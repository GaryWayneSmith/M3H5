/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRS515MI;
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
	/// Name: CRS515MI
	/// Component Name: WorkScheduleBasic
	/// Description: Work schedule basic data interface
	/// Version Release: 12.0
	///</summary>
	public partial class CRS515MIResource : M3BaseResourceEndpoint
	{
		public CRS515MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS515MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SelModelLines
		/// Description Selection of shift model lines
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FDIV">From division</param>
		/// <param name="m3TDIV">To division</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelModelLinesResponse></returns>
		/// <exception cref="M3Exception<SelModelLinesResponse>"></exception>
		public async Task<M3Response<SelModelLinesResponse>> SelModelLines(
			int? m3CONO = null, 
			string m3FDIV = null, 
			string m3TDIV = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelModelLines",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDIV))
				request.WithQueryParameter("FDIV", m3FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDIV))
				request.WithQueryParameter("TDIV", m3TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Execute the request
			var result = await Execute<SelModelLinesResponse>(
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
		/// Name SelPatternLines
		/// Description Selection of shift pattern lines
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FDIV">From Division</param>
		/// <param name="m3TDIV">To Division</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelPatternLinesResponse></returns>
		/// <exception cref="M3Exception<SelPatternLinesResponse>"></exception>
		public async Task<M3Response<SelPatternLinesResponse>> SelPatternLines(
			int? m3CONO = null, 
			string m3FDIV = null, 
			string m3TDIV = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelPatternLines",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDIV))
				request.WithQueryParameter("FDIV", m3FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDIV))
				request.WithQueryParameter("TDIV", m3TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Execute the request
			var result = await Execute<SelPatternLinesResponse>(
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
