/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.GLS215MI;
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
	/// Name: GLS215MI
	/// Component Name: Financials
	/// Description: Api: GL Balance File
	/// Version Release: 14.x
	///</summary>
	public partial class GLS215MIResource : M3BaseResourceEndpoint
	{
		public GLS215MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "GLS215MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetBitFromPtid
		/// Description Get Balance dimensions from FBAKEY based on PTID
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PTID">Pointer ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBitFromPtidResponse></returns>
		/// <exception cref="M3Exception<GetBitFromPtidResponse>"></exception>
		public async Task<M3Response<GetBitFromPtidResponse>> GetBitFromPtid(
			decimal m3_PTID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBitFromPtid",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PTID", m3_PTID.ToString());

			// Execute the request
			var result = await Execute<GetBitFromPtidResponse>(
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
		/// Name GetPerBalance
		/// Description Get Period Balance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PERI">Period (Required)</param>
		/// <param name="m3_BAKY">Balance key (Required)</param>
		/// <param name="m3_SIKY">Single key (Required)</param>
		/// <param name="m3_FIT1">From Balance dimension 1</param>
		/// <param name="m3_FIT2">From Balance dimension 2</param>
		/// <param name="m3_FIT3">From Balance dimension 3</param>
		/// <param name="m3_FIT4">From Balance dimension 4</param>
		/// <param name="m3_FIT5">From Balance dimension 5</param>
		/// <param name="m3_FIT6">From Balance dimension 6</param>
		/// <param name="m3_FIT7">From Balance dimension 7</param>
		/// <param name="m3_TIT1">To Balance dimension 1</param>
		/// <param name="m3_TIT2">To Balance dimension 2</param>
		/// <param name="m3_TIT3">To Balance dimension 3</param>
		/// <param name="m3_TIT4">To Balance dimension 4</param>
		/// <param name="m3_TIT5">To Balance dimension 5</param>
		/// <param name="m3_TIT6">To Balance dimension 6</param>
		/// <param name="m3_TIT7">To Balance dimension 7</param>
		/// <param name="m3_VTYP">Value type</param>
		/// <param name="m3_BUNO">Budget number</param>
		/// <param name="m3_BVER">Budget version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPerBalanceResponse></returns>
		/// <exception cref="M3Exception<GetPerBalanceResponse>"></exception>
		public async Task<M3Response<GetPerBalanceResponse>> GetPerBalance(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_PERI, 
			int m3_BAKY, 
			int m3_SIKY, 
			string m3_FIT1 = null, 
			string m3_FIT2 = null, 
			string m3_FIT3 = null, 
			string m3_FIT4 = null, 
			string m3_FIT5 = null, 
			string m3_FIT6 = null, 
			string m3_FIT7 = null, 
			string m3_TIT1 = null, 
			string m3_TIT2 = null, 
			string m3_TIT3 = null, 
			string m3_TIT4 = null, 
			string m3_TIT5 = null, 
			string m3_TIT6 = null, 
			string m3_TIT7 = null, 
			int? m3_VTYP = null, 
			int? m3_BUNO = null, 
			string m3_BVER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPerBalance",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PERI", m3_PERI.ToString())
				.WithQueryParameter("BAKY", m3_BAKY.ToString())
				.WithQueryParameter("SIKY", m3_SIKY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FIT1))
				request.WithQueryParameter("FIT1", m3_FIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT2))
				request.WithQueryParameter("FIT2", m3_FIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT3))
				request.WithQueryParameter("FIT3", m3_FIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT4))
				request.WithQueryParameter("FIT4", m3_FIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT5))
				request.WithQueryParameter("FIT5", m3_FIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT6))
				request.WithQueryParameter("FIT6", m3_FIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT7))
				request.WithQueryParameter("FIT7", m3_FIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT1))
				request.WithQueryParameter("TIT1", m3_TIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT2))
				request.WithQueryParameter("TIT2", m3_TIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT3))
				request.WithQueryParameter("TIT3", m3_TIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT4))
				request.WithQueryParameter("TIT4", m3_TIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT5))
				request.WithQueryParameter("TIT5", m3_TIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT6))
				request.WithQueryParameter("TIT6", m3_TIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT7))
				request.WithQueryParameter("TIT7", m3_TIT7.Trim());
			if (m3_VTYP.HasValue)
				request.WithQueryParameter("VTYP", m3_VTYP.Value.ToString());
			if (m3_BUNO.HasValue)
				request.WithQueryParameter("BUNO", m3_BUNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BVER))
				request.WithQueryParameter("BVER", m3_BVER.Trim());

			// Execute the request
			var result = await Execute<GetPerBalanceResponse>(
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
		/// Name GetPerOpenBal
		/// Description Get Period Opening Balance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PERI">Period (Required)</param>
		/// <param name="m3_BAKY">Balance key (Required)</param>
		/// <param name="m3_SIKY">Single key (Required)</param>
		/// <param name="m3_FIT1">From Balance dimension 1</param>
		/// <param name="m3_FIT2">From Balance dimension 2</param>
		/// <param name="m3_FIT3">From Balance dimension 3</param>
		/// <param name="m3_FIT4">From Balance dimension 4</param>
		/// <param name="m3_FIT5">From Balance dimension 5</param>
		/// <param name="m3_FIT6">From Balance dimension 6</param>
		/// <param name="m3_FIT7">From Balance dimension 7</param>
		/// <param name="m3_TIT1">To Balance dimension 1</param>
		/// <param name="m3_TIT2">To Balance dimension 2</param>
		/// <param name="m3_TIT3">To Balance dimension 3</param>
		/// <param name="m3_TIT4">To Balance dimension 4</param>
		/// <param name="m3_TIT5">To Balance dimension 5</param>
		/// <param name="m3_TIT6">To Balance dimension 6</param>
		/// <param name="m3_TIT7">To Balance dimension 7</param>
		/// <param name="m3_VTYP">Value type</param>
		/// <param name="m3_BUNO">Budget number</param>
		/// <param name="m3_BVER">Budget version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPerOpenBalResponse></returns>
		/// <exception cref="M3Exception<GetPerOpenBalResponse>"></exception>
		public async Task<M3Response<GetPerOpenBalResponse>> GetPerOpenBal(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_PERI, 
			int m3_BAKY, 
			int m3_SIKY, 
			string m3_FIT1 = null, 
			string m3_FIT2 = null, 
			string m3_FIT3 = null, 
			string m3_FIT4 = null, 
			string m3_FIT5 = null, 
			string m3_FIT6 = null, 
			string m3_FIT7 = null, 
			string m3_TIT1 = null, 
			string m3_TIT2 = null, 
			string m3_TIT3 = null, 
			string m3_TIT4 = null, 
			string m3_TIT5 = null, 
			string m3_TIT6 = null, 
			string m3_TIT7 = null, 
			int? m3_VTYP = null, 
			int? m3_BUNO = null, 
			string m3_BVER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPerOpenBal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PERI", m3_PERI.ToString())
				.WithQueryParameter("BAKY", m3_BAKY.ToString())
				.WithQueryParameter("SIKY", m3_SIKY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FIT1))
				request.WithQueryParameter("FIT1", m3_FIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT2))
				request.WithQueryParameter("FIT2", m3_FIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT3))
				request.WithQueryParameter("FIT3", m3_FIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT4))
				request.WithQueryParameter("FIT4", m3_FIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT5))
				request.WithQueryParameter("FIT5", m3_FIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT6))
				request.WithQueryParameter("FIT6", m3_FIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT7))
				request.WithQueryParameter("FIT7", m3_FIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT1))
				request.WithQueryParameter("TIT1", m3_TIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT2))
				request.WithQueryParameter("TIT2", m3_TIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT3))
				request.WithQueryParameter("TIT3", m3_TIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT4))
				request.WithQueryParameter("TIT4", m3_TIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT5))
				request.WithQueryParameter("TIT5", m3_TIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT6))
				request.WithQueryParameter("TIT6", m3_TIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT7))
				request.WithQueryParameter("TIT7", m3_TIT7.Trim());
			if (m3_VTYP.HasValue)
				request.WithQueryParameter("VTYP", m3_VTYP.Value.ToString());
			if (m3_BUNO.HasValue)
				request.WithQueryParameter("BUNO", m3_BUNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BVER))
				request.WithQueryParameter("BVER", m3_BVER.Trim());

			// Execute the request
			var result = await Execute<GetPerOpenBalResponse>(
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
		/// Name LstPerBalances
		/// Description List Per Balances
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BAKY">Balance key (Required)</param>
		/// <param name="m3_BIT1">Balance dimension 1</param>
		/// <param name="m3_BIT2">Balance dimension 2</param>
		/// <param name="m3_BIT3">Balance dimension 3</param>
		/// <param name="m3_BIT4">Balance dimension 4</param>
		/// <param name="m3_BIT5">Balance dimension 5</param>
		/// <param name="m3_BIT6">Balance dimension 6</param>
		/// <param name="m3_BIT7">Balance dimension 7</param>
		/// <param name="m3_VTYP">Value type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPerBalancesResponse></returns>
		/// <exception cref="M3Exception<LstPerBalancesResponse>"></exception>
		public async Task<M3Response<LstPerBalancesResponse>> LstPerBalances(
			string m3_DIVI, 
			int m3_BAKY, 
			string m3_BIT1 = null, 
			string m3_BIT2 = null, 
			string m3_BIT3 = null, 
			string m3_BIT4 = null, 
			string m3_BIT5 = null, 
			string m3_BIT6 = null, 
			string m3_BIT7 = null, 
			int? m3_VTYP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPerBalances",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BAKY", m3_BAKY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BIT1))
				request.WithQueryParameter("BIT1", m3_BIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BIT2))
				request.WithQueryParameter("BIT2", m3_BIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BIT3))
				request.WithQueryParameter("BIT3", m3_BIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BIT4))
				request.WithQueryParameter("BIT4", m3_BIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BIT5))
				request.WithQueryParameter("BIT5", m3_BIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BIT6))
				request.WithQueryParameter("BIT6", m3_BIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BIT7))
				request.WithQueryParameter("BIT7", m3_BIT7.Trim());
			if (m3_VTYP.HasValue)
				request.WithQueryParameter("VTYP", m3_VTYP.Value.ToString());

			// Execute the request
			var result = await Execute<LstPerBalancesResponse>(
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
