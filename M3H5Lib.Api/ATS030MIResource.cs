/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.ATS030MI;
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
	/// Name: ATS030MI
	/// Component Name: Planning and Manufacturing
	/// Description: Default attribute values
	/// Version Release: 14.x
	///</summary>
	public partial class ATS030MIResource : M3BaseResourceEndpoint
	{
		public ATS030MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ATS030MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDefaultVal
		/// Description This transaction displays default values of attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_PREX">Priority</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_DEVA">Default value</param>
		/// <param name="m3_OBJC">Field</param>
		/// <param name="m3_FMID">Formula</param>
		/// <param name="m3_FORI">Formula result identity</param>
		/// <param name="m3_AVRP">Attribute value range - from percentage</param>
		/// <param name="m3_ATRP">Attribute value range - to percentage</param>
		/// <param name="m3_AVRV">Attribute range value - from</param>
		/// <param name="m3_ATRV">Attribute value range -  to value</param>
		/// <param name="m3_AFRF">From formula result identity</param>
		/// <param name="m3_ATRF">To formula result identity</param>
		/// <param name="m3_INHC">Inheritance</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDefaultVal(
			string m3_ATID = null, 
			string m3_PREX = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_DEVA = null, 
			string m3_OBJC = null, 
			string m3_FMID = null, 
			string m3_FORI = null, 
			int? m3_AVRP = null, 
			int? m3_ATRP = null, 
			decimal? m3_AVRV = null, 
			decimal? m3_ATRV = null, 
			string m3_AFRF = null, 
			string m3_ATRF = null, 
			int? m3_INHC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDefaultVal",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PREX))
				request.WithQueryParameter("PREX", m3_PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEVA))
				request.WithQueryParameter("DEVA", m3_DEVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJC))
				request.WithQueryParameter("OBJC", m3_OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMID))
				request.WithQueryParameter("FMID", m3_FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FORI))
				request.WithQueryParameter("FORI", m3_FORI.Trim());
			if (m3_AVRP.HasValue)
				request.WithQueryParameter("AVRP", m3_AVRP.Value.ToString());
			if (m3_ATRP.HasValue)
				request.WithQueryParameter("ATRP", m3_ATRP.Value.ToString());
			if (m3_AVRV.HasValue)
				request.WithQueryParameter("AVRV", m3_AVRV.Value.ToString());
			if (m3_ATRV.HasValue)
				request.WithQueryParameter("ATRV", m3_ATRV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AFRF))
				request.WithQueryParameter("AFRF", m3_AFRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATRF))
				request.WithQueryParameter("ATRF", m3_ATRF.Trim());
			if (m3_INHC.HasValue)
				request.WithQueryParameter("INHC", m3_INHC.Value.ToString());

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
		/// Name DelDefaultVal
		/// Description This transaction displays default values of attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_PREX">Priority</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDefaultVal(
			string m3_ATID = null, 
			string m3_PREX = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelDefaultVal",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PREX))
				request.WithQueryParameter("PREX", m3_PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

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
		/// Name GetDefaultVal
		/// Description This transaction displays default values of attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDefaultValResponse></returns>
		/// <exception cref="M3Exception<GetDefaultValResponse>"></exception>
		public async Task<M3Response<GetDefaultValResponse>> GetDefaultVal(
			string m3_ATID, 
			string m3_PREX, 
			string m3_OBV1, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDefaultVal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

			// Execute the request
			var result = await Execute<GetDefaultValResponse>(
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
		/// Name LstDefaultVal
		/// Description This transaction lists default values of attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_PREX">Priority</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDefaultValResponse></returns>
		/// <exception cref="M3Exception<LstDefaultValResponse>"></exception>
		public async Task<M3Response<LstDefaultValResponse>> LstDefaultVal(
			string m3_ATID = null, 
			string m3_PREX = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDefaultVal",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PREX))
				request.WithQueryParameter("PREX", m3_PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

			// Execute the request
			var result = await Execute<LstDefaultValResponse>(
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
		/// Name UpdDefaultVal
		/// Description This transaction displays update alues of attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_PREX">Priority</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_DEVA">Default value</param>
		/// <param name="m3_OBJC">Field</param>
		/// <param name="m3_FMID">Formula</param>
		/// <param name="m3_FORI">Formula result identity</param>
		/// <param name="m3_AVRP">Attribute value range - from percentage</param>
		/// <param name="m3_ATRP">Attribute value range - to percentage</param>
		/// <param name="m3_AVRV">Attribute range value - from</param>
		/// <param name="m3_ATRV">Attribute value range -  to value</param>
		/// <param name="m3_AFRF">From formula result identity</param>
		/// <param name="m3_ATRF">To formula result identity</param>
		/// <param name="m3_INHC">Inheritance</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDefaultVal(
			string m3_ATID = null, 
			string m3_PREX = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_DEVA = null, 
			string m3_OBJC = null, 
			string m3_FMID = null, 
			string m3_FORI = null, 
			int? m3_AVRP = null, 
			int? m3_ATRP = null, 
			decimal? m3_AVRV = null, 
			decimal? m3_ATRV = null, 
			string m3_AFRF = null, 
			string m3_ATRF = null, 
			int? m3_INHC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdDefaultVal",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PREX))
				request.WithQueryParameter("PREX", m3_PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEVA))
				request.WithQueryParameter("DEVA", m3_DEVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJC))
				request.WithQueryParameter("OBJC", m3_OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMID))
				request.WithQueryParameter("FMID", m3_FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FORI))
				request.WithQueryParameter("FORI", m3_FORI.Trim());
			if (m3_AVRP.HasValue)
				request.WithQueryParameter("AVRP", m3_AVRP.Value.ToString());
			if (m3_ATRP.HasValue)
				request.WithQueryParameter("ATRP", m3_ATRP.Value.ToString());
			if (m3_AVRV.HasValue)
				request.WithQueryParameter("AVRV", m3_AVRV.Value.ToString());
			if (m3_ATRV.HasValue)
				request.WithQueryParameter("ATRV", m3_ATRV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AFRF))
				request.WithQueryParameter("AFRF", m3_AFRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATRF))
				request.WithQueryParameter("ATRF", m3_ATRF.Trim());
			if (m3_INHC.HasValue)
				request.WithQueryParameter("INHC", m3_INHC.Value.ToString());

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
