/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCharge
		/// Description Add Charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_DADN">Debit advice no (Required)</param>
		/// <param name="m3_DADA">Debit advice date (Required)</param>
		/// <param name="m3_CRGI">Charge (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CHAM">Charge amount</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_VTAM">Not used in Movex Std from build 3</param>
		/// <param name="m3_BVTM">Not used in Movex Std from build 3</param>
		/// <param name="m3_PRPN">Payment proposal</param>
		/// <param name="m3_PYON">Payment order</param>
		/// <param name="m3_PRNB">Payment reference number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCharge(
			string m3_DIVI, 
			string m3_BKID, 
			decimal m3_DADN, 
			DateTime m3_DADA, 
			string m3_CRGI, 
			int? m3_CONO = null, 
			decimal? m3_CHAM = null, 
			string m3_CUCD = null, 
			int? m3_VTCD = null, 
			decimal? m3_VTAM = null, 
			decimal? m3_BVTM = null, 
			long? m3_PRPN = null, 
			int? m3_PYON = null, 
			decimal? m3_PRNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");
			if (string.IsNullOrWhiteSpace(m3_CRGI))
				throw new ArgumentNullException("m3_CRGI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim())
				.WithQueryParameter("DADN", m3_DADN.ToString())
				.WithQueryParameter("DADA", m3_DADA.ToM3String())
				.WithQueryParameter("CRGI", m3_CRGI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_CHAM.HasValue)
				request.WithQueryParameter("CHAM", m3_CHAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (m3_VTAM.HasValue)
				request.WithQueryParameter("VTAM", m3_VTAM.Value.ToString());
			if (m3_BVTM.HasValue)
				request.WithQueryParameter("BVTM", m3_BVTM.Value.ToString());
			if (m3_PRPN.HasValue)
				request.WithQueryParameter("PRPN", m3_PRPN.Value.ToString());
			if (m3_PYON.HasValue)
				request.WithQueryParameter("PYON", m3_PYON.Value.ToString());
			if (m3_PRNB.HasValue)
				request.WithQueryParameter("PRNB", m3_PRNB.Value.ToString());

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
		/// Name AddHead
		/// Description Add Head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_DADN">Debit advice no (Required)</param>
		/// <param name="m3_DADA">Debit advice date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRPN">Payment proposal</param>
		/// <param name="m3_PYON">Payment order</param>
		/// <param name="m3_PRNB">Payment reference number</param>
		/// <param name="m3_LINH">Line item no</param>
		/// <param name="m3_PMDA">Payment order date</param>
		/// <param name="m3_PYCU">Paid amount currency</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ORAT">Original exchange rate</param>
		/// <param name="m3_EVEN">Accounting event</param>
		/// <param name="m3_BAFE">Bank confirmation</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_POAM">Reported amount</param>
		/// <param name="m3_CUPA">Currency</param>
		/// <param name="m3_POSD">Posting date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_PYME">Payment method - accounts payable</param>
		/// <param name="m3_TRAN">Yes/no</param>
		/// <param name="m3_PYRD">Payment reference date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddHead(
			string m3_DIVI, 
			string m3_BKID, 
			decimal m3_DADN, 
			DateTime m3_DADA, 
			int? m3_CONO = null, 
			long? m3_PRPN = null, 
			int? m3_PYON = null, 
			decimal? m3_PRNB = null, 
			int? m3_LINH = null, 
			DateTime? m3_PMDA = null, 
			decimal? m3_PYCU = null, 
			string m3_CUCD = null, 
			decimal? m3_ORAT = null, 
			string m3_EVEN = null, 
			int? m3_BAFE = null, 
			decimal? m3_ARAT = null, 
			decimal? m3_POAM = null, 
			string m3_CUPA = null, 
			DateTime? m3_POSD = null, 
			string m3_STAT = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_PYME = null, 
			int? m3_TRAN = null, 
			DateTime? m3_PYRD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim())
				.WithQueryParameter("DADN", m3_DADN.ToString())
				.WithQueryParameter("DADA", m3_DADA.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PRPN.HasValue)
				request.WithQueryParameter("PRPN", m3_PRPN.Value.ToString());
			if (m3_PYON.HasValue)
				request.WithQueryParameter("PYON", m3_PYON.Value.ToString());
			if (m3_PRNB.HasValue)
				request.WithQueryParameter("PRNB", m3_PRNB.Value.ToString());
			if (m3_LINH.HasValue)
				request.WithQueryParameter("LINH", m3_LINH.Value.ToString());
			if (m3_PMDA.HasValue)
				request.WithQueryParameter("PMDA", m3_PMDA.Value.ToM3String());
			if (m3_PYCU.HasValue)
				request.WithQueryParameter("PYCU", m3_PYCU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ORAT.HasValue)
				request.WithQueryParameter("ORAT", m3_ORAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVEN))
				request.WithQueryParameter("EVEN", m3_EVEN.Trim());
			if (m3_BAFE.HasValue)
				request.WithQueryParameter("BAFE", m3_BAFE.Value.ToString());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_POAM.HasValue)
				request.WithQueryParameter("POAM", m3_POAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (m3_POSD.HasValue)
				request.WithQueryParameter("POSD", m3_POSD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYME))
				request.WithQueryParameter("PYME", m3_PYME.Trim());
			if (m3_TRAN.HasValue)
				request.WithQueryParameter("TRAN", m3_TRAN.Value.ToString());
			if (m3_PYRD.HasValue)
				request.WithQueryParameter("PYRD", m3_PYRD.Value.ToM3String());

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
		/// Name GetHead
		/// Description Get Head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PRNB">Payment reference number (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_DADN">Debit advice no (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3_DIVI, 
			decimal m3_PRNB, 
			string m3_BKID, 
			decimal m3_DADN, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PRNB", m3_PRNB.ToString())
				.WithQueryParameter("BKID", m3_BKID.Trim())
				.WithQueryParameter("DADN", m3_DADN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name LstHeadByBank
		/// Description List Header information by bank account identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNB">Payment reference number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByBankResponse></returns>
		/// <exception cref="M3Exception<LstHeadByBankResponse>"></exception>
		public async Task<M3Response<LstHeadByBankResponse>> LstHeadByBank(
			string m3_DIVI, 
			string m3_BKID, 
			int? m3_CONO = null, 
			decimal? m3_PRNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHeadByBank",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PRNB.HasValue)
				request.WithQueryParameter("PRNB", m3_PRNB.Value.ToString());

			// Execute the request
			var result = await Execute<LstHeadByBankResponse>(
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
		/// Name UpdHead
		/// Description Update Head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_DADN">Debit advice no (Required)</param>
		/// <param name="m3_DADA">Debit advice date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRPN">Payment proposal</param>
		/// <param name="m3_PYON">Payment order</param>
		/// <param name="m3_PRNB">Payment reference number</param>
		/// <param name="m3_LINH">Line item no</param>
		/// <param name="m3_PMDA">Payment order date</param>
		/// <param name="m3_PYCU">Paid amount currency</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ORAT">Original exchange rate</param>
		/// <param name="m3_EVEN">Accounting event</param>
		/// <param name="m3_BAFE">Bank confirmation</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_POAM">Reported amount</param>
		/// <param name="m3_CUPA">Currency</param>
		/// <param name="m3_POSD">Posting date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_PYME">Payment method - accounts payable</param>
		/// <param name="m3_TRAN">Yes/no</param>
		/// <param name="m3_PYRD">Payment reference date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHead(
			string m3_DIVI, 
			string m3_BKID, 
			decimal m3_DADN, 
			DateTime m3_DADA, 
			int? m3_CONO = null, 
			long? m3_PRPN = null, 
			int? m3_PYON = null, 
			decimal? m3_PRNB = null, 
			int? m3_LINH = null, 
			DateTime? m3_PMDA = null, 
			decimal? m3_PYCU = null, 
			string m3_CUCD = null, 
			decimal? m3_ORAT = null, 
			string m3_EVEN = null, 
			int? m3_BAFE = null, 
			decimal? m3_ARAT = null, 
			decimal? m3_POAM = null, 
			string m3_CUPA = null, 
			DateTime? m3_POSD = null, 
			string m3_STAT = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_PYME = null, 
			int? m3_TRAN = null, 
			DateTime? m3_PYRD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim())
				.WithQueryParameter("DADN", m3_DADN.ToString())
				.WithQueryParameter("DADA", m3_DADA.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PRPN.HasValue)
				request.WithQueryParameter("PRPN", m3_PRPN.Value.ToString());
			if (m3_PYON.HasValue)
				request.WithQueryParameter("PYON", m3_PYON.Value.ToString());
			if (m3_PRNB.HasValue)
				request.WithQueryParameter("PRNB", m3_PRNB.Value.ToString());
			if (m3_LINH.HasValue)
				request.WithQueryParameter("LINH", m3_LINH.Value.ToString());
			if (m3_PMDA.HasValue)
				request.WithQueryParameter("PMDA", m3_PMDA.Value.ToM3String());
			if (m3_PYCU.HasValue)
				request.WithQueryParameter("PYCU", m3_PYCU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ORAT.HasValue)
				request.WithQueryParameter("ORAT", m3_ORAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVEN))
				request.WithQueryParameter("EVEN", m3_EVEN.Trim());
			if (m3_BAFE.HasValue)
				request.WithQueryParameter("BAFE", m3_BAFE.Value.ToString());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_POAM.HasValue)
				request.WithQueryParameter("POAM", m3_POAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (m3_POSD.HasValue)
				request.WithQueryParameter("POSD", m3_POSD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYME))
				request.WithQueryParameter("PYME", m3_PYME.Trim());
			if (m3_TRAN.HasValue)
				request.WithQueryParameter("TRAN", m3_TRAN.Value.ToString());
			if (m3_PYRD.HasValue)
				request.WithQueryParameter("PYRD", m3_PYRD.Value.ToM3String());

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
