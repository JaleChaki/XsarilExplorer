namespace XsarilExplorer {
	partial class LaunchButton {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaunchButton));
			this.ButtonImage = new System.Windows.Forms.PictureBox();
			this.UpdationTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ButtonImage)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonImage
			// 
			this.ButtonImage.Image = ((System.Drawing.Image)(resources.GetObject("ButtonImage.Image")));
			this.ButtonImage.Location = new System.Drawing.Point(-1, -1);
			this.ButtonImage.Name = "ButtonImage";
			this.ButtonImage.Size = new System.Drawing.Size(50, 50);
			this.ButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ButtonImage.TabIndex = 0;
			this.ButtonImage.TabStop = false;
			this.ButtonImage.Click += new System.EventHandler(this.ButtonImage_Click);
			// 
			// LaunchButton
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(50, 50);
			this.Controls.Add(this.ButtonImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LaunchButton";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form1";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.ButtonImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox ButtonImage;
		private System.Windows.Forms.Timer UpdationTimer;
	}
}

