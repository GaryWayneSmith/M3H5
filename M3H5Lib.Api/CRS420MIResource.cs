/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CRS420MI;
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
	/// Name: CRS420MI
	/// Component Name: ApplicationMessage
	/// Description: Application messages interface
	/// Version Release: 5e90
	///</summary>
	public partial class CRS420MIResource : M3BaseResourceEndpoint
	{
		public CRS420MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS420MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Adds a new application message
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3REC2">Application message receiver (Required)</param>
		/// <param name="m3MTPE">Application message type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ADAT">Action date</param>
		/// <param name="m3PAR1">Parameter 1</param>
		/// <param name="m3PAR2">Parameter 2</param>
		/// <param name="m3PAR3">Parameter 3</param>
		/// <param name="m3PAR4">Parameter 4</param>
		/// <param name="m3PAR5">Parameter 5</param>
		/// <param name="m3PAR6">Parameter 6</param>
		/// <param name="m3PAR7">Parameter 7</param>
		/// <param name="m3PAR8">Parameter 8</param>
		/// <param name="m3PAR9">Parameter 9</param>
		/// <param name="m3SEND">Sender</param>
		/// <param name="m3MSGF">Message file</param>
		/// <param name="m3RGTM">Application message time</param>
		/// <param name="m3RGDT">Application message date</param>
		/// <param name="m3OPT2">Opt. 11 - Option</param>
		/// <param name="m3PGNM">Opt. 11 - Program name</param>
		/// <param name="m3QTTP">Opt. 11 - Inquiry type</param>
		/// <param name="m3PICC">Opt. 11 - Opening picture</param>
		/// <param name="m3FL01">Opt. 11 - Name of MVXLDA field 1</param>
		/// <param name="m3FL02">Opt. 11 - Name of MVXLDA field 2</param>
		/// <param name="m3FL03">Opt. 11 - Name of MVXLDA field 3</param>
		/// <param name="m3FL04">Opt. 11 - Name of MVXLDA field 4</param>
		/// <param name="m3FL05">Opt. 11 - Name of MVXLDA field 5</param>
		/// <param name="m3FL06">Opt. 11 - Name of MVXLDA field 6</param>
		/// <param name="m3FL07">Opt. 11 - Name of MVXLDA field 7</param>
		/// <param name="m3FL08">Opt. 11 - Name of MVXLDA field 8</param>
		/// <param name="m3FL09">Opt. 11 - Name of MVXLDA field 9</param>
		/// <param name="m3FL10">Opt. 11 - Name of MVXLDA field 10</param>
		/// <param name="m3DT01">Opt. 11 - Data in MVXLDA field 1</param>
		/// <param name="m3DT02">Opt. 11 - Data in MVXLDA field 2</param>
		/// <param name="m3DT03">Opt. 11 - Data in MVXLDA field 3</param>
		/// <param name="m3DT04">Opt. 11 - Data in MVXLDA field 4</param>
		/// <param name="m3DT05">Opt. 11 - Data in MVXLDA field 5</param>
		/// <param name="m3DT06">Opt. 11 - Data in MVXLDA field 6</param>
		/// <param name="m3DT07">Opt. 11 - Data in MVXLDA field 7</param>
		/// <param name="m3DT08">Opt. 11 - Data in MVXLDA field 8</param>
		/// <param name="m3DT09">Opt. 11 - Data in MVXLDA field 9</param>
		/// <param name="m3DT10">Opt. 11 - Data in MVXLDA field 10</param>
		/// <param name="m3BODE">BOD enabled</param>
		/// <param name="m3BDMT">BOD message type</param>
		/// <param name="m3OFNC">Overriding function</param>
		/// <param name="m3FILE">File</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3KSTR">Keystring</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3REC2, 
			string m3MTPE, 
			int? m3CONO = null, 
			DateTime? m3ADAT = null, 
			string m3PAR1 = null, 
			string m3PAR2 = null, 
			string m3PAR3 = null, 
			string m3PAR4 = null, 
			string m3PAR5 = null, 
			string m3PAR6 = null, 
			string m3PAR7 = null, 
			string m3PAR8 = null, 
			string m3PAR9 = null, 
			string m3SEND = null, 
			string m3MSGF = null, 
			int? m3RGTM = null, 
			DateTime? m3RGDT = null, 
			string m3OPT2 = null, 
			string m3PGNM = null, 
			int? m3QTTP = null, 
			string m3PICC = null, 
			string m3FL01 = null, 
			string m3FL02 = null, 
			string m3FL03 = null, 
			string m3FL04 = null, 
			string m3FL05 = null, 
			string m3FL06 = null, 
			string m3FL07 = null, 
			string m3FL08 = null, 
			string m3FL09 = null, 
			string m3FL10 = null, 
			string m3DT01 = null, 
			string m3DT02 = null, 
			string m3DT03 = null, 
			string m3DT04 = null, 
			string m3DT05 = null, 
			string m3DT06 = null, 
			string m3DT07 = null, 
			string m3DT08 = null, 
			string m3DT09 = null, 
			string m3DT10 = null, 
			int? m3BODE = null, 
			int? m3BDMT = null, 
			string m3OFNC = null, 
			string m3FILE = null, 
			string m3FLDI = null, 
			string m3KSTR = null, 
			string m3TX30 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REC2))
				throw new ArgumentNullException(nameof(m3REC2));
			if (string.IsNullOrWhiteSpace(m3MTPE))
				throw new ArgumentNullException(nameof(m3MTPE));

			// Set mandatory parameters
			request
				.WithQueryParameter("REC2", m3REC2.Trim())
				.WithQueryParameter("MTPE", m3MTPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADAT.HasValue)
				request.WithQueryParameter("ADAT", m3ADAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PAR1))
				request.WithQueryParameter("PAR1", m3PAR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAR2))
				request.WithQueryParameter("PAR2", m3PAR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAR3))
				request.WithQueryParameter("PAR3", m3PAR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAR4))
				request.WithQueryParameter("PAR4", m3PAR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAR5))
				request.WithQueryParameter("PAR5", m3PAR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAR6))
				request.WithQueryParameter("PAR6", m3PAR6.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAR7))
				request.WithQueryParameter("PAR7", m3PAR7.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAR8))
				request.WithQueryParameter("PAR8", m3PAR8.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAR9))
				request.WithQueryParameter("PAR9", m3PAR9.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEND))
				request.WithQueryParameter("SEND", m3SEND.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGF))
				request.WithQueryParameter("MSGF", m3MSGF.Trim());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OPT2))
				request.WithQueryParameter("OPT2", m3OPT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());
			if (m3QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3QTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PICC))
				request.WithQueryParameter("PICC", m3PICC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL01))
				request.WithQueryParameter("FL01", m3FL01.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL02))
				request.WithQueryParameter("FL02", m3FL02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL03))
				request.WithQueryParameter("FL03", m3FL03.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL04))
				request.WithQueryParameter("FL04", m3FL04.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL05))
				request.WithQueryParameter("FL05", m3FL05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL06))
				request.WithQueryParameter("FL06", m3FL06.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL07))
				request.WithQueryParameter("FL07", m3FL07.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL08))
				request.WithQueryParameter("FL08", m3FL08.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL09))
				request.WithQueryParameter("FL09", m3FL09.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL10))
				request.WithQueryParameter("FL10", m3FL10.Trim());
			if (!string.IsNullOrWhiteSpace(m3DT01))
				request.WithQueryParameter("DT01", m3DT01.Trim());
			if (!string.IsNullOrWhiteSpace(m3DT02))
				request.WithQueryParameter("DT02", m3DT02.Trim());
			if (!string.IsNullOrWhiteSpace(m3DT03))
				request.WithQueryParameter("DT03", m3DT03.Trim());
			if (!string.IsNullOrWhiteSpace(m3DT04))
				request.WithQueryParameter("DT04", m3DT04.Trim());
			if (!string.IsNullOrWhiteSpace(m3DT05))
				request.WithQueryParameter("DT05", m3DT05.Trim());
			if (!string.IsNullOrWhiteSpace(m3DT06))
				request.WithQueryParameter("DT06", m3DT06.Trim());
			if (!string.IsNullOrWhiteSpace(m3DT07))
				request.WithQueryParameter("DT07", m3DT07.Trim());
			if (!string.IsNullOrWhiteSpace(m3DT08))
				request.WithQueryParameter("DT08", m3DT08.Trim());
			if (!string.IsNullOrWhiteSpace(m3DT09))
				request.WithQueryParameter("DT09", m3DT09.Trim());
			if (!string.IsNullOrWhiteSpace(m3DT10))
				request.WithQueryParameter("DT10", m3DT10.Trim());
			if (m3BODE.HasValue)
				request.WithQueryParameter("BODE", m3BODE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BDMT.HasValue)
				request.WithQueryParameter("BDMT", m3BDMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OFNC))
				request.WithQueryParameter("OFNC", m3OFNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3KSTR))
				request.WithQueryParameter("KSTR", m3KSTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name AddFreeText
		/// Description Add free text to an application message
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MLID">Unique id (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFreeText(
			decimal m3MLID, 
			int? m3CONO = null, 
			string m3TX60 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddFreeText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3MLID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());

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
		/// Name Complete
		/// Description Sets the status of a message to Complete (50)
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3MLID">Mail (Required)</param>
		/// <param name="m3CDAT">Completed date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Complete(
			decimal m3MLID, 
			DateTime? m3CDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Complete",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3MLID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CDAT.HasValue)
				request.WithQueryParameter("CDAT", m3CDAT.Value.ToM3String());

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
		/// Name Delete
		/// Description Delete application message
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MLID">Unique id (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			decimal m3MLID, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3MLID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Get
		/// Description Get application message
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MLID">Unique mail-id (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			decimal m3MLID, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3MLID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name GetAndSetSts
		/// Description Get application message and set status to opened
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MLID">Unique mail-id (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAndSetStsResponse></returns>
		/// <exception cref="M3Exception<GetAndSetStsResponse>"></exception>
		public async Task<M3Response<GetAndSetStsResponse>> GetAndSetSts(
			decimal m3MLID, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAndSetSts",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3MLID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAndSetStsResponse>(
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
		/// Name GetBookmark
		/// Description Get Bookmark info
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3MLID">Mail (Required)</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3DTRF">Data identity reference</param>
		/// <param name="m3DTIS">Data identity subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBookmarkResponse></returns>
		/// <exception cref="M3Exception<GetBookmarkResponse>"></exception>
		public async Task<M3Response<GetBookmarkResponse>> GetBookmark(
			decimal m3MLID, 
			decimal? m3DTID = null, 
			int? m3DTRF = null, 
			int? m3DTIS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBookmark",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3MLID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTRF.HasValue)
				request.WithQueryParameter("DTRF", m3DTRF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTIS.HasValue)
				request.WithQueryParameter("DTIS", m3DTIS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBookmarkResponse>(
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
		/// Name GetFreeText
		/// Description Gets the free text connected to an application message
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MLID">Unique id (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFreeTextResponse></returns>
		/// <exception cref="M3Exception<GetFreeTextResponse>"></exception>
		public async Task<M3Response<GetFreeTextResponse>> GetFreeText(
			decimal m3MLID, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetFreeText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3MLID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetFreeTextResponse>(
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
		/// Name LstBookmarkKeys
		/// Description List Bookmark keystring
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MLID">Mail (Required)</param>
		/// <param name="m3DTID">Data identity</param>
		/// <param name="m3DTRF">Data identity reference</param>
		/// <param name="m3DTIS">Data identity subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBookmarkKeysResponse></returns>
		/// <exception cref="M3Exception<LstBookmarkKeysResponse>"></exception>
		public async Task<M3Response<LstBookmarkKeysResponse>> LstBookmarkKeys(
			decimal m3MLID, 
			decimal? m3DTID = null, 
			int? m3DTRF = null, 
			int? m3DTIS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBookmarkKeys",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3MLID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3DTID.HasValue)
				request.WithQueryParameter("DTID", m3DTID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTRF.HasValue)
				request.WithQueryParameter("DTRF", m3DTRF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTIS.HasValue)
				request.WithQueryParameter("DTIS", m3DTIS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstBookmarkKeysResponse>(
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
		/// Name LstByActDate
		/// Description List application messages by Action date - ascending
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ADAT">Action Date</param>
		/// <param name="m3REC2">Receiver (Blank = current)</param>
		/// <param name="m3FSTS">From status</param>
		/// <param name="m3TSTS">To status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByActDateResponse></returns>
		/// <exception cref="M3Exception<LstByActDateResponse>"></exception>
		public async Task<M3Response<LstByActDateResponse>> LstByActDate(
			int? m3CONO = null, 
			DateTime? m3ADAT = null, 
			string m3REC2 = null, 
			string m3FSTS = null, 
			string m3TSTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByActDate",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADAT.HasValue)
				request.WithQueryParameter("ADAT", m3ADAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3REC2))
				request.WithQueryParameter("REC2", m3REC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSTS))
				request.WithQueryParameter("FSTS", m3FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTS))
				request.WithQueryParameter("TSTS", m3TSTS.Trim());

			// Execute the request
			var result = await Execute<LstByActDateResponse>(
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
		/// Name LstByActDateDsc
		/// Description List application messages by Action date - descending
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ADAT">Action Date</param>
		/// <param name="m3REC2">Receiver (blank = current)</param>
		/// <param name="m3FSTS">From status</param>
		/// <param name="m3TSTS">To status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByActDateDscResponse></returns>
		/// <exception cref="M3Exception<LstByActDateDscResponse>"></exception>
		public async Task<M3Response<LstByActDateDscResponse>> LstByActDateDsc(
			int? m3CONO = null, 
			DateTime? m3ADAT = null, 
			string m3REC2 = null, 
			string m3FSTS = null, 
			string m3TSTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByActDateDsc",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADAT.HasValue)
				request.WithQueryParameter("ADAT", m3ADAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3REC2))
				request.WithQueryParameter("REC2", m3REC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSTS))
				request.WithQueryParameter("FSTS", m3FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTS))
				request.WithQueryParameter("TSTS", m3TSTS.Trim());

			// Execute the request
			var result = await Execute<LstByActDateDscResponse>(
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
		/// Name LstByRegDate
		/// Description List application messages by Registration date - ascending
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RGDT">Message registration date (Required)</param>
		/// <param name="m3RGTM">Message registration time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3REC2">Receiver (blank = current)</param>
		/// <param name="m3FSTS">From status</param>
		/// <param name="m3TSTS">To status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByRegDateResponse></returns>
		/// <exception cref="M3Exception<LstByRegDateResponse>"></exception>
		public async Task<M3Response<LstByRegDateResponse>> LstByRegDate(
			DateTime m3RGDT, 
			int m3RGTM, 
			int? m3CONO = null, 
			string m3REC2 = null, 
			string m3FSTS = null, 
			string m3TSTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByRegDate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("RGDT", m3RGDT.ToM3String())
				.WithQueryParameter("RGTM", m3RGTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REC2))
				request.WithQueryParameter("REC2", m3REC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSTS))
				request.WithQueryParameter("FSTS", m3FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTS))
				request.WithQueryParameter("TSTS", m3TSTS.Trim());

			// Execute the request
			var result = await Execute<LstByRegDateResponse>(
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
		/// Name LstByRegDateDsc
		/// Description List application messages by Registration date - descending
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RGDT">Message registration date (Required)</param>
		/// <param name="m3RGTM">Message registration time (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3REC2">Receiver (blank = current)</param>
		/// <param name="m3FSTS">From status</param>
		/// <param name="m3TSTS">To status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByRegDateDscResponse></returns>
		/// <exception cref="M3Exception<LstByRegDateDscResponse>"></exception>
		public async Task<M3Response<LstByRegDateDscResponse>> LstByRegDateDsc(
			DateTime m3RGDT, 
			int m3RGTM, 
			int? m3CONO = null, 
			string m3REC2 = null, 
			string m3FSTS = null, 
			string m3TSTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByRegDateDsc",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("RGDT", m3RGDT.ToM3String())
				.WithQueryParameter("RGTM", m3RGTM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REC2))
				request.WithQueryParameter("REC2", m3REC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSTS))
				request.WithQueryParameter("FSTS", m3FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTS))
				request.WithQueryParameter("TSTS", m3TSTS.Trim());

			// Execute the request
			var result = await Execute<LstByRegDateDscResponse>(
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
		/// Name LstDetailMsg
		/// Description List detailed messages
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DTID">Data identity (Required)</param>
		/// <param name="m3DTRF">Data identity reference</param>
		/// <param name="m3DTIS">Data identity subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDetailMsgResponse></returns>
		/// <exception cref="M3Exception<LstDetailMsgResponse>"></exception>
		public async Task<M3Response<LstDetailMsgResponse>> LstDetailMsg(
			decimal m3DTID, 
			int? m3DTRF = null, 
			int? m3DTIS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDetailMsg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DTID", m3DTID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3DTRF.HasValue)
				request.WithQueryParameter("DTRF", m3DTRF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTIS.HasValue)
				request.WithQueryParameter("DTIS", m3DTIS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDetailMsgResponse>(
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
		/// Name LstFreeText
		/// Description Gets the free text connected to an application message
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MLID">Unique id (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFreeTextResponse></returns>
		/// <exception cref="M3Exception<LstFreeTextResponse>"></exception>
		public async Task<M3Response<LstFreeTextResponse>> LstFreeText(
			decimal m3MLID, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFreeText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3MLID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstFreeTextResponse>(
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
		/// Name Reorganize
		/// Description Remove old application messages
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ReorganizeResponse></returns>
		/// <exception cref="M3Exception<ReorganizeResponse>"></exception>
		public async Task<M3Response<ReorganizeResponse>> Reorganize(
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Reorganize",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ReorganizeResponse>(
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
