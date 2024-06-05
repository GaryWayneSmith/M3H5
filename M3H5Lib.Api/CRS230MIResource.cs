/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_DOTY">Document type (Required)</param>
		/// <param name="m3_DODE">Name (Required)</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_ADS1">Document subtype</param>
		/// <param name="m3_AISB">Document issuer</param>
		/// <param name="m3_DNUM">Document number</param>
		/// <param name="m3_ADOB">Document object</param>
		/// <param name="m3_DOSS">Status - document</param>
		/// <param name="m3_DOFM">Document application</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_ECMA">ECO managed</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_ASBJ">Subject</param>
		/// <param name="m3_ASB2">Subject</param>
		/// <param name="m3_DOME">Document media</param>
		/// <param name="m3_FIOF">File location</param>
		/// <param name="m3_FUNC">Function area</param>
		/// <param name="m3_STNC">Standard numbering system</param>
		/// <param name="m3_DGRP">Document group</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_AREG">Responsible engineering department</param>
		/// <param name="m3_AISD">Date issued</param>
		/// <param name="m3_AEDT">Effectivity date</param>
		/// <param name="m3_AED2">Effectivity date</param>
		/// <param name="m3_COPY">Number of copies</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ARVS">Revision service</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ACPL">Compliance code</param>
		/// <param name="m3_AADA">Engineering order accomplishment date</param>
		/// <param name="m3_AMTX">Amendment text</param>
		/// <param name="m3_ACPT">Text</param>
		/// <param name="m3_ACP2">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3_DOTY, 
			string m3_DODE, 
			string m3_DOID = null, 
			string m3_ADS1 = null, 
			string m3_AISB = null, 
			string m3_DNUM = null, 
			string m3_ADOB = null, 
			string m3_DOSS = null, 
			string m3_DOFM = null, 
			string m3_LNCD = null, 
			int? m3_ECMA = null, 
			string m3_ECVE = null, 
			string m3_ASBJ = null, 
			string m3_ASB2 = null, 
			string m3_DOME = null, 
			string m3_FIOF = null, 
			string m3_FUNC = null, 
			string m3_STNC = null, 
			string m3_DGRP = null, 
			string m3_RESP = null, 
			string m3_DEPT = null, 
			string m3_AREG = null, 
			DateTime? m3_AISD = null, 
			DateTime? m3_AEDT = null, 
			DateTime? m3_AED2 = null, 
			int? m3_COPY = null, 
			string m3_ITNO = null, 
			int? m3_ARVS = null, 
			string m3_FACI = null, 
			string m3_ACPL = null, 
			DateTime? m3_AADA = null, 
			string m3_AMTX = null, 
			string m3_ACPT = null, 
			string m3_ACP2 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DOTY))
				throw new ArgumentNullException("m3_DOTY");
			if (string.IsNullOrWhiteSpace(m3_DODE))
				throw new ArgumentNullException("m3_DODE");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOTY", m3_DOTY.Trim())
				.WithQueryParameter("DODE", m3_DODE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADS1))
				request.WithQueryParameter("ADS1", m3_ADS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AISB))
				request.WithQueryParameter("AISB", m3_AISB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DNUM))
				request.WithQueryParameter("DNUM", m3_DNUM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADOB))
				request.WithQueryParameter("ADOB", m3_ADOB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOSS))
				request.WithQueryParameter("DOSS", m3_DOSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOFM))
				request.WithQueryParameter("DOFM", m3_DOFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3_ECMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASBJ))
				request.WithQueryParameter("ASBJ", m3_ASBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASB2))
				request.WithQueryParameter("ASB2", m3_ASB2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOME))
				request.WithQueryParameter("DOME", m3_DOME.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIOF))
				request.WithQueryParameter("FIOF", m3_FIOF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUNC))
				request.WithQueryParameter("FUNC", m3_FUNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STNC))
				request.WithQueryParameter("STNC", m3_STNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DGRP))
				request.WithQueryParameter("DGRP", m3_DGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AREG))
				request.WithQueryParameter("AREG", m3_AREG.Trim());
			if (m3_AISD.HasValue)
				request.WithQueryParameter("AISD", m3_AISD.Value.ToM3String());
			if (m3_AEDT.HasValue)
				request.WithQueryParameter("AEDT", m3_AEDT.Value.ToM3String());
			if (m3_AED2.HasValue)
				request.WithQueryParameter("AED2", m3_AED2.Value.ToM3String());
			if (m3_COPY.HasValue)
				request.WithQueryParameter("COPY", m3_COPY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_ARVS.HasValue)
				request.WithQueryParameter("ARVS", m3_ARVS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACPL))
				request.WithQueryParameter("ACPL", m3_ACPL.Trim());
			if (m3_AADA.HasValue)
				request.WithQueryParameter("AADA", m3_AADA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_AMTX))
				request.WithQueryParameter("AMTX", m3_AMTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACPT))
				request.WithQueryParameter("ACPT", m3_ACPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACP2))
				request.WithQueryParameter("ACP2", m3_ACP2.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name AddDocEff1
		/// Description Add Document Effectivity Level 1
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_DVA1">Value 1 (Required)</param>
		/// <param name="m3_DNOT">Not valid</param>
		/// <param name="m3_DRAN">Condition</param>
		/// <param name="m3_DVA2">Value 2</param>
		/// <param name="m3_DNLV">Number of levels</param>
		/// <param name="m3_DNRB">Number of right brackets</param>
		/// <param name="m3_DNLB">Number of left brackets</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDocEff1Response></returns>
		/// <exception cref="M3Exception<AddDocEff1Response>"></exception>
		public async Task<M3Response<AddDocEff1Response>> AddDocEff1(
			string m3_DOID, 
			string m3_FLDI, 
			string m3_DVA1, 
			string m3_DNOT = null, 
			string m3_DRAN = null, 
			string m3_DVA2 = null, 
			int? m3_DNLV = null, 
			int? m3_DNRB = null, 
			int? m3_DNLB = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_DVA1))
				throw new ArgumentNullException("m3_DVA1");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("DVA1", m3_DVA1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DNOT))
				request.WithQueryParameter("DNOT", m3_DNOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DRAN))
				request.WithQueryParameter("DRAN", m3_DRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DVA2))
				request.WithQueryParameter("DVA2", m3_DVA2.Trim());
			if (m3_DNLV.HasValue)
				request.WithQueryParameter("DNLV", m3_DNLV.Value.ToString());
			if (m3_DNRB.HasValue)
				request.WithQueryParameter("DNRB", m3_DNRB.Value.ToString());
			if (m3_DNLB.HasValue)
				request.WithQueryParameter("DNLB", m3_DNLB.Value.ToString());

			// Execute the request
			var result = await Execute<AddDocEff1Response>(
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
		/// Name AddDocEff2
		/// Description Add Document Effectivity Level 2
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="m3_DSQ1">Document effectivity 1 (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_DVA1">Value 1 (Required)</param>
		/// <param name="m3_DNOT">Not valid</param>
		/// <param name="m3_DRAN">Condition</param>
		/// <param name="m3_DVA2">Value 2</param>
		/// <param name="m3_DNLV">Number of levels</param>
		/// <param name="m3_DNRB">Number of right brackets</param>
		/// <param name="m3_DNLB">Number of left brackets</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDocEff2Response></returns>
		/// <exception cref="M3Exception<AddDocEff2Response>"></exception>
		public async Task<M3Response<AddDocEff2Response>> AddDocEff2(
			string m3_DOID, 
			int m3_DSQ1, 
			string m3_FLDI, 
			string m3_DVA1, 
			string m3_DNOT = null, 
			string m3_DRAN = null, 
			string m3_DVA2 = null, 
			int? m3_DNLV = null, 
			int? m3_DNRB = null, 
			int? m3_DNLB = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_DVA1))
				throw new ArgumentNullException("m3_DVA1");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim())
				.WithQueryParameter("DSQ1", m3_DSQ1.ToString())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("DVA1", m3_DVA1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DNOT))
				request.WithQueryParameter("DNOT", m3_DNOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DRAN))
				request.WithQueryParameter("DRAN", m3_DRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DVA2))
				request.WithQueryParameter("DVA2", m3_DVA2.Trim());
			if (m3_DNLV.HasValue)
				request.WithQueryParameter("DNLV", m3_DNLV.Value.ToString());
			if (m3_DNRB.HasValue)
				request.WithQueryParameter("DNRB", m3_DNRB.Value.ToString());
			if (m3_DNLB.HasValue)
				request.WithQueryParameter("DNLB", m3_DNLB.Value.ToString());

			// Execute the request
			var result = await Execute<AddDocEff2Response>(
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
		/// Name AddDocEff3
		/// Description Add Document Effectivity Level 3
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="m3_DSQ1">Document effectivity 1 (Required)</param>
		/// <param name="m3_DSQ2">Document effectivity 2 (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_DVA1">Value 1 (Required)</param>
		/// <param name="m3_DNOT">Not valid</param>
		/// <param name="m3_DRAN">Condition</param>
		/// <param name="m3_DVA2">Value 2</param>
		/// <param name="m3_DNLV">Number of levels</param>
		/// <param name="m3_DNRB">Number of right brackets</param>
		/// <param name="m3_DNLB">Number of left brackets</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDocEff3Response></returns>
		/// <exception cref="M3Exception<AddDocEff3Response>"></exception>
		public async Task<M3Response<AddDocEff3Response>> AddDocEff3(
			string m3_DOID, 
			int m3_DSQ1, 
			int m3_DSQ2, 
			string m3_FLDI, 
			string m3_DVA1, 
			string m3_DNOT = null, 
			string m3_DRAN = null, 
			string m3_DVA2 = null, 
			int? m3_DNLV = null, 
			int? m3_DNRB = null, 
			int? m3_DNLB = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_DVA1))
				throw new ArgumentNullException("m3_DVA1");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim())
				.WithQueryParameter("DSQ1", m3_DSQ1.ToString())
				.WithQueryParameter("DSQ2", m3_DSQ2.ToString())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("DVA1", m3_DVA1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DNOT))
				request.WithQueryParameter("DNOT", m3_DNOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DRAN))
				request.WithQueryParameter("DRAN", m3_DRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DVA2))
				request.WithQueryParameter("DVA2", m3_DVA2.Trim());
			if (m3_DNLV.HasValue)
				request.WithQueryParameter("DNLV", m3_DNLV.Value.ToString());
			if (m3_DNRB.HasValue)
				request.WithQueryParameter("DNRB", m3_DNRB.Value.ToString());
			if (m3_DNLB.HasValue)
				request.WithQueryParameter("DNLB", m3_DNLB.Value.ToString());

			// Execute the request
			var result = await Execute<AddDocEff3Response>(
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
		/// Name AddDocStructure
		/// Description AddDocStructure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="m3_SUID">Subdocument (Required)</param>
		/// <param name="m3_FECV">From revision number</param>
		/// <param name="m3_TECV">To revision number</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDocStructure(
			string m3_DOID, 
			string m3_SUID, 
			string m3_FECV = null, 
			string m3_TECV = null, 
			string m3_REMK = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");
			if (string.IsNullOrWhiteSpace(m3_SUID))
				throw new ArgumentNullException("m3_SUID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim())
				.WithQueryParameter("SUID", m3_SUID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FECV))
				request.WithQueryParameter("FECV", m3_FECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECV))
				request.WithQueryParameter("TECV", m3_TECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());

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
		/// Name ChgDocStructure
		/// Description ChgDocStructure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="m3_SUID">Subdocument (Required)</param>
		/// <param name="m3_FECV">From revision number</param>
		/// <param name="m3_TECV">To revision number</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgDocStructure(
			string m3_DOID, 
			string m3_SUID, 
			string m3_FECV = null, 
			string m3_TECV = null, 
			string m3_REMK = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");
			if (string.IsNullOrWhiteSpace(m3_SUID))
				throw new ArgumentNullException("m3_SUID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim())
				.WithQueryParameter("SUID", m3_SUID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FECV))
				request.WithQueryParameter("FECV", m3_FECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECV))
				request.WithQueryParameter("TECV", m3_TECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());

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
		/// Name Delete
		/// Description Delete document record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="m3_DELT">Edit related info</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_DOID, 
			int? m3_DELT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DELT.HasValue)
				request.WithQueryParameter("DELT", m3_DELT.Value.ToString());

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
		/// Name DltAllDocEffect
		/// Description Delete all document effectivity records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAllDocEffect(
			string m3_DOID, 
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
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim());

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
		/// Name DltDocEffect
		/// Description Delete document effectivity records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="m3_DSQ1">Document effectivity 1</param>
		/// <param name="m3_DSQ2">Document effectivity 2</param>
		/// <param name="m3_DSQ3">Document effectivity 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltDocEffect(
			string m3_DOID, 
			int? m3_DSQ1 = null, 
			int? m3_DSQ2 = null, 
			int? m3_DSQ3 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DSQ1.HasValue)
				request.WithQueryParameter("DSQ1", m3_DSQ1.Value.ToString());
			if (m3_DSQ2.HasValue)
				request.WithQueryParameter("DSQ2", m3_DSQ2.Value.ToString());
			if (m3_DSQ3.HasValue)
				request.WithQueryParameter("DSQ3", m3_DSQ3.Value.ToString());

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
		/// Name DltDocStructure
		/// Description DltDocStructure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="m3_SUID">Subdocument (Required)</param>
		/// <param name="m3_FECV">From revision number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltDocStructure(
			string m3_DOID, 
			string m3_SUID, 
			string m3_FECV = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");
			if (string.IsNullOrWhiteSpace(m3_SUID))
				throw new ArgumentNullException("m3_SUID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim())
				.WithQueryParameter("SUID", m3_SUID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FECV))
				request.WithQueryParameter("FECV", m3_FECV.Trim());

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
		/// Name Get
		/// Description Get document data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_DOID, 
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
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name GetDocStructure
		/// Description GetDocStructure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="m3_SUID">Subdocument (Required)</param>
		/// <param name="m3_FECV">From revision number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDocStructureResponse></returns>
		/// <exception cref="M3Exception<GetDocStructureResponse>"></exception>
		public async Task<M3Response<GetDocStructureResponse>> GetDocStructure(
			string m3_DOID, 
			string m3_SUID, 
			string m3_FECV = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");
			if (string.IsNullOrWhiteSpace(m3_SUID))
				throw new ArgumentNullException("m3_SUID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim())
				.WithQueryParameter("SUID", m3_SUID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FECV))
				request.WithQueryParameter("FECV", m3_FECV.Trim());

			// Execute the request
			var result = await Execute<GetDocStructureResponse>(
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
		/// Name GetDocType
		/// Description Retrieve information about a certain document type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOTY">Document type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDocTypeResponse></returns>
		/// <exception cref="M3Exception<GetDocTypeResponse>"></exception>
		public async Task<M3Response<GetDocTypeResponse>> GetDocType(
			string m3_DOTY, 
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
			if (string.IsNullOrWhiteSpace(m3_DOTY))
				throw new ArgumentNullException("m3_DOTY");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOTY", m3_DOTY.Trim());

			// Execute the request
			var result = await Execute<GetDocTypeResponse>(
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
		/// Name List
		/// Description List documents
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_DOID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name LstByIssuer
		/// Description List documents in Issuer order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AISB">Document issuer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByIssuerResponse></returns>
		/// <exception cref="M3Exception<LstByIssuerResponse>"></exception>
		public async Task<M3Response<LstByIssuerResponse>> LstByIssuer(
			string m3_AISB = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_AISB))
				request.WithQueryParameter("AISB", m3_AISB.Trim());

			// Execute the request
			var result = await Execute<LstByIssuerResponse>(
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
		/// Name LstByType
		/// Description List documents in document type order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOTY">Document type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByTypeResponse></returns>
		/// <exception cref="M3Exception<LstByTypeResponse>"></exception>
		public async Task<M3Response<LstByTypeResponse>> LstByType(
			string m3_DOTY = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_DOTY))
				request.WithQueryParameter("DOTY", m3_DOTY.Trim());

			// Execute the request
			var result = await Execute<LstByTypeResponse>(
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
		/// Name LstDocEffect
		/// Description List all document effectivity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDocEffectResponse></returns>
		/// <exception cref="M3Exception<LstDocEffectResponse>"></exception>
		public async Task<M3Response<LstDocEffectResponse>> LstDocEffect(
			string m3_DOID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDocEffect",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstDocEffectResponse>(
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
		/// Name LstDocStructure
		/// Description LstDocStructure
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_SUID">Subdocument</param>
		/// <param name="m3_FECV">From revision number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDocStructureResponse></returns>
		/// <exception cref="M3Exception<LstDocStructureResponse>"></exception>
		public async Task<M3Response<LstDocStructureResponse>> LstDocStructure(
			string m3_DOID = null, 
			string m3_SUID = null, 
			string m3_FECV = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUID))
				request.WithQueryParameter("SUID", m3_SUID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FECV))
				request.WithQueryParameter("FECV", m3_FECV.Trim());

			// Execute the request
			var result = await Execute<LstDocStructureResponse>(
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
		/// Name LstDocTypes
		/// Description List valid document types
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOTY">Document type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDocTypesResponse></returns>
		/// <exception cref="M3Exception<LstDocTypesResponse>"></exception>
		public async Task<M3Response<LstDocTypesResponse>> LstDocTypes(
			string m3_DOTY = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_DOTY))
				request.WithQueryParameter("DOTY", m3_DOTY.Trim());

			// Execute the request
			var result = await Execute<LstDocTypesResponse>(
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
		/// Name Update
		/// Description Change info on specific document
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DOID">Document identity (Required)</param>
		/// <param name="m3_DOTY">Document type</param>
		/// <param name="m3_DODE">Name</param>
		/// <param name="m3_ADS1">Document subtype</param>
		/// <param name="m3_AISB">Document issuer</param>
		/// <param name="m3_DNUM">Document number</param>
		/// <param name="m3_ADOB">Document object</param>
		/// <param name="m3_DOSS">Status - document</param>
		/// <param name="m3_DOFM">Document application</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_ECMA">ECO managed</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_ASBJ">Subject</param>
		/// <param name="m3_ASB2">Subject</param>
		/// <param name="m3_DOME">Document media</param>
		/// <param name="m3_FIOF">File location</param>
		/// <param name="m3_FUNC">Function area</param>
		/// <param name="m3_STNC">Standard numbering system</param>
		/// <param name="m3_DGRP">Document group</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_AREG">Responsible engineering department</param>
		/// <param name="m3_AISD">Date issued</param>
		/// <param name="m3_AEDT">Effectivity date</param>
		/// <param name="m3_AED2">Effectivity date</param>
		/// <param name="m3_COPY">Number of copies</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ARVS">Revision service</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ACPL">Compliance code</param>
		/// <param name="m3_AADA">Engineering order accomplishment date</param>
		/// <param name="m3_AMTX">Amendment text</param>
		/// <param name="m3_ACPT">Text</param>
		/// <param name="m3_ACP2">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3_DOID, 
			string m3_DOTY = null, 
			string m3_DODE = null, 
			string m3_ADS1 = null, 
			string m3_AISB = null, 
			string m3_DNUM = null, 
			string m3_ADOB = null, 
			string m3_DOSS = null, 
			string m3_DOFM = null, 
			string m3_LNCD = null, 
			int? m3_ECMA = null, 
			string m3_ECVE = null, 
			string m3_ASBJ = null, 
			string m3_ASB2 = null, 
			string m3_DOME = null, 
			string m3_FIOF = null, 
			string m3_FUNC = null, 
			string m3_STNC = null, 
			string m3_DGRP = null, 
			string m3_RESP = null, 
			string m3_DEPT = null, 
			string m3_AREG = null, 
			DateTime? m3_AISD = null, 
			DateTime? m3_AEDT = null, 
			DateTime? m3_AED2 = null, 
			int? m3_COPY = null, 
			string m3_ITNO = null, 
			int? m3_ARVS = null, 
			string m3_FACI = null, 
			string m3_ACPL = null, 
			DateTime? m3_AADA = null, 
			string m3_AMTX = null, 
			string m3_ACPT = null, 
			string m3_ACP2 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DOID))
				throw new ArgumentNullException("m3_DOID");

			// Set mandatory parameters
			request
				.WithQueryParameter("DOID", m3_DOID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DOTY))
				request.WithQueryParameter("DOTY", m3_DOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DODE))
				request.WithQueryParameter("DODE", m3_DODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADS1))
				request.WithQueryParameter("ADS1", m3_ADS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AISB))
				request.WithQueryParameter("AISB", m3_AISB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DNUM))
				request.WithQueryParameter("DNUM", m3_DNUM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADOB))
				request.WithQueryParameter("ADOB", m3_ADOB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOSS))
				request.WithQueryParameter("DOSS", m3_DOSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOFM))
				request.WithQueryParameter("DOFM", m3_DOFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3_ECMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASBJ))
				request.WithQueryParameter("ASBJ", m3_ASBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASB2))
				request.WithQueryParameter("ASB2", m3_ASB2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOME))
				request.WithQueryParameter("DOME", m3_DOME.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIOF))
				request.WithQueryParameter("FIOF", m3_FIOF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUNC))
				request.WithQueryParameter("FUNC", m3_FUNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STNC))
				request.WithQueryParameter("STNC", m3_STNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DGRP))
				request.WithQueryParameter("DGRP", m3_DGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AREG))
				request.WithQueryParameter("AREG", m3_AREG.Trim());
			if (m3_AISD.HasValue)
				request.WithQueryParameter("AISD", m3_AISD.Value.ToM3String());
			if (m3_AEDT.HasValue)
				request.WithQueryParameter("AEDT", m3_AEDT.Value.ToM3String());
			if (m3_AED2.HasValue)
				request.WithQueryParameter("AED2", m3_AED2.Value.ToM3String());
			if (m3_COPY.HasValue)
				request.WithQueryParameter("COPY", m3_COPY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_ARVS.HasValue)
				request.WithQueryParameter("ARVS", m3_ARVS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACPL))
				request.WithQueryParameter("ACPL", m3_ACPL.Trim());
			if (m3_AADA.HasValue)
				request.WithQueryParameter("AADA", m3_AADA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_AMTX))
				request.WithQueryParameter("AMTX", m3_AMTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACPT))
				request.WithQueryParameter("ACPT", m3_ACPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACP2))
				request.WithQueryParameter("ACP2", m3_ACP2.Trim());

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
