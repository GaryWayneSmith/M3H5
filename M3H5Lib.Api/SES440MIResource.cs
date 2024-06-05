/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.SES440MI;
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
	/// Name: SES440MI
	/// Component Name: eSign Record
	/// Description: eSign Record interface
	/// Version Release: 5ea0
	///</summary>
	public partial class SES440MIResource : M3BaseResourceEndpoint
	{
		public SES440MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SES440MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetEsignRecord
		/// Description Get data for an eSign Record
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ESID">Esign number (Required)</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEsignRecordResponse></returns>
		/// <exception cref="M3Exception<GetEsignRecordResponse>"></exception>
		public async Task<M3Response<GetEsignRecordResponse>> GetEsignRecord(
			string m3ESID, 
			string m3FLDI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetEsignRecord",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ESID))
				throw new ArgumentNullException(nameof(m3ESID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ESID", m3ESID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<GetEsignRecordResponse>(
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
		/// Name LstEsignRecords
		/// Description List data for eSign Records
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ESID">Esign number</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEsignRecordsResponse></returns>
		/// <exception cref="M3Exception<LstEsignRecordsResponse>"></exception>
		public async Task<M3Response<LstEsignRecordsResponse>> LstEsignRecords(
			string m3ESID = null, 
			string m3FLDI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstEsignRecords",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ESID))
				request.WithQueryParameter("ESID", m3ESID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<LstEsignRecordsResponse>(
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
