/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3SBDS">Dataset (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRDI">From division</param>
		/// <param name="m3TODI">To Division</param>
		/// <param name="m3FRTR">From Transaction Type</param>
		/// <param name="m3TOTR">To Transaction Type</param>
		/// <param name="m3FRBV">From Budget Version</param>
		/// <param name="m3TOBV">To Budget Version</param>
		/// <param name="m3FRYR">From year</param>
		/// <param name="m3TOYR">To year</param>
		/// <param name="m3FRPR">From Period</param>
		/// <param name="m3TOPR">To Period</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDataResponse></returns>
		/// <exception cref="M3Exception<SelDataResponse>"></exception>
		public async Task<M3Response<SelDataResponse>> SelData(
			string m3SBDS, 
			string m3FILE, 
			int? m3CONO = null, 
			string m3FRDI = null, 
			string m3TODI = null, 
			int? m3FRTR = null, 
			int? m3TOTR = null, 
			string m3FRBV = null, 
			string m3TOBV = null, 
			string m3FRYR = null, 
			string m3TOYR = null, 
			int? m3FRPR = null, 
			int? m3TOPR = null, 
			decimal? m3LMTS = null, 
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
			if (string.IsNullOrWhiteSpace(m3SBDS))
				throw new ArgumentNullException(nameof(m3SBDS));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("SBDS", m3SBDS.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRDI))
				request.WithQueryParameter("FRDI", m3FRDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TODI))
				request.WithQueryParameter("TODI", m3TODI.Trim());
			if (m3FRTR.HasValue)
				request.WithQueryParameter("FRTR", m3FRTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOTR.HasValue)
				request.WithQueryParameter("TOTR", m3TOTR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRBV))
				request.WithQueryParameter("FRBV", m3FRBV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOBV))
				request.WithQueryParameter("TOBV", m3TOBV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRYR))
				request.WithQueryParameter("FRYR", m3FRYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOYR))
				request.WithQueryParameter("TOYR", m3TOYR.Trim());
			if (m3FRPR.HasValue)
				request.WithQueryParameter("FRPR", m3FRPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPR.HasValue)
				request.WithQueryParameter("TOPR", m3TOPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelDataResponse>(
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
		/// Name SelDataMercia
		/// Description Select Dataset data for Mercia
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SBDS">Dataset - statistics and budget (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRDI">From Division</param>
		/// <param name="m3TODI">To Division</param>
		/// <param name="m3FRTR">From Transaction type</param>
		/// <param name="m3TOTR">To Transaction Type</param>
		/// <param name="m3FRBV">From Budget Version</param>
		/// <param name="m3TOBV">To Budget Version</param>
		/// <param name="m3FRYR">From year</param>
		/// <param name="m3TOYR">To year</param>
		/// <param name="m3FRPR">From Period</param>
		/// <param name="m3TOPR">To Period</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDataMerciaResponse></returns>
		/// <exception cref="M3Exception<SelDataMerciaResponse>"></exception>
		public async Task<M3Response<SelDataMerciaResponse>> SelDataMercia(
			string m3SBDS, 
			string m3FILE, 
			int? m3CONO = null, 
			string m3FRDI = null, 
			string m3TODI = null, 
			int? m3FRTR = null, 
			int? m3TOTR = null, 
			string m3FRBV = null, 
			string m3TOBV = null, 
			string m3FRYR = null, 
			string m3TOYR = null, 
			int? m3FRPR = null, 
			int? m3TOPR = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
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
			if (string.IsNullOrWhiteSpace(m3SBDS))
				throw new ArgumentNullException(nameof(m3SBDS));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("SBDS", m3SBDS.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRDI))
				request.WithQueryParameter("FRDI", m3FRDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TODI))
				request.WithQueryParameter("TODI", m3TODI.Trim());
			if (m3FRTR.HasValue)
				request.WithQueryParameter("FRTR", m3FRTR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOTR.HasValue)
				request.WithQueryParameter("TOTR", m3TOTR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRBV))
				request.WithQueryParameter("FRBV", m3FRBV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOBV))
				request.WithQueryParameter("TOBV", m3TOBV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRYR))
				request.WithQueryParameter("FRYR", m3FRYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOYR))
				request.WithQueryParameter("TOYR", m3TOYR.Trim());
			if (m3FRPR.HasValue)
				request.WithQueryParameter("FRPR", m3FRPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPR.HasValue)
				request.WithQueryParameter("TOPR", m3TOPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<SelDataMerciaResponse>(
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
		/// Name SelDetailedData
		/// Description Select Dataset data
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SBDS">Dataset (Required)</param>
		/// <param name="m3SSTT">Transaction type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BVER">Budget version</param>
		/// <param name="m3KEY1">Key 1</param>
		/// <param name="m3KEY2">Key 2</param>
		/// <param name="m3KEY3">Key 3</param>
		/// <param name="m3KEY4">Key 4</param>
		/// <param name="m3KEY5">Key 5</param>
		/// <param name="m3KEY6">Key 6</param>
		/// <param name="m3FRYR">From Year</param>
		/// <param name="m3FRPR">From Period</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelDetailedDataResponse></returns>
		/// <exception cref="M3Exception<SelDetailedDataResponse>"></exception>
		public async Task<M3Response<SelDetailedDataResponse>> SelDetailedData(
			string m3SBDS, 
			int m3SSTT, 
			int? m3CONO = null, 
			string m3BVER = null, 
			string m3KEY1 = null, 
			string m3KEY2 = null, 
			string m3KEY3 = null, 
			string m3KEY4 = null, 
			string m3KEY5 = null, 
			string m3KEY6 = null, 
			int? m3FRYR = null, 
			int? m3FRPR = null, 
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
			if (string.IsNullOrWhiteSpace(m3SBDS))
				throw new ArgumentNullException(nameof(m3SBDS));

			// Set mandatory parameters
			request
				.WithQueryParameter("SBDS", m3SBDS.Trim())
				.WithQueryParameter("SSTT", m3SSTT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BVER))
				request.WithQueryParameter("BVER", m3BVER.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY1))
				request.WithQueryParameter("KEY1", m3KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY2))
				request.WithQueryParameter("KEY2", m3KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY3))
				request.WithQueryParameter("KEY3", m3KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY4))
				request.WithQueryParameter("KEY4", m3KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY5))
				request.WithQueryParameter("KEY5", m3KEY5.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY6))
				request.WithQueryParameter("KEY6", m3KEY6.Trim());
			if (m3FRYR.HasValue)
				request.WithQueryParameter("FRYR", m3FRYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRPR.HasValue)
				request.WithQueryParameter("FRPR", m3FRPR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelDetailedDataResponse>(
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
		/// Name Select
		/// Description Select Dataset
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FDAT">From Dataset</param>
		/// <param name="m3TDAT">To Dataset</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			int? m3CONO = null, 
			string m3FDAT = null, 
			string m3TDAT = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDAT))
				request.WithQueryParameter("FDAT", m3FDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDAT))
				request.WithQueryParameter("TDAT", m3TDAT.Trim());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name SelectMercia
		/// Description Select Dataset
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FDAT">From dataset</param>
		/// <param name="m3TDAT">To dataset</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectMerciaResponse></returns>
		/// <exception cref="M3Exception<SelectMerciaResponse>"></exception>
		public async Task<M3Response<SelectMerciaResponse>> SelectMercia(
			int? m3CONO = null, 
			string m3FDAT = null, 
			string m3TDAT = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDAT))
				request.WithQueryParameter("FDAT", m3FDAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDAT))
				request.WithQueryParameter("TDAT", m3TDAT.Trim());

			// Execute the request
			var result = await Execute<SelectMerciaResponse>(
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
		/// Name SndBudgets
		/// Description Add sales budgets without answer
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SBDS">Dataset - statistics and budget (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3SSTT">Transaction type (Required)</param>
		/// <param name="m3OSLE">Os level (Required)</param>
		/// <param name="m3YEA4">Year (Required)</param>
		/// <param name="m3PERI">Period (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3KEY1">Key</param>
		/// <param name="m3KEY2">Key</param>
		/// <param name="m3KEY3">key</param>
		/// <param name="m3KEY4">Key</param>
		/// <param name="m3KEY5">Key</param>
		/// <param name="m3KEY6">key</param>
		/// <param name="m3CL01">Column</param>
		/// <param name="m3CL02">Column</param>
		/// <param name="m3CL03">Column</param>
		/// <param name="m3CL04">Column</param>
		/// <param name="m3CL05">Column</param>
		/// <param name="m3CL06">Column</param>
		/// <param name="m3CL07">Column</param>
		/// <param name="m3CL08">Column</param>
		/// <param name="m3CL09">Column</param>
		/// <param name="m3CL10">Column</param>
		/// <param name="m3CL11">Column</param>
		/// <param name="m3CL12">Column</param>
		/// <param name="m3CL13">Column</param>
		/// <param name="m3CL14">Column</param>
		/// <param name="m3CL15">Column</param>
		/// <param name="m3CL16">Column</param>
		/// <param name="m3CL17">Column</param>
		/// <param name="m3CL18">Column</param>
		/// <param name="m3CL19">Column</param>
		/// <param name="m3CL20">Column</param>
		/// <param name="m3CL21">Column</param>
		/// <param name="m3CL22">Column</param>
		/// <param name="m3CL23">Column</param>
		/// <param name="m3CL24">Column</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndBudgets(
			string m3SBDS, 
			string m3FILE, 
			string m3BVER, 
			int m3SSTT, 
			int m3OSLE, 
			int m3YEA4, 
			int m3PERI, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3KEY1 = null, 
			string m3KEY2 = null, 
			string m3KEY3 = null, 
			string m3KEY4 = null, 
			string m3KEY5 = null, 
			string m3KEY6 = null, 
			string m3CL01 = null, 
			string m3CL02 = null, 
			string m3CL03 = null, 
			string m3CL04 = null, 
			string m3CL05 = null, 
			string m3CL06 = null, 
			string m3CL07 = null, 
			string m3CL08 = null, 
			string m3CL09 = null, 
			string m3CL10 = null, 
			string m3CL11 = null, 
			string m3CL12 = null, 
			string m3CL13 = null, 
			string m3CL14 = null, 
			string m3CL15 = null, 
			string m3CL16 = null, 
			string m3CL17 = null, 
			string m3CL18 = null, 
			string m3CL19 = null, 
			string m3CL20 = null, 
			string m3CL21 = null, 
			string m3CL22 = null, 
			string m3CL23 = null, 
			string m3CL24 = null, 
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
			if (string.IsNullOrWhiteSpace(m3SBDS))
				throw new ArgumentNullException(nameof(m3SBDS));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));

			// Set mandatory parameters
			request
				.WithQueryParameter("SBDS", m3SBDS.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("BVER", m3BVER.Trim())
				.WithQueryParameter("SSTT", m3SSTT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OSLE", m3OSLE.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("YEA4", m3YEA4.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PERI", m3PERI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY1))
				request.WithQueryParameter("KEY1", m3KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY2))
				request.WithQueryParameter("KEY2", m3KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY3))
				request.WithQueryParameter("KEY3", m3KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY4))
				request.WithQueryParameter("KEY4", m3KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY5))
				request.WithQueryParameter("KEY5", m3KEY5.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY6))
				request.WithQueryParameter("KEY6", m3KEY6.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL01))
				request.WithQueryParameter("CL01", m3CL01.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL02))
				request.WithQueryParameter("CL02", m3CL02.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL03))
				request.WithQueryParameter("CL03", m3CL03.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL04))
				request.WithQueryParameter("CL04", m3CL04.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL05))
				request.WithQueryParameter("CL05", m3CL05.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL06))
				request.WithQueryParameter("CL06", m3CL06.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL07))
				request.WithQueryParameter("CL07", m3CL07.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL08))
				request.WithQueryParameter("CL08", m3CL08.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL09))
				request.WithQueryParameter("CL09", m3CL09.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL10))
				request.WithQueryParameter("CL10", m3CL10.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL11))
				request.WithQueryParameter("CL11", m3CL11.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL12))
				request.WithQueryParameter("CL12", m3CL12.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL13))
				request.WithQueryParameter("CL13", m3CL13.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL14))
				request.WithQueryParameter("CL14", m3CL14.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL15))
				request.WithQueryParameter("CL15", m3CL15.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL16))
				request.WithQueryParameter("CL16", m3CL16.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL17))
				request.WithQueryParameter("CL17", m3CL17.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL18))
				request.WithQueryParameter("CL18", m3CL18.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL19))
				request.WithQueryParameter("CL19", m3CL19.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL20))
				request.WithQueryParameter("CL20", m3CL20.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL21))
				request.WithQueryParameter("CL21", m3CL21.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL22))
				request.WithQueryParameter("CL22", m3CL22.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL23))
				request.WithQueryParameter("CL23", m3CL23.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL24))
				request.WithQueryParameter("CL24", m3CL24.Trim());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name SndDatasetDta
		/// Description Update Dataset Information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3SBDS">Dataset - statistics and budget (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3BVER">Budget version</param>
		/// <param name="m3SSTT">Transaction type</param>
		/// <param name="m3LEVL">OS level</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3PERI">Period</param>
		/// <param name="m3KEY1">Key</param>
		/// <param name="m3KEY2">Key</param>
		/// <param name="m3KEY3">Key</param>
		/// <param name="m3KEY4">Key</param>
		/// <param name="m3KEY5">Key</param>
		/// <param name="m3KEY6">Key</param>
		/// <param name="m3CL01">Column</param>
		/// <param name="m3CL02">Column</param>
		/// <param name="m3CL03">Column</param>
		/// <param name="m3CL04">Column</param>
		/// <param name="m3CL05">Column</param>
		/// <param name="m3CL06">Column</param>
		/// <param name="m3CL07">Column</param>
		/// <param name="m3CL08">Column</param>
		/// <param name="m3CL09">Column</param>
		/// <param name="m3CL10">Column</param>
		/// <param name="m3CL11">Column</param>
		/// <param name="m3CL12">Column</param>
		/// <param name="m3CL13">Column</param>
		/// <param name="m3CL14">Colulm</param>
		/// <param name="m3CL15">Column</param>
		/// <param name="m3CL16">Column</param>
		/// <param name="m3CL17">Column</param>
		/// <param name="m3CL18">Column</param>
		/// <param name="m3CL19">Column</param>
		/// <param name="m3CL20">Column</param>
		/// <param name="m3CL21">Column</param>
		/// <param name="m3CL22">Column</param>
		/// <param name="m3CL23">Column</param>
		/// <param name="m3CL24">Column</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndDatasetDta(
			string m3SBDS, 
			string m3FILE, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3BVER = null, 
			int? m3SSTT = null, 
			int? m3LEVL = null, 
			int? m3YEA4 = null, 
			int? m3PERI = null, 
			string m3KEY1 = null, 
			string m3KEY2 = null, 
			string m3KEY3 = null, 
			string m3KEY4 = null, 
			string m3KEY5 = null, 
			string m3KEY6 = null, 
			string m3CL01 = null, 
			string m3CL02 = null, 
			string m3CL03 = null, 
			string m3CL04 = null, 
			string m3CL05 = null, 
			string m3CL06 = null, 
			string m3CL07 = null, 
			string m3CL08 = null, 
			string m3CL09 = null, 
			string m3CL10 = null, 
			string m3CL11 = null, 
			string m3CL12 = null, 
			string m3CL13 = null, 
			string m3CL14 = null, 
			string m3CL15 = null, 
			string m3CL16 = null, 
			string m3CL17 = null, 
			string m3CL18 = null, 
			string m3CL19 = null, 
			string m3CL20 = null, 
			string m3CL21 = null, 
			string m3CL22 = null, 
			string m3CL23 = null, 
			string m3CL24 = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
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
			if (string.IsNullOrWhiteSpace(m3SBDS))
				throw new ArgumentNullException(nameof(m3SBDS));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("SBDS", m3SBDS.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BVER))
				request.WithQueryParameter("BVER", m3BVER.Trim());
			if (m3SSTT.HasValue)
				request.WithQueryParameter("SSTT", m3SSTT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3LEVL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PERI.HasValue)
				request.WithQueryParameter("PERI", m3PERI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3KEY1))
				request.WithQueryParameter("KEY1", m3KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY2))
				request.WithQueryParameter("KEY2", m3KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY3))
				request.WithQueryParameter("KEY3", m3KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY4))
				request.WithQueryParameter("KEY4", m3KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY5))
				request.WithQueryParameter("KEY5", m3KEY5.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY6))
				request.WithQueryParameter("KEY6", m3KEY6.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL01))
				request.WithQueryParameter("CL01", m3CL01.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL02))
				request.WithQueryParameter("CL02", m3CL02.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL03))
				request.WithQueryParameter("CL03", m3CL03.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL04))
				request.WithQueryParameter("CL04", m3CL04.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL05))
				request.WithQueryParameter("CL05", m3CL05.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL06))
				request.WithQueryParameter("CL06", m3CL06.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL07))
				request.WithQueryParameter("CL07", m3CL07.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL08))
				request.WithQueryParameter("CL08", m3CL08.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL09))
				request.WithQueryParameter("CL09", m3CL09.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL10))
				request.WithQueryParameter("CL10", m3CL10.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL11))
				request.WithQueryParameter("CL11", m3CL11.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL12))
				request.WithQueryParameter("CL12", m3CL12.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL13))
				request.WithQueryParameter("CL13", m3CL13.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL14))
				request.WithQueryParameter("CL14", m3CL14.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL15))
				request.WithQueryParameter("CL15", m3CL15.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL16))
				request.WithQueryParameter("CL16", m3CL16.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL17))
				request.WithQueryParameter("CL17", m3CL17.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL18))
				request.WithQueryParameter("CL18", m3CL18.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL19))
				request.WithQueryParameter("CL19", m3CL19.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL20))
				request.WithQueryParameter("CL20", m3CL20.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL21))
				request.WithQueryParameter("CL21", m3CL21.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL22))
				request.WithQueryParameter("CL22", m3CL22.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL23))
				request.WithQueryParameter("CL23", m3CL23.Trim());
			if (!string.IsNullOrWhiteSpace(m3CL24))
				request.WithQueryParameter("CL24", m3CL24.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<M3Record>(
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
		/// Name TriggerForCalc
		/// Description Trigger Forecast calculation
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SBDS">Dataset - statistics and budget</param>
		/// <param name="m3YEA4">Year</param>
		/// <param name="m3PERI">Period</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<TriggerForCalcResponse></returns>
		/// <exception cref="M3Exception<TriggerForCalcResponse>"></exception>
		public async Task<M3Response<TriggerForCalcResponse>> TriggerForCalc(
			int? m3CONO = null, 
			string m3SBDS = null, 
			int? m3YEA4 = null, 
			int? m3PERI = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SBDS))
				request.WithQueryParameter("SBDS", m3SBDS.Trim());
			if (m3YEA4.HasValue)
				request.WithQueryParameter("YEA4", m3YEA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PERI.HasValue)
				request.WithQueryParameter("PERI", m3PERI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<TriggerForCalcResponse>(
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
		/// Name TriggerForImpl
		/// Description Trigger Forecast implementation
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SBDS">Dataset - statistics and budget</param>
		/// <param name="m3BVER">Budget version</param>
		/// <param name="m3SSTT">Transaction type</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3FRPE">Period</param>
		/// <param name="m3TOPE">Period</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ACUM">Cumulative</param>
		/// <param name="m3MDQT">Master demand</param>
		/// <param name="m3MDVR">Master demand schedule version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<TriggerForImplResponse></returns>
		/// <exception cref="M3Exception<TriggerForImplResponse>"></exception>
		public async Task<M3Response<TriggerForImplResponse>> TriggerForImpl(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3SBDS = null, 
			string m3BVER = null, 
			int? m3SSTT = null, 
			string m3FLDI = null, 
			int? m3FRPE = null, 
			int? m3TOPE = null, 
			string m3WHLO = null, 
			int? m3ACUM = null, 
			int? m3MDQT = null, 
			string m3MDVR = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SBDS))
				request.WithQueryParameter("SBDS", m3SBDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3BVER))
				request.WithQueryParameter("BVER", m3BVER.Trim());
			if (m3SSTT.HasValue)
				request.WithQueryParameter("SSTT", m3SSTT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (m3FRPE.HasValue)
				request.WithQueryParameter("FRPE", m3FRPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPE.HasValue)
				request.WithQueryParameter("TOPE", m3TOPE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3ACUM.HasValue)
				request.WithQueryParameter("ACUM", m3ACUM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MDQT.HasValue)
				request.WithQueryParameter("MDQT", m3MDQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MDVR))
				request.WithQueryParameter("MDVR", m3MDVR.Trim());

			// Execute the request
			var result = await Execute<TriggerForImplResponse>(
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
