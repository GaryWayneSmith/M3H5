/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_CONO">Company Number</param>
		/// <param name="m3_OOPT">Option</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_SQNU">Sequence number for sorting</param>
		/// <param name="m3_XCOC">Combination code</param>
		/// <param name="m3_OGRP">Option group</param>
		/// <param name="m3_MTCT">Material category</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			int? m3_CONO = null, 
			string m3_OOPT = null, 
			string m3_TX30 = null, 
			string m3_TX15 = null, 
			int? m3_SQNU = null, 
			int? m3_XCOC = null, 
			string m3_OGRP = null, 
			string m3_MTCT = null, 
			string m3_OPTN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OOPT))
				request.WithQueryParameter("OOPT", m3_OOPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_SQNU.HasValue)
				request.WithQueryParameter("SQNU", m3_SQNU.Value.ToString());
			if (m3_XCOC.HasValue)
				request.WithQueryParameter("XCOC", m3_XCOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OGRP))
				request.WithQueryParameter("OGRP", m3_OGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTCT))
				request.WithQueryParameter("MTCT", m3_MTCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());

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
		/// Name Copy
		/// Description Copy Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company Number</param>
		/// <param name="m3_OOPT">Option</param>
		/// <param name="m3_OCOP">Option</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_OGRP">Option group</param>
		/// <param name="m3_SQNU">Sequence number for sorting</param>
		/// <param name="m3_XCOC">Combination code</param>
		/// <param name="m3_MTCT">Material category</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="m3_COPT">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			int? m3_CONO = null, 
			string m3_OOPT = null, 
			string m3_OCOP = null, 
			string m3_TX30 = null, 
			string m3_TX15 = null, 
			string m3_OGRP = null, 
			int? m3_SQNU = null, 
			int? m3_XCOC = null, 
			string m3_MTCT = null, 
			string m3_OPTN = null, 
			string m3_COPT = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OOPT))
				request.WithQueryParameter("OOPT", m3_OOPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OCOP))
				request.WithQueryParameter("OCOP", m3_OCOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OGRP))
				request.WithQueryParameter("OGRP", m3_OGRP.Trim());
			if (m3_SQNU.HasValue)
				request.WithQueryParameter("SQNU", m3_SQNU.Value.ToString());
			if (m3_XCOC.HasValue)
				request.WithQueryParameter("XCOC", m3_XCOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTCT))
				request.WithQueryParameter("MTCT", m3_MTCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COPT))
				request.WithQueryParameter("COPT", m3_COPT.Trim());

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
		/// Name Delete
		/// Description Delete Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company Number</param>
		/// <param name="m3_OOPT">Option</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			int? m3_CONO = null, 
			string m3_OOPT = null, 
			string m3_OPTN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OOPT))
				request.WithQueryParameter("OOPT", m3_OOPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());

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
		/// Name Get
		/// Description Retrieve Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company Number</param>
		/// <param name="m3_OOPT">Option</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			int? m3_CONO = null, 
			string m3_OOPT = null, 
			string m3_OPTN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OOPT))
				request.WithQueryParameter("OOPT", m3_OOPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name List
		/// Description List Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company Number</param>
		/// <param name="m3_OOPT">Option</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int? m3_CONO = null, 
			string m3_OOPT = null, 
			string m3_OPTN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OOPT))
				request.WithQueryParameter("OOPT", m3_OOPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name LstNameByFeat
		/// Description List names in diff. languages by feature
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_OPTN">Option (Required)</param>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNameByFeatResponse></returns>
		/// <exception cref="M3Exception<LstNameByFeatResponse>"></exception>
		public async Task<M3Response<LstNameByFeatResponse>> LstNameByFeat(
			string m3_OPTN, 
			string m3_FTID, 
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
			if (string.IsNullOrWhiteSpace(m3_OPTN))
				throw new ArgumentNullException("m3_OPTN");
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("OPTN", m3_OPTN.Trim())
				.WithQueryParameter("FTID", m3_FTID.Trim());

			// Execute the request
			var result = await Execute<LstNameByFeatResponse>(
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
		/// Name LstNameLanguage
		/// Description List names in diff. languages
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_OPTN">Option (Required)</param>
		/// <param name="m3_FTID">Feature</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNameLanguageResponse></returns>
		/// <exception cref="M3Exception<LstNameLanguageResponse>"></exception>
		public async Task<M3Response<LstNameLanguageResponse>> LstNameLanguage(
			string m3_OPTN, 
			string m3_FTID = null, 
			string m3_LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_OPTN))
				throw new ArgumentNullException("m3_OPTN");

			// Set mandatory parameters
			request
				.WithQueryParameter("OPTN", m3_OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FTID))
				request.WithQueryParameter("FTID", m3_FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstNameLanguageResponse>(
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
		/// Name Update
		/// Description Update Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company Number</param>
		/// <param name="m3_OOPT">Option</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_SQNU">Sequence number for sorting</param>
		/// <param name="m3_XCOC">Combination code</param>
		/// <param name="m3_OGRP">Option group</param>
		/// <param name="m3_MTCT">Material category</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			int? m3_CONO = null, 
			string m3_OOPT = null, 
			string m3_TX30 = null, 
			string m3_TX15 = null, 
			int? m3_SQNU = null, 
			int? m3_XCOC = null, 
			string m3_OGRP = null, 
			string m3_MTCT = null, 
			string m3_OPTN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OOPT))
				request.WithQueryParameter("OOPT", m3_OOPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_SQNU.HasValue)
				request.WithQueryParameter("SQNU", m3_SQNU.Value.ToString());
			if (m3_XCOC.HasValue)
				request.WithQueryParameter("XCOC", m3_XCOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OGRP))
				request.WithQueryParameter("OGRP", m3_OGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTCT))
				request.WithQueryParameter("MTCT", m3_MTCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());

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
