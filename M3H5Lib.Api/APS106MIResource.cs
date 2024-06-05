/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PPYT">Payment request type (Required)</param>
		/// <param name="m3_SPYN">Payer (Required)</param>
		/// <param name="m3_PPYR">Reference number (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PPYN">Payment request number (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPaymentReqResponse></returns>
		/// <exception cref="M3Exception<GetPaymentReqResponse>"></exception>
		public async Task<M3Response<GetPaymentReqResponse>> GetPaymentReq(
			string m3_DIVI, 
			string m3_PPYT, 
			string m3_SPYN, 
			string m3_PPYR, 
			int m3_YEA4, 
			string m3_PPYN, 
			string m3_SUNO, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PPYT))
				throw new ArgumentNullException("m3_PPYT");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_PPYR))
				throw new ArgumentNullException("m3_PPYR");
			if (string.IsNullOrWhiteSpace(m3_PPYN))
				throw new ArgumentNullException("m3_PPYN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PPYT", m3_PPYT.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("PPYR", m3_PPYR.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PPYN", m3_PPYN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Execute the request
			var result = await Execute<GetPaymentReqResponse>(
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
		/// Name LstReqByPayee
		/// Description Lst Request By Payee
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PPYT">Payment request type (Required)</param>
		/// <param name="m3_SPYN">Payee (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReqByPayeeResponse></returns>
		/// <exception cref="M3Exception<LstReqByPayeeResponse>"></exception>
		public async Task<M3Response<LstReqByPayeeResponse>> LstReqByPayee(
			string m3_DIVI, 
			string m3_PPYT, 
			string m3_SPYN, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PPYT))
				throw new ArgumentNullException("m3_PPYT");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PPYT", m3_PPYT.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim());

			// Execute the request
			var result = await Execute<LstReqByPayeeResponse>(
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
		/// Name LstReqByRefNo
		/// Description List Payment Request By RefNo
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PPYT">Payment request type (Required)</param>
		/// <param name="m3_SPYN">Payer (Required)</param>
		/// <param name="m3_PPYR">Reference number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReqByRefNoResponse></returns>
		/// <exception cref="M3Exception<LstReqByRefNoResponse>"></exception>
		public async Task<M3Response<LstReqByRefNoResponse>> LstReqByRefNo(
			string m3_DIVI, 
			string m3_PPYT, 
			string m3_SPYN, 
			string m3_PPYR, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PPYT))
				throw new ArgumentNullException("m3_PPYT");
			if (string.IsNullOrWhiteSpace(m3_SPYN))
				throw new ArgumentNullException("m3_SPYN");
			if (string.IsNullOrWhiteSpace(m3_PPYR))
				throw new ArgumentNullException("m3_PPYR");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PPYT", m3_PPYT.Trim())
				.WithQueryParameter("SPYN", m3_SPYN.Trim())
				.WithQueryParameter("PPYR", m3_PPYR.Trim());

			// Execute the request
			var result = await Execute<LstReqByRefNoResponse>(
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
