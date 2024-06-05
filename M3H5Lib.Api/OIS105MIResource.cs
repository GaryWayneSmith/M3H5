/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS105MI;
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
	/// Name: OIS105MI
	/// Component Name: AdvanceInvoice
	/// Description: API: Advance invoicing
	/// Version Release: 5ea0
	///</summary>
	public partial class OIS105MIResource : M3BaseResourceEndpoint
	{
		public OIS105MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS105MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPreInvoice
		/// Description Sales Desk - Add Pre-invoice Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_IPDT">Requested invoice date</param>
		/// <param name="m3_IVAM">Invoice amount - foreign currency</param>
		/// <param name="m3_TX30">Text 1</param>
		/// <param name="m3_TX60">Text 2</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPreInvoice(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ORNO = null, 
			DateTime? m3_IPDT = null, 
			decimal? m3_IVAM = null, 
			string m3_TX30 = null, 
			string m3_TX60 = null, 
			int? m3_SEQN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPreInvoice",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_IPDT.HasValue)
				request.WithQueryParameter("IPDT", m3_IPDT.Value.ToM3String());
			if (m3_IVAM.HasValue)
				request.WithQueryParameter("IVAM", m3_IVAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

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
		/// Name CnfPreInvoice
		/// Description Sales Desk - Confirm Pre-invoice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_IPDT">Requested invoice date</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CnfPreInvoiceResponse></returns>
		/// <exception cref="M3Exception<CnfPreInvoiceResponse>"></exception>
		public async Task<M3Response<CnfPreInvoiceResponse>> CnfPreInvoice(
			int? m3_CONO = null, 
			string m3_ORNO = null, 
			DateTime? m3_IPDT = null, 
			int? m3_SEQN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CnfPreInvoice",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_IPDT.HasValue)
				request.WithQueryParameter("IPDT", m3_IPDT.Value.ToM3String());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());

			// Execute the request
			var result = await Execute<CnfPreInvoiceResponse>(
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
		/// Name GetPreInvByEXIN
		/// Description GetPreInvByEXIN
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_EXIN">Extended invoice number (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPreInvByEXINResponse></returns>
		/// <exception cref="M3Exception<GetPreInvByEXINResponse>"></exception>
		public async Task<M3Response<GetPreInvByEXINResponse>> GetPreInvByEXIN(
			string m3_EXIN, 
			int m3_YEA4, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPreInvByEXIN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EXIN))
				throw new ArgumentNullException("m3_EXIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("EXIN", m3_EXIN.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString());

			// Execute the request
			var result = await Execute<GetPreInvByEXINResponse>(
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
		/// Name GetPreInvoice
		/// Description GetPreInvoice
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_IPDT">Requested invoice date (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPreInvoiceResponse></returns>
		/// <exception cref="M3Exception<GetPreInvoiceResponse>"></exception>
		public async Task<M3Response<GetPreInvoiceResponse>> GetPreInvoice(
			string m3_ORNO, 
			DateTime m3_IPDT, 
			int m3_SEQN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPreInvoice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("IPDT", m3_IPDT.ToM3String())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Execute the request
			var result = await Execute<GetPreInvoiceResponse>(
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
		/// Name LstPreInvoice
		/// Description LstPreInvoice
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPreInvoiceResponse></returns>
		/// <exception cref="M3Exception<LstPreInvoiceResponse>"></exception>
		public async Task<M3Response<LstPreInvoiceResponse>> LstPreInvoice(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPreInvoice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Execute the request
			var result = await Execute<LstPreInvoiceResponse>(
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
