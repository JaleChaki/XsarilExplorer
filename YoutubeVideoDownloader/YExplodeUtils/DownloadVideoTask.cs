using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeVideoDownloader.YExplodeUtils {
	public class DownloadVideoTask : IAsyncTask {

		private readonly string Path;

		private readonly IStreamInfo StreamInfo;

		private readonly IProgress<double> ReportingCallback;

		private readonly Action CompletedCallback;

		private readonly YoutubeClient Client;

		public DownloadVideoTask(YoutubeClient client, string path, IStreamInfo stream, Action<double> progressChangedCallback, Action completeCallback) {
			ReportingCallback = new ProgressReporter(progressChangedCallback);
			StreamInfo = stream;
			Path = path;
			Client = client;
			CompletedCallback = completeCallback;
		}

		public void Complete() {
			CompletedCallback?.Invoke();
		}

		public void Run() {
			//Client.Videos.Streams.DownloadAsync(StreamInfo, Path, ReportingCallback).GetAwaiter().GetResult();
			
			RunAsync().GetAwaiter().GetResult();
		}

		private async Task RunAsync() {
			await Client.Videos.Streams.DownloadAsync(StreamInfo, Path, ReportingCallback);
			if (Path.EndsWith("mp3")) {
				string trueName = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Path), System.IO.Path.GetFileNameWithoutExtension(Path) + ".webm");
				//string trueName = System.IO.Path.ChangeExtension(Path, ".webm");
				File.Move(Path, trueName);
				//MessageBox.Show(Directory.GetCurrentDirectory());
				Process p = Process.Start(Directory.GetCurrentDirectory() + "/FFMpeg/ffmpeg.exe", "-i \"" + trueName + "\" \"" + Path + "\"");
				p.WaitForExit();
				File.Delete(trueName);
			}
		}
	}
}
