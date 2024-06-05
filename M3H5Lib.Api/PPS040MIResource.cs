/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PPS040MI;
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
	/// Name: PPS040MI
	/// Component Name: Purchasing
	/// Description: Item/Vendor interface
	/// Version Release: 14.x
	///</summary>
	public partial class PPS040MIResource : M3BaseResourceEndpoint
	{
		public PPS040MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS040MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItemSupplier
		/// Description Item Supplier Connect
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3PRCS">Serviceprocess</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3LEA5">Leadtimeforreplacementdelivery</param>
		/// <param name="m3GRMT">Goodsreceivingmethod</param>
		/// <param name="m3UNMU">Ordermultiple</param>
		/// <param name="m3LOQT">Minimumorderquantity</param>
		/// <param name="m3FVDT">Validfrom</param>
		/// <param name="m3UVDT">Validto</param>
		/// <param name="m3PUCD">Purchasepricequantity</param>
		/// <param name="m3PUPR">Purchaseprice</param>
		/// <param name="m3SUPR">Setupprice</param>
		/// <param name="m3FVD1">Validfrom</param>
		/// <param name="m3UVD1">Validto</param>
		/// <param name="m3PUP1">Purchaseprice</param>
		/// <param name="m3SUP1">Setupprice</param>
		/// <param name="m3LCLV">Lowest quality inspection method</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3CTXT">Inspection text</param>
		/// <param name="m3QUCL">Quality class</param>
		/// <param name="m3DSPS">Display service</param>
		/// <param name="m3VALS">No service valid</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItemSupplier(
			string m3ITNO, 
			string m3SUNO, 
			string m3PRCS = null, 
			string m3SUFI = null, 
			int? m3LEA5 = null, 
			string m3GRMT = null, 
			decimal? m3UNMU = null, 
			decimal? m3LOQT = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3UVDT = null, 
			int? m3PUCD = null, 
			decimal? m3PUPR = null, 
			decimal? m3SUPR = null, 
			DateTime? m3FVD1 = null, 
			DateTime? m3UVD1 = null, 
			decimal? m3PUP1 = null, 
			decimal? m3SUP1 = null, 
			string m3LCLV = null, 
			string m3ORCO = null, 
			string m3CTXT = null, 
			string m3QUCL = null, 
			int? m3DSPS = null, 
			int? m3VALS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddItemSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRCS))
				request.WithQueryParameter("PRCS", m3PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3LEA5.HasValue)
				request.WithQueryParameter("LEA5", m3LEA5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GRMT))
				request.WithQueryParameter("GRMT", m3GRMT.Trim());
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3LOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3UVDT.Value.ToM3String());
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3SUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVD1.HasValue)
				request.WithQueryParameter("FVD1", m3FVD1.Value.ToM3String());
			if (m3UVD1.HasValue)
				request.WithQueryParameter("UVD1", m3UVD1.Value.ToM3String());
			if (m3PUP1.HasValue)
				request.WithQueryParameter("PUP1", m3PUP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3SUP1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LCLV))
				request.WithQueryParameter("LCLV", m3LCLV.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTXT))
				request.WithQueryParameter("CTXT", m3CTXT.Trim());
			if (!string.IsNullOrWhiteSpace(m3QUCL))
				request.WithQueryParameter("QUCL", m3QUCL.Trim());
			if (m3DSPS.HasValue)
				request.WithQueryParameter("DSPS", m3DSPS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VALS.HasValue)
				request.WithQueryParameter("VALS", m3VALS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddItemSupplrQI
		/// Description Item Supplier Connect QI
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3PRCS">Serviceprocess</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3LEA5">Leadtimeforreplacementdelivery</param>
		/// <param name="m3GRMT">Goodsreceivingmethod</param>
		/// <param name="m3UNMU">Ordermultiple</param>
		/// <param name="m3LOQT">Minimumorderquantity</param>
		/// <param name="m3FVDT">Validfrom</param>
		/// <param name="m3UVDT">Validto</param>
		/// <param name="m3PUCD">Purchasepricequantity</param>
		/// <param name="m3PUPR">Purchaseprice</param>
		/// <param name="m3SUPR">Setupprice</param>
		/// <param name="m3FVD1">Validfrom</param>
		/// <param name="m3UVD1">Validto</param>
		/// <param name="m3PUP1">Purchaseprice</param>
		/// <param name="m3SUP1">Setupprice</param>
		/// <param name="m3LCLV">Lowest quality inspection method</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3CTXT">Inspection text</param>
		/// <param name="m3QUCL">Quality class</param>
		/// <param name="m3DSPS">Display service</param>
		/// <param name="m3VALS">No service valid</param>
		/// <param name="m3CSCT">Are quality inspection tasks used</param>
		/// <param name="m3CHNS">Quality inspection level - next batch</param>
		/// <param name="m3QCCE">Quality inspection level - new revision</param>
		/// <param name="m3TOSP">Quality inspection plan</param>
		/// <param name="m3SPTT">Sample table</param>
		/// <param name="m3MCLD">Minimum quality inspection interval</param>
		/// <param name="m3CLWM">QI level after minimum QI interval</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItemSupplrQI(
			string m3ITNO, 
			string m3SUNO, 
			string m3PRCS = null, 
			string m3SUFI = null, 
			int? m3LEA5 = null, 
			string m3GRMT = null, 
			decimal? m3UNMU = null, 
			decimal? m3LOQT = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3UVDT = null, 
			int? m3PUCD = null, 
			decimal? m3PUPR = null, 
			decimal? m3SUPR = null, 
			DateTime? m3FVD1 = null, 
			DateTime? m3UVD1 = null, 
			decimal? m3PUP1 = null, 
			decimal? m3SUP1 = null, 
			string m3LCLV = null, 
			string m3ORCO = null, 
			string m3CTXT = null, 
			string m3QUCL = null, 
			int? m3DSPS = null, 
			int? m3VALS = null, 
			int? m3CSCT = null, 
			string m3CHNS = null, 
			string m3QCCE = null, 
			string m3TOSP = null, 
			string m3SPTT = null, 
			int? m3MCLD = null, 
			string m3CLWM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddItemSupplrQI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRCS))
				request.WithQueryParameter("PRCS", m3PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3LEA5.HasValue)
				request.WithQueryParameter("LEA5", m3LEA5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GRMT))
				request.WithQueryParameter("GRMT", m3GRMT.Trim());
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3LOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3UVDT.Value.ToM3String());
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3SUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVD1.HasValue)
				request.WithQueryParameter("FVD1", m3FVD1.Value.ToM3String());
			if (m3UVD1.HasValue)
				request.WithQueryParameter("UVD1", m3UVD1.Value.ToM3String());
			if (m3PUP1.HasValue)
				request.WithQueryParameter("PUP1", m3PUP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3SUP1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LCLV))
				request.WithQueryParameter("LCLV", m3LCLV.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTXT))
				request.WithQueryParameter("CTXT", m3CTXT.Trim());
			if (!string.IsNullOrWhiteSpace(m3QUCL))
				request.WithQueryParameter("QUCL", m3QUCL.Trim());
			if (m3DSPS.HasValue)
				request.WithQueryParameter("DSPS", m3DSPS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VALS.HasValue)
				request.WithQueryParameter("VALS", m3VALS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CSCT.HasValue)
				request.WithQueryParameter("CSCT", m3CSCT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHNS))
				request.WithQueryParameter("CHNS", m3CHNS.Trim());
			if (!string.IsNullOrWhiteSpace(m3QCCE))
				request.WithQueryParameter("QCCE", m3QCCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOSP))
				request.WithQueryParameter("TOSP", m3TOSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPTT))
				request.WithQueryParameter("SPTT", m3SPTT.Trim());
			if (m3MCLD.HasValue)
				request.WithQueryParameter("MCLD", m3MCLD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CLWM))
				request.WithQueryParameter("CLWM", m3CLWM.Trim());

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
		/// Name DelItemSupplier
		/// Description Delete Item Supplier Connect
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3PRCS">Serviceprocess</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelItemSupplier(
			string m3ITNO, 
			string m3SUNO, 
			string m3PRCS = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelItemSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRCS))
				request.WithQueryParameter("PRCS", m3PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

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
		/// Name GetItemSupplier
		/// Description Retrieve Item Supplier Connect
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3PRCS">Serviceprocess</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemSupplierResponse></returns>
		/// <exception cref="M3Exception<GetItemSupplierResponse>"></exception>
		public async Task<M3Response<GetItemSupplierResponse>> GetItemSupplier(
			string m3ITNO, 
			string m3SUNO, 
			string m3PRCS = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetItemSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRCS))
				request.WithQueryParameter("PRCS", m3PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Execute the request
			var result = await Execute<GetItemSupplierResponse>(
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
		/// Name GetItemSupplrQI
		/// Description Retrieve Item Supplier Connect QI
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3PRCS">Serviceprocess</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemSupplrQIResponse></returns>
		/// <exception cref="M3Exception<GetItemSupplrQIResponse>"></exception>
		public async Task<M3Response<GetItemSupplrQIResponse>> GetItemSupplrQI(
			string m3ITNO, 
			string m3SUNO, 
			string m3PRCS = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetItemSupplrQI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRCS))
				request.WithQueryParameter("PRCS", m3PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Execute the request
			var result = await Execute<GetItemSupplrQIResponse>(
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
		/// Name LstItemSupplier
		/// Description List Item Supplier Connect
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3SUNO">Suppliernumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemSupplierResponse></returns>
		/// <exception cref="M3Exception<LstItemSupplierResponse>"></exception>
		public async Task<M3Response<LstItemSupplierResponse>> LstItemSupplier(
			string m3ITNO, 
			string m3SUNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItemSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Execute the request
			var result = await Execute<LstItemSupplierResponse>(
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
		/// Name UpdItemSupplier
		/// Description Updates Item Supplier Connect
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3PRCS">Serviceprocess</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3RTYP">Recordtype</param>
		/// <param name="m3SITE">Supplieritemnumber</param>
		/// <param name="m3SITD">Supplieritemname</param>
		/// <param name="m3SITT">Supplieritemdescription</param>
		/// <param name="m3ISRS">Status-item/supplier</param>
		/// <param name="m3STAP">Standardofapproval</param>
		/// <param name="m3LEA5">Leadtimeforreplacementdelivery</param>
		/// <param name="m3GRMT">Goodsreceivingmethod</param>
		/// <param name="m3UNMU">Ordermultiple</param>
		/// <param name="m3ORTY">Ordertype</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3PUUN">PurchaseorderU/M</param>
		/// <param name="m3PPUN">PurchasepriceU/M</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3LOQT">Minimumorderquantity</param>
		/// <param name="m3SMSQ">Externalsafetystock</param>
		/// <param name="m3MPSH">Rawmaterialshare</param>
		/// <param name="m3ORCO">Countryoforigin</param>
		/// <param name="m3CMCO">Communicationcode</param>
		/// <param name="m3QUCL">Qualityclass</param>
		/// <param name="m3QCUD">Validto</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3MCPR">Tolerancelimit</param>
		/// <param name="m3FVDT">Validfrom</param>
		/// <param name="m3UVDT">Validto</param>
		/// <param name="m3PUCD">Purchasepricequantity</param>
		/// <param name="m3PUPR">Purchaseprice</param>
		/// <param name="m3SUPR">Setupprice</param>
		/// <param name="m3FVD1">Validfrom</param>
		/// <param name="m3UVD1">Validto</param>
		/// <param name="m3PUP1">Purchaseprice</param>
		/// <param name="m3SUP1">Setupprice</param>
		/// <param name="m3LCLV">Lowest quality inspection method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItemSupplier(
			string m3ITNO, 
			string m3SUNO, 
			string m3PRCS = null, 
			string m3SUFI = null, 
			string m3RTYP = null, 
			string m3SITE = null, 
			string m3SITD = null, 
			string m3SITT = null, 
			string m3ISRS = null, 
			string m3STAP = null, 
			int? m3LEA5 = null, 
			string m3GRMT = null, 
			decimal? m3UNMU = null, 
			string m3ORTY = null, 
			string m3RFID = null, 
			string m3PUUN = null, 
			string m3PPUN = null, 
			string m3RESP = null, 
			decimal? m3LOQT = null, 
			decimal? m3SMSQ = null, 
			int? m3MPSH = null, 
			string m3ORCO = null, 
			string m3CMCO = null, 
			string m3QUCL = null, 
			DateTime? m3QCUD = null, 
			string m3PACT = null, 
			int? m3MCPR = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3UVDT = null, 
			int? m3PUCD = null, 
			decimal? m3PUPR = null, 
			decimal? m3SUPR = null, 
			DateTime? m3FVD1 = null, 
			DateTime? m3UVD1 = null, 
			decimal? m3PUP1 = null, 
			decimal? m3SUP1 = null, 
			string m3LCLV = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdItemSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRCS))
				request.WithQueryParameter("PRCS", m3PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3RTYP))
				request.WithQueryParameter("RTYP", m3RTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITD))
				request.WithQueryParameter("SITD", m3SITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITT))
				request.WithQueryParameter("SITT", m3SITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISRS))
				request.WithQueryParameter("ISRS", m3ISRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAP))
				request.WithQueryParameter("STAP", m3STAP.Trim());
			if (m3LEA5.HasValue)
				request.WithQueryParameter("LEA5", m3LEA5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GRMT))
				request.WithQueryParameter("GRMT", m3GRMT.Trim());
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3LOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SMSQ.HasValue)
				request.WithQueryParameter("SMSQ", m3SMSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MPSH.HasValue)
				request.WithQueryParameter("MPSH", m3MPSH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMCO))
				request.WithQueryParameter("CMCO", m3CMCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QUCL))
				request.WithQueryParameter("QUCL", m3QUCL.Trim());
			if (m3QCUD.HasValue)
				request.WithQueryParameter("QCUD", m3QCUD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3MCPR.HasValue)
				request.WithQueryParameter("MCPR", m3MCPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3UVDT.Value.ToM3String());
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3SUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVD1.HasValue)
				request.WithQueryParameter("FVD1", m3FVD1.Value.ToM3String());
			if (m3UVD1.HasValue)
				request.WithQueryParameter("UVD1", m3UVD1.Value.ToM3String());
			if (m3PUP1.HasValue)
				request.WithQueryParameter("PUP1", m3PUP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3SUP1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LCLV))
				request.WithQueryParameter("LCLV", m3LCLV.Trim());

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
		/// Name UpdItemSupplrQI
		/// Description Updates Item Supplier Connect QI
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3SUNO">Suppliernumber (Required)</param>
		/// <param name="m3PRCS">Serviceprocess</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3RTYP">Recordtype</param>
		/// <param name="m3SITE">Supplieritemnumber</param>
		/// <param name="m3SITD">Supplieritemname</param>
		/// <param name="m3SITT">Supplieritemdescription</param>
		/// <param name="m3ISRS">Status-item/supplier</param>
		/// <param name="m3STAP">Standardofapproval</param>
		/// <param name="m3LEA5">Leadtimeforreplacementdelivery</param>
		/// <param name="m3GRMT">Goodsreceivingmethod</param>
		/// <param name="m3UNMU">Ordermultiple</param>
		/// <param name="m3ORTY">Ordertype</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3PUUN">PurchaseorderU/M</param>
		/// <param name="m3PPUN">PurchasepriceU/M</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3LOQT">Minimumorderquantity</param>
		/// <param name="m3SMSQ">Externalsafetystock</param>
		/// <param name="m3MPSH">Rawmaterialshare</param>
		/// <param name="m3ORCO">Countryoforigin</param>
		/// <param name="m3CMCO">Communicationcode</param>
		/// <param name="m3QUCL">Qualityclass</param>
		/// <param name="m3QCUD">Validto</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3MCPR">Tolerancelimit</param>
		/// <param name="m3FVDT">Validfrom</param>
		/// <param name="m3UVDT">Validto</param>
		/// <param name="m3PUCD">Purchasepricequantity</param>
		/// <param name="m3PUPR">Purchaseprice</param>
		/// <param name="m3SUPR">Setupprice</param>
		/// <param name="m3FVD1">Validfrom</param>
		/// <param name="m3UVD1">Validto</param>
		/// <param name="m3PUP1">Purchaseprice</param>
		/// <param name="m3SUP1">Setupprice</param>
		/// <param name="m3LCLV">Lowest quality inspection method</param>
		/// <param name="m3CSCT">Are quality inspection tasks used</param>
		/// <param name="m3CHNS">Quality inspection level - next batch</param>
		/// <param name="m3QCCE">Quality inspection level - new revision</param>
		/// <param name="m3TOSP">Quality inspection plan</param>
		/// <param name="m3SPTT">Sample table</param>
		/// <param name="m3MCLD">Minimum quality inspection interval</param>
		/// <param name="m3CLWM">QI level after minimum QI interval</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItemSupplrQI(
			string m3ITNO, 
			string m3SUNO, 
			string m3PRCS = null, 
			string m3SUFI = null, 
			string m3RTYP = null, 
			string m3SITE = null, 
			string m3SITD = null, 
			string m3SITT = null, 
			string m3ISRS = null, 
			string m3STAP = null, 
			int? m3LEA5 = null, 
			string m3GRMT = null, 
			decimal? m3UNMU = null, 
			string m3ORTY = null, 
			string m3RFID = null, 
			string m3PUUN = null, 
			string m3PPUN = null, 
			string m3RESP = null, 
			decimal? m3LOQT = null, 
			decimal? m3SMSQ = null, 
			int? m3MPSH = null, 
			string m3ORCO = null, 
			string m3CMCO = null, 
			string m3QUCL = null, 
			DateTime? m3QCUD = null, 
			string m3PACT = null, 
			int? m3MCPR = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3UVDT = null, 
			int? m3PUCD = null, 
			decimal? m3PUPR = null, 
			decimal? m3SUPR = null, 
			DateTime? m3FVD1 = null, 
			DateTime? m3UVD1 = null, 
			decimal? m3PUP1 = null, 
			decimal? m3SUP1 = null, 
			string m3LCLV = null, 
			int? m3CSCT = null, 
			string m3CHNS = null, 
			string m3QCCE = null, 
			string m3TOSP = null, 
			string m3SPTT = null, 
			int? m3MCLD = null, 
			string m3CLWM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdItemSupplrQI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRCS))
				request.WithQueryParameter("PRCS", m3PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3RTYP))
				request.WithQueryParameter("RTYP", m3RTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITD))
				request.WithQueryParameter("SITD", m3SITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SITT))
				request.WithQueryParameter("SITT", m3SITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISRS))
				request.WithQueryParameter("ISRS", m3ISRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAP))
				request.WithQueryParameter("STAP", m3STAP.Trim());
			if (m3LEA5.HasValue)
				request.WithQueryParameter("LEA5", m3LEA5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GRMT))
				request.WithQueryParameter("GRMT", m3GRMT.Trim());
			if (m3UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3UNMU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3LOQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SMSQ.HasValue)
				request.WithQueryParameter("SMSQ", m3SMSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MPSH.HasValue)
				request.WithQueryParameter("MPSH", m3MPSH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMCO))
				request.WithQueryParameter("CMCO", m3CMCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3QUCL))
				request.WithQueryParameter("QUCL", m3QUCL.Trim());
			if (m3QCUD.HasValue)
				request.WithQueryParameter("QCUD", m3QCUD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3MCPR.HasValue)
				request.WithQueryParameter("MCPR", m3MCPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3UVDT.Value.ToM3String());
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3SUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVD1.HasValue)
				request.WithQueryParameter("FVD1", m3FVD1.Value.ToM3String());
			if (m3UVD1.HasValue)
				request.WithQueryParameter("UVD1", m3UVD1.Value.ToM3String());
			if (m3PUP1.HasValue)
				request.WithQueryParameter("PUP1", m3PUP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3SUP1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LCLV))
				request.WithQueryParameter("LCLV", m3LCLV.Trim());
			if (m3CSCT.HasValue)
				request.WithQueryParameter("CSCT", m3CSCT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHNS))
				request.WithQueryParameter("CHNS", m3CHNS.Trim());
			if (!string.IsNullOrWhiteSpace(m3QCCE))
				request.WithQueryParameter("QCCE", m3QCCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOSP))
				request.WithQueryParameter("TOSP", m3TOSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPTT))
				request.WithQueryParameter("SPTT", m3SPTT.Trim());
			if (m3MCLD.HasValue)
				request.WithQueryParameter("MCLD", m3MCLD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CLWM))
				request.WithQueryParameter("CLWM", m3CLWM.Trim());

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
