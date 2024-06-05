/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MNS205MI;
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
	/// Name: MNS205MI
	/// Component Name: Output media selection
	/// Description: API: Output Media Selection
	/// Version Release: 14.x
	///</summary>
	public partial class MNS205MIResource : M3BaseResourceEndpoint
	{
		public MNS205MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS205MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add output media selection record
		/// Version Release: 
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_MEDC">Media (Required)</param>
		/// <param name="m3_PRTF">Printer file</param>
		/// <param name="m3_DEVD">Location</param>
		/// <param name="m3_1DEV">Field selection Printer</param>
		/// <param name="m3_DEV1">Printer</param>
		/// <param name="m3_1COP">Field selection Number of copies</param>
		/// <param name="m3_COPY">Number of copies</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_USID, 
			string m3_MEDC, 
			string m3_PRTF = null, 
			string m3_DEVD = null, 
			string m3_1DEV = null, 
			string m3_DEV1 = null, 
			string m3_1COP = null, 
			int? m3_COPY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_MEDC))
				throw new ArgumentNullException("m3_MEDC");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("MEDC", m3_MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRTF))
				request.WithQueryParameter("PRTF", m3_PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEVD))
				request.WithQueryParameter("DEVD", m3_DEVD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_1DEV))
				request.WithQueryParameter("1DEV", m3_1DEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEV1))
				request.WithQueryParameter("DEV1", m3_DEV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_1COP))
				request.WithQueryParameter("1COP", m3_1COP.Trim());
			if (m3_COPY.HasValue)
				request.WithQueryParameter("COPY", m3_COPY.Value.ToString());

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
		/// Name Del
		/// Description Delete output media selection record
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRTF">Printer file</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_DEVD">Location</param>
		/// <param name="m3_MEDC">Media</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3_PRTF = null, 
			string m3_USID = null, 
			string m3_DEVD = null, 
			string m3_MEDC = null, 
			int? m3_SEQN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRTF))
				request.WithQueryParameter("PRTF", m3_PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEVD))
				request.WithQueryParameter("DEVD", m3_DEVD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEDC))
				request.WithQueryParameter("MEDC", m3_MEDC.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

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
		/// Name Get
		/// Description Get output media selection record
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRTF">Printer file</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_DEVD">Location</param>
		/// <param name="m3_MEDC">Media</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_PRTF = null, 
			string m3_USID = null, 
			string m3_DEVD = null, 
			string m3_MEDC = null, 
			int? m3_SEQN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRTF))
				request.WithQueryParameter("PRTF", m3_PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEVD))
				request.WithQueryParameter("DEVD", m3_DEVD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEDC))
				request.WithQueryParameter("MEDC", m3_MEDC.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List output media selection records
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRTF">Printer file</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_DEVD">Location</param>
		/// <param name="m3_MEDC">Media</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_PRTF = null, 
			string m3_USID = null, 
			string m3_DEVD = null, 
			string m3_MEDC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRTF))
				request.WithQueryParameter("PRTF", m3_PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEVD))
				request.WithQueryParameter("DEVD", m3_DEVD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEDC))
				request.WithQueryParameter("MEDC", m3_MEDC.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Update output media selection record
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRTF">Printer file</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_DEVD">Location</param>
		/// <param name="m3_MEDC">Media</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_1DEV">Field selection Printer</param>
		/// <param name="m3_DEV1">Printer</param>
		/// <param name="m3_1COP">Field selection Number of copies</param>
		/// <param name="m3_COPY">Number of copies</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_PRTF = null, 
			string m3_USID = null, 
			string m3_DEVD = null, 
			string m3_MEDC = null, 
			int? m3_SEQN = null, 
			string m3_1DEV = null, 
			string m3_DEV1 = null, 
			string m3_1COP = null, 
			int? m3_COPY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRTF))
				request.WithQueryParameter("PRTF", m3_PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEVD))
				request.WithQueryParameter("DEVD", m3_DEVD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEDC))
				request.WithQueryParameter("MEDC", m3_MEDC.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_1DEV))
				request.WithQueryParameter("1DEV", m3_1DEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEV1))
				request.WithQueryParameter("DEV1", m3_DEV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_1COP))
				request.WithQueryParameter("1COP", m3_1COP.Trim());
			if (m3_COPY.HasValue)
				request.WithQueryParameter("COPY", m3_COPY.Value.ToString());

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
