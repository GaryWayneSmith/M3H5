/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3PTID">Pointer ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBitFromPtidResponse></returns>
		/// <exception cref="M3Exception<GetBitFromPtidResponse>"></exception>
		public async Task<M3Response<GetBitFromPtidResponse>> GetBitFromPtid(
			decimal m3PTID, 
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
				.WithQueryParameter("PTID", m3PTID.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBitFromPtidResponse>(
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
		/// Name GetPerBalance
		/// Description Get Period Balance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3PERI">Period (Required)</param>
		/// <param name="m3BAKY">Balance key (Required)</param>
		/// <param name="m3SIKY">Single key (Required)</param>
		/// <param name="m3FIT1">From Balance dimension 1</param>
		/// <param name="m3FIT2">From Balance dimension 2</param>
		/// <param name="m3FIT3">From Balance dimension 3</param>
		/// <param name="m3FIT4">From Balance dimension 4</param>
		/// <param name="m3FIT5">From Balance dimension 5</param>
		/// <param name="m3FIT6">From Balance dimension 6</param>
		/// <param name="m3FIT7">From Balance dimension 7</param>
		/// <param name="m3TIT1">To Balance dimension 1</param>
		/// <param name="m3TIT2">To Balance dimension 2</param>
		/// <param name="m3TIT3">To Balance dimension 3</param>
		/// <param name="m3TIT4">To Balance dimension 4</param>
		/// <param name="m3TIT5">To Balance dimension 5</param>
		/// <param name="m3TIT6">To Balance dimension 6</param>
		/// <param name="m3TIT7">To Balance dimension 7</param>
		/// <param name="m3VTYP">Value type</param>
		/// <param name="m3BUNO">Budget number</param>
		/// <param name="m3BVER">Budget version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPerBalanceResponse></returns>
		/// <exception cref="M3Exception<GetPerBalanceResponse>"></exception>
		public async Task<M3Response<GetPerBalanceResponse>> GetPerBalance(
			string m3DIVI, 
			int m3YEA4, 
			int m3PERI, 
			int m3BAKY, 
			int m3SIKY, 
			string m3FIT1 = null, 
			string m3FIT2 = null, 
			string m3FIT3 = null, 
			string m3FIT4 = null, 
			string m3FIT5 = null, 
			string m3FIT6 = null, 
			string m3FIT7 = null, 
			string m3TIT1 = null, 
			string m3TIT2 = null, 
			string m3TIT3 = null, 
			string m3TIT4 = null, 
			string m3TIT5 = null, 
			string m3TIT6 = null, 
			string m3TIT7 = null, 
			int? m3VTYP = null, 
			int? m3BUNO = null, 
			string m3BVER = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PERI", m3PERI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BAKY", m3BAKY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SIKY", m3SIKY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FIT1))
				request.WithQueryParameter("FIT1", m3FIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT2))
				request.WithQueryParameter("FIT2", m3FIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT3))
				request.WithQueryParameter("FIT3", m3FIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT4))
				request.WithQueryParameter("FIT4", m3FIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT5))
				request.WithQueryParameter("FIT5", m3FIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT6))
				request.WithQueryParameter("FIT6", m3FIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT7))
				request.WithQueryParameter("FIT7", m3FIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT1))
				request.WithQueryParameter("TIT1", m3TIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT2))
				request.WithQueryParameter("TIT2", m3TIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT3))
				request.WithQueryParameter("TIT3", m3TIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT4))
				request.WithQueryParameter("TIT4", m3TIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT5))
				request.WithQueryParameter("TIT5", m3TIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT6))
				request.WithQueryParameter("TIT6", m3TIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT7))
				request.WithQueryParameter("TIT7", m3TIT7.Trim());
			if (m3VTYP.HasValue)
				request.WithQueryParameter("VTYP", m3VTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUNO.HasValue)
				request.WithQueryParameter("BUNO", m3BUNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BVER))
				request.WithQueryParameter("BVER", m3BVER.Trim());

			// Execute the request
			var result = await Execute<GetPerBalanceResponse>(
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
		/// Name GetPerOpenBal
		/// Description Get Period Opening Balance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3PERI">Period (Required)</param>
		/// <param name="m3BAKY">Balance key (Required)</param>
		/// <param name="m3SIKY">Single key (Required)</param>
		/// <param name="m3FIT1">From Balance dimension 1</param>
		/// <param name="m3FIT2">From Balance dimension 2</param>
		/// <param name="m3FIT3">From Balance dimension 3</param>
		/// <param name="m3FIT4">From Balance dimension 4</param>
		/// <param name="m3FIT5">From Balance dimension 5</param>
		/// <param name="m3FIT6">From Balance dimension 6</param>
		/// <param name="m3FIT7">From Balance dimension 7</param>
		/// <param name="m3TIT1">To Balance dimension 1</param>
		/// <param name="m3TIT2">To Balance dimension 2</param>
		/// <param name="m3TIT3">To Balance dimension 3</param>
		/// <param name="m3TIT4">To Balance dimension 4</param>
		/// <param name="m3TIT5">To Balance dimension 5</param>
		/// <param name="m3TIT6">To Balance dimension 6</param>
		/// <param name="m3TIT7">To Balance dimension 7</param>
		/// <param name="m3VTYP">Value type</param>
		/// <param name="m3BUNO">Budget number</param>
		/// <param name="m3BVER">Budget version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPerOpenBalResponse></returns>
		/// <exception cref="M3Exception<GetPerOpenBalResponse>"></exception>
		public async Task<M3Response<GetPerOpenBalResponse>> GetPerOpenBal(
			string m3DIVI, 
			int m3YEA4, 
			int m3PERI, 
			int m3BAKY, 
			int m3SIKY, 
			string m3FIT1 = null, 
			string m3FIT2 = null, 
			string m3FIT3 = null, 
			string m3FIT4 = null, 
			string m3FIT5 = null, 
			string m3FIT6 = null, 
			string m3FIT7 = null, 
			string m3TIT1 = null, 
			string m3TIT2 = null, 
			string m3TIT3 = null, 
			string m3TIT4 = null, 
			string m3TIT5 = null, 
			string m3TIT6 = null, 
			string m3TIT7 = null, 
			int? m3VTYP = null, 
			int? m3BUNO = null, 
			string m3BVER = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PERI", m3PERI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BAKY", m3BAKY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SIKY", m3SIKY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FIT1))
				request.WithQueryParameter("FIT1", m3FIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT2))
				request.WithQueryParameter("FIT2", m3FIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT3))
				request.WithQueryParameter("FIT3", m3FIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT4))
				request.WithQueryParameter("FIT4", m3FIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT5))
				request.WithQueryParameter("FIT5", m3FIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT6))
				request.WithQueryParameter("FIT6", m3FIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT7))
				request.WithQueryParameter("FIT7", m3FIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT1))
				request.WithQueryParameter("TIT1", m3TIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT2))
				request.WithQueryParameter("TIT2", m3TIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT3))
				request.WithQueryParameter("TIT3", m3TIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT4))
				request.WithQueryParameter("TIT4", m3TIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT5))
				request.WithQueryParameter("TIT5", m3TIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT6))
				request.WithQueryParameter("TIT6", m3TIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT7))
				request.WithQueryParameter("TIT7", m3TIT7.Trim());
			if (m3VTYP.HasValue)
				request.WithQueryParameter("VTYP", m3VTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUNO.HasValue)
				request.WithQueryParameter("BUNO", m3BUNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BVER))
				request.WithQueryParameter("BVER", m3BVER.Trim());

			// Execute the request
			var result = await Execute<GetPerOpenBalResponse>(
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
		/// Name LstPerBalances
		/// Description List Per Balances
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BAKY">Balance key (Required)</param>
		/// <param name="m3BIT1">Balance dimension 1</param>
		/// <param name="m3BIT2">Balance dimension 2</param>
		/// <param name="m3BIT3">Balance dimension 3</param>
		/// <param name="m3BIT4">Balance dimension 4</param>
		/// <param name="m3BIT5">Balance dimension 5</param>
		/// <param name="m3BIT6">Balance dimension 6</param>
		/// <param name="m3BIT7">Balance dimension 7</param>
		/// <param name="m3VTYP">Value type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPerBalancesResponse></returns>
		/// <exception cref="M3Exception<LstPerBalancesResponse>"></exception>
		public async Task<M3Response<LstPerBalancesResponse>> LstPerBalances(
			string m3DIVI, 
			int m3BAKY, 
			string m3BIT1 = null, 
			string m3BIT2 = null, 
			string m3BIT3 = null, 
			string m3BIT4 = null, 
			string m3BIT5 = null, 
			string m3BIT6 = null, 
			string m3BIT7 = null, 
			int? m3VTYP = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BAKY", m3BAKY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BIT1))
				request.WithQueryParameter("BIT1", m3BIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BIT2))
				request.WithQueryParameter("BIT2", m3BIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BIT3))
				request.WithQueryParameter("BIT3", m3BIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BIT4))
				request.WithQueryParameter("BIT4", m3BIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3BIT5))
				request.WithQueryParameter("BIT5", m3BIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3BIT6))
				request.WithQueryParameter("BIT6", m3BIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3BIT7))
				request.WithQueryParameter("BIT7", m3BIT7.Trim());
			if (m3VTYP.HasValue)
				request.WithQueryParameter("VTYP", m3VTYP.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPerBalancesResponse>(
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
