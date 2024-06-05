/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QMS300MI;
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
	/// Name: QMS300MI
	/// Component Name: QI Request
	/// Description: Api: QI request interface
	/// Version Release: 5ea3
	///</summary>
	public partial class QMS300MIResource : M3BaseResourceEndpoint
	{
		public QMS300MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS300MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddQIRequest
		/// Description Add a QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_QRDT">QI request reqd date (Required)</param>
		/// <param name="m3_TPS1">Test at pre-shipment (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_AUAT">Auto attach</param>
		/// <param name="m3_SRTT">Retest</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_RIDI">Delivery number</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="m3_RELI">Order line number</param>
		/// <param name="m3_FSPE">Include future-dated spec</param>
		/// <param name="m3_QIUS">QI req managed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddQIRequestResponse></returns>
		/// <exception cref="M3Exception<AddQIRequestResponse>"></exception>
		public async Task<M3Response<AddQIRequestResponse>> AddQIRequest(
			string m3_FACI, 
			string m3_ITNO, 
			DateTime m3_QRDT, 
			int m3_TPS1, 
			string m3_BANO = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_AUAT = null, 
			int? m3_SRTT = null, 
			int? m3_RORX = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_CAMU = null, 
			decimal? m3_RIDI = null, 
			long? m3_REPN = null, 
			int? m3_RELI = null, 
			int? m3_FSPE = null, 
			string m3_QIUS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddQIRequest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("QRDT", m3_QRDT.ToM3String())
				.WithQueryParameter("TPS1", m3_TPS1.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_AUAT.HasValue)
				request.WithQueryParameter("AUAT", m3_AUAT.Value.ToString());
			if (m3_SRTT.HasValue)
				request.WithQueryParameter("SRTT", m3_SRTT.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3_RIDI.Value.ToString());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());
			if (m3_RELI.HasValue)
				request.WithQueryParameter("RELI", m3_RELI.Value.ToString());
			if (m3_FSPE.HasValue)
				request.WithQueryParameter("FSPE", m3_FSPE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QIUS))
				request.WithQueryParameter("QIUS", m3_QIUS.Trim());

			// Execute the request
			var result = await Execute<AddQIRequestResponse>(
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
		/// Name DltQIRequest
		/// Description Delete a QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_QRID">Request ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltQIRequest(
			string m3_FACI, 
			string m3_QRID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltQIRequest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_QRID))
				throw new ArgumentNullException("m3_QRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("QRID", m3_QRID.Trim());

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
		/// Name GetQIRequest
		/// Description Get data for a QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_QRID">Request ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQIRequestResponse></returns>
		/// <exception cref="M3Exception<GetQIRequestResponse>"></exception>
		public async Task<M3Response<GetQIRequestResponse>> GetQIRequest(
			string m3_FACI, 
			string m3_QRID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetQIRequest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_QRID))
				throw new ArgumentNullException("m3_QRID");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("QRID", m3_QRID.Trim());

			// Execute the request
			var result = await Execute<GetQIRequestResponse>(
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
		/// Name GetQIRqByREPN
		/// Description GetQIRqByREPN
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_REPN">Receiving number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQIRqByREPNResponse></returns>
		/// <exception cref="M3Exception<GetQIRqByREPNResponse>"></exception>
		public async Task<M3Response<GetQIRqByREPNResponse>> GetQIRqByREPN(
			string m3_WHLO = null, 
			string m3_ITNO = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			long? m3_REPN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetQIRqByREPN",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_REPN.HasValue)
				request.WithQueryParameter("REPN", m3_REPN.Value.ToString());

			// Execute the request
			var result = await Execute<GetQIRqByREPNResponse>(
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
		/// Name GetQIRqByRefOrd
		/// Description GetQIRqByRefOrd
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_RORC">Reference order category (Required)</param>
		/// <param name="m3_RORN">Reference order number (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_QITY">QI request origin</param>
		/// <param name="m3_QSTA">QI request status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQIRqByRefOrdResponse></returns>
		/// <exception cref="M3Exception<GetQIRqByRefOrdResponse>"></exception>
		public async Task<M3Response<GetQIRqByRefOrdResponse>> GetQIRqByRefOrd(
			string m3_FACI, 
			string m3_ITNO, 
			int m3_RORC, 
			string m3_RORN, 
			string m3_BANO = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			int? m3_QITY = null, 
			int? m3_QSTA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetQIRqByRefOrd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_RORN))
				throw new ArgumentNullException("m3_RORN");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("RORC", m3_RORC.ToString())
				.WithQueryParameter("RORN", m3_RORN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (m3_QITY.HasValue)
				request.WithQueryParameter("QITY", m3_QITY.Value.ToString());
			if (m3_QSTA.HasValue)
				request.WithQueryParameter("QSTA", m3_QSTA.Value.ToString());

			// Execute the request
			var result = await Execute<GetQIRqByRefOrdResponse>(
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
		/// Name LstQIRequest
		/// Description List QI Requests
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQIRequestResponse></returns>
		/// <exception cref="M3Exception<LstQIRequestResponse>"></exception>
		public async Task<M3Response<LstQIRequestResponse>> LstQIRequest(
			string m3_FACI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQIRequest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Execute the request
			var result = await Execute<LstQIRequestResponse>(
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
		/// Name SearchQIRequest
		/// Description SearchQIRequest
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchQIRequestResponse></returns>
		/// <exception cref="M3Exception<SearchQIRequestResponse>"></exception>
		public async Task<M3Response<SearchQIRequestResponse>> SearchQIRequest(
			string m3_SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchQIRequest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchQIRequestResponse>(
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
		/// Name UpdQIRequest
		/// Description Update QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_QRID">Request ID (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_QRDT">QI request reqd date</param>
		/// <param name="m3_QSTA">Request status</param>
		/// <param name="m3_QAPR">QI request approval status</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_AUAT">Auto attach</param>
		/// <param name="m3_SRTT">Retest</param>
		/// <param name="m3_QIAP">Approved/rejected by</param>
		/// <param name="m3_QIUS">QI req managed by</param>
		/// <param name="m3_APDT">Date approved</param>
		/// <param name="m3_QATM">Approved time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdQIRequest(
			string m3_FACI, 
			string m3_QRID, 
			string m3_ITNO, 
			string m3_BANO = null, 
			DateTime? m3_QRDT = null, 
			int? m3_QSTA = null, 
			int? m3_QAPR = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_AUAT = null, 
			int? m3_SRTT = null, 
			string m3_QIAP = null, 
			string m3_QIUS = null, 
			DateTime? m3_APDT = null, 
			int? m3_QATM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdQIRequest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_QRID))
				throw new ArgumentNullException("m3_QRID");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("QRID", m3_QRID.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_QRDT.HasValue)
				request.WithQueryParameter("QRDT", m3_QRDT.Value.ToM3String());
			if (m3_QSTA.HasValue)
				request.WithQueryParameter("QSTA", m3_QSTA.Value.ToString());
			if (m3_QAPR.HasValue)
				request.WithQueryParameter("QAPR", m3_QAPR.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_AUAT.HasValue)
				request.WithQueryParameter("AUAT", m3_AUAT.Value.ToString());
			if (m3_SRTT.HasValue)
				request.WithQueryParameter("SRTT", m3_SRTT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QIAP))
				request.WithQueryParameter("QIAP", m3_QIAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QIUS))
				request.WithQueryParameter("QIUS", m3_QIUS.Trim());
			if (m3_APDT.HasValue)
				request.WithQueryParameter("APDT", m3_APDT.Value.ToM3String());
			if (m3_QATM.HasValue)
				request.WithQueryParameter("QATM", m3_QATM.Value.ToString());

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
