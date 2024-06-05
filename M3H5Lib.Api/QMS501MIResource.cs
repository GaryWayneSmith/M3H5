/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QMS501MI;
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
	/// Name: QMS501MI
	/// Component Name: Order Specification Test
	/// Description: Api:Order Specification Test Interface
	/// Version Release: 
	///</summary>
	public partial class QMS501MIResource : M3BaseResourceEndpoint
	{
		public QMS501MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS501MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddOrderSpecTst
		/// Description Add Order Spec Test
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QTST">Test</param>
		/// <param name="m3_QTE1">Effective date</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="m3_TSTY">Test type</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_QTI1">Inactive date</param>
		/// <param name="m3_QTI2">Inactive time</param>
		/// <param name="m3_EXSQ">Test order</param>
		/// <param name="m3_TCLS">Test classification</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_MSUR">Measurement method</param>
		/// <param name="m3_MSIN">Measurement instrument</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_LABO">Laboratory</param>
		/// <param name="m3_SMTP">Sample type</param>
		/// <param name="m3_INSD">Industry standard</param>
		/// <param name="m3_VLTP">Value setup</param>
		/// <param name="m3_QTCD">Numeric qualitative</param>
		/// <param name="m3_QLCD">Test result</param>
		/// <param name="m3_QOP1">Expected operator</param>
		/// <param name="m3_EVMX">Expected value max</param>
		/// <param name="m3_EVMN">Expected value min</param>
		/// <param name="m3_EVTG">Expected target value</param>
		/// <param name="m3_TEUM">Test U/M</param>
		/// <param name="m3_REQD">Required</param>
		/// <param name="m3_SMPR">Sampling required</param>
		/// <param name="m3_INTR">Internal test required</param>
		/// <param name="m3_FRPR">Frequency per</param>
		/// <param name="m3_FRTI">Frequency times</param>
		/// <param name="m3_FRQY">Frequency quantity</param>
		/// <param name="m3_FRUM">Frequency U/M</param>
		/// <param name="m3_SMSZ">Sample size</param>
		/// <param name="m3_DSSM">Discard sample</param>
		/// <param name="m3_RTSM">Retain sample</param>
		/// <param name="m3_TCAL">Calculated by formula</param>
		/// <param name="m3_QTSP">Test priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOrderSpecTst(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QTST = null, 
			DateTime? m3_QTE1 = null, 
			int? m3_QTE2 = null, 
			int? m3_TSTY = null, 
			string m3_TX40 = null, 
			DateTime? m3_QTI1 = null, 
			int? m3_QTI2 = null, 
			int? m3_EXSQ = null, 
			string m3_TCLS = null, 
			string m3_ATID = null, 
			string m3_MSUR = null, 
			string m3_MSIN = null, 
			string m3_DEPT = null, 
			string m3_LABO = null, 
			string m3_SMTP = null, 
			string m3_INSD = null, 
			int? m3_VLTP = null, 
			string m3_QTCD = null, 
			string m3_QLCD = null, 
			int? m3_QOP1 = null, 
			decimal? m3_EVMX = null, 
			decimal? m3_EVMN = null, 
			decimal? m3_EVTG = null, 
			string m3_TEUM = null, 
			int? m3_REQD = null, 
			int? m3_SMPR = null, 
			int? m3_INTR = null, 
			int? m3_FRPR = null, 
			int? m3_FRTI = null, 
			decimal? m3_FRQY = null, 
			string m3_FRUM = null, 
			decimal? m3_SMSZ = null, 
			int? m3_DSSM = null, 
			int? m3_RTSM = null, 
			int? m3_TCAL = null, 
			int? m3_QTSP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOrderSpecTst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QTST))
				request.WithQueryParameter("QTST", m3_QTST.Trim());
			if (m3_QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3_QTE1.Value.ToM3String());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());
			if (m3_TSTY.HasValue)
				request.WithQueryParameter("TSTY", m3_TSTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_QTI1.HasValue)
				request.WithQueryParameter("QTI1", m3_QTI1.Value.ToM3String());
			if (m3_QTI2.HasValue)
				request.WithQueryParameter("QTI2", m3_QTI2.Value.ToString());
			if (m3_EXSQ.HasValue)
				request.WithQueryParameter("EXSQ", m3_EXSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TCLS))
				request.WithQueryParameter("TCLS", m3_TCLS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSUR))
				request.WithQueryParameter("MSUR", m3_MSUR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSIN))
				request.WithQueryParameter("MSIN", m3_MSIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LABO))
				request.WithQueryParameter("LABO", m3_LABO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMTP))
				request.WithQueryParameter("SMTP", m3_SMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSD))
				request.WithQueryParameter("INSD", m3_INSD.Trim());
			if (m3_VLTP.HasValue)
				request.WithQueryParameter("VLTP", m3_VLTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QTCD))
				request.WithQueryParameter("QTCD", m3_QTCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QLCD))
				request.WithQueryParameter("QLCD", m3_QLCD.Trim());
			if (m3_QOP1.HasValue)
				request.WithQueryParameter("QOP1", m3_QOP1.Value.ToString());
			if (m3_EVMX.HasValue)
				request.WithQueryParameter("EVMX", m3_EVMX.Value.ToString());
			if (m3_EVMN.HasValue)
				request.WithQueryParameter("EVMN", m3_EVMN.Value.ToString());
			if (m3_EVTG.HasValue)
				request.WithQueryParameter("EVTG", m3_EVTG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEUM))
				request.WithQueryParameter("TEUM", m3_TEUM.Trim());
			if (m3_REQD.HasValue)
				request.WithQueryParameter("REQD", m3_REQD.Value.ToString());
			if (m3_SMPR.HasValue)
				request.WithQueryParameter("SMPR", m3_SMPR.Value.ToString());
			if (m3_INTR.HasValue)
				request.WithQueryParameter("INTR", m3_INTR.Value.ToString());
			if (m3_FRPR.HasValue)
				request.WithQueryParameter("FRPR", m3_FRPR.Value.ToString());
			if (m3_FRTI.HasValue)
				request.WithQueryParameter("FRTI", m3_FRTI.Value.ToString());
			if (m3_FRQY.HasValue)
				request.WithQueryParameter("FRQY", m3_FRQY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRUM))
				request.WithQueryParameter("FRUM", m3_FRUM.Trim());
			if (m3_SMSZ.HasValue)
				request.WithQueryParameter("SMSZ", m3_SMSZ.Value.ToString());
			if (m3_DSSM.HasValue)
				request.WithQueryParameter("DSSM", m3_DSSM.Value.ToString());
			if (m3_RTSM.HasValue)
				request.WithQueryParameter("RTSM", m3_RTSM.Value.ToString());
			if (m3_TCAL.HasValue)
				request.WithQueryParameter("TCAL", m3_TCAL.Value.ToString());
			if (m3_QTSP.HasValue)
				request.WithQueryParameter("QTSP", m3_QTSP.Value.ToString());

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
		/// Name DltOrderSpecTst
		/// Description Delete Order Spec Test
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QTST">Test</param>
		/// <param name="m3_QTE1">Effective date</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="m3_TSTY">Test type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltOrderSpecTst(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QTST = null, 
			DateTime? m3_QTE1 = null, 
			int? m3_QTE2 = null, 
			int? m3_TSTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltOrderSpecTst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QTST))
				request.WithQueryParameter("QTST", m3_QTST.Trim());
			if (m3_QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3_QTE1.Value.ToM3String());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());
			if (m3_TSTY.HasValue)
				request.WithQueryParameter("TSTY", m3_TSTY.Value.ToString());

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
		/// Name GetOrderSpecTst
		/// Description Get Order Spec Test
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QTST">Test</param>
		/// <param name="m3_QTE1">Effective date</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="m3_TSTY">Test type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderSpecTstResponse></returns>
		/// <exception cref="M3Exception<GetOrderSpecTstResponse>"></exception>
		public async Task<M3Response<GetOrderSpecTstResponse>> GetOrderSpecTst(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QTST = null, 
			DateTime? m3_QTE1 = null, 
			int? m3_QTE2 = null, 
			int? m3_TSTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOrderSpecTst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QTST))
				request.WithQueryParameter("QTST", m3_QTST.Trim());
			if (m3_QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3_QTE1.Value.ToM3String());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());
			if (m3_TSTY.HasValue)
				request.WithQueryParameter("TSTY", m3_TSTY.Value.ToString());

			// Execute the request
			var result = await Execute<GetOrderSpecTstResponse>(
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
		/// Name LstOrderSpecTst
		/// Description List Order Spec Test
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QTST">Test</param>
		/// <param name="m3_QTE1">Effective date</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="m3_TSTY">Test type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOrderSpecTstResponse></returns>
		/// <exception cref="M3Exception<LstOrderSpecTstResponse>"></exception>
		public async Task<M3Response<LstOrderSpecTstResponse>> LstOrderSpecTst(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QTST = null, 
			DateTime? m3_QTE1 = null, 
			int? m3_QTE2 = null, 
			int? m3_TSTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOrderSpecTst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QTST))
				request.WithQueryParameter("QTST", m3_QTST.Trim());
			if (m3_QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3_QTE1.Value.ToM3String());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());
			if (m3_TSTY.HasValue)
				request.WithQueryParameter("TSTY", m3_TSTY.Value.ToString());

			// Execute the request
			var result = await Execute<LstOrderSpecTstResponse>(
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
		/// Name UpdOrderSpecTst
		/// Description Update Order Spec Test
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QTST">Test</param>
		/// <param name="m3_QTE1">Effective date</param>
		/// <param name="m3_QTE2">Effective time</param>
		/// <param name="m3_TSTY">Test type</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_QTI1">Inactive date</param>
		/// <param name="m3_QTI2">Inactive time</param>
		/// <param name="m3_EXSQ">Test order</param>
		/// <param name="m3_TCLS">Test classification</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_MSUR">Measurement method</param>
		/// <param name="m3_MSIN">Measurement instrument</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_LABO">Laboratory</param>
		/// <param name="m3_SMTP">Sample type</param>
		/// <param name="m3_INSD">Industry standard</param>
		/// <param name="m3_VLTP">Value setup</param>
		/// <param name="m3_QTCD">Numeric qualitative</param>
		/// <param name="m3_QLCD">Test result</param>
		/// <param name="m3_QOP1">Expected operator</param>
		/// <param name="m3_EVMX">Expected value max</param>
		/// <param name="m3_EVMN">Expected value min</param>
		/// <param name="m3_EVTG">Expected target value</param>
		/// <param name="m3_TEUM">Test U/M</param>
		/// <param name="m3_REQD">Required</param>
		/// <param name="m3_SMPR">Sampling required</param>
		/// <param name="m3_INTR">Internal test required</param>
		/// <param name="m3_FRPR">Frequency per</param>
		/// <param name="m3_FRTI">Frequency times</param>
		/// <param name="m3_FRQY">Frequency quantity</param>
		/// <param name="m3_FRUM">Frequency U/M</param>
		/// <param name="m3_SMSZ">Sample size</param>
		/// <param name="m3_DSSM">Discard sample</param>
		/// <param name="m3_RTSM">Retain sample</param>
		/// <param name="m3_TCAL">Calculated by formula</param>
		/// <param name="m3_QTSP">Test priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdOrderSpecTst(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_SPEC = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_ITNO = null, 
			string m3_QTST = null, 
			DateTime? m3_QTE1 = null, 
			int? m3_QTE2 = null, 
			int? m3_TSTY = null, 
			string m3_TX40 = null, 
			DateTime? m3_QTI1 = null, 
			int? m3_QTI2 = null, 
			int? m3_EXSQ = null, 
			string m3_TCLS = null, 
			string m3_ATID = null, 
			string m3_MSUR = null, 
			string m3_MSIN = null, 
			string m3_DEPT = null, 
			string m3_LABO = null, 
			string m3_SMTP = null, 
			string m3_INSD = null, 
			int? m3_VLTP = null, 
			string m3_QTCD = null, 
			string m3_QLCD = null, 
			int? m3_QOP1 = null, 
			decimal? m3_EVMX = null, 
			decimal? m3_EVMN = null, 
			decimal? m3_EVTG = null, 
			string m3_TEUM = null, 
			int? m3_REQD = null, 
			int? m3_SMPR = null, 
			int? m3_INTR = null, 
			int? m3_FRPR = null, 
			int? m3_FRTI = null, 
			decimal? m3_FRQY = null, 
			string m3_FRUM = null, 
			decimal? m3_SMSZ = null, 
			int? m3_DSSM = null, 
			int? m3_RTSM = null, 
			int? m3_TCAL = null, 
			int? m3_QTSP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdOrderSpecTst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QTST))
				request.WithQueryParameter("QTST", m3_QTST.Trim());
			if (m3_QTE1.HasValue)
				request.WithQueryParameter("QTE1", m3_QTE1.Value.ToM3String());
			if (m3_QTE2.HasValue)
				request.WithQueryParameter("QTE2", m3_QTE2.Value.ToString());
			if (m3_TSTY.HasValue)
				request.WithQueryParameter("TSTY", m3_TSTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_QTI1.HasValue)
				request.WithQueryParameter("QTI1", m3_QTI1.Value.ToM3String());
			if (m3_QTI2.HasValue)
				request.WithQueryParameter("QTI2", m3_QTI2.Value.ToString());
			if (m3_EXSQ.HasValue)
				request.WithQueryParameter("EXSQ", m3_EXSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TCLS))
				request.WithQueryParameter("TCLS", m3_TCLS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSUR))
				request.WithQueryParameter("MSUR", m3_MSUR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSIN))
				request.WithQueryParameter("MSIN", m3_MSIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LABO))
				request.WithQueryParameter("LABO", m3_LABO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMTP))
				request.WithQueryParameter("SMTP", m3_SMTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSD))
				request.WithQueryParameter("INSD", m3_INSD.Trim());
			if (m3_VLTP.HasValue)
				request.WithQueryParameter("VLTP", m3_VLTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QTCD))
				request.WithQueryParameter("QTCD", m3_QTCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QLCD))
				request.WithQueryParameter("QLCD", m3_QLCD.Trim());
			if (m3_QOP1.HasValue)
				request.WithQueryParameter("QOP1", m3_QOP1.Value.ToString());
			if (m3_EVMX.HasValue)
				request.WithQueryParameter("EVMX", m3_EVMX.Value.ToString());
			if (m3_EVMN.HasValue)
				request.WithQueryParameter("EVMN", m3_EVMN.Value.ToString());
			if (m3_EVTG.HasValue)
				request.WithQueryParameter("EVTG", m3_EVTG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEUM))
				request.WithQueryParameter("TEUM", m3_TEUM.Trim());
			if (m3_REQD.HasValue)
				request.WithQueryParameter("REQD", m3_REQD.Value.ToString());
			if (m3_SMPR.HasValue)
				request.WithQueryParameter("SMPR", m3_SMPR.Value.ToString());
			if (m3_INTR.HasValue)
				request.WithQueryParameter("INTR", m3_INTR.Value.ToString());
			if (m3_FRPR.HasValue)
				request.WithQueryParameter("FRPR", m3_FRPR.Value.ToString());
			if (m3_FRTI.HasValue)
				request.WithQueryParameter("FRTI", m3_FRTI.Value.ToString());
			if (m3_FRQY.HasValue)
				request.WithQueryParameter("FRQY", m3_FRQY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRUM))
				request.WithQueryParameter("FRUM", m3_FRUM.Trim());
			if (m3_SMSZ.HasValue)
				request.WithQueryParameter("SMSZ", m3_SMSZ.Value.ToString());
			if (m3_DSSM.HasValue)
				request.WithQueryParameter("DSSM", m3_DSSM.Value.ToString());
			if (m3_RTSM.HasValue)
				request.WithQueryParameter("RTSM", m3_RTSM.Value.ToString());
			if (m3_TCAL.HasValue)
				request.WithQueryParameter("TCAL", m3_TCAL.Value.ToString());
			if (m3_QTSP.HasValue)
				request.WithQueryParameter("QTSP", m3_QTSP.Value.ToString());

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
