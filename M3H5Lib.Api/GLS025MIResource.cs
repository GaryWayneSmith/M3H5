/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.GLS025MI;
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
	/// Name: GLS025MI
	/// Component Name: Finance
	/// Description: Api: Accounting translation
	/// Version Release: 
	///</summary>
	public partial class GLS025MIResource : M3BaseResourceEndpoint
	{
		public GLS025MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "GLS025MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetAcntIdCtgry
		/// Description Get accounting id category
		/// Version Release: 
		/// </summary>
		/// <param name="m3SCEN">Scenario (Required)</param>
		/// <param name="m3AITP">Accounting dimension (Required)</param>
		/// <param name="m3AITM">Accounting identity (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAcntIdCtgryResponse></returns>
		/// <exception cref="M3Exception<GetAcntIdCtgryResponse>"></exception>
		public async Task<M3Response<GetAcntIdCtgryResponse>> GetAcntIdCtgry(
			string m3SCEN, 
			int m3AITP, 
			string m3AITM, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAcntIdCtgry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEN))
				throw new ArgumentNullException(nameof(m3SCEN));
			if (string.IsNullOrWhiteSpace(m3AITM))
				throw new ArgumentNullException(nameof(m3AITM));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEN", m3SCEN.Trim())
				.WithQueryParameter("AITP", m3AITP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("AITM", m3AITM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetAcntIdCtgryResponse>(
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
