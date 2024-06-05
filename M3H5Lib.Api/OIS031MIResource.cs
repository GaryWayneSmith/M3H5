/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.OIS031MI;
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
	/// Name: OIS031MI
	/// Component Name: CustomerOrderServiceCharge
	/// Description: Service charge
	/// Version Release: 12
	///</summary>
	public partial class OIS031MIResource : M3BaseResourceEndpoint
	{
		public OIS031MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS031MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstServChrgHead
		/// Description List service charges
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3EXCD">Service charge</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServChrgHeadResponse></returns>
		/// <exception cref="M3Exception<LstServChrgHeadResponse>"></exception>
		public async Task<M3Response<LstServChrgHeadResponse>> LstServChrgHead(
			int? m3CONO = null, 
			string m3EXCD = null, 
			string m3CUCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstServChrgHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXCD))
				request.WithQueryParameter("EXCD", m3EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Execute the request
			var result = await Execute<LstServChrgHeadResponse>(
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
		/// Name LstServChrgLng
		/// Description List service charges language description
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3EXCD">Service charge</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServChrgLngResponse></returns>
		/// <exception cref="M3Exception<LstServChrgLngResponse>"></exception>
		public async Task<M3Response<LstServChrgLngResponse>> LstServChrgLng(
			int? m3CONO = null, 
			string m3EXCD = null, 
			string m3CUCD = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstServChrgLng",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXCD))
				request.WithQueryParameter("EXCD", m3EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstServChrgLngResponse>(
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
		/// Name LstServChrgMtrx
		/// Description List service charge matrix
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3EXCD">Service charge</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServChrgMtrxResponse></returns>
		/// <exception cref="M3Exception<LstServChrgMtrxResponse>"></exception>
		public async Task<M3Response<LstServChrgMtrxResponse>> LstServChrgMtrx(
			int? m3CONO = null, 
			string m3EXCD = null, 
			string m3CUCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstServChrgMtrx",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXCD))
				request.WithQueryParameter("EXCD", m3EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Execute the request
			var result = await Execute<LstServChrgMtrxResponse>(
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
