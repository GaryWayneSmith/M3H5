/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.PMS060MI;
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
	/// Name: PMS060MI
	/// Component Name: ManufacturingOrderRptIssue
	/// Description: Manufacturing order. Report issue interface
	/// Version Release: 5ea1
	///</summary>
	public partial class PMS060MIResource : M3BaseResourceEndpoint
	{
		public PMS060MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS060MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DltIssue
		/// Description Manufacturing Order. Delete stock issue
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3DSP1">Warning indicator 1</param>
		/// <param name="m3DSP2">Warning indicator 2</param>
		/// <param name="m3DSP3">Warning indicator 3</param>
		/// <param name="m3DSP4">Warning indicator 4</param>
		/// <param name="m3DSP5">Warning indicator 5</param>
		/// <param name="m3DSP6">Warning indicator 6</param>
		/// <param name="m3DSP7">Warning indicator 7</param>
		/// <param name="m3DSP8">Warning indicator 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltIssue(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			int? m3MSEQ = null, 
			decimal? m3WOSQ = null, 
			string m3MTNO = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			decimal? m3RPQA = null, 
			string m3PEUN = null, 
			int? m3REND = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
			string m3CHID = null, 
			int? m3DSP1 = null, 
			int? m3DSP2 = null, 
			int? m3DSP3 = null, 
			int? m3DSP4 = null, 
			int? m3DSP5 = null, 
			int? m3DSP6 = null, 
			int? m3DSP7 = null, 
			int? m3DSP8 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltIssue",
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
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3RPQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3DSP5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3DSP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP7.HasValue)
				request.WithQueryParameter("DSP7", m3DSP7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP8.HasValue)
				request.WithQueryParameter("DSP8", m3DSP8.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name LstAgrBySchedNo
		/// Description List Aggregated WO Material by Schedule No
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SCHN">Schedule number (Required)</param>
		/// <param name="m3SPMT">Issue method (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrBySchedNoResponse></returns>
		/// <exception cref="M3Exception<LstAgrBySchedNoResponse>"></exception>
		public async Task<M3Response<LstAgrBySchedNoResponse>> LstAgrBySchedNo(
			string m3FACI, 
			decimal m3SCHN, 
			int m3SPMT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrBySchedNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SCHN", m3SCHN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SPMT", m3SPMT.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAgrBySchedNoResponse>(
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
		/// Name LstMatBySchedNo
		/// Description List MO Material by Schedule No
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SCHN">Schedule number (Required)</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMatBySchedNoResponse></returns>
		/// <exception cref="M3Exception<LstMatBySchedNoResponse>"></exception>
		public async Task<M3Response<LstMatBySchedNoResponse>> LstMatBySchedNo(
			string m3FACI, 
			decimal m3SCHN, 
			int? m3SPMT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMatBySchedNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SCHN", m3SCHN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstMatBySchedNoResponse>(
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
		/// Name RptByAgrSchedNo
		/// Description Report Issue By Aggregated Schedule No
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SCHN">Schedule number (Required)</param>
		/// <param name="m3SPMT">Issue method (Required)</param>
		/// <param name="m3MTNO">Component number (Required)</param>
		/// <param name="m3PEUN">Product engineering U/M (Required)</param>
		/// <param name="m3WMST">Material status (Required)</param>
		/// <param name="m3RDAT">Reservation date (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ALMT">Allocation method (Required)</param>
		/// <param name="m3BJNO">Job number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3NWHS">New Location</param>
		/// <param name="m3NBAN">New Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3DSP1">Warning Indicator 1</param>
		/// <param name="m3DSP2">Warning Indicator 2</param>
		/// <param name="m3DSP3">Warning Indicator 3</param>
		/// <param name="m3DSP4">Warning Indicator 4</param>
		/// <param name="m3DSP5">Warning Indicator 5</param>
		/// <param name="m3DSP6">Warning Indicator 6</param>
		/// <param name="m3DSP9">Warning Indicator 9</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptByAgrSchedNo(
			string m3FACI, 
			decimal m3SCHN, 
			int m3SPMT, 
			string m3MTNO, 
			string m3PEUN, 
			string m3WMST, 
			DateTime m3RDAT, 
			string m3WHLO, 
			int m3ALMT, 
			string m3BJNO = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			decimal? m3RPQA = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			int? m3REND = null, 
			string m3NWHS = null, 
			string m3NBAN = null, 
			string m3CAMU = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
			int? m3DSP1 = null, 
			int? m3DSP2 = null, 
			int? m3DSP3 = null, 
			int? m3DSP4 = null, 
			int? m3DSP5 = null, 
			int? m3DSP6 = null, 
			int? m3DSP9 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RptByAgrSchedNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3MTNO))
				throw new ArgumentNullException(nameof(m3MTNO));
			if (string.IsNullOrWhiteSpace(m3PEUN))
				throw new ArgumentNullException(nameof(m3PEUN));
			if (string.IsNullOrWhiteSpace(m3WMST))
				throw new ArgumentNullException(nameof(m3WMST));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SCHN", m3SCHN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SPMT", m3SPMT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MTNO", m3MTNO.Trim())
				.WithQueryParameter("PEUN", m3PEUN.Trim())
				.WithQueryParameter("WMST", m3WMST.Trim())
				.WithQueryParameter("RDAT", m3RDAT.ToM3String())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ALMT", m3ALMT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BJNO))
				request.WithQueryParameter("BJNO", m3BJNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3RPQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NWHS))
				request.WithQueryParameter("NWHS", m3NWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3NBAN))
				request.WithQueryParameter("NBAN", m3NBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3DSP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP3.HasValue)
				request.WithQueryParameter("DSP3", m3DSP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP4.HasValue)
				request.WithQueryParameter("DSP4", m3DSP4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3DSP5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3DSP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP9.HasValue)
				request.WithQueryParameter("DSP9", m3DSP9.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name RptIssue
		/// Description Manufacturing Order. Report stock issue
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3MFNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3RPDT">Reporting date</param>
		/// <param name="m3RPTM">Reporting time</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3PEUN">Product engineering U/M</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="m3DSP1">Warning indicator 1</param>
		/// <param name="m3DSP2">Warning indicator 2</param>
		/// <param name="m3DSP3">Warning indicator 3</param>
		/// <param name="m3DSP4">Warning indicator 4</param>
		/// <param name="m3DSP5">Warning indicator 5</param>
		/// <param name="m3DSP6">Warning indicator 6</param>
		/// <param name="m3DSP7">Warning indicator 7</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptIssue(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3MFNO = null, 
			int? m3OPNO = null, 
			int? m3MSEQ = null, 
			decimal? m3WOSQ = null, 
			string m3MTNO = null, 
			DateTime? m3RPDT = null, 
			int? m3RPTM = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			decimal? m3RPQA = null, 
			string m3PEUN = null, 
			int? m3REND = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			decimal? m3CAWE = null, 
			string m3CHID = null, 
			int? m3DSP1 = null, 
			int? m3DSP2 = null, 
			int? m3DSP3 = null, 
			int? m3DSP4 = null, 
			int? m3DSP5 = null, 
			int? m3DSP6 = null, 
			int? m3DSP7 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RptIssue",
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
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3RPTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3RPQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PEUN))
				request.WithQueryParameter("PEUN", m3PEUN.Trim());
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3DSP5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3DSP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP7.HasValue)
				request.WithQueryParameter("DSP7", m3DSP7.Value.ToString(CultureInfo.CurrentCulture));

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
