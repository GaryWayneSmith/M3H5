/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.OIS850MI;
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
	/// Name: OIS850MI
	/// Component Name: InitSupplyOrder
	/// Description: Initial Supply Orders
	/// Version Release: 15.0
	///</summary>
	public partial class OIS850MIResource : M3BaseResourceEndpoint
	{
		public OIS850MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS850MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Alloc
		/// Description Allocate CO
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3INOT">Initial order type (Required)</param>
		/// <param name="m3INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3DOCA">Demand order category (Required)</param>
		/// <param name="m3DRDN">Demand order number (Required)</param>
		/// <param name="m3DRDL">Demand order line (Required)</param>
		/// <param name="m3DRDX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Alloc(
			string m3DIVI, 
			int m3INOT, 
			string m3INOQ, 
			string m3DOCA, 
			string m3DRDN, 
			int m3DRDL, 
			int m3DRDX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Alloc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3INOQ))
				throw new ArgumentNullException(nameof(m3INOQ));
			if (string.IsNullOrWhiteSpace(m3DOCA))
				throw new ArgumentNullException(nameof(m3DOCA));
			if (string.IsNullOrWhiteSpace(m3DRDN))
				throw new ArgumentNullException(nameof(m3DRDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("INOT", m3INOT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INOQ", m3INOQ.Trim())
				.WithQueryParameter("DOCA", m3DOCA.Trim())
				.WithQueryParameter("DRDN", m3DRDN.Trim())
				.WithQueryParameter("DRDL", m3DRDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DRDX", m3DRDX.ToString(CultureInfo.CurrentCulture));

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
		/// Name Close
		/// Description Close an initial order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3INOT">Initial order type (Required)</param>
		/// <param name="m3INOQ">Initial order qualifier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Close(
			string m3DIVI, 
			int m3INOT, 
			string m3INOQ, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Close",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3INOQ))
				throw new ArgumentNullException(nameof(m3INOQ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("INOT", m3INOT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INOQ", m3INOQ.Trim());

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
		/// Name DeAlloc
		/// Description Deallocate CO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3INOT">Initial order type (Required)</param>
		/// <param name="m3INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3DOCA">Demand order category (Required)</param>
		/// <param name="m3DRDN">Demand order number (Required)</param>
		/// <param name="m3DRDL">Demand order line (Required)</param>
		/// <param name="m3DRDX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeAlloc(
			string m3DIVI, 
			int m3INOT, 
			string m3INOQ, 
			string m3DOCA, 
			string m3DRDN, 
			int m3DRDL, 
			int m3DRDX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeAlloc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3INOQ))
				throw new ArgumentNullException(nameof(m3INOQ));
			if (string.IsNullOrWhiteSpace(m3DOCA))
				throw new ArgumentNullException(nameof(m3DOCA));
			if (string.IsNullOrWhiteSpace(m3DRDN))
				throw new ArgumentNullException(nameof(m3DRDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("INOT", m3INOT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INOQ", m3INOQ.Trim())
				.WithQueryParameter("DOCA", m3DOCA.Trim())
				.WithQueryParameter("DRDN", m3DRDN.Trim())
				.WithQueryParameter("DRDL", m3DRDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DRDX", m3DRDX.ToString(CultureInfo.CurrentCulture));

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
		/// Name Gen
		/// Description Generate supply orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3INOT">Initial order type (Required)</param>
		/// <param name="m3INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Gen(
			string m3DIVI, 
			int m3INOT, 
			string m3INOQ, 
			string m3WHLO = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Gen",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3INOQ))
				throw new ArgumentNullException(nameof(m3INOQ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("INOT", m3INOT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INOQ", m3INOQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

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
		/// Name LstCOLines
		/// Description List CO Lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3INOT">Initial order type (Required)</param>
		/// <param name="m3INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCOLinesResponse></returns>
		/// <exception cref="M3Exception<LstCOLinesResponse>"></exception>
		public async Task<M3Response<LstCOLinesResponse>> LstCOLines(
			string m3DIVI, 
			int m3INOT, 
			string m3INOQ, 
			string m3WHLO, 
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCOLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3INOQ))
				throw new ArgumentNullException(nameof(m3INOQ));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("INOT", m3INOT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INOQ", m3INOQ.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstCOLinesResponse>(
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
		/// Name LstInitialOrder
		/// Description List Initial Orders
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3INOT">Initial order type (Required)</param>
		/// <param name="m3INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInitialOrderResponse></returns>
		/// <exception cref="M3Exception<LstInitialOrderResponse>"></exception>
		public async Task<M3Response<LstInitialOrderResponse>> LstInitialOrder(
			string m3DIVI, 
			int m3INOT, 
			string m3INOQ, 
			string m3WHLO = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstInitialOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3INOQ))
				throw new ArgumentNullException(nameof(m3INOQ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("INOT", m3INOT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INOQ", m3INOQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstInitialOrderResponse>(
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
		/// Name Rel
		/// Description Release an initial promotion for allocation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3INOT">Initial order type (Required)</param>
		/// <param name="m3INOQ">Initial order qualifier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Rel(
			string m3DIVI, 
			int m3INOT, 
			string m3INOQ, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Rel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3INOQ))
				throw new ArgumentNullException(nameof(m3INOQ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("INOT", m3INOT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INOQ", m3INOQ.Trim());

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
		/// Name Rmv
		/// Description Remove a CO line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3INOT">Initial order type (Required)</param>
		/// <param name="m3INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3DOCA">Demand order category (Required)</param>
		/// <param name="m3DRDN">Demand order number (Required)</param>
		/// <param name="m3DRDL">Demand order line (Required)</param>
		/// <param name="m3DRDX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Rmv(
			string m3DIVI, 
			int m3INOT, 
			string m3INOQ, 
			string m3DOCA, 
			string m3DRDN, 
			int m3DRDL, 
			int m3DRDX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Rmv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3INOQ))
				throw new ArgumentNullException(nameof(m3INOQ));
			if (string.IsNullOrWhiteSpace(m3DOCA))
				throw new ArgumentNullException(nameof(m3DOCA));
			if (string.IsNullOrWhiteSpace(m3DRDN))
				throw new ArgumentNullException(nameof(m3DRDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("INOT", m3INOT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INOQ", m3INOQ.Trim())
				.WithQueryParameter("DOCA", m3DOCA.Trim())
				.WithQueryParameter("DRDN", m3DRDN.Trim())
				.WithQueryParameter("DRDL", m3DRDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DRDX", m3DRDX.ToString(CultureInfo.CurrentCulture));

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
		/// Name Upd
		/// Description Update the initial promotion
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3INOT">Initial order type (Required)</param>
		/// <param name="m3INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3PPQT">Planned quantity</param>
		/// <param name="m3PLDT">Planning date</param>
		/// <param name="m3RPLS">Source</param>
		/// <param name="m3AGNO">Blanket agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3DIVI, 
			int m3INOT, 
			string m3INOQ, 
			string m3WHLO, 
			string m3ITNO, 
			decimal? m3PPQT = null, 
			DateTime? m3PLDT = null, 
			string m3RPLS = null, 
			string m3AGNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3INOQ))
				throw new ArgumentNullException(nameof(m3INOQ));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("INOT", m3INOT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INOQ", m3INOQ.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PPQT.HasValue)
				request.WithQueryParameter("PPQT", m3PPQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3PLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RPLS))
				request.WithQueryParameter("RPLS", m3RPLS.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNO))
				request.WithQueryParameter("AGNO", m3AGNO.Trim());

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
