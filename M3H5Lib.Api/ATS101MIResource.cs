/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3AALF">From attribute value</param>
		/// <param name="m3AALT">To attribute value</param>
		/// <param name="m3ATAV">Target value</param>
		/// <param name="m3ATVA">Attribute value</param>
		/// <param name="m3RGDT">Registrationdate</param>
		/// <param name="m3RGTM">Registration time</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3AVSQ">Attribute value sequence number</param>
		/// <param name="m3ATCI">Attachment indicator</param>
		/// <param name="m3SHIP">Shipless indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAttr(
			int? m3CONO = null, 
			decimal? m3ATNR = null, 
			string m3ATID = null, 
			string m3AALF = null, 
			string m3AALT = null, 
			string m3ATAV = null, 
			string m3ATVA = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			int? m3SIMD = null, 
			int? m3AVSQ = null, 
			int? m3ATCI = null, 
			int? m3SHIP = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3AALF))
				request.WithQueryParameter("AALF", m3AALF.Trim());
			if (!string.IsNullOrWhiteSpace(m3AALT))
				request.WithQueryParameter("AALT", m3AALT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATAV))
				request.WithQueryParameter("ATAV", m3ATAV.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATVA))
				request.WithQueryParameter("ATVA", m3ATVA.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3AVSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATCI.HasValue)
				request.WithQueryParameter("ATCI", m3ATCI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHIP.HasValue)
				request.WithQueryParameter("SHIP", m3SHIP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CalcSettlement
		/// Description CalcSettlement
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CalcSettlement(
			int? m3CONO = null, 
			decimal? m3ATNR = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltAttr
		/// Description Set or change attribute values
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3RGDT">Registration date</param>
		/// <param name="m3RGTM">Registration time</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3AVSQ">Attribute value sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAttr(
			int? m3CONO = null, 
			decimal? m3ATNR = null, 
			string m3ATID = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			int? m3SIMD = null, 
			int? m3AVSQ = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3AVSQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetAttributes
		/// Description Get attributes
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ATNR">Attribute number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ATNB">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttributesResponse></returns>
		/// <exception cref="M3Exception<GetAttributesResponse>"></exception>
		public async Task<M3Response<GetAttributesResponse>> GetAttributes(
			decimal m3ATNR, 
			int? m3CONO = null, 
			decimal? m3ATNB = null, 
			int? m3SIMD = null, 
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
				.WithQueryParameter("ATNR", m3ATNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3ATNB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAttributesResponse>(
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
		/// Name LstAttrByRef
		/// Description List attributes by reference
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3LSTB">List selected attributes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrByRefResponse></returns>
		/// <exception cref="M3Exception<LstAttrByRefResponse>"></exception>
		public async Task<M3Response<LstAttrByRefResponse>> LstAttrByRef(
			int? m3CONO = null, 
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			int? m3LSTB = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LSTB.HasValue)
				request.WithQueryParameter("LSTB", m3LSTB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAttrByRefResponse>(
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
		/// Name LstAttrPrompt
		/// Description List attributes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3ATNB">Attribute number</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrPromptResponse></returns>
		/// <exception cref="M3Exception<LstAttrPromptResponse>"></exception>
		public async Task<M3Response<LstAttrPromptResponse>> LstAttrPrompt(
			int? m3CONO = null, 
			string m3ATID = null, 
			string m3ITNO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3ATMO = null, 
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			decimal? m3ATNR = null, 
			decimal? m3ATNB = null, 
			string m3LNCD = null, 
			int? m3SIMD = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3ATNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAttrPromptResponse>(
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
		/// Name LstAttrTrans
		/// Description List Attribute Transaction
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3ATNR">Attribute number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3RGDT">Entry date</param>
		/// <param name="m3RGTM">Entry time</param>
		/// <param name="m3TMSX">Time suffix</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="m3AVSQ">Attribute value sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrTransResponse></returns>
		/// <exception cref="M3Exception<LstAttrTransResponse>"></exception>
		public async Task<M3Response<LstAttrTransResponse>> LstAttrTrans(
			decimal m3ATNR, 
			int? m3CONO = null, 
			string m3ATID = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			int? m3TMSX = null, 
			int? m3ANSQ = null, 
			int? m3AVSQ = null, 
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
				.WithQueryParameter("ATNR", m3ATNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TMSX.HasValue)
				request.WithQueryParameter("TMSX", m3TMSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3AVSQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAttrTransResponse>(
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
		/// Name LstAttributes
		/// Description List attributes
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3ATNB">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3LSTB">List selected attributes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttributesResponse></returns>
		/// <exception cref="M3Exception<LstAttributesResponse>"></exception>
		public async Task<M3Response<LstAttributesResponse>> LstAttributes(
			int? m3CONO = null, 
			decimal? m3ATNR = null, 
			decimal? m3ATNB = null, 
			int? m3SIMD = null, 
			int? m3LSTB = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3ATNB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LSTB.HasValue)
				request.WithQueryParameter("LSTB", m3LSTB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAttributesResponse>(
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
		/// Name LstErrAttr
		/// Description List Error attributes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrAttrResponse></returns>
		/// <exception cref="M3Exception<LstErrAttrResponse>"></exception>
		public async Task<M3Response<LstErrAttrResponse>> LstErrAttr(
			int? m3CONO = null, 
			decimal? m3ATNR = null, 
			int? m3SIMD = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstErrAttrResponse>(
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
		/// Name LstItemATID
		/// Description List relation by Ordernumber
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3AALF">From attribute value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemATIDResponse></returns>
		/// <exception cref="M3Exception<LstItemATIDResponse>"></exception>
		public async Task<M3Response<LstItemATIDResponse>> LstItemATID(
			int m3CONO, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3AALF = null, 
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
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AALF))
				request.WithQueryParameter("AALF", m3AALF.Trim());

			// Execute the request
			var result = await Execute<LstItemATIDResponse>(
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
		/// Name LstRelByATNR
		/// Description List Relation By attribute Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3ATNR">Attribute number (Required)</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3AVSQ">Attribute value sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelByATNRResponse></returns>
		/// <exception cref="M3Exception<LstRelByATNRResponse>"></exception>
		public async Task<M3Response<LstRelByATNRResponse>> LstRelByATNR(
			int m3CONO, 
			decimal m3ATNR, 
			string m3ATID = null, 
			int? m3AVSQ = null, 
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
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ATNR", m3ATNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (m3AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3AVSQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstRelByATNRResponse>(
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
		/// Name LstRelByOrder
		/// Description List relation by Ordernumber
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3ORCA">Order category (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelByOrderResponse></returns>
		/// <exception cref="M3Exception<LstRelByOrderResponse>"></exception>
		public async Task<M3Response<LstRelByOrderResponse>> LstRelByOrder(
			int m3CONO, 
			string m3ORCA, 
			string m3RIDN, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
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
			if (string.IsNullOrWhiteSpace(m3ORCA))
				throw new ArgumentNullException(nameof(m3ORCA));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORCA", m3ORCA.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstRelByOrderResponse>(
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
		/// Name SetAttrValue
		/// Description Set or change attribute values
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3AALF">From attribute value</param>
		/// <param name="m3AALT">To attribute value</param>
		/// <param name="m3ATAV">Target value</param>
		/// <param name="m3ATVA">Attribute value</param>
		/// <param name="m3RGDT">Registrationdate</param>
		/// <param name="m3RGTM">Registration time</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3AVSQ">Attribute value sequence number</param>
		/// <param name="m3ATCI">Attachment indicator</param>
		/// <param name="m3SHIP">Shipless indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetAttrValue(
			int? m3CONO = null, 
			decimal? m3ATNR = null, 
			string m3ATID = null, 
			string m3AALF = null, 
			string m3AALT = null, 
			string m3ATAV = null, 
			string m3ATVA = null, 
			DateTime? m3RGDT = null, 
			int? m3RGTM = null, 
			int? m3SIMD = null, 
			int? m3AVSQ = null, 
			int? m3ATCI = null, 
			int? m3SHIP = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3AALF))
				request.WithQueryParameter("AALF", m3AALF.Trim());
			if (!string.IsNullOrWhiteSpace(m3AALT))
				request.WithQueryParameter("AALT", m3AALT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATAV))
				request.WithQueryParameter("ATAV", m3ATAV.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATVA))
				request.WithQueryParameter("ATVA", m3ATVA.Trim());
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3RGTM.HasValue)
				request.WithQueryParameter("RGTM", m3RGTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3AVSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATCI.HasValue)
				request.WithQueryParameter("ATCI", m3ATCI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHIP.HasValue)
				request.WithQueryParameter("SHIP", m3SHIP.Value.ToString(CultureInfo.CurrentCulture));

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
