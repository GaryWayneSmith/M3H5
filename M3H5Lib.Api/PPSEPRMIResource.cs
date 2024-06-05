/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_RQNO">Requisition number (Required)</param>
		/// <param name="m3_RQID">Requisition identity (Required)</param>
		/// <param name="m3_RQDN">Requisition detail number (Required)</param>
		/// <param name="m3_SUNO">Supplier Number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_PPQT">Planned Quantity (Required)</param>
		/// <param name="m3_PUUN">Purchase order U/M (Required)</param>
		/// <param name="m3_PUPR">Purchase price (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_DLDT">Planned delivery date (Required)</param>
		/// <param name="m3_PURC">Requistion By (Required)</param>
		/// <param name="m3_PITT">PO item description (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SITE">Supplier Item number</param>
		/// <param name="m3_ACRF">Accounting control object</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_ADR1">Address line 1</param>
		/// <param name="m3_ADR2">Address line 2</param>
		/// <param name="m3_ADR3">Address line 3</param>
		/// <param name="m3_ADR4">Address line 4</param>
		/// <param name="m3_TEOR">Telephone order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEPRReq(
			string m3_WHLO, 
			string m3_RQNO, 
			string m3_RQID, 
			int m3_RQDN, 
			string m3_SUNO, 
			string m3_ITNO, 
			decimal m3_PPQT, 
			string m3_PUUN, 
			decimal m3_PUPR, 
			string m3_CUCD, 
			DateTime m3_DLDT, 
			string m3_PURC, 
			string m3_PITT, 
			int? m3_CONO = null, 
			string m3_SITE = null, 
			string m3_ACRF = null, 
			string m3_COCE = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_ORTY = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_ADR1 = null, 
			string m3_ADR2 = null, 
			string m3_ADR3 = null, 
			string m3_ADR4 = null, 
			int? m3_TEOR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_RQNO))
				throw new ArgumentNullException("m3_RQNO");
			if (string.IsNullOrWhiteSpace(m3_RQID))
				throw new ArgumentNullException("m3_RQID");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_PUUN))
				throw new ArgumentNullException("m3_PUUN");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_PURC))
				throw new ArgumentNullException("m3_PURC");
			if (string.IsNullOrWhiteSpace(m3_PITT))
				throw new ArgumentNullException("m3_PITT");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("RQNO", m3_RQNO.Trim())
				.WithQueryParameter("RQID", m3_RQID.Trim())
				.WithQueryParameter("RQDN", m3_RQDN.ToString())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("PPQT", m3_PPQT.ToString())
				.WithQueryParameter("PUUN", m3_PUUN.Trim())
				.WithQueryParameter("PUPR", m3_PUPR.ToString())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("DLDT", m3_DLDT.ToM3String())
				.WithQueryParameter("PURC", m3_PURC.Trim())
				.WithQueryParameter("PITT", m3_PITT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR1))
				request.WithQueryParameter("ADR1", m3_ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR2))
				request.WithQueryParameter("ADR2", m3_ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR3))
				request.WithQueryParameter("ADR3", m3_ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR4))
				request.WithQueryParameter("ADR4", m3_ADR4.Trim());
			if (m3_TEOR.HasValue)
				request.WithQueryParameter("TEOR", m3_TEOR.Value.ToString());

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
		/// Name AddEPRText
		/// Description Add text to EPR transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RQNO">Requisition number (Required)</param>
		/// <param name="m3_RQID">Requisition identity (Required)</param>
		/// <param name="m3_RQDN">Requisition detail number (Required)</param>
		/// <param name="m3_LINO">Line number (Required)</param>
		/// <param name="m3_TX60">Text (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEPRText(
			string m3_RQNO, 
			string m3_RQID, 
			int m3_RQDN, 
			int m3_LINO, 
			string m3_TX60, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_RQNO))
				throw new ArgumentNullException("m3_RQNO");
			if (string.IsNullOrWhiteSpace(m3_RQID))
				throw new ArgumentNullException("m3_RQID");
			if (string.IsNullOrWhiteSpace(m3_TX60))
				throw new ArgumentNullException("m3_TX60");

			// Set mandatory parameters
			request
				.WithQueryParameter("RQNO", m3_RQNO.Trim())
				.WithQueryParameter("RQID", m3_RQID.Trim())
				.WithQueryParameter("RQDN", m3_RQDN.ToString())
				.WithQueryParameter("LINO", m3_LINO.ToString())
				.WithQueryParameter("TX60", m3_TX60.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name ChgPOAdr
		/// Description Change the adress lines for a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_POAD">PO address type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_ADR1">Address line 1</param>
		/// <param name="m3_ADR2">Address line 2</param>
		/// <param name="m3_ADR3">Address line 3</param>
		/// <param name="m3_ADR4">Address line 4</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgPOAdr(
			string m3_PUNO, 
			string m3_POAD, 
			int? m3_CONO = null, 
			int? m3_PNLI = null, 
			string m3_ADR1 = null, 
			string m3_ADR2 = null, 
			string m3_ADR3 = null, 
			string m3_ADR4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");
			if (string.IsNullOrWhiteSpace(m3_POAD))
				throw new ArgumentNullException("m3_POAD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("POAD", m3_POAD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADR1))
				request.WithQueryParameter("ADR1", m3_ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR2))
				request.WithQueryParameter("ADR2", m3_ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR3))
				request.WithQueryParameter("ADR3", m3_ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR4))
				request.WithQueryParameter("ADR4", m3_ADR4.Trim());

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
		/// Name ConfirmEPRLine
		/// Description Confirm one e-Procurement order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RQID">Requisition identity (Required)</param>
		/// <param name="m3_RQDN">Requisition detail number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SORN">Supplier order number</param>
		/// <param name="m3_CODT">Confirmed delivery date</param>
		/// <param name="m3_CFQA">Confirmed quantity</param>
		/// <param name="m3_CPPR">Confirmed purchase price</param>
		/// <param name="m3_CPUC">Confirmed price quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConfirmEPRLine(
			string m3_RQID, 
			int m3_RQDN, 
			int? m3_CONO = null, 
			string m3_SORN = null, 
			DateTime? m3_CODT = null, 
			decimal? m3_CFQA = null, 
			decimal? m3_CPPR = null, 
			int? m3_CPUC = null, 
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
			if (string.IsNullOrWhiteSpace(m3_RQID))
				throw new ArgumentNullException("m3_RQID");

			// Set mandatory parameters
			request
				.WithQueryParameter("RQID", m3_RQID.Trim())
				.WithQueryParameter("RQDN", m3_RQDN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());
			if (m3_CODT.HasValue)
				request.WithQueryParameter("CODT", m3_CODT.Value.ToM3String());
			if (m3_CFQA.HasValue)
				request.WithQueryParameter("CFQA", m3_CFQA.Value.ToString());
			if (m3_CPPR.HasValue)
				request.WithQueryParameter("CPPR", m3_CPPR.Value.ToString());
			if (m3_CPUC.HasValue)
				request.WithQueryParameter("CPUC", m3_CPUC.Value.ToString());

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
		/// Name CrtEPRPO
		/// Description Create e-Procurement purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RQNO">Requisition number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CrtEPRPO(
			string m3_RQNO, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_RQNO))
				throw new ArgumentNullException("m3_RQNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("RQNO", m3_RQNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name ReceiptEPR
		/// Description Goods Receipt e-Procurement order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRDT">Transaction date (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_RQID">Requisition identity (Required)</param>
		/// <param name="m3_RQDN">Requisition detail number (Required)</param>
		/// <param name="m3_RVQA">Received quantity (Required)</param>
		/// <param name="m3_CONO">Company No</param>
		/// <param name="m3_PNLS">Purchase Order Number Subline</param>
		/// <param name="m3_OEND">Finish Mark</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReceiptEPR(
			DateTime m3_TRDT, 
			string m3_RESP, 
			string m3_RQID, 
			int m3_RQDN, 
			string m3_RVQA, 
			int? m3_CONO = null, 
			int? m3_PNLS = null, 
			int? m3_OEND = null, 
			string m3_WHSL = null, 
			string m3_SUDO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");
			if (string.IsNullOrWhiteSpace(m3_RQID))
				throw new ArgumentNullException("m3_RQID");
			if (string.IsNullOrWhiteSpace(m3_RVQA))
				throw new ArgumentNullException("m3_RVQA");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRDT", m3_TRDT.ToM3String())
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("RQID", m3_RQID.Trim())
				.WithQueryParameter("RQDN", m3_RQDN.ToString())
				.WithQueryParameter("RVQA", m3_RVQA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());

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
