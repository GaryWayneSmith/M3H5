/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS310MI;
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
	/// Name: PPS310MI
	/// Component Name: Quality inspection PO
	/// Description: Api: Quality inspection PO
	/// Version Release: 5ea1
	///</summary>
	public partial class PPS310MIResource : M3BaseResourceEndpoint
	{
		public PPS310MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS310MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CloseQIDelNote
		/// Description Close quality inspection delivery note
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseQIDelNote(
			string m3_WHLO, 
			string m3_SUNO, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CloseQIDelNote",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String());

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
		/// Name GetQIDataPO
		/// Description Get quality inspection data PO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_REPN">Receiving number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQIDataPOResponse></returns>
		/// <exception cref="M3Exception<GetQIDataPOResponse>"></exception>
		public async Task<M3Response<GetQIDataPOResponse>> GetQIDataPO(
			long m3_REPN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetQIDataPO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("REPN", m3_REPN.ToString());

			// Execute the request
			var result = await Execute<GetQIDataPOResponse>(
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
		/// Name LstBalIDQI
		/// Description List Balance ID
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_WHLT">Location type</param>
		/// <param name="m3_ALOC">Allocatable</param>
		/// <param name="m3_FSLT">From stock zone</param>
		/// <param name="m3_TSLT">To stock zone</param>
		/// <param name="m3_ISLT">Include stock zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBalIDQIResponse></returns>
		/// <exception cref="M3Exception<LstBalIDQIResponse>"></exception>
		public async Task<M3Response<LstBalIDQIResponse>> LstBalIDQI(
			string m3_WHLO = null, 
			string m3_ITNO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_WHLT = null, 
			int? m3_ALOC = null, 
			string m3_FSLT = null, 
			string m3_TSLT = null, 
			string m3_ISLT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBalIDQI",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (m3_ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3_ALOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FSLT))
				request.WithQueryParameter("FSLT", m3_FSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSLT))
				request.WithQueryParameter("TSLT", m3_TSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISLT))
				request.WithQueryParameter("ISLT", m3_ISLT.Trim());

			// Execute the request
			var result = await Execute<LstBalIDQIResponse>(
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
		/// Name LstBalIDQI2
		/// Description LstBalIDQI2
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_WHLT">Location type</param>
		/// <param name="m3_ALOC">Allocatable</param>
		/// <param name="m3_FSLT">From stock zone</param>
		/// <param name="m3_TSLT">To stock zone</param>
		/// <param name="m3_ISLT">Include stock zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBalIDQI2Response></returns>
		/// <exception cref="M3Exception<LstBalIDQI2Response>"></exception>
		public async Task<M3Response<LstBalIDQI2Response>> LstBalIDQI2(
			string m3_WHLO = null, 
			string m3_ITNO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_WHLT = null, 
			int? m3_ALOC = null, 
			string m3_FSLT = null, 
			string m3_TSLT = null, 
			string m3_ISLT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBalIDQI2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (m3_ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3_ALOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FSLT))
				request.WithQueryParameter("FSLT", m3_FSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSLT))
				request.WithQueryParameter("TSLT", m3_TSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISLT))
				request.WithQueryParameter("ISLT", m3_ISLT.Trim());

			// Execute the request
			var result = await Execute<LstBalIDQI2Response>(
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
		/// Name LstQIDataPO
		/// Description List quality inspection data PO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_REPN">Receiving number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQIDataPOResponse></returns>
		/// <exception cref="M3Exception<LstQIDataPOResponse>"></exception>
		public async Task<M3Response<LstQIDataPOResponse>> LstQIDataPO(
			long m3_REPN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQIDataPO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("REPN", m3_REPN.ToString());

			// Execute the request
			var result = await Execute<LstQIDataPOResponse>(
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
		/// Name LstQIDataPack
		/// Description List quality inspection data package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQIDataPackResponse></returns>
		/// <exception cref="M3Exception<LstQIDataPackResponse>"></exception>
		public async Task<M3Response<LstQIDataPackResponse>> LstQIDataPack(
			string m3_PACN = null, 
			string m3_WHLO = null, 
			string m3_SUNO = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQIDataPack",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstQIDataPackResponse>(
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
		/// Name LstQIDataSSCC
		/// Description List quality inspection data SSCC
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SSCC">SSCC number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQIDataSSCCResponse></returns>
		/// <exception cref="M3Exception<LstQIDataSSCCResponse>"></exception>
		public async Task<M3Response<LstQIDataSSCCResponse>> LstQIDataSSCC(
			string m3_SSCC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQIDataSSCC",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SSCC))
				throw new ArgumentNullException("m3_SSCC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<LstQIDataSSCCResponse>(
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
		/// Name LstReceivedPO
		/// Description List Received Purchase Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReceivedPOResponse></returns>
		/// <exception cref="M3Exception<LstReceivedPOResponse>"></exception>
		public async Task<M3Response<LstReceivedPOResponse>> LstReceivedPO(
			string m3_PUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstReceivedPO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Execute the request
			var result = await Execute<LstReceivedPOResponse>(
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
		/// Name LstRejectReason
		/// Description List reject reason
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRejectReasonResponse></returns>
		/// <exception cref="M3Exception<LstRejectReasonResponse>"></exception>
		public async Task<M3Response<LstRejectReasonResponse>> LstRejectReason(
			string m3_SCRE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRejectReason",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());

			// Execute the request
			var result = await Execute<LstRejectReasonResponse>(
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
		/// Name QualityInspPO
		/// Description Quality inspection PO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_REPN">Receiving number (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_QCRA">Quality inspection result (Required)</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_AQTY">Approved quantity</param>
		/// <param name="m3_AWHS">Approved Location</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_AREM">Approved Remark</param>
		/// <param name="m3_ABAN">Approved Lot number</param>
		/// <param name="m3_BREF">Approved Lot reference 1</param>
		/// <param name="m3_BRE2">Approved Lot reference 2</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_CNDT">Follow-up date</param>
		/// <param name="m3_SEDT">Sales date</param>
		/// <param name="m3_NOPK">Number of packages</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_RJQA">Rejected quantity</param>
		/// <param name="m3_RWHS">Reject Location</param>
		/// <param name="m3_RBAN">Reject Lot number</param>
		/// <param name="m3_RREM">Reject Remark</param>
		/// <param name="m3_WPRF">Service not performed</param>
		/// <param name="m3_SVDT">Service date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> QualityInspPO(
			long m3_REPN, 
			string m3_RESP, 
			string m3_QCRA, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			decimal? m3_AQTY = null, 
			string m3_AWHS = null, 
			int? m3_OEND = null, 
			string m3_AREM = null, 
			string m3_ABAN = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_CAMU = null, 
			DateTime? m3_CNDT = null, 
			DateTime? m3_SEDT = null, 
			int? m3_NOPK = null, 
			string m3_SCRE = null, 
			decimal? m3_RJQA = null, 
			string m3_RWHS = null, 
			string m3_RBAN = null, 
			string m3_RREM = null, 
			int? m3_WPRF = null, 
			DateTime? m3_SVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/QualityInspPO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");
			if (string.IsNullOrWhiteSpace(m3_QCRA))
				throw new ArgumentNullException("m3_QCRA");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPN", m3_REPN.ToString())
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("QCRA", m3_QCRA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_AQTY.HasValue)
				request.WithQueryParameter("AQTY", m3_AQTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AWHS))
				request.WithQueryParameter("AWHS", m3_AWHS.Trim());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AREM))
				request.WithQueryParameter("AREM", m3_AREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABAN))
				request.WithQueryParameter("ABAN", m3_ABAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3_CNDT.Value.ToM3String());
			if (m3_SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3_SEDT.Value.ToM3String());
			if (m3_NOPK.HasValue)
				request.WithQueryParameter("NOPK", m3_NOPK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (m3_RJQA.HasValue)
				request.WithQueryParameter("RJQA", m3_RJQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RWHS))
				request.WithQueryParameter("RWHS", m3_RWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RBAN))
				request.WithQueryParameter("RBAN", m3_RBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RREM))
				request.WithQueryParameter("RREM", m3_RREM.Trim());
			if (m3_WPRF.HasValue)
				request.WithQueryParameter("WPRF", m3_WPRF.Value.ToString());
			if (m3_SVDT.HasValue)
				request.WithQueryParameter("SVDT", m3_SVDT.Value.ToM3String());

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
		/// Name QualityInspPack
		/// Description Quality inspection package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_QCRA">Quality inspection result (Required)</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_AWHS">Approved Location</param>
		/// <param name="m3_RWHS">Rejected Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> QualityInspPack(
			string m3_RESP, 
			string m3_QCRA, 
			string m3_PACN = null, 
			string m3_WHLO = null, 
			string m3_SUNO = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			string m3_SCRE = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			string m3_AWHS = null, 
			string m3_RWHS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/QualityInspPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");
			if (string.IsNullOrWhiteSpace(m3_QCRA))
				throw new ArgumentNullException("m3_QCRA");

			// Set mandatory parameters
			request
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("QCRA", m3_QCRA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AWHS))
				request.WithQueryParameter("AWHS", m3_AWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RWHS))
				request.WithQueryParameter("RWHS", m3_RWHS.Trim());

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
		/// Name QualityInspSSCC
		/// Description Quality inspection SSCC
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SSCC">SSCC number (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_QCRA">Quality inspection result (Required)</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_AWHS">Approved Location</param>
		/// <param name="m3_RWHS">Rejected Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> QualityInspSSCC(
			string m3_SSCC, 
			string m3_RESP, 
			string m3_QCRA, 
			string m3_SCRE = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			string m3_AWHS = null, 
			string m3_RWHS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/QualityInspSSCC",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SSCC))
				throw new ArgumentNullException("m3_SSCC");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");
			if (string.IsNullOrWhiteSpace(m3_QCRA))
				throw new ArgumentNullException("m3_QCRA");

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3_SSCC.Trim())
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("QCRA", m3_QCRA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AWHS))
				request.WithQueryParameter("AWHS", m3_AWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RWHS))
				request.WithQueryParameter("RWHS", m3_RWHS.Trim());

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
