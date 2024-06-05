/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.FAS001MI;
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
	/// Name: FAS001MI
	/// Component Name: Financials
	/// Description: Api: Fixed assets
	/// Version Release: 5ea0
	///</summary>
	public partial class FAS001MIResource : M3BaseResourceEndpoint
	{
		public FAS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "FAS001MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAsset
		/// Description AddAsset
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ASID">Fixed asset (Required)</param>
		/// <param name="m3_SBNO">Subnumber (Required)</param>
		/// <param name="m3_FADS">Name (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_ARAT">Exchange rate (Required)</param>
		/// <param name="m3_PPER">Acquisition date (Required)</param>
		/// <param name="m3_FAQT">Fixed asset quantity (Required)</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_FATP">Fixed asset type</param>
		/// <param name="m3_ACAT">Fixed asset group</param>
		/// <param name="m3_LOC1">Location type 1</param>
		/// <param name="m3_LOC2">Location type 2</param>
		/// <param name="m3_LOC3">Location type 3</param>
		/// <param name="m3_SRNO">Serial number</param>
		/// <param name="m3_PINO">GUI picture</param>
		/// <param name="m3_WADT">Warranty date</param>
		/// <param name="m3_SECN">Service agreement</param>
		/// <param name="m3_SECS">Service company</param>
		/// <param name="m3_LCNO">Leasing agreement</param>
		/// <param name="m3_LCCO">Leasing company</param>
		/// <param name="m3_MPER">Manufacturing date</param>
		/// <param name="m3_APER">Activation date</param>
		/// <param name="m3_BPER">Building permit date</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_VSER">Voucher number series</param>
		/// <param name="m3_VONO">Voucher number</param>
		/// <param name="m3_CCCO">Cost of capital method</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_PCDA">Last physical inventory date</param>
		/// <param name="m3_PHCN">Physical inventory number</param>
		/// <param name="m3_PHSN">Physical inventory run number</param>
		/// <param name="m3_PHCT">Physical inventory text</param>
		/// <param name="m3_PHCD">Physical inventory code</param>
		/// <param name="m3_SPER">Sales date</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_CINO">Invoice number</param>
		/// <param name="m3_SCUC">Currency</param>
		/// <param name="m3_SRAT">Exchange rate</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="m3_FRF1">User-defined field 1 - fixed asset</param>
		/// <param name="m3_FRF2">User-defined field 2 - fixed asset</param>
		/// <param name="m3_FRF3">User-defined field 3 - fixed asset</param>
		/// <param name="m3_FRF4">User-defined field 4 - fixed asset</param>
		/// <param name="m3_FRF5">User-defined field 5 - fixed asset</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_LRVD">Last revaluation date</param>
		/// <param name="m3_REDA">Receipt date</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQGR">Equipment group</param>
		/// <param name="m3_GEOX">Geographic code X</param>
		/// <param name="m3_GEOY">Geographic code Y</param>
		/// <param name="m3_GEOZ">Geographic code Z</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAsset(
			string m3_DIVI, 
			string m3_ASID, 
			string m3_SBNO, 
			string m3_FADS, 
			string m3_CUCD, 
			decimal m3_ARAT, 
			DateTime m3_PPER, 
			decimal m3_FAQT, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			string m3_FATP = null, 
			string m3_ACAT = null, 
			string m3_LOC1 = null, 
			string m3_LOC2 = null, 
			string m3_LOC3 = null, 
			string m3_SRNO = null, 
			string m3_PINO = null, 
			DateTime? m3_WADT = null, 
			string m3_SECN = null, 
			string m3_SECS = null, 
			string m3_LCNO = null, 
			string m3_LCCO = null, 
			DateTime? m3_MPER = null, 
			DateTime? m3_APER = null, 
			DateTime? m3_BPER = null, 
			string m3_SPYN = null, 
			string m3_VSER = null, 
			int? m3_VONO = null, 
			string m3_CCCO = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_REAR = null, 
			DateTime? m3_PCDA = null, 
			long? m3_PHCN = null, 
			int? m3_PHSN = null, 
			string m3_PHCT = null, 
			int? m3_PHCD = null, 
			DateTime? m3_SPER = null, 
			string m3_PYNO = null, 
			string m3_CINO = null, 
			string m3_SCUC = null, 
			decimal? m3_SRAT = null, 
			string m3_INNO = null, 
			string m3_FRF1 = null, 
			string m3_FRF2 = null, 
			string m3_FRF3 = null, 
			string m3_FRF4 = null, 
			string m3_FRF5 = null, 
			decimal? m3_TXID = null, 
			DateTime? m3_LRVD = null, 
			DateTime? m3_REDA = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQGR = null, 
			decimal? m3_GEOX = null, 
			decimal? m3_GEOY = null, 
			decimal? m3_GEOZ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAsset",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ASID))
				throw new ArgumentNullException("m3_ASID");
			if (string.IsNullOrWhiteSpace(m3_SBNO))
				throw new ArgumentNullException("m3_SBNO");
			if (string.IsNullOrWhiteSpace(m3_FADS))
				throw new ArgumentNullException("m3_FADS");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("ASID", m3_ASID.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.Trim())
				.WithQueryParameter("FADS", m3_FADS.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("ARAT", m3_ARAT.ToString())
				.WithQueryParameter("PPER", m3_PPER.ToM3String())
				.WithQueryParameter("FAQT", m3_FAQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FATP))
				request.WithQueryParameter("FATP", m3_FATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACAT))
				request.WithQueryParameter("ACAT", m3_ACAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOC1))
				request.WithQueryParameter("LOC1", m3_LOC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOC2))
				request.WithQueryParameter("LOC2", m3_LOC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOC3))
				request.WithQueryParameter("LOC3", m3_LOC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRNO))
				request.WithQueryParameter("SRNO", m3_SRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PINO))
				request.WithQueryParameter("PINO", m3_PINO.Trim());
			if (m3_WADT.HasValue)
				request.WithQueryParameter("WADT", m3_WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SECN))
				request.WithQueryParameter("SECN", m3_SECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SECS))
				request.WithQueryParameter("SECS", m3_SECS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCNO))
				request.WithQueryParameter("LCNO", m3_LCNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCCO))
				request.WithQueryParameter("LCCO", m3_LCCO.Trim());
			if (m3_MPER.HasValue)
				request.WithQueryParameter("MPER", m3_MPER.Value.ToM3String());
			if (m3_APER.HasValue)
				request.WithQueryParameter("APER", m3_APER.Value.ToM3String());
			if (m3_BPER.HasValue)
				request.WithQueryParameter("BPER", m3_BPER.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VSER))
				request.WithQueryParameter("VSER", m3_VSER.Trim());
			if (m3_VONO.HasValue)
				request.WithQueryParameter("VONO", m3_VONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CCCO))
				request.WithQueryParameter("CCCO", m3_CCCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_PCDA.HasValue)
				request.WithQueryParameter("PCDA", m3_PCDA.Value.ToM3String());
			if (m3_PHCN.HasValue)
				request.WithQueryParameter("PHCN", m3_PHCN.Value.ToString());
			if (m3_PHSN.HasValue)
				request.WithQueryParameter("PHSN", m3_PHSN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PHCT))
				request.WithQueryParameter("PHCT", m3_PHCT.Trim());
			if (m3_PHCD.HasValue)
				request.WithQueryParameter("PHCD", m3_PHCD.Value.ToString());
			if (m3_SPER.HasValue)
				request.WithQueryParameter("SPER", m3_SPER.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCUC))
				request.WithQueryParameter("SCUC", m3_SCUC.Trim());
			if (m3_SRAT.HasValue)
				request.WithQueryParameter("SRAT", m3_SRAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF1))
				request.WithQueryParameter("FRF1", m3_FRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF2))
				request.WithQueryParameter("FRF2", m3_FRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF3))
				request.WithQueryParameter("FRF3", m3_FRF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF4))
				request.WithQueryParameter("FRF4", m3_FRF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF5))
				request.WithQueryParameter("FRF5", m3_FRF5.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_LRVD.HasValue)
				request.WithQueryParameter("LRVD", m3_LRVD.Value.ToM3String());
			if (m3_REDA.HasValue)
				request.WithQueryParameter("REDA", m3_REDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGR))
				request.WithQueryParameter("EQGR", m3_EQGR.Trim());
			if (m3_GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3_GEOX.Value.ToString());
			if (m3_GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3_GEOY.Value.ToString());
			if (m3_GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3_GEOZ.Value.ToString());

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
		/// Name GetAsset
		/// Description Get Asset
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ASID">Fixed asset (Required)</param>
		/// <param name="m3_SBNO">Subnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAssetResponse></returns>
		/// <exception cref="M3Exception<GetAssetResponse>"></exception>
		public async Task<M3Response<GetAssetResponse>> GetAsset(
			string m3_DIVI, 
			string m3_ASID, 
			int m3_SBNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAsset",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ASID))
				throw new ArgumentNullException("m3_ASID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("ASID", m3_ASID.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.ToString());

			// Execute the request
			var result = await Execute<GetAssetResponse>(
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
		/// Name GetDeprType
		/// Description Get Depreciation Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ASID">Fixed asset (Required)</param>
		/// <param name="m3_SBNO">Subnumber (Required)</param>
		/// <param name="m3_DPTP">Depreciation type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDeprTypeResponse></returns>
		/// <exception cref="M3Exception<GetDeprTypeResponse>"></exception>
		public async Task<M3Response<GetDeprTypeResponse>> GetDeprType(
			string m3_DIVI, 
			string m3_ASID, 
			int m3_SBNO, 
			int m3_DPTP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDeprType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ASID))
				throw new ArgumentNullException("m3_ASID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("ASID", m3_ASID.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.ToString())
				.WithQueryParameter("DPTP", m3_DPTP.ToString());

			// Execute the request
			var result = await Execute<GetDeprTypeResponse>(
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
		/// Name LstAsset
		/// Description Lst Asset
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ASID">Fixed asset</param>
		/// <param name="m3_SBNO">Subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssetResponse></returns>
		/// <exception cref="M3Exception<LstAssetResponse>"></exception>
		public async Task<M3Response<LstAssetResponse>> LstAsset(
			string m3_DIVI, 
			string m3_ASID = null, 
			int? m3_SBNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAsset",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ASID))
				request.WithQueryParameter("ASID", m3_ASID.Trim());
			if (m3_SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3_SBNO.Value.ToString());

			// Execute the request
			var result = await Execute<LstAssetResponse>(
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
		/// Name LstDeprTypes
		/// Description List Depreciation Types
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ASID">Fixed asset (Required)</param>
		/// <param name="m3_SBNO">Subnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDeprTypesResponse></returns>
		/// <exception cref="M3Exception<LstDeprTypesResponse>"></exception>
		public async Task<M3Response<LstDeprTypesResponse>> LstDeprTypes(
			string m3_DIVI, 
			string m3_ASID, 
			int m3_SBNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDeprTypes",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ASID))
				throw new ArgumentNullException("m3_ASID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("ASID", m3_ASID.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.ToString());

			// Execute the request
			var result = await Execute<LstDeprTypesResponse>(
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
		/// Name UpdateAsset
		/// Description UpdateAsset
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_ASID">Fixed asset (Required)</param>
		/// <param name="m3_SBNO">Subnumber (Required)</param>
		/// <param name="m3_FAST">Status - fixed asset</param>
		/// <param name="m3_FADS">Name</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_FATP">Fixed asset type</param>
		/// <param name="m3_ACAT">Fixed asset group</param>
		/// <param name="m3_LOC1">Location type 1</param>
		/// <param name="m3_LOC2">Location type 2</param>
		/// <param name="m3_LOC3">Location type 3</param>
		/// <param name="m3_SRNO">Serial number</param>
		/// <param name="m3_PINO">GUI picture</param>
		/// <param name="m3_WADT">Warranty date</param>
		/// <param name="m3_SECN">Service agreement</param>
		/// <param name="m3_SECS">Service company</param>
		/// <param name="m3_LCNO">Service company</param>
		/// <param name="m3_LCCO">Leasing company</param>
		/// <param name="m3_MPER">Leasing company</param>
		/// <param name="m3_APER">Activation date</param>
		/// <param name="m3_BPER">Building permit date</param>
		/// <param name="m3_SPYN">Payee</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="m3_PPER">Acquisition date</param>
		/// <param name="m3_CCCO">Cost of capital method</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_PCDA">Last physical inventory date</param>
		/// <param name="m3_PHCN">Physical inventory number</param>
		/// <param name="m3_PHSN">Physical inventory run number</param>
		/// <param name="m3_PHCT">Physical inventory text</param>
		/// <param name="m3_PHCD">Physical inventory code</param>
		/// <param name="m3_SPER">Sales date</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_CINO">Invoice number</param>
		/// <param name="m3_SCUC">Currency</param>
		/// <param name="m3_SRAT">Exchange rate</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="m3_FRF1">User-defined field 1 - fixed asset</param>
		/// <param name="m3_FRF2">User-defined field 2 - fixed asset</param>
		/// <param name="m3_FRF3">User-defined field 3 - fixed asset</param>
		/// <param name="m3_FRF4">User-defined field 4 - fixed asset</param>
		/// <param name="m3_FRF5">User-defined field 5 - fixed asset</param>
		/// <param name="m3_FAQT">Fixed asset quantity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_LRVD">Last revaluation date</param>
		/// <param name="m3_REDA">Receipt date</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQGR">Equipment group</param>
		/// <param name="m3_GEOX">Geographic code X</param>
		/// <param name="m3_GEOY">Geographic code Y</param>
		/// <param name="m3_GEOZ">Geographic code Z</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateAsset(
			string m3_DIVI, 
			string m3_ASID, 
			int m3_SBNO, 
			int? m3_FAST = null, 
			string m3_FADS = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			string m3_FATP = null, 
			string m3_ACAT = null, 
			string m3_LOC1 = null, 
			string m3_LOC2 = null, 
			string m3_LOC3 = null, 
			string m3_SRNO = null, 
			string m3_PINO = null, 
			DateTime? m3_WADT = null, 
			string m3_SECN = null, 
			string m3_SECS = null, 
			string m3_LCNO = null, 
			string m3_LCCO = null, 
			DateTime? m3_MPER = null, 
			DateTime? m3_APER = null, 
			DateTime? m3_BPER = null, 
			string m3_SPYN = null, 
			string m3_CUCD = null, 
			decimal? m3_ARAT = null, 
			DateTime? m3_PPER = null, 
			string m3_CCCO = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_REAR = null, 
			DateTime? m3_PCDA = null, 
			string m3_PHCN = null, 
			string m3_PHSN = null, 
			string m3_PHCT = null, 
			string m3_PHCD = null, 
			DateTime? m3_SPER = null, 
			string m3_PYNO = null, 
			string m3_CINO = null, 
			string m3_SCUC = null, 
			string m3_SRAT = null, 
			string m3_INNO = null, 
			string m3_FRF1 = null, 
			string m3_FRF2 = null, 
			string m3_FRF3 = null, 
			string m3_FRF4 = null, 
			string m3_FRF5 = null, 
			string m3_FAQT = null, 
			string m3_TXID = null, 
			DateTime? m3_LRVD = null, 
			DateTime? m3_REDA = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_EQGR = null, 
			string m3_GEOX = null, 
			string m3_GEOY = null, 
			string m3_GEOZ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdateAsset",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_ASID))
				throw new ArgumentNullException("m3_ASID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("ASID", m3_ASID.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FAST.HasValue)
				request.WithQueryParameter("FAST", m3_FAST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FADS))
				request.WithQueryParameter("FADS", m3_FADS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FATP))
				request.WithQueryParameter("FATP", m3_FATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACAT))
				request.WithQueryParameter("ACAT", m3_ACAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOC1))
				request.WithQueryParameter("LOC1", m3_LOC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOC2))
				request.WithQueryParameter("LOC2", m3_LOC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOC3))
				request.WithQueryParameter("LOC3", m3_LOC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRNO))
				request.WithQueryParameter("SRNO", m3_SRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PINO))
				request.WithQueryParameter("PINO", m3_PINO.Trim());
			if (m3_WADT.HasValue)
				request.WithQueryParameter("WADT", m3_WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SECN))
				request.WithQueryParameter("SECN", m3_SECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SECS))
				request.WithQueryParameter("SECS", m3_SECS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCNO))
				request.WithQueryParameter("LCNO", m3_LCNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCCO))
				request.WithQueryParameter("LCCO", m3_LCCO.Trim());
			if (m3_MPER.HasValue)
				request.WithQueryParameter("MPER", m3_MPER.Value.ToM3String());
			if (m3_APER.HasValue)
				request.WithQueryParameter("APER", m3_APER.Value.ToM3String());
			if (m3_BPER.HasValue)
				request.WithQueryParameter("BPER", m3_BPER.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SPYN))
				request.WithQueryParameter("SPYN", m3_SPYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());
			if (m3_PPER.HasValue)
				request.WithQueryParameter("PPER", m3_PPER.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CCCO))
				request.WithQueryParameter("CCCO", m3_CCCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_PCDA.HasValue)
				request.WithQueryParameter("PCDA", m3_PCDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PHCN))
				request.WithQueryParameter("PHCN", m3_PHCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHSN))
				request.WithQueryParameter("PHSN", m3_PHSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHCT))
				request.WithQueryParameter("PHCT", m3_PHCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHCD))
				request.WithQueryParameter("PHCD", m3_PHCD.Trim());
			if (m3_SPER.HasValue)
				request.WithQueryParameter("SPER", m3_SPER.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCUC))
				request.WithQueryParameter("SCUC", m3_SCUC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRAT))
				request.WithQueryParameter("SRAT", m3_SRAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF1))
				request.WithQueryParameter("FRF1", m3_FRF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF2))
				request.WithQueryParameter("FRF2", m3_FRF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF3))
				request.WithQueryParameter("FRF3", m3_FRF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF4))
				request.WithQueryParameter("FRF4", m3_FRF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF5))
				request.WithQueryParameter("FRF5", m3_FRF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FAQT))
				request.WithQueryParameter("FAQT", m3_FAQT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXID))
				request.WithQueryParameter("TXID", m3_TXID.Trim());
			if (m3_LRVD.HasValue)
				request.WithQueryParameter("LRVD", m3_LRVD.Value.ToM3String());
			if (m3_REDA.HasValue)
				request.WithQueryParameter("REDA", m3_REDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGR))
				request.WithQueryParameter("EQGR", m3_EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GEOX))
				request.WithQueryParameter("GEOX", m3_GEOX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GEOY))
				request.WithQueryParameter("GEOY", m3_GEOY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GEOZ))
				request.WithQueryParameter("GEOZ", m3_GEOZ.Trim());

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
