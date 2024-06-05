/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_TOOL">Tool number (Required)</param>
		/// <param name="m3_TOLT">Tool type (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX15">Name (Required)</param>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_GUDF">Get user defaults</param>
		/// <param name="m3_PHNO">Telephone number</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_MPDT">Purchase date</param>
		/// <param name="m3_MFDT">Manufacturing date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTool(
			string m3_TOOL, 
			string m3_TOLT, 
			string m3_TX40, 
			string m3_TX15, 
			string m3_USID, 
			string m3_WHLO, 
			int? m3_GUDF = null, 
			string m3_PHNO = null, 
			decimal? m3_PUPR = null, 
			string m3_WHSL = null, 
			DateTime? m3_MPDT = null, 
			DateTime? m3_MFDT = null, 
			int? m3_TRTM = null, 
			int? m3_UTCM = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TOOL))
				throw new ArgumentNullException("m3_TOOL");
			if (string.IsNullOrWhiteSpace(m3_TOLT))
				throw new ArgumentNullException("m3_TOLT");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_TX15))
				throw new ArgumentNullException("m3_TX15");
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("TOOL", m3_TOOL.Trim())
				.WithQueryParameter("TOLT", m3_TOLT.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("TX15", m3_TX15.Trim())
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_GUDF.HasValue)
				request.WithQueryParameter("GUDF", m3_GUDF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_MPDT.HasValue)
				request.WithQueryParameter("MPDT", m3_MPDT.Value.ToM3String());
			if (m3_MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3_MFDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
		/// Name DltTool
		/// Description Delete a tool
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TOOL">Tool number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltTool(
			string m3_TOOL, 
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
			if (string.IsNullOrWhiteSpace(m3_TOOL))
				throw new ArgumentNullException("m3_TOOL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TOOL", m3_TOOL.Trim());

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
		/// Name GetTool
		/// Description Get data for a tool
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_TOOL">Tool number (Required)</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetToolResponse></returns>
		/// <exception cref="M3Exception<GetToolResponse>"></exception>
		public async Task<M3Response<GetToolResponse>> GetTool(
			string m3_TOOL, 
			int? m3_UTCM = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TOOL))
				throw new ArgumentNullException("m3_TOOL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TOOL", m3_TOOL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<GetToolResponse>(
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
		/// Name LstTools
		/// Description List data for tools
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstToolsResponse></returns>
		/// <exception cref="M3Exception<LstToolsResponse>"></exception>
		public async Task<M3Response<LstToolsResponse>> LstTools(
			string m3_TOOL = null, 
			int? m3_UTCM = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

			// Execute the request
			var result = await Execute<LstToolsResponse>(
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
		/// Name SetCurrentDate
		/// Description Sets the date of the record(s) to todays date
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SetCurrentDateResponse></returns>
		/// <exception cref="M3Exception<SetCurrentDateResponse>"></exception>
		public async Task<M3Response<SetCurrentDateResponse>> SetCurrentDate(
			string m3_TOOL = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());

			// Execute the request
			var result = await Execute<SetCurrentDateResponse>(
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
		/// Name UpdTool
		/// Description Update data for a tool
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_TOOL">Tool number (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_GUDF">Get user defaults</param>
		/// <param name="m3_PHNO">Telephone number</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_MPDT">Purchase date</param>
		/// <param name="m3_MFDT">Manufacturing date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTool(
			string m3_TOOL, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_USID = null, 
			int? m3_GUDF = null, 
			string m3_PHNO = null, 
			decimal? m3_PUPR = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			DateTime? m3_MPDT = null, 
			DateTime? m3_MFDT = null, 
			int? m3_TRTM = null, 
			int? m3_UTCM = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TOOL))
				throw new ArgumentNullException("m3_TOOL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TOOL", m3_TOOL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (m3_GUDF.HasValue)
				request.WithQueryParameter("GUDF", m3_GUDF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (m3_MPDT.HasValue)
				request.WithQueryParameter("MPDT", m3_MPDT.Value.ToM3String());
			if (m3_MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3_MFDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
