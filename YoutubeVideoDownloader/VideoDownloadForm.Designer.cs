using XWinUI.Controls;

namespace YoutubeVideoDownloader {
	partial class VideoDownloadForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label label1;
			this.VideoSearchLabel = new System.Windows.Forms.Label();
			this.VideoSearchStatus = new System.Windows.Forms.Label();
			this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
			this.VideoInfoPanel = new System.Windows.Forms.Panel();
			this.WithAudioOptionPanel = new System.Windows.Forms.Panel();
			this.WithAudioOption = new XWinUI.Controls.XCheckBox();
			this.DownloadAs = new XWinUI.Controls.XButton();
			this.DownloadButtonContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.DurationLabel = new System.Windows.Forms.Label();
			this.Download = new XWinUI.Controls.XButton();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.VideoTitleLabel = new System.Windows.Forms.Label();
			this.VideoPreview = new System.Windows.Forms.PictureBox();
			this.CloseButton = new XWinUI.Controls.XButton();
			this.DownloadProgressBar = new XWinUI.Controls.XProgressBar();
			this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.DownloadCompleteLabel = new System.Windows.Forms.Label();
			this.ShowInExplorerButton = new XWinUI.Controls.XButton();
			label1 = new System.Windows.Forms.Label();
			this.VideoInfoPanel.SuspendLayout();
			this.WithAudioOptionPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VideoPreview)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(85, 17);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(76, 17);
			label1.TabIndex = 9;
			label1.Text = "Со звуком";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoSearchLabel
			// 
			this.VideoSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.VideoSearchLabel.ForeColor = System.Drawing.Color.White;
			this.VideoSearchLabel.Location = new System.Drawing.Point(275, 202);
			this.VideoSearchLabel.Name = "VideoSearchLabel";
			this.VideoSearchLabel.Size = new System.Drawing.Size(250, 45);
			this.VideoSearchLabel.TabIndex = 0;
			this.VideoSearchLabel.Text = "Поиск видео...";
			// 
			// VideoSearchStatus
			// 
			this.VideoSearchStatus.ForeColor = System.Drawing.Color.White;
			this.VideoSearchStatus.Location = new System.Drawing.Point(279, 256);
			this.VideoSearchStatus.Name = "VideoSearchStatus";
			this.VideoSearchStatus.Size = new System.Drawing.Size(246, 23);
			this.VideoSearchStatus.TabIndex = 1;
			this.VideoSearchStatus.Text = "Поиск начат";
			this.VideoSearchStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UpdateTimer
			// 
			this.UpdateTimer.Enabled = true;
			this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
			// 
			// VideoInfoPanel
			// 
			this.VideoInfoPanel.Controls.Add(this.DownloadCompleteLabel);
			this.VideoInfoPanel.Controls.Add(this.WithAudioOptionPanel);
			this.VideoInfoPanel.Controls.Add(this.DownloadAs);
			this.VideoInfoPanel.Controls.Add(this.DownloadButtonContainer);
			this.VideoInfoPanel.Controls.Add(this.DurationLabel);
			this.VideoInfoPanel.Controls.Add(this.Download);
			this.VideoInfoPanel.Controls.Add(this.AuthorLabel);
			this.VideoInfoPanel.Controls.Add(this.VideoTitleLabel);
			this.VideoInfoPanel.Controls.Add(this.VideoPreview);
			this.VideoInfoPanel.Controls.Add(this.CloseButton);
			this.VideoInfoPanel.Controls.Add(this.DownloadProgressBar);
			this.VideoInfoPanel.Controls.Add(this.ShowInExplorerButton);
			this.VideoInfoPanel.Location = new System.Drawing.Point(13, 13);
			this.VideoInfoPanel.Name = "VideoInfoPanel";
			this.VideoInfoPanel.Size = new System.Drawing.Size(775, 425);
			this.VideoInfoPanel.TabIndex = 2;
			this.VideoInfoPanel.Visible = false;
			// 
			// WithAudioOptionPanel
			// 
			this.WithAudioOptionPanel.Controls.Add(label1);
			this.WithAudioOptionPanel.Controls.Add(this.WithAudioOption);
			this.WithAudioOptionPanel.Location = new System.Drawing.Point(227, 378);
			this.WithAudioOptionPanel.Name = "WithAudioOptionPanel";
			this.WithAudioOptionPanel.Size = new System.Drawing.Size(233, 47);
			this.WithAudioOptionPanel.TabIndex = 10;
			this.WithAudioOptionPanel.Visible = false;
			// 
			// WithAudioOption
			// 
			this.WithAudioOption.BorderColor = System.Drawing.Color.Empty;
			this.WithAudioOption.Checked = false;
			this.WithAudioOption.CheckedBackColor = System.Drawing.Color.MediumSpringGreen;
			this.WithAudioOption.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.WithAudioOption.Location = new System.Drawing.Point(167, 12);
			this.WithAudioOption.Name = "WithAudioOption";
			this.WithAudioOption.Size = new System.Drawing.Size(59, 27);
			this.WithAudioOption.TabIndex = 8;
			this.WithAudioOption.UncheckedBackColor = System.Drawing.Color.DarkGray;
			// 
			// DownloadAs
			// 
			this.DownloadAs.BackColor = System.Drawing.Color.DarkGray;
			this.DownloadAs.Font = new System.Drawing.Font("Arial", 11F);
			this.DownloadAs.ForeColor = System.Drawing.Color.Black;
			this.DownloadAs.Location = new System.Drawing.Point(466, 385);
			this.DownloadAs.Name = "DownloadAs";
			this.DownloadAs.RippleColor = System.Drawing.Color.MediumSpringGreen;
			this.DownloadAs.Size = new System.Drawing.Size(150, 37);
			this.DownloadAs.TabIndex = 7;
			this.DownloadAs.Text = "Скачать в...";
			this.DownloadAs.TextAlignment = System.Drawing.StringAlignment.Center;
			this.DownloadAs.Visible = false;
			this.DownloadAs.Click += new System.EventHandler(this.DownloadAs_Click);
			// 
			// DownloadButtonContainer
			// 
			this.DownloadButtonContainer.AutoScroll = true;
			this.DownloadButtonContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.DownloadButtonContainer.Location = new System.Drawing.Point(8, 230);
			this.DownloadButtonContainer.Name = "DownloadButtonContainer";
			this.DownloadButtonContainer.Size = new System.Drawing.Size(767, 142);
			this.DownloadButtonContainer.TabIndex = 6;
			// 
			// DurationLabel
			// 
			this.DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DurationLabel.ForeColor = System.Drawing.Color.White;
			this.DurationLabel.Location = new System.Drawing.Point(597, 44);
			this.DurationLabel.Name = "DurationLabel";
			this.DurationLabel.Size = new System.Drawing.Size(175, 17);
			this.DurationLabel.TabIndex = 5;
			this.DurationLabel.Text = "VideoDurationLabel";
			this.DurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Download
			// 
			this.Download.BackColor = System.Drawing.Color.DarkGray;
			this.Download.Font = new System.Drawing.Font("Arial", 11F);
			this.Download.ForeColor = System.Drawing.Color.Black;
			this.Download.Location = new System.Drawing.Point(622, 385);
			this.Download.Name = "Download";
			this.Download.RippleColor = System.Drawing.Color.MediumSpringGreen;
			this.Download.Size = new System.Drawing.Size(150, 37);
			this.Download.TabIndex = 4;
			this.Download.Text = "Скачать";
			this.Download.TextAlignment = System.Drawing.StringAlignment.Center;
			this.Download.Visible = false;
			this.Download.Click += new System.EventHandler(this.Download_Click);
			// 
			// AuthorLabel
			// 
			this.AuthorLabel.AutoSize = true;
			this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AuthorLabel.ForeColor = System.Drawing.Color.White;
			this.AuthorLabel.Location = new System.Drawing.Point(398, 44);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new System.Drawing.Size(121, 17);
			this.AuthorLabel.TabIndex = 2;
			this.AuthorLabel.Text = "VideoAuthorLabel";
			this.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoTitleLabel
			// 
			this.VideoTitleLabel.AutoSize = true;
			this.VideoTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.VideoTitleLabel.ForeColor = System.Drawing.Color.White;
			this.VideoTitleLabel.Location = new System.Drawing.Point(399, 4);
			this.VideoTitleLabel.Name = "VideoTitleLabel";
			this.VideoTitleLabel.Size = new System.Drawing.Size(175, 29);
			this.VideoTitleLabel.TabIndex = 1;
			this.VideoTitleLabel.Text = "VideoTitleLabel";
			this.VideoTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoPreview
			// 
			this.VideoPreview.Location = new System.Drawing.Point(8, -1);
			this.VideoPreview.Name = "VideoPreview";
			this.VideoPreview.Size = new System.Drawing.Size(388, 230);
			this.VideoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.VideoPreview.TabIndex = 0;
			this.VideoPreview.TabStop = false;
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.Color.DarkGray;
			this.CloseButton.Font = new System.Drawing.Font("Arial", 11F);
			this.CloseButton.ForeColor = System.Drawing.Color.Black;
			this.CloseButton.Location = new System.Drawing.Point(3, 385);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.RippleColor = System.Drawing.Color.MediumSpringGreen;
			this.CloseButton.Size = new System.Drawing.Size(150, 37);
			this.CloseButton.TabIndex = 3;
			this.CloseButton.Text = "Закрыть";
			this.CloseButton.TextAlignment = System.Drawing.StringAlignment.Center;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// DownloadProgressBar
			// 
			this.DownloadProgressBar.BackColor = System.Drawing.Color.DarkGray;
			this.DownloadProgressBar.BorderColor = System.Drawing.Color.Black;
			this.DownloadProgressBar.Location = new System.Drawing.Point(8, 243);
			this.DownloadProgressBar.Name = "DownloadProgressBar";
			this.DownloadProgressBar.ProgressColor = System.Drawing.Color.MediumSpringGreen;
			this.DownloadProgressBar.Size = new System.Drawing.Size(764, 37);
			this.DownloadProgressBar.TabIndex = 11;
			this.DownloadProgressBar.Value = 0;
			this.DownloadProgressBar.Visible = false;
			// 
			// SaveFileDialog
			// 
			this.SaveFileDialog.Filter = "All files |*|mp4|*.mp4|mp3|*.mp3|webm|*.webm";
			// 
			// DownloadCompleteLabel
			// 
			this.DownloadCompleteLabel.AutoSize = true;
			this.DownloadCompleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DownloadCompleteLabel.ForeColor = System.Drawing.Color.White;
			this.DownloadCompleteLabel.Location = new System.Drawing.Point(263, 266);
			this.DownloadCompleteLabel.Name = "DownloadCompleteLabel";
			this.DownloadCompleteLabel.Size = new System.Drawing.Size(283, 31);
			this.DownloadCompleteLabel.TabIndex = 10;
			this.DownloadCompleteLabel.Text = "Загрузка завершена!";
			this.DownloadCompleteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DownloadCompleteLabel.Visible = false;
			// 
			// ShowInExplorerButton
			// 
			this.ShowInExplorerButton.BackColor = System.Drawing.Color.DarkGray;
			this.ShowInExplorerButton.Font = new System.Drawing.Font("Arial", 11F);
			this.ShowInExplorerButton.ForeColor = System.Drawing.Color.Black;
			this.ShowInExplorerButton.Location = new System.Drawing.Point(331, 314);
			this.ShowInExplorerButton.Name = "ShowInExplorerButton";
			this.ShowInExplorerButton.RippleColor = System.Drawing.Color.MediumSpringGreen;
			this.ShowInExplorerButton.Size = new System.Drawing.Size(150, 37);
			this.ShowInExplorerButton.TabIndex = 12;
			this.ShowInExplorerButton.Text = "Открыть в каталоге";
			this.ShowInExplorerButton.TextAlignment = System.Drawing.StringAlignment.Center;
			this.ShowInExplorerButton.Visible = false;
			this.ShowInExplorerButton.Click += new System.EventHandler(this.ShowInExplorerButton_Click);
			// 
			// VideoDownloadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.VideoInfoPanel);
			this.Controls.Add(this.VideoSearchStatus);
			this.Controls.Add(this.VideoSearchLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "VideoDownloadForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VideoDownloadForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VideoDownloadForm_FormClosed);
			this.VideoInfoPanel.ResumeLayout(false);
			this.VideoInfoPanel.PerformLayout();
			this.WithAudioOptionPanel.ResumeLayout(false);
			this.WithAudioOptionPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.VideoPreview)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label VideoSearchLabel;
		private System.Windows.Forms.Label VideoSearchStatus;
		private System.Windows.Forms.Timer UpdateTimer;
		private System.Windows.Forms.PictureBox VideoPreview;
		private System.Windows.Forms.Label VideoTitleLabel;
		private System.Windows.Forms.Label AuthorLabel;
		private XButton CloseButton;
		private XButton Download;
		private System.Windows.Forms.Label DurationLabel;
		private System.Windows.Forms.FlowLayoutPanel DownloadButtonContainer;
		private XButton DownloadAs;
		private System.Windows.Forms.Panel VideoInfoPanel;
		private XCheckBox WithAudioOption;
		private System.Windows.Forms.Panel WithAudioOptionPanel;
		private XProgressBar DownloadProgressBar;
		private System.Windows.Forms.SaveFileDialog SaveFileDialog;
		private XButton ShowInExplorerButton;
		private System.Windows.Forms.Label DownloadCompleteLabel;
	}
}