/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.EVS002MI;
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
	/// Name: EVS002MI
	/// Component Name: SendTableData
	/// Description: Send table data
	/// Version Release: 5e90
	///</summary>
	public partial class EVS002MIResource : M3BaseResourceEndpoint
	{
		public EVS002MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "EVS002MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ActivateSubs
		/// Description Activate or Deactivate a subscriber
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_PTNM">Program/Table name (Required)</param>
		/// <param name="m3_RSID">Remote server identity (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_MESI">Message ID</param>
		/// <param name="m3_SSBS">Subscriber status, 1 or 0</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ActivateSubs(
			string m3_PTNM, 
			string m3_RSID, 
			string m3_DIVI = null, 
			string m3_MESI = null, 
			string m3_SSBS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ActivateSubs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PTNM))
				throw new ArgumentNullException("m3_PTNM");
			if (string.IsNullOrWhiteSpace(m3_RSID))
				throw new ArgumentNullException("m3_RSID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PTNM", m3_PTNM.Trim())
				.WithQueryParameter("RSID", m3_RSID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MESI))
				request.WithQueryParameter("MESI", m3_MESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSBS))
				request.WithQueryParameter("SSBS", m3_SSBS.Trim());

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
		/// Name AddHost
		/// Description Create a new host entry
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_RSID">Remote server identity (Required)</param>
		/// <param name="m3_HOST">Host name (Required)</param>
		/// <param name="m3_PORA">Port (Required)</param>
		/// <param name="m3_CODP">Codepage</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TIOS">Socket timeout in seconds</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddHost(
			string m3_RSID, 
			string m3_HOST, 
			string m3_PORA, 
			string m3_CODP = null, 
			string m3_TX40 = null, 
			int? m3_TIOS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddHost",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RSID))
				throw new ArgumentNullException("m3_RSID");
			if (string.IsNullOrWhiteSpace(m3_HOST))
				throw new ArgumentNullException("m3_HOST");
			if (string.IsNullOrWhiteSpace(m3_PORA))
				throw new ArgumentNullException("m3_PORA");

			// Set mandatory parameters
			request
				.WithQueryParameter("RSID", m3_RSID.Trim())
				.WithQueryParameter("HOST", m3_HOST.Trim())
				.WithQueryParameter("PORA", m3_PORA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CODP))
				request.WithQueryParameter("CODP", m3_CODP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_TIOS.HasValue)
				request.WithQueryParameter("TIOS", m3_TIOS.Value.ToString());

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
		/// Name AddSubscriber
		/// Description Create a new subscriber entry
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_PTNM">Program/Table name (Required)</param>
		/// <param name="m3_RSID">Remote server identity (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_MESI">Message ID</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_SSBS">Subscriber status, 10=Inactive, 20=Active</param>
		/// <param name="m3_RSI2">Alternate server</param>
		/// <param name="m3_RSVF">Reserved field</param>
		/// <param name="m3_DLVF">Delivery confirmation flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSubscriber(
			string m3_PTNM, 
			string m3_RSID, 
			string m3_DIVI = null, 
			string m3_MESI = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
			string m3_SSBS = null, 
			string m3_RSI2 = null, 
			string m3_RSVF = null, 
			int? m3_DLVF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSubscriber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PTNM))
				throw new ArgumentNullException("m3_PTNM");
			if (string.IsNullOrWhiteSpace(m3_RSID))
				throw new ArgumentNullException("m3_RSID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PTNM", m3_PTNM.Trim())
				.WithQueryParameter("RSID", m3_RSID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MESI))
				request.WithQueryParameter("MESI", m3_MESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSBS))
				request.WithQueryParameter("SSBS", m3_SSBS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSI2))
				request.WithQueryParameter("RSI2", m3_RSI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSVF))
				request.WithQueryParameter("RSVF", m3_RSVF.Trim());
			if (m3_DLVF.HasValue)
				request.WithQueryParameter("DLVF", m3_DLVF.Value.ToString());

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
		/// Name DelHost
		/// Description Delete a single host entry
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_RSID">Remote server identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelHost(
			string m3_RSID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelHost",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RSID))
				throw new ArgumentNullException("m3_RSID");

			// Set mandatory parameters
			request
				.WithQueryParameter("RSID", m3_RSID.Trim());

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
		/// Name DelSubscriber
		/// Description Delete a subscriber entry
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_PTNM">Program/Table name (Required)</param>
		/// <param name="m3_RSID">Remote server identity (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_MESI">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSubscriber(
			string m3_PTNM, 
			string m3_RSID, 
			string m3_DIVI = null, 
			string m3_MESI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelSubscriber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PTNM))
				throw new ArgumentNullException("m3_PTNM");
			if (string.IsNullOrWhiteSpace(m3_RSID))
				throw new ArgumentNullException("m3_RSID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PTNM", m3_PTNM.Trim())
				.WithQueryParameter("RSID", m3_RSID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MESI))
				request.WithQueryParameter("MESI", m3_MESI.Trim());

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
		/// Name GetBJobStatus
		/// Description GetBJobStatus
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_BJNO">Job numbe3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBJobStatusResponse></returns>
		/// <exception cref="M3Exception<GetBJobStatusResponse>"></exception>
		public async Task<M3Response<GetBJobStatusResponse>> GetBJobStatus(
			decimal? m3_BJNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBJobStatus",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_BJNO.HasValue)
				request.WithQueryParameter("BJNO", m3_BJNO.Value.ToString());

			// Execute the request
			var result = await Execute<GetBJobStatusResponse>(
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
		/// Name GetHost
		/// Description Retrieve a host entry
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_RSID">Remote server identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHostResponse></returns>
		/// <exception cref="M3Exception<GetHostResponse>"></exception>
		public async Task<M3Response<GetHostResponse>> GetHost(
			string m3_RSID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHost",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RSID))
				throw new ArgumentNullException("m3_RSID");

			// Set mandatory parameters
			request
				.WithQueryParameter("RSID", m3_RSID.Trim());

			// Execute the request
			var result = await Execute<GetHostResponse>(
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
		/// Name GetIONParams
		/// Description Get ION Parameters
		/// Version Release: 5e90
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIONParamsResponse></returns>
		/// <exception cref="M3Exception<GetIONParamsResponse>"></exception>
		public async Task<M3Response<GetIONParamsResponse>> GetIONParams(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetIONParams",
			};

			// Execute the request
			var result = await Execute<GetIONParamsResponse>(
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
		/// Name GetSubscriber
		/// Description Get subscriber data
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_PTNM">Program/Table name (Required)</param>
		/// <param name="m3_RSID">Remote server identity (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_MESI">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSubscriberResponse></returns>
		/// <exception cref="M3Exception<GetSubscriberResponse>"></exception>
		public async Task<M3Response<GetSubscriberResponse>> GetSubscriber(
			string m3_PTNM, 
			string m3_RSID, 
			string m3_DIVI = null, 
			string m3_MESI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSubscriber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PTNM))
				throw new ArgumentNullException("m3_PTNM");
			if (string.IsNullOrWhiteSpace(m3_RSID))
				throw new ArgumentNullException("m3_RSID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PTNM", m3_PTNM.Trim())
				.WithQueryParameter("RSID", m3_RSID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MESI))
				request.WithQueryParameter("MESI", m3_MESI.Trim());

			// Execute the request
			var result = await Execute<GetSubscriberResponse>(
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
		/// Name Initiate
		/// Description Send table data via EventHub
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_NOAL">Number of actions</param>
		/// <param name="m3_SQRY">Search query</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_KEYI">Key fields only in output = 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<InitiateResponse></returns>
		/// <exception cref="M3Exception<InitiateResponse>"></exception>
		public async Task<M3Response<InitiateResponse>> Initiate(
			string m3_FILE, 
			int? m3_NOAL = null, 
			string m3_SQRY = null, 
			string m3_DIVI = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			int? m3_KEYI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Initiate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_NOAL.HasValue)
				request.WithQueryParameter("NOAL", m3_NOAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SQRY))
				request.WithQueryParameter("SQRY", m3_SQRY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (m3_KEYI.HasValue)
				request.WithQueryParameter("KEYI", m3_KEYI.Value.ToString());

			// Execute the request
			var result = await Execute<InitiateResponse>(
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
		/// Name LstHosts
		/// Description List remote hosts
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_RSID">Remote server identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHostsResponse></returns>
		/// <exception cref="M3Exception<LstHostsResponse>"></exception>
		public async Task<M3Response<LstHostsResponse>> LstHosts(
			string m3_RSID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHosts",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RSID))
				request.WithQueryParameter("RSID", m3_RSID.Trim());

			// Execute the request
			var result = await Execute<LstHostsResponse>(
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
		/// Name LstSubscribers
		/// Description List subscribers
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_PTNM">Program/Table name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSubscribersResponse></returns>
		/// <exception cref="M3Exception<LstSubscribersResponse>"></exception>
		public async Task<M3Response<LstSubscribersResponse>> LstSubscribers(
			string m3_PTNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSubscribers",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PTNM))
				request.WithQueryParameter("PTNM", m3_PTNM.Trim());

			// Execute the request
			var result = await Execute<LstSubscribersResponse>(
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
		/// Name LstUserJobs
		/// Description List running user jobs
		/// Version Release: 14.1
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUserJobsResponse></returns>
		/// <exception cref="M3Exception<LstUserJobsResponse>"></exception>
		public async Task<M3Response<LstUserJobsResponse>> LstUserJobs(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstUserJobs",
			};

			// Execute the request
			var result = await Execute<LstUserJobsResponse>(
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
		/// Name PushSubscriber
		/// Description Push out data from specified table to subscribers
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_RGDT">Entry date (Required)</param>
		/// <param name="m3_RGTM">Entry time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<PushSubscriberResponse></returns>
		/// <exception cref="M3Exception<PushSubscriberResponse>"></exception>
		public async Task<M3Response<PushSubscriberResponse>> PushSubscriber(
			string m3_FILE, 
			DateTime m3_RGDT, 
			int? m3_RGTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PushSubscriber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("RGDT", m3_RGDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());

			// Execute the request
			var result = await Execute<PushSubscriberResponse>(
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
		/// Name SetIONParams
		/// Description Set ION Parameters
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_USID">User ID for accessing ION</param>
		/// <param name="m3_PWD">Password for ION connect</param>
		/// <param name="m3_URL">URL address for connecting to ION</param>
		/// <param name="m3_LID">Logical ID for the M3BE instanc1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetIONParams(
			string m3_USID = null, 
			string m3_PWD = null, 
			string m3_URL = null, 
			string m3_LID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetIONParams",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PWD))
				request.WithQueryParameter("PWD", m3_PWD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_URL))
				request.WithQueryParameter("URL", m3_URL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LID))
				request.WithQueryParameter("LID", m3_LID.Trim());

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
		/// Name TestHost
		/// Description Send a test message to the host
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_RSID">Remote server identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TestHost(
			string m3_RSID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TestHost",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RSID))
				throw new ArgumentNullException("m3_RSID");

			// Set mandatory parameters
			request
				.WithQueryParameter("RSID", m3_RSID.Trim());

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
		/// Name TestSubscriber
		/// Description Send a test message to the subscriber
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_PTNM">Program/Table name (Required)</param>
		/// <param name="m3_RSID">Remote server identity (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_MESI">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TestSubscriber(
			string m3_PTNM, 
			string m3_RSID, 
			string m3_DIVI = null, 
			string m3_MESI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TestSubscriber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PTNM))
				throw new ArgumentNullException("m3_PTNM");
			if (string.IsNullOrWhiteSpace(m3_RSID))
				throw new ArgumentNullException("m3_RSID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PTNM", m3_PTNM.Trim())
				.WithQueryParameter("RSID", m3_RSID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MESI))
				request.WithQueryParameter("MESI", m3_MESI.Trim());

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
