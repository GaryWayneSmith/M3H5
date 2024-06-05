/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
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
	/// Name: PPSEPRMI
	/// Component Name: Movex e-Procurement
	/// Description: Movex e-Procurement
	/// Version Release: 14.x
	///</summary>
	public partial class PPSEPRMIResource : M3BaseResourceEndpoint
	{
		public PPSEPRMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPSEPRMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddEPRReq
		/// Description Add e-Procurement request
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3RQNO">Requisition number (Required)</param>
		/// <param name="m3RQID">Requisition identity (Required)</param>
		/// <param name="m3RQDN">Requisition detail number (Required)</param>
		/// <param name="m3SUNO">Supplier Number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3PPQT">Planned Quantity (Required)</param>
		/// <param name="m3PUUN">Purchase order U/M (Required)</param>
		/// <param name="m3PUPR">Purchase price (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3DLDT">Planned delivery date (Required)</param>
		/// <param name="m3PURC">Requistion By (Required)</param>
		/// <param name="m3PITT">PO item description (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SITE">Supplier Item number</param>
		/// <param name="m3ACRF">Accounting control object</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3ADR1">Address line 1</param>
		/// <param name="m3ADR2">Address line 2</param>
		/// <param name="m3ADR3">Address line 3</param>
		/// <param name="m3ADR4">Address line 4</param>
		/// <param name="m3TEOR">Telephone order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEPRReq(
			string m3WHLO, 
			string m3RQNO, 
			string m3RQID, 
			int m3RQDN, 
			string m3SUNO, 
			string m3ITNO, 
			decimal m3PPQT, 
			string m3PUUN, 
			decimal m3PUPR, 
			string m3CUCD, 
			DateTime m3DLDT, 
			string m3PURC, 
			string m3PITT, 
			int? m3CONO = null, 
			string m3SITE = null, 
			string m3ACRF = null, 
			string m3COCE = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3ORTY = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3ADR1 = null, 
			string m3ADR2 = null, 
			string m3ADR3 = null, 
			string m3ADR4 = null, 
			int? m3TEOR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddEPRReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3RQNO))
				throw new ArgumentNullException(nameof(m3RQNO));
			if (string.IsNullOrWhiteSpace(m3RQID))
				throw new ArgumentNullException(nameof(m3RQID));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3PUUN))
				throw new ArgumentNullException(nameof(m3PUUN));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3PURC))
				throw new ArgumentNullException(nameof(m3PURC));
			if (string.IsNullOrWhiteSpace(m3PITT))
				throw new ArgumentNullException(nameof(m3PITT));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("RQNO", m3RQNO.Trim())
				.WithQueryParameter("RQID", m3RQID.Trim())
				.WithQueryParameter("RQDN", m3RQDN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("PPQT", m3PPQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PUUN", m3PUUN.Trim())
				.WithQueryParameter("PUPR", m3PUPR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("DLDT", m3DLDT.ToM3String())
				.WithQueryParameter("PURC", m3PURC.Trim())
				.WithQueryParameter("PITT", m3PITT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR1))
				request.WithQueryParameter("ADR1", m3ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR2))
				request.WithQueryParameter("ADR2", m3ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR3))
				request.WithQueryParameter("ADR3", m3ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR4))
				request.WithQueryParameter("ADR4", m3ADR4.Trim());
			if (m3TEOR.HasValue)
				request.WithQueryParameter("TEOR", m3TEOR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddEPRText
		/// Description Add text to EPR transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RQNO">Requisition number (Required)</param>
		/// <param name="m3RQID">Requisition identity (Required)</param>
		/// <param name="m3RQDN">Requisition detail number (Required)</param>
		/// <param name="m3LINO">Line number (Required)</param>
		/// <param name="m3TX60">Text (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEPRText(
			string m3RQNO, 
			string m3RQID, 
			int m3RQDN, 
			int m3LINO, 
			string m3TX60, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddEPRText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RQNO))
				throw new ArgumentNullException(nameof(m3RQNO));
			if (string.IsNullOrWhiteSpace(m3RQID))
				throw new ArgumentNullException(nameof(m3RQID));
			if (string.IsNullOrWhiteSpace(m3TX60))
				throw new ArgumentNullException(nameof(m3TX60));

			// Set mandatory parameters
			request
				.WithQueryParameter("RQNO", m3RQNO.Trim())
				.WithQueryParameter("RQID", m3RQID.Trim())
				.WithQueryParameter("RQDN", m3RQDN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LINO", m3LINO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TX60", m3TX60.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgPOAdr
		/// Description Change the adress lines for a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3POAD">PO address type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3ADR1">Address line 1</param>
		/// <param name="m3ADR2">Address line 2</param>
		/// <param name="m3ADR3">Address line 3</param>
		/// <param name="m3ADR4">Address line 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgPOAdr(
			string m3PUNO, 
			string m3POAD, 
			int? m3CONO = null, 
			int? m3PNLI = null, 
			string m3ADR1 = null, 
			string m3ADR2 = null, 
			string m3ADR3 = null, 
			string m3ADR4 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgPOAdr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));
			if (string.IsNullOrWhiteSpace(m3POAD))
				throw new ArgumentNullException(nameof(m3POAD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("POAD", m3POAD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADR1))
				request.WithQueryParameter("ADR1", m3ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR2))
				request.WithQueryParameter("ADR2", m3ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR3))
				request.WithQueryParameter("ADR3", m3ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR4))
				request.WithQueryParameter("ADR4", m3ADR4.Trim());

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
		/// Name ConfirmEPRLine
		/// Description Confirm one e-Procurement order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RQID">Requisition identity (Required)</param>
		/// <param name="m3RQDN">Requisition detail number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SORN">Supplier order number</param>
		/// <param name="m3CODT">Confirmed delivery date</param>
		/// <param name="m3CFQA">Confirmed quantity</param>
		/// <param name="m3CPPR">Confirmed purchase price</param>
		/// <param name="m3CPUC">Confirmed price quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConfirmEPRLine(
			string m3RQID, 
			int m3RQDN, 
			int? m3CONO = null, 
			string m3SORN = null, 
			DateTime? m3CODT = null, 
			decimal? m3CFQA = null, 
			decimal? m3CPPR = null, 
			int? m3CPUC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConfirmEPRLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RQID))
				throw new ArgumentNullException(nameof(m3RQID));

			// Set mandatory parameters
			request
				.WithQueryParameter("RQID", m3RQID.Trim())
				.WithQueryParameter("RQDN", m3RQDN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());
			if (m3CODT.HasValue)
				request.WithQueryParameter("CODT", m3CODT.Value.ToM3String());
			if (m3CFQA.HasValue)
				request.WithQueryParameter("CFQA", m3CFQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPPR.HasValue)
				request.WithQueryParameter("CPPR", m3CPPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPUC.HasValue)
				request.WithQueryParameter("CPUC", m3CPUC.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CrtEPRPO
		/// Description Create e-Procurement purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RQNO">Requisition number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CrtEPRPO(
			string m3RQNO, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtEPRPO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RQNO))
				throw new ArgumentNullException(nameof(m3RQNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("RQNO", m3RQNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ReceiptEPR
		/// Description Goods Receipt e-Procurement order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRDT">Transaction date (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3RQID">Requisition identity (Required)</param>
		/// <param name="m3RQDN">Requisition detail number (Required)</param>
		/// <param name="m3RVQA">Received quantity (Required)</param>
		/// <param name="m3CONO">Company No</param>
		/// <param name="m3PNLS">Purchase Order Number Subline</param>
		/// <param name="m3OEND">Finish Mark</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReceiptEPR(
			DateTime m3TRDT, 
			string m3RESP, 
			string m3RQID, 
			int m3RQDN, 
			string m3RVQA, 
			int? m3CONO = null, 
			int? m3PNLS = null, 
			int? m3OEND = null, 
			string m3WHSL = null, 
			string m3SUDO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReceiptEPR",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));
			if (string.IsNullOrWhiteSpace(m3RQID))
				throw new ArgumentNullException(nameof(m3RQID));
			if (string.IsNullOrWhiteSpace(m3RVQA))
				throw new ArgumentNullException(nameof(m3RVQA));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRDT", m3TRDT.ToM3String())
				.WithQueryParameter("RESP", m3RESP.Trim())
				.WithQueryParameter("RQID", m3RQID.Trim())
				.WithQueryParameter("RQDN", m3RQDN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RVQA", m3RVQA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());

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
