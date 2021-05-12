using Newtonsoft.Json;
using System;
using System.IO;

namespace XsarilExplorerApi {
	public class AppConfiguration {

		[JsonProperty]
		public int ButtonPositionX { get; private set; }

		[JsonProperty]
		public int ButtonPositionY { get; private set; }

		[JsonProperty]
		public int LoopInterval { get; private set; }

		[JsonIgnore]
		public string ApplicationFolder { get; }

		[JsonProperty]
		public bool ActivateOnShow { get; private set; }

		[JsonProperty]
		public string PluginsFilelist { get; private set; }

		public AppConfiguration() {
			ApplicationFolder = Directory.GetCurrentDirectory();
		}

	}
}
