/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MNS260MI;
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
	/// Name: MNS260MI
	/// Component Name: MBM
	/// Description: Api: MBM Initiator
	/// Version Release: MNB
	///</summary>
	public partial class MNS260MIResource : M3BaseResourceEndpoint
	{
		public MNS260MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS260MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMBMInit
		/// Description Add Iniator
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_ARSD">Automatic resend</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_PRTF">Printer file</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_OBJC">Field</param>
		/// <param name="m3_DONO">Document identity</param>
		/// <param name="m3_MKF4">Message key field 4</param>
		/// <param name="m3_MKV4">Message key value 4</param>
		/// <param name="m3_MKF5">Message key field 5</param>
		/// <param name="m3_MKV5">Message key value 5</param>
		/// <param name="m3_MKF6">Message key field 6</param>
		/// <param name="m3_MKV6">Message key value 6</param>
		/// <param name="m3_MKF7">Message key field 7</param>
		/// <param name="m3_MKV7">Message key value 7</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMBMInitResponse></returns>
		/// <exception cref="M3Exception<AddMBMInitResponse>"></exception>
		public async Task<M3Response<AddMBMInitResponse>> AddMBMInit(
			int? m3_ARSD = null, 
			string m3_DONR = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_PRTF = null, 
			int? m3_CPPL = null, 
			string m3_OBJC = null, 
			string m3_DONO = null, 
			string m3_MKF4 = null, 
			string m3_MKV4 = null, 
			string m3_MKF5 = null, 
			string m3_MKV5 = null, 
			string m3_MKF6 = null, 
			string m3_MKV6 = null, 
			string m3_MKF7 = null, 
			string m3_MKV7 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMBMInit",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ARSD.HasValue)
				request.WithQueryParameter("ARSD", m3_ARSD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRTF))
				request.WithQueryParameter("PRTF", m3_PRTF.Trim());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBJC))
				request.WithQueryParameter("OBJC", m3_OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONO))
				request.WithQueryParameter("DONO", m3_DONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKF4))
				request.WithQueryParameter("MKF4", m3_MKF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKV4))
				request.WithQueryParameter("MKV4", m3_MKV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKF5))
				request.WithQueryParameter("MKF5", m3_MKF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKV5))
				request.WithQueryParameter("MKV5", m3_MKV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKF6))
				request.WithQueryParameter("MKF6", m3_MKF6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKV6))
				request.WithQueryParameter("MKV6", m3_MKV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKF7))
				request.WithQueryParameter("MKF7", m3_MKF7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKV7))
				request.WithQueryParameter("MKV7", m3_MKV7.Trim());

			// Execute the request
			var result = await Execute<AddMBMInitResponse>(
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
		/// Name AddMBMInitLRFld
		/// Description Add a new field to a list record
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_BMIN">MBM Initiator Name (Required)</param>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_RNBR">Record number (Required)</param>
		/// <param name="m3_FLDA">Field (Required)</param>
		/// <param name="m3_FVLU">Field value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMBMInitLRFld(
			string m3_BMIN, 
			string m3_FILE, 
			int m3_RNBR, 
			string m3_FLDA, 
			string m3_FVLU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMBMInitLRFld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMIN))
				throw new ArgumentNullException("m3_BMIN");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDA))
				throw new ArgumentNullException("m3_FLDA");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3_BMIN.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("RNBR", m3_RNBR.ToString())
				.WithQueryParameter("FLDA", m3_FLDA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FVLU))
				request.WithQueryParameter("FVLU", m3_FVLU.Trim());

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
		/// Name AddMBMLog
		/// Description Add MBM logrecord
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_MBMI">MBM identifier</param>
		/// <param name="m3_DATA">Data</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMBMLogResponse></returns>
		/// <exception cref="M3Exception<AddMBMLogResponse>"></exception>
		public async Task<M3Response<AddMBMLogResponse>> AddMBMLog(
			string m3_MBMI = null, 
			string m3_DATA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMBMLog",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MBMI))
				request.WithQueryParameter("MBMI", m3_MBMI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DATA))
				request.WithQueryParameter("DATA", m3_DATA.Trim());

			// Execute the request
			var result = await Execute<AddMBMLogResponse>(
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
		/// Name DelMBMInit
		/// Description Delete Initiator
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_BMIN">MBM Initiator Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMBMInit(
			string m3_BMIN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelMBMInit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMIN))
				throw new ArgumentNullException("m3_BMIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3_BMIN.Trim());

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
		/// Name DelMBMInitLRFld
		/// Description Delete a field in a list record
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_BMIN">MBM Initiator Name (Required)</param>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_RNBR">Record number (Required)</param>
		/// <param name="m3_FLDA">Field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMBMInitLRFld(
			string m3_BMIN, 
			string m3_FILE, 
			int m3_RNBR, 
			string m3_FLDA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelMBMInitLRFld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMIN))
				throw new ArgumentNullException("m3_BMIN");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDA))
				throw new ArgumentNullException("m3_FLDA");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3_BMIN.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("RNBR", m3_RNBR.ToString())
				.WithQueryParameter("FLDA", m3_FLDA.Trim());

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
		/// Name DelMBMLog
		/// Description Delete MBM logrecords
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_MBMI">MBM identifier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMBMLog(
			string m3_MBMI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelMBMLog",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MBMI))
				request.WithQueryParameter("MBMI", m3_MBMI.Trim());

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
		/// Name DelOutLog
		/// Description Delete log
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_BMIN">MBM Initiator Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelOutLog(
			string m3_BMIN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelOutLog",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMIN))
				throw new ArgumentNullException("m3_BMIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3_BMIN.Trim());

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
		/// Name GetMBMInit
		/// Description Get Initiator
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_BMIN">MBM Initiator Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMBMInitResponse></returns>
		/// <exception cref="M3Exception<GetMBMInitResponse>"></exception>
		public async Task<M3Response<GetMBMInitResponse>> GetMBMInit(
			string m3_BMIN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMBMInit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMIN))
				throw new ArgumentNullException("m3_BMIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3_BMIN.Trim());

			// Execute the request
			var result = await Execute<GetMBMInitResponse>(
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
		/// Name GetMBMInitLRFld
		/// Description Get field from a list record
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_BMIN">MBM Initiator Name (Required)</param>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_RNBR">Record number (Required)</param>
		/// <param name="m3_FLDA">Field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMBMInitLRFldResponse></returns>
		/// <exception cref="M3Exception<GetMBMInitLRFldResponse>"></exception>
		public async Task<M3Response<GetMBMInitLRFldResponse>> GetMBMInitLRFld(
			string m3_BMIN, 
			string m3_FILE, 
			int m3_RNBR, 
			string m3_FLDA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMBMInitLRFld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMIN))
				throw new ArgumentNullException("m3_BMIN");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDA))
				throw new ArgumentNullException("m3_FLDA");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3_BMIN.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("RNBR", m3_RNBR.ToString())
				.WithQueryParameter("FLDA", m3_FLDA.Trim());

			// Execute the request
			var result = await Execute<GetMBMInitLRFldResponse>(
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
		/// Name GetMBMLog
		/// Description Get MBM logrecord
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_MBMI">MBM identifier</param>
		/// <param name="m3_RNBR">Record number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMBMLogResponse></returns>
		/// <exception cref="M3Exception<GetMBMLogResponse>"></exception>
		public async Task<M3Response<GetMBMLogResponse>> GetMBMLog(
			string m3_MBMI = null, 
			int? m3_RNBR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMBMLog",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MBMI))
				request.WithQueryParameter("MBMI", m3_MBMI.Trim());
			if (m3_RNBR.HasValue)
				request.WithQueryParameter("RNBR", m3_RNBR.Value.ToString());

			// Execute the request
			var result = await Execute<GetMBMLogResponse>(
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
		/// Name GetMBMStatus
		/// Description Get MBM status
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_MBMI">MBM identifier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMBMStatusResponse></returns>
		/// <exception cref="M3Exception<GetMBMStatusResponse>"></exception>
		public async Task<M3Response<GetMBMStatusResponse>> GetMBMStatus(
			string m3_MBMI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMBMStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MBMI))
				throw new ArgumentNullException("m3_MBMI");

			// Set mandatory parameters
			request
				.WithQueryParameter("MBMI", m3_MBMI.Trim());

			// Execute the request
			var result = await Execute<GetMBMStatusResponse>(
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
		/// Name LstMBMInit
		/// Description List Initiator
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_RGDT">Entry date (Required)</param>
		/// <param name="m3_RGTM">Entry time (Required)</param>
		/// <param name="m3_CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMBMInitResponse></returns>
		/// <exception cref="M3Exception<LstMBMInitResponse>"></exception>
		public async Task<M3Response<LstMBMInitResponse>> LstMBMInit(
			DateTime m3_RGDT, 
			int m3_RGTM, 
			string m3_CHID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMBMInit",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("RGDT", m3_RGDT.ToM3String())
				.WithQueryParameter("RGTM", m3_RGTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CHID))
				request.WithQueryParameter("CHID", m3_CHID.Trim());

			// Execute the request
			var result = await Execute<LstMBMInitResponse>(
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
		/// Name LstMBMInitLRFld
		/// Description List fields from a list record
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_BMIN">MBM Initiator Name (Required)</param>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_RNBR">Record number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMBMInitLRFldResponse></returns>
		/// <exception cref="M3Exception<LstMBMInitLRFldResponse>"></exception>
		public async Task<M3Response<LstMBMInitLRFldResponse>> LstMBMInitLRFld(
			string m3_BMIN, 
			string m3_FILE, 
			int m3_RNBR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMBMInitLRFld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMIN))
				throw new ArgumentNullException("m3_BMIN");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3_BMIN.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("RNBR", m3_RNBR.ToString());

			// Execute the request
			var result = await Execute<LstMBMInitLRFldResponse>(
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
		/// Name LstMBMLog
		/// Description List MBM logrecords
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_MBMI">MBM identifier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMBMLogResponse></returns>
		/// <exception cref="M3Exception<LstMBMLogResponse>"></exception>
		public async Task<M3Response<LstMBMLogResponse>> LstMBMLog(
			string m3_MBMI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMBMLog",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MBMI))
				throw new ArgumentNullException("m3_MBMI");

			// Set mandatory parameters
			request
				.WithQueryParameter("MBMI", m3_MBMI.Trim());

			// Execute the request
			var result = await Execute<LstMBMLogResponse>(
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
		/// Name LstOutLog
		/// Description List MBM logrecords
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_BMIN">MBM Initiator Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOutLogResponse></returns>
		/// <exception cref="M3Exception<LstOutLogResponse>"></exception>
		public async Task<M3Response<LstOutLogResponse>> LstOutLog(
			string m3_BMIN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOutLog",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMIN))
				throw new ArgumentNullException("m3_BMIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3_BMIN.Trim());

			// Execute the request
			var result = await Execute<LstOutLogResponse>(
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
		/// Name LstOutStatus
		/// Description List MBM status
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_BMIN">MBM Initiator Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOutStatusResponse></returns>
		/// <exception cref="M3Exception<LstOutStatusResponse>"></exception>
		public async Task<M3Response<LstOutStatusResponse>> LstOutStatus(
			string m3_BMIN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOutStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMIN))
				throw new ArgumentNullException("m3_BMIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3_BMIN.Trim());

			// Execute the request
			var result = await Execute<LstOutStatusResponse>(
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
		/// Name PrcMBMInit
		/// Description Send Initiator
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_BMIN">MBM Initiator Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcMBMInit(
			string m3_BMIN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrcMBMInit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMIN))
				throw new ArgumentNullException("m3_BMIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3_BMIN.Trim());

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
		/// Name UpdMBMInit
		/// Description Update Iniator
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_BMIN">MBM Initiator Name (Required)</param>
		/// <param name="m3_ARSD">Automatic resend</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_MEPF">Media profile</param>
		/// <param name="m3_PRF1">Document/media controlling object 1</param>
		/// <param name="m3_PRF2">Document/media control object 2</param>
		/// <param name="m3_PRTF">Printer file</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_OBJC">Field</param>
		/// <param name="m3_DONO">Document identity</param>
		/// <param name="m3_MKF4">Message key field 4</param>
		/// <param name="m3_MKV4">Message key value 4</param>
		/// <param name="m3_MKF5">Message key field 5</param>
		/// <param name="m3_MKV5">Message key value 5</param>
		/// <param name="m3_MKF6">Message key field 6</param>
		/// <param name="m3_MKV6">Message key value 6</param>
		/// <param name="m3_MKF7">Message key field 7</param>
		/// <param name="m3_MKV7">Message key value 7</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMBMInit(
			string m3_BMIN, 
			int? m3_ARSD = null, 
			string m3_DONR = null, 
			string m3_DOVA = null, 
			string m3_MEPF = null, 
			string m3_PRF1 = null, 
			string m3_PRF2 = null, 
			string m3_PRTF = null, 
			int? m3_CPPL = null, 
			string m3_OBJC = null, 
			string m3_DONO = null, 
			string m3_MKF4 = null, 
			string m3_MKV4 = null, 
			string m3_MKF5 = null, 
			string m3_MKV5 = null, 
			string m3_MKF6 = null, 
			string m3_MKV6 = null, 
			string m3_MKF7 = null, 
			string m3_MKV7 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdMBMInit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMIN))
				throw new ArgumentNullException("m3_BMIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3_BMIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ARSD.HasValue)
				request.WithQueryParameter("ARSD", m3_ARSD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEPF))
				request.WithQueryParameter("MEPF", m3_MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF1))
				request.WithQueryParameter("PRF1", m3_PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRF2))
				request.WithQueryParameter("PRF2", m3_PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRTF))
				request.WithQueryParameter("PRTF", m3_PRTF.Trim());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBJC))
				request.WithQueryParameter("OBJC", m3_OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DONO))
				request.WithQueryParameter("DONO", m3_DONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKF4))
				request.WithQueryParameter("MKF4", m3_MKF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKV4))
				request.WithQueryParameter("MKV4", m3_MKV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKF5))
				request.WithQueryParameter("MKF5", m3_MKF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKV5))
				request.WithQueryParameter("MKV5", m3_MKV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKF6))
				request.WithQueryParameter("MKF6", m3_MKF6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKV6))
				request.WithQueryParameter("MKV6", m3_MKV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKF7))
				request.WithQueryParameter("MKF7", m3_MKF7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MKV7))
				request.WithQueryParameter("MKV7", m3_MKV7.Trim());

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
		/// Name UpdMBMInitLRFld
		/// Description Update field in a list record
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_BMIN">MBM Initiator Name (Required)</param>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_RNBR">Record number (Required)</param>
		/// <param name="m3_FLDA">Field (Required)</param>
		/// <param name="m3_FVLU">Field value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMBMInitLRFld(
			string m3_BMIN, 
			string m3_FILE, 
			int m3_RNBR, 
			string m3_FLDA, 
			string m3_FVLU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdMBMInitLRFld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMIN))
				throw new ArgumentNullException("m3_BMIN");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDA))
				throw new ArgumentNullException("m3_FLDA");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3_BMIN.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("RNBR", m3_RNBR.ToString())
				.WithQueryParameter("FLDA", m3_FLDA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FVLU))
				request.WithQueryParameter("FVLU", m3_FVLU.Trim());

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
		/// Name UpdMBMStatus
		/// Description Update MBM status
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_MBMI">MBM identifier</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_MSGD">Message</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdMBMStatusResponse></returns>
		/// <exception cref="M3Exception<UpdMBMStatusResponse>"></exception>
		public async Task<M3Response<UpdMBMStatusResponse>> UpdMBMStatus(
			string m3_MBMI = null, 
			string m3_STAT = null, 
			string m3_MSGD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdMBMStatus",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MBMI))
				request.WithQueryParameter("MBMI", m3_MBMI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGD))
				request.WithQueryParameter("MSGD", m3_MSGD.Trim());

			// Execute the request
			var result = await Execute<UpdMBMStatusResponse>(
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
