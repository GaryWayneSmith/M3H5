/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddComp
		/// Description Add complaint
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CTPE">ComplaintType (Required)</param>
		/// <param name="m3DES0">Subject (Required)</param>
		/// <param name="m3REPR">ReportedBy (Required)</param>
		/// <param name="m3CCLA">Error code 1 (Required)</param>
		/// <param name="m3DEBY">Decision by (Required)</param>
		/// <param name="m3CONO">CompanyNumber</param>
		/// <param name="m3TAIL">Registration no/Site</param>
		/// <param name="m3CFGL">ConfigurationPosition</param>
		/// <param name="m3ITNO">ItemNumber</param>
		/// <param name="m3SERN">SerialNumber</param>
		/// <param name="m3RED0">EventDate</param>
		/// <param name="m3RET0">EventTime</param>
		/// <param name="m3RANK">PositionOfReponsible</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3MREF">MEL reference</param>
		/// <param name="m3MCAT">MEL category</param>
		/// <param name="m3VERI">Verified</param>
		/// <param name="m3RCOM">Complaint on hold</param>
		/// <param name="m3RES0">Restriction</param>
		/// <param name="m3INV0">Investigation request</param>
		/// <param name="m3NOAC">No action</param>
		/// <param name="m3EXR0">External reference</param>
		/// <param name="m3EVBY">Evaluated by</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3CER0">Certificate</param>
		/// <param name="m3ODTP">Original document type</param>
		/// <param name="m3ODNO">Original document number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="m3TXL2">Text</param>
		/// <param name="m3TXL5">Text Decision</param>
		/// <param name="m3TXL6">Text decision</param>
		/// <param name="m3CCLS">Close complaint</param>
		/// <param name="m3ZONE">Aircraft zone</param>
		/// <param name="m3PICT">Picture</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddCompResponse></returns>
		/// <exception cref="M3Exception<AddCompResponse>"></exception>
		public async Task<M3Response<AddCompResponse>> AddComp(
			string m3CTPE, 
			string m3DES0, 
			string m3REPR, 
			string m3CCLA, 
			string m3DEBY, 
			int? m3CONO = null, 
			string m3TAIL = null, 
			string m3CFGL = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
			DateTime? m3RED0 = null, 
			int? m3RET0 = null, 
			string m3RANK = null, 
			string m3MWNO = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			string m3MREF = null, 
			string m3MCAT = null, 
			int? m3VERI = null, 
			int? m3RCOM = null, 
			int? m3RES0 = null, 
			int? m3INV0 = null, 
			int? m3NOAC = null, 
			string m3EXR0 = null, 
			string m3EVBY = null, 
			string m3FACI = null, 
			string m3STAT = null, 
			string m3CER0 = null, 
			string m3ODTP = null, 
			string m3ODNO = null, 
			int? m3OPNO = null, 
			string m3CUNO = null, 
			string m3ORNO = null, 
			string m3TX60 = null, 
			string m3TXL2 = null, 
			string m3TXL5 = null, 
			string m3TXL6 = null, 
			int? m3CCLS = null, 
			string m3ZONE = null, 
			string m3PICT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddComp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTPE))
				throw new ArgumentNullException(nameof(m3CTPE));
			if (string.IsNullOrWhiteSpace(m3DES0))
				throw new ArgumentNullException(nameof(m3DES0));
			if (string.IsNullOrWhiteSpace(m3REPR))
				throw new ArgumentNullException(nameof(m3REPR));
			if (string.IsNullOrWhiteSpace(m3CCLA))
				throw new ArgumentNullException(nameof(m3CCLA));
			if (string.IsNullOrWhiteSpace(m3DEBY))
				throw new ArgumentNullException(nameof(m3DEBY));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTPE", m3CTPE.Trim())
				.WithQueryParameter("DES0", m3DES0.Trim())
				.WithQueryParameter("REPR", m3REPR.Trim())
				.WithQueryParameter("CCLA", m3CCLA.Trim())
				.WithQueryParameter("DEBY", m3DEBY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (m3RED0.HasValue)
				request.WithQueryParameter("RED0", m3RED0.Value.ToM3String());
			if (m3RET0.HasValue)
				request.WithQueryParameter("RET0", m3RET0.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RANK))
				request.WithQueryParameter("RANK", m3RANK.Trim());
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MREF))
				request.WithQueryParameter("MREF", m3MREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MCAT))
				request.WithQueryParameter("MCAT", m3MCAT.Trim());
			if (m3VERI.HasValue)
				request.WithQueryParameter("VERI", m3VERI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCOM.HasValue)
				request.WithQueryParameter("RCOM", m3RCOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RES0.HasValue)
				request.WithQueryParameter("RES0", m3RES0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INV0.HasValue)
				request.WithQueryParameter("INV0", m3INV0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NOAC.HasValue)
				request.WithQueryParameter("NOAC", m3NOAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXR0))
				request.WithQueryParameter("EXR0", m3EXR0.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVBY))
				request.WithQueryParameter("EVBY", m3EVBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CER0))
				request.WithQueryParameter("CER0", m3CER0.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODTP))
				request.WithQueryParameter("ODTP", m3ODTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODNO))
				request.WithQueryParameter("ODNO", m3ODNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL2))
				request.WithQueryParameter("TXL2", m3TXL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL5))
				request.WithQueryParameter("TXL5", m3TXL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL6))
				request.WithQueryParameter("TXL6", m3TXL6.Trim());
			if (m3CCLS.HasValue)
				request.WithQueryParameter("CCLS", m3CCLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ZONE))
				request.WithQueryParameter("ZONE", m3ZONE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PICT))
				request.WithQueryParameter("PICT", m3PICT.Trim());

			// Execute the request
			var result = await Execute<AddCompResponse>(
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
		/// Name AddDecision
		/// Description Add Decision
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DEID">Complaint (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3NUM2">Number</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3MREF">MEL reference</param>
		/// <param name="m3MCAT">MEL category</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3VERI">Verified</param>
		/// <param name="m3RCOM">Complaint on hold</param>
		/// <param name="m3RES0">Restriction</param>
		/// <param name="m3INV0">Investigation request</param>
		/// <param name="m3NOAC">No action</param>
		/// <param name="m3EXR0">External reference</param>
		/// <param name="m3EVBY">Evaluated by</param>
		/// <param name="m3DEBY">Decision by</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3CER0">Certificate</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="m3TXL2">Text</param>
		/// <param name="m3CCLS">Close Complaint</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDecision(
			int m3DEID, 
			int? m3CONO = null, 
			int? m3NUM2 = null, 
			string m3MWNO = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			string m3MREF = null, 
			string m3MCAT = null, 
			string m3CFGL = null, 
			int? m3VERI = null, 
			int? m3RCOM = null, 
			int? m3RES0 = null, 
			int? m3INV0 = null, 
			int? m3NOAC = null, 
			string m3EXR0 = null, 
			string m3EVBY = null, 
			string m3DEBY = null, 
			string m3FACI = null, 
			string m3STAT = null, 
			string m3CER0 = null, 
			string m3TX60 = null, 
			string m3TXL2 = null, 
			int? m3CCLS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDecision",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DEID", m3DEID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUM2.HasValue)
				request.WithQueryParameter("NUM2", m3NUM2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MREF))
				request.WithQueryParameter("MREF", m3MREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MCAT))
				request.WithQueryParameter("MCAT", m3MCAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (m3VERI.HasValue)
				request.WithQueryParameter("VERI", m3VERI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCOM.HasValue)
				request.WithQueryParameter("RCOM", m3RCOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RES0.HasValue)
				request.WithQueryParameter("RES0", m3RES0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INV0.HasValue)
				request.WithQueryParameter("INV0", m3INV0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NOAC.HasValue)
				request.WithQueryParameter("NOAC", m3NOAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXR0))
				request.WithQueryParameter("EXR0", m3EXR0.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVBY))
				request.WithQueryParameter("EVBY", m3EVBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEBY))
				request.WithQueryParameter("DEBY", m3DEBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CER0))
				request.WithQueryParameter("CER0", m3CER0.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL2))
				request.WithQueryParameter("TXL2", m3TXL2.Trim());
			if (m3CCLS.HasValue)
				request.WithQueryParameter("CCLS", m3CCLS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelComp
		/// Description Delete Complaint
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DEID">Complaint (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelComp(
			int m3DEID, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelComp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DEID", m3DEID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelDecision
		/// Description Delete Decision
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DEID">Complaint (Required)</param>
		/// <param name="m3NUM2">Number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDecision(
			int m3DEID, 
			int m3NUM2, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelDecision",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DEID", m3DEID.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("NUM2", m3NUM2.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdComp
		/// Description Update Complaint
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3DEID">Complaint (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3DES0">Subject</param>
		/// <param name="m3RED0">Event date</param>
		/// <param name="m3RET0">Event time</param>
		/// <param name="m3REPR">Reported by</param>
		/// <param name="m3RANK">Position of reponsible person</param>
		/// <param name="m3CCLA">Error code 1</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3MREF">MEL reference</param>
		/// <param name="m3MCAT">MEL category</param>
		/// <param name="m3VERI">Verified</param>
		/// <param name="m3RCOM">Complaint on hold</param>
		/// <param name="m3RES0">Restriction</param>
		/// <param name="m3INV0">Investigation request</param>
		/// <param name="m3NOAC">No action</param>
		/// <param name="m3EXR0">External reference</param>
		/// <param name="m3EVBY">Evaluated by</param>
		/// <param name="m3DEBY">Decision by</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3CER0">Certificate</param>
		/// <param name="m3ODTP">Original document type</param>
		/// <param name="m3ODNO">Original document number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3TX60">Text Complaint</param>
		/// <param name="m3TXL2">Text Complaint</param>
		/// <param name="m3TXL5">Text Decision</param>
		/// <param name="m3TXL6">Text Decision</param>
		/// <param name="m3CCLS">Close Complaint</param>
		/// <param name="m3ZONE">Aircraft zone</param>
		/// <param name="m3PICT">Picture</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdComp(
			int m3DEID, 
			int? m3CONO = null, 
			string m3CFGL = null, 
			string m3DES0 = null, 
			DateTime? m3RED0 = null, 
			int? m3RET0 = null, 
			string m3REPR = null, 
			string m3RANK = null, 
			string m3CCLA = null, 
			string m3MWNO = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			string m3MREF = null, 
			string m3MCAT = null, 
			int? m3VERI = null, 
			int? m3RCOM = null, 
			int? m3RES0 = null, 
			int? m3INV0 = null, 
			int? m3NOAC = null, 
			string m3EXR0 = null, 
			string m3EVBY = null, 
			string m3DEBY = null, 
			string m3FACI = null, 
			string m3STAT = null, 
			string m3CER0 = null, 
			string m3ODTP = null, 
			string m3ODNO = null, 
			int? m3OPNO = null, 
			string m3CUNO = null, 
			string m3ORNO = null, 
			string m3TX60 = null, 
			string m3TXL2 = null, 
			string m3TXL5 = null, 
			string m3TXL6 = null, 
			int? m3CCLS = null, 
			string m3ZONE = null, 
			string m3PICT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdComp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DEID", m3DEID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (!string.IsNullOrWhiteSpace(m3DES0))
				request.WithQueryParameter("DES0", m3DES0.Trim());
			if (m3RED0.HasValue)
				request.WithQueryParameter("RED0", m3RED0.Value.ToM3String());
			if (m3RET0.HasValue)
				request.WithQueryParameter("RET0", m3RET0.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REPR))
				request.WithQueryParameter("REPR", m3REPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RANK))
				request.WithQueryParameter("RANK", m3RANK.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCLA))
				request.WithQueryParameter("CCLA", m3CCLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MREF))
				request.WithQueryParameter("MREF", m3MREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MCAT))
				request.WithQueryParameter("MCAT", m3MCAT.Trim());
			if (m3VERI.HasValue)
				request.WithQueryParameter("VERI", m3VERI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCOM.HasValue)
				request.WithQueryParameter("RCOM", m3RCOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RES0.HasValue)
				request.WithQueryParameter("RES0", m3RES0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INV0.HasValue)
				request.WithQueryParameter("INV0", m3INV0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NOAC.HasValue)
				request.WithQueryParameter("NOAC", m3NOAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXR0))
				request.WithQueryParameter("EXR0", m3EXR0.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVBY))
				request.WithQueryParameter("EVBY", m3EVBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEBY))
				request.WithQueryParameter("DEBY", m3DEBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CER0))
				request.WithQueryParameter("CER0", m3CER0.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODTP))
				request.WithQueryParameter("ODTP", m3ODTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODNO))
				request.WithQueryParameter("ODNO", m3ODNO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL2))
				request.WithQueryParameter("TXL2", m3TXL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL5))
				request.WithQueryParameter("TXL5", m3TXL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL6))
				request.WithQueryParameter("TXL6", m3TXL6.Trim());
			if (m3CCLS.HasValue)
				request.WithQueryParameter("CCLS", m3CCLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ZONE))
				request.WithQueryParameter("ZONE", m3ZONE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PICT))
				request.WithQueryParameter("PICT", m3PICT.Trim());

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
		/// Name UpdDecision
		/// Description Update Decision
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DEID">Complaint (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3NUM2">Number</param>
		/// <param name="m3MWNO">Work order number</param>
		/// <param name="m3FCL2">Error code 2</param>
		/// <param name="m3FCL3">Error code 3</param>
		/// <param name="m3MREF">MEL reference</param>
		/// <param name="m3MCAT">MEL category</param>
		/// <param name="m3CFGL">Configuration position</param>
		/// <param name="m3VERI">Verified</param>
		/// <param name="m3RCOM">Complaint on hold</param>
		/// <param name="m3RES0">Restriction</param>
		/// <param name="m3INV0">Investigation request</param>
		/// <param name="m3NOAC">No action</param>
		/// <param name="m3EXR0">External reference</param>
		/// <param name="m3EVBY">Evaluated by</param>
		/// <param name="m3DEBY">Decision by</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3CER0">Certificate</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="m3TXL2">Text</param>
		/// <param name="m3CCLS">Close complaint</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDecision(
			int m3DEID, 
			int? m3CONO = null, 
			int? m3NUM2 = null, 
			string m3MWNO = null, 
			string m3FCL2 = null, 
			string m3FCL3 = null, 
			string m3MREF = null, 
			string m3MCAT = null, 
			string m3CFGL = null, 
			int? m3VERI = null, 
			int? m3RCOM = null, 
			int? m3RES0 = null, 
			int? m3INV0 = null, 
			int? m3NOAC = null, 
			string m3EXR0 = null, 
			string m3EVBY = null, 
			string m3DEBY = null, 
			string m3FACI = null, 
			string m3STAT = null, 
			string m3CER0 = null, 
			string m3TX60 = null, 
			string m3TXL2 = null, 
			int? m3CCLS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdDecision",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("DEID", m3DEID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUM2.HasValue)
				request.WithQueryParameter("NUM2", m3NUM2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MWNO))
				request.WithQueryParameter("MWNO", m3MWNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL2))
				request.WithQueryParameter("FCL2", m3FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCL3))
				request.WithQueryParameter("FCL3", m3FCL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MREF))
				request.WithQueryParameter("MREF", m3MREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MCAT))
				request.WithQueryParameter("MCAT", m3MCAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFGL))
				request.WithQueryParameter("CFGL", m3CFGL.Trim());
			if (m3VERI.HasValue)
				request.WithQueryParameter("VERI", m3VERI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCOM.HasValue)
				request.WithQueryParameter("RCOM", m3RCOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RES0.HasValue)
				request.WithQueryParameter("RES0", m3RES0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INV0.HasValue)
				request.WithQueryParameter("INV0", m3INV0.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NOAC.HasValue)
				request.WithQueryParameter("NOAC", m3NOAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EXR0))
				request.WithQueryParameter("EXR0", m3EXR0.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVBY))
				request.WithQueryParameter("EVBY", m3EVBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEBY))
				request.WithQueryParameter("DEBY", m3DEBY.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CER0))
				request.WithQueryParameter("CER0", m3CER0.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL2))
				request.WithQueryParameter("TXL2", m3TXL2.Trim());
			if (m3CCLS.HasValue)
				request.WithQueryParameter("CCLS", m3CCLS.Value.ToString(CultureInfo.CurrentCulture));

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
