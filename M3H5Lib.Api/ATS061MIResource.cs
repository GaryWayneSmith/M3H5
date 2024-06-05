/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.ATS061MI;
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
	/// Name: ATS061MI
	/// Component Name: Info group
	/// Description: Default information group
	/// Version Release: 14.x
	///</summary>
	public partial class ATS061MIResource : M3BaseResourceEndpoint
	{
		public ATS061MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ATS061MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDefInfGrp
		/// Description Add a default information group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_TRPT">Trading partner</param>
		/// <param name="m3_IFGR">Information group</param>
		/// <param name="m3_INOI">Include order initiated</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDefInfGrp(
			string m3_ORCA = null, 
			string m3_ORTY = null, 
			string m3_TRPT = null, 
			string m3_IFGR = null, 
			int? m3_INOI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDefInfGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRPT))
				request.WithQueryParameter("TRPT", m3_TRPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFGR))
				request.WithQueryParameter("IFGR", m3_IFGR.Trim());
			if (m3_INOI.HasValue)
				request.WithQueryParameter("INOI", m3_INOI.Value.ToString());

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
		/// Name DltDefInfGrp
		/// Description Delete a default information group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_TRPT">Trading partner</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltDefInfGrp(
			string m3_ORCA = null, 
			string m3_ORTY = null, 
			string m3_TRPT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltDefInfGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRPT))
				request.WithQueryParameter("TRPT", m3_TRPT.Trim());

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
		/// Name GetDefInfGrp
		/// Description Get data for a default information group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_TRPT">Trading partner</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDefInfGrpResponse></returns>
		/// <exception cref="M3Exception<GetDefInfGrpResponse>"></exception>
		public async Task<M3Response<GetDefInfGrpResponse>> GetDefInfGrp(
			string m3_ORCA = null, 
			string m3_ORTY = null, 
			string m3_TRPT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDefInfGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRPT))
				request.WithQueryParameter("TRPT", m3_TRPT.Trim());

			// Execute the request
			var result = await Execute<GetDefInfGrpResponse>(
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
		/// Name LstDefInfGrp
		/// Description List data for a default information group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_TRPT">Trading partner</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDefInfGrpResponse></returns>
		/// <exception cref="M3Exception<LstDefInfGrpResponse>"></exception>
		public async Task<M3Response<LstDefInfGrpResponse>> LstDefInfGrp(
			string m3_ORCA = null, 
			string m3_ORTY = null, 
			string m3_TRPT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDefInfGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRPT))
				request.WithQueryParameter("TRPT", m3_TRPT.Trim());

			// Execute the request
			var result = await Execute<LstDefInfGrpResponse>(
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
		/// Name UpdDefInfGrp
		/// Description Update data for a default inforation group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_TRPT">Trading partner</param>
		/// <param name="m3_IFGR">Information group</param>
		/// <param name="m3_INOI">Include order initiated</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDefInfGrp(
			string m3_ORCA = null, 
			string m3_ORTY = null, 
			string m3_TRPT = null, 
			string m3_IFGR = null, 
			int? m3_INOI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdDefInfGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRPT))
				request.WithQueryParameter("TRPT", m3_TRPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IFGR))
				request.WithQueryParameter("IFGR", m3_IFGR.Trim());
			if (m3_INOI.HasValue)
				request.WithQueryParameter("INOI", m3_INOI.Value.ToString());

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
