/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS390MI;
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
	/// Name: PPS390MI
	/// Component Name: Purchasing
	/// Description: Receiving Claim Information interface
	/// Version Release: 5ea0
	///</summary>
	public partial class PPS390MIResource : M3BaseResourceEndpoint
	{
		public PPS390MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS390MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddClaimHead
		/// Description Add Claim Head
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_RTOT">Return to supplier order type (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_CLAN">Claim number</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_CLAL">Lowest claim status</param>
		/// <param name="m3_CLRE">Claim officer</param>
		/// <param name="m3_CLAD">Claim date</param>
		/// <param name="m3_CLRF">Claim reference</param>
		/// <param name="m3_YRE1">Your reference</param>
		/// <param name="m3_REPT">Replacement delivery</param>
		/// <param name="m3_CRTI">Credit to issue</param>
		/// <param name="m3_COMD">Supplementary delivery</param>
		/// <param name="m3_CORE">Cost to repair</param>
		/// <param name="m3_UPAV">Update material plan</param>
		/// <param name="m3_RPTD">Replacement delivery date</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_SORN">Supplier order number</param>
		/// <param name="m3_RCLD">Receipt date</param>
		/// <param name="m3_TTID">Transaction identity</param>
		/// <param name="m3_CMCO">Media profile</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddClaimHeadResponse></returns>
		/// <exception cref="M3Exception<AddClaimHeadResponse>"></exception>
		public async Task<M3Response<AddClaimHeadResponse>> AddClaimHead(
			string m3_FACI, 
			string m3_WHLO, 
			string m3_RTOT, 
			string m3_SUNO, 
			string m3_CLAN = null, 
			string m3_PUNO = null, 
			string m3_CLAL = null, 
			string m3_CLRE = null, 
			DateTime? m3_CLAD = null, 
			string m3_CLRF = null, 
			string m3_YRE1 = null, 
			int? m3_REPT = null, 
			int? m3_CRTI = null, 
			int? m3_COMD = null, 
			int? m3_CORE = null, 
			int? m3_UPAV = null, 
			DateTime? m3_RPTD = null, 
			string m3_SUDO = null, 
			string m3_SORN = null, 
			DateTime? m3_RCLD = null, 
			string m3_TTID = null, 
			string m3_CMCO = null, 
			string m3_TFNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddClaimHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_RTOT))
				throw new ArgumentNullException("m3_RTOT");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("RTOT", m3_RTOT.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLAN))
				request.WithQueryParameter("CLAN", m3_CLAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLAL))
				request.WithQueryParameter("CLAL", m3_CLAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLRE))
				request.WithQueryParameter("CLRE", m3_CLRE.Trim());
			if (m3_CLAD.HasValue)
				request.WithQueryParameter("CLAD", m3_CLAD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CLRF))
				request.WithQueryParameter("CLRF", m3_CLRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE1))
				request.WithQueryParameter("YRE1", m3_YRE1.Trim());
			if (m3_REPT.HasValue)
				request.WithQueryParameter("REPT", m3_REPT.Value.ToString());
			if (m3_CRTI.HasValue)
				request.WithQueryParameter("CRTI", m3_CRTI.Value.ToString());
			if (m3_COMD.HasValue)
				request.WithQueryParameter("COMD", m3_COMD.Value.ToString());
			if (m3_CORE.HasValue)
				request.WithQueryParameter("CORE", m3_CORE.Value.ToString());
			if (m3_UPAV.HasValue)
				request.WithQueryParameter("UPAV", m3_UPAV.Value.ToString());
			if (m3_RPTD.HasValue)
				request.WithQueryParameter("RPTD", m3_RPTD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());
			if (m3_RCLD.HasValue)
				request.WithQueryParameter("RCLD", m3_RCLD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TTID))
				request.WithQueryParameter("TTID", m3_TTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMCO))
				request.WithQueryParameter("CMCO", m3_CMCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());

			// Execute the request
			var result = await Execute<AddClaimHeadResponse>(
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
		/// Name AddClaimLine
		/// Description Add Claim Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLAN">Claim number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CLIS">Lowest status (Required)</param>
		/// <param name="m3_RJQA">Rejected quantity (Required)</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_PITD">Purchase order item name</param>
		/// <param name="m3_PITT">Purchase order item description</param>
		/// <param name="m3_RVQA">Received quantity</param>
		/// <param name="m3_CAQA">Approved quantity - alternate U/M</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_ICAM">QI cost amount</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_MOVC">Separation</param>
		/// <param name="m3_ISAM">QI cost amount</param>
		/// <param name="m3_PCQA">Partly credit quantity</param>
		/// <param name="m3_RSQA">Rejected quantity</param>
		/// <param name="m3_SSRE">Rejection reason</param>
		/// <param name="m3_CRNN">Credit note number</param>
		/// <param name="m3_CRND">Credit note date</param>
		/// <param name="m3_CRSS">Credit status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_RE20">Reference</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddClaimLine(
			string m3_CLAN, 
			string m3_ITNO, 
			string m3_CLIS, 
			decimal m3_RJQA, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
			string m3_SITE = null, 
			string m3_PITD = null, 
			string m3_PITT = null, 
			decimal? m3_RVQA = null, 
			decimal? m3_CAQA = null, 
			string m3_SCRE = null, 
			decimal? m3_ICAM = null, 
			string m3_BANO = null, 
			int? m3_MOVC = null, 
			decimal? m3_ISAM = null, 
			decimal? m3_PCQA = null, 
			decimal? m3_RSQA = null, 
			string m3_SSRE = null, 
			int? m3_CRNN = null, 
			DateTime? m3_CRND = null, 
			string m3_CRSS = null, 
			decimal? m3_TXID = null, 
			string m3_RE20 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddClaimLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLAN))
				throw new ArgumentNullException("m3_CLAN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CLIS))
				throw new ArgumentNullException("m3_CLIS");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3_CLAN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CLIS", m3_CLIS.Trim())
				.WithQueryParameter("RJQA", m3_RJQA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITD))
				request.WithQueryParameter("PITD", m3_PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITT))
				request.WithQueryParameter("PITT", m3_PITT.Trim());
			if (m3_RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3_RVQA.Value.ToString());
			if (m3_CAQA.HasValue)
				request.WithQueryParameter("CAQA", m3_CAQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (m3_ICAM.HasValue)
				request.WithQueryParameter("ICAM", m3_ICAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_MOVC.HasValue)
				request.WithQueryParameter("MOVC", m3_MOVC.Value.ToString());
			if (m3_ISAM.HasValue)
				request.WithQueryParameter("ISAM", m3_ISAM.Value.ToString());
			if (m3_PCQA.HasValue)
				request.WithQueryParameter("PCQA", m3_PCQA.Value.ToString());
			if (m3_RSQA.HasValue)
				request.WithQueryParameter("RSQA", m3_RSQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSRE))
				request.WithQueryParameter("SSRE", m3_SSRE.Trim());
			if (m3_CRNN.HasValue)
				request.WithQueryParameter("CRNN", m3_CRNN.Value.ToString());
			if (m3_CRND.HasValue)
				request.WithQueryParameter("CRND", m3_CRND.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CRSS))
				request.WithQueryParameter("CRSS", m3_CRSS.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RE20))
				request.WithQueryParameter("RE20", m3_RE20.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());

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
		/// Name ChgClaimHead
		/// Description Change Claim Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgClaimHead(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgClaimHead",
			};

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
		/// Name ChgClaimLine
		/// Description Change Claim Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgClaimLine(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgClaimLine",
			};

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
		/// Name CreateRO
		/// Description Create RO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLAN">Claim number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CreateRO(
			string m3_CLAN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CreateRO",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLAN))
				request.WithQueryParameter("CLAN", m3_CLAN.Trim());

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
		/// Name DltClaimLine
		/// Description Delete Claim Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLAN">Claim number (Required)</param>
		/// <param name="m3_CLLN">Claim order line (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltClaimLine(
			string m3_CLAN, 
			int m3_CLLN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltClaimLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLAN))
				throw new ArgumentNullException("m3_CLAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3_CLAN.Trim())
				.WithQueryParameter("CLLN", m3_CLLN.ToString());

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
		/// Name GetClaimHead
		/// Description Get Claim Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLAN">Claimnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimHeadResponse></returns>
		/// <exception cref="M3Exception<GetClaimHeadResponse>"></exception>
		public async Task<M3Response<GetClaimHeadResponse>> GetClaimHead(
			string m3_CLAN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetClaimHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLAN))
				throw new ArgumentNullException("m3_CLAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3_CLAN.Trim());

			// Execute the request
			var result = await Execute<GetClaimHeadResponse>(
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
		/// Name GetClaimLine
		/// Description Get Claim Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLAN">Claimnumber (Required)</param>
		/// <param name="m3_CLLN">Claimorderline (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimLineResponse></returns>
		/// <exception cref="M3Exception<GetClaimLineResponse>"></exception>
		public async Task<M3Response<GetClaimLineResponse>> GetClaimLine(
			string m3_CLAN, 
			int m3_CLLN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetClaimLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLAN))
				throw new ArgumentNullException("m3_CLAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3_CLAN.Trim())
				.WithQueryParameter("CLLN", m3_CLLN.ToString());

			// Execute the request
			var result = await Execute<GetClaimLineResponse>(
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
		/// Name LstClaimByPuno
		/// Description List Claim by purchase order number
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimByPunoResponse></returns>
		/// <exception cref="M3Exception<LstClaimByPunoResponse>"></exception>
		public async Task<M3Response<LstClaimByPunoResponse>> LstClaimByPuno(
			string m3_FACI, 
			string m3_WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstClaimByPuno",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Execute the request
			var result = await Execute<LstClaimByPunoResponse>(
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
		/// Name LstClaimBySuno
		/// Description List Claim by supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_RTOC">Return to supplier order category</param>
		/// <param name="m3_CLAL">Lowest claim status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimBySunoResponse></returns>
		/// <exception cref="M3Exception<LstClaimBySunoResponse>"></exception>
		public async Task<M3Response<LstClaimBySunoResponse>> LstClaimBySuno(
			string m3_SUNO, 
			string m3_RTOC = null, 
			string m3_CLAL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstClaimBySuno",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RTOC))
				request.WithQueryParameter("RTOC", m3_RTOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLAL))
				request.WithQueryParameter("CLAL", m3_CLAL.Trim());

			// Execute the request
			var result = await Execute<LstClaimBySunoResponse>(
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
		/// Name LstClaimHead
		/// Description List Claim Heads
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CLRE">Claimofficer</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_CLAN">Claimnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimHeadResponse></returns>
		/// <exception cref="M3Exception<LstClaimHeadResponse>"></exception>
		public async Task<M3Response<LstClaimHeadResponse>> LstClaimHead(
			string m3_FACI = null, 
			string m3_CLRE = null, 
			string m3_WHLO = null, 
			string m3_CLAN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstClaimHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLRE))
				request.WithQueryParameter("CLRE", m3_CLRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLAN))
				request.WithQueryParameter("CLAN", m3_CLAN.Trim());

			// Execute the request
			var result = await Execute<LstClaimHeadResponse>(
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
		/// Name LstClaimLine
		/// Description List Claim Lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLAN">Claimnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimLineResponse></returns>
		/// <exception cref="M3Exception<LstClaimLineResponse>"></exception>
		public async Task<M3Response<LstClaimLineResponse>> LstClaimLine(
			string m3_CLAN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstClaimLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLAN))
				throw new ArgumentNullException("m3_CLAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3_CLAN.Trim());

			// Execute the request
			var result = await Execute<LstClaimLineResponse>(
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
		/// Name UpdClaimHead
		/// Description Updates Claim Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLAN">Claimnumber (Required)</param>
		/// <param name="m3_CLAL">Lowestclaimstatus</param>
		/// <param name="m3_CLRE">Claimofficer</param>
		/// <param name="m3_CLAD">Claimdate</param>
		/// <param name="m3_CLRF">Claimreference</param>
		/// <param name="m3_YRE1">Yourreference</param>
		/// <param name="m3_REPT">Replacementdelivery</param>
		/// <param name="m3_CRTI">Credittoissue</param>
		/// <param name="m3_COMD">Supplementarydelivery</param>
		/// <param name="m3_CORE">Costtorepair</param>
		/// <param name="m3_UPAV">Updatematerialplan</param>
		/// <param name="m3_RPTD">Replacementdeliverydate</param>
		/// <param name="m3_SUDO">Deliverynotenumber</param>
		/// <param name="m3_SORN">Supplierordernumber</param>
		/// <param name="m3_RCLD">Receiptdate</param>
		/// <param name="m3_TTID">Transactionidentity</param>
		/// <param name="m3_CMCO">Communicationcode</param>
		/// <param name="m3_TFNO">Facsimiletransmissionnumber</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimHead(
			string m3_CLAN, 
			string m3_CLAL = null, 
			string m3_CLRE = null, 
			DateTime? m3_CLAD = null, 
			string m3_CLRF = null, 
			string m3_YRE1 = null, 
			int? m3_REPT = null, 
			int? m3_CRTI = null, 
			int? m3_COMD = null, 
			int? m3_CORE = null, 
			int? m3_UPAV = null, 
			DateTime? m3_RPTD = null, 
			string m3_SUDO = null, 
			string m3_SORN = null, 
			DateTime? m3_RCLD = null, 
			string m3_TTID = null, 
			string m3_CMCO = null, 
			string m3_TFNO = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLAN))
				throw new ArgumentNullException("m3_CLAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3_CLAN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CLAL))
				request.WithQueryParameter("CLAL", m3_CLAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLRE))
				request.WithQueryParameter("CLRE", m3_CLRE.Trim());
			if (m3_CLAD.HasValue)
				request.WithQueryParameter("CLAD", m3_CLAD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CLRF))
				request.WithQueryParameter("CLRF", m3_CLRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE1))
				request.WithQueryParameter("YRE1", m3_YRE1.Trim());
			if (m3_REPT.HasValue)
				request.WithQueryParameter("REPT", m3_REPT.Value.ToString());
			if (m3_CRTI.HasValue)
				request.WithQueryParameter("CRTI", m3_CRTI.Value.ToString());
			if (m3_COMD.HasValue)
				request.WithQueryParameter("COMD", m3_COMD.Value.ToString());
			if (m3_CORE.HasValue)
				request.WithQueryParameter("CORE", m3_CORE.Value.ToString());
			if (m3_UPAV.HasValue)
				request.WithQueryParameter("UPAV", m3_UPAV.Value.ToString());
			if (m3_RPTD.HasValue)
				request.WithQueryParameter("RPTD", m3_RPTD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());
			if (m3_RCLD.HasValue)
				request.WithQueryParameter("RCLD", m3_RCLD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TTID))
				request.WithQueryParameter("TTID", m3_TTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMCO))
				request.WithQueryParameter("CMCO", m3_CMCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name UpdClaimLine
		/// Description Updates Claim Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLAN">Claimnumber (Required)</param>
		/// <param name="m3_CLLN">Claimorderline (Required)</param>
		/// <param name="m3_PNLI">Purchaseorderline (Required)</param>
		/// <param name="m3_RJQA">Rejectedquantity (Required)</param>
		/// <param name="m3_PNLS">Purchaseorderlinesubnumber</param>
		/// <param name="m3_CLIS">Claimstatus</param>
		/// <param name="m3_SITE">Supplieritemnumber</param>
		/// <param name="m3_PITD">Purchaseorderitemname</param>
		/// <param name="m3_PITT">Purchaseorderitemdescription</param>
		/// <param name="m3_RVQA">Receivedquantity</param>
		/// <param name="m3_CAQA">Approvedquantity-alternateU/M</param>
		/// <param name="m3_SCRE">Rejectionreason</param>
		/// <param name="m3_ICAM">Qualityinspectedcostamount</param>
		/// <param name="m3_BANO">Lotnumber</param>
		/// <param name="m3_MOVC">Separation</param>
		/// <param name="m3_ISAM">Quality inspected cost amount</param>
		/// <param name="m3_PCQA">Partly credit quantity</param>
		/// <param name="m3_RSQA">Rejected quantity</param>
		/// <param name="m3_SSRE">Rejection reason</param>
		/// <param name="m3_CRNN">Credit note number</param>
		/// <param name="m3_CRND">Credit note date</param>
		/// <param name="m3_CRSS">Credit status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_RE20">Reference</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_WCLS">Warranty claim - status</param>
		/// <param name="m3_WAD1">Warranty defined field</param>
		/// <param name="m3_WAD2">Warranty defined field</param>
		/// <param name="m3_WAD3">Warranty defined field</param>
		/// <param name="m3_WAD4">Warranty defined field</param>
		/// <param name="m3_WAD5">Warranty defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimLine(
			string m3_CLAN, 
			int m3_CLLN, 
			int m3_PNLI, 
			decimal m3_RJQA, 
			int? m3_PNLS = null, 
			string m3_CLIS = null, 
			string m3_SITE = null, 
			string m3_PITD = null, 
			string m3_PITT = null, 
			decimal? m3_RVQA = null, 
			decimal? m3_CAQA = null, 
			string m3_SCRE = null, 
			decimal? m3_ICAM = null, 
			string m3_BANO = null, 
			int? m3_MOVC = null, 
			decimal? m3_ISAM = null, 
			decimal? m3_PCQA = null, 
			decimal? m3_RSQA = null, 
			string m3_SSRE = null, 
			int? m3_CRNN = null, 
			DateTime? m3_CRND = null, 
			string m3_CRSS = null, 
			decimal? m3_TXID = null, 
			string m3_RE20 = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_WCLS = null, 
			string m3_WAD1 = null, 
			string m3_WAD2 = null, 
			string m3_WAD3 = null, 
			string m3_WAD4 = null, 
			string m3_WAD5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CLAN))
				throw new ArgumentNullException("m3_CLAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3_CLAN.Trim())
				.WithQueryParameter("CLLN", m3_CLLN.ToString())
				.WithQueryParameter("PNLI", m3_PNLI.ToString())
				.WithQueryParameter("RJQA", m3_RJQA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CLIS))
				request.WithQueryParameter("CLIS", m3_CLIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITD))
				request.WithQueryParameter("PITD", m3_PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITT))
				request.WithQueryParameter("PITT", m3_PITT.Trim());
			if (m3_RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3_RVQA.Value.ToString());
			if (m3_CAQA.HasValue)
				request.WithQueryParameter("CAQA", m3_CAQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (m3_ICAM.HasValue)
				request.WithQueryParameter("ICAM", m3_ICAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_MOVC.HasValue)
				request.WithQueryParameter("MOVC", m3_MOVC.Value.ToString());
			if (m3_ISAM.HasValue)
				request.WithQueryParameter("ISAM", m3_ISAM.Value.ToString());
			if (m3_PCQA.HasValue)
				request.WithQueryParameter("PCQA", m3_PCQA.Value.ToString());
			if (m3_RSQA.HasValue)
				request.WithQueryParameter("RSQA", m3_RSQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSRE))
				request.WithQueryParameter("SSRE", m3_SSRE.Trim());
			if (m3_CRNN.HasValue)
				request.WithQueryParameter("CRNN", m3_CRNN.Value.ToString());
			if (m3_CRND.HasValue)
				request.WithQueryParameter("CRND", m3_CRND.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CRSS))
				request.WithQueryParameter("CRSS", m3_CRSS.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RE20))
				request.WithQueryParameter("RE20", m3_RE20.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WCLS))
				request.WithQueryParameter("WCLS", m3_WCLS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WAD1))
				request.WithQueryParameter("WAD1", m3_WAD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WAD2))
				request.WithQueryParameter("WAD2", m3_WAD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WAD3))
				request.WithQueryParameter("WAD3", m3_WAD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WAD4))
				request.WithQueryParameter("WAD4", m3_WAD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WAD5))
				request.WithQueryParameter("WAD5", m3_WAD5.Trim());

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
