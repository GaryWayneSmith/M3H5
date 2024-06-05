/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_JRNO">Journal number (Required)</param>
		/// <param name="m3_JSNO">Journal sequence number (Required)</param>
		/// <param name="m3_PEXN">AP information category (Required)</param>
		/// <param name="m3_PEXI">AP additional information (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PEXS">AP information sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInvInfo(
			int m3_YEA4, 
			int m3_JRNO, 
			int m3_JSNO, 
			int m3_PEXN, 
			string m3_PEXI, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_PEXS = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PEXI))
				throw new ArgumentNullException("m3_PEXI");

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("JRNO", m3_JRNO.ToString())
				.WithQueryParameter("JSNO", m3_JSNO.ToString())
				.WithQueryParameter("PEXN", m3_PEXN.ToString())
				.WithQueryParameter("PEXI", m3_PEXI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_PEXS.HasValue)
				request.WithQueryParameter("PEXS", m3_PEXS.Value.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
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
