/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.QMS400MI;
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
	/// Name: QMS400MI
	/// Component Name: QIRequestTestResult
	/// Description: QI Request Test Result
	/// Version Release: 5ea2
	///</summary>
	public partial class QMS400MIResource : M3BaseResourceEndpoint
	{
		public QMS400MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS400MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddResultSeq
		/// Description Add a new test result sequence
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3NBEX">Number of copies (Required)</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SI01">Comments</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QTE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3QTE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddResultSeq(
			string m3FACI, 
			string m3QTST, 
			int m3TSTY, 
			int m3NBEX, 
			string m3QRID = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3SI01 = null, 
			string m3SPEC = null, 
			DateTime? m3QSE1 = null, 
			DateTime? m3QTE1 = null, 
			int? m3QSE2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddResultSeq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("NBEX", m3NBEX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI01))
				request.WithQueryParameter("SI01", m3SI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3QTE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name CalcSettlement
		/// Description CalcSettlement
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CalcSettlement(
			int? m3CONO = null, 
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CalcSettlement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name DltTestResults
		/// Description Delete a QI test result record
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3TSEQ">Sequence number (Required)</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QTE1">Effective date</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QTE2">Effective time</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltTestResults(
			string m3FACI, 
			string m3QTST, 
			int m3TSTY, 
			int m3TSEQ, 
			string m3QRID = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3SPEC = null, 
			DateTime? m3QTE1 = null, 
			DateTime? m3QSE1 = null, 
			int? m3QTE2 = null, 
			int? m3QSE2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltTestResults",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TSEQ", m3TSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3QTE1.Value.ToM3String());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3QTE2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetTestResults
		/// Description List details for a QI test result
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3TSEQ">Sequence number (Required)</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTestResultsResponse></returns>
		/// <exception cref="M3Exception<GetTestResultsResponse>"></exception>
		public async Task<M3Response<GetTestResultsResponse>> GetTestResults(
			string m3FACI, 
			string m3QTST, 
			int m3TSTY, 
			int m3TSEQ, 
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetTestResults",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TSEQ", m3TSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<GetTestResultsResponse>(
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
		/// Name LstTestResults
		/// Description List details for a QI test result
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3QTST">Test</param>
		/// <param name="m3TSTY">Test type</param>
		/// <param name="m3TSEQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTestResultsResponse></returns>
		/// <exception cref="M3Exception<LstTestResultsResponse>"></exception>
		public async Task<M3Response<LstTestResultsResponse>> LstTestResults(
			string m3FACI, 
			string m3QRID = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3QTST = null, 
			int? m3TSTY = null, 
			int? m3TSEQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTestResults",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QTST))
				request.WithQueryParameter("QTST", m3QTST.Trim());
			if (m3TSTY.HasValue)
				request.WithQueryParameter("TSTY", m3TSTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TSEQ.HasValue)
				request.WithQueryParameter("TSEQ", m3TSEQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstTestResultsResponse>(
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
		/// Name SearchQITestRes
		/// Description SearchQITestRes
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchQITestResResponse></returns>
		/// <exception cref="M3Exception<SearchQITestResResponse>"></exception>
		public async Task<M3Response<SearchQITestResResponse>> SearchQITestRes(
			string m3SQRY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchQITestRes",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchQITestResResponse>(
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
		/// Name UpdCalcTests
		/// Description UpdCalcTests
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3QRID">QI request ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCalcTests(
			string m3FACI, 
			string m3QRID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdCalcTests",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3QRID))
				throw new ArgumentNullException(nameof(m3QRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("QRID", m3QRID.Trim());

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
		/// Name UpdTestResult
		/// Description Update test result, add new sequence if provided
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3QTST">Test (Required)</param>
		/// <param name="m3TSTY">Test type (Required)</param>
		/// <param name="m3TSEQ">Sequence number (Required)</param>
		/// <param name="m3VLEN">Value entered (Required)</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3QOP1">Expected operator</param>
		/// <param name="m3QTRS">Test result</param>
		/// <param name="m3QLCD">Test result</param>
		/// <param name="m3TTUS">Tested by</param>
		/// <param name="m3TTDT">Tested date</param>
		/// <param name="m3TTTE">Tested time</param>
		/// <param name="m3QRSN">Reason</param>
		/// <param name="m3SI01">Comments</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QTE1">Effective date</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QTE2">Effective time</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3UPCT">Update calculated test</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTestResult(
			string m3FACI, 
			string m3QTST, 
			int m3TSTY, 
			int m3TSEQ, 
			int m3VLEN, 
			string m3QRID = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			int? m3QOP1 = null, 
			decimal? m3QTRS = null, 
			string m3QLCD = null, 
			string m3TTUS = null, 
			DateTime? m3TTDT = null, 
			int? m3TTTE = null, 
			string m3QRSN = null, 
			string m3SI01 = null, 
			string m3SPEC = null, 
			DateTime? m3QTE1 = null, 
			DateTime? m3QSE1 = null, 
			int? m3QTE2 = null, 
			int? m3QSE2 = null, 
			int? m3UPCT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdTestResult",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3QTST))
				throw new ArgumentNullException(nameof(m3QTST));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("QTST", m3QTST.Trim())
				.WithQueryParameter("TSTY", m3TSTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TSEQ", m3TSEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VLEN", m3VLEN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3QOP1.HasValue)
				request.WithQueryParameter("QOP1", m3QOP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTRS.HasValue)
				request.WithQueryParameter("QTRS", m3QTRS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QLCD))
				request.WithQueryParameter("QLCD", m3QLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TTUS))
				request.WithQueryParameter("TTUS", m3TTUS.Trim());
			if (m3TTDT.HasValue)
				request.WithQueryParameter("TTDT", m3TTDT.Value.ToM3String());
			if (m3TTTE.HasValue)
				request.WithQueryParameter("TTTE", m3TTTE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QRSN))
				request.WithQueryParameter("QRSN", m3QRSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI01))
				request.WithQueryParameter("SI01", m3SI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3QTE1.Value.ToM3String());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3QTE2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPCT.HasValue)
				request.WithQueryParameter("UPCT", m3UPCT.Value.ToString(CultureInfo.CurrentCulture));

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
