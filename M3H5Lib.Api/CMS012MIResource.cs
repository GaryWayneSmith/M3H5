/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
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
	/// Name: CMS012MI
	/// Component Name: InfoBrowser
	/// Description: Api: Information browser cat - virtual fields
	/// Version Release: 5ea1
	///</summary>
	public partial class CMS012MIResource : M3BaseResourceEndpoint
	{
		public CMS012MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS012MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCalcVal
		/// Description Add value calculated by formula
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_VIFL">Virtual field (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_CASQ">Calculation sequence</param>
		/// <param name="m3_FLDT">Field type</param>
		/// <param name="m3_FLDB">Field length</param>
		/// <param name="m3_FLDP">Number of decimal places</param>
		/// <param name="m3_FDCA">Field information code</param>
		/// <param name="m3_OP01">Operand</param>
		/// <param name="m3_OP02">Operand</param>
		/// <param name="m3_OP03">Operand</param>
		/// <param name="m3_OP04">Operand</param>
		/// <param name="m3_OP05">Operand</param>
		/// <param name="m3_OP06">Operand</param>
		/// <param name="m3_OP07">Operand</param>
		/// <param name="m3_OP08">Operand</param>
		/// <param name="m3_OP09">Operand</param>
		/// <param name="m3_OP10">Operand</param>
		/// <param name="m3_OB01">Field</param>
		/// <param name="m3_OB02">Field</param>
		/// <param name="m3_OB03">Field</param>
		/// <param name="m3_OB04">Field</param>
		/// <param name="m3_OB05">Field</param>
		/// <param name="m3_OB06">Field</param>
		/// <param name="m3_OB07">Field</param>
		/// <param name="m3_OB08">Field</param>
		/// <param name="m3_OB09">Field</param>
		/// <param name="m3_OB10">Field</param>
		/// <param name="m3_FA01">Factor</param>
		/// <param name="m3_FA02">Factor</param>
		/// <param name="m3_FA03">Factor</param>
		/// <param name="m3_FA04">Factor</param>
		/// <param name="m3_FA05">Factor</param>
		/// <param name="m3_FA06">Factor</param>
		/// <param name="m3_FA07">Factor</param>
		/// <param name="m3_FA08">Factor</param>
		/// <param name="m3_FA09">Factor</param>
		/// <param name="m3_FA10">Factor</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCalcVal(
			string m3_IBCA, 
			string m3_VIFL, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_MSID = null, 
			int? m3_CASQ = null, 
			string m3_FLDT = null, 
			int? m3_FLDB = null, 
			int? m3_FLDP = null, 
			string m3_FDCA = null, 
			string m3_OP01 = null, 
			string m3_OP02 = null, 
			string m3_OP03 = null, 
			string m3_OP04 = null, 
			string m3_OP05 = null, 
			string m3_OP06 = null, 
			string m3_OP07 = null, 
			string m3_OP08 = null, 
			string m3_OP09 = null, 
			string m3_OP10 = null, 
			string m3_OB01 = null, 
			string m3_OB02 = null, 
			string m3_OB03 = null, 
			string m3_OB04 = null, 
			string m3_OB05 = null, 
			string m3_OB06 = null, 
			string m3_OB07 = null, 
			string m3_OB08 = null, 
			string m3_OB09 = null, 
			string m3_OB10 = null, 
			decimal? m3_FA01 = null, 
			decimal? m3_FA02 = null, 
			decimal? m3_FA03 = null, 
			decimal? m3_FA04 = null, 
			decimal? m3_FA05 = null, 
			decimal? m3_FA06 = null, 
			decimal? m3_FA07 = null, 
			decimal? m3_FA08 = null, 
			decimal? m3_FA09 = null, 
			decimal? m3_FA10 = null, 
			int? m3_RPBK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCalcVal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_VIFL))
				throw new ArgumentNullException("m3_VIFL");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("VIFL", m3_VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (m3_CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3_CASQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLDT))
				request.WithQueryParameter("FLDT", m3_FLDT.Trim());
			if (m3_FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3_FLDB.Value.ToString());
			if (m3_FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3_FLDP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDCA))
				request.WithQueryParameter("FDCA", m3_FDCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OP01))
				request.WithQueryParameter("OP01", m3_OP01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OP02))
				request.WithQueryParameter("OP02", m3_OP02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OP03))
				request.WithQueryParameter("OP03", m3_OP03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OP04))
				request.WithQueryParameter("OP04", m3_OP04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OP05))
				request.WithQueryParameter("OP05", m3_OP05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OP06))
				request.WithQueryParameter("OP06", m3_OP06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OP07))
				request.WithQueryParameter("OP07", m3_OP07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OP08))
				request.WithQueryParameter("OP08", m3_OP08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OP09))
				request.WithQueryParameter("OP09", m3_OP09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OP10))
				request.WithQueryParameter("OP10", m3_OP10.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_OB07))
				request.WithQueryParameter("OB07", m3_OB07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB08))
				request.WithQueryParameter("OB08", m3_OB08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB09))
				request.WithQueryParameter("OB09", m3_OB09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB10))
				request.WithQueryParameter("OB10", m3_OB10.Trim());
			if (m3_FA01.HasValue)
				request.WithQueryParameter("FA01", m3_FA01.Value.ToString());
			if (m3_FA02.HasValue)
				request.WithQueryParameter("FA02", m3_FA02.Value.ToString());
			if (m3_FA03.HasValue)
				request.WithQueryParameter("FA03", m3_FA03.Value.ToString());
			if (m3_FA04.HasValue)
				request.WithQueryParameter("FA04", m3_FA04.Value.ToString());
			if (m3_FA05.HasValue)
				request.WithQueryParameter("FA05", m3_FA05.Value.ToString());
			if (m3_FA06.HasValue)
				request.WithQueryParameter("FA06", m3_FA06.Value.ToString());
			if (m3_FA07.HasValue)
				request.WithQueryParameter("FA07", m3_FA07.Value.ToString());
			if (m3_FA08.HasValue)
				request.WithQueryParameter("FA08", m3_FA08.Value.ToString());
			if (m3_FA09.HasValue)
				request.WithQueryParameter("FA09", m3_FA09.Value.ToString());
			if (m3_FA10.HasValue)
				request.WithQueryParameter("FA10", m3_FA10.Value.ToString());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());

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
		/// Name AddCurrConv
		/// Description Add value from a currency conversion
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_VIFL">Virtual field (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_CASQ">Calculation sequence</param>
		/// <param name="m3_FLDT">Field type</param>
		/// <param name="m3_FLDB">Field length</param>
		/// <param name="m3_FLDP">Number of decimal places</param>
		/// <param name="m3_FDCA">Field information code</param>
		/// <param name="m3_RO01">Read option</param>
		/// <param name="m3_RO02">Read option</param>
		/// <param name="m3_RO03">Read option</param>
		/// <param name="m3_RO04">Read option</param>
		/// <param name="m3_RO05">Read option</param>
		/// <param name="m3_OB01">Field</param>
		/// <param name="m3_OB02">Field</param>
		/// <param name="m3_OB03">Field</param>
		/// <param name="m3_OB04">Field</param>
		/// <param name="m3_OB05">Field</param>
		/// <param name="m3_OB06">Field</param>
		/// <param name="m3_VAL1">Value field</param>
		/// <param name="m3_VAL2">Value field</param>
		/// <param name="m3_VAL3">Value field</param>
		/// <param name="m3_VAL4">Value field</param>
		/// <param name="m3_VAL5">Value field</param>
		/// <param name="m3_BADT">Base date</param>
		/// <param name="m3_CALD">Calculation date</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCurrConv(
			string m3_IBCA, 
			string m3_VIFL, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_MSID = null, 
			int? m3_CASQ = null, 
			string m3_FLDT = null, 
			int? m3_FLDB = null, 
			int? m3_FLDP = null, 
			string m3_FDCA = null, 
			int? m3_RO01 = null, 
			int? m3_RO02 = null, 
			int? m3_RO03 = null, 
			int? m3_RO04 = null, 
			int? m3_RO05 = null, 
			string m3_OB01 = null, 
			string m3_OB02 = null, 
			string m3_OB03 = null, 
			string m3_OB04 = null, 
			string m3_OB05 = null, 
			string m3_OB06 = null, 
			string m3_VAL1 = null, 
			string m3_VAL2 = null, 
			string m3_VAL3 = null, 
			string m3_VAL4 = null, 
			string m3_VAL5 = null, 
			DateTime? m3_BADT = null, 
			DateTime? m3_CALD = null, 
			int? m3_RPBK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCurrConv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_VIFL))
				throw new ArgumentNullException("m3_VIFL");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("VIFL", m3_VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (m3_CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3_CASQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLDT))
				request.WithQueryParameter("FLDT", m3_FLDT.Trim());
			if (m3_FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3_FLDB.Value.ToString());
			if (m3_FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3_FLDP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDCA))
				request.WithQueryParameter("FDCA", m3_FDCA.Trim());
			if (m3_RO01.HasValue)
				request.WithQueryParameter("RO01", m3_RO01.Value.ToString());
			if (m3_RO02.HasValue)
				request.WithQueryParameter("RO02", m3_RO02.Value.ToString());
			if (m3_RO03.HasValue)
				request.WithQueryParameter("RO03", m3_RO03.Value.ToString());
			if (m3_RO04.HasValue)
				request.WithQueryParameter("RO04", m3_RO04.Value.ToString());
			if (m3_RO05.HasValue)
				request.WithQueryParameter("RO05", m3_RO05.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_VAL4))
				request.WithQueryParameter("VAL4", m3_VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL5))
				request.WithQueryParameter("VAL5", m3_VAL5.Trim());
			if (m3_BADT.HasValue)
				request.WithQueryParameter("BADT", m3_BADT.Value.ToM3String());
			if (m3_CALD.HasValue)
				request.WithQueryParameter("CALD", m3_CALD.Value.ToM3String());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());

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
		/// Name AddDate
		/// Description Add date field
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_VIFL">Virtual field (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_CASQ">Calculation sequence</param>
		/// <param name="m3_FLDT">Field type</param>
		/// <param name="m3_FLDB">Field length</param>
		/// <param name="m3_FLDP">Number of decimal places</param>
		/// <param name="m3_BADT">Base date</param>
		/// <param name="m3_DAYA">Day adjustment</param>
		/// <param name="m3_DTOU">Date output</param>
		/// <param name="m3_OB01">Field</param>
		/// <param name="m3_CALD">Calculation date</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDate(
			string m3_IBCA, 
			string m3_VIFL, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_MSID = null, 
			int? m3_CASQ = null, 
			string m3_FLDT = null, 
			int? m3_FLDB = null, 
			int? m3_FLDP = null, 
			DateTime? m3_BADT = null, 
			int? m3_DAYA = null, 
			int? m3_DTOU = null, 
			string m3_OB01 = null, 
			DateTime? m3_CALD = null, 
			int? m3_RPBK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_VIFL))
				throw new ArgumentNullException("m3_VIFL");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("VIFL", m3_VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (m3_CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3_CASQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLDT))
				request.WithQueryParameter("FLDT", m3_FLDT.Trim());
			if (m3_FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3_FLDB.Value.ToString());
			if (m3_FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3_FLDP.Value.ToString());
			if (m3_BADT.HasValue)
				request.WithQueryParameter("BADT", m3_BADT.Value.ToM3String());
			if (m3_DAYA.HasValue)
				request.WithQueryParameter("DAYA", m3_DAYA.Value.ToString());
			if (m3_DTOU.HasValue)
				request.WithQueryParameter("DTOU", m3_DTOU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OB01))
				request.WithQueryParameter("OB01", m3_OB01.Trim());
			if (m3_CALD.HasValue)
				request.WithQueryParameter("CALD", m3_CALD.Value.ToM3String());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());

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
		/// Name AddLogicFormula
		/// Description Add value from a logic formula
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_VIFL">Virtual field (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_CASQ">Calculation sequence</param>
		/// <param name="m3_FLDT">Field type</param>
		/// <param name="m3_FLDB">Field length</param>
		/// <param name="m3_LOT1">Logical type</param>
		/// <param name="m3_LOT2">Logical type</param>
		/// <param name="m3_LOT3">Logical type</param>
		/// <param name="m3_ADO1">And/or</param>
		/// <param name="m3_ADO2">And/or</param>
		/// <param name="m3_OB01">Field</param>
		/// <param name="m3_OB02">Field</param>
		/// <param name="m3_OB03">Field</param>
		/// <param name="m3_OB04">Field</param>
		/// <param name="m3_OB05">Field</param>
		/// <param name="m3_OB06">Field</param>
		/// <param name="m3_OB07">Field</param>
		/// <param name="m3_OB08">Field</param>
		/// <param name="m3_COD1">Condition</param>
		/// <param name="m3_COD2">Condition</param>
		/// <param name="m3_COD3">Condition</param>
		/// <param name="m3_OPR1">Operand</param>
		/// <param name="m3_OPR2">Operand</param>
		/// <param name="m3_OPR3">Operand</param>
		/// <param name="m3_VAL1">Value field</param>
		/// <param name="m3_VAL2">Value field</param>
		/// <param name="m3_VAL3">Value field</param>
		/// <param name="m3_VAL4">Value field</param>
		/// <param name="m3_VAL5">Value field</param>
		/// <param name="m3_VTRU">Value if true</param>
		/// <param name="m3_VFAL">Value if false</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="m3_FLDP">Number of decimal places</param>
		/// <param name="m3_FDCA">Field information code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLogicFormula(
			string m3_IBCA, 
			string m3_VIFL, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_MSID = null, 
			int? m3_CASQ = null, 
			string m3_FLDT = null, 
			int? m3_FLDB = null, 
			string m3_LOT1 = null, 
			string m3_LOT2 = null, 
			string m3_LOT3 = null, 
			int? m3_ADO1 = null, 
			int? m3_ADO2 = null, 
			string m3_OB01 = null, 
			string m3_OB02 = null, 
			string m3_OB03 = null, 
			string m3_OB04 = null, 
			string m3_OB05 = null, 
			string m3_OB06 = null, 
			string m3_OB07 = null, 
			string m3_OB08 = null, 
			int? m3_COD1 = null, 
			int? m3_COD2 = null, 
			int? m3_COD3 = null, 
			int? m3_OPR1 = null, 
			int? m3_OPR2 = null, 
			int? m3_OPR3 = null, 
			string m3_VAL1 = null, 
			string m3_VAL2 = null, 
			string m3_VAL3 = null, 
			string m3_VAL4 = null, 
			string m3_VAL5 = null, 
			int? m3_VTRU = null, 
			int? m3_VFAL = null, 
			int? m3_RPBK = null, 
			int? m3_FLDP = null, 
			string m3_FDCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLogicFormula",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_VIFL))
				throw new ArgumentNullException("m3_VIFL");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("VIFL", m3_VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (m3_CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3_CASQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLDT))
				request.WithQueryParameter("FLDT", m3_FLDT.Trim());
			if (m3_FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3_FLDB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LOT1))
				request.WithQueryParameter("LOT1", m3_LOT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOT2))
				request.WithQueryParameter("LOT2", m3_LOT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOT3))
				request.WithQueryParameter("LOT3", m3_LOT3.Trim());
			if (m3_ADO1.HasValue)
				request.WithQueryParameter("ADO1", m3_ADO1.Value.ToString());
			if (m3_ADO2.HasValue)
				request.WithQueryParameter("ADO2", m3_ADO2.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_OB07))
				request.WithQueryParameter("OB07", m3_OB07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB08))
				request.WithQueryParameter("OB08", m3_OB08.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_VAL1))
				request.WithQueryParameter("VAL1", m3_VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL2))
				request.WithQueryParameter("VAL2", m3_VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL3))
				request.WithQueryParameter("VAL3", m3_VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL4))
				request.WithQueryParameter("VAL4", m3_VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL5))
				request.WithQueryParameter("VAL5", m3_VAL5.Trim());
			if (m3_VTRU.HasValue)
				request.WithQueryParameter("VTRU", m3_VTRU.Value.ToString());
			if (m3_VFAL.HasValue)
				request.WithQueryParameter("VFAL", m3_VFAL.Value.ToString());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());
			if (m3_FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3_FLDP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDCA))
				request.WithQueryParameter("FDCA", m3_FDCA.Trim());

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
		/// Name AddPreDefined
		/// Description Add value retrieved by a function program
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_VIFL">Virtual field (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_CASQ">Calculation sequence</param>
		/// <param name="m3_FLDT">Field type</param>
		/// <param name="m3_FLDB">Field length</param>
		/// <param name="m3_VIPD">Pre-defined value</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="m3_FLDP">Number of decimal places</param>
		/// <param name="m3_FDCA">Field information code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPreDefined(
			string m3_IBCA, 
			string m3_VIFL, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_MSID = null, 
			int? m3_CASQ = null, 
			string m3_FLDT = null, 
			int? m3_FLDB = null, 
			int? m3_VIPD = null, 
			int? m3_RPBK = null, 
			int? m3_FLDP = null, 
			string m3_FDCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPreDefined",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_VIFL))
				throw new ArgumentNullException("m3_VIFL");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("VIFL", m3_VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (m3_CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3_CASQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLDT))
				request.WithQueryParameter("FLDT", m3_FLDT.Trim());
			if (m3_FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3_FLDB.Value.ToString());
			if (m3_VIPD.HasValue)
				request.WithQueryParameter("VIPD", m3_VIPD.Value.ToString());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());
			if (m3_FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3_FLDP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDCA))
				request.WithQueryParameter("FDCA", m3_FDCA.Trim());

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
		/// Name AddTX15FrCSYTAB
		/// Description Add value from name field in CSYTAB
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_VIFL">Virtual field (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_CASQ">Calculation sequence</param>
		/// <param name="m3_KEY1">Key field</param>
		/// <param name="m3_KEY2">Key field</param>
		/// <param name="m3_KEY3">Key field</param>
		/// <param name="m3_KEY4">Key field</param>
		/// <param name="m3_KEY5">Key field</param>
		/// <param name="m3_RO01">Read option</param>
		/// <param name="m3_RO02">Read option</param>
		/// <param name="m3_RO03">Read option</param>
		/// <param name="m3_RO04">Read option</param>
		/// <param name="m3_RO05">Read option</param>
		/// <param name="m3_OB01">Field</param>
		/// <param name="m3_OB02">Field</param>
		/// <param name="m3_OB03">Field</param>
		/// <param name="m3_OB04">Field</param>
		/// <param name="m3_OB05">Field</param>
		/// <param name="m3_VAL1">Value field</param>
		/// <param name="m3_VAL2">Value field</param>
		/// <param name="m3_VAL3">Value field</param>
		/// <param name="m3_VAL4">Value field</param>
		/// <param name="m3_VAL5">Value field</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTX15FrCSYTAB(
			string m3_IBCA, 
			string m3_VIFL, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_MSID = null, 
			int? m3_CASQ = null, 
			string m3_KEY1 = null, 
			string m3_KEY2 = null, 
			string m3_KEY3 = null, 
			string m3_KEY4 = null, 
			string m3_KEY5 = null, 
			int? m3_RO01 = null, 
			int? m3_RO02 = null, 
			int? m3_RO03 = null, 
			int? m3_RO04 = null, 
			int? m3_RO05 = null, 
			string m3_OB01 = null, 
			string m3_OB02 = null, 
			string m3_OB03 = null, 
			string m3_OB04 = null, 
			string m3_OB05 = null, 
			string m3_VAL1 = null, 
			string m3_VAL2 = null, 
			string m3_VAL3 = null, 
			string m3_VAL4 = null, 
			string m3_VAL5 = null, 
			int? m3_RPBK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTX15FrCSYTAB",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_VIFL))
				throw new ArgumentNullException("m3_VIFL");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("VIFL", m3_VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (m3_CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3_CASQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_KEY1))
				request.WithQueryParameter("KEY1", m3_KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY2))
				request.WithQueryParameter("KEY2", m3_KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY3))
				request.WithQueryParameter("KEY3", m3_KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY4))
				request.WithQueryParameter("KEY4", m3_KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY5))
				request.WithQueryParameter("KEY5", m3_KEY5.Trim());
			if (m3_RO01.HasValue)
				request.WithQueryParameter("RO01", m3_RO01.Value.ToString());
			if (m3_RO02.HasValue)
				request.WithQueryParameter("RO02", m3_RO02.Value.ToString());
			if (m3_RO03.HasValue)
				request.WithQueryParameter("RO03", m3_RO03.Value.ToString());
			if (m3_RO04.HasValue)
				request.WithQueryParameter("RO04", m3_RO04.Value.ToString());
			if (m3_RO05.HasValue)
				request.WithQueryParameter("RO05", m3_RO05.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_VAL1))
				request.WithQueryParameter("VAL1", m3_VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL2))
				request.WithQueryParameter("VAL2", m3_VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL3))
				request.WithQueryParameter("VAL3", m3_VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL4))
				request.WithQueryParameter("VAL4", m3_VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL5))
				request.WithQueryParameter("VAL5", m3_VAL5.Trim());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());

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
		/// Name AddTX40FrCSYTAB
		/// Description Add value from description field in CSYTAB
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_VIFL">Virtual field (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_CASQ">Calculation sequence</param>
		/// <param name="m3_KEY1">Key field</param>
		/// <param name="m3_KEY2">Key field</param>
		/// <param name="m3_KEY3">Key field</param>
		/// <param name="m3_KEY4">Key field</param>
		/// <param name="m3_KEY5">Key field</param>
		/// <param name="m3_RO01">Read option</param>
		/// <param name="m3_RO02">Read option</param>
		/// <param name="m3_RO03">Read option</param>
		/// <param name="m3_RO04">Read option</param>
		/// <param name="m3_RO05">Read option</param>
		/// <param name="m3_OB01">Field</param>
		/// <param name="m3_OB02">Field</param>
		/// <param name="m3_OB03">Field</param>
		/// <param name="m3_OB04">Field</param>
		/// <param name="m3_OB05">Field</param>
		/// <param name="m3_VAL1">Value field</param>
		/// <param name="m3_VAL2">Value field</param>
		/// <param name="m3_VAL3">Value field</param>
		/// <param name="m3_VAL4">Value field</param>
		/// <param name="m3_VAL5">Value field</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTX40FrCSYTAB(
			string m3_IBCA, 
			string m3_VIFL, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_MSID = null, 
			int? m3_CASQ = null, 
			string m3_KEY1 = null, 
			string m3_KEY2 = null, 
			string m3_KEY3 = null, 
			string m3_KEY4 = null, 
			string m3_KEY5 = null, 
			int? m3_RO01 = null, 
			int? m3_RO02 = null, 
			int? m3_RO03 = null, 
			int? m3_RO04 = null, 
			int? m3_RO05 = null, 
			string m3_OB01 = null, 
			string m3_OB02 = null, 
			string m3_OB03 = null, 
			string m3_OB04 = null, 
			string m3_OB05 = null, 
			string m3_VAL1 = null, 
			string m3_VAL2 = null, 
			string m3_VAL3 = null, 
			string m3_VAL4 = null, 
			string m3_VAL5 = null, 
			int? m3_RPBK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTX40FrCSYTAB",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_VIFL))
				throw new ArgumentNullException("m3_VIFL");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("VIFL", m3_VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (m3_CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3_CASQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_KEY1))
				request.WithQueryParameter("KEY1", m3_KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY2))
				request.WithQueryParameter("KEY2", m3_KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY3))
				request.WithQueryParameter("KEY3", m3_KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY4))
				request.WithQueryParameter("KEY4", m3_KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KEY5))
				request.WithQueryParameter("KEY5", m3_KEY5.Trim());
			if (m3_RO01.HasValue)
				request.WithQueryParameter("RO01", m3_RO01.Value.ToString());
			if (m3_RO02.HasValue)
				request.WithQueryParameter("RO02", m3_RO02.Value.ToString());
			if (m3_RO03.HasValue)
				request.WithQueryParameter("RO03", m3_RO03.Value.ToString());
			if (m3_RO04.HasValue)
				request.WithQueryParameter("RO04", m3_RO04.Value.ToString());
			if (m3_RO05.HasValue)
				request.WithQueryParameter("RO05", m3_RO05.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_VAL1))
				request.WithQueryParameter("VAL1", m3_VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL2))
				request.WithQueryParameter("VAL2", m3_VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL3))
				request.WithQueryParameter("VAL3", m3_VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL4))
				request.WithQueryParameter("VAL4", m3_VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL5))
				request.WithQueryParameter("VAL5", m3_VAL5.Trim());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());

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
		/// Name DelVirtualField
		/// Description Delete virtual field
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_VIFL">Virtual field (Required)</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelVirtualField(
			string m3_IBCA, 
			string m3_VIFL, 
			int? m3_RPBK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelVirtualField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_VIFL))
				throw new ArgumentNullException("m3_VIFL");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("VIFL", m3_VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());

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
		/// Name MergeData
		/// Description Add  Merge Data information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="m3_VIFL">Virtual field</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_CASQ">Calculation sequence</param>
		/// <param name="m3_FLDT">Field type</param>
		/// <param name="m3_FLDB">Field length</param>
		/// <param name="m3_FLDP">Number of decimal places</param>
		/// <param name="m3_BDA1">Base for data</param>
		/// <param name="m3_BDA2">Base for data</param>
		/// <param name="m3_BDA3">Base for data</param>
		/// <param name="m3_BDA4">Base for data</param>
		/// <param name="m3_BDA5">Base for data</param>
		/// <param name="m3_FLL1">Field length</param>
		/// <param name="m3_FLL2">Field length</param>
		/// <param name="m3_FLL3">Field length</param>
		/// <param name="m3_FLL4">Field length</param>
		/// <param name="m3_FLL5">Field length</param>
		/// <param name="m3_OB01">Field</param>
		/// <param name="m3_OB02">Field</param>
		/// <param name="m3_OB03">Field</param>
		/// <param name="m3_OB04">Field</param>
		/// <param name="m3_OB05">Field</param>
		/// <param name="m3_FI01">File</param>
		/// <param name="m3_FI02">File</param>
		/// <param name="m3_FI03">File</param>
		/// <param name="m3_FI04">File</param>
		/// <param name="m3_FI05">File</param>
		/// <param name="m3_VAL1">Value field</param>
		/// <param name="m3_VAL2">Value field</param>
		/// <param name="m3_VAL3">Value field</param>
		/// <param name="m3_VAL4">Value field</param>
		/// <param name="m3_VAL5">Value field</param>
		/// <param name="m3_SEP1">Field separator</param>
		/// <param name="m3_SEP2">Field separator</param>
		/// <param name="m3_SEP3">Field separator</param>
		/// <param name="m3_SEP4">Field separator</param>
		/// <param name="m3_SEP5">Field separator</param>
		/// <param name="m3_BAD1">Add blank</param>
		/// <param name="m3_BAD2">Add blank</param>
		/// <param name="m3_BAD3">Add blank</param>
		/// <param name="m3_BAD4">Add blank</param>
		/// <param name="m3_BAD5">Add blank</param>
		/// <param name="m3_DFO1">Decimal format</param>
		/// <param name="m3_DFO2">Decimal format</param>
		/// <param name="m3_DFO3">Decimal format</param>
		/// <param name="m3_DFO4">Decimal format</param>
		/// <param name="m3_DFO5">Decimal format</param>
		/// <param name="m3_TRM1">Trim zeroes</param>
		/// <param name="m3_TRM2">Trim zeroes</param>
		/// <param name="m3_TRM3">Trim zeroes</param>
		/// <param name="m3_TRM4">Trim zeroes</param>
		/// <param name="m3_TRM5">Trim zeroes</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="m3_DTF1">Date format</param>
		/// <param name="m3_DTF2">Date format</param>
		/// <param name="m3_DTF3">Date format</param>
		/// <param name="m3_DTF4">Date format</param>
		/// <param name="m3_DTF5">Date format</param>
		/// <param name="m3_EDI1">Date editing</param>
		/// <param name="m3_EDI2">Date editing</param>
		/// <param name="m3_EDI3">Date editing</param>
		/// <param name="m3_EDI4">Date editing</param>
		/// <param name="m3_EDI5">Date editing</param>
		/// <param name="m3_ZES1">Zero supress</param>
		/// <param name="m3_ZES2">Zero supress</param>
		/// <param name="m3_ZES3">Zero supress</param>
		/// <param name="m3_ZES4">Zero supress</param>
		/// <param name="m3_ZES5">Zero supress</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MergeData(
			string m3_IBCA = null, 
			string m3_VIFL = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_MSID = null, 
			int? m3_CASQ = null, 
			string m3_FLDT = null, 
			int? m3_FLDB = null, 
			int? m3_FLDP = null, 
			int? m3_BDA1 = null, 
			int? m3_BDA2 = null, 
			int? m3_BDA3 = null, 
			int? m3_BDA4 = null, 
			int? m3_BDA5 = null, 
			int? m3_FLL1 = null, 
			int? m3_FLL2 = null, 
			int? m3_FLL3 = null, 
			int? m3_FLL4 = null, 
			int? m3_FLL5 = null, 
			string m3_OB01 = null, 
			string m3_OB02 = null, 
			string m3_OB03 = null, 
			string m3_OB04 = null, 
			string m3_OB05 = null, 
			string m3_FI01 = null, 
			string m3_FI02 = null, 
			string m3_FI03 = null, 
			string m3_FI04 = null, 
			string m3_FI05 = null, 
			string m3_VAL1 = null, 
			string m3_VAL2 = null, 
			string m3_VAL3 = null, 
			string m3_VAL4 = null, 
			string m3_VAL5 = null, 
			string m3_SEP1 = null, 
			string m3_SEP2 = null, 
			string m3_SEP3 = null, 
			string m3_SEP4 = null, 
			string m3_SEP5 = null, 
			int? m3_BAD1 = null, 
			int? m3_BAD2 = null, 
			int? m3_BAD3 = null, 
			int? m3_BAD4 = null, 
			int? m3_BAD5 = null, 
			string m3_DFO1 = null, 
			string m3_DFO2 = null, 
			string m3_DFO3 = null, 
			string m3_DFO4 = null, 
			string m3_DFO5 = null, 
			int? m3_TRM1 = null, 
			int? m3_TRM2 = null, 
			int? m3_TRM3 = null, 
			int? m3_TRM4 = null, 
			int? m3_TRM5 = null, 
			int? m3_RPBK = null, 
			string m3_DTF1 = null, 
			string m3_DTF2 = null, 
			string m3_DTF3 = null, 
			string m3_DTF4 = null, 
			string m3_DTF5 = null, 
			string m3_EDI1 = null, 
			string m3_EDI2 = null, 
			string m3_EDI3 = null, 
			string m3_EDI4 = null, 
			string m3_EDI5 = null, 
			int? m3_ZES1 = null, 
			int? m3_ZES2 = null, 
			int? m3_ZES3 = null, 
			int? m3_ZES4 = null, 
			int? m3_ZES5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/MergeData",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VIFL))
				request.WithQueryParameter("VIFL", m3_VIFL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (m3_CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3_CASQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLDT))
				request.WithQueryParameter("FLDT", m3_FLDT.Trim());
			if (m3_FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3_FLDB.Value.ToString());
			if (m3_FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3_FLDP.Value.ToString());
			if (m3_BDA1.HasValue)
				request.WithQueryParameter("BDA1", m3_BDA1.Value.ToString());
			if (m3_BDA2.HasValue)
				request.WithQueryParameter("BDA2", m3_BDA2.Value.ToString());
			if (m3_BDA3.HasValue)
				request.WithQueryParameter("BDA3", m3_BDA3.Value.ToString());
			if (m3_BDA4.HasValue)
				request.WithQueryParameter("BDA4", m3_BDA4.Value.ToString());
			if (m3_BDA5.HasValue)
				request.WithQueryParameter("BDA5", m3_BDA5.Value.ToString());
			if (m3_FLL1.HasValue)
				request.WithQueryParameter("FLL1", m3_FLL1.Value.ToString());
			if (m3_FLL2.HasValue)
				request.WithQueryParameter("FLL2", m3_FLL2.Value.ToString());
			if (m3_FLL3.HasValue)
				request.WithQueryParameter("FLL3", m3_FLL3.Value.ToString());
			if (m3_FLL4.HasValue)
				request.WithQueryParameter("FLL4", m3_FLL4.Value.ToString());
			if (m3_FLL5.HasValue)
				request.WithQueryParameter("FLL5", m3_FLL5.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_FI01))
				request.WithQueryParameter("FI01", m3_FI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI02))
				request.WithQueryParameter("FI02", m3_FI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI03))
				request.WithQueryParameter("FI03", m3_FI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI04))
				request.WithQueryParameter("FI04", m3_FI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI05))
				request.WithQueryParameter("FI05", m3_FI05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL1))
				request.WithQueryParameter("VAL1", m3_VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL2))
				request.WithQueryParameter("VAL2", m3_VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL3))
				request.WithQueryParameter("VAL3", m3_VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL4))
				request.WithQueryParameter("VAL4", m3_VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL5))
				request.WithQueryParameter("VAL5", m3_VAL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEP1))
				request.WithQueryParameter("SEP1", m3_SEP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEP2))
				request.WithQueryParameter("SEP2", m3_SEP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEP3))
				request.WithQueryParameter("SEP3", m3_SEP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEP4))
				request.WithQueryParameter("SEP4", m3_SEP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SEP5))
				request.WithQueryParameter("SEP5", m3_SEP5.Trim());
			if (m3_BAD1.HasValue)
				request.WithQueryParameter("BAD1", m3_BAD1.Value.ToString());
			if (m3_BAD2.HasValue)
				request.WithQueryParameter("BAD2", m3_BAD2.Value.ToString());
			if (m3_BAD3.HasValue)
				request.WithQueryParameter("BAD3", m3_BAD3.Value.ToString());
			if (m3_BAD4.HasValue)
				request.WithQueryParameter("BAD4", m3_BAD4.Value.ToString());
			if (m3_BAD5.HasValue)
				request.WithQueryParameter("BAD5", m3_BAD5.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DFO1))
				request.WithQueryParameter("DFO1", m3_DFO1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DFO2))
				request.WithQueryParameter("DFO2", m3_DFO2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DFO3))
				request.WithQueryParameter("DFO3", m3_DFO3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DFO4))
				request.WithQueryParameter("DFO4", m3_DFO4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DFO5))
				request.WithQueryParameter("DFO5", m3_DFO5.Trim());
			if (m3_TRM1.HasValue)
				request.WithQueryParameter("TRM1", m3_TRM1.Value.ToString());
			if (m3_TRM2.HasValue)
				request.WithQueryParameter("TRM2", m3_TRM2.Value.ToString());
			if (m3_TRM3.HasValue)
				request.WithQueryParameter("TRM3", m3_TRM3.Value.ToString());
			if (m3_TRM4.HasValue)
				request.WithQueryParameter("TRM4", m3_TRM4.Value.ToString());
			if (m3_TRM5.HasValue)
				request.WithQueryParameter("TRM5", m3_TRM5.Value.ToString());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DTF1))
				request.WithQueryParameter("DTF1", m3_DTF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DTF2))
				request.WithQueryParameter("DTF2", m3_DTF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DTF3))
				request.WithQueryParameter("DTF3", m3_DTF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DTF4))
				request.WithQueryParameter("DTF4", m3_DTF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DTF5))
				request.WithQueryParameter("DTF5", m3_DTF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDI1))
				request.WithQueryParameter("EDI1", m3_EDI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDI2))
				request.WithQueryParameter("EDI2", m3_EDI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDI3))
				request.WithQueryParameter("EDI3", m3_EDI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDI4))
				request.WithQueryParameter("EDI4", m3_EDI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDI5))
				request.WithQueryParameter("EDI5", m3_EDI5.Trim());
			if (m3_ZES1.HasValue)
				request.WithQueryParameter("ZES1", m3_ZES1.Value.ToString());
			if (m3_ZES2.HasValue)
				request.WithQueryParameter("ZES2", m3_ZES2.Value.ToString());
			if (m3_ZES3.HasValue)
				request.WithQueryParameter("ZES3", m3_ZES3.Value.ToString());
			if (m3_ZES4.HasValue)
				request.WithQueryParameter("ZES4", m3_ZES4.Value.ToString());
			if (m3_ZES5.HasValue)
				request.WithQueryParameter("ZES5", m3_ZES5.Value.ToString());

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
