/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CSS204MI;
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
	/// Name: CSS204MI
	/// Component Name: SCORE Reporting
	/// Description: Api: SCORE Reporting
	/// Version Release: 5ea0
	///</summary>
	public partial class CSS204MIResource : M3BaseResourceEndpoint
	{
		public CSS204MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CSS204MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddGrief
		/// Description AddGrief
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CRDT">Creation date (Required)</param>
		/// <param name="m3RETY">Transaction type (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3GFER">Grief error</param>
		/// <param name="m3GFMS">Grief message</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddGrief(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3CRDT, 
			string m3RETY, 
			string m3DIVI = null, 
			int? m3SEQN = null, 
			string m3GFER = null, 
			string m3GFMS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddGrief",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3RETY))
				throw new ArgumentNullException(nameof(m3RETY));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("CRDT", m3CRDT.ToM3String())
				.WithQueryParameter("RETY", m3RETY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3GFER))
				request.WithQueryParameter("GFER", m3GFER.Trim());
			if (!string.IsNullOrWhiteSpace(m3GFMS))
				request.WithQueryParameter("GFMS", m3GFMS.Trim());

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
		/// Name AddScore
		/// Description Add Score
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CRDT">Creation date (Required)</param>
		/// <param name="m3RETY">Transaction type (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3IDLR">Inventory dealer c</param>
		/// <param name="m3ALET">Sale type</param>
		/// <param name="m3OWCL">Owner class</param>
		/// <param name="m3DECD">Delivery code</param>
		/// <param name="m3SDLR">Selling dealer c</param>
		/// <param name="m3SMTX">Salesperson</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3CUNM">Name</param>
		/// <param name="m3ADR1">Address line 1</param>
		/// <param name="m3ADR2">Address line 2</param>
		/// <param name="m3ADR3">Address line 3</param>
		/// <param name="m3CITY">Address</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3CNTR">Country name</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3SACT">Sale contact name</param>
		/// <param name="m3SECT">Serv contact name</param>
		/// <param name="m3SEDT">Sales date</param>
		/// <param name="m3RTMS">Rent lease mos</param>
		/// <param name="m3PRWO">Principle work</param>
		/// <param name="m3DLDT">Planned delivery date</param>
		/// <param name="m3CATX">Cat extra code</param>
		/// <param name="m3RTIN">Rental income total</param>
		/// <param name="m3RTPC">Percent of rent applied</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SICC">Sicc code</param>
		/// <param name="m3TRPI">Transaction price</param>
		/// <param name="m3OVAM">Over allow amount</param>
		/// <param name="m3VINT">Vin</param>
		/// <param name="m3GOVT">Govt file no</param>
		/// <param name="m3REJE">Reinjes 7200 ser no</param>
		/// <param name="m3TRNG">Trans gen chge</param>
		/// <param name="m3DISH">Dist channel</param>
		/// <param name="m3FRI1">Sic code</param>
		/// <param name="m3APCO">Application code</param>
		/// <param name="m3TDLR">To dealer code</param>
		/// <param name="m3TRMD">Transmitted dlr cd</param>
		/// <param name="m3FUEL">Fuel code</param>
		/// <param name="m3CICC">Sic code</param>
		/// <param name="m3SBDT">Submit date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3DLIX">Delivery number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3FDLR">From dealer</param>
		/// <param name="m3SALZ">Salt</param>
		/// <param name="m3HRTZ">Hertz code</param>
		/// <param name="m3FRI2">User field 2</param>
		/// <param name="m3SPFO">Spar  focus code</param>
		/// <param name="m3COMI">Comitted Y/N</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddScoreResponse></returns>
		/// <exception cref="M3Exception<AddScoreResponse>"></exception>
		public async Task<M3Response<AddScoreResponse>> AddScore(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3CRDT, 
			string m3RETY, 
			string m3DIVI = null, 
			string m3IDLR = null, 
			string m3ALET = null, 
			string m3OWCL = null, 
			string m3DECD = null, 
			string m3SDLR = null, 
			string m3SMTX = null, 
			string m3CUNO = null, 
			string m3CUNM = null, 
			string m3ADR1 = null, 
			string m3ADR2 = null, 
			string m3ADR3 = null, 
			string m3CITY = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3PONO = null, 
			string m3CNTR = null, 
			string m3PHNO = null, 
			string m3SACT = null, 
			string m3SECT = null, 
			DateTime? m3SEDT = null, 
			int? m3RTMS = null, 
			string m3PRWO = null, 
			DateTime? m3DLDT = null, 
			string m3CATX = null, 
			decimal? m3RTIN = null, 
			int? m3RTPC = null, 
			decimal? m3SAPR = null, 
			string m3SICC = null, 
			decimal? m3TRPI = null, 
			decimal? m3OVAM = null, 
			string m3VINT = null, 
			string m3GOVT = null, 
			string m3REJE = null, 
			string m3TRNG = null, 
			string m3DISH = null, 
			string m3FRI1 = null, 
			string m3APCO = null, 
			string m3TDLR = null, 
			string m3TRMD = null, 
			string m3FUEL = null, 
			string m3CICC = null, 
			DateTime? m3SBDT = null, 
			string m3STAT = null, 
			decimal? m3DLIX = null, 
			int? m3RIDL = null, 
			string m3RIDN = null, 
			string m3FDLR = null, 
			string m3SALZ = null, 
			string m3HRTZ = null, 
			string m3FRI2 = null, 
			string m3SPFO = null, 
			string m3COMI = null, 
			string m3FRCO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddScore",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3RETY))
				throw new ArgumentNullException(nameof(m3RETY));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("CRDT", m3CRDT.ToM3String())
				.WithQueryParameter("RETY", m3RETY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDLR))
				request.WithQueryParameter("IDLR", m3IDLR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALET))
				request.WithQueryParameter("ALET", m3ALET.Trim());
			if (!string.IsNullOrWhiteSpace(m3OWCL))
				request.WithQueryParameter("OWCL", m3OWCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3DECD))
				request.WithQueryParameter("DECD", m3DECD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDLR))
				request.WithQueryParameter("SDLR", m3SDLR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMTX))
				request.WithQueryParameter("SMTX", m3SMTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR1))
				request.WithQueryParameter("ADR1", m3ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR2))
				request.WithQueryParameter("ADR2", m3ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR3))
				request.WithQueryParameter("ADR3", m3ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CITY))
				request.WithQueryParameter("CITY", m3CITY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CNTR))
				request.WithQueryParameter("CNTR", m3CNTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SACT))
				request.WithQueryParameter("SACT", m3SACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SECT))
				request.WithQueryParameter("SECT", m3SECT.Trim());
			if (m3SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3SEDT.Value.ToM3String());
			if (m3RTMS.HasValue)
				request.WithQueryParameter("RTMS", m3RTMS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRWO))
				request.WithQueryParameter("PRWO", m3PRWO.Trim());
			if (m3DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3DLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CATX))
				request.WithQueryParameter("CATX", m3CATX.Trim());
			if (m3RTIN.HasValue)
				request.WithQueryParameter("RTIN", m3RTIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTPC.HasValue)
				request.WithQueryParameter("RTPC", m3RTPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SICC))
				request.WithQueryParameter("SICC", m3SICC.Trim());
			if (m3TRPI.HasValue)
				request.WithQueryParameter("TRPI", m3TRPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OVAM.HasValue)
				request.WithQueryParameter("OVAM", m3OVAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VINT))
				request.WithQueryParameter("VINT", m3VINT.Trim());
			if (!string.IsNullOrWhiteSpace(m3GOVT))
				request.WithQueryParameter("GOVT", m3GOVT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REJE))
				request.WithQueryParameter("REJE", m3REJE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRNG))
				request.WithQueryParameter("TRNG", m3TRNG.Trim());
			if (!string.IsNullOrWhiteSpace(m3DISH))
				request.WithQueryParameter("DISH", m3DISH.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRI1))
				request.WithQueryParameter("FRI1", m3FRI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3APCO))
				request.WithQueryParameter("APCO", m3APCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDLR))
				request.WithQueryParameter("TDLR", m3TDLR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRMD))
				request.WithQueryParameter("TRMD", m3TRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUEL))
				request.WithQueryParameter("FUEL", m3FUEL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CICC))
				request.WithQueryParameter("CICC", m3CICC.Trim());
			if (m3SBDT.HasValue)
				request.WithQueryParameter("SBDT", m3SBDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3DLIX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDLR))
				request.WithQueryParameter("FDLR", m3FDLR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SALZ))
				request.WithQueryParameter("SALZ", m3SALZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3HRTZ))
				request.WithQueryParameter("HRTZ", m3HRTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRI2))
				request.WithQueryParameter("FRI2", m3FRI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPFO))
				request.WithQueryParameter("SPFO", m3SPFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3COMI))
				request.WithQueryParameter("COMI", m3COMI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());

			// Execute the request
			var result = await Execute<AddScoreResponse>(
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
		/// Name DelScore
		/// Description Delete Score
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CRDT">Creation date (Required)</param>
		/// <param name="m3RETY">Transaction type (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelScore(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3CRDT, 
			string m3RETY, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelScore",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3RETY))
				throw new ArgumentNullException(nameof(m3RETY));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("CRDT", m3CRDT.ToM3String())
				.WithQueryParameter("RETY", m3RETY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name GetCatScore
		/// Description Get Cat SCORE Reporting
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3RETY">Transaction type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCatScoreResponse></returns>
		/// <exception cref="M3Exception<GetCatScoreResponse>"></exception>
		public async Task<M3Response<GetCatScoreResponse>> GetCatScore(
			string m3SERN, 
			string m3RETY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCatScore",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3RETY))
				throw new ArgumentNullException(nameof(m3RETY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("RETY", m3RETY.Trim());

			// Execute the request
			var result = await Execute<GetCatScoreResponse>(
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
		/// Name GetSCOREREP
		/// Description Get SCORE Reporting
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CRDT">Creation date (Required)</param>
		/// <param name="m3RETY">Transaction type (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSCOREREPResponse></returns>
		/// <exception cref="M3Exception<GetSCOREREPResponse>"></exception>
		public async Task<M3Response<GetSCOREREPResponse>> GetSCOREREP(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3CRDT, 
			string m3RETY, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSCOREREP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3RETY))
				throw new ArgumentNullException(nameof(m3RETY));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("CRDT", m3CRDT.ToM3String())
				.WithQueryParameter("RETY", m3RETY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetSCOREREPResponse>(
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
		/// Name GetScrCode
		/// Description Get Scr Code
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3ITTY">Item type</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3EQTP">Equipment type</param>
		/// <param name="m3EQGR">Equipment group</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetScrCodeResponse></returns>
		/// <exception cref="M3Exception<GetScrCodeResponse>"></exception>
		public async Task<M3Response<GetScrCodeResponse>> GetScrCode(
			string m3RESP = null, 
			string m3ITTY = null, 
			string m3ITGR = null, 
			string m3ITCL = null, 
			string m3EQTP = null, 
			string m3EQGR = null, 
			string m3CUNO = null, 
			string m3PYNO = null, 
			int? m3RORC = null, 
			string m3CSCD = null, 
			string m3DIVI = null, 
			string m3FACI = null, 
			string m3ECAR = null, 
			string m3WHLO = null, 
			string m3ORTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetScrCode",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITTY))
				request.WithQueryParameter("ITTY", m3ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQTP))
				request.WithQueryParameter("EQTP", m3EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQGR))
				request.WithQueryParameter("EQGR", m3EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());

			// Execute the request
			var result = await Execute<GetScrCodeResponse>(
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
		/// Name UpdateScore
		/// Description Update SCORE Reporting
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3SERN">Serial number (Required)</param>
		/// <param name="m3CRDT">Creation date (Required)</param>
		/// <param name="m3RETY">Transaction type (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateScore(
			string m3ITNO, 
			string m3SERN, 
			DateTime m3CRDT, 
			string m3RETY, 
			string m3DIVI = null, 
			string m3STAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdateScore",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SERN))
				throw new ArgumentNullException(nameof(m3SERN));
			if (string.IsNullOrWhiteSpace(m3RETY))
				throw new ArgumentNullException(nameof(m3RETY));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SERN", m3SERN.Trim())
				.WithQueryParameter("CRDT", m3CRDT.ToM3String())
				.WithQueryParameter("RETY", m3RETY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

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
