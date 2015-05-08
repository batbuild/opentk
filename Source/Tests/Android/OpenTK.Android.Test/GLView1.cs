using System;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Platform;

using Android.Views;
using Android.Content;
using Android.Util;

namespace OpenTK.Android.Test
{
	class GLView1 : AndroidGameView
	{
		Random r = new Random ();

		public GLView1 (Context context) : base (context)
		{
		}

		// This gets called when the drawing surface is ready
		protected override void OnLoad (EventArgs e)
		{
			base.OnLoad (e);

			// Run the render loop
			//Run ();
		
		}


		protected override void OnUpdateFrame (FrameEventArgs e)
		{
			base.OnUpdateFrame (e);
		}
		// This gets called on each frame render
		protected override void OnRenderFrame (FrameEventArgs e)
		{
			// you only need to call this if you have delegates
			// registered that you want to have called
			base.OnRenderFrame (e);

			if (SupportsFullGL) {
				OpenTK.Graphics.OpenGL4.GL.ClearColor (0f, (float)r.NextDouble (), 0f, 0f);
				OpenTK.Graphics.OpenGL4.GL.Clear (OpenTK.Graphics.OpenGL4.ClearBufferMask.ColorBufferBit);
			} else {
				OpenTK.Graphics.ES20.GL.ClearColor ((float)r.NextDouble (), 0f, 0f, 0f);
				OpenTK.Graphics.ES20.GL.Clear (OpenTK.Graphics.ES20.ClearBufferMask.ColorBufferBit);
			}

			SwapBuffers ();
		}


	}
}

