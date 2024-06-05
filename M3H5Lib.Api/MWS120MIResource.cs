/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ClrInboxPreAll
		/// Description Clear Inbox for Pre-allocations
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClrInboxPreAll(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ClrInboxPreAll",
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
		/// Name GetUserJobSts
		/// Description Get update status per user
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STA4">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUserJobStsResponse></returns>
		/// <exception cref="M3Exception<GetUserJobStsResponse>"></exception>
		public async Task<M3Response<GetUserJobStsResponse>> GetUserJobSts(
			int? m3CONO = null, 
			string m3STA4 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetUserJobSts",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STA4))
				request.WithQueryParameter("STA4", m3STA4.Trim());

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
		/// Name SelErrPreAll
		/// Description Selection of Pre-allocation not correctly updated
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelErrPreAllResponse></returns>
		/// <exception cref="M3Exception<SelErrPreAllResponse>"></exception>
		public async Task<M3Response<SelErrPreAllResponse>> SelErrPreAll(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelErrPreAll",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelErrPreAllResponse>(
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
		/// Description Select pre-allocations from MPREAL
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FWHS">From warehouse</param>
		/// <param name="m3TWHS">To warehouse</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3REOS">Read only open status (1=Yes)</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			int? m3CONO = null, 
			string m3FWHS = null, 
			string m3TWHS = null, 
			string m3WHGR = null, 
			int? m3REOS = null, 
			string m3APIP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Select",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHS))
				request.WithQueryParameter("FWHS", m3FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHS))
				request.WithQueryParameter("TWHS", m3TWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3REOS.HasValue)
				request.WithQueryParameter("REOS", m3REOS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());

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
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3STA4">Status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetUserJobSts(
			string m3STA4, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SetUserJobSts",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STA4))
				throw new ArgumentNullException(nameof(m3STA4));

			// Set mandatory parameters
			request
				.WithQueryParameter("STA4", m3STA4.Trim());

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
		/// Name SndPreAllocat
		/// Description Send pre-allocations
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3AOCA">Acquistion order category</param>
		/// <param name="m3ARDN">Acquisition order number</param>
		/// <param name="m3ARDL">Acquisition order line</param>
		/// <param name="m3ARDX">Line suffix</param>
		/// <param name="m3DOCA">Demand order category</param>
		/// <param name="m3DRDN">Demand order number</param>
		/// <param name="m3DRDL">Demand order line</param>
		/// <param name="m3DRDX">Line suffix</param>
		/// <param name="m3PQTY">Pre-allocated quantity</param>
		/// <param name="m3PQTR">Received pre-allocated quantity</param>
		/// <param name="m3ARBD">Yes/No</param>
		/// <param name="m3DRBD">Yes/No</param>
		/// <param name="m3PATY">Pre-allocation type</param>
		/// <param name="m3STSB">Pre-allocation status</param>
		/// <param name="m3OPT2">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndPreAllocat(
			int? m3CONO = null, 
			string m3WHLO = null, 
			string m3ITNO = null, 
			string m3AOCA = null, 
			string m3ARDN = null, 
			int? m3ARDL = null, 
			int? m3ARDX = null, 
			string m3DOCA = null, 
			string m3DRDN = null, 
			int? m3DRDL = null, 
			int? m3DRDX = null, 
			decimal? m3PQTY = null, 
			decimal? m3PQTR = null, 
			int? m3ARBD = null, 
			int? m3DRBD = null, 
			string m3PATY = null, 
			string m3STSB = null, 
			string m3OPT2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndPreAllocat",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOCA))
				request.WithQueryParameter("AOCA", m3AOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARDN))
				request.WithQueryParameter("ARDN", m3ARDN.Trim());
			if (m3ARDL.HasValue)
				request.WithQueryParameter("ARDL", m3ARDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARDX.HasValue)
				request.WithQueryParameter("ARDX", m3ARDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DOCA))
				request.WithQueryParameter("DOCA", m3DOCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3DRDN))
				request.WithQueryParameter("DRDN", m3DRDN.Trim());
			if (m3DRDL.HasValue)
				request.WithQueryParameter("DRDL", m3DRDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DRDX.HasValue)
				request.WithQueryParameter("DRDX", m3DRDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PQTY.HasValue)
				request.WithQueryParameter("PQTY", m3PQTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PQTR.HasValue)
				request.WithQueryParameter("PQTR", m3PQTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARBD.HasValue)
				request.WithQueryParameter("ARBD", m3ARBD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DRBD.HasValue)
				request.WithQueryParameter("DRBD", m3DRBD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PATY))
				request.WithQueryParameter("PATY", m3PATY.Trim());
			if (!string.IsNullOrWhiteSpace(m3STSB))
				request.WithQueryParameter("STSB", m3STSB.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPT2))
				request.WithQueryParameter("OPT2", m3OPT2.Trim());

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
		/// Description Starts updates processing
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STA4">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TriggerUpdJob(
			int? m3CONO = null, 
			string m3STA4 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/TriggerUpdJob",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STA4))
				request.WithQueryParameter("STA4", m3STA4.Trim());

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
