/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.STS350MI;
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
	/// Name: STS350MI
	/// Component Name: ShortTermRentalInvoice
	/// Description: Short Term Rental invoice interface
	/// Version Release: 5ea0
	///</summary>
	public partial class STS350MIResource : M3BaseResourceEndpoint
	{
		public STS350MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS350MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetInvHead
		/// Description Retrieve Invoice Head
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_INPX">Invoice Prefix</param>
		/// <param name="m3_EXIN">Extended Invoice Number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInvHeadResponse></returns>
		/// <exception cref="M3Exception<GetInvHeadResponse>"></exception>
		public async Task<M3Response<GetInvHeadResponse>> GetInvHead(
			string m3_DIVI, 
			int m3_YEA4, 
			int m3_IVNO, 
			int? m3_CONO = null, 
			string m3_INPX = null, 
			string m3_EXIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("IVNO", m3_IVNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INPX))
				request.WithQueryParameter("INPX", m3_INPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXIN))
				request.WithQueryParameter("EXIN", m3_EXIN.Trim());

			// Execute the request
			var result = await Execute<GetInvHeadResponse>(
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
		/// Name ListInvHistLine
		/// Description ListInvHistLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_INPX">Invoice prefix (Required)</param>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_IVAD">Invoice address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListInvHistLineResponse></returns>
		/// <exception cref="M3Exception<ListInvHistLineResponse>"></exception>
		public async Task<M3Response<ListInvHistLineResponse>> ListInvHistLine(
			int m3_YEA4, 
			string m3_INPX, 
			int m3_IVNO, 
			string m3_AGNB, 
			string m3_PYNO, 
			string m3_IVAD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListInvHistLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_INPX))
				throw new ArgumentNullException("m3_INPX");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("INPX", m3_INPX.Trim())
				.WithQueryParameter("IVNO", m3_IVNO.ToString())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PYNO", m3_PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IVAD))
				request.WithQueryParameter("IVAD", m3_IVAD.Trim());

			// Execute the request
			var result = await Execute<ListInvHistLineResponse>(
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
		/// Name LslInvHistDet
		/// Description LslInvHistDet
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_INPX">Invoice prefix (Required)</param>
		/// <param name="m3_IVNO">Invoice number (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_PYNO">Payer (Required)</param>
		/// <param name="m3_CUPL">Customer site (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_IVAD">Invoice address</param>
		/// <param name="m3_SAID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LslInvHistDetResponse></returns>
		/// <exception cref="M3Exception<LslInvHistDetResponse>"></exception>
		public async Task<M3Response<LslInvHistDetResponse>> LslInvHistDet(
			int m3_YEA4, 
			string m3_INPX, 
			int m3_IVNO, 
			string m3_AGNB, 
			string m3_PYNO, 
			string m3_CUPL, 
			int m3_PONR, 
			string m3_IVAD = null, 
			string m3_SAID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LslInvHistDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_INPX))
				throw new ArgumentNullException("m3_INPX");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_PYNO))
				throw new ArgumentNullException("m3_PYNO");
			if (string.IsNullOrWhiteSpace(m3_CUPL))
				throw new ArgumentNullException("m3_CUPL");

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("INPX", m3_INPX.Trim())
				.WithQueryParameter("IVNO", m3_IVNO.ToString())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("PYNO", m3_PYNO.Trim())
				.WithQueryParameter("CUPL", m3_CUPL.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IVAD))
				request.WithQueryParameter("IVAD", m3_IVAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAID))
				request.WithQueryParameter("SAID", m3_SAID.Trim());

			// Execute the request
			var result = await Execute<LslInvHistDetResponse>(
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
		/// Name LstInvHistPrItm
		/// Description LstInvHistPrItm
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvHistPrItmResponse></returns>
		/// <exception cref="M3Exception<LstInvHistPrItmResponse>"></exception>
		public async Task<M3Response<LstInvHistPrItmResponse>> LstInvHistPrItm(
			string m3_ITNO, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstInvHistPrItm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<LstInvHistPrItmResponse>(
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
