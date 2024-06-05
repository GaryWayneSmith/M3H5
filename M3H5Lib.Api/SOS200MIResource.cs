/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SOS200MI;
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
	/// Name: SOS200MI
	/// Component Name: ServiceOrderInquiry
	/// Description: Service order inquiry interface
	/// Version Release: 5e90
	///</summary>
	public partial class SOS200MIResource : M3BaseResourceEndpoint
	{
		public SOS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SOS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIndItemText
		/// Description Add the free format text connected to an individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INNO">Individual item number (Required)</param>
		/// <param name="m3_LINO">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TXEI">External/internal text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddIndItemText(
			string m3_INNO, 
			int m3_LINO, 
			int? m3_CONO = null, 
			string m3_TX60 = null, 
			string m3_LNCD = null, 
			string m3_TXVR = null, 
			string m3_TX40 = null, 
			int? m3_TXEI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddIndItemText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_INNO))
				throw new ArgumentNullException("m3_INNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3_INNO.Trim())
				.WithQueryParameter("LINO", m3_LINO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3_TXEI.Value.ToString());

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
		/// Name AddSOText
		/// Description Add text to a service order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_EXCL">SO head, assign. or line (Required)</param>
		/// <param name="m3_TYTX">Type of text (Required)</param>
		/// <param name="m3_LINO">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="m3_JOBN">Assignment number</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TXEI">External/internal text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSOText(
			string m3_ORNO, 
			int m3_EXCL, 
			string m3_TYTX, 
			int m3_LINO, 
			int? m3_CONO = null, 
			string m3_TX60 = null, 
			int? m3_JOBN = null, 
			int? m3_JBSX = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_LNCD = null, 
			string m3_TXVR = null, 
			string m3_TX40 = null, 
			int? m3_TXEI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSOText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_TYTX))
				throw new ArgumentNullException("m3_TYTX");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("EXCL", m3_EXCL.ToString())
				.WithQueryParameter("TYTX", m3_TYTX.Trim())
				.WithQueryParameter("LINO", m3_LINO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (m3_JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3_JOBN.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3_TXEI.Value.ToString());

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
		/// Name GetServInfo
		/// Description Get sevice information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetServInfoResponse></returns>
		/// <exception cref="M3Exception<GetServInfoResponse>"></exception>
		public async Task<M3Response<GetServInfoResponse>> GetServInfo(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_ADID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetServInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetServInfoResponse>(
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
		/// Name LstAddnlSts
		/// Description List additional status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ESTI">Additional status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAddnlStsResponse></returns>
		/// <exception cref="M3Exception<LstAddnlStsResponse>"></exception>
		public async Task<M3Response<LstAddnlStsResponse>> LstAddnlSts(
			int? m3_CONO = null, 
			string m3_ESTI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAddnlSts",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ESTI))
				request.WithQueryParameter("ESTI", m3_ESTI.Trim());

			// Execute the request
			var result = await Execute<LstAddnlStsResponse>(
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
		/// Name LstAgrText
		/// Description List agreement text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CTNO">Agreement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TXEI">External/internal text</param>
		/// <param name="m3_TYTX">Type of text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrTextResponse></returns>
		/// <exception cref="M3Exception<LstAgrTextResponse>"></exception>
		public async Task<M3Response<LstAgrTextResponse>> LstAgrText(
			string m3_CTNO, 
			int? m3_CONO = null, 
			string m3_CUPL = null, 
			string m3_ADID = null, 
			int? m3_PONR = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
			int? m3_TXEI = null, 
			string m3_TYTX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrText",
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
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3_TXEI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TYTX))
				request.WithQueryParameter("TYTX", m3_TYTX.Trim());

			// Execute the request
			var result = await Execute<LstAgrTextResponse>(
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
		/// Name LstAgrType
		/// Description List agreement types
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrTypeResponse></returns>
		/// <exception cref="M3Exception<LstAgrTypeResponse>"></exception>
		public async Task<M3Response<LstAgrTypeResponse>> LstAgrType(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstAgrTypeResponse>(
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
		/// Name LstAgrcontent
		/// Description List content of an agreemnet line (included/excluded)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CTNO">Agreement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_REF4">Ref field 0-2 allowed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrcontentResponse></returns>
		/// <exception cref="M3Exception<LstAgrcontentResponse>"></exception>
		public async Task<M3Response<LstAgrcontentResponse>> LstAgrcontent(
			string m3_CTNO, 
			int? m3_CONO = null, 
			string m3_CUPL = null, 
			int? m3_PONR = null, 
			string m3_ADID = null, 
			int? m3_POSX = null, 
			int? m3_REF4 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrcontent",
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
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_REF4.HasValue)
				request.WithQueryParameter("REF4", m3_REF4.Value.ToString());

			// Execute the request
			var result = await Execute<LstAgrcontentResponse>(
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
		/// Name LstAlias
		/// Description List alias
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_POFR">Alias ID from</param>
		/// <param name="m3_POTO">Alias ID to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAliasResponse></returns>
		/// <exception cref="M3Exception<LstAliasResponse>"></exception>
		public async Task<M3Response<LstAliasResponse>> LstAlias(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_POFR = null, 
			string m3_POTO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAlias",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POFR))
				request.WithQueryParameter("POFR", m3_POFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POTO))
				request.WithQueryParameter("POTO", m3_POTO.Trim());

			// Execute the request
			var result = await Execute<LstAliasResponse>(
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
		/// Name LstAssignPerInd
		/// Description List assignment per individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INNO">Individual item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PMDT">From error report date</param>
		/// <param name="m3_NOAF">Max number of assignments</param>
		/// <param name="m3_JBSF">Assignment status from</param>
		/// <param name="m3_JBST">Assignment status to</param>
		/// <param name="m3_LMDT">From change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssignPerIndResponse></returns>
		/// <exception cref="M3Exception<LstAssignPerIndResponse>"></exception>
		public async Task<M3Response<LstAssignPerIndResponse>> LstAssignPerInd(
			string m3_INNO, 
			int? m3_CONO = null, 
			DateTime? m3_PMDT = null, 
			int? m3_NOAF = null, 
			string m3_JBSF = null, 
			string m3_JBST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssignPerInd",
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
			if (m3_PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3_PMDT.Value.ToM3String());
			if (m3_NOAF.HasValue)
				request.WithQueryParameter("NOAF", m3_NOAF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_JBSF))
				request.WithQueryParameter("JBSF", m3_JBSF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JBST))
				request.WithQueryParameter("JBST", m3_JBST.Trim());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAssignPerIndResponse>(
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
		/// Name LstAssignmType
		/// Description List assignment type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ASST">Assignment type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssignmTypeResponse></returns>
		/// <exception cref="M3Exception<LstAssignmTypeResponse>"></exception>
		public async Task<M3Response<LstAssignmTypeResponse>> LstAssignmType(
			int? m3_CONO = null, 
			string m3_ASST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssignmType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ASST))
				request.WithQueryParameter("ASST", m3_ASST.Trim());

			// Execute the request
			var result = await Execute<LstAssignmTypeResponse>(
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
		/// Name LstBreaks
		/// Description List breaks
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBreaksResponse></returns>
		/// <exception cref="M3Exception<LstBreaksResponse>"></exception>
		public async Task<M3Response<LstBreaksResponse>> LstBreaks(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBreaks",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstBreaksResponse>(
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
		/// Name LstCalender
		/// Description List calender
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YNQE">Display work time (Required)</param>
		/// <param name="m3_YNQ1">Display lunch break (Required)</param>
		/// <param name="m3_YNQ2">Display other breaks (Required)</param>
		/// <param name="m3_YNQ3">Display absence (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_YEID">Year</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCalenderResponse></returns>
		/// <exception cref="M3Exception<LstCalenderResponse>"></exception>
		public async Task<M3Response<LstCalenderResponse>> LstCalender(
			string m3_DIVI, 
			int m3_YNQE, 
			int m3_YNQ1, 
			int m3_YNQ2, 
			int m3_YNQ3, 
			int? m3_CONO = null, 
			int? m3_YEID = null, 
			string m3_EMNO = null, 
			string m3_TECH = null, 
			string m3_SRES = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCalender",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YNQE", m3_YNQE.ToString())
				.WithQueryParameter("YNQ1", m3_YNQ1.ToString())
				.WithQueryParameter("YNQ2", m3_YNQ2.ToString())
				.WithQueryParameter("YNQ3", m3_YNQ3.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_YEID.HasValue)
				request.WithQueryParameter("YEID", m3_YEID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstCalenderResponse>(
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
		/// Name LstDiscModels
		/// Description List discount models
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDiscModelsResponse></returns>
		/// <exception cref="M3Exception<LstDiscModelsResponse>"></exception>
		public async Task<M3Response<LstDiscModelsResponse>> LstDiscModels(
			int? m3_CONO = null, 
			string m3_DISY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDiscModels",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());

			// Execute the request
			var result = await Execute<LstDiscModelsResponse>(
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
		/// Name LstDiscNumbers
		/// Description List discount numbers
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDiscNumbersResponse></returns>
		/// <exception cref="M3Exception<LstDiscNumbersResponse>"></exception>
		public async Task<M3Response<LstDiscNumbersResponse>> LstDiscNumbers(
			int? m3_CONO = null, 
			string m3_DISY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDiscNumbers",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());

			// Execute the request
			var result = await Execute<LstDiscNumbersResponse>(
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
		/// Name LstGeoPerQualif
		/// Description List geographical area per qualification and postal code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstGeoPerQualifResponse></returns>
		/// <exception cref="M3Exception<LstGeoPerQualifResponse>"></exception>
		public async Task<M3Response<LstGeoPerQualifResponse>> LstGeoPerQualif(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstGeoPerQualif",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstGeoPerQualifResponse>(
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
		/// Name LstIndItemText
		/// Description List individual item text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INNO">Individual item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIndItemTextResponse></returns>
		/// <exception cref="M3Exception<LstIndItemTextResponse>"></exception>
		public async Task<M3Response<LstIndItemTextResponse>> LstIndItemText(
			string m3_INNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIndItemText",
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
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstIndItemTextResponse>(
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
		/// Name LstIndivItems
		/// Description List individual items
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CUPL">Customer number</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_CUOW">Owner</param>
		/// <param name="m3_INTY">Individual item type</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIndivItemsResponse></returns>
		/// <exception cref="M3Exception<LstIndivItemsResponse>"></exception>
		public async Task<M3Response<LstIndivItemsResponse>> LstIndivItems(
			int? m3_CONO = null, 
			string m3_CUPL = null, 
			string m3_ADID = null, 
			string m3_CUOW = null, 
			int? m3_INTY = null, 
			decimal? m3_LMTS = null, 
			string m3_INNO = null, 
			string m3_SERI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIndivItems",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOW))
				request.WithQueryParameter("CUOW", m3_CUOW.Trim());
			if (m3_INTY.HasValue)
				request.WithQueryParameter("INTY", m3_INTY.Value.ToString());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());

			// Execute the request
			var result = await Execute<LstIndivItemsResponse>(
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
		/// Name LstNewIndItems
		/// Description List new individual items
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNewIndItemsResponse></returns>
		/// <exception cref="M3Exception<LstNewIndItemsResponse>"></exception>
		public async Task<M3Response<LstNewIndItemsResponse>> LstNewIndItems(
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNewIndItems",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstNewIndItemsResponse>(
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
		/// Name LstPayerControl
		/// Description List payer control code
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DBCO">Payer control</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayerControlResponse></returns>
		/// <exception cref="M3Exception<LstPayerControlResponse>"></exception>
		public async Task<M3Response<LstPayerControlResponse>> LstPayerControl(
			int? m3_CONO = null, 
			string m3_DBCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPayerControl",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DBCO))
				request.WithQueryParameter("DBCO", m3_DBCO.Trim());

			// Execute the request
			var result = await Execute<LstPayerControlResponse>(
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
		/// Name LstQualifPerPro
		/// Description List qualification per product type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQualifPerProResponse></returns>
		/// <exception cref="M3Exception<LstQualifPerProResponse>"></exception>
		public async Task<M3Response<LstQualifPerProResponse>> LstQualifPerPro(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQualifPerPro",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstQualifPerProResponse>(
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
		/// Name LstResponsTime
		/// Description List response time conditions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponsTimeResponse></returns>
		/// <exception cref="M3Exception<LstResponsTimeResponse>"></exception>
		public async Task<M3Response<LstResponsTimeResponse>> LstResponsTime(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstResponsTime",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstResponsTimeResponse>(
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
		/// Name LstScaleLines
		/// Description List scale lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DISY">Discount model (Required)</param>
		/// <param name="m3_DIPO">Discount number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_PREX">Priority</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstScaleLinesResponse></returns>
		/// <exception cref="M3Exception<LstScaleLinesResponse>"></exception>
		public async Task<M3Response<LstScaleLinesResponse>> LstScaleLines(
			string m3_DISY, 
			int m3_DIPO, 
			int? m3_CONO = null, 
			DateTime? m3_FVDT = null, 
			string m3_PREX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstScaleLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DISY))
				throw new ArgumentNullException("m3_DISY");

			// Set mandatory parameters
			request
				.WithQueryParameter("DISY", m3_DISY.Trim())
				.WithQueryParameter("DIPO", m3_DIPO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PREX))
				request.WithQueryParameter("PREX", m3_PREX.Trim());

			// Execute the request
			var result = await Execute<LstScaleLinesResponse>(
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
		/// Name LstServiceExp
		/// Description List service expenses
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SVID">Service expense</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServiceExpResponse></returns>
		/// <exception cref="M3Exception<LstServiceExpResponse>"></exception>
		public async Task<M3Response<LstServiceExpResponse>> LstServiceExp(
			int? m3_CONO = null, 
			string m3_SVID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstServiceExp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SVID))
				request.WithQueryParameter("SVID", m3_SVID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstServiceExpResponse>(
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
		/// Name LstSoText
		/// Description List service order text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_JOBN">Service order job number</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TXEI">External/internal text</param>
		/// <param name="m3_TYTX">Type of text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSoTextResponse></returns>
		/// <exception cref="M3Exception<LstSoTextResponse>"></exception>
		public async Task<M3Response<LstSoTextResponse>> LstSoText(
			string m3_ORNO, 
			int? m3_CONO = null, 
			int? m3_JOBN = null, 
			int? m3_JBSX = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_LNCD = null, 
			string m3_TXVR = null, 
			string m3_TX40 = null, 
			int? m3_TXEI = null, 
			string m3_TYTX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSoText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3_JOBN.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3_TXEI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TYTX))
				request.WithQueryParameter("TYTX", m3_TYTX.Trim());

			// Execute the request
			var result = await Execute<LstSoTextResponse>(
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
		/// Name LstTechGeo
		/// Description List geographical area per technician
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTechGeoResponse></returns>
		/// <exception cref="M3Exception<LstTechGeoResponse>"></exception>
		public async Task<M3Response<LstTechGeoResponse>> LstTechGeo(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTechGeo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstTechGeoResponse>(
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
		/// Name LstTravelType
		/// Description List travel type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTravelTypeResponse></returns>
		/// <exception cref="M3Exception<LstTravelTypeResponse>"></exception>
		public async Task<M3Response<LstTravelTypeResponse>> LstTravelType(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTravelType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstTravelTypeResponse>(
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
		/// Name LstValidityType
		/// Description List agreement validity type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstValidityTypeResponse></returns>
		/// <exception cref="M3Exception<LstValidityTypeResponse>"></exception>
		public async Task<M3Response<LstValidityTypeResponse>> LstValidityType(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstValidityType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstValidityTypeResponse>(
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
		/// Name LstWarranty
		/// Description List warranty
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_MWTP">ID type</param>
		/// <param name="m3_IDE1">Item ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWarrantyResponse></returns>
		/// <exception cref="M3Exception<LstWarrantyResponse>"></exception>
		public async Task<M3Response<LstWarrantyResponse>> LstWarranty(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_BRAN = null, 
			int? m3_MWTP = null, 
			string m3_IDE1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstWarranty",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (m3_MWTP.HasValue)
				request.WithQueryParameter("MWTP", m3_MWTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IDE1))
				request.WithQueryParameter("IDE1", m3_IDE1.Trim());

			// Execute the request
			var result = await Execute<LstWarrantyResponse>(
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
		/// Name LstWorkHourDef
		/// Description List work hour definitions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWorkHourDefResponse></returns>
		/// <exception cref="M3Exception<LstWorkHourDefResponse>"></exception>
		public async Task<M3Response<LstWorkHourDefResponse>> LstWorkHourDef(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstWorkHourDef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstWorkHourDefResponse>(
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
		/// Name LstWrkSchedHead
		/// Description List the work schedules for a company
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_YEID">Year</param>
		/// <param name="m3_WOSC">Work schedule</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWrkSchedHeadResponse></returns>
		/// <exception cref="M3Exception<LstWrkSchedHeadResponse>"></exception>
		public async Task<M3Response<LstWrkSchedHeadResponse>> LstWrkSchedHead(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_YEID = null, 
			int? m3_WOSC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstWrkSchedHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_YEID.HasValue)
				request.WithQueryParameter("YEID", m3_YEID.Value.ToString());
			if (m3_WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3_WOSC.Value.ToString());

			// Execute the request
			var result = await Execute<LstWrkSchedHeadResponse>(
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
		/// Name LstZones
		/// Description List zones
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstZonesResponse></returns>
		/// <exception cref="M3Exception<LstZonesResponse>"></exception>
		public async Task<M3Response<LstZonesResponse>> LstZones(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstZones",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstZonesResponse>(
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
