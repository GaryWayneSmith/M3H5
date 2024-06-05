/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTaxAgentSet
		/// Description Add Tax Invoice Agent Settings
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TIAG">Agent (Required)</param>
		/// <param name="m3TIMT">Transfer method (Required)</param>
		/// <param name="m3TIIN">Issuing number system (Required)</param>
		/// <param name="m3TIBC">Business code (Required)</param>
		/// <param name="m3TICC">Client code (Required)</param>
		/// <param name="m3TISB">Smartbills server (Required)</param>
		/// <param name="m3TIAT">Authentification token (Required)</param>
		/// <param name="m3TRGI">Tax registration ID (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3TIPW">Certificate password</param>
		/// <param name="m3TIEK">Encryption key</param>
		/// <param name="m3TIKI">Keystore id</param>
		/// <param name="m3TIRV">Rvalue</param>
		/// <param name="m3TIDA">Authentification token valid date</param>
		/// <param name="m3SXML">Save XML</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTaxAgentSet(
			int m3TIAG, 
			int m3TIMT, 
			string m3TIIN, 
			string m3TIBC, 
			string m3TICC, 
			string m3TISB, 
			string m3TIAT, 
			string m3TRGI, 
			string m3DIVI = null, 
			string m3TIPW = null, 
			string m3TIEK = null, 
			string m3TIKI = null, 
			string m3TIRV = null, 
			DateTime? m3TIDA = null, 
			int? m3SXML = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddTaxAgentSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TIIN))
				throw new ArgumentNullException(nameof(m3TIIN));
			if (string.IsNullOrWhiteSpace(m3TIBC))
				throw new ArgumentNullException(nameof(m3TIBC));
			if (string.IsNullOrWhiteSpace(m3TICC))
				throw new ArgumentNullException(nameof(m3TICC));
			if (string.IsNullOrWhiteSpace(m3TISB))
				throw new ArgumentNullException(nameof(m3TISB));
			if (string.IsNullOrWhiteSpace(m3TIAT))
				throw new ArgumentNullException(nameof(m3TIAT));
			if (string.IsNullOrWhiteSpace(m3TRGI))
				throw new ArgumentNullException(nameof(m3TRGI));

			// Set mandatory parameters
			request
				.WithQueryParameter("TIAG", m3TIAG.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TIMT", m3TIMT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TIIN", m3TIIN.Trim())
				.WithQueryParameter("TIBC", m3TIBC.Trim())
				.WithQueryParameter("TICC", m3TICC.Trim())
				.WithQueryParameter("TISB", m3TISB.Trim())
				.WithQueryParameter("TIAT", m3TIAT.Trim())
				.WithQueryParameter("TRGI", m3TRGI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIPW))
				request.WithQueryParameter("TIPW", m3TIPW.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIEK))
				request.WithQueryParameter("TIEK", m3TIEK.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIKI))
				request.WithQueryParameter("TIKI", m3TIKI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIRV))
				request.WithQueryParameter("TIRV", m3TIRV.Trim());
			if (m3TIDA.HasValue)
				request.WithQueryParameter("TIDA", m3TIDA.Value.ToM3String());
			if (m3SXML.HasValue)
				request.WithQueryParameter("SXML", m3SXML.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CpyTaxAgentSet
		/// Description Copy Tax Invoice Agent Settings
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CDIV">Division - copy to (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyTaxAgentSet(
			string m3CDIV, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CpyTaxAgentSet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CDIV))
				throw new ArgumentNullException(nameof(m3CDIV));

			// Set mandatory parameters
			request
				.WithQueryParameter("CDIV", m3CDIV.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name DelTaxAgentSet
		/// Description Delete Tax Invoice Agent Settings
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTaxAgentSet(
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelTaxAgentSet",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name GetTaxAgentSet
		/// Description Get Tax Invoice Agent Settings
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaxAgentSetResponse></returns>
		/// <exception cref="M3Exception<GetTaxAgentSetResponse>"></exception>
		public async Task<M3Response<GetTaxAgentSetResponse>> GetTaxAgentSet(
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetTaxAgentSet",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetTaxAgentSetResponse>(
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
		/// Name LstTaxAgentSet
		/// Description List Tax Invoice Agent Settings
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaxAgentSetResponse></returns>
		/// <exception cref="M3Exception<LstTaxAgentSetResponse>"></exception>
		public async Task<M3Response<LstTaxAgentSetResponse>> LstTaxAgentSet(
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTaxAgentSet",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstTaxAgentSetResponse>(
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
		/// Name UpdTaxAgentSet
		/// Description Update Tax Invoice Agent Settings
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3TIAG">Agent</param>
		/// <param name="m3TIMT">Transfer method</param>
		/// <param name="m3TIIN">Issuing number system</param>
		/// <param name="m3TIBC">Business code</param>
		/// <param name="m3TICC">Client code</param>
		/// <param name="m3TIPW">Certificate password</param>
		/// <param name="m3TIEK">Encryption key</param>
		/// <param name="m3TIKI">Keystore id</param>
		/// <param name="m3TIRV">Rvalue</param>
		/// <param name="m3TISB">Smartbills server</param>
		/// <param name="m3TIAT">Authentification token</param>
		/// <param name="m3TIDA">Authentification token valid date</param>
		/// <param name="m3TRGI">Tax registration ID</param>
		/// <param name="m3SXML">Save XML</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTaxAgentSet(
			string m3DIVI = null, 
			int? m3TIAG = null, 
			int? m3TIMT = null, 
			string m3TIIN = null, 
			string m3TIBC = null, 
			string m3TICC = null, 
			string m3TIPW = null, 
			string m3TIEK = null, 
			string m3TIKI = null, 
			string m3TIRV = null, 
			string m3TISB = null, 
			string m3TIAT = null, 
			DateTime? m3TIDA = null, 
			string m3TRGI = null, 
			int? m3SXML = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdTaxAgentSet",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3TIAG.HasValue)
				request.WithQueryParameter("TIAG", m3TIAG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TIMT.HasValue)
				request.WithQueryParameter("TIMT", m3TIMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TIIN))
				request.WithQueryParameter("TIIN", m3TIIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIBC))
				request.WithQueryParameter("TIBC", m3TIBC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TICC))
				request.WithQueryParameter("TICC", m3TICC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIPW))
				request.WithQueryParameter("TIPW", m3TIPW.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIEK))
				request.WithQueryParameter("TIEK", m3TIEK.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIKI))
				request.WithQueryParameter("TIKI", m3TIKI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIRV))
				request.WithQueryParameter("TIRV", m3TIRV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TISB))
				request.WithQueryParameter("TISB", m3TISB.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIAT))
				request.WithQueryParameter("TIAT", m3TIAT.Trim());
			if (m3TIDA.HasValue)
				request.WithQueryParameter("TIDA", m3TIDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TRGI))
				request.WithQueryParameter("TRGI", m3TRGI.Trim());
			if (m3SXML.HasValue)
				request.WithQueryParameter("SXML", m3SXML.Value.ToString(CultureInfo.CurrentCulture));

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
