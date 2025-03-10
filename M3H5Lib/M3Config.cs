using ExtensibleHttp;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M3H5Lib
{
	public class M3Config : BaseConfig
	{
		public string BasePath { get; set; }
		public int Company { get; set; }
		public string Authorization { get; set; }
		public bool Debug { get; set; }


		class ConfigOptions
		{
			public string UserAgent { get; set; }
			public ApiFormat ApiFormat { get; set; }
			public int RequestTimeoutMs { get; set; }

			public string Host { get; set; }
			public int Port { get; set; }
			public string Username { get; set; }
			public string Password { get; set; }
			public bool UseSsl { get; set; }
			public string BasePath { get; set; } = "/m3api-rest/";
			public int Company { get; set; }
		}


		private M3Config()
		{
		}

		private M3Config(ConfigOptions configOptions)
		{
			string baseUrl = $"://{configOptions.Host}:{configOptions.Port}/";
			BaseUri = new Uri(configOptions.UseSsl ? ("https" + baseUrl) : ("http" + baseUrl));
			BasePath = configOptions.BasePath;
			Company = configOptions.Company;
			UserAgent = configOptions.UserAgent;
			ApiFormat = configOptions.ApiFormat;
			Authorization = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(configOptions.Username + ":" + configOptions.Password));
		}

		public static M3Config GetConfig(IConfiguration configuration, ApiFormat apiFormat)
		{
			ConfigOptions options = new ConfigOptions();
			if (configuration == null)
			{
				throw new ArgumentNullException(nameof(configuration));
			}

			configuration
				.GetSection("M3")
				.GetSection("Api")
				.Bind(options);

			options = new ConfigOptions();

			if (options.ApiFormat == 0) options.ApiFormat = apiFormat;
			// Minimum time is 5 seconds
			if (options.RequestTimeoutMs < 5000) options.RequestTimeoutMs = 5000;
			return new M3Config(options);
		}

		[Obsolete("Use GetConfig(IConfiguration configuration, ApiFormat apiFormat, CancellationToken cancellationToken) instead")]
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

			await Task.CompletedTask
				.ConfigureAwait(false);

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
