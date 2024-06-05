/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMBMInit
		/// Description Add Iniator
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3ARSD">Automatic resend</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3PRTF">Printer file</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3OBJC">Field</param>
		/// <param name="m3DONO">Document identity</param>
		/// <param name="m3MKF4">Message key field 4</param>
		/// <param name="m3MKV4">Message key value 4</param>
		/// <param name="m3MKF5">Message key field 5</param>
		/// <param name="m3MKV5">Message key value 5</param>
		/// <param name="m3MKF6">Message key field 6</param>
		/// <param name="m3MKV6">Message key value 6</param>
		/// <param name="m3MKF7">Message key field 7</param>
		/// <param name="m3MKV7">Message key value 7</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMBMInitResponse></returns>
		/// <exception cref="M3Exception<AddMBMInitResponse>"></exception>
		public async Task<M3Response<AddMBMInitResponse>> AddMBMInit(
			int? m3ARSD = null, 
			string m3DONR = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3PRTF = null, 
			int? m3CPPL = null, 
			string m3OBJC = null, 
			string m3DONO = null, 
			string m3MKF4 = null, 
			string m3MKV4 = null, 
			string m3MKF5 = null, 
			string m3MKV5 = null, 
			string m3MKF6 = null, 
			string m3MKV6 = null, 
			string m3MKF7 = null, 
			string m3MKV7 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMBMInit",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3ARSD.HasValue)
				request.WithQueryParameter("ARSD", m3ARSD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRTF))
				request.WithQueryParameter("PRTF", m3PRTF.Trim());
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBJC))
				request.WithQueryParameter("OBJC", m3OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONO))
				request.WithQueryParameter("DONO", m3DONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKF4))
				request.WithQueryParameter("MKF4", m3MKF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKV4))
				request.WithQueryParameter("MKV4", m3MKV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKF5))
				request.WithQueryParameter("MKF5", m3MKF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKV5))
				request.WithQueryParameter("MKV5", m3MKV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKF6))
				request.WithQueryParameter("MKF6", m3MKF6.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKV6))
				request.WithQueryParameter("MKV6", m3MKV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKF7))
				request.WithQueryParameter("MKF7", m3MKF7.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKV7))
				request.WithQueryParameter("MKV7", m3MKV7.Trim());

			// Execute the request
			var result = await Execute<AddMBMInitResponse>(
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
		/// Name AddMBMInitLRFld
		/// Description Add a new field to a list record
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3BMIN">MBM Initiator Name (Required)</param>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3RNBR">Record number (Required)</param>
		/// <param name="m3FLDA">Field (Required)</param>
		/// <param name="m3FVLU">Field value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMBMInitLRFld(
			string m3BMIN, 
			string m3FILE, 
			int m3RNBR, 
			string m3FLDA, 
			string m3FVLU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMBMInitLRFld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BMIN))
				throw new ArgumentNullException(nameof(m3BMIN));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDA))
				throw new ArgumentNullException(nameof(m3FLDA));

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3BMIN.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("RNBR", m3RNBR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FLDA", m3FLDA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FVLU))
				request.WithQueryParameter("FVLU", m3FVLU.Trim());

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
		/// Name AddMBMLog
		/// Description Add MBM logrecord
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3MBMI">MBM identifier</param>
		/// <param name="m3DATA">Data</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddMBMLogResponse></returns>
		/// <exception cref="M3Exception<AddMBMLogResponse>"></exception>
		public async Task<M3Response<AddMBMLogResponse>> AddMBMLog(
			string m3MBMI = null, 
			string m3DATA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMBMLog",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MBMI))
				request.WithQueryParameter("MBMI", m3MBMI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DATA))
				request.WithQueryParameter("DATA", m3DATA.Trim());

			// Execute the request
			var result = await Execute<AddMBMLogResponse>(
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
		/// Name DelMBMInit
		/// Description Delete Initiator
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3BMIN">MBM Initiator Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMBMInit(
			string m3BMIN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelMBMInit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BMIN))
				throw new ArgumentNullException(nameof(m3BMIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3BMIN.Trim());

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
		/// Name DelMBMInitLRFld
		/// Description Delete a field in a list record
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3BMIN">MBM Initiator Name (Required)</param>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3RNBR">Record number (Required)</param>
		/// <param name="m3FLDA">Field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMBMInitLRFld(
			string m3BMIN, 
			string m3FILE, 
			int m3RNBR, 
			string m3FLDA, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelMBMInitLRFld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BMIN))
				throw new ArgumentNullException(nameof(m3BMIN));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDA))
				throw new ArgumentNullException(nameof(m3FLDA));

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3BMIN.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("RNBR", m3RNBR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FLDA", m3FLDA.Trim());

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
		/// Name DelMBMLog
		/// Description Delete MBM logrecords
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3MBMI">MBM identifier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMBMLog(
			string m3MBMI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelMBMLog",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MBMI))
				request.WithQueryParameter("MBMI", m3MBMI.Trim());

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
		/// Name DelOutLog
		/// Description Delete log
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3BMIN">MBM Initiator Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelOutLog(
			string m3BMIN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelOutLog",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BMIN))
				throw new ArgumentNullException(nameof(m3BMIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3BMIN.Trim());

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
		/// Name GetMBMInit
		/// Description Get Initiator
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3BMIN">MBM Initiator Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMBMInitResponse></returns>
		/// <exception cref="M3Exception<GetMBMInitResponse>"></exception>
		public async Task<M3Response<GetMBMInitResponse>> GetMBMInit(
			string m3BMIN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMBMInit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BMIN))
				throw new ArgumentNullException(nameof(m3BMIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3BMIN.Trim());

			// Execute the request
			var result = await Execute<GetMBMInitResponse>(
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
		/// Name GetMBMInitLRFld
		/// Description Get field from a list record
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3BMIN">MBM Initiator Name (Required)</param>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3RNBR">Record number (Required)</param>
		/// <param name="m3FLDA">Field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMBMInitLRFldResponse></returns>
		/// <exception cref="M3Exception<GetMBMInitLRFldResponse>"></exception>
		public async Task<M3Response<GetMBMInitLRFldResponse>> GetMBMInitLRFld(
			string m3BMIN, 
			string m3FILE, 
			int m3RNBR, 
			string m3FLDA, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMBMInitLRFld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BMIN))
				throw new ArgumentNullException(nameof(m3BMIN));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDA))
				throw new ArgumentNullException(nameof(m3FLDA));

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3BMIN.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("RNBR", m3RNBR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FLDA", m3FLDA.Trim());

			// Execute the request
			var result = await Execute<GetMBMInitLRFldResponse>(
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
		/// Name GetMBMLog
		/// Description Get MBM logrecord
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3MBMI">MBM identifier</param>
		/// <param name="m3RNBR">Record number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMBMLogResponse></returns>
		/// <exception cref="M3Exception<GetMBMLogResponse>"></exception>
		public async Task<M3Response<GetMBMLogResponse>> GetMBMLog(
			string m3MBMI = null, 
			int? m3RNBR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMBMLog",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MBMI))
				request.WithQueryParameter("MBMI", m3MBMI.Trim());
			if (m3RNBR.HasValue)
				request.WithQueryParameter("RNBR", m3RNBR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMBMLogResponse>(
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
		/// Name GetMBMStatus
		/// Description Get MBM status
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3MBMI">MBM identifier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMBMStatusResponse></returns>
		/// <exception cref="M3Exception<GetMBMStatusResponse>"></exception>
		public async Task<M3Response<GetMBMStatusResponse>> GetMBMStatus(
			string m3MBMI, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMBMStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MBMI))
				throw new ArgumentNullException(nameof(m3MBMI));

			// Set mandatory parameters
			request
				.WithQueryParameter("MBMI", m3MBMI.Trim());

			// Execute the request
			var result = await Execute<GetMBMStatusResponse>(
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
		/// Name LstMBMInit
		/// Description List Initiator
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3RGDT">Entry date (Required)</param>
		/// <param name="m3RGTM">Entry time (Required)</param>
		/// <param name="m3CHID">Changed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMBMInitResponse></returns>
		/// <exception cref="M3Exception<LstMBMInitResponse>"></exception>
		public async Task<M3Response<LstMBMInitResponse>> LstMBMInit(
			DateTime m3RGDT, 
			int m3RGTM, 
			string m3CHID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMBMInit",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("RGDT", m3RGDT.ToM3String())
				.WithQueryParameter("RGTM", m3RGTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CHID))
				request.WithQueryParameter("CHID", m3CHID.Trim());

			// Execute the request
			var result = await Execute<LstMBMInitResponse>(
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
		/// Name LstMBMInitLRFld
		/// Description List fields from a list record
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3BMIN">MBM Initiator Name (Required)</param>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3RNBR">Record number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMBMInitLRFldResponse></returns>
		/// <exception cref="M3Exception<LstMBMInitLRFldResponse>"></exception>
		public async Task<M3Response<LstMBMInitLRFldResponse>> LstMBMInitLRFld(
			string m3BMIN, 
			string m3FILE, 
			int m3RNBR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMBMInitLRFld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BMIN))
				throw new ArgumentNullException(nameof(m3BMIN));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3BMIN.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("RNBR", m3RNBR.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstMBMInitLRFldResponse>(
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
		/// Name LstMBMLog
		/// Description List MBM logrecords
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3MBMI">MBM identifier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMBMLogResponse></returns>
		/// <exception cref="M3Exception<LstMBMLogResponse>"></exception>
		public async Task<M3Response<LstMBMLogResponse>> LstMBMLog(
			string m3MBMI, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMBMLog",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MBMI))
				throw new ArgumentNullException(nameof(m3MBMI));

			// Set mandatory parameters
			request
				.WithQueryParameter("MBMI", m3MBMI.Trim());

			// Execute the request
			var result = await Execute<LstMBMLogResponse>(
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
		/// Name LstOutLog
		/// Description List MBM logrecords
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3BMIN">MBM Initiator Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOutLogResponse></returns>
		/// <exception cref="M3Exception<LstOutLogResponse>"></exception>
		public async Task<M3Response<LstOutLogResponse>> LstOutLog(
			string m3BMIN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOutLog",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BMIN))
				throw new ArgumentNullException(nameof(m3BMIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3BMIN.Trim());

			// Execute the request
			var result = await Execute<LstOutLogResponse>(
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
		/// Name LstOutStatus
		/// Description List MBM status
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3BMIN">MBM Initiator Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOutStatusResponse></returns>
		/// <exception cref="M3Exception<LstOutStatusResponse>"></exception>
		public async Task<M3Response<LstOutStatusResponse>> LstOutStatus(
			string m3BMIN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOutStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BMIN))
				throw new ArgumentNullException(nameof(m3BMIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3BMIN.Trim());

			// Execute the request
			var result = await Execute<LstOutStatusResponse>(
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
		/// Name PrcMBMInit
		/// Description Send Initiator
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3BMIN">MBM Initiator Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcMBMInit(
			string m3BMIN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrcMBMInit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BMIN))
				throw new ArgumentNullException(nameof(m3BMIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3BMIN.Trim());

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
		/// Name UpdMBMInit
		/// Description Update Iniator
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3BMIN">MBM Initiator Name (Required)</param>
		/// <param name="m3ARSD">Automatic resend</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3MEPF">Media profile</param>
		/// <param name="m3PRF1">Document/media controlling object 1</param>
		/// <param name="m3PRF2">Document/media control object 2</param>
		/// <param name="m3PRTF">Printer file</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3OBJC">Field</param>
		/// <param name="m3DONO">Document identity</param>
		/// <param name="m3MKF4">Message key field 4</param>
		/// <param name="m3MKV4">Message key value 4</param>
		/// <param name="m3MKF5">Message key field 5</param>
		/// <param name="m3MKV5">Message key value 5</param>
		/// <param name="m3MKF6">Message key field 6</param>
		/// <param name="m3MKV6">Message key value 6</param>
		/// <param name="m3MKF7">Message key field 7</param>
		/// <param name="m3MKV7">Message key value 7</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMBMInit(
			string m3BMIN, 
			int? m3ARSD = null, 
			string m3DONR = null, 
			string m3DOVA = null, 
			string m3MEPF = null, 
			string m3PRF1 = null, 
			string m3PRF2 = null, 
			string m3PRTF = null, 
			int? m3CPPL = null, 
			string m3OBJC = null, 
			string m3DONO = null, 
			string m3MKF4 = null, 
			string m3MKV4 = null, 
			string m3MKF5 = null, 
			string m3MKV5 = null, 
			string m3MKF6 = null, 
			string m3MKV6 = null, 
			string m3MKF7 = null, 
			string m3MKV7 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdMBMInit",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BMIN))
				throw new ArgumentNullException(nameof(m3BMIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3BMIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ARSD.HasValue)
				request.WithQueryParameter("ARSD", m3ARSD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEPF))
				request.WithQueryParameter("MEPF", m3MEPF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF1))
				request.WithQueryParameter("PRF1", m3PRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRF2))
				request.WithQueryParameter("PRF2", m3PRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRTF))
				request.WithQueryParameter("PRTF", m3PRTF.Trim());
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBJC))
				request.WithQueryParameter("OBJC", m3OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3DONO))
				request.WithQueryParameter("DONO", m3DONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKF4))
				request.WithQueryParameter("MKF4", m3MKF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKV4))
				request.WithQueryParameter("MKV4", m3MKV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKF5))
				request.WithQueryParameter("MKF5", m3MKF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKV5))
				request.WithQueryParameter("MKV5", m3MKV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKF6))
				request.WithQueryParameter("MKF6", m3MKF6.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKV6))
				request.WithQueryParameter("MKV6", m3MKV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKF7))
				request.WithQueryParameter("MKF7", m3MKF7.Trim());
			if (!string.IsNullOrWhiteSpace(m3MKV7))
				request.WithQueryParameter("MKV7", m3MKV7.Trim());

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
		/// Name UpdMBMInitLRFld
		/// Description Update field in a list record
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3BMIN">MBM Initiator Name (Required)</param>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3RNBR">Record number (Required)</param>
		/// <param name="m3FLDA">Field (Required)</param>
		/// <param name="m3FVLU">Field value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMBMInitLRFld(
			string m3BMIN, 
			string m3FILE, 
			int m3RNBR, 
			string m3FLDA, 
			string m3FVLU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdMBMInitLRFld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BMIN))
				throw new ArgumentNullException(nameof(m3BMIN));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDA))
				throw new ArgumentNullException(nameof(m3FLDA));

			// Set mandatory parameters
			request
				.WithQueryParameter("BMIN", m3BMIN.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("RNBR", m3RNBR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FLDA", m3FLDA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FVLU))
				request.WithQueryParameter("FVLU", m3FVLU.Trim());

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
		/// Name UpdMBMStatus
		/// Description Update MBM status
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3MBMI">MBM identifier</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3MSGD">Message</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdMBMStatusResponse></returns>
		/// <exception cref="M3Exception<UpdMBMStatusResponse>"></exception>
		public async Task<M3Response<UpdMBMStatusResponse>> UpdMBMStatus(
			string m3MBMI = null, 
			string m3STAT = null, 
			string m3MSGD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdMBMStatus",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MBMI))
				request.WithQueryParameter("MBMI", m3MBMI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGD))
				request.WithQueryParameter("MSGD", m3MSGD.Trim());

			// Execute the request
			var result = await Execute<UpdMBMStatusResponse>(
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
