using FNF.XmlSerializerSetting;
using System;

namespace MastodonObserver {
	public class Settings : SettingsBase {
		public string InstanceURL;
		public string AccountID;
		public string Token;

		public override void ReadSettings() {
			return;
		}

		public override void WriteSettings() {
			return;
		}
	}
}
