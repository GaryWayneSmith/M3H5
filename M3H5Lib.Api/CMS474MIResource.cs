/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CFMG">Custom field group (Required)</param>
		/// <param name="m3CFMF">Custom field (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3CFMA">Custom field - alphanumeric</param>
		/// <param name="m3CFMN">Custom field - numeric</param>
		/// <param name="m3CFMD">Custom field - date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCompInfo(
			string m3ITNO, 
			string m3CFMG, 
			string m3CFMF, 
			int m3SQNR, 
			string m3CFMA = null, 
			decimal? m3CFMN = null, 
			DateTime? m3CFMD = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CFMG))
				throw new ArgumentNullException(nameof(m3CFMG));
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CFMG", m3CFMG.Trim())
				.WithQueryParameter("CFMF", m3CFMF.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CFMA))
				request.WithQueryParameter("CFMA", m3CFMA.Trim());
			if (m3CFMN.HasValue)
				request.WithQueryParameter("CFMN", m3CFMN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFMD.HasValue)
				request.WithQueryParameter("CFMD", m3CFMD.Value.ToM3String());

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
		/// Name AddEqInfo
		/// Description Adds user defined content
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CFMG">Custom field group (Required)</param>
		/// <param name="m3CFMF">Custom field (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3CFMA">Custom field - alphanumeric</param>
		/// <param name="m3CFMN">Custom field - numeric</param>
		/// <param name="m3CFMD">Custom field - date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEqInfo(
			string m3ITNO, 
			string m3CFMG, 
			string m3CFMF, 
			int m3SQNR, 
			string m3SERN = null, 
			string m3CFMA = null, 
			decimal? m3CFMN = null, 
			DateTime? m3CFMD = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CFMG))
				throw new ArgumentNullException(nameof(m3CFMG));
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CFMG", m3CFMG.Trim())
				.WithQueryParameter("CFMF", m3CFMF.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFMA))
				request.WithQueryParameter("CFMA", m3CFMA.Trim());
			if (m3CFMN.HasValue)
				request.WithQueryParameter("CFMN", m3CFMN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFMD.HasValue)
				request.WithQueryParameter("CFMD", m3CFMD.Value.ToM3String());

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
		/// Name DltCompInfo
		/// Description Delete user defined content, only for Fashion company
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CFMG">Custom field group (Required)</param>
		/// <param name="m3CFMF">Custom field (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCompInfo(
			string m3ITNO, 
			string m3CFMG, 
			string m3CFMF, 
			int m3SQNR, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CFMG))
				throw new ArgumentNullException(nameof(m3CFMG));
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CFMG", m3CFMG.Trim())
				.WithQueryParameter("CFMF", m3CFMF.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltEqInfo
		/// Description Delete user defined content
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CFMG">Custom field group (Required)</param>
		/// <param name="m3CFMF">Custom field (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltEqInfo(
			string m3ITNO, 
			string m3CFMG, 
			string m3CFMF, 
			int m3SQNR, 
			string m3SERN = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CFMG))
				throw new ArgumentNullException(nameof(m3CFMG));
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CFMG", m3CFMG.Trim())
				.WithQueryParameter("CFMF", m3CFMF.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());

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
		/// Name GetCompInfo
		/// Description Get user defined content, only for Fashion company
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CFMG">Custom field group (Required)</param>
		/// <param name="m3CFMF">Custom field (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCompInfoResponse></returns>
		/// <exception cref="M3Exception<GetCompInfoResponse>"></exception>
		public async Task<M3Response<GetCompInfoResponse>> GetCompInfo(
			string m3ITNO, 
			string m3CFMG, 
			string m3CFMF, 
			int m3SQNR, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CFMG))
				throw new ArgumentNullException(nameof(m3CFMG));
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CFMG", m3CFMG.Trim())
				.WithQueryParameter("CFMF", m3CFMF.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetCompInfoResponse>(
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
		/// Name GetEqInfo
		/// Description Get user defined content
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CFMG">Custom field group (Required)</param>
		/// <param name="m3CFMF">Custom field (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEqInfoResponse></returns>
		/// <exception cref="M3Exception<GetEqInfoResponse>"></exception>
		public async Task<M3Response<GetEqInfoResponse>> GetEqInfo(
			string m3ITNO, 
			string m3CFMG, 
			string m3CFMF, 
			int m3SQNR, 
			string m3SERN = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CFMG))
				throw new ArgumentNullException(nameof(m3CFMG));
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CFMG", m3CFMG.Trim())
				.WithQueryParameter("CFMF", m3CFMF.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());

			// Execute the request
			var result = await Execute<GetEqInfoResponse>(
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
		/// Name GetUdefContent
		/// Description GetUdefContent
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3UDFT">User defined fields - type (Required)</param>
		/// <param name="m3CFMG">Field group (Required)</param>
		/// <param name="m3CFMF">Field (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3GRPI">Group ID</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3ORAD">Origin address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUdefContentResponse></returns>
		/// <exception cref="M3Exception<GetUdefContentResponse>"></exception>
		public async Task<M3Response<GetUdefContentResponse>> GetUdefContent(
			string m3UDFT, 
			string m3CFMG, 
			string m3CFMF, 
			string m3ITNO = null, 
			string m3SUNO = null, 
			string m3AGNB = null, 
			int? m3GRPI = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			DateTime? m3FVDT = null, 
			string m3ORAD = null, 
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
			if (string.IsNullOrWhiteSpace(m3UDFT))
				throw new ArgumentNullException(nameof(m3UDFT));
			if (string.IsNullOrWhiteSpace(m3CFMG))
				throw new ArgumentNullException(nameof(m3CFMG));
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));

			// Set mandatory parameters
			request
				.WithQueryParameter("UDFT", m3UDFT.Trim())
				.WithQueryParameter("CFMG", m3CFMG.Trim())
				.WithQueryParameter("CFMF", m3CFMF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (m3GRPI.HasValue)
				request.WithQueryParameter("GRPI", m3GRPI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ORAD))
				request.WithQueryParameter("ORAD", m3ORAD.Trim());

			// Execute the request
			var result = await Execute<GetUdefContentResponse>(
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
		/// Name LstCompInfo
		/// Description Lists user defined content, only for Fashion company
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CFMG">Custom field group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCompInfoResponse></returns>
		/// <exception cref="M3Exception<LstCompInfoResponse>"></exception>
		public async Task<M3Response<LstCompInfoResponse>> LstCompInfo(
			string m3ITNO, 
			string m3CFMG = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CFMG))
				request.WithQueryParameter("CFMG", m3CFMG.Trim());

			// Execute the request
			var result = await Execute<LstCompInfoResponse>(
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
		/// Name LstEqInfo
		/// Description Lists user defined content
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3CFMG">Custom field group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEqInfoResponse></returns>
		/// <exception cref="M3Exception<LstEqInfoResponse>"></exception>
		public async Task<M3Response<LstEqInfoResponse>> LstEqInfo(
			string m3ITNO, 
			string m3SERN = null, 
			string m3CFMG = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFMG))
				request.WithQueryParameter("CFMG", m3CFMG.Trim());

			// Execute the request
			var result = await Execute<LstEqInfoResponse>(
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
		/// Name LstUdefContent
		/// Description LstUdefContent
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3UDFT">User defined fields - type (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3GRPI">Group ID</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3ORAD">Origin address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUdefContentResponse></returns>
		/// <exception cref="M3Exception<LstUdefContentResponse>"></exception>
		public async Task<M3Response<LstUdefContentResponse>> LstUdefContent(
			int m3UDFT, 
			string m3ITNO = null, 
			string m3SUNO = null, 
			string m3AGNB = null, 
			int? m3GRPI = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			DateTime? m3FVDT = null, 
			string m3ORAD = null, 
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
				.WithQueryParameter("UDFT", m3UDFT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (m3GRPI.HasValue)
				request.WithQueryParameter("GRPI", m3GRPI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ORAD))
				request.WithQueryParameter("ORAD", m3ORAD.Trim());

			// Execute the request
			var result = await Execute<LstUdefContentResponse>(
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
		/// Name LstUdefFields
		/// Description LstUdefFields
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3UDFT">User defined fields - type (Required)</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3SUCL">Supplier group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUdefFieldsResponse></returns>
		/// <exception cref="M3Exception<LstUdefFieldsResponse>"></exception>
		public async Task<M3Response<LstUdefFieldsResponse>> LstUdefFields(
			int m3UDFT, 
			string m3ITGR = null, 
			string m3SUCL = null, 
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
				.WithQueryParameter("UDFT", m3UDFT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUCL))
				request.WithQueryParameter("SUCL", m3SUCL.Trim());

			// Execute the request
			var result = await Execute<LstUdefFieldsResponse>(
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
		/// Name UpdCompInfo
		/// Description Updates user defined content, only for Fashion company
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CFMG">Custom field group (Required)</param>
		/// <param name="m3CFMF">Custom field (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3CFMA">Custom field - alphanumeric</param>
		/// <param name="m3CFMN">Custom field - numeric</param>
		/// <param name="m3CFMD">Custom field - date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCompInfo(
			string m3ITNO, 
			string m3CFMG, 
			string m3CFMF, 
			int m3SQNR, 
			string m3CFMA = null, 
			decimal? m3CFMN = null, 
			DateTime? m3CFMD = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CFMG))
				throw new ArgumentNullException(nameof(m3CFMG));
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CFMG", m3CFMG.Trim())
				.WithQueryParameter("CFMF", m3CFMF.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CFMA))
				request.WithQueryParameter("CFMA", m3CFMA.Trim());
			if (m3CFMN.HasValue)
				request.WithQueryParameter("CFMN", m3CFMN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFMD.HasValue)
				request.WithQueryParameter("CFMD", m3CFMD.Value.ToM3String());

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
		/// Name UpdEqInfo
		/// Description Updates user defined content
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CFMG">Custom field group (Required)</param>
		/// <param name="m3CFMF">Custom field (Required)</param>
		/// <param name="m3SQNR">Sequence number (Required)</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3CFMA">Custom field - alphanumeric</param>
		/// <param name="m3CFMN">Custom field - numeric</param>
		/// <param name="m3CFMD">Custom field - date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdEqInfo(
			string m3ITNO, 
			string m3CFMG, 
			string m3CFMF, 
			int m3SQNR, 
			string m3SERN = null, 
			string m3CFMA = null, 
			decimal? m3CFMN = null, 
			DateTime? m3CFMD = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CFMG))
				throw new ArgumentNullException(nameof(m3CFMG));
			if (string.IsNullOrWhiteSpace(m3CFMF))
				throw new ArgumentNullException(nameof(m3CFMF));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CFMG", m3CFMG.Trim())
				.WithQueryParameter("CFMF", m3CFMF.Trim())
				.WithQueryParameter("SQNR", m3SQNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFMA))
				request.WithQueryParameter("CFMA", m3CFMA.Trim());
			if (m3CFMN.HasValue)
				request.WithQueryParameter("CFMN", m3CFMN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFMD.HasValue)
				request.WithQueryParameter("CFMD", m3CFMD.Value.ToM3String());

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
		/// Name UpdUdefContent
		/// Description UpdUdefContent
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3UDFT">User defined fields - type (Required)</param>
		/// <param name="m3CFMG">Custom field group (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SUNO">Supplier numberion</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3GRPI">Group ID</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3CFMF">Custom field</param>
		/// <param name="m3CFMA">Custom field alpha</param>
		/// <param name="m3CFMN">Cutom field num</param>
		/// <param name="m3CFMD">Custom field date</param>
		/// <param name="m3ORAD">Origin address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdUdefContent(
			int m3UDFT, 
			string m3CFMG, 
			string m3ITNO = null, 
			string m3SUNO = null, 
			string m3AGNB = null, 
			int? m3GRPI = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			DateTime? m3FVDT = null, 
			string m3CFMF = null, 
			string m3CFMA = null, 
			decimal? m3CFMN = null, 
			DateTime? m3CFMD = null, 
			string m3ORAD = null, 
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
			if (string.IsNullOrWhiteSpace(m3CFMG))
				throw new ArgumentNullException(nameof(m3CFMG));

			// Set mandatory parameters
			request
				.WithQueryParameter("UDFT", m3UDFT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CFMG", m3CFMG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (m3GRPI.HasValue)
				request.WithQueryParameter("GRPI", m3GRPI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CFMF))
				request.WithQueryParameter("CFMF", m3CFMF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFMA))
				request.WithQueryParameter("CFMA", m3CFMA.Trim());
			if (m3CFMN.HasValue)
				request.WithQueryParameter("CFMN", m3CFMN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFMD.HasValue)
				request.WithQueryParameter("CFMD", m3CFMD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ORAD))
				request.WithQueryParameter("ORAD", m3ORAD.Trim());

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
