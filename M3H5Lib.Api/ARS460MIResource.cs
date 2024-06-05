/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_DDAN">Agreement proposal number (Required)</param>
		/// <param name="m3_BKI2">Bank account identity (Required)</param>
		/// <param name="m3_AGIN">Agreement indicator (Required)</param>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_BKAG">Bank EDI agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgByCustomerResponse></returns>
		/// <exception cref="M3Exception<GetAgByCustomerResponse>"></exception>
		public async Task<M3Response<GetAgByCustomerResponse>> GetAgByCustomer(
			string m3_DIVI, 
			long m3_DDAN, 
			string m3_BKI2, 
			string m3_AGIN, 
			string m3_CUNO, 
			string m3_BKID, 
			string m3_BKAG, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKI2))
				throw new ArgumentNullException("m3_BKI2");
			if (string.IsNullOrWhiteSpace(m3_AGIN))
				throw new ArgumentNullException("m3_AGIN");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");
			if (string.IsNullOrWhiteSpace(m3_BKAG))
				throw new ArgumentNullException("m3_BKAG");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("DDAN", m3_DDAN.ToString())
				.WithQueryParameter("BKI2", m3_BKI2.Trim())
				.WithQueryParameter("AGIN", m3_AGIN.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim())
				.WithQueryParameter("BKAG", m3_BKAG.Trim());

			// Execute the request
			var result = await Execute<GetAgByCustomerResponse>(
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
		/// Name GetCustomerHead
		/// Description Get Customer Information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_DDAN">Agreement proposal number (Required)</param>
		/// <param name="m3_BKI2">Bank account identity (Required)</param>
		/// <param name="m3_AGIN">Agreement indicator (Required)</param>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustomerHeadResponse></returns>
		/// <exception cref="M3Exception<GetCustomerHeadResponse>"></exception>
		public async Task<M3Response<GetCustomerHeadResponse>> GetCustomerHead(
			string m3_DIVI, 
			long m3_DDAN, 
			string m3_BKI2, 
			string m3_AGIN, 
			string m3_CUNO, 
			string m3_BKID, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKI2))
				throw new ArgumentNullException("m3_BKI2");
			if (string.IsNullOrWhiteSpace(m3_AGIN))
				throw new ArgumentNullException("m3_AGIN");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("DDAN", m3_DDAN.ToString())
				.WithQueryParameter("BKI2", m3_BKI2.Trim())
				.WithQueryParameter("AGIN", m3_AGIN.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim());

			// Execute the request
			var result = await Execute<GetCustomerHeadResponse>(
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
		/// Name GetHead
		/// Description Get Head Information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_DDAN">Agreement proposal number (Required)</param>
		/// <param name="m3_BKI2">Bank account identity (Required)</param>
		/// <param name="m3_AGIN">Agreement indicator (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3_DIVI, 
			long m3_DDAN, 
			string m3_BKI2, 
			string m3_AGIN, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKI2))
				throw new ArgumentNullException("m3_BKI2");
			if (string.IsNullOrWhiteSpace(m3_AGIN))
				throw new ArgumentNullException("m3_AGIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("DDAN", m3_DDAN.ToString())
				.WithQueryParameter("BKI2", m3_BKI2.Trim())
				.WithQueryParameter("AGIN", m3_AGIN.Trim());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetHeadAdress
		/// Description Get Head Adresses
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_DDAN">Agreement proposal number (Required)</param>
		/// <param name="m3_BKI2">Bank account identity (Required)</param>
		/// <param name="m3_AGIN">Agreement indicator (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadAdressResponse></returns>
		/// <exception cref="M3Exception<GetHeadAdressResponse>"></exception>
		public async Task<M3Response<GetHeadAdressResponse>> GetHeadAdress(
			string m3_DIVI, 
			long m3_DDAN, 
			string m3_BKI2, 
			string m3_AGIN, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKI2))
				throw new ArgumentNullException("m3_BKI2");
			if (string.IsNullOrWhiteSpace(m3_AGIN))
				throw new ArgumentNullException("m3_AGIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("DDAN", m3_DDAN.ToString())
				.WithQueryParameter("BKI2", m3_BKI2.Trim())
				.WithQueryParameter("AGIN", m3_AGIN.Trim());

			// Execute the request
			var result = await Execute<GetHeadAdressResponse>(
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
		/// Name LstAgByCustomer
		/// Description List Agreements by Customer
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_DDAN">Agreement proposal number (Required)</param>
		/// <param name="m3_BKI2">Bank account identity (Required)</param>
		/// <param name="m3_AGIN">Agreement indicator (Required)</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgByCustomerResponse></returns>
		/// <exception cref="M3Exception<LstAgByCustomerResponse>"></exception>
		public async Task<M3Response<LstAgByCustomerResponse>> LstAgByCustomer(
			string m3_DIVI, 
			long m3_DDAN, 
			string m3_BKI2, 
			string m3_AGIN, 
			string m3_CUNO = null, 
			string m3_BKID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKI2))
				throw new ArgumentNullException("m3_BKI2");
			if (string.IsNullOrWhiteSpace(m3_AGIN))
				throw new ArgumentNullException("m3_AGIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("DDAN", m3_DDAN.ToString())
				.WithQueryParameter("BKI2", m3_BKI2.Trim())
				.WithQueryParameter("AGIN", m3_AGIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());

			// Execute the request
			var result = await Execute<LstAgByCustomerResponse>(
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
