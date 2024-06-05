/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAffSerialNo
		/// Description Add Affected Serial No.
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="m3PLSD">Planned start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAffSerialNo(
			string m3AECN, 
			string m3AECR, 
			string m3ITNO, 
			string m3BANO, 
			DateTime? m3PLSD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAffSerialNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3PLSD.Value.ToM3String());

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
		/// Name AddEO
		/// Description Add Engineering Order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AECT">Engineering order type (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3DEPT">Department (Required)</param>
		/// <param name="m3AECC">Engineering order category (Required)</param>
		/// <param name="m3AECL">Engineering order class (Required)</param>
		/// <param name="m3AECN">Engineering order number</param>
		/// <param name="m3AECS">Status - engineering order</param>
		/// <param name="m3ARVD">Revision date</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3AECM">Mandatory</param>
		/// <param name="m3PCHG">Item number change</param>
		/// <param name="m3AERE">Repetitive</param>
		/// <param name="m3ACMO">Automatic approval of modification</param>
		/// <param name="m3AGRP">Engineering order group</param>
		/// <param name="m3APR2">Priority</param>
		/// <param name="m3STNC">Standard numbering system</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3FUNC">Function area</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3AISB">Document issuer</param>
		/// <param name="m3ADOB">Document object</param>
		/// <param name="m3ALPD">Latest performance date</param>
		/// <param name="m3ALDS">Latest performance date - warehouse</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3MRET">Retrospective</param>
		/// <param name="m3ARVR">Reason for document revision</param>
		/// <param name="m3ATRD">Date revised</param>
		/// <param name="m3ARVB">Revised by</param>
		/// <param name="m3REDA">Receipt date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddEOResponse></returns>
		/// <exception cref="M3Exception<AddEOResponse>"></exception>
		public async Task<M3Response<AddEOResponse>> AddEO(
			string m3AECT, 
			string m3TX40, 
			string m3DEPT, 
			string m3AECC, 
			string m3AECL, 
			string m3AECN = null, 
			string m3AECS = null, 
			DateTime? m3ARVD = null, 
			string m3RESP = null, 
			int? m3AECM = null, 
			int? m3PCHG = null, 
			int? m3AERE = null, 
			int? m3ACMO = null, 
			string m3AGRP = null, 
			int? m3APR2 = null, 
			string m3STNC = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3FUNC = null, 
			string m3DOID = null, 
			string m3ECVE = null, 
			string m3AISB = null, 
			string m3ADOB = null, 
			DateTime? m3ALPD = null, 
			DateTime? m3ALDS = null, 
			string m3WATP = null, 
			int? m3MRET = null, 
			string m3ARVR = null, 
			DateTime? m3ATRD = null, 
			string m3ARVB = null, 
			DateTime? m3REDA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddEO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECT))
				throw new ArgumentNullException(nameof(m3AECT));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3DEPT))
				throw new ArgumentNullException(nameof(m3DEPT));
			if (string.IsNullOrWhiteSpace(m3AECC))
				throw new ArgumentNullException(nameof(m3AECC));
			if (string.IsNullOrWhiteSpace(m3AECL))
				throw new ArgumentNullException(nameof(m3AECL));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECT", m3AECT.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("DEPT", m3DEPT.Trim())
				.WithQueryParameter("AECC", m3AECC.Trim())
				.WithQueryParameter("AECL", m3AECL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AECN))
				request.WithQueryParameter("AECN", m3AECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AECS))
				request.WithQueryParameter("AECS", m3AECS.Trim());
			if (m3ARVD.HasValue)
				request.WithQueryParameter("ARVD", m3ARVD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3AECM.HasValue)
				request.WithQueryParameter("AECM", m3AECM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCHG.HasValue)
				request.WithQueryParameter("PCHG", m3PCHG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AERE.HasValue)
				request.WithQueryParameter("AERE", m3AERE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACMO.HasValue)
				request.WithQueryParameter("ACMO", m3ACMO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGRP))
				request.WithQueryParameter("AGRP", m3AGRP.Trim());
			if (m3APR2.HasValue)
				request.WithQueryParameter("APR2", m3APR2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STNC))
				request.WithQueryParameter("STNC", m3STNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUNC))
				request.WithQueryParameter("FUNC", m3FUNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3AISB))
				request.WithQueryParameter("AISB", m3AISB.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADOB))
				request.WithQueryParameter("ADOB", m3ADOB.Trim());
			if (m3ALPD.HasValue)
				request.WithQueryParameter("ALPD", m3ALPD.Value.ToM3String());
			if (m3ALDS.HasValue)
				request.WithQueryParameter("ALDS", m3ALDS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (m3MRET.HasValue)
				request.WithQueryParameter("MRET", m3MRET.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ARVR))
				request.WithQueryParameter("ARVR", m3ARVR.Trim());
			if (m3ATRD.HasValue)
				request.WithQueryParameter("ATRD", m3ATRD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ARVB))
				request.WithQueryParameter("ARVB", m3ARVB.Trim());
			if (m3REDA.HasValue)
				request.WithQueryParameter("REDA", m3REDA.Value.ToM3String());

			// Execute the request
			var result = await Execute<AddEOResponse>(
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
		/// Name AddEOLine
		/// Description Add Engineering Order Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3ECVE">Revision number (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEOLine(
			string m3AECN, 
			string m3AECR, 
			string m3SUFI, 
			string m3ECVE, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddEOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3ECVE))
				throw new ArgumentNullException(nameof(m3ECVE));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("ECVE", m3ECVE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

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
		/// Name AddModRefComp
		/// Description Add Modification reference component
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3AOPN">Old item number (Required)</param>
		/// <param name="m3MODM">Modification marking</param>
		/// <param name="m3ANPN">New item number</param>
		/// <param name="m3AINS">Instruction</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddModRefComp(
			string m3AECN, 
			string m3AECR, 
			string m3AOPN, 
			string m3MODM = null, 
			string m3ANPN = null, 
			string m3AINS = null, 
			decimal? m3CNQT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddModRefComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));
			if (string.IsNullOrWhiteSpace(m3AOPN))
				throw new ArgumentNullException(nameof(m3AOPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim())
				.WithQueryParameter("AOPN", m3AOPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MODM))
				request.WithQueryParameter("MODM", m3MODM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ANPN))
				request.WithQueryParameter("ANPN", m3ANPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AINS))
				request.WithQueryParameter("AINS", m3AINS.Trim());
			if (m3CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3CNQT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CopyToNewRev
		/// Description Copy Engineering order to new revision
		/// Version Release: 
		/// </summary>
		/// <param name="m3AECN">Engineering order number</param>
		/// <param name="m3AECR">Revision number - engineering order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CopyToNewRev(
			string m3AECN = null, 
			string m3AECR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CopyToNewRev",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AECN))
				request.WithQueryParameter("AECN", m3AECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AECR))
				request.WithQueryParameter("AECR", m3AECR.Trim());

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
		/// Name DeactivateEO
		/// Description Deactivate Engineering order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeactivateEO(
			string m3AECN, 
			string m3AECR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeactivateEO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim());

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
		/// Name DelAffSerialNo
		/// Description Delete Affected Serial Number
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAffSerialNo(
			string m3AECN, 
			string m3AECR, 
			string m3ITNO, 
			string m3BANO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelAffSerialNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim());

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
		/// Name DelEOLine
		/// Description Delete Engineering Order Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3ECVE">Revision number (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelEOLine(
			string m3AECN, 
			string m3AECR, 
			string m3SUFI, 
			string m3ECVE, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelEOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3ECVE))
				throw new ArgumentNullException(nameof(m3ECVE));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("ECVE", m3ECVE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

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
		/// Name DelModRefComp
		/// Description DelModRefComp
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3AOPN">Old item number (Required)</param>
		/// <param name="m3ANPN">New item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelModRefComp(
			string m3AECN, 
			string m3AECR, 
			string m3AOPN, 
			string m3ANPN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelModRefComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));
			if (string.IsNullOrWhiteSpace(m3AOPN))
				throw new ArgumentNullException(nameof(m3AOPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim())
				.WithQueryParameter("AOPN", m3AOPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ANPN))
				request.WithQueryParameter("ANPN", m3ANPN.Trim());

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
		/// Name GetAffSerialNo
		/// Description Get affected serial numbers
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAffSerialNoResponse></returns>
		/// <exception cref="M3Exception<GetAffSerialNoResponse>"></exception>
		public async Task<M3Response<GetAffSerialNoResponse>> GetAffSerialNo(
			string m3AECN, 
			string m3AECR, 
			string m3ITNO, 
			string m3BANO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAffSerialNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<GetAffSerialNoResponse>(
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
		/// Name GetBasic
		/// Description Get Basic data for EO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicResponse></returns>
		/// <exception cref="M3Exception<GetBasicResponse>"></exception>
		public async Task<M3Response<GetBasicResponse>> GetBasic(
			string m3AECN, 
			string m3AECR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim());

			// Execute the request
			var result = await Execute<GetBasicResponse>(
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
		/// Name LstByResp
		/// Description List EO by responsible
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByRespResponse></returns>
		/// <exception cref="M3Exception<LstByRespResponse>"></exception>
		public async Task<M3Response<LstByRespResponse>> LstByResp(
			string m3RESP, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByResp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));

			// Set mandatory parameters
			request
				.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<LstByRespResponse>(
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
		/// Name LstEOLines
		/// Description List Engineering Order Lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEOLinesResponse></returns>
		/// <exception cref="M3Exception<LstEOLinesResponse>"></exception>
		public async Task<M3Response<LstEOLinesResponse>> LstEOLines(
			string m3AECN, 
			string m3AECR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstEOLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim());

			// Execute the request
			var result = await Execute<LstEOLinesResponse>(
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
		/// Name LstModRefComp
		/// Description List Modification reference component
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModRefCompResponse></returns>
		/// <exception cref="M3Exception<LstModRefCompResponse>"></exception>
		public async Task<M3Response<LstModRefCompResponse>> LstModRefComp(
			string m3AECN, 
			string m3AECR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstModRefComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim());

			// Execute the request
			var result = await Execute<LstModRefCompResponse>(
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
		/// Name RtvAffected
		/// Description Retrieve affected serial numbers
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLSD">Planned start date (Required)</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3AECN">Engineering order number</param>
		/// <param name="m3AECR">Revision number - engineering order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvAffectedResponse></returns>
		/// <exception cref="M3Exception<RtvAffectedResponse>"></exception>
		public async Task<M3Response<RtvAffectedResponse>> RtvAffected(
			DateTime m3PLSD, 
			string m3DOID = null, 
			string m3ECVE = null, 
			string m3AECN = null, 
			string m3AECR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RtvAffected",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLSD", m3PLSD.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3AECN))
				request.WithQueryParameter("AECN", m3AECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AECR))
				request.WithQueryParameter("AECR", m3AECR.Trim());

			// Execute the request
			var result = await Execute<RtvAffectedResponse>(
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
		/// Name TransferToProd
		/// Description Transfer Engineering order to production
		/// Version Release: 
		/// </summary>
		/// <param name="m3AECN">Engineering order number</param>
		/// <param name="m3AECR">Revision number - engineering order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TransferToProd(
			string m3AECN = null, 
			string m3AECR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/TransferToProd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AECN))
				request.WithQueryParameter("AECN", m3AECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AECR))
				request.WithQueryParameter("AECR", m3AECR.Trim());

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
		/// Name UpdEO
		/// Description Update Engineering Order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3AECS">Status - engineering order</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3AECM">Mandatory</param>
		/// <param name="m3PCHG">Item number change</param>
		/// <param name="m3AERE">Repetitive</param>
		/// <param name="m3ACMO">Automatic approval of modification</param>
		/// <param name="m3AECC">Engineering order category</param>
		/// <param name="m3AGRP">Engineering order group</param>
		/// <param name="m3AECL">Engineering order class</param>
		/// <param name="m3APR2">Priority</param>
		/// <param name="m3STNC">Standard numbering system</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3FUNC">Function area</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3ALPD">Latest performance date</param>
		/// <param name="m3ALDS">Latest performance date - warehouse</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3MRET">Retrospective</param>
		/// <param name="m3ARVD">Revision date</param>
		/// <param name="m3ARVR">Reason for document revision</param>
		/// <param name="m3ATRD">Date revised</param>
		/// <param name="m3ARVB">Revised by</param>
		/// <param name="m3REDA">Receipt date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdEO(
			string m3AECN, 
			string m3AECR, 
			string m3AECS = null, 
			string m3TX40 = null, 
			string m3RESP = null, 
			string m3DEPT = null, 
			int? m3AECM = null, 
			int? m3PCHG = null, 
			int? m3AERE = null, 
			int? m3ACMO = null, 
			string m3AECC = null, 
			string m3AGRP = null, 
			string m3AECL = null, 
			int? m3APR2 = null, 
			string m3STNC = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3FUNC = null, 
			string m3DOID = null, 
			string m3ECVE = null, 
			DateTime? m3ALPD = null, 
			DateTime? m3ALDS = null, 
			string m3WATP = null, 
			int? m3MRET = null, 
			DateTime? m3ARVD = null, 
			string m3ARVR = null, 
			DateTime? m3ATRD = null, 
			string m3ARVB = null, 
			DateTime? m3REDA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdEO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AECS))
				request.WithQueryParameter("AECS", m3AECS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (m3AECM.HasValue)
				request.WithQueryParameter("AECM", m3AECM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCHG.HasValue)
				request.WithQueryParameter("PCHG", m3PCHG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AERE.HasValue)
				request.WithQueryParameter("AERE", m3AERE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACMO.HasValue)
				request.WithQueryParameter("ACMO", m3ACMO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AECC))
				request.WithQueryParameter("AECC", m3AECC.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRP))
				request.WithQueryParameter("AGRP", m3AGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AECL))
				request.WithQueryParameter("AECL", m3AECL.Trim());
			if (m3APR2.HasValue)
				request.WithQueryParameter("APR2", m3APR2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STNC))
				request.WithQueryParameter("STNC", m3STNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUNC))
				request.WithQueryParameter("FUNC", m3FUNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (m3ALPD.HasValue)
				request.WithQueryParameter("ALPD", m3ALPD.Value.ToM3String());
			if (m3ALDS.HasValue)
				request.WithQueryParameter("ALDS", m3ALDS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (m3MRET.HasValue)
				request.WithQueryParameter("MRET", m3MRET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARVD.HasValue)
				request.WithQueryParameter("ARVD", m3ARVD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ARVR))
				request.WithQueryParameter("ARVR", m3ARVR.Trim());
			if (m3ATRD.HasValue)
				request.WithQueryParameter("ATRD", m3ATRD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ARVB))
				request.WithQueryParameter("ARVB", m3ARVB.Trim());
			if (m3REDA.HasValue)
				request.WithQueryParameter("REDA", m3REDA.Value.ToM3String());

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
		/// Name UpdModRefComp
		/// Description Update Modification reference component
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3AECN">Engineering order number (Required)</param>
		/// <param name="m3AECR">Revision number - engineering order (Required)</param>
		/// <param name="m3AOPN">Old item number (Required)</param>
		/// <param name="m3MODM">Modification marking</param>
		/// <param name="m3ANPN">New item number</param>
		/// <param name="m3AINS">Instruction</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdModRefComp(
			string m3AECN, 
			string m3AECR, 
			string m3AOPN, 
			string m3MODM = null, 
			string m3ANPN = null, 
			string m3AINS = null, 
			decimal? m3CNQT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdModRefComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AECN))
				throw new ArgumentNullException(nameof(m3AECN));
			if (string.IsNullOrWhiteSpace(m3AECR))
				throw new ArgumentNullException(nameof(m3AECR));
			if (string.IsNullOrWhiteSpace(m3AOPN))
				throw new ArgumentNullException(nameof(m3AOPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AECN", m3AECN.Trim())
				.WithQueryParameter("AECR", m3AECR.Trim())
				.WithQueryParameter("AOPN", m3AOPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MODM))
				request.WithQueryParameter("MODM", m3MODM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ANPN))
				request.WithQueryParameter("ANPN", m3ANPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AINS))
				request.WithQueryParameter("AINS", m3AINS.Trim());
			if (m3CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3CNQT.Value.ToString(CultureInfo.CurrentCulture));

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
