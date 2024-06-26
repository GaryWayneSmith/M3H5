/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.BODCSSMI;
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
	/// Name: BODCSSMI
	/// Component Name: BusinessObjectDoc
	/// Description: Business Object Documents
	/// Version Release: 15.1
	///</summary>
	public partial class BODCSSMIResource : M3BaseResourceEndpoint
	{
		public BODCSSMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "BODCSSMI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstBillToParty
		/// Description Retrieve a list of customers with a specific payer
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBillToPartyResponse></returns>
		/// <exception cref="M3Exception<LstBillToPartyResponse>"></exception>
		public async Task<M3Response<LstBillToPartyResponse>> LstBillToParty(
			string m3PYNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBillToParty",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PYNO", m3PYNO.Trim());

			// Execute the request
			var result = await Execute<LstBillToPartyResponse>(
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
