/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PCTG">Partner category</param>
		/// <param name="m3PAID">Partner ID</param>
		/// <param name="m3PAI1">Partner ID sublevel 1</param>
		/// <param name="m3PAI2">Partner ID sublevel 2</param>
		/// <param name="m3PAAC">Partner alias category</param>
		/// <param name="m3PAAQ">Partner alias qualifier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CnvPtrResponse></returns>
		/// <exception cref="M3Exception<CnvPtrResponse>"></exception>
		public async Task<M3Response<CnvPtrResponse>> CnvPtr(
			int? m3CONO = null, 
			int? m3PCTG = null, 
			string m3PAID = null, 
			string m3PAI1 = null, 
			string m3PAI2 = null, 
			int? m3PAAC = null, 
			string m3PAAQ = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCTG.HasValue)
				request.WithQueryParameter("PCTG", m3PCTG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAID))
				request.WithQueryParameter("PAID", m3PAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAI1))
				request.WithQueryParameter("PAI1", m3PAI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAI2))
				request.WithQueryParameter("PAI2", m3PAI2.Trim());
			if (m3PAAC.HasValue)
				request.WithQueryParameter("PAAC", m3PAAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAAQ))
				request.WithQueryParameter("PAAQ", m3PAAQ.Trim());

			// Execute the request
			var result = await Execute<CnvPtrResponse>(
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
		/// Name CnvPtrAlias
		/// Description Convert Partner Alias
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PAAL">Partner alias</param>
		/// <param name="m3PAA1">Partner alias sublevel 1</param>
		/// <param name="m3PAA2">Partner alias sublevel 2</param>
		/// <param name="m3PAAQ">Partner alias qualifier</param>
		/// <param name="m3PAAC">Partner alias category</param>
		/// <param name="m3PCTG">Partner category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CnvPtrAliasResponse></returns>
		/// <exception cref="M3Exception<CnvPtrAliasResponse>"></exception>
		public async Task<M3Response<CnvPtrAliasResponse>> CnvPtrAlias(
			int? m3CONO = null, 
			string m3PAAL = null, 
			string m3PAA1 = null, 
			string m3PAA2 = null, 
			string m3PAAQ = null, 
			int? m3PAAC = null, 
			int? m3PCTG = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAAL))
				request.WithQueryParameter("PAAL", m3PAAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAA1))
				request.WithQueryParameter("PAA1", m3PAA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAA2))
				request.WithQueryParameter("PAA2", m3PAA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAAQ))
				request.WithQueryParameter("PAAQ", m3PAAQ.Trim());
			if (m3PAAC.HasValue)
				request.WithQueryParameter("PAAC", m3PAAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCTG.HasValue)
				request.WithQueryParameter("PCTG", m3PCTG.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<CnvPtrAliasResponse>(
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
		/// Name CnvPtrAliasQual
		/// Description Convert Partner Alias with Qualifying Partner
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PAAL">Partner alias</param>
		/// <param name="m3PAA1">Partner alias 1</param>
		/// <param name="m3PAA2">Partner alias 2</param>
		/// <param name="m3QPAI">Qualifying partner ID</param>
		/// <param name="m3QPA1">Qualifying partner sublevel 1</param>
		/// <param name="m3QPA2">Qualifying partner sublevel 2</param>
		/// <param name="m3QCTG">Qualifying partner category</param>
		/// <param name="m3PAAQ">Partner alias qualifier</param>
		/// <param name="m3PAAC">Partner alias category</param>
		/// <param name="m3PCTG">Partner category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CnvPtrAliasQualResponse></returns>
		/// <exception cref="M3Exception<CnvPtrAliasQualResponse>"></exception>
		public async Task<M3Response<CnvPtrAliasQualResponse>> CnvPtrAliasQual(
			int? m3CONO = null, 
			string m3PAAL = null, 
			string m3PAA1 = null, 
			string m3PAA2 = null, 
			string m3QPAI = null, 
			string m3QPA1 = null, 
			string m3QPA2 = null, 
			int? m3QCTG = null, 
			string m3PAAQ = null, 
			int? m3PAAC = null, 
			int? m3PCTG = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAAL))
				request.WithQueryParameter("PAAL", m3PAAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAA1))
				request.WithQueryParameter("PAA1", m3PAA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAA2))
				request.WithQueryParameter("PAA2", m3PAA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3QPAI))
				request.WithQueryParameter("QPAI", m3QPAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3QPA1))
				request.WithQueryParameter("QPA1", m3QPA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3QPA2))
				request.WithQueryParameter("QPA2", m3QPA2.Trim());
			if (m3QCTG.HasValue)
				request.WithQueryParameter("QCTG", m3QCTG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAAQ))
				request.WithQueryParameter("PAAQ", m3PAAQ.Trim());
			if (m3PAAC.HasValue)
				request.WithQueryParameter("PAAC", m3PAAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCTG.HasValue)
				request.WithQueryParameter("PCTG", m3PCTG.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<CnvPtrAliasQualResponse>(
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
		/// Name CnvPtrQual
		/// Description Convert Partner with Qualifying Partner
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PCTG">Partner category</param>
		/// <param name="m3PAID">Partner ID</param>
		/// <param name="m3PAI1">Partner ID sublevel 1</param>
		/// <param name="m3PAI2">Partner ID sublevel 2</param>
		/// <param name="m3QCTG">Qualifying partner category</param>
		/// <param name="m3QPAI">Qualifying partner ID</param>
		/// <param name="m3QPA1">Qualifying partner sublevel 1</param>
		/// <param name="m3QPA2">Qualifying partner sublevel 2</param>
		/// <param name="m3PAAC">Partner alias category</param>
		/// <param name="m3PAAQ">Partner alias qualifier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CnvPtrQualResponse></returns>
		/// <exception cref="M3Exception<CnvPtrQualResponse>"></exception>
		public async Task<M3Response<CnvPtrQualResponse>> CnvPtrQual(
			int? m3CONO = null, 
			int? m3PCTG = null, 
			string m3PAID = null, 
			string m3PAI1 = null, 
			string m3PAI2 = null, 
			int? m3QCTG = null, 
			string m3QPAI = null, 
			string m3QPA1 = null, 
			string m3QPA2 = null, 
			int? m3PAAC = null, 
			string m3PAAQ = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCTG.HasValue)
				request.WithQueryParameter("PCTG", m3PCTG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAID))
				request.WithQueryParameter("PAID", m3PAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAI1))
				request.WithQueryParameter("PAI1", m3PAI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAI2))
				request.WithQueryParameter("PAI2", m3PAI2.Trim());
			if (m3QCTG.HasValue)
				request.WithQueryParameter("QCTG", m3QCTG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QPAI))
				request.WithQueryParameter("QPAI", m3QPAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3QPA1))
				request.WithQueryParameter("QPA1", m3QPA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3QPA2))
				request.WithQueryParameter("QPA2", m3QPA2.Trim());
			if (m3PAAC.HasValue)
				request.WithQueryParameter("PAAC", m3PAAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAAQ))
				request.WithQueryParameter("PAAQ", m3PAAQ.Trim());

			// Execute the request
			var result = await Execute<CnvPtrQualResponse>(
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
		/// Name GetPtr
		/// Description Get Partner
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PCTG">Partner category</param>
		/// <param name="m3PAID">Partner ID</param>
		/// <param name="m3PAI1">Partner ID sublevel 1</param>
		/// <param name="m3PAI2">Partner ID sublevel 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPtrResponse></returns>
		/// <exception cref="M3Exception<GetPtrResponse>"></exception>
		public async Task<M3Response<GetPtrResponse>> GetPtr(
			int? m3CONO = null, 
			int? m3PCTG = null, 
			string m3PAID = null, 
			string m3PAI1 = null, 
			string m3PAI2 = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCTG.HasValue)
				request.WithQueryParameter("PCTG", m3PCTG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAID))
				request.WithQueryParameter("PAID", m3PAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAI1))
				request.WithQueryParameter("PAI1", m3PAI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAI2))
				request.WithQueryParameter("PAI2", m3PAI2.Trim());

			// Execute the request
			var result = await Execute<GetPtrResponse>(
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
		/// Name GetPtrAlias
		/// Description Get Partner Alias
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PCTG">Partner category</param>
		/// <param name="m3PAID">Partner ID</param>
		/// <param name="m3PAI1">Partner ID sublevel 1</param>
		/// <param name="m3PAI2">Partner ID sublevel 2</param>
		/// <param name="m3PAAC">Partner alias category</param>
		/// <param name="m3PAAQ">Partner alias qualifier</param>
		/// <param name="m3PAAL">Partner alias</param>
		/// <param name="m3PAA1">Partner alias 1</param>
		/// <param name="m3PAA2">Partner alias 2</param>
		/// <param name="m3QCTG">Qualifying partner category</param>
		/// <param name="m3QPAI">Qualifying partner ID</param>
		/// <param name="m3QPA1">Qualifying partner sublevel 1</param>
		/// <param name="m3QPA2">Qualifying partner sublevel 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPtrAliasResponse></returns>
		/// <exception cref="M3Exception<GetPtrAliasResponse>"></exception>
		public async Task<M3Response<GetPtrAliasResponse>> GetPtrAlias(
			int? m3CONO = null, 
			int? m3PCTG = null, 
			string m3PAID = null, 
			string m3PAI1 = null, 
			string m3PAI2 = null, 
			int? m3PAAC = null, 
			string m3PAAQ = null, 
			string m3PAAL = null, 
			string m3PAA1 = null, 
			string m3PAA2 = null, 
			int? m3QCTG = null, 
			string m3QPAI = null, 
			string m3QPA1 = null, 
			string m3QPA2 = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCTG.HasValue)
				request.WithQueryParameter("PCTG", m3PCTG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAID))
				request.WithQueryParameter("PAID", m3PAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAI1))
				request.WithQueryParameter("PAI1", m3PAI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAI2))
				request.WithQueryParameter("PAI2", m3PAI2.Trim());
			if (m3PAAC.HasValue)
				request.WithQueryParameter("PAAC", m3PAAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAAQ))
				request.WithQueryParameter("PAAQ", m3PAAQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAAL))
				request.WithQueryParameter("PAAL", m3PAAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAA1))
				request.WithQueryParameter("PAA1", m3PAA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAA2))
				request.WithQueryParameter("PAA2", m3PAA2.Trim());
			if (m3QCTG.HasValue)
				request.WithQueryParameter("QCTG", m3QCTG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QPAI))
				request.WithQueryParameter("QPAI", m3QPAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3QPA1))
				request.WithQueryParameter("QPA1", m3QPA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3QPA2))
				request.WithQueryParameter("QPA2", m3QPA2.Trim());

			// Execute the request
			var result = await Execute<GetPtrAliasResponse>(
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
