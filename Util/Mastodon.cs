using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Collections.Specialized;

namespace MastodonObserver.Util {
	public class Mastodon {
		private string Instance;
		private string Token;

		public Mastodon (string Instance, string Token) {
			this.Instance = Instance;
			this.Token = Token;
		}

		private string Get (string url, NameValueCollection querys) {
			try {
				WebClient client = new WebClient();
				client.Headers.Add("Authorization", "Bearer " + this.Token);
				client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36");
				client.QueryString = querys;

				byte[] result = client.DownloadData(this.Instance + "/" + url);
				client.Dispose();

				return Encoding.UTF8.GetString(result);
			} catch (UriFormatException err) {
				throw err;
			}
		}

		private string Post(string url, string json) {
			try {
				WebClient client = new WebClient();
				client.Headers.Add("Authorization", "Bearer " + this.Token);

				string result = client.UploadString(this.Instance + "/" + url, json);
				client.Dispose();

				return result;
			} catch (UriFormatException err) {
				throw err;
			}
		}

		public string Test (string tootContent) {
			//return this.Post("https://httpbin.org/post", "{ status: \"" + tootContent + "\" }");
			return this.Get("api/v1/instance", new NameValueCollection());
			//return this.Get("https://httpbin.org/user-agent", new NameValueCollection());
		}
	}
}