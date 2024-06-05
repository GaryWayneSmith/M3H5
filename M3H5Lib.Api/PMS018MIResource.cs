/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PMS018MI;
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
	/// Name: PMS018MI
	/// Component Name: Transfer Supplier Capacity
	/// Description: Api: Transfer Supplier Capacity and Capability
	/// Version Release: 13.1
	///</summary>
	public partial class PMS018MIResource : M3BaseResourceEndpoint
	{
		public PMS018MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS018MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SupplierCap
		/// Description Transfer Supplier Capacity
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SupplierCapResponse></returns>
		/// <exception cref="M3Exception<SupplierCapResponse>"></exception>
		public async Task<M3Response<SupplierCapResponse>> SupplierCap(
			string m3_SUNO, 
			int? m3_CONO = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
	}
}
// EOF
