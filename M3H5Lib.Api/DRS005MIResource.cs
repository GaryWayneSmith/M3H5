/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3ROUT">Route (Required)</param>
		/// <param name="m3RUTP">Route type (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3SDES">Place of loading</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3SILD">Stipulated internal lead time - days</param>
		/// <param name="m3SILH">Stipulated internal lead time - hours</param>
		/// <param name="m3SILM">Stipulated internal lead time - minutes</param>
		/// <param name="m3DLMC">Manual shipment scheduling allowed</param>
		/// <param name="m3DLAC">Ignore deadline when connecting dely no</param>
		/// <param name="m3ACNC">Automatic connection to shipment</param>
		/// <param name="m3MARE">Responsible must be entered</param>
		/// <param name="m3MALP">Loading platform</param>
		/// <param name="m3MACA">Transportation equipment</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3TRCA">Transportation equipment</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TSID">Transportation service ID</param>
		/// <param name="m3DIST">Number of kilometer</param>
		/// <param name="m3LOBL">Load building</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddRoute(
			string m3ROUT, 
			int m3RUTP, 
			string m3TX40, 
			string m3RESP, 
			string m3TX15 = null, 
			string m3SDES = null, 
			string m3EDES = null, 
			int? m3SILD = null, 
			int? m3SILH = null, 
			int? m3SILM = null, 
			int? m3DLMC = null, 
			int? m3DLAC = null, 
			int? m3ACNC = null, 
			int? m3MARE = null, 
			int? m3MALP = null, 
			int? m3MACA = null, 
			string m3FWNO = null, 
			string m3TRCA = null, 
			string m3MODL = null, 
			string m3TSID = null, 
			int? m3DIST = null, 
			int? m3LOBL = null, 
			string m3LODO = null, 
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
			if (string.IsNullOrWhiteSpace(m3ROUT))
				throw new ArgumentNullException(nameof(m3ROUT));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ROUT", m3ROUT.Trim())
				.WithQueryParameter("RUTP", m3RUTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("RESP", m3RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDES))
				request.WithQueryParameter("SDES", m3SDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (m3SILD.HasValue)
				request.WithQueryParameter("SILD", m3SILD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SILH.HasValue)
				request.WithQueryParameter("SILH", m3SILH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SILM.HasValue)
				request.WithQueryParameter("SILM", m3SILM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLMC.HasValue)
				request.WithQueryParameter("DLMC", m3DLMC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLAC.HasValue)
				request.WithQueryParameter("DLAC", m3DLAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACNC.HasValue)
				request.WithQueryParameter("ACNC", m3ACNC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MARE.HasValue)
				request.WithQueryParameter("MARE", m3MARE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MALP.HasValue)
				request.WithQueryParameter("MALP", m3MALP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MACA.HasValue)
				request.WithQueryParameter("MACA", m3MACA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRCA))
				request.WithQueryParameter("TRCA", m3TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSID))
				request.WithQueryParameter("TSID", m3TSID.Trim());
			if (m3DIST.HasValue)
				request.WithQueryParameter("DIST", m3DIST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOBL.HasValue)
				request.WithQueryParameter("LOBL", m3LOBL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());

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
		/// Name DltRoute
		/// Description DltRoute
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ROUT">Route (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltRoute(
			string m3ROUT, 
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
			if (string.IsNullOrWhiteSpace(m3ROUT))
				throw new ArgumentNullException(nameof(m3ROUT));

			// Set mandatory parameters
			request
				.WithQueryParameter("ROUT", m3ROUT.Trim());

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
		/// Name GetRoute
		/// Description GetRoute
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ROUT">Route (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRouteResponse></returns>
		/// <exception cref="M3Exception<GetRouteResponse>"></exception>
		public async Task<M3Response<GetRouteResponse>> GetRoute(
			string m3ROUT, 
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
			if (string.IsNullOrWhiteSpace(m3ROUT))
				throw new ArgumentNullException(nameof(m3ROUT));

			// Set mandatory parameters
			request
				.WithQueryParameter("ROUT", m3ROUT.Trim());

			// Execute the request
			var result = await Execute<GetRouteResponse>(
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
		/// Name LstRoute
		/// Description LstRoute
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ROUT">Route</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRouteResponse></returns>
		/// <exception cref="M3Exception<LstRouteResponse>"></exception>
		public async Task<M3Response<LstRouteResponse>> LstRoute(
			string m3ROUT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());

			// Execute the request
			var result = await Execute<LstRouteResponse>(
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
		/// Name SelRoute
		/// Description Select list of Routes
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RUTP">Include route type</param>
		/// <param name="m3SDES">Place of loading</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3TRCA">Transportation equipment</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TSID">Transportation service ID</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3INOU">Direction</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelRouteResponse></returns>
		/// <exception cref="M3Exception<SelRouteResponse>"></exception>
		public async Task<M3Response<SelRouteResponse>> SelRoute(
			string m3WHLO = null, 
			string m3ROUT = null, 
			long? m3RUTP = null, 
			string m3SDES = null, 
			string m3EDES = null, 
			string m3FWNO = null, 
			string m3TRCA = null, 
			string m3MODL = null, 
			string m3TSID = null, 
			string m3LODO = null, 
			int? m3INOU = null, 
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
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (m3RUTP.HasValue)
				request.WithQueryParameter("RUTP", m3RUTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SDES))
				request.WithQueryParameter("SDES", m3SDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRCA))
				request.WithQueryParameter("TRCA", m3TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSID))
				request.WithQueryParameter("TSID", m3TSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3INOU.HasValue)
				request.WithQueryParameter("INOU", m3INOU.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelRouteResponse>(
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
		/// Name UpdRoute
		/// Description UpdRoute
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ROUT">Route (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3SDES">Place of loading</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3SILD">Stipulated internal lead time - days</param>
		/// <param name="m3SILH">Stipulated internal lead time - hours</param>
		/// <param name="m3SILM">Stipulated internal lead time - minutes</param>
		/// <param name="m3DLMC">Manual shipment scheduling allowed</param>
		/// <param name="m3DLAC">Ignore deadline when connecting dely no</param>
		/// <param name="m3ACNC">Automatic connection to shipment</param>
		/// <param name="m3MARE">Responsible must be entered</param>
		/// <param name="m3MALP">Loading platform</param>
		/// <param name="m3MACA">Transportation equipment</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3TRCA">Transportation equipment</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TSID">Transportation service ID</param>
		/// <param name="m3DIST">Number of kilometer</param>
		/// <param name="m3LOBL">Load building</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdRoute(
			string m3ROUT, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3RESP = null, 
			string m3SDES = null, 
			string m3EDES = null, 
			int? m3SILD = null, 
			int? m3SILH = null, 
			int? m3SILM = null, 
			int? m3DLMC = null, 
			int? m3DLAC = null, 
			int? m3ACNC = null, 
			int? m3MARE = null, 
			int? m3MALP = null, 
			int? m3MACA = null, 
			string m3FWNO = null, 
			string m3TRCA = null, 
			string m3MODL = null, 
			string m3TSID = null, 
			int? m3DIST = null, 
			int? m3LOBL = null, 
			string m3LODO = null, 
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
			if (string.IsNullOrWhiteSpace(m3ROUT))
				throw new ArgumentNullException(nameof(m3ROUT));

			// Set mandatory parameters
			request
				.WithQueryParameter("ROUT", m3ROUT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDES))
				request.WithQueryParameter("SDES", m3SDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (m3SILD.HasValue)
				request.WithQueryParameter("SILD", m3SILD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SILH.HasValue)
				request.WithQueryParameter("SILH", m3SILH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SILM.HasValue)
				request.WithQueryParameter("SILM", m3SILM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLMC.HasValue)
				request.WithQueryParameter("DLMC", m3DLMC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLAC.HasValue)
				request.WithQueryParameter("DLAC", m3DLAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACNC.HasValue)
				request.WithQueryParameter("ACNC", m3ACNC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MARE.HasValue)
				request.WithQueryParameter("MARE", m3MARE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MALP.HasValue)
				request.WithQueryParameter("MALP", m3MALP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MACA.HasValue)
				request.WithQueryParameter("MACA", m3MACA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRCA))
				request.WithQueryParameter("TRCA", m3TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSID))
				request.WithQueryParameter("TSID", m3TSID.Trim());
			if (m3DIST.HasValue)
				request.WithQueryParameter("DIST", m3DIST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOBL.HasValue)
				request.WithQueryParameter("LOBL", m3LOBL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());

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
