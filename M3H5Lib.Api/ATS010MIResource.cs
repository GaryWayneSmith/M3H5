/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAttrLang
		/// Description This transaction adds attribute  language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_TX30">Description (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAttrLang(
			string m3_ATID, 
			string m3_LNCD, 
			string m3_TX30, 
			string m3_TX15 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAttrLang",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");
			if (string.IsNullOrWhiteSpace(m3_TX30))
				throw new ArgumentNullException("m3_TX30");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim())
				.WithQueryParameter("LNCD", m3_LNCD.Trim())
				.WithQueryParameter("TX30", m3_TX30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());

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
		/// Description This transaction adds attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_ATVC">Attribute type (Required)</param>
		/// <param name="m3_TX30">Description (Required)</param>
		/// <param name="m3_COBT">Controlling object (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_ATGR">Attribute group</param>
		/// <param name="m3_MCAL">Manual change allowed</param>
		/// <param name="m3_PRII">Print attribute value</param>
		/// <param name="m3_PRFI">Print attribute info</param>
		/// <param name="m3_PRNL">Print on new line</param>
		/// <param name="m3_PSEP">Print separator</param>
		/// <param name="m3_PSPR">Print separator prefix</param>
		/// <param name="m3_PSES">Print separator suffix</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_IATT">Item attribute</param>
		/// <param name="m3_MUAV">Multiple attribute values</param>
		/// <param name="m3_ATCL">Attribute classification</param>
		/// <param name="m3_ALBA">Allow blanks</param>
		/// <param name="m3_QLCT">Quality controlled</param>
		/// <param name="m3_DYCA">Dynamically calculated</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAttribute(
			string m3_ATID, 
			string m3_ATVC, 
			string m3_TX30, 
			int m3_COBT, 
			string m3_TX15 = null, 
			string m3_ATGR = null, 
			int? m3_MCAL = null, 
			int? m3_PRII = null, 
			int? m3_PRFI = null, 
			int? m3_PRNL = null, 
			string m3_PSEP = null, 
			string m3_PSPR = null, 
			string m3_PSES = null, 
			string m3_UNMS = null, 
			int? m3_DCCD = null, 
			int? m3_IATT = null, 
			int? m3_MUAV = null, 
			int? m3_ATCL = null, 
			int? m3_ALBA = null, 
			int? m3_QLCT = null, 
			int? m3_DYCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");
			if (string.IsNullOrWhiteSpace(m3_ATVC))
				throw new ArgumentNullException("m3_ATVC");
			if (string.IsNullOrWhiteSpace(m3_TX30))
				throw new ArgumentNullException("m3_TX30");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim())
				.WithQueryParameter("ATVC", m3_ATVC.Trim())
				.WithQueryParameter("TX30", m3_TX30.Trim())
				.WithQueryParameter("COBT", m3_COBT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATGR))
				request.WithQueryParameter("ATGR", m3_ATGR.Trim());
			if (m3_MCAL.HasValue)
				request.WithQueryParameter("MCAL", m3_MCAL.Value.ToString());
			if (m3_PRII.HasValue)
				request.WithQueryParameter("PRII", m3_PRII.Value.ToString());
			if (m3_PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3_PRFI.Value.ToString());
			if (m3_PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3_PRNL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PSEP))
				request.WithQueryParameter("PSEP", m3_PSEP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSPR))
				request.WithQueryParameter("PSPR", m3_PSPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSES))
				request.WithQueryParameter("PSES", m3_PSES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_IATT.HasValue)
				request.WithQueryParameter("IATT", m3_IATT.Value.ToString());
			if (m3_MUAV.HasValue)
				request.WithQueryParameter("MUAV", m3_MUAV.Value.ToString());
			if (m3_ATCL.HasValue)
				request.WithQueryParameter("ATCL", m3_ATCL.Value.ToString());
			if (m3_ALBA.HasValue)
				request.WithQueryParameter("ALBA", m3_ALBA.Value.ToString());
			if (m3_QLCT.HasValue)
				request.WithQueryParameter("QLCT", m3_QLCT.Value.ToString());
			if (m3_DYCA.HasValue)
				request.WithQueryParameter("DYCA", m3_DYCA.Value.ToString());

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
		/// Name DelAttrLang
		/// Description This transaction deletes attribute  language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAttrLang(
			string m3_ATID, 
			string m3_LNCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAttrLang",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim())
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

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
		/// Name DelAttribute
		/// Description This transaction deletes attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAttribute(
			string m3_ATID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim());

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
		/// Name GetAttrLang
		/// Description This transaction displays attribute  language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute ID (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttrLangResponse></returns>
		/// <exception cref="M3Exception<GetAttrLangResponse>"></exception>
		public async Task<M3Response<GetAttrLangResponse>> GetAttrLang(
			string m3_ATID, 
			string m3_LNCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAttrLang",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim())
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetAttrLangResponse>(
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
		/// Name GetAttribute
		/// Description This transaction displays attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttributeResponse></returns>
		/// <exception cref="M3Exception<GetAttributeResponse>"></exception>
		public async Task<M3Response<GetAttributeResponse>> GetAttribute(
			string m3_ATID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Execute the request
			var result = await Execute<GetAttributeResponse>(
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
		/// Name LstAttrByDesc
		/// Description This transaction lists attribute ID from description
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TX30">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrByDescResponse></returns>
		/// <exception cref="M3Exception<LstAttrByDescResponse>"></exception>
		public async Task<M3Response<LstAttrByDescResponse>> LstAttrByDesc(
			string m3_TX30 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrByDesc",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());

			// Execute the request
			var result = await Execute<LstAttrByDescResponse>(
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
		/// Name LstAttrLang
		/// Description This transaction lists attribute  language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute ID (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrLangResponse></returns>
		/// <exception cref="M3Exception<LstAttrLangResponse>"></exception>
		public async Task<M3Response<LstAttrLangResponse>> LstAttrLang(
			string m3_ATID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrLang",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstAttrLangResponse>(
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
		/// Name LstAttribute
		/// Description This transaction lists attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttributeResponse></returns>
		/// <exception cref="M3Exception<LstAttributeResponse>"></exception>
		public async Task<M3Response<LstAttributeResponse>> LstAttribute(
			string m3_ATID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttribute",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());

			// Execute the request
			var result = await Execute<LstAttributeResponse>(
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
		/// Name SelAttributeGrp
		/// Description This transaction selects attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATGR">Attribute group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelAttributeGrpResponse></returns>
		/// <exception cref="M3Exception<SelAttributeGrpResponse>"></exception>
		public async Task<M3Response<SelAttributeGrpResponse>> SelAttributeGrp(
			string m3_ATGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelAttributeGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATGR))
				request.WithQueryParameter("ATGR", m3_ATGR.Trim());

			// Execute the request
			var result = await Execute<SelAttributeGrpResponse>(
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
		/// Name UpdAttrLang
		/// Description This transaction updates attribute  language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_TX30">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAttrLang(
			string m3_ATID, 
			string m3_LNCD, 
			string m3_TX30 = null, 
			string m3_TX15 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAttrLang",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim())
				.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());

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
		/// Name UpdAttribute
		/// Description This transaction updates attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_TX30">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_ATGR">Attribute group</param>
		/// <param name="m3_MCAL">Manual change allowed</param>
		/// <param name="m3_PRII">Print attribute value</param>
		/// <param name="m3_PRFI">Print attribute info</param>
		/// <param name="m3_PRNL">Print on new line</param>
		/// <param name="m3_PSEP">Print separator</param>
		/// <param name="m3_PSPR">Print separator prefix</param>
		/// <param name="m3_PSES">Print separator suffix</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_DCCD">Number of decimal places</param>
		/// <param name="m3_ATCL">Attribute classification</param>
		/// <param name="m3_ALBA">Allow blanks</param>
		/// <param name="m3_DYCA">Dynamically calculated</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAttribute(
			string m3_ATID, 
			string m3_TX30 = null, 
			string m3_TX15 = null, 
			string m3_ATGR = null, 
			int? m3_MCAL = null, 
			int? m3_PRII = null, 
			int? m3_PRFI = null, 
			int? m3_PRNL = null, 
			string m3_PSEP = null, 
			string m3_PSPR = null, 
			string m3_PSES = null, 
			string m3_UNMS = null, 
			int? m3_DCCD = null, 
			int? m3_ATCL = null, 
			int? m3_ALBA = null, 
			int? m3_DYCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATGR))
				request.WithQueryParameter("ATGR", m3_ATGR.Trim());
			if (m3_MCAL.HasValue)
				request.WithQueryParameter("MCAL", m3_MCAL.Value.ToString());
			if (m3_PRII.HasValue)
				request.WithQueryParameter("PRII", m3_PRII.Value.ToString());
			if (m3_PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3_PRFI.Value.ToString());
			if (m3_PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3_PRNL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PSEP))
				request.WithQueryParameter("PSEP", m3_PSEP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSPR))
				request.WithQueryParameter("PSPR", m3_PSPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSES))
				request.WithQueryParameter("PSES", m3_PSES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_ATCL.HasValue)
				request.WithQueryParameter("ATCL", m3_ATCL.Value.ToString());
			if (m3_ALBA.HasValue)
				request.WithQueryParameter("ALBA", m3_ALBA.Value.ToString());
			if (m3_DYCA.HasValue)
				request.WithQueryParameter("DYCA", m3_DYCA.Value.ToString());

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
