/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItemConnPkg
		/// Description Add Item connect to packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRQT">Quantity (Required)</param>
		/// <param name="m3TEPA">Packagingterms</param>
		/// <param name="m3ITNO">Itemnumber</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3ADID">Addressnumber</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3CUPA">Customers packaging identity</param>
		/// <param name="m3GRTP">Packagingcode</param>
		/// <param name="m3D1QT">Standardquantity</param>
		/// <param name="m3D2QT">Minimumquantity</param>
		/// <param name="m3D3QT">Maximumquantity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItemConnPkg(
			decimal m3TRQT, 
			string m3TEPA = null, 
			string m3ITNO = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			string m3PACT = null, 
			string m3CUPA = null, 
			string m3GRTP = null, 
			decimal? m3D1QT = null, 
			decimal? m3D2QT = null, 
			decimal? m3D3QT = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddItemConnPkg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQT", m3TRQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRTP))
				request.WithQueryParameter("GRTP", m3GRTP.Trim());
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D2QT.HasValue)
				request.WithQueryParameter("D2QT", m3D2QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D3QT.HasValue)
				request.WithQueryParameter("D3QT", m3D3QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

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
		/// Name DelItemConnPkg
		/// Description Delete Item connect to packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRQT">Quantity (Required)</param>
		/// <param name="m3TEPA">Packagingterms</param>
		/// <param name="m3ITNO">Itemnumber</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3ADID">Addressnumber</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelItemConnPkg(
			decimal m3TRQT, 
			string m3TEPA = null, 
			string m3ITNO = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelItemConnPkg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQT", m3TRQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

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
		/// Name GetConnPerPkg
		/// Description Get Item connects to per packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRQT">Quantity (Required)</param>
		/// <param name="m3TEPA">Packagingterms</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3ADID">Addressnumber</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetConnPerPkgResponse></returns>
		/// <exception cref="M3Exception<GetConnPerPkgResponse>"></exception>
		public async Task<M3Response<GetConnPerPkgResponse>> GetConnPerPkg(
			decimal m3TRQT, 
			string m3TEPA = null, 
			string m3PACT = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetConnPerPkg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQT", m3TRQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<GetConnPerPkgResponse>(
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
		/// Name GetItemConnPkg
		/// Description Get Item connect to packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRQT">Quantity (Required)</param>
		/// <param name="m3TEPA">Packagingterms</param>
		/// <param name="m3ITNO">Itemnumber</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3ADID">Addressnumber</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemConnPkgResponse></returns>
		/// <exception cref="M3Exception<GetItemConnPkgResponse>"></exception>
		public async Task<M3Response<GetItemConnPkgResponse>> GetItemConnPkg(
			decimal m3TRQT, 
			string m3TEPA = null, 
			string m3ITNO = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetItemConnPkg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQT", m3TRQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<GetItemConnPkgResponse>(
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
		/// Name GetPkgItemGrp
		/// Description Get Item connect to per item group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRQT">Quantity (Required)</param>
		/// <param name="m3TEPA">Packagingterms</param>
		/// <param name="m3ITGR">Itemgroup</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3ADID">Addressnumber</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPkgItemGrpResponse></returns>
		/// <exception cref="M3Exception<GetPkgItemGrpResponse>"></exception>
		public async Task<M3Response<GetPkgItemGrpResponse>> GetPkgItemGrp(
			decimal m3TRQT, 
			string m3TEPA = null, 
			string m3ITGR = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPkgItemGrp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQT", m3TRQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<GetPkgItemGrpResponse>(
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
		/// Name LstConnPerPkg
		/// Description List Items connect to per packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TEPA">Packagingterms</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3ADID">Addressnumber</param>
		/// <param name="m3TRQT">Quantity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConnPerPkgResponse></returns>
		/// <exception cref="M3Exception<LstConnPerPkgResponse>"></exception>
		public async Task<M3Response<LstConnPerPkgResponse>> LstConnPerPkg(
			string m3TEPA = null, 
			string m3PACT = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			decimal? m3TRQT = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstConnPerPkg",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<LstConnPerPkgResponse>(
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
		/// Name LstItemConnPkg
		/// Description List Items connect to packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TEPA">Packagingterms</param>
		/// <param name="m3ITNO">Itemnumber</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3ADID">Addressnumber</param>
		/// <param name="m3TRQT">Quantity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemConnPkgResponse></returns>
		/// <exception cref="M3Exception<LstItemConnPkgResponse>"></exception>
		public async Task<M3Response<LstItemConnPkgResponse>> LstItemConnPkg(
			string m3TEPA = null, 
			string m3ITNO = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			decimal? m3TRQT = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItemConnPkg",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<LstItemConnPkgResponse>(
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
		/// Name LstPkgItemGrp
		/// Description List Items connect to per item group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TEPA">Packagingterms</param>
		/// <param name="m3ITGR">Itemgroup</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3ADID">Addressnumber</param>
		/// <param name="m3TRQT">Quantity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPkgItemGrpResponse></returns>
		/// <exception cref="M3Exception<LstPkgItemGrpResponse>"></exception>
		public async Task<M3Response<LstPkgItemGrpResponse>> LstPkgItemGrp(
			string m3TEPA = null, 
			string m3ITGR = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			decimal? m3TRQT = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPkgItemGrp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<LstPkgItemGrpResponse>(
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
		/// Name RtvConnPkg
		/// Description Retrieve connected package
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M (Required)</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvConnPkgResponse></returns>
		/// <exception cref="M3Exception<RtvConnPkgResponse>"></exception>
		public async Task<M3Response<RtvConnPkgResponse>> RtvConnPkg(
			string m3ITNO, 
			decimal m3TRQT, 
			string m3WHLO = null, 
			string m3TEPA = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RtvConnPkg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("TRQT", m3TRQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());

			// Execute the request
			var result = await Execute<RtvConnPkgResponse>(
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
		/// Name RtvPkgByOrd
		/// Description RtvPkgByOrd
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3TTYP">Stock transaction type</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3RIDO">Order operation</param>
		/// <param name="m3PLRN">Reporting number - pick line</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvPkgByOrdResponse></returns>
		/// <exception cref="M3Exception<RtvPkgByOrdResponse>"></exception>
		public async Task<M3Response<RtvPkgByOrdResponse>> RtvPkgByOrd(
			string m3WHLO = null, 
			int? m3TTYP = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			int? m3RIDO = null, 
			decimal? m3PLRN = null, 
			decimal? m3TRQT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RtvPkgByOrd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
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
			if (m3PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3PLRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<RtvPkgByOrdResponse>(
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
		/// Name UpdItemConnPkg
		/// Description Updates Item connect to packaging
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TRQT">Quantity (Required)</param>
		/// <param name="m3TEPA">Packagingterms</param>
		/// <param name="m3ITNO">Itemnumber</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3ADID">Addressnumber</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3CUPA">Customers packaging identity</param>
		/// <param name="m3GRTP">Packagingcode</param>
		/// <param name="m3D1QT">Standardquantity</param>
		/// <param name="m3D2QT">Minimumquantity</param>
		/// <param name="m3D3QT">Maximumquantity</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItemConnPkg(
			decimal m3TRQT, 
			string m3TEPA = null, 
			string m3ITNO = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			string m3PACT = null, 
			string m3CUPA = null, 
			string m3GRTP = null, 
			int? m3D1QT = null, 
			int? m3D2QT = null, 
			int? m3D3QT = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdItemConnPkg",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("TRQT", m3TRQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRTP))
				request.WithQueryParameter("GRTP", m3GRTP.Trim());
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D2QT.HasValue)
				request.WithQueryParameter("D2QT", m3D2QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D3QT.HasValue)
				request.WithQueryParameter("D3QT", m3D3QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

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
