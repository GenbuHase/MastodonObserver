using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Diagnostics;
using System.Collections.Specialized;

namespace MastodonObserver.Util {
	public class Mastodon {
		private readonly string Instance;
		private readonly string Token;

		public Mastodon(string Instance, string Token) {
			this.Instance = Instance;
			this.Token = Token;
		}

		private string Get(string url) { return this.Get(url, new NameValueCollection()); }

		private string Get(string url, NameValueCollection querys) {
			try {
				if (!Uri.IsWellFormedUriString(url, UriKind.Absolute)) url = $"{this.Instance}/{url}";

				WebClient client = new WebClient();
				client.Encoding = Encoding.UTF8;
				
				client.Headers.Add("Authorization", $"Bearer {this.Token}");

				client.QueryString = querys;

				string result = client.DownloadString(url);
				client.Dispose();

				return result;
			} catch (UriFormatException err) {
				throw err;
			}
		}

		private string Post(string url) { return this.Post(url, ""); }

		private string Post(string url, string payload) {
			try {
				if (!Uri.IsWellFormedUriString(url, UriKind.Absolute)) url = $"{this.Instance}/{url}";

				WebClient client = new WebClient();
				client.Encoding = Encoding.UTF8;

				client.Headers.Add("Content-Type", "application/json");
				client.Headers.Add("Authorization", $"Bearer {this.Token}");

				string result = client.UploadString(url, "POST", payload);
				client.Dispose();

				return result;
			} catch (UriFormatException err) {
				throw err;
			}
		}

		public string Test(string text) {
			return this.Get("https://httpbin.org/get");
			//return this.Post("https://httpbin.org/post", $@"{{ status: ""{text}"" }}");

			//return this.Get("api/v1/instance");
			//return this.Post("https://misskey.xyz/api/stats", "");
			//return this.Post("api/notes/create", $@"{{ i: ""{this.Token}"", text: ""{text}"", visibility: ""followers"" }}");
		}
	}
}