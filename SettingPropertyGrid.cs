using FNF.XmlSerializerSetting;
using MastodonObserver.Util;

namespace MastodonObserver {
	public class SettingPropertyGrid : ISettingPropertyGrid {
		private const string MSTDN_BASIC = "SETTING_MSTDN_BASIC";
		private const string MSTDN_BASIC_INSTANCEURL_LABEL = "SETTING_MSTDN_BASIC_INSTANCEURL_LABEL";
		private const string MSTDN_BASIC_INSTANCEURL = "SETTING_MSTDN_BASIC_INSTANCEURL";
		private const string MSTDN_BASIC_ACCOUNTID_LABEL = "SETTING_MSTDN_BASIC_ACCOUNTID_LABEL";
		private const string MSTDN_BASIC_ACCOUNTID = "SETTING_MSTDN_BASIC_ACCOUNTID";
		private const string MSTDN_BASIC_TOKEN_LABEL = "SETTING_MSTDN_BASIC_TOKEN_LABEL";
		private const string MSTDN_BASIC_TOKEN = "SETTING_MSTDN_BASIC_TOKEN";

		private Settings settings;

		public SettingPropertyGrid(Settings setting) {
			this.settings = setting;
		}

		public string GetName() => Properties.Resources.SETTING_CATEGORY_MSTDN;

		[I18nCategory(MSTDN_BASIC)]
		[I18nDisplayName(MSTDN_BASIC_INSTANCEURL_LABEL)]
		[I18nDescription(MSTDN_BASIC_INSTANCEURL)]
		public string InstanceURL {
			get => this.settings.InstanceURL;
			set => this.settings.InstanceURL = value;
		}

		[I18nCategory(MSTDN_BASIC)]
		[I18nDisplayName(MSTDN_BASIC_ACCOUNTID_LABEL)]
		[I18nDescription(MSTDN_BASIC_ACCOUNTID)]
		public string AccountID {
			get => this.settings.AccountID;
			set => this.settings.AccountID = value;
		}

		[I18nCategory(MSTDN_BASIC)]
		[I18nDisplayName(MSTDN_BASIC_TOKEN_LABEL)]
		[I18nDescription(MSTDN_BASIC_TOKEN)]
		public string Token {
			get => this.settings.Token;
			set => this.settings.Token = value;
		}
	}
}
