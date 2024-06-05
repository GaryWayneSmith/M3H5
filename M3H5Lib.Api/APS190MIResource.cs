/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.APS190MI;
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
	/// Name: APS190MI
	/// Component Name: SupplierPaymentBankConf
	/// Description: Supplier payments, report bank confirmation interface
	/// Version Release: 14.x
	///</summary>
	public partial class APS190MIResource : M3BaseResourceEndpoint
	{
		public APS190MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APS190MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCharge
		/// Description Add Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3DADN">Debit advice no (Required)</param>
		/// <param name="m3DADA">Debit advice date (Required)</param>
		/// <param name="m3CRGI">Charge (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CHAM">Charge amount</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3VTAM">Not used in Movex Std from build 3</param>
		/// <param name="m3BVTM">Not used in Movex Std from build 3</param>
		/// <param name="m3PRPN">Payment proposal</param>
		/// <param name="m3PYON">Payment order</param>
		/// <param name="m3PRNB">Payment reference number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCharge(
			string m3DIVI, 
			string m3BKID, 
			decimal m3DADN, 
			DateTime m3DADA, 
			string m3CRGI, 
			int? m3CONO = null, 
			decimal? m3CHAM = null, 
			string m3CUCD = null, 
			int? m3VTCD = null, 
			decimal? m3VTAM = null, 
			decimal? m3BVTM = null, 
			long? m3PRPN = null, 
			int? m3PYON = null, 
			decimal? m3PRNB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));
			if (string.IsNullOrWhiteSpace(m3CRGI))
				throw new ArgumentNullException(nameof(m3CRGI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim())
				.WithQueryParameter("DADN", m3DADN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DADA", m3DADA.ToM3String())
				.WithQueryParameter("CRGI", m3CRGI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHAM.HasValue)
				request.WithQueryParameter("CHAM", m3CHAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VTAM.HasValue)
				request.WithQueryParameter("VTAM", m3VTAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BVTM.HasValue)
				request.WithQueryParameter("BVTM", m3BVTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRPN.HasValue)
				request.WithQueryParameter("PRPN", m3PRPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PYON.HasValue)
				request.WithQueryParameter("PYON", m3PYON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNB.HasValue)
				request.WithQueryParameter("PRNB", m3PRNB.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddHead
		/// Description Add Head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3DADN">Debit advice no (Required)</param>
		/// <param name="m3DADA">Debit advice date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRPN">Payment proposal</param>
		/// <param name="m3PYON">Payment order</param>
		/// <param name="m3PRNB">Payment reference number</param>
		/// <param name="m3LINH">Line item no</param>
		/// <param name="m3PMDA">Payment order date</param>
		/// <param name="m3PYCU">Paid amount currency</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ORAT">Original exchange rate</param>
		/// <param name="m3EVEN">Accounting event</param>
		/// <param name="m3BAFE">Bank confirmation</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3POAM">Reported amount</param>
		/// <param name="m3CUPA">Currency</param>
		/// <param name="m3POSD">Posting date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3PYME">Payment method - accounts payable</param>
		/// <param name="m3TRAN">Yes/no</param>
		/// <param name="m3PYRD">Payment reference date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddHead(
			string m3DIVI, 
			string m3BKID, 
			decimal m3DADN, 
			DateTime m3DADA, 
			int? m3CONO = null, 
			long? m3PRPN = null, 
			int? m3PYON = null, 
			decimal? m3PRNB = null, 
			int? m3LINH = null, 
			DateTime? m3PMDA = null, 
			decimal? m3PYCU = null, 
			string m3CUCD = null, 
			decimal? m3ORAT = null, 
			string m3EVEN = null, 
			int? m3BAFE = null, 
			decimal? m3ARAT = null, 
			decimal? m3POAM = null, 
			string m3CUPA = null, 
			DateTime? m3POSD = null, 
			string m3STAT = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3PYME = null, 
			int? m3TRAN = null, 
			DateTime? m3PYRD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim())
				.WithQueryParameter("DADN", m3DADN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DADA", m3DADA.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRPN.HasValue)
				request.WithQueryParameter("PRPN", m3PRPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PYON.HasValue)
				request.WithQueryParameter("PYON", m3PYON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNB.HasValue)
				request.WithQueryParameter("PRNB", m3PRNB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LINH.HasValue)
				request.WithQueryParameter("LINH", m3LINH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PMDA.HasValue)
				request.WithQueryParameter("PMDA", m3PMDA.Value.ToM3String());
			if (m3PYCU.HasValue)
				request.WithQueryParameter("PYCU", m3PYCU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ORAT.HasValue)
				request.WithQueryParameter("ORAT", m3ORAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVEN))
				request.WithQueryParameter("EVEN", m3EVEN.Trim());
			if (m3BAFE.HasValue)
				request.WithQueryParameter("BAFE", m3BAFE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POAM.HasValue)
				request.WithQueryParameter("POAM", m3POAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (m3POSD.HasValue)
				request.WithQueryParameter("POSD", m3POSD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYME))
				request.WithQueryParameter("PYME", m3PYME.Trim());
			if (m3TRAN.HasValue)
				request.WithQueryParameter("TRAN", m3TRAN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PYRD.HasValue)
				request.WithQueryParameter("PYRD", m3PYRD.Value.ToM3String());

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
		/// Name GetHead
		/// Description Get Head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PRNB">Payment reference number (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3DADN">Debit advice no (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3DIVI, 
			decimal m3PRNB, 
			string m3BKID, 
			decimal m3DADN, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PRNB", m3PRNB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BKID", m3BKID.Trim())
				.WithQueryParameter("DADN", m3DADN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name LstHeadByBank
		/// Description List Header information by bank account identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNB">Payment reference number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByBankResponse></returns>
		/// <exception cref="M3Exception<LstHeadByBankResponse>"></exception>
		public async Task<M3Response<LstHeadByBankResponse>> LstHeadByBank(
			string m3DIVI, 
			string m3BKID, 
			int? m3CONO = null, 
			decimal? m3PRNB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstHeadByBank",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNB.HasValue)
				request.WithQueryParameter("PRNB", m3PRNB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstHeadByBankResponse>(
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
		/// Name UpdHead
		/// Description Update Head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3DADN">Debit advice no (Required)</param>
		/// <param name="m3DADA">Debit advice date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRPN">Payment proposal</param>
		/// <param name="m3PYON">Payment order</param>
		/// <param name="m3PRNB">Payment reference number</param>
		/// <param name="m3LINH">Line item no</param>
		/// <param name="m3PMDA">Payment order date</param>
		/// <param name="m3PYCU">Paid amount currency</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ORAT">Original exchange rate</param>
		/// <param name="m3EVEN">Accounting event</param>
		/// <param name="m3BAFE">Bank confirmation</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="m3POAM">Reported amount</param>
		/// <param name="m3CUPA">Currency</param>
		/// <param name="m3POSD">Posting date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3PYME">Payment method - accounts payable</param>
		/// <param name="m3TRAN">Yes/no</param>
		/// <param name="m3PYRD">Payment reference date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHead(
			string m3DIVI, 
			string m3BKID, 
			decimal m3DADN, 
			DateTime m3DADA, 
			int? m3CONO = null, 
			long? m3PRPN = null, 
			int? m3PYON = null, 
			decimal? m3PRNB = null, 
			int? m3LINH = null, 
			DateTime? m3PMDA = null, 
			decimal? m3PYCU = null, 
			string m3CUCD = null, 
			decimal? m3ORAT = null, 
			string m3EVEN = null, 
			int? m3BAFE = null, 
			decimal? m3ARAT = null, 
			decimal? m3POAM = null, 
			string m3CUPA = null, 
			DateTime? m3POSD = null, 
			string m3STAT = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3PYME = null, 
			int? m3TRAN = null, 
			DateTime? m3PYRD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim())
				.WithQueryParameter("DADN", m3DADN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DADA", m3DADA.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRPN.HasValue)
				request.WithQueryParameter("PRPN", m3PRPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PYON.HasValue)
				request.WithQueryParameter("PYON", m3PYON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNB.HasValue)
				request.WithQueryParameter("PRNB", m3PRNB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LINH.HasValue)
				request.WithQueryParameter("LINH", m3LINH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PMDA.HasValue)
				request.WithQueryParameter("PMDA", m3PMDA.Value.ToM3String());
			if (m3PYCU.HasValue)
				request.WithQueryParameter("PYCU", m3PYCU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ORAT.HasValue)
				request.WithQueryParameter("ORAT", m3ORAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVEN))
				request.WithQueryParameter("EVEN", m3EVEN.Trim());
			if (m3BAFE.HasValue)
				request.WithQueryParameter("BAFE", m3BAFE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POAM.HasValue)
				request.WithQueryParameter("POAM", m3POAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (m3POSD.HasValue)
				request.WithQueryParameter("POSD", m3POSD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYME))
				request.WithQueryParameter("PYME", m3PYME.Trim());
			if (m3TRAN.HasValue)
				request.WithQueryParameter("TRAN", m3TRAN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PYRD.HasValue)
				request.WithQueryParameter("PYRD", m3PYRD.Value.ToM3String());

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
