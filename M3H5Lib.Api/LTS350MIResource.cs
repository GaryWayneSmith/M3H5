/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.LTS350MI;
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
	/// Name: LTS350MI
	/// Component Name: LongTermRentalInvoice
	/// Description: Long Term Rental invoice interface
	/// Version Release: 13.1
	///</summary>
	public partial class LTS350MIResource : M3BaseResourceEndpoint
	{
		public LTS350MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "LTS350MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetInvHead
		/// Description Retrieve Invoice Head
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3IVNO">Invoice number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3INPX">Invoice Prefix</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvHeadResponse></returns>
		/// <exception cref="M3Exception<GetInvHeadResponse>"></exception>
		public async Task<M3Response<GetInvHeadResponse>> GetInvHead(
			int m3IVNO, 
			int? m3CONO = null, 
			string m3INPX = null, 
			string m3AGNB = null, 
			string m3EXIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetInvHead",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("IVNO", m3IVNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());

			// Execute the request
			var result = await Execute<GetInvHeadResponse>(
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
