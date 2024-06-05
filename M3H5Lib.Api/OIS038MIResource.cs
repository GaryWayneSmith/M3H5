/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS038MI;
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
	/// Name: OIS038MI
	/// Component Name: BusinessChain
	/// Description: Business chain structure interface
	/// Version Release: 5ea0
	///</summary>
	public partial class OIS038MIResource : M3BaseResourceEndpoint
	{
		public OIS038MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS038MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBusChain
		/// Description Add Business Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CHAI">Business chain (Required)</param>
		/// <param name="m3_CHCT">Superior business chain</param>
		/// <param name="m3_CHMB">Member number</param>
		/// <param name="m3_MBST">Status - member</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBusChain(
			string m3_CHAI, 
			string m3_CHCT = null, 
			string m3_CHMB = null, 
			int? m3_MBST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBusChain",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CHAI))
				throw new ArgumentNullException("m3_CHAI");

			// Set mandatory parameters
			request
				.WithQueryParameter("CHAI", m3_CHAI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CHCT))
				request.WithQueryParameter("CHCT", m3_CHCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHMB))
				request.WithQueryParameter("CHMB", m3_CHMB.Trim());
			if (m3_MBST.HasValue)
				request.WithQueryParameter("MBST", m3_MBST.Value.ToString());

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
		/// Name AddBusChainCust
		/// Description Add Customer in Business Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CHCT">Superior business chain (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_CHMB">Member number</param>
		/// <param name="m3_MBST">Status - member</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBusChainCust(
			string m3_CHCT, 
			string m3_CUNO, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			string m3_CHMB = null, 
			int? m3_MBST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBusChainCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CHCT))
				throw new ArgumentNullException("m3_CHCT");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CHCT", m3_CHCT.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CHMB))
				request.WithQueryParameter("CHMB", m3_CHMB.Trim());
			if (m3_MBST.HasValue)
				request.WithQueryParameter("MBST", m3_MBST.Value.ToString());

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
		/// Name DelBusChain
		/// Description Delete Business Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CHAI">Business chain (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBusChain(
			string m3_CHAI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBusChain",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CHAI))
				throw new ArgumentNullException("m3_CHAI");

			// Set mandatory parameters
			request
				.WithQueryParameter("CHAI", m3_CHAI.Trim());

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
		/// Name DelBusChainCust
		/// Description Delete Customer in Business Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CHCT">Superior business chain (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBusChainCust(
			string m3_CHCT, 
			string m3_CUNO, 
			DateTime? m3_FVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBusChainCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CHCT))
				throw new ArgumentNullException("m3_CHCT");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CHCT", m3_CHCT.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());

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
		/// Name LstBusChainCust
		/// Description List business chain to customer relations
		/// Version Release: 12
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CHCT">Superior business chain</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_DATE">Entry date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBusChainCustResponse></returns>
		/// <exception cref="M3Exception<LstBusChainCustResponse>"></exception>
		public async Task<M3Response<LstBusChainCustResponse>> LstBusChainCust(
			int? m3_CONO = null, 
			string m3_CHCT = null, 
			string m3_CUNO = null, 
			DateTime? m3_DATE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBusChainCust",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHCT))
				request.WithQueryParameter("CHCT", m3_CHCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstBusChainCustResponse>(
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
		/// Name LstBusChainStr
		/// Description List business chain structure
		/// Version Release: 12
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CHAI">Business chain</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBusChainStrResponse></returns>
		/// <exception cref="M3Exception<LstBusChainStrResponse>"></exception>
		public async Task<M3Response<LstBusChainStrResponse>> LstBusChainStr(
			int? m3_CONO = null, 
			string m3_CHAI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBusChainStr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHAI))
				request.WithQueryParameter("CHAI", m3_CHAI.Trim());

			// Execute the request
			var result = await Execute<LstBusChainStrResponse>(
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
		/// Name UpdBusChain
		/// Description Update Business Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CHAI">Business chain (Required)</param>
		/// <param name="m3_CHCT">Superior business chain</param>
		/// <param name="m3_CHMB">Member number</param>
		/// <param name="m3_MBST">Status - member</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBusChain(
			string m3_CHAI, 
			string m3_CHCT = null, 
			string m3_CHMB = null, 
			int? m3_MBST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBusChain",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CHAI))
				throw new ArgumentNullException("m3_CHAI");

			// Set mandatory parameters
			request
				.WithQueryParameter("CHAI", m3_CHAI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CHCT))
				request.WithQueryParameter("CHCT", m3_CHCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHMB))
				request.WithQueryParameter("CHMB", m3_CHMB.Trim());
			if (m3_MBST.HasValue)
				request.WithQueryParameter("MBST", m3_MBST.Value.ToString());

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
		/// Name UpdBusChainCust
		/// Description Update Customer in Business Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CHCT">Superior business chain (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_CHMB">Member number</param>
		/// <param name="m3_MBST">Status - member</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBusChainCust(
			string m3_CHCT, 
			string m3_CUNO, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			string m3_CHMB = null, 
			int? m3_MBST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBusChainCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CHCT))
				throw new ArgumentNullException("m3_CHCT");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CHCT", m3_CHCT.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CHMB))
				request.WithQueryParameter("CHMB", m3_CHMB.Trim());
			if (m3_MBST.HasValue)
				request.WithQueryParameter("MBST", m3_MBST.Value.ToString());

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
