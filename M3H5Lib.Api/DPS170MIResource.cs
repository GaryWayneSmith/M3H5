/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.DPS170MI;
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
	/// Name: DPS170MI
	/// Component Name: PlannedDistributionOrder
	/// Description: Planned distribution orders interface
	/// Version Release: 5ea1
	///</summary>
	public partial class DPS170MIResource : M3BaseResourceEndpoint
	{
		public DPS170MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "DPS170MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ClrInboxDOP
		/// Description Clear Inbox for DOP
		/// Version Release: 12.2
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClrInboxDOP(
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClrInboxDOP",
			};

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
		/// Name DelPlannedDO
		/// Description DelPlannedDO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Subnumber - planned order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPlannedDO(
			int m3PLPN, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelPlannedDO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetDistDays
		/// Description Retrive distribution days
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FWLO">From warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TWLO">To warehouse</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3SYCA">Read from system calendar</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDistDaysResponse></returns>
		/// <exception cref="M3Exception<GetDistDaysResponse>"></exception>
		public async Task<M3Response<GetDistDaysResponse>> GetDistDays(
			string m3FWLO, 
			int? m3CONO = null, 
			string m3TWLO = null, 
			string m3WHGR = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			int? m3SYCA = null, 
			string m3DIVI = null, 
			string m3FACI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDistDays",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FWLO))
				throw new ArgumentNullException(nameof(m3FWLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FWLO", m3FWLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWLO))
				request.WithQueryParameter("TWLO", m3TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (m3SYCA.HasValue)
				request.WithQueryParameter("SYCA", m3SYCA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());

			// Execute the request
			var result = await Execute<GetDistDaysResponse>(
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
		/// Name GetDistRel
		/// Description Retrive distribution realtions between warehouses
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FWLO">From warehouse (Required)</param>
		/// <param name="m3RLTY">Relation type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TWLO">To warehouse</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3DIKY">Group identity</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDistRelResponse></returns>
		/// <exception cref="M3Exception<GetDistRelResponse>"></exception>
		public async Task<M3Response<GetDistRelResponse>> GetDistRel(
			string m3FWLO, 
			int m3RLTY, 
			int? m3CONO = null, 
			string m3TWLO = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			string m3DIKY = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDistRel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FWLO))
				throw new ArgumentNullException(nameof(m3FWLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FWLO", m3FWLO.Trim())
				.WithQueryParameter("RLTY", m3RLTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWLO))
				request.WithQueryParameter("TWLO", m3TWLO.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3DIKY))
				request.WithQueryParameter("DIKY", m3DIKY.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Execute the request
			var result = await Execute<GetDistRelResponse>(
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
		/// Name GetUserJobSts
		/// Description Get update status per user
		/// Version Release: 12.2
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STA2">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUserJobStsResponse></returns>
		/// <exception cref="M3Exception<GetUserJobStsResponse>"></exception>
		public async Task<M3Response<GetUserJobStsResponse>> GetUserJobSts(
			int? m3CONO = null, 
			string m3STA2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetUserJobSts",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STA2))
				request.WithQueryParameter("STA2", m3STA2.Trim());

			// Execute the request
			var result = await Execute<GetUserJobStsResponse>(
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
		/// Name LstDistDays
		/// Description List  distribution days
		/// Version Release: 12.2
		/// </summary>
		/// <param name="m3FWLO">From warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TWLO">To warehouse</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3SYCA">Read from system calendar</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDistDaysResponse></returns>
		/// <exception cref="M3Exception<LstDistDaysResponse>"></exception>
		public async Task<M3Response<LstDistDaysResponse>> LstDistDays(
			string m3FWLO, 
			int? m3CONO = null, 
			string m3TWLO = null, 
			string m3WHGR = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			int? m3SYCA = null, 
			string m3DIVI = null, 
			string m3FACI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDistDays",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FWLO))
				throw new ArgumentNullException(nameof(m3FWLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FWLO", m3FWLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWLO))
				request.WithQueryParameter("TWLO", m3TWLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (m3SYCA.HasValue)
				request.WithQueryParameter("SYCA", m3SYCA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());

			// Execute the request
			var result = await Execute<LstDistDaysResponse>(
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
		/// Name LstDistRel
		/// Description List distribution realtions between warehouses
		/// Version Release: 12.2
		/// </summary>
		/// <param name="m3FWLO">From warehouse (Required)</param>
		/// <param name="m3RLTY">Relation type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TWLO">To warehouse</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3DIKY">Group identity</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDistRelResponse></returns>
		/// <exception cref="M3Exception<LstDistRelResponse>"></exception>
		public async Task<M3Response<LstDistRelResponse>> LstDistRel(
			string m3FWLO, 
			int m3RLTY, 
			int? m3CONO = null, 
			string m3TWLO = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			string m3DIKY = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDistRel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FWLO))
				throw new ArgumentNullException(nameof(m3FWLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FWLO", m3FWLO.Trim())
				.WithQueryParameter("RLTY", m3RLTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWLO))
				request.WithQueryParameter("TWLO", m3TWLO.Trim());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3DIKY))
				request.WithQueryParameter("DIKY", m3DIKY.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Execute the request
			var result = await Execute<LstDistRelResponse>(
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
		/// Name SearchDOP
		/// Description Search DOP
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchDOPResponse></returns>
		/// <exception cref="M3Exception<SearchDOPResponse>"></exception>
		public async Task<M3Response<SearchDOPResponse>> SearchDOP(
			string m3SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchDOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchDOPResponse>(
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
		/// Name SelErrDOP
		/// Description Selection of DOP not correctly updated
		/// Version Release: 12.2
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelErrDOPResponse></returns>
		/// <exception cref="M3Exception<SelErrDOPResponse>"></exception>
		public async Task<M3Response<SelErrDOPResponse>> SelErrDOP(
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelErrDOP",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelErrDOPResponse>(
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
		/// Name Select
		/// Description Selection of planned distribution orders
		/// Version Release: 12,1
		/// </summary>
		/// <param name="m3WHGR">Warehouse Group (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FSTS">From status</param>
		/// <param name="m3TSTS">To status</param>
		/// <param name="m3DEDR">De-select external distr. reqs/supplies</param>
		/// <param name="m3SCHH">Scheduling horizon</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="m3DESE">Deselect requsition orders</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3WHGR, 
			int? m3CONO = null, 
			string m3FSTS = null, 
			string m3TSTS = null, 
			int? m3DEDR = null, 
			int? m3SCHH = null, 
			string m3APIP = null, 
			int? m3DESE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Select",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHGR))
				throw new ArgumentNullException(nameof(m3WHGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FSTS))
				request.WithQueryParameter("FSTS", m3FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTS))
				request.WithQueryParameter("TSTS", m3TSTS.Trim());
			if (m3DEDR.HasValue)
				request.WithQueryParameter("DEDR", m3DEDR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3DESE.HasValue)
				request.WithQueryParameter("DESE", m3DESE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name SetUserJobSts
		/// Description Set update status per user
		/// Version Release: 12.2
		/// </summary>
		/// <param name="m3STA2">Status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetUserJobSts(
			string m3STA2, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetUserJobSts",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STA2))
				throw new ArgumentNullException(nameof(m3STA2));

			// Set mandatory parameters
			request
				.WithQueryParameter("STA2", m3STA2.Trim());

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
		/// Name SndInboxDOP
		/// Description Send record to DOP order inbox
		/// Version Release: 12.2
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3PLDT">Planning date (Required)</param>
		/// <param name="m3PPQT">Planned quantity (Required)</param>
		/// <param name="m3OPT2">Option (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPN">Order proposal number</param>
		/// <param name="m3PLPS">Subnumber - order proposal</param>
		/// <param name="m3PSTS">Status - planned order</param>
		/// <param name="m3FWHL">From warehouse</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3PLHM">Planning time</param>
		/// <param name="m3ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3SUBN">Sub-network mark</param>
		/// <param name="m3SUBD">Subnetwork due date</param>
		/// <param name="m3TRDY">Transportation time</param>
		/// <param name="m3TRTE">Transportation hours</param>
		/// <param name="m3MACN">Macro order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndInboxDOP(
			string m3WHLO, 
			string m3ITNO, 
			DateTime m3PLDT, 
			decimal m3PPQT, 
			int m3OPT2, 
			int? m3CONO = null, 
			int? m3PLPN = null, 
			int? m3PLPS = null, 
			int? m3PSTS = null, 
			string m3FWHL = null, 
			string m3ORTY = null, 
			int? m3RORC = null, 
			long? m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			int? m3PLHM = null, 
			decimal? m3ORQA = null, 
			int? m3SUBN = null, 
			DateTime? m3SUBD = null, 
			int? m3TRDY = null, 
			int? m3TRTE = null, 
			decimal? m3MACN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndInboxDOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("PLDT", m3PLDT.ToM3String())
				.WithQueryParameter("PPQT", m3PPQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPT2", m3OPT2.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3PLPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSTS.HasValue)
				request.WithQueryParameter("PSTS", m3PSTS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORN.HasValue)
				request.WithQueryParameter("RORN", m3RORN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLHM.HasValue)
				request.WithQueryParameter("PLHM", m3PLHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3ORQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUBN.HasValue)
				request.WithQueryParameter("SUBN", m3SUBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUBD.HasValue)
				request.WithQueryParameter("SUBD", m3SUBD.Value.ToM3String());
			if (m3TRDY.HasValue)
				request.WithQueryParameter("TRDY", m3TRDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRTE.HasValue)
				request.WithQueryParameter("TRTE", m3TRTE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MACN.HasValue)
				request.WithQueryParameter("MACN", m3MACN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name TriggerUpdJob
		/// Description Start updates processing
		/// Version Release: 12.2
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STA2">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TriggerUpdJob(
			int? m3CONO = null, 
			string m3STA2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TriggerUpdJob",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STA2))
				request.WithQueryParameter("STA2", m3STA2.Trim());

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
