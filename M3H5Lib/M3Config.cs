using ExtensibleHttp;
using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M3H5Lib
{
	public class M3Config : BaseConfig
	{
		public string BasePath { get;  set; }
		public int Company { get; set; }
		public string Authorization { get; set; }
		public bool Debug { get; set; }

		public static async Task<M3Config> GetConfig(string host,
			int port,
			string username,
			string password,
			string basePath,
			bool ssl,
			int company,
			CancellationToken cancellationToken)
		{
			string baseUrl = $"://{host}:{port}/";

			baseUrl = ssl ? $"https{baseUrl}" : $"http{baseUrl}";

			await Task.CompletedTask;

			return new M3Config()
			{
				Company = company,
				BaseUri = new Uri(baseUrl),
				ApiFormat = ApiFormat.Json,
				UserAgent = "M3H5Lib",
				BasePath = basePath,
				Authorization = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(username + ":" + password)),
			};
		}

	}
}
