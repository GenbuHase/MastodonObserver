using FNF.XmlSerializerSetting;

namespace MastodonObserver {
	class SettingFormData : ISettingFormData {
		private Settings settings;
		public SettingPropertyGrid propGrid;

		public SettingFormData (Settings setting) {
			this.settings = setting;
			propGrid = new SettingPropertyGrid(this.settings);
		}

		public string Title => Properties.Settings.Default.Title;
		public SettingsBase Setting => this.settings;
		public bool ExpandAll => false;
	}
}
