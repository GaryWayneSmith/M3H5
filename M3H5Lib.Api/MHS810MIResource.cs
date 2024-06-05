/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MHS810MI;
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
	/// Name: MHS810MI
	/// Component Name: PickingListDownload
	/// Description: Picking list download interface
	/// Version Release: 14.x
	///</summary>
	public partial class MHS810MIResource : M3BaseResourceEndpoint
	{
		public MHS810MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS810MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ListDetByWave
		/// Description Process Wave Picking List Download
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PLRI">Wave number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListDetByWaveResponse></returns>
		/// <exception cref="M3Exception<ListDetByWaveResponse>"></exception>
		public async Task<M3Response<ListDetByWaveResponse>> ListDetByWave(
			string m3E0PA, 
			string m3WHLO, 
			string m3PLRI, 
			int? m3CONO = null, 
			int? m3DOWN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListDetByWave",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PLRI))
				throw new ArgumentNullException(nameof(m3PLRI));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PLRI", m3PLRI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListDetByWaveResponse>(
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
		/// Name LstPickAssign
		/// Description List Pick Assingment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="m3PICK">Picker</param>
		/// <param name="m3NUM3">Number of pick lists to download</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickAssignResponse></returns>
		/// <exception cref="M3Exception<LstPickAssignResponse>"></exception>
		public async Task<M3Response<LstPickAssignResponse>> LstPickAssign(
			string m3E0PA, 
			string m3WHLO, 
			int? m3CONO = null, 
			string m3SLTP = null, 
			string m3PISE = null, 
			string m3PICK = null, 
			int? m3NUM3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPickAssign",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PICK))
				request.WithQueryParameter("PICK", m3PICK.Trim());
			if (m3NUM3.HasValue)
				request.WithQueryParameter("NUM3", m3NUM3.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPickAssignResponse>(
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
		/// Name LstPickDetail
		/// Description Picking List Detail Download
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DLIX">Delivery index</param>
		/// <param name="m3PLSX">Pick list suffix</param>
		/// <param name="m3TTYP">Transaction type</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickDetailResponse></returns>
		/// <exception cref="M3Exception<LstPickDetailResponse>"></exception>
		public async Task<M3Response<LstPickDetailResponse>> LstPickDetail(
			string m3E0PA, 
			int? m3CONO = null, 
			string m3WHLO = null, 
			decimal? m3DLIX = null, 
			int? m3PLSX = null, 
			int? m3TTYP = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			int? m3RIDO = null, 
			int? m3DOWN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPickDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3TTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3RIDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPickDetailResponse>(
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
		/// Description Picking List Download
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DLIX">Delivery Index</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickListResponse></returns>
		/// <exception cref="M3Exception<LstPickListResponse>"></exception>
		public async Task<M3Response<LstPickListResponse>> LstPickList(
			string m3E0PA, 
			string m3WHLO, 
			int? m3CONO = null, 
			decimal? m3DLIX = null, 
			int? m3PLSX = null, 
			int? m3DOWN = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name LstPickListAdr
		/// Description Get Picking List Address Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickListAdrResponse></returns>
		/// <exception cref="M3Exception<LstPickListAdrResponse>"></exception>
		public async Task<M3Response<LstPickListAdrResponse>> LstPickListAdr(
			string m3E0PA, 
			string m3WHLO, 
			decimal m3DLIX, 
			int? m3CONO = null, 
			int? m3PLSX = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			int? m3ADRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPickListAdr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPickListAdrResponse>(
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
		/// Name LstPickListTxt
		/// Description Picking List Text Download
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DLIX">Delivery index</param>
		/// <param name="m3PLSX">Pick list suffix</param>
		/// <param name="m3TTYP">Transaction type</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3LINO">Line number</param>
		/// <param name="m3DOWN">Download</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPickListTxtResponse></returns>
		/// <exception cref="M3Exception<LstPickListTxtResponse>"></exception>
		public async Task<M3Response<LstPickListTxtResponse>> LstPickListTxt(
			string m3E0PA, 
			int? m3CONO = null, 
			string m3WHLO = null, 
			decimal? m3DLIX = null, 
			int? m3PLSX = null, 
			int? m3TTYP = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			int? m3RIDO = null, 
			decimal? m3TXID = null, 
			string m3TXVR = null, 
			string m3LNCD = null, 
			int? m3LINO = null, 
			int? m3DOWN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPickListTxt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3TTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3RIDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3LINO.HasValue)
				request.WithQueryParameter("LINO", m3LINO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPickListTxtResponse>(
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
		/// Name LstPkLsByShip
		/// Description Process Shipment Picking List Download
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPkLsByShipResponse></returns>
		/// <exception cref="M3Exception<LstPkLsByShipResponse>"></exception>
		public async Task<M3Response<LstPkLsByShipResponse>> LstPkLsByShip(
			string m3E0PA, 
			int m3CONN, 
			int? m3CONO = null, 
			string m3WHLO = null, 
			int? m3DOWN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPkLsByShip",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPkLsByShipResponse>(
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
		/// Name PrcPickList
		/// Description Process Picking List Download
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3DLIX">Delivery index (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcPickList(
			string m3E0PA, 
			string m3WHLO, 
			decimal m3DLIX, 
			int m3PLSX, 
			int? m3CONO = null, 
			int? m3DOWN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrcPickList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name PrcPickListDet
		/// Description Process Picking List Detailed Download
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3E0PA">Partner (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3TTYP">Stock transaction type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3DOWN">0/Blank=Unprocessed, 1=Processed</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcPickListDet(
			string m3E0PA, 
			string m3WHLO, 
			decimal m3DLIX, 
			int m3PLSX, 
			int m3TTYP, 
			string m3RIDN, 
			int m3RIDL, 
			int? m3CONO = null, 
			int? m3RIDX = null, 
			int? m3RIDO = null, 
			int? m3DOWN = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrcPickListDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0PA))
				throw new ArgumentNullException(nameof(m3E0PA));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3E0PA.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3RIDO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3DOWN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());

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
