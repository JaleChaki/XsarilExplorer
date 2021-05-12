using System;

namespace XsarilExplorerApi {
	public interface IPluginEnvironment {

		void RegisterService(string serviceName, Action<string> callback);

	}
}
