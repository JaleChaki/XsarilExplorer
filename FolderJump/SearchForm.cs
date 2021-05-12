using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XsarilExplorerApi.FormPresets;
using XWinUI.Controls;

namespace FolderJump {
	public partial class SearchForm : SearchString {

		private FolderInfo[] Folders;

		private int BaseHeight = 75;

		protected override string InputTextBoxPreviewText => "Ключевые слова";

		private ICollection<Control> SearchResults;

		public SearchForm(IEnumerable<FolderInfo> folders) {
			Folders = folders.ToArray();
			InitializeComponent();
			SearchResults = new List<Control>();
			InputTextBox.Focus();
		}

		private void SearchForm_Deactivate(object sender, EventArgs e) {
			this.Hide();
			this.Close();
		}

		private void CreateProc(string destFolder) {
			Process.Start("explorer.exe", @"/n," + destFolder);
			this.Hide();
		}

		private void InputTextBox_TextChanged(object sender, EventArgs e) {
			ClearResults();
			if (InputTextBox.Text.Length < 2) {
				this.Height = BaseHeight;
				//throw new Exception();
				return;
			}

			int align = 5;
			int y = BaseHeight + align;

			foreach (var res in GetResults(InputTextBox.Text)) {
				XButton b = new XButton(y, 5, 711, 50, res.DestinationFolderPath); // (res.DestinationFolderPath, 13, y, 711, 50);
				b.Font = new Font("Arial", 14);
				b.ForeColor = Color.White;
				b.Click += JumpTo;
				SearchResults.Add(b);
				Controls.Add(b);
				y += 50 + align;
			}
			this.Height = y + align;
		}

		private void JumpTo(object sender, EventArgs e) {
			string dest = (sender as Control).Text;
			if (string.IsNullOrEmpty(dest)) {
				return;
			}
			CreateProc(dest);
		}

		private IEnumerable<FolderInfo> GetResults(string input) {
			input = input.ToLower();
			ICollection<FolderInfo> outputResults = new List<FolderInfo>();
			foreach (var f in Folders) {
				if (f.FolderShortNames.Where(x => x.ToLower().Contains(input)).Count() > 0) {
					yield return f;
				}
			}
		}

		private void ClearResults() {
			foreach (var c in SearchResults) {
				Controls.Remove(c);
				c.Dispose();
			}
			SearchResults.Clear();
		}

		private void SearchForm_Shown(object sender, EventArgs e) {
			InputTextBox.Text = "";
			this.Height = BaseHeight;
			InputTextBox.Focus();
		}

		private void InputTextBox_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				e.Handled = true;
				e.SuppressKeyPress = true;
				string dest = GetResults(InputTextBox.Text).FirstOrDefault()?.DestinationFolderPath;
				if (string.IsNullOrEmpty(dest)) {
					return;
				}
				CreateProc(dest);
			}
		}

	}
}
