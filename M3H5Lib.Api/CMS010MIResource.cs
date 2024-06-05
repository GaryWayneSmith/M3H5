/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS010MI;
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
	/// Name: CMS010MI
	/// Component Name: CMS010
	/// Description: Api:Information Browser category
	/// Version Release: 5e90
	///</summary>
	public partial class CMS010MIResource : M3BaseResourceEndpoint
	{
		public CMS010MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS010MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ActivateInfoCat
		/// Description Activate Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ActivateInfoCat(
			string m3_IBCA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ActivateInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim());

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
		/// Name AddInfoCat
		/// Description Add a Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_ARLI">Archiving library</param>
		/// <param name="m3_UBPG">Used by program</param>
		/// <param name="m3_SNDU">Single division used</param>
		/// <param name="m3_AGGU">Aggregation used</param>
		/// <param name="m3_PRLI">Prevent listing of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInfoCat(
			string m3_IBCA, 
			string m3_TX40, 
			string m3_TX15 = null, 
			string m3_FILE = null, 
			string m3_ARLI = null, 
			string m3_UBPG = null, 
			int? m3_SNDU = null, 
			int? m3_AGGU = null, 
			int? m3_PRLI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARLI))
				request.WithQueryParameter("ARLI", m3_ARLI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UBPG))
				request.WithQueryParameter("UBPG", m3_UBPG.Trim());
			if (m3_SNDU.HasValue)
				request.WithQueryParameter("SNDU", m3_SNDU.Value.ToString());
			if (m3_AGGU.HasValue)
				request.WithQueryParameter("AGGU", m3_AGGU.Value.ToString());
			if (m3_PRLI.HasValue)
				request.WithQueryParameter("PRLI", m3_PRLI.Value.ToString());

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
		/// Name CheckSortOption
		/// Description CheckSortOption
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_SOPT">Sorting option (Required)</param>
		/// <param name="m3_KEY1">Field</param>
		/// <param name="m3_KEY2">Field</param>
		/// <param name="m3_KEY3">Field</param>
		/// <param name="m3_KEY4">Field</param>
		/// <param name="m3_KEY5">Field</param>
		/// <param name="m3_KEY6">Field</param>
		/// <param name="m3_KEY7">Field</param>
		/// <param name="m3_KEY8">Field</param>
		/// <param name="m3_KEY9">Field</param>
		/// <param name="m3_KE10">Field</param>
		/// <param name="m3_KE11">Field</param>
		/// <param name="m3_KE12">Field</param>
		/// <param name="m3_KE13">Field</param>
		/// <param name="m3_KE14">Field</param>
		/// <param name="m3_KE15">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CheckSortOption(
			string m3_FILE, 
			string m3_SOPT, 
			string m3_KEY1 = null, 
			string m3_KEY2 = null, 
			string m3_KEY3 = null, 
			string m3_KEY4 = null, 
			string m3_KEY5 = null, 
			string m3_KEY6 = null, 
			string m3_KEY7 = null, 
			string m3_KEY8 = null, 
			string m3_KEY9 = null, 
			string m3_KE10 = null, 
			string m3_KE11 = null, 
			string m3_KE12 = null, 
			string m3_KE13 = null, 
			string m3_KE14 = null, 
			string m3_KE15 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CheckSortOption",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_SOPT))
				throw new ArgumentNullException("m3_SOPT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("SOPT", m3_SOPT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_KEY1))
				request.WithQueryParameter("KEY1", m3_KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY2))
				request.WithQueryParameter("KEY2", m3_KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY3))
				request.WithQueryParameter("KEY3", m3_KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY4))
				request.WithQueryParameter("KEY4", m3_KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY5))
				request.WithQueryParameter("KEY5", m3_KEY5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY6))
				request.WithQueryParameter("KEY6", m3_KEY6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY7))
				request.WithQueryParameter("KEY7", m3_KEY7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY8))
				request.WithQueryParameter("KEY8", m3_KEY8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY9))
				request.WithQueryParameter("KEY9", m3_KEY9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KE10))
				request.WithQueryParameter("KE10", m3_KE10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KE11))
				request.WithQueryParameter("KE11", m3_KE11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KE12))
				request.WithQueryParameter("KE12", m3_KE12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KE13))
				request.WithQueryParameter("KE13", m3_KE13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KE14))
				request.WithQueryParameter("KE14", m3_KE14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KE15))
				request.WithQueryParameter("KE15", m3_KE15.Trim());

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
		/// Name ChgInfoCat
		/// Description Change Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_ARLI">Archiving library</param>
		/// <param name="m3_SNDU">Single division used</param>
		/// <param name="m3_AGGU">Aggregation used</param>
		/// <param name="m3_PRLI">Prevent listing of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgInfoCat(
			string m3_IBCA, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_ARLI = null, 
			int? m3_SNDU = null, 
			int? m3_AGGU = null, 
			int? m3_PRLI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARLI))
				request.WithQueryParameter("ARLI", m3_ARLI.Trim());
			if (m3_SNDU.HasValue)
				request.WithQueryParameter("SNDU", m3_SNDU.Value.ToString());
			if (m3_AGGU.HasValue)
				request.WithQueryParameter("AGGU", m3_AGGU.Value.ToString());
			if (m3_PRLI.HasValue)
				request.WithQueryParameter("PRLI", m3_PRLI.Value.ToString());

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
		/// Name DeactivInfoCat
		/// Description Deactivate Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeactivInfoCat(
			string m3_IBCA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeactivInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim());

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
		/// Name DelInfoCat
		/// Description Delete Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelInfoCat(
			string m3_IBCA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim());

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
		/// Name GetInfoCat
		/// Description Get Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInfoCatResponse></returns>
		/// <exception cref="M3Exception<GetInfoCatResponse>"></exception>
		public async Task<M3Response<GetInfoCatResponse>> GetInfoCat(
			string m3_IBCA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim());

			// Execute the request
			var result = await Execute<GetInfoCatResponse>(
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
		/// Name ImportInfoCat
		/// Description Add and activate a Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_ARLI">Archiving library</param>
		/// <param name="m3_UBPG">Used by program</param>
		/// <param name="m3_SNDU">Single division used</param>
		/// <param name="m3_AGGU">Aggregation used</param>
		/// <param name="m3_PRLI">Prevent listing of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ImportInfoCat(
			string m3_IBCA, 
			string m3_TX40, 
			string m3_TX15 = null, 
			string m3_FILE = null, 
			string m3_ARLI = null, 
			string m3_UBPG = null, 
			int? m3_SNDU = null, 
			int? m3_AGGU = null, 
			int? m3_PRLI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ImportInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARLI))
				request.WithQueryParameter("ARLI", m3_ARLI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UBPG))
				request.WithQueryParameter("UBPG", m3_UBPG.Trim());
			if (m3_SNDU.HasValue)
				request.WithQueryParameter("SNDU", m3_SNDU.Value.ToString());
			if (m3_AGGU.HasValue)
				request.WithQueryParameter("AGGU", m3_AGGU.Value.ToString());
			if (m3_PRLI.HasValue)
				request.WithQueryParameter("PRLI", m3_PRLI.Value.ToString());

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
		/// Name LstInfoCat
		/// Description List information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInfoCatResponse></returns>
		/// <exception cref="M3Exception<LstInfoCatResponse>"></exception>
		public async Task<M3Response<LstInfoCatResponse>> LstInfoCat(
			string m3_IBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInfoCat",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());

			// Execute the request
			var result = await Execute<LstInfoCatResponse>(
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
