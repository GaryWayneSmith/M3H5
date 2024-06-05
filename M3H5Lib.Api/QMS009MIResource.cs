/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddQualityPlan
		/// Description Add a Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QLPN">Quality plan (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_ACTF">Active (Required)</param>
		/// <param name="m3_QIMD">Changing QI request (Required)</param>
		/// <param name="m3_QIAT">Adding test to QI req (Required)</param>
		/// <param name="m3_QPLN">Spec approval basis (Required)</param>
		/// <param name="m3_QPLT">QI req appr basis (Required)</param>
		/// <param name="m3_QAPP">Approval passed/passed (Required)</param>
		/// <param name="m3_QAPF">Approval passed/failed (Required)</param>
		/// <param name="m3_QAPN">Approval passed/not tested (Required)</param>
		/// <param name="m3_QAPE">Approval passed/none (Required)</param>
		/// <param name="m3_QAFP">Approval failed/passed (Required)</param>
		/// <param name="m3_QAFF">Approval failed/failed (Required)</param>
		/// <param name="m3_QAFN">Approval failed/not tested (Required)</param>
		/// <param name="m3_QAFE">Approval failed/none (Required)</param>
		/// <param name="m3_QANP">Approval not tested/passed (Required)</param>
		/// <param name="m3_QANF">Approval not tested/failed (Required)</param>
		/// <param name="m3_QANN">Approval not tested/not tested (Required)</param>
		/// <param name="m3_QANE">Approval not tested/none (Required)</param>
		/// <param name="m3_QAEP">Approval none/passed (Required)</param>
		/// <param name="m3_QAEF">Approval none/failed (Required)</param>
		/// <param name="m3_QAEN">Approval none/not tested (Required)</param>
		/// <param name="m3_QIFR">Test freq basis for PO (Required)</param>
		/// <param name="m3_QIF1">Test freq basis for MO (Required)</param>
		/// <param name="m3_QIPF">Replace MO QI request (Required)</param>
		/// <param name="m3_QLTA">Lot auto-approval</param>
		/// <param name="m3_QSPA">Spec auto-approval</param>
		/// <param name="m3_QIRA">QI request auto-approval</param>
		/// <param name="m3_QRLV">QI request level</param>
		/// <param name="m3_QMQT">Max quantity per QI req</param>
		/// <param name="m3_QMUM">Maximum quantity per QI req U/M</param>
		/// <param name="m3_QST1">Manual QI req status</param>
		/// <param name="m3_TPS2">Default QI req as test at pre-ship</param>
		/// <param name="m3_QIRP">Replace PO QI request</param>
		/// <param name="m3_QCRF">Create QI request on CO returns</param>
		/// <param name="m3_QCRO">Copy QI request on New Lot</param>
		/// <param name="m3_QARE">Auto-reinspection of lots</param>
		/// <param name="m3_QARL">QI reinspection level</param>
		/// <param name="m3_QARB">Reinspection generation basis</param>
		/// <param name="m3_QARD">Reinspection calculation date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddQualityPlan(
			string m3_QLPN, 
			string m3_ITNO, 
			string m3_TX40, 
			int m3_ACTF, 
			int m3_QIMD, 
			int m3_QIAT, 
			int m3_QPLN, 
			int m3_QPLT, 
			int m3_QAPP, 
			int m3_QAPF, 
			int m3_QAPN, 
			int m3_QAPE, 
			int m3_QAFP, 
			int m3_QAFF, 
			int m3_QAFN, 
			int m3_QAFE, 
			int m3_QANP, 
			int m3_QANF, 
			int m3_QANN, 
			int m3_QANE, 
			int m3_QAEP, 
			int m3_QAEF, 
			int m3_QAEN, 
			int m3_QIFR, 
			int m3_QIF1, 
			int m3_QIPF, 
			int? m3_QLTA = null, 
			int? m3_QSPA = null, 
			int? m3_QIRA = null, 
			int? m3_QRLV = null, 
			decimal? m3_QMQT = null, 
			string m3_QMUM = null, 
			int? m3_QST1 = null, 
			int? m3_TPS2 = null, 
			int? m3_QIRP = null, 
			int? m3_QCRF = null, 
			int? m3_QCRO = null, 
			int? m3_QARE = null, 
			int? m3_QARL = null, 
			int? m3_QARB = null, 
			int? m3_QARD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddQualityPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QLPN))
				throw new ArgumentNullException("m3_QLPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3_QLPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("ACTF", m3_ACTF.ToString())
				.WithQueryParameter("QIMD", m3_QIMD.ToString())
				.WithQueryParameter("QIAT", m3_QIAT.ToString())
				.WithQueryParameter("QPLN", m3_QPLN.ToString())
				.WithQueryParameter("QPLT", m3_QPLT.ToString())
				.WithQueryParameter("QAPP", m3_QAPP.ToString())
				.WithQueryParameter("QAPF", m3_QAPF.ToString())
				.WithQueryParameter("QAPN", m3_QAPN.ToString())
				.WithQueryParameter("QAPE", m3_QAPE.ToString())
				.WithQueryParameter("QAFP", m3_QAFP.ToString())
				.WithQueryParameter("QAFF", m3_QAFF.ToString())
				.WithQueryParameter("QAFN", m3_QAFN.ToString())
				.WithQueryParameter("QAFE", m3_QAFE.ToString())
				.WithQueryParameter("QANP", m3_QANP.ToString())
				.WithQueryParameter("QANF", m3_QANF.ToString())
				.WithQueryParameter("QANN", m3_QANN.ToString())
				.WithQueryParameter("QANE", m3_QANE.ToString())
				.WithQueryParameter("QAEP", m3_QAEP.ToString())
				.WithQueryParameter("QAEF", m3_QAEF.ToString())
				.WithQueryParameter("QAEN", m3_QAEN.ToString())
				.WithQueryParameter("QIFR", m3_QIFR.ToString())
				.WithQueryParameter("QIF1", m3_QIF1.ToString())
				.WithQueryParameter("QIPF", m3_QIPF.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_QLTA.HasValue)
				request.WithQueryParameter("QLTA", m3_QLTA.Value.ToString());
			if (m3_QSPA.HasValue)
				request.WithQueryParameter("QSPA", m3_QSPA.Value.ToString());
			if (m3_QIRA.HasValue)
				request.WithQueryParameter("QIRA", m3_QIRA.Value.ToString());
			if (m3_QRLV.HasValue)
				request.WithQueryParameter("QRLV", m3_QRLV.Value.ToString());
			if (m3_QMQT.HasValue)
				request.WithQueryParameter("QMQT", m3_QMQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QMUM))
				request.WithQueryParameter("QMUM", m3_QMUM.Trim());
			if (m3_QST1.HasValue)
				request.WithQueryParameter("QST1", m3_QST1.Value.ToString());
			if (m3_TPS2.HasValue)
				request.WithQueryParameter("TPS2", m3_TPS2.Value.ToString());
			if (m3_QIRP.HasValue)
				request.WithQueryParameter("QIRP", m3_QIRP.Value.ToString());
			if (m3_QCRF.HasValue)
				request.WithQueryParameter("QCRF", m3_QCRF.Value.ToString());
			if (m3_QCRO.HasValue)
				request.WithQueryParameter("QCRO", m3_QCRO.Value.ToString());
			if (m3_QARE.HasValue)
				request.WithQueryParameter("QARE", m3_QARE.Value.ToString());
			if (m3_QARL.HasValue)
				request.WithQueryParameter("QARL", m3_QARL.Value.ToString());
			if (m3_QARB.HasValue)
				request.WithQueryParameter("QARB", m3_QARB.Value.ToString());
			if (m3_QARD.HasValue)
				request.WithQueryParameter("QARD", m3_QARD.Value.ToString());

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
		/// Name DltQualityPlan
		/// Description Delete a Quality Plan
		/// Version Release: 15.x
		/// </summary>
		/// <param name="m3_QLPN">Quality plan (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltQualityPlan(
			string m3_QLPN, 
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltQualityPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QLPN))
				throw new ArgumentNullException("m3_QLPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3_QLPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

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
		/// Name GetQualityPlan
		/// Description Get a Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QLPN">Quality plan (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQualityPlanResponse></returns>
		/// <exception cref="M3Exception<GetQualityPlanResponse>"></exception>
		public async Task<M3Response<GetQualityPlanResponse>> GetQualityPlan(
			string m3_QLPN, 
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetQualityPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QLPN))
				throw new ArgumentNullException("m3_QLPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3_QLPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<GetQualityPlanResponse>(
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
		/// Name LstQualityPlan
		/// Description List the Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QLPN">Quality plan</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQualityPlanResponse></returns>
		/// <exception cref="M3Exception<LstQualityPlanResponse>"></exception>
		public async Task<M3Response<LstQualityPlanResponse>> LstQualityPlan(
			string m3_QLPN = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQualityPlan",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QLPN))
				request.WithQueryParameter("QLPN", m3_QLPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstQualityPlanResponse>(
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
		/// Name UpdQualityPlan
		/// Description Update a Quality Plan
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_QLPN">Quality plan (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_ACTF">Active</param>
		/// <param name="m3_QIMD">Changing QI request</param>
		/// <param name="m3_QIAT">Adding test to QI req</param>
		/// <param name="m3_QPLN">Spec approval basis</param>
		/// <param name="m3_QPLT">QI req appr basis</param>
		/// <param name="m3_QAPP">Approval passed/passed</param>
		/// <param name="m3_QAPF">Approval passed/failed</param>
		/// <param name="m3_QAPN">Approval passed/not tested</param>
		/// <param name="m3_QAPE">Approval passed/none</param>
		/// <param name="m3_QAFP">Approval failed/passed</param>
		/// <param name="m3_QAFF">Approval failed/failed</param>
		/// <param name="m3_QAFN">Approval failed/not tested</param>
		/// <param name="m3_QAFE">Approval not tested/passed</param>
		/// <param name="m3_QANP">Approval not tested/passed</param>
		/// <param name="m3_QANF">Approval not tested/failed</param>
		/// <param name="m3_QANN">Approval not tested/not tested</param>
		/// <param name="m3_QANE">Approval not tested/none</param>
		/// <param name="m3_QAEP">Approval none/passed</param>
		/// <param name="m3_QAEF">Approval none/failed</param>
		/// <param name="m3_QAEN">Approval none/not tested</param>
		/// <param name="m3_QLTA">Lot auto-approval</param>
		/// <param name="m3_QSPA">Spec auto-approval</param>
		/// <param name="m3_QIRA">QI request auto-approval</param>
		/// <param name="m3_QRLV">QI request level</param>
		/// <param name="m3_QMQT">Max quantity per QI req</param>
		/// <param name="m3_QMUM">Maximum quantity per QI req U/M</param>
		/// <param name="m3_QST1">Manual QI req status</param>
		/// <param name="m3_TPS2">Default QI req as test at pre-ship</param>
		/// <param name="m3_QIFR">Test freq basis for PO</param>
		/// <param name="m3_QIRP">Replace PO QI request</param>
		/// <param name="m3_QIF1">Test freq basis for MO</param>
		/// <param name="m3_QIPF">Replace MO QI request</param>
		/// <param name="m3_QCRF">Create QI request on CO returns</param>
		/// <param name="m3_QCRO">Copy QI request on new lot</param>
		/// <param name="m3_QARE">Auto-reinspection of lots</param>
		/// <param name="m3_QARL">QI reinspection level</param>
		/// <param name="m3_QARB">Reinspection generation basis</param>
		/// <param name="m3_QARD">Reinspection calculation date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdQualityPlan(
			string m3_QLPN, 
			string m3_ITNO, 
			string m3_TX40 = null, 
			int? m3_ACTF = null, 
			int? m3_QIMD = null, 
			int? m3_QIAT = null, 
			int? m3_QPLN = null, 
			int? m3_QPLT = null, 
			int? m3_QAPP = null, 
			int? m3_QAPF = null, 
			int? m3_QAPN = null, 
			int? m3_QAPE = null, 
			int? m3_QAFP = null, 
			int? m3_QAFF = null, 
			int? m3_QAFN = null, 
			int? m3_QAFE = null, 
			int? m3_QANP = null, 
			int? m3_QANF = null, 
			int? m3_QANN = null, 
			int? m3_QANE = null, 
			int? m3_QAEP = null, 
			int? m3_QAEF = null, 
			int? m3_QAEN = null, 
			int? m3_QLTA = null, 
			int? m3_QSPA = null, 
			int? m3_QIRA = null, 
			int? m3_QRLV = null, 
			decimal? m3_QMQT = null, 
			string m3_QMUM = null, 
			int? m3_QST1 = null, 
			int? m3_TPS2 = null, 
			int? m3_QIFR = null, 
			int? m3_QIRP = null, 
			int? m3_QIF1 = null, 
			int? m3_QIPF = null, 
			int? m3_QCRF = null, 
			int? m3_QCRO = null, 
			int? m3_QARE = null, 
			int? m3_QARL = null, 
			int? m3_QARB = null, 
			int? m3_QARD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdQualityPlan",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QLPN))
				throw new ArgumentNullException("m3_QLPN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("QLPN", m3_QLPN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_ACTF.HasValue)
				request.WithQueryParameter("ACTF", m3_ACTF.Value.ToString());
			if (m3_QIMD.HasValue)
				request.WithQueryParameter("QIMD", m3_QIMD.Value.ToString());
			if (m3_QIAT.HasValue)
				request.WithQueryParameter("QIAT", m3_QIAT.Value.ToString());
			if (m3_QPLN.HasValue)
				request.WithQueryParameter("QPLN", m3_QPLN.Value.ToString());
			if (m3_QPLT.HasValue)
				request.WithQueryParameter("QPLT", m3_QPLT.Value.ToString());
			if (m3_QAPP.HasValue)
				request.WithQueryParameter("QAPP", m3_QAPP.Value.ToString());
			if (m3_QAPF.HasValue)
				request.WithQueryParameter("QAPF", m3_QAPF.Value.ToString());
			if (m3_QAPN.HasValue)
				request.WithQueryParameter("QAPN", m3_QAPN.Value.ToString());
			if (m3_QAPE.HasValue)
				request.WithQueryParameter("QAPE", m3_QAPE.Value.ToString());
			if (m3_QAFP.HasValue)
				request.WithQueryParameter("QAFP", m3_QAFP.Value.ToString());
			if (m3_QAFF.HasValue)
				request.WithQueryParameter("QAFF", m3_QAFF.Value.ToString());
			if (m3_QAFN.HasValue)
				request.WithQueryParameter("QAFN", m3_QAFN.Value.ToString());
			if (m3_QAFE.HasValue)
				request.WithQueryParameter("QAFE", m3_QAFE.Value.ToString());
			if (m3_QANP.HasValue)
				request.WithQueryParameter("QANP", m3_QANP.Value.ToString());
			if (m3_QANF.HasValue)
				request.WithQueryParameter("QANF", m3_QANF.Value.ToString());
			if (m3_QANN.HasValue)
				request.WithQueryParameter("QANN", m3_QANN.Value.ToString());
			if (m3_QANE.HasValue)
				request.WithQueryParameter("QANE", m3_QANE.Value.ToString());
			if (m3_QAEP.HasValue)
				request.WithQueryParameter("QAEP", m3_QAEP.Value.ToString());
			if (m3_QAEF.HasValue)
				request.WithQueryParameter("QAEF", m3_QAEF.Value.ToString());
			if (m3_QAEN.HasValue)
				request.WithQueryParameter("QAEN", m3_QAEN.Value.ToString());
			if (m3_QLTA.HasValue)
				request.WithQueryParameter("QLTA", m3_QLTA.Value.ToString());
			if (m3_QSPA.HasValue)
				request.WithQueryParameter("QSPA", m3_QSPA.Value.ToString());
			if (m3_QIRA.HasValue)
				request.WithQueryParameter("QIRA", m3_QIRA.Value.ToString());
			if (m3_QRLV.HasValue)
				request.WithQueryParameter("QRLV", m3_QRLV.Value.ToString());
			if (m3_QMQT.HasValue)
				request.WithQueryParameter("QMQT", m3_QMQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QMUM))
				request.WithQueryParameter("QMUM", m3_QMUM.Trim());
			if (m3_QST1.HasValue)
				request.WithQueryParameter("QST1", m3_QST1.Value.ToString());
			if (m3_TPS2.HasValue)
				request.WithQueryParameter("TPS2", m3_TPS2.Value.ToString());
			if (m3_QIFR.HasValue)
				request.WithQueryParameter("QIFR", m3_QIFR.Value.ToString());
			if (m3_QIRP.HasValue)
				request.WithQueryParameter("QIRP", m3_QIRP.Value.ToString());
			if (m3_QIF1.HasValue)
				request.WithQueryParameter("QIF1", m3_QIF1.Value.ToString());
			if (m3_QIPF.HasValue)
				request.WithQueryParameter("QIPF", m3_QIPF.Value.ToString());
			if (m3_QCRF.HasValue)
				request.WithQueryParameter("QCRF", m3_QCRF.Value.ToString());
			if (m3_QCRO.HasValue)
				request.WithQueryParameter("QCRO", m3_QCRO.Value.ToString());
			if (m3_QARE.HasValue)
				request.WithQueryParameter("QARE", m3_QARE.Value.ToString());
			if (m3_QARL.HasValue)
				request.WithQueryParameter("QARL", m3_QARL.Value.ToString());
			if (m3_QARB.HasValue)
				request.WithQueryParameter("QARB", m3_QARB.Value.ToString());
			if (m3_QARD.HasValue)
				request.WithQueryParameter("QARD", m3_QARD.Value.ToString());

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
