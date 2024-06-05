/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.OIS350MI;
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
	/// Name: OIS350MI
	/// Component Name: CustomerOrderInvoice
	/// Description: Customer Order invoice interface
	/// Version Release: 5ea2
	///</summary>
	public partial class OIS350MIResource : M3BaseResourceEndpoint
	{
		public OIS350MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS350MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetCashDiscount
		/// Description GetCashDiscount
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3IVNO">Invoice number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3INPX">Invoice prefix</param>
		/// <param name="m3EXIN">Extended invoice number</param>
		/// <param name="m3TECD">Cash discount term</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCashDiscountResponse></returns>
		/// <exception cref="M3Exception<GetCashDiscountResponse>"></exception>
		public async Task<M3Response<GetCashDiscountResponse>> GetCashDiscount(
			int m3YEA4, 
			int m3IVNO, 
			string m3DIVI = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
			string m3TECD = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCashDiscount",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IVNO", m3IVNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECD))
				request.WithQueryParameter("TECD", m3TECD.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetCashDiscountResponse>(
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
		/// Name GetDelHead
		/// Description Retrieve Delivery Head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3TEPY">Payment terms (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelHeadResponse></returns>
		/// <exception cref="M3Exception<GetDelHeadResponse>"></exception>
		public async Task<M3Response<GetDelHeadResponse>> GetDelHead(
			string m3ORNO, 
			string m3WHLO, 
			decimal m3DLIX, 
			string m3TEPY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDelHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3TEPY))
				throw new ArgumentNullException(nameof(m3TEPY));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TEPY", m3TEPY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDelHeadResponse>(
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
		/// Name GetDelLine
		/// Description Retrieve Delivery Line
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3TEPY">Payment terms (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDelLineResponse></returns>
		/// <exception cref="M3Exception<GetDelLineResponse>"></exception>
		public async Task<M3Response<GetDelLineResponse>> GetDelLine(
			string m3ORNO, 
			decimal m3DLIX, 
			string m3WHLO, 
			int m3PONR, 
			int m3POSX, 
			string m3TEPY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDelLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3TEPY))
				throw new ArgumentNullException(nameof(m3TEPY));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TEPY", m3TEPY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDelLineResponse>(
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
		/// Name GetInvHead
		/// Description Retrieve Invoice Head
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3IVNO">Invoice number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3INPX">Invoice Prefix</param>
		/// <param name="m3EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvHeadResponse></returns>
		/// <exception cref="M3Exception<GetInvHeadResponse>"></exception>
		public async Task<M3Response<GetInvHeadResponse>> GetInvHead(
			int m3YEA4, 
			int m3IVNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetInvHead",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IVNO", m3IVNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());

			// Execute the request
			var result = await Execute<GetInvHeadResponse>(
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
		/// Name GetInvLine
		/// Description Retrieve Invoice Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3IVNO">Invoice number (Required)</param>
		/// <param name="m3IVTP">Information type (Required)</param>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3IVRF">Invoice reference (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3INPX">Invoice Prefix</param>
		/// <param name="m3EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvLineResponse></returns>
		/// <exception cref="M3Exception<GetInvLineResponse>"></exception>
		public async Task<M3Response<GetInvLineResponse>> GetInvLine(
			string m3DIVI, 
			int m3YEA4, 
			int m3IVNO, 
			string m3IVTP, 
			string m3ORNO, 
			decimal m3DLIX, 
			string m3WHLO, 
			string m3IVRF, 
			int? m3CONO = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetInvLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3IVTP))
				throw new ArgumentNullException(nameof(m3IVTP));
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3IVRF))
				throw new ArgumentNullException(nameof(m3IVRF));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IVNO", m3IVNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IVTP", m3IVTP.Trim())
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("IVRF", m3IVRF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());

			// Execute the request
			var result = await Execute<GetInvLineResponse>(
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
		/// Name LstAllInvByCO
		/// Description List all invoice for a customer order
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAllInvByCOResponse></returns>
		/// <exception cref="M3Exception<LstAllInvByCOResponse>"></exception>
		public async Task<M3Response<LstAllInvByCOResponse>> LstAllInvByCO(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAllInvByCO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAllInvByCOResponse>(
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
		/// Name LstDelHeadByInv
		/// Description List Delivery Head By Invoices
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3IVNO">Invoice number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3INPX">Invoice Prefix</param>
		/// <param name="m3EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelHeadByInvResponse></returns>
		/// <exception cref="M3Exception<LstDelHeadByInvResponse>"></exception>
		public async Task<M3Response<LstDelHeadByInvResponse>> LstDelHeadByInv(
			int m3YEA4, 
			int m3IVNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDelHeadByInv",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IVNO", m3IVNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());

			// Execute the request
			var result = await Execute<LstDelHeadByInvResponse>(
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
		/// Name LstDelLine
		/// Description List Delivery Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3TEPY">Payment terms (Required)</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDelLineResponse></returns>
		/// <exception cref="M3Exception<LstDelLineResponse>"></exception>
		public async Task<M3Response<LstDelLineResponse>> LstDelLine(
			int m3CONO, 
			string m3ORNO, 
			decimal m3DLIX, 
			string m3WHLO, 
			string m3TEPY, 
			int? m3PONR = null, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDelLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3TEPY))
				throw new ArgumentNullException(nameof(m3TEPY));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("TEPY", m3TEPY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDelLineResponse>(
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
		/// Name LstInvByCOLine
		/// Description List Invoice Head Per Customer Order Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvByCOLineResponse></returns>
		/// <exception cref="M3Exception<LstInvByCOLineResponse>"></exception>
		public async Task<M3Response<LstInvByCOLineResponse>> LstInvByCOLine(
			string m3ORNO, 
			int m3PONR, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvByCOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstInvByCOLineResponse>(
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
		/// Name LstInvHead
		/// Description List Invoice Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3IVNO">Invoice number</param>
		/// <param name="m3INPX">Invoice Prefix</param>
		/// <param name="m3EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvHeadResponse></returns>
		/// <exception cref="M3Exception<LstInvHeadResponse>"></exception>
		public async Task<M3Response<LstInvHeadResponse>> LstInvHead(
			int m3YEA4, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3IVNO = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvHead",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3IVNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());

			// Execute the request
			var result = await Execute<LstInvHeadResponse>(
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
		/// Name LstInvHeadByCo
		/// Description List Invoice Head by Customer Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3OOIN">Only open invoices</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvHeadByCoResponse></returns>
		/// <exception cref="M3Exception<LstInvHeadByCoResponse>"></exception>
		public async Task<M3Response<LstInvHeadByCoResponse>> LstInvHeadByCo(
			string m3ORNO, 
			int? m3CONO = null, 
			string m3WHLO = null, 
			decimal? m3DLIX = null, 
			string m3OOIN = null, 
			string m3TEPY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvHeadByCo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OOIN))
				request.WithQueryParameter("OOIN", m3OOIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());

			// Execute the request
			var result = await Execute<LstInvHeadByCoResponse>(
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
		/// Name LstInvHeadByDel
		/// Description List Invoice Head Per Delivery Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvHeadByDelResponse></returns>
		/// <exception cref="M3Exception<LstInvHeadByDelResponse>"></exception>
		public async Task<M3Response<LstInvHeadByDelResponse>> LstInvHeadByDel(
			string m3ORNO, 
			string m3WHLO, 
			decimal m3DLIX, 
			int m3PONR, 
			int? m3POSX = null, 
			string m3TEPY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvHeadByDel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());

			// Execute the request
			var result = await Execute<LstInvHeadByDelResponse>(
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
		/// Name LstInvHeadByPay
		/// Description List Invoice Head by Payer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3IVNO">Invoice number</param>
		/// <param name="m3OOIN">Only open invoices</param>
		/// <param name="m3INPX">Invoice Prefix</param>
		/// <param name="m3EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvHeadByPayResponse></returns>
		/// <exception cref="M3Exception<LstInvHeadByPayResponse>"></exception>
		public async Task<M3Response<LstInvHeadByPayResponse>> LstInvHeadByPay(
			int m3YEA4, 
			string m3PYNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3IVNO = null, 
			int? m3OOIN = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvHeadByPay",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PYNO", m3PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3IVNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OOIN.HasValue)
				request.WithQueryParameter("OOIN", m3OOIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());

			// Execute the request
			var result = await Execute<LstInvHeadByPayResponse>(
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
		/// Name LstInvLine
		/// Description List Invoice Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3IVNO">Invoice number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3INPX">Invoice Prefix</param>
		/// <param name="m3EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvLineResponse></returns>
		/// <exception cref="M3Exception<LstInvLineResponse>"></exception>
		public async Task<M3Response<LstInvLineResponse>> LstInvLine(
			int m3YEA4, 
			int m3IVNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvLine",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IVNO", m3IVNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());

			// Execute the request
			var result = await Execute<LstInvLineResponse>(
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
		/// Name LstInvLineByTyp
		/// Description List Invoice Line By Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3IVNO">Invoice number (Required)</param>
		/// <param name="m3IVTP">Information type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3INPX">Invoice Prefix</param>
		/// <param name="m3EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvLineByTypResponse></returns>
		/// <exception cref="M3Exception<LstInvLineByTypResponse>"></exception>
		public async Task<M3Response<LstInvLineByTypResponse>> LstInvLineByTyp(
			int m3YEA4, 
			int m3IVNO, 
			string m3IVTP, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInvLineByTyp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IVTP))
				throw new ArgumentNullException(nameof(m3IVTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IVNO", m3IVNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IVTP", m3IVTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());

			// Execute the request
			var result = await Execute<LstInvLineByTypResponse>(
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
		/// Name LstTxExmpTxtVAT
		/// Description List Tax Exemption Text per VAT code
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3IVNO">Invoice number (Required)</param>
		/// <param name="m3VTCD">VAT code (Required)</param>
		/// <param name="m3FTCO">From/to country (Required)</param>
		/// <param name="m3BSCD">Base country (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3INPX">Invoice prefix</param>
		/// <param name="m3EXIN">Extended invoice number</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTxExmpTxtVATResponse></returns>
		/// <exception cref="M3Exception<LstTxExmpTxtVATResponse>"></exception>
		public async Task<M3Response<LstTxExmpTxtVATResponse>> LstTxExmpTxtVAT(
			int m3YEA4, 
			int m3IVNO, 
			int m3VTCD, 
			string m3FTCO, 
			string m3BSCD, 
			string m3DIVI = null, 
			string m3INPX = null, 
			string m3EXIN = null, 
			string m3ECAR = null, 
			string m3VRNO = null, 
			string m3ORNO = null, 
			string m3WHLO = null, 
			decimal? m3DLIX = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTxExmpTxtVAT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FTCO))
				throw new ArgumentNullException(nameof(m3FTCO));
			if (string.IsNullOrWhiteSpace(m3BSCD))
				throw new ArgumentNullException(nameof(m3BSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IVNO", m3IVNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VTCD", m3VTCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FTCO", m3FTCO.Trim())
				.WithQueryParameter("BSCD", m3BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXIN))
				request.WithQueryParameter("EXIN", m3EXIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstTxExmpTxtVATResponse>(
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
		/// Name UpdInvCDS
		/// Description Update invoice to cash desk sale
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3EXIN">Extended Invoice Number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3IVNO">Invoice number</param>
		/// <param name="m3INPX">Invoice Prefix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdInvCDS(
			int m3YEA4, 
			string m3EXIN, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3IVNO = null, 
			string m3INPX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdInvCDS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EXIN))
				throw new ArgumentNullException(nameof(m3EXIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("EXIN", m3EXIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3IVNO.HasValue)
				request.WithQueryParameter("IVNO", m3IVNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INPX))
				request.WithQueryParameter("INPX", m3INPX.Trim());

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
