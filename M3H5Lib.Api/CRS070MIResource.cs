/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS070MI;
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
	/// Name: CRS070MI
	/// Component Name: Wrk: Delivery Method
	/// Description: Delivery Method interface
	/// Version Release: 13.1
	///</summary>
	public partial class CRS070MIResource : M3BaseResourceEndpoint
	{
		public CRS070MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS070MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDelyMethod
		/// Description Add dely method
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_TEL1">Termstext (Required)</param>
		/// <param name="m3_VRDL">Transport method - trade stat (TST) (Required)</param>
		/// <param name="m3_MODL">Deliverymethod</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TEL2">Termstext</param>
		/// <param name="m3_COTT">Container used</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDelyMethod(
			string m3_LNCD, 
			string m3_TEL1, 
			int m3_VRDL, 
			string m3_MODL = null, 
			string m3_TX15 = null, 
			string m3_TEL2 = null, 
			int? m3_COTT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDelyMethod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");
			if (string.IsNullOrWhiteSpace(m3_TEL1))
				throw new ArgumentNullException("m3_TEL1");

			// Set mandatory parameters
			request
				.WithQueryParameter("LNCD", m3_LNCD.Trim())
				.WithQueryParameter("TEL1", m3_TEL1.Trim())
				.WithQueryParameter("VRDL", m3_VRDL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL2))
				request.WithQueryParameter("TEL2", m3_TEL2.Trim());
			if (m3_COTT.HasValue)
				request.WithQueryParameter("COTT", m3_COTT.Value.ToString());

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

		/// <summary>
		/// Name DelDelyMethod
		/// Description Del dely method
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_MODL">Deliverymethod</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDelyMethod(
			string m3_LNCD, 
			string m3_MODL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelDelyMethod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());

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

		/// <summary>
		/// Name GetDelyMethod
		/// Description Get dely method
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_MODL">Deliverymethod</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelyMethodResponse></returns>
		/// <exception cref="M3Exception<GetDelyMethodResponse>"></exception>
		public async Task<M3Response<GetDelyMethodResponse>> GetDelyMethod(
			string m3_LNCD, 
			string m3_MODL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDelyMethod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());

			// Execute the request
			var result = await Execute<GetDelyMethodResponse>(
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
		/// Name LstDelyMethod
		/// Description Lst dely method
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_MODL">Deliverymethod</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelyMethodResponse></returns>
		/// <exception cref="M3Exception<LstDelyMethodResponse>"></exception>
		public async Task<M3Response<LstDelyMethodResponse>> LstDelyMethod(
			string m3_MODL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDelyMethod",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());

			// Execute the request
			var result = await Execute<LstDelyMethodResponse>(
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
		/// Name UpdDelyMethod
		/// Description Upd dely method
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_MODL">Deliverymethod</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TEL1">Termstext</param>
		/// <param name="m3_TEL2">Termstext</param>
		/// <param name="m3_VRDL">Transport method - trade stat (TST)</param>
		/// <param name="m3_COTT">Container used</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDelyMethod(
			string m3_LNCD, 
			string m3_MODL = null, 
			string m3_TX15 = null, 
			string m3_TEL1 = null, 
			string m3_TEL2 = null, 
			int? m3_VRDL = null, 
			int? m3_COTT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdDelyMethod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL1))
				request.WithQueryParameter("TEL1", m3_TEL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL2))
				request.WithQueryParameter("TEL2", m3_TEL2.Trim());
			if (m3_VRDL.HasValue)
				request.WithQueryParameter("VRDL", m3_VRDL.Value.ToString());
			if (m3_COTT.HasValue)
				request.WithQueryParameter("COTT", m3_COTT.Value.ToString());

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
