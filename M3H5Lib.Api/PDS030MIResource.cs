/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SelCalendar
		/// Description Selection of days from system calendar
		/// Version Release: 12.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SDAT">Date (Required)</param>
		/// <param name="m3EDAT">Date (Required)</param>
		/// <param name="m3DATY">Day type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3NWFL">Non working day indicator</param>
		/// <param name="m3SSAS">Saturday/Sunday indicator</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3POD1">Production day indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelCalendarResponse></returns>
		/// <exception cref="M3Exception<SelCalendarResponse>"></exception>
		public async Task<M3Response<SelCalendarResponse>> SelCalendar(
			string m3DIVI, 
			DateTime m3SDAT, 
			long m3EDAT, 
			string m3DATY, 
			int? m3CONO = null, 
			string m3NWFL = null, 
			string m3SSAS = null, 
			string m3WHGR = null, 
			string m3POD1 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelCalendar",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3DATY))
				throw new ArgumentNullException(nameof(m3DATY));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SDAT", m3SDAT.ToM3String())
				.WithQueryParameter("EDAT", m3EDAT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DATY", m3DATY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NWFL))
				request.WithQueryParameter("NWFL", m3NWFL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSAS))
				request.WithQueryParameter("SSAS", m3SSAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3POD1))
				request.WithQueryParameter("POD1", m3POD1.Trim());

			// Execute the request
			var result = await Execute<SelCalendarResponse>(
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
		/// Name SelModelLines
		/// Description Selection of shift model lines
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FFAC">From facility</param>
		/// <param name="m3TFAC">To facility</param>
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
			string m3FFAC = null, 
			string m3TFAC = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelModelLines",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FFAC))
				request.WithQueryParameter("FFAC", m3FFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFAC))
				request.WithQueryParameter("TFAC", m3TFAC.Trim());
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
		/// Version Release: 11.0
		/// </summary>
		/// <param name="m3FFAC">From facility (Required)</param>
		/// <param name="m3TFAC">To facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelPatternLinesResponse></returns>
		/// <exception cref="M3Exception<SelPatternLinesResponse>"></exception>
		public async Task<M3Response<SelPatternLinesResponse>> SelPatternLines(
			string m3FFAC, 
			string m3TFAC, 
			int? m3CONO = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelPatternLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FFAC))
				throw new ArgumentNullException(nameof(m3FFAC));
			if (string.IsNullOrWhiteSpace(m3TFAC))
				throw new ArgumentNullException(nameof(m3TFAC));

			// Set mandatory parameters
			request
				.WithQueryParameter("FFAC", m3FFAC.Trim())
				.WithQueryParameter("TFAC", m3TFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
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
