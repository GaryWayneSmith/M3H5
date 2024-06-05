/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.TXS040MI;
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
	/// Name: TXS040MI
	/// Component Name: VATRegNo
	/// Description: Api: Retreive name from VAT reg no
	/// Version Release: 5e90
	///</summary>
	public partial class TXS040MIResource : M3BaseResourceEndpoint
	{
		public TXS040MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "TXS040MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetVATRegNoInfo
		/// Description Get VAT Registration number information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3CVOP">Customer/supplier code (Required)</param>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3VRNO">VAT registration number (Required)</param>
		/// <param name="m3CUSP">Customer/supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetVATRegNoInfoResponse></returns>
		/// <exception cref="M3Exception<GetVATRegNoInfoResponse>"></exception>
		public async Task<M3Response<GetVATRegNoInfoResponse>> GetVATRegNoInfo(
			int m3CONO, 
			int m3CVOP, 
			string m3CSCD, 
			string m3VRNO, 
			string m3CUSP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetVATRegNoInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));
			if (string.IsNullOrWhiteSpace(m3VRNO))
				throw new ArgumentNullException(nameof(m3VRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CVOP", m3CVOP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CSCD", m3CSCD.Trim())
				.WithQueryParameter("VRNO", m3VRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUSP))
				request.WithQueryParameter("CUSP", m3CUSP.Trim());

			// Execute the request
			var result = await Execute<GetVATRegNoInfoResponse>(
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
