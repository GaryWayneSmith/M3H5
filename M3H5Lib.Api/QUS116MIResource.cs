/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3QFIN">Financing (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3LVDT">Valid to (Required)</param>
		/// <param name="m3FUND">Funder number (Required)</param>
		/// <param name="m3AOTP">Agreement order type (Required)</param>
		/// <param name="m3KTNO">Kit number (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3LKNR">ID number</param>
		/// <param name="m3NOPR">Number of periods</param>
		/// <param name="m3REPE">Residual %</param>
		/// <param name="m3INTT">Interest type</param>
		/// <param name="m3INPE">Interest rate</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3INAP">Industry Application</param>
		/// <param name="m3OENV">Operational Environment</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3CUCL">Customer group</param>
		/// <param name="m3DERE">Default record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFinancing(
			string m3QFIN, 
			string m3TX40, 
			DateTime m3FVDT, 
			DateTime m3LVDT, 
			string m3FUND, 
			string m3AOTP, 
			string m3KTNO, 
			string m3PRNO = null, 
			string m3TX15 = null, 
			string m3STAT = null, 
			string m3RESP = null, 
			string m3LKNR = null, 
			int? m3NOPR = null, 
			int? m3REPE = null, 
			string m3INTT = null, 
			decimal? m3INPE = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3INAP = null, 
			string m3OENV = null, 
			string m3CUNO = null, 
			string m3CUCL = null, 
			int? m3DERE = null, 
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
			if (string.IsNullOrWhiteSpace(m3QFIN))
				throw new ArgumentNullException(nameof(m3QFIN));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3FUND))
				throw new ArgumentNullException(nameof(m3FUND));
			if (string.IsNullOrWhiteSpace(m3AOTP))
				throw new ArgumentNullException(nameof(m3AOTP));
			if (string.IsNullOrWhiteSpace(m3KTNO))
				throw new ArgumentNullException(nameof(m3KTNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("QFIN", m3QFIN.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("LVDT", m3LVDT.ToM3String())
				.WithQueryParameter("FUND", m3FUND.Trim())
				.WithQueryParameter("AOTP", m3AOTP.Trim())
				.WithQueryParameter("KTNO", m3KTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3LKNR))
				request.WithQueryParameter("LKNR", m3LKNR.Trim());
			if (m3NOPR.HasValue)
				request.WithQueryParameter("NOPR", m3NOPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPE.HasValue)
				request.WithQueryParameter("REPE", m3REPE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INTT))
				request.WithQueryParameter("INTT", m3INTT.Trim());
			if (m3INPE.HasValue)
				request.WithQueryParameter("INPE", m3INPE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3INAP))
				request.WithQueryParameter("INAP", m3INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OENV))
				request.WithQueryParameter("OENV", m3OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCL))
				request.WithQueryParameter("CUCL", m3CUCL.Trim());
			if (m3DERE.HasValue)
				request.WithQueryParameter("DERE", m3DERE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgFinancing
		/// Description Change Financing
		/// Version Release: 
		/// </summary>
		/// <param name="m3QFIN">Financing (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3LKNR">ID number</param>
		/// <param name="m3FUND">Funder number</param>
		/// <param name="m3AOTP">Agreement order type</param>
		/// <param name="m3KTNO">Kit number</param>
		/// <param name="m3NOPR">Number of periods</param>
		/// <param name="m3REPE">Residual %</param>
		/// <param name="m3INTT">Interest type</param>
		/// <param name="m3INPE">Interest rate</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3INAP">Industry Application</param>
		/// <param name="m3OENV">Operational Environment</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3CUCL">Customer group</param>
		/// <param name="m3DERE">Default record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgFinancing(
			string m3QFIN, 
			string m3PRNO = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3STAT = null, 
			string m3RESP = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			string m3LKNR = null, 
			string m3FUND = null, 
			string m3AOTP = null, 
			string m3KTNO = null, 
			int? m3NOPR = null, 
			int? m3REPE = null, 
			string m3INTT = null, 
			decimal? m3INPE = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3INAP = null, 
			string m3OENV = null, 
			string m3CUNO = null, 
			string m3CUCL = null, 
			int? m3DERE = null, 
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
			if (string.IsNullOrWhiteSpace(m3QFIN))
				throw new ArgumentNullException(nameof(m3QFIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("QFIN", m3QFIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3LKNR))
				request.WithQueryParameter("LKNR", m3LKNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUND))
				request.WithQueryParameter("FUND", m3FUND.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOTP))
				request.WithQueryParameter("AOTP", m3AOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3KTNO))
				request.WithQueryParameter("KTNO", m3KTNO.Trim());
			if (m3NOPR.HasValue)
				request.WithQueryParameter("NOPR", m3NOPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPE.HasValue)
				request.WithQueryParameter("REPE", m3REPE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INTT))
				request.WithQueryParameter("INTT", m3INTT.Trim());
			if (m3INPE.HasValue)
				request.WithQueryParameter("INPE", m3INPE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3INAP))
				request.WithQueryParameter("INAP", m3INAP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OENV))
				request.WithQueryParameter("OENV", m3OENV.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCL))
				request.WithQueryParameter("CUCL", m3CUCL.Trim());
			if (m3DERE.HasValue)
				request.WithQueryParameter("DERE", m3DERE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltFinancing
		/// Description Delete Financing
		/// Version Release: 
		/// </summary>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3QFIN">Financing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltFinancing(
			string m3PRNO = null, 
			string m3QFIN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QFIN))
				request.WithQueryParameter("QFIN", m3QFIN.Trim());

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
		/// Name GetFinancing
		/// Description Get Financing
		/// Version Release: 
		/// </summary>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3QFIN">Financing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFinancingResponse></returns>
		/// <exception cref="M3Exception<GetFinancingResponse>"></exception>
		public async Task<M3Response<GetFinancingResponse>> GetFinancing(
			string m3PRNO = null, 
			string m3QFIN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QFIN))
				request.WithQueryParameter("QFIN", m3QFIN.Trim());

			// Execute the request
			var result = await Execute<GetFinancingResponse>(
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
		/// Name LstFinancing
		/// Description List Financing
		/// Version Release: 
		/// </summary>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3QFIN">Financing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFinancingResponse></returns>
		/// <exception cref="M3Exception<LstFinancingResponse>"></exception>
		public async Task<M3Response<LstFinancingResponse>> LstFinancing(
			string m3PRNO = null, 
			string m3QFIN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QFIN))
				request.WithQueryParameter("QFIN", m3QFIN.Trim());

			// Execute the request
			var result = await Execute<LstFinancingResponse>(
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
