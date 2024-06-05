/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS434MI;
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
	/// Name: CRS434MI
	/// Component Name: Credit card
	/// Description: Credit card intercface settings
	/// Version Release: 5ea1
	///</summary>
	public partial class CRS434MIResource : M3BaseResourceEndpoint
	{
		public CRS434MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS434MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add3rdPartyId
		/// Description Add a third party id
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_TRDI">3rd-party id (Required)</param>
		/// <param name="m3_TRDP">3rd-party provider (Required)</param>
		/// <param name="m3_MEXX">Old MEID</param>
		/// <param name="m3_US65">User</param>
		/// <param name="m3_PWRD">Password</param>
		/// <param name="m3_HADR">Host address</param>
		/// <param name="m3_HPOR">Host port</param>
		/// <param name="m3_TOSE">Timeout in seconds</param>
		/// <param name="m3_VEND">Vendor</param>
		/// <param name="m3_PART">Partner</param>
		/// <param name="m3_PRXA">Proxy address</param>
		/// <param name="m3_PRXL">Proxy logon</param>
		/// <param name="m3_PRXP">Proxy port</param>
		/// <param name="m3_PRXW">Proxy password</param>
		/// <param name="m3_UD01">User-defined field</param>
		/// <param name="m3_UD02">User-defined field</param>
		/// <param name="m3_UD03">User-defined field</param>
		/// <param name="m3_UD04">User-defined field</param>
		/// <param name="m3_URLA">URL address</param>
		/// <param name="m3_AUDY">Authorization days</param>
		/// <param name="m3_MEID">Merchant ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add3rdPartyId(
			string m3_TRDI, 
			string m3_TRDP, 
			int? m3_MEXX = null, 
			string m3_US65 = null, 
			string m3_PWRD = null, 
			string m3_HADR = null, 
			int? m3_HPOR = null, 
			int? m3_TOSE = null, 
			string m3_VEND = null, 
			string m3_PART = null, 
			string m3_PRXA = null, 
			string m3_PRXL = null, 
			int? m3_PRXP = null, 
			string m3_PRXW = null, 
			string m3_UD01 = null, 
			string m3_UD02 = null, 
			string m3_UD03 = null, 
			string m3_UD04 = null, 
			string m3_URLA = null, 
			int? m3_AUDY = null, 
			int? m3_MEID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add3rdPartyId",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRDI))
				throw new ArgumentNullException("m3_TRDI");
			if (string.IsNullOrWhiteSpace(m3_TRDP))
				throw new ArgumentNullException("m3_TRDP");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRDI", m3_TRDI.Trim())
				.WithQueryParameter("TRDP", m3_TRDP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_MEXX.HasValue)
				request.WithQueryParameter("MEXX", m3_MEXX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_US65))
				request.WithQueryParameter("US65", m3_US65.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PWRD))
				request.WithQueryParameter("PWRD", m3_PWRD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HADR))
				request.WithQueryParameter("HADR", m3_HADR.Trim());
			if (m3_HPOR.HasValue)
				request.WithQueryParameter("HPOR", m3_HPOR.Value.ToString());
			if (m3_TOSE.HasValue)
				request.WithQueryParameter("TOSE", m3_TOSE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VEND))
				request.WithQueryParameter("VEND", m3_VEND.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PART))
				request.WithQueryParameter("PART", m3_PART.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRXA))
				request.WithQueryParameter("PRXA", m3_PRXA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRXL))
				request.WithQueryParameter("PRXL", m3_PRXL.Trim());
			if (m3_PRXP.HasValue)
				request.WithQueryParameter("PRXP", m3_PRXP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRXW))
				request.WithQueryParameter("PRXW", m3_PRXW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UD01))
				request.WithQueryParameter("UD01", m3_UD01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UD02))
				request.WithQueryParameter("UD02", m3_UD02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UD03))
				request.WithQueryParameter("UD03", m3_UD03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UD04))
				request.WithQueryParameter("UD04", m3_UD04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_URLA))
				request.WithQueryParameter("URLA", m3_URLA.Trim());
			if (m3_AUDY.HasValue)
				request.WithQueryParameter("AUDY", m3_AUDY.Value.ToString());
			if (m3_MEID.HasValue)
				request.WithQueryParameter("MEID", m3_MEID.Value.ToString());

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
		/// Name Dlt3rdPartyId
		/// Description Delete a third party id
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_TRDI">3rd-party id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt3rdPartyId(
			string m3_TRDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Dlt3rdPartyId",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TRDI))
				request.WithQueryParameter("TRDI", m3_TRDI.Trim());

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
		/// Name Get3rdPartyId
		/// Description Get data for a 3td party id
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_TRDI">3rd-party id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<Get3rdPartyIdResponse></returns>
		/// <exception cref="M3Exception<Get3rdPartyIdResponse>"></exception>
		public async Task<M3Response<Get3rdPartyIdResponse>> Get3rdPartyId(
			string m3_TRDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get3rdPartyId",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TRDI))
				request.WithQueryParameter("TRDI", m3_TRDI.Trim());

			// Execute the request
			var result = await Execute<Get3rdPartyIdResponse>(
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
		/// Name Get3rdPartyId2
		/// Description Get data for a 3td party id
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_TRDI">3rd-party id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<Get3rdPartyId2Response></returns>
		/// <exception cref="M3Exception<Get3rdPartyId2Response>"></exception>
		public async Task<M3Response<Get3rdPartyId2Response>> Get3rdPartyId2(
			string m3_TRDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get3rdPartyId2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TRDI))
				request.WithQueryParameter("TRDI", m3_TRDI.Trim());

			// Execute the request
			var result = await Execute<Get3rdPartyId2Response>(
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
		/// Name Lst3rdPartyIds
		/// Description List data for 3rd party ids
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_TRDI">3rd-party id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<Lst3rdPartyIdsResponse></returns>
		/// <exception cref="M3Exception<Lst3rdPartyIdsResponse>"></exception>
		public async Task<M3Response<Lst3rdPartyIdsResponse>> Lst3rdPartyIds(
			string m3_TRDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst3rdPartyIds",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TRDI))
				request.WithQueryParameter("TRDI", m3_TRDI.Trim());

			// Execute the request
			var result = await Execute<Lst3rdPartyIdsResponse>(
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
		/// Name Lst3rdPartyIds2
		/// Description List data for 3rd party ids
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_TRDI">3rd-party id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<Lst3rdPartyIds2Response></returns>
		/// <exception cref="M3Exception<Lst3rdPartyIds2Response>"></exception>
		public async Task<M3Response<Lst3rdPartyIds2Response>> Lst3rdPartyIds2(
			string m3_TRDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst3rdPartyIds2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TRDI))
				request.WithQueryParameter("TRDI", m3_TRDI.Trim());

			// Execute the request
			var result = await Execute<Lst3rdPartyIds2Response>(
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
		/// Name Upd3rdPartyId
		/// Description Update data for a 3rd party id
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_TRDI">3rd-party id (Required)</param>
		/// <param name="m3_TRDP">3rd-party provider</param>
		/// <param name="m3_HADR">Host address</param>
		/// <param name="m3_MEXX">Old MEID</param>
		/// <param name="m3_US65">User</param>
		/// <param name="m3_PWRD">Password</param>
		/// <param name="m3_HPOR">Host port</param>
		/// <param name="m3_TOSE">Timeout in seconds</param>
		/// <param name="m3_VEND">Vendor</param>
		/// <param name="m3_PART">Partner</param>
		/// <param name="m3_PRXA">Proxy address</param>
		/// <param name="m3_PRXL">Proxy logon</param>
		/// <param name="m3_PRXP">Proxy port</param>
		/// <param name="m3_PRXW">Proxy password</param>
		/// <param name="m3_UD01">User-defined field</param>
		/// <param name="m3_UD02">User-defined field</param>
		/// <param name="m3_UD03">User-defined field</param>
		/// <param name="m3_UD04">User-defined field</param>
		/// <param name="m3_URLA">URL address</param>
		/// <param name="m3_AUDY">Authorization days</param>
		/// <param name="m3_MEID">Merchant ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd3rdPartyId(
			string m3_TRDI, 
			string m3_TRDP = null, 
			string m3_HADR = null, 
			int? m3_MEXX = null, 
			string m3_US65 = null, 
			string m3_PWRD = null, 
			int? m3_HPOR = null, 
			int? m3_TOSE = null, 
			string m3_VEND = null, 
			string m3_PART = null, 
			string m3_PRXA = null, 
			string m3_PRXL = null, 
			int? m3_PRXP = null, 
			string m3_PRXW = null, 
			string m3_UD01 = null, 
			string m3_UD02 = null, 
			string m3_UD03 = null, 
			string m3_UD04 = null, 
			string m3_URLA = null, 
			int? m3_AUDY = null, 
			int? m3_MEID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd3rdPartyId",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRDI))
				throw new ArgumentNullException("m3_TRDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRDI", m3_TRDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TRDP))
				request.WithQueryParameter("TRDP", m3_TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HADR))
				request.WithQueryParameter("HADR", m3_HADR.Trim());
			if (m3_MEXX.HasValue)
				request.WithQueryParameter("MEXX", m3_MEXX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_US65))
				request.WithQueryParameter("US65", m3_US65.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PWRD))
				request.WithQueryParameter("PWRD", m3_PWRD.Trim());
			if (m3_HPOR.HasValue)
				request.WithQueryParameter("HPOR", m3_HPOR.Value.ToString());
			if (m3_TOSE.HasValue)
				request.WithQueryParameter("TOSE", m3_TOSE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VEND))
				request.WithQueryParameter("VEND", m3_VEND.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PART))
				request.WithQueryParameter("PART", m3_PART.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRXA))
				request.WithQueryParameter("PRXA", m3_PRXA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRXL))
				request.WithQueryParameter("PRXL", m3_PRXL.Trim());
			if (m3_PRXP.HasValue)
				request.WithQueryParameter("PRXP", m3_PRXP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRXW))
				request.WithQueryParameter("PRXW", m3_PRXW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UD01))
				request.WithQueryParameter("UD01", m3_UD01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UD02))
				request.WithQueryParameter("UD02", m3_UD02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UD03))
				request.WithQueryParameter("UD03", m3_UD03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UD04))
				request.WithQueryParameter("UD04", m3_UD04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_URLA))
				request.WithQueryParameter("URLA", m3_URLA.Trim());
			if (m3_AUDY.HasValue)
				request.WithQueryParameter("AUDY", m3_AUDY.Value.ToString());
			if (m3_MEID.HasValue)
				request.WithQueryParameter("MEID", m3_MEID.Value.ToString());

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
