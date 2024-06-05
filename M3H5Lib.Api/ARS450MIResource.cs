/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.ARS450MI;
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
	/// Name: ARS450MI
	/// Component Name: Financials
	/// Description: Api: Direct Debiting Agreements
	/// Version Release: 14.x
	///</summary>
	public partial class ARS450MIResource : M3BaseResourceEndpoint
	{
		public ARS450MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ARS450MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDirDebAgr
		/// Description Add Direct Debiting Agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3BKID">Customer Bank account identity (Required)</param>
		/// <param name="m3BKI2">Company Bank account identity (Required)</param>
		/// <param name="m3AGIN">Agreement indicator (Required)</param>
		/// <param name="m3BKAG">Bank EDI agreement number (Required)</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3VFDT">Valid from</param>
		/// <param name="m3VTDT">Valid to</param>
		/// <param name="m3MAXA">Maximum invoice amount</param>
		/// <param name="m3MTAM">Maximum total amount</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3AGR1">Agreement 1</param>
		/// <param name="m3AGR2">Agreement 2</param>
		/// <param name="m3AGR3">Agreement 3</param>
		/// <param name="m3AGR4">Agreement 4</param>
		/// <param name="m3AGR5">Agreement 5</param>
		/// <param name="m3AGR6">Agreement 6</param>
		/// <param name="m3AGR7">Agreement 7</param>
		/// <param name="m3TSTA">Transfer status</param>
		/// <param name="m3AGOT">One time agreement</param>
		/// <param name="m3LCOL">Last collection date</param>
		/// <param name="m3LRMN">Last remittance proposal number</param>
		/// <param name="m3AMRC">Amended mandate</param>
		/// <param name="m3BRAG">Reference agreement number</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3SDDS">Direct debit scheme</param>
		/// <param name="m3SEFR">SEPA DD frequency</param>
		/// <param name="m3DODT">Last printout date</param>
		/// <param name="m3STCF">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDirDebAgr(
			string m3DIVI, 
			string m3CUNO, 
			string m3BKID, 
			string m3BKI2, 
			string m3AGIN, 
			string m3BKAG, 
			string m3STAT = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			DateTime? m3VFDT = null, 
			DateTime? m3VTDT = null, 
			decimal? m3MAXA = null, 
			decimal? m3MTAM = null, 
			string m3CUCD = null, 
			string m3AGR1 = null, 
			string m3AGR2 = null, 
			string m3AGR3 = null, 
			string m3AGR4 = null, 
			string m3AGR5 = null, 
			string m3AGR6 = null, 
			string m3AGR7 = null, 
			int? m3TSTA = null, 
			int? m3AGOT = null, 
			DateTime? m3LCOL = null, 
			int? m3LRMN = null, 
			string m3AMRC = null, 
			string m3BRAG = null, 
			decimal? m3TXID = null, 
			int? m3SDDS = null, 
			int? m3SEFR = null, 
			DateTime? m3DODT = null, 
			int? m3STCF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDirDebAgr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));
			if (string.IsNullOrWhiteSpace(m3BKI2))
				throw new ArgumentNullException(nameof(m3BKI2));
			if (string.IsNullOrWhiteSpace(m3AGIN))
				throw new ArgumentNullException(nameof(m3AGIN));
			if (string.IsNullOrWhiteSpace(m3BKAG))
				throw new ArgumentNullException(nameof(m3BKAG));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim())
				.WithQueryParameter("BKI2", m3BKI2.Trim())
				.WithQueryParameter("AGIN", m3AGIN.Trim())
				.WithQueryParameter("BKAG", m3BKAG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3VFDT.Value.ToM3String());
			if (m3VTDT.HasValue)
				request.WithQueryParameter("VTDT", m3VTDT.Value.ToM3String());
			if (m3MAXA.HasValue)
				request.WithQueryParameter("MAXA", m3MAXA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MTAM.HasValue)
				request.WithQueryParameter("MTAM", m3MTAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR1))
				request.WithQueryParameter("AGR1", m3AGR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR2))
				request.WithQueryParameter("AGR2", m3AGR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR3))
				request.WithQueryParameter("AGR3", m3AGR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR4))
				request.WithQueryParameter("AGR4", m3AGR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR5))
				request.WithQueryParameter("AGR5", m3AGR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR6))
				request.WithQueryParameter("AGR6", m3AGR6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR7))
				request.WithQueryParameter("AGR7", m3AGR7.Trim());
			if (m3TSTA.HasValue)
				request.WithQueryParameter("TSTA", m3TSTA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGOT.HasValue)
				request.WithQueryParameter("AGOT", m3AGOT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LCOL.HasValue)
				request.WithQueryParameter("LCOL", m3LCOL.Value.ToM3String());
			if (m3LRMN.HasValue)
				request.WithQueryParameter("LRMN", m3LRMN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AMRC))
				request.WithQueryParameter("AMRC", m3AMRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAG))
				request.WithQueryParameter("BRAG", m3BRAG.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDDS.HasValue)
				request.WithQueryParameter("SDDS", m3SDDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEFR.HasValue)
				request.WithQueryParameter("SEFR", m3SEFR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DODT.HasValue)
				request.WithQueryParameter("DODT", m3DODT.Value.ToM3String());
			if (m3STCF.HasValue)
				request.WithQueryParameter("STCF", m3STCF.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelDirDebAgr
		/// Description Delete Direct Debiting Agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3BKID">Customer Bank account identity (Required)</param>
		/// <param name="m3BKI2">Company Bank account identity (Required)</param>
		/// <param name="m3AGIN">Agreement indicator (Required)</param>
		/// <param name="m3BKAG">Bank EDI agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDirDebAgr(
			string m3DIVI, 
			string m3CUNO, 
			string m3BKID, 
			string m3BKI2, 
			string m3AGIN, 
			string m3BKAG, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelDirDebAgr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));
			if (string.IsNullOrWhiteSpace(m3BKI2))
				throw new ArgumentNullException(nameof(m3BKI2));
			if (string.IsNullOrWhiteSpace(m3AGIN))
				throw new ArgumentNullException(nameof(m3AGIN));
			if (string.IsNullOrWhiteSpace(m3BKAG))
				throw new ArgumentNullException(nameof(m3BKAG));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim())
				.WithQueryParameter("BKI2", m3BKI2.Trim())
				.WithQueryParameter("AGIN", m3AGIN.Trim())
				.WithQueryParameter("BKAG", m3BKAG.Trim());

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
		/// Name GetBasicData
		/// Description Retrieve agreement basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3BKI2">Bank account identity (Required)</param>
		/// <param name="m3AGIN">Agreement indicator (Required)</param>
		/// <param name="m3BKAG">Bank EDI agreement number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3DIVI, 
			string m3CUNO, 
			string m3BKID, 
			string m3BKI2, 
			string m3AGIN, 
			string m3BKAG = null, 
			string m3STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));
			if (string.IsNullOrWhiteSpace(m3BKI2))
				throw new ArgumentNullException(nameof(m3BKI2));
			if (string.IsNullOrWhiteSpace(m3AGIN))
				throw new ArgumentNullException(nameof(m3AGIN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim())
				.WithQueryParameter("BKI2", m3BKI2.Trim())
				.WithQueryParameter("AGIN", m3AGIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BKAG))
				request.WithQueryParameter("BKAG", m3BKAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name LstAgrByCustNo
		/// Description List Agreement By Customer Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3BKID">Bank account identity</param>
		/// <param name="m3BKI2">Bank account identity</param>
		/// <param name="m3BKAG">Bank EDI agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrByCustNoResponse></returns>
		/// <exception cref="M3Exception<LstAgrByCustNoResponse>"></exception>
		public async Task<M3Response<LstAgrByCustNoResponse>> LstAgrByCustNo(
			string m3DIVI, 
			string m3CUNO, 
			string m3BKID = null, 
			string m3BKI2 = null, 
			string m3BKAG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrByCustNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BKID))
				request.WithQueryParameter("BKID", m3BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKI2))
				request.WithQueryParameter("BKI2", m3BKI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3BKAG))
				request.WithQueryParameter("BKAG", m3BKAG.Trim());

			// Execute the request
			var result = await Execute<LstAgrByCustNoResponse>(
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
		/// Name UpdAgr
		/// Description Update agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3BKID">Bank account identity (Required)</param>
		/// <param name="m3BKI2">Bank account identity (Required)</param>
		/// <param name="m3AGIN">Agreement indicator (Required)</param>
		/// <param name="m3BKAG">Bank EDI agreement number (Required)</param>
		/// <param name="m3ACTO">Action (Required)</param>
		/// <param name="m3ACTB">Action number</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3VFDT">Valid from</param>
		/// <param name="m3VTDT">Valid to</param>
		/// <param name="m3MAXA">Maximum invoice amount</param>
		/// <param name="m3MTAM">Maximum total amount</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3AGR1">Agreement 1</param>
		/// <param name="m3AGR2">Agreement 2</param>
		/// <param name="m3AGR3">Agreement 3</param>
		/// <param name="m3AGR4">Agreement 4</param>
		/// <param name="m3AGR5">Agreement 5</param>
		/// <param name="m3AGR6">Agreement 6</param>
		/// <param name="m3AGR7">Agreement 7</param>
		/// <param name="m3TSTA">Transfer status</param>
		/// <param name="m3ACTD">Action date</param>
		/// <param name="m3ACTZ">Action time</param>
		/// <param name="m3AGCC">Agreement confirmation code</param>
		/// <param name="m3AGOT">One time agreement</param>
		/// <param name="m3LCOL">Last collection date</param>
		/// <param name="m3LRMN">Last remittance proposal number</param>
		/// <param name="m3AMRC">Amended mandate</param>
		/// <param name="m3BRAG">Reference agreement number</param>
		/// <param name="m3SDDS">Direct debit scheme</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3SEFR">SEPA DD frequency</param>
		/// <param name="m3DODT">Last printout date</param>
		/// <param name="m3STCF">Status</param>
		/// <param name="m3SIGD">Signature date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdAgrResponse></returns>
		/// <exception cref="M3Exception<UpdAgrResponse>"></exception>
		public async Task<M3Response<UpdAgrResponse>> UpdAgr(
			string m3DIVI, 
			string m3CUNO, 
			string m3BKID, 
			string m3BKI2, 
			string m3AGIN, 
			string m3BKAG, 
			int m3ACTO, 
			long? m3ACTB = null, 
			string m3STAT = null, 
			DateTime? m3VFDT = null, 
			DateTime? m3VTDT = null, 
			decimal? m3MAXA = null, 
			decimal? m3MTAM = null, 
			string m3CUCD = null, 
			string m3AGR1 = null, 
			string m3AGR2 = null, 
			string m3AGR3 = null, 
			string m3AGR4 = null, 
			string m3AGR5 = null, 
			string m3AGR6 = null, 
			string m3AGR7 = null, 
			int? m3TSTA = null, 
			DateTime? m3ACTD = null, 
			int? m3ACTZ = null, 
			string m3AGCC = null, 
			int? m3AGOT = null, 
			DateTime? m3LCOL = null, 
			int? m3LRMN = null, 
			string m3AMRC = null, 
			string m3BRAG = null, 
			int? m3SDDS = null, 
			decimal? m3TXID = null, 
			int? m3SEFR = null, 
			DateTime? m3DODT = null, 
			int? m3STCF = null, 
			DateTime? m3SIGD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAgr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3BKID))
				throw new ArgumentNullException(nameof(m3BKID));
			if (string.IsNullOrWhiteSpace(m3BKI2))
				throw new ArgumentNullException(nameof(m3BKI2));
			if (string.IsNullOrWhiteSpace(m3AGIN))
				throw new ArgumentNullException(nameof(m3AGIN));
			if (string.IsNullOrWhiteSpace(m3BKAG))
				throw new ArgumentNullException(nameof(m3BKAG));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("BKID", m3BKID.Trim())
				.WithQueryParameter("BKI2", m3BKI2.Trim())
				.WithQueryParameter("AGIN", m3AGIN.Trim())
				.WithQueryParameter("BKAG", m3BKAG.Trim())
				.WithQueryParameter("ACTO", m3ACTO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3ACTB.HasValue)
				request.WithQueryParameter("ACTB", m3ACTB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3VFDT.Value.ToM3String());
			if (m3VTDT.HasValue)
				request.WithQueryParameter("VTDT", m3VTDT.Value.ToM3String());
			if (m3MAXA.HasValue)
				request.WithQueryParameter("MAXA", m3MAXA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MTAM.HasValue)
				request.WithQueryParameter("MTAM", m3MTAM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR1))
				request.WithQueryParameter("AGR1", m3AGR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR2))
				request.WithQueryParameter("AGR2", m3AGR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR3))
				request.WithQueryParameter("AGR3", m3AGR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR4))
				request.WithQueryParameter("AGR4", m3AGR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR5))
				request.WithQueryParameter("AGR5", m3AGR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR6))
				request.WithQueryParameter("AGR6", m3AGR6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGR7))
				request.WithQueryParameter("AGR7", m3AGR7.Trim());
			if (m3TSTA.HasValue)
				request.WithQueryParameter("TSTA", m3TSTA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTD.HasValue)
				request.WithQueryParameter("ACTD", m3ACTD.Value.ToM3String());
			if (m3ACTZ.HasValue)
				request.WithQueryParameter("ACTZ", m3ACTZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGCC))
				request.WithQueryParameter("AGCC", m3AGCC.Trim());
			if (m3AGOT.HasValue)
				request.WithQueryParameter("AGOT", m3AGOT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LCOL.HasValue)
				request.WithQueryParameter("LCOL", m3LCOL.Value.ToM3String());
			if (m3LRMN.HasValue)
				request.WithQueryParameter("LRMN", m3LRMN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AMRC))
				request.WithQueryParameter("AMRC", m3AMRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAG))
				request.WithQueryParameter("BRAG", m3BRAG.Trim());
			if (m3SDDS.HasValue)
				request.WithQueryParameter("SDDS", m3SDDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEFR.HasValue)
				request.WithQueryParameter("SEFR", m3SEFR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DODT.HasValue)
				request.WithQueryParameter("DODT", m3DODT.Value.ToM3String());
			if (m3STCF.HasValue)
				request.WithQueryParameter("STCF", m3STCF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIGD.HasValue)
				request.WithQueryParameter("SIGD", m3SIGD.Value.ToM3String());

			// Execute the request
			var result = await Execute<UpdAgrResponse>(
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
