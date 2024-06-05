/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_VRUN">VAT run</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadInfoResponse></returns>
		/// <exception cref="M3Exception<GetHeadInfoResponse>"></exception>
		public async Task<M3Response<GetHeadInfoResponse>> GetHeadInfo(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_VRUN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRUN))
				request.WithQueryParameter("VRUN", m3_VRUN.Trim());

			// Execute the request
			var result = await Execute<GetHeadInfoResponse>(
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
		/// Name GetVATRunID
		/// Description GetVATRunID: Returns the keys for a VAT run
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_UK01">Primary key 1</param>
		/// <param name="m3_UK02">Primary key 2</param>
		/// <param name="m3_UK03">Primary key 3</param>
		/// <param name="m3_UK04">Primary key 4</param>
		/// <param name="m3_UK05">Primary key 5</param>
		/// <param name="m3_UK06">Primary key 6</param>
		/// <param name="m3_UK07">Primary key 7</param>
		/// <param name="m3_UK08">Primary key 8</param>
		/// <param name="m3_UK09">Primary key 9</param>
		/// <param name="m3_UK10">Primary key 10</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetVATRunIDResponse></returns>
		/// <exception cref="M3Exception<GetVATRunIDResponse>"></exception>
		public async Task<M3Response<GetVATRunIDResponse>> GetVATRunID(
			string m3_UK01 = null, 
			string m3_UK02 = null, 
			string m3_UK03 = null, 
			string m3_UK04 = null, 
			string m3_UK05 = null, 
			string m3_UK06 = null, 
			string m3_UK07 = null, 
			string m3_UK08 = null, 
			string m3_UK09 = null, 
			string m3_UK10 = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_UK01))
				request.WithQueryParameter("UK01", m3_UK01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK02))
				request.WithQueryParameter("UK02", m3_UK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK03))
				request.WithQueryParameter("UK03", m3_UK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK04))
				request.WithQueryParameter("UK04", m3_UK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK05))
				request.WithQueryParameter("UK05", m3_UK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK06))
				request.WithQueryParameter("UK06", m3_UK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK07))
				request.WithQueryParameter("UK07", m3_UK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK08))
				request.WithQueryParameter("UK08", m3_UK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK09))
				request.WithQueryParameter("UK09", m3_UK09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK10))
				request.WithQueryParameter("UK10", m3_UK10.Trim());

			// Execute the request
			var result = await Execute<GetVATRunIDResponse>(
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
		/// Name LstVATDetails
		/// Description List Electronic VAT report details
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_VRUN">VAT run</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVATDetailsResponse></returns>
		/// <exception cref="M3Exception<LstVATDetailsResponse>"></exception>
		public async Task<M3Response<LstVATDetailsResponse>> LstVATDetails(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_VRUN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRUN))
				request.WithQueryParameter("VRUN", m3_VRUN.Trim());

			// Execute the request
			var result = await Execute<LstVATDetailsResponse>(
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
		/// Name LstVATInvPerLn
		/// Description List Electronic VAT report details per Line no and Invoice
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_VRUN">VAT run (Required)</param>
		/// <param name="m3_VRLN">VAT report line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVATInvPerLnResponse></returns>
		/// <exception cref="M3Exception<LstVATInvPerLnResponse>"></exception>
		public async Task<M3Response<LstVATInvPerLnResponse>> LstVATInvPerLn(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_VRUN, 
			int? m3_VRLN = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_VRUN))
				throw new ArgumentNullException("m3_VRUN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("VRUN", m3_VRUN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_VRLN.HasValue)
				request.WithQueryParameter("VRLN", m3_VRLN.Value.ToString());

			// Execute the request
			var result = await Execute<LstVATInvPerLnResponse>(
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
		/// Name LstVATInvoice
		/// Description List Electronic VAT report details per Cust/Suppl Invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_VRUN">VAT run</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVATInvoiceResponse></returns>
		/// <exception cref="M3Exception<LstVATInvoiceResponse>"></exception>
		public async Task<M3Response<LstVATInvoiceResponse>> LstVATInvoice(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_VRUN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRUN))
				request.WithQueryParameter("VRUN", m3_VRUN.Trim());

			// Execute the request
			var result = await Execute<LstVATInvoiceResponse>(
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
		/// Name LstVATLine
		/// Description List a Electronic VAT report line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_VRUN">VAT run</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVATLineResponse></returns>
		/// <exception cref="M3Exception<LstVATLineResponse>"></exception>
		public async Task<M3Response<LstVATLineResponse>> LstVATLine(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_VRUN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRUN))
				request.WithQueryParameter("VRUN", m3_VRUN.Trim());

			// Execute the request
			var result = await Execute<LstVATLineResponse>(
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
		/// Name LstVATUserDef
		/// Description LstVATUserDef
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_VRUN">VAT run</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstVATUserDefResponse></returns>
		/// <exception cref="M3Exception<LstVATUserDefResponse>"></exception>
		public async Task<M3Response<LstVATUserDefResponse>> LstVATUserDef(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_VRUN = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRUN))
				request.WithQueryParameter("VRUN", m3_VRUN.Trim());

			// Execute the request
			var result = await Execute<LstVATUserDefResponse>(
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
		/// Name UpdStatusHead
		/// Description Update status for the VAT run header
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_VRUN">VAT run</param>
		/// <param name="m3_EVRS">Electronic VAT report - status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatusHead(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_VRUN = null, 
			int? m3_EVRS = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRUN))
				request.WithQueryParameter("VRUN", m3_VRUN.Trim());
			if (m3_EVRS.HasValue)
				request.WithQueryParameter("EVRS", m3_EVRS.Value.ToString());

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
		/// Name UpdStatusLine
		/// Description Update the status and error code for a line
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_VRUN">VAT run</param>
		/// <param name="m3_UK01">Primary key 1</param>
		/// <param name="m3_UK02">Primary key 2</param>
		/// <param name="m3_UK03">Primary key 3</param>
		/// <param name="m3_UK04">Primary key 4</param>
		/// <param name="m3_UK05">Primary key 5</param>
		/// <param name="m3_UK06">Primary key 6</param>
		/// <param name="m3_UK07">Primary key 7</param>
		/// <param name="m3_UK08">Primary key 8</param>
		/// <param name="m3_UK09">Primary key 9</param>
		/// <param name="m3_UK10">Primary key 10</param>
		/// <param name="m3_OLST">Status online VAT transaction</param>
		/// <param name="m3_OLER">Error code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatusLine(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_VRUN = null, 
			string m3_UK01 = null, 
			string m3_UK02 = null, 
			string m3_UK03 = null, 
			string m3_UK04 = null, 
			string m3_UK05 = null, 
			string m3_UK06 = null, 
			string m3_UK07 = null, 
			string m3_UK08 = null, 
			string m3_UK09 = null, 
			string m3_UK10 = null, 
			string m3_OLST = null, 
			string m3_OLER = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRUN))
				request.WithQueryParameter("VRUN", m3_VRUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK01))
				request.WithQueryParameter("UK01", m3_UK01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK02))
				request.WithQueryParameter("UK02", m3_UK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK03))
				request.WithQueryParameter("UK03", m3_UK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK04))
				request.WithQueryParameter("UK04", m3_UK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK05))
				request.WithQueryParameter("UK05", m3_UK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK06))
				request.WithQueryParameter("UK06", m3_UK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK07))
				request.WithQueryParameter("UK07", m3_UK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK08))
				request.WithQueryParameter("UK08", m3_UK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK09))
				request.WithQueryParameter("UK09", m3_UK09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UK10))
				request.WithQueryParameter("UK10", m3_UK10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OLST))
				request.WithQueryParameter("OLST", m3_OLST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OLER))
				request.WithQueryParameter("OLER", m3_OLER.Trim());

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
