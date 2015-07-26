using System;
using Android.Content;

namespace OpenTK.Android.Test
{
	class GLView1 : AndroidGameView
	{
		Random r = new Random ();

		public GLView1 (Context context) : base (context)
		{
		}

		
		protected override void OnLoad (EventArgs e)
		{
			base.OnLoad (e);
		}


		// This gets called on each frame render
		protected override void OnRenderFrame (FrameEventArgs e)
		{
			// you only need to call this if you have delegates
			// registered that you want to have called
			base.OnRenderFrame (e);

			if (SupportsFullGL) {
				Console.WriteLine(Graphics.OpenGL4.GL.GetString (Graphics.OpenGL4.StringName.Version));
				Graphics.OpenGL4.GL.ClearColor (0f, (float)r.NextDouble (), 0f, 0f);
				Graphics.OpenGL4.GL.Clear (Graphics.OpenGL4.ClearBufferMask.ColorBufferBit);
			} else {
				Graphics.ES20.GL.ClearColor ((float)r.NextDouble (), 0f, 0f, 0f);
				Graphics.ES20.GL.Clear (OpenTK.Graphics.ES20.ClearBufferMask.ColorBufferBit);
			}

			SwapBuffers ();
		}


	}
}

