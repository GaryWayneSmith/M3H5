/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_MTRL">Component identity (Required)</param>
		/// <param name="m3_CFGL">Configuration position (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_MVRN">Model level</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddComponent(
			string m3_MOTP, 
			string m3_MTRL, 
			string m3_CFGL, 
			int? m3_CONO = null, 
			string m3_STAT = null, 
			string m3_MVRN = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");
			if (string.IsNullOrWhiteSpace(m3_MTRL))
				throw new ArgumentNullException("m3_MTRL");
			if (string.IsNullOrWhiteSpace(m3_CFGL))
				throw new ArgumentNullException("m3_CFGL");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim())
				.WithQueryParameter("MTRL", m3_MTRL.Trim())
				.WithQueryParameter("CFGL", m3_CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVRN))
				request.WithQueryParameter("MVRN", m3_MVRN.Trim());

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
		/// Name DltComponent
		/// Description Delete Component
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_MTRL">Component identity (Required)</param>
		/// <param name="m3_CFGL">Configuration position (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltComponent(
			string m3_MOTP, 
			string m3_MTRL, 
			string m3_CFGL, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");
			if (string.IsNullOrWhiteSpace(m3_MTRL))
				throw new ArgumentNullException("m3_MTRL");
			if (string.IsNullOrWhiteSpace(m3_CFGL))
				throw new ArgumentNullException("m3_CFGL");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim())
				.WithQueryParameter("MTRL", m3_MTRL.Trim())
				.WithQueryParameter("CFGL", m3_CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name GetComponent
		/// Description Get Component
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_MTRL">Component identity (Required)</param>
		/// <param name="m3_CFGL">Configuration position (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetComponentResponse></returns>
		/// <exception cref="M3Exception<GetComponentResponse>"></exception>
		public async Task<M3Response<GetComponentResponse>> GetComponent(
			string m3_MOTP, 
			string m3_MTRL, 
			string m3_CFGL, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");
			if (string.IsNullOrWhiteSpace(m3_MTRL))
				throw new ArgumentNullException("m3_MTRL");
			if (string.IsNullOrWhiteSpace(m3_CFGL))
				throw new ArgumentNullException("m3_CFGL");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim())
				.WithQueryParameter("MTRL", m3_MTRL.Trim())
				.WithQueryParameter("CFGL", m3_CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetComponentResponse>(
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
		/// Name LstComponent
		/// Description List Components
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstComponentResponse></returns>
		/// <exception cref="M3Exception<LstComponentResponse>"></exception>
		public async Task<M3Response<LstComponentResponse>> LstComponent(
			string m3_MOTP, 
			int? m3_CONO = null, 
			string m3_CFGL = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());

			// Execute the request
			var result = await Execute<LstComponentResponse>(
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
		/// Name UpdComponent
		/// Description Update Component
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_MTRL">Component identity (Required)</param>
		/// <param name="m3_CFGL">Configuration position (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_MVRN">Model level</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdComponent(
			string m3_MOTP, 
			string m3_MTRL, 
			string m3_CFGL, 
			int? m3_CONO = null, 
			string m3_STAT = null, 
			string m3_MVRN = null, 
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
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");
			if (string.IsNullOrWhiteSpace(m3_MTRL))
				throw new ArgumentNullException("m3_MTRL");
			if (string.IsNullOrWhiteSpace(m3_CFGL))
				throw new ArgumentNullException("m3_CFGL");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim())
				.WithQueryParameter("MTRL", m3_MTRL.Trim())
				.WithQueryParameter("CFGL", m3_CFGL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVRN))
				request.WithQueryParameter("MVRN", m3_MVRN.Trim());

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
