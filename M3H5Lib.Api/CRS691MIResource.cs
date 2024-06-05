/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS691MI;
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
	/// Name: CRS691MI
	/// Component Name: BankBranch
	/// Description: Bank branch interface
	/// Version Release: 14.x
	///</summary>
	public partial class CRS691MIResource : M3BaseResourceEndpoint
	{
		public CRS691MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS691MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBankBranch
		/// Description Add a new bank branch
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BKNO">Bank number (Required)</param>
		/// <param name="m3_BBRN">Bank branch identity (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_BKBM">Bank branch name (Required)</param>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_ALBK">Search key</param>
		/// <param name="m3_BKA1">Bank address 1</param>
		/// <param name="m3_BKA2">Bank address 2</param>
		/// <param name="m3_BKA3">Bank address 3</param>
		/// <param name="m3_BKA4">Bank address 4</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_YRE2">Your reference 2</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_BKPL">Banking region</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="m3_WESI">Web site address</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_SWIC">Swift code</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBankBranch(
			string m3_DIVI, 
			string m3_BKNO, 
			string m3_BBRN, 
			string m3_STAT, 
			string m3_BKBM, 
			string m3_CSCD, 
			string m3_LNCD, 
			string m3_ALBK = null, 
			string m3_BKA1 = null, 
			string m3_BKA2 = null, 
			string m3_BKA3 = null, 
			string m3_BKA4 = null, 
			string m3_PONO = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_YRE2 = null, 
			string m3_OREF = null, 
			string m3_BKPL = null, 
			string m3_EMAL = null, 
			string m3_WESI = null, 
			string m3_ECAR = null, 
			string m3_SWIC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBankBranch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKNO))
				throw new ArgumentNullException("m3_BKNO");
			if (string.IsNullOrWhiteSpace(m3_BBRN))
				throw new ArgumentNullException("m3_BBRN");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");
			if (string.IsNullOrWhiteSpace(m3_BKBM))
				throw new ArgumentNullException("m3_BKBM");
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BKNO", m3_BKNO.Trim())
				.WithQueryParameter("BBRN", m3_BBRN.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim())
				.WithQueryParameter("BKBM", m3_BKBM.Trim())
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
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
			if (!string.IsNullOrWhiteSpace(m3_BKPL))
				request.WithQueryParameter("BKPL", m3_BKPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WESI))
				request.WithQueryParameter("WESI", m3_WESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SWIC))
				request.WithQueryParameter("SWIC", m3_SWIC.Trim());
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
		/// <param name="m3_BBRN">Bank branch identity (Required)</param>
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
			string m3_BBRN, 
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
			if (string.IsNullOrWhiteSpace(m3_BBRN))
				throw new ArgumentNullException("m3_BBRN");

			// Set mandatory parameters
			request
				.WithQueryParameter("BKNO", m3_BKNO.Trim())
				.WithQueryParameter("BBRN", m3_BBRN.Trim());

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
		/// Description Retrieve bank branch basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BKNO">Bank number (Required)</param>
		/// <param name="m3_BBRN">Bank branch identity (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3_DIVI, 
			string m3_BKNO, 
			string m3_BBRN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKNO))
				throw new ArgumentNullException("m3_BKNO");
			if (string.IsNullOrWhiteSpace(m3_BBRN))
				throw new ArgumentNullException("m3_BBRN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BKNO", m3_BKNO.Trim())
				.WithQueryParameter("BBRN", m3_BBRN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Description List bank branch by bank country
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
		/// Description List bank branch by bank number
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
		/// Description List bank branch by Swift code
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
		/// Description Update record by bank number
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BKNO">Bank number (Required)</param>
		/// <param name="m3_BBRN">Bank branch identity (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_BKBM">Bank branch name</param>
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
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_BKPL">Banking region</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="m3_WESI">Web site address</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_SWIC">Swift code</param>
		/// <param name="m3_TOWN">City</param>
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
			string m3_BBRN, 
			string m3_STAT = null, 
			string m3_BKBM = null, 
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
			string m3_LNCD = null, 
			string m3_BKPL = null, 
			string m3_EMAL = null, 
			string m3_WESI = null, 
			string m3_ECAR = null, 
			string m3_SWIC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdByNumber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BKNO))
				throw new ArgumentNullException("m3_BKNO");
			if (string.IsNullOrWhiteSpace(m3_BBRN))
				throw new ArgumentNullException("m3_BBRN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BKNO", m3_BKNO.Trim())
				.WithQueryParameter("BBRN", m3_BBRN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKBM))
				request.WithQueryParameter("BKBM", m3_BKBM.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKPL))
				request.WithQueryParameter("BKPL", m3_BKPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WESI))
				request.WithQueryParameter("WESI", m3_WESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SWIC))
				request.WithQueryParameter("SWIC", m3_SWIC.Trim());
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
		/// Name UpdBySwiftCode
		/// Description Update record by Swift code
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SWIC">Swift code (Required)</param>
		/// <param name="m3_BBRN">Bank branch identity (Required)</param>
		/// <param name="m3_BKNO">Bank number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_BKBM">Bank branch name</param>
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
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_BKPL">Banking region</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="m3_WESI">Web site address</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_TOWN">City</param>
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
			string m3_BBRN, 
			string m3_BKNO = null, 
			string m3_STAT = null, 
			string m3_BKBM = null, 
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
			string m3_LNCD = null, 
			string m3_BKPL = null, 
			string m3_EMAL = null, 
			string m3_WESI = null, 
			string m3_ECAR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBySwiftCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SWIC))
				throw new ArgumentNullException("m3_SWIC");
			if (string.IsNullOrWhiteSpace(m3_BBRN))
				throw new ArgumentNullException("m3_BBRN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SWIC", m3_SWIC.Trim())
				.WithQueryParameter("BBRN", m3_BBRN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BKNO))
				request.WithQueryParameter("BKNO", m3_BKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKBM))
				request.WithQueryParameter("BKBM", m3_BKBM.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKPL))
				request.WithQueryParameter("BKPL", m3_BKPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WESI))
				request.WithQueryParameter("WESI", m3_WESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
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
	}
}
// EOF
