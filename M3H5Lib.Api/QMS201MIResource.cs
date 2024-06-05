/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSpecTest
		/// Description Add spec test
		/// Version Release: 
		/// </summary>
		/// <param name="m3SPEC">Specification (Required)</param>
		/// <param name="m3QSE1">Effective date (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3QTE1">Effective date (Required)</param>
		/// <param name="m3QTI1">Inactive date (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3EXSQ">Test order (Required)</param>
		/// <param name="m3VLTP">Value setup (Required)</param>
		/// <param name="m3QTSP">Test priority (Required)</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3QTE2">Effective time</param>
		/// <param name="m3QTI2">Inactive time</param>
		/// <param name="m3QTCD">Numeric qualitative</param>
		/// <param name="m3QLCD">Test result</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3MSUR">Measurement method</param>
		/// <param name="m3MSIN">Measurement instrument</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3LABO">Laboratory</param>
		/// <param name="m3SMTP">Sample type</param>
		/// <param name="m3INSD">Industry standard</param>
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
		/// <param name="m3TEUM">Test U/M</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3REQD">Required</param>
		/// <param name="m3SMPR">Sampling required</param>
		/// <param name="m3INTR">Internal test required</param>
		/// <param name="m3FRPR">Frequency per</param>
		/// <param name="m3FRTI">Frequency times</param>
		/// <param name="m3FRQY">Frequency quantity</param>
		/// <param name="m3FRUM">Frequency U/M</param>
		/// <param name="m3SMSZ">Sample size</param>
		/// <param name="m3SMUM">Sample U/M</param>
		/// <param name="m3DSSM">Discard sample</param>
		/// <param name="m3RTSM">Retain sample</param>
		/// <param name="m3TCAL">Calculated by formula</param>
		/// <param name="m3TCLS">Test classification</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3ITQR">Include test in QI request</param>
		/// <param name="m3PTCA">Print test on Certificate of Analysis</param>
		/// <param name="m3PTSP">Print test on specification document</param>
		/// <param name="m3DUSM">Sample usage</param>
		/// <param name="m3QPTT">Print spec test values</param>
		/// <param name="m3QPTR">Print result value</param>
		/// <param name="m3CDOR">Copy DO results</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSpecTest(
			string m3SPEC, 
			DateTime m3QSE1, 
			string m3QTST, 
			int m3TSTY, 
			DateTime m3QTE1, 
			DateTime m3QTI1, 
			string m3TX40, 
			int m3EXSQ, 
			int m3VLTP, 
			int m3QTSP, 
			int? m3QSE2 = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
			int? m3QTE2 = null, 
			int? m3QTI2 = null, 
			string m3QTCD = null, 
			string m3QLCD = null, 
			string m3ATID = null, 
			string m3MSUR = null, 
			string m3MSIN = null, 
			string m3DEPT = null, 
			string m3LABO = null, 
			string m3SMTP = null, 
			string m3INSD = null, 
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
			string m3TEUM = null, 
			int? m3DCCD = null, 
			int? m3REQD = null, 
			int? m3SMPR = null, 
			int? m3INTR = null, 
			int? m3FRPR = null, 
			int? m3FRTI = null, 
			decimal? m3FRQY = null, 
			string m3FRUM = null, 
			decimal? m3SMSZ = null, 
			string m3SMUM = null, 
			int? m3DSSM = null, 
			int? m3RTSM = null, 
			int? m3TCAL = null, 
			string m3TCLS = null, 
			decimal? m3TXID = null, 
			int? m3ITQR = null, 
			int? m3PTCA = null, 
			int? m3PTSP = null, 
			int? m3DUSM = null, 
			int? m3QPTT = null, 
			int? m3QPTR = null, 
			int? m3CDOR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSpecTest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SPEC))
				throw new ArgumentNullException(nameof(m3SPEC));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPEC", m3SPEC.Trim())
				.WithQueryParameter("QSE1", m3QSE1.ToM3String())
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QTE1", m3QTE1.ToM3String())
				.WithQueryParameter("QTI1", m3QTI1.ToM3String())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("EXSQ", m3EXSQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VLTP", m3VLTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QTSP", m3QTSP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3QTE2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTI2.HasValue)
				request.WithQueryParameter("QTI2", m3QTI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QTCD))
				request.WithQueryParameter("QTCD", m3QTCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3QLCD))
				request.WithQueryParameter("QLCD", m3QLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSUR))
				request.WithQueryParameter("MSUR", m3MSUR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSIN))
				request.WithQueryParameter("MSIN", m3MSIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3LABO))
				request.WithQueryParameter("LABO", m3LABO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMTP))
				request.WithQueryParameter("SMTP", m3SMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSD))
				request.WithQueryParameter("INSD", m3INSD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3TEUM))
				request.WithQueryParameter("TEUM", m3TEUM.Trim());
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REQD.HasValue)
				request.WithQueryParameter("REQD", m3REQD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SMPR.HasValue)
				request.WithQueryParameter("SMPR", m3SMPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INTR.HasValue)
				request.WithQueryParameter("INTR", m3INTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRPR.HasValue)
				request.WithQueryParameter("FRPR", m3FRPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRTI.HasValue)
				request.WithQueryParameter("FRTI", m3FRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRQY.HasValue)
				request.WithQueryParameter("FRQY", m3FRQY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRUM))
				request.WithQueryParameter("FRUM", m3FRUM.Trim());
			if (m3SMSZ.HasValue)
				request.WithQueryParameter("SMSZ", m3SMSZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SMUM))
				request.WithQueryParameter("SMUM", m3SMUM.Trim());
			if (m3DSSM.HasValue)
				request.WithQueryParameter("DSSM", m3DSSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTSM.HasValue)
				request.WithQueryParameter("RTSM", m3RTSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCAL.HasValue)
				request.WithQueryParameter("TCAL", m3TCAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TCLS))
				request.WithQueryParameter("TCLS", m3TCLS.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITQR.HasValue)
				request.WithQueryParameter("ITQR", m3ITQR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PTCA.HasValue)
				request.WithQueryParameter("PTCA", m3PTCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PTSP.HasValue)
				request.WithQueryParameter("PTSP", m3PTSP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DUSM.HasValue)
				request.WithQueryParameter("DUSM", m3DUSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPTT.HasValue)
				request.WithQueryParameter("QPTT", m3QPTT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPTR.HasValue)
				request.WithQueryParameter("QPTR", m3QPTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDOR.HasValue)
				request.WithQueryParameter("CDOR", m3CDOR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltSpecTest
		/// Description Delete a spec test
		/// Version Release: 
		/// </summary>
		/// <param name="m3SPEC">Specification (Required)</param>
		/// <param name="m3QSE1">Effective date (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3QTE1">Effective date (Required)</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3QTE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSpecTest(
			string m3SPEC, 
			DateTime m3QSE1, 
			string m3QTST, 
			int m3TSTY, 
			DateTime m3QTE1, 
			int? m3QSE2 = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
			int? m3QTE2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltSpecTest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SPEC))
				throw new ArgumentNullException(nameof(m3SPEC));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPEC", m3SPEC.Trim())
				.WithQueryParameter("QSE1", m3QSE1.ToM3String())
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QTE1", m3QTE1.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3QTE2.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetSpecTest
		/// Description Get a spec test
		/// Version Release: 
		/// </summary>
		/// <param name="m3SPEC">Specification (Required)</param>
		/// <param name="m3QSE1">Effective date (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3QTE1">Effective date (Required)</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3QTE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSpecTestResponse></returns>
		/// <exception cref="M3Exception<GetSpecTestResponse>"></exception>
		public async Task<M3Response<GetSpecTestResponse>> GetSpecTest(
			string m3SPEC, 
			DateTime m3QSE1, 
			string m3QTST, 
			int m3TSTY, 
			DateTime m3QTE1, 
			int? m3QSE2 = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
			int? m3QTE2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSpecTest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SPEC))
				throw new ArgumentNullException(nameof(m3SPEC));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPEC", m3SPEC.Trim())
				.WithQueryParameter("QSE1", m3QSE1.ToM3String())
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QTE1", m3QTE1.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3QTE2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSpecTestResponse>(
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
		/// Name LstSpecTest
		/// Description List details from QMSTST
		/// Version Release: 
		/// </summary>
		/// <param name="m3SPEC">Specification (Required)</param>
		/// <param name="m3QSE1">Effective date (Required)</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3QTST">Test</param>
		/// <param name="m3TSTY">Test type</param>
		/// <param name="m3QTE1">Effective date</param>
		/// <param name="m3QTE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecTestResponse></returns>
		/// <exception cref="M3Exception<LstSpecTestResponse>"></exception>
		public async Task<M3Response<LstSpecTestResponse>> LstSpecTest(
			string m3SPEC, 
			DateTime m3QSE1, 
			int? m3QSE2 = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
			string m3QTST = null, 
			int? m3TSTY = null, 
			DateTime? m3QTE1 = null, 
			int? m3QTE2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSpecTest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SPEC))
				throw new ArgumentNullException(nameof(m3SPEC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPEC", m3SPEC.Trim())
				.WithQueryParameter("QSE1", m3QSE1.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3QTST))
				request.WithQueryParameter("QTST", m3QTST.Trim());
			if (m3TSTY.HasValue)
				request.WithQueryParameter("TSTY", m3TSTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3QTE1.Value.ToM3String());
			if (m3QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3QTE2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSpecTestResponse>(
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
		/// Name UpdSpecTest
		/// Description Update a spec test
		/// Version Release: 
		/// </summary>
		/// <param name="m3SPEC">Specification (Required)</param>
		/// <param name="m3QSE1">Effective date (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3QTE1">Effective date (Required)</param>
		/// <param name="m3QTI1">Inactive date (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3EXSQ">Test order (Required)</param>
		/// <param name="m3VLTP">Value setup (Required)</param>
		/// <param name="m3QTSP">Test priority (Required)</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3QTE2">Effective time</param>
		/// <param name="m3QTI2">Inactive time</param>
		/// <param name="m3QTCD">Numeric qualitative</param>
		/// <param name="m3QLCD">Test result</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3MSUR">Measurement method</param>
		/// <param name="m3MSIN">Measurement instrument</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3LABO">Laboratory</param>
		/// <param name="m3SMTP">Sample type</param>
		/// <param name="m3INSD">Industry standard</param>
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
		/// <param name="m3TEUM">Test U/M</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3REQD">Required</param>
		/// <param name="m3SMPR">Sampling required</param>
		/// <param name="m3INTR">Internal test required</param>
		/// <param name="m3FRPR">Frequency per</param>
		/// <param name="m3FRTI">Frequency times</param>
		/// <param name="m3FRQY">Frequency quantity</param>
		/// <param name="m3FRUM">Frequency U/M</param>
		/// <param name="m3SMSZ">Sample size</param>
		/// <param name="m3SMUM">Sample U/M</param>
		/// <param name="m3DSSM">Discard sample</param>
		/// <param name="m3RTSM">Retain sample</param>
		/// <param name="m3TCAL">Calculated by formula</param>
		/// <param name="m3TCLS">Test classification</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3ITQR">Include test in QI request</param>
		/// <param name="m3PTCA">Print test on Certificate of Analysis</param>
		/// <param name="m3PTSP">Print test on specification document</param>
		/// <param name="m3DUSM">Sample usage</param>
		/// <param name="m3QPTT">Print spec test values</param>
		/// <param name="m3QPTR">Print result value</param>
		/// <param name="m3CDOR">Copy DO results</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSpecTest(
			string m3SPEC, 
			DateTime m3QSE1, 
			string m3QTST, 
			int m3TSTY, 
			DateTime m3QTE1, 
			DateTime m3QTI1, 
			string m3TX40, 
			int m3EXSQ, 
			int m3VLTP, 
			int m3QTSP, 
			int? m3QSE2 = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
			int? m3QTE2 = null, 
			int? m3QTI2 = null, 
			string m3QTCD = null, 
			string m3QLCD = null, 
			string m3ATID = null, 
			string m3MSUR = null, 
			string m3MSIN = null, 
			string m3DEPT = null, 
			string m3LABO = null, 
			string m3SMTP = null, 
			string m3INSD = null, 
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
			string m3TEUM = null, 
			int? m3DCCD = null, 
			int? m3REQD = null, 
			int? m3SMPR = null, 
			int? m3INTR = null, 
			int? m3FRPR = null, 
			int? m3FRTI = null, 
			decimal? m3FRQY = null, 
			string m3FRUM = null, 
			decimal? m3SMSZ = null, 
			string m3SMUM = null, 
			int? m3DSSM = null, 
			int? m3RTSM = null, 
			int? m3TCAL = null, 
			string m3TCLS = null, 
			decimal? m3TXID = null, 
			int? m3ITQR = null, 
			int? m3PTCA = null, 
			int? m3PTSP = null, 
			int? m3DUSM = null, 
			int? m3QPTT = null, 
			int? m3QPTR = null, 
			int? m3CDOR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdSpecTest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SPEC))
				throw new ArgumentNullException(nameof(m3SPEC));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPEC", m3SPEC.Trim())
				.WithQueryParameter("QSE1", m3QSE1.ToM3String())
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QTE1", m3QTE1.ToM3String())
				.WithQueryParameter("QTI1", m3QTI1.ToM3String())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("EXSQ", m3EXSQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VLTP", m3VLTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QTSP", m3QTSP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3QTE2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTI2.HasValue)
				request.WithQueryParameter("QTI2", m3QTI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QTCD))
				request.WithQueryParameter("QTCD", m3QTCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3QLCD))
				request.WithQueryParameter("QLCD", m3QLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSUR))
				request.WithQueryParameter("MSUR", m3MSUR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSIN))
				request.WithQueryParameter("MSIN", m3MSIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3LABO))
				request.WithQueryParameter("LABO", m3LABO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMTP))
				request.WithQueryParameter("SMTP", m3SMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSD))
				request.WithQueryParameter("INSD", m3INSD.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3TEUM))
				request.WithQueryParameter("TEUM", m3TEUM.Trim());
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REQD.HasValue)
				request.WithQueryParameter("REQD", m3REQD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SMPR.HasValue)
				request.WithQueryParameter("SMPR", m3SMPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INTR.HasValue)
				request.WithQueryParameter("INTR", m3INTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRPR.HasValue)
				request.WithQueryParameter("FRPR", m3FRPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRTI.HasValue)
				request.WithQueryParameter("FRTI", m3FRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRQY.HasValue)
				request.WithQueryParameter("FRQY", m3FRQY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRUM))
				request.WithQueryParameter("FRUM", m3FRUM.Trim());
			if (m3SMSZ.HasValue)
				request.WithQueryParameter("SMSZ", m3SMSZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SMUM))
				request.WithQueryParameter("SMUM", m3SMUM.Trim());
			if (m3DSSM.HasValue)
				request.WithQueryParameter("DSSM", m3DSSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTSM.HasValue)
				request.WithQueryParameter("RTSM", m3RTSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCAL.HasValue)
				request.WithQueryParameter("TCAL", m3TCAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TCLS))
				request.WithQueryParameter("TCLS", m3TCLS.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ITQR.HasValue)
				request.WithQueryParameter("ITQR", m3ITQR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PTCA.HasValue)
				request.WithQueryParameter("PTCA", m3PTCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PTSP.HasValue)
				request.WithQueryParameter("PTSP", m3PTSP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DUSM.HasValue)
				request.WithQueryParameter("DUSM", m3DUSM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPTT.HasValue)
				request.WithQueryParameter("QPTT", m3QPTT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPTR.HasValue)
				request.WithQueryParameter("QPTR", m3QPTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CDOR.HasValue)
				request.WithQueryParameter("CDOR", m3CDOR.Value.ToString(CultureInfo.CurrentCulture));

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
