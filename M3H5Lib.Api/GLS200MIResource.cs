/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.GLS200MI;
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
	/// Name: GLS200MI
	/// Component Name: GeneralLedger
	/// Description: Api : General Ledger Information
	/// Version Release: 5ea1
	///</summary>
	public partial class GLS200MIResource : M3BaseResourceEndpoint
	{
		public GLS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "GLS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetVoucherHead
		/// Description Retrieves header information for one voucher
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_VONO">Voucher number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_VSER">Voucher number series</param>
		/// <param name="m3_JRNO">Journal number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetVoucherHeadResponse></returns>
		/// <exception cref="M3Exception<GetVoucherHeadResponse>"></exception>
		public async Task<M3Response<GetVoucherHeadResponse>> GetVoucherHead(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_VONO, 
			int? m3_CONO = null, 
			string m3_VSER = null, 
			int? m3_JRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetVoucherHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("VONO", m3_VONO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VSER))
				request.WithQueryParameter("VSER", m3_VSER.Trim());
			if (m3_JRNO.HasValue)
				request.WithQueryParameter("JRNO", m3_JRNO.Value.ToString());

			// Execute the request
			var result = await Execute<GetVoucherHeadResponse>(
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
		/// Name GetVoucherLine
		/// Description Retrieve a voucher line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_VONO">Voucher number (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_VSER">Voucher number series</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetVoucherLineResponse></returns>
		/// <exception cref="M3Exception<GetVoucherLineResponse>"></exception>
		public async Task<M3Response<GetVoucherLineResponse>> GetVoucherLine(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_VONO, 
			int m3_JRNO, 
			int m3_JSNO, 
			int? m3_CONO = null, 
			string m3_VSER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetVoucherLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("VONO", m3_VONO.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VSER))
				request.WithQueryParameter("VSER", m3_VSER.Trim());

			// Execute the request
			var result = await Execute<GetVoucherLineResponse>(
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
		/// Name LstVoucherLines
		/// Description List Transaction for a given Voucher
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_VONO">Voucher number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_VSER">Voucher number series</param>
		/// <param name="m3_JRNO">Journal number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVoucherLinesResponse></returns>
		/// <exception cref="M3Exception<LstVoucherLinesResponse>"></exception>
		public async Task<M3Response<LstVoucherLinesResponse>> LstVoucherLines(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_VONO, 
			int? m3_CONO = null, 
			string m3_VSER = null, 
			int? m3_JRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstVoucherLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("VONO", m3_VONO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VSER))
				request.WithQueryParameter("VSER", m3_VSER.Trim());
			if (m3_JRNO.HasValue)
				request.WithQueryParameter("JRNO", m3_JRNO.Value.ToString());

			// Execute the request
			var result = await Execute<LstVoucherLinesResponse>(
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
		/// Name LstVouchersByDt
		/// Description List Transactions for a Vouchers within given dates
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_TODT">To date (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVouchersByDtResponse></returns>
		/// <exception cref="M3Exception<LstVouchersByDtResponse>"></exception>
		public async Task<M3Response<LstVouchersByDtResponse>> LstVouchersByDt(
			DateTime m3_FRDT, 
			DateTime m3_TODT, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstVouchersByDt",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("TODT", m3_TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstVouchersByDtResponse>(
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
		/// Name SearchGenLedger
		/// Description SearchGenLedger
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchGenLedgerResponse></returns>
		/// <exception cref="M3Exception<SearchGenLedgerResponse>"></exception>
		public async Task<M3Response<SearchGenLedgerResponse>> SearchGenLedger(
			string m3_SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchGenLedger",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchGenLedgerResponse>(
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
