/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.XBE622MI;
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
	/// Name: XBE622MI
	/// Component Name: Suppliers
	/// Description: COUNTRY:Supplier Addresses
	/// Version Release: 12.4
	///</summary>
	public partial class XBE622MIResource : M3BaseResourceEndpoint
	{
		public XBE622MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "XBE622MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetSupplAddress
		/// Description Retrieve Supplier Address
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3ADTE">Address Type (Required)</param>
		/// <param name="m3ADID">Address Number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSupplAddressResponse></returns>
		/// <exception cref="M3Exception<GetSupplAddressResponse>"></exception>
		public async Task<M3Response<GetSupplAddressResponse>> GetSupplAddress(
			int m3CONO, 
			string m3SUNO, 
			int m3ADTE, 
			string m3ADID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSupplAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("ADTE", m3ADTE.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADID", m3ADID.Trim());

			// Execute the request
			var result = await Execute<GetSupplAddressResponse>(
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
