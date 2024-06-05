/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GenDetSevMac
		/// Description Generate detailed for several macro orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FFAC">From Facility</param>
		/// <param name="m3TFAC">To Facility</param>
		/// <param name="m3FWHL">From Warehouse</param>
		/// <param name="m3TWHL">To Warehouse</param>
		/// <param name="m3FSTS">From Status</param>
		/// <param name="m3TSTS">To Status</param>
		/// <param name="m3FSDB">From Bucket start date</param>
		/// <param name="m3TSDB">To Bucket start date</param>
		/// <param name="m3FMOP">From Macro order policy</param>
		/// <param name="m3TMOP">To Macro order policy</param>
		/// <param name="m3FMOT">From Macro order type</param>
		/// <param name="m3TMOT">To Macro order type</param>
		/// <param name="m3FMON">From Macro order number</param>
		/// <param name="m3TMON">To Macro order number</param>
		/// <param name="m3RCRT">Recreate</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GenDetSevMacResponse></returns>
		/// <exception cref="M3Exception<GenDetSevMacResponse>"></exception>
		public async Task<M3Response<GenDetSevMacResponse>> GenDetSevMac(
			int? m3CONO = null, 
			string m3FFAC = null, 
			string m3TFAC = null, 
			string m3FWHL = null, 
			string m3TWHL = null, 
			string m3FSTS = null, 
			string m3TSTS = null, 
			DateTime? m3FSDB = null, 
			DateTime? m3TSDB = null, 
			string m3FMOP = null, 
			string m3TMOP = null, 
			string m3FMOT = null, 
			string m3TMOT = null, 
			string m3FMON = null, 
			string m3TMON = null, 
			int? m3RCRT = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GenDetSevMac",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FFAC))
				request.WithQueryParameter("FFAC", m3FFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFAC))
				request.WithQueryParameter("TFAC", m3TFAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHL))
				request.WithQueryParameter("TWHL", m3TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSTS))
				request.WithQueryParameter("FSTS", m3FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTS))
				request.WithQueryParameter("TSTS", m3TSTS.Trim());
			if (m3FSDB.HasValue)
				request.WithQueryParameter("FSDB", m3FSDB.Value.ToM3String());
			if (m3TSDB.HasValue)
				request.WithQueryParameter("TSDB", m3TSDB.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FMOP))
				request.WithQueryParameter("FMOP", m3FMOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TMOP))
				request.WithQueryParameter("TMOP", m3TMOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMOT))
				request.WithQueryParameter("FMOT", m3FMOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TMOT))
				request.WithQueryParameter("TMOT", m3TMOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMON))
				request.WithQueryParameter("FMON", m3FMON.Trim());
			if (!string.IsNullOrWhiteSpace(m3TMON))
				request.WithQueryParameter("TMON", m3TMON.Trim());
			if (m3RCRT.HasValue)
				request.WithQueryParameter("RCRT", m3RCRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Execute the request
			var result = await Execute<GenDetSevMacResponse>(
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
		/// Name GetMacroHead
		/// Description Get Macro Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MONO">Macro order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMacroHeadResponse></returns>
		/// <exception cref="M3Exception<GetMacroHeadResponse>"></exception>
		public async Task<M3Response<GetMacroHeadResponse>> GetMacroHead(
			int? m3CONO = null, 
			string m3MONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMacroHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MONO))
				request.WithQueryParameter("MONO", m3MONO.Trim());

			// Execute the request
			var result = await Execute<GetMacroHeadResponse>(
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
		/// Name ListHeader
		/// Description ListHeader
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListHeaderResponse></returns>
		/// <exception cref="M3Exception<ListHeaderResponse>"></exception>
		public async Task<M3Response<ListHeaderResponse>> ListHeader(
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListHeader",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListHeaderResponse>(
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
		/// Name ListMaterials
		/// Description ListMaterials
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListMaterialsResponse></returns>
		/// <exception cref="M3Exception<ListMaterialsResponse>"></exception>
		public async Task<M3Response<ListMaterialsResponse>> ListMaterials(
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListMaterials",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListMaterialsResponse>(
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
		/// Name ListOperations
		/// Description ListOperations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListOperationsResponse></returns>
		/// <exception cref="M3Exception<ListOperationsResponse>"></exception>
		public async Task<M3Response<ListOperationsResponse>> ListOperations(
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListOperations",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListOperationsResponse>(
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
		/// Name SelDetRelByHead
		/// Description Select Detail Relations By Macro Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3STSF">From Status</param>
		/// <param name="m3STST">To Status</param>
		/// <param name="m3SDBU">Bucket start date</param>
		/// <param name="m3EDBU">Bucket end date</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3MONO">Macro order number</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="m3MOTY">Macro order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDetRelByHeadResponse></returns>
		/// <exception cref="M3Exception<SelDetRelByHeadResponse>"></exception>
		public async Task<M3Response<SelDetRelByHeadResponse>> SelDetRelByHead(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3STSF = null, 
			string m3STST = null, 
			DateTime? m3SDBU = null, 
			DateTime? m3EDBU = null, 
			string m3WHGR = null, 
			string m3MONO = null, 
			string m3APIP = null, 
			string m3MOTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelDetRelByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STSF))
				request.WithQueryParameter("STSF", m3STSF.Trim());
			if (!string.IsNullOrWhiteSpace(m3STST))
				request.WithQueryParameter("STST", m3STST.Trim());
			if (m3SDBU.HasValue)
				request.WithQueryParameter("SDBU", m3SDBU.Value.ToM3String());
			if (m3EDBU.HasValue)
				request.WithQueryParameter("EDBU", m3EDBU.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MONO))
				request.WithQueryParameter("MONO", m3MONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MOTY))
				request.WithQueryParameter("MOTY", m3MOTY.Trim());

			// Execute the request
			var result = await Execute<SelDetRelByHeadResponse>(
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
		/// Name SelMacroHead
		/// Description Select Macro Order Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3STSF">From Status</param>
		/// <param name="m3STST">To Status</param>
		/// <param name="m3SDBU">Bucket start date</param>
		/// <param name="m3EDBU">Bucket end date</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3MONO">Macro order number</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="m3MOTY">Macro order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMacroHeadResponse></returns>
		/// <exception cref="M3Exception<SelMacroHeadResponse>"></exception>
		public async Task<M3Response<SelMacroHeadResponse>> SelMacroHead(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3STSF = null, 
			string m3STST = null, 
			DateTime? m3SDBU = null, 
			DateTime? m3EDBU = null, 
			string m3WHGR = null, 
			string m3MONO = null, 
			string m3APIP = null, 
			string m3MOTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelMacroHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STSF))
				request.WithQueryParameter("STSF", m3STSF.Trim());
			if (!string.IsNullOrWhiteSpace(m3STST))
				request.WithQueryParameter("STST", m3STST.Trim());
			if (m3SDBU.HasValue)
				request.WithQueryParameter("SDBU", m3SDBU.Value.ToM3String());
			if (m3EDBU.HasValue)
				request.WithQueryParameter("EDBU", m3EDBU.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MONO))
				request.WithQueryParameter("MONO", m3MONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MOTY))
				request.WithQueryParameter("MOTY", m3MOTY.Trim());

			// Execute the request
			var result = await Execute<SelMacroHeadResponse>(
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
		/// Name SelMatByHead
		/// Description Select Materials By Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3STSF">From Status</param>
		/// <param name="m3STST">To Status</param>
		/// <param name="m3SDBU">Bucket start date</param>
		/// <param name="m3EDBU">Bucket end date</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3MONO">Macro order number</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="m3MOTY">Macro order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMatByHeadResponse></returns>
		/// <exception cref="M3Exception<SelMatByHeadResponse>"></exception>
		public async Task<M3Response<SelMatByHeadResponse>> SelMatByHead(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3STSF = null, 
			string m3STST = null, 
			DateTime? m3SDBU = null, 
			DateTime? m3EDBU = null, 
			string m3WHGR = null, 
			string m3MONO = null, 
			string m3APIP = null, 
			string m3MOTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelMatByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STSF))
				request.WithQueryParameter("STSF", m3STSF.Trim());
			if (!string.IsNullOrWhiteSpace(m3STST))
				request.WithQueryParameter("STST", m3STST.Trim());
			if (m3SDBU.HasValue)
				request.WithQueryParameter("SDBU", m3SDBU.Value.ToM3String());
			if (m3EDBU.HasValue)
				request.WithQueryParameter("EDBU", m3EDBU.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MONO))
				request.WithQueryParameter("MONO", m3MONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MOTY))
				request.WithQueryParameter("MOTY", m3MOTY.Trim());

			// Execute the request
			var result = await Execute<SelMatByHeadResponse>(
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
		/// Name SelOpeByHead
		/// Description Select Operations By Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3STSF">From Status</param>
		/// <param name="m3STST">To Status</param>
		/// <param name="m3SDBU">Bucket start date</param>
		/// <param name="m3EDBU">Bucket end date</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3MONO">Macro order number</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="m3MOTY">Macro order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOpeByHeadResponse></returns>
		/// <exception cref="M3Exception<SelOpeByHeadResponse>"></exception>
		public async Task<M3Response<SelOpeByHeadResponse>> SelOpeByHead(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3STSF = null, 
			string m3STST = null, 
			DateTime? m3SDBU = null, 
			DateTime? m3EDBU = null, 
			string m3WHGR = null, 
			string m3MONO = null, 
			string m3APIP = null, 
			string m3MOTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelOpeByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STSF))
				request.WithQueryParameter("STSF", m3STSF.Trim());
			if (!string.IsNullOrWhiteSpace(m3STST))
				request.WithQueryParameter("STST", m3STST.Trim());
			if (m3SDBU.HasValue)
				request.WithQueryParameter("SDBU", m3SDBU.Value.ToM3String());
			if (m3EDBU.HasValue)
				request.WithQueryParameter("EDBU", m3EDBU.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MONO))
				request.WithQueryParameter("MONO", m3MONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MOTY))
				request.WithQueryParameter("MOTY", m3MOTY.Trim());

			// Execute the request
			var result = await Execute<SelOpeByHeadResponse>(
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
		/// Name SelOrdRelByHead
		/// Description Select Order Relations By Macro Header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3STSF">From Status</param>
		/// <param name="m3STST">To Status</param>
		/// <param name="m3SDBU">Bucket start date</param>
		/// <param name="m3EDBU">Bucket end date</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3MONO">Macro order number</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="m3MOTY">Macro order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOrdRelByHeadResponse></returns>
		/// <exception cref="M3Exception<SelOrdRelByHeadResponse>"></exception>
		public async Task<M3Response<SelOrdRelByHeadResponse>> SelOrdRelByHead(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3STSF = null, 
			string m3STST = null, 
			DateTime? m3SDBU = null, 
			DateTime? m3EDBU = null, 
			string m3WHGR = null, 
			string m3MONO = null, 
			string m3APIP = null, 
			string m3MOTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelOrdRelByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STSF))
				request.WithQueryParameter("STSF", m3STSF.Trim());
			if (!string.IsNullOrWhiteSpace(m3STST))
				request.WithQueryParameter("STST", m3STST.Trim());
			if (m3SDBU.HasValue)
				request.WithQueryParameter("SDBU", m3SDBU.Value.ToM3String());
			if (m3EDBU.HasValue)
				request.WithQueryParameter("EDBU", m3EDBU.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MONO))
				request.WithQueryParameter("MONO", m3MONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3MOTY))
				request.WithQueryParameter("MOTY", m3MOTY.Trim());

			// Execute the request
			var result = await Execute<SelOrdRelByHeadResponse>(
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
