/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add tax invoice
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3TIAN">Approval number (Required)</param>
		/// <param name="m3VRNO">VAT registration number (Required)</param>
		/// <param name="m3TIFN">File name (Required)</param>
		/// <param name="m3TIVN">Supplier name</param>
		/// <param name="m3TICP">Supplier contact person</param>
		/// <param name="m3TIAD">Address</param>
		/// <param name="m3TIEM">Email</param>
		/// <param name="m3TICR">Creation date for tax invoice</param>
		/// <param name="m3TIID">Issue date</param>
		/// <param name="m3GAMT">Gross amount</param>
		/// <param name="m3VTAM">VAT</param>
		/// <param name="m3NAMT">Net amount</param>
		/// <param name="m3TIT1">Type of tax invoice</param>
		/// <param name="m3TIT2">Type of tax invoice 2</param>
		/// <param name="m3TIIT">Issue type</param>
		/// <param name="m3TIRR">Unpaid/paid</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3DIVI, 
			string m3BSCD, 
			string m3TIAN, 
			string m3VRNO, 
			string m3TIFN, 
			string m3TIVN = null, 
			string m3TICP = null, 
			string m3TIAD = null, 
			string m3TIEM = null, 
			DateTime? m3TICR = null, 
			DateTime? m3TIID = null, 
			decimal? m3GAMT = null, 
			decimal? m3VTAM = null, 
			decimal? m3NAMT = null, 
			string m3TIT1 = null, 
			string m3TIT2 = null, 
			string m3TIIT = null, 
			string m3TIRR = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));
			if (string.IsNullOrWhiteSpace(m3TIAN))
				throw new ArgumentNullException(nameof(m3TIAN));
			if (string.IsNullOrWhiteSpace(m3VRNO))
				throw new ArgumentNullException(nameof(m3VRNO));
			if (string.IsNullOrWhiteSpace(m3TIFN))
				throw new ArgumentNullException(nameof(m3TIFN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("TIAN", m3TIAN.Trim())
				.WithQueryParameter("VRNO", m3VRNO.Trim())
				.WithQueryParameter("TIFN", m3TIFN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TIVN))
				request.WithQueryParameter("TIVN", m3TIVN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TICP))
				request.WithQueryParameter("TICP", m3TICP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIAD))
				request.WithQueryParameter("TIAD", m3TIAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIEM))
				request.WithQueryParameter("TIEM", m3TIEM.Trim());
			if (m3TICR.HasValue)
				request.WithQueryParameter("TICR", m3TICR.Value.ToM3String());
			if (m3TIID.HasValue)
				request.WithQueryParameter("TIID", m3TIID.Value.ToM3String());
			if (m3GAMT.HasValue)
				request.WithQueryParameter("GAMT", m3GAMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTAM.HasValue)
				request.WithQueryParameter("VTAM", m3VTAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NAMT.HasValue)
				request.WithQueryParameter("NAMT", m3NAMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TIT1))
				request.WithQueryParameter("TIT1", m3TIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT2))
				request.WithQueryParameter("TIT2", m3TIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIIT))
				request.WithQueryParameter("TIIT", m3TIIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIRR))
				request.WithQueryParameter("TIRR", m3TIRR.Trim());

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
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3TIAN">Approval number (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3DIVI, 
			string m3BSCD, 
			string m3TIAN, 
			string m3SUNO, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));
			if (string.IsNullOrWhiteSpace(m3TIAN))
				throw new ArgumentNullException(nameof(m3TIAN));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSCD", m3BSCD.Trim())
				.WithQueryParameter("TIAN", m3TIAN.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim());

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
		/// Name List
		/// Description List records
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3TIAN">Approval number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3DIVI, 
			string m3BSCD, 
			string m3TIAN = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/List",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BSCD", m3BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TIAN))
				request.WithQueryParameter("TIAN", m3TIAN.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
