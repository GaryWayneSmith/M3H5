/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.AHS200MI;
using M3H5Lib.Extensions;
using M3H5Lib.Models;
using ExtensibleHttp.Payload;
using ExtensibleHttp;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace M3H5Lib.Api
{

	/// <summary>
	/// Name: AHS200MI
	/// Component Name: Ad-hoc Report
	/// Description: Api: Ad-hoc Report version by user
	/// Version Release: 15.0
	///</summary>
	public partial class AHS200MIResource : M3BaseResourceEndpoint
	{
		public AHS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "AHS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstByUser
		/// Description List Ad hoc reports per user
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByUserResponse></returns>
		/// <exception cref="M3Exception<LstByUserResponse>"></exception>
		public async Task<M3Response<LstByUserResponse>> LstByUser(
			string m3_USID, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByUser",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<LstByUserResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken);

			// Return the response object in it's entirety
			return result;
		}
	}
}
// EOF
