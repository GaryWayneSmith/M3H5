/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.AHS110MI;
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
	/// Name: AHS110MI
	/// Component Name: Ad-hoc Report
	/// Description: Api: Ad-hoc report
	/// Version Release: 15.0
	///</summary>
	public partial class AHS110MIResource : M3BaseResourceEndpoint
	{
		public AHS110MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "AHS110MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddReport
		/// Description Add report
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report (Required)</param>
		/// <param name="m3_REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3_LITX">Report text (Required)</param>
		/// <param name="m3_LCKR">Locked report</param>
		/// <param name="m3_PAVR">View</param>
		/// <param name="m3_UPVR">Personal view</param>
		/// <param name="m3_OBK1">Object control parameter</param>
		/// <param name="m3_OBK2">Object control parameter</param>
		/// <param name="m3_OBK3">Object control parameter</param>
		/// <param name="m3_OBK4">Object control parameter</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="m3_QTTP">Sorting order</param>
		/// <param name="m3_AGGR">Aggregation</param>
		/// <param name="m3_SUB1">Subtotal 1</param>
		/// <param name="m3_SUB2">Subtotal 2</param>
		/// <param name="m3_SUB3">Subtotal 3</param>
		/// <param name="m3_SLF1">Selection field 1</param>
		/// <param name="m3_SLF2">Selection field 2</param>
		/// <param name="m3_SLF3">Selection field 3</param>
		/// <param name="m3_FSLT">Selection value 1</param>
		/// <param name="m3_TSLT">Selection value 1</param>
		/// <param name="m3_FSL2">Selection value 2</param>
		/// <param name="m3_TSL2">Selection value 2</param>
		/// <param name="m3_FSL3">Selection value 3</param>
		/// <param name="m3_TSL3">Selection value 3</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_REEM">Ad-hoc report e-mail</param>
		/// <param name="m3_EMTP">E-mail type</param>
		/// <param name="m3_EMKY">E-mail key value</param>
		/// <param name="m3_SUBJ">Subject</param>
		/// <param name="m3_EMTX">E-mail text</param>
		/// <param name="m3_RLCT">Ad-hoc report location</param>
		/// <param name="m3_PETP">Period type</param>
		/// <param name="m3_XSAL">Job schedule allowed</param>
		/// <param name="m3_XCAT">Job schedule category</param>
		/// <param name="m3_DOLO">Document location</param>
		/// <param name="m3_SEEA">Sender e-mail address</param>
		/// <param name="m3_RSRR">Save report run</param>
		/// <param name="m3_RNRR">Number of days to save report run</param>
		/// <param name="m3_RSRL">Save report lines</param>
		/// <param name="m3_RNRL">Number of days to save report lines</param>
		/// <param name="m3_DAL1">Monday</param>
		/// <param name="m3_DAL2">Tuesday</param>
		/// <param name="m3_DAL3">Wednesday</param>
		/// <param name="m3_DAL4">Thursday</param>
		/// <param name="m3_DAL5">Friday</param>
		/// <param name="m3_DAL6">Saturday</param>
		/// <param name="m3_DAL7">Sunday</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_FRTM">From time</param>
		/// <param name="m3_TOTM">To time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddReport(
			string m3_REPO, 
			string m3_REPV, 
			string m3_LITX, 
			int? m3_LCKR = null, 
			string m3_PAVR = null, 
			string m3_UPVR = null, 
			string m3_OBK1 = null, 
			string m3_OBK2 = null, 
			string m3_OBK3 = null, 
			string m3_OBK4 = null, 
			int? m3_NFTR = null, 
			int? m3_QTTP = null, 
			int? m3_AGGR = null, 
			int? m3_SUB1 = null, 
			int? m3_SUB2 = null, 
			int? m3_SUB3 = null, 
			string m3_SLF1 = null, 
			string m3_SLF2 = null, 
			string m3_SLF3 = null, 
			string m3_FSLT = null, 
			string m3_TSLT = null, 
			string m3_FSL2 = null, 
			string m3_TSL2 = null, 
			string m3_FSL3 = null, 
			string m3_TSL3 = null, 
			decimal? m3_TXID = null, 
			int? m3_REEM = null, 
			string m3_EMTP = null, 
			string m3_EMKY = null, 
			string m3_SUBJ = null, 
			string m3_EMTX = null, 
			string m3_RLCT = null, 
			int? m3_PETP = null, 
			int? m3_XSAL = null, 
			string m3_XCAT = null, 
			string m3_DOLO = null, 
			string m3_SEEA = null, 
			int? m3_RSRR = null, 
			int? m3_RNRR = null, 
			int? m3_RSRL = null, 
			int? m3_RNRL = null, 
			int? m3_DAL1 = null, 
			int? m3_DAL2 = null, 
			int? m3_DAL3 = null, 
			int? m3_DAL4 = null, 
			int? m3_DAL5 = null, 
			int? m3_DAL6 = null, 
			int? m3_DAL7 = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
			int? m3_FRTM = null, 
			int? m3_TOTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REPO))
				throw new ArgumentNullException("m3_REPO");
			if (string.IsNullOrWhiteSpace(m3_REPV))
				throw new ArgumentNullException("m3_REPV");
			if (string.IsNullOrWhiteSpace(m3_LITX))
				throw new ArgumentNullException("m3_LITX");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3_REPO.Trim())
				.WithQueryParameter("REPV", m3_REPV.Trim())
				.WithQueryParameter("LITX", m3_LITX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LCKR.HasValue)
				request.WithQueryParameter("LCKR", m3_LCKR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAVR))
				request.WithQueryParameter("PAVR", m3_PAVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPVR))
				request.WithQueryParameter("UPVR", m3_UPVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK1))
				request.WithQueryParameter("OBK1", m3_OBK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK2))
				request.WithQueryParameter("OBK2", m3_OBK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK3))
				request.WithQueryParameter("OBK3", m3_OBK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK4))
				request.WithQueryParameter("OBK4", m3_OBK4.Trim());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());
			if (m3_QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3_QTTP.Value.ToString());
			if (m3_AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3_AGGR.Value.ToString());
			if (m3_SUB1.HasValue)
				request.WithQueryParameter("SUB1", m3_SUB1.Value.ToString());
			if (m3_SUB2.HasValue)
				request.WithQueryParameter("SUB2", m3_SUB2.Value.ToString());
			if (m3_SUB3.HasValue)
				request.WithQueryParameter("SUB3", m3_SUB3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLF1))
				request.WithQueryParameter("SLF1", m3_SLF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLF2))
				request.WithQueryParameter("SLF2", m3_SLF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLF3))
				request.WithQueryParameter("SLF3", m3_SLF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSLT))
				request.WithQueryParameter("FSLT", m3_FSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSLT))
				request.WithQueryParameter("TSLT", m3_TSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSL2))
				request.WithQueryParameter("FSL2", m3_FSL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSL2))
				request.WithQueryParameter("TSL2", m3_TSL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSL3))
				request.WithQueryParameter("FSL3", m3_FSL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSL3))
				request.WithQueryParameter("TSL3", m3_TSL3.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_REEM.HasValue)
				request.WithQueryParameter("REEM", m3_REEM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMTP))
				request.WithQueryParameter("EMTP", m3_EMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMKY))
				request.WithQueryParameter("EMKY", m3_EMKY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUBJ))
				request.WithQueryParameter("SUBJ", m3_SUBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMTX))
				request.WithQueryParameter("EMTX", m3_EMTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RLCT))
				request.WithQueryParameter("RLCT", m3_RLCT.Trim());
			if (m3_PETP.HasValue)
				request.WithQueryParameter("PETP", m3_PETP.Value.ToString());
			if (m3_XSAL.HasValue)
				request.WithQueryParameter("XSAL", m3_XSAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_XCAT))
				request.WithQueryParameter("XCAT", m3_XCAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOLO))
				request.WithQueryParameter("DOLO", m3_DOLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEEA))
				request.WithQueryParameter("SEEA", m3_SEEA.Trim());
			if (m3_RSRR.HasValue)
				request.WithQueryParameter("RSRR", m3_RSRR.Value.ToString());
			if (m3_RNRR.HasValue)
				request.WithQueryParameter("RNRR", m3_RNRR.Value.ToString());
			if (m3_RSRL.HasValue)
				request.WithQueryParameter("RSRL", m3_RSRL.Value.ToString());
			if (m3_RNRL.HasValue)
				request.WithQueryParameter("RNRL", m3_RNRL.Value.ToString());
			if (m3_DAL1.HasValue)
				request.WithQueryParameter("DAL1", m3_DAL1.Value.ToString());
			if (m3_DAL2.HasValue)
				request.WithQueryParameter("DAL2", m3_DAL2.Value.ToString());
			if (m3_DAL3.HasValue)
				request.WithQueryParameter("DAL3", m3_DAL3.Value.ToString());
			if (m3_DAL4.HasValue)
				request.WithQueryParameter("DAL4", m3_DAL4.Value.ToString());
			if (m3_DAL5.HasValue)
				request.WithQueryParameter("DAL5", m3_DAL5.Value.ToString());
			if (m3_DAL6.HasValue)
				request.WithQueryParameter("DAL6", m3_DAL6.Value.ToString());
			if (m3_DAL7.HasValue)
				request.WithQueryParameter("DAL7", m3_DAL7.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3_FRTM.Value.ToString());
			if (m3_TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3_TOTM.Value.ToString());

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
		/// Name DelReport
		/// Description Delete report
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report (Required)</param>
		/// <param name="m3_REPV">Ad-hoc report version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelReport(
			string m3_REPO, 
			string m3_REPV, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REPO))
				throw new ArgumentNullException("m3_REPO");
			if (string.IsNullOrWhiteSpace(m3_REPV))
				throw new ArgumentNullException("m3_REPV");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3_REPO.Trim())
				.WithQueryParameter("REPV", m3_REPV.Trim());

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
		/// Name GetReport
		/// Description Get report
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report (Required)</param>
		/// <param name="m3_REPV">Ad-hoc report version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetReportResponse></returns>
		/// <exception cref="M3Exception<GetReportResponse>"></exception>
		public async Task<M3Response<GetReportResponse>> GetReport(
			string m3_REPO, 
			string m3_REPV, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REPO))
				throw new ArgumentNullException("m3_REPO");
			if (string.IsNullOrWhiteSpace(m3_REPV))
				throw new ArgumentNullException("m3_REPV");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3_REPO.Trim())
				.WithQueryParameter("REPV", m3_REPV.Trim());

			// Execute the request
			var result = await Execute<GetReportResponse>(
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
		/// Name LstReport
		/// Description List report
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report</param>
		/// <param name="m3_REPV">Ad-hoc report version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReportResponse></returns>
		/// <exception cref="M3Exception<LstReportResponse>"></exception>
		public async Task<M3Response<LstReportResponse>> LstReport(
			string m3_REPO = null, 
			string m3_REPV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstReport",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_REPO))
				request.WithQueryParameter("REPO", m3_REPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REPV))
				request.WithQueryParameter("REPV", m3_REPV.Trim());

			// Execute the request
			var result = await Execute<LstReportResponse>(
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
		/// Name UpdAppMes
		/// Description Update Application message information
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report (Required)</param>
		/// <param name="m3_REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3_AHAM">Ad Hoc Application message</param>
		/// <param name="m3_REC2">Receiver</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_MSGT">Message</param>
		/// <param name="m3_FIET">File type</param>
		/// <param name="m3_BODE">BOD enabled</param>
		/// <param name="m3_BDMT">BOD message type</param>
		/// <param name="m3_OFNC">Overriding function</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAppMes(
			string m3_REPO, 
			string m3_REPV, 
			int? m3_AHAM = null, 
			string m3_REC2 = null, 
			string m3_TX30 = null, 
			string m3_MSGT = null, 
			int? m3_FIET = null, 
			int? m3_BODE = null, 
			int? m3_BDMT = null, 
			string m3_OFNC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAppMes",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REPO))
				throw new ArgumentNullException("m3_REPO");
			if (string.IsNullOrWhiteSpace(m3_REPV))
				throw new ArgumentNullException("m3_REPV");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3_REPO.Trim())
				.WithQueryParameter("REPV", m3_REPV.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_AHAM.HasValue)
				request.WithQueryParameter("AHAM", m3_AHAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REC2))
				request.WithQueryParameter("REC2", m3_REC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSGT))
				request.WithQueryParameter("MSGT", m3_MSGT.Trim());
			if (m3_FIET.HasValue)
				request.WithQueryParameter("FIET", m3_FIET.Value.ToString());
			if (m3_BODE.HasValue)
				request.WithQueryParameter("BODE", m3_BODE.Value.ToString());
			if (m3_BDMT.HasValue)
				request.WithQueryParameter("BDMT", m3_BDMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OFNC))
				request.WithQueryParameter("OFNC", m3_OFNC.Trim());

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
		/// Name UpdReport
		/// Description Update report
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_REPO">Ad-hoc report (Required)</param>
		/// <param name="m3_REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3_LITX">Report text</param>
		/// <param name="m3_LCKR">Locked report</param>
		/// <param name="m3_PAVR">View</param>
		/// <param name="m3_UPVR">Personal view</param>
		/// <param name="m3_OBK1">Object control parameter</param>
		/// <param name="m3_OBK2">Object control parameter</param>
		/// <param name="m3_OBK3">Object control parameter</param>
		/// <param name="m3_OBK4">Object control parameter</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="m3_QTTP">Sorting order</param>
		/// <param name="m3_AGGR">Aggregation</param>
		/// <param name="m3_SUB1">Subtotal 1</param>
		/// <param name="m3_SUB2">Subtotal 2</param>
		/// <param name="m3_SUB3">Subtotal 3</param>
		/// <param name="m3_SLF1">Selection field 1</param>
		/// <param name="m3_SLF2">Selection field 2</param>
		/// <param name="m3_SLF3">Selection field 3</param>
		/// <param name="m3_FSLT">Selection value 1</param>
		/// <param name="m3_TSLT">Selection value 1</param>
		/// <param name="m3_FSL2">Selection value 2</param>
		/// <param name="m3_TSL2">Selection value 2</param>
		/// <param name="m3_FSL3">Selection value 3</param>
		/// <param name="m3_TSL3">Selection value 3</param>
		/// <param name="m3_REEM">Ad-hoc report e-mail</param>
		/// <param name="m3_EMTP">E-mail type</param>
		/// <param name="m3_EMKY">E-mail key value</param>
		/// <param name="m3_SUBJ">Subject</param>
		/// <param name="m3_EMTX">E-mail text</param>
		/// <param name="m3_RLCT">Ad-hoc report location</param>
		/// <param name="m3_PETP">Period type</param>
		/// <param name="m3_XSAL">Job schedule allowed</param>
		/// <param name="m3_XCAT">Job schedule category</param>
		/// <param name="m3_DOLO">Document location</param>
		/// <param name="m3_SEEA">Sender e-mail address</param>
		/// <param name="m3_RSRR">Save report run</param>
		/// <param name="m3_RNRR">Number of days to save report run</param>
		/// <param name="m3_RSRL">Save report lines</param>
		/// <param name="m3_RNRL">Number of days to save report lines</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdReport(
			string m3_REPO, 
			string m3_REPV, 
			string m3_LITX = null, 
			int? m3_LCKR = null, 
			string m3_PAVR = null, 
			string m3_UPVR = null, 
			string m3_OBK1 = null, 
			string m3_OBK2 = null, 
			string m3_OBK3 = null, 
			string m3_OBK4 = null, 
			int? m3_NFTR = null, 
			int? m3_QTTP = null, 
			int? m3_AGGR = null, 
			int? m3_SUB1 = null, 
			int? m3_SUB2 = null, 
			int? m3_SUB3 = null, 
			string m3_SLF1 = null, 
			string m3_SLF2 = null, 
			string m3_SLF3 = null, 
			string m3_FSLT = null, 
			string m3_TSLT = null, 
			string m3_FSL2 = null, 
			string m3_TSL2 = null, 
			string m3_FSL3 = null, 
			string m3_TSL3 = null, 
			int? m3_REEM = null, 
			string m3_EMTP = null, 
			string m3_EMKY = null, 
			string m3_SUBJ = null, 
			string m3_EMTX = null, 
			string m3_RLCT = null, 
			int? m3_PETP = null, 
			int? m3_XSAL = null, 
			string m3_XCAT = null, 
			string m3_DOLO = null, 
			string m3_SEEA = null, 
			int? m3_RSRR = null, 
			int? m3_RNRR = null, 
			int? m3_RSRL = null, 
			int? m3_RNRL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_REPO))
				throw new ArgumentNullException("m3_REPO");
			if (string.IsNullOrWhiteSpace(m3_REPV))
				throw new ArgumentNullException("m3_REPV");

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3_REPO.Trim())
				.WithQueryParameter("REPV", m3_REPV.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LITX))
				request.WithQueryParameter("LITX", m3_LITX.Trim());
			if (m3_LCKR.HasValue)
				request.WithQueryParameter("LCKR", m3_LCKR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAVR))
				request.WithQueryParameter("PAVR", m3_PAVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPVR))
				request.WithQueryParameter("UPVR", m3_UPVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK1))
				request.WithQueryParameter("OBK1", m3_OBK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK2))
				request.WithQueryParameter("OBK2", m3_OBK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK3))
				request.WithQueryParameter("OBK3", m3_OBK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK4))
				request.WithQueryParameter("OBK4", m3_OBK4.Trim());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());
			if (m3_QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3_QTTP.Value.ToString());
			if (m3_AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3_AGGR.Value.ToString());
			if (m3_SUB1.HasValue)
				request.WithQueryParameter("SUB1", m3_SUB1.Value.ToString());
			if (m3_SUB2.HasValue)
				request.WithQueryParameter("SUB2", m3_SUB2.Value.ToString());
			if (m3_SUB3.HasValue)
				request.WithQueryParameter("SUB3", m3_SUB3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLF1))
				request.WithQueryParameter("SLF1", m3_SLF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLF2))
				request.WithQueryParameter("SLF2", m3_SLF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLF3))
				request.WithQueryParameter("SLF3", m3_SLF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSLT))
				request.WithQueryParameter("FSLT", m3_FSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSLT))
				request.WithQueryParameter("TSLT", m3_TSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSL2))
				request.WithQueryParameter("FSL2", m3_FSL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSL2))
				request.WithQueryParameter("TSL2", m3_TSL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSL3))
				request.WithQueryParameter("FSL3", m3_FSL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSL3))
				request.WithQueryParameter("TSL3", m3_TSL3.Trim());
			if (m3_REEM.HasValue)
				request.WithQueryParameter("REEM", m3_REEM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMTP))
				request.WithQueryParameter("EMTP", m3_EMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMKY))
				request.WithQueryParameter("EMKY", m3_EMKY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUBJ))
				request.WithQueryParameter("SUBJ", m3_SUBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMTX))
				request.WithQueryParameter("EMTX", m3_EMTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RLCT))
				request.WithQueryParameter("RLCT", m3_RLCT.Trim());
			if (m3_PETP.HasValue)
				request.WithQueryParameter("PETP", m3_PETP.Value.ToString());
			if (m3_XSAL.HasValue)
				request.WithQueryParameter("XSAL", m3_XSAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_XCAT))
				request.WithQueryParameter("XCAT", m3_XCAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOLO))
				request.WithQueryParameter("DOLO", m3_DOLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEEA))
				request.WithQueryParameter("SEEA", m3_SEEA.Trim());
			if (m3_RSRR.HasValue)
				request.WithQueryParameter("RSRR", m3_RSRR.Value.ToString());
			if (m3_RNRR.HasValue)
				request.WithQueryParameter("RNRR", m3_RNRR.Value.ToString());
			if (m3_RSRL.HasValue)
				request.WithQueryParameter("RSRL", m3_RSRL.Value.ToString());
			if (m3_RNRL.HasValue)
				request.WithQueryParameter("RNRL", m3_RNRL.Value.ToString());

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
