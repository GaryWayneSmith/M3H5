/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ActivateSubs
		/// Description Activate or Deactivate a subscriber
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3PTNM">Program/Table name (Required)</param>
		/// <param name="m3RSID">Remote server identity (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3MESI">Message ID</param>
		/// <param name="m3SSBS">Subscriber status, 1 or 0</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ActivateSubs(
			string m3PTNM, 
			string m3RSID, 
			string m3DIVI = null, 
			string m3MESI = null, 
			string m3SSBS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ActivateSubs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PTNM))
				throw new ArgumentNullException(nameof(m3PTNM));
			if (string.IsNullOrWhiteSpace(m3RSID))
				throw new ArgumentNullException(nameof(m3RSID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PTNM", m3PTNM.Trim())
				.WithQueryParameter("RSID", m3RSID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MESI))
				request.WithQueryParameter("MESI", m3MESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSBS))
				request.WithQueryParameter("SSBS", m3SSBS.Trim());

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
		/// Name AddHost
		/// Description Create a new host entry
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3RSID">Remote server identity (Required)</param>
		/// <param name="m3HOST">Host name (Required)</param>
		/// <param name="m3PORA">Port (Required)</param>
		/// <param name="m3CODP">Codepage</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TIOS">Socket timeout in seconds</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddHost(
			string m3RSID, 
			string m3HOST, 
			string m3PORA, 
			string m3CODP = null, 
			string m3TX40 = null, 
			int? m3TIOS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddHost",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RSID))
				throw new ArgumentNullException(nameof(m3RSID));
			if (string.IsNullOrWhiteSpace(m3HOST))
				throw new ArgumentNullException(nameof(m3HOST));
			if (string.IsNullOrWhiteSpace(m3PORA))
				throw new ArgumentNullException(nameof(m3PORA));

			// Set mandatory parameters
			request
				.WithQueryParameter("RSID", m3RSID.Trim())
				.WithQueryParameter("HOST", m3HOST.Trim())
				.WithQueryParameter("PORA", m3PORA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CODP))
				request.WithQueryParameter("CODP", m3CODP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3TIOS.HasValue)
				request.WithQueryParameter("TIOS", m3TIOS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddSubscriber
		/// Description Create a new subscriber entry
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3PTNM">Program/Table name (Required)</param>
		/// <param name="m3RSID">Remote server identity (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3MESI">Message ID</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3SSBS">Subscriber status, 10=Inactive, 20=Active</param>
		/// <param name="m3RSI2">Alternate server</param>
		/// <param name="m3RSVF">Reserved field</param>
		/// <param name="m3DLVF">Delivery confirmation flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSubscriber(
			string m3PTNM, 
			string m3RSID, 
			string m3DIVI = null, 
			string m3MESI = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
			string m3SSBS = null, 
			string m3RSI2 = null, 
			string m3RSVF = null, 
			int? m3DLVF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSubscriber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PTNM))
				throw new ArgumentNullException(nameof(m3PTNM));
			if (string.IsNullOrWhiteSpace(m3RSID))
				throw new ArgumentNullException(nameof(m3RSID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PTNM", m3PTNM.Trim())
				.WithQueryParameter("RSID", m3RSID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MESI))
				request.WithQueryParameter("MESI", m3MESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSBS))
				request.WithQueryParameter("SSBS", m3SSBS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSI2))
				request.WithQueryParameter("RSI2", m3RSI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSVF))
				request.WithQueryParameter("RSVF", m3RSVF.Trim());
			if (m3DLVF.HasValue)
				request.WithQueryParameter("DLVF", m3DLVF.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelHost
		/// Description Delete a single host entry
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3RSID">Remote server identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelHost(
			string m3RSID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelHost",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RSID))
				throw new ArgumentNullException(nameof(m3RSID));

			// Set mandatory parameters
			request
				.WithQueryParameter("RSID", m3RSID.Trim());

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
		/// Name DelSubscriber
		/// Description Delete a subscriber entry
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3PTNM">Program/Table name (Required)</param>
		/// <param name="m3RSID">Remote server identity (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3MESI">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSubscriber(
			string m3PTNM, 
			string m3RSID, 
			string m3DIVI = null, 
			string m3MESI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelSubscriber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PTNM))
				throw new ArgumentNullException(nameof(m3PTNM));
			if (string.IsNullOrWhiteSpace(m3RSID))
				throw new ArgumentNullException(nameof(m3RSID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PTNM", m3PTNM.Trim())
				.WithQueryParameter("RSID", m3RSID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MESI))
				request.WithQueryParameter("MESI", m3MESI.Trim());

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
		/// Name GetBJobStatus
		/// Description GetBJobStatus
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3BJNO">Job numbe3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBJobStatusResponse></returns>
		/// <exception cref="M3Exception<GetBJobStatusResponse>"></exception>
		public async Task<M3Response<GetBJobStatusResponse>> GetBJobStatus(
			decimal? m3BJNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBJobStatus",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3BJNO.HasValue)
				request.WithQueryParameter("BJNO", m3BJNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBJobStatusResponse>(
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
		/// Name GetHost
		/// Description Retrieve a host entry
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3RSID">Remote server identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHostResponse></returns>
		/// <exception cref="M3Exception<GetHostResponse>"></exception>
		public async Task<M3Response<GetHostResponse>> GetHost(
			string m3RSID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHost",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RSID))
				throw new ArgumentNullException(nameof(m3RSID));

			// Set mandatory parameters
			request
				.WithQueryParameter("RSID", m3RSID.Trim());

			// Execute the request
			var result = await Execute<GetHostResponse>(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetIONParams",
			};

			// Execute the request
			var result = await Execute<GetIONParamsResponse>(
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
		/// Name GetSubscriber
		/// Description Get subscriber data
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3PTNM">Program/Table name (Required)</param>
		/// <param name="m3RSID">Remote server identity (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3MESI">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSubscriberResponse></returns>
		/// <exception cref="M3Exception<GetSubscriberResponse>"></exception>
		public async Task<M3Response<GetSubscriberResponse>> GetSubscriber(
			string m3PTNM, 
			string m3RSID, 
			string m3DIVI = null, 
			string m3MESI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSubscriber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PTNM))
				throw new ArgumentNullException(nameof(m3PTNM));
			if (string.IsNullOrWhiteSpace(m3RSID))
				throw new ArgumentNullException(nameof(m3RSID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PTNM", m3PTNM.Trim())
				.WithQueryParameter("RSID", m3RSID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MESI))
				request.WithQueryParameter("MESI", m3MESI.Trim());

			// Execute the request
			var result = await Execute<GetSubscriberResponse>(
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
		/// Name Initiate
		/// Description Send table data via EventHub
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3NOAL">Number of actions</param>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3KEYI">Key fields only in output = 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<InitiateResponse></returns>
		/// <exception cref="M3Exception<InitiateResponse>"></exception>
		public async Task<M3Response<InitiateResponse>> Initiate(
			string m3FILE, 
			int? m3NOAL = null, 
			string m3SQRY = null, 
			string m3DIVI = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			int? m3KEYI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Initiate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3NOAL.HasValue)
				request.WithQueryParameter("NOAL", m3NOAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (m3KEYI.HasValue)
				request.WithQueryParameter("KEYI", m3KEYI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<InitiateResponse>(
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
		/// Name LstHosts
		/// Description List remote hosts
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3RSID">Remote server identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHostsResponse></returns>
		/// <exception cref="M3Exception<LstHostsResponse>"></exception>
		public async Task<M3Response<LstHostsResponse>> LstHosts(
			string m3RSID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstHosts",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RSID))
				request.WithQueryParameter("RSID", m3RSID.Trim());

			// Execute the request
			var result = await Execute<LstHostsResponse>(
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
		/// Name LstSubscribers
		/// Description List subscribers
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3PTNM">Program/Table name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSubscribersResponse></returns>
		/// <exception cref="M3Exception<LstSubscribersResponse>"></exception>
		public async Task<M3Response<LstSubscribersResponse>> LstSubscribers(
			string m3PTNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSubscribers",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PTNM))
				request.WithQueryParameter("PTNM", m3PTNM.Trim());

			// Execute the request
			var result = await Execute<LstSubscribersResponse>(
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstUserJobs",
			};

			// Execute the request
			var result = await Execute<LstUserJobsResponse>(
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
		/// Name PushSubscriber
		/// Description Push out data from specified table to subscribers
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3RGDT">Entry date (Required)</param>
		/// <param name="m3RGTM">Entry time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<PushSubscriberResponse></returns>
		/// <exception cref="M3Exception<PushSubscriberResponse>"></exception>
		public async Task<M3Response<PushSubscriberResponse>> PushSubscriber(
			string m3FILE, 
			DateTime m3RGDT, 
			int? m3RGTM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PushSubscriber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("RGDT", m3RGDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<PushSubscriberResponse>(
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
		/// Name SetIONParams
		/// Description Set ION Parameters
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3USID">User ID for accessing ION</param>
		/// <param name="m3PWD">Password for ION connect</param>
		/// <param name="m3URL">URL address for connecting to ION</param>
		/// <param name="m3LID">Logical ID for the M3BE instanc1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetIONParams(
			string m3USID = null, 
			string m3PWD = null, 
			string m3URL = null, 
			string m3LID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SetIONParams",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PWD))
				request.WithQueryParameter("PWD", m3PWD.Trim());
			if (!string.IsNullOrWhiteSpace(m3URL))
				request.WithQueryParameter("URL", m3URL.Trim());
			if (!string.IsNullOrWhiteSpace(m3LID))
				request.WithQueryParameter("LID", m3LID.Trim());

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
		/// Name TestHost
		/// Description Send a test message to the host
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3RSID">Remote server identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TestHost(
			string m3RSID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/TestHost",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RSID))
				throw new ArgumentNullException(nameof(m3RSID));

			// Set mandatory parameters
			request
				.WithQueryParameter("RSID", m3RSID.Trim());

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
		/// Name TestSubscriber
		/// Description Send a test message to the subscriber
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3PTNM">Program/Table name (Required)</param>
		/// <param name="m3RSID">Remote server identity (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3MESI">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TestSubscriber(
			string m3PTNM, 
			string m3RSID, 
			string m3DIVI = null, 
			string m3MESI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/TestSubscriber",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PTNM))
				throw new ArgumentNullException(nameof(m3PTNM));
			if (string.IsNullOrWhiteSpace(m3RSID))
				throw new ArgumentNullException(nameof(m3RSID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PTNM", m3PTNM.Trim())
				.WithQueryParameter("RSID", m3RSID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MESI))
				request.WithQueryParameter("MESI", m3MESI.Trim());

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
