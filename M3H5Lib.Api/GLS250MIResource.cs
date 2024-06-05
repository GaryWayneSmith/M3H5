/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.GLS250MI;
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
	/// Name: GLS250MI
	/// Component Name: Financials
	/// Description: Api: Extra information numbers
	/// Version Release: 14.x
	///</summary>
	public partial class GLS250MIResource : M3BaseResourceEndpoint
	{
		public GLS250MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "GLS250MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstInfo
		/// Description Lists all GL-additional info based
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_GEXN">GL information number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInfoResponse></returns>
		/// <exception cref="M3Exception<LstInfoResponse>"></exception>
		public async Task<M3Response<LstInfoResponse>> LstInfo(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_JRNO, 
			int m3_GEXN, 
			int? m3_JSNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("GEXN", m3_GEXN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_JSNO.HasValue)
				request.WithQueryParameter("JSNO", m3_JSNO.Value.ToString());

			// Execute the request
			var result = await Execute<LstInfoResponse>(
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
