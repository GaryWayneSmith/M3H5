/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add table
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3RFMT">Format</param>
		/// <param name="m3FTYP">Table type</param>
		/// <param name="m3SEQ1">Sequence number</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3MXKL">Max key length</param>
		/// <param name="m3MXRL">Max record length</param>
		/// <param name="m3BOFI">Physical file</param>
		/// <param name="m3KEY1">Key field</param>
		/// <param name="m3KEY2">Key field</param>
		/// <param name="m3KEY3">Key field</param>
		/// <param name="m3KEY4">Key field</param>
		/// <param name="m3KEY5">Key field</param>
		/// <param name="m3KEY6">Key field</param>
		/// <param name="m3KEY7">Key field</param>
		/// <param name="m3KEY8">Key field</param>
		/// <param name="m3KEY9">Key field</param>
		/// <param name="m3RFL1">Reference field</param>
		/// <param name="m3RFL2">Reference field</param>
		/// <param name="m3RFL3">Reference field</param>
		/// <param name="m3RFL4">Reference field</param>
		/// <param name="m3RFL5">Reference field</param>
		/// <param name="m3RFL6">Reference field</param>
		/// <param name="m3RFL7">Reference field</param>
		/// <param name="m3RFL8">Reference field</param>
		/// <param name="m3RFL9">Reference field</param>
		/// <param name="m3BPGM">Browse function</param>
		/// <param name="m3FNAR">Archiving function</param>
		/// <param name="m3FNMD">Mass delete function</param>
		/// <param name="m3APGM">Security function</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3FILE = null, 
			string m3RFMT = null, 
			string m3FTYP = null, 
			int? m3SEQ1 = null, 
			string m3RFID = null, 
			int? m3MXKL = null, 
			int? m3MXRL = null, 
			string m3BOFI = null, 
			string m3KEY1 = null, 
			string m3KEY2 = null, 
			string m3KEY3 = null, 
			string m3KEY4 = null, 
			string m3KEY5 = null, 
			string m3KEY6 = null, 
			string m3KEY7 = null, 
			string m3KEY8 = null, 
			string m3KEY9 = null, 
			string m3RFL1 = null, 
			string m3RFL2 = null, 
			string m3RFL3 = null, 
			string m3RFL4 = null, 
			string m3RFL5 = null, 
			string m3RFL6 = null, 
			string m3RFL7 = null, 
			string m3RFL8 = null, 
			string m3RFL9 = null, 
			string m3BPGM = null, 
			string m3FNAR = null, 
			string m3FNMD = null, 
			string m3APGM = null, 
			string m3MSID = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFMT))
				request.WithQueryParameter("RFMT", m3RFMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTYP))
				request.WithQueryParameter("FTYP", m3FTYP.Trim());
			if (m3SEQ1.HasValue)
				request.WithQueryParameter("SEQ1", m3SEQ1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (m3MXKL.HasValue)
				request.WithQueryParameter("MXKL", m3MXKL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXRL.HasValue)
				request.WithQueryParameter("MXRL", m3MXRL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BOFI))
				request.WithQueryParameter("BOFI", m3BOFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY1))
				request.WithQueryParameter("KEY1", m3KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY2))
				request.WithQueryParameter("KEY2", m3KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY3))
				request.WithQueryParameter("KEY3", m3KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY4))
				request.WithQueryParameter("KEY4", m3KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY5))
				request.WithQueryParameter("KEY5", m3KEY5.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY6))
				request.WithQueryParameter("KEY6", m3KEY6.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY7))
				request.WithQueryParameter("KEY7", m3KEY7.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY8))
				request.WithQueryParameter("KEY8", m3KEY8.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY9))
				request.WithQueryParameter("KEY9", m3KEY9.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL1))
				request.WithQueryParameter("RFL1", m3RFL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL2))
				request.WithQueryParameter("RFL2", m3RFL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL3))
				request.WithQueryParameter("RFL3", m3RFL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL4))
				request.WithQueryParameter("RFL4", m3RFL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL5))
				request.WithQueryParameter("RFL5", m3RFL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL6))
				request.WithQueryParameter("RFL6", m3RFL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL7))
				request.WithQueryParameter("RFL7", m3RFL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL8))
				request.WithQueryParameter("RFL8", m3RFL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL9))
				request.WithQueryParameter("RFL9", m3RFL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3BPGM))
				request.WithQueryParameter("BPGM", m3BPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3FNAR))
				request.WithQueryParameter("FNAR", m3FNAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3FNMD))
				request.WithQueryParameter("FNMD", m3FNMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3APGM))
				request.WithQueryParameter("APGM", m3APGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());

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
		/// Name Chg
		/// Description Change table
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3RFMT">Format</param>
		/// <param name="m3FTYP">Table type</param>
		/// <param name="m3SEQ1">Sequence number</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3MXKL">Max key length</param>
		/// <param name="m3MXRL">Max record length</param>
		/// <param name="m3BOFI">Physical file</param>
		/// <param name="m3KEY1">Key field</param>
		/// <param name="m3KEY2">Key field</param>
		/// <param name="m3KEY3">Key field</param>
		/// <param name="m3KEY4">Key field</param>
		/// <param name="m3KEY5">Key field</param>
		/// <param name="m3KEY6">Key field</param>
		/// <param name="m3KEY7">Key field</param>
		/// <param name="m3KEY8">Key field</param>
		/// <param name="m3KEY9">Key field</param>
		/// <param name="m3RFL1">Reference field</param>
		/// <param name="m3RFL2">Reference field</param>
		/// <param name="m3RFL3">Reference field</param>
		/// <param name="m3RFL4">Reference field</param>
		/// <param name="m3RFL5">Reference field</param>
		/// <param name="m3RFL6">Reference field</param>
		/// <param name="m3RFL7">Reference field</param>
		/// <param name="m3RFL8">Reference field</param>
		/// <param name="m3RFL9">Reference field</param>
		/// <param name="m3BPGM">Browse function</param>
		/// <param name="m3FNAR">Archiving function</param>
		/// <param name="m3FNMD">Mass delete function</param>
		/// <param name="m3APGM">Security function</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Chg(
			string m3FILE = null, 
			string m3RFMT = null, 
			string m3FTYP = null, 
			int? m3SEQ1 = null, 
			string m3RFID = null, 
			int? m3MXKL = null, 
			int? m3MXRL = null, 
			string m3BOFI = null, 
			string m3KEY1 = null, 
			string m3KEY2 = null, 
			string m3KEY3 = null, 
			string m3KEY4 = null, 
			string m3KEY5 = null, 
			string m3KEY6 = null, 
			string m3KEY7 = null, 
			string m3KEY8 = null, 
			string m3KEY9 = null, 
			string m3RFL1 = null, 
			string m3RFL2 = null, 
			string m3RFL3 = null, 
			string m3RFL4 = null, 
			string m3RFL5 = null, 
			string m3RFL6 = null, 
			string m3RFL7 = null, 
			string m3RFL8 = null, 
			string m3RFL9 = null, 
			string m3BPGM = null, 
			string m3FNAR = null, 
			string m3FNMD = null, 
			string m3APGM = null, 
			string m3MSID = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Chg",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFMT))
				request.WithQueryParameter("RFMT", m3RFMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTYP))
				request.WithQueryParameter("FTYP", m3FTYP.Trim());
			if (m3SEQ1.HasValue)
				request.WithQueryParameter("SEQ1", m3SEQ1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (m3MXKL.HasValue)
				request.WithQueryParameter("MXKL", m3MXKL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXRL.HasValue)
				request.WithQueryParameter("MXRL", m3MXRL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BOFI))
				request.WithQueryParameter("BOFI", m3BOFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY1))
				request.WithQueryParameter("KEY1", m3KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY2))
				request.WithQueryParameter("KEY2", m3KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY3))
				request.WithQueryParameter("KEY3", m3KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY4))
				request.WithQueryParameter("KEY4", m3KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY5))
				request.WithQueryParameter("KEY5", m3KEY5.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY6))
				request.WithQueryParameter("KEY6", m3KEY6.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY7))
				request.WithQueryParameter("KEY7", m3KEY7.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY8))
				request.WithQueryParameter("KEY8", m3KEY8.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY9))
				request.WithQueryParameter("KEY9", m3KEY9.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL1))
				request.WithQueryParameter("RFL1", m3RFL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL2))
				request.WithQueryParameter("RFL2", m3RFL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL3))
				request.WithQueryParameter("RFL3", m3RFL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL4))
				request.WithQueryParameter("RFL4", m3RFL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL5))
				request.WithQueryParameter("RFL5", m3RFL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL6))
				request.WithQueryParameter("RFL6", m3RFL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL7))
				request.WithQueryParameter("RFL7", m3RFL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL8))
				request.WithQueryParameter("RFL8", m3RFL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFL9))
				request.WithQueryParameter("RFL9", m3RFL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3BPGM))
				request.WithQueryParameter("BPGM", m3BPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3FNAR))
				request.WithQueryParameter("FNAR", m3FNAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3FNMD))
				request.WithQueryParameter("FNMD", m3FNMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3APGM))
				request.WithQueryParameter("APGM", m3APGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());

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
		/// Name Del
		/// Description Delet table
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3FILE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

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
		/// Description Get table
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3FILE, 
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
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

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
		/// Name Lst
		/// Description List table
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3BOFI">Physical file</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3BOFI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BOFI))
				request.WithQueryParameter("BOFI", m3BOFI.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
