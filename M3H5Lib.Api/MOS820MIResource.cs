/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
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
	/// Name: MOS820MI
	/// Component Name: TimeReporting
	/// Description: Start/Stop time reporting
	/// Version Release: 5ea1
	///</summary>
	public partial class MOS820MIResource : M3BaseResourceEndpoint
	{
		public MOS820MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS820MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name StartDisturb
		/// Description Start disturbance
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3WOSQ">Reporting number (Required)</param>
		/// <param name="m3RUDI">Run disturbance</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartDisturb(
			long m3CANO, 
			decimal m3WOSQ, 
			string m3RUDI = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartDisturb",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WOSQ", m3WOSQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RUDI))
				request.WithQueryParameter("RUDI", m3RUDI.Trim());
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name StartOp
		/// Description StartOp
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3SDAT">Clock date (Required)</param>
		/// <param name="m3STTE">Clock time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartOp(
			string m3MWNO, 
			int m3OPNO, 
			string m3EMNO, 
			DateTime m3SDAT, 
			int m3STTE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("EMNO", m3EMNO.Trim())
				.WithQueryParameter("SDAT", m3SDAT.ToM3String())
				.WithQueryParameter("STTE", m3STTE.ToString(CultureInfo.CurrentCulture));

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
		/// Name StartTravel
		/// Description StartTravel
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3SDAT">Clock date (Required)</param>
		/// <param name="m3STTE">Clock time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartTravel(
			string m3MWNO, 
			int m3OPNO, 
			string m3EMNO, 
			DateTime m3SDAT, 
			int m3STTE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartTravel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("EMNO", m3EMNO.Trim())
				.WithQueryParameter("SDAT", m3SDAT.ToM3String())
				.WithQueryParameter("STTE", m3STTE.ToString(CultureInfo.CurrentCulture));

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
		/// Name StopDisturb
		/// Description Stop disturbance
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3WOSQ">Reporting number (Required)</param>
		/// <param name="m3RUDI">Run disturbance</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopDisturb(
			long m3CANO, 
			decimal m3WOSQ, 
			string m3RUDI = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopDisturb",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WOSQ", m3WOSQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RUDI))
				request.WithQueryParameter("RUDI", m3RUDI.Trim());
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name StopOp
		/// Description StopOp
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3SDAT">Clock date (Required)</param>
		/// <param name="m3STTE">Clock time (Required)</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3LCDE">Labor charge code</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3MAQA">Manufactured quantity</param>
		/// <param name="m3SCQA">Scrapped quantity</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3FCLA">Error code 1</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3INFR">Injury free</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopOp(
			string m3MWNO, 
			int m3OPNO, 
			string m3EMNO, 
			DateTime m3SDAT, 
			int m3STTE, 
			string m3PCTP = null, 
			string m3LCDE = null, 
			int? m3REND = null, 
			decimal? m3MAQA = null, 
			decimal? m3SCQA = null, 
			string m3SCRE = null, 
			string m3FCLA = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			int? m3INFR = null, 
			string m3REMK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("EMNO", m3EMNO.Trim())
				.WithQueryParameter("SDAT", m3SDAT.ToM3String())
				.WithQueryParameter("STTE", m3STTE.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCDE))
				request.WithQueryParameter("LCDE", m3LCDE.Trim());
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3MAQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCQA.HasValue)
				request.WithQueryParameter("SCQA", m3SCQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCLA))
				request.WithQueryParameter("FCLA", m3FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (m3INFR.HasValue)
				request.WithQueryParameter("INFR", m3INFR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());

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
		/// Name StopTravel
		/// Description StopTravel
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3SDAT">Clock date (Required)</param>
		/// <param name="m3STTE">Clock time (Required)</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3LCDE">Labor charge code</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopTravel(
			string m3MWNO, 
			int m3OPNO, 
			string m3EMNO, 
			DateTime m3SDAT, 
			int m3STTE, 
			string m3PCTP = null, 
			string m3LCDE = null, 
			string m3REMK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopTravel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("EMNO", m3EMNO.Trim())
				.WithQueryParameter("SDAT", m3SDAT.ToM3String())
				.WithQueryParameter("STTE", m3STTE.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCDE))
				request.WithQueryParameter("LCDE", m3LCDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());

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
		/// Name StopWorkOp
		/// Description StopWorkOp
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3WOSQ">Reporting number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3MAQA">Manufactured quantity</param>
		/// <param name="m3SCQA">Scrapped quantity</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3TMNO">Work group</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3LCDE">Labor charge code</param>
		/// <param name="m3INFR">Injury free</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopWorkOp(
			long m3CANO, 
			decimal m3WOSQ, 
			string m3TENR = null, 
			decimal? m3MAQA = null, 
			decimal? m3SCQA = null, 
			string m3SCRE = null, 
			int? m3TMNO = null, 
			int? m3REND = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
			string m3PCTP = null, 
			string m3LCDE = null, 
			int? m3INFR = null, 
			string m3REMK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopWorkOp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WOSQ", m3WOSQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3MAQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCQA.HasValue)
				request.WithQueryParameter("SCQA", m3SCQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCRE))
				request.WithQueryParameter("SCRE", m3SCRE.Trim());
			if (m3TMNO.HasValue)
				request.WithQueryParameter("TMNO", m3TMNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REND.HasValue)
				request.WithQueryParameter("REND", m3REND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCDE))
				request.WithQueryParameter("LCDE", m3LCDE.Trim());
			if (m3INFR.HasValue)
				request.WithQueryParameter("INFR", m3INFR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());

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
		/// Name StopWorkSetup
		/// Description StopWorkSetup
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CANO">Card number (Required)</param>
		/// <param name="m3WOSQ">Reporting number (Required)</param>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3TMNO">Work group</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3LCDE">Labor charge code</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopWorkSetup(
			long m3CANO, 
			decimal m3WOSQ, 
			string m3TENR = null, 
			int? m3TMNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
			string m3PCTP = null, 
			string m3LCDE = null, 
			string m3REMK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StopWorkSetup",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3CANO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WOSQ", m3WOSQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3TMNO.HasValue)
				request.WithQueryParameter("TMNO", m3TMNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCDE))
				request.WithQueryParameter("LCDE", m3LCDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());

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
