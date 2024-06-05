/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PMS230MI;
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
	/// Name: PMS230MI
	/// Component Name: WorkCenterSchedule
	/// Description: Work center schedule interface
	/// Version Release: 5ea0
	///</summary>
	public partial class PMS230MIResource : M3BaseResourceEndpoint
	{
		public PMS230MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS230MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Select
		/// Description Select
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work Center (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRDT">From Date</param>
		/// <param name="m3_TODT">To Date</param>
		/// <param name="m3_PLHZ">Planning horizon</param>
		/// <param name="m3_CLHM">Include held MOs</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3_FACI, 
			string m3_PLGR, 
			int? m3_CONO = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			int? m3_PLHZ = null, 
			int? m3_CLHM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Select",
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (m3_PLHZ.HasValue)
				request.WithQueryParameter("PLHZ", m3_PLHZ.Value.ToString());
			if (m3_CLHM.HasValue)
				request.WithQueryParameter("CLHM", m3_CLHM.Value.ToString());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
