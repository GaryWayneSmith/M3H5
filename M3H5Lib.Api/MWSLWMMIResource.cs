/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPOData
		/// Description Get receiving data for a purchase order line
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3PNLI">Purchase order line (Required)</param>
		/// <param name="m3PNLS">Purchase order line subnumber (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPODataResponse></returns>
		/// <exception cref="M3Exception<GetPODataResponse>"></exception>
		public async Task<M3Response<GetPODataResponse>> GetPOData(
			string m3PUNO, 
			int m3PNLI, 
			int m3PNLS, 
			string m3BANO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPOData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PNLS", m3PNLS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<GetPODataResponse>(
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
		/// Name LstDOLine
		/// Description List DO line transactions
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3TODT">To date (Required)</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3CONB">Consignor</param>
		/// <param name="m3FRRO">Reference order category</param>
		/// <param name="m3TORO">Reference order category</param>
		/// <param name="m3CONN">Shipment</param>
		/// <param name="m3ETRN">External tracking number</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3FRTM">Transaction time from</param>
		/// <param name="m3TOTM">Transaction time to</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3XCNT">Check sequence - item identity</param>
		/// <param name="m3CHAL">Search sequence - alias type</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDOLineResponse></returns>
		/// <exception cref="M3Exception<LstDOLineResponse>"></exception>
		public async Task<M3Response<LstDOLineResponse>> LstDOLine(
			string m3WHLO, 
			DateTime m3FRDT, 
			DateTime m3TODT, 
			decimal? m3DLIX = null, 
			string m3CONB = null, 
			int? m3FRRO = null, 
			int? m3TORO = null, 
			int? m3CONN = null, 
			string m3ETRN = null, 
			string m3FWNO = null, 
			int? m3FRTM = null, 
			int? m3TOTM = null, 
			string m3PANR = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3XCNT = null, 
			int? m3CHAL = null, 
			string m3SSCC = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("TODT", m3TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CONB))
				request.WithQueryParameter("CONB", m3CONB.Trim());
			if (m3FRRO.HasValue)
				request.WithQueryParameter("FRRO", m3FRRO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TORO.HasValue)
				request.WithQueryParameter("TORO", m3TORO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONN.HasValue)
				request.WithQueryParameter("CONN", m3CONN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ETRN))
				request.WithQueryParameter("ETRN", m3ETRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (m3FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3FRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3TOTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3XCNT))
				request.WithQueryParameter("XCNT", m3XCNT.Trim());
			if (m3CHAL.HasValue)
				request.WithQueryParameter("CHAL", m3CHAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());

			// Execute the request
			var result = await Execute<LstDOLineResponse>(
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
		/// Name LstDOPac
		/// Description List DO Pac transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3TODT">To date (Required)</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3CONB">Consignor</param>
		/// <param name="m3FRRO">Reference order category</param>
		/// <param name="m3TORO">Reference order category</param>
		/// <param name="m3CONN">Shipment</param>
		/// <param name="m3ETRN">External tracking number</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3FRTM">From time</param>
		/// <param name="m3TOTM">To time</param>
		/// <param name="m3FRPA">Package level</param>
		/// <param name="m3TOPA">Package level</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDOPacResponse></returns>
		/// <exception cref="M3Exception<LstDOPacResponse>"></exception>
		public async Task<M3Response<LstDOPacResponse>> LstDOPac(
			string m3WHLO, 
			DateTime m3FRDT, 
			DateTime m3TODT, 
			decimal? m3DLIX = null, 
			string m3CONB = null, 
			int? m3FRRO = null, 
			int? m3TORO = null, 
			int? m3CONN = null, 
			string m3ETRN = null, 
			string m3FWNO = null, 
			int? m3FRTM = null, 
			int? m3TOTM = null, 
			int? m3FRPA = null, 
			int? m3TOPA = null, 
			string m3SSCC = null, 
			string m3PANR = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDOPac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("TODT", m3TODT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CONB))
				request.WithQueryParameter("CONB", m3CONB.Trim());
			if (m3FRRO.HasValue)
				request.WithQueryParameter("FRRO", m3FRRO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TORO.HasValue)
				request.WithQueryParameter("TORO", m3TORO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONN.HasValue)
				request.WithQueryParameter("CONN", m3CONN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ETRN))
				request.WithQueryParameter("ETRN", m3ETRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (m3FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3FRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3TOTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRPA.HasValue)
				request.WithQueryParameter("FRPA", m3FRPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPA.HasValue)
				request.WithQueryParameter("TOPA", m3TOPA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());

			// Execute the request
			var result = await Execute<LstDOPacResponse>(
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
		/// Name LstExpPOReceipt
		/// Description List expected PO receipts
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3TPDT">To - Planning date (Required)</param>
		/// <param name="m3FPDT">From - Planning date</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3XCNT">Check sequence - item identity</param>
		/// <param name="m3CHAL">Check sequence - alias type</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3SORN">Supplier order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExpPOReceiptResponse></returns>
		/// <exception cref="M3Exception<LstExpPOReceiptResponse>"></exception>
		public async Task<M3Response<LstExpPOReceiptResponse>> LstExpPOReceipt(
			string m3WHLO, 
			DateTime m3TPDT, 
			DateTime? m3FPDT = null, 
			string m3ITNO = null, 
			string m3XCNT = null, 
			string m3CHAL = null, 
			string m3SUNO = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			string m3SUDO = null, 
			string m3SORN = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstExpPOReceipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("TPDT", m3TPDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FPDT.HasValue)
				request.WithQueryParameter("FPDT", m3FPDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3XCNT))
				request.WithQueryParameter("XCNT", m3XCNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHAL))
				request.WithQueryParameter("CHAL", m3CHAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());

			// Execute the request
			var result = await Execute<LstExpPOReceiptResponse>(
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
		/// Name LstMOHead
		/// Description List MO head transactions
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3XCNT">Check sequence - item identity</param>
		/// <param name="m3CHAL">Check sequence - alias type</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SLFR">From status</param>
		/// <param name="m3SLTO">To status</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3FRTM">From time</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3TOTM">To time</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMOHeadResponse></returns>
		/// <exception cref="M3Exception<LstMOHeadResponse>"></exception>
		public async Task<M3Response<LstMOHeadResponse>> LstMOHead(
			string m3FACI, 
			decimal? m3WOSQ = null, 
			string m3POPN = null, 
			string m3XCNT = null, 
			int? m3CHAL = null, 
			string m3MFNO = null, 
			decimal? m3SCHN = null, 
			string m3BANO = null, 
			string m3SLFR = null, 
			string m3SLTO = null, 
			DateTime? m3FDAT = null, 
			int? m3FRTM = null, 
			DateTime? m3TDAT = null, 
			int? m3TOTM = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMOHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3XCNT))
				request.WithQueryParameter("XCNT", m3XCNT.Trim());
			if (m3CHAL.HasValue)
				request.WithQueryParameter("CHAL", m3CHAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLFR))
				request.WithQueryParameter("SLFR", m3SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTO))
				request.WithQueryParameter("SLTO", m3SLTO.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3FRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3TOTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());

			// Execute the request
			var result = await Execute<LstMOHeadResponse>(
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
		/// Name LstMOHead2
		/// Description List MO head transactions
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3XCNT">Check sequence - item identity</param>
		/// <param name="m3CHAL">Check sequence - alias type</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SLFR">From status</param>
		/// <param name="m3SLTO">To status</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3FRTM">From time</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3TOTM">To time</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMOHead2Response></returns>
		/// <exception cref="M3Exception<LstMOHead2Response>"></exception>
		public async Task<M3Response<LstMOHead2Response>> LstMOHead2(
			string m3FACI, 
			decimal? m3WOSQ = null, 
			string m3POPN = null, 
			string m3XCNT = null, 
			int? m3CHAL = null, 
			string m3MFNO = null, 
			decimal? m3SCHN = null, 
			string m3BANO = null, 
			string m3SLFR = null, 
			string m3SLTO = null, 
			DateTime? m3FDAT = null, 
			int? m3FRTM = null, 
			DateTime? m3TDAT = null, 
			int? m3TOTM = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMOHead2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3XCNT))
				request.WithQueryParameter("XCNT", m3XCNT.Trim());
			if (m3CHAL.HasValue)
				request.WithQueryParameter("CHAL", m3CHAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLFR))
				request.WithQueryParameter("SLFR", m3SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTO))
				request.WithQueryParameter("SLTO", m3SLTO.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3FRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3TOTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());

			// Execute the request
			var result = await Execute<LstMOHead2Response>(
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
		/// Name LstMOMat
		/// Description List MO materials
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3XCNT">Check sequence - item identity</param>
		/// <param name="m3CHAL">Check sequence - alias type</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3FBYP">By/co-product code</param>
		/// <param name="m3TBYP">By/co-product code</param>
		/// <param name="m3SLFR">From status</param>
		/// <param name="m3SLTO">To status</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMOMatResponse></returns>
		/// <exception cref="M3Exception<LstMOMatResponse>"></exception>
		public async Task<M3Response<LstMOMatResponse>> LstMOMat(
			string m3FACI, 
			string m3WHLO = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			decimal? m3WOSQ = null, 
			decimal? m3SCHN = null, 
			string m3PLGR = null, 
			string m3POPN = null, 
			string m3XCNT = null, 
			int? m3CHAL = null, 
			int? m3SPMT = null, 
			string m3BANO = null, 
			string m3MTNO = null, 
			int? m3FBYP = null, 
			int? m3TBYP = null, 
			string m3SLFR = null, 
			string m3SLTO = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMOMat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3XCNT))
				request.WithQueryParameter("XCNT", m3XCNT.Trim());
			if (m3CHAL.HasValue)
				request.WithQueryParameter("CHAL", m3CHAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3FBYP.HasValue)
				request.WithQueryParameter("FBYP", m3FBYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TBYP.HasValue)
				request.WithQueryParameter("TBYP", m3TBYP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLFR))
				request.WithQueryParameter("SLFR", m3SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTO))
				request.WithQueryParameter("SLTO", m3SLTO.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstMOMatResponse>(
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
		/// Name LstMOOpe
		/// Description List MO operations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3XCNT">Check sequence - item identity</param>
		/// <param name="m3CHAL">Check sequence - alias type</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SLFR">From status</param>
		/// <param name="m3SLTO">To status</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3FRTM">From time</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3TOTM">To time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMOOpeResponse></returns>
		/// <exception cref="M3Exception<LstMOOpeResponse>"></exception>
		public async Task<M3Response<LstMOOpeResponse>> LstMOOpe(
			string m3FACI, 
			decimal? m3WOSQ = null, 
			string m3POPN = null, 
			string m3XCNT = null, 
			int? m3CHAL = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			decimal? m3SCHN = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			string m3BANO = null, 
			string m3SLFR = null, 
			string m3SLTO = null, 
			DateTime? m3FDAT = null, 
			int? m3FRTM = null, 
			DateTime? m3TDAT = null, 
			int? m3TOTM = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMOOpe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3XCNT))
				request.WithQueryParameter("XCNT", m3XCNT.Trim());
			if (m3CHAL.HasValue)
				request.WithQueryParameter("CHAL", m3CHAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLFR))
				request.WithQueryParameter("SLFR", m3SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTO))
				request.WithQueryParameter("SLTO", m3SLTO.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3FRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3TOTM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstMOOpeResponse>(
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
		/// Name LstMOOpe2
		/// Description List MO operations
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3XCNT">Check sequence - item identity</param>
		/// <param name="m3CHAL">Check sequence - alias type</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SLFR">From status</param>
		/// <param name="m3SLTO">To status</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3FRTM">From time</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3TOTM">To time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMOOpe2Response></returns>
		/// <exception cref="M3Exception<LstMOOpe2Response>"></exception>
		public async Task<M3Response<LstMOOpe2Response>> LstMOOpe2(
			string m3FACI, 
			decimal? m3WOSQ = null, 
			string m3POPN = null, 
			string m3XCNT = null, 
			int? m3CHAL = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			decimal? m3SCHN = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			string m3BANO = null, 
			string m3SLFR = null, 
			string m3SLTO = null, 
			DateTime? m3FDAT = null, 
			int? m3FRTM = null, 
			DateTime? m3TDAT = null, 
			int? m3TOTM = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMOOpe2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3XCNT))
				request.WithQueryParameter("XCNT", m3XCNT.Trim());
			if (m3CHAL.HasValue)
				request.WithQueryParameter("CHAL", m3CHAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLFR))
				request.WithQueryParameter("SLFR", m3SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTO))
				request.WithQueryParameter("SLTO", m3SLTO.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3FRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3TOTM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstMOOpe2Response>(
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
		/// Name LstPOLine
		/// Description List PO lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3FPDT">From - Planning date</param>
		/// <param name="m3TPDT">To - Planning date</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3TVDT">Valid to</param>
		/// <param name="m3FHST">From highest status</param>
		/// <param name="m3THST">To highest status</param>
		/// <param name="m3FLST">From lowest status</param>
		/// <param name="m3TLST">To lowest status</param>
		/// <param name="m3FPOC">From purchase order category</param>
		/// <param name="m3TPOC">To purchase order category</param>
		/// <param name="m3FLIT">From line type</param>
		/// <param name="m3TLIT">To line type</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3XCNT">Check sequence - item identity</param>
		/// <param name="m3CHAL">Check sequence - alias type</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3SORN">Supplier order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPOLineResponse></returns>
		/// <exception cref="M3Exception<LstPOLineResponse>"></exception>
		public async Task<M3Response<LstPOLineResponse>> LstPOLine(
			string m3WHLO, 
			DateTime? m3FPDT = null, 
			DateTime? m3TPDT = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3TVDT = null, 
			string m3FHST = null, 
			string m3THST = null, 
			string m3FLST = null, 
			string m3TLST = null, 
			string m3FPOC = null, 
			string m3TPOC = null, 
			string m3FLIT = null, 
			string m3TLIT = null, 
			string m3ITNO = null, 
			string m3XCNT = null, 
			string m3CHAL = null, 
			string m3PUNO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
			string m3SUNO = null, 
			string m3SUDO = null, 
			string m3SORN = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FPDT.HasValue)
				request.WithQueryParameter("FPDT", m3FPDT.Value.ToM3String());
			if (m3TPDT.HasValue)
				request.WithQueryParameter("TPDT", m3TPDT.Value.ToM3String());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3TVDT.HasValue)
				request.WithQueryParameter("TVDT", m3TVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FHST))
				request.WithQueryParameter("FHST", m3FHST.Trim());
			if (!string.IsNullOrWhiteSpace(m3THST))
				request.WithQueryParameter("THST", m3THST.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLST))
				request.WithQueryParameter("FLST", m3FLST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLST))
				request.WithQueryParameter("TLST", m3TLST.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPOC))
				request.WithQueryParameter("FPOC", m3FPOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPOC))
				request.WithQueryParameter("TPOC", m3TPOC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLIT))
				request.WithQueryParameter("FLIT", m3FLIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLIT))
				request.WithQueryParameter("TLIT", m3TLIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3XCNT))
				request.WithQueryParameter("XCNT", m3XCNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHAL))
				request.WithQueryParameter("CHAL", m3CHAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());

			// Execute the request
			var result = await Execute<LstPOLineResponse>(
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
		/// Name SelDOLineConn
		/// Description Select DO line Conn transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDOLineConnResponse></returns>
		/// <exception cref="M3Exception<SelDOLineConnResponse>"></exception>
		public async Task<M3Response<SelDOLineConnResponse>> SelDOLineConn(
			string m3WHLO, 
			string m3SSCC = null, 
			string m3PANR = null, 
			decimal? m3DLIX = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelDOLineConn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelDOLineConnResponse>(
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
		/// Name SelDOPacConn
		/// Description List DO Pac Conn transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3PANR">Package number</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDOPacConnResponse></returns>
		/// <exception cref="M3Exception<SelDOPacConnResponse>"></exception>
		public async Task<M3Response<SelDOPacConnResponse>> SelDOPacConn(
			string m3WHLO, 
			string m3SSCC = null, 
			string m3PANR = null, 
			decimal? m3DLIX = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelDOPacConn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PANR))
				request.WithQueryParameter("PANR", m3PANR.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelDOPacConnResponse>(
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
