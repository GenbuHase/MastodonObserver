using FNF.BouyomiChanApp;
using FNF.XmlSerializerSetting;

namespace MastodonObserver {
	public class Plugin_MastodonObserver : IPlugin {
		public string Name => Properties.Settings.Default.Title;

		public string Version => Properties.Settings.Default.Version;

		public string Caption => Properties.Settings.Default.Description;

		public ISettingFormData SettingFormData => null;

		public void Begin() {
			return;
		}

		public void End() {
			return;
		}
	}
}