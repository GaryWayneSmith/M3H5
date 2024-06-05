/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS207MI;
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
	/// Name: CRS207MI
	/// Component Name: FashionMatrix
	/// Description: List API for fashion matrix
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS207MIResource : M3BaseResourceEndpoint
	{
		public CRS207MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS207MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstStyleDetByCO
		/// Description List matrix by CO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_STYN">Style number</param>
		/// <param name="m3_CODT">Confirmed delivery date</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_CODZ">Confirmed delivery date in date zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleDetByCOResponse></returns>
		/// <exception cref="M3Exception<LstStyleDetByCOResponse>"></exception>
		public async Task<M3Response<LstStyleDetByCOResponse>> LstStyleDetByCO(
			string m3_ORNO = null, 
			string m3_STYN = null, 
			DateTime? m3_CODT = null, 
			string m3_ADID = null, 
			string m3_WHLO = null, 
			DateTime? m3_CODZ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStyleDetByCO",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STYN))
				request.WithQueryParameter("STYN", m3_STYN.Trim());
			if (m3_CODT.HasValue)
				request.WithQueryParameter("CODT", m3_CODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_CODZ.HasValue)
				request.WithQueryParameter("CODZ", m3_CODZ.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstStyleDetByCOResponse>(
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
		/// Name LstStyleDetByDO
		/// Description List matrix by DO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRNR">Order number (Required)</param>
		/// <param name="m3_STYN">Style number</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleDetByDOResponse></returns>
		/// <exception cref="M3Exception<LstStyleDetByDOResponse>"></exception>
		public async Task<M3Response<LstStyleDetByDOResponse>> LstStyleDetByDO(
			string m3_TRNR, 
			string m3_STYN = null, 
			DateTime? m3_TRDT = null, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStyleDetByDO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRNR))
				throw new ArgumentNullException("m3_TRNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRNR", m3_TRNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STYN))
				request.WithQueryParameter("STYN", m3_STYN.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<LstStyleDetByDOResponse>(
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
		/// Name LstStyleDetByMO
		/// Description List matrix by MO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SCHN">Schedule number (Required)</param>
		/// <param name="m3_STYN">Style number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleDetByMOResponse></returns>
		/// <exception cref="M3Exception<LstStyleDetByMOResponse>"></exception>
		public async Task<M3Response<LstStyleDetByMOResponse>> LstStyleDetByMO(
			decimal m3_SCHN, 
			string m3_STYN = null, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStyleDetByMO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("SCHN", m3_SCHN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STYN))
				request.WithQueryParameter("STYN", m3_STYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<LstStyleDetByMOResponse>(
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
		/// Name LstStyleDetByPO
		/// Description List matrix by PO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_STYN">Style number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_PLDT">Planning date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleDetByPOResponse></returns>
		/// <exception cref="M3Exception<LstStyleDetByPOResponse>"></exception>
		public async Task<M3Response<LstStyleDetByPOResponse>> LstStyleDetByPO(
			string m3_PUNO = null, 
			string m3_STYN = null, 
			string m3_WHLO = null, 
			DateTime? m3_DWDT = null, 
			DateTime? m3_PLDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStyleDetByPO",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STYN))
				request.WithQueryParameter("STYN", m3_STYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (m3_PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3_PLDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstStyleDetByPOResponse>(
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
