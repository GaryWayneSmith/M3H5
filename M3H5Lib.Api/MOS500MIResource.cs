/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS500MI;
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
	/// Name: MOS500MI
	/// Component Name: MaintenanceComplaints
	/// Description: Maintenance complaints interface
	/// Version Release: 5ea0
	///</summary>
	public partial class MOS500MIResource : M3BaseResourceEndpoint
	{
		public MOS500MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS500MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddComp
		/// Description Add complaint
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CTPE">ComplaintType (Required)</param>
		/// <param name="m3_DES0">Subject (Required)</param>
		/// <param name="m3_REPR">ReportedBy (Required)</param>
		/// <param name="m3_CCLA">Error code 1 (Required)</param>
		/// <param name="m3_DEBY">Decision by (Required)</param>
		/// <param name="m3_CONO">CompanyNumber</param>
		/// <param name="m3_TAIL">Registration no/Site</param>
		/// <param name="m3_CFGL">ConfigurationPosition</param>
		/// <param name="m3_ITNO">ItemNumber</param>
		/// <param name="m3_SERN">SerialNumber</param>
		/// <param name="m3_RED0">EventDate</param>
		/// <param name="m3_RET0">EventTime</param>
		/// <param name="m3_RANK">PositionOfReponsible</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_MREF">MEL reference</param>
		/// <param name="m3_MCAT">MEL category</param>
		/// <param name="m3_VERI">Verified</param>
		/// <param name="m3_RCOM">Complaint on hold</param>
		/// <param name="m3_RES0">Restriction</param>
		/// <param name="m3_INV0">Investigation request</param>
		/// <param name="m3_NOAC">No action</param>
		/// <param name="m3_EXR0">External reference</param>
		/// <param name="m3_EVBY">Evaluated by</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_CER0">Certificate</param>
		/// <param name="m3_ODTP">Original document type</param>
		/// <param name="m3_ODNO">Original document number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="m3_TXL2">Text</param>
		/// <param name="m3_TXL5">Text Decision</param>
		/// <param name="m3_TXL6">Text decision</param>
		/// <param name="m3_CCLS">Close complaint</param>
		/// <param name="m3_ZONE">Aircraft zone</param>
		/// <param name="m3_PICT">Picture</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCompResponse></returns>
		/// <exception cref="M3Exception<AddCompResponse>"></exception>
		public async Task<M3Response<AddCompResponse>> AddComp(
			string m3_CTPE, 
			string m3_DES0, 
			string m3_REPR, 
			string m3_CCLA, 
			string m3_DEBY, 
			int? m3_CONO = null, 
			string m3_TAIL = null, 
			string m3_CFGL = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
			DateTime? m3_RED0 = null, 
			int? m3_RET0 = null, 
			string m3_RANK = null, 
			string m3_MWNO = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			string m3_MREF = null, 
			string m3_MCAT = null, 
			int? m3_VERI = null, 
			int? m3_RCOM = null, 
			int? m3_RES0 = null, 
			int? m3_INV0 = null, 
			int? m3_NOAC = null, 
			string m3_EXR0 = null, 
			string m3_EVBY = null, 
			string m3_FACI = null, 
			string m3_STAT = null, 
			string m3_CER0 = null, 
			string m3_ODTP = null, 
			string m3_ODNO = null, 
			int? m3_OPNO = null, 
			string m3_CUNO = null, 
			string m3_ORNO = null, 
			string m3_TX60 = null, 
			string m3_TXL2 = null, 
			string m3_TXL5 = null, 
			string m3_TXL6 = null, 
			int? m3_CCLS = null, 
			string m3_ZONE = null, 
			string m3_PICT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CTPE))
				throw new ArgumentNullException("m3_CTPE");
			if (string.IsNullOrWhiteSpace(m3_DES0))
				throw new ArgumentNullException("m3_DES0");
			if (string.IsNullOrWhiteSpace(m3_REPR))
				throw new ArgumentNullException("m3_REPR");
			if (string.IsNullOrWhiteSpace(m3_CCLA))
				throw new ArgumentNullException("m3_CCLA");
			if (string.IsNullOrWhiteSpace(m3_DEBY))
				throw new ArgumentNullException("m3_DEBY");

			// Set mandatory parameters
			request
				.WithQueryParameter("CTPE", m3_CTPE.Trim())
				.WithQueryParameter("DES0", m3_DES0.Trim())
				.WithQueryParameter("REPR", m3_REPR.Trim())
				.WithQueryParameter("CCLA", m3_CCLA.Trim())
				.WithQueryParameter("DEBY", m3_DEBY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (m3_RED0.HasValue)
				request.WithQueryParameter("RED0", m3_RED0.Value.ToM3String());
			if (m3_RET0.HasValue)
				request.WithQueryParameter("RET0", m3_RET0.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RANK))
				request.WithQueryParameter("RANK", m3_RANK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MREF))
				request.WithQueryParameter("MREF", m3_MREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MCAT))
				request.WithQueryParameter("MCAT", m3_MCAT.Trim());
			if (m3_VERI.HasValue)
				request.WithQueryParameter("VERI", m3_VERI.Value.ToString());
			if (m3_RCOM.HasValue)
				request.WithQueryParameter("RCOM", m3_RCOM.Value.ToString());
			if (m3_RES0.HasValue)
				request.WithQueryParameter("RES0", m3_RES0.Value.ToString());
			if (m3_INV0.HasValue)
				request.WithQueryParameter("INV0", m3_INV0.Value.ToString());
			if (m3_NOAC.HasValue)
				request.WithQueryParameter("NOAC", m3_NOAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXR0))
				request.WithQueryParameter("EXR0", m3_EXR0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVBY))
				request.WithQueryParameter("EVBY", m3_EVBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CER0))
				request.WithQueryParameter("CER0", m3_CER0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODTP))
				request.WithQueryParameter("ODTP", m3_ODTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODNO))
				request.WithQueryParameter("ODNO", m3_ODNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL2))
				request.WithQueryParameter("TXL2", m3_TXL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL5))
				request.WithQueryParameter("TXL5", m3_TXL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL6))
				request.WithQueryParameter("TXL6", m3_TXL6.Trim());
			if (m3_CCLS.HasValue)
				request.WithQueryParameter("CCLS", m3_CCLS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ZONE))
				request.WithQueryParameter("ZONE", m3_ZONE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PICT))
				request.WithQueryParameter("PICT", m3_PICT.Trim());

			// Execute the request
			var result = await Execute<AddCompResponse>(
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
		/// Name AddDecision
		/// Description Add Decision
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DEID">Complaint (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_NUM2">Number</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_MREF">MEL reference</param>
		/// <param name="m3_MCAT">MEL category</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_VERI">Verified</param>
		/// <param name="m3_RCOM">Complaint on hold</param>
		/// <param name="m3_RES0">Restriction</param>
		/// <param name="m3_INV0">Investigation request</param>
		/// <param name="m3_NOAC">No action</param>
		/// <param name="m3_EXR0">External reference</param>
		/// <param name="m3_EVBY">Evaluated by</param>
		/// <param name="m3_DEBY">Decision by</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_CER0">Certificate</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="m3_TXL2">Text</param>
		/// <param name="m3_CCLS">Close Complaint</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDecision(
			int m3_DEID, 
			int? m3_CONO = null, 
			int? m3_NUM2 = null, 
			string m3_MWNO = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			string m3_MREF = null, 
			string m3_MCAT = null, 
			string m3_CFGL = null, 
			int? m3_VERI = null, 
			int? m3_RCOM = null, 
			int? m3_RES0 = null, 
			int? m3_INV0 = null, 
			int? m3_NOAC = null, 
			string m3_EXR0 = null, 
			string m3_EVBY = null, 
			string m3_DEBY = null, 
			string m3_FACI = null, 
			string m3_STAT = null, 
			string m3_CER0 = null, 
			string m3_TX60 = null, 
			string m3_TXL2 = null, 
			int? m3_CCLS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDecision",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DEID", m3_DEID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_NUM2.HasValue)
				request.WithQueryParameter("NUM2", m3_NUM2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MREF))
				request.WithQueryParameter("MREF", m3_MREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MCAT))
				request.WithQueryParameter("MCAT", m3_MCAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (m3_VERI.HasValue)
				request.WithQueryParameter("VERI", m3_VERI.Value.ToString());
			if (m3_RCOM.HasValue)
				request.WithQueryParameter("RCOM", m3_RCOM.Value.ToString());
			if (m3_RES0.HasValue)
				request.WithQueryParameter("RES0", m3_RES0.Value.ToString());
			if (m3_INV0.HasValue)
				request.WithQueryParameter("INV0", m3_INV0.Value.ToString());
			if (m3_NOAC.HasValue)
				request.WithQueryParameter("NOAC", m3_NOAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXR0))
				request.WithQueryParameter("EXR0", m3_EXR0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVBY))
				request.WithQueryParameter("EVBY", m3_EVBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEBY))
				request.WithQueryParameter("DEBY", m3_DEBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CER0))
				request.WithQueryParameter("CER0", m3_CER0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL2))
				request.WithQueryParameter("TXL2", m3_TXL2.Trim());
			if (m3_CCLS.HasValue)
				request.WithQueryParameter("CCLS", m3_CCLS.Value.ToString());

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
		/// Name DelComp
		/// Description Delete Complaint
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DEID">Complaint (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelComp(
			int m3_DEID, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelComp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DEID", m3_DEID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name DelDecision
		/// Description Delete Decision
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DEID">Complaint (Required)</param>
		/// <param name="m3_NUM2">Number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDecision(
			int m3_DEID, 
			int m3_NUM2, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelDecision",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DEID", m3_DEID.ToString())
				.WithQueryParameter("NUM2", m3_NUM2.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name UpdComp
		/// Description Update Complaint
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_DEID">Complaint (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_DES0">Subject</param>
		/// <param name="m3_RED0">Event date</param>
		/// <param name="m3_RET0">Event time</param>
		/// <param name="m3_REPR">Reported by</param>
		/// <param name="m3_RANK">Position of reponsible person</param>
		/// <param name="m3_CCLA">Error code 1</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_MREF">MEL reference</param>
		/// <param name="m3_MCAT">MEL category</param>
		/// <param name="m3_VERI">Verified</param>
		/// <param name="m3_RCOM">Complaint on hold</param>
		/// <param name="m3_RES0">Restriction</param>
		/// <param name="m3_INV0">Investigation request</param>
		/// <param name="m3_NOAC">No action</param>
		/// <param name="m3_EXR0">External reference</param>
		/// <param name="m3_EVBY">Evaluated by</param>
		/// <param name="m3_DEBY">Decision by</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_CER0">Certificate</param>
		/// <param name="m3_ODTP">Original document type</param>
		/// <param name="m3_ODNO">Original document number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_TX60">Text Complaint</param>
		/// <param name="m3_TXL2">Text Complaint</param>
		/// <param name="m3_TXL5">Text Decision</param>
		/// <param name="m3_TXL6">Text Decision</param>
		/// <param name="m3_CCLS">Close Complaint</param>
		/// <param name="m3_ZONE">Aircraft zone</param>
		/// <param name="m3_PICT">Picture</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdComp(
			int m3_DEID, 
			int? m3_CONO = null, 
			string m3_CFGL = null, 
			string m3_DES0 = null, 
			DateTime? m3_RED0 = null, 
			int? m3_RET0 = null, 
			string m3_REPR = null, 
			string m3_RANK = null, 
			string m3_CCLA = null, 
			string m3_MWNO = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			string m3_MREF = null, 
			string m3_MCAT = null, 
			int? m3_VERI = null, 
			int? m3_RCOM = null, 
			int? m3_RES0 = null, 
			int? m3_INV0 = null, 
			int? m3_NOAC = null, 
			string m3_EXR0 = null, 
			string m3_EVBY = null, 
			string m3_DEBY = null, 
			string m3_FACI = null, 
			string m3_STAT = null, 
			string m3_CER0 = null, 
			string m3_ODTP = null, 
			string m3_ODNO = null, 
			int? m3_OPNO = null, 
			string m3_CUNO = null, 
			string m3_ORNO = null, 
			string m3_TX60 = null, 
			string m3_TXL2 = null, 
			string m3_TXL5 = null, 
			string m3_TXL6 = null, 
			int? m3_CCLS = null, 
			string m3_ZONE = null, 
			string m3_PICT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdComp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DEID", m3_DEID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DES0))
				request.WithQueryParameter("DES0", m3_DES0.Trim());
			if (m3_RED0.HasValue)
				request.WithQueryParameter("RED0", m3_RED0.Value.ToM3String());
			if (m3_RET0.HasValue)
				request.WithQueryParameter("RET0", m3_RET0.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REPR))
				request.WithQueryParameter("REPR", m3_REPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RANK))
				request.WithQueryParameter("RANK", m3_RANK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCLA))
				request.WithQueryParameter("CCLA", m3_CCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MREF))
				request.WithQueryParameter("MREF", m3_MREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MCAT))
				request.WithQueryParameter("MCAT", m3_MCAT.Trim());
			if (m3_VERI.HasValue)
				request.WithQueryParameter("VERI", m3_VERI.Value.ToString());
			if (m3_RCOM.HasValue)
				request.WithQueryParameter("RCOM", m3_RCOM.Value.ToString());
			if (m3_RES0.HasValue)
				request.WithQueryParameter("RES0", m3_RES0.Value.ToString());
			if (m3_INV0.HasValue)
				request.WithQueryParameter("INV0", m3_INV0.Value.ToString());
			if (m3_NOAC.HasValue)
				request.WithQueryParameter("NOAC", m3_NOAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXR0))
				request.WithQueryParameter("EXR0", m3_EXR0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVBY))
				request.WithQueryParameter("EVBY", m3_EVBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEBY))
				request.WithQueryParameter("DEBY", m3_DEBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CER0))
				request.WithQueryParameter("CER0", m3_CER0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODTP))
				request.WithQueryParameter("ODTP", m3_ODTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODNO))
				request.WithQueryParameter("ODNO", m3_ODNO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL2))
				request.WithQueryParameter("TXL2", m3_TXL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL5))
				request.WithQueryParameter("TXL5", m3_TXL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL6))
				request.WithQueryParameter("TXL6", m3_TXL6.Trim());
			if (m3_CCLS.HasValue)
				request.WithQueryParameter("CCLS", m3_CCLS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ZONE))
				request.WithQueryParameter("ZONE", m3_ZONE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PICT))
				request.WithQueryParameter("PICT", m3_PICT.Trim());

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
		/// Name UpdDecision
		/// Description Update Decision
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DEID">Complaint (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_NUM2">Number</param>
		/// <param name="m3_MWNO">Work order number</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_MREF">MEL reference</param>
		/// <param name="m3_MCAT">MEL category</param>
		/// <param name="m3_CFGL">Configuration position</param>
		/// <param name="m3_VERI">Verified</param>
		/// <param name="m3_RCOM">Complaint on hold</param>
		/// <param name="m3_RES0">Restriction</param>
		/// <param name="m3_INV0">Investigation request</param>
		/// <param name="m3_NOAC">No action</param>
		/// <param name="m3_EXR0">External reference</param>
		/// <param name="m3_EVBY">Evaluated by</param>
		/// <param name="m3_DEBY">Decision by</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_CER0">Certificate</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="m3_TXL2">Text</param>
		/// <param name="m3_CCLS">Close complaint</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDecision(
			int m3_DEID, 
			int? m3_CONO = null, 
			int? m3_NUM2 = null, 
			string m3_MWNO = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			string m3_MREF = null, 
			string m3_MCAT = null, 
			string m3_CFGL = null, 
			int? m3_VERI = null, 
			int? m3_RCOM = null, 
			int? m3_RES0 = null, 
			int? m3_INV0 = null, 
			int? m3_NOAC = null, 
			string m3_EXR0 = null, 
			string m3_EVBY = null, 
			string m3_DEBY = null, 
			string m3_FACI = null, 
			string m3_STAT = null, 
			string m3_CER0 = null, 
			string m3_TX60 = null, 
			string m3_TXL2 = null, 
			int? m3_CCLS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdDecision",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DEID", m3_DEID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_NUM2.HasValue)
				request.WithQueryParameter("NUM2", m3_NUM2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MWNO))
				request.WithQueryParameter("MWNO", m3_MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MREF))
				request.WithQueryParameter("MREF", m3_MREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MCAT))
				request.WithQueryParameter("MCAT", m3_MCAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFGL))
				request.WithQueryParameter("CFGL", m3_CFGL.Trim());
			if (m3_VERI.HasValue)
				request.WithQueryParameter("VERI", m3_VERI.Value.ToString());
			if (m3_RCOM.HasValue)
				request.WithQueryParameter("RCOM", m3_RCOM.Value.ToString());
			if (m3_RES0.HasValue)
				request.WithQueryParameter("RES0", m3_RES0.Value.ToString());
			if (m3_INV0.HasValue)
				request.WithQueryParameter("INV0", m3_INV0.Value.ToString());
			if (m3_NOAC.HasValue)
				request.WithQueryParameter("NOAC", m3_NOAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EXR0))
				request.WithQueryParameter("EXR0", m3_EXR0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVBY))
				request.WithQueryParameter("EVBY", m3_EVBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEBY))
				request.WithQueryParameter("DEBY", m3_DEBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CER0))
				request.WithQueryParameter("CER0", m3_CER0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL2))
				request.WithQueryParameter("TXL2", m3_TXL2.Trim());
			if (m3_CCLS.HasValue)
				request.WithQueryParameter("CCLS", m3_CCLS.Value.ToString());

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
