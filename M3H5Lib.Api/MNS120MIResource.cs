/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MNS120MI;
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
	/// Name: MNS120MI
	/// Component Name: FileHeader
	/// Description: Api: File Header Information Interface
	/// Version Release: 13.1
	///</summary>
	public partial class MNS120MIResource : M3BaseResourceEndpoint
	{
		public MNS120MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS120MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add table
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_RFMT">Format</param>
		/// <param name="m3_FTYP">Table type</param>
		/// <param name="m3_SEQ1">Sequence number</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_MXKL">Max key length</param>
		/// <param name="m3_MXRL">Max record length</param>
		/// <param name="m3_BOFI">Physical file</param>
		/// <param name="m3_KEY1">Key field</param>
		/// <param name="m3_KEY2">Key field</param>
		/// <param name="m3_KEY3">Key field</param>
		/// <param name="m3_KEY4">Key field</param>
		/// <param name="m3_KEY5">Key field</param>
		/// <param name="m3_KEY6">Key field</param>
		/// <param name="m3_KEY7">Key field</param>
		/// <param name="m3_KEY8">Key field</param>
		/// <param name="m3_KEY9">Key field</param>
		/// <param name="m3_RFL1">Reference field</param>
		/// <param name="m3_RFL2">Reference field</param>
		/// <param name="m3_RFL3">Reference field</param>
		/// <param name="m3_RFL4">Reference field</param>
		/// <param name="m3_RFL5">Reference field</param>
		/// <param name="m3_RFL6">Reference field</param>
		/// <param name="m3_RFL7">Reference field</param>
		/// <param name="m3_RFL8">Reference field</param>
		/// <param name="m3_RFL9">Reference field</param>
		/// <param name="m3_BPGM">Browse function</param>
		/// <param name="m3_FNAR">Archiving function</param>
		/// <param name="m3_FNMD">Mass delete function</param>
		/// <param name="m3_APGM">Security function</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_FILE = null, 
			string m3_RFMT = null, 
			string m3_FTYP = null, 
			int? m3_SEQ1 = null, 
			string m3_RFID = null, 
			int? m3_MXKL = null, 
			int? m3_MXRL = null, 
			string m3_BOFI = null, 
			string m3_KEY1 = null, 
			string m3_KEY2 = null, 
			string m3_KEY3 = null, 
			string m3_KEY4 = null, 
			string m3_KEY5 = null, 
			string m3_KEY6 = null, 
			string m3_KEY7 = null, 
			string m3_KEY8 = null, 
			string m3_KEY9 = null, 
			string m3_RFL1 = null, 
			string m3_RFL2 = null, 
			string m3_RFL3 = null, 
			string m3_RFL4 = null, 
			string m3_RFL5 = null, 
			string m3_RFL6 = null, 
			string m3_RFL7 = null, 
			string m3_RFL8 = null, 
			string m3_RFL9 = null, 
			string m3_BPGM = null, 
			string m3_FNAR = null, 
			string m3_FNMD = null, 
			string m3_APGM = null, 
			string m3_MSID = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFMT))
				request.WithQueryParameter("RFMT", m3_RFMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTYP))
				request.WithQueryParameter("FTYP", m3_FTYP.Trim());
			if (m3_SEQ1.HasValue)
				request.WithQueryParameter("SEQ1", m3_SEQ1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (m3_MXKL.HasValue)
				request.WithQueryParameter("MXKL", m3_MXKL.Value.ToString());
			if (m3_MXRL.HasValue)
				request.WithQueryParameter("MXRL", m3_MXRL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BOFI))
				request.WithQueryParameter("BOFI", m3_BOFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY1))
				request.WithQueryParameter("KEY1", m3_KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY2))
				request.WithQueryParameter("KEY2", m3_KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY3))
				request.WithQueryParameter("KEY3", m3_KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY4))
				request.WithQueryParameter("KEY4", m3_KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY5))
				request.WithQueryParameter("KEY5", m3_KEY5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY6))
				request.WithQueryParameter("KEY6", m3_KEY6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY7))
				request.WithQueryParameter("KEY7", m3_KEY7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY8))
				request.WithQueryParameter("KEY8", m3_KEY8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY9))
				request.WithQueryParameter("KEY9", m3_KEY9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL1))
				request.WithQueryParameter("RFL1", m3_RFL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL2))
				request.WithQueryParameter("RFL2", m3_RFL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL3))
				request.WithQueryParameter("RFL3", m3_RFL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL4))
				request.WithQueryParameter("RFL4", m3_RFL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL5))
				request.WithQueryParameter("RFL5", m3_RFL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL6))
				request.WithQueryParameter("RFL6", m3_RFL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL7))
				request.WithQueryParameter("RFL7", m3_RFL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL8))
				request.WithQueryParameter("RFL8", m3_RFL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL9))
				request.WithQueryParameter("RFL9", m3_RFL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BPGM))
				request.WithQueryParameter("BPGM", m3_BPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FNAR))
				request.WithQueryParameter("FNAR", m3_FNAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FNMD))
				request.WithQueryParameter("FNMD", m3_FNMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APGM))
				request.WithQueryParameter("APGM", m3_APGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());

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
		/// Name Chg
		/// Description Change table
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_RFMT">Format</param>
		/// <param name="m3_FTYP">Table type</param>
		/// <param name="m3_SEQ1">Sequence number</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_MXKL">Max key length</param>
		/// <param name="m3_MXRL">Max record length</param>
		/// <param name="m3_BOFI">Physical file</param>
		/// <param name="m3_KEY1">Key field</param>
		/// <param name="m3_KEY2">Key field</param>
		/// <param name="m3_KEY3">Key field</param>
		/// <param name="m3_KEY4">Key field</param>
		/// <param name="m3_KEY5">Key field</param>
		/// <param name="m3_KEY6">Key field</param>
		/// <param name="m3_KEY7">Key field</param>
		/// <param name="m3_KEY8">Key field</param>
		/// <param name="m3_KEY9">Key field</param>
		/// <param name="m3_RFL1">Reference field</param>
		/// <param name="m3_RFL2">Reference field</param>
		/// <param name="m3_RFL3">Reference field</param>
		/// <param name="m3_RFL4">Reference field</param>
		/// <param name="m3_RFL5">Reference field</param>
		/// <param name="m3_RFL6">Reference field</param>
		/// <param name="m3_RFL7">Reference field</param>
		/// <param name="m3_RFL8">Reference field</param>
		/// <param name="m3_RFL9">Reference field</param>
		/// <param name="m3_BPGM">Browse function</param>
		/// <param name="m3_FNAR">Archiving function</param>
		/// <param name="m3_FNMD">Mass delete function</param>
		/// <param name="m3_APGM">Security function</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Chg(
			string m3_FILE = null, 
			string m3_RFMT = null, 
			string m3_FTYP = null, 
			int? m3_SEQ1 = null, 
			string m3_RFID = null, 
			int? m3_MXKL = null, 
			int? m3_MXRL = null, 
			string m3_BOFI = null, 
			string m3_KEY1 = null, 
			string m3_KEY2 = null, 
			string m3_KEY3 = null, 
			string m3_KEY4 = null, 
			string m3_KEY5 = null, 
			string m3_KEY6 = null, 
			string m3_KEY7 = null, 
			string m3_KEY8 = null, 
			string m3_KEY9 = null, 
			string m3_RFL1 = null, 
			string m3_RFL2 = null, 
			string m3_RFL3 = null, 
			string m3_RFL4 = null, 
			string m3_RFL5 = null, 
			string m3_RFL6 = null, 
			string m3_RFL7 = null, 
			string m3_RFL8 = null, 
			string m3_RFL9 = null, 
			string m3_BPGM = null, 
			string m3_FNAR = null, 
			string m3_FNMD = null, 
			string m3_APGM = null, 
			string m3_MSID = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Chg",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFMT))
				request.WithQueryParameter("RFMT", m3_RFMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTYP))
				request.WithQueryParameter("FTYP", m3_FTYP.Trim());
			if (m3_SEQ1.HasValue)
				request.WithQueryParameter("SEQ1", m3_SEQ1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (m3_MXKL.HasValue)
				request.WithQueryParameter("MXKL", m3_MXKL.Value.ToString());
			if (m3_MXRL.HasValue)
				request.WithQueryParameter("MXRL", m3_MXRL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BOFI))
				request.WithQueryParameter("BOFI", m3_BOFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY1))
				request.WithQueryParameter("KEY1", m3_KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY2))
				request.WithQueryParameter("KEY2", m3_KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY3))
				request.WithQueryParameter("KEY3", m3_KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY4))
				request.WithQueryParameter("KEY4", m3_KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY5))
				request.WithQueryParameter("KEY5", m3_KEY5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY6))
				request.WithQueryParameter("KEY6", m3_KEY6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY7))
				request.WithQueryParameter("KEY7", m3_KEY7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY8))
				request.WithQueryParameter("KEY8", m3_KEY8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY9))
				request.WithQueryParameter("KEY9", m3_KEY9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL1))
				request.WithQueryParameter("RFL1", m3_RFL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL2))
				request.WithQueryParameter("RFL2", m3_RFL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL3))
				request.WithQueryParameter("RFL3", m3_RFL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL4))
				request.WithQueryParameter("RFL4", m3_RFL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL5))
				request.WithQueryParameter("RFL5", m3_RFL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL6))
				request.WithQueryParameter("RFL6", m3_RFL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL7))
				request.WithQueryParameter("RFL7", m3_RFL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL8))
				request.WithQueryParameter("RFL8", m3_RFL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFL9))
				request.WithQueryParameter("RFL9", m3_RFL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BPGM))
				request.WithQueryParameter("BPGM", m3_BPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FNAR))
				request.WithQueryParameter("FNAR", m3_FNAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FNMD))
				request.WithQueryParameter("FNMD", m3_FNMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APGM))
				request.WithQueryParameter("APGM", m3_APGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());

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
		/// Name Del
		/// Description Delet table
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3_FILE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim());

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
		/// Description Get table
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_FILE, 
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
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim());

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
		/// Name Lst
		/// Description List table
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_BOFI">Physical file</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_BOFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BOFI))
				request.WithQueryParameter("BOFI", m3_BOFI.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
