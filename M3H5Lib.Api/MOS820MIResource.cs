/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name StartDisturb
		/// Description Start disturbance
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_WOSQ">Reporting number (Required)</param>
		/// <param name="m3_RUDI">Run disturbance</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartDisturb(
			long m3_CANO, 
			decimal m3_WOSQ, 
			string m3_RUDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartDisturb",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.ToString())
				.WithQueryParameter("WOSQ", m3_WOSQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RUDI))
				request.WithQueryParameter("RUDI", m3_RUDI.Trim());
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
		/// Name StartOp
		/// Description StartOp
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_SDAT">Clock date (Required)</param>
		/// <param name="m3_STTE">Clock time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartOp(
			string m3_MWNO, 
			int m3_OPNO, 
			string m3_EMNO, 
			DateTime m3_SDAT, 
			int m3_STTE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("EMNO", m3_EMNO.Trim())
				.WithQueryParameter("SDAT", m3_SDAT.ToM3String())
				.WithQueryParameter("STTE", m3_STTE.ToString());

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
		/// Name StartTravel
		/// Description StartTravel
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_SDAT">Clock date (Required)</param>
		/// <param name="m3_STTE">Clock time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartTravel(
			string m3_MWNO, 
			int m3_OPNO, 
			string m3_EMNO, 
			DateTime m3_SDAT, 
			int m3_STTE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartTravel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("EMNO", m3_EMNO.Trim())
				.WithQueryParameter("SDAT", m3_SDAT.ToM3String())
				.WithQueryParameter("STTE", m3_STTE.ToString());

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
		/// Description Stop disturbance
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_WOSQ">Reporting number (Required)</param>
		/// <param name="m3_RUDI">Run disturbance</param>
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
			long m3_CANO, 
			decimal m3_WOSQ, 
			string m3_RUDI = null, 
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

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.ToString())
				.WithQueryParameter("WOSQ", m3_WOSQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RUDI))
				request.WithQueryParameter("RUDI", m3_RUDI.Trim());
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
		/// Name StopOp
		/// Description StopOp
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_SDAT">Clock date (Required)</param>
		/// <param name="m3_STTE">Clock time (Required)</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_LCDE">Labor charge code</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_MAQA">Manufactured quantity</param>
		/// <param name="m3_SCQA">Scrapped quantity</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_INFR">Injury free</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopOp(
			string m3_MWNO, 
			int m3_OPNO, 
			string m3_EMNO, 
			DateTime m3_SDAT, 
			int m3_STTE, 
			string m3_PCTP = null, 
			string m3_LCDE = null, 
			int? m3_REND = null, 
			decimal? m3_MAQA = null, 
			decimal? m3_SCQA = null, 
			string m3_SCRE = null, 
			string m3_FCLA = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			int? m3_INFR = null, 
			string m3_REMK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StopOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("EMNO", m3_EMNO.Trim())
				.WithQueryParameter("SDAT", m3_SDAT.ToM3String())
				.WithQueryParameter("STTE", m3_STTE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCDE))
				request.WithQueryParameter("LCDE", m3_LCDE.Trim());
			if (m3_REND.HasValue)
				request.WithQueryParameter("REND", m3_REND.Value.ToString());
			if (m3_MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3_MAQA.Value.ToString());
			if (m3_SCQA.HasValue)
				request.WithQueryParameter("SCQA", m3_SCQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCRE))
				request.WithQueryParameter("SCRE", m3_SCRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (m3_INFR.HasValue)
				request.WithQueryParameter("INFR", m3_INFR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());

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
		/// Name StopTravel
		/// Description StopTravel
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_MWNO">Work order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_SDAT">Clock date (Required)</param>
		/// <param name="m3_STTE">Clock time (Required)</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_LCDE">Labor charge code</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopTravel(
			string m3_MWNO, 
			int m3_OPNO, 
			string m3_EMNO, 
			DateTime m3_SDAT, 
			int m3_STTE, 
			string m3_PCTP = null, 
			string m3_LCDE = null, 
			string m3_REMK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StopTravel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("EMNO", m3_EMNO.Trim())
				.WithQueryParameter("SDAT", m3_SDAT.ToM3String())
				.WithQueryParameter("STTE", m3_STTE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCDE))
				request.WithQueryParameter("LCDE", m3_LCDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());

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
		/// Description StopWorkOp
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_WOSQ">Reporting number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_MAQA">Manufactured quantity</param>
		/// <param name="m3_SCQA">Scrapped quantity</param>
		/// <param name="m3_SCRE">Rejection reason</param>
		/// <param name="m3_TMNO">Work group</param>
		/// <param name="m3_REND">Manual completion flag</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_LCDE">Labor charge code</param>
		/// <param name="m3_INFR">Injury free</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopWorkOp(
			long m3_CANO, 
			decimal m3_WOSQ, 
			string m3_TENR = null, 
			decimal? m3_MAQA = null, 
			decimal? m3_SCQA = null, 
			string m3_SCRE = null, 
			int? m3_TMNO = null, 
			int? m3_REND = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
			string m3_PCTP = null, 
			string m3_LCDE = null, 
			int? m3_INFR = null, 
			string m3_REMK = null, 
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

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.ToString())
				.WithQueryParameter("WOSQ", m3_WOSQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_MAQA.HasValue)
				request.WithQueryParameter("MAQA", m3_MAQA.Value.ToString());
			if (m3_SCQA.HasValue)
				request.WithQueryParameter("SCQA", m3_SCQA.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCDE))
				request.WithQueryParameter("LCDE", m3_LCDE.Trim());
			if (m3_INFR.HasValue)
				request.WithQueryParameter("INFR", m3_INFR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());

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
		/// Description StopWorkSetup
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CANO">Card number (Required)</param>
		/// <param name="m3_WOSQ">Reporting number (Required)</param>
		/// <param name="m3_TENR">Terminal number</param>
		/// <param name="m3_TMNO">Work group</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_LCDE">Labor charge code</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StopWorkSetup(
			long m3_CANO, 
			decimal m3_WOSQ, 
			string m3_TENR = null, 
			int? m3_TMNO = null, 
			DateTime? m3_SDAT = null, 
			int? m3_STTE = null, 
			string m3_PCTP = null, 
			string m3_LCDE = null, 
			string m3_REMK = null, 
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

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CANO", m3_CANO.ToString())
				.WithQueryParameter("WOSQ", m3_WOSQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TENR))
				request.WithQueryParameter("TENR", m3_TENR.Trim());
			if (m3_TMNO.HasValue)
				request.WithQueryParameter("TMNO", m3_TMNO.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToM3String());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCDE))
				request.WithQueryParameter("LCDE", m3_LCDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());

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
