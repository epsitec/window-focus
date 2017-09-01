//	Copyright © 2017, EPSITEC SA, CH-1400 Yverdon-les-Bains, Switzerland
//	Author: Pierre ARNAUD, Maintainer: Pierre ARNAUD

using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public static class Native
	{
		[DllImport ("user32.dll", SetLastError = true)]
		public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int processId);

		[DllImport ("user32.dll", SetLastError = true)]
		public static extern bool AttachThreadInput(int idAttach, int idAttachTo, int mode);

		[DllImport ("user32.dll", SetLastError = true)]
		public static extern bool SetActiveWindow(IntPtr hwnd);

		[DllImport ("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr child, IntPtr parent);

		[DllImport ("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr hwnd);

		[DllImport ("user32.dll")]
		public static extern IntPtr SetWindowLong(IntPtr hwnd, WindowLongIndex index, IntPtr handle);

		[DllImport ("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommand command);
	}
}
