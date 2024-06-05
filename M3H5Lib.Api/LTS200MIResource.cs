/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.LTS200MI;
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
	/// Name: LTS200MI
	/// Component Name: Cust Sales and Serv
	/// Description: Api: LTR Funding
	/// Version Release: 5ea0
	///</summary>
	public partial class LTS200MIResource : M3BaseResourceEndpoint
	{
		public LTS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "LTS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddFundDetail
		/// Description This transaction adds Funding Details
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Serial number (Required)</param>
		/// <param name="m3_NOPR">Number of periods (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_FUPR">Funding price (Required)</param>
		/// <param name="m3_INTT">Interest type (Required)</param>
		/// <param name="m3_FUND">Funder number (Required)</param>
		/// <param name="m3_SBNO">Subnumber</param>
		/// <param name="m3_TX25">Text</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_CMPP">Months/period</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_RESV">Residual value</param>
		/// <param name="m3_REPE">Residual %</param>
		/// <param name="m3_INPE">Interest rate</param>
		/// <param name="m3_RENT">Rent amount</param>
		/// <param name="m3_CINO">Invoice number</param>
		/// <param name="m3_FUAG">Funder agreement number</param>
		/// <param name="m3_INLL">Minimun variable interest rate</param>
		/// <param name="m3_INTH">Interest threshold value</param>
		/// <param name="m3_FFA1">User-defined field 1 alfa</param>
		/// <param name="m3_FFA2">User-defined field 2 alfa</param>
		/// <param name="m3_FFA3">User-defined field 3 alfa</param>
		/// <param name="m3_FFA4">User-defined field 4 alfa</param>
		/// <param name="m3_FFA5">User-defined field 5 alfa</param>
		/// <param name="m3_FFA6">User-defined field 6 alfa</param>
		/// <param name="m3_FFA7">User-defined field 7 alfa</param>
		/// <param name="m3_FFA8">User-defined field 8 alfa</param>
		/// <param name="m3_FFA9">User-defined field 9 alfa</param>
		/// <param name="m3_FFA0">User-defined field 0 alfa</param>
		/// <param name="m3_FFN1">User-defined field 1 numeric</param>
		/// <param name="m3_FFN2">User-defined field 2 numeric</param>
		/// <param name="m3_FFN3">User-defined field 3 numeric</param>
		/// <param name="m3_FFN4">User-defined field 4 numeric</param>
		/// <param name="m3_FFN5">User-defined field 5 numeric</param>
		/// <param name="m3_FFN6">User-defined field 6 numeric</param>
		/// <param name="m3_FFN7">User-defined field 7 numeric</param>
		/// <param name="m3_FFN8">User-defined field 8 numeric</param>
		/// <param name="m3_FFN9">User-defined field 9 numeric</param>
		/// <param name="m3_FFN0">User-defined field 0 numeric</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFundDetail(
			string m3_ITNO, 
			string m3_BANO, 
			int m3_NOPR, 
			DateTime m3_FVDT, 
			decimal m3_FUPR, 
			string m3_INTT, 
			string m3_FUND, 
			int? m3_SBNO = null, 
			string m3_TX25 = null, 
			string m3_STAT = null, 
			int? m3_CMPP = null, 
			string m3_INVM = null, 
			string m3_CUCD = null, 
			decimal? m3_RESV = null, 
			int? m3_REPE = null, 
			decimal? m3_INPE = null, 
			decimal? m3_RENT = null, 
			string m3_CINO = null, 
			string m3_FUAG = null, 
			decimal? m3_INLL = null, 
			int? m3_INTH = null, 
			string m3_FFA1 = null, 
			string m3_FFA2 = null, 
			string m3_FFA3 = null, 
			string m3_FFA4 = null, 
			string m3_FFA5 = null, 
			string m3_FFA6 = null, 
			string m3_FFA7 = null, 
			string m3_FFA8 = null, 
			string m3_FFA9 = null, 
			string m3_FFA0 = null, 
			decimal? m3_FFN1 = null, 
			decimal? m3_FFN2 = null, 
			decimal? m3_FFN3 = null, 
			decimal? m3_FFN4 = null, 
			decimal? m3_FFN5 = null, 
			decimal? m3_FFN6 = null, 
			decimal? m3_FFN7 = null, 
			decimal? m3_FFN8 = null, 
			decimal? m3_FFN9 = null, 
			decimal? m3_FFN0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFundDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");
			if (string.IsNullOrWhiteSpace(m3_INTT))
				throw new ArgumentNullException("m3_INTT");
			if (string.IsNullOrWhiteSpace(m3_FUND))
				throw new ArgumentNullException("m3_FUND");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("NOPR", m3_NOPR.ToString())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("FUPR", m3_FUPR.ToString())
				.WithQueryParameter("INTT", m3_INTT.Trim())
				.WithQueryParameter("FUND", m3_FUND.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3_SBNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX25))
				request.WithQueryParameter("TX25", m3_TX25.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_CMPP.HasValue)
				request.WithQueryParameter("CMPP", m3_CMPP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INVM))
				request.WithQueryParameter("INVM", m3_INVM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_RESV.HasValue)
				request.WithQueryParameter("RESV", m3_RESV.Value.ToString());
			if (m3_REPE.HasValue)
				request.WithQueryParameter("REPE", m3_REPE.Value.ToString());
			if (m3_INPE.HasValue)
				request.WithQueryParameter("INPE", m3_INPE.Value.ToString());
			if (m3_RENT.HasValue)
				request.WithQueryParameter("RENT", m3_RENT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUAG))
				request.WithQueryParameter("FUAG", m3_FUAG.Trim());
			if (m3_INLL.HasValue)
				request.WithQueryParameter("INLL", m3_INLL.Value.ToString());
			if (m3_INTH.HasValue)
				request.WithQueryParameter("INTH", m3_INTH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FFA1))
				request.WithQueryParameter("FFA1", m3_FFA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA2))
				request.WithQueryParameter("FFA2", m3_FFA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA3))
				request.WithQueryParameter("FFA3", m3_FFA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA4))
				request.WithQueryParameter("FFA4", m3_FFA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA5))
				request.WithQueryParameter("FFA5", m3_FFA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA6))
				request.WithQueryParameter("FFA6", m3_FFA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA7))
				request.WithQueryParameter("FFA7", m3_FFA7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA8))
				request.WithQueryParameter("FFA8", m3_FFA8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA9))
				request.WithQueryParameter("FFA9", m3_FFA9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA0))
				request.WithQueryParameter("FFA0", m3_FFA0.Trim());
			if (m3_FFN1.HasValue)
				request.WithQueryParameter("FFN1", m3_FFN1.Value.ToString());
			if (m3_FFN2.HasValue)
				request.WithQueryParameter("FFN2", m3_FFN2.Value.ToString());
			if (m3_FFN3.HasValue)
				request.WithQueryParameter("FFN3", m3_FFN3.Value.ToString());
			if (m3_FFN4.HasValue)
				request.WithQueryParameter("FFN4", m3_FFN4.Value.ToString());
			if (m3_FFN5.HasValue)
				request.WithQueryParameter("FFN5", m3_FFN5.Value.ToString());
			if (m3_FFN6.HasValue)
				request.WithQueryParameter("FFN6", m3_FFN6.Value.ToString());
			if (m3_FFN7.HasValue)
				request.WithQueryParameter("FFN7", m3_FFN7.Value.ToString());
			if (m3_FFN8.HasValue)
				request.WithQueryParameter("FFN8", m3_FFN8.Value.ToString());
			if (m3_FFN9.HasValue)
				request.WithQueryParameter("FFN9", m3_FFN9.Value.ToString());
			if (m3_FFN0.HasValue)
				request.WithQueryParameter("FFN0", m3_FFN0.Value.ToString());

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
		/// Name AddFunding
		/// Description This transaction adds LTR Funding
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFunding(
			string m3_ITNO, 
			string m3_BANO, 
			string m3_FACI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFunding",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim());

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
		/// Name DltFundDetail
		/// Description This transaction deletes Funding Details
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Serial number (Required)</param>
		/// <param name="m3_SBNO">Subnumber (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltFundDetail(
			string m3_ITNO, 
			string m3_BANO, 
			int m3_SBNO, 
			int m3_VERS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltFundDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.ToString())
				.WithQueryParameter("VERS", m3_VERS.ToString());

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
		/// Name DltFunding
		/// Description This transaction deletes Funding
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltFunding(
			string m3_ITNO, 
			string m3_BANO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltFunding",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim());

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
		/// Name GetFundDetail
		/// Description This transaction displays Funding Details
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Serial number (Required)</param>
		/// <param name="m3_SBNO">Subnumber (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFundDetailResponse></returns>
		/// <exception cref="M3Exception<GetFundDetailResponse>"></exception>
		public async Task<M3Response<GetFundDetailResponse>> GetFundDetail(
			string m3_ITNO, 
			string m3_BANO, 
			int m3_SBNO, 
			int m3_VERS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFundDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.ToString())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Execute the request
			var result = await Execute<GetFundDetailResponse>(
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
		/// Name LstFundByAgree
		/// Description This transaction lists Funding By Agreements
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_FUAG">Funder agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFundByAgreeResponse></returns>
		/// <exception cref="M3Exception<LstFundByAgreeResponse>"></exception>
		public async Task<M3Response<LstFundByAgreeResponse>> LstFundByAgree(
			string m3_FACI = null, 
			string m3_FUAG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFundByAgree",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUAG))
				request.WithQueryParameter("FUAG", m3_FUAG.Trim());

			// Execute the request
			var result = await Execute<LstFundByAgreeResponse>(
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
		/// Name LstFundByFunder
		/// Description This transaction lists Funding By Funders
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CUNO">Funder number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFundByFunderResponse></returns>
		/// <exception cref="M3Exception<LstFundByFunderResponse>"></exception>
		public async Task<M3Response<LstFundByFunderResponse>> LstFundByFunder(
			string m3_FACI = null, 
			string m3_CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFundByFunder",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<LstFundByFunderResponse>(
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
		/// Name LstFundByItem
		/// Description This transaction lists Funding By Items
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFundByItemResponse></returns>
		/// <exception cref="M3Exception<LstFundByItemResponse>"></exception>
		public async Task<M3Response<LstFundByItemResponse>> LstFundByItem(
			string m3_ITNO = null, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFundByItem",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<LstFundByItemResponse>(
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
		/// Name LstFundByStatus
		/// Description This transaction lists Funding By Statuses
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFundByStatusResponse></returns>
		/// <exception cref="M3Exception<LstFundByStatusResponse>"></exception>
		public async Task<M3Response<LstFundByStatusResponse>> LstFundByStatus(
			string m3_FACI = null, 
			string m3_STAT = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFundByStatus",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<LstFundByStatusResponse>(
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
		/// Name LstFundDetail
		/// Description This transaction lists Funding Details
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Serial number (Required)</param>
		/// <param name="m3_SBNO">Subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFundDetailResponse></returns>
		/// <exception cref="M3Exception<LstFundDetailResponse>"></exception>
		public async Task<M3Response<LstFundDetailResponse>> LstFundDetail(
			string m3_ITNO, 
			string m3_BANO, 
			int? m3_SBNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFundDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3_SBNO.Value.ToString());

			// Execute the request
			var result = await Execute<LstFundDetailResponse>(
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
		/// Name UpdFundDetail
		/// Description This transaction updates Funding Details
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_BANO">Serial number (Required)</param>
		/// <param name="m3_SBNO">Subnumber (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_NOPR">Number of periods</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_CMPP">Months/period</param>
		/// <param name="m3_INVM">Invoicing method</param>
		/// <param name="m3_RESV">Residual value</param>
		/// <param name="m3_REPE">Residual %</param>
		/// <param name="m3_INTT">Interest type</param>
		/// <param name="m3_INPE">Interest rate</param>
		/// <param name="m3_RENT">Rent amount</param>
		/// <param name="m3_FUND">Funder number</param>
		/// <param name="m3_CINO">Invoice number</param>
		/// <param name="m3_FUAG">Funder agreement number</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_INLL">Minimum variable interest rate</param>
		/// <param name="m3_INTH">Interest threshold value</param>
		/// <param name="m3_FFA1">User-defined field 1 alfa</param>
		/// <param name="m3_FFA2">User-defined field 2 alfa</param>
		/// <param name="m3_FFA3">User-defined field 3 alfa</param>
		/// <param name="m3_FFA4">User-defined field 4 alfa</param>
		/// <param name="m3_FFA5">User-defined field 5 alfa</param>
		/// <param name="m3_FFA6">User-defined field 6 alfa</param>
		/// <param name="m3_FFA7">User-defined field 7 alfa</param>
		/// <param name="m3_FFA8">User-defined field 8 alfa</param>
		/// <param name="m3_FFA9">User-defined field 9 alfa</param>
		/// <param name="m3_FFA0">User-defined field 10 alfa</param>
		/// <param name="m3_FFN1">User-defined field 1 numeric</param>
		/// <param name="m3_FFN2">User-defined field 2 numeric</param>
		/// <param name="m3_FFN3">User-defined field 3 numeric</param>
		/// <param name="m3_FFN4">User-defined field 4 numeric</param>
		/// <param name="m3_FFN5">User-defined field 5 numeric</param>
		/// <param name="m3_FFN6">User-defined field 6 numeric</param>
		/// <param name="m3_FFN7">User-defined field 7 numeric</param>
		/// <param name="m3_FFN8">User-defined field 8 numeric</param>
		/// <param name="m3_FFN9">User-defined field 9 numeric</param>
		/// <param name="m3_FFN0">User-defined field 10 numeric</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdFundDetail(
			string m3_ITNO, 
			string m3_BANO, 
			int m3_SBNO, 
			int m3_VERS, 
			string m3_STAT = null, 
			int? m3_NOPR = null, 
			DateTime? m3_FVDT = null, 
			int? m3_CMPP = null, 
			string m3_INVM = null, 
			decimal? m3_RESV = null, 
			int? m3_REPE = null, 
			string m3_INTT = null, 
			decimal? m3_INPE = null, 
			decimal? m3_RENT = null, 
			string m3_FUND = null, 
			string m3_CINO = null, 
			string m3_FUAG = null, 
			string m3_CUCD = null, 
			decimal? m3_INLL = null, 
			int? m3_INTH = null, 
			string m3_FFA1 = null, 
			string m3_FFA2 = null, 
			string m3_FFA3 = null, 
			string m3_FFA4 = null, 
			string m3_FFA5 = null, 
			string m3_FFA6 = null, 
			string m3_FFA7 = null, 
			string m3_FFA8 = null, 
			string m3_FFA9 = null, 
			string m3_FFA0 = null, 
			decimal? m3_FFN1 = null, 
			decimal? m3_FFN2 = null, 
			decimal? m3_FFN3 = null, 
			decimal? m3_FFN4 = null, 
			decimal? m3_FFN5 = null, 
			decimal? m3_FFN6 = null, 
			decimal? m3_FFN7 = null, 
			decimal? m3_FFN8 = null, 
			decimal? m3_FFN9 = null, 
			decimal? m3_FFN0 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdFundDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("SBNO", m3_SBNO.ToString())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_NOPR.HasValue)
				request.WithQueryParameter("NOPR", m3_NOPR.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_CMPP.HasValue)
				request.WithQueryParameter("CMPP", m3_CMPP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INVM))
				request.WithQueryParameter("INVM", m3_INVM.Trim());
			if (m3_RESV.HasValue)
				request.WithQueryParameter("RESV", m3_RESV.Value.ToString());
			if (m3_REPE.HasValue)
				request.WithQueryParameter("REPE", m3_REPE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INTT))
				request.WithQueryParameter("INTT", m3_INTT.Trim());
			if (m3_INPE.HasValue)
				request.WithQueryParameter("INPE", m3_INPE.Value.ToString());
			if (m3_RENT.HasValue)
				request.WithQueryParameter("RENT", m3_RENT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FUND))
				request.WithQueryParameter("FUND", m3_FUND.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CINO))
				request.WithQueryParameter("CINO", m3_CINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUAG))
				request.WithQueryParameter("FUAG", m3_FUAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_INLL.HasValue)
				request.WithQueryParameter("INLL", m3_INLL.Value.ToString());
			if (m3_INTH.HasValue)
				request.WithQueryParameter("INTH", m3_INTH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FFA1))
				request.WithQueryParameter("FFA1", m3_FFA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA2))
				request.WithQueryParameter("FFA2", m3_FFA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA3))
				request.WithQueryParameter("FFA3", m3_FFA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA4))
				request.WithQueryParameter("FFA4", m3_FFA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA5))
				request.WithQueryParameter("FFA5", m3_FFA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA6))
				request.WithQueryParameter("FFA6", m3_FFA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA7))
				request.WithQueryParameter("FFA7", m3_FFA7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA8))
				request.WithQueryParameter("FFA8", m3_FFA8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA9))
				request.WithQueryParameter("FFA9", m3_FFA9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFA0))
				request.WithQueryParameter("FFA0", m3_FFA0.Trim());
			if (m3_FFN1.HasValue)
				request.WithQueryParameter("FFN1", m3_FFN1.Value.ToString());
			if (m3_FFN2.HasValue)
				request.WithQueryParameter("FFN2", m3_FFN2.Value.ToString());
			if (m3_FFN3.HasValue)
				request.WithQueryParameter("FFN3", m3_FFN3.Value.ToString());
			if (m3_FFN4.HasValue)
				request.WithQueryParameter("FFN4", m3_FFN4.Value.ToString());
			if (m3_FFN5.HasValue)
				request.WithQueryParameter("FFN5", m3_FFN5.Value.ToString());
			if (m3_FFN6.HasValue)
				request.WithQueryParameter("FFN6", m3_FFN6.Value.ToString());
			if (m3_FFN7.HasValue)
				request.WithQueryParameter("FFN7", m3_FFN7.Value.ToString());
			if (m3_FFN8.HasValue)
				request.WithQueryParameter("FFN8", m3_FFN8.Value.ToString());
			if (m3_FFN9.HasValue)
				request.WithQueryParameter("FFN9", m3_FFN9.Value.ToString());
			if (m3_FFN0.HasValue)
				request.WithQueryParameter("FFN0", m3_FFN0.Value.ToString());

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
