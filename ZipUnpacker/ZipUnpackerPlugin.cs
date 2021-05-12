using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using XsarilExplorerApi;

namespace ZipUnpacker {
	public class ZipUnpackerPlugin : Plugin {

		private string DownloadsFolder;

		public override void Init(IPluginEnvironment environment) {
			DownloadsFolder = File.ReadAllText(Path.Combine(PluginFolder, "downloadsfolder.txt"));
			environment.RegisterService("Unpack downloaded ZIP", ServiceCallback);
		}

		private void ServiceCallback(string _) {
			List<string> files = Directory.GetFiles(DownloadsFolder, "*.zip").ToList();
			files.Sort((a, b) => {
				var aTime = File.GetCreationTime(a);
				var bTime = File.GetCreationTime(b);
				return DateTime.Compare(aTime, bTime);
			});
			string targ = files.LastOrDefault();
			if (string.IsNullOrEmpty(targ)) {
				MessageBox.Show("Нет доступных zip архивов в каталоге " + DownloadsFolder, "Error", MessageBoxButtons.OK);
				return;
			}
			string outputFolder = Path.Combine(DownloadsFolder, Path.GetFileNameWithoutExtension(targ));
			if (!Directory.Exists(outputFolder)) {
				Directory.CreateDirectory(outputFolder);
			}
			var p = Process.Start(@"C:\Program Files\7-Zip\7z.exe", "x " + files.Last() + " -r -y -o" + outputFolder);
			p.WaitForExit();
			Process.Start("explorer.exe", "/n," + outputFolder);
		}
	}
}
