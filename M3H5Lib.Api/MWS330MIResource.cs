/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddReservation
		/// Description Add manual reservation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3VTDT">Valid to</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3AOCA">Acquistion order category</param>
		/// <param name="m3ARDN">Acquisition order number</param>
		/// <param name="m3ARDL">Acquisition order line</param>
		/// <param name="m3ARDX">Line suffix</param>
		/// <param name="m3XRES">Reserve</param>
		/// <param name="m3TXP1">Text line  1</param>
		/// <param name="m3TXP2">Text line  2</param>
		/// <param name="m3TXP3">Text line  3</param>
		/// <param name="m3TXP4">Text line  4</param>
		/// <param name="m3TXP5">Text line  5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddReservationResponse></returns>
		/// <exception cref="M3Exception<AddReservationResponse>"></exception>
		public async Task<M3Response<AddReservationResponse>> AddReservation(
			string m3RESP = null, 
			string m3CUNO = null, 
			DateTime? m3VTDT = null, 
			DateTime? m3DWDT = null, 
			string m3WHLO = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3AOCA = null, 
			string m3ARDN = null, 
			int? m3ARDL = null, 
			int? m3ARDX = null, 
			int? m3XRES = null, 
			string m3TXP1 = null, 
			string m3TXP2 = null, 
			string m3TXP3 = null, 
			string m3TXP4 = null, 
			string m3TXP5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddReservation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3VTDT.HasValue)
				request.WithQueryParameter("VTDT", m3VTDT.Value.ToM3String());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOCA))
				request.WithQueryParameter("AOCA", m3AOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARDN))
				request.WithQueryParameter("ARDN", m3ARDN.Trim());
			if (m3ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3ARDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3ARDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3XRES.HasValue)
				request.WithQueryParameter("XRES", m3XRES.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXP1))
				request.WithQueryParameter("TXP1", m3TXP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXP2))
				request.WithQueryParameter("TXP2", m3TXP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXP3))
				request.WithQueryParameter("TXP3", m3TXP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXP4))
				request.WithQueryParameter("TXP4", m3TXP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXP5))
				request.WithQueryParameter("TXP5", m3TXP5.Trim());

			// Execute the request
			var result = await Execute<AddReservationResponse>(
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
		/// Name ChgReservation
		/// Description Change reservation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RENB">Reservation number</param>
		/// <param name="m3SQNB">Sequence number</param>
		/// <param name="m3PRI2">Priority</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3VTDT">Valid to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgReservation(
			string m3RENB = null, 
			int? m3SQNB = null, 
			int? m3PRI2 = null, 
			DateTime? m3PRDT = null, 
			DateTime? m3VTDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgReservation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RENB))
				request.WithQueryParameter("RENB", m3RENB.Trim());
			if (m3SQNB.HasValue)
				request.WithQueryParameter("SQNB", m3SQNB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRI2.HasValue)
				request.WithQueryParameter("PRI2", m3PRI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (m3VTDT.HasValue)
				request.WithQueryParameter("VTDT", m3VTDT.Value.ToM3String());

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
		/// Name DltReservation
		/// Description Delete reservation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RENB">Reservation number</param>
		/// <param name="m3SQNB">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltReservation(
			string m3RENB = null, 
			int? m3SQNB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltReservation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RENB))
				request.WithQueryParameter("RENB", m3RENB.Trim());
			if (m3SQNB.HasValue)
				request.WithQueryParameter("SQNB", m3SQNB.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetReservation
		/// Description Get reservation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RENB">Reservation number</param>
		/// <param name="m3SQNB">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetReservationResponse></returns>
		/// <exception cref="M3Exception<GetReservationResponse>"></exception>
		public async Task<M3Response<GetReservationResponse>> GetReservation(
			string m3RENB = null, 
			int? m3SQNB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetReservation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RENB))
				request.WithQueryParameter("RENB", m3RENB.Trim());
			if (m3SQNB.HasValue)
				request.WithQueryParameter("SQNB", m3SQNB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetReservationResponse>(
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
		/// Name LstReservation
		/// Description List reservations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3AOCA">Acquistion order category</param>
		/// <param name="m3ARDN">Acquisition order number</param>
		/// <param name="m3ARDL">Acquisition order line</param>
		/// <param name="m3ARDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReservationResponse></returns>
		/// <exception cref="M3Exception<LstReservationResponse>"></exception>
		public async Task<M3Response<LstReservationResponse>> LstReservation(
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3AOCA = null, 
			string m3ARDN = null, 
			int? m3ARDL = null, 
			int? m3ARDX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstReservation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOCA))
				request.WithQueryParameter("AOCA", m3AOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARDN))
				request.WithQueryParameter("ARDN", m3ARDN.Trim());
			if (m3ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3ARDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3ARDX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstReservationResponse>(
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
		/// Name PrioReserve
		/// Description Prioritized reservation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RENB">Reservation number</param>
		/// <param name="m3SQNB">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrioReserve(
			string m3RENB = null, 
			int? m3SQNB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrioReserve",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RENB))
				request.WithQueryParameter("RENB", m3RENB.Trim());
			if (m3SQNB.HasValue)
				request.WithQueryParameter("SQNB", m3SQNB.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Reserve
		/// Description Reserve
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RENB">Reservation number</param>
		/// <param name="m3SQNB">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Reserve(
			string m3RENB = null, 
			int? m3SQNB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Reserve",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RENB))
				request.WithQueryParameter("RENB", m3RENB.Trim());
			if (m3SQNB.HasValue)
				request.WithQueryParameter("SQNB", m3SQNB.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UnReserve
		/// Description Un-reserve
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RENB">Reservation number</param>
		/// <param name="m3SQNB">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UnReserve(
			string m3RENB = null, 
			int? m3SQNB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UnReserve",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RENB))
				request.WithQueryParameter("RENB", m3RENB.Trim());
			if (m3SQNB.HasValue)
				request.WithQueryParameter("SQNB", m3SQNB.Value.ToString(CultureInfo.CurrentCulture));

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
