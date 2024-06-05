/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS910MI;
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
	/// Name: CRS910MI
	/// Component Name: SystemPeriod
	/// Description: System Period interface
	/// Version Release: 13.1
	///</summary>
	public partial class CRS910MIResource : M3BaseResourceEndpoint
	{
		public CRS910MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS910MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Select
		/// Description Select System Periods
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FDIV">From Division</param>
		/// <param name="m3_TDIV">To Division</param>
		/// <param name="m3_FYEA">From year</param>
		/// <param name="m3_TYEA">To year</param>
		/// <param name="m3_FPET">Period type</param>
		/// <param name="m3_TPET">Period type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			int? m3_CONO = null, 
			string m3_FDIV = null, 
			string m3_TDIV = null, 
			int? m3_FYEA = null, 
			int? m3_TYEA = null, 
			int? m3_FPET = null, 
			int? m3_TPET = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDIV))
				request.WithQueryParameter("FDIV", m3_FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDIV))
				request.WithQueryParameter("TDIV", m3_TDIV.Trim());
			if (m3_FYEA.HasValue)
				request.WithQueryParameter("FYEA", m3_FYEA.Value.ToString());
			if (m3_TYEA.HasValue)
				request.WithQueryParameter("TYEA", m3_TYEA.Value.ToString());
			if (m3_FPET.HasValue)
				request.WithQueryParameter("FPET", m3_FPET.Value.ToString());
			if (m3_TPET.HasValue)
				request.WithQueryParameter("TPET", m3_TPET.Value.ToString());

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
