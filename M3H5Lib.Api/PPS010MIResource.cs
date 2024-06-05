/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS010MI;
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
	/// Name: PPS010MI
	/// Component Name: Purchasing
	/// Description: Vendor transportation lead time interface
	/// Version Release: 5e90
	///</summary>
	public partial class PPS010MIResource : M3BaseResourceEndpoint
	{
		public PPS010MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS010MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddConnTranspLT
		/// Description Add Vendor transportation lead time
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_TEDL">Deliveryterms (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_MODL">Deliverymethod</param>
		/// <param name="m3_DELT">*** Not in use *** Goodsresponsibility</param>
		/// <param name="m3_TLE1">Transportationleadtime1</param>
		/// <param name="m3_TLE2">Transportationleadtime2</param>
		/// <param name="m3_SDES">Place of loading</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddConnTranspLT(
			string m3_SUNO, 
			string m3_TEDL, 
			string m3_WHLO, 
			string m3_MODL = null, 
			int? m3_DELT = null, 
			int? m3_TLE1 = null, 
			int? m3_TLE2 = null, 
			string m3_SDES = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddConnTranspLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_TEDL))
				throw new ArgumentNullException("m3_TEDL");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("TEDL", m3_TEDL.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (m3_DELT.HasValue)
				request.WithQueryParameter("DELT", m3_DELT.Value.ToString());
			if (m3_TLE1.HasValue)
				request.WithQueryParameter("TLE1", m3_TLE1.Value.ToString());
			if (m3_TLE2.HasValue)
				request.WithQueryParameter("TLE2", m3_TLE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SDES))
				request.WithQueryParameter("SDES", m3_SDES.Trim());

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
		/// Name DelConnTranspLT
		/// Description Delete Vendor transportation lead time
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_TEDL">Deliveryterms (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_MODL">Deliverymethod</param>
		/// <param name="m3_SDES">Place of loading</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelConnTranspLT(
			string m3_SUNO, 
			string m3_TEDL, 
			string m3_WHLO, 
			string m3_MODL = null, 
			string m3_SDES = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelConnTranspLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_TEDL))
				throw new ArgumentNullException("m3_TEDL");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("TEDL", m3_TEDL.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDES))
				request.WithQueryParameter("SDES", m3_SDES.Trim());

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
		/// Name GetConnTranspLT
		/// Description Get Vendor transportation lead time
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_TEDL">Deliveryterms (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_MODL">Deliverymethod</param>
		/// <param name="m3_SDES">Place of loading</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetConnTranspLTResponse></returns>
		/// <exception cref="M3Exception<GetConnTranspLTResponse>"></exception>
		public async Task<M3Response<GetConnTranspLTResponse>> GetConnTranspLT(
			string m3_SUNO, 
			string m3_TEDL, 
			string m3_WHLO, 
			string m3_MODL = null, 
			string m3_SDES = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetConnTranspLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_TEDL))
				throw new ArgumentNullException("m3_TEDL");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("TEDL", m3_TEDL.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDES))
				request.WithQueryParameter("SDES", m3_SDES.Trim());

			// Execute the request
			var result = await Execute<GetConnTranspLTResponse>(
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
		/// Name LstConnTranspLT
		/// Description List Vendor transportation lead time
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_TEDL">Deliveryterms</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_MODL">Deliverymethod</param>
		/// <param name="m3_SDES">Place of loading</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConnTranspLTResponse></returns>
		/// <exception cref="M3Exception<LstConnTranspLTResponse>"></exception>
		public async Task<M3Response<LstConnTranspLTResponse>> LstConnTranspLT(
			string m3_SUNO, 
			string m3_TEDL = null, 
			string m3_WHLO = null, 
			string m3_MODL = null, 
			string m3_SDES = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstConnTranspLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDES))
				request.WithQueryParameter("SDES", m3_SDES.Trim());

			// Execute the request
			var result = await Execute<LstConnTranspLTResponse>(
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
		/// Name UpdConnTranspLT
		/// Description Update Vendor transportation lead time
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_TEDL">Deliveryterms (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_MODL">Deliverymethod</param>
		/// <param name="m3_DELT">*** Not in use *** Goodsresponsibility</param>
		/// <param name="m3_TLE1">Transportationleadtime1</param>
		/// <param name="m3_TLE2">Transportationleadtime2</param>
		/// <param name="m3_SDES">Place of loading</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdConnTranspLT(
			string m3_SUNO, 
			string m3_TEDL, 
			string m3_WHLO, 
			string m3_MODL = null, 
			int? m3_DELT = null, 
			int? m3_TLE1 = null, 
			int? m3_TLE2 = null, 
			string m3_SDES = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdConnTranspLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_TEDL))
				throw new ArgumentNullException("m3_TEDL");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("TEDL", m3_TEDL.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (m3_DELT.HasValue)
				request.WithQueryParameter("DELT", m3_DELT.Value.ToString());
			if (m3_TLE1.HasValue)
				request.WithQueryParameter("TLE1", m3_TLE1.Value.ToString());
			if (m3_TLE2.HasValue)
				request.WithQueryParameter("TLE2", m3_TLE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SDES))
				request.WithQueryParameter("SDES", m3_SDES.Trim());

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
