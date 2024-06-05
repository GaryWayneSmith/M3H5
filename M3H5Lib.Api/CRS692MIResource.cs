/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBankAccount
		/// Description Add a new bank account
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BKTP">Bank account type (Required)</param>
		/// <param name="m3ACHO">Account holder (Required)</param>
		/// <param name="m3BKIN">Bank account indicator (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3CBPY">Bank priority (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3BANA">Bank account name (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3BKNO">Bank number</param>
		/// <param name="m3BBRN">Bank branch identity</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3BAF1">Bank account field 1</param>
		/// <param name="m3BAF2">Bank account field 2</param>
		/// <param name="m3BAF3">Bank account field 3</param>
		/// <param name="m3BAF4">Bank account field 4</param>
		/// <param name="m3BAF5">Bank account field 5</param>
		/// <param name="m3BKPL">Banking region</param>
		/// <param name="m3ARTP">Remittance method</param>
		/// <param name="m3BMDA">Maximum discountable amount</param>
		/// <param name="m3BMCA">Maximum collection amount</param>
		/// <param name="m3FCDC">Fixed discount charge</param>
		/// <param name="m3BIDC">Discount rate</param>
		/// <param name="m3BMDI">Minimum number of days for interest</param>
		/// <param name="m3FCCO">Fixed collection charges</param>
		/// <param name="m3DNOV">Discounted amount not overdue</param>
		/// <param name="m3CNOV">Cash remittance not overdue</param>
		/// <param name="m3BKAG">Bank EDI agreement number</param>
		/// <param name="m3FINC">Financial institution</param>
		/// <param name="m3C1QF">Code list - qualifier</param>
		/// <param name="m3C1RA">Code list - responsible agent</param>
		/// <param name="m3FIAN">Account number at financial institution</param>
		/// <param name="m3BRNO">Branch number</param>
		/// <param name="m3C2QF">Code list - qualifier</param>
		/// <param name="m3C2RA">Code list - responsible agent</param>
		/// <param name="m3FICU">Customer number at financial institution</param>
		/// <param name="m3NCHL">Number of lines</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3NODY">Number of days risk</param>
		/// <param name="m3EBAT">Employee bank account type</param>
		/// <param name="m3PYTK">Payment type key</param>
		/// <param name="m3CSTC">Cost allocation code</param>
		/// <param name="m3IBAN">International bank account number</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3CIDN">Creditor identifier number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBankAccount(
			string m3DIVI, 
			int m3BKTP, 
			string m3ACHO, 
			string m3BKIN, 
			string m3BKID, 
			int m3CBPY, 
			string m3STAT, 
			string m3BANA, 
			string m3LNCD, 
			string m3BKNO = null, 
			string m3BBRN = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3CUCD = null, 
			string m3BAF1 = null, 
			string m3BAF2 = null, 
			string m3BAF3 = null, 
			string m3BAF4 = null, 
			string m3BAF5 = null, 
			string m3BKPL = null, 
			int? m3ARTP = null, 
			decimal? m3BMDA = null, 
			decimal? m3BMCA = null, 
			decimal? m3FCDC = null, 
			int? m3BIDC = null, 
			int? m3BMDI = null, 
			decimal? m3FCCO = null, 
			decimal? m3DNOV = null, 
			decimal? m3CNOV = null, 
			string m3BKAG = null, 
			string m3FINC = null, 
			string m3C1QF = null, 
			string m3C1RA = null, 
			string m3FIAN = null, 
			string m3BRNO = null, 
			string m3C2QF = null, 
			string m3C2RA = null, 
			string m3FICU = null, 
			int? m3NCHL = null, 
			string m3PYCD = null, 
			int? m3NODY = null, 
			string m3EBAT = null, 
			int? m3PYTK = null, 
			int? m3CSTC = null, 
			string m3IBAN = null, 
			string m3ACGR = null, 
			string m3CIDN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBankAccount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3ACHO))
				throw new ArgumentNullException(nameof(m3ACHO));
			if (string.IsNullOrWhiteSpace(m3BKIN))
				throw new ArgumentNullException(nameof(m3BKIN));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));
			if (string.IsNullOrWhiteSpace(m3BANA))
				throw new ArgumentNullException(nameof(m3BANA));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BKTP", m3BKTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACHO", m3ACHO.Trim())
				.WithQueryParameter("BKIN", m3BKIN.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim())
				.WithQueryParameter("CBPY", m3CBPY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("BANA", m3BANA.Trim())
				.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BKNO))
				request.WithQueryParameter("BKNO", m3BKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BBRN))
				request.WithQueryParameter("BBRN", m3BBRN.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF1))
				request.WithQueryParameter("BAF1", m3BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF2))
				request.WithQueryParameter("BAF2", m3BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF3))
				request.WithQueryParameter("BAF3", m3BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF4))
				request.WithQueryParameter("BAF4", m3BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF5))
				request.WithQueryParameter("BAF5", m3BAF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKPL))
				request.WithQueryParameter("BKPL", m3BKPL.Trim());
			if (m3ARTP.HasValue)
				request.WithQueryParameter("ARTP", m3ARTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BMDA.HasValue)
				request.WithQueryParameter("BMDA", m3BMDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BMCA.HasValue)
				request.WithQueryParameter("BMCA", m3BMCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FCDC.HasValue)
				request.WithQueryParameter("FCDC", m3FCDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BIDC.HasValue)
				request.WithQueryParameter("BIDC", m3BIDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BMDI.HasValue)
				request.WithQueryParameter("BMDI", m3BMDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FCCO.HasValue)
				request.WithQueryParameter("FCCO", m3FCCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DNOV.HasValue)
				request.WithQueryParameter("DNOV", m3DNOV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNOV.HasValue)
				request.WithQueryParameter("CNOV", m3CNOV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BKAG))
				request.WithQueryParameter("BKAG", m3BKAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3FINC))
				request.WithQueryParameter("FINC", m3FINC.Trim());
			if (!string.IsNullOrWhiteSpace(m3C1QF))
				request.WithQueryParameter("C1QF", m3C1QF.Trim());
			if (!string.IsNullOrWhiteSpace(m3C1RA))
				request.WithQueryParameter("C1RA", m3C1RA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIAN))
				request.WithQueryParameter("FIAN", m3FIAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRNO))
				request.WithQueryParameter("BRNO", m3BRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3C2QF))
				request.WithQueryParameter("C2QF", m3C2QF.Trim());
			if (!string.IsNullOrWhiteSpace(m3C2RA))
				request.WithQueryParameter("C2RA", m3C2RA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FICU))
				request.WithQueryParameter("FICU", m3FICU.Trim());
			if (m3NCHL.HasValue)
				request.WithQueryParameter("NCHL", m3NCHL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (m3NODY.HasValue)
				request.WithQueryParameter("NODY", m3NODY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EBAT))
				request.WithQueryParameter("EBAT", m3EBAT.Trim());
			if (m3PYTK.HasValue)
				request.WithQueryParameter("PYTK", m3PYTK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSTC.HasValue)
				request.WithQueryParameter("CSTC", m3CSTC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IBAN))
				request.WithQueryParameter("IBAN", m3IBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CIDN))
				request.WithQueryParameter("CIDN", m3CIDN.Trim());

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
		/// Name ChgBasicData
		/// Description Modify bank accounts basic data
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BKTP">Bank account type (Required)</param>
		/// <param name="m3ACHO">Account holder (Required)</param>
		/// <param name="m3BKIN">Bank account indicator (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3CBPY">Bank priority</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3BANA">Bank account name</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3BKNO">Bank number</param>
		/// <param name="m3BBRN">Bank branch identity</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3BAF1">Bank account field 1</param>
		/// <param name="m3BAF2">Bank account field 2</param>
		/// <param name="m3BAF3">Bank account field 3</param>
		/// <param name="m3BAF4">Bank account field 4</param>
		/// <param name="m3BAF5">Bank account field 5</param>
		/// <param name="m3BKPL">Banking region</param>
		/// <param name="m3ARTP">Remittance method</param>
		/// <param name="m3BMDA">Maximum discountable amount</param>
		/// <param name="m3BMCA">Maximum collection amount</param>
		/// <param name="m3FCDC">Fixed discount charge</param>
		/// <param name="m3BIDC">Discount rate</param>
		/// <param name="m3BMDI">Minimum number of days for interest</param>
		/// <param name="m3FCCO">Fixed collection charges</param>
		/// <param name="m3DNOV">Discounted amount not overdue</param>
		/// <param name="m3CNOV">Cash remittance not overdue</param>
		/// <param name="m3BKAG">Bank EDI agreement number</param>
		/// <param name="m3FINC">Financial institution</param>
		/// <param name="m3C1QF">Code list - qualifier</param>
		/// <param name="m3C1RA">Code list - responsible agent</param>
		/// <param name="m3FIAN">Account number at financial institution</param>
		/// <param name="m3BRNO">Branch number</param>
		/// <param name="m3C2QF">Code list - qualifier</param>
		/// <param name="m3C2RA">Code list - responsible agent</param>
		/// <param name="m3FICU">Customer number at financial institution</param>
		/// <param name="m3NCHL">Number of lines</param>
		/// <param name="m3PYCD">Payment method - accounts receivable</param>
		/// <param name="m3NODY">Number of days risk</param>
		/// <param name="m3EBAT">Employee bank account type</param>
		/// <param name="m3PYTK">Payment type key</param>
		/// <param name="m3CSTC">Cost allocation code</param>
		/// <param name="m3IBAN">International bank account number</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3CIDN">Creditor identifier number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgBasicData(
			string m3DIVI, 
			int m3BKTP, 
			string m3ACHO, 
			string m3BKIN, 
			string m3BKID, 
			int? m3CBPY = null, 
			string m3STAT = null, 
			string m3BANA = null, 
			string m3LNCD = null, 
			string m3BKNO = null, 
			string m3BBRN = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3CUCD = null, 
			string m3BAF1 = null, 
			string m3BAF2 = null, 
			string m3BAF3 = null, 
			string m3BAF4 = null, 
			string m3BAF5 = null, 
			string m3BKPL = null, 
			int? m3ARTP = null, 
			decimal? m3BMDA = null, 
			decimal? m3BMCA = null, 
			decimal? m3FCDC = null, 
			int? m3BIDC = null, 
			int? m3BMDI = null, 
			decimal? m3FCCO = null, 
			decimal? m3DNOV = null, 
			decimal? m3CNOV = null, 
			string m3BKAG = null, 
			string m3FINC = null, 
			string m3C1QF = null, 
			string m3C1RA = null, 
			string m3FIAN = null, 
			string m3BRNO = null, 
			string m3C2QF = null, 
			string m3C2RA = null, 
			string m3FICU = null, 
			int? m3NCHL = null, 
			string m3PYCD = null, 
			int? m3NODY = null, 
			string m3EBAT = null, 
			int? m3PYTK = null, 
			int? m3CSTC = null, 
			string m3IBAN = null, 
			string m3ACGR = null, 
			string m3CIDN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3ACHO))
				throw new ArgumentNullException(nameof(m3ACHO));
			if (string.IsNullOrWhiteSpace(m3BKIN))
				throw new ArgumentNullException(nameof(m3BKIN));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BKTP", m3BKTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACHO", m3ACHO.Trim())
				.WithQueryParameter("BKIN", m3BKIN.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CBPY.HasValue)
				request.WithQueryParameter("CBPY", m3CBPY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANA))
				request.WithQueryParameter("BANA", m3BANA.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKNO))
				request.WithQueryParameter("BKNO", m3BKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BBRN))
				request.WithQueryParameter("BBRN", m3BBRN.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF1))
				request.WithQueryParameter("BAF1", m3BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF2))
				request.WithQueryParameter("BAF2", m3BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF3))
				request.WithQueryParameter("BAF3", m3BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF4))
				request.WithQueryParameter("BAF4", m3BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF5))
				request.WithQueryParameter("BAF5", m3BAF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKPL))
				request.WithQueryParameter("BKPL", m3BKPL.Trim());
			if (m3ARTP.HasValue)
				request.WithQueryParameter("ARTP", m3ARTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BMDA.HasValue)
				request.WithQueryParameter("BMDA", m3BMDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BMCA.HasValue)
				request.WithQueryParameter("BMCA", m3BMCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FCDC.HasValue)
				request.WithQueryParameter("FCDC", m3FCDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BIDC.HasValue)
				request.WithQueryParameter("BIDC", m3BIDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BMDI.HasValue)
				request.WithQueryParameter("BMDI", m3BMDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FCCO.HasValue)
				request.WithQueryParameter("FCCO", m3FCCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DNOV.HasValue)
				request.WithQueryParameter("DNOV", m3DNOV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNOV.HasValue)
				request.WithQueryParameter("CNOV", m3CNOV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BKAG))
				request.WithQueryParameter("BKAG", m3BKAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3FINC))
				request.WithQueryParameter("FINC", m3FINC.Trim());
			if (!string.IsNullOrWhiteSpace(m3C1QF))
				request.WithQueryParameter("C1QF", m3C1QF.Trim());
			if (!string.IsNullOrWhiteSpace(m3C1RA))
				request.WithQueryParameter("C1RA", m3C1RA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIAN))
				request.WithQueryParameter("FIAN", m3FIAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRNO))
				request.WithQueryParameter("BRNO", m3BRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3C2QF))
				request.WithQueryParameter("C2QF", m3C2QF.Trim());
			if (!string.IsNullOrWhiteSpace(m3C2RA))
				request.WithQueryParameter("C2RA", m3C2RA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FICU))
				request.WithQueryParameter("FICU", m3FICU.Trim());
			if (m3NCHL.HasValue)
				request.WithQueryParameter("NCHL", m3NCHL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (m3NODY.HasValue)
				request.WithQueryParameter("NODY", m3NODY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EBAT))
				request.WithQueryParameter("EBAT", m3EBAT.Trim());
			if (m3PYTK.HasValue)
				request.WithQueryParameter("PYTK", m3PYTK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSTC.HasValue)
				request.WithQueryParameter("CSTC", m3CSTC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IBAN))
				request.WithQueryParameter("IBAN", m3IBAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CIDN))
				request.WithQueryParameter("CIDN", m3CIDN.Trim());

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
		/// Name DelBankAccount
		/// Description Delete bank account
		/// Version Release: 
		/// </summary>
		/// <param name="m3BKTP">Bank account type (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ACHO">Account holder</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBankAccount(
			int m3BKTP, 
			string m3BKID, 
			string m3DIVI = null, 
			string m3ACHO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelBankAccount",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3BKTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BKID", m3BKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACHO))
				request.WithQueryParameter("ACHO", m3ACHO.Trim());

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
		/// Name GetAccHolder
		/// Description Retrieve Account Holder based on Bank Account information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3BKTP">Bank account type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BAF1">Bank account field 1</param>
		/// <param name="m3BAF2">Bank account field 2</param>
		/// <param name="m3BAF3">Bank account field 3</param>
		/// <param name="m3BAF4">Bank account field 4</param>
		/// <param name="m3BAF5">Bank account field 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAccHolderResponse></returns>
		/// <exception cref="M3Exception<GetAccHolderResponse>"></exception>
		public async Task<M3Response<GetAccHolderResponse>> GetAccHolder(
			int m3BKTP, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3BAF1 = null, 
			string m3BAF2 = null, 
			string m3BAF3 = null, 
			string m3BAF4 = null, 
			string m3BAF5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAccHolder",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3BKTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF1))
				request.WithQueryParameter("BAF1", m3BAF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF2))
				request.WithQueryParameter("BAF2", m3BAF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF3))
				request.WithQueryParameter("BAF3", m3BAF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF4))
				request.WithQueryParameter("BAF4", m3BAF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAF5))
				request.WithQueryParameter("BAF5", m3BAF5.Trim());

			// Execute the request
			var result = await Execute<GetAccHolderResponse>(
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
		/// Name GetBankAccount
		/// Description Retrieve bank account information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3BKTP">Bank account type (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ACHO">Account holder</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3BKIN">Bank account indicator</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3CBPY">Bank priority</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ULOC">Use local currency</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBankAccountResponse></returns>
		/// <exception cref="M3Exception<GetBankAccountResponse>"></exception>
		public async Task<M3Response<GetBankAccountResponse>> GetBankAccount(
			int m3BKTP, 
			string m3DIVI = null, 
			string m3ACHO = null, 
			string m3BKID = null, 
			string m3BKIN = null, 
			string m3STAT = null, 
			int? m3CBPY = null, 
			string m3CUCD = null, 
			int? m3ULOC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBankAccount",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3BKTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACHO))
				request.WithQueryParameter("ACHO", m3ACHO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKIN))
				request.WithQueryParameter("BKIN", m3BKIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3CBPY.HasValue)
				request.WithQueryParameter("CBPY", m3CBPY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ULOC.HasValue)
				request.WithQueryParameter("ULOC", m3ULOC.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBankAccountResponse>(
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
		/// Name GetBasicData
		/// Description Retrieve bank account basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3BKTP">Bank account type (Required)</param>
		/// <param name="m3ACHO">Account holder (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			int m3BKTP, 
			string m3ACHO, 
			string m3BKID, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ACHO))
				throw new ArgumentNullException(nameof(m3ACHO));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3BKTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACHO", m3ACHO.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name GetBasicData2
		/// Description Get bank account information for global electronic messages
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3BKTP">Bank account type (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ACHO">Account holder</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicData2Response></returns>
		/// <exception cref="M3Exception<GetBasicData2Response>"></exception>
		public async Task<M3Response<GetBasicData2Response>> GetBasicData2(
			int m3BKTP, 
			string m3BKID, 
			string m3DIVI = null, 
			string m3ACHO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasicData2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3BKTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BKID", m3BKID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACHO))
				request.WithQueryParameter("ACHO", m3ACHO.Trim());

			// Execute the request
			var result = await Execute<GetBasicData2Response>(
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
		/// Name LstByAccHolder
		/// Description List Bank account information By Account Holder
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3BKTP">Bank account type (Required)</param>
		/// <param name="m3ACHO">Account holder (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3CBPY">Bank priority</param>
		/// <param name="m3BKIN">Bank account indicator</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByAccHolderResponse></returns>
		/// <exception cref="M3Exception<LstByAccHolderResponse>"></exception>
		public async Task<M3Response<LstByAccHolderResponse>> LstByAccHolder(
			int m3BKTP, 
			string m3ACHO, 
			string m3DIVI = null, 
			int? m3CBPY = null, 
			string m3BKIN = null, 
			string m3CUCD = null, 
			string m3STAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByAccHolder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ACHO))
				throw new ArgumentNullException(nameof(m3ACHO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BKTP", m3BKTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACHO", m3ACHO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3CBPY.HasValue)
				request.WithQueryParameter("CBPY", m3CBPY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BKIN))
				request.WithQueryParameter("BKIN", m3BKIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

			// Execute the request
			var result = await Execute<LstByAccHolderResponse>(
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
		/// Name LstByBranch
		/// Description List Bank accounts by branch
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BBRN">Bank branch identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByBranchResponse></returns>
		/// <exception cref="M3Exception<LstByBranchResponse>"></exception>
		public async Task<M3Response<LstByBranchResponse>> LstByBranch(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3BBRN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByBranch",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BBRN))
				request.WithQueryParameter("BBRN", m3BBRN.Trim());

			// Execute the request
			var result = await Execute<LstByBranchResponse>(
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
		/// Name LstByID
		/// Description List Bank accounts by identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByIDResponse></returns>
		/// <exception cref="M3Exception<LstByIDResponse>"></exception>
		public async Task<M3Response<LstByIDResponse>> LstByID(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3BKID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());

			// Execute the request
			var result = await Execute<LstByIDResponse>(
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
		/// Name LstByNumber
		/// Description List Bank accounts by bank number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BKNO">Bank number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByNumberResponse></returns>
		/// <exception cref="M3Exception<LstByNumberResponse>"></exception>
		public async Task<M3Response<LstByNumberResponse>> LstByNumber(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3BKNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByNumber",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKNO))
				request.WithQueryParameter("BKNO", m3BKNO.Trim());

			// Execute the request
			var result = await Execute<LstByNumberResponse>(
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
		/// Name LstByType
		/// Description List Bank accounts by account type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BKTP">Bank account type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByTypeResponse></returns>
		/// <exception cref="M3Exception<LstByTypeResponse>"></exception>
		public async Task<M3Response<LstByTypeResponse>> LstByType(
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3BKTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3BKTP.HasValue)
				request.WithQueryParameter("BKTP", m3BKTP.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByTypeResponse>(
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
