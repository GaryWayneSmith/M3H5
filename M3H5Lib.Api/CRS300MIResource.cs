/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CRS300MI;
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
	/// Name: CRS300MI
	/// Component Name: Ship-via address
	/// Description: Api: Ship-via address
	/// Version Release: 5e90
	///</summary>
	public partial class CRS300MIResource : M3BaseResourceEndpoint
	{
		public CRS300MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS300MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetShipVia
		/// Description Get ship-via address
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3ADVI">Ship-via address (Required)</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetShipViaResponse></returns>
		/// <exception cref="M3Exception<GetShipViaResponse>"></exception>
		public async Task<M3Response<GetShipViaResponse>> GetShipVia(
			string m3ADVI, 
			DateTime? m3STDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetShipVia",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ADVI))
				throw new ArgumentNullException(nameof(m3ADVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("ADVI", m3ADVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetShipViaResponse>(
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
		/// Name LstShipVia
		/// Description List ship-via address
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3ADVI">Ship-via address</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstShipViaResponse></returns>
		/// <exception cref="M3Exception<LstShipViaResponse>"></exception>
		public async Task<M3Response<LstShipViaResponse>> LstShipVia(
			string m3ADVI = null, 
			DateTime? m3STDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstShipVia",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADVI))
				request.WithQueryParameter("ADVI", m3ADVI.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstShipViaResponse>(
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
