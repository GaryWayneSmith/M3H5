/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.ARBR75MI;
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
	/// Name: ARBR75MI
	/// Component Name: Bank remittance
	/// Description: COUNTRY:Bank remittance
	/// Version Release: 14.0
	///</summary>
	public partial class ARBR75MIResource : M3BaseResourceEndpoint
	{
		public ARBR75MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ARBR75MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetBasicData
		/// Description Get Basic Data
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BOPE">Batch payment type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3DIVI, 
			string m3BOPE, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BOPE))
				throw new ArgumentNullException(nameof(m3BOPE));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BOPE", m3BOPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name GetBatchPaymTyp
		/// Description Get Batch Payment Type
		/// Version Release: 14.0
		/// </summary>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BOPE">Batch payment type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBatchPaymTypResponse></returns>
		/// <exception cref="M3Exception<GetBatchPaymTypResponse>"></exception>
		public async Task<M3Response<GetBatchPaymTypResponse>> GetBatchPaymTyp(
			string m3TX40, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3BOPE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBatchPaymTyp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOPE))
				request.WithQueryParameter("BOPE", m3BOPE.Trim());

			// Execute the request
			var result = await Execute<GetBatchPaymTypResponse>(
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
