/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PYAG">Payer agreement (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3TIAM">Labor</param>
		/// <param name="m3MAA1">Material</param>
		/// <param name="m3SUAM">Subcontract</param>
		/// <param name="m3MIA1">Miscellaneous</param>
		/// <param name="m3LOA3">Loan</param>
		/// <param name="m3TIP1">Labor %</param>
		/// <param name="m3MAP1">Material %</param>
		/// <param name="m3SUP1">Subcontract %</param>
		/// <param name="m3MIP1">Miscellaneous %</param>
		/// <param name="m3LOP1">Loan percent</param>
		/// <param name="m3ASBO">Service bill of material</param>
		/// <param name="m3ACWA">Claim warranty</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3AAGN, 
			int m3SRVP, 
			string m3PYNO, 
			string m3PYAG, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			DateTime? m3STDT = null, 
			decimal? m3TIAM = null, 
			decimal? m3MAA1 = null, 
			decimal? m3SUAM = null, 
			decimal? m3MIA1 = null, 
			decimal? m3LOA3 = null, 
			int? m3TIP1 = null, 
			int? m3MAP1 = null, 
			int? m3SUP1 = null, 
			int? m3MIP1 = null, 
			int? m3LOP1 = null, 
			int? m3ASBO = null, 
			int? m3ACWA = null, 
			decimal? m3TXID = null, 
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
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3PYAG))
				throw new ArgumentNullException(nameof(m3PYAG));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("PYAG", m3PYAG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3TIAM.HasValue)
				request.WithQueryParameter("TIAM", m3TIAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAA1.HasValue)
				request.WithQueryParameter("MAA1", m3MAA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUAM.HasValue)
				request.WithQueryParameter("SUAM", m3SUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIA1.HasValue)
				request.WithQueryParameter("MIA1", m3MIA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOA3.HasValue)
				request.WithQueryParameter("LOA3", m3LOA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TIP1.HasValue)
				request.WithQueryParameter("TIP1", m3TIP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAP1.HasValue)
				request.WithQueryParameter("MAP1", m3MAP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3SUP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIP1.HasValue)
				request.WithQueryParameter("MIP1", m3MIP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOP1.HasValue)
				request.WithQueryParameter("LOP1", m3LOP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3ASBO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3ACWA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Del
		/// Description This transaction should be removed. Use Dlt instead
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3AAGN, 
			int m3SRVP, 
			string m3PYNO, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			DateTime? m3STDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYNO", m3PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());

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
		/// Name Dlt
		/// Description Delete transaction
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3AAGN, 
			int m3SRVP, 
			string m3PYNO, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			DateTime? m3STDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYNO", m3PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());

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
		/// Name Get
		/// Description Get
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3AAGN, 
			int m3SRVP, 
			string m3PYNO, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			DateTime? m3STDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYNO", m3PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description Lst
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3AAGN, 
			int m3SRVP, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			DateTime? m3STDT = null, 
			string m3PYNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Upd
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AAGN">Agreement (Required)</param>
		/// <param name="m3SRVP">Service price method (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3PYAG">Payer agreement</param>
		/// <param name="m3TIAM">Labor</param>
		/// <param name="m3MAA1">Material</param>
		/// <param name="m3SUAM">Subcontract</param>
		/// <param name="m3MIA1">Miscellaneous</param>
		/// <param name="m3LOA3">Loan</param>
		/// <param name="m3TIP1">Labor %</param>
		/// <param name="m3MAP1">Material %</param>
		/// <param name="m3SUP1">Subcontract %</param>
		/// <param name="m3MIP1">Miscellaneous %</param>
		/// <param name="m3LOP1">Loan percent</param>
		/// <param name="m3ASBO">Service bill of material</param>
		/// <param name="m3ACWA">Claim warranty</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3AAGN, 
			int m3SRVP, 
			string m3PYNO, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			DateTime? m3STDT = null, 
			string m3PYAG = null, 
			decimal? m3TIAM = null, 
			decimal? m3MAA1 = null, 
			decimal? m3SUAM = null, 
			decimal? m3MIA1 = null, 
			decimal? m3LOA3 = null, 
			int? m3TIP1 = null, 
			int? m3MAP1 = null, 
			int? m3SUP1 = null, 
			int? m3MIP1 = null, 
			int? m3LOP1 = null, 
			int? m3ASBO = null, 
			int? m3ACWA = null, 
			decimal? m3TXID = null, 
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
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("SRVP", m3SRVP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYNO", m3PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PYAG))
				request.WithQueryParameter("PYAG", m3PYAG.Trim());
			if (m3TIAM.HasValue)
				request.WithQueryParameter("TIAM", m3TIAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAA1.HasValue)
				request.WithQueryParameter("MAA1", m3MAA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUAM.HasValue)
				request.WithQueryParameter("SUAM", m3SUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIA1.HasValue)
				request.WithQueryParameter("MIA1", m3MIA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOA3.HasValue)
				request.WithQueryParameter("LOA3", m3LOA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TIP1.HasValue)
				request.WithQueryParameter("TIP1", m3TIP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAP1.HasValue)
				request.WithQueryParameter("MAP1", m3MAP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3SUP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIP1.HasValue)
				request.WithQueryParameter("MIP1", m3MIP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOP1.HasValue)
				request.WithQueryParameter("LOP1", m3LOP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3ASBO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3ACWA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
