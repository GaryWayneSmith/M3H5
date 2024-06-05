/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBatchHead
		/// Description AddBatchHead
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3HRE2">Bulk order header reference</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3AGDT">Blanket agreement date</param>
		/// <param name="m3SPGR">Superior groups</param>
		/// <param name="m3AGCB">Business chain agreement</param>
		/// <param name="m3AGPD">Agreed prices</param>
		/// <param name="m3AGQT">Agreed quantity</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3AGHE">Summed agreement quantity</param>
		/// <param name="m3AGEC">Quantity check</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SEAH">Season in use</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3PRLC">Price list customer number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CUDT">Customer´s purchase order date</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3FECN">Future rate agreement number</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3SCMO">Costing model - sales price</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3TECD">Cash discount term</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3NTCD">Net price used</param>
		/// <param name="m3BNCD">Bonus generating</param>
		/// <param name="m3PRAC">Commission generating</param>
		/// <param name="m3AGNT">Recipient agreement type 1 - commission</param>
		/// <param name="m3AGN2">Recipient agreement type 2 - commission</param>
		/// <param name="m3AGN3">Recipient agreement type 3 - commission</param>
		/// <param name="m3AGN4">Recipient agreement type 4 - commission</param>
		/// <param name="m3AGN5">Recipient agreement type 5 - commission</param>
		/// <param name="m3AGN6">Recipient agreement type 6 - commission</param>
		/// <param name="m3AGN7">Recipient agreement type 7 - commission</param>
		/// <param name="m3BREC">Recipient agreement type 9 - bonus</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchHeadResponse></returns>
		/// <exception cref="M3Exception<AddBatchHeadResponse>"></exception>
		public async Task<M3Response<AddBatchHeadResponse>> AddBatchHead(
			string m3MSGN, 
			string m3CUNO, 
			DateTime m3STDT, 
			string m3HRE2 = null, 
			string m3AGTP = null, 
			DateTime? m3LVDT = null, 
			string m3TX40 = null, 
			string m3ACGR = null, 
			DateTime? m3AGDT = null, 
			int? m3SPGR = null, 
			int? m3AGCB = null, 
			int? m3AGPD = null, 
			decimal? m3AGQT = null, 
			string m3UNIT = null, 
			int? m3AGHE = null, 
			string m3AGEC = null, 
			string m3ADID = null, 
			string m3SUNO = null, 
			int? m3SEAH = null, 
			string m3AGNB = null, 
			string m3PROJ = null, 
			string m3PRRF = null, 
			string m3PRLC = null, 
			string m3ELNO = null, 
			string m3CUCD = null, 
			string m3LNCD = null, 
			DateTime? m3CUDT = null, 
			string m3CUOR = null, 
			string m3OREF = null, 
			string m3YREF = null, 
			string m3FECN = null, 
			string m3SMCD = null, 
			string m3SCMO = null, 
			string m3RESP = null, 
			string m3TEPY = null, 
			string m3TECD = null, 
			string m3TEDL = null, 
			string m3MODL = null, 
			string m3TEPA = null, 
			int? m3NTCD = null, 
			int? m3BNCD = null, 
			int? m3PRAC = null, 
			string m3AGNT = null, 
			string m3AGN2 = null, 
			string m3AGN3 = null, 
			string m3AGN4 = null, 
			string m3AGN5 = null, 
			string m3AGN6 = null, 
			string m3AGN7 = null, 
			string m3BREC = null, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3HRE2))
				request.WithQueryParameter("HRE2", m3HRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3AGDT.HasValue)
				request.WithQueryParameter("AGDT", m3AGDT.Value.ToM3String());
			if (m3SPGR.HasValue)
				request.WithQueryParameter("SPGR", m3SPGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGCB.HasValue)
				request.WithQueryParameter("AGCB", m3AGCB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGPD.HasValue)
				request.WithQueryParameter("AGPD", m3AGPD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGQT.HasValue)
				request.WithQueryParameter("AGQT", m3AGQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (m3AGHE.HasValue)
				request.WithQueryParameter("AGHE", m3AGHE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGEC))
				request.WithQueryParameter("AGEC", m3AGEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SEAH.HasValue)
				request.WithQueryParameter("SEAH", m3SEAH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRLC))
				request.WithQueryParameter("PRLC", m3PRLC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3FECN))
				request.WithQueryParameter("FECN", m3FECN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECD))
				request.WithQueryParameter("TECD", m3TECD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (m3NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3NTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3BNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3PRAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNT))
				request.WithQueryParameter("AGNT", m3AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGN2))
				request.WithQueryParameter("AGN2", m3AGN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGN3))
				request.WithQueryParameter("AGN3", m3AGN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGN4))
				request.WithQueryParameter("AGN4", m3AGN4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGN5))
				request.WithQueryParameter("AGN5", m3AGN5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGN6))
				request.WithQueryParameter("AGN6", m3AGN6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGN7))
				request.WithQueryParameter("AGN7", m3AGN7.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREC))
				request.WithQueryParameter("BREC", m3BREC.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<AddBatchHeadResponse>(
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
		/// Name AddBatchLn
		/// Description Add Batch Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3AGNO">Blanket agreement number</param>
		/// <param name="m3HRE2">Bulk order header reference</param>
		/// <param name="m3LRE2">Bulk order line reference</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3PRLC">Price list customer number</param>
		/// <param name="m3SPUN">Sales price unit of measure</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3AGQT">Agreed quantity</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3D2QT">Minimum quantity</param>
		/// <param name="m3D3QT">Maximum quantity</param>
		/// <param name="m3NAQT">Normal call-off quantity</param>
		/// <param name="m3PLDT">Planning date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchLnResponse></returns>
		/// <exception cref="M3Exception<AddBatchLnResponse>"></exception>
		public async Task<M3Response<AddBatchLnResponse>> AddBatchLn(
			string m3MSGN, 
			string m3CUNO, 
			DateTime m3FDAT, 
			DateTime m3STDT, 
			string m3OBV1, 
			string m3AGNO = null, 
			string m3HRE2 = null, 
			string m3LRE2 = null, 
			DateTime? m3LVDT = null, 
			string m3PRRF = null, 
			string m3PRLC = null, 
			string m3SPUN = null, 
			string m3SUNO = null, 
			string m3AGNB = null, 
			decimal? m3AGQT = null, 
			string m3UNIT = null, 
			decimal? m3D2QT = null, 
			decimal? m3D3QT = null, 
			decimal? m3NAQT = null, 
			DateTime? m3PLDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchLn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("OBV1", m3OBV1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AGNO))
				request.WithQueryParameter("AGNO", m3AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3HRE2))
				request.WithQueryParameter("HRE2", m3HRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3LRE2))
				request.WithQueryParameter("LRE2", m3LRE2.Trim());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRLC))
				request.WithQueryParameter("PRLC", m3PRLC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPUN))
				request.WithQueryParameter("SPUN", m3SPUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (m3AGQT.HasValue)
				request.WithQueryParameter("AGQT", m3AGQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (m3D2QT.HasValue)
				request.WithQueryParameter("D2QT", m3D2QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D3QT.HasValue)
				request.WithQueryParameter("D3QT", m3D3QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NAQT.HasValue)
				request.WithQueryParameter("NAQT", m3NAQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLDT.HasValue)
				request.WithQueryParameter("PLDT", m3PLDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<AddBatchLnResponse>(
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
		/// Name AddBatchPrice
		/// Description Add Batch Price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="m3OBV1">Start value 1 (Required)</param>
		/// <param name="m3AGNO">Blanket agreement number</param>
		/// <param name="m3HRE2">Bulk order header reference</param>
		/// <param name="m3LRE2">Bulk order line reference</param>
		/// <param name="m3QTYL">Lowest quantity limit</param>
		/// <param name="m3AGPR">Agreed price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3DIPC">Discount</param>
		/// <param name="m3DIPR">Discount amount per unit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchPriceResponse></returns>
		/// <exception cref="M3Exception<AddBatchPriceResponse>"></exception>
		public async Task<M3Response<AddBatchPriceResponse>> AddBatchPrice(
			string m3MSGN, 
			string m3CUNO, 
			DateTime m3FDAT, 
			DateTime m3STDT, 
			string m3OBV1, 
			string m3AGNO = null, 
			string m3HRE2 = null, 
			string m3LRE2 = null, 
			decimal? m3QTYL = null, 
			decimal? m3AGPR = null, 
			int? m3SACD = null, 
			int? m3DIPC = null, 
			decimal? m3DIPR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBatchPrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3OBV1))
				throw new ArgumentNullException(nameof(m3OBV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("STDT", m3STDT.ToM3String())
				.WithQueryParameter("OBV1", m3OBV1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AGNO))
				request.WithQueryParameter("AGNO", m3AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3HRE2))
				request.WithQueryParameter("HRE2", m3HRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3LRE2))
				request.WithQueryParameter("LRE2", m3LRE2.Trim());
			if (m3QTYL.HasValue)
				request.WithQueryParameter("QTYL", m3QTYL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGPR.HasValue)
				request.WithQueryParameter("AGPR", m3AGPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3DIPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIPR.HasValue)
				request.WithQueryParameter("DIPR", m3DIPR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddBatchPriceResponse>(
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
		/// Name DeleteEntry
		/// Description Delete Entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteEntry(
			string m3MSGN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteEntry",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MSGN))
				request.WithQueryParameter("MSGN", m3MSGN.Trim());

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
		/// Name FinishEntry
		/// Description Finish entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> FinishEntry(
			string m3MSGN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/FinishEntry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim());

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
		/// Name StartEntry
		/// Description Start entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3BABU">Bulk order batch origin (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StartEntryResponse></returns>
		/// <exception cref="M3Exception<StartEntryResponse>"></exception>
		public async Task<M3Response<StartEntryResponse>> StartEntry(
			string m3BABU, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartEntry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BABU))
				throw new ArgumentNullException(nameof(m3BABU));

			// Set mandatory parameters
			request
				.WithQueryParameter("BABU", m3BABU.Trim());

			// Execute the request
			var result = await Execute<StartEntryResponse>(
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
