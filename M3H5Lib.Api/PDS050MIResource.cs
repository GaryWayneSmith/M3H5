/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.PDS050MI;
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
	/// Name: PDS050MI
	/// Component Name: ProductOption
	/// Description: Product option interface
	/// Version Release: 5ea1
	///</summary>
	public partial class PDS050MIResource : M3BaseResourceEndpoint
	{
		public PDS050MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS050MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Create Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3OOPT">Option</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3SQNU">Sequence number for sorting</param>
		/// <param name="m3XCOC">Combination code</param>
		/// <param name="m3OGRP">Option group</param>
		/// <param name="m3MTCT">Material category</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			int? m3CONO = null, 
			string m3OOPT = null, 
			string m3TX30 = null, 
			string m3TX15 = null, 
			int? m3SQNU = null, 
			int? m3XCOC = null, 
			string m3OGRP = null, 
			string m3MTCT = null, 
			string m3OPTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OOPT))
				request.WithQueryParameter("OOPT", m3OOPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3SQNU.HasValue)
				request.WithQueryParameter("SQNU", m3SQNU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3XCOC.HasValue)
				request.WithQueryParameter("XCOC", m3XCOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OGRP))
				request.WithQueryParameter("OGRP", m3OGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTCT))
				request.WithQueryParameter("MTCT", m3MTCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());

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
		/// Name Copy
		/// Description Copy Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3OOPT">Option</param>
		/// <param name="m3OCOP">Option</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3OGRP">Option group</param>
		/// <param name="m3SQNU">Sequence number for sorting</param>
		/// <param name="m3XCOC">Combination code</param>
		/// <param name="m3MTCT">Material category</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="m3COPT">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			int? m3CONO = null, 
			string m3OOPT = null, 
			string m3OCOP = null, 
			string m3TX30 = null, 
			string m3TX15 = null, 
			string m3OGRP = null, 
			int? m3SQNU = null, 
			int? m3XCOC = null, 
			string m3MTCT = null, 
			string m3OPTN = null, 
			string m3COPT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Copy",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OOPT))
				request.WithQueryParameter("OOPT", m3OOPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OCOP))
				request.WithQueryParameter("OCOP", m3OCOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3OGRP))
				request.WithQueryParameter("OGRP", m3OGRP.Trim());
			if (m3SQNU.HasValue)
				request.WithQueryParameter("SQNU", m3SQNU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3XCOC.HasValue)
				request.WithQueryParameter("XCOC", m3XCOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTCT))
				request.WithQueryParameter("MTCT", m3MTCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3COPT))
				request.WithQueryParameter("COPT", m3COPT.Trim());

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
		/// Name Delete
		/// Description Delete Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3OOPT">Option</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			int? m3CONO = null, 
			string m3OOPT = null, 
			string m3OPTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OOPT))
				request.WithQueryParameter("OOPT", m3OOPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());

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
		/// Name Get
		/// Description Retrieve Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3OOPT">Option</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			int? m3CONO = null, 
			string m3OOPT = null, 
			string m3OPTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OOPT))
				request.WithQueryParameter("OOPT", m3OOPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name List
		/// Description List Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3OOPT">Option</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int? m3CONO = null, 
			string m3OOPT = null, 
			string m3OPTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OOPT))
				request.WithQueryParameter("OOPT", m3OOPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name LstNameByFeat
		/// Description List names in diff. languages by feature
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3OPTN">Option (Required)</param>
		/// <param name="m3FTID">Feature (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNameByFeatResponse></returns>
		/// <exception cref="M3Exception<LstNameByFeatResponse>"></exception>
		public async Task<M3Response<LstNameByFeatResponse>> LstNameByFeat(
			string m3OPTN, 
			string m3FTID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNameByFeat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OPTN))
				throw new ArgumentNullException(nameof(m3OPTN));
			if (string.IsNullOrWhiteSpace(m3FTID))
				throw new ArgumentNullException(nameof(m3FTID));

			// Set mandatory parameters
			request
				.WithQueryParameter("OPTN", m3OPTN.Trim())
				.WithQueryParameter("FTID", m3FTID.Trim());

			// Execute the request
			var result = await Execute<LstNameByFeatResponse>(
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
		/// Name LstNameLanguage
		/// Description List names in diff. languages
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3OPTN">Option (Required)</param>
		/// <param name="m3FTID">Feature</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNameLanguageResponse></returns>
		/// <exception cref="M3Exception<LstNameLanguageResponse>"></exception>
		public async Task<M3Response<LstNameLanguageResponse>> LstNameLanguage(
			string m3OPTN, 
			string m3FTID = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNameLanguage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3OPTN))
				throw new ArgumentNullException(nameof(m3OPTN));

			// Set mandatory parameters
			request
				.WithQueryParameter("OPTN", m3OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FTID))
				request.WithQueryParameter("FTID", m3FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstNameLanguageResponse>(
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
		/// Name Update
		/// Description Update Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3OOPT">Option</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3SQNU">Sequence number for sorting</param>
		/// <param name="m3XCOC">Combination code</param>
		/// <param name="m3OGRP">Option group</param>
		/// <param name="m3MTCT">Material category</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			int? m3CONO = null, 
			string m3OOPT = null, 
			string m3TX30 = null, 
			string m3TX15 = null, 
			int? m3SQNU = null, 
			int? m3XCOC = null, 
			string m3OGRP = null, 
			string m3MTCT = null, 
			string m3OPTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Update",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OOPT))
				request.WithQueryParameter("OOPT", m3OOPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3SQNU.HasValue)
				request.WithQueryParameter("SQNU", m3SQNU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3XCOC.HasValue)
				request.WithQueryParameter("XCOC", m3XCOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OGRP))
				request.WithQueryParameter("OGRP", m3OGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTCT))
				request.WithQueryParameter("MTCT", m3MTCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());

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
