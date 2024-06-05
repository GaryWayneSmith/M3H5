/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAddress
		/// Description Add address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3ADTE">Addresstype (Required)</param>
		/// <param name="m3ADID">Addressnumber (Required)</param>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3PRIA">Printoutcode (Required)</param>
		/// <param name="m3STDT">Startdate</param>
		/// <param name="m3SUNM">Suppliername</param>
		/// <param name="m3ADR1">Addressline1</param>
		/// <param name="m3ADR2">Addressline2</param>
		/// <param name="m3ADR3">Addressline3</param>
		/// <param name="m3ADR4">Addressline4</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3PONO">Postalcode</param>
		/// <param name="m3PNOD">Planningnode</param>
		/// <param name="m3ADVI">Viaaddress</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3GEOX">Geographic cod X</param>
		/// <param name="m3GEOY">Geographic code Y</param>
		/// <param name="m3GEOZ">Geographic cod Z</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3SADR">Supplier´s address reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddress(
			string m3SUNO, 
			int m3ADTE, 
			string m3ADID, 
			string m3CSCD, 
			int m3PRIA, 
			DateTime? m3STDT = null, 
			string m3SUNM = null, 
			string m3ADR1 = null, 
			string m3ADR2 = null, 
			string m3ADR3 = null, 
			string m3ADR4 = null, 
			string m3TOWN = null, 
			string m3ECAR = null, 
			string m3PONO = null, 
			string m3PNOD = null, 
			string m3ADVI = null, 
			string m3EDES = null, 
			decimal? m3GEOX = null, 
			decimal? m3GEOY = null, 
			decimal? m3GEOZ = null, 
			string m3FRCO = null, 
			int? m3GEOC = null, 
			string m3SADR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("ADTE", m3ADTE.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADID", m3ADID.Trim())
				.WithQueryParameter("CSCD", m3CSCD.Trim())
				.WithQueryParameter("PRIA", m3PRIA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SUNM))
				request.WithQueryParameter("SUNM", m3SUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR1))
				request.WithQueryParameter("ADR1", m3ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR2))
				request.WithQueryParameter("ADR2", m3ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR3))
				request.WithQueryParameter("ADR3", m3ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR4))
				request.WithQueryParameter("ADR4", m3ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PNOD))
				request.WithQueryParameter("PNOD", m3PNOD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADVI))
				request.WithQueryParameter("ADVI", m3ADVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (m3GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3GEOX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3GEOY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3GEOZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SADR))
				request.WithQueryParameter("SADR", m3SADR.Trim());

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
		/// Name AddSupplier
		/// Description Add supplier
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3SUNM">Suppliername (Required)</param>
		/// <param name="m3SUTY">Suppliertype (Required)</param>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3ECAR">State (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3DTFM">Dateformat (Required)</param>
		/// <param name="m3MEPF">Mediaprofile (Required)</param>
		/// <param name="m3SUCL">Suppliergroup (Required)</param>
		/// <param name="m3QUCL">Qualityclass (Required)</param>
		/// <param name="m3ORTY">Ordertype (Required)</param>
		/// <param name="m3TEDL">Deliveryterms (Required)</param>
		/// <param name="m3MODL">Deliverymethod (Required)</param>
		/// <param name="m3TEAF">Freightterms (Required)</param>
		/// <param name="m3TEPA">Packagingterms (Required)</param>
		/// <param name="m3DT4T">Datetype (Required)</param>
		/// <param name="m3DTCD">Datecode (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CRTP">Exchangeratetype (Required)</param>
		/// <param name="m3TEPY">Paymentterms (Required)</param>
		/// <param name="m3PYME">Paymentmethod-accountspayable (Required)</param>
		/// <param name="m3ATPR">Attributepricingrule (Required)</param>
		/// <param name="m3ACRF">User-definedaccountingcontrolobject (Required)</param>
		/// <param name="m3ALSU">Searchkey</param>
		/// <param name="m3HAFE">Harbororairport</param>
		/// <param name="m3VTCD">VATcode</param>
		/// <param name="m3TXAP">Taxapplicable</param>
		/// <param name="m3TAXC">Taxcodecustomer/address</param>
		/// <param name="m3PHNO">Telephonenumber1</param>
		/// <param name="m3PHN2">Telephonenumber2</param>
		/// <param name="m3TFNO">Facsimiletransmissionnumber</param>
		/// <param name="m3TLNO">Telexnumber</param>
		/// <param name="m3CORG">Organizationnumber1</param>
		/// <param name="m3COR2">Organizationnumber2</param>
		/// <param name="m3VRNO">VATregistrationnumber</param>
		/// <param name="m3SUCO">Suppliernumberwithingroup</param>
		/// <param name="m3DESV">Alternatelangforoptiondescription</param>
		/// <param name="m3FWSC">ForwardersSCACcode</param>
		/// <param name="m3SUAL">Supplieralternateidentity</param>
		/// <param name="m3EDIT">Dateediting</param>
		/// <param name="m3SUCM">Suppliercomputercommunicationaddress</param>
		/// <param name="m3PODA">Transmissionleadtime-supplier</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3RESP">Authorized</param>
		/// <param name="m3AGNT">Agent</param>
		/// <param name="m3ABSK">ABCclass-supplier</param>
		/// <param name="m3ABSM">ABCmethod-supplier</param>
		/// <param name="m3PWMT">PINcode</param>
		/// <param name="m3DCSM">Discountcalculationmethod</param>
		/// <param name="m3FUSC">Monitoringactivitylist</param>
		/// <param name="m3SPFC">Monitoringclass</param>
		/// <param name="m3COBI">Groupofcompanies</param>
		/// <param name="m3SCNO">Suppliercustomernumber</param>
		/// <param name="m3SUGR">Statisticalsupplier</param>
		/// <param name="m3SHST">Shipmenttable</param>
		/// <param name="m3POOT">Pointoftimetable</param>
		/// <param name="m3OUCN">Ourcustomernumberatsupplier</param>
		/// <param name="m3TINO">TaxIDforsupplier</param>
		/// <param name="m3PRSU">Payee</param>
		/// <param name="m3SERS">Servicecode</param>
		/// <param name="m3SBPE">Self-billingpermitted</param>
		/// <param name="m3PACD">Paymentpriority</param>
		/// <param name="m3PTDY">Tolerance-payment</param>
		/// <param name="m3SUST">Supplierstatistics</param>
		/// <param name="m3DTDY">Tolerance-deliverydate</param>
		/// <param name="m3TECD">Cashdiscountterm</param>
		/// <param name="m3REGR">Invoiceaccountingtemplate</param>
		/// <param name="m3SUSY">Numberofyearsofstatistics</param>
		/// <param name="m3SHAC">Shipmentadvice</param>
		/// <param name="m3AVCD">Activitycode</param>
		/// <param name="m3TAME">Taxwithholdingmethod</param>
		/// <param name="m3TDCD">Tradecode</param>
		/// <param name="m3IAPT">Automaticinvoiceapprovalcode</param>
		/// <param name="m3IAPC">Invoiceapprovalcondition1</param>
		/// <param name="m3IAPE">Invoiceapprovalcondition2</param>
		/// <param name="m3IAPF">Invoiceapprovalcondition3</param>
		/// <param name="m3CFI1">User-definedfield1-supplier</param>
		/// <param name="m3CFI2">User-definedfield2-supplier</param>
		/// <param name="m3CFI3">User-definedfield3-supplier</param>
		/// <param name="m3CFI4">User-definedfield4-supplier</param>
		/// <param name="m3CFI5">User-definedfield5-supplier</param>
		/// <param name="m3CFI6">User-definedfield1-purchase/financial</param>
		/// <param name="m3CFI7">User-definedfield2-purchase/financial</param>
		/// <param name="m3CFI8">User-definedfield3-purchase/financial</param>
		/// <param name="m3CFI9">User-definedfield4-purchase/financial</param>
		/// <param name="m3CF10">User-definedfield5-purchase/financial</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PPIN">Print packing instruction</param>
		/// <param name="m3CGRP">Consolidation group</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3PPLV">Level of purchase planning</param>
		/// <param name="m3CINP">Claim invoice permitted</param>
		/// <param name="m3SCIS">Rebate claim invoice setting ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSupplier(
			string m3SUNO, 
			string m3SUNM, 
			int m3SUTY, 
			string m3CSCD, 
			string m3ECAR, 
			string m3LNCD, 
			string m3DTFM, 
			string m3MEPF, 
			string m3SUCL, 
			string m3QUCL, 
			string m3ORTY, 
			string m3TEDL, 
			string m3MODL, 
			string m3TEAF, 
			string m3TEPA, 
			int m3DT4T, 
			int m3DTCD, 
			string m3CUCD, 
			int m3CRTP, 
			string m3TEPY, 
			string m3PYME, 
			string m3ATPR, 
			string m3ACRF, 
			string m3ALSU = null, 
			string m3HAFE = null, 
			int? m3VTCD = null, 
			int? m3TXAP = null, 
			string m3TAXC = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3TFNO = null, 
			string m3TLNO = null, 
			string m3CORG = null, 
			string m3COR2 = null, 
			string m3VRNO = null, 
			string m3SUCO = null, 
			string m3DESV = null, 
			string m3FWSC = null, 
			string m3SUAL = null, 
			string m3EDIT = null, 
			string m3SUCM = null, 
			int? m3PODA = null, 
			string m3BUYE = null, 
			string m3RESP = null, 
			string m3AGNT = null, 
			string m3ABSK = null, 
			int? m3ABSM = null, 
			string m3PWMT = null, 
			int? m3DCSM = null, 
			string m3FUSC = null, 
			string m3SPFC = null, 
			string m3COBI = null, 
			string m3SCNO = null, 
			string m3SUGR = null, 
			int? m3SHST = null, 
			string m3POOT = null, 
			string m3OUCN = null, 
			string m3TINO = null, 
			string m3PRSU = null, 
			int? m3SERS = null, 
			int? m3SBPE = null, 
			string m3PACD = null, 
			int? m3PTDY = null, 
			int? m3SUST = null, 
			int? m3DTDY = null, 
			string m3TECD = null, 
			int? m3REGR = null, 
			int? m3SUSY = null, 
			int? m3SHAC = null, 
			string m3AVCD = null, 
			int? m3TAME = null, 
			string m3TDCD = null, 
			int? m3IAPT = null, 
			int? m3IAPC = null, 
			int? m3IAPE = null, 
			int? m3IAPF = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3CFI6 = null, 
			decimal? m3CFI7 = null, 
			string m3CFI8 = null, 
			string m3CFI9 = null, 
			string m3CF10 = null, 
			string m3STAT = null, 
			int? m3PPIN = null, 
			string m3CGRP = null, 
			string m3RASN = null, 
			int? m3GEOC = null, 
			int? m3PPLV = null, 
			int? m3CINP = null, 
			string m3SCIS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUNM))
				throw new ArgumentNullException(nameof(m3SUNM));
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));
			if (string.IsNullOrWhiteSpace(m3ECAR))
				throw new ArgumentNullException(nameof(m3ECAR));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));
			if (string.IsNullOrWhiteSpace(m3DTFM))
				throw new ArgumentNullException(nameof(m3DTFM));
			if (string.IsNullOrWhiteSpace(m3MEPF))
				throw new ArgumentNullException(nameof(m3MEPF));
			if (string.IsNullOrWhiteSpace(m3SUCL))
				throw new ArgumentNullException(nameof(m3SUCL));
			if (string.IsNullOrWhiteSpace(m3QUCL))
				throw new ArgumentNullException(nameof(m3QUCL));
			if (string.IsNullOrWhiteSpace(m3ORTY))
				throw new ArgumentNullException(nameof(m3ORTY));
			if (string.IsNullOrWhiteSpace(m3TEDL))
				throw new ArgumentNullException(nameof(m3TEDL));
			if (string.IsNullOrWhiteSpace(m3MODL))
				throw new ArgumentNullException(nameof(m3MODL));
			if (string.IsNullOrWhiteSpace(m3TEAF))
				throw new ArgumentNullException(nameof(m3TEAF));
			if (string.IsNullOrWhiteSpace(m3TEPA))
				throw new ArgumentNullException(nameof(m3TEPA));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3TEPY))
				throw new ArgumentNullException(nameof(m3TEPY));
			if (string.IsNullOrWhiteSpace(m3PYME))
				throw new ArgumentNullException(nameof(m3PYME));
			if (string.IsNullOrWhiteSpace(m3ATPR))
				throw new ArgumentNullException(nameof(m3ATPR));
			if (string.IsNullOrWhiteSpace(m3ACRF))
				throw new ArgumentNullException(nameof(m3ACRF));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUNM", m3SUNM.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CSCD", m3CSCD.Trim())
				.WithQueryParameter("ECAR", m3ECAR.Trim())
				.WithQueryParameter("LNCD", m3LNCD.Trim())
				.WithQueryParameter("DTFM", m3DTFM.Trim())
				.WithQueryParameter("MEPF", m3MEPF.Trim())
				.WithQueryParameter("SUCL", m3SUCL.Trim())
				.WithQueryParameter("QUCL", m3QUCL.Trim())
				.WithQueryParameter("ORTY", m3ORTY.Trim())
				.WithQueryParameter("TEDL", m3TEDL.Trim())
				.WithQueryParameter("MODL", m3MODL.Trim())
				.WithQueryParameter("TEAF", m3TEAF.Trim())
				.WithQueryParameter("TEPA", m3TEPA.Trim())
				.WithQueryParameter("DT4T", m3DT4T.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DTCD", m3DTCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("CRTP", m3CRTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TEPY", m3TEPY.Trim())
				.WithQueryParameter("PYME", m3PYME.Trim())
				.WithQueryParameter("ATPR", m3ATPR.Trim())
				.WithQueryParameter("ACRF", m3ACRF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ALSU))
				request.WithQueryParameter("ALSU", m3ALSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3TXAP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLNO))
				request.WithQueryParameter("TLNO", m3TLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CORG))
				request.WithQueryParameter("CORG", m3CORG.Trim());
			if (!string.IsNullOrWhiteSpace(m3COR2))
				request.WithQueryParameter("COR2", m3COR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCO))
				request.WithQueryParameter("SUCO", m3SUCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DESV))
				request.WithQueryParameter("DESV", m3DESV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWSC))
				request.WithQueryParameter("FWSC", m3FWSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUAL))
				request.WithQueryParameter("SUAL", m3SUAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDIT))
				request.WithQueryParameter("EDIT", m3EDIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCM))
				request.WithQueryParameter("SUCM", m3SUCM.Trim());
			if (m3PODA.HasValue)
				request.WithQueryParameter("PODA", m3PODA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNT))
				request.WithQueryParameter("AGNT", m3AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABSK))
				request.WithQueryParameter("ABSK", m3ABSK.Trim());
			if (m3ABSM.HasValue)
				request.WithQueryParameter("ABSM", m3ABSM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PWMT))
				request.WithQueryParameter("PWMT", m3PWMT.Trim());
			if (m3DCSM.HasValue)
				request.WithQueryParameter("DCSM", m3DCSM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FUSC))
				request.WithQueryParameter("FUSC", m3FUSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPFC))
				request.WithQueryParameter("SPFC", m3SPFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3COBI))
				request.WithQueryParameter("COBI", m3COBI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCNO))
				request.WithQueryParameter("SCNO", m3SCNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUGR))
				request.WithQueryParameter("SUGR", m3SUGR.Trim());
			if (m3SHST.HasValue)
				request.WithQueryParameter("SHST", m3SHST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POOT))
				request.WithQueryParameter("POOT", m3POOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OUCN))
				request.WithQueryParameter("OUCN", m3OUCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TINO))
				request.WithQueryParameter("TINO", m3TINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRSU))
				request.WithQueryParameter("PRSU", m3PRSU.Trim());
			if (m3SERS.HasValue)
				request.WithQueryParameter("SERS", m3SERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SBPE.HasValue)
				request.WithQueryParameter("SBPE", m3SBPE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACD))
				request.WithQueryParameter("PACD", m3PACD.Trim());
			if (m3PTDY.HasValue)
				request.WithQueryParameter("PTDY", m3PTDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUST.HasValue)
				request.WithQueryParameter("SUST", m3SUST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTDY.HasValue)
				request.WithQueryParameter("DTDY", m3DTDY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECD))
				request.WithQueryParameter("TECD", m3TECD.Trim());
			if (m3REGR.HasValue)
				request.WithQueryParameter("REGR", m3REGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUSY.HasValue)
				request.WithQueryParameter("SUSY", m3SUSY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHAC.HasValue)
				request.WithQueryParameter("SHAC", m3SHAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AVCD))
				request.WithQueryParameter("AVCD", m3AVCD.Trim());
			if (m3TAME.HasValue)
				request.WithQueryParameter("TAME", m3TAME.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TDCD))
				request.WithQueryParameter("TDCD", m3TDCD.Trim());
			if (m3IAPT.HasValue)
				request.WithQueryParameter("IAPT", m3IAPT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IAPC.HasValue)
				request.WithQueryParameter("IAPC", m3IAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IAPE.HasValue)
				request.WithQueryParameter("IAPE", m3IAPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IAPF.HasValue)
				request.WithQueryParameter("IAPF", m3IAPF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI1))
				request.WithQueryParameter("CFI1", m3CFI1.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI3))
				request.WithQueryParameter("CFI3", m3CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI4))
				request.WithQueryParameter("CFI4", m3CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI5))
				request.WithQueryParameter("CFI5", m3CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI6))
				request.WithQueryParameter("CFI6", m3CFI6.Trim());
			if (m3CFI7.HasValue)
				request.WithQueryParameter("CFI7", m3CFI7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI8))
				request.WithQueryParameter("CFI8", m3CFI8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI9))
				request.WithQueryParameter("CFI9", m3CFI9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CF10))
				request.WithQueryParameter("CF10", m3CF10.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3PPIN.HasValue)
				request.WithQueryParameter("PPIN", m3PPIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CGRP))
				request.WithQueryParameter("CGRP", m3CGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPLV.HasValue)
				request.WithQueryParameter("PPLV", m3PPLV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CINP.HasValue)
				request.WithQueryParameter("CINP", m3CINP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCIS))
				request.WithQueryParameter("SCIS", m3SCIS.Trim());

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
		/// Name AddSupplierRef
		/// Description Adds reference to Supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3RFTY">Referencetype (Required)</param>
		/// <param name="m3RFID">Reference (Required)</param>
		/// <param name="m3YRE1">Yourreference (Required)</param>
		/// <param name="m3PHNO">Telephonenumber1</param>
		/// <param name="m3TFNO">Facsimiletransmissionnumber</param>
		/// <param name="m3EMAL">Electronicmailaddress</param>
		/// <param name="m3SUCM">Suppliercomputercommunicationaddress</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSupplierRef(
			string m3SUNO, 
			string m3RFTY, 
			string m3RFID, 
			string m3YRE1, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3EMAL = null, 
			string m3SUCM = null, 
			string m3REMK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSupplierRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3RFTY))
				throw new ArgumentNullException(nameof(m3RFTY));
			if (string.IsNullOrWhiteSpace(m3RFID))
				throw new ArgumentNullException(nameof(m3RFID));
			if (string.IsNullOrWhiteSpace(m3YRE1))
				throw new ArgumentNullException(nameof(m3YRE1));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("RFTY", m3RFTY.Trim())
				.WithQueryParameter("RFID", m3RFID.Trim())
				.WithQueryParameter("YRE1", m3YRE1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCM))
				request.WithQueryParameter("SUCM", m3SUCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());

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
		/// Name CopyTemplate
		/// Description CopyTemplate
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3STEM">Supplier template (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3SUTY">Supplier type</param>
		/// <param name="m3OPYC">Copy capability</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CopyTemplateResponse></returns>
		/// <exception cref="M3Exception<CopyTemplateResponse>"></exception>
		public async Task<M3Response<CopyTemplateResponse>> CopyTemplate(
			string m3STEM, 
			string m3SUNO, 
			int? m3SUTY = null, 
			int? m3OPYC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CopyTemplate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STEM))
				throw new ArgumentNullException(nameof(m3STEM));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("STEM", m3STEM.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3SUTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPYC.HasValue)
				request.WithQueryParameter("OPYC", m3OPYC.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<CopyTemplateResponse>(
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
		/// Name DelAddress
		/// Description Delete Address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3ADTE">Address type (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAddress(
			string m3SUNO, 
			int m3ADTE, 
			DateTime m3STDT, 
			string m3ADID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("ADTE", m3ADTE.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("ADID", m3ADID.Trim());

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
		/// Name DelSupplierRef
		/// Description Delete Supplier Reference
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3RFTY">Reference type (Required)</param>
		/// <param name="m3RFID">Reference (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSupplierRef(
			string m3SUNO, 
			string m3RFTY, 
			string m3RFID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelSupplierRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3RFTY))
				throw new ArgumentNullException(nameof(m3RFTY));
			if (string.IsNullOrWhiteSpace(m3RFID))
				throw new ArgumentNullException(nameof(m3RFID));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("RFTY", m3RFTY.Trim())
				.WithQueryParameter("RFID", m3RFID.Trim());

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
		/// Name GetAddress
		/// Description Get supplier address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3ADTE">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			string m3SUNO, 
			int? m3ADTE = null, 
			string m3ADID = null, 
			DateTime? m3STDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ADTE.HasValue)
				request.WithQueryParameter("ADTE", m3ADTE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());

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
		/// Name GetBasicData
		/// Description Retrive supplier basic data
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3SUNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name GetSupplierRef
		/// Description Gets references linked to supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3RFTY">Referencetype (Required)</param>
		/// <param name="m3RFID">Reference (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSupplierRefResponse></returns>
		/// <exception cref="M3Exception<GetSupplierRefResponse>"></exception>
		public async Task<M3Response<GetSupplierRefResponse>> GetSupplierRef(
			string m3SUNO, 
			string m3RFTY, 
			string m3RFID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSupplierRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3RFTY))
				throw new ArgumentNullException(nameof(m3RFTY));
			if (string.IsNullOrWhiteSpace(m3RFID))
				throw new ArgumentNullException(nameof(m3RFID));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("RFTY", m3RFTY.Trim())
				.WithQueryParameter("RFID", m3RFID.Trim());

			// Execute the request
			var result = await Execute<GetSupplierRefResponse>(
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
		/// Name LstAddresses
		/// Description List addresses linked to supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAddressesResponse></returns>
		/// <exception cref="M3Exception<LstAddressesResponse>"></exception>
		public async Task<M3Response<LstAddressesResponse>> LstAddresses(
			string m3SUNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAddresses",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Execute the request
			var result = await Execute<LstAddressesResponse>(
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
		/// Name LstByName
		/// Description List supplier in Supplier name
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SUNM">Suppliername (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByNameResponse></returns>
		/// <exception cref="M3Exception<LstByNameResponse>"></exception>
		public async Task<M3Response<LstByNameResponse>> LstByName(
			string m3SUNM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByName",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNM))
				throw new ArgumentNullException(nameof(m3SUNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNM", m3SUNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByNameResponse>(
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
		/// Name LstByNumber
		/// Description List Supplier in supplier number order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByNumberResponse></returns>
		/// <exception cref="M3Exception<LstByNumberResponse>"></exception>
		public async Task<M3Response<LstByNumberResponse>> LstByNumber(
			string m3SUNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByNumber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByNumberResponse>(
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
		/// Name LstSupplierRef
		/// Description List references linked to supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSupplierRefResponse></returns>
		/// <exception cref="M3Exception<LstSupplierRefResponse>"></exception>
		public async Task<M3Response<LstSupplierRefResponse>> LstSupplierRef(
			string m3SUNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSupplierRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Execute the request
			var result = await Execute<LstSupplierRefResponse>(
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
		/// Name LstSuppliers
		/// Description Retrieves Supplier Information
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3CONO">Companynumber</param>
		/// <param name="m3FRSU">FromSupplier</param>
		/// <param name="m3TOSU">ToSupplier</param>
		/// <param name="m3LMTS">Lastimport´stimestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSuppliersResponse></returns>
		/// <exception cref="M3Exception<LstSuppliersResponse>"></exception>
		public async Task<M3Response<LstSuppliersResponse>> LstSuppliers(
			int? m3CONO = null, 
			string m3FRSU = null, 
			string m3TOSU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSuppliers",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRSU))
				request.WithQueryParameter("FRSU", m3FRSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOSU))
				request.WithQueryParameter("TOSU", m3TOSU.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSuppliersResponse>(
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
		/// Name SearchSupplier
		/// Description SearchSupplier
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchSupplierResponse></returns>
		/// <exception cref="M3Exception<SearchSupplierResponse>"></exception>
		public async Task<M3Response<SearchSupplierResponse>> SearchSupplier(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchSupplierResponse>(
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
		/// Name UpdAddress
		/// Description Updates address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3ADTE">Addresstype (Required)</param>
		/// <param name="m3ADID">Addressnumber (Required)</param>
		/// <param name="m3STDT">Startdate (Required)</param>
		/// <param name="m3SUNM">Suppliername</param>
		/// <param name="m3ADR1">Addressline1</param>
		/// <param name="m3ADR2">Addressline2</param>
		/// <param name="m3ADR3">Addressline3</param>
		/// <param name="m3ADR4">Addressline4</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3PONO">Postalcode</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PNOD">Planningnode</param>
		/// <param name="m3PRIA">Printoutcode</param>
		/// <param name="m3ADVI">Viaaddress</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3GEOX">Geographic cod X</param>
		/// <param name="m3GEOY">Geographic code Y</param>
		/// <param name="m3GEOZ">Geographic cod Z</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3SADR">Supplier´s address reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAddress(
			string m3SUNO, 
			int m3ADTE, 
			string m3ADID, 
			DateTime m3STDT, 
			string m3SUNM = null, 
			string m3ADR1 = null, 
			string m3ADR2 = null, 
			string m3ADR3 = null, 
			string m3ADR4 = null, 
			string m3TOWN = null, 
			string m3ECAR = null, 
			string m3PONO = null, 
			string m3CSCD = null, 
			string m3PNOD = null, 
			int? m3PRIA = null, 
			string m3ADVI = null, 
			string m3EDES = null, 
			decimal? m3GEOX = null, 
			decimal? m3GEOY = null, 
			decimal? m3GEOZ = null, 
			string m3FRCO = null, 
			int? m3GEOC = null, 
			string m3SADR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("ADTE", m3ADTE.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADID", m3ADID.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SUNM))
				request.WithQueryParameter("SUNM", m3SUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR1))
				request.WithQueryParameter("ADR1", m3ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR2))
				request.WithQueryParameter("ADR2", m3ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR3))
				request.WithQueryParameter("ADR3", m3ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR4))
				request.WithQueryParameter("ADR4", m3ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PNOD))
				request.WithQueryParameter("PNOD", m3PNOD.Trim());
			if (m3PRIA.HasValue)
				request.WithQueryParameter("PRIA", m3PRIA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADVI))
				request.WithQueryParameter("ADVI", m3ADVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (m3GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3GEOX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3GEOY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3GEOZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SADR))
				request.WithQueryParameter("SADR", m3SADR.Trim());

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
		/// Name UpdSupplier
		/// Description Updates Supplier
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3SUNM">Suppliername</param>
		/// <param name="m3ALSU">Searchkey</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3DTFM">Dateformat</param>
		/// <param name="m3MEPF">Mediaprofile</param>
		/// <param name="m3HAFE">Harbororairport</param>
		/// <param name="m3SUCL">Suppliergroup</param>
		/// <param name="m3QUCL">Qualityclass</param>
		/// <param name="m3ORTY">Ordertype</param>
		/// <param name="m3TEDL">Deliveryterms</param>
		/// <param name="m3MODL">Deliverymethod</param>
		/// <param name="m3TEAF">Freightterms</param>
		/// <param name="m3TEPA">Packagingterms</param>
		/// <param name="m3DT4T">Datetype</param>
		/// <param name="m3DTCD">Datecode</param>
		/// <param name="m3VTCD">VATcode</param>
		/// <param name="m3TXAP">Taxapplicable</param>
		/// <param name="m3TAXC">Taxcodecustomer/address</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CRTP">Exchangeratetype</param>
		/// <param name="m3TEPY">Paymentterms</param>
		/// <param name="m3PYME">Paymentmethod-accountspayable</param>
		/// <param name="m3ATPR">Attributepricingrule</param>
		/// <param name="m3ACRF">User-definedaccountingcontrolobject</param>
		/// <param name="m3PHNO">Telephonenumber1</param>
		/// <param name="m3PHN2">Telephonenumber2</param>
		/// <param name="m3TFNO">Facsimiletransmissionnumber</param>
		/// <param name="m3TLNO">Telexnumber</param>
		/// <param name="m3CORG">Organizationnumber1</param>
		/// <param name="m3COR2">Organizationnumber2</param>
		/// <param name="m3VRNO">VATregistrationnumber</param>
		/// <param name="m3SUCO">Suppliernumberwithingroup</param>
		/// <param name="m3DESV">Alternatelangforoptiondescription</param>
		/// <param name="m3FWSC">ForwardersSCACcode</param>
		/// <param name="m3SUAL">Supplieralternateidentity</param>
		/// <param name="m3EDIT">Dateediting</param>
		/// <param name="m3SUCM">Suppliercomputercommunicationaddress</param>
		/// <param name="m3PODA">Transmissionleadtime-supplier</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3RESP">Authorized</param>
		/// <param name="m3AGNT">Agent</param>
		/// <param name="m3ABSK">ABCclass-supplier</param>
		/// <param name="m3ABSM">ABCmethod-supplier</param>
		/// <param name="m3PWMT">PINcode</param>
		/// <param name="m3DCSM">Discountcalculationmethod</param>
		/// <param name="m3FUSC">Monitoringactivitylist</param>
		/// <param name="m3SPFC">Monitoringclass</param>
		/// <param name="m3COBI">Groupofcompanies</param>
		/// <param name="m3SCNO">Suppliercustomernumber</param>
		/// <param name="m3SUGR">Statisticalsupplier</param>
		/// <param name="m3SHST">Shipmenttable</param>
		/// <param name="m3POOT">Pointoftimetable</param>
		/// <param name="m3OUCN">Ourcustomernumberatsupplier</param>
		/// <param name="m3TINO">TaxIDforsupplier</param>
		/// <param name="m3PRSU">Payee</param>
		/// <param name="m3SERS">Servicecode</param>
		/// <param name="m3SBPE">Self-billingpermitted</param>
		/// <param name="m3PACD">Paymentpriority</param>
		/// <param name="m3PTDY">Tolerance-payment</param>
		/// <param name="m3SUST">Supplierstatistics</param>
		/// <param name="m3DTDY">Tolerance-deliverydate</param>
		/// <param name="m3TECD">Cashdiscountterm</param>
		/// <param name="m3REGR">Invoiceaccountingtemplate</param>
		/// <param name="m3SUSY">Numberofyearsofstatistics</param>
		/// <param name="m3SHAC">Shipmentadvice</param>
		/// <param name="m3AVCD">Activitycode</param>
		/// <param name="m3TAME">Taxwithholdingmethod</param>
		/// <param name="m3TDCD">Tradecode</param>
		/// <param name="m3IAPT">Automaticinvoiceapprovalcode</param>
		/// <param name="m3IAPC">Invoiceapprovalcondition1</param>
		/// <param name="m3IAPE">Invoiceapprovalcondition2</param>
		/// <param name="m3IAPF">Invoiceapprovalcondition3</param>
		/// <param name="m3CFI1">User-definedfield1-supplier</param>
		/// <param name="m3CFI2">User-definedfield2-supplier</param>
		/// <param name="m3CFI3">User-definedfield3-supplier</param>
		/// <param name="m3CFI4">User-definedfield4-supplier</param>
		/// <param name="m3CFI5">User-definedfield5-supplier</param>
		/// <param name="m3CFI6">User-definedfield1-purchase/financial</param>
		/// <param name="m3CFI7">User-definedfield2-purchase/financial</param>
		/// <param name="m3CFI8">User-definedfield3-purchase/financial</param>
		/// <param name="m3CFI9">User-definedfield4-purchase/financial</param>
		/// <param name="m3CF10">User-definedfield5-purchase/financial</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PPIN">Print packing instruction</param>
		/// <param name="m3CGRP">Consolidation group</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3PPLV">Level of purchase planning</param>
		/// <param name="m3CINP">Claim invoice permitted</param>
		/// <param name="m3SCIS">Rebate claim invoice setting ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSupplier(
			string m3SUNO, 
			string m3SUNM = null, 
			string m3ALSU = null, 
			string m3CSCD = null, 
			string m3ECAR = null, 
			string m3LNCD = null, 
			string m3DTFM = null, 
			string m3MEPF = null, 
			string m3HAFE = null, 
			string m3SUCL = null, 
			string m3QUCL = null, 
			string m3ORTY = null, 
			string m3TEDL = null, 
			string m3MODL = null, 
			string m3TEAF = null, 
			string m3TEPA = null, 
			int? m3DT4T = null, 
			int? m3DTCD = null, 
			int? m3VTCD = null, 
			int? m3TXAP = null, 
			string m3TAXC = null, 
			string m3CUCD = null, 
			int? m3CRTP = null, 
			string m3TEPY = null, 
			string m3PYME = null, 
			string m3ATPR = null, 
			string m3ACRF = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3TFNO = null, 
			string m3TLNO = null, 
			string m3CORG = null, 
			string m3COR2 = null, 
			string m3VRNO = null, 
			string m3SUCO = null, 
			string m3DESV = null, 
			string m3FWSC = null, 
			string m3SUAL = null, 
			string m3EDIT = null, 
			string m3SUCM = null, 
			int? m3PODA = null, 
			string m3BUYE = null, 
			string m3RESP = null, 
			string m3AGNT = null, 
			string m3ABSK = null, 
			int? m3ABSM = null, 
			string m3PWMT = null, 
			int? m3DCSM = null, 
			string m3FUSC = null, 
			string m3SPFC = null, 
			string m3COBI = null, 
			string m3SCNO = null, 
			string m3SUGR = null, 
			int? m3SHST = null, 
			string m3POOT = null, 
			string m3OUCN = null, 
			string m3TINO = null, 
			string m3PRSU = null, 
			int? m3SERS = null, 
			int? m3SBPE = null, 
			string m3PACD = null, 
			int? m3PTDY = null, 
			int? m3SUST = null, 
			int? m3DTDY = null, 
			string m3TECD = null, 
			int? m3REGR = null, 
			int? m3SUSY = null, 
			int? m3SHAC = null, 
			string m3AVCD = null, 
			int? m3TAME = null, 
			string m3TDCD = null, 
			int? m3IAPT = null, 
			int? m3IAPC = null, 
			int? m3IAPE = null, 
			int? m3IAPF = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3CFI6 = null, 
			decimal? m3CFI7 = null, 
			string m3CFI8 = null, 
			string m3CFI9 = null, 
			string m3CF10 = null, 
			string m3STAT = null, 
			int? m3PPIN = null, 
			string m3CGRP = null, 
			string m3RASN = null, 
			int? m3GEOC = null, 
			int? m3PPLV = null, 
			int? m3CINP = null, 
			string m3SCIS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SUNM))
				request.WithQueryParameter("SUNM", m3SUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALSU))
				request.WithQueryParameter("ALSU", m3ALSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3DTFM))
				request.WithQueryParameter("DTFM", m3DTFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCL))
				request.WithQueryParameter("SUCL", m3SUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3QUCL))
				request.WithQueryParameter("QUCL", m3QUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEAF))
				request.WithQueryParameter("TEAF", m3TEAF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (m3DT4T.HasValue)
				request.WithQueryParameter("DT4T", m3DT4T.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTCD.HasValue)
				request.WithQueryParameter("DTCD", m3DTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3TXAP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYME))
				request.WithQueryParameter("PYME", m3PYME.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATPR))
				request.WithQueryParameter("ATPR", m3ATPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TLNO))
				request.WithQueryParameter("TLNO", m3TLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CORG))
				request.WithQueryParameter("CORG", m3CORG.Trim());
			if (!string.IsNullOrWhiteSpace(m3COR2))
				request.WithQueryParameter("COR2", m3COR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCO))
				request.WithQueryParameter("SUCO", m3SUCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DESV))
				request.WithQueryParameter("DESV", m3DESV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWSC))
				request.WithQueryParameter("FWSC", m3FWSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUAL))
				request.WithQueryParameter("SUAL", m3SUAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDIT))
				request.WithQueryParameter("EDIT", m3EDIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCM))
				request.WithQueryParameter("SUCM", m3SUCM.Trim());
			if (m3PODA.HasValue)
				request.WithQueryParameter("PODA", m3PODA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNT))
				request.WithQueryParameter("AGNT", m3AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABSK))
				request.WithQueryParameter("ABSK", m3ABSK.Trim());
			if (m3ABSM.HasValue)
				request.WithQueryParameter("ABSM", m3ABSM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PWMT))
				request.WithQueryParameter("PWMT", m3PWMT.Trim());
			if (m3DCSM.HasValue)
				request.WithQueryParameter("DCSM", m3DCSM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FUSC))
				request.WithQueryParameter("FUSC", m3FUSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPFC))
				request.WithQueryParameter("SPFC", m3SPFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3COBI))
				request.WithQueryParameter("COBI", m3COBI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCNO))
				request.WithQueryParameter("SCNO", m3SCNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUGR))
				request.WithQueryParameter("SUGR", m3SUGR.Trim());
			if (m3SHST.HasValue)
				request.WithQueryParameter("SHST", m3SHST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POOT))
				request.WithQueryParameter("POOT", m3POOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OUCN))
				request.WithQueryParameter("OUCN", m3OUCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TINO))
				request.WithQueryParameter("TINO", m3TINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRSU))
				request.WithQueryParameter("PRSU", m3PRSU.Trim());
			if (m3SERS.HasValue)
				request.WithQueryParameter("SERS", m3SERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SBPE.HasValue)
				request.WithQueryParameter("SBPE", m3SBPE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACD))
				request.WithQueryParameter("PACD", m3PACD.Trim());
			if (m3PTDY.HasValue)
				request.WithQueryParameter("PTDY", m3PTDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUST.HasValue)
				request.WithQueryParameter("SUST", m3SUST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTDY.HasValue)
				request.WithQueryParameter("DTDY", m3DTDY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECD))
				request.WithQueryParameter("TECD", m3TECD.Trim());
			if (m3REGR.HasValue)
				request.WithQueryParameter("REGR", m3REGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUSY.HasValue)
				request.WithQueryParameter("SUSY", m3SUSY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHAC.HasValue)
				request.WithQueryParameter("SHAC", m3SHAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AVCD))
				request.WithQueryParameter("AVCD", m3AVCD.Trim());
			if (m3TAME.HasValue)
				request.WithQueryParameter("TAME", m3TAME.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TDCD))
				request.WithQueryParameter("TDCD", m3TDCD.Trim());
			if (m3IAPT.HasValue)
				request.WithQueryParameter("IAPT", m3IAPT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IAPC.HasValue)
				request.WithQueryParameter("IAPC", m3IAPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IAPE.HasValue)
				request.WithQueryParameter("IAPE", m3IAPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IAPF.HasValue)
				request.WithQueryParameter("IAPF", m3IAPF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI1))
				request.WithQueryParameter("CFI1", m3CFI1.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI3))
				request.WithQueryParameter("CFI3", m3CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI4))
				request.WithQueryParameter("CFI4", m3CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI5))
				request.WithQueryParameter("CFI5", m3CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI6))
				request.WithQueryParameter("CFI6", m3CFI6.Trim());
			if (m3CFI7.HasValue)
				request.WithQueryParameter("CFI7", m3CFI7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI8))
				request.WithQueryParameter("CFI8", m3CFI8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI9))
				request.WithQueryParameter("CFI9", m3CFI9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CF10))
				request.WithQueryParameter("CF10", m3CF10.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3PPIN.HasValue)
				request.WithQueryParameter("PPIN", m3PPIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CGRP))
				request.WithQueryParameter("CGRP", m3CGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPLV.HasValue)
				request.WithQueryParameter("PPLV", m3PPLV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CINP.HasValue)
				request.WithQueryParameter("CINP", m3CINP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCIS))
				request.WithQueryParameter("SCIS", m3SCIS.Trim());

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
		/// Name UpdSupplierRef
		/// Description Updates reference of Supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3RFTY">Referencetype (Required)</param>
		/// <param name="m3RFID">Reference (Required)</param>
		/// <param name="m3YRE1">Yourreference</param>
		/// <param name="m3PHNO">Telephonenumber1</param>
		/// <param name="m3TFNO">Facsimiletransmissionnumber</param>
		/// <param name="m3EMAL">Electronicmailaddress</param>
		/// <param name="m3SUCM">Suppliercomputercommunicationaddress</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSupplierRef(
			string m3SUNO, 
			string m3RFTY, 
			string m3RFID, 
			string m3YRE1 = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3EMAL = null, 
			string m3SUCM = null, 
			string m3REMK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdSupplierRef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3RFTY))
				throw new ArgumentNullException(nameof(m3RFTY));
			if (string.IsNullOrWhiteSpace(m3RFID))
				throw new ArgumentNullException(nameof(m3RFID));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("RFTY", m3RFTY.Trim())
				.WithQueryParameter("RFID", m3RFID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3YRE1))
				request.WithQueryParameter("YRE1", m3YRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCM))
				request.WithQueryParameter("SUCM", m3SUCM.Trim());
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());

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
