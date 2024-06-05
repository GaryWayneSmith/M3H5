/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.RPS170MI;
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
	/// Name: RPS170MI
	/// Component Name: Macro orders
	/// Description: Transfer DemandOrder
	/// Version Release: 13.1
	///</summary>
	public partial class RPS170MIResource : M3BaseResourceEndpoint
	{
		public RPS170MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "RPS170MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GenDEOStat
		/// Description Generate Demand Order Statistics
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FRES">Responsible</param>
		/// <param name="m3_TRES">Responsible</param>
		/// <param name="m3_FWLO">From warehouse</param>
		/// <param name="m3_TWLO">To warehouse</param>
		/// <param name="m3_FITN">From item number</param>
		/// <param name="m3_TITN">To item number</param>
		/// <param name="m3_FREF">Reference number</param>
		/// <param name="m3_TREF">Reference number</param>
		/// <param name="m3_FDEN">From Order number</param>
		/// <param name="m3_TDEN">To Order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GenDEOStatResponse></returns>
		/// <exception cref="M3Exception<GenDEOStatResponse>"></exception>
		public async Task<M3Response<GenDEOStatResponse>> GenDEOStat(
			string m3_FRES = null, 
			string m3_TRES = null, 
			string m3_FWLO = null, 
			string m3_TWLO = null, 
			string m3_FITN = null, 
			string m3_TITN = null, 
			string m3_FREF = null, 
			string m3_TREF = null, 
			string m3_FDEN = null, 
			string m3_TDEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GenDEOStat",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FRES))
				request.WithQueryParameter("FRES", m3_FRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRES))
				request.WithQueryParameter("TRES", m3_TRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWLO))
				request.WithQueryParameter("FWLO", m3_FWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWLO))
				request.WithQueryParameter("TWLO", m3_TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FITN))
				request.WithQueryParameter("FITN", m3_FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITN))
				request.WithQueryParameter("TITN", m3_TITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FREF))
				request.WithQueryParameter("FREF", m3_FREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TREF))
				request.WithQueryParameter("TREF", m3_TREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDEN))
				request.WithQueryParameter("FDEN", m3_FDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDEN))
				request.WithQueryParameter("TDEN", m3_TDEN.Trim());

			// Execute the request
			var result = await Execute<GenDEOStatResponse>(
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
		/// Name GetDEORel
		/// Description Get Demand Order Relation
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FDEN">From  Order number</param>
		/// <param name="m3_TDEN">To Order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDEORelResponse></returns>
		/// <exception cref="M3Exception<GetDEORelResponse>"></exception>
		public async Task<M3Response<GetDEORelResponse>> GetDEORel(
			string m3_FDEN = null, 
			string m3_TDEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDEORel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FDEN))
				request.WithQueryParameter("FDEN", m3_FDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDEN))
				request.WithQueryParameter("TDEN", m3_TDEN.Trim());

			// Execute the request
			var result = await Execute<GetDEORelResponse>(
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
		/// Name GetDEOStat
		/// Description Get Demand Order Statistics
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FRES">From Responible</param>
		/// <param name="m3_TRES">To Responible</param>
		/// <param name="m3_FWLO">From warehouse</param>
		/// <param name="m3_TWLO">To warehouse</param>
		/// <param name="m3_FITN">From item number</param>
		/// <param name="m3_TITN">To item number</param>
		/// <param name="m3_FREF">Reference number</param>
		/// <param name="m3_TREF">Reference number</param>
		/// <param name="m3_FDEN">From  Order number</param>
		/// <param name="m3_TDEN">To Order number</param>
		/// <param name="m3_PUIT">Acquisition code</param>
		/// <param name="m3_REOD">Replenishment order</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDEOStatResponse></returns>
		/// <exception cref="M3Exception<GetDEOStatResponse>"></exception>
		public async Task<M3Response<GetDEOStatResponse>> GetDEOStat(
			string m3_FRES = null, 
			string m3_TRES = null, 
			string m3_FWLO = null, 
			string m3_TWLO = null, 
			string m3_FITN = null, 
			string m3_TITN = null, 
			string m3_FREF = null, 
			string m3_TREF = null, 
			string m3_FDEN = null, 
			string m3_TDEN = null, 
			int? m3_PUIT = null, 
			int? m3_REOD = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDEOStat",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FRES))
				request.WithQueryParameter("FRES", m3_FRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRES))
				request.WithQueryParameter("TRES", m3_TRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWLO))
				request.WithQueryParameter("FWLO", m3_FWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWLO))
				request.WithQueryParameter("TWLO", m3_TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FITN))
				request.WithQueryParameter("FITN", m3_FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITN))
				request.WithQueryParameter("TITN", m3_TITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FREF))
				request.WithQueryParameter("FREF", m3_FREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TREF))
				request.WithQueryParameter("TREF", m3_TREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDEN))
				request.WithQueryParameter("FDEN", m3_FDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDEN))
				request.WithQueryParameter("TDEN", m3_TDEN.Trim());
			if (m3_PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3_PUIT.Value.ToString());
			if (m3_REOD.HasValue)
				request.WithQueryParameter("REOD", m3_REOD.Value.ToString());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<GetDEOStatResponse>(
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
		/// Name LstDEONo
		/// Description List Demand  Order number
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_NREF">Reference number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDEONoResponse></returns>
		/// <exception cref="M3Exception<LstDEONoResponse>"></exception>
		public async Task<M3Response<LstDEONoResponse>> LstDEONo(
			string m3_NREF, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDEONo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_NREF))
				throw new ArgumentNullException("m3_NREF");

			// Set mandatory parameters
			request
				.WithQueryParameter("NREF", m3_NREF.Trim());

			// Execute the request
			var result = await Execute<LstDEONoResponse>(
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
		/// Name LstFWOAgr
		/// Description List Forward Order Agreement
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_PLDT">Planning date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFWOAgrResponse></returns>
		/// <exception cref="M3Exception<LstFWOAgrResponse>"></exception>
		public async Task<M3Response<LstFWOAgrResponse>> LstFWOAgr(
			string m3_CUNO = null, 
			DateTime? m3_PLDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFWOAgr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3_PLDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstFWOAgrResponse>(
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
		/// Name LstFWOAgrStart
		/// Description List Forward Order Agreement with Start Date
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_PLDT">Planning date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFWOAgrStartResponse></returns>
		/// <exception cref="M3Exception<LstFWOAgrStartResponse>"></exception>
		public async Task<M3Response<LstFWOAgrStartResponse>> LstFWOAgrStart(
			string m3_CUNO = null, 
			DateTime? m3_PLDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFWOAgrStart",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3_PLDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstFWOAgrStartResponse>(
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
