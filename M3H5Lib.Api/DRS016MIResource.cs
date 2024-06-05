/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.DRS016MI;
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
	/// Name: DRS016MI
	/// Component Name: LoadingPlatform
	/// Description: Loading platform Interface
	/// Version Release: 5ea0
	///</summary>
	public partial class DRS016MIResource : M3BaseResourceEndpoint
	{
		public DRS016MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "DRS016MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstLoadPlat
		/// Description List loading platforms
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3SDES">Place of loading</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLoadPlatResponse></returns>
		/// <exception cref="M3Exception<LstLoadPlatResponse>"></exception>
		public async Task<M3Response<LstLoadPlatResponse>> LstLoadPlat(
			string m3WHLO = null, 
			string m3LODO = null, 
			string m3SDES = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLoadPlat",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDES))
				request.WithQueryParameter("SDES", m3SDES.Trim());

			// Execute the request
			var result = await Execute<LstLoadPlatResponse>(
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
