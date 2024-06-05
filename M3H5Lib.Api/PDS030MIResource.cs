/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PDS030MI;
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
	/// Name: PDS030MI
	/// Component Name: ShiftPlanning
	/// Description: Shift planning basic data interface
	/// Version Release: 11.0
	///</summary>
	public partial class PDS030MIResource : M3BaseResourceEndpoint
	{
		public PDS030MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS030MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SelCalendar
		/// Description Selection of days from system calendar
		/// Version Release: 12.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SDAT">Date (Required)</param>
		/// <param name="m3_EDAT">Date (Required)</param>
		/// <param name="m3_DATY">Day type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_NWFL">Non working day indicator</param>
		/// <param name="m3_SSAS">Saturday/Sunday indicator</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_POD1">Production day indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelCalendarResponse></returns>
		/// <exception cref="M3Exception<SelCalendarResponse>"></exception>
		public async Task<M3Response<SelCalendarResponse>> SelCalendar(
			string m3_DIVI, 
			DateTime m3_SDAT, 
			long m3_EDAT, 
			string m3_DATY, 
			int? m3_CONO = null, 
			string m3_NWFL = null, 
			string m3_SSAS = null, 
			string m3_WHGR = null, 
			string m3_POD1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelCalendar",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_DATY))
				throw new ArgumentNullException("m3_DATY");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SDAT", m3_SDAT.ToM3String())
				.WithQueryParameter("EDAT", m3_EDAT.ToString())
				.WithQueryParameter("DATY", m3_DATY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NWFL))
				request.WithQueryParameter("NWFL", m3_NWFL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSAS))
				request.WithQueryParameter("SSAS", m3_SSAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POD1))
				request.WithQueryParameter("POD1", m3_POD1.Trim());

			// Execute the request
			var result = await Execute<SelCalendarResponse>(
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
		/// Name SelModelLines
		/// Description Selection of shift model lines
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FFAC">From facility</param>
		/// <param name="m3_TFAC">To facility</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelModelLinesResponse></returns>
		/// <exception cref="M3Exception<SelModelLinesResponse>"></exception>
		public async Task<M3Response<SelModelLinesResponse>> SelModelLines(
			int? m3_CONO = null, 
			string m3_FFAC = null, 
			string m3_TFAC = null, 
			string m3_WHGR = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FFAC))
				request.WithQueryParameter("FFAC", m3_FFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFAC))
				request.WithQueryParameter("TFAC", m3_TFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());

			// Execute the request
			var result = await Execute<SelModelLinesResponse>(
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
		/// Name SelPatternLines
		/// Description Selection of shift pattern lines
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3_FFAC">From facility (Required)</param>
		/// <param name="m3_TFAC">To facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelPatternLinesResponse></returns>
		/// <exception cref="M3Exception<SelPatternLinesResponse>"></exception>
		public async Task<M3Response<SelPatternLinesResponse>> SelPatternLines(
			string m3_FFAC, 
			string m3_TFAC, 
			int? m3_CONO = null, 
			string m3_WHGR = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FFAC))
				throw new ArgumentNullException("m3_FFAC");
			if (string.IsNullOrWhiteSpace(m3_TFAC))
				throw new ArgumentNullException("m3_TFAC");

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3_FFAC.Trim())
				.WithQueryParameter("TFAC", m3_TFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());

			// Execute the request
			var result = await Execute<SelPatternLinesResponse>(
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
