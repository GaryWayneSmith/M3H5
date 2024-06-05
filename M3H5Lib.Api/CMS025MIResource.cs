/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddReportLayout
		/// Description Add a report layout
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RLAY">Report layout (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_RPLY">XML structure (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_DUCO">Display update panel</param>
		/// <param name="m3_PDOC">External ID</param>
		/// <param name="m3_COVR">Cover information</param>
		/// <param name="m3_FOIN">Formatting information</param>
		/// <param name="m3_LAIN">Label information</param>
		/// <param name="m3_MEIN">Media information</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddReportLayout(
			string m3_PRTF, 
			string m3_RLAY, 
			string m3_TX40, 
			string m3_RPLY, 
			string m3_TX15 = null, 
			int? m3_DUCO = null, 
			string m3_PDOC = null, 
			int? m3_COVR = null, 
			int? m3_FOIN = null, 
			int? m3_LAIN = null, 
			int? m3_MEIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddReportLayout",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RLAY))
				throw new ArgumentNullException("m3_RLAY");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_RPLY))
				throw new ArgumentNullException("m3_RPLY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RLAY", m3_RLAY.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("RPLY", m3_RPLY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_DUCO.HasValue)
				request.WithQueryParameter("DUCO", m3_DUCO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PDOC))
				request.WithQueryParameter("PDOC", m3_PDOC.Trim());
			if (m3_COVR.HasValue)
				request.WithQueryParameter("COVR", m3_COVR.Value.ToString());
			if (m3_FOIN.HasValue)
				request.WithQueryParameter("FOIN", m3_FOIN.Value.ToString());
			if (m3_LAIN.HasValue)
				request.WithQueryParameter("LAIN", m3_LAIN.Value.ToString());
			if (m3_MEIN.HasValue)
				request.WithQueryParameter("MEIN", m3_MEIN.Value.ToString());

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
		/// Name DltReportLayout
		/// Description Delete a report layout
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RLAY">Report layout (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltReportLayout(
			string m3_PRTF, 
			string m3_RLAY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltReportLayout",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RLAY))
				throw new ArgumentNullException("m3_RLAY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RLAY", m3_RLAY.Trim());

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
		/// Name GetReportLayout
		/// Description Get data for a report layout
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RLAY">Report layout (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetReportLayoutResponse></returns>
		/// <exception cref="M3Exception<GetReportLayoutResponse>"></exception>
		public async Task<M3Response<GetReportLayoutResponse>> GetReportLayout(
			string m3_PRTF, 
			string m3_RLAY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetReportLayout",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RLAY))
				throw new ArgumentNullException("m3_RLAY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RLAY", m3_RLAY.Trim());

			// Execute the request
			var result = await Execute<GetReportLayoutResponse>(
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
		/// Name LstReportLayout
		/// Description List data for report layouts
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file</param>
		/// <param name="m3_RLAY">Report layout</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReportLayoutResponse></returns>
		/// <exception cref="M3Exception<LstReportLayoutResponse>"></exception>
		public async Task<M3Response<LstReportLayoutResponse>> LstReportLayout(
			string m3_PRTF = null, 
			string m3_RLAY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstReportLayout",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRTF))
				request.WithQueryParameter("PRTF", m3_PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RLAY))
				request.WithQueryParameter("RLAY", m3_RLAY.Trim());

			// Execute the request
			var result = await Execute<LstReportLayoutResponse>(
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
		/// Name UpdReportLayout
		/// Description Update data for a report layout
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PRTF">Printer file (Required)</param>
		/// <param name="m3_RLAY">Report layout (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_RPLY">XML structure</param>
		/// <param name="m3_DUCO">Display update panel</param>
		/// <param name="m3_PDOC">External ID</param>
		/// <param name="m3_COVR">Cover information</param>
		/// <param name="m3_FOIN">Formatting information</param>
		/// <param name="m3_LAIN">Label information</param>
		/// <param name="m3_MEIN">Media information</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdReportLayout(
			string m3_PRTF, 
			string m3_RLAY, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_RPLY = null, 
			int? m3_DUCO = null, 
			string m3_PDOC = null, 
			int? m3_COVR = null, 
			int? m3_FOIN = null, 
			int? m3_LAIN = null, 
			int? m3_MEIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdReportLayout",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRTF))
				throw new ArgumentNullException("m3_PRTF");
			if (string.IsNullOrWhiteSpace(m3_RLAY))
				throw new ArgumentNullException("m3_RLAY");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRTF", m3_PRTF.Trim())
				.WithQueryParameter("RLAY", m3_RLAY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RPLY))
				request.WithQueryParameter("RPLY", m3_RPLY.Trim());
			if (m3_DUCO.HasValue)
				request.WithQueryParameter("DUCO", m3_DUCO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PDOC))
				request.WithQueryParameter("PDOC", m3_PDOC.Trim());
			if (m3_COVR.HasValue)
				request.WithQueryParameter("COVR", m3_COVR.Value.ToString());
			if (m3_FOIN.HasValue)
				request.WithQueryParameter("FOIN", m3_FOIN.Value.ToString());
			if (m3_LAIN.HasValue)
				request.WithQueryParameter("LAIN", m3_LAIN.Value.ToString());
			if (m3_MEIN.HasValue)
				request.WithQueryParameter("MEIN", m3_MEIN.Value.ToString());

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
