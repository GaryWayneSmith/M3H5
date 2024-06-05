/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ActivateInfoCat
		/// Description Activate Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ActivateInfoCat(
			string m3IBCA, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ActivateInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim());

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
		/// Name AddInfoCat
		/// Description Add a Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3ARLI">Archiving library</param>
		/// <param name="m3UBPG">Used by program</param>
		/// <param name="m3SNDU">Single division used</param>
		/// <param name="m3AGGU">Aggregation used</param>
		/// <param name="m3PRLI">Prevent listing of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddInfoCat(
			string m3IBCA, 
			string m3TX40, 
			string m3TX15 = null, 
			string m3FILE = null, 
			string m3ARLI = null, 
			string m3UBPG = null, 
			int? m3SNDU = null, 
			int? m3AGGU = null, 
			int? m3PRLI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARLI))
				request.WithQueryParameter("ARLI", m3ARLI.Trim());
			if (!string.IsNullOrWhiteSpace(m3UBPG))
				request.WithQueryParameter("UBPG", m3UBPG.Trim());
			if (m3SNDU.HasValue)
				request.WithQueryParameter("SNDU", m3SNDU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGGU.HasValue)
				request.WithQueryParameter("AGGU", m3AGGU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRLI.HasValue)
				request.WithQueryParameter("PRLI", m3PRLI.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CheckSortOption
		/// Description CheckSortOption
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3SOPT">Sorting option (Required)</param>
		/// <param name="m3KEY1">Field</param>
		/// <param name="m3KEY2">Field</param>
		/// <param name="m3KEY3">Field</param>
		/// <param name="m3KEY4">Field</param>
		/// <param name="m3KEY5">Field</param>
		/// <param name="m3KEY6">Field</param>
		/// <param name="m3KEY7">Field</param>
		/// <param name="m3KEY8">Field</param>
		/// <param name="m3KEY9">Field</param>
		/// <param name="m3KE10">Field</param>
		/// <param name="m3KE11">Field</param>
		/// <param name="m3KE12">Field</param>
		/// <param name="m3KE13">Field</param>
		/// <param name="m3KE14">Field</param>
		/// <param name="m3KE15">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CheckSortOption(
			string m3FILE, 
			string m3SOPT, 
			string m3KEY1 = null, 
			string m3KEY2 = null, 
			string m3KEY3 = null, 
			string m3KEY4 = null, 
			string m3KEY5 = null, 
			string m3KEY6 = null, 
			string m3KEY7 = null, 
			string m3KEY8 = null, 
			string m3KEY9 = null, 
			string m3KE10 = null, 
			string m3KE11 = null, 
			string m3KE12 = null, 
			string m3KE13 = null, 
			string m3KE14 = null, 
			string m3KE15 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CheckSortOption",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3SOPT))
				throw new ArgumentNullException(nameof(m3SOPT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("SOPT", m3SOPT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3KEY1))
				request.WithQueryParameter("KEY1", m3KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY2))
				request.WithQueryParameter("KEY2", m3KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY3))
				request.WithQueryParameter("KEY3", m3KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY4))
				request.WithQueryParameter("KEY4", m3KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY5))
				request.WithQueryParameter("KEY5", m3KEY5.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY6))
				request.WithQueryParameter("KEY6", m3KEY6.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY7))
				request.WithQueryParameter("KEY7", m3KEY7.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY8))
				request.WithQueryParameter("KEY8", m3KEY8.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY9))
				request.WithQueryParameter("KEY9", m3KEY9.Trim());
			if (!string.IsNullOrWhiteSpace(m3KE10))
				request.WithQueryParameter("KE10", m3KE10.Trim());
			if (!string.IsNullOrWhiteSpace(m3KE11))
				request.WithQueryParameter("KE11", m3KE11.Trim());
			if (!string.IsNullOrWhiteSpace(m3KE12))
				request.WithQueryParameter("KE12", m3KE12.Trim());
			if (!string.IsNullOrWhiteSpace(m3KE13))
				request.WithQueryParameter("KE13", m3KE13.Trim());
			if (!string.IsNullOrWhiteSpace(m3KE14))
				request.WithQueryParameter("KE14", m3KE14.Trim());
			if (!string.IsNullOrWhiteSpace(m3KE15))
				request.WithQueryParameter("KE15", m3KE15.Trim());

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
		/// Name ChgInfoCat
		/// Description Change Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3ARLI">Archiving library</param>
		/// <param name="m3SNDU">Single division used</param>
		/// <param name="m3AGGU">Aggregation used</param>
		/// <param name="m3PRLI">Prevent listing of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgInfoCat(
			string m3IBCA, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3ARLI = null, 
			int? m3SNDU = null, 
			int? m3AGGU = null, 
			int? m3PRLI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARLI))
				request.WithQueryParameter("ARLI", m3ARLI.Trim());
			if (m3SNDU.HasValue)
				request.WithQueryParameter("SNDU", m3SNDU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGGU.HasValue)
				request.WithQueryParameter("AGGU", m3AGGU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRLI.HasValue)
				request.WithQueryParameter("PRLI", m3PRLI.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DeactivInfoCat
		/// Description Deactivate Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeactivInfoCat(
			string m3IBCA, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeactivInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim());

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
		/// Name DelInfoCat
		/// Description Delete Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelInfoCat(
			string m3IBCA, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim());

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
		/// Name GetInfoCat
		/// Description Get Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInfoCatResponse></returns>
		/// <exception cref="M3Exception<GetInfoCatResponse>"></exception>
		public async Task<M3Response<GetInfoCatResponse>> GetInfoCat(
			string m3IBCA, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim());

			// Execute the request
			var result = await Execute<GetInfoCatResponse>(
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
		/// Name ImportInfoCat
		/// Description Add and activate a Information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3ARLI">Archiving library</param>
		/// <param name="m3UBPG">Used by program</param>
		/// <param name="m3SNDU">Single division used</param>
		/// <param name="m3AGGU">Aggregation used</param>
		/// <param name="m3PRLI">Prevent listing of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ImportInfoCat(
			string m3IBCA, 
			string m3TX40, 
			string m3TX15 = null, 
			string m3FILE = null, 
			string m3ARLI = null, 
			string m3UBPG = null, 
			int? m3SNDU = null, 
			int? m3AGGU = null, 
			int? m3PRLI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ImportInfoCat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARLI))
				request.WithQueryParameter("ARLI", m3ARLI.Trim());
			if (!string.IsNullOrWhiteSpace(m3UBPG))
				request.WithQueryParameter("UBPG", m3UBPG.Trim());
			if (m3SNDU.HasValue)
				request.WithQueryParameter("SNDU", m3SNDU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGGU.HasValue)
				request.WithQueryParameter("AGGU", m3AGGU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRLI.HasValue)
				request.WithQueryParameter("PRLI", m3PRLI.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name LstInfoCat
		/// Description List information browser category
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInfoCatResponse></returns>
		/// <exception cref="M3Exception<LstInfoCatResponse>"></exception>
		public async Task<M3Response<LstInfoCatResponse>> LstInfoCat(
			string m3IBCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInfoCat",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());

			// Execute the request
			var result = await Execute<LstInfoCatResponse>(
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
