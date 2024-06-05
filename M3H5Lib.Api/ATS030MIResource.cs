/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDefaultVal
		/// Description This transaction displays default values of attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3PREX">Priority</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3DEVA">Default value</param>
		/// <param name="m3OBJC">Field</param>
		/// <param name="m3FMID">Formula</param>
		/// <param name="m3FORI">Formula result identity</param>
		/// <param name="m3AVRP">Attribute value range - from percentage</param>
		/// <param name="m3ATRP">Attribute value range - to percentage</param>
		/// <param name="m3AVRV">Attribute range value - from</param>
		/// <param name="m3ATRV">Attribute value range -  to value</param>
		/// <param name="m3AFRF">From formula result identity</param>
		/// <param name="m3ATRF">To formula result identity</param>
		/// <param name="m3INHC">Inheritance</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDefaultVal(
			string m3ATID = null, 
			string m3PREX = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3DEVA = null, 
			string m3OBJC = null, 
			string m3FMID = null, 
			string m3FORI = null, 
			int? m3AVRP = null, 
			int? m3ATRP = null, 
			decimal? m3AVRV = null, 
			decimal? m3ATRV = null, 
			string m3AFRF = null, 
			string m3ATRF = null, 
			int? m3INHC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDefaultVal",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PREX))
				request.WithQueryParameter("PREX", m3PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEVA))
				request.WithQueryParameter("DEVA", m3DEVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJC))
				request.WithQueryParameter("OBJC", m3OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMID))
				request.WithQueryParameter("FMID", m3FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FORI))
				request.WithQueryParameter("FORI", m3FORI.Trim());
			if (m3AVRP.HasValue)
				request.WithQueryParameter("AVRP", m3AVRP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATRP.HasValue)
				request.WithQueryParameter("ATRP", m3ATRP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVRV.HasValue)
				request.WithQueryParameter("AVRV", m3AVRV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATRV.HasValue)
				request.WithQueryParameter("ATRV", m3ATRV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AFRF))
				request.WithQueryParameter("AFRF", m3AFRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATRF))
				request.WithQueryParameter("ATRF", m3ATRF.Trim());
			if (m3INHC.HasValue)
				request.WithQueryParameter("INHC", m3INHC.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelDefaultVal
		/// Description This transaction displays default values of attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3PREX">Priority</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDefaultVal(
			string m3ATID = null, 
			string m3PREX = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelDefaultVal",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PREX))
				request.WithQueryParameter("PREX", m3PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

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
		/// Name GetDefaultVal
		/// Description This transaction displays default values of attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDefaultValResponse></returns>
		/// <exception cref="M3Exception<GetDefaultValResponse>"></exception>
		public async Task<M3Response<GetDefaultValResponse>> GetDefaultVal(
			string m3ATID, 
			string m3PREX, 
			string m3OBV1, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDefaultVal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3ATID.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

			// Execute the request
			var result = await Execute<GetDefaultValResponse>(
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
		/// Name LstDefaultVal
		/// Description This transaction lists default values of attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3PREX">Priority</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDefaultValResponse></returns>
		/// <exception cref="M3Exception<LstDefaultValResponse>"></exception>
		public async Task<M3Response<LstDefaultValResponse>> LstDefaultVal(
			string m3ATID = null, 
			string m3PREX = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstDefaultVal",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PREX))
				request.WithQueryParameter("PREX", m3PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

			// Execute the request
			var result = await Execute<LstDefaultValResponse>(
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
		/// Name UpdDefaultVal
		/// Description This transaction displays update alues of attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3PREX">Priority</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3DEVA">Default value</param>
		/// <param name="m3OBJC">Field</param>
		/// <param name="m3FMID">Formula</param>
		/// <param name="m3FORI">Formula result identity</param>
		/// <param name="m3AVRP">Attribute value range - from percentage</param>
		/// <param name="m3ATRP">Attribute value range - to percentage</param>
		/// <param name="m3AVRV">Attribute range value - from</param>
		/// <param name="m3ATRV">Attribute value range -  to value</param>
		/// <param name="m3AFRF">From formula result identity</param>
		/// <param name="m3ATRF">To formula result identity</param>
		/// <param name="m3INHC">Inheritance</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDefaultVal(
			string m3ATID = null, 
			string m3PREX = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3DEVA = null, 
			string m3OBJC = null, 
			string m3FMID = null, 
			string m3FORI = null, 
			int? m3AVRP = null, 
			int? m3ATRP = null, 
			decimal? m3AVRV = null, 
			decimal? m3ATRV = null, 
			string m3AFRF = null, 
			string m3ATRF = null, 
			int? m3INHC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdDefaultVal",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PREX))
				request.WithQueryParameter("PREX", m3PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEVA))
				request.WithQueryParameter("DEVA", m3DEVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJC))
				request.WithQueryParameter("OBJC", m3OBJC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMID))
				request.WithQueryParameter("FMID", m3FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FORI))
				request.WithQueryParameter("FORI", m3FORI.Trim());
			if (m3AVRP.HasValue)
				request.WithQueryParameter("AVRP", m3AVRP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATRP.HasValue)
				request.WithQueryParameter("ATRP", m3ATRP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVRV.HasValue)
				request.WithQueryParameter("AVRV", m3AVRV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATRV.HasValue)
				request.WithQueryParameter("ATRV", m3ATRV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AFRF))
				request.WithQueryParameter("AFRF", m3AFRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATRF))
				request.WithQueryParameter("ATRF", m3ATRF.Trim());
			if (m3INHC.HasValue)
				request.WithQueryParameter("INHC", m3INHC.Value.ToString(CultureInfo.CurrentCulture));

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
