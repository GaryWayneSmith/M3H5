/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CSSEITMI;
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
	/// Name: CSSEITMI
	/// Component Name: ExternalInformation
	/// Description: Api: External Temporary order information
	/// Version Release: 
	///</summary>
	public partial class CSSEITMIResource : M3BaseResourceEndpoint
	{
		public CSSEITMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CSSEITMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstExtTempInf
		/// Description List External Temporary Order Information
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_TMPO">Temporary order</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExtTempInfResponse></returns>
		/// <exception cref="M3Exception<LstExtTempInfResponse>"></exception>
		public async Task<M3Response<LstExtTempInfResponse>> LstExtTempInf(
			string m3_ORCA = null, 
			string m3_RIDN = null, 
			int? m3_TMPO = null, 
			int? m3_RIDL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstExtTempInf",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_TMPO.HasValue)
				request.WithQueryParameter("TMPO", m3_TMPO.Value.ToString());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());

			// Execute the request
			var result = await Execute<LstExtTempInfResponse>(
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
		/// Name UpdExtTempInf
		/// Description Update External Temporary Order Information
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_TMPO">Temporary order</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_EICI">Credit indicator</param>
		/// <param name="m3_IATH">Item authorized</param>
		/// <param name="m3_ATHL">Authorization level</param>
		/// <param name="m3_EREF">External reference</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdExtTempInf(
			string m3_ORCA = null, 
			string m3_RIDN = null, 
			int? m3_TMPO = null, 
			int? m3_RIDL = null, 
			string m3_ITNO = null, 
			string m3_EICI = null, 
			string m3_IATH = null, 
			string m3_ATHL = null, 
			string m3_EREF = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdExtTempInf",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_TMPO.HasValue)
				request.WithQueryParameter("TMPO", m3_TMPO.Value.ToString());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EICI))
				request.WithQueryParameter("EICI", m3_EICI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IATH))
				request.WithQueryParameter("IATH", m3_IATH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATHL))
				request.WithQueryParameter("ATHL", m3_ATHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EREF))
				request.WithQueryParameter("EREF", m3_EREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());

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
