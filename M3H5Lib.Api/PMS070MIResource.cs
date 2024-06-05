/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PMS070MI;
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
	/// Name: PMS070MI
	/// Component Name: ManufacturingOrderRptOperation
	/// Description: Manufacturing Order. Report Operation interface
	/// Version Release: 5ea3
	///</summary>
	public partial class PMS070MIResource : M3BaseResourceEndpoint
	{
		public PMS070MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS070MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CloseOperation
		/// Description Close Operation
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_PLNO">Production lot number</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_PEWA">Payroll period</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseOperation(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
			decimal? m3_WOSQ = null, 
			long? m3_PLNO = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			int? m3_PEWA = null, 
			string m3_CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CloseOperation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (m3_PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3_PLNO.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_PEWA.HasValue)
				request.WithQueryParameter("PEWA", m3_PEWA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_PLNO">Production lot number</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_PEWA">Payroll period</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Confirm(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
			decimal? m3_WOSQ = null, 
			long? m3_PLNO = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			int? m3_PEWA = null, 
			string m3_CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Confirm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (m3_PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3_PLNO.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_PEWA.HasValue)
				request.WithQueryParameter("PEWA", m3_PEWA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
		/// Name GetOperation
		/// Description Get Operation
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_WOSQ">Operation's reporting number</param>
		/// <param name="m3_PLNO">Production lot number</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOperationResponse></returns>
		/// <exception cref="M3Exception<GetOperationResponse>"></exception>
		public async Task<M3Response<GetOperationResponse>> GetOperation(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
			decimal? m3_WOSQ = null, 
			long? m3_PLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOperation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (m3_PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3_PLNO.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<GetOperationResponse>(
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
		/// Name RptOperation
		/// Description Manufacturing Order. Report Operation
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_PLNO">Production lot number</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_PEWA">Payroll period</param>
		/// <param name="m3_UMAT">Used labor run time</param>
		/// <param name="m3_UMAS">Used labor setup time</param>
		/// <param name="m3_UPIT">Used machine run time</param>
		/// <param name="m3_USET">Used machine setup time</param>
		/// <param name="m3_RUDI">Run disturbance</param>
		/// <param name="m3_SEDI">Setup disturbance</param>
		/// <param name="m3_MAQA">Manufactured quantity</param>
		/// <param name="m3_MAUN">Manufacturing U/M</param>
		/// <param name="m3_SCQA">Scrap quantity alternative unit</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_SCWC">Scrap source work center</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_SHFC">Shift</param>
		/// <param name="m3_MSNO">Resource</param>
		/// <param name="m3_TRDT">Transaction date(not used)</param>
		/// <param name="m3_TRTM">Transaction time(not used)</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_REWK">Rework</param>
		/// <param name="m3_DPLG">Deviating work center</param>
		/// <param name="m3_SEPR">Setup price</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_PIPR">Unit price</param>
		/// <param name="m3_TODL">Total amount direct labor</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_WAFA">Time rate</param>
		/// <param name="m3_KIWG">Pay element</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_DSP1">Warning indicator 1</param>
		/// <param name="m3_DSP2">Warning indicator 2</param>
		/// <param name="m3_DSP3">Warning indicator 3</param>
		/// <param name="m3_DSP4">Warning indicator 4</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_DSPA">Create Attribute</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptOperation(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
			decimal? m3_WOSQ = null, 
			long? m3_PLNO = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			int? m3_PEWA = null, 
			int? m3_UMAT = null, 
			int? m3_UMAS = null, 
			int? m3_UPIT = null, 
			int? m3_USET = null, 
			string m3_RUDI = null, 
			string m3_SEDI = null, 
			decimal? m3_MAQA = null, 
			string m3_MAUN = null, 
			decimal? m3_SCQA = null, 
			string m3_SCRE = null, 
			string m3_SCWC = null, 
			int? m3_REND = null, 
			string m3_EMNO = null, 
			string m3_PCTP = null, 
			string m3_SHFC = null, 
			string m3_MSNO = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			int? m3_PRNP = null, 
			int? m3_SENP = null, 
			int? m3_REWK = null, 
			string m3_DPLG = null, 
			decimal? m3_SEPR = null, 
			string m3_SUNO = null, 
			decimal? m3_PIPR = null, 
			decimal? m3_TODL = null, 
			string m3_REMK = null, 
			decimal? m3_WAFA = null, 
			int? m3_KIWG = null, 
			string m3_CHID = null, 
			int? m3_DSP1 = null, 
			int? m3_DSP2 = null, 
			int? m3_DSP3 = null, 
			int? m3_DSP4 = null, 
			string m3_CAMU = null, 
			string m3_BANO = null, 
			int? m3_DSPA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RptOperation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (m3_PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3_PLNO.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_PEWA.HasValue)
				request.WithQueryParameter("PEWA", m3_PEWA.Value.ToString());
			if (m3_UMAT.HasValue)
				request.WithQueryParameter("UMAT", m3_UMAT.Value.ToString());
			if (m3_UMAS.HasValue)
				request.WithQueryParameter("UMAS", m3_UMAS.Value.ToString());
			if (m3_UPIT.HasValue)
				request.WithQueryParameter("UPIT", m3_UPIT.Value.ToString());
			if (m3_USET.HasValue)
				request.WithQueryParameter("USET", m3_USET.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RUDI))
				request.WithQueryParameter("RUDI", m3_RUDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEDI))
				request.WithQueryParameter("SEDI", m3_SEDI.Trim());
			if (m3_MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3_MAQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAUN))
				request.WithQueryParameter("MAUN", m3_MAUN.Trim());
			if (m3_SCQA.HasValue)
				request.WithQueryParameter("SCQA", m3_SCQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCWC))
				request.WithQueryParameter("SCWC", m3_SCWC.Trim());
			if (m3_REND.HasValue)
				request.WithQueryParameter("REND", m3_REND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHFC))
				request.WithQueryParameter("SHFC", m3_SHFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSNO))
				request.WithQueryParameter("MSNO", m3_MSNO.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_REWK.HasValue)
				request.WithQueryParameter("REWK", m3_REWK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DPLG))
				request.WithQueryParameter("DPLG", m3_DPLG.Trim());
			if (m3_SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3_SEPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3_PIPR.Value.ToString());
			if (m3_TODL.HasValue)
				request.WithQueryParameter("TODL", m3_TODL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (m3_WAFA.HasValue)
				request.WithQueryParameter("WAFA", m3_WAFA.Value.ToString());
			if (m3_KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3_KIWG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());
			if (m3_DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3_DSP2.Value.ToString());
			if (m3_DSP3.HasValue)
				request.WithQueryParameter("DSP3", m3_DSP3.Value.ToString());
			if (m3_DSP4.HasValue)
				request.WithQueryParameter("DSP4", m3_DSP4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_DSPA.HasValue)
				request.WithQueryParameter("DSPA", m3_DSPA.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
