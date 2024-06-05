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
	/// Name: STS106MI
	/// Component Name: STRAgreements
	/// Description: API: STR Agreement - Contact person
	/// Version Release: 5e90
	///</summary>
	public partial class STS106MIResource : M3BaseResourceEndpoint
	{
		public STS106MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS106MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCalcRPO
		/// Description AddCalcRPO
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_NOPR">Number of periods (Required)</param>
		/// <param name="m3_INTT">Interest type (Required)</param>
		/// <param name="m3_REPE">Residual percent (Required)</param>
		/// <param name="m3_INPE">Interest rate</param>
		/// <param name="m3_RESV">Residual value</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_RECH">Rental charges</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCalcRPO(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
			int m3_NOPR, 
			string m3_INTT, 
			int m3_REPE, 
			decimal? m3_INPE = null, 
			decimal? m3_RESV = null, 
			decimal? m3_SAPR = null, 
			decimal? m3_RECH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCalcRPO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_INTT))
				throw new ArgumentNullException("m3_INTT");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString())
				.WithQueryParameter("NOPR", m3_NOPR.ToString())
				.WithQueryParameter("INTT", m3_INTT.Trim())
				.WithQueryParameter("REPE", m3_REPE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_INPE.HasValue)
				request.WithQueryParameter("INPE", m3_INPE.Value.ToString());
			if (m3_RESV.HasValue)
				request.WithQueryParameter("RESV", m3_RESV.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_RECH.HasValue)
				request.WithQueryParameter("RECH", m3_RECH.Value.ToString());

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
		/// Name DelRPO
		/// Description DelRPO
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelRPO(
			string m3_AGNB, 
			int m3_VERS, 
			int m3_PONR, 
			int m3_POSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelRPO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString());

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
