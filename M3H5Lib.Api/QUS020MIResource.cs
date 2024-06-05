/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QUS020MI;
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
	/// Name: QUS020MI
	/// Component Name: Quotation
	/// Description: Api: Quotation type
	/// Version Release: 5ea0
	///</summary>
	public partial class QUS020MIResource : M3BaseResourceEndpoint
	{
		public QUS020MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUS020MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddQuoteType
		/// Description Add Quotation Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_QUTY">Quotation type (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_SMNG">Sales manager</param>
		/// <param name="m3_PREL">Preliminary quotation</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_TPCU">Template customer</param>
		/// <param name="m3_PLTB">Price list table</param>
		/// <param name="m3_QSMS">SMS Quote</param>
		/// <param name="m3_QLMA">Lowest margin</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_OT06">Entry option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddQuoteType(
			string m3_QUTY, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_ORTP = null, 
			string m3_SMNG = null, 
			int? m3_PREL = null, 
			string m3_WHSL = null, 
			string m3_TPCU = null, 
			string m3_PLTB = null, 
			int? m3_QSMS = null, 
			int? m3_QLMA = null, 
			decimal? m3_TXID = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_OT06 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddQuoteType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QUTY))
				throw new ArgumentNullException("m3_QUTY");

			// Set mandatory parameters
			request
				.WithQueryParameter("QUTY", m3_QUTY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMNG))
				request.WithQueryParameter("SMNG", m3_SMNG.Trim());
			if (m3_PREL.HasValue)
				request.WithQueryParameter("PREL", m3_PREL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPCU))
				request.WithQueryParameter("TPCU", m3_TPCU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTB))
				request.WithQueryParameter("PLTB", m3_PLTB.Trim());
			if (m3_QSMS.HasValue)
				request.WithQueryParameter("QSMS", m3_QSMS.Value.ToString());
			if (m3_QLMA.HasValue)
				request.WithQueryParameter("QLMA", m3_QLMA.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_OT06.HasValue)
				request.WithQueryParameter("OT06", m3_OT06.Value.ToString());

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
		/// Name DltQuoteType
		/// Description Delete Quotation Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_QUTY">Quotation type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltQuoteType(
			string m3_QUTY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltQuoteType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QUTY))
				throw new ArgumentNullException("m3_QUTY");

			// Set mandatory parameters
			request
				.WithQueryParameter("QUTY", m3_QUTY.Trim());

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
		/// Name GetQuoteType
		/// Description Get Quotation Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_QUTY">Quotation type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQuoteTypeResponse></returns>
		/// <exception cref="M3Exception<GetQuoteTypeResponse>"></exception>
		public async Task<M3Response<GetQuoteTypeResponse>> GetQuoteType(
			string m3_QUTY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetQuoteType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_QUTY))
				throw new ArgumentNullException("m3_QUTY");

			// Set mandatory parameters
			request
				.WithQueryParameter("QUTY", m3_QUTY.Trim());

			// Execute the request
			var result = await Execute<GetQuoteTypeResponse>(
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
		/// Name LstQuoteType
		/// Description List Quotation Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_QUTY">Quotation type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuoteTypeResponse></returns>
		/// <exception cref="M3Exception<LstQuoteTypeResponse>"></exception>
		public async Task<M3Response<LstQuoteTypeResponse>> LstQuoteType(
			string m3_QUTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstQuoteType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_QUTY))
				request.WithQueryParameter("QUTY", m3_QUTY.Trim());

			// Execute the request
			var result = await Execute<LstQuoteTypeResponse>(
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
