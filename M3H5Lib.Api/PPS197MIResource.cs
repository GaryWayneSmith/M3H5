/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS197MI;
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
	/// Name: PPS197MI
	/// Component Name: Priority Rule
	/// Description: Priority Rule
	/// Version Release: 5e90
	///</summary>
	public partial class PPS197MIResource : M3BaseResourceEndpoint
	{
		public PPS197MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS197MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPriorityRule
		/// Description AddPriorityRule
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_RULE">Rule</param>
		/// <param name="m3_VALA">Value alpha-numerical</param>
		/// <param name="m3_ANDO">AND operator</param>
		/// <param name="m3_PPRN">Priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPriorityRule(
			int? m3_SEQN = null, 
			string m3_RULE = null, 
			string m3_VALA = null, 
			int? m3_ANDO = null, 
			int? m3_PPRN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPriorityRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RULE))
				request.WithQueryParameter("RULE", m3_RULE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VALA))
				request.WithQueryParameter("VALA", m3_VALA.Trim());
			if (m3_ANDO.HasValue)
				request.WithQueryParameter("ANDO", m3_ANDO.Value.ToString());
			if (m3_PPRN.HasValue)
				request.WithQueryParameter("PPRN", m3_PPRN.Value.ToString());

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
		/// Name DltPriorityRule
		/// Description DltPriorityRule
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPriorityRule(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPriorityRule",
			};

			// Set optional parameters, checking for null/blank data for each element
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
		/// Name GetPriorityRule
		/// Description GetPriorityRule
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPriorityRuleResponse></returns>
		/// <exception cref="M3Exception<GetPriorityRuleResponse>"></exception>
		public async Task<M3Response<GetPriorityRuleResponse>> GetPriorityRule(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPriorityRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

			// Execute the request
			var result = await Execute<GetPriorityRuleResponse>(
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
		/// Name LstPriorityRule
		/// Description LstPriorityRule
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPriorityRuleResponse></returns>
		/// <exception cref="M3Exception<LstPriorityRuleResponse>"></exception>
		public async Task<M3Response<LstPriorityRuleResponse>> LstPriorityRule(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPriorityRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

			// Execute the request
			var result = await Execute<LstPriorityRuleResponse>(
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
		/// Name UpdPriorityRule
		/// Description UpdPriorityRule
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_RULE">Rule</param>
		/// <param name="m3_VALA">Value alpha-numerical</param>
		/// <param name="m3_ANDO">AND operator</param>
		/// <param name="m3_PPRN">Priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPriorityRule(
			int? m3_SEQN = null, 
			string m3_RULE = null, 
			string m3_VALA = null, 
			int? m3_ANDO = null, 
			int? m3_PPRN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPriorityRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RULE))
				request.WithQueryParameter("RULE", m3_RULE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VALA))
				request.WithQueryParameter("VALA", m3_VALA.Trim());
			if (m3_ANDO.HasValue)
				request.WithQueryParameter("ANDO", m3_ANDO.Value.ToString());
			if (m3_PPRN.HasValue)
				request.WithQueryParameter("PPRN", m3_PPRN.Value.ToString());

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
