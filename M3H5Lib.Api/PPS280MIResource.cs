/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddElement
		/// Description Add Purchase Costing Element
		/// Version Release: 
		/// </summary>
		/// <param name="m3CEID">Purchase costing element (Required)</param>
		/// <param name="m3TX30">Text (Required)</param>
		/// <param name="m3WSOP">Costing operator (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3OBJ1">Field</param>
		/// <param name="m3OBJ2">Field</param>
		/// <param name="m3OBJ3">Field</param>
		/// <param name="m3POOV">Markup</param>
		/// <param name="m3EXTY">Charge type</param>
		/// <param name="m3DIMT">Distribution method</param>
		/// <param name="m3DIUN">Distribution unit type</param>
		/// <param name="m3EXIC">Charge invoicing</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3ATI1">Attribute identity</param>
		/// <param name="m3ATI2">Attribute identity</param>
		/// <param name="m3ATI3">Attribute identity</param>
		/// <param name="m3MRF1">Value in range</param>
		/// <param name="m3MRF2">Value in range</param>
		/// <param name="m3MRF3">Value in range</param>
		/// <param name="m3IVCQ">Invoice charge quantity</param>
		/// <param name="m3THPR">Third part charge</param>
		/// <param name="m3HELV">Hide element value</param>
		/// <param name="m3OBJ4">Field</param>
		/// <param name="m3OBJ5">Field</param>
		/// <param name="m3ATI4">Attribute identity</param>
		/// <param name="m3ATI5">Attribute identity</param>
		/// <param name="m3FMID">Formula</param>
		/// <param name="m3RESI">Result identity</param>
		/// <param name="m3CTY2">Charge categori</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddElement(
			string m3CEID, 
			string m3TX30, 
			string m3WSOP, 
			string m3TX15 = null, 
			string m3OBJ1 = null, 
			string m3OBJ2 = null, 
			string m3OBJ3 = null, 
			int? m3POOV = null, 
			int? m3EXTY = null, 
			int? m3DIMT = null, 
			int? m3DIUN = null, 
			int? m3EXIC = null, 
			string m3ACRF = null, 
			int? m3VTCD = null, 
			string m3ATI1 = null, 
			string m3ATI2 = null, 
			string m3ATI3 = null, 
			int? m3MRF1 = null, 
			int? m3MRF2 = null, 
			int? m3MRF3 = null, 
			int? m3IVCQ = null, 
			int? m3THPR = null, 
			int? m3HELV = null, 
			string m3OBJ4 = null, 
			string m3OBJ5 = null, 
			string m3ATI4 = null, 
			string m3ATI5 = null, 
			string m3FMID = null, 
			string m3RESI = null, 
			int? m3CTY2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CEID))
				throw new ArgumentNullException(nameof(m3CEID));
			if (string.IsNullOrWhiteSpace(m3TX30))
				throw new ArgumentNullException(nameof(m3TX30));
			if (string.IsNullOrWhiteSpace(m3WSOP))
				throw new ArgumentNullException(nameof(m3WSOP));

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3CEID.Trim())
				.WithQueryParameter("TX30", m3TX30.Trim())
				.WithQueryParameter("WSOP", m3WSOP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ1))
				request.WithQueryParameter("OBJ1", m3OBJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ2))
				request.WithQueryParameter("OBJ2", m3OBJ2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ3))
				request.WithQueryParameter("OBJ3", m3OBJ3.Trim());
			if (m3POOV.HasValue)
				request.WithQueryParameter("POOV", m3POOV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXTY.HasValue)
				request.WithQueryParameter("EXTY", m3EXTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIMT.HasValue)
				request.WithQueryParameter("DIMT", m3DIMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIUN.HasValue)
				request.WithQueryParameter("DIUN", m3DIUN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXIC.HasValue)
				request.WithQueryParameter("EXIC", m3EXIC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATI1))
				request.WithQueryParameter("ATI1", m3ATI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI2))
				request.WithQueryParameter("ATI2", m3ATI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI3))
				request.WithQueryParameter("ATI3", m3ATI3.Trim());
			if (m3MRF1.HasValue)
				request.WithQueryParameter("MRF1", m3MRF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRF2.HasValue)
				request.WithQueryParameter("MRF2", m3MRF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRF3.HasValue)
				request.WithQueryParameter("MRF3", m3MRF3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVCQ.HasValue)
				request.WithQueryParameter("IVCQ", m3IVCQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3THPR.HasValue)
				request.WithQueryParameter("THPR", m3THPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HELV.HasValue)
				request.WithQueryParameter("HELV", m3HELV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBJ4))
				request.WithQueryParameter("OBJ4", m3OBJ4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ5))
				request.WithQueryParameter("OBJ5", m3OBJ5.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI4))
				request.WithQueryParameter("ATI4", m3ATI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI5))
				request.WithQueryParameter("ATI5", m3ATI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMID))
				request.WithQueryParameter("FMID", m3FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESI))
				request.WithQueryParameter("RESI", m3RESI.Trim());
			if (m3CTY2.HasValue)
				request.WithQueryParameter("CTY2", m3CTY2.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddElementValue
		/// Description Add Purchase Costing Element Value
		/// Version Release: 
		/// </summary>
		/// <param name="m3CEID">Purchase costing element (Required)</param>
		/// <param name="m3OVK1">Costing key 1 (Required)</param>
		/// <param name="m3OVK2">Costing key 2 (Required)</param>
		/// <param name="m3OVK3">Costing key 3 (Required)</param>
		/// <param name="m3VFDT">Valid from (Required)</param>
		/// <param name="m3OVHE">Costing markup</param>
		/// <param name="m3OVCD">Batch price quantity</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3FMID">Formula</param>
		/// <param name="m3RESI">Result identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3OVK4">Costing key 4</param>
		/// <param name="m3OVK5">Costing key 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddElementValue(
			string m3CEID, 
			string m3OVK1, 
			string m3OVK2, 
			string m3OVK3, 
			DateTime m3VFDT, 
			decimal? m3OVHE = null, 
			int? m3OVCD = null, 
			string m3CUCD = null, 
			int? m3CRTP = null, 
			string m3FMID = null, 
			string m3RESI = null, 
			decimal? m3TXID = null, 
			string m3OVK4 = null, 
			string m3OVK5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddElementValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CEID))
				throw new ArgumentNullException(nameof(m3CEID));
			if (string.IsNullOrWhiteSpace(m3OVK1))
				throw new ArgumentNullException(nameof(m3OVK1));
			if (string.IsNullOrWhiteSpace(m3OVK2))
				throw new ArgumentNullException(nameof(m3OVK2));
			if (string.IsNullOrWhiteSpace(m3OVK3))
				throw new ArgumentNullException(nameof(m3OVK3));

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3CEID.Trim())
				.WithQueryParameter("OVK1", m3OVK1.Trim())
				.WithQueryParameter("OVK2", m3OVK2.Trim())
				.WithQueryParameter("OVK3", m3OVK3.Trim())
				.WithQueryParameter("VFDT", m3VFDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3OVHE.HasValue)
				request.WithQueryParameter("OVHE", m3OVHE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OVCD.HasValue)
				request.WithQueryParameter("OVCD", m3OVCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FMID))
				request.WithQueryParameter("FMID", m3FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESI))
				request.WithQueryParameter("RESI", m3RESI.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OVK4))
				request.WithQueryParameter("OVK4", m3OVK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVK5))
				request.WithQueryParameter("OVK5", m3OVK5.Trim());

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
		/// Name DltElementValue
		/// Description Delete Purchase Costing Element Value
		/// Version Release: 
		/// </summary>
		/// <param name="m3CEID">Purchase costing element (Required)</param>
		/// <param name="m3OVK1">Costing key 1 (Required)</param>
		/// <param name="m3OVK2">Costing key 2 (Required)</param>
		/// <param name="m3OVK3">Costing key 3 (Required)</param>
		/// <param name="m3VFDT">Valid from (Required)</param>
		/// <param name="m3OVK4">Costing key 4</param>
		/// <param name="m3OVK5">Costing key 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltElementValue(
			string m3CEID, 
			string m3OVK1, 
			string m3OVK2, 
			string m3OVK3, 
			DateTime m3VFDT, 
			string m3OVK4 = null, 
			string m3OVK5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltElementValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CEID))
				throw new ArgumentNullException(nameof(m3CEID));
			if (string.IsNullOrWhiteSpace(m3OVK1))
				throw new ArgumentNullException(nameof(m3OVK1));
			if (string.IsNullOrWhiteSpace(m3OVK2))
				throw new ArgumentNullException(nameof(m3OVK2));
			if (string.IsNullOrWhiteSpace(m3OVK3))
				throw new ArgumentNullException(nameof(m3OVK3));

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3CEID.Trim())
				.WithQueryParameter("OVK1", m3OVK1.Trim())
				.WithQueryParameter("OVK2", m3OVK2.Trim())
				.WithQueryParameter("OVK3", m3OVK3.Trim())
				.WithQueryParameter("VFDT", m3VFDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OVK4))
				request.WithQueryParameter("OVK4", m3OVK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVK5))
				request.WithQueryParameter("OVK5", m3OVK5.Trim());

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
		/// Name GetElement
		/// Description Get Purchase Costing Elements
		/// Version Release: 
		/// </summary>
		/// <param name="m3CEID">Purchase costing element (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetElementResponse></returns>
		/// <exception cref="M3Exception<GetElementResponse>"></exception>
		public async Task<M3Response<GetElementResponse>> GetElement(
			string m3CEID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CEID))
				throw new ArgumentNullException(nameof(m3CEID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3CEID.Trim());

			// Execute the request
			var result = await Execute<GetElementResponse>(
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
		/// Name GetElementValue
		/// Description Get Purchase Costing Element Value
		/// Version Release: 
		/// </summary>
		/// <param name="m3CEID">Purchase costing element (Required)</param>
		/// <param name="m3OVK1">Costing key 1 (Required)</param>
		/// <param name="m3OVK2">Costing key 2 (Required)</param>
		/// <param name="m3OVK3">Costing key 3 (Required)</param>
		/// <param name="m3VFDT">Valid from (Required)</param>
		/// <param name="m3OVK4">Costing key 4</param>
		/// <param name="m3OVK5">Costing key 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetElementValueResponse></returns>
		/// <exception cref="M3Exception<GetElementValueResponse>"></exception>
		public async Task<M3Response<GetElementValueResponse>> GetElementValue(
			string m3CEID, 
			string m3OVK1, 
			string m3OVK2, 
			string m3OVK3, 
			DateTime m3VFDT, 
			string m3OVK4 = null, 
			string m3OVK5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetElementValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CEID))
				throw new ArgumentNullException(nameof(m3CEID));
			if (string.IsNullOrWhiteSpace(m3OVK1))
				throw new ArgumentNullException(nameof(m3OVK1));
			if (string.IsNullOrWhiteSpace(m3OVK2))
				throw new ArgumentNullException(nameof(m3OVK2));
			if (string.IsNullOrWhiteSpace(m3OVK3))
				throw new ArgumentNullException(nameof(m3OVK3));

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3CEID.Trim())
				.WithQueryParameter("OVK1", m3OVK1.Trim())
				.WithQueryParameter("OVK2", m3OVK2.Trim())
				.WithQueryParameter("OVK3", m3OVK3.Trim())
				.WithQueryParameter("VFDT", m3VFDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OVK4))
				request.WithQueryParameter("OVK4", m3OVK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVK5))
				request.WithQueryParameter("OVK5", m3OVK5.Trim());

			// Execute the request
			var result = await Execute<GetElementValueResponse>(
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
		/// Name LstElement
		/// Description List Purchase Costing Elements
		/// Version Release: 
		/// </summary>
		/// <param name="m3CEID">Purchase costing element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElementResponse></returns>
		/// <exception cref="M3Exception<LstElementResponse>"></exception>
		public async Task<M3Response<LstElementResponse>> LstElement(
			string m3CEID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstElement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CEID))
				request.WithQueryParameter("CEID", m3CEID.Trim());

			// Execute the request
			var result = await Execute<LstElementResponse>(
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
		/// Name LstElementRange
		/// Description List Range of Purchase Costing Elements
		/// Version Release: 
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FEID">Purchase costing element (From)</param>
		/// <param name="m3TEID">Purchase costing element (To)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElementRangeResponse></returns>
		/// <exception cref="M3Exception<LstElementRangeResponse>"></exception>
		public async Task<M3Response<LstElementRangeResponse>> LstElementRange(
			int? m3CONO = null, 
			string m3FEID = null, 
			string m3TEID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstElementRange",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FEID))
				request.WithQueryParameter("FEID", m3FEID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEID))
				request.WithQueryParameter("TEID", m3TEID.Trim());

			// Execute the request
			var result = await Execute<LstElementRangeResponse>(
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
		/// Name LstElementValue
		/// Description List Purchase Costing Element Value
		/// Version Release: 
		/// </summary>
		/// <param name="m3CEID">Purchase costing element (Required)</param>
		/// <param name="m3OVK1">Costing key 1</param>
		/// <param name="m3OVK2">Costing key 2</param>
		/// <param name="m3OVK3">Costing key 3</param>
		/// <param name="m3OVK4">Costing key 4</param>
		/// <param name="m3OVK5">Costing key 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElementValueResponse></returns>
		/// <exception cref="M3Exception<LstElementValueResponse>"></exception>
		public async Task<M3Response<LstElementValueResponse>> LstElementValue(
			string m3CEID, 
			string m3OVK1 = null, 
			string m3OVK2 = null, 
			string m3OVK3 = null, 
			string m3OVK4 = null, 
			string m3OVK5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstElementValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CEID))
				throw new ArgumentNullException(nameof(m3CEID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3CEID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OVK1))
				request.WithQueryParameter("OVK1", m3OVK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVK2))
				request.WithQueryParameter("OVK2", m3OVK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVK3))
				request.WithQueryParameter("OVK3", m3OVK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVK4))
				request.WithQueryParameter("OVK4", m3OVK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVK5))
				request.WithQueryParameter("OVK5", m3OVK5.Trim());

			// Execute the request
			var result = await Execute<LstElementValueResponse>(
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
		/// Name UpdElement
		/// Description Update Purchase Costing Element
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CEID">Purchase costing element (Required)</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3OBJ1">Field</param>
		/// <param name="m3OBJ2">Field</param>
		/// <param name="m3OBJ3">Field</param>
		/// <param name="m3WSOP">Costing operator</param>
		/// <param name="m3POOV">Markup</param>
		/// <param name="m3EXTY">Charge type</param>
		/// <param name="m3DIMT">Distribution method</param>
		/// <param name="m3DIUN">Distribution unit type</param>
		/// <param name="m3EXIC">Charge invoicing</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3ATI1">Attribute identity</param>
		/// <param name="m3ATI2">Attribute identity</param>
		/// <param name="m3ATI3">Attribute identity</param>
		/// <param name="m3MRF1">Value in range</param>
		/// <param name="m3MRF2">Value in range</param>
		/// <param name="m3MRF3">Value in range</param>
		/// <param name="m3IVCQ">Invoice charge quantity</param>
		/// <param name="m3THPR">Third part charge</param>
		/// <param name="m3HELV">Hide element value</param>
		/// <param name="m3OBJ4">Field</param>
		/// <param name="m3OBJ5">Field</param>
		/// <param name="m3ATI4">Attribute identity</param>
		/// <param name="m3ATI5">Attribute identity</param>
		/// <param name="m3FMID">Formula</param>
		/// <param name="m3RESI">Result identity</param>
		/// <param name="m3DUM1">Field not used</param>
		/// <param name="m3CTY2">Charge category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdElement(
			string m3CEID, 
			string m3TX30 = null, 
			string m3TX15 = null, 
			string m3OBJ1 = null, 
			string m3OBJ2 = null, 
			string m3OBJ3 = null, 
			string m3WSOP = null, 
			int? m3POOV = null, 
			int? m3EXTY = null, 
			int? m3DIMT = null, 
			int? m3DIUN = null, 
			int? m3EXIC = null, 
			string m3ACRF = null, 
			int? m3VTCD = null, 
			string m3ATI1 = null, 
			string m3ATI2 = null, 
			string m3ATI3 = null, 
			int? m3MRF1 = null, 
			int? m3MRF2 = null, 
			int? m3MRF3 = null, 
			int? m3IVCQ = null, 
			int? m3THPR = null, 
			int? m3HELV = null, 
			string m3OBJ4 = null, 
			string m3OBJ5 = null, 
			string m3ATI4 = null, 
			string m3ATI5 = null, 
			string m3FMID = null, 
			string m3RESI = null, 
			string m3DUM1 = null, 
			int? m3CTY2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CEID))
				throw new ArgumentNullException(nameof(m3CEID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3CEID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ1))
				request.WithQueryParameter("OBJ1", m3OBJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ2))
				request.WithQueryParameter("OBJ2", m3OBJ2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ3))
				request.WithQueryParameter("OBJ3", m3OBJ3.Trim());
			if (!string.IsNullOrWhiteSpace(m3WSOP))
				request.WithQueryParameter("WSOP", m3WSOP.Trim());
			if (m3POOV.HasValue)
				request.WithQueryParameter("POOV", m3POOV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXTY.HasValue)
				request.WithQueryParameter("EXTY", m3EXTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIMT.HasValue)
				request.WithQueryParameter("DIMT", m3DIMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIUN.HasValue)
				request.WithQueryParameter("DIUN", m3DIUN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXIC.HasValue)
				request.WithQueryParameter("EXIC", m3EXIC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATI1))
				request.WithQueryParameter("ATI1", m3ATI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI2))
				request.WithQueryParameter("ATI2", m3ATI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI3))
				request.WithQueryParameter("ATI3", m3ATI3.Trim());
			if (m3MRF1.HasValue)
				request.WithQueryParameter("MRF1", m3MRF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRF2.HasValue)
				request.WithQueryParameter("MRF2", m3MRF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRF3.HasValue)
				request.WithQueryParameter("MRF3", m3MRF3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IVCQ.HasValue)
				request.WithQueryParameter("IVCQ", m3IVCQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3THPR.HasValue)
				request.WithQueryParameter("THPR", m3THPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HELV.HasValue)
				request.WithQueryParameter("HELV", m3HELV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBJ4))
				request.WithQueryParameter("OBJ4", m3OBJ4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ5))
				request.WithQueryParameter("OBJ5", m3OBJ5.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI4))
				request.WithQueryParameter("ATI4", m3ATI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI5))
				request.WithQueryParameter("ATI5", m3ATI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMID))
				request.WithQueryParameter("FMID", m3FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESI))
				request.WithQueryParameter("RESI", m3RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DUM1))
				request.WithQueryParameter("DUM1", m3DUM1.Trim());
			if (m3CTY2.HasValue)
				request.WithQueryParameter("CTY2", m3CTY2.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdElementValue
		/// Description Update Purchase Costing Element Value
		/// Version Release: 
		/// </summary>
		/// <param name="m3CEID">Purchase costing element (Required)</param>
		/// <param name="m3OVK1">Costing key 1 (Required)</param>
		/// <param name="m3OVK2">Costing key 2 (Required)</param>
		/// <param name="m3OVK3">Costing key 3 (Required)</param>
		/// <param name="m3VFDT">Valid from (Required)</param>
		/// <param name="m3OVHE">Costing markup</param>
		/// <param name="m3OVCD">Batch price quantity</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3FMID">Formula</param>
		/// <param name="m3RESI">Result identity</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3OVK4">Costing key 4</param>
		/// <param name="m3OVK5">Costing key 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdElementValue(
			string m3CEID, 
			string m3OVK1, 
			string m3OVK2, 
			string m3OVK3, 
			DateTime m3VFDT, 
			decimal? m3OVHE = null, 
			int? m3OVCD = null, 
			string m3CUCD = null, 
			int? m3CRTP = null, 
			string m3FMID = null, 
			string m3RESI = null, 
			decimal? m3TXID = null, 
			string m3OVK4 = null, 
			string m3OVK5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdElementValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CEID))
				throw new ArgumentNullException(nameof(m3CEID));
			if (string.IsNullOrWhiteSpace(m3OVK1))
				throw new ArgumentNullException(nameof(m3OVK1));
			if (string.IsNullOrWhiteSpace(m3OVK2))
				throw new ArgumentNullException(nameof(m3OVK2));
			if (string.IsNullOrWhiteSpace(m3OVK3))
				throw new ArgumentNullException(nameof(m3OVK3));

			// Set mandatory parameters
			request
				.WithQueryParameter("CEID", m3CEID.Trim())
				.WithQueryParameter("OVK1", m3OVK1.Trim())
				.WithQueryParameter("OVK2", m3OVK2.Trim())
				.WithQueryParameter("OVK3", m3OVK3.Trim())
				.WithQueryParameter("VFDT", m3VFDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3OVHE.HasValue)
				request.WithQueryParameter("OVHE", m3OVHE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OVCD.HasValue)
				request.WithQueryParameter("OVCD", m3OVCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FMID))
				request.WithQueryParameter("FMID", m3FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESI))
				request.WithQueryParameter("RESI", m3RESI.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OVK4))
				request.WithQueryParameter("OVK4", m3OVK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVK5))
				request.WithQueryParameter("OVK5", m3OVK5.Trim());

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
