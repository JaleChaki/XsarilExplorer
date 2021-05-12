using XWinUI.Controls;
using System.Collections.Generic;
using XsarilExplorer.Front;
using XsarilExplorerApi;
using System.Drawing;

namespace XsarilExplorer {
	public partial class ServiceMenu : XWinUI.Forms.ShadowFlattenForm {
		
		public ServiceMenu(IEnumerable<Service> services, AppConfiguration configs) {
			InitializeComponent();
			int margin = 5;
			int buttonWidth = this.Width - 24;
			int buttonHeight = 50;
			int buttonLeft = (this.Width - buttonWidth) / 2;
			foreach (var s in services) {
				XButton button = new XButton(margin, buttonLeft, buttonWidth, buttonHeight, s.Name);
				button.BackColor = Color.FromArgb(45, 45, 48);
				button.ForeColor = Color.White;
				button.Click += new System.EventHandler((sender, args) => s.Invoke(s.Name));
				Controls.Add(button);
				margin += button.Height + 5;
			}
			this.Size = new System.Drawing.Size(Width, margin + 5);
			int top = configs.ButtonPositionY - this.Height;
			int left = configs.ButtonPositionX - this.Width;
			if (top < 0) {
				top *= -1;
				top += 50;
			}
			if (left < 0) {
				left *= -1;
				left += 50;
			}
			this.Top = top;
			this.Left = left;
			this.TopMost = configs.ActivateOnShow;
		}

		private void ServiceMenu_Deactivate(object sender, System.EventArgs e) {
			this.Hide();
			this.Close();
		}
	}
}
