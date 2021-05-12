using System.Drawing;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace YoutubeVideoDownloader.YExplodeUtils {
	public class VideoInfo {

		public Video Video { get; }

		public StreamManifest StreamManifest { get; }

		public Bitmap Preview { get; }

		public VideoInfo(Video video, StreamManifest streamManifest, Bitmap bitmap) {
			Video = video;
			StreamManifest = streamManifest;
			Preview = bitmap;
		}


	}
}
