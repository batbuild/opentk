using System;
using Android.Views;
using Android.Util;
using Size = System.Drawing.Size;
using System.Threading.Tasks;
using System.Threading;
//using Javax.Microedition.Khronos.Egl;
using Android.Runtime;
using System.Collections.Generic;
using Android.Content;
using Android.App;
using Android.Opengl;
using OpenTK.Graphics;
using OpenTK.Platform.Egl;

namespace OpenTK.Android
{
	[CLSCompliant(false)]
	public class AndroidGameView : SurfaceView, ISurfaceHolderCallback, View.IOnTouchListener
	{
		bool disposed = false;
		ISurfaceHolder mHolder;
		Size size;
		object lockObject = new object ();

		bool surfaceAvailable;

		int surfaceWidth;
		int surfaceHeight;

		bool glSurfaceAvailable;
		bool glContextAvailable;
		bool lostglContext;
		private bool isPaused;
		private bool isExited = false;
		System.Diagnostics.Stopwatch stopWatch;
		double tick = 0;

		bool loaded = false;

		Task renderTask;
		CancellationTokenSource cts = null;

		const int EglContextClientVersion = 0x3098;

		public bool IsResuming { get; private set; }

		public bool SupportsFullGL { get; private set; }

		public AndroidGameView (Context context)
			: base (context)
		{
			Init ();
		}

		private void Init ()
		{
			// default
			mHolder = Holder;
			// Add callback to get the SurfaceCreated etc events
			mHolder.AddCallback (this);
			mHolder.SetType (SurfaceType.Gpu);
		}

		public void SurfaceChanged (ISurfaceHolder holder, global::Android.Graphics.Format format, int width, int height)
		{
			lock (lockObject) {
				Log.Verbose ("AndroidGameView", "SurfaceChanged");
				surfaceWidth = Width;
				surfaceHeight = Height;
			}
		}

		public void SurfaceCreated (ISurfaceHolder holder)
		{
			lock (lockObject) {
				Log.Verbose ("AndroidGameView", "SurfaceCreated");
				surfaceWidth = Width;
				surfaceHeight = Height;
				surfaceAvailable = true;
				Monitor.PulseAll (lockObject);
			}
		}

		public void SurfaceDestroyed (ISurfaceHolder holder)
		{
			lock (lockObject) {
				Log.Verbose ("AndroidGameView", "SurfaceDestroyed");
				surfaceAvailable = false;
				Monitor.PulseAll (lockObject);
				while (glSurfaceAvailable) {
					Monitor.Wait (lockObject);
				}
			}
		}

		public bool OnTouch (View v, MotionEvent e)
		{
			return true;
		}

		public virtual void SwapBuffers ()
		{
			EnsureUndisposed ();
			if (!EGL14.EglSwapBuffers (eglDisplay, eglSurface)) {
				if (EGL14.EglGetError () == EGL14.EglContextLost) {
					if (lostglContext)
						System.Diagnostics.Debug.WriteLine ("Lost EGL context" + GetErrorAsString ());
					lostglContext = true;
				}
			}

		}

		public virtual void MakeCurrent ()
		{
			EnsureUndisposed ();
			if (!EGL14.EglMakeCurrent (eglDisplay, eglSurface,
				eglSurface, eglContext)) {
				System.Diagnostics.Debug.WriteLine ("Error Make Current" + GetErrorAsString ());
			}

		}

		public virtual void ClearCurrent()
		{
			EnsureUndisposed ();
			if (!EGL14.EglMakeCurrent (eglDisplay, EGL14.EglNoSurface,
				EGL14.EglNoSurface, EGL14.EglNoContext)) {
				System.Diagnostics.Debug.WriteLine ("Error Clearing Current" + GetErrorAsString ());
			}
		}

		double updates;

		public bool LogFPS { get; set; }
		public bool RenderOnUIThread {get;set;}

		public virtual void Run ()
		{
			cts = new CancellationTokenSource ();
			if (LogFPS) {
				targetFps = currentFps = 0;
				avgFps = 1;
			}
			updates = 0;
			var syncContext = new SynchronizationContext ();
			renderTask = Task.Factory.StartNew (() => {
				if (RenderOnUIThread) {
					syncContext.Send((s) => {
						RenderLoop (cts.Token);
					}, null);
				} else
					RenderLoop (cts.Token);
			}, cts.Token)
				.ContinueWith ((t) => {
					OnStopped (EventArgs.Empty);
				});
		}

