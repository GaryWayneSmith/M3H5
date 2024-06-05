/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS692MI;
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
	/// Name: CRS692MI
	/// Component Name: BankAccount
	/// Description: Bank account interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS692MIResource : M3BaseResourceEndpoint
	{
		public CRS692MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS692MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBankAccount
		/// Description Add a new bank account
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BKTP">Bank account type (Required)</param>
		/// <param name="m3_ACHO">Account holder (Required)</param>
		/// <param name="m3_BKIN">Bank account indicator (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_CBPY">Bank priority (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_BANA">Bank account name (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_BKNO">Bank number</param>
		/// <param name="m3_BBRN">Bank branch identity</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_BAF1">Bank account field 1</param>
		/// <param name="m3_BAF2">Bank account field 2</param>
		/// <param name="m3_BAF3">Bank account field 3</param>
		/// <param name="m3_BAF4">Bank account field 4</param>
		/// <param name="m3_BAF5">Bank account field 5</param>
		/// <param name="m3_BKPL">Banking region</param>
		/// <param name="m3_ARTP">Remittance method</param>
		/// <param name="m3_BMDA">Maximum discountable amount</param>
		/// <param name="m3_BMCA">Maximum collection amount</param>
		/// <param name="m3_FCDC">Fixed discount charge</param>
		/// <param name="m3_BIDC">Discount rate</param>
		/// <param name="m3_BMDI">Minimum number of days for interest</param>
		/// <param name="m3_FCCO">Fixed collection charges</param>
		/// <param name="m3_DNOV">Discounted amount not overdue</param>
		/// <param name="m3_CNOV">Cash remittance not overdue</param>
		/// <param name="m3_BKAG">Bank EDI agreement number</param>
		/// <param name="m3_FINC">Financial institution</param>
		/// <param name="m3_C1QF">Code list - qualifier</param>
		/// <param name="m3_C1RA">Code list - responsible agent</param>
		/// <param name="m3_FIAN">Account number at financial institution</param>
		/// <param name="m3_BRNO">Branch number</param>
		/// <param name="m3_C2QF">Code list - qualifier</param>
		/// <param name="m3_C2RA">Code list - responsible agent</param>
		/// <param name="m3_FICU">Customer number at financial institution</param>
		/// <param name="m3_NCHL">Number of lines</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_NODY">Number of days risk</param>
		/// <param name="m3_EBAT">Employee bank account type</param>
		/// <param name="m3_PYTK">Payment type key</param>
		/// <param name="m3_CSTC">Cost allocation code</param>
		/// <param name="m3_IBAN">International bank account number</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_CIDN">Creditor identifier number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBankAccount(
			string m3_DIVI, 
			int m3_BKTP, 
			string m3_ACHO, 
			string m3_BKIN, 
			string m3_BKID, 
			int m3_CBPY, 
			string m3_STAT, 
			string m3_BANA, 
			string m3_LNCD, 
			string m3_BKNO = null, 
			string m3_BBRN = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_CUCD = null, 
			string m3_BAF1 = null, 
			string m3_BAF2 = null, 
			string m3_BAF3 = null, 
			string m3_BAF4 = null, 
			string m3_BAF5 = null, 
			string m3_BKPL = null, 
			int? m3_ARTP = null, 
			decimal? m3_BMDA = null, 
			decimal? m3_BMCA = null, 
			decimal? m3_FCDC = null, 
			int? m3_BIDC = null, 
			int? m3_BMDI = null, 
			decimal? m3_FCCO = null, 
			decimal? m3_DNOV = null, 
			decimal? m3_CNOV = null, 
			string m3_BKAG = null, 
			string m3_FINC = null, 
			string m3_C1QF = null, 
			string m3_C1RA = null, 
			string m3_FIAN = null, 
			string m3_BRNO = null, 
			string m3_C2QF = null, 
			string m3_C2RA = null, 
			string m3_FICU = null, 
			int? m3_NCHL = null, 
			string m3_PYCD = null, 
			int? m3_NODY = null, 
			string m3_EBAT = null, 
			int? m3_PYTK = null, 
			int? m3_CSTC = null, 
			string m3_IBAN = null, 
			string m3_ACGR = null, 
			string m3_CIDN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBankAccount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ACHO))
				throw new ArgumentNullException("m3_ACHO");
			if (string.IsNullOrWhiteSpace(m3_BKIN))
				throw new ArgumentNullException("m3_BKIN");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");
			if (string.IsNullOrWhiteSpace(m3_BANA))
				throw new ArgumentNullException("m3_BANA");
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BKTP", m3_BKTP.ToString())
				.WithQueryParameter("ACHO", m3_ACHO.Trim())
				.WithQueryParameter("BKIN", m3_BKIN.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim())
				.WithQueryParameter("CBPY", m3_CBPY.ToString())
				.WithQueryParameter("STAT", m3_STAT.Trim())
				.WithQueryParameter("BANA", m3_BANA.Trim())
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BKNO))
				request.WithQueryParameter("BKNO", m3_BKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BBRN))
				request.WithQueryParameter("BBRN", m3_BBRN.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF1))
				request.WithQueryParameter("BAF1", m3_BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF2))
				request.WithQueryParameter("BAF2", m3_BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF3))
				request.WithQueryParameter("BAF3", m3_BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF4))
				request.WithQueryParameter("BAF4", m3_BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF5))
				request.WithQueryParameter("BAF5", m3_BAF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKPL))
				request.WithQueryParameter("BKPL", m3_BKPL.Trim());
			if (m3_ARTP.HasValue)
				request.WithQueryParameter("ARTP", m3_ARTP.Value.ToString());
			if (m3_BMDA.HasValue)
				request.WithQueryParameter("BMDA", m3_BMDA.Value.ToString());
			if (m3_BMCA.HasValue)
				request.WithQueryParameter("BMCA", m3_BMCA.Value.ToString());
			if (m3_FCDC.HasValue)
				request.WithQueryParameter("FCDC", m3_FCDC.Value.ToString());
			if (m3_BIDC.HasValue)
				request.WithQueryParameter("BIDC", m3_BIDC.Value.ToString());
			if (m3_BMDI.HasValue)
				request.WithQueryParameter("BMDI", m3_BMDI.Value.ToString());
			if (m3_FCCO.HasValue)
				request.WithQueryParameter("FCCO", m3_FCCO.Value.ToString());
			if (m3_DNOV.HasValue)
				request.WithQueryParameter("DNOV", m3_DNOV.Value.ToString());
			if (m3_CNOV.HasValue)
				request.WithQueryParameter("CNOV", m3_CNOV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BKAG))
				request.WithQueryParameter("BKAG", m3_BKAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FINC))
				request.WithQueryParameter("FINC", m3_FINC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_C1QF))
				request.WithQueryParameter("C1QF", m3_C1QF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_C1RA))
				request.WithQueryParameter("C1RA", m3_C1RA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIAN))
				request.WithQueryParameter("FIAN", m3_FIAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRNO))
				request.WithQueryParameter("BRNO", m3_BRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_C2QF))
				request.WithQueryParameter("C2QF", m3_C2QF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_C2RA))
				request.WithQueryParameter("C2RA", m3_C2RA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FICU))
				request.WithQueryParameter("FICU", m3_FICU.Trim());
			if (m3_NCHL.HasValue)
				request.WithQueryParameter("NCHL", m3_NCHL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (m3_NODY.HasValue)
				request.WithQueryParameter("NODY", m3_NODY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EBAT))
				request.WithQueryParameter("EBAT", m3_EBAT.Trim());
			if (m3_PYTK.HasValue)
				request.WithQueryParameter("PYTK", m3_PYTK.Value.ToString());
			if (m3_CSTC.HasValue)
				request.WithQueryParameter("CSTC", m3_CSTC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IBAN))
				request.WithQueryParameter("IBAN", m3_IBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CIDN))
				request.WithQueryParameter("CIDN", m3_CIDN.Trim());

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
		/// Name ChgBasicData
		/// Description Modify bank accounts basic data
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BKTP">Bank account type (Required)</param>
		/// <param name="m3_ACHO">Account holder (Required)</param>
		/// <param name="m3_BKIN">Bank account indicator (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_CBPY">Bank priority</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_BANA">Bank account name</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_BKNO">Bank number</param>
		/// <param name="m3_BBRN">Bank branch identity</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_BAF1">Bank account field 1</param>
		/// <param name="m3_BAF2">Bank account field 2</param>
		/// <param name="m3_BAF3">Bank account field 3</param>
		/// <param name="m3_BAF4">Bank account field 4</param>
		/// <param name="m3_BAF5">Bank account field 5</param>
		/// <param name="m3_BKPL">Banking region</param>
		/// <param name="m3_ARTP">Remittance method</param>
		/// <param name="m3_BMDA">Maximum discountable amount</param>
		/// <param name="m3_BMCA">Maximum collection amount</param>
		/// <param name="m3_FCDC">Fixed discount charge</param>
		/// <param name="m3_BIDC">Discount rate</param>
		/// <param name="m3_BMDI">Minimum number of days for interest</param>
		/// <param name="m3_FCCO">Fixed collection charges</param>
		/// <param name="m3_DNOV">Discounted amount not overdue</param>
		/// <param name="m3_CNOV">Cash remittance not overdue</param>
		/// <param name="m3_BKAG">Bank EDI agreement number</param>
		/// <param name="m3_FINC">Financial institution</param>
		/// <param name="m3_C1QF">Code list - qualifier</param>
		/// <param name="m3_C1RA">Code list - responsible agent</param>
		/// <param name="m3_FIAN">Account number at financial institution</param>
		/// <param name="m3_BRNO">Branch number</param>
		/// <param name="m3_C2QF">Code list - qualifier</param>
		/// <param name="m3_C2RA">Code list - responsible agent</param>
		/// <param name="m3_FICU">Customer number at financial institution</param>
		/// <param name="m3_NCHL">Number of lines</param>
		/// <param name="m3_PYCD">Payment method - accounts receivable</param>
		/// <param name="m3_NODY">Number of days risk</param>
		/// <param name="m3_EBAT">Employee bank account type</param>
		/// <param name="m3_PYTK">Payment type key</param>
		/// <param name="m3_CSTC">Cost allocation code</param>
		/// <param name="m3_IBAN">International bank account number</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_CIDN">Creditor identifier number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgBasicData(
			string m3_DIVI, 
			int m3_BKTP, 
			string m3_ACHO, 
			string m3_BKIN, 
			string m3_BKID, 
			int? m3_CBPY = null, 
			string m3_STAT = null, 
			string m3_BANA = null, 
			string m3_LNCD = null, 
			string m3_BKNO = null, 
			string m3_BBRN = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_CUCD = null, 
			string m3_BAF1 = null, 
			string m3_BAF2 = null, 
			string m3_BAF3 = null, 
			string m3_BAF4 = null, 
			string m3_BAF5 = null, 
			string m3_BKPL = null, 
			int? m3_ARTP = null, 
			decimal? m3_BMDA = null, 
			decimal? m3_BMCA = null, 
			decimal? m3_FCDC = null, 
			int? m3_BIDC = null, 
			int? m3_BMDI = null, 
			decimal? m3_FCCO = null, 
			decimal? m3_DNOV = null, 
			decimal? m3_CNOV = null, 
			string m3_BKAG = null, 
			string m3_FINC = null, 
			string m3_C1QF = null, 
			string m3_C1RA = null, 
			string m3_FIAN = null, 
			string m3_BRNO = null, 
			string m3_C2QF = null, 
			string m3_C2RA = null, 
			string m3_FICU = null, 
			int? m3_NCHL = null, 
			string m3_PYCD = null, 
			int? m3_NODY = null, 
			string m3_EBAT = null, 
			int? m3_PYTK = null, 
			int? m3_CSTC = null, 
			string m3_IBAN = null, 
			string m3_ACGR = null, 
			string m3_CIDN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ACHO))
				throw new ArgumentNullException("m3_ACHO");
			if (string.IsNullOrWhiteSpace(m3_BKIN))
				throw new ArgumentNullException("m3_BKIN");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BKTP", m3_BKTP.ToString())
				.WithQueryParameter("ACHO", m3_ACHO.Trim())
				.WithQueryParameter("BKIN", m3_BKIN.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CBPY.HasValue)
				request.WithQueryParameter("CBPY", m3_CBPY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANA))
				request.WithQueryParameter("BANA", m3_BANA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKNO))
				request.WithQueryParameter("BKNO", m3_BKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BBRN))
				request.WithQueryParameter("BBRN", m3_BBRN.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF1))
				request.WithQueryParameter("BAF1", m3_BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF2))
				request.WithQueryParameter("BAF2", m3_BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF3))
				request.WithQueryParameter("BAF3", m3_BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF4))
				request.WithQueryParameter("BAF4", m3_BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF5))
				request.WithQueryParameter("BAF5", m3_BAF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKPL))
				request.WithQueryParameter("BKPL", m3_BKPL.Trim());
			if (m3_ARTP.HasValue)
				request.WithQueryParameter("ARTP", m3_ARTP.Value.ToString());
			if (m3_BMDA.HasValue)
				request.WithQueryParameter("BMDA", m3_BMDA.Value.ToString());
			if (m3_BMCA.HasValue)
				request.WithQueryParameter("BMCA", m3_BMCA.Value.ToString());
			if (m3_FCDC.HasValue)
				request.WithQueryParameter("FCDC", m3_FCDC.Value.ToString());
			if (m3_BIDC.HasValue)
				request.WithQueryParameter("BIDC", m3_BIDC.Value.ToString());
			if (m3_BMDI.HasValue)
				request.WithQueryParameter("BMDI", m3_BMDI.Value.ToString());
			if (m3_FCCO.HasValue)
				request.WithQueryParameter("FCCO", m3_FCCO.Value.ToString());
			if (m3_DNOV.HasValue)
				request.WithQueryParameter("DNOV", m3_DNOV.Value.ToString());
			if (m3_CNOV.HasValue)
				request.WithQueryParameter("CNOV", m3_CNOV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BKAG))
				request.WithQueryParameter("BKAG", m3_BKAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FINC))
				request.WithQueryParameter("FINC", m3_FINC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_C1QF))
				request.WithQueryParameter("C1QF", m3_C1QF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_C1RA))
				request.WithQueryParameter("C1RA", m3_C1RA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIAN))
				request.WithQueryParameter("FIAN", m3_FIAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRNO))
				request.WithQueryParameter("BRNO", m3_BRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_C2QF))
				request.WithQueryParameter("C2QF", m3_C2QF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_C2RA))
				request.WithQueryParameter("C2RA", m3_C2RA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FICU))
				request.WithQueryParameter("FICU", m3_FICU.Trim());
			if (m3_NCHL.HasValue)
				request.WithQueryParameter("NCHL", m3_NCHL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (m3_NODY.HasValue)
				request.WithQueryParameter("NODY", m3_NODY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EBAT))
				request.WithQueryParameter("EBAT", m3_EBAT.Trim());
			if (m3_PYTK.HasValue)
				request.WithQueryParameter("PYTK", m3_PYTK.Value.ToString());
			if (m3_CSTC.HasValue)
				request.WithQueryParameter("CSTC", m3_CSTC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IBAN))
				request.WithQueryParameter("IBAN", m3_IBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CIDN))
				request.WithQueryParameter("CIDN", m3_CIDN.Trim());

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
		/// Name DelBankAccount
		/// Description Delete bank account
		/// Version Release: 
		/// </summary>
		/// <param name="m3_BKTP">Bank account type (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ACHO">Account holder</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBankAccount(
			int m3_BKTP, 
			string m3_BKID, 
			string m3_DIVI = null, 
			string m3_ACHO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBankAccount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3_BKTP.ToString())
				.WithQueryParameter("BKID", m3_BKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACHO))
				request.WithQueryParameter("ACHO", m3_ACHO.Trim());

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
		/// Name GetAccHolder
		/// Description Retrieve Account Holder based on Bank Account information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_BKTP">Bank account type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_BAF1">Bank account field 1</param>
		/// <param name="m3_BAF2">Bank account field 2</param>
		/// <param name="m3_BAF3">Bank account field 3</param>
		/// <param name="m3_BAF4">Bank account field 4</param>
		/// <param name="m3_BAF5">Bank account field 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAccHolderResponse></returns>
		/// <exception cref="M3Exception<GetAccHolderResponse>"></exception>
		public async Task<M3Response<GetAccHolderResponse>> GetAccHolder(
			int m3_BKTP, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_BAF1 = null, 
			string m3_BAF2 = null, 
			string m3_BAF3 = null, 
			string m3_BAF4 = null, 
			string m3_BAF5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAccHolder",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3_BKTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF1))
				request.WithQueryParameter("BAF1", m3_BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF2))
				request.WithQueryParameter("BAF2", m3_BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF3))
				request.WithQueryParameter("BAF3", m3_BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF4))
				request.WithQueryParameter("BAF4", m3_BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAF5))
				request.WithQueryParameter("BAF5", m3_BAF5.Trim());

			// Execute the request
			var result = await Execute<GetAccHolderResponse>(
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
		/// Name GetBankAccount
		/// Description Retrieve bank account information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_BKTP">Bank account type (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ACHO">Account holder</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_BKIN">Bank account indicator</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_CBPY">Bank priority</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ULOC">Use local currency</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBankAccountResponse></returns>
		/// <exception cref="M3Exception<GetBankAccountResponse>"></exception>
		public async Task<M3Response<GetBankAccountResponse>> GetBankAccount(
			int m3_BKTP, 
			string m3_DIVI = null, 
			string m3_ACHO = null, 
			string m3_BKID = null, 
			string m3_BKIN = null, 
			string m3_STAT = null, 
			int? m3_CBPY = null, 
			string m3_CUCD = null, 
			int? m3_ULOC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBankAccount",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3_BKTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACHO))
				request.WithQueryParameter("ACHO", m3_ACHO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKIN))
				request.WithQueryParameter("BKIN", m3_BKIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_CBPY.HasValue)
				request.WithQueryParameter("CBPY", m3_CBPY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ULOC.HasValue)
				request.WithQueryParameter("ULOC", m3_ULOC.Value.ToString());

			// Execute the request
			var result = await Execute<GetBankAccountResponse>(
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
		/// Name GetBasicData
		/// Description Retrieve bank account basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_BKTP">Bank account type (Required)</param>
		/// <param name="m3_ACHO">Account holder (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			int m3_BKTP, 
			string m3_ACHO, 
			string m3_BKID, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ACHO))
				throw new ArgumentNullException("m3_ACHO");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3_BKTP.ToString())
				.WithQueryParameter("ACHO", m3_ACHO.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name GetBasicData2
		/// Description Get bank account information for global electronic messages
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_BKTP">Bank account type (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ACHO">Account holder</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicData2Response></returns>
		/// <exception cref="M3Exception<GetBasicData2Response>"></exception>
		public async Task<M3Response<GetBasicData2Response>> GetBasicData2(
			int m3_BKTP, 
			string m3_BKID, 
			string m3_DIVI = null, 
			string m3_ACHO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3_BKTP.ToString())
				.WithQueryParameter("BKID", m3_BKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACHO))
				request.WithQueryParameter("ACHO", m3_ACHO.Trim());

			// Execute the request
			var result = await Execute<GetBasicData2Response>(
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
		/// Name LstByAccHolder
		/// Description List Bank account information By Account Holder
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_BKTP">Bank account type (Required)</param>
		/// <param name="m3_ACHO">Account holder (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_CBPY">Bank priority</param>
		/// <param name="m3_BKIN">Bank account indicator</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByAccHolderResponse></returns>
		/// <exception cref="M3Exception<LstByAccHolderResponse>"></exception>
		public async Task<M3Response<LstByAccHolderResponse>> LstByAccHolder(
			int m3_BKTP, 
			string m3_ACHO, 
			string m3_DIVI = null, 
			int? m3_CBPY = null, 
			string m3_BKIN = null, 
			string m3_CUCD = null, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByAccHolder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ACHO))
				throw new ArgumentNullException("m3_ACHO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3_BKTP.ToString())
				.WithQueryParameter("ACHO", m3_ACHO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_CBPY.HasValue)
				request.WithQueryParameter("CBPY", m3_CBPY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BKIN))
				request.WithQueryParameter("BKIN", m3_BKIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

			// Execute the request
			var result = await Execute<LstByAccHolderResponse>(
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
		/// Name LstByBranch
		/// Description List Bank accounts by branch
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_BBRN">Bank branch identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByBranchResponse></returns>
		/// <exception cref="M3Exception<LstByBranchResponse>"></exception>
		public async Task<M3Response<LstByBranchResponse>> LstByBranch(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_BBRN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByBranch",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BBRN))
				request.WithQueryParameter("BBRN", m3_BBRN.Trim());

			// Execute the request
			var result = await Execute<LstByBranchResponse>(
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
		/// Name LstByID
		/// Description List Bank accounts by identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByIDResponse></returns>
		/// <exception cref="M3Exception<LstByIDResponse>"></exception>
		public async Task<M3Response<LstByIDResponse>> LstByID(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_BKID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());

			// Execute the request
			var result = await Execute<LstByIDResponse>(
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
		/// Name LstByNumber
		/// Description List Bank accounts by bank number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_BKNO">Bank number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByNumberResponse></returns>
		/// <exception cref="M3Exception<LstByNumberResponse>"></exception>
		public async Task<M3Response<LstByNumberResponse>> LstByNumber(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_BKNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByNumber",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKNO))
				request.WithQueryParameter("BKNO", m3_BKNO.Trim());

			// Execute the request
			var result = await Execute<LstByNumberResponse>(
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
		/// Name LstByType
		/// Description List Bank accounts by account type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_BKTP">Bank account type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByTypeResponse></returns>
		/// <exception cref="M3Exception<LstByTypeResponse>"></exception>
		public async Task<M3Response<LstByTypeResponse>> LstByType(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_BKTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_BKTP.HasValue)
				request.WithQueryParameter("BKTP", m3_BKTP.Value.ToString());

			// Execute the request
			var result = await Execute<LstByTypeResponse>(
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
