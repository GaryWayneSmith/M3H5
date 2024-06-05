/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PDS016MI;
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
	/// Name: PDS016MI
	/// Component Name: Planning and Manufacturing
	/// Description: Daily Capacity interface
	/// Version Release: 13.1
	///</summary>
	public partial class PDS016MIResource : M3BaseResourceEndpoint
	{
		public PDS016MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS016MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDailyCap
		/// Description Adds Daily Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Workcenter (Required)</param>
		/// <param name="m3DATE">Entrydate (Required)</param>
		/// <param name="m3SHFC">Shift (Required)</param>
		/// <param name="m3ETIM">Endtime (Required)</param>
		/// <param name="m3STIM">Starttime</param>
		/// <param name="m3AVEF">Utilizationrate</param>
		/// <param name="m3WCNM">Numberofmachines</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDailyCap(
			string m3FACI, 
			string m3PLGR, 
			DateTime m3DATE, 
			string m3SHFC, 
			int m3ETIM, 
			int? m3STIM = null, 
			int? m3AVEF = null, 
			int? m3WCNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDailyCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));
			if (string.IsNullOrWhiteSpace(m3SHFC))
				throw new ArgumentNullException(nameof(m3SHFC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("DATE", m3DATE.ToM3String())
				.WithQueryParameter("SHFC", m3SHFC.Trim())
				.WithQueryParameter("ETIM", m3ETIM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVEF.HasValue)
				request.WithQueryParameter("AVEF", m3AVEF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WCNM.HasValue)
				request.WithQueryParameter("WCNM", m3WCNM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelDailyCap
		/// Description Deletes Daily Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Workcenter (Required)</param>
		/// <param name="m3DATE">Entrydate (Required)</param>
		/// <param name="m3STIM">Starttime (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDailyCap(
			string m3FACI, 
			string m3PLGR, 
			DateTime m3DATE, 
			int m3STIM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelDailyCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("DATE", m3DATE.ToM3String())
				.WithQueryParameter("STIM", m3STIM.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetDailyCap
		/// Description Gets Daily Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Workcenter (Required)</param>
		/// <param name="m3DATE">Entrydate (Required)</param>
		/// <param name="m3STIM">Starttime (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDailyCapResponse></returns>
		/// <exception cref="M3Exception<GetDailyCapResponse>"></exception>
		public async Task<M3Response<GetDailyCapResponse>> GetDailyCap(
			string m3FACI, 
			string m3PLGR, 
			DateTime m3DATE, 
			int m3STIM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDailyCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("DATE", m3DATE.ToM3String())
				.WithQueryParameter("STIM", m3STIM.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDailyCapResponse>(
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
		/// Name LstDailyCap
		/// Description Lists Daily Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Workcenter (Required)</param>
		/// <param name="m3DATE">Entrydate</param>
		/// <param name="m3STIM">Starttime</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDailyCapResponse></returns>
		/// <exception cref="M3Exception<LstDailyCapResponse>"></exception>
		public async Task<M3Response<LstDailyCapResponse>> LstDailyCap(
			string m3FACI, 
			string m3PLGR, 
			DateTime? m3DATE = null, 
			int? m3STIM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDailyCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDailyCapResponse>(
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
		/// Name SelWCCap
		/// Description Selects WCCap
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3PLTP">Resource type</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3DATE">Entry date</param>
		/// <param name="m3STIM">Start time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelWCCapResponse></returns>
		/// <exception cref="M3Exception<SelWCCapResponse>"></exception>
		public async Task<M3Response<SelWCCapResponse>> SelWCCap(
			string m3FACI, 
			string m3PLGR = null, 
			string m3PLTP = null, 
			string m3REAR = null, 
			string m3DEPT = null, 
			DateTime? m3DATE = null, 
			int? m3STIM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelWCCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTP))
				request.WithQueryParameter("PLTP", m3PLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3STIM.HasValue)
				request.WithQueryParameter("STIM", m3STIM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelWCCapResponse>(
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
		/// Name UpdDailyCap
		/// Description Updates Daily Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Workcenter (Required)</param>
		/// <param name="m3DATE">Entrydate (Required)</param>
		/// <param name="m3STIM">Starttime (Required)</param>
		/// <param name="m3SHFC">Shift</param>
		/// <param name="m3ETIM">Endtime</param>
		/// <param name="m3AVEF">Utilizationrate</param>
		/// <param name="m3WCNM">Numberofmachines</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDailyCap(
			string m3FACI, 
			string m3PLGR, 
			DateTime m3DATE, 
			int m3STIM, 
			string m3SHFC = null, 
			int? m3ETIM = null, 
			int? m3AVEF = null, 
			int? m3WCNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdDailyCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("DATE", m3DATE.ToM3String())
				.WithQueryParameter("STIM", m3STIM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SHFC))
				request.WithQueryParameter("SHFC", m3SHFC.Trim());
			if (m3ETIM.HasValue)
				request.WithQueryParameter("ETIM", m3ETIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVEF.HasValue)
				request.WithQueryParameter("AVEF", m3AVEF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WCNM.HasValue)
				request.WithQueryParameter("WCNM", m3WCNM.Value.ToString(CultureInfo.CurrentCulture));

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
