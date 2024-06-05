/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRTVSUMI;
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
	/// Name: CRTVSUMI
	/// Component Name: Supplier Invoice
	/// Description: Rretrieve supplier number
	/// Version Release: 14.x
	///</summary>
	public partial class CRTVSUMIResource : M3BaseResourceEndpoint
	{
		public CRTVSUMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRTVSUMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetSupplier
		/// Description Get supplier
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_XALT">Alternative Search Key (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSupplierResponse></returns>
		/// <exception cref="M3Exception<GetSupplierResponse>"></exception>
		public async Task<M3Response<GetSupplierResponse>> GetSupplier(
			string m3_XALT, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_XALT))
				throw new ArgumentNullException("m3_XALT");

			// Set mandatory parameters
			request
				.WithQueryParameter("XALT", m3_XALT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetSupplierResponse>(
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

		/// <summary>
		/// Name LstSuppliers
		/// Description List suppliers
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_XALT">Alternative Search Key</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSuppliersResponse></returns>
		/// <exception cref="M3Exception<LstSuppliersResponse>"></exception>
		public async Task<M3Response<LstSuppliersResponse>> LstSuppliers(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_XALT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSuppliers",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XALT))
				request.WithQueryParameter("XALT", m3_XALT.Trim());

			// Execute the request
			var result = await Execute<LstSuppliersResponse>(
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
