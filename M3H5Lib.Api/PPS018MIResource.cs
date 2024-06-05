/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS018MI;
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
	/// Name: PPS018MI
	/// Component Name: Transfer Supplier Capacity
	/// Description: Api: Supplier Capacity and Capability
	/// Version Release: 13.1
	///</summary>
	public partial class PPS018MIResource : M3BaseResourceEndpoint
	{
		public PPS018MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS018MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSupplierCap
		/// Description Add Supplier Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_SCPG">SCP item group (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_TDAT">To date (Required)</param>
		/// <param name="m3_AGLE">Aggregation level</param>
		/// <param name="m3_SUCA">Delivery capacity</param>
		/// <param name="m3_CACH">Consider capacity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSupplierCap(
			string m3_SUNO, 
			string m3_SCPG, 
			DateTime m3_FDAT, 
			DateTime m3_TDAT, 
			int? m3_AGLE = null, 
			decimal? m3_SUCA = null, 
			int? m3_CACH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSupplierCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SCPG))
				throw new ArgumentNullException("m3_SCPG");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SCPG", m3_SCPG.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("TDAT", m3_TDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_AGLE.HasValue)
				request.WithQueryParameter("AGLE", m3_AGLE.Value.ToString());
			if (m3_SUCA.HasValue)
				request.WithQueryParameter("SUCA", m3_SUCA.Value.ToString());
			if (m3_CACH.HasValue)
				request.WithQueryParameter("CACH", m3_CACH.Value.ToString());

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
		/// Name SupplierCap
		/// Description Transfer Supplier Capacity
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_AGLE">Aggregation level</param>
		/// <param name="m3_SCPG">SCP item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SupplierCapResponse></returns>
		/// <exception cref="M3Exception<SupplierCapResponse>"></exception>
		public async Task<M3Response<SupplierCapResponse>> SupplierCap(
			string m3_SUNO, 
			int? m3_AGLE = null, 
			string m3_SCPG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SupplierCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_AGLE.HasValue)
				request.WithQueryParameter("AGLE", m3_AGLE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCPG))
				request.WithQueryParameter("SCPG", m3_SCPG.Trim());

			// Execute the request
			var result = await Execute<SupplierCapResponse>(
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
		/// Name UpdSupplierCap
		/// Description Updates Supplier Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_SCPG">SCP item group (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_AGLE">Aggregation level</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_SUCA">Delivery capacity</param>
		/// <param name="m3_CACH">Consider capacity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSupplierCap(
			string m3_SUNO, 
			string m3_SCPG, 
			DateTime m3_FDAT, 
			int? m3_AGLE = null, 
			DateTime? m3_TDAT = null, 
			decimal? m3_SUCA = null, 
			int? m3_CACH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSupplierCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SCPG))
				throw new ArgumentNullException("m3_SCPG");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SCPG", m3_SCPG.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_AGLE.HasValue)
				request.WithQueryParameter("AGLE", m3_AGLE.Value.ToString());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_SUCA.HasValue)
				request.WithQueryParameter("SUCA", m3_SUCA.Value.ToString());
			if (m3_CACH.HasValue)
				request.WithQueryParameter("CACH", m3_CACH.Value.ToString());

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
