/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
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
	/// Name: MNS206MI
	/// Component Name: OutputControl
	/// Description: Output management
	/// Version Release: 12.4
	///</summary>
	public partial class MNS206MIResource : M3BaseResourceEndpoint
	{
		public MNS206MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS206MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SbmOutput
		/// Description Submits output from server
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_BJNO">Batch job number (Required)</param>
		/// <param name="m3_FILE">File name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SbmOutput(
			string m3_BJNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SbmOutput",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BJNO))
				throw new ArgumentNullException("m3_BJNO");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("BJNO", m3_BJNO.Trim())
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
		/// Name UpdControl
		/// Description Updates control record
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_BJNO">Batch job number (Required)</param>
		/// <param name="m3_FILE">File name (Required)</param>
		/// <param name="m3_SSTA">Status</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_MSGD">Message description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdControl(
			string m3_BJNO, 
			string m3_FILE, 
			string m3_SSTA = null, 
			string m3_MSID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdControl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BJNO))
				throw new ArgumentNullException("m3_BJNO");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("BJNO", m3_BJNO.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SSTA))
				request.WithQueryParameter("SSTA", m3_SSTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGD))
				request.WithQueryParameter("MSGD", m3_MSGD.Trim());

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
