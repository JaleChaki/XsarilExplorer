namespace XsarilExplorerApi {
	public abstract class Plugin {

		public virtual string Name => null;

		public string AppFolder { get; internal set; }

		public string PluginFolder { get; internal set; }

		public abstract void Init(IPluginEnvironment environment);

	}
}
