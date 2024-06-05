/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS423MI;
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
	/// Name: MWS423MI
	/// Component Name: Packages
	/// Description: Package Interface
	/// Version Release: 5ea2
	///</summary>
	public partial class MWS423MIResource : M3BaseResourceEndpoint
	{
		public MWS423MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS423MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPackage
		/// Description Add Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_NBPA">Number of packages</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_PAII">Included in package number</param>
		/// <param name="m3_SORT">Sort value</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_GRTP">Packaging code</param>
		/// <param name="m3_DLRM">Remark</param>
		/// <param name="m3_DLMO">Goods mark Odette standard</param>
		/// <param name="m3_ETRN">External tracking number</param>
		/// <param name="m3_PACU">Bulk package</param>
		/// <param name="m3_GWTM">Actual gross weight</param>
		/// <param name="m3_VLMM">Actual volume</param>
		/// <param name="m3_FRCM">Actual quantity in free unit</param>
		/// <param name="m3_PACL">Packaging length</param>
		/// <param name="m3_PACH">Packaging height</param>
		/// <param name="m3_PACW">Packaging width</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPackageResponse></returns>
		/// <exception cref="M3Exception<AddPackageResponse>"></exception>
		public async Task<M3Response<AddPackageResponse>> AddPackage(
			decimal m3_DLIX, 
			int? m3_CONO = null, 
			int? m3_NBPA = null, 
			string m3_PANR = null, 
			string m3_PAII = null, 
			string m3_SORT = null, 
			string m3_PACT = null, 
			string m3_GRTP = null, 
			string m3_DLRM = null, 
			string m3_DLMO = null, 
			string m3_ETRN = null, 
			int? m3_PACU = null, 
			decimal? m3_GWTM = null, 
			decimal? m3_VLMM = null, 
			decimal? m3_FRCM = null, 
			int? m3_PACL = null, 
			int? m3_PACH = null, 
			int? m3_PACW = null, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPackage",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_NBPA.HasValue)
				request.WithQueryParameter("NBPA", m3_NBPA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAII))
				request.WithQueryParameter("PAII", m3_PAII.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORT))
				request.WithQueryParameter("SORT", m3_SORT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTP))
				request.WithQueryParameter("GRTP", m3_GRTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLRM))
				request.WithQueryParameter("DLRM", m3_DLRM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLMO))
				request.WithQueryParameter("DLMO", m3_DLMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETRN))
				request.WithQueryParameter("ETRN", m3_ETRN.Trim());
			if (m3_PACU.HasValue)
				request.WithQueryParameter("PACU", m3_PACU.Value.ToString());
			if (m3_GWTM.HasValue)
				request.WithQueryParameter("GWTM", m3_GWTM.Value.ToString());
			if (m3_VLMM.HasValue)
				request.WithQueryParameter("VLMM", m3_VLMM.Value.ToString());
			if (m3_FRCM.HasValue)
				request.WithQueryParameter("FRCM", m3_FRCM.Value.ToString());
			if (m3_PACL.HasValue)
				request.WithQueryParameter("PACL", m3_PACL.Value.ToString());
			if (m3_PACH.HasValue)
				request.WithQueryParameter("PACH", m3_PACH.Value.ToString());
			if (m3_PACW.HasValue)
				request.WithQueryParameter("PACW", m3_PACW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<AddPackageResponse>(
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
		/// Name AddPckToShpPck
		/// Description Add Package To Shipment Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_SSC1">SSCC number MPTRNS</param>
		/// <param name="m3_SPNO">Shipment package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPckToShpPck(
			string m3_PANR = null, 
			decimal? m3_DLIX = null, 
			string m3_SSC1 = null, 
			string m3_SPNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPckToShpPck",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSC1))
				request.WithQueryParameter("SSC1", m3_SSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPNO))
				request.WithQueryParameter("SPNO", m3_SPNO.Trim());
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
		/// Name ChangePackage
		/// Description Change Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DLIX">Delivery number</param>
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
		/// <param name="m3_PGRS">Delivery status</param>
		/// <param name="m3_PACL">Packaging length</param>
		/// <param name="m3_PACW">Packaging width</param>
		/// <param name="m3_PACH">Packaging height</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangePackage(
			int? m3_CONO = null, 
			decimal? m3_DLIX = null, 
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
			string m3_PGRS = null, 
			int? m3_PACL = null, 
			int? m3_PACW = null, 
			int? m3_PACH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChangePackage",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_PGRS))
				request.WithQueryParameter("PGRS", m3_PGRS.Trim());
			if (m3_PACL.HasValue)
				request.WithQueryParameter("PACL", m3_PACL.Value.ToString());
			if (m3_PACW.HasValue)
				request.WithQueryParameter("PACW", m3_PACW.Value.ToString());
			if (m3_PACH.HasValue)
				request.WithQueryParameter("PACH", m3_PACH.Value.ToString());
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
		/// Name ChgPackageConn
		/// Description Change package connection
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_PAI1">Included in package number</param>
		/// <param name="m3_PAI2">Included in package number</param>
		/// <param name="m3_PAI3">Included in package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgPackageConn(
			int? m3_CONO = null, 
			decimal? m3_DLIX = null, 
			string m3_PANR = null, 
			string m3_PAI1 = null, 
			string m3_PAI2 = null, 
			string m3_PAI3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgPackageConn",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAI1))
				request.WithQueryParameter("PAI1", m3_PAI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAI2))
				request.WithQueryParameter("PAI2", m3_PAI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAI3))
				request.WithQueryParameter("PAI3", m3_PAI3.Trim());
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
		/// Name ConnectPackages
		/// Description Connect packages in package structure
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_GRTP">Packaging code</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_PACI">Packaging</param>
		/// <param name="m3_PAII">Included in package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConnectPackages(
			int? m3_CONO = null, 
			decimal? m3_DLIX = null, 
			string m3_PACT = null, 
			string m3_GRTP = null, 
			string m3_PANR = null, 
			string m3_PACI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConnectPackages",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRTP))
				request.WithQueryParameter("GRTP", m3_GRTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACI))
				request.WithQueryParameter("PACI", m3_PACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAII))
				request.WithQueryParameter("PAII", m3_PAII.Trim());
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
		/// Name DltPackage
		/// Description Delete Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPackage(
			int? m3_CONO = null, 
			decimal? m3_DLIX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPackage",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
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
		/// Name GenPackDetail
		/// Description Generate package details when simple or no pack
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INOU">Direction (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> GenPackDetail(
			int m3_INOU, 
			decimal m3_DLIX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GenPackDetail",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INOU", m3_INOU.ToString())
				.WithQueryParameter("DLIX", m3_DLIX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name GetPackagSSCCEx
		/// Description Get package on a SSCC number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SSCC">SSCC number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPackagSSCCExResponse></returns>
		/// <exception cref="M3Exception<GetPackagSSCCExResponse>"></exception>
		public async Task<M3Response<GetPackagSSCCExResponse>> GetPackagSSCCEx(
			string m3_SSCC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPackagSSCCEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SSCC))
				throw new ArgumentNullException("m3_SSCC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<GetPackagSSCCExResponse>(
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
		/// Name GetPackageValue
		/// Description Get package value
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIPA">Disconnected package (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPackageValueResponse></returns>
		/// <exception cref="M3Exception<GetPackageValueResponse>"></exception>
		public async Task<M3Response<GetPackageValueResponse>> GetPackageValue(
			int m3_DIPA, 
			string m3_WHLO = null, 
			decimal? m3_DLIX = null, 
			string m3_PANR = null, 
			string m3_CUCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPackageValue",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DIPA", m3_DIPA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<GetPackageValueResponse>(
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
		/// Name LstContents
		/// Description List contents of a package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PDSO">Package detail sort order (Required)</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_PAII">Included in package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstContentsResponse></returns>
		/// <exception cref="M3Exception<LstContentsResponse>"></exception>
		public async Task<M3Response<LstContentsResponse>> LstContents(
			string m3_PDSO, 
			decimal? m3_DLIX = null, 
			string m3_PANR = null, 
			string m3_ITNO = null, 
			int? m3_RORC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstContents",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PDSO))
				throw new ArgumentNullException("m3_PDSO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PDSO", m3_PDSO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAII))
				request.WithQueryParameter("PAII", m3_PAII.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<LstContentsResponse>(
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
		/// Name LstContentsSfx
		/// Description List contents of a package with PLSX
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_PLRN">Reporting number - pick line</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstContentsSfxResponse></returns>
		/// <exception cref="M3Exception<LstContentsSfxResponse>"></exception>
		public async Task<M3Response<LstContentsSfxResponse>> LstContentsSfx(
			string m3_WHLO = null, 
			decimal? m3_DLIX = null, 
			string m3_PANR = null, 
			int? m3_RORC = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_PLRN = null, 
			int? m3_PLSX = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstContentsSfx",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_PLRN.HasValue)
				request.WithQueryParameter("PLRN", m3_PLRN.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstContentsSfxResponse>(
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
		/// Name LstManualPack
		/// Description List picklist lines of a picklist suffix
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstManualPackResponse></returns>
		/// <exception cref="M3Exception<LstManualPackResponse>"></exception>
		public async Task<M3Response<LstManualPackResponse>> LstManualPack(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstManualPack",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString());

			// Execute the request
			var result = await Execute<LstManualPackResponse>(
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
		/// Name LstNotPacked
		/// Description List not packed allocations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FCON">From shipment (Required)</param>
		/// <param name="m3_TCON">To shipment</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNotPackedResponse></returns>
		/// <exception cref="M3Exception<LstNotPackedResponse>"></exception>
		public async Task<M3Response<LstNotPackedResponse>> LstNotPacked(
			int m3_FCON, 
			int? m3_TCON = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNotPacked",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("FCON", m3_FCON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TCON.HasValue)
				request.WithQueryParameter("TCON", m3_TCON.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<LstNotPackedResponse>(
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
		/// Name LstNotPicked
		/// Description List pick list lines with lower than status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FCON">From Shipment (Required)</param>
		/// <param name="m3_TCON">To Shipment</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_STAT">Lower than Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNotPickedResponse></returns>
		/// <exception cref="M3Exception<LstNotPickedResponse>"></exception>
		public async Task<M3Response<LstNotPickedResponse>> LstNotPicked(
			int m3_FCON, 
			int? m3_TCON = null, 
			string m3_WHLO = null, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNotPicked",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("FCON", m3_FCON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TCON.HasValue)
				request.WithQueryParameter("TCON", m3_TCON.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

			// Execute the request
			var result = await Execute<LstNotPickedResponse>(
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
		/// Name LstPLByPackage
		/// Description List Pick List by Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPLByPackageResponse></returns>
		/// <exception cref="M3Exception<LstPLByPackageResponse>"></exception>
		public async Task<M3Response<LstPLByPackageResponse>> LstPLByPackage(
			string m3_SSCC = null, 
			string m3_PANR = null, 
			decimal? m3_DLIX = null, 
			string m3_SLTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPLByPackage",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());

			// Execute the request
			var result = await Execute<LstPLByPackageResponse>(
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
		/// Name LstPack
		/// Description List packages on a warehouse and shipment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_FCON">From shipment (Required)</param>
		/// <param name="m3_TCON">To shipment</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_FINV">1=ignore invoice deliveries</param>
		/// <param name="m3_FEXT">1=read only packs wh ext track num blank</param>
		/// <param name="m3_FREM">1=read only packs wh remark is blank</param>
		/// <param name="m3_ALPL">1=check all pack lines against stock zone</param>
		/// <param name="m3_ISST">1=search MITTRA if not found in MITALO</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackResponse></returns>
		/// <exception cref="M3Exception<LstPackResponse>"></exception>
		public async Task<M3Response<LstPackResponse>> LstPack(
			string m3_WHLO, 
			int m3_FCON, 
			int? m3_TCON = null, 
			string m3_SLTP = null, 
			int? m3_FINV = null, 
			int? m3_FEXT = null, 
			int? m3_FREM = null, 
			int? m3_ALPL = null, 
			int? m3_ISST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("FCON", m3_FCON.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TCON.HasValue)
				request.WithQueryParameter("TCON", m3_TCON.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (m3_FINV.HasValue)
				request.WithQueryParameter("FINV", m3_FINV.Value.ToString());
			if (m3_FEXT.HasValue)
				request.WithQueryParameter("FEXT", m3_FEXT.Value.ToString());
			if (m3_FREM.HasValue)
				request.WithQueryParameter("FREM", m3_FREM.Value.ToString());
			if (m3_ALPL.HasValue)
				request.WithQueryParameter("ALPL", m3_ALPL.Value.ToString());
			if (m3_ISST.HasValue)
				request.WithQueryParameter("ISST", m3_ISST.Value.ToString());

			// Execute the request
			var result = await Execute<LstPackResponse>(
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
		/// Name LstPackDel
		/// Description List packages by delivery
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PACO">Package level</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_PACK">Packaging type</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackDelResponse></returns>
		/// <exception cref="M3Exception<LstPackDelResponse>"></exception>
		public async Task<M3Response<LstPackDelResponse>> LstPackDel(
			string m3_PANR = null, 
			decimal? m3_DLIX = null, 
			int? m3_PACO = null, 
			string m3_PACT = null, 
			string m3_PACK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackDel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PACO.HasValue)
				request.WithQueryParameter("PACO", m3_PACO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACK))
				request.WithQueryParameter("PACK", m3_PACK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<LstPackDelResponse>(
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
		/// Name LstPackDelSfx
		/// Description List packages by delivery/suffix
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_PACO">Package level</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_PACK">Packaging type</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackDelSfxResponse></returns>
		/// <exception cref="M3Exception<LstPackDelSfxResponse>"></exception>
		public async Task<M3Response<LstPackDelSfxResponse>> LstPackDelSfx(
			string m3_PANR = null, 
			decimal? m3_DLIX = null, 
			int? m3_PLSX = null, 
			int? m3_PACO = null, 
			string m3_PACT = null, 
			string m3_PACK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackDelSfx",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (m3_PACO.HasValue)
				request.WithQueryParameter("PACO", m3_PACO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACK))
				request.WithQueryParameter("PACK", m3_PACK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<LstPackDelSfxResponse>(
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
		/// Name LstPackGrp
		/// Description List package groups for one Delivery number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INOU">Direction (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PACO">Package level (Required)</param>
		/// <param name="m3_PAGL">Package aggregation level (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackGrpResponse></returns>
		/// <exception cref="M3Exception<LstPackGrpResponse>"></exception>
		public async Task<M3Response<LstPackGrpResponse>> LstPackGrp(
			int m3_INOU, 
			decimal m3_DLIX, 
			int m3_PACO, 
			int m3_PAGL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackGrp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INOU", m3_INOU.ToString())
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PACO", m3_PACO.ToString())
				.WithQueryParameter("PAGL", m3_PAGL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstPackGrpResponse>(
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
		/// Name LstPackages
		/// Description List packages on a delivery number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INOU">Direction (Required)</param>
		/// <param name="m3_DLIX">Delivery number (Required)</param>
		/// <param name="m3_PACO">Package level (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_PACK">Packaging type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackagesResponse></returns>
		/// <exception cref="M3Exception<LstPackagesResponse>"></exception>
		public async Task<M3Response<LstPackagesResponse>> LstPackages(
			int m3_INOU, 
			decimal m3_DLIX, 
			int m3_PACO, 
			int? m3_CONO = null, 
			string m3_PACT = null, 
			string m3_PACK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackages",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INOU", m3_INOU.ToString())
				.WithQueryParameter("DLIX", m3_DLIX.ToString())
				.WithQueryParameter("PACO", m3_PACO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACK))
				request.WithQueryParameter("PACK", m3_PACK.Trim());

			// Execute the request
			var result = await Execute<LstPackagesResponse>(
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
		/// Name LstPackaging
		/// Description List package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackagingResponse></returns>
		/// <exception cref="M3Exception<LstPackagingResponse>"></exception>
		public async Task<M3Response<LstPackagingResponse>> LstPackaging(
			string m3_PACT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackaging",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());

			// Execute the request
			var result = await Execute<LstPackagingResponse>(
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
		/// Name MoveContents
		/// Description Move package into another package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TPAN">To Package number (Required)</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MoveContents(
			string m3_TPAN, 
			decimal? m3_DLIX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/MoveContents",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TPAN))
				throw new ArgumentNullException("m3_TPAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("TPAN", m3_TPAN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
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
		/// Name MovePackage
		/// Description Move package between deliverys
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_TLIX">Delivery number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<MovePackageResponse></returns>
		/// <exception cref="M3Exception<MovePackageResponse>"></exception>
		public async Task<M3Response<MovePackageResponse>> MovePackage(
			int? m3_CONO = null, 
			decimal? m3_DLIX = null, 
			int? m3_PLSX = null, 
			string m3_PANR = null, 
			decimal? m3_TLIX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/MovePackage",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (m3_TLIX.HasValue)
				request.WithQueryParameter("TLIX", m3_TLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<MovePackageResponse>(
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
		/// Name PackLine
		/// Description Manual pack for a pick list line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_TTYP">Stock transaction type</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_CHKQ">Yes/no</param>
		/// <param name="m3_PAQT">Packed quantity</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PackLine(
			int? m3_CONO = null, 
			decimal? m3_RIDI = null, 
			int? m3_PLSX = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_ITNO = null, 
			int? m3_TTYP = null, 
			int? m3_RIDO = null, 
			int? m3_CHKQ = null, 
			decimal? m3_PAQT = null, 
			string m3_PANR = null, 
			string m3_PACT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PackLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3_TTYP.Value.ToString());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (m3_CHKQ.HasValue)
				request.WithQueryParameter("CHKQ", m3_CHKQ.Value.ToString());
			if (m3_PAQT.HasValue)
				request.WithQueryParameter("PAQT", m3_PAQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());

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
		/// Name PackLineInNew
		/// Description Manual pack for a pick list line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_TTYP">Stock transaction type</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_CHKQ">Yes/no</param>
		/// <param name="m3_PAQT">Packed quantity</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PackLineInNew(
			int? m3_CONO = null, 
			decimal? m3_RIDI = null, 
			int? m3_PLSX = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_ITNO = null, 
			int? m3_TTYP = null, 
			int? m3_RIDO = null, 
			int? m3_CHKQ = null, 
			decimal? m3_PAQT = null, 
			string m3_PANR = null, 
			string m3_PACT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PackLineInNew",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3_TTYP.Value.ToString());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (m3_CHKQ.HasValue)
				request.WithQueryParameter("CHKQ", m3_CHKQ.Value.ToString());
			if (m3_PAQT.HasValue)
				request.WithQueryParameter("PAQT", m3_PAQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());

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
		/// Name PackPicklist
		/// Description Pack reporting for a complete picking list
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PackPicklist(
			int? m3_CONO = null, 
			decimal? m3_DLIX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PackPicklist",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());

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
		/// Name PackSblotInNew
		/// Description PackSblotInNew
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_TTYP">Stock transaction type</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_BANT">Reference sublot ID</param>
		/// <param name="m3_CHKQ">Yes/no</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PackSblotInNew(
			int? m3_CONO = null, 
			decimal? m3_RIDI = null, 
			int? m3_PLSX = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_ITNO = null, 
			int? m3_TTYP = null, 
			int? m3_RIDO = null, 
			string m3_BANT = null, 
			int? m3_CHKQ = null, 
			string m3_PANR = null, 
			string m3_PACT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PackSblotInNew",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3_TTYP.Value.ToString());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANT))
				request.WithQueryParameter("BANT", m3_BANT.Trim());
			if (m3_CHKQ.HasValue)
				request.WithQueryParameter("CHKQ", m3_CHKQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());

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
		/// Name PackSublot
		/// Description PackSublot
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_TTYP">Stock transaction type</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_BANT">Reference sublot ID</param>
		/// <param name="m3_CHKQ">Yes/no</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PackSublot(
			int? m3_CONO = null, 
			decimal? m3_RIDI = null, 
			int? m3_PLSX = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_ITNO = null, 
			int? m3_TTYP = null, 
			int? m3_RIDO = null, 
			string m3_BANT = null, 
			int? m3_CHKQ = null, 
			string m3_PANR = null, 
			string m3_PACT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PackSublot",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3_TTYP.Value.ToString());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANT))
				request.WithQueryParameter("BANT", m3_BANT.Trim());
			if (m3_CHKQ.HasValue)
				request.WithQueryParameter("CHKQ", m3_CHKQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());

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
		/// Name PrintPackage
		/// Description Print Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PANR">Package number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintPackage(
			string m3_PANR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrintPackage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PANR))
				throw new ArgumentNullException("m3_PANR");

			// Set mandatory parameters
			request
				.WithQueryParameter("PANR", m3_PANR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name PrtAddrLabel
		/// Description Print address label
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_DLIX">Delivery number</param>
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
		public async Task<M3Response<M3Record>> PrtAddrLabel(
			string m3_WHLO, 
			decimal? m3_DLIX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrtAddrLabel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
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
		/// Name PrtTransLabel
		/// Description Print transport label
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DLIX">Delivery number</param>
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
		public async Task<M3Response<M3Record>> PrtTransLabel(
			decimal? m3_DLIX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrtTransLabel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
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
		/// Name RemPckFrmShpPck
		/// Description Remove Package From Shipment Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_SSC1">SSCC number MPTRNS</param>
		/// <param name="m3_SPNO">Shipment package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RemPckFrmShpPck(
			string m3_PANR = null, 
			decimal? m3_DLIX = null, 
			string m3_SSC1 = null, 
			string m3_SPNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RemPckFrmShpPck",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSC1))
				request.WithQueryParameter("SSC1", m3_SSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPNO))
				request.WithQueryParameter("SPNO", m3_SPNO.Trim());
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
		/// Name RtvLastPkg
		/// Description RtvLastPkg
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvLastPkgResponse></returns>
		/// <exception cref="M3Exception<RtvLastPkgResponse>"></exception>
		public async Task<M3Response<RtvLastPkgResponse>> RtvLastPkg(
			string m3_WHLO = null, 
			decimal? m3_DLIX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RtvLastPkg",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());

			// Execute the request
			var result = await Execute<RtvLastPkgResponse>(
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
		/// Name UnpackLine
		/// Description Unpack for a pick list line
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_TTYP">Stock transaction type</param>
		/// <param name="m3_RIDO">Order operation</param>
		/// <param name="m3_KEMP">Keep empty packages</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UnpackLine(
			int? m3_CONO = null, 
			decimal? m3_RIDI = null, 
			int? m3_PLSX = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_ITNO = null, 
			int? m3_TTYP = null, 
			int? m3_RIDO = null, 
			int? m3_KEMP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UnpackLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3_TTYP.Value.ToString());
			if (m3_RIDO.HasValue)
				request.WithQueryParameter("RIDO", m3_RIDO.Value.ToString());
			if (m3_KEMP.HasValue)
				request.WithQueryParameter("KEMP", m3_KEMP.Value.ToString());

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
		/// <param name="m3_DLIX">Delivery number</param>
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
			decimal? m3_DLIX = null, 
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
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
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
		/// Name UnpackPicklist
		/// Description Unpack a complete pick list
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UnpackPicklist(
			int? m3_CONO = null, 
			decimal? m3_DLIX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UnpackPicklist",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());

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
