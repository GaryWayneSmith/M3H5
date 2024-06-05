/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CRS399MI;
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
	/// Name: CRS399MI
	/// Component Name: Simulate Accounting String
	/// Description: Api: Simulate Accounting String
	/// Version Release: 5e90
	///</summary>
	public partial class CRS399MIResource : M3BaseResourceEndpoint
	{
		public CRS399MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS399MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetCA60910
		/// Description Gets the inventory account event CA60 and type 910
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCA60910Response></returns>
		/// <exception cref="M3Exception<GetCA60910Response>"></exception>
		public async Task<M3Response<GetCA60910Response>> GetCA60910(
			string m3ITNO, 
			DateTime? m3FDAT = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCA60910",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<GetCA60910Response>(
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
