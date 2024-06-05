/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgCostCenter(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelTimeTrans
		/// Description Delete time transaction
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3SDAT">Clock date (Required)</param>
		/// <param name="m3STTE">Clock time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTimeTrans(
			string m3DIVI, 
			string m3EMNO, 
			DateTime m3SDAT, 
			int m3STTE, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("EMNO", m3EMNO.Trim())
				.WithQueryParameter("SDAT", m3SDAT.ToM3String())
				.WithQueryParameter("STTE", m3STTE.ToString(CultureInfo.CurrentCulture));

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
		/// Description Fixed time
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
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
			string m3TENR = null, 
			long? m3CANO = null, 
			string m3TTPE = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TTPE))
				request.WithQueryParameter("TTPE", m3TTPE.Trim());
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetEmpStat
		/// Description Get last action for employee
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CANO">Card number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEmpStatResponse></returns>
		/// <exception cref="M3Exception<GetEmpStatResponse>"></exception>
		public async Task<M3Response<GetEmpStatResponse>> GetEmpStat(
			long? m3CANO = null, 
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
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetEmpStatResponse>(
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
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> In(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name InOvertimeComp
		/// Description In overtime compensation time
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOvertimeComp(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name InOvertimePaid
		/// Description In overtime paid
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOvertimePaid(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name InOvertimeUD2
		/// Description In overtime user defined
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOvertimeUD2(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name InOvertimeUD3
		/// Description In overtime user defined
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOvertimeUD3(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name InOvertimeUDef
		/// Description In overtime user defined
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InOvertimeUDef(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name LstAbsCodes
		/// Description List Absence codes
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAbsCodesResponse></returns>
		/// <exception cref="M3Exception<LstAbsCodesResponse>"></exception>
		public async Task<M3Response<LstAbsCodesResponse>> LstAbsCodes(
			int? m3CONO = null, 
			string m3DIVI = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstAbsCodesResponse>(
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
		/// Name LstActivity
		/// Description List Activities
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstActivityResponse></returns>
		/// <exception cref="M3Exception<LstActivityResponse>"></exception>
		public async Task<M3Response<LstActivityResponse>> LstActivity(
			int? m3CONO = null, 
			string m3DIVI = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstActivityResponse>(
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
		/// Name LstBallances
		/// Description List Ballances
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBallancesResponse></returns>
		/// <exception cref="M3Exception<LstBallancesResponse>"></exception>
		public async Task<M3Response<LstBallancesResponse>> LstBallances(
			int? m3CONO = null, 
			string m3DIVI = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstBallancesResponse>(
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
		/// Name LstEmp
		/// Description List Employees
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEmpResponse></returns>
		/// <exception cref="M3Exception<LstEmpResponse>"></exception>
		public async Task<M3Response<LstEmpResponse>> LstEmp(
			int? m3CONO = null, 
			string m3DIVI = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstEmpResponse>(
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
		/// Name LstTimeTypes
		/// Description List Time types
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTimeTypesResponse></returns>
		/// <exception cref="M3Exception<LstTimeTypesResponse>"></exception>
		public async Task<M3Response<LstTimeTypesResponse>> LstTimeTypes(
			int? m3CONO = null, 
			string m3DIVI = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstTimeTypesResponse>(
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
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Out(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name OutOvertimeComp
		/// Description Out overtime compensation time
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOvertimeComp(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name OutOvertimePaid
		/// Description Out overtime paid
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOvertimePaid(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name OutOvertimeUD2
		/// Description Out overtime user defined
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOvertimeUD2(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name OutOvertimeUD3
		/// Description Out overtime user defined
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOvertimeUD3(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name OutOvertimeUDef
		/// Description Out overtime user defined
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3SHNO">Reference no - accounting dimension 2</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OutOvertimeUDef(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			int? m3SHNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHNO.HasValue)
				request.WithQueryParameter("SHNO", m3SHNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Planned Absence
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3FRSD">From clock date</param>
		/// <param name="m3TOSD">To clock date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PlannedAbsence(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			DateTime? m3FRSD = null, 
			DateTime? m3TOSD = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRSD.HasValue)
				request.WithQueryParameter("FRSD", m3FRSD.Value.ToM3String());
			if (m3TOSD.HasValue)
				request.WithQueryParameter("TOSD", m3TOSD.Value.ToM3String());

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
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3TTPE">Time type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> QueryBalance(
			string m3TENR = null, 
			long? m3CANO = null, 
			string m3TTPE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TTPE))
				request.WithQueryParameter("TTPE", m3TTPE.Trim());

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
		/// Name RunningAbsence
		/// Description Running Absence
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3ABSC">Absence type</param>
		/// <param name="m3FRSD">From clock date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RunningAbsence(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3ABSC = null, 
			DateTime? m3FRSD = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ABSC.HasValue)
				request.WithQueryParameter("ABSC", m3ABSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRSD.HasValue)
				request.WithQueryParameter("FRSD", m3FRSD.Value.ToM3String());

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
		/// Name StartActivity
		/// Description Start activity time
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3PJID">Time activity</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartActivity(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3PJID = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PJID.HasValue)
				request.WithQueryParameter("PJID", m3PJID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3PJID">Time activity</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopActivity(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3PJID = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PJID.HasValue)
				request.WithQueryParameter("PJID", m3PJID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
