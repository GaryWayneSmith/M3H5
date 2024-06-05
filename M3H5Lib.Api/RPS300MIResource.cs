/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.RPS300MI;
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
	/// Name: RPS300MI
	/// Component Name: Macro orders
	/// Description: Transfer Macro orders to Fashion Planner
	/// Version Release: 14.x
	///</summary>
	public partial class RPS300MIResource : M3BaseResourceEndpoint
	{
		public RPS300MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "RPS300MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GenDetSevMac
		/// Description Generate detailed for several macro orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FFAC">From Facility</param>
		/// <param name="m3_TFAC">To Facility</param>
		/// <param name="m3_FWHL">From Warehouse</param>
		/// <param name="m3_TWHL">To Warehouse</param>
		/// <param name="m3_FSTS">From Status</param>
		/// <param name="m3_TSTS">To Status</param>
		/// <param name="m3_FSDB">From Bucket start date</param>
		/// <param name="m3_TSDB">To Bucket start date</param>
		/// <param name="m3_FMOP">From Macro order policy</param>
		/// <param name="m3_TMOP">To Macro order policy</param>
		/// <param name="m3_FMOT">From Macro order type</param>
		/// <param name="m3_TMOT">To Macro order type</param>
		/// <param name="m3_FMON">From Macro order number</param>
		/// <param name="m3_TMON">To Macro order number</param>
		/// <param name="m3_RCRT">Recreate</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GenDetSevMacResponse></returns>
		/// <exception cref="M3Exception<GenDetSevMacResponse>"></exception>
		public async Task<M3Response<GenDetSevMacResponse>> GenDetSevMac(
			int? m3_CONO = null, 
			string m3_FFAC = null, 
			string m3_TFAC = null, 
			string m3_FWHL = null, 
			string m3_TWHL = null, 
			string m3_FSTS = null, 
			string m3_TSTS = null, 
			DateTime? m3_FSDB = null, 
			DateTime? m3_TSDB = null, 
			string m3_FMOP = null, 
			string m3_TMOP = null, 
			string m3_FMOT = null, 
			string m3_TMOT = null, 
			string m3_FMON = null, 
			string m3_TMON = null, 
			int? m3_RCRT = null, 
			string m3_WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GenDetSevMac",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FFAC))
				request.WithQueryParameter("FFAC", m3_FFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFAC))
				request.WithQueryParameter("TFAC", m3_TFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWHL))
				request.WithQueryParameter("FWHL", m3_FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHL))
				request.WithQueryParameter("TWHL", m3_TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSTS))
				request.WithQueryParameter("FSTS", m3_FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTS))
				request.WithQueryParameter("TSTS", m3_TSTS.Trim());
			if (m3_FSDB.HasValue)
				request.WithQueryParameter("FSDB", m3_FSDB.Value.ToM3String());
			if (m3_TSDB.HasValue)
				request.WithQueryParameter("TSDB", m3_TSDB.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FMOP))
				request.WithQueryParameter("FMOP", m3_FMOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TMOP))
				request.WithQueryParameter("TMOP", m3_TMOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMOT))
				request.WithQueryParameter("FMOT", m3_FMOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TMOT))
				request.WithQueryParameter("TMOT", m3_TMOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMON))
				request.WithQueryParameter("FMON", m3_FMON.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TMON))
				request.WithQueryParameter("TMON", m3_TMON.Trim());
			if (m3_RCRT.HasValue)
				request.WithQueryParameter("RCRT", m3_RCRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());

			// Execute the request
			var result = await Execute<GenDetSevMacResponse>(
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
		/// Name GetMacroHead
		/// Description Get Macro Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MONO">Macro order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMacroHeadResponse></returns>
		/// <exception cref="M3Exception<GetMacroHeadResponse>"></exception>
		public async Task<M3Response<GetMacroHeadResponse>> GetMacroHead(
			int? m3_CONO = null, 
			string m3_MONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMacroHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MONO))
				request.WithQueryParameter("MONO", m3_MONO.Trim());

			// Execute the request
			var result = await Execute<GetMacroHeadResponse>(
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
		/// Name ListHeader
		/// Description ListHeader
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListHeaderResponse></returns>
		/// <exception cref="M3Exception<ListHeaderResponse>"></exception>
		public async Task<M3Response<ListHeaderResponse>> ListHeader(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListHeader",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<ListHeaderResponse>(
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
		/// Name ListMaterials
		/// Description ListMaterials
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListMaterialsResponse></returns>
		/// <exception cref="M3Exception<ListMaterialsResponse>"></exception>
		public async Task<M3Response<ListMaterialsResponse>> ListMaterials(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListMaterials",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<ListMaterialsResponse>(
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
		/// Name ListOperations
		/// Description ListOperations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListOperationsResponse></returns>
		/// <exception cref="M3Exception<ListOperationsResponse>"></exception>
		public async Task<M3Response<ListOperationsResponse>> ListOperations(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListOperations",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<ListOperationsResponse>(
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
		/// Name SelDetRelByHead
		/// Description Select Detail Relations By Macro Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_STSF">From Status</param>
		/// <param name="m3_STST">To Status</param>
		/// <param name="m3_SDBU">Bucket start date</param>
		/// <param name="m3_EDBU">Bucket end date</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_MONO">Macro order number</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="m3_MOTY">Macro order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDetRelByHeadResponse></returns>
		/// <exception cref="M3Exception<SelDetRelByHeadResponse>"></exception>
		public async Task<M3Response<SelDetRelByHeadResponse>> SelDetRelByHead(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_STSF = null, 
			string m3_STST = null, 
			DateTime? m3_SDBU = null, 
			DateTime? m3_EDBU = null, 
			string m3_WHGR = null, 
			string m3_MONO = null, 
			string m3_APIP = null, 
			string m3_MOTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelDetRelByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STSF))
				request.WithQueryParameter("STSF", m3_STSF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STST))
				request.WithQueryParameter("STST", m3_STST.Trim());
			if (m3_SDBU.HasValue)
				request.WithQueryParameter("SDBU", m3_SDBU.Value.ToM3String());
			if (m3_EDBU.HasValue)
				request.WithQueryParameter("EDBU", m3_EDBU.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MONO))
				request.WithQueryParameter("MONO", m3_MONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MOTY))
				request.WithQueryParameter("MOTY", m3_MOTY.Trim());

			// Execute the request
			var result = await Execute<SelDetRelByHeadResponse>(
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
		/// Name SelMacroHead
		/// Description Select Macro Order Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_STSF">From Status</param>
		/// <param name="m3_STST">To Status</param>
		/// <param name="m3_SDBU">Bucket start date</param>
		/// <param name="m3_EDBU">Bucket end date</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_MONO">Macro order number</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="m3_MOTY">Macro order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMacroHeadResponse></returns>
		/// <exception cref="M3Exception<SelMacroHeadResponse>"></exception>
		public async Task<M3Response<SelMacroHeadResponse>> SelMacroHead(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_STSF = null, 
			string m3_STST = null, 
			DateTime? m3_SDBU = null, 
			DateTime? m3_EDBU = null, 
			string m3_WHGR = null, 
			string m3_MONO = null, 
			string m3_APIP = null, 
			string m3_MOTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelMacroHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STSF))
				request.WithQueryParameter("STSF", m3_STSF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STST))
				request.WithQueryParameter("STST", m3_STST.Trim());
			if (m3_SDBU.HasValue)
				request.WithQueryParameter("SDBU", m3_SDBU.Value.ToM3String());
			if (m3_EDBU.HasValue)
				request.WithQueryParameter("EDBU", m3_EDBU.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MONO))
				request.WithQueryParameter("MONO", m3_MONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MOTY))
				request.WithQueryParameter("MOTY", m3_MOTY.Trim());

			// Execute the request
			var result = await Execute<SelMacroHeadResponse>(
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
		/// Name SelMatByHead
		/// Description Select Materials By Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_STSF">From Status</param>
		/// <param name="m3_STST">To Status</param>
		/// <param name="m3_SDBU">Bucket start date</param>
		/// <param name="m3_EDBU">Bucket end date</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_MONO">Macro order number</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="m3_MOTY">Macro order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMatByHeadResponse></returns>
		/// <exception cref="M3Exception<SelMatByHeadResponse>"></exception>
		public async Task<M3Response<SelMatByHeadResponse>> SelMatByHead(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_STSF = null, 
			string m3_STST = null, 
			DateTime? m3_SDBU = null, 
			DateTime? m3_EDBU = null, 
			string m3_WHGR = null, 
			string m3_MONO = null, 
			string m3_APIP = null, 
			string m3_MOTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelMatByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STSF))
				request.WithQueryParameter("STSF", m3_STSF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STST))
				request.WithQueryParameter("STST", m3_STST.Trim());
			if (m3_SDBU.HasValue)
				request.WithQueryParameter("SDBU", m3_SDBU.Value.ToM3String());
			if (m3_EDBU.HasValue)
				request.WithQueryParameter("EDBU", m3_EDBU.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MONO))
				request.WithQueryParameter("MONO", m3_MONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MOTY))
				request.WithQueryParameter("MOTY", m3_MOTY.Trim());

			// Execute the request
			var result = await Execute<SelMatByHeadResponse>(
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
		/// Name SelOpeByHead
		/// Description Select Operations By Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_STSF">From Status</param>
		/// <param name="m3_STST">To Status</param>
		/// <param name="m3_SDBU">Bucket start date</param>
		/// <param name="m3_EDBU">Bucket end date</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_MONO">Macro order number</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="m3_MOTY">Macro order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOpeByHeadResponse></returns>
		/// <exception cref="M3Exception<SelOpeByHeadResponse>"></exception>
		public async Task<M3Response<SelOpeByHeadResponse>> SelOpeByHead(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_STSF = null, 
			string m3_STST = null, 
			DateTime? m3_SDBU = null, 
			DateTime? m3_EDBU = null, 
			string m3_WHGR = null, 
			string m3_MONO = null, 
			string m3_APIP = null, 
			string m3_MOTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelOpeByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STSF))
				request.WithQueryParameter("STSF", m3_STSF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STST))
				request.WithQueryParameter("STST", m3_STST.Trim());
			if (m3_SDBU.HasValue)
				request.WithQueryParameter("SDBU", m3_SDBU.Value.ToM3String());
			if (m3_EDBU.HasValue)
				request.WithQueryParameter("EDBU", m3_EDBU.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MONO))
				request.WithQueryParameter("MONO", m3_MONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MOTY))
				request.WithQueryParameter("MOTY", m3_MOTY.Trim());

			// Execute the request
			var result = await Execute<SelOpeByHeadResponse>(
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
		/// Name SelOrdRelByHead
		/// Description Select Order Relations By Macro Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_STSF">From Status</param>
		/// <param name="m3_STST">To Status</param>
		/// <param name="m3_SDBU">Bucket start date</param>
		/// <param name="m3_EDBU">Bucket end date</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_MONO">Macro order number</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="m3_MOTY">Macro order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOrdRelByHeadResponse></returns>
		/// <exception cref="M3Exception<SelOrdRelByHeadResponse>"></exception>
		public async Task<M3Response<SelOrdRelByHeadResponse>> SelOrdRelByHead(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_STSF = null, 
			string m3_STST = null, 
			DateTime? m3_SDBU = null, 
			DateTime? m3_EDBU = null, 
			string m3_WHGR = null, 
			string m3_MONO = null, 
			string m3_APIP = null, 
			string m3_MOTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelOrdRelByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STSF))
				request.WithQueryParameter("STSF", m3_STSF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STST))
				request.WithQueryParameter("STST", m3_STST.Trim());
			if (m3_SDBU.HasValue)
				request.WithQueryParameter("SDBU", m3_SDBU.Value.ToM3String());
			if (m3_EDBU.HasValue)
				request.WithQueryParameter("EDBU", m3_EDBU.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MONO))
				request.WithQueryParameter("MONO", m3_MONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MOTY))
				request.WithQueryParameter("MOTY", m3_MOTY.Trim());

			// Execute the request
			var result = await Execute<SelOrdRelByHeadResponse>(
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
