/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS881MI;
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
	/// Name: CRS881MI
	/// Component Name: BusinessMessageDataTrans
	/// Description: Business message data translation interface
	/// Version Release: 14.x
	///</summary>
	public partial class CRS881MIResource : M3BaseResourceEndpoint
	{
		public CRS881MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS881MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTranslData
		/// Description Add Translation Data
		/// Version Release: 
		/// </summary>
		/// <param name="m3_TRQF">Record type (Required)</param>
		/// <param name="m3_MSTD">Message standard (Required)</param>
		/// <param name="m3_MVRS">Message version (Required)</param>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_TX15">Name (Required)</param>
		/// <param name="m3_ELMC">Conditional element</param>
		/// <param name="m3_MBMC">Conditional data</param>
		/// <param name="m3_MVXP">Movex partner address</param>
		/// <param name="m3_EXTP">External partner address</param>
		/// <param name="m3_MVXD">Movex data</param>
		/// <param name="m3_MBMD">Message data</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTranslData(
			string m3_TRQF, 
			string m3_MSTD, 
			string m3_MVRS, 
			string m3_BMSG, 
			string m3_IBOB, 
			string m3_ELMP, 
			string m3_ELMD, 
			string m3_TX15, 
			string m3_ELMC = null, 
			string m3_MBMC = null, 
			string m3_MVXP = null, 
			string m3_EXTP = null, 
			string m3_MVXD = null, 
			string m3_MBMD = null, 
			string m3_TX40 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTranslData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRQF))
				throw new ArgumentNullException("m3_TRQF");
			if (string.IsNullOrWhiteSpace(m3_MSTD))
				throw new ArgumentNullException("m3_MSTD");
			if (string.IsNullOrWhiteSpace(m3_MVRS))
				throw new ArgumentNullException("m3_MVRS");
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_IBOB))
				throw new ArgumentNullException("m3_IBOB");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");
			if (string.IsNullOrWhiteSpace(m3_TX15))
				throw new ArgumentNullException("m3_TX15");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3_TRQF.Trim())
				.WithQueryParameter("MSTD", m3_MSTD.Trim())
				.WithQueryParameter("MVRS", m3_MVRS.Trim())
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("IBOB", m3_IBOB.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim())
				.WithQueryParameter("TX15", m3_TX15.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ELMC))
				request.WithQueryParameter("ELMC", m3_ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MBMC))
				request.WithQueryParameter("MBMC", m3_MBMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVXP))
				request.WithQueryParameter("MVXP", m3_MVXP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXTP))
				request.WithQueryParameter("EXTP", m3_EXTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVXD))
				request.WithQueryParameter("MVXD", m3_MVXD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MBMD))
				request.WithQueryParameter("MBMD", m3_MBMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());

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
		/// Name AddTranslation
		/// Description Add Translation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRQF">Record type (Required)</param>
		/// <param name="m3_MSTD">Message standard (Required)</param>
		/// <param name="m3_MVRS">Message version (Required)</param>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_IDTR">Business data translation identity (Required)</param>
		/// <param name="m3_ELMC">Conditional element</param>
		/// <param name="m3_MBMC">Conditional data</param>
		/// <param name="m3_FILE">File</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTranslation(
			string m3_TRQF, 
			string m3_MSTD, 
			string m3_MVRS, 
			string m3_BMSG, 
			string m3_IBOB, 
			string m3_ELMP, 
			string m3_ELMD, 
			int m3_IDTR, 
			string m3_ELMC = null, 
			string m3_MBMC = null, 
			string m3_FILE = null, 
			string m3_FLDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTranslation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRQF))
				throw new ArgumentNullException("m3_TRQF");
			if (string.IsNullOrWhiteSpace(m3_MSTD))
				throw new ArgumentNullException("m3_MSTD");
			if (string.IsNullOrWhiteSpace(m3_MVRS))
				throw new ArgumentNullException("m3_MVRS");
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_IBOB))
				throw new ArgumentNullException("m3_IBOB");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3_TRQF.Trim())
				.WithQueryParameter("MSTD", m3_MSTD.Trim())
				.WithQueryParameter("MVRS", m3_MVRS.Trim())
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("IBOB", m3_IBOB.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim())
				.WithQueryParameter("IDTR", m3_IDTR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ELMC))
				request.WithQueryParameter("ELMC", m3_ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MBMC))
				request.WithQueryParameter("MBMC", m3_MBMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());

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
		/// Name DelDeletedTrans
		/// Description Delete Deleted Translations with status 90
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDeletedTrans(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelDeletedTrans",
			};

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
		/// Name DelTranslData
		/// Description Delete Transalation Data
		/// Version Release: 
		/// </summary>
		/// <param name="m3_TRQF">Record type (Required)</param>
		/// <param name="m3_MSTD">Message standard (Required)</param>
		/// <param name="m3_MVRS">Message version (Required)</param>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_ELMC">Conditional element</param>
		/// <param name="m3_MBMC">Conditional data</param>
		/// <param name="m3_MVXP">Movex partner address</param>
		/// <param name="m3_EXTP">External partner address</param>
		/// <param name="m3_MVXD">Movex data</param>
		/// <param name="m3_MBMD">Message data</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTranslData(
			string m3_TRQF, 
			string m3_MSTD, 
			string m3_MVRS, 
			string m3_BMSG, 
			string m3_IBOB, 
			string m3_ELMP, 
			string m3_ELMD, 
			string m3_ELMC = null, 
			string m3_MBMC = null, 
			string m3_MVXP = null, 
			string m3_EXTP = null, 
			string m3_MVXD = null, 
			string m3_MBMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelTranslData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRQF))
				throw new ArgumentNullException("m3_TRQF");
			if (string.IsNullOrWhiteSpace(m3_MSTD))
				throw new ArgumentNullException("m3_MSTD");
			if (string.IsNullOrWhiteSpace(m3_MVRS))
				throw new ArgumentNullException("m3_MVRS");
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_IBOB))
				throw new ArgumentNullException("m3_IBOB");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3_TRQF.Trim())
				.WithQueryParameter("MSTD", m3_MSTD.Trim())
				.WithQueryParameter("MVRS", m3_MVRS.Trim())
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("IBOB", m3_IBOB.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ELMC))
				request.WithQueryParameter("ELMC", m3_ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MBMC))
				request.WithQueryParameter("MBMC", m3_MBMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVXP))
				request.WithQueryParameter("MVXP", m3_MVXP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXTP))
				request.WithQueryParameter("EXTP", m3_EXTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVXD))
				request.WithQueryParameter("MVXD", m3_MVXD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MBMD))
				request.WithQueryParameter("MBMD", m3_MBMD.Trim());

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
		/// Name DelTranslation
		/// Description Delete Translation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRQF">Record type (Required)</param>
		/// <param name="m3_MSTD">Message standard (Required)</param>
		/// <param name="m3_MVRS">Message version (Required)</param>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_ELMC">Conditional element</param>
		/// <param name="m3_MBMC">Conditional data</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTranslation(
			string m3_TRQF, 
			string m3_MSTD, 
			string m3_MVRS, 
			string m3_BMSG, 
			string m3_IBOB, 
			string m3_ELMP, 
			string m3_ELMD, 
			string m3_ELMC = null, 
			string m3_MBMC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelTranslation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRQF))
				throw new ArgumentNullException("m3_TRQF");
			if (string.IsNullOrWhiteSpace(m3_MSTD))
				throw new ArgumentNullException("m3_MSTD");
			if (string.IsNullOrWhiteSpace(m3_MVRS))
				throw new ArgumentNullException("m3_MVRS");
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_IBOB))
				throw new ArgumentNullException("m3_IBOB");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3_TRQF.Trim())
				.WithQueryParameter("MSTD", m3_MSTD.Trim())
				.WithQueryParameter("MVRS", m3_MVRS.Trim())
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("IBOB", m3_IBOB.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ELMC))
				request.WithQueryParameter("ELMC", m3_ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MBMC))
				request.WithQueryParameter("MBMC", m3_MBMC.Trim());

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
		/// Name DelUnusedTrans
		/// Description Delete Unused Translations with status 05
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelUnusedTrans(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelUnusedTrans",
			};

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
		/// Name GetMaxId
		/// Description Get highest translation identity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMaxIdResponse></returns>
		/// <exception cref="M3Exception<GetMaxIdResponse>"></exception>
		public async Task<M3Response<GetMaxIdResponse>> GetMaxId(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMaxId",
			};

			// Execute the request
			var result = await Execute<GetMaxIdResponse>(
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
		/// Name GetTranslData
		/// Description Get Translation Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRQF">Record type (Required)</param>
		/// <param name="m3_MSTD">Message standard (Required)</param>
		/// <param name="m3_MVRS">Message version (Required)</param>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_ELMC">Conditional element</param>
		/// <param name="m3_MBMC">Conditional data</param>
		/// <param name="m3_MVXP">Movex partner address</param>
		/// <param name="m3_EXTP">External partner address</param>
		/// <param name="m3_MVXD">Movex data</param>
		/// <param name="m3_MBMD">Message data</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTranslDataResponse></returns>
		/// <exception cref="M3Exception<GetTranslDataResponse>"></exception>
		public async Task<M3Response<GetTranslDataResponse>> GetTranslData(
			string m3_TRQF, 
			string m3_MSTD, 
			string m3_MVRS, 
			string m3_BMSG, 
			string m3_IBOB, 
			string m3_ELMP, 
			string m3_ELMD, 
			string m3_ELMC = null, 
			string m3_MBMC = null, 
			string m3_MVXP = null, 
			string m3_EXTP = null, 
			string m3_MVXD = null, 
			string m3_MBMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTranslData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRQF))
				throw new ArgumentNullException("m3_TRQF");
			if (string.IsNullOrWhiteSpace(m3_MSTD))
				throw new ArgumentNullException("m3_MSTD");
			if (string.IsNullOrWhiteSpace(m3_MVRS))
				throw new ArgumentNullException("m3_MVRS");
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_IBOB))
				throw new ArgumentNullException("m3_IBOB");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3_TRQF.Trim())
				.WithQueryParameter("MSTD", m3_MSTD.Trim())
				.WithQueryParameter("MVRS", m3_MVRS.Trim())
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("IBOB", m3_IBOB.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ELMC))
				request.WithQueryParameter("ELMC", m3_ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MBMC))
				request.WithQueryParameter("MBMC", m3_MBMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVXP))
				request.WithQueryParameter("MVXP", m3_MVXP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXTP))
				request.WithQueryParameter("EXTP", m3_EXTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MVXD))
				request.WithQueryParameter("MVXD", m3_MVXD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MBMD))
				request.WithQueryParameter("MBMD", m3_MBMD.Trim());

			// Execute the request
			var result = await Execute<GetTranslDataResponse>(
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
		/// Name GetTranslation
		/// Description Get Translation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRQF">Record type (Required)</param>
		/// <param name="m3_MSTD">Message standard (Required)</param>
		/// <param name="m3_MVRS">Message version (Required)</param>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_ELMC">Conditional element</param>
		/// <param name="m3_MBMC">Conditional data</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTranslationResponse></returns>
		/// <exception cref="M3Exception<GetTranslationResponse>"></exception>
		public async Task<M3Response<GetTranslationResponse>> GetTranslation(
			string m3_TRQF, 
			string m3_MSTD, 
			string m3_MVRS, 
			string m3_BMSG, 
			string m3_IBOB, 
			string m3_ELMP, 
			string m3_ELMD, 
			string m3_ELMC = null, 
			string m3_MBMC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTranslation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRQF))
				throw new ArgumentNullException("m3_TRQF");
			if (string.IsNullOrWhiteSpace(m3_MSTD))
				throw new ArgumentNullException("m3_MSTD");
			if (string.IsNullOrWhiteSpace(m3_MVRS))
				throw new ArgumentNullException("m3_MVRS");
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_IBOB))
				throw new ArgumentNullException("m3_IBOB");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3_TRQF.Trim())
				.WithQueryParameter("MSTD", m3_MSTD.Trim())
				.WithQueryParameter("MVRS", m3_MVRS.Trim())
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("IBOB", m3_IBOB.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ELMC))
				request.WithQueryParameter("ELMC", m3_ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MBMC))
				request.WithQueryParameter("MBMC", m3_MBMC.Trim());

			// Execute the request
			var result = await Execute<GetTranslationResponse>(
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
		/// Name LstTranslData
		/// Description List Translation Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRQF">Record type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTranslDataResponse></returns>
		/// <exception cref="M3Exception<LstTranslDataResponse>"></exception>
		public async Task<M3Response<LstTranslDataResponse>> LstTranslData(
			string m3_TRQF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTranslData",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TRQF))
				request.WithQueryParameter("TRQF", m3_TRQF.Trim());

			// Execute the request
			var result = await Execute<LstTranslDataResponse>(
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
		/// Name UpdAllStatuses
		/// Description Update All Statuses
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SLFR">From status</param>
		/// <param name="m3_SLTO">To status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAllStatuses(
			string m3_SLFR = null, 
			string m3_SLTO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAllStatuses",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SLFR))
				request.WithQueryParameter("SLFR", m3_SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTO))
				request.WithQueryParameter("SLTO", m3_SLTO.Trim());

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
		/// Name UpdTranslation
		/// Description Update Translation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRQF">Record type (Required)</param>
		/// <param name="m3_MSTD">Message standard (Required)</param>
		/// <param name="m3_MVRS">Message version (Required)</param>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_ELMC">Conditional element</param>
		/// <param name="m3_MBMC">Conditional data</param>
		/// <param name="m3_FILE">File</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTranslation(
			string m3_TRQF, 
			string m3_MSTD, 
			string m3_MVRS, 
			string m3_BMSG, 
			string m3_IBOB, 
			string m3_ELMP, 
			string m3_ELMD, 
			string m3_STAT, 
			string m3_ELMC = null, 
			string m3_MBMC = null, 
			string m3_FILE = null, 
			string m3_FLDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTranslation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRQF))
				throw new ArgumentNullException("m3_TRQF");
			if (string.IsNullOrWhiteSpace(m3_MSTD))
				throw new ArgumentNullException("m3_MSTD");
			if (string.IsNullOrWhiteSpace(m3_MVRS))
				throw new ArgumentNullException("m3_MVRS");
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_IBOB))
				throw new ArgumentNullException("m3_IBOB");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3_TRQF.Trim())
				.WithQueryParameter("MSTD", m3_MSTD.Trim())
				.WithQueryParameter("MVRS", m3_MVRS.Trim())
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("IBOB", m3_IBOB.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ELMC))
				request.WithQueryParameter("ELMC", m3_ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MBMC))
				request.WithQueryParameter("MBMC", m3_MBMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());

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
