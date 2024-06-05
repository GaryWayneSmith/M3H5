/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CloseAllOp
		/// Description Close all operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseAllOp(
			string m3MWNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CloseAllOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim());

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
		/// Description Confirm operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3PEWA">Payroll period</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Confirm(
			string m3FACI, 
			string m3MWNO, 
			int m3OPNO, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			decimal? m3WOSQ = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			int? m3PEWA = null, 
			string m3CHID = null, 
			string m3EMNO = null, 
			string m3PCTP = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEWA.HasValue)
				request.WithQueryParameter("PEWA", m3PEWA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());

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
		/// Name DeleteStartStop
		/// Description Delete Start and Stop Transaction
		/// Version Release: 
		/// </summary>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3OSTM">Start time - operation</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteStartStop(
			string m3EMNO = null, 
			string m3MWNO = null, 
			int? m3OPNO = null, 
			DateTime? m3STDT = null, 
			int? m3OSTM = null, 
			string m3PCTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteStartStop",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3OSTM.HasValue)
				request.WithQueryParameter("OSTM", m3OSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());

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
		/// Name ReportStartStop
		/// Description Report Start and Stop of Operation
		/// Version Release: 
		/// </summary>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3OSTM">Start time - operation</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3OFTM">Stop time operation</param>
		/// <param name="m3UMAT">Used labor run time</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3MAQA">Manufactured quantity</param>
		/// <param name="m3UMAS">Used labor setup time</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="m3INFR">Injury free</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3LCDE">Labor charge code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReportStartStop(
			string m3EMNO = null, 
			string m3MWNO = null, 
			int? m3OPNO = null, 
			DateTime? m3STDT = null, 
			int? m3OSTM = null, 
			DateTime? m3FIDT = null, 
			int? m3OFTM = null, 
			int? m3UMAT = null, 
			int? m3REND = null, 
			string m3PCTP = null, 
			decimal? m3MAQA = null, 
			int? m3UMAS = null, 
			string m3REMK = null, 
			int? m3INFR = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			string m3LCDE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ReportStartStop",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3OSTM.HasValue)
				request.WithQueryParameter("OSTM", m3OSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3OFTM.HasValue)
				request.WithQueryParameter("OFTM", m3OFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UMAT.HasValue)
				request.WithQueryParameter("UMAT", m3UMAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (m3MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3MAQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UMAS.HasValue)
				request.WithQueryParameter("UMAS", m3UMAS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());
			if (m3INFR.HasValue)
				request.WithQueryParameter("INFR", m3INFR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCDE))
				request.WithQueryParameter("LCDE", m3LCDE.Trim());

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
		/// Name ReportTravel
		/// Description Report Start and Stop of Traveltime
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3OSTM">Start time - travel</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3OFTM">Stop time travel</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3MAQA">Manufactured quantity</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="m3INFR">Injury free</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3LCDE">Labor charge code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReportTravel(
			string m3EMNO = null, 
			string m3MWNO = null, 
			int? m3OPNO = null, 
			DateTime? m3STDT = null, 
			int? m3OSTM = null, 
			DateTime? m3FIDT = null, 
			int? m3OFTM = null, 
			int? m3REND = null, 
			string m3PCTP = null, 
			decimal? m3MAQA = null, 
			string m3REMK = null, 
			int? m3INFR = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			string m3LCDE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ReportTravel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3OSTM.HasValue)
				request.WithQueryParameter("OSTM", m3OSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3OFTM.HasValue)
				request.WithQueryParameter("OFTM", m3OFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (m3MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3MAQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());
			if (m3INFR.HasValue)
				request.WithQueryParameter("INFR", m3INFR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCDE))
				request.WithQueryParameter("LCDE", m3LCDE.Trim());

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
		/// Name UpdOperation
		/// Description Update operation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RTM1">Reporting time</param>
		/// <param name="m3RPRE">Responsible for reporting</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3UMAS">Used labor setup time</param>
		/// <param name="m3UMAT">Used labor run time</param>
		/// <param name="m3UPIT">Used machine run time</param>
		/// <param name="m3USET">Used machine setup time</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3MAQA">Manufactured quantity</param>
		/// <param name="m3SCQA">Scrap quantity alternative unit</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3DPLG">Deviating work center</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3FCLA">Failure class</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3DOWT">Downtime</param>
		/// <param name="m3DLY1">Delay time 1</param>
		/// <param name="m3DLY2">Delay time 2</param>
		/// <param name="m3TXL1">Text</param>
		/// <param name="m3TXL2">Text</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3TXID">Text Identity</param>
		/// <param name="m3CLBL">Close Blanket</param>
		/// <param name="m3INFR">Injury free</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="m3LCDE">Labor charge code</param>
		/// <param name="m3IOSX">Interface line suffix</param>
		/// <param name="m3RUDI">Run disturbance</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdOperation(
			string m3MWNO, 
			int m3OPNO, 
			int? m3CONO = null, 
			DateTime? m3RPDT = null, 
			int? m3RTM1 = null, 
			string m3RPRE = null, 
			string m3EMNO = null, 
			int? m3UMAS = null, 
			int? m3UMAT = null, 
			int? m3UPIT = null, 
			int? m3USET = null, 
			int? m3REND = null, 
			decimal? m3MAQA = null, 
			decimal? m3SCQA = null, 
			string m3SCRE = null, 
			string m3DPLG = null, 
			string m3PCTP = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			int? m3DOWT = null, 
			int? m3DLY1 = null, 
			int? m3DLY2 = null, 
			string m3TXL1 = null, 
			string m3TXL2 = null, 
			string m3EQNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			decimal? m3TXID = null, 
			int? m3CLBL = null, 
			int? m3INFR = null, 
			string m3REMK = null, 
			string m3LCDE = null, 
			int? m3IOSX = null, 
			string m3RUDI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdOperation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RTM1.HasValue)
				request.WithQueryParameter("RTM1", m3RTM1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPRE))
				request.WithQueryParameter("RPRE", m3RPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (m3UMAS.HasValue)
				request.WithQueryParameter("UMAS", m3UMAS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UMAT.HasValue)
				request.WithQueryParameter("UMAT", m3UMAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPIT.HasValue)
				request.WithQueryParameter("UPIT", m3UPIT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3USET.HasValue)
				request.WithQueryParameter("USET", m3USET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3MAQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCQA.HasValue)
				request.WithQueryParameter("SCQA", m3SCQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3DPLG))
				request.WithQueryParameter("DPLG", m3DPLG.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (m3DOWT.HasValue)
				request.WithQueryParameter("DOWT", m3DOWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLY1.HasValue)
				request.WithQueryParameter("DLY1", m3DLY1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLY2.HasValue)
				request.WithQueryParameter("DLY2", m3DLY2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXL1))
				request.WithQueryParameter("TXL1", m3TXL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL2))
				request.WithQueryParameter("TXL2", m3TXL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CLBL.HasValue)
				request.WithQueryParameter("CLBL", m3CLBL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INFR.HasValue)
				request.WithQueryParameter("INFR", m3INFR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCDE))
				request.WithQueryParameter("LCDE", m3LCDE.Trim());
			if (m3IOSX.HasValue)
				request.WithQueryParameter("IOSX", m3IOSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RUDI))
				request.WithQueryParameter("RUDI", m3RUDI.Trim());

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
		/// Name UpdOperationSta
		/// Description Update status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3TXID">Text Identity</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdOperationSta(
			string m3MWNO, 
			int m3OPNO, 
			int? m3CONO = null, 
			string m3FCL2 = null, 
			string m3FCLA = null, 
			decimal? m3TXID = null, 
			string m3FCL3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdOperationSta",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());

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