		public virtual void Run (double updatesPerSecond)
		{
			cts = new CancellationTokenSource ();
			if (LogFPS) {
				avgFps = targetFps = currentFps = updatesPerSecond;
			}
			updates = 1000 / updatesPerSecond;
			var syncContext = new SynchronizationContext ();
			renderTask = Task.Factory.StartNew (() => {
				if (RenderOnUIThread) {
					syncContext.Send((s) => {
						RenderLoop (cts.Token);
					}, null);
				} else
					RenderLoop (cts.Token);
			}, cts.Token);
		}

		public virtual void Pause ()
		{
			EnsureUndisposed ();
			lock (lockObject) {
				isPaused = true;
				Monitor.PulseAll (lockObject);
			}
		}

		public virtual void Resume ()
		{
			EnsureUndisposed ();
			lock (lockObject) {
				if (isPaused) {
					isPaused = false;
					Monitor.PulseAll (lockObject);
				}
				try {
					if (!IsFocused)
						RequestFocus ();
				} catch {
				}
			}
		}

		protected override void Dispose (bool disposing)
		{
			if (disposing) {
				Stop ();
			}
			base.Dispose (disposing);
		}

		public async void Stop ()
		{
			Log.Verbose ("AndroidGameView", "Stop() Called!!!!!");
			EnsureUndisposed ();
			if (cts != null) {
				lock (lockObject) {
					Monitor.PulseAll (lockObject);
				}
				cts.Cancel ();
				while (!isExited) {
					lock (lockObject) {
						Monitor.PulseAll (lockObject);

					}
					await Task.Delay (100);
				}
				//renderTask.Wait ();
				Log.Verbose ("AndroidGameView", "Stop() Completed!!!!!");
			}
		}

		FrameEventArgs renderEventArgs = new FrameEventArgs ();

		protected void RenderLoop (CancellationToken token)
		{
			try {
				stopWatch = System.Diagnostics.Stopwatch.StartNew ();
				tick = 0;
				prevUpdateTime = DateTime.Now;
				while (!cts.IsCancellationRequested) {
					if (!IsGLSurfaceAvailable ()) {
						break;
					}

					try {
						RunIteration (token);
					} catch (Exception ex) {
						Log.Error ("AndroidGameView", "GL Exception occured during RunIteration {0}", ex.Message);
					}

					if (updates > 0) {
						var t = updates - (stopWatch.Elapsed.TotalMilliseconds - tick);
						if (t > 0) {
							if (LogFPS) {
								Log.Verbose ("AndroidGameView", "took {0:F2}ms, should take {1:F2}ms, sleeping for {2:F2}", stopWatch.Elapsed.TotalMilliseconds - tick, updates, t);
							}
							if (token.IsCancellationRequested)
								return;
						}
					}
				}
				Log.Verbose ("AndroidGameView", "RenderLoop exited");
			} catch (Exception ex) {
				Log.Error ("AndroidGameView", ex.ToString ());
			} finally {
				lock (lockObject) {
					isExited = true;
					cts = null;
					if (glSurfaceAvailable)
						DestroyGLSurface ();
					if (glContextAvailable) {
						DestroyGLContext ();
						ContextLostInternal ();
					}
				}
			}
		}

		DateTime prevUpdateTime;
		DateTime prevRenderTime;
		DateTime curUpdateTime;
		DateTime curRenderTime;
		FrameEventArgs updateEventArgs = new FrameEventArgs ();

		void UpdateFrameInternal (FrameEventArgs e)
		{
			OnUpdateFrame (e);
			if (UpdateFrame != null)
				UpdateFrame (this, e);
		}

		protected virtual void OnUpdateFrame (FrameEventArgs e)
		{

		}

