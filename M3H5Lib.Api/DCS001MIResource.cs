/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ChangeTeam
		/// Description Change/connect/disconnect to workgroup
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TMNO">Workgroup (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangeTeam(
			string m3CANO, 
			string m3TMNO, 
			string m3TENR = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChangeTeam",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));
			if (string.IsNullOrWhiteSpace(m3TMNO))
				throw new ArgumentNullException(nameof(m3TMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim())
				.WithQueryParameter("TMNO", m3TMNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name ChgCostCenter
		/// Description Change cost center of attendance time
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3SHNO">Reference number for cost center (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgCostCenter(
			string m3CANO, 
			string m3SHNO, 
			string m3TENR = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgCostCenter",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));
			if (string.IsNullOrWhiteSpace(m3SHNO))
				throw new ArgumentNullException(nameof(m3SHNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim())
				.WithQueryParameter("SHNO", m3SHNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name FixedTime
		/// Description Fixed time, transaction type U0
		/// Version Release: 11.5
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3TTPE">Time type</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> FixedTime(
			string m3CANO, 
			string m3TENR = null, 
			string m3TTPE = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/FixedTime",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TTPE))
				request.WithQueryParameter("TTPE", m3TTPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name GetStatusByCard
		/// Description Retrieve Status of Operation By Card Number
		/// Version Release: 12.6
		/// </summary>
		/// <param name="m3CANO">Card Number (Required)</param>
		/// <param name="m3WOSQ">Operations reporting number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStatusByCardResponse></returns>
		/// <exception cref="M3Exception<GetStatusByCardResponse>"></exception>
		public async Task<M3Response<GetStatusByCardResponse>> GetStatusByCard(
			long m3CANO, 
			int m3WOSQ, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetStatusByCard",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WOSQ", m3WOSQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetStatusByCardResponse>(
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
		/// Name In
		/// Description In normal
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3ABCD">Absence reason</param>
		/// <param name="m3SHNO">Reference number for cost center</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> In(
			string m3CANO, 
			string m3TENR = null, 
			string m3ABCD = null, 
			string m3SHNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/In",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHNO))
				request.WithQueryParameter("SHNO", m3SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name InOverTimeComp
		/// Description In overtime compensation time
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3ABCD">Absence reason</param>
		/// <param name="m3SHNO">Reference number for cost center</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOverTimeComp(
			string m3CANO, 
			string m3TENR = null, 
			string m3ABCD = null, 
			string m3SHNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/InOverTimeComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHNO))
				request.WithQueryParameter("SHNO", m3SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name InOverTimePaid
		/// Description In overtime paid
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3ABCD">Absence reason</param>
		/// <param name="m3SHNO">Reference number for cost center</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOverTimePaid(
			string m3CANO, 
			string m3TENR = null, 
			string m3ABCD = null, 
			string m3SHNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/InOverTimePaid",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHNO))
				request.WithQueryParameter("SHNO", m3SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name InOverTimeUD2
		/// Description In overtime user defined
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3ABCD">Absence reason</param>
		/// <param name="m3SHNO">Reference number for cost center</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOverTimeUD2(
			string m3CANO, 
			string m3TENR = null, 
			string m3ABCD = null, 
			string m3SHNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/InOverTimeUD2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHNO))
				request.WithQueryParameter("SHNO", m3SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name InOverTimeUD3
		/// Description In overtime user defined
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3ABCD">Absence reason</param>
		/// <param name="m3SHNO">Reference number for cost center</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOverTimeUD3(
			string m3CANO, 
			string m3TENR = null, 
			string m3ABCD = null, 
			string m3SHNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/InOverTimeUD3",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHNO))
				request.WithQueryParameter("SHNO", m3SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name InOverTimeUDef
		/// Description In overtime user defined
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3ABCD">Absence reason</param>
		/// <param name="m3SHNO">Reference number for cost center</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOverTimeUDef(
			string m3CANO, 
			string m3TENR = null, 
			string m3ABCD = null, 
			string m3SHNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/InOverTimeUDef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHNO))
				request.WithQueryParameter("SHNO", m3SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name Out
		/// Description Out normal
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3ABCD">Absence reason</param>
		/// <param name="m3SHNO">Reference number for cost center</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Out(
			string m3CANO, 
			string m3TENR = null, 
			string m3ABCD = null, 
			string m3SHNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Out",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHNO))
				request.WithQueryParameter("SHNO", m3SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name OutOverTimeComp
		/// Description Out overtime compensation time
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3ABCD">Absence reason</param>
		/// <param name="m3SHNO">Reference number for cost center</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOverTimeComp(
			string m3CANO, 
			string m3TENR = null, 
			string m3ABCD = null, 
			string m3SHNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/OutOverTimeComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHNO))
				request.WithQueryParameter("SHNO", m3SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name OutOverTimePaid
		/// Description Out overtime paid
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3ABCD">Absence reason</param>
		/// <param name="m3SHNO">Reference number for cost center</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOverTimePaid(
			string m3CANO, 
			string m3TENR = null, 
			string m3ABCD = null, 
			string m3SHNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/OutOverTimePaid",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHNO))
				request.WithQueryParameter("SHNO", m3SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name OutOverTimeUD2
		/// Description Out overtime user defined
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3ABCD">Absence reason</param>
		/// <param name="m3SHNO">Reference number for cost center</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOverTimeUD2(
			string m3CANO, 
			string m3TENR = null, 
			string m3ABCD = null, 
			string m3SHNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/OutOverTimeUD2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHNO))
				request.WithQueryParameter("SHNO", m3SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name OutOverTimeUD3
		/// Description Out overtime user defined
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3ABCD">Absence reason</param>
		/// <param name="m3SHNO">Reference number for cost center</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOverTimeUD3(
			string m3CANO, 
			string m3TENR = null, 
			string m3ABCD = null, 
			string m3SHNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/OutOverTimeUD3",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHNO))
				request.WithQueryParameter("SHNO", m3SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name OutOverTimeUDef
		/// Description Out overtime user defined
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3ABCD">Absence reason</param>
		/// <param name="m3SHNO">Reference number for cost center</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOverTimeUDef(
			string m3CANO, 
			string m3TENR = null, 
			string m3ABCD = null, 
			string m3SHNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/OutOverTimeUDef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABCD))
				request.WithQueryParameter("ABCD", m3ABCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHNO))
				request.WithQueryParameter("SHNO", m3SHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name PlannedAbsence
		/// Description Planned absence
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3ABCD">Absence reason (Required)</param>
		/// <param name="m3FRSD">Planned absence from schedule date (Required)</param>
		/// <param name="m3TOSD">Planned absence to schedule date (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PlannedAbsence(
			string m3CANO, 
			string m3ABCD, 
			string m3FRSD, 
			string m3TOSD, 
			string m3TENR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PlannedAbsence",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));
			if (string.IsNullOrWhiteSpace(m3ABCD))
				throw new ArgumentNullException(nameof(m3ABCD));
			if (string.IsNullOrWhiteSpace(m3FRSD))
				throw new ArgumentNullException(nameof(m3FRSD));
			if (string.IsNullOrWhiteSpace(m3TOSD))
				throw new ArgumentNullException(nameof(m3TOSD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim())
				.WithQueryParameter("ABCD", m3ABCD.Trim())
				.WithQueryParameter("FRSD", m3FRSD.Trim())
				.WithQueryParameter("TOSD", m3TOSD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());

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
		/// Name PutAwayMO
		/// Description Put-away on working order
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3WOSQ">Reporting number (Required)</param>
		/// <param name="m3MAQA">Produced quantity (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3POCY">Potency</param>
		/// <param name="m3REND">Completion flag</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3PLNO">Production lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PutAwayMO(
			string m3CANO, 
			string m3WOSQ, 
			string m3MAQA, 
			string m3TENR = null, 
			string m3BANO = null, 
			string m3WHSL = null, 
			string m3POCY = null, 
			string m3REND = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
			string m3CAMU = null, 
			long? m3PLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PutAwayMO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));
			if (string.IsNullOrWhiteSpace(m3WOSQ))
				throw new ArgumentNullException(nameof(m3WOSQ));
			if (string.IsNullOrWhiteSpace(m3MAQA))
				throw new ArgumentNullException(nameof(m3MAQA));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim())
				.WithQueryParameter("WOSQ", m3WOSQ.Trim())
				.WithQueryParameter("MAQA", m3MAQA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3POCY))
				request.WithQueryParameter("POCY", m3POCY.Trim());
			if (!string.IsNullOrWhiteSpace(m3REND))
				request.WithQueryParameter("REND", m3REND.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3PLNO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name QueryBalance
		/// Description Balance inquiry
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3TTPE">Balance identity (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<QueryBalanceResponse></returns>
		/// <exception cref="M3Exception<QueryBalanceResponse>"></exception>
		public async Task<M3Response<QueryBalanceResponse>> QueryBalance(
			string m3CANO, 
			string m3TTPE, 
			string m3TENR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/QueryBalance",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));
			if (string.IsNullOrWhiteSpace(m3TTPE))
				throw new ArgumentNullException(nameof(m3TTPE));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim())
				.WithQueryParameter("TTPE", m3TTPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());

			// Execute the request
			var result = await Execute<QueryBalanceResponse>(
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
		/// Name StartActivity
		/// Description Start activity time
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3PJID">Activity number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartActivity(
			string m3CANO, 
			string m3PJID, 
			string m3TENR = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartActivity",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));
			if (string.IsNullOrWhiteSpace(m3PJID))
				throw new ArgumentNullException(nameof(m3PJID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim())
				.WithQueryParameter("PJID", m3PJID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name StartDisturb
		/// Description Report start of disturbance
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3WOSQ">Reporting number (Required)</param>
		/// <param name="m3DISE">Disturbance code (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartDisturb(
			string m3CANO, 
			string m3WOSQ, 
			string m3DISE, 
			string m3TENR = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartDisturb",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));
			if (string.IsNullOrWhiteSpace(m3WOSQ))
				throw new ArgumentNullException(nameof(m3WOSQ));
			if (string.IsNullOrWhiteSpace(m3DISE))
				throw new ArgumentNullException(nameof(m3DISE));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim())
				.WithQueryParameter("WOSQ", m3WOSQ.Trim())
				.WithQueryParameter("DISE", m3DISE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name StartWorkOp
		/// Description Start work on operation
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3WOSQ">Reporting number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3TMNO">Work group</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="m3PLNO">Production lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartWorkOp(
			long m3CANO, 
			string m3WOSQ, 
			string m3TENR = null, 
			string m3TMNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
			long? m3PLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartWorkOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WOSQ))
				throw new ArgumentNullException(nameof(m3WOSQ));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WOSQ", m3WOSQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TMNO))
				request.WithQueryParameter("TMNO", m3TMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());
			if (m3PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3PLNO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name StartWorkSetup
		/// Description Start work on setup
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3WOSQ">Reporting number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3TMNO">Work group</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Repoting time</param>
		/// <param name="m3PLNO">Production lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartWorkSetup(
			string m3CANO, 
			string m3WOSQ, 
			string m3TENR = null, 
			string m3TMNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
			long? m3PLNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartWorkSetup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));
			if (string.IsNullOrWhiteSpace(m3WOSQ))
				throw new ArgumentNullException(nameof(m3WOSQ));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim())
				.WithQueryParameter("WOSQ", m3WOSQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TMNO))
				request.WithQueryParameter("TMNO", m3TMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());
			if (m3PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3PLNO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name StockIssueMO
		/// Description Stock issue on working order
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3WOSQ">Reporting number (Required)</param>
		/// <param name="m3RPQA">Issued quantity (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3REND">Completion flag</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StockIssueMO(
			string m3CANO, 
			string m3WOSQ, 
			string m3RPQA, 
			string m3TENR = null, 
			string m3REND = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StockIssueMO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));
			if (string.IsNullOrWhiteSpace(m3WOSQ))
				throw new ArgumentNullException(nameof(m3WOSQ));
			if (string.IsNullOrWhiteSpace(m3RPQA))
				throw new ArgumentNullException(nameof(m3RPQA));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim())
				.WithQueryParameter("WOSQ", m3WOSQ.Trim())
				.WithQueryParameter("RPQA", m3RPQA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3REND))
				request.WithQueryParameter("REND", m3REND.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());

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
		/// Name StopActivity
		/// Description Stop activity time
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3PJID">Activity number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopActivity(
			string m3CANO, 
			string m3PJID, 
			string m3TENR = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopActivity",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));
			if (string.IsNullOrWhiteSpace(m3PJID))
				throw new ArgumentNullException(nameof(m3PJID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim())
				.WithQueryParameter("PJID", m3PJID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name StopDisturb
		/// Description Report stop of disturbance
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3WOSQ">Reporting number (Required)</param>
		/// <param name="m3DISE">Disturbance code (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopDisturb(
			string m3CANO, 
			string m3WOSQ, 
			string m3DISE, 
			string m3TENR = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopDisturb",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));
			if (string.IsNullOrWhiteSpace(m3WOSQ))
				throw new ArgumentNullException(nameof(m3WOSQ));
			if (string.IsNullOrWhiteSpace(m3DISE))
				throw new ArgumentNullException(nameof(m3DISE));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim())
				.WithQueryParameter("WOSQ", m3WOSQ.Trim())
				.WithQueryParameter("DISE", m3DISE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name StopWorkOp
		/// Description Stop work on operation
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3WOSQ">Reporting number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3MAQA">Produced quantity</param>
		/// <param name="m3SCQA">Rejected quantity</param>
		/// <param name="m3SCRE">Rejected reason</param>
		/// <param name="m3TMNO">Work group</param>
		/// <param name="m3REND">Completion flag</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopWorkOp(
			long m3CANO, 
			string m3WOSQ, 
			string m3TENR = null, 
			string m3MAQA = null, 
			string m3SCQA = null, 
			string m3SCRE = null, 
			string m3TMNO = null, 
			string m3REND = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopWorkOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WOSQ))
				throw new ArgumentNullException(nameof(m3WOSQ));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WOSQ", m3WOSQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAQA))
				request.WithQueryParameter("MAQA", m3MAQA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCQA))
				request.WithQueryParameter("SCQA", m3SCQA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TMNO))
				request.WithQueryParameter("TMNO", m3TMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3REND))
				request.WithQueryParameter("REND", m3REND.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
		/// Name StopWorkSetup
		/// Description Stop work on setup
		/// Version Release: 10.6
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3WOSQ">Reporting number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3TMNO">Work group</param>
		/// <param name="m3SDAT">Reporting date</param>
		/// <param name="m3STTE">Repoting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopWorkSetup(
			string m3CANO, 
			string m3WOSQ, 
			string m3TENR = null, 
			string m3TMNO = null, 
			string m3SDAT = null, 
			string m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopWorkSetup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CANO))
				throw new ArgumentNullException(nameof(m3CANO));
			if (string.IsNullOrWhiteSpace(m3WOSQ))
				throw new ArgumentNullException(nameof(m3WOSQ));

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.Trim())
				.WithQueryParameter("WOSQ", m3WOSQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TMNO))
				request.WithQueryParameter("TMNO", m3TMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDAT))
				request.WithQueryParameter("SDAT", m3SDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTE))
				request.WithQueryParameter("STTE", m3STTE.Trim());

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
