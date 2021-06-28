using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XWinUI.Controls;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;
using YoutubeVideoDownloader.YExplodeUtils;

namespace YoutubeVideoDownloader {
	public partial class VideoDownloadForm : Form {

		private YoutubeExplodeFacade DownloadHelper;

		private GetVideoStatus GetStatus;

		private StreamManifest SelectedStreamManifest;

		private IStreamInfo SelectedStreamInfo;

		private Video SelectedVideo;

		private double DownloadVideoProgress;

		public VideoDownloadForm(string url) {
			InitializeComponent();
			DownloadHelper = new YoutubeExplodeFacade();
			DownloadHelper.GetVideo(url, OnVideoGetComplete, (status) => {
				GetStatus = status;
			});
		}

		private void OnVideoGetComplete(VideoInfo info) {
			System.Console.WriteLine("COMPLETE");
			SelectedVideo = info.Video;
			VideoInfoPanel.Visible = true;
			VideoPreview.Image = info.Preview;
			VideoTitleLabel.Text = info.Video.Title;
			AuthorLabel.Text = info.Video.Author.Title;
			DurationLabel.Text = info.Video.Duration.ToString();
			int height = DownloadButtonContainer.Height / 2 - 10;
			SelectedStreamManifest = info.StreamManifest;
			foreach (var m in info.StreamManifest.Streams.Where(x => x.Container.Name != "webm" || x is AudioOnlyStreamInfo)) {
				XButton b = new XButton(5, 5, DownloadButtonContainer.Width / 8, height);
				b.Tag = m;
				//b.ForeColor = Color.White;
				b.BackColor = CloseButton.BackColor;
				b.RippleColor = CloseButton.RippleColor;
				StringBuilder caption = new StringBuilder();
				caption.AppendLine(m.Container.Name);
				if (m is IVideoStreamInfo s) {
					caption
						.Append(s.VideoResolution.Width + "x" + s.VideoResolution.Height)
						.Append("\n")
						.Append(s.VideoQuality.Framerate + " FPS\n");
				}
				if (m is VideoOnlyStreamInfo) {
					caption.Append("(video only)");
				}
				if (m is AudioOnlyStreamInfo) {
					caption.Append("(audio only)");
				}
				b.Text = caption.ToString();
				b.Click += ButtonClick;
				DownloadButtonContainer.Controls.Add(b);
			}
		}

		private void ButtonClick(object sender, EventArgs e) {
			foreach (var c in DownloadButtonContainer.Controls.Cast<Control>()) {
				c.BackColor = CloseButton.BackColor;
			}
			var csender = sender as Control;
			csender.BackColor = Color.DarkCyan;
			IStreamInfo streamInfo = csender.Tag as IStreamInfo;
			WithAudioOptionPanel.Visible = (streamInfo is VideoOnlyStreamInfo);
			Download.Visible = true;
			DownloadAs.Visible = true;
			SelectedStreamInfo = streamInfo;
		}

		private void CreateDownloadContract(string path) {
			DownloadProgressBar.Visible = true;
			DownloadButtonContainer.Visible = false;
			Download.Visible = false;
			DownloadAs.Visible = false;
			WithAudioOptionPanel.Visible = false;
			DownloadHelper.DownloadVideo(path, SelectedStreamManifest, SelectedStreamInfo, WithAudioOption.Checked, (progress) => {
				DownloadVideoProgress = progress;
			}, 
			() => {
				DownloadCompleteLabel.Visible = true;
				ShowInExplorerButton.Visible = true;
				DownloadProgressBar.Visible = false;
			});
			SaveFileDialog.FileName = path;
		}

		private void UpdateTimer_Tick(object sender, EventArgs e) {
			//System.Console.WriteLine("TICK");
			DownloadHelper.Update();
			DownloadProgressBar.Value = (int)(100 * DownloadVideoProgress);
			if (GetStatus == GetVideoStatus.GetVideo) {
				VideoSearchStatus.Text = "Получение информации о видео";
			}
			if (GetStatus == GetVideoStatus.GetManifest) {
				VideoSearchStatus.Text = "Получение информации о форматах загрузки";
			}
			if (GetStatus == GetVideoStatus.GetThumbnail) {
				VideoSearchStatus.Text = "Загрузка превью";
			}
			if (GetStatus == GetVideoStatus.Completed) {
				VideoSearchStatus.Text = "Завершение";
			}
		}

		private void VideoDownloadForm_FormClosed(object sender, FormClosedEventArgs e) {
			VideoPreview.Image?.Dispose();
			//VideoPreview.
			GC.Collect();
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}

		private void CloseButton_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void Download_Click(object sender, EventArgs e) {
			CreateDownloadContract(GetVideoTitle());
		}

		private string GetVideoTitle() {
			string result = SelectedVideo.Title;
			foreach (char c in Path.GetInvalidFileNameChars()) {
				result = result.Replace(c, '_');
			}
			return result + "." + SelectedStreamInfo.Container.Name;
		}

		private void DownloadAs_Click(object sender, EventArgs e) {
			if (SaveFileDialog.ShowDialog() == DialogResult.OK) {
				CreateDownloadContract(SaveFileDialog.FileName);
			}
		}

		private void ShowInExplorerButton_Click(object sender, EventArgs e) {
			Process.Start("explorer.exe", @"/select," + SaveFileDialog.FileName);
		}
	}
}
