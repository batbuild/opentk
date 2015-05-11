using System;
using System.Runtime.InteropServices;
using OpenTK.Platform.Egl;

namespace OpenTK.Android
{
	internal static class EntryPointHelper {

		public static RenderableFlags Renderable;
		static IntPtr ES1 = DL.Open("/system/lib/libGLESv1_CM.so", DLOpenFlags.Lazy);
		static IntPtr ES2 = DL.Open("/system/lib/libGLESv2.so", DLOpenFlags.Lazy);
		
#if __ANDROID__
		static IntPtr GL = DL.Open("/system/lib/libglcore.so", DLOpenFlags.Lazy);
#else
		static IntPtr GL = DL.Open("/system/lib/libgl.so", DLOpenFlags.Lazy);
#endif

		public static IntPtr GetAddress(IntPtr function)
		{
			// Try loading a static export from ES1 or ES2
			IntPtr address = GetStaticAddress(function, Renderable);

			// If a static export is not available, try retrieving an extension
			// function pointer with eglGetProcAddress
			if (address == IntPtr.Zero)
			{
				address = Egl.GetProcAddress(function);
			}

			return address;
		}

		public static IntPtr GetStaticAddress(IntPtr function, RenderableFlags renderable)
		{
			if ((renderable & RenderableFlags.ES) != 0 && ES1 != IntPtr.Zero)
			{
				return DL.Symbol(ES1, function);
			}
			else if ((renderable & RenderableFlags.ES2) != 0 && ES2 != IntPtr.Zero)
			{
				return DL.Symbol(ES2, function);
			}
			else if ((renderable & RenderableFlags.GL) != 0 && GL != IntPtr.Zero)
			{
				return DL.Symbol(GL, function);
			}
			return IntPtr.Zero;
		}
	}


	internal class DL
	{
		const string lib = "/system/lib/libdl.so";

		[DllImport(lib, EntryPoint = "dlopen")]
		internal static extern IntPtr Open(string filename, DLOpenFlags flags);

		[DllImport(lib, EntryPoint = "dlclose")]
		internal static extern int Close(IntPtr handle);

		[DllImport(lib, EntryPoint = "dlsym")]
		internal static extern IntPtr Symbol(IntPtr handle, IntPtr name);
	}

	internal enum DLOpenFlags
	{
		Lazy = 0x0001,
		Now = 0x0002,
		Global = 0x0100,
		Local = 0x0000,
	}
}

