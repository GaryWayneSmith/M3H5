/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CRS200MI;
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
	/// Name: CRS200MI
	/// Component Name: Wrk: GST Order Types
	/// Description: GST Order Types
	/// Version Release: 13.1
	///</summary>
	public partial class CRS200MIResource : M3BaseResourceEndpoint
	{
		public CRS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS200MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstOrderType
		/// Description Lists GST Order Types
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3TRTP">Order type</param>
		/// <param name="m3TTYP">Stock transaction type</param>
		/// <param name="m3FSQ3">Next manual function</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOrderTypeResponse></returns>
		/// <exception cref="M3Exception<LstOrderTypeResponse>"></exception>
		public async Task<M3Response<LstOrderTypeResponse>> LstOrderType(
			string m3TRTP = null, 
			int? m3TTYP = null, 
			string m3FSQ3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOrderType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TRTP))
				request.WithQueryParameter("TRTP", m3TRTP.Trim());
			if (m3TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3TTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FSQ3))
				request.WithQueryParameter("FSQ3", m3FSQ3.Trim());

			// Execute the request
			var result = await Execute<LstOrderTypeResponse>(
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
