using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win32;

namespace AppAlice
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent ();

			this.button2.Enabled = false;
			this.button3.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string args = this.Handle.ToString ();
			this.process = System.Diagnostics.Process.Start ("AppBob.exe", args);
			this.process.WaitForInputIdle ();
			this.button2.Enabled = true;
			this.button3.Enabled = true;
		}

		private Process process;

		private void button2_Click(object sender, EventArgs e)
		{
			var targetHwnd = this.process.MainWindowHandle;

			Native.SetActiveWindow (targetHwnd);
			
			/*
			var alicesProcessId = System.Diagnostics.Process.GetCurrentProcess ().Id;
			var bobsProcessId = this.process.Id;

			Native.AttachThreadInput (alicesProcessId, bobsProcessId, 1);
			Native.SetActiveWindow (targetHwnd);
			Native.AttachThreadInput (alicesProcessId, bobsProcessId, 0);
			*/
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var targetHwnd = this.process.MainWindowHandle;

			Native.ShowWindow (targetHwnd, ShowWindowCommand.Restore);
		}
	}
}
