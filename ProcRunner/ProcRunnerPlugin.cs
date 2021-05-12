using System.Collections.Generic;
using System.Diagnostics;
using XsarilExplorerApi;
using Newtonsoft.Json;
using System.IO;

namespace ProcRunner {
	public class ProcRunnerPlugin : Plugin {
		
		private struct ProcessInitInfo {

			[JsonProperty("File")]
			public string FileName { get; }

			[JsonProperty("Args")]
			public string Arguments { get; }

			[JsonConstructor]
			public ProcessInitInfo(string filename, string arguments) {
				this.FileName = filename;
				this.Arguments = arguments;
			}
		}

		private Dictionary<string, ProcessInitInfo> ProcData;
		
		public ProcRunnerPlugin() {
			ProcData = new Dictionary<string, ProcessInitInfo>();
		}

		public override void Init(IPluginEnvironment environment) {
			ProcData = JsonConvert.DeserializeObject<Dictionary<string, ProcessInitInfo>>(File.ReadAllText(Path.Combine(PluginFolder, "processes.json")));
			foreach (string procName in ProcData.Keys) {
				environment.RegisterService(procName, CallbackAction);
			}
		}

		private void CallbackAction(string procName) {
			var initInfo = ProcData[procName];
			Process.Start(initInfo.FileName, initInfo.Arguments);
		}
	}
}
