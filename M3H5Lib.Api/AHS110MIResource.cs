/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddReport
		/// Description Add report
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report (Required)</param>
		/// <param name="m3REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3LITX">Report text (Required)</param>
		/// <param name="m3LCKR">Locked report</param>
		/// <param name="m3PAVR">View</param>
		/// <param name="m3UPVR">Personal view</param>
		/// <param name="m3OBK1">Object control parameter</param>
		/// <param name="m3OBK2">Object control parameter</param>
		/// <param name="m3OBK3">Object control parameter</param>
		/// <param name="m3OBK4">Object control parameter</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="m3QTTP">Sorting order</param>
		/// <param name="m3AGGR">Aggregation</param>
		/// <param name="m3SUB1">Subtotal 1</param>
		/// <param name="m3SUB2">Subtotal 2</param>
		/// <param name="m3SUB3">Subtotal 3</param>
		/// <param name="m3SLF1">Selection field 1</param>
		/// <param name="m3SLF2">Selection field 2</param>
		/// <param name="m3SLF3">Selection field 3</param>
		/// <param name="m3FSLT">Selection value 1</param>
		/// <param name="m3TSLT">Selection value 1</param>
		/// <param name="m3FSL2">Selection value 2</param>
		/// <param name="m3TSL2">Selection value 2</param>
		/// <param name="m3FSL3">Selection value 3</param>
		/// <param name="m3TSL3">Selection value 3</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3REEM">Ad-hoc report e-mail</param>
		/// <param name="m3EMTP">E-mail type</param>
		/// <param name="m3EMKY">E-mail key value</param>
		/// <param name="m3SUBJ">Subject</param>
		/// <param name="m3EMTX">E-mail text</param>
		/// <param name="m3RLCT">Ad-hoc report location</param>
		/// <param name="m3PETP">Period type</param>
		/// <param name="m3XSAL">Job schedule allowed</param>
		/// <param name="m3XCAT">Job schedule category</param>
		/// <param name="m3DOLO">Document location</param>
		/// <param name="m3SEEA">Sender e-mail address</param>
		/// <param name="m3RSRR">Save report run</param>
		/// <param name="m3RNRR">Number of days to save report run</param>
		/// <param name="m3RSRL">Save report lines</param>
		/// <param name="m3RNRL">Number of days to save report lines</param>
		/// <param name="m3DAL1">Monday</param>
		/// <param name="m3DAL2">Tuesday</param>
		/// <param name="m3DAL3">Wednesday</param>
		/// <param name="m3DAL4">Thursday</param>
		/// <param name="m3DAL5">Friday</param>
		/// <param name="m3DAL6">Saturday</param>
		/// <param name="m3DAL7">Sunday</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3FRTM">From time</param>
		/// <param name="m3TOTM">To time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddReport(
			string m3REPO, 
			string m3REPV, 
			string m3LITX, 
			int? m3LCKR = null, 
			string m3PAVR = null, 
			string m3UPVR = null, 
			string m3OBK1 = null, 
			string m3OBK2 = null, 
			string m3OBK3 = null, 
			string m3OBK4 = null, 
			int? m3NFTR = null, 
			int? m3QTTP = null, 
			int? m3AGGR = null, 
			int? m3SUB1 = null, 
			int? m3SUB2 = null, 
			int? m3SUB3 = null, 
			string m3SLF1 = null, 
			string m3SLF2 = null, 
			string m3SLF3 = null, 
			string m3FSLT = null, 
			string m3TSLT = null, 
			string m3FSL2 = null, 
			string m3TSL2 = null, 
			string m3FSL3 = null, 
			string m3TSL3 = null, 
			decimal? m3TXID = null, 
			int? m3REEM = null, 
			string m3EMTP = null, 
			string m3EMKY = null, 
			string m3SUBJ = null, 
			string m3EMTX = null, 
			string m3RLCT = null, 
			int? m3PETP = null, 
			int? m3XSAL = null, 
			string m3XCAT = null, 
			string m3DOLO = null, 
			string m3SEEA = null, 
			int? m3RSRR = null, 
			int? m3RNRR = null, 
			int? m3RSRL = null, 
			int? m3RNRL = null, 
			int? m3DAL1 = null, 
			int? m3DAL2 = null, 
			int? m3DAL3 = null, 
			int? m3DAL4 = null, 
			int? m3DAL5 = null, 
			int? m3DAL6 = null, 
			int? m3DAL7 = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			int? m3FRTM = null, 
			int? m3TOTM = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REPO))
				throw new ArgumentNullException(nameof(m3REPO));
			if (string.IsNullOrWhiteSpace(m3REPV))
				throw new ArgumentNullException(nameof(m3REPV));
			if (string.IsNullOrWhiteSpace(m3LITX))
				throw new ArgumentNullException(nameof(m3LITX));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3REPO.Trim())
				.WithQueryParameter("REPV", m3REPV.Trim())
				.WithQueryParameter("LITX", m3LITX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LCKR.HasValue)
				request.WithQueryParameter("LCKR", m3LCKR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAVR))
				request.WithQueryParameter("PAVR", m3PAVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPVR))
				request.WithQueryParameter("UPVR", m3UPVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK1))
				request.WithQueryParameter("OBK1", m3OBK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK2))
				request.WithQueryParameter("OBK2", m3OBK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK3))
				request.WithQueryParameter("OBK3", m3OBK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK4))
				request.WithQueryParameter("OBK4", m3OBK4.Trim());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3QTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3AGGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB1.HasValue)
				request.WithQueryParameter("SUB1", m3SUB1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB2.HasValue)
				request.WithQueryParameter("SUB2", m3SUB2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB3.HasValue)
				request.WithQueryParameter("SUB3", m3SUB3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLF1))
				request.WithQueryParameter("SLF1", m3SLF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLF2))
				request.WithQueryParameter("SLF2", m3SLF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLF3))
				request.WithQueryParameter("SLF3", m3SLF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSLT))
				request.WithQueryParameter("FSLT", m3FSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSLT))
				request.WithQueryParameter("TSLT", m3TSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSL2))
				request.WithQueryParameter("FSL2", m3FSL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSL2))
				request.WithQueryParameter("TSL2", m3TSL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSL3))
				request.WithQueryParameter("FSL3", m3FSL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSL3))
				request.WithQueryParameter("TSL3", m3TSL3.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REEM.HasValue)
				request.WithQueryParameter("REEM", m3REEM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMTP))
				request.WithQueryParameter("EMTP", m3EMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMKY))
				request.WithQueryParameter("EMKY", m3EMKY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUBJ))
				request.WithQueryParameter("SUBJ", m3SUBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMTX))
				request.WithQueryParameter("EMTX", m3EMTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3RLCT))
				request.WithQueryParameter("RLCT", m3RLCT.Trim());
			if (m3PETP.HasValue)
				request.WithQueryParameter("PETP", m3PETP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3XSAL.HasValue)
				request.WithQueryParameter("XSAL", m3XSAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3XCAT))
				request.WithQueryParameter("XCAT", m3XCAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOLO))
				request.WithQueryParameter("DOLO", m3DOLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEEA))
				request.WithQueryParameter("SEEA", m3SEEA.Trim());
			if (m3RSRR.HasValue)
				request.WithQueryParameter("RSRR", m3RSRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRR.HasValue)
				request.WithQueryParameter("RNRR", m3RNRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSRL.HasValue)
				request.WithQueryParameter("RSRL", m3RSRL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRL.HasValue)
				request.WithQueryParameter("RNRL", m3RNRL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAL1.HasValue)
				request.WithQueryParameter("DAL1", m3DAL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAL2.HasValue)
				request.WithQueryParameter("DAL2", m3DAL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAL3.HasValue)
				request.WithQueryParameter("DAL3", m3DAL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAL4.HasValue)
				request.WithQueryParameter("DAL4", m3DAL4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAL5.HasValue)
				request.WithQueryParameter("DAL5", m3DAL5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAL6.HasValue)
				request.WithQueryParameter("DAL6", m3DAL6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAL7.HasValue)
				request.WithQueryParameter("DAL7", m3DAL7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3FRTM.HasValue)
				request.WithQueryParameter("FRTM", m3FRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOTM.HasValue)
				request.WithQueryParameter("TOTM", m3TOTM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelReport
		/// Description Delete report
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report (Required)</param>
		/// <param name="m3REPV">Ad-hoc report version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelReport(
			string m3REPO, 
			string m3REPV, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REPO))
				throw new ArgumentNullException(nameof(m3REPO));
			if (string.IsNullOrWhiteSpace(m3REPV))
				throw new ArgumentNullException(nameof(m3REPV));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3REPO.Trim())
				.WithQueryParameter("REPV", m3REPV.Trim());

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
		/// Name GetReport
		/// Description Get report
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report (Required)</param>
		/// <param name="m3REPV">Ad-hoc report version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetReportResponse></returns>
		/// <exception cref="M3Exception<GetReportResponse>"></exception>
		public async Task<M3Response<GetReportResponse>> GetReport(
			string m3REPO, 
			string m3REPV, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REPO))
				throw new ArgumentNullException(nameof(m3REPO));
			if (string.IsNullOrWhiteSpace(m3REPV))
				throw new ArgumentNullException(nameof(m3REPV));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3REPO.Trim())
				.WithQueryParameter("REPV", m3REPV.Trim());

			// Execute the request
			var result = await Execute<GetReportResponse>(
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
		/// Name LstReport
		/// Description List report
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report</param>
		/// <param name="m3REPV">Ad-hoc report version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReportResponse></returns>
		/// <exception cref="M3Exception<LstReportResponse>"></exception>
		public async Task<M3Response<LstReportResponse>> LstReport(
			string m3REPO = null, 
			string m3REPV = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstReport",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3REPO))
				request.WithQueryParameter("REPO", m3REPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3REPV))
				request.WithQueryParameter("REPV", m3REPV.Trim());

			// Execute the request
			var result = await Execute<LstReportResponse>(
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
		/// Name UpdAppMes
		/// Description Update Application message information
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report (Required)</param>
		/// <param name="m3REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3AHAM">Ad Hoc Application message</param>
		/// <param name="m3REC2">Receiver</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3MSGT">Message</param>
		/// <param name="m3FIET">File type</param>
		/// <param name="m3BODE">BOD enabled</param>
		/// <param name="m3BDMT">BOD message type</param>
		/// <param name="m3OFNC">Overriding function</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAppMes(
			string m3REPO, 
			string m3REPV, 
			int? m3AHAM = null, 
			string m3REC2 = null, 
			string m3TX30 = null, 
			string m3MSGT = null, 
			int? m3FIET = null, 
			int? m3BODE = null, 
			int? m3BDMT = null, 
			string m3OFNC = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAppMes",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REPO))
				throw new ArgumentNullException(nameof(m3REPO));
			if (string.IsNullOrWhiteSpace(m3REPV))
				throw new ArgumentNullException(nameof(m3REPV));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3REPO.Trim())
				.WithQueryParameter("REPV", m3REPV.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3AHAM.HasValue)
				request.WithQueryParameter("AHAM", m3AHAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REC2))
				request.WithQueryParameter("REC2", m3REC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSGT))
				request.WithQueryParameter("MSGT", m3MSGT.Trim());
			if (m3FIET.HasValue)
				request.WithQueryParameter("FIET", m3FIET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BODE.HasValue)
				request.WithQueryParameter("BODE", m3BODE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BDMT.HasValue)
				request.WithQueryParameter("BDMT", m3BDMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OFNC))
				request.WithQueryParameter("OFNC", m3OFNC.Trim());

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
		/// Name UpdReport
		/// Description Update report
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3REPO">Ad-hoc report (Required)</param>
		/// <param name="m3REPV">Ad-hoc report version (Required)</param>
		/// <param name="m3LITX">Report text</param>
		/// <param name="m3LCKR">Locked report</param>
		/// <param name="m3PAVR">View</param>
		/// <param name="m3UPVR">Personal view</param>
		/// <param name="m3OBK1">Object control parameter</param>
		/// <param name="m3OBK2">Object control parameter</param>
		/// <param name="m3OBK3">Object control parameter</param>
		/// <param name="m3OBK4">Object control parameter</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="m3QTTP">Sorting order</param>
		/// <param name="m3AGGR">Aggregation</param>
		/// <param name="m3SUB1">Subtotal 1</param>
		/// <param name="m3SUB2">Subtotal 2</param>
		/// <param name="m3SUB3">Subtotal 3</param>
		/// <param name="m3SLF1">Selection field 1</param>
		/// <param name="m3SLF2">Selection field 2</param>
		/// <param name="m3SLF3">Selection field 3</param>
		/// <param name="m3FSLT">Selection value 1</param>
		/// <param name="m3TSLT">Selection value 1</param>
		/// <param name="m3FSL2">Selection value 2</param>
		/// <param name="m3TSL2">Selection value 2</param>
		/// <param name="m3FSL3">Selection value 3</param>
		/// <param name="m3TSL3">Selection value 3</param>
		/// <param name="m3REEM">Ad-hoc report e-mail</param>
		/// <param name="m3EMTP">E-mail type</param>
		/// <param name="m3EMKY">E-mail key value</param>
		/// <param name="m3SUBJ">Subject</param>
		/// <param name="m3EMTX">E-mail text</param>
		/// <param name="m3RLCT">Ad-hoc report location</param>
		/// <param name="m3PETP">Period type</param>
		/// <param name="m3XSAL">Job schedule allowed</param>
		/// <param name="m3XCAT">Job schedule category</param>
		/// <param name="m3DOLO">Document location</param>
		/// <param name="m3SEEA">Sender e-mail address</param>
		/// <param name="m3RSRR">Save report run</param>
		/// <param name="m3RNRR">Number of days to save report run</param>
		/// <param name="m3RSRL">Save report lines</param>
		/// <param name="m3RNRL">Number of days to save report lines</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdReport(
			string m3REPO, 
			string m3REPV, 
			string m3LITX = null, 
			int? m3LCKR = null, 
			string m3PAVR = null, 
			string m3UPVR = null, 
			string m3OBK1 = null, 
			string m3OBK2 = null, 
			string m3OBK3 = null, 
			string m3OBK4 = null, 
			int? m3NFTR = null, 
			int? m3QTTP = null, 
			int? m3AGGR = null, 
			int? m3SUB1 = null, 
			int? m3SUB2 = null, 
			int? m3SUB3 = null, 
			string m3SLF1 = null, 
			string m3SLF2 = null, 
			string m3SLF3 = null, 
			string m3FSLT = null, 
			string m3TSLT = null, 
			string m3FSL2 = null, 
			string m3TSL2 = null, 
			string m3FSL3 = null, 
			string m3TSL3 = null, 
			int? m3REEM = null, 
			string m3EMTP = null, 
			string m3EMKY = null, 
			string m3SUBJ = null, 
			string m3EMTX = null, 
			string m3RLCT = null, 
			int? m3PETP = null, 
			int? m3XSAL = null, 
			string m3XCAT = null, 
			string m3DOLO = null, 
			string m3SEEA = null, 
			int? m3RSRR = null, 
			int? m3RNRR = null, 
			int? m3RSRL = null, 
			int? m3RNRL = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdReport",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3REPO))
				throw new ArgumentNullException(nameof(m3REPO));
			if (string.IsNullOrWhiteSpace(m3REPV))
				throw new ArgumentNullException(nameof(m3REPV));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPO", m3REPO.Trim())
				.WithQueryParameter("REPV", m3REPV.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LITX))
				request.WithQueryParameter("LITX", m3LITX.Trim());
			if (m3LCKR.HasValue)
				request.WithQueryParameter("LCKR", m3LCKR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAVR))
				request.WithQueryParameter("PAVR", m3PAVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPVR))
				request.WithQueryParameter("UPVR", m3UPVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK1))
				request.WithQueryParameter("OBK1", m3OBK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK2))
				request.WithQueryParameter("OBK2", m3OBK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK3))
				request.WithQueryParameter("OBK3", m3OBK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK4))
				request.WithQueryParameter("OBK4", m3OBK4.Trim());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3QTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3AGGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB1.HasValue)
				request.WithQueryParameter("SUB1", m3SUB1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB2.HasValue)
				request.WithQueryParameter("SUB2", m3SUB2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB3.HasValue)
				request.WithQueryParameter("SUB3", m3SUB3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLF1))
				request.WithQueryParameter("SLF1", m3SLF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLF2))
				request.WithQueryParameter("SLF2", m3SLF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLF3))
				request.WithQueryParameter("SLF3", m3SLF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSLT))
				request.WithQueryParameter("FSLT", m3FSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSLT))
				request.WithQueryParameter("TSLT", m3TSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSL2))
				request.WithQueryParameter("FSL2", m3FSL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSL2))
				request.WithQueryParameter("TSL2", m3TSL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSL3))
				request.WithQueryParameter("FSL3", m3FSL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSL3))
				request.WithQueryParameter("TSL3", m3TSL3.Trim());
			if (m3REEM.HasValue)
				request.WithQueryParameter("REEM", m3REEM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMTP))
				request.WithQueryParameter("EMTP", m3EMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMKY))
				request.WithQueryParameter("EMKY", m3EMKY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUBJ))
				request.WithQueryParameter("SUBJ", m3SUBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMTX))
				request.WithQueryParameter("EMTX", m3EMTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3RLCT))
				request.WithQueryParameter("RLCT", m3RLCT.Trim());
			if (m3PETP.HasValue)
				request.WithQueryParameter("PETP", m3PETP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3XSAL.HasValue)
				request.WithQueryParameter("XSAL", m3XSAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3XCAT))
				request.WithQueryParameter("XCAT", m3XCAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOLO))
				request.WithQueryParameter("DOLO", m3DOLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEEA))
				request.WithQueryParameter("SEEA", m3SEEA.Trim());
			if (m3RSRR.HasValue)
				request.WithQueryParameter("RSRR", m3RSRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRR.HasValue)
				request.WithQueryParameter("RNRR", m3RNRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSRL.HasValue)
				request.WithQueryParameter("RSRL", m3RSRL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RNRL.HasValue)
				request.WithQueryParameter("RNRL", m3RNRL.Value.ToString(CultureInfo.CurrentCulture));

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
