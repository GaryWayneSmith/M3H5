/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.DRS100MI;
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
	/// Name: DRS100MI
	/// Component Name: Shipment
	/// Description: Api: Shipment
	/// Version Release: 5ea1
	///</summary>
	public partial class DRS100MIResource : M3BaseResourceEndpoint
	{
		public DRS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "DRS100MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CloseShipment
		/// Description Close shipment
		/// Version Release: 
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CloseShipmentResponse></returns>
		/// <exception cref="M3Exception<CloseShipmentResponse>"></exception>
		public async Task<M3Response<CloseShipmentResponse>> CloseShipment(
			int m3CONN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CloseShipment",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<CloseShipmentResponse>(
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
		/// Name ConnectShipment
		/// Description Connect shipment to loading platform
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConnectShipment(
			int m3CONN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ConnectShipment",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

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
		/// Name DisconnectShip
		/// Description Disconnect shipment from loading platform
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DisconnectShip(
			int m3CONN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DisconnectShip",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetLoadingStat
		/// Description Get the status of the loading process
		/// Version Release: 
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLoadingStatResponse></returns>
		/// <exception cref="M3Exception<GetLoadingStatResponse>"></exception>
		public async Task<M3Response<GetLoadingStatResponse>> GetLoadingStat(
			int m3CONN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLoadingStat",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetLoadingStatResponse>(
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
		/// Name GetShipment
		/// Description Get Shipment
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetShipmentResponse></returns>
		/// <exception cref="M3Exception<GetShipmentResponse>"></exception>
		public async Task<M3Response<GetShipmentResponse>> GetShipment(
			int m3CONN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetShipment",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetShipmentResponse>(
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
		/// Name LstByDelivery
		/// Description List Delivery
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByDeliveryResponse></returns>
		/// <exception cref="M3Exception<LstByDeliveryResponse>"></exception>
		public async Task<M3Response<LstByDeliveryResponse>> LstByDelivery(
			int m3CONN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByDelivery",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByDeliveryResponse>(
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
		/// Name LstByPlace
		/// Description List Delivery by Place
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByPlaceResponse></returns>
		/// <exception cref="M3Exception<LstByPlaceResponse>"></exception>
		public async Task<M3Response<LstByPlaceResponse>> LstByPlace(
			int m3CONN, 
			string m3EDES = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByPlace",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());

			// Execute the request
			var result = await Execute<LstByPlaceResponse>(
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
		/// Name LstShipPickDet
		/// Description LstShipPickDet
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstShipPickDetResponse></returns>
		/// <exception cref="M3Exception<LstShipPickDetResponse>"></exception>
		public async Task<M3Response<LstShipPickDetResponse>> LstShipPickDet(
			int m3CONN, 
			decimal? m3DLIX = null, 
			int? m3PLSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstShipPickDet",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstShipPickDetResponse>(
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
		/// Name LstShipPicklist
		/// Description LstShipPicklist
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3TEAM">Picking team</param>
		/// <param name="m3PICK">Picker</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3PLSX">Picking list suffix</param>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstShipPicklistResponse></returns>
		/// <exception cref="M3Exception<LstShipPicklistResponse>"></exception>
		public async Task<M3Response<LstShipPicklistResponse>> LstShipPicklist(
			int m3CONN, 
			string m3WHLO = null, 
			string m3SLTP = null, 
			string m3TEAM = null, 
			string m3PICK = null, 
			decimal? m3DLIX = null, 
			int? m3PLSX = null, 
			string m3PISE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstShipPicklist",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEAM))
				request.WithQueryParameter("TEAM", m3TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PICK))
				request.WithQueryParameter("PICK", m3PICK.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3PLSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());

			// Execute the request
			var result = await Execute<LstShipPicklistResponse>(
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
		/// Name LstShipment
		/// Description LstShipment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SDES">Place of loading</param>
		/// <param name="m3DSDT">Departure date</param>
		/// <param name="m3CONN">Shipment</param>
		/// <param name="m3FCSH">From highest status</param>
		/// <param name="m3TCSH">To highest status</param>
		/// <param name="m3FCSL">From lowest status</param>
		/// <param name="m3TCSL">To lowest status</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3TRCA">Transportation equipment</param>
		/// <param name="m3SILO">Shipment ready for loading</param>
		/// <param name="m31DDT">From departure date</param>
		/// <param name="m32DDT">To departure date</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3DLOS">Display loading status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstShipmentResponse></returns>
		/// <exception cref="M3Exception<LstShipmentResponse>"></exception>
		public async Task<M3Response<LstShipmentResponse>> LstShipment(
			string m3SDES = null, 
			DateTime? m3DSDT = null, 
			int? m3CONN = null, 
			string m3FCSH = null, 
			string m3TCSH = null, 
			string m3FCSL = null, 
			string m3TCSL = null, 
			string m3ROUT = null, 
			string m3FWNO = null, 
			string m3TRCA = null, 
			int? m3SILO = null, 
			DateTime? m31DDT = null, 
			DateTime? m32DDT = null, 
			string m3LODO = null, 
			int? m3DLOS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstShipment",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SDES))
				request.WithQueryParameter("SDES", m3SDES.Trim());
			if (m3DSDT.HasValue)
				request.WithQueryParameter("DSDT", m3DSDT.Value.ToM3String());
			if (m3CONN.HasValue)
				request.WithQueryParameter("CONN", m3CONN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCSH))
				request.WithQueryParameter("FCSH", m3FCSH.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCSH))
				request.WithQueryParameter("TCSH", m3TCSH.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCSL))
				request.WithQueryParameter("FCSL", m3FCSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCSL))
				request.WithQueryParameter("TCSL", m3TCSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRCA))
				request.WithQueryParameter("TRCA", m3TRCA.Trim());
			if (m3SILO.HasValue)
				request.WithQueryParameter("SILO", m3SILO.Value.ToString(CultureInfo.CurrentCulture));
			if (m31DDT.HasValue)
				request.WithQueryParameter("1DDT", m31DDT.Value.ToM3String());
			if (m32DDT.HasValue)
				request.WithQueryParameter("2DDT", m32DDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (m3DLOS.HasValue)
				request.WithQueryParameter("DLOS", m3DLOS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstShipmentResponse>(
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
		/// Name OpenShipment
		/// Description Open shipment
		/// Version Release: 
		/// </summary>
		/// <param name="m3CONN">Shipment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OpenShipment(
			int? m3CONN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/OpenShipment",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONN.HasValue)
				request.WithQueryParameter("CONN", m3CONN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ReleasePick
		/// Description Release shipment for picking
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReleasePick(
			int m3CONN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ReleasePick",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

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
		/// Name RptShipmentPick
		/// Description Report shipment picking
		/// Version Release: 
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptShipmentPick(
			int m3CONN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RptShipmentPick",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

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
		/// Name TrgDilvStpCheck
		/// Description Trigger delivery stop check
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TrgDilvStpCheck(
			int m3CONN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/TrgDilvStpCheck",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

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
		/// Name Update
		/// Description Update Shipment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="m3MMDL">Main delivery method</param>
		/// <param name="m3CDLD">Deadline date</param>
		/// <param name="m3CDHM">Chr. delivery note nbr creation time</param>
		/// <param name="m3DSDT">Departure date</param>
		/// <param name="m3DSHM">Departure time</param>
		/// <param name="m3ARDT">Arrival date</param>
		/// <param name="m3ARHM">Arrival time</param>
		/// <param name="m3SEAL">Seal number</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3TRCA">Transportation equipment</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3TSID">Transportation service ID</param>
		/// <param name="m3DLAC">Ignore deadline when connecting dely no</param>
		/// <param name="m3LOBL">Load building</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="m3E0B4">Transport identity - departure</param>
		/// <param name="m3GRW3">Included gross weight</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3FRCP">Capacity - free capacity unit</param>
		/// <param name="m3DRCD">Detention reason code</param>
		/// <param name="m3DFDT">Actual detention date</param>
		/// <param name="m3DFHM">Actual detention time</param>
		/// <param name="m3AWDT">Forwarders actual arrival date</param>
		/// <param name="m3AWHM">Forwarders actual arrival time</param>
		/// <param name="m3DSP1">Flag</param>
		/// <param name="m3TRFI">Transport interface indicator ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			int m3CONN, 
			string m3MMDL = null, 
			DateTime? m3CDLD = null, 
			int? m3CDHM = null, 
			DateTime? m3DSDT = null, 
			int? m3DSHM = null, 
			DateTime? m3ARDT = null, 
			int? m3ARHM = null, 
			string m3SEAL = null, 
			string m3FWNO = null, 
			string m3TRCA = null, 
			string m3RESP = null, 
			string m3AGNB = null, 
			string m3TSID = null, 
			int? m3DLAC = null, 
			int? m3LOBL = null, 
			string m3LODO = null, 
			string m3E0B4 = null, 
			decimal? m3GRW3 = null, 
			decimal? m3VOL3 = null, 
			decimal? m3FRCP = null, 
			string m3DRCD = null, 
			DateTime? m3DFDT = null, 
			int? m3DFHM = null, 
			DateTime? m3AWDT = null, 
			int? m3AWHM = null, 
			int? m3DSP1 = null, 
			string m3TRFI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MMDL))
				request.WithQueryParameter("MMDL", m3MMDL.Trim());
			if (m3CDLD.HasValue)
				request.WithQueryParameter("CDLD", m3CDLD.Value.ToM3String());
			if (m3CDHM.HasValue)
				request.WithQueryParameter("CDHM", m3CDHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSDT.HasValue)
				request.WithQueryParameter("DSDT", m3DSDT.Value.ToM3String());
			if (m3DSHM.HasValue)
				request.WithQueryParameter("DSHM", m3DSHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3ARDT.Value.ToM3String());
			if (m3ARHM.HasValue)
				request.WithQueryParameter("ARHM", m3ARHM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SEAL))
				request.WithQueryParameter("SEAL", m3SEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRCA))
				request.WithQueryParameter("TRCA", m3TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSID))
				request.WithQueryParameter("TSID", m3TSID.Trim());
			if (m3DLAC.HasValue)
				request.WithQueryParameter("DLAC", m3DLAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOBL.HasValue)
				request.WithQueryParameter("LOBL", m3LOBL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0B4))
				request.WithQueryParameter("E0B4", m3E0B4.Trim());
			if (m3GRW3.HasValue)
				request.WithQueryParameter("GRW3", m3GRW3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3FRCP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DRCD))
				request.WithQueryParameter("DRCD", m3DRCD.Trim());
			if (m3DFDT.HasValue)
				request.WithQueryParameter("DFDT", m3DFDT.Value.ToM3String());
			if (m3DFHM.HasValue)
				request.WithQueryParameter("DFHM", m3DFHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AWDT.HasValue)
				request.WithQueryParameter("AWDT", m3AWDT.Value.ToM3String());
			if (m3AWHM.HasValue)
				request.WithQueryParameter("AWHM", m3AWHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TRFI))
				request.WithQueryParameter("TRFI", m3TRFI.Trim());

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
