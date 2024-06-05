/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BKNO">Bank number (Required)</param>
		/// <param name="m3BBRN">Bank branch identity (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3BKBM">Bank branch name (Required)</param>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3ALBK">Search key</param>
		/// <param name="m3BKA1">Bank address 1</param>
		/// <param name="m3BKA2">Bank address 2</param>
		/// <param name="m3BKA3">Bank address 3</param>
		/// <param name="m3BKA4">Bank address 4</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3YRE2">Your reference 2</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3BKPL">Banking region</param>
		/// <param name="m3EMAL">Electronic mail address</param>
		/// <param name="m3WESI">Web site address</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3SWIC">Swift code</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBankBranch(
			string m3DIVI, 
			string m3BKNO, 
			string m3BBRN, 
			string m3STAT, 
			string m3BKBM, 
			string m3CSCD, 
			string m3LNCD, 
			string m3ALBK = null, 
			string m3BKA1 = null, 
			string m3BKA2 = null, 
			string m3BKA3 = null, 
			string m3BKA4 = null, 
			string m3PONO = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3YRE2 = null, 
			string m3OREF = null, 
			string m3BKPL = null, 
			string m3EMAL = null, 
			string m3WESI = null, 
			string m3ECAR = null, 
			string m3SWIC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBankBranch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKNO))
				throw new ArgumentNullException(nameof(m3BKNO));
			if (string.IsNullOrWhiteSpace(m3BBRN))
				throw new ArgumentNullException(nameof(m3BBRN));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));
			if (string.IsNullOrWhiteSpace(m3BKBM))
				throw new ArgumentNullException(nameof(m3BKBM));
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BKNO", m3BKNO.Trim())
				.WithQueryParameter("BBRN", m3BBRN.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("BKBM", m3BKBM.Trim())
				.WithQueryParameter("CSCD", m3CSCD.Trim())
				.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
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
			if (!string.IsNullOrWhiteSpace(m3BKPL))
				request.WithQueryParameter("BKPL", m3BKPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3WESI))
				request.WithQueryParameter("WESI", m3WESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SWIC))
				request.WithQueryParameter("SWIC", m3SWIC.Trim());
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
		/// <param name="m3BBRN">Bank branch identity (Required)</param>
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
			string m3BBRN, 
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
			if (string.IsNullOrWhiteSpace(m3BBRN))
				throw new ArgumentNullException(nameof(m3BBRN));

			// Set mandatory parameters
			request
				.WithQueryParameter("BKNO", m3BKNO.Trim())
				.WithQueryParameter("BBRN", m3BBRN.Trim());

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
		/// Description Retrieve bank branch basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BKNO">Bank number (Required)</param>
		/// <param name="m3BBRN">Bank branch identity (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3DIVI, 
			string m3BKNO, 
			string m3BBRN, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKNO))
				throw new ArgumentNullException(nameof(m3BKNO));
			if (string.IsNullOrWhiteSpace(m3BBRN))
				throw new ArgumentNullException(nameof(m3BBRN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BKNO", m3BKNO.Trim())
				.WithQueryParameter("BBRN", m3BBRN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description List bank branch by bank country
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
		/// Description List bank branch by bank number
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
		/// Description List bank branch by Swift code
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
		/// Description Update record by bank number
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BKNO">Bank number (Required)</param>
		/// <param name="m3BBRN">Bank branch identity (Required)</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3BKBM">Bank branch name</param>
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
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3BKPL">Banking region</param>
		/// <param name="m3EMAL">Electronic mail address</param>
		/// <param name="m3WESI">Web site address</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3SWIC">Swift code</param>
		/// <param name="m3TOWN">City</param>
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
			string m3BBRN, 
			string m3STAT = null, 
			string m3BKBM = null, 
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
			string m3LNCD = null, 
			string m3BKPL = null, 
			string m3EMAL = null, 
			string m3WESI = null, 
			string m3ECAR = null, 
			string m3SWIC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdByNumber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BKNO))
				throw new ArgumentNullException(nameof(m3BKNO));
			if (string.IsNullOrWhiteSpace(m3BBRN))
				throw new ArgumentNullException(nameof(m3BBRN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BKNO", m3BKNO.Trim())
				.WithQueryParameter("BBRN", m3BBRN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKBM))
				request.WithQueryParameter("BKBM", m3BKBM.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKPL))
				request.WithQueryParameter("BKPL", m3BKPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3WESI))
				request.WithQueryParameter("WESI", m3WESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SWIC))
				request.WithQueryParameter("SWIC", m3SWIC.Trim());
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
		/// Name UpdBySwiftCode
		/// Description Update record by Swift code
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SWIC">Swift code (Required)</param>
		/// <param name="m3BBRN">Bank branch identity (Required)</param>
		/// <param name="m3BKNO">Bank number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3BKBM">Bank branch name</param>
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
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3BKPL">Banking region</param>
		/// <param name="m3EMAL">Electronic mail address</param>
		/// <param name="m3WESI">Web site address</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3TOWN">City</param>
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
			string m3BBRN, 
			string m3BKNO = null, 
			string m3STAT = null, 
			string m3BKBM = null, 
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
			string m3LNCD = null, 
			string m3BKPL = null, 
			string m3EMAL = null, 
			string m3WESI = null, 
			string m3ECAR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBySwiftCode",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SWIC))
				throw new ArgumentNullException(nameof(m3SWIC));
			if (string.IsNullOrWhiteSpace(m3BBRN))
				throw new ArgumentNullException(nameof(m3BBRN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SWIC", m3SWIC.Trim())
				.WithQueryParameter("BBRN", m3BBRN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BKNO))
				request.WithQueryParameter("BKNO", m3BKNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKBM))
				request.WithQueryParameter("BKBM", m3BKBM.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKPL))
				request.WithQueryParameter("BKPL", m3BKPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3WESI))
				request.WithQueryParameter("WESI", m3WESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
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
	}
}
// EOF
