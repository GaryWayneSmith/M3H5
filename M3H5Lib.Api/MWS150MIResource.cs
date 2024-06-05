/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order Number</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3RIDS">Line specification</param>
		/// <param name="m3SCNB">Supply chain number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelSupplyChainResponse></returns>
		/// <exception cref="M3Exception<SelSupplyChainResponse>"></exception>
		public async Task<M3Response<SelSupplyChainResponse>> SelSupplyChain(
			int? m3CONO = null, 
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3PONR = null, 
			int? m3RIDS = null, 
			string m3SCNB = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDS.HasValue)
				request.WithQueryParameter("RIDS", m3RIDS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCNB))
				request.WithQueryParameter("SCNB", m3SCNB.Trim());

			// Execute the request
			var result = await Execute<SelSupplyChainResponse>(
				request: request,
				maxRecords: maxRecords,
				includeMetadata: includeMetadata,
				trimResults: trimResults,
				outputColumns: outputColumns,
				throwExceptionWithoutSuccess: throwExceptionWithoutSuccess,
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}
	}
}
// EOF
