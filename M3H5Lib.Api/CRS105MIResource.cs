/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS105MI;
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
	/// Name: CRS105MI
	/// Component Name: COP
	/// Description: Assortment
	/// Version Release: 12
	///</summary>
	public partial class CRS105MIResource : M3BaseResourceEndpoint
	{
		public CRS105MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS105MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstAssmCust
		/// Description List Assortment Customer
		/// Version Release: 12
		/// </summary>
		/// <param name="m3_ASCD">Assortment (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FCUN">From customer number</param>
		/// <param name="m3_TCUN">To customer number</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssmCustResponse></returns>
		/// <exception cref="M3Exception<LstAssmCustResponse>"></exception>
		public async Task<M3Response<LstAssmCustResponse>> LstAssmCust(
			string m3_ASCD, 
			int? m3_CONO = null, 
			string m3_FCUN = null, 
			string m3_TCUN = null, 
			DateTime? m3_LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssmCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ASCD))
				throw new ArgumentNullException("m3_ASCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("ASCD", m3_ASCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCUN))
				request.WithQueryParameter("FCUN", m3_FCUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCUN))
				request.WithQueryParameter("TCUN", m3_TCUN.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAssmCustResponse>(
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
		/// Name LstAssmHead
		/// Description List Assortment Head
		/// Version Release: 12
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FASC">From Assortment</param>
		/// <param name="m3_TASC">To Assortment</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssmHeadResponse></returns>
		/// <exception cref="M3Exception<LstAssmHeadResponse>"></exception>
		public async Task<M3Response<LstAssmHeadResponse>> LstAssmHead(
			int? m3_CONO = null, 
			string m3_FASC = null, 
			string m3_TASC = null, 
			DateTime? m3_LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssmHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FASC))
				request.WithQueryParameter("FASC", m3_FASC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TASC))
				request.WithQueryParameter("TASC", m3_TASC.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAssmHeadResponse>(
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
		/// Name LstAssmItem
		/// Description List Assortment Item
		/// Version Release: 12
		/// </summary>
		/// <param name="m3_ASCD">Assortment (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FITN">From item number</param>
		/// <param name="m3_TITN">To item number</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssmItemResponse></returns>
		/// <exception cref="M3Exception<LstAssmItemResponse>"></exception>
		public async Task<M3Response<LstAssmItemResponse>> LstAssmItem(
			string m3_ASCD, 
			int? m3_CONO = null, 
			string m3_FITN = null, 
			string m3_TITN = null, 
			DateTime? m3_LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssmItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ASCD))
				throw new ArgumentNullException("m3_ASCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("ASCD", m3_ASCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FITN))
				request.WithQueryParameter("FITN", m3_FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITN))
				request.WithQueryParameter("TITN", m3_TITN.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAssmItemResponse>(
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
