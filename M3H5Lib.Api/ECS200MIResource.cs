/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.ECS200MI;
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
	/// Name: ECS200MI
	/// Component Name: EngineeringOrder
	/// Description: Engineering order interface
	/// Version Release: 5ea0
	///</summary>
	public partial class ECS200MIResource : M3BaseResourceEndpoint
	{
		public ECS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ECS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAffSerialNo
		/// Description Add Affected Serial No.
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_PLSD">Planned start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAffSerialNo(
			string m3_AECN, 
			string m3_AECR, 
			string m3_ITNO, 
			string m3_BANO, 
			DateTime? m3_PLSD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAffSerialNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3_PLSD.Value.ToM3String());

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
		/// Name AddEO
		/// Description Add Engineering Order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AECT">Engineering order type (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_DEPT">Department (Required)</param>
		/// <param name="m3_AECC">Engineering order category (Required)</param>
		/// <param name="m3_AECL">Engineering order class (Required)</param>
		/// <param name="m3_AECN">Engineering order number</param>
		/// <param name="m3_AECS">Status - engineering order</param>
		/// <param name="m3_ARVD">Revision date</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_AECM">Mandatory</param>
		/// <param name="m3_PCHG">Item number change</param>
		/// <param name="m3_AERE">Repetitive</param>
		/// <param name="m3_ACMO">Automatic approval of modification</param>
		/// <param name="m3_AGRP">Engineering order group</param>
		/// <param name="m3_APR2">Priority</param>
		/// <param name="m3_STNC">Standard numbering system</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_FUNC">Function area</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_AISB">Document issuer</param>
		/// <param name="m3_ADOB">Document object</param>
		/// <param name="m3_ALPD">Latest performance date</param>
		/// <param name="m3_ALDS">Latest performance date - warehouse</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_MRET">Retrospective</param>
		/// <param name="m3_ARVR">Reason for document revision</param>
		/// <param name="m3_ATRD">Date revised</param>
		/// <param name="m3_ARVB">Revised by</param>
		/// <param name="m3_REDA">Receipt date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddEOResponse></returns>
		/// <exception cref="M3Exception<AddEOResponse>"></exception>
		public async Task<M3Response<AddEOResponse>> AddEO(
			string m3_AECT, 
			string m3_TX40, 
			string m3_DEPT, 
			string m3_AECC, 
			string m3_AECL, 
			string m3_AECN = null, 
			string m3_AECS = null, 
			DateTime? m3_ARVD = null, 
			string m3_RESP = null, 
			int? m3_AECM = null, 
			int? m3_PCHG = null, 
			int? m3_AERE = null, 
			int? m3_ACMO = null, 
			string m3_AGRP = null, 
			int? m3_APR2 = null, 
			string m3_STNC = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_FUNC = null, 
			string m3_DOID = null, 
			string m3_ECVE = null, 
			string m3_AISB = null, 
			string m3_ADOB = null, 
			DateTime? m3_ALPD = null, 
			DateTime? m3_ALDS = null, 
			string m3_WATP = null, 
			int? m3_MRET = null, 
			string m3_ARVR = null, 
			DateTime? m3_ATRD = null, 
			string m3_ARVB = null, 
			DateTime? m3_REDA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddEO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECT))
				throw new ArgumentNullException("m3_AECT");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_DEPT))
				throw new ArgumentNullException("m3_DEPT");
			if (string.IsNullOrWhiteSpace(m3_AECC))
				throw new ArgumentNullException("m3_AECC");
			if (string.IsNullOrWhiteSpace(m3_AECL))
				throw new ArgumentNullException("m3_AECL");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECT", m3_AECT.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("DEPT", m3_DEPT.Trim())
				.WithQueryParameter("AECC", m3_AECC.Trim())
				.WithQueryParameter("AECL", m3_AECL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AECN))
				request.WithQueryParameter("AECN", m3_AECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AECS))
				request.WithQueryParameter("AECS", m3_AECS.Trim());
			if (m3_ARVD.HasValue)
				request.WithQueryParameter("ARVD", m3_ARVD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_AECM.HasValue)
				request.WithQueryParameter("AECM", m3_AECM.Value.ToString());
			if (m3_PCHG.HasValue)
				request.WithQueryParameter("PCHG", m3_PCHG.Value.ToString());
			if (m3_AERE.HasValue)
				request.WithQueryParameter("AERE", m3_AERE.Value.ToString());
			if (m3_ACMO.HasValue)
				request.WithQueryParameter("ACMO", m3_ACMO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGRP))
				request.WithQueryParameter("AGRP", m3_AGRP.Trim());
			if (m3_APR2.HasValue)
				request.WithQueryParameter("APR2", m3_APR2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STNC))
				request.WithQueryParameter("STNC", m3_STNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUNC))
				request.WithQueryParameter("FUNC", m3_FUNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AISB))
				request.WithQueryParameter("AISB", m3_AISB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADOB))
				request.WithQueryParameter("ADOB", m3_ADOB.Trim());
			if (m3_ALPD.HasValue)
				request.WithQueryParameter("ALPD", m3_ALPD.Value.ToM3String());
			if (m3_ALDS.HasValue)
				request.WithQueryParameter("ALDS", m3_ALDS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (m3_MRET.HasValue)
				request.WithQueryParameter("MRET", m3_MRET.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ARVR))
				request.WithQueryParameter("ARVR", m3_ARVR.Trim());
			if (m3_ATRD.HasValue)
				request.WithQueryParameter("ATRD", m3_ATRD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ARVB))
				request.WithQueryParameter("ARVB", m3_ARVB.Trim());
			if (m3_REDA.HasValue)
				request.WithQueryParameter("REDA", m3_REDA.Value.ToM3String());

			// Execute the request
			var result = await Execute<AddEOResponse>(
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
		/// Name AddEOLine
		/// Description Add Engineering Order Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_ECVE">Revision number (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEOLine(
			string m3_AECN, 
			string m3_AECR, 
			string m3_SUFI, 
			string m3_ECVE, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddEOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_ECVE))
				throw new ArgumentNullException("m3_ECVE");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("ECVE", m3_ECVE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

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
		/// Name AddModRefComp
		/// Description Add Modification reference component
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3_AOPN">Old item number (Required)</param>
		/// <param name="m3_MODM">Modification marking</param>
		/// <param name="m3_ANPN">New item number</param>
		/// <param name="m3_AINS">Instruction</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddModRefComp(
			string m3_AECN, 
			string m3_AECR, 
			string m3_AOPN, 
			string m3_MODM = null, 
			string m3_ANPN = null, 
			string m3_AINS = null, 
			decimal? m3_CNQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddModRefComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");
			if (string.IsNullOrWhiteSpace(m3_AOPN))
				throw new ArgumentNullException("m3_AOPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim())
				.WithQueryParameter("AOPN", m3_AOPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MODM))
				request.WithQueryParameter("MODM", m3_MODM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ANPN))
				request.WithQueryParameter("ANPN", m3_ANPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AINS))
				request.WithQueryParameter("AINS", m3_AINS.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());

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
		/// Name CopyToNewRev
		/// Description Copy Engineering order to new revision
		/// Version Release: 
		/// </summary>
		/// <param name="m3_AECN">Engineering order number</param>
		/// <param name="m3_AECR">Revision number - engineering order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CopyToNewRev(
			string m3_AECN = null, 
			string m3_AECR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CopyToNewRev",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AECN))
				request.WithQueryParameter("AECN", m3_AECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AECR))
				request.WithQueryParameter("AECR", m3_AECR.Trim());

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
		/// Name DeactivateEO
		/// Description Deactivate Engineering order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeactivateEO(
			string m3_AECN, 
			string m3_AECR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeactivateEO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim());

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
		/// Name DelAffSerialNo
		/// Description Delete Affected Serial Number
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAffSerialNo(
			string m3_AECN, 
			string m3_AECR, 
			string m3_ITNO, 
			string m3_BANO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAffSerialNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim());

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
		/// Name DelEOLine
		/// Description Delete Engineering Order Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_ECVE">Revision number (Required)</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelEOLine(
			string m3_AECN, 
			string m3_AECR, 
			string m3_SUFI, 
			string m3_ECVE, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelEOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_ECVE))
				throw new ArgumentNullException("m3_ECVE");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("ECVE", m3_ECVE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

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
		/// Name DelModRefComp
		/// Description DelModRefComp
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3_AOPN">Old item number (Required)</param>
		/// <param name="m3_ANPN">New item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelModRefComp(
			string m3_AECN, 
			string m3_AECR, 
			string m3_AOPN, 
			string m3_ANPN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelModRefComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");
			if (string.IsNullOrWhiteSpace(m3_AOPN))
				throw new ArgumentNullException("m3_AOPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim())
				.WithQueryParameter("AOPN", m3_AOPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ANPN))
				request.WithQueryParameter("ANPN", m3_ANPN.Trim());

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
		/// Name GetAffSerialNo
		/// Description Get affected serial numbers
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAffSerialNoResponse></returns>
		/// <exception cref="M3Exception<GetAffSerialNoResponse>"></exception>
		public async Task<M3Response<GetAffSerialNoResponse>> GetAffSerialNo(
			string m3_AECN, 
			string m3_AECR, 
			string m3_ITNO, 
			string m3_BANO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAffSerialNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<GetAffSerialNoResponse>(
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
		/// Name GetBasic
		/// Description Get Basic data for EO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicResponse></returns>
		/// <exception cref="M3Exception<GetBasicResponse>"></exception>
		public async Task<M3Response<GetBasicResponse>> GetBasic(
			string m3_AECN, 
			string m3_AECR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim());

			// Execute the request
			var result = await Execute<GetBasicResponse>(
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
		/// Name LstByResp
		/// Description List EO by responsible
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByRespResponse></returns>
		/// <exception cref="M3Exception<LstByRespResponse>"></exception>
		public async Task<M3Response<LstByRespResponse>> LstByResp(
			string m3_RESP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByResp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");

			// Set mandatory parameters
			request
				.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<LstByRespResponse>(
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
		/// Name LstEOLines
		/// Description List Engineering Order Lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEOLinesResponse></returns>
		/// <exception cref="M3Exception<LstEOLinesResponse>"></exception>
		public async Task<M3Response<LstEOLinesResponse>> LstEOLines(
			string m3_AECN, 
			string m3_AECR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstEOLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim());

			// Execute the request
			var result = await Execute<LstEOLinesResponse>(
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
		/// Name LstModRefComp
		/// Description List Modification reference component
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModRefCompResponse></returns>
		/// <exception cref="M3Exception<LstModRefCompResponse>"></exception>
		public async Task<M3Response<LstModRefCompResponse>> LstModRefComp(
			string m3_AECN, 
			string m3_AECR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstModRefComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim());

			// Execute the request
			var result = await Execute<LstModRefCompResponse>(
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
		/// Name RtvAffected
		/// Description Retrieve affected serial numbers
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLSD">Planned start date (Required)</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_AECN">Engineering order number</param>
		/// <param name="m3_AECR">Revision number - engineering order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvAffectedResponse></returns>
		/// <exception cref="M3Exception<RtvAffectedResponse>"></exception>
		public async Task<M3Response<RtvAffectedResponse>> RtvAffected(
			DateTime m3_PLSD, 
			string m3_DOID = null, 
			string m3_ECVE = null, 
			string m3_AECN = null, 
			string m3_AECR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RtvAffected",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLSD", m3_PLSD.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AECN))
				request.WithQueryParameter("AECN", m3_AECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AECR))
				request.WithQueryParameter("AECR", m3_AECR.Trim());

			// Execute the request
			var result = await Execute<RtvAffectedResponse>(
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
		/// Name TransferToProd
		/// Description Transfer Engineering order to production
		/// Version Release: 
		/// </summary>
		/// <param name="m3_AECN">Engineering order number</param>
		/// <param name="m3_AECR">Revision number - engineering order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TransferToProd(
			string m3_AECN = null, 
			string m3_AECR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TransferToProd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AECN))
				request.WithQueryParameter("AECN", m3_AECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AECR))
				request.WithQueryParameter("AECR", m3_AECR.Trim());

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
		/// Name UpdEO
		/// Description Update Engineering Order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3_AECS">Status - engineering order</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_AECM">Mandatory</param>
		/// <param name="m3_PCHG">Item number change</param>
		/// <param name="m3_AERE">Repetitive</param>
		/// <param name="m3_ACMO">Automatic approval of modification</param>
		/// <param name="m3_AECC">Engineering order category</param>
		/// <param name="m3_AGRP">Engineering order group</param>
		/// <param name="m3_AECL">Engineering order class</param>
		/// <param name="m3_APR2">Priority</param>
		/// <param name="m3_STNC">Standard numbering system</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_FUNC">Function area</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_ALPD">Latest performance date</param>
		/// <param name="m3_ALDS">Latest performance date - warehouse</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_MRET">Retrospective</param>
		/// <param name="m3_ARVD">Revision date</param>
		/// <param name="m3_ARVR">Reason for document revision</param>
		/// <param name="m3_ATRD">Date revised</param>
		/// <param name="m3_ARVB">Revised by</param>
		/// <param name="m3_REDA">Receipt date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdEO(
			string m3_AECN, 
			string m3_AECR, 
			string m3_AECS = null, 
			string m3_TX40 = null, 
			string m3_RESP = null, 
			string m3_DEPT = null, 
			int? m3_AECM = null, 
			int? m3_PCHG = null, 
			int? m3_AERE = null, 
			int? m3_ACMO = null, 
			string m3_AECC = null, 
			string m3_AGRP = null, 
			string m3_AECL = null, 
			int? m3_APR2 = null, 
			string m3_STNC = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_FUNC = null, 
			string m3_DOID = null, 
			string m3_ECVE = null, 
			DateTime? m3_ALPD = null, 
			DateTime? m3_ALDS = null, 
			string m3_WATP = null, 
			int? m3_MRET = null, 
			DateTime? m3_ARVD = null, 
			string m3_ARVR = null, 
			DateTime? m3_ATRD = null, 
			string m3_ARVB = null, 
			DateTime? m3_REDA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdEO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AECS))
				request.WithQueryParameter("AECS", m3_AECS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (m3_AECM.HasValue)
				request.WithQueryParameter("AECM", m3_AECM.Value.ToString());
			if (m3_PCHG.HasValue)
				request.WithQueryParameter("PCHG", m3_PCHG.Value.ToString());
			if (m3_AERE.HasValue)
				request.WithQueryParameter("AERE", m3_AERE.Value.ToString());
			if (m3_ACMO.HasValue)
				request.WithQueryParameter("ACMO", m3_ACMO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AECC))
				request.WithQueryParameter("AECC", m3_AECC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRP))
				request.WithQueryParameter("AGRP", m3_AGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AECL))
				request.WithQueryParameter("AECL", m3_AECL.Trim());
			if (m3_APR2.HasValue)
				request.WithQueryParameter("APR2", m3_APR2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STNC))
				request.WithQueryParameter("STNC", m3_STNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUNC))
				request.WithQueryParameter("FUNC", m3_FUNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (m3_ALPD.HasValue)
				request.WithQueryParameter("ALPD", m3_ALPD.Value.ToM3String());
			if (m3_ALDS.HasValue)
				request.WithQueryParameter("ALDS", m3_ALDS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (m3_MRET.HasValue)
				request.WithQueryParameter("MRET", m3_MRET.Value.ToString());
			if (m3_ARVD.HasValue)
				request.WithQueryParameter("ARVD", m3_ARVD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ARVR))
				request.WithQueryParameter("ARVR", m3_ARVR.Trim());
			if (m3_ATRD.HasValue)
				request.WithQueryParameter("ATRD", m3_ATRD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ARVB))
				request.WithQueryParameter("ARVB", m3_ARVB.Trim());
			if (m3_REDA.HasValue)
				request.WithQueryParameter("REDA", m3_REDA.Value.ToM3String());

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
		/// Name UpdModRefComp
		/// Description Update Modification reference component
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_AECN">Engineering order number (Required)</param>
		/// <param name="m3_AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3_AOPN">Old item number (Required)</param>
		/// <param name="m3_MODM">Modification marking</param>
		/// <param name="m3_ANPN">New item number</param>
		/// <param name="m3_AINS">Instruction</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdModRefComp(
			string m3_AECN, 
			string m3_AECR, 
			string m3_AOPN, 
			string m3_MODM = null, 
			string m3_ANPN = null, 
			string m3_AINS = null, 
			decimal? m3_CNQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdModRefComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AECN))
				throw new ArgumentNullException("m3_AECN");
			if (string.IsNullOrWhiteSpace(m3_AECR))
				throw new ArgumentNullException("m3_AECR");
			if (string.IsNullOrWhiteSpace(m3_AOPN))
				throw new ArgumentNullException("m3_AOPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3_AECN.Trim())
				.WithQueryParameter("AECR", m3_AECR.Trim())
				.WithQueryParameter("AOPN", m3_AOPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MODM))
				request.WithQueryParameter("MODM", m3_MODM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ANPN))
				request.WithQueryParameter("ANPN", m3_ANPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AINS))
				request.WithQueryParameter("AINS", m3_AINS.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());

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
