/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.STS465MI;
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
	/// Name: STS465MI
	/// Component Name: Rental
	/// Description: API: Rental Alias number
	/// Version Release: 5ea0
	///</summary>
	public partial class STS465MIResource : M3BaseResourceEndpoint
	{
		public STS465MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS465MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAlias
		/// Description Add alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M (Required)</param>
		/// <param name="m3_LTYP">Line type (Required)</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_INCQ">Include quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAlias(
			string m3_POPN, 
			string m3_ITNO, 
			decimal m3_ORQT, 
			string m3_LTYP, 
			int? m3_SEQN = null, 
			int? m3_INCQ = null, 
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
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_LTYP))
				throw new ArgumentNullException("m3_LTYP");

			// Set mandatory parameters
			request
				.WithQueryParameter("POPN", m3_POPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ORQT", m3_ORQT.ToString())
				.WithQueryParameter("LTYP", m3_LTYP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (m3_INCQ.HasValue)
				request.WithQueryParameter("INCQ", m3_INCQ.Value.ToString());

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
		/// Description Dlt alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAlias(
			string m3_POPN, 
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAlias",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("POPN", m3_POPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

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
		/// Name GetAlias
		/// Description GetAlias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAliasResponse></returns>
		/// <exception cref="M3Exception<GetAliasResponse>"></exception>
		public async Task<M3Response<GetAliasResponse>> GetAlias(
			string m3_POPN, 
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAlias",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("POPN", m3_POPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

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
		/// Name LstAlias
		/// Description List alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAliasResponse></returns>
		/// <exception cref="M3Exception<LstAliasResponse>"></exception>
		public async Task<M3Response<LstAliasResponse>> LstAlias(
			string m3_POPN = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());

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
		/// Name UpdAlias
		/// Description Update alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_LTYP">Line type</param>
		/// <param name="m3_INCQ">Include quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAlias(
			string m3_POPN, 
			string m3_ITNO, 
			int? m3_SEQN = null, 
			decimal? m3_ORQT = null, 
			string m3_LTYP = null, 
			int? m3_INCQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAlias",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("POPN", m3_POPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LTYP))
				request.WithQueryParameter("LTYP", m3_LTYP.Trim());
			if (m3_INCQ.HasValue)
				request.WithQueryParameter("INCQ", m3_INCQ.Value.ToString());

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
