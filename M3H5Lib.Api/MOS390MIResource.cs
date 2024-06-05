/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description This transaction creates warranty based on warranty type
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3WATP">Warranty type (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNS">Service product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3ITNO, 
			string m3SERN, 
			string m3WATP, 
			DateTime m3STDT, 
			string m3FACI = null, 
			string m3PRNS = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3RESP = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			decimal? m3ATNR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3WATP))
				throw new ArgumentNullException(nameof(m3WATP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("WATP", m3WATP.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNS))
				request.WithQueryParameter("PRNS", m3PRNS.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddClaimDetail
		/// Description This transaction adds Claim details
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3WADT">Warranty date (Required)</param>
		/// <param name="m3WATP">Warranty type (Required)</param>
		/// <param name="m3EXCL">Excluded (Required)</param>
		/// <param name="m3ALNT">Line type (Required)</param>
		/// <param name="m3IDTY">Item ID type (Required)</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3IDEN">Item ID</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PYN1">Payer</param>
		/// <param name="m3AAG1">Agreement</param>
		/// <param name="m3ASBO">Service bill of material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddClaimDetail(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3WADT, 
			string m3WATP, 
			int m3EXCL, 
			int m3ALNT, 
			int m3IDTY, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3IDEN = null, 
			string m3STAT = null, 
			string m3PYN1 = null, 
			string m3AAG1 = null, 
			int? m3ASBO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddClaimDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3WATP))
				throw new ArgumentNullException(nameof(m3WATP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("WADT", m3WADT.ToM3String())
				.WithQueryParameter("WATP", m3WATP.Trim())
				.WithQueryParameter("EXCL", m3EXCL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALNT", m3ALNT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IDTY", m3IDTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDEN))
				request.WithQueryParameter("IDEN", m3IDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYN1))
				request.WithQueryParameter("PYN1", m3PYN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAG1))
				request.WithQueryParameter("AAG1", m3AAG1.Trim());
			if (m3ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3ASBO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddWarDetail
		/// Description This transaction adds Warranty details
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3WADT">Warranty date (Required)</param>
		/// <param name="m3WATP">Warranty type (Required)</param>
		/// <param name="m3EXCL">Excluded (Required)</param>
		/// <param name="m3ALNT">Line type (Required)</param>
		/// <param name="m3IDTY">Item ID type (Required)</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3IDEN">Item ID</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PYN1">Payer</param>
		/// <param name="m3AAG1">Agreement</param>
		/// <param name="m3ASBO">Service bill of material</param>
		/// <param name="m3RTPR">Return processing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddWarDetail(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3WADT, 
			string m3WATP, 
			int m3EXCL, 
			int m3ALNT, 
			int m3IDTY, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3IDEN = null, 
			string m3STAT = null, 
			string m3PYN1 = null, 
			string m3AAG1 = null, 
			int? m3ASBO = null, 
			int? m3RTPR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddWarDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3WATP))
				throw new ArgumentNullException(nameof(m3WATP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("WADT", m3WADT.ToM3String())
				.WithQueryParameter("WATP", m3WATP.Trim())
				.WithQueryParameter("EXCL", m3EXCL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALNT", m3ALNT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IDTY", m3IDTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDEN))
				request.WithQueryParameter("IDEN", m3IDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYN1))
				request.WithQueryParameter("PYN1", m3PYN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAG1))
				request.WithQueryParameter("AAG1", m3AAG1.Trim());
			if (m3ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3ASBO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTPR.HasValue)
				request.WithQueryParameter("RTPR", m3RTPR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CheckWar
		/// Description This transaction checks warranty for a service
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DATE">Entry date</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CheckWarResponse></returns>
		/// <exception cref="M3Exception<CheckWarResponse>"></exception>
		public async Task<M3Response<CheckWarResponse>> CheckWar(
			string m3ITNO, 
			string m3SERN, 
			int? m3CONO = null, 
			DateTime? m3DATE = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CheckWar",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

			// Execute the request
			var result = await Execute<CheckWarResponse>(
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
		/// Name ChkWarMtrl
		/// Description This transaction check if warranty exists for an item number
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3WADT">Warranty date (Required)</param>
		/// <param name="m3IDEN">Item ID (Required)</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChkWarMtrlResponse></returns>
		/// <exception cref="M3Exception<ChkWarMtrlResponse>"></exception>
		public async Task<M3Response<ChkWarMtrlResponse>> ChkWarMtrl(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3WADT, 
			string m3IDEN, 
			string m3STRT = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChkWarMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3IDEN))
				throw new ArgumentNullException(nameof(m3IDEN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("WADT", m3WADT.ToM3String())
				.WithQueryParameter("IDEN", m3IDEN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Execute the request
			var result = await Execute<ChkWarMtrlResponse>(
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
		/// Name DelClaimDetail
		/// Description This transaction deletes Claim detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3WADT">Warranty date (Required)</param>
		/// <param name="m3WATP">Warranty type (Required)</param>
		/// <param name="m3EXCL">Excluded (Required)</param>
		/// <param name="m3ALNT">Line type (Required)</param>
		/// <param name="m3IDTY">Item ID type (Required)</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3IDEN">Item ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelClaimDetail(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3WADT, 
			string m3WATP, 
			int m3EXCL, 
			int m3ALNT, 
			int m3IDTY, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3IDEN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelClaimDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3WATP))
				throw new ArgumentNullException(nameof(m3WATP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("WADT", m3WADT.ToM3String())
				.WithQueryParameter("WATP", m3WATP.Trim())
				.WithQueryParameter("EXCL", m3EXCL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALNT", m3ALNT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IDTY", m3IDTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDEN))
				request.WithQueryParameter("IDEN", m3IDEN.Trim());

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
		/// Name DelWarDetail
		/// Description This transaction deletes Warranty detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3WADT">Warranty date (Required)</param>
		/// <param name="m3WATP">Warranty type (Required)</param>
		/// <param name="m3EXCL">Excluded (Required)</param>
		/// <param name="m3ALNT">Line type (Required)</param>
		/// <param name="m3IDTY">Item ID type (Required)</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3IDEN">Item ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelWarDetail(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3WADT, 
			string m3WATP, 
			int m3EXCL, 
			int m3ALNT, 
			int m3IDTY, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3IDEN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelWarDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3WATP))
				throw new ArgumentNullException(nameof(m3WATP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("WADT", m3WADT.ToM3String())
				.WithQueryParameter("WATP", m3WATP.Trim())
				.WithQueryParameter("EXCL", m3EXCL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALNT", m3ALNT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IDTY", m3IDTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDEN))
				request.WithQueryParameter("IDEN", m3IDEN.Trim());

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
		/// Name GetClaimDetail
		/// Description This transaction retrieves Claim detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3WADT">Warranty date (Required)</param>
		/// <param name="m3WATP">Warranty type (Required)</param>
		/// <param name="m3EXCL">Excluded (Required)</param>
		/// <param name="m3ALNT">Line type (Required)</param>
		/// <param name="m3IDTY">Item ID type (Required)</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3IDEN">Item ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetClaimDetailResponse></returns>
		/// <exception cref="M3Exception<GetClaimDetailResponse>"></exception>
		public async Task<M3Response<GetClaimDetailResponse>> GetClaimDetail(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3WADT, 
			string m3WATP, 
			int m3EXCL, 
			int m3ALNT, 
			int m3IDTY, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3IDEN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetClaimDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3WATP))
				throw new ArgumentNullException(nameof(m3WATP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("WADT", m3WADT.ToM3String())
				.WithQueryParameter("WATP", m3WATP.Trim())
				.WithQueryParameter("EXCL", m3EXCL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALNT", m3ALNT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IDTY", m3IDTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDEN))
				request.WithQueryParameter("IDEN", m3IDEN.Trim());

			// Execute the request
			var result = await Execute<GetClaimDetailResponse>(
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
		/// Name GetWarDetail
		/// Description This transaction retrieves Warranty detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3WADT">Warranty date (Required)</param>
		/// <param name="m3WATP">Warranty type (Required)</param>
		/// <param name="m3EXCL">Excluded (Required)</param>
		/// <param name="m3ALNT">Line type (Required)</param>
		/// <param name="m3IDTY">Item ID type (Required)</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3IDEN">Item ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetWarDetailResponse></returns>
		/// <exception cref="M3Exception<GetWarDetailResponse>"></exception>
		public async Task<M3Response<GetWarDetailResponse>> GetWarDetail(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3WADT, 
			string m3WATP, 
			int m3EXCL, 
			int m3ALNT, 
			int m3IDTY, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3IDEN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetWarDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3WATP))
				throw new ArgumentNullException(nameof(m3WATP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("WADT", m3WADT.ToM3String())
				.WithQueryParameter("WATP", m3WATP.Trim())
				.WithQueryParameter("EXCL", m3EXCL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALNT", m3ALNT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IDTY", m3IDTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDEN))
				request.WithQueryParameter("IDEN", m3IDEN.Trim());

			// Execute the request
			var result = await Execute<GetWarDetailResponse>(
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
		/// Name LstClaDetail
		/// Description This transaction lists equipment claim details
		/// Version Release: 
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3WADT">Warranty date</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STA1">Status from</param>
		/// <param name="m3STA2">Status to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstClaDetailResponse></returns>
		/// <exception cref="M3Exception<LstClaDetailResponse>"></exception>
		public async Task<M3Response<LstClaDetailResponse>> LstClaDetail(
			string m3ITNO, 
			string m3SERN, 
			DateTime? m3WADT = null, 
			string m3WATP = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3STA1 = null, 
			string m3STA2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstClaDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3WADT.HasValue)
				request.WithQueryParameter("WADT", m3WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STA1))
				request.WithQueryParameter("STA1", m3STA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3STA2))
				request.WithQueryParameter("STA2", m3STA2.Trim());

			// Execute the request
			var result = await Execute<LstClaDetailResponse>(
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
		/// Name LstWarDetail
		/// Description This transaction lists equipment warranty details
		/// Version Release: 
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3WADT">Warranty date</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3STA1">Status from</param>
		/// <param name="m3STA2">Status to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWarDetailResponse></returns>
		/// <exception cref="M3Exception<LstWarDetailResponse>"></exception>
		public async Task<M3Response<LstWarDetailResponse>> LstWarDetail(
			string m3ITNO, 
			string m3SERN, 
			DateTime? m3WADT = null, 
			string m3WATP = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3STA1 = null, 
			string m3STA2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstWarDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3WADT.HasValue)
				request.WithQueryParameter("WADT", m3WADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STA1))
				request.WithQueryParameter("STA1", m3STA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3STA2))
				request.WithQueryParameter("STA2", m3STA2.Trim());

			// Execute the request
			var result = await Execute<LstWarDetailResponse>(
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
		/// Name UpdClaimDetail
		/// Description This transaction updates Claim detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3WADT">Warranty date (Required)</param>
		/// <param name="m3WATP">Warranty type (Required)</param>
		/// <param name="m3EXCL">Excluded (Required)</param>
		/// <param name="m3ALNT">Line type (Required)</param>
		/// <param name="m3IDTY">Item ID type (Required)</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3IDEN">Item ID</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PYN1">Payer</param>
		/// <param name="m3AAG1">Agreement</param>
		/// <param name="m3ASBO">Service bill of material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdClaimDetail(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3WADT, 
			string m3WATP, 
			int m3EXCL, 
			int m3ALNT, 
			int m3IDTY, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3IDEN = null, 
			string m3STAT = null, 
			string m3PYN1 = null, 
			string m3AAG1 = null, 
			int? m3ASBO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdClaimDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3WATP))
				throw new ArgumentNullException(nameof(m3WATP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("WADT", m3WADT.ToM3String())
				.WithQueryParameter("WATP", m3WATP.Trim())
				.WithQueryParameter("EXCL", m3EXCL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALNT", m3ALNT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IDTY", m3IDTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDEN))
				request.WithQueryParameter("IDEN", m3IDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYN1))
				request.WithQueryParameter("PYN1", m3PYN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAG1))
				request.WithQueryParameter("AAG1", m3AAG1.Trim());
			if (m3ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3ASBO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdWarDetail
		/// Description This transaction updates Warranty detail
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3WADT">Warranty date (Required)</param>
		/// <param name="m3WATP">Warranty type (Required)</param>
		/// <param name="m3EXCL">Excluded (Required)</param>
		/// <param name="m3ALNT">Line type (Required)</param>
		/// <param name="m3IDTY">Item ID type (Required)</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3IDEN">Item ID</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PYN1">Payer</param>
		/// <param name="m3AAG1">Agreement</param>
		/// <param name="m3ASBO">Service bill of material</param>
		/// <param name="m3RTPR">Return processing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdWarDetail(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3WADT, 
			string m3WATP, 
			int m3EXCL, 
			int m3ALNT, 
			int m3IDTY, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3IDEN = null, 
			string m3STAT = null, 
			string m3PYN1 = null, 
			string m3AAG1 = null, 
			int? m3ASBO = null, 
			int? m3RTPR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdWarDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3WATP))
				throw new ArgumentNullException(nameof(m3WATP));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("WADT", m3WADT.ToM3String())
				.WithQueryParameter("WATP", m3WATP.Trim())
				.WithQueryParameter("EXCL", m3EXCL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ALNT", m3ALNT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IDTY", m3IDTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDEN))
				request.WithQueryParameter("IDEN", m3IDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYN1))
				request.WithQueryParameter("PYN1", m3PYN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAG1))
				request.WithQueryParameter("AAG1", m3AAG1.Trim());
			if (m3ASBO.HasValue)
				request.WithQueryParameter("ASBO", m3ASBO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTPR.HasValue)
				request.WithQueryParameter("RTPR", m3RTPR.Value.ToString(CultureInfo.CurrentCulture));

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
