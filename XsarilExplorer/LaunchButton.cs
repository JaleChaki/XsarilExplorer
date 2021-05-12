using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using XsarilExplorer.Front;
using XsarilExplorerApi;

namespace XsarilExplorer {
	public partial class LaunchButton : Form {

		private AppConfiguration Config;

		private bool UpdatedFigure = false;

		private IMenuFactory MenuFactory;

		public LaunchButton(IMenuFactory menuFactory, AppConfiguration config) {
			InitializeComponent();
			MenuFactory = menuFactory;
			Config = config;
			UpdationTimer.Interval = Config.LoopInterval;
			UpdationTimer.Enabled = true;
			UpdationTimer.Tick += new EventHandler((a, b) => LoopTick());
			UpdatePosition();
			this.TopMost = Config.ActivateOnShow;
		}

		private void LoopTick() {
			UpdatePosition();
			if (CursorChecker.Check(this)) {
				if (!this.Visible) {
					this.Show();
					if (!Config.ActivateOnShow) {
						this.Activate();
					}
				}
			} else {
				if (this.Visible) {
					this.Hide();
				}
			}
		}

		private void UpdatePosition() {
			if (!UpdatedFigure) {
				var path = new GraphicsPath();
				path.AddEllipse(0, 0, Width, Height);
				Region = new Region(path);
				UpdatedFigure = true;
			}
			this.Top = Config.ButtonPositionY;
			this.Left = Config.ButtonPositionX;
		}

		private void ButtonImage_Click(object sender, EventArgs e) {
			MenuFactory.GetOrCreateMenu().Show();
		}
	}
}
