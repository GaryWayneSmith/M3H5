/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
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
	/// Name: MMS120MI
	/// Component Name: Allocation
	/// Description: Perform Detailed Allocation
	/// Version Release: 14.x
	///</summary>
	public partial class MMS120MIResource : M3BaseResourceEndpoint
	{
		public MMS120MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS120MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AllocateOrdLine
		/// Description Allocate Order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TTYP">Stock transaction type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3MAAL">Allocation origin (Required)</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3ALQT">Allocated quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AllocateOrdLine(
			int m3TTYP, 
			string m3RIDN, 
			int m3RIDL, 
			string m3MAAL, 
			int? m3RIDX = null, 
			decimal? m3ALQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AllocateOrdLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));
			if (string.IsNullOrWhiteSpace(m3MAAL))
				throw new ArgumentNullException(nameof(m3MAAL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MAAL", m3MAAL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3ALQT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AllocateOrder
		/// Description Allocate Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TTYP">Stock transaction type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3MAAL">Allocation origin (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AllocateOrder(
			int m3TTYP, 
			string m3RIDN, 
			string m3MAAL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AllocateOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));
			if (string.IsNullOrWhiteSpace(m3MAAL))
				throw new ArgumentNullException(nameof(m3MAAL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("MAAL", m3MAAL.Trim());

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
		/// Name DeAllocateOrLne
		/// Description De-Allocate Order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TTYP">Stock transaction type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3MAAL">Allocation origin (Required)</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3ALQT">Allocated quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeAllocateOrLne(
			int m3TTYP, 
			string m3RIDN, 
			int m3RIDL, 
			string m3MAAL, 
			int? m3RIDX = null, 
			decimal? m3ALQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeAllocateOrLne",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));
			if (string.IsNullOrWhiteSpace(m3MAAL))
				throw new ArgumentNullException(nameof(m3MAAL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MAAL", m3MAAL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3ALQT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DeAllocateOrder
		/// Description Deallocate Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TTYP">Stock transaction type (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3MAAL">Allocation origin (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeAllocateOrder(
			int m3TTYP, 
			string m3RIDN, 
			string m3MAAL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeAllocateOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));
			if (string.IsNullOrWhiteSpace(m3MAAL))
				throw new ArgumentNullException(nameof(m3MAAL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("MAAL", m3MAAL.Trim());

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
		/// Name PerfDetAlloc
		/// Description Perform Detailed Allocation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3RIDI">Delivery number (Required)</param>
		/// <param name="m3PLSX">Picking list suffix (Required)</param>
		/// <param name="m3ORCA">Order category (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3WHSL">Original Location (Required)</param>
		/// <param name="m3OQTY">Original Quantity (Required)</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3BANO">Original Lot number</param>
		/// <param name="m3CAMU">Original Container</param>
		/// <param name="m3NWSL">New Location</param>
		/// <param name="m3NBNO">New Lot number</param>
		/// <param name="m3NCMU">New Container</param>
		/// <param name="m3NQTY">New Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PerfDetAlloc(
			string m3WHLO, 
			string m3ITNO, 
			decimal m3RIDI, 
			int m3PLSX, 
			string m3ORCA, 
			string m3RIDN, 
			int m3RIDL, 
			string m3WHSL, 
			decimal m3OQTY, 
			int? m3RIDX = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3NWSL = null, 
			string m3NBNO = null, 
			string m3NCMU = null, 
			decimal? m3NQTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PerfDetAlloc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3ORCA))
				throw new ArgumentNullException(nameof(m3ORCA));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("RIDI", m3RIDI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLSX", m3PLSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORCA", m3ORCA.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("WHSL", m3WHSL.Trim())
				.WithQueryParameter("OQTY", m3OQTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3NWSL))
				request.WithQueryParameter("NWSL", m3NWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3NBNO))
				request.WithQueryParameter("NBNO", m3NBNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NCMU))
				request.WithQueryParameter("NCMU", m3NCMU.Trim());
			if (m3NQTY.HasValue)
				request.WithQueryParameter("NQTY", m3NQTY.Value.ToString(CultureInfo.CurrentCulture));

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
