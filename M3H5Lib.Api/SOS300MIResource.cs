/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.SOS300MI;
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
	/// Name: SOS300MI
	/// Component Name: ServiceOrder
	/// Description: Batch order entry Service order
	/// Version Release: 5ea0
	///</summary>
	public partial class SOS300MIResource : M3BaseResourceEndpoint
	{
		public SOS300MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SOS300MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBatchAssignm
		/// Description Add service batch order assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3JOBN">Service order job number</param>
		/// <param name="m3JBSX">Assignment suffix</param>
		/// <param name="m3INNO">Individual item number</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3MODE">Model description</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3PMDT">Error reporting date</param>
		/// <param name="m3PMTM">Error report time</param>
		/// <param name="m3RQSD">Required start date</param>
		/// <param name="m3RQST">Required start time</param>
		/// <param name="m3RQFD">Required finish date</param>
		/// <param name="m3RQFT">Required finish time</param>
		/// <param name="m3CSDT">Confirmed start date</param>
		/// <param name="m3CSTM">Confirmed start time</param>
		/// <param name="m3CFDA">Confirmed finish date</param>
		/// <param name="m3CFTM">Confirmed finish time</param>
		/// <param name="m3SSDT">Last start date</param>
		/// <param name="m3SSTM">Last start time</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3ESCO">Error symptom</param>
		/// <param name="m3ETX1">Error symptom text</param>
		/// <param name="m3ETX2">Error symptom text</param>
		/// <param name="m3ETX3">Error symptom text</param>
		/// <param name="m3ETX4">Error symptom text</param>
		/// <param name="m3ERCO">Error cause</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3SVID">Service expense</param>
		/// <param name="m3WOTM">Forecast work hours</param>
		/// <param name="m3PRTM">Planned preparation time</param>
		/// <param name="m3FITM">Planned completion time</param>
		/// <param name="m3TRTI">Planned travel time</param>
		/// <param name="m3PSDW">Planned start date - task</param>
		/// <param name="m3PSTW">Planned start time - task</param>
		/// <param name="m3PFDW">Planned finish date - task</param>
		/// <param name="m3PFTW">Planned finish time - task</param>
		/// <param name="m3PSDJ">Planned start date - assignment</param>
		/// <param name="m3PSTJ">Planned start time - assignment</param>
		/// <param name="m3PFDJ">Planned finish date - assignment</param>
		/// <param name="m3PFTJ">Planned finish time - assignment</param>
		/// <param name="m3MTCO">Action text</param>
		/// <param name="m3MTX1">Text</param>
		/// <param name="m3MTX2">Text</param>
		/// <param name="m3MTX3">Text</param>
		/// <param name="m3MTX4">Text</param>
		/// <param name="m3MECO">Action</param>
		/// <param name="m3OPRI">Priority</param>
		/// <param name="m3JBST">Status service assignment</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3ASST">Assignment type</param>
		/// <param name="m3FCTN">Function area</param>
		/// <param name="m3TRIN">Transportation of individual item</param>
		/// <param name="m3QUNO">Qualification</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3RDTE">Received date</param>
		/// <param name="m3RTIM">Received time</param>
		/// <param name="m3CNDI">Individual item condition</param>
		/// <param name="m3JBSE">Additional status</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3ROLE">Role/organizational position</param>
		/// <param name="m3ABLC">Allocation block code</param>
		/// <param name="m3PLME">Sent to remote server</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchAssignmResponse></returns>
		/// <exception cref="M3Exception<AddBatchAssignmResponse>"></exception>
		public async Task<M3Response<AddBatchAssignmResponse>> AddBatchAssignm(
			string m3ORNO, 
			int? m3CONO = null, 
			int? m3JOBN = null, 
			int? m3JBSX = null, 
			string m3INNO = null, 
			string m3SERI = null, 
			string m3MODE = null, 
			string m3ITNO = null, 
			string m3TECH = null, 
			string m3SRES = null, 
			DateTime? m3PMDT = null, 
			int? m3PMTM = null, 
			DateTime? m3RQSD = null, 
			int? m3RQST = null, 
			DateTime? m3RQFD = null, 
			int? m3RQFT = null, 
			DateTime? m3CSDT = null, 
			int? m3CSTM = null, 
			DateTime? m3CFDA = null, 
			int? m3CFTM = null, 
			DateTime? m3SSDT = null, 
			int? m3SSTM = null, 
			string m3CTNO = null, 
			string m3ESCO = null, 
			string m3ETX1 = null, 
			string m3ETX2 = null, 
			string m3ETX3 = null, 
			string m3ETX4 = null, 
			string m3ERCO = null, 
			string m3DBCO = null, 
			string m3SVID = null, 
			int? m3WOTM = null, 
			int? m3PRTM = null, 
			int? m3FITM = null, 
			int? m3TRTI = null, 
			DateTime? m3PSDW = null, 
			int? m3PSTW = null, 
			DateTime? m3PFDW = null, 
			int? m3PFTW = null, 
			DateTime? m3PSDJ = null, 
			int? m3PSTJ = null, 
			DateTime? m3PFDJ = null, 
			int? m3PFTJ = null, 
			string m3MTCO = null, 
			string m3MTX1 = null, 
			string m3MTX2 = null, 
			string m3MTX3 = null, 
			string m3MTX4 = null, 
			string m3MECO = null, 
			int? m3OPRI = null, 
			string m3JBST = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3ASST = null, 
			string m3FCTN = null, 
			int? m3TRIN = null, 
			string m3QUNO = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			DateTime? m3RDTE = null, 
			int? m3RTIM = null, 
			string m3CNDI = null, 
			string m3JBSE = null, 
			string m3SUFI = null, 
			string m3ROLE = null, 
			int? m3ABLC = null, 
			int? m3PLME = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchAssignm",
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
			if (m3JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3JOBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3JBSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODE))
				request.WithQueryParameter("MODE", m3MODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (m3PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3PMDT.Value.ToM3String());
			if (m3PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3PMTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RQSD.HasValue)
				request.WithQueryParameter("RQSD", m3RQSD.Value.ToM3String());
			if (m3RQST.HasValue)
				request.WithQueryParameter("RQST", m3RQST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RQFD.HasValue)
				request.WithQueryParameter("RQFD", m3RQFD.Value.ToM3String());
			if (m3RQFT.HasValue)
				request.WithQueryParameter("RQFT", m3RQFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSDT.HasValue)
				request.WithQueryParameter("CSDT", m3CSDT.Value.ToM3String());
			if (m3CSTM.HasValue)
				request.WithQueryParameter("CSTM", m3CSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFDA.HasValue)
				request.WithQueryParameter("CFDA", m3CFDA.Value.ToM3String());
			if (m3CFTM.HasValue)
				request.WithQueryParameter("CFTM", m3CFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSDT.HasValue)
				request.WithQueryParameter("SSDT", m3SSDT.Value.ToM3String());
			if (m3SSTM.HasValue)
				request.WithQueryParameter("SSTM", m3SSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ESCO))
				request.WithQueryParameter("ESCO", m3ESCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX1))
				request.WithQueryParameter("ETX1", m3ETX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX2))
				request.WithQueryParameter("ETX2", m3ETX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX3))
				request.WithQueryParameter("ETX3", m3ETX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX4))
				request.WithQueryParameter("ETX4", m3ETX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ERCO))
				request.WithQueryParameter("ERCO", m3ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SVID))
				request.WithQueryParameter("SVID", m3SVID.Trim());
			if (m3WOTM.HasValue)
				request.WithQueryParameter("WOTM", m3WOTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRTM.HasValue)
				request.WithQueryParameter("PRTM", m3PRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FITM.HasValue)
				request.WithQueryParameter("FITM", m3FITM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRTI.HasValue)
				request.WithQueryParameter("TRTI", m3TRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSDW.HasValue)
				request.WithQueryParameter("PSDW", m3PSDW.Value.ToM3String());
			if (m3PSTW.HasValue)
				request.WithQueryParameter("PSTW", m3PSTW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PFDW.HasValue)
				request.WithQueryParameter("PFDW", m3PFDW.Value.ToM3String());
			if (m3PFTW.HasValue)
				request.WithQueryParameter("PFTW", m3PFTW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSDJ.HasValue)
				request.WithQueryParameter("PSDJ", m3PSDJ.Value.ToM3String());
			if (m3PSTJ.HasValue)
				request.WithQueryParameter("PSTJ", m3PSTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PFDJ.HasValue)
				request.WithQueryParameter("PFDJ", m3PFDJ.Value.ToM3String());
			if (m3PFTJ.HasValue)
				request.WithQueryParameter("PFTJ", m3PFTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTCO))
				request.WithQueryParameter("MTCO", m3MTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX1))
				request.WithQueryParameter("MTX1", m3MTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX2))
				request.WithQueryParameter("MTX2", m3MTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX3))
				request.WithQueryParameter("MTX3", m3MTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX4))
				request.WithQueryParameter("MTX4", m3MTX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3MECO))
				request.WithQueryParameter("MECO", m3MECO.Trim());
			if (m3OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3OPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3JBST))
				request.WithQueryParameter("JBST", m3JBST.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASST))
				request.WithQueryParameter("ASST", m3ASST.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCTN))
				request.WithQueryParameter("FCTN", m3FCTN.Trim());
			if (m3TRIN.HasValue)
				request.WithQueryParameter("TRIN", m3TRIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QUNO))
				request.WithQueryParameter("QUNO", m3QUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3RDTE.HasValue)
				request.WithQueryParameter("RDTE", m3RDTE.Value.ToM3String());
			if (m3RTIM.HasValue)
				request.WithQueryParameter("RTIM", m3RTIM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CNDI))
				request.WithQueryParameter("CNDI", m3CNDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3JBSE))
				request.WithQueryParameter("JBSE", m3JBSE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROLE))
				request.WithQueryParameter("ROLE", m3ROLE.Trim());
			if (m3ABLC.HasValue)
				request.WithQueryParameter("ABLC", m3ABLC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLME.HasValue)
				request.WithQueryParameter("PLME", m3PLME.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddBatchAssignmResponse>(
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
		/// Description Add service batch order head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3SOTP">Service order type</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3PRS1">Price list SO</param>
		/// <param name="m3PMDT">Error reporting date</param>
		/// <param name="m3PMTM">Error report time</param>
		/// <param name="m3RQSD">Required start date</param>
		/// <param name="m3RQST">Required start time</param>
		/// <param name="m3RQFD">Required finish date</param>
		/// <param name="m3RQFT">Required finish time</param>
		/// <param name="m3CSDT">Confirmed start date</param>
		/// <param name="m3CSTM">Confirmed start time</param>
		/// <param name="m3CFDA">Confirmed finish date</param>
		/// <param name="m3CFTM">Confirmed finish time</param>
		/// <param name="m3CBDT">Contact customer date</param>
		/// <param name="m3CBTM">Contact customer time</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3OSDT">Order entry date</param>
		/// <param name="m3CUDT">Customer´s purchase order date</param>
		/// <param name="m3DMDT">Manual due date</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3AICD">Summary invoice</param>
		/// <param name="m3EXCD">Service charge</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3DLRM">Remark</param>
		/// <param name="m3LHCD">Language code order head</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3SO40">FAM direct</param>
		/// <param name="m3RONO">Run</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TAXC">Tax code</param>
		/// <param name="m3CHSY">Line charge model</param>
		/// <param name="m3TXAP">Tax applicable</param>
		/// <param name="m3INNO">Individual item number</param>
		/// <param name="m3REBE">Registration number</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3MORN">Mobile service order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchHeadResponse></returns>
		/// <exception cref="M3Exception<AddBatchHeadResponse>"></exception>
		public async Task<M3Response<AddBatchHeadResponse>> AddBatchHead(
			int? m3CONO = null, 
			string m3ORNO = null, 
			string m3CUNO = null, 
			string m3SOTP = null, 
			string m3TEPY = null, 
			string m3ADID = null, 
			string m3PYNO = null, 
			string m3CUCD = null, 
			string m3SMCD = null, 
			string m3SRES = null, 
			string m3TECH = null, 
			string m3PRS1 = null, 
			DateTime? m3PMDT = null, 
			int? m3PMTM = null, 
			DateTime? m3RQSD = null, 
			int? m3RQST = null, 
			DateTime? m3RQFD = null, 
			int? m3RQFT = null, 
			DateTime? m3CSDT = null, 
			int? m3CSTM = null, 
			DateTime? m3CFDA = null, 
			int? m3CFTM = null, 
			DateTime? m3CBDT = null, 
			int? m3CBTM = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3TFNO = null, 
			DateTime? m3OSDT = null, 
			DateTime? m3CUDT = null, 
			DateTime? m3DMDT = null, 
			string m3OREF = null, 
			string m3YREF = null, 
			int? m3AICD = null, 
			string m3EXCD = null, 
			string m3CUOR = null, 
			string m3DLRM = null, 
			string m3LHCD = null, 
			string m3OFNO = null, 
			int? m3SO40 = null, 
			string m3RONO = null, 
			string m3RORN = null, 
			int? m3RORC = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3FACI = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TAXC = null, 
			string m3CHSY = null, 
			int? m3TXAP = null, 
			string m3INNO = null, 
			string m3REBE = null, 
			int? m3CRTP = null, 
			string m3MORN = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SOTP))
				request.WithQueryParameter("SOTP", m3SOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRS1))
				request.WithQueryParameter("PRS1", m3PRS1.Trim());
			if (m3PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3PMDT.Value.ToM3String());
			if (m3PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3PMTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RQSD.HasValue)
				request.WithQueryParameter("RQSD", m3RQSD.Value.ToM3String());
			if (m3RQST.HasValue)
				request.WithQueryParameter("RQST", m3RQST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RQFD.HasValue)
				request.WithQueryParameter("RQFD", m3RQFD.Value.ToM3String());
			if (m3RQFT.HasValue)
				request.WithQueryParameter("RQFT", m3RQFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSDT.HasValue)
				request.WithQueryParameter("CSDT", m3CSDT.Value.ToM3String());
			if (m3CSTM.HasValue)
				request.WithQueryParameter("CSTM", m3CSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFDA.HasValue)
				request.WithQueryParameter("CFDA", m3CFDA.Value.ToM3String());
			if (m3CFTM.HasValue)
				request.WithQueryParameter("CFTM", m3CFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CBDT.HasValue)
				request.WithQueryParameter("CBDT", m3CBDT.Value.ToM3String());
			if (m3CBTM.HasValue)
				request.WithQueryParameter("CBTM", m3CBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (m3OSDT.HasValue)
				request.WithQueryParameter("OSDT", m3OSDT.Value.ToM3String());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (m3DMDT.HasValue)
				request.WithQueryParameter("DMDT", m3DMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (m3AICD.HasValue)
				request.WithQueryParameter("AICD", m3AICD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXCD))
				request.WithQueryParameter("EXCD", m3EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLRM))
				request.WithQueryParameter("DLRM", m3DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3LHCD))
				request.WithQueryParameter("LHCD", m3LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3SO40.HasValue)
				request.WithQueryParameter("SO40", m3SO40.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RONO))
				request.WithQueryParameter("RONO", m3RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHSY))
				request.WithQueryParameter("CHSY", m3CHSY.Trim());
			if (m3TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3TXAP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3REBE))
				request.WithQueryParameter("REBE", m3REBE.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MORN))
				request.WithQueryParameter("MORN", m3MORN.Trim());

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
		/// Name AddSOAssignm
		/// Description Add service order assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3INNO">Individual item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3JOBN">Service order job number</param>
		/// <param name="m3JBSX">Assignment suffix</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3MODE">Model description</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3PMDT">Error reporting date</param>
		/// <param name="m3PMTM">Error report time</param>
		/// <param name="m3RQSD">Required start date</param>
		/// <param name="m3RQST">Required start time</param>
		/// <param name="m3RQFD">Required finish date</param>
		/// <param name="m3RQFT">Required finish time</param>
		/// <param name="m3CSDT">Confirmed start date</param>
		/// <param name="m3CSTM">Confirmed start time</param>
		/// <param name="m3CFDA">Confirmed finish date</param>
		/// <param name="m3CFTM">Confirmed finish time</param>
		/// <param name="m3SSDT">Last start date</param>
		/// <param name="m3SSTM">Last start time</param>
		/// <param name="m3RSDJ">Actual start date - assignment</param>
		/// <param name="m3RSTJ">Actual start time - assignment</param>
		/// <param name="m3RFDJ">Actual finish date - assignment</param>
		/// <param name="m3RFTJ">Actual finish time - assignment</param>
		/// <param name="m3RSDW">Actual start date - task</param>
		/// <param name="m3RSTW">Actual start time - task</param>
		/// <param name="m3RFDW">Actual finish date - task</param>
		/// <param name="m3RFTW">Actual finish time - task</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3ESCO">Error symptom</param>
		/// <param name="m3ETX1">Error symptom text</param>
		/// <param name="m3ETX2">Error symptom text</param>
		/// <param name="m3ETX3">Error symptom text</param>
		/// <param name="m3ETX4">Error symptom text</param>
		/// <param name="m3ERCO">Error cause</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3SVID">Service expense</param>
		/// <param name="m3WOTM">Forecast work hours</param>
		/// <param name="m3PRTM">Planned preparation time</param>
		/// <param name="m3FITM">Planned completion time</param>
		/// <param name="m3TRTI">Planned travel time</param>
		/// <param name="m3PSDW">Planned start date - task</param>
		/// <param name="m3PSTW">Planned start time - task</param>
		/// <param name="m3PFDW">Planned finish date - task</param>
		/// <param name="m3PFTW">Planned finish time - task</param>
		/// <param name="m3PSDJ">Planned start date - assignment</param>
		/// <param name="m3PSTJ">Planned start time - assignment</param>
		/// <param name="m3PFDJ">Planned finish date - assignment</param>
		/// <param name="m3PFTJ">Planned finish time - assignment</param>
		/// <param name="m3MTCO">Action text</param>
		/// <param name="m3MTX1">Text</param>
		/// <param name="m3MTX2">Text</param>
		/// <param name="m3MTX3">Text</param>
		/// <param name="m3MTX4">Text</param>
		/// <param name="m3MECO">Action</param>
		/// <param name="m3OPRI">Priority</param>
		/// <param name="m3JDCD">Joint delivery</param>
		/// <param name="m3JBST">Status service assignment</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3ASST">Assignment type</param>
		/// <param name="m3FCTN">Function area</param>
		/// <param name="m3TRIN">Transportation of individual item</param>
		/// <param name="m3QUNO">Qualification</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3RDTE">Received date</param>
		/// <param name="m3RTIM">Received time</param>
		/// <param name="m3ADEQ">Additional equipment</param>
		/// <param name="m3CNDI">Individual item condition</param>
		/// <param name="m3JBSE">Additional status</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3ABLC">Allocation block code</param>
		/// <param name="m3ATQC">Authority required</param>
		/// <param name="m3PLME">Sent to remote server</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddSOAssignmResponse></returns>
		/// <exception cref="M3Exception<AddSOAssignmResponse>"></exception>
		public async Task<M3Response<AddSOAssignmResponse>> AddSOAssignm(
			string m3ORNO, 
			string m3INNO, 
			int? m3CONO = null, 
			int? m3JOBN = null, 
			int? m3JBSX = null, 
			string m3SERI = null, 
			string m3MODE = null, 
			string m3ITNO = null, 
			string m3TECH = null, 
			string m3SRES = null, 
			DateTime? m3PMDT = null, 
			int? m3PMTM = null, 
			DateTime? m3RQSD = null, 
			int? m3RQST = null, 
			DateTime? m3RQFD = null, 
			int? m3RQFT = null, 
			DateTime? m3CSDT = null, 
			int? m3CSTM = null, 
			DateTime? m3CFDA = null, 
			int? m3CFTM = null, 
			DateTime? m3SSDT = null, 
			int? m3SSTM = null, 
			DateTime? m3RSDJ = null, 
			int? m3RSTJ = null, 
			DateTime? m3RFDJ = null, 
			int? m3RFTJ = null, 
			DateTime? m3RSDW = null, 
			int? m3RSTW = null, 
			DateTime? m3RFDW = null, 
			int? m3RFTW = null, 
			string m3CTNO = null, 
			string m3ESCO = null, 
			string m3ETX1 = null, 
			string m3ETX2 = null, 
			string m3ETX3 = null, 
			string m3ETX4 = null, 
			string m3ERCO = null, 
			string m3DBCO = null, 
			string m3SVID = null, 
			int? m3WOTM = null, 
			int? m3PRTM = null, 
			int? m3FITM = null, 
			int? m3TRTI = null, 
			DateTime? m3PSDW = null, 
			int? m3PSTW = null, 
			DateTime? m3PFDW = null, 
			int? m3PFTW = null, 
			DateTime? m3PSDJ = null, 
			int? m3PSTJ = null, 
			DateTime? m3PFDJ = null, 
			int? m3PFTJ = null, 
			string m3MTCO = null, 
			string m3MTX1 = null, 
			string m3MTX2 = null, 
			string m3MTX3 = null, 
			string m3MTX4 = null, 
			string m3MECO = null, 
			int? m3OPRI = null, 
			string m3JDCD = null, 
			string m3JBST = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3ASST = null, 
			string m3FCTN = null, 
			int? m3TRIN = null, 
			string m3QUNO = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			DateTime? m3RDTE = null, 
			int? m3RTIM = null, 
			string m3ADEQ = null, 
			string m3CNDI = null, 
			string m3JBSE = null, 
			string m3SUFI = null, 
			int? m3ABLC = null, 
			int? m3ATQC = null, 
			int? m3PLME = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSOAssignm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3INNO))
				throw new ArgumentNullException(nameof(m3INNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("INNO", m3INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3JOBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3JBSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODE))
				request.WithQueryParameter("MODE", m3MODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (m3PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3PMDT.Value.ToM3String());
			if (m3PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3PMTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RQSD.HasValue)
				request.WithQueryParameter("RQSD", m3RQSD.Value.ToM3String());
			if (m3RQST.HasValue)
				request.WithQueryParameter("RQST", m3RQST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RQFD.HasValue)
				request.WithQueryParameter("RQFD", m3RQFD.Value.ToM3String());
			if (m3RQFT.HasValue)
				request.WithQueryParameter("RQFT", m3RQFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSDT.HasValue)
				request.WithQueryParameter("CSDT", m3CSDT.Value.ToM3String());
			if (m3CSTM.HasValue)
				request.WithQueryParameter("CSTM", m3CSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFDA.HasValue)
				request.WithQueryParameter("CFDA", m3CFDA.Value.ToM3String());
			if (m3CFTM.HasValue)
				request.WithQueryParameter("CFTM", m3CFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSDT.HasValue)
				request.WithQueryParameter("SSDT", m3SSDT.Value.ToM3String());
			if (m3SSTM.HasValue)
				request.WithQueryParameter("SSTM", m3SSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSDJ.HasValue)
				request.WithQueryParameter("RSDJ", m3RSDJ.Value.ToM3String());
			if (m3RSTJ.HasValue)
				request.WithQueryParameter("RSTJ", m3RSTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RFDJ.HasValue)
				request.WithQueryParameter("RFDJ", m3RFDJ.Value.ToM3String());
			if (m3RFTJ.HasValue)
				request.WithQueryParameter("RFTJ", m3RFTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSDW.HasValue)
				request.WithQueryParameter("RSDW", m3RSDW.Value.ToM3String());
			if (m3RSTW.HasValue)
				request.WithQueryParameter("RSTW", m3RSTW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RFDW.HasValue)
				request.WithQueryParameter("RFDW", m3RFDW.Value.ToM3String());
			if (m3RFTW.HasValue)
				request.WithQueryParameter("RFTW", m3RFTW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ESCO))
				request.WithQueryParameter("ESCO", m3ESCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX1))
				request.WithQueryParameter("ETX1", m3ETX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX2))
				request.WithQueryParameter("ETX2", m3ETX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX3))
				request.WithQueryParameter("ETX3", m3ETX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX4))
				request.WithQueryParameter("ETX4", m3ETX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ERCO))
				request.WithQueryParameter("ERCO", m3ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SVID))
				request.WithQueryParameter("SVID", m3SVID.Trim());
			if (m3WOTM.HasValue)
				request.WithQueryParameter("WOTM", m3WOTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRTM.HasValue)
				request.WithQueryParameter("PRTM", m3PRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FITM.HasValue)
				request.WithQueryParameter("FITM", m3FITM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRTI.HasValue)
				request.WithQueryParameter("TRTI", m3TRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSDW.HasValue)
				request.WithQueryParameter("PSDW", m3PSDW.Value.ToM3String());
			if (m3PSTW.HasValue)
				request.WithQueryParameter("PSTW", m3PSTW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PFDW.HasValue)
				request.WithQueryParameter("PFDW", m3PFDW.Value.ToM3String());
			if (m3PFTW.HasValue)
				request.WithQueryParameter("PFTW", m3PFTW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSDJ.HasValue)
				request.WithQueryParameter("PSDJ", m3PSDJ.Value.ToM3String());
			if (m3PSTJ.HasValue)
				request.WithQueryParameter("PSTJ", m3PSTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PFDJ.HasValue)
				request.WithQueryParameter("PFDJ", m3PFDJ.Value.ToM3String());
			if (m3PFTJ.HasValue)
				request.WithQueryParameter("PFTJ", m3PFTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTCO))
				request.WithQueryParameter("MTCO", m3MTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX1))
				request.WithQueryParameter("MTX1", m3MTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX2))
				request.WithQueryParameter("MTX2", m3MTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX3))
				request.WithQueryParameter("MTX3", m3MTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX4))
				request.WithQueryParameter("MTX4", m3MTX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3MECO))
				request.WithQueryParameter("MECO", m3MECO.Trim());
			if (m3OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3OPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3JDCD))
				request.WithQueryParameter("JDCD", m3JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3JBST))
				request.WithQueryParameter("JBST", m3JBST.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASST))
				request.WithQueryParameter("ASST", m3ASST.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCTN))
				request.WithQueryParameter("FCTN", m3FCTN.Trim());
			if (m3TRIN.HasValue)
				request.WithQueryParameter("TRIN", m3TRIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QUNO))
				request.WithQueryParameter("QUNO", m3QUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3RDTE.HasValue)
				request.WithQueryParameter("RDTE", m3RDTE.Value.ToM3String());
			if (m3RTIM.HasValue)
				request.WithQueryParameter("RTIM", m3RTIM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADEQ))
				request.WithQueryParameter("ADEQ", m3ADEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3CNDI))
				request.WithQueryParameter("CNDI", m3CNDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3JBSE))
				request.WithQueryParameter("JBSE", m3JBSE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3ABLC.HasValue)
				request.WithQueryParameter("ABLC", m3ABLC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATQC.HasValue)
				request.WithQueryParameter("ATQC", m3ATQC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLME.HasValue)
				request.WithQueryParameter("PLME", m3PLME.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddSOAssignmResponse>(
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
		/// Name AddSOHead
		/// Description Add service order head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3SOTP">Service order type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3PRS1">Price list SO</param>
		/// <param name="m3PMDT">Error reporting date</param>
		/// <param name="m3PMTM">Error report time</param>
		/// <param name="m3RQSD">Required start date</param>
		/// <param name="m3RQST">Required start time</param>
		/// <param name="m3RQFD">Required finish date</param>
		/// <param name="m3RQFT">Required finish time</param>
		/// <param name="m3CSDT">Confirmed start date</param>
		/// <param name="m3CSTM">Confirmed start time</param>
		/// <param name="m3CFDA">Confirmed finish date</param>
		/// <param name="m3CFTM">Confirmed finish time</param>
		/// <param name="m3CBDT">Contact customer date</param>
		/// <param name="m3CBTM">Contact customer time</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3OSDT">Order entry date</param>
		/// <param name="m3CUDT">Customer´s purchase order date</param>
		/// <param name="m3DMDT">Manual due date</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3AICD">Summary invoice</param>
		/// <param name="m3EXCD">Service charge</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3DLRM">Remark</param>
		/// <param name="m3LHCD">Language code order head</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3SO40">FAM direct</param>
		/// <param name="m3RONO">Run</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TAXC">Tax code</param>
		/// <param name="m3CHSY">Line charge model</param>
		/// <param name="m3TXAP">Tax applicable</param>
		/// <param name="m3INNO">Individual item number</param>
		/// <param name="m3REBE">Registration number</param>
		/// <param name="m3OIVR">Original invoice reference</param>
		/// <param name="m3OYEA">Original year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddSOHeadResponse></returns>
		/// <exception cref="M3Exception<AddSOHeadResponse>"></exception>
		public async Task<M3Response<AddSOHeadResponse>> AddSOHead(
			string m3CUNO, 
			string m3SOTP, 
			int? m3CONO = null, 
			string m3ORNO = null, 
			string m3TEPY = null, 
			string m3ADID = null, 
			string m3PYNO = null, 
			string m3CUCD = null, 
			string m3SMCD = null, 
			string m3SRES = null, 
			string m3TECH = null, 
			string m3PRS1 = null, 
			DateTime? m3PMDT = null, 
			int? m3PMTM = null, 
			DateTime? m3RQSD = null, 
			int? m3RQST = null, 
			DateTime? m3RQFD = null, 
			int? m3RQFT = null, 
			DateTime? m3CSDT = null, 
			int? m3CSTM = null, 
			DateTime? m3CFDA = null, 
			int? m3CFTM = null, 
			DateTime? m3CBDT = null, 
			int? m3CBTM = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3TFNO = null, 
			DateTime? m3OSDT = null, 
			DateTime? m3CUDT = null, 
			DateTime? m3DMDT = null, 
			string m3OREF = null, 
			string m3YREF = null, 
			int? m3AICD = null, 
			string m3EXCD = null, 
			string m3CUOR = null, 
			string m3DLRM = null, 
			string m3LHCD = null, 
			string m3OFNO = null, 
			int? m3SO40 = null, 
			string m3RONO = null, 
			string m3RORN = null, 
			int? m3RORC = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3FACI = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TAXC = null, 
			string m3CHSY = null, 
			int? m3TXAP = null, 
			string m3INNO = null, 
			string m3REBE = null, 
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSOHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3SOTP))
				throw new ArgumentNullException(nameof(m3SOTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("SOTP", m3SOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRS1))
				request.WithQueryParameter("PRS1", m3PRS1.Trim());
			if (m3PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3PMDT.Value.ToM3String());
			if (m3PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3PMTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RQSD.HasValue)
				request.WithQueryParameter("RQSD", m3RQSD.Value.ToM3String());
			if (m3RQST.HasValue)
				request.WithQueryParameter("RQST", m3RQST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RQFD.HasValue)
				request.WithQueryParameter("RQFD", m3RQFD.Value.ToM3String());
			if (m3RQFT.HasValue)
				request.WithQueryParameter("RQFT", m3RQFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSDT.HasValue)
				request.WithQueryParameter("CSDT", m3CSDT.Value.ToM3String());
			if (m3CSTM.HasValue)
				request.WithQueryParameter("CSTM", m3CSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFDA.HasValue)
				request.WithQueryParameter("CFDA", m3CFDA.Value.ToM3String());
			if (m3CFTM.HasValue)
				request.WithQueryParameter("CFTM", m3CFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CBDT.HasValue)
				request.WithQueryParameter("CBDT", m3CBDT.Value.ToM3String());
			if (m3CBTM.HasValue)
				request.WithQueryParameter("CBTM", m3CBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (m3OSDT.HasValue)
				request.WithQueryParameter("OSDT", m3OSDT.Value.ToM3String());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (m3DMDT.HasValue)
				request.WithQueryParameter("DMDT", m3DMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (m3AICD.HasValue)
				request.WithQueryParameter("AICD", m3AICD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXCD))
				request.WithQueryParameter("EXCD", m3EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLRM))
				request.WithQueryParameter("DLRM", m3DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3LHCD))
				request.WithQueryParameter("LHCD", m3LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3SO40.HasValue)
				request.WithQueryParameter("SO40", m3SO40.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RONO))
				request.WithQueryParameter("RONO", m3RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHSY))
				request.WithQueryParameter("CHSY", m3CHSY.Trim());
			if (m3TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3TXAP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3REBE))
				request.WithQueryParameter("REBE", m3REBE.Trim());
			if (!string.IsNullOrWhiteSpace(m3OIVR))
				request.WithQueryParameter("OIVR", m3OIVR.Trim());
			if (m3OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3OYEA.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddSOHeadResponse>(
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
		/// Name AddSOLine
		/// Description Add service order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3JOBN">Service order job number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3JBSX">Assignment suffix</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3LTYP">Line type</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3PLSD">Planned start date</param>
		/// <param name="m3PLST">Planned start time</param>
		/// <param name="m3PLFD">Planned finish date</param>
		/// <param name="m3PLFT">Planned finish time</param>
		/// <param name="m3STCD">Inventory accounting</param>
		/// <param name="m3UCOS">Cost price</param>
		/// <param name="m3ERCO">Error cause</param>
		/// <param name="m3MECO">Action</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3DIP1">Discount 1</param>
		/// <param name="m3DIP2">Discount 2</param>
		/// <param name="m3DIP3">Discount 3</param>
		/// <param name="m3DIP4">Discount 4</param>
		/// <param name="m3DIP5">Discount 5</param>
		/// <param name="m3DIP6">Discount 6</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3DIA2">Discount amount 2</param>
		/// <param name="m3DIA3">Discount amount 3</param>
		/// <param name="m3DIA4">Discount amount 4</param>
		/// <param name="m3DIA5">Discount amount 5</param>
		/// <param name="m3DIA6">Discount amount 6</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3FCTN">Function area</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3ADTY">Internal address type</param>
		/// <param name="m3FWHL">From warehouse</param>
		/// <param name="m3DRAL">Direct allocate</param>
		/// <param name="m3FSCD">Kit control</param>
		/// <param name="m3FQCD">Fixed quantity</param>
		/// <param name="m3ERRM">Error message (1=No set sts to 11, 0=Yes)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddSOLineResponse></returns>
		/// <exception cref="M3Exception<AddSOLineResponse>"></exception>
		public async Task<M3Response<AddSOLineResponse>> AddSOLine(
			string m3ORNO, 
			int m3JOBN, 
			string m3ITNO, 
			decimal m3ORQT, 
			int? m3CONO = null, 
			int? m3JBSX = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3TECH = null, 
			string m3PYNO = null, 
			string m3LTYP = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3SERI = null, 
			string m3ITDS = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			DateTime? m3PLSD = null, 
			int? m3PLST = null, 
			DateTime? m3PLFD = null, 
			int? m3PLFT = null, 
			int? m3STCD = null, 
			decimal? m3UCOS = null, 
			string m3ERCO = null, 
			string m3MECO = null, 
			string m3CTNO = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3DISY = null, 
			int? m3DIP1 = null, 
			int? m3DIP2 = null, 
			int? m3DIP3 = null, 
			int? m3DIP4 = null, 
			int? m3DIP5 = null, 
			int? m3DIP6 = null, 
			decimal? m3DIA1 = null, 
			decimal? m3DIA2 = null, 
			decimal? m3DIA3 = null, 
			decimal? m3DIA4 = null, 
			decimal? m3DIA5 = null, 
			decimal? m3DIA6 = null, 
			string m3SUNO = null, 
			string m3FCTN = null, 
			string m3DBCO = null, 
			int? m3ADTY = null, 
			string m3FWHL = null, 
			int? m3DRAL = null, 
			int? m3FSCD = null, 
			int? m3FQCD = null, 
			int? m3ERRM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ORQT", m3ORQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3JBSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3LTYP))
				request.WithQueryParameter("LTYP", m3LTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3PLSD.Value.ToM3String());
			if (m3PLST.HasValue)
				request.WithQueryParameter("PLST", m3PLST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3PLFD.Value.ToM3String());
			if (m3PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3PLFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STCD.HasValue)
				request.WithQueryParameter("STCD", m3STCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3UCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ERCO))
				request.WithQueryParameter("ERCO", m3ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MECO))
				request.WithQueryParameter("MECO", m3MECO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCTN))
				request.WithQueryParameter("FCTN", m3FCTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (m3ADTY.HasValue)
				request.WithQueryParameter("ADTY", m3ADTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (m3DRAL.HasValue)
				request.WithQueryParameter("DRAL", m3DRAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSCD.HasValue)
				request.WithQueryParameter("FSCD", m3FSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FQCD.HasValue)
				request.WithQueryParameter("FQCD", m3FQCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ERRM.HasValue)
				request.WithQueryParameter("ERRM", m3ERRM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddSOLineResponse>(
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
		/// Name AddServBatchAdr
		/// Description Add service batch order address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUA1">Customer address 1</param>
		/// <param name="m3CUA2">Customer address 2</param>
		/// <param name="m3CUA3">Customer address 3</param>
		/// <param name="m3CUA4">Customer address 4</param>
		/// <param name="m3CUA5">Customer address 5</param>
		/// <param name="m3CUA6">Customer address 6</param>
		/// <param name="m3CUA7">Customer address 7</param>
		/// <param name="m3CUA8">Customer address 8</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3MEAL">Valid media</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3TAXC">Tax code</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddServBatchAdr(
			string m3ORNO, 
			int? m3CONO = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3CUA5 = null, 
			string m3CUA6 = null, 
			string m3CUA7 = null, 
			string m3CUA8 = null, 
			string m3PONO = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3MEAL = null, 
			long? m3GEOC = null, 
			string m3TAXC = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3TOWN = null, 
			string m3FRCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddServBatchAdr",
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
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3CUA5))
				request.WithQueryParameter("CUA5", m3CUA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA6))
				request.WithQueryParameter("CUA6", m3CUA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA7))
				request.WithQueryParameter("CUA7", m3CUA7.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA8))
				request.WithQueryParameter("CUA8", m3CUA8.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEAL))
				request.WithQueryParameter("MEAL", m3MEAL.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());

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
		/// Name AddServBatchLin
		/// Description Add service batch order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3JOBN">Service order job number (Required)</param>
		/// <param name="m3JBSX">Assignment suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3LTYP">Line type</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3PLSD">Planned start date</param>
		/// <param name="m3PLST">Planned start time</param>
		/// <param name="m3PLFD">Planned finish date</param>
		/// <param name="m3PLFT">Planned finish time</param>
		/// <param name="m3STCD">Inventory accounting</param>
		/// <param name="m3UCOS">Cost price</param>
		/// <param name="m3ERCO">Error cause</param>
		/// <param name="m3MECO">Action</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3DIP1">Discount 1</param>
		/// <param name="m3DIP2">Discount 2</param>
		/// <param name="m3DIP3">Discount 3</param>
		/// <param name="m3DIP4">Discount 4</param>
		/// <param name="m3DIP5">Discount 5</param>
		/// <param name="m3DIP6">Discount 6</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3DIA2">Discount amount 2</param>
		/// <param name="m3DIA3">Discount amount 3</param>
		/// <param name="m3DIA4">Discount amount 4</param>
		/// <param name="m3DIA5">Discount amount 5</param>
		/// <param name="m3DIA6">Discount amount 6</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3FCTN">Function area</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3ADTY">Internal address type</param>
		/// <param name="m3FWHL">From warehouse</param>
		/// <param name="m3FSCD">Kit control</param>
		/// <param name="m3FQCD">Fixed quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddServBatchLinResponse></returns>
		/// <exception cref="M3Exception<AddServBatchLinResponse>"></exception>
		public async Task<M3Response<AddServBatchLinResponse>> AddServBatchLin(
			string m3ORNO, 
			int m3JOBN, 
			int m3JBSX, 
			int? m3CONO = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3TECH = null, 
			string m3PYNO = null, 
			string m3LTYP = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3ITNO = null, 
			string m3SERI = null, 
			string m3ITDS = null, 
			decimal? m3ORQT = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			DateTime? m3PLSD = null, 
			int? m3PLST = null, 
			DateTime? m3PLFD = null, 
			int? m3PLFT = null, 
			int? m3STCD = null, 
			decimal? m3UCOS = null, 
			string m3ERCO = null, 
			string m3MECO = null, 
			string m3CTNO = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3DISY = null, 
			int? m3DIP1 = null, 
			int? m3DIP2 = null, 
			int? m3DIP3 = null, 
			int? m3DIP4 = null, 
			int? m3DIP5 = null, 
			int? m3DIP6 = null, 
			decimal? m3DIA1 = null, 
			decimal? m3DIA2 = null, 
			decimal? m3DIA3 = null, 
			decimal? m3DIA4 = null, 
			decimal? m3DIA5 = null, 
			decimal? m3DIA6 = null, 
			string m3SUNO = null, 
			string m3FCTN = null, 
			string m3DBCO = null, 
			int? m3ADTY = null, 
			string m3FWHL = null, 
			int? m3FSCD = null, 
			int? m3FQCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddServBatchLin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBSX", m3JBSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3LTYP))
				request.WithQueryParameter("LTYP", m3LTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3PLSD.Value.ToM3String());
			if (m3PLST.HasValue)
				request.WithQueryParameter("PLST", m3PLST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3PLFD.Value.ToM3String());
			if (m3PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3PLFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STCD.HasValue)
				request.WithQueryParameter("STCD", m3STCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3UCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ERCO))
				request.WithQueryParameter("ERCO", m3ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MECO))
				request.WithQueryParameter("MECO", m3MECO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCTN))
				request.WithQueryParameter("FCTN", m3FCTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (m3ADTY.HasValue)
				request.WithQueryParameter("ADTY", m3ADTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (m3FSCD.HasValue)
				request.WithQueryParameter("FSCD", m3FSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FQCD.HasValue)
				request.WithQueryParameter("FQCD", m3FQCD.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddServBatchLinResponse>(
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
		/// Name AddServBatchTxt
		/// Description Add service batch order text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Temp Service order number (Required)</param>
		/// <param name="m3TYPE">Text for Head, Assignment, Line (Required)</param>
		/// <param name="m3TYTR">Type of text (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3JOBN">Service order job number</param>
		/// <param name="m3JBSX">Assignment suffix</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TXEI">External/internal text</param>
		/// <param name="m3TXHE">Document class</param>
		/// <param name="m3TEXT">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddServBatchTxt(
			string m3ORNO, 
			string m3TYPE, 
			string m3TYTR, 
			int? m3CONO = null, 
			int? m3JOBN = null, 
			int? m3JBSX = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			decimal? m3TXID = null, 
			string m3TXVR = null, 
			string m3LNCD = null, 
			int? m3TXEI = null, 
			string m3TXHE = null, 
			string m3TEXT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddServBatchTxt",
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
			if (m3JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3JOBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3JBSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3TXEI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXHE))
				request.WithQueryParameter("TXHE", m3TXHE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEXT))
				request.WithQueryParameter("TEXT", m3TEXT.Trim());

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
		/// Name ChgFixedPrAssig
		/// Description Change fixed price assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3JOBN">Service order job number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3JBSX">Assignment suffix</param>
		/// <param name="m3TOPR">Total price</param>
		/// <param name="m3TOPL">Price labor done</param>
		/// <param name="m3TOPP">Price for all parts</param>
		/// <param name="m3SCO1">Service expence cat</param>
		/// <param name="m3SCO2">Service expence cat</param>
		/// <param name="m3SCO3">Service expence cat</param>
		/// <param name="m3SCO4">Service expence cat</param>
		/// <param name="m3SCO5">Service expence cat</param>
		/// <param name="m3SCO6">Service expence cat</param>
		/// <param name="m3SCO7">Service expence cat</param>
		/// <param name="m3SCO8">Service expence cat</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgFixedPrAssigResponse></returns>
		/// <exception cref="M3Exception<ChgFixedPrAssigResponse>"></exception>
		public async Task<M3Response<ChgFixedPrAssigResponse>> ChgFixedPrAssig(
			string m3ORNO, 
			int m3JOBN, 
			int? m3CONO = null, 
			int? m3JBSX = null, 
			decimal? m3TOPR = null, 
			decimal? m3TOPL = null, 
			decimal? m3TOPP = null, 
			int? m3SCO1 = null, 
			int? m3SCO2 = null, 
			int? m3SCO3 = null, 
			int? m3SCO4 = null, 
			int? m3SCO5 = null, 
			int? m3SCO6 = null, 
			int? m3SCO7 = null, 
			int? m3SCO8 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgFixedPrAssig",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3JBSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPR.HasValue)
				request.WithQueryParameter("TOPR", m3TOPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPL.HasValue)
				request.WithQueryParameter("TOPL", m3TOPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPP.HasValue)
				request.WithQueryParameter("TOPP", m3TOPP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCO1.HasValue)
				request.WithQueryParameter("SCO1", m3SCO1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCO2.HasValue)
				request.WithQueryParameter("SCO2", m3SCO2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCO3.HasValue)
				request.WithQueryParameter("SCO3", m3SCO3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCO4.HasValue)
				request.WithQueryParameter("SCO4", m3SCO4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCO5.HasValue)
				request.WithQueryParameter("SCO5", m3SCO5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCO6.HasValue)
				request.WithQueryParameter("SCO6", m3SCO6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCO7.HasValue)
				request.WithQueryParameter("SCO7", m3SCO7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCO8.HasValue)
				request.WithQueryParameter("SCO8", m3SCO8.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ChgFixedPrAssigResponse>(
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
		/// Name ChgSOAssignm
		/// Description Change service order assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3JOBN">Service order job number</param>
		/// <param name="m3JBSX">Assignment suffix</param>
		/// <param name="m3INNO">Individual item number</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3MODE">Model description</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3PMDT">Error reporting date</param>
		/// <param name="m3PMTM">Error report time</param>
		/// <param name="m3RQSD">Required start date</param>
		/// <param name="m3RQST">Required start time</param>
		/// <param name="m3RQFD">Required finish date</param>
		/// <param name="m3RQFT">Required finish time</param>
		/// <param name="m3CSDT">Confirmed start date</param>
		/// <param name="m3CSTM">Confirmed start time</param>
		/// <param name="m3CFDA">Confirmed finish date</param>
		/// <param name="m3CFTM">Confirmed finish time</param>
		/// <param name="m3SSDT">Last start date</param>
		/// <param name="m3SSTM">Last start time</param>
		/// <param name="m3RSDJ">Actual start date - assignment</param>
		/// <param name="m3RSTJ">Actual start time - assignment</param>
		/// <param name="m3RFDJ">Actual finish date - assignment</param>
		/// <param name="m3RFTJ">Actual finish time - assignment</param>
		/// <param name="m3RSDW">Actual start date - task</param>
		/// <param name="m3RSTW">Actual start time - task</param>
		/// <param name="m3RFDW">Actual finish date - task</param>
		/// <param name="m3RFTW">Actual finish time - task</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3ESCO">Error symptom</param>
		/// <param name="m3ETX1">Error symptom text</param>
		/// <param name="m3ETX2">Error symptom text</param>
		/// <param name="m3ETX3">Error symptom text</param>
		/// <param name="m3ETX4">Error symptom text</param>
		/// <param name="m3ERCO">Error cause</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3SVID">Service expense</param>
		/// <param name="m3WOTM">Forecast work hours</param>
		/// <param name="m3PRTM">Planned preparation time</param>
		/// <param name="m3FITM">Planned completion time</param>
		/// <param name="m3TRTI">Planned travel time</param>
		/// <param name="m3PSDW">Planned start date - task</param>
		/// <param name="m3PSTW">Planned start time - task</param>
		/// <param name="m3PFDW">Planned finish date - task</param>
		/// <param name="m3PFTW">Planned finish time - task</param>
		/// <param name="m3PSDJ">Planned start date - assignment</param>
		/// <param name="m3PSTJ">Planned start time - assignment</param>
		/// <param name="m3PFDJ">Planned finish date - assignment</param>
		/// <param name="m3PFTJ">Planned finish time - assignment</param>
		/// <param name="m3MTCO">Action text</param>
		/// <param name="m3MTX1">Text</param>
		/// <param name="m3MTX2">Text</param>
		/// <param name="m3MTX3">Text</param>
		/// <param name="m3MTX4">Text</param>
		/// <param name="m3MECO">Action</param>
		/// <param name="m3OPRI">Priority</param>
		/// <param name="m3JDCD">Joint delivery</param>
		/// <param name="m3JBST">Status service assignment</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3ASST">Assignment type</param>
		/// <param name="m3FCTN">Function area</param>
		/// <param name="m3TRIN">Transportation of individual item</param>
		/// <param name="m3QUNO">Qualification</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3RDTE">Received date</param>
		/// <param name="m3RTIM">Received time</param>
		/// <param name="m3ADEQ">Additional equipment</param>
		/// <param name="m3CNDI">Individual item condition</param>
		/// <param name="m3JBSE">Additional status</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3ABLC">Allocation block code</param>
		/// <param name="m3ATQC">Authority required</param>
		/// <param name="m3PLME">Sent to remote server</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgSOAssignmResponse></returns>
		/// <exception cref="M3Exception<ChgSOAssignmResponse>"></exception>
		public async Task<M3Response<ChgSOAssignmResponse>> ChgSOAssignm(
			string m3ORNO, 
			int? m3CONO = null, 
			int? m3JOBN = null, 
			int? m3JBSX = null, 
			string m3INNO = null, 
			string m3SERI = null, 
			string m3MODE = null, 
			string m3ITNO = null, 
			string m3TECH = null, 
			string m3SRES = null, 
			DateTime? m3PMDT = null, 
			int? m3PMTM = null, 
			DateTime? m3RQSD = null, 
			int? m3RQST = null, 
			DateTime? m3RQFD = null, 
			int? m3RQFT = null, 
			DateTime? m3CSDT = null, 
			int? m3CSTM = null, 
			DateTime? m3CFDA = null, 
			int? m3CFTM = null, 
			DateTime? m3SSDT = null, 
			int? m3SSTM = null, 
			DateTime? m3RSDJ = null, 
			int? m3RSTJ = null, 
			DateTime? m3RFDJ = null, 
			int? m3RFTJ = null, 
			DateTime? m3RSDW = null, 
			int? m3RSTW = null, 
			DateTime? m3RFDW = null, 
			int? m3RFTW = null, 
			string m3CTNO = null, 
			string m3ESCO = null, 
			string m3ETX1 = null, 
			string m3ETX2 = null, 
			string m3ETX3 = null, 
			string m3ETX4 = null, 
			string m3ERCO = null, 
			string m3DBCO = null, 
			string m3SVID = null, 
			int? m3WOTM = null, 
			int? m3PRTM = null, 
			int? m3FITM = null, 
			int? m3TRTI = null, 
			DateTime? m3PSDW = null, 
			int? m3PSTW = null, 
			DateTime? m3PFDW = null, 
			int? m3PFTW = null, 
			DateTime? m3PSDJ = null, 
			int? m3PSTJ = null, 
			DateTime? m3PFDJ = null, 
			int? m3PFTJ = null, 
			string m3MTCO = null, 
			string m3MTX1 = null, 
			string m3MTX2 = null, 
			string m3MTX3 = null, 
			string m3MTX4 = null, 
			string m3MECO = null, 
			int? m3OPRI = null, 
			string m3JDCD = null, 
			string m3JBST = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3ASST = null, 
			string m3FCTN = null, 
			int? m3TRIN = null, 
			string m3QUNO = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			DateTime? m3RDTE = null, 
			int? m3RTIM = null, 
			string m3ADEQ = null, 
			string m3CNDI = null, 
			string m3JBSE = null, 
			string m3SUFI = null, 
			int? m3ABLC = null, 
			int? m3ATQC = null, 
			int? m3PLME = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgSOAssignm",
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
			if (m3JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3JOBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3JBSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODE))
				request.WithQueryParameter("MODE", m3MODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (m3PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3PMDT.Value.ToM3String());
			if (m3PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3PMTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RQSD.HasValue)
				request.WithQueryParameter("RQSD", m3RQSD.Value.ToM3String());
			if (m3RQST.HasValue)
				request.WithQueryParameter("RQST", m3RQST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RQFD.HasValue)
				request.WithQueryParameter("RQFD", m3RQFD.Value.ToM3String());
			if (m3RQFT.HasValue)
				request.WithQueryParameter("RQFT", m3RQFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSDT.HasValue)
				request.WithQueryParameter("CSDT", m3CSDT.Value.ToM3String());
			if (m3CSTM.HasValue)
				request.WithQueryParameter("CSTM", m3CSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFDA.HasValue)
				request.WithQueryParameter("CFDA", m3CFDA.Value.ToM3String());
			if (m3CFTM.HasValue)
				request.WithQueryParameter("CFTM", m3CFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSDT.HasValue)
				request.WithQueryParameter("SSDT", m3SSDT.Value.ToM3String());
			if (m3SSTM.HasValue)
				request.WithQueryParameter("SSTM", m3SSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSDJ.HasValue)
				request.WithQueryParameter("RSDJ", m3RSDJ.Value.ToM3String());
			if (m3RSTJ.HasValue)
				request.WithQueryParameter("RSTJ", m3RSTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RFDJ.HasValue)
				request.WithQueryParameter("RFDJ", m3RFDJ.Value.ToM3String());
			if (m3RFTJ.HasValue)
				request.WithQueryParameter("RFTJ", m3RFTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSDW.HasValue)
				request.WithQueryParameter("RSDW", m3RSDW.Value.ToM3String());
			if (m3RSTW.HasValue)
				request.WithQueryParameter("RSTW", m3RSTW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RFDW.HasValue)
				request.WithQueryParameter("RFDW", m3RFDW.Value.ToM3String());
			if (m3RFTW.HasValue)
				request.WithQueryParameter("RFTW", m3RFTW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ESCO))
				request.WithQueryParameter("ESCO", m3ESCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX1))
				request.WithQueryParameter("ETX1", m3ETX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX2))
				request.WithQueryParameter("ETX2", m3ETX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX3))
				request.WithQueryParameter("ETX3", m3ETX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX4))
				request.WithQueryParameter("ETX4", m3ETX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ERCO))
				request.WithQueryParameter("ERCO", m3ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SVID))
				request.WithQueryParameter("SVID", m3SVID.Trim());
			if (m3WOTM.HasValue)
				request.WithQueryParameter("WOTM", m3WOTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRTM.HasValue)
				request.WithQueryParameter("PRTM", m3PRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FITM.HasValue)
				request.WithQueryParameter("FITM", m3FITM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRTI.HasValue)
				request.WithQueryParameter("TRTI", m3TRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSDW.HasValue)
				request.WithQueryParameter("PSDW", m3PSDW.Value.ToM3String());
			if (m3PSTW.HasValue)
				request.WithQueryParameter("PSTW", m3PSTW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PFDW.HasValue)
				request.WithQueryParameter("PFDW", m3PFDW.Value.ToM3String());
			if (m3PFTW.HasValue)
				request.WithQueryParameter("PFTW", m3PFTW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSDJ.HasValue)
				request.WithQueryParameter("PSDJ", m3PSDJ.Value.ToM3String());
			if (m3PSTJ.HasValue)
				request.WithQueryParameter("PSTJ", m3PSTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PFDJ.HasValue)
				request.WithQueryParameter("PFDJ", m3PFDJ.Value.ToM3String());
			if (m3PFTJ.HasValue)
				request.WithQueryParameter("PFTJ", m3PFTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTCO))
				request.WithQueryParameter("MTCO", m3MTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX1))
				request.WithQueryParameter("MTX1", m3MTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX2))
				request.WithQueryParameter("MTX2", m3MTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX3))
				request.WithQueryParameter("MTX3", m3MTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX4))
				request.WithQueryParameter("MTX4", m3MTX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3MECO))
				request.WithQueryParameter("MECO", m3MECO.Trim());
			if (m3OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3OPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3JDCD))
				request.WithQueryParameter("JDCD", m3JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3JBST))
				request.WithQueryParameter("JBST", m3JBST.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASST))
				request.WithQueryParameter("ASST", m3ASST.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCTN))
				request.WithQueryParameter("FCTN", m3FCTN.Trim());
			if (m3TRIN.HasValue)
				request.WithQueryParameter("TRIN", m3TRIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QUNO))
				request.WithQueryParameter("QUNO", m3QUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3RDTE.HasValue)
				request.WithQueryParameter("RDTE", m3RDTE.Value.ToM3String());
			if (m3RTIM.HasValue)
				request.WithQueryParameter("RTIM", m3RTIM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADEQ))
				request.WithQueryParameter("ADEQ", m3ADEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3CNDI))
				request.WithQueryParameter("CNDI", m3CNDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3JBSE))
				request.WithQueryParameter("JBSE", m3JBSE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3ABLC.HasValue)
				request.WithQueryParameter("ABLC", m3ABLC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATQC.HasValue)
				request.WithQueryParameter("ATQC", m3ATQC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLME.HasValue)
				request.WithQueryParameter("PLME", m3PLME.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ChgSOAssignmResponse>(
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
		/// Name ChgSOHead
		/// Description Change service order head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3PRS1">Price list SO</param>
		/// <param name="m3PMDT">Error reporting date</param>
		/// <param name="m3PMTM">Error report time</param>
		/// <param name="m3RQSD">Required start date</param>
		/// <param name="m3RQST">Required start time</param>
		/// <param name="m3RQFD">Required finish date</param>
		/// <param name="m3RQFT">Required finish time</param>
		/// <param name="m3CSDT">Confirmed start date</param>
		/// <param name="m3CSTM">Confirmed start time</param>
		/// <param name="m3CFDA">Confirmed finish date</param>
		/// <param name="m3CFTM">Confirmed finish time</param>
		/// <param name="m3CBDT">Contact customer date</param>
		/// <param name="m3CBTM">Contact customer time</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3OSDT">Order entry date</param>
		/// <param name="m3CUDT">Customer´s purchase order date</param>
		/// <param name="m3DMDT">Manual due date</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3EXCD">Service charge</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3DLRM">Remark</param>
		/// <param name="m3LHCD">Language code order head</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3SO40">FAM direct</param>
		/// <param name="m3RONO">Run</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TAXC">Tax code</param>
		/// <param name="m3CHSY">Line charge model</param>
		/// <param name="m3TXAP">Tax applicable</param>
		/// <param name="m3AICD">Summary invoice</param>
		/// <param name="m3OIVR">Original invoice reference</param>
		/// <param name="m3OYEA">Original year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgSOHeadResponse></returns>
		/// <exception cref="M3Exception<ChgSOHeadResponse>"></exception>
		public async Task<M3Response<ChgSOHeadResponse>> ChgSOHead(
			string m3ORNO, 
			int? m3CONO = null, 
			string m3TEPY = null, 
			string m3ADID = null, 
			string m3PYNO = null, 
			string m3SMCD = null, 
			string m3SRES = null, 
			string m3TECH = null, 
			string m3PRS1 = null, 
			DateTime? m3PMDT = null, 
			int? m3PMTM = null, 
			DateTime? m3RQSD = null, 
			int? m3RQST = null, 
			DateTime? m3RQFD = null, 
			int? m3RQFT = null, 
			DateTime? m3CSDT = null, 
			int? m3CSTM = null, 
			DateTime? m3CFDA = null, 
			int? m3CFTM = null, 
			DateTime? m3CBDT = null, 
			int? m3CBTM = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3TFNO = null, 
			DateTime? m3OSDT = null, 
			DateTime? m3CUDT = null, 
			DateTime? m3DMDT = null, 
			string m3OREF = null, 
			string m3YREF = null, 
			string m3EXCD = null, 
			string m3CUOR = null, 
			string m3DLRM = null, 
			string m3LHCD = null, 
			string m3OFNO = null, 
			int? m3SO40 = null, 
			string m3RONO = null, 
			string m3RORN = null, 
			int? m3RORC = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TAXC = null, 
			string m3CHSY = null, 
			int? m3TXAP = null, 
			int? m3AICD = null, 
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgSOHead",
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
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRS1))
				request.WithQueryParameter("PRS1", m3PRS1.Trim());
			if (m3PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3PMDT.Value.ToM3String());
			if (m3PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3PMTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RQSD.HasValue)
				request.WithQueryParameter("RQSD", m3RQSD.Value.ToM3String());
			if (m3RQST.HasValue)
				request.WithQueryParameter("RQST", m3RQST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RQFD.HasValue)
				request.WithQueryParameter("RQFD", m3RQFD.Value.ToM3String());
			if (m3RQFT.HasValue)
				request.WithQueryParameter("RQFT", m3RQFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSDT.HasValue)
				request.WithQueryParameter("CSDT", m3CSDT.Value.ToM3String());
			if (m3CSTM.HasValue)
				request.WithQueryParameter("CSTM", m3CSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFDA.HasValue)
				request.WithQueryParameter("CFDA", m3CFDA.Value.ToM3String());
			if (m3CFTM.HasValue)
				request.WithQueryParameter("CFTM", m3CFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CBDT.HasValue)
				request.WithQueryParameter("CBDT", m3CBDT.Value.ToM3String());
			if (m3CBTM.HasValue)
				request.WithQueryParameter("CBTM", m3CBTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (m3OSDT.HasValue)
				request.WithQueryParameter("OSDT", m3OSDT.Value.ToM3String());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (m3DMDT.HasValue)
				request.WithQueryParameter("DMDT", m3DMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXCD))
				request.WithQueryParameter("EXCD", m3EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLRM))
				request.WithQueryParameter("DLRM", m3DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3LHCD))
				request.WithQueryParameter("LHCD", m3LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3SO40.HasValue)
				request.WithQueryParameter("SO40", m3SO40.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RONO))
				request.WithQueryParameter("RONO", m3RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHSY))
				request.WithQueryParameter("CHSY", m3CHSY.Trim());
			if (m3TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3TXAP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AICD.HasValue)
				request.WithQueryParameter("AICD", m3AICD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OIVR))
				request.WithQueryParameter("OIVR", m3OIVR.Trim());
			if (m3OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3OYEA.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ChgSOHeadResponse>(
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
		/// Name ChgSOLine
		/// Description Change service order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3PLSD">Planned start date</param>
		/// <param name="m3PLST">Planned start time</param>
		/// <param name="m3PLFD">Planned finish date</param>
		/// <param name="m3PLFT">Planned finish time</param>
		/// <param name="m3UCOS">Cost price</param>
		/// <param name="m3ERCO">Error cause</param>
		/// <param name="m3MECO">Action</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3DIP1">Discount 1</param>
		/// <param name="m3DIP2">Discount 2</param>
		/// <param name="m3DIP3">Discount 3</param>
		/// <param name="m3DIP4">Discount 4</param>
		/// <param name="m3DIP5">Discount 5</param>
		/// <param name="m3DIP6">Discount 6</param>
		/// <param name="m3DIA1">Discount amount 1</param>
		/// <param name="m3DIA2">Discount amount 2</param>
		/// <param name="m3DIA3">Discount amount 3</param>
		/// <param name="m3DIA4">Discount amount 4</param>
		/// <param name="m3DIA5">Discount amount 5</param>
		/// <param name="m3DIA6">Discount amount 6</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3FCTN">Function area</param>
		/// <param name="m3RAQT">Reported quantity</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3DRAL">Direct allocate</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgSOLineResponse></returns>
		/// <exception cref="M3Exception<ChgSOLineResponse>"></exception>
		public async Task<M3Response<ChgSOLineResponse>> ChgSOLine(
			string m3ORNO, 
			int m3PONR, 
			int? m3CONO = null, 
			int? m3POSX = null, 
			string m3TECH = null, 
			string m3PYNO = null, 
			string m3SERI = null, 
			string m3ITDS = null, 
			decimal? m3ORQT = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			DateTime? m3PLSD = null, 
			int? m3PLST = null, 
			DateTime? m3PLFD = null, 
			int? m3PLFT = null, 
			decimal? m3UCOS = null, 
			string m3ERCO = null, 
			string m3MECO = null, 
			string m3CTNO = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3DISY = null, 
			int? m3DIP1 = null, 
			int? m3DIP2 = null, 
			int? m3DIP3 = null, 
			int? m3DIP4 = null, 
			int? m3DIP5 = null, 
			int? m3DIP6 = null, 
			decimal? m3DIA1 = null, 
			decimal? m3DIA2 = null, 
			decimal? m3DIA3 = null, 
			decimal? m3DIA4 = null, 
			decimal? m3DIA5 = null, 
			decimal? m3DIA6 = null, 
			string m3SUNO = null, 
			string m3FCTN = null, 
			decimal? m3RAQT = null, 
			int? m3OEND = null, 
			int? m3DRAL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgSOLine",
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
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3PLSD.Value.ToM3String());
			if (m3PLST.HasValue)
				request.WithQueryParameter("PLST", m3PLST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3PLFD.Value.ToM3String());
			if (m3PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3PLFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3UCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ERCO))
				request.WithQueryParameter("ERCO", m3ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MECO))
				request.WithQueryParameter("MECO", m3MECO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCTN))
				request.WithQueryParameter("FCTN", m3FCTN.Trim());
			if (m3RAQT.HasValue)
				request.WithQueryParameter("RAQT", m3RAQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DRAL.HasValue)
				request.WithQueryParameter("DRAL", m3DRAL.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ChgSOLineResponse>(
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
		/// Description Confirm of SO batch order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CONO">Company</param>
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
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetSOAssignm
		/// Description GetSOAssignm
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3JOBN">Assignment</param>
		/// <param name="m3JBSX">Assignment suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSOAssignmResponse></returns>
		/// <exception cref="M3Exception<GetSOAssignmResponse>"></exception>
		public async Task<M3Response<GetSOAssignmResponse>> GetSOAssignm(
			int? m3CONO = null, 
			string m3ORNO = null, 
			int? m3JOBN = null, 
			int? m3JBSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSOAssignm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3JOBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3JBSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSOAssignmResponse>(
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
		/// Name GetSOLine
		/// Description Get service order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSOLineResponse></returns>
		/// <exception cref="M3Exception<GetSOLineResponse>"></exception>
		public async Task<M3Response<GetSOLineResponse>> GetSOLine(
			string m3ORNO, 
			int m3PONR, 
			int m3POSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSOLineResponse>(
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
		/// Description List error msg on batch order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstErrMsgOrder",
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
	}
}
// EOF
