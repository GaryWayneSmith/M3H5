/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPriorityRule
		/// Description AddPriorityRule
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3RULE">Rule</param>
		/// <param name="m3VALA">Value alpha-numerical</param>
		/// <param name="m3ANDO">AND operator</param>
		/// <param name="m3PPRN">Priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPriorityRule(
			int? m3SEQN = null, 
			string m3RULE = null, 
			string m3VALA = null, 
			int? m3ANDO = null, 
			int? m3PPRN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPriorityRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RULE))
				request.WithQueryParameter("RULE", m3RULE.Trim());
			if (!string.IsNullOrWhiteSpace(m3VALA))
				request.WithQueryParameter("VALA", m3VALA.Trim());
			if (m3ANDO.HasValue)
				request.WithQueryParameter("ANDO", m3ANDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPRN.HasValue)
				request.WithQueryParameter("PPRN", m3PPRN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltPriorityRule
		/// Description DltPriorityRule
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPriorityRule(
			int? m3SEQN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltPriorityRule",
			};

			// Set optional parameters, checking for null/blank data for each element
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
		/// Name GetPriorityRule
		/// Description GetPriorityRule
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPriorityRuleResponse></returns>
		/// <exception cref="M3Exception<GetPriorityRuleResponse>"></exception>
		public async Task<M3Response<GetPriorityRuleResponse>> GetPriorityRule(
			int? m3SEQN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPriorityRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPriorityRuleResponse>(
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
		/// Name LstPriorityRule
		/// Description LstPriorityRule
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPriorityRuleResponse></returns>
		/// <exception cref="M3Exception<LstPriorityRuleResponse>"></exception>
		public async Task<M3Response<LstPriorityRuleResponse>> LstPriorityRule(
			int? m3SEQN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPriorityRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPriorityRuleResponse>(
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
		/// Name UpdPriorityRule
		/// Description UpdPriorityRule
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3RULE">Rule</param>
		/// <param name="m3VALA">Value alpha-numerical</param>
		/// <param name="m3ANDO">AND operator</param>
		/// <param name="m3PPRN">Priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPriorityRule(
			int? m3SEQN = null, 
			string m3RULE = null, 
			string m3VALA = null, 
			int? m3ANDO = null, 
			int? m3PPRN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPriorityRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RULE))
				request.WithQueryParameter("RULE", m3RULE.Trim());
			if (!string.IsNullOrWhiteSpace(m3VALA))
				request.WithQueryParameter("VALA", m3VALA.Trim());
			if (m3ANDO.HasValue)
				request.WithQueryParameter("ANDO", m3ANDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPRN.HasValue)
				request.WithQueryParameter("PPRN", m3PPRN.Value.ToString(CultureInfo.CurrentCulture));

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
