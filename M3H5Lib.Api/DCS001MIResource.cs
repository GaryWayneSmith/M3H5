/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.DCS001MI;
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
	/// Name: DCS001MI
	/// Component Name: DataCollection
	/// Description: Data Collection interface
	/// Version Release: 10.6
	///</summary>
	public partial class DCS001MIResource : M3BaseResourceEndpoint
	{
		public DCS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "DCS001MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ChangeTeam
		/// Description Change/connect/disconnect to workgroup
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TMNO">Workgroup (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangeTeam(
			string m3_CANO, 
			string m3_TMNO, 
			string m3_TENR = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChangeTeam",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");
			if (string.IsNullOrWhiteSpace(m3_TMNO))
				throw new ArgumentNullException("m3_TMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim())
				.WithQueryParameter("TMNO", m3_TMNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name ChgCostCenter
		/// Description Change cost center of attendance time
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_SHNO">Reference number for cost center (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgCostCenter(
			string m3_CANO, 
			string m3_SHNO, 
			string m3_TENR = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgCostCenter",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");
			if (string.IsNullOrWhiteSpace(m3_SHNO))
				throw new ArgumentNullException("m3_SHNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim())
				.WithQueryParameter("SHNO", m3_SHNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name FixedTime
		/// Description Fixed time, transaction type U0
		/// Version Release: 11.5
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_TTPE">Time type</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> FixedTime(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_TTPE = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/FixedTime",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TTPE))
				request.WithQueryParameter("TTPE", m3_TTPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name GetStatusByCard
		/// Description Retrieve Status of Operation By Card Number
		/// Version Release: 12.6
		/// </summary>
		/// <param name="m3_CANO">Card Number (Required)</param>
		/// <param name="m3_WOSQ">Operations reporting number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStatusByCardResponse></returns>
		/// <exception cref="M3Exception<GetStatusByCardResponse>"></exception>
		public async Task<M3Response<GetStatusByCardResponse>> GetStatusByCard(
			long m3_CANO, 
			int m3_WOSQ, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetStatusByCard",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.ToString())
				.WithQueryParameter("WOSQ", m3_WOSQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetStatusByCardResponse>(
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
		/// Name In
		/// Description In normal
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_ABCD">Absence reason</param>
		/// <param name="m3_SHNO">Reference number for cost center</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> In(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_ABCD = null, 
			string m3_SHNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/In",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHNO))
				request.WithQueryParameter("SHNO", m3_SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name InOverTimeComp
		/// Description In overtime compensation time
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_ABCD">Absence reason</param>
		/// <param name="m3_SHNO">Reference number for cost center</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOverTimeComp(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_ABCD = null, 
			string m3_SHNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InOverTimeComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHNO))
				request.WithQueryParameter("SHNO", m3_SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name InOverTimePaid
		/// Description In overtime paid
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_ABCD">Absence reason</param>
		/// <param name="m3_SHNO">Reference number for cost center</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOverTimePaid(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_ABCD = null, 
			string m3_SHNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InOverTimePaid",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHNO))
				request.WithQueryParameter("SHNO", m3_SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name InOverTimeUD2
		/// Description In overtime user defined
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_ABCD">Absence reason</param>
		/// <param name="m3_SHNO">Reference number for cost center</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOverTimeUD2(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_ABCD = null, 
			string m3_SHNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InOverTimeUD2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHNO))
				request.WithQueryParameter("SHNO", m3_SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name InOverTimeUD3
		/// Description In overtime user defined
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_ABCD">Absence reason</param>
		/// <param name="m3_SHNO">Reference number for cost center</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOverTimeUD3(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_ABCD = null, 
			string m3_SHNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InOverTimeUD3",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHNO))
				request.WithQueryParameter("SHNO", m3_SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name InOverTimeUDef
		/// Description In overtime user defined
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_ABCD">Absence reason</param>
		/// <param name="m3_SHNO">Reference number for cost center</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOverTimeUDef(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_ABCD = null, 
			string m3_SHNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InOverTimeUDef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHNO))
				request.WithQueryParameter("SHNO", m3_SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name Out
		/// Description Out normal
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_ABCD">Absence reason</param>
		/// <param name="m3_SHNO">Reference number for cost center</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Out(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_ABCD = null, 
			string m3_SHNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Out",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHNO))
				request.WithQueryParameter("SHNO", m3_SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name OutOverTimeComp
		/// Description Out overtime compensation time
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_ABCD">Absence reason</param>
		/// <param name="m3_SHNO">Reference number for cost center</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOverTimeComp(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_ABCD = null, 
			string m3_SHNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/OutOverTimeComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHNO))
				request.WithQueryParameter("SHNO", m3_SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name OutOverTimePaid
		/// Description Out overtime paid
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_ABCD">Absence reason</param>
		/// <param name="m3_SHNO">Reference number for cost center</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOverTimePaid(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_ABCD = null, 
			string m3_SHNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/OutOverTimePaid",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHNO))
				request.WithQueryParameter("SHNO", m3_SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name OutOverTimeUD2
		/// Description Out overtime user defined
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_ABCD">Absence reason</param>
		/// <param name="m3_SHNO">Reference number for cost center</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOverTimeUD2(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_ABCD = null, 
			string m3_SHNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/OutOverTimeUD2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHNO))
				request.WithQueryParameter("SHNO", m3_SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name OutOverTimeUD3
		/// Description Out overtime user defined
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_ABCD">Absence reason</param>
		/// <param name="m3_SHNO">Reference number for cost center</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOverTimeUD3(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_ABCD = null, 
			string m3_SHNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/OutOverTimeUD3",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHNO))
				request.WithQueryParameter("SHNO", m3_SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name OutOverTimeUDef
		/// Description Out overtime user defined
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_ABCD">Absence reason</param>
		/// <param name="m3_SHNO">Reference number for cost center</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOverTimeUDef(
			string m3_CANO, 
			string m3_TENR = null, 
			string m3_ABCD = null, 
			string m3_SHNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/OutOverTimeUDef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABCD))
				request.WithQueryParameter("ABCD", m3_ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHNO))
				request.WithQueryParameter("SHNO", m3_SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name PlannedAbsence
		/// Description Planned absence
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_ABCD">Absence reason (Required)</param>
		/// <param name="m3_FRSD">Planned absence from schedule date (Required)</param>
		/// <param name="m3_TOSD">Planned absence to schedule date (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PlannedAbsence(
			string m3_CANO, 
			string m3_ABCD, 
			string m3_FRSD, 
			string m3_TOSD, 
			string m3_TENR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PlannedAbsence",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");
			if (string.IsNullOrWhiteSpace(m3_ABCD))
				throw new ArgumentNullException("m3_ABCD");
			if (string.IsNullOrWhiteSpace(m3_FRSD))
				throw new ArgumentNullException("m3_FRSD");
			if (string.IsNullOrWhiteSpace(m3_TOSD))
				throw new ArgumentNullException("m3_TOSD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim())
				.WithQueryParameter("ABCD", m3_ABCD.Trim())
				.WithQueryParameter("FRSD", m3_FRSD.Trim())
				.WithQueryParameter("TOSD", m3_TOSD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());

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
		/// Name PutAwayMO
		/// Description Put-away on working order
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_WOSQ">Reporting number (Required)</param>
		/// <param name="m3_MAQA">Produced quantity (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_POCY">Potency</param>
		/// <param name="m3_REND">Completion flag</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_PLNO">Production lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PutAwayMO(
			string m3_CANO, 
			string m3_WOSQ, 
			string m3_MAQA, 
			string m3_TENR = null, 
			string m3_BANO = null, 
			string m3_WHSL = null, 
			string m3_POCY = null, 
			string m3_REND = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
			string m3_CAMU = null, 
			long? m3_PLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PutAwayMO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");
			if (string.IsNullOrWhiteSpace(m3_WOSQ))
				throw new ArgumentNullException("m3_WOSQ");
			if (string.IsNullOrWhiteSpace(m3_MAQA))
				throw new ArgumentNullException("m3_MAQA");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim())
				.WithQueryParameter("WOSQ", m3_WOSQ.Trim())
				.WithQueryParameter("MAQA", m3_MAQA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POCY))
				request.WithQueryParameter("POCY", m3_POCY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REND))
				request.WithQueryParameter("REND", m3_REND.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3_PLNO.Value.ToString());

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
		/// Name QueryBalance
		/// Description Balance inquiry
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_TTPE">Balance identity (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<QueryBalanceResponse></returns>
		/// <exception cref="M3Exception<QueryBalanceResponse>"></exception>
		public async Task<M3Response<QueryBalanceResponse>> QueryBalance(
			string m3_CANO, 
			string m3_TTPE, 
			string m3_TENR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/QueryBalance",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");
			if (string.IsNullOrWhiteSpace(m3_TTPE))
				throw new ArgumentNullException("m3_TTPE");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim())
				.WithQueryParameter("TTPE", m3_TTPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());

			// Execute the request
			var result = await Execute<QueryBalanceResponse>(
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
		/// Name StartActivity
		/// Description Start activity time
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_PJID">Activity number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartActivity(
			string m3_CANO, 
			string m3_PJID, 
			string m3_TENR = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartActivity",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");
			if (string.IsNullOrWhiteSpace(m3_PJID))
				throw new ArgumentNullException("m3_PJID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim())
				.WithQueryParameter("PJID", m3_PJID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name StartDisturb
		/// Description Report start of disturbance
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_WOSQ">Reporting number (Required)</param>
		/// <param name="m3_DISE">Disturbance code (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartDisturb(
			string m3_CANO, 
			string m3_WOSQ, 
			string m3_DISE, 
			string m3_TENR = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartDisturb",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");
			if (string.IsNullOrWhiteSpace(m3_WOSQ))
				throw new ArgumentNullException("m3_WOSQ");
			if (string.IsNullOrWhiteSpace(m3_DISE))
				throw new ArgumentNullException("m3_DISE");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim())
				.WithQueryParameter("WOSQ", m3_WOSQ.Trim())
				.WithQueryParameter("DISE", m3_DISE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name StartWorkOp
		/// Description Start work on operation
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_WOSQ">Reporting number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_TMNO">Work group</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="m3_PLNO">Production lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartWorkOp(
			long m3_CANO, 
			string m3_WOSQ, 
			string m3_TENR = null, 
			string m3_TMNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
			long? m3_PLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartWorkOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WOSQ))
				throw new ArgumentNullException("m3_WOSQ");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.ToString())
				.WithQueryParameter("WOSQ", m3_WOSQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TMNO))
				request.WithQueryParameter("TMNO", m3_TMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());
			if (m3_PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3_PLNO.Value.ToString());

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
		/// Name StartWorkSetup
		/// Description Start work on setup
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_WOSQ">Reporting number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_TMNO">Work group</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Repoting time</param>
		/// <param name="m3_PLNO">Production lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartWorkSetup(
			string m3_CANO, 
			string m3_WOSQ, 
			string m3_TENR = null, 
			string m3_TMNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
			long? m3_PLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartWorkSetup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");
			if (string.IsNullOrWhiteSpace(m3_WOSQ))
				throw new ArgumentNullException("m3_WOSQ");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim())
				.WithQueryParameter("WOSQ", m3_WOSQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TMNO))
				request.WithQueryParameter("TMNO", m3_TMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());
			if (m3_PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3_PLNO.Value.ToString());

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
		/// Name StockIssueMO
		/// Description Stock issue on working order
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_WOSQ">Reporting number (Required)</param>
		/// <param name="m3_RPQA">Issued quantity (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_REND">Completion flag</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StockIssueMO(
			string m3_CANO, 
			string m3_WOSQ, 
			string m3_RPQA, 
			string m3_TENR = null, 
			string m3_REND = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StockIssueMO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");
			if (string.IsNullOrWhiteSpace(m3_WOSQ))
				throw new ArgumentNullException("m3_WOSQ");
			if (string.IsNullOrWhiteSpace(m3_RPQA))
				throw new ArgumentNullException("m3_RPQA");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim())
				.WithQueryParameter("WOSQ", m3_WOSQ.Trim())
				.WithQueryParameter("RPQA", m3_RPQA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REND))
				request.WithQueryParameter("REND", m3_REND.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());

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
		/// Name StopActivity
		/// Description Stop activity time
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_PJID">Activity number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopActivity(
			string m3_CANO, 
			string m3_PJID, 
			string m3_TENR = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StopActivity",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");
			if (string.IsNullOrWhiteSpace(m3_PJID))
				throw new ArgumentNullException("m3_PJID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim())
				.WithQueryParameter("PJID", m3_PJID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name StopDisturb
		/// Description Report stop of disturbance
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_WOSQ">Reporting number (Required)</param>
		/// <param name="m3_DISE">Disturbance code (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopDisturb(
			string m3_CANO, 
			string m3_WOSQ, 
			string m3_DISE, 
			string m3_TENR = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StopDisturb",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");
			if (string.IsNullOrWhiteSpace(m3_WOSQ))
				throw new ArgumentNullException("m3_WOSQ");
			if (string.IsNullOrWhiteSpace(m3_DISE))
				throw new ArgumentNullException("m3_DISE");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim())
				.WithQueryParameter("WOSQ", m3_WOSQ.Trim())
				.WithQueryParameter("DISE", m3_DISE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name StopWorkOp
		/// Description Stop work on operation
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_WOSQ">Reporting number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_MAQA">Produced quantity</param>
		/// <param name="m3_SCQA">Rejected quantity</param>
		/// <param name="m3_SCRE">Rejected reason</param>
		/// <param name="m3_TMNO">Work group</param>
		/// <param name="m3_REND">Completion flag</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopWorkOp(
			long m3_CANO, 
			string m3_WOSQ, 
			string m3_TENR = null, 
			string m3_MAQA = null, 
			string m3_SCQA = null, 
			string m3_SCRE = null, 
			string m3_TMNO = null, 
			string m3_REND = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StopWorkOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WOSQ))
				throw new ArgumentNullException("m3_WOSQ");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.ToString())
				.WithQueryParameter("WOSQ", m3_WOSQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAQA))
				request.WithQueryParameter("MAQA", m3_MAQA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCQA))
				request.WithQueryParameter("SCQA", m3_SCQA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TMNO))
				request.WithQueryParameter("TMNO", m3_TMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REND))
				request.WithQueryParameter("REND", m3_REND.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
		/// Name StopWorkSetup
		/// Description Stop work on setup
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_WOSQ">Reporting number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_TMNO">Work group</param>
		/// <param name="m3_SDAT">Reporting date</param>
		/// <param name="m3_STTE">Repoting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopWorkSetup(
			string m3_CANO, 
			string m3_WOSQ, 
			string m3_TENR = null, 
			string m3_TMNO = null, 
			string m3_SDAT = null, 
			string m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StopWorkSetup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CANO))
				throw new ArgumentNullException("m3_CANO");
			if (string.IsNullOrWhiteSpace(m3_WOSQ))
				throw new ArgumentNullException("m3_WOSQ");

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.Trim())
				.WithQueryParameter("WOSQ", m3_WOSQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TMNO))
				request.WithQueryParameter("TMNO", m3_TMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDAT))
				request.WithQueryParameter("SDAT", m3_SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTE))
				request.WithQueryParameter("STTE", m3_STTE.Trim());

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
