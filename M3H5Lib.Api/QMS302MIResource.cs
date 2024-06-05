/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QMS302MI;
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
	/// Name: QMS302MI
	/// Component Name: QI Request Spec Test
	/// Description: Api: QI Request Spec Test
	/// Version Release: 5ea3
	///</summary>
	public partial class QMS302MIResource : M3BaseResourceEndpoint
	{
		public QMS302MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS302MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTesttoQIReq
		/// Description Standard transaction to update test to a Spec in the QI req
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QRID">Request ID (Required)</param>
		/// <param name="m3_SPEC">Specification (Required)</param>
		/// <param name="m3_QSE1">Effective date (Required)</param>
		/// <param name="m3_QSE2">Effective time (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_QTE1">Effective date (Required)</param>
		/// <param name="m3_QTE2">Effective time (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_EXSQ">Test order</param>
		/// <param name="m3_MSUR">Measurement method</param>
		/// <param name="m3_MSIN">Measurement instrument</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_SMTP">Sample type</param>
		/// <param name="m3_INSD">Industry standard</param>
		/// <param name="m3_VLTP">Value setup</param>
		/// <param name="m3_QLCD">Test result</param>
		/// <param name="m3_QOP1">Expected operator</param>
		/// <param name="m3_QOP2">External operator</param>
		/// <param name="m3_QOP3">Alarm operator</param>
		/// <param name="m3_EVMX">Expected value max</param>
		/// <param name="m3_EVMN">Expected value min</param>
		/// <param name="m3_EXMX">External lab max</param>
		/// <param name="m3_EXMN">External lab min</param>
		/// <param name="m3_ALMX">Alarm limit max</param>
		/// <param name="m3_ALMN">Alarm limit min</param>
		/// <param name="m3_EVTG">Expected target value</param>
		/// <param name="m3_TVTG">External target value</param>
		/// <param name="m3_AVTG">Alarm target value</param>
		/// <param name="m3_REQD">Required</param>
		/// <param name="m3_SMPR">Sampling required</param>
		/// <param name="m3_SMSZ">Sample size</param>
		/// <param name="m3_SMUM">Sample U/M</param>
		/// <param name="m3_DSSM">Discard sample</param>
		/// <param name="m3_RTSM">Retain sample</param>
		/// <param name="m3_QTSP">Test priority</param>
		/// <param name="m3_PTCA">Print test on Certificate of Analysis</param>
		/// <param name="m3_QPTR">Print result value</param>
		/// <param name="m3_QPTT">Print spec test values</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTesttoQIReq(
			string m3_QRID, 
			string m3_SPEC, 
			DateTime m3_QSE1, 
			int m3_QSE2, 
			string m3_QTST, 
			DateTime m3_QTE1, 
			int m3_QTE2, 
			int m3_TSTY, 
			string m3_FACI = null, 
			int? m3_EXSQ = null, 
			string m3_MSUR = null, 
			string m3_MSIN = null, 
			string m3_DEPT = null, 
			string m3_SMTP = null, 
			string m3_INSD = null, 
			int? m3_VLTP = null, 
			string m3_QLCD = null, 
			int? m3_QOP1 = null, 
			int? m3_QOP2 = null, 
			int? m3_QOP3 = null, 
			decimal? m3_EVMX = null, 
			decimal? m3_EVMN = null, 
			decimal? m3_EXMX = null, 
			decimal? m3_EXMN = null, 
			decimal? m3_ALMX = null, 
			decimal? m3_ALMN = null, 
			decimal? m3_EVTG = null, 
			decimal? m3_TVTG = null, 
			decimal? m3_AVTG = null, 
			int? m3_REQD = null, 
			int? m3_SMPR = null, 
			decimal? m3_SMSZ = null, 
			string m3_SMUM = null, 
			int? m3_DSSM = null, 
			int? m3_RTSM = null, 
			int? m3_QTSP = null, 
			int? m3_PTCA = null, 
			int? m3_QPTR = null, 
			int? m3_QPTT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTesttoQIReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QRID))
				throw new ArgumentNullException("m3_QRID");
			if (string.IsNullOrWhiteSpace(m3_SPEC))
				throw new ArgumentNullException("m3_SPEC");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("QRID", m3_QRID.Trim())
				.WithQueryParameter("SPEC", m3_SPEC.Trim())
				.WithQueryParameter("QSE1", m3_QSE1.ToM3String())
				.WithQueryParameter("QSE2", m3_QSE2.ToString())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("QTE1", m3_QTE1.ToM3String())
				.WithQueryParameter("QTE2", m3_QTE2.ToString())
				.WithQueryParameter("TSTY", m3_TSTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_EXSQ.HasValue)
				request.WithQueryParameter("EXSQ", m3_EXSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSUR))
				request.WithQueryParameter("MSUR", m3_MSUR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSIN))
				request.WithQueryParameter("MSIN", m3_MSIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMTP))
				request.WithQueryParameter("SMTP", m3_SMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSD))
				request.WithQueryParameter("INSD", m3_INSD.Trim());
			if (m3_VLTP.HasValue)
				request.WithQueryParameter("VLTP", m3_VLTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLCD))
				request.WithQueryParameter("QLCD", m3_QLCD.Trim());
			if (m3_QOP1.HasValue)
				request.WithQueryParameter("QOP1", m3_QOP1.Value.ToString());
			if (m3_QOP2.HasValue)
				request.WithQueryParameter("QOP2", m3_QOP2.Value.ToString());
			if (m3_QOP3.HasValue)
				request.WithQueryParameter("QOP3", m3_QOP3.Value.ToString());
			if (m3_EVMX.HasValue)
				request.WithQueryParameter("EVMX", m3_EVMX.Value.ToString());
			if (m3_EVMN.HasValue)
				request.WithQueryParameter("EVMN", m3_EVMN.Value.ToString());
			if (m3_EXMX.HasValue)
				request.WithQueryParameter("EXMX", m3_EXMX.Value.ToString());
			if (m3_EXMN.HasValue)
				request.WithQueryParameter("EXMN", m3_EXMN.Value.ToString());
			if (m3_ALMX.HasValue)
				request.WithQueryParameter("ALMX", m3_ALMX.Value.ToString());
			if (m3_ALMN.HasValue)
				request.WithQueryParameter("ALMN", m3_ALMN.Value.ToString());
			if (m3_EVTG.HasValue)
				request.WithQueryParameter("EVTG", m3_EVTG.Value.ToString());
			if (m3_TVTG.HasValue)
				request.WithQueryParameter("TVTG", m3_TVTG.Value.ToString());
			if (m3_AVTG.HasValue)
				request.WithQueryParameter("AVTG", m3_AVTG.Value.ToString());
			if (m3_REQD.HasValue)
				request.WithQueryParameter("REQD", m3_REQD.Value.ToString());
			if (m3_SMPR.HasValue)
				request.WithQueryParameter("SMPR", m3_SMPR.Value.ToString());
			if (m3_SMSZ.HasValue)
				request.WithQueryParameter("SMSZ", m3_SMSZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SMUM))
				request.WithQueryParameter("SMUM", m3_SMUM.Trim());
			if (m3_DSSM.HasValue)
				request.WithQueryParameter("DSSM", m3_DSSM.Value.ToString());
			if (m3_RTSM.HasValue)
				request.WithQueryParameter("RTSM", m3_RTSM.Value.ToString());
			if (m3_QTSP.HasValue)
				request.WithQueryParameter("QTSP", m3_QTSP.Value.ToString());
			if (m3_PTCA.HasValue)
				request.WithQueryParameter("PTCA", m3_PTCA.Value.ToString());
			if (m3_QPTR.HasValue)
				request.WithQueryParameter("QPTR", m3_QPTR.Value.ToString());
			if (m3_QPTT.HasValue)
				request.WithQueryParameter("QPTT", m3_QPTT.Value.ToString());

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
		/// Name DltTestQIReq
		/// Description Delete QI request spec test
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SPEC">Specification (Required)</param>
		/// <param name="m3_QSE1">Effective date (Required)</param>
		/// <param name="m3_QSE2">Effective time (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_QTE1">Effective date (Required)</param>
		/// <param name="m3_QTE2">Effective time (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltTestQIReq(
			string m3_FACI, 
			string m3_SPEC, 
			DateTime m3_QSE1, 
			int m3_QSE2, 
			string m3_QTST, 
			DateTime m3_QTE1, 
			int m3_QTE2, 
			int m3_TSTY, 
			string m3_QRID = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltTestQIReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SPEC))
				throw new ArgumentNullException("m3_SPEC");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SPEC", m3_SPEC.Trim())
				.WithQueryParameter("QSE1", m3_QSE1.ToM3String())
				.WithQueryParameter("QSE2", m3_QSE2.ToString())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("QTE1", m3_QTE1.ToM3String())
				.WithQueryParameter("QTE2", m3_QTE2.ToString())
				.WithQueryParameter("TSTY", m3_TSTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

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
		/// Name GetTestQIReq
		/// Description Standard list details from QI request spec test
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SPEC">Specification (Required)</param>
		/// <param name="m3_QSE1">Effective date (Required)</param>
		/// <param name="m3_QSE2">Effective time (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_QTE1">Effective date (Required)</param>
		/// <param name="m3_QTE2">Effective time (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTestQIReqResponse></returns>
		/// <exception cref="M3Exception<GetTestQIReqResponse>"></exception>
		public async Task<M3Response<GetTestQIReqResponse>> GetTestQIReq(
			string m3_FACI, 
			string m3_SPEC, 
			DateTime m3_QSE1, 
			int m3_QSE2, 
			string m3_QTST, 
			DateTime m3_QTE1, 
			int m3_QTE2, 
			int m3_TSTY, 
			string m3_QRID = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTestQIReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SPEC))
				throw new ArgumentNullException("m3_SPEC");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SPEC", m3_SPEC.Trim())
				.WithQueryParameter("QSE1", m3_QSE1.ToM3String())
				.WithQueryParameter("QSE2", m3_QSE2.ToString())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("QTE1", m3_QTE1.ToM3String())
				.WithQueryParameter("QTE2", m3_QTE2.ToString())
				.WithQueryParameter("TSTY", m3_TSTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<GetTestQIReqResponse>(
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
		/// Name LstTestQIReq
		/// Description Standard list details from QI request spec test
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SPEC">Specification (Required)</param>
		/// <param name="m3_QSE1">Effective date (Required)</param>
		/// <param name="m3_QSE2">Effective time (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_QTE1">Effective date (Required)</param>
		/// <param name="m3_QTE2">Effective time (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTestQIReqResponse></returns>
		/// <exception cref="M3Exception<LstTestQIReqResponse>"></exception>
		public async Task<M3Response<LstTestQIReqResponse>> LstTestQIReq(
			string m3_FACI, 
			string m3_SPEC, 
			DateTime m3_QSE1, 
			int m3_QSE2, 
			string m3_QTST, 
			DateTime m3_QTE1, 
			int m3_QTE2, 
			int m3_TSTY, 
			string m3_QRID = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTestQIReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SPEC))
				throw new ArgumentNullException("m3_SPEC");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SPEC", m3_SPEC.Trim())
				.WithQueryParameter("QSE1", m3_QSE1.ToM3String())
				.WithQueryParameter("QSE2", m3_QSE2.ToString())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("QTE1", m3_QTE1.ToM3String())
				.WithQueryParameter("QTE2", m3_QTE2.ToString())
				.WithQueryParameter("TSTY", m3_TSTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<LstTestQIReqResponse>(
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
		/// Name LstTestsByRange
		/// Description List QI Request Spec tests by Status and Tested date range
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SPEC">Specification (Required)</param>
		/// <param name="m3_QSE1">Effective date (Required)</param>
		/// <param name="m3_QSE2">Effective time (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_QTE1">Effective date (Required)</param>
		/// <param name="m3_QTE2">Effective time (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_TSTT">Test status</param>
		/// <param name="m3_FTDT">From test date</param>
		/// <param name="m3_FTTE">From test time</param>
		/// <param name="m3_TTDT">To test date</param>
		/// <param name="m3_TTTE">To test time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTestsByRangeResponse></returns>
		/// <exception cref="M3Exception<LstTestsByRangeResponse>"></exception>
		public async Task<M3Response<LstTestsByRangeResponse>> LstTestsByRange(
			string m3_FACI, 
			string m3_SPEC, 
			DateTime m3_QSE1, 
			int m3_QSE2, 
			string m3_QTST, 
			DateTime m3_QTE1, 
			int m3_QTE2, 
			int m3_TSTY, 
			string m3_QRID = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			int? m3_TSTT = null, 
			DateTime? m3_FTDT = null, 
			int? m3_FTTE = null, 
			DateTime? m3_TTDT = null, 
			int? m3_TTTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTestsByRange",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SPEC))
				throw new ArgumentNullException("m3_SPEC");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SPEC", m3_SPEC.Trim())
				.WithQueryParameter("QSE1", m3_QSE1.ToM3String())
				.WithQueryParameter("QSE2", m3_QSE2.ToString())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("QTE1", m3_QTE1.ToM3String())
				.WithQueryParameter("QTE2", m3_QTE2.ToString())
				.WithQueryParameter("TSTY", m3_TSTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_TSTT.HasValue)
				request.WithQueryParameter("TSTT", m3_TSTT.Value.ToString());
			if (m3_FTDT.HasValue)
				request.WithQueryParameter("FTDT", m3_FTDT.Value.ToM3String());
			if (m3_FTTE.HasValue)
				request.WithQueryParameter("FTTE", m3_FTTE.Value.ToString());
			if (m3_TTDT.HasValue)
				request.WithQueryParameter("TTDT", m3_TTDT.Value.ToM3String());
			if (m3_TTTE.HasValue)
				request.WithQueryParameter("TTTE", m3_TTTE.Value.ToString());

			// Execute the request
			var result = await Execute<LstTestsByRangeResponse>(
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
		/// Name LstTstQRIDByLab
		/// Description List QI Request spec tests by laboratory
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_QRID">Request ID (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_QTST">Test</param>
		/// <param name="m3_QTE1">Effective date</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="m3_TSTY">Test type</param>
		/// <param name="m3_LABO">Laboratory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTstQRIDByLabResponse></returns>
		/// <exception cref="M3Exception<LstTstQRIDByLabResponse>"></exception>
		public async Task<M3Response<LstTstQRIDByLabResponse>> LstTstQRIDByLab(
			string m3_FACI, 
			string m3_QRID, 
			string m3_ITNO, 
			string m3_BANO, 
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_QTST = null, 
			DateTime? m3_QTE1 = null, 
			int? m3_QTE2 = null, 
			int? m3_TSTY = null, 
			string m3_LABO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTstQRIDByLab",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_QRID))
				throw new ArgumentNullException("m3_QRID");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("QRID", m3_QRID.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QTST))
				request.WithQueryParameter("QTST", m3_QTST.Trim());
			if (m3_QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3_QTE1.Value.ToM3String());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());
			if (m3_TSTY.HasValue)
				request.WithQueryParameter("TSTY", m3_TSTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LABO))
				request.WithQueryParameter("LABO", m3_LABO.Trim());

			// Execute the request
			var result = await Execute<LstTstQRIDByLabResponse>(
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
		/// Name UpdTesttoQIReq
		/// Description Standard transaction to update test to a Spec in the QI req
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_QRID">Request ID (Required)</param>
		/// <param name="m3_SPEC">Specification (Required)</param>
		/// <param name="m3_QSE1">Effective date (Required)</param>
		/// <param name="m3_QSE2">Effective time (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_QTE1">Effective date (Required)</param>
		/// <param name="m3_QTE2">Effective time (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_EXSQ">Test order</param>
		/// <param name="m3_MSUR">Measurement method</param>
		/// <param name="m3_MSIN">Measurement instrument</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_SMTP">Sample type</param>
		/// <param name="m3_INSD">Industry standard</param>
		/// <param name="m3_VLTP">Value setup</param>
		/// <param name="m3_QLCD">Test result</param>
		/// <param name="m3_QOP1">Expected operator</param>
		/// <param name="m3_QOP2">External operator</param>
		/// <param name="m3_QOP3">Alarm operator</param>
		/// <param name="m3_EVMX">Expected value max</param>
		/// <param name="m3_EVMN">Expected value min</param>
		/// <param name="m3_EXMX">External lab max</param>
		/// <param name="m3_EXMN">External lab min</param>
		/// <param name="m3_ALMX">Alarm limit max</param>
		/// <param name="m3_ALMN">Alarm limit min</param>
		/// <param name="m3_EVTG">Expected target value</param>
		/// <param name="m3_TVTG">External target value</param>
		/// <param name="m3_AVTG">Alarm target value</param>
		/// <param name="m3_REQD">Required</param>
		/// <param name="m3_SMPR">Sampling required</param>
		/// <param name="m3_SMSZ">Sample size</param>
		/// <param name="m3_SMUM">Sample U/M</param>
		/// <param name="m3_DSSM">Discard sample</param>
		/// <param name="m3_RTSM">Retain sample</param>
		/// <param name="m3_QTSP">Test priority</param>
		/// <param name="m3_OVDT">Overrided date</param>
		/// <param name="m3_OVTE">Overrided time</param>
		/// <param name="m3_OVUS">Overrided by</param>
		/// <param name="m3_PVST">Prior status</param>
		/// <param name="m3_QRSN">Reason</param>
		/// <param name="m3_DQTY">Defective quantity</param>
		/// <param name="m3_TSTT">Specification test status</param>
		/// <param name="m3_PTCA">Print test on Certificate of Analysis</param>
		/// <param name="m3_QPTT">Print spec test values</param>
		/// <param name="m3_QPTR">Print result value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTesttoQIReq(
			string m3_FACI, 
			string m3_QRID, 
			string m3_SPEC, 
			DateTime m3_QSE1, 
			int m3_QSE2, 
			string m3_QTST, 
			DateTime m3_QTE1, 
			int m3_QTE2, 
			int m3_TSTY, 
			int? m3_EXSQ = null, 
			string m3_MSUR = null, 
			string m3_MSIN = null, 
			string m3_DEPT = null, 
			string m3_SMTP = null, 
			string m3_INSD = null, 
			int? m3_VLTP = null, 
			string m3_QLCD = null, 
			int? m3_QOP1 = null, 
			int? m3_QOP2 = null, 
			int? m3_QOP3 = null, 
			decimal? m3_EVMX = null, 
			decimal? m3_EVMN = null, 
			decimal? m3_EXMX = null, 
			decimal? m3_EXMN = null, 
			decimal? m3_ALMX = null, 
			decimal? m3_ALMN = null, 
			decimal? m3_EVTG = null, 
			decimal? m3_TVTG = null, 
			decimal? m3_AVTG = null, 
			int? m3_REQD = null, 
			int? m3_SMPR = null, 
			decimal? m3_SMSZ = null, 
			string m3_SMUM = null, 
			int? m3_DSSM = null, 
			int? m3_RTSM = null, 
			int? m3_QTSP = null, 
			DateTime? m3_OVDT = null, 
			int? m3_OVTE = null, 
			string m3_OVUS = null, 
			int? m3_PVST = null, 
			string m3_QRSN = null, 
			decimal? m3_DQTY = null, 
			int? m3_TSTT = null, 
			int? m3_PTCA = null, 
			int? m3_QPTT = null, 
			int? m3_QPTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTesttoQIReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_QRID))
				throw new ArgumentNullException("m3_QRID");
			if (string.IsNullOrWhiteSpace(m3_SPEC))
				throw new ArgumentNullException("m3_SPEC");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("QRID", m3_QRID.Trim())
				.WithQueryParameter("SPEC", m3_SPEC.Trim())
				.WithQueryParameter("QSE1", m3_QSE1.ToM3String())
				.WithQueryParameter("QSE2", m3_QSE2.ToString())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("QTE1", m3_QTE1.ToM3String())
				.WithQueryParameter("QTE2", m3_QTE2.ToString())
				.WithQueryParameter("TSTY", m3_TSTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_EXSQ.HasValue)
				request.WithQueryParameter("EXSQ", m3_EXSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSUR))
				request.WithQueryParameter("MSUR", m3_MSUR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSIN))
				request.WithQueryParameter("MSIN", m3_MSIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMTP))
				request.WithQueryParameter("SMTP", m3_SMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSD))
				request.WithQueryParameter("INSD", m3_INSD.Trim());
			if (m3_VLTP.HasValue)
				request.WithQueryParameter("VLTP", m3_VLTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLCD))
				request.WithQueryParameter("QLCD", m3_QLCD.Trim());
			if (m3_QOP1.HasValue)
				request.WithQueryParameter("QOP1", m3_QOP1.Value.ToString());
			if (m3_QOP2.HasValue)
				request.WithQueryParameter("QOP2", m3_QOP2.Value.ToString());
			if (m3_QOP3.HasValue)
				request.WithQueryParameter("QOP3", m3_QOP3.Value.ToString());
			if (m3_EVMX.HasValue)
				request.WithQueryParameter("EVMX", m3_EVMX.Value.ToString());
			if (m3_EVMN.HasValue)
				request.WithQueryParameter("EVMN", m3_EVMN.Value.ToString());
			if (m3_EXMX.HasValue)
				request.WithQueryParameter("EXMX", m3_EXMX.Value.ToString());
			if (m3_EXMN.HasValue)
				request.WithQueryParameter("EXMN", m3_EXMN.Value.ToString());
			if (m3_ALMX.HasValue)
				request.WithQueryParameter("ALMX", m3_ALMX.Value.ToString());
			if (m3_ALMN.HasValue)
				request.WithQueryParameter("ALMN", m3_ALMN.Value.ToString());
			if (m3_EVTG.HasValue)
				request.WithQueryParameter("EVTG", m3_EVTG.Value.ToString());
			if (m3_TVTG.HasValue)
				request.WithQueryParameter("TVTG", m3_TVTG.Value.ToString());
			if (m3_AVTG.HasValue)
				request.WithQueryParameter("AVTG", m3_AVTG.Value.ToString());
			if (m3_REQD.HasValue)
				request.WithQueryParameter("REQD", m3_REQD.Value.ToString());
			if (m3_SMPR.HasValue)
				request.WithQueryParameter("SMPR", m3_SMPR.Value.ToString());
			if (m3_SMSZ.HasValue)
				request.WithQueryParameter("SMSZ", m3_SMSZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SMUM))
				request.WithQueryParameter("SMUM", m3_SMUM.Trim());
			if (m3_DSSM.HasValue)
				request.WithQueryParameter("DSSM", m3_DSSM.Value.ToString());
			if (m3_RTSM.HasValue)
				request.WithQueryParameter("RTSM", m3_RTSM.Value.ToString());
			if (m3_QTSP.HasValue)
				request.WithQueryParameter("QTSP", m3_QTSP.Value.ToString());
			if (m3_OVDT.HasValue)
				request.WithQueryParameter("OVDT", m3_OVDT.Value.ToM3String());
			if (m3_OVTE.HasValue)
				request.WithQueryParameter("OVTE", m3_OVTE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OVUS))
				request.WithQueryParameter("OVUS", m3_OVUS.Trim());
			if (m3_PVST.HasValue)
				request.WithQueryParameter("PVST", m3_PVST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QRSN))
				request.WithQueryParameter("QRSN", m3_QRSN.Trim());
			if (m3_DQTY.HasValue)
				request.WithQueryParameter("DQTY", m3_DQTY.Value.ToString());
			if (m3_TSTT.HasValue)
				request.WithQueryParameter("TSTT", m3_TSTT.Value.ToString());
			if (m3_PTCA.HasValue)
				request.WithQueryParameter("PTCA", m3_PTCA.Value.ToString());
			if (m3_QPTT.HasValue)
				request.WithQueryParameter("QPTT", m3_QPTT.Value.ToString());
			if (m3_QPTR.HasValue)
				request.WithQueryParameter("QPTR", m3_QPTR.Value.ToString());

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
