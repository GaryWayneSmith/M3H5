/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddQIRequest
		/// Description Add a QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3QRDT">QI request reqd date (Required)</param>
		/// <param name="m3TPS1">Test at pre-shipment (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3AUAT">Auto attach</param>
		/// <param name="m3SRTT">Retest</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3RIDI">Delivery number</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3RELI">Order line number</param>
		/// <param name="m3FSPE">Include future-dated spec</param>
		/// <param name="m3QIUS">QI req managed by</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddQIRequestResponse></returns>
		/// <exception cref="M3Exception<AddQIRequestResponse>"></exception>
		public async Task<M3Response<AddQIRequestResponse>> AddQIRequest(
			string m3FACI, 
			string m3ITNO, 
			DateTime m3QRDT, 
			int m3TPS1, 
			string m3BANO = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3AUAT = null, 
			int? m3SRTT = null, 
			int? m3RORX = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3CAMU = null, 
			decimal? m3RIDI = null, 
			long? m3REPN = null, 
			int? m3RELI = null, 
			int? m3FSPE = null, 
			string m3QIUS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddQIRequest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("QRDT", m3QRDT.ToM3String())
				.WithQueryParameter("TPS1", m3TPS1.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUAT.HasValue)
				request.WithQueryParameter("AUAT", m3AUAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRTT.HasValue)
				request.WithQueryParameter("SRTT", m3SRTT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3RIDI.HasValue)
				request.WithQueryParameter("RIDI", m3RIDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RELI.HasValue)
				request.WithQueryParameter("RELI", m3RELI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSPE.HasValue)
				request.WithQueryParameter("FSPE", m3FSPE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QIUS))
				request.WithQueryParameter("QIUS", m3QIUS.Trim());

			// Execute the request
			var result = await Execute<AddQIRequestResponse>(
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
		/// Name DltQIRequest
		/// Description Delete a QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3QRID">Request ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltQIRequest(
			string m3FACI, 
			string m3QRID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltQIRequest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3QRID))
				throw new ArgumentNullException(nameof(m3QRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("QRID", m3QRID.Trim());

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
		/// Name GetQIRequest
		/// Description Get data for a QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3QRID">Request ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQIRequestResponse></returns>
		/// <exception cref="M3Exception<GetQIRequestResponse>"></exception>
		public async Task<M3Response<GetQIRequestResponse>> GetQIRequest(
			string m3FACI, 
			string m3QRID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetQIRequest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3QRID))
				throw new ArgumentNullException(nameof(m3QRID));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("QRID", m3QRID.Trim());

			// Execute the request
			var result = await Execute<GetQIRequestResponse>(
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
		/// Name GetQIRqByREPN
		/// Description GetQIRqByREPN
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQIRqByREPNResponse></returns>
		/// <exception cref="M3Exception<GetQIRqByREPNResponse>"></exception>
		public async Task<M3Response<GetQIRqByREPNResponse>> GetQIRqByREPN(
			string m3WHLO = null, 
			string m3ITNO = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetQIRqByREPN",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetQIRqByREPNResponse>(
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
		/// Name GetQIRqByRefOrd
		/// Description GetQIRqByRefOrd
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3RORC">Reference order category (Required)</param>
		/// <param name="m3RORN">Reference order number (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3QITY">QI request origin</param>
		/// <param name="m3QSTA">QI request status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQIRqByRefOrdResponse></returns>
		/// <exception cref="M3Exception<GetQIRqByRefOrdResponse>"></exception>
		public async Task<M3Response<GetQIRqByRefOrdResponse>> GetQIRqByRefOrd(
			string m3FACI, 
			string m3ITNO, 
			int m3RORC, 
			string m3RORN, 
			string m3BANO = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			int? m3QITY = null, 
			int? m3QSTA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetQIRqByRefOrd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3RORN))
				throw new ArgumentNullException(nameof(m3RORN));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("RORC", m3RORC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RORN", m3RORN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QITY.HasValue)
				request.WithQueryParameter("QITY", m3QITY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QSTA.HasValue)
				request.WithQueryParameter("QSTA", m3QSTA.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetQIRqByRefOrdResponse>(
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
		/// Name LstQIRequest
		/// Description List QI Requests
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQIRequestResponse></returns>
		/// <exception cref="M3Exception<LstQIRequestResponse>"></exception>
		public async Task<M3Response<LstQIRequestResponse>> LstQIRequest(
			string m3FACI, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstQIRequest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Execute the request
			var result = await Execute<LstQIRequestResponse>(
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
		/// Name SearchQIRequest
		/// Description SearchQIRequest
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchQIRequestResponse></returns>
		/// <exception cref="M3Exception<SearchQIRequestResponse>"></exception>
		public async Task<M3Response<SearchQIRequestResponse>> SearchQIRequest(
			string m3SQRY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchQIRequest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchQIRequestResponse>(
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
		/// Name UpdQIRequest
		/// Description Update QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3QRID">Request ID (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3QRDT">QI request reqd date</param>
		/// <param name="m3QSTA">Request status</param>
		/// <param name="m3QAPR">QI request approval status</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3AUAT">Auto attach</param>
		/// <param name="m3SRTT">Retest</param>
		/// <param name="m3QIAP">Approved/rejected by</param>
		/// <param name="m3QIUS">QI req managed by</param>
		/// <param name="m3APDT">Date approved</param>
		/// <param name="m3QATM">Approved time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdQIRequest(
			string m3FACI, 
			string m3QRID, 
			string m3ITNO, 
			string m3BANO = null, 
			DateTime? m3QRDT = null, 
			int? m3QSTA = null, 
			int? m3QAPR = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3AUAT = null, 
			int? m3SRTT = null, 
			string m3QIAP = null, 
			string m3QIUS = null, 
			DateTime? m3APDT = null, 
			int? m3QATM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdQIRequest",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3QRID))
				throw new ArgumentNullException(nameof(m3QRID));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("QRID", m3QRID.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3QRDT.HasValue)
				request.WithQueryParameter("QRDT", m3QRDT.Value.ToM3String());
			if (m3QSTA.HasValue)
				request.WithQueryParameter("QSTA", m3QSTA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QAPR.HasValue)
				request.WithQueryParameter("QAPR", m3QAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUAT.HasValue)
				request.WithQueryParameter("AUAT", m3AUAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRTT.HasValue)
				request.WithQueryParameter("SRTT", m3SRTT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QIAP))
				request.WithQueryParameter("QIAP", m3QIAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3QIUS))
				request.WithQueryParameter("QIUS", m3QIUS.Trim());
			if (m3APDT.HasValue)
				request.WithQueryParameter("APDT", m3APDT.Value.ToM3String());
			if (m3QATM.HasValue)
				request.WithQueryParameter("QATM", m3QATM.Value.ToString(CultureInfo.CurrentCulture));

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
