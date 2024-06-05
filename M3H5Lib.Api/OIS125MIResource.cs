/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS125MI;
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
	/// Name: OIS125MI
	/// Component Name: PaymentRequest
	/// Description: Payment request
	/// Version Release: 5e90
	///</summary>
	public partial class OIS125MIResource : M3BaseResourceEndpoint
	{
		public OIS125MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS125MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddFinalPayment
		/// Description Add final payment request
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_COIV">Co/Invoice no (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_IVAM">Invoice amount - local currency (Required)</param>
		/// <param name="m3_RQDT">Need date</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddFinalPaymentResponse></returns>
		/// <exception cref="M3Exception<AddFinalPaymentResponse>"></exception>
		public async Task<M3Response<AddFinalPaymentResponse>> AddFinalPayment(
			string m3_DIVI, 
			string m3_COIV, 
			int m3_YEA4, 
			string m3_STAT, 
			decimal m3_IVAM, 
			DateTime? m3_RQDT = null, 
			string m3_TEPY = null, 
			string m3_TX30 = null, 
			string m3_TX60 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFinalPayment",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_COIV))
				throw new ArgumentNullException("m3_COIV");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("COIV", m3_COIV.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("STAT", m3_STAT.Trim())
				.WithQueryParameter("IVAM", m3_IVAM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RQDT.HasValue)
				request.WithQueryParameter("RQDT", m3_RQDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());

			// Execute the request
			var result = await Execute<AddFinalPaymentResponse>(
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
		/// Name AddGenPrePmt
		/// Description Add Generic prepayments
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_COIV">Co/Invoice no (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_IVAM">Invoice amount - local currency (Required)</param>
		/// <param name="m3_RQDT">Need date</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddGenPrePmtResponse></returns>
		/// <exception cref="M3Exception<AddGenPrePmtResponse>"></exception>
		public async Task<M3Response<AddGenPrePmtResponse>> AddGenPrePmt(
			string m3_DIVI, 
			string m3_COIV, 
			string m3_STAT, 
			decimal m3_IVAM, 
			DateTime? m3_RQDT = null, 
			string m3_TEPY = null, 
			int? m3_VTCD = null, 
			string m3_TX30 = null, 
			string m3_TX60 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddGenPrePmt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_COIV))
				throw new ArgumentNullException("m3_COIV");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("COIV", m3_COIV.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim())
				.WithQueryParameter("IVAM", m3_IVAM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RQDT.HasValue)
				request.WithQueryParameter("RQDT", m3_RQDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());

			// Execute the request
			var result = await Execute<AddGenPrePmtResponse>(
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
		/// Name AddPrePayment
		/// Description Add prepayments
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_COIV">Co/Invoice no (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_IVAM">Invoice amount - local currency (Required)</param>
		/// <param name="m3_RQDT">Need date</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPrePaymentResponse></returns>
		/// <exception cref="M3Exception<AddPrePaymentResponse>"></exception>
		public async Task<M3Response<AddPrePaymentResponse>> AddPrePayment(
			string m3_DIVI, 
			string m3_COIV, 
			string m3_STAT, 
			decimal m3_IVAM, 
			DateTime? m3_RQDT = null, 
			string m3_TEPY = null, 
			int? m3_VTCD = null, 
			string m3_TX30 = null, 
			string m3_TX60 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPrePayment",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_COIV))
				throw new ArgumentNullException("m3_COIV");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("COIV", m3_COIV.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim())
				.WithQueryParameter("IVAM", m3_IVAM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RQDT.HasValue)
				request.WithQueryParameter("RQDT", m3_RQDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());

			// Execute the request
			var result = await Execute<AddPrePaymentResponse>(
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
		/// Name LstFinPayByIVNO
		/// Description List final payment request by invoice number
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_COIV">Co/Invoice no</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFinPayByIVNOResponse></returns>
		/// <exception cref="M3Exception<LstFinPayByIVNOResponse>"></exception>
		public async Task<M3Response<LstFinPayByIVNOResponse>> LstFinPayByIVNO(
			string m3_DIVI = null, 
			string m3_COIV = null, 
			int? m3_YEA4 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFinPayByIVNO",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COIV))
				request.WithQueryParameter("COIV", m3_COIV.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());

			// Execute the request
			var result = await Execute<LstFinPayByIVNOResponse>(
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
		/// Name LstPrePayByCO
		/// Description List prepayment request by customer number
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_COIV">Co/Invoice no (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPrePayByCOResponse></returns>
		/// <exception cref="M3Exception<LstPrePayByCOResponse>"></exception>
		public async Task<M3Response<LstPrePayByCOResponse>> LstPrePayByCO(
			string m3_DIVI, 
			string m3_COIV, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPrePayByCO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_COIV))
				throw new ArgumentNullException("m3_COIV");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("COIV", m3_COIV.Trim());

			// Execute the request
			var result = await Execute<LstPrePayByCOResponse>(
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
		/// Name UpdFinalPayStat
		/// Description Update final payment status
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PPYN">Payment request  number (Required)</param>
		/// <param name="m3_RYEA">Year (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdFinalPayStat(
			string m3_DIVI, 
			string m3_PPYN, 
			int m3_RYEA, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdFinalPayStat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PPYN))
				throw new ArgumentNullException("m3_PPYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PPYN", m3_PPYN.Trim())
				.WithQueryParameter("RYEA", m3_RYEA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

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

		/// <summary>
		/// Name UpdPrePayStatus
		/// Description Update pre payment status
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PPYN">Payment request  number (Required)</param>
		/// <param name="m3_RYEA">Year (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPrePayStatus(
			string m3_DIVI, 
			string m3_PPYN, 
			int m3_RYEA, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPrePayStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PPYN))
				throw new ArgumentNullException("m3_PPYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PPYN", m3_PPYN.Trim())
				.WithQueryParameter("RYEA", m3_RYEA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

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
