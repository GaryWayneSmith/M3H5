/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS386MI;
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
	/// Name: PPS386MI
	/// Component Name: SettlementPrintingModel
	/// Description: Settlement Printing Model. Connect test and attribute lines
	/// Version Release: 5e90
	///</summary>
	public partial class PPS386MIResource : M3BaseResourceEndpoint
	{
		public PPS386MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS386MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddModelElement
		/// Description AddModelElement
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_WSCA">Costing model</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="m3_SCET">Element type - sales price costing</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_POSE">Print on settlement</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddModelElement(
			string m3_WSCA = null, 
			int? m3_FDAT = null, 
			int? m3_ANSQ = null, 
			int? m3_SCET = null, 
			string m3_OBV1 = null, 
			int? m3_POSE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddModelElement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WSCA))
				request.WithQueryParameter("WSCA", m3_WSCA.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());
			if (m3_SCET.HasValue)
				request.WithQueryParameter("SCET", m3_SCET.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (m3_POSE.HasValue)
				request.WithQueryParameter("POSE", m3_POSE.Value.ToString());

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
		/// Name DltModelElement
		/// Description DltModelElement
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_WSCA">Costing model</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltModelElement(
			string m3_WSCA = null, 
			DateTime? m3_FDAT = null, 
			int? m3_ANSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltModelElement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WSCA))
				request.WithQueryParameter("WSCA", m3_WSCA.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());

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
		/// Name GetModelElement
		/// Description GetModelElement
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_WSCA">Costing model</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetModelElementResponse></returns>
		/// <exception cref="M3Exception<GetModelElementResponse>"></exception>
		public async Task<M3Response<GetModelElementResponse>> GetModelElement(
			string m3_WSCA = null, 
			DateTime? m3_FDAT = null, 
			int? m3_ANSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetModelElement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WSCA))
				request.WithQueryParameter("WSCA", m3_WSCA.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());

			// Execute the request
			var result = await Execute<GetModelElementResponse>(
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
		/// Name LstModelElement
		/// Description LstModelElement
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_WSCA">Costing model</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModelElementResponse></returns>
		/// <exception cref="M3Exception<LstModelElementResponse>"></exception>
		public async Task<M3Response<LstModelElementResponse>> LstModelElement(
			string m3_WSCA = null, 
			DateTime? m3_FDAT = null, 
			int? m3_ANSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstModelElement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WSCA))
				request.WithQueryParameter("WSCA", m3_WSCA.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());

			// Execute the request
			var result = await Execute<LstModelElementResponse>(
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
		/// Name UpdModelElement
		/// Description UpdModelElement
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_WSCA">Costing model</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="m3_SCET">Element type - sales price costing</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_POSE">Print on settlement</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdModelElement(
			string m3_WSCA = null, 
			DateTime? m3_FDAT = null, 
			int? m3_ANSQ = null, 
			int? m3_SCET = null, 
			string m3_OBV1 = null, 
			int? m3_POSE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdModelElement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WSCA))
				request.WithQueryParameter("WSCA", m3_WSCA.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());
			if (m3_SCET.HasValue)
				request.WithQueryParameter("SCET", m3_SCET.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (m3_POSE.HasValue)
				request.WithQueryParameter("POSE", m3_POSE.Value.ToString());

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
