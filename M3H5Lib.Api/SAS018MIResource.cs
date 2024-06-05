/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SAS018MI;
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
	/// Name: SAS018MI
	/// Component Name: STR Rates: Contract Item Price
	/// Description: API: STR Rates:Contract Item Price
	/// Version Release: 5e90
	///</summary>
	public partial class SAS018MIResource : M3BaseResourceEndpoint
	{
		public SAS018MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SAS018MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddServPrcList
		/// Description AddServPrcList
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRS1">Price list SO (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_AGRS">Contract item (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_QTYL">Lowest quantity limit</param>
		/// <param name="m3_NTCD">Net price used</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_DIPR">Discount amount per unit</param>
		/// <param name="m3_DIPC">Discount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddServPrcList(
			string m3_PRS1, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_AGRS, 
			string m3_CUNO = null, 
			decimal? m3_QTYL = null, 
			int? m3_NTCD = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			decimal? m3_DIPR = null, 
			int? m3_DIPC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddServPrcList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRS1))
				throw new ArgumentNullException("m3_PRS1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_AGRS))
				throw new ArgumentNullException("m3_AGRS");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRS1", m3_PRS1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("AGRS", m3_AGRS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_QTYL.HasValue)
				request.WithQueryParameter("QTYL", m3_QTYL.Value.ToString());
			if (m3_NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3_NTCD.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (m3_DIPR.HasValue)
				request.WithQueryParameter("DIPR", m3_DIPR.Value.ToString());
			if (m3_DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3_DIPC.Value.ToString());

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
		/// Name DelServPrcList
		/// Description DelServPrcList
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRS1">Price list SO (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_AGRS">Contract item (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelServPrcList(
			string m3_PRS1, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_AGRS, 
			string m3_CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelServPrcList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRS1))
				throw new ArgumentNullException("m3_PRS1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_AGRS))
				throw new ArgumentNullException("m3_AGRS");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRS1", m3_PRS1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("AGRS", m3_AGRS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

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
		/// Name GetServPrcList
		/// Description GetServPrcList
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRS1">Price list SO (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_AGRS">Contract item (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetServPrcListResponse></returns>
		/// <exception cref="M3Exception<GetServPrcListResponse>"></exception>
		public async Task<M3Response<GetServPrcListResponse>> GetServPrcList(
			string m3_PRS1, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_AGRS, 
			string m3_CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetServPrcList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRS1))
				throw new ArgumentNullException("m3_PRS1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_AGRS))
				throw new ArgumentNullException("m3_AGRS");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRS1", m3_PRS1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("AGRS", m3_AGRS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<GetServPrcListResponse>(
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
		/// Name LstServPrcList
		/// Description LstServPrcList
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRS1">Price list SO (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_AGRS">Contract item</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServPrcListResponse></returns>
		/// <exception cref="M3Exception<LstServPrcListResponse>"></exception>
		public async Task<M3Response<LstServPrcListResponse>> LstServPrcList(
			string m3_PRS1, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_CUNO = null, 
			string m3_AGRS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstServPrcList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRS1))
				throw new ArgumentNullException("m3_PRS1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRS1", m3_PRS1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRS))
				request.WithQueryParameter("AGRS", m3_AGRS.Trim());

			// Execute the request
			var result = await Execute<LstServPrcListResponse>(
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
		/// Name UpdServPrcList
		/// Description UpdServPrcList
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_PRS1">Price list SO (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_AGRS">Contract item (Required)</param>
		/// <param name="m3_QTYL">Lowest quantity limit (Required)</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_NQTY">New lowest quantity limit</param>
		/// <param name="m3_NTCD">Net price used</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_DIPR">Discount amount per unit</param>
		/// <param name="m3_DIPC">Discount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdServPrcList(
			string m3_PRS1, 
			string m3_CUCD, 
			DateTime m3_STDT, 
			string m3_AGRS, 
			decimal m3_QTYL, 
			string m3_CUNO = null, 
			decimal? m3_NQTY = null, 
			int? m3_NTCD = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			decimal? m3_DIPR = null, 
			int? m3_DIPC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdServPrcList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRS1))
				throw new ArgumentNullException("m3_PRS1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_AGRS))
				throw new ArgumentNullException("m3_AGRS");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRS1", m3_PRS1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("AGRS", m3_AGRS.Trim())
				.WithQueryParameter("QTYL", m3_QTYL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_NQTY.HasValue)
				request.WithQueryParameter("NQTY", m3_NQTY.Value.ToString());
			if (m3_NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3_NTCD.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (m3_DIPR.HasValue)
				request.WithQueryParameter("DIPR", m3_DIPR.Value.ToString());
			if (m3_DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3_DIPC.Value.ToString());

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
