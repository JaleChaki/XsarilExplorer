using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace YoutubeVideoDownloader.YExplodeUtils {
	public class DownloadVideoSeparatelyTask : IAsyncTask {

		private readonly string Path;

		private readonly IStreamInfo StreamInfo;

		private readonly IProgress<double> ReportingCallback;

		private readonly Action CompletedCallback;

		private readonly YoutubeClient Client;

		private readonly StreamManifest Manifest;

		public DownloadVideoSeparatelyTask(YoutubeClient client, string path, Action<double> progressChangedCallback, Action completeCallback, StreamManifest manifest, IStreamInfo stream) {
			ReportingCallback = new ProgressReporter(progressChangedCallback);
			StreamInfo = stream;
			Path = path;
			Client = client;
			Manifest = manifest;
			CompletedCallback = completeCallback;
		}

		public void Complete() {
			CompletedCallback?.Invoke();
		}

		public void Run() {
			RunAsync().GetAwaiter().GetResult();
		}

		private async Task RunAsync() {
			List<IStreamInfo> streams = new List<IStreamInfo>();
			streams.Add(StreamInfo);
			streams.Add(Manifest.GetAudioOnly().First());
			await Client.Videos.DownloadAsync(streams, new ConversionRequestBuilder(Path).SetFFmpegPath("FFMpeg/ffmpeg.exe").Build(), ReportingCallback);
			if (Path.EndsWith("mp3")) {
				string trueName = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Path), System.IO.Path.GetFileNameWithoutExtension(Path) + ".webm");
				//string trueName = System.IO.Path.ChangeExtension(Path, ".webm");
				File.Move(Path, trueName);
				//Console.WriteLine(Directory.GetCurrentDirectory());
				Process p = Process.Start(Directory.GetCurrentDirectory() + "/FFMpeg/ffmpeg.exe", "-i \"" + trueName + "\" \"" + Path + "\"");
				p.WaitForExit();
				File.Delete(trueName);
			}
		}
	}
}
