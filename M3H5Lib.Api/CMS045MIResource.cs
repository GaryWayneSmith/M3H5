/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CMS045MI;
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
	/// Name: CMS045MI
	/// Component Name: Events
	/// Description: Event based subscriptions/alerts
	/// Version Release: 5e90
	///</summary>
	public partial class CMS045MIResource : M3BaseResourceEndpoint
	{
		public CMS045MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS045MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAlertRule
		/// Description Create a new rule
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3AMSG">Alert message (Required)</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3ARID">Alert rule identity</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3LOT1">Logical type</param>
		/// <param name="m3LOT2">Logical type</param>
		/// <param name="m3LOT3">Logical type</param>
		/// <param name="m3OB01">Field</param>
		/// <param name="m3OB02">Field</param>
		/// <param name="m3OB03">Field</param>
		/// <param name="m3OB04">Field</param>
		/// <param name="m3OB05">Field</param>
		/// <param name="m3OB06">Field</param>
		/// <param name="m3VAL1">Value field</param>
		/// <param name="m3VAL2">Value field</param>
		/// <param name="m3VAL3">Value field</param>
		/// <param name="m3COD1">Condition</param>
		/// <param name="m3COD2">Condition</param>
		/// <param name="m3COD3">Condition</param>
		/// <param name="m3OPR1">Operand</param>
		/// <param name="m3OPR2">Operand</param>
		/// <param name="m3OPR3">Operand</param>
		/// <param name="m3ADO1">And/or</param>
		/// <param name="m3ADO2">And/or</param>
		/// <param name="m3REC2">Receiver</param>
		/// <param name="m3OARF">File</param>
		/// <param name="m3OARE">Field</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3BODE">BOD enabled</param>
		/// <param name="m3BDMT">BOD message type</param>
		/// <param name="m3OFNC">Overriding function</param>
		/// <param name="m3BFFL">Bookmark focus field</param>
		/// <param name="m3OPT2">Option</param>
		/// <param name="m3PICC">Opening panel</param>
		/// <param name="m3WFNM">Workflow name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAlertRule(
			string m3EVPB, 
			string m3EVNM, 
			string m3TX40, 
			string m3AMSG, 
			string m3EVNO = null, 
			string m3ARID = null, 
			string m3TX15 = null, 
			string m3STAT = null, 
			string m3LOT1 = null, 
			string m3LOT2 = null, 
			string m3LOT3 = null, 
			string m3OB01 = null, 
			string m3OB02 = null, 
			string m3OB03 = null, 
			string m3OB04 = null, 
			string m3OB05 = null, 
			string m3OB06 = null, 
			string m3VAL1 = null, 
			string m3VAL2 = null, 
			string m3VAL3 = null, 
			int? m3COD1 = null, 
			int? m3COD2 = null, 
			int? m3COD3 = null, 
			int? m3OPR1 = null, 
			int? m3OPR2 = null, 
			int? m3OPR3 = null, 
			int? m3ADO1 = null, 
			int? m3ADO2 = null, 
			string m3REC2 = null, 
			string m3OARF = null, 
			string m3OARE = null, 
			decimal? m3TXID = null, 
			int? m3BODE = null, 
			int? m3BDMT = null, 
			string m3OFNC = null, 
			string m3BFFL = null, 
			string m3OPT2 = null, 
			string m3PICC = null, 
			string m3WFNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAlertRule",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3AMSG))
				throw new ArgumentNullException(nameof(m3AMSG));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("AMSG", m3AMSG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARID))
				request.WithQueryParameter("ARID", m3ARID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOT1))
				request.WithQueryParameter("LOT1", m3LOT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOT2))
				request.WithQueryParameter("LOT2", m3LOT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOT3))
				request.WithQueryParameter("LOT3", m3LOT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB01))
				request.WithQueryParameter("OB01", m3OB01.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB02))
				request.WithQueryParameter("OB02", m3OB02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB03))
				request.WithQueryParameter("OB03", m3OB03.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB04))
				request.WithQueryParameter("OB04", m3OB04.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB05))
				request.WithQueryParameter("OB05", m3OB05.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB06))
				request.WithQueryParameter("OB06", m3OB06.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL1))
				request.WithQueryParameter("VAL1", m3VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL2))
				request.WithQueryParameter("VAL2", m3VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL3))
				request.WithQueryParameter("VAL3", m3VAL3.Trim());
			if (m3COD1.HasValue)
				request.WithQueryParameter("COD1", m3COD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COD2.HasValue)
				request.WithQueryParameter("COD2", m3COD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COD3.HasValue)
				request.WithQueryParameter("COD3", m3COD3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPR1.HasValue)
				request.WithQueryParameter("OPR1", m3OPR1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPR2.HasValue)
				request.WithQueryParameter("OPR2", m3OPR2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPR3.HasValue)
				request.WithQueryParameter("OPR3", m3OPR3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADO1.HasValue)
				request.WithQueryParameter("ADO1", m3ADO1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADO2.HasValue)
				request.WithQueryParameter("ADO2", m3ADO2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REC2))
				request.WithQueryParameter("REC2", m3REC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OARF))
				request.WithQueryParameter("OARF", m3OARF.Trim());
			if (!string.IsNullOrWhiteSpace(m3OARE))
				request.WithQueryParameter("OARE", m3OARE.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BODE.HasValue)
				request.WithQueryParameter("BODE", m3BODE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BDMT.HasValue)
				request.WithQueryParameter("BDMT", m3BDMT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OFNC))
				request.WithQueryParameter("OFNC", m3OFNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3BFFL))
				request.WithQueryParameter("BFFL", m3BFFL.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPT2))
				request.WithQueryParameter("OPT2", m3OPT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PICC))
				request.WithQueryParameter("PICC", m3PICC.Trim());
			if (!string.IsNullOrWhiteSpace(m3WFNM))
				request.WithQueryParameter("WFNM", m3WFNM.Trim());

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
		/// Name AddFieldKey
		/// Description Add Field Event Key
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3EVNO">Event name operation (Required)</param>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3KEYF">Key field (Required)</param>
		/// <param name="m3FEFI">From event field</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldKey(
			string m3EVPB, 
			string m3EVNM, 
			string m3EVNO, 
			string m3FILE, 
			string m3KEYF, 
			string m3FEFI = null, 
			string m3STAT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddFieldKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));
			if (string.IsNullOrWhiteSpace(m3EVNO))
				throw new ArgumentNullException(nameof(m3EVNO));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3KEYF))
				throw new ArgumentNullException(nameof(m3KEYF));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim())
				.WithQueryParameter("EVNO", m3EVNO.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("KEYF", m3KEYF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FEFI))
				request.WithQueryParameter("FEFI", m3FEFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddFieldMap
		/// Description Add Field  Mapping
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3EVNO">Event name operation (Required)</param>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3FVLU">Field value</param>
		/// <param name="m3FEFI">From event field</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldMap(
			string m3EVPB, 
			string m3EVNM, 
			string m3EVNO, 
			string m3FILE, 
			string m3FLDI, 
			string m3FVLU = null, 
			string m3FEFI = null, 
			string m3STAT = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddFieldMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));
			if (string.IsNullOrWhiteSpace(m3EVNO))
				throw new ArgumentNullException(nameof(m3EVNO));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim())
				.WithQueryParameter("EVNO", m3EVNO.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FVLU))
				request.WithQueryParameter("FVLU", m3FVLU.Trim());
			if (!string.IsNullOrWhiteSpace(m3FEFI))
				request.WithQueryParameter("FEFI", m3FEFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddSubscription
		/// Description Create a new subscription
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3INEM">Include/exclude in event mapping</param>
		/// <param name="m3INEA">Include/exclude in event alerts</param>
		/// <param name="m3INEC">Include in event Db changes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSubscription(
			string m3EVPB, 
			string m3EVNM, 
			string m3EVNO = null, 
			string m3STAT = null, 
			int? m3INEM = null, 
			int? m3INEA = null, 
			int? m3INEC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSubscription",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3INEM.HasValue)
				request.WithQueryParameter("INEM", m3INEM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INEA.HasValue)
				request.WithQueryParameter("INEA", m3INEA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INEC.HasValue)
				request.WithQueryParameter("INEC", m3INEC.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelAlertRule
		/// Description Delete a rule
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3ARID">Alert rule identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAlertRule(
			string m3EVPB, 
			string m3EVNM, 
			string m3EVNO = null, 
			string m3ARID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelAlertRule",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARID))
				request.WithQueryParameter("ARID", m3ARID.Trim());

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
		/// Name DelSubscription
		/// Description Delete a subscription
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSubscription(
			string m3EVPB, 
			string m3EVNM, 
			string m3EVNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelSubscription",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());

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
		/// Name GetAlertRule
		/// Description Get alert rule
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3ARID">Alert rule identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAlertRuleResponse></returns>
		/// <exception cref="M3Exception<GetAlertRuleResponse>"></exception>
		public async Task<M3Response<GetAlertRuleResponse>> GetAlertRule(
			string m3EVPB, 
			string m3EVNM, 
			string m3EVNO = null, 
			string m3ARID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAlertRule",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARID))
				request.WithQueryParameter("ARID", m3ARID.Trim());

			// Execute the request
			var result = await Execute<GetAlertRuleResponse>(
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
		/// Name GetSubscription
		/// Description Get subscription data
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSubscriptionResponse></returns>
		/// <exception cref="M3Exception<GetSubscriptionResponse>"></exception>
		public async Task<M3Response<GetSubscriptionResponse>> GetSubscription(
			string m3EVPB, 
			string m3EVNM, 
			string m3EVNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSubscription",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());

			// Execute the request
			var result = await Execute<GetSubscriptionResponse>(
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
		/// Name LstAlertRules
		/// Description List rules
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3ARID">Alert rule identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAlertRulesResponse></returns>
		/// <exception cref="M3Exception<LstAlertRulesResponse>"></exception>
		public async Task<M3Response<LstAlertRulesResponse>> LstAlertRules(
			string m3EVPB = null, 
			string m3EVNM = null, 
			string m3EVNO = null, 
			string m3ARID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAlertRules",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARID))
				request.WithQueryParameter("ARID", m3ARID.Trim());

			// Execute the request
			var result = await Execute<LstAlertRulesResponse>(
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
		/// Name LstFieldKey
		/// Description List Field Event Key
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3KEYF">Key field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldKeyResponse></returns>
		/// <exception cref="M3Exception<LstFieldKeyResponse>"></exception>
		public async Task<M3Response<LstFieldKeyResponse>> LstFieldKey(
			string m3EVPB = null, 
			string m3EVNM = null, 
			string m3EVNO = null, 
			string m3FILE = null, 
			string m3KEYF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFieldKey",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEYF))
				request.WithQueryParameter("KEYF", m3KEYF.Trim());

			// Execute the request
			var result = await Execute<LstFieldKeyResponse>(
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
		/// Name LstFieldMap
		/// Description List Field Mapping
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldMapResponse></returns>
		/// <exception cref="M3Exception<LstFieldMapResponse>"></exception>
		public async Task<M3Response<LstFieldMapResponse>> LstFieldMap(
			string m3EVPB = null, 
			string m3EVNM = null, 
			string m3EVNO = null, 
			string m3FILE = null, 
			string m3FLDI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFieldMap",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<LstFieldMapResponse>(
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
		/// Name LstSubscription
		/// Description List subscriptions
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSubscriptionResponse></returns>
		/// <exception cref="M3Exception<LstSubscriptionResponse>"></exception>
		public async Task<M3Response<LstSubscriptionResponse>> LstSubscription(
			string m3EVPB = null, 
			string m3EVNM = null, 
			string m3EVNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSubscription",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());

			// Execute the request
			var result = await Execute<LstSubscriptionResponse>(
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
		/// Name SetRuleStatus
		/// Description Set status of an alert rule
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3ARID">Alert rule identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetRuleStatus(
			string m3EVPB, 
			string m3EVNM, 
			string m3STAT, 
			string m3EVNO = null, 
			string m3ARID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SetRuleStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARID))
				request.WithQueryParameter("ARID", m3ARID.Trim());

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
		/// Name SetSubsStatus
		/// Description Set status on a subscription
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3EVPB">Event publisher (Required)</param>
		/// <param name="m3EVNM">Event name (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetSubsStatus(
			string m3EVPB, 
			string m3EVNM, 
			string m3STAT, 
			string m3EVNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SetSubsStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EVPB))
				throw new ArgumentNullException(nameof(m3EVPB));
			if (string.IsNullOrWhiteSpace(m3EVNM))
				throw new ArgumentNullException(nameof(m3EVNM));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3EVPB.Trim())
				.WithQueryParameter("EVNM", m3EVNM.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());

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
