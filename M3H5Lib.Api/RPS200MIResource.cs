/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
	/// Name: RPS200MI
	/// Component Name: Macro orders
	/// Description: Work with supplychain order
	/// Version Release: 14.x
	///</summary>
	public partial class RPS200MIResource : M3BaseResourceEndpoint
	{
		public RPS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "RPS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ReGenSupChain
		/// Description Generate Demand Order Statistics
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCNB">Supply chain number</param>
		/// <param name="m3SCFD">Supply chain finish date</param>
		/// <param name="m3SCFT">Supply chain finish time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReGenSupChain(
			string m3SCNB = null, 
			DateTime? m3SCFD = null, 
			int? m3SCFT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReGenSupChain",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SCNB))
				request.WithQueryParameter("SCNB", m3SCNB.Trim());
			if (m3SCFD.HasValue)
				request.WithQueryParameter("SCFD", m3SCFD.Value.ToM3String());
			if (m3SCFT.HasValue)
				request.WithQueryParameter("SCFT", m3SCFT.Value.ToString(CultureInfo.CurrentCulture));

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
