/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseQIDelNote(
			string m3WHLO, 
			string m3SUNO, 
			string m3SUDO, 
			DateTime m3DNDT, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name GetQIDataPO
		/// Description Get quality inspection data PO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3REPN">Receiving number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQIDataPOResponse></returns>
		/// <exception cref="M3Exception<GetQIDataPOResponse>"></exception>
		public async Task<M3Response<GetQIDataPOResponse>> GetQIDataPO(
			long m3REPN, 
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
				.WithQueryParameter("REPN", m3REPN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetQIDataPOResponse>(
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
		/// Name LstBalIDQI
		/// Description List Balance ID
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3WHLT">Location type</param>
		/// <param name="m3ALOC">Allocatable</param>
		/// <param name="m3FSLT">From stock zone</param>
		/// <param name="m3TSLT">To stock zone</param>
		/// <param name="m3ISLT">Include stock zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBalIDQIResponse></returns>
		/// <exception cref="M3Exception<LstBalIDQIResponse>"></exception>
		public async Task<M3Response<LstBalIDQIResponse>> LstBalIDQI(
			string m3WHLO = null, 
			string m3ITNO = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3WHLT = null, 
			int? m3ALOC = null, 
			string m3FSLT = null, 
			string m3TSLT = null, 
			string m3ISLT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (m3ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3ALOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FSLT))
				request.WithQueryParameter("FSLT", m3FSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSLT))
				request.WithQueryParameter("TSLT", m3TSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISLT))
				request.WithQueryParameter("ISLT", m3ISLT.Trim());

			// Execute the request
			var result = await Execute<LstBalIDQIResponse>(
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
		/// Name LstBalIDQI2
		/// Description LstBalIDQI2
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3WHLT">Location type</param>
		/// <param name="m3ALOC">Allocatable</param>
		/// <param name="m3FSLT">From stock zone</param>
		/// <param name="m3TSLT">To stock zone</param>
		/// <param name="m3ISLT">Include stock zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBalIDQI2Response></returns>
		/// <exception cref="M3Exception<LstBalIDQI2Response>"></exception>
		public async Task<M3Response<LstBalIDQI2Response>> LstBalIDQI2(
			string m3WHLO = null, 
			string m3ITNO = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3WHLT = null, 
			int? m3ALOC = null, 
			string m3FSLT = null, 
			string m3TSLT = null, 
			string m3ISLT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (m3ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3ALOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FSLT))
				request.WithQueryParameter("FSLT", m3FSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSLT))
				request.WithQueryParameter("TSLT", m3TSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISLT))
				request.WithQueryParameter("ISLT", m3ISLT.Trim());

			// Execute the request
			var result = await Execute<LstBalIDQI2Response>(
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
		/// Name LstQIDataPO
		/// Description List quality inspection data PO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3REPN">Receiving number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQIDataPOResponse></returns>
		/// <exception cref="M3Exception<LstQIDataPOResponse>"></exception>
		public async Task<M3Response<LstQIDataPOResponse>> LstQIDataPO(
			long m3REPN, 
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
				.WithQueryParameter("REPN", m3REPN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstQIDataPOResponse>(
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
		/// Name LstQIDataPack
		/// Description List quality inspection data package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQIDataPackResponse></returns>
		/// <exception cref="M3Exception<LstQIDataPackResponse>"></exception>
		public async Task<M3Response<LstQIDataPackResponse>> LstQIDataPack(
			string m3PACN = null, 
			string m3WHLO = null, 
			string m3SUNO = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstQIDataPackResponse>(
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
		/// Name LstQIDataSSCC
		/// Description List quality inspection data SSCC
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SSCC">SSCC number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQIDataSSCCResponse></returns>
		/// <exception cref="M3Exception<LstQIDataSSCCResponse>"></exception>
		public async Task<M3Response<LstQIDataSSCCResponse>> LstQIDataSSCC(
			string m3SSCC, 
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
			if (string.IsNullOrWhiteSpace(m3SSCC))
				throw new ArgumentNullException(nameof(m3SSCC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3SSCC.Trim());

			// Execute the request
			var result = await Execute<LstQIDataSSCCResponse>(
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
		/// Name LstReceivedPO
		/// Description List Received Purchase Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReceivedPOResponse></returns>
		/// <exception cref="M3Exception<LstReceivedPOResponse>"></exception>
		public async Task<M3Response<LstReceivedPOResponse>> LstReceivedPO(
			string m3PUNO, 
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
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Execute the request
			var result = await Execute<LstReceivedPOResponse>(
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
		/// Name LstRejectReason
		/// Description List reject reason
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRejectReasonResponse></returns>
		/// <exception cref="M3Exception<LstRejectReasonResponse>"></exception>
		public async Task<M3Response<LstRejectReasonResponse>> LstRejectReason(
			string m3SCRE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());

			// Execute the request
			var result = await Execute<LstRejectReasonResponse>(
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
		/// Name QualityInspPO
		/// Description Quality inspection PO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3REPN">Receiving number (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3QCRA">Quality inspection result (Required)</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3AQTY">Approved quantity</param>
		/// <param name="m3AWHS">Approved Location</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3AREM">Approved Remark</param>
		/// <param name="m3ABAN">Approved Lot number</param>
		/// <param name="m3BREF">Approved Lot reference 1</param>
		/// <param name="m3BRE2">Approved Lot reference 2</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3CNDT">Follow-up date</param>
		/// <param name="m3SEDT">Sales date</param>
		/// <param name="m3NOPK">Number of packages</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3RJQA">Rejected quantity</param>
		/// <param name="m3RWHS">Reject Location</param>
		/// <param name="m3RBAN">Reject Lot number</param>
		/// <param name="m3RREM">Reject Remark</param>
		/// <param name="m3WPRF">Service not performed</param>
		/// <param name="m3SVDT">Service date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> QualityInspPO(
			long m3REPN, 
			string m3RESP, 
			string m3QCRA, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			decimal? m3AQTY = null, 
			string m3AWHS = null, 
			int? m3OEND = null, 
			string m3AREM = null, 
			string m3ABAN = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3CAMU = null, 
			DateTime? m3CNDT = null, 
			DateTime? m3SEDT = null, 
			int? m3NOPK = null, 
			string m3SCRE = null, 
			decimal? m3RJQA = null, 
			string m3RWHS = null, 
			string m3RBAN = null, 
			string m3RREM = null, 
			int? m3WPRF = null, 
			DateTime? m3SVDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));
			if (string.IsNullOrWhiteSpace(m3QCRA))
				throw new ArgumentNullException(nameof(m3QCRA));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPN", m3REPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RESP", m3RESP.Trim())
				.WithQueryParameter("QCRA", m3QCRA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AQTY.HasValue)
				request.WithQueryParameter("AQTY", m3AQTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AWHS))
				request.WithQueryParameter("AWHS", m3AWHS.Trim());
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AREM))
				request.WithQueryParameter("AREM", m3AREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABAN))
				request.WithQueryParameter("ABAN", m3ABAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3CNDT.Value.ToM3String());
			if (m3SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3SEDT.Value.ToM3String());
			if (m3NOPK.HasValue)
				request.WithQueryParameter("NOPK", m3NOPK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (m3RJQA.HasValue)
				request.WithQueryParameter("RJQA", m3RJQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RWHS))
				request.WithQueryParameter("RWHS", m3RWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RBAN))
				request.WithQueryParameter("RBAN", m3RBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RREM))
				request.WithQueryParameter("RREM", m3RREM.Trim());
			if (m3WPRF.HasValue)
				request.WithQueryParameter("WPRF", m3WPRF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SVDT.HasValue)
				request.WithQueryParameter("SVDT", m3SVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name QualityInspPack
		/// Description Quality inspection package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3QCRA">Quality inspection result (Required)</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3AWHS">Approved Location</param>
		/// <param name="m3RWHS">Rejected Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> QualityInspPack(
			string m3RESP, 
			string m3QCRA, 
			string m3PACN = null, 
			string m3WHLO = null, 
			string m3SUNO = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			string m3SCRE = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			string m3AWHS = null, 
			string m3RWHS = null, 
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
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));
			if (string.IsNullOrWhiteSpace(m3QCRA))
				throw new ArgumentNullException(nameof(m3QCRA));

			// Set mandatory parameters
			request
				.WithQueryParameter("RESP", m3RESP.Trim())
				.WithQueryParameter("QCRA", m3QCRA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AWHS))
				request.WithQueryParameter("AWHS", m3AWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RWHS))
				request.WithQueryParameter("RWHS", m3RWHS.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name QualityInspSSCC
		/// Description Quality inspection SSCC
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SSCC">SSCC number (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3QCRA">Quality inspection result (Required)</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3AWHS">Approved Location</param>
		/// <param name="m3RWHS">Rejected Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> QualityInspSSCC(
			string m3SSCC, 
			string m3RESP, 
			string m3QCRA, 
			string m3SCRE = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			string m3AWHS = null, 
			string m3RWHS = null, 
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
			if (string.IsNullOrWhiteSpace(m3SSCC))
				throw new ArgumentNullException(nameof(m3SSCC));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));
			if (string.IsNullOrWhiteSpace(m3QCRA))
				throw new ArgumentNullException(nameof(m3QCRA));

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3SSCC.Trim())
				.WithQueryParameter("RESP", m3RESP.Trim())
				.WithQueryParameter("QCRA", m3QCRA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AWHS))
				request.WithQueryParameter("AWHS", m3AWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RWHS))
				request.WithQueryParameter("RWHS", m3RWHS.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
