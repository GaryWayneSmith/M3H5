/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS280MI;
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
	/// Name: PPS280MI
	/// Component Name: PurchaseCosting
	/// Description: Api: Purchase Costing Element
	/// Version Release: 5ea0
	///</summary>
	public partial class PPS280MIResource : M3BaseResourceEndpoint
	{
		public PPS280MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS280MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddElement
		/// Description Add Purchase Costing Element
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CEID">Purchase costing element (Required)</param>
		/// <param name="m3_TX30">Text (Required)</param>
		/// <param name="m3_WSOP">Costing operator (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_OBJ1">Field</param>
		/// <param name="m3_OBJ2">Field</param>
		/// <param name="m3_OBJ3">Field</param>
		/// <param name="m3_POOV">Markup</param>
		/// <param name="m3_EXTY">Charge type</param>
		/// <param name="m3_DIMT">Distribution method</param>
		/// <param name="m3_DIUN">Distribution unit type</param>
		/// <param name="m3_EXIC">Charge invoicing</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_ATI1">Attribute identity</param>
		/// <param name="m3_ATI2">Attribute identity</param>
		/// <param name="m3_ATI3">Attribute identity</param>
		/// <param name="m3_MRF1">Value in range</param>
		/// <param name="m3_MRF2">Value in range</param>
		/// <param name="m3_MRF3">Value in range</param>
		/// <param name="m3_IVCQ">Invoice charge quantity</param>
		/// <param name="m3_THPR">Third part charge</param>
		/// <param name="m3_HELV">Hide element value</param>
		/// <param name="m3_OBJ4">Field</param>
		/// <param name="m3_OBJ5">Field</param>
		/// <param name="m3_ATI4">Attribute identity</param>
		/// <param name="m3_ATI5">Attribute identity</param>
		/// <param name="m3_FMID">Formula</param>
		/// <param name="m3_RESI">Result identity</param>
		/// <param name="m3_CTY2">Charge categori</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddElement(
			string m3_CEID, 
			string m3_TX30, 
			string m3_WSOP, 
			string m3_TX15 = null, 
			string m3_OBJ1 = null, 
			string m3_OBJ2 = null, 
			string m3_OBJ3 = null, 
			int? m3_POOV = null, 
			int? m3_EXTY = null, 
			int? m3_DIMT = null, 
			int? m3_DIUN = null, 
			int? m3_EXIC = null, 
			string m3_ACRF = null, 
			int? m3_VTCD = null, 
			string m3_ATI1 = null, 
			string m3_ATI2 = null, 
			string m3_ATI3 = null, 
			int? m3_MRF1 = null, 
			int? m3_MRF2 = null, 
			int? m3_MRF3 = null, 
			int? m3_IVCQ = null, 
			int? m3_THPR = null, 
			int? m3_HELV = null, 
			string m3_OBJ4 = null, 
			string m3_OBJ5 = null, 
			string m3_ATI4 = null, 
			string m3_ATI5 = null, 
			string m3_FMID = null, 
			string m3_RESI = null, 
			int? m3_CTY2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CEID))
				throw new ArgumentNullException("m3_CEID");
			if (string.IsNullOrWhiteSpace(m3_TX30))
				throw new ArgumentNullException("m3_TX30");
			if (string.IsNullOrWhiteSpace(m3_WSOP))
				throw new ArgumentNullException("m3_WSOP");

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3_CEID.Trim())
				.WithQueryParameter("TX30", m3_TX30.Trim())
				.WithQueryParameter("WSOP", m3_WSOP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ1))
				request.WithQueryParameter("OBJ1", m3_OBJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ2))
				request.WithQueryParameter("OBJ2", m3_OBJ2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ3))
				request.WithQueryParameter("OBJ3", m3_OBJ3.Trim());
			if (m3_POOV.HasValue)
				request.WithQueryParameter("POOV", m3_POOV.Value.ToString());
			if (m3_EXTY.HasValue)
				request.WithQueryParameter("EXTY", m3_EXTY.Value.ToString());
			if (m3_DIMT.HasValue)
				request.WithQueryParameter("DIMT", m3_DIMT.Value.ToString());
			if (m3_DIUN.HasValue)
				request.WithQueryParameter("DIUN", m3_DIUN.Value.ToString());
			if (m3_EXIC.HasValue)
				request.WithQueryParameter("EXIC", m3_EXIC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATI1))
				request.WithQueryParameter("ATI1", m3_ATI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI2))
				request.WithQueryParameter("ATI2", m3_ATI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI3))
				request.WithQueryParameter("ATI3", m3_ATI3.Trim());
			if (m3_MRF1.HasValue)
				request.WithQueryParameter("MRF1", m3_MRF1.Value.ToString());
			if (m3_MRF2.HasValue)
				request.WithQueryParameter("MRF2", m3_MRF2.Value.ToString());
			if (m3_MRF3.HasValue)
				request.WithQueryParameter("MRF3", m3_MRF3.Value.ToString());
			if (m3_IVCQ.HasValue)
				request.WithQueryParameter("IVCQ", m3_IVCQ.Value.ToString());
			if (m3_THPR.HasValue)
				request.WithQueryParameter("THPR", m3_THPR.Value.ToString());
			if (m3_HELV.HasValue)
				request.WithQueryParameter("HELV", m3_HELV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBJ4))
				request.WithQueryParameter("OBJ4", m3_OBJ4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ5))
				request.WithQueryParameter("OBJ5", m3_OBJ5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI4))
				request.WithQueryParameter("ATI4", m3_ATI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI5))
				request.WithQueryParameter("ATI5", m3_ATI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMID))
				request.WithQueryParameter("FMID", m3_FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESI))
				request.WithQueryParameter("RESI", m3_RESI.Trim());
			if (m3_CTY2.HasValue)
				request.WithQueryParameter("CTY2", m3_CTY2.Value.ToString());

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
		/// Name AddElementValue
		/// Description Add Purchase Costing Element Value
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CEID">Purchase costing element (Required)</param>
		/// <param name="m3_OVK1">Costing key 1 (Required)</param>
		/// <param name="m3_OVK2">Costing key 2 (Required)</param>
		/// <param name="m3_OVK3">Costing key 3 (Required)</param>
		/// <param name="m3_VFDT">Valid from (Required)</param>
		/// <param name="m3_OVHE">Costing markup</param>
		/// <param name="m3_OVCD">Batch price quantity</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_FMID">Formula</param>
		/// <param name="m3_RESI">Result identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_OVK4">Costing key 4</param>
		/// <param name="m3_OVK5">Costing key 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddElementValue(
			string m3_CEID, 
			string m3_OVK1, 
			string m3_OVK2, 
			string m3_OVK3, 
			DateTime m3_VFDT, 
			decimal? m3_OVHE = null, 
			int? m3_OVCD = null, 
			string m3_CUCD = null, 
			int? m3_CRTP = null, 
			string m3_FMID = null, 
			string m3_RESI = null, 
			decimal? m3_TXID = null, 
			string m3_OVK4 = null, 
			string m3_OVK5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddElementValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CEID))
				throw new ArgumentNullException("m3_CEID");
			if (string.IsNullOrWhiteSpace(m3_OVK1))
				throw new ArgumentNullException("m3_OVK1");
			if (string.IsNullOrWhiteSpace(m3_OVK2))
				throw new ArgumentNullException("m3_OVK2");
			if (string.IsNullOrWhiteSpace(m3_OVK3))
				throw new ArgumentNullException("m3_OVK3");

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3_CEID.Trim())
				.WithQueryParameter("OVK1", m3_OVK1.Trim())
				.WithQueryParameter("OVK2", m3_OVK2.Trim())
				.WithQueryParameter("OVK3", m3_OVK3.Trim())
				.WithQueryParameter("VFDT", m3_VFDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_OVHE.HasValue)
				request.WithQueryParameter("OVHE", m3_OVHE.Value.ToString());
			if (m3_OVCD.HasValue)
				request.WithQueryParameter("OVCD", m3_OVCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FMID))
				request.WithQueryParameter("FMID", m3_FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESI))
				request.WithQueryParameter("RESI", m3_RESI.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OVK4))
				request.WithQueryParameter("OVK4", m3_OVK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVK5))
				request.WithQueryParameter("OVK5", m3_OVK5.Trim());

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
		/// Name DltElementValue
		/// Description Delete Purchase Costing Element Value
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CEID">Purchase costing element (Required)</param>
		/// <param name="m3_OVK1">Costing key 1 (Required)</param>
		/// <param name="m3_OVK2">Costing key 2 (Required)</param>
		/// <param name="m3_OVK3">Costing key 3 (Required)</param>
		/// <param name="m3_VFDT">Valid from (Required)</param>
		/// <param name="m3_OVK4">Costing key 4</param>
		/// <param name="m3_OVK5">Costing key 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltElementValue(
			string m3_CEID, 
			string m3_OVK1, 
			string m3_OVK2, 
			string m3_OVK3, 
			DateTime m3_VFDT, 
			string m3_OVK4 = null, 
			string m3_OVK5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltElementValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CEID))
				throw new ArgumentNullException("m3_CEID");
			if (string.IsNullOrWhiteSpace(m3_OVK1))
				throw new ArgumentNullException("m3_OVK1");
			if (string.IsNullOrWhiteSpace(m3_OVK2))
				throw new ArgumentNullException("m3_OVK2");
			if (string.IsNullOrWhiteSpace(m3_OVK3))
				throw new ArgumentNullException("m3_OVK3");

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3_CEID.Trim())
				.WithQueryParameter("OVK1", m3_OVK1.Trim())
				.WithQueryParameter("OVK2", m3_OVK2.Trim())
				.WithQueryParameter("OVK3", m3_OVK3.Trim())
				.WithQueryParameter("VFDT", m3_VFDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OVK4))
				request.WithQueryParameter("OVK4", m3_OVK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVK5))
				request.WithQueryParameter("OVK5", m3_OVK5.Trim());

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
		/// Name GetElement
		/// Description Get Purchase Costing Elements
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CEID">Purchase costing element (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetElementResponse></returns>
		/// <exception cref="M3Exception<GetElementResponse>"></exception>
		public async Task<M3Response<GetElementResponse>> GetElement(
			string m3_CEID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CEID))
				throw new ArgumentNullException("m3_CEID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3_CEID.Trim());

			// Execute the request
			var result = await Execute<GetElementResponse>(
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
		/// Name GetElementValue
		/// Description Get Purchase Costing Element Value
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CEID">Purchase costing element (Required)</param>
		/// <param name="m3_OVK1">Costing key 1 (Required)</param>
		/// <param name="m3_OVK2">Costing key 2 (Required)</param>
		/// <param name="m3_OVK3">Costing key 3 (Required)</param>
		/// <param name="m3_VFDT">Valid from (Required)</param>
		/// <param name="m3_OVK4">Costing key 4</param>
		/// <param name="m3_OVK5">Costing key 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetElementValueResponse></returns>
		/// <exception cref="M3Exception<GetElementValueResponse>"></exception>
		public async Task<M3Response<GetElementValueResponse>> GetElementValue(
			string m3_CEID, 
			string m3_OVK1, 
			string m3_OVK2, 
			string m3_OVK3, 
			DateTime m3_VFDT, 
			string m3_OVK4 = null, 
			string m3_OVK5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetElementValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CEID))
				throw new ArgumentNullException("m3_CEID");
			if (string.IsNullOrWhiteSpace(m3_OVK1))
				throw new ArgumentNullException("m3_OVK1");
			if (string.IsNullOrWhiteSpace(m3_OVK2))
				throw new ArgumentNullException("m3_OVK2");
			if (string.IsNullOrWhiteSpace(m3_OVK3))
				throw new ArgumentNullException("m3_OVK3");

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3_CEID.Trim())
				.WithQueryParameter("OVK1", m3_OVK1.Trim())
				.WithQueryParameter("OVK2", m3_OVK2.Trim())
				.WithQueryParameter("OVK3", m3_OVK3.Trim())
				.WithQueryParameter("VFDT", m3_VFDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OVK4))
				request.WithQueryParameter("OVK4", m3_OVK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVK5))
				request.WithQueryParameter("OVK5", m3_OVK5.Trim());

			// Execute the request
			var result = await Execute<GetElementValueResponse>(
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
		/// Name LstElement
		/// Description List Purchase Costing Elements
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CEID">Purchase costing element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElementResponse></returns>
		/// <exception cref="M3Exception<LstElementResponse>"></exception>
		public async Task<M3Response<LstElementResponse>> LstElement(
			string m3_CEID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstElement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CEID))
				request.WithQueryParameter("CEID", m3_CEID.Trim());

			// Execute the request
			var result = await Execute<LstElementResponse>(
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
		/// Name LstElementRange
		/// Description List Range of Purchase Costing Elements
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FEID">Purchase costing element (From)</param>
		/// <param name="m3_TEID">Purchase costing element (To)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElementRangeResponse></returns>
		/// <exception cref="M3Exception<LstElementRangeResponse>"></exception>
		public async Task<M3Response<LstElementRangeResponse>> LstElementRange(
			int? m3_CONO = null, 
			string m3_FEID = null, 
			string m3_TEID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstElementRange",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FEID))
				request.WithQueryParameter("FEID", m3_FEID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEID))
				request.WithQueryParameter("TEID", m3_TEID.Trim());

			// Execute the request
			var result = await Execute<LstElementRangeResponse>(
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
		/// Name LstElementValue
		/// Description List Purchase Costing Element Value
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CEID">Purchase costing element (Required)</param>
		/// <param name="m3_OVK1">Costing key 1</param>
		/// <param name="m3_OVK2">Costing key 2</param>
		/// <param name="m3_OVK3">Costing key 3</param>
		/// <param name="m3_OVK4">Costing key 4</param>
		/// <param name="m3_OVK5">Costing key 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElementValueResponse></returns>
		/// <exception cref="M3Exception<LstElementValueResponse>"></exception>
		public async Task<M3Response<LstElementValueResponse>> LstElementValue(
			string m3_CEID, 
			string m3_OVK1 = null, 
			string m3_OVK2 = null, 
			string m3_OVK3 = null, 
			string m3_OVK4 = null, 
			string m3_OVK5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstElementValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CEID))
				throw new ArgumentNullException("m3_CEID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3_CEID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OVK1))
				request.WithQueryParameter("OVK1", m3_OVK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVK2))
				request.WithQueryParameter("OVK2", m3_OVK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVK3))
				request.WithQueryParameter("OVK3", m3_OVK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVK4))
				request.WithQueryParameter("OVK4", m3_OVK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVK5))
				request.WithQueryParameter("OVK5", m3_OVK5.Trim());

			// Execute the request
			var result = await Execute<LstElementValueResponse>(
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
		/// Name UpdElement
		/// Description Update Purchase Costing Element
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CEID">Purchase costing element (Required)</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_OBJ1">Field</param>
		/// <param name="m3_OBJ2">Field</param>
		/// <param name="m3_OBJ3">Field</param>
		/// <param name="m3_WSOP">Costing operator</param>
		/// <param name="m3_POOV">Markup</param>
		/// <param name="m3_EXTY">Charge type</param>
		/// <param name="m3_DIMT">Distribution method</param>
		/// <param name="m3_DIUN">Distribution unit type</param>
		/// <param name="m3_EXIC">Charge invoicing</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_ATI1">Attribute identity</param>
		/// <param name="m3_ATI2">Attribute identity</param>
		/// <param name="m3_ATI3">Attribute identity</param>
		/// <param name="m3_MRF1">Value in range</param>
		/// <param name="m3_MRF2">Value in range</param>
		/// <param name="m3_MRF3">Value in range</param>
		/// <param name="m3_IVCQ">Invoice charge quantity</param>
		/// <param name="m3_THPR">Third part charge</param>
		/// <param name="m3_HELV">Hide element value</param>
		/// <param name="m3_OBJ4">Field</param>
		/// <param name="m3_OBJ5">Field</param>
		/// <param name="m3_ATI4">Attribute identity</param>
		/// <param name="m3_ATI5">Attribute identity</param>
		/// <param name="m3_FMID">Formula</param>
		/// <param name="m3_RESI">Result identity</param>
		/// <param name="m3_DUM1">Field not used</param>
		/// <param name="m3_CTY2">Charge category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdElement(
			string m3_CEID, 
			string m3_TX30 = null, 
			string m3_TX15 = null, 
			string m3_OBJ1 = null, 
			string m3_OBJ2 = null, 
			string m3_OBJ3 = null, 
			string m3_WSOP = null, 
			int? m3_POOV = null, 
			int? m3_EXTY = null, 
			int? m3_DIMT = null, 
			int? m3_DIUN = null, 
			int? m3_EXIC = null, 
			string m3_ACRF = null, 
			int? m3_VTCD = null, 
			string m3_ATI1 = null, 
			string m3_ATI2 = null, 
			string m3_ATI3 = null, 
			int? m3_MRF1 = null, 
			int? m3_MRF2 = null, 
			int? m3_MRF3 = null, 
			int? m3_IVCQ = null, 
			int? m3_THPR = null, 
			int? m3_HELV = null, 
			string m3_OBJ4 = null, 
			string m3_OBJ5 = null, 
			string m3_ATI4 = null, 
			string m3_ATI5 = null, 
			string m3_FMID = null, 
			string m3_RESI = null, 
			string m3_DUM1 = null, 
			int? m3_CTY2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CEID))
				throw new ArgumentNullException("m3_CEID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3_CEID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ1))
				request.WithQueryParameter("OBJ1", m3_OBJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ2))
				request.WithQueryParameter("OBJ2", m3_OBJ2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ3))
				request.WithQueryParameter("OBJ3", m3_OBJ3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WSOP))
				request.WithQueryParameter("WSOP", m3_WSOP.Trim());
			if (m3_POOV.HasValue)
				request.WithQueryParameter("POOV", m3_POOV.Value.ToString());
			if (m3_EXTY.HasValue)
				request.WithQueryParameter("EXTY", m3_EXTY.Value.ToString());
			if (m3_DIMT.HasValue)
				request.WithQueryParameter("DIMT", m3_DIMT.Value.ToString());
			if (m3_DIUN.HasValue)
				request.WithQueryParameter("DIUN", m3_DIUN.Value.ToString());
			if (m3_EXIC.HasValue)
				request.WithQueryParameter("EXIC", m3_EXIC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATI1))
				request.WithQueryParameter("ATI1", m3_ATI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI2))
				request.WithQueryParameter("ATI2", m3_ATI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI3))
				request.WithQueryParameter("ATI3", m3_ATI3.Trim());
			if (m3_MRF1.HasValue)
				request.WithQueryParameter("MRF1", m3_MRF1.Value.ToString());
			if (m3_MRF2.HasValue)
				request.WithQueryParameter("MRF2", m3_MRF2.Value.ToString());
			if (m3_MRF3.HasValue)
				request.WithQueryParameter("MRF3", m3_MRF3.Value.ToString());
			if (m3_IVCQ.HasValue)
				request.WithQueryParameter("IVCQ", m3_IVCQ.Value.ToString());
			if (m3_THPR.HasValue)
				request.WithQueryParameter("THPR", m3_THPR.Value.ToString());
			if (m3_HELV.HasValue)
				request.WithQueryParameter("HELV", m3_HELV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBJ4))
				request.WithQueryParameter("OBJ4", m3_OBJ4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ5))
				request.WithQueryParameter("OBJ5", m3_OBJ5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI4))
				request.WithQueryParameter("ATI4", m3_ATI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI5))
				request.WithQueryParameter("ATI5", m3_ATI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMID))
				request.WithQueryParameter("FMID", m3_FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESI))
				request.WithQueryParameter("RESI", m3_RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DUM1))
				request.WithQueryParameter("DUM1", m3_DUM1.Trim());
			if (m3_CTY2.HasValue)
				request.WithQueryParameter("CTY2", m3_CTY2.Value.ToString());

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
		/// Name UpdElementValue
		/// Description Update Purchase Costing Element Value
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CEID">Purchase costing element (Required)</param>
		/// <param name="m3_OVK1">Costing key 1 (Required)</param>
		/// <param name="m3_OVK2">Costing key 2 (Required)</param>
		/// <param name="m3_OVK3">Costing key 3 (Required)</param>
		/// <param name="m3_VFDT">Valid from (Required)</param>
		/// <param name="m3_OVHE">Costing markup</param>
		/// <param name="m3_OVCD">Batch price quantity</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_FMID">Formula</param>
		/// <param name="m3_RESI">Result identity</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_OVK4">Costing key 4</param>
		/// <param name="m3_OVK5">Costing key 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdElementValue(
			string m3_CEID, 
			string m3_OVK1, 
			string m3_OVK2, 
			string m3_OVK3, 
			DateTime m3_VFDT, 
			decimal? m3_OVHE = null, 
			int? m3_OVCD = null, 
			string m3_CUCD = null, 
			int? m3_CRTP = null, 
			string m3_FMID = null, 
			string m3_RESI = null, 
			decimal? m3_TXID = null, 
			string m3_OVK4 = null, 
			string m3_OVK5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdElementValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CEID))
				throw new ArgumentNullException("m3_CEID");
			if (string.IsNullOrWhiteSpace(m3_OVK1))
				throw new ArgumentNullException("m3_OVK1");
			if (string.IsNullOrWhiteSpace(m3_OVK2))
				throw new ArgumentNullException("m3_OVK2");
			if (string.IsNullOrWhiteSpace(m3_OVK3))
				throw new ArgumentNullException("m3_OVK3");

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3_CEID.Trim())
				.WithQueryParameter("OVK1", m3_OVK1.Trim())
				.WithQueryParameter("OVK2", m3_OVK2.Trim())
				.WithQueryParameter("OVK3", m3_OVK3.Trim())
				.WithQueryParameter("VFDT", m3_VFDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_OVHE.HasValue)
				request.WithQueryParameter("OVHE", m3_OVHE.Value.ToString());
			if (m3_OVCD.HasValue)
				request.WithQueryParameter("OVCD", m3_OVCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FMID))
				request.WithQueryParameter("FMID", m3_FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESI))
				request.WithQueryParameter("RESI", m3_RESI.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OVK4))
				request.WithQueryParameter("OVK4", m3_OVK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVK5))
				request.WithQueryParameter("OVK5", m3_OVK5.Trim());

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
