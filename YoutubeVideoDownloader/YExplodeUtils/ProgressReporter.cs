using System;

namespace YoutubeVideoDownloader.YExplodeUtils {
	internal class ProgressReporter : IProgress<double> {

		private readonly Action<double> Callback;

		public ProgressReporter(Action<double> callback) {
			Callback = callback;
		}

		public void Report(double value) => Callback?.Invoke(value);
	}
}
