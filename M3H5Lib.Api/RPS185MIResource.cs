/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3RULE">Rule (Required)</param>
		/// <param name="m3OPE1">Operator (Required)</param>
		/// <param name="m3CMVL">Compare value (Required)</param>
		/// <param name="m3PLNT">Planning template (Required)</param>
		/// <param name="m3ANDO">AND operator (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="m3FLDA">Field</param>
		/// <param name="m3XVAL">X-value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPLTRule(
			string m3PREX, 
			string m3OBV1, 
			int m3SEQN, 
			string m3RULE, 
			string m3OPE1, 
			decimal m3CMVL, 
			string m3PLNT, 
			int m3ANDO, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
			string m3FLDA = null, 
			DateTime? m3XVAL = null, 
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
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));
			if (string.IsNullOrWhiteSpace(m3RULE))
				throw new ArgumentNullException(nameof(m3RULE));
			if (string.IsNullOrWhiteSpace(m3OPE1))
				throw new ArgumentNullException(nameof(m3OPE1));
			if (string.IsNullOrWhiteSpace(m3PLNT))
				throw new ArgumentNullException(nameof(m3PLNT));

			// Set mandatory parameters
			request
				.WithQueryParameter("PREX", m3PREX.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RULE", m3RULE.Trim())
				.WithQueryParameter("OPE1", m3OPE1.Trim())
				.WithQueryParameter("CMVL", m3CMVL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLNT", m3PLNT.Trim())
				.WithQueryParameter("ANDO", m3ANDO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDA))
				request.WithQueryParameter("FLDA", m3FLDA.Trim());
			if (m3XVAL.HasValue)
				request.WithQueryParameter("XVAL", m3XVAL.Value.ToM3String());

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
		/// Name ChangePLTRule
		/// Description Change Planning template rule
		/// Version Release: 
		/// </summary>
		/// <param name="m3PREX">Priority</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3RULE">Rule</param>
		/// <param name="m3FLDA">Field</param>
		/// <param name="m3XVAL">X-value</param>
		/// <param name="m3OPE1">Operator</param>
		/// <param name="m3CMVL">Compare value</param>
		/// <param name="m3PLNT">Planning template</param>
		/// <param name="m3ANDO">AND operator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangePLTRule(
			string m3PREX = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
			int? m3SEQN = null, 
			string m3RULE = null, 
			string m3FLDA = null, 
			DateTime? m3XVAL = null, 
			string m3OPE1 = null, 
			decimal? m3CMVL = null, 
			string m3PLNT = null, 
			int? m3ANDO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PREX))
				request.WithQueryParameter("PREX", m3PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RULE))
				request.WithQueryParameter("RULE", m3RULE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDA))
				request.WithQueryParameter("FLDA", m3FLDA.Trim());
			if (m3XVAL.HasValue)
				request.WithQueryParameter("XVAL", m3XVAL.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OPE1))
				request.WithQueryParameter("OPE1", m3OPE1.Trim());
			if (m3CMVL.HasValue)
				request.WithQueryParameter("CMVL", m3CMVL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLNT))
				request.WithQueryParameter("PLNT", m3PLNT.Trim());
			if (m3ANDO.HasValue)
				request.WithQueryParameter("ANDO", m3ANDO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CopyPLTRule
		/// Description Copy Planning template rule
		/// Version Release: 
		/// </summary>
		/// <param name="m3FRPR">Priority</param>
		/// <param name="m3FRV1">Start value 1</param>
		/// <param name="m3FRV2">Start value 2</param>
		/// <param name="m3FRV3">Start value 3</param>
		/// <param name="m3FRV4">Start value 4</param>
		/// <param name="m3FRV5">Start value 5</param>
		/// <param name="m3FRSQ">Sequence number</param>
		/// <param name="m3TOV1">Start value 1</param>
		/// <param name="m3TOV2">Start value 2</param>
		/// <param name="m3TOV3">Start value 3</param>
		/// <param name="m3TOV4">Start value 4</param>
		/// <param name="m3TOV5">Start value 5</param>
		/// <param name="m3TOSQ">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CopyPLTRule(
			string m3FRPR = null, 
			string m3FRV1 = null, 
			string m3FRV2 = null, 
			string m3FRV3 = null, 
			string m3FRV4 = null, 
			string m3FRV5 = null, 
			int? m3FRSQ = null, 
			string m3TOV1 = null, 
			string m3TOV2 = null, 
			string m3TOV3 = null, 
			string m3TOV4 = null, 
			string m3TOV5 = null, 
			int? m3TOSQ = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FRPR))
				request.WithQueryParameter("FRPR", m3FRPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRV1))
				request.WithQueryParameter("FRV1", m3FRV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRV2))
				request.WithQueryParameter("FRV2", m3FRV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRV3))
				request.WithQueryParameter("FRV3", m3FRV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRV4))
				request.WithQueryParameter("FRV4", m3FRV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRV5))
				request.WithQueryParameter("FRV5", m3FRV5.Trim());
			if (m3FRSQ.HasValue)
				request.WithQueryParameter("FRSQ", m3FRSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TOV1))
				request.WithQueryParameter("TOV1", m3TOV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOV2))
				request.WithQueryParameter("TOV2", m3TOV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOV3))
				request.WithQueryParameter("TOV3", m3TOV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOV4))
				request.WithQueryParameter("TOV4", m3TOV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOV5))
				request.WithQueryParameter("TOV5", m3TOV5.Trim());
			if (m3TOSQ.HasValue)
				request.WithQueryParameter("TOSQ", m3TOSQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DeletePLTRule
		/// Description Delete Planning template rule
		/// Version Release: 
		/// </summary>
		/// <param name="m3PREX">Priority</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeletePLTRule(
			string m3PREX = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeletePLTRule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PREX))
				request.WithQueryParameter("PREX", m3PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());
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
		/// Name ListPLTRule
		/// Description List Planning template rule
		/// Version Release: 
		/// </summary>
		/// <param name="m3PREX">Priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListPLTRuleResponse></returns>
		/// <exception cref="M3Exception<ListPLTRuleResponse>"></exception>
		public async Task<M3Response<ListPLTRuleResponse>> ListPLTRule(
			string m3PREX = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PREX))
				request.WithQueryParameter("PREX", m3PREX.Trim());

			// Execute the request
			var result = await Execute<ListPLTRuleResponse>(
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
