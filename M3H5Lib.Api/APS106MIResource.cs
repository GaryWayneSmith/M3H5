/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.APS106MI;
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
	/// Name: APS106MI
	/// Component Name: APS106
	/// Description: Pre Payments lines
	/// Version Release: 5e90
	///</summary>
	public partial class APS106MIResource : M3BaseResourceEndpoint
	{
		public APS106MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APS106MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPaymentReq
		/// Description Get Payment request line
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PPYT">Payment request type (Required)</param>
		/// <param name="m3SPYN">Payer (Required)</param>
		/// <param name="m3PPYR">Reference number (Required)</param>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3PPYN">Payment request number (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPaymentReqResponse></returns>
		/// <exception cref="M3Exception<GetPaymentReqResponse>"></exception>
		public async Task<M3Response<GetPaymentReqResponse>> GetPaymentReq(
			string m3DIVI, 
			string m3PPYT, 
			string m3SPYN, 
			string m3PPYR, 
			int m3YEA4, 
			string m3PPYN, 
			string m3SUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPaymentReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PPYT))
				throw new ArgumentNullException(nameof(m3PPYT));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3PPYR))
				throw new ArgumentNullException(nameof(m3PPYR));
			if (string.IsNullOrWhiteSpace(m3PPYN))
				throw new ArgumentNullException(nameof(m3PPYN));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PPYT", m3PPYT.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("PPYR", m3PPYR.Trim())
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PPYN", m3PPYN.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Execute the request
			var result = await Execute<GetPaymentReqResponse>(
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
		/// Name LstReqByPayee
		/// Description Lst Request By Payee
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PPYT">Payment request type (Required)</param>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReqByPayeeResponse></returns>
		/// <exception cref="M3Exception<LstReqByPayeeResponse>"></exception>
		public async Task<M3Response<LstReqByPayeeResponse>> LstReqByPayee(
			string m3DIVI, 
			string m3PPYT, 
			string m3SPYN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstReqByPayee",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PPYT))
				throw new ArgumentNullException(nameof(m3PPYT));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PPYT", m3PPYT.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim());

			// Execute the request
			var result = await Execute<LstReqByPayeeResponse>(
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
		/// Name LstReqByRefNo
		/// Description List Payment Request By RefNo
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PPYT">Payment request type (Required)</param>
		/// <param name="m3SPYN">Payer (Required)</param>
		/// <param name="m3PPYR">Reference number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReqByRefNoResponse></returns>
		/// <exception cref="M3Exception<LstReqByRefNoResponse>"></exception>
		public async Task<M3Response<LstReqByRefNoResponse>> LstReqByRefNo(
			string m3DIVI, 
			string m3PPYT, 
			string m3SPYN, 
			string m3PPYR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstReqByRefNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PPYT))
				throw new ArgumentNullException(nameof(m3PPYT));
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3PPYR))
				throw new ArgumentNullException(nameof(m3PPYR));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PPYT", m3PPYT.Trim())
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("PPYR", m3PPYR.Trim());

			// Execute the request
			var result = await Execute<LstReqByRefNoResponse>(
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