		// this method is called on the main thread
		void RunIteration (CancellationToken token)
		{
			if (token.IsCancellationRequested)
				return;

			curUpdateTime = DateTime.Now;
			if (prevUpdateTime.Ticks != 0) {
				var t = (curUpdateTime - prevUpdateTime).TotalMilliseconds;
				updateEventArgs.Time = t < 0 ? 0 : t;
			}
			try {
				UpdateFrameInternal (updateEventArgs);
			} catch (Exception) {
				// ignore it..
			}

			prevUpdateTime = curUpdateTime;

			curRenderTime = DateTime.Now;
			if (prevRenderTime.Ticks == 0) {
				var t = (curRenderTime - prevRenderTime).TotalMilliseconds;
				renderEventArgs.Time = t < 0 ? 0 : t;
			}

			RenderFrameInternal (renderEventArgs);
			prevRenderTime = curRenderTime;

		}

		void RenderFrameInternal (FrameEventArgs e)
		{
			if (LogFPS) {
				Mark ();
			}
			OnRenderFrame (e);
			if (RenderFrame != null)
				RenderFrame (this, e);
		}

		protected virtual void OnRenderFrame (FrameEventArgs e)
		{

		}

		int frames = 0;
		double prev = 0;
		double avgFps = 0;
		double currentFps = 0;
		double targetFps = 0;

		void Mark ()
		{
			double cur = stopWatch.Elapsed.TotalMilliseconds;
			if (cur < 2000) {
				return;
			}
			frames++;

			if (cur - prev >= 995) {
				avgFps = 0.8 * avgFps + 0.2 * frames;

				Log.Verbose ("AndroidGameView", "frames {0} elapsed {1}ms {2:F2} fps",
					frames,
					cur - prev,
					avgFps);

				frames = 0;
				prev = cur;
			}
		}

		protected void EnsureUndisposed ()
		{
			if (disposed)
				throw new ObjectDisposedException ("");
		}

		protected void DestroyGLContext ()
		{
			Log.Verbose ("AndroidGameView", "DestroyGLContext");
			if (eglContext != null) {
				if (!EGL14.EglDestroyContext (eglDisplay, eglContext))
					throw new Exception ("Could not destroy EGL context" + GetErrorAsString ());
				eglContext = null;
			}
			if (eglDisplay != null) {
				if (!EGL14.EglTerminate (eglDisplay))
					throw new Exception ("Could not terminate EGL connection" + GetErrorAsString ());
				eglDisplay = null;
			}

			glContextAvailable = false;

		}

		void DestroyGLSurfaceInternal ()
		{
			if (!(eglSurface == null || eglSurface == EGL14.EglNoSurface)) {
				if (!EGL14.EglMakeCurrent (eglDisplay, EGL14.EglNoSurface,
					EGL14.EglNoSurface, EGL14.EglNoContext)) {
					Log.Verbose ("AndroidGameView", "Could not unbind EGL surface" + GetErrorAsString ());
				}

				if (!EGL14.EglDestroySurface (eglDisplay, eglSurface)) {
					Log.Verbose ("AndroidGameView", "Could not destroy EGL surface" + GetErrorAsString ());
				}
			}
			eglSurface = null;
		}

		protected virtual void DestroyGLSurface ()
		{
			Log.Verbose ("AndroidGameView", "DestroyGLSurface");
			DestroyGLSurfaceInternal ();
			glSurfaceAvailable = false;
			Monitor.PulseAll (lockObject);
		}

		internal struct SurfaceConfig {
			public int Red;
			public int Green;
			public int Blue;
			public int Alpha;
			public int Depth;
			public int Stencil;

			public int[] ToConfigAttribs(int renderableType = 4) {

				return new int[] {
					EGL14.EglSurfaceType, EGL14.EglWindowBit,
					EGL14.EglRedSize, Red,
					EGL14.EglGreenSize, Green,
					EGL14.EglBlueSize, Blue,
					EGL14.EglAlphaSize, Alpha,
					EGL14.EglDepthSize, Depth,
					EGL14.EglStencilSize, Stencil,
					EGL14.EglRenderableType, renderableType,
					EGL14.EglNone
				};
			}

			public override string ToString ()
			{
				return string.Format ("Red:{0} Green:{1} Blue:{2} Alpha:{3} Depth:{4} Stencil:{5}", Red, Green, Blue, Alpha, Depth, Stencil);
			}
		}

