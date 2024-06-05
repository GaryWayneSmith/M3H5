/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS420MI;
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
	/// Name: MWS420MI
	/// Component Name: WHI
	/// Description: Api: Picking List
	/// Version Release: 5ea0
	///</summary>
	public partial class MWS420MIResource : M3BaseResourceEndpoint
	{
		public MWS420MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS420MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Confirm
		/// Description Confirm issues
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Confirm(
			decimal m3_DLIX, 
			int m3_PLSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Confirm",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

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
		/// Name GetPckLnViaRepN
		/// Description Get pick line via reporting number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLRN">Reporting number - pick line (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPckLnViaRepNResponse></returns>
		/// <exception cref="M3Exception<GetPckLnViaRepNResponse>"></exception>
		public async Task<M3Response<GetPckLnViaRepNResponse>> GetPckLnViaRepN(
			decimal m3_PLRN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPckLnViaRepN",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLRN", m3_PLRN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetPckLnViaRepNResponse>(
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
		/// Name GetPickListLine
		/// Description Get pick list line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_WHSL">Location (Required)</param>
		/// <param name="m3_TTYP">Stock transaction type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDI">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_SOFT">Soft allocation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPickListLineResponse></returns>
		/// <exception cref="M3Exception<GetPickListLineResponse>"></exception>
		public async Task<M3Response<GetPickListLineResponse>> GetPickListLine(
			string m3_WHLO, 
			string m3_ITNO, 
			string m3_WHSL, 
			int m3_TTYP, 
			string m3_RIDN, 
			int m3_RIDL, 
			decimal m3_RIDI, 
			int m3_PLSX, 
			int? m3_CONO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			int? m3_RIDO = null, 
			int? m3_RIDX = null, 
			int? m3_SOFT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPickListLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("WHSL", m3_WHSL.Trim())
				.WithQueryParameter("TTYP", m3_TTYP.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDI", m3_RIDI.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_SOFT.HasValue)
				request.WithQueryParameter("SOFT", m3_SOFT.Value.ToString());

			// Execute the request
			var result = await Execute<GetPickListLineResponse>(
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
		/// Name HdAllocByPckLst
		/// Description Transfer soft allocated pick list to hard allocated
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> HdAllocByPckLst(
			decimal m3_DLIX, 
			int m3_PLSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/HdAllocByPckLst",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

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
		/// Name HdAllocLnByRepN
		/// Description Transfer soft allocation to hard allocation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<HdAllocLnByRepNResponse></returns>
		/// <exception cref="M3Exception<HdAllocLnByRepNResponse>"></exception>
		public async Task<M3Response<HdAllocLnByRepNResponse>> HdAllocLnByRepN(
			decimal? m3_PLRN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/HdAllocLnByRepN",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());

			// Execute the request
			var result = await Execute<HdAllocLnByRepNResponse>(
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
		/// Name LoadOntoShip
		/// Description load onto shipment
		/// Version Release: 14.4
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> LoadOntoShip(
			decimal m3_DLIX, 
			int m3_PLSX, 
			string m3_LODO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LoadOntoShip",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());

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
		/// Name LstPLViaPckLst
		/// Description List pick line via pick list
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RIDI">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPLViaPckLstResponse></returns>
		/// <exception cref="M3Exception<LstPLViaPckLstResponse>"></exception>
		public async Task<M3Response<LstPLViaPckLstResponse>> LstPLViaPckLst(
			decimal m3_RIDI, 
			int m3_PLSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPLViaPckLst",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("RIDI", m3_RIDI.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstPLViaPckLstResponse>(
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
		/// Name LstPickHeader
		/// Description List pick header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickHeaderResponse></returns>
		/// <exception cref="M3Exception<LstPickHeaderResponse>"></exception>
		public async Task<M3Response<LstPickHeaderResponse>> LstPickHeader(
			decimal m3_DLIX, 
			int? m3_PLSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPickHeader",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());

			// Execute the request
			var result = await Execute<LstPickHeaderResponse>(
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
		/// Name LstPickList
		/// Description List of picking lists matching the selection criteria
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FPIS">From Picking status</param>
		/// <param name="m3_TPIS">To Picking status</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_TEAM">Picking team</param>
		/// <param name="m3_PICK">Picker</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_PISE">Warehouse equipment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickListResponse></returns>
		/// <exception cref="M3Exception<LstPickListResponse>"></exception>
		public async Task<M3Response<LstPickListResponse>> LstPickList(
			string m3_WHLO = null, 
			string m3_FPIS = null, 
			string m3_TPIS = null, 
			int? m3_RORC = null, 
			string m3_SLTP = null, 
			string m3_TEAM = null, 
			string m3_PICK = null, 
			decimal? m3_DLIX = null, 
			int? m3_PLSX = null, 
			string m3_PISE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPickList",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPIS))
				request.WithQueryParameter("FPIS", m3_FPIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPIS))
				request.WithQueryParameter("TPIS", m3_TPIS.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEAM))
				request.WithQueryParameter("TEAM", m3_TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PICK))
				request.WithQueryParameter("PICK", m3_PICK.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PISE))
				request.WithQueryParameter("PISE", m3_PISE.Trim());

			// Execute the request
			var result = await Execute<LstPickListResponse>(
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
		/// Name LstPickersPL
		/// Description Pickers Picklist
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FPIS">From picking status</param>
		/// <param name="m3_TPIS">To picking status</param>
		/// <param name="m3_FORC">From reference order category</param>
		/// <param name="m3_TORC">To reference order category</param>
		/// <param name="m3_FSEQ">From picking sequence</param>
		/// <param name="m3_TSEQ">To picking sequence</param>
		/// <param name="m3_SSEQ">Sort by Seq</param>
		/// <param name="m3_ZFTP">From stock zone</param>
		/// <param name="m3_ZTTP">To stock zone</param>
		/// <param name="m3_ZLST">Excl/incl stock zone</param>
		/// <param name="m3_TEAM">Picking team</param>
		/// <param name="m3_PICK">Picker</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_PISE">Warehouse equipment</param>
		/// <param name="m3_ZXPN">Max no of pick line</param>
		/// <param name="m3_ZXPL">Max no of pick list</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_PLRI">Wave number</param>
		/// <param name="m3_FDDT">From departure date</param>
		/// <param name="m3_FDHM">From departure time</param>
		/// <param name="m3_TDDT">To departure date</param>
		/// <param name="m3_TDHM">To departure time</param>
		/// <param name="m3_CONA">Consignee</param>
		/// <param name="m3_FPAS">From packing status</param>
		/// <param name="m3_TPAS">To packing status</param>
		/// <param name="m3_ZPIS">Include picking status</param>
		/// <param name="m3_ZORC">Include reference order category</param>
		/// <param name="m3_ZPAS">Include packing status</param>
		/// <param name="m3_ZISE">Include warehouse equipment</param>
		/// <param name="m3_CLPI">Calculate lines to pick</param>
		/// <param name="m3_CLPA">Calculate lines to pack</param>
		/// <param name="m3_CWV1">Calculate weight/volume to pick</param>
		/// <param name="m3_CWV2">Calculate weight/volume to pack</param>
		/// <param name="m3_XPI0">Exclude if lines to pick = 0</param>
		/// <param name="m3_XPA0">Exclude if lines to pack = 0</param>
		/// <param name="m3_FLPI">From lines to pick</param>
		/// <param name="m3_TLPI">To lines to pick</param>
		/// <param name="m3_FWPI">From weight to pick</param>
		/// <param name="m3_TWPI">To weight to pick</param>
		/// <param name="m3_FVPI">From volume to pick</param>
		/// <param name="m3_TVPI">To volume to pick</param>
		/// <param name="m3_FLPA">From lines to pack</param>
		/// <param name="m3_TLPA">To lines to pack</param>
		/// <param name="m3_FWPA">From weight to pack</param>
		/// <param name="m3_TWPA">To weight to pack</param>
		/// <param name="m3_FVPA">From volume to pack</param>
		/// <param name="m3_TVPA">To volume to pack</param>
		/// <param name="m3_MLPI">Max lines to pick</param>
		/// <param name="m3_MLPA">Max lines to pack</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickersPLResponse></returns>
		/// <exception cref="M3Exception<LstPickersPLResponse>"></exception>
		public async Task<M3Response<LstPickersPLResponse>> LstPickersPL(
			string m3_WHLO = null, 
			string m3_FPIS = null, 
			string m3_TPIS = null, 
			int? m3_FORC = null, 
			int? m3_TORC = null, 
			int? m3_FSEQ = null, 
			int? m3_TSEQ = null, 
			int? m3_SSEQ = null, 
			string m3_ZFTP = null, 
			string m3_ZTTP = null, 
			string m3_ZLST = null, 
			string m3_TEAM = null, 
			string m3_PICK = null, 
			decimal? m3_DLIX = null, 
			int? m3_PLSX = null, 
			string m3_PISE = null, 
			int? m3_ZXPN = null, 
			int? m3_ZXPL = null, 
			string m3_ROUT = null, 
			int? m3_RODN = null, 
			int? m3_CONN = null, 
			string m3_PLRI = null, 
			DateTime? m3_FDDT = null, 
			int? m3_FDHM = null, 
			DateTime? m3_TDDT = null, 
			int? m3_TDHM = null, 
			string m3_CONA = null, 
			string m3_FPAS = null, 
			string m3_TPAS = null, 
			string m3_ZPIS = null, 
			long? m3_ZORC = null, 
			string m3_ZPAS = null, 
			string m3_ZISE = null, 
			int? m3_CLPI = null, 
			int? m3_CLPA = null, 
			int? m3_CWV1 = null, 
			int? m3_CWV2 = null, 
			int? m3_XPI0 = null, 
			int? m3_XPA0 = null, 
			int? m3_FLPI = null, 
			int? m3_TLPI = null, 
			decimal? m3_FWPI = null, 
			decimal? m3_TWPI = null, 
			decimal? m3_FVPI = null, 
			decimal? m3_TVPI = null, 
			int? m3_FLPA = null, 
			int? m3_TLPA = null, 
			decimal? m3_FWPA = null, 
			decimal? m3_TWPA = null, 
			decimal? m3_FVPA = null, 
			decimal? m3_TVPA = null, 
			int? m3_MLPI = null, 
			int? m3_MLPA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPickersPL",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPIS))
				request.WithQueryParameter("FPIS", m3_FPIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPIS))
				request.WithQueryParameter("TPIS", m3_TPIS.Trim());
			if (m3_FORC.HasValue)
				request.WithQueryParameter("FORC", m3_FORC.Value.ToString());
			if (m3_TORC.HasValue)
				request.WithQueryParameter("TORC", m3_TORC.Value.ToString());
			if (m3_FSEQ.HasValue)
				request.WithQueryParameter("FSEQ", m3_FSEQ.Value.ToString());
			if (m3_TSEQ.HasValue)
				request.WithQueryParameter("TSEQ", m3_TSEQ.Value.ToString());
			if (m3_SSEQ.HasValue)
				request.WithQueryParameter("SSEQ", m3_SSEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ZFTP))
				request.WithQueryParameter("ZFTP", m3_ZFTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ZTTP))
				request.WithQueryParameter("ZTTP", m3_ZTTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ZLST))
				request.WithQueryParameter("ZLST", m3_ZLST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEAM))
				request.WithQueryParameter("TEAM", m3_TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PICK))
				request.WithQueryParameter("PICK", m3_PICK.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PISE))
				request.WithQueryParameter("PISE", m3_PISE.Trim());
			if (m3_ZXPN.HasValue)
				request.WithQueryParameter("ZXPN", m3_ZXPN.Value.ToString());
			if (m3_ZXPL.HasValue)
				request.WithQueryParameter("ZXPL", m3_ZXPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (m3_RODN.HasValue)
				request.WithQueryParameter("RODN", m3_RODN.Value.ToString());
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLRI))
				request.WithQueryParameter("PLRI", m3_PLRI.Trim());
			if (m3_FDDT.HasValue)
				request.WithQueryParameter("FDDT", m3_FDDT.Value.ToM3String());
			if (m3_FDHM.HasValue)
				request.WithQueryParameter("FDHM", m3_FDHM.Value.ToString());
			if (m3_TDDT.HasValue)
				request.WithQueryParameter("TDDT", m3_TDDT.Value.ToM3String());
			if (m3_TDHM.HasValue)
				request.WithQueryParameter("TDHM", m3_TDHM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CONA))
				request.WithQueryParameter("CONA", m3_CONA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPAS))
				request.WithQueryParameter("FPAS", m3_FPAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPAS))
				request.WithQueryParameter("TPAS", m3_TPAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ZPIS))
				request.WithQueryParameter("ZPIS", m3_ZPIS.Trim());
			if (m3_ZORC.HasValue)
				request.WithQueryParameter("ZORC", m3_ZORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ZPAS))
				request.WithQueryParameter("ZPAS", m3_ZPAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ZISE))
				request.WithQueryParameter("ZISE", m3_ZISE.Trim());
			if (m3_CLPI.HasValue)
				request.WithQueryParameter("CLPI", m3_CLPI.Value.ToString());
			if (m3_CLPA.HasValue)
				request.WithQueryParameter("CLPA", m3_CLPA.Value.ToString());
			if (m3_CWV1.HasValue)
				request.WithQueryParameter("CWV1", m3_CWV1.Value.ToString());
			if (m3_CWV2.HasValue)
				request.WithQueryParameter("CWV2", m3_CWV2.Value.ToString());
			if (m3_XPI0.HasValue)
				request.WithQueryParameter("XPI0", m3_XPI0.Value.ToString());
			if (m3_XPA0.HasValue)
				request.WithQueryParameter("XPA0", m3_XPA0.Value.ToString());
			if (m3_FLPI.HasValue)
				request.WithQueryParameter("FLPI", m3_FLPI.Value.ToString());
			if (m3_TLPI.HasValue)
				request.WithQueryParameter("TLPI", m3_TLPI.Value.ToString());
			if (m3_FWPI.HasValue)
				request.WithQueryParameter("FWPI", m3_FWPI.Value.ToString());
			if (m3_TWPI.HasValue)
				request.WithQueryParameter("TWPI", m3_TWPI.Value.ToString());
			if (m3_FVPI.HasValue)
				request.WithQueryParameter("FVPI", m3_FVPI.Value.ToString());
			if (m3_TVPI.HasValue)
				request.WithQueryParameter("TVPI", m3_TVPI.Value.ToString());
			if (m3_FLPA.HasValue)
				request.WithQueryParameter("FLPA", m3_FLPA.Value.ToString());
			if (m3_TLPA.HasValue)
				request.WithQueryParameter("TLPA", m3_TLPA.Value.ToString());
			if (m3_FWPA.HasValue)
				request.WithQueryParameter("FWPA", m3_FWPA.Value.ToString());
			if (m3_TWPA.HasValue)
				request.WithQueryParameter("TWPA", m3_TWPA.Value.ToString());
			if (m3_FVPA.HasValue)
				request.WithQueryParameter("FVPA", m3_FVPA.Value.ToString());
			if (m3_TVPA.HasValue)
				request.WithQueryParameter("TVPA", m3_TVPA.Value.ToString());
			if (m3_MLPI.HasValue)
				request.WithQueryParameter("MLPI", m3_MLPI.Value.ToString());
			if (m3_MLPA.HasValue)
				request.WithQueryParameter("MLPA", m3_MLPA.Value.ToString());

			// Execute the request
			var result = await Execute<LstPickersPLResponse>(
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
		/// Name LstWave
		/// Description List wave numbers for warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PLRI">Wave number</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_PISE">Warehouse equipment</param>
		/// <param name="m3_TEAM">Picking team</param>
		/// <param name="m3_PICK">Picker</param>
		/// <param name="m3_FPIS">From Picking status</param>
		/// <param name="m3_TPIS">To Picking status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWaveResponse></returns>
		/// <exception cref="M3Exception<LstWaveResponse>"></exception>
		public async Task<M3Response<LstWaveResponse>> LstWave(
			string m3_WHLO, 
			string m3_PLRI = null, 
			string m3_SLTP = null, 
			string m3_PISE = null, 
			string m3_TEAM = null, 
			string m3_PICK = null, 
			string m3_FPIS = null, 
			string m3_TPIS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstWave",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PLRI))
				request.WithQueryParameter("PLRI", m3_PLRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PISE))
				request.WithQueryParameter("PISE", m3_PISE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEAM))
				request.WithQueryParameter("TEAM", m3_TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PICK))
				request.WithQueryParameter("PICK", m3_PICK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPIS))
				request.WithQueryParameter("FPIS", m3_FPIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPIS))
				request.WithQueryParameter("TPIS", m3_TPIS.Trim());

			// Execute the request
			var result = await Execute<LstWaveResponse>(
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
		/// Name LstWavePickList
		/// Description List picking list lines for wave number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PLRI">Wave number (Required)</param>
		/// <param name="m3_FPIS">From Picking status</param>
		/// <param name="m3_TPIS">To Picking status</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_TEAM">Picking team</param>
		/// <param name="m3_PICK">Picker</param>
		/// <param name="m3_PISE">Warehouse equipment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWavePickListResponse></returns>
		/// <exception cref="M3Exception<LstWavePickListResponse>"></exception>
		public async Task<M3Response<LstWavePickListResponse>> LstWavePickList(
			string m3_WHLO, 
			string m3_PLRI, 
			string m3_FPIS = null, 
			string m3_TPIS = null, 
			int? m3_RORC = null, 
			string m3_SLTP = null, 
			string m3_TEAM = null, 
			string m3_PICK = null, 
			string m3_PISE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstWavePickList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PLRI))
				throw new ArgumentNullException("m3_PLRI");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PLRI", m3_PLRI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FPIS))
				request.WithQueryParameter("FPIS", m3_FPIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPIS))
				request.WithQueryParameter("TPIS", m3_TPIS.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEAM))
				request.WithQueryParameter("TEAM", m3_TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PICK))
				request.WithQueryParameter("PICK", m3_PICK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PISE))
				request.WithQueryParameter("PISE", m3_PISE.Trim());

			// Execute the request
			var result = await Execute<LstWavePickListResponse>(
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
		/// Name MoveToDock
		/// Description MoveToDock
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MoveToDock(
			decimal m3_DLIX, 
			int m3_PLSX, 
			string m3_TWSL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/MoveToDock",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());

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
		/// Name MoveToPack
		/// Description Move to packing location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MoveToPack(
			decimal m3_DLIX, 
			int m3_PLSX, 
			string m3_TWSL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/MoveToPack",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());

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
		/// Name MoveToStd
		/// Description Move to standard location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MoveToStd(
			decimal m3_DLIX, 
			int m3_PLSX, 
			string m3_TWSL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/MoveToStd",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());

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
		/// Name PrtDocuments
		/// Description Submit job to print delivery document
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_DEV0">Printer</param>
		/// <param name="m3_COPY">Number of copies</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_GENR">Generate before print</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrtDocuments(
			decimal? m3_DLIX = null, 
			int? m3_CONN = null, 
			string m3_DEV0 = null, 
			int? m3_COPY = null, 
			string m3_DONR = null, 
			string m3_DOVA = null, 
			int? m3_GENR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrtDocuments",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DEV0))
				request.WithQueryParameter("DEV0", m3_DEV0.Trim());
			if (m3_COPY.HasValue)
				request.WithQueryParameter("COPY", m3_COPY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (m3_GENR.HasValue)
				request.WithQueryParameter("GENR", m3_GENR.Value.ToString());

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
		/// Name PrtPickingList
		/// Description Print a picking list at any time once it is created
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_PLRI">Wave number</param>
		/// <param name="m3_COPL">Wave line specification</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="m3_DEV0">Printer</param>
		/// <param name="m3_COPY">Number of copies</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrtPickingList(
			decimal m3_DLIX, 
			int? m3_PLSX = null, 
			string m3_PLRI = null, 
			int? m3_COPL = null, 
			string m3_DOVA = null, 
			string m3_DEV0 = null, 
			int? m3_COPY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrtPickingList",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLRI))
				request.WithQueryParameter("PLRI", m3_PLRI.Trim());
			if (m3_COPL.HasValue)
				request.WithQueryParameter("COPL", m3_COPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEV0))
				request.WithQueryParameter("DEV0", m3_DEV0.Trim());
			if (m3_COPY.HasValue)
				request.WithQueryParameter("COPY", m3_COPY.Value.ToString());

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
		/// Name UnloadFromShip
		/// Description Unload from shipment
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UnloadFromShip(
			decimal m3_DLIX, 
			int m3_PLSX, 
			string m3_LODO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UnloadFromShip",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());

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
		/// Name UpdPickHead
		/// Description Update picking head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_TEAM">Picking team</param>
		/// <param name="m3_PICK">Picker</param>
		/// <param name="m3_SEEQ">Picking sequence</param>
		/// <param name="m3_DEV">Printer</param>
		/// <param name="m3_DOVA">Document variant</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPickHead(
			decimal m3_DLIX, 
			int m3_PLSX, 
			string m3_TEAM = null, 
			string m3_PICK = null, 
			int? m3_SEEQ = null, 
			string m3_DEV = null, 
			string m3_DOVA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPickHead",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEAM))
				request.WithQueryParameter("TEAM", m3_TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PICK))
				request.WithQueryParameter("PICK", m3_PICK.Trim());
			if (m3_SEEQ.HasValue)
				request.WithQueryParameter("SEEQ", m3_SEEQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DEV))
				request.WithQueryParameter("DEV", m3_DEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOVA))
				request.WithQueryParameter("DOVA", m3_DOVA.Trim());

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
