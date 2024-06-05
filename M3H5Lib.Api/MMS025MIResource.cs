/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAlias
		/// Description Add Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_VFDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_CFXX">Old CFIN</param>
		/// <param name="m3_SEA1">Season</param>
		/// <param name="m3_ATPE">Alias type</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_PRNA">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAlias(
			int m3_ALWT, 
			string m3_ALWQ, 
			string m3_ITNO, 
			string m3_POPN, 
			int? m3_CONO = null, 
			string m3_E0PA = null, 
			DateTime? m3_VFDT = null, 
			DateTime? m3_LVDT = null, 
			decimal? m3_CNQT = null, 
			string m3_ALUN = null, 
			string m3_ORCO = null, 
			int? m3_SEQN = null, 
			string m3_REMK = null, 
			int? m3_CFXX = null, 
			string m3_SEA1 = null, 
			string m3_ATPE = null, 
			decimal? m3_ATNR = null, 
			long? m3_CFIN = null, 
			string m3_PRNA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAlias",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ALWQ))
				throw new ArgumentNullException("m3_ALWQ");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ALWT", m3_ALWT.ToString())
				.WithQueryParameter("ALWQ", m3_ALWQ.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (m3_VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3_VFDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (m3_CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3_CFXX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SEA1))
				request.WithQueryParameter("SEA1", m3_SEA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATPE))
				request.WithQueryParameter("ATPE", m3_ATPE.Trim());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNA))
				request.WithQueryParameter("PRNA", m3_PRNA.Trim());

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
		/// Name DltAlias
		/// Description Delete Alias
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_SEA1">Season</param>
		/// <param name="m3_VFDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAlias(
			int m3_ALWT, 
			string m3_ALWQ, 
			string m3_ITNO, 
			string m3_POPN, 
			int? m3_CONO = null, 
			string m3_E0PA = null, 
			string m3_SEA1 = null, 
			DateTime? m3_VFDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAlias",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ALWQ))
				throw new ArgumentNullException("m3_ALWQ");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ALWT", m3_ALWT.ToString())
				.WithQueryParameter("ALWQ", m3_ALWQ.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEA1))
				request.WithQueryParameter("SEA1", m3_SEA1.Trim());
			if (m3_VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3_VFDT.Value.ToM3String());

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
		/// Name GetAlias
		/// Description Get Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_VFDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAliasResponse></returns>
		/// <exception cref="M3Exception<GetAliasResponse>"></exception>
		public async Task<M3Response<GetAliasResponse>> GetAlias(
			int m3_ALWT, 
			string m3_ITNO, 
			string m3_ALWQ, 
			int? m3_CONO = null, 
			string m3_E0PA = null, 
			DateTime? m3_VFDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAlias",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_ALWQ))
				throw new ArgumentNullException("m3_ALWQ");

			// Set mandatory parameters
			request
				.WithQueryParameter("ALWT", m3_ALWT.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ALWQ", m3_ALWQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (m3_VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3_VFDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetAliasResponse>(
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
		/// Name GetItem
		/// Description Get Item
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_SEA1">Season</param>
		/// <param name="m3_VFDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemResponse></returns>
		/// <exception cref="M3Exception<GetItemResponse>"></exception>
		public async Task<M3Response<GetItemResponse>> GetItem(
			int m3_ALWT, 
			string m3_POPN, 
			int? m3_CONO = null, 
			string m3_ALWQ = null, 
			string m3_E0PA = null, 
			string m3_SEA1 = null, 
			DateTime? m3_VFDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ALWT", m3_ALWT.ToString())
				.WithQueryParameter("POPN", m3_POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEA1))
				request.WithQueryParameter("SEA1", m3_SEA1.Trim());
			if (m3_VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3_VFDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetItemResponse>(
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
		/// Name LstAlias
		/// Description List Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAliasResponse></returns>
		/// <exception cref="M3Exception<LstAliasResponse>"></exception>
		public async Task<M3Response<LstAliasResponse>> LstAlias(
			string m3_ITNO, 
			int? m3_CONO = null, 
			int? m3_ALWT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAlias",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());

			// Execute the request
			var result = await Execute<LstAliasResponse>(
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
		/// Name LstAliasViaCat
		/// Description List Alias Via Category
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAliasViaCatResponse></returns>
		/// <exception cref="M3Exception<LstAliasViaCatResponse>"></exception>
		public async Task<M3Response<LstAliasViaCatResponse>> LstAliasViaCat(
			int m3_ALWT, 
			int? m3_CONO = null, 
			string m3_ALWQ = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAliasViaCat",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ALWT", m3_ALWT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstAliasViaCatResponse>(
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
		/// Name LstItem
		/// Description List Items
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemResponse></returns>
		/// <exception cref="M3Exception<LstItemResponse>"></exception>
		public async Task<M3Response<LstItemResponse>> LstItem(
			string m3_POPN, 
			int? m3_CONO = null, 
			int? m3_ALWT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("POPN", m3_POPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());

			// Execute the request
			var result = await Execute<LstItemResponse>(
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
