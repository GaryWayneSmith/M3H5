/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.ATS010MI;
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
	/// Name: ATS010MI
	/// Component Name: Planning and Manufacturing
	/// Description: Api: Attribute
	/// Version Release: 5e90
	///</summary>
	public partial class ATS010MIResource : M3BaseResourceEndpoint
	{
		public ATS010MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ATS010MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAttrLang
		/// Description This transaction adds attribute  language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3TX30">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAttrLang(
			string m3ATID, 
			string m3LNCD, 
			string m3TX30, 
			string m3TX15 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAttrLang",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));
			if (string.IsNullOrWhiteSpace(m3TX30))
				throw new ArgumentNullException(nameof(m3TX30));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3ATID.Trim())
				.WithQueryParameter("LNCD", m3LNCD.Trim())
				.WithQueryParameter("TX30", m3TX30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());

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
		/// Description This transaction adds attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3ATVC">Attribute type (Required)</param>
		/// <param name="m3TX30">Description (Required)</param>
		/// <param name="m3COBT">Controlling object (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3ATGR">Attribute group</param>
		/// <param name="m3MCAL">Manual change allowed</param>
		/// <param name="m3PRII">Print attribute value</param>
		/// <param name="m3PRFI">Print attribute info</param>
		/// <param name="m3PRNL">Print on new line</param>
		/// <param name="m3PSEP">Print separator</param>
		/// <param name="m3PSPR">Print separator prefix</param>
		/// <param name="m3PSES">Print separator suffix</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3IATT">Item attribute</param>
		/// <param name="m3MUAV">Multiple attribute values</param>
		/// <param name="m3ATCL">Attribute classification</param>
		/// <param name="m3ALBA">Allow blanks</param>
		/// <param name="m3QLCT">Quality controlled</param>
		/// <param name="m3DYCA">Dynamically calculated</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAttribute(
			string m3ATID, 
			string m3ATVC, 
			string m3TX30, 
			int m3COBT, 
			string m3TX15 = null, 
			string m3ATGR = null, 
			int? m3MCAL = null, 
			int? m3PRII = null, 
			int? m3PRFI = null, 
			int? m3PRNL = null, 
			string m3PSEP = null, 
			string m3PSPR = null, 
			string m3PSES = null, 
			string m3UNMS = null, 
			int? m3DCCD = null, 
			int? m3IATT = null, 
			int? m3MUAV = null, 
			int? m3ATCL = null, 
			int? m3ALBA = null, 
			int? m3QLCT = null, 
			int? m3DYCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));
			if (string.IsNullOrWhiteSpace(m3ATVC))
				throw new ArgumentNullException(nameof(m3ATVC));
			if (string.IsNullOrWhiteSpace(m3TX30))
				throw new ArgumentNullException(nameof(m3TX30));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3ATID.Trim())
				.WithQueryParameter("ATVC", m3ATVC.Trim())
				.WithQueryParameter("TX30", m3TX30.Trim())
				.WithQueryParameter("COBT", m3COBT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATGR))
				request.WithQueryParameter("ATGR", m3ATGR.Trim());
			if (m3MCAL.HasValue)
				request.WithQueryParameter("MCAL", m3MCAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRII.HasValue)
				request.WithQueryParameter("PRII", m3PRII.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3PRFI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3PRNL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PSEP))
				request.WithQueryParameter("PSEP", m3PSEP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSPR))
				request.WithQueryParameter("PSPR", m3PSPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSES))
				request.WithQueryParameter("PSES", m3PSES.Trim());
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IATT.HasValue)
				request.WithQueryParameter("IATT", m3IATT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MUAV.HasValue)
				request.WithQueryParameter("MUAV", m3MUAV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATCL.HasValue)
				request.WithQueryParameter("ATCL", m3ATCL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALBA.HasValue)
				request.WithQueryParameter("ALBA", m3ALBA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLCT.HasValue)
				request.WithQueryParameter("QLCT", m3QLCT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DYCA.HasValue)
				request.WithQueryParameter("DYCA", m3DYCA.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelAttrLang
		/// Description This transaction deletes attribute  language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAttrLang(
			string m3ATID, 
			string m3LNCD, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelAttrLang",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3ATID.Trim())
				.WithQueryParameter("LNCD", m3LNCD.Trim());

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
		/// Name DelAttribute
		/// Description This transaction deletes attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAttribute(
			string m3ATID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3ATID.Trim());

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
		/// Name GetAttrLang
		/// Description This transaction displays attribute  language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute ID (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttrLangResponse></returns>
		/// <exception cref="M3Exception<GetAttrLangResponse>"></exception>
		public async Task<M3Response<GetAttrLangResponse>> GetAttrLang(
			string m3ATID, 
			string m3LNCD, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAttrLang",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3ATID.Trim())
				.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetAttrLangResponse>(
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
		/// Name GetAttribute
		/// Description This transaction displays attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttributeResponse></returns>
		/// <exception cref="M3Exception<GetAttributeResponse>"></exception>
		public async Task<M3Response<GetAttributeResponse>> GetAttribute(
			string m3ATID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3ATID.Trim());

			// Execute the request
			var result = await Execute<GetAttributeResponse>(
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
		/// Name LstAttrByDesc
		/// Description This transaction lists attribute ID from description
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TX30">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrByDescResponse></returns>
		/// <exception cref="M3Exception<LstAttrByDescResponse>"></exception>
		public async Task<M3Response<LstAttrByDescResponse>> LstAttrByDesc(
			string m3TX30 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAttrByDesc",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());

			// Execute the request
			var result = await Execute<LstAttrByDescResponse>(
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
		/// Name LstAttrLang
		/// Description This transaction lists attribute  language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute ID (Required)</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrLangResponse></returns>
		/// <exception cref="M3Exception<LstAttrLangResponse>"></exception>
		public async Task<M3Response<LstAttrLangResponse>> LstAttrLang(
			string m3ATID, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAttrLang",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstAttrLangResponse>(
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
		/// Name LstAttribute
		/// Description This transaction lists attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttributeResponse></returns>
		/// <exception cref="M3Exception<LstAttributeResponse>"></exception>
		public async Task<M3Response<LstAttributeResponse>> LstAttribute(
			string m3ATID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAttribute",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());

			// Execute the request
			var result = await Execute<LstAttributeResponse>(
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
		/// Name SelAttributeGrp
		/// Description This transaction selects attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATGR">Attribute group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelAttributeGrpResponse></returns>
		/// <exception cref="M3Exception<SelAttributeGrpResponse>"></exception>
		public async Task<M3Response<SelAttributeGrpResponse>> SelAttributeGrp(
			string m3ATGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelAttributeGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATGR))
				request.WithQueryParameter("ATGR", m3ATGR.Trim());

			// Execute the request
			var result = await Execute<SelAttributeGrpResponse>(
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
		/// Name UpdAttrLang
		/// Description This transaction updates attribute  language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3TX30">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAttrLang(
			string m3ATID, 
			string m3LNCD, 
			string m3TX30 = null, 
			string m3TX15 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAttrLang",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3ATID.Trim())
				.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());

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
		/// Name UpdAttribute
		/// Description This transaction updates attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3TX30">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3ATGR">Attribute group</param>
		/// <param name="m3MCAL">Manual change allowed</param>
		/// <param name="m3PRII">Print attribute value</param>
		/// <param name="m3PRFI">Print attribute info</param>
		/// <param name="m3PRNL">Print on new line</param>
		/// <param name="m3PSEP">Print separator</param>
		/// <param name="m3PSPR">Print separator prefix</param>
		/// <param name="m3PSES">Print separator suffix</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3DCCD">Number of decimal places</param>
		/// <param name="m3ATCL">Attribute classification</param>
		/// <param name="m3ALBA">Allow blanks</param>
		/// <param name="m3DYCA">Dynamically calculated</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAttribute(
			string m3ATID, 
			string m3TX30 = null, 
			string m3TX15 = null, 
			string m3ATGR = null, 
			int? m3MCAL = null, 
			int? m3PRII = null, 
			int? m3PRFI = null, 
			int? m3PRNL = null, 
			string m3PSEP = null, 
			string m3PSPR = null, 
			string m3PSES = null, 
			string m3UNMS = null, 
			int? m3DCCD = null, 
			int? m3ATCL = null, 
			int? m3ALBA = null, 
			int? m3DYCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATGR))
				request.WithQueryParameter("ATGR", m3ATGR.Trim());
			if (m3MCAL.HasValue)
				request.WithQueryParameter("MCAL", m3MCAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRII.HasValue)
				request.WithQueryParameter("PRII", m3PRII.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3PRFI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3PRNL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PSEP))
				request.WithQueryParameter("PSEP", m3PSEP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSPR))
				request.WithQueryParameter("PSPR", m3PSPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSES))
				request.WithQueryParameter("PSES", m3PSES.Trim());
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATCL.HasValue)
				request.WithQueryParameter("ATCL", m3ATCL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALBA.HasValue)
				request.WithQueryParameter("ALBA", m3ALBA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DYCA.HasValue)
				request.WithQueryParameter("DYCA", m3DYCA.Value.ToString(CultureInfo.CurrentCulture));

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
