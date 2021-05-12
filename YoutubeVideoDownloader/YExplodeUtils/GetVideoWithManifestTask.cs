using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace YoutubeVideoDownloader.YExplodeUtils {
	public class GetVideoWithManifestTask : IAsyncTask {

		private readonly Action<VideoInfo> CompletedCallback;

		private readonly Action<GetVideoStatus> StatusChangeCallback;

		private readonly YoutubeClient Client;

		private readonly string Url;

		private Video Result;

		private Bitmap Preview;

		private StreamManifest Manifest;

		public GetVideoWithManifestTask(YoutubeClient client, string url, Action<VideoInfo> completedCallback, Action<GetVideoStatus> statusChangeCallback = null) {
			Client = client;
			Url = url;
			CompletedCallback = completedCallback;
			StatusChangeCallback = statusChangeCallback;
		}

		public void Complete() {
			CompletedCallback?.Invoke(new VideoInfo(Result, Manifest, Preview));
		}

		public void Run() {
			RunAsync().GetAwaiter().GetResult();
		}

		private async Task RunAsync() {
			StatusChangeCallback?.Invoke(GetVideoStatus.GetVideo);
			Console.WriteLine("Get video");
			Result = await Client.Videos.GetAsync(Url);
			Console.WriteLine("Get manifest");
			StatusChangeCallback?.Invoke(GetVideoStatus.GetManifest);
			Console.WriteLine("Get prev");
			Manifest = await Client.Videos.Streams.GetManifestAsync(Result.Id);
			StatusChangeCallback?.Invoke(GetVideoStatus.GetThumbnail);

			using (WebClient client = new WebClient()) {
				string thumbnailUrl = Result.Thumbnails.MaxResUrl;
				Stream s = null;
				try {
					s = client.OpenRead(thumbnailUrl);
				}
				catch (WebException) {
					thumbnailUrl = Result.Thumbnails.MediumResUrl;
				}
				finally {
					s?.Dispose();
				}

				//client.DownloadFile(thumbnailUrl, "temp.jpg");
				using (Stream stream = client.OpenRead(thumbnailUrl)) {
					Preview = new Bitmap(stream);
					//stream.
				}
			}
			StatusChangeCallback?.Invoke(GetVideoStatus.Completed);

		}
	}
}
