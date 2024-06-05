/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetPrePackNo
		/// Description Get Pre Pack Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PHID">Phantom ID (Required)</param>
		/// <param name="m3_STYN">Style number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPrePackNoResponse></returns>
		/// <exception cref="M3Exception<GetPrePackNoResponse>"></exception>
		public async Task<M3Response<GetPrePackNoResponse>> GetPrePackNo(
			string m3_PHID, 
			string m3_STYN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPrePackNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PHID))
				throw new ArgumentNullException("m3_PHID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PHID", m3_PHID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STYN))
				request.WithQueryParameter("STYN", m3_STYN.Trim());

			// Execute the request
			var result = await Execute<GetPrePackNoResponse>(
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
		/// Name LstStyleItem
		/// Description List Item per Style
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OPTX">Option for feature X</param>
		/// <param name="m3_OPTY">Option for feature Y</param>
		/// <param name="m3_OPTZ">Option for feature Z</param>
		/// <param name="m3_CHCD">Configuration code</param>
		/// <param name="m3_FSTY">From Style number</param>
		/// <param name="m3_TSTY">To Style number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleItemResponse></returns>
		/// <exception cref="M3Exception<LstStyleItemResponse>"></exception>
		public async Task<M3Response<LstStyleItemResponse>> LstStyleItem(
			string m3_STYN, 
			int? m3_CONO = null, 
			string m3_OPTX = null, 
			string m3_OPTY = null, 
			string m3_OPTZ = null, 
			int? m3_CHCD = null, 
			string m3_FSTY = null, 
			string m3_TSTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStyleItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OPTX))
				request.WithQueryParameter("OPTX", m3_OPTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTY))
				request.WithQueryParameter("OPTY", m3_OPTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTZ))
				request.WithQueryParameter("OPTZ", m3_OPTZ.Trim());
			if (m3_CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3_CHCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FSTY))
				request.WithQueryParameter("FSTY", m3_FSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTY))
				request.WithQueryParameter("TSTY", m3_TSTY.Trim());

			// Execute the request
			var result = await Execute<LstStyleItemResponse>(
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
		/// Name LstStyleWhsBal
		/// Description List Stock Levels
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OPTX">Option for feature X</param>
		/// <param name="m3_OPTY">Option for feature Y</param>
		/// <param name="m3_OPTZ">Option for feature Z</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ECAR">Area/State</param>
		/// <param name="m3_CHCD">Configuration code</param>
		/// <param name="m3_FSTY">From Style number</param>
		/// <param name="m3_TSTY">To Style number</param>
		/// <param name="m3_INVF">Filter For Non Zero Inventory</param>
		/// <param name="m3_STOF">Store info</param>
		/// <param name="m3_DCIN">DC info</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstStyleWhsBalResponse></returns>
		/// <exception cref="M3Exception<LstStyleWhsBalResponse>"></exception>
		public async Task<M3Response<LstStyleWhsBalResponse>> LstStyleWhsBal(
			string m3_STYN, 
			int? m3_CONO = null, 
			string m3_OPTX = null, 
			string m3_OPTY = null, 
			string m3_OPTZ = null, 
			string m3_WHLO = null, 
			string m3_DIVI = null, 
			string m3_FACI = null, 
			string m3_ECAR = null, 
			int? m3_CHCD = null, 
			string m3_FSTY = null, 
			string m3_TSTY = null, 
			int? m3_INVF = null, 
			int? m3_STOF = null, 
			string m3_DCIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstStyleWhsBal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OPTX))
				request.WithQueryParameter("OPTX", m3_OPTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTY))
				request.WithQueryParameter("OPTY", m3_OPTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTZ))
				request.WithQueryParameter("OPTZ", m3_OPTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (m3_CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3_CHCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FSTY))
				request.WithQueryParameter("FSTY", m3_FSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTY))
				request.WithQueryParameter("TSTY", m3_TSTY.Trim());
			if (m3_INVF.HasValue)
				request.WithQueryParameter("INVF", m3_INVF.Value.ToString());
			if (m3_STOF.HasValue)
				request.WithQueryParameter("STOF", m3_STOF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DCIN))
				request.WithQueryParameter("DCIN", m3_DCIN.Trim());

			// Execute the request
			var result = await Execute<LstStyleWhsBalResponse>(
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
		/// Name LstWhsBal
		/// Description List Stock Levels
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STYN">Style number</param>
		/// <param name="m3_OPTX">Option for feature X</param>
		/// <param name="m3_OPTY">Option for feature Y</param>
		/// <param name="m3_OPTZ">Option for feature Z</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_CHCD">Configuration code</param>
		/// <param name="m3_FSTY">From Style number</param>
		/// <param name="m3_TSTY">To Style number</param>
		/// <param name="m3_INVF">Filter for Non Zero Inventory</param>
		/// <param name="m3_STOF">Store info</param>
		/// <param name="m3_DCIN">DC info</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWhsBalResponse></returns>
		/// <exception cref="M3Exception<LstWhsBalResponse>"></exception>
		public async Task<M3Response<LstWhsBalResponse>> LstWhsBal(
			int? m3_CONO = null, 
			string m3_STYN = null, 
			string m3_OPTX = null, 
			string m3_OPTY = null, 
			string m3_OPTZ = null, 
			string m3_WHLO = null, 
			string m3_DIVI = null, 
			string m3_FACI = null, 
			string m3_ECAR = null, 
			int? m3_CHCD = null, 
			string m3_FSTY = null, 
			string m3_TSTY = null, 
			int? m3_INVF = null, 
			int? m3_STOF = null, 
			string m3_DCIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstWhsBal",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STYN))
				request.WithQueryParameter("STYN", m3_STYN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTX))
				request.WithQueryParameter("OPTX", m3_OPTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTY))
				request.WithQueryParameter("OPTY", m3_OPTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTZ))
				request.WithQueryParameter("OPTZ", m3_OPTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (m3_CHCD.HasValue)
				request.WithQueryParameter("CHCD", m3_CHCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FSTY))
				request.WithQueryParameter("FSTY", m3_FSTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTY))
				request.WithQueryParameter("TSTY", m3_TSTY.Trim());
			if (m3_INVF.HasValue)
				request.WithQueryParameter("INVF", m3_INVF.Value.ToString());
			if (m3_STOF.HasValue)
				request.WithQueryParameter("STOF", m3_STOF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DCIN))
				request.WithQueryParameter("DCIN", m3_DCIN.Trim());

			// Execute the request
			var result = await Execute<LstWhsBalResponse>(
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
