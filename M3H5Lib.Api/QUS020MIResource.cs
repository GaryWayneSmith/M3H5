/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3QUTY">Quotation type (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3SMNG">Sales manager</param>
		/// <param name="m3PREL">Preliminary quotation</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3TPCU">Template customer</param>
		/// <param name="m3PLTB">Price list table</param>
		/// <param name="m3QSMS">SMS Quote</param>
		/// <param name="m3QLMA">Lowest margin</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3OT06">Entry option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddQuoteType(
			string m3QUTY, 
			string m3TX15 = null, 
			string m3TX40 = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3ORTP = null, 
			string m3SMNG = null, 
			int? m3PREL = null, 
			string m3WHSL = null, 
			string m3TPCU = null, 
			string m3PLTB = null, 
			int? m3QSMS = null, 
			int? m3QLMA = null, 
			decimal? m3TXID = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			int? m3OT06 = null, 
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
			if (string.IsNullOrWhiteSpace(m3QUTY))
				throw new ArgumentNullException(nameof(m3QUTY));

			// Set mandatory parameters
			request
				.WithQueryParameter("QUTY", m3QUTY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMNG))
				request.WithQueryParameter("SMNG", m3SMNG.Trim());
			if (m3PREL.HasValue)
				request.WithQueryParameter("PREL", m3PREL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPCU))
				request.WithQueryParameter("TPCU", m3TPCU.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTB))
				request.WithQueryParameter("PLTB", m3PLTB.Trim());
			if (m3QSMS.HasValue)
				request.WithQueryParameter("QSMS", m3QSMS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QLMA.HasValue)
				request.WithQueryParameter("QLMA", m3QLMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3OT06.HasValue)
				request.WithQueryParameter("OT06", m3OT06.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltQuoteType
		/// Description Delete Quotation Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3QUTY">Quotation type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltQuoteType(
			string m3QUTY, 
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
			if (string.IsNullOrWhiteSpace(m3QUTY))
				throw new ArgumentNullException(nameof(m3QUTY));

			// Set mandatory parameters
			request
				.WithQueryParameter("QUTY", m3QUTY.Trim());

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
		/// Name GetQuoteType
		/// Description Get Quotation Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3QUTY">Quotation type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetQuoteTypeResponse></returns>
		/// <exception cref="M3Exception<GetQuoteTypeResponse>"></exception>
		public async Task<M3Response<GetQuoteTypeResponse>> GetQuoteType(
			string m3QUTY, 
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
			if (string.IsNullOrWhiteSpace(m3QUTY))
				throw new ArgumentNullException(nameof(m3QUTY));

			// Set mandatory parameters
			request
				.WithQueryParameter("QUTY", m3QUTY.Trim());

			// Execute the request
			var result = await Execute<GetQuoteTypeResponse>(
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
		/// Name LstQuoteType
		/// Description List Quotation Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3QUTY">Quotation type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstQuoteTypeResponse></returns>
		/// <exception cref="M3Exception<LstQuoteTypeResponse>"></exception>
		public async Task<M3Response<LstQuoteTypeResponse>> LstQuoteType(
			string m3QUTY = null, 
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
			if (!string.IsNullOrWhiteSpace(m3QUTY))
				request.WithQueryParameter("QUTY", m3QUTY.Trim());

			// Execute the request
			var result = await Execute<LstQuoteTypeResponse>(
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
