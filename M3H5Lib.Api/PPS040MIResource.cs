/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItemSupplier
		/// Description Item Supplier Connect
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_PRCS">Serviceprocess</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_LEA5">Leadtimeforreplacementdelivery</param>
		/// <param name="m3_GRMT">Goodsreceivingmethod</param>
		/// <param name="m3_UNMU">Ordermultiple</param>
		/// <param name="m3_LOQT">Minimumorderquantity</param>
		/// <param name="m3_FVDT">Validfrom</param>
		/// <param name="m3_UVDT">Validto</param>
		/// <param name="m3_PUCD">Purchasepricequantity</param>
		/// <param name="m3_PUPR">Purchaseprice</param>
		/// <param name="m3_SUPR">Setupprice</param>
		/// <param name="m3_FVD1">Validfrom</param>
		/// <param name="m3_UVD1">Validto</param>
		/// <param name="m3_PUP1">Purchaseprice</param>
		/// <param name="m3_SUP1">Setupprice</param>
		/// <param name="m3_LCLV">Lowest quality inspection method</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_CTXT">Inspection text</param>
		/// <param name="m3_QUCL">Quality class</param>
		/// <param name="m3_DSPS">Display service</param>
		/// <param name="m3_VALS">No service valid</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItemSupplier(
			string m3_ITNO, 
			string m3_SUNO, 
			string m3_PRCS = null, 
			string m3_SUFI = null, 
			int? m3_LEA5 = null, 
			string m3_GRMT = null, 
			decimal? m3_UNMU = null, 
			decimal? m3_LOQT = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_UVDT = null, 
			int? m3_PUCD = null, 
			decimal? m3_PUPR = null, 
			decimal? m3_SUPR = null, 
			DateTime? m3_FVD1 = null, 
			DateTime? m3_UVD1 = null, 
			decimal? m3_PUP1 = null, 
			decimal? m3_SUP1 = null, 
			string m3_LCLV = null, 
			string m3_ORCO = null, 
			string m3_CTXT = null, 
			string m3_QUCL = null, 
			int? m3_DSPS = null, 
			int? m3_VALS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItemSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRCS))
				request.WithQueryParameter("PRCS", m3_PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_LEA5.HasValue)
				request.WithQueryParameter("LEA5", m3_LEA5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRMT))
				request.WithQueryParameter("GRMT", m3_GRMT.Trim());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3_UVDT.Value.ToM3String());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3_SUPR.Value.ToString());
			if (m3_FVD1.HasValue)
				request.WithQueryParameter("FVD1", m3_FVD1.Value.ToM3String());
			if (m3_UVD1.HasValue)
				request.WithQueryParameter("UVD1", m3_UVD1.Value.ToM3String());
			if (m3_PUP1.HasValue)
				request.WithQueryParameter("PUP1", m3_PUP1.Value.ToString());
			if (m3_SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3_SUP1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LCLV))
				request.WithQueryParameter("LCLV", m3_LCLV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTXT))
				request.WithQueryParameter("CTXT", m3_CTXT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QUCL))
				request.WithQueryParameter("QUCL", m3_QUCL.Trim());
			if (m3_DSPS.HasValue)
				request.WithQueryParameter("DSPS", m3_DSPS.Value.ToString());
			if (m3_VALS.HasValue)
				request.WithQueryParameter("VALS", m3_VALS.Value.ToString());

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
		/// Name AddItemSupplrQI
		/// Description Item Supplier Connect QI
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_PRCS">Serviceprocess</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_LEA5">Leadtimeforreplacementdelivery</param>
		/// <param name="m3_GRMT">Goodsreceivingmethod</param>
		/// <param name="m3_UNMU">Ordermultiple</param>
		/// <param name="m3_LOQT">Minimumorderquantity</param>
		/// <param name="m3_FVDT">Validfrom</param>
		/// <param name="m3_UVDT">Validto</param>
		/// <param name="m3_PUCD">Purchasepricequantity</param>
		/// <param name="m3_PUPR">Purchaseprice</param>
		/// <param name="m3_SUPR">Setupprice</param>
		/// <param name="m3_FVD1">Validfrom</param>
		/// <param name="m3_UVD1">Validto</param>
		/// <param name="m3_PUP1">Purchaseprice</param>
		/// <param name="m3_SUP1">Setupprice</param>
		/// <param name="m3_LCLV">Lowest quality inspection method</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_CTXT">Inspection text</param>
		/// <param name="m3_QUCL">Quality class</param>
		/// <param name="m3_DSPS">Display service</param>
		/// <param name="m3_VALS">No service valid</param>
		/// <param name="m3_CSCT">Are quality inspection tasks used</param>
		/// <param name="m3_CHNS">Quality inspection level - next batch</param>
		/// <param name="m3_QCCE">Quality inspection level - new revision</param>
		/// <param name="m3_TOSP">Quality inspection plan</param>
		/// <param name="m3_SPTT">Sample table</param>
		/// <param name="m3_MCLD">Minimum quality inspection interval</param>
		/// <param name="m3_CLWM">QI level after minimum QI interval</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItemSupplrQI(
			string m3_ITNO, 
			string m3_SUNO, 
			string m3_PRCS = null, 
			string m3_SUFI = null, 
			int? m3_LEA5 = null, 
			string m3_GRMT = null, 
			decimal? m3_UNMU = null, 
			decimal? m3_LOQT = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_UVDT = null, 
			int? m3_PUCD = null, 
			decimal? m3_PUPR = null, 
			decimal? m3_SUPR = null, 
			DateTime? m3_FVD1 = null, 
			DateTime? m3_UVD1 = null, 
			decimal? m3_PUP1 = null, 
			decimal? m3_SUP1 = null, 
			string m3_LCLV = null, 
			string m3_ORCO = null, 
			string m3_CTXT = null, 
			string m3_QUCL = null, 
			int? m3_DSPS = null, 
			int? m3_VALS = null, 
			int? m3_CSCT = null, 
			string m3_CHNS = null, 
			string m3_QCCE = null, 
			string m3_TOSP = null, 
			string m3_SPTT = null, 
			int? m3_MCLD = null, 
			string m3_CLWM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItemSupplrQI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRCS))
				request.WithQueryParameter("PRCS", m3_PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_LEA5.HasValue)
				request.WithQueryParameter("LEA5", m3_LEA5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRMT))
				request.WithQueryParameter("GRMT", m3_GRMT.Trim());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3_UVDT.Value.ToM3String());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3_SUPR.Value.ToString());
			if (m3_FVD1.HasValue)
				request.WithQueryParameter("FVD1", m3_FVD1.Value.ToM3String());
			if (m3_UVD1.HasValue)
				request.WithQueryParameter("UVD1", m3_UVD1.Value.ToM3String());
			if (m3_PUP1.HasValue)
				request.WithQueryParameter("PUP1", m3_PUP1.Value.ToString());
			if (m3_SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3_SUP1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LCLV))
				request.WithQueryParameter("LCLV", m3_LCLV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTXT))
				request.WithQueryParameter("CTXT", m3_CTXT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QUCL))
				request.WithQueryParameter("QUCL", m3_QUCL.Trim());
			if (m3_DSPS.HasValue)
				request.WithQueryParameter("DSPS", m3_DSPS.Value.ToString());
			if (m3_VALS.HasValue)
				request.WithQueryParameter("VALS", m3_VALS.Value.ToString());
			if (m3_CSCT.HasValue)
				request.WithQueryParameter("CSCT", m3_CSCT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHNS))
				request.WithQueryParameter("CHNS", m3_CHNS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QCCE))
				request.WithQueryParameter("QCCE", m3_QCCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOSP))
				request.WithQueryParameter("TOSP", m3_TOSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPTT))
				request.WithQueryParameter("SPTT", m3_SPTT.Trim());
			if (m3_MCLD.HasValue)
				request.WithQueryParameter("MCLD", m3_MCLD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CLWM))
				request.WithQueryParameter("CLWM", m3_CLWM.Trim());

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
		/// Name DelItemSupplier
		/// Description Delete Item Supplier Connect
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_PRCS">Serviceprocess</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelItemSupplier(
			string m3_ITNO, 
			string m3_SUNO, 
			string m3_PRCS = null, 
			string m3_SUFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelItemSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRCS))
				request.WithQueryParameter("PRCS", m3_PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());

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
		/// Name GetItemSupplier
		/// Description Retrieve Item Supplier Connect
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_PRCS">Serviceprocess</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemSupplierResponse></returns>
		/// <exception cref="M3Exception<GetItemSupplierResponse>"></exception>
		public async Task<M3Response<GetItemSupplierResponse>> GetItemSupplier(
			string m3_ITNO, 
			string m3_SUNO, 
			string m3_PRCS = null, 
			string m3_SUFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItemSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRCS))
				request.WithQueryParameter("PRCS", m3_PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Execute the request
			var result = await Execute<GetItemSupplierResponse>(
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
		/// Name GetItemSupplrQI
		/// Description Retrieve Item Supplier Connect QI
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_PRCS">Serviceprocess</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemSupplrQIResponse></returns>
		/// <exception cref="M3Exception<GetItemSupplrQIResponse>"></exception>
		public async Task<M3Response<GetItemSupplrQIResponse>> GetItemSupplrQI(
			string m3_ITNO, 
			string m3_SUNO, 
			string m3_PRCS = null, 
			string m3_SUFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItemSupplrQI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRCS))
				request.WithQueryParameter("PRCS", m3_PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Execute the request
			var result = await Execute<GetItemSupplrQIResponse>(
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
		/// Name LstItemSupplier
		/// Description List Item Supplier Connect
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_SUNO">Suppliernumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemSupplierResponse></returns>
		/// <exception cref="M3Exception<LstItemSupplierResponse>"></exception>
		public async Task<M3Response<LstItemSupplierResponse>> LstItemSupplier(
			string m3_ITNO, 
			string m3_SUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItemSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Execute the request
			var result = await Execute<LstItemSupplierResponse>(
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
		/// Name UpdItemSupplier
		/// Description Updates Item Supplier Connect
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_PRCS">Serviceprocess</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_RTYP">Recordtype</param>
		/// <param name="m3_SITE">Supplieritemnumber</param>
		/// <param name="m3_SITD">Supplieritemname</param>
		/// <param name="m3_SITT">Supplieritemdescription</param>
		/// <param name="m3_ISRS">Status-item/supplier</param>
		/// <param name="m3_STAP">Standardofapproval</param>
		/// <param name="m3_LEA5">Leadtimeforreplacementdelivery</param>
		/// <param name="m3_GRMT">Goodsreceivingmethod</param>
		/// <param name="m3_UNMU">Ordermultiple</param>
		/// <param name="m3_ORTY">Ordertype</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_PUUN">PurchaseorderU/M</param>
		/// <param name="m3_PPUN">PurchasepriceU/M</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_LOQT">Minimumorderquantity</param>
		/// <param name="m3_SMSQ">Externalsafetystock</param>
		/// <param name="m3_MPSH">Rawmaterialshare</param>
		/// <param name="m3_ORCO">Countryoforigin</param>
		/// <param name="m3_CMCO">Communicationcode</param>
		/// <param name="m3_QUCL">Qualityclass</param>
		/// <param name="m3_QCUD">Validto</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_MCPR">Tolerancelimit</param>
		/// <param name="m3_FVDT">Validfrom</param>
		/// <param name="m3_UVDT">Validto</param>
		/// <param name="m3_PUCD">Purchasepricequantity</param>
		/// <param name="m3_PUPR">Purchaseprice</param>
		/// <param name="m3_SUPR">Setupprice</param>
		/// <param name="m3_FVD1">Validfrom</param>
		/// <param name="m3_UVD1">Validto</param>
		/// <param name="m3_PUP1">Purchaseprice</param>
		/// <param name="m3_SUP1">Setupprice</param>
		/// <param name="m3_LCLV">Lowest quality inspection method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItemSupplier(
			string m3_ITNO, 
			string m3_SUNO, 
			string m3_PRCS = null, 
			string m3_SUFI = null, 
			string m3_RTYP = null, 
			string m3_SITE = null, 
			string m3_SITD = null, 
			string m3_SITT = null, 
			string m3_ISRS = null, 
			string m3_STAP = null, 
			int? m3_LEA5 = null, 
			string m3_GRMT = null, 
			decimal? m3_UNMU = null, 
			string m3_ORTY = null, 
			string m3_RFID = null, 
			string m3_PUUN = null, 
			string m3_PPUN = null, 
			string m3_RESP = null, 
			decimal? m3_LOQT = null, 
			decimal? m3_SMSQ = null, 
			int? m3_MPSH = null, 
			string m3_ORCO = null, 
			string m3_CMCO = null, 
			string m3_QUCL = null, 
			DateTime? m3_QCUD = null, 
			string m3_PACT = null, 
			int? m3_MCPR = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_UVDT = null, 
			int? m3_PUCD = null, 
			decimal? m3_PUPR = null, 
			decimal? m3_SUPR = null, 
			DateTime? m3_FVD1 = null, 
			DateTime? m3_UVD1 = null, 
			decimal? m3_PUP1 = null, 
			decimal? m3_SUP1 = null, 
			string m3_LCLV = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItemSupplier",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRCS))
				request.WithQueryParameter("PRCS", m3_PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RTYP))
				request.WithQueryParameter("RTYP", m3_RTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITD))
				request.WithQueryParameter("SITD", m3_SITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITT))
				request.WithQueryParameter("SITT", m3_SITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISRS))
				request.WithQueryParameter("ISRS", m3_ISRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAP))
				request.WithQueryParameter("STAP", m3_STAP.Trim());
			if (m3_LEA5.HasValue)
				request.WithQueryParameter("LEA5", m3_LEA5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRMT))
				request.WithQueryParameter("GRMT", m3_GRMT.Trim());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_SMSQ.HasValue)
				request.WithQueryParameter("SMSQ", m3_SMSQ.Value.ToString());
			if (m3_MPSH.HasValue)
				request.WithQueryParameter("MPSH", m3_MPSH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMCO))
				request.WithQueryParameter("CMCO", m3_CMCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QUCL))
				request.WithQueryParameter("QUCL", m3_QUCL.Trim());
			if (m3_QCUD.HasValue)
				request.WithQueryParameter("QCUD", m3_QCUD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_MCPR.HasValue)
				request.WithQueryParameter("MCPR", m3_MCPR.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3_UVDT.Value.ToM3String());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3_SUPR.Value.ToString());
			if (m3_FVD1.HasValue)
				request.WithQueryParameter("FVD1", m3_FVD1.Value.ToM3String());
			if (m3_UVD1.HasValue)
				request.WithQueryParameter("UVD1", m3_UVD1.Value.ToM3String());
			if (m3_PUP1.HasValue)
				request.WithQueryParameter("PUP1", m3_PUP1.Value.ToString());
			if (m3_SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3_SUP1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LCLV))
				request.WithQueryParameter("LCLV", m3_LCLV.Trim());

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
		/// Name UpdItemSupplrQI
		/// Description Updates Item Supplier Connect QI
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_SUNO">Suppliernumber (Required)</param>
		/// <param name="m3_PRCS">Serviceprocess</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_RTYP">Recordtype</param>
		/// <param name="m3_SITE">Supplieritemnumber</param>
		/// <param name="m3_SITD">Supplieritemname</param>
		/// <param name="m3_SITT">Supplieritemdescription</param>
		/// <param name="m3_ISRS">Status-item/supplier</param>
		/// <param name="m3_STAP">Standardofapproval</param>
		/// <param name="m3_LEA5">Leadtimeforreplacementdelivery</param>
		/// <param name="m3_GRMT">Goodsreceivingmethod</param>
		/// <param name="m3_UNMU">Ordermultiple</param>
		/// <param name="m3_ORTY">Ordertype</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_PUUN">PurchaseorderU/M</param>
		/// <param name="m3_PPUN">PurchasepriceU/M</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_LOQT">Minimumorderquantity</param>
		/// <param name="m3_SMSQ">Externalsafetystock</param>
		/// <param name="m3_MPSH">Rawmaterialshare</param>
		/// <param name="m3_ORCO">Countryoforigin</param>
		/// <param name="m3_CMCO">Communicationcode</param>
		/// <param name="m3_QUCL">Qualityclass</param>
		/// <param name="m3_QCUD">Validto</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_MCPR">Tolerancelimit</param>
		/// <param name="m3_FVDT">Validfrom</param>
		/// <param name="m3_UVDT">Validto</param>
		/// <param name="m3_PUCD">Purchasepricequantity</param>
		/// <param name="m3_PUPR">Purchaseprice</param>
		/// <param name="m3_SUPR">Setupprice</param>
		/// <param name="m3_FVD1">Validfrom</param>
		/// <param name="m3_UVD1">Validto</param>
		/// <param name="m3_PUP1">Purchaseprice</param>
		/// <param name="m3_SUP1">Setupprice</param>
		/// <param name="m3_LCLV">Lowest quality inspection method</param>
		/// <param name="m3_CSCT">Are quality inspection tasks used</param>
		/// <param name="m3_CHNS">Quality inspection level - next batch</param>
		/// <param name="m3_QCCE">Quality inspection level - new revision</param>
		/// <param name="m3_TOSP">Quality inspection plan</param>
		/// <param name="m3_SPTT">Sample table</param>
		/// <param name="m3_MCLD">Minimum quality inspection interval</param>
		/// <param name="m3_CLWM">QI level after minimum QI interval</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItemSupplrQI(
			string m3_ITNO, 
			string m3_SUNO, 
			string m3_PRCS = null, 
			string m3_SUFI = null, 
			string m3_RTYP = null, 
			string m3_SITE = null, 
			string m3_SITD = null, 
			string m3_SITT = null, 
			string m3_ISRS = null, 
			string m3_STAP = null, 
			int? m3_LEA5 = null, 
			string m3_GRMT = null, 
			decimal? m3_UNMU = null, 
			string m3_ORTY = null, 
			string m3_RFID = null, 
			string m3_PUUN = null, 
			string m3_PPUN = null, 
			string m3_RESP = null, 
			decimal? m3_LOQT = null, 
			decimal? m3_SMSQ = null, 
			int? m3_MPSH = null, 
			string m3_ORCO = null, 
			string m3_CMCO = null, 
			string m3_QUCL = null, 
			DateTime? m3_QCUD = null, 
			string m3_PACT = null, 
			int? m3_MCPR = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_UVDT = null, 
			int? m3_PUCD = null, 
			decimal? m3_PUPR = null, 
			decimal? m3_SUPR = null, 
			DateTime? m3_FVD1 = null, 
			DateTime? m3_UVD1 = null, 
			decimal? m3_PUP1 = null, 
			decimal? m3_SUP1 = null, 
			string m3_LCLV = null, 
			int? m3_CSCT = null, 
			string m3_CHNS = null, 
			string m3_QCCE = null, 
			string m3_TOSP = null, 
			string m3_SPTT = null, 
			int? m3_MCLD = null, 
			string m3_CLWM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItemSupplrQI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRCS))
				request.WithQueryParameter("PRCS", m3_PRCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RTYP))
				request.WithQueryParameter("RTYP", m3_RTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITD))
				request.WithQueryParameter("SITD", m3_SITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SITT))
				request.WithQueryParameter("SITT", m3_SITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISRS))
				request.WithQueryParameter("ISRS", m3_ISRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAP))
				request.WithQueryParameter("STAP", m3_STAP.Trim());
			if (m3_LEA5.HasValue)
				request.WithQueryParameter("LEA5", m3_LEA5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GRMT))
				request.WithQueryParameter("GRMT", m3_GRMT.Trim());
			if (m3_UNMU.HasValue)
				request.WithQueryParameter("UNMU", m3_UNMU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_LOQT.HasValue)
				request.WithQueryParameter("LOQT", m3_LOQT.Value.ToString());
			if (m3_SMSQ.HasValue)
				request.WithQueryParameter("SMSQ", m3_SMSQ.Value.ToString());
			if (m3_MPSH.HasValue)
				request.WithQueryParameter("MPSH", m3_MPSH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMCO))
				request.WithQueryParameter("CMCO", m3_CMCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QUCL))
				request.WithQueryParameter("QUCL", m3_QUCL.Trim());
			if (m3_QCUD.HasValue)
				request.WithQueryParameter("QCUD", m3_QCUD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_MCPR.HasValue)
				request.WithQueryParameter("MCPR", m3_MCPR.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_UVDT.HasValue)
				request.WithQueryParameter("UVDT", m3_UVDT.Value.ToM3String());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_SUPR.HasValue)
				request.WithQueryParameter("SUPR", m3_SUPR.Value.ToString());
			if (m3_FVD1.HasValue)
				request.WithQueryParameter("FVD1", m3_FVD1.Value.ToM3String());
			if (m3_UVD1.HasValue)
				request.WithQueryParameter("UVD1", m3_UVD1.Value.ToM3String());
			if (m3_PUP1.HasValue)
				request.WithQueryParameter("PUP1", m3_PUP1.Value.ToString());
			if (m3_SUP1.HasValue)
				request.WithQueryParameter("SUP1", m3_SUP1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LCLV))
				request.WithQueryParameter("LCLV", m3_LCLV.Trim());
			if (m3_CSCT.HasValue)
				request.WithQueryParameter("CSCT", m3_CSCT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHNS))
				request.WithQueryParameter("CHNS", m3_CHNS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QCCE))
				request.WithQueryParameter("QCCE", m3_QCCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOSP))
				request.WithQueryParameter("TOSP", m3_TOSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPTT))
				request.WithQueryParameter("SPTT", m3_SPTT.Trim());
			if (m3_MCLD.HasValue)
				request.WithQueryParameter("MCLD", m3_MCLD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CLWM))
				request.WithQueryParameter("CLWM", m3_CLWM.Trim());

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
