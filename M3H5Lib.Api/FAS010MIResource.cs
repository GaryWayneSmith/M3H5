/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstAssetUsage
		/// Description List Fixed asset usage plan
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ASID">Fixed asset (Required)</param>
		/// <param name="m3_SBNO">Subnumber (Required)</param>
		/// <param name="m3_DPTP">Depreciation type (Required)</param>
		/// <param name="m3_VPER">Value period</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssetUsageResponse></returns>
		/// <exception cref="M3Exception<LstAssetUsageResponse>"></exception>
		public async Task<M3Response<LstAssetUsageResponse>> LstAssetUsage(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_ASID, 
			int m3_SBNO, 
			int m3_DPTP, 
			int? m3_VPER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssetUsage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ASID))
				throw new ArgumentNullException("m3_ASID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("ASID", m3_ASID.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.ToString())
				.WithQueryParameter("DPTP", m3_DPTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_VPER.HasValue)
				request.WithQueryParameter("VPER", m3_VPER.Value.ToString());

			// Execute the request
			var result = await Execute<LstAssetUsageResponse>(
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

		/// <summary>
		/// Name UpdAssetUsage
		/// Description Update Fixed asset usage
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ASID">Fixed asset (Required)</param>
		/// <param name="m3_SBNO">Subnumber (Required)</param>
		/// <param name="m3_DPTP">Depreciation type (Required)</param>
		/// <param name="m3_VPER">Value period (Required)</param>
		/// <param name="m3_USSH">Used share (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAssetUsage(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_ASID, 
			int m3_SBNO, 
			int m3_DPTP, 
			int m3_VPER, 
			decimal m3_USSH, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAssetUsage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ASID))
				throw new ArgumentNullException("m3_ASID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("ASID", m3_ASID.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.ToString())
				.WithQueryParameter("DPTP", m3_DPTP.ToString())
				.WithQueryParameter("VPER", m3_VPER.ToString())
				.WithQueryParameter("USSH", m3_USSH.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
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
