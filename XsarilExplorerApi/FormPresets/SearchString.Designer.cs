namespace XsarilExplorerApi.FormPresets {
	partial class SearchString {
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
			this.InputTextBox = new XWinUI.Controls.XTextBox();
			this.SuspendLayout();
			// 
			// InputTextBox
			// 
			this.InputTextBox.BorderColor = System.Drawing.SystemColors.ControlLightLight;
			this.InputTextBox.Font = new System.Drawing.Font("Verdana", 16F);
			this.InputTextBox.ForeColor = System.Drawing.Color.White;
			this.InputTextBox.InactiveBorderColor = System.Drawing.Color.DarkGray;
			this.InputTextBox.Location = new System.Drawing.Point(5, 12);
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.PreviewFont = new System.Drawing.Font("Arial", 10F);
			this.InputTextBox.PreviewText = null;
			this.InputTextBox.Size = new System.Drawing.Size(783, 50);
			this.InputTextBox.TabIndex = 0;
			// 
			// SearchString
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(800, 75);
			this.Controls.Add(this.InputTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SearchString";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SearchString";
			this.ResumeLayout(false);

		}

		#endregion

		protected XWinUI.Controls.XTextBox InputTextBox;
	}
}