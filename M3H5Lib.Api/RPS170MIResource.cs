/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3FRES">Responsible</param>
		/// <param name="m3TRES">Responsible</param>
		/// <param name="m3FWLO">From warehouse</param>
		/// <param name="m3TWLO">To warehouse</param>
		/// <param name="m3FITN">From item number</param>
		/// <param name="m3TITN">To item number</param>
		/// <param name="m3FREF">Reference number</param>
		/// <param name="m3TREF">Reference number</param>
		/// <param name="m3FDEN">From Order number</param>
		/// <param name="m3TDEN">To Order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GenDEOStatResponse></returns>
		/// <exception cref="M3Exception<GenDEOStatResponse>"></exception>
		public async Task<M3Response<GenDEOStatResponse>> GenDEOStat(
			string m3FRES = null, 
			string m3TRES = null, 
			string m3FWLO = null, 
			string m3TWLO = null, 
			string m3FITN = null, 
			string m3TITN = null, 
			string m3FREF = null, 
			string m3TREF = null, 
			string m3FDEN = null, 
			string m3TDEN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FRES))
				request.WithQueryParameter("FRES", m3FRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRES))
				request.WithQueryParameter("TRES", m3TRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWLO))
				request.WithQueryParameter("FWLO", m3FWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWLO))
				request.WithQueryParameter("TWLO", m3TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FITN))
				request.WithQueryParameter("FITN", m3FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITN))
				request.WithQueryParameter("TITN", m3TITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FREF))
				request.WithQueryParameter("FREF", m3FREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TREF))
				request.WithQueryParameter("TREF", m3TREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDEN))
				request.WithQueryParameter("FDEN", m3FDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDEN))
				request.WithQueryParameter("TDEN", m3TDEN.Trim());

			// Execute the request
			var result = await Execute<GenDEOStatResponse>(
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
		/// Name GetDEORel
		/// Description Get Demand Order Relation
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FDEN">From  Order number</param>
		/// <param name="m3TDEN">To Order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDEORelResponse></returns>
		/// <exception cref="M3Exception<GetDEORelResponse>"></exception>
		public async Task<M3Response<GetDEORelResponse>> GetDEORel(
			string m3FDEN = null, 
			string m3TDEN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FDEN))
				request.WithQueryParameter("FDEN", m3FDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDEN))
				request.WithQueryParameter("TDEN", m3TDEN.Trim());

			// Execute the request
			var result = await Execute<GetDEORelResponse>(
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
		/// Name GetDEOStat
		/// Description Get Demand Order Statistics
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FRES">From Responible</param>
		/// <param name="m3TRES">To Responible</param>
		/// <param name="m3FWLO">From warehouse</param>
		/// <param name="m3TWLO">To warehouse</param>
		/// <param name="m3FITN">From item number</param>
		/// <param name="m3TITN">To item number</param>
		/// <param name="m3FREF">Reference number</param>
		/// <param name="m3TREF">Reference number</param>
		/// <param name="m3FDEN">From  Order number</param>
		/// <param name="m3TDEN">To Order number</param>
		/// <param name="m3PUIT">Acquisition code</param>
		/// <param name="m3REOD">Replenishment order</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDEOStatResponse></returns>
		/// <exception cref="M3Exception<GetDEOStatResponse>"></exception>
		public async Task<M3Response<GetDEOStatResponse>> GetDEOStat(
			string m3FRES = null, 
			string m3TRES = null, 
			string m3FWLO = null, 
			string m3TWLO = null, 
			string m3FITN = null, 
			string m3TITN = null, 
			string m3FREF = null, 
			string m3TREF = null, 
			string m3FDEN = null, 
			string m3TDEN = null, 
			int? m3PUIT = null, 
			int? m3REOD = null, 
			decimal? m3LMTS = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FRES))
				request.WithQueryParameter("FRES", m3FRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRES))
				request.WithQueryParameter("TRES", m3TRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWLO))
				request.WithQueryParameter("FWLO", m3FWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWLO))
				request.WithQueryParameter("TWLO", m3TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FITN))
				request.WithQueryParameter("FITN", m3FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITN))
				request.WithQueryParameter("TITN", m3TITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FREF))
				request.WithQueryParameter("FREF", m3FREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TREF))
				request.WithQueryParameter("TREF", m3TREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDEN))
				request.WithQueryParameter("FDEN", m3FDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDEN))
				request.WithQueryParameter("TDEN", m3TDEN.Trim());
			if (m3PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3PUIT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REOD.HasValue)
				request.WithQueryParameter("REOD", m3REOD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDEOStatResponse>(
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
		/// Name LstDEONo
		/// Description List Demand  Order number
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3NREF">Reference number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDEONoResponse></returns>
		/// <exception cref="M3Exception<LstDEONoResponse>"></exception>
		public async Task<M3Response<LstDEONoResponse>> LstDEONo(
			string m3NREF, 
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
			if (string.IsNullOrWhiteSpace(m3NREF))
				throw new ArgumentNullException(nameof(m3NREF));

			// Set mandatory parameters
			request
				.WithQueryParameter("NREF", m3NREF.Trim());

			// Execute the request
			var result = await Execute<LstDEONoResponse>(
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
		/// Name LstFWOAgr
		/// Description List Forward Order Agreement
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3PLDT">Planning date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFWOAgrResponse></returns>
		/// <exception cref="M3Exception<LstFWOAgrResponse>"></exception>
		public async Task<M3Response<LstFWOAgrResponse>> LstFWOAgr(
			string m3CUNO = null, 
			DateTime? m3PLDT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3PLDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstFWOAgrResponse>(
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
		/// Name LstFWOAgrStart
		/// Description List Forward Order Agreement with Start Date
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3PLDT">Planning date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFWOAgrStartResponse></returns>
		/// <exception cref="M3Exception<LstFWOAgrStartResponse>"></exception>
		public async Task<M3Response<LstFWOAgrStartResponse>> LstFWOAgrStart(
			string m3CUNO = null, 
			DateTime? m3PLDT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3PLDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstFWOAgrStartResponse>(
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
