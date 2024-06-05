/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.TMS006MI;
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
	/// Name: TMS006MI
	/// Component Name: TimeAndAttendance
	/// Description: Time and attendance interface
	/// Version Release: 5ea0
	///</summary>
	public partial class TMS006MIResource : M3BaseResourceEndpoint
	{
		public TMS006MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "TMS006MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ChgCostCenter
		/// Description Change Costcenter
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgCostCenter(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name DelTimeTrans
		/// Description Delete time transaction
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_SDAT">Clock date (Required)</param>
		/// <param name="m3_STTE">Clock time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTimeTrans(
			string m3_DIVI, 
			string m3_EMNO, 
			DateTime m3_SDAT, 
			int m3_STTE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelTimeTrans",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("EMNO", m3_EMNO.Trim())
				.WithQueryParameter("SDAT", m3_SDAT.ToM3String())
				.WithQueryParameter("STTE", m3_STTE.ToString());

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
		/// Description Fixed time
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
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
			string m3_TENR = null, 
			long? m3_CANO = null, 
			string m3_TTPE = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TTPE))
				request.WithQueryParameter("TTPE", m3_TTPE.Trim());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name GetEmpStat
		/// Description Get last action for employee
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEmpStatResponse></returns>
		/// <exception cref="M3Exception<GetEmpStatResponse>"></exception>
		public async Task<M3Response<GetEmpStatResponse>> GetEmpStat(
			long? m3_CANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetEmpStat",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());

			// Execute the request
			var result = await Execute<GetEmpStatResponse>(
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
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> In(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name InOvertimeComp
		/// Description In overtime compensation time
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOvertimeComp(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InOvertimeComp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name InOvertimePaid
		/// Description In overtime paid
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOvertimePaid(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InOvertimePaid",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name InOvertimeUD2
		/// Description In overtime user defined
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOvertimeUD2(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InOvertimeUD2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name InOvertimeUD3
		/// Description In overtime user defined
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOvertimeUD3(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InOvertimeUD3",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name InOvertimeUDef
		/// Description In overtime user defined
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOvertimeUDef(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InOvertimeUDef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name LstAbsCodes
		/// Description List Absence codes
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAbsCodesResponse></returns>
		/// <exception cref="M3Exception<LstAbsCodesResponse>"></exception>
		public async Task<M3Response<LstAbsCodesResponse>> LstAbsCodes(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAbsCodes",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstAbsCodesResponse>(
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
		/// Name LstActivity
		/// Description List Activities
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstActivityResponse></returns>
		/// <exception cref="M3Exception<LstActivityResponse>"></exception>
		public async Task<M3Response<LstActivityResponse>> LstActivity(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstActivity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstActivityResponse>(
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
		/// Name LstBallances
		/// Description List Ballances
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBallancesResponse></returns>
		/// <exception cref="M3Exception<LstBallancesResponse>"></exception>
		public async Task<M3Response<LstBallancesResponse>> LstBallances(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBallances",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstBallancesResponse>(
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
		/// Name LstEmp
		/// Description List Employees
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEmpResponse></returns>
		/// <exception cref="M3Exception<LstEmpResponse>"></exception>
		public async Task<M3Response<LstEmpResponse>> LstEmp(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstEmp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstEmpResponse>(
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
		/// Name LstTimeTypes
		/// Description List Time types
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTimeTypesResponse></returns>
		/// <exception cref="M3Exception<LstTimeTypesResponse>"></exception>
		public async Task<M3Response<LstTimeTypesResponse>> LstTimeTypes(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTimeTypes",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstTimeTypesResponse>(
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
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Out(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name OutOvertimeComp
		/// Description Out overtime compensation time
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOvertimeComp(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/OutOvertimeComp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name OutOvertimePaid
		/// Description Out overtime paid
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOvertimePaid(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/OutOvertimePaid",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name OutOvertimeUD2
		/// Description Out overtime user defined
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOvertimeUD2(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/OutOvertimeUD2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name OutOvertimeUD3
		/// Description Out overtime user defined
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOvertimeUD3(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/OutOvertimeUD3",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name OutOvertimeUDef
		/// Description Out overtime user defined
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOvertimeUDef(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			int? m3_SHNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/OutOvertimeUDef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3_SHNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Description Planned Absence
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_FRSD">From clock date</param>
		/// <param name="m3_TOSD">To clock date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PlannedAbsence(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			DateTime? m3_FRSD = null, 
			DateTime? m3_TOSD = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_FRSD.HasValue)
				request.WithQueryParameter("FRSD", m3_FRSD.Value.ToM3String());
			if (m3_TOSD.HasValue)
				request.WithQueryParameter("TOSD", m3_TOSD.Value.ToM3String());

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
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_TTPE">Time type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> QueryBalance(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			string m3_TTPE = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TTPE))
				request.WithQueryParameter("TTPE", m3_TTPE.Trim());

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
		/// Name RunningAbsence
		/// Description Running Absence
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_ABSC">Absence type</param>
		/// <param name="m3_FRSD">From clock date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RunningAbsence(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_ABSC = null, 
			DateTime? m3_FRSD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RunningAbsence",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3_ABSC.Value.ToString());
			if (m3_FRSD.HasValue)
				request.WithQueryParameter("FRSD", m3_FRSD.Value.ToM3String());

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
		/// Name StartActivity
		/// Description Start activity time
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_PJID">Time activity</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartActivity(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_PJID = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_PJID.HasValue)
				request.WithQueryParameter("PJID", m3_PJID.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_PJID">Time activity</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopActivity(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_PJID = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_PJID.HasValue)
				request.WithQueryParameter("PJID", m3_PJID.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
