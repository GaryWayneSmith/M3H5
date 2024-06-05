/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.STS110MI;
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
	/// Name: STS110MI
	/// Component Name: STRAgreements
	/// Description: API: STR Agreement - Deposit
	/// Version Release: 14.x
	///</summary>
	public partial class STS110MIResource : M3BaseResourceEndpoint
	{
		public STS110MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS110MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDeposit
		/// Description Add rental deposit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_DEPA">Deposit Amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDeposit(
			string m3_AGNB, 
			int m3_VERS, 
			int? m3_SEQN = null, 
			string m3_PYNO = null, 
			decimal? m3_DEPA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDeposit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_DEPA.HasValue)
				request.WithQueryParameter("DEPA", m3_DEPA.Value.ToString());

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
		/// Name ChgDeposit
		/// Description Change deposit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_DEPA">Deposit Amount</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgDeposit(
			string m3_AGNB, 
			int m3_SEQN, 
			string m3_PYNO = null, 
			decimal? m3_DEPA = null, 
			int? m3_VERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgDeposit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_DEPA.HasValue)
				request.WithQueryParameter("DEPA", m3_DEPA.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());

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
		/// Name DelDeposit
		/// Description Delete Deposit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDeposit(
			string m3_AGNB, 
			int m3_SEQN, 
			int? m3_VERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelDeposit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());

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
		/// Name GetDeposit
		/// Description Get deposit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDepositResponse></returns>
		/// <exception cref="M3Exception<GetDepositResponse>"></exception>
		public async Task<M3Response<GetDepositResponse>> GetDeposit(
			string m3_AGNB = null, 
			int? m3_SEQN = null, 
			int? m3_VERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDeposit",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());

			// Execute the request
			var result = await Execute<GetDepositResponse>(
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
		/// Name LstDeposit
		/// Description List deposit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDepositResponse></returns>
		/// <exception cref="M3Exception<LstDepositResponse>"></exception>
		public async Task<M3Response<LstDepositResponse>> LstDeposit(
			string m3_AGNB = null, 
			int? m3_SEQN = null, 
			int? m3_VERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDeposit",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());

			// Execute the request
			var result = await Execute<LstDepositResponse>(
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
