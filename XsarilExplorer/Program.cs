using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using XsarilExplorer.Front;
using XsarilExplorerApi;

namespace XsarilExplorer {
	static class Program {
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			AppConfiguration config = JsonConvert.DeserializeObject<AppConfiguration>(File.ReadAllText("config.json")); ;

			var middlemanSrv = new MenuFactory(config);

			PluginLoader loader = new PluginLoader();

			foreach (var pluginDll in JsonConvert.DeserializeObject<string[]>(File.ReadAllText(config.PluginsFilelist))) {
				var plugin = loader.Load(pluginDll, config);
				plugin.Init(middlemanSrv);
			}

			Application.Run(new LaunchButton(middlemanSrv, config));
		}
	}
}
