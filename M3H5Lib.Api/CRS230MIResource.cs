/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRS230MI;
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
	/// Name: CRS230MI
	/// Component Name: TechDoc
	/// Description: Technical documents
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS230MIResource : M3BaseResourceEndpoint
	{
		public CRS230MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS230MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add a document record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOTY">Document type (Required)</param>
		/// <param name="m3DODE">Name (Required)</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3ADS1">Document subtype</param>
		/// <param name="m3AISB">Document issuer</param>
		/// <param name="m3DNUM">Document number</param>
		/// <param name="m3ADOB">Document object</param>
		/// <param name="m3DOSS">Status - document</param>
		/// <param name="m3DOFM">Document application</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3ECMA">ECO managed</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3ASBJ">Subject</param>
		/// <param name="m3ASB2">Subject</param>
		/// <param name="m3DOME">Document media</param>
		/// <param name="m3FIOF">File location</param>
		/// <param name="m3FUNC">Function area</param>
		/// <param name="m3STNC">Standard numbering system</param>
		/// <param name="m3DGRP">Document group</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3AREG">Responsible engineering department</param>
		/// <param name="m3AISD">Date issued</param>
		/// <param name="m3AEDT">Effectivity date</param>
		/// <param name="m3AED2">Effectivity date</param>
		/// <param name="m3COPY">Number of copies</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ARVS">Revision service</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ACPL">Compliance code</param>
		/// <param name="m3AADA">Engineering order accomplishment date</param>
		/// <param name="m3AMTX">Amendment text</param>
		/// <param name="m3ACPT">Text</param>
		/// <param name="m3ACP2">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3DOTY, 
			string m3DODE, 
			string m3DOID = null, 
			string m3ADS1 = null, 
			string m3AISB = null, 
			string m3DNUM = null, 
			string m3ADOB = null, 
			string m3DOSS = null, 
			string m3DOFM = null, 
			string m3LNCD = null, 
			int? m3ECMA = null, 
			string m3ECVE = null, 
			string m3ASBJ = null, 
			string m3ASB2 = null, 
			string m3DOME = null, 
			string m3FIOF = null, 
			string m3FUNC = null, 
			string m3STNC = null, 
			string m3DGRP = null, 
			string m3RESP = null, 
			string m3DEPT = null, 
			string m3AREG = null, 
			DateTime? m3AISD = null, 
			DateTime? m3AEDT = null, 
			DateTime? m3AED2 = null, 
			int? m3COPY = null, 
			string m3ITNO = null, 
			int? m3ARVS = null, 
			string m3FACI = null, 
			string m3ACPL = null, 
			DateTime? m3AADA = null, 
			string m3AMTX = null, 
			string m3ACPT = null, 
			string m3ACP2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOTY))
				throw new ArgumentNullException(nameof(m3DOTY));
			if (string.IsNullOrWhiteSpace(m3DODE))
				throw new ArgumentNullException(nameof(m3DODE));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOTY", m3DOTY.Trim())
				.WithQueryParameter("DODE", m3DODE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADS1))
				request.WithQueryParameter("ADS1", m3ADS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AISB))
				request.WithQueryParameter("AISB", m3AISB.Trim());
			if (!string.IsNullOrWhiteSpace(m3DNUM))
				request.WithQueryParameter("DNUM", m3DNUM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADOB))
				request.WithQueryParameter("ADOB", m3ADOB.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOSS))
				request.WithQueryParameter("DOSS", m3DOSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOFM))
				request.WithQueryParameter("DOFM", m3DOFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3ECMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASBJ))
				request.WithQueryParameter("ASBJ", m3ASBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASB2))
				request.WithQueryParameter("ASB2", m3ASB2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOME))
				request.WithQueryParameter("DOME", m3DOME.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIOF))
				request.WithQueryParameter("FIOF", m3FIOF.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUNC))
				request.WithQueryParameter("FUNC", m3FUNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3STNC))
				request.WithQueryParameter("STNC", m3STNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3DGRP))
				request.WithQueryParameter("DGRP", m3DGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AREG))
				request.WithQueryParameter("AREG", m3AREG.Trim());
			if (m3AISD.HasValue)
				request.WithQueryParameter("AISD", m3AISD.Value.ToM3String());
			if (m3AEDT.HasValue)
				request.WithQueryParameter("AEDT", m3AEDT.Value.ToM3String());
			if (m3AED2.HasValue)
				request.WithQueryParameter("AED2", m3AED2.Value.ToM3String());
			if (m3COPY.HasValue)
				request.WithQueryParameter("COPY", m3COPY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3ARVS.HasValue)
				request.WithQueryParameter("ARVS", m3ARVS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACPL))
				request.WithQueryParameter("ACPL", m3ACPL.Trim());
			if (m3AADA.HasValue)
				request.WithQueryParameter("AADA", m3AADA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3AMTX))
				request.WithQueryParameter("AMTX", m3AMTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACPT))
				request.WithQueryParameter("ACPT", m3ACPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACP2))
				request.WithQueryParameter("ACP2", m3ACP2.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name AddDocEff1
		/// Description Add Document Effectivity Level 1
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3DVA1">Value 1 (Required)</param>
		/// <param name="m3DNOT">Not valid</param>
		/// <param name="m3DRAN">Condition</param>
		/// <param name="m3DVA2">Value 2</param>
		/// <param name="m3DNLV">Number of levels</param>
		/// <param name="m3DNRB">Number of right brackets</param>
		/// <param name="m3DNLB">Number of left brackets</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDocEff1Response></returns>
		/// <exception cref="M3Exception<AddDocEff1Response>"></exception>
		public async Task<M3Response<AddDocEff1Response>> AddDocEff1(
			string m3DOID, 
			string m3FLDI, 
			string m3DVA1, 
			string m3DNOT = null, 
			string m3DRAN = null, 
			string m3DVA2 = null, 
			int? m3DNLV = null, 
			int? m3DNRB = null, 
			int? m3DNLB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDocEff1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3DVA1))
				throw new ArgumentNullException(nameof(m3DVA1));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("DVA1", m3DVA1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DNOT))
				request.WithQueryParameter("DNOT", m3DNOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DRAN))
				request.WithQueryParameter("DRAN", m3DRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DVA2))
				request.WithQueryParameter("DVA2", m3DVA2.Trim());
			if (m3DNLV.HasValue)
				request.WithQueryParameter("DNLV", m3DNLV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DNRB.HasValue)
				request.WithQueryParameter("DNRB", m3DNRB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DNLB.HasValue)
				request.WithQueryParameter("DNLB", m3DNLB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddDocEff1Response>(
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
		/// Name AddDocEff2
		/// Description Add Document Effectivity Level 2
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="m3DSQ1">Document effectivity 1 (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3DVA1">Value 1 (Required)</param>
		/// <param name="m3DNOT">Not valid</param>
		/// <param name="m3DRAN">Condition</param>
		/// <param name="m3DVA2">Value 2</param>
		/// <param name="m3DNLV">Number of levels</param>
		/// <param name="m3DNRB">Number of right brackets</param>
		/// <param name="m3DNLB">Number of left brackets</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDocEff2Response></returns>
		/// <exception cref="M3Exception<AddDocEff2Response>"></exception>
		public async Task<M3Response<AddDocEff2Response>> AddDocEff2(
			string m3DOID, 
			int m3DSQ1, 
			string m3FLDI, 
			string m3DVA1, 
			string m3DNOT = null, 
			string m3DRAN = null, 
			string m3DVA2 = null, 
			int? m3DNLV = null, 
			int? m3DNRB = null, 
			int? m3DNLB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDocEff2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3DVA1))
				throw new ArgumentNullException(nameof(m3DVA1));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim())
				.WithQueryParameter("DSQ1", m3DSQ1.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("DVA1", m3DVA1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DNOT))
				request.WithQueryParameter("DNOT", m3DNOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DRAN))
				request.WithQueryParameter("DRAN", m3DRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DVA2))
				request.WithQueryParameter("DVA2", m3DVA2.Trim());
			if (m3DNLV.HasValue)
				request.WithQueryParameter("DNLV", m3DNLV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DNRB.HasValue)
				request.WithQueryParameter("DNRB", m3DNRB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DNLB.HasValue)
				request.WithQueryParameter("DNLB", m3DNLB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddDocEff2Response>(
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
		/// Name AddDocEff3
		/// Description Add Document Effectivity Level 3
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="m3DSQ1">Document effectivity 1 (Required)</param>
		/// <param name="m3DSQ2">Document effectivity 2 (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3DVA1">Value 1 (Required)</param>
		/// <param name="m3DNOT">Not valid</param>
		/// <param name="m3DRAN">Condition</param>
		/// <param name="m3DVA2">Value 2</param>
		/// <param name="m3DNLV">Number of levels</param>
		/// <param name="m3DNRB">Number of right brackets</param>
		/// <param name="m3DNLB">Number of left brackets</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDocEff3Response></returns>
		/// <exception cref="M3Exception<AddDocEff3Response>"></exception>
		public async Task<M3Response<AddDocEff3Response>> AddDocEff3(
			string m3DOID, 
			int m3DSQ1, 
			int m3DSQ2, 
			string m3FLDI, 
			string m3DVA1, 
			string m3DNOT = null, 
			string m3DRAN = null, 
			string m3DVA2 = null, 
			int? m3DNLV = null, 
			int? m3DNRB = null, 
			int? m3DNLB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDocEff3",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3DVA1))
				throw new ArgumentNullException(nameof(m3DVA1));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim())
				.WithQueryParameter("DSQ1", m3DSQ1.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DSQ2", m3DSQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("DVA1", m3DVA1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DNOT))
				request.WithQueryParameter("DNOT", m3DNOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DRAN))
				request.WithQueryParameter("DRAN", m3DRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DVA2))
				request.WithQueryParameter("DVA2", m3DVA2.Trim());
			if (m3DNLV.HasValue)
				request.WithQueryParameter("DNLV", m3DNLV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DNRB.HasValue)
				request.WithQueryParameter("DNRB", m3DNRB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DNLB.HasValue)
				request.WithQueryParameter("DNLB", m3DNLB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddDocEff3Response>(
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
		/// Name AddDocStructure
		/// Description AddDocStructure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="m3SUID">Subdocument (Required)</param>
		/// <param name="m3FECV">From revision number</param>
		/// <param name="m3TECV">To revision number</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDocStructure(
			string m3DOID, 
			string m3SUID, 
			string m3FECV = null, 
			string m3TECV = null, 
			string m3REMK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDocStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));
			if (string.IsNullOrWhiteSpace(m3SUID))
				throw new ArgumentNullException(nameof(m3SUID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim())
				.WithQueryParameter("SUID", m3SUID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FECV))
				request.WithQueryParameter("FECV", m3FECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECV))
				request.WithQueryParameter("TECV", m3TECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());

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
		/// Name ChgDocStructure
		/// Description ChgDocStructure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="m3SUID">Subdocument (Required)</param>
		/// <param name="m3FECV">From revision number</param>
		/// <param name="m3TECV">To revision number</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgDocStructure(
			string m3DOID, 
			string m3SUID, 
			string m3FECV = null, 
			string m3TECV = null, 
			string m3REMK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgDocStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));
			if (string.IsNullOrWhiteSpace(m3SUID))
				throw new ArgumentNullException(nameof(m3SUID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim())
				.WithQueryParameter("SUID", m3SUID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FECV))
				request.WithQueryParameter("FECV", m3FECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECV))
				request.WithQueryParameter("TECV", m3TECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());

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
		/// Name Delete
		/// Description Delete document record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="m3DELT">Edit related info</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3DOID, 
			int? m3DELT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DELT.HasValue)
				request.WithQueryParameter("DELT", m3DELT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltAllDocEffect
		/// Description Delete all document effectivity records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAllDocEffect(
			string m3DOID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAllDocEffect",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim());

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
		/// Name DltDocEffect
		/// Description Delete document effectivity records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="m3DSQ1">Document effectivity 1</param>
		/// <param name="m3DSQ2">Document effectivity 2</param>
		/// <param name="m3DSQ3">Document effectivity 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltDocEffect(
			string m3DOID, 
			int? m3DSQ1 = null, 
			int? m3DSQ2 = null, 
			int? m3DSQ3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltDocEffect",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DSQ1.HasValue)
				request.WithQueryParameter("DSQ1", m3DSQ1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSQ2.HasValue)
				request.WithQueryParameter("DSQ2", m3DSQ2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSQ3.HasValue)
				request.WithQueryParameter("DSQ3", m3DSQ3.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltDocStructure
		/// Description DltDocStructure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="m3SUID">Subdocument (Required)</param>
		/// <param name="m3FECV">From revision number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltDocStructure(
			string m3DOID, 
			string m3SUID, 
			string m3FECV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltDocStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));
			if (string.IsNullOrWhiteSpace(m3SUID))
				throw new ArgumentNullException(nameof(m3SUID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim())
				.WithQueryParameter("SUID", m3SUID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FECV))
				request.WithQueryParameter("FECV", m3FECV.Trim());

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
		/// Name Get
		/// Description Get document data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3DOID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name GetDocStructure
		/// Description GetDocStructure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="m3SUID">Subdocument (Required)</param>
		/// <param name="m3FECV">From revision number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDocStructureResponse></returns>
		/// <exception cref="M3Exception<GetDocStructureResponse>"></exception>
		public async Task<M3Response<GetDocStructureResponse>> GetDocStructure(
			string m3DOID, 
			string m3SUID, 
			string m3FECV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDocStructure",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));
			if (string.IsNullOrWhiteSpace(m3SUID))
				throw new ArgumentNullException(nameof(m3SUID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim())
				.WithQueryParameter("SUID", m3SUID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FECV))
				request.WithQueryParameter("FECV", m3FECV.Trim());

			// Execute the request
			var result = await Execute<GetDocStructureResponse>(
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
		/// Name GetDocType
		/// Description Retrieve information about a certain document type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOTY">Document type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDocTypeResponse></returns>
		/// <exception cref="M3Exception<GetDocTypeResponse>"></exception>
		public async Task<M3Response<GetDocTypeResponse>> GetDocType(
			string m3DOTY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDocType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOTY))
				throw new ArgumentNullException(nameof(m3DOTY));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOTY", m3DOTY.Trim());

			// Execute the request
			var result = await Execute<GetDocTypeResponse>(
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
		/// Name List
		/// Description List documents
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3DOID = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name LstByIssuer
		/// Description List documents in Issuer order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AISB">Document issuer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByIssuerResponse></returns>
		/// <exception cref="M3Exception<LstByIssuerResponse>"></exception>
		public async Task<M3Response<LstByIssuerResponse>> LstByIssuer(
			string m3AISB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByIssuer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AISB))
				request.WithQueryParameter("AISB", m3AISB.Trim());

			// Execute the request
			var result = await Execute<LstByIssuerResponse>(
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
		/// Name LstByType
		/// Description List documents in document type order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOTY">Document type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByTypeResponse></returns>
		/// <exception cref="M3Exception<LstByTypeResponse>"></exception>
		public async Task<M3Response<LstByTypeResponse>> LstByType(
			string m3DOTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DOTY))
				request.WithQueryParameter("DOTY", m3DOTY.Trim());

			// Execute the request
			var result = await Execute<LstByTypeResponse>(
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
		/// Name LstDocEffect
		/// Description List all document effectivity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDocEffectResponse></returns>
		/// <exception cref="M3Exception<LstDocEffectResponse>"></exception>
		public async Task<M3Response<LstDocEffectResponse>> LstDocEffect(
			string m3DOID = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDocEffect",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDocEffectResponse>(
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
		/// Name LstDocStructure
		/// Description LstDocStructure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3SUID">Subdocument</param>
		/// <param name="m3FECV">From revision number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDocStructureResponse></returns>
		/// <exception cref="M3Exception<LstDocStructureResponse>"></exception>
		public async Task<M3Response<LstDocStructureResponse>> LstDocStructure(
			string m3DOID = null, 
			string m3SUID = null, 
			string m3FECV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDocStructure",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUID))
				request.WithQueryParameter("SUID", m3SUID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FECV))
				request.WithQueryParameter("FECV", m3FECV.Trim());

			// Execute the request
			var result = await Execute<LstDocStructureResponse>(
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
		/// Name LstDocTypes
		/// Description List valid document types
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOTY">Document type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDocTypesResponse></returns>
		/// <exception cref="M3Exception<LstDocTypesResponse>"></exception>
		public async Task<M3Response<LstDocTypesResponse>> LstDocTypes(
			string m3DOTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDocTypes",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DOTY))
				request.WithQueryParameter("DOTY", m3DOTY.Trim());

			// Execute the request
			var result = await Execute<LstDocTypesResponse>(
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
		/// Name Update
		/// Description Change info on specific document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DOID">Document identity (Required)</param>
		/// <param name="m3DOTY">Document type</param>
		/// <param name="m3DODE">Name</param>
		/// <param name="m3ADS1">Document subtype</param>
		/// <param name="m3AISB">Document issuer</param>
		/// <param name="m3DNUM">Document number</param>
		/// <param name="m3ADOB">Document object</param>
		/// <param name="m3DOSS">Status - document</param>
		/// <param name="m3DOFM">Document application</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3ECMA">ECO managed</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3ASBJ">Subject</param>
		/// <param name="m3ASB2">Subject</param>
		/// <param name="m3DOME">Document media</param>
		/// <param name="m3FIOF">File location</param>
		/// <param name="m3FUNC">Function area</param>
		/// <param name="m3STNC">Standard numbering system</param>
		/// <param name="m3DGRP">Document group</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3AREG">Responsible engineering department</param>
		/// <param name="m3AISD">Date issued</param>
		/// <param name="m3AEDT">Effectivity date</param>
		/// <param name="m3AED2">Effectivity date</param>
		/// <param name="m3COPY">Number of copies</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ARVS">Revision service</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ACPL">Compliance code</param>
		/// <param name="m3AADA">Engineering order accomplishment date</param>
		/// <param name="m3AMTX">Amendment text</param>
		/// <param name="m3ACPT">Text</param>
		/// <param name="m3ACP2">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3DOID, 
			string m3DOTY = null, 
			string m3DODE = null, 
			string m3ADS1 = null, 
			string m3AISB = null, 
			string m3DNUM = null, 
			string m3ADOB = null, 
			string m3DOSS = null, 
			string m3DOFM = null, 
			string m3LNCD = null, 
			int? m3ECMA = null, 
			string m3ECVE = null, 
			string m3ASBJ = null, 
			string m3ASB2 = null, 
			string m3DOME = null, 
			string m3FIOF = null, 
			string m3FUNC = null, 
			string m3STNC = null, 
			string m3DGRP = null, 
			string m3RESP = null, 
			string m3DEPT = null, 
			string m3AREG = null, 
			DateTime? m3AISD = null, 
			DateTime? m3AEDT = null, 
			DateTime? m3AED2 = null, 
			int? m3COPY = null, 
			string m3ITNO = null, 
			int? m3ARVS = null, 
			string m3FACI = null, 
			string m3ACPL = null, 
			DateTime? m3AADA = null, 
			string m3AMTX = null, 
			string m3ACPT = null, 
			string m3ACP2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DOID))
				throw new ArgumentNullException(nameof(m3DOID));

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3DOID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DOTY))
				request.WithQueryParameter("DOTY", m3DOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3DODE))
				request.WithQueryParameter("DODE", m3DODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADS1))
				request.WithQueryParameter("ADS1", m3ADS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AISB))
				request.WithQueryParameter("AISB", m3AISB.Trim());
			if (!string.IsNullOrWhiteSpace(m3DNUM))
				request.WithQueryParameter("DNUM", m3DNUM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADOB))
				request.WithQueryParameter("ADOB", m3ADOB.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOSS))
				request.WithQueryParameter("DOSS", m3DOSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOFM))
				request.WithQueryParameter("DOFM", m3DOFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3ECMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASBJ))
				request.WithQueryParameter("ASBJ", m3ASBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASB2))
				request.WithQueryParameter("ASB2", m3ASB2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOME))
				request.WithQueryParameter("DOME", m3DOME.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIOF))
				request.WithQueryParameter("FIOF", m3FIOF.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUNC))
				request.WithQueryParameter("FUNC", m3FUNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3STNC))
				request.WithQueryParameter("STNC", m3STNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3DGRP))
				request.WithQueryParameter("DGRP", m3DGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AREG))
				request.WithQueryParameter("AREG", m3AREG.Trim());
			if (m3AISD.HasValue)
				request.WithQueryParameter("AISD", m3AISD.Value.ToM3String());
			if (m3AEDT.HasValue)
				request.WithQueryParameter("AEDT", m3AEDT.Value.ToM3String());
			if (m3AED2.HasValue)
				request.WithQueryParameter("AED2", m3AED2.Value.ToM3String());
			if (m3COPY.HasValue)
				request.WithQueryParameter("COPY", m3COPY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3ARVS.HasValue)
				request.WithQueryParameter("ARVS", m3ARVS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACPL))
				request.WithQueryParameter("ACPL", m3ACPL.Trim());
			if (m3AADA.HasValue)
				request.WithQueryParameter("AADA", m3AADA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3AMTX))
				request.WithQueryParameter("AMTX", m3AMTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACPT))
				request.WithQueryParameter("ACPT", m3ACPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACP2))
				request.WithQueryParameter("ACP2", m3ACP2.Trim());

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
