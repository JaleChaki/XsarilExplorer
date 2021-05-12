using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using XsarilExplorerApi;

namespace YoutubeVideoDownloader {
	public class YoutubeVideoDownloaderPlugin : Plugin {

		private Form UrlInputBox;

		public override void Init(IPluginEnvironment environment) {
			environment.RegisterService("Youtube download", (s) => ServiceCallback());
		}

		private void ServiceCallback() {
			if (UrlInputBox == null || UrlInputBox.IsDisposed) {
				UrlInputBox = new VideoUrlForm(this);
			}
			UrlInputBox.Show();
		}

		internal void ShowDownloadForm(string url) {
			//string cd = Directory.GetCurrentDirectory();
			//string processFilename = Path.Combine(PluginFolder, "YoutubeVideoDownloader.exe");
			var psi = new ProcessStartInfo("YoutubeVideoDownloader.exe", url) {
				WorkingDirectory = PluginFolder
			};
			Process.Start(psi);
			//Process.Start(new ProcessStartInfo(processFilename, url));
		}
	}
}
