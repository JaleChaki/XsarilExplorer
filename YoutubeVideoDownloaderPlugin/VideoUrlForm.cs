using System;

namespace YoutubeVideoDownloader {
	public partial class VideoUrlForm : XsarilExplorerApi.FormPresets.SearchString {

		protected override string InputTextBoxPreviewText => "URL видео";

		YoutubeVideoDownloaderPlugin ParentPlugin;

		public VideoUrlForm(YoutubeVideoDownloaderPlugin parent) {
			InitializeComponent();
			ParentPlugin = parent;
		}

		private void VideoUrlForm_Shown(object sender, EventArgs e) {
			InputTextBox.Focus();
		}

		private void InputTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			if (e.KeyCode == System.Windows.Forms.Keys.Enter) {
				e.Handled = true;
				e.SuppressKeyPress = true;
				ParentPlugin?.ShowDownloadForm(InputTextBox.Text);
				ParentPlugin = null;
			}
		}

		private void VideoUrlForm_Deactivate(object sender, EventArgs e) {
			ParentPlugin = null;
			this.Hide();
			this.Close();
		}
	}
}
