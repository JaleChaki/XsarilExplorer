using System;

namespace XsarilExplorer.Front {
	public class Service {

		public string Name { get; }

		private Action<string> Callback;

		public Service(string name, Action<string> callback) {
			this.Name = name;
			this.Callback = callback;
		}

		public void Invoke(string s) => Callback?.Invoke(s);

	}
}
