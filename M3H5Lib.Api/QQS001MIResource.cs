/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.QQS001MI;
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
	/// Name: QQS001MI
	/// Component Name: Tool
	/// Description: Tool interface
	/// Version Release: 5ea1
	///</summary>
	public partial class QQS001MIResource : M3BaseResourceEndpoint
	{
		public QQS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QQS001MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTool
		/// Description Add a tool
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3TOOL">Tool number (Required)</param>
		/// <param name="m3TOLT">Tool type (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name (Required)</param>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3GUDF">Get user defaults</param>
		/// <param name="m3PHNO">Telephone number</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3MPDT">Purchase date</param>
		/// <param name="m3MFDT">Manufacturing date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTool(
			string m3TOOL, 
			string m3TOLT, 
			string m3TX40, 
			string m3TX15, 
			string m3USID, 
			string m3WHLO, 
			int? m3GUDF = null, 
			string m3PHNO = null, 
			decimal? m3PUPR = null, 
			string m3WHSL = null, 
			DateTime? m3MPDT = null, 
			DateTime? m3MFDT = null, 
			int? m3TRTM = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTool",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TOOL))
				throw new ArgumentNullException(nameof(m3TOOL));
			if (string.IsNullOrWhiteSpace(m3TOLT))
				throw new ArgumentNullException(nameof(m3TOLT));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3TX15))
				throw new ArgumentNullException(nameof(m3TX15));
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("TOOL", m3TOOL.Trim())
				.WithQueryParameter("TOLT", m3TOLT.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("TX15", m3TX15.Trim())
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3GUDF.HasValue)
				request.WithQueryParameter("GUDF", m3GUDF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3MPDT.HasValue)
				request.WithQueryParameter("MPDT", m3MPDT.Value.ToM3String());
			if (m3MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3MFDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltTool
		/// Description Delete a tool
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TOOL">Tool number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltTool(
			string m3TOOL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltTool",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TOOL))
				throw new ArgumentNullException(nameof(m3TOOL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TOOL", m3TOOL.Trim());

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
		/// Name GetTool
		/// Description Get data for a tool
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3TOOL">Tool number (Required)</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetToolResponse></returns>
		/// <exception cref="M3Exception<GetToolResponse>"></exception>
		public async Task<M3Response<GetToolResponse>> GetTool(
			string m3TOOL, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTool",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TOOL))
				throw new ArgumentNullException(nameof(m3TOOL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TOOL", m3TOOL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetToolResponse>(
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
		/// Name LstTools
		/// Description List data for tools
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstToolsResponse></returns>
		/// <exception cref="M3Exception<LstToolsResponse>"></exception>
		public async Task<M3Response<LstToolsResponse>> LstTools(
			string m3TOOL = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTools",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstToolsResponse>(
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
		/// Name SetCurrentDate
		/// Description Sets the date of the record(s) to todays date
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SetCurrentDateResponse></returns>
		/// <exception cref="M3Exception<SetCurrentDateResponse>"></exception>
		public async Task<M3Response<SetCurrentDateResponse>> SetCurrentDate(
			string m3TOOL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetCurrentDate",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());

			// Execute the request
			var result = await Execute<SetCurrentDateResponse>(
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
		/// Name UpdTool
		/// Description Update data for a tool
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3TOOL">Tool number (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3GUDF">Get user defaults</param>
		/// <param name="m3PHNO">Telephone number</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3MPDT">Purchase date</param>
		/// <param name="m3MFDT">Manufacturing date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTool(
			string m3TOOL, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3USID = null, 
			int? m3GUDF = null, 
			string m3PHNO = null, 
			decimal? m3PUPR = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			DateTime? m3MPDT = null, 
			DateTime? m3MFDT = null, 
			int? m3TRTM = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTool",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TOOL))
				throw new ArgumentNullException(nameof(m3TOOL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TOOL", m3TOOL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (m3GUDF.HasValue)
				request.WithQueryParameter("GUDF", m3GUDF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3MPDT.HasValue)
				request.WithQueryParameter("MPDT", m3MPDT.Value.ToM3String());
			if (m3MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3MFDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
