/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS612MI;
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
	/// Name: CRS612MI
	/// Component Name: Cust Sales and Service
	/// Description: Api: Customer cards
	/// Version Release: 13.1
	///</summary>
	public partial class CRS612MIResource : M3BaseResourceEndpoint
	{
		public CRS612MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS612MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCustCard
		/// Description This transaction adds customer card
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CCNR">Customer card number (Required)</param>
		/// <param name="m3_BLD1">Blocking date</param>
		/// <param name="m3_VTMM">Valid through month</param>
		/// <param name="m3_VTYY">Valid through year</param>
		/// <param name="m3_ORDT">Order date</param>
		/// <param name="m3_BLCD">Blocking code</param>
		/// <param name="m3_CTP1">Card type</param>
		/// <param name="m3_MCRD">Main card</param>
		/// <param name="m3_RCRD">Replacement card</param>
		/// <param name="m3_CSND">Send to printing</param>
		/// <param name="m3_REFE">Reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustCard(
			string m3_CUNO, 
			decimal m3_CCNR, 
			int? m3_BLD1 = null, 
			int? m3_VTMM = null, 
			int? m3_VTYY = null, 
			DateTime? m3_ORDT = null, 
			int? m3_BLCD = null, 
			int? m3_CTP1 = null, 
			string m3_MCRD = null, 
			int? m3_RCRD = null, 
			int? m3_CSND = null, 
			string m3_REFE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCustCard",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("CCNR", m3_CCNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_BLD1.HasValue)
				request.WithQueryParameter("BLD1", m3_BLD1.Value.ToString());
			if (m3_VTMM.HasValue)
				request.WithQueryParameter("VTMM", m3_VTMM.Value.ToString());
			if (m3_VTYY.HasValue)
				request.WithQueryParameter("VTYY", m3_VTYY.Value.ToString());
			if (m3_ORDT.HasValue)
				request.WithQueryParameter("ORDT", m3_ORDT.Value.ToM3String());
			if (m3_BLCD.HasValue)
				request.WithQueryParameter("BLCD", m3_BLCD.Value.ToString());
			if (m3_CTP1.HasValue)
				request.WithQueryParameter("CTP1", m3_CTP1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCRD))
				request.WithQueryParameter("MCRD", m3_MCRD.Trim());
			if (m3_RCRD.HasValue)
				request.WithQueryParameter("RCRD", m3_RCRD.Value.ToString());
			if (m3_CSND.HasValue)
				request.WithQueryParameter("CSND", m3_CSND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REFE))
				request.WithQueryParameter("REFE", m3_REFE.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name DelCustCard
		/// Description This transaction deletes customer card
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CCNR">Customer card number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelCustCard(
			string m3_CUNO, 
			decimal m3_CCNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelCustCard",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("CCNR", m3_CCNR.ToString());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name GetCustCard
		/// Description This transaction displays customer card
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CCNR">Customer card number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustCardResponse></returns>
		/// <exception cref="M3Exception<GetCustCardResponse>"></exception>
		public async Task<M3Response<GetCustCardResponse>> GetCustCard(
			string m3_CUNO, 
			decimal m3_CCNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCustCard",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("CCNR", m3_CCNR.ToString());

			// Execute the request
			var result = await Execute<GetCustCardResponse>(
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
		/// Name LstCustCard
		/// Description This transaction lists customer card
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_CCNR">Customer card number</param>
		/// <param name="m3_CTP1">Card type</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="m3_REFE">Reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustCardResponse></returns>
		/// <exception cref="M3Exception<LstCustCardResponse>"></exception>
		public async Task<M3Response<LstCustCardResponse>> LstCustCard(
			string m3_CUNO = null, 
			decimal? m3_CCNR = null, 
			int? m3_CTP1 = null, 
			DateTime? m3_LMDT = null, 
			string m3_REFE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustCard",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_CCNR.HasValue)
				request.WithQueryParameter("CCNR", m3_CCNR.Value.ToString());
			if (m3_CTP1.HasValue)
				request.WithQueryParameter("CTP1", m3_CTP1.Value.ToString());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_REFE))
				request.WithQueryParameter("REFE", m3_REFE.Trim());

			// Execute the request
			var result = await Execute<LstCustCardResponse>(
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
		/// Name UpdCustCard
		/// Description This transaction updates customer card
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CCNR">Customer card number (Required)</param>
		/// <param name="m3_BLD1">Blocking date</param>
		/// <param name="m3_VTMM">Valid through month</param>
		/// <param name="m3_VTYY">Valid through year</param>
		/// <param name="m3_ORDT">Order date</param>
		/// <param name="m3_BLCD">Blocking code</param>
		/// <param name="m3_CTP1">Card type</param>
		/// <param name="m3_MCRD">Main card</param>
		/// <param name="m3_RCRD">Replacement card</param>
		/// <param name="m3_CSND">Send to printing</param>
		/// <param name="m3_REFE">Reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCustCard(
			string m3_CUNO, 
			decimal m3_CCNR, 
			int? m3_BLD1 = null, 
			int? m3_VTMM = null, 
			int? m3_VTYY = null, 
			DateTime? m3_ORDT = null, 
			int? m3_BLCD = null, 
			int? m3_CTP1 = null, 
			string m3_MCRD = null, 
			int? m3_RCRD = null, 
			int? m3_CSND = null, 
			string m3_REFE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCustCard",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("CCNR", m3_CCNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_BLD1.HasValue)
				request.WithQueryParameter("BLD1", m3_BLD1.Value.ToString());
			if (m3_VTMM.HasValue)
				request.WithQueryParameter("VTMM", m3_VTMM.Value.ToString());
			if (m3_VTYY.HasValue)
				request.WithQueryParameter("VTYY", m3_VTYY.Value.ToString());
			if (m3_ORDT.HasValue)
				request.WithQueryParameter("ORDT", m3_ORDT.Value.ToM3String());
			if (m3_BLCD.HasValue)
				request.WithQueryParameter("BLCD", m3_BLCD.Value.ToString());
			if (m3_CTP1.HasValue)
				request.WithQueryParameter("CTP1", m3_CTP1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MCRD))
				request.WithQueryParameter("MCRD", m3_MCRD.Trim());
			if (m3_RCRD.HasValue)
				request.WithQueryParameter("RCRD", m3_RCRD.Value.ToString());
			if (m3_CSND.HasValue)
				request.WithQueryParameter("CSND", m3_CSND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REFE))
				request.WithQueryParameter("REFE", m3_REFE.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
