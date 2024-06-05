/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PMS085MI;
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
	/// Name: PMS085MI
	/// Component Name: Inspection results
	/// Description: Api: Inspection results
	/// Version Release: 14.x
	///</summary>
	public partial class PMS085MIResource : M3BaseResourceEndpoint
	{
		public PMS085MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS085MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DelInspectionRs
		/// Description This transaction deletes reported inspection transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Operation element number (Required)</param>
		/// <param name="m3_INSI">Inspection identity (Required)</param>
		/// <param name="m3_SPOS">Line number (Required)</param>
		/// <param name="m3_LNNR">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelInspectionRs(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int m3_OPNO, 
			int m3_ACTS, 
			string m3_INSI, 
			int m3_SPOS, 
			int m3_LNNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelInspectionRs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");
			if (string.IsNullOrWhiteSpace(m3_INSI))
				throw new ArgumentNullException("m3_INSI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("INSI", m3_INSI.Trim())
				.WithQueryParameter("SPOS", m3_SPOS.ToString())
				.WithQueryParameter("LNNR", m3_LNNR.ToString());

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
		/// Name GetInspectionRs
		/// Description This transaction displays reported inspection transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Operation element number (Required)</param>
		/// <param name="m3_INSI">Inspection identity (Required)</param>
		/// <param name="m3_SPOS">Line number (Required)</param>
		/// <param name="m3_LNNR">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInspectionRsResponse></returns>
		/// <exception cref="M3Exception<GetInspectionRsResponse>"></exception>
		public async Task<M3Response<GetInspectionRsResponse>> GetInspectionRs(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int m3_OPNO, 
			int m3_ACTS, 
			string m3_INSI, 
			int m3_SPOS, 
			int m3_LNNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInspectionRs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");
			if (string.IsNullOrWhiteSpace(m3_INSI))
				throw new ArgumentNullException("m3_INSI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("INSI", m3_INSI.Trim())
				.WithQueryParameter("SPOS", m3_SPOS.ToString())
				.WithQueryParameter("LNNR", m3_LNNR.ToString());

			// Execute the request
			var result = await Execute<GetInspectionRsResponse>(
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
		/// Name GetReportInspRs
		/// Description This transaction displays an inspection to be reported
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Operation element number (Required)</param>
		/// <param name="m3_PLNO">Production lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetReportInspRsResponse></returns>
		/// <exception cref="M3Exception<GetReportInspRsResponse>"></exception>
		public async Task<M3Response<GetReportInspRsResponse>> GetReportInspRs(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int m3_OPNO, 
			int m3_ACTS, 
			long? m3_PLNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetReportInspRs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PLNO.HasValue)
				request.WithQueryParameter("PLNO", m3_PLNO.Value.ToString());

			// Execute the request
			var result = await Execute<GetReportInspRsResponse>(
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
		/// Name LstInspectionRs
		/// Description This transaction lists the reported inspection transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Operation element number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInspectionRsResponse></returns>
		/// <exception cref="M3Exception<LstInspectionRsResponse>"></exception>
		public async Task<M3Response<LstInspectionRsResponse>> LstInspectionRs(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int m3_OPNO, 
			int? m3_ACTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInspectionRs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3_ACTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstInspectionRsResponse>(
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
		/// Name LstReportInspRs
		/// Description This transaction lists the inspections to be reported
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Operation element number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReportInspRsResponse></returns>
		/// <exception cref="M3Exception<LstReportInspRsResponse>"></exception>
		public async Task<M3Response<LstReportInspRsResponse>> LstReportInspRs(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int m3_OPNO, 
			int? m3_ACTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstReportInspRs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3_ACTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstReportInspRsResponse>(
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
		/// Name ReportInsp
		/// Description This transaction adds new inspection for each reporting
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Element number (Required)</param>
		/// <param name="m3_SPOS">Line number (Required)</param>
		/// <param name="m3_RVAL">Reported value</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_TRTM">Reporting time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReportInsp(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int m3_OPNO, 
			int m3_ACTS, 
			int m3_SPOS, 
			string m3_RVAL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReportInsp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("SPOS", m3_SPOS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RVAL))
				request.WithQueryParameter("RVAL", m3_RVAL.Trim());
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

		/// <summary>
		/// Name UpdInspectionRs
		/// Description This transaction updates reported inspection transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MFNO">Manufacturing order number (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Operation element number (Required)</param>
		/// <param name="m3_INSI">Inspection identity (Required)</param>
		/// <param name="m3_SPOS">Line number (Required)</param>
		/// <param name="m3_LNNR">Serial number (Required)</param>
		/// <param name="m3_RVAL">Reported value</param>
		/// <param name="m3_RPDT">Reporting date</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdInspectionRs(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_MFNO, 
			int m3_OPNO, 
			int m3_ACTS, 
			string m3_INSI, 
			int m3_SPOS, 
			int m3_LNNR, 
			string m3_RVAL = null, 
			DateTime? m3_RPDT = null, 
			int? m3_TRTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdInspectionRs",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_MFNO))
				throw new ArgumentNullException("m3_MFNO");
			if (string.IsNullOrWhiteSpace(m3_INSI))
				throw new ArgumentNullException("m3_INSI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MFNO", m3_MFNO.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("INSI", m3_INSI.Trim())
				.WithQueryParameter("SPOS", m3_SPOS.ToString())
				.WithQueryParameter("LNNR", m3_LNNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RVAL))
				request.WithQueryParameter("RVAL", m3_RVAL.Trim());
			if (m3_RPDT.HasValue)
				request.WithQueryParameter("RPDT", m3_RPDT.Value.ToM3String());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
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
