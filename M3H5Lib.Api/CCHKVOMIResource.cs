/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CCHKVOMI;
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
	/// Name: CCHKVOMI
	/// Component Name: VoucherNumber
	/// Description: Retrieve voucher number interface
	/// Version Release: 12.1
	///</summary>
	public partial class CCHKVOMIResource : M3BaseResourceEndpoint
	{
		public CCHKVOMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CCHKVOMI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetNumber
		/// Description Retrieve voucher number
		/// Version Release: 12.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3VSER">Voucher number series (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetNumberResponse></returns>
		/// <exception cref="M3Exception<GetNumberResponse>"></exception>
		public async Task<M3Response<GetNumberResponse>> GetNumber(
			string m3DIVI, 
			string m3VSER, 
			DateTime m3FRDT, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetNumber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3VSER))
				throw new ArgumentNullException(nameof(m3VSER));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("VSER", m3VSER.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetNumberResponse>(
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
