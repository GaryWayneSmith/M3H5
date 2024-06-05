/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMRAdr
		/// Description Add materials requisition Address
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PLPN">Order proposal number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3PLPS">Sub number - order proposal</param>
		/// <param name="m3CONM">Company name</param>
		/// <param name="m3OFID">Final destination</param>
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
		public async Task<M3Response<M3Record>> AddMRAdr(
			int m3PLPN, 
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			int? m3PLPS = null, 
			string m3CONM = null, 
			string m3OFID = null, 
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMRAdr",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CONM))
				request.WithQueryParameter("CONM", m3CONM.Trim());
			if (!string.IsNullOrWhiteSpace(m3OFID))
				request.WithQueryParameter("OFID", m3OFID.Trim());
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
		/// Name AddMRReq
		/// Description Add material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PLPN">Order proposal number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3PPQT">Planned Quantity (Required)</param>
		/// <param name="m3UNMS">Basic unit of measure (Required)</param>
		/// <param name="m3DLDT">Planned delivery date (Required)</param>
		/// <param name="m3PURC">Requistion By (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PLPS">Sub number - order proposal</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ODI1">Discount 1</param>
		/// <param name="m3ODI2">Discount 2</param>
		/// <param name="m3ODI3">Discount 3</param>
		/// <param name="m3SUNO">Supplier Number</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3ACRF">Accounting control object</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="m3PRCN">Procurement card number</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3IRCV">Recipient</param>
		/// <param name="m3SITE">Supplier Item number</param>
		/// <param name="m3PITD">PO item name</param>
		/// <param name="m3PITT">PO item description</param>
		/// <param name="m3TEOR">Telephone order</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PTXT">Note</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3AUTH">Authorizer</param>
		/// <param name="m3SOMT">Type of acquisition order</param>
		/// <param name="m3OFID">Final destination</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMRReq(
			string m3WHLO, 
			int m3PLPN, 
			string m3ITNO, 
			decimal m3PPQT, 
			string m3UNMS, 
			DateTime m3DLDT, 
			string m3PURC, 
			int? m3CONO = null, 
			string m3FACI = null, 
			int? m3PLPS = null, 
			string m3PUUN = null, 
			decimal? m3PUPR = null, 
			string m3CUCD = null, 
			int? m3ODI1 = null, 
			int? m3ODI2 = null, 
			int? m3ODI3 = null, 
			string m3SUNO = null, 
			string m3BUYE = null, 
			string m3ACRF = null, 
			string m3COCE = null, 
			string m3PRCN = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			int? m3RORC = null, 
			string m3IRCV = null, 
			string m3SITE = null, 
			string m3PITD = null, 
			string m3PITT = null, 
			int? m3TEOR = null, 
			string m3RESP = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3FWNO = null, 
			string m3ORTY = null, 
			string m3PTXT = null, 
			decimal? m3TXID = null, 
			string m3AUTH = null, 
			string m3SOMT = null, 
			string m3OFID = null, 
			string m3PROJ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMRReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3UNMS))
				throw new ArgumentNullException(nameof(m3UNMS));
			if (string.IsNullOrWhiteSpace(m3PURC))
				throw new ArgumentNullException(nameof(m3PURC));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("PPQT", m3PPQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("UNMS", m3UNMS.Trim())
				.WithQueryParameter("DLDT", m3DLDT.ToM3String())
				.WithQueryParameter("PURC", m3PURC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3ODI1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3ODI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3ODI3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRCN))
				request.WithQueryParameter("PRCN", m3PRCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IRCV))
				request.WithQueryParameter("IRCV", m3IRCV.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITD))
				request.WithQueryParameter("PITD", m3PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITT))
				request.WithQueryParameter("PITT", m3PITT.Trim());
			if (m3TEOR.HasValue)
				request.WithQueryParameter("TEOR", m3TEOR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PTXT))
				request.WithQueryParameter("PTXT", m3PTXT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AUTH))
				request.WithQueryParameter("AUTH", m3AUTH.Trim());
			if (!string.IsNullOrWhiteSpace(m3SOMT))
				request.WithQueryParameter("SOMT", m3SOMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OFID))
				request.WithQueryParameter("OFID", m3OFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());

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
		/// Name AddText
		/// Description Add text block on material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PLPN">Planned order number (Required)</param>
		/// <param name="m3LINO">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Sub number - planned order</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TXEI">External / Internal text</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3TXT3">Text line 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddTextResponse></returns>
		/// <exception cref="M3Exception<AddTextResponse>"></exception>
		public async Task<M3Response<AddTextResponse>> AddText(
			int m3PLPN, 
			int m3LINO, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
			string m3TXVR = null, 
			string m3LNCD = null, 
			string m3TX40 = null, 
			int? m3TXEI = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			string m3TXT3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LINO", m3LINO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3TXEI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT3))
				request.WithQueryParameter("TXT3", m3TXT3.Trim());

			// Execute the request
			var result = await Execute<AddTextResponse>(
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
		/// Name AttestMR
		/// Description Authorization of material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PLPN">Planned purchase order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Sub number - planned purchase order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AttestMR(
			int m3PLPN, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AttestMR",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgAuth
		/// Description Change authorizer on material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PLPN">Planned order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Sub number - planned order number</param>
		/// <param name="m3AUTH">Authorizer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAuth(
			int m3PLPN, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
			string m3AUTH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgAuth",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AUTH))
				request.WithQueryParameter("AUTH", m3AUTH.Trim());

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
		/// Name ChgMRAdr
		/// Description Change materials requisition Address
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PLPN">Order proposal number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3PLPS">Sub number - order proposal</param>
		/// <param name="m3CONM">Company name</param>
		/// <param name="m3OFID">Final destination</param>
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
		public async Task<M3Response<M3Record>> ChgMRAdr(
			int m3PLPN, 
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			int? m3PLPS = null, 
			string m3CONM = null, 
			string m3OFID = null, 
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgMRAdr",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CONM))
				request.WithQueryParameter("CONM", m3CONM.Trim());
			if (!string.IsNullOrWhiteSpace(m3OFID))
				request.WithQueryParameter("OFID", m3OFID.Trim());
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
		/// Name ChgMRAttest
		/// Description Change material requisition by authorizer
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PLPN">Planned purchase order number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PPQT">Planned quantity (Required)</param>
		/// <param name="m3DLDT">Planned delivery date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Sub number - planned purchase order</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3ODI1">Discount 1</param>
		/// <param name="m3ODI2">Discount 2</param>
		/// <param name="m3ODI3">Discount 3</param>
		/// <param name="m3SOMT">Type of acquisition order</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3AUTX">Authorizers note</param>
		/// <param name="m3ACRF">Accounting control object</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgMRAttest(
			int m3PLPN, 
			string m3WHLO, 
			decimal m3PPQT, 
			DateTime m3DLDT, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
			decimal? m3PUPR = null, 
			int? m3ODI1 = null, 
			int? m3ODI2 = null, 
			int? m3ODI3 = null, 
			string m3SOMT = null, 
			string m3ORTY = null, 
			string m3SUNO = null, 
			string m3BUYE = null, 
			string m3RESP = null, 
			string m3AUTX = null, 
			string m3ACRF = null, 
			string m3PROJ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgMRAttest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PPQT", m3PPQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DLDT", m3DLDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3ODI1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3ODI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3ODI3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SOMT))
				request.WithQueryParameter("SOMT", m3SOMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AUTX))
				request.WithQueryParameter("AUTX", m3AUTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());

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
		/// Name ChgMRReq
		/// Description Change material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PLPN">Order proposal number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3PPQT">Planned Quantity (Required)</param>
		/// <param name="m3UNMS">Basic unit of measure (Required)</param>
		/// <param name="m3DLDT">Planned delivery date (Required)</param>
		/// <param name="m3PURC">Requistion By (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PLPS">Sub number - order proposal</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ODI1">Discount 1</param>
		/// <param name="m3ODI2">Discount 2</param>
		/// <param name="m3ODI3">Discount 3</param>
		/// <param name="m3SUNO">Supplier Number</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3ACRF">Accounting control object</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="m3PRCN">Procurement card number</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3IRCV">Recipient</param>
		/// <param name="m3SITE">Supplier Item number</param>
		/// <param name="m3PITD">PO item name</param>
		/// <param name="m3PITT">PO item description</param>
		/// <param name="m3TEOR">Telephone order</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PTXT">Note</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3AUTH">Authorizer</param>
		/// <param name="m3SOMT">Type of acquisition order</param>
		/// <param name="m3OFID">Final destination</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgMRReq(
			string m3WHLO, 
			int m3PLPN, 
			string m3ITNO, 
			decimal m3PPQT, 
			string m3UNMS, 
			DateTime m3DLDT, 
			string m3PURC, 
			int? m3CONO = null, 
			string m3FACI = null, 
			int? m3PLPS = null, 
			string m3PUUN = null, 
			decimal? m3PUPR = null, 
			string m3CUCD = null, 
			int? m3ODI1 = null, 
			int? m3ODI2 = null, 
			int? m3ODI3 = null, 
			string m3SUNO = null, 
			string m3BUYE = null, 
			string m3ACRF = null, 
			string m3COCE = null, 
			string m3PRCN = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			int? m3RORC = null, 
			string m3IRCV = null, 
			string m3SITE = null, 
			string m3PITD = null, 
			string m3PITT = null, 
			int? m3TEOR = null, 
			string m3RESP = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3FWNO = null, 
			string m3ORTY = null, 
			string m3PTXT = null, 
			decimal? m3TXID = null, 
			string m3AUTH = null, 
			string m3SOMT = null, 
			string m3OFID = null, 
			string m3PROJ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgMRReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3UNMS))
				throw new ArgumentNullException(nameof(m3UNMS));
			if (string.IsNullOrWhiteSpace(m3PURC))
				throw new ArgumentNullException(nameof(m3PURC));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("PPQT", m3PPQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("UNMS", m3UNMS.Trim())
				.WithQueryParameter("DLDT", m3DLDT.ToM3String())
				.WithQueryParameter("PURC", m3PURC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3ODI1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3ODI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3ODI3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRCN))
				request.WithQueryParameter("PRCN", m3PRCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IRCV))
				request.WithQueryParameter("IRCV", m3IRCV.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITD))
				request.WithQueryParameter("PITD", m3PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITT))
				request.WithQueryParameter("PITT", m3PITT.Trim());
			if (m3TEOR.HasValue)
				request.WithQueryParameter("TEOR", m3TEOR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PTXT))
				request.WithQueryParameter("PTXT", m3PTXT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AUTH))
				request.WithQueryParameter("AUTH", m3AUTH.Trim());
			if (!string.IsNullOrWhiteSpace(m3SOMT))
				request.WithQueryParameter("SOMT", m3SOMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OFID))
				request.WithQueryParameter("OFID", m3OFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());

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
		/// Name DltMRReq
		/// Description Delete material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PLPN">Order proposal number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Sub number - Order proposal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltMRReq(
			int m3PLPN, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltMRReq",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltText
		/// Description Delete text block on material requisition
		/// Version Release: 11.4
		/// </summary>
		/// <param name="m3PLPN">Order proposal number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Subnumber - order proposal</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DltTextResponse></returns>
		/// <exception cref="M3Exception<DltTextResponse>"></exception>
		public async Task<M3Response<DltTextResponse>> DltText(
			int m3PLPN, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
			string m3TXVR = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<DltTextResponse>(
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
		/// Name EvaluateMR
		/// Description Evaluation of material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PLPN">Planned purchase order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Sub number - planned purchase order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> EvaluateMR(
			int m3PLPN, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/EvaluateMR",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetMRAdr
		/// Description Delete material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PLPN">Order proposal number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Sub number - Order proposal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMRAdrResponse></returns>
		/// <exception cref="M3Exception<GetMRAdrResponse>"></exception>
		public async Task<M3Response<GetMRAdrResponse>> GetMRAdr(
			int m3PLPN, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMRAdr",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMRAdrResponse>(
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
		/// Name GetMRReq
		/// Description Retrive material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PLPN">Order proposal number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Sub number - Order proposal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMRReqResponse></returns>
		/// <exception cref="M3Exception<GetMRReqResponse>"></exception>
		public async Task<M3Response<GetMRReqResponse>> GetMRReq(
			int m3PLPN, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMRReq",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMRReqResponse>(
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
		/// Name GetText
		/// Description Retrive text associated with a material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PLPN">Order proposal number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Sub number - order proposal</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTextResponse></returns>
		/// <exception cref="M3Exception<GetTextResponse>"></exception>
		public async Task<M3Response<GetTextResponse>> GetText(
			int m3PLPN, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetTextResponse>(
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
		/// Name LstMRAdr
		/// Description List material requisition Address
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PURC">Requisition by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMRAdrResponse></returns>
		/// <exception cref="M3Exception<LstMRAdrResponse>"></exception>
		public async Task<M3Response<LstMRAdrResponse>> LstMRAdr(
			int? m3CONO = null, 
			string m3PURC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMRAdr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PURC))
				request.WithQueryParameter("PURC", m3PURC.Trim());

			// Execute the request
			var result = await Execute<LstMRAdrResponse>(
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
		/// Name LstMRAttest
		/// Description List material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3AUTH">Authorizer (Required)</param>
		/// <param name="m3STSR">Status - Material requisition (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SOPT">Sorting option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMRAttestResponse></returns>
		/// <exception cref="M3Exception<LstMRAttestResponse>"></exception>
		public async Task<M3Response<LstMRAttestResponse>> LstMRAttest(
			string m3AUTH, 
			string m3STSR, 
			int? m3CONO = null, 
			string m3SOPT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMRAttest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AUTH))
				throw new ArgumentNullException(nameof(m3AUTH));
			if (string.IsNullOrWhiteSpace(m3STSR))
				throw new ArgumentNullException(nameof(m3STSR));

			// Set mandatory parameters
			request
				.WithQueryParameter("AUTH", m3AUTH.Trim())
				.WithQueryParameter("STSR", m3STSR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SOPT))
				request.WithQueryParameter("SOPT", m3SOPT.Trim());

			// Execute the request
			var result = await Execute<LstMRAttestResponse>(
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
		/// Name LstMRReq
		/// Description List material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PURC">Requisition by (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STSR">Status - Material requisition</param>
		/// <param name="m3SOPT">Sorting option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMRReqResponse></returns>
		/// <exception cref="M3Exception<LstMRReqResponse>"></exception>
		public async Task<M3Response<LstMRReqResponse>> LstMRReq(
			string m3PURC, 
			int? m3CONO = null, 
			string m3STSR = null, 
			string m3SOPT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMRReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PURC))
				throw new ArgumentNullException(nameof(m3PURC));

			// Set mandatory parameters
			request
				.WithQueryParameter("PURC", m3PURC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STSR))
				request.WithQueryParameter("STSR", m3STSR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SOPT))
				request.WithQueryParameter("SOPT", m3SOPT.Trim());

			// Execute the request
			var result = await Execute<LstMRReqResponse>(
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
		/// Name LstText
		/// Description Retrive text associated with a material requisition
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3PLPN">Order proposal number (Required)</param>
		/// <param name="m3PLPS">Sub number - order proposal (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTextResponse></returns>
		/// <exception cref="M3Exception<LstTextResponse>"></exception>
		public async Task<M3Response<LstTextResponse>> LstText(
			int m3PLPN, 
			int m3PLPS, 
			string m3LNCD, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLPS", m3PLPS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstTextResponse>(
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
		/// Name RejectMR
		/// Description Rejection of material requisition
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3PLPN">Planned purchase order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Sub number - planned purchase order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RejectMR(
			int m3PLPN, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RejectMR",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));

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
