/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
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
	/// Name: MOS070MI
	/// Component Name: MaintenanceTimeReport
	/// Description: Maintenance time report interface
	/// Version Release: 5ea1
	///</summary>
	public partial class MOS070MIResource : M3BaseResourceEndpoint
	{
		public MOS070MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS070MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CloseAllOp
		/// Description Close all operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseAllOp(
			string m3_MWNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CloseAllOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim());

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
		/// Description Confirm operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_PEWA">Payroll period</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Confirm(
			string m3_FACI, 
			string m3_MWNO, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			decimal? m3_WOSQ = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			int? m3_PEWA = null, 
			string m3_CHID = null, 
			string m3_EMNO = null, 
			string m3_PCTP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_PEWA.HasValue)
				request.WithQueryParameter("PEWA", m3_PEWA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());

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
		/// Name DeleteStartStop
		/// Description Delete Start and Stop Transaction
		/// Version Release: 
		/// </summary>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_OSTM">Start time - operation</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteStartStop(
			string m3_EMNO = null, 
			string m3_MWNO = null, 
			int? m3_OPNO = null, 
			DateTime? m3_STDT = null, 
			int? m3_OSTM = null, 
			string m3_PCTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteStartStop",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_OSTM.HasValue)
				request.WithQueryParameter("OSTM", m3_OSTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());

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
		/// Name ReportStartStop
		/// Description Report Start and Stop of Operation
		/// Version Release: 
		/// </summary>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_OSTM">Start time - operation</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_OFTM">Stop time operation</param>
		/// <param name="m3_UMAT">Used labor run time</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_MAQA">Manufactured quantity</param>
		/// <param name="m3_UMAS">Used labor setup time</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_INFR">Injury free</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_LCDE">Labor charge code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReportStartStop(
			string m3_EMNO = null, 
			string m3_MWNO = null, 
			int? m3_OPNO = null, 
			DateTime? m3_STDT = null, 
			int? m3_OSTM = null, 
			DateTime? m3_FIDT = null, 
			int? m3_OFTM = null, 
			int? m3_UMAT = null, 
			int? m3_REND = null, 
			string m3_PCTP = null, 
			decimal? m3_MAQA = null, 
			int? m3_UMAS = null, 
			string m3_REMK = null, 
			int? m3_INFR = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			string m3_LCDE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReportStartStop",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_OSTM.HasValue)
				request.WithQueryParameter("OSTM", m3_OSTM.Value.ToString());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_OFTM.HasValue)
				request.WithQueryParameter("OFTM", m3_OFTM.Value.ToString());
			if (m3_UMAT.HasValue)
				request.WithQueryParameter("UMAT", m3_UMAT.Value.ToString());
			if (m3_REND.HasValue)
				request.WithQueryParameter("REND", m3_REND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (m3_MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3_MAQA.Value.ToString());
			if (m3_UMAS.HasValue)
				request.WithQueryParameter("UMAS", m3_UMAS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (m3_INFR.HasValue)
				request.WithQueryParameter("INFR", m3_INFR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCDE))
				request.WithQueryParameter("LCDE", m3_LCDE.Trim());

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
		/// Name ReportTravel
		/// Description Report Start and Stop of Traveltime
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_OSTM">Start time - travel</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_OFTM">Stop time travel</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_MAQA">Manufactured quantity</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_INFR">Injury free</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_LCDE">Labor charge code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReportTravel(
			string m3_EMNO = null, 
			string m3_MWNO = null, 
			int? m3_OPNO = null, 
			DateTime? m3_STDT = null, 
			int? m3_OSTM = null, 
			DateTime? m3_FIDT = null, 
			int? m3_OFTM = null, 
			int? m3_REND = null, 
			string m3_PCTP = null, 
			decimal? m3_MAQA = null, 
			string m3_REMK = null, 
			int? m3_INFR = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			string m3_LCDE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReportTravel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_OSTM.HasValue)
				request.WithQueryParameter("OSTM", m3_OSTM.Value.ToString());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_OFTM.HasValue)
				request.WithQueryParameter("OFTM", m3_OFTM.Value.ToString());
			if (m3_REND.HasValue)
				request.WithQueryParameter("REND", m3_REND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (m3_MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3_MAQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (m3_INFR.HasValue)
				request.WithQueryParameter("INFR", m3_INFR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCDE))
				request.WithQueryParameter("LCDE", m3_LCDE.Trim());

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
		/// Name UpdOperation
		/// Description Update operation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RTM1">Reporting time</param>
		/// <param name="m3_RPRE">Responsible for reporting</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_UMAS">Used labor setup time</param>
		/// <param name="m3_UMAT">Used labor run time</param>
		/// <param name="m3_UPIT">Used machine run time</param>
		/// <param name="m3_USET">Used machine setup time</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_MAQA">Manufactured quantity</param>
		/// <param name="m3_SCQA">Scrap quantity alternative unit</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_DPLG">Deviating work center</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_FCLA">Failure class</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_DOWT">Downtime</param>
		/// <param name="m3_DLY1">Delay time 1</param>
		/// <param name="m3_DLY2">Delay time 2</param>
		/// <param name="m3_TXL1">Text</param>
		/// <param name="m3_TXL2">Text</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_TXID">Text Identity</param>
		/// <param name="m3_CLBL">Close Blanket</param>
		/// <param name="m3_INFR">Injury free</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_LCDE">Labor charge code</param>
		/// <param name="m3_IOSX">Interface line suffix</param>
		/// <param name="m3_RUDI">Run disturbance</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdOperation(
			string m3_MWNO, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RTM1 = null, 
			string m3_RPRE = null, 
			string m3_EMNO = null, 
			int? m3_UMAS = null, 
			int? m3_UMAT = null, 
			int? m3_UPIT = null, 
			int? m3_USET = null, 
			int? m3_REND = null, 
			decimal? m3_MAQA = null, 
			decimal? m3_SCQA = null, 
			string m3_SCRE = null, 
			string m3_DPLG = null, 
			string m3_PCTP = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			int? m3_DOWT = null, 
			int? m3_DLY1 = null, 
			int? m3_DLY2 = null, 
			string m3_TXL1 = null, 
			string m3_TXL2 = null, 
			string m3_EQNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			decimal? m3_TXID = null, 
			int? m3_CLBL = null, 
			int? m3_INFR = null, 
			string m3_REMK = null, 
			string m3_LCDE = null, 
			int? m3_IOSX = null, 
			string m3_RUDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdOperation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RTM1.HasValue)
				request.WithQueryParameter("RTM1", m3_RTM1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPRE))
				request.WithQueryParameter("RPRE", m3_RPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (m3_UMAS.HasValue)
				request.WithQueryParameter("UMAS", m3_UMAS.Value.ToString());
			if (m3_UMAT.HasValue)
				request.WithQueryParameter("UMAT", m3_UMAT.Value.ToString());
			if (m3_UPIT.HasValue)
				request.WithQueryParameter("UPIT", m3_UPIT.Value.ToString());
			if (m3_USET.HasValue)
				request.WithQueryParameter("USET", m3_USET.Value.ToString());
			if (m3_REND.HasValue)
				request.WithQueryParameter("REND", m3_REND.Value.ToString());
			if (m3_MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3_MAQA.Value.ToString());
			if (m3_SCQA.HasValue)
				request.WithQueryParameter("SCQA", m3_SCQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DPLG))
				request.WithQueryParameter("DPLG", m3_DPLG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (m3_DOWT.HasValue)
				request.WithQueryParameter("DOWT", m3_DOWT.Value.ToString());
			if (m3_DLY1.HasValue)
				request.WithQueryParameter("DLY1", m3_DLY1.Value.ToString());
			if (m3_DLY2.HasValue)
				request.WithQueryParameter("DLY2", m3_DLY2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXL1))
				request.WithQueryParameter("TXL1", m3_TXL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL2))
				request.WithQueryParameter("TXL2", m3_TXL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_CLBL.HasValue)
				request.WithQueryParameter("CLBL", m3_CLBL.Value.ToString());
			if (m3_INFR.HasValue)
				request.WithQueryParameter("INFR", m3_INFR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCDE))
				request.WithQueryParameter("LCDE", m3_LCDE.Trim());
			if (m3_IOSX.HasValue)
				request.WithQueryParameter("IOSX", m3_IOSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RUDI))
				request.WithQueryParameter("RUDI", m3_RUDI.Trim());

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
		/// Name UpdOperationSta
		/// Description Update status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_TXID">Text Identity</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdOperationSta(
			string m3_MWNO, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			string m3_FCL2 = null, 
			string m3_FCLA = null, 
			decimal? m3_TXID = null, 
			string m3_FCL3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdOperationSta",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());

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
