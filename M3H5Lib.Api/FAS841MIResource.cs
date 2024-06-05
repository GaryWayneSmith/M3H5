/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.FAS841MI;
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
	/// Name: FAS841MI
	/// Component Name: Deprecn plan simulation header
	/// Description: Deprecn plan simulation header API
	/// Version Release: 5ea0
	///</summary>
	public partial class FAS841MIResource : M3BaseResourceEndpoint
	{
		public FAS841MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "FAS841MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstSimPeriods
		/// Description list depreciation plan simulation periods
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ASID">Fixed asset (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="m3DPTP">Depreciation type (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSimPeriodsResponse></returns>
		/// <exception cref="M3Exception<LstSimPeriodsResponse>"></exception>
		public async Task<M3Response<LstSimPeriodsResponse>> LstSimPeriods(
			string m3ASID, 
			int m3SBNO, 
			int m3DPTP, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSimPeriods",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ASID))
				throw new ArgumentNullException(nameof(m3ASID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ASID", m3ASID.Trim())
				.WithQueryParameter("SBNO", m3SBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DPTP", m3DPTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstSimPeriodsResponse>(
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
