/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS180MI;
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
	/// Name: CRS180MI
	/// Component Name: Education
	/// Description: Api: Convert numbers into words
	/// Version Release: 5e90
	///</summary>
	public partial class CRS180MIResource : M3BaseResourceEndpoint
	{
		public CRS180MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS180MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetAmtInWords
		/// Description Get Amount in Words
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_NUMI">Amount in Numerals (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CNVM">Printout of amounts</param>
		/// <param name="m3_PMNE">Negative value permitted</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAmtInWordsResponse></returns>
		/// <exception cref="M3Exception<GetAmtInWordsResponse>"></exception>
		public async Task<M3Response<GetAmtInWordsResponse>> GetAmtInWords(
			string m3_CUCD, 
			decimal m3_NUMI, 
			string m3_LNCD = null, 
			int? m3_CNVM = null, 
			int? m3_PMNE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAmtInWords",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("NUMI", m3_NUMI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_CNVM.HasValue)
				request.WithQueryParameter("CNVM", m3_CNVM.Value.ToString());
			if (m3_PMNE.HasValue)
				request.WithQueryParameter("PMNE", m3_PMNE.Value.ToString());

			// Execute the request
			var result = await Execute<GetAmtInWordsResponse>(
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
		/// Name GetCurrPerLng
		/// Description Get Currency per Language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCurrPerLngResponse></returns>
		/// <exception cref="M3Exception<GetCurrPerLngResponse>"></exception>
		public async Task<M3Response<GetCurrPerLngResponse>> GetCurrPerLng(
			string m3_CUCD, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCurrPerLng",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetCurrPerLngResponse>(
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
