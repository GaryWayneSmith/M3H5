/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CloseOperation
		/// Description Close Operation
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3PLNO">Production lot number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3PEWA">Payroll period</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseOperation(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			decimal? m3WOSQ = null, 
			long? m3PLNO = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			int? m3PEWA = null, 
			string m3CHID = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CloseOperation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3PLNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEWA.HasValue)
				request.WithQueryParameter("PEWA", m3PEWA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3PLNO">Production lot number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3PEWA">Payroll period</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Confirm(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			decimal? m3WOSQ = null, 
			long? m3PLNO = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			int? m3PEWA = null, 
			string m3CHID = null, 
			int? m3UTCM = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3PLNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEWA.HasValue)
				request.WithQueryParameter("PEWA", m3PEWA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetOperation
		/// Description Get Operation
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3WOSQ">Operation's reporting number</param>
		/// <param name="m3PLNO">Production lot number</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOperationResponse></returns>
		/// <exception cref="M3Exception<GetOperationResponse>"></exception>
		public async Task<M3Response<GetOperationResponse>> GetOperation(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			decimal? m3WOSQ = null, 
			long? m3PLNO = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOperation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3PLNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetOperationResponse>(
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
		/// Name RptOperation
		/// Description Manufacturing Order. Report Operation
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3PLNO">Production lot number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3PEWA">Payroll period</param>
		/// <param name="m3UMAT">Used labor run time</param>
		/// <param name="m3UMAS">Used labor setup time</param>
		/// <param name="m3UPIT">Used machine run time</param>
		/// <param name="m3USET">Used machine setup time</param>
		/// <param name="m3RUDI">Run disturbance</param>
		/// <param name="m3SEDI">Setup disturbance</param>
		/// <param name="m3MAQA">Manufactured quantity</param>
		/// <param name="m3MAUN">Manufacturing U/M</param>
		/// <param name="m3SCQA">Scrap quantity alternative unit</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3SCWC">Scrap source work center</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3SHFC">Shift</param>
		/// <param name="m3MSNO">Resource</param>
		/// <param name="m3TRDT">Transaction date(not used)</param>
		/// <param name="m3TRTM">Transaction time(not used)</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3REWK">Rework</param>
		/// <param name="m3DPLG">Deviating work center</param>
		/// <param name="m3SEPR">Setup price</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3PIPR">Unit price</param>
		/// <param name="m3TODL">Total amount direct labor</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="m3WAFA">Time rate</param>
		/// <param name="m3KIWG">Pay element</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3DSP1">Warning indicator 1</param>
		/// <param name="m3DSP2">Warning indicator 2</param>
		/// <param name="m3DSP3">Warning indicator 3</param>
		/// <param name="m3DSP4">Warning indicator 4</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3DSPA">Create Attribute</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptOperation(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			decimal? m3WOSQ = null, 
			long? m3PLNO = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			int? m3PEWA = null, 
			int? m3UMAT = null, 
			int? m3UMAS = null, 
			int? m3UPIT = null, 
			int? m3USET = null, 
			string m3RUDI = null, 
			string m3SEDI = null, 
			decimal? m3MAQA = null, 
			string m3MAUN = null, 
			decimal? m3SCQA = null, 
			string m3SCRE = null, 
			string m3SCWC = null, 
			int? m3REND = null, 
			string m3EMNO = null, 
			string m3PCTP = null, 
			string m3SHFC = null, 
			string m3MSNO = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			int? m3PRNP = null, 
			int? m3SENP = null, 
			int? m3REWK = null, 
			string m3DPLG = null, 
			decimal? m3SEPR = null, 
			string m3SUNO = null, 
			decimal? m3PIPR = null, 
			decimal? m3TODL = null, 
			string m3REMK = null, 
			decimal? m3WAFA = null, 
			int? m3KIWG = null, 
			string m3CHID = null, 
			int? m3DSP1 = null, 
			int? m3DSP2 = null, 
			int? m3DSP3 = null, 
			int? m3DSP4 = null, 
			string m3CAMU = null, 
			string m3BANO = null, 
			int? m3DSPA = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RptOperation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3PLNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEWA.HasValue)
				request.WithQueryParameter("PEWA", m3PEWA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UMAT.HasValue)
				request.WithQueryParameter("UMAT", m3UMAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UMAS.HasValue)
				request.WithQueryParameter("UMAS", m3UMAS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPIT.HasValue)
				request.WithQueryParameter("UPIT", m3UPIT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3USET.HasValue)
				request.WithQueryParameter("USET", m3USET.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RUDI))
				request.WithQueryParameter("RUDI", m3RUDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEDI))
				request.WithQueryParameter("SEDI", m3SEDI.Trim());
			if (m3MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3MAQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MAUN))
				request.WithQueryParameter("MAUN", m3MAUN.Trim());
			if (m3SCQA.HasValue)
				request.WithQueryParameter("SCQA", m3SCQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCWC))
				request.WithQueryParameter("SCWC", m3SCWC.Trim());
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHFC))
				request.WithQueryParameter("SHFC", m3SHFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSNO))
				request.WithQueryParameter("MSNO", m3MSNO.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REWK.HasValue)
				request.WithQueryParameter("REWK", m3REWK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DPLG))
				request.WithQueryParameter("DPLG", m3DPLG.Trim());
			if (m3SEPR.HasValue)
				request.WithQueryParameter("SEPR", m3SEPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3PIPR.HasValue)
				request.WithQueryParameter("PIPR", m3PIPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TODL.HasValue)
				request.WithQueryParameter("TODL", m3TODL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());
			if (m3WAFA.HasValue)
				request.WithQueryParameter("WAFA", m3WAFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KIWG.HasValue)
				request.WithQueryParameter("KIWG", m3KIWG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3DSP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP3.HasValue)
				request.WithQueryParameter("DSP3", m3DSP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP4.HasValue)
				request.WithQueryParameter("DSP4", m3DSP4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3DSPA.HasValue)
				request.WithQueryParameter("DSPA", m3DSPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
