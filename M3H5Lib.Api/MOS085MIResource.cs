/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS085MI;
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
	/// Name: MOS085MI
	/// Component Name: MaintenanceInspections
	/// Description: Maintenance inspections interface
	/// Version Release: 5ea1
	///</summary>
	public partial class MOS085MIResource : M3BaseResourceEndpoint
	{
		public MOS085MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS085MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddInspText
		/// Description Add Inspections Text
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_MWNO">MaintenanceOrderNumber (Required)</param>
		/// <param name="m3_OPNO">OperationNumber (Required)</param>
		/// <param name="m3_ACTS">OperationElementNumber (Required)</param>
		/// <param name="m3_SPOS">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">ProductNumber</param>
		/// <param name="m3_INSI">Inspection identity</param>
		/// <param name="m3_LNNR">Serial number</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LINO">Line number</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddInspTextResponse></returns>
		/// <exception cref="M3Exception<AddInspTextResponse>"></exception>
		public async Task<M3Response<AddInspTextResponse>> AddInspText(
			string m3_FACI, 
			string m3_MWNO, 
			int m3_OPNO, 
			int m3_ACTS, 
			int m3_SPOS, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_INSI = null, 
			int? m3_LNNR = null, 
			string m3_TXVR = null, 
			int? m3_LINO = null, 
			string m3_TX60 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddInspText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("SPOS", m3_SPOS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSI))
				request.WithQueryParameter("INSI", m3_INSI.Trim());
			if (m3_LNNR.HasValue)
				request.WithQueryParameter("LNNR", m3_LNNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (m3_LINO.HasValue)
				request.WithQueryParameter("LINO", m3_LINO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());

			// Execute the request
			var result = await Execute<AddInspTextResponse>(
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
		/// Name ClsInsp
		/// Description Close Inspections
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_MWNO">MaintenanceOrderNumber (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OPNO">Operation</param>
		/// <param name="m3_PITI">RunTime</param>
		/// <param name="m3_TRDT">TransactionDate</param>
		/// <param name="m3_TRTM">TransactionTime</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_TXID">Text Identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ClsInspResponse></returns>
		/// <exception cref="M3Exception<ClsInspResponse>"></exception>
		public async Task<M3Response<ClsInspResponse>> ClsInsp(
			string m3_FACI, 
			string m3_MWNO, 
			int? m3_CONO = null, 
			int? m3_OPNO = null, 
			string m3_PITI = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TRTM = null, 
			string m3_EMNO = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClsInsp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("MWNO", m3_MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PITI))
				request.WithQueryParameter("PITI", m3_PITI.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

			// Execute the request
			var result = await Execute<ClsInspResponse>(
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
		/// Name LstInsp
		/// Description List inspections
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MWNO">Manufacturing order number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInspResponse></returns>
		/// <exception cref="M3Exception<LstInspResponse>"></exception>
		public async Task<M3Response<LstInspResponse>> LstInsp(
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_MWNO = null, 
			int? m3_OPNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInsp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());

			// Execute the request
			var result = await Execute<LstInspResponse>(
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
		/// Name RptInsp
		/// Description Report Inspections
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_MWNO">MaintenanceOrderNumber (Required)</param>
		/// <param name="m3_OPNO">OperationNumber (Required)</param>
		/// <param name="m3_ACTS">OperationElementNumber (Required)</param>
		/// <param name="m3_SPOS">LineNumber (Required)</param>
		/// <param name="m3_RVAL">ReportedValue (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">ProductNumber</param>
		/// <param name="m3_INSI">InspectionID</param>
		/// <param name="m3_LNNR">LineNumber</param>
		/// <param name="m3_XERR">WarningIndicator</param>
		/// <param name="m3_INRS">InspectionResult</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_RPDT">ReportingDate</param>
		/// <param name="m3_TRTM">ReportingTime HHMM</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptInsp(
			string m3_FACI, 
			string m3_MWNO, 
			int m3_OPNO, 
			int m3_ACTS, 
			int m3_SPOS, 
			string m3_RVAL, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_INSI = null, 
			int? m3_LNNR = null, 
			string m3_XERR = null, 
			string m3_INRS = null, 
			string m3_REMK = null, 
			DateTime? m3_RPDT = null, 
			int? m3_TRTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RptInsp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_MWNO))
				throw new ArgumentNullException("m3_MWNO");
			if (string.IsNullOrWhiteSpace(m3_RVAL))
				throw new ArgumentNullException("m3_RVAL");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("MWNO", m3_MWNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("SPOS", m3_SPOS.ToString())
				.WithQueryParameter("RVAL", m3_RVAL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSI))
				request.WithQueryParameter("INSI", m3_INSI.Trim());
			if (m3_LNNR.HasValue)
				request.WithQueryParameter("LNNR", m3_LNNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_XERR))
				request.WithQueryParameter("XERR", m3_XERR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INRS))
				request.WithQueryParameter("INRS", m3_INRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());

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
