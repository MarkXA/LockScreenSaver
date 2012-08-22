using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LockScreenSaver
{
	internal static class Program
	{
		[DllImport("user32.dll")]
		public static extern void LockWorkStation();

		[STAThread]
		private static void Main(string[] args)
		{
			if (args.Length < 1)
				return;

			var argument = args[0].ToLowerInvariant().Trim();

			if (argument.StartsWith("/c"))
			{
				MessageBox.Show(
					@"This screen saver has no options that you can set.",
					@"Lock screen saver",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			else if (argument.StartsWith("/s"))
			{
				LockWorkStation();
			}
		}
	}
}