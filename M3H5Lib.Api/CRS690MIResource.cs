/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_BKNO">Bank number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_BKNM">Bank name</param>
		/// <param name="m3_ALBK">Search key</param>
		/// <param name="m3_BKA1">Bank address 1</param>
		/// <param name="m3_BKA2">Bank address 2</param>
		/// <param name="m3_BKA3">Bank address 3</param>
		/// <param name="m3_BKA4">Bank address 4</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_YRE2">Your reference 2</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_FCDC">Fixed discount charge</param>
		/// <param name="m3_BIDC">Discount rate</param>
		/// <param name="m3_BMDI">Minimum number of days for interest</param>
		/// <param name="m3_FCCO">Fixed collection charges</param>
		/// <param name="m3_BAGR">Bank group</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="m3_WESI">Web site address</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_SWIC">Swift code</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBank(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_BKNO = null, 
			string m3_STAT = null, 
			string m3_BKNM = null, 
			string m3_ALBK = null, 
			string m3_BKA1 = null, 
			string m3_BKA2 = null, 
			string m3_BKA3 = null, 
			string m3_BKA4 = null, 
			string m3_CSCD = null, 
			string m3_PONO = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_YRE2 = null, 
			string m3_OREF = null, 
			decimal? m3_FCDC = null, 
			int? m3_BIDC = null, 
			int? m3_BMDI = null, 
			decimal? m3_FCCO = null, 
			string m3_BAGR = null, 
			string m3_EMAL = null, 
			string m3_WESI = null, 
			string m3_ECAR = null, 
			string m3_SWIC = null, 
			string m3_VRNO = null, 
			decimal? m3_TXID = null, 
			string m3_TOWN = null, 
			string m3_FRCO = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKNO))
				request.WithQueryParameter("BKNO", m3_BKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKNM))
				request.WithQueryParameter("BKNM", m3_BKNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALBK))
				request.WithQueryParameter("ALBK", m3_ALBK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKA1))
				request.WithQueryParameter("BKA1", m3_BKA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKA2))
				request.WithQueryParameter("BKA2", m3_BKA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKA3))
				request.WithQueryParameter("BKA3", m3_BKA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKA4))
				request.WithQueryParameter("BKA4", m3_BKA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE2))
				request.WithQueryParameter("YRE2", m3_YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (m3_FCDC.HasValue)
				request.WithQueryParameter("FCDC", m3_FCDC.Value.ToString());
			if (m3_BIDC.HasValue)
				request.WithQueryParameter("BIDC", m3_BIDC.Value.ToString());
			if (m3_BMDI.HasValue)
				request.WithQueryParameter("BMDI", m3_BMDI.Value.ToString());
			if (m3_FCCO.HasValue)
				request.WithQueryParameter("FCCO", m3_FCCO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BAGR))
				request.WithQueryParameter("BAGR", m3_BAGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WESI))
				request.WithQueryParameter("WESI", m3_WESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SWIC))
				request.WithQueryParameter("SWIC", m3_SWIC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());

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
		/// Name DelByNumber
		/// Description Delete record by bank number
		/// Version Release: 
		/// </summary>
		/// <param name="m3_BKNO">Bank number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelByNumber(
			string m3_BKNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelByNumber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BKNO))
				throw new ArgumentNullException("m3_BKNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BKNO", m3_BKNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name DelBySwiftCode
		/// Description Delete by SWIFT code
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SWIC">Swift code (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBySwiftCode(
			string m3_SWIC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBySwiftCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SWIC))
				throw new ArgumentNullException("m3_SWIC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SWIC", m3_SWIC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name GetBasicData
		/// Description Retrieve bank basic data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_BKNO">Bank number (Required)</param>
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
			string m3_BKNO, 
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
			if (string.IsNullOrWhiteSpace(m3_BKNO))
				throw new ArgumentNullException("m3_BKNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BKNO", m3_BKNO.Trim());

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
		/// Name LstByCountry
		/// Description List Banks by bank country
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByCountryResponse></returns>
		/// <exception cref="M3Exception<LstByCountryResponse>"></exception>
		public async Task<M3Response<LstByCountryResponse>> LstByCountry(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_CSCD = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());

			// Execute the request
			var result = await Execute<LstByCountryResponse>(
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
		/// Description List Banks by bank number
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
		/// Name LstBySwiftCode
		/// Description List Banks by Swift code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SWIC">Swift code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBySwiftCodeResponse></returns>
		/// <exception cref="M3Exception<LstBySwiftCodeResponse>"></exception>
		public async Task<M3Response<LstBySwiftCodeResponse>> LstBySwiftCode(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_SWIC = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SWIC))
				request.WithQueryParameter("SWIC", m3_SWIC.Trim());

			// Execute the request
			var result = await Execute<LstBySwiftCodeResponse>(
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
		/// Name UpdByNumber
		/// Description Update data by bank number
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BKNO">Bank number (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_BKNM">Bank name</param>
		/// <param name="m3_ALBK">Search key</param>
		/// <param name="m3_BKA1">Bank address 1</param>
		/// <param name="m3_BKA2">Bank address 2</param>
		/// <param name="m3_BKA3">Bank address 3</param>
		/// <param name="m3_BKA4">Bank address 4</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_YRE2">Your reference 2</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_BKIN">Bank account indicator</param>
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
		/// <param name="m3_BAGR">Bank group</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="m3_WESI">Web site address</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_SWIC">Swift code</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_DNOV">Discounted amount not overdue</param>
		/// <param name="m3_CNOV">Cash remittance not overdue</param>
		/// <param name="m3_FINC">Financial institution</param>
		/// <param name="m3_C1QF">Code list - qualifier</param>
		/// <param name="m3_C1RA">Code list - responsible agent</param>
		/// <param name="m3_FIAN">Account number at financial institution</param>
		/// <param name="m3_BRNO">Branch number</param>
		/// <param name="m3_C2QF">Code list - qualifier</param>
		/// <param name="m3_C2RA">Code list - responsible agent</param>
		/// <param name="m3_FICU">Customer number at financial institution</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_NCHL">Number of lines</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdByNumber(
			string m3_DIVI, 
			string m3_BKNO, 
			string m3_STAT = null, 
			string m3_BKNM = null, 
			string m3_ALBK = null, 
			string m3_BKA1 = null, 
			string m3_BKA2 = null, 
			string m3_BKA3 = null, 
			string m3_BKA4 = null, 
			string m3_CSCD = null, 
			string m3_PONO = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_YRE2 = null, 
			string m3_OREF = null, 
			string m3_AIT1 = null, 
			string m3_CUCD = null, 
			string m3_BKIN = null, 
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
			string m3_BAGR = null, 
			string m3_EMAL = null, 
			string m3_WESI = null, 
			string m3_ECAR = null, 
			string m3_SWIC = null, 
			string m3_VRNO = null, 
			decimal? m3_DNOV = null, 
			decimal? m3_CNOV = null, 
			string m3_FINC = null, 
			string m3_C1QF = null, 
			string m3_C1RA = null, 
			string m3_FIAN = null, 
			string m3_BRNO = null, 
			string m3_C2QF = null, 
			string m3_C2RA = null, 
			string m3_FICU = null, 
			string m3_TOWN = null, 
			string m3_LNCD = null, 
			int? m3_NCHL = null, 
			string m3_FRCO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKNO))
				throw new ArgumentNullException("m3_BKNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BKNO", m3_BKNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKNM))
				request.WithQueryParameter("BKNM", m3_BKNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALBK))
				request.WithQueryParameter("ALBK", m3_ALBK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKA1))
				request.WithQueryParameter("BKA1", m3_BKA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKA2))
				request.WithQueryParameter("BKA2", m3_BKA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKA3))
				request.WithQueryParameter("BKA3", m3_BKA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKA4))
				request.WithQueryParameter("BKA4", m3_BKA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE2))
				request.WithQueryParameter("YRE2", m3_YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKIN))
				request.WithQueryParameter("BKIN", m3_BKIN.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_BAGR))
				request.WithQueryParameter("BAGR", m3_BAGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WESI))
				request.WithQueryParameter("WESI", m3_WESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SWIC))
				request.WithQueryParameter("SWIC", m3_SWIC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (m3_DNOV.HasValue)
				request.WithQueryParameter("DNOV", m3_DNOV.Value.ToString());
			if (m3_CNOV.HasValue)
				request.WithQueryParameter("CNOV", m3_CNOV.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_NCHL.HasValue)
				request.WithQueryParameter("NCHL", m3_NCHL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());

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
		/// Name UpdBySwiftCode
		/// Description Update data by SWIFT code
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SWIC">Swift code (Required)</param>
		/// <param name="m3_BKNO">Bank number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_BKNM">Bank name</param>
		/// <param name="m3_ALBK">Search key</param>
		/// <param name="m3_BKA1">Bank address 1</param>
		/// <param name="m3_BKA2">Bank address 2</param>
		/// <param name="m3_BKA3">Bank address 3</param>
		/// <param name="m3_BKA4">Bank address 4</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_YRE2">Your reference 2</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_BKIN">Bank account indicator</param>
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
		/// <param name="m3_BAGR">Bank group</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="m3_WESI">Web site address</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_DNOV">Discounted amount not overdue</param>
		/// <param name="m3_CNOV">Cash remittance not overdue</param>
		/// <param name="m3_FINC">Financial institution</param>
		/// <param name="m3_C1QF">Code list - qualifier</param>
		/// <param name="m3_C1RA">Code list - responsible agent</param>
		/// <param name="m3_FIAN">Account number at financial institution</param>
		/// <param name="m3_BRNO">Branch number</param>
		/// <param name="m3_C2QF">Code list - qualifier</param>
		/// <param name="m3_C2RA">Code list - responsible agent</param>
		/// <param name="m3_FICU">Customer number at financial institution</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_NCHL">Number of lines</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBySwiftCode(
			string m3_DIVI, 
			string m3_SWIC, 
			string m3_BKNO = null, 
			string m3_STAT = null, 
			string m3_BKNM = null, 
			string m3_ALBK = null, 
			string m3_BKA1 = null, 
			string m3_BKA2 = null, 
			string m3_BKA3 = null, 
			string m3_BKA4 = null, 
			string m3_CSCD = null, 
			string m3_PONO = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_YRE2 = null, 
			string m3_OREF = null, 
			string m3_AIT1 = null, 
			string m3_CUCD = null, 
			string m3_BKIN = null, 
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
			string m3_BAGR = null, 
			string m3_EMAL = null, 
			string m3_WESI = null, 
			string m3_ECAR = null, 
			string m3_VRNO = null, 
			decimal? m3_DNOV = null, 
			decimal? m3_CNOV = null, 
			string m3_FINC = null, 
			string m3_C1QF = null, 
			string m3_C1RA = null, 
			string m3_FIAN = null, 
			string m3_BRNO = null, 
			string m3_C2QF = null, 
			string m3_C2RA = null, 
			string m3_FICU = null, 
			string m3_TOWN = null, 
			string m3_LNCD = null, 
			int? m3_NCHL = null, 
			string m3_FRCO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SWIC))
				throw new ArgumentNullException("m3_SWIC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SWIC", m3_SWIC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BKNO))
				request.WithQueryParameter("BKNO", m3_BKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKNM))
				request.WithQueryParameter("BKNM", m3_BKNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALBK))
				request.WithQueryParameter("ALBK", m3_ALBK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKA1))
				request.WithQueryParameter("BKA1", m3_BKA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKA2))
				request.WithQueryParameter("BKA2", m3_BKA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKA3))
				request.WithQueryParameter("BKA3", m3_BKA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKA4))
				request.WithQueryParameter("BKA4", m3_BKA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE2))
				request.WithQueryParameter("YRE2", m3_YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKIN))
				request.WithQueryParameter("BKIN", m3_BKIN.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_BAGR))
				request.WithQueryParameter("BAGR", m3_BAGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WESI))
				request.WithQueryParameter("WESI", m3_WESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (m3_DNOV.HasValue)
				request.WithQueryParameter("DNOV", m3_DNOV.Value.ToString());
			if (m3_CNOV.HasValue)
				request.WithQueryParameter("CNOV", m3_CNOV.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_NCHL.HasValue)
				request.WithQueryParameter("NCHL", m3_NCHL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());

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
