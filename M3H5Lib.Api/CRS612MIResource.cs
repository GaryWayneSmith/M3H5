/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CCNR">Customer card number (Required)</param>
		/// <param name="m3BLD1">Blocking date</param>
		/// <param name="m3VTMM">Valid through month</param>
		/// <param name="m3VTYY">Valid through year</param>
		/// <param name="m3ORDT">Order date</param>
		/// <param name="m3BLCD">Blocking code</param>
		/// <param name="m3CTP1">Card type</param>
		/// <param name="m3MCRD">Main card</param>
		/// <param name="m3RCRD">Replacement card</param>
		/// <param name="m3CSND">Send to printing</param>
		/// <param name="m3REFE">Reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustCard(
			string m3CUNO, 
			decimal m3CCNR, 
			int? m3BLD1 = null, 
			int? m3VTMM = null, 
			int? m3VTYY = null, 
			DateTime? m3ORDT = null, 
			int? m3BLCD = null, 
			int? m3CTP1 = null, 
			string m3MCRD = null, 
			int? m3RCRD = null, 
			int? m3CSND = null, 
			string m3REFE = null, 
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
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("CCNR", m3CCNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3BLD1.HasValue)
				request.WithQueryParameter("BLD1", m3BLD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTMM.HasValue)
				request.WithQueryParameter("VTMM", m3VTMM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTYY.HasValue)
				request.WithQueryParameter("VTYY", m3VTYY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORDT.HasValue)
				request.WithQueryParameter("ORDT", m3ORDT.Value.ToM3String());
			if (m3BLCD.HasValue)
				request.WithQueryParameter("BLCD", m3BLCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CTP1.HasValue)
				request.WithQueryParameter("CTP1", m3CTP1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCRD))
				request.WithQueryParameter("MCRD", m3MCRD.Trim());
			if (m3RCRD.HasValue)
				request.WithQueryParameter("RCRD", m3RCRD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSND.HasValue)
				request.WithQueryParameter("CSND", m3CSND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REFE))
				request.WithQueryParameter("REFE", m3REFE.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name DelCustCard
		/// Description This transaction deletes customer card
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CCNR">Customer card number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelCustCard(
			string m3CUNO, 
			decimal m3CCNR, 
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
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("CCNR", m3CCNR.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name GetCustCard
		/// Description This transaction displays customer card
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CCNR">Customer card number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustCardResponse></returns>
		/// <exception cref="M3Exception<GetCustCardResponse>"></exception>
		public async Task<M3Response<GetCustCardResponse>> GetCustCard(
			string m3CUNO, 
			decimal m3CCNR, 
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
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("CCNR", m3CCNR.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetCustCardResponse>(
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
		/// Name LstCustCard
		/// Description This transaction lists customer card
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3CCNR">Customer card number</param>
		/// <param name="m3CTP1">Card type</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="m3REFE">Reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustCardResponse></returns>
		/// <exception cref="M3Exception<LstCustCardResponse>"></exception>
		public async Task<M3Response<LstCustCardResponse>> LstCustCard(
			string m3CUNO = null, 
			decimal? m3CCNR = null, 
			int? m3CTP1 = null, 
			DateTime? m3LMDT = null, 
			string m3REFE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3CCNR.HasValue)
				request.WithQueryParameter("CCNR", m3CCNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CTP1.HasValue)
				request.WithQueryParameter("CTP1", m3CTP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3REFE))
				request.WithQueryParameter("REFE", m3REFE.Trim());

			// Execute the request
			var result = await Execute<LstCustCardResponse>(
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
		/// Name UpdCustCard
		/// Description This transaction updates customer card
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CCNR">Customer card number (Required)</param>
		/// <param name="m3BLD1">Blocking date</param>
		/// <param name="m3VTMM">Valid through month</param>
		/// <param name="m3VTYY">Valid through year</param>
		/// <param name="m3ORDT">Order date</param>
		/// <param name="m3BLCD">Blocking code</param>
		/// <param name="m3CTP1">Card type</param>
		/// <param name="m3MCRD">Main card</param>
		/// <param name="m3RCRD">Replacement card</param>
		/// <param name="m3CSND">Send to printing</param>
		/// <param name="m3REFE">Reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCustCard(
			string m3CUNO, 
			decimal m3CCNR, 
			int? m3BLD1 = null, 
			int? m3VTMM = null, 
			int? m3VTYY = null, 
			DateTime? m3ORDT = null, 
			int? m3BLCD = null, 
			int? m3CTP1 = null, 
			string m3MCRD = null, 
			int? m3RCRD = null, 
			int? m3CSND = null, 
			string m3REFE = null, 
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
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("CCNR", m3CCNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3BLD1.HasValue)
				request.WithQueryParameter("BLD1", m3BLD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTMM.HasValue)
				request.WithQueryParameter("VTMM", m3VTMM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTYY.HasValue)
				request.WithQueryParameter("VTYY", m3VTYY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORDT.HasValue)
				request.WithQueryParameter("ORDT", m3ORDT.Value.ToM3String());
			if (m3BLCD.HasValue)
				request.WithQueryParameter("BLCD", m3BLCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CTP1.HasValue)
				request.WithQueryParameter("CTP1", m3CTP1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MCRD))
				request.WithQueryParameter("MCRD", m3MCRD.Trim());
			if (m3RCRD.HasValue)
				request.WithQueryParameter("RCRD", m3RCRD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSND.HasValue)
				request.WithQueryParameter("CSND", m3CSND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REFE))
				request.WithQueryParameter("REFE", m3REFE.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
