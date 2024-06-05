/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.ATS101MI;
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
	/// Name: ATS101MI
	/// Component Name: Attributeinformation
	/// Description: Attribute information interface
	/// Version Release: 5ea2
	///</summary>
	public partial class ATS101MIResource : M3BaseResourceEndpoint
	{
		public ATS101MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ATS101MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAttr
		/// Description Set or change attribute values
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_AALF">From attribute value</param>
		/// <param name="m3_AALT">To attribute value</param>
		/// <param name="m3_ATAV">Target value</param>
		/// <param name="m3_ATVA">Attribute value</param>
		/// <param name="m3_RGDT">Registrationdate</param>
		/// <param name="m3_RGTM">Registration time</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_AVSQ">Attribute value sequence number</param>
		/// <param name="m3_ATCI">Attachment indicator</param>
		/// <param name="m3_SHIP">Shipless indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAttr(
			int? m3_CONO = null, 
			decimal? m3_ATNR = null, 
			string m3_ATID = null, 
			string m3_AALF = null, 
			string m3_AALT = null, 
			string m3_ATAV = null, 
			string m3_ATVA = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			int? m3_SIMD = null, 
			int? m3_AVSQ = null, 
			int? m3_ATCI = null, 
			int? m3_SHIP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAttr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AALF))
				request.WithQueryParameter("AALF", m3_AALF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AALT))
				request.WithQueryParameter("AALT", m3_AALT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATAV))
				request.WithQueryParameter("ATAV", m3_ATAV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATVA))
				request.WithQueryParameter("ATVA", m3_ATVA.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3_AVSQ.Value.ToString());
			if (m3_ATCI.HasValue)
				request.WithQueryParameter("ATCI", m3_ATCI.Value.ToString());
			if (m3_SHIP.HasValue)
				request.WithQueryParameter("SHIP", m3_SHIP.Value.ToString());

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
		/// Name CalcSettlement
		/// Description CalcSettlement
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CalcSettlement(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CalcSettlement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());

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
		/// Name DltAttr
		/// Description Set or change attribute values
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_RGDT">Registration date</param>
		/// <param name="m3_RGTM">Registration time</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_AVSQ">Attribute value sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAttr(
			int? m3_CONO = null, 
			decimal? m3_ATNR = null, 
			string m3_ATID = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			int? m3_SIMD = null, 
			int? m3_AVSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAttr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3_AVSQ.Value.ToString());

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
		/// Name GetAttributes
		/// Description Get attributes
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ATNR">Attribute number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ATNB">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttributesResponse></returns>
		/// <exception cref="M3Exception<GetAttributesResponse>"></exception>
		public async Task<M3Response<GetAttributesResponse>> GetAttributes(
			decimal m3_ATNR, 
			int? m3_CONO = null, 
			decimal? m3_ATNB = null, 
			int? m3_SIMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAttributes",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ATNR", m3_ATNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3_ATNB.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());

			// Execute the request
			var result = await Execute<GetAttributesResponse>(
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
		/// Name LstAttrByRef
		/// Description List attributes by reference
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_LSTB">List selected attributes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrByRefResponse></returns>
		/// <exception cref="M3Exception<LstAttrByRefResponse>"></exception>
		public async Task<M3Response<LstAttrByRefResponse>> LstAttrByRef(
			int? m3_CONO = null, 
			string m3_ORCA = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			int? m3_LSTB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrByRef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_LSTB.HasValue)
				request.WithQueryParameter("LSTB", m3_LSTB.Value.ToString());

			// Execute the request
			var result = await Execute<LstAttrByRefResponse>(
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
		/// Name LstAttrPrompt
		/// Description List attributes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_ATNB">Attribute number</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrPromptResponse></returns>
		/// <exception cref="M3Exception<LstAttrPromptResponse>"></exception>
		public async Task<M3Response<LstAttrPromptResponse>> LstAttrPrompt(
			int? m3_CONO = null, 
			string m3_ATID = null, 
			string m3_ITNO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_ATMO = null, 
			string m3_ORCA = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			decimal? m3_ATNR = null, 
			decimal? m3_ATNB = null, 
			string m3_LNCD = null, 
			int? m3_SIMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrPrompt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3_ATNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());

			// Execute the request
			var result = await Execute<LstAttrPromptResponse>(
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
		/// Name LstAttrTrans
		/// Description List Attribute Transaction
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_ATNR">Attribute number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_RGDT">Entry date</param>
		/// <param name="m3_RGTM">Entry time</param>
		/// <param name="m3_TMSX">Time suffix</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="m3_AVSQ">Attribute value sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrTransResponse></returns>
		/// <exception cref="M3Exception<LstAttrTransResponse>"></exception>
		public async Task<M3Response<LstAttrTransResponse>> LstAttrTrans(
			decimal m3_ATNR, 
			int? m3_CONO = null, 
			string m3_ATID = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			int? m3_TMSX = null, 
			int? m3_ANSQ = null, 
			int? m3_AVSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrTrans",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ATNR", m3_ATNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_TMSX.HasValue)
				request.WithQueryParameter("TMSX", m3_TMSX.Value.ToString());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());
			if (m3_AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3_AVSQ.Value.ToString());

			// Execute the request
			var result = await Execute<LstAttrTransResponse>(
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
		/// Name LstAttributes
		/// Description List attributes
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_ATNB">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_LSTB">List selected attributes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttributesResponse></returns>
		/// <exception cref="M3Exception<LstAttributesResponse>"></exception>
		public async Task<M3Response<LstAttributesResponse>> LstAttributes(
			int? m3_CONO = null, 
			decimal? m3_ATNR = null, 
			decimal? m3_ATNB = null, 
			int? m3_SIMD = null, 
			int? m3_LSTB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttributes",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3_ATNB.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_LSTB.HasValue)
				request.WithQueryParameter("LSTB", m3_LSTB.Value.ToString());

			// Execute the request
			var result = await Execute<LstAttributesResponse>(
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
		/// Name LstErrAttr
		/// Description List Error attributes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrAttrResponse></returns>
		/// <exception cref="M3Exception<LstErrAttrResponse>"></exception>
		public async Task<M3Response<LstErrAttrResponse>> LstErrAttr(
			int? m3_CONO = null, 
			decimal? m3_ATNR = null, 
			int? m3_SIMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstErrAttr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());

			// Execute the request
			var result = await Execute<LstErrAttrResponse>(
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
		/// Name LstItemATID
		/// Description List relation by Ordernumber
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_AALF">From attribute value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemATIDResponse></returns>
		/// <exception cref="M3Exception<LstItemATIDResponse>"></exception>
		public async Task<M3Response<LstItemATIDResponse>> LstItemATID(
			int m3_CONO, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_AALF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItemATID",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AALF))
				request.WithQueryParameter("AALF", m3_AALF.Trim());

			// Execute the request
			var result = await Execute<LstItemATIDResponse>(
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
		/// Name LstRelByATNR
		/// Description List Relation By attribute Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_ATNR">Attribute number (Required)</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_AVSQ">Attribute value sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelByATNRResponse></returns>
		/// <exception cref="M3Exception<LstRelByATNRResponse>"></exception>
		public async Task<M3Response<LstRelByATNRResponse>> LstRelByATNR(
			int m3_CONO, 
			decimal m3_ATNR, 
			string m3_ATID = null, 
			int? m3_AVSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRelByATNR",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("ATNR", m3_ATNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (m3_AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3_AVSQ.Value.ToString());

			// Execute the request
			var result = await Execute<LstRelByATNRResponse>(
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
		/// Name LstRelByOrder
		/// Description List relation by Ordernumber
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_ORCA">Order category (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelByOrderResponse></returns>
		/// <exception cref="M3Exception<LstRelByOrderResponse>"></exception>
		public async Task<M3Response<LstRelByOrderResponse>> LstRelByOrder(
			int m3_CONO, 
			string m3_ORCA, 
			string m3_RIDN, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRelByOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORCA))
				throw new ArgumentNullException("m3_ORCA");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("ORCA", m3_ORCA.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());

			// Execute the request
			var result = await Execute<LstRelByOrderResponse>(
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
		/// Name SetAttrValue
		/// Description Set or change attribute values
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_AALF">From attribute value</param>
		/// <param name="m3_AALT">To attribute value</param>
		/// <param name="m3_ATAV">Target value</param>
		/// <param name="m3_ATVA">Attribute value</param>
		/// <param name="m3_RGDT">Registrationdate</param>
		/// <param name="m3_RGTM">Registration time</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_AVSQ">Attribute value sequence number</param>
		/// <param name="m3_ATCI">Attachment indicator</param>
		/// <param name="m3_SHIP">Shipless indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetAttrValue(
			int? m3_CONO = null, 
			decimal? m3_ATNR = null, 
			string m3_ATID = null, 
			string m3_AALF = null, 
			string m3_AALT = null, 
			string m3_ATAV = null, 
			string m3_ATVA = null, 
			DateTime? m3_RGDT = null, 
			int? m3_RGTM = null, 
			int? m3_SIMD = null, 
			int? m3_AVSQ = null, 
			int? m3_ATCI = null, 
			int? m3_SHIP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetAttrValue",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AALF))
				request.WithQueryParameter("AALF", m3_AALF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AALT))
				request.WithQueryParameter("AALT", m3_AALT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATAV))
				request.WithQueryParameter("ATAV", m3_ATAV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATVA))
				request.WithQueryParameter("ATVA", m3_ATVA.Trim());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3_RGTM.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3_AVSQ.Value.ToString());
			if (m3_ATCI.HasValue)
				request.WithQueryParameter("ATCI", m3_ATCI.Value.ToString());
			if (m3_SHIP.HasValue)
				request.WithQueryParameter("SHIP", m3_SHIP.Value.ToString());

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
