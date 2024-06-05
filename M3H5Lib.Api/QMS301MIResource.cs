/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSpecToQIReqt
		/// Description Add Spec To QI Request
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3QRID">Request ID (Required)</param>
		/// <param name="m3SPEC">Specification (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3QSE1">Effective date (Required)</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3SPRE">LI specification manager</param>
		/// <param name="m3SPAN">Laboratory manager</param>
		/// <param name="m3NBEX">Number of copies</param>
		/// <param name="m3SI01">Comments</param>
		/// <param name="m3SI02">Comments</param>
		/// <param name="m3SI03">Comments</param>
		/// <param name="m3SI04">Comments</param>
		/// <param name="m3SI05">Comments</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSpecToQIReqt(
			string m3FACI, 
			string m3QRID, 
			string m3SPEC, 
			string m3ITNO, 
			DateTime m3QSE1, 
			int? m3QSE2 = null, 
			string m3SPRE = null, 
			string m3SPAN = null, 
			int? m3NBEX = null, 
			string m3SI01 = null, 
			string m3SI02 = null, 
			string m3SI03 = null, 
			string m3SI04 = null, 
			string m3SI05 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSpecToQIReqt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3QRID))
				throw new ArgumentNullException(nameof(m3QRID));
			if (string.IsNullOrWhiteSpace(m3SPEC))
				throw new ArgumentNullException(nameof(m3SPEC));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("QRID", m3QRID.Trim())
				.WithQueryParameter("SPEC", m3SPEC.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("QSE1", m3QSE1.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPRE))
				request.WithQueryParameter("SPRE", m3SPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPAN))
				request.WithQueryParameter("SPAN", m3SPAN.Trim());
			if (m3NBEX.HasValue)
				request.WithQueryParameter("NBEX", m3NBEX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SI01))
				request.WithQueryParameter("SI01", m3SI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI02))
				request.WithQueryParameter("SI02", m3SI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI03))
				request.WithQueryParameter("SI03", m3SI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI04))
				request.WithQueryParameter("SI04", m3SI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI05))
				request.WithQueryParameter("SI05", m3SI05.Trim());

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
		/// Name DelSpecToQIReqt
		/// Description Delete Spec To QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSpecToQIReqt(
			string m3FACI = null, 
			string m3QRID = null, 
			string m3SPEC = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelSpecToQIReqt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetSpecQIReqt
		/// Description Get QI Spec
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSpecQIReqtResponse></returns>
		/// <exception cref="M3Exception<GetSpecQIReqtResponse>"></exception>
		public async Task<M3Response<GetSpecQIReqtResponse>> GetSpecQIReqt(
			string m3FACI = null, 
			string m3QRID = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3SPEC = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSpecQIReqt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSpecQIReqtResponse>(
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
		/// Name LstSpecQIReqt
		/// Description List QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecQIReqtResponse></returns>
		/// <exception cref="M3Exception<LstSpecQIReqtResponse>"></exception>
		public async Task<M3Response<LstSpecQIReqtResponse>> LstSpecQIReqt(
			string m3FACI = null, 
			string m3QRID = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3SPEC = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSpecQIReqt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSpecQIReqtResponse>(
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
		/// Name UpdSpecToQIReqt
		/// Description Update Spec To QI Request
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3QRID">Request ID</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3SPRE">LI specification manager</param>
		/// <param name="m3SPAN">Laboratory manager</param>
		/// <param name="m3NBEX">Number of copies</param>
		/// <param name="m3SI01">Comments</param>
		/// <param name="m3SI02">Comments</param>
		/// <param name="m3SI03">Comments</param>
		/// <param name="m3SI04">Comments</param>
		/// <param name="m3SI05">Comments</param>
		/// <param name="m3QSST">Specification status</param>
		/// <param name="m3OVDT">Overrided date</param>
		/// <param name="m3OVUS">Overrided by</param>
		/// <param name="m3OVTE">Overrided time</param>
		/// <param name="m3QRSN">Reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSpecToQIReqt(
			string m3FACI = null, 
			string m3QRID = null, 
			string m3SPEC = null, 
			string m3ITNO = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
			string m3SPRE = null, 
			string m3SPAN = null, 
			int? m3NBEX = null, 
			string m3SI01 = null, 
			string m3SI02 = null, 
			string m3SI03 = null, 
			string m3SI04 = null, 
			string m3SI05 = null, 
			int? m3QSST = null, 
			DateTime? m3OVDT = null, 
			string m3OVUS = null, 
			int? m3OVTE = null, 
			string m3QRSN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdSpecToQIReqt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3QRID))
				request.WithQueryParameter("QRID", m3QRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPRE))
				request.WithQueryParameter("SPRE", m3SPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPAN))
				request.WithQueryParameter("SPAN", m3SPAN.Trim());
			if (m3NBEX.HasValue)
				request.WithQueryParameter("NBEX", m3NBEX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SI01))
				request.WithQueryParameter("SI01", m3SI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI02))
				request.WithQueryParameter("SI02", m3SI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI03))
				request.WithQueryParameter("SI03", m3SI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI04))
				request.WithQueryParameter("SI04", m3SI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI05))
				request.WithQueryParameter("SI05", m3SI05.Trim());
			if (m3QSST.HasValue)
				request.WithQueryParameter("QSST", m3QSST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OVDT.HasValue)
				request.WithQueryParameter("OVDT", m3OVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OVUS))
				request.WithQueryParameter("OVUS", m3OVUS.Trim());
			if (m3OVTE.HasValue)
				request.WithQueryParameter("OVTE", m3OVTE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QRSN))
				request.WithQueryParameter("QRSN", m3QRSN.Trim());

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
