/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS124MI;
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
	/// Name: MOS124MI
	/// Component Name: MaintenanceRemoveInstall
	/// Description: Removal Installation Transactions
	/// Version Release: 5ea0
	///</summary>
	public partial class MOS124MIResource : M3BaseResourceEndpoint
	{
		public MOS124MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS124MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetLatestRem
		/// Description Get Information from latest Removal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNR">Item number (Required)</param>
		/// <param name="m3_BANR">Lot number (Required)</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRT1">Transaction time</param>
		/// <param name="m3_TRT2">Transaction time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLatestRemResponse></returns>
		/// <exception cref="M3Exception<GetLatestRemResponse>"></exception>
		public async Task<M3Response<GetLatestRemResponse>> GetLatestRem(
			string m3_ITNR, 
			string m3_BANR, 
			DateTime? m3_TRDT = null, 
			int? m3_TRT1 = null, 
			int? m3_TRT2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLatestRem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNR))
				throw new ArgumentNullException("m3_ITNR");
			if (string.IsNullOrWhiteSpace(m3_BANR))
				throw new ArgumentNullException("m3_BANR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNR", m3_ITNR.Trim())
				.WithQueryParameter("BANR", m3_BANR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRT1.HasValue)
				request.WithQueryParameter("TRT1", m3_TRT1.Value.ToString());
			if (m3_TRT2.HasValue)
				request.WithQueryParameter("TRT2", m3_TRT2.Value.ToString());

			// Execute the request
			var result = await Execute<GetLatestRemResponse>(
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
		/// Name PrintRemovalTag
		/// Description PrintRemovalTag
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RITR">Removal/installation transaction number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintRemovalTag(
			string m3_RITR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrintRemovalTag",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RITR))
				throw new ArgumentNullException("m3_RITR");

			// Set mandatory parameters
			request
				.WithQueryParameter("RITR", m3_RITR.Trim());

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
