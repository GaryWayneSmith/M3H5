/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3TRID">Transaction ID (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3QTTP">Sorting order</param>
		/// <param name="m3PAVR">View</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="m3AGGR">Aggregation</param>
		/// <param name="m3SUB1">Subtotal 1</param>
		/// <param name="m3SUB2">Subtotal 2</param>
		/// <param name="m3SUB3">Subtotal 3</param>
		/// <param name="m3SLF1">Selection field 1</param>
		/// <param name="m3SLF2">Selection field 2</param>
		/// <param name="m3SLF3">Selection field 3</param>
		/// <param name="m3SACH">Search</param>
		/// <param name="m3INBO">Include bookmark fields</param>
		/// <param name="m3MXRE">Maximum number of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCustomMI(
			string m3TRID, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3IBCA = null, 
			string m3ACGR = null, 
			int? m3QTTP = null, 
			string m3PAVR = null, 
			int? m3NFTR = null, 
			int? m3AGGR = null, 
			int? m3SUB1 = null, 
			int? m3SUB2 = null, 
			int? m3SUB3 = null, 
			string m3SLF1 = null, 
			string m3SLF2 = null, 
			string m3SLF3 = null, 
			int? m3SACH = null, 
			int? m3INBO = null, 
			int? m3MXRE = null, 
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
			if (string.IsNullOrWhiteSpace(m3TRID))
				throw new ArgumentNullException(nameof(m3TRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3TRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3QTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAVR))
				request.WithQueryParameter("PAVR", m3PAVR.Trim());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3AGGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB1.HasValue)
				request.WithQueryParameter("SUB1", m3SUB1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB2.HasValue)
				request.WithQueryParameter("SUB2", m3SUB2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB3.HasValue)
				request.WithQueryParameter("SUB3", m3SUB3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLF1))
				request.WithQueryParameter("SLF1", m3SLF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLF2))
				request.WithQueryParameter("SLF2", m3SLF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLF3))
				request.WithQueryParameter("SLF3", m3SLF3.Trim());
			if (m3SACH.HasValue)
				request.WithQueryParameter("SACH", m3SACH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INBO.HasValue)
				request.WithQueryParameter("INBO", m3INBO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXRE.HasValue)
				request.WithQueryParameter("MXRE", m3MXRE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name DltCustomMI
		/// Description Deletes a custom MI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TRID">Transaction ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCustomMI(
			string m3TRID, 
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
			if (string.IsNullOrWhiteSpace(m3TRID))
				throw new ArgumentNullException(nameof(m3TRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3TRID.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name DltMIRepository
		/// Description DltMIRepository
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TRID">Transaction ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DltMIRepositoryResponse></returns>
		/// <exception cref="M3Exception<DltMIRepositoryResponse>"></exception>
		public async Task<M3Response<DltMIRepositoryResponse>> DltMIRepository(
			string m3TRID, 
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
			if (string.IsNullOrWhiteSpace(m3TRID))
				throw new ArgumentNullException(nameof(m3TRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3TRID.Trim());

			// Execute the request
			var result = await Execute<DltMIRepositoryResponse>(
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
		/// Name GetCustomMI
		/// Description Gets data for custom MI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TRID">New field description (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCustomMIResponse></returns>
		/// <exception cref="M3Exception<GetCustomMIResponse>"></exception>
		public async Task<M3Response<GetCustomMIResponse>> GetCustomMI(
			string m3TRID, 
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
			if (string.IsNullOrWhiteSpace(m3TRID))
				throw new ArgumentNullException(nameof(m3TRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3TRID.Trim());

			// Execute the request
			var result = await Execute<GetCustomMIResponse>(
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
		/// Name ImportCustomMI
		/// Description Adds a custom MI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TRID">Transaction ID (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3QTTP">Sorting order</param>
		/// <param name="m3PAVR">View</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="m3AGGR">Aggregation</param>
		/// <param name="m3SUB1">Subtotal 1</param>
		/// <param name="m3SUB2">Subtotal 2</param>
		/// <param name="m3SUB3">Subtotal 3</param>
		/// <param name="m3SLF1">Selection field 1</param>
		/// <param name="m3SLF2">Selection field 2</param>
		/// <param name="m3SLF3">Selection field 3</param>
		/// <param name="m3SACH">Search</param>
		/// <param name="m3INBO">Include bookmark fields</param>
		/// <param name="m3MXRE">Maximum number of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ImportCustomMI(
			string m3TRID, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3IBCA = null, 
			string m3ACGR = null, 
			int? m3QTTP = null, 
			string m3PAVR = null, 
			int? m3NFTR = null, 
			int? m3AGGR = null, 
			int? m3SUB1 = null, 
			int? m3SUB2 = null, 
			int? m3SUB3 = null, 
			string m3SLF1 = null, 
			string m3SLF2 = null, 
			string m3SLF3 = null, 
			int? m3SACH = null, 
			int? m3INBO = null, 
			int? m3MXRE = null, 
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
			if (string.IsNullOrWhiteSpace(m3TRID))
				throw new ArgumentNullException(nameof(m3TRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3TRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3QTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAVR))
				request.WithQueryParameter("PAVR", m3PAVR.Trim());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3AGGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB1.HasValue)
				request.WithQueryParameter("SUB1", m3SUB1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB2.HasValue)
				request.WithQueryParameter("SUB2", m3SUB2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB3.HasValue)
				request.WithQueryParameter("SUB3", m3SUB3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLF1))
				request.WithQueryParameter("SLF1", m3SLF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLF2))
				request.WithQueryParameter("SLF2", m3SLF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLF3))
				request.WithQueryParameter("SLF3", m3SLF3.Trim());
			if (m3SACH.HasValue)
				request.WithQueryParameter("SACH", m3SACH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INBO.HasValue)
				request.WithQueryParameter("INBO", m3INBO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXRE.HasValue)
				request.WithQueryParameter("MXRE", m3MXRE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name LstCustomMI
		/// Description List records for custom MI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TRID">Transaction ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustomMIResponse></returns>
		/// <exception cref="M3Exception<LstCustomMIResponse>"></exception>
		public async Task<M3Response<LstCustomMIResponse>> LstCustomMI(
			string m3TRID = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TRID))
				request.WithQueryParameter("TRID", m3TRID.Trim());

			// Execute the request
			var result = await Execute<LstCustomMIResponse>(
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
		/// Name UpdCustomMI
		/// Description Update data for custom MI
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TRID">Transaction ID (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3QTTP">Sorting order</param>
		/// <param name="m3PAVR">View</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="m3AGGR">Aggregation</param>
		/// <param name="m3SUB1">Subtotal 1</param>
		/// <param name="m3SUB2">Subtotal 2</param>
		/// <param name="m3SUB3">Subtotal 3</param>
		/// <param name="m3SLF1">Selection field 1</param>
		/// <param name="m3SLF2">Selection field 2</param>
		/// <param name="m3SLF3">Selection field 3</param>
		/// <param name="m3SACH">Search</param>
		/// <param name="m3INBO">Include bookmark fields</param>
		/// <param name="m3MXRE">Maximum number of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCustomMI(
			string m3TRID, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3ACGR = null, 
			int? m3QTTP = null, 
			string m3PAVR = null, 
			int? m3NFTR = null, 
			int? m3AGGR = null, 
			int? m3SUB1 = null, 
			int? m3SUB2 = null, 
			int? m3SUB3 = null, 
			string m3SLF1 = null, 
			string m3SLF2 = null, 
			string m3SLF3 = null, 
			int? m3SACH = null, 
			int? m3INBO = null, 
			int? m3MXRE = null, 
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
			if (string.IsNullOrWhiteSpace(m3TRID))
				throw new ArgumentNullException(nameof(m3TRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3TRID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3QTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAVR))
				request.WithQueryParameter("PAVR", m3PAVR.Trim());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3AGGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB1.HasValue)
				request.WithQueryParameter("SUB1", m3SUB1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB2.HasValue)
				request.WithQueryParameter("SUB2", m3SUB2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB3.HasValue)
				request.WithQueryParameter("SUB3", m3SUB3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLF1))
				request.WithQueryParameter("SLF1", m3SLF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLF2))
				request.WithQueryParameter("SLF2", m3SLF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLF3))
				request.WithQueryParameter("SLF3", m3SLF3.Trim());
			if (m3SACH.HasValue)
				request.WithQueryParameter("SACH", m3SACH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INBO.HasValue)
				request.WithQueryParameter("INBO", m3INBO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXRE.HasValue)
				request.WithQueryParameter("MXRE", m3MXRE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name UpdMIRepository
		/// Description UpdMIRepository
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TRID">Transaction ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdMIRepositoryResponse></returns>
		/// <exception cref="M3Exception<UpdMIRepositoryResponse>"></exception>
		public async Task<M3Response<UpdMIRepositoryResponse>> UpdMIRepository(
			string m3TRID, 
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
			if (string.IsNullOrWhiteSpace(m3TRID))
				throw new ArgumentNullException(nameof(m3TRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRID", m3TRID.Trim());

			// Execute the request
			var result = await Execute<UpdMIRepositoryResponse>(
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
