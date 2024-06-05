/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetVATRegNoInfo
		/// Description Get VAT Registration number information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_CVOP">Customer/supplier code (Required)</param>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_VRNO">VAT registration number (Required)</param>
		/// <param name="m3_CUSP">Customer/supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetVATRegNoInfoResponse></returns>
		/// <exception cref="M3Exception<GetVATRegNoInfoResponse>"></exception>
		public async Task<M3Response<GetVATRegNoInfoResponse>> GetVATRegNoInfo(
			int m3_CONO, 
			int m3_CVOP, 
			string m3_CSCD, 
			string m3_VRNO, 
			string m3_CUSP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetVATRegNoInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_VRNO))
				throw new ArgumentNullException("m3_VRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("CVOP", m3_CVOP.ToString())
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("VRNO", m3_VRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUSP))
				request.WithQueryParameter("CUSP", m3_CUSP.Trim());

			// Execute the request
			var result = await Execute<GetVATRegNoInfoResponse>(
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
