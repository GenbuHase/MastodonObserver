using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MastodonObserver.Util {
	class I18nCategoryAttribute : CategoryAttribute {
		public I18nCategoryAttribute (string key) : base(Properties.Resources.ResourceManager.GetString(key)) {
			
		}
	}

	class I18nDescriptionAttribute : DescriptionAttribute {
		public I18nDescriptionAttribute (string key) : base(Properties.Resources.ResourceManager.GetString(key)) {
			
		}
	}

	class I18nDisplayNameAttribute : DisplayNameAttribute {
		public I18nDisplayNameAttribute(string key) : base(Properties.Resources.ResourceManager.GetString(key)) {

		}
	}
}