/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.OIS015MI;
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
	/// Name: OIS015MI
	/// Component Name: Cust Sales and Service
	/// Description: Api: Sales price calculation elements
	/// Version Release: 14.x
	///</summary>
	public partial class OIS015MIResource : M3BaseResourceEndpoint
	{
		public OIS015MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS015MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCostElement
		/// Description Add Cost Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3SCET">Element type - sales price costing (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3WSOP">Costing operator (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3PC01">Cost distribution key 1</param>
		/// <param name="m3PC02">Cost distribution key 2</param>
		/// <param name="m3PC03">Cost distribution key 3</param>
		/// <param name="m3POOV">Markup</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3FTI1">Feature</param>
		/// <param name="m3FTI2">Feature</param>
		/// <param name="m3FTI3">Feature</param>
		/// <param name="m3ATI1">Attribute identity</param>
		/// <param name="m3ATI2">Attribute identity</param>
		/// <param name="m3ATI3">Attribute identity</param>
		/// <param name="m3DMI1">Drawing measurement</param>
		/// <param name="m3DMI2">Drawing measurement</param>
		/// <param name="m3DMI3">Drawing measurement</param>
		/// <param name="m3MRF1">Value in range</param>
		/// <param name="m3MRF2">Value in range</param>
		/// <param name="m3MRF3">Value in range</param>
		/// <param name="m3PC04">Field</param>
		/// <param name="m3PC05">Field</param>
		/// <param name="m3FTI4">Feature</param>
		/// <param name="m3FTI5">Feature</param>
		/// <param name="m3ATI4">Attribute identity</param>
		/// <param name="m3ATI5">Attribute identity</param>
		/// <param name="m3DMI4">Drawing measurement</param>
		/// <param name="m3DMI5">Drawing measurement</param>
		/// <param name="m3MRF4">Value in range</param>
		/// <param name="m3MRF5">Value in range</param>
		/// <param name="m3EX01">Field</param>
		/// <param name="m3EX02">Field</param>
		/// <param name="m3EX03">Field</param>
		/// <param name="m3EX04">Field</param>
		/// <param name="m3EX05">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCostElement(
			string m3SCEL, 
			int m3SCET, 
			string m3TX40, 
			string m3WSOP, 
			int? m3CONO = null, 
			string m3TX15 = null, 
			string m3PC01 = null, 
			string m3PC02 = null, 
			string m3PC03 = null, 
			int? m3POOV = null, 
			decimal? m3TXID = null, 
			string m3FTI1 = null, 
			string m3FTI2 = null, 
			string m3FTI3 = null, 
			string m3ATI1 = null, 
			string m3ATI2 = null, 
			string m3ATI3 = null, 
			string m3DMI1 = null, 
			string m3DMI2 = null, 
			string m3DMI3 = null, 
			int? m3MRF1 = null, 
			int? m3MRF2 = null, 
			int? m3MRF3 = null, 
			string m3PC04 = null, 
			string m3PC05 = null, 
			string m3FTI4 = null, 
			string m3FTI5 = null, 
			string m3ATI4 = null, 
			string m3ATI5 = null, 
			string m3DMI4 = null, 
			string m3DMI5 = null, 
			int? m3MRF4 = null, 
			int? m3MRF5 = null, 
			string m3EX01 = null, 
			string m3EX02 = null, 
			string m3EX03 = null, 
			string m3EX04 = null, 
			string m3EX05 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCostElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3WSOP))
				throw new ArgumentNullException(nameof(m3WSOP));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3SCEL.Trim())
				.WithQueryParameter("SCET", m3SCET.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("WSOP", m3WSOP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC01))
				request.WithQueryParameter("PC01", m3PC01.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC02))
				request.WithQueryParameter("PC02", m3PC02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC03))
				request.WithQueryParameter("PC03", m3PC03.Trim());
			if (m3POOV.HasValue)
				request.WithQueryParameter("POOV", m3POOV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FTI1))
				request.WithQueryParameter("FTI1", m3FTI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTI2))
				request.WithQueryParameter("FTI2", m3FTI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTI3))
				request.WithQueryParameter("FTI3", m3FTI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI1))
				request.WithQueryParameter("ATI1", m3ATI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI2))
				request.WithQueryParameter("ATI2", m3ATI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI3))
				request.WithQueryParameter("ATI3", m3ATI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMI1))
				request.WithQueryParameter("DMI1", m3DMI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMI2))
				request.WithQueryParameter("DMI2", m3DMI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMI3))
				request.WithQueryParameter("DMI3", m3DMI3.Trim());
			if (m3MRF1.HasValue)
				request.WithQueryParameter("MRF1", m3MRF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRF2.HasValue)
				request.WithQueryParameter("MRF2", m3MRF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRF3.HasValue)
				request.WithQueryParameter("MRF3", m3MRF3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PC04))
				request.WithQueryParameter("PC04", m3PC04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC05))
				request.WithQueryParameter("PC05", m3PC05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTI4))
				request.WithQueryParameter("FTI4", m3FTI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTI5))
				request.WithQueryParameter("FTI5", m3FTI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI4))
				request.WithQueryParameter("ATI4", m3ATI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI5))
				request.WithQueryParameter("ATI5", m3ATI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMI4))
				request.WithQueryParameter("DMI4", m3DMI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMI5))
				request.WithQueryParameter("DMI5", m3DMI5.Trim());
			if (m3MRF4.HasValue)
				request.WithQueryParameter("MRF4", m3MRF4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRF5.HasValue)
				request.WithQueryParameter("MRF5", m3MRF5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EX01))
				request.WithQueryParameter("EX01", m3EX01.Trim());
			if (!string.IsNullOrWhiteSpace(m3EX02))
				request.WithQueryParameter("EX02", m3EX02.Trim());
			if (!string.IsNullOrWhiteSpace(m3EX03))
				request.WithQueryParameter("EX03", m3EX03.Trim());
			if (!string.IsNullOrWhiteSpace(m3EX04))
				request.WithQueryParameter("EX04", m3EX04.Trim());
			if (!string.IsNullOrWhiteSpace(m3EX05))
				request.WithQueryParameter("EX05", m3EX05.Trim());

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
		/// Name AddElementExcl
		/// Description Add Element exclusions
		/// Version Release: 
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBJC">Field</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddElementExcl(
			string m3SCEL, 
			DateTime m3FVDT, 
			int? m3CONO = null, 
			string m3OBJC = null, 
			string m3OBV1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddElementExcl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3SCEL.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBJC))
				request.WithQueryParameter("OBJC", m3OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());

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
		/// Name AddElementRate
		/// Description Add Element Rate
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3CRTP">Exchange rate type (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OVHE">Costing markup</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3FMID">Formula</param>
		/// <param name="m3RESI">Result identity</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddElementRate(
			string m3SCEL, 
			DateTime m3FVDT, 
			int m3CRTP, 
			string m3CUCD, 
			int? m3CONO = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			decimal? m3OVHE = null, 
			int? m3SACD = null, 
			string m3FMID = null, 
			string m3RESI = null, 
			string m3PRRF = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddElementRate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3SCEL.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("CRTP", m3CRTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (m3OVHE.HasValue)
				request.WithQueryParameter("OVHE", m3OVHE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FMID))
				request.WithQueryParameter("FMID", m3FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESI))
				request.WithQueryParameter("RESI", m3RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());

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
		/// Name DltCostElement
		/// Description Delete Cost Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCostElement(
			string m3SCEL, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltCostElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3SCEL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltElementExcl
		/// Description Delete Element Excl
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBJC">Field</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltElementExcl(
			string m3SCEL, 
			DateTime m3FVDT, 
			int? m3CONO = null, 
			string m3OBJC = null, 
			string m3OBV1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltElementExcl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3SCEL.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBJC))
				request.WithQueryParameter("OBJC", m3OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());

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
		/// Name DltElementRate
		/// Description Delete Element Rate
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltElementRate(
			string m3SCEL, 
			DateTime m3FVDT, 
			int? m3CONO = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltElementRate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3SCEL.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());

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
		/// Name GetCostElement
		/// Description GetCostElement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCostElementResponse></returns>
		/// <exception cref="M3Exception<GetCostElementResponse>"></exception>
		public async Task<M3Response<GetCostElementResponse>> GetCostElement(
			string m3SCEL, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCostElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3SCEL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetCostElementResponse>(
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
		/// Name GetElementRate
		/// Description Get Element Rate
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetElementRateResponse></returns>
		/// <exception cref="M3Exception<GetElementRateResponse>"></exception>
		public async Task<M3Response<GetElementRateResponse>> GetElementRate(
			string m3SCEL, 
			DateTime m3FVDT, 
			int? m3CONO = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetElementRate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3SCEL.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());

			// Execute the request
			var result = await Execute<GetElementRateResponse>(
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
		/// Name LstCostElements
		/// Description LstCostElements
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCostElementsResponse></returns>
		/// <exception cref="M3Exception<LstCostElementsResponse>"></exception>
		public async Task<M3Response<LstCostElementsResponse>> LstCostElements(
			string m3SCEL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCostElements",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SCEL))
				request.WithQueryParameter("SCEL", m3SCEL.Trim());

			// Execute the request
			var result = await Execute<LstCostElementsResponse>(
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
		/// Name LstElemByText
		/// Description List Element By Text
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3TX15">Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElemByTextResponse></returns>
		/// <exception cref="M3Exception<LstElemByTextResponse>"></exception>
		public async Task<M3Response<LstElemByTextResponse>> LstElemByText(
			string m3TX15, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstElemByText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TX15))
				throw new ArgumentNullException(nameof(m3TX15));

			// Set mandatory parameters
			request
				.WithQueryParameter("TX15", m3TX15.Trim());

			// Execute the request
			var result = await Execute<LstElemByTextResponse>(
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
		/// Name LstElementExcl
		/// Description List Elements Exclusions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBJC">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElementExclResponse></returns>
		/// <exception cref="M3Exception<LstElementExclResponse>"></exception>
		public async Task<M3Response<LstElementExclResponse>> LstElementExcl(
			string m3SCEL, 
			int? m3CONO = null, 
			string m3OBJC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstElementExcl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3SCEL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBJC))
				request.WithQueryParameter("OBJC", m3OBJC.Trim());

			// Execute the request
			var result = await Execute<LstElementExclResponse>(
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
		/// Description To list a range of Sales Costing Elements
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FCEL">Element - sales price costing (from)</param>
		/// <param name="m3TCEL">Element - sales price costing (to)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElementRangeResponse></returns>
		/// <exception cref="M3Exception<LstElementRangeResponse>"></exception>
		public async Task<M3Response<LstElementRangeResponse>> LstElementRange(
			int? m3CONO = null, 
			string m3FCEL = null, 
			string m3TCEL = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCEL))
				request.WithQueryParameter("FCEL", m3FCEL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCEL))
				request.WithQueryParameter("TCEL", m3TCEL.Trim());

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
		/// Name LstElementRates
		/// Description LstElementRates
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElementRatesResponse></returns>
		/// <exception cref="M3Exception<LstElementRatesResponse>"></exception>
		public async Task<M3Response<LstElementRatesResponse>> LstElementRates(
			string m3SCEL, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			DateTime? m3FVDT = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstElementRates",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3SCEL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());

			// Execute the request
			var result = await Execute<LstElementRatesResponse>(
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
		/// Name LstModelByText
		/// Description List Model By Text
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModelByTextResponse></returns>
		/// <exception cref="M3Exception<LstModelByTextResponse>"></exception>
		public async Task<M3Response<LstModelByTextResponse>> LstModelByText(
			string m3TX40, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstModelByText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Execute the request
			var result = await Execute<LstModelByTextResponse>(
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
		/// Name UpdCostElement
		/// Description Update Cost Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SCET">Element type - sales price costing</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3PC01">Cost distribution key 1</param>
		/// <param name="m3PC02">Cost distribution key 2</param>
		/// <param name="m3PC03">Cost distribution key 3</param>
		/// <param name="m3WSOP">Costing operator</param>
		/// <param name="m3POOV">Markup</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3FTI1">Feature</param>
		/// <param name="m3FTI2">Feature</param>
		/// <param name="m3FTI3">Feature</param>
		/// <param name="m3ATI1">Attribute identity</param>
		/// <param name="m3ATI2">Attribute identity</param>
		/// <param name="m3ATI3">Attribute identity</param>
		/// <param name="m3DMI1">Drawing measurement</param>
		/// <param name="m3DMI2">Drawing measurement</param>
		/// <param name="m3DMI3">Drawing measurement</param>
		/// <param name="m3MRF1">Value in range</param>
		/// <param name="m3MRF2">Value in range</param>
		/// <param name="m3MRF3">Value in range</param>
		/// <param name="m3PC04">Field</param>
		/// <param name="m3PC05">Field</param>
		/// <param name="m3FTI4">Feature</param>
		/// <param name="m3FTI5">Feature</param>
		/// <param name="m3ATI4">Attribute identity</param>
		/// <param name="m3ATI5">Attribute identity</param>
		/// <param name="m3DMI4">Drawing measurement</param>
		/// <param name="m3DMI5">Drawing measurement</param>
		/// <param name="m3MRF4">Value in range</param>
		/// <param name="m3MRF5">Value in range</param>
		/// <param name="m3EX01">Field</param>
		/// <param name="m3EX02">Field</param>
		/// <param name="m3EX03">Field</param>
		/// <param name="m3EX04">Field</param>
		/// <param name="m3EX05">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCostElement(
			string m3SCEL, 
			int? m3CONO = null, 
			int? m3SCET = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3PC01 = null, 
			string m3PC02 = null, 
			string m3PC03 = null, 
			string m3WSOP = null, 
			int? m3POOV = null, 
			decimal? m3TXID = null, 
			string m3FTI1 = null, 
			string m3FTI2 = null, 
			string m3FTI3 = null, 
			string m3ATI1 = null, 
			string m3ATI2 = null, 
			string m3ATI3 = null, 
			string m3DMI1 = null, 
			string m3DMI2 = null, 
			string m3DMI3 = null, 
			int? m3MRF1 = null, 
			int? m3MRF2 = null, 
			int? m3MRF3 = null, 
			string m3PC04 = null, 
			string m3PC05 = null, 
			string m3FTI4 = null, 
			string m3FTI5 = null, 
			string m3ATI4 = null, 
			string m3ATI5 = null, 
			string m3DMI4 = null, 
			string m3DMI5 = null, 
			int? m3MRF4 = null, 
			int? m3MRF5 = null, 
			string m3EX01 = null, 
			string m3EX02 = null, 
			string m3EX03 = null, 
			string m3EX04 = null, 
			string m3EX05 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdCostElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3SCEL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCET.HasValue)
				request.WithQueryParameter("SCET", m3SCET.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC01))
				request.WithQueryParameter("PC01", m3PC01.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC02))
				request.WithQueryParameter("PC02", m3PC02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC03))
				request.WithQueryParameter("PC03", m3PC03.Trim());
			if (!string.IsNullOrWhiteSpace(m3WSOP))
				request.WithQueryParameter("WSOP", m3WSOP.Trim());
			if (m3POOV.HasValue)
				request.WithQueryParameter("POOV", m3POOV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FTI1))
				request.WithQueryParameter("FTI1", m3FTI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTI2))
				request.WithQueryParameter("FTI2", m3FTI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTI3))
				request.WithQueryParameter("FTI3", m3FTI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI1))
				request.WithQueryParameter("ATI1", m3ATI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI2))
				request.WithQueryParameter("ATI2", m3ATI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI3))
				request.WithQueryParameter("ATI3", m3ATI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMI1))
				request.WithQueryParameter("DMI1", m3DMI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMI2))
				request.WithQueryParameter("DMI2", m3DMI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMI3))
				request.WithQueryParameter("DMI3", m3DMI3.Trim());
			if (m3MRF1.HasValue)
				request.WithQueryParameter("MRF1", m3MRF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRF2.HasValue)
				request.WithQueryParameter("MRF2", m3MRF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRF3.HasValue)
				request.WithQueryParameter("MRF3", m3MRF3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PC04))
				request.WithQueryParameter("PC04", m3PC04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC05))
				request.WithQueryParameter("PC05", m3PC05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTI4))
				request.WithQueryParameter("FTI4", m3FTI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTI5))
				request.WithQueryParameter("FTI5", m3FTI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI4))
				request.WithQueryParameter("ATI4", m3ATI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATI5))
				request.WithQueryParameter("ATI5", m3ATI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMI4))
				request.WithQueryParameter("DMI4", m3DMI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMI5))
				request.WithQueryParameter("DMI5", m3DMI5.Trim());
			if (m3MRF4.HasValue)
				request.WithQueryParameter("MRF4", m3MRF4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRF5.HasValue)
				request.WithQueryParameter("MRF5", m3MRF5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EX01))
				request.WithQueryParameter("EX01", m3EX01.Trim());
			if (!string.IsNullOrWhiteSpace(m3EX02))
				request.WithQueryParameter("EX02", m3EX02.Trim());
			if (!string.IsNullOrWhiteSpace(m3EX03))
				request.WithQueryParameter("EX03", m3EX03.Trim());
			if (!string.IsNullOrWhiteSpace(m3EX04))
				request.WithQueryParameter("EX04", m3EX04.Trim());
			if (!string.IsNullOrWhiteSpace(m3EX05))
				request.WithQueryParameter("EX05", m3EX05.Trim());

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
		/// Name UpdElementRate
		/// Description Update Element Rate
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OVHE">Costing markup</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3FMID">Formula</param>
		/// <param name="m3RESI">Result identity</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdElementRate(
			string m3SCEL, 
			DateTime m3FVDT, 
			int? m3CONO = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			decimal? m3OVHE = null, 
			int? m3SACD = null, 
			int? m3CRTP = null, 
			string m3CUCD = null, 
			string m3FMID = null, 
			string m3RESI = null, 
			string m3PRRF = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdElementRate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCEL))
				throw new ArgumentNullException(nameof(m3SCEL));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3SCEL.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (m3OVHE.HasValue)
				request.WithQueryParameter("OVHE", m3OVHE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMID))
				request.WithQueryParameter("FMID", m3FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESI))
				request.WithQueryParameter("RESI", m3RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());

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
