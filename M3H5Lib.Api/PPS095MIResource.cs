/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS095MI;
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
	/// Name: PPS095MI
	/// Component Name: Wrk: Purchase Order Type
	/// Description: Purchase Order Type
	/// Version Release: 5ea0
	///</summary>
	public partial class PPS095MIResource : M3BaseResourceEndpoint
	{
		public PPS095MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS095MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstOrderType
		/// Description Lists Purchase Order Type
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_POTC">Purchase order category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOrderTypeResponse></returns>
		/// <exception cref="M3Exception<LstOrderTypeResponse>"></exception>
		public async Task<M3Response<LstOrderTypeResponse>> LstOrderType(
			string m3_ORTY = null, 
			string m3_POTC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOrderType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POTC))
				request.WithQueryParameter("POTC", m3_POTC.Trim());

			// Execute the request
			var result = await Execute<LstOrderTypeResponse>(
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
