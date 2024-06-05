/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.STS040MI;
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
	/// Name: STS040MI
	/// Component Name: CostAndRevenue
	/// Description: API: Cost and Revenue Allocation rules
	/// Version Release: 14.x
	///</summary>
	public partial class STS040MIResource : M3BaseResourceEndpoint
	{
		public STS040MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS040MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAllocRules
		/// Description Add Cost and Revenue Allocation rules
		/// Version Release: 
		/// </summary>
		/// <param name="m3_OFAC">Owning facility (Required)</param>
		/// <param name="m3_UFAC">Using facility (Required)</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_RSHA">Revenue share</param>
		/// <param name="m3_CSHA">Cost share</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAllocRules(
			string m3_OFAC, 
			string m3_UFAC, 
			string m3_ITCL = null, 
			int? m3_RSHA = null, 
			int? m3_CSHA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAllocRules",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_OFAC))
				throw new ArgumentNullException("m3_OFAC");
			if (string.IsNullOrWhiteSpace(m3_UFAC))
				throw new ArgumentNullException("m3_UFAC");

			// Set mandatory parameters
			request
				.WithQueryParameter("OFAC", m3_OFAC.Trim())
				.WithQueryParameter("UFAC", m3_UFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (m3_RSHA.HasValue)
				request.WithQueryParameter("RSHA", m3_RSHA.Value.ToString());
			if (m3_CSHA.HasValue)
				request.WithQueryParameter("CSHA", m3_CSHA.Value.ToString());

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
		/// Name DelAllocRules
		/// Description Delete Cost and Revenue Allocation Rules
		/// Version Release: 
		/// </summary>
		/// <param name="m3_OFAC">Owning facility</param>
		/// <param name="m3_UFAC">Using facility</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAllocRules(
			string m3_OFAC = null, 
			string m3_UFAC = null, 
			string m3_ITCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAllocRules",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OFAC))
				request.WithQueryParameter("OFAC", m3_OFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UFAC))
				request.WithQueryParameter("UFAC", m3_UFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());

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
		/// Name GetAllocRules
		/// Description Get Cost and Revenue Rules
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_OFAC">Owning facility (Required)</param>
		/// <param name="m3_UFAC">Using facility</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAllocRulesResponse></returns>
		/// <exception cref="M3Exception<GetAllocRulesResponse>"></exception>
		public async Task<M3Response<GetAllocRulesResponse>> GetAllocRules(
			string m3_OFAC, 
			string m3_UFAC = null, 
			string m3_ITCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAllocRules",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_OFAC))
				throw new ArgumentNullException("m3_OFAC");

			// Set mandatory parameters
			request
				.WithQueryParameter("OFAC", m3_OFAC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_UFAC))
				request.WithQueryParameter("UFAC", m3_UFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());

			// Execute the request
			var result = await Execute<GetAllocRulesResponse>(
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
		/// Name LstAllocRules
		/// Description List Cost and Revenue rules
		/// Version Release: 
		/// </summary>
		/// <param name="m3_OFAC">Owning facility</param>
		/// <param name="m3_UFAC">Using facility</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAllocRulesResponse></returns>
		/// <exception cref="M3Exception<LstAllocRulesResponse>"></exception>
		public async Task<M3Response<LstAllocRulesResponse>> LstAllocRules(
			string m3_OFAC = null, 
			string m3_UFAC = null, 
			string m3_ITCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAllocRules",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OFAC))
				request.WithQueryParameter("OFAC", m3_OFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UFAC))
				request.WithQueryParameter("UFAC", m3_UFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());

			// Execute the request
			var result = await Execute<LstAllocRulesResponse>(
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
		/// Name UpdAllocRules
		/// Description Update Cost and Revenue Allocation Rules
		/// Version Release: 
		/// </summary>
		/// <param name="m3_OFAC">Owning facility</param>
		/// <param name="m3_UFAC">Using facility</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_RSHA">Revenue share</param>
		/// <param name="m3_CSHA">Cost share</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAllocRules(
			string m3_OFAC = null, 
			string m3_UFAC = null, 
			string m3_ITCL = null, 
			int? m3_RSHA = null, 
			int? m3_CSHA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAllocRules",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OFAC))
				request.WithQueryParameter("OFAC", m3_OFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UFAC))
				request.WithQueryParameter("UFAC", m3_UFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (m3_RSHA.HasValue)
				request.WithQueryParameter("RSHA", m3_RSHA.Value.ToString());
			if (m3_CSHA.HasValue)
				request.WithQueryParameter("CSHA", m3_CSHA.Value.ToString());

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
