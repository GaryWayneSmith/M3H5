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
	/// Name: APS250MI
	/// Component Name: AccountsPayableAdditionalInfo
	/// Description: Accounts Payable. Rtv add info
	/// Version Release: 13.1
	///</summary>
	public partial class APS250MIResource : M3BaseResourceEndpoint
	{
		public APS250MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APS250MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddInvInfo
		/// Description Add additional invoice information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3JRNO">Journal number (Required)</param>
		/// <param name="m3JSNO">Journal sequence number (Required)</param>
		/// <param name="m3PEXN">AP information category (Required)</param>
		/// <param name="m3PEXI">AP additional information (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PEXS">AP information sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInvInfo(
			int m3YEA4, 
			int m3JRNO, 
			int m3JSNO, 
			int m3PEXN, 
			string m3PEXI, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3PEXS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddInvInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PEXI))
				throw new ArgumentNullException(nameof(m3PEXI));

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JRNO", m3JRNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JSNO", m3JSNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PEXN", m3PEXN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PEXI", m3PEXI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3PEXS.HasValue)
				request.WithQueryParameter("PEXS", m3PEXS.Value.ToString(CultureInfo.CurrentCulture));

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
