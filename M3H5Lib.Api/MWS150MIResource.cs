/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS150MI;
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
	/// Name: MWS150MI
	/// Component Name: Active Supply Chain
	/// Description: Active Supply Chain
	/// Version Release: 5ea0
	///</summary>
	public partial class MWS150MIResource : M3BaseResourceEndpoint
	{
		public MWS150MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS150MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SelSupplyChain
		/// Description Select Supply Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order Number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_RIDS">Line specification</param>
		/// <param name="m3_SCNB">Supply chain number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelSupplyChainResponse></returns>
		/// <exception cref="M3Exception<SelSupplyChainResponse>"></exception>
		public async Task<M3Response<SelSupplyChainResponse>> SelSupplyChain(
			int? m3_CONO = null, 
			string m3_ORCA = null, 
			string m3_RIDN = null, 
			int? m3_PONR = null, 
			int? m3_RIDS = null, 
			string m3_SCNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelSupplyChain",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_RIDS.HasValue)
				request.WithQueryParameter("RIDS", m3_RIDS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCNB))
				request.WithQueryParameter("SCNB", m3_SCNB.Trim());

			// Execute the request
			var result = await Execute<SelSupplyChainResponse>(
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
