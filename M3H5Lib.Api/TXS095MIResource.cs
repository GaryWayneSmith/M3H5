/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.TXS095MI;
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
	/// Name: TXS095MI
	/// Component Name: Tax Invoice Agent Settings
	/// Description: Tax Invoice Agent Settings
	/// Version Release: 5ea0
	///</summary>
	public partial class TXS095MIResource : M3BaseResourceEndpoint
	{
		public TXS095MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "TXS095MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTaxAgentSet
		/// Description Add Tax Invoice Agent Settings
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TIAG">Agent (Required)</param>
		/// <param name="m3_TIMT">Transfer method (Required)</param>
		/// <param name="m3_TIIN">Issuing number system (Required)</param>
		/// <param name="m3_TIBC">Business code (Required)</param>
		/// <param name="m3_TICC">Client code (Required)</param>
		/// <param name="m3_TISB">Smartbills server (Required)</param>
		/// <param name="m3_TIAT">Authentification token (Required)</param>
		/// <param name="m3_TRGI">Tax registration ID (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TIPW">Certificate password</param>
		/// <param name="m3_TIEK">Encryption key</param>
		/// <param name="m3_TIKI">Keystore id</param>
		/// <param name="m3_TIRV">Rvalue</param>
		/// <param name="m3_TIDA">Authentification token valid date</param>
		/// <param name="m3_SXML">Save XML</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTaxAgentSet(
			int m3_TIAG, 
			int m3_TIMT, 
			string m3_TIIN, 
			string m3_TIBC, 
			string m3_TICC, 
			string m3_TISB, 
			string m3_TIAT, 
			string m3_TRGI, 
			string m3_DIVI = null, 
			string m3_TIPW = null, 
			string m3_TIEK = null, 
			string m3_TIKI = null, 
			string m3_TIRV = null, 
			DateTime? m3_TIDA = null, 
			int? m3_SXML = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTaxAgentSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TIIN))
				throw new ArgumentNullException("m3_TIIN");
			if (string.IsNullOrWhiteSpace(m3_TIBC))
				throw new ArgumentNullException("m3_TIBC");
			if (string.IsNullOrWhiteSpace(m3_TICC))
				throw new ArgumentNullException("m3_TICC");
			if (string.IsNullOrWhiteSpace(m3_TISB))
				throw new ArgumentNullException("m3_TISB");
			if (string.IsNullOrWhiteSpace(m3_TIAT))
				throw new ArgumentNullException("m3_TIAT");
			if (string.IsNullOrWhiteSpace(m3_TRGI))
				throw new ArgumentNullException("m3_TRGI");

			// Set mandatory parameters
			request
				.WithQueryParameter("TIAG", m3_TIAG.ToString())
				.WithQueryParameter("TIMT", m3_TIMT.ToString())
				.WithQueryParameter("TIIN", m3_TIIN.Trim())
				.WithQueryParameter("TIBC", m3_TIBC.Trim())
				.WithQueryParameter("TICC", m3_TICC.Trim())
				.WithQueryParameter("TISB", m3_TISB.Trim())
				.WithQueryParameter("TIAT", m3_TIAT.Trim())
				.WithQueryParameter("TRGI", m3_TRGI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIPW))
				request.WithQueryParameter("TIPW", m3_TIPW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIEK))
				request.WithQueryParameter("TIEK", m3_TIEK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIKI))
				request.WithQueryParameter("TIKI", m3_TIKI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIRV))
				request.WithQueryParameter("TIRV", m3_TIRV.Trim());
			if (m3_TIDA.HasValue)
				request.WithQueryParameter("TIDA", m3_TIDA.Value.ToM3String());
			if (m3_SXML.HasValue)
				request.WithQueryParameter("SXML", m3_SXML.Value.ToString());

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
		/// Name CpyTaxAgentSet
		/// Description Copy Tax Invoice Agent Settings
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CDIV">Division - copy to (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyTaxAgentSet(
			string m3_CDIV, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyTaxAgentSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CDIV))
				throw new ArgumentNullException("m3_CDIV");

			// Set mandatory parameters
			request
				.WithQueryParameter("CDIV", m3_CDIV.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name DelTaxAgentSet
		/// Description Delete Tax Invoice Agent Settings
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTaxAgentSet(
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelTaxAgentSet",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name GetTaxAgentSet
		/// Description Get Tax Invoice Agent Settings
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxAgentSetResponse></returns>
		/// <exception cref="M3Exception<GetTaxAgentSetResponse>"></exception>
		public async Task<M3Response<GetTaxAgentSetResponse>> GetTaxAgentSet(
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTaxAgentSet",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetTaxAgentSetResponse>(
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
		/// Name LstTaxAgentSet
		/// Description List Tax Invoice Agent Settings
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxAgentSetResponse></returns>
		/// <exception cref="M3Exception<LstTaxAgentSetResponse>"></exception>
		public async Task<M3Response<LstTaxAgentSetResponse>> LstTaxAgentSet(
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTaxAgentSet",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstTaxAgentSetResponse>(
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
		/// Name UpdTaxAgentSet
		/// Description Update Tax Invoice Agent Settings
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TIAG">Agent</param>
		/// <param name="m3_TIMT">Transfer method</param>
		/// <param name="m3_TIIN">Issuing number system</param>
		/// <param name="m3_TIBC">Business code</param>
		/// <param name="m3_TICC">Client code</param>
		/// <param name="m3_TIPW">Certificate password</param>
		/// <param name="m3_TIEK">Encryption key</param>
		/// <param name="m3_TIKI">Keystore id</param>
		/// <param name="m3_TIRV">Rvalue</param>
		/// <param name="m3_TISB">Smartbills server</param>
		/// <param name="m3_TIAT">Authentification token</param>
		/// <param name="m3_TIDA">Authentification token valid date</param>
		/// <param name="m3_TRGI">Tax registration ID</param>
		/// <param name="m3_SXML">Save XML</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTaxAgentSet(
			string m3_DIVI = null, 
			int? m3_TIAG = null, 
			int? m3_TIMT = null, 
			string m3_TIIN = null, 
			string m3_TIBC = null, 
			string m3_TICC = null, 
			string m3_TIPW = null, 
			string m3_TIEK = null, 
			string m3_TIKI = null, 
			string m3_TIRV = null, 
			string m3_TISB = null, 
			string m3_TIAT = null, 
			DateTime? m3_TIDA = null, 
			string m3_TRGI = null, 
			int? m3_SXML = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTaxAgentSet",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_TIAG.HasValue)
				request.WithQueryParameter("TIAG", m3_TIAG.Value.ToString());
			if (m3_TIMT.HasValue)
				request.WithQueryParameter("TIMT", m3_TIMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TIIN))
				request.WithQueryParameter("TIIN", m3_TIIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIBC))
				request.WithQueryParameter("TIBC", m3_TIBC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TICC))
				request.WithQueryParameter("TICC", m3_TICC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIPW))
				request.WithQueryParameter("TIPW", m3_TIPW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIEK))
				request.WithQueryParameter("TIEK", m3_TIEK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIKI))
				request.WithQueryParameter("TIKI", m3_TIKI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIRV))
				request.WithQueryParameter("TIRV", m3_TIRV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TISB))
				request.WithQueryParameter("TISB", m3_TISB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIAT))
				request.WithQueryParameter("TIAT", m3_TIAT.Trim());
			if (m3_TIDA.HasValue)
				request.WithQueryParameter("TIDA", m3_TIDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TRGI))
				request.WithQueryParameter("TRGI", m3_TRGI.Trim());
			if (m3_SXML.HasValue)
				request.WithQueryParameter("SXML", m3_SXML.Value.ToString());

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
