/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_BKID">Customer Bank account identity (Required)</param>
		/// <param name="m3_BKI2">Company Bank account identity (Required)</param>
		/// <param name="m3_AGIN">Agreement indicator (Required)</param>
		/// <param name="m3_BKAG">Bank EDI agreement number (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_VFDT">Valid from</param>
		/// <param name="m3_VTDT">Valid to</param>
		/// <param name="m3_MAXA">Maximum invoice amount</param>
		/// <param name="m3_MTAM">Maximum total amount</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_AGR1">Agreement 1</param>
		/// <param name="m3_AGR2">Agreement 2</param>
		/// <param name="m3_AGR3">Agreement 3</param>
		/// <param name="m3_AGR4">Agreement 4</param>
		/// <param name="m3_AGR5">Agreement 5</param>
		/// <param name="m3_AGR6">Agreement 6</param>
		/// <param name="m3_AGR7">Agreement 7</param>
		/// <param name="m3_TSTA">Transfer status</param>
		/// <param name="m3_AGOT">One time agreement</param>
		/// <param name="m3_LCOL">Last collection date</param>
		/// <param name="m3_LRMN">Last remittance proposal number</param>
		/// <param name="m3_AMRC">Amended mandate</param>
		/// <param name="m3_BRAG">Reference agreement number</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_SDDS">Direct debit scheme</param>
		/// <param name="m3_SEFR">SEPA DD frequency</param>
		/// <param name="m3_DODT">Last printout date</param>
		/// <param name="m3_STCF">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDirDebAgr(
			string m3_DIVI, 
			string m3_CUNO, 
			string m3_BKID, 
			string m3_BKI2, 
			string m3_AGIN, 
			string m3_BKAG, 
			string m3_STAT = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			DateTime? m3_VFDT = null, 
			DateTime? m3_VTDT = null, 
			decimal? m3_MAXA = null, 
			decimal? m3_MTAM = null, 
			string m3_CUCD = null, 
			string m3_AGR1 = null, 
			string m3_AGR2 = null, 
			string m3_AGR3 = null, 
			string m3_AGR4 = null, 
			string m3_AGR5 = null, 
			string m3_AGR6 = null, 
			string m3_AGR7 = null, 
			int? m3_TSTA = null, 
			int? m3_AGOT = null, 
			DateTime? m3_LCOL = null, 
			int? m3_LRMN = null, 
			string m3_AMRC = null, 
			string m3_BRAG = null, 
			decimal? m3_TXID = null, 
			int? m3_SDDS = null, 
			int? m3_SEFR = null, 
			DateTime? m3_DODT = null, 
			int? m3_STCF = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");
			if (string.IsNullOrWhiteSpace(m3_BKI2))
				throw new ArgumentNullException("m3_BKI2");
			if (string.IsNullOrWhiteSpace(m3_AGIN))
				throw new ArgumentNullException("m3_AGIN");
			if (string.IsNullOrWhiteSpace(m3_BKAG))
				throw new ArgumentNullException("m3_BKAG");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim())
				.WithQueryParameter("BKI2", m3_BKI2.Trim())
				.WithQueryParameter("AGIN", m3_AGIN.Trim())
				.WithQueryParameter("BKAG", m3_BKAG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3_VFDT.Value.ToM3String());
			if (m3_VTDT.HasValue)
				request.WithQueryParameter("VTDT", m3_VTDT.Value.ToM3String());
			if (m3_MAXA.HasValue)
				request.WithQueryParameter("MAXA", m3_MAXA.Value.ToString());
			if (m3_MTAM.HasValue)
				request.WithQueryParameter("MTAM", m3_MTAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR1))
				request.WithQueryParameter("AGR1", m3_AGR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR2))
				request.WithQueryParameter("AGR2", m3_AGR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR3))
				request.WithQueryParameter("AGR3", m3_AGR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR4))
				request.WithQueryParameter("AGR4", m3_AGR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR5))
				request.WithQueryParameter("AGR5", m3_AGR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR6))
				request.WithQueryParameter("AGR6", m3_AGR6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR7))
				request.WithQueryParameter("AGR7", m3_AGR7.Trim());
			if (m3_TSTA.HasValue)
				request.WithQueryParameter("TSTA", m3_TSTA.Value.ToString());
			if (m3_AGOT.HasValue)
				request.WithQueryParameter("AGOT", m3_AGOT.Value.ToString());
			if (m3_LCOL.HasValue)
				request.WithQueryParameter("LCOL", m3_LCOL.Value.ToM3String());
			if (m3_LRMN.HasValue)
				request.WithQueryParameter("LRMN", m3_LRMN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AMRC))
				request.WithQueryParameter("AMRC", m3_AMRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAG))
				request.WithQueryParameter("BRAG", m3_BRAG.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_SDDS.HasValue)
				request.WithQueryParameter("SDDS", m3_SDDS.Value.ToString());
			if (m3_SEFR.HasValue)
				request.WithQueryParameter("SEFR", m3_SEFR.Value.ToString());
			if (m3_DODT.HasValue)
				request.WithQueryParameter("DODT", m3_DODT.Value.ToM3String());
			if (m3_STCF.HasValue)
				request.WithQueryParameter("STCF", m3_STCF.Value.ToString());

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
		/// Name DelDirDebAgr
		/// Description Delete Direct Debiting Agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_BKID">Customer Bank account identity (Required)</param>
		/// <param name="m3_BKI2">Company Bank account identity (Required)</param>
		/// <param name="m3_AGIN">Agreement indicator (Required)</param>
		/// <param name="m3_BKAG">Bank EDI agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelDirDebAgr(
			string m3_DIVI, 
			string m3_CUNO, 
			string m3_BKID, 
			string m3_BKI2, 
			string m3_AGIN, 
			string m3_BKAG, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");
			if (string.IsNullOrWhiteSpace(m3_BKI2))
				throw new ArgumentNullException("m3_BKI2");
			if (string.IsNullOrWhiteSpace(m3_AGIN))
				throw new ArgumentNullException("m3_AGIN");
			if (string.IsNullOrWhiteSpace(m3_BKAG))
				throw new ArgumentNullException("m3_BKAG");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim())
				.WithQueryParameter("BKI2", m3_BKI2.Trim())
				.WithQueryParameter("AGIN", m3_AGIN.Trim())
				.WithQueryParameter("BKAG", m3_BKAG.Trim());

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
		/// Name GetBasicData
		/// Description Retrieve agreement basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_BKI2">Bank account identity (Required)</param>
		/// <param name="m3_AGIN">Agreement indicator (Required)</param>
		/// <param name="m3_BKAG">Bank EDI agreement number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3_DIVI, 
			string m3_CUNO, 
			string m3_BKID, 
			string m3_BKI2, 
			string m3_AGIN, 
			string m3_BKAG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");
			if (string.IsNullOrWhiteSpace(m3_BKI2))
				throw new ArgumentNullException("m3_BKI2");
			if (string.IsNullOrWhiteSpace(m3_AGIN))
				throw new ArgumentNullException("m3_AGIN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim())
				.WithQueryParameter("BKI2", m3_BKI2.Trim())
				.WithQueryParameter("AGIN", m3_AGIN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BKAG))
				request.WithQueryParameter("BKAG", m3_BKAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name LstAgrByCustNo
		/// Description List Agreement By Customer Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_BKID">Bank account identity</param>
		/// <param name="m3_BKI2">Bank account identity</param>
		/// <param name="m3_BKAG">Bank EDI agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrByCustNoResponse></returns>
		/// <exception cref="M3Exception<LstAgrByCustNoResponse>"></exception>
		public async Task<M3Response<LstAgrByCustNoResponse>> LstAgrByCustNo(
			string m3_DIVI, 
			string m3_CUNO, 
			string m3_BKID = null, 
			string m3_BKI2 = null, 
			string m3_BKAG = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BKID))
				request.WithQueryParameter("BKID", m3_BKID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKI2))
				request.WithQueryParameter("BKI2", m3_BKI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BKAG))
				request.WithQueryParameter("BKAG", m3_BKAG.Trim());

			// Execute the request
			var result = await Execute<LstAgrByCustNoResponse>(
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
		/// Name UpdAgr
		/// Description Update agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_BKID">Bank account identity (Required)</param>
		/// <param name="m3_BKI2">Bank account identity (Required)</param>
		/// <param name="m3_AGIN">Agreement indicator (Required)</param>
		/// <param name="m3_BKAG">Bank EDI agreement number (Required)</param>
		/// <param name="m3_ACTO">Action (Required)</param>
		/// <param name="m3_ACTB">Action number</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_VFDT">Valid from</param>
		/// <param name="m3_VTDT">Valid to</param>
		/// <param name="m3_MAXA">Maximum invoice amount</param>
		/// <param name="m3_MTAM">Maximum total amount</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_AGR1">Agreement 1</param>
		/// <param name="m3_AGR2">Agreement 2</param>
		/// <param name="m3_AGR3">Agreement 3</param>
		/// <param name="m3_AGR4">Agreement 4</param>
		/// <param name="m3_AGR5">Agreement 5</param>
		/// <param name="m3_AGR6">Agreement 6</param>
		/// <param name="m3_AGR7">Agreement 7</param>
		/// <param name="m3_TSTA">Transfer status</param>
		/// <param name="m3_ACTD">Action date</param>
		/// <param name="m3_ACTZ">Action time</param>
		/// <param name="m3_AGCC">Agreement confirmation code</param>
		/// <param name="m3_AGOT">One time agreement</param>
		/// <param name="m3_LCOL">Last collection date</param>
		/// <param name="m3_LRMN">Last remittance proposal number</param>
		/// <param name="m3_AMRC">Amended mandate</param>
		/// <param name="m3_BRAG">Reference agreement number</param>
		/// <param name="m3_SDDS">Direct debit scheme</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_SEFR">SEPA DD frequency</param>
		/// <param name="m3_DODT">Last printout date</param>
		/// <param name="m3_STCF">Status</param>
		/// <param name="m3_SIGD">Signature date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdAgrResponse></returns>
		/// <exception cref="M3Exception<UpdAgrResponse>"></exception>
		public async Task<M3Response<UpdAgrResponse>> UpdAgr(
			string m3_DIVI, 
			string m3_CUNO, 
			string m3_BKID, 
			string m3_BKI2, 
			string m3_AGIN, 
			string m3_BKAG, 
			int m3_ACTO, 
			long? m3_ACTB = null, 
			string m3_STAT = null, 
			DateTime? m3_VFDT = null, 
			DateTime? m3_VTDT = null, 
			decimal? m3_MAXA = null, 
			decimal? m3_MTAM = null, 
			string m3_CUCD = null, 
			string m3_AGR1 = null, 
			string m3_AGR2 = null, 
			string m3_AGR3 = null, 
			string m3_AGR4 = null, 
			string m3_AGR5 = null, 
			string m3_AGR6 = null, 
			string m3_AGR7 = null, 
			int? m3_TSTA = null, 
			DateTime? m3_ACTD = null, 
			int? m3_ACTZ = null, 
			string m3_AGCC = null, 
			int? m3_AGOT = null, 
			DateTime? m3_LCOL = null, 
			int? m3_LRMN = null, 
			string m3_AMRC = null, 
			string m3_BRAG = null, 
			int? m3_SDDS = null, 
			decimal? m3_TXID = null, 
			int? m3_SEFR = null, 
			DateTime? m3_DODT = null, 
			int? m3_STCF = null, 
			DateTime? m3_SIGD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_BKID))
				throw new ArgumentNullException("m3_BKID");
			if (string.IsNullOrWhiteSpace(m3_BKI2))
				throw new ArgumentNullException("m3_BKI2");
			if (string.IsNullOrWhiteSpace(m3_AGIN))
				throw new ArgumentNullException("m3_AGIN");
			if (string.IsNullOrWhiteSpace(m3_BKAG))
				throw new ArgumentNullException("m3_BKAG");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("BKID", m3_BKID.Trim())
				.WithQueryParameter("BKI2", m3_BKI2.Trim())
				.WithQueryParameter("AGIN", m3_AGIN.Trim())
				.WithQueryParameter("BKAG", m3_BKAG.Trim())
				.WithQueryParameter("ACTO", m3_ACTO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ACTB.HasValue)
				request.WithQueryParameter("ACTB", m3_ACTB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3_VFDT.Value.ToM3String());
			if (m3_VTDT.HasValue)
				request.WithQueryParameter("VTDT", m3_VTDT.Value.ToM3String());
			if (m3_MAXA.HasValue)
				request.WithQueryParameter("MAXA", m3_MAXA.Value.ToString());
			if (m3_MTAM.HasValue)
				request.WithQueryParameter("MTAM", m3_MTAM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR1))
				request.WithQueryParameter("AGR1", m3_AGR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR2))
				request.WithQueryParameter("AGR2", m3_AGR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR3))
				request.WithQueryParameter("AGR3", m3_AGR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR4))
				request.WithQueryParameter("AGR4", m3_AGR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR5))
				request.WithQueryParameter("AGR5", m3_AGR5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR6))
				request.WithQueryParameter("AGR6", m3_AGR6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGR7))
				request.WithQueryParameter("AGR7", m3_AGR7.Trim());
			if (m3_TSTA.HasValue)
				request.WithQueryParameter("TSTA", m3_TSTA.Value.ToString());
			if (m3_ACTD.HasValue)
				request.WithQueryParameter("ACTD", m3_ACTD.Value.ToM3String());
			if (m3_ACTZ.HasValue)
				request.WithQueryParameter("ACTZ", m3_ACTZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGCC))
				request.WithQueryParameter("AGCC", m3_AGCC.Trim());
			if (m3_AGOT.HasValue)
				request.WithQueryParameter("AGOT", m3_AGOT.Value.ToString());
			if (m3_LCOL.HasValue)
				request.WithQueryParameter("LCOL", m3_LCOL.Value.ToM3String());
			if (m3_LRMN.HasValue)
				request.WithQueryParameter("LRMN", m3_LRMN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AMRC))
				request.WithQueryParameter("AMRC", m3_AMRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAG))
				request.WithQueryParameter("BRAG", m3_BRAG.Trim());
			if (m3_SDDS.HasValue)
				request.WithQueryParameter("SDDS", m3_SDDS.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_SEFR.HasValue)
				request.WithQueryParameter("SEFR", m3_SEFR.Value.ToString());
			if (m3_DODT.HasValue)
				request.WithQueryParameter("DODT", m3_DODT.Value.ToM3String());
			if (m3_STCF.HasValue)
				request.WithQueryParameter("STCF", m3_STCF.Value.ToString());
			if (m3_SIGD.HasValue)
				request.WithQueryParameter("SIGD", m3_SIGD.Value.ToM3String());

			// Execute the request
			var result = await Execute<UpdAgrResponse>(
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
