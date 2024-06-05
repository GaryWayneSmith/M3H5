/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS048MI;
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
	/// Name: CMS048MI
	/// Component Name: Equipment
	/// Description: Event log fields
	/// Version Release: 14.x
	///</summary>
	public partial class CMS048MIResource : M3BaseResourceEndpoint
	{
		public CMS048MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS048MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddField
		/// Description Add record in CSYEVF
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_EVNM">Event name</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_EVPB">Event publisher</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddField(
			string m3_EVNM = null, 
			string m3_EVNO = null, 
			string m3_EVPB = null, 
			string m3_FLDI = null, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddField",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNM))
				request.WithQueryParameter("EVNM", m3_EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVPB))
				request.WithQueryParameter("EVPB", m3_EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

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
		/// Name DltField
		/// Description Delete record in CSYEVF
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_EVNM">Event name</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_EVPB">Event publisher</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltField(
			string m3_EVNM = null, 
			string m3_EVNO = null, 
			string m3_EVPB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltField",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNM))
				request.WithQueryParameter("EVNM", m3_EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVPB))
				request.WithQueryParameter("EVPB", m3_EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());

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
		/// Name GetField
		/// Description Get record from CSYEVF
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_EVNM">Event name</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_EVPB">Event publisher</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldResponse></returns>
		/// <exception cref="M3Exception<GetFieldResponse>"></exception>
		public async Task<M3Response<GetFieldResponse>> GetField(
			string m3_EVNM = null, 
			string m3_EVNO = null, 
			string m3_EVPB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetField",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNM))
				request.WithQueryParameter("EVNM", m3_EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVPB))
				request.WithQueryParameter("EVPB", m3_EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Execute the request
			var result = await Execute<GetFieldResponse>(
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
		/// Name LstFields
		/// Description List records from CSYEVF
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_EVNM">Event name</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_EVPB">Event publisher</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldsResponse></returns>
		/// <exception cref="M3Exception<LstFieldsResponse>"></exception>
		public async Task<M3Response<LstFieldsResponse>> LstFields(
			string m3_EVNM = null, 
			string m3_EVNO = null, 
			string m3_EVPB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFields",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNM))
				request.WithQueryParameter("EVNM", m3_EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVPB))
				request.WithQueryParameter("EVPB", m3_EVPB.Trim());

			// Execute the request
			var result = await Execute<LstFieldsResponse>(
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
		/// Name UpdField
		/// Description Update record in CSYEVF
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_EVNM">Event name</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_EVPB">Event publisher</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdField(
			string m3_EVNM = null, 
			string m3_EVNO = null, 
			string m3_EVPB = null, 
			string m3_FLDI = null, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdField",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNM))
				request.WithQueryParameter("EVNM", m3_EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVPB))
				request.WithQueryParameter("EVPB", m3_EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

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
