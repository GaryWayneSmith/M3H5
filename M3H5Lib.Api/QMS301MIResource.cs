/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QMS301MI;
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
	/// Name: QMS301MI
	/// Component Name: QI Specification
	/// Description: Api:QI Specification Interface
	/// Version Release: 5ea1
	///</summary>
	public partial class QMS301MIResource : M3BaseResourceEndpoint
	{
		public QMS301MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS301MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSpecToQIReqt
		/// Description Add Spec To QI Request
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_QRID">Request ID (Required)</param>
		/// <param name="m3_SPEC">Specification (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_QSE1">Effective date (Required)</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_SPRE">LI specification manager</param>
		/// <param name="m3_SPAN">Laboratory manager</param>
		/// <param name="m3_NBEX">Number of copies</param>
		/// <param name="m3_SI01">Comments</param>
		/// <param name="m3_SI02">Comments</param>
		/// <param name="m3_SI03">Comments</param>
		/// <param name="m3_SI04">Comments</param>
		/// <param name="m3_SI05">Comments</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSpecToQIReqt(
			string m3_FACI, 
			string m3_QRID, 
			string m3_SPEC, 
			string m3_ITNO, 
			DateTime m3_QSE1, 
			int? m3_QSE2 = null, 
			string m3_SPRE = null, 
			string m3_SPAN = null, 
			int? m3_NBEX = null, 
			string m3_SI01 = null, 
			string m3_SI02 = null, 
			string m3_SI03 = null, 
			string m3_SI04 = null, 
			string m3_SI05 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSpecToQIReqt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_QRID))
				throw new ArgumentNullException("m3_QRID");
			if (string.IsNullOrWhiteSpace(m3_SPEC))
				throw new ArgumentNullException("m3_SPEC");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("QRID", m3_QRID.Trim())
				.WithQueryParameter("SPEC", m3_SPEC.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("QSE1", m3_QSE1.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPRE))
				request.WithQueryParameter("SPRE", m3_SPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPAN))
				request.WithQueryParameter("SPAN", m3_SPAN.Trim());
			if (m3_NBEX.HasValue)
				request.WithQueryParameter("NBEX", m3_NBEX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SI01))
				request.WithQueryParameter("SI01", m3_SI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI02))
				request.WithQueryParameter("SI02", m3_SI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI03))
				request.WithQueryParameter("SI03", m3_SI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI04))
				request.WithQueryParameter("SI04", m3_SI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI05))
				request.WithQueryParameter("SI05", m3_SI05.Trim());

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
		/// Name DelSpecToQIReqt
		/// Description Delete Spec To QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSpecToQIReqt(
			string m3_FACI = null, 
			string m3_QRID = null, 
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelSpecToQIReqt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());

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
		/// Name GetSpecQIReqt
		/// Description Get QI Spec
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSpecQIReqtResponse></returns>
		/// <exception cref="M3Exception<GetSpecQIReqtResponse>"></exception>
		public async Task<M3Response<GetSpecQIReqtResponse>> GetSpecQIReqt(
			string m3_FACI = null, 
			string m3_QRID = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSpecQIReqt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());

			// Execute the request
			var result = await Execute<GetSpecQIReqtResponse>(
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
		/// Name LstSpecQIReqt
		/// Description List QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecQIReqtResponse></returns>
		/// <exception cref="M3Exception<LstSpecQIReqtResponse>"></exception>
		public async Task<M3Response<LstSpecQIReqtResponse>> LstSpecQIReqt(
			string m3_FACI = null, 
			string m3_QRID = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSpecQIReqt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());

			// Execute the request
			var result = await Execute<LstSpecQIReqtResponse>(
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
		/// Name UpdSpecToQIReqt
		/// Description Update Spec To QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_QRID">Request ID</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_SPRE">LI specification manager</param>
		/// <param name="m3_SPAN">Laboratory manager</param>
		/// <param name="m3_NBEX">Number of copies</param>
		/// <param name="m3_SI01">Comments</param>
		/// <param name="m3_SI02">Comments</param>
		/// <param name="m3_SI03">Comments</param>
		/// <param name="m3_SI04">Comments</param>
		/// <param name="m3_SI05">Comments</param>
		/// <param name="m3_QSST">Specification status</param>
		/// <param name="m3_OVDT">Overrided date</param>
		/// <param name="m3_OVUS">Overrided by</param>
		/// <param name="m3_OVTE">Overrided time</param>
		/// <param name="m3_QRSN">Reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSpecToQIReqt(
			string m3_FACI = null, 
			string m3_QRID = null, 
			string m3_SPEC = null, 
			string m3_ITNO = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_SPRE = null, 
			string m3_SPAN = null, 
			int? m3_NBEX = null, 
			string m3_SI01 = null, 
			string m3_SI02 = null, 
			string m3_SI03 = null, 
			string m3_SI04 = null, 
			string m3_SI05 = null, 
			int? m3_QSST = null, 
			DateTime? m3_OVDT = null, 
			string m3_OVUS = null, 
			int? m3_OVTE = null, 
			string m3_QRSN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSpecToQIReqt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QRID))
				request.WithQueryParameter("QRID", m3_QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPRE))
				request.WithQueryParameter("SPRE", m3_SPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPAN))
				request.WithQueryParameter("SPAN", m3_SPAN.Trim());
			if (m3_NBEX.HasValue)
				request.WithQueryParameter("NBEX", m3_NBEX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SI01))
				request.WithQueryParameter("SI01", m3_SI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI02))
				request.WithQueryParameter("SI02", m3_SI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI03))
				request.WithQueryParameter("SI03", m3_SI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI04))
				request.WithQueryParameter("SI04", m3_SI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI05))
				request.WithQueryParameter("SI05", m3_SI05.Trim());
			if (m3_QSST.HasValue)
				request.WithQueryParameter("QSST", m3_QSST.Value.ToString());
			if (m3_OVDT.HasValue)
				request.WithQueryParameter("OVDT", m3_OVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OVUS))
				request.WithQueryParameter("OVUS", m3_OVUS.Trim());
			if (m3_OVTE.HasValue)
				request.WithQueryParameter("OVTE", m3_OVTE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QRSN))
				request.WithQueryParameter("QRSN", m3_QRSN.Trim());

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
