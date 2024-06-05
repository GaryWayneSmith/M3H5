/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.RPS185MI;
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
	/// Name: RPS185MI
	/// Component Name: Planning template
	/// Description: Api: Planning template rules
	/// Version Release: 
	///</summary>
	public partial class RPS185MIResource : M3BaseResourceEndpoint
	{
		public RPS185MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "RPS185MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPLTRule
		/// Description Add Planning template rule
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_RULE">Rule (Required)</param>
		/// <param name="m3_OPE1">Operator (Required)</param>
		/// <param name="m3_CMVL">Compare value (Required)</param>
		/// <param name="m3_PLNT">Planning template (Required)</param>
		/// <param name="m3_ANDO">AND operator (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="m3_FLDA">Field</param>
		/// <param name="m3_XVAL">X-value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPLTRule(
			string m3_PREX, 
			string m3_OBV1, 
			int m3_SEQN, 
			string m3_RULE, 
			string m3_OPE1, 
			decimal m3_CMVL, 
			string m3_PLNT, 
			int m3_ANDO, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
			string m3_FLDA = null, 
			DateTime? m3_XVAL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPLTRule",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");
			if (string.IsNullOrWhiteSpace(m3_RULE))
				throw new ArgumentNullException("m3_RULE");
			if (string.IsNullOrWhiteSpace(m3_OPE1))
				throw new ArgumentNullException("m3_OPE1");
			if (string.IsNullOrWhiteSpace(m3_PLNT))
				throw new ArgumentNullException("m3_PLNT");

			// Set mandatory parameters
			request
				.WithQueryParameter("PREX", m3_PREX.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString())
				.WithQueryParameter("RULE", m3_RULE.Trim())
				.WithQueryParameter("OPE1", m3_OPE1.Trim())
				.WithQueryParameter("CMVL", m3_CMVL.ToString())
				.WithQueryParameter("PLNT", m3_PLNT.Trim())
				.WithQueryParameter("ANDO", m3_ANDO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDA))
				request.WithQueryParameter("FLDA", m3_FLDA.Trim());
			if (m3_XVAL.HasValue)
				request.WithQueryParameter("XVAL", m3_XVAL.Value.ToM3String());

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
		/// Name ChangePLTRule
		/// Description Change Planning template rule
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PREX">Priority</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_RULE">Rule</param>
		/// <param name="m3_FLDA">Field</param>
		/// <param name="m3_XVAL">X-value</param>
		/// <param name="m3_OPE1">Operator</param>
		/// <param name="m3_CMVL">Compare value</param>
		/// <param name="m3_PLNT">Planning template</param>
		/// <param name="m3_ANDO">AND operator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangePLTRule(
			string m3_PREX = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
			int? m3_SEQN = null, 
			string m3_RULE = null, 
			string m3_FLDA = null, 
			DateTime? m3_XVAL = null, 
			string m3_OPE1 = null, 
			decimal? m3_CMVL = null, 
			string m3_PLNT = null, 
			int? m3_ANDO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChangePLTRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PREX))
				request.WithQueryParameter("PREX", m3_PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RULE))
				request.WithQueryParameter("RULE", m3_RULE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDA))
				request.WithQueryParameter("FLDA", m3_FLDA.Trim());
			if (m3_XVAL.HasValue)
				request.WithQueryParameter("XVAL", m3_XVAL.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OPE1))
				request.WithQueryParameter("OPE1", m3_OPE1.Trim());
			if (m3_CMVL.HasValue)
				request.WithQueryParameter("CMVL", m3_CMVL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLNT))
				request.WithQueryParameter("PLNT", m3_PLNT.Trim());
			if (m3_ANDO.HasValue)
				request.WithQueryParameter("ANDO", m3_ANDO.Value.ToString());

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
		/// Name CopyPLTRule
		/// Description Copy Planning template rule
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FRPR">Priority</param>
		/// <param name="m3_FRV1">Start value 1</param>
		/// <param name="m3_FRV2">Start value 2</param>
		/// <param name="m3_FRV3">Start value 3</param>
		/// <param name="m3_FRV4">Start value 4</param>
		/// <param name="m3_FRV5">Start value 5</param>
		/// <param name="m3_FRSQ">Sequence number</param>
		/// <param name="m3_TOV1">Start value 1</param>
		/// <param name="m3_TOV2">Start value 2</param>
		/// <param name="m3_TOV3">Start value 3</param>
		/// <param name="m3_TOV4">Start value 4</param>
		/// <param name="m3_TOV5">Start value 5</param>
		/// <param name="m3_TOSQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CopyPLTRule(
			string m3_FRPR = null, 
			string m3_FRV1 = null, 
			string m3_FRV2 = null, 
			string m3_FRV3 = null, 
			string m3_FRV4 = null, 
			string m3_FRV5 = null, 
			int? m3_FRSQ = null, 
			string m3_TOV1 = null, 
			string m3_TOV2 = null, 
			string m3_TOV3 = null, 
			string m3_TOV4 = null, 
			string m3_TOV5 = null, 
			int? m3_TOSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CopyPLTRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FRPR))
				request.WithQueryParameter("FRPR", m3_FRPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRV1))
				request.WithQueryParameter("FRV1", m3_FRV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRV2))
				request.WithQueryParameter("FRV2", m3_FRV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRV3))
				request.WithQueryParameter("FRV3", m3_FRV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRV4))
				request.WithQueryParameter("FRV4", m3_FRV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRV5))
				request.WithQueryParameter("FRV5", m3_FRV5.Trim());
			if (m3_FRSQ.HasValue)
				request.WithQueryParameter("FRSQ", m3_FRSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TOV1))
				request.WithQueryParameter("TOV1", m3_TOV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOV2))
				request.WithQueryParameter("TOV2", m3_TOV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOV3))
				request.WithQueryParameter("TOV3", m3_TOV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOV4))
				request.WithQueryParameter("TOV4", m3_TOV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOV5))
				request.WithQueryParameter("TOV5", m3_TOV5.Trim());
			if (m3_TOSQ.HasValue)
				request.WithQueryParameter("TOSQ", m3_TOSQ.Value.ToString());

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
		/// Name DeletePLTRule
		/// Description Delete Planning template rule
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PREX">Priority</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeletePLTRule(
			string m3_PREX = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeletePLTRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PREX))
				request.WithQueryParameter("PREX", m3_PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());
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
		/// Name ListPLTRule
		/// Description List Planning template rule
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PREX">Priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListPLTRuleResponse></returns>
		/// <exception cref="M3Exception<ListPLTRuleResponse>"></exception>
		public async Task<M3Response<ListPLTRuleResponse>> ListPLTRule(
			string m3_PREX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListPLTRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PREX))
				request.WithQueryParameter("PREX", m3_PREX.Trim());

			// Execute the request
			var result = await Execute<ListPLTRuleResponse>(
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
