/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS860MI;
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
	/// Name: OIS860MI
	/// Component Name: OIS860
	/// Description: Supplier rebate agreement on sales
	/// Version Release: 5ea0
	///</summary>
	public partial class OIS860MIResource : M3BaseResourceEndpoint
	{
		public OIS860MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS860MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddHead
		/// Description Add supplier rebate agreement
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_AGRD">Agreement date</param>
		/// <param name="m3_PRI2">Priority</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_STA3">Status</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_RASR">Agreement reference number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_SRCA">Supplier rebate calculation method</param>
		/// <param name="m3_SREP">Rebate percentage</param>
		/// <param name="m3_SRBA">Supplier rebate base</param>
		/// <param name="m3_SRSC">Supplier rebate scale</param>
		/// <param name="m3_SECW">Search criteria - warehouse</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_PC01">Field</param>
		/// <param name="m3_PC02">Field</param>
		/// <param name="m3_PC03">Field</param>
		/// <param name="m3_PC04">Field</param>
		/// <param name="m3_PC05">Field</param>
		/// <param name="m3_PRR1">Price list</param>
		/// <param name="m3_CUC1">Currency</param>
		/// <param name="m3_SRB2">Rebate base 2</param>
		/// <param name="m3_SEC2">Search criteria - warehouse 2</param>
		/// <param name="m3_AGN2">Agreement number 2</param>
		/// <param name="m3_PRR2">Price list 2</param>
		/// <param name="m3_CUC2">Currency 2</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_PCT2">Costing type 2</param>
		/// <param name="m3_SRB3">Margin cost base</param>
		/// <param name="m3_SRE2">Guaranteed margin percentage</param>
		/// <param name="m3_AGSR">Agreed rebate amount</param>
		/// <param name="m3_SRAA">Supplier rebate agreed amount</param>
		/// <param name="m3_RAG2">Template Agmnt</param>
		/// <param name="m3_CUST">Copy agr values</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddHead(
			string m3_RAGN, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			DateTime? m3_AGRD = null, 
			int? m3_PRI2 = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_STA3 = null, 
			string m3_SUNO = null, 
			string m3_RASR = null, 
			string m3_FACI = null, 
			string m3_CUCD = null, 
			string m3_ACGR = null, 
			string m3_RFID = null, 
			string m3_RESP = null, 
			string m3_OREF = null, 
			int? m3_SRCA = null, 
			decimal? m3_SREP = null, 
			int? m3_SRBA = null, 
			string m3_SRSC = null, 
			string m3_SECW = null, 
			string m3_AGNB = null, 
			string m3_PC01 = null, 
			string m3_PC02 = null, 
			string m3_PC03 = null, 
			string m3_PC04 = null, 
			string m3_PC05 = null, 
			string m3_PRR1 = null, 
			string m3_CUC1 = null, 
			int? m3_SRB2 = null, 
			string m3_SEC2 = null, 
			string m3_AGN2 = null, 
			string m3_PRR2 = null, 
			string m3_CUC2 = null, 
			string m3_PCTP = null, 
			string m3_PCT2 = null, 
			int? m3_SRB3 = null, 
			decimal? m3_SRE2 = null, 
			int? m3_AGSR = null, 
			decimal? m3_SRAA = null, 
			string m3_RAG2 = null, 
			string m3_CUST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RAGN))
				throw new ArgumentNullException("m3_RAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3_RAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_AGRD.HasValue)
				request.WithQueryParameter("AGRD", m3_AGRD.Value.ToM3String());
			if (m3_PRI2.HasValue)
				request.WithQueryParameter("PRI2", m3_PRI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STA3))
				request.WithQueryParameter("STA3", m3_STA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASR))
				request.WithQueryParameter("RASR", m3_RASR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (m3_SRCA.HasValue)
				request.WithQueryParameter("SRCA", m3_SRCA.Value.ToString());
			if (m3_SREP.HasValue)
				request.WithQueryParameter("SREP", m3_SREP.Value.ToString());
			if (m3_SRBA.HasValue)
				request.WithQueryParameter("SRBA", m3_SRBA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SRSC))
				request.WithQueryParameter("SRSC", m3_SRSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SECW))
				request.WithQueryParameter("SECW", m3_SECW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC01))
				request.WithQueryParameter("PC01", m3_PC01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC02))
				request.WithQueryParameter("PC02", m3_PC02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC03))
				request.WithQueryParameter("PC03", m3_PC03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC04))
				request.WithQueryParameter("PC04", m3_PC04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC05))
				request.WithQueryParameter("PC05", m3_PC05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR1))
				request.WithQueryParameter("PRR1", m3_PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUC1))
				request.WithQueryParameter("CUC1", m3_CUC1.Trim());
			if (m3_SRB2.HasValue)
				request.WithQueryParameter("SRB2", m3_SRB2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SEC2))
				request.WithQueryParameter("SEC2", m3_SEC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGN2))
				request.WithQueryParameter("AGN2", m3_AGN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR2))
				request.WithQueryParameter("PRR2", m3_PRR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUC2))
				request.WithQueryParameter("CUC2", m3_CUC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCT2))
				request.WithQueryParameter("PCT2", m3_PCT2.Trim());
			if (m3_SRB3.HasValue)
				request.WithQueryParameter("SRB3", m3_SRB3.Value.ToString());
			if (m3_SRE2.HasValue)
				request.WithQueryParameter("SRE2", m3_SRE2.Value.ToString());
			if (m3_AGSR.HasValue)
				request.WithQueryParameter("AGSR", m3_AGSR.Value.ToString());
			if (m3_SRAA.HasValue)
				request.WithQueryParameter("SRAA", m3_SRAA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RAG2))
				request.WithQueryParameter("RAG2", m3_RAG2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUST))
				request.WithQueryParameter("CUST", m3_CUST.Trim());

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
		/// Name AddLine
		/// Description Add supplier agreement line
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_SRCA">Rebate calculation method</param>
		/// <param name="m3_SREP">Rebate percentage</param>
		/// <param name="m3_SREA">Rebate amount</param>
		/// <param name="m3_RPUN">Rebate amount unit of measure</param>
		/// <param name="m3_SRBA">Rebate base</param>
		/// <param name="m3_SRSC">Rebate scale</param>
		/// <param name="m3_SECW">Search criteria - warehouse</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_PRR1">Price list</param>
		/// <param name="m3_CUC1">Currency</param>
		/// <param name="m3_SRB2">Rebate base 2</param>
		/// <param name="m3_SEC2">Search criteria - warehouse 2</param>
		/// <param name="m3_AGN2">Agreement number 2</param>
		/// <param name="m3_PRR2">Price list 2</param>
		/// <param name="m3_CUC2">Currency 2</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_PCT2">Costing type 2</param>
		/// <param name="m3_SRB3">Margin cost base</param>
		/// <param name="m3_SRE2">Guaranteed margin percentage</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLine(
			string m3_RAGN, 
			string m3_PREX, 
			string m3_OBV1, 
			DateTime m3_FVDT, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
			DateTime? m3_LVDT = null, 
			int? m3_SRCA = null, 
			decimal? m3_SREP = null, 
			decimal? m3_SREA = null, 
			string m3_RPUN = null, 
			int? m3_SRBA = null, 
			string m3_SRSC = null, 
			string m3_SECW = null, 
			string m3_AGNB = null, 
			string m3_PRR1 = null, 
			string m3_CUC1 = null, 
			int? m3_SRB2 = null, 
			string m3_SEC2 = null, 
			string m3_AGN2 = null, 
			string m3_PRR2 = null, 
			string m3_CUC2 = null, 
			string m3_PCTP = null, 
			string m3_PCT2 = null, 
			int? m3_SRB3 = null, 
			decimal? m3_SRE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RAGN))
				throw new ArgumentNullException("m3_RAGN");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3_RAGN.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_SRCA.HasValue)
				request.WithQueryParameter("SRCA", m3_SRCA.Value.ToString());
			if (m3_SREP.HasValue)
				request.WithQueryParameter("SREP", m3_SREP.Value.ToString());
			if (m3_SREA.HasValue)
				request.WithQueryParameter("SREA", m3_SREA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPUN))
				request.WithQueryParameter("RPUN", m3_RPUN.Trim());
			if (m3_SRBA.HasValue)
				request.WithQueryParameter("SRBA", m3_SRBA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SRSC))
				request.WithQueryParameter("SRSC", m3_SRSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SECW))
				request.WithQueryParameter("SECW", m3_SECW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR1))
				request.WithQueryParameter("PRR1", m3_PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUC1))
				request.WithQueryParameter("CUC1", m3_CUC1.Trim());
			if (m3_SRB2.HasValue)
				request.WithQueryParameter("SRB2", m3_SRB2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SEC2))
				request.WithQueryParameter("SEC2", m3_SEC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGN2))
				request.WithQueryParameter("AGN2", m3_AGN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR2))
				request.WithQueryParameter("PRR2", m3_PRR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUC2))
				request.WithQueryParameter("CUC2", m3_CUC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCT2))
				request.WithQueryParameter("PCT2", m3_PCT2.Trim());
			if (m3_SRB3.HasValue)
				request.WithQueryParameter("SRB3", m3_SRB3.Value.ToString());
			if (m3_SRE2.HasValue)
				request.WithQueryParameter("SRE2", m3_SRE2.Value.ToString());

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
		/// Name ConnectAgrValue
		/// Description Connect agr values to supplier rebate agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConnectAgrValue(
			string m3_RAGN, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConnectAgrValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RAGN))
				throw new ArgumentNullException("m3_RAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3_RAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());

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
		/// Name DelAgrValues
		/// Description Delete agreement values from supplier rebate agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAgrValues(
			string m3_RAGN, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAgrValues",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RAGN))
				throw new ArgumentNullException("m3_RAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3_RAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());

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
		/// Name DelAgreement
		/// Description Delete supplier rebate agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAgreement(
			string m3_RAGN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAgreement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RAGN))
				throw new ArgumentNullException("m3_RAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3_RAGN.Trim());

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
		/// Name DelLine
		/// Description Delete a supplier rebate line
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLine(
			string m3_RAGN, 
			string m3_PREX, 
			string m3_OBV1, 
			DateTime m3_FVDT, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RAGN))
				throw new ArgumentNullException("m3_RAGN");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3_RAGN.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());

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
		/// Name GetHead
		/// Description Get supplier rebate agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3_RAGN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RAGN))
				throw new ArgumentNullException("m3_RAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3_RAGN.Trim());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetLine
		/// Description Get suppluer rebate Lines
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3_RAGN, 
			string m3_PREX, 
			string m3_OBV1, 
			DateTime m3_FVDT, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RAGN))
				throw new ArgumentNullException("m3_RAGN");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3_RAGN.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());

			// Execute the request
			var result = await Execute<GetLineResponse>(
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
		/// Name LstAgrValByAgr
		/// Description List agreement values supplier rebate agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrValByAgrResponse></returns>
		/// <exception cref="M3Exception<LstAgrValByAgrResponse>"></exception>
		public async Task<M3Response<LstAgrValByAgrResponse>> LstAgrValByAgr(
			string m3_RAGN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrValByAgr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RAGN))
				throw new ArgumentNullException("m3_RAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3_RAGN.Trim());

			// Execute the request
			var result = await Execute<LstAgrValByAgrResponse>(
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
		/// Name LstByFacility
		/// Description List supplier rebate agreements by facility
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_STA3">Status</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByFacilityResponse></returns>
		/// <exception cref="M3Exception<LstByFacilityResponse>"></exception>
		public async Task<M3Response<LstByFacilityResponse>> LstByFacility(
			string m3_FACI = null, 
			string m3_SUNO = null, 
			string m3_STA3 = null, 
			DateTime? m3_FVDT = null, 
			int? m3_NFTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByFacility",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STA3))
				request.WithQueryParameter("STA3", m3_STA3.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());

			// Execute the request
			var result = await Execute<LstByFacilityResponse>(
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
		/// Name LstByStatus
		/// Description List supplier rebate agreements by status
		/// Version Release: 
		/// </summary>
		/// <param name="m3_STA3">Status</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByStatusResponse></returns>
		/// <exception cref="M3Exception<LstByStatusResponse>"></exception>
		public async Task<M3Response<LstByStatusResponse>> LstByStatus(
			string m3_STA3 = null, 
			string m3_SUNO = null, 
			DateTime? m3_FVDT = null, 
			int? m3_NFTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByStatus",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STA3))
				request.WithQueryParameter("STA3", m3_STA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());

			// Execute the request
			var result = await Execute<LstByStatusResponse>(
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
		/// Name LstBySupAgrRef
		/// Description List supplier rebate agreements by sup agreement reference
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RASR">Agreement reference number</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_STA3">Status</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBySupAgrRefResponse></returns>
		/// <exception cref="M3Exception<LstBySupAgrRefResponse>"></exception>
		public async Task<M3Response<LstBySupAgrRefResponse>> LstBySupAgrRef(
			string m3_RASR = null, 
			string m3_SUNO = null, 
			string m3_STA3 = null, 
			DateTime? m3_FVDT = null, 
			int? m3_NFTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBySupAgrRef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RASR))
				request.WithQueryParameter("RASR", m3_RASR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STA3))
				request.WithQueryParameter("STA3", m3_STA3.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());

			// Execute the request
			var result = await Execute<LstBySupAgrRefResponse>(
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
		/// Name LstBySupplier
		/// Description List supplier rebate agreements by supplier
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_STA3">Status</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBySupplierResponse></returns>
		/// <exception cref="M3Exception<LstBySupplierResponse>"></exception>
		public async Task<M3Response<LstBySupplierResponse>> LstBySupplier(
			string m3_SUNO = null, 
			string m3_STA3 = null, 
			DateTime? m3_FVDT = null, 
			int? m3_NFTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBySupplier",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STA3))
				request.WithQueryParameter("STA3", m3_STA3.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());

			// Execute the request
			var result = await Execute<LstBySupplierResponse>(
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
		/// Name LstHead
		/// Description List supplier rebate agreements
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadResponse></returns>
		/// <exception cref="M3Exception<LstHeadResponse>"></exception>
		public async Task<M3Response<LstHeadResponse>> LstHead(
			string m3_RAGN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RAGN))
				request.WithQueryParameter("RAGN", m3_RAGN.Trim());

			// Execute the request
			var result = await Execute<LstHeadResponse>(
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
		/// Name LstLine
		/// Description List supplier agreement lines
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3_PREX">Priority</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3_RAGN, 
			string m3_PREX = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
			DateTime? m3_FVDT = null, 
			int? m3_NFTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RAGN))
				throw new ArgumentNullException("m3_RAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3_RAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PREX))
				request.WithQueryParameter("PREX", m3_PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
		/// Name UpdHead
		/// Description Update supplier rebate agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_AGRD">Agreement date</param>
		/// <param name="m3_PRI2">Priority</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_STA3">Status</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_RASR">Agreement reference number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_RFID">Reference</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_SRCA">Supplier rebate calculation method</param>
		/// <param name="m3_SREP">Rebate percentage</param>
		/// <param name="m3_SRBA">Supplier rebate base</param>
		/// <param name="m3_SRSC">Supplier rebate scale</param>
		/// <param name="m3_SECW">Search criteria - warehouse</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_PC01">Field</param>
		/// <param name="m3_PC02">Field</param>
		/// <param name="m3_PC03">Field</param>
		/// <param name="m3_PC04">Field</param>
		/// <param name="m3_PC05">Field</param>
		/// <param name="m3_PRR1">Price list</param>
		/// <param name="m3_CUC1">Currency</param>
		/// <param name="m3_SRB2">Rebate base 2</param>
		/// <param name="m3_SEC2">Search criteria - warehouse 2</param>
		/// <param name="m3_AGN2">Agreement number 2</param>
		/// <param name="m3_PRR2">Price list 2</param>
		/// <param name="m3_CUC2">Currency</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_PCT2">Costing type 2</param>
		/// <param name="m3_SRB3">Margin cost base</param>
		/// <param name="m3_SRE2">Guaranteed margin percentage</param>
		/// <param name="m3_SRAA">Supplier rebate agreed amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHead(
			string m3_RAGN, 
			DateTime m3_FVDT, 
			DateTime? m3_LVDT = null, 
			DateTime? m3_AGRD = null, 
			int? m3_PRI2 = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_STA3 = null, 
			string m3_SUNO = null, 
			string m3_RASR = null, 
			string m3_FACI = null, 
			string m3_ACGR = null, 
			string m3_RFID = null, 
			string m3_RESP = null, 
			string m3_OREF = null, 
			int? m3_SRCA = null, 
			decimal? m3_SREP = null, 
			int? m3_SRBA = null, 
			string m3_SRSC = null, 
			string m3_SECW = null, 
			string m3_AGNB = null, 
			string m3_PC01 = null, 
			string m3_PC02 = null, 
			string m3_PC03 = null, 
			string m3_PC04 = null, 
			string m3_PC05 = null, 
			string m3_PRR1 = null, 
			string m3_CUC1 = null, 
			int? m3_SRB2 = null, 
			string m3_SEC2 = null, 
			string m3_AGN2 = null, 
			string m3_PRR2 = null, 
			string m3_CUC2 = null, 
			string m3_PCTP = null, 
			string m3_PCT2 = null, 
			int? m3_SRB3 = null, 
			decimal? m3_SRE2 = null, 
			decimal? m3_SRAA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RAGN))
				throw new ArgumentNullException("m3_RAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3_RAGN.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_AGRD.HasValue)
				request.WithQueryParameter("AGRD", m3_AGRD.Value.ToM3String());
			if (m3_PRI2.HasValue)
				request.WithQueryParameter("PRI2", m3_PRI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STA3))
				request.WithQueryParameter("STA3", m3_STA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASR))
				request.WithQueryParameter("RASR", m3_RASR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFID))
				request.WithQueryParameter("RFID", m3_RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (m3_SRCA.HasValue)
				request.WithQueryParameter("SRCA", m3_SRCA.Value.ToString());
			if (m3_SREP.HasValue)
				request.WithQueryParameter("SREP", m3_SREP.Value.ToString());
			if (m3_SRBA.HasValue)
				request.WithQueryParameter("SRBA", m3_SRBA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SRSC))
				request.WithQueryParameter("SRSC", m3_SRSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SECW))
				request.WithQueryParameter("SECW", m3_SECW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC01))
				request.WithQueryParameter("PC01", m3_PC01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC02))
				request.WithQueryParameter("PC02", m3_PC02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC03))
				request.WithQueryParameter("PC03", m3_PC03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC04))
				request.WithQueryParameter("PC04", m3_PC04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC05))
				request.WithQueryParameter("PC05", m3_PC05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR1))
				request.WithQueryParameter("PRR1", m3_PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUC1))
				request.WithQueryParameter("CUC1", m3_CUC1.Trim());
			if (m3_SRB2.HasValue)
				request.WithQueryParameter("SRB2", m3_SRB2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SEC2))
				request.WithQueryParameter("SEC2", m3_SEC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGN2))
				request.WithQueryParameter("AGN2", m3_AGN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR2))
				request.WithQueryParameter("PRR2", m3_PRR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUC2))
				request.WithQueryParameter("CUC2", m3_CUC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCT2))
				request.WithQueryParameter("PCT2", m3_PCT2.Trim());
			if (m3_SRB3.HasValue)
				request.WithQueryParameter("SRB3", m3_SRB3.Value.ToString());
			if (m3_SRE2.HasValue)
				request.WithQueryParameter("SRE2", m3_SRE2.Value.ToString());
			if (m3_SRAA.HasValue)
				request.WithQueryParameter("SRAA", m3_SRAA.Value.ToString());

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
		/// Name UpdLine
		/// Description Update supplier agreement line
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_FVDT">Valid from (Required)</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_SRCA">Rebate calculation method</param>
		/// <param name="m3_SREP">Rebate percentage</param>
		/// <param name="m3_SREA">Rebate amount</param>
		/// <param name="m3_RPUN">Rebate amount unit of measure</param>
		/// <param name="m3_SRBA">Rebate base</param>
		/// <param name="m3_SRSC">Rebate scale</param>
		/// <param name="m3_SECW">Search criteria - warehouse</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_PRR1">Price list</param>
		/// <param name="m3_CUC1">Currency</param>
		/// <param name="m3_SRB2">Rebate base 2</param>
		/// <param name="m3_SEC2">Search criteria - warehouse 2</param>
		/// <param name="m3_AGN2">Agreement number 2</param>
		/// <param name="m3_PRR2">Price list 2</param>
		/// <param name="m3_CUC2">Currency 2</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_PCT2">Costing type 2</param>
		/// <param name="m3_SRB3">Margin cost base</param>
		/// <param name="m3_SRE2">Guaranteed margin percentage</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLine(
			string m3_RAGN, 
			string m3_PREX, 
			string m3_OBV1, 
			DateTime m3_FVDT, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			string m3_OBV5 = null, 
			DateTime? m3_LVDT = null, 
			int? m3_SRCA = null, 
			decimal? m3_SREP = null, 
			decimal? m3_SREA = null, 
			string m3_RPUN = null, 
			int? m3_SRBA = null, 
			string m3_SRSC = null, 
			string m3_SECW = null, 
			string m3_AGNB = null, 
			string m3_PRR1 = null, 
			string m3_CUC1 = null, 
			int? m3_SRB2 = null, 
			string m3_SEC2 = null, 
			string m3_AGN2 = null, 
			string m3_PRR2 = null, 
			string m3_CUC2 = null, 
			string m3_PCTP = null, 
			string m3_PCT2 = null, 
			int? m3_SRB3 = null, 
			decimal? m3_SRE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RAGN))
				throw new ArgumentNullException("m3_RAGN");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3_RAGN.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim())
				.WithQueryParameter("OBV1", m3_OBV1.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV5))
				request.WithQueryParameter("OBV5", m3_OBV5.Trim());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (m3_SRCA.HasValue)
				request.WithQueryParameter("SRCA", m3_SRCA.Value.ToString());
			if (m3_SREP.HasValue)
				request.WithQueryParameter("SREP", m3_SREP.Value.ToString());
			if (m3_SREA.HasValue)
				request.WithQueryParameter("SREA", m3_SREA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPUN))
				request.WithQueryParameter("RPUN", m3_RPUN.Trim());
			if (m3_SRBA.HasValue)
				request.WithQueryParameter("SRBA", m3_SRBA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SRSC))
				request.WithQueryParameter("SRSC", m3_SRSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SECW))
				request.WithQueryParameter("SECW", m3_SECW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR1))
				request.WithQueryParameter("PRR1", m3_PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUC1))
				request.WithQueryParameter("CUC1", m3_CUC1.Trim());
			if (m3_SRB2.HasValue)
				request.WithQueryParameter("SRB2", m3_SRB2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SEC2))
				request.WithQueryParameter("SEC2", m3_SEC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGN2))
				request.WithQueryParameter("AGN2", m3_AGN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRR2))
				request.WithQueryParameter("PRR2", m3_PRR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUC2))
				request.WithQueryParameter("CUC2", m3_CUC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCT2))
				request.WithQueryParameter("PCT2", m3_PCT2.Trim());
			if (m3_SRB3.HasValue)
				request.WithQueryParameter("SRB3", m3_SRB3.Value.ToString());
			if (m3_SRE2.HasValue)
				request.WithQueryParameter("SRE2", m3_SRE2.Value.ToString());

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
