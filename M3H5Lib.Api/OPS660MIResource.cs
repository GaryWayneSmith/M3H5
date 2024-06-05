/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OPS660MI;
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
	/// Name: OPS660MI
	/// Component Name: PointOfSale
	/// Description: Retrieve Mix and Match data
	/// Version Release: 13.1
	///</summary>
	public partial class OPS660MIResource : M3BaseResourceEndpoint
	{
		public OPS660MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OPS660MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstMixMatch
		/// Description Retrieve Mix and Match
		/// Version Release: 13.1
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMixMatchResponse></returns>
		/// <exception cref="M3Exception<LstMixMatchResponse>"></exception>
		public async Task<M3Response<LstMixMatchResponse>> LstMixMatch(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMixMatch",
			};

			// Execute the request
			var result = await Execute<LstMixMatchResponse>(
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
