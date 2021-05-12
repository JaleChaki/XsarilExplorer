using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XsarilExplorerApi;

namespace XsarilExplorer.Front {
	public class MenuFactory : IPluginEnvironment, IMenuFactory {

		private List<Service> RegisteredServices;

		private readonly AppConfiguration Config;

		private Form Menu;

		public MenuFactory(AppConfiguration config) {
			RegisteredServices = new List<Service>();
			Config = config;
		}

		public void RegisterService(string serviceName, Action<string> callback) {
			RegisteredServices.Add(new Service(serviceName, callback));
		}

		public Form GetOrCreateMenu() {
			if (Menu == null || Menu.IsDisposed) {
				Menu = new ServiceMenu(RegisteredServices, Config);
			}
			return Menu;
		}
	}
}
