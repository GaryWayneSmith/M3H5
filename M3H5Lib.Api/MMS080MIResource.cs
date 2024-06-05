/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstItemWarehous
		/// Description List  Item/warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FWHL">From warehouse (Required)</param>
		/// <param name="m3TWHL">To warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="m3CRTM">Read only Critical materials</param>
		/// <param name="m3SELE">Acquisition select</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemWarehousResponse></returns>
		/// <exception cref="M3Exception<LstItemWarehousResponse>"></exception>
		public async Task<M3Response<LstItemWarehousResponse>> LstItemWarehous(
			string m3FWHL, 
			string m3TWHL, 
			int? m3CONO = null, 
			string m3WHGR = null, 
			string m3APIP = null, 
			int? m3CRTM = null, 
			int? m3SELE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItemWarehous",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FWHL))
				throw new ArgumentNullException(nameof(m3FWHL));
			if (string.IsNullOrWhiteSpace(m3TWHL))
				throw new ArgumentNullException(nameof(m3TWHL));

			// Set mandatory parameters
			request
				.WithQueryParameter("FWHL", m3FWHL.Trim())
				.WithQueryParameter("TWHL", m3TWHL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SELE.HasValue)
				request.WithQueryParameter("SELE", m3SELE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstItemWarehousResponse>(
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
		/// Name LstPOHBalance
		/// Description Select POH
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FWLO">From warehouse</param>
		/// <param name="m3TWLO">To warehouse</param>
		/// <param name="m3FITN">From item number</param>
		/// <param name="m3TITN">To item number</param>
		/// <param name="m3PLDT">Planning date</param>
		/// <param name="m3IFOR">Include forecast</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPOHBalanceResponse></returns>
		/// <exception cref="M3Exception<LstPOHBalanceResponse>"></exception>
		public async Task<M3Response<LstPOHBalanceResponse>> LstPOHBalance(
			int? m3CONO = null, 
			string m3FWLO = null, 
			string m3TWLO = null, 
			string m3FITN = null, 
			string m3TITN = null, 
			DateTime? m3PLDT = null, 
			int? m3IFOR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPOHBalance",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWLO))
				request.WithQueryParameter("FWLO", m3FWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWLO))
				request.WithQueryParameter("TWLO", m3TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FITN))
				request.WithQueryParameter("FITN", m3FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITN))
				request.WithQueryParameter("TITN", m3TITN.Trim());
			if (m3PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3PLDT.Value.ToM3String());
			if (m3IFOR.HasValue)
				request.WithQueryParameter("IFOR", m3IFOR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPOHBalanceResponse>(
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
		/// Name SelByCoProd
		/// Description Select By/Co product for MSP/APP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3FORC">From order category</param>
		/// <param name="m3TORC">To order category</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="m3SCHH">Planning horizon</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelByCoProdResponse></returns>
		/// <exception cref="M3Exception<SelByCoProdResponse>"></exception>
		public async Task<M3Response<SelByCoProdResponse>> SelByCoProd(
			int? m3CONO = null, 
			string m3WHLO = null, 
			string m3WHGR = null, 
			string m3FORC = null, 
			string m3TORC = null, 
			string m3APIP = null, 
			int? m3SCHH = null, 
			int? m3SIMD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelByCoProd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3FORC))
				request.WithQueryParameter("FORC", m3FORC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TORC))
				request.WithQueryParameter("TORC", m3TORC.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelByCoProdResponse>(
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
		/// Name SelForcTrans
		/// Description Selection of forecastsrecords
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FWHL">From warehouse (Required)</param>
		/// <param name="m3TWHL">To warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="m3SCHH">Planning horizon</param>
		/// <param name="m3SWHG">Sum warehousegroup</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelForcTransResponse></returns>
		/// <exception cref="M3Exception<SelForcTransResponse>"></exception>
		public async Task<M3Response<SelForcTransResponse>> SelForcTrans(
			string m3FWHL, 
			string m3TWHL, 
			int? m3CONO = null, 
			string m3WHGR = null, 
			string m3APIP = null, 
			int? m3SCHH = null, 
			int? m3SWHG = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelForcTrans",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FWHL))
				throw new ArgumentNullException(nameof(m3FWHL));
			if (string.IsNullOrWhiteSpace(m3TWHL))
				throw new ArgumentNullException(nameof(m3TWHL));

			// Set mandatory parameters
			request
				.WithQueryParameter("FWHL", m3FWHL.Trim())
				.WithQueryParameter("TWHL", m3TWHL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SWHG.HasValue)
				request.WithQueryParameter("SWHG", m3SWHG.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelForcTransResponse>(
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
		/// Name SelItemWarehous
		/// Description Selection item/warehouse
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FWHL">From warehouse (Required)</param>
		/// <param name="m3TWHL">To warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3SINV">Select only inv.acc(STCD) equals one</param>
		/// <param name="m3RPLO">0 = Reade MITBAL00, 1 = Reade MITPLO00</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="m3STYN">Select only Styles (with no transaction)</param>
		/// <param name="m3CRTM">Read only Critical materials</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelItemWarehousResponse></returns>
		/// <exception cref="M3Exception<SelItemWarehousResponse>"></exception>
		public async Task<M3Response<SelItemWarehousResponse>> SelItemWarehous(
			string m3FWHL, 
			string m3TWHL, 
			int? m3CONO = null, 
			string m3WHGR = null, 
			int? m3SINV = null, 
			int? m3RPLO = null, 
			string m3APIP = null, 
			int? m3STYN = null, 
			int? m3CRTM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelItemWarehous",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FWHL))
				throw new ArgumentNullException(nameof(m3FWHL));
			if (string.IsNullOrWhiteSpace(m3TWHL))
				throw new ArgumentNullException(nameof(m3TWHL));

			// Set mandatory parameters
			request
				.WithQueryParameter("FWHL", m3FWHL.Trim())
				.WithQueryParameter("TWHL", m3TWHL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3SINV.HasValue)
				request.WithQueryParameter("SINV", m3SINV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPLO.HasValue)
				request.WithQueryParameter("RPLO", m3RPLO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3STYN.HasValue)
				request.WithQueryParameter("STYN", m3STYN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelItemWarehousResponse>(
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
		/// Name SelMtrlTrans
		/// Description Selection material plan transactions
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3FORC">From order category</param>
		/// <param name="m3TORC">To order category</param>
		/// <param name="m3WHGR">Warehouse Group</param>
		/// <param name="m3DIDR">De-select internal distribution records</param>
		/// <param name="m3DSBP">De-select PO trans. which don't upd. POB</param>
		/// <param name="m3DSBR">De-select RO trans. with ref ord cat = 1</param>
		/// <param name="m3MITF">Read MITPLO20(=0), MITPLO40(=1)</param>
		/// <param name="m3SINV">Select only inv.acc(STCD) equals one</param>
		/// <param name="m3SECO">Select CO with status below 20</param>
		/// <param name="m3RREF">Retrive refrensorder info</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="m3SCHH">Planning horizon</param>
		/// <param name="m3CRTM">Critical Material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMtrlTransResponse></returns>
		/// <exception cref="M3Exception<SelMtrlTransResponse>"></exception>
		public async Task<M3Response<SelMtrlTransResponse>> SelMtrlTrans(
			string m3WHLO, 
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3FORC = null, 
			string m3TORC = null, 
			string m3WHGR = null, 
			int? m3DIDR = null, 
			int? m3DSBP = null, 
			int? m3DSBR = null, 
			int? m3MITF = null, 
			int? m3SINV = null, 
			int? m3SECO = null, 
			int? m3RREF = null, 
			string m3APIP = null, 
			int? m3SCHH = null, 
			int? m3CRTM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelMtrlTrans",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FORC))
				request.WithQueryParameter("FORC", m3FORC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TORC))
				request.WithQueryParameter("TORC", m3TORC.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3DIDR.HasValue)
				request.WithQueryParameter("DIDR", m3DIDR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSBP.HasValue)
				request.WithQueryParameter("DSBP", m3DSBP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSBR.HasValue)
				request.WithQueryParameter("DSBR", m3DSBR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MITF.HasValue)
				request.WithQueryParameter("MITF", m3MITF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SINV.HasValue)
				request.WithQueryParameter("SINV", m3SINV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SECO.HasValue)
				request.WithQueryParameter("SECO", m3SECO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RREF.HasValue)
				request.WithQueryParameter("RREF", m3RREF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelMtrlTransResponse>(
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
		/// Name SelPOHBalance
		/// Description Select Projected On Hand Balance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLDT">Planning date (Required)</param>
		/// <param name="m3APIP">APS - policy (Required)</param>
		/// <param name="m3FWLO">Warehouse (Required)</param>
		/// <param name="m3TWLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3IFOR">Include forecast</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelPOHBalanceResponse></returns>
		/// <exception cref="M3Exception<SelPOHBalanceResponse>"></exception>
		public async Task<M3Response<SelPOHBalanceResponse>> SelPOHBalance(
			DateTime m3PLDT, 
			string m3APIP, 
			string m3FWLO, 
			string m3TWLO, 
			int? m3CONO = null, 
			string m3WHGR = null, 
			int? m3IFOR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelPOHBalance",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3APIP))
				throw new ArgumentNullException(nameof(m3APIP));
			if (string.IsNullOrWhiteSpace(m3FWLO))
				throw new ArgumentNullException(nameof(m3FWLO));
			if (string.IsNullOrWhiteSpace(m3TWLO))
				throw new ArgumentNullException(nameof(m3TWLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PLDT", m3PLDT.ToM3String())
				.WithQueryParameter("APIP", m3APIP.Trim())
				.WithQueryParameter("FWLO", m3FWLO.Trim())
				.WithQueryParameter("TWLO", m3TWLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3IFOR.HasValue)
				request.WithQueryParameter("IFOR", m3IFOR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelPOHBalanceResponse>(
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