		protected void CreateGLContext ()
		{
			Log.Verbose ("AndroidGameView", "CreateGLContext");
			lostglContext = false;

			try {

				SupportsFullGL = OpenTK.Platform.Egl.Egl.BindAPI (OpenTK.Platform.Egl.RenderApi.GL);
				if (!SupportsFullGL)
					OpenTK.Platform.Egl.Egl.BindAPI (OpenTK.Platform.Egl.RenderApi.ES);
			}catch {
			}

			//eglDisplay = egl.EglGetDisplay (EGL10.EglDefaultDisplay);
			eglDisplay = EGL14.EglGetDisplay(EGL14.EglDefaultDisplay);
			if (eglDisplay == EGL14.EglNoDisplay)
				throw new Exception ("Could not get EGL display" + GetErrorAsString ());

			int[] version = new int[2];
			//if (!egl.EglInitialize (eglDisplay, version))
			if (!EGL14.EglInitialize(eglDisplay, version, 0, version, 1))
				throw new Exception ("Could not initialize EGL display" + GetErrorAsString ());

			int depth = 0;
			int stencil = 0;
			List<SurfaceConfig> configs = new List<SurfaceConfig> ();
			if (depth > 0) {
				configs.Add (new SurfaceConfig () { Red = 8, Green = 8, Blue = 8, Alpha = 8, Depth = depth, Stencil = stencil });
				configs.Add (new SurfaceConfig () { Red = 5, Green = 6, Blue = 5, Depth = depth, Stencil = stencil });
				configs.Add (new SurfaceConfig () { Depth = depth, Stencil = stencil });
				if (depth > 16) {
					configs.Add (new SurfaceConfig () { Red = 8, Green = 8, Blue = 8, Alpha = 8, Depth = 16 });
					configs.Add (new SurfaceConfig () { Red = 5, Green = 6, Blue = 5, Depth = 16 });
					configs.Add (new SurfaceConfig () { Depth = 16 });
				}
			} else {
				configs.Add (new SurfaceConfig () { Red = 8, Green = 8, Blue = 8, Alpha = 8});
				configs.Add (new SurfaceConfig () { Red = 5, Green = 6, Blue = 5 });
			}
			configs.Add (new SurfaceConfig () { Red = 4, Green = 4, Blue = 4, Alpha = 0, Depth = 0, Stencil = 0 });
			int[] numConfigs = new int[1];
			EGLConfig[] results = new EGLConfig[1];

			int renderableType = SupportsFullGL ? OpenTK.Platform.Egl.Egl.OPENGL_BIT : OpenTK.Platform.Egl.Egl.OPENGL_ES2_BIT;

			foreach (var config in configs) {

				if (!EGL14.EglChooseConfig (eglDisplay, config.ToConfigAttribs(renderableType), 0, results, 0, 1, numConfigs, 0)) {
					continue;
				}
				Log.Verbose ("AndroidGameView", string.Format("Selected Config : {0}",config)); 
				break;
			}

			if (numConfigs [0] == 0)
				throw new Exception ("No valid EGL configs found" + GetErrorAsString ());
			eglConfig = results [0];


			const int EGL_CONTEXT_MAJOR_VERSION_KHR = 0x3098;
			const int EGL_CONTEXT_MINOR_VERSION_KHR = 0x30FB;
			const int EGL_CONTEXT_OPENGL_PROFILE_MASK_KHR = 0x30FD;
			const int EGL_CONTEXT_OPENGL_COMPATIBILITY_PROFILE_BIT_KHR = 0x00000002;

			int[] contextAttribs = new int[] 
			{ 
				EGL_CONTEXT_MAJOR_VERSION_KHR, 4,
				EGL_CONTEXT_OPENGL_PROFILE_MASK_KHR,
				EGL_CONTEXT_OPENGL_COMPATIBILITY_PROFILE_BIT_KHR,
				EGL14.EglNone };
			eglContext = EGL14.EglCreateContext (eglDisplay, eglConfig, EGL14.EglNoContext, contextAttribs, 0);
			int[] value = new int[2];

			if (eglContext == null || eglContext == EGL14.EglNoContext) {
				eglContext = null;
				throw new Exception ("Could not create EGL context" + GetErrorAsString ());
			}

			int majVer;
			if (EGL14.EglQueryContext(eglDisplay, eglContext, EGL_CONTEXT_MAJOR_VERSION_KHR, value, 0))
				majVer = value[0];

			int minVer;
			if (EGL14.EglQueryContext(eglDisplay, eglContext, EGL_CONTEXT_MINOR_VERSION_KHR, value, 0))
				minVer = value[0];

			glContextAvailable = true;
		}

