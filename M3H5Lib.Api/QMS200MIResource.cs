/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSpec
		/// Description Add Specification
		/// Version Release: 
		/// </summary>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3QSI1">Inactive date</param>
		/// <param name="m3QSI2">Inactive time</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3APDT">Date approved</param>
		/// <param name="m3APUS">Approved by</param>
		/// <param name="m3DVDT">Deactivated date</param>
		/// <param name="m3DVUS">Deactivated by</param>
		/// <param name="m3SPET">Spec type</param>
		/// <param name="m3SRTT">Retest</param>
		/// <param name="m3SRCL">Reclassification</param>
		/// <param name="m3AUAT">Auto attach</param>
		/// <param name="m3SPRE">LI specification manager</param>
		/// <param name="m3SPAN">Laboratory manager</param>
		/// <param name="m3NBEX">Number of copies</param>
		/// <param name="m3SI01">Comments</param>
		/// <param name="m3SI02">Comments</param>
		/// <param name="m3SI03">Comments</param>
		/// <param name="m3SI04">Comments</param>
		/// <param name="m3SI05">Comments</param>
		/// <param name="m3TPSH">Test at pre-shipment</param>
		/// <param name="m3QSET">Quality Set</param>
		/// <param name="m3SBLN">Blending</param>
		/// <param name="m3SAGN">Selectable for agreement</param>
		/// <param name="m3SDOR">Retest DO receipt</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSpec(
			string m3SPEC = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
			DateTime? m3QSI1 = null, 
			int? m3QSI2 = null, 
			string m3TX40 = null, 
			string m3STAT = null, 
			DateTime? m3APDT = null, 
			string m3APUS = null, 
			DateTime? m3DVDT = null, 
			string m3DVUS = null, 
			int? m3SPET = null, 
			int? m3SRTT = null, 
			int? m3SRCL = null, 
			int? m3AUAT = null, 
			string m3SPRE = null, 
			string m3SPAN = null, 
			int? m3NBEX = null, 
			string m3SI01 = null, 
			string m3SI02 = null, 
			string m3SI03 = null, 
			string m3SI04 = null, 
			string m3SI05 = null, 
			int? m3TPSH = null, 
			string m3QSET = null, 
			int? m3SBLN = null, 
			int? m3SAGN = null, 
			int? m3SDOR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QSI1.HasValue)
				request.WithQueryParameter("QSI1", m3QSI1.Value.ToM3String());
			if (m3QSI2.HasValue)
				request.WithQueryParameter("QSI2", m3QSI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3APDT.HasValue)
				request.WithQueryParameter("APDT", m3APDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3APUS))
				request.WithQueryParameter("APUS", m3APUS.Trim());
			if (m3DVDT.HasValue)
				request.WithQueryParameter("DVDT", m3DVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3DVUS))
				request.WithQueryParameter("DVUS", m3DVUS.Trim());
			if (m3SPET.HasValue)
				request.WithQueryParameter("SPET", m3SPET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRTT.HasValue)
				request.WithQueryParameter("SRTT", m3SRTT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRCL.HasValue)
				request.WithQueryParameter("SRCL", m3SRCL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUAT.HasValue)
				request.WithQueryParameter("AUAT", m3AUAT.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3TPSH.HasValue)
				request.WithQueryParameter("TPSH", m3TPSH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QSET))
				request.WithQueryParameter("QSET", m3QSET.Trim());
			if (m3SBLN.HasValue)
				request.WithQueryParameter("SBLN", m3SBLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAGN.HasValue)
				request.WithQueryParameter("SAGN", m3SAGN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDOR.HasValue)
				request.WithQueryParameter("SDOR", m3SDOR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltSpec
		/// Description Delet Specification
		/// Version Release: 
		/// </summary>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSpec(
			string m3SPEC = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
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
		/// Name GetSpec
		/// Description Get details from the QMSSPE. Allow warnings to continue
		/// Version Release: 
		/// </summary>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSpecResponse></returns>
		/// <exception cref="M3Exception<GetSpecResponse>"></exception>
		public async Task<M3Response<GetSpecResponse>> GetSpec(
			string m3SPEC = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSpecResponse>(
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
		/// Name LstSpecsByItem
		/// Description List of specs by items
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecsByItemResponse></returns>
		/// <exception cref="M3Exception<LstSpecsByItemResponse>"></exception>
		public async Task<M3Response<LstSpecsByItemResponse>> LstSpecsByItem(
			string m3ITNO = null, 
			string m3SPEC = null, 
			string m3QMGP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSpecsByItem",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSpecsByItemResponse>(
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
		/// Name LstSpecsByQMGP
		/// Description List of specs by quality groups
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecsByQMGPResponse></returns>
		/// <exception cref="M3Exception<LstSpecsByQMGPResponse>"></exception>
		public async Task<M3Response<LstSpecsByQMGPResponse>> LstSpecsByQMGP(
			string m3QMGP = null, 
			string m3SPEC = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSpecsByQMGP",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSpecsByQMGPResponse>(
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
		/// Name LstSpecsByRange
		/// Description List of specs by item and date/time range
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FITM">From Item number</param>
		/// <param name="m3TITM">To Item number</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3FQS1">From Effective date</param>
		/// <param name="m3FQS2">From Effective time</param>
		/// <param name="m3TQS1">To Effective date</param>
		/// <param name="m3TQS2">To Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecsByRangeResponse></returns>
		/// <exception cref="M3Exception<LstSpecsByRangeResponse>"></exception>
		public async Task<M3Response<LstSpecsByRangeResponse>> LstSpecsByRange(
			string m3FITM = null, 
			string m3TITM = null, 
			string m3SPEC = null, 
			string m3QMGP = null, 
			DateTime? m3FQS1 = null, 
			int? m3FQS2 = null, 
			DateTime? m3TQS1 = null, 
			int? m3TQS2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSpecsByRange",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FITM))
				request.WithQueryParameter("FITM", m3FITM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITM))
				request.WithQueryParameter("TITM", m3TITM.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3FQS1.HasValue)
				request.WithQueryParameter("FQS1", m3FQS1.Value.ToM3String());
			if (m3FQS2.HasValue)
				request.WithQueryParameter("FQS2", m3FQS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TQS1.HasValue)
				request.WithQueryParameter("TQS1", m3TQS1.Value.ToM3String());
			if (m3TQS2.HasValue)
				request.WithQueryParameter("TQS2", m3TQS2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSpecsByRangeResponse>(
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
		/// Name LstSpecsBySpec
		/// Description List of specs by specifications
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecsBySpecResponse></returns>
		/// <exception cref="M3Exception<LstSpecsBySpecResponse>"></exception>
		public async Task<M3Response<LstSpecsBySpecResponse>> LstSpecsBySpec(
			string m3SPEC = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSpecsBySpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSpecsBySpecResponse>(
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
		/// Name UpdSpec
		/// Description Update Specification
		/// Version Release: 
		/// </summary>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QMGP">Quality group</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3QSI1">Inactive date</param>
		/// <param name="m3QSI2">Inactive time</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3APDT">Date approved</param>
		/// <param name="m3APUS">Approved by</param>
		/// <param name="m3DVDT">Deactivated date</param>
		/// <param name="m3DVUS">Deactivated by</param>
		/// <param name="m3SPET">Spec type</param>
		/// <param name="m3SRTT">Retest</param>
		/// <param name="m3SRCL">Reclassification</param>
		/// <param name="m3AUAT">Auto attach</param>
		/// <param name="m3SPRE">LI specification manager</param>
		/// <param name="m3SPAN">Laboratory manager</param>
		/// <param name="m3NBEX">Number of copies</param>
		/// <param name="m3SI01">Comments</param>
		/// <param name="m3SI02">Comments</param>
		/// <param name="m3SI03">Comments</param>
		/// <param name="m3SI04">Comments</param>
		/// <param name="m3SI05">Comments</param>
		/// <param name="m3TPSH">Test at pre-shipment</param>
		/// <param name="m3SBLN">Blending</param>
		/// <param name="m3SAGN">Selectable for agreement</param>
		/// <param name="m3SDOR">Retest DO receipt</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSpec(
			string m3SPEC = null, 
			string m3ITNO = null, 
			string m3QMGP = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
			DateTime? m3QSI1 = null, 
			int? m3QSI2 = null, 
			string m3TX40 = null, 
			string m3STAT = null, 
			DateTime? m3APDT = null, 
			string m3APUS = null, 
			DateTime? m3DVDT = null, 
			string m3DVUS = null, 
			int? m3SPET = null, 
			int? m3SRTT = null, 
			int? m3SRCL = null, 
			int? m3AUAT = null, 
			string m3SPRE = null, 
			string m3SPAN = null, 
			int? m3NBEX = null, 
			string m3SI01 = null, 
			string m3SI02 = null, 
			string m3SI03 = null, 
			string m3SI04 = null, 
			string m3SI05 = null, 
			int? m3TPSH = null, 
			int? m3SBLN = null, 
			int? m3SAGN = null, 
			int? m3SDOR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QMGP))
				request.WithQueryParameter("QMGP", m3QMGP.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QSI1.HasValue)
				request.WithQueryParameter("QSI1", m3QSI1.Value.ToM3String());
			if (m3QSI2.HasValue)
				request.WithQueryParameter("QSI2", m3QSI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3APDT.HasValue)
				request.WithQueryParameter("APDT", m3APDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3APUS))
				request.WithQueryParameter("APUS", m3APUS.Trim());
			if (m3DVDT.HasValue)
				request.WithQueryParameter("DVDT", m3DVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3DVUS))
				request.WithQueryParameter("DVUS", m3DVUS.Trim());
			if (m3SPET.HasValue)
				request.WithQueryParameter("SPET", m3SPET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRTT.HasValue)
				request.WithQueryParameter("SRTT", m3SRTT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRCL.HasValue)
				request.WithQueryParameter("SRCL", m3SRCL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUAT.HasValue)
				request.WithQueryParameter("AUAT", m3AUAT.Value.ToString(CultureInfo.CurrentCulture));
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
			if (m3TPSH.HasValue)
				request.WithQueryParameter("TPSH", m3TPSH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SBLN.HasValue)
				request.WithQueryParameter("SBLN", m3SBLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAGN.HasValue)
				request.WithQueryParameter("SAGN", m3SAGN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDOR.HasValue)
				request.WithQueryParameter("SDOR", m3SDOR.Value.ToString(CultureInfo.CurrentCulture));

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
