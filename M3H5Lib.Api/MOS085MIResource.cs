/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3MWNO">MaintenanceOrderNumber (Required)</param>
		/// <param name="m3OPNO">OperationNumber (Required)</param>
		/// <param name="m3ACTS">OperationElementNumber (Required)</param>
		/// <param name="m3SPOS">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">ProductNumber</param>
		/// <param name="m3INSI">Inspection identity</param>
		/// <param name="m3LNNR">Serial number</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LINO">Line number</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddInspTextResponse></returns>
		/// <exception cref="M3Exception<AddInspTextResponse>"></exception>
		public async Task<M3Response<AddInspTextResponse>> AddInspText(
			string m3FACI, 
			string m3MWNO, 
			int m3OPNO, 
			int m3ACTS, 
			int m3SPOS, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3INSI = null, 
			int? m3LNNR = null, 
			string m3TXVR = null, 
			int? m3LINO = null, 
			string m3TX60 = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SPOS", m3SPOS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSI))
				request.WithQueryParameter("INSI", m3INSI.Trim());
			if (m3LNNR.HasValue)
				request.WithQueryParameter("LNNR", m3LNNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (m3LINO.HasValue)
				request.WithQueryParameter("LINO", m3LINO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());

			// Execute the request
			var result = await Execute<AddInspTextResponse>(
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
		/// Name ClsInsp
		/// Description Close Inspections
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3MWNO">MaintenanceOrderNumber (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OPNO">Operation</param>
		/// <param name="m3PITI">RunTime</param>
		/// <param name="m3TRDT">TransactionDate</param>
		/// <param name="m3TRTM">TransactionTime</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3TXID">Text Identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ClsInspResponse></returns>
		/// <exception cref="M3Exception<ClsInspResponse>"></exception>
		public async Task<M3Response<ClsInspResponse>> ClsInsp(
			string m3FACI, 
			string m3MWNO, 
			int? m3CONO = null, 
			int? m3OPNO = null, 
			string m3PITI = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			string m3EMNO = null, 
			decimal? m3TXID = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("MWNO", m3MWNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PITI))
				request.WithQueryParameter("PITI", m3PITI.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ClsInspResponse>(
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
		/// Name LstInsp
		/// Description List inspections
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MWNO">Manufacturing order number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInspResponse></returns>
		/// <exception cref="M3Exception<LstInspResponse>"></exception>
		public async Task<M3Response<LstInspResponse>> LstInsp(
			string m3FACI, 
			int? m3CONO = null, 
			string m3MWNO = null, 
			int? m3OPNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstInspResponse>(
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
		/// Name RptInsp
		/// Description Report Inspections
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3MWNO">MaintenanceOrderNumber (Required)</param>
		/// <param name="m3OPNO">OperationNumber (Required)</param>
		/// <param name="m3ACTS">OperationElementNumber (Required)</param>
		/// <param name="m3SPOS">LineNumber (Required)</param>
		/// <param name="m3RVAL">ReportedValue (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">ProductNumber</param>
		/// <param name="m3INSI">InspectionID</param>
		/// <param name="m3LNNR">LineNumber</param>
		/// <param name="m3XERR">WarningIndicator</param>
		/// <param name="m3INRS">InspectionResult</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="m3RPDT">ReportingDate</param>
		/// <param name="m3TRTM">ReportingTime HHMM</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RptInsp(
			string m3FACI, 
			string m3MWNO, 
			int m3OPNO, 
			int m3ACTS, 
			int m3SPOS, 
			string m3RVAL, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3INSI = null, 
			int? m3LNNR = null, 
			string m3XERR = null, 
			string m3INRS = null, 
			string m3REMK = null, 
			DateTime? m3RPDT = null, 
			int? m3TRTM = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));
			if (string.IsNullOrWhiteSpace(m3RVAL))
				throw new ArgumentNullException(nameof(m3RVAL));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SPOS", m3SPOS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RVAL", m3RVAL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSI))
				request.WithQueryParameter("INSI", m3INSI.Trim());
			if (m3LNNR.HasValue)
				request.WithQueryParameter("LNNR", m3LNNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3XERR))
				request.WithQueryParameter("XERR", m3XERR.Trim());
			if (!string.IsNullOrWhiteSpace(m3INRS))
				request.WithQueryParameter("INRS", m3INRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());
			if (m3RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3RPDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));

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
