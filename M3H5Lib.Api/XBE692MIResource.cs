/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.XBE692MI;
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
	/// Name: XBE692MI
	/// Component Name: Banks
	/// Description: COUNTRY:Bank Account - Extension
	/// Version Release: 12.4
	///</summary>
	public partial class XBE692MIResource : M3BaseResourceEndpoint
	{
		public XBE692MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "XBE692MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetBasicData
		/// Description Retrieve bank account basic data - Extension
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BKTP">Bank Account Type (Required)</param>
		/// <param name="m3_ACHO">Account Holder (Required)</param>
		/// <param name="m3_BKID">Bank Account Identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			int m3_CONO, 
			string m3_DIVI, 
			int m3_BKTP, 
			string m3_ACHO, 
			string m3_BKID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ACHO))
				throw new ArgumentNullException("m3_ACHO");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BKTP", m3_BKTP.ToString())
				.WithQueryParameter("ACHO", m3_ACHO.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
