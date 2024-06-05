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
	/// Name: OIS800MI
	/// Component Name: Sales
	/// Description: Api: Discount model
	/// Version Release: 5e90
	///</summary>
	public partial class OIS800MIResource : M3BaseResourceEndpoint
	{
		public OIS800MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS800MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDiscNo
		/// Description Add Discount Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_DIPO">Discount number</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX08">Additional text</param>
		/// <param name="m3_DACC">Accumulation</param>
		/// <param name="m3_DCHA">Manually changeable discount</param>
		/// <param name="m3_DPST">Statistics field for discount</param>
		/// <param name="m3_DDSU">Discount presentation</param>
		/// <param name="m3_DITP">Discount type</param>
		/// <param name="m3_DIBE">Discount base</param>
		/// <param name="m3_DIRE">Discount relation</param>
		/// <param name="m3_IDSC">Internal discount</param>
		/// <param name="m3_SGGB">Discount scale base</param>
		/// <param name="m3_SGGC">Discount scale code</param>
		/// <param name="m3_SGGU">Unit of measure</param>
		/// <param name="m3_PC11">Field</param>
		/// <param name="m3_PC12">Field</param>
		/// <param name="m3_PC13">Field</param>
		/// <param name="m3_PC21">Field</param>
		/// <param name="m3_PC22">Field</param>
		/// <param name="m3_PC23">Field</param>
		/// <param name="m3_PC31">Field</param>
		/// <param name="m3_PC32">Field</param>
		/// <param name="m3_PC33">Field</param>
		/// <param name="m3_PC41">Field</param>
		/// <param name="m3_PC42">Field</param>
		/// <param name="m3_PC43">Field</param>
		/// <param name="m3_PC51">Field</param>
		/// <param name="m3_PC52">Field</param>
		/// <param name="m3_PC53">Field</param>
		/// <param name="m3_PC61">Field</param>
		/// <param name="m3_PC62">Field</param>
		/// <param name="m3_PC63">Field</param>
		/// <param name="m3_PC71">Field</param>
		/// <param name="m3_PC72">Field</param>
		/// <param name="m3_PC73">Field</param>
		/// <param name="m3_PC81">Field</param>
		/// <param name="m3_PC82">Field</param>
		/// <param name="m3_PC83">Field</param>
		/// <param name="m3_PC91">Field</param>
		/// <param name="m3_PC92">Field</param>
		/// <param name="m3_PC93">Field</param>
		/// <param name="m3_PC01">Field</param>
		/// <param name="m3_PC02">Field</param>
		/// <param name="m3_PC03">Field</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_DICA">Discount category</param>
		/// <param name="m3_PCHM">Priority check method</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDiscNo(
			string m3_DISY = null, 
			int? m3_DIPO = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_TX08 = null, 
			int? m3_DACC = null, 
			int? m3_DCHA = null, 
			int? m3_DPST = null, 
			int? m3_DDSU = null, 
			int? m3_DITP = null, 
			string m3_DIBE = null, 
			string m3_DIRE = null, 
			int? m3_IDSC = null, 
			string m3_SGGB = null, 
			string m3_SGGC = null, 
			string m3_SGGU = null, 
			string m3_PC11 = null, 
			string m3_PC12 = null, 
			string m3_PC13 = null, 
			string m3_PC21 = null, 
			string m3_PC22 = null, 
			string m3_PC23 = null, 
			string m3_PC31 = null, 
			string m3_PC32 = null, 
			string m3_PC33 = null, 
			string m3_PC41 = null, 
			string m3_PC42 = null, 
			string m3_PC43 = null, 
			string m3_PC51 = null, 
			string m3_PC52 = null, 
			string m3_PC53 = null, 
			string m3_PC61 = null, 
			string m3_PC62 = null, 
			string m3_PC63 = null, 
			string m3_PC71 = null, 
			string m3_PC72 = null, 
			string m3_PC73 = null, 
			string m3_PC81 = null, 
			string m3_PC82 = null, 
			string m3_PC83 = null, 
			string m3_PC91 = null, 
			string m3_PC92 = null, 
			string m3_PC93 = null, 
			string m3_PC01 = null, 
			string m3_PC02 = null, 
			string m3_PC03 = null, 
			string m3_ACRF = null, 
			string m3_DICA = null, 
			int? m3_PCHM = null, 
			decimal? m3_TXID = null, 
			string m3_TEPY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDiscNo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (m3_DIPO.HasValue)
				request.WithQueryParameter("DIPO", m3_DIPO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX08))
				request.WithQueryParameter("TX08", m3_TX08.Trim());
			if (m3_DACC.HasValue)
				request.WithQueryParameter("DACC", m3_DACC.Value.ToString());
			if (m3_DCHA.HasValue)
				request.WithQueryParameter("DCHA", m3_DCHA.Value.ToString());
			if (m3_DPST.HasValue)
				request.WithQueryParameter("DPST", m3_DPST.Value.ToString());
			if (m3_DDSU.HasValue)
				request.WithQueryParameter("DDSU", m3_DDSU.Value.ToString());
			if (m3_DITP.HasValue)
				request.WithQueryParameter("DITP", m3_DITP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIBE))
				request.WithQueryParameter("DIBE", m3_DIBE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIRE))
				request.WithQueryParameter("DIRE", m3_DIRE.Trim());
			if (m3_IDSC.HasValue)
				request.WithQueryParameter("IDSC", m3_IDSC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SGGB))
				request.WithQueryParameter("SGGB", m3_SGGB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SGGC))
				request.WithQueryParameter("SGGC", m3_SGGC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SGGU))
				request.WithQueryParameter("SGGU", m3_SGGU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC11))
				request.WithQueryParameter("PC11", m3_PC11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC12))
				request.WithQueryParameter("PC12", m3_PC12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC13))
				request.WithQueryParameter("PC13", m3_PC13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC21))
				request.WithQueryParameter("PC21", m3_PC21.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC22))
				request.WithQueryParameter("PC22", m3_PC22.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC23))
				request.WithQueryParameter("PC23", m3_PC23.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC31))
				request.WithQueryParameter("PC31", m3_PC31.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC32))
				request.WithQueryParameter("PC32", m3_PC32.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC33))
				request.WithQueryParameter("PC33", m3_PC33.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC41))
				request.WithQueryParameter("PC41", m3_PC41.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC42))
				request.WithQueryParameter("PC42", m3_PC42.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC43))
				request.WithQueryParameter("PC43", m3_PC43.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC51))
				request.WithQueryParameter("PC51", m3_PC51.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC52))
				request.WithQueryParameter("PC52", m3_PC52.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC53))
				request.WithQueryParameter("PC53", m3_PC53.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC61))
				request.WithQueryParameter("PC61", m3_PC61.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC62))
				request.WithQueryParameter("PC62", m3_PC62.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC63))
				request.WithQueryParameter("PC63", m3_PC63.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC71))
				request.WithQueryParameter("PC71", m3_PC71.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC72))
				request.WithQueryParameter("PC72", m3_PC72.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC73))
				request.WithQueryParameter("PC73", m3_PC73.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC81))
				request.WithQueryParameter("PC81", m3_PC81.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC82))
				request.WithQueryParameter("PC82", m3_PC82.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC83))
				request.WithQueryParameter("PC83", m3_PC83.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC91))
				request.WithQueryParameter("PC91", m3_PC91.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC92))
				request.WithQueryParameter("PC92", m3_PC92.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC93))
				request.WithQueryParameter("PC93", m3_PC93.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC01))
				request.WithQueryParameter("PC01", m3_PC01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC02))
				request.WithQueryParameter("PC02", m3_PC02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PC03))
				request.WithQueryParameter("PC03", m3_PC03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DICA))
				request.WithQueryParameter("DICA", m3_DICA.Trim());
			if (m3_PCHM.HasValue)
				request.WithQueryParameter("PCHM", m3_PCHM.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());

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
		/// Name AddModel
		/// Description Add Discount Model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ALDP">Allocated discount number</param>
		/// <param name="m3_ALPP">Reserved promotional discount</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_CORD">Core aging discount number</param>
		/// <param name="m3_EDC1">Reserv external disc 1 to discount no</param>
		/// <param name="m3_EDC2">Reserv external disc 2 to discount no</param>
		/// <param name="m3_EDC3">Reserv external disc 3 to discount no</param>
		/// <param name="m3_EDC4">Reserv external disc 4 to discount no</param>
		/// <param name="m3_EDC5">Reserv external disc 5 to discount no</param>
		/// <param name="m3_EDC6">Reserv external disc 6 to discount no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddModel(
			string m3_DISY = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_CUCD = null, 
			int? m3_ALDP = null, 
			int? m3_ALPP = null, 
			decimal? m3_TXID = null, 
			string m3_ACGR = null, 
			int? m3_CORD = null, 
			int? m3_EDC1 = null, 
			int? m3_EDC2 = null, 
			int? m3_EDC3 = null, 
			int? m3_EDC4 = null, 
			int? m3_EDC5 = null, 
			int? m3_EDC6 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ALDP.HasValue)
				request.WithQueryParameter("ALDP", m3_ALDP.Value.ToString());
			if (m3_ALPP.HasValue)
				request.WithQueryParameter("ALPP", m3_ALPP.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_CORD.HasValue)
				request.WithQueryParameter("CORD", m3_CORD.Value.ToString());
			if (m3_EDC1.HasValue)
				request.WithQueryParameter("EDC1", m3_EDC1.Value.ToString());
			if (m3_EDC2.HasValue)
				request.WithQueryParameter("EDC2", m3_EDC2.Value.ToString());
			if (m3_EDC3.HasValue)
				request.WithQueryParameter("EDC3", m3_EDC3.Value.ToString());
			if (m3_EDC4.HasValue)
				request.WithQueryParameter("EDC4", m3_EDC4.Value.ToString());
			if (m3_EDC5.HasValue)
				request.WithQueryParameter("EDC5", m3_EDC5.Value.ToString());
			if (m3_EDC6.HasValue)
				request.WithQueryParameter("EDC6", m3_EDC6.Value.ToString());

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
		/// Name AddScaleLine
		/// Description Add Scale Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_DIPO">Discount number</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_PREX">Priority</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_LIMT">Limit value</param>
		/// <param name="m3_DITP">Discount type</param>
		/// <param name="m3_DISP">Discount percentage</param>
		/// <param name="m3_DIAM">Discount amount</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddScaleLine(
			string m3_DISY = null, 
			int? m3_DIPO = null, 
			DateTime? m3_FVDT = null, 
			string m3_PREX = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			decimal? m3_LIMT = null, 
			int? m3_DITP = null, 
			int? m3_DISP = null, 
			decimal? m3_DIAM = null, 
			string m3_ITNO = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_SAPR = null, 
			string m3_TEPY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddScaleLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (m3_DIPO.HasValue)
				request.WithQueryParameter("DIPO", m3_DIPO.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PREX))
				request.WithQueryParameter("PREX", m3_PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (m3_LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3_LIMT.Value.ToString());
			if (m3_DITP.HasValue)
				request.WithQueryParameter("DITP", m3_DITP.Value.ToString());
			if (m3_DISP.HasValue)
				request.WithQueryParameter("DISP", m3_DISP.Value.ToString());
			if (m3_DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3_DIAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
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
		/// Name DltModel
		/// Description Delete  Discount Model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltModel(
			string m3_DISY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());

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
