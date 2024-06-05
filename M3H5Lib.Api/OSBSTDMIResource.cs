/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SelDetails
		/// Description Select Sales Statistic Details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3FRDT">From Invoice date (Required)</param>
		/// <param name="m3TODT">To Invoice date (Required)</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3ITFR">Item type from</param>
		/// <param name="m3ITTO">Item type to</param>
		/// <param name="m3ORFR">Origin from</param>
		/// <param name="m3ORTO">Origin to</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3DLNI">Delivered/not invoiced statistics</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDetailsResponse></returns>
		/// <exception cref="M3Exception<SelDetailsResponse>"></exception>
		public async Task<M3Response<SelDetailsResponse>> SelDetails(
			string m3DIVI, 
			DateTime m3FRDT, 
			DateTime m3TODT, 
			int? m3YEA4 = null, 
			string m3ITFR = null, 
			string m3ITTO = null, 
			int? m3ORFR = null, 
			int? m3ORTO = null, 
			string m3SUNO = null, 
			int? m3DLNI = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelDetails",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("TODT", m3TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITFR))
				request.WithQueryParameter("ITFR", m3ITFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITTO))
				request.WithQueryParameter("ITTO", m3ITTO.Trim());
			if (m3ORFR.HasValue)
				request.WithQueryParameter("ORFR", m3ORFR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORTO.HasValue)
				request.WithQueryParameter("ORTO", m3ORTO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3DLNI.HasValue)
				request.WithQueryParameter("DLNI", m3DLNI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelDetailsResponse>(
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
