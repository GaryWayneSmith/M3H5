/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
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
	/// Name: MMS076MI
	/// Component Name: StyleCreateItem
	/// Description: Style. Create item interface
	/// Version Release: 11.0
	///</summary>
	public partial class MMS076MIResource : M3BaseResourceEndpoint
	{
		public MMS076MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS076MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 11.2
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STYN">Style number</param>
		/// <param name="m3_SEA1">Not used</param>
		/// <param name="m3_SEAX">Season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			int? m3_CONO = null, 
			string m3_STYN = null, 
			string m3_SEA1 = null, 
			string m3_SEAX = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STYN))
				request.WithQueryParameter("STYN", m3_STYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEA1))
				request.WithQueryParameter("SEA1", m3_SEA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEAX))
				request.WithQueryParameter("SEAX", m3_SEAX.Trim());

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
