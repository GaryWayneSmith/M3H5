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
	/// Name: SPS020MI
	/// Component Name: SupplyChainNode
	/// Description: Supply chain node interface
	/// Version Release: 12.1
	///</summary>
	public partial class SPS020MIResource : M3BaseResourceEndpoint
	{
		public SPS020MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SPS020MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SndCoordinates
		/// Description Update of Node Coordinates
		/// Version Release: 12.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_NDID">Node ID (Required)</param>
		/// <param name="m3_GEOX">Geo Code X (Required)</param>
		/// <param name="m3_GEOY">Geo Code Y (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_VCOX">Virtual Code X</param>
		/// <param name="m3_VCOY">Virtual Code Y</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndCoordinates(
			string m3_DIVI, 
			string m3_NDID, 
			decimal m3_GEOX, 
			decimal m3_GEOY, 
			int? m3_CONO = null, 
			decimal? m3_VCOX = null, 
			decimal? m3_VCOY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndCoordinates",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_NDID))
				throw new ArgumentNullException("m3_NDID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("NDID", m3_NDID.Trim())
				.WithQueryParameter("GEOX", m3_GEOX.ToString())
				.WithQueryParameter("GEOY", m3_GEOY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_VCOX.HasValue)
				request.WithQueryParameter("VCOX", m3_VCOX.Value.ToString());
			if (m3_VCOY.HasValue)
				request.WithQueryParameter("VCOY", m3_VCOY.Value.ToString());

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
