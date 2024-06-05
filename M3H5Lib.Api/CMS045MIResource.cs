/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAlertRule
		/// Description Create a new rule
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_AMSG">Alert message (Required)</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_ARID">Alert rule identity</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_LOT1">Logical type</param>
		/// <param name="m3_LOT2">Logical type</param>
		/// <param name="m3_LOT3">Logical type</param>
		/// <param name="m3_OB01">Field</param>
		/// <param name="m3_OB02">Field</param>
		/// <param name="m3_OB03">Field</param>
		/// <param name="m3_OB04">Field</param>
		/// <param name="m3_OB05">Field</param>
		/// <param name="m3_OB06">Field</param>
		/// <param name="m3_VAL1">Value field</param>
		/// <param name="m3_VAL2">Value field</param>
		/// <param name="m3_VAL3">Value field</param>
		/// <param name="m3_COD1">Condition</param>
		/// <param name="m3_COD2">Condition</param>
		/// <param name="m3_COD3">Condition</param>
		/// <param name="m3_OPR1">Operand</param>
		/// <param name="m3_OPR2">Operand</param>
		/// <param name="m3_OPR3">Operand</param>
		/// <param name="m3_ADO1">And/or</param>
		/// <param name="m3_ADO2">And/or</param>
		/// <param name="m3_REC2">Receiver</param>
		/// <param name="m3_OARF">File</param>
		/// <param name="m3_OARE">Field</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_BODE">BOD enabled</param>
		/// <param name="m3_BDMT">BOD message type</param>
		/// <param name="m3_OFNC">Overriding function</param>
		/// <param name="m3_BFFL">Bookmark focus field</param>
		/// <param name="m3_OPT2">Option</param>
		/// <param name="m3_PICC">Opening panel</param>
		/// <param name="m3_WFNM">Workflow name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAlertRule(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_TX40, 
			string m3_AMSG, 
			string m3_EVNO = null, 
			string m3_ARID = null, 
			string m3_TX15 = null, 
			string m3_STAT = null, 
			string m3_LOT1 = null, 
			string m3_LOT2 = null, 
			string m3_LOT3 = null, 
			string m3_OB01 = null, 
			string m3_OB02 = null, 
			string m3_OB03 = null, 
			string m3_OB04 = null, 
			string m3_OB05 = null, 
			string m3_OB06 = null, 
			string m3_VAL1 = null, 
			string m3_VAL2 = null, 
			string m3_VAL3 = null, 
			int? m3_COD1 = null, 
			int? m3_COD2 = null, 
			int? m3_COD3 = null, 
			int? m3_OPR1 = null, 
			int? m3_OPR2 = null, 
			int? m3_OPR3 = null, 
			int? m3_ADO1 = null, 
			int? m3_ADO2 = null, 
			string m3_REC2 = null, 
			string m3_OARF = null, 
			string m3_OARE = null, 
			decimal? m3_TXID = null, 
			int? m3_BODE = null, 
			int? m3_BDMT = null, 
			string m3_OFNC = null, 
			string m3_BFFL = null, 
			string m3_OPT2 = null, 
			string m3_PICC = null, 
			string m3_WFNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAlertRule",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_AMSG))
				throw new ArgumentNullException("m3_AMSG");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("AMSG", m3_AMSG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARID))
				request.WithQueryParameter("ARID", m3_ARID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOT1))
				request.WithQueryParameter("LOT1", m3_LOT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOT2))
				request.WithQueryParameter("LOT2", m3_LOT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOT3))
				request.WithQueryParameter("LOT3", m3_LOT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB01))
				request.WithQueryParameter("OB01", m3_OB01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB02))
				request.WithQueryParameter("OB02", m3_OB02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB03))
				request.WithQueryParameter("OB03", m3_OB03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB04))
				request.WithQueryParameter("OB04", m3_OB04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB05))
				request.WithQueryParameter("OB05", m3_OB05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB06))
				request.WithQueryParameter("OB06", m3_OB06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL1))
				request.WithQueryParameter("VAL1", m3_VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL2))
				request.WithQueryParameter("VAL2", m3_VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL3))
				request.WithQueryParameter("VAL3", m3_VAL3.Trim());
			if (m3_COD1.HasValue)
				request.WithQueryParameter("COD1", m3_COD1.Value.ToString());
			if (m3_COD2.HasValue)
				request.WithQueryParameter("COD2", m3_COD2.Value.ToString());
			if (m3_COD3.HasValue)
				request.WithQueryParameter("COD3", m3_COD3.Value.ToString());
			if (m3_OPR1.HasValue)
				request.WithQueryParameter("OPR1", m3_OPR1.Value.ToString());
			if (m3_OPR2.HasValue)
				request.WithQueryParameter("OPR2", m3_OPR2.Value.ToString());
			if (m3_OPR3.HasValue)
				request.WithQueryParameter("OPR3", m3_OPR3.Value.ToString());
			if (m3_ADO1.HasValue)
				request.WithQueryParameter("ADO1", m3_ADO1.Value.ToString());
			if (m3_ADO2.HasValue)
				request.WithQueryParameter("ADO2", m3_ADO2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REC2))
				request.WithQueryParameter("REC2", m3_REC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OARF))
				request.WithQueryParameter("OARF", m3_OARF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OARE))
				request.WithQueryParameter("OARE", m3_OARE.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_BODE.HasValue)
				request.WithQueryParameter("BODE", m3_BODE.Value.ToString());
			if (m3_BDMT.HasValue)
				request.WithQueryParameter("BDMT", m3_BDMT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OFNC))
				request.WithQueryParameter("OFNC", m3_OFNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BFFL))
				request.WithQueryParameter("BFFL", m3_BFFL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPT2))
				request.WithQueryParameter("OPT2", m3_OPT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PICC))
				request.WithQueryParameter("PICC", m3_PICC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WFNM))
				request.WithQueryParameter("WFNM", m3_WFNM.Trim());

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
		/// Name AddFieldKey
		/// Description Add Field Event Key
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_EVNO">Event name operation (Required)</param>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_KEYF">Key field (Required)</param>
		/// <param name="m3_FEFI">From event field</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldKey(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_EVNO, 
			string m3_FILE, 
			string m3_KEYF, 
			string m3_FEFI = null, 
			string m3_STAT = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFieldKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");
			if (string.IsNullOrWhiteSpace(m3_EVNO))
				throw new ArgumentNullException("m3_EVNO");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_KEYF))
				throw new ArgumentNullException("m3_KEYF");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim())
				.WithQueryParameter("EVNO", m3_EVNO.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("KEYF", m3_KEYF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FEFI))
				request.WithQueryParameter("FEFI", m3_FEFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name AddFieldMap
		/// Description Add Field  Mapping
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_EVNO">Event name operation (Required)</param>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_FVLU">Field value</param>
		/// <param name="m3_FEFI">From event field</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldMap(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_EVNO, 
			string m3_FILE, 
			string m3_FLDI, 
			string m3_FVLU = null, 
			string m3_FEFI = null, 
			string m3_STAT = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFieldMap",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");
			if (string.IsNullOrWhiteSpace(m3_EVNO))
				throw new ArgumentNullException("m3_EVNO");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim())
				.WithQueryParameter("EVNO", m3_EVNO.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FVLU))
				request.WithQueryParameter("FVLU", m3_FVLU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FEFI))
				request.WithQueryParameter("FEFI", m3_FEFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name AddSubscription
		/// Description Create a new subscription
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_INEM">Include/exclude in event mapping</param>
		/// <param name="m3_INEA">Include/exclude in event alerts</param>
		/// <param name="m3_INEC">Include in event Db changes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSubscription(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_EVNO = null, 
			string m3_STAT = null, 
			int? m3_INEM = null, 
			int? m3_INEA = null, 
			int? m3_INEC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSubscription",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_INEM.HasValue)
				request.WithQueryParameter("INEM", m3_INEM.Value.ToString());
			if (m3_INEA.HasValue)
				request.WithQueryParameter("INEA", m3_INEA.Value.ToString());
			if (m3_INEC.HasValue)
				request.WithQueryParameter("INEC", m3_INEC.Value.ToString());

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
		/// Name DelAlertRule
		/// Description Delete a rule
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_ARID">Alert rule identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAlertRule(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_EVNO = null, 
			string m3_ARID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAlertRule",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARID))
				request.WithQueryParameter("ARID", m3_ARID.Trim());

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
		/// Name DelSubscription
		/// Description Delete a subscription
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSubscription(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_EVNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelSubscription",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());

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
		/// Name GetAlertRule
		/// Description Get alert rule
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_ARID">Alert rule identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAlertRuleResponse></returns>
		/// <exception cref="M3Exception<GetAlertRuleResponse>"></exception>
		public async Task<M3Response<GetAlertRuleResponse>> GetAlertRule(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_EVNO = null, 
			string m3_ARID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAlertRule",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARID))
				request.WithQueryParameter("ARID", m3_ARID.Trim());

			// Execute the request
			var result = await Execute<GetAlertRuleResponse>(
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
		/// Name GetSubscription
		/// Description Get subscription data
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSubscriptionResponse></returns>
		/// <exception cref="M3Exception<GetSubscriptionResponse>"></exception>
		public async Task<M3Response<GetSubscriptionResponse>> GetSubscription(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_EVNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSubscription",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());

			// Execute the request
			var result = await Execute<GetSubscriptionResponse>(
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
		/// Name LstAlertRules
		/// Description List rules
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3_EVPB">Event publisher</param>
		/// <param name="m3_EVNM">Event name</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_ARID">Alert rule identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAlertRulesResponse></returns>
		/// <exception cref="M3Exception<LstAlertRulesResponse>"></exception>
		public async Task<M3Response<LstAlertRulesResponse>> LstAlertRules(
			string m3_EVPB = null, 
			string m3_EVNM = null, 
			string m3_EVNO = null, 
			string m3_ARID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAlertRules",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVPB))
				request.WithQueryParameter("EVPB", m3_EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNM))
				request.WithQueryParameter("EVNM", m3_EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARID))
				request.WithQueryParameter("ARID", m3_ARID.Trim());

			// Execute the request
			var result = await Execute<LstAlertRulesResponse>(
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
		/// Name LstFieldKey
		/// Description List Field Event Key
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_EVPB">Event publisher</param>
		/// <param name="m3_EVNM">Event name</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_KEYF">Key field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldKeyResponse></returns>
		/// <exception cref="M3Exception<LstFieldKeyResponse>"></exception>
		public async Task<M3Response<LstFieldKeyResponse>> LstFieldKey(
			string m3_EVPB = null, 
			string m3_EVNM = null, 
			string m3_EVNO = null, 
			string m3_FILE = null, 
			string m3_KEYF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFieldKey",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVPB))
				request.WithQueryParameter("EVPB", m3_EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNM))
				request.WithQueryParameter("EVNM", m3_EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEYF))
				request.WithQueryParameter("KEYF", m3_KEYF.Trim());

			// Execute the request
			var result = await Execute<LstFieldKeyResponse>(
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
		/// Name LstFieldMap
		/// Description List Field Mapping
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_EVPB">Event publisher</param>
		/// <param name="m3_EVNM">Event name</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldMapResponse></returns>
		/// <exception cref="M3Exception<LstFieldMapResponse>"></exception>
		public async Task<M3Response<LstFieldMapResponse>> LstFieldMap(
			string m3_EVPB = null, 
			string m3_EVNM = null, 
			string m3_EVNO = null, 
			string m3_FILE = null, 
			string m3_FLDI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFieldMap",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVPB))
				request.WithQueryParameter("EVPB", m3_EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNM))
				request.WithQueryParameter("EVNM", m3_EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Execute the request
			var result = await Execute<LstFieldMapResponse>(
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
		/// Name LstSubscription
		/// Description List subscriptions
		/// Version Release: 15.2
		/// </summary>
		/// <param name="m3_EVPB">Event publisher</param>
		/// <param name="m3_EVNM">Event name</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSubscriptionResponse></returns>
		/// <exception cref="M3Exception<LstSubscriptionResponse>"></exception>
		public async Task<M3Response<LstSubscriptionResponse>> LstSubscription(
			string m3_EVPB = null, 
			string m3_EVNM = null, 
			string m3_EVNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSubscription",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVPB))
				request.WithQueryParameter("EVPB", m3_EVPB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNM))
				request.WithQueryParameter("EVNM", m3_EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());

			// Execute the request
			var result = await Execute<LstSubscriptionResponse>(
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
		/// Name SetRuleStatus
		/// Description Set status of an alert rule
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="m3_ARID">Alert rule identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetRuleStatus(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_STAT, 
			string m3_EVNO = null, 
			string m3_ARID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetRuleStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARID))
				request.WithQueryParameter("ARID", m3_ARID.Trim());

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
		/// Name SetSubsStatus
		/// Description Set status on a subscription
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_EVPB">Event publisher (Required)</param>
		/// <param name="m3_EVNM">Event name (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_EVNO">Event name operation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetSubsStatus(
			string m3_EVPB, 
			string m3_EVNM, 
			string m3_STAT, 
			string m3_EVNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetSubsStatus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EVPB))
				throw new ArgumentNullException("m3_EVPB");
			if (string.IsNullOrWhiteSpace(m3_EVNM))
				throw new ArgumentNullException("m3_EVNM");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("EVPB", m3_EVPB.Trim())
				.WithQueryParameter("EVNM", m3_EVNM.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EVNO))
				request.WithQueryParameter("EVNO", m3_EVNO.Trim());

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
