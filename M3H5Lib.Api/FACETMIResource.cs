/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.FACETMI;
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
	/// Name: FACETMI
	/// Component Name: Facets
	/// Description: Facets interface
	/// Version Release: 5e90
	///</summary>
	public partial class FACETMIResource : M3BaseResourceEndpoint
	{
		public FACETMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "FACETMI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstFacets
		/// Description List Facets
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FNAM">Table name (Required)</param>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="m3FLNA">Filtering of field name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFacetsResponse></returns>
		/// <exception cref="M3Exception<LstFacetsResponse>"></exception>
		public async Task<M3Response<LstFacetsResponse>> LstFacets(
			string m3FNAM, 
			string m3SQRY, 
			string m3FLNA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFacets",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FNAM))
				throw new ArgumentNullException(nameof(m3FNAM));
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("FNAM", m3FNAM.Trim())
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FLNA))
				request.WithQueryParameter("FLNA", m3FLNA.Trim());

			// Execute the request
			var result = await Execute<LstFacetsResponse>(
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
