/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBudgetHeader
		/// Description Adds budget header definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3BSPR">Start period - budget (Required)</param>
		/// <param name="m3CRTP">Exchange rate type (Required)</param>
		/// <param name="m3NPAM">Number of periods (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3ROPP">Rounding-off category</param>
		/// <param name="m3UPDB">Update balance file</param>
		/// <param name="m3DTMP">Allocation template</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBudgetHeader(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			string m3TX40, 
			int m3BSPR, 
			int m3CRTP, 
			int m3NPAM, 
			int? m3CONO = null, 
			string m3TX15 = null, 
			int? m3ROPP = null, 
			int? m3UPDB = null, 
			string m3DTMP = null, 
			string m3ACGR = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBudgetHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("BSPR", m3BSPR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CRTP", m3CRTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("NPAM", m3NPAM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3ROPP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPDB.HasValue)
				request.WithQueryParameter("UPDB", m3UPDB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DTMP))
				request.WithQueryParameter("DTMP", m3DTMP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());

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
		/// Name AddBudgetLines
		/// Description Adds budget lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="m3BCUA">Total Foreign currency amount - budget</param>
		/// <param name="m3BUDQ">Total Budget quantity</param>
		/// <param name="m3BCU1">Foreign currency amount - budget 1</param>
		/// <param name="m3BCU2">Foreign currency amount - budget 2</param>
		/// <param name="m3BCU3">Foreign currency amount - budget 3</param>
		/// <param name="m3BCU4">Foreign currency amount - budget 4</param>
		/// <param name="m3BCU5">Foreign currency amount - budget 5</param>
		/// <param name="m3BCU6">Foreign currency amount - budget 6</param>
		/// <param name="m3BCU7">Foreign currency amount - budget 7</param>
		/// <param name="m3BCU8">Foreign currency amount - budget 8</param>
		/// <param name="m3BCU9">Foreign currency amount - budget 9</param>
		/// <param name="m3BC10">Foreign currency amount - budget 10</param>
		/// <param name="m3BC11">Foreign currency amount - budget 11</param>
		/// <param name="m3BC12">Foreign currency amount - budget 12</param>
		/// <param name="m3BC13">Foreign currency amount - budget 13</param>
		/// <param name="m3BC14">Foreign currency amount - budget 14</param>
		/// <param name="m3BC15">Foreign currency amount - budget 15</param>
		/// <param name="m3BUD1">Budget quantity 1</param>
		/// <param name="m3BUD2">Budget quantity 2</param>
		/// <param name="m3BUD3">Budget quantity 3</param>
		/// <param name="m3BUD4">Budget quantity 4</param>
		/// <param name="m3BUD5">Budget quantity 5</param>
		/// <param name="m3BUD6">Budget quantity 6</param>
		/// <param name="m3BUD7">Budget quantity 7</param>
		/// <param name="m3BUD8">Budget quantity 8</param>
		/// <param name="m3BUD9">Budget quantity 9</param>
		/// <param name="m3BU10">Budget quantity 10</param>
		/// <param name="m3BU11">Budget quantity 11</param>
		/// <param name="m3BU12">Budget quantity 12</param>
		/// <param name="m3BU13">Budget quantity 13</param>
		/// <param name="m3BU14">Budget quantity 14</param>
		/// <param name="m3BU15">Budget quantity 15</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBudgetLines(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			string m3AIT1, 
			string m3CUCD, 
			int? m3CONO = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			int? m3AMTN = null, 
			decimal? m3BCUA = null, 
			decimal? m3BUDQ = null, 
			decimal? m3BCU1 = null, 
			decimal? m3BCU2 = null, 
			decimal? m3BCU3 = null, 
			decimal? m3BCU4 = null, 
			decimal? m3BCU5 = null, 
			decimal? m3BCU6 = null, 
			decimal? m3BCU7 = null, 
			decimal? m3BCU8 = null, 
			decimal? m3BCU9 = null, 
			decimal? m3BC10 = null, 
			decimal? m3BC11 = null, 
			decimal? m3BC12 = null, 
			decimal? m3BC13 = null, 
			decimal? m3BC14 = null, 
			decimal? m3BC15 = null, 
			decimal? m3BUD1 = null, 
			decimal? m3BUD2 = null, 
			decimal? m3BUD3 = null, 
			decimal? m3BUD4 = null, 
			decimal? m3BUD5 = null, 
			decimal? m3BUD6 = null, 
			decimal? m3BUD7 = null, 
			decimal? m3BUD8 = null, 
			decimal? m3BUD9 = null, 
			decimal? m3BU10 = null, 
			decimal? m3BU11 = null, 
			decimal? m3BU12 = null, 
			decimal? m3BU13 = null, 
			decimal? m3BU14 = null, 
			decimal? m3BU15 = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBudgetLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));
			if (string.IsNullOrWhiteSpace(m3AIT1))
				throw new ArgumentNullException(nameof(m3AIT1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim())
				.WithQueryParameter("AIT1", m3AIT1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCUA.HasValue)
				request.WithQueryParameter("BCUA", m3BCUA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUDQ.HasValue)
				request.WithQueryParameter("BUDQ", m3BUDQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU1.HasValue)
				request.WithQueryParameter("BCU1", m3BCU1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU2.HasValue)
				request.WithQueryParameter("BCU2", m3BCU2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU3.HasValue)
				request.WithQueryParameter("BCU3", m3BCU3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU4.HasValue)
				request.WithQueryParameter("BCU4", m3BCU4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU5.HasValue)
				request.WithQueryParameter("BCU5", m3BCU5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU6.HasValue)
				request.WithQueryParameter("BCU6", m3BCU6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU7.HasValue)
				request.WithQueryParameter("BCU7", m3BCU7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU8.HasValue)
				request.WithQueryParameter("BCU8", m3BCU8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU9.HasValue)
				request.WithQueryParameter("BCU9", m3BCU9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BC10.HasValue)
				request.WithQueryParameter("BC10", m3BC10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BC11.HasValue)
				request.WithQueryParameter("BC11", m3BC11.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BC12.HasValue)
				request.WithQueryParameter("BC12", m3BC12.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BC13.HasValue)
				request.WithQueryParameter("BC13", m3BC13.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BC14.HasValue)
				request.WithQueryParameter("BC14", m3BC14.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BC15.HasValue)
				request.WithQueryParameter("BC15", m3BC15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD1.HasValue)
				request.WithQueryParameter("BUD1", m3BUD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD2.HasValue)
				request.WithQueryParameter("BUD2", m3BUD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD3.HasValue)
				request.WithQueryParameter("BUD3", m3BUD3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD4.HasValue)
				request.WithQueryParameter("BUD4", m3BUD4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD5.HasValue)
				request.WithQueryParameter("BUD5", m3BUD5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD6.HasValue)
				request.WithQueryParameter("BUD6", m3BUD6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD7.HasValue)
				request.WithQueryParameter("BUD7", m3BUD7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD8.HasValue)
				request.WithQueryParameter("BUD8", m3BUD8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD9.HasValue)
				request.WithQueryParameter("BUD9", m3BUD9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BU10.HasValue)
				request.WithQueryParameter("BU10", m3BU10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BU11.HasValue)
				request.WithQueryParameter("BU11", m3BU11.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BU12.HasValue)
				request.WithQueryParameter("BU12", m3BU12.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BU13.HasValue)
				request.WithQueryParameter("BU13", m3BU13.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BU14.HasValue)
				request.WithQueryParameter("BU14", m3BU14.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BU15.HasValue)
				request.WithQueryParameter("BU15", m3BU15.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddBudgetLnPer
		/// Description Add Budget line per period
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3BUPE">Budget period (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="m3BCUA">Foreign currency amount - budget</param>
		/// <param name="m3BUDQ">Budget quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBudgetLnPer(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			string m3AIT1, 
			string m3CUCD, 
			int m3BUPE, 
			int? m3CONO = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			int? m3AMTN = null, 
			decimal? m3BCUA = null, 
			decimal? m3BUDQ = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBudgetLnPer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));
			if (string.IsNullOrWhiteSpace(m3AIT1))
				throw new ArgumentNullException(nameof(m3AIT1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim())
				.WithQueryParameter("AIT1", m3AIT1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("BUPE", m3BUPE.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCUA.HasValue)
				request.WithQueryParameter("BCUA", m3BCUA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUDQ.HasValue)
				request.WithQueryParameter("BUDQ", m3BUDQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelBudgetHeader
		/// Description Deletes budget header definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBudgetHeader(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelBudgetHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelBudgetLines
		/// Description Deletes budget lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BUPE">Budget period</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBudgetLines(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			string m3AIT1, 
			string m3CUCD, 
			int? m3CONO = null, 
			int? m3BUPE = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			int? m3AMTN = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelBudgetLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));
			if (string.IsNullOrWhiteSpace(m3AIT1))
				throw new ArgumentNullException(nameof(m3AIT1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim())
				.WithQueryParameter("AIT1", m3AIT1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUPE.HasValue)
				request.WithQueryParameter("BUPE", m3BUPE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DspBudgetValues
		/// Description Displays Budget values
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3PERF">FromBudget period (Required)</param>
		/// <param name="m3PERT">To Budget period (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FIT1">From Accounting dimension 1</param>
		/// <param name="m3TIT1">To Accounting dimension 1</param>
		/// <param name="m3FIT2">From Accounting dimension 2</param>
		/// <param name="m3TIT2">To Accounting dimension 2</param>
		/// <param name="m3FIT3">From Accounting dimension 3</param>
		/// <param name="m3TIT3">To Accounting dimension 3</param>
		/// <param name="m3FIT4">From Accounting dimension 4</param>
		/// <param name="m3TIT4">To Accounting dimension 4</param>
		/// <param name="m3FIT5">From Accounting dimension 5</param>
		/// <param name="m3TIT5">To Accounting dimension 5</param>
		/// <param name="m3FIT6">From Accounting dimension 6</param>
		/// <param name="m3TIT6">To Accounting dimension 6</param>
		/// <param name="m3FIT7">From Accounting dimension 7</param>
		/// <param name="m3TIT7">To Accounting dimension 7</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DspBudgetValuesResponse></returns>
		/// <exception cref="M3Exception<DspBudgetValuesResponse>"></exception>
		public async Task<M3Response<DspBudgetValuesResponse>> DspBudgetValues(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			int m3PERF, 
			int m3PERT, 
			int? m3CONO = null, 
			string m3FIT1 = null, 
			string m3TIT1 = null, 
			string m3FIT2 = null, 
			string m3TIT2 = null, 
			string m3FIT3 = null, 
			string m3TIT3 = null, 
			string m3FIT4 = null, 
			string m3TIT4 = null, 
			string m3FIT5 = null, 
			string m3TIT5 = null, 
			string m3FIT6 = null, 
			string m3TIT6 = null, 
			string m3FIT7 = null, 
			string m3TIT7 = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DspBudgetValues",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim())
				.WithQueryParameter("PERF", m3PERF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PERT", m3PERT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FIT1))
				request.WithQueryParameter("FIT1", m3FIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT1))
				request.WithQueryParameter("TIT1", m3TIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT2))
				request.WithQueryParameter("FIT2", m3FIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT2))
				request.WithQueryParameter("TIT2", m3TIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT3))
				request.WithQueryParameter("FIT3", m3FIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT3))
				request.WithQueryParameter("TIT3", m3TIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT4))
				request.WithQueryParameter("FIT4", m3FIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT4))
				request.WithQueryParameter("TIT4", m3TIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT5))
				request.WithQueryParameter("FIT5", m3FIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT5))
				request.WithQueryParameter("TIT5", m3TIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT6))
				request.WithQueryParameter("FIT6", m3FIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT6))
				request.WithQueryParameter("TIT6", m3TIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIT7))
				request.WithQueryParameter("FIT7", m3FIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIT7))
				request.WithQueryParameter("TIT7", m3TIT7.Trim());

			// Execute the request
			var result = await Execute<DspBudgetValuesResponse>(
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
		/// Name GetBudPerPeriod
		/// Description Displays budget per period
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3BUPE">Budget period (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBudPerPeriodResponse></returns>
		/// <exception cref="M3Exception<GetBudPerPeriodResponse>"></exception>
		public async Task<M3Response<GetBudPerPeriodResponse>> GetBudPerPeriod(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			string m3AIT1, 
			string m3CUCD, 
			int m3BUPE, 
			int? m3CONO = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			int? m3AMTN = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBudPerPeriod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));
			if (string.IsNullOrWhiteSpace(m3AIT1))
				throw new ArgumentNullException(nameof(m3AIT1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim())
				.WithQueryParameter("AIT1", m3AIT1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("BUPE", m3BUPE.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBudPerPeriodResponse>(
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
		/// Name GetBudgetHeader
		/// Description Displays budget header definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBudgetHeaderResponse></returns>
		/// <exception cref="M3Exception<GetBudgetHeaderResponse>"></exception>
		public async Task<M3Response<GetBudgetHeaderResponse>> GetBudgetHeader(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBudgetHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBudgetHeaderResponse>(
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
		/// Name LockBudget
		/// Description Locks budget header definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> LockBudget(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LockBudget",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name LstBudPeriodVal
		/// Description Lists budget periodic values
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="m3BUPE">Budget period</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBudPeriodValResponse></returns>
		/// <exception cref="M3Exception<LstBudPeriodValResponse>"></exception>
		public async Task<M3Response<LstBudPeriodValResponse>> LstBudPeriodVal(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			int? m3CONO = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3CUCD = null, 
			int? m3AMTN = null, 
			int? m3BUPE = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBudPeriodVal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUPE.HasValue)
				request.WithQueryParameter("BUPE", m3BUPE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstBudPeriodValResponse>(
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
		/// Name LstBudgetHeader
		/// Description Lists budget header definitions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BUNO">From Budget number</param>
		/// <param name="m3BVER">From Budget version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBudgetHeaderResponse></returns>
		/// <exception cref="M3Exception<LstBudgetHeaderResponse>"></exception>
		public async Task<M3Response<LstBudgetHeaderResponse>> LstBudgetHeader(
			string m3DIVI, 
			int? m3CONO = null, 
			int? m3BUNO = null, 
			string m3BVER = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBudgetHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUNO.HasValue)
				request.WithQueryParameter("BUNO", m3BUNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BVER))
				request.WithQueryParameter("BVER", m3BVER.Trim());

			// Execute the request
			var result = await Execute<LstBudgetHeaderResponse>(
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
		/// Name LstBudgetLines
		/// Description Lists budget lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBudgetLinesResponse></returns>
		/// <exception cref="M3Exception<LstBudgetLinesResponse>"></exception>
		public async Task<M3Response<LstBudgetLinesResponse>> LstBudgetLines(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			int? m3CONO = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3CUCD = null, 
			int? m3AMTN = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBudgetLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstBudgetLinesResponse>(
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
		/// Name SelBudPeriod
		/// Description Displays budget per period
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3BUPE">Budget period (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelBudPeriodResponse></returns>
		/// <exception cref="M3Exception<SelBudPeriodResponse>"></exception>
		public async Task<M3Response<SelBudPeriodResponse>> SelBudPeriod(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			string m3AIT1, 
			string m3CUCD, 
			int m3BUPE, 
			int? m3CONO = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			int? m3AMTN = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelBudPeriod",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));
			if (string.IsNullOrWhiteSpace(m3AIT1))
				throw new ArgumentNullException(nameof(m3AIT1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim())
				.WithQueryParameter("AIT1", m3AIT1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("BUPE", m3BUPE.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelBudPeriodResponse>(
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
		/// Name UnlockBudget
		/// Description Unlocks budget header definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UnlockBudget(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			int? m3CONO = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UnlockBudget",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdBudgetHeader
		/// Description Updates budget header definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3BSPR">Start period - budget</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3NPAM">Number of periods</param>
		/// <param name="m3ROPP">Rounding-off category</param>
		/// <param name="m3UPDB">Update balance file</param>
		/// <param name="m3DTMP">Allocation template</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBudgetHeader(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			int? m3CONO = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3BSPR = null, 
			int? m3CRTP = null, 
			int? m3NPAM = null, 
			int? m3ROPP = null, 
			int? m3UPDB = null, 
			string m3DTMP = null, 
			string m3ACGR = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdBudgetHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3BSPR.HasValue)
				request.WithQueryParameter("BSPR", m3BSPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NPAM.HasValue)
				request.WithQueryParameter("NPAM", m3NPAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3ROPP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPDB.HasValue)
				request.WithQueryParameter("UPDB", m3UPDB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DTMP))
				request.WithQueryParameter("DTMP", m3DTMP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());

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
		/// Name UpdBudgetLines
		/// Description Updates budget lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="m3BCUA">Total Foreign currency amount - budget</param>
		/// <param name="m3BUDQ">Total Budget quantity</param>
		/// <param name="m3BCU1">Foreign currency amount - budget 1</param>
		/// <param name="m3BCU2">Foreign currency amount - budget 2</param>
		/// <param name="m3BCU3">Foreign currency amount - budget 3</param>
		/// <param name="m3BCU4">Foreign currency amount - budget 4</param>
		/// <param name="m3BCU5">Foreign currency amount - budget 5</param>
		/// <param name="m3BCU6">Foreign currency amount - budget 6</param>
		/// <param name="m3BCU7">Foreign currency amount - budget 7</param>
		/// <param name="m3BCU8">Foreign currency amount - budget 8</param>
		/// <param name="m3BCU9">Foreign currency amount - budget 9</param>
		/// <param name="m3BC10">Foreign currency amount - budget 10</param>
		/// <param name="m3BC11">Foreign currency amount - budget 11</param>
		/// <param name="m3BC12">Foreign currency amount - budget 12</param>
		/// <param name="m3BC13">Foreign currency amount - budget 13</param>
		/// <param name="m3BC14">Foreign currency amount - budget 14</param>
		/// <param name="m3BC15">Foreign currency amount - budget 15</param>
		/// <param name="m3BUD1">Budget quantity 1</param>
		/// <param name="m3BUD2">Budget quantity 2</param>
		/// <param name="m3BUD3">Budget quantity 3</param>
		/// <param name="m3BUD4">Budget quantity 4</param>
		/// <param name="m3BUD5">Budget quantity 5</param>
		/// <param name="m3BUD6">Budget quantity 6</param>
		/// <param name="m3BUD7">Budget quantity 7</param>
		/// <param name="m3BUD8">Budget quantity 8</param>
		/// <param name="m3BUD9">Budget quantity 9</param>
		/// <param name="m3BU10">Budget quantity 10</param>
		/// <param name="m3BU11">Budget quantity 11</param>
		/// <param name="m3BU12">Budget quantity 12</param>
		/// <param name="m3BU13">Budget quantity 13</param>
		/// <param name="m3BU14">Budget quantity 14</param>
		/// <param name="m3BU15">Budget quantity 15</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBudgetLines(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			string m3AIT1, 
			string m3CUCD, 
			int? m3CONO = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			int? m3AMTN = null, 
			decimal? m3BCUA = null, 
			decimal? m3BUDQ = null, 
			decimal? m3BCU1 = null, 
			decimal? m3BCU2 = null, 
			decimal? m3BCU3 = null, 
			decimal? m3BCU4 = null, 
			decimal? m3BCU5 = null, 
			decimal? m3BCU6 = null, 
			decimal? m3BCU7 = null, 
			decimal? m3BCU8 = null, 
			decimal? m3BCU9 = null, 
			decimal? m3BC10 = null, 
			decimal? m3BC11 = null, 
			decimal? m3BC12 = null, 
			decimal? m3BC13 = null, 
			decimal? m3BC14 = null, 
			decimal? m3BC15 = null, 
			decimal? m3BUD1 = null, 
			decimal? m3BUD2 = null, 
			decimal? m3BUD3 = null, 
			decimal? m3BUD4 = null, 
			decimal? m3BUD5 = null, 
			decimal? m3BUD6 = null, 
			decimal? m3BUD7 = null, 
			decimal? m3BUD8 = null, 
			decimal? m3BUD9 = null, 
			decimal? m3BU10 = null, 
			decimal? m3BU11 = null, 
			decimal? m3BU12 = null, 
			decimal? m3BU13 = null, 
			decimal? m3BU14 = null, 
			decimal? m3BU15 = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdBudgetLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));
			if (string.IsNullOrWhiteSpace(m3AIT1))
				throw new ArgumentNullException(nameof(m3AIT1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim())
				.WithQueryParameter("AIT1", m3AIT1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCUA.HasValue)
				request.WithQueryParameter("BCUA", m3BCUA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUDQ.HasValue)
				request.WithQueryParameter("BUDQ", m3BUDQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU1.HasValue)
				request.WithQueryParameter("BCU1", m3BCU1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU2.HasValue)
				request.WithQueryParameter("BCU2", m3BCU2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU3.HasValue)
				request.WithQueryParameter("BCU3", m3BCU3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU4.HasValue)
				request.WithQueryParameter("BCU4", m3BCU4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU5.HasValue)
				request.WithQueryParameter("BCU5", m3BCU5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU6.HasValue)
				request.WithQueryParameter("BCU6", m3BCU6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU7.HasValue)
				request.WithQueryParameter("BCU7", m3BCU7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU8.HasValue)
				request.WithQueryParameter("BCU8", m3BCU8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCU9.HasValue)
				request.WithQueryParameter("BCU9", m3BCU9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BC10.HasValue)
				request.WithQueryParameter("BC10", m3BC10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BC11.HasValue)
				request.WithQueryParameter("BC11", m3BC11.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BC12.HasValue)
				request.WithQueryParameter("BC12", m3BC12.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BC13.HasValue)
				request.WithQueryParameter("BC13", m3BC13.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BC14.HasValue)
				request.WithQueryParameter("BC14", m3BC14.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BC15.HasValue)
				request.WithQueryParameter("BC15", m3BC15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD1.HasValue)
				request.WithQueryParameter("BUD1", m3BUD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD2.HasValue)
				request.WithQueryParameter("BUD2", m3BUD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD3.HasValue)
				request.WithQueryParameter("BUD3", m3BUD3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD4.HasValue)
				request.WithQueryParameter("BUD4", m3BUD4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD5.HasValue)
				request.WithQueryParameter("BUD5", m3BUD5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD6.HasValue)
				request.WithQueryParameter("BUD6", m3BUD6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD7.HasValue)
				request.WithQueryParameter("BUD7", m3BUD7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD8.HasValue)
				request.WithQueryParameter("BUD8", m3BUD8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUD9.HasValue)
				request.WithQueryParameter("BUD9", m3BUD9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BU10.HasValue)
				request.WithQueryParameter("BU10", m3BU10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BU11.HasValue)
				request.WithQueryParameter("BU11", m3BU11.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BU12.HasValue)
				request.WithQueryParameter("BU12", m3BU12.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BU13.HasValue)
				request.WithQueryParameter("BU13", m3BU13.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BU14.HasValue)
				request.WithQueryParameter("BU14", m3BU14.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BU15.HasValue)
				request.WithQueryParameter("BU15", m3BU15.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdBudgetLnPer
		/// Description Update Budget line per period
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BUNO">Budget number (Required)</param>
		/// <param name="m3BVER">Budget version (Required)</param>
		/// <param name="m3AIT1">Accounting dimension 1 (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3BUPE">Budget period (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3AMTN">Curve</param>
		/// <param name="m3BCUA">Foreign currency amount - budget</param>
		/// <param name="m3BUDQ">Budget quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBudgetLnPer(
			string m3DIVI, 
			int m3BUNO, 
			string m3BVER, 
			string m3AIT1, 
			string m3CUCD, 
			int m3BUPE, 
			int? m3CONO = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			int? m3AMTN = null, 
			decimal? m3BCUA = null, 
			decimal? m3BUDQ = null, 
			int? maxRecords = null, 
			bool? includeMetadata = null, 
			bool? trimResults = null, 
			IEnumerable<string> outputColumns = null, 
			bool? throwExceptionWithoutSuccess = null, 
			CancellationToken cancellationToken = default)
		{
			await new ContextRemover();
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdBudgetLnPer",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BVER))
				throw new ArgumentNullException(nameof(m3BVER));
			if (string.IsNullOrWhiteSpace(m3AIT1))
				throw new ArgumentNullException(nameof(m3AIT1));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BUNO", m3BUNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("BVER", m3BVER.Trim())
				.WithQueryParameter("AIT1", m3AIT1.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("BUPE", m3BUPE.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (m3AMTN.HasValue)
				request.WithQueryParameter("AMTN", m3AMTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCUA.HasValue)
				request.WithQueryParameter("BCUA", m3BCUA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUDQ.HasValue)
				request.WithQueryParameter("BUDQ", m3BUDQ.Value.ToString(CultureInfo.CurrentCulture));

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
	}
}
// EOF
