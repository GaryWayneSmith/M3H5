/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddHead
		/// Description Add supplier rebate agreement
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3AGRD">Agreement date</param>
		/// <param name="m3PRI2">Priority</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STA3">Status</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3RASR">Agreement reference number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3SRCA">Supplier rebate calculation method</param>
		/// <param name="m3SREP">Rebate percentage</param>
		/// <param name="m3SRBA">Supplier rebate base</param>
		/// <param name="m3SRSC">Supplier rebate scale</param>
		/// <param name="m3SECW">Search criteria - warehouse</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3PC01">Field</param>
		/// <param name="m3PC02">Field</param>
		/// <param name="m3PC03">Field</param>
		/// <param name="m3PC04">Field</param>
		/// <param name="m3PC05">Field</param>
		/// <param name="m3PRR1">Price list</param>
		/// <param name="m3CUC1">Currency</param>
		/// <param name="m3SRB2">Rebate base 2</param>
		/// <param name="m3SEC2">Search criteria - warehouse 2</param>
		/// <param name="m3AGN2">Agreement number 2</param>
		/// <param name="m3PRR2">Price list 2</param>
		/// <param name="m3CUC2">Currency 2</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3PCT2">Costing type 2</param>
		/// <param name="m3SRB3">Margin cost base</param>
		/// <param name="m3SRE2">Guaranteed margin percentage</param>
		/// <param name="m3AGSR">Agreed rebate amount</param>
		/// <param name="m3SRAA">Supplier rebate agreed amount</param>
		/// <param name="m3RAG2">Template Agmnt</param>
		/// <param name="m3CUST">Copy agr values</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddHead(
			string m3RAGN, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			DateTime? m3AGRD = null, 
			int? m3PRI2 = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3STA3 = null, 
			string m3SUNO = null, 
			string m3RASR = null, 
			string m3FACI = null, 
			string m3CUCD = null, 
			string m3ACGR = null, 
			string m3RFID = null, 
			string m3RESP = null, 
			string m3OREF = null, 
			int? m3SRCA = null, 
			decimal? m3SREP = null, 
			int? m3SRBA = null, 
			string m3SRSC = null, 
			string m3SECW = null, 
			string m3AGNB = null, 
			string m3PC01 = null, 
			string m3PC02 = null, 
			string m3PC03 = null, 
			string m3PC04 = null, 
			string m3PC05 = null, 
			string m3PRR1 = null, 
			string m3CUC1 = null, 
			int? m3SRB2 = null, 
			string m3SEC2 = null, 
			string m3AGN2 = null, 
			string m3PRR2 = null, 
			string m3CUC2 = null, 
			string m3PCTP = null, 
			string m3PCT2 = null, 
			int? m3SRB3 = null, 
			decimal? m3SRE2 = null, 
			int? m3AGSR = null, 
			decimal? m3SRAA = null, 
			string m3RAG2 = null, 
			string m3CUST = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RAGN))
				throw new ArgumentNullException(nameof(m3RAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3RAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3AGRD.HasValue)
				request.WithQueryParameter("AGRD", m3AGRD.Value.ToM3String());
			if (m3PRI2.HasValue)
				request.WithQueryParameter("PRI2", m3PRI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STA3))
				request.WithQueryParameter("STA3", m3STA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASR))
				request.WithQueryParameter("RASR", m3RASR.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (m3SRCA.HasValue)
				request.WithQueryParameter("SRCA", m3SRCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SREP.HasValue)
				request.WithQueryParameter("SREP", m3SREP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRBA.HasValue)
				request.WithQueryParameter("SRBA", m3SRBA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SRSC))
				request.WithQueryParameter("SRSC", m3SRSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SECW))
				request.WithQueryParameter("SECW", m3SECW.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC01))
				request.WithQueryParameter("PC01", m3PC01.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC02))
				request.WithQueryParameter("PC02", m3PC02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC03))
				request.WithQueryParameter("PC03", m3PC03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC04))
				request.WithQueryParameter("PC04", m3PC04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC05))
				request.WithQueryParameter("PC05", m3PC05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR1))
				request.WithQueryParameter("PRR1", m3PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUC1))
				request.WithQueryParameter("CUC1", m3CUC1.Trim());
			if (m3SRB2.HasValue)
				request.WithQueryParameter("SRB2", m3SRB2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SEC2))
				request.WithQueryParameter("SEC2", m3SEC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGN2))
				request.WithQueryParameter("AGN2", m3AGN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR2))
				request.WithQueryParameter("PRR2", m3PRR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUC2))
				request.WithQueryParameter("CUC2", m3CUC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCT2))
				request.WithQueryParameter("PCT2", m3PCT2.Trim());
			if (m3SRB3.HasValue)
				request.WithQueryParameter("SRB3", m3SRB3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRE2.HasValue)
				request.WithQueryParameter("SRE2", m3SRE2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGSR.HasValue)
				request.WithQueryParameter("AGSR", m3AGSR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRAA.HasValue)
				request.WithQueryParameter("SRAA", m3SRAA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RAG2))
				request.WithQueryParameter("RAG2", m3RAG2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUST))
				request.WithQueryParameter("CUST", m3CUST.Trim());

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
		/// Name AddLine
		/// Description Add supplier agreement line
		/// Version Release: 
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3SRCA">Rebate calculation method</param>
		/// <param name="m3SREP">Rebate percentage</param>
		/// <param name="m3SREA">Rebate amount</param>
		/// <param name="m3RPUN">Rebate amount unit of measure</param>
		/// <param name="m3SRBA">Rebate base</param>
		/// <param name="m3SRSC">Rebate scale</param>
		/// <param name="m3SECW">Search criteria - warehouse</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3PRR1">Price list</param>
		/// <param name="m3CUC1">Currency</param>
		/// <param name="m3SRB2">Rebate base 2</param>
		/// <param name="m3SEC2">Search criteria - warehouse 2</param>
		/// <param name="m3AGN2">Agreement number 2</param>
		/// <param name="m3PRR2">Price list 2</param>
		/// <param name="m3CUC2">Currency 2</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3PCT2">Costing type 2</param>
		/// <param name="m3SRB3">Margin cost base</param>
		/// <param name="m3SRE2">Guaranteed margin percentage</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLine(
			string m3RAGN, 
			string m3PREX, 
			string m3OBV1, 
			DateTime m3FVDT, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
			DateTime? m3LVDT = null, 
			int? m3SRCA = null, 
			decimal? m3SREP = null, 
			decimal? m3SREA = null, 
			string m3RPUN = null, 
			int? m3SRBA = null, 
			string m3SRSC = null, 
			string m3SECW = null, 
			string m3AGNB = null, 
			string m3PRR1 = null, 
			string m3CUC1 = null, 
			int? m3SRB2 = null, 
			string m3SEC2 = null, 
			string m3AGN2 = null, 
			string m3PRR2 = null, 
			string m3CUC2 = null, 
			string m3PCTP = null, 
			string m3PCT2 = null, 
			int? m3SRB3 = null, 
			decimal? m3SRE2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RAGN))
				throw new ArgumentNullException(nameof(m3RAGN));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3RAGN.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3SRCA.HasValue)
				request.WithQueryParameter("SRCA", m3SRCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SREP.HasValue)
				request.WithQueryParameter("SREP", m3SREP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SREA.HasValue)
				request.WithQueryParameter("SREA", m3SREA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPUN))
				request.WithQueryParameter("RPUN", m3RPUN.Trim());
			if (m3SRBA.HasValue)
				request.WithQueryParameter("SRBA", m3SRBA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SRSC))
				request.WithQueryParameter("SRSC", m3SRSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SECW))
				request.WithQueryParameter("SECW", m3SECW.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR1))
				request.WithQueryParameter("PRR1", m3PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUC1))
				request.WithQueryParameter("CUC1", m3CUC1.Trim());
			if (m3SRB2.HasValue)
				request.WithQueryParameter("SRB2", m3SRB2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SEC2))
				request.WithQueryParameter("SEC2", m3SEC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGN2))
				request.WithQueryParameter("AGN2", m3AGN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR2))
				request.WithQueryParameter("PRR2", m3PRR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUC2))
				request.WithQueryParameter("CUC2", m3CUC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCT2))
				request.WithQueryParameter("PCT2", m3PCT2.Trim());
			if (m3SRB3.HasValue)
				request.WithQueryParameter("SRB3", m3SRB3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRE2.HasValue)
				request.WithQueryParameter("SRE2", m3SRE2.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ConnectAgrValue
		/// Description Connect agr values to supplier rebate agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConnectAgrValue(
			string m3RAGN, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ConnectAgrValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RAGN))
				throw new ArgumentNullException(nameof(m3RAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3RAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());

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
		/// Name DelAgrValues
		/// Description Delete agreement values from supplier rebate agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAgrValues(
			string m3RAGN, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelAgrValues",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RAGN))
				throw new ArgumentNullException(nameof(m3RAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3RAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());

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
		/// Name DelAgreement
		/// Description Delete supplier rebate agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAgreement(
			string m3RAGN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelAgreement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RAGN))
				throw new ArgumentNullException(nameof(m3RAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3RAGN.Trim());

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
		/// Name DelLine
		/// Description Delete a supplier rebate line
		/// Version Release: 
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLine(
			string m3RAGN, 
			string m3PREX, 
			string m3OBV1, 
			DateTime m3FVDT, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RAGN))
				throw new ArgumentNullException(nameof(m3RAGN));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3RAGN.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());

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
		/// Name GetHead
		/// Description Get supplier rebate agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3RAGN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RAGN))
				throw new ArgumentNullException(nameof(m3RAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3RAGN.Trim());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetLine
		/// Description Get suppluer rebate Lines
		/// Version Release: 
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3RAGN, 
			string m3PREX, 
			string m3OBV1, 
			DateTime m3FVDT, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RAGN))
				throw new ArgumentNullException(nameof(m3RAGN));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3RAGN.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());

			// Execute the request
			var result = await Execute<GetLineResponse>(
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
		/// Name LstAgrValByAgr
		/// Description List agreement values supplier rebate agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrValByAgrResponse></returns>
		/// <exception cref="M3Exception<LstAgrValByAgrResponse>"></exception>
		public async Task<M3Response<LstAgrValByAgrResponse>> LstAgrValByAgr(
			string m3RAGN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgrValByAgr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RAGN))
				throw new ArgumentNullException(nameof(m3RAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3RAGN.Trim());

			// Execute the request
			var result = await Execute<LstAgrValByAgrResponse>(
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
		/// Name LstByFacility
		/// Description List supplier rebate agreements by facility
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3STA3">Status</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByFacilityResponse></returns>
		/// <exception cref="M3Exception<LstByFacilityResponse>"></exception>
		public async Task<M3Response<LstByFacilityResponse>> LstByFacility(
			string m3FACI = null, 
			string m3SUNO = null, 
			string m3STA3 = null, 
			DateTime? m3FVDT = null, 
			int? m3NFTR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByFacility",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STA3))
				request.WithQueryParameter("STA3", m3STA3.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByFacilityResponse>(
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
		/// Name LstByStatus
		/// Description List supplier rebate agreements by status
		/// Version Release: 
		/// </summary>
		/// <param name="m3STA3">Status</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByStatusResponse></returns>
		/// <exception cref="M3Exception<LstByStatusResponse>"></exception>
		public async Task<M3Response<LstByStatusResponse>> LstByStatus(
			string m3STA3 = null, 
			string m3SUNO = null, 
			DateTime? m3FVDT = null, 
			int? m3NFTR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByStatus",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STA3))
				request.WithQueryParameter("STA3", m3STA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByStatusResponse>(
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
		/// Name LstBySupAgrRef
		/// Description List supplier rebate agreements by sup agreement reference
		/// Version Release: 
		/// </summary>
		/// <param name="m3RASR">Agreement reference number</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3STA3">Status</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBySupAgrRefResponse></returns>
		/// <exception cref="M3Exception<LstBySupAgrRefResponse>"></exception>
		public async Task<M3Response<LstBySupAgrRefResponse>> LstBySupAgrRef(
			string m3RASR = null, 
			string m3SUNO = null, 
			string m3STA3 = null, 
			DateTime? m3FVDT = null, 
			int? m3NFTR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBySupAgrRef",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RASR))
				request.WithQueryParameter("RASR", m3RASR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STA3))
				request.WithQueryParameter("STA3", m3STA3.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstBySupAgrRefResponse>(
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
		/// Name LstBySupplier
		/// Description List supplier rebate agreements by supplier
		/// Version Release: 
		/// </summary>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3STA3">Status</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBySupplierResponse></returns>
		/// <exception cref="M3Exception<LstBySupplierResponse>"></exception>
		public async Task<M3Response<LstBySupplierResponse>> LstBySupplier(
			string m3SUNO = null, 
			string m3STA3 = null, 
			DateTime? m3FVDT = null, 
			int? m3NFTR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBySupplier",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STA3))
				request.WithQueryParameter("STA3", m3STA3.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstBySupplierResponse>(
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
		/// Name LstHead
		/// Description List supplier rebate agreements
		/// Version Release: 
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadResponse></returns>
		/// <exception cref="M3Exception<LstHeadResponse>"></exception>
		public async Task<M3Response<LstHeadResponse>> LstHead(
			string m3RAGN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RAGN))
				request.WithQueryParameter("RAGN", m3RAGN.Trim());

			// Execute the request
			var result = await Execute<LstHeadResponse>(
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
		/// Name LstLine
		/// Description List supplier agreement lines
		/// Version Release: 
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3PREX">Priority</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3RAGN, 
			string m3PREX = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
			DateTime? m3FVDT = null, 
			int? m3NFTR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RAGN))
				throw new ArgumentNullException(nameof(m3RAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3RAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PREX))
				request.WithQueryParameter("PREX", m3PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
		/// Name UpdHead
		/// Description Update supplier rebate agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3AGRD">Agreement date</param>
		/// <param name="m3PRI2">Priority</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3STA3">Status</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3RASR">Agreement reference number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3RFID">Reference</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3SRCA">Supplier rebate calculation method</param>
		/// <param name="m3SREP">Rebate percentage</param>
		/// <param name="m3SRBA">Supplier rebate base</param>
		/// <param name="m3SRSC">Supplier rebate scale</param>
		/// <param name="m3SECW">Search criteria - warehouse</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3PC01">Field</param>
		/// <param name="m3PC02">Field</param>
		/// <param name="m3PC03">Field</param>
		/// <param name="m3PC04">Field</param>
		/// <param name="m3PC05">Field</param>
		/// <param name="m3PRR1">Price list</param>
		/// <param name="m3CUC1">Currency</param>
		/// <param name="m3SRB2">Rebate base 2</param>
		/// <param name="m3SEC2">Search criteria - warehouse 2</param>
		/// <param name="m3AGN2">Agreement number 2</param>
		/// <param name="m3PRR2">Price list 2</param>
		/// <param name="m3CUC2">Currency</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3PCT2">Costing type 2</param>
		/// <param name="m3SRB3">Margin cost base</param>
		/// <param name="m3SRE2">Guaranteed margin percentage</param>
		/// <param name="m3SRAA">Supplier rebate agreed amount</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHead(
			string m3RAGN, 
			DateTime m3FVDT, 
			DateTime? m3LVDT = null, 
			DateTime? m3AGRD = null, 
			int? m3PRI2 = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3STA3 = null, 
			string m3SUNO = null, 
			string m3RASR = null, 
			string m3FACI = null, 
			string m3ACGR = null, 
			string m3RFID = null, 
			string m3RESP = null, 
			string m3OREF = null, 
			int? m3SRCA = null, 
			decimal? m3SREP = null, 
			int? m3SRBA = null, 
			string m3SRSC = null, 
			string m3SECW = null, 
			string m3AGNB = null, 
			string m3PC01 = null, 
			string m3PC02 = null, 
			string m3PC03 = null, 
			string m3PC04 = null, 
			string m3PC05 = null, 
			string m3PRR1 = null, 
			string m3CUC1 = null, 
			int? m3SRB2 = null, 
			string m3SEC2 = null, 
			string m3AGN2 = null, 
			string m3PRR2 = null, 
			string m3CUC2 = null, 
			string m3PCTP = null, 
			string m3PCT2 = null, 
			int? m3SRB3 = null, 
			decimal? m3SRE2 = null, 
			decimal? m3SRAA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RAGN))
				throw new ArgumentNullException(nameof(m3RAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3RAGN.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3AGRD.HasValue)
				request.WithQueryParameter("AGRD", m3AGRD.Value.ToM3String());
			if (m3PRI2.HasValue)
				request.WithQueryParameter("PRI2", m3PRI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3STA3))
				request.WithQueryParameter("STA3", m3STA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASR))
				request.WithQueryParameter("RASR", m3RASR.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFID))
				request.WithQueryParameter("RFID", m3RFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (m3SRCA.HasValue)
				request.WithQueryParameter("SRCA", m3SRCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SREP.HasValue)
				request.WithQueryParameter("SREP", m3SREP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRBA.HasValue)
				request.WithQueryParameter("SRBA", m3SRBA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SRSC))
				request.WithQueryParameter("SRSC", m3SRSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SECW))
				request.WithQueryParameter("SECW", m3SECW.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC01))
				request.WithQueryParameter("PC01", m3PC01.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC02))
				request.WithQueryParameter("PC02", m3PC02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC03))
				request.WithQueryParameter("PC03", m3PC03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC04))
				request.WithQueryParameter("PC04", m3PC04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC05))
				request.WithQueryParameter("PC05", m3PC05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR1))
				request.WithQueryParameter("PRR1", m3PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUC1))
				request.WithQueryParameter("CUC1", m3CUC1.Trim());
			if (m3SRB2.HasValue)
				request.WithQueryParameter("SRB2", m3SRB2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SEC2))
				request.WithQueryParameter("SEC2", m3SEC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGN2))
				request.WithQueryParameter("AGN2", m3AGN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR2))
				request.WithQueryParameter("PRR2", m3PRR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUC2))
				request.WithQueryParameter("CUC2", m3CUC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCT2))
				request.WithQueryParameter("PCT2", m3PCT2.Trim());
			if (m3SRB3.HasValue)
				request.WithQueryParameter("SRB3", m3SRB3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRE2.HasValue)
				request.WithQueryParameter("SRE2", m3SRE2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRAA.HasValue)
				request.WithQueryParameter("SRAA", m3SRAA.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdLine
		/// Description Update supplier agreement line
		/// Version Release: 
		/// </summary>
		/// <param name="m3RAGN">Supplier rebate agreement on sales (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3FVDT">Valid from (Required)</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3SRCA">Rebate calculation method</param>
		/// <param name="m3SREP">Rebate percentage</param>
		/// <param name="m3SREA">Rebate amount</param>
		/// <param name="m3RPUN">Rebate amount unit of measure</param>
		/// <param name="m3SRBA">Rebate base</param>
		/// <param name="m3SRSC">Rebate scale</param>
		/// <param name="m3SECW">Search criteria - warehouse</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3PRR1">Price list</param>
		/// <param name="m3CUC1">Currency</param>
		/// <param name="m3SRB2">Rebate base 2</param>
		/// <param name="m3SEC2">Search criteria - warehouse 2</param>
		/// <param name="m3AGN2">Agreement number 2</param>
		/// <param name="m3PRR2">Price list 2</param>
		/// <param name="m3CUC2">Currency 2</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m3PCT2">Costing type 2</param>
		/// <param name="m3SRB3">Margin cost base</param>
		/// <param name="m3SRE2">Guaranteed margin percentage</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLine(
			string m3RAGN, 
			string m3PREX, 
			string m3OBV1, 
			DateTime m3FVDT, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			string m3OBV5 = null, 
			DateTime? m3LVDT = null, 
			int? m3SRCA = null, 
			decimal? m3SREP = null, 
			decimal? m3SREA = null, 
			string m3RPUN = null, 
			int? m3SRBA = null, 
			string m3SRSC = null, 
			string m3SECW = null, 
			string m3AGNB = null, 
			string m3PRR1 = null, 
			string m3CUC1 = null, 
			int? m3SRB2 = null, 
			string m3SEC2 = null, 
			string m3AGN2 = null, 
			string m3PRR2 = null, 
			string m3CUC2 = null, 
			string m3PCTP = null, 
			string m3PCT2 = null, 
			int? m3SRB3 = null, 
			decimal? m3SRE2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RAGN))
				throw new ArgumentNullException(nameof(m3RAGN));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("RAGN", m3RAGN.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim())
				.WithQueryParameter("OBV1", m3OBV1.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV5))
				request.WithQueryParameter("OBV5", m3OBV5.Trim());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (m3SRCA.HasValue)
				request.WithQueryParameter("SRCA", m3SRCA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SREP.HasValue)
				request.WithQueryParameter("SREP", m3SREP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SREA.HasValue)
				request.WithQueryParameter("SREA", m3SREA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPUN))
				request.WithQueryParameter("RPUN", m3RPUN.Trim());
			if (m3SRBA.HasValue)
				request.WithQueryParameter("SRBA", m3SRBA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SRSC))
				request.WithQueryParameter("SRSC", m3SRSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SECW))
				request.WithQueryParameter("SECW", m3SECW.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR1))
				request.WithQueryParameter("PRR1", m3PRR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUC1))
				request.WithQueryParameter("CUC1", m3CUC1.Trim());
			if (m3SRB2.HasValue)
				request.WithQueryParameter("SRB2", m3SRB2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SEC2))
				request.WithQueryParameter("SEC2", m3SEC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGN2))
				request.WithQueryParameter("AGN2", m3AGN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRR2))
				request.WithQueryParameter("PRR2", m3PRR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUC2))
				request.WithQueryParameter("CUC2", m3CUC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCT2))
				request.WithQueryParameter("PCT2", m3PCT2.Trim());
			if (m3SRB3.HasValue)
				request.WithQueryParameter("SRB3", m3SRB3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRE2.HasValue)
				request.WithQueryParameter("SRE2", m3SRE2.Value.ToString(CultureInfo.CurrentCulture));

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
