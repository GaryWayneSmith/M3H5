/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OSBSTDMI;
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
	/// Name: OSBSTDMI
	/// Component Name: SalesStatistics
	/// Description: Api: Sales Statistics Details
	/// Version Release: 14.x
	///</summary>
	public partial class OSBSTDMIResource : M3BaseResourceEndpoint
	{
		public OSBSTDMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OSBSTDMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SelDetails
		/// Description Select Sales Statistic Details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_FRDT">From Invoice date (Required)</param>
		/// <param name="m3_TODT">To Invoice date (Required)</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_ITFR">Item type from</param>
		/// <param name="m3_ITTO">Item type to</param>
		/// <param name="m3_ORFR">Origin from</param>
		/// <param name="m3_ORTO">Origin to</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_DLNI">Delivered/not invoiced statistics</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDetailsResponse></returns>
		/// <exception cref="M3Exception<SelDetailsResponse>"></exception>
		public async Task<M3Response<SelDetailsResponse>> SelDetails(
			string m3_DIVI, 
			DateTime m3_FRDT, 
			DateTime m3_TODT, 
			int? m3_YEA4 = null, 
			string m3_ITFR = null, 
			string m3_ITTO = null, 
			int? m3_ORFR = null, 
			int? m3_ORTO = null, 
			string m3_SUNO = null, 
			int? m3_DLNI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelDetails",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("TODT", m3_TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITFR))
				request.WithQueryParameter("ITFR", m3_ITFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITTO))
				request.WithQueryParameter("ITTO", m3_ITTO.Trim());
			if (m3_ORFR.HasValue)
				request.WithQueryParameter("ORFR", m3_ORFR.Value.ToString());
			if (m3_ORTO.HasValue)
				request.WithQueryParameter("ORTO", m3_ORTO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_DLNI.HasValue)
				request.WithQueryParameter("DLNI", m3_DLNI.Value.ToString());

			// Execute the request
			var result = await Execute<SelDetailsResponse>(
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
