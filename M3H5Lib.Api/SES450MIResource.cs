/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SES450MI;
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
	/// Name: SES450MI
	/// Component Name: eSignature
	/// Description: eSignature interface
	/// Version Release: 5ea0
	///</summary>
	public partial class SES450MIResource : M3BaseResourceEndpoint
	{
		public SES450MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SES450MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetEsignature
		/// Description Get data for eSignature
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ESID">Esign number (Required)</param>
		/// <param name="m3_WORK">Workflow (Required)</param>
		/// <param name="m3_USID">Signatory (Required)</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEsignatureResponse></returns>
		/// <exception cref="M3Exception<GetEsignatureResponse>"></exception>
		public async Task<M3Response<GetEsignatureResponse>> GetEsignature(
			string m3_ESID, 
			int m3_WORK, 
			string m3_USID, 
			string m3_FLDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetEsignature",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ESID))
				throw new ArgumentNullException("m3_ESID");
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ESID", m3_ESID.Trim())
				.WithQueryParameter("WORK", m3_WORK.ToString())
				.WithQueryParameter("USID", m3_USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Execute the request
			var result = await Execute<GetEsignatureResponse>(
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
		/// Name LstEsignatures
		/// Description List data for eSignatures
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ESID">Esign number (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_WORK">Workflow</param>
		/// <param name="m3_USID">Signatory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEsignaturesResponse></returns>
		/// <exception cref="M3Exception<LstEsignaturesResponse>"></exception>
		public async Task<M3Response<LstEsignaturesResponse>> LstEsignatures(
			string m3_ESID, 
			string m3_FLDI, 
			int? m3_WORK = null, 
			string m3_USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstEsignatures",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ESID))
				throw new ArgumentNullException("m3_ESID");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("ESID", m3_ESID.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_WORK.HasValue)
				request.WithQueryParameter("WORK", m3_WORK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<LstEsignaturesResponse>(
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
