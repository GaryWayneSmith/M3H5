/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Serial number (Required)</param>
		/// <param name="m3NOPR">Number of periods (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3FUPR">Funding price (Required)</param>
		/// <param name="m3INTT">Interest type (Required)</param>
		/// <param name="m3FUND">Funder number (Required)</param>
		/// <param name="m3SBNO">Subnumber</param>
		/// <param name="m3TX25">Text</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3CMPP">Months/period</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3RESV">Residual value</param>
		/// <param name="m3REPE">Residual %</param>
		/// <param name="m3INPE">Interest rate</param>
		/// <param name="m3RENT">Rent amount</param>
		/// <param name="m3CINO">Invoice number</param>
		/// <param name="m3FUAG">Funder agreement number</param>
		/// <param name="m3INLL">Minimun variable interest rate</param>
		/// <param name="m3INTH">Interest threshold value</param>
		/// <param name="m3FFA1">User-defined field 1 alfa</param>
		/// <param name="m3FFA2">User-defined field 2 alfa</param>
		/// <param name="m3FFA3">User-defined field 3 alfa</param>
		/// <param name="m3FFA4">User-defined field 4 alfa</param>
		/// <param name="m3FFA5">User-defined field 5 alfa</param>
		/// <param name="m3FFA6">User-defined field 6 alfa</param>
		/// <param name="m3FFA7">User-defined field 7 alfa</param>
		/// <param name="m3FFA8">User-defined field 8 alfa</param>
		/// <param name="m3FFA9">User-defined field 9 alfa</param>
		/// <param name="m3FFA0">User-defined field 0 alfa</param>
		/// <param name="m3FFN1">User-defined field 1 numeric</param>
		/// <param name="m3FFN2">User-defined field 2 numeric</param>
		/// <param name="m3FFN3">User-defined field 3 numeric</param>
		/// <param name="m3FFN4">User-defined field 4 numeric</param>
		/// <param name="m3FFN5">User-defined field 5 numeric</param>
		/// <param name="m3FFN6">User-defined field 6 numeric</param>
		/// <param name="m3FFN7">User-defined field 7 numeric</param>
		/// <param name="m3FFN8">User-defined field 8 numeric</param>
		/// <param name="m3FFN9">User-defined field 9 numeric</param>
		/// <param name="m3FFN0">User-defined field 0 numeric</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFundDetail(
			string m3ITNO, 
			string m3BANO, 
			int m3NOPR, 
			DateTime m3FVDT, 
			decimal m3FUPR, 
			string m3INTT, 
			string m3FUND, 
			int? m3SBNO = null, 
			string m3TX25 = null, 
			string m3STAT = null, 
			int? m3CMPP = null, 
			string m3INVM = null, 
			string m3CUCD = null, 
			decimal? m3RESV = null, 
			int? m3REPE = null, 
			decimal? m3INPE = null, 
			decimal? m3RENT = null, 
			string m3CINO = null, 
			string m3FUAG = null, 
			decimal? m3INLL = null, 
			int? m3INTH = null, 
			string m3FFA1 = null, 
			string m3FFA2 = null, 
			string m3FFA3 = null, 
			string m3FFA4 = null, 
			string m3FFA5 = null, 
			string m3FFA6 = null, 
			string m3FFA7 = null, 
			string m3FFA8 = null, 
			string m3FFA9 = null, 
			string m3FFA0 = null, 
			decimal? m3FFN1 = null, 
			decimal? m3FFN2 = null, 
			decimal? m3FFN3 = null, 
			decimal? m3FFN4 = null, 
			decimal? m3FFN5 = null, 
			decimal? m3FFN6 = null, 
			decimal? m3FFN7 = null, 
			decimal? m3FFN8 = null, 
			decimal? m3FFN9 = null, 
			decimal? m3FFN0 = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));
			if (string.IsNullOrWhiteSpace(m3INTT))
				throw new ArgumentNullException(nameof(m3INTT));
			if (string.IsNullOrWhiteSpace(m3FUND))
				throw new ArgumentNullException(nameof(m3FUND));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim())
				.WithQueryParameter("NOPR", m3NOPR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("FUPR", m3FUPR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("INTT", m3INTT.Trim())
				.WithQueryParameter("FUND", m3FUND.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3SBNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX25))
				request.WithQueryParameter("TX25", m3TX25.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3CMPP.HasValue)
				request.WithQueryParameter("CMPP", m3CMPP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3RESV.HasValue)
				request.WithQueryParameter("RESV", m3RESV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPE.HasValue)
				request.WithQueryParameter("REPE", m3REPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INPE.HasValue)
				request.WithQueryParameter("INPE", m3INPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENT.HasValue)
				request.WithQueryParameter("RENT", m3RENT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CINO))
				request.WithQueryParameter("CINO", m3CINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUAG))
				request.WithQueryParameter("FUAG", m3FUAG.Trim());
			if (m3INLL.HasValue)
				request.WithQueryParameter("INLL", m3INLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INTH.HasValue)
				request.WithQueryParameter("INTH", m3INTH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FFA1))
				request.WithQueryParameter("FFA1", m3FFA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA2))
				request.WithQueryParameter("FFA2", m3FFA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA3))
				request.WithQueryParameter("FFA3", m3FFA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA4))
				request.WithQueryParameter("FFA4", m3FFA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA5))
				request.WithQueryParameter("FFA5", m3FFA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA6))
				request.WithQueryParameter("FFA6", m3FFA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA7))
				request.WithQueryParameter("FFA7", m3FFA7.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA8))
				request.WithQueryParameter("FFA8", m3FFA8.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA9))
				request.WithQueryParameter("FFA9", m3FFA9.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA0))
				request.WithQueryParameter("FFA0", m3FFA0.Trim());
			if (m3FFN1.HasValue)
				request.WithQueryParameter("FFN1", m3FFN1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN2.HasValue)
				request.WithQueryParameter("FFN2", m3FFN2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN3.HasValue)
				request.WithQueryParameter("FFN3", m3FFN3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN4.HasValue)
				request.WithQueryParameter("FFN4", m3FFN4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN5.HasValue)
				request.WithQueryParameter("FFN5", m3FFN5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN6.HasValue)
				request.WithQueryParameter("FFN6", m3FFN6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN7.HasValue)
				request.WithQueryParameter("FFN7", m3FFN7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN8.HasValue)
				request.WithQueryParameter("FFN8", m3FFN8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN9.HasValue)
				request.WithQueryParameter("FFN9", m3FFN9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN0.HasValue)
				request.WithQueryParameter("FFN0", m3FFN0.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddFunding
		/// Description This transaction adds LTR Funding
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFunding(
			string m3ITNO, 
			string m3BANO, 
			string m3FACI, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim());

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
		/// Name DltFundDetail
		/// Description This transaction deletes Funding Details
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Serial number (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltFundDetail(
			string m3ITNO, 
			string m3BANO, 
			int m3SBNO, 
			int m3VERS, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim())
				.WithQueryParameter("SBNO", m3SBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltFunding
		/// Description This transaction deletes Funding
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltFunding(
			string m3ITNO, 
			string m3BANO, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim());

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
		/// Name GetFundDetail
		/// Description This transaction displays Funding Details
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Serial number (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFundDetailResponse></returns>
		/// <exception cref="M3Exception<GetFundDetailResponse>"></exception>
		public async Task<M3Response<GetFundDetailResponse>> GetFundDetail(
			string m3ITNO, 
			string m3BANO, 
			int m3SBNO, 
			int m3VERS, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim())
				.WithQueryParameter("SBNO", m3SBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetFundDetailResponse>(
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
		/// Name LstFundByAgree
		/// Description This transaction lists Funding By Agreements
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3FUAG">Funder agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFundByAgreeResponse></returns>
		/// <exception cref="M3Exception<LstFundByAgreeResponse>"></exception>
		public async Task<M3Response<LstFundByAgreeResponse>> LstFundByAgree(
			string m3FACI = null, 
			string m3FUAG = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUAG))
				request.WithQueryParameter("FUAG", m3FUAG.Trim());

			// Execute the request
			var result = await Execute<LstFundByAgreeResponse>(
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
		/// Name LstFundByFunder
		/// Description This transaction lists Funding By Funders
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CUNO">Funder number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFundByFunderResponse></returns>
		/// <exception cref="M3Exception<LstFundByFunderResponse>"></exception>
		public async Task<M3Response<LstFundByFunderResponse>> LstFundByFunder(
			string m3FACI = null, 
			string m3CUNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<LstFundByFunderResponse>(
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
		/// Name LstFundByItem
		/// Description This transaction lists Funding By Items
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFundByItemResponse></returns>
		/// <exception cref="M3Exception<LstFundByItemResponse>"></exception>
		public async Task<M3Response<LstFundByItemResponse>> LstFundByItem(
			string m3ITNO = null, 
			string m3BANO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<LstFundByItemResponse>(
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
		/// Name LstFundByStatus
		/// Description This transaction lists Funding By Statuses
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFundByStatusResponse></returns>
		/// <exception cref="M3Exception<LstFundByStatusResponse>"></exception>
		public async Task<M3Response<LstFundByStatusResponse>> LstFundByStatus(
			string m3FACI = null, 
			string m3STAT = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<LstFundByStatusResponse>(
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
		/// Name LstFundDetail
		/// Description This transaction lists Funding Details
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Serial number (Required)</param>
		/// <param name="m3SBNO">Subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFundDetailResponse></returns>
		/// <exception cref="M3Exception<LstFundDetailResponse>"></exception>
		public async Task<M3Response<LstFundDetailResponse>> LstFundDetail(
			string m3ITNO, 
			string m3BANO, 
			int? m3SBNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3SBNO.HasValue)
				request.WithQueryParameter("SBNO", m3SBNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstFundDetailResponse>(
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
		/// Name UpdFundDetail
		/// Description This transaction updates Funding Details
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3BANO">Serial number (Required)</param>
		/// <param name="m3SBNO">Subnumber (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3NOPR">Number of periods</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3CMPP">Months/period</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3RESV">Residual value</param>
		/// <param name="m3REPE">Residual %</param>
		/// <param name="m3INTT">Interest type</param>
		/// <param name="m3INPE">Interest rate</param>
		/// <param name="m3RENT">Rent amount</param>
		/// <param name="m3FUND">Funder number</param>
		/// <param name="m3CINO">Invoice number</param>
		/// <param name="m3FUAG">Funder agreement number</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3INLL">Minimum variable interest rate</param>
		/// <param name="m3INTH">Interest threshold value</param>
		/// <param name="m3FFA1">User-defined field 1 alfa</param>
		/// <param name="m3FFA2">User-defined field 2 alfa</param>
		/// <param name="m3FFA3">User-defined field 3 alfa</param>
		/// <param name="m3FFA4">User-defined field 4 alfa</param>
		/// <param name="m3FFA5">User-defined field 5 alfa</param>
		/// <param name="m3FFA6">User-defined field 6 alfa</param>
		/// <param name="m3FFA7">User-defined field 7 alfa</param>
		/// <param name="m3FFA8">User-defined field 8 alfa</param>
		/// <param name="m3FFA9">User-defined field 9 alfa</param>
		/// <param name="m3FFA0">User-defined field 10 alfa</param>
		/// <param name="m3FFN1">User-defined field 1 numeric</param>
		/// <param name="m3FFN2">User-defined field 2 numeric</param>
		/// <param name="m3FFN3">User-defined field 3 numeric</param>
		/// <param name="m3FFN4">User-defined field 4 numeric</param>
		/// <param name="m3FFN5">User-defined field 5 numeric</param>
		/// <param name="m3FFN6">User-defined field 6 numeric</param>
		/// <param name="m3FFN7">User-defined field 7 numeric</param>
		/// <param name="m3FFN8">User-defined field 8 numeric</param>
		/// <param name="m3FFN9">User-defined field 9 numeric</param>
		/// <param name="m3FFN0">User-defined field 10 numeric</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdFundDetail(
			string m3ITNO, 
			string m3BANO, 
			int m3SBNO, 
			int m3VERS, 
			string m3STAT = null, 
			int? m3NOPR = null, 
			DateTime? m3FVDT = null, 
			int? m3CMPP = null, 
			string m3INVM = null, 
			decimal? m3RESV = null, 
			int? m3REPE = null, 
			string m3INTT = null, 
			decimal? m3INPE = null, 
			decimal? m3RENT = null, 
			string m3FUND = null, 
			string m3CINO = null, 
			string m3FUAG = null, 
			string m3CUCD = null, 
			decimal? m3INLL = null, 
			int? m3INTH = null, 
			string m3FFA1 = null, 
			string m3FFA2 = null, 
			string m3FFA3 = null, 
			string m3FFA4 = null, 
			string m3FFA5 = null, 
			string m3FFA6 = null, 
			string m3FFA7 = null, 
			string m3FFA8 = null, 
			string m3FFA9 = null, 
			string m3FFA0 = null, 
			decimal? m3FFN1 = null, 
			decimal? m3FFN2 = null, 
			decimal? m3FFN3 = null, 
			decimal? m3FFN4 = null, 
			decimal? m3FFN5 = null, 
			decimal? m3FFN6 = null, 
			decimal? m3FFN7 = null, 
			decimal? m3FFN8 = null, 
			decimal? m3FFN9 = null, 
			decimal? m3FFN0 = null, 
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
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim())
				.WithQueryParameter("SBNO", m3SBNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3NOPR.HasValue)
				request.WithQueryParameter("NOPR", m3NOPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3CMPP.HasValue)
				request.WithQueryParameter("CMPP", m3CMPP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (m3RESV.HasValue)
				request.WithQueryParameter("RESV", m3RESV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REPE.HasValue)
				request.WithQueryParameter("REPE", m3REPE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INTT))
				request.WithQueryParameter("INTT", m3INTT.Trim());
			if (m3INPE.HasValue)
				request.WithQueryParameter("INPE", m3INPE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RENT.HasValue)
				request.WithQueryParameter("RENT", m3RENT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FUND))
				request.WithQueryParameter("FUND", m3FUND.Trim());
			if (!string.IsNullOrWhiteSpace(m3CINO))
				request.WithQueryParameter("CINO", m3CINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUAG))
				request.WithQueryParameter("FUAG", m3FUAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3INLL.HasValue)
				request.WithQueryParameter("INLL", m3INLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INTH.HasValue)
				request.WithQueryParameter("INTH", m3INTH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FFA1))
				request.WithQueryParameter("FFA1", m3FFA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA2))
				request.WithQueryParameter("FFA2", m3FFA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA3))
				request.WithQueryParameter("FFA3", m3FFA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA4))
				request.WithQueryParameter("FFA4", m3FFA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA5))
				request.WithQueryParameter("FFA5", m3FFA5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA6))
				request.WithQueryParameter("FFA6", m3FFA6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA7))
				request.WithQueryParameter("FFA7", m3FFA7.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA8))
				request.WithQueryParameter("FFA8", m3FFA8.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA9))
				request.WithQueryParameter("FFA9", m3FFA9.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFA0))
				request.WithQueryParameter("FFA0", m3FFA0.Trim());
			if (m3FFN1.HasValue)
				request.WithQueryParameter("FFN1", m3FFN1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN2.HasValue)
				request.WithQueryParameter("FFN2", m3FFN2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN3.HasValue)
				request.WithQueryParameter("FFN3", m3FFN3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN4.HasValue)
				request.WithQueryParameter("FFN4", m3FFN4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN5.HasValue)
				request.WithQueryParameter("FFN5", m3FFN5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN6.HasValue)
				request.WithQueryParameter("FFN6", m3FFN6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN7.HasValue)
				request.WithQueryParameter("FFN7", m3FFN7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN8.HasValue)
				request.WithQueryParameter("FFN8", m3FFN8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN9.HasValue)
				request.WithQueryParameter("FFN9", m3FFN9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FFN0.HasValue)
				request.WithQueryParameter("FFN0", m3FFN0.Value.ToString(CultureInfo.CurrentCulture));

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
