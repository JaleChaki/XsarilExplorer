using System;
using System.IO;
using System.Windows.Forms;

namespace YoutubeVideoDownloader {
	static class Program {
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (args == null || args.Length == 0) {
				MessageBox.Show("Нужно указать URL видео в качестве параметра", "Ошибка", MessageBoxButtons.OK);
				return;
			}
			Application.Run(new VideoDownloadForm(args[0]));
		}
	}
}
