/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS900MI;
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
	/// Name: CRS900MI
	/// Component Name: SystemCalendar
	/// Description: System calendar interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS900MIResource : M3BaseResourceEndpoint
	{
		public CRS900MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS900MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddWorkingDays
		/// Description Add working days to a date
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_DAYS">Additional days</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddWorkingDaysResponse></returns>
		/// <exception cref="M3Exception<AddWorkingDaysResponse>"></exception>
		public async Task<M3Response<AddWorkingDaysResponse>> AddWorkingDays(
			DateTime m3_FRDT, 
			int? m3_DAYS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddWorkingDays",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DAYS.HasValue)
				request.WithQueryParameter("DAYS", m3_DAYS.Value.ToString());

			// Execute the request
			var result = await Execute<AddWorkingDaysResponse>(
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
		/// Name LstSysCalendar
		/// Description List system calendar
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSysCalendarResponse></returns>
		/// <exception cref="M3Exception<LstSysCalendarResponse>"></exception>
		public async Task<M3Response<LstSysCalendarResponse>> LstSysCalendar(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSysCalendar",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstSysCalendarResponse>(
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
