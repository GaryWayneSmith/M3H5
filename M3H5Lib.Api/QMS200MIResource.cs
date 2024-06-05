/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QMS200MI;
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
	/// Name: QMS200MI
	/// Component Name: Test Specification
	/// Description: Api: Test Specification Interface
	/// Version Release: 5ea2
	///</summary>
	public partial class QMS200MIResource : M3BaseResourceEndpoint
	{
		public QMS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSpec
		/// Description Add Specification
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_QSI1">Inactive date</param>
		/// <param name="m3_QSI2">Inactive time</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_APDT">Date approved</param>
		/// <param name="m3_APUS">Approved by</param>
		/// <param name="m3_DVDT">Deactivated date</param>
		/// <param name="m3_DVUS">Deactivated by</param>
		/// <param name="m3_SPET">Spec type</param>
		/// <param name="m3_SRTT">Retest</param>
		/// <param name="m3_SRCL">Reclassification</param>
		/// <param name="m3_AUAT">Auto attach</param>
		/// <param name="m3_SPRE">LI specification manager</param>
		/// <param name="m3_SPAN">Laboratory manager</param>
		/// <param name="m3_NBEX">Number of copies</param>
		/// <param name="m3_SI01">Comments</param>
		/// <param name="m3_SI02">Comments</param>
		/// <param name="m3_SI03">Comments</param>
		/// <param name="m3_SI04">Comments</param>
		/// <param name="m3_SI05">Comments</param>
		/// <param name="m3_TPSH">Test at pre-shipment</param>
		/// <param name="m3_QSET">Quality Set</param>
		/// <param name="m3_SBLN">Blending</param>
		/// <param name="m3_SAGN">Selectable for agreement</param>
		/// <param name="m3_SDOR">Retest DO receipt</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSpec(
			string m3_SPEC = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			DateTime? m3_QSI1 = null, 
			int? m3_QSI2 = null, 
			string m3_TX40 = null, 
			string m3_STAT = null, 
			DateTime? m3_APDT = null, 
			string m3_APUS = null, 
			DateTime? m3_DVDT = null, 
			string m3_DVUS = null, 
			int? m3_SPET = null, 
			int? m3_SRTT = null, 
			int? m3_SRCL = null, 
			int? m3_AUAT = null, 
			string m3_SPRE = null, 
			string m3_SPAN = null, 
			int? m3_NBEX = null, 
			string m3_SI01 = null, 
			string m3_SI02 = null, 
			string m3_SI03 = null, 
			string m3_SI04 = null, 
			string m3_SI05 = null, 
			int? m3_TPSH = null, 
			string m3_QSET = null, 
			int? m3_SBLN = null, 
			int? m3_SAGN = null, 
			int? m3_SDOR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (m3_QSI1.HasValue)
				request.WithQueryParameter("QSI1", m3_QSI1.Value.ToM3String());
			if (m3_QSI2.HasValue)
				request.WithQueryParameter("QSI2", m3_QSI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_APDT.HasValue)
				request.WithQueryParameter("APDT", m3_APDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_APUS))
				request.WithQueryParameter("APUS", m3_APUS.Trim());
			if (m3_DVDT.HasValue)
				request.WithQueryParameter("DVDT", m3_DVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_DVUS))
				request.WithQueryParameter("DVUS", m3_DVUS.Trim());
			if (m3_SPET.HasValue)
				request.WithQueryParameter("SPET", m3_SPET.Value.ToString());
			if (m3_SRTT.HasValue)
				request.WithQueryParameter("SRTT", m3_SRTT.Value.ToString());
			if (m3_SRCL.HasValue)
				request.WithQueryParameter("SRCL", m3_SRCL.Value.ToString());
			if (m3_AUAT.HasValue)
				request.WithQueryParameter("AUAT", m3_AUAT.Value.ToString());
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
			if (m3_TPSH.HasValue)
				request.WithQueryParameter("TPSH", m3_TPSH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QSET))
				request.WithQueryParameter("QSET", m3_QSET.Trim());
			if (m3_SBLN.HasValue)
				request.WithQueryParameter("SBLN", m3_SBLN.Value.ToString());
			if (m3_SAGN.HasValue)
				request.WithQueryParameter("SAGN", m3_SAGN.Value.ToString());
			if (m3_SDOR.HasValue)
				request.WithQueryParameter("SDOR", m3_SDOR.Value.ToString());

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
		/// Name DltSpec
		/// Description Delet Specification
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSpec(
			string m3_SPEC = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
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
		/// Name GetSpec
		/// Description Get details from the QMSSPE. Allow warnings to continue
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSpecResponse></returns>
		/// <exception cref="M3Exception<GetSpecResponse>"></exception>
		public async Task<M3Response<GetSpecResponse>> GetSpec(
			string m3_SPEC = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());

			// Execute the request
			var result = await Execute<GetSpecResponse>(
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
		/// Name LstSpecsByItem
		/// Description List of specs by items
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecsByItemResponse></returns>
		/// <exception cref="M3Exception<LstSpecsByItemResponse>"></exception>
		public async Task<M3Response<LstSpecsByItemResponse>> LstSpecsByItem(
			string m3_ITNO = null, 
			string m3_SPEC = null, 
			string m3_QMGP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSpecsByItem",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());

			// Execute the request
			var result = await Execute<LstSpecsByItemResponse>(
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
		/// Name LstSpecsByQMGP
		/// Description List of specs by quality groups
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecsByQMGPResponse></returns>
		/// <exception cref="M3Exception<LstSpecsByQMGPResponse>"></exception>
		public async Task<M3Response<LstSpecsByQMGPResponse>> LstSpecsByQMGP(
			string m3_QMGP = null, 
			string m3_SPEC = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSpecsByQMGP",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());

			// Execute the request
			var result = await Execute<LstSpecsByQMGPResponse>(
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
		/// Name LstSpecsByRange
		/// Description List of specs by item and date/time range
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FITM">From Item number</param>
		/// <param name="m3_TITM">To Item number</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_FQS1">From Effective date</param>
		/// <param name="m3_FQS2">From Effective time</param>
		/// <param name="m3_TQS1">To Effective date</param>
		/// <param name="m3_TQS2">To Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecsByRangeResponse></returns>
		/// <exception cref="M3Exception<LstSpecsByRangeResponse>"></exception>
		public async Task<M3Response<LstSpecsByRangeResponse>> LstSpecsByRange(
			string m3_FITM = null, 
			string m3_TITM = null, 
			string m3_SPEC = null, 
			string m3_QMGP = null, 
			DateTime? m3_FQS1 = null, 
			int? m3_FQS2 = null, 
			DateTime? m3_TQS1 = null, 
			int? m3_TQS2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSpecsByRange",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FITM))
				request.WithQueryParameter("FITM", m3_FITM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITM))
				request.WithQueryParameter("TITM", m3_TITM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_FQS1.HasValue)
				request.WithQueryParameter("FQS1", m3_FQS1.Value.ToM3String());
			if (m3_FQS2.HasValue)
				request.WithQueryParameter("FQS2", m3_FQS2.Value.ToString());
			if (m3_TQS1.HasValue)
				request.WithQueryParameter("TQS1", m3_TQS1.Value.ToM3String());
			if (m3_TQS2.HasValue)
				request.WithQueryParameter("TQS2", m3_TQS2.Value.ToString());

			// Execute the request
			var result = await Execute<LstSpecsByRangeResponse>(
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
		/// Name LstSpecsBySpec
		/// Description List of specs by specifications
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecsBySpecResponse></returns>
		/// <exception cref="M3Exception<LstSpecsBySpecResponse>"></exception>
		public async Task<M3Response<LstSpecsBySpecResponse>> LstSpecsBySpec(
			string m3_SPEC = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSpecsBySpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());

			// Execute the request
			var result = await Execute<LstSpecsBySpecResponse>(
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
		/// Name UpdSpec
		/// Description Update Specification
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QMGP">Quality group</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_QSI1">Inactive date</param>
		/// <param name="m3_QSI2">Inactive time</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_APDT">Date approved</param>
		/// <param name="m3_APUS">Approved by</param>
		/// <param name="m3_DVDT">Deactivated date</param>
		/// <param name="m3_DVUS">Deactivated by</param>
		/// <param name="m3_SPET">Spec type</param>
		/// <param name="m3_SRTT">Retest</param>
		/// <param name="m3_SRCL">Reclassification</param>
		/// <param name="m3_AUAT">Auto attach</param>
		/// <param name="m3_SPRE">LI specification manager</param>
		/// <param name="m3_SPAN">Laboratory manager</param>
		/// <param name="m3_NBEX">Number of copies</param>
		/// <param name="m3_SI01">Comments</param>
		/// <param name="m3_SI02">Comments</param>
		/// <param name="m3_SI03">Comments</param>
		/// <param name="m3_SI04">Comments</param>
		/// <param name="m3_SI05">Comments</param>
		/// <param name="m3_TPSH">Test at pre-shipment</param>
		/// <param name="m3_SBLN">Blending</param>
		/// <param name="m3_SAGN">Selectable for agreement</param>
		/// <param name="m3_SDOR">Retest DO receipt</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSpec(
			string m3_SPEC = null, 
			string m3_ITNO = null, 
			string m3_QMGP = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			DateTime? m3_QSI1 = null, 
			int? m3_QSI2 = null, 
			string m3_TX40 = null, 
			string m3_STAT = null, 
			DateTime? m3_APDT = null, 
			string m3_APUS = null, 
			DateTime? m3_DVDT = null, 
			string m3_DVUS = null, 
			int? m3_SPET = null, 
			int? m3_SRTT = null, 
			int? m3_SRCL = null, 
			int? m3_AUAT = null, 
			string m3_SPRE = null, 
			string m3_SPAN = null, 
			int? m3_NBEX = null, 
			string m3_SI01 = null, 
			string m3_SI02 = null, 
			string m3_SI03 = null, 
			string m3_SI04 = null, 
			string m3_SI05 = null, 
			int? m3_TPSH = null, 
			int? m3_SBLN = null, 
			int? m3_SAGN = null, 
			int? m3_SDOR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QMGP))
				request.WithQueryParameter("QMGP", m3_QMGP.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (m3_QSI1.HasValue)
				request.WithQueryParameter("QSI1", m3_QSI1.Value.ToM3String());
			if (m3_QSI2.HasValue)
				request.WithQueryParameter("QSI2", m3_QSI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_APDT.HasValue)
				request.WithQueryParameter("APDT", m3_APDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_APUS))
				request.WithQueryParameter("APUS", m3_APUS.Trim());
			if (m3_DVDT.HasValue)
				request.WithQueryParameter("DVDT", m3_DVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_DVUS))
				request.WithQueryParameter("DVUS", m3_DVUS.Trim());
			if (m3_SPET.HasValue)
				request.WithQueryParameter("SPET", m3_SPET.Value.ToString());
			if (m3_SRTT.HasValue)
				request.WithQueryParameter("SRTT", m3_SRTT.Value.ToString());
			if (m3_SRCL.HasValue)
				request.WithQueryParameter("SRCL", m3_SRCL.Value.ToString());
			if (m3_AUAT.HasValue)
				request.WithQueryParameter("AUAT", m3_AUAT.Value.ToString());
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
			if (m3_TPSH.HasValue)
				request.WithQueryParameter("TPSH", m3_TPSH.Value.ToString());
			if (m3_SBLN.HasValue)
				request.WithQueryParameter("SBLN", m3_SBLN.Value.ToString());
			if (m3_SAGN.HasValue)
				request.WithQueryParameter("SAGN", m3_SAGN.Value.ToString());
			if (m3_SDOR.HasValue)
				request.WithQueryParameter("SDOR", m3_SDOR.Value.ToString());

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
