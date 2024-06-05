/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CloseShipment
		/// Description Close shipment
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CloseShipmentResponse></returns>
		/// <exception cref="M3Exception<CloseShipmentResponse>"></exception>
		public async Task<M3Response<CloseShipmentResponse>> CloseShipment(
			int m3_CONN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CloseShipment",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

			// Execute the request
			var result = await Execute<CloseShipmentResponse>(
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
		/// Name ConnectShipment
		/// Description Connect shipment to loading platform
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConnectShipment(
			int m3_CONN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConnectShipment",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

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
		/// Name DisconnectShip
		/// Description Disconnect shipment from loading platform
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DisconnectShip(
			int m3_CONN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DisconnectShip",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

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
		/// Name GetLoadingStat
		/// Description Get the status of the loading process
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLoadingStatResponse></returns>
		/// <exception cref="M3Exception<GetLoadingStatResponse>"></exception>
		public async Task<M3Response<GetLoadingStatResponse>> GetLoadingStat(
			int m3_CONN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLoadingStat",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

			// Execute the request
			var result = await Execute<GetLoadingStatResponse>(
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
		/// Name GetShipment
		/// Description Get Shipment
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetShipmentResponse></returns>
		/// <exception cref="M3Exception<GetShipmentResponse>"></exception>
		public async Task<M3Response<GetShipmentResponse>> GetShipment(
			int m3_CONN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetShipment",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

			// Execute the request
			var result = await Execute<GetShipmentResponse>(
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
		/// Name LstByDelivery
		/// Description List Delivery
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByDeliveryResponse></returns>
		/// <exception cref="M3Exception<LstByDeliveryResponse>"></exception>
		public async Task<M3Response<LstByDeliveryResponse>> LstByDelivery(
			int m3_CONN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByDelivery",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

			// Execute the request
			var result = await Execute<LstByDeliveryResponse>(
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
		/// Name LstByPlace
		/// Description List Delivery by Place
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByPlaceResponse></returns>
		/// <exception cref="M3Exception<LstByPlaceResponse>"></exception>
		public async Task<M3Response<LstByPlaceResponse>> LstByPlace(
			int m3_CONN, 
			string m3_EDES = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByPlace",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());

			// Execute the request
			var result = await Execute<LstByPlaceResponse>(
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
		/// Name LstShipPickDet
		/// Description LstShipPickDet
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstShipPickDetResponse></returns>
		/// <exception cref="M3Exception<LstShipPickDetResponse>"></exception>
		public async Task<M3Response<LstShipPickDetResponse>> LstShipPickDet(
			int m3_CONN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstShipPickDet",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());

			// Execute the request
			var result = await Execute<LstShipPickDetResponse>(
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
		/// Name LstShipPicklist
		/// Description LstShipPicklist
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_TEAM">Picking team</param>
		/// <param name="m3_PICK">Picker</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_PLSX">Picking list suffix</param>
		/// <param name="m3_PISE">Warehouse equipment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstShipPicklistResponse></returns>
		/// <exception cref="M3Exception<LstShipPicklistResponse>"></exception>
		public async Task<M3Response<LstShipPicklistResponse>> LstShipPicklist(
			int m3_CONN, 
			string m3_WHLO = null, 
			string m3_SLTP = null, 
			string m3_TEAM = null, 
			string m3_PICK = null, 
			decimal? m3_DLIX = null, 
			int? m3_PLSX = null, 
			string m3_PISE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstShipPicklist",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEAM))
				request.WithQueryParameter("TEAM", m3_TEAM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PICK))
				request.WithQueryParameter("PICK", m3_PICK.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_PLSX.HasValue)
				request.WithQueryParameter("PLSX", m3_PLSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PISE))
				request.WithQueryParameter("PISE", m3_PISE.Trim());

			// Execute the request
			var result = await Execute<LstShipPicklistResponse>(
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
		/// Name LstShipment
		/// Description LstShipment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SDES">Place of loading</param>
		/// <param name="m3_DSDT">Departure date</param>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="m3_FCSH">From highest status</param>
		/// <param name="m3_TCSH">To highest status</param>
		/// <param name="m3_FCSL">From lowest status</param>
		/// <param name="m3_TCSL">To lowest status</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_TRCA">Transportation equipment</param>
		/// <param name="m3_SILO">Shipment ready for loading</param>
		/// <param name="m3_1DDT">From departure date</param>
		/// <param name="m3_2DDT">To departure date</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_DLOS">Display loading status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstShipmentResponse></returns>
		/// <exception cref="M3Exception<LstShipmentResponse>"></exception>
		public async Task<M3Response<LstShipmentResponse>> LstShipment(
			string m3_SDES = null, 
			DateTime? m3_DSDT = null, 
			int? m3_CONN = null, 
			string m3_FCSH = null, 
			string m3_TCSH = null, 
			string m3_FCSL = null, 
			string m3_TCSL = null, 
			string m3_ROUT = null, 
			string m3_FWNO = null, 
			string m3_TRCA = null, 
			int? m3_SILO = null, 
			DateTime? m3_1DDT = null, 
			DateTime? m3_2DDT = null, 
			string m3_LODO = null, 
			int? m3_DLOS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstShipment",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SDES))
				request.WithQueryParameter("SDES", m3_SDES.Trim());
			if (m3_DSDT.HasValue)
				request.WithQueryParameter("DSDT", m3_DSDT.Value.ToM3String());
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCSH))
				request.WithQueryParameter("FCSH", m3_FCSH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCSH))
				request.WithQueryParameter("TCSH", m3_TCSH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCSL))
				request.WithQueryParameter("FCSL", m3_FCSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCSL))
				request.WithQueryParameter("TCSL", m3_TCSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRCA))
				request.WithQueryParameter("TRCA", m3_TRCA.Trim());
			if (m3_SILO.HasValue)
				request.WithQueryParameter("SILO", m3_SILO.Value.ToString());
			if (m3_1DDT.HasValue)
				request.WithQueryParameter("1DDT", m3_1DDT.Value.ToM3String());
			if (m3_2DDT.HasValue)
				request.WithQueryParameter("2DDT", m3_2DDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (m3_DLOS.HasValue)
				request.WithQueryParameter("DLOS", m3_DLOS.Value.ToString());

			// Execute the request
			var result = await Execute<LstShipmentResponse>(
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
		/// Name OpenShipment
		/// Description Open shipment
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CONN">Shipment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> OpenShipment(
			int? m3_CONN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/OpenShipment",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONN.HasValue)
				request.WithQueryParameter("CONN", m3_CONN.Value.ToString());

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
		/// Name ReleasePick
		/// Description Release shipment for picking
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReleasePick(
			int m3_CONN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReleasePick",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

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
		/// Name RptShipmentPick
		/// Description Report shipment picking
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptShipmentPick(
			int m3_CONN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RptShipmentPick",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

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
		/// Name TrgDilvStpCheck
		/// Description Trigger delivery stop check
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TrgDilvStpCheck(
			int m3_CONN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TrgDilvStpCheck",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

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
		/// Name Update
		/// Description Update Shipment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONN">Shipment (Required)</param>
		/// <param name="m3_MMDL">Main delivery method</param>
		/// <param name="m3_CDLD">Deadline date</param>
		/// <param name="m3_CDHM">Chr. delivery note nbr creation time</param>
		/// <param name="m3_DSDT">Departure date</param>
		/// <param name="m3_DSHM">Departure time</param>
		/// <param name="m3_ARDT">Arrival date</param>
		/// <param name="m3_ARHM">Arrival time</param>
		/// <param name="m3_SEAL">Seal number</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_TRCA">Transportation equipment</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_TSID">Transportation service ID</param>
		/// <param name="m3_DLAC">Ignore deadline when connecting dely no</param>
		/// <param name="m3_LOBL">Load building</param>
		/// <param name="m3_LODO">Loading platform</param>
		/// <param name="m3_E0B4">Transport identity - departure</param>
		/// <param name="m3_GRW3">Included gross weight</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_FRCP">Capacity - free capacity unit</param>
		/// <param name="m3_DRCD">Detention reason code</param>
		/// <param name="m3_DFDT">Actual detention date</param>
		/// <param name="m3_DFHM">Actual detention time</param>
		/// <param name="m3_AWDT">Forwarders actual arrival date</param>
		/// <param name="m3_AWHM">Forwarders actual arrival time</param>
		/// <param name="m3_DSP1">Flag</param>
		/// <param name="m3_TRFI">Transport interface indicator ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			int m3_CONN, 
			string m3_MMDL = null, 
			DateTime? m3_CDLD = null, 
			int? m3_CDHM = null, 
			DateTime? m3_DSDT = null, 
			int? m3_DSHM = null, 
			DateTime? m3_ARDT = null, 
			int? m3_ARHM = null, 
			string m3_SEAL = null, 
			string m3_FWNO = null, 
			string m3_TRCA = null, 
			string m3_RESP = null, 
			string m3_AGNB = null, 
			string m3_TSID = null, 
			int? m3_DLAC = null, 
			int? m3_LOBL = null, 
			string m3_LODO = null, 
			string m3_E0B4 = null, 
			decimal? m3_GRW3 = null, 
			decimal? m3_VOL3 = null, 
			decimal? m3_FRCP = null, 
			string m3_DRCD = null, 
			DateTime? m3_DFDT = null, 
			int? m3_DFHM = null, 
			DateTime? m3_AWDT = null, 
			int? m3_AWHM = null, 
			int? m3_DSP1 = null, 
			string m3_TRFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3_CONN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MMDL))
				request.WithQueryParameter("MMDL", m3_MMDL.Trim());
			if (m3_CDLD.HasValue)
				request.WithQueryParameter("CDLD", m3_CDLD.Value.ToM3String());
			if (m3_CDHM.HasValue)
				request.WithQueryParameter("CDHM", m3_CDHM.Value.ToString());
			if (m3_DSDT.HasValue)
				request.WithQueryParameter("DSDT", m3_DSDT.Value.ToM3String());
			if (m3_DSHM.HasValue)
				request.WithQueryParameter("DSHM", m3_DSHM.Value.ToString());
			if (m3_ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3_ARDT.Value.ToM3String());
			if (m3_ARHM.HasValue)
				request.WithQueryParameter("ARHM", m3_ARHM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SEAL))
				request.WithQueryParameter("SEAL", m3_SEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRCA))
				request.WithQueryParameter("TRCA", m3_TRCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSID))
				request.WithQueryParameter("TSID", m3_TSID.Trim());
			if (m3_DLAC.HasValue)
				request.WithQueryParameter("DLAC", m3_DLAC.Value.ToString());
			if (m3_LOBL.HasValue)
				request.WithQueryParameter("LOBL", m3_LOBL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LODO))
				request.WithQueryParameter("LODO", m3_LODO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0B4))
				request.WithQueryParameter("E0B4", m3_E0B4.Trim());
			if (m3_GRW3.HasValue)
				request.WithQueryParameter("GRW3", m3_GRW3.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (m3_FRCP.HasValue)
				request.WithQueryParameter("FRCP", m3_FRCP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DRCD))
				request.WithQueryParameter("DRCD", m3_DRCD.Trim());
			if (m3_DFDT.HasValue)
				request.WithQueryParameter("DFDT", m3_DFDT.Value.ToM3String());
			if (m3_DFHM.HasValue)
				request.WithQueryParameter("DFHM", m3_DFHM.Value.ToString());
			if (m3_AWDT.HasValue)
				request.WithQueryParameter("AWDT", m3_AWDT.Value.ToM3String());
			if (m3_AWHM.HasValue)
				request.WithQueryParameter("AWHM", m3_AWHM.Value.ToString());
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TRFI))
				request.WithQueryParameter("TRFI", m3_TRFI.Trim());

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
