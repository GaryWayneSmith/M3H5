/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3PGNM">Program (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3TX60">Reason (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3ESMT">Sign method</param>
		/// <param name="m3ESST">Sign strategy</param>
		/// <param name="m3ESP1">Sign process</param>
		/// <param name="m3ECIN">Comment input</param>
		/// <param name="m3SSND">Send application message - successful</param>
		/// <param name="m3SREC">Receiver - successful</param>
		/// <param name="m3SBOD">BOD enabled - successful</param>
		/// <param name="m3SBDM">BOD message type - successful</param>
		/// <param name="m3SWFN">Workflow name - successful</param>
		/// <param name="m3FSND">Send application message - failed</param>
		/// <param name="m3FREC">Receiver - failed</param>
		/// <param name="m3FBOD">BOD enabled - failed</param>
		/// <param name="m3FBDM">BOD message type - failed</param>
		/// <param name="m3FWFN">Workflow name - failed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddObject(
			string m3PGNM, 
			string m3FILE, 
			string m3FLDI, 
			string m3TX60, 
			string m3STAT, 
			int? m3ESMT = null, 
			int? m3ESST = null, 
			int? m3ESP1 = null, 
			int? m3ECIN = null, 
			int? m3SSND = null, 
			string m3SREC = null, 
			int? m3SBOD = null, 
			int? m3SBDM = null, 
			string m3SWFN = null, 
			int? m3FSND = null, 
			string m3FREC = null, 
			int? m3FBOD = null, 
			int? m3FBDM = null, 
			string m3FWFN = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3TX60))
				throw new ArgumentNullException(nameof(m3TX60));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("TX60", m3TX60.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ESMT.HasValue)
				request.WithQueryParameter("ESMT", m3ESMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ESST.HasValue)
				request.WithQueryParameter("ESST", m3ESST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ESP1.HasValue)
				request.WithQueryParameter("ESP1", m3ESP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ECIN.HasValue)
				request.WithQueryParameter("ECIN", m3ECIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSND.HasValue)
				request.WithQueryParameter("SSND", m3SSND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SREC))
				request.WithQueryParameter("SREC", m3SREC.Trim());
			if (m3SBOD.HasValue)
				request.WithQueryParameter("SBOD", m3SBOD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SBDM.HasValue)
				request.WithQueryParameter("SBDM", m3SBDM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SWFN))
				request.WithQueryParameter("SWFN", m3SWFN.Trim());
			if (m3FSND.HasValue)
				request.WithQueryParameter("FSND", m3FSND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FREC))
				request.WithQueryParameter("FREC", m3FREC.Trim());
			if (m3FBOD.HasValue)
				request.WithQueryParameter("FBOD", m3FBOD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FBDM.HasValue)
				request.WithQueryParameter("FBDM", m3FBDM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWFN))
				request.WithQueryParameter("FWFN", m3FWFN.Trim());

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
		/// Name DltObject
		/// Description Delete an eSign Object
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PGNM">Program (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltObject(
			string m3PGNM, 
			string m3FILE, 
			string m3FLDI, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

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
		/// Name GetObject
		/// Description Get data for an eSign Object
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PGNM">Program (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetObjectResponse></returns>
		/// <exception cref="M3Exception<GetObjectResponse>"></exception>
		public async Task<M3Response<GetObjectResponse>> GetObject(
			string m3PGNM, 
			string m3FILE, 
			string m3FLDI, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<GetObjectResponse>(
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
		/// Name LstObjects
		/// Description List data for eSign Objects
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PGNM">Program</param>
		/// <param name="m3FILE">File</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstObjectsResponse></returns>
		/// <exception cref="M3Exception<LstObjectsResponse>"></exception>
		public async Task<M3Response<LstObjectsResponse>> LstObjects(
			string m3PGNM = null, 
			string m3FILE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<LstObjectsResponse>(
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
		/// Name UpdObject
		/// Description Update data for an eSign Object
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PGNM">Program (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3TX60">Reason</param>
		/// <param name="m3ESMT">Sign method</param>
		/// <param name="m3ESST">Sign strategy</param>
		/// <param name="m3ESP1">Sign process</param>
		/// <param name="m3ECIN">Comment input</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3SSND">Send application message - successful</param>
		/// <param name="m3SREC">Receiver - successful</param>
		/// <param name="m3SBOD">BOD enabled - successful</param>
		/// <param name="m3SBDM">BOD message type - successful</param>
		/// <param name="m3SWFN">Workflow name - successful</param>
		/// <param name="m3FSND">Send application message - failed</param>
		/// <param name="m3FREC">Receiver - failed</param>
		/// <param name="m3FBOD">BOD enabled - failed</param>
		/// <param name="m3FBDM">BOD message type - failed</param>
		/// <param name="m3FWFN">Workflow name - failed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdObject(
			string m3PGNM, 
			string m3FILE, 
			string m3FLDI, 
			string m3TX60 = null, 
			int? m3ESMT = null, 
			int? m3ESST = null, 
			int? m3ESP1 = null, 
			int? m3ECIN = null, 
			string m3STAT = null, 
			int? m3SSND = null, 
			string m3SREC = null, 
			int? m3SBOD = null, 
			int? m3SBDM = null, 
			string m3SWFN = null, 
			int? m3FSND = null, 
			string m3FREC = null, 
			int? m3FBOD = null, 
			int? m3FBDM = null, 
			string m3FWFN = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());
			if (m3ESMT.HasValue)
				request.WithQueryParameter("ESMT", m3ESMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ESST.HasValue)
				request.WithQueryParameter("ESST", m3ESST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ESP1.HasValue)
				request.WithQueryParameter("ESP1", m3ESP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ECIN.HasValue)
				request.WithQueryParameter("ECIN", m3ECIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3SSND.HasValue)
				request.WithQueryParameter("SSND", m3SSND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SREC))
				request.WithQueryParameter("SREC", m3SREC.Trim());
			if (m3SBOD.HasValue)
				request.WithQueryParameter("SBOD", m3SBOD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SBDM.HasValue)
				request.WithQueryParameter("SBDM", m3SBDM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SWFN))
				request.WithQueryParameter("SWFN", m3SWFN.Trim());
			if (m3FSND.HasValue)
				request.WithQueryParameter("FSND", m3FSND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FREC))
				request.WithQueryParameter("FREC", m3FREC.Trim());
			if (m3FBOD.HasValue)
				request.WithQueryParameter("FBOD", m3FBOD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FBDM.HasValue)
				request.WithQueryParameter("FBDM", m3FBDM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWFN))
				request.WithQueryParameter("FWFN", m3FWFN.Trim());

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
