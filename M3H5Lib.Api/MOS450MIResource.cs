/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.MOS450MI;
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
	/// Name: MOS450MI
	/// Component Name: ModelComponents
	/// Description: Wrk: Components/Config Position
	/// Version Release: 13.1
	///</summary>
	public partial class MOS450MIResource : M3BaseResourceEndpoint
	{
		public MOS450MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS450MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddComponent
		/// Description Add Component
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3MTRL">Component identity (Required)</param>
		/// <param name="m3CFGL">Configuration position (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3MVRN">Model level</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddComponent(
			string m3MOTP, 
			string m3MTRL, 
			string m3CFGL, 
			int? m3CONO = null, 
			string m3STAT = null, 
			string m3MVRN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddComponent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));
			if (string.IsNullOrWhiteSpace(m3MTRL))
				throw new ArgumentNullException(nameof(m3MTRL));
			if (string.IsNullOrWhiteSpace(m3CFGL))
				throw new ArgumentNullException(nameof(m3CFGL));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim())
				.WithQueryParameter("MTRL", m3MTRL.Trim())
				.WithQueryParameter("CFGL", m3CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVRN))
				request.WithQueryParameter("MVRN", m3MVRN.Trim());

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
		/// Name DltComponent
		/// Description Delete Component
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3MTRL">Component identity (Required)</param>
		/// <param name="m3CFGL">Configuration position (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltComponent(
			string m3MOTP, 
			string m3MTRL, 
			string m3CFGL, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltComponent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));
			if (string.IsNullOrWhiteSpace(m3MTRL))
				throw new ArgumentNullException(nameof(m3MTRL));
			if (string.IsNullOrWhiteSpace(m3CFGL))
				throw new ArgumentNullException(nameof(m3CFGL));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim())
				.WithQueryParameter("MTRL", m3MTRL.Trim())
				.WithQueryParameter("CFGL", m3CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetComponent
		/// Description Get Component
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3MTRL">Component identity (Required)</param>
		/// <param name="m3CFGL">Configuration position (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetComponentResponse></returns>
		/// <exception cref="M3Exception<GetComponentResponse>"></exception>
		public async Task<M3Response<GetComponentResponse>> GetComponent(
			string m3MOTP, 
			string m3MTRL, 
			string m3CFGL, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetComponent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));
			if (string.IsNullOrWhiteSpace(m3MTRL))
				throw new ArgumentNullException(nameof(m3MTRL));
			if (string.IsNullOrWhiteSpace(m3CFGL))
				throw new ArgumentNullException(nameof(m3CFGL));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim())
				.WithQueryParameter("MTRL", m3MTRL.Trim())
				.WithQueryParameter("CFGL", m3CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetComponentResponse>(
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
		/// Name LstComponent
		/// Description List Components
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstComponentResponse></returns>
		/// <exception cref="M3Exception<LstComponentResponse>"></exception>
		public async Task<M3Response<LstComponentResponse>> LstComponent(
			string m3MOTP, 
			int? m3CONO = null, 
			string m3CFGL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstComponent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());

			// Execute the request
			var result = await Execute<LstComponentResponse>(
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
		/// Name UpdComponent
		/// Description Update Component
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3MTRL">Component identity (Required)</param>
		/// <param name="m3CFGL">Configuration position (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3MVRN">Model level</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdComponent(
			string m3MOTP, 
			string m3MTRL, 
			string m3CFGL, 
			int? m3CONO = null, 
			string m3STAT = null, 
			string m3MVRN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdComponent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));
			if (string.IsNullOrWhiteSpace(m3MTRL))
				throw new ArgumentNullException(nameof(m3MTRL));
			if (string.IsNullOrWhiteSpace(m3CFGL))
				throw new ArgumentNullException(nameof(m3CFGL));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim())
				.WithQueryParameter("MTRL", m3MTRL.Trim())
				.WithQueryParameter("CFGL", m3CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVRN))
				request.WithQueryParameter("MVRN", m3MVRN.Trim());

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
