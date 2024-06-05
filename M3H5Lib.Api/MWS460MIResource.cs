/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS460MI;
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
	/// Name: MWS460MI
	/// Component Name: PendingPutAway
	/// Description: Pending put-aways
	/// Version Release: 5ea0
	///</summary>
	public partial class MWS460MIResource : M3BaseResourceEndpoint
	{
		public MWS460MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS460MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPutAwayTask
		/// Description Get Put-away Task
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PANO">Put-away number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPutAwayTaskResponse></returns>
		/// <exception cref="M3Exception<GetPutAwayTaskResponse>"></exception>
		public async Task<M3Response<GetPutAwayTaskResponse>> GetPutAwayTask(
			string m3_WHLO, 
			long m3_PANO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPutAwayTask",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PANO", m3_PANO.ToString());

			// Execute the request
			var result = await Execute<GetPutAwayTaskResponse>(
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
		/// Name LstPackage
		/// Description LstPackage
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackageResponse></returns>
		/// <exception cref="M3Exception<LstPackageResponse>"></exception>
		public async Task<M3Response<LstPackageResponse>> LstPackage(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackage",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<LstPackageResponse>(
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
		/// Name LstPutAwayByPac
		/// Description List put-away by package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPutAwayByPacResponse></returns>
		/// <exception cref="M3Exception<LstPutAwayByPacResponse>"></exception>
		public async Task<M3Response<LstPutAwayByPacResponse>> LstPutAwayByPac(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPutAwayByPac",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<LstPutAwayByPacResponse>(
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
		/// Name LstPutAwayTask
		/// Description List put away task
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_TEAM">Picking team</param>
		/// <param name="m3_PICK">Picker</param>
		/// <param name="m3_PLRI">Wave number</param>
		/// <param name="m3_PANR">Package number</param>
		/// <param name="m3_OPAN">Outer package number</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_AORC">Acquistion order category</param>
		/// <param name="m3_ARDN">Acquisition order number</param>
		/// <param name="m3_ARDL">Acquisition order line</param>
		/// <param name="m3_ARDX">Line suffix</param>
		/// <param name="m3_LOCG">Location group</param>
		/// <param name="m3_WHLT">Location type</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_PISE">Warehouse equipment</param>
		/// <param name="m3_PANO">Put-away number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPutAwayTaskResponse></returns>
		/// <exception cref="M3Exception<LstPutAwayTaskResponse>"></exception>
		public async Task<M3Response<LstPutAwayTaskResponse>> LstPutAwayTask(
			string m3_WHLO, 
			int? m3_CONO = null, 
			string m3_WHSL = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			string m3_TEAM = null, 
			string m3_PICK = null, 
			string m3_PLRI = null, 
			string m3_PANR = null, 
			string m3_OPAN = null, 
			decimal? m3_DLIX = null, 
			int? m3_AORC = null, 
			string m3_ARDN = null, 
			int? m3_ARDL = null, 
			int? m3_ARDX = null, 
			string m3_LOCG = null, 
			string m3_WHLT = null, 
			string m3_SLTP = null, 
			string m3_PISE = null, 
			long? m3_PANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPutAwayTask",
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
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEAM))
				request.WithQueryParameter("TEAM", m3_TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PICK))
				request.WithQueryParameter("PICK", m3_PICK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLRI))
				request.WithQueryParameter("PLRI", m3_PLRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PANR))
				request.WithQueryParameter("PANR", m3_PANR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPAN))
				request.WithQueryParameter("OPAN", m3_OPAN.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_AORC.HasValue)
				request.WithQueryParameter("AORC", m3_AORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ARDN))
				request.WithQueryParameter("ARDN", m3_ARDN.Trim());
			if (m3_ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3_ARDL.Value.ToString());
			if (m3_ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3_ARDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LOCG))
				request.WithQueryParameter("LOCG", m3_LOCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PISE))
				request.WithQueryParameter("PISE", m3_PISE.Trim());
			if (m3_PANO.HasValue)
				request.WithQueryParameter("PANO", m3_PANO.Value.ToString());

			// Execute the request
			var result = await Execute<LstPutAwayTaskResponse>(
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
		/// Name RetrLocViaPano
		/// Description Retrieve Put-away Location Via Put-away Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PANO">Put-away number (Required)</param>
		/// <param name="m3_TRQT">Transaction quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RetrLocViaPanoResponse></returns>
		/// <exception cref="M3Exception<RetrLocViaPanoResponse>"></exception>
		public async Task<M3Response<RetrLocViaPanoResponse>> RetrLocViaPano(
			long m3_PANO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RetrLocViaPano",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PANO", m3_PANO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());

			// Execute the request
			var result = await Execute<RetrLocViaPanoResponse>(
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
		/// Name RetrPutAwayLoc
		/// Description Retrieve Put-away Location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_WHSL">Location (Required)</param>
		/// <param name="m3_TRQT">Transaction quantity (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_CDTP">Cross-dock type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RetrPutAwayLocResponse></returns>
		/// <exception cref="M3Exception<RetrPutAwayLocResponse>"></exception>
		public async Task<M3Response<RetrPutAwayLocResponse>> RetrPutAwayLoc(
			string m3_WHLO, 
			string m3_ITNO, 
			string m3_WHSL, 
			decimal m3_TRQT, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
			int? m3_CDTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RetrPutAwayLoc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("WHSL", m3_WHSL.Trim())
				.WithQueryParameter("TRQT", m3_TRQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (m3_CDTP.HasValue)
				request.WithQueryParameter("CDTP", m3_CDTP.Value.ToString());

			// Execute the request
			var result = await Execute<RetrPutAwayLocResponse>(
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
		/// Name UpdPutAwayTask
		/// Description Update put-away task
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PANO">Put-away number (Required)</param>
		/// <param name="m3_TEAM">Picking team</param>
		/// <param name="m3_PICK">Picker</param>
		/// <param name="m3_PLRI">Wave number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_STGE">Staged two-step put-away</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPutAwayTask(
			long m3_PANO, 
			string m3_TEAM = null, 
			string m3_PICK = null, 
			string m3_PLRI = null, 
			string m3_WHSL = null, 
			string m3_CAMU = null, 
			decimal? m3_TRQT = null, 
			int? m3_STGE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPutAwayTask",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PANO", m3_PANO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TEAM))
				request.WithQueryParameter("TEAM", m3_TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PICK))
				request.WithQueryParameter("PICK", m3_PICK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLRI))
				request.WithQueryParameter("PLRI", m3_PLRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (m3_STGE.HasValue)
				request.WithQueryParameter("STGE", m3_STGE.Value.ToString());

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
