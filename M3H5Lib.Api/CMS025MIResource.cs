/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CMS025MI;
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
	/// Name: CMS025MI
	/// Component Name: Report layout
	/// Description: Report layout interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CMS025MIResource : M3BaseResourceEndpoint
	{
		public CMS025MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS025MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddReportLayout
		/// Description Add a report layout
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RLAY">Report layout (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3RPLY">XML structure (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3DUCO">Display update panel</param>
		/// <param name="m3PDOC">External ID</param>
		/// <param name="m3COVR">Cover information</param>
		/// <param name="m3FOIN">Formatting information</param>
		/// <param name="m3LAIN">Label information</param>
		/// <param name="m3MEIN">Media information</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddReportLayout(
			string m3PRTF, 
			string m3RLAY, 
			string m3TX40, 
			string m3RPLY, 
			string m3TX15 = null, 
			int? m3DUCO = null, 
			string m3PDOC = null, 
			int? m3COVR = null, 
			int? m3FOIN = null, 
			int? m3LAIN = null, 
			int? m3MEIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddReportLayout",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RLAY))
				throw new ArgumentNullException(nameof(m3RLAY));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3RPLY))
				throw new ArgumentNullException(nameof(m3RPLY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RLAY", m3RLAY.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("RPLY", m3RPLY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3DUCO.HasValue)
				request.WithQueryParameter("DUCO", m3DUCO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PDOC))
				request.WithQueryParameter("PDOC", m3PDOC.Trim());
			if (m3COVR.HasValue)
				request.WithQueryParameter("COVR", m3COVR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FOIN.HasValue)
				request.WithQueryParameter("FOIN", m3FOIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LAIN.HasValue)
				request.WithQueryParameter("LAIN", m3LAIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MEIN.HasValue)
				request.WithQueryParameter("MEIN", m3MEIN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltReportLayout
		/// Description Delete a report layout
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RLAY">Report layout (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltReportLayout(
			string m3PRTF, 
			string m3RLAY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltReportLayout",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RLAY))
				throw new ArgumentNullException(nameof(m3RLAY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RLAY", m3RLAY.Trim());

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
		/// Name GetReportLayout
		/// Description Get data for a report layout
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RLAY">Report layout (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetReportLayoutResponse></returns>
		/// <exception cref="M3Exception<GetReportLayoutResponse>"></exception>
		public async Task<M3Response<GetReportLayoutResponse>> GetReportLayout(
			string m3PRTF, 
			string m3RLAY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetReportLayout",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RLAY))
				throw new ArgumentNullException(nameof(m3RLAY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RLAY", m3RLAY.Trim());

			// Execute the request
			var result = await Execute<GetReportLayoutResponse>(
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
		/// Name LstReportLayout
		/// Description List data for report layouts
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file</param>
		/// <param name="m3RLAY">Report layout</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReportLayoutResponse></returns>
		/// <exception cref="M3Exception<LstReportLayoutResponse>"></exception>
		public async Task<M3Response<LstReportLayoutResponse>> LstReportLayout(
			string m3PRTF = null, 
			string m3RLAY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstReportLayout",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRTF))
				request.WithQueryParameter("PRTF", m3PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3RLAY))
				request.WithQueryParameter("RLAY", m3RLAY.Trim());

			// Execute the request
			var result = await Execute<LstReportLayoutResponse>(
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
		/// Name UpdReportLayout
		/// Description Update data for a report layout
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PRTF">Printer file (Required)</param>
		/// <param name="m3RLAY">Report layout (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3RPLY">XML structure</param>
		/// <param name="m3DUCO">Display update panel</param>
		/// <param name="m3PDOC">External ID</param>
		/// <param name="m3COVR">Cover information</param>
		/// <param name="m3FOIN">Formatting information</param>
		/// <param name="m3LAIN">Label information</param>
		/// <param name="m3MEIN">Media information</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdReportLayout(
			string m3PRTF, 
			string m3RLAY, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3RPLY = null, 
			int? m3DUCO = null, 
			string m3PDOC = null, 
			int? m3COVR = null, 
			int? m3FOIN = null, 
			int? m3LAIN = null, 
			int? m3MEIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdReportLayout",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRTF))
				throw new ArgumentNullException(nameof(m3PRTF));
			if (string.IsNullOrWhiteSpace(m3RLAY))
				throw new ArgumentNullException(nameof(m3RLAY));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3PRTF.Trim())
				.WithQueryParameter("RLAY", m3RLAY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3RPLY))
				request.WithQueryParameter("RPLY", m3RPLY.Trim());
			if (m3DUCO.HasValue)
				request.WithQueryParameter("DUCO", m3DUCO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PDOC))
				request.WithQueryParameter("PDOC", m3PDOC.Trim());
			if (m3COVR.HasValue)
				request.WithQueryParameter("COVR", m3COVR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FOIN.HasValue)
				request.WithQueryParameter("FOIN", m3FOIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LAIN.HasValue)
				request.WithQueryParameter("LAIN", m3LAIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MEIN.HasValue)
				request.WithQueryParameter("MEIN", m3MEIN.Value.ToString(CultureInfo.CurrentCulture));

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
