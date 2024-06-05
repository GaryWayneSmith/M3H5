/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OSS401MI;
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
	/// Name: OSS401MI
	/// Component Name: DatasetInformation
	/// Description: Dataset Information interface
	/// Version Release: 5ea0
	///</summary>
	public partial class OSS401MIResource : M3BaseResourceEndpoint
	{
		public OSS401MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OSS401MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name SelData
		/// Description Select Dataset data
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SBDS">Dataset (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRDI">From division</param>
		/// <param name="m3_TODI">To Division</param>
		/// <param name="m3_FRTR">From Transaction Type</param>
		/// <param name="m3_TOTR">To Transaction Type</param>
		/// <param name="m3_FRBV">From Budget Version</param>
		/// <param name="m3_TOBV">To Budget Version</param>
		/// <param name="m3_FRYR">From year</param>
		/// <param name="m3_TOYR">To year</param>
		/// <param name="m3_FRPR">From Period</param>
		/// <param name="m3_TOPR">To Period</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDataResponse></returns>
		/// <exception cref="M3Exception<SelDataResponse>"></exception>
		public async Task<M3Response<SelDataResponse>> SelData(
			string m3_SBDS, 
			string m3_FILE, 
			int? m3_CONO = null, 
			string m3_FRDI = null, 
			string m3_TODI = null, 
			int? m3_FRTR = null, 
			int? m3_TOTR = null, 
			string m3_FRBV = null, 
			string m3_TOBV = null, 
			string m3_FRYR = null, 
			string m3_TOYR = null, 
			int? m3_FRPR = null, 
			int? m3_TOPR = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBDS))
				throw new ArgumentNullException("m3_SBDS");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBDS", m3_SBDS.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRDI))
				request.WithQueryParameter("FRDI", m3_FRDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TODI))
				request.WithQueryParameter("TODI", m3_TODI.Trim());
			if (m3_FRTR.HasValue)
				request.WithQueryParameter("FRTR", m3_FRTR.Value.ToString());
			if (m3_TOTR.HasValue)
				request.WithQueryParameter("TOTR", m3_TOTR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRBV))
				request.WithQueryParameter("FRBV", m3_FRBV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOBV))
				request.WithQueryParameter("TOBV", m3_TOBV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRYR))
				request.WithQueryParameter("FRYR", m3_FRYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOYR))
				request.WithQueryParameter("TOYR", m3_TOYR.Trim());
			if (m3_FRPR.HasValue)
				request.WithQueryParameter("FRPR", m3_FRPR.Value.ToString());
			if (m3_TOPR.HasValue)
				request.WithQueryParameter("TOPR", m3_TOPR.Value.ToString());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<SelDataResponse>(
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
		/// Name SelDataMercia
		/// Description Select Dataset data for Mercia
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SBDS">Dataset - statistics and budget (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRDI">From Division</param>
		/// <param name="m3_TODI">To Division</param>
		/// <param name="m3_FRTR">From Transaction type</param>
		/// <param name="m3_TOTR">To Transaction Type</param>
		/// <param name="m3_FRBV">From Budget Version</param>
		/// <param name="m3_TOBV">To Budget Version</param>
		/// <param name="m3_FRYR">From year</param>
		/// <param name="m3_TOYR">To year</param>
		/// <param name="m3_FRPR">From Period</param>
		/// <param name="m3_TOPR">To Period</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDataMerciaResponse></returns>
		/// <exception cref="M3Exception<SelDataMerciaResponse>"></exception>
		public async Task<M3Response<SelDataMerciaResponse>> SelDataMercia(
			string m3_SBDS, 
			string m3_FILE, 
			int? m3_CONO = null, 
			string m3_FRDI = null, 
			string m3_TODI = null, 
			int? m3_FRTR = null, 
			int? m3_TOTR = null, 
			string m3_FRBV = null, 
			string m3_TOBV = null, 
			string m3_FRYR = null, 
			string m3_TOYR = null, 
			int? m3_FRPR = null, 
			int? m3_TOPR = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelDataMercia",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBDS))
				throw new ArgumentNullException("m3_SBDS");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBDS", m3_SBDS.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRDI))
				request.WithQueryParameter("FRDI", m3_FRDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TODI))
				request.WithQueryParameter("TODI", m3_TODI.Trim());
			if (m3_FRTR.HasValue)
				request.WithQueryParameter("FRTR", m3_FRTR.Value.ToString());
			if (m3_TOTR.HasValue)
				request.WithQueryParameter("TOTR", m3_TOTR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRBV))
				request.WithQueryParameter("FRBV", m3_FRBV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOBV))
				request.WithQueryParameter("TOBV", m3_TOBV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRYR))
				request.WithQueryParameter("FRYR", m3_FRYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOYR))
				request.WithQueryParameter("TOYR", m3_TOYR.Trim());
			if (m3_FRPR.HasValue)
				request.WithQueryParameter("FRPR", m3_FRPR.Value.ToString());
			if (m3_TOPR.HasValue)
				request.WithQueryParameter("TOPR", m3_TOPR.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<SelDataMerciaResponse>(
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
		/// Name SelDetailedData
		/// Description Select Dataset data
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SBDS">Dataset (Required)</param>
		/// <param name="m3_SSTT">Transaction type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BVER">Budget version</param>
		/// <param name="m3_KEY1">Key 1</param>
		/// <param name="m3_KEY2">Key 2</param>
		/// <param name="m3_KEY3">Key 3</param>
		/// <param name="m3_KEY4">Key 4</param>
		/// <param name="m3_KEY5">Key 5</param>
		/// <param name="m3_KEY6">Key 6</param>
		/// <param name="m3_FRYR">From Year</param>
		/// <param name="m3_FRPR">From Period</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDetailedDataResponse></returns>
		/// <exception cref="M3Exception<SelDetailedDataResponse>"></exception>
		public async Task<M3Response<SelDetailedDataResponse>> SelDetailedData(
			string m3_SBDS, 
			int m3_SSTT, 
			int? m3_CONO = null, 
			string m3_BVER = null, 
			string m3_KEY1 = null, 
			string m3_KEY2 = null, 
			string m3_KEY3 = null, 
			string m3_KEY4 = null, 
			string m3_KEY5 = null, 
			string m3_KEY6 = null, 
			int? m3_FRYR = null, 
			int? m3_FRPR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelDetailedData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBDS))
				throw new ArgumentNullException("m3_SBDS");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBDS", m3_SBDS.Trim())
				.WithQueryParameter("SSTT", m3_SSTT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BVER))
				request.WithQueryParameter("BVER", m3_BVER.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY1))
				request.WithQueryParameter("KEY1", m3_KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY2))
				request.WithQueryParameter("KEY2", m3_KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY3))
				request.WithQueryParameter("KEY3", m3_KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY4))
				request.WithQueryParameter("KEY4", m3_KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY5))
				request.WithQueryParameter("KEY5", m3_KEY5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY6))
				request.WithQueryParameter("KEY6", m3_KEY6.Trim());
			if (m3_FRYR.HasValue)
				request.WithQueryParameter("FRYR", m3_FRYR.Value.ToString());
			if (m3_FRPR.HasValue)
				request.WithQueryParameter("FRPR", m3_FRPR.Value.ToString());

			// Execute the request
			var result = await Execute<SelDetailedDataResponse>(
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
		/// Name Select
		/// Description Select Dataset
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FDAT">From Dataset</param>
		/// <param name="m3_TDAT">To Dataset</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			int? m3_CONO = null, 
			string m3_FDAT = null, 
			string m3_TDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Select",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDAT))
				request.WithQueryParameter("FDAT", m3_FDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDAT))
				request.WithQueryParameter("TDAT", m3_TDAT.Trim());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name SelectMercia
		/// Description Select Dataset
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FDAT">From dataset</param>
		/// <param name="m3_TDAT">To dataset</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectMerciaResponse></returns>
		/// <exception cref="M3Exception<SelectMerciaResponse>"></exception>
		public async Task<M3Response<SelectMerciaResponse>> SelectMercia(
			int? m3_CONO = null, 
			string m3_FDAT = null, 
			string m3_TDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelectMercia",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDAT))
				request.WithQueryParameter("FDAT", m3_FDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDAT))
				request.WithQueryParameter("TDAT", m3_TDAT.Trim());

			// Execute the request
			var result = await Execute<SelectMerciaResponse>(
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
		/// Name SndBudgets
		/// Description Add sales budgets without answer
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SBDS">Dataset - statistics and budget (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_SSTT">Transaction type (Required)</param>
		/// <param name="m3_OSLE">Os level (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PERI">Period (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_KEY1">Key</param>
		/// <param name="m3_KEY2">Key</param>
		/// <param name="m3_KEY3">key</param>
		/// <param name="m3_KEY4">Key</param>
		/// <param name="m3_KEY5">Key</param>
		/// <param name="m3_KEY6">key</param>
		/// <param name="m3_CL01">Column</param>
		/// <param name="m3_CL02">Column</param>
		/// <param name="m3_CL03">Column</param>
		/// <param name="m3_CL04">Column</param>
		/// <param name="m3_CL05">Column</param>
		/// <param name="m3_CL06">Column</param>
		/// <param name="m3_CL07">Column</param>
		/// <param name="m3_CL08">Column</param>
		/// <param name="m3_CL09">Column</param>
		/// <param name="m3_CL10">Column</param>
		/// <param name="m3_CL11">Column</param>
		/// <param name="m3_CL12">Column</param>
		/// <param name="m3_CL13">Column</param>
		/// <param name="m3_CL14">Column</param>
		/// <param name="m3_CL15">Column</param>
		/// <param name="m3_CL16">Column</param>
		/// <param name="m3_CL17">Column</param>
		/// <param name="m3_CL18">Column</param>
		/// <param name="m3_CL19">Column</param>
		/// <param name="m3_CL20">Column</param>
		/// <param name="m3_CL21">Column</param>
		/// <param name="m3_CL22">Column</param>
		/// <param name="m3_CL23">Column</param>
		/// <param name="m3_CL24">Column</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndBudgets(
			string m3_SBDS, 
			string m3_FILE, 
			string m3_BVER, 
			int m3_SSTT, 
			int m3_OSLE, 
			int m3_YEA4, 
			int m3_PERI, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_KEY1 = null, 
			string m3_KEY2 = null, 
			string m3_KEY3 = null, 
			string m3_KEY4 = null, 
			string m3_KEY5 = null, 
			string m3_KEY6 = null, 
			string m3_CL01 = null, 
			string m3_CL02 = null, 
			string m3_CL03 = null, 
			string m3_CL04 = null, 
			string m3_CL05 = null, 
			string m3_CL06 = null, 
			string m3_CL07 = null, 
			string m3_CL08 = null, 
			string m3_CL09 = null, 
			string m3_CL10 = null, 
			string m3_CL11 = null, 
			string m3_CL12 = null, 
			string m3_CL13 = null, 
			string m3_CL14 = null, 
			string m3_CL15 = null, 
			string m3_CL16 = null, 
			string m3_CL17 = null, 
			string m3_CL18 = null, 
			string m3_CL19 = null, 
			string m3_CL20 = null, 
			string m3_CL21 = null, 
			string m3_CL22 = null, 
			string m3_CL23 = null, 
			string m3_CL24 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndBudgets",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBDS))
				throw new ArgumentNullException("m3_SBDS");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBDS", m3_SBDS.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("BVER", m3_BVER.Trim())
				.WithQueryParameter("SSTT", m3_SSTT.ToString())
				.WithQueryParameter("OSLE", m3_OSLE.ToString())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PERI", m3_PERI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY1))
				request.WithQueryParameter("KEY1", m3_KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY2))
				request.WithQueryParameter("KEY2", m3_KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY3))
				request.WithQueryParameter("KEY3", m3_KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY4))
				request.WithQueryParameter("KEY4", m3_KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY5))
				request.WithQueryParameter("KEY5", m3_KEY5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY6))
				request.WithQueryParameter("KEY6", m3_KEY6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL01))
				request.WithQueryParameter("CL01", m3_CL01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL02))
				request.WithQueryParameter("CL02", m3_CL02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL03))
				request.WithQueryParameter("CL03", m3_CL03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL04))
				request.WithQueryParameter("CL04", m3_CL04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL05))
				request.WithQueryParameter("CL05", m3_CL05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL06))
				request.WithQueryParameter("CL06", m3_CL06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL07))
				request.WithQueryParameter("CL07", m3_CL07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL08))
				request.WithQueryParameter("CL08", m3_CL08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL09))
				request.WithQueryParameter("CL09", m3_CL09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL10))
				request.WithQueryParameter("CL10", m3_CL10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL11))
				request.WithQueryParameter("CL11", m3_CL11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL12))
				request.WithQueryParameter("CL12", m3_CL12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL13))
				request.WithQueryParameter("CL13", m3_CL13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL14))
				request.WithQueryParameter("CL14", m3_CL14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL15))
				request.WithQueryParameter("CL15", m3_CL15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL16))
				request.WithQueryParameter("CL16", m3_CL16.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL17))
				request.WithQueryParameter("CL17", m3_CL17.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL18))
				request.WithQueryParameter("CL18", m3_CL18.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL19))
				request.WithQueryParameter("CL19", m3_CL19.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL20))
				request.WithQueryParameter("CL20", m3_CL20.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL21))
				request.WithQueryParameter("CL21", m3_CL21.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL22))
				request.WithQueryParameter("CL22", m3_CL22.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL23))
				request.WithQueryParameter("CL23", m3_CL23.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL24))
				request.WithQueryParameter("CL24", m3_CL24.Trim());

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
		/// Name SndDatasetDta
		/// Description Update Dataset Information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_SBDS">Dataset - statistics and budget (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_BVER">Budget version</param>
		/// <param name="m3_SSTT">Transaction type</param>
		/// <param name="m3_LEVL">OS level</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_PERI">Period</param>
		/// <param name="m3_KEY1">Key</param>
		/// <param name="m3_KEY2">Key</param>
		/// <param name="m3_KEY3">Key</param>
		/// <param name="m3_KEY4">Key</param>
		/// <param name="m3_KEY5">Key</param>
		/// <param name="m3_KEY6">Key</param>
		/// <param name="m3_CL01">Column</param>
		/// <param name="m3_CL02">Column</param>
		/// <param name="m3_CL03">Column</param>
		/// <param name="m3_CL04">Column</param>
		/// <param name="m3_CL05">Column</param>
		/// <param name="m3_CL06">Column</param>
		/// <param name="m3_CL07">Column</param>
		/// <param name="m3_CL08">Column</param>
		/// <param name="m3_CL09">Column</param>
		/// <param name="m3_CL10">Column</param>
		/// <param name="m3_CL11">Column</param>
		/// <param name="m3_CL12">Column</param>
		/// <param name="m3_CL13">Column</param>
		/// <param name="m3_CL14">Colulm</param>
		/// <param name="m3_CL15">Column</param>
		/// <param name="m3_CL16">Column</param>
		/// <param name="m3_CL17">Column</param>
		/// <param name="m3_CL18">Column</param>
		/// <param name="m3_CL19">Column</param>
		/// <param name="m3_CL20">Column</param>
		/// <param name="m3_CL21">Column</param>
		/// <param name="m3_CL22">Column</param>
		/// <param name="m3_CL23">Column</param>
		/// <param name="m3_CL24">Column</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndDatasetDta(
			string m3_SBDS, 
			string m3_FILE, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_BVER = null, 
			int? m3_SSTT = null, 
			int? m3_LEVL = null, 
			int? m3_YEA4 = null, 
			int? m3_PERI = null, 
			string m3_KEY1 = null, 
			string m3_KEY2 = null, 
			string m3_KEY3 = null, 
			string m3_KEY4 = null, 
			string m3_KEY5 = null, 
			string m3_KEY6 = null, 
			string m3_CL01 = null, 
			string m3_CL02 = null, 
			string m3_CL03 = null, 
			string m3_CL04 = null, 
			string m3_CL05 = null, 
			string m3_CL06 = null, 
			string m3_CL07 = null, 
			string m3_CL08 = null, 
			string m3_CL09 = null, 
			string m3_CL10 = null, 
			string m3_CL11 = null, 
			string m3_CL12 = null, 
			string m3_CL13 = null, 
			string m3_CL14 = null, 
			string m3_CL15 = null, 
			string m3_CL16 = null, 
			string m3_CL17 = null, 
			string m3_CL18 = null, 
			string m3_CL19 = null, 
			string m3_CL20 = null, 
			string m3_CL21 = null, 
			string m3_CL22 = null, 
			string m3_CL23 = null, 
			string m3_CL24 = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndDatasetDta",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SBDS))
				throw new ArgumentNullException("m3_SBDS");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("SBDS", m3_SBDS.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BVER))
				request.WithQueryParameter("BVER", m3_BVER.Trim());
			if (m3_SSTT.HasValue)
				request.WithQueryParameter("SSTT", m3_SSTT.Value.ToString());
			if (m3_LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3_LEVL.Value.ToString());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (m3_PERI.HasValue)
				request.WithQueryParameter("PERI", m3_PERI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_KEY1))
				request.WithQueryParameter("KEY1", m3_KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY2))
				request.WithQueryParameter("KEY2", m3_KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY3))
				request.WithQueryParameter("KEY3", m3_KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY4))
				request.WithQueryParameter("KEY4", m3_KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY5))
				request.WithQueryParameter("KEY5", m3_KEY5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY6))
				request.WithQueryParameter("KEY6", m3_KEY6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL01))
				request.WithQueryParameter("CL01", m3_CL01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL02))
				request.WithQueryParameter("CL02", m3_CL02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL03))
				request.WithQueryParameter("CL03", m3_CL03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL04))
				request.WithQueryParameter("CL04", m3_CL04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL05))
				request.WithQueryParameter("CL05", m3_CL05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL06))
				request.WithQueryParameter("CL06", m3_CL06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL07))
				request.WithQueryParameter("CL07", m3_CL07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL08))
				request.WithQueryParameter("CL08", m3_CL08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL09))
				request.WithQueryParameter("CL09", m3_CL09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL10))
				request.WithQueryParameter("CL10", m3_CL10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL11))
				request.WithQueryParameter("CL11", m3_CL11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL12))
				request.WithQueryParameter("CL12", m3_CL12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL13))
				request.WithQueryParameter("CL13", m3_CL13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL14))
				request.WithQueryParameter("CL14", m3_CL14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL15))
				request.WithQueryParameter("CL15", m3_CL15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL16))
				request.WithQueryParameter("CL16", m3_CL16.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL17))
				request.WithQueryParameter("CL17", m3_CL17.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL18))
				request.WithQueryParameter("CL18", m3_CL18.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL19))
				request.WithQueryParameter("CL19", m3_CL19.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL20))
				request.WithQueryParameter("CL20", m3_CL20.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL21))
				request.WithQueryParameter("CL21", m3_CL21.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL22))
				request.WithQueryParameter("CL22", m3_CL22.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL23))
				request.WithQueryParameter("CL23", m3_CL23.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CL24))
				request.WithQueryParameter("CL24", m3_CL24.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());

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
		/// Name TriggerForCalc
		/// Description Trigger Forecast calculation
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SBDS">Dataset - statistics and budget</param>
		/// <param name="m3_YEA4">Year</param>
		/// <param name="m3_PERI">Period</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<TriggerForCalcResponse></returns>
		/// <exception cref="M3Exception<TriggerForCalcResponse>"></exception>
		public async Task<M3Response<TriggerForCalcResponse>> TriggerForCalc(
			int? m3_CONO = null, 
			string m3_SBDS = null, 
			int? m3_YEA4 = null, 
			int? m3_PERI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TriggerForCalc",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SBDS))
				request.WithQueryParameter("SBDS", m3_SBDS.Trim());
			if (m3_YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3_YEA4.Value.ToString());
			if (m3_PERI.HasValue)
				request.WithQueryParameter("PERI", m3_PERI.Value.ToString());

			// Execute the request
			var result = await Execute<TriggerForCalcResponse>(
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
		/// Name TriggerForImpl
		/// Description Trigger Forecast implementation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SBDS">Dataset - statistics and budget</param>
		/// <param name="m3_BVER">Budget version</param>
		/// <param name="m3_SSTT">Transaction type</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="m3_FRPE">Period</param>
		/// <param name="m3_TOPE">Period</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ACUM">Cumulative</param>
		/// <param name="m3_MDQT">Master demand</param>
		/// <param name="m3_MDVR">Master demand schedule version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<TriggerForImplResponse></returns>
		/// <exception cref="M3Exception<TriggerForImplResponse>"></exception>
		public async Task<M3Response<TriggerForImplResponse>> TriggerForImpl(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_SBDS = null, 
			string m3_BVER = null, 
			int? m3_SSTT = null, 
			string m3_FLDI = null, 
			int? m3_FRPE = null, 
			int? m3_TOPE = null, 
			string m3_WHLO = null, 
			int? m3_ACUM = null, 
			int? m3_MDQT = null, 
			string m3_MDVR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TriggerForImpl",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SBDS))
				request.WithQueryParameter("SBDS", m3_SBDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BVER))
				request.WithQueryParameter("BVER", m3_BVER.Trim());
			if (m3_SSTT.HasValue)
				request.WithQueryParameter("SSTT", m3_SSTT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());
			if (m3_FRPE.HasValue)
				request.WithQueryParameter("FRPE", m3_FRPE.Value.ToString());
			if (m3_TOPE.HasValue)
				request.WithQueryParameter("TOPE", m3_TOPE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_ACUM.HasValue)
				request.WithQueryParameter("ACUM", m3_ACUM.Value.ToString());
			if (m3_MDQT.HasValue)
				request.WithQueryParameter("MDQT", m3_MDQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MDVR))
				request.WithQueryParameter("MDVR", m3_MDVR.Trim());

			// Execute the request
			var result = await Execute<TriggerForImplResponse>(
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
