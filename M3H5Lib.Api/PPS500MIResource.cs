/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PPS500MI;
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
	/// Name: PPS500MI
	/// Component Name: Tool
	/// Description: Freight purchase transactions interface
	/// Version Release: 14.x
	///</summary>
	public partial class PPS500MIResource : M3BaseResourceEndpoint
	{
		public PPS500MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS500MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddFreightTrans
		/// Description Add a Freight purchase transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3PLDT">Planning date (Required)</param>
		/// <param name="m3FPN1">Freight purchase number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FRAL">Freight rate aggregation level</param>
		/// <param name="m3TRLV">Auto level</param>
		/// <param name="m3I3PT">Included in PO to 3rd-party forwarder</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3TTYP">Stock transaction type</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3PPQT">Planned quantity</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3RELD">Release date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFreightTrans(
			string m3FACI, 
			string m3STAT, 
			int m3CONN, 
			decimal m3DLIX, 
			string m3SUNO, 
			DateTime m3PLDT, 
			long? m3FPN1 = null, 
			string m3WHLO = null, 
			int? m3FRAL = null, 
			int? m3TRLV = null, 
			int? m3I3PT = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			int? m3TTYP = null, 
			string m3ORTY = null, 
			string m3ITNO = null, 
			decimal? m3PUPR = null, 
			int? m3PUCD = null, 
			decimal? m3PPQT = null, 
			string m3CUCD = null, 
			int? m3CRTP = null, 
			string m3BUYE = null, 
			string m3MODL = null, 
			DateTime? m3RELD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddFreightTrans",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("PLDT", m3PLDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FPN1.HasValue)
				request.WithQueryParameter("FPN1", m3FPN1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3FRAL.HasValue)
				request.WithQueryParameter("FRAL", m3FRAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRLV.HasValue)
				request.WithQueryParameter("TRLV", m3TRLV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3I3PT.HasValue)
				request.WithQueryParameter("I3PT", m3I3PT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TTYP.HasValue)
				request.WithQueryParameter("TTYP", m3TTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPQT.HasValue)
				request.WithQueryParameter("PPQT", m3PPQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (m3RELD.HasValue)
				request.WithQueryParameter("RELD", m3RELD.Value.ToM3String());

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
		/// Name DltFreightTrans
		/// Description Delete a Freight purchase transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3PLDT">Planning date (Required)</param>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3FPN1">Freight purchase number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltFreightTrans(
			string m3FACI, 
			string m3STAT, 
			string m3SUNO, 
			DateTime m3PLDT, 
			int m3CONN, 
			decimal m3DLIX, 
			long? m3FPN1 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltFreightTrans",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("PLDT", m3PLDT.ToM3String())
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3FPN1.HasValue)
				request.WithQueryParameter("FPN1", m3FPN1.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetFreightTrans
		/// Description Get a Freight purchase transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3PLDT">Planning date (Required)</param>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3FPN1">Freight purchase number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFreightTransResponse></returns>
		/// <exception cref="M3Exception<GetFreightTransResponse>"></exception>
		public async Task<M3Response<GetFreightTransResponse>> GetFreightTrans(
			string m3FACI, 
			string m3STAT, 
			string m3SUNO, 
			DateTime m3PLDT, 
			int m3CONN, 
			decimal m3DLIX, 
			long? m3FPN1 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetFreightTrans",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("PLDT", m3PLDT.ToM3String())
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3FPN1.HasValue)
				request.WithQueryParameter("FPN1", m3FPN1.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetFreightTransResponse>(
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
		/// Name LstFreightTrans
		/// Description List Freight purchase transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3PLDT">Planning date</param>
		/// <param name="m3CONN">Shipment</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3FPN1">Freight purchase number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFreightTransResponse></returns>
		/// <exception cref="M3Exception<LstFreightTransResponse>"></exception>
		public async Task<M3Response<LstFreightTransResponse>> LstFreightTrans(
			string m3FACI = null, 
			string m3STAT = null, 
			string m3SUNO = null, 
			DateTime? m3PLDT = null, 
			int? m3CONN = null, 
			decimal? m3DLIX = null, 
			long? m3FPN1 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFreightTrans",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3PLDT.Value.ToM3String());
			if (m3CONN.HasValue)
				request.WithQueryParameter("CONN", m3CONN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FPN1.HasValue)
				request.WithQueryParameter("FPN1", m3FPN1.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstFreightTransResponse>(
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
		/// Name UpdFreightTrans
		/// Description Update a Freight purchase transaction
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3PLDT">Planning date</param>
		/// <param name="m3FPN1">Freight purchase number</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdFreightTrans(
			string m3FACI, 
			string m3STAT, 
			string m3SUNO, 
			int m3CONN, 
			decimal m3DLIX, 
			DateTime? m3PLDT = null, 
			long? m3FPN1 = null, 
			string m3ORTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdFreightTrans",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3PLDT.Value.ToM3String());
			if (m3FPN1.HasValue)
				request.WithQueryParameter("FPN1", m3FPN1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());

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
