/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MMS162MI;
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
	/// Name: MMS162MI
	/// Component Name: StockLevels
	/// Description: Stock levels on Style level
	/// Version Release: 14.x
	///</summary>
	public partial class MMS162MIResource : M3BaseResourceEndpoint
	{
		public MMS162MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS162MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPrePackNo
		/// Description Get Pre Pack Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PHID">Phantom ID (Required)</param>
		/// <param name="m3STYN">Style number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPrePackNoResponse></returns>
		/// <exception cref="M3Exception<GetPrePackNoResponse>"></exception>
		public async Task<M3Response<GetPrePackNoResponse>> GetPrePackNo(
			string m3PHID, 
			string m3STYN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPrePackNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PHID))
				throw new ArgumentNullException(nameof(m3PHID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PHID", m3PHID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STYN))
				request.WithQueryParameter("STYN", m3STYN.Trim());

			// Execute the request
			var result = await Execute<GetPrePackNoResponse>(
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
		/// Name LstStyleItem
		/// Description List Item per Style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OPTX">Option for feature X</param>
		/// <param name="m3OPTY">Option for feature Y</param>
		/// <param name="m3OPTZ">Option for feature Z</param>
		/// <param name="m3CHCD">Configuration code</param>
		/// <param name="m3FSTY">From Style number</param>
		/// <param name="m3TSTY">To Style number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleItemResponse></returns>
		/// <exception cref="M3Exception<LstStyleItemResponse>"></exception>
		public async Task<M3Response<LstStyleItemResponse>> LstStyleItem(
			string m3STYN, 
			int? m3CONO = null, 
			string m3OPTX = null, 
			string m3OPTY = null, 
			string m3OPTZ = null, 
			int? m3CHCD = null, 
			string m3FSTY = null, 
			string m3TSTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstStyleItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OPTX))
				request.WithQueryParameter("OPTX", m3OPTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTY))
				request.WithQueryParameter("OPTY", m3OPTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTZ))
				request.WithQueryParameter("OPTZ", m3OPTZ.Trim());
			if (m3CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3CHCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FSTY))
				request.WithQueryParameter("FSTY", m3FSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTY))
				request.WithQueryParameter("TSTY", m3TSTY.Trim());

			// Execute the request
			var result = await Execute<LstStyleItemResponse>(
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
		/// Name LstStyleWhsBal
		/// Description List Stock Levels
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OPTX">Option for feature X</param>
		/// <param name="m3OPTY">Option for feature Y</param>
		/// <param name="m3OPTZ">Option for feature Z</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ECAR">Area/State</param>
		/// <param name="m3CHCD">Configuration code</param>
		/// <param name="m3FSTY">From Style number</param>
		/// <param name="m3TSTY">To Style number</param>
		/// <param name="m3INVF">Filter For Non Zero Inventory</param>
		/// <param name="m3STOF">Store info</param>
		/// <param name="m3DCIN">DC info</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleWhsBalResponse></returns>
		/// <exception cref="M3Exception<LstStyleWhsBalResponse>"></exception>
		public async Task<M3Response<LstStyleWhsBalResponse>> LstStyleWhsBal(
			string m3STYN, 
			int? m3CONO = null, 
			string m3OPTX = null, 
			string m3OPTY = null, 
			string m3OPTZ = null, 
			string m3WHLO = null, 
			string m3DIVI = null, 
			string m3FACI = null, 
			string m3ECAR = null, 
			int? m3CHCD = null, 
			string m3FSTY = null, 
			string m3TSTY = null, 
			int? m3INVF = null, 
			int? m3STOF = null, 
			string m3DCIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstStyleWhsBal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OPTX))
				request.WithQueryParameter("OPTX", m3OPTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTY))
				request.WithQueryParameter("OPTY", m3OPTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTZ))
				request.WithQueryParameter("OPTZ", m3OPTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (m3CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3CHCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FSTY))
				request.WithQueryParameter("FSTY", m3FSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTY))
				request.WithQueryParameter("TSTY", m3TSTY.Trim());
			if (m3INVF.HasValue)
				request.WithQueryParameter("INVF", m3INVF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STOF.HasValue)
				request.WithQueryParameter("STOF", m3STOF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DCIN))
				request.WithQueryParameter("DCIN", m3DCIN.Trim());

			// Execute the request
			var result = await Execute<LstStyleWhsBalResponse>(
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
		/// Name LstWhsBal
		/// Description List Stock Levels
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STYN">Style number</param>
		/// <param name="m3OPTX">Option for feature X</param>
		/// <param name="m3OPTY">Option for feature Y</param>
		/// <param name="m3OPTZ">Option for feature Z</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3CHCD">Configuration code</param>
		/// <param name="m3FSTY">From Style number</param>
		/// <param name="m3TSTY">To Style number</param>
		/// <param name="m3INVF">Filter for Non Zero Inventory</param>
		/// <param name="m3STOF">Store info</param>
		/// <param name="m3DCIN">DC info</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWhsBalResponse></returns>
		/// <exception cref="M3Exception<LstWhsBalResponse>"></exception>
		public async Task<M3Response<LstWhsBalResponse>> LstWhsBal(
			int? m3CONO = null, 
			string m3STYN = null, 
			string m3OPTX = null, 
			string m3OPTY = null, 
			string m3OPTZ = null, 
			string m3WHLO = null, 
			string m3DIVI = null, 
			string m3FACI = null, 
			string m3ECAR = null, 
			int? m3CHCD = null, 
			string m3FSTY = null, 
			string m3TSTY = null, 
			int? m3INVF = null, 
			int? m3STOF = null, 
			string m3DCIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstWhsBal",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STYN))
				request.WithQueryParameter("STYN", m3STYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTX))
				request.WithQueryParameter("OPTX", m3OPTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTY))
				request.WithQueryParameter("OPTY", m3OPTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTZ))
				request.WithQueryParameter("OPTZ", m3OPTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (m3CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3CHCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FSTY))
				request.WithQueryParameter("FSTY", m3FSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTY))
				request.WithQueryParameter("TSTY", m3TSTY.Trim());
			if (m3INVF.HasValue)
				request.WithQueryParameter("INVF", m3INVF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STOF.HasValue)
				request.WithQueryParameter("STOF", m3STOF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DCIN))
				request.WithQueryParameter("DCIN", m3DCIN.Trim());

			// Execute the request
			var result = await Execute<LstWhsBalResponse>(
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
