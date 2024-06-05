/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS370MI;
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
	/// Name: OIS370MI
	/// Component Name: OIS3770
	/// Description: Api: Bulk order batch entry
	/// Version Release: 5ea0
	///</summary>
	public partial class OIS370MIResource : M3BaseResourceEndpoint
	{
		public OIS370MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS370MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBatchHead
		/// Description AddBatchHead
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_HRE2">Bulk order header reference</param>
		/// <param name="m3_AGTP">Agreement type</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_ACGR">Object access group</param>
		/// <param name="m3_AGDT">Blanket agreement date</param>
		/// <param name="m3_SPGR">Superior groups</param>
		/// <param name="m3_AGCB">Business chain agreement</param>
		/// <param name="m3_AGPD">Agreed prices</param>
		/// <param name="m3_AGQT">Agreed quantity</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_AGHE">Summed agreement quantity</param>
		/// <param name="m3_AGEC">Quantity check</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SEAH">Season in use</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_PRLC">Price list customer number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CUDT">Customer´s purchase order date</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_FECN">Future rate agreement number</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_SCMO">Costing model - sales price</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_TECD">Cash discount term</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_NTCD">Net price used</param>
		/// <param name="m3_BNCD">Bonus generating</param>
		/// <param name="m3_PRAC">Commission generating</param>
		/// <param name="m3_AGNT">Recipient agreement type 1 - commission</param>
		/// <param name="m3_AGN2">Recipient agreement type 2 - commission</param>
		/// <param name="m3_AGN3">Recipient agreement type 3 - commission</param>
		/// <param name="m3_AGN4">Recipient agreement type 4 - commission</param>
		/// <param name="m3_AGN5">Recipient agreement type 5 - commission</param>
		/// <param name="m3_AGN6">Recipient agreement type 6 - commission</param>
		/// <param name="m3_AGN7">Recipient agreement type 7 - commission</param>
		/// <param name="m3_BREC">Recipient agreement type 9 - bonus</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchHeadResponse></returns>
		/// <exception cref="M3Exception<AddBatchHeadResponse>"></exception>
		public async Task<M3Response<AddBatchHeadResponse>> AddBatchHead(
			string m3_MSGN, 
			string m3_CUNO, 
			DateTime m3_STDT, 
			string m3_HRE2 = null, 
			string m3_AGTP = null, 
			DateTime? m3_LVDT = null, 
			string m3_TX40 = null, 
			string m3_ACGR = null, 
			DateTime? m3_AGDT = null, 
			int? m3_SPGR = null, 
			int? m3_AGCB = null, 
			int? m3_AGPD = null, 
			decimal? m3_AGQT = null, 
			string m3_UNIT = null, 
			int? m3_AGHE = null, 
			string m3_AGEC = null, 
			string m3_ADID = null, 
			string m3_SUNO = null, 
			int? m3_SEAH = null, 
			string m3_AGNB = null, 
			string m3_PROJ = null, 
			string m3_PRRF = null, 
			string m3_PRLC = null, 
			string m3_ELNO = null, 
			string m3_CUCD = null, 
			string m3_LNCD = null, 
			DateTime? m3_CUDT = null, 
			string m3_CUOR = null, 
			string m3_OREF = null, 
			string m3_YREF = null, 
			string m3_FECN = null, 
			string m3_SMCD = null, 
			string m3_SCMO = null, 
			string m3_RESP = null, 
			string m3_TEPY = null, 
			string m3_TECD = null, 
			string m3_TEDL = null, 
			string m3_MODL = null, 
			string m3_TEPA = null, 
			int? m3_NTCD = null, 
			int? m3_BNCD = null, 
			int? m3_PRAC = null, 
			string m3_AGNT = null, 
			string m3_AGN2 = null, 
			string m3_AGN3 = null, 
			string m3_AGN4 = null, 
			string m3_AGN5 = null, 
			string m3_AGN6 = null, 
			string m3_AGN7 = null, 
			string m3_BREC = null, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_HRE2))
				request.WithQueryParameter("HRE2", m3_HRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGTP))
				request.WithQueryParameter("AGTP", m3_AGTP.Trim());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_AGDT.HasValue)
				request.WithQueryParameter("AGDT", m3_AGDT.Value.ToM3String());
			if (m3_SPGR.HasValue)
				request.WithQueryParameter("SPGR", m3_SPGR.Value.ToString());
			if (m3_AGCB.HasValue)
				request.WithQueryParameter("AGCB", m3_AGCB.Value.ToString());
			if (m3_AGPD.HasValue)
				request.WithQueryParameter("AGPD", m3_AGPD.Value.ToString());
			if (m3_AGQT.HasValue)
				request.WithQueryParameter("AGQT", m3_AGQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (m3_AGHE.HasValue)
				request.WithQueryParameter("AGHE", m3_AGHE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGEC))
				request.WithQueryParameter("AGEC", m3_AGEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SEAH.HasValue)
				request.WithQueryParameter("SEAH", m3_SEAH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRLC))
				request.WithQueryParameter("PRLC", m3_PRLC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FECN))
				request.WithQueryParameter("FECN", m3_FECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECD))
				request.WithQueryParameter("TECD", m3_TECD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (m3_NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3_NTCD.Value.ToString());
			if (m3_BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3_BNCD.Value.ToString());
			if (m3_PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3_PRAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNT))
				request.WithQueryParameter("AGNT", m3_AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGN2))
				request.WithQueryParameter("AGN2", m3_AGN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGN3))
				request.WithQueryParameter("AGN3", m3_AGN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGN4))
				request.WithQueryParameter("AGN4", m3_AGN4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGN5))
				request.WithQueryParameter("AGN5", m3_AGN5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGN6))
				request.WithQueryParameter("AGN6", m3_AGN6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGN7))
				request.WithQueryParameter("AGN7", m3_AGN7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREC))
				request.WithQueryParameter("BREC", m3_BREC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<AddBatchHeadResponse>(
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
		/// Name AddBatchLn
		/// Description Add Batch Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_AGNO">Blanket agreement number</param>
		/// <param name="m3_HRE2">Bulk order header reference</param>
		/// <param name="m3_LRE2">Bulk order line reference</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_PRLC">Price list customer number</param>
		/// <param name="m3_SPUN">Sales price unit of measure</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_AGQT">Agreed quantity</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_D2QT">Minimum quantity</param>
		/// <param name="m3_D3QT">Maximum quantity</param>
		/// <param name="m3_NAQT">Normal call-off quantity</param>
		/// <param name="m3_PLDT">Planning date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchLnResponse></returns>
		/// <exception cref="M3Exception<AddBatchLnResponse>"></exception>
		public async Task<M3Response<AddBatchLnResponse>> AddBatchLn(
			string m3_MSGN, 
			string m3_CUNO, 
			DateTime m3_FDAT, 
			DateTime m3_STDT, 
			string m3_OBV1, 
			string m3_AGNO = null, 
			string m3_HRE2 = null, 
			string m3_LRE2 = null, 
			DateTime? m3_LVDT = null, 
			string m3_PRRF = null, 
			string m3_PRLC = null, 
			string m3_SPUN = null, 
			string m3_SUNO = null, 
			string m3_AGNB = null, 
			decimal? m3_AGQT = null, 
			string m3_UNIT = null, 
			decimal? m3_D2QT = null, 
			decimal? m3_D3QT = null, 
			decimal? m3_NAQT = null, 
			DateTime? m3_PLDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("OBV1", m3_OBV1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AGNO))
				request.WithQueryParameter("AGNO", m3_AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HRE2))
				request.WithQueryParameter("HRE2", m3_HRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LRE2))
				request.WithQueryParameter("LRE2", m3_LRE2.Trim());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRLC))
				request.WithQueryParameter("PRLC", m3_PRLC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPUN))
				request.WithQueryParameter("SPUN", m3_SPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_AGQT.HasValue)
				request.WithQueryParameter("AGQT", m3_AGQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (m3_D2QT.HasValue)
				request.WithQueryParameter("D2QT", m3_D2QT.Value.ToString());
			if (m3_D3QT.HasValue)
				request.WithQueryParameter("D3QT", m3_D3QT.Value.ToString());
			if (m3_NAQT.HasValue)
				request.WithQueryParameter("NAQT", m3_NAQT.Value.ToString());
			if (m3_PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3_PLDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<AddBatchLnResponse>(
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
		/// Name AddBatchPrice
		/// Description Add Batch Price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_OBV1">Start value 1 (Required)</param>
		/// <param name="m3_AGNO">Blanket agreement number</param>
		/// <param name="m3_HRE2">Bulk order header reference</param>
		/// <param name="m3_LRE2">Bulk order line reference</param>
		/// <param name="m3_QTYL">Lowest quantity limit</param>
		/// <param name="m3_AGPR">Agreed price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_DIPC">Discount</param>
		/// <param name="m3_DIPR">Discount amount per unit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchPriceResponse></returns>
		/// <exception cref="M3Exception<AddBatchPriceResponse>"></exception>
		public async Task<M3Response<AddBatchPriceResponse>> AddBatchPrice(
			string m3_MSGN, 
			string m3_CUNO, 
			DateTime m3_FDAT, 
			DateTime m3_STDT, 
			string m3_OBV1, 
			string m3_AGNO = null, 
			string m3_HRE2 = null, 
			string m3_LRE2 = null, 
			decimal? m3_QTYL = null, 
			decimal? m3_AGPR = null, 
			int? m3_SACD = null, 
			int? m3_DIPC = null, 
			decimal? m3_DIPR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_OBV1))
				throw new ArgumentNullException("m3_OBV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("OBV1", m3_OBV1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AGNO))
				request.WithQueryParameter("AGNO", m3_AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HRE2))
				request.WithQueryParameter("HRE2", m3_HRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LRE2))
				request.WithQueryParameter("LRE2", m3_LRE2.Trim());
			if (m3_QTYL.HasValue)
				request.WithQueryParameter("QTYL", m3_QTYL.Value.ToString());
			if (m3_AGPR.HasValue)
				request.WithQueryParameter("AGPR", m3_AGPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (m3_DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3_DIPC.Value.ToString());
			if (m3_DIPR.HasValue)
				request.WithQueryParameter("DIPR", m3_DIPR.Value.ToString());

			// Execute the request
			var result = await Execute<AddBatchPriceResponse>(
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
		/// Name DeleteEntry
		/// Description Delete Entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteEntry(
			string m3_MSGN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteEntry",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MSGN))
				request.WithQueryParameter("MSGN", m3_MSGN.Trim());

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
		/// Name FinishEntry
		/// Description Finish entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> FinishEntry(
			string m3_MSGN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/FinishEntry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

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
		/// Name StartEntry
		/// Description Start entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_BABU">Bulk order batch origin (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StartEntryResponse></returns>
		/// <exception cref="M3Exception<StartEntryResponse>"></exception>
		public async Task<M3Response<StartEntryResponse>> StartEntry(
			string m3_BABU, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartEntry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BABU))
				throw new ArgumentNullException("m3_BABU");

			// Set mandatory parameters
			request
				.WithQueryParameter("BABU", m3_BABU.Trim());

			// Execute the request
			var result = await Execute<StartEntryResponse>(
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
