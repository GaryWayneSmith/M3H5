/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS160MI;
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
	/// Name: PPS160MI
	/// Component Name: MaterialRequisition
	/// Description: Material requisition request interface
	/// Version Release: 11.3
	///</summary>
	public partial class PPS160MIResource : M3BaseResourceEndpoint
	{
		public PPS160MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS160MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMRAdr
		/// Description Add materials requisition Address
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_PLPS">Sub number - order proposal</param>
		/// <param name="m3_CONM">Company name</param>
		/// <param name="m3_OFID">Final destination</param>
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
		public async Task<M3Response<M3Record>> AddMRAdr(
			int m3_PLPN, 
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			int? m3_PLPS = null, 
			string m3_CONM = null, 
			string m3_OFID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMRAdr",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CONM))
				request.WithQueryParameter("CONM", m3_CONM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OFID))
				request.WithQueryParameter("OFID", m3_OFID.Trim());
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
		/// Name AddMRReq
		/// Description Add material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_PPQT">Planned Quantity (Required)</param>
		/// <param name="m3_UNMS">Basic unit of measure (Required)</param>
		/// <param name="m3_DLDT">Planned delivery date (Required)</param>
		/// <param name="m3_PURC">Requistion By (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PLPS">Sub number - order proposal</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ODI1">Discount 1</param>
		/// <param name="m3_ODI2">Discount 2</param>
		/// <param name="m3_ODI3">Discount 3</param>
		/// <param name="m3_SUNO">Supplier Number</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_ACRF">Accounting control object</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_PRCN">Procurement card number</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_IRCV">Recipient</param>
		/// <param name="m3_SITE">Supplier Item number</param>
		/// <param name="m3_PITD">PO item name</param>
		/// <param name="m3_PITT">PO item description</param>
		/// <param name="m3_TEOR">Telephone order</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PTXT">Note</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_AUTH">Authorizer</param>
		/// <param name="m3_SOMT">Type of acquisition order</param>
		/// <param name="m3_OFID">Final destination</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMRReq(
			string m3_WHLO, 
			int m3_PLPN, 
			string m3_ITNO, 
			decimal m3_PPQT, 
			string m3_UNMS, 
			DateTime m3_DLDT, 
			string m3_PURC, 
			int? m3_CONO = null, 
			string m3_FACI = null, 
			int? m3_PLPS = null, 
			string m3_PUUN = null, 
			decimal? m3_PUPR = null, 
			string m3_CUCD = null, 
			int? m3_ODI1 = null, 
			int? m3_ODI2 = null, 
			int? m3_ODI3 = null, 
			string m3_SUNO = null, 
			string m3_BUYE = null, 
			string m3_ACRF = null, 
			string m3_COCE = null, 
			string m3_PRCN = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			int? m3_RORC = null, 
			string m3_IRCV = null, 
			string m3_SITE = null, 
			string m3_PITD = null, 
			string m3_PITT = null, 
			int? m3_TEOR = null, 
			string m3_RESP = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_FWNO = null, 
			string m3_ORTY = null, 
			string m3_PTXT = null, 
			decimal? m3_TXID = null, 
			string m3_AUTH = null, 
			string m3_SOMT = null, 
			string m3_OFID = null, 
			string m3_PROJ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMRReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_UNMS))
				throw new ArgumentNullException("m3_UNMS");
			if (string.IsNullOrWhiteSpace(m3_PURC))
				throw new ArgumentNullException("m3_PURC");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("PPQT", m3_PPQT.ToString())
				.WithQueryParameter("UNMS", m3_UNMS.Trim())
				.WithQueryParameter("DLDT", m3_DLDT.ToM3String())
				.WithQueryParameter("PURC", m3_PURC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3_ODI1.Value.ToString());
			if (m3_ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3_ODI2.Value.ToString());
			if (m3_ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3_ODI3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRCN))
				request.WithQueryParameter("PRCN", m3_PRCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IRCV))
				request.WithQueryParameter("IRCV", m3_IRCV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITD))
				request.WithQueryParameter("PITD", m3_PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITT))
				request.WithQueryParameter("PITT", m3_PITT.Trim());
			if (m3_TEOR.HasValue)
				request.WithQueryParameter("TEOR", m3_TEOR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PTXT))
				request.WithQueryParameter("PTXT", m3_PTXT.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AUTH))
				request.WithQueryParameter("AUTH", m3_AUTH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SOMT))
				request.WithQueryParameter("SOMT", m3_SOMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OFID))
				request.WithQueryParameter("OFID", m3_OFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());

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
		/// Name AddText
		/// Description Add text block on material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PLPN">Planned order number (Required)</param>
		/// <param name="m3_LINO">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Sub number - planned order</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TXEI">External / Internal text</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_TXT3">Text line 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddTextResponse></returns>
		/// <exception cref="M3Exception<AddTextResponse>"></exception>
		public async Task<M3Response<AddTextResponse>> AddText(
			int m3_PLPN, 
			int m3_LINO, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
			string m3_TX40 = null, 
			int? m3_TXEI = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			string m3_TXT3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("LINO", m3_LINO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3_TXEI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT3))
				request.WithQueryParameter("TXT3", m3_TXT3.Trim());

			// Execute the request
			var result = await Execute<AddTextResponse>(
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
		/// Name AttestMR
		/// Description Authorization of material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PLPN">Planned purchase order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Sub number - planned purchase order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AttestMR(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AttestMR",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());

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
		/// Name ChgAuth
		/// Description Change authorizer on material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PLPN">Planned order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Sub number - planned order number</param>
		/// <param name="m3_AUTH">Authorizer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAuth(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
			string m3_AUTH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgAuth",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AUTH))
				request.WithQueryParameter("AUTH", m3_AUTH.Trim());

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
		/// Name ChgMRAdr
		/// Description Change materials requisition Address
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_PLPS">Sub number - order proposal</param>
		/// <param name="m3_CONM">Company name</param>
		/// <param name="m3_OFID">Final destination</param>
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
		public async Task<M3Response<M3Record>> ChgMRAdr(
			int m3_PLPN, 
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			int? m3_PLPS = null, 
			string m3_CONM = null, 
			string m3_OFID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgMRAdr",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CONM))
				request.WithQueryParameter("CONM", m3_CONM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OFID))
				request.WithQueryParameter("OFID", m3_OFID.Trim());
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
		/// Name ChgMRAttest
		/// Description Change material requisition by authorizer
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PLPN">Planned purchase order number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PPQT">Planned quantity (Required)</param>
		/// <param name="m3_DLDT">Planned delivery date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Sub number - planned purchase order</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_ODI1">Discount 1</param>
		/// <param name="m3_ODI2">Discount 2</param>
		/// <param name="m3_ODI3">Discount 3</param>
		/// <param name="m3_SOMT">Type of acquisition order</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_AUTX">Authorizers note</param>
		/// <param name="m3_ACRF">Accounting control object</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgMRAttest(
			int m3_PLPN, 
			string m3_WHLO, 
			decimal m3_PPQT, 
			DateTime m3_DLDT, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
			decimal? m3_PUPR = null, 
			int? m3_ODI1 = null, 
			int? m3_ODI2 = null, 
			int? m3_ODI3 = null, 
			string m3_SOMT = null, 
			string m3_ORTY = null, 
			string m3_SUNO = null, 
			string m3_BUYE = null, 
			string m3_RESP = null, 
			string m3_AUTX = null, 
			string m3_ACRF = null, 
			string m3_PROJ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgMRAttest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PPQT", m3_PPQT.ToString())
				.WithQueryParameter("DLDT", m3_DLDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3_ODI1.Value.ToString());
			if (m3_ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3_ODI2.Value.ToString());
			if (m3_ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3_ODI3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SOMT))
				request.WithQueryParameter("SOMT", m3_SOMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AUTX))
				request.WithQueryParameter("AUTX", m3_AUTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());

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
		/// Name ChgMRReq
		/// Description Change material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_PPQT">Planned Quantity (Required)</param>
		/// <param name="m3_UNMS">Basic unit of measure (Required)</param>
		/// <param name="m3_DLDT">Planned delivery date (Required)</param>
		/// <param name="m3_PURC">Requistion By (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PLPS">Sub number - order proposal</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ODI1">Discount 1</param>
		/// <param name="m3_ODI2">Discount 2</param>
		/// <param name="m3_ODI3">Discount 3</param>
		/// <param name="m3_SUNO">Supplier Number</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_ACRF">Accounting control object</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_PRCN">Procurement card number</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_IRCV">Recipient</param>
		/// <param name="m3_SITE">Supplier Item number</param>
		/// <param name="m3_PITD">PO item name</param>
		/// <param name="m3_PITT">PO item description</param>
		/// <param name="m3_TEOR">Telephone order</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PTXT">Note</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_AUTH">Authorizer</param>
		/// <param name="m3_SOMT">Type of acquisition order</param>
		/// <param name="m3_OFID">Final destination</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgMRReq(
			string m3_WHLO, 
			int m3_PLPN, 
			string m3_ITNO, 
			decimal m3_PPQT, 
			string m3_UNMS, 
			DateTime m3_DLDT, 
			string m3_PURC, 
			int? m3_CONO = null, 
			string m3_FACI = null, 
			int? m3_PLPS = null, 
			string m3_PUUN = null, 
			decimal? m3_PUPR = null, 
			string m3_CUCD = null, 
			int? m3_ODI1 = null, 
			int? m3_ODI2 = null, 
			int? m3_ODI3 = null, 
			string m3_SUNO = null, 
			string m3_BUYE = null, 
			string m3_ACRF = null, 
			string m3_COCE = null, 
			string m3_PRCN = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			int? m3_RORC = null, 
			string m3_IRCV = null, 
			string m3_SITE = null, 
			string m3_PITD = null, 
			string m3_PITT = null, 
			int? m3_TEOR = null, 
			string m3_RESP = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_FWNO = null, 
			string m3_ORTY = null, 
			string m3_PTXT = null, 
			decimal? m3_TXID = null, 
			string m3_AUTH = null, 
			string m3_SOMT = null, 
			string m3_OFID = null, 
			string m3_PROJ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgMRReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_UNMS))
				throw new ArgumentNullException("m3_UNMS");
			if (string.IsNullOrWhiteSpace(m3_PURC))
				throw new ArgumentNullException("m3_PURC");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("PPQT", m3_PPQT.ToString())
				.WithQueryParameter("UNMS", m3_UNMS.Trim())
				.WithQueryParameter("DLDT", m3_DLDT.ToM3String())
				.WithQueryParameter("PURC", m3_PURC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3_ODI1.Value.ToString());
			if (m3_ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3_ODI2.Value.ToString());
			if (m3_ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3_ODI3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRCN))
				request.WithQueryParameter("PRCN", m3_PRCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IRCV))
				request.WithQueryParameter("IRCV", m3_IRCV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITD))
				request.WithQueryParameter("PITD", m3_PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITT))
				request.WithQueryParameter("PITT", m3_PITT.Trim());
			if (m3_TEOR.HasValue)
				request.WithQueryParameter("TEOR", m3_TEOR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PTXT))
				request.WithQueryParameter("PTXT", m3_PTXT.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AUTH))
				request.WithQueryParameter("AUTH", m3_AUTH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SOMT))
				request.WithQueryParameter("SOMT", m3_SOMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OFID))
				request.WithQueryParameter("OFID", m3_OFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());

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
		/// Name DltMRReq
		/// Description Delete material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Sub number - Order proposal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltMRReq(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltMRReq",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());

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
		/// Name DltText
		/// Description Delete text block on material requisition
		/// Version Release: 11.4
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Subnumber - order proposal</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DltTextResponse></returns>
		/// <exception cref="M3Exception<DltTextResponse>"></exception>
		public async Task<M3Response<DltTextResponse>> DltText(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
			string m3_TXVR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<DltTextResponse>(
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
		/// Name EvaluateMR
		/// Description Evaluation of material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PLPN">Planned purchase order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Sub number - planned purchase order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> EvaluateMR(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/EvaluateMR",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());

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
		/// Name GetMRAdr
		/// Description Delete material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Sub number - Order proposal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMRAdrResponse></returns>
		/// <exception cref="M3Exception<GetMRAdrResponse>"></exception>
		public async Task<M3Response<GetMRAdrResponse>> GetMRAdr(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMRAdr",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());

			// Execute the request
			var result = await Execute<GetMRAdrResponse>(
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
		/// Name GetMRReq
		/// Description Retrive material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Sub number - Order proposal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMRReqResponse></returns>
		/// <exception cref="M3Exception<GetMRReqResponse>"></exception>
		public async Task<M3Response<GetMRReqResponse>> GetMRReq(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMRReq",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());

			// Execute the request
			var result = await Execute<GetMRReqResponse>(
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
		/// Name GetText
		/// Description Retrive text associated with a material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Sub number - order proposal</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTextResponse></returns>
		/// <exception cref="M3Exception<GetTextResponse>"></exception>
		public async Task<M3Response<GetTextResponse>> GetText(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetTextResponse>(
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
		/// Name LstMRAdr
		/// Description List material requisition Address
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PURC">Requisition by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMRAdrResponse></returns>
		/// <exception cref="M3Exception<LstMRAdrResponse>"></exception>
		public async Task<M3Response<LstMRAdrResponse>> LstMRAdr(
			int? m3_CONO = null, 
			string m3_PURC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMRAdr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PURC))
				request.WithQueryParameter("PURC", m3_PURC.Trim());

			// Execute the request
			var result = await Execute<LstMRAdrResponse>(
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
		/// Name LstMRAttest
		/// Description List material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_AUTH">Authorizer (Required)</param>
		/// <param name="m3_STSR">Status - Material requisition (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SOPT">Sorting option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMRAttestResponse></returns>
		/// <exception cref="M3Exception<LstMRAttestResponse>"></exception>
		public async Task<M3Response<LstMRAttestResponse>> LstMRAttest(
			string m3_AUTH, 
			string m3_STSR, 
			int? m3_CONO = null, 
			string m3_SOPT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMRAttest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AUTH))
				throw new ArgumentNullException("m3_AUTH");
			if (string.IsNullOrWhiteSpace(m3_STSR))
				throw new ArgumentNullException("m3_STSR");

			// Set mandatory parameters
			request
				.WithQueryParameter("AUTH", m3_AUTH.Trim())
				.WithQueryParameter("STSR", m3_STSR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SOPT))
				request.WithQueryParameter("SOPT", m3_SOPT.Trim());

			// Execute the request
			var result = await Execute<LstMRAttestResponse>(
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
		/// Name LstMRReq
		/// Description List material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PURC">Requisition by (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STSR">Status - Material requisition</param>
		/// <param name="m3_SOPT">Sorting option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMRReqResponse></returns>
		/// <exception cref="M3Exception<LstMRReqResponse>"></exception>
		public async Task<M3Response<LstMRReqResponse>> LstMRReq(
			string m3_PURC, 
			int? m3_CONO = null, 
			string m3_STSR = null, 
			string m3_SOPT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMRReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PURC))
				throw new ArgumentNullException("m3_PURC");

			// Set mandatory parameters
			request
				.WithQueryParameter("PURC", m3_PURC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STSR))
				request.WithQueryParameter("STSR", m3_STSR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SOPT))
				request.WithQueryParameter("SOPT", m3_SOPT.Trim());

			// Execute the request
			var result = await Execute<LstMRReqResponse>(
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
		/// Name LstText
		/// Description Retrive text associated with a material requisition
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_PLPN">Order proposal number (Required)</param>
		/// <param name="m3_PLPS">Sub number - order proposal (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTextResponse></returns>
		/// <exception cref="M3Exception<LstTextResponse>"></exception>
		public async Task<M3Response<LstTextResponse>> LstText(
			int m3_PLPN, 
			int m3_PLPS, 
			string m3_LNCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PLPS", m3_PLPS.ToString())
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstTextResponse>(
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
		/// Name RejectMR
		/// Description Rejection of material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PLPN">Planned purchase order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Sub number - planned purchase order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RejectMR(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RejectMR",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());

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
