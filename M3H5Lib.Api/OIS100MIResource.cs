/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.OIS100MI;
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
	/// Name: OIS100MI
	/// Component Name: CustomerOrder
	/// Description: Customer order interface
	/// Version Release: 5eaE
	///</summary>
	public partial class OIS100MIResource : M3BaseResourceEndpoint
	{
		public OIS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS100MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBatchAddress
		/// Description Add batch order address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ADID">Address id</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUA1">Address line 1</param>
		/// <param name="m3CUA2">Address line 2</param>
		/// <param name="m3CUA3">Address line 3</param>
		/// <param name="m3CUA4">Address line 4</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3PHNO">Phone number</param>
		/// <param name="m3TFNO">Fax number</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3VRNO">VAT Registration number</param>
		/// <param name="m3EDES">Place of load - NOT IN USE (2004.06.10)</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3ULZO">Unloading zone</param>
		/// <param name="m3TAXC">Tax code</param>
		/// <param name="m3ECAR">Area/State</param>
		/// <param name="m3HAFE">Harbor or Airport</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3DSTX">Description,delivery specification</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TEL2">Terms text</param>
		/// <param name="m3EDE2">Place of load</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3PHN2">Phone number 2</param>
		/// <param name="m3TFN2">Facsimile transmission number 2</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3ADVI">Ship-via address</param>
		/// <param name="m3SPLE">Standard point location code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchAddress(
			string m3ORNO, 
			int m3ADRT, 
			int? m3CONO = null, 
			string m3ADID = null, 
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3PONO = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3CSCD = null, 
			string m3VRNO = null, 
			string m3EDES = null, 
			string m3ROUT = null, 
			int? m3RODN = null, 
			string m3ULZO = null, 
			string m3TAXC = null, 
			string m3ECAR = null, 
			string m3HAFE = null, 
			string m3YREF = null, 
			string m3DLSP = null, 
			string m3DSTX = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEL2 = null, 
			string m3EDE2 = null, 
			string m3TOWN = null, 
			string m3PHN2 = null, 
			string m3TFN2 = null, 
			string m3FRCO = null, 
			string m3RASN = null, 
			string m3ADVI = null, 
			string m3SPLE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (m3RODN.HasValue)
				request.WithQueryParameter("RODN", m3RODN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ULZO))
				request.WithQueryParameter("ULZO", m3ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSTX))
				request.WithQueryParameter("DSTX", m3DSTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL2))
				request.WithQueryParameter("TEL2", m3TEL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDE2))
				request.WithQueryParameter("EDE2", m3EDE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFN2))
				request.WithQueryParameter("TFN2", m3TFN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADVI))
				request.WithQueryParameter("ADVI", m3ADVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPLE))
				request.WithQueryParameter("SPLE", m3SPLE.Trim());

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
		/// Name AddBatchHead
		/// Description Create new batch order head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3ORTP">Order type</param>
		/// <param name="m3RLDT">Requested delivery date</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3AGNT">Agent</param>
		/// <param name="m3SMCD">Salesman</param>
		/// <param name="m3MODL">Method of delivery</param>
		/// <param name="m3TEDL">Term of delivery</param>
		/// <param name="m3YREF">Reference at customer</param>
		/// <param name="m3PROJ">Project</param>
		/// <param name="m3OTBA">Order discount amount</param>
		/// <param name="m3TEPY">Terms of payment</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3ADID">Delivery address id</param>
		/// <param name="m3CUCD">Currency code</param>
		/// <param name="m3OREF">Our referens</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3TEL2">Delivery terms text</param>
		/// <param name="m3CUDT">Customers purchase order date</param>
		/// <param name="m3INRC">Invoice recipient</param>
		/// <param name="m3ORDT">Order date</param>
		/// <param name="m3RLHM">Requested delivery time</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3TIZO">Time zone</param>
		/// <param name="m3AGNO">Blanket agreement number</param>
		/// <param name="m3PRO2">Project</param>
		/// <param name="m3RLDZ">Requested delivery date</param>
		/// <param name="m3RLHZ">Requested delivery time</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3DSTX">Description of delivery specification</param>
		/// <param name="m3TECD">Cash discount term</param>
		/// <param name="m3PLTB">Price list table</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3WCON">Contact method</param>
		/// <param name="m3ID01">Message identity 1</param>
		/// <param name="m3ID02">Message identity 2</param>
		/// <param name="m3OTDP">Total discount percentage</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3DICD">Discount origin</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3CHL1">Business chain - level 1</param>
		/// <param name="m3CHL2">Business chain - level 2</param>
		/// <param name="m3CHL3">Business chain - level 3</param>
		/// <param name="m3CHL4">Business chain - level 4</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3NREF">Reference number</param>
		/// <param name="m3TRDP">3rd party provider ID</param>
		/// <param name="m3IPAD">IP address</param>
		/// <param name="m3ESOV">e-Sales order value</param>
		/// <param name="m3EXCD">Service charge</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3FRE1">Statistics identity 1 customer</param>
		/// <param name="m3FDED">First delivery date</param>
		/// <param name="m3LDED">Last delivery date</param>
		/// <param name="m3BREC">Recipient agreement type 9 - bonus</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3OHEA">Only header</param>
		/// <param name="m3CUCH">Customer channel id</param>
		/// <param name="m3CCAC">Activity</param>
		/// <param name="m3DECU">Delivery customer</param>
		/// <param name="m3GCAC">Supplier ID</param>
		/// <param name="m3PYRE">Request reference number</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3OPRI">Priority</param>
		/// <param name="m3SPLM">Supply model</param>
		/// <param name="m3CHSY">Line charge model</param>
		/// <param name="m3OIVR">Original invoice reference</param>
		/// <param name="m3OYEA">Original year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchHeadResponse></returns>
		/// <exception cref="M3Exception<AddBatchHeadResponse>"></exception>
		public async Task<M3Response<AddBatchHeadResponse>> AddBatchHead(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			string m3ORTP = null, 
			DateTime? m3RLDT = null, 
			string m3FACI = null, 
			string m3CUOR = null, 
			string m3AGNT = null, 
			string m3SMCD = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3YREF = null, 
			string m3PROJ = null, 
			string m3OTBA = null, 
			string m3TEPY = null, 
			string m3PYNO = null, 
			string m3ADID = null, 
			string m3CUCD = null, 
			string m3OREF = null, 
			string m3OFNO = null, 
			string m3TEL2 = null, 
			DateTime? m3CUDT = null, 
			string m3INRC = null, 
			DateTime? m3ORDT = null, 
			int? m3RLHM = null, 
			string m3TEPA = null, 
			string m3TIZO = null, 
			string m3AGNO = null, 
			string m3PRO2 = null, 
			DateTime? m3RLDZ = null, 
			int? m3RLHZ = null, 
			string m3DLSP = null, 
			string m3DSTX = null, 
			string m3TECD = null, 
			string m3PLTB = null, 
			string m3DISY = null, 
			string m3WCON = null, 
			string m3ID01 = null, 
			string m3ID02 = null, 
			string m3OTDP = null, 
			string m3CRTP = null, 
			int? m3DICD = null, 
			string m3ELNO = null, 
			string m3CHL1 = null, 
			string m3CHL2 = null, 
			string m3CHL3 = null, 
			string m3CHL4 = null, 
			string m3WHLO = null, 
			string m3NREF = null, 
			string m3TRDP = null, 
			string m3IPAD = null, 
			int? m3ESOV = null, 
			string m3EXCD = null, 
			string m3PYCD = null, 
			string m3FRE1 = null, 
			DateTime? m3FDED = null, 
			DateTime? m3LDED = null, 
			string m3BREC = null, 
			string m3RESP = null, 
			int? m3OHEA = null, 
			string m3CUCH = null, 
			string m3CCAC = null, 
			string m3DECU = null, 
			string m3GCAC = null, 
			string m3PYRE = null, 
			string m3BKID = null, 
			int? m3OPRI = null, 
			string m3SPLM = null, 
			string m3CHSY = null, 
			string m3OIVR = null, 
			int? m3OYEA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (m3RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3RLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNT))
				request.WithQueryParameter("AGNT", m3AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTBA))
				request.WithQueryParameter("OTBA", m3OTBA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL2))
				request.WithQueryParameter("TEL2", m3TEL2.Trim());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3INRC))
				request.WithQueryParameter("INRC", m3INRC.Trim());
			if (m3ORDT.HasValue)
				request.WithQueryParameter("ORDT", m3ORDT.Value.ToM3String());
			if (m3RLHM.HasValue)
				request.WithQueryParameter("RLHM", m3RLHM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIZO))
				request.WithQueryParameter("TIZO", m3TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNO))
				request.WithQueryParameter("AGNO", m3AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRO2))
				request.WithQueryParameter("PRO2", m3PRO2.Trim());
			if (m3RLDZ.HasValue)
				request.WithQueryParameter("RLDZ", m3RLDZ.Value.ToM3String());
			if (m3RLHZ.HasValue)
				request.WithQueryParameter("RLHZ", m3RLHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSTX))
				request.WithQueryParameter("DSTX", m3DSTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECD))
				request.WithQueryParameter("TECD", m3TECD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTB))
				request.WithQueryParameter("PLTB", m3PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (!string.IsNullOrWhiteSpace(m3WCON))
				request.WithQueryParameter("WCON", m3WCON.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID01))
				request.WithQueryParameter("ID01", m3ID01.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID02))
				request.WithQueryParameter("ID02", m3ID02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTDP))
				request.WithQueryParameter("OTDP", m3OTDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRTP))
				request.WithQueryParameter("CRTP", m3CRTP.Trim());
			if (m3DICD.HasValue)
				request.WithQueryParameter("DICD", m3DICD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL1))
				request.WithQueryParameter("CHL1", m3CHL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL2))
				request.WithQueryParameter("CHL2", m3CHL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL3))
				request.WithQueryParameter("CHL3", m3CHL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL4))
				request.WithQueryParameter("CHL4", m3CHL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NREF))
				request.WithQueryParameter("NREF", m3NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRDP))
				request.WithQueryParameter("TRDP", m3TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3IPAD))
				request.WithQueryParameter("IPAD", m3IPAD.Trim());
			if (m3ESOV.HasValue)
				request.WithQueryParameter("ESOV", m3ESOV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXCD))
				request.WithQueryParameter("EXCD", m3EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE1))
				request.WithQueryParameter("FRE1", m3FRE1.Trim());
			if (m3FDED.HasValue)
				request.WithQueryParameter("FDED", m3FDED.Value.ToM3String());
			if (m3LDED.HasValue)
				request.WithQueryParameter("LDED", m3LDED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3BREC))
				request.WithQueryParameter("BREC", m3BREC.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3OHEA.HasValue)
				request.WithQueryParameter("OHEA", m3OHEA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCH))
				request.WithQueryParameter("CUCH", m3CUCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCAC))
				request.WithQueryParameter("CCAC", m3CCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3DECU))
				request.WithQueryParameter("DECU", m3DECU.Trim());
			if (!string.IsNullOrWhiteSpace(m3GCAC))
				request.WithQueryParameter("GCAC", m3GCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYRE))
				request.WithQueryParameter("PYRE", m3PYRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (m3OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3OPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPLM))
				request.WithQueryParameter("SPLM", m3SPLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHSY))
				request.WithQueryParameter("CHSY", m3CHSY.Trim());
			if (!string.IsNullOrWhiteSpace(m3OIVR))
				request.WithQueryParameter("OIVR", m3OIVR.Trim());
			if (m3OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3OYEA.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddBatchHeadResponse>(
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
		/// Name AddBatchHeadChg
		/// Description Add charge to batch order head
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3CRID">Charge (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CRAM">Charge amount</param>
		/// <param name="m3CRFA">Calcualtion factor</param>
		/// <param name="m3CRD0">Description</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchHeadChg(
			string m3ORNO, 
			string m3CRID, 
			int? m3CONO = null, 
			string m3CRAM = null, 
			string m3CRFA = null, 
			string m3CRD0 = null, 
			string m3TAXC = null, 
			string m3CUCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchHeadChg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3CRID))
				throw new ArgumentNullException(nameof(m3CRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("CRID", m3CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CRAM))
				request.WithQueryParameter("CRAM", m3CRAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRFA))
				request.WithQueryParameter("CRFA", m3CRFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRD0))
				request.WithQueryParameter("CRD0", m3CRD0.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());

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
		/// Name AddBatchLine
		/// Description Add batch order line
		/// Version Release: 5eaB
		/// </summary>
		/// <param name="m3ORNO">Temporary order number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORQT">Ordered quantity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3JDCD">Joint delivery code</param>
		/// <param name="m3CUPO">Customers order number</param>
		/// <param name="m3SAPR">Salesprice</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3DIA2">Discount amount 2</param>
		/// <param name="m3DIA3">Discount amount 3</param>
		/// <param name="m3DIA4">Discount amount 4</param>
		/// <param name="m3DIA5">Discount amount 5</param>
		/// <param name="m3DIA6">Discount amount 6</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3DLSX">Delivery specification text</param>
		/// <param name="m3CFXX">Old CFIN</param>
		/// <param name="m3ECVS">Simulations number</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3CODT">Confirmed date of delivery</param>
		/// <param name="m3ITDS">Item description</param>
		/// <param name="m3DIP1">Discount percent 1</param>
		/// <param name="m3DIP2">Discount percent 2</param>
		/// <param name="m3DIP3">Discount percent 3</param>
		/// <param name="m3DIP4">Discount percent 4</param>
		/// <param name="m3DIP5">Discount percent 5</param>
		/// <param name="m3DIP6">Discount percent 6</param>
		/// <param name="m3ALWT">Alias qualifier</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3AGNO">Blanket agreement number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUPA">Customers packaging identity</param>
		/// <param name="m3DWHM">Requested delivery time</param>
		/// <param name="m3D1QT">Standard quantity</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3SPUN">Sales price unit of measure</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3EDFP">EDIFACT price</param>
		/// <param name="m3DWDZ">Requested delivery date</param>
		/// <param name="m3DWHZ">Requested delivery time</param>
		/// <param name="m3COHM">Confirmed delivery time</param>
		/// <param name="m3CODZ">Confirmed delivery date</param>
		/// <param name="m3COHZ">Confirmed delivery time</param>
		/// <param name="m3HDPR">Main product</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3CUSX">Line suffix</param>
		/// <param name="m3DIC1">Status - discount</param>
		/// <param name="m3DIC2">Status - discount</param>
		/// <param name="m3DIC3">Status - discount</param>
		/// <param name="m3DIC4">Status - discount</param>
		/// <param name="m3DIC5">Status - discount</param>
		/// <param name="m3DIC6">Status - discount</param>
		/// <param name="m3CMNO">Sales campaign</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3TEDS">Description 1</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3BANO">Batch no</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3PRHL">Product number highest level</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3GWTP">Granted warranty type</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3PRHW">Product number highest level</param>
		/// <param name="m3SERW">Serial number</param>
		/// <param name="m3PWNR">Order line number</param>
		/// <param name="m3PWSX">Line suffix</param>
		/// <param name="m3EWST">Extended warranty start</param>
		/// <param name="m3DANR">Default attribute number</param>
		/// <param name="m3TECN">Tax exemption contract number</param>
		/// <param name="m3INAP">Industry Application</param>
		/// <param name="m3DRDN">Demand order number</param>
		/// <param name="m3DRDL">Demand order line</param>
		/// <param name="m3DRDX">Line suffix</param>
		/// <param name="m3PIDE">Promotion</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3LTYP">Line type</param>
		/// <param name="m3EXH2">External order number</param>
		/// <param name="m3EXC2">External configuration number</param>
		/// <param name="m3MCHP">Price change indicator</param>
		/// <param name="m3EXHE">External order number</param>
		/// <param name="m3EXCN">External configuration number</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchLineResponse></returns>
		/// <exception cref="M3Exception<AddBatchLineResponse>"></exception>
		public async Task<M3Response<AddBatchLineResponse>> AddBatchLine(
			string m3ORNO, 
			string m3ITNO, 
			int? m3CONO = null, 
			string m3ORQT = null, 
			string m3WHLO = null, 
			DateTime? m3DWDT = null, 
			string m3JDCD = null, 
			string m3CUPO = null, 
			string m3SAPR = null, 
			string m3DIA1 = null, 
			string m3DIA2 = null, 
			string m3DIA3 = null, 
			string m3DIA4 = null, 
			string m3DIA5 = null, 
			string m3DIA6 = null, 
			string m3DLSP = null, 
			string m3DLSX = null, 
			int? m3CFXX = null, 
			int? m3ECVS = null, 
			string m3ALUN = null, 
			DateTime? m3CODT = null, 
			string m3ITDS = null, 
			int? m3DIP1 = null, 
			int? m3DIP2 = null, 
			int? m3DIP3 = null, 
			int? m3DIP4 = null, 
			int? m3DIP5 = null, 
			int? m3DIP6 = null, 
			int? m3ALWT = null, 
			string m3ALWQ = null, 
			string m3AGNO = null, 
			string m3CAMU = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3CUOR = null, 
			string m3CUPA = null, 
			int? m3DWHM = null, 
			decimal? m3D1QT = null, 
			string m3PACT = null, 
			string m3POPN = null, 
			int? m3SACD = null, 
			string m3SPUN = null, 
			string m3TEPA = null, 
			decimal? m3EDFP = null, 
			DateTime? m3DWDZ = null, 
			int? m3DWHZ = null, 
			int? m3COHM = null, 
			DateTime? m3CODZ = null, 
			int? m3COHZ = null, 
			string m3HDPR = null, 
			string m3ADID = null, 
			int? m3CUSX = null, 
			int? m3DIC1 = null, 
			int? m3DIC2 = null, 
			int? m3DIC3 = null, 
			int? m3DIC4 = null, 
			int? m3DIC5 = null, 
			int? m3DIC6 = null, 
			string m3CMNO = null, 
			string m3RSCD = null, 
			string m3TEDS = null, 
			long? m3CFIN = null, 
			string m3BANO = null, 
			string m3WHSL = null, 
			string m3PRHL = null, 
			string m3SERN = null, 
			string m3CTNO = null, 
			string m3CFGL = null, 
			string m3GWTP = null, 
			string m3WATP = null, 
			string m3PRHW = null, 
			string m3SERW = null, 
			int? m3PWNR = null, 
			int? m3PWSX = null, 
			int? m3EWST = null, 
			decimal? m3DANR = null, 
			string m3TECN = null, 
			string m3INAP = null, 
			string m3DRDN = null, 
			int? m3DRDL = null, 
			int? m3DRDX = null, 
			string m3PIDE = null, 
			string m3TEPY = null, 
			string m3LTYP = null, 
			string m3EXH2 = null, 
			string m3EXC2 = null, 
			int? m3MCHP = null, 
			string m3EXHE = null, 
			string m3EXCN = null, 
			string m3MODL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORQT))
				request.WithQueryParameter("ORQT", m3ORQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3JDCD))
				request.WithQueryParameter("JDCD", m3JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPO))
				request.WithQueryParameter("CUPO", m3CUPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAPR))
				request.WithQueryParameter("SAPR", m3SAPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA1))
				request.WithQueryParameter("DIA1", m3DIA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA2))
				request.WithQueryParameter("DIA2", m3DIA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA3))
				request.WithQueryParameter("DIA3", m3DIA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA4))
				request.WithQueryParameter("DIA4", m3DIA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA5))
				request.WithQueryParameter("DIA5", m3DIA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA6))
				request.WithQueryParameter("DIA6", m3DIA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSX))
				request.WithQueryParameter("DLSX", m3DLSX.Trim());
			if (m3CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3CFXX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3ECVS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3CODT.HasValue)
				request.WithQueryParameter("CODT", m3CODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (m3DIP1.HasValue)
				request.WithQueryParameter("DIP1", m3DIP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP2.HasValue)
				request.WithQueryParameter("DIP2", m3DIP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3DIP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP4.HasValue)
				request.WithQueryParameter("DIP4", m3DIP4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP5.HasValue)
				request.WithQueryParameter("DIP5", m3DIP5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP6.HasValue)
				request.WithQueryParameter("DIP6", m3DIP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNO))
				request.WithQueryParameter("AGNO", m3AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (m3DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3DWHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPUN))
				request.WithQueryParameter("SPUN", m3SPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (m3EDFP.HasValue)
				request.WithQueryParameter("EDFP", m3EDFP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DWDZ.HasValue)
				request.WithQueryParameter("DWDZ", m3DWDZ.Value.ToM3String());
			if (m3DWHZ.HasValue)
				request.WithQueryParameter("DWHZ", m3DWHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COHM.HasValue)
				request.WithQueryParameter("COHM", m3COHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CODZ.HasValue)
				request.WithQueryParameter("CODZ", m3CODZ.Value.ToM3String());
			if (m3COHZ.HasValue)
				request.WithQueryParameter("COHZ", m3COHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3HDPR))
				request.WithQueryParameter("HDPR", m3HDPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3CUSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC1.HasValue)
				request.WithQueryParameter("DIC1", m3DIC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC2.HasValue)
				request.WithQueryParameter("DIC2", m3DIC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC3.HasValue)
				request.WithQueryParameter("DIC3", m3DIC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC4.HasValue)
				request.WithQueryParameter("DIC4", m3DIC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC5.HasValue)
				request.WithQueryParameter("DIC5", m3DIC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC6.HasValue)
				request.WithQueryParameter("DIC6", m3DIC6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CMNO))
				request.WithQueryParameter("CMNO", m3CMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDS))
				request.WithQueryParameter("TEDS", m3TEDS.Trim());
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRHL))
				request.WithQueryParameter("PRHL", m3PRHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3GWTP))
				request.WithQueryParameter("GWTP", m3GWTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRHW))
				request.WithQueryParameter("PRHW", m3PRHW.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERW))
				request.WithQueryParameter("SERW", m3SERW.Trim());
			if (m3PWNR.HasValue)
				request.WithQueryParameter("PWNR", m3PWNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PWSX.HasValue)
				request.WithQueryParameter("PWSX", m3PWSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EWST.HasValue)
				request.WithQueryParameter("EWST", m3EWST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DANR.HasValue)
				request.WithQueryParameter("DANR", m3DANR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECN))
				request.WithQueryParameter("TECN", m3TECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3INAP))
				request.WithQueryParameter("INAP", m3INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DRDN))
				request.WithQueryParameter("DRDN", m3DRDN.Trim());
			if (m3DRDL.HasValue)
				request.WithQueryParameter("DRDL", m3DRDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3DRDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PIDE))
				request.WithQueryParameter("PIDE", m3PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3LTYP))
				request.WithQueryParameter("LTYP", m3LTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXH2))
				request.WithQueryParameter("EXH2", m3EXH2.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXC2))
				request.WithQueryParameter("EXC2", m3EXC2.Trim());
			if (m3MCHP.HasValue)
				request.WithQueryParameter("MCHP", m3MCHP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXHE))
				request.WithQueryParameter("EXHE", m3EXHE.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXCN))
				request.WithQueryParameter("EXCN", m3EXCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());

			// Execute the request
			var result = await Execute<AddBatchLineResponse>(
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
		/// Name AddBatchLineChg
		/// Description Add charge to batch order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3CRID">Charge id (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CRAM">Charge amount</param>
		/// <param name="m3CRFA">Calculation factor</param>
		/// <param name="m3CRD0">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchLineChg(
			string m3ORNO, 
			string m3PONR, 
			string m3POSX, 
			string m3CRID, 
			int? m3CONO = null, 
			string m3CRAM = null, 
			string m3CRFA = null, 
			string m3CRD0 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchLineChg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));
			if (string.IsNullOrWhiteSpace(m3POSX))
				throw new ArgumentNullException(nameof(m3POSX));
			if (string.IsNullOrWhiteSpace(m3CRID))
				throw new ArgumentNullException(nameof(m3CRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim())
				.WithQueryParameter("POSX", m3POSX.Trim())
				.WithQueryParameter("CRID", m3CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CRAM))
				request.WithQueryParameter("CRAM", m3CRAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRFA))
				request.WithQueryParameter("CRFA", m3CRFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRD0))
				request.WithQueryParameter("CRD0", m3CRD0.Trim());

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
		/// Name AddBatchLnInfo
		/// Description Add additional information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchLnInfo(
			string m3ORNO, 
			string m3PONR, 
			string m3AGNB, 
			int m3SEQN, 
			string m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchLnInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());

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
		/// Name AddBatchLnManRe
		/// Description Add manual rebate to batch order line
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3CLAR">Supplier rebate reference number (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3RASR">Agreement reference number</param>
		/// <param name="m3SREA">Rebate amount</param>
		/// <param name="m3RPUN">Rebate amount - unit of measure</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchLnManRe(
			int m3CONO, 
			string m3ORNO, 
			int m3PONR, 
			int m3POSX, 
			string m3SUNO, 
			string m3CLAR, 
			string m3CUCD, 
			string m3RASR = null, 
			decimal? m3SREA = null, 
			string m3RPUN = null, 
			string m3RESP = null, 
			string m3RFID = null, 
			string m3OREF = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchLnManRe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3CLAR))
				throw new ArgumentNullException(nameof(m3CLAR));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("CLAR", m3CLAR.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RASR))
				request.WithQueryParameter("RASR", m3RASR.Trim());
			if (m3SREA.HasValue)
				request.WithQueryParameter("SREA", m3SREA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPUN))
				request.WithQueryParameter("RPUN", m3RPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
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
		/// Name AddBatchQuot
		/// Description Add quotation information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3GIDT">Valid to date (Required)</param>
		/// <param name="m3BVC1">Follow up activity 1 (Required)</param>
		/// <param name="m3BVC2">Follow up activity 2 (Required)</param>
		/// <param name="m3FFI1">User defined field 1 (Required)</param>
		/// <param name="m3FFI2">User defined field 2 (Required)</param>
		/// <param name="m3FFI3">User defined field 3 (Required)</param>
		/// <param name="m3FFI4">User defined field 4 (Required)</param>
		/// <param name="m3ORCD">Quotation reason (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BVD1">Follow up date 1</param>
		/// <param name="m3BVD2">Follow up date 2</param>
		/// <param name="m3DLDA">Delivery time in days</param>
		/// <param name="m3REFO">Reference object - Used as search key</param>
		/// <param name="m3FFI5">User defined field 5</param>
		/// <param name="m3FFI6">User defined field 6</param>
		/// <param name="m3NUM2">Confirm</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchQuotResponse></returns>
		/// <exception cref="M3Exception<AddBatchQuotResponse>"></exception>
		public async Task<M3Response<AddBatchQuotResponse>> AddBatchQuot(
			string m3ORNO, 
			DateTime m3GIDT, 
			string m3BVC1, 
			string m3BVC2, 
			string m3FFI1, 
			string m3FFI2, 
			string m3FFI3, 
			string m3FFI4, 
			string m3ORCD, 
			int? m3CONO = null, 
			DateTime? m3BVD1 = null, 
			DateTime? m3BVD2 = null, 
			int? m3DLDA = null, 
			string m3REFO = null, 
			string m3FFI5 = null, 
			string m3FFI6 = null, 
			int? m3NUM2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3BVC1))
				throw new ArgumentNullException(nameof(m3BVC1));
			if (string.IsNullOrWhiteSpace(m3BVC2))
				throw new ArgumentNullException(nameof(m3BVC2));
			if (string.IsNullOrWhiteSpace(m3FFI1))
				throw new ArgumentNullException(nameof(m3FFI1));
			if (string.IsNullOrWhiteSpace(m3FFI2))
				throw new ArgumentNullException(nameof(m3FFI2));
			if (string.IsNullOrWhiteSpace(m3FFI3))
				throw new ArgumentNullException(nameof(m3FFI3));
			if (string.IsNullOrWhiteSpace(m3FFI4))
				throw new ArgumentNullException(nameof(m3FFI4));
			if (string.IsNullOrWhiteSpace(m3ORCD))
				throw new ArgumentNullException(nameof(m3ORCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("GIDT", m3GIDT.ToM3String())
				.WithQueryParameter("BVC1", m3BVC1.Trim())
				.WithQueryParameter("BVC2", m3BVC2.Trim())
				.WithQueryParameter("FFI1", m3FFI1.Trim())
				.WithQueryParameter("FFI2", m3FFI2.Trim())
				.WithQueryParameter("FFI3", m3FFI3.Trim())
				.WithQueryParameter("FFI4", m3FFI4.Trim())
				.WithQueryParameter("ORCD", m3ORCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BVD1.HasValue)
				request.WithQueryParameter("BVD1", m3BVD1.Value.ToM3String());
			if (m3BVD2.HasValue)
				request.WithQueryParameter("BVD2", m3BVD2.Value.ToM3String());
			if (m3DLDA.HasValue)
				request.WithQueryParameter("DLDA", m3DLDA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REFO))
				request.WithQueryParameter("REFO", m3REFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI5))
				request.WithQueryParameter("FFI5", m3FFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI6))
				request.WithQueryParameter("FFI6", m3FFI6.Trim());
			if (m3NUM2.HasValue)
				request.WithQueryParameter("NUM2", m3NUM2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddBatchQuotResponse>(
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
		/// Name AddBatchSalesPe
		/// Description Add Batch Salesperson
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORNO">Temporary order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3SMCD">Salesperson (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CAMO">Commission amount</param>
		/// <param name="m3COPE">Commission percentage</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchSalesPe(
			string m3ORNO, 
			int m3PONR, 
			string m3SMCD, 
			int? m3POSX = null, 
			string m3CUCD = null, 
			decimal? m3CAMO = null, 
			int? m3COPE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchSalesPe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3SMCD))
				throw new ArgumentNullException(nameof(m3SMCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SMCD", m3SMCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3CAMO.HasValue)
				request.WithQueryParameter("CAMO", m3CAMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COPE.HasValue)
				request.WithQueryParameter("COPE", m3COPE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddBatchText
		/// Description Add text for order head/line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3TYPE">Order head or Line, 1=Head/2=Line (Required)</param>
		/// <param name="m3TYTR">Type of text, 1=Pre/2=Post/3=F6 (Required)</param>
		/// <param name="m3PARM">Text (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3TXHE">Document class</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TXEI">External/internal text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchText(
			string m3ORNO, 
			string m3TYPE, 
			int m3TYTR, 
			string m3PARM, 
			int? m3CONO = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3TXHE = null, 
			string m3LNCD = null, 
			string m3TX40 = null, 
			int? m3TXEI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3TYPE))
				throw new ArgumentNullException(nameof(m3TYPE));
			if (string.IsNullOrWhiteSpace(m3PARM))
				throw new ArgumentNullException(nameof(m3PARM));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("TYPE", m3TYPE.Trim())
				.WithQueryParameter("TYTR", m3TYTR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PARM", m3PARM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXHE))
				request.WithQueryParameter("TXHE", m3TXHE.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3TXEI.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddConnCOCharge
		/// Description Add Connected CO Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CRID">Charge (Required)</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3CRAM">Charge amount</param>
		/// <param name="m3CRFA">Calculation factor</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3CRD0">Description language 0</param>
		/// <param name="m3CHST">Status - charge</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddConnCOCharge(
			string m3ORNO, 
			string m3CRID, 
			decimal? m3DLIX = null, 
			decimal? m3CRAM = null, 
			decimal? m3CRFA = null, 
			int? m3VTCD = null, 
			string m3ACRF = null, 
			string m3CRD0 = null, 
			string m3CHST = null, 
			string m3TAXC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddConnCOCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3CRID))
				throw new ArgumentNullException(nameof(m3CRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("CRID", m3CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRAM.HasValue)
				request.WithQueryParameter("CRAM", m3CRAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRFA.HasValue)
				request.WithQueryParameter("CRFA", m3CRFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRD0))
				request.WithQueryParameter("CRD0", m3CRD0.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHST))
				request.WithQueryParameter("CHST", m3CHST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());

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
		/// Name AddDocument
		/// Description Add Connected Document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3NOEX">Number of copies</param>
		/// <param name="m3DOCD">Print document</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDocument(
			string m3ORNO = null, 
			string m3DONR = null, 
			string m3DOVA = null, 
			int? m3NOEX = null, 
			int? m3DOCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDocument",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (m3NOEX.HasValue)
				request.WithQueryParameter("NOEX", m3NOEX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOCD.HasValue)
				request.WithQueryParameter("DOCD", m3DOCD.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddECI
		/// Description Add coded ECI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TPLI">Template item number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3TEDS">Description 1</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddECIResponse></returns>
		/// <exception cref="M3Exception<AddECIResponse>"></exception>
		public async Task<M3Response<AddECIResponse>> AddECI(
			string m3TPLI, 
			string m3WHLO, 
			string m3CUNO, 
			string m3SUNO = null, 
			string m3ITDS = null, 
			string m3TEDS = null, 
			string m3BUYE = null, 
			string m3ORTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddECI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TPLI))
				throw new ArgumentNullException(nameof(m3TPLI));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("TPLI", m3TPLI.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDS))
				request.WithQueryParameter("TEDS", m3TEDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());

			// Execute the request
			var result = await Execute<AddECIResponse>(
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
		/// Name AddLineBatchEnt
		/// Description Add CO line to an existing order via batch order entry
		/// Version Release: 5ea8
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3JDCD">Joint delivery</param>
		/// <param name="m3CUPO">Line number</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3DIA2">Discount amount 2</param>
		/// <param name="m3DIA3">Discount amount 3</param>
		/// <param name="m3DIA4">Discount amount 4</param>
		/// <param name="m3DIA5">Discount amount 5</param>
		/// <param name="m3DIA6">Discount amount 6</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3DLSX">Delivery specification text</param>
		/// <param name="m3CFXX">Old CFIN</param>
		/// <param name="m3ECVS">Simulation round</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3CODT">Confirmed delivery date</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3DIP1">Discount 1</param>
		/// <param name="m3DIP2">Discount 2</param>
		/// <param name="m3DIP3">Discount 3</param>
		/// <param name="m3DIP4">Discount 4</param>
		/// <param name="m3DIP5">Discount 5</param>
		/// <param name="m3DIP6">Discount 6</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3AGNO">Blanket agreement number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUPA">Customers packaging identity</param>
		/// <param name="m3DWHM">Requested delivery time</param>
		/// <param name="m3D1QT">Standard quantity</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3SPUN">Sales price unit of measure</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3EDFP">EDIFACT price</param>
		/// <param name="m3DWDZ">Requested delivery date</param>
		/// <param name="m3DWHZ">Requested delivery time</param>
		/// <param name="m3COHM">Confirmed delivery time</param>
		/// <param name="m3CODZ">Confirmed delivery date</param>
		/// <param name="m3COHZ">Confirmed delivery time</param>
		/// <param name="m3HDPR">Main product</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3CUSX">Line suffix</param>
		/// <param name="m3TEDS">Description 1</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3BANO">Batch no</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3DIC1">Status - discount</param>
		/// <param name="m3DIC2">Status - discount</param>
		/// <param name="m3DIC3">Status - discount</param>
		/// <param name="m3DIC4">Status - discount</param>
		/// <param name="m3DIC5">Status - discount</param>
		/// <param name="m3DIC6">Status - discount</param>
		/// <param name="m3PRHL">Product number highest level</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3GWTP">Granted warranty type</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3PRHW">Product number highest level</param>
		/// <param name="m3SERW">Serial number</param>
		/// <param name="m3PWNR">Order line number</param>
		/// <param name="m3PWSX">Line suffix</param>
		/// <param name="m3EWST">Extended warranty start</param>
		/// <param name="m3DANR">Default attribute number</param>
		/// <param name="m3TECN">Tax exemption contract number</param>
		/// <param name="m3INAP">Industry Application</param>
		/// <param name="m3DRDN">Demand order number</param>
		/// <param name="m3DRDL">Demand order line</param>
		/// <param name="m3DRDX">Line suffix</param>
		/// <param name="m3PIDE">Promotion</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3LTYP">Line type</param>
		/// <param name="m3PONR">Order line number</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3EXH2">External order number</param>
		/// <param name="m3EXC2">External configuration number</param>
		/// <param name="m3MCHP">Price change indicator</param>
		/// <param name="m3EXHE">External order number</param>
		/// <param name="m3EXCN">External configuration number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLineBatchEntResponse></returns>
		/// <exception cref="M3Exception<AddLineBatchEntResponse>"></exception>
		public async Task<M3Response<AddLineBatchEntResponse>> AddLineBatchEnt(
			string m3ORNO, 
			string m3ITNO, 
			int? m3CONO = null, 
			string m3ORQT = null, 
			string m3WHLO = null, 
			DateTime? m3DWDT = null, 
			string m3JDCD = null, 
			string m3CUPO = null, 
			string m3SAPR = null, 
			string m3DIA1 = null, 
			string m3DIA2 = null, 
			string m3DIA3 = null, 
			string m3DIA4 = null, 
			string m3DIA5 = null, 
			string m3DIA6 = null, 
			string m3DLSP = null, 
			string m3DLSX = null, 
			int? m3CFXX = null, 
			int? m3ECVS = null, 
			string m3ALUN = null, 
			DateTime? m3CODT = null, 
			string m3ITDS = null, 
			int? m3DIP1 = null, 
			int? m3DIP2 = null, 
			int? m3DIP3 = null, 
			int? m3DIP4 = null, 
			int? m3DIP5 = null, 
			int? m3DIP6 = null, 
			int? m3ALWT = null, 
			string m3ALWQ = null, 
			string m3AGNO = null, 
			string m3CAMU = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3CUOR = null, 
			string m3CUPA = null, 
			int? m3DWHM = null, 
			decimal? m3D1QT = null, 
			string m3PACT = null, 
			string m3POPN = null, 
			int? m3SACD = null, 
			string m3SPUN = null, 
			string m3TEPA = null, 
			decimal? m3EDFP = null, 
			DateTime? m3DWDZ = null, 
			int? m3DWHZ = null, 
			int? m3COHM = null, 
			DateTime? m3CODZ = null, 
			int? m3COHZ = null, 
			string m3HDPR = null, 
			string m3ADID = null, 
			int? m3CUSX = null, 
			string m3TEDS = null, 
			long? m3CFIN = null, 
			string m3BANO = null, 
			string m3WHSL = null, 
			int? m3DIC1 = null, 
			int? m3DIC2 = null, 
			int? m3DIC3 = null, 
			int? m3DIC4 = null, 
			int? m3DIC5 = null, 
			int? m3DIC6 = null, 
			string m3PRHL = null, 
			string m3SERN = null, 
			string m3CTNO = null, 
			string m3CFGL = null, 
			string m3GWTP = null, 
			string m3WATP = null, 
			string m3PRHW = null, 
			string m3SERW = null, 
			int? m3PWNR = null, 
			int? m3PWSX = null, 
			int? m3EWST = null, 
			decimal? m3DANR = null, 
			string m3TECN = null, 
			string m3INAP = null, 
			string m3DRDN = null, 
			int? m3DRDL = null, 
			int? m3DRDX = null, 
			string m3PIDE = null, 
			string m3TEPY = null, 
			string m3LTYP = null, 
			int? m3PONR = null, 
			string m3RSCD = null, 
			string m3EXH2 = null, 
			string m3EXC2 = null, 
			int? m3MCHP = null, 
			string m3EXHE = null, 
			string m3EXCN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddLineBatchEnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORQT))
				request.WithQueryParameter("ORQT", m3ORQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3JDCD))
				request.WithQueryParameter("JDCD", m3JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPO))
				request.WithQueryParameter("CUPO", m3CUPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAPR))
				request.WithQueryParameter("SAPR", m3SAPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA1))
				request.WithQueryParameter("DIA1", m3DIA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA2))
				request.WithQueryParameter("DIA2", m3DIA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA3))
				request.WithQueryParameter("DIA3", m3DIA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA4))
				request.WithQueryParameter("DIA4", m3DIA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA5))
				request.WithQueryParameter("DIA5", m3DIA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA6))
				request.WithQueryParameter("DIA6", m3DIA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSX))
				request.WithQueryParameter("DLSX", m3DLSX.Trim());
			if (m3CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3CFXX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3ECVS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3CODT.HasValue)
				request.WithQueryParameter("CODT", m3CODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (m3DIP1.HasValue)
				request.WithQueryParameter("DIP1", m3DIP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP2.HasValue)
				request.WithQueryParameter("DIP2", m3DIP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3DIP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP4.HasValue)
				request.WithQueryParameter("DIP4", m3DIP4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP5.HasValue)
				request.WithQueryParameter("DIP5", m3DIP5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP6.HasValue)
				request.WithQueryParameter("DIP6", m3DIP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNO))
				request.WithQueryParameter("AGNO", m3AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (m3DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3DWHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPUN))
				request.WithQueryParameter("SPUN", m3SPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (m3EDFP.HasValue)
				request.WithQueryParameter("EDFP", m3EDFP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DWDZ.HasValue)
				request.WithQueryParameter("DWDZ", m3DWDZ.Value.ToM3String());
			if (m3DWHZ.HasValue)
				request.WithQueryParameter("DWHZ", m3DWHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COHM.HasValue)
				request.WithQueryParameter("COHM", m3COHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CODZ.HasValue)
				request.WithQueryParameter("CODZ", m3CODZ.Value.ToM3String());
			if (m3COHZ.HasValue)
				request.WithQueryParameter("COHZ", m3COHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3HDPR))
				request.WithQueryParameter("HDPR", m3HDPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3CUSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEDS))
				request.WithQueryParameter("TEDS", m3TEDS.Trim());
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3DIC1.HasValue)
				request.WithQueryParameter("DIC1", m3DIC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC2.HasValue)
				request.WithQueryParameter("DIC2", m3DIC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC3.HasValue)
				request.WithQueryParameter("DIC3", m3DIC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC4.HasValue)
				request.WithQueryParameter("DIC4", m3DIC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC5.HasValue)
				request.WithQueryParameter("DIC5", m3DIC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC6.HasValue)
				request.WithQueryParameter("DIC6", m3DIC6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRHL))
				request.WithQueryParameter("PRHL", m3PRHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3GWTP))
				request.WithQueryParameter("GWTP", m3GWTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRHW))
				request.WithQueryParameter("PRHW", m3PRHW.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERW))
				request.WithQueryParameter("SERW", m3SERW.Trim());
			if (m3PWNR.HasValue)
				request.WithQueryParameter("PWNR", m3PWNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PWSX.HasValue)
				request.WithQueryParameter("PWSX", m3PWSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EWST.HasValue)
				request.WithQueryParameter("EWST", m3EWST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DANR.HasValue)
				request.WithQueryParameter("DANR", m3DANR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECN))
				request.WithQueryParameter("TECN", m3TECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3INAP))
				request.WithQueryParameter("INAP", m3INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DRDN))
				request.WithQueryParameter("DRDN", m3DRDN.Trim());
			if (m3DRDL.HasValue)
				request.WithQueryParameter("DRDL", m3DRDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3DRDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PIDE))
				request.WithQueryParameter("PIDE", m3PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3LTYP))
				request.WithQueryParameter("LTYP", m3LTYP.Trim());
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXH2))
				request.WithQueryParameter("EXH2", m3EXH2.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXC2))
				request.WithQueryParameter("EXC2", m3EXC2.Trim());
			if (m3MCHP.HasValue)
				request.WithQueryParameter("MCHP", m3MCHP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXHE))
				request.WithQueryParameter("EXHE", m3EXHE.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXCN))
				request.WithQueryParameter("EXCN", m3EXCN.Trim());

			// Execute the request
			var result = await Execute<AddLineBatchEntResponse>(
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
		/// Name AddLineManRe
		/// Description Add manual rebate to an existing order line
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3CLAR">Supplier rebate reference number (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3RASR">Agreement reference number</param>
		/// <param name="m3SREA">Rebate amount</param>
		/// <param name="m3RPUN">Rebate amount - unit of measure</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLineManRe(
			int m3CONO, 
			string m3ORNO, 
			int m3PONR, 
			int m3POSX, 
			string m3SUNO, 
			string m3CLAR, 
			string m3CUCD, 
			string m3RASR = null, 
			decimal? m3SREA = null, 
			string m3RPUN = null, 
			string m3RESP = null, 
			string m3RFID = null, 
			string m3OREF = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddLineManRe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3CLAR))
				throw new ArgumentNullException(nameof(m3CLAR));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("CLAR", m3CLAR.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RASR))
				request.WithQueryParameter("RASR", m3RASR.Trim());
			if (m3SREA.HasValue)
				request.WithQueryParameter("SREA", m3SREA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPUN))
				request.WithQueryParameter("RPUN", m3RPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
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
		/// Name AddLnInfo
		/// Description Add additional information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLnInfo(
			string m3ORNO, 
			int m3PONR, 
			string m3AGNB, 
			int m3SEQN, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddLnInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddSoldAgainst
		/// Description Add sold against info for pricing
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3AAGN">Agreement</param>
		/// <param name="m3ADLM">Dealer model</param>
		/// <param name="m3APRM">Price model</param>
		/// <param name="m3ASLM">Sales model</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFJ0">User-defined field 10 - serv agreement NOT USED 170224</param>
		/// <param name="m3EQGR">Equipment group</param>
		/// <param name="m3EQTP">Equipment type</param>
		/// <param name="m3FLEE">Fleet</param>
		/// <param name="m3FLNO">Fleet number</param>
		/// <param name="m3INAP">Industry application</param>
		/// <param name="m3OENV">Operating environment</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3PROD">Manufacturer</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3CFJX">User-defined field 10 - serv agreement</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSoldAgainst(
			int m3CONO, 
			string m3ORNO, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3AAGN = null, 
			string m3ADLM = null, 
			string m3APRM = null, 
			string m3ASLM = null, 
			string m3BRAN = null, 
			string m3CFI3 = null, 
			string m3CFJ0 = null, 
			string m3EQGR = null, 
			string m3EQTP = null, 
			string m3FLEE = null, 
			string m3FLNO = null, 
			string m3INAP = null, 
			string m3OENV = null, 
			string m3PRNO = null, 
			string m3PROD = null, 
			string m3SERN = null, 
			string m3SUNO = null, 
			string m3CFJX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSoldAgainst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADLM))
				request.WithQueryParameter("ADLM", m3ADLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3APRM))
				request.WithQueryParameter("APRM", m3APRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASLM))
				request.WithQueryParameter("ASLM", m3ASLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI3))
				request.WithQueryParameter("CFI3", m3CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ0))
				request.WithQueryParameter("CFJ0", m3CFJ0.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGR))
				request.WithQueryParameter("EQGR", m3EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQTP))
				request.WithQueryParameter("EQTP", m3EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLEE))
				request.WithQueryParameter("FLEE", m3FLEE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLNO))
				request.WithQueryParameter("FLNO", m3FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3INAP))
				request.WithQueryParameter("INAP", m3INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OENV))
				request.WithQueryParameter("OENV", m3OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROD))
				request.WithQueryParameter("PROD", m3PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJX))
				request.WithQueryParameter("CFJX", m3CFJX.Trim());

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
		/// Description Add Text for a customer order
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3FLDN">Field number</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TXCC">Text control code</param>
		/// <param name="m3TXEI">External/internal text</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3KFLD">File key</param>
		/// <param name="m3REPL">Replacing VAT code found</param>
		/// <param name="m3TEXT">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddTextResponse></returns>
		/// <exception cref="M3Exception<AddTextResponse>"></exception>
		public async Task<M3Response<AddTextResponse>> AddText(
			string m3FLDN = null, 
			string m3TXVR = null, 
			string m3LNCD = null, 
			string m3TX40 = null, 
			string m3TXCC = null, 
			int? m3TXEI = null, 
			string m3FILE = null, 
			string m3KFLD = null, 
			int? m3REPL = null, 
			string m3TEXT = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FLDN))
				request.WithQueryParameter("FLDN", m3FLDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXCC))
				request.WithQueryParameter("TXCC", m3TXCC.Trim());
			if (m3TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3TXEI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3KFLD))
				request.WithQueryParameter("KFLD", m3KFLD.Trim());
			if (m3REPL.HasValue)
				request.WithQueryParameter("REPL", m3REPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEXT))
				request.WithQueryParameter("TEXT", m3TEXT.Trim());

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
		/// Name AddUncheckHead
		/// Description Create new batch order head without checks
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3ORTP">Order type (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3RLDT">Requested delivery date</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3AGNT">Agent</param>
		/// <param name="m3SMCD">Salesman</param>
		/// <param name="m3MODL">Method of delivery</param>
		/// <param name="m3TEDL">Term of delivery</param>
		/// <param name="m3YREF">Reference at customer</param>
		/// <param name="m3PROJ">Project</param>
		/// <param name="m3OTBA">Order discount amount</param>
		/// <param name="m3TEPY">Terms of payment</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3ADID">Delivery address id</param>
		/// <param name="m3CUCD">Currency code</param>
		/// <param name="m3OREF">Our referens</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3TEL2">Delivery terms text</param>
		/// <param name="m3CUDT">Customers purchase order date</param>
		/// <param name="m3INRC">Invoice recipient</param>
		/// <param name="m3ORDT">Order date</param>
		/// <param name="m3RLHM">Requested delivery time</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3TIZO">Time zone</param>
		/// <param name="m3AGNO">Blanket agreement number</param>
		/// <param name="m3PRO2">Project</param>
		/// <param name="m3RLDZ">Requested delivery date</param>
		/// <param name="m3RLHZ">Requested delivery time</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3DSTX">Description of delivery specification</param>
		/// <param name="m3TECD">Cash discount term</param>
		/// <param name="m3PLTB">Price list table</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3WCON">Contact method</param>
		/// <param name="m3ID01">Message identity 1</param>
		/// <param name="m3ID02">Message identity 2</param>
		/// <param name="m3OTDP">Total discount percentage</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3DICD">Discount origin</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3CHL1">Business chain - level 1</param>
		/// <param name="m3CHL2">Business chain - level 2</param>
		/// <param name="m3CHL3">Business chain - level 3</param>
		/// <param name="m3CHL4">Business chain - level 4</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3NREF">Reference number</param>
		/// <param name="m3TRDP">3rd party provider ID</param>
		/// <param name="m3IPAD">IP address</param>
		/// <param name="m3ESOV">e-Sales order value</param>
		/// <param name="m3EXCD">Service charge</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3FRE1">Statistics identity 1 customer</param>
		/// <param name="m3FDED">First delivery date</param>
		/// <param name="m3LDED">Last delivery date</param>
		/// <param name="m3BREC">Recipient agreement type 9 - bonus</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3OHEA">Only header</param>
		/// <param name="m3CUCH">Customer channel id</param>
		/// <param name="m3CCAC">Activity</param>
		/// <param name="m3DECU">Delivery customer</param>
		/// <param name="m3GCAC">Supplier ID</param>
		/// <param name="m3PYRE">Request reference number</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddUncheckHeadResponse></returns>
		/// <exception cref="M3Exception<AddUncheckHeadResponse>"></exception>
		public async Task<M3Response<AddUncheckHeadResponse>> AddUncheckHead(
			string m3CUNO, 
			string m3ORTP, 
			string m3FACI, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			DateTime? m3RLDT = null, 
			string m3CUOR = null, 
			string m3AGNT = null, 
			string m3SMCD = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3YREF = null, 
			string m3PROJ = null, 
			string m3OTBA = null, 
			string m3TEPY = null, 
			string m3PYNO = null, 
			string m3ADID = null, 
			string m3CUCD = null, 
			string m3OREF = null, 
			string m3OFNO = null, 
			string m3TEL2 = null, 
			DateTime? m3CUDT = null, 
			string m3INRC = null, 
			DateTime? m3ORDT = null, 
			int? m3RLHM = null, 
			string m3TEPA = null, 
			string m3TIZO = null, 
			string m3AGNO = null, 
			string m3PRO2 = null, 
			DateTime? m3RLDZ = null, 
			int? m3RLHZ = null, 
			string m3DLSP = null, 
			string m3DSTX = null, 
			string m3TECD = null, 
			string m3PLTB = null, 
			string m3DISY = null, 
			string m3WCON = null, 
			string m3ID01 = null, 
			string m3ID02 = null, 
			string m3OTDP = null, 
			string m3CRTP = null, 
			int? m3DICD = null, 
			string m3ELNO = null, 
			string m3CHL1 = null, 
			string m3CHL2 = null, 
			string m3CHL3 = null, 
			string m3CHL4 = null, 
			string m3WHLO = null, 
			string m3NREF = null, 
			string m3TRDP = null, 
			string m3IPAD = null, 
			int? m3ESOV = null, 
			string m3EXCD = null, 
			string m3PYCD = null, 
			string m3FRE1 = null, 
			DateTime? m3FDED = null, 
			DateTime? m3LDED = null, 
			string m3BREC = null, 
			string m3RESP = null, 
			int? m3OHEA = null, 
			string m3CUCH = null, 
			string m3CCAC = null, 
			string m3DECU = null, 
			string m3GCAC = null, 
			string m3PYRE = null, 
			string m3BKID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddUncheckHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3ORTP))
				throw new ArgumentNullException(nameof(m3ORTP));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ORTP", m3ORTP.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3RLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNT))
				request.WithQueryParameter("AGNT", m3AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTBA))
				request.WithQueryParameter("OTBA", m3OTBA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL2))
				request.WithQueryParameter("TEL2", m3TEL2.Trim());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3INRC))
				request.WithQueryParameter("INRC", m3INRC.Trim());
			if (m3ORDT.HasValue)
				request.WithQueryParameter("ORDT", m3ORDT.Value.ToM3String());
			if (m3RLHM.HasValue)
				request.WithQueryParameter("RLHM", m3RLHM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIZO))
				request.WithQueryParameter("TIZO", m3TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNO))
				request.WithQueryParameter("AGNO", m3AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRO2))
				request.WithQueryParameter("PRO2", m3PRO2.Trim());
			if (m3RLDZ.HasValue)
				request.WithQueryParameter("RLDZ", m3RLDZ.Value.ToM3String());
			if (m3RLHZ.HasValue)
				request.WithQueryParameter("RLHZ", m3RLHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSTX))
				request.WithQueryParameter("DSTX", m3DSTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECD))
				request.WithQueryParameter("TECD", m3TECD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTB))
				request.WithQueryParameter("PLTB", m3PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (!string.IsNullOrWhiteSpace(m3WCON))
				request.WithQueryParameter("WCON", m3WCON.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID01))
				request.WithQueryParameter("ID01", m3ID01.Trim());
			if (!string.IsNullOrWhiteSpace(m3ID02))
				request.WithQueryParameter("ID02", m3ID02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTDP))
				request.WithQueryParameter("OTDP", m3OTDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRTP))
				request.WithQueryParameter("CRTP", m3CRTP.Trim());
			if (m3DICD.HasValue)
				request.WithQueryParameter("DICD", m3DICD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL1))
				request.WithQueryParameter("CHL1", m3CHL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL2))
				request.WithQueryParameter("CHL2", m3CHL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL3))
				request.WithQueryParameter("CHL3", m3CHL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL4))
				request.WithQueryParameter("CHL4", m3CHL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NREF))
				request.WithQueryParameter("NREF", m3NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRDP))
				request.WithQueryParameter("TRDP", m3TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3IPAD))
				request.WithQueryParameter("IPAD", m3IPAD.Trim());
			if (m3ESOV.HasValue)
				request.WithQueryParameter("ESOV", m3ESOV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXCD))
				request.WithQueryParameter("EXCD", m3EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE1))
				request.WithQueryParameter("FRE1", m3FRE1.Trim());
			if (m3FDED.HasValue)
				request.WithQueryParameter("FDED", m3FDED.Value.ToM3String());
			if (m3LDED.HasValue)
				request.WithQueryParameter("LDED", m3LDED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3BREC))
				request.WithQueryParameter("BREC", m3BREC.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3OHEA.HasValue)
				request.WithQueryParameter("OHEA", m3OHEA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCH))
				request.WithQueryParameter("CUCH", m3CUCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCAC))
				request.WithQueryParameter("CCAC", m3CCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3DECU))
				request.WithQueryParameter("DECU", m3DECU.Trim());
			if (!string.IsNullOrWhiteSpace(m3GCAC))
				request.WithQueryParameter("GCAC", m3GCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYRE))
				request.WithQueryParameter("PYRE", m3PYRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());

			// Execute the request
			var result = await Execute<AddUncheckHeadResponse>(
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
		/// Name AuthCreditCard
		/// Description Authorize Credit Card
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3NREF">Reference number</param>
		/// <param name="m3TRDP">3rd party provider</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AuthCreditCard(
			int? m3CONO = null, 
			string m3ORNO = null, 
			string m3NREF = null, 
			string m3TRDP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AuthCreditCard",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NREF))
				request.WithQueryParameter("NREF", m3NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRDP))
				request.WithQueryParameter("TRDP", m3TRDP.Trim());

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
		/// Name CheckCredit
		/// Description Check customer credit exceeded
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CheckCredit(
			string m3CUNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CheckCredit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

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
		/// Name CheckCustomer
		/// Description Check customer information
		/// Version Release: 
		/// </summary>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CheckCustomerResponse></returns>
		/// <exception cref="M3Exception<CheckCustomerResponse>"></exception>
		public async Task<M3Response<CheckCustomerResponse>> CheckCustomer(
			string m3CUNO = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CheckCustomer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());

			// Execute the request
			var result = await Execute<CheckCustomerResponse>(
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
		/// Name CheckPIN
		/// Description Check customer number and PIN code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3PWMT">Password (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CheckPIN(
			string m3CUNO, 
			string m3PWMT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CheckPIN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3PWMT))
				throw new ArgumentNullException(nameof(m3PWMT));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("PWMT", m3PWMT.Trim());

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
		/// Name ChgBatchHead
		/// Description Change contents of batch order head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Temporary order number (Required)</param>
		/// <param name="m3ORTP">Order type (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3RLDT">Requested delivery date</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3AGNT">Agent</param>
		/// <param name="m3SMCD">Salesman</param>
		/// <param name="m3MODL">Method of delivery</param>
		/// <param name="m3TEDL">Term of delivery</param>
		/// <param name="m3YREF">Reference at customer</param>
		/// <param name="m3PROJ">Project</param>
		/// <param name="m3OTBA">Order discount amount</param>
		/// <param name="m3TEPY">Terms of payment</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3ADID">Delivery address id</param>
		/// <param name="m3CUCD">Currency code</param>
		/// <param name="m3OREF">Our referens</param>
		/// <param name="m3INRC">Invoice recipient</param>
		/// <param name="m3TEL2">Terms text</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3RLDZ">Requested delivery date</param>
		/// <param name="m3RLHZ">Requested delivery time</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3DSTX">Description, delivery specification</param>
		/// <param name="m3TECD">Cash discount term</param>
		/// <param name="m3OTDP">Total discount percentage</param>
		/// <param name="m3NREF">Reference number</param>
		/// <param name="m3TRDP">3rd party provider ID</param>
		/// <param name="m3IPAD">IP address</param>
		/// <param name="m3EXCD">Service charge</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3FRE1">Statistics identity 1 customer</param>
		/// <param name="m3FDED">First delivery date</param>
		/// <param name="m3LDED">Last delivery date</param>
		/// <param name="m3BREC">Recipient agreement type 9 - bonus</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3PYRE">Request reference number</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3OPRI">Priority</param>
		/// <param name="m3SPLM">Supply model</param>
		/// <param name="m3OIVR">Original invoice reference</param>
		/// <param name="m3OYEA">Original year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgBatchHead(
			string m3ORNO, 
			string m3ORTP, 
			string m3FACI, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			DateTime? m3RLDT = null, 
			string m3CUOR = null, 
			string m3AGNT = null, 
			string m3SMCD = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3YREF = null, 
			string m3PROJ = null, 
			string m3OTBA = null, 
			string m3TEPY = null, 
			string m3PYNO = null, 
			string m3ADID = null, 
			string m3CUCD = null, 
			string m3OREF = null, 
			string m3INRC = null, 
			string m3TEL2 = null, 
			string m3TEPA = null, 
			string m3OFNO = null, 
			DateTime? m3RLDZ = null, 
			int? m3RLHZ = null, 
			string m3DLSP = null, 
			string m3DSTX = null, 
			string m3TECD = null, 
			string m3OTDP = null, 
			string m3NREF = null, 
			string m3TRDP = null, 
			string m3IPAD = null, 
			string m3EXCD = null, 
			string m3PYCD = null, 
			string m3FRE1 = null, 
			DateTime? m3FDED = null, 
			DateTime? m3LDED = null, 
			string m3BREC = null, 
			string m3RESP = null, 
			string m3PYRE = null, 
			string m3BKID = null, 
			int? m3OPRI = null, 
			string m3SPLM = null, 
			string m3OIVR = null, 
			int? m3OYEA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3ORTP))
				throw new ArgumentNullException(nameof(m3ORTP));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("ORTP", m3ORTP.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3RLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNT))
				request.WithQueryParameter("AGNT", m3AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTBA))
				request.WithQueryParameter("OTBA", m3OTBA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3INRC))
				request.WithQueryParameter("INRC", m3INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL2))
				request.WithQueryParameter("TEL2", m3TEL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3RLDZ.HasValue)
				request.WithQueryParameter("RLDZ", m3RLDZ.Value.ToM3String());
			if (m3RLHZ.HasValue)
				request.WithQueryParameter("RLHZ", m3RLHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSTX))
				request.WithQueryParameter("DSTX", m3DSTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECD))
				request.WithQueryParameter("TECD", m3TECD.Trim());
			if (!string.IsNullOrWhiteSpace(m3OTDP))
				request.WithQueryParameter("OTDP", m3OTDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3NREF))
				request.WithQueryParameter("NREF", m3NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRDP))
				request.WithQueryParameter("TRDP", m3TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3IPAD))
				request.WithQueryParameter("IPAD", m3IPAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXCD))
				request.WithQueryParameter("EXCD", m3EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE1))
				request.WithQueryParameter("FRE1", m3FRE1.Trim());
			if (m3FDED.HasValue)
				request.WithQueryParameter("FDED", m3FDED.Value.ToM3String());
			if (m3LDED.HasValue)
				request.WithQueryParameter("LDED", m3LDED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3BREC))
				request.WithQueryParameter("BREC", m3BREC.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYRE))
				request.WithQueryParameter("PYRE", m3PYRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (m3OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3OPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPLM))
				request.WithQueryParameter("SPLM", m3SPLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3OIVR))
				request.WithQueryParameter("OIVR", m3OIVR.Trim());
			if (m3OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3OYEA.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgBatchLine
		/// Description Change contents of batch order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Temporary order number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORQT">Ordered quantity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3JDCD">Joint delivery code</param>
		/// <param name="m3CUPO">Customers order number</param>
		/// <param name="m3SAPR">Salesprice</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3DIA2">Discount amount 2</param>
		/// <param name="m3DIA3">Discount amount 3</param>
		/// <param name="m3DIA4">Discount amount 4</param>
		/// <param name="m3DIA5">Discount amount 5</param>
		/// <param name="m3DIA6">Discount amount 6</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3DLSX">Delivery specification text</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3CFXX">Old CFIN</param>
		/// <param name="m3ECVS">Simulations number</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3CODT">Confirmed date of delivery</param>
		/// <param name="m3ITDS">Item description</param>
		/// <param name="m3DWHM">Requested delivery time</param>
		/// <param name="m3DWDZ">Requested delivery date</param>
		/// <param name="m3DWHZ">Requested delivery time</param>
		/// <param name="m3COHM">Confirmed delivery time</param>
		/// <param name="m3CODZ">Confirmed delivery date</param>
		/// <param name="m3COHZ">Confirmed delivery time</param>
		/// <param name="m3HDPR">Main product</param>
		/// <param name="m3AGNO">Blanket agreement number</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3CUPA">Customers packaging identity</param>
		/// <param name="m3D1QT">Standard quantity</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUSX">Line suffix</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3BANO">Batch no</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3GWTP">Granted warranty type</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3TECN">Tax exemption contract number</param>
		/// <param name="m3INAP">Industry Application</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgBatchLine(
			string m3ORNO, 
			string m3ITNO, 
			string m3PONR, 
			int? m3CONO = null, 
			string m3ORQT = null, 
			string m3WHLO = null, 
			DateTime? m3DWDT = null, 
			string m3JDCD = null, 
			string m3CUPO = null, 
			string m3SAPR = null, 
			string m3DIA1 = null, 
			string m3DIA2 = null, 
			string m3DIA3 = null, 
			string m3DIA4 = null, 
			string m3DIA5 = null, 
			string m3DIA6 = null, 
			string m3DLSP = null, 
			string m3DLSX = null, 
			string m3POSX = null, 
			int? m3CFXX = null, 
			int? m3ECVS = null, 
			string m3ALUN = null, 
			DateTime? m3CODT = null, 
			string m3ITDS = null, 
			int? m3DWHM = null, 
			DateTime? m3DWDZ = null, 
			int? m3DWHZ = null, 
			int? m3COHM = null, 
			DateTime? m3CODZ = null, 
			int? m3COHZ = null, 
			string m3HDPR = null, 
			string m3AGNO = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3CAMU = null, 
			string m3ADID = null, 
			string m3TEPA = null, 
			string m3PACT = null, 
			string m3CUPA = null, 
			decimal? m3D1QT = null, 
			string m3CUOR = null, 
			int? m3CUSX = null, 
			long? m3CFIN = null, 
			string m3BANO = null, 
			string m3WHSL = null, 
			string m3CTNO = null, 
			string m3CFGL = null, 
			string m3GWTP = null, 
			string m3WATP = null, 
			string m3TECN = null, 
			string m3INAP = null, 
			string m3TEPY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORQT))
				request.WithQueryParameter("ORQT", m3ORQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3JDCD))
				request.WithQueryParameter("JDCD", m3JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPO))
				request.WithQueryParameter("CUPO", m3CUPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAPR))
				request.WithQueryParameter("SAPR", m3SAPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA1))
				request.WithQueryParameter("DIA1", m3DIA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA2))
				request.WithQueryParameter("DIA2", m3DIA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA3))
				request.WithQueryParameter("DIA3", m3DIA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA4))
				request.WithQueryParameter("DIA4", m3DIA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA5))
				request.WithQueryParameter("DIA5", m3DIA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA6))
				request.WithQueryParameter("DIA6", m3DIA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSX))
				request.WithQueryParameter("DLSX", m3DLSX.Trim());
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());
			if (m3CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3CFXX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3ECVS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3CODT.HasValue)
				request.WithQueryParameter("CODT", m3CODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (m3DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3DWHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DWDZ.HasValue)
				request.WithQueryParameter("DWDZ", m3DWDZ.Value.ToM3String());
			if (m3DWHZ.HasValue)
				request.WithQueryParameter("DWHZ", m3DWHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COHM.HasValue)
				request.WithQueryParameter("COHM", m3COHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CODZ.HasValue)
				request.WithQueryParameter("CODZ", m3CODZ.Value.ToM3String());
			if (m3COHZ.HasValue)
				request.WithQueryParameter("COHZ", m3COHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3HDPR))
				request.WithQueryParameter("HDPR", m3HDPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNO))
				request.WithQueryParameter("AGNO", m3AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3CUSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3GWTP))
				request.WithQueryParameter("GWTP", m3GWTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECN))
				request.WithQueryParameter("TECN", m3TECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3INAP))
				request.WithQueryParameter("INAP", m3INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());

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
		/// Name ChgBatchLnPurch
		/// Description Change purchase info of batch order line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3PPUN">Purchase price U/M</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ODI1">Discount 1</param>
		/// <param name="m3ODI2">Discount 2</param>
		/// <param name="m3ODI3">Discount 3</param>
		/// <param name="m3OURR">Our reference number</param>
		/// <param name="m3OURT">Reference type</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgBatchLnPurch(
			int m3CONO, 
			string m3ORNO, 
			int m3PONR, 
			int? m3POSX = null, 
			string m3ORTY = null, 
			string m3SUNO = null, 
			decimal? m3PUPR = null, 
			int? m3PUCD = null, 
			string m3PPUN = null, 
			string m3CUCD = null, 
			int? m3ODI1 = null, 
			int? m3ODI2 = null, 
			int? m3ODI3 = null, 
			string m3OURR = null, 
			string m3OURT = null, 
			string m3BUYE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgBatchLnPurch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3ODI1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3ODI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3ODI3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OURR))
				request.WithQueryParameter("OURR", m3OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OURT))
				request.WithQueryParameter("OURT", m3OURT.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());

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
		/// Name ChgBatchQuot
		/// Description Change batch quotation information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORCD">Quotation reason</param>
		/// <param name="m3GIDT">Valid to date</param>
		/// <param name="m3BVD1">Follow up date 1</param>
		/// <param name="m3BVD2">Follow up date 2</param>
		/// <param name="m3BVC1">Follow up activity 1</param>
		/// <param name="m3BVC2">Follow up activity 2</param>
		/// <param name="m3DLDA">Delivery time in days</param>
		/// <param name="m3REFO">Reference object - Used as search key</param>
		/// <param name="m3FFI1">User defined field 1</param>
		/// <param name="m3FFI2">User defined field 2</param>
		/// <param name="m3FFI3">User defined field 3</param>
		/// <param name="m3FFI4">User defined field 4</param>
		/// <param name="m3FFI5">User defined field 5</param>
		/// <param name="m3FFI6">User defined field 6</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgBatchQuot(
			string m3ORNO, 
			int? m3CONO = null, 
			string m3ORCD = null, 
			DateTime? m3GIDT = null, 
			DateTime? m3BVD1 = null, 
			DateTime? m3BVD2 = null, 
			string m3BVC1 = null, 
			string m3BVC2 = null, 
			int? m3DLDA = null, 
			string m3REFO = null, 
			string m3FFI1 = null, 
			string m3FFI2 = null, 
			string m3FFI3 = null, 
			string m3FFI4 = null, 
			string m3FFI5 = null, 
			string m3FFI6 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgBatchQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCD))
				request.WithQueryParameter("ORCD", m3ORCD.Trim());
			if (m3GIDT.HasValue)
				request.WithQueryParameter("GIDT", m3GIDT.Value.ToM3String());
			if (m3BVD1.HasValue)
				request.WithQueryParameter("BVD1", m3BVD1.Value.ToM3String());
			if (m3BVD2.HasValue)
				request.WithQueryParameter("BVD2", m3BVD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3BVC1))
				request.WithQueryParameter("BVC1", m3BVC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BVC2))
				request.WithQueryParameter("BVC2", m3BVC2.Trim());
			if (m3DLDA.HasValue)
				request.WithQueryParameter("DLDA", m3DLDA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REFO))
				request.WithQueryParameter("REFO", m3REFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI1))
				request.WithQueryParameter("FFI1", m3FFI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI2))
				request.WithQueryParameter("FFI2", m3FFI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI3))
				request.WithQueryParameter("FFI3", m3FFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI4))
				request.WithQueryParameter("FFI4", m3FFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI5))
				request.WithQueryParameter("FFI5", m3FFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI6))
				request.WithQueryParameter("FFI6", m3FFI6.Trim());

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
		/// Name ChgLineBatchEnt
		/// Description Change CO line on an existing order via batch order entry
		/// Version Release: 5eaE
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3DWDZ">Requested delivery date</param>
		/// <param name="m3DWHZ">Requested delivery time</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3CUPA">Customers packaging identity</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3EDFP">EDIFACT price</param>
		/// <param name="m3PRHL">Product number highest level</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3GWTP">Granted warranty type</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3TECN">Tax exemption contract number</param>
		/// <param name="m3INAP">Industry Application</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3JDCD">Joint delivery</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgLineBatchEntResponse></returns>
		/// <exception cref="M3Exception<ChgLineBatchEntResponse>"></exception>
		public async Task<M3Response<ChgLineBatchEntResponse>> ChgLineBatchEnt(
			string m3ORNO, 
			string m3PONR, 
			int? m3CONO = null, 
			string m3POSX = null, 
			string m3ORQA = null, 
			DateTime? m3DWDZ = null, 
			int? m3DWHZ = null, 
			string m3CUOR = null, 
			string m3TEPA = null, 
			string m3CUPA = null, 
			string m3ADID = null, 
			string m3DLSP = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3EDFP = null, 
			string m3PRHL = null, 
			string m3SERN = null, 
			string m3CTNO = null, 
			string m3CFGL = null, 
			string m3GWTP = null, 
			string m3WATP = null, 
			string m3TECN = null, 
			string m3INAP = null, 
			string m3TEPY = null, 
			string m3JDCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgLineBatchEnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORQA))
				request.WithQueryParameter("ORQA", m3ORQA.Trim());
			if (m3DWDZ.HasValue)
				request.WithQueryParameter("DWDZ", m3DWDZ.Value.ToM3String());
			if (m3DWHZ.HasValue)
				request.WithQueryParameter("DWHZ", m3DWHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDFP))
				request.WithQueryParameter("EDFP", m3EDFP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRHL))
				request.WithQueryParameter("PRHL", m3PRHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3GWTP))
				request.WithQueryParameter("GWTP", m3GWTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECN))
				request.WithQueryParameter("TECN", m3TECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3INAP))
				request.WithQueryParameter("INAP", m3INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3JDCD))
				request.WithQueryParameter("JDCD", m3JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<ChgLineBatchEntResponse>(
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
		/// Name ChgQuot
		/// Description Change quotation information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STAT">Status quotation</param>
		/// <param name="m3ORCD">Quotation reason</param>
		/// <param name="m3GIDT">Valid to date</param>
		/// <param name="m3BVD1">Follow up date 1</param>
		/// <param name="m3BVD2">Follow up date 2</param>
		/// <param name="m3BVC1">Follow up activity 1</param>
		/// <param name="m3BVC2">Follow up activity 2</param>
		/// <param name="m3DLDA">Delivery time in days</param>
		/// <param name="m3REFO">Reference object - Used as search key</param>
		/// <param name="m3FFI1">User defined field 1</param>
		/// <param name="m3FFI2">User defined field 2</param>
		/// <param name="m3FFI3">User defined field 3</param>
		/// <param name="m3FFI4">User defined field 4</param>
		/// <param name="m3FFI5">User defined field 5</param>
		/// <param name="m3FFI6">User defined field 6</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgQuot(
			string m3ORNO, 
			int? m3CONO = null, 
			string m3STAT = null, 
			string m3ORCD = null, 
			DateTime? m3GIDT = null, 
			DateTime? m3BVD1 = null, 
			DateTime? m3BVD2 = null, 
			string m3BVC1 = null, 
			string m3BVC2 = null, 
			int? m3DLDA = null, 
			string m3REFO = null, 
			string m3FFI1 = null, 
			string m3FFI2 = null, 
			string m3FFI3 = null, 
			string m3FFI4 = null, 
			string m3FFI5 = null, 
			string m3FFI6 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCD))
				request.WithQueryParameter("ORCD", m3ORCD.Trim());
			if (m3GIDT.HasValue)
				request.WithQueryParameter("GIDT", m3GIDT.Value.ToM3String());
			if (m3BVD1.HasValue)
				request.WithQueryParameter("BVD1", m3BVD1.Value.ToM3String());
			if (m3BVD2.HasValue)
				request.WithQueryParameter("BVD2", m3BVD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3BVC1))
				request.WithQueryParameter("BVC1", m3BVC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BVC2))
				request.WithQueryParameter("BVC2", m3BVC2.Trim());
			if (m3DLDA.HasValue)
				request.WithQueryParameter("DLDA", m3DLDA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REFO))
				request.WithQueryParameter("REFO", m3REFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI1))
				request.WithQueryParameter("FFI1", m3FFI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI2))
				request.WithQueryParameter("FFI2", m3FFI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI3))
				request.WithQueryParameter("FFI3", m3FFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI4))
				request.WithQueryParameter("FFI4", m3FFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI5))
				request.WithQueryParameter("FFI5", m3FFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI6))
				request.WithQueryParameter("FFI6", m3FFI6.Trim());

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
		/// Name ChgWarehouse
		/// Description Change warehouse on CO line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgWarehouseResponse></returns>
		/// <exception cref="M3Exception<ChgWarehouseResponse>"></exception>
		public async Task<M3Response<ChgWarehouseResponse>> ChgWarehouse(
			string m3ORNO, 
			string m3WHLO, 
			int? m3CONO = null, 
			string m3PONR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgWarehouse",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PONR))
				request.WithQueryParameter("PONR", m3PONR.Trim());

			// Execute the request
			var result = await Execute<ChgWarehouseResponse>(
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
		/// Name CloLine
		/// Description CloLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3PONR">Order line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloLine(
			int? m3CONO = null, 
			string m3ORNO = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CloLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Confirm
		/// Description Confirm order (release batch order)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Batch order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CTYP">Confirmation type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConfirmResponse></returns>
		/// <exception cref="M3Exception<ConfirmResponse>"></exception>
		public async Task<M3Response<ConfirmResponse>> Confirm(
			string m3ORNO, 
			int? m3CONO = null, 
			string m3CTYP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Confirm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CTYP))
				request.WithQueryParameter("CTYP", m3CTYP.Trim());

			// Execute the request
			var result = await Execute<ConfirmResponse>(
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
		/// Name CpyOrder
		/// Description Copy customer order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNR">Ordernumber to copy from (Required)</param>
		/// <param name="m3ORTP">Order type to use (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CORH">Copy order head</param>
		/// <param name="m3CORL">Copy order lines</param>
		/// <param name="m3COCH">Copy line charges</param>
		/// <param name="m3COTX">Copy order texts</param>
		/// <param name="m3CLCH">Copy order texts</param>
		/// <param name="m3CLTX">Copy line texts</param>
		/// <param name="m3CADR">Copy addresses</param>
		/// <param name="m3SAPR">Copy sales price</param>
		/// <param name="m3UCOS">Copy cost price</param>
		/// <param name="m3JDCD">Copy joint delivery</param>
		/// <param name="m3RLDT">Copy requested delivery date</param>
		/// <param name="m3CODT">Copy confirmed delivery date</param>
		/// <param name="m3EPRI">Copy external prices</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CpyOrderResponse></returns>
		/// <exception cref="M3Exception<CpyOrderResponse>"></exception>
		public async Task<M3Response<CpyOrderResponse>> CpyOrder(
			string m3ORNR, 
			string m3ORTP, 
			int? m3CONO = null, 
			int? m3CORH = null, 
			int? m3CORL = null, 
			int? m3COCH = null, 
			int? m3COTX = null, 
			int? m3CLCH = null, 
			int? m3CLTX = null, 
			int? m3CADR = null, 
			int? m3SAPR = null, 
			int? m3UCOS = null, 
			int? m3JDCD = null, 
			DateTime? m3RLDT = null, 
			DateTime? m3CODT = null, 
			int? m3EPRI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CpyOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNR))
				throw new ArgumentNullException(nameof(m3ORNR));
			if (string.IsNullOrWhiteSpace(m3ORTP))
				throw new ArgumentNullException(nameof(m3ORTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNR", m3ORNR.Trim())
				.WithQueryParameter("ORTP", m3ORTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CORH.HasValue)
				request.WithQueryParameter("CORH", m3CORH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CORL.HasValue)
				request.WithQueryParameter("CORL", m3CORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COCH.HasValue)
				request.WithQueryParameter("COCH", m3COCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COTX.HasValue)
				request.WithQueryParameter("COTX", m3COTX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CLCH.HasValue)
				request.WithQueryParameter("CLCH", m3CLCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CLTX.HasValue)
				request.WithQueryParameter("CLTX", m3CLTX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CADR.HasValue)
				request.WithQueryParameter("CADR", m3CADR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3UCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JDCD.HasValue)
				request.WithQueryParameter("JDCD", m3JDCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3RLDT.Value.ToM3String());
			if (m3CODT.HasValue)
				request.WithQueryParameter("CODT", m3CODT.Value.ToM3String());
			if (m3EPRI.HasValue)
				request.WithQueryParameter("EPRI", m3EPRI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<CpyOrderResponse>(
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
		/// Name DelBatchHead
		/// Description Delete batch order head record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBatchHead(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

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
		/// Name DelBatchLine
		/// Description Delete batch order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Temporary order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBatchLine(
			string m3ORNO, 
			string m3PONR, 
			int? m3CONO = null, 
			string m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());

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
		/// Name DelBatchSalespe
		/// Description Delete Batch Salesperson
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORNO">Temporary order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3SMCD">Salesperson (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBatchSalespe(
			string m3ORNO, 
			int m3PONR, 
			string m3SMCD, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelBatchSalespe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3SMCD))
				throw new ArgumentNullException(nameof(m3SMCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SMCD", m3SMCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelBatchText
		/// Description Delete text for head/line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3TYPE">Order head or line, 1=Head/2=Line (Required)</param>
		/// <param name="m3TYTR">Type of text, 1=Pre/2=Post/3=F6 (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3TXHE">Document class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBatchText(
			string m3ORNO, 
			string m3TYPE, 
			string m3TYTR, 
			int? m3CONO = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3TXHE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelBatchText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3TYPE))
				throw new ArgumentNullException(nameof(m3TYPE));
			if (string.IsNullOrWhiteSpace(m3TYTR))
				throw new ArgumentNullException(nameof(m3TYTR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("TYPE", m3TYPE.Trim())
				.WithQueryParameter("TYTR", m3TYTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXHE))
				request.WithQueryParameter("TXHE", m3TXHE.Trim());

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
		/// Name DelConnCOCharge
		/// Description Delete Connected CO Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CRID">Charge (Required)</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelConnCOCharge(
			string m3ORNO, 
			string m3CRID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelConnCOCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3CRID))
				throw new ArgumentNullException(nameof(m3CRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("CRID", m3CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelDocument
		/// Description Delete Connected Document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDocument(
			string m3ORNO = null, 
			string m3DONR = null, 
			string m3DOVA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelDocument",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());

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
		/// Name DelHead
		/// Description Delete order head record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelHead(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

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
		/// Name DelLine
		/// Description Delete order line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3OT65">Statistics - lost sales</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLine(
			string m3ORNO, 
			string m3PONR, 
			int? m3CONO = null, 
			string m3POSX = null, 
			int? m3OT65 = null, 
			string m3RSCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());
			if (m3OT65.HasValue)
				request.WithQueryParameter("OT65", m3OT65.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());

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
		/// Name DelLineBatchEnt
		/// Description Delete CO line on an existing order via batch order entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelLineBatchEntResponse></returns>
		/// <exception cref="M3Exception<DelLineBatchEntResponse>"></exception>
		public async Task<M3Response<DelLineBatchEntResponse>> DelLineBatchEnt(
			string m3ORNO, 
			string m3PONR, 
			int? m3CONO = null, 
			string m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelLineBatchEnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());

			// Execute the request
			var result = await Execute<DelLineBatchEntResponse>(
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
		/// Name DelLineManRe
		/// Description Delete manual rebate record
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLineManRe(
			int m3CONO, 
			string m3ORNO, 
			int m3PONR, 
			int m3POSX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelLineManRe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltBatchLnInfo
		/// Description Delet additional information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltBatchLnInfo(
			string m3ORNO, 
			string m3PONR, 
			string m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltBatchLnInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());

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
		/// Name DltLnInfo
		/// Description Delet additional information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLnInfo(
			string m3ORNO, 
			string m3PONR, 
			string m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltLnInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());

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
		/// Name GetATP
		/// Description Calculate ATP for given item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetATPResponse></returns>
		/// <exception cref="M3Exception<GetATPResponse>"></exception>
		public async Task<M3Response<GetATPResponse>> GetATP(
			string m3ITNO, 
			string m3WHLO, 
			int? m3CONO = null, 
			DateTime? m3DWDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetATP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetATPResponse>(
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
		/// Name GetAddrVreg
		/// Description Get adress and VAT-no
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3QLFI">Qualifier (Required)</param>
		/// <param name="m3QLFV">Value for qualifier (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddrVregResponse></returns>
		/// <exception cref="M3Exception<GetAddrVregResponse>"></exception>
		public async Task<M3Response<GetAddrVregResponse>> GetAddrVreg(
			string m3QLFI, 
			string m3QLFV, 
			int? m3CONO = null, 
			string m3ORNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAddrVreg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QLFI))
				throw new ArgumentNullException(nameof(m3QLFI));
			if (string.IsNullOrWhiteSpace(m3QLFV))
				throw new ArgumentNullException(nameof(m3QLFV));

			// Set mandatory parameters
			request
				.WithQueryParameter("QLFI", m3QLFI.Trim())
				.WithQueryParameter("QLFV", m3QLFV.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Execute the request
			var result = await Execute<GetAddrVregResponse>(
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
		/// Name GetAddress
		/// Description Get address for customer order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			string m3ORNO, 
			int m3ADRT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAddressResponse>(
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
		/// Name GetBatchHead
		/// Description Retrieve batch order head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchHeadResponse></returns>
		/// <exception cref="M3Exception<GetBatchHeadResponse>"></exception>
		public async Task<M3Response<GetBatchHeadResponse>> GetBatchHead(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBatchHeadResponse>(
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
		/// Name GetBatchLine
		/// Description Retrieve batch order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Temporary ordernumber (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchLineResponse></returns>
		/// <exception cref="M3Exception<GetBatchLineResponse>"></exception>
		public async Task<M3Response<GetBatchLineResponse>> GetBatchLine(
			string m3ORNO, 
			string m3PONR, 
			int? m3CONO = null, 
			string m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());

			// Execute the request
			var result = await Execute<GetBatchLineResponse>(
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
		/// Name GetBatchLnInfo
		/// Description Retrieve batch order line additional information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ORNO">Temporary ordernumber (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchLnInfoResponse></returns>
		/// <exception cref="M3Exception<GetBatchLnInfoResponse>"></exception>
		public async Task<M3Response<GetBatchLnInfoResponse>> GetBatchLnInfo(
			string m3ORNO, 
			int m3PONR, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBatchLnInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBatchLnInfoResponse>(
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
		/// Name GetBatchQuot
		/// Description Get quotation information for an order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchQuotResponse></returns>
		/// <exception cref="M3Exception<GetBatchQuotResponse>"></exception>
		public async Task<M3Response<GetBatchQuotResponse>> GetBatchQuot(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBatchQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBatchQuotResponse>(
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
		/// Name GetConfigData
		/// Description Get configuration data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetConfigDataResponse></returns>
		/// <exception cref="M3Exception<GetConfigDataResponse>"></exception>
		public async Task<M3Response<GetConfigDataResponse>> GetConfigData(
			string m3ITNO, 
			int? m3CONO = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetConfigData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<GetConfigDataResponse>(
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
		/// Name GetDelHeadChrg
		/// Description Retrieve charges connected to Delivery Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3CRID">Charge (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelHeadChrgResponse></returns>
		/// <exception cref="M3Exception<GetDelHeadChrgResponse>"></exception>
		public async Task<M3Response<GetDelHeadChrgResponse>> GetDelHeadChrg(
			string m3ORNO, 
			decimal m3DLIX, 
			string m3CRID, 
			string m3WHLO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDelHeadChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3CRID))
				throw new ArgumentNullException(nameof(m3CRID));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CRID", m3CRID.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDelHeadChrgResponse>(
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
		/// Name GetDocClasses
		/// Description Retrieves document classes for customer order
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3FLDN">Field number</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3KFLD">File key</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDocClassesResponse></returns>
		/// <exception cref="M3Exception<GetDocClassesResponse>"></exception>
		public async Task<M3Response<GetDocClassesResponse>> GetDocClasses(
			string m3FLDN = null, 
			string m3LNCD = null, 
			string m3FILE = null, 
			string m3KFLD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDocClasses",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FLDN))
				request.WithQueryParameter("FLDN", m3FLDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3KFLD))
				request.WithQueryParameter("KFLD", m3KFLD.Trim());

			// Execute the request
			var result = await Execute<GetDocClassesResponse>(
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
		/// Name GetDocument
		/// Description Get Connected Document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDocumentResponse></returns>
		/// <exception cref="M3Exception<GetDocumentResponse>"></exception>
		public async Task<M3Response<GetDocumentResponse>> GetDocument(
			string m3ORNO = null, 
			string m3DONR = null, 
			string m3DOVA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDocument",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());

			// Execute the request
			var result = await Execute<GetDocumentResponse>(
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
		/// Name GetHead
		/// Description Retrieve customer order head information
		/// Version Release: 5eaC
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetHeadText
		/// Description Retrieve text associated with the order head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TYTR">Type of text, 1=Pre/2=Post</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadTextResponse></returns>
		/// <exception cref="M3Exception<GetHeadTextResponse>"></exception>
		public async Task<M3Response<GetHeadTextResponse>> GetHeadText(
			string m3ORNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			string m3TYTR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHeadText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TYTR))
				request.WithQueryParameter("TYTR", m3TYTR.Trim());

			// Execute the request
			var result = await Execute<GetHeadTextResponse>(
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
		/// Name GetLine
		/// Description Retrieve customer order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3ORNO, 
			string m3PONR, 
			int? m3CONO = null, 
			string m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());

			// Execute the request
			var result = await Execute<GetLineResponse>(
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
		/// Name GetLine2
		/// Description Retrieve customer order line part 2
		/// Version Release: 5eaB
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLine2Response></returns>
		/// <exception cref="M3Exception<GetLine2Response>"></exception>
		public async Task<M3Response<GetLine2Response>> GetLine2(
			string m3ORNO, 
			int m3PONR, 
			int? m3CONO = null, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLine2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetLine2Response>(
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
		/// Name GetLineAddress
		/// Description Retrieve CO Line address.
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PONR">Order line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineAddressResponse></returns>
		/// <exception cref="M3Exception<GetLineAddressResponse>"></exception>
		public async Task<M3Response<GetLineAddressResponse>> GetLineAddress(
			string m3ORNO, 
			int? m3CONO = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLineAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetLineAddressResponse>(
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
		/// Name GetLineChrg
		/// Description Retrieve line charges connected to order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3CRID">Charge (Required)</param>
		/// <param name="m3CRTY">Internal charge (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineChrgResponse></returns>
		/// <exception cref="M3Exception<GetLineChrgResponse>"></exception>
		public async Task<M3Response<GetLineChrgResponse>> GetLineChrg(
			string m3ORNO, 
			int m3PONR, 
			int m3POSX, 
			string m3CRID, 
			int m3CRTY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLineChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3CRID))
				throw new ArgumentNullException(nameof(m3CRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CRID", m3CRID.Trim())
				.WithQueryParameter("CRTY", m3CRTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetLineChrgResponse>(
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
		/// Name GetLineChrgTot
		/// Description GetLineChrgTot
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineChrgTotResponse></returns>
		/// <exception cref="M3Exception<GetLineChrgTotResponse>"></exception>
		public async Task<M3Response<GetLineChrgTotResponse>> GetLineChrgTot(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLineChrgTot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Execute the request
			var result = await Execute<GetLineChrgTotResponse>(
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
		/// Name GetLineManRe
		/// Description Retrieve manual rebate connected the order line
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineManReResponse></returns>
		/// <exception cref="M3Exception<GetLineManReResponse>"></exception>
		public async Task<M3Response<GetLineManReResponse>> GetLineManRe(
			int m3CONO, 
			string m3ORNO, 
			int m3PONR, 
			int m3POSX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLineManRe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetLineManReResponse>(
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
		/// Name GetLinePurch
		/// Description Get purchase info of order line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLinePurchResponse></returns>
		/// <exception cref="M3Exception<GetLinePurchResponse>"></exception>
		public async Task<M3Response<GetLinePurchResponse>> GetLinePurch(
			string m3ORNO, 
			string m3PONR, 
			int? m3CONO = null, 
			string m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLinePurch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());

			// Execute the request
			var result = await Execute<GetLinePurchResponse>(
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
		/// Name GetLineText
		/// Description Retrieve text associated with the order line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3TYTR">Type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineTextResponse></returns>
		/// <exception cref="M3Exception<GetLineTextResponse>"></exception>
		public async Task<M3Response<GetLineTextResponse>> GetLineText(
			string m3ORNO, 
			string m3PONR, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			string m3POSX = null, 
			string m3TYTR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLineText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());
			if (!string.IsNullOrWhiteSpace(m3TYTR))
				request.WithQueryParameter("TYTR", m3TYTR.Trim());

			// Execute the request
			var result = await Execute<GetLineTextResponse>(
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
		/// Name GetLnInfo
		/// Description Retrieve batch order line additional information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ORNO">Temporary ordernumber (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLnInfoResponse></returns>
		/// <exception cref="M3Exception<GetLnInfoResponse>"></exception>
		public async Task<M3Response<GetLnInfoResponse>> GetLnInfo(
			string m3ORNO, 
			int m3PONR, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLnInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetLnInfoResponse>(
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
		/// Name GetMapping
		/// Description Map the input fields to the M3/CAT fields
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMappingResponse></returns>
		/// <exception cref="M3Exception<GetMappingResponse>"></exception>
		public async Task<M3Response<GetMappingResponse>> GetMapping(
			int? m3CONO = null, 
			string m3CUNO = null, 
			string m3FACI = null, 
			string m3ORTP = null, 
			string m3MODL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMapping",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());

			// Execute the request
			var result = await Execute<GetMappingResponse>(
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
		/// Name GetNextDlyDate
		/// Description Get Next Delivery Date
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetNextDlyDateResponse></returns>
		/// <exception cref="M3Exception<GetNextDlyDateResponse>"></exception>
		public async Task<M3Response<GetNextDlyDateResponse>> GetNextDlyDate(
			string m3ORNO, 
			int m3PONR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetNextDlyDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetNextDlyDateResponse>(
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
		/// Name GetOrderNo
		/// Description Get Order no from batch order no
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Temporary order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderNoResponse></returns>
		/// <exception cref="M3Exception<GetOrderNoResponse>"></exception>
		public async Task<M3Response<GetOrderNoResponse>> GetOrderNo(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOrderNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetOrderNoResponse>(
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
		/// Name GetOrderPromise
		/// Description Get ordered to promise
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ORQT">Ordered quantity (Required)</param>
		/// <param name="m3DWDT">Requested delivery date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderPromiseResponse></returns>
		/// <exception cref="M3Exception<GetOrderPromiseResponse>"></exception>
		public async Task<M3Response<GetOrderPromiseResponse>> GetOrderPromise(
			string m3ITNO, 
			decimal m3ORQT, 
			DateTime m3DWDT, 
			int? m3CONO = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOrderPromise",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ORQT", m3ORQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DWDT", m3DWDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<GetOrderPromiseResponse>(
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
		/// Name GetOrderType
		/// Description Displays order type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderTypeResponse></returns>
		/// <exception cref="M3Exception<GetOrderTypeResponse>"></exception>
		public async Task<M3Response<GetOrderTypeResponse>> GetOrderType(
			string m3CUNO = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOrderType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<GetOrderTypeResponse>(
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
		/// Name GetOrderValue
		/// Description Retrieve order value information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderValueResponse></returns>
		/// <exception cref="M3Exception<GetOrderValueResponse>"></exception>
		public async Task<M3Response<GetOrderValueResponse>> GetOrderValue(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOrderValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetOrderValueResponse>(
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
		/// Name GetPanelSeq
		/// Description Get panel sequence
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3HEAD">Only panels for OIS100</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPanelSeqResponse></returns>
		/// <exception cref="M3Exception<GetPanelSeqResponse>"></exception>
		public async Task<M3Response<GetPanelSeqResponse>> GetPanelSeq(
			string m3ORTP = null, 
			string m3RESP = null, 
			string m3HEAD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPanelSeq",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3HEAD))
				request.WithQueryParameter("HEAD", m3HEAD.Trim());

			// Execute the request
			var result = await Execute<GetPanelSeqResponse>(
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
		/// Name GetQuot
		/// Description Get quotation information for an order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQuotResponse></returns>
		/// <exception cref="M3Exception<GetQuotResponse>"></exception>
		public async Task<M3Response<GetQuotResponse>> GetQuot(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetQuotResponse>(
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
		/// Description Retrieves text for a customer order
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3FLDN">Field number</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3KFLD">File key</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTextResponse></returns>
		/// <exception cref="M3Exception<GetTextResponse>"></exception>
		public async Task<M3Response<GetTextResponse>> GetText(
			string m3FLDN = null, 
			string m3TXVR = null, 
			string m3LNCD = null, 
			string m3FILE = null, 
			string m3KFLD = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FLDN))
				request.WithQueryParameter("FLDN", m3FLDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3KFLD))
				request.WithQueryParameter("KFLD", m3KFLD.Trim());

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
		/// Name LockOrder
		/// Description Sales Desk - Lock order by changing OAHOCD to 9
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> LockOrder(
			int? m3CONO = null, 
			string m3ORNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LockOrder",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());

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
		/// Name LstBLInByPurAgr
		/// Description LstLine
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3ORSL">Lowest status - customer order</param>
		/// <param name="m3ORST">Highest status - customer order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBLInByPurAgrResponse></returns>
		/// <exception cref="M3Exception<LstBLInByPurAgrResponse>"></exception>
		public async Task<M3Response<LstBLInByPurAgrResponse>> LstBLInByPurAgr(
			string m3SUNO, 
			string m3AGNB, 
			int m3SEQN, 
			string m3ORSL = null, 
			string m3ORST = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBLInByPurAgr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORSL))
				request.WithQueryParameter("ORSL", m3ORSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORST))
				request.WithQueryParameter("ORST", m3ORST.Trim());

			// Execute the request
			var result = await Execute<LstBLInByPurAgrResponse>(
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
		/// Name LstBatchHead
		/// Description Retrieve customer order head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORSL">Order status from</param>
		/// <param name="m3ORST">Order status to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBatchHeadResponse></returns>
		/// <exception cref="M3Exception<LstBatchHeadResponse>"></exception>
		public async Task<M3Response<LstBatchHeadResponse>> LstBatchHead(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3ORSL = null, 
			string m3ORST = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORSL))
				request.WithQueryParameter("ORSL", m3ORSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORST))
				request.WithQueryParameter("ORST", m3ORST.Trim());

			// Execute the request
			var result = await Execute<LstBatchHeadResponse>(
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
		/// Name LstBatchLine
		/// Description List all order lines for given batch order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Temporary ordernumber (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBatchLineResponse></returns>
		/// <exception cref="M3Exception<LstBatchLineResponse>"></exception>
		public async Task<M3Response<LstBatchLineResponse>> LstBatchLine(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstBatchLineResponse>(
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
		/// Name LstCOLineInfo
		/// Description Lists CO line information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3COSF">Cost factor</param>
		/// <param name="m3LORD">Order lines in descending order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCOLineInfoResponse></returns>
		/// <exception cref="M3Exception<LstCOLineInfoResponse>"></exception>
		public async Task<M3Response<LstCOLineInfoResponse>> LstCOLineInfo(
			string m3ORNO = null, 
			int? m3COSF = null, 
			string m3LORD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCOLineInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3COSF.HasValue)
				request.WithQueryParameter("COSF", m3COSF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LORD))
				request.WithQueryParameter("LORD", m3LORD.Trim());

			// Execute the request
			var result = await Execute<LstCOLineInfoResponse>(
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
		/// Name LstConnCOCharge
		/// Description List Connected CO Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConnCOChargeResponse></returns>
		/// <exception cref="M3Exception<LstConnCOChargeResponse>"></exception>
		public async Task<M3Response<LstConnCOChargeResponse>> LstConnCOCharge(
			string m3ORNO, 
			decimal? m3DLIX = null, 
			string m3CRID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstConnCOCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CRID))
				request.WithQueryParameter("CRID", m3CRID.Trim());

			// Execute the request
			var result = await Execute<LstConnCOChargeResponse>(
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
		/// Name LstDelLineByCO
		/// Description List Delivery Lines By CO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelLineByCOResponse></returns>
		/// <exception cref="M3Exception<LstDelLineByCOResponse>"></exception>
		public async Task<M3Response<LstDelLineByCOResponse>> LstDelLineByCO(
			string m3ORNO, 
			int m3PONR, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDelLineByCO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDelLineByCOResponse>(
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
		/// Name LstDlyDates
		/// Description List Delivery Dates
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3NUM2">Number of Confirmed delivery dates</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDlyDatesResponse></returns>
		/// <exception cref="M3Exception<LstDlyDatesResponse>"></exception>
		public async Task<M3Response<LstDlyDatesResponse>> LstDlyDates(
			string m3ORNO, 
			int m3PONR, 
			int? m3NUM2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDlyDates",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3NUM2.HasValue)
				request.WithQueryParameter("NUM2", m3NUM2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDlyDatesResponse>(
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
		/// Name LstDocument
		/// Description List Connected documents
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDocumentResponse></returns>
		/// <exception cref="M3Exception<LstDocumentResponse>"></exception>
		public async Task<M3Response<LstDocumentResponse>> LstDocument(
			string m3ORNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDocument",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Execute the request
			var result = await Execute<LstDocumentResponse>(
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
		/// Name LstErrMsgOrder
		/// Description List error messages on order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Temporary order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrMsgOrderResponse></returns>
		/// <exception cref="M3Exception<LstErrMsgOrderResponse>"></exception>
		public async Task<M3Response<LstErrMsgOrderResponse>> LstErrMsgOrder(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstErrMsgOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstErrMsgOrderResponse>(
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
		/// Name LstHead
		/// Description Retrieve customer order head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORSL">Order status from</param>
		/// <param name="m3ORST">Order status to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadResponse></returns>
		/// <exception cref="M3Exception<LstHeadResponse>"></exception>
		public async Task<M3Response<LstHeadResponse>> LstHead(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3ORSL = null, 
			string m3ORST = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORSL))
				request.WithQueryParameter("ORSL", m3ORSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORST))
				request.WithQueryParameter("ORST", m3ORST.Trim());

			// Execute the request
			var result = await Execute<LstHeadResponse>(
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
		/// Name LstHeadText
		/// Description Retrieve text associated with the order head
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3TYTR">Type of text, 1=Pre/2=Post/3=General (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TXV9">Text block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadTextResponse></returns>
		/// <exception cref="M3Exception<LstHeadTextResponse>"></exception>
		public async Task<M3Response<LstHeadTextResponse>> LstHeadText(
			string m3ORNO, 
			string m3TYTR, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			string m3TXV9 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstHeadText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3TYTR))
				throw new ArgumentNullException(nameof(m3TYTR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("TYTR", m3TYTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXV9))
				request.WithQueryParameter("TXV9", m3TXV9.Trim());

			// Execute the request
			var result = await Execute<LstHeadTextResponse>(
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
		/// Name LstItmAltQty
		/// Description Lists Item alternate quantity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3CHL1">Business chain - level 1</param>
		/// <param name="m3CHL2">Business chain - level 2</param>
		/// <param name="m3CHL3">Business chain - level 3</param>
		/// <param name="m3CHL4">Business chain - level 4</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmAltQtyResponse></returns>
		/// <exception cref="M3Exception<LstItmAltQtyResponse>"></exception>
		public async Task<M3Response<LstItmAltQtyResponse>> LstItmAltQty(
			string m3ITNO = null, 
			string m3WHLO = null, 
			string m3CUNO = null, 
			string m3ORTP = null, 
			string m3TEPA = null, 
			string m3CHL1 = null, 
			string m3CHL2 = null, 
			string m3CHL3 = null, 
			string m3CHL4 = null, 
			string m3ADID = null, 
			decimal? m3TRQT = null, 
			string m3ALUN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItmAltQty",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL1))
				request.WithQueryParameter("CHL1", m3CHL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL2))
				request.WithQueryParameter("CHL2", m3CHL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL3))
				request.WithQueryParameter("CHL3", m3CHL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHL4))
				request.WithQueryParameter("CHL4", m3CHL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());

			// Execute the request
			var result = await Execute<LstItmAltQtyResponse>(
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
		/// Name LstLine
		/// Description List all order lines for given customer order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Ordernumber (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORST">Highest status - customer order</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3ORNO, 
			int? m3CONO = null, 
			string m3ORST = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORST))
				request.WithQueryParameter("ORST", m3ORST.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
		/// Name LstLine2
		/// Description List all order lines for given customer order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Ordernumber (Required)</param>
		/// <param name="m3ORST">Highest status - customer order</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLine2Response></returns>
		/// <exception cref="M3Exception<LstLine2Response>"></exception>
		public async Task<M3Response<LstLine2Response>> LstLine2(
			string m3ORNO, 
			string m3ORST = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLine2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORST))
				request.WithQueryParameter("ORST", m3ORST.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstLine2Response>(
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
		/// Name LstLineBOD
		/// Description List all order lines for given customer order.
		/// Version Release: 5eaB
		/// </summary>
		/// <param name="m3ORNO">Ordernumber (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORST">Highest status - customer order</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineBODResponse></returns>
		/// <exception cref="M3Exception<LstLineBODResponse>"></exception>
		public async Task<M3Response<LstLineBODResponse>> LstLineBOD(
			string m3ORNO, 
			int? m3CONO = null, 
			string m3ORST = null, 
			string m3ITNO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLineBOD",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORST))
				request.WithQueryParameter("ORST", m3ORST.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLineBODResponse>(
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
		/// Name LstLineByKitLvl
		/// Description List orderline by kitlevel
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3KTLV">Kitlevel, 0=Kitmother, 1= Kitcomponents (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineByKitLvlResponse></returns>
		/// <exception cref="M3Exception<LstLineByKitLvlResponse>"></exception>
		public async Task<M3Response<LstLineByKitLvlResponse>> LstLineByKitLvl(
			string m3ORNO, 
			string m3KTLV, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLineByKitLvl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3KTLV))
				throw new ArgumentNullException(nameof(m3KTLV));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("KTLV", m3KTLV.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLineByKitLvlResponse>(
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
		/// Name LstLineCharge
		/// Description LstLineCharge
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineChargeResponse></returns>
		/// <exception cref="M3Exception<LstLineChargeResponse>"></exception>
		public async Task<M3Response<LstLineChargeResponse>> LstLineCharge(
			string m3ORNO, 
			int m3PONR, 
			int? m3POSX = null, 
			string m3CRID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLineCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CRID))
				request.WithQueryParameter("CRID", m3CRID.Trim());

			// Execute the request
			var result = await Execute<LstLineChargeResponse>(
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
		/// Name LstLinePurch
		/// Description List purchase info of all order lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Ordernumber (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORST">Highest status - customer order</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLinePurchResponse></returns>
		/// <exception cref="M3Exception<LstLinePurchResponse>"></exception>
		public async Task<M3Response<LstLinePurchResponse>> LstLinePurch(
			string m3ORNO, 
			int? m3CONO = null, 
			string m3ORST = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLinePurch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORST))
				request.WithQueryParameter("ORST", m3ORST.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstLinePurchResponse>(
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
		/// Name LstLineText
		/// Description Retrieve text associated with the order line
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3TYTR">Type of text, 1=Pre/2=Post (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3TXV9">Text block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineTextResponse></returns>
		/// <exception cref="M3Exception<LstLineTextResponse>"></exception>
		public async Task<M3Response<LstLineTextResponse>> LstLineText(
			string m3ORNO, 
			string m3PONR, 
			string m3TYTR, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			string m3POSX = null, 
			string m3TXV9 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLineText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PONR))
				throw new ArgumentNullException(nameof(m3PONR));
			if (string.IsNullOrWhiteSpace(m3TYTR))
				throw new ArgumentNullException(nameof(m3TYTR));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.Trim())
				.WithQueryParameter("TYTR", m3TYTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3POSX))
				request.WithQueryParameter("POSX", m3POSX.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXV9))
				request.WithQueryParameter("TXV9", m3TXV9.Trim());

			// Execute the request
			var result = await Execute<LstLineTextResponse>(
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
		/// Name LstLinesByItem
		/// Description List orderlines sorted by item number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3ORST">Order status to (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLinesByItemResponse></returns>
		/// <exception cref="M3Exception<LstLinesByItemResponse>"></exception>
		public async Task<M3Response<LstLinesByItemResponse>> LstLinesByItem(
			string m3CUNO, 
			string m3ORST, 
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLinesByItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3ORST))
				throw new ArgumentNullException(nameof(m3ORST));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ORST", m3ORST.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLinesByItemResponse>(
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
		/// Name LstNewBalances
		/// Description List new and changed warehouse balances based on LMTS
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNewBalancesResponse></returns>
		/// <exception cref="M3Exception<LstNewBalancesResponse>"></exception>
		public async Task<M3Response<LstNewBalancesResponse>> LstNewBalances(
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstNewBalances",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstNewBalancesResponse>(
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
		/// Name LstOrderCharge
		/// Description List order charges
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOrderChargeResponse></returns>
		/// <exception cref="M3Exception<LstOrderChargeResponse>"></exception>
		public async Task<M3Response<LstOrderChargeResponse>> LstOrderCharge(
			string m3ORNO, 
			string m3CRID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOrderCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CRID))
				request.WithQueryParameter("CRID", m3CRID.Trim());

			// Execute the request
			var result = await Execute<LstOrderChargeResponse>(
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
		/// Name LstOrderTypes
		/// Description Retrieve order types for given company
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOrderTypesResponse></returns>
		/// <exception cref="M3Exception<LstOrderTypesResponse>"></exception>
		public async Task<M3Response<LstOrderTypesResponse>> LstOrderTypes(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOrderTypes",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstOrderTypesResponse>(
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
		/// Name LstQuot
		/// Description List batch quotations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuotResponse></returns>
		/// <exception cref="M3Exception<LstQuotResponse>"></exception>
		public async Task<M3Response<LstQuotResponse>> LstQuot(
			string m3CUNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstQuotResponse>(
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
		/// Name LstWarehBalance
		/// Description Retrieve warehouse balance for given item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWarehBalanceResponse></returns>
		/// <exception cref="M3Exception<LstWarehBalanceResponse>"></exception>
		public async Task<M3Response<LstWarehBalanceResponse>> LstWarehBalance(
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstWarehBalance",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstWarehBalanceResponse>(
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
		/// Name ReleaseOrder
		/// Description Sales Desk - Release order by changing OAHOCD to 0
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReleaseOrder(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ReleaseOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

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
		/// Name RetrOrderNo
		/// Description Sales Desk - Retrieve customer order number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORTP">Customer order type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RetrOrderNoResponse></returns>
		/// <exception cref="M3Exception<RetrOrderNoResponse>"></exception>
		public async Task<M3Response<RetrOrderNoResponse>> RetrOrderNo(
			string m3ORTP, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RetrOrderNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORTP))
				throw new ArgumentNullException(nameof(m3ORTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORTP", m3ORTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<RetrOrderNoResponse>(
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
		/// Name SearchHead
		/// Description Search order heads
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchHeadResponse></returns>
		/// <exception cref="M3Exception<SearchHeadResponse>"></exception>
		public async Task<M3Response<SearchHeadResponse>> SearchHead(
			string m3SQRY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchHeadResponse>(
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
		/// Name SearchLine
		/// Description Search order lines
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchLineResponse></returns>
		/// <exception cref="M3Exception<SearchLineResponse>"></exception>
		public async Task<M3Response<SearchLineResponse>> SearchLine(
			string m3SQRY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchLineResponse>(
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
		/// Name SearchQuotation
		/// Description Search quotation
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchQuotationResponse></returns>
		/// <exception cref="M3Exception<SearchQuotationResponse>"></exception>
		public async Task<M3Response<SearchQuotationResponse>> SearchQuotation(
			string m3SQRY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchQuotation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchQuotationResponse>(
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
		/// Name SndBatchLine
		/// Description Add batch order line without answer
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Temporary order number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORQT">Ordered quantity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3JDCD">Joint delivery code</param>
		/// <param name="m3CUPO">Customers order line number</param>
		/// <param name="m3SAPR">Salesprice</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3DIA2">Discount amount 2</param>
		/// <param name="m3DIA3">Discount amount 3</param>
		/// <param name="m3DIA4">Discount amount 4</param>
		/// <param name="m3DIA5">Discount amount 5</param>
		/// <param name="m3DIA6">Discount amount 6</param>
		/// <param name="m3DLSP">Delivery specification</param>
		/// <param name="m3DLSX">Delivery specification text</param>
		/// <param name="m3CFXX">Old CFIN</param>
		/// <param name="m3ECVS">Simulations number</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3CODT">Confirmed date of delivery</param>
		/// <param name="m3ITDS">Item description</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUPA">Customers packaging identity</param>
		/// <param name="m3DWHM">Requested delivery time</param>
		/// <param name="m3D1QT">Standard quantity</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3SPUN">Sales price unit of measure</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3TIZO">Time zone</param>
		/// <param name="m3EDFP">Reference price</param>
		/// <param name="m3AGNO">Blanket agreement number</param>
		/// <param name="m3DWDZ">Requested delivery date</param>
		/// <param name="m3DWHZ">Requested delivery time</param>
		/// <param name="m3COHM">Confirmed delivery time</param>
		/// <param name="m3CODZ">Confirmed delivery date</param>
		/// <param name="m3COHZ">Confirmed delivery time</param>
		/// <param name="m3HDPR">Main product</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3CUSX">Line suffix</param>
		/// <param name="m3DIC1">Status - discount</param>
		/// <param name="m3DIC2">Status - discount</param>
		/// <param name="m3DIC3">Status - discount</param>
		/// <param name="m3DIC4">Status - discount</param>
		/// <param name="m3DIC5">Status - discount</param>
		/// <param name="m3DIC6">Status - discount</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3BANO">Batch no</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3DIP1">Discount 1</param>
		/// <param name="m3DIP2">Discount 2</param>
		/// <param name="m3DIP3">Discount 3</param>
		/// <param name="m3DIP4">Discount 4</param>
		/// <param name="m3DIP5">Discount 5</param>
		/// <param name="m3DIP6">Discount 6</param>
		/// <param name="m3CMNO">Sales campaign</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3PRHL">Product number highest level</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3GWTP">Granted warranty type</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3PRHW">Product number highest level</param>
		/// <param name="m3SERW">Serial number</param>
		/// <param name="m3PWNR">Order line number</param>
		/// <param name="m3PWSX">Line suffix</param>
		/// <param name="m3EWST">Extended warranty start</param>
		/// <param name="m3TECN">Tax exemption contract number</param>
		/// <param name="m3INAP">Industry Application</param>
		/// <param name="m3DRDN">Demand order number</param>
		/// <param name="m3DRDL">Demand order line</param>
		/// <param name="m3DRDX">Line suffix</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3PIDE">Promotion</param>
		/// <param name="m3MCHP">Price change indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndBatchLine(
			string m3ORNO, 
			string m3ITNO, 
			int? m3CONO = null, 
			decimal? m3ORQT = null, 
			string m3WHLO = null, 
			DateTime? m3DWDT = null, 
			string m3JDCD = null, 
			string m3CUPO = null, 
			decimal? m3SAPR = null, 
			decimal? m3DIA1 = null, 
			decimal? m3DIA2 = null, 
			decimal? m3DIA3 = null, 
			decimal? m3DIA4 = null, 
			string m3DIA5 = null, 
			string m3DIA6 = null, 
			string m3DLSP = null, 
			string m3DLSX = null, 
			int? m3CFXX = null, 
			int? m3ECVS = null, 
			string m3ALUN = null, 
			DateTime? m3CODT = null, 
			string m3ITDS = null, 
			string m3ALWQ = null, 
			int? m3ALWT = null, 
			string m3CUOR = null, 
			string m3CUPA = null, 
			int? m3DWHM = null, 
			decimal? m3D1QT = null, 
			string m3PACT = null, 
			string m3POPN = null, 
			int? m3SACD = null, 
			string m3SPUN = null, 
			string m3TEPA = null, 
			string m3TIZO = null, 
			decimal? m3EDFP = null, 
			string m3AGNO = null, 
			DateTime? m3DWDZ = null, 
			int? m3DWHZ = null, 
			int? m3COHM = null, 
			DateTime? m3CODZ = null, 
			int? m3COHZ = null, 
			string m3HDPR = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3CAMU = null, 
			string m3ADID = null, 
			int? m3CUSX = null, 
			int? m3DIC1 = null, 
			int? m3DIC2 = null, 
			int? m3DIC3 = null, 
			int? m3DIC4 = null, 
			int? m3DIC5 = null, 
			int? m3DIC6 = null, 
			long? m3CFIN = null, 
			string m3BANO = null, 
			string m3WHSL = null, 
			int? m3DIP1 = null, 
			int? m3DIP2 = null, 
			int? m3DIP3 = null, 
			int? m3DIP4 = null, 
			int? m3DIP5 = null, 
			int? m3DIP6 = null, 
			string m3CMNO = null, 
			string m3RSCD = null, 
			string m3PRHL = null, 
			string m3SERN = null, 
			string m3CTNO = null, 
			string m3CFGL = null, 
			string m3GWTP = null, 
			string m3WATP = null, 
			string m3PRHW = null, 
			string m3SERW = null, 
			int? m3PWNR = null, 
			int? m3PWSX = null, 
			int? m3EWST = null, 
			string m3TECN = null, 
			string m3INAP = null, 
			string m3DRDN = null, 
			int? m3DRDL = null, 
			int? m3DRDX = null, 
			string m3TEPY = null, 
			string m3PIDE = null, 
			int? m3MCHP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3JDCD))
				request.WithQueryParameter("JDCD", m3JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPO))
				request.WithQueryParameter("CUPO", m3CUPO.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3DIA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA2.HasValue)
				request.WithQueryParameter("DIA2", m3DIA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA3.HasValue)
				request.WithQueryParameter("DIA3", m3DIA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA4.HasValue)
				request.WithQueryParameter("DIA4", m3DIA4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIA5))
				request.WithQueryParameter("DIA5", m3DIA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIA6))
				request.WithQueryParameter("DIA6", m3DIA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSP))
				request.WithQueryParameter("DLSP", m3DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLSX))
				request.WithQueryParameter("DLSX", m3DLSX.Trim());
			if (m3CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3CFXX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3ECVS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3CODT.HasValue)
				request.WithQueryParameter("CODT", m3CODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (m3DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3DWHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPUN))
				request.WithQueryParameter("SPUN", m3SPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIZO))
				request.WithQueryParameter("TIZO", m3TIZO.Trim());
			if (m3EDFP.HasValue)
				request.WithQueryParameter("EDFP", m3EDFP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNO))
				request.WithQueryParameter("AGNO", m3AGNO.Trim());
			if (m3DWDZ.HasValue)
				request.WithQueryParameter("DWDZ", m3DWDZ.Value.ToM3String());
			if (m3DWHZ.HasValue)
				request.WithQueryParameter("DWHZ", m3DWHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COHM.HasValue)
				request.WithQueryParameter("COHM", m3COHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CODZ.HasValue)
				request.WithQueryParameter("CODZ", m3CODZ.Value.ToM3String());
			if (m3COHZ.HasValue)
				request.WithQueryParameter("COHZ", m3COHZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3HDPR))
				request.WithQueryParameter("HDPR", m3HDPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3CUSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC1.HasValue)
				request.WithQueryParameter("DIC1", m3DIC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC2.HasValue)
				request.WithQueryParameter("DIC2", m3DIC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC3.HasValue)
				request.WithQueryParameter("DIC3", m3DIC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC4.HasValue)
				request.WithQueryParameter("DIC4", m3DIC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC5.HasValue)
				request.WithQueryParameter("DIC5", m3DIC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC6.HasValue)
				request.WithQueryParameter("DIC6", m3DIC6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3DIP1.HasValue)
				request.WithQueryParameter("DIP1", m3DIP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP2.HasValue)
				request.WithQueryParameter("DIP2", m3DIP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3DIP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP4.HasValue)
				request.WithQueryParameter("DIP4", m3DIP4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP5.HasValue)
				request.WithQueryParameter("DIP5", m3DIP5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP6.HasValue)
				request.WithQueryParameter("DIP6", m3DIP6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CMNO))
				request.WithQueryParameter("CMNO", m3CMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRHL))
				request.WithQueryParameter("PRHL", m3PRHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3GWTP))
				request.WithQueryParameter("GWTP", m3GWTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRHW))
				request.WithQueryParameter("PRHW", m3PRHW.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERW))
				request.WithQueryParameter("SERW", m3SERW.Trim());
			if (m3PWNR.HasValue)
				request.WithQueryParameter("PWNR", m3PWNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PWSX.HasValue)
				request.WithQueryParameter("PWSX", m3PWSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EWST.HasValue)
				request.WithQueryParameter("EWST", m3EWST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECN))
				request.WithQueryParameter("TECN", m3TECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3INAP))
				request.WithQueryParameter("INAP", m3INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DRDN))
				request.WithQueryParameter("DRDN", m3DRDN.Trim());
			if (m3DRDL.HasValue)
				request.WithQueryParameter("DRDL", m3DRDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3DRDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIDE))
				request.WithQueryParameter("PIDE", m3PIDE.Trim());
			if (m3MCHP.HasValue)
				request.WithQueryParameter("MCHP", m3MCHP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SndBatchText
		/// Description Add text for order head/line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Order number (Required)</param>
		/// <param name="m3TYPE">Order head or Line, 1=Head/2=Line (Required)</param>
		/// <param name="m3TYTR">Type of text, 1=Pre/2=Post/3=F6 (Required)</param>
		/// <param name="m3PARM">Text (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3TXHE">Document class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndBatchText(
			string m3ORNO, 
			string m3TYPE, 
			int m3TYTR, 
			string m3PARM, 
			int? m3CONO = null, 
			int? m3POSX = null, 
			string m3TXHE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndBatchText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3TYPE))
				throw new ArgumentNullException(nameof(m3TYPE));
			if (string.IsNullOrWhiteSpace(m3PARM))
				throw new ArgumentNullException(nameof(m3PARM));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("TYPE", m3TYPE.Trim())
				.WithQueryParameter("TYTR", m3TYTR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PARM", m3PARM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXHE))
				request.WithQueryParameter("TXHE", m3TXHE.Trim());

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
		/// Name UpdCnfDlyDate
		/// Description Update Confirmed Delivery Date fields in CO line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3PLDT">Planning date (Required)</param>
		/// <param name="m3PLHM">Planning time (Required)</param>
		/// <param name="m3DSDT">Departure date (Required)</param>
		/// <param name="m3DSHM">Departure time (Required)</param>
		/// <param name="m3CODT">Confirmed delivery date (Required)</param>
		/// <param name="m3COHM">Confirmed delivery time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCnfDlyDate(
			string m3ORNO, 
			int m3PONR, 
			DateTime m3PLDT, 
			int m3PLHM, 
			DateTime m3DSDT, 
			int m3DSHM, 
			DateTime m3CODT, 
			int m3COHM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdCnfDlyDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLDT", m3PLDT.ToM3String())
				.WithQueryParameter("PLHM", m3PLHM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DSDT", m3DSDT.ToM3String())
				.WithQueryParameter("DSHM", m3DSHM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CODT", m3CODT.ToM3String())
				.WithQueryParameter("COHM", m3COHM.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdConnCOCharge
		/// Description Update Connected CO Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CRID">Charge (Required)</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3CRAM">Charge amount</param>
		/// <param name="m3CRFA">Calculation factor</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3CRD0">Description language 0</param>
		/// <param name="m3CHST">Status - charge</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdConnCOCharge(
			string m3ORNO, 
			string m3CRID, 
			decimal? m3DLIX = null, 
			decimal? m3CRAM = null, 
			decimal? m3CRFA = null, 
			int? m3VTCD = null, 
			string m3ACRF = null, 
			string m3CRD0 = null, 
			string m3CHST = null, 
			string m3TAXC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdConnCOCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3CRID))
				throw new ArgumentNullException(nameof(m3CRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("CRID", m3CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRAM.HasValue)
				request.WithQueryParameter("CRAM", m3CRAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRFA.HasValue)
				request.WithQueryParameter("CRFA", m3CRFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRD0))
				request.WithQueryParameter("CRD0", m3CRD0.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHST))
				request.WithQueryParameter("CHST", m3CHST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());

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
		/// Name UpdDocument
		/// Description Update Connected Document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3NOEX">Number of copies</param>
		/// <param name="m3DOCD">Print document</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDocument(
			string m3ORNO = null, 
			string m3DONR = null, 
			string m3DOVA = null, 
			int? m3NOEX = null, 
			int? m3DOCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdDocument",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (m3NOEX.HasValue)
				request.WithQueryParameter("NOEX", m3NOEX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOCD.HasValue)
				request.WithQueryParameter("DOCD", m3DOCD.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdLineManRe
		/// Description Update manual rebate on an existing order line
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3CLAR">Supplier rebate reference number</param>
		/// <param name="m3RASR">Agreement reference number</param>
		/// <param name="m3SREA">Rebate amount</param>
		/// <param name="m3RPUN">Rebate amount - unit of measure</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLineManRe(
			int m3CONO, 
			string m3ORNO, 
			int m3PONR, 
			int m3POSX, 
			string m3SUNO = null, 
			string m3CLAR = null, 
			string m3RASR = null, 
			decimal? m3SREA = null, 
			string m3RPUN = null, 
			string m3CUCD = null, 
			string m3RESP = null, 
			string m3RFID = null, 
			string m3OREF = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdLineManRe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CLAR))
				request.WithQueryParameter("CLAR", m3CLAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASR))
				request.WithQueryParameter("RASR", m3RASR.Trim());
			if (m3SREA.HasValue)
				request.WithQueryParameter("SREA", m3SREA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPUN))
				request.WithQueryParameter("RPUN", m3RPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
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
		/// Name UpdPriceInfo
		/// Description Updates price information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3DIP1">Discount 1</param>
		/// <param name="m3DIP2">Discount 2</param>
		/// <param name="m3DIP3">Discount 3</param>
		/// <param name="m3DIP4">Discount 4</param>
		/// <param name="m3DIP5">Discount 5</param>
		/// <param name="m3DIP6">Discount 6</param>
		/// <param name="m3DIC1">Status - discount</param>
		/// <param name="m3DIC2">Status - discount</param>
		/// <param name="m3DIC3">Status - discount</param>
		/// <param name="m3DIC4">Status - discount</param>
		/// <param name="m3DIC5">Status - discount</param>
		/// <param name="m3DIC6">Status - discount</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3DIA2">Discount amount 2</param>
		/// <param name="m3DIA3">Discount amount 3</param>
		/// <param name="m3DIA4">Discount amount 4</param>
		/// <param name="m3DIA5">Discount amount 5</param>
		/// <param name="m3DIA6">Discount amount 6</param>
		/// <param name="m3UCOS">Cost price</param>
		/// <param name="m3NTCD">Net price used</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPriceInfo(
			string m3ORNO = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			decimal? m3SAPR = null, 
			int? m3DIP1 = null, 
			int? m3DIP2 = null, 
			int? m3DIP3 = null, 
			int? m3DIP4 = null, 
			int? m3DIP5 = null, 
			int? m3DIP6 = null, 
			int? m3DIC1 = null, 
			int? m3DIC2 = null, 
			int? m3DIC3 = null, 
			int? m3DIC4 = null, 
			int? m3DIC5 = null, 
			int? m3DIC6 = null, 
			decimal? m3DIA1 = null, 
			decimal? m3DIA2 = null, 
			decimal? m3DIA3 = null, 
			decimal? m3DIA4 = null, 
			decimal? m3DIA5 = null, 
			decimal? m3DIA6 = null, 
			decimal? m3UCOS = null, 
			int? m3NTCD = null, 
			int? m3SACD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPriceInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP1.HasValue)
				request.WithQueryParameter("DIP1", m3DIP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP2.HasValue)
				request.WithQueryParameter("DIP2", m3DIP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3DIP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP4.HasValue)
				request.WithQueryParameter("DIP4", m3DIP4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP5.HasValue)
				request.WithQueryParameter("DIP5", m3DIP5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP6.HasValue)
				request.WithQueryParameter("DIP6", m3DIP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC1.HasValue)
				request.WithQueryParameter("DIC1", m3DIC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC2.HasValue)
				request.WithQueryParameter("DIC2", m3DIC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC3.HasValue)
				request.WithQueryParameter("DIC3", m3DIC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC4.HasValue)
				request.WithQueryParameter("DIC4", m3DIC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC5.HasValue)
				request.WithQueryParameter("DIC5", m3DIC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIC6.HasValue)
				request.WithQueryParameter("DIC6", m3DIC6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3DIA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA2.HasValue)
				request.WithQueryParameter("DIA2", m3DIA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA3.HasValue)
				request.WithQueryParameter("DIA3", m3DIA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA4.HasValue)
				request.WithQueryParameter("DIA4", m3DIA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA5.HasValue)
				request.WithQueryParameter("DIA5", m3DIA5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIA6.HasValue)
				request.WithQueryParameter("DIA6", m3DIA6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3UCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3NTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));

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
