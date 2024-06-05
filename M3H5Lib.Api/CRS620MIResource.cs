/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS620MI;
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
	/// Name: CRS620MI
	/// Component Name: Supplier
	/// Description: Supplier interface
	/// Version Release: 5ea4
	///</summary>
	public partial class CRS620MIResource : M3BaseResourceEndpoint
	{
		public CRS620MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS620MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAddress
		/// Description Add address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_ADTE">Addresstype (Required)</param>
		/// <param name="m3_ADID">Addressnumber (Required)</param>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_PRIA">Printoutcode (Required)</param>
		/// <param name="m3_STDT">Startdate</param>
		/// <param name="m3_SUNM">Suppliername</param>
		/// <param name="m3_ADR1">Addressline1</param>
		/// <param name="m3_ADR2">Addressline2</param>
		/// <param name="m3_ADR3">Addressline3</param>
		/// <param name="m3_ADR4">Addressline4</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_PONO">Postalcode</param>
		/// <param name="m3_PNOD">Planningnode</param>
		/// <param name="m3_ADVI">Viaaddress</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_GEOX">Geographic cod X</param>
		/// <param name="m3_GEOY">Geographic code Y</param>
		/// <param name="m3_GEOZ">Geographic cod Z</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_SADR">Supplier´s address reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddress(
			string m3_SUNO, 
			int m3_ADTE, 
			string m3_ADID, 
			string m3_CSCD, 
			int m3_PRIA, 
			DateTime? m3_STDT = null, 
			string m3_SUNM = null, 
			string m3_ADR1 = null, 
			string m3_ADR2 = null, 
			string m3_ADR3 = null, 
			string m3_ADR4 = null, 
			string m3_TOWN = null, 
			string m3_ECAR = null, 
			string m3_PONO = null, 
			string m3_PNOD = null, 
			string m3_ADVI = null, 
			string m3_EDES = null, 
			decimal? m3_GEOX = null, 
			decimal? m3_GEOY = null, 
			decimal? m3_GEOZ = null, 
			string m3_FRCO = null, 
			int? m3_GEOC = null, 
			string m3_SADR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("ADTE", m3_ADTE.ToString())
				.WithQueryParameter("ADID", m3_ADID.Trim())
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("PRIA", m3_PRIA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SUNM))
				request.WithQueryParameter("SUNM", m3_SUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR1))
				request.WithQueryParameter("ADR1", m3_ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR2))
				request.WithQueryParameter("ADR2", m3_ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR3))
				request.WithQueryParameter("ADR3", m3_ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR4))
				request.WithQueryParameter("ADR4", m3_ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PNOD))
				request.WithQueryParameter("PNOD", m3_PNOD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADVI))
				request.WithQueryParameter("ADVI", m3_ADVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (m3_GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3_GEOX.Value.ToString());
			if (m3_GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3_GEOY.Value.ToString());
			if (m3_GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3_GEOZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SADR))
				request.WithQueryParameter("SADR", m3_SADR.Trim());

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
		/// Name AddSupplier
		/// Description Add supplier
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_SUNM">Suppliername (Required)</param>
		/// <param name="m3_SUTY">Suppliertype (Required)</param>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_ECAR">State (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_DTFM">Dateformat (Required)</param>
		/// <param name="m3_MEPF">Mediaprofile (Required)</param>
		/// <param name="m3_SUCL">Suppliergroup (Required)</param>
		/// <param name="m3_QUCL">Qualityclass (Required)</param>
		/// <param name="m3_ORTY">Ordertype (Required)</param>
		/// <param name="m3_TEDL">Deliveryterms (Required)</param>
		/// <param name="m3_MODL">Deliverymethod (Required)</param>
		/// <param name="m3_TEAF">Freightterms (Required)</param>
		/// <param name="m3_TEPA">Packagingterms (Required)</param>
		/// <param name="m3_DT4T">Datetype (Required)</param>
		/// <param name="m3_DTCD">Datecode (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CRTP">Exchangeratetype (Required)</param>
		/// <param name="m3_TEPY">Paymentterms (Required)</param>
		/// <param name="m3_PYME">Paymentmethod-accountspayable (Required)</param>
		/// <param name="m3_ATPR">Attributepricingrule (Required)</param>
		/// <param name="m3_ACRF">User-definedaccountingcontrolobject (Required)</param>
		/// <param name="m3_ALSU">Searchkey</param>
		/// <param name="m3_HAFE">Harbororairport</param>
		/// <param name="m3_VTCD">VATcode</param>
		/// <param name="m3_TXAP">Taxapplicable</param>
		/// <param name="m3_TAXC">Taxcodecustomer/address</param>
		/// <param name="m3_PHNO">Telephonenumber1</param>
		/// <param name="m3_PHN2">Telephonenumber2</param>
		/// <param name="m3_TFNO">Facsimiletransmissionnumber</param>
		/// <param name="m3_TLNO">Telexnumber</param>
		/// <param name="m3_CORG">Organizationnumber1</param>
		/// <param name="m3_COR2">Organizationnumber2</param>
		/// <param name="m3_VRNO">VATregistrationnumber</param>
		/// <param name="m3_SUCO">Suppliernumberwithingroup</param>
		/// <param name="m3_DESV">Alternatelangforoptiondescription</param>
		/// <param name="m3_FWSC">ForwardersSCACcode</param>
		/// <param name="m3_SUAL">Supplieralternateidentity</param>
		/// <param name="m3_EDIT">Dateediting</param>
		/// <param name="m3_SUCM">Suppliercomputercommunicationaddress</param>
		/// <param name="m3_PODA">Transmissionleadtime-supplier</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_RESP">Authorized</param>
		/// <param name="m3_AGNT">Agent</param>
		/// <param name="m3_ABSK">ABCclass-supplier</param>
		/// <param name="m3_ABSM">ABCmethod-supplier</param>
		/// <param name="m3_PWMT">PINcode</param>
		/// <param name="m3_DCSM">Discountcalculationmethod</param>
		/// <param name="m3_FUSC">Monitoringactivitylist</param>
		/// <param name="m3_SPFC">Monitoringclass</param>
		/// <param name="m3_COBI">Groupofcompanies</param>
		/// <param name="m3_SCNO">Suppliercustomernumber</param>
		/// <param name="m3_SUGR">Statisticalsupplier</param>
		/// <param name="m3_SHST">Shipmenttable</param>
		/// <param name="m3_POOT">Pointoftimetable</param>
		/// <param name="m3_OUCN">Ourcustomernumberatsupplier</param>
		/// <param name="m3_TINO">TaxIDforsupplier</param>
		/// <param name="m3_PRSU">Payee</param>
		/// <param name="m3_SERS">Servicecode</param>
		/// <param name="m3_SBPE">Self-billingpermitted</param>
		/// <param name="m3_PACD">Paymentpriority</param>
		/// <param name="m3_PTDY">Tolerance-payment</param>
		/// <param name="m3_SUST">Supplierstatistics</param>
		/// <param name="m3_DTDY">Tolerance-deliverydate</param>
		/// <param name="m3_TECD">Cashdiscountterm</param>
		/// <param name="m3_REGR">Invoiceaccountingtemplate</param>
		/// <param name="m3_SUSY">Numberofyearsofstatistics</param>
		/// <param name="m3_SHAC">Shipmentadvice</param>
		/// <param name="m3_AVCD">Activitycode</param>
		/// <param name="m3_TAME">Taxwithholdingmethod</param>
		/// <param name="m3_TDCD">Tradecode</param>
		/// <param name="m3_IAPT">Automaticinvoiceapprovalcode</param>
		/// <param name="m3_IAPC">Invoiceapprovalcondition1</param>
		/// <param name="m3_IAPE">Invoiceapprovalcondition2</param>
		/// <param name="m3_IAPF">Invoiceapprovalcondition3</param>
		/// <param name="m3_CFI1">User-definedfield1-supplier</param>
		/// <param name="m3_CFI2">User-definedfield2-supplier</param>
		/// <param name="m3_CFI3">User-definedfield3-supplier</param>
		/// <param name="m3_CFI4">User-definedfield4-supplier</param>
		/// <param name="m3_CFI5">User-definedfield5-supplier</param>
		/// <param name="m3_CFI6">User-definedfield1-purchase/financial</param>
		/// <param name="m3_CFI7">User-definedfield2-purchase/financial</param>
		/// <param name="m3_CFI8">User-definedfield3-purchase/financial</param>
		/// <param name="m3_CFI9">User-definedfield4-purchase/financial</param>
		/// <param name="m3_CF10">User-definedfield5-purchase/financial</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PPIN">Print packing instruction</param>
		/// <param name="m3_CGRP">Consolidation group</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_PPLV">Level of purchase planning</param>
		/// <param name="m3_CINP">Claim invoice permitted</param>
		/// <param name="m3_SCIS">Rebate claim invoice setting ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSupplier(
			string m3_SUNO, 
			string m3_SUNM, 
			int m3_SUTY, 
			string m3_CSCD, 
			string m3_ECAR, 
			string m3_LNCD, 
			string m3_DTFM, 
			string m3_MEPF, 
			string m3_SUCL, 
			string m3_QUCL, 
			string m3_ORTY, 
			string m3_TEDL, 
			string m3_MODL, 
			string m3_TEAF, 
			string m3_TEPA, 
			int m3_DT4T, 
			int m3_DTCD, 
			string m3_CUCD, 
			int m3_CRTP, 
			string m3_TEPY, 
			string m3_PYME, 
			string m3_ATPR, 
			string m3_ACRF, 
			string m3_ALSU = null, 
			string m3_HAFE = null, 
			int? m3_VTCD = null, 
			int? m3_TXAP = null, 
			string m3_TAXC = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_TFNO = null, 
			string m3_TLNO = null, 
			string m3_CORG = null, 
			string m3_COR2 = null, 
			string m3_VRNO = null, 
			string m3_SUCO = null, 
			string m3_DESV = null, 
			string m3_FWSC = null, 
			string m3_SUAL = null, 
			string m3_EDIT = null, 
			string m3_SUCM = null, 
			int? m3_PODA = null, 
			string m3_BUYE = null, 
			string m3_RESP = null, 
			string m3_AGNT = null, 
			string m3_ABSK = null, 
			int? m3_ABSM = null, 
			string m3_PWMT = null, 
			int? m3_DCSM = null, 
			string m3_FUSC = null, 
			string m3_SPFC = null, 
			string m3_COBI = null, 
			string m3_SCNO = null, 
			string m3_SUGR = null, 
			int? m3_SHST = null, 
			string m3_POOT = null, 
			string m3_OUCN = null, 
			string m3_TINO = null, 
			string m3_PRSU = null, 
			int? m3_SERS = null, 
			int? m3_SBPE = null, 
			string m3_PACD = null, 
			int? m3_PTDY = null, 
			int? m3_SUST = null, 
			int? m3_DTDY = null, 
			string m3_TECD = null, 
			int? m3_REGR = null, 
			int? m3_SUSY = null, 
			int? m3_SHAC = null, 
			string m3_AVCD = null, 
			int? m3_TAME = null, 
			string m3_TDCD = null, 
			int? m3_IAPT = null, 
			int? m3_IAPC = null, 
			int? m3_IAPE = null, 
			int? m3_IAPF = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_CFI6 = null, 
			decimal? m3_CFI7 = null, 
			string m3_CFI8 = null, 
			string m3_CFI9 = null, 
			string m3_CF10 = null, 
			string m3_STAT = null, 
			int? m3_PPIN = null, 
			string m3_CGRP = null, 
			string m3_RASN = null, 
			int? m3_GEOC = null, 
			int? m3_PPLV = null, 
			int? m3_CINP = null, 
			string m3_SCIS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUNM))
				throw new ArgumentNullException("m3_SUNM");
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_ECAR))
				throw new ArgumentNullException("m3_ECAR");
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");
			if (string.IsNullOrWhiteSpace(m3_DTFM))
				throw new ArgumentNullException("m3_DTFM");
			if (string.IsNullOrWhiteSpace(m3_MEPF))
				throw new ArgumentNullException("m3_MEPF");
			if (string.IsNullOrWhiteSpace(m3_SUCL))
				throw new ArgumentNullException("m3_SUCL");
			if (string.IsNullOrWhiteSpace(m3_QUCL))
				throw new ArgumentNullException("m3_QUCL");
			if (string.IsNullOrWhiteSpace(m3_ORTY))
				throw new ArgumentNullException("m3_ORTY");
			if (string.IsNullOrWhiteSpace(m3_TEDL))
				throw new ArgumentNullException("m3_TEDL");
			if (string.IsNullOrWhiteSpace(m3_MODL))
				throw new ArgumentNullException("m3_MODL");
			if (string.IsNullOrWhiteSpace(m3_TEAF))
				throw new ArgumentNullException("m3_TEAF");
			if (string.IsNullOrWhiteSpace(m3_TEPA))
				throw new ArgumentNullException("m3_TEPA");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_TEPY))
				throw new ArgumentNullException("m3_TEPY");
			if (string.IsNullOrWhiteSpace(m3_PYME))
				throw new ArgumentNullException("m3_PYME");
			if (string.IsNullOrWhiteSpace(m3_ATPR))
				throw new ArgumentNullException("m3_ATPR");
			if (string.IsNullOrWhiteSpace(m3_ACRF))
				throw new ArgumentNullException("m3_ACRF");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUNM", m3_SUNM.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("ECAR", m3_ECAR.Trim())
				.WithQueryParameter("LNCD", m3_LNCD.Trim())
				.WithQueryParameter("DTFM", m3_DTFM.Trim())
				.WithQueryParameter("MEPF", m3_MEPF.Trim())
				.WithQueryParameter("SUCL", m3_SUCL.Trim())
				.WithQueryParameter("QUCL", m3_QUCL.Trim())
				.WithQueryParameter("ORTY", m3_ORTY.Trim())
				.WithQueryParameter("TEDL", m3_TEDL.Trim())
				.WithQueryParameter("MODL", m3_MODL.Trim())
				.WithQueryParameter("TEAF", m3_TEAF.Trim())
				.WithQueryParameter("TEPA", m3_TEPA.Trim())
				.WithQueryParameter("DT4T", m3_DT4T.ToString())
				.WithQueryParameter("DTCD", m3_DTCD.ToString())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("CRTP", m3_CRTP.ToString())
				.WithQueryParameter("TEPY", m3_TEPY.Trim())
				.WithQueryParameter("PYME", m3_PYME.Trim())
				.WithQueryParameter("ATPR", m3_ATPR.Trim())
				.WithQueryParameter("ACRF", m3_ACRF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ALSU))
				request.WithQueryParameter("ALSU", m3_ALSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (m3_TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3_TXAP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLNO))
				request.WithQueryParameter("TLNO", m3_TLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORG))
				request.WithQueryParameter("CORG", m3_CORG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COR2))
				request.WithQueryParameter("COR2", m3_COR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCO))
				request.WithQueryParameter("SUCO", m3_SUCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DESV))
				request.WithQueryParameter("DESV", m3_DESV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWSC))
				request.WithQueryParameter("FWSC", m3_FWSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUAL))
				request.WithQueryParameter("SUAL", m3_SUAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDIT))
				request.WithQueryParameter("EDIT", m3_EDIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCM))
				request.WithQueryParameter("SUCM", m3_SUCM.Trim());
			if (m3_PODA.HasValue)
				request.WithQueryParameter("PODA", m3_PODA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNT))
				request.WithQueryParameter("AGNT", m3_AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABSK))
				request.WithQueryParameter("ABSK", m3_ABSK.Trim());
			if (m3_ABSM.HasValue)
				request.WithQueryParameter("ABSM", m3_ABSM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PWMT))
				request.WithQueryParameter("PWMT", m3_PWMT.Trim());
			if (m3_DCSM.HasValue)
				request.WithQueryParameter("DCSM", m3_DCSM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FUSC))
				request.WithQueryParameter("FUSC", m3_FUSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPFC))
				request.WithQueryParameter("SPFC", m3_SPFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COBI))
				request.WithQueryParameter("COBI", m3_COBI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCNO))
				request.WithQueryParameter("SCNO", m3_SCNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUGR))
				request.WithQueryParameter("SUGR", m3_SUGR.Trim());
			if (m3_SHST.HasValue)
				request.WithQueryParameter("SHST", m3_SHST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POOT))
				request.WithQueryParameter("POOT", m3_POOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OUCN))
				request.WithQueryParameter("OUCN", m3_OUCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TINO))
				request.WithQueryParameter("TINO", m3_TINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRSU))
				request.WithQueryParameter("PRSU", m3_PRSU.Trim());
			if (m3_SERS.HasValue)
				request.WithQueryParameter("SERS", m3_SERS.Value.ToString());
			if (m3_SBPE.HasValue)
				request.WithQueryParameter("SBPE", m3_SBPE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACD))
				request.WithQueryParameter("PACD", m3_PACD.Trim());
			if (m3_PTDY.HasValue)
				request.WithQueryParameter("PTDY", m3_PTDY.Value.ToString());
			if (m3_SUST.HasValue)
				request.WithQueryParameter("SUST", m3_SUST.Value.ToString());
			if (m3_DTDY.HasValue)
				request.WithQueryParameter("DTDY", m3_DTDY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECD))
				request.WithQueryParameter("TECD", m3_TECD.Trim());
			if (m3_REGR.HasValue)
				request.WithQueryParameter("REGR", m3_REGR.Value.ToString());
			if (m3_SUSY.HasValue)
				request.WithQueryParameter("SUSY", m3_SUSY.Value.ToString());
			if (m3_SHAC.HasValue)
				request.WithQueryParameter("SHAC", m3_SHAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AVCD))
				request.WithQueryParameter("AVCD", m3_AVCD.Trim());
			if (m3_TAME.HasValue)
				request.WithQueryParameter("TAME", m3_TAME.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TDCD))
				request.WithQueryParameter("TDCD", m3_TDCD.Trim());
			if (m3_IAPT.HasValue)
				request.WithQueryParameter("IAPT", m3_IAPT.Value.ToString());
			if (m3_IAPC.HasValue)
				request.WithQueryParameter("IAPC", m3_IAPC.Value.ToString());
			if (m3_IAPE.HasValue)
				request.WithQueryParameter("IAPE", m3_IAPE.Value.ToString());
			if (m3_IAPF.HasValue)
				request.WithQueryParameter("IAPF", m3_IAPF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI1))
				request.WithQueryParameter("CFI1", m3_CFI1.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI4))
				request.WithQueryParameter("CFI4", m3_CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI5))
				request.WithQueryParameter("CFI5", m3_CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI6))
				request.WithQueryParameter("CFI6", m3_CFI6.Trim());
			if (m3_CFI7.HasValue)
				request.WithQueryParameter("CFI7", m3_CFI7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI8))
				request.WithQueryParameter("CFI8", m3_CFI8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI9))
				request.WithQueryParameter("CFI9", m3_CFI9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CF10))
				request.WithQueryParameter("CF10", m3_CF10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_PPIN.HasValue)
				request.WithQueryParameter("PPIN", m3_PPIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CGRP))
				request.WithQueryParameter("CGRP", m3_CGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (m3_PPLV.HasValue)
				request.WithQueryParameter("PPLV", m3_PPLV.Value.ToString());
			if (m3_CINP.HasValue)
				request.WithQueryParameter("CINP", m3_CINP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCIS))
				request.WithQueryParameter("SCIS", m3_SCIS.Trim());

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
		/// Name AddSupplierRef
		/// Description Adds reference to Supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_RFTY">Referencetype (Required)</param>
		/// <param name="m3_RFID">Reference (Required)</param>
		/// <param name="m3_YRE1">Yourreference (Required)</param>
		/// <param name="m3_PHNO">Telephonenumber1</param>
		/// <param name="m3_TFNO">Facsimiletransmissionnumber</param>
		/// <param name="m3_EMAL">Electronicmailaddress</param>
		/// <param name="m3_SUCM">Suppliercomputercommunicationaddress</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSupplierRef(
			string m3_SUNO, 
			string m3_RFTY, 
			string m3_RFID, 
			string m3_YRE1, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_EMAL = null, 
			string m3_SUCM = null, 
			string m3_REMK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSupplierRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_RFTY))
				throw new ArgumentNullException("m3_RFTY");
			if (string.IsNullOrWhiteSpace(m3_RFID))
				throw new ArgumentNullException("m3_RFID");
			if (string.IsNullOrWhiteSpace(m3_YRE1))
				throw new ArgumentNullException("m3_YRE1");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("RFTY", m3_RFTY.Trim())
				.WithQueryParameter("RFID", m3_RFID.Trim())
				.WithQueryParameter("YRE1", m3_YRE1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCM))
				request.WithQueryParameter("SUCM", m3_SUCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());

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
		/// Name CopyTemplate
		/// Description CopyTemplate
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_STEM">Supplier template (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_SUTY">Supplier type</param>
		/// <param name="m3_OPYC">Copy capability</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CopyTemplateResponse></returns>
		/// <exception cref="M3Exception<CopyTemplateResponse>"></exception>
		public async Task<M3Response<CopyTemplateResponse>> CopyTemplate(
			string m3_STEM, 
			string m3_SUNO, 
			int? m3_SUTY = null, 
			int? m3_OPYC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CopyTemplate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STEM))
				throw new ArgumentNullException("m3_STEM");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("STEM", m3_STEM.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3_SUTY.Value.ToString());
			if (m3_OPYC.HasValue)
				request.WithQueryParameter("OPYC", m3_OPYC.Value.ToString());

			// Execute the request
			var result = await Execute<CopyTemplateResponse>(
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
		/// Name DelAddress
		/// Description Delete Address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_ADTE">Address type (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAddress(
			string m3_SUNO, 
			int m3_ADTE, 
			DateTime m3_STDT, 
			string m3_ADID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("ADTE", m3_ADTE.ToString())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("ADID", m3_ADID.Trim());

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
		/// Name DelSupplierRef
		/// Description Delete Supplier Reference
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_RFTY">Reference type (Required)</param>
		/// <param name="m3_RFID">Reference (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSupplierRef(
			string m3_SUNO, 
			string m3_RFTY, 
			string m3_RFID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelSupplierRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_RFTY))
				throw new ArgumentNullException("m3_RFTY");
			if (string.IsNullOrWhiteSpace(m3_RFID))
				throw new ArgumentNullException("m3_RFID");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("RFTY", m3_RFTY.Trim())
				.WithQueryParameter("RFID", m3_RFID.Trim());

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
		/// Name GetAddress
		/// Description Get supplier address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_ADTE">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			string m3_SUNO, 
			int? m3_ADTE = null, 
			string m3_ADID = null, 
			DateTime? m3_STDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ADTE.HasValue)
				request.WithQueryParameter("ADTE", m3_ADTE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());

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
		/// Name GetBasicData
		/// Description Retrive supplier basic data
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3_SUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name GetSupplierRef
		/// Description Gets references linked to supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_RFTY">Referencetype (Required)</param>
		/// <param name="m3_RFID">Reference (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSupplierRefResponse></returns>
		/// <exception cref="M3Exception<GetSupplierRefResponse>"></exception>
		public async Task<M3Response<GetSupplierRefResponse>> GetSupplierRef(
			string m3_SUNO, 
			string m3_RFTY, 
			string m3_RFID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSupplierRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_RFTY))
				throw new ArgumentNullException("m3_RFTY");
			if (string.IsNullOrWhiteSpace(m3_RFID))
				throw new ArgumentNullException("m3_RFID");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("RFTY", m3_RFTY.Trim())
				.WithQueryParameter("RFID", m3_RFID.Trim());

			// Execute the request
			var result = await Execute<GetSupplierRefResponse>(
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
		/// Name LstAddresses
		/// Description List addresses linked to supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAddressesResponse></returns>
		/// <exception cref="M3Exception<LstAddressesResponse>"></exception>
		public async Task<M3Response<LstAddressesResponse>> LstAddresses(
			string m3_SUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAddresses",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Execute the request
			var result = await Execute<LstAddressesResponse>(
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
		/// Name LstByName
		/// Description List supplier in Supplier name
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SUNM">Suppliername (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByNameResponse></returns>
		/// <exception cref="M3Exception<LstByNameResponse>"></exception>
		public async Task<M3Response<LstByNameResponse>> LstByName(
			string m3_SUNM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByName",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNM))
				throw new ArgumentNullException("m3_SUNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNM", m3_SUNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstByNameResponse>(
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
		/// Name LstByNumber
		/// Description List Supplier in supplier number order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByNumberResponse></returns>
		/// <exception cref="M3Exception<LstByNumberResponse>"></exception>
		public async Task<M3Response<LstByNumberResponse>> LstByNumber(
			string m3_SUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByNumber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstByNumberResponse>(
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
		/// Name LstSupplierRef
		/// Description List references linked to supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSupplierRefResponse></returns>
		/// <exception cref="M3Exception<LstSupplierRefResponse>"></exception>
		public async Task<M3Response<LstSupplierRefResponse>> LstSupplierRef(
			string m3_SUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSupplierRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Execute the request
			var result = await Execute<LstSupplierRefResponse>(
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
		/// Name LstSuppliers
		/// Description Retrieves Supplier Information
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_CONO">Companynumber</param>
		/// <param name="m3_FRSU">FromSupplier</param>
		/// <param name="m3_TOSU">ToSupplier</param>
		/// <param name="m3_LMTS">Lastimport´stimestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSuppliersResponse></returns>
		/// <exception cref="M3Exception<LstSuppliersResponse>"></exception>
		public async Task<M3Response<LstSuppliersResponse>> LstSuppliers(
			int? m3_CONO = null, 
			string m3_FRSU = null, 
			string m3_TOSU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSuppliers",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRSU))
				request.WithQueryParameter("FRSU", m3_FRSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOSU))
				request.WithQueryParameter("TOSU", m3_TOSU.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstSuppliersResponse>(
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
		/// Name SearchSupplier
		/// Description SearchSupplier
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchSupplierResponse></returns>
		/// <exception cref="M3Exception<SearchSupplierResponse>"></exception>
		public async Task<M3Response<SearchSupplierResponse>> SearchSupplier(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchSupplierResponse>(
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
		/// Name UpdAddress
		/// Description Updates address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_ADTE">Addresstype (Required)</param>
		/// <param name="m3_ADID">Addressnumber (Required)</param>
		/// <param name="m3_STDT">Startdate (Required)</param>
		/// <param name="m3_SUNM">Suppliername</param>
		/// <param name="m3_ADR1">Addressline1</param>
		/// <param name="m3_ADR2">Addressline2</param>
		/// <param name="m3_ADR3">Addressline3</param>
		/// <param name="m3_ADR4">Addressline4</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_PONO">Postalcode</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PNOD">Planningnode</param>
		/// <param name="m3_PRIA">Printoutcode</param>
		/// <param name="m3_ADVI">Viaaddress</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_GEOX">Geographic cod X</param>
		/// <param name="m3_GEOY">Geographic code Y</param>
		/// <param name="m3_GEOZ">Geographic cod Z</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_SADR">Supplier´s address reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAddress(
			string m3_SUNO, 
			int m3_ADTE, 
			string m3_ADID, 
			DateTime m3_STDT, 
			string m3_SUNM = null, 
			string m3_ADR1 = null, 
			string m3_ADR2 = null, 
			string m3_ADR3 = null, 
			string m3_ADR4 = null, 
			string m3_TOWN = null, 
			string m3_ECAR = null, 
			string m3_PONO = null, 
			string m3_CSCD = null, 
			string m3_PNOD = null, 
			int? m3_PRIA = null, 
			string m3_ADVI = null, 
			string m3_EDES = null, 
			decimal? m3_GEOX = null, 
			decimal? m3_GEOY = null, 
			decimal? m3_GEOZ = null, 
			string m3_FRCO = null, 
			int? m3_GEOC = null, 
			string m3_SADR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("ADTE", m3_ADTE.ToString())
				.WithQueryParameter("ADID", m3_ADID.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SUNM))
				request.WithQueryParameter("SUNM", m3_SUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR1))
				request.WithQueryParameter("ADR1", m3_ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR2))
				request.WithQueryParameter("ADR2", m3_ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR3))
				request.WithQueryParameter("ADR3", m3_ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR4))
				request.WithQueryParameter("ADR4", m3_ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PNOD))
				request.WithQueryParameter("PNOD", m3_PNOD.Trim());
			if (m3_PRIA.HasValue)
				request.WithQueryParameter("PRIA", m3_PRIA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADVI))
				request.WithQueryParameter("ADVI", m3_ADVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (m3_GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3_GEOX.Value.ToString());
			if (m3_GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3_GEOY.Value.ToString());
			if (m3_GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3_GEOZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SADR))
				request.WithQueryParameter("SADR", m3_SADR.Trim());

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
		/// Name UpdSupplier
		/// Description Updates Supplier
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_SUNM">Suppliername</param>
		/// <param name="m3_ALSU">Searchkey</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_DTFM">Dateformat</param>
		/// <param name="m3_MEPF">Mediaprofile</param>
		/// <param name="m3_HAFE">Harbororairport</param>
		/// <param name="m3_SUCL">Suppliergroup</param>
		/// <param name="m3_QUCL">Qualityclass</param>
		/// <param name="m3_ORTY">Ordertype</param>
		/// <param name="m3_TEDL">Deliveryterms</param>
		/// <param name="m3_MODL">Deliverymethod</param>
		/// <param name="m3_TEAF">Freightterms</param>
		/// <param name="m3_TEPA">Packagingterms</param>
		/// <param name="m3_DT4T">Datetype</param>
		/// <param name="m3_DTCD">Datecode</param>
		/// <param name="m3_VTCD">VATcode</param>
		/// <param name="m3_TXAP">Taxapplicable</param>
		/// <param name="m3_TAXC">Taxcodecustomer/address</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CRTP">Exchangeratetype</param>
		/// <param name="m3_TEPY">Paymentterms</param>
		/// <param name="m3_PYME">Paymentmethod-accountspayable</param>
		/// <param name="m3_ATPR">Attributepricingrule</param>
		/// <param name="m3_ACRF">User-definedaccountingcontrolobject</param>
		/// <param name="m3_PHNO">Telephonenumber1</param>
		/// <param name="m3_PHN2">Telephonenumber2</param>
		/// <param name="m3_TFNO">Facsimiletransmissionnumber</param>
		/// <param name="m3_TLNO">Telexnumber</param>
		/// <param name="m3_CORG">Organizationnumber1</param>
		/// <param name="m3_COR2">Organizationnumber2</param>
		/// <param name="m3_VRNO">VATregistrationnumber</param>
		/// <param name="m3_SUCO">Suppliernumberwithingroup</param>
		/// <param name="m3_DESV">Alternatelangforoptiondescription</param>
		/// <param name="m3_FWSC">ForwardersSCACcode</param>
		/// <param name="m3_SUAL">Supplieralternateidentity</param>
		/// <param name="m3_EDIT">Dateediting</param>
		/// <param name="m3_SUCM">Suppliercomputercommunicationaddress</param>
		/// <param name="m3_PODA">Transmissionleadtime-supplier</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_RESP">Authorized</param>
		/// <param name="m3_AGNT">Agent</param>
		/// <param name="m3_ABSK">ABCclass-supplier</param>
		/// <param name="m3_ABSM">ABCmethod-supplier</param>
		/// <param name="m3_PWMT">PINcode</param>
		/// <param name="m3_DCSM">Discountcalculationmethod</param>
		/// <param name="m3_FUSC">Monitoringactivitylist</param>
		/// <param name="m3_SPFC">Monitoringclass</param>
		/// <param name="m3_COBI">Groupofcompanies</param>
		/// <param name="m3_SCNO">Suppliercustomernumber</param>
		/// <param name="m3_SUGR">Statisticalsupplier</param>
		/// <param name="m3_SHST">Shipmenttable</param>
		/// <param name="m3_POOT">Pointoftimetable</param>
		/// <param name="m3_OUCN">Ourcustomernumberatsupplier</param>
		/// <param name="m3_TINO">TaxIDforsupplier</param>
		/// <param name="m3_PRSU">Payee</param>
		/// <param name="m3_SERS">Servicecode</param>
		/// <param name="m3_SBPE">Self-billingpermitted</param>
		/// <param name="m3_PACD">Paymentpriority</param>
		/// <param name="m3_PTDY">Tolerance-payment</param>
		/// <param name="m3_SUST">Supplierstatistics</param>
		/// <param name="m3_DTDY">Tolerance-deliverydate</param>
		/// <param name="m3_TECD">Cashdiscountterm</param>
		/// <param name="m3_REGR">Invoiceaccountingtemplate</param>
		/// <param name="m3_SUSY">Numberofyearsofstatistics</param>
		/// <param name="m3_SHAC">Shipmentadvice</param>
		/// <param name="m3_AVCD">Activitycode</param>
		/// <param name="m3_TAME">Taxwithholdingmethod</param>
		/// <param name="m3_TDCD">Tradecode</param>
		/// <param name="m3_IAPT">Automaticinvoiceapprovalcode</param>
		/// <param name="m3_IAPC">Invoiceapprovalcondition1</param>
		/// <param name="m3_IAPE">Invoiceapprovalcondition2</param>
		/// <param name="m3_IAPF">Invoiceapprovalcondition3</param>
		/// <param name="m3_CFI1">User-definedfield1-supplier</param>
		/// <param name="m3_CFI2">User-definedfield2-supplier</param>
		/// <param name="m3_CFI3">User-definedfield3-supplier</param>
		/// <param name="m3_CFI4">User-definedfield4-supplier</param>
		/// <param name="m3_CFI5">User-definedfield5-supplier</param>
		/// <param name="m3_CFI6">User-definedfield1-purchase/financial</param>
		/// <param name="m3_CFI7">User-definedfield2-purchase/financial</param>
		/// <param name="m3_CFI8">User-definedfield3-purchase/financial</param>
		/// <param name="m3_CFI9">User-definedfield4-purchase/financial</param>
		/// <param name="m3_CF10">User-definedfield5-purchase/financial</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PPIN">Print packing instruction</param>
		/// <param name="m3_CGRP">Consolidation group</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_PPLV">Level of purchase planning</param>
		/// <param name="m3_CINP">Claim invoice permitted</param>
		/// <param name="m3_SCIS">Rebate claim invoice setting ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSupplier(
			string m3_SUNO, 
			string m3_SUNM = null, 
			string m3_ALSU = null, 
			string m3_CSCD = null, 
			string m3_ECAR = null, 
			string m3_LNCD = null, 
			string m3_DTFM = null, 
			string m3_MEPF = null, 
			string m3_HAFE = null, 
			string m3_SUCL = null, 
			string m3_QUCL = null, 
			string m3_ORTY = null, 
			string m3_TEDL = null, 
			string m3_MODL = null, 
			string m3_TEAF = null, 
			string m3_TEPA = null, 
			int? m3_DT4T = null, 
			int? m3_DTCD = null, 
			int? m3_VTCD = null, 
			int? m3_TXAP = null, 
			string m3_TAXC = null, 
			string m3_CUCD = null, 
			int? m3_CRTP = null, 
			string m3_TEPY = null, 
			string m3_PYME = null, 
			string m3_ATPR = null, 
			string m3_ACRF = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_TFNO = null, 
			string m3_TLNO = null, 
			string m3_CORG = null, 
			string m3_COR2 = null, 
			string m3_VRNO = null, 
			string m3_SUCO = null, 
			string m3_DESV = null, 
			string m3_FWSC = null, 
			string m3_SUAL = null, 
			string m3_EDIT = null, 
			string m3_SUCM = null, 
			int? m3_PODA = null, 
			string m3_BUYE = null, 
			string m3_RESP = null, 
			string m3_AGNT = null, 
			string m3_ABSK = null, 
			int? m3_ABSM = null, 
			string m3_PWMT = null, 
			int? m3_DCSM = null, 
			string m3_FUSC = null, 
			string m3_SPFC = null, 
			string m3_COBI = null, 
			string m3_SCNO = null, 
			string m3_SUGR = null, 
			int? m3_SHST = null, 
			string m3_POOT = null, 
			string m3_OUCN = null, 
			string m3_TINO = null, 
			string m3_PRSU = null, 
			int? m3_SERS = null, 
			int? m3_SBPE = null, 
			string m3_PACD = null, 
			int? m3_PTDY = null, 
			int? m3_SUST = null, 
			int? m3_DTDY = null, 
			string m3_TECD = null, 
			int? m3_REGR = null, 
			int? m3_SUSY = null, 
			int? m3_SHAC = null, 
			string m3_AVCD = null, 
			int? m3_TAME = null, 
			string m3_TDCD = null, 
			int? m3_IAPT = null, 
			int? m3_IAPC = null, 
			int? m3_IAPE = null, 
			int? m3_IAPF = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_CFI6 = null, 
			decimal? m3_CFI7 = null, 
			string m3_CFI8 = null, 
			string m3_CFI9 = null, 
			string m3_CF10 = null, 
			string m3_STAT = null, 
			int? m3_PPIN = null, 
			string m3_CGRP = null, 
			string m3_RASN = null, 
			int? m3_GEOC = null, 
			int? m3_PPLV = null, 
			int? m3_CINP = null, 
			string m3_SCIS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SUNM))
				request.WithQueryParameter("SUNM", m3_SUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALSU))
				request.WithQueryParameter("ALSU", m3_ALSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DTFM))
				request.WithQueryParameter("DTFM", m3_DTFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCL))
				request.WithQueryParameter("SUCL", m3_SUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QUCL))
				request.WithQueryParameter("QUCL", m3_QUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEAF))
				request.WithQueryParameter("TEAF", m3_TEAF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (m3_DT4T.HasValue)
				request.WithQueryParameter("DT4T", m3_DT4T.Value.ToString());
			if (m3_DTCD.HasValue)
				request.WithQueryParameter("DTCD", m3_DTCD.Value.ToString());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (m3_TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3_TXAP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYME))
				request.WithQueryParameter("PYME", m3_PYME.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATPR))
				request.WithQueryParameter("ATPR", m3_ATPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TLNO))
				request.WithQueryParameter("TLNO", m3_TLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORG))
				request.WithQueryParameter("CORG", m3_CORG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COR2))
				request.WithQueryParameter("COR2", m3_COR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCO))
				request.WithQueryParameter("SUCO", m3_SUCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DESV))
				request.WithQueryParameter("DESV", m3_DESV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWSC))
				request.WithQueryParameter("FWSC", m3_FWSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUAL))
				request.WithQueryParameter("SUAL", m3_SUAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDIT))
				request.WithQueryParameter("EDIT", m3_EDIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCM))
				request.WithQueryParameter("SUCM", m3_SUCM.Trim());
			if (m3_PODA.HasValue)
				request.WithQueryParameter("PODA", m3_PODA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNT))
				request.WithQueryParameter("AGNT", m3_AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABSK))
				request.WithQueryParameter("ABSK", m3_ABSK.Trim());
			if (m3_ABSM.HasValue)
				request.WithQueryParameter("ABSM", m3_ABSM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PWMT))
				request.WithQueryParameter("PWMT", m3_PWMT.Trim());
			if (m3_DCSM.HasValue)
				request.WithQueryParameter("DCSM", m3_DCSM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FUSC))
				request.WithQueryParameter("FUSC", m3_FUSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPFC))
				request.WithQueryParameter("SPFC", m3_SPFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COBI))
				request.WithQueryParameter("COBI", m3_COBI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCNO))
				request.WithQueryParameter("SCNO", m3_SCNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUGR))
				request.WithQueryParameter("SUGR", m3_SUGR.Trim());
			if (m3_SHST.HasValue)
				request.WithQueryParameter("SHST", m3_SHST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POOT))
				request.WithQueryParameter("POOT", m3_POOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OUCN))
				request.WithQueryParameter("OUCN", m3_OUCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TINO))
				request.WithQueryParameter("TINO", m3_TINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRSU))
				request.WithQueryParameter("PRSU", m3_PRSU.Trim());
			if (m3_SERS.HasValue)
				request.WithQueryParameter("SERS", m3_SERS.Value.ToString());
			if (m3_SBPE.HasValue)
				request.WithQueryParameter("SBPE", m3_SBPE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACD))
				request.WithQueryParameter("PACD", m3_PACD.Trim());
			if (m3_PTDY.HasValue)
				request.WithQueryParameter("PTDY", m3_PTDY.Value.ToString());
			if (m3_SUST.HasValue)
				request.WithQueryParameter("SUST", m3_SUST.Value.ToString());
			if (m3_DTDY.HasValue)
				request.WithQueryParameter("DTDY", m3_DTDY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECD))
				request.WithQueryParameter("TECD", m3_TECD.Trim());
			if (m3_REGR.HasValue)
				request.WithQueryParameter("REGR", m3_REGR.Value.ToString());
			if (m3_SUSY.HasValue)
				request.WithQueryParameter("SUSY", m3_SUSY.Value.ToString());
			if (m3_SHAC.HasValue)
				request.WithQueryParameter("SHAC", m3_SHAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AVCD))
				request.WithQueryParameter("AVCD", m3_AVCD.Trim());
			if (m3_TAME.HasValue)
				request.WithQueryParameter("TAME", m3_TAME.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TDCD))
				request.WithQueryParameter("TDCD", m3_TDCD.Trim());
			if (m3_IAPT.HasValue)
				request.WithQueryParameter("IAPT", m3_IAPT.Value.ToString());
			if (m3_IAPC.HasValue)
				request.WithQueryParameter("IAPC", m3_IAPC.Value.ToString());
			if (m3_IAPE.HasValue)
				request.WithQueryParameter("IAPE", m3_IAPE.Value.ToString());
			if (m3_IAPF.HasValue)
				request.WithQueryParameter("IAPF", m3_IAPF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI1))
				request.WithQueryParameter("CFI1", m3_CFI1.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI4))
				request.WithQueryParameter("CFI4", m3_CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI5))
				request.WithQueryParameter("CFI5", m3_CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI6))
				request.WithQueryParameter("CFI6", m3_CFI6.Trim());
			if (m3_CFI7.HasValue)
				request.WithQueryParameter("CFI7", m3_CFI7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI8))
				request.WithQueryParameter("CFI8", m3_CFI8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI9))
				request.WithQueryParameter("CFI9", m3_CFI9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CF10))
				request.WithQueryParameter("CF10", m3_CF10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_PPIN.HasValue)
				request.WithQueryParameter("PPIN", m3_PPIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CGRP))
				request.WithQueryParameter("CGRP", m3_CGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (m3_PPLV.HasValue)
				request.WithQueryParameter("PPLV", m3_PPLV.Value.ToString());
			if (m3_CINP.HasValue)
				request.WithQueryParameter("CINP", m3_CINP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCIS))
				request.WithQueryParameter("SCIS", m3_SCIS.Trim());

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
		/// Name UpdSupplierRef
		/// Description Updates reference of Supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_RFTY">Referencetype (Required)</param>
		/// <param name="m3_RFID">Reference (Required)</param>
		/// <param name="m3_YRE1">Yourreference</param>
		/// <param name="m3_PHNO">Telephonenumber1</param>
		/// <param name="m3_TFNO">Facsimiletransmissionnumber</param>
		/// <param name="m3_EMAL">Electronicmailaddress</param>
		/// <param name="m3_SUCM">Suppliercomputercommunicationaddress</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSupplierRef(
			string m3_SUNO, 
			string m3_RFTY, 
			string m3_RFID, 
			string m3_YRE1 = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_EMAL = null, 
			string m3_SUCM = null, 
			string m3_REMK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSupplierRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_RFTY))
				throw new ArgumentNullException("m3_RFTY");
			if (string.IsNullOrWhiteSpace(m3_RFID))
				throw new ArgumentNullException("m3_RFID");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("RFTY", m3_RFTY.Trim())
				.WithQueryParameter("RFID", m3_RFID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_YRE1))
				request.WithQueryParameter("YRE1", m3_YRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCM))
				request.WithQueryParameter("SUCM", m3_SUCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());

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
