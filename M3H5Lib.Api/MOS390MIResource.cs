/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MOS390MI;
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
	/// Name: MOS390MI
	/// Component Name: Cust Sales and Serv
	/// Description: Api: Service Warranty
	/// Version Release: 5ea3
	///</summary>
	public partial class MOS390MIResource : M3BaseResourceEndpoint
	{
		public MOS390MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS390MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description This transaction creates warranty based on warranty type
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNS">Service product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_ITNO, 
			string m3_SERN, 
			string m3_WATP, 
			DateTime m3_STDT, 
			string m3_FACI = null, 
			string m3_PRNS = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_RESP = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			decimal? m3_ATNR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("WATP", m3_WATP.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNS))
				request.WithQueryParameter("PRNS", m3_PRNS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());

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
		/// Name AddClaimDetail
		/// Description This transaction adds Claim details
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_WADT">Warranty date (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="m3_EXCL">Excluded (Required)</param>
		/// <param name="m3_ALNT">Line type (Required)</param>
		/// <param name="m3_IDTY">Item ID type (Required)</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_IDEN">Item ID</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PYN1">Payer</param>
		/// <param name="m3_AAG1">Agreement</param>
		/// <param name="m3_ASBO">Service bill of material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddClaimDetail(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_WADT, 
			string m3_WATP, 
			int m3_EXCL, 
			int m3_ALNT, 
			int m3_IDTY, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_IDEN = null, 
			string m3_STAT = null, 
			string m3_PYN1 = null, 
			string m3_AAG1 = null, 
			int? m3_ASBO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddClaimDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("WADT", m3_WADT.ToM3String())
				.WithQueryParameter("WATP", m3_WATP.Trim())
				.WithQueryParameter("EXCL", m3_EXCL.ToString())
				.WithQueryParameter("ALNT", m3_ALNT.ToString())
				.WithQueryParameter("IDTY", m3_IDTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDEN))
				request.WithQueryParameter("IDEN", m3_IDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYN1))
				request.WithQueryParameter("PYN1", m3_PYN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAG1))
				request.WithQueryParameter("AAG1", m3_AAG1.Trim());
			if (m3_ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3_ASBO.Value.ToString());

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
		/// Name AddWarDetail
		/// Description This transaction adds Warranty details
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_WADT">Warranty date (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="m3_EXCL">Excluded (Required)</param>
		/// <param name="m3_ALNT">Line type (Required)</param>
		/// <param name="m3_IDTY">Item ID type (Required)</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_IDEN">Item ID</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PYN1">Payer</param>
		/// <param name="m3_AAG1">Agreement</param>
		/// <param name="m3_ASBO">Service bill of material</param>
		/// <param name="m3_RTPR">Return processing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddWarDetail(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_WADT, 
			string m3_WATP, 
			int m3_EXCL, 
			int m3_ALNT, 
			int m3_IDTY, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_IDEN = null, 
			string m3_STAT = null, 
			string m3_PYN1 = null, 
			string m3_AAG1 = null, 
			int? m3_ASBO = null, 
			int? m3_RTPR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddWarDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("WADT", m3_WADT.ToM3String())
				.WithQueryParameter("WATP", m3_WATP.Trim())
				.WithQueryParameter("EXCL", m3_EXCL.ToString())
				.WithQueryParameter("ALNT", m3_ALNT.ToString())
				.WithQueryParameter("IDTY", m3_IDTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDEN))
				request.WithQueryParameter("IDEN", m3_IDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYN1))
				request.WithQueryParameter("PYN1", m3_PYN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAG1))
				request.WithQueryParameter("AAG1", m3_AAG1.Trim());
			if (m3_ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3_ASBO.Value.ToString());
			if (m3_RTPR.HasValue)
				request.WithQueryParameter("RTPR", m3_RTPR.Value.ToString());

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
		/// Name CheckWar
		/// Description This transaction checks warranty for a service
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DATE">Entry date</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CheckWarResponse></returns>
		/// <exception cref="M3Exception<CheckWarResponse>"></exception>
		public async Task<M3Response<CheckWarResponse>> CheckWar(
			string m3_ITNO, 
			string m3_SERN, 
			int? m3_CONO = null, 
			DateTime? m3_DATE = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CheckWar",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

			// Execute the request
			var result = await Execute<CheckWarResponse>(
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
		/// Name ChkWarMtrl
		/// Description This transaction check if warranty exists for an item number
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_WADT">Warranty date (Required)</param>
		/// <param name="m3_IDEN">Item ID (Required)</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChkWarMtrlResponse></returns>
		/// <exception cref="M3Exception<ChkWarMtrlResponse>"></exception>
		public async Task<M3Response<ChkWarMtrlResponse>> ChkWarMtrl(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_WADT, 
			string m3_IDEN, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChkWarMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_IDEN))
				throw new ArgumentNullException("m3_IDEN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("WADT", m3_WADT.ToM3String())
				.WithQueryParameter("IDEN", m3_IDEN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Execute the request
			var result = await Execute<ChkWarMtrlResponse>(
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
		/// Name DelClaimDetail
		/// Description This transaction deletes Claim detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_WADT">Warranty date (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="m3_EXCL">Excluded (Required)</param>
		/// <param name="m3_ALNT">Line type (Required)</param>
		/// <param name="m3_IDTY">Item ID type (Required)</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_IDEN">Item ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelClaimDetail(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_WADT, 
			string m3_WATP, 
			int m3_EXCL, 
			int m3_ALNT, 
			int m3_IDTY, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_IDEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelClaimDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("WADT", m3_WADT.ToM3String())
				.WithQueryParameter("WATP", m3_WATP.Trim())
				.WithQueryParameter("EXCL", m3_EXCL.ToString())
				.WithQueryParameter("ALNT", m3_ALNT.ToString())
				.WithQueryParameter("IDTY", m3_IDTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDEN))
				request.WithQueryParameter("IDEN", m3_IDEN.Trim());

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
		/// Name DelWarDetail
		/// Description This transaction deletes Warranty detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_WADT">Warranty date (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="m3_EXCL">Excluded (Required)</param>
		/// <param name="m3_ALNT">Line type (Required)</param>
		/// <param name="m3_IDTY">Item ID type (Required)</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_IDEN">Item ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelWarDetail(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_WADT, 
			string m3_WATP, 
			int m3_EXCL, 
			int m3_ALNT, 
			int m3_IDTY, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_IDEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelWarDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("WADT", m3_WADT.ToM3String())
				.WithQueryParameter("WATP", m3_WATP.Trim())
				.WithQueryParameter("EXCL", m3_EXCL.ToString())
				.WithQueryParameter("ALNT", m3_ALNT.ToString())
				.WithQueryParameter("IDTY", m3_IDTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDEN))
				request.WithQueryParameter("IDEN", m3_IDEN.Trim());

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
		/// Name GetClaimDetail
		/// Description This transaction retrieves Claim detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_WADT">Warranty date (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="m3_EXCL">Excluded (Required)</param>
		/// <param name="m3_ALNT">Line type (Required)</param>
		/// <param name="m3_IDTY">Item ID type (Required)</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_IDEN">Item ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimDetailResponse></returns>
		/// <exception cref="M3Exception<GetClaimDetailResponse>"></exception>
		public async Task<M3Response<GetClaimDetailResponse>> GetClaimDetail(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_WADT, 
			string m3_WATP, 
			int m3_EXCL, 
			int m3_ALNT, 
			int m3_IDTY, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_IDEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetClaimDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("WADT", m3_WADT.ToM3String())
				.WithQueryParameter("WATP", m3_WATP.Trim())
				.WithQueryParameter("EXCL", m3_EXCL.ToString())
				.WithQueryParameter("ALNT", m3_ALNT.ToString())
				.WithQueryParameter("IDTY", m3_IDTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDEN))
				request.WithQueryParameter("IDEN", m3_IDEN.Trim());

			// Execute the request
			var result = await Execute<GetClaimDetailResponse>(
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
		/// Name GetWarDetail
		/// Description This transaction retrieves Warranty detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_WADT">Warranty date (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="m3_EXCL">Excluded (Required)</param>
		/// <param name="m3_ALNT">Line type (Required)</param>
		/// <param name="m3_IDTY">Item ID type (Required)</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_IDEN">Item ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWarDetailResponse></returns>
		/// <exception cref="M3Exception<GetWarDetailResponse>"></exception>
		public async Task<M3Response<GetWarDetailResponse>> GetWarDetail(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_WADT, 
			string m3_WATP, 
			int m3_EXCL, 
			int m3_ALNT, 
			int m3_IDTY, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_IDEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetWarDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("WADT", m3_WADT.ToM3String())
				.WithQueryParameter("WATP", m3_WATP.Trim())
				.WithQueryParameter("EXCL", m3_EXCL.ToString())
				.WithQueryParameter("ALNT", m3_ALNT.ToString())
				.WithQueryParameter("IDTY", m3_IDTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDEN))
				request.WithQueryParameter("IDEN", m3_IDEN.Trim());

			// Execute the request
			var result = await Execute<GetWarDetailResponse>(
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
		/// Name LstClaDetail
		/// Description This transaction lists equipment claim details
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_WADT">Warranty date</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STA1">Status from</param>
		/// <param name="m3_STA2">Status to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaDetailResponse></returns>
		/// <exception cref="M3Exception<LstClaDetailResponse>"></exception>
		public async Task<M3Response<LstClaDetailResponse>> LstClaDetail(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime? m3_WADT = null, 
			string m3_WATP = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_STA1 = null, 
			string m3_STA2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstClaDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_WADT.HasValue)
				request.WithQueryParameter("WADT", m3_WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STA1))
				request.WithQueryParameter("STA1", m3_STA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STA2))
				request.WithQueryParameter("STA2", m3_STA2.Trim());

			// Execute the request
			var result = await Execute<LstClaDetailResponse>(
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
		/// Name LstWarDetail
		/// Description This transaction lists equipment warranty details
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_WADT">Warranty date</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_STA1">Status from</param>
		/// <param name="m3_STA2">Status to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWarDetailResponse></returns>
		/// <exception cref="M3Exception<LstWarDetailResponse>"></exception>
		public async Task<M3Response<LstWarDetailResponse>> LstWarDetail(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime? m3_WADT = null, 
			string m3_WATP = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_STA1 = null, 
			string m3_STA2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstWarDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_WADT.HasValue)
				request.WithQueryParameter("WADT", m3_WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STA1))
				request.WithQueryParameter("STA1", m3_STA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STA2))
				request.WithQueryParameter("STA2", m3_STA2.Trim());

			// Execute the request
			var result = await Execute<LstWarDetailResponse>(
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
		/// Name UpdClaimDetail
		/// Description This transaction updates Claim detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_WADT">Warranty date (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="m3_EXCL">Excluded (Required)</param>
		/// <param name="m3_ALNT">Line type (Required)</param>
		/// <param name="m3_IDTY">Item ID type (Required)</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_IDEN">Item ID</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PYN1">Payer</param>
		/// <param name="m3_AAG1">Agreement</param>
		/// <param name="m3_ASBO">Service bill of material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimDetail(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_WADT, 
			string m3_WATP, 
			int m3_EXCL, 
			int m3_ALNT, 
			int m3_IDTY, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_IDEN = null, 
			string m3_STAT = null, 
			string m3_PYN1 = null, 
			string m3_AAG1 = null, 
			int? m3_ASBO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdClaimDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("WADT", m3_WADT.ToM3String())
				.WithQueryParameter("WATP", m3_WATP.Trim())
				.WithQueryParameter("EXCL", m3_EXCL.ToString())
				.WithQueryParameter("ALNT", m3_ALNT.ToString())
				.WithQueryParameter("IDTY", m3_IDTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDEN))
				request.WithQueryParameter("IDEN", m3_IDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYN1))
				request.WithQueryParameter("PYN1", m3_PYN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAG1))
				request.WithQueryParameter("AAG1", m3_AAG1.Trim());
			if (m3_ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3_ASBO.Value.ToString());

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
		/// Name UpdWarDetail
		/// Description This transaction updates Warranty detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_WADT">Warranty date (Required)</param>
		/// <param name="m3_WATP">Warranty type (Required)</param>
		/// <param name="m3_EXCL">Excluded (Required)</param>
		/// <param name="m3_ALNT">Line type (Required)</param>
		/// <param name="m3_IDTY">Item ID type (Required)</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_IDEN">Item ID</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PYN1">Payer</param>
		/// <param name="m3_AAG1">Agreement</param>
		/// <param name="m3_ASBO">Service bill of material</param>
		/// <param name="m3_RTPR">Return processing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdWarDetail(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_WADT, 
			string m3_WATP, 
			int m3_EXCL, 
			int m3_ALNT, 
			int m3_IDTY, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_IDEN = null, 
			string m3_STAT = null, 
			string m3_PYN1 = null, 
			string m3_AAG1 = null, 
			int? m3_ASBO = null, 
			int? m3_RTPR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdWarDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_WATP))
				throw new ArgumentNullException("m3_WATP");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("WADT", m3_WADT.ToM3String())
				.WithQueryParameter("WATP", m3_WATP.Trim())
				.WithQueryParameter("EXCL", m3_EXCL.ToString())
				.WithQueryParameter("ALNT", m3_ALNT.ToString())
				.WithQueryParameter("IDTY", m3_IDTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDEN))
				request.WithQueryParameter("IDEN", m3_IDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYN1))
				request.WithQueryParameter("PYN1", m3_PYN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAG1))
				request.WithQueryParameter("AAG1", m3_AAG1.Trim());
			if (m3_ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3_ASBO.Value.ToString());
			if (m3_RTPR.HasValue)
				request.WithQueryParameter("RTPR", m3_RTPR.Value.ToString());

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
