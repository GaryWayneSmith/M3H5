/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3RTOT">Return to supplier order type (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3CLAN">Claim number</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3CLAL">Lowest claim status</param>
		/// <param name="m3CLRE">Claim officer</param>
		/// <param name="m3CLAD">Claim date</param>
		/// <param name="m3CLRF">Claim reference</param>
		/// <param name="m3YRE1">Your reference</param>
		/// <param name="m3REPT">Replacement delivery</param>
		/// <param name="m3CRTI">Credit to issue</param>
		/// <param name="m3COMD">Supplementary delivery</param>
		/// <param name="m3CORE">Cost to repair</param>
		/// <param name="m3UPAV">Update material plan</param>
		/// <param name="m3RPTD">Replacement delivery date</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3SORN">Supplier order number</param>
		/// <param name="m3RCLD">Receipt date</param>
		/// <param name="m3TTID">Transaction identity</param>
		/// <param name="m3CMCO">Media profile</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddClaimHeadResponse></returns>
		/// <exception cref="M3Exception<AddClaimHeadResponse>"></exception>
		public async Task<M3Response<AddClaimHeadResponse>> AddClaimHead(
			string m3FACI, 
			string m3WHLO, 
			string m3RTOT, 
			string m3SUNO, 
			string m3CLAN = null, 
			string m3PUNO = null, 
			string m3CLAL = null, 
			string m3CLRE = null, 
			DateTime? m3CLAD = null, 
			string m3CLRF = null, 
			string m3YRE1 = null, 
			int? m3REPT = null, 
			int? m3CRTI = null, 
			int? m3COMD = null, 
			int? m3CORE = null, 
			int? m3UPAV = null, 
			DateTime? m3RPTD = null, 
			string m3SUDO = null, 
			string m3SORN = null, 
			DateTime? m3RCLD = null, 
			string m3TTID = null, 
			string m3CMCO = null, 
			string m3TFNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3RTOT))
				throw new ArgumentNullException(nameof(m3RTOT));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("RTOT", m3RTOT.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLAN))
				request.WithQueryParameter("CLAN", m3CLAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLAL))
				request.WithQueryParameter("CLAL", m3CLAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLRE))
				request.WithQueryParameter("CLRE", m3CLRE.Trim());
			if (m3CLAD.HasValue)
				request.WithQueryParameter("CLAD", m3CLAD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CLRF))
				request.WithQueryParameter("CLRF", m3CLRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE1))
				request.WithQueryParameter("YRE1", m3YRE1.Trim());
			if (m3REPT.HasValue)
				request.WithQueryParameter("REPT", m3REPT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTI.HasValue)
				request.WithQueryParameter("CRTI", m3CRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COMD.HasValue)
				request.WithQueryParameter("COMD", m3COMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CORE.HasValue)
				request.WithQueryParameter("CORE", m3CORE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPAV.HasValue)
				request.WithQueryParameter("UPAV", m3UPAV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPTD.HasValue)
				request.WithQueryParameter("RPTD", m3RPTD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());
			if (m3RCLD.HasValue)
				request.WithQueryParameter("RCLD", m3RCLD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TTID))
				request.WithQueryParameter("TTID", m3TTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMCO))
				request.WithQueryParameter("CMCO", m3CMCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());

			// Execute the request
			var result = await Execute<AddClaimHeadResponse>(
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
		/// Name AddClaimLine
		/// Description Add Claim Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLAN">Claim number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CLIS">Lowest status (Required)</param>
		/// <param name="m3RJQA">Rejected quantity (Required)</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="m3SITE">Supplier item number</param>
		/// <param name="m3PITD">Purchase order item name</param>
		/// <param name="m3PITT">Purchase order item description</param>
		/// <param name="m3RVQA">Received quantity</param>
		/// <param name="m3CAQA">Approved quantity - alternate U/M</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3ICAM">QI cost amount</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3MOVC">Separation</param>
		/// <param name="m3ISAM">QI cost amount</param>
		/// <param name="m3PCQA">Partly credit quantity</param>
		/// <param name="m3RSQA">Rejected quantity</param>
		/// <param name="m3SSRE">Rejection reason</param>
		/// <param name="m3CRNN">Credit note number</param>
		/// <param name="m3CRND">Credit note date</param>
		/// <param name="m3CRSS">Credit status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3RE20">Reference</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddClaimLine(
			string m3CLAN, 
			string m3ITNO, 
			string m3CLIS, 
			decimal m3RJQA, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
			string m3SITE = null, 
			string m3PITD = null, 
			string m3PITT = null, 
			decimal? m3RVQA = null, 
			decimal? m3CAQA = null, 
			string m3SCRE = null, 
			decimal? m3ICAM = null, 
			string m3BANO = null, 
			int? m3MOVC = null, 
			decimal? m3ISAM = null, 
			decimal? m3PCQA = null, 
			decimal? m3RSQA = null, 
			string m3SSRE = null, 
			int? m3CRNN = null, 
			DateTime? m3CRND = null, 
			string m3CRSS = null, 
			decimal? m3TXID = null, 
			string m3RE20 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3CLAN))
				throw new ArgumentNullException(nameof(m3CLAN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CLIS))
				throw new ArgumentNullException(nameof(m3CLIS));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3CLAN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CLIS", m3CLIS.Trim())
				.WithQueryParameter("RJQA", m3RJQA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITD))
				request.WithQueryParameter("PITD", m3PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITT))
				request.WithQueryParameter("PITT", m3PITT.Trim());
			if (m3RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3RVQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAQA.HasValue)
				request.WithQueryParameter("CAQA", m3CAQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (m3ICAM.HasValue)
				request.WithQueryParameter("ICAM", m3ICAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3MOVC.HasValue)
				request.WithQueryParameter("MOVC", m3MOVC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ISAM.HasValue)
				request.WithQueryParameter("ISAM", m3ISAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCQA.HasValue)
				request.WithQueryParameter("PCQA", m3PCQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSQA.HasValue)
				request.WithQueryParameter("RSQA", m3RSQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSRE))
				request.WithQueryParameter("SSRE", m3SSRE.Trim());
			if (m3CRNN.HasValue)
				request.WithQueryParameter("CRNN", m3CRNN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRND.HasValue)
				request.WithQueryParameter("CRND", m3CRND.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CRSS))
				request.WithQueryParameter("CRSS", m3CRSS.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RE20))
				request.WithQueryParameter("RE20", m3RE20.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());

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
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

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
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name CreateRO
		/// Description Create RO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLAN">Claim number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CreateRO(
			string m3CLAN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3CLAN))
				request.WithQueryParameter("CLAN", m3CLAN.Trim());

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
		/// Name DltClaimLine
		/// Description Delete Claim Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLAN">Claim number (Required)</param>
		/// <param name="m3CLLN">Claim order line (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltClaimLine(
			string m3CLAN, 
			int m3CLLN, 
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
			if (string.IsNullOrWhiteSpace(m3CLAN))
				throw new ArgumentNullException(nameof(m3CLAN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3CLAN.Trim())
				.WithQueryParameter("CLLN", m3CLLN.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetClaimHead
		/// Description Get Claim Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLAN">Claimnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimHeadResponse></returns>
		/// <exception cref="M3Exception<GetClaimHeadResponse>"></exception>
		public async Task<M3Response<GetClaimHeadResponse>> GetClaimHead(
			string m3CLAN, 
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
			if (string.IsNullOrWhiteSpace(m3CLAN))
				throw new ArgumentNullException(nameof(m3CLAN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3CLAN.Trim());

			// Execute the request
			var result = await Execute<GetClaimHeadResponse>(
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
		/// Name GetClaimLine
		/// Description Get Claim Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLAN">Claimnumber (Required)</param>
		/// <param name="m3CLLN">Claimorderline (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimLineResponse></returns>
		/// <exception cref="M3Exception<GetClaimLineResponse>"></exception>
		public async Task<M3Response<GetClaimLineResponse>> GetClaimLine(
			string m3CLAN, 
			int m3CLLN, 
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
			if (string.IsNullOrWhiteSpace(m3CLAN))
				throw new ArgumentNullException(nameof(m3CLAN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3CLAN.Trim())
				.WithQueryParameter("CLLN", m3CLLN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetClaimLineResponse>(
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
		/// Name LstClaimByPuno
		/// Description List Claim by purchase order number
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimByPunoResponse></returns>
		/// <exception cref="M3Exception<LstClaimByPunoResponse>"></exception>
		public async Task<M3Response<LstClaimByPunoResponse>> LstClaimByPuno(
			string m3FACI, 
			string m3WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstClaimByPuno",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Execute the request
			var result = await Execute<LstClaimByPunoResponse>(
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
		/// Name LstClaimBySuno
		/// Description List Claim by supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3RTOC">Return to supplier order category</param>
		/// <param name="m3CLAL">Lowest claim status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimBySunoResponse></returns>
		/// <exception cref="M3Exception<LstClaimBySunoResponse>"></exception>
		public async Task<M3Response<LstClaimBySunoResponse>> LstClaimBySuno(
			string m3SUNO, 
			string m3RTOC = null, 
			string m3CLAL = null, 
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
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RTOC))
				request.WithQueryParameter("RTOC", m3RTOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLAL))
				request.WithQueryParameter("CLAL", m3CLAL.Trim());

			// Execute the request
			var result = await Execute<LstClaimBySunoResponse>(
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
		/// Name LstClaimHead
		/// Description List Claim Heads
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CLRE">Claimofficer</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3CLAN">Claimnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimHeadResponse></returns>
		/// <exception cref="M3Exception<LstClaimHeadResponse>"></exception>
		public async Task<M3Response<LstClaimHeadResponse>> LstClaimHead(
			string m3FACI = null, 
			string m3CLRE = null, 
			string m3WHLO = null, 
			string m3CLAN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLRE))
				request.WithQueryParameter("CLRE", m3CLRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLAN))
				request.WithQueryParameter("CLAN", m3CLAN.Trim());

			// Execute the request
			var result = await Execute<LstClaimHeadResponse>(
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
		/// Name LstClaimLine
		/// Description List Claim Lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLAN">Claimnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaimLineResponse></returns>
		/// <exception cref="M3Exception<LstClaimLineResponse>"></exception>
		public async Task<M3Response<LstClaimLineResponse>> LstClaimLine(
			string m3CLAN, 
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
			if (string.IsNullOrWhiteSpace(m3CLAN))
				throw new ArgumentNullException(nameof(m3CLAN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3CLAN.Trim());

			// Execute the request
			var result = await Execute<LstClaimLineResponse>(
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
		/// Name UpdClaimHead
		/// Description Updates Claim Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLAN">Claimnumber (Required)</param>
		/// <param name="m3CLAL">Lowestclaimstatus</param>
		/// <param name="m3CLRE">Claimofficer</param>
		/// <param name="m3CLAD">Claimdate</param>
		/// <param name="m3CLRF">Claimreference</param>
		/// <param name="m3YRE1">Yourreference</param>
		/// <param name="m3REPT">Replacementdelivery</param>
		/// <param name="m3CRTI">Credittoissue</param>
		/// <param name="m3COMD">Supplementarydelivery</param>
		/// <param name="m3CORE">Costtorepair</param>
		/// <param name="m3UPAV">Updatematerialplan</param>
		/// <param name="m3RPTD">Replacementdeliverydate</param>
		/// <param name="m3SUDO">Deliverynotenumber</param>
		/// <param name="m3SORN">Supplierordernumber</param>
		/// <param name="m3RCLD">Receiptdate</param>
		/// <param name="m3TTID">Transactionidentity</param>
		/// <param name="m3CMCO">Communicationcode</param>
		/// <param name="m3TFNO">Facsimiletransmissionnumber</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimHead(
			string m3CLAN, 
			string m3CLAL = null, 
			string m3CLRE = null, 
			DateTime? m3CLAD = null, 
			string m3CLRF = null, 
			string m3YRE1 = null, 
			int? m3REPT = null, 
			int? m3CRTI = null, 
			int? m3COMD = null, 
			int? m3CORE = null, 
			int? m3UPAV = null, 
			DateTime? m3RPTD = null, 
			string m3SUDO = null, 
			string m3SORN = null, 
			DateTime? m3RCLD = null, 
			string m3TTID = null, 
			string m3CMCO = null, 
			string m3TFNO = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			decimal? m3TXID = null, 
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
			if (string.IsNullOrWhiteSpace(m3CLAN))
				throw new ArgumentNullException(nameof(m3CLAN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3CLAN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CLAL))
				request.WithQueryParameter("CLAL", m3CLAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLRE))
				request.WithQueryParameter("CLRE", m3CLRE.Trim());
			if (m3CLAD.HasValue)
				request.WithQueryParameter("CLAD", m3CLAD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CLRF))
				request.WithQueryParameter("CLRF", m3CLRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE1))
				request.WithQueryParameter("YRE1", m3YRE1.Trim());
			if (m3REPT.HasValue)
				request.WithQueryParameter("REPT", m3REPT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTI.HasValue)
				request.WithQueryParameter("CRTI", m3CRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COMD.HasValue)
				request.WithQueryParameter("COMD", m3COMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CORE.HasValue)
				request.WithQueryParameter("CORE", m3CORE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPAV.HasValue)
				request.WithQueryParameter("UPAV", m3UPAV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPTD.HasValue)
				request.WithQueryParameter("RPTD", m3RPTD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());
			if (m3RCLD.HasValue)
				request.WithQueryParameter("RCLD", m3RCLD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TTID))
				request.WithQueryParameter("TTID", m3TTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMCO))
				request.WithQueryParameter("CMCO", m3CMCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdClaimLine
		/// Description Updates Claim Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLAN">Claimnumber (Required)</param>
		/// <param name="m3CLLN">Claimorderline (Required)</param>
		/// <param name="m3PNLI">Purchaseorderline (Required)</param>
		/// <param name="m3RJQA">Rejectedquantity (Required)</param>
		/// <param name="m3PNLS">Purchaseorderlinesubnumber</param>
		/// <param name="m3CLIS">Claimstatus</param>
		/// <param name="m3SITE">Supplieritemnumber</param>
		/// <param name="m3PITD">Purchaseorderitemname</param>
		/// <param name="m3PITT">Purchaseorderitemdescription</param>
		/// <param name="m3RVQA">Receivedquantity</param>
		/// <param name="m3CAQA">Approvedquantity-alternateU/M</param>
		/// <param name="m3SCRE">Rejectionreason</param>
		/// <param name="m3ICAM">Qualityinspectedcostamount</param>
		/// <param name="m3BANO">Lotnumber</param>
		/// <param name="m3MOVC">Separation</param>
		/// <param name="m3ISAM">Quality inspected cost amount</param>
		/// <param name="m3PCQA">Partly credit quantity</param>
		/// <param name="m3RSQA">Rejected quantity</param>
		/// <param name="m3SSRE">Rejection reason</param>
		/// <param name="m3CRNN">Credit note number</param>
		/// <param name="m3CRND">Credit note date</param>
		/// <param name="m3CRSS">Credit status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3RE20">Reference</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3WCLS">Warranty claim - status</param>
		/// <param name="m3WAD1">Warranty defined field</param>
		/// <param name="m3WAD2">Warranty defined field</param>
		/// <param name="m3WAD3">Warranty defined field</param>
		/// <param name="m3WAD4">Warranty defined field</param>
		/// <param name="m3WAD5">Warranty defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimLine(
			string m3CLAN, 
			int m3CLLN, 
			int m3PNLI, 
			decimal m3RJQA, 
			int? m3PNLS = null, 
			string m3CLIS = null, 
			string m3SITE = null, 
			string m3PITD = null, 
			string m3PITT = null, 
			decimal? m3RVQA = null, 
			decimal? m3CAQA = null, 
			string m3SCRE = null, 
			decimal? m3ICAM = null, 
			string m3BANO = null, 
			int? m3MOVC = null, 
			decimal? m3ISAM = null, 
			decimal? m3PCQA = null, 
			decimal? m3RSQA = null, 
			string m3SSRE = null, 
			int? m3CRNN = null, 
			DateTime? m3CRND = null, 
			string m3CRSS = null, 
			decimal? m3TXID = null, 
			string m3RE20 = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3WCLS = null, 
			string m3WAD1 = null, 
			string m3WAD2 = null, 
			string m3WAD3 = null, 
			string m3WAD4 = null, 
			string m3WAD5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3CLAN))
				throw new ArgumentNullException(nameof(m3CLAN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLAN", m3CLAN.Trim())
				.WithQueryParameter("CLLN", m3CLLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RJQA", m3RJQA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CLIS))
				request.WithQueryParameter("CLIS", m3CLIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITD))
				request.WithQueryParameter("PITD", m3PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITT))
				request.WithQueryParameter("PITT", m3PITT.Trim());
			if (m3RVQA.HasValue)
				request.WithQueryParameter("RVQA", m3RVQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAQA.HasValue)
				request.WithQueryParameter("CAQA", m3CAQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (m3ICAM.HasValue)
				request.WithQueryParameter("ICAM", m3ICAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3MOVC.HasValue)
				request.WithQueryParameter("MOVC", m3MOVC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ISAM.HasValue)
				request.WithQueryParameter("ISAM", m3ISAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCQA.HasValue)
				request.WithQueryParameter("PCQA", m3PCQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSQA.HasValue)
				request.WithQueryParameter("RSQA", m3RSQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSRE))
				request.WithQueryParameter("SSRE", m3SSRE.Trim());
			if (m3CRNN.HasValue)
				request.WithQueryParameter("CRNN", m3CRNN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRND.HasValue)
				request.WithQueryParameter("CRND", m3CRND.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CRSS))
				request.WithQueryParameter("CRSS", m3CRSS.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RE20))
				request.WithQueryParameter("RE20", m3RE20.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3WCLS))
				request.WithQueryParameter("WCLS", m3WCLS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WAD1))
				request.WithQueryParameter("WAD1", m3WAD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3WAD2))
				request.WithQueryParameter("WAD2", m3WAD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3WAD3))
				request.WithQueryParameter("WAD3", m3WAD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3WAD4))
				request.WithQueryParameter("WAD4", m3WAD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3WAD5))
				request.WithQueryParameter("WAD5", m3WAD5.Trim());

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
