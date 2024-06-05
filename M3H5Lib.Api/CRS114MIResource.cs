/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS114MI;
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
	/// Name: CRS114MI
	/// Component Name: Salesperson
	/// Description: Order Line Salespersons Interface
	/// Version Release: 14.x
	///</summary>
	public partial class CRS114MIResource : M3BaseResourceEndpoint
	{
		public CRS114MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS114MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Create new sales persons
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_SMCD">Salesperson (Required)</param>
		/// <param name="m3_ORCA">Order category (Required)</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CAMO">Commission amount</param>
		/// <param name="m3_COPE">Commission percentage</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_RIDN, 
			int m3_RIDL, 
			string m3_SMCD, 
			string m3_ORCA, 
			int? m3_RIDX = null, 
			int? m3_VERS = null, 
			string m3_CUCD = null, 
			decimal? m3_CAMO = null, 
			int? m3_COPE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_SMCD))
				throw new ArgumentNullException("m3_SMCD");
			if (string.IsNullOrWhiteSpace(m3_ORCA))
				throw new ArgumentNullException("m3_ORCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("SMCD", m3_SMCD.Trim())
				.WithQueryParameter("ORCA", m3_ORCA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_CAMO.HasValue)
				request.WithQueryParameter("CAMO", m3_CAMO.Value.ToString());
			if (m3_COPE.HasValue)
				request.WithQueryParameter("COPE", m3_COPE.Value.ToString());

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
		/// Name Delete
		/// Description Delete sales persons
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_ORCA">Order category (Required)</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_RIDN, 
			int m3_RIDL, 
			string m3_ORCA, 
			int? m3_RIDX = null, 
			int? m3_VERS = null, 
			string m3_SMCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_ORCA))
				throw new ArgumentNullException("m3_ORCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("ORCA", m3_ORCA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());

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
		/// Name List
		/// Description List salespersons
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_ORCA">Order category (Required)</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_RIDN, 
			int m3_RIDL, 
			string m3_ORCA, 
			int? m3_RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_ORCA))
				throw new ArgumentNullException("m3_ORCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("ORCA", m3_ORCA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());

			// Execute the request
			var result = await Execute<ListResponse>(
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
