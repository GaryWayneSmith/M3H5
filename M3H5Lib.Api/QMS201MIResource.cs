/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QMS201MI;
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
	/// Name: QMS201MI
	/// Component Name: Spec Test
	/// Description: Api: Spec Test Interface
	/// Version Release: 5ea0
	///</summary>
	public partial class QMS201MIResource : M3BaseResourceEndpoint
	{
		public QMS201MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS201MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSpecTest
		/// Description Add spec test
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SPEC">Specification (Required)</param>
		/// <param name="m3_QSE1">Effective date (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_QTE1">Effective date (Required)</param>
		/// <param name="m3_QTI1">Inactive date (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_EXSQ">Test order (Required)</param>
		/// <param name="m3_VLTP">Value setup (Required)</param>
		/// <param name="m3_QTSP">Test priority (Required)</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="m3_QTI2">Inactive time</param>
		/// <param name="m3_QTCD">Numeric qualitative</param>
		/// <param name="m3_QLCD">Test result</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_MSUR">Measurement method</param>
		/// <param name="m3_MSIN">Measurement instrument</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_LABO">Laboratory</param>
		/// <param name="m3_SMTP">Sample type</param>
		/// <param name="m3_INSD">Industry standard</param>
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
		/// <param name="m3_TEUM">Test U/M</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_REQD">Required</param>
		/// <param name="m3_SMPR">Sampling required</param>
		/// <param name="m3_INTR">Internal test required</param>
		/// <param name="m3_FRPR">Frequency per</param>
		/// <param name="m3_FRTI">Frequency times</param>
		/// <param name="m3_FRQY">Frequency quantity</param>
		/// <param name="m3_FRUM">Frequency U/M</param>
		/// <param name="m3_SMSZ">Sample size</param>
		/// <param name="m3_SMUM">Sample U/M</param>
		/// <param name="m3_DSSM">Discard sample</param>
		/// <param name="m3_RTSM">Retain sample</param>
		/// <param name="m3_TCAL">Calculated by formula</param>
		/// <param name="m3_TCLS">Test classification</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ITQR">Include test in QI request</param>
		/// <param name="m3_PTCA">Print test on Certificate of Analysis</param>
		/// <param name="m3_PTSP">Print test on specification document</param>
		/// <param name="m3_DUSM">Sample usage</param>
		/// <param name="m3_QPTT">Print spec test values</param>
		/// <param name="m3_QPTR">Print result value</param>
		/// <param name="m3_CDOR">Copy DO results</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSpecTest(
			string m3_SPEC, 
			DateTime m3_QSE1, 
			string m3_QTST, 
			int m3_TSTY, 
			DateTime m3_QTE1, 
			DateTime m3_QTI1, 
			string m3_TX40, 
			int m3_EXSQ, 
			int m3_VLTP, 
			int m3_QTSP, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
			int? m3_QTE2 = null, 
			int? m3_QTI2 = null, 
			string m3_QTCD = null, 
			string m3_QLCD = null, 
			string m3_ATID = null, 
			string m3_MSUR = null, 
			string m3_MSIN = null, 
			string m3_DEPT = null, 
			string m3_LABO = null, 
			string m3_SMTP = null, 
			string m3_INSD = null, 
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
			string m3_TEUM = null, 
			int? m3_DCCD = null, 
			int? m3_REQD = null, 
			int? m3_SMPR = null, 
			int? m3_INTR = null, 
			int? m3_FRPR = null, 
			int? m3_FRTI = null, 
			decimal? m3_FRQY = null, 
			string m3_FRUM = null, 
			decimal? m3_SMSZ = null, 
			string m3_SMUM = null, 
			int? m3_DSSM = null, 
			int? m3_RTSM = null, 
			int? m3_TCAL = null, 
			string m3_TCLS = null, 
			decimal? m3_TXID = null, 
			int? m3_ITQR = null, 
			int? m3_PTCA = null, 
			int? m3_PTSP = null, 
			int? m3_DUSM = null, 
			int? m3_QPTT = null, 
			int? m3_QPTR = null, 
			int? m3_CDOR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSpecTest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SPEC))
				throw new ArgumentNullException("m3_SPEC");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPEC", m3_SPEC.Trim())
				.WithQueryParameter("QSE1", m3_QSE1.ToM3String())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("TSTY", m3_TSTY.ToString())
				.WithQueryParameter("QTE1", m3_QTE1.ToM3String())
				.WithQueryParameter("QTI1", m3_QTI1.ToM3String())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("EXSQ", m3_EXSQ.ToString())
				.WithQueryParameter("VLTP", m3_VLTP.ToString())
				.WithQueryParameter("QTSP", m3_QTSP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());
			if (m3_QTI2.HasValue)
				request.WithQueryParameter("QTI2", m3_QTI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QTCD))
				request.WithQueryParameter("QTCD", m3_QTCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QLCD))
				request.WithQueryParameter("QLCD", m3_QLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSUR))
				request.WithQueryParameter("MSUR", m3_MSUR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSIN))
				request.WithQueryParameter("MSIN", m3_MSIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LABO))
				request.WithQueryParameter("LABO", m3_LABO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMTP))
				request.WithQueryParameter("SMTP", m3_SMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSD))
				request.WithQueryParameter("INSD", m3_INSD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_TEUM))
				request.WithQueryParameter("TEUM", m3_TEUM.Trim());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_REQD.HasValue)
				request.WithQueryParameter("REQD", m3_REQD.Value.ToString());
			if (m3_SMPR.HasValue)
				request.WithQueryParameter("SMPR", m3_SMPR.Value.ToString());
			if (m3_INTR.HasValue)
				request.WithQueryParameter("INTR", m3_INTR.Value.ToString());
			if (m3_FRPR.HasValue)
				request.WithQueryParameter("FRPR", m3_FRPR.Value.ToString());
			if (m3_FRTI.HasValue)
				request.WithQueryParameter("FRTI", m3_FRTI.Value.ToString());
			if (m3_FRQY.HasValue)
				request.WithQueryParameter("FRQY", m3_FRQY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRUM))
				request.WithQueryParameter("FRUM", m3_FRUM.Trim());
			if (m3_SMSZ.HasValue)
				request.WithQueryParameter("SMSZ", m3_SMSZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SMUM))
				request.WithQueryParameter("SMUM", m3_SMUM.Trim());
			if (m3_DSSM.HasValue)
				request.WithQueryParameter("DSSM", m3_DSSM.Value.ToString());
			if (m3_RTSM.HasValue)
				request.WithQueryParameter("RTSM", m3_RTSM.Value.ToString());
			if (m3_TCAL.HasValue)
				request.WithQueryParameter("TCAL", m3_TCAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TCLS))
				request.WithQueryParameter("TCLS", m3_TCLS.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_ITQR.HasValue)
				request.WithQueryParameter("ITQR", m3_ITQR.Value.ToString());
			if (m3_PTCA.HasValue)
				request.WithQueryParameter("PTCA", m3_PTCA.Value.ToString());
			if (m3_PTSP.HasValue)
				request.WithQueryParameter("PTSP", m3_PTSP.Value.ToString());
			if (m3_DUSM.HasValue)
				request.WithQueryParameter("DUSM", m3_DUSM.Value.ToString());
			if (m3_QPTT.HasValue)
				request.WithQueryParameter("QPTT", m3_QPTT.Value.ToString());
			if (m3_QPTR.HasValue)
				request.WithQueryParameter("QPTR", m3_QPTR.Value.ToString());
			if (m3_CDOR.HasValue)
				request.WithQueryParameter("CDOR", m3_CDOR.Value.ToString());

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
		/// Name DltSpecTest
		/// Description Delete a spec test
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SPEC">Specification (Required)</param>
		/// <param name="m3_QSE1">Effective date (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_QTE1">Effective date (Required)</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSpecTest(
			string m3_SPEC, 
			DateTime m3_QSE1, 
			string m3_QTST, 
			int m3_TSTY, 
			DateTime m3_QTE1, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
			int? m3_QTE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltSpecTest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SPEC))
				throw new ArgumentNullException("m3_SPEC");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPEC", m3_SPEC.Trim())
				.WithQueryParameter("QSE1", m3_QSE1.ToM3String())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("TSTY", m3_TSTY.ToString())
				.WithQueryParameter("QTE1", m3_QTE1.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());

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
		/// Name GetSpecTest
		/// Description Get a spec test
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SPEC">Specification (Required)</param>
		/// <param name="m3_QSE1">Effective date (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_QTE1">Effective date (Required)</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSpecTestResponse></returns>
		/// <exception cref="M3Exception<GetSpecTestResponse>"></exception>
		public async Task<M3Response<GetSpecTestResponse>> GetSpecTest(
			string m3_SPEC, 
			DateTime m3_QSE1, 
			string m3_QTST, 
			int m3_TSTY, 
			DateTime m3_QTE1, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
			int? m3_QTE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSpecTest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SPEC))
				throw new ArgumentNullException("m3_SPEC");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPEC", m3_SPEC.Trim())
				.WithQueryParameter("QSE1", m3_QSE1.ToM3String())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("TSTY", m3_TSTY.ToString())
				.WithQueryParameter("QTE1", m3_QTE1.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());

			// Execute the request
			var result = await Execute<GetSpecTestResponse>(
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
		/// Name LstSpecTest
		/// Description List details from QMSTST
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SPEC">Specification (Required)</param>
		/// <param name="m3_QSE1">Effective date (Required)</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_QTST">Test</param>
		/// <param name="m3_TSTY">Test type</param>
		/// <param name="m3_QTE1">Effective date</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecTestResponse></returns>
		/// <exception cref="M3Exception<LstSpecTestResponse>"></exception>
		public async Task<M3Response<LstSpecTestResponse>> LstSpecTest(
			string m3_SPEC, 
			DateTime m3_QSE1, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
			string m3_QTST = null, 
			int? m3_TSTY = null, 
			DateTime? m3_QTE1 = null, 
			int? m3_QTE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSpecTest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SPEC))
				throw new ArgumentNullException("m3_SPEC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPEC", m3_SPEC.Trim())
				.WithQueryParameter("QSE1", m3_QSE1.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QTST))
				request.WithQueryParameter("QTST", m3_QTST.Trim());
			if (m3_TSTY.HasValue)
				request.WithQueryParameter("TSTY", m3_TSTY.Value.ToString());
			if (m3_QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3_QTE1.Value.ToM3String());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());

			// Execute the request
			var result = await Execute<LstSpecTestResponse>(
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
		/// Name UpdSpecTest
		/// Description Update a spec test
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SPEC">Specification (Required)</param>
		/// <param name="m3_QSE1">Effective date (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_QTE1">Effective date (Required)</param>
		/// <param name="m3_QTI1">Inactive date (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_EXSQ">Test order (Required)</param>
		/// <param name="m3_VLTP">Value setup (Required)</param>
		/// <param name="m3_QTSP">Test priority (Required)</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="m3_QTI2">Inactive time</param>
		/// <param name="m3_QTCD">Numeric qualitative</param>
		/// <param name="m3_QLCD">Test result</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_MSUR">Measurement method</param>
		/// <param name="m3_MSIN">Measurement instrument</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_LABO">Laboratory</param>
		/// <param name="m3_SMTP">Sample type</param>
		/// <param name="m3_INSD">Industry standard</param>
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
		/// <param name="m3_TEUM">Test U/M</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_REQD">Required</param>
		/// <param name="m3_SMPR">Sampling required</param>
		/// <param name="m3_INTR">Internal test required</param>
		/// <param name="m3_FRPR">Frequency per</param>
		/// <param name="m3_FRTI">Frequency times</param>
		/// <param name="m3_FRQY">Frequency quantity</param>
		/// <param name="m3_FRUM">Frequency U/M</param>
		/// <param name="m3_SMSZ">Sample size</param>
		/// <param name="m3_SMUM">Sample U/M</param>
		/// <param name="m3_DSSM">Discard sample</param>
		/// <param name="m3_RTSM">Retain sample</param>
		/// <param name="m3_TCAL">Calculated by formula</param>
		/// <param name="m3_TCLS">Test classification</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ITQR">Include test in QI request</param>
		/// <param name="m3_PTCA">Print test on Certificate of Analysis</param>
		/// <param name="m3_PTSP">Print test on specification document</param>
		/// <param name="m3_DUSM">Sample usage</param>
		/// <param name="m3_QPTT">Print spec test values</param>
		/// <param name="m3_QPTR">Print result value</param>
		/// <param name="m3_CDOR">Copy DO results</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSpecTest(
			string m3_SPEC, 
			DateTime m3_QSE1, 
			string m3_QTST, 
			int m3_TSTY, 
			DateTime m3_QTE1, 
			DateTime m3_QTI1, 
			string m3_TX40, 
			int m3_EXSQ, 
			int m3_VLTP, 
			int m3_QTSP, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
			int? m3_QTE2 = null, 
			int? m3_QTI2 = null, 
			string m3_QTCD = null, 
			string m3_QLCD = null, 
			string m3_ATID = null, 
			string m3_MSUR = null, 
			string m3_MSIN = null, 
			string m3_DEPT = null, 
			string m3_LABO = null, 
			string m3_SMTP = null, 
			string m3_INSD = null, 
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
			string m3_TEUM = null, 
			int? m3_DCCD = null, 
			int? m3_REQD = null, 
			int? m3_SMPR = null, 
			int? m3_INTR = null, 
			int? m3_FRPR = null, 
			int? m3_FRTI = null, 
			decimal? m3_FRQY = null, 
			string m3_FRUM = null, 
			decimal? m3_SMSZ = null, 
			string m3_SMUM = null, 
			int? m3_DSSM = null, 
			int? m3_RTSM = null, 
			int? m3_TCAL = null, 
			string m3_TCLS = null, 
			decimal? m3_TXID = null, 
			int? m3_ITQR = null, 
			int? m3_PTCA = null, 
			int? m3_PTSP = null, 
			int? m3_DUSM = null, 
			int? m3_QPTT = null, 
			int? m3_QPTR = null, 
			int? m3_CDOR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSpecTest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SPEC))
				throw new ArgumentNullException("m3_SPEC");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPEC", m3_SPEC.Trim())
				.WithQueryParameter("QSE1", m3_QSE1.ToM3String())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("TSTY", m3_TSTY.ToString())
				.WithQueryParameter("QTE1", m3_QTE1.ToM3String())
				.WithQueryParameter("QTI1", m3_QTI1.ToM3String())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("EXSQ", m3_EXSQ.ToString())
				.WithQueryParameter("VLTP", m3_VLTP.ToString())
				.WithQueryParameter("QTSP", m3_QTSP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());
			if (m3_QTI2.HasValue)
				request.WithQueryParameter("QTI2", m3_QTI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QTCD))
				request.WithQueryParameter("QTCD", m3_QTCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QLCD))
				request.WithQueryParameter("QLCD", m3_QLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSUR))
				request.WithQueryParameter("MSUR", m3_MSUR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSIN))
				request.WithQueryParameter("MSIN", m3_MSIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LABO))
				request.WithQueryParameter("LABO", m3_LABO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMTP))
				request.WithQueryParameter("SMTP", m3_SMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSD))
				request.WithQueryParameter("INSD", m3_INSD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_TEUM))
				request.WithQueryParameter("TEUM", m3_TEUM.Trim());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_REQD.HasValue)
				request.WithQueryParameter("REQD", m3_REQD.Value.ToString());
			if (m3_SMPR.HasValue)
				request.WithQueryParameter("SMPR", m3_SMPR.Value.ToString());
			if (m3_INTR.HasValue)
				request.WithQueryParameter("INTR", m3_INTR.Value.ToString());
			if (m3_FRPR.HasValue)
				request.WithQueryParameter("FRPR", m3_FRPR.Value.ToString());
			if (m3_FRTI.HasValue)
				request.WithQueryParameter("FRTI", m3_FRTI.Value.ToString());
			if (m3_FRQY.HasValue)
				request.WithQueryParameter("FRQY", m3_FRQY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRUM))
				request.WithQueryParameter("FRUM", m3_FRUM.Trim());
			if (m3_SMSZ.HasValue)
				request.WithQueryParameter("SMSZ", m3_SMSZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SMUM))
				request.WithQueryParameter("SMUM", m3_SMUM.Trim());
			if (m3_DSSM.HasValue)
				request.WithQueryParameter("DSSM", m3_DSSM.Value.ToString());
			if (m3_RTSM.HasValue)
				request.WithQueryParameter("RTSM", m3_RTSM.Value.ToString());
			if (m3_TCAL.HasValue)
				request.WithQueryParameter("TCAL", m3_TCAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TCLS))
				request.WithQueryParameter("TCLS", m3_TCLS.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_ITQR.HasValue)
				request.WithQueryParameter("ITQR", m3_ITQR.Value.ToString());
			if (m3_PTCA.HasValue)
				request.WithQueryParameter("PTCA", m3_PTCA.Value.ToString());
			if (m3_PTSP.HasValue)
				request.WithQueryParameter("PTSP", m3_PTSP.Value.ToString());
			if (m3_DUSM.HasValue)
				request.WithQueryParameter("DUSM", m3_DUSM.Value.ToString());
			if (m3_QPTT.HasValue)
				request.WithQueryParameter("QPTT", m3_QPTT.Value.ToString());
			if (m3_QPTR.HasValue)
				request.WithQueryParameter("QPTR", m3_QPTR.Value.ToString());
			if (m3_CDOR.HasValue)
				request.WithQueryParameter("CDOR", m3_CDOR.Value.ToString());

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
