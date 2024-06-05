/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.POS350MI;
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
	/// Name: POS350MI
	/// Component Name: ProjectInvoice
	/// Description: Project invoice interface
	/// Version Release: 5ea0
	///</summary>
	public partial class POS350MIResource : M3BaseResourceEndpoint
	{
		public POS350MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "POS350MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetCashDiscount
		/// Description GetCashDiscount
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_IVNO">Invoice number</param>
		/// <param name="m3_INPX">Invoice prefix</param>
		/// <param name="m3_EXIN">Extended invoice number</param>
		/// <param name="m3_TECD">Cash discount term</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCashDiscountResponse></returns>
		/// <exception cref="M3Exception<GetCashDiscountResponse>"></exception>
		public async Task<M3Response<GetCashDiscountResponse>> GetCashDiscount(
			string m3_DIVI = null, 
			int? m3_YEA4 = null, 
			int? m3_IVNO = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
			string m3_TECD = null, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCashDiscount",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (m3_IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3_IVNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECD))
				request.WithQueryParameter("TECD", m3_TECD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetCashDiscountResponse>(
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
		/// Name GetDelLine
		/// Description GetDelLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_ELNO">Project element (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelLineResponse></returns>
		/// <exception cref="M3Exception<GetDelLineResponse>"></exception>
		public async Task<M3Response<GetDelLineResponse>> GetDelLine(
			string m3_PROJ, 
			string m3_ELNO, 
			int m3_PONR, 
			int m3_POSX, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDelLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");
			if (string.IsNullOrWhiteSpace(m3_ELNO))
				throw new ArgumentNullException("m3_ELNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("ELNO", m3_ELNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetDelLineResponse>(
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
		/// Name GetInvHead
		/// Description Retrieve Invoice Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_INPX">Invoice Prefix</param>
		/// <param name="m3_EXIN">Extended Invoice Number</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvHeadResponse></returns>
		/// <exception cref="M3Exception<GetInvHeadResponse>"></exception>
		public async Task<M3Response<GetInvHeadResponse>> GetInvHead(
			int m3_IVNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_YEA4 = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvHead",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("IVNO", m3_IVNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());

			// Execute the request
			var result = await Execute<GetInvHeadResponse>(
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
		/// Name GetInvLine
		/// Description GetInvLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_IVTP">Information type (Required)</param>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_IVRF">Invoice reference (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_INPX">Invoice prefix</param>
		/// <param name="m3_EXIN">Extended invoice number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvLineResponse></returns>
		/// <exception cref="M3Exception<GetInvLineResponse>"></exception>
		public async Task<M3Response<GetInvLineResponse>> GetInvLine(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_IVNO, 
			string m3_IVTP, 
			string m3_ORNO, 
			decimal m3_DLIX, 
			string m3_IVRF, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_IVTP))
				throw new ArgumentNullException("m3_IVTP");
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_IVRF))
				throw new ArgumentNullException("m3_IVRF");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("IVNO", m3_IVNO.ToString())
				.WithQueryParameter("IVTP", m3_IVTP.Trim())
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("IVRF", m3_IVRF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());

			// Execute the request
			var result = await Execute<GetInvLineResponse>(
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
		/// Name GetInvoiceHd
		/// Description GetInvoiceHd
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_INPX">Invoice prefix</param>
		/// <param name="m3_EXIN">Extended invoice number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvoiceHdResponse></returns>
		/// <exception cref="M3Exception<GetInvoiceHdResponse>"></exception>
		public async Task<M3Response<GetInvoiceHdResponse>> GetInvoiceHd(
			int m3_YEA4, 
			int m3_IVNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvoiceHd",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("IVNO", m3_IVNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());

			// Execute the request
			var result = await Execute<GetInvoiceHdResponse>(
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
		/// Name LstDelHeadByInv
		/// Description LstDelHeadByInv
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_IVNO">Invoice number</param>
		/// <param name="m3_INPX">Invoice prefix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelHeadByInvResponse></returns>
		/// <exception cref="M3Exception<LstDelHeadByInvResponse>"></exception>
		public async Task<M3Response<LstDelHeadByInvResponse>> LstDelHeadByInv(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_YEA4 = null, 
			int? m3_IVNO = null, 
			string m3_INPX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDelHeadByInv",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (m3_IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3_IVNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());

			// Execute the request
			var result = await Execute<LstDelHeadByInvResponse>(
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
		/// Name LstInvHead
		/// Description LstInvHead
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_IVNO">Invoice number</param>
		/// <param name="m3_INPX">Invoice prefix</param>
		/// <param name="m3_EXIN">Extended invoice number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvHeadResponse></returns>
		/// <exception cref="M3Exception<LstInvHeadResponse>"></exception>
		public async Task<M3Response<LstInvHeadResponse>> LstInvHead(
			int m3_YEA4, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_IVNO = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvHead",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3_IVNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());

			// Execute the request
			var result = await Execute<LstInvHeadResponse>(
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
		/// Name LstInvLine
		/// Description LstInvLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_INPX">Invoice prefix</param>
		/// <param name="m3_EXIN">Extended invoice number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvLineResponse></returns>
		/// <exception cref="M3Exception<LstInvLineResponse>"></exception>
		public async Task<M3Response<LstInvLineResponse>> LstInvLine(
			int m3_YEA4, 
			int m3_IVNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvLine",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("IVNO", m3_IVNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());

			// Execute the request
			var result = await Execute<LstInvLineResponse>(
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
		/// Name LstInvLineByTyp
		/// Description LstInvLineByTyp
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_IVTP">Information type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_INPX">Invoice prefix</param>
		/// <param name="m3_EXIN">Extended invoice number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvLineByTypResponse></returns>
		/// <exception cref="M3Exception<LstInvLineByTypResponse>"></exception>
		public async Task<M3Response<LstInvLineByTypResponse>> LstInvLineByTyp(
			int m3_YEA4, 
			int m3_IVNO, 
			string m3_IVTP, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvLineByTyp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IVTP))
				throw new ArgumentNullException("m3_IVTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("IVNO", m3_IVNO.ToString())
				.WithQueryParameter("IVTP", m3_IVTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());

			// Execute the request
			var result = await Execute<LstInvLineByTypResponse>(
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
		/// Name LstLine
		/// Description List Project Invoice Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3_DIVI, 
			string m3_PROJ, 
			int? m3_CONO = null, 
			string m3_ELNO = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
