/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3TRDI">3rd-party id (Required)</param>
		/// <param name="m3TRDP">3rd-party provider (Required)</param>
		/// <param name="m3MEXX">Old MEID</param>
		/// <param name="m3US65">User</param>
		/// <param name="m3PWRD">Password</param>
		/// <param name="m3HADR">Host address</param>
		/// <param name="m3HPOR">Host port</param>
		/// <param name="m3TOSE">Timeout in seconds</param>
		/// <param name="m3VEND">Vendor</param>
		/// <param name="m3PART">Partner</param>
		/// <param name="m3PRXA">Proxy address</param>
		/// <param name="m3PRXL">Proxy logon</param>
		/// <param name="m3PRXP">Proxy port</param>
		/// <param name="m3PRXW">Proxy password</param>
		/// <param name="m3UD01">User-defined field</param>
		/// <param name="m3UD02">User-defined field</param>
		/// <param name="m3UD03">User-defined field</param>
		/// <param name="m3UD04">User-defined field</param>
		/// <param name="m3URLA">URL address</param>
		/// <param name="m3AUDY">Authorization days</param>
		/// <param name="m3MEID">Merchant ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add3rdPartyId(
			string m3TRDI, 
			string m3TRDP, 
			int? m3MEXX = null, 
			string m3US65 = null, 
			string m3PWRD = null, 
			string m3HADR = null, 
			int? m3HPOR = null, 
			int? m3TOSE = null, 
			string m3VEND = null, 
			string m3PART = null, 
			string m3PRXA = null, 
			string m3PRXL = null, 
			int? m3PRXP = null, 
			string m3PRXW = null, 
			string m3UD01 = null, 
			string m3UD02 = null, 
			string m3UD03 = null, 
			string m3UD04 = null, 
			string m3URLA = null, 
			int? m3AUDY = null, 
			int? m3MEID = null, 
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
			if (string.IsNullOrWhiteSpace(m3TRDI))
				throw new ArgumentNullException(nameof(m3TRDI));
			if (string.IsNullOrWhiteSpace(m3TRDP))
				throw new ArgumentNullException(nameof(m3TRDP));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRDI", m3TRDI.Trim())
				.WithQueryParameter("TRDP", m3TRDP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3MEXX.HasValue)
				request.WithQueryParameter("MEXX", m3MEXX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3US65))
				request.WithQueryParameter("US65", m3US65.Trim());
			if (!string.IsNullOrWhiteSpace(m3PWRD))
				request.WithQueryParameter("PWRD", m3PWRD.Trim());
			if (!string.IsNullOrWhiteSpace(m3HADR))
				request.WithQueryParameter("HADR", m3HADR.Trim());
			if (m3HPOR.HasValue)
				request.WithQueryParameter("HPOR", m3HPOR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOSE.HasValue)
				request.WithQueryParameter("TOSE", m3TOSE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VEND))
				request.WithQueryParameter("VEND", m3VEND.Trim());
			if (!string.IsNullOrWhiteSpace(m3PART))
				request.WithQueryParameter("PART", m3PART.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRXA))
				request.WithQueryParameter("PRXA", m3PRXA.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRXL))
				request.WithQueryParameter("PRXL", m3PRXL.Trim());
			if (m3PRXP.HasValue)
				request.WithQueryParameter("PRXP", m3PRXP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRXW))
				request.WithQueryParameter("PRXW", m3PRXW.Trim());
			if (!string.IsNullOrWhiteSpace(m3UD01))
				request.WithQueryParameter("UD01", m3UD01.Trim());
			if (!string.IsNullOrWhiteSpace(m3UD02))
				request.WithQueryParameter("UD02", m3UD02.Trim());
			if (!string.IsNullOrWhiteSpace(m3UD03))
				request.WithQueryParameter("UD03", m3UD03.Trim());
			if (!string.IsNullOrWhiteSpace(m3UD04))
				request.WithQueryParameter("UD04", m3UD04.Trim());
			if (!string.IsNullOrWhiteSpace(m3URLA))
				request.WithQueryParameter("URLA", m3URLA.Trim());
			if (m3AUDY.HasValue)
				request.WithQueryParameter("AUDY", m3AUDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MEID.HasValue)
				request.WithQueryParameter("MEID", m3MEID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Dlt3rdPartyId
		/// Description Delete a third party id
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3TRDI">3rd-party id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt3rdPartyId(
			string m3TRDI = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TRDI))
				request.WithQueryParameter("TRDI", m3TRDI.Trim());

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
		/// Name Get3rdPartyId
		/// Description Get data for a 3td party id
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3TRDI">3rd-party id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<Get3rdPartyIdResponse></returns>
		/// <exception cref="M3Exception<Get3rdPartyIdResponse>"></exception>
		public async Task<M3Response<Get3rdPartyIdResponse>> Get3rdPartyId(
			string m3TRDI = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TRDI))
				request.WithQueryParameter("TRDI", m3TRDI.Trim());

			// Execute the request
			var result = await Execute<Get3rdPartyIdResponse>(
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
		/// Name Get3rdPartyId2
		/// Description Get data for a 3td party id
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3TRDI">3rd-party id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<Get3rdPartyId2Response></returns>
		/// <exception cref="M3Exception<Get3rdPartyId2Response>"></exception>
		public async Task<M3Response<Get3rdPartyId2Response>> Get3rdPartyId2(
			string m3TRDI = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TRDI))
				request.WithQueryParameter("TRDI", m3TRDI.Trim());

			// Execute the request
			var result = await Execute<Get3rdPartyId2Response>(
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
		/// Name Lst3rdPartyIds
		/// Description List data for 3rd party ids
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3TRDI">3rd-party id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<Lst3rdPartyIdsResponse></returns>
		/// <exception cref="M3Exception<Lst3rdPartyIdsResponse>"></exception>
		public async Task<M3Response<Lst3rdPartyIdsResponse>> Lst3rdPartyIds(
			string m3TRDI = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TRDI))
				request.WithQueryParameter("TRDI", m3TRDI.Trim());

			// Execute the request
			var result = await Execute<Lst3rdPartyIdsResponse>(
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
		/// Name Lst3rdPartyIds2
		/// Description List data for 3rd party ids
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3TRDI">3rd-party id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<Lst3rdPartyIds2Response></returns>
		/// <exception cref="M3Exception<Lst3rdPartyIds2Response>"></exception>
		public async Task<M3Response<Lst3rdPartyIds2Response>> Lst3rdPartyIds2(
			string m3TRDI = null, 
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
			if (!string.IsNullOrWhiteSpace(m3TRDI))
				request.WithQueryParameter("TRDI", m3TRDI.Trim());

			// Execute the request
			var result = await Execute<Lst3rdPartyIds2Response>(
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
		/// Name Upd3rdPartyId
		/// Description Update data for a 3rd party id
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3TRDI">3rd-party id (Required)</param>
		/// <param name="m3TRDP">3rd-party provider</param>
		/// <param name="m3HADR">Host address</param>
		/// <param name="m3MEXX">Old MEID</param>
		/// <param name="m3US65">User</param>
		/// <param name="m3PWRD">Password</param>
		/// <param name="m3HPOR">Host port</param>
		/// <param name="m3TOSE">Timeout in seconds</param>
		/// <param name="m3VEND">Vendor</param>
		/// <param name="m3PART">Partner</param>
		/// <param name="m3PRXA">Proxy address</param>
		/// <param name="m3PRXL">Proxy logon</param>
		/// <param name="m3PRXP">Proxy port</param>
		/// <param name="m3PRXW">Proxy password</param>
		/// <param name="m3UD01">User-defined field</param>
		/// <param name="m3UD02">User-defined field</param>
		/// <param name="m3UD03">User-defined field</param>
		/// <param name="m3UD04">User-defined field</param>
		/// <param name="m3URLA">URL address</param>
		/// <param name="m3AUDY">Authorization days</param>
		/// <param name="m3MEID">Merchant ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd3rdPartyId(
			string m3TRDI, 
			string m3TRDP = null, 
			string m3HADR = null, 
			int? m3MEXX = null, 
			string m3US65 = null, 
			string m3PWRD = null, 
			int? m3HPOR = null, 
			int? m3TOSE = null, 
			string m3VEND = null, 
			string m3PART = null, 
			string m3PRXA = null, 
			string m3PRXL = null, 
			int? m3PRXP = null, 
			string m3PRXW = null, 
			string m3UD01 = null, 
			string m3UD02 = null, 
			string m3UD03 = null, 
			string m3UD04 = null, 
			string m3URLA = null, 
			int? m3AUDY = null, 
			int? m3MEID = null, 
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
			if (string.IsNullOrWhiteSpace(m3TRDI))
				throw new ArgumentNullException(nameof(m3TRDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRDI", m3TRDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TRDP))
				request.WithQueryParameter("TRDP", m3TRDP.Trim());
			if (!string.IsNullOrWhiteSpace(m3HADR))
				request.WithQueryParameter("HADR", m3HADR.Trim());
			if (m3MEXX.HasValue)
				request.WithQueryParameter("MEXX", m3MEXX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3US65))
				request.WithQueryParameter("US65", m3US65.Trim());
			if (!string.IsNullOrWhiteSpace(m3PWRD))
				request.WithQueryParameter("PWRD", m3PWRD.Trim());
			if (m3HPOR.HasValue)
				request.WithQueryParameter("HPOR", m3HPOR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOSE.HasValue)
				request.WithQueryParameter("TOSE", m3TOSE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VEND))
				request.WithQueryParameter("VEND", m3VEND.Trim());
			if (!string.IsNullOrWhiteSpace(m3PART))
				request.WithQueryParameter("PART", m3PART.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRXA))
				request.WithQueryParameter("PRXA", m3PRXA.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRXL))
				request.WithQueryParameter("PRXL", m3PRXL.Trim());
			if (m3PRXP.HasValue)
				request.WithQueryParameter("PRXP", m3PRXP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRXW))
				request.WithQueryParameter("PRXW", m3PRXW.Trim());
			if (!string.IsNullOrWhiteSpace(m3UD01))
				request.WithQueryParameter("UD01", m3UD01.Trim());
			if (!string.IsNullOrWhiteSpace(m3UD02))
				request.WithQueryParameter("UD02", m3UD02.Trim());
			if (!string.IsNullOrWhiteSpace(m3UD03))
				request.WithQueryParameter("UD03", m3UD03.Trim());
			if (!string.IsNullOrWhiteSpace(m3UD04))
				request.WithQueryParameter("UD04", m3UD04.Trim());
			if (!string.IsNullOrWhiteSpace(m3URLA))
				request.WithQueryParameter("URLA", m3URLA.Trim());
			if (m3AUDY.HasValue)
				request.WithQueryParameter("AUDY", m3AUDY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MEID.HasValue)
				request.WithQueryParameter("MEID", m3MEID.Value.ToString(CultureInfo.CurrentCulture));

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
