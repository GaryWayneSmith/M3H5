/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRS690MI;
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
	/// Name: CRS690MI
	/// Component Name: Bank
	/// Description: Bank interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS690MIResource : M3BaseResourceEndpoint
	{
		public CRS690MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS690MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBank
		/// Description Enter bank data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BKNO">Bank number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3BKNM">Bank name</param>
		/// <param name="m3ALBK">Search key</param>
		/// <param name="m3BKA1">Bank address 1</param>
		/// <param name="m3BKA2">Bank address 2</param>
		/// <param name="m3BKA3">Bank address 3</param>
		/// <param name="m3BKA4">Bank address 4</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3YRE2">Your reference 2</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3FCDC">Fixed discount charge</param>
		/// <param name="m3BIDC">Discount rate</param>
		/// <param name="m3BMDI">Minimum number of days for interest</param>
		/// <param name="m3FCCO">Fixed collection charges</param>
		/// <param name="m3BAGR">Bank group</param>
		/// <param name="m3EMAL">Electronic mail address</param>
		/// <param name="m3WESI">Web site address</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3SWIC">Swift code</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBank(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3BKNO = null, 
			string m3STAT = null, 
			string m3BKNM = null, 
			string m3ALBK = null, 
			string m3BKA1 = null, 
			string m3BKA2 = null, 
			string m3BKA3 = null, 
			string m3BKA4 = null, 
			string m3CSCD = null, 
			string m3PONO = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3YRE2 = null, 
			string m3OREF = null, 
			decimal? m3FCDC = null, 
			int? m3BIDC = null, 
			int? m3BMDI = null, 
			decimal? m3FCCO = null, 
			string m3BAGR = null, 
			string m3EMAL = null, 
			string m3WESI = null, 
			string m3ECAR = null, 
			string m3SWIC = null, 
			string m3VRNO = null, 
			decimal? m3TXID = null, 
			string m3TOWN = null, 
			string m3FRCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBank",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKNO))
				request.WithQueryParameter("BKNO", m3BKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKNM))
				request.WithQueryParameter("BKNM", m3BKNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALBK))
				request.WithQueryParameter("ALBK", m3ALBK.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKA1))
				request.WithQueryParameter("BKA1", m3BKA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKA2))
				request.WithQueryParameter("BKA2", m3BKA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKA3))
				request.WithQueryParameter("BKA3", m3BKA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKA4))
				request.WithQueryParameter("BKA4", m3BKA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE2))
				request.WithQueryParameter("YRE2", m3YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (m3FCDC.HasValue)
				request.WithQueryParameter("FCDC", m3FCDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BIDC.HasValue)
				request.WithQueryParameter("BIDC", m3BIDC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BMDI.HasValue)
				request.WithQueryParameter("BMDI", m3BMDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FCCO.HasValue)
				request.WithQueryParameter("FCCO", m3FCCO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BAGR))
				request.WithQueryParameter("BAGR", m3BAGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3WESI))
				request.WithQueryParameter("WESI", m3WESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SWIC))
				request.WithQueryParameter("SWIC", m3SWIC.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());

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
		/// Name DelByNumber
		/// Description Delete record by bank number
		/// Version Release: 
		/// </summary>
		/// <param name="m3BKNO">Bank number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelByNumber(
			string m3BKNO, 
			string m3DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelByNumber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BKNO))
				throw new ArgumentNullException(nameof(m3BKNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BKNO", m3BKNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name DelBySwiftCode
		/// Description Delete by SWIFT code
		/// Version Release: 
		/// </summary>
		/// <param name="m3SWIC">Swift code (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBySwiftCode(
			string m3SWIC, 
			string m3DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBySwiftCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SWIC))
				throw new ArgumentNullException(nameof(m3SWIC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SWIC", m3SWIC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name GetBasicData
		/// Description Retrieve bank basic data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3BKNO">Bank number (Required)</param>
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
			string m3BKNO, 
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BKNO))
				throw new ArgumentNullException(nameof(m3BKNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BKNO", m3BKNO.Trim());

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
		/// Name LstByCountry
		/// Description List Banks by bank country
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByCountryResponse></returns>
		/// <exception cref="M3Exception<LstByCountryResponse>"></exception>
		public async Task<M3Response<LstByCountryResponse>> LstByCountry(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3CSCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByCountry",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());

			// Execute the request
			var result = await Execute<LstByCountryResponse>(
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
		/// Description List Banks by bank number
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByNumber",
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
		/// Name LstBySwiftCode
		/// Description List Banks by Swift code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SWIC">Swift code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBySwiftCodeResponse></returns>
		/// <exception cref="M3Exception<LstBySwiftCodeResponse>"></exception>
		public async Task<M3Response<LstBySwiftCodeResponse>> LstBySwiftCode(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3SWIC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBySwiftCode",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SWIC))
				request.WithQueryParameter("SWIC", m3SWIC.Trim());

			// Execute the request
			var result = await Execute<LstBySwiftCodeResponse>(
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
		/// Name UpdByNumber
		/// Description Update data by bank number
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BKNO">Bank number (Required)</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3BKNM">Bank name</param>
		/// <param name="m3ALBK">Search key</param>
		/// <param name="m3BKA1">Bank address 1</param>
		/// <param name="m3BKA2">Bank address 2</param>
		/// <param name="m3BKA3">Bank address 3</param>
		/// <param name="m3BKA4">Bank address 4</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3YRE2">Your reference 2</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3BKIN">Bank account indicator</param>
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
		/// <param name="m3BAGR">Bank group</param>
		/// <param name="m3EMAL">Electronic mail address</param>
		/// <param name="m3WESI">Web site address</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3SWIC">Swift code</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3DNOV">Discounted amount not overdue</param>
		/// <param name="m3CNOV">Cash remittance not overdue</param>
		/// <param name="m3FINC">Financial institution</param>
		/// <param name="m3C1QF">Code list - qualifier</param>
		/// <param name="m3C1RA">Code list - responsible agent</param>
		/// <param name="m3FIAN">Account number at financial institution</param>
		/// <param name="m3BRNO">Branch number</param>
		/// <param name="m3C2QF">Code list - qualifier</param>
		/// <param name="m3C2RA">Code list - responsible agent</param>
		/// <param name="m3FICU">Customer number at financial institution</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3NCHL">Number of lines</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdByNumber(
			string m3DIVI, 
			string m3BKNO, 
			string m3STAT = null, 
			string m3BKNM = null, 
			string m3ALBK = null, 
			string m3BKA1 = null, 
			string m3BKA2 = null, 
			string m3BKA3 = null, 
			string m3BKA4 = null, 
			string m3CSCD = null, 
			string m3PONO = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3YRE2 = null, 
			string m3OREF = null, 
			string m3AIT1 = null, 
			string m3CUCD = null, 
			string m3BKIN = null, 
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
			string m3BAGR = null, 
			string m3EMAL = null, 
			string m3WESI = null, 
			string m3ECAR = null, 
			string m3SWIC = null, 
			string m3VRNO = null, 
			decimal? m3DNOV = null, 
			decimal? m3CNOV = null, 
			string m3FINC = null, 
			string m3C1QF = null, 
			string m3C1RA = null, 
			string m3FIAN = null, 
			string m3BRNO = null, 
			string m3C2QF = null, 
			string m3C2RA = null, 
			string m3FICU = null, 
			string m3TOWN = null, 
			string m3LNCD = null, 
			int? m3NCHL = null, 
			string m3FRCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdByNumber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKNO))
				throw new ArgumentNullException(nameof(m3BKNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BKNO", m3BKNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKNM))
				request.WithQueryParameter("BKNM", m3BKNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALBK))
				request.WithQueryParameter("ALBK", m3ALBK.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKA1))
				request.WithQueryParameter("BKA1", m3BKA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKA2))
				request.WithQueryParameter("BKA2", m3BKA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKA3))
				request.WithQueryParameter("BKA3", m3BKA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKA4))
				request.WithQueryParameter("BKA4", m3BKA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE2))
				request.WithQueryParameter("YRE2", m3YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKIN))
				request.WithQueryParameter("BKIN", m3BKIN.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3BAGR))
				request.WithQueryParameter("BAGR", m3BAGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3WESI))
				request.WithQueryParameter("WESI", m3WESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SWIC))
				request.WithQueryParameter("SWIC", m3SWIC.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (m3DNOV.HasValue)
				request.WithQueryParameter("DNOV", m3DNOV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNOV.HasValue)
				request.WithQueryParameter("CNOV", m3CNOV.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3NCHL.HasValue)
				request.WithQueryParameter("NCHL", m3NCHL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());

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
		/// Name UpdBySwiftCode
		/// Description Update data by SWIFT code
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SWIC">Swift code (Required)</param>
		/// <param name="m3BKNO">Bank number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3BKNM">Bank name</param>
		/// <param name="m3ALBK">Search key</param>
		/// <param name="m3BKA1">Bank address 1</param>
		/// <param name="m3BKA2">Bank address 2</param>
		/// <param name="m3BKA3">Bank address 3</param>
		/// <param name="m3BKA4">Bank address 4</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3YRE2">Your reference 2</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3BKIN">Bank account indicator</param>
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
		/// <param name="m3BAGR">Bank group</param>
		/// <param name="m3EMAL">Electronic mail address</param>
		/// <param name="m3WESI">Web site address</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3DNOV">Discounted amount not overdue</param>
		/// <param name="m3CNOV">Cash remittance not overdue</param>
		/// <param name="m3FINC">Financial institution</param>
		/// <param name="m3C1QF">Code list - qualifier</param>
		/// <param name="m3C1RA">Code list - responsible agent</param>
		/// <param name="m3FIAN">Account number at financial institution</param>
		/// <param name="m3BRNO">Branch number</param>
		/// <param name="m3C2QF">Code list - qualifier</param>
		/// <param name="m3C2RA">Code list - responsible agent</param>
		/// <param name="m3FICU">Customer number at financial institution</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3NCHL">Number of lines</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBySwiftCode(
			string m3DIVI, 
			string m3SWIC, 
			string m3BKNO = null, 
			string m3STAT = null, 
			string m3BKNM = null, 
			string m3ALBK = null, 
			string m3BKA1 = null, 
			string m3BKA2 = null, 
			string m3BKA3 = null, 
			string m3BKA4 = null, 
			string m3CSCD = null, 
			string m3PONO = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3YRE2 = null, 
			string m3OREF = null, 
			string m3AIT1 = null, 
			string m3CUCD = null, 
			string m3BKIN = null, 
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
			string m3BAGR = null, 
			string m3EMAL = null, 
			string m3WESI = null, 
			string m3ECAR = null, 
			string m3VRNO = null, 
			decimal? m3DNOV = null, 
			decimal? m3CNOV = null, 
			string m3FINC = null, 
			string m3C1QF = null, 
			string m3C1RA = null, 
			string m3FIAN = null, 
			string m3BRNO = null, 
			string m3C2QF = null, 
			string m3C2RA = null, 
			string m3FICU = null, 
			string m3TOWN = null, 
			string m3LNCD = null, 
			int? m3NCHL = null, 
			string m3FRCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBySwiftCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SWIC))
				throw new ArgumentNullException(nameof(m3SWIC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SWIC", m3SWIC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BKNO))
				request.WithQueryParameter("BKNO", m3BKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKNM))
				request.WithQueryParameter("BKNM", m3BKNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALBK))
				request.WithQueryParameter("ALBK", m3ALBK.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKA1))
				request.WithQueryParameter("BKA1", m3BKA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKA2))
				request.WithQueryParameter("BKA2", m3BKA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKA3))
				request.WithQueryParameter("BKA3", m3BKA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKA4))
				request.WithQueryParameter("BKA4", m3BKA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE2))
				request.WithQueryParameter("YRE2", m3YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKIN))
				request.WithQueryParameter("BKIN", m3BKIN.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3BAGR))
				request.WithQueryParameter("BAGR", m3BAGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3WESI))
				request.WithQueryParameter("WESI", m3WESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (m3DNOV.HasValue)
				request.WithQueryParameter("DNOV", m3DNOV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CNOV.HasValue)
				request.WithQueryParameter("CNOV", m3CNOV.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3NCHL.HasValue)
				request.WithQueryParameter("NCHL", m3NCHL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());

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
