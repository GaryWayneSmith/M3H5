/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetAmtInWords
		/// Description Get Amount in Words
		/// Version Release: 
		/// </summary>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3NUMI">Amount in Numerals (Required)</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CNVM">Printout of amounts</param>
		/// <param name="m3PMNE">Negative value permitted</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAmtInWordsResponse></returns>
		/// <exception cref="M3Exception<GetAmtInWordsResponse>"></exception>
		public async Task<M3Response<GetAmtInWordsResponse>> GetAmtInWords(
			string m3CUCD, 
			decimal m3NUMI, 
			string m3LNCD = null, 
			int? m3CNVM = null, 
			int? m3PMNE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAmtInWords",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("NUMI", m3NUMI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3CNVM.HasValue)
				request.WithQueryParameter("CNVM", m3CNVM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PMNE.HasValue)
				request.WithQueryParameter("PMNE", m3PMNE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAmtInWordsResponse>(
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
		/// Name GetCurrPerLng
		/// Description Get Currency per Language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCurrPerLngResponse></returns>
		/// <exception cref="M3Exception<GetCurrPerLngResponse>"></exception>
		public async Task<M3Response<GetCurrPerLngResponse>> GetCurrPerLng(
			string m3CUCD, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCurrPerLng",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetCurrPerLngResponse>(
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
