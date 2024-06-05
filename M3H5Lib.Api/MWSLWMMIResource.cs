/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWSLWMMI;
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
	/// Name: MWSLWMMI
	/// Component Name: LWM List expected receipts
	/// Description: LWM List expected receipts
	/// Version Release: 5ea4
	///</summary>
	public partial class MWSLWMMIResource : M3BaseResourceEndpoint
	{
		public MWSLWMMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWSLWMMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPOData
		/// Description Get receiving data for a purchase order line
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_PNLI">Purchase order line (Required)</param>
		/// <param name="m3_PNLS">Purchase order line subnumber (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPODataResponse></returns>
		/// <exception cref="M3Exception<GetPODataResponse>"></exception>
		public async Task<M3Response<GetPODataResponse>> GetPOData(
			string m3_PUNO, 
			int m3_PNLI, 
			int m3_PNLS, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPOData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString())
				.WithQueryParameter("PNLS", m3_PNLS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<GetPODataResponse>(
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
		/// Name LstDOLine
		/// Description List DO line transactions
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_TODT">To date (Required)</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_CONB">Consignor</param>
		/// <param name="m3_FRRO">Reference order category</param>
		/// <param name="m3_TORO">Reference order category</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_ETRN">External tracking number</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_FRTM">Transaction time from</param>
		/// <param name="m3_TOTM">Transaction time to</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_XCNT">Check sequence - item identity</param>
		/// <param name="m3_CHAL">Search sequence - alias type</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDOLineResponse></returns>
		/// <exception cref="M3Exception<LstDOLineResponse>"></exception>
		public async Task<M3Response<LstDOLineResponse>> LstDOLine(
			string m3_WHLO, 
			DateTime m3_FRDT, 
			DateTime m3_TODT, 
			decimal? m3_DLIX = null, 
			string m3_CONB = null, 
			int? m3_FRRO = null, 
			int? m3_TORO = null, 
			int? m3_CONN = null, 
			string m3_ETRN = null, 
			string m3_FWNO = null, 
			int? m3_FRTM = null, 
			int? m3_TOTM = null, 
			string m3_PANR = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_XCNT = null, 
			int? m3_CHAL = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("TODT", m3_TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CONB))
				request.WithQueryParameter("CONB", m3_CONB.Trim());
			if (m3_FRRO.HasValue)
				request.WithQueryParameter("FRRO", m3_FRRO.Value.ToString());
			if (m3_TORO.HasValue)
				request.WithQueryParameter("TORO", m3_TORO.Value.ToString());
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ETRN))
				request.WithQueryParameter("ETRN", m3_ETRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (m3_FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3_FRTM.Value.ToString());
			if (m3_TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3_TOTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XCNT))
				request.WithQueryParameter("XCNT", m3_XCNT.Trim());
			if (m3_CHAL.HasValue)
				request.WithQueryParameter("CHAL", m3_CHAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<LstDOLineResponse>(
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
		/// Name LstDOPac
		/// Description List DO Pac transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_TODT">To date (Required)</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_CONB">Consignor</param>
		/// <param name="m3_FRRO">Reference order category</param>
		/// <param name="m3_TORO">Reference order category</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_ETRN">External tracking number</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_FRTM">From time</param>
		/// <param name="m3_TOTM">To time</param>
		/// <param name="m3_FRPA">Package level</param>
		/// <param name="m3_TOPA">Package level</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDOPacResponse></returns>
		/// <exception cref="M3Exception<LstDOPacResponse>"></exception>
		public async Task<M3Response<LstDOPacResponse>> LstDOPac(
			string m3_WHLO, 
			DateTime m3_FRDT, 
			DateTime m3_TODT, 
			decimal? m3_DLIX = null, 
			string m3_CONB = null, 
			int? m3_FRRO = null, 
			int? m3_TORO = null, 
			int? m3_CONN = null, 
			string m3_ETRN = null, 
			string m3_FWNO = null, 
			int? m3_FRTM = null, 
			int? m3_TOTM = null, 
			int? m3_FRPA = null, 
			int? m3_TOPA = null, 
			string m3_SSCC = null, 
			string m3_PANR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDOPac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("TODT", m3_TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CONB))
				request.WithQueryParameter("CONB", m3_CONB.Trim());
			if (m3_FRRO.HasValue)
				request.WithQueryParameter("FRRO", m3_FRRO.Value.ToString());
			if (m3_TORO.HasValue)
				request.WithQueryParameter("TORO", m3_TORO.Value.ToString());
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ETRN))
				request.WithQueryParameter("ETRN", m3_ETRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (m3_FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3_FRTM.Value.ToString());
			if (m3_TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3_TOTM.Value.ToString());
			if (m3_FRPA.HasValue)
				request.WithQueryParameter("FRPA", m3_FRPA.Value.ToString());
			if (m3_TOPA.HasValue)
				request.WithQueryParameter("TOPA", m3_TOPA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());

			// Execute the request
			var result = await Execute<LstDOPacResponse>(
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
		/// Name LstExpPOReceipt
		/// Description List expected PO receipts
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_TPDT">To - Planning date (Required)</param>
		/// <param name="m3_FPDT">From - Planning date</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_XCNT">Check sequence - item identity</param>
		/// <param name="m3_CHAL">Check sequence - alias type</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_SORN">Supplier order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExpPOReceiptResponse></returns>
		/// <exception cref="M3Exception<LstExpPOReceiptResponse>"></exception>
		public async Task<M3Response<LstExpPOReceiptResponse>> LstExpPOReceipt(
			string m3_WHLO, 
			DateTime m3_TPDT, 
			DateTime? m3_FPDT = null, 
			string m3_ITNO = null, 
			string m3_XCNT = null, 
			string m3_CHAL = null, 
			string m3_SUNO = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_SUDO = null, 
			string m3_SORN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstExpPOReceipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("TPDT", m3_TPDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FPDT.HasValue)
				request.WithQueryParameter("FPDT", m3_FPDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XCNT))
				request.WithQueryParameter("XCNT", m3_XCNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHAL))
				request.WithQueryParameter("CHAL", m3_CHAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());

			// Execute the request
			var result = await Execute<LstExpPOReceiptResponse>(
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
		/// Name LstMOHead
		/// Description List MO head transactions
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_XCNT">Check sequence - item identity</param>
		/// <param name="m3_CHAL">Check sequence - alias type</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SLFR">From status</param>
		/// <param name="m3_SLTO">To status</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_FRTM">From time</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_TOTM">To time</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMOHeadResponse></returns>
		/// <exception cref="M3Exception<LstMOHeadResponse>"></exception>
		public async Task<M3Response<LstMOHeadResponse>> LstMOHead(
			string m3_FACI, 
			decimal? m3_WOSQ = null, 
			string m3_POPN = null, 
			string m3_XCNT = null, 
			int? m3_CHAL = null, 
			string m3_MFNO = null, 
			decimal? m3_SCHN = null, 
			string m3_BANO = null, 
			string m3_SLFR = null, 
			string m3_SLTO = null, 
			DateTime? m3_FDAT = null, 
			int? m3_FRTM = null, 
			DateTime? m3_TDAT = null, 
			int? m3_TOTM = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMOHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XCNT))
				request.WithQueryParameter("XCNT", m3_XCNT.Trim());
			if (m3_CHAL.HasValue)
				request.WithQueryParameter("CHAL", m3_CHAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLFR))
				request.WithQueryParameter("SLFR", m3_SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTO))
				request.WithQueryParameter("SLTO", m3_SLTO.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3_FRTM.Value.ToString());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3_TOTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());

			// Execute the request
			var result = await Execute<LstMOHeadResponse>(
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
		/// Name LstMOHead2
		/// Description List MO head transactions
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_XCNT">Check sequence - item identity</param>
		/// <param name="m3_CHAL">Check sequence - alias type</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SLFR">From status</param>
		/// <param name="m3_SLTO">To status</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_FRTM">From time</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_TOTM">To time</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMOHead2Response></returns>
		/// <exception cref="M3Exception<LstMOHead2Response>"></exception>
		public async Task<M3Response<LstMOHead2Response>> LstMOHead2(
			string m3_FACI, 
			decimal? m3_WOSQ = null, 
			string m3_POPN = null, 
			string m3_XCNT = null, 
			int? m3_CHAL = null, 
			string m3_MFNO = null, 
			decimal? m3_SCHN = null, 
			string m3_BANO = null, 
			string m3_SLFR = null, 
			string m3_SLTO = null, 
			DateTime? m3_FDAT = null, 
			int? m3_FRTM = null, 
			DateTime? m3_TDAT = null, 
			int? m3_TOTM = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMOHead2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XCNT))
				request.WithQueryParameter("XCNT", m3_XCNT.Trim());
			if (m3_CHAL.HasValue)
				request.WithQueryParameter("CHAL", m3_CHAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLFR))
				request.WithQueryParameter("SLFR", m3_SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTO))
				request.WithQueryParameter("SLTO", m3_SLTO.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3_FRTM.Value.ToString());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3_TOTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());

			// Execute the request
			var result = await Execute<LstMOHead2Response>(
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
		/// Name LstMOMat
		/// Description List MO materials
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_XCNT">Check sequence - item identity</param>
		/// <param name="m3_CHAL">Check sequence - alias type</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_FBYP">By/co-product code</param>
		/// <param name="m3_TBYP">By/co-product code</param>
		/// <param name="m3_SLFR">From status</param>
		/// <param name="m3_SLTO">To status</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMOMatResponse></returns>
		/// <exception cref="M3Exception<LstMOMatResponse>"></exception>
		public async Task<M3Response<LstMOMatResponse>> LstMOMat(
			string m3_FACI, 
			string m3_WHLO = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
			decimal? m3_WOSQ = null, 
			decimal? m3_SCHN = null, 
			string m3_PLGR = null, 
			string m3_POPN = null, 
			string m3_XCNT = null, 
			int? m3_CHAL = null, 
			int? m3_SPMT = null, 
			string m3_BANO = null, 
			string m3_MTNO = null, 
			int? m3_FBYP = null, 
			int? m3_TBYP = null, 
			string m3_SLFR = null, 
			string m3_SLTO = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMOMat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XCNT))
				request.WithQueryParameter("XCNT", m3_XCNT.Trim());
			if (m3_CHAL.HasValue)
				request.WithQueryParameter("CHAL", m3_CHAL.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (m3_FBYP.HasValue)
				request.WithQueryParameter("FBYP", m3_FBYP.Value.ToString());
			if (m3_TBYP.HasValue)
				request.WithQueryParameter("TBYP", m3_TBYP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLFR))
				request.WithQueryParameter("SLFR", m3_SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTO))
				request.WithQueryParameter("SLTO", m3_SLTO.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstMOMatResponse>(
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
		/// Name LstMOOpe
		/// Description List MO operations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_XCNT">Check sequence - item identity</param>
		/// <param name="m3_CHAL">Check sequence - alias type</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SLFR">From status</param>
		/// <param name="m3_SLTO">To status</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_FRTM">From time</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_TOTM">To time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMOOpeResponse></returns>
		/// <exception cref="M3Exception<LstMOOpeResponse>"></exception>
		public async Task<M3Response<LstMOOpeResponse>> LstMOOpe(
			string m3_FACI, 
			decimal? m3_WOSQ = null, 
			string m3_POPN = null, 
			string m3_XCNT = null, 
			int? m3_CHAL = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
			decimal? m3_SCHN = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			string m3_BANO = null, 
			string m3_SLFR = null, 
			string m3_SLTO = null, 
			DateTime? m3_FDAT = null, 
			int? m3_FRTM = null, 
			DateTime? m3_TDAT = null, 
			int? m3_TOTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMOOpe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XCNT))
				request.WithQueryParameter("XCNT", m3_XCNT.Trim());
			if (m3_CHAL.HasValue)
				request.WithQueryParameter("CHAL", m3_CHAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLFR))
				request.WithQueryParameter("SLFR", m3_SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTO))
				request.WithQueryParameter("SLTO", m3_SLTO.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3_FRTM.Value.ToString());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3_TOTM.Value.ToString());

			// Execute the request
			var result = await Execute<LstMOOpeResponse>(
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
		/// Name LstMOOpe2
		/// Description List MO operations
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_XCNT">Check sequence - item identity</param>
		/// <param name="m3_CHAL">Check sequence - alias type</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SLFR">From status</param>
		/// <param name="m3_SLTO">To status</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_FRTM">From time</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_TOTM">To time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMOOpe2Response></returns>
		/// <exception cref="M3Exception<LstMOOpe2Response>"></exception>
		public async Task<M3Response<LstMOOpe2Response>> LstMOOpe2(
			string m3_FACI, 
			decimal? m3_WOSQ = null, 
			string m3_POPN = null, 
			string m3_XCNT = null, 
			int? m3_CHAL = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
			decimal? m3_SCHN = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			string m3_BANO = null, 
			string m3_SLFR = null, 
			string m3_SLTO = null, 
			DateTime? m3_FDAT = null, 
			int? m3_FRTM = null, 
			DateTime? m3_TDAT = null, 
			int? m3_TOTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMOOpe2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XCNT))
				request.WithQueryParameter("XCNT", m3_XCNT.Trim());
			if (m3_CHAL.HasValue)
				request.WithQueryParameter("CHAL", m3_CHAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLFR))
				request.WithQueryParameter("SLFR", m3_SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTO))
				request.WithQueryParameter("SLTO", m3_SLTO.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3_FRTM.Value.ToString());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3_TOTM.Value.ToString());

			// Execute the request
			var result = await Execute<LstMOOpe2Response>(
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
		/// Name LstPOLine
		/// Description List PO lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_FPDT">From - Planning date</param>
		/// <param name="m3_TPDT">To - Planning date</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_TVDT">Valid to</param>
		/// <param name="m3_FHST">From highest status</param>
		/// <param name="m3_THST">To highest status</param>
		/// <param name="m3_FLST">From lowest status</param>
		/// <param name="m3_TLST">To lowest status</param>
		/// <param name="m3_FPOC">From purchase order category</param>
		/// <param name="m3_TPOC">To purchase order category</param>
		/// <param name="m3_FLIT">From line type</param>
		/// <param name="m3_TLIT">To line type</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_XCNT">Check sequence - item identity</param>
		/// <param name="m3_CHAL">Check sequence - alias type</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_SORN">Supplier order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPOLineResponse></returns>
		/// <exception cref="M3Exception<LstPOLineResponse>"></exception>
		public async Task<M3Response<LstPOLineResponse>> LstPOLine(
			string m3_WHLO, 
			DateTime? m3_FPDT = null, 
			DateTime? m3_TPDT = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_TVDT = null, 
			string m3_FHST = null, 
			string m3_THST = null, 
			string m3_FLST = null, 
			string m3_TLST = null, 
			string m3_FPOC = null, 
			string m3_TPOC = null, 
			string m3_FLIT = null, 
			string m3_TLIT = null, 
			string m3_ITNO = null, 
			string m3_XCNT = null, 
			string m3_CHAL = null, 
			string m3_PUNO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
			string m3_SUNO = null, 
			string m3_SUDO = null, 
			string m3_SORN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FPDT.HasValue)
				request.WithQueryParameter("FPDT", m3_FPDT.Value.ToM3String());
			if (m3_TPDT.HasValue)
				request.WithQueryParameter("TPDT", m3_TPDT.Value.ToM3String());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_TVDT.HasValue)
				request.WithQueryParameter("TVDT", m3_TVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FHST))
				request.WithQueryParameter("FHST", m3_FHST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_THST))
				request.WithQueryParameter("THST", m3_THST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLST))
				request.WithQueryParameter("FLST", m3_FLST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLST))
				request.WithQueryParameter("TLST", m3_TLST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPOC))
				request.WithQueryParameter("FPOC", m3_FPOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPOC))
				request.WithQueryParameter("TPOC", m3_TPOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLIT))
				request.WithQueryParameter("FLIT", m3_FLIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLIT))
				request.WithQueryParameter("TLIT", m3_TLIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XCNT))
				request.WithQueryParameter("XCNT", m3_XCNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHAL))
				request.WithQueryParameter("CHAL", m3_CHAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());

			// Execute the request
			var result = await Execute<LstPOLineResponse>(
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
		/// Name SelDOLineConn
		/// Description Select DO line Conn transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDOLineConnResponse></returns>
		/// <exception cref="M3Exception<SelDOLineConnResponse>"></exception>
		public async Task<M3Response<SelDOLineConnResponse>> SelDOLineConn(
			string m3_WHLO, 
			string m3_SSCC = null, 
			string m3_PANR = null, 
			decimal? m3_DLIX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelDOLineConn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());

			// Execute the request
			var result = await Execute<SelDOLineConnResponse>(
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
		/// Name SelDOPacConn
		/// Description List DO Pac Conn transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDOPacConnResponse></returns>
		/// <exception cref="M3Exception<SelDOPacConnResponse>"></exception>
		public async Task<M3Response<SelDOPacConnResponse>> SelDOPacConn(
			string m3_WHLO, 
			string m3_SSCC = null, 
			string m3_PANR = null, 
			decimal? m3_DLIX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelDOPacConn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());

			// Execute the request
			var result = await Execute<SelDOPacConnResponse>(
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
