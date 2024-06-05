/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3IVNO">Invoice number (Required)</param>
		/// <param name="m3CONO">Company</param>
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
			string m3DIVI, 
			int m3YEA4, 
			int m3IVNO, 
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInvHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("IVNO", m3IVNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name ListInvHistLine
		/// Description ListInvHistLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3INPX">Invoice prefix (Required)</param>
		/// <param name="m3IVNO">Invoice number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3IVAD">Invoice address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListInvHistLineResponse></returns>
		/// <exception cref="M3Exception<ListInvHistLineResponse>"></exception>
		public async Task<M3Response<ListInvHistLineResponse>> ListInvHistLine(
			int m3YEA4, 
			string m3INPX, 
			int m3IVNO, 
			string m3AGNB, 
			string m3PYNO, 
			string m3IVAD = null, 
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
			if (string.IsNullOrWhiteSpace(m3INPX))
				throw new ArgumentNullException(nameof(m3INPX));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INPX", m3INPX.Trim())
				.WithQueryParameter("IVNO", m3IVNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PYNO", m3PYNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IVAD))
				request.WithQueryParameter("IVAD", m3IVAD.Trim());

			// Execute the request
			var result = await Execute<ListInvHistLineResponse>(
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
		/// Name LslInvHistDet
		/// Description LslInvHistDet
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3INPX">Invoice prefix (Required)</param>
		/// <param name="m3IVNO">Invoice number (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3PYNO">Payer (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3IVAD">Invoice address</param>
		/// <param name="m3SAID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LslInvHistDetResponse></returns>
		/// <exception cref="M3Exception<LslInvHistDetResponse>"></exception>
		public async Task<M3Response<LslInvHistDetResponse>> LslInvHistDet(
			int m3YEA4, 
			string m3INPX, 
			int m3IVNO, 
			string m3AGNB, 
			string m3PYNO, 
			string m3CUPL, 
			int m3PONR, 
			string m3IVAD = null, 
			string m3SAID = null, 
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
			if (string.IsNullOrWhiteSpace(m3INPX))
				throw new ArgumentNullException(nameof(m3INPX));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3PYNO))
				throw new ArgumentNullException(nameof(m3PYNO));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));

			// Set mandatory parameters
			request
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INPX", m3INPX.Trim())
				.WithQueryParameter("IVNO", m3IVNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("PYNO", m3PYNO.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IVAD))
				request.WithQueryParameter("IVAD", m3IVAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAID))
				request.WithQueryParameter("SAID", m3SAID.Trim());

			// Execute the request
			var result = await Execute<LslInvHistDetResponse>(
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
		/// Name LstInvHistPrItm
		/// Description LstInvHistPrItm
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstInvHistPrItmResponse></returns>
		/// <exception cref="M3Exception<LstInvHistPrItmResponse>"></exception>
		public async Task<M3Response<LstInvHistPrItmResponse>> LstInvHistPrItm(
			string m3ITNO, 
			string m3BANO = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<LstInvHistPrItmResponse>(
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
