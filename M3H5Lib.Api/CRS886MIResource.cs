/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS886MI;
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
	/// Name: CRS886MI
	/// Component Name: PartnerAlias
	/// Description: Partner alias interface
	/// Version Release: 12.3
	///</summary>
	public partial class CRS886MIResource : M3BaseResourceEndpoint
	{
		public CRS886MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS886MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CnvPtr
		/// Description Convert Partner
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PCTG">Partner category</param>
		/// <param name="m3_PAID">Partner ID</param>
		/// <param name="m3_PAI1">Partner ID sublevel 1</param>
		/// <param name="m3_PAI2">Partner ID sublevel 2</param>
		/// <param name="m3_PAAC">Partner alias category</param>
		/// <param name="m3_PAAQ">Partner alias qualifier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CnvPtrResponse></returns>
		/// <exception cref="M3Exception<CnvPtrResponse>"></exception>
		public async Task<M3Response<CnvPtrResponse>> CnvPtr(
			int? m3_CONO = null, 
			int? m3_PCTG = null, 
			string m3_PAID = null, 
			string m3_PAI1 = null, 
			string m3_PAI2 = null, 
			int? m3_PAAC = null, 
			string m3_PAAQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CnvPtr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PCTG.HasValue)
				request.WithQueryParameter("PCTG", m3_PCTG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAID))
				request.WithQueryParameter("PAID", m3_PAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAI1))
				request.WithQueryParameter("PAI1", m3_PAI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAI2))
				request.WithQueryParameter("PAI2", m3_PAI2.Trim());
			if (m3_PAAC.HasValue)
				request.WithQueryParameter("PAAC", m3_PAAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAAQ))
				request.WithQueryParameter("PAAQ", m3_PAAQ.Trim());

			// Execute the request
			var result = await Execute<CnvPtrResponse>(
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
		/// Name CnvPtrAlias
		/// Description Convert Partner Alias
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PAAL">Partner alias</param>
		/// <param name="m3_PAA1">Partner alias sublevel 1</param>
		/// <param name="m3_PAA2">Partner alias sublevel 2</param>
		/// <param name="m3_PAAQ">Partner alias qualifier</param>
		/// <param name="m3_PAAC">Partner alias category</param>
		/// <param name="m3_PCTG">Partner category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CnvPtrAliasResponse></returns>
		/// <exception cref="M3Exception<CnvPtrAliasResponse>"></exception>
		public async Task<M3Response<CnvPtrAliasResponse>> CnvPtrAlias(
			int? m3_CONO = null, 
			string m3_PAAL = null, 
			string m3_PAA1 = null, 
			string m3_PAA2 = null, 
			string m3_PAAQ = null, 
			int? m3_PAAC = null, 
			int? m3_PCTG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CnvPtrAlias",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAAL))
				request.WithQueryParameter("PAAL", m3_PAAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAA1))
				request.WithQueryParameter("PAA1", m3_PAA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAA2))
				request.WithQueryParameter("PAA2", m3_PAA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAAQ))
				request.WithQueryParameter("PAAQ", m3_PAAQ.Trim());
			if (m3_PAAC.HasValue)
				request.WithQueryParameter("PAAC", m3_PAAC.Value.ToString());
			if (m3_PCTG.HasValue)
				request.WithQueryParameter("PCTG", m3_PCTG.Value.ToString());

			// Execute the request
			var result = await Execute<CnvPtrAliasResponse>(
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
		/// Name CnvPtrAliasQual
		/// Description Convert Partner Alias with Qualifying Partner
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PAAL">Partner alias</param>
		/// <param name="m3_PAA1">Partner alias 1</param>
		/// <param name="m3_PAA2">Partner alias 2</param>
		/// <param name="m3_QPAI">Qualifying partner ID</param>
		/// <param name="m3_QPA1">Qualifying partner sublevel 1</param>
		/// <param name="m3_QPA2">Qualifying partner sublevel 2</param>
		/// <param name="m3_QCTG">Qualifying partner category</param>
		/// <param name="m3_PAAQ">Partner alias qualifier</param>
		/// <param name="m3_PAAC">Partner alias category</param>
		/// <param name="m3_PCTG">Partner category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CnvPtrAliasQualResponse></returns>
		/// <exception cref="M3Exception<CnvPtrAliasQualResponse>"></exception>
		public async Task<M3Response<CnvPtrAliasQualResponse>> CnvPtrAliasQual(
			int? m3_CONO = null, 
			string m3_PAAL = null, 
			string m3_PAA1 = null, 
			string m3_PAA2 = null, 
			string m3_QPAI = null, 
			string m3_QPA1 = null, 
			string m3_QPA2 = null, 
			int? m3_QCTG = null, 
			string m3_PAAQ = null, 
			int? m3_PAAC = null, 
			int? m3_PCTG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CnvPtrAliasQual",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAAL))
				request.WithQueryParameter("PAAL", m3_PAAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAA1))
				request.WithQueryParameter("PAA1", m3_PAA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAA2))
				request.WithQueryParameter("PAA2", m3_PAA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QPAI))
				request.WithQueryParameter("QPAI", m3_QPAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QPA1))
				request.WithQueryParameter("QPA1", m3_QPA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QPA2))
				request.WithQueryParameter("QPA2", m3_QPA2.Trim());
			if (m3_QCTG.HasValue)
				request.WithQueryParameter("QCTG", m3_QCTG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAAQ))
				request.WithQueryParameter("PAAQ", m3_PAAQ.Trim());
			if (m3_PAAC.HasValue)
				request.WithQueryParameter("PAAC", m3_PAAC.Value.ToString());
			if (m3_PCTG.HasValue)
				request.WithQueryParameter("PCTG", m3_PCTG.Value.ToString());

			// Execute the request
			var result = await Execute<CnvPtrAliasQualResponse>(
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
		/// Name CnvPtrQual
		/// Description Convert Partner with Qualifying Partner
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PCTG">Partner category</param>
		/// <param name="m3_PAID">Partner ID</param>
		/// <param name="m3_PAI1">Partner ID sublevel 1</param>
		/// <param name="m3_PAI2">Partner ID sublevel 2</param>
		/// <param name="m3_QCTG">Qualifying partner category</param>
		/// <param name="m3_QPAI">Qualifying partner ID</param>
		/// <param name="m3_QPA1">Qualifying partner sublevel 1</param>
		/// <param name="m3_QPA2">Qualifying partner sublevel 2</param>
		/// <param name="m3_PAAC">Partner alias category</param>
		/// <param name="m3_PAAQ">Partner alias qualifier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CnvPtrQualResponse></returns>
		/// <exception cref="M3Exception<CnvPtrQualResponse>"></exception>
		public async Task<M3Response<CnvPtrQualResponse>> CnvPtrQual(
			int? m3_CONO = null, 
			int? m3_PCTG = null, 
			string m3_PAID = null, 
			string m3_PAI1 = null, 
			string m3_PAI2 = null, 
			int? m3_QCTG = null, 
			string m3_QPAI = null, 
			string m3_QPA1 = null, 
			string m3_QPA2 = null, 
			int? m3_PAAC = null, 
			string m3_PAAQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CnvPtrQual",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PCTG.HasValue)
				request.WithQueryParameter("PCTG", m3_PCTG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAID))
				request.WithQueryParameter("PAID", m3_PAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAI1))
				request.WithQueryParameter("PAI1", m3_PAI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAI2))
				request.WithQueryParameter("PAI2", m3_PAI2.Trim());
			if (m3_QCTG.HasValue)
				request.WithQueryParameter("QCTG", m3_QCTG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QPAI))
				request.WithQueryParameter("QPAI", m3_QPAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QPA1))
				request.WithQueryParameter("QPA1", m3_QPA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QPA2))
				request.WithQueryParameter("QPA2", m3_QPA2.Trim());
			if (m3_PAAC.HasValue)
				request.WithQueryParameter("PAAC", m3_PAAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAAQ))
				request.WithQueryParameter("PAAQ", m3_PAAQ.Trim());

			// Execute the request
			var result = await Execute<CnvPtrQualResponse>(
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
		/// Name GetPtr
		/// Description Get Partner
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PCTG">Partner category</param>
		/// <param name="m3_PAID">Partner ID</param>
		/// <param name="m3_PAI1">Partner ID sublevel 1</param>
		/// <param name="m3_PAI2">Partner ID sublevel 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPtrResponse></returns>
		/// <exception cref="M3Exception<GetPtrResponse>"></exception>
		public async Task<M3Response<GetPtrResponse>> GetPtr(
			int? m3_CONO = null, 
			int? m3_PCTG = null, 
			string m3_PAID = null, 
			string m3_PAI1 = null, 
			string m3_PAI2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPtr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PCTG.HasValue)
				request.WithQueryParameter("PCTG", m3_PCTG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAID))
				request.WithQueryParameter("PAID", m3_PAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAI1))
				request.WithQueryParameter("PAI1", m3_PAI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAI2))
				request.WithQueryParameter("PAI2", m3_PAI2.Trim());

			// Execute the request
			var result = await Execute<GetPtrResponse>(
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
		/// Name GetPtrAlias
		/// Description Get Partner Alias
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PCTG">Partner category</param>
		/// <param name="m3_PAID">Partner ID</param>
		/// <param name="m3_PAI1">Partner ID sublevel 1</param>
		/// <param name="m3_PAI2">Partner ID sublevel 2</param>
		/// <param name="m3_PAAC">Partner alias category</param>
		/// <param name="m3_PAAQ">Partner alias qualifier</param>
		/// <param name="m3_PAAL">Partner alias</param>
		/// <param name="m3_PAA1">Partner alias 1</param>
		/// <param name="m3_PAA2">Partner alias 2</param>
		/// <param name="m3_QCTG">Qualifying partner category</param>
		/// <param name="m3_QPAI">Qualifying partner ID</param>
		/// <param name="m3_QPA1">Qualifying partner sublevel 1</param>
		/// <param name="m3_QPA2">Qualifying partner sublevel 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPtrAliasResponse></returns>
		/// <exception cref="M3Exception<GetPtrAliasResponse>"></exception>
		public async Task<M3Response<GetPtrAliasResponse>> GetPtrAlias(
			int? m3_CONO = null, 
			int? m3_PCTG = null, 
			string m3_PAID = null, 
			string m3_PAI1 = null, 
			string m3_PAI2 = null, 
			int? m3_PAAC = null, 
			string m3_PAAQ = null, 
			string m3_PAAL = null, 
			string m3_PAA1 = null, 
			string m3_PAA2 = null, 
			int? m3_QCTG = null, 
			string m3_QPAI = null, 
			string m3_QPA1 = null, 
			string m3_QPA2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPtrAlias",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PCTG.HasValue)
				request.WithQueryParameter("PCTG", m3_PCTG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAID))
				request.WithQueryParameter("PAID", m3_PAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAI1))
				request.WithQueryParameter("PAI1", m3_PAI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAI2))
				request.WithQueryParameter("PAI2", m3_PAI2.Trim());
			if (m3_PAAC.HasValue)
				request.WithQueryParameter("PAAC", m3_PAAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAAQ))
				request.WithQueryParameter("PAAQ", m3_PAAQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAAL))
				request.WithQueryParameter("PAAL", m3_PAAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAA1))
				request.WithQueryParameter("PAA1", m3_PAA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAA2))
				request.WithQueryParameter("PAA2", m3_PAA2.Trim());
			if (m3_QCTG.HasValue)
				request.WithQueryParameter("QCTG", m3_QCTG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QPAI))
				request.WithQueryParameter("QPAI", m3_QPAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QPA1))
				request.WithQueryParameter("QPA1", m3_QPA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QPA2))
				request.WithQueryParameter("QPA2", m3_QPA2.Trim());

			// Execute the request
			var result = await Execute<GetPtrAliasResponse>(
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
