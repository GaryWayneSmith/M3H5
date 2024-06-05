/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.RPS045MI;
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
	/// Name: RPS045MI
	/// Component Name: PlanningEntity
	/// Description: Planning entity interface
	/// Version Release: 15.1
	///</summary>
	public partial class RPS045MIResource : M3BaseResourceEndpoint
	{
		public RPS045MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "RPS045MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add planning entity
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CCIT">Planning entity (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_TDAT">To date (Required)</param>
		/// <param name="m3_DIME">Distribution method (Required)</param>
		/// <param name="m3_PRSH">Share</param>
		/// <param name="m3_DTFN">Distribution time fence</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_WHLO, 
			string m3_CCIT, 
			DateTime m3_FDAT, 
			DateTime m3_TDAT, 
			string m3_DIME, 
			int? m3_PRSH = null, 
			int? m3_DTFN = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CCIT))
				throw new ArgumentNullException("m3_CCIT");
			if (string.IsNullOrWhiteSpace(m3_DIME))
				throw new ArgumentNullException("m3_DIME");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CCIT", m3_CCIT.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("TDAT", m3_TDAT.ToM3String())
				.WithQueryParameter("DIME", m3_DIME.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PRSH.HasValue)
				request.WithQueryParameter("PRSH", m3_PRSH.Value.ToString());
			if (m3_DTFN.HasValue)
				request.WithQueryParameter("DTFN", m3_DTFN.Value.ToString());

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
		/// Name AddAttribute
		/// Description Add attribute
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CCIT">Planning entity (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddAttributeResponse></returns>
		/// <exception cref="M3Exception<AddAttributeResponse>"></exception>
		public async Task<M3Response<AddAttributeResponse>> AddAttribute(
			string m3_WHLO, 
			string m3_CCIT, 
			DateTime m3_FDAT, 
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CCIT))
				throw new ArgumentNullException("m3_CCIT");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CCIT", m3_CCIT.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<AddAttributeResponse>(
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
		/// Name AddItem
		/// Description Add item
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CCIT">Planning entity (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_NOFR">Normalizing factor (Required)</param>
		/// <param name="m3_PRSH">Share</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItem(
			string m3_WHLO, 
			string m3_CCIT, 
			DateTime m3_FDAT, 
			string m3_ITNO, 
			decimal m3_NOFR, 
			int? m3_PRSH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CCIT))
				throw new ArgumentNullException("m3_CCIT");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CCIT", m3_CCIT.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("NOFR", m3_NOFR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PRSH.HasValue)
				request.WithQueryParameter("PRSH", m3_PRSH.Value.ToString());

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
		/// Name Del
		/// Description Delete planning entity
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CCIT">Planning entity (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3_WHLO, 
			string m3_CCIT, 
			DateTime m3_FDAT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CCIT))
				throw new ArgumentNullException("m3_CCIT");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CCIT", m3_CCIT.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

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
		/// Name DelItem
		/// Description Delete item
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CCIT">Planning entity (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ATNR">Attribute number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelItem(
			string m3_WHLO, 
			string m3_CCIT, 
			DateTime m3_FDAT, 
			string m3_ITNO, 
			decimal m3_ATNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CCIT))
				throw new ArgumentNullException("m3_CCIT");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CCIT", m3_CCIT.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ATNR", m3_ATNR.ToString());

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
		/// Name GenItems
		/// Description Generate items
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CCIT">Planning entity (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_ADRE">Add/replace (Required)</param>
		/// <param name="m3_FITN">Item number</param>
		/// <param name="m3_TITN">Item number</param>
		/// <param name="m3_FITG">Item group</param>
		/// <param name="m3_TITG">Item group</param>
		/// <param name="m3_FITC">Product group</param>
		/// <param name="m3_TITC">Product group</param>
		/// <param name="m3_FRES">Responsible</param>
		/// <param name="m3_TRES">Responsible</param>
		/// <param name="m3_FSTY">Style number</param>
		/// <param name="m3_TSTY">Style number</param>
		/// <param name="m3_CURV">Distribution template</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_FPOP">Alias number</param>
		/// <param name="m3_TPOP">Alias number</param>
		/// <param name="m3_FSTA">Status</param>
		/// <param name="m3_TSTA">Status</param>
		/// <param name="m3_OPTZ">Z-option</param>
		/// <param name="m3_OPTY">Y-option</param>
		/// <param name="m3_OPTX">X-option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GenItemsResponse></returns>
		/// <exception cref="M3Exception<GenItemsResponse>"></exception>
		public async Task<M3Response<GenItemsResponse>> GenItems(
			string m3_WHLO, 
			string m3_CCIT, 
			DateTime m3_FDAT, 
			int m3_ADRE, 
			string m3_FITN = null, 
			string m3_TITN = null, 
			string m3_FITG = null, 
			string m3_TITG = null, 
			string m3_FITC = null, 
			string m3_TITC = null, 
			string m3_FRES = null, 
			string m3_TRES = null, 
			string m3_FSTY = null, 
			string m3_TSTY = null, 
			string m3_CURV = null, 
			int? m3_ALWT = null, 
			string m3_FPOP = null, 
			string m3_TPOP = null, 
			string m3_FSTA = null, 
			string m3_TSTA = null, 
			string m3_OPTZ = null, 
			string m3_OPTY = null, 
			string m3_OPTX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GenItems",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CCIT))
				throw new ArgumentNullException("m3_CCIT");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CCIT", m3_CCIT.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("ADRE", m3_ADRE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FITN))
				request.WithQueryParameter("FITN", m3_FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITN))
				request.WithQueryParameter("TITN", m3_TITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FITG))
				request.WithQueryParameter("FITG", m3_FITG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITG))
				request.WithQueryParameter("TITG", m3_TITG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FITC))
				request.WithQueryParameter("FITC", m3_FITC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITC))
				request.WithQueryParameter("TITC", m3_TITC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRES))
				request.WithQueryParameter("FRES", m3_FRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRES))
				request.WithQueryParameter("TRES", m3_TRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSTY))
				request.WithQueryParameter("FSTY", m3_FSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTY))
				request.WithQueryParameter("TSTY", m3_TSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CURV))
				request.WithQueryParameter("CURV", m3_CURV.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FPOP))
				request.WithQueryParameter("FPOP", m3_FPOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPOP))
				request.WithQueryParameter("TPOP", m3_TPOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSTA))
				request.WithQueryParameter("FSTA", m3_FSTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTA))
				request.WithQueryParameter("TSTA", m3_TSTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTZ))
				request.WithQueryParameter("OPTZ", m3_OPTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTY))
				request.WithQueryParameter("OPTY", m3_OPTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTX))
				request.WithQueryParameter("OPTX", m3_OPTX.Trim());

			// Execute the request
			var result = await Execute<GenItemsResponse>(
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
		/// Description Get planning entity
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CCIT">Planning entity (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_WHLO, 
			string m3_CCIT, 
			DateTime m3_FDAT, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CCIT))
				throw new ArgumentNullException("m3_CCIT");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CCIT", m3_CCIT.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

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
		/// Name GetItem
		/// Description Get item
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CCIT">Planning entity (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ATNR">Attribute number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemResponse></returns>
		/// <exception cref="M3Exception<GetItemResponse>"></exception>
		public async Task<M3Response<GetItemResponse>> GetItem(
			string m3_WHLO, 
			string m3_CCIT, 
			DateTime m3_FDAT, 
			string m3_ITNO, 
			decimal m3_ATNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CCIT))
				throw new ArgumentNullException("m3_CCIT");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CCIT", m3_CCIT.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ATNR", m3_ATNR.ToString());

			// Execute the request
			var result = await Execute<GetItemResponse>(
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
		/// Name Lst
		/// Description List planning entities
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_CCIT">Planning entity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_CCIT = null, 
			string m3_WHLO = null, 
			DateTime? m3_FDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CCIT))
				request.WithQueryParameter("CCIT", m3_CCIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name LstByWarehouse
		/// Description List planning entities for a warehouse
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CCIT">Planning entity</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByWarehouseResponse></returns>
		/// <exception cref="M3Exception<LstByWarehouseResponse>"></exception>
		public async Task<M3Response<LstByWarehouseResponse>> LstByWarehouse(
			string m3_WHLO, 
			string m3_CCIT = null, 
			DateTime? m3_FDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByWarehouse",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CCIT))
				request.WithQueryParameter("CCIT", m3_CCIT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstByWarehouseResponse>(
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
		/// Name LstItems
		/// Description List items
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CCIT">Planning entity (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemsResponse></returns>
		/// <exception cref="M3Exception<LstItemsResponse>"></exception>
		public async Task<M3Response<LstItemsResponse>> LstItems(
			string m3_WHLO, 
			string m3_CCIT, 
			DateTime m3_FDAT, 
			string m3_ITNO = null, 
			decimal? m3_ATNR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItems",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CCIT))
				throw new ArgumentNullException("m3_CCIT");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CCIT", m3_CCIT.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());

			// Execute the request
			var result = await Execute<LstItemsResponse>(
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
		/// Name Upd
		/// Description Update planning entity
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CCIT">Planning entity (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_PRSH">Share</param>
		/// <param name="m3_DIME">Distribution method</param>
		/// <param name="m3_DTFN">Distribution time fence</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_WHLO, 
			string m3_CCIT, 
			DateTime m3_FDAT, 
			DateTime? m3_TDAT = null, 
			int? m3_PRSH = null, 
			string m3_DIME = null, 
			int? m3_DTFN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CCIT))
				throw new ArgumentNullException("m3_CCIT");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CCIT", m3_CCIT.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_PRSH.HasValue)
				request.WithQueryParameter("PRSH", m3_PRSH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIME))
				request.WithQueryParameter("DIME", m3_DIME.Trim());
			if (m3_DTFN.HasValue)
				request.WithQueryParameter("DTFN", m3_DTFN.Value.ToString());

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
		/// Name UpdItem
		/// Description Update item
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CCIT">Planning entity (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ATNR">Attribute number (Required)</param>
		/// <param name="m3_NOFR">Normalizing factor</param>
		/// <param name="m3_PRSH">Share</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItem(
			string m3_WHLO, 
			string m3_CCIT, 
			DateTime m3_FDAT, 
			string m3_ITNO, 
			decimal m3_ATNR, 
			decimal? m3_NOFR = null, 
			int? m3_PRSH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_CCIT))
				throw new ArgumentNullException("m3_CCIT");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("CCIT", m3_CCIT.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ATNR", m3_ATNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_NOFR.HasValue)
				request.WithQueryParameter("NOFR", m3_NOFR.Value.ToString());
			if (m3_PRSH.HasValue)
				request.WithQueryParameter("PRSH", m3_PRSH.Value.ToString());

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
