/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDailyCap
		/// Description Adds Daily Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Workcenter (Required)</param>
		/// <param name="m3_DATE">Entrydate (Required)</param>
		/// <param name="m3_SHFC">Shift (Required)</param>
		/// <param name="m3_ETIM">Endtime (Required)</param>
		/// <param name="m3_STIM">Starttime</param>
		/// <param name="m3_AVEF">Utilizationrate</param>
		/// <param name="m3_WCNM">Numberofmachines</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDailyCap(
			string m3_FACI, 
			string m3_PLGR, 
			DateTime m3_DATE, 
			string m3_SHFC, 
			int m3_ETIM, 
			int? m3_STIM = null, 
			int? m3_AVEF = null, 
			int? m3_WCNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDailyCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");
			if (string.IsNullOrWhiteSpace(m3_SHFC))
				throw new ArgumentNullException("m3_SHFC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("DATE", m3_DATE.ToM3String())
				.WithQueryParameter("SHFC", m3_SHFC.Trim())
				.WithQueryParameter("ETIM", m3_ETIM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());
			if (m3_AVEF.HasValue)
				request.WithQueryParameter("AVEF", m3_AVEF.Value.ToString());
			if (m3_WCNM.HasValue)
				request.WithQueryParameter("WCNM", m3_WCNM.Value.ToString());

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
		/// Name DelDailyCap
		/// Description Deletes Daily Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Workcenter (Required)</param>
		/// <param name="m3_DATE">Entrydate (Required)</param>
		/// <param name="m3_STIM">Starttime (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDailyCap(
			string m3_FACI, 
			string m3_PLGR, 
			DateTime m3_DATE, 
			int m3_STIM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelDailyCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("DATE", m3_DATE.ToM3String())
				.WithQueryParameter("STIM", m3_STIM.ToString());

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
		/// Name GetDailyCap
		/// Description Gets Daily Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Workcenter (Required)</param>
		/// <param name="m3_DATE">Entrydate (Required)</param>
		/// <param name="m3_STIM">Starttime (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDailyCapResponse></returns>
		/// <exception cref="M3Exception<GetDailyCapResponse>"></exception>
		public async Task<M3Response<GetDailyCapResponse>> GetDailyCap(
			string m3_FACI, 
			string m3_PLGR, 
			DateTime m3_DATE, 
			int m3_STIM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDailyCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("DATE", m3_DATE.ToM3String())
				.WithQueryParameter("STIM", m3_STIM.ToString());

			// Execute the request
			var result = await Execute<GetDailyCapResponse>(
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
		/// Name LstDailyCap
		/// Description Lists Daily Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Workcenter (Required)</param>
		/// <param name="m3_DATE">Entrydate</param>
		/// <param name="m3_STIM">Starttime</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDailyCapResponse></returns>
		/// <exception cref="M3Exception<LstDailyCapResponse>"></exception>
		public async Task<M3Response<LstDailyCapResponse>> LstDailyCap(
			string m3_FACI, 
			string m3_PLGR, 
			DateTime? m3_DATE = null, 
			int? m3_STIM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDailyCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());

			// Execute the request
			var result = await Execute<LstDailyCapResponse>(
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
		/// Name SelWCCap
		/// Description Selects WCCap
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_PLTP">Resource type</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_DATE">Entry date</param>
		/// <param name="m3_STIM">Start time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelWCCapResponse></returns>
		/// <exception cref="M3Exception<SelWCCapResponse>"></exception>
		public async Task<M3Response<SelWCCapResponse>> SelWCCap(
			string m3_FACI, 
			string m3_PLGR = null, 
			string m3_PLTP = null, 
			string m3_REAR = null, 
			string m3_DEPT = null, 
			DateTime? m3_DATE = null, 
			int? m3_STIM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelWCCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTP))
				request.WithQueryParameter("PLTP", m3_PLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_STIM.HasValue)
				request.WithQueryParameter("STIM", m3_STIM.Value.ToString());

			// Execute the request
			var result = await Execute<SelWCCapResponse>(
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
		/// Name UpdDailyCap
		/// Description Updates Daily Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Workcenter (Required)</param>
		/// <param name="m3_DATE">Entrydate (Required)</param>
		/// <param name="m3_STIM">Starttime (Required)</param>
		/// <param name="m3_SHFC">Shift</param>
		/// <param name="m3_ETIM">Endtime</param>
		/// <param name="m3_AVEF">Utilizationrate</param>
		/// <param name="m3_WCNM">Numberofmachines</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDailyCap(
			string m3_FACI, 
			string m3_PLGR, 
			DateTime m3_DATE, 
			int m3_STIM, 
			string m3_SHFC = null, 
			int? m3_ETIM = null, 
			int? m3_AVEF = null, 
			int? m3_WCNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdDailyCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("DATE", m3_DATE.ToM3String())
				.WithQueryParameter("STIM", m3_STIM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SHFC))
				request.WithQueryParameter("SHFC", m3_SHFC.Trim());
			if (m3_ETIM.HasValue)
				request.WithQueryParameter("ETIM", m3_ETIM.Value.ToString());
			if (m3_AVEF.HasValue)
				request.WithQueryParameter("AVEF", m3_AVEF.Value.ToString());
			if (m3_WCNM.HasValue)
				request.WithQueryParameter("WCNM", m3_WCNM.Value.ToString());

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
