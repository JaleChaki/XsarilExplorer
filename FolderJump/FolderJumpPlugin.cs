using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using XsarilExplorerApi;

namespace FolderJump {
	public class FolderJumpPlugin : Plugin {

		private Form Form;

		public override void Init(IPluginEnvironment environment) {
			environment.RegisterService("Jump to...", ServiceCallback);
		}

		private void ServiceCallback(string _) {
			if (Form == null || Form.IsDisposed) {
				Form = new SearchForm(JsonConvert.DeserializeObject<FolderInfo[]>(File.ReadAllText(Path.Combine(PluginFolder, "folderjump.json"))));
			}
			Form.Show();
		}
	}
}
