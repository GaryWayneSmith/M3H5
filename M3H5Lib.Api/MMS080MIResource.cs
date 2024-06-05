/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS080MI;
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
	/// Name: MMS080MI
	/// Component Name: MaterialPlans
	/// Description: Material plans interface
	/// Version Release: 5ea0
	///</summary>
	public partial class MMS080MIResource : M3BaseResourceEndpoint
	{
		public MMS080MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS080MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstItemWarehous
		/// Description List  Item/warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FWHL">From warehouse (Required)</param>
		/// <param name="m3_TWHL">To warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="m3_CRTM">Read only Critical materials</param>
		/// <param name="m3_SELE">Acquisition select</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemWarehousResponse></returns>
		/// <exception cref="M3Exception<LstItemWarehousResponse>"></exception>
		public async Task<M3Response<LstItemWarehousResponse>> LstItemWarehous(
			string m3_FWHL, 
			string m3_TWHL, 
			int? m3_CONO = null, 
			string m3_WHGR = null, 
			string m3_APIP = null, 
			int? m3_CRTM = null, 
			int? m3_SELE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItemWarehous",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FWHL))
				throw new ArgumentNullException("m3_FWHL");
			if (string.IsNullOrWhiteSpace(m3_TWHL))
				throw new ArgumentNullException("m3_TWHL");

			// Set mandatory parameters
			request
				.WithQueryParameter("FWHL", m3_FWHL.Trim())
				.WithQueryParameter("TWHL", m3_TWHL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());
			if (m3_SELE.HasValue)
				request.WithQueryParameter("SELE", m3_SELE.Value.ToString());

			// Execute the request
			var result = await Execute<LstItemWarehousResponse>(
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
		/// Name LstPOHBalance
		/// Description Select POH
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FWLO">From warehouse</param>
		/// <param name="m3_TWLO">To warehouse</param>
		/// <param name="m3_FITN">From item number</param>
		/// <param name="m3_TITN">To item number</param>
		/// <param name="m3_PLDT">Planning date</param>
		/// <param name="m3_IFOR">Include forecast</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPOHBalanceResponse></returns>
		/// <exception cref="M3Exception<LstPOHBalanceResponse>"></exception>
		public async Task<M3Response<LstPOHBalanceResponse>> LstPOHBalance(
			int? m3_CONO = null, 
			string m3_FWLO = null, 
			string m3_TWLO = null, 
			string m3_FITN = null, 
			string m3_TITN = null, 
			DateTime? m3_PLDT = null, 
			int? m3_IFOR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPOHBalance",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWLO))
				request.WithQueryParameter("FWLO", m3_FWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWLO))
				request.WithQueryParameter("TWLO", m3_TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FITN))
				request.WithQueryParameter("FITN", m3_FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITN))
				request.WithQueryParameter("TITN", m3_TITN.Trim());
			if (m3_PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3_PLDT.Value.ToM3String());
			if (m3_IFOR.HasValue)
				request.WithQueryParameter("IFOR", m3_IFOR.Value.ToString());

			// Execute the request
			var result = await Execute<LstPOHBalanceResponse>(
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
		/// Name SelByCoProd
		/// Description Select By/Co product for MSP/APP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_FORC">From order category</param>
		/// <param name="m3_TORC">To order category</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="m3_SCHH">Planning horizon</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelByCoProdResponse></returns>
		/// <exception cref="M3Exception<SelByCoProdResponse>"></exception>
		public async Task<M3Response<SelByCoProdResponse>> SelByCoProd(
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			string m3_WHGR = null, 
			string m3_FORC = null, 
			string m3_TORC = null, 
			string m3_APIP = null, 
			int? m3_SCHH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelByCoProd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FORC))
				request.WithQueryParameter("FORC", m3_FORC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TORC))
				request.WithQueryParameter("TORC", m3_TORC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());

			// Execute the request
			var result = await Execute<SelByCoProdResponse>(
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
		/// Name SelForcTrans
		/// Description Selection of forecastsrecords
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FWHL">From warehouse (Required)</param>
		/// <param name="m3_TWHL">To warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="m3_SCHH">Planning horizon</param>
		/// <param name="m3_SWHG">Sum warehousegroup</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelForcTransResponse></returns>
		/// <exception cref="M3Exception<SelForcTransResponse>"></exception>
		public async Task<M3Response<SelForcTransResponse>> SelForcTrans(
			string m3_FWHL, 
			string m3_TWHL, 
			int? m3_CONO = null, 
			string m3_WHGR = null, 
			string m3_APIP = null, 
			int? m3_SCHH = null, 
			int? m3_SWHG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelForcTrans",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FWHL))
				throw new ArgumentNullException("m3_FWHL");
			if (string.IsNullOrWhiteSpace(m3_TWHL))
				throw new ArgumentNullException("m3_TWHL");

			// Set mandatory parameters
			request
				.WithQueryParameter("FWHL", m3_FWHL.Trim())
				.WithQueryParameter("TWHL", m3_TWHL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (m3_SWHG.HasValue)
				request.WithQueryParameter("SWHG", m3_SWHG.Value.ToString());

			// Execute the request
			var result = await Execute<SelForcTransResponse>(
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
		/// Name SelItemWarehous
		/// Description Selection item/warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FWHL">From warehouse (Required)</param>
		/// <param name="m3_TWHL">To warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_SINV">Select only inv.acc(STCD) equals one</param>
		/// <param name="m3_RPLO">0 = Reade MITBAL00, 1 = Reade MITPLO00</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="m3_STYN">Select only Styles (with no transaction)</param>
		/// <param name="m3_CRTM">Read only Critical materials</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItemWarehousResponse></returns>
		/// <exception cref="M3Exception<SelItemWarehousResponse>"></exception>
		public async Task<M3Response<SelItemWarehousResponse>> SelItemWarehous(
			string m3_FWHL, 
			string m3_TWHL, 
			int? m3_CONO = null, 
			string m3_WHGR = null, 
			int? m3_SINV = null, 
			int? m3_RPLO = null, 
			string m3_APIP = null, 
			int? m3_STYN = null, 
			int? m3_CRTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelItemWarehous",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FWHL))
				throw new ArgumentNullException("m3_FWHL");
			if (string.IsNullOrWhiteSpace(m3_TWHL))
				throw new ArgumentNullException("m3_TWHL");

			// Set mandatory parameters
			request
				.WithQueryParameter("FWHL", m3_FWHL.Trim())
				.WithQueryParameter("TWHL", m3_TWHL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (m3_SINV.HasValue)
				request.WithQueryParameter("SINV", m3_SINV.Value.ToString());
			if (m3_RPLO.HasValue)
				request.WithQueryParameter("RPLO", m3_RPLO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (m3_STYN.HasValue)
				request.WithQueryParameter("STYN", m3_STYN.Value.ToString());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());

			// Execute the request
			var result = await Execute<SelItemWarehousResponse>(
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
		/// Name SelMtrlTrans
		/// Description Selection material plan transactions
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_FORC">From order category</param>
		/// <param name="m3_TORC">To order category</param>
		/// <param name="m3_WHGR">Warehouse Group</param>
		/// <param name="m3_DIDR">De-select internal distribution records</param>
		/// <param name="m3_DSBP">De-select PO trans. which don't upd. POB</param>
		/// <param name="m3_DSBR">De-select RO trans. with ref ord cat = 1</param>
		/// <param name="m3_MITF">Read MITPLO20(=0), MITPLO40(=1)</param>
		/// <param name="m3_SINV">Select only inv.acc(STCD) equals one</param>
		/// <param name="m3_SECO">Select CO with status below 20</param>
		/// <param name="m3_RREF">Retrive refrensorder info</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="m3_SCHH">Planning horizon</param>
		/// <param name="m3_CRTM">Critical Material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMtrlTransResponse></returns>
		/// <exception cref="M3Exception<SelMtrlTransResponse>"></exception>
		public async Task<M3Response<SelMtrlTransResponse>> SelMtrlTrans(
			string m3_WHLO, 
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_FORC = null, 
			string m3_TORC = null, 
			string m3_WHGR = null, 
			int? m3_DIDR = null, 
			int? m3_DSBP = null, 
			int? m3_DSBR = null, 
			int? m3_MITF = null, 
			int? m3_SINV = null, 
			int? m3_SECO = null, 
			int? m3_RREF = null, 
			string m3_APIP = null, 
			int? m3_SCHH = null, 
			int? m3_CRTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelMtrlTrans",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FORC))
				request.WithQueryParameter("FORC", m3_FORC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TORC))
				request.WithQueryParameter("TORC", m3_TORC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (m3_DIDR.HasValue)
				request.WithQueryParameter("DIDR", m3_DIDR.Value.ToString());
			if (m3_DSBP.HasValue)
				request.WithQueryParameter("DSBP", m3_DSBP.Value.ToString());
			if (m3_DSBR.HasValue)
				request.WithQueryParameter("DSBR", m3_DSBR.Value.ToString());
			if (m3_MITF.HasValue)
				request.WithQueryParameter("MITF", m3_MITF.Value.ToString());
			if (m3_SINV.HasValue)
				request.WithQueryParameter("SINV", m3_SINV.Value.ToString());
			if (m3_SECO.HasValue)
				request.WithQueryParameter("SECO", m3_SECO.Value.ToString());
			if (m3_RREF.HasValue)
				request.WithQueryParameter("RREF", m3_RREF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());

			// Execute the request
			var result = await Execute<SelMtrlTransResponse>(
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
		/// Name SelPOHBalance
		/// Description Select Projected On Hand Balance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLDT">Planning date (Required)</param>
		/// <param name="m3_APIP">APS - policy (Required)</param>
		/// <param name="m3_FWLO">Warehouse (Required)</param>
		/// <param name="m3_TWLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_IFOR">Include forecast</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelPOHBalanceResponse></returns>
		/// <exception cref="M3Exception<SelPOHBalanceResponse>"></exception>
		public async Task<M3Response<SelPOHBalanceResponse>> SelPOHBalance(
			DateTime m3_PLDT, 
			string m3_APIP, 
			string m3_FWLO, 
			string m3_TWLO, 
			int? m3_CONO = null, 
			string m3_WHGR = null, 
			int? m3_IFOR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelPOHBalance",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_APIP))
				throw new ArgumentNullException("m3_APIP");
			if (string.IsNullOrWhiteSpace(m3_FWLO))
				throw new ArgumentNullException("m3_FWLO");
			if (string.IsNullOrWhiteSpace(m3_TWLO))
				throw new ArgumentNullException("m3_TWLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PLDT", m3_PLDT.ToM3String())
				.WithQueryParameter("APIP", m3_APIP.Trim())
				.WithQueryParameter("FWLO", m3_FWLO.Trim())
				.WithQueryParameter("TWLO", m3_TWLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (m3_IFOR.HasValue)
				request.WithQueryParameter("IFOR", m3_IFOR.Value.ToString());

			// Execute the request
			var result = await Execute<SelPOHBalanceResponse>(
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
