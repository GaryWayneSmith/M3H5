/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Confirm
		/// Description Confirm issues
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Confirm(
			decimal m3DLIX, 
			int m3PLSX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Confirm",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetPckLnViaRepN
		/// Description Get pick line via reporting number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLRN">Reporting number - pick line (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPckLnViaRepNResponse></returns>
		/// <exception cref="M3Exception<GetPckLnViaRepNResponse>"></exception>
		public async Task<M3Response<GetPckLnViaRepNResponse>> GetPckLnViaRepN(
			decimal m3PLRN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPckLnViaRepN",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLRN", m3PLRN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPckLnViaRepNResponse>(
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
		/// Name GetPickListLine
		/// Description Get pick list line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3WHSL">Location (Required)</param>
		/// <param name="m3TTYP">Stock transaction type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3RIDI">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3SOFT">Soft allocation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPickListLineResponse></returns>
		/// <exception cref="M3Exception<GetPickListLineResponse>"></exception>
		public async Task<M3Response<GetPickListLineResponse>> GetPickListLine(
			string m3WHLO, 
			string m3ITNO, 
			string m3WHSL, 
			int m3TTYP, 
			string m3RIDN, 
			int m3RIDL, 
			decimal m3RIDI, 
			int m3PLSX, 
			int? m3CONO = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			int? m3RIDO = null, 
			int? m3RIDX = null, 
			int? m3SOFT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPickListLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("WHSL", m3WHSL.Trim())
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDI", m3RIDI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3RIDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOFT.HasValue)
				request.WithQueryParameter("SOFT", m3SOFT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPickListLineResponse>(
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
		/// Name HdAllocByPckLst
		/// Description Transfer soft allocated pick list to hard allocated
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> HdAllocByPckLst(
			decimal m3DLIX, 
			int m3PLSX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/HdAllocByPckLst",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

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
		/// Name HdAllocLnByRepN
		/// Description Transfer soft allocation to hard allocation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLRN">Reporting number - pick line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<HdAllocLnByRepNResponse></returns>
		/// <exception cref="M3Exception<HdAllocLnByRepNResponse>"></exception>
		public async Task<M3Response<HdAllocLnByRepNResponse>> HdAllocLnByRepN(
			decimal? m3PLRN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/HdAllocLnByRepN",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3PLRN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<HdAllocLnByRepNResponse>(
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
		/// Name LoadOntoShip
		/// Description load onto shipment
		/// Version Release: 14.4
		/// </summary>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> LoadOntoShip(
			decimal m3DLIX, 
			int m3PLSX, 
			string m3LODO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LoadOntoShip",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());

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
		/// Name LstPLViaPckLst
		/// Description List pick line via pick list
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RIDI">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPLViaPckLstResponse></returns>
		/// <exception cref="M3Exception<LstPLViaPckLstResponse>"></exception>
		public async Task<M3Response<LstPLViaPckLstResponse>> LstPLViaPckLst(
			decimal m3RIDI, 
			int m3PLSX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPLViaPckLst",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("RIDI", m3RIDI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPLViaPckLstResponse>(
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
		/// Name LstPickHeader
		/// Description List pick header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickHeaderResponse></returns>
		/// <exception cref="M3Exception<LstPickHeaderResponse>"></exception>
		public async Task<M3Response<LstPickHeaderResponse>> LstPickHeader(
			decimal m3DLIX, 
			int? m3PLSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPickHeader",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPickHeaderResponse>(
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
		/// Name LstPickList
		/// Description List of picking lists matching the selection criteria
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FPIS">From Picking status</param>
		/// <param name="m3TPIS">To Picking status</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3TEAM">Picking team</param>
		/// <param name="m3PICK">Picker</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickListResponse></returns>
		/// <exception cref="M3Exception<LstPickListResponse>"></exception>
		public async Task<M3Response<LstPickListResponse>> LstPickList(
			string m3WHLO = null, 
			string m3FPIS = null, 
			string m3TPIS = null, 
			int? m3RORC = null, 
			string m3SLTP = null, 
			string m3TEAM = null, 
			string m3PICK = null, 
			decimal? m3DLIX = null, 
			int? m3PLSX = null, 
			string m3PISE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPickList",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPIS))
				request.WithQueryParameter("FPIS", m3FPIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPIS))
				request.WithQueryParameter("TPIS", m3TPIS.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEAM))
				request.WithQueryParameter("TEAM", m3TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PICK))
				request.WithQueryParameter("PICK", m3PICK.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());

			// Execute the request
			var result = await Execute<LstPickListResponse>(
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
		/// Name LstPickersPL
		/// Description Pickers Picklist
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FPIS">From picking status</param>
		/// <param name="m3TPIS">To picking status</param>
		/// <param name="m3FORC">From reference order category</param>
		/// <param name="m3TORC">To reference order category</param>
		/// <param name="m3FSEQ">From picking sequence</param>
		/// <param name="m3TSEQ">To picking sequence</param>
		/// <param name="m3SSEQ">Sort by Seq</param>
		/// <param name="m3ZFTP">From stock zone</param>
		/// <param name="m3ZTTP">To stock zone</param>
		/// <param name="m3ZLST">Excl/incl stock zone</param>
		/// <param name="m3TEAM">Picking team</param>
		/// <param name="m3PICK">Picker</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="m3ZXPN">Max no of pick line</param>
		/// <param name="m3ZXPL">Max no of pick list</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3CONN">Shipment</param>
		/// <param name="m3PLRI">Wave number</param>
		/// <param name="m3FDDT">From departure date</param>
		/// <param name="m3FDHM">From departure time</param>
		/// <param name="m3TDDT">To departure date</param>
		/// <param name="m3TDHM">To departure time</param>
		/// <param name="m3CONA">Consignee</param>
		/// <param name="m3FPAS">From packing status</param>
		/// <param name="m3TPAS">To packing status</param>
		/// <param name="m3ZPIS">Include picking status</param>
		/// <param name="m3ZORC">Include reference order category</param>
		/// <param name="m3ZPAS">Include packing status</param>
		/// <param name="m3ZISE">Include warehouse equipment</param>
		/// <param name="m3CLPI">Calculate lines to pick</param>
		/// <param name="m3CLPA">Calculate lines to pack</param>
		/// <param name="m3CWV1">Calculate weight/volume to pick</param>
		/// <param name="m3CWV2">Calculate weight/volume to pack</param>
		/// <param name="m3XPI0">Exclude if lines to pick = 0</param>
		/// <param name="m3XPA0">Exclude if lines to pack = 0</param>
		/// <param name="m3FLPI">From lines to pick</param>
		/// <param name="m3TLPI">To lines to pick</param>
		/// <param name="m3FWPI">From weight to pick</param>
		/// <param name="m3TWPI">To weight to pick</param>
		/// <param name="m3FVPI">From volume to pick</param>
		/// <param name="m3TVPI">To volume to pick</param>
		/// <param name="m3FLPA">From lines to pack</param>
		/// <param name="m3TLPA">To lines to pack</param>
		/// <param name="m3FWPA">From weight to pack</param>
		/// <param name="m3TWPA">To weight to pack</param>
		/// <param name="m3FVPA">From volume to pack</param>
		/// <param name="m3TVPA">To volume to pack</param>
		/// <param name="m3MLPI">Max lines to pick</param>
		/// <param name="m3MLPA">Max lines to pack</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickersPLResponse></returns>
		/// <exception cref="M3Exception<LstPickersPLResponse>"></exception>
		public async Task<M3Response<LstPickersPLResponse>> LstPickersPL(
			string m3WHLO = null, 
			string m3FPIS = null, 
			string m3TPIS = null, 
			int? m3FORC = null, 
			int? m3TORC = null, 
			int? m3FSEQ = null, 
			int? m3TSEQ = null, 
			int? m3SSEQ = null, 
			string m3ZFTP = null, 
			string m3ZTTP = null, 
			string m3ZLST = null, 
			string m3TEAM = null, 
			string m3PICK = null, 
			decimal? m3DLIX = null, 
			int? m3PLSX = null, 
			string m3PISE = null, 
			int? m3ZXPN = null, 
			int? m3ZXPL = null, 
			string m3ROUT = null, 
			int? m3RODN = null, 
			int? m3CONN = null, 
			string m3PLRI = null, 
			DateTime? m3FDDT = null, 
			int? m3FDHM = null, 
			DateTime? m3TDDT = null, 
			int? m3TDHM = null, 
			string m3CONA = null, 
			string m3FPAS = null, 
			string m3TPAS = null, 
			string m3ZPIS = null, 
			long? m3ZORC = null, 
			string m3ZPAS = null, 
			string m3ZISE = null, 
			int? m3CLPI = null, 
			int? m3CLPA = null, 
			int? m3CWV1 = null, 
			int? m3CWV2 = null, 
			int? m3XPI0 = null, 
			int? m3XPA0 = null, 
			int? m3FLPI = null, 
			int? m3TLPI = null, 
			decimal? m3FWPI = null, 
			decimal? m3TWPI = null, 
			decimal? m3FVPI = null, 
			decimal? m3TVPI = null, 
			int? m3FLPA = null, 
			int? m3TLPA = null, 
			decimal? m3FWPA = null, 
			decimal? m3TWPA = null, 
			decimal? m3FVPA = null, 
			decimal? m3TVPA = null, 
			int? m3MLPI = null, 
			int? m3MLPA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPickersPL",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPIS))
				request.WithQueryParameter("FPIS", m3FPIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPIS))
				request.WithQueryParameter("TPIS", m3TPIS.Trim());
			if (m3FORC.HasValue)
				request.WithQueryParameter("FORC", m3FORC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TORC.HasValue)
				request.WithQueryParameter("TORC", m3TORC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSEQ.HasValue)
				request.WithQueryParameter("FSEQ", m3FSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TSEQ.HasValue)
				request.WithQueryParameter("TSEQ", m3TSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSEQ.HasValue)
				request.WithQueryParameter("SSEQ", m3SSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ZFTP))
				request.WithQueryParameter("ZFTP", m3ZFTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ZTTP))
				request.WithQueryParameter("ZTTP", m3ZTTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ZLST))
				request.WithQueryParameter("ZLST", m3ZLST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEAM))
				request.WithQueryParameter("TEAM", m3TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PICK))
				request.WithQueryParameter("PICK", m3PICK.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());
			if (m3ZXPN.HasValue)
				request.WithQueryParameter("ZXPN", m3ZXPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ZXPL.HasValue)
				request.WithQueryParameter("ZXPL", m3ZXPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (m3RODN.HasValue)
				request.WithQueryParameter("RODN", m3RODN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONN.HasValue)
				request.WithQueryParameter("CONN", m3CONN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLRI))
				request.WithQueryParameter("PLRI", m3PLRI.Trim());
			if (m3FDDT.HasValue)
				request.WithQueryParameter("FDDT", m3FDDT.Value.ToM3String());
			if (m3FDHM.HasValue)
				request.WithQueryParameter("FDHM", m3FDHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TDDT.HasValue)
				request.WithQueryParameter("TDDT", m3TDDT.Value.ToM3String());
			if (m3TDHM.HasValue)
				request.WithQueryParameter("TDHM", m3TDHM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CONA))
				request.WithQueryParameter("CONA", m3CONA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPAS))
				request.WithQueryParameter("FPAS", m3FPAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPAS))
				request.WithQueryParameter("TPAS", m3TPAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ZPIS))
				request.WithQueryParameter("ZPIS", m3ZPIS.Trim());
			if (m3ZORC.HasValue)
				request.WithQueryParameter("ZORC", m3ZORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ZPAS))
				request.WithQueryParameter("ZPAS", m3ZPAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ZISE))
				request.WithQueryParameter("ZISE", m3ZISE.Trim());
			if (m3CLPI.HasValue)
				request.WithQueryParameter("CLPI", m3CLPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CLPA.HasValue)
				request.WithQueryParameter("CLPA", m3CLPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CWV1.HasValue)
				request.WithQueryParameter("CWV1", m3CWV1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CWV2.HasValue)
				request.WithQueryParameter("CWV2", m3CWV2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3XPI0.HasValue)
				request.WithQueryParameter("XPI0", m3XPI0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3XPA0.HasValue)
				request.WithQueryParameter("XPA0", m3XPA0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLPI.HasValue)
				request.WithQueryParameter("FLPI", m3FLPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TLPI.HasValue)
				request.WithQueryParameter("TLPI", m3TLPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FWPI.HasValue)
				request.WithQueryParameter("FWPI", m3FWPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TWPI.HasValue)
				request.WithQueryParameter("TWPI", m3TWPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVPI.HasValue)
				request.WithQueryParameter("FVPI", m3FVPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TVPI.HasValue)
				request.WithQueryParameter("TVPI", m3TVPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLPA.HasValue)
				request.WithQueryParameter("FLPA", m3FLPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TLPA.HasValue)
				request.WithQueryParameter("TLPA", m3TLPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FWPA.HasValue)
				request.WithQueryParameter("FWPA", m3FWPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TWPA.HasValue)
				request.WithQueryParameter("TWPA", m3TWPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVPA.HasValue)
				request.WithQueryParameter("FVPA", m3FVPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TVPA.HasValue)
				request.WithQueryParameter("TVPA", m3TVPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MLPI.HasValue)
				request.WithQueryParameter("MLPI", m3MLPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MLPA.HasValue)
				request.WithQueryParameter("MLPA", m3MLPA.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPickersPLResponse>(
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
		/// Name LstWave
		/// Description List wave numbers for warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PLRI">Wave number</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="m3TEAM">Picking team</param>
		/// <param name="m3PICK">Picker</param>
		/// <param name="m3FPIS">From Picking status</param>
		/// <param name="m3TPIS">To Picking status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWaveResponse></returns>
		/// <exception cref="M3Exception<LstWaveResponse>"></exception>
		public async Task<M3Response<LstWaveResponse>> LstWave(
			string m3WHLO, 
			string m3PLRI = null, 
			string m3SLTP = null, 
			string m3PISE = null, 
			string m3TEAM = null, 
			string m3PICK = null, 
			string m3FPIS = null, 
			string m3TPIS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstWave",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PLRI))
				request.WithQueryParameter("PLRI", m3PLRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEAM))
				request.WithQueryParameter("TEAM", m3TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PICK))
				request.WithQueryParameter("PICK", m3PICK.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPIS))
				request.WithQueryParameter("FPIS", m3FPIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPIS))
				request.WithQueryParameter("TPIS", m3TPIS.Trim());

			// Execute the request
			var result = await Execute<LstWaveResponse>(
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
		/// Name LstWavePickList
		/// Description List picking list lines for wave number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PLRI">Wave number (Required)</param>
		/// <param name="m3FPIS">From Picking status</param>
		/// <param name="m3TPIS">To Picking status</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3TEAM">Picking team</param>
		/// <param name="m3PICK">Picker</param>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWavePickListResponse></returns>
		/// <exception cref="M3Exception<LstWavePickListResponse>"></exception>
		public async Task<M3Response<LstWavePickListResponse>> LstWavePickList(
			string m3WHLO, 
			string m3PLRI, 
			string m3FPIS = null, 
			string m3TPIS = null, 
			int? m3RORC = null, 
			string m3SLTP = null, 
			string m3TEAM = null, 
			string m3PICK = null, 
			string m3PISE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstWavePickList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PLRI))
				throw new ArgumentNullException(nameof(m3PLRI));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PLRI", m3PLRI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FPIS))
				request.WithQueryParameter("FPIS", m3FPIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPIS))
				request.WithQueryParameter("TPIS", m3TPIS.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEAM))
				request.WithQueryParameter("TEAM", m3TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PICK))
				request.WithQueryParameter("PICK", m3PICK.Trim());
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());

			// Execute the request
			var result = await Execute<LstWavePickListResponse>(
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
		/// Name MoveToDock
		/// Description MoveToDock
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MoveToDock(
			decimal m3DLIX, 
			int m3PLSX, 
			string m3TWSL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/MoveToDock",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());

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
		/// Name MoveToPack
		/// Description Move to packing location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MoveToPack(
			decimal m3DLIX, 
			int m3PLSX, 
			string m3TWSL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/MoveToPack",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());

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
		/// Name MoveToStd
		/// Description Move to standard location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MoveToStd(
			decimal m3DLIX, 
			int m3PLSX, 
			string m3TWSL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/MoveToStd",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());

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
		/// Name PrtDocuments
		/// Description Submit job to print delivery document
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3CONN">Shipment</param>
		/// <param name="m3DEV0">Printer</param>
		/// <param name="m3COPY">Number of copies</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3GENR">Generate before print</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrtDocuments(
			decimal? m3DLIX = null, 
			int? m3CONN = null, 
			string m3DEV0 = null, 
			int? m3COPY = null, 
			string m3DONR = null, 
			string m3DOVA = null, 
			int? m3GENR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrtDocuments",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONN.HasValue)
				request.WithQueryParameter("CONN", m3CONN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DEV0))
				request.WithQueryParameter("DEV0", m3DEV0.Trim());
			if (m3COPY.HasValue)
				request.WithQueryParameter("COPY", m3COPY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (m3GENR.HasValue)
				request.WithQueryParameter("GENR", m3GENR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name PrtPickingList
		/// Description Print a picking list at any time once it is created
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3PLRI">Wave number</param>
		/// <param name="m3COPL">Wave line specification</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="m3DEV0">Printer</param>
		/// <param name="m3COPY">Number of copies</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrtPickingList(
			decimal m3DLIX, 
			int? m3PLSX = null, 
			string m3PLRI = null, 
			int? m3COPL = null, 
			string m3DOVA = null, 
			string m3DEV0 = null, 
			int? m3COPY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrtPickingList",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLRI))
				request.WithQueryParameter("PLRI", m3PLRI.Trim());
			if (m3COPL.HasValue)
				request.WithQueryParameter("COPL", m3COPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEV0))
				request.WithQueryParameter("DEV0", m3DEV0.Trim());
			if (m3COPY.HasValue)
				request.WithQueryParameter("COPY", m3COPY.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UnloadFromShip
		/// Description Unload from shipment
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UnloadFromShip(
			decimal m3DLIX, 
			int m3PLSX, 
			string m3LODO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UnloadFromShip",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());

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
		/// Name UpdPickHead
		/// Description Update picking head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3TEAM">Picking team</param>
		/// <param name="m3PICK">Picker</param>
		/// <param name="m3SEEQ">Picking sequence</param>
		/// <param name="m3DEV">Printer</param>
		/// <param name="m3DOVA">Document variant</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPickHead(
			decimal m3DLIX, 
			int m3PLSX, 
			string m3TEAM = null, 
			string m3PICK = null, 
			int? m3SEEQ = null, 
			string m3DEV = null, 
			string m3DOVA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPickHead",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEAM))
				request.WithQueryParameter("TEAM", m3TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PICK))
				request.WithQueryParameter("PICK", m3PICK.Trim());
			if (m3SEEQ.HasValue)
				request.WithQueryParameter("SEEQ", m3SEEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DEV))
				request.WithQueryParameter("DEV", m3DEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOVA))
				request.WithQueryParameter("DOVA", m3DOVA.Trim());

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
