/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.DRS005MI;
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
	/// Name: DRS005MI
	/// Component Name: Route
	/// Description: Route interface
	/// Version Release: 5ea0
	///</summary>
	public partial class DRS005MIResource : M3BaseResourceEndpoint
	{
		public DRS005MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "DRS005MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddRoute
		/// Description AddRoute
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ROUT">Route (Required)</param>
		/// <param name="m3_RUTP">Route type (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_SDES">Place of loading</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_SILD">Stipulated internal lead time - days</param>
		/// <param name="m3_SILH">Stipulated internal lead time - hours</param>
		/// <param name="m3_SILM">Stipulated internal lead time - minutes</param>
		/// <param name="m3_DLMC">Manual shipment scheduling allowed</param>
		/// <param name="m3_DLAC">Ignore deadline when connecting dely no</param>
		/// <param name="m3_ACNC">Automatic connection to shipment</param>
		/// <param name="m3_MARE">Responsible must be entered</param>
		/// <param name="m3_MALP">Loading platform</param>
		/// <param name="m3_MACA">Transportation equipment</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_TRCA">Transportation equipment</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TSID">Transportation service ID</param>
		/// <param name="m3_DIST">Number of kilometer</param>
		/// <param name="m3_LOBL">Load building</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddRoute(
			string m3_ROUT, 
			int m3_RUTP, 
			string m3_TX40, 
			string m3_RESP, 
			string m3_TX15 = null, 
			string m3_SDES = null, 
			string m3_EDES = null, 
			int? m3_SILD = null, 
			int? m3_SILH = null, 
			int? m3_SILM = null, 
			int? m3_DLMC = null, 
			int? m3_DLAC = null, 
			int? m3_ACNC = null, 
			int? m3_MARE = null, 
			int? m3_MALP = null, 
			int? m3_MACA = null, 
			string m3_FWNO = null, 
			string m3_TRCA = null, 
			string m3_MODL = null, 
			string m3_TSID = null, 
			int? m3_DIST = null, 
			int? m3_LOBL = null, 
			string m3_LODO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddRoute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ROUT))
				throw new ArgumentNullException("m3_ROUT");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");

			// Set mandatory parameters
			request
				.WithQueryParameter("ROUT", m3_ROUT.Trim())
				.WithQueryParameter("RUTP", m3_RUTP.ToString())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("RESP", m3_RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDES))
				request.WithQueryParameter("SDES", m3_SDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (m3_SILD.HasValue)
				request.WithQueryParameter("SILD", m3_SILD.Value.ToString());
			if (m3_SILH.HasValue)
				request.WithQueryParameter("SILH", m3_SILH.Value.ToString());
			if (m3_SILM.HasValue)
				request.WithQueryParameter("SILM", m3_SILM.Value.ToString());
			if (m3_DLMC.HasValue)
				request.WithQueryParameter("DLMC", m3_DLMC.Value.ToString());
			if (m3_DLAC.HasValue)
				request.WithQueryParameter("DLAC", m3_DLAC.Value.ToString());
			if (m3_ACNC.HasValue)
				request.WithQueryParameter("ACNC", m3_ACNC.Value.ToString());
			if (m3_MARE.HasValue)
				request.WithQueryParameter("MARE", m3_MARE.Value.ToString());
			if (m3_MALP.HasValue)
				request.WithQueryParameter("MALP", m3_MALP.Value.ToString());
			if (m3_MACA.HasValue)
				request.WithQueryParameter("MACA", m3_MACA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRCA))
				request.WithQueryParameter("TRCA", m3_TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSID))
				request.WithQueryParameter("TSID", m3_TSID.Trim());
			if (m3_DIST.HasValue)
				request.WithQueryParameter("DIST", m3_DIST.Value.ToString());
			if (m3_LOBL.HasValue)
				request.WithQueryParameter("LOBL", m3_LOBL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());

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
		/// Name DltRoute
		/// Description DltRoute
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ROUT">Route (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltRoute(
			string m3_ROUT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltRoute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ROUT))
				throw new ArgumentNullException("m3_ROUT");

			// Set mandatory parameters
			request
				.WithQueryParameter("ROUT", m3_ROUT.Trim());

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
		/// Name GetRoute
		/// Description GetRoute
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ROUT">Route (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRouteResponse></returns>
		/// <exception cref="M3Exception<GetRouteResponse>"></exception>
		public async Task<M3Response<GetRouteResponse>> GetRoute(
			string m3_ROUT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetRoute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ROUT))
				throw new ArgumentNullException("m3_ROUT");

			// Set mandatory parameters
			request
				.WithQueryParameter("ROUT", m3_ROUT.Trim());

			// Execute the request
			var result = await Execute<GetRouteResponse>(
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
		/// Name LstRoute
		/// Description LstRoute
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRouteResponse></returns>
		/// <exception cref="M3Exception<LstRouteResponse>"></exception>
		public async Task<M3Response<LstRouteResponse>> LstRoute(
			string m3_ROUT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRoute",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());

			// Execute the request
			var result = await Execute<LstRouteResponse>(
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
		/// Name SelRoute
		/// Description Select list of Routes
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RUTP">Include route type</param>
		/// <param name="m3_SDES">Place of loading</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_TRCA">Transportation equipment</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TSID">Transportation service ID</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_INOU">Direction</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelRouteResponse></returns>
		/// <exception cref="M3Exception<SelRouteResponse>"></exception>
		public async Task<M3Response<SelRouteResponse>> SelRoute(
			string m3_WHLO = null, 
			string m3_ROUT = null, 
			long? m3_RUTP = null, 
			string m3_SDES = null, 
			string m3_EDES = null, 
			string m3_FWNO = null, 
			string m3_TRCA = null, 
			string m3_MODL = null, 
			string m3_TSID = null, 
			string m3_LODO = null, 
			int? m3_INOU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelRoute",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (m3_RUTP.HasValue)
				request.WithQueryParameter("RUTP", m3_RUTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SDES))
				request.WithQueryParameter("SDES", m3_SDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRCA))
				request.WithQueryParameter("TRCA", m3_TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSID))
				request.WithQueryParameter("TSID", m3_TSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_INOU.HasValue)
				request.WithQueryParameter("INOU", m3_INOU.Value.ToString());

			// Execute the request
			var result = await Execute<SelRouteResponse>(
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
		/// Name UpdRoute
		/// Description UpdRoute
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ROUT">Route (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_SDES">Place of loading</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_SILD">Stipulated internal lead time - days</param>
		/// <param name="m3_SILH">Stipulated internal lead time - hours</param>
		/// <param name="m3_SILM">Stipulated internal lead time - minutes</param>
		/// <param name="m3_DLMC">Manual shipment scheduling allowed</param>
		/// <param name="m3_DLAC">Ignore deadline when connecting dely no</param>
		/// <param name="m3_ACNC">Automatic connection to shipment</param>
		/// <param name="m3_MARE">Responsible must be entered</param>
		/// <param name="m3_MALP">Loading platform</param>
		/// <param name="m3_MACA">Transportation equipment</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_TRCA">Transportation equipment</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TSID">Transportation service ID</param>
		/// <param name="m3_DIST">Number of kilometer</param>
		/// <param name="m3_LOBL">Load building</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdRoute(
			string m3_ROUT, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_RESP = null, 
			string m3_SDES = null, 
			string m3_EDES = null, 
			int? m3_SILD = null, 
			int? m3_SILH = null, 
			int? m3_SILM = null, 
			int? m3_DLMC = null, 
			int? m3_DLAC = null, 
			int? m3_ACNC = null, 
			int? m3_MARE = null, 
			int? m3_MALP = null, 
			int? m3_MACA = null, 
			string m3_FWNO = null, 
			string m3_TRCA = null, 
			string m3_MODL = null, 
			string m3_TSID = null, 
			int? m3_DIST = null, 
			int? m3_LOBL = null, 
			string m3_LODO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdRoute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ROUT))
				throw new ArgumentNullException("m3_ROUT");

			// Set mandatory parameters
			request
				.WithQueryParameter("ROUT", m3_ROUT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDES))
				request.WithQueryParameter("SDES", m3_SDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (m3_SILD.HasValue)
				request.WithQueryParameter("SILD", m3_SILD.Value.ToString());
			if (m3_SILH.HasValue)
				request.WithQueryParameter("SILH", m3_SILH.Value.ToString());
			if (m3_SILM.HasValue)
				request.WithQueryParameter("SILM", m3_SILM.Value.ToString());
			if (m3_DLMC.HasValue)
				request.WithQueryParameter("DLMC", m3_DLMC.Value.ToString());
			if (m3_DLAC.HasValue)
				request.WithQueryParameter("DLAC", m3_DLAC.Value.ToString());
			if (m3_ACNC.HasValue)
				request.WithQueryParameter("ACNC", m3_ACNC.Value.ToString());
			if (m3_MARE.HasValue)
				request.WithQueryParameter("MARE", m3_MARE.Value.ToString());
			if (m3_MALP.HasValue)
				request.WithQueryParameter("MALP", m3_MALP.Value.ToString());
			if (m3_MACA.HasValue)
				request.WithQueryParameter("MACA", m3_MACA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRCA))
				request.WithQueryParameter("TRCA", m3_TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSID))
				request.WithQueryParameter("TSID", m3_TSID.Trim());
			if (m3_DIST.HasValue)
				request.WithQueryParameter("DIST", m3_DIST.Value.ToString());
			if (m3_LOBL.HasValue)
				request.WithQueryParameter("LOBL", m3_LOBL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());

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
