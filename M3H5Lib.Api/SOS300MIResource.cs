/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_JOBN">Service order job number</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_MODE">Model description</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_PMDT">Error reporting date</param>
		/// <param name="m3_PMTM">Error report time</param>
		/// <param name="m3_RQSD">Required start date</param>
		/// <param name="m3_RQST">Required start time</param>
		/// <param name="m3_RQFD">Required finish date</param>
		/// <param name="m3_RQFT">Required finish time</param>
		/// <param name="m3_CSDT">Confirmed start date</param>
		/// <param name="m3_CSTM">Confirmed start time</param>
		/// <param name="m3_CFDA">Confirmed finish date</param>
		/// <param name="m3_CFTM">Confirmed finish time</param>
		/// <param name="m3_SSDT">Last start date</param>
		/// <param name="m3_SSTM">Last start time</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_ESCO">Error symptom</param>
		/// <param name="m3_ETX1">Error symptom text</param>
		/// <param name="m3_ETX2">Error symptom text</param>
		/// <param name="m3_ETX3">Error symptom text</param>
		/// <param name="m3_ETX4">Error symptom text</param>
		/// <param name="m3_ERCO">Error cause</param>
		/// <param name="m3_DBCO">Payer control</param>
		/// <param name="m3_SVID">Service expense</param>
		/// <param name="m3_WOTM">Forecast work hours</param>
		/// <param name="m3_PRTM">Planned preparation time</param>
		/// <param name="m3_FITM">Planned completion time</param>
		/// <param name="m3_TRTI">Planned travel time</param>
		/// <param name="m3_PSDW">Planned start date - task</param>
		/// <param name="m3_PSTW">Planned start time - task</param>
		/// <param name="m3_PFDW">Planned finish date - task</param>
		/// <param name="m3_PFTW">Planned finish time - task</param>
		/// <param name="m3_PSDJ">Planned start date - assignment</param>
		/// <param name="m3_PSTJ">Planned start time - assignment</param>
		/// <param name="m3_PFDJ">Planned finish date - assignment</param>
		/// <param name="m3_PFTJ">Planned finish time - assignment</param>
		/// <param name="m3_MTCO">Action text</param>
		/// <param name="m3_MTX1">Text</param>
		/// <param name="m3_MTX2">Text</param>
		/// <param name="m3_MTX3">Text</param>
		/// <param name="m3_MTX4">Text</param>
		/// <param name="m3_MECO">Action</param>
		/// <param name="m3_OPRI">Priority</param>
		/// <param name="m3_JBST">Status service assignment</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_ASST">Assignment type</param>
		/// <param name="m3_FCTN">Function area</param>
		/// <param name="m3_TRIN">Transportation of individual item</param>
		/// <param name="m3_QUNO">Qualification</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_RDTE">Received date</param>
		/// <param name="m3_RTIM">Received time</param>
		/// <param name="m3_CNDI">Individual item condition</param>
		/// <param name="m3_JBSE">Additional status</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_ROLE">Role/organizational position</param>
		/// <param name="m3_ABLC">Allocation block code</param>
		/// <param name="m3_PLME">Sent to remote server</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchAssignmResponse></returns>
		/// <exception cref="M3Exception<AddBatchAssignmResponse>"></exception>
		public async Task<M3Response<AddBatchAssignmResponse>> AddBatchAssignm(
			string m3_ORNO, 
			int? m3_CONO = null, 
			int? m3_JOBN = null, 
			int? m3_JBSX = null, 
			string m3_INNO = null, 
			string m3_SERI = null, 
			string m3_MODE = null, 
			string m3_ITNO = null, 
			string m3_TECH = null, 
			string m3_SRES = null, 
			DateTime? m3_PMDT = null, 
			int? m3_PMTM = null, 
			DateTime? m3_RQSD = null, 
			int? m3_RQST = null, 
			DateTime? m3_RQFD = null, 
			int? m3_RQFT = null, 
			DateTime? m3_CSDT = null, 
			int? m3_CSTM = null, 
			DateTime? m3_CFDA = null, 
			int? m3_CFTM = null, 
			DateTime? m3_SSDT = null, 
			int? m3_SSTM = null, 
			string m3_CTNO = null, 
			string m3_ESCO = null, 
			string m3_ETX1 = null, 
			string m3_ETX2 = null, 
			string m3_ETX3 = null, 
			string m3_ETX4 = null, 
			string m3_ERCO = null, 
			string m3_DBCO = null, 
			string m3_SVID = null, 
			int? m3_WOTM = null, 
			int? m3_PRTM = null, 
			int? m3_FITM = null, 
			int? m3_TRTI = null, 
			DateTime? m3_PSDW = null, 
			int? m3_PSTW = null, 
			DateTime? m3_PFDW = null, 
			int? m3_PFTW = null, 
			DateTime? m3_PSDJ = null, 
			int? m3_PSTJ = null, 
			DateTime? m3_PFDJ = null, 
			int? m3_PFTJ = null, 
			string m3_MTCO = null, 
			string m3_MTX1 = null, 
			string m3_MTX2 = null, 
			string m3_MTX3 = null, 
			string m3_MTX4 = null, 
			string m3_MECO = null, 
			int? m3_OPRI = null, 
			string m3_JBST = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_ASST = null, 
			string m3_FCTN = null, 
			int? m3_TRIN = null, 
			string m3_QUNO = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			DateTime? m3_RDTE = null, 
			int? m3_RTIM = null, 
			string m3_CNDI = null, 
			string m3_JBSE = null, 
			string m3_SUFI = null, 
			string m3_ROLE = null, 
			int? m3_ABLC = null, 
			int? m3_PLME = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3_JOBN.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODE))
				request.WithQueryParameter("MODE", m3_MODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (m3_PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3_PMDT.Value.ToM3String());
			if (m3_PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3_PMTM.Value.ToString());
			if (m3_RQSD.HasValue)
				request.WithQueryParameter("RQSD", m3_RQSD.Value.ToM3String());
			if (m3_RQST.HasValue)
				request.WithQueryParameter("RQST", m3_RQST.Value.ToString());
			if (m3_RQFD.HasValue)
				request.WithQueryParameter("RQFD", m3_RQFD.Value.ToM3String());
			if (m3_RQFT.HasValue)
				request.WithQueryParameter("RQFT", m3_RQFT.Value.ToString());
			if (m3_CSDT.HasValue)
				request.WithQueryParameter("CSDT", m3_CSDT.Value.ToM3String());
			if (m3_CSTM.HasValue)
				request.WithQueryParameter("CSTM", m3_CSTM.Value.ToString());
			if (m3_CFDA.HasValue)
				request.WithQueryParameter("CFDA", m3_CFDA.Value.ToM3String());
			if (m3_CFTM.HasValue)
				request.WithQueryParameter("CFTM", m3_CFTM.Value.ToString());
			if (m3_SSDT.HasValue)
				request.WithQueryParameter("SSDT", m3_SSDT.Value.ToM3String());
			if (m3_SSTM.HasValue)
				request.WithQueryParameter("SSTM", m3_SSTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ESCO))
				request.WithQueryParameter("ESCO", m3_ESCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX1))
				request.WithQueryParameter("ETX1", m3_ETX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX2))
				request.WithQueryParameter("ETX2", m3_ETX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX3))
				request.WithQueryParameter("ETX3", m3_ETX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX4))
				request.WithQueryParameter("ETX4", m3_ETX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ERCO))
				request.WithQueryParameter("ERCO", m3_ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DBCO))
				request.WithQueryParameter("DBCO", m3_DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SVID))
				request.WithQueryParameter("SVID", m3_SVID.Trim());
			if (m3_WOTM.HasValue)
				request.WithQueryParameter("WOTM", m3_WOTM.Value.ToString());
			if (m3_PRTM.HasValue)
				request.WithQueryParameter("PRTM", m3_PRTM.Value.ToString());
			if (m3_FITM.HasValue)
				request.WithQueryParameter("FITM", m3_FITM.Value.ToString());
			if (m3_TRTI.HasValue)
				request.WithQueryParameter("TRTI", m3_TRTI.Value.ToString());
			if (m3_PSDW.HasValue)
				request.WithQueryParameter("PSDW", m3_PSDW.Value.ToM3String());
			if (m3_PSTW.HasValue)
				request.WithQueryParameter("PSTW", m3_PSTW.Value.ToString());
			if (m3_PFDW.HasValue)
				request.WithQueryParameter("PFDW", m3_PFDW.Value.ToM3String());
			if (m3_PFTW.HasValue)
				request.WithQueryParameter("PFTW", m3_PFTW.Value.ToString());
			if (m3_PSDJ.HasValue)
				request.WithQueryParameter("PSDJ", m3_PSDJ.Value.ToM3String());
			if (m3_PSTJ.HasValue)
				request.WithQueryParameter("PSTJ", m3_PSTJ.Value.ToString());
			if (m3_PFDJ.HasValue)
				request.WithQueryParameter("PFDJ", m3_PFDJ.Value.ToM3String());
			if (m3_PFTJ.HasValue)
				request.WithQueryParameter("PFTJ", m3_PFTJ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTCO))
				request.WithQueryParameter("MTCO", m3_MTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX1))
				request.WithQueryParameter("MTX1", m3_MTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX2))
				request.WithQueryParameter("MTX2", m3_MTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX3))
				request.WithQueryParameter("MTX3", m3_MTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX4))
				request.WithQueryParameter("MTX4", m3_MTX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MECO))
				request.WithQueryParameter("MECO", m3_MECO.Trim());
			if (m3_OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3_OPRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_JBST))
				request.WithQueryParameter("JBST", m3_JBST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASST))
				request.WithQueryParameter("ASST", m3_ASST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCTN))
				request.WithQueryParameter("FCTN", m3_FCTN.Trim());
			if (m3_TRIN.HasValue)
				request.WithQueryParameter("TRIN", m3_TRIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QUNO))
				request.WithQueryParameter("QUNO", m3_QUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_RDTE.HasValue)
				request.WithQueryParameter("RDTE", m3_RDTE.Value.ToM3String());
			if (m3_RTIM.HasValue)
				request.WithQueryParameter("RTIM", m3_RTIM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CNDI))
				request.WithQueryParameter("CNDI", m3_CNDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JBSE))
				request.WithQueryParameter("JBSE", m3_JBSE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROLE))
				request.WithQueryParameter("ROLE", m3_ROLE.Trim());
			if (m3_ABLC.HasValue)
				request.WithQueryParameter("ABLC", m3_ABLC.Value.ToString());
			if (m3_PLME.HasValue)
				request.WithQueryParameter("PLME", m3_PLME.Value.ToString());

			// Execute the request
			var result = await Execute<AddBatchAssignmResponse>(
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
		/// Description Add service batch order head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_SOTP">Service order type</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_PRS1">Price list SO</param>
		/// <param name="m3_PMDT">Error reporting date</param>
		/// <param name="m3_PMTM">Error report time</param>
		/// <param name="m3_RQSD">Required start date</param>
		/// <param name="m3_RQST">Required start time</param>
		/// <param name="m3_RQFD">Required finish date</param>
		/// <param name="m3_RQFT">Required finish time</param>
		/// <param name="m3_CSDT">Confirmed start date</param>
		/// <param name="m3_CSTM">Confirmed start time</param>
		/// <param name="m3_CFDA">Confirmed finish date</param>
		/// <param name="m3_CFTM">Confirmed finish time</param>
		/// <param name="m3_CBDT">Contact customer date</param>
		/// <param name="m3_CBTM">Contact customer time</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_OSDT">Order entry date</param>
		/// <param name="m3_CUDT">Customer´s purchase order date</param>
		/// <param name="m3_DMDT">Manual due date</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_AICD">Summary invoice</param>
		/// <param name="m3_EXCD">Service charge</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_DLRM">Remark</param>
		/// <param name="m3_LHCD">Language code order head</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_SO40">FAM direct</param>
		/// <param name="m3_RONO">Run</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TAXC">Tax code</param>
		/// <param name="m3_CHSY">Line charge model</param>
		/// <param name="m3_TXAP">Tax applicable</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="m3_REBE">Registration number</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_MORN">Mobile service order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchHeadResponse></returns>
		/// <exception cref="M3Exception<AddBatchHeadResponse>"></exception>
		public async Task<M3Response<AddBatchHeadResponse>> AddBatchHead(
			int? m3_CONO = null, 
			string m3_ORNO = null, 
			string m3_CUNO = null, 
			string m3_SOTP = null, 
			string m3_TEPY = null, 
			string m3_ADID = null, 
			string m3_PYNO = null, 
			string m3_CUCD = null, 
			string m3_SMCD = null, 
			string m3_SRES = null, 
			string m3_TECH = null, 
			string m3_PRS1 = null, 
			DateTime? m3_PMDT = null, 
			int? m3_PMTM = null, 
			DateTime? m3_RQSD = null, 
			int? m3_RQST = null, 
			DateTime? m3_RQFD = null, 
			int? m3_RQFT = null, 
			DateTime? m3_CSDT = null, 
			int? m3_CSTM = null, 
			DateTime? m3_CFDA = null, 
			int? m3_CFTM = null, 
			DateTime? m3_CBDT = null, 
			int? m3_CBTM = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_TFNO = null, 
			DateTime? m3_OSDT = null, 
			DateTime? m3_CUDT = null, 
			DateTime? m3_DMDT = null, 
			string m3_OREF = null, 
			string m3_YREF = null, 
			int? m3_AICD = null, 
			string m3_EXCD = null, 
			string m3_CUOR = null, 
			string m3_DLRM = null, 
			string m3_LHCD = null, 
			string m3_OFNO = null, 
			int? m3_SO40 = null, 
			string m3_RONO = null, 
			string m3_RORN = null, 
			int? m3_RORC = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_FACI = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TAXC = null, 
			string m3_CHSY = null, 
			int? m3_TXAP = null, 
			string m3_INNO = null, 
			string m3_REBE = null, 
			int? m3_CRTP = null, 
			string m3_MORN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SOTP))
				request.WithQueryParameter("SOTP", m3_SOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRS1))
				request.WithQueryParameter("PRS1", m3_PRS1.Trim());
			if (m3_PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3_PMDT.Value.ToM3String());
			if (m3_PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3_PMTM.Value.ToString());
			if (m3_RQSD.HasValue)
				request.WithQueryParameter("RQSD", m3_RQSD.Value.ToM3String());
			if (m3_RQST.HasValue)
				request.WithQueryParameter("RQST", m3_RQST.Value.ToString());
			if (m3_RQFD.HasValue)
				request.WithQueryParameter("RQFD", m3_RQFD.Value.ToM3String());
			if (m3_RQFT.HasValue)
				request.WithQueryParameter("RQFT", m3_RQFT.Value.ToString());
			if (m3_CSDT.HasValue)
				request.WithQueryParameter("CSDT", m3_CSDT.Value.ToM3String());
			if (m3_CSTM.HasValue)
				request.WithQueryParameter("CSTM", m3_CSTM.Value.ToString());
			if (m3_CFDA.HasValue)
				request.WithQueryParameter("CFDA", m3_CFDA.Value.ToM3String());
			if (m3_CFTM.HasValue)
				request.WithQueryParameter("CFTM", m3_CFTM.Value.ToString());
			if (m3_CBDT.HasValue)
				request.WithQueryParameter("CBDT", m3_CBDT.Value.ToM3String());
			if (m3_CBTM.HasValue)
				request.WithQueryParameter("CBTM", m3_CBTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (m3_OSDT.HasValue)
				request.WithQueryParameter("OSDT", m3_OSDT.Value.ToM3String());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (m3_DMDT.HasValue)
				request.WithQueryParameter("DMDT", m3_DMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (m3_AICD.HasValue)
				request.WithQueryParameter("AICD", m3_AICD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXCD))
				request.WithQueryParameter("EXCD", m3_EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLRM))
				request.WithQueryParameter("DLRM", m3_DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LHCD))
				request.WithQueryParameter("LHCD", m3_LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_SO40.HasValue)
				request.WithQueryParameter("SO40", m3_SO40.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RONO))
				request.WithQueryParameter("RONO", m3_RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHSY))
				request.WithQueryParameter("CHSY", m3_CHSY.Trim());
			if (m3_TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3_TXAP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REBE))
				request.WithQueryParameter("REBE", m3_REBE.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MORN))
				request.WithQueryParameter("MORN", m3_MORN.Trim());

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
		/// Name AddSOAssignm
		/// Description Add service order assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_INNO">Individual item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_JOBN">Service order job number</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_MODE">Model description</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_PMDT">Error reporting date</param>
		/// <param name="m3_PMTM">Error report time</param>
		/// <param name="m3_RQSD">Required start date</param>
		/// <param name="m3_RQST">Required start time</param>
		/// <param name="m3_RQFD">Required finish date</param>
		/// <param name="m3_RQFT">Required finish time</param>
		/// <param name="m3_CSDT">Confirmed start date</param>
		/// <param name="m3_CSTM">Confirmed start time</param>
		/// <param name="m3_CFDA">Confirmed finish date</param>
		/// <param name="m3_CFTM">Confirmed finish time</param>
		/// <param name="m3_SSDT">Last start date</param>
		/// <param name="m3_SSTM">Last start time</param>
		/// <param name="m3_RSDJ">Actual start date - assignment</param>
		/// <param name="m3_RSTJ">Actual start time - assignment</param>
		/// <param name="m3_RFDJ">Actual finish date - assignment</param>
		/// <param name="m3_RFTJ">Actual finish time - assignment</param>
		/// <param name="m3_RSDW">Actual start date - task</param>
		/// <param name="m3_RSTW">Actual start time - task</param>
		/// <param name="m3_RFDW">Actual finish date - task</param>
		/// <param name="m3_RFTW">Actual finish time - task</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_ESCO">Error symptom</param>
		/// <param name="m3_ETX1">Error symptom text</param>
		/// <param name="m3_ETX2">Error symptom text</param>
		/// <param name="m3_ETX3">Error symptom text</param>
		/// <param name="m3_ETX4">Error symptom text</param>
		/// <param name="m3_ERCO">Error cause</param>
		/// <param name="m3_DBCO">Payer control</param>
		/// <param name="m3_SVID">Service expense</param>
		/// <param name="m3_WOTM">Forecast work hours</param>
		/// <param name="m3_PRTM">Planned preparation time</param>
		/// <param name="m3_FITM">Planned completion time</param>
		/// <param name="m3_TRTI">Planned travel time</param>
		/// <param name="m3_PSDW">Planned start date - task</param>
		/// <param name="m3_PSTW">Planned start time - task</param>
		/// <param name="m3_PFDW">Planned finish date - task</param>
		/// <param name="m3_PFTW">Planned finish time - task</param>
		/// <param name="m3_PSDJ">Planned start date - assignment</param>
		/// <param name="m3_PSTJ">Planned start time - assignment</param>
		/// <param name="m3_PFDJ">Planned finish date - assignment</param>
		/// <param name="m3_PFTJ">Planned finish time - assignment</param>
		/// <param name="m3_MTCO">Action text</param>
		/// <param name="m3_MTX1">Text</param>
		/// <param name="m3_MTX2">Text</param>
		/// <param name="m3_MTX3">Text</param>
		/// <param name="m3_MTX4">Text</param>
		/// <param name="m3_MECO">Action</param>
		/// <param name="m3_OPRI">Priority</param>
		/// <param name="m3_JDCD">Joint delivery</param>
		/// <param name="m3_JBST">Status service assignment</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_ASST">Assignment type</param>
		/// <param name="m3_FCTN">Function area</param>
		/// <param name="m3_TRIN">Transportation of individual item</param>
		/// <param name="m3_QUNO">Qualification</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_RDTE">Received date</param>
		/// <param name="m3_RTIM">Received time</param>
		/// <param name="m3_ADEQ">Additional equipment</param>
		/// <param name="m3_CNDI">Individual item condition</param>
		/// <param name="m3_JBSE">Additional status</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_ABLC">Allocation block code</param>
		/// <param name="m3_ATQC">Authority required</param>
		/// <param name="m3_PLME">Sent to remote server</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddSOAssignmResponse></returns>
		/// <exception cref="M3Exception<AddSOAssignmResponse>"></exception>
		public async Task<M3Response<AddSOAssignmResponse>> AddSOAssignm(
			string m3_ORNO, 
			string m3_INNO, 
			int? m3_CONO = null, 
			int? m3_JOBN = null, 
			int? m3_JBSX = null, 
			string m3_SERI = null, 
			string m3_MODE = null, 
			string m3_ITNO = null, 
			string m3_TECH = null, 
			string m3_SRES = null, 
			DateTime? m3_PMDT = null, 
			int? m3_PMTM = null, 
			DateTime? m3_RQSD = null, 
			int? m3_RQST = null, 
			DateTime? m3_RQFD = null, 
			int? m3_RQFT = null, 
			DateTime? m3_CSDT = null, 
			int? m3_CSTM = null, 
			DateTime? m3_CFDA = null, 
			int? m3_CFTM = null, 
			DateTime? m3_SSDT = null, 
			int? m3_SSTM = null, 
			DateTime? m3_RSDJ = null, 
			int? m3_RSTJ = null, 
			DateTime? m3_RFDJ = null, 
			int? m3_RFTJ = null, 
			DateTime? m3_RSDW = null, 
			int? m3_RSTW = null, 
			DateTime? m3_RFDW = null, 
			int? m3_RFTW = null, 
			string m3_CTNO = null, 
			string m3_ESCO = null, 
			string m3_ETX1 = null, 
			string m3_ETX2 = null, 
			string m3_ETX3 = null, 
			string m3_ETX4 = null, 
			string m3_ERCO = null, 
			string m3_DBCO = null, 
			string m3_SVID = null, 
			int? m3_WOTM = null, 
			int? m3_PRTM = null, 
			int? m3_FITM = null, 
			int? m3_TRTI = null, 
			DateTime? m3_PSDW = null, 
			int? m3_PSTW = null, 
			DateTime? m3_PFDW = null, 
			int? m3_PFTW = null, 
			DateTime? m3_PSDJ = null, 
			int? m3_PSTJ = null, 
			DateTime? m3_PFDJ = null, 
			int? m3_PFTJ = null, 
			string m3_MTCO = null, 
			string m3_MTX1 = null, 
			string m3_MTX2 = null, 
			string m3_MTX3 = null, 
			string m3_MTX4 = null, 
			string m3_MECO = null, 
			int? m3_OPRI = null, 
			string m3_JDCD = null, 
			string m3_JBST = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_ASST = null, 
			string m3_FCTN = null, 
			int? m3_TRIN = null, 
			string m3_QUNO = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			DateTime? m3_RDTE = null, 
			int? m3_RTIM = null, 
			string m3_ADEQ = null, 
			string m3_CNDI = null, 
			string m3_JBSE = null, 
			string m3_SUFI = null, 
			int? m3_ABLC = null, 
			int? m3_ATQC = null, 
			int? m3_PLME = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_INNO))
				throw new ArgumentNullException("m3_INNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("INNO", m3_INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3_JOBN.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODE))
				request.WithQueryParameter("MODE", m3_MODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (m3_PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3_PMDT.Value.ToM3String());
			if (m3_PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3_PMTM.Value.ToString());
			if (m3_RQSD.HasValue)
				request.WithQueryParameter("RQSD", m3_RQSD.Value.ToM3String());
			if (m3_RQST.HasValue)
				request.WithQueryParameter("RQST", m3_RQST.Value.ToString());
			if (m3_RQFD.HasValue)
				request.WithQueryParameter("RQFD", m3_RQFD.Value.ToM3String());
			if (m3_RQFT.HasValue)
				request.WithQueryParameter("RQFT", m3_RQFT.Value.ToString());
			if (m3_CSDT.HasValue)
				request.WithQueryParameter("CSDT", m3_CSDT.Value.ToM3String());
			if (m3_CSTM.HasValue)
				request.WithQueryParameter("CSTM", m3_CSTM.Value.ToString());
			if (m3_CFDA.HasValue)
				request.WithQueryParameter("CFDA", m3_CFDA.Value.ToM3String());
			if (m3_CFTM.HasValue)
				request.WithQueryParameter("CFTM", m3_CFTM.Value.ToString());
			if (m3_SSDT.HasValue)
				request.WithQueryParameter("SSDT", m3_SSDT.Value.ToM3String());
			if (m3_SSTM.HasValue)
				request.WithQueryParameter("SSTM", m3_SSTM.Value.ToString());
			if (m3_RSDJ.HasValue)
				request.WithQueryParameter("RSDJ", m3_RSDJ.Value.ToM3String());
			if (m3_RSTJ.HasValue)
				request.WithQueryParameter("RSTJ", m3_RSTJ.Value.ToString());
			if (m3_RFDJ.HasValue)
				request.WithQueryParameter("RFDJ", m3_RFDJ.Value.ToM3String());
			if (m3_RFTJ.HasValue)
				request.WithQueryParameter("RFTJ", m3_RFTJ.Value.ToString());
			if (m3_RSDW.HasValue)
				request.WithQueryParameter("RSDW", m3_RSDW.Value.ToM3String());
			if (m3_RSTW.HasValue)
				request.WithQueryParameter("RSTW", m3_RSTW.Value.ToString());
			if (m3_RFDW.HasValue)
				request.WithQueryParameter("RFDW", m3_RFDW.Value.ToM3String());
			if (m3_RFTW.HasValue)
				request.WithQueryParameter("RFTW", m3_RFTW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ESCO))
				request.WithQueryParameter("ESCO", m3_ESCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX1))
				request.WithQueryParameter("ETX1", m3_ETX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX2))
				request.WithQueryParameter("ETX2", m3_ETX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX3))
				request.WithQueryParameter("ETX3", m3_ETX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX4))
				request.WithQueryParameter("ETX4", m3_ETX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ERCO))
				request.WithQueryParameter("ERCO", m3_ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DBCO))
				request.WithQueryParameter("DBCO", m3_DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SVID))
				request.WithQueryParameter("SVID", m3_SVID.Trim());
			if (m3_WOTM.HasValue)
				request.WithQueryParameter("WOTM", m3_WOTM.Value.ToString());
			if (m3_PRTM.HasValue)
				request.WithQueryParameter("PRTM", m3_PRTM.Value.ToString());
			if (m3_FITM.HasValue)
				request.WithQueryParameter("FITM", m3_FITM.Value.ToString());
			if (m3_TRTI.HasValue)
				request.WithQueryParameter("TRTI", m3_TRTI.Value.ToString());
			if (m3_PSDW.HasValue)
				request.WithQueryParameter("PSDW", m3_PSDW.Value.ToM3String());
			if (m3_PSTW.HasValue)
				request.WithQueryParameter("PSTW", m3_PSTW.Value.ToString());
			if (m3_PFDW.HasValue)
				request.WithQueryParameter("PFDW", m3_PFDW.Value.ToM3String());
			if (m3_PFTW.HasValue)
				request.WithQueryParameter("PFTW", m3_PFTW.Value.ToString());
			if (m3_PSDJ.HasValue)
				request.WithQueryParameter("PSDJ", m3_PSDJ.Value.ToM3String());
			if (m3_PSTJ.HasValue)
				request.WithQueryParameter("PSTJ", m3_PSTJ.Value.ToString());
			if (m3_PFDJ.HasValue)
				request.WithQueryParameter("PFDJ", m3_PFDJ.Value.ToM3String());
			if (m3_PFTJ.HasValue)
				request.WithQueryParameter("PFTJ", m3_PFTJ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTCO))
				request.WithQueryParameter("MTCO", m3_MTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX1))
				request.WithQueryParameter("MTX1", m3_MTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX2))
				request.WithQueryParameter("MTX2", m3_MTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX3))
				request.WithQueryParameter("MTX3", m3_MTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX4))
				request.WithQueryParameter("MTX4", m3_MTX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MECO))
				request.WithQueryParameter("MECO", m3_MECO.Trim());
			if (m3_OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3_OPRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_JDCD))
				request.WithQueryParameter("JDCD", m3_JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JBST))
				request.WithQueryParameter("JBST", m3_JBST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASST))
				request.WithQueryParameter("ASST", m3_ASST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCTN))
				request.WithQueryParameter("FCTN", m3_FCTN.Trim());
			if (m3_TRIN.HasValue)
				request.WithQueryParameter("TRIN", m3_TRIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QUNO))
				request.WithQueryParameter("QUNO", m3_QUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_RDTE.HasValue)
				request.WithQueryParameter("RDTE", m3_RDTE.Value.ToM3String());
			if (m3_RTIM.HasValue)
				request.WithQueryParameter("RTIM", m3_RTIM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADEQ))
				request.WithQueryParameter("ADEQ", m3_ADEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CNDI))
				request.WithQueryParameter("CNDI", m3_CNDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JBSE))
				request.WithQueryParameter("JBSE", m3_JBSE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_ABLC.HasValue)
				request.WithQueryParameter("ABLC", m3_ABLC.Value.ToString());
			if (m3_ATQC.HasValue)
				request.WithQueryParameter("ATQC", m3_ATQC.Value.ToString());
			if (m3_PLME.HasValue)
				request.WithQueryParameter("PLME", m3_PLME.Value.ToString());

			// Execute the request
			var result = await Execute<AddSOAssignmResponse>(
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
		/// Name AddSOHead
		/// Description Add service order head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_SOTP">Service order type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_PRS1">Price list SO</param>
		/// <param name="m3_PMDT">Error reporting date</param>
		/// <param name="m3_PMTM">Error report time</param>
		/// <param name="m3_RQSD">Required start date</param>
		/// <param name="m3_RQST">Required start time</param>
		/// <param name="m3_RQFD">Required finish date</param>
		/// <param name="m3_RQFT">Required finish time</param>
		/// <param name="m3_CSDT">Confirmed start date</param>
		/// <param name="m3_CSTM">Confirmed start time</param>
		/// <param name="m3_CFDA">Confirmed finish date</param>
		/// <param name="m3_CFTM">Confirmed finish time</param>
		/// <param name="m3_CBDT">Contact customer date</param>
		/// <param name="m3_CBTM">Contact customer time</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_OSDT">Order entry date</param>
		/// <param name="m3_CUDT">Customer´s purchase order date</param>
		/// <param name="m3_DMDT">Manual due date</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_AICD">Summary invoice</param>
		/// <param name="m3_EXCD">Service charge</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_DLRM">Remark</param>
		/// <param name="m3_LHCD">Language code order head</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_SO40">FAM direct</param>
		/// <param name="m3_RONO">Run</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TAXC">Tax code</param>
		/// <param name="m3_CHSY">Line charge model</param>
		/// <param name="m3_TXAP">Tax applicable</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="m3_REBE">Registration number</param>
		/// <param name="m3_OIVR">Original invoice reference</param>
		/// <param name="m3_OYEA">Original year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddSOHeadResponse></returns>
		/// <exception cref="M3Exception<AddSOHeadResponse>"></exception>
		public async Task<M3Response<AddSOHeadResponse>> AddSOHead(
			string m3_CUNO, 
			string m3_SOTP, 
			int? m3_CONO = null, 
			string m3_ORNO = null, 
			string m3_TEPY = null, 
			string m3_ADID = null, 
			string m3_PYNO = null, 
			string m3_CUCD = null, 
			string m3_SMCD = null, 
			string m3_SRES = null, 
			string m3_TECH = null, 
			string m3_PRS1 = null, 
			DateTime? m3_PMDT = null, 
			int? m3_PMTM = null, 
			DateTime? m3_RQSD = null, 
			int? m3_RQST = null, 
			DateTime? m3_RQFD = null, 
			int? m3_RQFT = null, 
			DateTime? m3_CSDT = null, 
			int? m3_CSTM = null, 
			DateTime? m3_CFDA = null, 
			int? m3_CFTM = null, 
			DateTime? m3_CBDT = null, 
			int? m3_CBTM = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_TFNO = null, 
			DateTime? m3_OSDT = null, 
			DateTime? m3_CUDT = null, 
			DateTime? m3_DMDT = null, 
			string m3_OREF = null, 
			string m3_YREF = null, 
			int? m3_AICD = null, 
			string m3_EXCD = null, 
			string m3_CUOR = null, 
			string m3_DLRM = null, 
			string m3_LHCD = null, 
			string m3_OFNO = null, 
			int? m3_SO40 = null, 
			string m3_RONO = null, 
			string m3_RORN = null, 
			int? m3_RORC = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_FACI = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TAXC = null, 
			string m3_CHSY = null, 
			int? m3_TXAP = null, 
			string m3_INNO = null, 
			string m3_REBE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSOHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_SOTP))
				throw new ArgumentNullException("m3_SOTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("SOTP", m3_SOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRS1))
				request.WithQueryParameter("PRS1", m3_PRS1.Trim());
			if (m3_PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3_PMDT.Value.ToM3String());
			if (m3_PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3_PMTM.Value.ToString());
			if (m3_RQSD.HasValue)
				request.WithQueryParameter("RQSD", m3_RQSD.Value.ToM3String());
			if (m3_RQST.HasValue)
				request.WithQueryParameter("RQST", m3_RQST.Value.ToString());
			if (m3_RQFD.HasValue)
				request.WithQueryParameter("RQFD", m3_RQFD.Value.ToM3String());
			if (m3_RQFT.HasValue)
				request.WithQueryParameter("RQFT", m3_RQFT.Value.ToString());
			if (m3_CSDT.HasValue)
				request.WithQueryParameter("CSDT", m3_CSDT.Value.ToM3String());
			if (m3_CSTM.HasValue)
				request.WithQueryParameter("CSTM", m3_CSTM.Value.ToString());
			if (m3_CFDA.HasValue)
				request.WithQueryParameter("CFDA", m3_CFDA.Value.ToM3String());
			if (m3_CFTM.HasValue)
				request.WithQueryParameter("CFTM", m3_CFTM.Value.ToString());
			if (m3_CBDT.HasValue)
				request.WithQueryParameter("CBDT", m3_CBDT.Value.ToM3String());
			if (m3_CBTM.HasValue)
				request.WithQueryParameter("CBTM", m3_CBTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (m3_OSDT.HasValue)
				request.WithQueryParameter("OSDT", m3_OSDT.Value.ToM3String());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (m3_DMDT.HasValue)
				request.WithQueryParameter("DMDT", m3_DMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (m3_AICD.HasValue)
				request.WithQueryParameter("AICD", m3_AICD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXCD))
				request.WithQueryParameter("EXCD", m3_EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLRM))
				request.WithQueryParameter("DLRM", m3_DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LHCD))
				request.WithQueryParameter("LHCD", m3_LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_SO40.HasValue)
				request.WithQueryParameter("SO40", m3_SO40.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RONO))
				request.WithQueryParameter("RONO", m3_RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHSY))
				request.WithQueryParameter("CHSY", m3_CHSY.Trim());
			if (m3_TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3_TXAP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REBE))
				request.WithQueryParameter("REBE", m3_REBE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OIVR))
				request.WithQueryParameter("OIVR", m3_OIVR.Trim());
			if (m3_OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3_OYEA.Value.ToString());

			// Execute the request
			var result = await Execute<AddSOHeadResponse>(
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
		/// Name AddSOLine
		/// Description Add service order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_JOBN">Service order job number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_LTYP">Line type</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_PLSD">Planned start date</param>
		/// <param name="m3_PLST">Planned start time</param>
		/// <param name="m3_PLFD">Planned finish date</param>
		/// <param name="m3_PLFT">Planned finish time</param>
		/// <param name="m3_STCD">Inventory accounting</param>
		/// <param name="m3_UCOS">Cost price</param>
		/// <param name="m3_ERCO">Error cause</param>
		/// <param name="m3_MECO">Action</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_DIP1">Discount 1</param>
		/// <param name="m3_DIP2">Discount 2</param>
		/// <param name="m3_DIP3">Discount 3</param>
		/// <param name="m3_DIP4">Discount 4</param>
		/// <param name="m3_DIP5">Discount 5</param>
		/// <param name="m3_DIP6">Discount 6</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_DIA2">Discount amount 2</param>
		/// <param name="m3_DIA3">Discount amount 3</param>
		/// <param name="m3_DIA4">Discount amount 4</param>
		/// <param name="m3_DIA5">Discount amount 5</param>
		/// <param name="m3_DIA6">Discount amount 6</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_FCTN">Function area</param>
		/// <param name="m3_DBCO">Payer control</param>
		/// <param name="m3_ADTY">Internal address type</param>
		/// <param name="m3_FWHL">From warehouse</param>
		/// <param name="m3_DRAL">Direct allocate</param>
		/// <param name="m3_FSCD">Kit control</param>
		/// <param name="m3_FQCD">Fixed quantity</param>
		/// <param name="m3_ERRM">Error message (1=No set sts to 11, 0=Yes)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddSOLineResponse></returns>
		/// <exception cref="M3Exception<AddSOLineResponse>"></exception>
		public async Task<M3Response<AddSOLineResponse>> AddSOLine(
			string m3_ORNO, 
			int m3_JOBN, 
			string m3_ITNO, 
			decimal m3_ORQT, 
			int? m3_CONO = null, 
			int? m3_JBSX = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_TECH = null, 
			string m3_PYNO = null, 
			string m3_LTYP = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_SERI = null, 
			string m3_ITDS = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			DateTime? m3_PLSD = null, 
			int? m3_PLST = null, 
			DateTime? m3_PLFD = null, 
			int? m3_PLFT = null, 
			int? m3_STCD = null, 
			decimal? m3_UCOS = null, 
			string m3_ERCO = null, 
			string m3_MECO = null, 
			string m3_CTNO = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_DISY = null, 
			int? m3_DIP1 = null, 
			int? m3_DIP2 = null, 
			int? m3_DIP3 = null, 
			int? m3_DIP4 = null, 
			int? m3_DIP5 = null, 
			int? m3_DIP6 = null, 
			decimal? m3_DIA1 = null, 
			decimal? m3_DIA2 = null, 
			decimal? m3_DIA3 = null, 
			decimal? m3_DIA4 = null, 
			decimal? m3_DIA5 = null, 
			decimal? m3_DIA6 = null, 
			string m3_SUNO = null, 
			string m3_FCTN = null, 
			string m3_DBCO = null, 
			int? m3_ADTY = null, 
			string m3_FWHL = null, 
			int? m3_DRAL = null, 
			int? m3_FSCD = null, 
			int? m3_FQCD = null, 
			int? m3_ERRM = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ORQT", m3_ORQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LTYP))
				request.WithQueryParameter("LTYP", m3_LTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (m3_PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3_PLSD.Value.ToM3String());
			if (m3_PLST.HasValue)
				request.WithQueryParameter("PLST", m3_PLST.Value.ToString());
			if (m3_PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3_PLFD.Value.ToM3String());
			if (m3_PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3_PLFT.Value.ToString());
			if (m3_STCD.HasValue)
				request.WithQueryParameter("STCD", m3_STCD.Value.ToString());
			if (m3_UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3_UCOS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ERCO))
				request.WithQueryParameter("ERCO", m3_ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MECO))
				request.WithQueryParameter("MECO", m3_MECO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCTN))
				request.WithQueryParameter("FCTN", m3_FCTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DBCO))
				request.WithQueryParameter("DBCO", m3_DBCO.Trim());
			if (m3_ADTY.HasValue)
				request.WithQueryParameter("ADTY", m3_ADTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWHL))
				request.WithQueryParameter("FWHL", m3_FWHL.Trim());
			if (m3_DRAL.HasValue)
				request.WithQueryParameter("DRAL", m3_DRAL.Value.ToString());
			if (m3_FSCD.HasValue)
				request.WithQueryParameter("FSCD", m3_FSCD.Value.ToString());
			if (m3_FQCD.HasValue)
				request.WithQueryParameter("FQCD", m3_FQCD.Value.ToString());
			if (m3_ERRM.HasValue)
				request.WithQueryParameter("ERRM", m3_ERRM.Value.ToString());

			// Execute the request
			var result = await Execute<AddSOLineResponse>(
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
		/// Name AddServBatchAdr
		/// Description Add service batch order address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUA1">Customer address 1</param>
		/// <param name="m3_CUA2">Customer address 2</param>
		/// <param name="m3_CUA3">Customer address 3</param>
		/// <param name="m3_CUA4">Customer address 4</param>
		/// <param name="m3_CUA5">Customer address 5</param>
		/// <param name="m3_CUA6">Customer address 6</param>
		/// <param name="m3_CUA7">Customer address 7</param>
		/// <param name="m3_CUA8">Customer address 8</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_MEAL">Valid media</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_TAXC">Tax code</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddServBatchAdr(
			string m3_ORNO, 
			int? m3_CONO = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_CUA5 = null, 
			string m3_CUA6 = null, 
			string m3_CUA7 = null, 
			string m3_CUA8 = null, 
			string m3_PONO = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_MEAL = null, 
			long? m3_GEOC = null, 
			string m3_TAXC = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_TOWN = null, 
			string m3_FRCO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_CUA5))
				request.WithQueryParameter("CUA5", m3_CUA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA6))
				request.WithQueryParameter("CUA6", m3_CUA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA7))
				request.WithQueryParameter("CUA7", m3_CUA7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA8))
				request.WithQueryParameter("CUA8", m3_CUA8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEAL))
				request.WithQueryParameter("MEAL", m3_MEAL.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());

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
		/// Name AddServBatchLin
		/// Description Add service batch order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_JOBN">Service order job number (Required)</param>
		/// <param name="m3_JBSX">Assignment suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_LTYP">Line type</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_PLSD">Planned start date</param>
		/// <param name="m3_PLST">Planned start time</param>
		/// <param name="m3_PLFD">Planned finish date</param>
		/// <param name="m3_PLFT">Planned finish time</param>
		/// <param name="m3_STCD">Inventory accounting</param>
		/// <param name="m3_UCOS">Cost price</param>
		/// <param name="m3_ERCO">Error cause</param>
		/// <param name="m3_MECO">Action</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_DIP1">Discount 1</param>
		/// <param name="m3_DIP2">Discount 2</param>
		/// <param name="m3_DIP3">Discount 3</param>
		/// <param name="m3_DIP4">Discount 4</param>
		/// <param name="m3_DIP5">Discount 5</param>
		/// <param name="m3_DIP6">Discount 6</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_DIA2">Discount amount 2</param>
		/// <param name="m3_DIA3">Discount amount 3</param>
		/// <param name="m3_DIA4">Discount amount 4</param>
		/// <param name="m3_DIA5">Discount amount 5</param>
		/// <param name="m3_DIA6">Discount amount 6</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_FCTN">Function area</param>
		/// <param name="m3_DBCO">Payer control</param>
		/// <param name="m3_ADTY">Internal address type</param>
		/// <param name="m3_FWHL">From warehouse</param>
		/// <param name="m3_FSCD">Kit control</param>
		/// <param name="m3_FQCD">Fixed quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddServBatchLinResponse></returns>
		/// <exception cref="M3Exception<AddServBatchLinResponse>"></exception>
		public async Task<M3Response<AddServBatchLinResponse>> AddServBatchLin(
			string m3_ORNO, 
			int m3_JOBN, 
			int m3_JBSX, 
			int? m3_CONO = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_TECH = null, 
			string m3_PYNO = null, 
			string m3_LTYP = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_ITNO = null, 
			string m3_SERI = null, 
			string m3_ITDS = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			DateTime? m3_PLSD = null, 
			int? m3_PLST = null, 
			DateTime? m3_PLFD = null, 
			int? m3_PLFT = null, 
			int? m3_STCD = null, 
			decimal? m3_UCOS = null, 
			string m3_ERCO = null, 
			string m3_MECO = null, 
			string m3_CTNO = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_DISY = null, 
			int? m3_DIP1 = null, 
			int? m3_DIP2 = null, 
			int? m3_DIP3 = null, 
			int? m3_DIP4 = null, 
			int? m3_DIP5 = null, 
			int? m3_DIP6 = null, 
			decimal? m3_DIA1 = null, 
			decimal? m3_DIA2 = null, 
			decimal? m3_DIA3 = null, 
			decimal? m3_DIA4 = null, 
			decimal? m3_DIA5 = null, 
			decimal? m3_DIA6 = null, 
			string m3_SUNO = null, 
			string m3_FCTN = null, 
			string m3_DBCO = null, 
			int? m3_ADTY = null, 
			string m3_FWHL = null, 
			int? m3_FSCD = null, 
			int? m3_FQCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("JBSX", m3_JBSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LTYP))
				request.WithQueryParameter("LTYP", m3_LTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (m3_PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3_PLSD.Value.ToM3String());
			if (m3_PLST.HasValue)
				request.WithQueryParameter("PLST", m3_PLST.Value.ToString());
			if (m3_PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3_PLFD.Value.ToM3String());
			if (m3_PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3_PLFT.Value.ToString());
			if (m3_STCD.HasValue)
				request.WithQueryParameter("STCD", m3_STCD.Value.ToString());
			if (m3_UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3_UCOS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ERCO))
				request.WithQueryParameter("ERCO", m3_ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MECO))
				request.WithQueryParameter("MECO", m3_MECO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCTN))
				request.WithQueryParameter("FCTN", m3_FCTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DBCO))
				request.WithQueryParameter("DBCO", m3_DBCO.Trim());
			if (m3_ADTY.HasValue)
				request.WithQueryParameter("ADTY", m3_ADTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWHL))
				request.WithQueryParameter("FWHL", m3_FWHL.Trim());
			if (m3_FSCD.HasValue)
				request.WithQueryParameter("FSCD", m3_FSCD.Value.ToString());
			if (m3_FQCD.HasValue)
				request.WithQueryParameter("FQCD", m3_FQCD.Value.ToString());

			// Execute the request
			var result = await Execute<AddServBatchLinResponse>(
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
		/// Name AddServBatchTxt
		/// Description Add service batch order text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Temp Service order number (Required)</param>
		/// <param name="m3_TYPE">Text for Head, Assignment, Line (Required)</param>
		/// <param name="m3_TYTR">Type of text (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_JOBN">Service order job number</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TXEI">External/internal text</param>
		/// <param name="m3_TXHE">Document class</param>
		/// <param name="m3_TEXT">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddServBatchTxt(
			string m3_ORNO, 
			string m3_TYPE, 
			string m3_TYTR, 
			int? m3_CONO = null, 
			int? m3_JOBN = null, 
			int? m3_JBSX = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			decimal? m3_TXID = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
			int? m3_TXEI = null, 
			string m3_TXHE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddServBatchTxt",
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
			if (m3_JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3_JOBN.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3_TXEI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXHE))
				request.WithQueryParameter("TXHE", m3_TXHE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEXT))
				request.WithQueryParameter("TEXT", m3_TEXT.Trim());

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
		/// Name ChgFixedPrAssig
		/// Description Change fixed price assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_JOBN">Service order job number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="m3_TOPR">Total price</param>
		/// <param name="m3_TOPL">Price labor done</param>
		/// <param name="m3_TOPP">Price for all parts</param>
		/// <param name="m3_SCO1">Service expence cat</param>
		/// <param name="m3_SCO2">Service expence cat</param>
		/// <param name="m3_SCO3">Service expence cat</param>
		/// <param name="m3_SCO4">Service expence cat</param>
		/// <param name="m3_SCO5">Service expence cat</param>
		/// <param name="m3_SCO6">Service expence cat</param>
		/// <param name="m3_SCO7">Service expence cat</param>
		/// <param name="m3_SCO8">Service expence cat</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgFixedPrAssigResponse></returns>
		/// <exception cref="M3Exception<ChgFixedPrAssigResponse>"></exception>
		public async Task<M3Response<ChgFixedPrAssigResponse>> ChgFixedPrAssig(
			string m3_ORNO, 
			int m3_JOBN, 
			int? m3_CONO = null, 
			int? m3_JBSX = null, 
			decimal? m3_TOPR = null, 
			decimal? m3_TOPL = null, 
			decimal? m3_TOPP = null, 
			int? m3_SCO1 = null, 
			int? m3_SCO2 = null, 
			int? m3_SCO3 = null, 
			int? m3_SCO4 = null, 
			int? m3_SCO5 = null, 
			int? m3_SCO6 = null, 
			int? m3_SCO7 = null, 
			int? m3_SCO8 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());
			if (m3_TOPR.HasValue)
				request.WithQueryParameter("TOPR", m3_TOPR.Value.ToString());
			if (m3_TOPL.HasValue)
				request.WithQueryParameter("TOPL", m3_TOPL.Value.ToString());
			if (m3_TOPP.HasValue)
				request.WithQueryParameter("TOPP", m3_TOPP.Value.ToString());
			if (m3_SCO1.HasValue)
				request.WithQueryParameter("SCO1", m3_SCO1.Value.ToString());
			if (m3_SCO2.HasValue)
				request.WithQueryParameter("SCO2", m3_SCO2.Value.ToString());
			if (m3_SCO3.HasValue)
				request.WithQueryParameter("SCO3", m3_SCO3.Value.ToString());
			if (m3_SCO4.HasValue)
				request.WithQueryParameter("SCO4", m3_SCO4.Value.ToString());
			if (m3_SCO5.HasValue)
				request.WithQueryParameter("SCO5", m3_SCO5.Value.ToString());
			if (m3_SCO6.HasValue)
				request.WithQueryParameter("SCO6", m3_SCO6.Value.ToString());
			if (m3_SCO7.HasValue)
				request.WithQueryParameter("SCO7", m3_SCO7.Value.ToString());
			if (m3_SCO8.HasValue)
				request.WithQueryParameter("SCO8", m3_SCO8.Value.ToString());

			// Execute the request
			var result = await Execute<ChgFixedPrAssigResponse>(
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
		/// Name ChgSOAssignm
		/// Description Change service order assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_JOBN">Service order job number</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_MODE">Model description</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_PMDT">Error reporting date</param>
		/// <param name="m3_PMTM">Error report time</param>
		/// <param name="m3_RQSD">Required start date</param>
		/// <param name="m3_RQST">Required start time</param>
		/// <param name="m3_RQFD">Required finish date</param>
		/// <param name="m3_RQFT">Required finish time</param>
		/// <param name="m3_CSDT">Confirmed start date</param>
		/// <param name="m3_CSTM">Confirmed start time</param>
		/// <param name="m3_CFDA">Confirmed finish date</param>
		/// <param name="m3_CFTM">Confirmed finish time</param>
		/// <param name="m3_SSDT">Last start date</param>
		/// <param name="m3_SSTM">Last start time</param>
		/// <param name="m3_RSDJ">Actual start date - assignment</param>
		/// <param name="m3_RSTJ">Actual start time - assignment</param>
		/// <param name="m3_RFDJ">Actual finish date - assignment</param>
		/// <param name="m3_RFTJ">Actual finish time - assignment</param>
		/// <param name="m3_RSDW">Actual start date - task</param>
		/// <param name="m3_RSTW">Actual start time - task</param>
		/// <param name="m3_RFDW">Actual finish date - task</param>
		/// <param name="m3_RFTW">Actual finish time - task</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_ESCO">Error symptom</param>
		/// <param name="m3_ETX1">Error symptom text</param>
		/// <param name="m3_ETX2">Error symptom text</param>
		/// <param name="m3_ETX3">Error symptom text</param>
		/// <param name="m3_ETX4">Error symptom text</param>
		/// <param name="m3_ERCO">Error cause</param>
		/// <param name="m3_DBCO">Payer control</param>
		/// <param name="m3_SVID">Service expense</param>
		/// <param name="m3_WOTM">Forecast work hours</param>
		/// <param name="m3_PRTM">Planned preparation time</param>
		/// <param name="m3_FITM">Planned completion time</param>
		/// <param name="m3_TRTI">Planned travel time</param>
		/// <param name="m3_PSDW">Planned start date - task</param>
		/// <param name="m3_PSTW">Planned start time - task</param>
		/// <param name="m3_PFDW">Planned finish date - task</param>
		/// <param name="m3_PFTW">Planned finish time - task</param>
		/// <param name="m3_PSDJ">Planned start date - assignment</param>
		/// <param name="m3_PSTJ">Planned start time - assignment</param>
		/// <param name="m3_PFDJ">Planned finish date - assignment</param>
		/// <param name="m3_PFTJ">Planned finish time - assignment</param>
		/// <param name="m3_MTCO">Action text</param>
		/// <param name="m3_MTX1">Text</param>
		/// <param name="m3_MTX2">Text</param>
		/// <param name="m3_MTX3">Text</param>
		/// <param name="m3_MTX4">Text</param>
		/// <param name="m3_MECO">Action</param>
		/// <param name="m3_OPRI">Priority</param>
		/// <param name="m3_JDCD">Joint delivery</param>
		/// <param name="m3_JBST">Status service assignment</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_ASST">Assignment type</param>
		/// <param name="m3_FCTN">Function area</param>
		/// <param name="m3_TRIN">Transportation of individual item</param>
		/// <param name="m3_QUNO">Qualification</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_RDTE">Received date</param>
		/// <param name="m3_RTIM">Received time</param>
		/// <param name="m3_ADEQ">Additional equipment</param>
		/// <param name="m3_CNDI">Individual item condition</param>
		/// <param name="m3_JBSE">Additional status</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_ABLC">Allocation block code</param>
		/// <param name="m3_ATQC">Authority required</param>
		/// <param name="m3_PLME">Sent to remote server</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgSOAssignmResponse></returns>
		/// <exception cref="M3Exception<ChgSOAssignmResponse>"></exception>
		public async Task<M3Response<ChgSOAssignmResponse>> ChgSOAssignm(
			string m3_ORNO, 
			int? m3_CONO = null, 
			int? m3_JOBN = null, 
			int? m3_JBSX = null, 
			string m3_INNO = null, 
			string m3_SERI = null, 
			string m3_MODE = null, 
			string m3_ITNO = null, 
			string m3_TECH = null, 
			string m3_SRES = null, 
			DateTime? m3_PMDT = null, 
			int? m3_PMTM = null, 
			DateTime? m3_RQSD = null, 
			int? m3_RQST = null, 
			DateTime? m3_RQFD = null, 
			int? m3_RQFT = null, 
			DateTime? m3_CSDT = null, 
			int? m3_CSTM = null, 
			DateTime? m3_CFDA = null, 
			int? m3_CFTM = null, 
			DateTime? m3_SSDT = null, 
			int? m3_SSTM = null, 
			DateTime? m3_RSDJ = null, 
			int? m3_RSTJ = null, 
			DateTime? m3_RFDJ = null, 
			int? m3_RFTJ = null, 
			DateTime? m3_RSDW = null, 
			int? m3_RSTW = null, 
			DateTime? m3_RFDW = null, 
			int? m3_RFTW = null, 
			string m3_CTNO = null, 
			string m3_ESCO = null, 
			string m3_ETX1 = null, 
			string m3_ETX2 = null, 
			string m3_ETX3 = null, 
			string m3_ETX4 = null, 
			string m3_ERCO = null, 
			string m3_DBCO = null, 
			string m3_SVID = null, 
			int? m3_WOTM = null, 
			int? m3_PRTM = null, 
			int? m3_FITM = null, 
			int? m3_TRTI = null, 
			DateTime? m3_PSDW = null, 
			int? m3_PSTW = null, 
			DateTime? m3_PFDW = null, 
			int? m3_PFTW = null, 
			DateTime? m3_PSDJ = null, 
			int? m3_PSTJ = null, 
			DateTime? m3_PFDJ = null, 
			int? m3_PFTJ = null, 
			string m3_MTCO = null, 
			string m3_MTX1 = null, 
			string m3_MTX2 = null, 
			string m3_MTX3 = null, 
			string m3_MTX4 = null, 
			string m3_MECO = null, 
			int? m3_OPRI = null, 
			string m3_JDCD = null, 
			string m3_JBST = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_ASST = null, 
			string m3_FCTN = null, 
			int? m3_TRIN = null, 
			string m3_QUNO = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			DateTime? m3_RDTE = null, 
			int? m3_RTIM = null, 
			string m3_ADEQ = null, 
			string m3_CNDI = null, 
			string m3_JBSE = null, 
			string m3_SUFI = null, 
			int? m3_ABLC = null, 
			int? m3_ATQC = null, 
			int? m3_PLME = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3_JOBN.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODE))
				request.WithQueryParameter("MODE", m3_MODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (m3_PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3_PMDT.Value.ToM3String());
			if (m3_PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3_PMTM.Value.ToString());
			if (m3_RQSD.HasValue)
				request.WithQueryParameter("RQSD", m3_RQSD.Value.ToM3String());
			if (m3_RQST.HasValue)
				request.WithQueryParameter("RQST", m3_RQST.Value.ToString());
			if (m3_RQFD.HasValue)
				request.WithQueryParameter("RQFD", m3_RQFD.Value.ToM3String());
			if (m3_RQFT.HasValue)
				request.WithQueryParameter("RQFT", m3_RQFT.Value.ToString());
			if (m3_CSDT.HasValue)
				request.WithQueryParameter("CSDT", m3_CSDT.Value.ToM3String());
			if (m3_CSTM.HasValue)
				request.WithQueryParameter("CSTM", m3_CSTM.Value.ToString());
			if (m3_CFDA.HasValue)
				request.WithQueryParameter("CFDA", m3_CFDA.Value.ToM3String());
			if (m3_CFTM.HasValue)
				request.WithQueryParameter("CFTM", m3_CFTM.Value.ToString());
			if (m3_SSDT.HasValue)
				request.WithQueryParameter("SSDT", m3_SSDT.Value.ToM3String());
			if (m3_SSTM.HasValue)
				request.WithQueryParameter("SSTM", m3_SSTM.Value.ToString());
			if (m3_RSDJ.HasValue)
				request.WithQueryParameter("RSDJ", m3_RSDJ.Value.ToM3String());
			if (m3_RSTJ.HasValue)
				request.WithQueryParameter("RSTJ", m3_RSTJ.Value.ToString());
			if (m3_RFDJ.HasValue)
				request.WithQueryParameter("RFDJ", m3_RFDJ.Value.ToM3String());
			if (m3_RFTJ.HasValue)
				request.WithQueryParameter("RFTJ", m3_RFTJ.Value.ToString());
			if (m3_RSDW.HasValue)
				request.WithQueryParameter("RSDW", m3_RSDW.Value.ToM3String());
			if (m3_RSTW.HasValue)
				request.WithQueryParameter("RSTW", m3_RSTW.Value.ToString());
			if (m3_RFDW.HasValue)
				request.WithQueryParameter("RFDW", m3_RFDW.Value.ToM3String());
			if (m3_RFTW.HasValue)
				request.WithQueryParameter("RFTW", m3_RFTW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ESCO))
				request.WithQueryParameter("ESCO", m3_ESCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX1))
				request.WithQueryParameter("ETX1", m3_ETX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX2))
				request.WithQueryParameter("ETX2", m3_ETX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX3))
				request.WithQueryParameter("ETX3", m3_ETX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX4))
				request.WithQueryParameter("ETX4", m3_ETX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ERCO))
				request.WithQueryParameter("ERCO", m3_ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DBCO))
				request.WithQueryParameter("DBCO", m3_DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SVID))
				request.WithQueryParameter("SVID", m3_SVID.Trim());
			if (m3_WOTM.HasValue)
				request.WithQueryParameter("WOTM", m3_WOTM.Value.ToString());
			if (m3_PRTM.HasValue)
				request.WithQueryParameter("PRTM", m3_PRTM.Value.ToString());
			if (m3_FITM.HasValue)
				request.WithQueryParameter("FITM", m3_FITM.Value.ToString());
			if (m3_TRTI.HasValue)
				request.WithQueryParameter("TRTI", m3_TRTI.Value.ToString());
			if (m3_PSDW.HasValue)
				request.WithQueryParameter("PSDW", m3_PSDW.Value.ToM3String());
			if (m3_PSTW.HasValue)
				request.WithQueryParameter("PSTW", m3_PSTW.Value.ToString());
			if (m3_PFDW.HasValue)
				request.WithQueryParameter("PFDW", m3_PFDW.Value.ToM3String());
			if (m3_PFTW.HasValue)
				request.WithQueryParameter("PFTW", m3_PFTW.Value.ToString());
			if (m3_PSDJ.HasValue)
				request.WithQueryParameter("PSDJ", m3_PSDJ.Value.ToM3String());
			if (m3_PSTJ.HasValue)
				request.WithQueryParameter("PSTJ", m3_PSTJ.Value.ToString());
			if (m3_PFDJ.HasValue)
				request.WithQueryParameter("PFDJ", m3_PFDJ.Value.ToM3String());
			if (m3_PFTJ.HasValue)
				request.WithQueryParameter("PFTJ", m3_PFTJ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTCO))
				request.WithQueryParameter("MTCO", m3_MTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX1))
				request.WithQueryParameter("MTX1", m3_MTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX2))
				request.WithQueryParameter("MTX2", m3_MTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX3))
				request.WithQueryParameter("MTX3", m3_MTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX4))
				request.WithQueryParameter("MTX4", m3_MTX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MECO))
				request.WithQueryParameter("MECO", m3_MECO.Trim());
			if (m3_OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3_OPRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_JDCD))
				request.WithQueryParameter("JDCD", m3_JDCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JBST))
				request.WithQueryParameter("JBST", m3_JBST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASST))
				request.WithQueryParameter("ASST", m3_ASST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCTN))
				request.WithQueryParameter("FCTN", m3_FCTN.Trim());
			if (m3_TRIN.HasValue)
				request.WithQueryParameter("TRIN", m3_TRIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QUNO))
				request.WithQueryParameter("QUNO", m3_QUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_RDTE.HasValue)
				request.WithQueryParameter("RDTE", m3_RDTE.Value.ToM3String());
			if (m3_RTIM.HasValue)
				request.WithQueryParameter("RTIM", m3_RTIM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADEQ))
				request.WithQueryParameter("ADEQ", m3_ADEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CNDI))
				request.WithQueryParameter("CNDI", m3_CNDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JBSE))
				request.WithQueryParameter("JBSE", m3_JBSE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_ABLC.HasValue)
				request.WithQueryParameter("ABLC", m3_ABLC.Value.ToString());
			if (m3_ATQC.HasValue)
				request.WithQueryParameter("ATQC", m3_ATQC.Value.ToString());
			if (m3_PLME.HasValue)
				request.WithQueryParameter("PLME", m3_PLME.Value.ToString());

			// Execute the request
			var result = await Execute<ChgSOAssignmResponse>(
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
		/// Name ChgSOHead
		/// Description Change service order head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_PRS1">Price list SO</param>
		/// <param name="m3_PMDT">Error reporting date</param>
		/// <param name="m3_PMTM">Error report time</param>
		/// <param name="m3_RQSD">Required start date</param>
		/// <param name="m3_RQST">Required start time</param>
		/// <param name="m3_RQFD">Required finish date</param>
		/// <param name="m3_RQFT">Required finish time</param>
		/// <param name="m3_CSDT">Confirmed start date</param>
		/// <param name="m3_CSTM">Confirmed start time</param>
		/// <param name="m3_CFDA">Confirmed finish date</param>
		/// <param name="m3_CFTM">Confirmed finish time</param>
		/// <param name="m3_CBDT">Contact customer date</param>
		/// <param name="m3_CBTM">Contact customer time</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_OSDT">Order entry date</param>
		/// <param name="m3_CUDT">Customer´s purchase order date</param>
		/// <param name="m3_DMDT">Manual due date</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_EXCD">Service charge</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_DLRM">Remark</param>
		/// <param name="m3_LHCD">Language code order head</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_SO40">FAM direct</param>
		/// <param name="m3_RONO">Run</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TAXC">Tax code</param>
		/// <param name="m3_CHSY">Line charge model</param>
		/// <param name="m3_TXAP">Tax applicable</param>
		/// <param name="m3_AICD">Summary invoice</param>
		/// <param name="m3_OIVR">Original invoice reference</param>
		/// <param name="m3_OYEA">Original year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgSOHeadResponse></returns>
		/// <exception cref="M3Exception<ChgSOHeadResponse>"></exception>
		public async Task<M3Response<ChgSOHeadResponse>> ChgSOHead(
			string m3_ORNO, 
			int? m3_CONO = null, 
			string m3_TEPY = null, 
			string m3_ADID = null, 
			string m3_PYNO = null, 
			string m3_SMCD = null, 
			string m3_SRES = null, 
			string m3_TECH = null, 
			string m3_PRS1 = null, 
			DateTime? m3_PMDT = null, 
			int? m3_PMTM = null, 
			DateTime? m3_RQSD = null, 
			int? m3_RQST = null, 
			DateTime? m3_RQFD = null, 
			int? m3_RQFT = null, 
			DateTime? m3_CSDT = null, 
			int? m3_CSTM = null, 
			DateTime? m3_CFDA = null, 
			int? m3_CFTM = null, 
			DateTime? m3_CBDT = null, 
			int? m3_CBTM = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_TFNO = null, 
			DateTime? m3_OSDT = null, 
			DateTime? m3_CUDT = null, 
			DateTime? m3_DMDT = null, 
			string m3_OREF = null, 
			string m3_YREF = null, 
			string m3_EXCD = null, 
			string m3_CUOR = null, 
			string m3_DLRM = null, 
			string m3_LHCD = null, 
			string m3_OFNO = null, 
			int? m3_SO40 = null, 
			string m3_RONO = null, 
			string m3_RORN = null, 
			int? m3_RORC = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TAXC = null, 
			string m3_CHSY = null, 
			int? m3_TXAP = null, 
			int? m3_AICD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgSOHead",
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
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRS1))
				request.WithQueryParameter("PRS1", m3_PRS1.Trim());
			if (m3_PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3_PMDT.Value.ToM3String());
			if (m3_PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3_PMTM.Value.ToString());
			if (m3_RQSD.HasValue)
				request.WithQueryParameter("RQSD", m3_RQSD.Value.ToM3String());
			if (m3_RQST.HasValue)
				request.WithQueryParameter("RQST", m3_RQST.Value.ToString());
			if (m3_RQFD.HasValue)
				request.WithQueryParameter("RQFD", m3_RQFD.Value.ToM3String());
			if (m3_RQFT.HasValue)
				request.WithQueryParameter("RQFT", m3_RQFT.Value.ToString());
			if (m3_CSDT.HasValue)
				request.WithQueryParameter("CSDT", m3_CSDT.Value.ToM3String());
			if (m3_CSTM.HasValue)
				request.WithQueryParameter("CSTM", m3_CSTM.Value.ToString());
			if (m3_CFDA.HasValue)
				request.WithQueryParameter("CFDA", m3_CFDA.Value.ToM3String());
			if (m3_CFTM.HasValue)
				request.WithQueryParameter("CFTM", m3_CFTM.Value.ToString());
			if (m3_CBDT.HasValue)
				request.WithQueryParameter("CBDT", m3_CBDT.Value.ToM3String());
			if (m3_CBTM.HasValue)
				request.WithQueryParameter("CBTM", m3_CBTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (m3_OSDT.HasValue)
				request.WithQueryParameter("OSDT", m3_OSDT.Value.ToM3String());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (m3_DMDT.HasValue)
				request.WithQueryParameter("DMDT", m3_DMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXCD))
				request.WithQueryParameter("EXCD", m3_EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLRM))
				request.WithQueryParameter("DLRM", m3_DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LHCD))
				request.WithQueryParameter("LHCD", m3_LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_SO40.HasValue)
				request.WithQueryParameter("SO40", m3_SO40.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RONO))
				request.WithQueryParameter("RONO", m3_RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHSY))
				request.WithQueryParameter("CHSY", m3_CHSY.Trim());
			if (m3_TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3_TXAP.Value.ToString());
			if (m3_AICD.HasValue)
				request.WithQueryParameter("AICD", m3_AICD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OIVR))
				request.WithQueryParameter("OIVR", m3_OIVR.Trim());
			if (m3_OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3_OYEA.Value.ToString());

			// Execute the request
			var result = await Execute<ChgSOHeadResponse>(
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
		/// Name ChgSOLine
		/// Description Change service order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_PLSD">Planned start date</param>
		/// <param name="m3_PLST">Planned start time</param>
		/// <param name="m3_PLFD">Planned finish date</param>
		/// <param name="m3_PLFT">Planned finish time</param>
		/// <param name="m3_UCOS">Cost price</param>
		/// <param name="m3_ERCO">Error cause</param>
		/// <param name="m3_MECO">Action</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_DIP1">Discount 1</param>
		/// <param name="m3_DIP2">Discount 2</param>
		/// <param name="m3_DIP3">Discount 3</param>
		/// <param name="m3_DIP4">Discount 4</param>
		/// <param name="m3_DIP5">Discount 5</param>
		/// <param name="m3_DIP6">Discount 6</param>
		/// <param name="m3_DIA1">Discount amount 1</param>
		/// <param name="m3_DIA2">Discount amount 2</param>
		/// <param name="m3_DIA3">Discount amount 3</param>
		/// <param name="m3_DIA4">Discount amount 4</param>
		/// <param name="m3_DIA5">Discount amount 5</param>
		/// <param name="m3_DIA6">Discount amount 6</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_FCTN">Function area</param>
		/// <param name="m3_RAQT">Reported quantity</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_DRAL">Direct allocate</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgSOLineResponse></returns>
		/// <exception cref="M3Exception<ChgSOLineResponse>"></exception>
		public async Task<M3Response<ChgSOLineResponse>> ChgSOLine(
			string m3_ORNO, 
			int m3_PONR, 
			int? m3_CONO = null, 
			int? m3_POSX = null, 
			string m3_TECH = null, 
			string m3_PYNO = null, 
			string m3_SERI = null, 
			string m3_ITDS = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			DateTime? m3_PLSD = null, 
			int? m3_PLST = null, 
			DateTime? m3_PLFD = null, 
			int? m3_PLFT = null, 
			decimal? m3_UCOS = null, 
			string m3_ERCO = null, 
			string m3_MECO = null, 
			string m3_CTNO = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_DISY = null, 
			int? m3_DIP1 = null, 
			int? m3_DIP2 = null, 
			int? m3_DIP3 = null, 
			int? m3_DIP4 = null, 
			int? m3_DIP5 = null, 
			int? m3_DIP6 = null, 
			decimal? m3_DIA1 = null, 
			decimal? m3_DIA2 = null, 
			decimal? m3_DIA3 = null, 
			decimal? m3_DIA4 = null, 
			decimal? m3_DIA5 = null, 
			decimal? m3_DIA6 = null, 
			string m3_SUNO = null, 
			string m3_FCTN = null, 
			decimal? m3_RAQT = null, 
			int? m3_OEND = null, 
			int? m3_DRAL = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (m3_PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3_PLSD.Value.ToM3String());
			if (m3_PLST.HasValue)
				request.WithQueryParameter("PLST", m3_PLST.Value.ToString());
			if (m3_PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3_PLFD.Value.ToM3String());
			if (m3_PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3_PLFT.Value.ToString());
			if (m3_UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3_UCOS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ERCO))
				request.WithQueryParameter("ERCO", m3_ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MECO))
				request.WithQueryParameter("MECO", m3_MECO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCTN))
				request.WithQueryParameter("FCTN", m3_FCTN.Trim());
			if (m3_RAQT.HasValue)
				request.WithQueryParameter("RAQT", m3_RAQT.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_DRAL.HasValue)
				request.WithQueryParameter("DRAL", m3_DRAL.Value.ToString());

			// Execute the request
			var result = await Execute<ChgSOLineResponse>(
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
		/// Description Confirm of SO batch order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
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
		/// Name GetSOAssignm
		/// Description GetSOAssignm
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_JOBN">Assignment</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSOAssignmResponse></returns>
		/// <exception cref="M3Exception<GetSOAssignmResponse>"></exception>
		public async Task<M3Response<GetSOAssignmResponse>> GetSOAssignm(
			int? m3_CONO = null, 
			string m3_ORNO = null, 
			int? m3_JOBN = null, 
			int? m3_JBSX = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3_JOBN.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());

			// Execute the request
			var result = await Execute<GetSOAssignmResponse>(
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
		/// Name GetSOLine
		/// Description Get service order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSOLineResponse></returns>
		/// <exception cref="M3Exception<GetSOLineResponse>"></exception>
		public async Task<M3Response<GetSOLineResponse>> GetSOLine(
			string m3_ORNO, 
			int m3_PONR, 
			int m3_POSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetSOLineResponse>(
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
		/// Description List error msg on batch order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
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
	}
}
// EOF
