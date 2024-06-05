/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.ARS460MI;
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
	/// Name: ARS460MI
	/// Component Name: Financials
	/// Description: Api: Direct Debiting Agreement Transfer
	/// Version Release: 13.1
	///</summary>
	public partial class ARS460MIResource : M3BaseResourceEndpoint
	{
		public ARS460MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ARS460MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetAgByCustomer
		/// Description Get Agreements by Customer
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3DDAN">Agreement proposal number (Required)</param>
		/// <param name="m3BKI2">Bank account identity (Required)</param>
		/// <param name="m3AGIN">Agreement indicator (Required)</param>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3BKAG">Bank EDI agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgByCustomerResponse></returns>
		/// <exception cref="M3Exception<GetAgByCustomerResponse>"></exception>
		public async Task<M3Response<GetAgByCustomerResponse>> GetAgByCustomer(
			string m3DIVI, 
			long m3DDAN, 
			string m3BKI2, 
			string m3AGIN, 
			string m3CUNO, 
			string m3BKID, 
			string m3BKAG, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgByCustomer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKI2))
				throw new ArgumentNullException(nameof(m3BKI2));
			if (string.IsNullOrWhiteSpace(m3AGIN))
				throw new ArgumentNullException(nameof(m3AGIN));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));
			if (string.IsNullOrWhiteSpace(m3BKAG))
				throw new ArgumentNullException(nameof(m3BKAG));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("DDAN", m3DDAN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BKI2", m3BKI2.Trim())
				.WithQueryParameter("AGIN", m3AGIN.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim())
				.WithQueryParameter("BKAG", m3BKAG.Trim());

			// Execute the request
			var result = await Execute<GetAgByCustomerResponse>(
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
		/// Name GetCustomerHead
		/// Description Get Customer Information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3DDAN">Agreement proposal number (Required)</param>
		/// <param name="m3BKI2">Bank account identity (Required)</param>
		/// <param name="m3AGIN">Agreement indicator (Required)</param>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustomerHeadResponse></returns>
		/// <exception cref="M3Exception<GetCustomerHeadResponse>"></exception>
		public async Task<M3Response<GetCustomerHeadResponse>> GetCustomerHead(
			string m3DIVI, 
			long m3DDAN, 
			string m3BKI2, 
			string m3AGIN, 
			string m3CUNO, 
			string m3BKID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCustomerHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKI2))
				throw new ArgumentNullException(nameof(m3BKI2));
			if (string.IsNullOrWhiteSpace(m3AGIN))
				throw new ArgumentNullException(nameof(m3AGIN));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("DDAN", m3DDAN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BKI2", m3BKI2.Trim())
				.WithQueryParameter("AGIN", m3AGIN.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim());

			// Execute the request
			var result = await Execute<GetCustomerHeadResponse>(
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
		/// Name GetHead
		/// Description Get Head Information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3DDAN">Agreement proposal number (Required)</param>
		/// <param name="m3BKI2">Bank account identity (Required)</param>
		/// <param name="m3AGIN">Agreement indicator (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3DIVI, 
			long m3DDAN, 
			string m3BKI2, 
			string m3AGIN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKI2))
				throw new ArgumentNullException(nameof(m3BKI2));
			if (string.IsNullOrWhiteSpace(m3AGIN))
				throw new ArgumentNullException(nameof(m3AGIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("DDAN", m3DDAN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BKI2", m3BKI2.Trim())
				.WithQueryParameter("AGIN", m3AGIN.Trim());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetHeadAdress
		/// Description Get Head Adresses
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3DDAN">Agreement proposal number (Required)</param>
		/// <param name="m3BKI2">Bank account identity (Required)</param>
		/// <param name="m3AGIN">Agreement indicator (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadAdressResponse></returns>
		/// <exception cref="M3Exception<GetHeadAdressResponse>"></exception>
		public async Task<M3Response<GetHeadAdressResponse>> GetHeadAdress(
			string m3DIVI, 
			long m3DDAN, 
			string m3BKI2, 
			string m3AGIN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadAdress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKI2))
				throw new ArgumentNullException(nameof(m3BKI2));
			if (string.IsNullOrWhiteSpace(m3AGIN))
				throw new ArgumentNullException(nameof(m3AGIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("DDAN", m3DDAN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BKI2", m3BKI2.Trim())
				.WithQueryParameter("AGIN", m3AGIN.Trim());

			// Execute the request
			var result = await Execute<GetHeadAdressResponse>(
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
		/// Name LstAgByCustomer
		/// Description List Agreements by Customer
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3DDAN">Agreement proposal number (Required)</param>
		/// <param name="m3BKI2">Bank account identity (Required)</param>
		/// <param name="m3AGIN">Agreement indicator (Required)</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgByCustomerResponse></returns>
		/// <exception cref="M3Exception<LstAgByCustomerResponse>"></exception>
		public async Task<M3Response<LstAgByCustomerResponse>> LstAgByCustomer(
			string m3DIVI, 
			long m3DDAN, 
			string m3BKI2, 
			string m3AGIN, 
			string m3CUNO = null, 
			string m3BKID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgByCustomer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKI2))
				throw new ArgumentNullException(nameof(m3BKI2));
			if (string.IsNullOrWhiteSpace(m3AGIN))
				throw new ArgumentNullException(nameof(m3AGIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("DDAN", m3DDAN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BKI2", m3BKI2.Trim())
				.WithQueryParameter("AGIN", m3AGIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());

			// Execute the request
			var result = await Execute<LstAgByCustomerResponse>(
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
