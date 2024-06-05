/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.TXS910MI;
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
	/// Name: TXS910MI
	/// Component Name: TaxInvoices
	/// Description: Tax Invoices for South Korea
	/// Version Release: 5ea0
	///</summary>
	public partial class TXS910MIResource : M3BaseResourceEndpoint
	{
		public TXS910MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "TXS910MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add tax invoice
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_TIAN">Approval number (Required)</param>
		/// <param name="m3_VRNO">VAT registration number (Required)</param>
		/// <param name="m3_TIFN">File name (Required)</param>
		/// <param name="m3_TIVN">Supplier name</param>
		/// <param name="m3_TICP">Supplier contact person</param>
		/// <param name="m3_TIAD">Address</param>
		/// <param name="m3_TIEM">Email</param>
		/// <param name="m3_TICR">Creation date for tax invoice</param>
		/// <param name="m3_TIID">Issue date</param>
		/// <param name="m3_GAMT">Gross amount</param>
		/// <param name="m3_VTAM">VAT</param>
		/// <param name="m3_NAMT">Net amount</param>
		/// <param name="m3_TIT1">Type of tax invoice</param>
		/// <param name="m3_TIT2">Type of tax invoice 2</param>
		/// <param name="m3_TIIT">Issue type</param>
		/// <param name="m3_TIRR">Unpaid/paid</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_DIVI, 
			string m3_BSCD, 
			string m3_TIAN, 
			string m3_VRNO, 
			string m3_TIFN, 
			string m3_TIVN = null, 
			string m3_TICP = null, 
			string m3_TIAD = null, 
			string m3_TIEM = null, 
			DateTime? m3_TICR = null, 
			DateTime? m3_TIID = null, 
			decimal? m3_GAMT = null, 
			decimal? m3_VTAM = null, 
			decimal? m3_NAMT = null, 
			string m3_TIT1 = null, 
			string m3_TIT2 = null, 
			string m3_TIIT = null, 
			string m3_TIRR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_TIAN))
				throw new ArgumentNullException("m3_TIAN");
			if (string.IsNullOrWhiteSpace(m3_VRNO))
				throw new ArgumentNullException("m3_VRNO");
			if (string.IsNullOrWhiteSpace(m3_TIFN))
				throw new ArgumentNullException("m3_TIFN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("TIAN", m3_TIAN.Trim())
				.WithQueryParameter("VRNO", m3_VRNO.Trim())
				.WithQueryParameter("TIFN", m3_TIFN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TIVN))
				request.WithQueryParameter("TIVN", m3_TIVN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TICP))
				request.WithQueryParameter("TICP", m3_TICP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIAD))
				request.WithQueryParameter("TIAD", m3_TIAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIEM))
				request.WithQueryParameter("TIEM", m3_TIEM.Trim());
			if (m3_TICR.HasValue)
				request.WithQueryParameter("TICR", m3_TICR.Value.ToM3String());
			if (m3_TIID.HasValue)
				request.WithQueryParameter("TIID", m3_TIID.Value.ToM3String());
			if (m3_GAMT.HasValue)
				request.WithQueryParameter("GAMT", m3_GAMT.Value.ToString());
			if (m3_VTAM.HasValue)
				request.WithQueryParameter("VTAM", m3_VTAM.Value.ToString());
			if (m3_NAMT.HasValue)
				request.WithQueryParameter("NAMT", m3_NAMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TIT1))
				request.WithQueryParameter("TIT1", m3_TIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT2))
				request.WithQueryParameter("TIT2", m3_TIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIIT))
				request.WithQueryParameter("TIIT", m3_TIIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIRR))
				request.WithQueryParameter("TIRR", m3_TIRR.Trim());

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
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_TIAN">Approval number (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_DIVI, 
			string m3_BSCD, 
			string m3_TIAN, 
			string m3_SUNO, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_TIAN))
				throw new ArgumentNullException("m3_TIAN");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("TIAN", m3_TIAN.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

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
		/// Name List
		/// Description List records
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_TIAN">Approval number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_DIVI, 
			string m3_BSCD, 
			string m3_TIAN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BSCD", m3_BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TIAN))
				request.WithQueryParameter("TIAN", m3_TIAN.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
