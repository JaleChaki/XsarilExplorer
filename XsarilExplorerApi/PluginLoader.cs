using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace XsarilExplorerApi {
	public class PluginLoader {

		public Plugin Load(string path, AppConfiguration config) {
			Type pluginType = Assembly.LoadFrom(path).GetTypes().Where(x => typeof(Plugin).IsAssignableFrom(x)).FirstOrDefault();
			if (pluginType is null) {
				return null;
			}
			var plugin = Activator.CreateInstance(pluginType) as Plugin;
			plugin.PluginFolder = Path.GetDirectoryName(path);
			plugin.AppFolder = config.ApplicationFolder;
			return plugin;
		}

	}
}
