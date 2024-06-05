/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.STS109MI;
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
	/// Name: STS109MI
	/// Component Name: STRAgreements
	/// Description: API: STR Agreement - Create
	/// Version Release: 12.5
	///</summary>
	public partial class STS109MIResource : M3BaseResourceEndpoint
	{
		public STS109MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS109MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CrtRentalAgrmnt
		/// Description Create Rental Agreement
		/// Version Release: 12
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3CRCD">Create agreement (Required)</param>
		/// <param name="m3ARCC">Reason code - created agreement (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRQA">Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CrtRentalAgrmntResponse></returns>
		/// <exception cref="M3Exception<CrtRentalAgrmntResponse>"></exception>
		public async Task<M3Response<CrtRentalAgrmntResponse>> CrtRentalAgrmnt(
			string m3AGNB, 
			int m3VERS, 
			int m3CRCD, 
			string m3ARCC, 
			int? m3CONO = null, 
			int? m3PRQA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtRentalAgrmnt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3ARCC))
				throw new ArgumentNullException(nameof(m3ARCC));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CRCD", m3CRCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ARCC", m3ARCC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRQA.HasValue)
				request.WithQueryParameter("PRQA", m3PRQA.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<CrtRentalAgrmntResponse>(
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
