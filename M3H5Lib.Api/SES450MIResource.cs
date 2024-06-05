/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3ESID">Esign number (Required)</param>
		/// <param name="m3WORK">Workflow (Required)</param>
		/// <param name="m3USID">Signatory (Required)</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEsignatureResponse></returns>
		/// <exception cref="M3Exception<GetEsignatureResponse>"></exception>
		public async Task<M3Response<GetEsignatureResponse>> GetEsignature(
			string m3ESID, 
			int m3WORK, 
			string m3USID, 
			string m3FLDI = null, 
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
			if (string.IsNullOrWhiteSpace(m3ESID))
				throw new ArgumentNullException(nameof(m3ESID));
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ESID", m3ESID.Trim())
				.WithQueryParameter("WORK", m3WORK.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("USID", m3USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<GetEsignatureResponse>(
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
		/// Name LstEsignatures
		/// Description List data for eSignatures
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ESID">Esign number (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3WORK">Workflow</param>
		/// <param name="m3USID">Signatory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEsignaturesResponse></returns>
		/// <exception cref="M3Exception<LstEsignaturesResponse>"></exception>
		public async Task<M3Response<LstEsignaturesResponse>> LstEsignatures(
			string m3ESID, 
			string m3FLDI, 
			int? m3WORK = null, 
			string m3USID = null, 
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
			if (string.IsNullOrWhiteSpace(m3ESID))
				throw new ArgumentNullException(nameof(m3ESID));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("ESID", m3ESID.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3WORK.HasValue)
				request.WithQueryParameter("WORK", m3WORK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());

			// Execute the request
			var result = await Execute<LstEsignaturesResponse>(
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
