/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STFR">Status FROM</param>
		/// <param name="m3_STTO">Status to</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STD2">Start date</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_FID2">Finish date</param>
		/// <param name="m3_RGDT">Entry date</param>
		/// <param name="m3_RGD2">Entry date</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_NSTP">Shutdown</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_PLPN">Planned order</param>
		/// <param name="m3_PLPS">Subnumber - planned order</param>
		/// <param name="m3_PLP2">Subnumber - order proposal</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelPlannedResponse></returns>
		/// <exception cref="M3Exception<SelPlannedResponse>"></exception>
		public async Task<M3Response<SelPlannedResponse>> SelPlanned(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_STFR = null, 
			string m3_STTO = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_STD2 = null, 
			DateTime? m3_FIDT = null, 
			DateTime? m3_FID2 = null, 
			DateTime? m3_RGDT = null, 
			DateTime? m3_RGD2 = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			string m3_CFGL = null, 
			string m3_SUFI = null, 
			string m3_EVTY = null, 
			int? m3_NSTP = null, 
			string m3_ORTY = null, 
			string m3_PRNO = null, 
			int? m3_PLPN = null, 
			int? m3_PLPS = null, 
			int? m3_PLP2 = null, 
			string m3_EMNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STFR))
				request.WithQueryParameter("STFR", m3_STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTO))
				request.WithQueryParameter("STTO", m3_STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STD2.HasValue)
				request.WithQueryParameter("STD2", m3_STD2.Value.ToM3String());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_FID2.HasValue)
				request.WithQueryParameter("FID2", m3_FID2.Value.ToM3String());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3_RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (m3_NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3_NSTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (m3_PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3_PLP2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());

			// Execute the request
			var result = await Execute<SelPlannedResponse>(
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
		/// Name SelReleased
		/// Description Select ReleasedWork Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STFR">Status FROM</param>
		/// <param name="m3_STTO">Status to</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STD2">Start date</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_FID2">Finish date</param>
		/// <param name="m3_RGDT">Entry date</param>
		/// <param name="m3_RGD2">Entry date</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_PLPN">Planned order</param>
		/// <param name="m3_PLPS">Subnumber - planned order</param>
		/// <param name="m3_PLP2">Subnumber - order proposal</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelReleasedResponse></returns>
		/// <exception cref="M3Exception<SelReleasedResponse>"></exception>
		public async Task<M3Response<SelReleasedResponse>> SelReleased(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_STFR = null, 
			string m3_STTO = null, 
			string m3_PLGR = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_STD2 = null, 
			DateTime? m3_FIDT = null, 
			DateTime? m3_FID2 = null, 
			DateTime? m3_RGDT = null, 
			DateTime? m3_RGD2 = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			string m3_CFGL = null, 
			string m3_SUFI = null, 
			string m3_EVTY = null, 
			string m3_ORTY = null, 
			string m3_PRNO = null, 
			int? m3_PLPN = null, 
			int? m3_PLPS = null, 
			int? m3_PLP2 = null, 
			string m3_MWNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STFR))
				request.WithQueryParameter("STFR", m3_STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTO))
				request.WithQueryParameter("STTO", m3_STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STD2.HasValue)
				request.WithQueryParameter("STD2", m3_STD2.Value.ToM3String());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_FID2.HasValue)
				request.WithQueryParameter("FID2", m3_FID2.Value.ToM3String());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3_RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (m3_PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3_PLP2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());

			// Execute the request
			var result = await Execute<SelReleasedResponse>(
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
		/// Name SelReqElem
		/// Description Select WO request element for empl.
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STFR">Status FROM</param>
		/// <param name="m3_STTO">Status to</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STD2">Start date</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_FID2">Finish date</param>
		/// <param name="m3_RGDT">Entry date</param>
		/// <param name="m3_RGD2">Entry date</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_NSTP">Shutdown</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_PLPN">Planned order</param>
		/// <param name="m3_PLPS">Subnumber - planned order</param>
		/// <param name="m3_PLP2">Subnumber - order proposal</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_ACTF">Operation element type</param>
		/// <param name="m3_ACTT">Operation element type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelReqElemResponse></returns>
		/// <exception cref="M3Exception<SelReqElemResponse>"></exception>
		public async Task<M3Response<SelReqElemResponse>> SelReqElem(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_STFR = null, 
			string m3_STTO = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_STD2 = null, 
			DateTime? m3_FIDT = null, 
			DateTime? m3_FID2 = null, 
			DateTime? m3_RGDT = null, 
			DateTime? m3_RGD2 = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			string m3_CFGL = null, 
			string m3_SUFI = null, 
			string m3_EVTY = null, 
			int? m3_NSTP = null, 
			string m3_ORTY = null, 
			string m3_PRNO = null, 
			int? m3_PLPN = null, 
			int? m3_PLPS = null, 
			int? m3_PLP2 = null, 
			string m3_EMNO = null, 
			string m3_CHID = null, 
			string m3_RESP = null, 
			string m3_ACTF = null, 
			string m3_ACTT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STFR))
				request.WithQueryParameter("STFR", m3_STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTO))
				request.WithQueryParameter("STTO", m3_STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STD2.HasValue)
				request.WithQueryParameter("STD2", m3_STD2.Value.ToM3String());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_FID2.HasValue)
				request.WithQueryParameter("FID2", m3_FID2.Value.ToM3String());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3_RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (m3_NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3_NSTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (m3_PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3_PLP2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACTF))
				request.WithQueryParameter("ACTF", m3_ACTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACTT))
				request.WithQueryParameter("ACTT", m3_ACTT.Trim());

			// Execute the request
			var result = await Execute<SelReqElemResponse>(
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
		/// Name SelReqOper
		/// Description Select Planned Work Order Operations with various filter
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STFR">Status FROM</param>
		/// <param name="m3_STTO">Status to</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STD2">Start date</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_FID2">Finish date</param>
		/// <param name="m3_RGDT">Entry date</param>
		/// <param name="m3_RGD2">Entry date</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_NSTP">Shutdown</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_PLPN">Planned order</param>
		/// <param name="m3_PLPS">Subnumber - planned order</param>
		/// <param name="m3_PLP2">Subnumber - order proposal</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelReqOperResponse></returns>
		/// <exception cref="M3Exception<SelReqOperResponse>"></exception>
		public async Task<M3Response<SelReqOperResponse>> SelReqOper(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_STFR = null, 
			string m3_STTO = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_STD2 = null, 
			DateTime? m3_FIDT = null, 
			DateTime? m3_FID2 = null, 
			DateTime? m3_RGDT = null, 
			DateTime? m3_RGD2 = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			string m3_CFGL = null, 
			string m3_SUFI = null, 
			string m3_EVTY = null, 
			int? m3_NSTP = null, 
			string m3_ORTY = null, 
			string m3_PRNO = null, 
			int? m3_PLPN = null, 
			int? m3_PLPS = null, 
			int? m3_PLP2 = null, 
			string m3_EMNO = null, 
			string m3_CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelReqOper",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STFR))
				request.WithQueryParameter("STFR", m3_STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTO))
				request.WithQueryParameter("STTO", m3_STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STD2.HasValue)
				request.WithQueryParameter("STD2", m3_STD2.Value.ToM3String());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_FID2.HasValue)
				request.WithQueryParameter("FID2", m3_FID2.Value.ToM3String());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3_RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (m3_NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3_NSTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());
			if (m3_PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3_PLP2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<SelReqOperResponse>(
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
		/// Name SelWoAndReqElem
		/// Description Select Work Order and Request Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STFR">Status FROM</param>
		/// <param name="m3_STTO">Status to</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STD2">Start date</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_FID2">Finish date</param>
		/// <param name="m3_RGDT">Entry date</param>
		/// <param name="m3_RGD2">Entry date</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_NSTP">Shutdown</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelWoAndReqElemResponse></returns>
		/// <exception cref="M3Exception<SelWoAndReqElemResponse>"></exception>
		public async Task<M3Response<SelWoAndReqElemResponse>> SelWoAndReqElem(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_STFR = null, 
			string m3_STTO = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_STD2 = null, 
			DateTime? m3_FIDT = null, 
			DateTime? m3_FID2 = null, 
			DateTime? m3_RGDT = null, 
			DateTime? m3_RGD2 = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			string m3_CFGL = null, 
			string m3_SUFI = null, 
			string m3_EVTY = null, 
			int? m3_NSTP = null, 
			string m3_ORTY = null, 
			string m3_PRNO = null, 
			string m3_MWNO = null, 
			string m3_EMNO = null, 
			string m3_CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelWoAndReqElem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STFR))
				request.WithQueryParameter("STFR", m3_STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTO))
				request.WithQueryParameter("STTO", m3_STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STD2.HasValue)
				request.WithQueryParameter("STD2", m3_STD2.Value.ToM3String());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_FID2.HasValue)
				request.WithQueryParameter("FID2", m3_FID2.Value.ToM3String());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3_RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (m3_NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3_NSTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<SelWoAndReqElemResponse>(
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
		/// Name SelWoAndReqOper
		/// Description Select Work Order and Request Operations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STFR">Status FROM</param>
		/// <param name="m3_STTO">Status to</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STD2">Start date</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_FID2">Finish date</param>
		/// <param name="m3_RGDT">Entry date</param>
		/// <param name="m3_RGD2">Entry date</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_NSTP">Shutdown</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelWoAndReqOperResponse></returns>
		/// <exception cref="M3Exception<SelWoAndReqOperResponse>"></exception>
		public async Task<M3Response<SelWoAndReqOperResponse>> SelWoAndReqOper(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_STFR = null, 
			string m3_STTO = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_STD2 = null, 
			DateTime? m3_FIDT = null, 
			DateTime? m3_FID2 = null, 
			DateTime? m3_RGDT = null, 
			DateTime? m3_RGD2 = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			string m3_CFGL = null, 
			string m3_SUFI = null, 
			string m3_EVTY = null, 
			int? m3_NSTP = null, 
			string m3_ORTY = null, 
			string m3_PRNO = null, 
			string m3_MWNO = null, 
			string m3_EMNO = null, 
			string m3_CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelWoAndReqOper",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STFR))
				request.WithQueryParameter("STFR", m3_STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTO))
				request.WithQueryParameter("STTO", m3_STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STD2.HasValue)
				request.WithQueryParameter("STD2", m3_STD2.Value.ToM3String());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_FID2.HasValue)
				request.WithQueryParameter("FID2", m3_FID2.Value.ToM3String());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3_RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (m3_NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3_NSTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<SelWoAndReqOperResponse>(
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
		/// Name SelWoElem
		/// Description Select WO element for employee
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STFR">Status FROM</param>
		/// <param name="m3_STTO">Status to</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STD2">Start date</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_FID2">Finish date</param>
		/// <param name="m3_RGDT">Entry date</param>
		/// <param name="m3_RGD2">Entry date</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_NSTP">Shutdown</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_STMF">Status mobility</param>
		/// <param name="m3_STMT">Status mobility</param>
		/// <param name="m3_ACTF">Operation element type</param>
		/// <param name="m3_ACTT">Operation element type</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelWoElemResponse></returns>
		/// <exception cref="M3Exception<SelWoElemResponse>"></exception>
		public async Task<M3Response<SelWoElemResponse>> SelWoElem(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_STFR = null, 
			string m3_STTO = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_STD2 = null, 
			DateTime? m3_FIDT = null, 
			DateTime? m3_FID2 = null, 
			DateTime? m3_RGDT = null, 
			DateTime? m3_RGD2 = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			string m3_CFGL = null, 
			string m3_SUFI = null, 
			string m3_EVTY = null, 
			int? m3_NSTP = null, 
			string m3_ORTY = null, 
			string m3_PRNO = null, 
			string m3_MWNO = null, 
			string m3_EMNO = null, 
			string m3_CHID = null, 
			string m3_RESP = null, 
			string m3_STMF = null, 
			string m3_STMT = null, 
			string m3_ACTF = null, 
			string m3_ACTT = null, 
			int? m3_OPNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STFR))
				request.WithQueryParameter("STFR", m3_STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTO))
				request.WithQueryParameter("STTO", m3_STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STD2.HasValue)
				request.WithQueryParameter("STD2", m3_STD2.Value.ToM3String());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_FID2.HasValue)
				request.WithQueryParameter("FID2", m3_FID2.Value.ToM3String());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3_RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (m3_NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3_NSTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STMF))
				request.WithQueryParameter("STMF", m3_STMF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STMT))
				request.WithQueryParameter("STMT", m3_STMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACTF))
				request.WithQueryParameter("ACTF", m3_ACTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACTT))
				request.WithQueryParameter("ACTT", m3_ACTT.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());

			// Execute the request
			var result = await Execute<SelWoElemResponse>(
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
		/// Name SelWoOper
		/// Description Select Work Order Operations with various filter
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STFR">Status FROM</param>
		/// <param name="m3_STTO">Status to</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STD2">Start date</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_FID2">Finish date</param>
		/// <param name="m3_RGDT">Entry date</param>
		/// <param name="m3_RGD2">Entry date</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_NSTP">Shutdown</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelWoOperResponse></returns>
		/// <exception cref="M3Exception<SelWoOperResponse>"></exception>
		public async Task<M3Response<SelWoOperResponse>> SelWoOper(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_STFR = null, 
			string m3_STTO = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_STD2 = null, 
			DateTime? m3_FIDT = null, 
			DateTime? m3_FID2 = null, 
			DateTime? m3_RGDT = null, 
			DateTime? m3_RGD2 = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			string m3_CFGL = null, 
			string m3_SUFI = null, 
			string m3_EVTY = null, 
			int? m3_NSTP = null, 
			string m3_ORTY = null, 
			string m3_PRNO = null, 
			string m3_MWNO = null, 
			string m3_EMNO = null, 
			string m3_CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelWoOper",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STFR))
				request.WithQueryParameter("STFR", m3_STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTO))
				request.WithQueryParameter("STTO", m3_STTO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STD2.HasValue)
				request.WithQueryParameter("STD2", m3_STD2.Value.ToM3String());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_FID2.HasValue)
				request.WithQueryParameter("FID2", m3_FID2.Value.ToM3String());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGD2.HasValue)
				request.WithQueryParameter("RGD2", m3_RGD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (m3_NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3_NSTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<SelWoOperResponse>(
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
