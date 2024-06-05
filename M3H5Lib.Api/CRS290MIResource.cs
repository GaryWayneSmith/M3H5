/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS290MI;
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
	/// Name: CRS290MI
	/// Component Name: Printer
	/// Description: Printer interface
	/// Version Release: 5ea1
	///</summary>
	public partial class CRS290MIResource : M3BaseResourceEndpoint
	{
		public CRS290MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS290MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPrinter
		/// Description Add a printer
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_DEV">Printer</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_DEVP">Printer priority</param>
		/// <param name="m3_OUTQ">Out queue</param>
		/// <param name="m3_PVRA">Printer server address</param>
		/// <param name="m3_XPRT">Modification</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPrinter(
			string m3_TX40, 
			string m3_DEV = null, 
			string m3_TX15 = null, 
			int? m3_DEVP = null, 
			string m3_OUTQ = null, 
			string m3_PVRA = null, 
			string m3_XPRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPrinter",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DEV))
				request.WithQueryParameter("DEV", m3_DEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_DEVP.HasValue)
				request.WithQueryParameter("DEVP", m3_DEVP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OUTQ))
				request.WithQueryParameter("OUTQ", m3_OUTQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PVRA))
				request.WithQueryParameter("PVRA", m3_PVRA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XPRT))
				request.WithQueryParameter("XPRT", m3_XPRT.Trim());

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
		/// Name DltPrinter
		/// Description Delete a printer
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DEV">Printer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPrinter(
			string m3_DEV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPrinter",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DEV))
				request.WithQueryParameter("DEV", m3_DEV.Trim());

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
		/// Name GetPrinter
		/// Description Get data for a printer
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_DEV">Printer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPrinterResponse></returns>
		/// <exception cref="M3Exception<GetPrinterResponse>"></exception>
		public async Task<M3Response<GetPrinterResponse>> GetPrinter(
			string m3_DEV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPrinter",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DEV))
				request.WithQueryParameter("DEV", m3_DEV.Trim());

			// Execute the request
			var result = await Execute<GetPrinterResponse>(
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
		/// Name LstPrinters
		/// Description List data for printers
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_DEV">Printer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPrintersResponse></returns>
		/// <exception cref="M3Exception<LstPrintersResponse>"></exception>
		public async Task<M3Response<LstPrintersResponse>> LstPrinters(
			string m3_DEV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPrinters",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DEV))
				request.WithQueryParameter("DEV", m3_DEV.Trim());

			// Execute the request
			var result = await Execute<LstPrintersResponse>(
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
		/// Name UpdPrinter
		/// Description Change data for a printer
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_DEV">Printer</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_DEVP">Printer priority</param>
		/// <param name="m3_OUTQ">Out queue</param>
		/// <param name="m3_PVRA">Printer server address</param>
		/// <param name="m3_XPRT">Modification</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPrinter(
			string m3_DEV = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_DEVP = null, 
			string m3_OUTQ = null, 
			string m3_PVRA = null, 
			string m3_XPRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPrinter",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DEV))
				request.WithQueryParameter("DEV", m3_DEV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_DEVP.HasValue)
				request.WithQueryParameter("DEVP", m3_DEVP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OUTQ))
				request.WithQueryParameter("OUTQ", m3_OUTQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PVRA))
				request.WithQueryParameter("PVRA", m3_PVRA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_XPRT))
				request.WithQueryParameter("XPRT", m3_XPRT.Trim());

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
