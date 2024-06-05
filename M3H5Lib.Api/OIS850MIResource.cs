/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Alloc
		/// Description Allocate CO
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_INOT">Initial order type (Required)</param>
		/// <param name="m3_INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3_DOCA">Demand order category (Required)</param>
		/// <param name="m3_DRDN">Demand order number (Required)</param>
		/// <param name="m3_DRDL">Demand order line (Required)</param>
		/// <param name="m3_DRDX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Alloc(
			string m3_DIVI, 
			int m3_INOT, 
			string m3_INOQ, 
			string m3_DOCA, 
			string m3_DRDN, 
			int m3_DRDL, 
			int m3_DRDX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Alloc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_INOQ))
				throw new ArgumentNullException("m3_INOQ");
			if (string.IsNullOrWhiteSpace(m3_DOCA))
				throw new ArgumentNullException("m3_DOCA");
			if (string.IsNullOrWhiteSpace(m3_DRDN))
				throw new ArgumentNullException("m3_DRDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("INOT", m3_INOT.ToString())
				.WithQueryParameter("INOQ", m3_INOQ.Trim())
				.WithQueryParameter("DOCA", m3_DOCA.Trim())
				.WithQueryParameter("DRDN", m3_DRDN.Trim())
				.WithQueryParameter("DRDL", m3_DRDL.ToString())
				.WithQueryParameter("DRDX", m3_DRDX.ToString());

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
		/// Name Close
		/// Description Close an initial order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_INOT">Initial order type (Required)</param>
		/// <param name="m3_INOQ">Initial order qualifier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Close(
			string m3_DIVI, 
			int m3_INOT, 
			string m3_INOQ, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Close",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_INOQ))
				throw new ArgumentNullException("m3_INOQ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("INOT", m3_INOT.ToString())
				.WithQueryParameter("INOQ", m3_INOQ.Trim());

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
		/// Name DeAlloc
		/// Description Deallocate CO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_INOT">Initial order type (Required)</param>
		/// <param name="m3_INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3_DOCA">Demand order category (Required)</param>
		/// <param name="m3_DRDN">Demand order number (Required)</param>
		/// <param name="m3_DRDL">Demand order line (Required)</param>
		/// <param name="m3_DRDX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeAlloc(
			string m3_DIVI, 
			int m3_INOT, 
			string m3_INOQ, 
			string m3_DOCA, 
			string m3_DRDN, 
			int m3_DRDL, 
			int m3_DRDX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeAlloc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_INOQ))
				throw new ArgumentNullException("m3_INOQ");
			if (string.IsNullOrWhiteSpace(m3_DOCA))
				throw new ArgumentNullException("m3_DOCA");
			if (string.IsNullOrWhiteSpace(m3_DRDN))
				throw new ArgumentNullException("m3_DRDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("INOT", m3_INOT.ToString())
				.WithQueryParameter("INOQ", m3_INOQ.Trim())
				.WithQueryParameter("DOCA", m3_DOCA.Trim())
				.WithQueryParameter("DRDN", m3_DRDN.Trim())
				.WithQueryParameter("DRDL", m3_DRDL.ToString())
				.WithQueryParameter("DRDX", m3_DRDX.ToString());

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
		/// Name Gen
		/// Description Generate supply orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_INOT">Initial order type (Required)</param>
		/// <param name="m3_INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Gen(
			string m3_DIVI, 
			int m3_INOT, 
			string m3_INOQ, 
			string m3_WHLO = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Gen",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_INOQ))
				throw new ArgumentNullException("m3_INOQ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("INOT", m3_INOT.ToString())
				.WithQueryParameter("INOQ", m3_INOQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

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
		/// Name LstCOLines
		/// Description List CO Lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_INOT">Initial order type (Required)</param>
		/// <param name="m3_INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCOLinesResponse></returns>
		/// <exception cref="M3Exception<LstCOLinesResponse>"></exception>
		public async Task<M3Response<LstCOLinesResponse>> LstCOLines(
			string m3_DIVI, 
			int m3_INOT, 
			string m3_INOQ, 
			string m3_WHLO, 
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCOLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_INOQ))
				throw new ArgumentNullException("m3_INOQ");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("INOT", m3_INOT.ToString())
				.WithQueryParameter("INOQ", m3_INOQ.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstCOLinesResponse>(
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
		/// Name LstInitialOrder
		/// Description List Initial Orders
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_INOT">Initial order type (Required)</param>
		/// <param name="m3_INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInitialOrderResponse></returns>
		/// <exception cref="M3Exception<LstInitialOrderResponse>"></exception>
		public async Task<M3Response<LstInitialOrderResponse>> LstInitialOrder(
			string m3_DIVI, 
			int m3_INOT, 
			string m3_INOQ, 
			string m3_WHLO = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInitialOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_INOQ))
				throw new ArgumentNullException("m3_INOQ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("INOT", m3_INOT.ToString())
				.WithQueryParameter("INOQ", m3_INOQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstInitialOrderResponse>(
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
		/// Name Rel
		/// Description Release an initial promotion for allocation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_INOT">Initial order type (Required)</param>
		/// <param name="m3_INOQ">Initial order qualifier (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Rel(
			string m3_DIVI, 
			int m3_INOT, 
			string m3_INOQ, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Rel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_INOQ))
				throw new ArgumentNullException("m3_INOQ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("INOT", m3_INOT.ToString())
				.WithQueryParameter("INOQ", m3_INOQ.Trim());

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
		/// Name Rmv
		/// Description Remove a CO line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_INOT">Initial order type (Required)</param>
		/// <param name="m3_INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3_DOCA">Demand order category (Required)</param>
		/// <param name="m3_DRDN">Demand order number (Required)</param>
		/// <param name="m3_DRDL">Demand order line (Required)</param>
		/// <param name="m3_DRDX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Rmv(
			string m3_DIVI, 
			int m3_INOT, 
			string m3_INOQ, 
			string m3_DOCA, 
			string m3_DRDN, 
			int m3_DRDL, 
			int m3_DRDX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Rmv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_INOQ))
				throw new ArgumentNullException("m3_INOQ");
			if (string.IsNullOrWhiteSpace(m3_DOCA))
				throw new ArgumentNullException("m3_DOCA");
			if (string.IsNullOrWhiteSpace(m3_DRDN))
				throw new ArgumentNullException("m3_DRDN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("INOT", m3_INOT.ToString())
				.WithQueryParameter("INOQ", m3_INOQ.Trim())
				.WithQueryParameter("DOCA", m3_DOCA.Trim())
				.WithQueryParameter("DRDN", m3_DRDN.Trim())
				.WithQueryParameter("DRDL", m3_DRDL.ToString())
				.WithQueryParameter("DRDX", m3_DRDX.ToString());

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
		/// Name Upd
		/// Description Update the initial promotion
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_INOT">Initial order type (Required)</param>
		/// <param name="m3_INOQ">Initial order qualifier (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_PPQT">Planned quantity</param>
		/// <param name="m3_PLDT">Planning date</param>
		/// <param name="m3_RPLS">Source</param>
		/// <param name="m3_AGNO">Blanket agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_DIVI, 
			int m3_INOT, 
			string m3_INOQ, 
			string m3_WHLO, 
			string m3_ITNO, 
			decimal? m3_PPQT = null, 
			DateTime? m3_PLDT = null, 
			string m3_RPLS = null, 
			string m3_AGNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_INOQ))
				throw new ArgumentNullException("m3_INOQ");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("INOT", m3_INOT.ToString())
				.WithQueryParameter("INOQ", m3_INOQ.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PPQT.HasValue)
				request.WithQueryParameter("PPQT", m3_PPQT.Value.ToString());
			if (m3_PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3_PLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RPLS))
				request.WithQueryParameter("RPLS", m3_RPLS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNO))
				request.WithQueryParameter("AGNO", m3_AGNO.Trim());

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
