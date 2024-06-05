/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3QRID">Request ID (Required)</param>
		/// <param name="m3SPEC">Specification (Required)</param>
		/// <param name="m3QSE1">Effective date (Required)</param>
		/// <param name="m3QSE2">Effective time (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3QTE1">Effective date (Required)</param>
		/// <param name="m3QTE2">Effective time (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3EXSQ">Test order</param>
		/// <param name="m3MSUR">Measurement method</param>
		/// <param name="m3MSIN">Measurement instrument</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3SMTP">Sample type</param>
		/// <param name="m3INSD">Industry standard</param>
		/// <param name="m3VLTP">Value setup</param>
		/// <param name="m3QLCD">Test result</param>
		/// <param name="m3QOP1">Expected operator</param>
		/// <param name="m3QOP2">External operator</param>
		/// <param name="m3QOP3">Alarm operator</param>
		/// <param name="m3EVMX">Expected value max</param>
		/// <param name="m3EVMN">Expected value min</param>
		/// <param name="m3EXMX">External lab max</param>
		/// <param name="m3EXMN">External lab min</param>
		/// <param name="m3ALMX">Alarm limit max</param>
		/// <param name="m3ALMN">Alarm limit min</param>
		/// <param name="m3EVTG">Expected target value</param>
		/// <param name="m3TVTG">External target value</param>
		/// <param name="m3AVTG">Alarm target value</param>
		/// <param name="m3REQD">Required</param>
		/// <param name="m3SMPR">Sampling required</param>
		/// <param name="m3SMSZ">Sample size</param>
		/// <param name="m3SMUM">Sample U/M</param>
		/// <param name="m3DSSM">Discard sample</param>
		/// <param name="m3RTSM">Retain sample</param>
		/// <param name="m3QTSP">Test priority</param>
		/// <param name="m3PTCA">Print test on Certificate of Analysis</param>
		/// <param name="m3QPTR">Print result value</param>
		/// <param name="m3QPTT">Print spec test values</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTesttoQIReq(
			string m3QRID, 
			string m3SPEC, 
			DateTime m3QSE1, 
			int m3QSE2, 
			string m3QTST, 
			DateTime m3QTE1, 
			int m3QTE2, 
			int m3TSTY, 
			string m3FACI = null, 
			int? m3EXSQ = null, 
			string m3MSUR = null, 
			string m3MSIN = null, 
			string m3DEPT = null, 
			string m3SMTP = null, 
			string m3INSD = null, 
			int? m3VLTP = null, 
			string m3QLCD = null, 
			int? m3QOP1 = null, 
			int? m3QOP2 = null, 
			int? m3QOP3 = null, 
			decimal? m3EVMX = null, 
			decimal? m3EVMN = null, 
			decimal? m3EXMX = null, 
			decimal? m3EXMN = null, 
			decimal? m3ALMX = null, 
			decimal? m3ALMN = null, 
			decimal? m3EVTG = null, 
			decimal? m3TVTG = null, 
			decimal? m3AVTG = null, 
			int? m3REQD = null, 
			int? m3SMPR = null, 
			decimal? m3SMSZ = null, 
			string m3SMUM = null, 
			int? m3DSSM = null, 
			int? m3RTSM = null, 
			int? m3QTSP = null, 
			int? m3PTCA = null, 
			int? m3QPTR = null, 
			int? m3QPTT = null, 
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
			if (string.IsNullOrWhiteSpace(m3QRID))
				throw new ArgumentNullException(nameof(m3QRID));
			if (string.IsNullOrWhiteSpace(m3SPEC))
				throw new ArgumentNullException(nameof(m3SPEC));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));

			// Set mandatory parameters
			request
				.WithQueryParameter("QRID", m3QRID.Trim())
				.WithQueryParameter("SPEC", m3SPEC.Trim())
				.WithQueryParameter("QSE1", m3QSE1.ToM3String())
				.WithQueryParameter("QSE2", m3QSE2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("QTE1", m3QTE1.ToM3String())
				.WithQueryParameter("QTE2", m3QTE2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3EXSQ.HasValue)
				request.WithQueryParameter("EXSQ", m3EXSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSUR))
				request.WithQueryParameter("MSUR", m3MSUR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSIN))
				request.WithQueryParameter("MSIN", m3MSIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMTP))
				request.WithQueryParameter("SMTP", m3SMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSD))
				request.WithQueryParameter("INSD", m3INSD.Trim());
			if (m3VLTP.HasValue)
				request.WithQueryParameter("VLTP", m3VLTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLCD))
				request.WithQueryParameter("QLCD", m3QLCD.Trim());
			if (m3QOP1.HasValue)
				request.WithQueryParameter("QOP1", m3QOP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QOP2.HasValue)
				request.WithQueryParameter("QOP2", m3QOP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QOP3.HasValue)
				request.WithQueryParameter("QOP3", m3QOP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EVMX.HasValue)
				request.WithQueryParameter("EVMX", m3EVMX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EVMN.HasValue)
				request.WithQueryParameter("EVMN", m3EVMN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXMX.HasValue)
				request.WithQueryParameter("EXMX", m3EXMX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXMN.HasValue)
				request.WithQueryParameter("EXMN", m3EXMN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALMX.HasValue)
				request.WithQueryParameter("ALMX", m3ALMX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALMN.HasValue)
				request.WithQueryParameter("ALMN", m3ALMN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EVTG.HasValue)
				request.WithQueryParameter("EVTG", m3EVTG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TVTG.HasValue)
				request.WithQueryParameter("TVTG", m3TVTG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVTG.HasValue)
				request.WithQueryParameter("AVTG", m3AVTG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REQD.HasValue)
				request.WithQueryParameter("REQD", m3REQD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SMPR.HasValue)
				request.WithQueryParameter("SMPR", m3SMPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SMSZ.HasValue)
				request.WithQueryParameter("SMSZ", m3SMSZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SMUM))
				request.WithQueryParameter("SMUM", m3SMUM.Trim());
			if (m3DSSM.HasValue)
				request.WithQueryParameter("DSSM", m3DSSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTSM.HasValue)
				request.WithQueryParameter("RTSM", m3RTSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTSP.HasValue)
				request.WithQueryParameter("QTSP", m3QTSP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PTCA.HasValue)
				request.WithQueryParameter("PTCA", m3PTCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPTR.HasValue)
				request.WithQueryParameter("QPTR", m3QPTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPTT.HasValue)
				request.WithQueryParameter("QPTT", m3QPTT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltTestQIReq
		/// Description Delete QI request spec test
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SPEC">Specification (Required)</param>
		/// <param name="m3QSE1">Effective date (Required)</param>
		/// <param name="m3QSE2">Effective time (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3QTE1">Effective date (Required)</param>
		/// <param name="m3QTE2">Effective time (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltTestQIReq(
			string m3FACI, 
			string m3SPEC, 
			DateTime m3QSE1, 
			int m3QSE2, 
			string m3QTST, 
			DateTime m3QTE1, 
			int m3QTE2, 
			int m3TSTY, 
			string m3QRID = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SPEC))
				throw new ArgumentNullException(nameof(m3SPEC));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SPEC", m3SPEC.Trim())
				.WithQueryParameter("QSE1", m3QSE1.ToM3String())
				.WithQueryParameter("QSE2", m3QSE2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("QTE1", m3QTE1.ToM3String())
				.WithQueryParameter("QTE2", m3QTE2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

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
		/// Name GetTestQIReq
		/// Description Standard list details from QI request spec test
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SPEC">Specification (Required)</param>
		/// <param name="m3QSE1">Effective date (Required)</param>
		/// <param name="m3QSE2">Effective time (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3QTE1">Effective date (Required)</param>
		/// <param name="m3QTE2">Effective time (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTestQIReqResponse></returns>
		/// <exception cref="M3Exception<GetTestQIReqResponse>"></exception>
		public async Task<M3Response<GetTestQIReqResponse>> GetTestQIReq(
			string m3FACI, 
			string m3SPEC, 
			DateTime m3QSE1, 
			int m3QSE2, 
			string m3QTST, 
			DateTime m3QTE1, 
			int m3QTE2, 
			int m3TSTY, 
			string m3QRID = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SPEC))
				throw new ArgumentNullException(nameof(m3SPEC));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SPEC", m3SPEC.Trim())
				.WithQueryParameter("QSE1", m3QSE1.ToM3String())
				.WithQueryParameter("QSE2", m3QSE2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("QTE1", m3QTE1.ToM3String())
				.WithQueryParameter("QTE2", m3QTE2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<GetTestQIReqResponse>(
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
		/// Name LstTestQIReq
		/// Description Standard list details from QI request spec test
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SPEC">Specification (Required)</param>
		/// <param name="m3QSE1">Effective date (Required)</param>
		/// <param name="m3QSE2">Effective time (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3QTE1">Effective date (Required)</param>
		/// <param name="m3QTE2">Effective time (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTestQIReqResponse></returns>
		/// <exception cref="M3Exception<LstTestQIReqResponse>"></exception>
		public async Task<M3Response<LstTestQIReqResponse>> LstTestQIReq(
			string m3FACI, 
			string m3SPEC, 
			DateTime m3QSE1, 
			int m3QSE2, 
			string m3QTST, 
			DateTime m3QTE1, 
			int m3QTE2, 
			int m3TSTY, 
			string m3QRID = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SPEC))
				throw new ArgumentNullException(nameof(m3SPEC));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SPEC", m3SPEC.Trim())
				.WithQueryParameter("QSE1", m3QSE1.ToM3String())
				.WithQueryParameter("QSE2", m3QSE2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("QTE1", m3QTE1.ToM3String())
				.WithQueryParameter("QTE2", m3QTE2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<LstTestQIReqResponse>(
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
		/// Name LstTestsByRange
		/// Description List QI Request Spec tests by Status and Tested date range
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SPEC">Specification (Required)</param>
		/// <param name="m3QSE1">Effective date (Required)</param>
		/// <param name="m3QSE2">Effective time (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3QTE1">Effective date (Required)</param>
		/// <param name="m3QTE2">Effective time (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3TSTT">Test status</param>
		/// <param name="m3FTDT">From test date</param>
		/// <param name="m3FTTE">From test time</param>
		/// <param name="m3TTDT">To test date</param>
		/// <param name="m3TTTE">To test time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTestsByRangeResponse></returns>
		/// <exception cref="M3Exception<LstTestsByRangeResponse>"></exception>
		public async Task<M3Response<LstTestsByRangeResponse>> LstTestsByRange(
			string m3FACI, 
			string m3SPEC, 
			DateTime m3QSE1, 
			int m3QSE2, 
			string m3QTST, 
			DateTime m3QTE1, 
			int m3QTE2, 
			int m3TSTY, 
			string m3QRID = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			int? m3TSTT = null, 
			DateTime? m3FTDT = null, 
			int? m3FTTE = null, 
			DateTime? m3TTDT = null, 
			int? m3TTTE = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SPEC))
				throw new ArgumentNullException(nameof(m3SPEC));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SPEC", m3SPEC.Trim())
				.WithQueryParameter("QSE1", m3QSE1.ToM3String())
				.WithQueryParameter("QSE2", m3QSE2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("QTE1", m3QTE1.ToM3String())
				.WithQueryParameter("QTE2", m3QTE2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3TSTT.HasValue)
				request.WithQueryParameter("TSTT", m3TSTT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FTDT.HasValue)
				request.WithQueryParameter("FTDT", m3FTDT.Value.ToM3String());
			if (m3FTTE.HasValue)
				request.WithQueryParameter("FTTE", m3FTTE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TTDT.HasValue)
				request.WithQueryParameter("TTDT", m3TTDT.Value.ToM3String());
			if (m3TTTE.HasValue)
				request.WithQueryParameter("TTTE", m3TTTE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstTestsByRangeResponse>(
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
		/// Name LstTstQRIDByLab
		/// Description List QI Request spec tests by laboratory
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3QRID">Request ID (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3QTST">Test</param>
		/// <param name="m3QTE1">Effective date</param>
		/// <param name="m3QTE2">Effective time</param>
		/// <param name="m3TSTY">Test type</param>
		/// <param name="m3LABO">Laboratory</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTstQRIDByLabResponse></returns>
		/// <exception cref="M3Exception<LstTstQRIDByLabResponse>"></exception>
		public async Task<M3Response<LstTstQRIDByLabResponse>> LstTstQRIDByLab(
			string m3FACI, 
			string m3QRID, 
			string m3ITNO, 
			string m3BANO, 
			string m3SPEC = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
			string m3QTST = null, 
			DateTime? m3QTE1 = null, 
			int? m3QTE2 = null, 
			int? m3TSTY = null, 
			string m3LABO = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3QRID))
				throw new ArgumentNullException(nameof(m3QRID));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("QRID", m3QRID.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QTST))
				request.WithQueryParameter("QTST", m3QTST.Trim());
			if (m3QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3QTE1.Value.ToM3String());
			if (m3QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3QTE2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TSTY.HasValue)
				request.WithQueryParameter("TSTY", m3TSTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LABO))
				request.WithQueryParameter("LABO", m3LABO.Trim());

			// Execute the request
			var result = await Execute<LstTstQRIDByLabResponse>(
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
		/// Name UpdTesttoQIReq
		/// Description Standard transaction to update test to a Spec in the QI req
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3QRID">Request ID (Required)</param>
		/// <param name="m3SPEC">Specification (Required)</param>
		/// <param name="m3QSE1">Effective date (Required)</param>
		/// <param name="m3QSE2">Effective time (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3QTE1">Effective date (Required)</param>
		/// <param name="m3QTE2">Effective time (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3EXSQ">Test order</param>
		/// <param name="m3MSUR">Measurement method</param>
		/// <param name="m3MSIN">Measurement instrument</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3SMTP">Sample type</param>
		/// <param name="m3INSD">Industry standard</param>
		/// <param name="m3VLTP">Value setup</param>
		/// <param name="m3QLCD">Test result</param>
		/// <param name="m3QOP1">Expected operator</param>
		/// <param name="m3QOP2">External operator</param>
		/// <param name="m3QOP3">Alarm operator</param>
		/// <param name="m3EVMX">Expected value max</param>
		/// <param name="m3EVMN">Expected value min</param>
		/// <param name="m3EXMX">External lab max</param>
		/// <param name="m3EXMN">External lab min</param>
		/// <param name="m3ALMX">Alarm limit max</param>
		/// <param name="m3ALMN">Alarm limit min</param>
		/// <param name="m3EVTG">Expected target value</param>
		/// <param name="m3TVTG">External target value</param>
		/// <param name="m3AVTG">Alarm target value</param>
		/// <param name="m3REQD">Required</param>
		/// <param name="m3SMPR">Sampling required</param>
		/// <param name="m3SMSZ">Sample size</param>
		/// <param name="m3SMUM">Sample U/M</param>
		/// <param name="m3DSSM">Discard sample</param>
		/// <param name="m3RTSM">Retain sample</param>
		/// <param name="m3QTSP">Test priority</param>
		/// <param name="m3OVDT">Overrided date</param>
		/// <param name="m3OVTE">Overrided time</param>
		/// <param name="m3OVUS">Overrided by</param>
		/// <param name="m3PVST">Prior status</param>
		/// <param name="m3QRSN">Reason</param>
		/// <param name="m3DQTY">Defective quantity</param>
		/// <param name="m3TSTT">Specification test status</param>
		/// <param name="m3PTCA">Print test on Certificate of Analysis</param>
		/// <param name="m3QPTT">Print spec test values</param>
		/// <param name="m3QPTR">Print result value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTesttoQIReq(
			string m3FACI, 
			string m3QRID, 
			string m3SPEC, 
			DateTime m3QSE1, 
			int m3QSE2, 
			string m3QTST, 
			DateTime m3QTE1, 
			int m3QTE2, 
			int m3TSTY, 
			int? m3EXSQ = null, 
			string m3MSUR = null, 
			string m3MSIN = null, 
			string m3DEPT = null, 
			string m3SMTP = null, 
			string m3INSD = null, 
			int? m3VLTP = null, 
			string m3QLCD = null, 
			int? m3QOP1 = null, 
			int? m3QOP2 = null, 
			int? m3QOP3 = null, 
			decimal? m3EVMX = null, 
			decimal? m3EVMN = null, 
			decimal? m3EXMX = null, 
			decimal? m3EXMN = null, 
			decimal? m3ALMX = null, 
			decimal? m3ALMN = null, 
			decimal? m3EVTG = null, 
			decimal? m3TVTG = null, 
			decimal? m3AVTG = null, 
			int? m3REQD = null, 
			int? m3SMPR = null, 
			decimal? m3SMSZ = null, 
			string m3SMUM = null, 
			int? m3DSSM = null, 
			int? m3RTSM = null, 
			int? m3QTSP = null, 
			DateTime? m3OVDT = null, 
			int? m3OVTE = null, 
			string m3OVUS = null, 
			int? m3PVST = null, 
			string m3QRSN = null, 
			decimal? m3DQTY = null, 
			int? m3TSTT = null, 
			int? m3PTCA = null, 
			int? m3QPTT = null, 
			int? m3QPTR = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3QRID))
				throw new ArgumentNullException(nameof(m3QRID));
			if (string.IsNullOrWhiteSpace(m3SPEC))
				throw new ArgumentNullException(nameof(m3SPEC));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("QRID", m3QRID.Trim())
				.WithQueryParameter("SPEC", m3SPEC.Trim())
				.WithQueryParameter("QSE1", m3QSE1.ToM3String())
				.WithQueryParameter("QSE2", m3QSE2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("QTE1", m3QTE1.ToM3String())
				.WithQueryParameter("QTE2", m3QTE2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3EXSQ.HasValue)
				request.WithQueryParameter("EXSQ", m3EXSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSUR))
				request.WithQueryParameter("MSUR", m3MSUR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSIN))
				request.WithQueryParameter("MSIN", m3MSIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMTP))
				request.WithQueryParameter("SMTP", m3SMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSD))
				request.WithQueryParameter("INSD", m3INSD.Trim());
			if (m3VLTP.HasValue)
				request.WithQueryParameter("VLTP", m3VLTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLCD))
				request.WithQueryParameter("QLCD", m3QLCD.Trim());
			if (m3QOP1.HasValue)
				request.WithQueryParameter("QOP1", m3QOP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QOP2.HasValue)
				request.WithQueryParameter("QOP2", m3QOP2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QOP3.HasValue)
				request.WithQueryParameter("QOP3", m3QOP3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EVMX.HasValue)
				request.WithQueryParameter("EVMX", m3EVMX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EVMN.HasValue)
				request.WithQueryParameter("EVMN", m3EVMN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXMX.HasValue)
				request.WithQueryParameter("EXMX", m3EXMX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXMN.HasValue)
				request.WithQueryParameter("EXMN", m3EXMN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALMX.HasValue)
				request.WithQueryParameter("ALMX", m3ALMX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALMN.HasValue)
				request.WithQueryParameter("ALMN", m3ALMN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EVTG.HasValue)
				request.WithQueryParameter("EVTG", m3EVTG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TVTG.HasValue)
				request.WithQueryParameter("TVTG", m3TVTG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVTG.HasValue)
				request.WithQueryParameter("AVTG", m3AVTG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REQD.HasValue)
				request.WithQueryParameter("REQD", m3REQD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SMPR.HasValue)
				request.WithQueryParameter("SMPR", m3SMPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SMSZ.HasValue)
				request.WithQueryParameter("SMSZ", m3SMSZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SMUM))
				request.WithQueryParameter("SMUM", m3SMUM.Trim());
			if (m3DSSM.HasValue)
				request.WithQueryParameter("DSSM", m3DSSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTSM.HasValue)
				request.WithQueryParameter("RTSM", m3RTSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTSP.HasValue)
				request.WithQueryParameter("QTSP", m3QTSP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OVDT.HasValue)
				request.WithQueryParameter("OVDT", m3OVDT.Value.ToM3String());
			if (m3OVTE.HasValue)
				request.WithQueryParameter("OVTE", m3OVTE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OVUS))
				request.WithQueryParameter("OVUS", m3OVUS.Trim());
			if (m3PVST.HasValue)
				request.WithQueryParameter("PVST", m3PVST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QRSN))
				request.WithQueryParameter("QRSN", m3QRSN.Trim());
			if (m3DQTY.HasValue)
				request.WithQueryParameter("DQTY", m3DQTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TSTT.HasValue)
				request.WithQueryParameter("TSTT", m3TSTT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PTCA.HasValue)
				request.WithQueryParameter("PTCA", m3PTCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPTT.HasValue)
				request.WithQueryParameter("QPTT", m3QPTT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPTR.HasValue)
				request.WithQueryParameter("QPTR", m3QPTR.Value.ToString(CultureInfo.CurrentCulture));

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