		private string GetErrorAsString ()
		{
			switch (EGL14.EglGetError ()) {
			case EGL14.EglSuccess:
				return "Success";

			case EGL14.EglNotInitialized:
				return "Not Initialized";

			case EGL14.EglBadAccess:
				return "Bad Access";
			case EGL14.EglBadAlloc:
				return "Bad Allocation";
			case EGL14.EglBadAttribute:
				return "Bad Attribute";
			case EGL14.EglBadConfig:
				return "Bad Config";
			case EGL14.EglBadContext:
				return "Bad Context";
			case EGL14.EglBadCurrentSurface:
				return "Bad Current Surface";
			case EGL14.EglBadDisplay:
				return "Bad Display";
			case EGL14.EglBadMatch:
				return "Bad Match";
			case EGL14.EglBadNativePixmap:
				return "Bad Native Pixmap";
			case EGL14.EglBadNativeWindow:
				return "Bad Native Window";
			case EGL14.EglBadParameter:
				return "Bad Parameter";
			case EGL14.EglBadSurface:
				return "Bad Surface";

			default:
				return "Unknown Error";
			}
		}


		protected void CreateGLSurface ()
		{

			if (!glSurfaceAvailable)
				try {
				Log.Verbose ("AndroidGameView", "CreateGLSurface");
				// If there is an existing surface, destroy the old one
				DestroyGLSurfaceInternal ();

				int[] attribs_config = new int[]{
					EGL14.EglRenderBuffer, EGL14.EglBackBuffer,
					EGL14.EglNone
				};
				eglSurface = EGL14.EglCreateWindowSurface (eglDisplay, eglConfig, (Java.Lang.Object)this.Holder, attribs_config, 0);
				if (eglSurface == null || eglSurface == EGL14.EglNoSurface)
					throw new Exception ("Could not create EGL window surface" + GetErrorAsString ());

				if (!EGL14.EglMakeCurrent (eglDisplay, eglSurface, eglSurface, eglContext))
					throw new Exception ("Could not make EGL current" + GetErrorAsString ());

				glSurfaceAvailable = true;

				// DEAN: is this a valid way to get the surface size? Returns the right values for us but not sure
				// how this will behave on other devices.
				Size = new Size(RootView.Width, RootView.Height);

			} catch (Exception ex) {
				Log.Error ("AndroidGameView", ex.ToString ());
				glSurfaceAvailable = false;
			}
		}

		protected EGLSurface CreatePBufferSurface (EGLConfig config, int[] attribList)
		{
			//            IEGL10 egl = EGLContext.EGL.JavaCast<IEGL10> ();
			EGLSurface result = EGL14.EglCreatePbufferSurface (eglDisplay, config, attribList, 0);
			if (result == null || result == EGL14.EglNoSurface)
				throw new Exception ("EglCreatePBufferSurface");
			return result;
		}

		protected void ContextSetInternal ()
		{
			if (lostglContext)
			{

			}
			OnContextSet (EventArgs.Empty);
		}

		protected void ContextLostInternal ()
		{
			OnContextLost (EventArgs.Empty);
		}

		protected virtual void OnContextLost (EventArgs eventArgs)
		{

		}

