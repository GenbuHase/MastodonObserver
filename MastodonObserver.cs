using FNF.BouyomiChanApp;
using FNF.XmlSerializerSetting;
using FNF.Utility;

namespace MastodonObserver {
	public class MastodonObserver : IPlugin {
		private string settingPath = Base.CallAsmPath + Base.CallAsmName + ".setting";
		private Settings setting = null;
		private SettingFormData formData = null;

		public string Name => Properties.Settings.Default.Title;
		public string Version => Properties.Settings.Default.Version;
		public string Caption => Properties.Settings.Default.Description;
		public ISettingFormData SettingFormData => this.formData;

		public void Begin() {
			this.setting = new Settings();
			this.setting.Load(settingPath);

			this.formData = new SettingFormData(this.setting);

			return;
		}

		public void End() {
			this.setting.Save(settingPath);

			return;
		}
	}
}