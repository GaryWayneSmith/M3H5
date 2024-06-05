/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_TMNO">Work group</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangeTeam(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			int? m3_TMNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_TMNO.HasValue)
				request.WithQueryParameter("TMNO", m3_TMNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name LstTransaction
		/// Description List reported operation transaction
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_OPTP">Operation report type</param>
		/// <param name="m3_FICD">Open/closed record</param>
		/// <param name="m3_FSTD">From Start date</param>
		/// <param name="m3_TSTD">To Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTransactionResponse></returns>
		/// <exception cref="M3Exception<LstTransactionResponse>"></exception>
		public async Task<M3Response<LstTransactionResponse>> LstTransaction(
			decimal? m3_WOSQ = null, 
			string m3_EMNO = null, 
			long? m3_CANO = null, 
			int? m3_OPTP = null, 
			int? m3_FICD = null, 
			DateTime? m3_FSTD = null, 
			DateTime? m3_TSTD = null, 
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
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_OPTP.HasValue)
				request.WithQueryParameter("OPTP", m3_OPTP.Value.ToString());
			if (m3_FICD.HasValue)
				request.WithQueryParameter("FICD", m3_FICD.Value.ToString());
			if (m3_FSTD.HasValue)
				request.WithQueryParameter("FSTD", m3_FSTD.Value.ToM3String());
			if (m3_TSTD.HasValue)
				request.WithQueryParameter("TSTD", m3_TSTD.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstTransactionResponse>(
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
		/// Name StartDisturb
		/// Description Start on disturbance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_DICE">Disturbance type</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="m3_MSNO">Resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartDisturb(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			decimal? m3_WOSQ = null, 
			string m3_DICE = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
			string m3_MSNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DICE))
				request.WithQueryParameter("DICE", m3_DICE.Trim());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNO))
				request.WithQueryParameter("MSNO", m3_MSNO.Trim());

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
		/// Name StartWorkOp
		/// Description Start work on operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_TMNO">Work group</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="m3_PLNO">Production lot number</param>
		/// <param name="m3_MSNO">Resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartWorkOp(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			decimal? m3_WOSQ = null, 
			int? m3_TMNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
			long? m3_PLNO = null, 
			string m3_MSNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (m3_TMNO.HasValue)
				request.WithQueryParameter("TMNO", m3_TMNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());
			if (m3_PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3_PLNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNO))
				request.WithQueryParameter("MSNO", m3_MSNO.Trim());

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
		/// Name StartWorkSetup
		/// Description Start work on setup
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_TMNO">Work group</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="m3_PLNO">Production lot number</param>
		/// <param name="m3_MSNO">Resource</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartWorkSetup(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			decimal? m3_WOSQ = null, 
			int? m3_TMNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
			long? m3_PLNO = null, 
			string m3_MSNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (m3_TMNO.HasValue)
				request.WithQueryParameter("TMNO", m3_TMNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());
			if (m3_PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3_PLNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MSNO))
				request.WithQueryParameter("MSNO", m3_MSNO.Trim());

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
		/// Name StopDisturb
		/// Description Stop on disturbance
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_DICE">Disturbance type</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopDisturb(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			decimal? m3_WOSQ = null, 
			string m3_DICE = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DICE))
				request.WithQueryParameter("DICE", m3_DICE.Trim());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name StopWorkOp
		/// Description Stop work on operation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_MAQA">Manufactured quantity</param>
		/// <param name="m3_SCQA">Scrap quantity alternative unit</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_TMNO">Work group</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopWorkOp(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			decimal? m3_WOSQ = null, 
			string m3_MAQA = null, 
			string m3_SCQA = null, 
			string m3_SCRE = null, 
			int? m3_TMNO = null, 
			int? m3_REND = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAQA))
				request.WithQueryParameter("MAQA", m3_MAQA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCQA))
				request.WithQueryParameter("SCQA", m3_SCQA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (m3_TMNO.HasValue)
				request.WithQueryParameter("TMNO", m3_TMNO.Value.ToString());
			if (m3_REND.HasValue)
				request.WithQueryParameter("REND", m3_REND.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
		/// Name StopWorkSetup
		/// Description Stop work on setup
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_WOSQ">Reporting number</param>
		/// <param name="m3_TMNO">Work group</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopWorkSetup(
			string m3_TENR = null, 
			long? m3_CANO = null, 
			decimal? m3_WOSQ = null, 
			int? m3_TMNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (m3_WOSQ.HasValue)
				request.WithQueryParameter("WOSQ", m3_WOSQ.Value.ToString());
			if (m3_TMNO.HasValue)
				request.WithQueryParameter("TMNO", m3_TMNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());

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