		protected bool IsGLSurfaceAvailable ()
		{
			lock (lockObject) {
				// we want to wait until we have a valid surface
				// this is not called from the UI thread but on
				// the background rendering thread
				while (!cts.IsCancellationRequested) {
					//Log.Verbose ("AndroidGameView", "IsGLSurfaceAvailable {0} IsPaused {1} lostcontext {2} surfaceAvailable {3} contextAvailable {4} ThreadID {5}",
					//    glSurfaceAvailable, isPaused, lostglContext, surfaceAvailable, glContextAvailable,Thread.CurrentThread.ManagedThreadId);
					if (glSurfaceAvailable && (isPaused || !surfaceAvailable)) {
						// Surface we are using needs to go away
						DestroyGLSurface ();
						if (loaded)
							OnUnload (EventArgs.Empty);

					} else if ((!glSurfaceAvailable && !isPaused && surfaceAvailable) || lostglContext) {
						// We can (re)create the EGL surface (not paused, surface available)
						if (glContextAvailable && !lostglContext) {
							try {
								CreateGLSurface ();
							} catch (Exception ex) {
								// We failed to create the surface for some reason
								Log.Verbose ("AndroidGameView", ex.ToString ());
							}
						}

						if (!glSurfaceAvailable || lostglContext) { // Start or Restart due to context loss
							bool contextLost = false;
							if (lostglContext || glContextAvailable) {
								// we actually lost the context
								// so we need to free up our existing 
								// objects and re-create one.
								DestroyGLContext ();
								contextLost = true;
								Log.Verbose ("AndroidGameView", "ContentLostInternal");
								ContextLostInternal ();
							}

							CreateGLContext ();
							CreateGLSurface ();

							if (!SupportsFullGL)
							{
								OpenTK.Android.EntryPointHelper.Renderable = OpenTK.Platform.Egl.RenderableFlags.ES2;
								new OpenTK.Graphics.ES20.GL().LoadEntryPoints();
							}
							else
							{
								OpenTK.Android.EntryPointHelper.Renderable = OpenTK.Platform.Egl.RenderableFlags.GL;
								var contextHandle = new ContextHandle(EGL14.EglGetCurrentContext().Handle);
								var context = new GraphicsContext(contextHandle, Egl.GetProcAddress, () => contextHandle);
								new OpenTK.Graphics.OpenGL.GL().LoadEntryPoints();
							}

							if (!loaded && glContextAvailable)
								OnLoad (EventArgs.Empty);

							if (contextLost && glContextAvailable) {
								Log.Verbose ("AndroidGameView", "ContentSetInternal");
								// we lost the gl context, we need to let the programmer
								// know so they can re-create textures etc.
								ContextSetInternal ();
							}
						}
					}

					// If we have a GL surface we can continue 
					// rednering
					if (glSurfaceAvailable) {
						return true;
					} else {
						// if we dont we need to wait until we get
						// a surfaceCreated event or some other 
						// event from the ISurfaceHolderCallback
						// so we can create a new GL surface.
						if (cts.IsCancellationRequested)
							break;
						if (((Activity)Context).IsFinishing)
							return false;
						Log.Verbose ("AndroidGameView", "IsGLSurfaceAvailable entering wait state");
						Monitor.Wait (lockObject);
						Log.Verbose ("AndroidGameView", "IsGLSurfaceAvailable exiting wait state");
						continue;
					}
				}
				Log.Verbose ("AndroidGameView", "IsGLSurfaceAvailable exited!!!!!");
				return false;
			}
		}

		protected virtual void OnUnload (EventArgs eventArgs)
		{

		}

		protected virtual void OnContextSet (EventArgs eventArgs)
		{

		}

		protected virtual void OnLoad (EventArgs eventArgs)
		{

		}

		protected virtual void OnStopped (EventArgs eventArgs)
		{

		}

		#region Key and Motion

		public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
		{
			/*
            if (GamePad.OnKeyDown(keyCode, e))
                return true;

            Keyboard.KeyDown(keyCode);
            // we need to handle the Back key here because it doesnt work any other way
            if (keyCode == Keycode.Back)
                GamePad.Back = true;

            if (keyCode == Keycode.VolumeUp)
            {
                AudioManager audioManager = (AudioManager)Context.GetSystemService(Context.AudioService);
                audioManager.AdjustStreamVolume(Stream.Music, Adjust.Raise, VolumeNotificationFlags.ShowUi);
                return true;
            }

            if (keyCode == Keycode.VolumeDown)
            {
                AudioManager audioManager = (AudioManager)Context.GetSystemService(Context.AudioService);
                audioManager.AdjustStreamVolume(Stream.Music, Adjust.Lower, VolumeNotificationFlags.ShowUi);
                return true;
            }*/

			return true;
		}

