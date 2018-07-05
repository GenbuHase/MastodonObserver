using FNF.BouyomiChanApp;
using FNF.XmlSerializerSetting;
using FNF.Utility;
using System.Diagnostics;
using MastodonObserver.Util;

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

			Mastodon mstdn = new Mastodon(this.setting.InstanceURL, this.setting.Token);
			Debug.WriteLine(mstdn.Test("TEST"));
			//Pub.AddTalkTask();

			return;
		}

		public void End() {
			this.setting.Save(settingPath);
			return;
		}
	}
}