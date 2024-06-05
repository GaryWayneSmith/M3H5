/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.DRS151MI;
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
	/// Name: DRS151MI
	/// Component Name: Shipment package
	/// Description: Shipment Package Interface
	/// Version Release: 14.x
	///</summary>
	public partial class DRS151MIResource : M3BaseResourceEndpoint
	{
		public DRS151MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "DRS151MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstPckInShpPck
		/// Description List Package In Shipment Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SPNO">Shipment package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPckInShpPckResponse></returns>
		/// <exception cref="M3Exception<LstPckInShpPckResponse>"></exception>
		public async Task<M3Response<LstPckInShpPckResponse>> LstPckInShpPck(
			string m3_SPNO = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPckInShpPck",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPNO))
				request.WithQueryParameter("SPNO", m3_SPNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<LstPckInShpPckResponse>(
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
