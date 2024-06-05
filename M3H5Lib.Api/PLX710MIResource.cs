/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PLX710MI;
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
	/// Name: PLX710MI
	/// Component Name: Financials
	/// Description: COUNTRY: Reference Data on Purchase Invoice
	/// Version Release: 14.x
	///</summary>
	public partial class PLX710MIResource : M3BaseResourceEndpoint
	{
		public PLX710MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PLX710MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetReference
		/// Description Get Invoice Reference
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3STCO">Constant value (Required)</param>
		/// <param name="m3STKY">Key value</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetReferenceResponse></returns>
		/// <exception cref="M3Exception<GetReferenceResponse>"></exception>
		public async Task<M3Response<GetReferenceResponse>> GetReference(
			string m3DIVI, 
			string m3SUNO, 
			string m3SINO, 
			string m3STCO, 
			string m3STKY = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetReference",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));
			if (string.IsNullOrWhiteSpace(m3STCO))
				throw new ArgumentNullException(nameof(m3STCO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("STCO", m3STCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STKY))
				request.WithQueryParameter("STKY", m3STKY.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetReferenceResponse>(
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
