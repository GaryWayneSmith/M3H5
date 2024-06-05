/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBatchAddress
		/// Description Add batch order address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ADID">Address id</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUA1">Address line 1</param>
		/// <param name="m3_CUA2">Address line 2</param>
		/// <param name="m3_CUA3">Address line 3</param>
		/// <param name="m3_CUA4">Address line 4</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_PHNO">Phone number</param>
		/// <param name="m3_TFNO">Fax number</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_VRNO">VAT Registration number</param>
		/// <param name="m3_EDES">Place of load - NOT IN USE (2004.06.10)</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_ULZO">Unloading zone</param>
		/// <param name="m3_TAXC">Tax code</param>
		/// <param name="m3_ECAR">Area/State</param>
		/// <param name="m3_HAFE">Harbor or Airport</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_DSTX">Description,delivery specification</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TEL2">Terms text</param>
		/// <param name="m3_EDE2">Place of load</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_PHN2">Phone number 2</param>
		/// <param name="m3_TFN2">Facsimile transmission number 2</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_ADVI">Ship-via address</param>
		/// <param name="m3_SPLE">Standard point location code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchAddress(
			string m3_ORNO, 
			int m3_ADRT, 
			int? m3_CONO = null, 
			string m3_ADID = null, 
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_PONO = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_CSCD = null, 
			string m3_VRNO = null, 
			string m3_EDES = null, 
			string m3_ROUT = null, 
			int? m3_RODN = null, 
			string m3_ULZO = null, 
			string m3_TAXC = null, 
			string m3_ECAR = null, 
			string m3_HAFE = null, 
			string m3_YREF = null, 
			string m3_DLSP = null, 
			string m3_DSTX = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEL2 = null, 
			string m3_EDE2 = null, 
			string m3_TOWN = null, 
			string m3_PHN2 = null, 
			string m3_TFN2 = null, 
			string m3_FRCO = null, 
			string m3_RASN = null, 
			string m3_ADVI = null, 
			string m3_SPLE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("ADRT", m3_ADRT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (m3_RODN.HasValue)
				request.WithQueryParameter("RODN", m3_RODN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ULZO))
				request.WithQueryParameter("ULZO", m3_ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSTX))
				request.WithQueryParameter("DSTX", m3_DSTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL2))
				request.WithQueryParameter("TEL2", m3_TEL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDE2))
				request.WithQueryParameter("EDE2", m3_EDE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFN2))
				request.WithQueryParameter("TFN2", m3_TFN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADVI))
				request.WithQueryParameter("ADVI", m3_ADVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPLE))
				request.WithQueryParameter("SPLE", m3_SPLE.Trim());

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
		/// Name AddBatchHead
		/// Description Create new batch order head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_ORTP">Order type</param>
		/// <param name="m3_RLDT">Requested delivery date</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_AGNT">Agent</param>
		/// <param name="m3_SMCD">Salesman</param>
		/// <param name="m3_MODL">Method of delivery</param>
		/// <param name="m3_TEDL">Term of delivery</param>
		/// <param name="m3_YREF">Reference at customer</param>
		/// <param name="m3_PROJ">Project</param>
		/// <param name="m3_OTBA">Order discount amount</param>
		/// <param name="m3_TEPY">Terms of payment</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_ADID">Delivery address id</param>
		/// <param name="m3_CUCD">Currency code</param>
		/// <param name="m3_OREF">Our referens</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_TEL2">Delivery terms text</param>
		/// <param name="m3_CUDT">Customers purchase order date</param>
		/// <param name="m3_INRC">Invoice recipient</param>
		/// <param name="m3_ORDT">Order date</param>
		/// <param name="m3_RLHM">Requested delivery time</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_TIZO">Time zone</param>
		/// <param name="m3_AGNO">Blanket agreement number</param>
		/// <param name="m3_PRO2">Project</param>
		/// <param name="m3_RLDZ">Requested delivery date</param>
		/// <param name="m3_RLHZ">Requested delivery time</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_DSTX">Description of delivery specification</param>
		/// <param name="m3_TECD">Cash discount term</param>
		/// <param name="m3_PLTB">Price list table</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_WCON">Contact method</param>
		/// <param name="m3_ID01">Message identity 1</param>
		/// <param name="m3_ID02">Message identity 2</param>
		/// <param name="m3_OTDP">Total discount percentage</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_DICD">Discount origin</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_CHL1">Business chain - level 1</param>
		/// <param name="m3_CHL2">Business chain - level 2</param>
		/// <param name="m3_CHL3">Business chain - level 3</param>
		/// <param name="m3_CHL4">Business chain - level 4</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_NREF">Reference number</param>
		/// <param name="m3_TRDP">3rd party provider ID</param>
		/// <param name="m3_IPAD">IP address</param>
		/// <param name="m3_ESOV">e-Sales order value</param>
		/// <param name="m3_EXCD">Service charge</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_FRE1">Statistics identity 1 customer</param>
		/// <param name="m3_FDED">First delivery date</param>
		/// <param name="m3_LDED">Last delivery date</param>
		/// <param name="m3_BREC">Recipient agreement type 9 - bonus</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_OHEA">Only header</param>
		/// <param name="m3_CUCH">Customer channel id</param>
		/// <param name="m3_CCAC">Activity</param>
		/// <param name="m3_DECU">Delivery customer</param>
		/// <param name="m3_GCAC">Supplier ID</param>
		/// <param name="m3_PYRE">Request reference number</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_OPRI">Priority</param>
		/// <param name="m3_SPLM">Supply model</param>
		/// <param name="m3_CHSY">Line charge model</param>
		/// <param name="m3_OIVR">Original invoice reference</param>
		/// <param name="m3_OYEA">Original year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchHeadResponse></returns>
		/// <exception cref="M3Exception<AddBatchHeadResponse>"></exception>
		public async Task<M3Response<AddBatchHeadResponse>> AddBatchHead(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			string m3_ORTP = null, 
			DateTime? m3_RLDT = null, 
			string m3_FACI = null, 
			string m3_CUOR = null, 
			string m3_AGNT = null, 
			string m3_SMCD = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_YREF = null, 
			string m3_PROJ = null, 
			string m3_OTBA = null, 
			string m3_TEPY = null, 
			string m3_PYNO = null, 
			string m3_ADID = null, 
			string m3_CUCD = null, 
			string m3_OREF = null, 
			string m3_OFNO = null, 
			string m3_TEL2 = null, 
			DateTime? m3_CUDT = null, 
			string m3_INRC = null, 
			DateTime? m3_ORDT = null, 
			int? m3_RLHM = null, 
			string m3_TEPA = null, 
			string m3_TIZO = null, 
			string m3_AGNO = null, 
			string m3_PRO2 = null, 
			DateTime? m3_RLDZ = null, 
			int? m3_RLHZ = null, 
			string m3_DLSP = null, 
			string m3_DSTX = null, 
			string m3_TECD = null, 
			string m3_PLTB = null, 
			string m3_DISY = null, 
			string m3_WCON = null, 
			string m3_ID01 = null, 
			string m3_ID02 = null, 
			string m3_OTDP = null, 
			string m3_CRTP = null, 
			int? m3_DICD = null, 
			string m3_ELNO = null, 
			string m3_CHL1 = null, 
			string m3_CHL2 = null, 
			string m3_CHL3 = null, 
			string m3_CHL4 = null, 
			string m3_WHLO = null, 
			string m3_NREF = null, 
			string m3_TRDP = null, 
			string m3_IPAD = null, 
			int? m3_ESOV = null, 
			string m3_EXCD = null, 
			string m3_PYCD = null, 
			string m3_FRE1 = null, 
			DateTime? m3_FDED = null, 
			DateTime? m3_LDED = null, 
			string m3_BREC = null, 
			string m3_RESP = null, 
			int? m3_OHEA = null, 
			string m3_CUCH = null, 
			string m3_CCAC = null, 
			string m3_DECU = null, 
			string m3_GCAC = null, 
			string m3_PYRE = null, 
			string m3_BKID = null, 
			int? m3_OPRI = null, 
			string m3_SPLM = null, 
			string m3_CHSY = null, 
			string m3_OIVR = null, 
			int? m3_OYEA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (m3_RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3_RLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNT))
				request.WithQueryParameter("AGNT", m3_AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTBA))
				request.WithQueryParameter("OTBA", m3_OTBA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL2))
				request.WithQueryParameter("TEL2", m3_TEL2.Trim());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_INRC))
				request.WithQueryParameter("INRC", m3_INRC.Trim());
			if (m3_ORDT.HasValue)
				request.WithQueryParameter("ORDT", m3_ORDT.Value.ToM3String());
			if (m3_RLHM.HasValue)
				request.WithQueryParameter("RLHM", m3_RLHM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIZO))
				request.WithQueryParameter("TIZO", m3_TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNO))
				request.WithQueryParameter("AGNO", m3_AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRO2))
				request.WithQueryParameter("PRO2", m3_PRO2.Trim());
			if (m3_RLDZ.HasValue)
				request.WithQueryParameter("RLDZ", m3_RLDZ.Value.ToM3String());
			if (m3_RLHZ.HasValue)
				request.WithQueryParameter("RLHZ", m3_RLHZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSTX))
				request.WithQueryParameter("DSTX", m3_DSTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECD))
				request.WithQueryParameter("TECD", m3_TECD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTB))
				request.WithQueryParameter("PLTB", m3_PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WCON))
				request.WithQueryParameter("WCON", m3_WCON.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID01))
				request.WithQueryParameter("ID01", m3_ID01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID02))
				request.WithQueryParameter("ID02", m3_ID02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTDP))
				request.WithQueryParameter("OTDP", m3_OTDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRTP))
				request.WithQueryParameter("CRTP", m3_CRTP.Trim());
			if (m3_DICD.HasValue)
				request.WithQueryParameter("DICD", m3_DICD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL1))
				request.WithQueryParameter("CHL1", m3_CHL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL2))
				request.WithQueryParameter("CHL2", m3_CHL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL3))
				request.WithQueryParameter("CHL3", m3_CHL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL4))
				request.WithQueryParameter("CHL4", m3_CHL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NREF))
				request.WithQueryParameter("NREF", m3_NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRDP))
				request.WithQueryParameter("TRDP", m3_TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IPAD))
				request.WithQueryParameter("IPAD", m3_IPAD.Trim());
			if (m3_ESOV.HasValue)
				request.WithQueryParameter("ESOV", m3_ESOV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXCD))
				request.WithQueryParameter("EXCD", m3_EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE1))
				request.WithQueryParameter("FRE1", m3_FRE1.Trim());
			if (m3_FDED.HasValue)
				request.WithQueryParameter("FDED", m3_FDED.Value.ToM3String());
			if (m3_LDED.HasValue)
				request.WithQueryParameter("LDED", m3_LDED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_BREC))
				request.WithQueryParameter("BREC", m3_BREC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_OHEA.HasValue)
				request.WithQueryParameter("OHEA", m3_OHEA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCH))
				request.WithQueryParameter("CUCH", m3_CUCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCAC))
				request.WithQueryParameter("CCAC", m3_CCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DECU))
				request.WithQueryParameter("DECU", m3_DECU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GCAC))
				request.WithQueryParameter("GCAC", m3_GCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYRE))
				request.WithQueryParameter("PYRE", m3_PYRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (m3_OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3_OPRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPLM))
				request.WithQueryParameter("SPLM", m3_SPLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHSY))
				request.WithQueryParameter("CHSY", m3_CHSY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OIVR))
				request.WithQueryParameter("OIVR", m3_OIVR.Trim());
			if (m3_OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3_OYEA.Value.ToString());

			// Execute the request
			var result = await Execute<AddBatchHeadResponse>(
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
		/// Name AddBatchHeadChg
		/// Description Add charge to batch order head
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CRAM">Charge amount</param>
		/// <param name="m3_CRFA">Calcualtion factor</param>
		/// <param name="m3_CRD0">Description</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchHeadChg(
			string m3_ORNO, 
			string m3_CRID, 
			int? m3_CONO = null, 
			string m3_CRAM = null, 
			string m3_CRFA = null, 
			string m3_CRD0 = null, 
			string m3_TAXC = null, 
			string m3_CUCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchHeadChg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRAM))
				request.WithQueryParameter("CRAM", m3_CRAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRFA))
				request.WithQueryParameter("CRFA", m3_CRFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRD0))
				request.WithQueryParameter("CRD0", m3_CRD0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());

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
		/// Name AddBatchLine
		/// Description Add batch order line
		/// Version Release: 5eaB
		/// </summary>
		/// <param name="m3_ORNO">Temporary order number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORQT">Ordered quantity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_JDCD">Joint delivery code</param>
		/// <param name="m3_CUPO">Customers order number</param>
		/// <param name="m3_SAPR">Salesprice</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_DIA2">Discount amount 2</param>
		/// <param name="m3_DIA3">Discount amount 3</param>
		/// <param name="m3_DIA4">Discount amount 4</param>
		/// <param name="m3_DIA5">Discount amount 5</param>
		/// <param name="m3_DIA6">Discount amount 6</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_DLSX">Delivery specification text</param>
		/// <param name="m3_CFXX">Old CFIN</param>
		/// <param name="m3_ECVS">Simulations number</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_CODT">Confirmed date of delivery</param>
		/// <param name="m3_ITDS">Item description</param>
		/// <param name="m3_DIP1">Discount percent 1</param>
		/// <param name="m3_DIP2">Discount percent 2</param>
		/// <param name="m3_DIP3">Discount percent 3</param>
		/// <param name="m3_DIP4">Discount percent 4</param>
		/// <param name="m3_DIP5">Discount percent 5</param>
		/// <param name="m3_DIP6">Discount percent 6</param>
		/// <param name="m3_ALWT">Alias qualifier</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_AGNO">Blanket agreement number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUPA">Customers packaging identity</param>
		/// <param name="m3_DWHM">Requested delivery time</param>
		/// <param name="m3_D1QT">Standard quantity</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_SPUN">Sales price unit of measure</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_EDFP">EDIFACT price</param>
		/// <param name="m3_DWDZ">Requested delivery date</param>
		/// <param name="m3_DWHZ">Requested delivery time</param>
		/// <param name="m3_COHM">Confirmed delivery time</param>
		/// <param name="m3_CODZ">Confirmed delivery date</param>
		/// <param name="m3_COHZ">Confirmed delivery time</param>
		/// <param name="m3_HDPR">Main product</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_CUSX">Line suffix</param>
		/// <param name="m3_DIC1">Status - discount</param>
		/// <param name="m3_DIC2">Status - discount</param>
		/// <param name="m3_DIC3">Status - discount</param>
		/// <param name="m3_DIC4">Status - discount</param>
		/// <param name="m3_DIC5">Status - discount</param>
		/// <param name="m3_DIC6">Status - discount</param>
		/// <param name="m3_CMNO">Sales campaign</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_TEDS">Description 1</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_BANO">Batch no</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_PRHL">Product number highest level</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_GWTP">Granted warranty type</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_PRHW">Product number highest level</param>
		/// <param name="m3_SERW">Serial number</param>
		/// <param name="m3_PWNR">Order line number</param>
		/// <param name="m3_PWSX">Line suffix</param>
		/// <param name="m3_EWST">Extended warranty start</param>
		/// <param name="m3_DANR">Default attribute number</param>
		/// <param name="m3_TECN">Tax exemption contract number</param>
		/// <param name="m3_INAP">Industry Application</param>
		/// <param name="m3_DRDN">Demand order number</param>
		/// <param name="m3_DRDL">Demand order line</param>
		/// <param name="m3_DRDX">Line suffix</param>
		/// <param name="m3_PIDE">Promotion</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_LTYP">Line type</param>
		/// <param name="m3_EXH2">External order number</param>
		/// <param name="m3_EXC2">External configuration number</param>
		/// <param name="m3_MCHP">Price change indicator</param>
		/// <param name="m3_EXHE">External order number</param>
		/// <param name="m3_EXCN">External configuration number</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchLineResponse></returns>
		/// <exception cref="M3Exception<AddBatchLineResponse>"></exception>
		public async Task<M3Response<AddBatchLineResponse>> AddBatchLine(
			string m3_ORNO, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_ORQT = null, 
			string m3_WHLO = null, 
			DateTime? m3_DWDT = null, 
			string m3_JDCD = null, 
			string m3_CUPO = null, 
			string m3_SAPR = null, 
			string m3_DIA1 = null, 
			string m3_DIA2 = null, 
			string m3_DIA3 = null, 
			string m3_DIA4 = null, 
			string m3_DIA5 = null, 
			string m3_DIA6 = null, 
			string m3_DLSP = null, 
			string m3_DLSX = null, 
			int? m3_CFXX = null, 
			int? m3_ECVS = null, 
			string m3_ALUN = null, 
			DateTime? m3_CODT = null, 
			string m3_ITDS = null, 
			int? m3_DIP1 = null, 
			int? m3_DIP2 = null, 
			int? m3_DIP3 = null, 
			int? m3_DIP4 = null, 
			int? m3_DIP5 = null, 
			int? m3_DIP6 = null, 
			int? m3_ALWT = null, 
			string m3_ALWQ = null, 
			string m3_AGNO = null, 
			string m3_CAMU = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_CUOR = null, 
			string m3_CUPA = null, 
			int? m3_DWHM = null, 
			decimal? m3_D1QT = null, 
			string m3_PACT = null, 
			string m3_POPN = null, 
			int? m3_SACD = null, 
			string m3_SPUN = null, 
			string m3_TEPA = null, 
			decimal? m3_EDFP = null, 
			DateTime? m3_DWDZ = null, 
			int? m3_DWHZ = null, 
			int? m3_COHM = null, 
			DateTime? m3_CODZ = null, 
			int? m3_COHZ = null, 
			string m3_HDPR = null, 
			string m3_ADID = null, 
			int? m3_CUSX = null, 
			int? m3_DIC1 = null, 
			int? m3_DIC2 = null, 
			int? m3_DIC3 = null, 
			int? m3_DIC4 = null, 
			int? m3_DIC5 = null, 
			int? m3_DIC6 = null, 
			string m3_CMNO = null, 
			string m3_RSCD = null, 
			string m3_TEDS = null, 
			long? m3_CFIN = null, 
			string m3_BANO = null, 
			string m3_WHSL = null, 
			string m3_PRHL = null, 
			string m3_SERN = null, 
			string m3_CTNO = null, 
			string m3_CFGL = null, 
			string m3_GWTP = null, 
			string m3_WATP = null, 
			string m3_PRHW = null, 
			string m3_SERW = null, 
			int? m3_PWNR = null, 
			int? m3_PWSX = null, 
			int? m3_EWST = null, 
			decimal? m3_DANR = null, 
			string m3_TECN = null, 
			string m3_INAP = null, 
			string m3_DRDN = null, 
			int? m3_DRDL = null, 
			int? m3_DRDX = null, 
			string m3_PIDE = null, 
			string m3_TEPY = null, 
			string m3_LTYP = null, 
			string m3_EXH2 = null, 
			string m3_EXC2 = null, 
			int? m3_MCHP = null, 
			string m3_EXHE = null, 
			string m3_EXCN = null, 
			string m3_MODL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORQT))
				request.WithQueryParameter("ORQT", m3_ORQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_JDCD))
				request.WithQueryParameter("JDCD", m3_JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPO))
				request.WithQueryParameter("CUPO", m3_CUPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAPR))
				request.WithQueryParameter("SAPR", m3_SAPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA1))
				request.WithQueryParameter("DIA1", m3_DIA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA2))
				request.WithQueryParameter("DIA2", m3_DIA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA3))
				request.WithQueryParameter("DIA3", m3_DIA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA4))
				request.WithQueryParameter("DIA4", m3_DIA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA5))
				request.WithQueryParameter("DIA5", m3_DIA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA6))
				request.WithQueryParameter("DIA6", m3_DIA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSX))
				request.WithQueryParameter("DLSX", m3_DLSX.Trim());
			if (m3_CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3_CFXX.Value.ToString());
			if (m3_ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3_ECVS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_CODT.HasValue)
				request.WithQueryParameter("CODT", m3_CODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (m3_DIP1.HasValue)
				request.WithQueryParameter("DIP1", m3_DIP1.Value.ToString());
			if (m3_DIP2.HasValue)
				request.WithQueryParameter("DIP2", m3_DIP2.Value.ToString());
			if (m3_DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3_DIP3.Value.ToString());
			if (m3_DIP4.HasValue)
				request.WithQueryParameter("DIP4", m3_DIP4.Value.ToString());
			if (m3_DIP5.HasValue)
				request.WithQueryParameter("DIP5", m3_DIP5.Value.ToString());
			if (m3_DIP6.HasValue)
				request.WithQueryParameter("DIP6", m3_DIP6.Value.ToString());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNO))
				request.WithQueryParameter("AGNO", m3_AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (m3_DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3_DWHM.Value.ToString());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPUN))
				request.WithQueryParameter("SPUN", m3_SPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (m3_EDFP.HasValue)
				request.WithQueryParameter("EDFP", m3_EDFP.Value.ToString());
			if (m3_DWDZ.HasValue)
				request.WithQueryParameter("DWDZ", m3_DWDZ.Value.ToM3String());
			if (m3_DWHZ.HasValue)
				request.WithQueryParameter("DWHZ", m3_DWHZ.Value.ToString());
			if (m3_COHM.HasValue)
				request.WithQueryParameter("COHM", m3_COHM.Value.ToString());
			if (m3_CODZ.HasValue)
				request.WithQueryParameter("CODZ", m3_CODZ.Value.ToM3String());
			if (m3_COHZ.HasValue)
				request.WithQueryParameter("COHZ", m3_COHZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_HDPR))
				request.WithQueryParameter("HDPR", m3_HDPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3_CUSX.Value.ToString());
			if (m3_DIC1.HasValue)
				request.WithQueryParameter("DIC1", m3_DIC1.Value.ToString());
			if (m3_DIC2.HasValue)
				request.WithQueryParameter("DIC2", m3_DIC2.Value.ToString());
			if (m3_DIC3.HasValue)
				request.WithQueryParameter("DIC3", m3_DIC3.Value.ToString());
			if (m3_DIC4.HasValue)
				request.WithQueryParameter("DIC4", m3_DIC4.Value.ToString());
			if (m3_DIC5.HasValue)
				request.WithQueryParameter("DIC5", m3_DIC5.Value.ToString());
			if (m3_DIC6.HasValue)
				request.WithQueryParameter("DIC6", m3_DIC6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CMNO))
				request.WithQueryParameter("CMNO", m3_CMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDS))
				request.WithQueryParameter("TEDS", m3_TEDS.Trim());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRHL))
				request.WithQueryParameter("PRHL", m3_PRHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GWTP))
				request.WithQueryParameter("GWTP", m3_GWTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRHW))
				request.WithQueryParameter("PRHW", m3_PRHW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERW))
				request.WithQueryParameter("SERW", m3_SERW.Trim());
			if (m3_PWNR.HasValue)
				request.WithQueryParameter("PWNR", m3_PWNR.Value.ToString());
			if (m3_PWSX.HasValue)
				request.WithQueryParameter("PWSX", m3_PWSX.Value.ToString());
			if (m3_EWST.HasValue)
				request.WithQueryParameter("EWST", m3_EWST.Value.ToString());
			if (m3_DANR.HasValue)
				request.WithQueryParameter("DANR", m3_DANR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECN))
				request.WithQueryParameter("TECN", m3_TECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INAP))
				request.WithQueryParameter("INAP", m3_INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DRDN))
				request.WithQueryParameter("DRDN", m3_DRDN.Trim());
			if (m3_DRDL.HasValue)
				request.WithQueryParameter("DRDL", m3_DRDL.Value.ToString());
			if (m3_DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3_DRDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PIDE))
				request.WithQueryParameter("PIDE", m3_PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LTYP))
				request.WithQueryParameter("LTYP", m3_LTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXH2))
				request.WithQueryParameter("EXH2", m3_EXH2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXC2))
				request.WithQueryParameter("EXC2", m3_EXC2.Trim());
			if (m3_MCHP.HasValue)
				request.WithQueryParameter("MCHP", m3_MCHP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXHE))
				request.WithQueryParameter("EXHE", m3_EXHE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXCN))
				request.WithQueryParameter("EXCN", m3_EXCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());

			// Execute the request
			var result = await Execute<AddBatchLineResponse>(
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
		/// Name AddBatchLineChg
		/// Description Add charge to batch order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CRID">Charge id (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CRAM">Charge amount</param>
		/// <param name="m3_CRFA">Calculation factor</param>
		/// <param name="m3_CRD0">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchLineChg(
			string m3_ORNO, 
			string m3_PONR, 
			string m3_POSX, 
			string m3_CRID, 
			int? m3_CONO = null, 
			string m3_CRAM = null, 
			string m3_CRFA = null, 
			string m3_CRD0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchLineChg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");
			if (string.IsNullOrWhiteSpace(m3_POSX))
				throw new ArgumentNullException("m3_POSX");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim())
				.WithQueryParameter("POSX", m3_POSX.Trim())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRAM))
				request.WithQueryParameter("CRAM", m3_CRAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRFA))
				request.WithQueryParameter("CRFA", m3_CRFA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRD0))
				request.WithQueryParameter("CRD0", m3_CRD0.Trim());

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
		/// Name AddBatchLnInfo
		/// Description Add additional information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchLnInfo(
			string m3_ORNO, 
			string m3_PONR, 
			string m3_AGNB, 
			int m3_SEQN, 
			string m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchLnInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());

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
		/// Name AddBatchLnManRe
		/// Description Add manual rebate to batch order line
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_CLAR">Supplier rebate reference number (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_RASR">Agreement reference number</param>
		/// <param name="m3_SREA">Rebate amount</param>
		/// <param name="m3_RPUN">Rebate amount - unit of measure</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchLnManRe(
			int m3_CONO, 
			string m3_ORNO, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_SUNO, 
			string m3_CLAR, 
			string m3_CUCD, 
			string m3_RASR = null, 
			decimal? m3_SREA = null, 
			string m3_RPUN = null, 
			string m3_RESP = null, 
			string m3_RFID = null, 
			string m3_OREF = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchLnManRe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_CLAR))
				throw new ArgumentNullException("m3_CLAR");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("CLAR", m3_CLAR.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RASR))
				request.WithQueryParameter("RASR", m3_RASR.Trim());
			if (m3_SREA.HasValue)
				request.WithQueryParameter("SREA", m3_SREA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPUN))
				request.WithQueryParameter("RPUN", m3_RPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name AddBatchQuot
		/// Description Add quotation information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_GIDT">Valid to date (Required)</param>
		/// <param name="m3_BVC1">Follow up activity 1 (Required)</param>
		/// <param name="m3_BVC2">Follow up activity 2 (Required)</param>
		/// <param name="m3_FFI1">User defined field 1 (Required)</param>
		/// <param name="m3_FFI2">User defined field 2 (Required)</param>
		/// <param name="m3_FFI3">User defined field 3 (Required)</param>
		/// <param name="m3_FFI4">User defined field 4 (Required)</param>
		/// <param name="m3_ORCD">Quotation reason (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BVD1">Follow up date 1</param>
		/// <param name="m3_BVD2">Follow up date 2</param>
		/// <param name="m3_DLDA">Delivery time in days</param>
		/// <param name="m3_REFO">Reference object - Used as search key</param>
		/// <param name="m3_FFI5">User defined field 5</param>
		/// <param name="m3_FFI6">User defined field 6</param>
		/// <param name="m3_NUM2">Confirm</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchQuotResponse></returns>
		/// <exception cref="M3Exception<AddBatchQuotResponse>"></exception>
		public async Task<M3Response<AddBatchQuotResponse>> AddBatchQuot(
			string m3_ORNO, 
			DateTime m3_GIDT, 
			string m3_BVC1, 
			string m3_BVC2, 
			string m3_FFI1, 
			string m3_FFI2, 
			string m3_FFI3, 
			string m3_FFI4, 
			string m3_ORCD, 
			int? m3_CONO = null, 
			DateTime? m3_BVD1 = null, 
			DateTime? m3_BVD2 = null, 
			int? m3_DLDA = null, 
			string m3_REFO = null, 
			string m3_FFI5 = null, 
			string m3_FFI6 = null, 
			int? m3_NUM2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_BVC1))
				throw new ArgumentNullException("m3_BVC1");
			if (string.IsNullOrWhiteSpace(m3_BVC2))
				throw new ArgumentNullException("m3_BVC2");
			if (string.IsNullOrWhiteSpace(m3_FFI1))
				throw new ArgumentNullException("m3_FFI1");
			if (string.IsNullOrWhiteSpace(m3_FFI2))
				throw new ArgumentNullException("m3_FFI2");
			if (string.IsNullOrWhiteSpace(m3_FFI3))
				throw new ArgumentNullException("m3_FFI3");
			if (string.IsNullOrWhiteSpace(m3_FFI4))
				throw new ArgumentNullException("m3_FFI4");
			if (string.IsNullOrWhiteSpace(m3_ORCD))
				throw new ArgumentNullException("m3_ORCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("GIDT", m3_GIDT.ToM3String())
				.WithQueryParameter("BVC1", m3_BVC1.Trim())
				.WithQueryParameter("BVC2", m3_BVC2.Trim())
				.WithQueryParameter("FFI1", m3_FFI1.Trim())
				.WithQueryParameter("FFI2", m3_FFI2.Trim())
				.WithQueryParameter("FFI3", m3_FFI3.Trim())
				.WithQueryParameter("FFI4", m3_FFI4.Trim())
				.WithQueryParameter("ORCD", m3_ORCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_BVD1.HasValue)
				request.WithQueryParameter("BVD1", m3_BVD1.Value.ToM3String());
			if (m3_BVD2.HasValue)
				request.WithQueryParameter("BVD2", m3_BVD2.Value.ToM3String());
			if (m3_DLDA.HasValue)
				request.WithQueryParameter("DLDA", m3_DLDA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REFO))
				request.WithQueryParameter("REFO", m3_REFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI5))
				request.WithQueryParameter("FFI5", m3_FFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI6))
				request.WithQueryParameter("FFI6", m3_FFI6.Trim());
			if (m3_NUM2.HasValue)
				request.WithQueryParameter("NUM2", m3_NUM2.Value.ToString());

			// Execute the request
			var result = await Execute<AddBatchQuotResponse>(
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
		/// Name AddBatchSalesPe
		/// Description Add Batch Salesperson
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ORNO">Temporary order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_SMCD">Salesperson (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CAMO">Commission amount</param>
		/// <param name="m3_COPE">Commission percentage</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchSalesPe(
			string m3_ORNO, 
			int m3_PONR, 
			string m3_SMCD, 
			int? m3_POSX = null, 
			string m3_CUCD = null, 
			decimal? m3_CAMO = null, 
			int? m3_COPE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchSalesPe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_SMCD))
				throw new ArgumentNullException("m3_SMCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("SMCD", m3_SMCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_CAMO.HasValue)
				request.WithQueryParameter("CAMO", m3_CAMO.Value.ToString());
			if (m3_COPE.HasValue)
				request.WithQueryParameter("COPE", m3_COPE.Value.ToString());

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
		/// Name AddBatchText
		/// Description Add text for order head/line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_TYPE">Order head or Line, 1=Head/2=Line (Required)</param>
		/// <param name="m3_TYTR">Type of text, 1=Pre/2=Post/3=F6 (Required)</param>
		/// <param name="m3_PARM">Text (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_TXHE">Document class</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TXEI">External/internal text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBatchText(
			string m3_ORNO, 
			string m3_TYPE, 
			int m3_TYTR, 
			string m3_PARM, 
			int? m3_CONO = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_TXHE = null, 
			string m3_LNCD = null, 
			string m3_TX40 = null, 
			int? m3_TXEI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_TYPE))
				throw new ArgumentNullException("m3_TYPE");
			if (string.IsNullOrWhiteSpace(m3_PARM))
				throw new ArgumentNullException("m3_PARM");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("TYPE", m3_TYPE.Trim())
				.WithQueryParameter("TYTR", m3_TYTR.ToString())
				.WithQueryParameter("PARM", m3_PARM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXHE))
				request.WithQueryParameter("TXHE", m3_TXHE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3_TXEI.Value.ToString());

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
		/// Name AddConnCOCharge
		/// Description Add Connected CO Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_CRAM">Charge amount</param>
		/// <param name="m3_CRFA">Calculation factor</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_CRD0">Description language 0</param>
		/// <param name="m3_CHST">Status - charge</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddConnCOCharge(
			string m3_ORNO, 
			string m3_CRID, 
			decimal? m3_DLIX = null, 
			decimal? m3_CRAM = null, 
			decimal? m3_CRFA = null, 
			int? m3_VTCD = null, 
			string m3_ACRF = null, 
			string m3_CRD0 = null, 
			string m3_CHST = null, 
			string m3_TAXC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddConnCOCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_CRAM.HasValue)
				request.WithQueryParameter("CRAM", m3_CRAM.Value.ToString());
			if (m3_CRFA.HasValue)
				request.WithQueryParameter("CRFA", m3_CRFA.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRD0))
				request.WithQueryParameter("CRD0", m3_CRD0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHST))
				request.WithQueryParameter("CHST", m3_CHST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());

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
		/// Name AddDocument
		/// Description Add Connected Document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_NOEX">Number of copies</param>
		/// <param name="m3_DOCD">Print document</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDocument(
			string m3_ORNO = null, 
			string m3_DONR = null, 
			string m3_DOVA = null, 
			int? m3_NOEX = null, 
			int? m3_DOCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDocument",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (m3_NOEX.HasValue)
				request.WithQueryParameter("NOEX", m3_NOEX.Value.ToString());
			if (m3_DOCD.HasValue)
				request.WithQueryParameter("DOCD", m3_DOCD.Value.ToString());

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
		/// Name AddECI
		/// Description Add coded ECI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TPLI">Template item number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_TEDS">Description 1</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddECIResponse></returns>
		/// <exception cref="M3Exception<AddECIResponse>"></exception>
		public async Task<M3Response<AddECIResponse>> AddECI(
			string m3_TPLI, 
			string m3_WHLO, 
			string m3_CUNO, 
			string m3_SUNO = null, 
			string m3_ITDS = null, 
			string m3_TEDS = null, 
			string m3_BUYE = null, 
			string m3_ORTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddECI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TPLI))
				throw new ArgumentNullException("m3_TPLI");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("TPLI", m3_TPLI.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDS))
				request.WithQueryParameter("TEDS", m3_TEDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());

			// Execute the request
			var result = await Execute<AddECIResponse>(
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
		/// Name AddLineBatchEnt
		/// Description Add CO line to an existing order via batch order entry
		/// Version Release: 5ea8
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_JDCD">Joint delivery</param>
		/// <param name="m3_CUPO">Line number</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_DIA2">Discount amount 2</param>
		/// <param name="m3_DIA3">Discount amount 3</param>
		/// <param name="m3_DIA4">Discount amount 4</param>
		/// <param name="m3_DIA5">Discount amount 5</param>
		/// <param name="m3_DIA6">Discount amount 6</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_DLSX">Delivery specification text</param>
		/// <param name="m3_CFXX">Old CFIN</param>
		/// <param name="m3_ECVS">Simulation round</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_CODT">Confirmed delivery date</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_DIP1">Discount 1</param>
		/// <param name="m3_DIP2">Discount 2</param>
		/// <param name="m3_DIP3">Discount 3</param>
		/// <param name="m3_DIP4">Discount 4</param>
		/// <param name="m3_DIP5">Discount 5</param>
		/// <param name="m3_DIP6">Discount 6</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_AGNO">Blanket agreement number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUPA">Customers packaging identity</param>
		/// <param name="m3_DWHM">Requested delivery time</param>
		/// <param name="m3_D1QT">Standard quantity</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_SPUN">Sales price unit of measure</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_EDFP">EDIFACT price</param>
		/// <param name="m3_DWDZ">Requested delivery date</param>
		/// <param name="m3_DWHZ">Requested delivery time</param>
		/// <param name="m3_COHM">Confirmed delivery time</param>
		/// <param name="m3_CODZ">Confirmed delivery date</param>
		/// <param name="m3_COHZ">Confirmed delivery time</param>
		/// <param name="m3_HDPR">Main product</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_CUSX">Line suffix</param>
		/// <param name="m3_TEDS">Description 1</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_BANO">Batch no</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_DIC1">Status - discount</param>
		/// <param name="m3_DIC2">Status - discount</param>
		/// <param name="m3_DIC3">Status - discount</param>
		/// <param name="m3_DIC4">Status - discount</param>
		/// <param name="m3_DIC5">Status - discount</param>
		/// <param name="m3_DIC6">Status - discount</param>
		/// <param name="m3_PRHL">Product number highest level</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_GWTP">Granted warranty type</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_PRHW">Product number highest level</param>
		/// <param name="m3_SERW">Serial number</param>
		/// <param name="m3_PWNR">Order line number</param>
		/// <param name="m3_PWSX">Line suffix</param>
		/// <param name="m3_EWST">Extended warranty start</param>
		/// <param name="m3_DANR">Default attribute number</param>
		/// <param name="m3_TECN">Tax exemption contract number</param>
		/// <param name="m3_INAP">Industry Application</param>
		/// <param name="m3_DRDN">Demand order number</param>
		/// <param name="m3_DRDL">Demand order line</param>
		/// <param name="m3_DRDX">Line suffix</param>
		/// <param name="m3_PIDE">Promotion</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_LTYP">Line type</param>
		/// <param name="m3_PONR">Order line number</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_EXH2">External order number</param>
		/// <param name="m3_EXC2">External configuration number</param>
		/// <param name="m3_MCHP">Price change indicator</param>
		/// <param name="m3_EXHE">External order number</param>
		/// <param name="m3_EXCN">External configuration number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLineBatchEntResponse></returns>
		/// <exception cref="M3Exception<AddLineBatchEntResponse>"></exception>
		public async Task<M3Response<AddLineBatchEntResponse>> AddLineBatchEnt(
			string m3_ORNO, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_ORQT = null, 
			string m3_WHLO = null, 
			DateTime? m3_DWDT = null, 
			string m3_JDCD = null, 
			string m3_CUPO = null, 
			string m3_SAPR = null, 
			string m3_DIA1 = null, 
			string m3_DIA2 = null, 
			string m3_DIA3 = null, 
			string m3_DIA4 = null, 
			string m3_DIA5 = null, 
			string m3_DIA6 = null, 
			string m3_DLSP = null, 
			string m3_DLSX = null, 
			int? m3_CFXX = null, 
			int? m3_ECVS = null, 
			string m3_ALUN = null, 
			DateTime? m3_CODT = null, 
			string m3_ITDS = null, 
			int? m3_DIP1 = null, 
			int? m3_DIP2 = null, 
			int? m3_DIP3 = null, 
			int? m3_DIP4 = null, 
			int? m3_DIP5 = null, 
			int? m3_DIP6 = null, 
			int? m3_ALWT = null, 
			string m3_ALWQ = null, 
			string m3_AGNO = null, 
			string m3_CAMU = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_CUOR = null, 
			string m3_CUPA = null, 
			int? m3_DWHM = null, 
			decimal? m3_D1QT = null, 
			string m3_PACT = null, 
			string m3_POPN = null, 
			int? m3_SACD = null, 
			string m3_SPUN = null, 
			string m3_TEPA = null, 
			decimal? m3_EDFP = null, 
			DateTime? m3_DWDZ = null, 
			int? m3_DWHZ = null, 
			int? m3_COHM = null, 
			DateTime? m3_CODZ = null, 
			int? m3_COHZ = null, 
			string m3_HDPR = null, 
			string m3_ADID = null, 
			int? m3_CUSX = null, 
			string m3_TEDS = null, 
			long? m3_CFIN = null, 
			string m3_BANO = null, 
			string m3_WHSL = null, 
			int? m3_DIC1 = null, 
			int? m3_DIC2 = null, 
			int? m3_DIC3 = null, 
			int? m3_DIC4 = null, 
			int? m3_DIC5 = null, 
			int? m3_DIC6 = null, 
			string m3_PRHL = null, 
			string m3_SERN = null, 
			string m3_CTNO = null, 
			string m3_CFGL = null, 
			string m3_GWTP = null, 
			string m3_WATP = null, 
			string m3_PRHW = null, 
			string m3_SERW = null, 
			int? m3_PWNR = null, 
			int? m3_PWSX = null, 
			int? m3_EWST = null, 
			decimal? m3_DANR = null, 
			string m3_TECN = null, 
			string m3_INAP = null, 
			string m3_DRDN = null, 
			int? m3_DRDL = null, 
			int? m3_DRDX = null, 
			string m3_PIDE = null, 
			string m3_TEPY = null, 
			string m3_LTYP = null, 
			int? m3_PONR = null, 
			string m3_RSCD = null, 
			string m3_EXH2 = null, 
			string m3_EXC2 = null, 
			int? m3_MCHP = null, 
			string m3_EXHE = null, 
			string m3_EXCN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLineBatchEnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORQT))
				request.WithQueryParameter("ORQT", m3_ORQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_JDCD))
				request.WithQueryParameter("JDCD", m3_JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPO))
				request.WithQueryParameter("CUPO", m3_CUPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAPR))
				request.WithQueryParameter("SAPR", m3_SAPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA1))
				request.WithQueryParameter("DIA1", m3_DIA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA2))
				request.WithQueryParameter("DIA2", m3_DIA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA3))
				request.WithQueryParameter("DIA3", m3_DIA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA4))
				request.WithQueryParameter("DIA4", m3_DIA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA5))
				request.WithQueryParameter("DIA5", m3_DIA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA6))
				request.WithQueryParameter("DIA6", m3_DIA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSX))
				request.WithQueryParameter("DLSX", m3_DLSX.Trim());
			if (m3_CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3_CFXX.Value.ToString());
			if (m3_ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3_ECVS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_CODT.HasValue)
				request.WithQueryParameter("CODT", m3_CODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (m3_DIP1.HasValue)
				request.WithQueryParameter("DIP1", m3_DIP1.Value.ToString());
			if (m3_DIP2.HasValue)
				request.WithQueryParameter("DIP2", m3_DIP2.Value.ToString());
			if (m3_DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3_DIP3.Value.ToString());
			if (m3_DIP4.HasValue)
				request.WithQueryParameter("DIP4", m3_DIP4.Value.ToString());
			if (m3_DIP5.HasValue)
				request.WithQueryParameter("DIP5", m3_DIP5.Value.ToString());
			if (m3_DIP6.HasValue)
				request.WithQueryParameter("DIP6", m3_DIP6.Value.ToString());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNO))
				request.WithQueryParameter("AGNO", m3_AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (m3_DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3_DWHM.Value.ToString());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPUN))
				request.WithQueryParameter("SPUN", m3_SPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (m3_EDFP.HasValue)
				request.WithQueryParameter("EDFP", m3_EDFP.Value.ToString());
			if (m3_DWDZ.HasValue)
				request.WithQueryParameter("DWDZ", m3_DWDZ.Value.ToM3String());
			if (m3_DWHZ.HasValue)
				request.WithQueryParameter("DWHZ", m3_DWHZ.Value.ToString());
			if (m3_COHM.HasValue)
				request.WithQueryParameter("COHM", m3_COHM.Value.ToString());
			if (m3_CODZ.HasValue)
				request.WithQueryParameter("CODZ", m3_CODZ.Value.ToM3String());
			if (m3_COHZ.HasValue)
				request.WithQueryParameter("COHZ", m3_COHZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_HDPR))
				request.WithQueryParameter("HDPR", m3_HDPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3_CUSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEDS))
				request.WithQueryParameter("TEDS", m3_TEDS.Trim());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_DIC1.HasValue)
				request.WithQueryParameter("DIC1", m3_DIC1.Value.ToString());
			if (m3_DIC2.HasValue)
				request.WithQueryParameter("DIC2", m3_DIC2.Value.ToString());
			if (m3_DIC3.HasValue)
				request.WithQueryParameter("DIC3", m3_DIC3.Value.ToString());
			if (m3_DIC4.HasValue)
				request.WithQueryParameter("DIC4", m3_DIC4.Value.ToString());
			if (m3_DIC5.HasValue)
				request.WithQueryParameter("DIC5", m3_DIC5.Value.ToString());
			if (m3_DIC6.HasValue)
				request.WithQueryParameter("DIC6", m3_DIC6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRHL))
				request.WithQueryParameter("PRHL", m3_PRHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GWTP))
				request.WithQueryParameter("GWTP", m3_GWTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRHW))
				request.WithQueryParameter("PRHW", m3_PRHW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERW))
				request.WithQueryParameter("SERW", m3_SERW.Trim());
			if (m3_PWNR.HasValue)
				request.WithQueryParameter("PWNR", m3_PWNR.Value.ToString());
			if (m3_PWSX.HasValue)
				request.WithQueryParameter("PWSX", m3_PWSX.Value.ToString());
			if (m3_EWST.HasValue)
				request.WithQueryParameter("EWST", m3_EWST.Value.ToString());
			if (m3_DANR.HasValue)
				request.WithQueryParameter("DANR", m3_DANR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECN))
				request.WithQueryParameter("TECN", m3_TECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INAP))
				request.WithQueryParameter("INAP", m3_INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DRDN))
				request.WithQueryParameter("DRDN", m3_DRDN.Trim());
			if (m3_DRDL.HasValue)
				request.WithQueryParameter("DRDL", m3_DRDL.Value.ToString());
			if (m3_DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3_DRDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PIDE))
				request.WithQueryParameter("PIDE", m3_PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LTYP))
				request.WithQueryParameter("LTYP", m3_LTYP.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXH2))
				request.WithQueryParameter("EXH2", m3_EXH2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXC2))
				request.WithQueryParameter("EXC2", m3_EXC2.Trim());
			if (m3_MCHP.HasValue)
				request.WithQueryParameter("MCHP", m3_MCHP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXHE))
				request.WithQueryParameter("EXHE", m3_EXHE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXCN))
				request.WithQueryParameter("EXCN", m3_EXCN.Trim());

			// Execute the request
			var result = await Execute<AddLineBatchEntResponse>(
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
		/// Name AddLineManRe
		/// Description Add manual rebate to an existing order line
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_CLAR">Supplier rebate reference number (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_RASR">Agreement reference number</param>
		/// <param name="m3_SREA">Rebate amount</param>
		/// <param name="m3_RPUN">Rebate amount - unit of measure</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLineManRe(
			int m3_CONO, 
			string m3_ORNO, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_SUNO, 
			string m3_CLAR, 
			string m3_CUCD, 
			string m3_RASR = null, 
			decimal? m3_SREA = null, 
			string m3_RPUN = null, 
			string m3_RESP = null, 
			string m3_RFID = null, 
			string m3_OREF = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLineManRe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_CLAR))
				throw new ArgumentNullException("m3_CLAR");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("CLAR", m3_CLAR.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RASR))
				request.WithQueryParameter("RASR", m3_RASR.Trim());
			if (m3_SREA.HasValue)
				request.WithQueryParameter("SREA", m3_SREA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPUN))
				request.WithQueryParameter("RPUN", m3_RPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name AddLnInfo
		/// Description Add additional information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLnInfo(
			string m3_ORNO, 
			int m3_PONR, 
			string m3_AGNB, 
			int m3_SEQN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLnInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

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
		/// Name AddSoldAgainst
		/// Description Add sold against info for pricing
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_AAGN">Agreement</param>
		/// <param name="m3_ADLM">Dealer model</param>
		/// <param name="m3_APRM">Price model</param>
		/// <param name="m3_ASLM">Sales model</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFJ0">User-defined field 10 - serv agreement NOT USED 170224</param>
		/// <param name="m3_EQGR">Equipment group</param>
		/// <param name="m3_EQTP">Equipment type</param>
		/// <param name="m3_FLEE">Fleet</param>
		/// <param name="m3_FLNO">Fleet number</param>
		/// <param name="m3_INAP">Industry application</param>
		/// <param name="m3_OENV">Operating environment</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_PROD">Manufacturer</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_CFJX">User-defined field 10 - serv agreement</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSoldAgainst(
			int m3_CONO, 
			string m3_ORNO, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_AAGN = null, 
			string m3_ADLM = null, 
			string m3_APRM = null, 
			string m3_ASLM = null, 
			string m3_BRAN = null, 
			string m3_CFI3 = null, 
			string m3_CFJ0 = null, 
			string m3_EQGR = null, 
			string m3_EQTP = null, 
			string m3_FLEE = null, 
			string m3_FLNO = null, 
			string m3_INAP = null, 
			string m3_OENV = null, 
			string m3_PRNO = null, 
			string m3_PROD = null, 
			string m3_SERN = null, 
			string m3_SUNO = null, 
			string m3_CFJX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSoldAgainst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADLM))
				request.WithQueryParameter("ADLM", m3_ADLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APRM))
				request.WithQueryParameter("APRM", m3_APRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASLM))
				request.WithQueryParameter("ASLM", m3_ASLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJ0))
				request.WithQueryParameter("CFJ0", m3_CFJ0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGR))
				request.WithQueryParameter("EQGR", m3_EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQTP))
				request.WithQueryParameter("EQTP", m3_EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLEE))
				request.WithQueryParameter("FLEE", m3_FLEE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLNO))
				request.WithQueryParameter("FLNO", m3_FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INAP))
				request.WithQueryParameter("INAP", m3_INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OENV))
				request.WithQueryParameter("OENV", m3_OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROD))
				request.WithQueryParameter("PROD", m3_PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJX))
				request.WithQueryParameter("CFJX", m3_CFJX.Trim());

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
		/// Description Add Text for a customer order
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3_FLDN">Field number</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TXCC">Text control code</param>
		/// <param name="m3_TXEI">External/internal text</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_KFLD">File key</param>
		/// <param name="m3_REPL">Replacing VAT code found</param>
		/// <param name="m3_TEXT">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddTextResponse></returns>
		/// <exception cref="M3Exception<AddTextResponse>"></exception>
		public async Task<M3Response<AddTextResponse>> AddText(
			string m3_FLDN = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
			string m3_TX40 = null, 
			string m3_TXCC = null, 
			int? m3_TXEI = null, 
			string m3_FILE = null, 
			string m3_KFLD = null, 
			int? m3_REPL = null, 
			string m3_TEXT = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FLDN))
				request.WithQueryParameter("FLDN", m3_FLDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXCC))
				request.WithQueryParameter("TXCC", m3_TXCC.Trim());
			if (m3_TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3_TXEI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KFLD))
				request.WithQueryParameter("KFLD", m3_KFLD.Trim());
			if (m3_REPL.HasValue)
				request.WithQueryParameter("REPL", m3_REPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEXT))
				request.WithQueryParameter("TEXT", m3_TEXT.Trim());

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
		/// Name AddUncheckHead
		/// Description Create new batch order head without checks
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_ORTP">Order type (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_RLDT">Requested delivery date</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_AGNT">Agent</param>
		/// <param name="m3_SMCD">Salesman</param>
		/// <param name="m3_MODL">Method of delivery</param>
		/// <param name="m3_TEDL">Term of delivery</param>
		/// <param name="m3_YREF">Reference at customer</param>
		/// <param name="m3_PROJ">Project</param>
		/// <param name="m3_OTBA">Order discount amount</param>
		/// <param name="m3_TEPY">Terms of payment</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_ADID">Delivery address id</param>
		/// <param name="m3_CUCD">Currency code</param>
		/// <param name="m3_OREF">Our referens</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_TEL2">Delivery terms text</param>
		/// <param name="m3_CUDT">Customers purchase order date</param>
		/// <param name="m3_INRC">Invoice recipient</param>
		/// <param name="m3_ORDT">Order date</param>
		/// <param name="m3_RLHM">Requested delivery time</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_TIZO">Time zone</param>
		/// <param name="m3_AGNO">Blanket agreement number</param>
		/// <param name="m3_PRO2">Project</param>
		/// <param name="m3_RLDZ">Requested delivery date</param>
		/// <param name="m3_RLHZ">Requested delivery time</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_DSTX">Description of delivery specification</param>
		/// <param name="m3_TECD">Cash discount term</param>
		/// <param name="m3_PLTB">Price list table</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_WCON">Contact method</param>
		/// <param name="m3_ID01">Message identity 1</param>
		/// <param name="m3_ID02">Message identity 2</param>
		/// <param name="m3_OTDP">Total discount percentage</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_DICD">Discount origin</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_CHL1">Business chain - level 1</param>
		/// <param name="m3_CHL2">Business chain - level 2</param>
		/// <param name="m3_CHL3">Business chain - level 3</param>
		/// <param name="m3_CHL4">Business chain - level 4</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_NREF">Reference number</param>
		/// <param name="m3_TRDP">3rd party provider ID</param>
		/// <param name="m3_IPAD">IP address</param>
		/// <param name="m3_ESOV">e-Sales order value</param>
		/// <param name="m3_EXCD">Service charge</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_FRE1">Statistics identity 1 customer</param>
		/// <param name="m3_FDED">First delivery date</param>
		/// <param name="m3_LDED">Last delivery date</param>
		/// <param name="m3_BREC">Recipient agreement type 9 - bonus</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_OHEA">Only header</param>
		/// <param name="m3_CUCH">Customer channel id</param>
		/// <param name="m3_CCAC">Activity</param>
		/// <param name="m3_DECU">Delivery customer</param>
		/// <param name="m3_GCAC">Supplier ID</param>
		/// <param name="m3_PYRE">Request reference number</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddUncheckHeadResponse></returns>
		/// <exception cref="M3Exception<AddUncheckHeadResponse>"></exception>
		public async Task<M3Response<AddUncheckHeadResponse>> AddUncheckHead(
			string m3_CUNO, 
			string m3_ORTP, 
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			DateTime? m3_RLDT = null, 
			string m3_CUOR = null, 
			string m3_AGNT = null, 
			string m3_SMCD = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_YREF = null, 
			string m3_PROJ = null, 
			string m3_OTBA = null, 
			string m3_TEPY = null, 
			string m3_PYNO = null, 
			string m3_ADID = null, 
			string m3_CUCD = null, 
			string m3_OREF = null, 
			string m3_OFNO = null, 
			string m3_TEL2 = null, 
			DateTime? m3_CUDT = null, 
			string m3_INRC = null, 
			DateTime? m3_ORDT = null, 
			int? m3_RLHM = null, 
			string m3_TEPA = null, 
			string m3_TIZO = null, 
			string m3_AGNO = null, 
			string m3_PRO2 = null, 
			DateTime? m3_RLDZ = null, 
			int? m3_RLHZ = null, 
			string m3_DLSP = null, 
			string m3_DSTX = null, 
			string m3_TECD = null, 
			string m3_PLTB = null, 
			string m3_DISY = null, 
			string m3_WCON = null, 
			string m3_ID01 = null, 
			string m3_ID02 = null, 
			string m3_OTDP = null, 
			string m3_CRTP = null, 
			int? m3_DICD = null, 
			string m3_ELNO = null, 
			string m3_CHL1 = null, 
			string m3_CHL2 = null, 
			string m3_CHL3 = null, 
			string m3_CHL4 = null, 
			string m3_WHLO = null, 
			string m3_NREF = null, 
			string m3_TRDP = null, 
			string m3_IPAD = null, 
			int? m3_ESOV = null, 
			string m3_EXCD = null, 
			string m3_PYCD = null, 
			string m3_FRE1 = null, 
			DateTime? m3_FDED = null, 
			DateTime? m3_LDED = null, 
			string m3_BREC = null, 
			string m3_RESP = null, 
			int? m3_OHEA = null, 
			string m3_CUCH = null, 
			string m3_CCAC = null, 
			string m3_DECU = null, 
			string m3_GCAC = null, 
			string m3_PYRE = null, 
			string m3_BKID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddUncheckHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_ORTP))
				throw new ArgumentNullException("m3_ORTP");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ORTP", m3_ORTP.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3_RLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNT))
				request.WithQueryParameter("AGNT", m3_AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTBA))
				request.WithQueryParameter("OTBA", m3_OTBA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL2))
				request.WithQueryParameter("TEL2", m3_TEL2.Trim());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_INRC))
				request.WithQueryParameter("INRC", m3_INRC.Trim());
			if (m3_ORDT.HasValue)
				request.WithQueryParameter("ORDT", m3_ORDT.Value.ToM3String());
			if (m3_RLHM.HasValue)
				request.WithQueryParameter("RLHM", m3_RLHM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIZO))
				request.WithQueryParameter("TIZO", m3_TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNO))
				request.WithQueryParameter("AGNO", m3_AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRO2))
				request.WithQueryParameter("PRO2", m3_PRO2.Trim());
			if (m3_RLDZ.HasValue)
				request.WithQueryParameter("RLDZ", m3_RLDZ.Value.ToM3String());
			if (m3_RLHZ.HasValue)
				request.WithQueryParameter("RLHZ", m3_RLHZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSTX))
				request.WithQueryParameter("DSTX", m3_DSTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECD))
				request.WithQueryParameter("TECD", m3_TECD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTB))
				request.WithQueryParameter("PLTB", m3_PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WCON))
				request.WithQueryParameter("WCON", m3_WCON.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID01))
				request.WithQueryParameter("ID01", m3_ID01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ID02))
				request.WithQueryParameter("ID02", m3_ID02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTDP))
				request.WithQueryParameter("OTDP", m3_OTDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRTP))
				request.WithQueryParameter("CRTP", m3_CRTP.Trim());
			if (m3_DICD.HasValue)
				request.WithQueryParameter("DICD", m3_DICD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL1))
				request.WithQueryParameter("CHL1", m3_CHL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL2))
				request.WithQueryParameter("CHL2", m3_CHL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL3))
				request.WithQueryParameter("CHL3", m3_CHL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL4))
				request.WithQueryParameter("CHL4", m3_CHL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NREF))
				request.WithQueryParameter("NREF", m3_NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRDP))
				request.WithQueryParameter("TRDP", m3_TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IPAD))
				request.WithQueryParameter("IPAD", m3_IPAD.Trim());
			if (m3_ESOV.HasValue)
				request.WithQueryParameter("ESOV", m3_ESOV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXCD))
				request.WithQueryParameter("EXCD", m3_EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE1))
				request.WithQueryParameter("FRE1", m3_FRE1.Trim());
			if (m3_FDED.HasValue)
				request.WithQueryParameter("FDED", m3_FDED.Value.ToM3String());
			if (m3_LDED.HasValue)
				request.WithQueryParameter("LDED", m3_LDED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_BREC))
				request.WithQueryParameter("BREC", m3_BREC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_OHEA.HasValue)
				request.WithQueryParameter("OHEA", m3_OHEA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCH))
				request.WithQueryParameter("CUCH", m3_CUCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCAC))
				request.WithQueryParameter("CCAC", m3_CCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DECU))
				request.WithQueryParameter("DECU", m3_DECU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GCAC))
				request.WithQueryParameter("GCAC", m3_GCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYRE))
				request.WithQueryParameter("PYRE", m3_PYRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());

			// Execute the request
			var result = await Execute<AddUncheckHeadResponse>(
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
		/// Name AuthCreditCard
		/// Description Authorize Credit Card
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_NREF">Reference number</param>
		/// <param name="m3_TRDP">3rd party provider</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AuthCreditCard(
			int? m3_CONO = null, 
			string m3_ORNO = null, 
			string m3_NREF = null, 
			string m3_TRDP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AuthCreditCard",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NREF))
				request.WithQueryParameter("NREF", m3_NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRDP))
				request.WithQueryParameter("TRDP", m3_TRDP.Trim());

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
		/// Name CheckCredit
		/// Description Check customer credit exceeded
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CheckCredit(
			string m3_CUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CheckCredit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

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
		/// Name CheckCustomer
		/// Description Check customer information
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CheckCustomerResponse></returns>
		/// <exception cref="M3Exception<CheckCustomerResponse>"></exception>
		public async Task<M3Response<CheckCustomerResponse>> CheckCustomer(
			string m3_CUNO = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CheckCustomer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());

			// Execute the request
			var result = await Execute<CheckCustomerResponse>(
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
		/// Name CheckPIN
		/// Description Check customer number and PIN code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_PWMT">Password (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CheckPIN(
			string m3_CUNO, 
			string m3_PWMT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CheckPIN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_PWMT))
				throw new ArgumentNullException("m3_PWMT");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("PWMT", m3_PWMT.Trim());

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
		/// Name ChgBatchHead
		/// Description Change contents of batch order head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Temporary order number (Required)</param>
		/// <param name="m3_ORTP">Order type (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_RLDT">Requested delivery date</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_AGNT">Agent</param>
		/// <param name="m3_SMCD">Salesman</param>
		/// <param name="m3_MODL">Method of delivery</param>
		/// <param name="m3_TEDL">Term of delivery</param>
		/// <param name="m3_YREF">Reference at customer</param>
		/// <param name="m3_PROJ">Project</param>
		/// <param name="m3_OTBA">Order discount amount</param>
		/// <param name="m3_TEPY">Terms of payment</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_ADID">Delivery address id</param>
		/// <param name="m3_CUCD">Currency code</param>
		/// <param name="m3_OREF">Our referens</param>
		/// <param name="m3_INRC">Invoice recipient</param>
		/// <param name="m3_TEL2">Terms text</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_RLDZ">Requested delivery date</param>
		/// <param name="m3_RLHZ">Requested delivery time</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_DSTX">Description, delivery specification</param>
		/// <param name="m3_TECD">Cash discount term</param>
		/// <param name="m3_OTDP">Total discount percentage</param>
		/// <param name="m3_NREF">Reference number</param>
		/// <param name="m3_TRDP">3rd party provider ID</param>
		/// <param name="m3_IPAD">IP address</param>
		/// <param name="m3_EXCD">Service charge</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_FRE1">Statistics identity 1 customer</param>
		/// <param name="m3_FDED">First delivery date</param>
		/// <param name="m3_LDED">Last delivery date</param>
		/// <param name="m3_BREC">Recipient agreement type 9 - bonus</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_PYRE">Request reference number</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_OPRI">Priority</param>
		/// <param name="m3_SPLM">Supply model</param>
		/// <param name="m3_OIVR">Original invoice reference</param>
		/// <param name="m3_OYEA">Original year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgBatchHead(
			string m3_ORNO, 
			string m3_ORTP, 
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			DateTime? m3_RLDT = null, 
			string m3_CUOR = null, 
			string m3_AGNT = null, 
			string m3_SMCD = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_YREF = null, 
			string m3_PROJ = null, 
			string m3_OTBA = null, 
			string m3_TEPY = null, 
			string m3_PYNO = null, 
			string m3_ADID = null, 
			string m3_CUCD = null, 
			string m3_OREF = null, 
			string m3_INRC = null, 
			string m3_TEL2 = null, 
			string m3_TEPA = null, 
			string m3_OFNO = null, 
			DateTime? m3_RLDZ = null, 
			int? m3_RLHZ = null, 
			string m3_DLSP = null, 
			string m3_DSTX = null, 
			string m3_TECD = null, 
			string m3_OTDP = null, 
			string m3_NREF = null, 
			string m3_TRDP = null, 
			string m3_IPAD = null, 
			string m3_EXCD = null, 
			string m3_PYCD = null, 
			string m3_FRE1 = null, 
			DateTime? m3_FDED = null, 
			DateTime? m3_LDED = null, 
			string m3_BREC = null, 
			string m3_RESP = null, 
			string m3_PYRE = null, 
			string m3_BKID = null, 
			int? m3_OPRI = null, 
			string m3_SPLM = null, 
			string m3_OIVR = null, 
			int? m3_OYEA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_ORTP))
				throw new ArgumentNullException("m3_ORTP");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("ORTP", m3_ORTP.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3_RLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNT))
				request.WithQueryParameter("AGNT", m3_AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTBA))
				request.WithQueryParameter("OTBA", m3_OTBA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INRC))
				request.WithQueryParameter("INRC", m3_INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL2))
				request.WithQueryParameter("TEL2", m3_TEL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_RLDZ.HasValue)
				request.WithQueryParameter("RLDZ", m3_RLDZ.Value.ToM3String());
			if (m3_RLHZ.HasValue)
				request.WithQueryParameter("RLHZ", m3_RLHZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSTX))
				request.WithQueryParameter("DSTX", m3_DSTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECD))
				request.WithQueryParameter("TECD", m3_TECD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OTDP))
				request.WithQueryParameter("OTDP", m3_OTDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NREF))
				request.WithQueryParameter("NREF", m3_NREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRDP))
				request.WithQueryParameter("TRDP", m3_TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IPAD))
				request.WithQueryParameter("IPAD", m3_IPAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXCD))
				request.WithQueryParameter("EXCD", m3_EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE1))
				request.WithQueryParameter("FRE1", m3_FRE1.Trim());
			if (m3_FDED.HasValue)
				request.WithQueryParameter("FDED", m3_FDED.Value.ToM3String());
			if (m3_LDED.HasValue)
				request.WithQueryParameter("LDED", m3_LDED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_BREC))
				request.WithQueryParameter("BREC", m3_BREC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYRE))
				request.WithQueryParameter("PYRE", m3_PYRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (m3_OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3_OPRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPLM))
				request.WithQueryParameter("SPLM", m3_SPLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OIVR))
				request.WithQueryParameter("OIVR", m3_OIVR.Trim());
			if (m3_OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3_OYEA.Value.ToString());

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
		/// Name ChgBatchLine
		/// Description Change contents of batch order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Temporary order number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORQT">Ordered quantity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_JDCD">Joint delivery code</param>
		/// <param name="m3_CUPO">Customers order number</param>
		/// <param name="m3_SAPR">Salesprice</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_DIA2">Discount amount 2</param>
		/// <param name="m3_DIA3">Discount amount 3</param>
		/// <param name="m3_DIA4">Discount amount 4</param>
		/// <param name="m3_DIA5">Discount amount 5</param>
		/// <param name="m3_DIA6">Discount amount 6</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_DLSX">Delivery specification text</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_CFXX">Old CFIN</param>
		/// <param name="m3_ECVS">Simulations number</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_CODT">Confirmed date of delivery</param>
		/// <param name="m3_ITDS">Item description</param>
		/// <param name="m3_DWHM">Requested delivery time</param>
		/// <param name="m3_DWDZ">Requested delivery date</param>
		/// <param name="m3_DWHZ">Requested delivery time</param>
		/// <param name="m3_COHM">Confirmed delivery time</param>
		/// <param name="m3_CODZ">Confirmed delivery date</param>
		/// <param name="m3_COHZ">Confirmed delivery time</param>
		/// <param name="m3_HDPR">Main product</param>
		/// <param name="m3_AGNO">Blanket agreement number</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_CUPA">Customers packaging identity</param>
		/// <param name="m3_D1QT">Standard quantity</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUSX">Line suffix</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_BANO">Batch no</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_GWTP">Granted warranty type</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_TECN">Tax exemption contract number</param>
		/// <param name="m3_INAP">Industry Application</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgBatchLine(
			string m3_ORNO, 
			string m3_ITNO, 
			string m3_PONR, 
			int? m3_CONO = null, 
			string m3_ORQT = null, 
			string m3_WHLO = null, 
			DateTime? m3_DWDT = null, 
			string m3_JDCD = null, 
			string m3_CUPO = null, 
			string m3_SAPR = null, 
			string m3_DIA1 = null, 
			string m3_DIA2 = null, 
			string m3_DIA3 = null, 
			string m3_DIA4 = null, 
			string m3_DIA5 = null, 
			string m3_DIA6 = null, 
			string m3_DLSP = null, 
			string m3_DLSX = null, 
			string m3_POSX = null, 
			int? m3_CFXX = null, 
			int? m3_ECVS = null, 
			string m3_ALUN = null, 
			DateTime? m3_CODT = null, 
			string m3_ITDS = null, 
			int? m3_DWHM = null, 
			DateTime? m3_DWDZ = null, 
			int? m3_DWHZ = null, 
			int? m3_COHM = null, 
			DateTime? m3_CODZ = null, 
			int? m3_COHZ = null, 
			string m3_HDPR = null, 
			string m3_AGNO = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_CAMU = null, 
			string m3_ADID = null, 
			string m3_TEPA = null, 
			string m3_PACT = null, 
			string m3_CUPA = null, 
			decimal? m3_D1QT = null, 
			string m3_CUOR = null, 
			int? m3_CUSX = null, 
			long? m3_CFIN = null, 
			string m3_BANO = null, 
			string m3_WHSL = null, 
			string m3_CTNO = null, 
			string m3_CFGL = null, 
			string m3_GWTP = null, 
			string m3_WATP = null, 
			string m3_TECN = null, 
			string m3_INAP = null, 
			string m3_TEPY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORQT))
				request.WithQueryParameter("ORQT", m3_ORQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_JDCD))
				request.WithQueryParameter("JDCD", m3_JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPO))
				request.WithQueryParameter("CUPO", m3_CUPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAPR))
				request.WithQueryParameter("SAPR", m3_SAPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA1))
				request.WithQueryParameter("DIA1", m3_DIA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA2))
				request.WithQueryParameter("DIA2", m3_DIA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA3))
				request.WithQueryParameter("DIA3", m3_DIA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA4))
				request.WithQueryParameter("DIA4", m3_DIA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA5))
				request.WithQueryParameter("DIA5", m3_DIA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA6))
				request.WithQueryParameter("DIA6", m3_DIA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSX))
				request.WithQueryParameter("DLSX", m3_DLSX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());
			if (m3_CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3_CFXX.Value.ToString());
			if (m3_ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3_ECVS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_CODT.HasValue)
				request.WithQueryParameter("CODT", m3_CODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (m3_DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3_DWHM.Value.ToString());
			if (m3_DWDZ.HasValue)
				request.WithQueryParameter("DWDZ", m3_DWDZ.Value.ToM3String());
			if (m3_DWHZ.HasValue)
				request.WithQueryParameter("DWHZ", m3_DWHZ.Value.ToString());
			if (m3_COHM.HasValue)
				request.WithQueryParameter("COHM", m3_COHM.Value.ToString());
			if (m3_CODZ.HasValue)
				request.WithQueryParameter("CODZ", m3_CODZ.Value.ToM3String());
			if (m3_COHZ.HasValue)
				request.WithQueryParameter("COHZ", m3_COHZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_HDPR))
				request.WithQueryParameter("HDPR", m3_HDPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNO))
				request.WithQueryParameter("AGNO", m3_AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3_CUSX.Value.ToString());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GWTP))
				request.WithQueryParameter("GWTP", m3_GWTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECN))
				request.WithQueryParameter("TECN", m3_TECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INAP))
				request.WithQueryParameter("INAP", m3_INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());

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
		/// Name ChgBatchLnPurch
		/// Description Change purchase info of batch order line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_PPUN">Purchase price U/M</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ODI1">Discount 1</param>
		/// <param name="m3_ODI2">Discount 2</param>
		/// <param name="m3_ODI3">Discount 3</param>
		/// <param name="m3_OURR">Our reference number</param>
		/// <param name="m3_OURT">Reference type</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgBatchLnPurch(
			int m3_CONO, 
			string m3_ORNO, 
			int m3_PONR, 
			int? m3_POSX = null, 
			string m3_ORTY = null, 
			string m3_SUNO = null, 
			decimal? m3_PUPR = null, 
			int? m3_PUCD = null, 
			string m3_PPUN = null, 
			string m3_CUCD = null, 
			int? m3_ODI1 = null, 
			int? m3_ODI2 = null, 
			int? m3_ODI3 = null, 
			string m3_OURR = null, 
			string m3_OURT = null, 
			string m3_BUYE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgBatchLnPurch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3_ODI1.Value.ToString());
			if (m3_ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3_ODI2.Value.ToString());
			if (m3_ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3_ODI3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OURR))
				request.WithQueryParameter("OURR", m3_OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OURT))
				request.WithQueryParameter("OURT", m3_OURT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());

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
		/// Name ChgBatchQuot
		/// Description Change batch quotation information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORCD">Quotation reason</param>
		/// <param name="m3_GIDT">Valid to date</param>
		/// <param name="m3_BVD1">Follow up date 1</param>
		/// <param name="m3_BVD2">Follow up date 2</param>
		/// <param name="m3_BVC1">Follow up activity 1</param>
		/// <param name="m3_BVC2">Follow up activity 2</param>
		/// <param name="m3_DLDA">Delivery time in days</param>
		/// <param name="m3_REFO">Reference object - Used as search key</param>
		/// <param name="m3_FFI1">User defined field 1</param>
		/// <param name="m3_FFI2">User defined field 2</param>
		/// <param name="m3_FFI3">User defined field 3</param>
		/// <param name="m3_FFI4">User defined field 4</param>
		/// <param name="m3_FFI5">User defined field 5</param>
		/// <param name="m3_FFI6">User defined field 6</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgBatchQuot(
			string m3_ORNO, 
			int? m3_CONO = null, 
			string m3_ORCD = null, 
			DateTime? m3_GIDT = null, 
			DateTime? m3_BVD1 = null, 
			DateTime? m3_BVD2 = null, 
			string m3_BVC1 = null, 
			string m3_BVC2 = null, 
			int? m3_DLDA = null, 
			string m3_REFO = null, 
			string m3_FFI1 = null, 
			string m3_FFI2 = null, 
			string m3_FFI3 = null, 
			string m3_FFI4 = null, 
			string m3_FFI5 = null, 
			string m3_FFI6 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgBatchQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCD))
				request.WithQueryParameter("ORCD", m3_ORCD.Trim());
			if (m3_GIDT.HasValue)
				request.WithQueryParameter("GIDT", m3_GIDT.Value.ToM3String());
			if (m3_BVD1.HasValue)
				request.WithQueryParameter("BVD1", m3_BVD1.Value.ToM3String());
			if (m3_BVD2.HasValue)
				request.WithQueryParameter("BVD2", m3_BVD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_BVC1))
				request.WithQueryParameter("BVC1", m3_BVC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BVC2))
				request.WithQueryParameter("BVC2", m3_BVC2.Trim());
			if (m3_DLDA.HasValue)
				request.WithQueryParameter("DLDA", m3_DLDA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REFO))
				request.WithQueryParameter("REFO", m3_REFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI1))
				request.WithQueryParameter("FFI1", m3_FFI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI2))
				request.WithQueryParameter("FFI2", m3_FFI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI3))
				request.WithQueryParameter("FFI3", m3_FFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI4))
				request.WithQueryParameter("FFI4", m3_FFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI5))
				request.WithQueryParameter("FFI5", m3_FFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI6))
				request.WithQueryParameter("FFI6", m3_FFI6.Trim());

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
		/// Name ChgLineBatchEnt
		/// Description Change CO line on an existing order via batch order entry
		/// Version Release: 5eaE
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3_DWDZ">Requested delivery date</param>
		/// <param name="m3_DWHZ">Requested delivery time</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_CUPA">Customers packaging identity</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_EDFP">EDIFACT price</param>
		/// <param name="m3_PRHL">Product number highest level</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_GWTP">Granted warranty type</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_TECN">Tax exemption contract number</param>
		/// <param name="m3_INAP">Industry Application</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_JDCD">Joint delivery</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgLineBatchEntResponse></returns>
		/// <exception cref="M3Exception<ChgLineBatchEntResponse>"></exception>
		public async Task<M3Response<ChgLineBatchEntResponse>> ChgLineBatchEnt(
			string m3_ORNO, 
			string m3_PONR, 
			int? m3_CONO = null, 
			string m3_POSX = null, 
			string m3_ORQA = null, 
			DateTime? m3_DWDZ = null, 
			int? m3_DWHZ = null, 
			string m3_CUOR = null, 
			string m3_TEPA = null, 
			string m3_CUPA = null, 
			string m3_ADID = null, 
			string m3_DLSP = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_EDFP = null, 
			string m3_PRHL = null, 
			string m3_SERN = null, 
			string m3_CTNO = null, 
			string m3_CFGL = null, 
			string m3_GWTP = null, 
			string m3_WATP = null, 
			string m3_TECN = null, 
			string m3_INAP = null, 
			string m3_TEPY = null, 
			string m3_JDCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgLineBatchEnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORQA))
				request.WithQueryParameter("ORQA", m3_ORQA.Trim());
			if (m3_DWDZ.HasValue)
				request.WithQueryParameter("DWDZ", m3_DWDZ.Value.ToM3String());
			if (m3_DWHZ.HasValue)
				request.WithQueryParameter("DWHZ", m3_DWHZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDFP))
				request.WithQueryParameter("EDFP", m3_EDFP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRHL))
				request.WithQueryParameter("PRHL", m3_PRHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GWTP))
				request.WithQueryParameter("GWTP", m3_GWTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECN))
				request.WithQueryParameter("TECN", m3_TECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INAP))
				request.WithQueryParameter("INAP", m3_INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JDCD))
				request.WithQueryParameter("JDCD", m3_JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<ChgLineBatchEntResponse>(
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
		/// Name ChgQuot
		/// Description Change quotation information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STAT">Status quotation</param>
		/// <param name="m3_ORCD">Quotation reason</param>
		/// <param name="m3_GIDT">Valid to date</param>
		/// <param name="m3_BVD1">Follow up date 1</param>
		/// <param name="m3_BVD2">Follow up date 2</param>
		/// <param name="m3_BVC1">Follow up activity 1</param>
		/// <param name="m3_BVC2">Follow up activity 2</param>
		/// <param name="m3_DLDA">Delivery time in days</param>
		/// <param name="m3_REFO">Reference object - Used as search key</param>
		/// <param name="m3_FFI1">User defined field 1</param>
		/// <param name="m3_FFI2">User defined field 2</param>
		/// <param name="m3_FFI3">User defined field 3</param>
		/// <param name="m3_FFI4">User defined field 4</param>
		/// <param name="m3_FFI5">User defined field 5</param>
		/// <param name="m3_FFI6">User defined field 6</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgQuot(
			string m3_ORNO, 
			int? m3_CONO = null, 
			string m3_STAT = null, 
			string m3_ORCD = null, 
			DateTime? m3_GIDT = null, 
			DateTime? m3_BVD1 = null, 
			DateTime? m3_BVD2 = null, 
			string m3_BVC1 = null, 
			string m3_BVC2 = null, 
			int? m3_DLDA = null, 
			string m3_REFO = null, 
			string m3_FFI1 = null, 
			string m3_FFI2 = null, 
			string m3_FFI3 = null, 
			string m3_FFI4 = null, 
			string m3_FFI5 = null, 
			string m3_FFI6 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCD))
				request.WithQueryParameter("ORCD", m3_ORCD.Trim());
			if (m3_GIDT.HasValue)
				request.WithQueryParameter("GIDT", m3_GIDT.Value.ToM3String());
			if (m3_BVD1.HasValue)
				request.WithQueryParameter("BVD1", m3_BVD1.Value.ToM3String());
			if (m3_BVD2.HasValue)
				request.WithQueryParameter("BVD2", m3_BVD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_BVC1))
				request.WithQueryParameter("BVC1", m3_BVC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BVC2))
				request.WithQueryParameter("BVC2", m3_BVC2.Trim());
			if (m3_DLDA.HasValue)
				request.WithQueryParameter("DLDA", m3_DLDA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REFO))
				request.WithQueryParameter("REFO", m3_REFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI1))
				request.WithQueryParameter("FFI1", m3_FFI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI2))
				request.WithQueryParameter("FFI2", m3_FFI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI3))
				request.WithQueryParameter("FFI3", m3_FFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI4))
				request.WithQueryParameter("FFI4", m3_FFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI5))
				request.WithQueryParameter("FFI5", m3_FFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI6))
				request.WithQueryParameter("FFI6", m3_FFI6.Trim());

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
		/// Name ChgWarehouse
		/// Description Change warehouse on CO line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgWarehouseResponse></returns>
		/// <exception cref="M3Exception<ChgWarehouseResponse>"></exception>
		public async Task<M3Response<ChgWarehouseResponse>> ChgWarehouse(
			string m3_ORNO, 
			string m3_WHLO, 
			int? m3_CONO = null, 
			string m3_PONR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgWarehouse",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PONR))
				request.WithQueryParameter("PONR", m3_PONR.Trim());

			// Execute the request
			var result = await Execute<ChgWarehouseResponse>(
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
		/// Name CloLine
		/// Description CloLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_PONR">Order line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloLine(
			int? m3_CONO = null, 
			string m3_ORNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CloLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

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
		/// Name Confirm
		/// Description Confirm order (release batch order)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Batch order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CTYP">Confirmation type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConfirmResponse></returns>
		/// <exception cref="M3Exception<ConfirmResponse>"></exception>
		public async Task<M3Response<ConfirmResponse>> Confirm(
			string m3_ORNO, 
			int? m3_CONO = null, 
			string m3_CTYP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Confirm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CTYP))
				request.WithQueryParameter("CTYP", m3_CTYP.Trim());

			// Execute the request
			var result = await Execute<ConfirmResponse>(
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
		/// Name CpyOrder
		/// Description Copy customer order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNR">Ordernumber to copy from (Required)</param>
		/// <param name="m3_ORTP">Order type to use (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CORH">Copy order head</param>
		/// <param name="m3_CORL">Copy order lines</param>
		/// <param name="m3_COCH">Copy line charges</param>
		/// <param name="m3_COTX">Copy order texts</param>
		/// <param name="m3_CLCH">Copy order texts</param>
		/// <param name="m3_CLTX">Copy line texts</param>
		/// <param name="m3_CADR">Copy addresses</param>
		/// <param name="m3_SAPR">Copy sales price</param>
		/// <param name="m3_UCOS">Copy cost price</param>
		/// <param name="m3_JDCD">Copy joint delivery</param>
		/// <param name="m3_RLDT">Copy requested delivery date</param>
		/// <param name="m3_CODT">Copy confirmed delivery date</param>
		/// <param name="m3_EPRI">Copy external prices</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CpyOrderResponse></returns>
		/// <exception cref="M3Exception<CpyOrderResponse>"></exception>
		public async Task<M3Response<CpyOrderResponse>> CpyOrder(
			string m3_ORNR, 
			string m3_ORTP, 
			int? m3_CONO = null, 
			int? m3_CORH = null, 
			int? m3_CORL = null, 
			int? m3_COCH = null, 
			int? m3_COTX = null, 
			int? m3_CLCH = null, 
			int? m3_CLTX = null, 
			int? m3_CADR = null, 
			int? m3_SAPR = null, 
			int? m3_UCOS = null, 
			int? m3_JDCD = null, 
			DateTime? m3_RLDT = null, 
			DateTime? m3_CODT = null, 
			int? m3_EPRI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNR))
				throw new ArgumentNullException("m3_ORNR");
			if (string.IsNullOrWhiteSpace(m3_ORTP))
				throw new ArgumentNullException("m3_ORTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNR", m3_ORNR.Trim())
				.WithQueryParameter("ORTP", m3_ORTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_CORH.HasValue)
				request.WithQueryParameter("CORH", m3_CORH.Value.ToString());
			if (m3_CORL.HasValue)
				request.WithQueryParameter("CORL", m3_CORL.Value.ToString());
			if (m3_COCH.HasValue)
				request.WithQueryParameter("COCH", m3_COCH.Value.ToString());
			if (m3_COTX.HasValue)
				request.WithQueryParameter("COTX", m3_COTX.Value.ToString());
			if (m3_CLCH.HasValue)
				request.WithQueryParameter("CLCH", m3_CLCH.Value.ToString());
			if (m3_CLTX.HasValue)
				request.WithQueryParameter("CLTX", m3_CLTX.Value.ToString());
			if (m3_CADR.HasValue)
				request.WithQueryParameter("CADR", m3_CADR.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3_UCOS.Value.ToString());
			if (m3_JDCD.HasValue)
				request.WithQueryParameter("JDCD", m3_JDCD.Value.ToString());
			if (m3_RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3_RLDT.Value.ToM3String());
			if (m3_CODT.HasValue)
				request.WithQueryParameter("CODT", m3_CODT.Value.ToM3String());
			if (m3_EPRI.HasValue)
				request.WithQueryParameter("EPRI", m3_EPRI.Value.ToString());

			// Execute the request
			var result = await Execute<CpyOrderResponse>(
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
		/// Name DelBatchHead
		/// Description Delete batch order head record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBatchHead(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

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
		/// Name DelBatchLine
		/// Description Delete batch order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Temporary order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBatchLine(
			string m3_ORNO, 
			string m3_PONR, 
			int? m3_CONO = null, 
			string m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());

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
		/// Name DelBatchSalespe
		/// Description Delete Batch Salesperson
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ORNO">Temporary order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_SMCD">Salesperson (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBatchSalespe(
			string m3_ORNO, 
			int m3_PONR, 
			string m3_SMCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBatchSalespe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_SMCD))
				throw new ArgumentNullException("m3_SMCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("SMCD", m3_SMCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

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
		/// Name DelBatchText
		/// Description Delete text for head/line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_TYPE">Order head or line, 1=Head/2=Line (Required)</param>
		/// <param name="m3_TYTR">Type of text, 1=Pre/2=Post/3=F6 (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_TXHE">Document class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBatchText(
			string m3_ORNO, 
			string m3_TYPE, 
			string m3_TYTR, 
			int? m3_CONO = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_TXHE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBatchText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_TYPE))
				throw new ArgumentNullException("m3_TYPE");
			if (string.IsNullOrWhiteSpace(m3_TYTR))
				throw new ArgumentNullException("m3_TYTR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("TYPE", m3_TYPE.Trim())
				.WithQueryParameter("TYTR", m3_TYTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXHE))
				request.WithQueryParameter("TXHE", m3_TXHE.Trim());

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
		/// Name DelConnCOCharge
		/// Description Delete Connected CO Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelConnCOCharge(
			string m3_ORNO, 
			string m3_CRID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelConnCOCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());

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
		/// Name DelDocument
		/// Description Delete Connected Document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDocument(
			string m3_ORNO = null, 
			string m3_DONR = null, 
			string m3_DOVA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelDocument",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());

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
		/// Name DelHead
		/// Description Delete order head record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelHead(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

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
		/// Name DelLine
		/// Description Delete order line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_OT65">Statistics - lost sales</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLine(
			string m3_ORNO, 
			string m3_PONR, 
			int? m3_CONO = null, 
			string m3_POSX = null, 
			int? m3_OT65 = null, 
			string m3_RSCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());
			if (m3_OT65.HasValue)
				request.WithQueryParameter("OT65", m3_OT65.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());

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
		/// Name DelLineBatchEnt
		/// Description Delete CO line on an existing order via batch order entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelLineBatchEntResponse></returns>
		/// <exception cref="M3Exception<DelLineBatchEntResponse>"></exception>
		public async Task<M3Response<DelLineBatchEntResponse>> DelLineBatchEnt(
			string m3_ORNO, 
			string m3_PONR, 
			int? m3_CONO = null, 
			string m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLineBatchEnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());

			// Execute the request
			var result = await Execute<DelLineBatchEntResponse>(
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
		/// Name DelLineManRe
		/// Description Delete manual rebate record
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLineManRe(
			int m3_CONO, 
			string m3_ORNO, 
			int m3_PONR, 
			int m3_POSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLineManRe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString());

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
		/// Name DltBatchLnInfo
		/// Description Delet additional information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltBatchLnInfo(
			string m3_ORNO, 
			string m3_PONR, 
			string m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltBatchLnInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());

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
		/// Name DltLnInfo
		/// Description Delet additional information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLnInfo(
			string m3_ORNO, 
			string m3_PONR, 
			string m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltLnInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());

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
		/// Name GetATP
		/// Description Calculate ATP for given item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetATPResponse></returns>
		/// <exception cref="M3Exception<GetATPResponse>"></exception>
		public async Task<M3Response<GetATPResponse>> GetATP(
			string m3_ITNO, 
			string m3_WHLO, 
			int? m3_CONO = null, 
			DateTime? m3_DWDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetATP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetATPResponse>(
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
		/// Name GetAddrVreg
		/// Description Get adress and VAT-no
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_QLFI">Qualifier (Required)</param>
		/// <param name="m3_QLFV">Value for qualifier (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddrVregResponse></returns>
		/// <exception cref="M3Exception<GetAddrVregResponse>"></exception>
		public async Task<M3Response<GetAddrVregResponse>> GetAddrVreg(
			string m3_QLFI, 
			string m3_QLFV, 
			int? m3_CONO = null, 
			string m3_ORNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddrVreg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QLFI))
				throw new ArgumentNullException("m3_QLFI");
			if (string.IsNullOrWhiteSpace(m3_QLFV))
				throw new ArgumentNullException("m3_QLFV");

			// Set mandatory parameters
			request
				.WithQueryParameter("QLFI", m3_QLFI.Trim())
				.WithQueryParameter("QLFV", m3_QLFV.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Execute the request
			var result = await Execute<GetAddrVregResponse>(
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
		/// Name GetAddress
		/// Description Get address for customer order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			string m3_ORNO, 
			int m3_ADRT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("ADRT", m3_ADRT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetAddressResponse>(
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
		/// Name GetBatchHead
		/// Description Retrieve batch order head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchHeadResponse></returns>
		/// <exception cref="M3Exception<GetBatchHeadResponse>"></exception>
		public async Task<M3Response<GetBatchHeadResponse>> GetBatchHead(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetBatchHeadResponse>(
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
		/// Name GetBatchLine
		/// Description Retrieve batch order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Temporary ordernumber (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchLineResponse></returns>
		/// <exception cref="M3Exception<GetBatchLineResponse>"></exception>
		public async Task<M3Response<GetBatchLineResponse>> GetBatchLine(
			string m3_ORNO, 
			string m3_PONR, 
			int? m3_CONO = null, 
			string m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());

			// Execute the request
			var result = await Execute<GetBatchLineResponse>(
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
		/// Name GetBatchLnInfo
		/// Description Retrieve batch order line additional information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ORNO">Temporary ordernumber (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchLnInfoResponse></returns>
		/// <exception cref="M3Exception<GetBatchLnInfoResponse>"></exception>
		public async Task<M3Response<GetBatchLnInfoResponse>> GetBatchLnInfo(
			string m3_ORNO, 
			int m3_PONR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBatchLnInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<GetBatchLnInfoResponse>(
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
		/// Name GetBatchQuot
		/// Description Get quotation information for an order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchQuotResponse></returns>
		/// <exception cref="M3Exception<GetBatchQuotResponse>"></exception>
		public async Task<M3Response<GetBatchQuotResponse>> GetBatchQuot(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBatchQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetBatchQuotResponse>(
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
		/// Name GetConfigData
		/// Description Get configuration data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetConfigDataResponse></returns>
		/// <exception cref="M3Exception<GetConfigDataResponse>"></exception>
		public async Task<M3Response<GetConfigDataResponse>> GetConfigData(
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetConfigData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<GetConfigDataResponse>(
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
		/// Name GetDelHeadChrg
		/// Description Retrieve charges connected to Delivery Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelHeadChrgResponse></returns>
		/// <exception cref="M3Exception<GetDelHeadChrgResponse>"></exception>
		public async Task<M3Response<GetDelHeadChrgResponse>> GetDelHeadChrg(
			string m3_ORNO, 
			decimal m3_DLIX, 
			string m3_CRID, 
			string m3_WHLO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDelHeadChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("CRID", m3_CRID.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetDelHeadChrgResponse>(
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
		/// Name GetDocClasses
		/// Description Retrieves document classes for customer order
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3_FLDN">Field number</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_KFLD">File key</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDocClassesResponse></returns>
		/// <exception cref="M3Exception<GetDocClassesResponse>"></exception>
		public async Task<M3Response<GetDocClassesResponse>> GetDocClasses(
			string m3_FLDN = null, 
			string m3_LNCD = null, 
			string m3_FILE = null, 
			string m3_KFLD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDocClasses",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FLDN))
				request.WithQueryParameter("FLDN", m3_FLDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KFLD))
				request.WithQueryParameter("KFLD", m3_KFLD.Trim());

			// Execute the request
			var result = await Execute<GetDocClassesResponse>(
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
		/// Name GetDocument
		/// Description Get Connected Document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDocumentResponse></returns>
		/// <exception cref="M3Exception<GetDocumentResponse>"></exception>
		public async Task<M3Response<GetDocumentResponse>> GetDocument(
			string m3_ORNO = null, 
			string m3_DONR = null, 
			string m3_DOVA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDocument",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());

			// Execute the request
			var result = await Execute<GetDocumentResponse>(
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
		/// Name GetHead
		/// Description Retrieve customer order head information
		/// Version Release: 5eaC
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetHeadText
		/// Description Retrieve text associated with the order head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TYTR">Type of text, 1=Pre/2=Post</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadTextResponse></returns>
		/// <exception cref="M3Exception<GetHeadTextResponse>"></exception>
		public async Task<M3Response<GetHeadTextResponse>> GetHeadText(
			string m3_ORNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			string m3_TYTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TYTR))
				request.WithQueryParameter("TYTR", m3_TYTR.Trim());

			// Execute the request
			var result = await Execute<GetHeadTextResponse>(
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
		/// Name GetLine
		/// Description Retrieve customer order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3_ORNO, 
			string m3_PONR, 
			int? m3_CONO = null, 
			string m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());

			// Execute the request
			var result = await Execute<GetLineResponse>(
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
		/// Name GetLine2
		/// Description Retrieve customer order line part 2
		/// Version Release: 5eaB
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLine2Response></returns>
		/// <exception cref="M3Exception<GetLine2Response>"></exception>
		public async Task<M3Response<GetLine2Response>> GetLine2(
			string m3_ORNO, 
			int m3_PONR, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLine2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<GetLine2Response>(
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
		/// Name GetLineAddress
		/// Description Retrieve CO Line address.
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PONR">Order line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineAddressResponse></returns>
		/// <exception cref="M3Exception<GetLineAddressResponse>"></exception>
		public async Task<M3Response<GetLineAddressResponse>> GetLineAddress(
			string m3_ORNO, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLineAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<GetLineAddressResponse>(
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
		/// Name GetLineChrg
		/// Description Retrieve line charges connected to order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_CRTY">Internal charge (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineChrgResponse></returns>
		/// <exception cref="M3Exception<GetLineChrgResponse>"></exception>
		public async Task<M3Response<GetLineChrgResponse>> GetLineChrg(
			string m3_ORNO, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_CRID, 
			int m3_CRTY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLineChrg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("CRID", m3_CRID.Trim())
				.WithQueryParameter("CRTY", m3_CRTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetLineChrgResponse>(
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
		/// Name GetLineChrgTot
		/// Description GetLineChrgTot
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineChrgTotResponse></returns>
		/// <exception cref="M3Exception<GetLineChrgTotResponse>"></exception>
		public async Task<M3Response<GetLineChrgTotResponse>> GetLineChrgTot(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLineChrgTot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Execute the request
			var result = await Execute<GetLineChrgTotResponse>(
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
		/// Name GetLineManRe
		/// Description Retrieve manual rebate connected the order line
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineManReResponse></returns>
		/// <exception cref="M3Exception<GetLineManReResponse>"></exception>
		public async Task<M3Response<GetLineManReResponse>> GetLineManRe(
			int m3_CONO, 
			string m3_ORNO, 
			int m3_PONR, 
			int m3_POSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLineManRe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString());

			// Execute the request
			var result = await Execute<GetLineManReResponse>(
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
		/// Name GetLinePurch
		/// Description Get purchase info of order line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLinePurchResponse></returns>
		/// <exception cref="M3Exception<GetLinePurchResponse>"></exception>
		public async Task<M3Response<GetLinePurchResponse>> GetLinePurch(
			string m3_ORNO, 
			string m3_PONR, 
			int? m3_CONO = null, 
			string m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLinePurch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());

			// Execute the request
			var result = await Execute<GetLinePurchResponse>(
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
		/// Name GetLineText
		/// Description Retrieve text associated with the order line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_TYTR">Type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineTextResponse></returns>
		/// <exception cref="M3Exception<GetLineTextResponse>"></exception>
		public async Task<M3Response<GetLineTextResponse>> GetLineText(
			string m3_ORNO, 
			string m3_PONR, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			string m3_POSX = null, 
			string m3_TYTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLineText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TYTR))
				request.WithQueryParameter("TYTR", m3_TYTR.Trim());

			// Execute the request
			var result = await Execute<GetLineTextResponse>(
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
		/// Name GetLnInfo
		/// Description Retrieve batch order line additional information
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ORNO">Temporary ordernumber (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLnInfoResponse></returns>
		/// <exception cref="M3Exception<GetLnInfoResponse>"></exception>
		public async Task<M3Response<GetLnInfoResponse>> GetLnInfo(
			string m3_ORNO, 
			int m3_PONR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLnInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<GetLnInfoResponse>(
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
		/// Name GetMapping
		/// Description Map the input fields to the M3/CAT fields
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMappingResponse></returns>
		/// <exception cref="M3Exception<GetMappingResponse>"></exception>
		public async Task<M3Response<GetMappingResponse>> GetMapping(
			int? m3_CONO = null, 
			string m3_CUNO = null, 
			string m3_FACI = null, 
			string m3_ORTP = null, 
			string m3_MODL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMapping",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());

			// Execute the request
			var result = await Execute<GetMappingResponse>(
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
		/// Name GetNextDlyDate
		/// Description Get Next Delivery Date
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetNextDlyDateResponse></returns>
		/// <exception cref="M3Exception<GetNextDlyDateResponse>"></exception>
		public async Task<M3Response<GetNextDlyDateResponse>> GetNextDlyDate(
			string m3_ORNO, 
			int m3_PONR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetNextDlyDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Execute the request
			var result = await Execute<GetNextDlyDateResponse>(
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
		/// Name GetOrderNo
		/// Description Get Order no from batch order no
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Temporary order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderNoResponse></returns>
		/// <exception cref="M3Exception<GetOrderNoResponse>"></exception>
		public async Task<M3Response<GetOrderNoResponse>> GetOrderNo(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOrderNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetOrderNoResponse>(
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
		/// Name GetOrderPromise
		/// Description Get ordered to promise
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ORQT">Ordered quantity (Required)</param>
		/// <param name="m3_DWDT">Requested delivery date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderPromiseResponse></returns>
		/// <exception cref="M3Exception<GetOrderPromiseResponse>"></exception>
		public async Task<M3Response<GetOrderPromiseResponse>> GetOrderPromise(
			string m3_ITNO, 
			decimal m3_ORQT, 
			DateTime m3_DWDT, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOrderPromise",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ORQT", m3_ORQT.ToString())
				.WithQueryParameter("DWDT", m3_DWDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<GetOrderPromiseResponse>(
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
		/// Name GetOrderType
		/// Description Displays order type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderTypeResponse></returns>
		/// <exception cref="M3Exception<GetOrderTypeResponse>"></exception>
		public async Task<M3Response<GetOrderTypeResponse>> GetOrderType(
			string m3_CUNO = null, 
			string m3_RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOrderType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<GetOrderTypeResponse>(
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
		/// Name GetOrderValue
		/// Description Retrieve order value information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderValueResponse></returns>
		/// <exception cref="M3Exception<GetOrderValueResponse>"></exception>
		public async Task<M3Response<GetOrderValueResponse>> GetOrderValue(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOrderValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetOrderValueResponse>(
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
		/// Name GetPanelSeq
		/// Description Get panel sequence
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_HEAD">Only panels for OIS100</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPanelSeqResponse></returns>
		/// <exception cref="M3Exception<GetPanelSeqResponse>"></exception>
		public async Task<M3Response<GetPanelSeqResponse>> GetPanelSeq(
			string m3_ORTP = null, 
			string m3_RESP = null, 
			string m3_HEAD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPanelSeq",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HEAD))
				request.WithQueryParameter("HEAD", m3_HEAD.Trim());

			// Execute the request
			var result = await Execute<GetPanelSeqResponse>(
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
		/// Name GetQuot
		/// Description Get quotation information for an order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQuotResponse></returns>
		/// <exception cref="M3Exception<GetQuotResponse>"></exception>
		public async Task<M3Response<GetQuotResponse>> GetQuot(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetQuotResponse>(
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
		/// Description Retrieves text for a customer order
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3_FLDN">Field number</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_KFLD">File key</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTextResponse></returns>
		/// <exception cref="M3Exception<GetTextResponse>"></exception>
		public async Task<M3Response<GetTextResponse>> GetText(
			string m3_FLDN = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
			string m3_FILE = null, 
			string m3_KFLD = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FLDN))
				request.WithQueryParameter("FLDN", m3_FLDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KFLD))
				request.WithQueryParameter("KFLD", m3_KFLD.Trim());

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
		/// Name LockOrder
		/// Description Sales Desk - Lock order by changing OAHOCD to 9
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> LockOrder(
			int? m3_CONO = null, 
			string m3_ORNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LockOrder",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());

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
		/// Name LstBLInByPurAgr
		/// Description LstLine
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_ORSL">Lowest status - customer order</param>
		/// <param name="m3_ORST">Highest status - customer order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBLInByPurAgrResponse></returns>
		/// <exception cref="M3Exception<LstBLInByPurAgrResponse>"></exception>
		public async Task<M3Response<LstBLInByPurAgrResponse>> LstBLInByPurAgr(
			string m3_SUNO, 
			string m3_AGNB, 
			int m3_SEQN, 
			string m3_ORSL = null, 
			string m3_ORST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBLInByPurAgr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORSL))
				request.WithQueryParameter("ORSL", m3_ORSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORST))
				request.WithQueryParameter("ORST", m3_ORST.Trim());

			// Execute the request
			var result = await Execute<LstBLInByPurAgrResponse>(
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
		/// Name LstBatchHead
		/// Description Retrieve customer order head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORSL">Order status from</param>
		/// <param name="m3_ORST">Order status to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBatchHeadResponse></returns>
		/// <exception cref="M3Exception<LstBatchHeadResponse>"></exception>
		public async Task<M3Response<LstBatchHeadResponse>> LstBatchHead(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_ORSL = null, 
			string m3_ORST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORSL))
				request.WithQueryParameter("ORSL", m3_ORSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORST))
				request.WithQueryParameter("ORST", m3_ORST.Trim());

			// Execute the request
			var result = await Execute<LstBatchHeadResponse>(
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
		/// Name LstBatchLine
		/// Description List all order lines for given batch order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Temporary ordernumber (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBatchLineResponse></returns>
		/// <exception cref="M3Exception<LstBatchLineResponse>"></exception>
		public async Task<M3Response<LstBatchLineResponse>> LstBatchLine(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstBatchLineResponse>(
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
		/// Name LstCOLineInfo
		/// Description Lists CO line information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_COSF">Cost factor</param>
		/// <param name="m3_LORD">Order lines in descending order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCOLineInfoResponse></returns>
		/// <exception cref="M3Exception<LstCOLineInfoResponse>"></exception>
		public async Task<M3Response<LstCOLineInfoResponse>> LstCOLineInfo(
			string m3_ORNO = null, 
			int? m3_COSF = null, 
			string m3_LORD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCOLineInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_COSF.HasValue)
				request.WithQueryParameter("COSF", m3_COSF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LORD))
				request.WithQueryParameter("LORD", m3_LORD.Trim());

			// Execute the request
			var result = await Execute<LstCOLineInfoResponse>(
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
		/// Name LstConnCOCharge
		/// Description List Connected CO Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConnCOChargeResponse></returns>
		/// <exception cref="M3Exception<LstConnCOChargeResponse>"></exception>
		public async Task<M3Response<LstConnCOChargeResponse>> LstConnCOCharge(
			string m3_ORNO, 
			decimal? m3_DLIX = null, 
			string m3_CRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstConnCOCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());

			// Execute the request
			var result = await Execute<LstConnCOChargeResponse>(
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
		/// Name LstDelLineByCO
		/// Description List Delivery Lines By CO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelLineByCOResponse></returns>
		/// <exception cref="M3Exception<LstDelLineByCOResponse>"></exception>
		public async Task<M3Response<LstDelLineByCOResponse>> LstDelLineByCO(
			string m3_ORNO, 
			int m3_PONR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDelLineByCO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<LstDelLineByCOResponse>(
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
		/// Name LstDlyDates
		/// Description List Delivery Dates
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_NUM2">Number of Confirmed delivery dates</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDlyDatesResponse></returns>
		/// <exception cref="M3Exception<LstDlyDatesResponse>"></exception>
		public async Task<M3Response<LstDlyDatesResponse>> LstDlyDates(
			string m3_ORNO, 
			int m3_PONR, 
			int? m3_NUM2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDlyDates",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_NUM2.HasValue)
				request.WithQueryParameter("NUM2", m3_NUM2.Value.ToString());

			// Execute the request
			var result = await Execute<LstDlyDatesResponse>(
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
		/// Name LstDocument
		/// Description List Connected documents
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDocumentResponse></returns>
		/// <exception cref="M3Exception<LstDocumentResponse>"></exception>
		public async Task<M3Response<LstDocumentResponse>> LstDocument(
			string m3_ORNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDocument",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Execute the request
			var result = await Execute<LstDocumentResponse>(
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
		/// Name LstErrMsgOrder
		/// Description List error messages on order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Temporary order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrMsgOrderResponse></returns>
		/// <exception cref="M3Exception<LstErrMsgOrderResponse>"></exception>
		public async Task<M3Response<LstErrMsgOrderResponse>> LstErrMsgOrder(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstErrMsgOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstErrMsgOrderResponse>(
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
		/// Name LstHead
		/// Description Retrieve customer order head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORSL">Order status from</param>
		/// <param name="m3_ORST">Order status to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadResponse></returns>
		/// <exception cref="M3Exception<LstHeadResponse>"></exception>
		public async Task<M3Response<LstHeadResponse>> LstHead(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_ORSL = null, 
			string m3_ORST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORSL))
				request.WithQueryParameter("ORSL", m3_ORSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORST))
				request.WithQueryParameter("ORST", m3_ORST.Trim());

			// Execute the request
			var result = await Execute<LstHeadResponse>(
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
		/// Name LstHeadText
		/// Description Retrieve text associated with the order head
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_TYTR">Type of text, 1=Pre/2=Post/3=General (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TXV9">Text block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadTextResponse></returns>
		/// <exception cref="M3Exception<LstHeadTextResponse>"></exception>
		public async Task<M3Response<LstHeadTextResponse>> LstHeadText(
			string m3_ORNO, 
			string m3_TYTR, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			string m3_TXV9 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHeadText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_TYTR))
				throw new ArgumentNullException("m3_TYTR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("TYTR", m3_TYTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXV9))
				request.WithQueryParameter("TXV9", m3_TXV9.Trim());

			// Execute the request
			var result = await Execute<LstHeadTextResponse>(
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
		/// Name LstItmAltQty
		/// Description Lists Item alternate quantity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_CHL1">Business chain - level 1</param>
		/// <param name="m3_CHL2">Business chain - level 2</param>
		/// <param name="m3_CHL3">Business chain - level 3</param>
		/// <param name="m3_CHL4">Business chain - level 4</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmAltQtyResponse></returns>
		/// <exception cref="M3Exception<LstItmAltQtyResponse>"></exception>
		public async Task<M3Response<LstItmAltQtyResponse>> LstItmAltQty(
			string m3_ITNO = null, 
			string m3_WHLO = null, 
			string m3_CUNO = null, 
			string m3_ORTP = null, 
			string m3_TEPA = null, 
			string m3_CHL1 = null, 
			string m3_CHL2 = null, 
			string m3_CHL3 = null, 
			string m3_CHL4 = null, 
			string m3_ADID = null, 
			decimal? m3_TRQT = null, 
			string m3_ALUN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmAltQty",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL1))
				request.WithQueryParameter("CHL1", m3_CHL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL2))
				request.WithQueryParameter("CHL2", m3_CHL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL3))
				request.WithQueryParameter("CHL3", m3_CHL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHL4))
				request.WithQueryParameter("CHL4", m3_CHL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());

			// Execute the request
			var result = await Execute<LstItmAltQtyResponse>(
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
		/// Description List all order lines for given customer order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Ordernumber (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORST">Highest status - customer order</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3_ORNO, 
			int? m3_CONO = null, 
			string m3_ORST = null, 
			string m3_ITNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORST))
				request.WithQueryParameter("ORST", m3_ORST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

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

		/// <summary>
		/// Name LstLine2
		/// Description List all order lines for given customer order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Ordernumber (Required)</param>
		/// <param name="m3_ORST">Highest status - customer order</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLine2Response></returns>
		/// <exception cref="M3Exception<LstLine2Response>"></exception>
		public async Task<M3Response<LstLine2Response>> LstLine2(
			string m3_ORNO, 
			string m3_ORST = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLine2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORST))
				request.WithQueryParameter("ORST", m3_ORST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstLine2Response>(
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
		/// Name LstLineBOD
		/// Description List all order lines for given customer order.
		/// Version Release: 5eaB
		/// </summary>
		/// <param name="m3_ORNO">Ordernumber (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORST">Highest status - customer order</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineBODResponse></returns>
		/// <exception cref="M3Exception<LstLineBODResponse>"></exception>
		public async Task<M3Response<LstLineBODResponse>> LstLineBOD(
			string m3_ORNO, 
			int? m3_CONO = null, 
			string m3_ORST = null, 
			string m3_ITNO = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineBOD",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORST))
				request.WithQueryParameter("ORST", m3_ORST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<LstLineBODResponse>(
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
		/// Name LstLineByKitLvl
		/// Description List orderline by kitlevel
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_KTLV">Kitlevel, 0=Kitmother, 1= Kitcomponents (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineByKitLvlResponse></returns>
		/// <exception cref="M3Exception<LstLineByKitLvlResponse>"></exception>
		public async Task<M3Response<LstLineByKitLvlResponse>> LstLineByKitLvl(
			string m3_ORNO, 
			string m3_KTLV, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineByKitLvl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_KTLV))
				throw new ArgumentNullException("m3_KTLV");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("KTLV", m3_KTLV.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstLineByKitLvlResponse>(
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
		/// Name LstLineCharge
		/// Description LstLineCharge
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineChargeResponse></returns>
		/// <exception cref="M3Exception<LstLineChargeResponse>"></exception>
		public async Task<M3Response<LstLineChargeResponse>> LstLineCharge(
			string m3_ORNO, 
			int m3_PONR, 
			int? m3_POSX = null, 
			string m3_CRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());

			// Execute the request
			var result = await Execute<LstLineChargeResponse>(
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
		/// Name LstLinePurch
		/// Description List purchase info of all order lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Ordernumber (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORST">Highest status - customer order</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLinePurchResponse></returns>
		/// <exception cref="M3Exception<LstLinePurchResponse>"></exception>
		public async Task<M3Response<LstLinePurchResponse>> LstLinePurch(
			string m3_ORNO, 
			int? m3_CONO = null, 
			string m3_ORST = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLinePurch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORST))
				request.WithQueryParameter("ORST", m3_ORST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstLinePurchResponse>(
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
		/// Name LstLineText
		/// Description Retrieve text associated with the order line
		/// Version Release: 5ea9
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_TYTR">Type of text, 1=Pre/2=Post (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_TXV9">Text block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineTextResponse></returns>
		/// <exception cref="M3Exception<LstLineTextResponse>"></exception>
		public async Task<M3Response<LstLineTextResponse>> LstLineText(
			string m3_ORNO, 
			string m3_PONR, 
			string m3_TYTR, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			string m3_POSX = null, 
			string m3_TXV9 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");
			if (string.IsNullOrWhiteSpace(m3_TYTR))
				throw new ArgumentNullException("m3_TYTR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim())
				.WithQueryParameter("TYTR", m3_TYTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXV9))
				request.WithQueryParameter("TXV9", m3_TXV9.Trim());

			// Execute the request
			var result = await Execute<LstLineTextResponse>(
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
		/// Name LstLinesByItem
		/// Description List orderlines sorted by item number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_ORST">Order status to (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLinesByItemResponse></returns>
		/// <exception cref="M3Exception<LstLinesByItemResponse>"></exception>
		public async Task<M3Response<LstLinesByItemResponse>> LstLinesByItem(
			string m3_CUNO, 
			string m3_ORST, 
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLinesByItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_ORST))
				throw new ArgumentNullException("m3_ORST");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ORST", m3_ORST.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstLinesByItemResponse>(
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
		/// Name LstNewBalances
		/// Description List new and changed warehouse balances based on LMTS
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNewBalancesResponse></returns>
		/// <exception cref="M3Exception<LstNewBalancesResponse>"></exception>
		public async Task<M3Response<LstNewBalancesResponse>> LstNewBalances(
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNewBalances",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstNewBalancesResponse>(
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
		/// Name LstOrderCharge
		/// Description List order charges
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOrderChargeResponse></returns>
		/// <exception cref="M3Exception<LstOrderChargeResponse>"></exception>
		public async Task<M3Response<LstOrderChargeResponse>> LstOrderCharge(
			string m3_ORNO, 
			string m3_CRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOrderCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());

			// Execute the request
			var result = await Execute<LstOrderChargeResponse>(
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
		/// Name LstOrderTypes
		/// Description Retrieve order types for given company
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOrderTypesResponse></returns>
		/// <exception cref="M3Exception<LstOrderTypesResponse>"></exception>
		public async Task<M3Response<LstOrderTypesResponse>> LstOrderTypes(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOrderTypes",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstOrderTypesResponse>(
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
		/// Name LstQuot
		/// Description List batch quotations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuotResponse></returns>
		/// <exception cref="M3Exception<LstQuotResponse>"></exception>
		public async Task<M3Response<LstQuotResponse>> LstQuot(
			string m3_CUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstQuotResponse>(
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
		/// Name LstWarehBalance
		/// Description Retrieve warehouse balance for given item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWarehBalanceResponse></returns>
		/// <exception cref="M3Exception<LstWarehBalanceResponse>"></exception>
		public async Task<M3Response<LstWarehBalanceResponse>> LstWarehBalance(
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstWarehBalance",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstWarehBalanceResponse>(
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
		/// Name ReleaseOrder
		/// Description Sales Desk - Release order by changing OAHOCD to 0
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReleaseOrder(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReleaseOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

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
		/// Name RetrOrderNo
		/// Description Sales Desk - Retrieve customer order number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORTP">Customer order type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RetrOrderNoResponse></returns>
		/// <exception cref="M3Exception<RetrOrderNoResponse>"></exception>
		public async Task<M3Response<RetrOrderNoResponse>> RetrOrderNo(
			string m3_ORTP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RetrOrderNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORTP))
				throw new ArgumentNullException("m3_ORTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORTP", m3_ORTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<RetrOrderNoResponse>(
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
		/// Name SearchHead
		/// Description Search order heads
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchHeadResponse></returns>
		/// <exception cref="M3Exception<SearchHeadResponse>"></exception>
		public async Task<M3Response<SearchHeadResponse>> SearchHead(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchHeadResponse>(
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
		/// Name SearchLine
		/// Description Search order lines
		/// Version Release: 5ea6
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchLineResponse></returns>
		/// <exception cref="M3Exception<SearchLineResponse>"></exception>
		public async Task<M3Response<SearchLineResponse>> SearchLine(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchLineResponse>(
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
		/// Name SearchQuotation
		/// Description Search quotation
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchQuotationResponse></returns>
		/// <exception cref="M3Exception<SearchQuotationResponse>"></exception>
		public async Task<M3Response<SearchQuotationResponse>> SearchQuotation(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchQuotation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchQuotationResponse>(
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
		/// Name SndBatchLine
		/// Description Add batch order line without answer
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Temporary order number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORQT">Ordered quantity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_JDCD">Joint delivery code</param>
		/// <param name="m3_CUPO">Customers order line number</param>
		/// <param name="m3_SAPR">Salesprice</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_DIA2">Discount amount 2</param>
		/// <param name="m3_DIA3">Discount amount 3</param>
		/// <param name="m3_DIA4">Discount amount 4</param>
		/// <param name="m3_DIA5">Discount amount 5</param>
		/// <param name="m3_DIA6">Discount amount 6</param>
		/// <param name="m3_DLSP">Delivery specification</param>
		/// <param name="m3_DLSX">Delivery specification text</param>
		/// <param name="m3_CFXX">Old CFIN</param>
		/// <param name="m3_ECVS">Simulations number</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_CODT">Confirmed date of delivery</param>
		/// <param name="m3_ITDS">Item description</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUPA">Customers packaging identity</param>
		/// <param name="m3_DWHM">Requested delivery time</param>
		/// <param name="m3_D1QT">Standard quantity</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_SPUN">Sales price unit of measure</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_TIZO">Time zone</param>
		/// <param name="m3_EDFP">Reference price</param>
		/// <param name="m3_AGNO">Blanket agreement number</param>
		/// <param name="m3_DWDZ">Requested delivery date</param>
		/// <param name="m3_DWHZ">Requested delivery time</param>
		/// <param name="m3_COHM">Confirmed delivery time</param>
		/// <param name="m3_CODZ">Confirmed delivery date</param>
		/// <param name="m3_COHZ">Confirmed delivery time</param>
		/// <param name="m3_HDPR">Main product</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_CUSX">Line suffix</param>
		/// <param name="m3_DIC1">Status - discount</param>
		/// <param name="m3_DIC2">Status - discount</param>
		/// <param name="m3_DIC3">Status - discount</param>
		/// <param name="m3_DIC4">Status - discount</param>
		/// <param name="m3_DIC5">Status - discount</param>
		/// <param name="m3_DIC6">Status - discount</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_BANO">Batch no</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_DIP1">Discount 1</param>
		/// <param name="m3_DIP2">Discount 2</param>
		/// <param name="m3_DIP3">Discount 3</param>
		/// <param name="m3_DIP4">Discount 4</param>
		/// <param name="m3_DIP5">Discount 5</param>
		/// <param name="m3_DIP6">Discount 6</param>
		/// <param name="m3_CMNO">Sales campaign</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_PRHL">Product number highest level</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_GWTP">Granted warranty type</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_PRHW">Product number highest level</param>
		/// <param name="m3_SERW">Serial number</param>
		/// <param name="m3_PWNR">Order line number</param>
		/// <param name="m3_PWSX">Line suffix</param>
		/// <param name="m3_EWST">Extended warranty start</param>
		/// <param name="m3_TECN">Tax exemption contract number</param>
		/// <param name="m3_INAP">Industry Application</param>
		/// <param name="m3_DRDN">Demand order number</param>
		/// <param name="m3_DRDL">Demand order line</param>
		/// <param name="m3_DRDX">Line suffix</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_PIDE">Promotion</param>
		/// <param name="m3_MCHP">Price change indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndBatchLine(
			string m3_ORNO, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			decimal? m3_ORQT = null, 
			string m3_WHLO = null, 
			DateTime? m3_DWDT = null, 
			string m3_JDCD = null, 
			string m3_CUPO = null, 
			decimal? m3_SAPR = null, 
			decimal? m3_DIA1 = null, 
			decimal? m3_DIA2 = null, 
			decimal? m3_DIA3 = null, 
			decimal? m3_DIA4 = null, 
			string m3_DIA5 = null, 
			string m3_DIA6 = null, 
			string m3_DLSP = null, 
			string m3_DLSX = null, 
			int? m3_CFXX = null, 
			int? m3_ECVS = null, 
			string m3_ALUN = null, 
			DateTime? m3_CODT = null, 
			string m3_ITDS = null, 
			string m3_ALWQ = null, 
			int? m3_ALWT = null, 
			string m3_CUOR = null, 
			string m3_CUPA = null, 
			int? m3_DWHM = null, 
			decimal? m3_D1QT = null, 
			string m3_PACT = null, 
			string m3_POPN = null, 
			int? m3_SACD = null, 
			string m3_SPUN = null, 
			string m3_TEPA = null, 
			string m3_TIZO = null, 
			decimal? m3_EDFP = null, 
			string m3_AGNO = null, 
			DateTime? m3_DWDZ = null, 
			int? m3_DWHZ = null, 
			int? m3_COHM = null, 
			DateTime? m3_CODZ = null, 
			int? m3_COHZ = null, 
			string m3_HDPR = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_CAMU = null, 
			string m3_ADID = null, 
			int? m3_CUSX = null, 
			int? m3_DIC1 = null, 
			int? m3_DIC2 = null, 
			int? m3_DIC3 = null, 
			int? m3_DIC4 = null, 
			int? m3_DIC5 = null, 
			int? m3_DIC6 = null, 
			long? m3_CFIN = null, 
			string m3_BANO = null, 
			string m3_WHSL = null, 
			int? m3_DIP1 = null, 
			int? m3_DIP2 = null, 
			int? m3_DIP3 = null, 
			int? m3_DIP4 = null, 
			int? m3_DIP5 = null, 
			int? m3_DIP6 = null, 
			string m3_CMNO = null, 
			string m3_RSCD = null, 
			string m3_PRHL = null, 
			string m3_SERN = null, 
			string m3_CTNO = null, 
			string m3_CFGL = null, 
			string m3_GWTP = null, 
			string m3_WATP = null, 
			string m3_PRHW = null, 
			string m3_SERW = null, 
			int? m3_PWNR = null, 
			int? m3_PWSX = null, 
			int? m3_EWST = null, 
			string m3_TECN = null, 
			string m3_INAP = null, 
			string m3_DRDN = null, 
			int? m3_DRDL = null, 
			int? m3_DRDX = null, 
			string m3_TEPY = null, 
			string m3_PIDE = null, 
			int? m3_MCHP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_JDCD))
				request.WithQueryParameter("JDCD", m3_JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPO))
				request.WithQueryParameter("CUPO", m3_CUPO.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3_DIA1.Value.ToString());
			if (m3_DIA2.HasValue)
				request.WithQueryParameter("DIA2", m3_DIA2.Value.ToString());
			if (m3_DIA3.HasValue)
				request.WithQueryParameter("DIA3", m3_DIA3.Value.ToString());
			if (m3_DIA4.HasValue)
				request.WithQueryParameter("DIA4", m3_DIA4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIA5))
				request.WithQueryParameter("DIA5", m3_DIA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIA6))
				request.WithQueryParameter("DIA6", m3_DIA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSP))
				request.WithQueryParameter("DLSP", m3_DLSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLSX))
				request.WithQueryParameter("DLSX", m3_DLSX.Trim());
			if (m3_CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3_CFXX.Value.ToString());
			if (m3_ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3_ECVS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_CODT.HasValue)
				request.WithQueryParameter("CODT", m3_CODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (m3_DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3_DWHM.Value.ToString());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPUN))
				request.WithQueryParameter("SPUN", m3_SPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIZO))
				request.WithQueryParameter("TIZO", m3_TIZO.Trim());
			if (m3_EDFP.HasValue)
				request.WithQueryParameter("EDFP", m3_EDFP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNO))
				request.WithQueryParameter("AGNO", m3_AGNO.Trim());
			if (m3_DWDZ.HasValue)
				request.WithQueryParameter("DWDZ", m3_DWDZ.Value.ToM3String());
			if (m3_DWHZ.HasValue)
				request.WithQueryParameter("DWHZ", m3_DWHZ.Value.ToString());
			if (m3_COHM.HasValue)
				request.WithQueryParameter("COHM", m3_COHM.Value.ToString());
			if (m3_CODZ.HasValue)
				request.WithQueryParameter("CODZ", m3_CODZ.Value.ToM3String());
			if (m3_COHZ.HasValue)
				request.WithQueryParameter("COHZ", m3_COHZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_HDPR))
				request.WithQueryParameter("HDPR", m3_HDPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3_CUSX.Value.ToString());
			if (m3_DIC1.HasValue)
				request.WithQueryParameter("DIC1", m3_DIC1.Value.ToString());
			if (m3_DIC2.HasValue)
				request.WithQueryParameter("DIC2", m3_DIC2.Value.ToString());
			if (m3_DIC3.HasValue)
				request.WithQueryParameter("DIC3", m3_DIC3.Value.ToString());
			if (m3_DIC4.HasValue)
				request.WithQueryParameter("DIC4", m3_DIC4.Value.ToString());
			if (m3_DIC5.HasValue)
				request.WithQueryParameter("DIC5", m3_DIC5.Value.ToString());
			if (m3_DIC6.HasValue)
				request.WithQueryParameter("DIC6", m3_DIC6.Value.ToString());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_DIP1.HasValue)
				request.WithQueryParameter("DIP1", m3_DIP1.Value.ToString());
			if (m3_DIP2.HasValue)
				request.WithQueryParameter("DIP2", m3_DIP2.Value.ToString());
			if (m3_DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3_DIP3.Value.ToString());
			if (m3_DIP4.HasValue)
				request.WithQueryParameter("DIP4", m3_DIP4.Value.ToString());
			if (m3_DIP5.HasValue)
				request.WithQueryParameter("DIP5", m3_DIP5.Value.ToString());
			if (m3_DIP6.HasValue)
				request.WithQueryParameter("DIP6", m3_DIP6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CMNO))
				request.WithQueryParameter("CMNO", m3_CMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRHL))
				request.WithQueryParameter("PRHL", m3_PRHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GWTP))
				request.WithQueryParameter("GWTP", m3_GWTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRHW))
				request.WithQueryParameter("PRHW", m3_PRHW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERW))
				request.WithQueryParameter("SERW", m3_SERW.Trim());
			if (m3_PWNR.HasValue)
				request.WithQueryParameter("PWNR", m3_PWNR.Value.ToString());
			if (m3_PWSX.HasValue)
				request.WithQueryParameter("PWSX", m3_PWSX.Value.ToString());
			if (m3_EWST.HasValue)
				request.WithQueryParameter("EWST", m3_EWST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECN))
				request.WithQueryParameter("TECN", m3_TECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INAP))
				request.WithQueryParameter("INAP", m3_INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DRDN))
				request.WithQueryParameter("DRDN", m3_DRDN.Trim());
			if (m3_DRDL.HasValue)
				request.WithQueryParameter("DRDL", m3_DRDL.Value.ToString());
			if (m3_DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3_DRDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIDE))
				request.WithQueryParameter("PIDE", m3_PIDE.Trim());
			if (m3_MCHP.HasValue)
				request.WithQueryParameter("MCHP", m3_MCHP.Value.ToString());

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
		/// Name SndBatchText
		/// Description Add text for order head/line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Order number (Required)</param>
		/// <param name="m3_TYPE">Order head or Line, 1=Head/2=Line (Required)</param>
		/// <param name="m3_TYTR">Type of text, 1=Pre/2=Post/3=F6 (Required)</param>
		/// <param name="m3_PARM">Text (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_TXHE">Document class</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndBatchText(
			string m3_ORNO, 
			string m3_TYPE, 
			int m3_TYTR, 
			string m3_PARM, 
			int? m3_CONO = null, 
			int? m3_POSX = null, 
			string m3_TXHE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndBatchText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_TYPE))
				throw new ArgumentNullException("m3_TYPE");
			if (string.IsNullOrWhiteSpace(m3_PARM))
				throw new ArgumentNullException("m3_PARM");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("TYPE", m3_TYPE.Trim())
				.WithQueryParameter("TYTR", m3_TYTR.ToString())
				.WithQueryParameter("PARM", m3_PARM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXHE))
				request.WithQueryParameter("TXHE", m3_TXHE.Trim());

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
		/// Name UpdCnfDlyDate
		/// Description Update Confirmed Delivery Date fields in CO line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_PLDT">Planning date (Required)</param>
		/// <param name="m3_PLHM">Planning time (Required)</param>
		/// <param name="m3_DSDT">Departure date (Required)</param>
		/// <param name="m3_DSHM">Departure time (Required)</param>
		/// <param name="m3_CODT">Confirmed delivery date (Required)</param>
		/// <param name="m3_COHM">Confirmed delivery time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCnfDlyDate(
			string m3_ORNO, 
			int m3_PONR, 
			DateTime m3_PLDT, 
			int m3_PLHM, 
			DateTime m3_DSDT, 
			int m3_DSHM, 
			DateTime m3_CODT, 
			int m3_COHM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCnfDlyDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("PLDT", m3_PLDT.ToM3String())
				.WithQueryParameter("PLHM", m3_PLHM.ToString())
				.WithQueryParameter("DSDT", m3_DSDT.ToM3String())
				.WithQueryParameter("DSHM", m3_DSHM.ToString())
				.WithQueryParameter("CODT", m3_CODT.ToM3String())
				.WithQueryParameter("COHM", m3_COHM.ToString());

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
		/// Name UpdConnCOCharge
		/// Description Update Connected CO Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CRID">Charge (Required)</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_CRAM">Charge amount</param>
		/// <param name="m3_CRFA">Calculation factor</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_CRD0">Description language 0</param>
		/// <param name="m3_CHST">Status - charge</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdConnCOCharge(
			string m3_ORNO, 
			string m3_CRID, 
			decimal? m3_DLIX = null, 
			decimal? m3_CRAM = null, 
			decimal? m3_CRFA = null, 
			int? m3_VTCD = null, 
			string m3_ACRF = null, 
			string m3_CRD0 = null, 
			string m3_CHST = null, 
			string m3_TAXC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdConnCOCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_CRID))
				throw new ArgumentNullException("m3_CRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("CRID", m3_CRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_CRAM.HasValue)
				request.WithQueryParameter("CRAM", m3_CRAM.Value.ToString());
			if (m3_CRFA.HasValue)
				request.WithQueryParameter("CRFA", m3_CRFA.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRD0))
				request.WithQueryParameter("CRD0", m3_CRD0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHST))
				request.WithQueryParameter("CHST", m3_CHST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());

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
		/// Name UpdDocument
		/// Description Update Connected Document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_NOEX">Number of copies</param>
		/// <param name="m3_DOCD">Print document</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDocument(
			string m3_ORNO = null, 
			string m3_DONR = null, 
			string m3_DOVA = null, 
			int? m3_NOEX = null, 
			int? m3_DOCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdDocument",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (m3_NOEX.HasValue)
				request.WithQueryParameter("NOEX", m3_NOEX.Value.ToString());
			if (m3_DOCD.HasValue)
				request.WithQueryParameter("DOCD", m3_DOCD.Value.ToString());

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
		/// Name UpdLineManRe
		/// Description Update manual rebate on an existing order line
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_CLAR">Supplier rebate reference number</param>
		/// <param name="m3_RASR">Agreement reference number</param>
		/// <param name="m3_SREA">Rebate amount</param>
		/// <param name="m3_RPUN">Rebate amount - unit of measure</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLineManRe(
			int m3_CONO, 
			string m3_ORNO, 
			int m3_PONR, 
			int m3_POSX, 
			string m3_SUNO = null, 
			string m3_CLAR = null, 
			string m3_RASR = null, 
			decimal? m3_SREA = null, 
			string m3_RPUN = null, 
			string m3_CUCD = null, 
			string m3_RESP = null, 
			string m3_RFID = null, 
			string m3_OREF = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdLineManRe",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CLAR))
				request.WithQueryParameter("CLAR", m3_CLAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASR))
				request.WithQueryParameter("RASR", m3_RASR.Trim());
			if (m3_SREA.HasValue)
				request.WithQueryParameter("SREA", m3_SREA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPUN))
				request.WithQueryParameter("RPUN", m3_RPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name UpdPriceInfo
		/// Description Updates price information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_DIP1">Discount 1</param>
		/// <param name="m3_DIP2">Discount 2</param>
		/// <param name="m3_DIP3">Discount 3</param>
		/// <param name="m3_DIP4">Discount 4</param>
		/// <param name="m3_DIP5">Discount 5</param>
		/// <param name="m3_DIP6">Discount 6</param>
		/// <param name="m3_DIC1">Status - discount</param>
		/// <param name="m3_DIC2">Status - discount</param>
		/// <param name="m3_DIC3">Status - discount</param>
		/// <param name="m3_DIC4">Status - discount</param>
		/// <param name="m3_DIC5">Status - discount</param>
		/// <param name="m3_DIC6">Status - discount</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_DIA2">Discount amount 2</param>
		/// <param name="m3_DIA3">Discount amount 3</param>
		/// <param name="m3_DIA4">Discount amount 4</param>
		/// <param name="m3_DIA5">Discount amount 5</param>
		/// <param name="m3_DIA6">Discount amount 6</param>
		/// <param name="m3_UCOS">Cost price</param>
		/// <param name="m3_NTCD">Net price used</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPriceInfo(
			string m3_ORNO = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			decimal? m3_SAPR = null, 
			int? m3_DIP1 = null, 
			int? m3_DIP2 = null, 
			int? m3_DIP3 = null, 
			int? m3_DIP4 = null, 
			int? m3_DIP5 = null, 
			int? m3_DIP6 = null, 
			int? m3_DIC1 = null, 
			int? m3_DIC2 = null, 
			int? m3_DIC3 = null, 
			int? m3_DIC4 = null, 
			int? m3_DIC5 = null, 
			int? m3_DIC6 = null, 
			decimal? m3_DIA1 = null, 
			decimal? m3_DIA2 = null, 
			decimal? m3_DIA3 = null, 
			decimal? m3_DIA4 = null, 
			decimal? m3_DIA5 = null, 
			decimal? m3_DIA6 = null, 
			decimal? m3_UCOS = null, 
			int? m3_NTCD = null, 
			int? m3_SACD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPriceInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_DIP1.HasValue)
				request.WithQueryParameter("DIP1", m3_DIP1.Value.ToString());
			if (m3_DIP2.HasValue)
				request.WithQueryParameter("DIP2", m3_DIP2.Value.ToString());
			if (m3_DIP3.HasValue)
				request.WithQueryParameter("DIP3", m3_DIP3.Value.ToString());
			if (m3_DIP4.HasValue)
				request.WithQueryParameter("DIP4", m3_DIP4.Value.ToString());
			if (m3_DIP5.HasValue)
				request.WithQueryParameter("DIP5", m3_DIP5.Value.ToString());
			if (m3_DIP6.HasValue)
				request.WithQueryParameter("DIP6", m3_DIP6.Value.ToString());
			if (m3_DIC1.HasValue)
				request.WithQueryParameter("DIC1", m3_DIC1.Value.ToString());
			if (m3_DIC2.HasValue)
				request.WithQueryParameter("DIC2", m3_DIC2.Value.ToString());
			if (m3_DIC3.HasValue)
				request.WithQueryParameter("DIC3", m3_DIC3.Value.ToString());
			if (m3_DIC4.HasValue)
				request.WithQueryParameter("DIC4", m3_DIC4.Value.ToString());
			if (m3_DIC5.HasValue)
				request.WithQueryParameter("DIC5", m3_DIC5.Value.ToString());
			if (m3_DIC6.HasValue)
				request.WithQueryParameter("DIC6", m3_DIC6.Value.ToString());
			if (m3_DIA1.HasValue)
				request.WithQueryParameter("DIA1", m3_DIA1.Value.ToString());
			if (m3_DIA2.HasValue)
				request.WithQueryParameter("DIA2", m3_DIA2.Value.ToString());
			if (m3_DIA3.HasValue)
				request.WithQueryParameter("DIA3", m3_DIA3.Value.ToString());
			if (m3_DIA4.HasValue)
				request.WithQueryParameter("DIA4", m3_DIA4.Value.ToString());
			if (m3_DIA5.HasValue)
				request.WithQueryParameter("DIA5", m3_DIA5.Value.ToString());
			if (m3_DIA6.HasValue)
				request.WithQueryParameter("DIA6", m3_DIA6.Value.ToString());
			if (m3_UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3_UCOS.Value.ToString());
			if (m3_NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3_NTCD.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());

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
