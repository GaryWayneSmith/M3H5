/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS474MI;
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
	/// Name: CMS474MI
	/// Component Name: Procurement
	/// Description: Api: User defined fields
	/// Version Release: 5ea1
	///</summary>
	public partial class CMS474MIResource : M3BaseResourceEndpoint
	{
		public CMS474MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS474MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCompInfo
		/// Description Adds user defined content, only for Fashion company
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_CFMA">Custom field - alphanumeric</param>
		/// <param name="m3_CFMN">Custom field - numeric</param>
		/// <param name="m3_CFMD">Custom field - date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCompInfo(
			string m3_ITNO, 
			string m3_CFMG, 
			string m3_CFMF, 
			int m3_SQNR, 
			string m3_CFMA = null, 
			decimal? m3_CFMN = null, 
			DateTime? m3_CFMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCompInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("CFMF", m3_CFMF.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CFMA))
				request.WithQueryParameter("CFMA", m3_CFMA.Trim());
			if (m3_CFMN.HasValue)
				request.WithQueryParameter("CFMN", m3_CFMN.Value.ToString());
			if (m3_CFMD.HasValue)
				request.WithQueryParameter("CFMD", m3_CFMD.Value.ToM3String());

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
		/// Name AddEqInfo
		/// Description Adds user defined content
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_CFMA">Custom field - alphanumeric</param>
		/// <param name="m3_CFMN">Custom field - numeric</param>
		/// <param name="m3_CFMD">Custom field - date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEqInfo(
			string m3_ITNO, 
			string m3_CFMG, 
			string m3_CFMF, 
			int m3_SQNR, 
			string m3_SERN = null, 
			string m3_CFMA = null, 
			decimal? m3_CFMN = null, 
			DateTime? m3_CFMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddEqInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("CFMF", m3_CFMF.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFMA))
				request.WithQueryParameter("CFMA", m3_CFMA.Trim());
			if (m3_CFMN.HasValue)
				request.WithQueryParameter("CFMN", m3_CFMN.Value.ToString());
			if (m3_CFMD.HasValue)
				request.WithQueryParameter("CFMD", m3_CFMD.Value.ToM3String());

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
		/// Name DltCompInfo
		/// Description Delete user defined content, only for Fashion company
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCompInfo(
			string m3_ITNO, 
			string m3_CFMG, 
			string m3_CFMF, 
			int m3_SQNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCompInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("CFMF", m3_CFMF.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

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
		/// Name DltEqInfo
		/// Description Delete user defined content
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltEqInfo(
			string m3_ITNO, 
			string m3_CFMG, 
			string m3_CFMF, 
			int m3_SQNR, 
			string m3_SERN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltEqInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("CFMF", m3_CFMF.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());

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
		/// Name GetCompInfo
		/// Description Get user defined content, only for Fashion company
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCompInfoResponse></returns>
		/// <exception cref="M3Exception<GetCompInfoResponse>"></exception>
		public async Task<M3Response<GetCompInfoResponse>> GetCompInfo(
			string m3_ITNO, 
			string m3_CFMG, 
			string m3_CFMF, 
			int m3_SQNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCompInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("CFMF", m3_CFMF.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Execute the request
			var result = await Execute<GetCompInfoResponse>(
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
		/// Name GetEqInfo
		/// Description Get user defined content
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEqInfoResponse></returns>
		/// <exception cref="M3Exception<GetEqInfoResponse>"></exception>
		public async Task<M3Response<GetEqInfoResponse>> GetEqInfo(
			string m3_ITNO, 
			string m3_CFMG, 
			string m3_CFMF, 
			int m3_SQNR, 
			string m3_SERN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetEqInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("CFMF", m3_CFMF.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());

			// Execute the request
			var result = await Execute<GetEqInfoResponse>(
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
		/// Name GetUdefContent
		/// Description GetUdefContent
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_UDFT">User defined fields - type (Required)</param>
		/// <param name="m3_CFMG">Field group (Required)</param>
		/// <param name="m3_CFMF">Field (Required)</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_GRPI">Group ID</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_ORAD">Origin address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUdefContentResponse></returns>
		/// <exception cref="M3Exception<GetUdefContentResponse>"></exception>
		public async Task<M3Response<GetUdefContentResponse>> GetUdefContent(
			string m3_UDFT, 
			string m3_CFMG, 
			string m3_CFMF, 
			string m3_ITNO = null, 
			string m3_SUNO = null, 
			string m3_AGNB = null, 
			int? m3_GRPI = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			DateTime? m3_FVDT = null, 
			string m3_ORAD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetUdefContent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_UDFT))
				throw new ArgumentNullException("m3_UDFT");
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("UDFT", m3_UDFT.Trim())
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("CFMF", m3_CFMF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_GRPI.HasValue)
				request.WithQueryParameter("GRPI", m3_GRPI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ORAD))
				request.WithQueryParameter("ORAD", m3_ORAD.Trim());

			// Execute the request
			var result = await Execute<GetUdefContentResponse>(
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
		/// Name LstCompInfo
		/// Description Lists user defined content, only for Fashion company
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CFMG">Custom field group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCompInfoResponse></returns>
		/// <exception cref="M3Exception<LstCompInfoResponse>"></exception>
		public async Task<M3Response<LstCompInfoResponse>> LstCompInfo(
			string m3_ITNO, 
			string m3_CFMG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCompInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CFMG))
				request.WithQueryParameter("CFMG", m3_CFMG.Trim());

			// Execute the request
			var result = await Execute<LstCompInfoResponse>(
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
		/// Name LstEqInfo
		/// Description Lists user defined content
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_CFMG">Custom field group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEqInfoResponse></returns>
		/// <exception cref="M3Exception<LstEqInfoResponse>"></exception>
		public async Task<M3Response<LstEqInfoResponse>> LstEqInfo(
			string m3_ITNO, 
			string m3_SERN = null, 
			string m3_CFMG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstEqInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFMG))
				request.WithQueryParameter("CFMG", m3_CFMG.Trim());

			// Execute the request
			var result = await Execute<LstEqInfoResponse>(
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
		/// Name LstUdefContent
		/// Description LstUdefContent
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_UDFT">User defined fields - type (Required)</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_GRPI">Group ID</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_ORAD">Origin address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUdefContentResponse></returns>
		/// <exception cref="M3Exception<LstUdefContentResponse>"></exception>
		public async Task<M3Response<LstUdefContentResponse>> LstUdefContent(
			int m3_UDFT, 
			string m3_ITNO = null, 
			string m3_SUNO = null, 
			string m3_AGNB = null, 
			int? m3_GRPI = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			DateTime? m3_FVDT = null, 
			string m3_ORAD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstUdefContent",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("UDFT", m3_UDFT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_GRPI.HasValue)
				request.WithQueryParameter("GRPI", m3_GRPI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ORAD))
				request.WithQueryParameter("ORAD", m3_ORAD.Trim());

			// Execute the request
			var result = await Execute<LstUdefContentResponse>(
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
		/// Name LstUdefFields
		/// Description LstUdefFields
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_UDFT">User defined fields - type (Required)</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_SUCL">Supplier group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUdefFieldsResponse></returns>
		/// <exception cref="M3Exception<LstUdefFieldsResponse>"></exception>
		public async Task<M3Response<LstUdefFieldsResponse>> LstUdefFields(
			int m3_UDFT, 
			string m3_ITGR = null, 
			string m3_SUCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstUdefFields",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("UDFT", m3_UDFT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUCL))
				request.WithQueryParameter("SUCL", m3_SUCL.Trim());

			// Execute the request
			var result = await Execute<LstUdefFieldsResponse>(
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
		/// Name UpdCompInfo
		/// Description Updates user defined content, only for Fashion company
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_CFMA">Custom field - alphanumeric</param>
		/// <param name="m3_CFMN">Custom field - numeric</param>
		/// <param name="m3_CFMD">Custom field - date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCompInfo(
			string m3_ITNO, 
			string m3_CFMG, 
			string m3_CFMF, 
			int m3_SQNR, 
			string m3_CFMA = null, 
			decimal? m3_CFMN = null, 
			DateTime? m3_CFMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCompInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("CFMF", m3_CFMF.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CFMA))
				request.WithQueryParameter("CFMA", m3_CFMA.Trim());
			if (m3_CFMN.HasValue)
				request.WithQueryParameter("CFMN", m3_CFMN.Value.ToString());
			if (m3_CFMD.HasValue)
				request.WithQueryParameter("CFMD", m3_CFMD.Value.ToM3String());

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
		/// Name UpdEqInfo
		/// Description Updates user defined content
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_CFMF">Custom field (Required)</param>
		/// <param name="m3_SQNR">Sequence number (Required)</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_CFMA">Custom field - alphanumeric</param>
		/// <param name="m3_CFMN">Custom field - numeric</param>
		/// <param name="m3_CFMD">Custom field - date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdEqInfo(
			string m3_ITNO, 
			string m3_CFMG, 
			string m3_CFMF, 
			int m3_SQNR, 
			string m3_SERN = null, 
			string m3_CFMA = null, 
			decimal? m3_CFMN = null, 
			DateTime? m3_CFMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdEqInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");
			if (string.IsNullOrWhiteSpace(m3_CFMF))
				throw new ArgumentNullException("m3_CFMF");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CFMG", m3_CFMG.Trim())
				.WithQueryParameter("CFMF", m3_CFMF.Trim())
				.WithQueryParameter("SQNR", m3_SQNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFMA))
				request.WithQueryParameter("CFMA", m3_CFMA.Trim());
			if (m3_CFMN.HasValue)
				request.WithQueryParameter("CFMN", m3_CFMN.Value.ToString());
			if (m3_CFMD.HasValue)
				request.WithQueryParameter("CFMD", m3_CFMD.Value.ToM3String());

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
		/// Name UpdUdefContent
		/// Description UpdUdefContent
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_UDFT">User defined fields - type (Required)</param>
		/// <param name="m3_CFMG">Custom field group (Required)</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SUNO">Supplier numberion</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_GRPI">Group ID</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_CFMF">Custom field</param>
		/// <param name="m3_CFMA">Custom field alpha</param>
		/// <param name="m3_CFMN">Cutom field num</param>
		/// <param name="m3_CFMD">Custom field date</param>
		/// <param name="m3_ORAD">Origin address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdUdefContent(
			int m3_UDFT, 
			string m3_CFMG, 
			string m3_ITNO = null, 
			string m3_SUNO = null, 
			string m3_AGNB = null, 
			int? m3_GRPI = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			DateTime? m3_FVDT = null, 
			string m3_CFMF = null, 
			string m3_CFMA = null, 
			decimal? m3_CFMN = null, 
			DateTime? m3_CFMD = null, 
			string m3_ORAD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdUdefContent",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CFMG))
				throw new ArgumentNullException("m3_CFMG");

			// Set mandatory parameters
			request
				.WithQueryParameter("UDFT", m3_UDFT.ToString())
				.WithQueryParameter("CFMG", m3_CFMG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_GRPI.HasValue)
				request.WithQueryParameter("GRPI", m3_GRPI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CFMF))
				request.WithQueryParameter("CFMF", m3_CFMF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFMA))
				request.WithQueryParameter("CFMA", m3_CFMA.Trim());
			if (m3_CFMN.HasValue)
				request.WithQueryParameter("CFMN", m3_CFMN.Value.ToString());
			if (m3_CFMD.HasValue)
				request.WithQueryParameter("CFMD", m3_CFMD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ORAD))
				request.WithQueryParameter("ORAD", m3_ORAD.Trim());

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
