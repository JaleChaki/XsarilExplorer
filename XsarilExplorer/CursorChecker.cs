using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XsarilExplorer {
	public static class CursorChecker {

		[StructLayout(LayoutKind.Sequential)]
		private struct POINT {

			public int X;

			public int Y;

		}

		[DllImport("user32.dll")]
		private static extern bool GetCursorPos(out POINT point);

		public static bool Check(Control c) {
			if (!GetCursorPos(out POINT p)) {
				return false;
			}
			return (p.X > c.Left && p.Y > c.Top) && (p.X < c.Left + c.Width && p.Y < c.Top + c.Height);
		}

	}
}
