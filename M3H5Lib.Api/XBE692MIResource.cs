/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetBasicData
		/// Description Retrieve bank account basic data - Extension
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BKTP">Bank Account Type (Required)</param>
		/// <param name="m3ACHO">Account Holder (Required)</param>
		/// <param name="m3BKID">Bank Account Identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			int m3CONO, 
			string m3DIVI, 
			int m3BKTP, 
			string m3ACHO, 
			string m3BKID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3ACHO))
				throw new ArgumentNullException(nameof(m3ACHO));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BKTP", m3BKTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACHO", m3ACHO.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
