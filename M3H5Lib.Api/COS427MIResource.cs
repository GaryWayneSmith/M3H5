/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.COS427MI;
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
	/// Name: COS427MI
	/// Component Name: Agreement Split Invoice
	/// Description: Agreement Split Invoice
	/// Version Release: 5ea0
	///</summary>
	public partial class COS427MIResource : M3BaseResourceEndpoint
	{
		public COS427MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS427MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PYAG">Payer agreement (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_TIAM">Labor</param>
		/// <param name="m3_MAA1">Material</param>
		/// <param name="m3_SUAM">Subcontract</param>
		/// <param name="m3_MIA1">Miscellaneous</param>
		/// <param name="m3_LOA3">Loan</param>
		/// <param name="m3_TIP1">Labor %</param>
		/// <param name="m3_MAP1">Material %</param>
		/// <param name="m3_SUP1">Subcontract %</param>
		/// <param name="m3_MIP1">Miscellaneous %</param>
		/// <param name="m3_LOP1">Loan percent</param>
		/// <param name="m3_ASBO">Service bill of material</param>
		/// <param name="m3_ACWA">Claim warranty</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_AAGN, 
			int m3_SRVP, 
			string m3_PYNO, 
			string m3_PYAG, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			DateTime? m3_STDT = null, 
			decimal? m3_TIAM = null, 
			decimal? m3_MAA1 = null, 
			decimal? m3_SUAM = null, 
			decimal? m3_MIA1 = null, 
			decimal? m3_LOA3 = null, 
			int? m3_TIP1 = null, 
			int? m3_MAP1 = null, 
			int? m3_SUP1 = null, 
			int? m3_MIP1 = null, 
			int? m3_LOP1 = null, 
			int? m3_ASBO = null, 
			int? m3_ACWA = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");
			if (string.IsNullOrWhiteSpace(m3_PYAG))
				throw new ArgumentNullException("m3_PYAG");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString())
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("PYAG", m3_PYAG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_TIAM.HasValue)
				request.WithQueryParameter("TIAM", m3_TIAM.Value.ToString());
			if (m3_MAA1.HasValue)
				request.WithQueryParameter("MAA1", m3_MAA1.Value.ToString());
			if (m3_SUAM.HasValue)
				request.WithQueryParameter("SUAM", m3_SUAM.Value.ToString());
			if (m3_MIA1.HasValue)
				request.WithQueryParameter("MIA1", m3_MIA1.Value.ToString());
			if (m3_LOA3.HasValue)
				request.WithQueryParameter("LOA3", m3_LOA3.Value.ToString());
			if (m3_TIP1.HasValue)
				request.WithQueryParameter("TIP1", m3_TIP1.Value.ToString());
			if (m3_MAP1.HasValue)
				request.WithQueryParameter("MAP1", m3_MAP1.Value.ToString());
			if (m3_SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3_SUP1.Value.ToString());
			if (m3_MIP1.HasValue)
				request.WithQueryParameter("MIP1", m3_MIP1.Value.ToString());
			if (m3_LOP1.HasValue)
				request.WithQueryParameter("LOP1", m3_LOP1.Value.ToString());
			if (m3_ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3_ASBO.Value.ToString());
			if (m3_ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3_ACWA.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name Del
		/// Description This transaction should be removed. Use Dlt instead
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3_AAGN, 
			int m3_SRVP, 
			string m3_PYNO, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			DateTime? m3_STDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString())
				.WithQueryParameter("PYNO", m3_PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());

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
		/// Name Dlt
		/// Description Delete transaction
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3_AAGN, 
			int m3_SRVP, 
			string m3_PYNO, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			DateTime? m3_STDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString())
				.WithQueryParameter("PYNO", m3_PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());

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
		/// Name Get
		/// Description Get
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_AAGN, 
			int m3_SRVP, 
			string m3_PYNO, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			DateTime? m3_STDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString())
				.WithQueryParameter("PYNO", m3_PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description Lst
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_AAGN, 
			int m3_SRVP, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			DateTime? m3_STDT = null, 
			string m3_PYNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Upd
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AAGN">Agreement (Required)</param>
		/// <param name="m3_SRVP">Service price method (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_PYAG">Payer agreement</param>
		/// <param name="m3_TIAM">Labor</param>
		/// <param name="m3_MAA1">Material</param>
		/// <param name="m3_SUAM">Subcontract</param>
		/// <param name="m3_MIA1">Miscellaneous</param>
		/// <param name="m3_LOA3">Loan</param>
		/// <param name="m3_TIP1">Labor %</param>
		/// <param name="m3_MAP1">Material %</param>
		/// <param name="m3_SUP1">Subcontract %</param>
		/// <param name="m3_MIP1">Miscellaneous %</param>
		/// <param name="m3_LOP1">Loan percent</param>
		/// <param name="m3_ASBO">Service bill of material</param>
		/// <param name="m3_ACWA">Claim warranty</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_AAGN, 
			int m3_SRVP, 
			string m3_PYNO, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			DateTime? m3_STDT = null, 
			string m3_PYAG = null, 
			decimal? m3_TIAM = null, 
			decimal? m3_MAA1 = null, 
			decimal? m3_SUAM = null, 
			decimal? m3_MIA1 = null, 
			decimal? m3_LOA3 = null, 
			int? m3_TIP1 = null, 
			int? m3_MAP1 = null, 
			int? m3_SUP1 = null, 
			int? m3_MIP1 = null, 
			int? m3_LOP1 = null, 
			int? m3_ASBO = null, 
			int? m3_ACWA = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("SRVP", m3_SRVP.ToString())
				.WithQueryParameter("PYNO", m3_PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PYAG))
				request.WithQueryParameter("PYAG", m3_PYAG.Trim());
			if (m3_TIAM.HasValue)
				request.WithQueryParameter("TIAM", m3_TIAM.Value.ToString());
			if (m3_MAA1.HasValue)
				request.WithQueryParameter("MAA1", m3_MAA1.Value.ToString());
			if (m3_SUAM.HasValue)
				request.WithQueryParameter("SUAM", m3_SUAM.Value.ToString());
			if (m3_MIA1.HasValue)
				request.WithQueryParameter("MIA1", m3_MIA1.Value.ToString());
			if (m3_LOA3.HasValue)
				request.WithQueryParameter("LOA3", m3_LOA3.Value.ToString());
			if (m3_TIP1.HasValue)
				request.WithQueryParameter("TIP1", m3_TIP1.Value.ToString());
			if (m3_MAP1.HasValue)
				request.WithQueryParameter("MAP1", m3_MAP1.Value.ToString());
			if (m3_SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3_SUP1.Value.ToString());
			if (m3_MIP1.HasValue)
				request.WithQueryParameter("MIP1", m3_MIP1.Value.ToString());
			if (m3_LOP1.HasValue)
				request.WithQueryParameter("LOP1", m3_LOP1.Value.ToString());
			if (m3_ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3_ASBO.Value.ToString());
			if (m3_ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3_ACWA.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
