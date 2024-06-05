/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.RPS120MI;
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
	/// Name: RPS120MI
	/// Component Name: Macro orders
	/// Description: Transfer Demand Order Type
	/// Version Release: 13.1
	///</summary>
	public partial class RPS120MIResource : M3BaseResourceEndpoint
	{
		public RPS120MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "RPS120MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetDEOType
		/// Description Get Demand Order Type
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FORT">Order type</param>
		/// <param name="m3TORT">Order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDEOTypeResponse></returns>
		/// <exception cref="M3Exception<GetDEOTypeResponse>"></exception>
		public async Task<M3Response<GetDEOTypeResponse>> GetDEOType(
			string m3FORT = null, 
			string m3TORT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDEOType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FORT))
				request.WithQueryParameter("FORT", m3FORT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TORT))
				request.WithQueryParameter("TORT", m3TORT.Trim());

			// Execute the request
			var result = await Execute<GetDEOTypeResponse>(
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
