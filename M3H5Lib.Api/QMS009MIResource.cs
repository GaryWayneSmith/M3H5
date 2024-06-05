/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.QMS009MI;
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
	/// Name: QMS009MI
	/// Component Name: Quality plan
	/// Description: Quality plan interface
	/// Version Release: 5ea0
	///</summary>
	public partial class QMS009MIResource : M3BaseResourceEndpoint
	{
		public QMS009MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS009MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddQualityPlan
		/// Description Add a Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3QLPN">Quality plan (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3ACTF">Active (Required)</param>
		/// <param name="m3QIMD">Changing QI request (Required)</param>
		/// <param name="m3QIAT">Adding test to QI req (Required)</param>
		/// <param name="m3QPLN">Spec approval basis (Required)</param>
		/// <param name="m3QPLT">QI req appr basis (Required)</param>
		/// <param name="m3QAPP">Approval passed/passed (Required)</param>
		/// <param name="m3QAPF">Approval passed/failed (Required)</param>
		/// <param name="m3QAPN">Approval passed/not tested (Required)</param>
		/// <param name="m3QAPE">Approval passed/none (Required)</param>
		/// <param name="m3QAFP">Approval failed/passed (Required)</param>
		/// <param name="m3QAFF">Approval failed/failed (Required)</param>
		/// <param name="m3QAFN">Approval failed/not tested (Required)</param>
		/// <param name="m3QAFE">Approval failed/none (Required)</param>
		/// <param name="m3QANP">Approval not tested/passed (Required)</param>
		/// <param name="m3QANF">Approval not tested/failed (Required)</param>
		/// <param name="m3QANN">Approval not tested/not tested (Required)</param>
		/// <param name="m3QANE">Approval not tested/none (Required)</param>
		/// <param name="m3QAEP">Approval none/passed (Required)</param>
		/// <param name="m3QAEF">Approval none/failed (Required)</param>
		/// <param name="m3QAEN">Approval none/not tested (Required)</param>
		/// <param name="m3QIFR">Test freq basis for PO (Required)</param>
		/// <param name="m3QIF1">Test freq basis for MO (Required)</param>
		/// <param name="m3QIPF">Replace MO QI request (Required)</param>
		/// <param name="m3QLTA">Lot auto-approval</param>
		/// <param name="m3QSPA">Spec auto-approval</param>
		/// <param name="m3QIRA">QI request auto-approval</param>
		/// <param name="m3QRLV">QI request level</param>
		/// <param name="m3QMQT">Max quantity per QI req</param>
		/// <param name="m3QMUM">Maximum quantity per QI req U/M</param>
		/// <param name="m3QST1">Manual QI req status</param>
		/// <param name="m3TPS2">Default QI req as test at pre-ship</param>
		/// <param name="m3QIRP">Replace PO QI request</param>
		/// <param name="m3QCRF">Create QI request on CO returns</param>
		/// <param name="m3QCRO">Copy QI request on New Lot</param>
		/// <param name="m3QARE">Auto-reinspection of lots</param>
		/// <param name="m3QARL">QI reinspection level</param>
		/// <param name="m3QARB">Reinspection generation basis</param>
		/// <param name="m3QARD">Reinspection calculation date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddQualityPlan(
			string m3QLPN, 
			string m3ITNO, 
			string m3TX40, 
			int m3ACTF, 
			int m3QIMD, 
			int m3QIAT, 
			int m3QPLN, 
			int m3QPLT, 
			int m3QAPP, 
			int m3QAPF, 
			int m3QAPN, 
			int m3QAPE, 
			int m3QAFP, 
			int m3QAFF, 
			int m3QAFN, 
			int m3QAFE, 
			int m3QANP, 
			int m3QANF, 
			int m3QANN, 
			int m3QANE, 
			int m3QAEP, 
			int m3QAEF, 
			int m3QAEN, 
			int m3QIFR, 
			int m3QIF1, 
			int m3QIPF, 
			int? m3QLTA = null, 
			int? m3QSPA = null, 
			int? m3QIRA = null, 
			int? m3QRLV = null, 
			decimal? m3QMQT = null, 
			string m3QMUM = null, 
			int? m3QST1 = null, 
			int? m3TPS2 = null, 
			int? m3QIRP = null, 
			int? m3QCRF = null, 
			int? m3QCRO = null, 
			int? m3QARE = null, 
			int? m3QARL = null, 
			int? m3QARB = null, 
			int? m3QARD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddQualityPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QLPN))
				throw new ArgumentNullException(nameof(m3QLPN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3QLPN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("ACTF", m3ACTF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QIMD", m3QIMD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QIAT", m3QIAT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QPLN", m3QPLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QPLT", m3QPLT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QAPP", m3QAPP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QAPF", m3QAPF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QAPN", m3QAPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QAPE", m3QAPE.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QAFP", m3QAFP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QAFF", m3QAFF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QAFN", m3QAFN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QAFE", m3QAFE.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QANP", m3QANP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QANF", m3QANF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QANN", m3QANN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QANE", m3QANE.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QAEP", m3QAEP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QAEF", m3QAEF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QAEN", m3QAEN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QIFR", m3QIFR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QIF1", m3QIF1.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("QIPF", m3QIPF.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3QLTA.HasValue)
				request.WithQueryParameter("QLTA", m3QLTA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QSPA.HasValue)
				request.WithQueryParameter("QSPA", m3QSPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QIRA.HasValue)
				request.WithQueryParameter("QIRA", m3QIRA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QRLV.HasValue)
				request.WithQueryParameter("QRLV", m3QRLV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QMQT.HasValue)
				request.WithQueryParameter("QMQT", m3QMQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QMUM))
				request.WithQueryParameter("QMUM", m3QMUM.Trim());
			if (m3QST1.HasValue)
				request.WithQueryParameter("QST1", m3QST1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TPS2.HasValue)
				request.WithQueryParameter("TPS2", m3TPS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QIRP.HasValue)
				request.WithQueryParameter("QIRP", m3QIRP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QCRF.HasValue)
				request.WithQueryParameter("QCRF", m3QCRF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QCRO.HasValue)
				request.WithQueryParameter("QCRO", m3QCRO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QARE.HasValue)
				request.WithQueryParameter("QARE", m3QARE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QARL.HasValue)
				request.WithQueryParameter("QARL", m3QARL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QARB.HasValue)
				request.WithQueryParameter("QARB", m3QARB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QARD.HasValue)
				request.WithQueryParameter("QARD", m3QARD.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltQualityPlan
		/// Description Delete a Quality Plan
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3QLPN">Quality plan (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltQualityPlan(
			string m3QLPN, 
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltQualityPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QLPN))
				throw new ArgumentNullException(nameof(m3QLPN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3QLPN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

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
		/// Name GetQualityPlan
		/// Description Get a Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3QLPN">Quality plan (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQualityPlanResponse></returns>
		/// <exception cref="M3Exception<GetQualityPlanResponse>"></exception>
		public async Task<M3Response<GetQualityPlanResponse>> GetQualityPlan(
			string m3QLPN, 
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetQualityPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QLPN))
				throw new ArgumentNullException(nameof(m3QLPN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3QLPN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<GetQualityPlanResponse>(
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
		/// Name LstQualityPlan
		/// Description List the Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3QLPN">Quality plan</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQualityPlanResponse></returns>
		/// <exception cref="M3Exception<LstQualityPlanResponse>"></exception>
		public async Task<M3Response<LstQualityPlanResponse>> LstQualityPlan(
			string m3QLPN = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstQualityPlan",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3QLPN))
				request.WithQueryParameter("QLPN", m3QLPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstQualityPlanResponse>(
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
		/// Name UpdQualityPlan
		/// Description Update a Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3QLPN">Quality plan (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3ACTF">Active</param>
		/// <param name="m3QIMD">Changing QI request</param>
		/// <param name="m3QIAT">Adding test to QI req</param>
		/// <param name="m3QPLN">Spec approval basis</param>
		/// <param name="m3QPLT">QI req appr basis</param>
		/// <param name="m3QAPP">Approval passed/passed</param>
		/// <param name="m3QAPF">Approval passed/failed</param>
		/// <param name="m3QAPN">Approval passed/not tested</param>
		/// <param name="m3QAPE">Approval passed/none</param>
		/// <param name="m3QAFP">Approval failed/passed</param>
		/// <param name="m3QAFF">Approval failed/failed</param>
		/// <param name="m3QAFN">Approval failed/not tested</param>
		/// <param name="m3QAFE">Approval not tested/passed</param>
		/// <param name="m3QANP">Approval not tested/passed</param>
		/// <param name="m3QANF">Approval not tested/failed</param>
		/// <param name="m3QANN">Approval not tested/not tested</param>
		/// <param name="m3QANE">Approval not tested/none</param>
		/// <param name="m3QAEP">Approval none/passed</param>
		/// <param name="m3QAEF">Approval none/failed</param>
		/// <param name="m3QAEN">Approval none/not tested</param>
		/// <param name="m3QLTA">Lot auto-approval</param>
		/// <param name="m3QSPA">Spec auto-approval</param>
		/// <param name="m3QIRA">QI request auto-approval</param>
		/// <param name="m3QRLV">QI request level</param>
		/// <param name="m3QMQT">Max quantity per QI req</param>
		/// <param name="m3QMUM">Maximum quantity per QI req U/M</param>
		/// <param name="m3QST1">Manual QI req status</param>
		/// <param name="m3TPS2">Default QI req as test at pre-ship</param>
		/// <param name="m3QIFR">Test freq basis for PO</param>
		/// <param name="m3QIRP">Replace PO QI request</param>
		/// <param name="m3QIF1">Test freq basis for MO</param>
		/// <param name="m3QIPF">Replace MO QI request</param>
		/// <param name="m3QCRF">Create QI request on CO returns</param>
		/// <param name="m3QCRO">Copy QI request on new lot</param>
		/// <param name="m3QARE">Auto-reinspection of lots</param>
		/// <param name="m3QARL">QI reinspection level</param>
		/// <param name="m3QARB">Reinspection generation basis</param>
		/// <param name="m3QARD">Reinspection calculation date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdQualityPlan(
			string m3QLPN, 
			string m3ITNO, 
			string m3TX40 = null, 
			int? m3ACTF = null, 
			int? m3QIMD = null, 
			int? m3QIAT = null, 
			int? m3QPLN = null, 
			int? m3QPLT = null, 
			int? m3QAPP = null, 
			int? m3QAPF = null, 
			int? m3QAPN = null, 
			int? m3QAPE = null, 
			int? m3QAFP = null, 
			int? m3QAFF = null, 
			int? m3QAFN = null, 
			int? m3QAFE = null, 
			int? m3QANP = null, 
			int? m3QANF = null, 
			int? m3QANN = null, 
			int? m3QANE = null, 
			int? m3QAEP = null, 
			int? m3QAEF = null, 
			int? m3QAEN = null, 
			int? m3QLTA = null, 
			int? m3QSPA = null, 
			int? m3QIRA = null, 
			int? m3QRLV = null, 
			decimal? m3QMQT = null, 
			string m3QMUM = null, 
			int? m3QST1 = null, 
			int? m3TPS2 = null, 
			int? m3QIFR = null, 
			int? m3QIRP = null, 
			int? m3QIF1 = null, 
			int? m3QIPF = null, 
			int? m3QCRF = null, 
			int? m3QCRO = null, 
			int? m3QARE = null, 
			int? m3QARL = null, 
			int? m3QARB = null, 
			int? m3QARD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdQualityPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3QLPN))
				throw new ArgumentNullException(nameof(m3QLPN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3QLPN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3ACTF.HasValue)
				request.WithQueryParameter("ACTF", m3ACTF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QIMD.HasValue)
				request.WithQueryParameter("QIMD", m3QIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QIAT.HasValue)
				request.WithQueryParameter("QIAT", m3QIAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPLN.HasValue)
				request.WithQueryParameter("QPLN", m3QPLN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QPLT.HasValue)
				request.WithQueryParameter("QPLT", m3QPLT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QAPP.HasValue)
				request.WithQueryParameter("QAPP", m3QAPP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QAPF.HasValue)
				request.WithQueryParameter("QAPF", m3QAPF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QAPN.HasValue)
				request.WithQueryParameter("QAPN", m3QAPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QAPE.HasValue)
				request.WithQueryParameter("QAPE", m3QAPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QAFP.HasValue)
				request.WithQueryParameter("QAFP", m3QAFP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QAFF.HasValue)
				request.WithQueryParameter("QAFF", m3QAFF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QAFN.HasValue)
				request.WithQueryParameter("QAFN", m3QAFN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QAFE.HasValue)
				request.WithQueryParameter("QAFE", m3QAFE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QANP.HasValue)
				request.WithQueryParameter("QANP", m3QANP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QANF.HasValue)
				request.WithQueryParameter("QANF", m3QANF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QANN.HasValue)
				request.WithQueryParameter("QANN", m3QANN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QANE.HasValue)
				request.WithQueryParameter("QANE", m3QANE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QAEP.HasValue)
				request.WithQueryParameter("QAEP", m3QAEP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QAEF.HasValue)
				request.WithQueryParameter("QAEF", m3QAEF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QAEN.HasValue)
				request.WithQueryParameter("QAEN", m3QAEN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLTA.HasValue)
				request.WithQueryParameter("QLTA", m3QLTA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QSPA.HasValue)
				request.WithQueryParameter("QSPA", m3QSPA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QIRA.HasValue)
				request.WithQueryParameter("QIRA", m3QIRA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QRLV.HasValue)
				request.WithQueryParameter("QRLV", m3QRLV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QMQT.HasValue)
				request.WithQueryParameter("QMQT", m3QMQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QMUM))
				request.WithQueryParameter("QMUM", m3QMUM.Trim());
			if (m3QST1.HasValue)
				request.WithQueryParameter("QST1", m3QST1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TPS2.HasValue)
				request.WithQueryParameter("TPS2", m3TPS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QIFR.HasValue)
				request.WithQueryParameter("QIFR", m3QIFR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QIRP.HasValue)
				request.WithQueryParameter("QIRP", m3QIRP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QIF1.HasValue)
				request.WithQueryParameter("QIF1", m3QIF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QIPF.HasValue)
				request.WithQueryParameter("QIPF", m3QIPF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QCRF.HasValue)
				request.WithQueryParameter("QCRF", m3QCRF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QCRO.HasValue)
				request.WithQueryParameter("QCRO", m3QCRO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QARE.HasValue)
				request.WithQueryParameter("QARE", m3QARE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QARL.HasValue)
				request.WithQueryParameter("QARL", m3QARL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QARB.HasValue)
				request.WithQueryParameter("QARB", m3QARB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QARD.HasValue)
				request.WithQueryParameter("QARD", m3QARD.Value.ToString(CultureInfo.CurrentCulture));

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
