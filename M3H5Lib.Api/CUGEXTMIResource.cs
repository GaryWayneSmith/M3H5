/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddFieldKey
		/// Description Add Field Event Key
		/// Version Release: 14
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3EVNO">Event name operation (Required)</param>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3KEYF">Key field (Required)</param>
		/// <param name="m3FEFI">From event field</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldKey(
			string m3EVPB, 
			string m3EVNM, 
			string m3EVNO, 
			string m3FILE, 
			string m3KEYF, 
			string m3FEFI = null, 
			string m3STAT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddFieldKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));
			if (string.IsNullOrWhiteSpace(m3EVNO))
				throw new ArgumentNullException(nameof(m3EVNO));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3KEYF))
				throw new ArgumentNullException(nameof(m3KEYF));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim())
				.WithQueryParameter("EVNO", m3EVNO.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("KEYF", m3KEYF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FEFI))
				request.WithQueryParameter("FEFI", m3FEFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddFieldMap
		/// Description Add Field  Mapping
		/// Version Release: 14
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3EVNO">Event name operation (Required)</param>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3FVLU">Field value</param>
		/// <param name="m3FEFI">From event field</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldMap(
			string m3EVPB, 
			string m3EVNM, 
			string m3EVNO, 
			string m3FILE, 
			string m3FLDI, 
			string m3FVLU = null, 
			string m3FEFI = null, 
			string m3STAT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddFieldMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));
			if (string.IsNullOrWhiteSpace(m3EVNO))
				throw new ArgumentNullException(nameof(m3EVNO));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim())
				.WithQueryParameter("EVNO", m3EVNO.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FVLU))
				request.WithQueryParameter("FVLU", m3FVLU.Trim());
			if (!string.IsNullOrWhiteSpace(m3FEFI))
				request.WithQueryParameter("FEFI", m3FEFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddFieldSub
		/// Description Add Field  Subscription
		/// Version Release: 14
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3EVNO">Event name operation (Required)</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldSub(
			string m3EVPB, 
			string m3EVNM, 
			string m3EVNO, 
			string m3STAT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddFieldSub",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));
			if (string.IsNullOrWhiteSpace(m3EVNO))
				throw new ArgumentNullException(nameof(m3EVNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim())
				.WithQueryParameter("EVNO", m3EVNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name LstFieldKey
		/// Description List Field Event Key
		/// Version Release: 14
		/// </summary>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3KEYF">Key field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldKeyResponse></returns>
		/// <exception cref="M3Exception<LstFieldKeyResponse>"></exception>
		public async Task<M3Response<LstFieldKeyResponse>> LstFieldKey(
			string m3EVPB = null, 
			string m3EVNM = null, 
			string m3EVNO = null, 
			string m3FILE = null, 
			string m3KEYF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFieldKey",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEYF))
				request.WithQueryParameter("KEYF", m3KEYF.Trim());

			// Execute the request
			var result = await Execute<LstFieldKeyResponse>(
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
		/// Name LstFieldMap
		/// Description List Field Mapping
		/// Version Release: 14
		/// </summary>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldMapResponse></returns>
		/// <exception cref="M3Exception<LstFieldMapResponse>"></exception>
		public async Task<M3Response<LstFieldMapResponse>> LstFieldMap(
			string m3EVPB = null, 
			string m3EVNM = null, 
			string m3EVNO = null, 
			string m3FILE = null, 
			string m3FLDI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFieldMap",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<LstFieldMapResponse>(
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
		/// Name LstFieldSub
		/// Description List Field Subscription
		/// Version Release: 14
		/// </summary>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldSubResponse></returns>
		/// <exception cref="M3Exception<LstFieldSubResponse>"></exception>
		public async Task<M3Response<LstFieldSubResponse>> LstFieldSub(
			string m3EVPB = null, 
			string m3EVNM = null, 
			string m3EVNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFieldSub",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());

			// Execute the request
			var result = await Execute<LstFieldSubResponse>(
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
