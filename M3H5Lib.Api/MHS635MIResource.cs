/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MHS635MI;
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
	/// Name: MHS635MI
	/// Component Name: ItemAliasExtract
	/// Description: Item alias extract interface
	/// Version Release: 11.4
	///</summary>
	public partial class MHS635MIResource : M3BaseResourceEndpoint
	{
		public MHS635MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MHS635MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstAliasExtract
		/// Description List Alias Extract Information
		/// Version Release: 11.4
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_E0PB">Partner ID</param>
		/// <param name="m3_VFDT">Valid from</param>
		/// <param name="m3_DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAliasExtractResponse></returns>
		/// <exception cref="M3Exception<LstAliasExtractResponse>"></exception>
		public async Task<M3Response<LstAliasExtractResponse>> LstAliasExtract(
			string m3_E0PA, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			int? m3_ALWT = null, 
			string m3_ALWQ = null, 
			string m3_ITNO = null, 
			string m3_POPN = null, 
			string m3_E0PB = null, 
			DateTime? m3_VFDT = null, 
			int? m3_DOWN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAliasExtract",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0PB))
				request.WithQueryParameter("E0PB", m3_E0PB.Trim());
			if (m3_VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3_VFDT.Value.ToM3String());
			if (m3_DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3_DOWN.Value.ToString());

			// Execute the request
			var result = await Execute<LstAliasExtractResponse>(
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
		/// Name LstAliasViaItem
		/// Description List Alias Extract Information
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAliasViaItemResponse></returns>
		/// <exception cref="M3Exception<LstAliasViaItemResponse>"></exception>
		public async Task<M3Response<LstAliasViaItemResponse>> LstAliasViaItem(
			string m3_E0PA, 
			string m3_WHLO, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			int? m3_DOWN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAliasViaItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3_DOWN.Value.ToString());

			// Execute the request
			var result = await Execute<LstAliasViaItemResponse>(
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
		/// Name PrcAliasExtract
		/// Description Process Alias Extract Information
		/// Version Release: 11.4
		/// </summary>
		/// <param name="m3_E0PA">Partner (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ALWT">Alias category (Required)</param>
		/// <param name="m3_ALWQ">Alias qualifier (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_POPN">Alias number (Required)</param>
		/// <param name="m3_E0PB">Partner ID (Required)</param>
		/// <param name="m3_VFDT">Valid from (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DOWN">0/blank=Unprocessed, 1=Processed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrcAliasExtract(
			string m3_E0PA, 
			string m3_WHLO, 
			int m3_ALWT, 
			string m3_ALWQ, 
			string m3_ITNO, 
			string m3_POPN, 
			string m3_E0PB, 
			DateTime m3_VFDT, 
			int? m3_CONO = null, 
			int? m3_DOWN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrcAliasExtract",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0PA))
				throw new ArgumentNullException("m3_E0PA");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ALWQ))
				throw new ArgumentNullException("m3_ALWQ");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_POPN))
				throw new ArgumentNullException("m3_POPN");
			if (string.IsNullOrWhiteSpace(m3_E0PB))
				throw new ArgumentNullException("m3_E0PB");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0PA", m3_E0PA.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ALWT", m3_ALWT.ToString())
				.WithQueryParameter("ALWQ", m3_ALWQ.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("POPN", m3_POPN.Trim())
				.WithQueryParameter("E0PB", m3_E0PB.Trim())
				.WithQueryParameter("VFDT", m3_VFDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DOWN.HasValue)
				request.WithQueryParameter("DOWN", m3_DOWN.Value.ToString());

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
