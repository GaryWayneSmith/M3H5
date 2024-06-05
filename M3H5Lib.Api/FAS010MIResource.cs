/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.FAS010MI;
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
	/// Name: FAS010MI
	/// Component Name: Financials
	/// Description: Api: Usage based depreciation interface
	/// Version Release: 14.x
	///</summary>
	public partial class FAS010MIResource : M3BaseResourceEndpoint
	{
		public FAS010MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "FAS010MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstAssetUsage
		/// Description List Fixed asset usage plan
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3ASID">Fixed asset (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="m3DPTP">Depreciation type (Required)</param>
		/// <param name="m3VPER">Value period</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssetUsageResponse></returns>
		/// <exception cref="M3Exception<LstAssetUsageResponse>"></exception>
		public async Task<M3Response<LstAssetUsageResponse>> LstAssetUsage(
			int m3CONO, 
			string m3DIVI, 
			string m3ASID, 
			int m3SBNO, 
			int m3DPTP, 
			int? m3VPER = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAssetUsage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3ASID))
				throw new ArgumentNullException(nameof(m3ASID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("ASID", m3ASID.Trim())
				.WithQueryParameter("SBNO", m3SBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DPTP", m3DPTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3VPER.HasValue)
				request.WithQueryParameter("VPER", m3VPER.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAssetUsageResponse>(
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

		/// <summary>
		/// Name UpdAssetUsage
		/// Description Update Fixed asset usage
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3ASID">Fixed asset (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="m3DPTP">Depreciation type (Required)</param>
		/// <param name="m3VPER">Value period (Required)</param>
		/// <param name="m3USSH">Used share (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAssetUsage(
			int m3CONO, 
			string m3DIVI, 
			string m3ASID, 
			int m3SBNO, 
			int m3DPTP, 
			int m3VPER, 
			decimal m3USSH, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAssetUsage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3ASID))
				throw new ArgumentNullException(nameof(m3ASID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("ASID", m3ASID.Trim())
				.WithQueryParameter("SBNO", m3SBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DPTP", m3DPTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VPER", m3VPER.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("USSH", m3USSH.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
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
