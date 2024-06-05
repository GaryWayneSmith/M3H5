/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSupplierCap
		/// Description Add Supplier Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3SCPG">SCP item group (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3TDAT">To date (Required)</param>
		/// <param name="m3AGLE">Aggregation level</param>
		/// <param name="m3SUCA">Delivery capacity</param>
		/// <param name="m3CACH">Consider capacity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSupplierCap(
			string m3SUNO, 
			string m3SCPG, 
			DateTime m3FDAT, 
			DateTime m3TDAT, 
			int? m3AGLE = null, 
			decimal? m3SUCA = null, 
			int? m3CACH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSupplierCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SCPG))
				throw new ArgumentNullException(nameof(m3SCPG));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SCPG", m3SCPG.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("TDAT", m3TDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3AGLE.HasValue)
				request.WithQueryParameter("AGLE", m3AGLE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUCA.HasValue)
				request.WithQueryParameter("SUCA", m3SUCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CACH.HasValue)
				request.WithQueryParameter("CACH", m3CACH.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SupplierCap
		/// Description Transfer Supplier Capacity
		/// Version Release: 
		/// </summary>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3AGLE">Aggregation level</param>
		/// <param name="m3SCPG">SCP item group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SupplierCapResponse></returns>
		/// <exception cref="M3Exception<SupplierCapResponse>"></exception>
		public async Task<M3Response<SupplierCapResponse>> SupplierCap(
			string m3SUNO, 
			int? m3AGLE = null, 
			string m3SCPG = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SupplierCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3AGLE.HasValue)
				request.WithQueryParameter("AGLE", m3AGLE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCPG))
				request.WithQueryParameter("SCPG", m3SCPG.Trim());

			// Execute the request
			var result = await Execute<SupplierCapResponse>(
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
		/// Name UpdSupplierCap
		/// Description Updates Supplier Capacity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3SCPG">SCP item group (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3AGLE">Aggregation level</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3SUCA">Delivery capacity</param>
		/// <param name="m3CACH">Consider capacity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSupplierCap(
			string m3SUNO, 
			string m3SCPG, 
			DateTime m3FDAT, 
			int? m3AGLE = null, 
			DateTime? m3TDAT = null, 
			decimal? m3SUCA = null, 
			int? m3CACH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdSupplierCap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SCPG))
				throw new ArgumentNullException(nameof(m3SCPG));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SCPG", m3SCPG.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3AGLE.HasValue)
				request.WithQueryParameter("AGLE", m3AGLE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3SUCA.HasValue)
				request.WithQueryParameter("SUCA", m3SUCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CACH.HasValue)
				request.WithQueryParameter("CACH", m3CACH.Value.ToString(CultureInfo.CurrentCulture));

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
