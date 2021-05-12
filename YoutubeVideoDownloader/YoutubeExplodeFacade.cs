using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeVideoDownloader.YExplodeUtils;

namespace YoutubeVideoDownloader {
	public class YoutubeExplodeFacade {

		private YoutubeClient Client;

		private List<IAsyncTask> Tasks;

		private List<IAsyncTask> CompletedTasks;

		private object Sync = new object();

		private Thread WorkerThread;

		public YoutubeExplodeFacade() {
			Client = new YoutubeClient();
			CompletedTasks = new List<IAsyncTask>();
			Tasks = new List<IAsyncTask>();

			WorkerThread = new Thread(() => Worker()) {
				IsBackground = true
			};
			WorkerThread.Start();
		}

		private void Worker() {
			while (true) {
				List<IAsyncTask> clonedTasks = new List<IAsyncTask>();
				lock (Sync) {
					foreach (var t in Tasks) {
						clonedTasks.Add(t);
					}
					Tasks.Clear();
				}
				Parallel.For(0, clonedTasks.Count, (i) => {
					clonedTasks[i].Run();
				});
				foreach (var t in clonedTasks) {
					CompletedTasks.Add(t);
				}
				Thread.Sleep(150);
			}
		}

		public void Update() {
			lock (Sync) {
				foreach (var t in CompletedTasks) {
					t.Complete();
				}
				CompletedTasks.Clear();
			}
		}

		public void GetVideo(string url, Action<VideoInfo> completeCallback, Action<GetVideoStatus> statusChangeCallback) {
			lock (Sync) {
				Tasks.Add(new GetVideoWithManifestTask(Client, url, completeCallback, statusChangeCallback));
			}
		}

		public void DownloadVideo(string path, StreamManifest manifest, IStreamInfo streamInfo, bool includeAudio = false, Action<double> progressChangedCallback = null, Action completeCallback = null) {
			lock (Sync) {
				if (streamInfo is VideoOnlyStreamInfo && includeAudio) {
					Tasks.Add(new DownloadVideoSeparatelyTask(Client, path, progressChangedCallback, completeCallback, manifest, streamInfo));
				} else {
					Tasks.Add(new DownloadVideoTask(Client, path, streamInfo, progressChangedCallback, completeCallback));
				}
			}
		}

		public void Stop() {
			lock (Sync) {
				WorkerThread.Abort();
			}
		}

	}
}
