/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_ADTE">Address Type (Required)</param>
		/// <param name="m3_ADID">Address Number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSupplAddressResponse></returns>
		/// <exception cref="M3Exception<GetSupplAddressResponse>"></exception>
		public async Task<M3Response<GetSupplAddressResponse>> GetSupplAddress(
			int m3_CONO, 
			string m3_SUNO, 
			int m3_ADTE, 
			string m3_ADID, 
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
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("ADTE", m3_ADTE.ToString())
				.WithQueryParameter("ADID", m3_ADID.Trim());

			// Execute the request
			var result = await Execute<GetSupplAddressResponse>(
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
