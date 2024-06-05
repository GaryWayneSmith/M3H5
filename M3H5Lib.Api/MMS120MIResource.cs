/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_TTYP">Stock transaction type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_MAAL">Allocation origin (Required)</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ALQT">Allocated quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AllocateOrdLine(
			int m3_TTYP, 
			string m3_RIDN, 
			int m3_RIDL, 
			string m3_MAAL, 
			int? m3_RIDX = null, 
			decimal? m3_ALQT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_MAAL))
				throw new ArgumentNullException("m3_MAAL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3_TTYP.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("MAAL", m3_MAAL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3_ALQT.Value.ToString());

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
		/// Name AllocateOrder
		/// Description Allocate Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TTYP">Stock transaction type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_MAAL">Allocation origin (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AllocateOrder(
			int m3_TTYP, 
			string m3_RIDN, 
			string m3_MAAL, 
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
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_MAAL))
				throw new ArgumentNullException("m3_MAAL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3_TTYP.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("MAAL", m3_MAAL.Trim());

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
		/// Name DeAllocateOrLne
		/// Description De-Allocate Order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TTYP">Stock transaction type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_MAAL">Allocation origin (Required)</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_ALQT">Allocated quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeAllocateOrLne(
			int m3_TTYP, 
			string m3_RIDN, 
			int m3_RIDL, 
			string m3_MAAL, 
			int? m3_RIDX = null, 
			decimal? m3_ALQT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_MAAL))
				throw new ArgumentNullException("m3_MAAL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3_TTYP.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("MAAL", m3_MAAL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_ALQT.HasValue)
				request.WithQueryParameter("ALQT", m3_ALQT.Value.ToString());

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
		/// Name DeAllocateOrder
		/// Description Deallocate Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TTYP">Stock transaction type (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_MAAL">Allocation origin (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeAllocateOrder(
			int m3_TTYP, 
			string m3_RIDN, 
			string m3_MAAL, 
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
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_MAAL))
				throw new ArgumentNullException("m3_MAAL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3_TTYP.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("MAAL", m3_MAAL.Trim());

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
		/// Name PerfDetAlloc
		/// Description Perform Detailed Allocation
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_RIDI">Delivery number (Required)</param>
		/// <param name="m3_PLSX">Picking list suffix (Required)</param>
		/// <param name="m3_ORCA">Order category (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_WHSL">Original Location (Required)</param>
		/// <param name="m3_OQTY">Original Quantity (Required)</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_BANO">Original Lot number</param>
		/// <param name="m3_CAMU">Original Container</param>
		/// <param name="m3_NWSL">New Location</param>
		/// <param name="m3_NBNO">New Lot number</param>
		/// <param name="m3_NCMU">New Container</param>
		/// <param name="m3_NQTY">New Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PerfDetAlloc(
			string m3_WHLO, 
			string m3_ITNO, 
			decimal m3_RIDI, 
			int m3_PLSX, 
			string m3_ORCA, 
			string m3_RIDN, 
			int m3_RIDL, 
			string m3_WHSL, 
			decimal m3_OQTY, 
			int? m3_RIDX = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_NWSL = null, 
			string m3_NBNO = null, 
			string m3_NCMU = null, 
			decimal? m3_NQTY = null, 
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
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_ORCA))
				throw new ArgumentNullException("m3_ORCA");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("RIDI", m3_RIDI.ToString())
				.WithQueryParameter("PLSX", m3_PLSX.ToString())
				.WithQueryParameter("ORCA", m3_ORCA.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("WHSL", m3_WHSL.Trim())
				.WithQueryParameter("OQTY", m3_OQTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NWSL))
				request.WithQueryParameter("NWSL", m3_NWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NBNO))
				request.WithQueryParameter("NBNO", m3_NBNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NCMU))
				request.WithQueryParameter("NCMU", m3_NCMU.Trim());
			if (m3_NQTY.HasValue)
				request.WithQueryParameter("NQTY", m3_NQTY.Value.ToString());

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
