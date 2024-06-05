/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetAddField
		/// Description Get additional field
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3ESAF">Additional field (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TYPE">Transaction type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddFieldResponse></returns>
		/// <exception cref="M3Exception<GetAddFieldResponse>"></exception>
		public async Task<M3Response<GetAddFieldResponse>> GetAddField(
			string m3DIVI, 
			int m3ESAF, 
			string m3BSCD, 
			int? m3CONO = null, 
			int? m3TYPE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAddField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("ESAF", m3ESAF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BSCD", m3BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TYPE.HasValue)
				request.WithQueryParameter("TYPE", m3TYPE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAddFieldResponse>(
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
		/// Name LstBaseCountry
		/// Description List by base country
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TYPE">Transaction type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBaseCountryResponse></returns>
		/// <exception cref="M3Exception<LstBaseCountryResponse>"></exception>
		public async Task<M3Response<LstBaseCountryResponse>> LstBaseCountry(
			string m3DIVI, 
			string m3BSCD, 
			int? m3CONO = null, 
			int? m3TYPE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBaseCountry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSCD", m3BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TYPE.HasValue)
				request.WithQueryParameter("TYPE", m3TYPE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstBaseCountryResponse>(
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
