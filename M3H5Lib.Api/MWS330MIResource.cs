/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS330MI;
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
	/// Name: MWS330MI
	/// Component Name: Reservation
	/// Description: Api: Reservation
	/// Version Release: 14.x
	///</summary>
	public partial class MWS330MIResource : M3BaseResourceEndpoint
	{
		public MWS330MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS330MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddReservation
		/// Description Add manual reservation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_VTDT">Valid to</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_AOCA">Acquistion order category</param>
		/// <param name="m3_ARDN">Acquisition order number</param>
		/// <param name="m3_ARDL">Acquisition order line</param>
		/// <param name="m3_ARDX">Line suffix</param>
		/// <param name="m3_XRES">Reserve</param>
		/// <param name="m3_TXP1">Text line  1</param>
		/// <param name="m3_TXP2">Text line  2</param>
		/// <param name="m3_TXP3">Text line  3</param>
		/// <param name="m3_TXP4">Text line  4</param>
		/// <param name="m3_TXP5">Text line  5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddReservationResponse></returns>
		/// <exception cref="M3Exception<AddReservationResponse>"></exception>
		public async Task<M3Response<AddReservationResponse>> AddReservation(
			string m3_RESP = null, 
			string m3_CUNO = null, 
			DateTime? m3_VTDT = null, 
			DateTime? m3_DWDT = null, 
			string m3_WHLO = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_AOCA = null, 
			string m3_ARDN = null, 
			int? m3_ARDL = null, 
			int? m3_ARDX = null, 
			int? m3_XRES = null, 
			string m3_TXP1 = null, 
			string m3_TXP2 = null, 
			string m3_TXP3 = null, 
			string m3_TXP4 = null, 
			string m3_TXP5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddReservation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_VTDT.HasValue)
				request.WithQueryParameter("VTDT", m3_VTDT.Value.ToM3String());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOCA))
				request.WithQueryParameter("AOCA", m3_AOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARDN))
				request.WithQueryParameter("ARDN", m3_ARDN.Trim());
			if (m3_ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3_ARDL.Value.ToString());
			if (m3_ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3_ARDX.Value.ToString());
			if (m3_XRES.HasValue)
				request.WithQueryParameter("XRES", m3_XRES.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXP1))
				request.WithQueryParameter("TXP1", m3_TXP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXP2))
				request.WithQueryParameter("TXP2", m3_TXP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXP3))
				request.WithQueryParameter("TXP3", m3_TXP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXP4))
				request.WithQueryParameter("TXP4", m3_TXP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXP5))
				request.WithQueryParameter("TXP5", m3_TXP5.Trim());

			// Execute the request
			var result = await Execute<AddReservationResponse>(
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
		/// Name ChgReservation
		/// Description Change reservation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RENB">Reservation number</param>
		/// <param name="m3_SQNB">Sequence number</param>
		/// <param name="m3_PRI2">Priority</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_VTDT">Valid to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgReservation(
			string m3_RENB = null, 
			int? m3_SQNB = null, 
			int? m3_PRI2 = null, 
			DateTime? m3_PRDT = null, 
			DateTime? m3_VTDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgReservation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RENB))
				request.WithQueryParameter("RENB", m3_RENB.Trim());
			if (m3_SQNB.HasValue)
				request.WithQueryParameter("SQNB", m3_SQNB.Value.ToString());
			if (m3_PRI2.HasValue)
				request.WithQueryParameter("PRI2", m3_PRI2.Value.ToString());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (m3_VTDT.HasValue)
				request.WithQueryParameter("VTDT", m3_VTDT.Value.ToM3String());

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
		/// Name DltReservation
		/// Description Delete reservation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RENB">Reservation number</param>
		/// <param name="m3_SQNB">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltReservation(
			string m3_RENB = null, 
			int? m3_SQNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltReservation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RENB))
				request.WithQueryParameter("RENB", m3_RENB.Trim());
			if (m3_SQNB.HasValue)
				request.WithQueryParameter("SQNB", m3_SQNB.Value.ToString());

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
		/// Name GetReservation
		/// Description Get reservation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RENB">Reservation number</param>
		/// <param name="m3_SQNB">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetReservationResponse></returns>
		/// <exception cref="M3Exception<GetReservationResponse>"></exception>
		public async Task<M3Response<GetReservationResponse>> GetReservation(
			string m3_RENB = null, 
			int? m3_SQNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetReservation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RENB))
				request.WithQueryParameter("RENB", m3_RENB.Trim());
			if (m3_SQNB.HasValue)
				request.WithQueryParameter("SQNB", m3_SQNB.Value.ToString());

			// Execute the request
			var result = await Execute<GetReservationResponse>(
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
		/// Name LstReservation
		/// Description List reservations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_AOCA">Acquistion order category</param>
		/// <param name="m3_ARDN">Acquisition order number</param>
		/// <param name="m3_ARDL">Acquisition order line</param>
		/// <param name="m3_ARDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReservationResponse></returns>
		/// <exception cref="M3Exception<LstReservationResponse>"></exception>
		public async Task<M3Response<LstReservationResponse>> LstReservation(
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_AOCA = null, 
			string m3_ARDN = null, 
			int? m3_ARDL = null, 
			int? m3_ARDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstReservation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOCA))
				request.WithQueryParameter("AOCA", m3_AOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARDN))
				request.WithQueryParameter("ARDN", m3_ARDN.Trim());
			if (m3_ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3_ARDL.Value.ToString());
			if (m3_ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3_ARDX.Value.ToString());

			// Execute the request
			var result = await Execute<LstReservationResponse>(
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
		/// Name PrioReserve
		/// Description Prioritized reservation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RENB">Reservation number</param>
		/// <param name="m3_SQNB">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrioReserve(
			string m3_RENB = null, 
			int? m3_SQNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrioReserve",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RENB))
				request.WithQueryParameter("RENB", m3_RENB.Trim());
			if (m3_SQNB.HasValue)
				request.WithQueryParameter("SQNB", m3_SQNB.Value.ToString());

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
		/// Name Reserve
		/// Description Reserve
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RENB">Reservation number</param>
		/// <param name="m3_SQNB">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Reserve(
			string m3_RENB = null, 
			int? m3_SQNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Reserve",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RENB))
				request.WithQueryParameter("RENB", m3_RENB.Trim());
			if (m3_SQNB.HasValue)
				request.WithQueryParameter("SQNB", m3_SQNB.Value.ToString());

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
		/// Name UnReserve
		/// Description Un-reserve
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RENB">Reservation number</param>
		/// <param name="m3_SQNB">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UnReserve(
			string m3_RENB = null, 
			int? m3_SQNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UnReserve",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RENB))
				request.WithQueryParameter("RENB", m3_RENB.Trim());
			if (m3_SQNB.HasValue)
				request.WithQueryParameter("SQNB", m3_SQNB.Value.ToString());

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
