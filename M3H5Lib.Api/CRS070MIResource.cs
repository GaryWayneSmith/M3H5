/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDelyMethod
		/// Description Add dely method
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3TEL1">Termstext (Required)</param>
		/// <param name="m3VRDL">Transport method - trade stat (TST) (Required)</param>
		/// <param name="m3MODL">Deliverymethod</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TEL2">Termstext</param>
		/// <param name="m3COTT">Container used</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDelyMethod(
			string m3LNCD, 
			string m3TEL1, 
			int m3VRDL, 
			string m3MODL = null, 
			string m3TX15 = null, 
			string m3TEL2 = null, 
			int? m3COTT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDelyMethod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));
			if (string.IsNullOrWhiteSpace(m3TEL1))
				throw new ArgumentNullException(nameof(m3TEL1));

			// Set mandatory parameters
			request
				.WithQueryParameter("LNCD", m3LNCD.Trim())
				.WithQueryParameter("TEL1", m3TEL1.Trim())
				.WithQueryParameter("VRDL", m3VRDL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL2))
				request.WithQueryParameter("TEL2", m3TEL2.Trim());
			if (m3COTT.HasValue)
				request.WithQueryParameter("COTT", m3COTT.Value.ToString(CultureInfo.CurrentCulture));

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

		/// <summary>
		/// Name DelDelyMethod
		/// Description Del dely method
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3MODL">Deliverymethod</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDelyMethod(
			string m3LNCD, 
			string m3MODL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelDelyMethod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());

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

		/// <summary>
		/// Name GetDelyMethod
		/// Description Get dely method
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3MODL">Deliverymethod</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelyMethodResponse></returns>
		/// <exception cref="M3Exception<GetDelyMethodResponse>"></exception>
		public async Task<M3Response<GetDelyMethodResponse>> GetDelyMethod(
			string m3LNCD, 
			string m3MODL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDelyMethod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());

			// Execute the request
			var result = await Execute<GetDelyMethodResponse>(
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

		/// <summary>
		/// Name LstDelyMethod
		/// Description Lst dely method
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3MODL">Deliverymethod</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelyMethodResponse></returns>
		/// <exception cref="M3Exception<LstDelyMethodResponse>"></exception>
		public async Task<M3Response<LstDelyMethodResponse>> LstDelyMethod(
			string m3MODL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDelyMethod",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());

			// Execute the request
			var result = await Execute<LstDelyMethodResponse>(
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

		/// <summary>
		/// Name UpdDelyMethod
		/// Description Upd dely method
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3MODL">Deliverymethod</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TEL1">Termstext</param>
		/// <param name="m3TEL2">Termstext</param>
		/// <param name="m3VRDL">Transport method - trade stat (TST)</param>
		/// <param name="m3COTT">Container used</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDelyMethod(
			string m3LNCD, 
			string m3MODL = null, 
			string m3TX15 = null, 
			string m3TEL1 = null, 
			string m3TEL2 = null, 
			int? m3VRDL = null, 
			int? m3COTT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdDelyMethod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL1))
				request.WithQueryParameter("TEL1", m3TEL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL2))
				request.WithQueryParameter("TEL2", m3TEL2.Trim());
			if (m3VRDL.HasValue)
				request.WithQueryParameter("VRDL", m3VRDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COTT.HasValue)
				request.WithQueryParameter("COTT", m3COTT.Value.ToString(CultureInfo.CurrentCulture));

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
