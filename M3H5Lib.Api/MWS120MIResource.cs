/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS120MI;
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
	/// Name: MWS120MI
	/// Component Name: Pre-allocations
	/// Description: Pre-allocations interface
	/// Version Release: 12.3
	///</summary>
	public partial class MWS120MIResource : M3BaseResourceEndpoint
	{
		public MWS120MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS120MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ClrInboxPreAll
		/// Description Clear Inbox for Pre-allocations
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClrInboxPreAll(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClrInboxPreAll",
			};

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
		/// Name GetUserJobSts
		/// Description Get update status per user
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STA4">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUserJobStsResponse></returns>
		/// <exception cref="M3Exception<GetUserJobStsResponse>"></exception>
		public async Task<M3Response<GetUserJobStsResponse>> GetUserJobSts(
			int? m3_CONO = null, 
			string m3_STA4 = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STA4))
				request.WithQueryParameter("STA4", m3_STA4.Trim());

			// Execute the request
			var result = await Execute<GetUserJobStsResponse>(
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
		/// Name SelErrPreAll
		/// Description Selection of Pre-allocation not correctly updated
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelErrPreAllResponse></returns>
		/// <exception cref="M3Exception<SelErrPreAllResponse>"></exception>
		public async Task<M3Response<SelErrPreAllResponse>> SelErrPreAll(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelErrPreAll",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<SelErrPreAllResponse>(
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
		/// Name Select
		/// Description Select pre-allocations from MPREAL
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FWHS">From warehouse</param>
		/// <param name="m3_TWHS">To warehouse</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_REOS">Read only open status (1=Yes)</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			int? m3_CONO = null, 
			string m3_FWHS = null, 
			string m3_TWHS = null, 
			string m3_WHGR = null, 
			int? m3_REOS = null, 
			string m3_APIP = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWHS))
				request.WithQueryParameter("FWHS", m3_FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHS))
				request.WithQueryParameter("TWHS", m3_TWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (m3_REOS.HasValue)
				request.WithQueryParameter("REOS", m3_REOS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name SetUserJobSts
		/// Description Set update status per user
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_STA4">Status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetUserJobSts(
			string m3_STA4, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetUserJobSts",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STA4))
				throw new ArgumentNullException("m3_STA4");

			// Set mandatory parameters
			request
				.WithQueryParameter("STA4", m3_STA4.Trim());

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
		/// Name SndPreAllocat
		/// Description Send pre-allocations
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_AOCA">Acquistion order category</param>
		/// <param name="m3_ARDN">Acquisition order number</param>
		/// <param name="m3_ARDL">Acquisition order line</param>
		/// <param name="m3_ARDX">Line suffix</param>
		/// <param name="m3_DOCA">Demand order category</param>
		/// <param name="m3_DRDN">Demand order number</param>
		/// <param name="m3_DRDL">Demand order line</param>
		/// <param name="m3_DRDX">Line suffix</param>
		/// <param name="m3_PQTY">Pre-allocated quantity</param>
		/// <param name="m3_PQTR">Received pre-allocated quantity</param>
		/// <param name="m3_ARBD">Yes/No</param>
		/// <param name="m3_DRBD">Yes/No</param>
		/// <param name="m3_PATY">Pre-allocation type</param>
		/// <param name="m3_STSB">Pre-allocation status</param>
		/// <param name="m3_OPT2">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndPreAllocat(
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			string m3_ITNO = null, 
			string m3_AOCA = null, 
			string m3_ARDN = null, 
			int? m3_ARDL = null, 
			int? m3_ARDX = null, 
			string m3_DOCA = null, 
			string m3_DRDN = null, 
			int? m3_DRDL = null, 
			int? m3_DRDX = null, 
			decimal? m3_PQTY = null, 
			decimal? m3_PQTR = null, 
			int? m3_ARBD = null, 
			int? m3_DRBD = null, 
			string m3_PATY = null, 
			string m3_STSB = null, 
			string m3_OPT2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndPreAllocat",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOCA))
				request.WithQueryParameter("AOCA", m3_AOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARDN))
				request.WithQueryParameter("ARDN", m3_ARDN.Trim());
			if (m3_ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3_ARDL.Value.ToString());
			if (m3_ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3_ARDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DOCA))
				request.WithQueryParameter("DOCA", m3_DOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DRDN))
				request.WithQueryParameter("DRDN", m3_DRDN.Trim());
			if (m3_DRDL.HasValue)
				request.WithQueryParameter("DRDL", m3_DRDL.Value.ToString());
			if (m3_DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3_DRDX.Value.ToString());
			if (m3_PQTY.HasValue)
				request.WithQueryParameter("PQTY", m3_PQTY.Value.ToString());
			if (m3_PQTR.HasValue)
				request.WithQueryParameter("PQTR", m3_PQTR.Value.ToString());
			if (m3_ARBD.HasValue)
				request.WithQueryParameter("ARBD", m3_ARBD.Value.ToString());
			if (m3_DRBD.HasValue)
				request.WithQueryParameter("DRBD", m3_DRBD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PATY))
				request.WithQueryParameter("PATY", m3_PATY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STSB))
				request.WithQueryParameter("STSB", m3_STSB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPT2))
				request.WithQueryParameter("OPT2", m3_OPT2.Trim());

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
		/// Name TriggerUpdJob
		/// Description Starts updates processing
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STA4">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TriggerUpdJob(
			int? m3_CONO = null, 
			string m3_STA4 = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STA4))
				request.WithQueryParameter("STA4", m3_STA4.Trim());

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
