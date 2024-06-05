/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CRS036MI;
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
	/// Name: CRS036MI
	/// Component Name: BusinessArea
	/// Description: Business area
	/// Version Release: 12.6
	///</summary>
	public partial class CRS036MIResource : M3BaseResourceEndpoint
	{
		public CRS036MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS036MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstBusinessArea
		/// Description Business area
		/// Version Release: 12.6
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRBU">From Business Area</param>
		/// <param name="m3TOBU">To Business Area</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBusinessAreaResponse></returns>
		/// <exception cref="M3Exception<LstBusinessAreaResponse>"></exception>
		public async Task<M3Response<LstBusinessAreaResponse>> LstBusinessArea(
			int? m3CONO = null, 
			string m3FRBU = null, 
			string m3TOBU = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBusinessArea",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRBU))
				request.WithQueryParameter("FRBU", m3FRBU.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOBU))
				request.WithQueryParameter("TOBU", m3TOBU.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstBusinessAreaResponse>(
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
