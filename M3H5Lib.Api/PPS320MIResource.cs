/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS320MI;
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
	/// Name: PPS320MI
	/// Component Name: Put Away PO
	/// Description: Api: Put-Away PO
	/// Version Release: 5ea1
	///</summary>
	public partial class PPS320MIResource : M3BaseResourceEndpoint
	{
		public PPS320MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS320MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ClosePADelNote
		/// Description Close put-away delivery note
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
		public async Task<M3Response<M3Record>> ClosePADelNote(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClosePADelNote",
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
		/// Name GetPADataPO
		/// Description Get put-away data for purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_REPN">Receiving number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPADataPOResponse></returns>
		/// <exception cref="M3Exception<GetPADataPOResponse>"></exception>
		public async Task<M3Response<GetPADataPOResponse>> GetPADataPO(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPADataPO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("REPN", m3_REPN.ToString());

			// Execute the request
			var result = await Execute<GetPADataPOResponse>(
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
		/// Name LstBalIDPA
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
		/// <returns>M3Response<LstBalIDPAResponse></returns>
		/// <exception cref="M3Exception<LstBalIDPAResponse>"></exception>
		public async Task<M3Response<LstBalIDPAResponse>> LstBalIDPA(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBalIDPA",
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
			var result = await Execute<LstBalIDPAResponse>(
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
		/// Name LstPADataPO
		/// Description List put-away data PO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_REPN">Receiving number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPADataPOResponse></returns>
		/// <exception cref="M3Exception<LstPADataPOResponse>"></exception>
		public async Task<M3Response<LstPADataPOResponse>> LstPADataPO(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPADataPO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("REPN", m3_REPN.ToString());

			// Execute the request
			var result = await Execute<LstPADataPOResponse>(
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
		/// Name LstPADataPack
		/// Description List put-away data for package
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
		/// <returns>M3Response<LstPADataPackResponse></returns>
		/// <exception cref="M3Exception<LstPADataPackResponse>"></exception>
		public async Task<M3Response<LstPADataPackResponse>> LstPADataPack(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPADataPack",
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
			var result = await Execute<LstPADataPackResponse>(
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
		/// Name LstPADataSSCC
		/// Description List put-away data for SSCC number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SSCC">SSCC number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPADataSSCCResponse></returns>
		/// <exception cref="M3Exception<LstPADataSSCCResponse>"></exception>
		public async Task<M3Response<LstPADataSSCCResponse>> LstPADataSSCC(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPADataSSCC",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SSCC))
				throw new ArgumentNullException("m3_SSCC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<LstPADataSSCCResponse>(
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
		/// Name PutawayPO
		/// Description Put-away Purchase Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_REPN">Receiving number (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_RPQA">Reported quantity in alternative unit (Required)</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_NOPK">Number of packages</param>
		/// <param name="m3_DSP1">Warning indicator 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PutawayPO(
			long m3_REPN, 
			string m3_RESP, 
			decimal m3_RPQA, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			string m3_WHSL = null, 
			int? m3_OEND = null, 
			string m3_BANO = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_CAMU = null, 
			decimal? m3_CAWE = null, 
			DateTime? m3_PRDT = null, 
			string m3_BREM = null, 
			int? m3_NOPK = null, 
			int? m3_DSP1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PutawayPO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPN", m3_REPN.ToString())
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("RPQA", m3_RPQA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (m3_NOPK.HasValue)
				request.WithQueryParameter("NOPK", m3_NOPK.Value.ToString());
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());

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
		/// Name PutawayPack
		/// Description Put-away package level
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PutawayPack(
			string m3_RESP, 
			string m3_PACN = null, 
			string m3_WHLO = null, 
			string m3_SUNO = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			string m3_WHSL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PutawayPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");

			// Set mandatory parameters
			request
				.WithQueryParameter("RESP", m3_RESP.Trim());

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
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());

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
		/// Name PutawayPackBld
		/// Description Put-away package level and include in
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_PACC">Included in package number (Required)</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PutawayPackBld(
			string m3_PACN, 
			string m3_RESP, 
			string m3_PACC, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			string m3_WHSL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PutawayPackBld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");
			if (string.IsNullOrWhiteSpace(m3_PACC))
				throw new ArgumentNullException("m3_PACC");

			// Set mandatory parameters
			request
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("PACC", m3_PACC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());

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
		/// Name PutawaySSCC
		/// Description Put-away on SSCC number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SSCC">SSCC number (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PutawaySSCC(
			string m3_SSCC, 
			string m3_RESP, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			string m3_WHSL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PutawaySSCC",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SSCC))
				throw new ArgumentNullException("m3_SSCC");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3_SSCC.Trim())
				.WithQueryParameter("RESP", m3_RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());

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