		public override bool OnKeyUp(Keycode keyCode, KeyEvent e)
		{
			/*
            if (GamePad.OnKeyUp(keyCode, e))
                return true;
            Keyboard.KeyUp(keyCode);*/
			return true;
		}

		public override bool OnGenericMotionEvent(MotionEvent e)
		{
			/*
            if (GamePad.OnGenericMotionEvent(e))
                return true;
*/
			return base.OnGenericMotionEvent(e);
		}

		#endregion

		#region Properties

		//private  IEGL10 egl;
		private  EGLDisplay eglDisplay;
		private  EGLConfig eglConfig;
		private  EGLContext eglContext;
		private  EGLSurface eglSurface;

		/// <summary>The visibility of the window. Always returns true.</summary>
		/// <value></value>
		/// <exception cref="T:System.ObjectDisposed">The instance has been disposed</exception>
		public virtual bool Visible {
			get {
				EnsureUndisposed ();
				return true;
			}
			set {
				EnsureUndisposed ();
			}
		}

		/// <summary>The size of the current view.</summary>
		/// <value>A <see cref="T:System.Drawing.Size" /> which is the size of the current view.</value>
		/// <exception cref="T:System.ObjectDisposed">The instance has been disposed</exception>
		public virtual Size Size {
			get {
				EnsureUndisposed ();
				return size;
			}
			set {
				EnsureUndisposed ();
				if (size != value) {
					size = value;
					OnResize (EventArgs.Empty);
				}
			}
		}

		private void OnResize (EventArgs eventArgs)
		{

		}

		#endregion

		public event FrameEvent RenderFrame;
		public event FrameEvent UpdateFrame;

		public delegate void FrameEvent (object sender,FrameEventArgs e);

		public class FrameEventArgs : EventArgs
		{
			double elapsed;

			/// <summary>
			/// Constructs a new FrameEventArgs instance.
			/// </summary>
			public FrameEventArgs ()
			{
			}

			/// <summary>
			/// Constructs a new FrameEventArgs instance.
			/// </summary>
			/// <param name="elapsed">The amount of time that has elapsed since the previous event, in seconds.</param>
			public FrameEventArgs (double elapsed)
			{
				Time = elapsed;
			}

			/// <summary>
			/// Gets a <see cref="System.Double"/> that indicates how many seconds of time elapsed since the previous event.
			/// </summary>
			public double Time {
				get { return elapsed; }
				internal set {
					if (value < 0)
						throw new ArgumentOutOfRangeException ();
					elapsed = value;
				}
			}
		}

		public BackgroundContext CreateBackgroundContext()
		{
			return new BackgroundContext (this);
		}

		public class BackgroundContext {

			EGLContext eglContext;
			AndroidGameView view;
			EGLSurface surface;

			public BackgroundContext (AndroidGameView view)
			{
				this.view = view;
				int[] contextAttribs = new int[] { EglContextClientVersion, 2, EGL14.EglNone };
				eglContext = EGL14.EglCreateContext (view.eglDisplay, view.eglConfig, view.eglContext, contextAttribs, 0);
				if (eglContext == null || eglContext == EGL14.EglNoContext) {
					eglContext = null;
					throw new Exception ("Could not create EGL context" + view.GetErrorAsString ());
				}
				int[] pbufferAttribList = new int [] { EGL14.EglWidth, 64, EGL14.EglHeight, 64, EGL14.EglNone };
				surface = view.CreatePBufferSurface (view.eglConfig, pbufferAttribList);
				if (surface == EGL14.EglNoSurface)
					throw new Exception ("Could not create Pbuffer Surface" + view.GetErrorAsString ());
			}

			public void MakeCurrent() {
				view.ClearCurrent ();
				if (!EGL14.EglMakeCurrent (view.eglDisplay, surface, surface, eglContext)) 
				{
					Log.Error ("AndroidGameView", "Error in MakeCurret, " + EGL14.EglGetError ());
					Console.WriteLine ("Error in MakeCurret, " + EGL14.EglGetError ());
				}
			}
		}
	}
}
