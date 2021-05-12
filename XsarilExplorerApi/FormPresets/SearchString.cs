using System.Windows.Forms;

namespace XsarilExplorerApi.FormPresets {
	public partial class SearchString : Form {

		protected virtual string InputTextBoxPreviewText => "";

		public SearchString() {
			InitializeComponent();
			InputTextBox.PreviewText = InputTextBoxPreviewText;
		}
	}
}
