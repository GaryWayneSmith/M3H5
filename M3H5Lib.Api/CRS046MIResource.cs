/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CRS046MI;
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
	/// Name: CRS046MI
	/// Component Name: StateAreaCode
	/// Description: State / Area code interface
	/// Version Release: 13
	///</summary>
	public partial class CRS046MIResource : M3BaseResourceEndpoint
	{
		public CRS046MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS046MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstAreaCodes
		/// Description List Area and State codes
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAreaCodesResponse></returns>
		/// <exception cref="M3Exception<LstAreaCodesResponse>"></exception>
		public async Task<M3Response<LstAreaCodesResponse>> LstAreaCodes(
			string m3CSCD, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAreaCodes",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CSCD", m3CSCD.Trim());

			// Execute the request
			var result = await Execute<LstAreaCodesResponse>(
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
