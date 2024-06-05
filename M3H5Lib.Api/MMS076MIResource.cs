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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 11.2
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STYN">Style number</param>
		/// <param name="m3SEA1">Not used</param>
		/// <param name="m3SEAX">Season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			int? m3CONO = null, 
			string m3STYN = null, 
			string m3SEA1 = null, 
			string m3SEAX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STYN))
				request.WithQueryParameter("STYN", m3STYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEA1))
				request.WithQueryParameter("SEA1", m3SEA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEAX))
				request.WithQueryParameter("SEAX", m3SEAX.Trim());

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
