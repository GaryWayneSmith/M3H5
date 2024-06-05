/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3STYN">Style number</param>
		/// <param name="m3CODT">Confirmed delivery date</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3CODZ">Confirmed delivery date in date zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleDetByCOResponse></returns>
		/// <exception cref="M3Exception<LstStyleDetByCOResponse>"></exception>
		public async Task<M3Response<LstStyleDetByCOResponse>> LstStyleDetByCO(
			string m3ORNO = null, 
			string m3STYN = null, 
			DateTime? m3CODT = null, 
			string m3ADID = null, 
			string m3WHLO = null, 
			DateTime? m3CODZ = null, 
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
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STYN))
				request.WithQueryParameter("STYN", m3STYN.Trim());
			if (m3CODT.HasValue)
				request.WithQueryParameter("CODT", m3CODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3CODZ.HasValue)
				request.WithQueryParameter("CODZ", m3CODZ.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstStyleDetByCOResponse>(
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
		/// Name LstStyleDetByDO
		/// Description List matrix by DO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TRNR">Order number (Required)</param>
		/// <param name="m3STYN">Style number</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleDetByDOResponse></returns>
		/// <exception cref="M3Exception<LstStyleDetByDOResponse>"></exception>
		public async Task<M3Response<LstStyleDetByDOResponse>> LstStyleDetByDO(
			string m3TRNR, 
			string m3STYN = null, 
			DateTime? m3TRDT = null, 
			string m3WHLO = null, 
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
			if (string.IsNullOrWhiteSpace(m3TRNR))
				throw new ArgumentNullException(nameof(m3TRNR));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRNR", m3TRNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STYN))
				request.WithQueryParameter("STYN", m3STYN.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<LstStyleDetByDOResponse>(
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
		/// Name LstStyleDetByMO
		/// Description List matrix by MO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SCHN">Schedule number (Required)</param>
		/// <param name="m3STYN">Style number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleDetByMOResponse></returns>
		/// <exception cref="M3Exception<LstStyleDetByMOResponse>"></exception>
		public async Task<M3Response<LstStyleDetByMOResponse>> LstStyleDetByMO(
			decimal m3SCHN, 
			string m3STYN = null, 
			string m3WHLO = null, 
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
				.WithQueryParameter("SCHN", m3SCHN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STYN))
				request.WithQueryParameter("STYN", m3STYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<LstStyleDetByMOResponse>(
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
		/// Name LstStyleDetByPO
		/// Description List matrix by PO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3STYN">Style number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3PLDT">Planning date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleDetByPOResponse></returns>
		/// <exception cref="M3Exception<LstStyleDetByPOResponse>"></exception>
		public async Task<M3Response<LstStyleDetByPOResponse>> LstStyleDetByPO(
			string m3PUNO = null, 
			string m3STYN = null, 
			string m3WHLO = null, 
			DateTime? m3DWDT = null, 
			DateTime? m3PLDT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STYN))
				request.WithQueryParameter("STYN", m3STYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (m3PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3PLDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstStyleDetByPOResponse>(
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
