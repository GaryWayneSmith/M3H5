/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.ARS251MI;
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
	/// Name: ARS251MI
	/// Component Name: AccountsReceivableInformation
	/// Description: Accounts receivable information interface
	/// Version Release: 5ea0
	///</summary>
	public partial class ARS251MIResource : M3BaseResourceEndpoint
	{
		public ARS251MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ARS251MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddInfoCat
		/// Description AddInfoCat
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3JRNO">Journal number (Required)</param>
		/// <param name="m3JSNO">Journal sequence number (Required)</param>
		/// <param name="m3SEXN">AR information category (Required)</param>
		/// <param name="m3SEXI">AR additional information (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SEXS">AR information sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInfoCat(
			int m3YEA4, 
			int m3JRNO, 
			int m3JSNO, 
			int m3SEXN, 
			string m3SEXI, 
			string m3DIVI = null, 
			int? m3SEXS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SEXI))
				throw new ArgumentNullException(nameof(m3SEXI));

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JRNO", m3JRNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JSNO", m3JSNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEXN", m3SEXN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEXI", m3SEXI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3SEXS.HasValue)
				request.WithQueryParameter("SEXS", m3SEXS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltInfoCat
		/// Description DltInfoCat
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3JRNO">Journal number (Required)</param>
		/// <param name="m3JSNO">Journal sequence number (Required)</param>
		/// <param name="m3SEXN">AR information category (Required)</param>
		/// <param name="m3SEXI">AR additional information (Required)</param>
		/// <param name="m3SEXS">AR information sequence number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltInfoCat(
			int m3YEA4, 
			int m3JRNO, 
			int m3JSNO, 
			int m3SEXN, 
			string m3SEXI, 
			int m3SEXS, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SEXI))
				throw new ArgumentNullException(nameof(m3SEXI));

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JRNO", m3JRNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JSNO", m3JSNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEXN", m3SEXN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEXI", m3SEXI.Trim())
				.WithQueryParameter("SEXS", m3SEXS.ToString(CultureInfo.CurrentCulture));

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
		/// Name LstInfo
		/// Description Get additional information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3JRNO">Journal number (Required)</param>
		/// <param name="m3JSNO">Journal sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SEXN">GL information number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInfoResponse></returns>
		/// <exception cref="M3Exception<LstInfoResponse>"></exception>
		public async Task<M3Response<LstInfoResponse>> LstInfo(
			int m3YEA4, 
			int m3JRNO, 
			int m3JSNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3SEXN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInfo",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JRNO", m3JRNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JSNO", m3JSNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3SEXN.HasValue)
				request.WithQueryParameter("SEXN", m3SEXN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstInfoResponse>(
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
		/// Name LstInfoPerAddNo
		/// Description List information per additional number
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SEXN">AR information category (Required)</param>
		/// <param name="m3SEXI">AR additional information (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SEXS">AR information sequence number</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3JRNO">Journal number</param>
		/// <param name="m3JSNO">Journal sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInfoPerAddNoResponse></returns>
		/// <exception cref="M3Exception<LstInfoPerAddNoResponse>"></exception>
		public async Task<M3Response<LstInfoPerAddNoResponse>> LstInfoPerAddNo(
			int m3SEXN, 
			string m3SEXI, 
			string m3DIVI = null, 
			int? m3SEXS = null, 
			int? m3YEA4 = null, 
			int? m3JRNO = null, 
			int? m3JSNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInfoPerAddNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SEXI))
				throw new ArgumentNullException(nameof(m3SEXI));

			// Set mandatory parameters
			request
				.WithQueryParameter("SEXN", m3SEXN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEXI", m3SEXI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3SEXS.HasValue)
				request.WithQueryParameter("SEXS", m3SEXS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JRNO.HasValue)
				request.WithQueryParameter("JRNO", m3JRNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JSNO.HasValue)
				request.WithQueryParameter("JSNO", m3JSNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstInfoPerAddNoResponse>(
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
		/// Name LstInvInfo
		/// Description Get additional information with invoice number
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CINO">Invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SEXN">GL information number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvInfoResponse></returns>
		/// <exception cref="M3Exception<LstInvInfoResponse>"></exception>
		public async Task<M3Response<LstInvInfoResponse>> LstInvInfo(
			string m3PYNO, 
			string m3CUNO, 
			string m3CINO, 
			int m3INYR, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3SEXN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3CINO))
				throw new ArgumentNullException(nameof(m3CINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("CINO", m3CINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3SEXN.HasValue)
				request.WithQueryParameter("SEXN", m3SEXN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstInvInfoResponse>(
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
