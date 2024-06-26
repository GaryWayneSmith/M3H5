/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CRS140MI;
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
	/// Name: CRS140MI
	/// Component Name: District
	/// Description: District interface
	/// Version Release: 12.2
	///</summary>
	public partial class CRS140MIResource : M3BaseResourceEndpoint
	{
		public CRS140MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS140MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstDistrict
		/// Description List District information
		/// Version Release: 12.2
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRSD">From district</param>
		/// <param name="m3TOSD">To district</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDistrictResponse></returns>
		/// <exception cref="M3Exception<LstDistrictResponse>"></exception>
		public async Task<M3Response<LstDistrictResponse>> LstDistrict(
			int? m3CONO = null, 
			string m3FRSD = null, 
			string m3TOSD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDistrict",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRSD))
				request.WithQueryParameter("FRSD", m3FRSD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOSD))
				request.WithQueryParameter("TOSD", m3TOSD.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDistrictResponse>(
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
