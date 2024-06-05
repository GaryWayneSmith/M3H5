/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.TXS100MI;
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
	/// Name: TXS100MI
	/// Component Name: ElectronicVATReport
	/// Description: Api: Electronic VAT report
	/// Version Release: 5ea3
	///</summary>
	public partial class TXS100MIResource : M3BaseResourceEndpoint
	{
		public TXS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "TXS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetHeadInfo
		/// Description Get header information
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3VRUN">VAT run</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadInfoResponse></returns>
		/// <exception cref="M3Exception<GetHeadInfoResponse>"></exception>
		public async Task<M3Response<GetHeadInfoResponse>> GetHeadInfo(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3VRUN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRUN))
				request.WithQueryParameter("VRUN", m3VRUN.Trim());

			// Execute the request
			var result = await Execute<GetHeadInfoResponse>(
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
		/// Name GetVATRunID
		/// Description GetVATRunID: Returns the keys for a VAT run
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3UK01">Primary key 1</param>
		/// <param name="m3UK02">Primary key 2</param>
		/// <param name="m3UK03">Primary key 3</param>
		/// <param name="m3UK04">Primary key 4</param>
		/// <param name="m3UK05">Primary key 5</param>
		/// <param name="m3UK06">Primary key 6</param>
		/// <param name="m3UK07">Primary key 7</param>
		/// <param name="m3UK08">Primary key 8</param>
		/// <param name="m3UK09">Primary key 9</param>
		/// <param name="m3UK10">Primary key 10</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetVATRunIDResponse></returns>
		/// <exception cref="M3Exception<GetVATRunIDResponse>"></exception>
		public async Task<M3Response<GetVATRunIDResponse>> GetVATRunID(
			string m3UK01 = null, 
			string m3UK02 = null, 
			string m3UK03 = null, 
			string m3UK04 = null, 
			string m3UK05 = null, 
			string m3UK06 = null, 
			string m3UK07 = null, 
			string m3UK08 = null, 
			string m3UK09 = null, 
			string m3UK10 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetVATRunID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3UK01))
				request.WithQueryParameter("UK01", m3UK01.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK02))
				request.WithQueryParameter("UK02", m3UK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK03))
				request.WithQueryParameter("UK03", m3UK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK04))
				request.WithQueryParameter("UK04", m3UK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK05))
				request.WithQueryParameter("UK05", m3UK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK06))
				request.WithQueryParameter("UK06", m3UK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK07))
				request.WithQueryParameter("UK07", m3UK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK08))
				request.WithQueryParameter("UK08", m3UK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK09))
				request.WithQueryParameter("UK09", m3UK09.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK10))
				request.WithQueryParameter("UK10", m3UK10.Trim());

			// Execute the request
			var result = await Execute<GetVATRunIDResponse>(
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
		/// Name LstVATDetails
		/// Description List Electronic VAT report details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3VRUN">VAT run</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVATDetailsResponse></returns>
		/// <exception cref="M3Exception<LstVATDetailsResponse>"></exception>
		public async Task<M3Response<LstVATDetailsResponse>> LstVATDetails(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3VRUN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstVATDetails",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRUN))
				request.WithQueryParameter("VRUN", m3VRUN.Trim());

			// Execute the request
			var result = await Execute<LstVATDetailsResponse>(
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
		/// Name LstVATInvPerLn
		/// Description List Electronic VAT report details per Line no and Invoice
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3VRUN">VAT run (Required)</param>
		/// <param name="m3VRLN">VAT report line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVATInvPerLnResponse></returns>
		/// <exception cref="M3Exception<LstVATInvPerLnResponse>"></exception>
		public async Task<M3Response<LstVATInvPerLnResponse>> LstVATInvPerLn(
			int m3CONO, 
			string m3DIVI, 
			string m3VRUN, 
			int? m3VRLN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstVATInvPerLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3VRUN))
				throw new ArgumentNullException(nameof(m3VRUN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("VRUN", m3VRUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3VRLN.HasValue)
				request.WithQueryParameter("VRLN", m3VRLN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstVATInvPerLnResponse>(
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
		/// Name LstVATInvoice
		/// Description List Electronic VAT report details per Cust/Suppl Invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3VRUN">VAT run</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVATInvoiceResponse></returns>
		/// <exception cref="M3Exception<LstVATInvoiceResponse>"></exception>
		public async Task<M3Response<LstVATInvoiceResponse>> LstVATInvoice(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3VRUN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstVATInvoice",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRUN))
				request.WithQueryParameter("VRUN", m3VRUN.Trim());

			// Execute the request
			var result = await Execute<LstVATInvoiceResponse>(
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
		/// Name LstVATLine
		/// Description List a Electronic VAT report line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3VRUN">VAT run</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVATLineResponse></returns>
		/// <exception cref="M3Exception<LstVATLineResponse>"></exception>
		public async Task<M3Response<LstVATLineResponse>> LstVATLine(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3VRUN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstVATLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRUN))
				request.WithQueryParameter("VRUN", m3VRUN.Trim());

			// Execute the request
			var result = await Execute<LstVATLineResponse>(
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
		/// Name LstVATUserDef
		/// Description LstVATUserDef
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3VRUN">VAT run</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVATUserDefResponse></returns>
		/// <exception cref="M3Exception<LstVATUserDefResponse>"></exception>
		public async Task<M3Response<LstVATUserDefResponse>> LstVATUserDef(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3VRUN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstVATUserDef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRUN))
				request.WithQueryParameter("VRUN", m3VRUN.Trim());

			// Execute the request
			var result = await Execute<LstVATUserDefResponse>(
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
		/// Name UpdStatusHead
		/// Description Update status for the VAT run header
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3VRUN">VAT run</param>
		/// <param name="m3EVRS">Electronic VAT report - status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatusHead(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3VRUN = null, 
			int? m3EVRS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStatusHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRUN))
				request.WithQueryParameter("VRUN", m3VRUN.Trim());
			if (m3EVRS.HasValue)
				request.WithQueryParameter("EVRS", m3EVRS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdStatusLine
		/// Description Update the status and error code for a line
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3VRUN">VAT run</param>
		/// <param name="m3UK01">Primary key 1</param>
		/// <param name="m3UK02">Primary key 2</param>
		/// <param name="m3UK03">Primary key 3</param>
		/// <param name="m3UK04">Primary key 4</param>
		/// <param name="m3UK05">Primary key 5</param>
		/// <param name="m3UK06">Primary key 6</param>
		/// <param name="m3UK07">Primary key 7</param>
		/// <param name="m3UK08">Primary key 8</param>
		/// <param name="m3UK09">Primary key 9</param>
		/// <param name="m3UK10">Primary key 10</param>
		/// <param name="m3OLST">Status online VAT transaction</param>
		/// <param name="m3OLER">Error code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatusLine(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3VRUN = null, 
			string m3UK01 = null, 
			string m3UK02 = null, 
			string m3UK03 = null, 
			string m3UK04 = null, 
			string m3UK05 = null, 
			string m3UK06 = null, 
			string m3UK07 = null, 
			string m3UK08 = null, 
			string m3UK09 = null, 
			string m3UK10 = null, 
			string m3OLST = null, 
			string m3OLER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStatusLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRUN))
				request.WithQueryParameter("VRUN", m3VRUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK01))
				request.WithQueryParameter("UK01", m3UK01.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK02))
				request.WithQueryParameter("UK02", m3UK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK03))
				request.WithQueryParameter("UK03", m3UK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK04))
				request.WithQueryParameter("UK04", m3UK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK05))
				request.WithQueryParameter("UK05", m3UK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK06))
				request.WithQueryParameter("UK06", m3UK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK07))
				request.WithQueryParameter("UK07", m3UK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK08))
				request.WithQueryParameter("UK08", m3UK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK09))
				request.WithQueryParameter("UK09", m3UK09.Trim());
			if (!string.IsNullOrWhiteSpace(m3UK10))
				request.WithQueryParameter("UK10", m3UK10.Trim());
			if (!string.IsNullOrWhiteSpace(m3OLST))
				request.WithQueryParameter("OLST", m3OLST.Trim());
			if (!string.IsNullOrWhiteSpace(m3OLER))
				request.WithQueryParameter("OLER", m3OLER.Trim());

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
