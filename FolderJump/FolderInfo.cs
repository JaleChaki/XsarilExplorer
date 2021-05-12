using Newtonsoft.Json;

namespace FolderJump {
	public class FolderInfo {

		[JsonProperty("Dest")]
		public string DestinationFolderPath;

		[JsonProperty("Hints")]
		public string[] FolderShortNames;

	}
}
