/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddResultSeq
		/// Description Add a new test result sequence
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_NBEX">Number of copies (Required)</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SI01">Comments</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QTE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddResultSeq(
			string m3_FACI, 
			string m3_QTST, 
			int m3_TSTY, 
			int m3_NBEX, 
			string m3_QRID = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_SI01 = null, 
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			DateTime? m3_QTE1 = null, 
			int? m3_QSE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddResultSeq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("TSTY", m3_TSTY.ToString())
				.WithQueryParameter("NBEX", m3_NBEX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI01))
				request.WithQueryParameter("SI01", m3_SI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3_QTE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
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
		/// Name CalcSettlement
		/// Description CalcSettlement
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CalcSettlement(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CalcSettlement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
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
		/// Name DltTestResults
		/// Description Delete a QI test result record
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_TSEQ">Sequence number (Required)</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QTE1">Effective date</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltTestResults(
			string m3_FACI, 
			string m3_QTST, 
			int m3_TSTY, 
			int m3_TSEQ, 
			string m3_QRID = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_SPEC = null, 
			DateTime? m3_QTE1 = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QTE2 = null, 
			int? m3_QSE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltTestResults",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("TSTY", m3_TSTY.ToString())
				.WithQueryParameter("TSEQ", m3_TSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3_QTE1.Value.ToM3String());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());

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
		/// Name GetTestResults
		/// Description List details for a QI test result
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_TSEQ">Sequence number (Required)</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTestResultsResponse></returns>
		/// <exception cref="M3Exception<GetTestResultsResponse>"></exception>
		public async Task<M3Response<GetTestResultsResponse>> GetTestResults(
			string m3_FACI, 
			string m3_QTST, 
			int m3_TSTY, 
			int m3_TSEQ, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTestResults",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("TSTY", m3_TSTY.ToString())
				.WithQueryParameter("TSEQ", m3_TSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<GetTestResultsResponse>(
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
		/// Name LstTestResults
		/// Description List details for a QI test result
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_QTST">Test</param>
		/// <param name="m3_TSTY">Test type</param>
		/// <param name="m3_TSEQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTestResultsResponse></returns>
		/// <exception cref="M3Exception<LstTestResultsResponse>"></exception>
		public async Task<M3Response<LstTestResultsResponse>> LstTestResults(
			string m3_FACI, 
			string m3_QRID = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_QTST = null, 
			int? m3_TSTY = null, 
			int? m3_TSEQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTestResults",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QTST))
				request.WithQueryParameter("QTST", m3_QTST.Trim());
			if (m3_TSTY.HasValue)
				request.WithQueryParameter("TSTY", m3_TSTY.Value.ToString());
			if (m3_TSEQ.HasValue)
				request.WithQueryParameter("TSEQ", m3_TSEQ.Value.ToString());

			// Execute the request
			var result = await Execute<LstTestResultsResponse>(
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
		/// Name SearchQITestRes
		/// Description SearchQITestRes
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchQITestResResponse></returns>
		/// <exception cref="M3Exception<SearchQITestResResponse>"></exception>
		public async Task<M3Response<SearchQITestResResponse>> SearchQITestRes(
			string m3_SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchQITestRes",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchQITestResResponse>(
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
		/// Name UpdCalcTests
		/// Description UpdCalcTests
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_QRID">QI request ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCalcTests(
			string m3_FACI, 
			string m3_QRID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCalcTests",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_QRID))
				throw new ArgumentNullException("m3_QRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("QRID", m3_QRID.Trim());

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
		/// Name UpdTestResult
		/// Description Update test result, add new sequence if provided
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_QTST">Test (Required)</param>
		/// <param name="m3_TSTY">Test type (Required)</param>
		/// <param name="m3_TSEQ">Sequence number (Required)</param>
		/// <param name="m3_VLEN">Value entered (Required)</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_QOP1">Expected operator</param>
		/// <param name="m3_QTRS">Test result</param>
		/// <param name="m3_QLCD">Test result</param>
		/// <param name="m3_TTUS">Tested by</param>
		/// <param name="m3_TTDT">Tested date</param>
		/// <param name="m3_TTTE">Tested time</param>
		/// <param name="m3_QRSN">Reason</param>
		/// <param name="m3_SI01">Comments</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QTE1">Effective date</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_UPCT">Update calculated test</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTestResult(
			string m3_FACI, 
			string m3_QTST, 
			int m3_TSTY, 
			int m3_TSEQ, 
			int m3_VLEN, 
			string m3_QRID = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			int? m3_QOP1 = null, 
			decimal? m3_QTRS = null, 
			string m3_QLCD = null, 
			string m3_TTUS = null, 
			DateTime? m3_TTDT = null, 
			int? m3_TTTE = null, 
			string m3_QRSN = null, 
			string m3_SI01 = null, 
			string m3_SPEC = null, 
			DateTime? m3_QTE1 = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QTE2 = null, 
			int? m3_QSE2 = null, 
			int? m3_UPCT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTestResult",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_QTST))
				throw new ArgumentNullException("m3_QTST");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("QTST", m3_QTST.Trim())
				.WithQueryParameter("TSTY", m3_TSTY.ToString())
				.WithQueryParameter("TSEQ", m3_TSEQ.ToString())
				.WithQueryParameter("VLEN", m3_VLEN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_QOP1.HasValue)
				request.WithQueryParameter("QOP1", m3_QOP1.Value.ToString());
			if (m3_QTRS.HasValue)
				request.WithQueryParameter("QTRS", m3_QTRS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QLCD))
				request.WithQueryParameter("QLCD", m3_QLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TTUS))
				request.WithQueryParameter("TTUS", m3_TTUS.Trim());
			if (m3_TTDT.HasValue)
				request.WithQueryParameter("TTDT", m3_TTDT.Value.ToM3String());
			if (m3_TTTE.HasValue)
				request.WithQueryParameter("TTTE", m3_TTTE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QRSN))
				request.WithQueryParameter("QRSN", m3_QRSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI01))
				request.WithQueryParameter("SI01", m3_SI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3_QTE1.Value.ToM3String());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (m3_UPCT.HasValue)
				request.WithQueryParameter("UPCT", m3_UPCT.Value.ToString());

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
