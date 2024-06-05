/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_DSP1">Warning indicator 1</param>
		/// <param name="m3_DSP2">Warning indicator 2</param>
		/// <param name="m3_DSP3">Warning indicator 3</param>
		/// <param name="m3_DSP4">Warning indicator 4</param>
		/// <param name="m3_DSP5">Warning indicator 5</param>
		/// <param name="m3_DSP6">Warning indicator 6</param>
		/// <param name="m3_DSP7">Warning indicator 7</param>
		/// <param name="m3_DSP8">Warning indicator 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltIssue(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
			int? m3_MSEQ = null, 
			decimal? m3_WOSQ = null, 
			string m3_MTNO = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			decimal? m3_RPQA = null, 
			string m3_PEUN = null, 
			int? m3_REND = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
			string m3_CHID = null, 
			int? m3_DSP1 = null, 
			int? m3_DSP2 = null, 
			int? m3_DSP3 = null, 
			int? m3_DSP4 = null, 
			int? m3_DSP5 = null, 
			int? m3_DSP6 = null, 
			int? m3_DSP7 = null, 
			int? m3_DSP8 = null, 
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
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3_RPQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (m3_REND.HasValue)
				request.WithQueryParameter("REND", m3_REND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
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
			if (m3_DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3_DSP5.Value.ToString());
			if (m3_DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3_DSP6.Value.ToString());
			if (m3_DSP7.HasValue)
				request.WithQueryParameter("DSP7", m3_DSP7.Value.ToString());
			if (m3_DSP8.HasValue)
				request.WithQueryParameter("DSP8", m3_DSP8.Value.ToString());

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
		/// Name LstAgrBySchedNo
		/// Description List Aggregated WO Material by Schedule No
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SCHN">Schedule number (Required)</param>
		/// <param name="m3_SPMT">Issue method (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrBySchedNoResponse></returns>
		/// <exception cref="M3Exception<LstAgrBySchedNoResponse>"></exception>
		public async Task<M3Response<LstAgrBySchedNoResponse>> LstAgrBySchedNo(
			string m3_FACI, 
			decimal m3_SCHN, 
			int m3_SPMT, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SCHN", m3_SCHN.ToString())
				.WithQueryParameter("SPMT", m3_SPMT.ToString());

			// Execute the request
			var result = await Execute<LstAgrBySchedNoResponse>(
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
		/// Name LstMatBySchedNo
		/// Description List MO Material by Schedule No
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SCHN">Schedule number (Required)</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMatBySchedNoResponse></returns>
		/// <exception cref="M3Exception<LstMatBySchedNoResponse>"></exception>
		public async Task<M3Response<LstMatBySchedNoResponse>> LstMatBySchedNo(
			string m3_FACI, 
			decimal m3_SCHN, 
			int? m3_SPMT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SCHN", m3_SCHN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());

			// Execute the request
			var result = await Execute<LstMatBySchedNoResponse>(
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
		/// Name RptByAgrSchedNo
		/// Description Report Issue By Aggregated Schedule No
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SCHN">Schedule number (Required)</param>
		/// <param name="m3_SPMT">Issue method (Required)</param>
		/// <param name="m3_MTNO">Component number (Required)</param>
		/// <param name="m3_PEUN">Product engineering U/M (Required)</param>
		/// <param name="m3_WMST">Material status (Required)</param>
		/// <param name="m3_RDAT">Reservation date (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ALMT">Allocation method (Required)</param>
		/// <param name="m3_BJNO">Job number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_NWHS">New Location</param>
		/// <param name="m3_NBAN">New Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_DSP1">Warning Indicator 1</param>
		/// <param name="m3_DSP2">Warning Indicator 2</param>
		/// <param name="m3_DSP3">Warning Indicator 3</param>
		/// <param name="m3_DSP4">Warning Indicator 4</param>
		/// <param name="m3_DSP5">Warning Indicator 5</param>
		/// <param name="m3_DSP6">Warning Indicator 6</param>
		/// <param name="m3_DSP9">Warning Indicator 9</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptByAgrSchedNo(
			string m3_FACI, 
			decimal m3_SCHN, 
			int m3_SPMT, 
			string m3_MTNO, 
			string m3_PEUN, 
			string m3_WMST, 
			DateTime m3_RDAT, 
			string m3_WHLO, 
			int m3_ALMT, 
			string m3_BJNO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			decimal? m3_RPQA = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			int? m3_REND = null, 
			string m3_NWHS = null, 
			string m3_NBAN = null, 
			string m3_CAMU = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
			int? m3_DSP1 = null, 
			int? m3_DSP2 = null, 
			int? m3_DSP3 = null, 
			int? m3_DSP4 = null, 
			int? m3_DSP5 = null, 
			int? m3_DSP6 = null, 
			int? m3_DSP9 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_MTNO))
				throw new ArgumentNullException("m3_MTNO");
			if (string.IsNullOrWhiteSpace(m3_PEUN))
				throw new ArgumentNullException("m3_PEUN");
			if (string.IsNullOrWhiteSpace(m3_WMST))
				throw new ArgumentNullException("m3_WMST");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SCHN", m3_SCHN.ToString())
				.WithQueryParameter("SPMT", m3_SPMT.ToString())
				.WithQueryParameter("MTNO", m3_MTNO.Trim())
				.WithQueryParameter("PEUN", m3_PEUN.Trim())
				.WithQueryParameter("WMST", m3_WMST.Trim())
				.WithQueryParameter("RDAT", m3_RDAT.ToM3String())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ALMT", m3_ALMT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BJNO))
				request.WithQueryParameter("BJNO", m3_BJNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3_RPQA.Value.ToString());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_REND.HasValue)
				request.WithQueryParameter("REND", m3_REND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NWHS))
				request.WithQueryParameter("NWHS", m3_NWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NBAN))
				request.WithQueryParameter("NBAN", m3_NBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());
			if (m3_DSP2.HasValue)
				request.WithQueryParameter("DSP2", m3_DSP2.Value.ToString());
			if (m3_DSP3.HasValue)
				request.WithQueryParameter("DSP3", m3_DSP3.Value.ToString());
			if (m3_DSP4.HasValue)
				request.WithQueryParameter("DSP4", m3_DSP4.Value.ToString());
			if (m3_DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3_DSP5.Value.ToString());
			if (m3_DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3_DSP6.Value.ToString());
			if (m3_DSP9.HasValue)
				request.WithQueryParameter("DSP9", m3_DSP9.Value.ToString());

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
		/// Name RptIssue
		/// Description Manufacturing Order. Report stock issue
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_MFNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_RPTM">Reporting time</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3_PEUN">Product engineering U/M</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="m3_DSP1">Warning indicator 1</param>
		/// <param name="m3_DSP2">Warning indicator 2</param>
		/// <param name="m3_DSP3">Warning indicator 3</param>
		/// <param name="m3_DSP4">Warning indicator 4</param>
		/// <param name="m3_DSP5">Warning indicator 5</param>
		/// <param name="m3_DSP6">Warning indicator 6</param>
		/// <param name="m3_DSP7">Warning indicator 7</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptIssue(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_MFNO = null, 
			int? m3_OPNO = null, 
			int? m3_MSEQ = null, 
			decimal? m3_WOSQ = null, 
			string m3_MTNO = null, 
			DateTime? m3_RPDT = null, 
			int? m3_RPTM = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			decimal? m3_RPQA = null, 
			string m3_PEUN = null, 
			int? m3_REND = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			decimal? m3_CAWE = null, 
			string m3_CHID = null, 
			int? m3_DSP1 = null, 
			int? m3_DSP2 = null, 
			int? m3_DSP3 = null, 
			int? m3_DSP4 = null, 
			int? m3_DSP5 = null, 
			int? m3_DSP6 = null, 
			int? m3_DSP7 = null, 
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
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_RPTM.HasValue)
				request.WithQueryParameter("RPTM", m3_RPTM.Value.ToString());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3_RPQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PEUN))
				request.WithQueryParameter("PEUN", m3_PEUN.Trim());
			if (m3_REND.HasValue)
				request.WithQueryParameter("REND", m3_REND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
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
			if (m3_DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3_DSP5.Value.ToString());
			if (m3_DSP6.HasValue)
				request.WithQueryParameter("DSP6", m3_DSP6.Value.ToString());
			if (m3_DSP7.HasValue)
				request.WithQueryParameter("DSP7", m3_DSP7.Value.ToString());

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
