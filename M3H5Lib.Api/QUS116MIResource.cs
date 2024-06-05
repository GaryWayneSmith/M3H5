/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QUS116MI;
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
	/// Name: QUS116MI
	/// Component Name: Financing
	/// Description: Api: Add Financing
	/// Version Release: 14.x
	///</summary>
	public partial class QUS116MIResource : M3BaseResourceEndpoint
	{
		public QUS116MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUS116MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddFinancing
		/// Description Add Financing
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QFIN">Financing (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_LVDT">Valid to (Required)</param>
		/// <param name="m3_FUND">Funder number (Required)</param>
		/// <param name="m3_AOTP">Agreement order type (Required)</param>
		/// <param name="m3_KTNO">Kit number (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_LKNR">ID number</param>
		/// <param name="m3_NOPR">Number of periods</param>
		/// <param name="m3_REPE">Residual %</param>
		/// <param name="m3_INTT">Interest type</param>
		/// <param name="m3_INPE">Interest rate</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_INAP">Industry Application</param>
		/// <param name="m3_OENV">Operational Environment</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_CUCL">Customer group</param>
		/// <param name="m3_DERE">Default record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFinancing(
			string m3_QFIN, 
			string m3_TX40, 
			DateTime m3_FVDT, 
			DateTime m3_LVDT, 
			string m3_FUND, 
			string m3_AOTP, 
			string m3_KTNO, 
			string m3_PRNO = null, 
			string m3_TX15 = null, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			string m3_LKNR = null, 
			int? m3_NOPR = null, 
			int? m3_REPE = null, 
			string m3_INTT = null, 
			decimal? m3_INPE = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_INAP = null, 
			string m3_OENV = null, 
			string m3_CUNO = null, 
			string m3_CUCL = null, 
			int? m3_DERE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFinancing",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QFIN))
				throw new ArgumentNullException("m3_QFIN");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_FUND))
				throw new ArgumentNullException("m3_FUND");
			if (string.IsNullOrWhiteSpace(m3_AOTP))
				throw new ArgumentNullException("m3_AOTP");
			if (string.IsNullOrWhiteSpace(m3_KTNO))
				throw new ArgumentNullException("m3_KTNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("QFIN", m3_QFIN.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("LVDT", m3_LVDT.ToM3String())
				.WithQueryParameter("FUND", m3_FUND.Trim())
				.WithQueryParameter("AOTP", m3_AOTP.Trim())
				.WithQueryParameter("KTNO", m3_KTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LKNR))
				request.WithQueryParameter("LKNR", m3_LKNR.Trim());
			if (m3_NOPR.HasValue)
				request.WithQueryParameter("NOPR", m3_NOPR.Value.ToString());
			if (m3_REPE.HasValue)
				request.WithQueryParameter("REPE", m3_REPE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INTT))
				request.WithQueryParameter("INTT", m3_INTT.Trim());
			if (m3_INPE.HasValue)
				request.WithQueryParameter("INPE", m3_INPE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INAP))
				request.WithQueryParameter("INAP", m3_INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OENV))
				request.WithQueryParameter("OENV", m3_OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCL))
				request.WithQueryParameter("CUCL", m3_CUCL.Trim());
			if (m3_DERE.HasValue)
				request.WithQueryParameter("DERE", m3_DERE.Value.ToString());

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
		/// Name ChgFinancing
		/// Description Change Financing
		/// Version Release: 
		/// </summary>
		/// <param name="m3_QFIN">Financing (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_LKNR">ID number</param>
		/// <param name="m3_FUND">Funder number</param>
		/// <param name="m3_AOTP">Agreement order type</param>
		/// <param name="m3_KTNO">Kit number</param>
		/// <param name="m3_NOPR">Number of periods</param>
		/// <param name="m3_REPE">Residual %</param>
		/// <param name="m3_INTT">Interest type</param>
		/// <param name="m3_INPE">Interest rate</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_INAP">Industry Application</param>
		/// <param name="m3_OENV">Operational Environment</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_CUCL">Customer group</param>
		/// <param name="m3_DERE">Default record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgFinancing(
			string m3_QFIN, 
			string m3_PRNO = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			string m3_LKNR = null, 
			string m3_FUND = null, 
			string m3_AOTP = null, 
			string m3_KTNO = null, 
			int? m3_NOPR = null, 
			int? m3_REPE = null, 
			string m3_INTT = null, 
			decimal? m3_INPE = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_INAP = null, 
			string m3_OENV = null, 
			string m3_CUNO = null, 
			string m3_CUCL = null, 
			int? m3_DERE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgFinancing",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QFIN))
				throw new ArgumentNullException("m3_QFIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("QFIN", m3_QFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_LKNR))
				request.WithQueryParameter("LKNR", m3_LKNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUND))
				request.WithQueryParameter("FUND", m3_FUND.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOTP))
				request.WithQueryParameter("AOTP", m3_AOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KTNO))
				request.WithQueryParameter("KTNO", m3_KTNO.Trim());
			if (m3_NOPR.HasValue)
				request.WithQueryParameter("NOPR", m3_NOPR.Value.ToString());
			if (m3_REPE.HasValue)
				request.WithQueryParameter("REPE", m3_REPE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INTT))
				request.WithQueryParameter("INTT", m3_INTT.Trim());
			if (m3_INPE.HasValue)
				request.WithQueryParameter("INPE", m3_INPE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INAP))
				request.WithQueryParameter("INAP", m3_INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OENV))
				request.WithQueryParameter("OENV", m3_OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCL))
				request.WithQueryParameter("CUCL", m3_CUCL.Trim());
			if (m3_DERE.HasValue)
				request.WithQueryParameter("DERE", m3_DERE.Value.ToString());

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
		/// Name DltFinancing
		/// Description Delete Financing
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_QFIN">Financing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltFinancing(
			string m3_PRNO = null, 
			string m3_QFIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltFinancing",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QFIN))
				request.WithQueryParameter("QFIN", m3_QFIN.Trim());

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
		/// Name GetFinancing
		/// Description Get Financing
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_QFIN">Financing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFinancingResponse></returns>
		/// <exception cref="M3Exception<GetFinancingResponse>"></exception>
		public async Task<M3Response<GetFinancingResponse>> GetFinancing(
			string m3_PRNO = null, 
			string m3_QFIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFinancing",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QFIN))
				request.WithQueryParameter("QFIN", m3_QFIN.Trim());

			// Execute the request
			var result = await Execute<GetFinancingResponse>(
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
		/// Name LstFinancing
		/// Description List Financing
		/// Version Release: 
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_QFIN">Financing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFinancingResponse></returns>
		/// <exception cref="M3Exception<LstFinancingResponse>"></exception>
		public async Task<M3Response<LstFinancingResponse>> LstFinancing(
			string m3_PRNO = null, 
			string m3_QFIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFinancing",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QFIN))
				request.WithQueryParameter("QFIN", m3_QFIN.Trim());

			// Execute the request
			var result = await Execute<LstFinancingResponse>(
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
