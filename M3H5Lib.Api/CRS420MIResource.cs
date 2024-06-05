/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Adds a new application message
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_REC2">Application message receiver (Required)</param>
		/// <param name="m3_MTPE">Application message type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ADAT">Action date</param>
		/// <param name="m3_PAR1">Parameter 1</param>
		/// <param name="m3_PAR2">Parameter 2</param>
		/// <param name="m3_PAR3">Parameter 3</param>
		/// <param name="m3_PAR4">Parameter 4</param>
		/// <param name="m3_PAR5">Parameter 5</param>
		/// <param name="m3_PAR6">Parameter 6</param>
		/// <param name="m3_PAR7">Parameter 7</param>
		/// <param name="m3_PAR8">Parameter 8</param>
		/// <param name="m3_PAR9">Parameter 9</param>
		/// <param name="m3_SEND">Sender</param>
		/// <param name="m3_MSGF">Message file</param>
		/// <param name="m3_RGTM">Application message time</param>
		/// <param name="m3_RGDT">Application message date</param>
		/// <param name="m3_OPT2">Opt. 11 - Option</param>
		/// <param name="m3_PGNM">Opt. 11 - Program name</param>
		/// <param name="m3_QTTP">Opt. 11 - Inquiry type</param>
		/// <param name="m3_PICC">Opt. 11 - Opening picture</param>
		/// <param name="m3_FL01">Opt. 11 - Name of MVXLDA field 1</param>
		/// <param name="m3_FL02">Opt. 11 - Name of MVXLDA field 2</param>
		/// <param name="m3_FL03">Opt. 11 - Name of MVXLDA field 3</param>
		/// <param name="m3_FL04">Opt. 11 - Name of MVXLDA field 4</param>
		/// <param name="m3_FL05">Opt. 11 - Name of MVXLDA field 5</param>
		/// <param name="m3_FL06">Opt. 11 - Name of MVXLDA field 6</param>
		/// <param name="m3_FL07">Opt. 11 - Name of MVXLDA field 7</param>
		/// <param name="m3_FL08">Opt. 11 - Name of MVXLDA field 8</param>
		/// <param name="m3_FL09">Opt. 11 - Name of MVXLDA field 9</param>
		/// <param name="m3_FL10">Opt. 11 - Name of MVXLDA field 10</param>
		/// <param name="m3_DT01">Opt. 11 - Data in MVXLDA field 1</param>
		/// <param name="m3_DT02">Opt. 11 - Data in MVXLDA field 2</param>
		/// <param name="m3_DT03">Opt. 11 - Data in MVXLDA field 3</param>
		/// <param name="m3_DT04">Opt. 11 - Data in MVXLDA field 4</param>
		/// <param name="m3_DT05">Opt. 11 - Data in MVXLDA field 5</param>
		/// <param name="m3_DT06">Opt. 11 - Data in MVXLDA field 6</param>
		/// <param name="m3_DT07">Opt. 11 - Data in MVXLDA field 7</param>
		/// <param name="m3_DT08">Opt. 11 - Data in MVXLDA field 8</param>
		/// <param name="m3_DT09">Opt. 11 - Data in MVXLDA field 9</param>
		/// <param name="m3_DT10">Opt. 11 - Data in MVXLDA field 10</param>
		/// <param name="m3_BODE">BOD enabled</param>
		/// <param name="m3_BDMT">BOD message type</param>
		/// <param name="m3_OFNC">Overriding function</param>
		/// <param name="m3_FILE">File</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="m3_KSTR">Keystring</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3_REC2, 
			string m3_MTPE, 
			int? m3_CONO = null, 
			DateTime? m3_ADAT = null, 
			string m3_PAR1 = null, 
			string m3_PAR2 = null, 
			string m3_PAR3 = null, 
			string m3_PAR4 = null, 
			string m3_PAR5 = null, 
			string m3_PAR6 = null, 
			string m3_PAR7 = null, 
			string m3_PAR8 = null, 
			string m3_PAR9 = null, 
			string m3_SEND = null, 
			string m3_MSGF = null, 
			int? m3_RGTM = null, 
			DateTime? m3_RGDT = null, 
			string m3_OPT2 = null, 
			string m3_PGNM = null, 
			int? m3_QTTP = null, 
			string m3_PICC = null, 
			string m3_FL01 = null, 
			string m3_FL02 = null, 
			string m3_FL03 = null, 
			string m3_FL04 = null, 
			string m3_FL05 = null, 
			string m3_FL06 = null, 
			string m3_FL07 = null, 
			string m3_FL08 = null, 
			string m3_FL09 = null, 
			string m3_FL10 = null, 
			string m3_DT01 = null, 
			string m3_DT02 = null, 
			string m3_DT03 = null, 
			string m3_DT04 = null, 
			string m3_DT05 = null, 
			string m3_DT06 = null, 
			string m3_DT07 = null, 
			string m3_DT08 = null, 
			string m3_DT09 = null, 
			string m3_DT10 = null, 
			int? m3_BODE = null, 
			int? m3_BDMT = null, 
			string m3_OFNC = null, 
			string m3_FILE = null, 
			string m3_FLDI = null, 
			string m3_KSTR = null, 
			string m3_TX30 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REC2))
				throw new ArgumentNullException("m3_REC2");
			if (string.IsNullOrWhiteSpace(m3_MTPE))
				throw new ArgumentNullException("m3_MTPE");

			// Set mandatory parameters
			request
				.WithQueryParameter("REC2", m3_REC2.Trim())
				.WithQueryParameter("MTPE", m3_MTPE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ADAT.HasValue)
				request.WithQueryParameter("ADAT", m3_ADAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PAR1))
				request.WithQueryParameter("PAR1", m3_PAR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAR2))
				request.WithQueryParameter("PAR2", m3_PAR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAR3))
				request.WithQueryParameter("PAR3", m3_PAR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAR4))
				request.WithQueryParameter("PAR4", m3_PAR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAR5))
				request.WithQueryParameter("PAR5", m3_PAR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAR6))
				request.WithQueryParameter("PAR6", m3_PAR6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAR7))
				request.WithQueryParameter("PAR7", m3_PAR7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAR8))
				request.WithQueryParameter("PAR8", m3_PAR8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAR9))
				request.WithQueryParameter("PAR9", m3_PAR9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEND))
				request.WithQueryParameter("SEND", m3_SEND.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGF))
				request.WithQueryParameter("MSGF", m3_MSGF.Trim());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OPT2))
				request.WithQueryParameter("OPT2", m3_OPT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());
			if (m3_QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3_QTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PICC))
				request.WithQueryParameter("PICC", m3_PICC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL01))
				request.WithQueryParameter("FL01", m3_FL01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL02))
				request.WithQueryParameter("FL02", m3_FL02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL03))
				request.WithQueryParameter("FL03", m3_FL03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL04))
				request.WithQueryParameter("FL04", m3_FL04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL05))
				request.WithQueryParameter("FL05", m3_FL05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL06))
				request.WithQueryParameter("FL06", m3_FL06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL07))
				request.WithQueryParameter("FL07", m3_FL07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL08))
				request.WithQueryParameter("FL08", m3_FL08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL09))
				request.WithQueryParameter("FL09", m3_FL09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL10))
				request.WithQueryParameter("FL10", m3_FL10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DT01))
				request.WithQueryParameter("DT01", m3_DT01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DT02))
				request.WithQueryParameter("DT02", m3_DT02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DT03))
				request.WithQueryParameter("DT03", m3_DT03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DT04))
				request.WithQueryParameter("DT04", m3_DT04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DT05))
				request.WithQueryParameter("DT05", m3_DT05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DT06))
				request.WithQueryParameter("DT06", m3_DT06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DT07))
				request.WithQueryParameter("DT07", m3_DT07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DT08))
				request.WithQueryParameter("DT08", m3_DT08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DT09))
				request.WithQueryParameter("DT09", m3_DT09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DT10))
				request.WithQueryParameter("DT10", m3_DT10.Trim());
			if (m3_BODE.HasValue)
				request.WithQueryParameter("BODE", m3_BODE.Value.ToString());
			if (m3_BDMT.HasValue)
				request.WithQueryParameter("BDMT", m3_BDMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OFNC))
				request.WithQueryParameter("OFNC", m3_OFNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KSTR))
				request.WithQueryParameter("KSTR", m3_KSTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name AddFreeText
		/// Description Add free text to an application message
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MLID">Unique id (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFreeText(
			decimal m3_MLID, 
			int? m3_CONO = null, 
			string m3_TX60 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFreeText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3_MLID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());

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
		/// Name Complete
		/// Description Sets the status of a message to Complete (50)
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_MLID">Mail (Required)</param>
		/// <param name="m3_CDAT">Completed date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Complete(
			decimal m3_MLID, 
			DateTime? m3_CDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Complete",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3_MLID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CDAT.HasValue)
				request.WithQueryParameter("CDAT", m3_CDAT.Value.ToM3String());

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
		/// Name Delete
		/// Description Delete application message
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MLID">Unique id (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			decimal m3_MLID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3_MLID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name Get
		/// Description Get application message
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MLID">Unique mail-id (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			decimal m3_MLID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3_MLID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name GetAndSetSts
		/// Description Get application message and set status to opened
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MLID">Unique mail-id (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAndSetStsResponse></returns>
		/// <exception cref="M3Exception<GetAndSetStsResponse>"></exception>
		public async Task<M3Response<GetAndSetStsResponse>> GetAndSetSts(
			decimal m3_MLID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAndSetSts",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3_MLID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetAndSetStsResponse>(
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
		/// Name GetBookmark
		/// Description Get Bookmark info
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_MLID">Mail (Required)</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_DTRF">Data identity reference</param>
		/// <param name="m3_DTIS">Data identity subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBookmarkResponse></returns>
		/// <exception cref="M3Exception<GetBookmarkResponse>"></exception>
		public async Task<M3Response<GetBookmarkResponse>> GetBookmark(
			decimal m3_MLID, 
			decimal? m3_DTID = null, 
			int? m3_DTRF = null, 
			int? m3_DTIS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBookmark",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3_MLID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_DTRF.HasValue)
				request.WithQueryParameter("DTRF", m3_DTRF.Value.ToString());
			if (m3_DTIS.HasValue)
				request.WithQueryParameter("DTIS", m3_DTIS.Value.ToString());

			// Execute the request
			var result = await Execute<GetBookmarkResponse>(
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
		/// Name GetFreeText
		/// Description Gets the free text connected to an application message
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MLID">Unique id (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFreeTextResponse></returns>
		/// <exception cref="M3Exception<GetFreeTextResponse>"></exception>
		public async Task<M3Response<GetFreeTextResponse>> GetFreeText(
			decimal m3_MLID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFreeText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3_MLID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetFreeTextResponse>(
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
		/// Name LstBookmarkKeys
		/// Description List Bookmark keystring
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MLID">Mail (Required)</param>
		/// <param name="m3_DTID">Data identity</param>
		/// <param name="m3_DTRF">Data identity reference</param>
		/// <param name="m3_DTIS">Data identity subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBookmarkKeysResponse></returns>
		/// <exception cref="M3Exception<LstBookmarkKeysResponse>"></exception>
		public async Task<M3Response<LstBookmarkKeysResponse>> LstBookmarkKeys(
			decimal m3_MLID, 
			decimal? m3_DTID = null, 
			int? m3_DTRF = null, 
			int? m3_DTIS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBookmarkKeys",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3_MLID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DTID.HasValue)
				request.WithQueryParameter("DTID", m3_DTID.Value.ToString());
			if (m3_DTRF.HasValue)
				request.WithQueryParameter("DTRF", m3_DTRF.Value.ToString());
			if (m3_DTIS.HasValue)
				request.WithQueryParameter("DTIS", m3_DTIS.Value.ToString());

			// Execute the request
			var result = await Execute<LstBookmarkKeysResponse>(
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
		/// Name LstByActDate
		/// Description List application messages by Action date - ascending
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ADAT">Action Date</param>
		/// <param name="m3_REC2">Receiver (Blank = current)</param>
		/// <param name="m3_FSTS">From status</param>
		/// <param name="m3_TSTS">To status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByActDateResponse></returns>
		/// <exception cref="M3Exception<LstByActDateResponse>"></exception>
		public async Task<M3Response<LstByActDateResponse>> LstByActDate(
			int? m3_CONO = null, 
			DateTime? m3_ADAT = null, 
			string m3_REC2 = null, 
			string m3_FSTS = null, 
			string m3_TSTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByActDate",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ADAT.HasValue)
				request.WithQueryParameter("ADAT", m3_ADAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_REC2))
				request.WithQueryParameter("REC2", m3_REC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSTS))
				request.WithQueryParameter("FSTS", m3_FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTS))
				request.WithQueryParameter("TSTS", m3_TSTS.Trim());

			// Execute the request
			var result = await Execute<LstByActDateResponse>(
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
		/// Name LstByActDateDsc
		/// Description List application messages by Action date - descending
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ADAT">Action Date</param>
		/// <param name="m3_REC2">Receiver (blank = current)</param>
		/// <param name="m3_FSTS">From status</param>
		/// <param name="m3_TSTS">To status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByActDateDscResponse></returns>
		/// <exception cref="M3Exception<LstByActDateDscResponse>"></exception>
		public async Task<M3Response<LstByActDateDscResponse>> LstByActDateDsc(
			int? m3_CONO = null, 
			DateTime? m3_ADAT = null, 
			string m3_REC2 = null, 
			string m3_FSTS = null, 
			string m3_TSTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByActDateDsc",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ADAT.HasValue)
				request.WithQueryParameter("ADAT", m3_ADAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_REC2))
				request.WithQueryParameter("REC2", m3_REC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSTS))
				request.WithQueryParameter("FSTS", m3_FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTS))
				request.WithQueryParameter("TSTS", m3_TSTS.Trim());

			// Execute the request
			var result = await Execute<LstByActDateDscResponse>(
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
		/// Name LstByRegDate
		/// Description List application messages by Registration date - ascending
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RGDT">Message registration date (Required)</param>
		/// <param name="m3_RGTM">Message registration time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_REC2">Receiver (blank = current)</param>
		/// <param name="m3_FSTS">From status</param>
		/// <param name="m3_TSTS">To status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByRegDateResponse></returns>
		/// <exception cref="M3Exception<LstByRegDateResponse>"></exception>
		public async Task<M3Response<LstByRegDateResponse>> LstByRegDate(
			DateTime m3_RGDT, 
			int m3_RGTM, 
			int? m3_CONO = null, 
			string m3_REC2 = null, 
			string m3_FSTS = null, 
			string m3_TSTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByRegDate",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("RGDT", m3_RGDT.ToM3String())
				.WithQueryParameter("RGTM", m3_RGTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REC2))
				request.WithQueryParameter("REC2", m3_REC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSTS))
				request.WithQueryParameter("FSTS", m3_FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTS))
				request.WithQueryParameter("TSTS", m3_TSTS.Trim());

			// Execute the request
			var result = await Execute<LstByRegDateResponse>(
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
		/// Name LstByRegDateDsc
		/// Description List application messages by Registration date - descending
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RGDT">Message registration date (Required)</param>
		/// <param name="m3_RGTM">Message registration time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_REC2">Receiver (blank = current)</param>
		/// <param name="m3_FSTS">From status</param>
		/// <param name="m3_TSTS">To status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByRegDateDscResponse></returns>
		/// <exception cref="M3Exception<LstByRegDateDscResponse>"></exception>
		public async Task<M3Response<LstByRegDateDscResponse>> LstByRegDateDsc(
			DateTime m3_RGDT, 
			int m3_RGTM, 
			int? m3_CONO = null, 
			string m3_REC2 = null, 
			string m3_FSTS = null, 
			string m3_TSTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByRegDateDsc",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("RGDT", m3_RGDT.ToM3String())
				.WithQueryParameter("RGTM", m3_RGTM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REC2))
				request.WithQueryParameter("REC2", m3_REC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSTS))
				request.WithQueryParameter("FSTS", m3_FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTS))
				request.WithQueryParameter("TSTS", m3_TSTS.Trim());

			// Execute the request
			var result = await Execute<LstByRegDateDscResponse>(
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
		/// Name LstDetailMsg
		/// Description List detailed messages
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DTID">Data identity (Required)</param>
		/// <param name="m3_DTRF">Data identity reference</param>
		/// <param name="m3_DTIS">Data identity subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDetailMsgResponse></returns>
		/// <exception cref="M3Exception<LstDetailMsgResponse>"></exception>
		public async Task<M3Response<LstDetailMsgResponse>> LstDetailMsg(
			decimal m3_DTID, 
			int? m3_DTRF = null, 
			int? m3_DTIS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDetailMsg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DTID", m3_DTID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DTRF.HasValue)
				request.WithQueryParameter("DTRF", m3_DTRF.Value.ToString());
			if (m3_DTIS.HasValue)
				request.WithQueryParameter("DTIS", m3_DTIS.Value.ToString());

			// Execute the request
			var result = await Execute<LstDetailMsgResponse>(
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
		/// Name LstFreeText
		/// Description Gets the free text connected to an application message
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MLID">Unique id (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFreeTextResponse></returns>
		/// <exception cref="M3Exception<LstFreeTextResponse>"></exception>
		public async Task<M3Response<LstFreeTextResponse>> LstFreeText(
			decimal m3_MLID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFreeText",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MLID", m3_MLID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstFreeTextResponse>(
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
		/// Name Reorganize
		/// Description Remove old application messages
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ReorganizeResponse></returns>
		/// <exception cref="M3Exception<ReorganizeResponse>"></exception>
		public async Task<M3Response<ReorganizeResponse>> Reorganize(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Reorganize",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<ReorganizeResponse>(
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
