using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win32;

namespace AppBob
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent ();

			this.SizeChanged += this.Form1_SizeChanged;
			this.label1.Text = "Owner set";

			Native.SetWindowLong (this.Handle, WindowLongIndex.GWLP_HWNDPARENT, Program.Owner);
		}

		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			switch (this.WindowState)
			{
				case FormWindowState.Minimized:
					Native.SetWindowLong (this.Handle, WindowLongIndex.GWLP_HWNDPARENT, IntPtr.Zero);
					this.label1.Text = "Owner cleared";
					break;

				case FormWindowState.Normal:
					Native.SetWindowLong (this.Handle, WindowLongIndex.GWLP_HWNDPARENT, Program.Owner);
					this.label1.Text = "Owner restored";
					break;
			}
		}
	}
}
