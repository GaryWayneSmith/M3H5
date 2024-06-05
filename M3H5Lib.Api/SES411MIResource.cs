/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SES411MI;
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
	/// Name: SES411MI
	/// Component Name: eSign Object
	/// Description: eSign Object interface
	/// Version Release: 5ea0
	///</summary>
	public partial class SES411MIResource : M3BaseResourceEndpoint
	{
		public SES411MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SES411MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddObject
		/// Description Add an eSign Object
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PGNM">Program (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_TX60">Reason (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_ESMT">Sign method</param>
		/// <param name="m3_ESST">Sign strategy</param>
		/// <param name="m3_ESP1">Sign process</param>
		/// <param name="m3_ECIN">Comment input</param>
		/// <param name="m3_SSND">Send application message - successful</param>
		/// <param name="m3_SREC">Receiver - successful</param>
		/// <param name="m3_SBOD">BOD enabled - successful</param>
		/// <param name="m3_SBDM">BOD message type - successful</param>
		/// <param name="m3_SWFN">Workflow name - successful</param>
		/// <param name="m3_FSND">Send application message - failed</param>
		/// <param name="m3_FREC">Receiver - failed</param>
		/// <param name="m3_FBOD">BOD enabled - failed</param>
		/// <param name="m3_FBDM">BOD message type - failed</param>
		/// <param name="m3_FWFN">Workflow name - failed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddObject(
			string m3_PGNM, 
			string m3_FILE, 
			string m3_FLDI, 
			string m3_TX60, 
			string m3_STAT, 
			int? m3_ESMT = null, 
			int? m3_ESST = null, 
			int? m3_ESP1 = null, 
			int? m3_ECIN = null, 
			int? m3_SSND = null, 
			string m3_SREC = null, 
			int? m3_SBOD = null, 
			int? m3_SBDM = null, 
			string m3_SWFN = null, 
			int? m3_FSND = null, 
			string m3_FREC = null, 
			int? m3_FBOD = null, 
			int? m3_FBDM = null, 
			string m3_FWFN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddObject",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_TX60))
				throw new ArgumentNullException("m3_TX60");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("TX60", m3_TX60.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ESMT.HasValue)
				request.WithQueryParameter("ESMT", m3_ESMT.Value.ToString());
			if (m3_ESST.HasValue)
				request.WithQueryParameter("ESST", m3_ESST.Value.ToString());
			if (m3_ESP1.HasValue)
				request.WithQueryParameter("ESP1", m3_ESP1.Value.ToString());
			if (m3_ECIN.HasValue)
				request.WithQueryParameter("ECIN", m3_ECIN.Value.ToString());
			if (m3_SSND.HasValue)
				request.WithQueryParameter("SSND", m3_SSND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SREC))
				request.WithQueryParameter("SREC", m3_SREC.Trim());
			if (m3_SBOD.HasValue)
				request.WithQueryParameter("SBOD", m3_SBOD.Value.ToString());
			if (m3_SBDM.HasValue)
				request.WithQueryParameter("SBDM", m3_SBDM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SWFN))
				request.WithQueryParameter("SWFN", m3_SWFN.Trim());
			if (m3_FSND.HasValue)
				request.WithQueryParameter("FSND", m3_FSND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FREC))
				request.WithQueryParameter("FREC", m3_FREC.Trim());
			if (m3_FBOD.HasValue)
				request.WithQueryParameter("FBOD", m3_FBOD.Value.ToString());
			if (m3_FBDM.HasValue)
				request.WithQueryParameter("FBDM", m3_FBDM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWFN))
				request.WithQueryParameter("FWFN", m3_FWFN.Trim());

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
		/// Name DltObject
		/// Description Delete an eSign Object
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PGNM">Program (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltObject(
			string m3_PGNM, 
			string m3_FILE, 
			string m3_FLDI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltObject",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

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
		/// Name GetObject
		/// Description Get data for an eSign Object
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PGNM">Program (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetObjectResponse></returns>
		/// <exception cref="M3Exception<GetObjectResponse>"></exception>
		public async Task<M3Response<GetObjectResponse>> GetObject(
			string m3_PGNM, 
			string m3_FILE, 
			string m3_FLDI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetObject",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Execute the request
			var result = await Execute<GetObjectResponse>(
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
		/// Name LstObjects
		/// Description List data for eSign Objects
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PGNM">Program</param>
		/// <param name="m3_FILE">File</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstObjectsResponse></returns>
		/// <exception cref="M3Exception<LstObjectsResponse>"></exception>
		public async Task<M3Response<LstObjectsResponse>> LstObjects(
			string m3_PGNM = null, 
			string m3_FILE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstObjects",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());

			// Execute the request
			var result = await Execute<LstObjectsResponse>(
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
		/// Name UpdObject
		/// Description Update data for an eSign Object
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PGNM">Program (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_TX60">Reason</param>
		/// <param name="m3_ESMT">Sign method</param>
		/// <param name="m3_ESST">Sign strategy</param>
		/// <param name="m3_ESP1">Sign process</param>
		/// <param name="m3_ECIN">Comment input</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_SSND">Send application message - successful</param>
		/// <param name="m3_SREC">Receiver - successful</param>
		/// <param name="m3_SBOD">BOD enabled - successful</param>
		/// <param name="m3_SBDM">BOD message type - successful</param>
		/// <param name="m3_SWFN">Workflow name - successful</param>
		/// <param name="m3_FSND">Send application message - failed</param>
		/// <param name="m3_FREC">Receiver - failed</param>
		/// <param name="m3_FBOD">BOD enabled - failed</param>
		/// <param name="m3_FBDM">BOD message type - failed</param>
		/// <param name="m3_FWFN">Workflow name - failed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdObject(
			string m3_PGNM, 
			string m3_FILE, 
			string m3_FLDI, 
			string m3_TX60 = null, 
			int? m3_ESMT = null, 
			int? m3_ESST = null, 
			int? m3_ESP1 = null, 
			int? m3_ECIN = null, 
			string m3_STAT = null, 
			int? m3_SSND = null, 
			string m3_SREC = null, 
			int? m3_SBOD = null, 
			int? m3_SBDM = null, 
			string m3_SWFN = null, 
			int? m3_FSND = null, 
			string m3_FREC = null, 
			int? m3_FBOD = null, 
			int? m3_FBDM = null, 
			string m3_FWFN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdObject",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (m3_ESMT.HasValue)
				request.WithQueryParameter("ESMT", m3_ESMT.Value.ToString());
			if (m3_ESST.HasValue)
				request.WithQueryParameter("ESST", m3_ESST.Value.ToString());
			if (m3_ESP1.HasValue)
				request.WithQueryParameter("ESP1", m3_ESP1.Value.ToString());
			if (m3_ECIN.HasValue)
				request.WithQueryParameter("ECIN", m3_ECIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_SSND.HasValue)
				request.WithQueryParameter("SSND", m3_SSND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SREC))
				request.WithQueryParameter("SREC", m3_SREC.Trim());
			if (m3_SBOD.HasValue)
				request.WithQueryParameter("SBOD", m3_SBOD.Value.ToString());
			if (m3_SBDM.HasValue)
				request.WithQueryParameter("SBDM", m3_SBDM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SWFN))
				request.WithQueryParameter("SWFN", m3_SWFN.Trim());
			if (m3_FSND.HasValue)
				request.WithQueryParameter("FSND", m3_FSND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FREC))
				request.WithQueryParameter("FREC", m3_FREC.Trim());
			if (m3_FBOD.HasValue)
				request.WithQueryParameter("FBOD", m3_FBOD.Value.ToString());
			if (m3_FBDM.HasValue)
				request.WithQueryParameter("FBDM", m3_FBDM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWFN))
				request.WithQueryParameter("FWFN", m3_FWFN.Trim());

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
