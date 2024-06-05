/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CUGEXTMI;
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
	/// Name: CUGEXTMI
	/// Component Name: Customer generic ext. tables
	/// Description: Customer generic extension tables
	/// Version Release: 14.x
	///</summary>
	public partial class CUGEXTMIResource : M3BaseResourceEndpoint
	{
		public CUGEXTMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CUGEXTMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddFieldKey
		/// Description Add Field Event Key
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_EVNO">Event name operation (Required)</param>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_KEYF">Key field (Required)</param>
		/// <param name="m3_FEFI">From event field</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldKey(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_EVNO, 
			string m3_FILE, 
			string m3_KEYF, 
			string m3_FEFI = null, 
			string m3_STAT = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFieldKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");
			if (string.IsNullOrWhiteSpace(m3_EVNO))
				throw new ArgumentNullException("m3_EVNO");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_KEYF))
				throw new ArgumentNullException("m3_KEYF");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim())
				.WithQueryParameter("EVNO", m3_EVNO.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("KEYF", m3_KEYF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FEFI))
				request.WithQueryParameter("FEFI", m3_FEFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name AddFieldMap
		/// Description Add Field  Mapping
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_EVNO">Event name operation (Required)</param>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_FVLU">Field value</param>
		/// <param name="m3_FEFI">From event field</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldMap(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_EVNO, 
			string m3_FILE, 
			string m3_FLDI, 
			string m3_FVLU = null, 
			string m3_FEFI = null, 
			string m3_STAT = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFieldMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");
			if (string.IsNullOrWhiteSpace(m3_EVNO))
				throw new ArgumentNullException("m3_EVNO");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim())
				.WithQueryParameter("EVNO", m3_EVNO.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FVLU))
				request.WithQueryParameter("FVLU", m3_FVLU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FEFI))
				request.WithQueryParameter("FEFI", m3_FEFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name AddFieldSub
		/// Description Add Field  Subscription
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_EVNO">Event name operation (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldSub(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_EVNO, 
			string m3_STAT = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFieldSub",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");
			if (string.IsNullOrWhiteSpace(m3_EVNO))
				throw new ArgumentNullException("m3_EVNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim())
				.WithQueryParameter("EVNO", m3_EVNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name LstFieldKey
		/// Description List Field Event Key
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_EVPB">Event publisher</param>
		/// <param name="m3_EVNM">Event name</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_KEYF">Key field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldKeyResponse></returns>
		/// <exception cref="M3Exception<LstFieldKeyResponse>"></exception>
		public async Task<M3Response<LstFieldKeyResponse>> LstFieldKey(
			string m3_EVPB = null, 
			string m3_EVNM = null, 
			string m3_EVNO = null, 
			string m3_FILE = null, 
			string m3_KEYF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFieldKey",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVPB))
				request.WithQueryParameter("EVPB", m3_EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNM))
				request.WithQueryParameter("EVNM", m3_EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEYF))
				request.WithQueryParameter("KEYF", m3_KEYF.Trim());

			// Execute the request
			var result = await Execute<LstFieldKeyResponse>(
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
		/// Name LstFieldMap
		/// Description List Field Mapping
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_EVPB">Event publisher</param>
		/// <param name="m3_EVNM">Event name</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldMapResponse></returns>
		/// <exception cref="M3Exception<LstFieldMapResponse>"></exception>
		public async Task<M3Response<LstFieldMapResponse>> LstFieldMap(
			string m3_EVPB = null, 
			string m3_EVNM = null, 
			string m3_EVNO = null, 
			string m3_FILE = null, 
			string m3_FLDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFieldMap",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVPB))
				request.WithQueryParameter("EVPB", m3_EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNM))
				request.WithQueryParameter("EVNM", m3_EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Execute the request
			var result = await Execute<LstFieldMapResponse>(
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
		/// Name LstFieldSub
		/// Description List Field Subscription
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_EVPB">Event publisher</param>
		/// <param name="m3_EVNM">Event name</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldSubResponse></returns>
		/// <exception cref="M3Exception<LstFieldSubResponse>"></exception>
		public async Task<M3Response<LstFieldSubResponse>> LstFieldSub(
			string m3_EVPB = null, 
			string m3_EVNM = null, 
			string m3_EVNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFieldSub",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVPB))
				request.WithQueryParameter("EVPB", m3_EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNM))
				request.WithQueryParameter("EVNM", m3_EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());

			// Execute the request
			var result = await Execute<LstFieldSubResponse>(
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
