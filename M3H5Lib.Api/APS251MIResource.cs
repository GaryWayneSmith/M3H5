/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.APS251MI;
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
	/// Name: APS251MI
	/// Component Name: AccountsPayableInformation
	/// Description: Accounts payable information interface
	/// Version Release: 5ea0
	///</summary>
	public partial class APS251MIResource : M3BaseResourceEndpoint
	{
		public APS251MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APS251MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddInfoCat
		/// Description Add AP Information category.
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3JRNO">Journal number (Required)</param>
		/// <param name="m3JSNO">Journal sequence number (Required)</param>
		/// <param name="m3PEXN">AP information category (Required)</param>
		/// <param name="m3PEXI">AP additional information (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PEXS">AP information sequence number</param>
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
			int m3PEXN, 
			string m3PEXI, 
			string m3DIVI = null, 
			int? m3PEXS = null, 
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
			if (string.IsNullOrWhiteSpace(m3PEXI))
				throw new ArgumentNullException(nameof(m3PEXI));

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JRNO", m3JRNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JSNO", m3JSNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PEXN", m3PEXN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PEXI", m3PEXI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3PEXS.HasValue)
				request.WithQueryParameter("PEXS", m3PEXS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Delete AP Information category.
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3JRNO">Journal number (Required)</param>
		/// <param name="m3JSNO">Journal sequence number (Required)</param>
		/// <param name="m3PEXN">AP information category (Required)</param>
		/// <param name="m3PEXI">AP additional information (Required)</param>
		/// <param name="m3PEXS">AP information sequence number (Required)</param>
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
			int m3PEXN, 
			string m3PEXI, 
			int m3PEXS, 
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
			if (string.IsNullOrWhiteSpace(m3PEXI))
				throw new ArgumentNullException(nameof(m3PEXI));

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JRNO", m3JRNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JSNO", m3JSNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PEXN", m3PEXN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PEXI", m3PEXI.Trim())
				.WithQueryParameter("PEXS", m3PEXS.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetInfo
		/// Description Get additional information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3JRNO">Journal number (Required)</param>
		/// <param name="m3JSNO">Journal sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PEXN">AP information category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInfoResponse></returns>
		/// <exception cref="M3Exception<GetInfoResponse>"></exception>
		public async Task<M3Response<GetInfoResponse>> GetInfo(
			int m3YEA4, 
			int m3JRNO, 
			int m3JSNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3PEXN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetInfo",
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
			if (m3PEXN.HasValue)
				request.WithQueryParameter("PEXN", m3PEXN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetInfoResponse>(
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
		/// Name GetInvInfo
		/// Description Get additional information with invoice number
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PEXN">AP information category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvInfoResponse></returns>
		/// <exception cref="M3Exception<GetInvInfoResponse>"></exception>
		public async Task<M3Response<GetInvInfoResponse>> GetInvInfo(
			string m3SPYN, 
			string m3SUNO, 
			string m3SINO, 
			int m3INYR, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3PEXN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetInvInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3PEXN.HasValue)
				request.WithQueryParameter("PEXN", m3PEXN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetInvInfoResponse>(
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
		/// <param name="m3PEXN">AP information category</param>
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
			int? m3PEXN = null, 
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
			if (m3PEXN.HasValue)
				request.WithQueryParameter("PEXN", m3PEXN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name LstInvInfo
		/// Description Get additional information with invoice number
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SPYN">Payee (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SINO">Supplier invoice number (Required)</param>
		/// <param name="m3INYR">Invoice year (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PEXN">AP information category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvInfoResponse></returns>
		/// <exception cref="M3Exception<LstInvInfoResponse>"></exception>
		public async Task<M3Response<LstInvInfoResponse>> LstInvInfo(
			string m3SPYN, 
			string m3SUNO, 
			string m3SINO, 
			int m3INYR, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3PEXN = null, 
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
			if (string.IsNullOrWhiteSpace(m3SPYN))
				throw new ArgumentNullException(nameof(m3SPYN));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SINO))
				throw new ArgumentNullException(nameof(m3SINO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPYN", m3SPYN.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SINO", m3SINO.Trim())
				.WithQueryParameter("INYR", m3INYR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3PEXN.HasValue)
				request.WithQueryParameter("PEXN", m3PEXN.Value.ToString(CultureInfo.CurrentCulture));

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
