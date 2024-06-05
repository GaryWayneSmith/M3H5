/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MMS025MI;
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
	/// Name: MMS025MI
	/// Component Name: AliasNumbers
	/// Description: Alias numbers interface
	/// Version Release: 5ea0
	///</summary>
	public partial class MMS025MIResource : M3BaseResourceEndpoint
	{
		public MMS025MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS025MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAlias
		/// Description Add Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ALWT">Alias category (Required)</param>
		/// <param name="m3ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3POPN">Alias number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3VFDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="m3CFXX">Old CFIN</param>
		/// <param name="m3SEA1">Season</param>
		/// <param name="m3ATPE">Alias type</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3PRNA">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAlias(
			int m3ALWT, 
			string m3ALWQ, 
			string m3ITNO, 
			string m3POPN, 
			int? m3CONO = null, 
			string m3E0PA = null, 
			DateTime? m3VFDT = null, 
			DateTime? m3LVDT = null, 
			decimal? m3CNQT = null, 
			string m3ALUN = null, 
			string m3ORCO = null, 
			int? m3SEQN = null, 
			string m3REMK = null, 
			int? m3CFXX = null, 
			string m3SEA1 = null, 
			string m3ATPE = null, 
			decimal? m3ATNR = null, 
			long? m3CFIN = null, 
			string m3PRNA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAlias",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ALWQ))
				throw new ArgumentNullException(nameof(m3ALWQ));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3POPN))
				throw new ArgumentNullException(nameof(m3POPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ALWT", m3ALWT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALWQ", m3ALWQ.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("POPN", m3POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (m3VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3VFDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3CNQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());
			if (m3CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3CFXX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SEA1))
				request.WithQueryParameter("SEA1", m3SEA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATPE))
				request.WithQueryParameter("ATPE", m3ATPE.Trim());
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNA))
				request.WithQueryParameter("PRNA", m3PRNA.Trim());

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
		/// Name DltAlias
		/// Description Delete Alias
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ALWT">Alias category (Required)</param>
		/// <param name="m3ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3POPN">Alias number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3SEA1">Season</param>
		/// <param name="m3VFDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAlias(
			int m3ALWT, 
			string m3ALWQ, 
			string m3ITNO, 
			string m3POPN, 
			int? m3CONO = null, 
			string m3E0PA = null, 
			string m3SEA1 = null, 
			DateTime? m3VFDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltAlias",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ALWQ))
				throw new ArgumentNullException(nameof(m3ALWQ));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3POPN))
				throw new ArgumentNullException(nameof(m3POPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ALWT", m3ALWT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALWQ", m3ALWQ.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("POPN", m3POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEA1))
				request.WithQueryParameter("SEA1", m3SEA1.Trim());
			if (m3VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3VFDT.Value.ToM3String());

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
		/// Name GetAlias
		/// Description Get Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ALWT">Alias category (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3VFDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAliasResponse></returns>
		/// <exception cref="M3Exception<GetAliasResponse>"></exception>
		public async Task<M3Response<GetAliasResponse>> GetAlias(
			int m3ALWT, 
			string m3ITNO, 
			string m3ALWQ, 
			int? m3CONO = null, 
			string m3E0PA = null, 
			DateTime? m3VFDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAlias",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3ALWQ))
				throw new ArgumentNullException(nameof(m3ALWQ));

			// Set mandatory parameters
			request
				.WithQueryParameter("ALWT", m3ALWT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ALWQ", m3ALWQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (m3VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3VFDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetAliasResponse>(
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
		/// Name GetItem
		/// Description Get Item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ALWT">Alias category (Required)</param>
		/// <param name="m3POPN">Alias number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3SEA1">Season</param>
		/// <param name="m3VFDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemResponse></returns>
		/// <exception cref="M3Exception<GetItemResponse>"></exception>
		public async Task<M3Response<GetItemResponse>> GetItem(
			int m3ALWT, 
			string m3POPN, 
			int? m3CONO = null, 
			string m3ALWQ = null, 
			string m3E0PA = null, 
			string m3SEA1 = null, 
			DateTime? m3VFDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3POPN))
				throw new ArgumentNullException(nameof(m3POPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ALWT", m3ALWT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POPN", m3POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEA1))
				request.WithQueryParameter("SEA1", m3SEA1.Trim());
			if (m3VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3VFDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetItemResponse>(
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
		/// Name LstAlias
		/// Description List Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAliasResponse></returns>
		/// <exception cref="M3Exception<LstAliasResponse>"></exception>
		public async Task<M3Response<LstAliasResponse>> LstAlias(
			string m3ITNO, 
			int? m3CONO = null, 
			int? m3ALWT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAlias",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAliasResponse>(
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
		/// Name LstAliasViaCat
		/// Description List Alias Via Category
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ALWT">Alias category (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAliasViaCatResponse></returns>
		/// <exception cref="M3Exception<LstAliasViaCatResponse>"></exception>
		public async Task<M3Response<LstAliasViaCatResponse>> LstAliasViaCat(
			int m3ALWT, 
			int? m3CONO = null, 
			string m3ALWQ = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAliasViaCat",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ALWT", m3ALWT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAliasViaCatResponse>(
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
		/// Name LstItem
		/// Description List Items
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3POPN">Alias number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemResponse></returns>
		/// <exception cref="M3Exception<LstItemResponse>"></exception>
		public async Task<M3Response<LstItemResponse>> LstItem(
			string m3POPN, 
			int? m3CONO = null, 
			int? m3ALWT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3POPN))
				throw new ArgumentNullException(nameof(m3POPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("POPN", m3POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstItemResponse>(
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
