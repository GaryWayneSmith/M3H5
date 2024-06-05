/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS417MI;
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
	/// Name: MWS417MI
	/// Component Name: Delivery accessorials
	/// Description: Api: Delivery accessorials
	/// Version Release: 14.x
	///</summary>
	public partial class MWS417MIResource : M3BaseResourceEndpoint
	{
		public MWS417MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS417MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add accessorial per delivery
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FALV">Freight accessorial level (Required)</param>
		/// <param name="m3_FAID">Freight accessorial ID (Required)</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_FQTY">Freight accessorial quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			int m3_FALV, 
			string m3_FAID, 
			int? m3_CONN = null, 
			decimal? m3_DLIX = null, 
			int? m3_RORC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			decimal? m3_FQTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FAID))
				throw new ArgumentNullException("m3_FAID");

			// Set mandatory parameters
			request
				.WithQueryParameter("FALV", m3_FALV.ToString())
				.WithQueryParameter("FAID", m3_FAID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_FQTY.HasValue)
				request.WithQueryParameter("FQTY", m3_FQTY.Value.ToString());

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
		/// Name Delete
		/// Description Delete accessorial per delivery
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FALV">Freight accessorial level (Required)</param>
		/// <param name="m3_FAID">Freight accessorial ID (Required)</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			int m3_FALV, 
			string m3_FAID, 
			int? m3_CONN = null, 
			decimal? m3_DLIX = null, 
			int? m3_RORC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FAID))
				throw new ArgumentNullException("m3_FAID");

			// Set mandatory parameters
			request
				.WithQueryParameter("FALV", m3_FALV.ToString())
				.WithQueryParameter("FAID", m3_FAID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());

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
		/// Name Get
		/// Description Get accessorial line
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FALV">Freight accessorial level (Required)</param>
		/// <param name="m3_FAID">Freight accessorial ID (Required)</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			int m3_FALV, 
			string m3_FAID, 
			int? m3_CONN = null, 
			decimal? m3_DLIX = null, 
			int? m3_RORC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FAID))
				throw new ArgumentNullException("m3_FAID");

			// Set mandatory parameters
			request
				.WithQueryParameter("FALV", m3_FALV.ToString())
				.WithQueryParameter("FAID", m3_FAID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name LstAll
		/// Description List all connected accessorials
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAllResponse></returns>
		/// <exception cref="M3Exception<LstAllResponse>"></exception>
		public async Task<M3Response<LstAllResponse>> LstAll(
			int? m3_CONN = null, 
			decimal? m3_DLIX = null, 
			int? m3_RORC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAll",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());

			// Execute the request
			var result = await Execute<LstAllResponse>(
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
		/// Name LstbyAccLvl
		/// Description List accessorials by Accessorial level
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FALV">Freight accessorial level (Required)</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_FAID">Freight accessorial ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstbyAccLvlResponse></returns>
		/// <exception cref="M3Exception<LstbyAccLvlResponse>"></exception>
		public async Task<M3Response<LstbyAccLvlResponse>> LstbyAccLvl(
			int m3_FALV, 
			int? m3_CONN = null, 
			decimal? m3_DLIX = null, 
			int? m3_RORC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_FAID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstbyAccLvl",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("FALV", m3_FALV.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FAID))
				request.WithQueryParameter("FAID", m3_FAID.Trim());

			// Execute the request
			var result = await Execute<LstbyAccLvlResponse>(
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
		/// Name Update
		/// Description Update accessorial per delivery
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FALV">Freight accessorial level (Required)</param>
		/// <param name="m3_FAID">Freight accessorial ID (Required)</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_FQTY">Freight accessorial quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			int m3_FALV, 
			string m3_FAID, 
			int? m3_CONN = null, 
			decimal? m3_DLIX = null, 
			int? m3_RORC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			decimal? m3_FQTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FAID))
				throw new ArgumentNullException("m3_FAID");

			// Set mandatory parameters
			request
				.WithQueryParameter("FALV", m3_FALV.ToString())
				.WithQueryParameter("FAID", m3_FAID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_FQTY.HasValue)
				request.WithQueryParameter("FQTY", m3_FQTY.Value.ToString());

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
