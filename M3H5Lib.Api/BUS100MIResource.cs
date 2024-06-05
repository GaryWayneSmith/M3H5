/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.BUS100MI;
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
	/// Name: BUS100MI
	/// Component Name: Financials
	/// Description: Api: Budget definition interface
	/// Version Release: 14.x
	///</summary>
	public partial class BUS100MIResource : M3BaseResourceEndpoint
	{
		public BUS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "BUS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBudgetHeader
		/// Description Adds budget header definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_BSPR">Start period - budget (Required)</param>
		/// <param name="m3_CRTP">Exchange rate type (Required)</param>
		/// <param name="m3_NPAM">Number of periods (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_ROPP">Rounding-off category</param>
		/// <param name="m3_UPDB">Update balance file</param>
		/// <param name="m3_DTMP">Allocation template</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBudgetHeader(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			string m3_TX40, 
			int m3_BSPR, 
			int m3_CRTP, 
			int m3_NPAM, 
			int? m3_CONO = null, 
			string m3_TX15 = null, 
			int? m3_ROPP = null, 
			int? m3_UPDB = null, 
			string m3_DTMP = null, 
			string m3_ACGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBudgetHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("BSPR", m3_BSPR.ToString())
				.WithQueryParameter("CRTP", m3_CRTP.ToString())
				.WithQueryParameter("NPAM", m3_NPAM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3_ROPP.Value.ToString());
			if (m3_UPDB.HasValue)
				request.WithQueryParameter("UPDB", m3_UPDB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DTMP))
				request.WithQueryParameter("DTMP", m3_DTMP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());

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
		/// Name AddBudgetLines
		/// Description Adds budget lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="m3_BCUA">Total Foreign currency amount - budget</param>
		/// <param name="m3_BUDQ">Total Budget quantity</param>
		/// <param name="m3_BCU1">Foreign currency amount - budget 1</param>
		/// <param name="m3_BCU2">Foreign currency amount - budget 2</param>
		/// <param name="m3_BCU3">Foreign currency amount - budget 3</param>
		/// <param name="m3_BCU4">Foreign currency amount - budget 4</param>
		/// <param name="m3_BCU5">Foreign currency amount - budget 5</param>
		/// <param name="m3_BCU6">Foreign currency amount - budget 6</param>
		/// <param name="m3_BCU7">Foreign currency amount - budget 7</param>
		/// <param name="m3_BCU8">Foreign currency amount - budget 8</param>
		/// <param name="m3_BCU9">Foreign currency amount - budget 9</param>
		/// <param name="m3_BC10">Foreign currency amount - budget 10</param>
		/// <param name="m3_BC11">Foreign currency amount - budget 11</param>
		/// <param name="m3_BC12">Foreign currency amount - budget 12</param>
		/// <param name="m3_BC13">Foreign currency amount - budget 13</param>
		/// <param name="m3_BC14">Foreign currency amount - budget 14</param>
		/// <param name="m3_BC15">Foreign currency amount - budget 15</param>
		/// <param name="m3_BUD1">Budget quantity 1</param>
		/// <param name="m3_BUD2">Budget quantity 2</param>
		/// <param name="m3_BUD3">Budget quantity 3</param>
		/// <param name="m3_BUD4">Budget quantity 4</param>
		/// <param name="m3_BUD5">Budget quantity 5</param>
		/// <param name="m3_BUD6">Budget quantity 6</param>
		/// <param name="m3_BUD7">Budget quantity 7</param>
		/// <param name="m3_BUD8">Budget quantity 8</param>
		/// <param name="m3_BUD9">Budget quantity 9</param>
		/// <param name="m3_BU10">Budget quantity 10</param>
		/// <param name="m3_BU11">Budget quantity 11</param>
		/// <param name="m3_BU12">Budget quantity 12</param>
		/// <param name="m3_BU13">Budget quantity 13</param>
		/// <param name="m3_BU14">Budget quantity 14</param>
		/// <param name="m3_BU15">Budget quantity 15</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBudgetLines(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			string m3_AIT1, 
			string m3_CUCD, 
			int? m3_CONO = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			int? m3_AMTN = null, 
			decimal? m3_BCUA = null, 
			decimal? m3_BUDQ = null, 
			decimal? m3_BCU1 = null, 
			decimal? m3_BCU2 = null, 
			decimal? m3_BCU3 = null, 
			decimal? m3_BCU4 = null, 
			decimal? m3_BCU5 = null, 
			decimal? m3_BCU6 = null, 
			decimal? m3_BCU7 = null, 
			decimal? m3_BCU8 = null, 
			decimal? m3_BCU9 = null, 
			decimal? m3_BC10 = null, 
			decimal? m3_BC11 = null, 
			decimal? m3_BC12 = null, 
			decimal? m3_BC13 = null, 
			decimal? m3_BC14 = null, 
			decimal? m3_BC15 = null, 
			decimal? m3_BUD1 = null, 
			decimal? m3_BUD2 = null, 
			decimal? m3_BUD3 = null, 
			decimal? m3_BUD4 = null, 
			decimal? m3_BUD5 = null, 
			decimal? m3_BUD6 = null, 
			decimal? m3_BUD7 = null, 
			decimal? m3_BUD8 = null, 
			decimal? m3_BUD9 = null, 
			decimal? m3_BU10 = null, 
			decimal? m3_BU11 = null, 
			decimal? m3_BU12 = null, 
			decimal? m3_BU13 = null, 
			decimal? m3_BU14 = null, 
			decimal? m3_BU15 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBudgetLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");
			if (string.IsNullOrWhiteSpace(m3_AIT1))
				throw new ArgumentNullException("m3_AIT1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim())
				.WithQueryParameter("AIT1", m3_AIT1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());
			if (m3_BCUA.HasValue)
				request.WithQueryParameter("BCUA", m3_BCUA.Value.ToString());
			if (m3_BUDQ.HasValue)
				request.WithQueryParameter("BUDQ", m3_BUDQ.Value.ToString());
			if (m3_BCU1.HasValue)
				request.WithQueryParameter("BCU1", m3_BCU1.Value.ToString());
			if (m3_BCU2.HasValue)
				request.WithQueryParameter("BCU2", m3_BCU2.Value.ToString());
			if (m3_BCU3.HasValue)
				request.WithQueryParameter("BCU3", m3_BCU3.Value.ToString());
			if (m3_BCU4.HasValue)
				request.WithQueryParameter("BCU4", m3_BCU4.Value.ToString());
			if (m3_BCU5.HasValue)
				request.WithQueryParameter("BCU5", m3_BCU5.Value.ToString());
			if (m3_BCU6.HasValue)
				request.WithQueryParameter("BCU6", m3_BCU6.Value.ToString());
			if (m3_BCU7.HasValue)
				request.WithQueryParameter("BCU7", m3_BCU7.Value.ToString());
			if (m3_BCU8.HasValue)
				request.WithQueryParameter("BCU8", m3_BCU8.Value.ToString());
			if (m3_BCU9.HasValue)
				request.WithQueryParameter("BCU9", m3_BCU9.Value.ToString());
			if (m3_BC10.HasValue)
				request.WithQueryParameter("BC10", m3_BC10.Value.ToString());
			if (m3_BC11.HasValue)
				request.WithQueryParameter("BC11", m3_BC11.Value.ToString());
			if (m3_BC12.HasValue)
				request.WithQueryParameter("BC12", m3_BC12.Value.ToString());
			if (m3_BC13.HasValue)
				request.WithQueryParameter("BC13", m3_BC13.Value.ToString());
			if (m3_BC14.HasValue)
				request.WithQueryParameter("BC14", m3_BC14.Value.ToString());
			if (m3_BC15.HasValue)
				request.WithQueryParameter("BC15", m3_BC15.Value.ToString());
			if (m3_BUD1.HasValue)
				request.WithQueryParameter("BUD1", m3_BUD1.Value.ToString());
			if (m3_BUD2.HasValue)
				request.WithQueryParameter("BUD2", m3_BUD2.Value.ToString());
			if (m3_BUD3.HasValue)
				request.WithQueryParameter("BUD3", m3_BUD3.Value.ToString());
			if (m3_BUD4.HasValue)
				request.WithQueryParameter("BUD4", m3_BUD4.Value.ToString());
			if (m3_BUD5.HasValue)
				request.WithQueryParameter("BUD5", m3_BUD5.Value.ToString());
			if (m3_BUD6.HasValue)
				request.WithQueryParameter("BUD6", m3_BUD6.Value.ToString());
			if (m3_BUD7.HasValue)
				request.WithQueryParameter("BUD7", m3_BUD7.Value.ToString());
			if (m3_BUD8.HasValue)
				request.WithQueryParameter("BUD8", m3_BUD8.Value.ToString());
			if (m3_BUD9.HasValue)
				request.WithQueryParameter("BUD9", m3_BUD9.Value.ToString());
			if (m3_BU10.HasValue)
				request.WithQueryParameter("BU10", m3_BU10.Value.ToString());
			if (m3_BU11.HasValue)
				request.WithQueryParameter("BU11", m3_BU11.Value.ToString());
			if (m3_BU12.HasValue)
				request.WithQueryParameter("BU12", m3_BU12.Value.ToString());
			if (m3_BU13.HasValue)
				request.WithQueryParameter("BU13", m3_BU13.Value.ToString());
			if (m3_BU14.HasValue)
				request.WithQueryParameter("BU14", m3_BU14.Value.ToString());
			if (m3_BU15.HasValue)
				request.WithQueryParameter("BU15", m3_BU15.Value.ToString());

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
		/// Name AddBudgetLnPer
		/// Description Add Budget line per period
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_BUPE">Budget period (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="m3_BCUA">Foreign currency amount - budget</param>
		/// <param name="m3_BUDQ">Budget quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBudgetLnPer(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			string m3_AIT1, 
			string m3_CUCD, 
			int m3_BUPE, 
			int? m3_CONO = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			int? m3_AMTN = null, 
			decimal? m3_BCUA = null, 
			decimal? m3_BUDQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBudgetLnPer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");
			if (string.IsNullOrWhiteSpace(m3_AIT1))
				throw new ArgumentNullException("m3_AIT1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim())
				.WithQueryParameter("AIT1", m3_AIT1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("BUPE", m3_BUPE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());
			if (m3_BCUA.HasValue)
				request.WithQueryParameter("BCUA", m3_BCUA.Value.ToString());
			if (m3_BUDQ.HasValue)
				request.WithQueryParameter("BUDQ", m3_BUDQ.Value.ToString());

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
		/// Name DelBudgetHeader
		/// Description Deletes budget header definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBudgetHeader(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBudgetHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name DelBudgetLines
		/// Description Deletes budget lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BUPE">Budget period</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBudgetLines(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			string m3_AIT1, 
			string m3_CUCD, 
			int? m3_CONO = null, 
			int? m3_BUPE = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			int? m3_AMTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBudgetLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");
			if (string.IsNullOrWhiteSpace(m3_AIT1))
				throw new ArgumentNullException("m3_AIT1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim())
				.WithQueryParameter("AIT1", m3_AIT1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_BUPE.HasValue)
				request.WithQueryParameter("BUPE", m3_BUPE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());

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
		/// Name DspBudgetValues
		/// Description Displays Budget values
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_PERF">FromBudget period (Required)</param>
		/// <param name="m3_PERT">To Budget period (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FIT1">From Accounting dimension 1</param>
		/// <param name="m3_TIT1">To Accounting dimension 1</param>
		/// <param name="m3_FIT2">From Accounting dimension 2</param>
		/// <param name="m3_TIT2">To Accounting dimension 2</param>
		/// <param name="m3_FIT3">From Accounting dimension 3</param>
		/// <param name="m3_TIT3">To Accounting dimension 3</param>
		/// <param name="m3_FIT4">From Accounting dimension 4</param>
		/// <param name="m3_TIT4">To Accounting dimension 4</param>
		/// <param name="m3_FIT5">From Accounting dimension 5</param>
		/// <param name="m3_TIT5">To Accounting dimension 5</param>
		/// <param name="m3_FIT6">From Accounting dimension 6</param>
		/// <param name="m3_TIT6">To Accounting dimension 6</param>
		/// <param name="m3_FIT7">From Accounting dimension 7</param>
		/// <param name="m3_TIT7">To Accounting dimension 7</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DspBudgetValuesResponse></returns>
		/// <exception cref="M3Exception<DspBudgetValuesResponse>"></exception>
		public async Task<M3Response<DspBudgetValuesResponse>> DspBudgetValues(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			int m3_PERF, 
			int m3_PERT, 
			int? m3_CONO = null, 
			string m3_FIT1 = null, 
			string m3_TIT1 = null, 
			string m3_FIT2 = null, 
			string m3_TIT2 = null, 
			string m3_FIT3 = null, 
			string m3_TIT3 = null, 
			string m3_FIT4 = null, 
			string m3_TIT4 = null, 
			string m3_FIT5 = null, 
			string m3_TIT5 = null, 
			string m3_FIT6 = null, 
			string m3_TIT6 = null, 
			string m3_FIT7 = null, 
			string m3_TIT7 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DspBudgetValues",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim())
				.WithQueryParameter("PERF", m3_PERF.ToString())
				.WithQueryParameter("PERT", m3_PERT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FIT1))
				request.WithQueryParameter("FIT1", m3_FIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT1))
				request.WithQueryParameter("TIT1", m3_TIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT2))
				request.WithQueryParameter("FIT2", m3_FIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT2))
				request.WithQueryParameter("TIT2", m3_TIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT3))
				request.WithQueryParameter("FIT3", m3_FIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT3))
				request.WithQueryParameter("TIT3", m3_TIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT4))
				request.WithQueryParameter("FIT4", m3_FIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT4))
				request.WithQueryParameter("TIT4", m3_TIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT5))
				request.WithQueryParameter("FIT5", m3_FIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT5))
				request.WithQueryParameter("TIT5", m3_TIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT6))
				request.WithQueryParameter("FIT6", m3_FIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT6))
				request.WithQueryParameter("TIT6", m3_TIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIT7))
				request.WithQueryParameter("FIT7", m3_FIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIT7))
				request.WithQueryParameter("TIT7", m3_TIT7.Trim());

			// Execute the request
			var result = await Execute<DspBudgetValuesResponse>(
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
		/// Name GetBudPerPeriod
		/// Description Displays budget per period
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_BUPE">Budget period (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBudPerPeriodResponse></returns>
		/// <exception cref="M3Exception<GetBudPerPeriodResponse>"></exception>
		public async Task<M3Response<GetBudPerPeriodResponse>> GetBudPerPeriod(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			string m3_AIT1, 
			string m3_CUCD, 
			int m3_BUPE, 
			int? m3_CONO = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			int? m3_AMTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBudPerPeriod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");
			if (string.IsNullOrWhiteSpace(m3_AIT1))
				throw new ArgumentNullException("m3_AIT1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim())
				.WithQueryParameter("AIT1", m3_AIT1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("BUPE", m3_BUPE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());

			// Execute the request
			var result = await Execute<GetBudPerPeriodResponse>(
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
		/// Name GetBudgetHeader
		/// Description Displays budget header definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBudgetHeaderResponse></returns>
		/// <exception cref="M3Exception<GetBudgetHeaderResponse>"></exception>
		public async Task<M3Response<GetBudgetHeaderResponse>> GetBudgetHeader(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBudgetHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetBudgetHeaderResponse>(
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
		/// Name LockBudget
		/// Description Locks budget header definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> LockBudget(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LockBudget",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name LstBudPeriodVal
		/// Description Lists budget periodic values
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="m3_BUPE">Budget period</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBudPeriodValResponse></returns>
		/// <exception cref="M3Exception<LstBudPeriodValResponse>"></exception>
		public async Task<M3Response<LstBudPeriodValResponse>> LstBudPeriodVal(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			int? m3_CONO = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_CUCD = null, 
			int? m3_AMTN = null, 
			int? m3_BUPE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBudPeriodVal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());
			if (m3_BUPE.HasValue)
				request.WithQueryParameter("BUPE", m3_BUPE.Value.ToString());

			// Execute the request
			var result = await Execute<LstBudPeriodValResponse>(
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
		/// Name LstBudgetHeader
		/// Description Lists budget header definitions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BUNO">From Budget number</param>
		/// <param name="m3_BVER">From Budget version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBudgetHeaderResponse></returns>
		/// <exception cref="M3Exception<LstBudgetHeaderResponse>"></exception>
		public async Task<M3Response<LstBudgetHeaderResponse>> LstBudgetHeader(
			string m3_DIVI, 
			int? m3_CONO = null, 
			int? m3_BUNO = null, 
			string m3_BVER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBudgetHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_BUNO.HasValue)
				request.WithQueryParameter("BUNO", m3_BUNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BVER))
				request.WithQueryParameter("BVER", m3_BVER.Trim());

			// Execute the request
			var result = await Execute<LstBudgetHeaderResponse>(
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
		/// Name LstBudgetLines
		/// Description Lists budget lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBudgetLinesResponse></returns>
		/// <exception cref="M3Exception<LstBudgetLinesResponse>"></exception>
		public async Task<M3Response<LstBudgetLinesResponse>> LstBudgetLines(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			int? m3_CONO = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			string m3_CUCD = null, 
			int? m3_AMTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBudgetLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());

			// Execute the request
			var result = await Execute<LstBudgetLinesResponse>(
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
		/// Name SelBudPeriod
		/// Description Displays budget per period
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_BUPE">Budget period (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelBudPeriodResponse></returns>
		/// <exception cref="M3Exception<SelBudPeriodResponse>"></exception>
		public async Task<M3Response<SelBudPeriodResponse>> SelBudPeriod(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			string m3_AIT1, 
			string m3_CUCD, 
			int m3_BUPE, 
			int? m3_CONO = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			int? m3_AMTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelBudPeriod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");
			if (string.IsNullOrWhiteSpace(m3_AIT1))
				throw new ArgumentNullException("m3_AIT1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim())
				.WithQueryParameter("AIT1", m3_AIT1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("BUPE", m3_BUPE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());

			// Execute the request
			var result = await Execute<SelBudPeriodResponse>(
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
		/// Name UnlockBudget
		/// Description Unlocks budget header definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UnlockBudget(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UnlockBudget",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name UpdBudgetHeader
		/// Description Updates budget header definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_BSPR">Start period - budget</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_NPAM">Number of periods</param>
		/// <param name="m3_ROPP">Rounding-off category</param>
		/// <param name="m3_UPDB">Update balance file</param>
		/// <param name="m3_DTMP">Allocation template</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBudgetHeader(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			int? m3_CONO = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_BSPR = null, 
			int? m3_CRTP = null, 
			int? m3_NPAM = null, 
			int? m3_ROPP = null, 
			int? m3_UPDB = null, 
			string m3_DTMP = null, 
			string m3_ACGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBudgetHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_BSPR.HasValue)
				request.WithQueryParameter("BSPR", m3_BSPR.Value.ToString());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (m3_NPAM.HasValue)
				request.WithQueryParameter("NPAM", m3_NPAM.Value.ToString());
			if (m3_ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3_ROPP.Value.ToString());
			if (m3_UPDB.HasValue)
				request.WithQueryParameter("UPDB", m3_UPDB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DTMP))
				request.WithQueryParameter("DTMP", m3_DTMP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());

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
		/// Name UpdBudgetLines
		/// Description Updates budget lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="m3_BCUA">Total Foreign currency amount - budget</param>
		/// <param name="m3_BUDQ">Total Budget quantity</param>
		/// <param name="m3_BCU1">Foreign currency amount - budget 1</param>
		/// <param name="m3_BCU2">Foreign currency amount - budget 2</param>
		/// <param name="m3_BCU3">Foreign currency amount - budget 3</param>
		/// <param name="m3_BCU4">Foreign currency amount - budget 4</param>
		/// <param name="m3_BCU5">Foreign currency amount - budget 5</param>
		/// <param name="m3_BCU6">Foreign currency amount - budget 6</param>
		/// <param name="m3_BCU7">Foreign currency amount - budget 7</param>
		/// <param name="m3_BCU8">Foreign currency amount - budget 8</param>
		/// <param name="m3_BCU9">Foreign currency amount - budget 9</param>
		/// <param name="m3_BC10">Foreign currency amount - budget 10</param>
		/// <param name="m3_BC11">Foreign currency amount - budget 11</param>
		/// <param name="m3_BC12">Foreign currency amount - budget 12</param>
		/// <param name="m3_BC13">Foreign currency amount - budget 13</param>
		/// <param name="m3_BC14">Foreign currency amount - budget 14</param>
		/// <param name="m3_BC15">Foreign currency amount - budget 15</param>
		/// <param name="m3_BUD1">Budget quantity 1</param>
		/// <param name="m3_BUD2">Budget quantity 2</param>
		/// <param name="m3_BUD3">Budget quantity 3</param>
		/// <param name="m3_BUD4">Budget quantity 4</param>
		/// <param name="m3_BUD5">Budget quantity 5</param>
		/// <param name="m3_BUD6">Budget quantity 6</param>
		/// <param name="m3_BUD7">Budget quantity 7</param>
		/// <param name="m3_BUD8">Budget quantity 8</param>
		/// <param name="m3_BUD9">Budget quantity 9</param>
		/// <param name="m3_BU10">Budget quantity 10</param>
		/// <param name="m3_BU11">Budget quantity 11</param>
		/// <param name="m3_BU12">Budget quantity 12</param>
		/// <param name="m3_BU13">Budget quantity 13</param>
		/// <param name="m3_BU14">Budget quantity 14</param>
		/// <param name="m3_BU15">Budget quantity 15</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBudgetLines(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			string m3_AIT1, 
			string m3_CUCD, 
			int? m3_CONO = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			int? m3_AMTN = null, 
			decimal? m3_BCUA = null, 
			decimal? m3_BUDQ = null, 
			decimal? m3_BCU1 = null, 
			decimal? m3_BCU2 = null, 
			decimal? m3_BCU3 = null, 
			decimal? m3_BCU4 = null, 
			decimal? m3_BCU5 = null, 
			decimal? m3_BCU6 = null, 
			decimal? m3_BCU7 = null, 
			decimal? m3_BCU8 = null, 
			decimal? m3_BCU9 = null, 
			decimal? m3_BC10 = null, 
			decimal? m3_BC11 = null, 
			decimal? m3_BC12 = null, 
			decimal? m3_BC13 = null, 
			decimal? m3_BC14 = null, 
			decimal? m3_BC15 = null, 
			decimal? m3_BUD1 = null, 
			decimal? m3_BUD2 = null, 
			decimal? m3_BUD3 = null, 
			decimal? m3_BUD4 = null, 
			decimal? m3_BUD5 = null, 
			decimal? m3_BUD6 = null, 
			decimal? m3_BUD7 = null, 
			decimal? m3_BUD8 = null, 
			decimal? m3_BUD9 = null, 
			decimal? m3_BU10 = null, 
			decimal? m3_BU11 = null, 
			decimal? m3_BU12 = null, 
			decimal? m3_BU13 = null, 
			decimal? m3_BU14 = null, 
			decimal? m3_BU15 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBudgetLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");
			if (string.IsNullOrWhiteSpace(m3_AIT1))
				throw new ArgumentNullException("m3_AIT1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim())
				.WithQueryParameter("AIT1", m3_AIT1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());
			if (m3_BCUA.HasValue)
				request.WithQueryParameter("BCUA", m3_BCUA.Value.ToString());
			if (m3_BUDQ.HasValue)
				request.WithQueryParameter("BUDQ", m3_BUDQ.Value.ToString());
			if (m3_BCU1.HasValue)
				request.WithQueryParameter("BCU1", m3_BCU1.Value.ToString());
			if (m3_BCU2.HasValue)
				request.WithQueryParameter("BCU2", m3_BCU2.Value.ToString());
			if (m3_BCU3.HasValue)
				request.WithQueryParameter("BCU3", m3_BCU3.Value.ToString());
			if (m3_BCU4.HasValue)
				request.WithQueryParameter("BCU4", m3_BCU4.Value.ToString());
			if (m3_BCU5.HasValue)
				request.WithQueryParameter("BCU5", m3_BCU5.Value.ToString());
			if (m3_BCU6.HasValue)
				request.WithQueryParameter("BCU6", m3_BCU6.Value.ToString());
			if (m3_BCU7.HasValue)
				request.WithQueryParameter("BCU7", m3_BCU7.Value.ToString());
			if (m3_BCU8.HasValue)
				request.WithQueryParameter("BCU8", m3_BCU8.Value.ToString());
			if (m3_BCU9.HasValue)
				request.WithQueryParameter("BCU9", m3_BCU9.Value.ToString());
			if (m3_BC10.HasValue)
				request.WithQueryParameter("BC10", m3_BC10.Value.ToString());
			if (m3_BC11.HasValue)
				request.WithQueryParameter("BC11", m3_BC11.Value.ToString());
			if (m3_BC12.HasValue)
				request.WithQueryParameter("BC12", m3_BC12.Value.ToString());
			if (m3_BC13.HasValue)
				request.WithQueryParameter("BC13", m3_BC13.Value.ToString());
			if (m3_BC14.HasValue)
				request.WithQueryParameter("BC14", m3_BC14.Value.ToString());
			if (m3_BC15.HasValue)
				request.WithQueryParameter("BC15", m3_BC15.Value.ToString());
			if (m3_BUD1.HasValue)
				request.WithQueryParameter("BUD1", m3_BUD1.Value.ToString());
			if (m3_BUD2.HasValue)
				request.WithQueryParameter("BUD2", m3_BUD2.Value.ToString());
			if (m3_BUD3.HasValue)
				request.WithQueryParameter("BUD3", m3_BUD3.Value.ToString());
			if (m3_BUD4.HasValue)
				request.WithQueryParameter("BUD4", m3_BUD4.Value.ToString());
			if (m3_BUD5.HasValue)
				request.WithQueryParameter("BUD5", m3_BUD5.Value.ToString());
			if (m3_BUD6.HasValue)
				request.WithQueryParameter("BUD6", m3_BUD6.Value.ToString());
			if (m3_BUD7.HasValue)
				request.WithQueryParameter("BUD7", m3_BUD7.Value.ToString());
			if (m3_BUD8.HasValue)
				request.WithQueryParameter("BUD8", m3_BUD8.Value.ToString());
			if (m3_BUD9.HasValue)
				request.WithQueryParameter("BUD9", m3_BUD9.Value.ToString());
			if (m3_BU10.HasValue)
				request.WithQueryParameter("BU10", m3_BU10.Value.ToString());
			if (m3_BU11.HasValue)
				request.WithQueryParameter("BU11", m3_BU11.Value.ToString());
			if (m3_BU12.HasValue)
				request.WithQueryParameter("BU12", m3_BU12.Value.ToString());
			if (m3_BU13.HasValue)
				request.WithQueryParameter("BU13", m3_BU13.Value.ToString());
			if (m3_BU14.HasValue)
				request.WithQueryParameter("BU14", m3_BU14.Value.ToString());
			if (m3_BU15.HasValue)
				request.WithQueryParameter("BU15", m3_BU15.Value.ToString());

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
		/// Name UpdBudgetLnPer
		/// Description Update Budget line per period
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BUNO">Budget number (Required)</param>
		/// <param name="m3_BVER">Budget version (Required)</param>
		/// <param name="m3_AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_BUPE">Budget period (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="m3_AMTN">Curve</param>
		/// <param name="m3_BCUA">Foreign currency amount - budget</param>
		/// <param name="m3_BUDQ">Budget quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBudgetLnPer(
			string m3_DIVI, 
			int m3_BUNO, 
			string m3_BVER, 
			string m3_AIT1, 
			string m3_CUCD, 
			int m3_BUPE, 
			int? m3_CONO = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
			int? m3_AMTN = null, 
			decimal? m3_BCUA = null, 
			decimal? m3_BUDQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBudgetLnPer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BVER))
				throw new ArgumentNullException("m3_BVER");
			if (string.IsNullOrWhiteSpace(m3_AIT1))
				throw new ArgumentNullException("m3_AIT1");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BUNO", m3_BUNO.ToString())
				.WithQueryParameter("BVER", m3_BVER.Trim())
				.WithQueryParameter("AIT1", m3_AIT1.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("BUPE", m3_BUPE.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());
			if (m3_AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3_AMTN.Value.ToString());
			if (m3_BCUA.HasValue)
				request.WithQueryParameter("BCUA", m3_BCUA.Value.ToString());
			if (m3_BUDQ.HasValue)
				request.WithQueryParameter("BUDQ", m3_BUDQ.Value.ToString());

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
