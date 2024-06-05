/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SOS400MI;
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
	/// Name: SOS400MI
	/// Component Name: ServiceOrderInq
	/// Description: Service order inquiry interface
	/// Version Release: 5e90
	///</summary>
	public partial class SOS400MIResource : M3BaseResourceEndpoint
	{
		public SOS400MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SOS400MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAssignStsHis
		/// Description Add assignment status history
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_JOBN">Service order job number (Required)</param>
		/// <param name="m3_JBSX">Assignment suffix (Required)</param>
		/// <param name="m3_JBST">Status service assignment (Required)</param>
		/// <param name="m3_CDJS">Change date assignment status (Required)</param>
		/// <param name="m3_CTJS">Entry time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_JBSE">Additional status</param>
		/// <param name="m3_WOS1">Work schedule 1</param>
		/// <param name="m3_WOS2">Work schedule 2</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddAssignStsHisResponse></returns>
		/// <exception cref="M3Exception<AddAssignStsHisResponse>"></exception>
		public async Task<M3Response<AddAssignStsHisResponse>> AddAssignStsHis(
			string m3_ORNO, 
			int m3_JOBN, 
			int m3_JBSX, 
			string m3_JBST, 
			DateTime m3_CDJS, 
			int m3_CTJS, 
			int? m3_CONO = null, 
			string m3_JBSE = null, 
			int? m3_WOS1 = null, 
			int? m3_WOS2 = null, 
			string m3_SRES = null, 
			string m3_TECH = null, 
			string m3_USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAssignStsHis",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_JBST))
				throw new ArgumentNullException("m3_JBST");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("JBSX", m3_JBSX.ToString())
				.WithQueryParameter("JBST", m3_JBST.Trim())
				.WithQueryParameter("CDJS", m3_CDJS.ToM3String())
				.WithQueryParameter("CTJS", m3_CTJS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_JBSE))
				request.WithQueryParameter("JBSE", m3_JBSE.Trim());
			if (m3_WOS1.HasValue)
				request.WithQueryParameter("WOS1", m3_WOS1.Value.ToString());
			if (m3_WOS2.HasValue)
				request.WithQueryParameter("WOS2", m3_WOS2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<AddAssignStsHisResponse>(
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
		/// Name DelAssignStsHis
		/// Description Delete assignment status history
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_JOBN">Service order job number (Required)</param>
		/// <param name="m3_JBSX">Assignment suffix (Required)</param>
		/// <param name="m3_JBST">Status service assignment (Required)</param>
		/// <param name="m3_CDJS">Change date assignment status (Required)</param>
		/// <param name="m3_CTJS">Entry time (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_JBSE">Additional status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelAssignStsHisResponse></returns>
		/// <exception cref="M3Exception<DelAssignStsHisResponse>"></exception>
		public async Task<M3Response<DelAssignStsHisResponse>> DelAssignStsHis(
			string m3_ORNO, 
			int m3_JOBN, 
			int m3_JBSX, 
			string m3_JBST, 
			DateTime m3_CDJS, 
			int m3_CTJS, 
			int? m3_CONO = null, 
			string m3_JBSE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAssignStsHis",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_JBST))
				throw new ArgumentNullException("m3_JBST");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("JBSX", m3_JBSX.ToString())
				.WithQueryParameter("JBST", m3_JBST.Trim())
				.WithQueryParameter("CDJS", m3_CDJS.ToM3String())
				.WithQueryParameter("CTJS", m3_CTJS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_JBSE))
				request.WithQueryParameter("JBSE", m3_JBSE.Trim());

			// Execute the request
			var result = await Execute<DelAssignStsHisResponse>(
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
		/// Name LstAgrLocation
		/// Description List agreement location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrLocationResponse></returns>
		/// <exception cref="M3Exception<LstAgrLocationResponse>"></exception>
		public async Task<M3Response<LstAgrLocationResponse>> LstAgrLocation(
			int? m3_CONO = null, 
			string m3_CTNO = null, 
			string m3_CUPL = null, 
			string m3_ADID = null, 
			DateTime? m3_LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrLocation",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAgrLocationResponse>(
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
		/// Name LstAgrMtrPrDet
		/// Description List agreement meter price schedule, detail
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CTNO">Agreement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrMtrPrDetResponse></returns>
		/// <exception cref="M3Exception<LstAgrMtrPrDetResponse>"></exception>
		public async Task<M3Response<LstAgrMtrPrDetResponse>> LstAgrMtrPrDet(
			string m3_CTNO, 
			int? m3_CONO = null, 
			string m3_CUPL = null, 
			string m3_ADID = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrMtrPrDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CTNO))
				throw new ArgumentNullException("m3_CTNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3_CTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<LstAgrMtrPrDetResponse>(
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
		/// Name LstAgrMtrPrHd
		/// Description List agreement meter price schedule, head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CTNO">Agreement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrMtrPrHdResponse></returns>
		/// <exception cref="M3Exception<LstAgrMtrPrHdResponse>"></exception>
		public async Task<M3Response<LstAgrMtrPrHdResponse>> LstAgrMtrPrHd(
			string m3_CTNO, 
			int? m3_CONO = null, 
			string m3_CUPL = null, 
			string m3_ADID = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrMtrPrHd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CTNO))
				throw new ArgumentNullException("m3_CTNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3_CTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<LstAgrMtrPrHdResponse>(
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
		/// Name LstAgrOrdType
		/// Description List agreement ordertype
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AOTP">Agreement order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrOrdTypeResponse></returns>
		/// <exception cref="M3Exception<LstAgrOrdTypeResponse>"></exception>
		public async Task<M3Response<LstAgrOrdTypeResponse>> LstAgrOrdType(
			int? m3_CONO = null, 
			string m3_AOTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrOrdType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOTP))
				request.WithQueryParameter("AOTP", m3_AOTP.Trim());

			// Execute the request
			var result = await Execute<LstAgrOrdTypeResponse>(
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
		/// Name LstAgrhead
		/// Description List agreement head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrheadResponse></returns>
		/// <exception cref="M3Exception<LstAgrheadResponse>"></exception>
		public async Task<M3Response<LstAgrheadResponse>> LstAgrhead(
			int? m3_CONO = null, 
			string m3_CUPL = null, 
			string m3_CTNO = null, 
			DateTime? m3_LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrhead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAgrheadResponse>(
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
		/// Name LstAssignStsHis
		/// Description List assignment status history
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_JOBN">Service order job number</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssignStsHisResponse></returns>
		/// <exception cref="M3Exception<LstAssignStsHisResponse>"></exception>
		public async Task<M3Response<LstAssignStsHisResponse>> LstAssignStsHis(
			int? m3_CONO = null, 
			string m3_ORNO = null, 
			int? m3_JOBN = null, 
			int? m3_JBSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssignStsHis",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3_JOBN.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());

			// Execute the request
			var result = await Execute<LstAssignStsHisResponse>(
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
		/// Name LstContrItems
		/// Description List contract items
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AGRS">Contract item</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstContrItemsResponse></returns>
		/// <exception cref="M3Exception<LstContrItemsResponse>"></exception>
		public async Task<M3Response<LstContrItemsResponse>> LstContrItems(
			int? m3_CONO = null, 
			string m3_AGRS = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstContrItems",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGRS))
				request.WithQueryParameter("AGRS", m3_AGRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstContrItemsResponse>(
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
		/// Name LstItmSrvSupplm
		/// Description List item service supplement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmSrvSupplmResponse></returns>
		/// <exception cref="M3Exception<LstItmSrvSupplmResponse>"></exception>
		public async Task<M3Response<LstItmSrvSupplmResponse>> LstItmSrvSupplm(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmSrvSupplm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstItmSrvSupplmResponse>(
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
		/// Name LstMtrByItm
		/// Description List meter by item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMtrByItmResponse></returns>
		/// <exception cref="M3Exception<LstMtrByItmResponse>"></exception>
		public async Task<M3Response<LstMtrByItmResponse>> LstMtrByItm(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMtrByItm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstMtrByItmResponse>(
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
		/// Name LstMtrTransHist
		/// Description List individual meter transaction history
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INNO">Individual item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MEEV">Meter event</param>
		/// <param name="m3_EVDT">From event date</param>
		/// <param name="m3_LMDT">From change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMtrTransHistResponse></returns>
		/// <exception cref="M3Exception<LstMtrTransHistResponse>"></exception>
		public async Task<M3Response<LstMtrTransHistResponse>> LstMtrTransHist(
			string m3_INNO, 
			int? m3_CONO = null, 
			string m3_MEEV = null, 
			DateTime? m3_EVDT = null, 
			DateTime? m3_LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMtrTransHist",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_INNO))
				throw new ArgumentNullException("m3_INNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3_INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MEEV))
				request.WithQueryParameter("MEEV", m3_MEEV.Trim());
			if (m3_EVDT.HasValue)
				request.WithQueryParameter("EVDT", m3_EVDT.Value.ToM3String());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstMtrTransHistResponse>(
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
		/// Name LstSOHead
		/// Description List service order head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ORFR">Lowest status from</param>
		/// <param name="m3_ORTO">Lowest status to</param>
		/// <param name="m3_LMDT">Change date from</param>
		/// <param name="m3_SOTF">SO type from</param>
		/// <param name="m3_SOTT">SO type to</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSOHeadResponse></returns>
		/// <exception cref="M3Exception<LstSOHeadResponse>"></exception>
		public async Task<M3Response<LstSOHeadResponse>> LstSOHead(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_FACI = null, 
			string m3_ORFR = null, 
			string m3_ORTO = null, 
			DateTime? m3_LMDT = null, 
			string m3_SOTF = null, 
			string m3_SOTT = null, 
			string m3_CUNO = null, 
			string m3_ORNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSOHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORFR))
				request.WithQueryParameter("ORFR", m3_ORFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTO))
				request.WithQueryParameter("ORTO", m3_ORTO.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SOTF))
				request.WithQueryParameter("SOTF", m3_SOTF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SOTT))
				request.WithQueryParameter("SOTT", m3_SOTT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Execute the request
			var result = await Execute<LstSOHeadResponse>(
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
		/// Name LstServKitHead
		/// Description List service kithead
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_KTIT">Service kit</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServKitHeadResponse></returns>
		/// <exception cref="M3Exception<LstServKitHeadResponse>"></exception>
		public async Task<M3Response<LstServKitHeadResponse>> LstServKitHead(
			int? m3_CONO = null, 
			string m3_KTIT = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstServKitHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_KTIT))
				request.WithQueryParameter("KTIT", m3_KTIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstServKitHeadResponse>(
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
		/// Name LstServKitLine
		/// Description List service kitline
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_KTIT">Service kit</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServKitLineResponse></returns>
		/// <exception cref="M3Exception<LstServKitLineResponse>"></exception>
		public async Task<M3Response<LstServKitLineResponse>> LstServKitLine(
			int? m3_CONO = null, 
			string m3_KTIT = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstServKitLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_KTIT))
				request.WithQueryParameter("KTIT", m3_KTIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstServKitLineResponse>(
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
