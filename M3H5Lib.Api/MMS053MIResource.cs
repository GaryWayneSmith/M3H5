/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS053MI;
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
	/// Name: MMS053MI
	/// Component Name: Supply Chain Execution
	/// Description: Packagining/Customer Item interface
	/// Version Release: 5ea0
	///</summary>
	public partial class MMS053MIResource : M3BaseResourceEndpoint
	{
		public MMS053MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS053MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItemConnPkg
		/// Description Add Item connect to packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRQT">Quantity (Required)</param>
		/// <param name="m3_TEPA">Packagingterms</param>
		/// <param name="m3_ITNO">Itemnumber</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_ADID">Addressnumber</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_CUPA">Customers packaging identity</param>
		/// <param name="m3_GRTP">Packagingcode</param>
		/// <param name="m3_D1QT">Standardquantity</param>
		/// <param name="m3_D2QT">Minimumquantity</param>
		/// <param name="m3_D3QT">Maximumquantity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItemConnPkg(
			decimal m3_TRQT, 
			string m3_TEPA = null, 
			string m3_ITNO = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			string m3_PACT = null, 
			string m3_CUPA = null, 
			string m3_GRTP = null, 
			decimal? m3_D1QT = null, 
			decimal? m3_D2QT = null, 
			decimal? m3_D3QT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItemConnPkg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQT", m3_TRQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTP))
				request.WithQueryParameter("GRTP", m3_GRTP.Trim());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (m3_D2QT.HasValue)
				request.WithQueryParameter("D2QT", m3_D2QT.Value.ToString());
			if (m3_D3QT.HasValue)
				request.WithQueryParameter("D3QT", m3_D3QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

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
		/// Name DelItemConnPkg
		/// Description Delete Item connect to packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRQT">Quantity (Required)</param>
		/// <param name="m3_TEPA">Packagingterms</param>
		/// <param name="m3_ITNO">Itemnumber</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_ADID">Addressnumber</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelItemConnPkg(
			decimal m3_TRQT, 
			string m3_TEPA = null, 
			string m3_ITNO = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelItemConnPkg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQT", m3_TRQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

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
		/// Name GetConnPerPkg
		/// Description Get Item connects to per packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRQT">Quantity (Required)</param>
		/// <param name="m3_TEPA">Packagingterms</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_ADID">Addressnumber</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetConnPerPkgResponse></returns>
		/// <exception cref="M3Exception<GetConnPerPkgResponse>"></exception>
		public async Task<M3Response<GetConnPerPkgResponse>> GetConnPerPkg(
			decimal m3_TRQT, 
			string m3_TEPA = null, 
			string m3_PACT = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetConnPerPkg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQT", m3_TRQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<GetConnPerPkgResponse>(
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
		/// Name GetItemConnPkg
		/// Description Get Item connect to packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRQT">Quantity (Required)</param>
		/// <param name="m3_TEPA">Packagingterms</param>
		/// <param name="m3_ITNO">Itemnumber</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_ADID">Addressnumber</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemConnPkgResponse></returns>
		/// <exception cref="M3Exception<GetItemConnPkgResponse>"></exception>
		public async Task<M3Response<GetItemConnPkgResponse>> GetItemConnPkg(
			decimal m3_TRQT, 
			string m3_TEPA = null, 
			string m3_ITNO = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItemConnPkg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQT", m3_TRQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<GetItemConnPkgResponse>(
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
		/// Name GetPkgItemGrp
		/// Description Get Item connect to per item group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRQT">Quantity (Required)</param>
		/// <param name="m3_TEPA">Packagingterms</param>
		/// <param name="m3_ITGR">Itemgroup</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_ADID">Addressnumber</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPkgItemGrpResponse></returns>
		/// <exception cref="M3Exception<GetPkgItemGrpResponse>"></exception>
		public async Task<M3Response<GetPkgItemGrpResponse>> GetPkgItemGrp(
			decimal m3_TRQT, 
			string m3_TEPA = null, 
			string m3_ITGR = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPkgItemGrp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQT", m3_TRQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<GetPkgItemGrpResponse>(
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
		/// Name LstConnPerPkg
		/// Description List Items connect to per packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TEPA">Packagingterms</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_ADID">Addressnumber</param>
		/// <param name="m3_TRQT">Quantity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConnPerPkgResponse></returns>
		/// <exception cref="M3Exception<LstConnPerPkgResponse>"></exception>
		public async Task<M3Response<LstConnPerPkgResponse>> LstConnPerPkg(
			string m3_TEPA = null, 
			string m3_PACT = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			decimal? m3_TRQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstConnPerPkg",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<LstConnPerPkgResponse>(
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
		/// Name LstItemConnPkg
		/// Description List Items connect to packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TEPA">Packagingterms</param>
		/// <param name="m3_ITNO">Itemnumber</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_ADID">Addressnumber</param>
		/// <param name="m3_TRQT">Quantity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemConnPkgResponse></returns>
		/// <exception cref="M3Exception<LstItemConnPkgResponse>"></exception>
		public async Task<M3Response<LstItemConnPkgResponse>> LstItemConnPkg(
			string m3_TEPA = null, 
			string m3_ITNO = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			decimal? m3_TRQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItemConnPkg",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<LstItemConnPkgResponse>(
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
		/// Name LstPkgItemGrp
		/// Description List Items connect to per item group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TEPA">Packagingterms</param>
		/// <param name="m3_ITGR">Itemgroup</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_ADID">Addressnumber</param>
		/// <param name="m3_TRQT">Quantity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPkgItemGrpResponse></returns>
		/// <exception cref="M3Exception<LstPkgItemGrpResponse>"></exception>
		public async Task<M3Response<LstPkgItemGrpResponse>> LstPkgItemGrp(
			string m3_TEPA = null, 
			string m3_ITGR = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			decimal? m3_TRQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPkgItemGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<LstPkgItemGrpResponse>(
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
		/// Name RtvConnPkg
		/// Description Retrieve connected package
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvConnPkgResponse></returns>
		/// <exception cref="M3Exception<RtvConnPkgResponse>"></exception>
		public async Task<M3Response<RtvConnPkgResponse>> RtvConnPkg(
			string m3_ITNO, 
			decimal m3_TRQT, 
			string m3_WHLO = null, 
			string m3_TEPA = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RtvConnPkg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("TRQT", m3_TRQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());

			// Execute the request
			var result = await Execute<RtvConnPkgResponse>(
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
		/// Name RtvPkgByOrd
		/// Description RtvPkgByOrd
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_TTYP">Stock transaction type</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvPkgByOrdResponse></returns>
		/// <exception cref="M3Exception<RtvPkgByOrdResponse>"></exception>
		public async Task<M3Response<RtvPkgByOrdResponse>> RtvPkgByOrd(
			string m3_WHLO = null, 
			int? m3_TTYP = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			int? m3_RIDO = null, 
			decimal? m3_PLRN = null, 
			decimal? m3_TRQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RtvPkgByOrd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3_TTYP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());

			// Execute the request
			var result = await Execute<RtvPkgByOrdResponse>(
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
		/// Name UpdItemConnPkg
		/// Description Updates Item connect to packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRQT">Quantity (Required)</param>
		/// <param name="m3_TEPA">Packagingterms</param>
		/// <param name="m3_ITNO">Itemnumber</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_ADID">Addressnumber</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_CUPA">Customers packaging identity</param>
		/// <param name="m3_GRTP">Packagingcode</param>
		/// <param name="m3_D1QT">Standardquantity</param>
		/// <param name="m3_D2QT">Minimumquantity</param>
		/// <param name="m3_D3QT">Maximumquantity</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItemConnPkg(
			decimal m3_TRQT, 
			string m3_TEPA = null, 
			string m3_ITNO = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			string m3_PACT = null, 
			string m3_CUPA = null, 
			string m3_GRTP = null, 
			int? m3_D1QT = null, 
			int? m3_D2QT = null, 
			int? m3_D3QT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItemConnPkg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQT", m3_TRQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTP))
				request.WithQueryParameter("GRTP", m3_GRTP.Trim());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (m3_D2QT.HasValue)
				request.WithQueryParameter("D2QT", m3_D2QT.Value.ToString());
			if (m3_D3QT.HasValue)
				request.WithQueryParameter("D3QT", m3_D3QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

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
