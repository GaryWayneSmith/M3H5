/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRS630MI;
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
	/// Name: CRS630MI
	/// Component Name: Financials
	/// Description: Api: Chart of accounts file
	/// Version Release: 5e90
	///</summary>
	public partial class CRS630MIResource : M3BaseResourceEndpoint
	{
		public CRS630MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS630MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetAccountID
		/// Description Get Account ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AITP">Accounting dimension (Required)</param>
		/// <param name="m3AITM">Accounting identity (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAccountIDResponse></returns>
		/// <exception cref="M3Exception<GetAccountIDResponse>"></exception>
		public async Task<M3Response<GetAccountIDResponse>> GetAccountID(
			int m3AITP, 
			string m3AITM, 
			string m3DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAccountID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AITM))
				throw new ArgumentNullException(nameof(m3AITM));

			// Set mandatory parameters
			request
				.WithQueryParameter("AITP", m3AITP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("AITM", m3AITM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetAccountIDResponse>(
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
		/// Name GetAccountIDLng
		/// Description Get Account ID Language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AITP">Accounting dimension (Required)</param>
		/// <param name="m3AITM">Accounting identity (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAccountIDLngResponse></returns>
		/// <exception cref="M3Exception<GetAccountIDLngResponse>"></exception>
		public async Task<M3Response<GetAccountIDLngResponse>> GetAccountIDLng(
			int m3AITP, 
			string m3AITM, 
			string m3DIVI = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAccountIDLng",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AITM))
				throw new ArgumentNullException(nameof(m3AITM));

			// Set mandatory parameters
			request
				.WithQueryParameter("AITP", m3AITP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("AITM", m3AITM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetAccountIDLngResponse>(
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
		/// Name LstAccountID
		/// Description List Account ID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AITP">Accounting dimension (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3AITM">Accounting identity</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAccountIDResponse></returns>
		/// <exception cref="M3Exception<LstAccountIDResponse>"></exception>
		public async Task<M3Response<LstAccountIDResponse>> LstAccountID(
			int m3AITP, 
			string m3DIVI = null, 
			string m3AITM = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAccountID",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("AITP", m3AITP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AITM))
				request.WithQueryParameter("AITM", m3AITM.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstAccountIDResponse>(
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
		/// Name LstAccountIDLng
		/// Description List Account ID Language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AITP">Accounting dimension (Required)</param>
		/// <param name="m3AITM">Accounting identity (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAccountIDLngResponse></returns>
		/// <exception cref="M3Exception<LstAccountIDLngResponse>"></exception>
		public async Task<M3Response<LstAccountIDLngResponse>> LstAccountIDLng(
			int m3AITP, 
			string m3AITM, 
			string m3LNCD, 
			string m3DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAccountIDLng",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AITM))
				throw new ArgumentNullException(nameof(m3AITM));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("AITP", m3AITP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("AITM", m3AITM.Trim())
				.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstAccountIDLngResponse>(
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
