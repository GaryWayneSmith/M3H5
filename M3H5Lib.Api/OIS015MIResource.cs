/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_SCET">Element type - sales price costing (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_WSOP">Costing operator (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_PC01">Cost distribution key 1</param>
		/// <param name="m3_PC02">Cost distribution key 2</param>
		/// <param name="m3_PC03">Cost distribution key 3</param>
		/// <param name="m3_POOV">Markup</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_FTI1">Feature</param>
		/// <param name="m3_FTI2">Feature</param>
		/// <param name="m3_FTI3">Feature</param>
		/// <param name="m3_ATI1">Attribute identity</param>
		/// <param name="m3_ATI2">Attribute identity</param>
		/// <param name="m3_ATI3">Attribute identity</param>
		/// <param name="m3_DMI1">Drawing measurement</param>
		/// <param name="m3_DMI2">Drawing measurement</param>
		/// <param name="m3_DMI3">Drawing measurement</param>
		/// <param name="m3_MRF1">Value in range</param>
		/// <param name="m3_MRF2">Value in range</param>
		/// <param name="m3_MRF3">Value in range</param>
		/// <param name="m3_PC04">Field</param>
		/// <param name="m3_PC05">Field</param>
		/// <param name="m3_FTI4">Feature</param>
		/// <param name="m3_FTI5">Feature</param>
		/// <param name="m3_ATI4">Attribute identity</param>
		/// <param name="m3_ATI5">Attribute identity</param>
		/// <param name="m3_DMI4">Drawing measurement</param>
		/// <param name="m3_DMI5">Drawing measurement</param>
		/// <param name="m3_MRF4">Value in range</param>
		/// <param name="m3_MRF5">Value in range</param>
		/// <param name="m3_EX01">Field</param>
		/// <param name="m3_EX02">Field</param>
		/// <param name="m3_EX03">Field</param>
		/// <param name="m3_EX04">Field</param>
		/// <param name="m3_EX05">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCostElement(
			string m3_SCEL, 
			int m3_SCET, 
			string m3_TX40, 
			string m3_WSOP, 
			int? m3_CONO = null, 
			string m3_TX15 = null, 
			string m3_PC01 = null, 
			string m3_PC02 = null, 
			string m3_PC03 = null, 
			int? m3_POOV = null, 
			decimal? m3_TXID = null, 
			string m3_FTI1 = null, 
			string m3_FTI2 = null, 
			string m3_FTI3 = null, 
			string m3_ATI1 = null, 
			string m3_ATI2 = null, 
			string m3_ATI3 = null, 
			string m3_DMI1 = null, 
			string m3_DMI2 = null, 
			string m3_DMI3 = null, 
			int? m3_MRF1 = null, 
			int? m3_MRF2 = null, 
			int? m3_MRF3 = null, 
			string m3_PC04 = null, 
			string m3_PC05 = null, 
			string m3_FTI4 = null, 
			string m3_FTI5 = null, 
			string m3_ATI4 = null, 
			string m3_ATI5 = null, 
			string m3_DMI4 = null, 
			string m3_DMI5 = null, 
			int? m3_MRF4 = null, 
			int? m3_MRF5 = null, 
			string m3_EX01 = null, 
			string m3_EX02 = null, 
			string m3_EX03 = null, 
			string m3_EX04 = null, 
			string m3_EX05 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_WSOP))
				throw new ArgumentNullException("m3_WSOP");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3_SCEL.Trim())
				.WithQueryParameter("SCET", m3_SCET.ToString())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("WSOP", m3_WSOP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC01))
				request.WithQueryParameter("PC01", m3_PC01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC02))
				request.WithQueryParameter("PC02", m3_PC02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC03))
				request.WithQueryParameter("PC03", m3_PC03.Trim());
			if (m3_POOV.HasValue)
				request.WithQueryParameter("POOV", m3_POOV.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FTI1))
				request.WithQueryParameter("FTI1", m3_FTI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTI2))
				request.WithQueryParameter("FTI2", m3_FTI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTI3))
				request.WithQueryParameter("FTI3", m3_FTI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI1))
				request.WithQueryParameter("ATI1", m3_ATI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI2))
				request.WithQueryParameter("ATI2", m3_ATI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI3))
				request.WithQueryParameter("ATI3", m3_ATI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMI1))
				request.WithQueryParameter("DMI1", m3_DMI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMI2))
				request.WithQueryParameter("DMI2", m3_DMI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMI3))
				request.WithQueryParameter("DMI3", m3_DMI3.Trim());
			if (m3_MRF1.HasValue)
				request.WithQueryParameter("MRF1", m3_MRF1.Value.ToString());
			if (m3_MRF2.HasValue)
				request.WithQueryParameter("MRF2", m3_MRF2.Value.ToString());
			if (m3_MRF3.HasValue)
				request.WithQueryParameter("MRF3", m3_MRF3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PC04))
				request.WithQueryParameter("PC04", m3_PC04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC05))
				request.WithQueryParameter("PC05", m3_PC05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTI4))
				request.WithQueryParameter("FTI4", m3_FTI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTI5))
				request.WithQueryParameter("FTI5", m3_FTI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI4))
				request.WithQueryParameter("ATI4", m3_ATI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI5))
				request.WithQueryParameter("ATI5", m3_ATI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMI4))
				request.WithQueryParameter("DMI4", m3_DMI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMI5))
				request.WithQueryParameter("DMI5", m3_DMI5.Trim());
			if (m3_MRF4.HasValue)
				request.WithQueryParameter("MRF4", m3_MRF4.Value.ToString());
			if (m3_MRF5.HasValue)
				request.WithQueryParameter("MRF5", m3_MRF5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EX01))
				request.WithQueryParameter("EX01", m3_EX01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EX02))
				request.WithQueryParameter("EX02", m3_EX02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EX03))
				request.WithQueryParameter("EX03", m3_EX03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EX04))
				request.WithQueryParameter("EX04", m3_EX04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EX05))
				request.WithQueryParameter("EX05", m3_EX05.Trim());

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
		/// Name AddElementExcl
		/// Description Add Element exclusions
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBJC">Field</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddElementExcl(
			string m3_SCEL, 
			DateTime m3_FVDT, 
			int? m3_CONO = null, 
			string m3_OBJC = null, 
			string m3_OBV1 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3_SCEL.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBJC))
				request.WithQueryParameter("OBJC", m3_OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());

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
		/// Name AddElementRate
		/// Description Add Element Rate
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_CRTP">Exchange rate type (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OVHE">Costing markup</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_FMID">Formula</param>
		/// <param name="m3_RESI">Result identity</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddElementRate(
			string m3_SCEL, 
			DateTime m3_FVDT, 
			int m3_CRTP, 
			string m3_CUCD, 
			int? m3_CONO = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			decimal? m3_OVHE = null, 
			int? m3_SACD = null, 
			string m3_FMID = null, 
			string m3_RESI = null, 
			string m3_PRRF = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3_SCEL.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("CRTP", m3_CRTP.ToString())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (m3_OVHE.HasValue)
				request.WithQueryParameter("OVHE", m3_OVHE.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FMID))
				request.WithQueryParameter("FMID", m3_FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESI))
				request.WithQueryParameter("RESI", m3_RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());

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
		/// Name DltCostElement
		/// Description Delete Cost Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltCostElement(
			string m3_SCEL, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3_SCEL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name DltElementExcl
		/// Description Delete Element Excl
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBJC">Field</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltElementExcl(
			string m3_SCEL, 
			DateTime m3_FVDT, 
			int? m3_CONO = null, 
			string m3_OBJC = null, 
			string m3_OBV1 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3_SCEL.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBJC))
				request.WithQueryParameter("OBJC", m3_OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());

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
		/// Name DltElementRate
		/// Description Delete Element Rate
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltElementRate(
			string m3_SCEL, 
			DateTime m3_FVDT, 
			int? m3_CONO = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3_SCEL.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());

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
		/// Name GetCostElement
		/// Description GetCostElement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCostElementResponse></returns>
		/// <exception cref="M3Exception<GetCostElementResponse>"></exception>
		public async Task<M3Response<GetCostElementResponse>> GetCostElement(
			string m3_SCEL, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3_SCEL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetCostElementResponse>(
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
		/// Name GetElementRate
		/// Description Get Element Rate
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetElementRateResponse></returns>
		/// <exception cref="M3Exception<GetElementRateResponse>"></exception>
		public async Task<M3Response<GetElementRateResponse>> GetElementRate(
			string m3_SCEL, 
			DateTime m3_FVDT, 
			int? m3_CONO = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3_SCEL.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());

			// Execute the request
			var result = await Execute<GetElementRateResponse>(
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
		/// Name LstCostElements
		/// Description LstCostElements
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCEL">Element - sales price costing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCostElementsResponse></returns>
		/// <exception cref="M3Exception<LstCostElementsResponse>"></exception>
		public async Task<M3Response<LstCostElementsResponse>> LstCostElements(
			string m3_SCEL = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_SCEL))
				request.WithQueryParameter("SCEL", m3_SCEL.Trim());

			// Execute the request
			var result = await Execute<LstCostElementsResponse>(
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
		/// Name LstElemByText
		/// Description List Element By Text
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_TX15">Name (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElemByTextResponse></returns>
		/// <exception cref="M3Exception<LstElemByTextResponse>"></exception>
		public async Task<M3Response<LstElemByTextResponse>> LstElemByText(
			string m3_TX15, 
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
			if (string.IsNullOrWhiteSpace(m3_TX15))
				throw new ArgumentNullException("m3_TX15");

			// Set mandatory parameters
			request
				.WithQueryParameter("TX15", m3_TX15.Trim());

			// Execute the request
			var result = await Execute<LstElemByTextResponse>(
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
		/// Name LstElementExcl
		/// Description List Elements Exclusions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBJC">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElementExclResponse></returns>
		/// <exception cref="M3Exception<LstElementExclResponse>"></exception>
		public async Task<M3Response<LstElementExclResponse>> LstElementExcl(
			string m3_SCEL, 
			int? m3_CONO = null, 
			string m3_OBJC = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3_SCEL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBJC))
				request.WithQueryParameter("OBJC", m3_OBJC.Trim());

			// Execute the request
			var result = await Execute<LstElementExclResponse>(
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
		/// Description To list a range of Sales Costing Elements
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FCEL">Element - sales price costing (from)</param>
		/// <param name="m3_TCEL">Element - sales price costing (to)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElementRangeResponse></returns>
		/// <exception cref="M3Exception<LstElementRangeResponse>"></exception>
		public async Task<M3Response<LstElementRangeResponse>> LstElementRange(
			int? m3_CONO = null, 
			string m3_FCEL = null, 
			string m3_TCEL = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FCEL))
				request.WithQueryParameter("FCEL", m3_FCEL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCEL))
				request.WithQueryParameter("TCEL", m3_TCEL.Trim());

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
		/// Name LstElementRates
		/// Description LstElementRates
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstElementRatesResponse></returns>
		/// <exception cref="M3Exception<LstElementRatesResponse>"></exception>
		public async Task<M3Response<LstElementRatesResponse>> LstElementRates(
			string m3_SCEL, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			DateTime? m3_FVDT = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3_SCEL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());

			// Execute the request
			var result = await Execute<LstElementRatesResponse>(
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
		/// Name LstModelByText
		/// Description List Model By Text
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModelByTextResponse></returns>
		/// <exception cref="M3Exception<LstModelByTextResponse>"></exception>
		public async Task<M3Response<LstModelByTextResponse>> LstModelByText(
			string m3_TX40, 
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
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Execute the request
			var result = await Execute<LstModelByTextResponse>(
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
		/// Name UpdCostElement
		/// Description Update Cost Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SCET">Element type - sales price costing</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_PC01">Cost distribution key 1</param>
		/// <param name="m3_PC02">Cost distribution key 2</param>
		/// <param name="m3_PC03">Cost distribution key 3</param>
		/// <param name="m3_WSOP">Costing operator</param>
		/// <param name="m3_POOV">Markup</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_FTI1">Feature</param>
		/// <param name="m3_FTI2">Feature</param>
		/// <param name="m3_FTI3">Feature</param>
		/// <param name="m3_ATI1">Attribute identity</param>
		/// <param name="m3_ATI2">Attribute identity</param>
		/// <param name="m3_ATI3">Attribute identity</param>
		/// <param name="m3_DMI1">Drawing measurement</param>
		/// <param name="m3_DMI2">Drawing measurement</param>
		/// <param name="m3_DMI3">Drawing measurement</param>
		/// <param name="m3_MRF1">Value in range</param>
		/// <param name="m3_MRF2">Value in range</param>
		/// <param name="m3_MRF3">Value in range</param>
		/// <param name="m3_PC04">Field</param>
		/// <param name="m3_PC05">Field</param>
		/// <param name="m3_FTI4">Feature</param>
		/// <param name="m3_FTI5">Feature</param>
		/// <param name="m3_ATI4">Attribute identity</param>
		/// <param name="m3_ATI5">Attribute identity</param>
		/// <param name="m3_DMI4">Drawing measurement</param>
		/// <param name="m3_DMI5">Drawing measurement</param>
		/// <param name="m3_MRF4">Value in range</param>
		/// <param name="m3_MRF5">Value in range</param>
		/// <param name="m3_EX01">Field</param>
		/// <param name="m3_EX02">Field</param>
		/// <param name="m3_EX03">Field</param>
		/// <param name="m3_EX04">Field</param>
		/// <param name="m3_EX05">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdCostElement(
			string m3_SCEL, 
			int? m3_CONO = null, 
			int? m3_SCET = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_PC01 = null, 
			string m3_PC02 = null, 
			string m3_PC03 = null, 
			string m3_WSOP = null, 
			int? m3_POOV = null, 
			decimal? m3_TXID = null, 
			string m3_FTI1 = null, 
			string m3_FTI2 = null, 
			string m3_FTI3 = null, 
			string m3_ATI1 = null, 
			string m3_ATI2 = null, 
			string m3_ATI3 = null, 
			string m3_DMI1 = null, 
			string m3_DMI2 = null, 
			string m3_DMI3 = null, 
			int? m3_MRF1 = null, 
			int? m3_MRF2 = null, 
			int? m3_MRF3 = null, 
			string m3_PC04 = null, 
			string m3_PC05 = null, 
			string m3_FTI4 = null, 
			string m3_FTI5 = null, 
			string m3_ATI4 = null, 
			string m3_ATI5 = null, 
			string m3_DMI4 = null, 
			string m3_DMI5 = null, 
			int? m3_MRF4 = null, 
			int? m3_MRF5 = null, 
			string m3_EX01 = null, 
			string m3_EX02 = null, 
			string m3_EX03 = null, 
			string m3_EX04 = null, 
			string m3_EX05 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3_SCEL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_SCET.HasValue)
				request.WithQueryParameter("SCET", m3_SCET.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC01))
				request.WithQueryParameter("PC01", m3_PC01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC02))
				request.WithQueryParameter("PC02", m3_PC02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC03))
				request.WithQueryParameter("PC03", m3_PC03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WSOP))
				request.WithQueryParameter("WSOP", m3_WSOP.Trim());
			if (m3_POOV.HasValue)
				request.WithQueryParameter("POOV", m3_POOV.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FTI1))
				request.WithQueryParameter("FTI1", m3_FTI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTI2))
				request.WithQueryParameter("FTI2", m3_FTI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTI3))
				request.WithQueryParameter("FTI3", m3_FTI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI1))
				request.WithQueryParameter("ATI1", m3_ATI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI2))
				request.WithQueryParameter("ATI2", m3_ATI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI3))
				request.WithQueryParameter("ATI3", m3_ATI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMI1))
				request.WithQueryParameter("DMI1", m3_DMI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMI2))
				request.WithQueryParameter("DMI2", m3_DMI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMI3))
				request.WithQueryParameter("DMI3", m3_DMI3.Trim());
			if (m3_MRF1.HasValue)
				request.WithQueryParameter("MRF1", m3_MRF1.Value.ToString());
			if (m3_MRF2.HasValue)
				request.WithQueryParameter("MRF2", m3_MRF2.Value.ToString());
			if (m3_MRF3.HasValue)
				request.WithQueryParameter("MRF3", m3_MRF3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PC04))
				request.WithQueryParameter("PC04", m3_PC04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC05))
				request.WithQueryParameter("PC05", m3_PC05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTI4))
				request.WithQueryParameter("FTI4", m3_FTI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTI5))
				request.WithQueryParameter("FTI5", m3_FTI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI4))
				request.WithQueryParameter("ATI4", m3_ATI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATI5))
				request.WithQueryParameter("ATI5", m3_ATI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMI4))
				request.WithQueryParameter("DMI4", m3_DMI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMI5))
				request.WithQueryParameter("DMI5", m3_DMI5.Trim());
			if (m3_MRF4.HasValue)
				request.WithQueryParameter("MRF4", m3_MRF4.Value.ToString());
			if (m3_MRF5.HasValue)
				request.WithQueryParameter("MRF5", m3_MRF5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EX01))
				request.WithQueryParameter("EX01", m3_EX01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EX02))
				request.WithQueryParameter("EX02", m3_EX02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EX03))
				request.WithQueryParameter("EX03", m3_EX03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EX04))
				request.WithQueryParameter("EX04", m3_EX04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EX05))
				request.WithQueryParameter("EX05", m3_EX05.Trim());

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
		/// Name UpdElementRate
		/// Description Update Element Rate
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCEL">Element - sales price costing (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OVHE">Costing markup</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_FMID">Formula</param>
		/// <param name="m3_RESI">Result identity</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdElementRate(
			string m3_SCEL, 
			DateTime m3_FVDT, 
			int? m3_CONO = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			decimal? m3_OVHE = null, 
			int? m3_SACD = null, 
			int? m3_CRTP = null, 
			string m3_CUCD = null, 
			string m3_FMID = null, 
			string m3_RESI = null, 
			string m3_PRRF = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SCEL))
				throw new ArgumentNullException("m3_SCEL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCEL", m3_SCEL.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (m3_OVHE.HasValue)
				request.WithQueryParameter("OVHE", m3_OVHE.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMID))
				request.WithQueryParameter("FMID", m3_FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESI))
				request.WithQueryParameter("RESI", m3_RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());

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
