/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTranslData
		/// Description Add Translation Data
		/// Version Release: 
		/// </summary>
		/// <param name="m3TRQF">Record type (Required)</param>
		/// <param name="m3MSTD">Message standard (Required)</param>
		/// <param name="m3MVRS">Message version (Required)</param>
		/// <param name="m3BMSG">Business message (Required)</param>
		/// <param name="m3IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3ELMP">Parent element(s) (Required)</param>
		/// <param name="m3ELMD">Data element (Required)</param>
		/// <param name="m3TX15">Name (Required)</param>
		/// <param name="m3ELMC">Conditional element</param>
		/// <param name="m3MBMC">Conditional data</param>
		/// <param name="m3MVXP">Movex partner address</param>
		/// <param name="m3EXTP">External partner address</param>
		/// <param name="m3MVXD">Movex data</param>
		/// <param name="m3MBMD">Message data</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTranslData(
			string m3TRQF, 
			string m3MSTD, 
			string m3MVRS, 
			string m3BMSG, 
			string m3IBOB, 
			string m3ELMP, 
			string m3ELMD, 
			string m3TX15, 
			string m3ELMC = null, 
			string m3MBMC = null, 
			string m3MVXP = null, 
			string m3EXTP = null, 
			string m3MVXD = null, 
			string m3MBMD = null, 
			string m3TX40 = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddTranslData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TRQF))
				throw new ArgumentNullException(nameof(m3TRQF));
			if (string.IsNullOrWhiteSpace(m3MSTD))
				throw new ArgumentNullException(nameof(m3MSTD));
			if (string.IsNullOrWhiteSpace(m3MVRS))
				throw new ArgumentNullException(nameof(m3MVRS));
			if (string.IsNullOrWhiteSpace(m3BMSG))
				throw new ArgumentNullException(nameof(m3BMSG));
			if (string.IsNullOrWhiteSpace(m3IBOB))
				throw new ArgumentNullException(nameof(m3IBOB));
			if (string.IsNullOrWhiteSpace(m3ELMP))
				throw new ArgumentNullException(nameof(m3ELMP));
			if (string.IsNullOrWhiteSpace(m3ELMD))
				throw new ArgumentNullException(nameof(m3ELMD));
			if (string.IsNullOrWhiteSpace(m3TX15))
				throw new ArgumentNullException(nameof(m3TX15));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3TRQF.Trim())
				.WithQueryParameter("MSTD", m3MSTD.Trim())
				.WithQueryParameter("MVRS", m3MVRS.Trim())
				.WithQueryParameter("BMSG", m3BMSG.Trim())
				.WithQueryParameter("IBOB", m3IBOB.Trim())
				.WithQueryParameter("ELMP", m3ELMP.Trim())
				.WithQueryParameter("ELMD", m3ELMD.Trim())
				.WithQueryParameter("TX15", m3TX15.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ELMC))
				request.WithQueryParameter("ELMC", m3ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MBMC))
				request.WithQueryParameter("MBMC", m3MBMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVXP))
				request.WithQueryParameter("MVXP", m3MVXP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXTP))
				request.WithQueryParameter("EXTP", m3EXTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVXD))
				request.WithQueryParameter("MVXD", m3MVXD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MBMD))
				request.WithQueryParameter("MBMD", m3MBMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());

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
		/// Name AddTranslation
		/// Description Add Translation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRQF">Record type (Required)</param>
		/// <param name="m3MSTD">Message standard (Required)</param>
		/// <param name="m3MVRS">Message version (Required)</param>
		/// <param name="m3BMSG">Business message (Required)</param>
		/// <param name="m3IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3ELMP">Parent element(s) (Required)</param>
		/// <param name="m3ELMD">Data element (Required)</param>
		/// <param name="m3IDTR">Business data translation identity (Required)</param>
		/// <param name="m3ELMC">Conditional element</param>
		/// <param name="m3MBMC">Conditional data</param>
		/// <param name="m3FILE">File</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTranslation(
			string m3TRQF, 
			string m3MSTD, 
			string m3MVRS, 
			string m3BMSG, 
			string m3IBOB, 
			string m3ELMP, 
			string m3ELMD, 
			int m3IDTR, 
			string m3ELMC = null, 
			string m3MBMC = null, 
			string m3FILE = null, 
			string m3FLDI = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddTranslation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TRQF))
				throw new ArgumentNullException(nameof(m3TRQF));
			if (string.IsNullOrWhiteSpace(m3MSTD))
				throw new ArgumentNullException(nameof(m3MSTD));
			if (string.IsNullOrWhiteSpace(m3MVRS))
				throw new ArgumentNullException(nameof(m3MVRS));
			if (string.IsNullOrWhiteSpace(m3BMSG))
				throw new ArgumentNullException(nameof(m3BMSG));
			if (string.IsNullOrWhiteSpace(m3IBOB))
				throw new ArgumentNullException(nameof(m3IBOB));
			if (string.IsNullOrWhiteSpace(m3ELMP))
				throw new ArgumentNullException(nameof(m3ELMP));
			if (string.IsNullOrWhiteSpace(m3ELMD))
				throw new ArgumentNullException(nameof(m3ELMD));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3TRQF.Trim())
				.WithQueryParameter("MSTD", m3MSTD.Trim())
				.WithQueryParameter("MVRS", m3MVRS.Trim())
				.WithQueryParameter("BMSG", m3BMSG.Trim())
				.WithQueryParameter("IBOB", m3IBOB.Trim())
				.WithQueryParameter("ELMP", m3ELMP.Trim())
				.WithQueryParameter("ELMD", m3ELMD.Trim())
				.WithQueryParameter("IDTR", m3IDTR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ELMC))
				request.WithQueryParameter("ELMC", m3ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MBMC))
				request.WithQueryParameter("MBMC", m3MBMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelDeletedTrans",
			};

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
		/// Name DelTranslData
		/// Description Delete Transalation Data
		/// Version Release: 
		/// </summary>
		/// <param name="m3TRQF">Record type (Required)</param>
		/// <param name="m3MSTD">Message standard (Required)</param>
		/// <param name="m3MVRS">Message version (Required)</param>
		/// <param name="m3BMSG">Business message (Required)</param>
		/// <param name="m3IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3ELMP">Parent element(s) (Required)</param>
		/// <param name="m3ELMD">Data element (Required)</param>
		/// <param name="m3ELMC">Conditional element</param>
		/// <param name="m3MBMC">Conditional data</param>
		/// <param name="m3MVXP">Movex partner address</param>
		/// <param name="m3EXTP">External partner address</param>
		/// <param name="m3MVXD">Movex data</param>
		/// <param name="m3MBMD">Message data</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTranslData(
			string m3TRQF, 
			string m3MSTD, 
			string m3MVRS, 
			string m3BMSG, 
			string m3IBOB, 
			string m3ELMP, 
			string m3ELMD, 
			string m3ELMC = null, 
			string m3MBMC = null, 
			string m3MVXP = null, 
			string m3EXTP = null, 
			string m3MVXD = null, 
			string m3MBMD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelTranslData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TRQF))
				throw new ArgumentNullException(nameof(m3TRQF));
			if (string.IsNullOrWhiteSpace(m3MSTD))
				throw new ArgumentNullException(nameof(m3MSTD));
			if (string.IsNullOrWhiteSpace(m3MVRS))
				throw new ArgumentNullException(nameof(m3MVRS));
			if (string.IsNullOrWhiteSpace(m3BMSG))
				throw new ArgumentNullException(nameof(m3BMSG));
			if (string.IsNullOrWhiteSpace(m3IBOB))
				throw new ArgumentNullException(nameof(m3IBOB));
			if (string.IsNullOrWhiteSpace(m3ELMP))
				throw new ArgumentNullException(nameof(m3ELMP));
			if (string.IsNullOrWhiteSpace(m3ELMD))
				throw new ArgumentNullException(nameof(m3ELMD));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3TRQF.Trim())
				.WithQueryParameter("MSTD", m3MSTD.Trim())
				.WithQueryParameter("MVRS", m3MVRS.Trim())
				.WithQueryParameter("BMSG", m3BMSG.Trim())
				.WithQueryParameter("IBOB", m3IBOB.Trim())
				.WithQueryParameter("ELMP", m3ELMP.Trim())
				.WithQueryParameter("ELMD", m3ELMD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ELMC))
				request.WithQueryParameter("ELMC", m3ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MBMC))
				request.WithQueryParameter("MBMC", m3MBMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVXP))
				request.WithQueryParameter("MVXP", m3MVXP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXTP))
				request.WithQueryParameter("EXTP", m3EXTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVXD))
				request.WithQueryParameter("MVXD", m3MVXD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MBMD))
				request.WithQueryParameter("MBMD", m3MBMD.Trim());

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
		/// Name DelTranslation
		/// Description Delete Translation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRQF">Record type (Required)</param>
		/// <param name="m3MSTD">Message standard (Required)</param>
		/// <param name="m3MVRS">Message version (Required)</param>
		/// <param name="m3BMSG">Business message (Required)</param>
		/// <param name="m3IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3ELMP">Parent element(s) (Required)</param>
		/// <param name="m3ELMD">Data element (Required)</param>
		/// <param name="m3ELMC">Conditional element</param>
		/// <param name="m3MBMC">Conditional data</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTranslation(
			string m3TRQF, 
			string m3MSTD, 
			string m3MVRS, 
			string m3BMSG, 
			string m3IBOB, 
			string m3ELMP, 
			string m3ELMD, 
			string m3ELMC = null, 
			string m3MBMC = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelTranslation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TRQF))
				throw new ArgumentNullException(nameof(m3TRQF));
			if (string.IsNullOrWhiteSpace(m3MSTD))
				throw new ArgumentNullException(nameof(m3MSTD));
			if (string.IsNullOrWhiteSpace(m3MVRS))
				throw new ArgumentNullException(nameof(m3MVRS));
			if (string.IsNullOrWhiteSpace(m3BMSG))
				throw new ArgumentNullException(nameof(m3BMSG));
			if (string.IsNullOrWhiteSpace(m3IBOB))
				throw new ArgumentNullException(nameof(m3IBOB));
			if (string.IsNullOrWhiteSpace(m3ELMP))
				throw new ArgumentNullException(nameof(m3ELMP));
			if (string.IsNullOrWhiteSpace(m3ELMD))
				throw new ArgumentNullException(nameof(m3ELMD));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3TRQF.Trim())
				.WithQueryParameter("MSTD", m3MSTD.Trim())
				.WithQueryParameter("MVRS", m3MVRS.Trim())
				.WithQueryParameter("BMSG", m3BMSG.Trim())
				.WithQueryParameter("IBOB", m3IBOB.Trim())
				.WithQueryParameter("ELMP", m3ELMP.Trim())
				.WithQueryParameter("ELMD", m3ELMD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ELMC))
				request.WithQueryParameter("ELMC", m3ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MBMC))
				request.WithQueryParameter("MBMC", m3MBMC.Trim());

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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelUnusedTrans",
			};

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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMaxId",
			};

			// Execute the request
			var result = await Execute<GetMaxIdResponse>(
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
		/// Name GetTranslData
		/// Description Get Translation Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRQF">Record type (Required)</param>
		/// <param name="m3MSTD">Message standard (Required)</param>
		/// <param name="m3MVRS">Message version (Required)</param>
		/// <param name="m3BMSG">Business message (Required)</param>
		/// <param name="m3IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3ELMP">Parent element(s) (Required)</param>
		/// <param name="m3ELMD">Data element (Required)</param>
		/// <param name="m3ELMC">Conditional element</param>
		/// <param name="m3MBMC">Conditional data</param>
		/// <param name="m3MVXP">Movex partner address</param>
		/// <param name="m3EXTP">External partner address</param>
		/// <param name="m3MVXD">Movex data</param>
		/// <param name="m3MBMD">Message data</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTranslDataResponse></returns>
		/// <exception cref="M3Exception<GetTranslDataResponse>"></exception>
		public async Task<M3Response<GetTranslDataResponse>> GetTranslData(
			string m3TRQF, 
			string m3MSTD, 
			string m3MVRS, 
			string m3BMSG, 
			string m3IBOB, 
			string m3ELMP, 
			string m3ELMD, 
			string m3ELMC = null, 
			string m3MBMC = null, 
			string m3MVXP = null, 
			string m3EXTP = null, 
			string m3MVXD = null, 
			string m3MBMD = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetTranslData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TRQF))
				throw new ArgumentNullException(nameof(m3TRQF));
			if (string.IsNullOrWhiteSpace(m3MSTD))
				throw new ArgumentNullException(nameof(m3MSTD));
			if (string.IsNullOrWhiteSpace(m3MVRS))
				throw new ArgumentNullException(nameof(m3MVRS));
			if (string.IsNullOrWhiteSpace(m3BMSG))
				throw new ArgumentNullException(nameof(m3BMSG));
			if (string.IsNullOrWhiteSpace(m3IBOB))
				throw new ArgumentNullException(nameof(m3IBOB));
			if (string.IsNullOrWhiteSpace(m3ELMP))
				throw new ArgumentNullException(nameof(m3ELMP));
			if (string.IsNullOrWhiteSpace(m3ELMD))
				throw new ArgumentNullException(nameof(m3ELMD));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3TRQF.Trim())
				.WithQueryParameter("MSTD", m3MSTD.Trim())
				.WithQueryParameter("MVRS", m3MVRS.Trim())
				.WithQueryParameter("BMSG", m3BMSG.Trim())
				.WithQueryParameter("IBOB", m3IBOB.Trim())
				.WithQueryParameter("ELMP", m3ELMP.Trim())
				.WithQueryParameter("ELMD", m3ELMD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ELMC))
				request.WithQueryParameter("ELMC", m3ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MBMC))
				request.WithQueryParameter("MBMC", m3MBMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVXP))
				request.WithQueryParameter("MVXP", m3MVXP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXTP))
				request.WithQueryParameter("EXTP", m3EXTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MVXD))
				request.WithQueryParameter("MVXD", m3MVXD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MBMD))
				request.WithQueryParameter("MBMD", m3MBMD.Trim());

			// Execute the request
			var result = await Execute<GetTranslDataResponse>(
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
		/// Name GetTranslation
		/// Description Get Translation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRQF">Record type (Required)</param>
		/// <param name="m3MSTD">Message standard (Required)</param>
		/// <param name="m3MVRS">Message version (Required)</param>
		/// <param name="m3BMSG">Business message (Required)</param>
		/// <param name="m3IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3ELMP">Parent element(s) (Required)</param>
		/// <param name="m3ELMD">Data element (Required)</param>
		/// <param name="m3ELMC">Conditional element</param>
		/// <param name="m3MBMC">Conditional data</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTranslationResponse></returns>
		/// <exception cref="M3Exception<GetTranslationResponse>"></exception>
		public async Task<M3Response<GetTranslationResponse>> GetTranslation(
			string m3TRQF, 
			string m3MSTD, 
			string m3MVRS, 
			string m3BMSG, 
			string m3IBOB, 
			string m3ELMP, 
			string m3ELMD, 
			string m3ELMC = null, 
			string m3MBMC = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetTranslation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TRQF))
				throw new ArgumentNullException(nameof(m3TRQF));
			if (string.IsNullOrWhiteSpace(m3MSTD))
				throw new ArgumentNullException(nameof(m3MSTD));
			if (string.IsNullOrWhiteSpace(m3MVRS))
				throw new ArgumentNullException(nameof(m3MVRS));
			if (string.IsNullOrWhiteSpace(m3BMSG))
				throw new ArgumentNullException(nameof(m3BMSG));
			if (string.IsNullOrWhiteSpace(m3IBOB))
				throw new ArgumentNullException(nameof(m3IBOB));
			if (string.IsNullOrWhiteSpace(m3ELMP))
				throw new ArgumentNullException(nameof(m3ELMP));
			if (string.IsNullOrWhiteSpace(m3ELMD))
				throw new ArgumentNullException(nameof(m3ELMD));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3TRQF.Trim())
				.WithQueryParameter("MSTD", m3MSTD.Trim())
				.WithQueryParameter("MVRS", m3MVRS.Trim())
				.WithQueryParameter("BMSG", m3BMSG.Trim())
				.WithQueryParameter("IBOB", m3IBOB.Trim())
				.WithQueryParameter("ELMP", m3ELMP.Trim())
				.WithQueryParameter("ELMD", m3ELMD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ELMC))
				request.WithQueryParameter("ELMC", m3ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MBMC))
				request.WithQueryParameter("MBMC", m3MBMC.Trim());

			// Execute the request
			var result = await Execute<GetTranslationResponse>(
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
		/// Name LstTranslData
		/// Description List Translation Data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRQF">Record type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTranslDataResponse></returns>
		/// <exception cref="M3Exception<LstTranslDataResponse>"></exception>
		public async Task<M3Response<LstTranslDataResponse>> LstTranslData(
			string m3TRQF = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTranslData",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TRQF))
				request.WithQueryParameter("TRQF", m3TRQF.Trim());

			// Execute the request
			var result = await Execute<LstTranslDataResponse>(
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
		/// Name UpdAllStatuses
		/// Description Update All Statuses
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SLFR">From status</param>
		/// <param name="m3SLTO">To status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAllStatuses(
			string m3SLFR = null, 
			string m3SLTO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAllStatuses",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SLFR))
				request.WithQueryParameter("SLFR", m3SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTO))
				request.WithQueryParameter("SLTO", m3SLTO.Trim());

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
		/// Name UpdTranslation
		/// Description Update Translation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRQF">Record type (Required)</param>
		/// <param name="m3MSTD">Message standard (Required)</param>
		/// <param name="m3MVRS">Message version (Required)</param>
		/// <param name="m3BMSG">Business message (Required)</param>
		/// <param name="m3IBOB">Inbound or outbound message (Required)</param>
		/// <param name="m3ELMP">Parent element(s) (Required)</param>
		/// <param name="m3ELMD">Data element (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3ELMC">Conditional element</param>
		/// <param name="m3MBMC">Conditional data</param>
		/// <param name="m3FILE">File</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTranslation(
			string m3TRQF, 
			string m3MSTD, 
			string m3MVRS, 
			string m3BMSG, 
			string m3IBOB, 
			string m3ELMP, 
			string m3ELMD, 
			string m3STAT, 
			string m3ELMC = null, 
			string m3MBMC = null, 
			string m3FILE = null, 
			string m3FLDI = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdTranslation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TRQF))
				throw new ArgumentNullException(nameof(m3TRQF));
			if (string.IsNullOrWhiteSpace(m3MSTD))
				throw new ArgumentNullException(nameof(m3MSTD));
			if (string.IsNullOrWhiteSpace(m3MVRS))
				throw new ArgumentNullException(nameof(m3MVRS));
			if (string.IsNullOrWhiteSpace(m3BMSG))
				throw new ArgumentNullException(nameof(m3BMSG));
			if (string.IsNullOrWhiteSpace(m3IBOB))
				throw new ArgumentNullException(nameof(m3IBOB));
			if (string.IsNullOrWhiteSpace(m3ELMP))
				throw new ArgumentNullException(nameof(m3ELMP));
			if (string.IsNullOrWhiteSpace(m3ELMD))
				throw new ArgumentNullException(nameof(m3ELMD));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQF", m3TRQF.Trim())
				.WithQueryParameter("MSTD", m3MSTD.Trim())
				.WithQueryParameter("MVRS", m3MVRS.Trim())
				.WithQueryParameter("BMSG", m3BMSG.Trim())
				.WithQueryParameter("IBOB", m3IBOB.Trim())
				.WithQueryParameter("ELMP", m3ELMP.Trim())
				.WithQueryParameter("ELMD", m3ELMD.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ELMC))
				request.WithQueryParameter("ELMC", m3ELMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3MBMC))
				request.WithQueryParameter("MBMC", m3MBMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

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
	}
}
// EOF
