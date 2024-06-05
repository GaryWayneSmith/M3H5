/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SndCoordinates
		/// Description Update of Node Coordinates
		/// Version Release: 12.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3NDID">Node ID (Required)</param>
		/// <param name="m3GEOX">Geo Code X (Required)</param>
		/// <param name="m3GEOY">Geo Code Y (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3VCOX">Virtual Code X</param>
		/// <param name="m3VCOY">Virtual Code Y</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndCoordinates(
			string m3DIVI, 
			string m3NDID, 
			decimal m3GEOX, 
			decimal m3GEOY, 
			int? m3CONO = null, 
			decimal? m3VCOX = null, 
			decimal? m3VCOY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndCoordinates",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3NDID))
				throw new ArgumentNullException(nameof(m3NDID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("NDID", m3NDID.Trim())
				.WithQueryParameter("GEOX", m3GEOX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("GEOY", m3GEOY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VCOX.HasValue)
				request.WithQueryParameter("VCOX", m3VCOX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VCOY.HasValue)
				request.WithQueryParameter("VCOY", m3VCOY.Value.ToString(CultureInfo.CurrentCulture));

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
