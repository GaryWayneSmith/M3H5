/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add planning entity
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CCIT">Planning entity (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3TDAT">To date (Required)</param>
		/// <param name="m3DIME">Distribution method (Required)</param>
		/// <param name="m3PRSH">Share</param>
		/// <param name="m3DTFN">Distribution time fence</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3WHLO, 
			string m3CCIT, 
			DateTime m3FDAT, 
			DateTime m3TDAT, 
			string m3DIME, 
			int? m3PRSH = null, 
			int? m3DTFN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CCIT))
				throw new ArgumentNullException(nameof(m3CCIT));
			if (string.IsNullOrWhiteSpace(m3DIME))
				throw new ArgumentNullException(nameof(m3DIME));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CCIT", m3CCIT.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("TDAT", m3TDAT.ToM3String())
				.WithQueryParameter("DIME", m3DIME.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PRSH.HasValue)
				request.WithQueryParameter("PRSH", m3PRSH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTFN.HasValue)
				request.WithQueryParameter("DTFN", m3DTFN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddAttribute
		/// Description Add attribute
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CCIT">Planning entity (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddAttributeResponse></returns>
		/// <exception cref="M3Exception<AddAttributeResponse>"></exception>
		public async Task<M3Response<AddAttributeResponse>> AddAttribute(
			string m3WHLO, 
			string m3CCIT, 
			DateTime m3FDAT, 
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CCIT))
				throw new ArgumentNullException(nameof(m3CCIT));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CCIT", m3CCIT.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<AddAttributeResponse>(
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
		/// Name AddItem
		/// Description Add item
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CCIT">Planning entity (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3NOFR">Normalizing factor (Required)</param>
		/// <param name="m3PRSH">Share</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItem(
			string m3WHLO, 
			string m3CCIT, 
			DateTime m3FDAT, 
			string m3ITNO, 
			decimal m3NOFR, 
			int? m3PRSH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CCIT))
				throw new ArgumentNullException(nameof(m3CCIT));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CCIT", m3CCIT.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("NOFR", m3NOFR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PRSH.HasValue)
				request.WithQueryParameter("PRSH", m3PRSH.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Del
		/// Description Delete planning entity
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CCIT">Planning entity (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3WHLO, 
			string m3CCIT, 
			DateTime m3FDAT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CCIT))
				throw new ArgumentNullException(nameof(m3CCIT));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CCIT", m3CCIT.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

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
		/// Name DelItem
		/// Description Delete item
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CCIT">Planning entity (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ATNR">Attribute number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelItem(
			string m3WHLO, 
			string m3CCIT, 
			DateTime m3FDAT, 
			string m3ITNO, 
			decimal m3ATNR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CCIT))
				throw new ArgumentNullException(nameof(m3CCIT));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CCIT", m3CCIT.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ATNR", m3ATNR.ToString(CultureInfo.CurrentCulture));

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
		/// Name GenItems
		/// Description Generate items
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CCIT">Planning entity (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3ADRE">Add/replace (Required)</param>
		/// <param name="m3FITN">Item number</param>
		/// <param name="m3TITN">Item number</param>
		/// <param name="m3FITG">Item group</param>
		/// <param name="m3TITG">Item group</param>
		/// <param name="m3FITC">Product group</param>
		/// <param name="m3TITC">Product group</param>
		/// <param name="m3FRES">Responsible</param>
		/// <param name="m3TRES">Responsible</param>
		/// <param name="m3FSTY">Style number</param>
		/// <param name="m3TSTY">Style number</param>
		/// <param name="m3CURV">Distribution template</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3FPOP">Alias number</param>
		/// <param name="m3TPOP">Alias number</param>
		/// <param name="m3FSTA">Status</param>
		/// <param name="m3TSTA">Status</param>
		/// <param name="m3OPTZ">Z-option</param>
		/// <param name="m3OPTY">Y-option</param>
		/// <param name="m3OPTX">X-option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GenItemsResponse></returns>
		/// <exception cref="M3Exception<GenItemsResponse>"></exception>
		public async Task<M3Response<GenItemsResponse>> GenItems(
			string m3WHLO, 
			string m3CCIT, 
			DateTime m3FDAT, 
			int m3ADRE, 
			string m3FITN = null, 
			string m3TITN = null, 
			string m3FITG = null, 
			string m3TITG = null, 
			string m3FITC = null, 
			string m3TITC = null, 
			string m3FRES = null, 
			string m3TRES = null, 
			string m3FSTY = null, 
			string m3TSTY = null, 
			string m3CURV = null, 
			int? m3ALWT = null, 
			string m3FPOP = null, 
			string m3TPOP = null, 
			string m3FSTA = null, 
			string m3TSTA = null, 
			string m3OPTZ = null, 
			string m3OPTY = null, 
			string m3OPTX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GenItems",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CCIT))
				throw new ArgumentNullException(nameof(m3CCIT));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CCIT", m3CCIT.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("ADRE", m3ADRE.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FITN))
				request.WithQueryParameter("FITN", m3FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITN))
				request.WithQueryParameter("TITN", m3TITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FITG))
				request.WithQueryParameter("FITG", m3FITG.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITG))
				request.WithQueryParameter("TITG", m3TITG.Trim());
			if (!string.IsNullOrWhiteSpace(m3FITC))
				request.WithQueryParameter("FITC", m3FITC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITC))
				request.WithQueryParameter("TITC", m3TITC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRES))
				request.WithQueryParameter("FRES", m3FRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRES))
				request.WithQueryParameter("TRES", m3TRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSTY))
				request.WithQueryParameter("FSTY", m3FSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTY))
				request.WithQueryParameter("TSTY", m3TSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CURV))
				request.WithQueryParameter("CURV", m3CURV.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FPOP))
				request.WithQueryParameter("FPOP", m3FPOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPOP))
				request.WithQueryParameter("TPOP", m3TPOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSTA))
				request.WithQueryParameter("FSTA", m3FSTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTA))
				request.WithQueryParameter("TSTA", m3TSTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTZ))
				request.WithQueryParameter("OPTZ", m3OPTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTY))
				request.WithQueryParameter("OPTY", m3OPTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTX))
				request.WithQueryParameter("OPTX", m3OPTX.Trim());

			// Execute the request
			var result = await Execute<GenItemsResponse>(
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
		/// Description Get planning entity
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CCIT">Planning entity (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3WHLO, 
			string m3CCIT, 
			DateTime m3FDAT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CCIT))
				throw new ArgumentNullException(nameof(m3CCIT));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CCIT", m3CCIT.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

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
		/// Name GetItem
		/// Description Get item
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CCIT">Planning entity (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ATNR">Attribute number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemResponse></returns>
		/// <exception cref="M3Exception<GetItemResponse>"></exception>
		public async Task<M3Response<GetItemResponse>> GetItem(
			string m3WHLO, 
			string m3CCIT, 
			DateTime m3FDAT, 
			string m3ITNO, 
			decimal m3ATNR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CCIT))
				throw new ArgumentNullException(nameof(m3CCIT));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CCIT", m3CCIT.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ATNR", m3ATNR.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetItemResponse>(
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
		/// Name Lst
		/// Description List planning entities
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3CCIT">Planning entity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3CCIT = null, 
			string m3WHLO = null, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CCIT))
				request.WithQueryParameter("CCIT", m3CCIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name LstByWarehouse
		/// Description List planning entities for a warehouse
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CCIT">Planning entity</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByWarehouseResponse></returns>
		/// <exception cref="M3Exception<LstByWarehouseResponse>"></exception>
		public async Task<M3Response<LstByWarehouseResponse>> LstByWarehouse(
			string m3WHLO, 
			string m3CCIT = null, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByWarehouse",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CCIT))
				request.WithQueryParameter("CCIT", m3CCIT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstByWarehouseResponse>(
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
		/// Name LstItems
		/// Description List items
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CCIT">Planning entity (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemsResponse></returns>
		/// <exception cref="M3Exception<LstItemsResponse>"></exception>
		public async Task<M3Response<LstItemsResponse>> LstItems(
			string m3WHLO, 
			string m3CCIT, 
			DateTime m3FDAT, 
			string m3ITNO = null, 
			decimal? m3ATNR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItems",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CCIT))
				throw new ArgumentNullException(nameof(m3CCIT));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CCIT", m3CCIT.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstItemsResponse>(
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
		/// Name Upd
		/// Description Update planning entity
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CCIT">Planning entity (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3PRSH">Share</param>
		/// <param name="m3DIME">Distribution method</param>
		/// <param name="m3DTFN">Distribution time fence</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3WHLO, 
			string m3CCIT, 
			DateTime m3FDAT, 
			DateTime? m3TDAT = null, 
			int? m3PRSH = null, 
			string m3DIME = null, 
			int? m3DTFN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CCIT))
				throw new ArgumentNullException(nameof(m3CCIT));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CCIT", m3CCIT.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3PRSH.HasValue)
				request.WithQueryParameter("PRSH", m3PRSH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIME))
				request.WithQueryParameter("DIME", m3DIME.Trim());
			if (m3DTFN.HasValue)
				request.WithQueryParameter("DTFN", m3DTFN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdItem
		/// Description Update item
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CCIT">Planning entity (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ATNR">Attribute number (Required)</param>
		/// <param name="m3NOFR">Normalizing factor</param>
		/// <param name="m3PRSH">Share</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItem(
			string m3WHLO, 
			string m3CCIT, 
			DateTime m3FDAT, 
			string m3ITNO, 
			decimal m3ATNR, 
			decimal? m3NOFR = null, 
			int? m3PRSH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3CCIT))
				throw new ArgumentNullException(nameof(m3CCIT));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("CCIT", m3CCIT.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ATNR", m3ATNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3NOFR.HasValue)
				request.WithQueryParameter("NOFR", m3NOFR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRSH.HasValue)
				request.WithQueryParameter("PRSH", m3PRSH.Value.ToString(CultureInfo.CurrentCulture));

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
