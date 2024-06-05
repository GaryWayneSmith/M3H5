/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.MNS030MI;
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
	/// Name: MNS030MI
	/// Component Name: HB Moniker
	/// Description: Get correct HB moniker for diffrent applications
	/// Version Release: 13.1
	///</summary>
	public partial class MNS030MIResource : M3BaseResourceEndpoint
	{
		public MNS030MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS030MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetMonikerApp
		/// Description Return the miniker for an application
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3PRID">ProductID</param>
		/// <param name="m3MAJO">MajorVersion</param>
		/// <param name="m3MINO">MinorVersion</param>
		/// <param name="m3PREL">Release</param>
		/// <param name="m3PRSP">ServicePack</param>
		/// <param name="m3PABU">Patch build</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMonikerAppResponse></returns>
		/// <exception cref="M3Exception<GetMonikerAppResponse>"></exception>
		public async Task<M3Response<GetMonikerAppResponse>> GetMonikerApp(
			string m3PRID = null, 
			string m3MAJO = null, 
			string m3MINO = null, 
			string m3PREL = null, 
			string m3PRSP = null, 
			string m3PABU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMonikerApp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRID))
				request.WithQueryParameter("PRID", m3PRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAJO))
				request.WithQueryParameter("MAJO", m3MAJO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MINO))
				request.WithQueryParameter("MINO", m3MINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PREL))
				request.WithQueryParameter("PREL", m3PREL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRSP))
				request.WithQueryParameter("PRSP", m3PRSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PABU))
				request.WithQueryParameter("PABU", m3PABU.Trim());

			// Execute the request
			var result = await Execute<GetMonikerAppResponse>(
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
		/// Name LstMonikerApp
		/// Description List all monikers for an application major minor
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3PRID">ProductId</param>
		/// <param name="m3MAJO">MajorVersion</param>
		/// <param name="m3MINO">Minor Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMonikerAppResponse></returns>
		/// <exception cref="M3Exception<LstMonikerAppResponse>"></exception>
		public async Task<M3Response<LstMonikerAppResponse>> LstMonikerApp(
			string m3PRID = null, 
			string m3MAJO = null, 
			string m3MINO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMonikerApp",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRID))
				request.WithQueryParameter("PRID", m3PRID.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAJO))
				request.WithQueryParameter("MAJO", m3MAJO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MINO))
				request.WithQueryParameter("MINO", m3MINO.Trim());

			// Execute the request
			var result = await Execute<LstMonikerAppResponse>(
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
