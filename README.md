## M3H5Lib

This library is a high level wrapper for the Infor/Lawson/M3/Movex C# .Net Standard library ERP system.  It used based upon the GaryWayneSmith/ExtensibleHttp library

The resource models contained here are mostly auto-generated.  Some elements might not return the expected return type, and when in doubt it returns strings. Not all applications are included as the installation of Infor didn't have full access to all modules.

If you have additional applications that need created, clone the repository, make the applicable changes, and push for review.


### Example config values.
```
{
	"m3config": {
		"BasePath": "/m3api-rest/execute",
		"Company": 1,
		"Debug": false,
		"Host": "example.net",
		"Port": "443",
		"Username": "username",
		"Password": "password",
		"UserAgent": "M3H5Lib",
		"ApiFormat": "Json",
		"RequestTimeoutMs": 100000
	}
}
```

### Example ErpConfig.cs
```
public class ErpConfig
{
	public static async Task<M3Config> GetConfig(CancellationToken cancellationToken)
	{
		int port = 443;
		string host = "https://erpserver.local"
		string username = "username";
		string password = "password";

		bool useSsl = true;

		M3Config config = await M3Config.GetConfig(
			host: host,
			port: port,
			ssl: useSsl,
			username: username,
			password: password,
			basePath: "/m3api-rest/execute",
			company: 1,
			cancellationToken: cancellationToken
		);
		return config;
	}
}

```

### Example resource call
```
using M3H5Lib;
using M3H5Lib.Api;
using M3H5Lib.Api.OIS100MI;
using M3H5Lib.Models;

public async Task<GetHeadResponse> GetOrderStatus(string erpNumber, CancellationToken cancellationToken)
{
	M3Config config = await ErpConfig.GetConfig(cancellationToken);
	ApiClient apiClient = new ApiClient(config);
	OIS100MIResource resource = new OIS100MIResource(apiClient);

	M3Response<GetHeadResponse> response = await resource.GetHead(
		m3_CONO: config.Company,
		m3_ORNO: erpNumber,
		throwExceptionWithoutSuccess: true,
		cancellationToken: cancellationToken);

	if (!response.Success)
	{
		_logger.LogWarning("Failed to retreive record, {message}", response.Message);
		return null;
	}
	return response.Rows.FirstOrDefault();
}

```