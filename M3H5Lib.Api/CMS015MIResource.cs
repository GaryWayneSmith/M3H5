/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS015MI;
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
	/// Name: CMS015MI
	/// Component Name: Information Browser MI
	/// Description: Information Browser MI - Interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CMS015MIResource : M3BaseResourceEndpoint
	{
		public CMS015MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS015MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCustomMI
		/// Description Adds a custom MI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRID">Transaction ID (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_QTTP">Sorting order</param>
		/// <param name="m3_PAVR">View</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="m3_AGGR">Aggregation</param>
		/// <param name="m3_SUB1">Subtotal 1</param>
		/// <param name="m3_SUB2">Subtotal 2</param>
		/// <param name="m3_SUB3">Subtotal 3</param>
		/// <param name="m3_SLF1">Selection field 1</param>
		/// <param name="m3_SLF2">Selection field 2</param>
		/// <param name="m3_SLF3">Selection field 3</param>
		/// <param name="m3_SACH">Search</param>
		/// <param name="m3_INBO">Include bookmark fields</param>
		/// <param name="m3_MXRE">Maximum number of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustomMI(
			string m3_TRID, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_IBCA = null, 
			string m3_ACGR = null, 
			int? m3_QTTP = null, 
			string m3_PAVR = null, 
			int? m3_NFTR = null, 
			int? m3_AGGR = null, 
			int? m3_SUB1 = null, 
			int? m3_SUB2 = null, 
			int? m3_SUB3 = null, 
			string m3_SLF1 = null, 
			string m3_SLF2 = null, 
			string m3_SLF3 = null, 
			int? m3_SACH = null, 
			int? m3_INBO = null, 
			int? m3_MXRE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCustomMI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRID))
				throw new ArgumentNullException("m3_TRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3_TRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3_QTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAVR))
				request.WithQueryParameter("PAVR", m3_PAVR.Trim());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());
			if (m3_AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3_AGGR.Value.ToString());
			if (m3_SUB1.HasValue)
				request.WithQueryParameter("SUB1", m3_SUB1.Value.ToString());
			if (m3_SUB2.HasValue)
				request.WithQueryParameter("SUB2", m3_SUB2.Value.ToString());
			if (m3_SUB3.HasValue)
				request.WithQueryParameter("SUB3", m3_SUB3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLF1))
				request.WithQueryParameter("SLF1", m3_SLF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLF2))
				request.WithQueryParameter("SLF2", m3_SLF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLF3))
				request.WithQueryParameter("SLF3", m3_SLF3.Trim());
			if (m3_SACH.HasValue)
				request.WithQueryParameter("SACH", m3_SACH.Value.ToString());
			if (m3_INBO.HasValue)
				request.WithQueryParameter("INBO", m3_INBO.Value.ToString());
			if (m3_MXRE.HasValue)
				request.WithQueryParameter("MXRE", m3_MXRE.Value.ToString());

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
		/// Name DltCustomMI
		/// Description Deletes a custom MI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRID">Transaction ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCustomMI(
			string m3_TRID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCustomMI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRID))
				throw new ArgumentNullException("m3_TRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3_TRID.Trim());

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
		/// Name DltMIRepository
		/// Description DltMIRepository
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRID">Transaction ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DltMIRepositoryResponse></returns>
		/// <exception cref="M3Exception<DltMIRepositoryResponse>"></exception>
		public async Task<M3Response<DltMIRepositoryResponse>> DltMIRepository(
			string m3_TRID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltMIRepository",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRID))
				throw new ArgumentNullException("m3_TRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3_TRID.Trim());

			// Execute the request
			var result = await Execute<DltMIRepositoryResponse>(
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
		/// Name GetCustomMI
		/// Description Gets data for custom MI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRID">New field description (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustomMIResponse></returns>
		/// <exception cref="M3Exception<GetCustomMIResponse>"></exception>
		public async Task<M3Response<GetCustomMIResponse>> GetCustomMI(
			string m3_TRID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCustomMI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRID))
				throw new ArgumentNullException("m3_TRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3_TRID.Trim());

			// Execute the request
			var result = await Execute<GetCustomMIResponse>(
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
		/// Name ImportCustomMI
		/// Description Adds a custom MI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRID">Transaction ID (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_QTTP">Sorting order</param>
		/// <param name="m3_PAVR">View</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="m3_AGGR">Aggregation</param>
		/// <param name="m3_SUB1">Subtotal 1</param>
		/// <param name="m3_SUB2">Subtotal 2</param>
		/// <param name="m3_SUB3">Subtotal 3</param>
		/// <param name="m3_SLF1">Selection field 1</param>
		/// <param name="m3_SLF2">Selection field 2</param>
		/// <param name="m3_SLF3">Selection field 3</param>
		/// <param name="m3_SACH">Search</param>
		/// <param name="m3_INBO">Include bookmark fields</param>
		/// <param name="m3_MXRE">Maximum number of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ImportCustomMI(
			string m3_TRID, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_IBCA = null, 
			string m3_ACGR = null, 
			int? m3_QTTP = null, 
			string m3_PAVR = null, 
			int? m3_NFTR = null, 
			int? m3_AGGR = null, 
			int? m3_SUB1 = null, 
			int? m3_SUB2 = null, 
			int? m3_SUB3 = null, 
			string m3_SLF1 = null, 
			string m3_SLF2 = null, 
			string m3_SLF3 = null, 
			int? m3_SACH = null, 
			int? m3_INBO = null, 
			int? m3_MXRE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ImportCustomMI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRID))
				throw new ArgumentNullException("m3_TRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3_TRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3_QTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAVR))
				request.WithQueryParameter("PAVR", m3_PAVR.Trim());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());
			if (m3_AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3_AGGR.Value.ToString());
			if (m3_SUB1.HasValue)
				request.WithQueryParameter("SUB1", m3_SUB1.Value.ToString());
			if (m3_SUB2.HasValue)
				request.WithQueryParameter("SUB2", m3_SUB2.Value.ToString());
			if (m3_SUB3.HasValue)
				request.WithQueryParameter("SUB3", m3_SUB3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLF1))
				request.WithQueryParameter("SLF1", m3_SLF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLF2))
				request.WithQueryParameter("SLF2", m3_SLF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLF3))
				request.WithQueryParameter("SLF3", m3_SLF3.Trim());
			if (m3_SACH.HasValue)
				request.WithQueryParameter("SACH", m3_SACH.Value.ToString());
			if (m3_INBO.HasValue)
				request.WithQueryParameter("INBO", m3_INBO.Value.ToString());
			if (m3_MXRE.HasValue)
				request.WithQueryParameter("MXRE", m3_MXRE.Value.ToString());

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
		/// Name LstCustomMI
		/// Description List records for custom MI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRID">Transaction ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustomMIResponse></returns>
		/// <exception cref="M3Exception<LstCustomMIResponse>"></exception>
		public async Task<M3Response<LstCustomMIResponse>> LstCustomMI(
			string m3_TRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustomMI",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TRID))
				request.WithQueryParameter("TRID", m3_TRID.Trim());

			// Execute the request
			var result = await Execute<LstCustomMIResponse>(
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
		/// Name UpdCustomMI
		/// Description Update data for custom MI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRID">Transaction ID (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_QTTP">Sorting order</param>
		/// <param name="m3_PAVR">View</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="m3_AGGR">Aggregation</param>
		/// <param name="m3_SUB1">Subtotal 1</param>
		/// <param name="m3_SUB2">Subtotal 2</param>
		/// <param name="m3_SUB3">Subtotal 3</param>
		/// <param name="m3_SLF1">Selection field 1</param>
		/// <param name="m3_SLF2">Selection field 2</param>
		/// <param name="m3_SLF3">Selection field 3</param>
		/// <param name="m3_SACH">Search</param>
		/// <param name="m3_INBO">Include bookmark fields</param>
		/// <param name="m3_MXRE">Maximum number of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCustomMI(
			string m3_TRID, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_ACGR = null, 
			int? m3_QTTP = null, 
			string m3_PAVR = null, 
			int? m3_NFTR = null, 
			int? m3_AGGR = null, 
			int? m3_SUB1 = null, 
			int? m3_SUB2 = null, 
			int? m3_SUB3 = null, 
			string m3_SLF1 = null, 
			string m3_SLF2 = null, 
			string m3_SLF3 = null, 
			int? m3_SACH = null, 
			int? m3_INBO = null, 
			int? m3_MXRE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCustomMI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRID))
				throw new ArgumentNullException("m3_TRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3_TRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3_QTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAVR))
				request.WithQueryParameter("PAVR", m3_PAVR.Trim());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());
			if (m3_AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3_AGGR.Value.ToString());
			if (m3_SUB1.HasValue)
				request.WithQueryParameter("SUB1", m3_SUB1.Value.ToString());
			if (m3_SUB2.HasValue)
				request.WithQueryParameter("SUB2", m3_SUB2.Value.ToString());
			if (m3_SUB3.HasValue)
				request.WithQueryParameter("SUB3", m3_SUB3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLF1))
				request.WithQueryParameter("SLF1", m3_SLF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLF2))
				request.WithQueryParameter("SLF2", m3_SLF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLF3))
				request.WithQueryParameter("SLF3", m3_SLF3.Trim());
			if (m3_SACH.HasValue)
				request.WithQueryParameter("SACH", m3_SACH.Value.ToString());
			if (m3_INBO.HasValue)
				request.WithQueryParameter("INBO", m3_INBO.Value.ToString());
			if (m3_MXRE.HasValue)
				request.WithQueryParameter("MXRE", m3_MXRE.Value.ToString());

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
		/// Name UpdMIRepository
		/// Description UpdMIRepository
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRID">Transaction ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdMIRepositoryResponse></returns>
		/// <exception cref="M3Exception<UpdMIRepositoryResponse>"></exception>
		public async Task<M3Response<UpdMIRepositoryResponse>> UpdMIRepository(
			string m3_TRID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdMIRepository",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRID))
				throw new ArgumentNullException("m3_TRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3_TRID.Trim());

			// Execute the request
			var result = await Execute<UpdMIRepositoryResponse>(
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
