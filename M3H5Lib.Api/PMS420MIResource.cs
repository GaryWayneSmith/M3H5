/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.PMS420MI;
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
	/// Name: PMS420MI
	/// Component Name: Reportjob
	/// Description: Report Op setup and disturbance interface
	/// Version Release: 14.x
	///</summary>
	public partial class PMS420MIResource : M3BaseResourceEndpoint
	{
		public PMS420MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS420MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ChangeTeam
		/// Description Change workgroup
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3TMNO">Work group</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangeTeam(
			string m3TENR = null, 
			long? m3CANO = null, 
			int? m3TMNO = null, 
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChangeTeam",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TMNO.HasValue)
				request.WithQueryParameter("TMNO", m3TMNO.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name LstTransaction
		/// Description List reported operation transaction
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3OPTP">Operation report type</param>
		/// <param name="m3FICD">Open/closed record</param>
		/// <param name="m3FSTD">From Start date</param>
		/// <param name="m3TSTD">To Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTransactionResponse></returns>
		/// <exception cref="M3Exception<LstTransactionResponse>"></exception>
		public async Task<M3Response<LstTransactionResponse>> LstTransaction(
			decimal? m3WOSQ = null, 
			string m3EMNO = null, 
			long? m3CANO = null, 
			int? m3OPTP = null, 
			int? m3FICD = null, 
			DateTime? m3FSTD = null, 
			DateTime? m3TSTD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTransaction",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPTP.HasValue)
				request.WithQueryParameter("OPTP", m3OPTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FICD.HasValue)
				request.WithQueryParameter("FICD", m3FICD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSTD.HasValue)
				request.WithQueryParameter("FSTD", m3FSTD.Value.ToM3String());
			if (m3TSTD.HasValue)
				request.WithQueryParameter("TSTD", m3TSTD.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstTransactionResponse>(
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
		/// Name StartDisturb
		/// Description Start on disturbance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3DICE">Disturbance type</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="m3MSNO">Resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartDisturb(
			string m3TENR = null, 
			long? m3CANO = null, 
			decimal? m3WOSQ = null, 
			string m3DICE = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
			string m3MSNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartDisturb",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DICE))
				request.WithQueryParameter("DICE", m3DICE.Trim());
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNO))
				request.WithQueryParameter("MSNO", m3MSNO.Trim());

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
		/// Name StartWorkOp
		/// Description Start work on operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3TMNO">Work group</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="m3PLNO">Production lot number</param>
		/// <param name="m3MSNO">Resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartWorkOp(
			string m3TENR = null, 
			long? m3CANO = null, 
			decimal? m3WOSQ = null, 
			int? m3TMNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
			long? m3PLNO = null, 
			string m3MSNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartWorkOp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TMNO.HasValue)
				request.WithQueryParameter("TMNO", m3TMNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3PLNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNO))
				request.WithQueryParameter("MSNO", m3MSNO.Trim());

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
		/// Name StartWorkSetup
		/// Description Start work on setup
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3TMNO">Work group</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="m3PLNO">Production lot number</param>
		/// <param name="m3MSNO">Resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartWorkSetup(
			string m3TENR = null, 
			long? m3CANO = null, 
			decimal? m3WOSQ = null, 
			int? m3TMNO = null, 
			DateTime? m3SDAT = null, 
			int? m3STTE = null, 
			long? m3PLNO = null, 
			string m3MSNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartWorkSetup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TMNO.HasValue)
				request.WithQueryParameter("TMNO", m3TMNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToM3String());
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3PLNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MSNO))
				request.WithQueryParameter("MSNO", m3MSNO.Trim());

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
		/// Description Stop on disturbance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3DICE">Disturbance type</param>
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
			string m3TENR = null, 
			long? m3CANO = null, 
			decimal? m3WOSQ = null, 
			string m3DICE = null, 
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StopDisturb",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DICE))
				request.WithQueryParameter("DICE", m3DICE.Trim());
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
		/// Name StopWorkOp
		/// Description Stop work on operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3MAQA">Manufactured quantity</param>
		/// <param name="m3SCQA">Scrap quantity alternative unit</param>
		/// <param name="m3SCRE">Rejection reason</param>
		/// <param name="m3TMNO">Work group</param>
		/// <param name="m3REND">Manual completion flag</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopWorkOp(
			string m3TENR = null, 
			long? m3CANO = null, 
			decimal? m3WOSQ = null, 
			string m3MAQA = null, 
			string m3SCQA = null, 
			string m3SCRE = null, 
			int? m3TMNO = null, 
			int? m3REND = null, 
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StopWorkOp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MAQA))
				request.WithQueryParameter("MAQA", m3MAQA.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCQA))
				request.WithQueryParameter("SCQA", m3SCQA.Trim());
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
		/// Description Stop work on setup
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TENR">Terminal number</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3WOSQ">Reporting number</param>
		/// <param name="m3TMNO">Work group</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopWorkSetup(
			string m3TENR = null, 
			long? m3CANO = null, 
			decimal? m3WOSQ = null, 
			int? m3TMNO = null, 
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StopWorkSetup",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TENR))
				request.WithQueryParameter("TENR", m3TENR.Trim());
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3WOSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TMNO.HasValue)
				request.WithQueryParameter("TMNO", m3TMNO.Value.ToString(CultureInfo.CurrentCulture));
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
	}
}
// EOF
