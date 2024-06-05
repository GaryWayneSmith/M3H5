/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3MEDC">Media (Required)</param>
		/// <param name="m3PRTF">Printer file</param>
		/// <param name="m3DEVD">Location</param>
		/// <param name="m31DEV">Field selection Printer</param>
		/// <param name="m3DEV1">Printer</param>
		/// <param name="m31COP">Field selection Number of copies</param>
		/// <param name="m3COPY">Number of copies</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3USID, 
			string m3MEDC, 
			string m3PRTF = null, 
			string m3DEVD = null, 
			string m31DEV = null, 
			string m3DEV1 = null, 
			string m31COP = null, 
			int? m3COPY = null, 
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
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));
			if (string.IsNullOrWhiteSpace(m3MEDC))
				throw new ArgumentNullException(nameof(m3MEDC));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("MEDC", m3MEDC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRTF))
				request.WithQueryParameter("PRTF", m3PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEVD))
				request.WithQueryParameter("DEVD", m3DEVD.Trim());
			if (!string.IsNullOrWhiteSpace(m31DEV))
				request.WithQueryParameter("1DEV", m31DEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEV1))
				request.WithQueryParameter("DEV1", m3DEV1.Trim());
			if (!string.IsNullOrWhiteSpace(m31COP))
				request.WithQueryParameter("1COP", m31COP.Trim());
			if (m3COPY.HasValue)
				request.WithQueryParameter("COPY", m3COPY.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Del
		/// Description Delete output media selection record
		/// Version Release: 
		/// </summary>
		/// <param name="m3PRTF">Printer file</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3DEVD">Location</param>
		/// <param name="m3MEDC">Media</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3PRTF = null, 
			string m3USID = null, 
			string m3DEVD = null, 
			string m3MEDC = null, 
			int? m3SEQN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PRTF))
				request.WithQueryParameter("PRTF", m3PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEVD))
				request.WithQueryParameter("DEVD", m3DEVD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEDC))
				request.WithQueryParameter("MEDC", m3MEDC.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Get
		/// Description Get output media selection record
		/// Version Release: 
		/// </summary>
		/// <param name="m3PRTF">Printer file</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3DEVD">Location</param>
		/// <param name="m3MEDC">Media</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3PRTF = null, 
			string m3USID = null, 
			string m3DEVD = null, 
			string m3MEDC = null, 
			int? m3SEQN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PRTF))
				request.WithQueryParameter("PRTF", m3PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEVD))
				request.WithQueryParameter("DEVD", m3DEVD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEDC))
				request.WithQueryParameter("MEDC", m3MEDC.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List output media selection records
		/// Version Release: 
		/// </summary>
		/// <param name="m3PRTF">Printer file</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3DEVD">Location</param>
		/// <param name="m3MEDC">Media</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3PRTF = null, 
			string m3USID = null, 
			string m3DEVD = null, 
			string m3MEDC = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PRTF))
				request.WithQueryParameter("PRTF", m3PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEVD))
				request.WithQueryParameter("DEVD", m3DEVD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEDC))
				request.WithQueryParameter("MEDC", m3MEDC.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Update output media selection record
		/// Version Release: 
		/// </summary>
		/// <param name="m3PRTF">Printer file</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3DEVD">Location</param>
		/// <param name="m3MEDC">Media</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m31DEV">Field selection Printer</param>
		/// <param name="m3DEV1">Printer</param>
		/// <param name="m31COP">Field selection Number of copies</param>
		/// <param name="m3COPY">Number of copies</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3PRTF = null, 
			string m3USID = null, 
			string m3DEVD = null, 
			string m3MEDC = null, 
			int? m3SEQN = null, 
			string m31DEV = null, 
			string m3DEV1 = null, 
			string m31COP = null, 
			int? m3COPY = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PRTF))
				request.WithQueryParameter("PRTF", m3PRTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEVD))
				request.WithQueryParameter("DEVD", m3DEVD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEDC))
				request.WithQueryParameter("MEDC", m3MEDC.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m31DEV))
				request.WithQueryParameter("1DEV", m31DEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEV1))
				request.WithQueryParameter("DEV1", m3DEV1.Trim());
			if (!string.IsNullOrWhiteSpace(m31COP))
				request.WithQueryParameter("1COP", m31COP.Trim());
			if (m3COPY.HasValue)
				request.WithQueryParameter("COPY", m3COPY.Value.ToString(CultureInfo.CurrentCulture));

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
