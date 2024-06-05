/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddGrief
		/// Description AddGrief
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CRDT">Creation date (Required)</param>
		/// <param name="m3_RETY">Transaction type (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_GFER">Grief error</param>
		/// <param name="m3_GFMS">Grief message</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddGrief(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_CRDT, 
			string m3_RETY, 
			string m3_DIVI = null, 
			int? m3_SEQN = null, 
			string m3_GFER = null, 
			string m3_GFMS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddGrief",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_RETY))
				throw new ArgumentNullException("m3_RETY");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("CRDT", m3_CRDT.ToM3String())
				.WithQueryParameter("RETY", m3_RETY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_GFER))
				request.WithQueryParameter("GFER", m3_GFER.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GFMS))
				request.WithQueryParameter("GFMS", m3_GFMS.Trim());

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
		/// Name AddScore
		/// Description Add Score
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CRDT">Creation date (Required)</param>
		/// <param name="m3_RETY">Transaction type (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_IDLR">Inventory dealer c</param>
		/// <param name="m3_ALET">Sale type</param>
		/// <param name="m3_OWCL">Owner class</param>
		/// <param name="m3_DECD">Delivery code</param>
		/// <param name="m3_SDLR">Selling dealer c</param>
		/// <param name="m3_SMTX">Salesperson</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_CUNM">Name</param>
		/// <param name="m3_ADR1">Address line 1</param>
		/// <param name="m3_ADR2">Address line 2</param>
		/// <param name="m3_ADR3">Address line 3</param>
		/// <param name="m3_CITY">Address</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_CNTR">Country name</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_SACT">Sale contact name</param>
		/// <param name="m3_SECT">Serv contact name</param>
		/// <param name="m3_SEDT">Sales date</param>
		/// <param name="m3_RTMS">Rent lease mos</param>
		/// <param name="m3_PRWO">Principle work</param>
		/// <param name="m3_DLDT">Planned delivery date</param>
		/// <param name="m3_CATX">Cat extra code</param>
		/// <param name="m3_RTIN">Rental income total</param>
		/// <param name="m3_RTPC">Percent of rent applied</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SICC">Sicc code</param>
		/// <param name="m3_TRPI">Transaction price</param>
		/// <param name="m3_OVAM">Over allow amount</param>
		/// <param name="m3_VINT">Vin</param>
		/// <param name="m3_GOVT">Govt file no</param>
		/// <param name="m3_REJE">Reinjes 7200 ser no</param>
		/// <param name="m3_TRNG">Trans gen chge</param>
		/// <param name="m3_DISH">Dist channel</param>
		/// <param name="m3_FRI1">Sic code</param>
		/// <param name="m3_APCO">Application code</param>
		/// <param name="m3_TDLR">To dealer code</param>
		/// <param name="m3_TRMD">Transmitted dlr cd</param>
		/// <param name="m3_FUEL">Fuel code</param>
		/// <param name="m3_CICC">Sic code</param>
		/// <param name="m3_SBDT">Submit date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_DLIX">Delivery number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_FDLR">From dealer</param>
		/// <param name="m3_SALZ">Salt</param>
		/// <param name="m3_HRTZ">Hertz code</param>
		/// <param name="m3_FRI2">User field 2</param>
		/// <param name="m3_SPFO">Spar  focus code</param>
		/// <param name="m3_COMI">Comitted Y/N</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddScoreResponse></returns>
		/// <exception cref="M3Exception<AddScoreResponse>"></exception>
		public async Task<M3Response<AddScoreResponse>> AddScore(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_CRDT, 
			string m3_RETY, 
			string m3_DIVI = null, 
			string m3_IDLR = null, 
			string m3_ALET = null, 
			string m3_OWCL = null, 
			string m3_DECD = null, 
			string m3_SDLR = null, 
			string m3_SMTX = null, 
			string m3_CUNO = null, 
			string m3_CUNM = null, 
			string m3_ADR1 = null, 
			string m3_ADR2 = null, 
			string m3_ADR3 = null, 
			string m3_CITY = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_PONO = null, 
			string m3_CNTR = null, 
			string m3_PHNO = null, 
			string m3_SACT = null, 
			string m3_SECT = null, 
			DateTime? m3_SEDT = null, 
			int? m3_RTMS = null, 
			string m3_PRWO = null, 
			DateTime? m3_DLDT = null, 
			string m3_CATX = null, 
			decimal? m3_RTIN = null, 
			int? m3_RTPC = null, 
			decimal? m3_SAPR = null, 
			string m3_SICC = null, 
			decimal? m3_TRPI = null, 
			decimal? m3_OVAM = null, 
			string m3_VINT = null, 
			string m3_GOVT = null, 
			string m3_REJE = null, 
			string m3_TRNG = null, 
			string m3_DISH = null, 
			string m3_FRI1 = null, 
			string m3_APCO = null, 
			string m3_TDLR = null, 
			string m3_TRMD = null, 
			string m3_FUEL = null, 
			string m3_CICC = null, 
			DateTime? m3_SBDT = null, 
			string m3_STAT = null, 
			decimal? m3_DLIX = null, 
			int? m3_RIDL = null, 
			string m3_RIDN = null, 
			string m3_FDLR = null, 
			string m3_SALZ = null, 
			string m3_HRTZ = null, 
			string m3_FRI2 = null, 
			string m3_SPFO = null, 
			string m3_COMI = null, 
			string m3_FRCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddScore",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_RETY))
				throw new ArgumentNullException("m3_RETY");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("CRDT", m3_CRDT.ToM3String())
				.WithQueryParameter("RETY", m3_RETY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDLR))
				request.WithQueryParameter("IDLR", m3_IDLR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALET))
				request.WithQueryParameter("ALET", m3_ALET.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OWCL))
				request.WithQueryParameter("OWCL", m3_OWCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DECD))
				request.WithQueryParameter("DECD", m3_DECD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDLR))
				request.WithQueryParameter("SDLR", m3_SDLR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMTX))
				request.WithQueryParameter("SMTX", m3_SMTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR1))
				request.WithQueryParameter("ADR1", m3_ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR2))
				request.WithQueryParameter("ADR2", m3_ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR3))
				request.WithQueryParameter("ADR3", m3_ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CITY))
				request.WithQueryParameter("CITY", m3_CITY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CNTR))
				request.WithQueryParameter("CNTR", m3_CNTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SACT))
				request.WithQueryParameter("SACT", m3_SACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SECT))
				request.WithQueryParameter("SECT", m3_SECT.Trim());
			if (m3_SEDT.HasValue)
				request.WithQueryParameter("SEDT", m3_SEDT.Value.ToM3String());
			if (m3_RTMS.HasValue)
				request.WithQueryParameter("RTMS", m3_RTMS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRWO))
				request.WithQueryParameter("PRWO", m3_PRWO.Trim());
			if (m3_DLDT.HasValue)
				request.WithQueryParameter("DLDT", m3_DLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CATX))
				request.WithQueryParameter("CATX", m3_CATX.Trim());
			if (m3_RTIN.HasValue)
				request.WithQueryParameter("RTIN", m3_RTIN.Value.ToString());
			if (m3_RTPC.HasValue)
				request.WithQueryParameter("RTPC", m3_RTPC.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SICC))
				request.WithQueryParameter("SICC", m3_SICC.Trim());
			if (m3_TRPI.HasValue)
				request.WithQueryParameter("TRPI", m3_TRPI.Value.ToString());
			if (m3_OVAM.HasValue)
				request.WithQueryParameter("OVAM", m3_OVAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VINT))
				request.WithQueryParameter("VINT", m3_VINT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GOVT))
				request.WithQueryParameter("GOVT", m3_GOVT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REJE))
				request.WithQueryParameter("REJE", m3_REJE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRNG))
				request.WithQueryParameter("TRNG", m3_TRNG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DISH))
				request.WithQueryParameter("DISH", m3_DISH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRI1))
				request.WithQueryParameter("FRI1", m3_FRI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APCO))
				request.WithQueryParameter("APCO", m3_APCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDLR))
				request.WithQueryParameter("TDLR", m3_TDLR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRMD))
				request.WithQueryParameter("TRMD", m3_TRMD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUEL))
				request.WithQueryParameter("FUEL", m3_FUEL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CICC))
				request.WithQueryParameter("CICC", m3_CICC.Trim());
			if (m3_SBDT.HasValue)
				request.WithQueryParameter("SBDT", m3_SBDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_DLIX.HasValue)
				request.WithQueryParameter("DLIX", m3_DLIX.Value.ToString());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDLR))
				request.WithQueryParameter("FDLR", m3_FDLR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SALZ))
				request.WithQueryParameter("SALZ", m3_SALZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HRTZ))
				request.WithQueryParameter("HRTZ", m3_HRTZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRI2))
				request.WithQueryParameter("FRI2", m3_FRI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPFO))
				request.WithQueryParameter("SPFO", m3_SPFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COMI))
				request.WithQueryParameter("COMI", m3_COMI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());

			// Execute the request
			var result = await Execute<AddScoreResponse>(
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
		/// Name DelScore
		/// Description Delete Score
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CRDT">Creation date (Required)</param>
		/// <param name="m3_RETY">Transaction type (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelScore(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_CRDT, 
			string m3_RETY, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelScore",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_RETY))
				throw new ArgumentNullException("m3_RETY");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("CRDT", m3_CRDT.ToM3String())
				.WithQueryParameter("RETY", m3_RETY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name GetCatScore
		/// Description Get Cat SCORE Reporting
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_RETY">Transaction type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCatScoreResponse></returns>
		/// <exception cref="M3Exception<GetCatScoreResponse>"></exception>
		public async Task<M3Response<GetCatScoreResponse>> GetCatScore(
			string m3_SERN, 
			string m3_RETY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCatScore",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_RETY))
				throw new ArgumentNullException("m3_RETY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("RETY", m3_RETY.Trim());

			// Execute the request
			var result = await Execute<GetCatScoreResponse>(
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
		/// Name GetSCOREREP
		/// Description Get SCORE Reporting
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CRDT">Creation date (Required)</param>
		/// <param name="m3_RETY">Transaction type (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSCOREREPResponse></returns>
		/// <exception cref="M3Exception<GetSCOREREPResponse>"></exception>
		public async Task<M3Response<GetSCOREREPResponse>> GetSCOREREP(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_CRDT, 
			string m3_RETY, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSCOREREP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_RETY))
				throw new ArgumentNullException("m3_RETY");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("CRDT", m3_CRDT.ToM3String())
				.WithQueryParameter("RETY", m3_RETY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetSCOREREPResponse>(
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
		/// Name GetScrCode
		/// Description Get Scr Code
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_ITTY">Item type</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_EQTP">Equipment type</param>
		/// <param name="m3_EQGR">Equipment group</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetScrCodeResponse></returns>
		/// <exception cref="M3Exception<GetScrCodeResponse>"></exception>
		public async Task<M3Response<GetScrCodeResponse>> GetScrCode(
			string m3_RESP = null, 
			string m3_ITTY = null, 
			string m3_ITGR = null, 
			string m3_ITCL = null, 
			string m3_EQTP = null, 
			string m3_EQGR = null, 
			string m3_CUNO = null, 
			string m3_PYNO = null, 
			int? m3_RORC = null, 
			string m3_CSCD = null, 
			string m3_DIVI = null, 
			string m3_FACI = null, 
			string m3_ECAR = null, 
			string m3_WHLO = null, 
			string m3_ORTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetScrCode",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITTY))
				request.WithQueryParameter("ITTY", m3_ITTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQTP))
				request.WithQueryParameter("EQTP", m3_EQTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQGR))
				request.WithQueryParameter("EQGR", m3_EQGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());

			// Execute the request
			var result = await Execute<GetScrCodeResponse>(
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
		/// Name UpdateScore
		/// Description Update SCORE Reporting
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_CRDT">Creation date (Required)</param>
		/// <param name="m3_RETY">Transaction type (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateScore(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_CRDT, 
			string m3_RETY, 
			string m3_DIVI = null, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdateScore",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_RETY))
				throw new ArgumentNullException("m3_RETY");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("CRDT", m3_CRDT.ToM3String())
				.WithQueryParameter("RETY", m3_RETY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

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
