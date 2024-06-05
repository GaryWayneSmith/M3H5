/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.TXS035MI;
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
	/// Name: TXS035MI
	/// Component Name: EU Sales/Purchase Additional F
	/// Description: Api: EU Sales/Purchase Additional Field
	/// Version Release: 13.1
	///</summary>
	public partial class TXS035MIResource : M3BaseResourceEndpoint
	{
		public TXS035MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "TXS035MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetAddField
		/// Description Get additional field
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ESAF">Additional field (Required)</param>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TYPE">Transaction type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddFieldResponse></returns>
		/// <exception cref="M3Exception<GetAddFieldResponse>"></exception>
		public async Task<M3Response<GetAddFieldResponse>> GetAddField(
			string m3_DIVI, 
			int m3_ESAF, 
			string m3_BSCD, 
			int? m3_CONO = null, 
			int? m3_TYPE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("ESAF", m3_ESAF.ToString())
				.WithQueryParameter("BSCD", m3_BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_TYPE.HasValue)
				request.WithQueryParameter("TYPE", m3_TYPE.Value.ToString());

			// Execute the request
			var result = await Execute<GetAddFieldResponse>(
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
		/// Name LstBaseCountry
		/// Description List by base country
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TYPE">Transaction type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBaseCountryResponse></returns>
		/// <exception cref="M3Exception<LstBaseCountryResponse>"></exception>
		public async Task<M3Response<LstBaseCountryResponse>> LstBaseCountry(
			string m3_DIVI, 
			string m3_BSCD, 
			int? m3_CONO = null, 
			int? m3_TYPE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBaseCountry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BSCD", m3_BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_TYPE.HasValue)
				request.WithQueryParameter("TYPE", m3_TYPE.Value.ToString());

			// Execute the request
			var result = await Execute<LstBaseCountryResponse>(
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
