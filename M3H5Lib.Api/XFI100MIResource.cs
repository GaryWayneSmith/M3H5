/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.XFI100MI;
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
	/// Name: XFI100MI
	/// Component Name: Financials
	/// Description: COUNTRY: Reference Data on Purchase Invoice
	/// Version Release: 14.x
	///</summary>
	public partial class XFI100MIResource : M3BaseResourceEndpoint
	{
		public XFI100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "XFI100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetReference
		/// Description Get Invoice Reference
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_SINO">Supplier invoice number (Required)</param>
		/// <param name="m3_STCO">Constant value (Required)</param>
		/// <param name="m3_STKY">Key value</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetReferenceResponse></returns>
		/// <exception cref="M3Exception<GetReferenceResponse>"></exception>
		public async Task<M3Response<GetReferenceResponse>> GetReference(
			string m3_DIVI, 
			string m3_SUNO, 
			string m3_SINO, 
			string m3_STCO, 
			string m3_STKY = null, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetReference",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SINO))
				throw new ArgumentNullException("m3_SINO");
			if (string.IsNullOrWhiteSpace(m3_STCO))
				throw new ArgumentNullException("m3_STCO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SINO", m3_SINO.Trim())
				.WithQueryParameter("STCO", m3_STCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STKY))
				request.WithQueryParameter("STKY", m3_STKY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetReferenceResponse>(
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
