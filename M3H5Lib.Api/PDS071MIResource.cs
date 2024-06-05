/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
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
	/// Name: PDS071MI
	/// Component Name: Feature Distribute Option
	/// Description: Api: Feature Distribute Option
	/// Version Release: 14.x
	///</summary>
	public partial class PDS071MIResource : M3BaseResourceEndpoint
	{
		public PDS071MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS071MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name FeatDistOpChk
		/// Description Feature Distribution Option Check
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_CURV">Distribution template (Required)</param>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> FeatDistOpChk(
			string m3_CURV, 
			string m3_FTID, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/FeatDistOpChk",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CURV))
				throw new ArgumentNullException("m3_CURV");
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CURV", m3_CURV.Trim())
				.WithQueryParameter("FTID", m3_FTID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

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
		/// Name FeatDistOpUpd
		/// Description Feature Distribution Option Update
		/// Version Release: 14.
		/// </summary>
		/// <param name="m3_CURV">Distribution template (Required)</param>
		/// <param name="m3_FTID">Feature (Required)</param>
		/// <param name="m3_OPTN">Option (Required)</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SHAR">Percentage</param>
		/// <param name="m3_BQ10">Ref field for base quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> FeatDistOpUpd(
			string m3_CURV, 
			string m3_FTID, 
			string m3_OPTN, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			int? m3_SHAR = null, 
			long? m3_BQ10 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/FeatDistOpUpd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CURV))
				throw new ArgumentNullException("m3_CURV");
			if (string.IsNullOrWhiteSpace(m3_FTID))
				throw new ArgumentNullException("m3_FTID");
			if (string.IsNullOrWhiteSpace(m3_OPTN))
				throw new ArgumentNullException("m3_OPTN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CURV", m3_CURV.Trim())
				.WithQueryParameter("FTID", m3_FTID.Trim())
				.WithQueryParameter("OPTN", m3_OPTN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_SHAR.HasValue)
				request.WithQueryParameter("SHAR", m3_SHAR.Value.ToString());
			if (m3_BQ10.HasValue)
				request.WithQueryParameter("BQ10", m3_BQ10.Value.ToString());

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
