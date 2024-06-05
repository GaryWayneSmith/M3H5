/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3DIPO">Discount number</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX08">Additional text</param>
		/// <param name="m3DACC">Accumulation</param>
		/// <param name="m3DCHA">Manually changeable discount</param>
		/// <param name="m3DPST">Statistics field for discount</param>
		/// <param name="m3DDSU">Discount presentation</param>
		/// <param name="m3DITP">Discount type</param>
		/// <param name="m3DIBE">Discount base</param>
		/// <param name="m3DIRE">Discount relation</param>
		/// <param name="m3IDSC">Internal discount</param>
		/// <param name="m3SGGB">Discount scale base</param>
		/// <param name="m3SGGC">Discount scale code</param>
		/// <param name="m3SGGU">Unit of measure</param>
		/// <param name="m3PC11">Field</param>
		/// <param name="m3PC12">Field</param>
		/// <param name="m3PC13">Field</param>
		/// <param name="m3PC21">Field</param>
		/// <param name="m3PC22">Field</param>
		/// <param name="m3PC23">Field</param>
		/// <param name="m3PC31">Field</param>
		/// <param name="m3PC32">Field</param>
		/// <param name="m3PC33">Field</param>
		/// <param name="m3PC41">Field</param>
		/// <param name="m3PC42">Field</param>
		/// <param name="m3PC43">Field</param>
		/// <param name="m3PC51">Field</param>
		/// <param name="m3PC52">Field</param>
		/// <param name="m3PC53">Field</param>
		/// <param name="m3PC61">Field</param>
		/// <param name="m3PC62">Field</param>
		/// <param name="m3PC63">Field</param>
		/// <param name="m3PC71">Field</param>
		/// <param name="m3PC72">Field</param>
		/// <param name="m3PC73">Field</param>
		/// <param name="m3PC81">Field</param>
		/// <param name="m3PC82">Field</param>
		/// <param name="m3PC83">Field</param>
		/// <param name="m3PC91">Field</param>
		/// <param name="m3PC92">Field</param>
		/// <param name="m3PC93">Field</param>
		/// <param name="m3PC01">Field</param>
		/// <param name="m3PC02">Field</param>
		/// <param name="m3PC03">Field</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3DICA">Discount category</param>
		/// <param name="m3PCHM">Priority check method</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDiscNo(
			string m3DISY = null, 
			int? m3DIPO = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3TX08 = null, 
			int? m3DACC = null, 
			int? m3DCHA = null, 
			int? m3DPST = null, 
			int? m3DDSU = null, 
			int? m3DITP = null, 
			string m3DIBE = null, 
			string m3DIRE = null, 
			int? m3IDSC = null, 
			string m3SGGB = null, 
			string m3SGGC = null, 
			string m3SGGU = null, 
			string m3PC11 = null, 
			string m3PC12 = null, 
			string m3PC13 = null, 
			string m3PC21 = null, 
			string m3PC22 = null, 
			string m3PC23 = null, 
			string m3PC31 = null, 
			string m3PC32 = null, 
			string m3PC33 = null, 
			string m3PC41 = null, 
			string m3PC42 = null, 
			string m3PC43 = null, 
			string m3PC51 = null, 
			string m3PC52 = null, 
			string m3PC53 = null, 
			string m3PC61 = null, 
			string m3PC62 = null, 
			string m3PC63 = null, 
			string m3PC71 = null, 
			string m3PC72 = null, 
			string m3PC73 = null, 
			string m3PC81 = null, 
			string m3PC82 = null, 
			string m3PC83 = null, 
			string m3PC91 = null, 
			string m3PC92 = null, 
			string m3PC93 = null, 
			string m3PC01 = null, 
			string m3PC02 = null, 
			string m3PC03 = null, 
			string m3ACRF = null, 
			string m3DICA = null, 
			int? m3PCHM = null, 
			decimal? m3TXID = null, 
			string m3TEPY = null, 
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
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (m3DIPO.HasValue)
				request.WithQueryParameter("DIPO", m3DIPO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX08))
				request.WithQueryParameter("TX08", m3TX08.Trim());
			if (m3DACC.HasValue)
				request.WithQueryParameter("DACC", m3DACC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCHA.HasValue)
				request.WithQueryParameter("DCHA", m3DCHA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPST.HasValue)
				request.WithQueryParameter("DPST", m3DPST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DDSU.HasValue)
				request.WithQueryParameter("DDSU", m3DDSU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DITP.HasValue)
				request.WithQueryParameter("DITP", m3DITP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIBE))
				request.WithQueryParameter("DIBE", m3DIBE.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIRE))
				request.WithQueryParameter("DIRE", m3DIRE.Trim());
			if (m3IDSC.HasValue)
				request.WithQueryParameter("IDSC", m3IDSC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SGGB))
				request.WithQueryParameter("SGGB", m3SGGB.Trim());
			if (!string.IsNullOrWhiteSpace(m3SGGC))
				request.WithQueryParameter("SGGC", m3SGGC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SGGU))
				request.WithQueryParameter("SGGU", m3SGGU.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC11))
				request.WithQueryParameter("PC11", m3PC11.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC12))
				request.WithQueryParameter("PC12", m3PC12.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC13))
				request.WithQueryParameter("PC13", m3PC13.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC21))
				request.WithQueryParameter("PC21", m3PC21.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC22))
				request.WithQueryParameter("PC22", m3PC22.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC23))
				request.WithQueryParameter("PC23", m3PC23.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC31))
				request.WithQueryParameter("PC31", m3PC31.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC32))
				request.WithQueryParameter("PC32", m3PC32.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC33))
				request.WithQueryParameter("PC33", m3PC33.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC41))
				request.WithQueryParameter("PC41", m3PC41.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC42))
				request.WithQueryParameter("PC42", m3PC42.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC43))
				request.WithQueryParameter("PC43", m3PC43.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC51))
				request.WithQueryParameter("PC51", m3PC51.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC52))
				request.WithQueryParameter("PC52", m3PC52.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC53))
				request.WithQueryParameter("PC53", m3PC53.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC61))
				request.WithQueryParameter("PC61", m3PC61.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC62))
				request.WithQueryParameter("PC62", m3PC62.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC63))
				request.WithQueryParameter("PC63", m3PC63.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC71))
				request.WithQueryParameter("PC71", m3PC71.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC72))
				request.WithQueryParameter("PC72", m3PC72.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC73))
				request.WithQueryParameter("PC73", m3PC73.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC81))
				request.WithQueryParameter("PC81", m3PC81.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC82))
				request.WithQueryParameter("PC82", m3PC82.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC83))
				request.WithQueryParameter("PC83", m3PC83.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC91))
				request.WithQueryParameter("PC91", m3PC91.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC92))
				request.WithQueryParameter("PC92", m3PC92.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC93))
				request.WithQueryParameter("PC93", m3PC93.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC01))
				request.WithQueryParameter("PC01", m3PC01.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC02))
				request.WithQueryParameter("PC02", m3PC02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PC03))
				request.WithQueryParameter("PC03", m3PC03.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3DICA))
				request.WithQueryParameter("DICA", m3DICA.Trim());
			if (m3PCHM.HasValue)
				request.WithQueryParameter("PCHM", m3PCHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());

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
		/// Name AddModel
		/// Description Add Discount Model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ALDP">Allocated discount number</param>
		/// <param name="m3ALPP">Reserved promotional discount</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3CORD">Core aging discount number</param>
		/// <param name="m3EDC1">Reserv external disc 1 to discount no</param>
		/// <param name="m3EDC2">Reserv external disc 2 to discount no</param>
		/// <param name="m3EDC3">Reserv external disc 3 to discount no</param>
		/// <param name="m3EDC4">Reserv external disc 4 to discount no</param>
		/// <param name="m3EDC5">Reserv external disc 5 to discount no</param>
		/// <param name="m3EDC6">Reserv external disc 6 to discount no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddModel(
			string m3DISY = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3CUCD = null, 
			int? m3ALDP = null, 
			int? m3ALPP = null, 
			decimal? m3TXID = null, 
			string m3ACGR = null, 
			int? m3CORD = null, 
			int? m3EDC1 = null, 
			int? m3EDC2 = null, 
			int? m3EDC3 = null, 
			int? m3EDC4 = null, 
			int? m3EDC5 = null, 
			int? m3EDC6 = null, 
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
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ALDP.HasValue)
				request.WithQueryParameter("ALDP", m3ALDP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALPP.HasValue)
				request.WithQueryParameter("ALPP", m3ALPP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3CORD.HasValue)
				request.WithQueryParameter("CORD", m3CORD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EDC1.HasValue)
				request.WithQueryParameter("EDC1", m3EDC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EDC2.HasValue)
				request.WithQueryParameter("EDC2", m3EDC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EDC3.HasValue)
				request.WithQueryParameter("EDC3", m3EDC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EDC4.HasValue)
				request.WithQueryParameter("EDC4", m3EDC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EDC5.HasValue)
				request.WithQueryParameter("EDC5", m3EDC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EDC6.HasValue)
				request.WithQueryParameter("EDC6", m3EDC6.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddScaleLine
		/// Description Add Scale Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3DIPO">Discount number</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3PREX">Priority</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3LIMT">Limit value</param>
		/// <param name="m3DITP">Discount type</param>
		/// <param name="m3DISP">Discount percentage</param>
		/// <param name="m3DIAM">Discount amount</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ORQT">Ordered quantity - basic U/M</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3OBV5">Start value 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddScaleLine(
			string m3DISY = null, 
			int? m3DIPO = null, 
			DateTime? m3FVDT = null, 
			string m3PREX = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			decimal? m3LIMT = null, 
			int? m3DITP = null, 
			int? m3DISP = null, 
			decimal? m3DIAM = null, 
			string m3ITNO = null, 
			decimal? m3ORQT = null, 
			decimal? m3SAPR = null, 
			string m3TEPY = null, 
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddScaleLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (m3DIPO.HasValue)
				request.WithQueryParameter("DIPO", m3DIPO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PREX))
				request.WithQueryParameter("PREX", m3PREX.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (m3LIMT.HasValue)
				request.WithQueryParameter("LIMT", m3LIMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DITP.HasValue)
				request.WithQueryParameter("DITP", m3DITP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DISP.HasValue)
				request.WithQueryParameter("DISP", m3DISP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIAM.HasValue)
				request.WithQueryParameter("DIAM", m3DIAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
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
		/// Name DltModel
		/// Description Delete  Discount Model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltModel(
			string m3DISY = null, 
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
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());

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
