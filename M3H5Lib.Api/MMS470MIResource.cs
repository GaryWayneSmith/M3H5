/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS470MI;
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
	/// Name: MMS470MI
	/// Component Name: Packages
	/// Description: Package Interface
	/// Version Release: 5ea3
	///</summary>
	public partial class MMS470MIResource : M3BaseResourceEndpoint
	{
		public MMS470MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS470MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPackStk
		/// Description Add Package in Stock
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_PACT">Packaging (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPackStkResponse></returns>
		/// <exception cref="M3Exception<AddPackStkResponse>"></exception>
		public async Task<M3Response<AddPackStkResponse>> AddPackStk(
			string m3_PACT, 
			int? m3_CONO = null, 
			string m3_PANR = null, 
			string m3_SSCC = null, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPackStk",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PACT))
				throw new ArgumentNullException("m3_PACT");

			// Set mandatory parameters
			request
				.WithQueryParameter("PACT", m3_PACT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<AddPackStkResponse>(
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
		/// Name CalcPackLevel
		/// Description Calculates the package level
		/// Version Release: 15.*
		/// </summary>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CalcPackLevel(
			string m3_PANR = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CalcPackLevel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

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
		/// Name ChangePackStk
		/// Description Change Package in Stock
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_PAII">Included in package number</param>
		/// <param name="m3_SORT">Sort value</param>
		/// <param name="m3_PACU">Bulk package</param>
		/// <param name="m3_GRTP">Packaging code</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_DLRM">Remark</param>
		/// <param name="m3_DLMO">Goods mark Odette standard</param>
		/// <param name="m3_ETRN">External tracking number</param>
		/// <param name="m3_GWTM">Actual gross weight</param>
		/// <param name="m3_VLMM">Actual volume</param>
		/// <param name="m3_FRCM">Actual quantity in free unit</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_PPNB">Pre-pack number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_PAN1">Package alias 1</param>
		/// <param name="m3_PAN2">Package alias 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangePackStk(
			int? m3_CONO = null, 
			string m3_PANR = null, 
			string m3_PAII = null, 
			string m3_SORT = null, 
			int? m3_PACU = null, 
			string m3_GRTP = null, 
			string m3_PACT = null, 
			string m3_DLRM = null, 
			string m3_DLMO = null, 
			string m3_ETRN = null, 
			decimal? m3_GWTM = null, 
			decimal? m3_VLMM = null, 
			decimal? m3_FRCM = null, 
			string m3_BANO = null, 
			string m3_PPNB = null, 
			string m3_SSCC = null, 
			string m3_PAN1 = null, 
			string m3_PAN2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChangePackStk",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAII))
				request.WithQueryParameter("PAII", m3_PAII.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORT))
				request.WithQueryParameter("SORT", m3_SORT.Trim());
			if (m3_PACU.HasValue)
				request.WithQueryParameter("PACU", m3_PACU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRTP))
				request.WithQueryParameter("GRTP", m3_GRTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLRM))
				request.WithQueryParameter("DLRM", m3_DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLMO))
				request.WithQueryParameter("DLMO", m3_DLMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETRN))
				request.WithQueryParameter("ETRN", m3_ETRN.Trim());
			if (m3_GWTM.HasValue)
				request.WithQueryParameter("GWTM", m3_GWTM.Value.ToString());
			if (m3_VLMM.HasValue)
				request.WithQueryParameter("VLMM", m3_VLMM.Value.ToString());
			if (m3_FRCM.HasValue)
				request.WithQueryParameter("FRCM", m3_FRCM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PPNB))
				request.WithQueryParameter("PPNB", m3_PPNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAN1))
				request.WithQueryParameter("PAN1", m3_PAN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAN2))
				request.WithQueryParameter("PAN2", m3_PAN2.Trim());

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
		/// Name ConPacStkNoCalc
		/// Description Connect packages in stock (Without package recalculation)
		/// Version Release: 15.*
		/// </summary>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_PAII">Included in package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConPacStkNoCalcResponse></returns>
		/// <exception cref="M3Exception<ConPacStkNoCalcResponse>"></exception>
		public async Task<M3Response<ConPacStkNoCalcResponse>> ConPacStkNoCalc(
			string m3_PANR = null, 
			string m3_PACT = null, 
			string m3_PAII = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConPacStkNoCalc",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAII))
				request.WithQueryParameter("PAII", m3_PAII.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<ConPacStkNoCalcResponse>(
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
		/// Name ConnectPackStk
		/// Description Connect packages in stock
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_PAII">Included in package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConnectPackStkResponse></returns>
		/// <exception cref="M3Exception<ConnectPackStkResponse>"></exception>
		public async Task<M3Response<ConnectPackStkResponse>> ConnectPackStk(
			int? m3_CONO = null, 
			string m3_PANR = null, 
			string m3_PACT = null, 
			string m3_PAII = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConnectPackStk",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAII))
				request.WithQueryParameter("PAII", m3_PAII.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<ConnectPackStkResponse>(
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
		/// Name DeletePackStk
		/// Description Delete Package in Stock
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeletePackStk(
			int? m3_CONO = null, 
			string m3_PANR = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeletePackStk",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

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
		/// Name GetPackageStk
		/// Description Get packages in Stock
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPackageStkResponse></returns>
		/// <exception cref="M3Exception<GetPackageStkResponse>"></exception>
		public async Task<M3Response<GetPackageStkResponse>> GetPackageStk(
			int? m3_CONO = null, 
			string m3_PANR = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPackageStk",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<GetPackageStkResponse>(
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
		/// Name LstPackStkCont
		/// Description List Stocked Package Content
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackStkContResponse></returns>
		/// <exception cref="M3Exception<LstPackStkContResponse>"></exception>
		public async Task<M3Response<LstPackStkContResponse>> LstPackStkCont(
			int? m3_CONO = null, 
			string m3_PANR = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackStkCont",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<LstPackStkContResponse>(
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
		/// Name LstPackageStk
		/// Description List packages in Stock
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackageStkResponse></returns>
		/// <exception cref="M3Exception<LstPackageStkResponse>"></exception>
		public async Task<M3Response<LstPackageStkResponse>> LstPackageStk(
			int? m3_CONO = null, 
			string m3_PANR = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackageStk",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<LstPackageStkResponse>(
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
		/// Name PrintPackage
		/// Description Print Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_DEV0">Printer</param>
		/// <param name="m3_COPY">Number of copies</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintPackage(
			int? m3_CONO = null, 
			string m3_PANR = null, 
			string m3_DEV0 = null, 
			int? m3_COPY = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrintPackage",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEV0))
				request.WithQueryParameter("DEV0", m3_DEV0.Trim());
			if (m3_COPY.HasValue)
				request.WithQueryParameter("COPY", m3_COPY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

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
		/// Name UnpackPackage
		/// Description Unpack a specific package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UnpackPackage(
			int? m3_CONO = null, 
			string m3_PANR = null, 
			string m3_SSCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UnpackPackage",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

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
