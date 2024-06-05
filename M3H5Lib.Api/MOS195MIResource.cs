/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.MOS195MI;
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
	/// Name: MOS195MI
	/// Component Name: MOS195
	/// Description: API: Search WO Operation
	/// Version Release: 14.x
	///</summary>
	public partial class MOS195MIResource : M3BaseResourceEndpoint
	{
		public MOS195MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS195MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SelPlanned
		/// Description Select Planned Work Order Operations with various filter
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STFR">Status FROM</param>
		/// <param name="m3STTO">Status to</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STD2">Start date</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3FID2">Finish date</param>
		/// <param name="m3RGDT">Entry date</param>
		/// <param name="m3RGD2">Entry date</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3NSTP">Shutdown</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3PLPN">Planned order</param>
		/// <param name="m3PLPS">Subnumber - planned order</param>
		/// <param name="m3PLP2">Subnumber - order proposal</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelPlannedResponse></returns>
		/// <exception cref="M3Exception<SelPlannedResponse>"></exception>
		public async Task<M3Response<SelPlannedResponse>> SelPlanned(
			string m3FACI, 
			int? m3CONO = null, 
			string m3STFR = null, 
			string m3STTO = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			DateTime? m3STDT = null, 
			DateTime? m3STD2 = null, 
			DateTime? m3FIDT = null, 
			DateTime? m3FID2 = null, 
			DateTime? m3RGDT = null, 
			DateTime? m3RGD2 = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			string m3CFGL = null, 
			string m3SUFI = null, 
			string m3EVTY = null, 
			int? m3NSTP = null, 
			string m3ORTY = null, 
			string m3PRNO = null, 
			int? m3PLPN = null, 
			int? m3PLPS = null, 
			int? m3PLP2 = null, 
			string m3EMNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelPlanned",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STFR))
				request.WithQueryParameter("STFR", m3STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTO))
				request.WithQueryParameter("STTO", m3STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STD2.HasValue)
				request.WithQueryParameter("STD2", m3STD2.Value.ToM3String());
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3FID2.HasValue)
				request.WithQueryParameter("FID2", m3FID2.Value.ToM3String());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (m3NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3NSTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (m3PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3PLPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3PLP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());

			// Execute the request
			var result = await Execute<SelPlannedResponse>(
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
		/// Name SelReleased
		/// Description Select ReleasedWork Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STFR">Status FROM</param>
		/// <param name="m3STTO">Status to</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STD2">Start date</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3FID2">Finish date</param>
		/// <param name="m3RGDT">Entry date</param>
		/// <param name="m3RGD2">Entry date</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3PLPN">Planned order</param>
		/// <param name="m3PLPS">Subnumber - planned order</param>
		/// <param name="m3PLP2">Subnumber - order proposal</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelReleasedResponse></returns>
		/// <exception cref="M3Exception<SelReleasedResponse>"></exception>
		public async Task<M3Response<SelReleasedResponse>> SelReleased(
			string m3FACI, 
			int? m3CONO = null, 
			string m3STFR = null, 
			string m3STTO = null, 
			string m3PLGR = null, 
			DateTime? m3STDT = null, 
			DateTime? m3STD2 = null, 
			DateTime? m3FIDT = null, 
			DateTime? m3FID2 = null, 
			DateTime? m3RGDT = null, 
			DateTime? m3RGD2 = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			string m3CFGL = null, 
			string m3SUFI = null, 
			string m3EVTY = null, 
			string m3ORTY = null, 
			string m3PRNO = null, 
			int? m3PLPN = null, 
			int? m3PLPS = null, 
			int? m3PLP2 = null, 
			string m3MWNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelReleased",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STFR))
				request.WithQueryParameter("STFR", m3STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTO))
				request.WithQueryParameter("STTO", m3STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STD2.HasValue)
				request.WithQueryParameter("STD2", m3STD2.Value.ToM3String());
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3FID2.HasValue)
				request.WithQueryParameter("FID2", m3FID2.Value.ToM3String());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (m3PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3PLPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3PLP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());

			// Execute the request
			var result = await Execute<SelReleasedResponse>(
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
		/// Name SelReqElem
		/// Description Select WO request element for empl.
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STFR">Status FROM</param>
		/// <param name="m3STTO">Status to</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STD2">Start date</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3FID2">Finish date</param>
		/// <param name="m3RGDT">Entry date</param>
		/// <param name="m3RGD2">Entry date</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3NSTP">Shutdown</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3PLPN">Planned order</param>
		/// <param name="m3PLPS">Subnumber - planned order</param>
		/// <param name="m3PLP2">Subnumber - order proposal</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3ACTF">Operation element type</param>
		/// <param name="m3ACTT">Operation element type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelReqElemResponse></returns>
		/// <exception cref="M3Exception<SelReqElemResponse>"></exception>
		public async Task<M3Response<SelReqElemResponse>> SelReqElem(
			string m3FACI, 
			int? m3CONO = null, 
			string m3STFR = null, 
			string m3STTO = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			DateTime? m3STDT = null, 
			DateTime? m3STD2 = null, 
			DateTime? m3FIDT = null, 
			DateTime? m3FID2 = null, 
			DateTime? m3RGDT = null, 
			DateTime? m3RGD2 = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			string m3CFGL = null, 
			string m3SUFI = null, 
			string m3EVTY = null, 
			int? m3NSTP = null, 
			string m3ORTY = null, 
			string m3PRNO = null, 
			int? m3PLPN = null, 
			int? m3PLPS = null, 
			int? m3PLP2 = null, 
			string m3EMNO = null, 
			string m3CHID = null, 
			string m3RESP = null, 
			string m3ACTF = null, 
			string m3ACTT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelReqElem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STFR))
				request.WithQueryParameter("STFR", m3STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTO))
				request.WithQueryParameter("STTO", m3STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STD2.HasValue)
				request.WithQueryParameter("STD2", m3STD2.Value.ToM3String());
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3FID2.HasValue)
				request.WithQueryParameter("FID2", m3FID2.Value.ToM3String());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (m3NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3NSTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (m3PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3PLPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3PLP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACTF))
				request.WithQueryParameter("ACTF", m3ACTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACTT))
				request.WithQueryParameter("ACTT", m3ACTT.Trim());

			// Execute the request
			var result = await Execute<SelReqElemResponse>(
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
		/// Name SelReqOper
		/// Description Select Planned Work Order Operations with various filter
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STFR">Status FROM</param>
		/// <param name="m3STTO">Status to</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STD2">Start date</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3FID2">Finish date</param>
		/// <param name="m3RGDT">Entry date</param>
		/// <param name="m3RGD2">Entry date</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3NSTP">Shutdown</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3PLPN">Planned order</param>
		/// <param name="m3PLPS">Subnumber - planned order</param>
		/// <param name="m3PLP2">Subnumber - order proposal</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelReqOperResponse></returns>
		/// <exception cref="M3Exception<SelReqOperResponse>"></exception>
		public async Task<M3Response<SelReqOperResponse>> SelReqOper(
			string m3FACI, 
			int? m3CONO = null, 
			string m3STFR = null, 
			string m3STTO = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			DateTime? m3STDT = null, 
			DateTime? m3STD2 = null, 
			DateTime? m3FIDT = null, 
			DateTime? m3FID2 = null, 
			DateTime? m3RGDT = null, 
			DateTime? m3RGD2 = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			string m3CFGL = null, 
			string m3SUFI = null, 
			string m3EVTY = null, 
			int? m3NSTP = null, 
			string m3ORTY = null, 
			string m3PRNO = null, 
			int? m3PLPN = null, 
			int? m3PLPS = null, 
			int? m3PLP2 = null, 
			string m3EMNO = null, 
			string m3CHID = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelReqOper",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STFR))
				request.WithQueryParameter("STFR", m3STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTO))
				request.WithQueryParameter("STTO", m3STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STD2.HasValue)
				request.WithQueryParameter("STD2", m3STD2.Value.ToM3String());
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3FID2.HasValue)
				request.WithQueryParameter("FID2", m3FID2.Value.ToM3String());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (m3NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3NSTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (m3PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3PLPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3PLP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<SelReqOperResponse>(
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
		/// Name SelWoAndReqElem
		/// Description Select Work Order and Request Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STFR">Status FROM</param>
		/// <param name="m3STTO">Status to</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STD2">Start date</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3FID2">Finish date</param>
		/// <param name="m3RGDT">Entry date</param>
		/// <param name="m3RGD2">Entry date</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3NSTP">Shutdown</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelWoAndReqElemResponse></returns>
		/// <exception cref="M3Exception<SelWoAndReqElemResponse>"></exception>
		public async Task<M3Response<SelWoAndReqElemResponse>> SelWoAndReqElem(
			string m3FACI, 
			int? m3CONO = null, 
			string m3STFR = null, 
			string m3STTO = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			DateTime? m3STDT = null, 
			DateTime? m3STD2 = null, 
			DateTime? m3FIDT = null, 
			DateTime? m3FID2 = null, 
			DateTime? m3RGDT = null, 
			DateTime? m3RGD2 = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			string m3CFGL = null, 
			string m3SUFI = null, 
			string m3EVTY = null, 
			int? m3NSTP = null, 
			string m3ORTY = null, 
			string m3PRNO = null, 
			string m3MWNO = null, 
			string m3EMNO = null, 
			string m3CHID = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelWoAndReqElem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STFR))
				request.WithQueryParameter("STFR", m3STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTO))
				request.WithQueryParameter("STTO", m3STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STD2.HasValue)
				request.WithQueryParameter("STD2", m3STD2.Value.ToM3String());
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3FID2.HasValue)
				request.WithQueryParameter("FID2", m3FID2.Value.ToM3String());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (m3NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3NSTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<SelWoAndReqElemResponse>(
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
		/// Name SelWoAndReqOper
		/// Description Select Work Order and Request Operations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STFR">Status FROM</param>
		/// <param name="m3STTO">Status to</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STD2">Start date</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3FID2">Finish date</param>
		/// <param name="m3RGDT">Entry date</param>
		/// <param name="m3RGD2">Entry date</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3NSTP">Shutdown</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelWoAndReqOperResponse></returns>
		/// <exception cref="M3Exception<SelWoAndReqOperResponse>"></exception>
		public async Task<M3Response<SelWoAndReqOperResponse>> SelWoAndReqOper(
			string m3FACI, 
			int? m3CONO = null, 
			string m3STFR = null, 
			string m3STTO = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			DateTime? m3STDT = null, 
			DateTime? m3STD2 = null, 
			DateTime? m3FIDT = null, 
			DateTime? m3FID2 = null, 
			DateTime? m3RGDT = null, 
			DateTime? m3RGD2 = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			string m3CFGL = null, 
			string m3SUFI = null, 
			string m3EVTY = null, 
			int? m3NSTP = null, 
			string m3ORTY = null, 
			string m3PRNO = null, 
			string m3MWNO = null, 
			string m3EMNO = null, 
			string m3CHID = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelWoAndReqOper",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STFR))
				request.WithQueryParameter("STFR", m3STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTO))
				request.WithQueryParameter("STTO", m3STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STD2.HasValue)
				request.WithQueryParameter("STD2", m3STD2.Value.ToM3String());
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3FID2.HasValue)
				request.WithQueryParameter("FID2", m3FID2.Value.ToM3String());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (m3NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3NSTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<SelWoAndReqOperResponse>(
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
		/// Name SelWoElem
		/// Description Select WO element for employee
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STFR">Status FROM</param>
		/// <param name="m3STTO">Status to</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STD2">Start date</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3FID2">Finish date</param>
		/// <param name="m3RGDT">Entry date</param>
		/// <param name="m3RGD2">Entry date</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3NSTP">Shutdown</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3STMF">Status mobility</param>
		/// <param name="m3STMT">Status mobility</param>
		/// <param name="m3ACTF">Operation element type</param>
		/// <param name="m3ACTT">Operation element type</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelWoElemResponse></returns>
		/// <exception cref="M3Exception<SelWoElemResponse>"></exception>
		public async Task<M3Response<SelWoElemResponse>> SelWoElem(
			string m3FACI, 
			int? m3CONO = null, 
			string m3STFR = null, 
			string m3STTO = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			DateTime? m3STDT = null, 
			DateTime? m3STD2 = null, 
			DateTime? m3FIDT = null, 
			DateTime? m3FID2 = null, 
			DateTime? m3RGDT = null, 
			DateTime? m3RGD2 = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			string m3CFGL = null, 
			string m3SUFI = null, 
			string m3EVTY = null, 
			int? m3NSTP = null, 
			string m3ORTY = null, 
			string m3PRNO = null, 
			string m3MWNO = null, 
			string m3EMNO = null, 
			string m3CHID = null, 
			string m3RESP = null, 
			string m3STMF = null, 
			string m3STMT = null, 
			string m3ACTF = null, 
			string m3ACTT = null, 
			int? m3OPNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelWoElem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STFR))
				request.WithQueryParameter("STFR", m3STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTO))
				request.WithQueryParameter("STTO", m3STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STD2.HasValue)
				request.WithQueryParameter("STD2", m3STD2.Value.ToM3String());
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3FID2.HasValue)
				request.WithQueryParameter("FID2", m3FID2.Value.ToM3String());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (m3NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3NSTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3STMF))
				request.WithQueryParameter("STMF", m3STMF.Trim());
			if (!string.IsNullOrWhiteSpace(m3STMT))
				request.WithQueryParameter("STMT", m3STMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACTF))
				request.WithQueryParameter("ACTF", m3ACTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACTT))
				request.WithQueryParameter("ACTT", m3ACTT.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelWoElemResponse>(
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
		/// Name SelWoOper
		/// Description Select Work Order Operations with various filter
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STFR">Status FROM</param>
		/// <param name="m3STTO">Status to</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3STD2">Start date</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3FID2">Finish date</param>
		/// <param name="m3RGDT">Entry date</param>
		/// <param name="m3RGD2">Entry date</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3NSTP">Shutdown</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelWoOperResponse></returns>
		/// <exception cref="M3Exception<SelWoOperResponse>"></exception>
		public async Task<M3Response<SelWoOperResponse>> SelWoOper(
			string m3FACI, 
			int? m3CONO = null, 
			string m3STFR = null, 
			string m3STTO = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			DateTime? m3STDT = null, 
			DateTime? m3STD2 = null, 
			DateTime? m3FIDT = null, 
			DateTime? m3FID2 = null, 
			DateTime? m3RGDT = null, 
			DateTime? m3RGD2 = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			string m3CFGL = null, 
			string m3SUFI = null, 
			string m3EVTY = null, 
			int? m3NSTP = null, 
			string m3ORTY = null, 
			string m3PRNO = null, 
			string m3MWNO = null, 
			string m3EMNO = null, 
			string m3CHID = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelWoOper",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STFR))
				request.WithQueryParameter("STFR", m3STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTO))
				request.WithQueryParameter("STTO", m3STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3STD2.HasValue)
				request.WithQueryParameter("STD2", m3STD2.Value.ToM3String());
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3FID2.HasValue)
				request.WithQueryParameter("FID2", m3FID2.Value.ToM3String());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (m3NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3NSTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<SelWoOperResponse>(
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
