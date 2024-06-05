/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS010MI;
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
	/// Name: MMS010MI
	/// Component Name: ListLocations
	/// Description: Stock location interface
	/// Version Release: 5ea3
	///</summary>
	public partial class MMS010MIResource : M3BaseResourceEndpoint
	{
		public MMS010MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS010MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddLocation
		/// Description Add stock location
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_WHSL">Location (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SLDS">Stock location description</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_SLDV">Multi-storage location</param>
		/// <param name="m3_ALOC">Allocatable</param>
		/// <param name="m3_SALO">Single allocation</param>
		/// <param name="m3_DEHO">Delay</param>
		/// <param name="m3_DEST">Status proposal</param>
		/// <param name="m3_AUDE">Automatic deletion</param>
		/// <param name="m3_AUDD">Automatic deletion delay</param>
		/// <param name="m3_IDDT">Last receipt date</param>
		/// <param name="m3_ODDT">Last issue date</param>
		/// <param name="m3_NBRL">Number of balance identities</param>
		/// <param name="m3_MVOL">Maximum storage volume</param>
		/// <param name="m3_AVOL">Current storage volume</param>
		/// <param name="m3_MAXW">Maximum storage weight</param>
		/// <param name="m3_ACTW">Current storage weight</param>
		/// <param name="m3_PISE">Warehouse equipment</param>
		/// <param name="m3_EDP1">Editing position 1</param>
		/// <param name="m3_EDP2">Editing position 2</param>
		/// <param name="m3_EDS1">Editing character 1</param>
		/// <param name="m3_EDS2">Editing character 2</param>
		/// <param name="m3_TRFL">Transportation flow</param>
		/// <param name="m3_ABFC">ABC class - frequency</param>
		/// <param name="m3_SPID">Distribution identity</param>
		/// <param name="m3_WHLT">Location type</param>
		/// <param name="m3_STFU">Transaction statistics</param>
		/// <param name="m3_MFRT">Max filling rate</param>
		/// <param name="m3_FRTE">Current filling rate</param>
		/// <param name="m3_PACL">Packaging length</param>
		/// <param name="m3_PACW">Packaging width</param>
		/// <param name="m3_PACH">Packaging height</param>
		/// <param name="m3_CMNG">Container management</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CHKC">Check code</param>
		/// <param name="m3_LOCG">Location group</param>
		/// <param name="m3_LCHK">Check code - location</param>
		/// <param name="m3_GEOX">Geographic cod X</param>
		/// <param name="m3_GEOY">Geographic code Y</param>
		/// <param name="m3_GEOZ">Geographic cod  Z</param>
		/// <param name="m3_WHLC">Location characteristic</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLocation(
			string m3_WHLO, 
			string m3_WHSL, 
			int? m3_CONO = null, 
			string m3_SLDS = null, 
			string m3_SLTP = null, 
			string m3_RESP = null, 
			int? m3_SLDV = null, 
			int? m3_ALOC = null, 
			int? m3_SALO = null, 
			int? m3_DEHO = null, 
			string m3_DEST = null, 
			int? m3_AUDE = null, 
			int? m3_AUDD = null, 
			DateTime? m3_IDDT = null, 
			DateTime? m3_ODDT = null, 
			int? m3_NBRL = null, 
			decimal? m3_MVOL = null, 
			decimal? m3_AVOL = null, 
			decimal? m3_MAXW = null, 
			decimal? m3_ACTW = null, 
			string m3_PISE = null, 
			int? m3_EDP1 = null, 
			int? m3_EDP2 = null, 
			string m3_EDS1 = null, 
			string m3_EDS2 = null, 
			string m3_TRFL = null, 
			string m3_ABFC = null, 
			string m3_SPID = null, 
			string m3_WHLT = null, 
			int? m3_STFU = null, 
			int? m3_MFRT = null, 
			int? m3_FRTE = null, 
			int? m3_PACL = null, 
			int? m3_PACW = null, 
			int? m3_PACH = null, 
			int? m3_CMNG = null, 
			string m3_CUNO = null, 
			decimal? m3_TXID = null, 
			int? m3_CHKC = null, 
			string m3_LOCG = null, 
			string m3_LCHK = null, 
			decimal? m3_GEOX = null, 
			decimal? m3_GEOY = null, 
			decimal? m3_GEOZ = null, 
			int? m3_WHLC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLocation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("WHSL", m3_WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLDS))
				request.WithQueryParameter("SLDS", m3_SLDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_SLDV.HasValue)
				request.WithQueryParameter("SLDV", m3_SLDV.Value.ToString());
			if (m3_ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3_ALOC.Value.ToString());
			if (m3_SALO.HasValue)
				request.WithQueryParameter("SALO", m3_SALO.Value.ToString());
			if (m3_DEHO.HasValue)
				request.WithQueryParameter("DEHO", m3_DEHO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DEST))
				request.WithQueryParameter("DEST", m3_DEST.Trim());
			if (m3_AUDE.HasValue)
				request.WithQueryParameter("AUDE", m3_AUDE.Value.ToString());
			if (m3_AUDD.HasValue)
				request.WithQueryParameter("AUDD", m3_AUDD.Value.ToString());
			if (m3_IDDT.HasValue)
				request.WithQueryParameter("IDDT", m3_IDDT.Value.ToM3String());
			if (m3_ODDT.HasValue)
				request.WithQueryParameter("ODDT", m3_ODDT.Value.ToM3String());
			if (m3_NBRL.HasValue)
				request.WithQueryParameter("NBRL", m3_NBRL.Value.ToString());
			if (m3_MVOL.HasValue)
				request.WithQueryParameter("MVOL", m3_MVOL.Value.ToString());
			if (m3_AVOL.HasValue)
				request.WithQueryParameter("AVOL", m3_AVOL.Value.ToString());
			if (m3_MAXW.HasValue)
				request.WithQueryParameter("MAXW", m3_MAXW.Value.ToString());
			if (m3_ACTW.HasValue)
				request.WithQueryParameter("ACTW", m3_ACTW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PISE))
				request.WithQueryParameter("PISE", m3_PISE.Trim());
			if (m3_EDP1.HasValue)
				request.WithQueryParameter("EDP1", m3_EDP1.Value.ToString());
			if (m3_EDP2.HasValue)
				request.WithQueryParameter("EDP2", m3_EDP2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EDS1))
				request.WithQueryParameter("EDS1", m3_EDS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDS2))
				request.WithQueryParameter("EDS2", m3_EDS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRFL))
				request.WithQueryParameter("TRFL", m3_TRFL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABFC))
				request.WithQueryParameter("ABFC", m3_ABFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPID))
				request.WithQueryParameter("SPID", m3_SPID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (m3_STFU.HasValue)
				request.WithQueryParameter("STFU", m3_STFU.Value.ToString());
			if (m3_MFRT.HasValue)
				request.WithQueryParameter("MFRT", m3_MFRT.Value.ToString());
			if (m3_FRTE.HasValue)
				request.WithQueryParameter("FRTE", m3_FRTE.Value.ToString());
			if (m3_PACL.HasValue)
				request.WithQueryParameter("PACL", m3_PACL.Value.ToString());
			if (m3_PACW.HasValue)
				request.WithQueryParameter("PACW", m3_PACW.Value.ToString());
			if (m3_PACH.HasValue)
				request.WithQueryParameter("PACH", m3_PACH.Value.ToString());
			if (m3_CMNG.HasValue)
				request.WithQueryParameter("CMNG", m3_CMNG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_CHKC.HasValue)
				request.WithQueryParameter("CHKC", m3_CHKC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LOCG))
				request.WithQueryParameter("LOCG", m3_LOCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCHK))
				request.WithQueryParameter("LCHK", m3_LCHK.Trim());
			if (m3_GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3_GEOX.Value.ToString());
			if (m3_GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3_GEOY.Value.ToString());
			if (m3_GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3_GEOZ.Value.ToString());
			if (m3_WHLC.HasValue)
				request.WithQueryParameter("WHLC", m3_WHLC.Value.ToString());

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
		/// Name ChgLocation
		/// Description Change stock location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_WHSL">Location (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SLDS">Stock location description</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_SLDV">Multi-storage location</param>
		/// <param name="m3_ALOC">Allocatable</param>
		/// <param name="m3_SALO">Single allocation</param>
		/// <param name="m3_DEHO">Delay</param>
		/// <param name="m3_DEST">Status proposal</param>
		/// <param name="m3_AUDE">Automatic deletion</param>
		/// <param name="m3_AUDD">Automatic deletion delay</param>
		/// <param name="m3_IDDT">Last receipt date</param>
		/// <param name="m3_ODDT">Last issue date</param>
		/// <param name="m3_NBRL">Number of balance identities</param>
		/// <param name="m3_MVOL">Maximum storage volume</param>
		/// <param name="m3_AVOL">Current storage volume</param>
		/// <param name="m3_MAXW">Maximum storage weight</param>
		/// <param name="m3_ACTW">Current storage weight</param>
		/// <param name="m3_PISE">Warehouse equipment</param>
		/// <param name="m3_EDP1">Editing position 1</param>
		/// <param name="m3_EDP2">Editing position 2</param>
		/// <param name="m3_EDS1">Editing character 1</param>
		/// <param name="m3_EDS2">Editing character 2</param>
		/// <param name="m3_TRFL">Transportation flow</param>
		/// <param name="m3_ABFC">ABC class - frequency</param>
		/// <param name="m3_SPID">Distribution identity</param>
		/// <param name="m3_WHLT">Location type</param>
		/// <param name="m3_STFU">Transaction statistics</param>
		/// <param name="m3_MFRT">Max filling rate</param>
		/// <param name="m3_FRTE">Current filling rate</param>
		/// <param name="m3_PACL">Packaging length</param>
		/// <param name="m3_PACW">Packaging width</param>
		/// <param name="m3_PACH">Packaging height</param>
		/// <param name="m3_CMNG">Container management</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CHKC">Check code</param>
		/// <param name="m3_LOCG">Location group</param>
		/// <param name="m3_LCHK">Check code - location</param>
		/// <param name="m3_WHLC">Location characteristic</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgLocation(
			string m3_WHLO, 
			string m3_WHSL, 
			int? m3_CONO = null, 
			string m3_SLDS = null, 
			string m3_SLTP = null, 
			string m3_RESP = null, 
			int? m3_SLDV = null, 
			int? m3_ALOC = null, 
			int? m3_SALO = null, 
			int? m3_DEHO = null, 
			string m3_DEST = null, 
			int? m3_AUDE = null, 
			int? m3_AUDD = null, 
			DateTime? m3_IDDT = null, 
			DateTime? m3_ODDT = null, 
			int? m3_NBRL = null, 
			decimal? m3_MVOL = null, 
			decimal? m3_AVOL = null, 
			decimal? m3_MAXW = null, 
			decimal? m3_ACTW = null, 
			string m3_PISE = null, 
			int? m3_EDP1 = null, 
			int? m3_EDP2 = null, 
			string m3_EDS1 = null, 
			string m3_EDS2 = null, 
			string m3_TRFL = null, 
			string m3_ABFC = null, 
			string m3_SPID = null, 
			string m3_WHLT = null, 
			int? m3_STFU = null, 
			int? m3_MFRT = null, 
			int? m3_FRTE = null, 
			int? m3_PACL = null, 
			int? m3_PACW = null, 
			int? m3_PACH = null, 
			int? m3_CMNG = null, 
			string m3_CUNO = null, 
			decimal? m3_TXID = null, 
			int? m3_CHKC = null, 
			string m3_LOCG = null, 
			string m3_LCHK = null, 
			int? m3_WHLC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgLocation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("WHSL", m3_WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLDS))
				request.WithQueryParameter("SLDS", m3_SLDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_SLDV.HasValue)
				request.WithQueryParameter("SLDV", m3_SLDV.Value.ToString());
			if (m3_ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3_ALOC.Value.ToString());
			if (m3_SALO.HasValue)
				request.WithQueryParameter("SALO", m3_SALO.Value.ToString());
			if (m3_DEHO.HasValue)
				request.WithQueryParameter("DEHO", m3_DEHO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DEST))
				request.WithQueryParameter("DEST", m3_DEST.Trim());
			if (m3_AUDE.HasValue)
				request.WithQueryParameter("AUDE", m3_AUDE.Value.ToString());
			if (m3_AUDD.HasValue)
				request.WithQueryParameter("AUDD", m3_AUDD.Value.ToString());
			if (m3_IDDT.HasValue)
				request.WithQueryParameter("IDDT", m3_IDDT.Value.ToM3String());
			if (m3_ODDT.HasValue)
				request.WithQueryParameter("ODDT", m3_ODDT.Value.ToM3String());
			if (m3_NBRL.HasValue)
				request.WithQueryParameter("NBRL", m3_NBRL.Value.ToString());
			if (m3_MVOL.HasValue)
				request.WithQueryParameter("MVOL", m3_MVOL.Value.ToString());
			if (m3_AVOL.HasValue)
				request.WithQueryParameter("AVOL", m3_AVOL.Value.ToString());
			if (m3_MAXW.HasValue)
				request.WithQueryParameter("MAXW", m3_MAXW.Value.ToString());
			if (m3_ACTW.HasValue)
				request.WithQueryParameter("ACTW", m3_ACTW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PISE))
				request.WithQueryParameter("PISE", m3_PISE.Trim());
			if (m3_EDP1.HasValue)
				request.WithQueryParameter("EDP1", m3_EDP1.Value.ToString());
			if (m3_EDP2.HasValue)
				request.WithQueryParameter("EDP2", m3_EDP2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EDS1))
				request.WithQueryParameter("EDS1", m3_EDS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDS2))
				request.WithQueryParameter("EDS2", m3_EDS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRFL))
				request.WithQueryParameter("TRFL", m3_TRFL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABFC))
				request.WithQueryParameter("ABFC", m3_ABFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPID))
				request.WithQueryParameter("SPID", m3_SPID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (m3_STFU.HasValue)
				request.WithQueryParameter("STFU", m3_STFU.Value.ToString());
			if (m3_MFRT.HasValue)
				request.WithQueryParameter("MFRT", m3_MFRT.Value.ToString());
			if (m3_FRTE.HasValue)
				request.WithQueryParameter("FRTE", m3_FRTE.Value.ToString());
			if (m3_PACL.HasValue)
				request.WithQueryParameter("PACL", m3_PACL.Value.ToString());
			if (m3_PACW.HasValue)
				request.WithQueryParameter("PACW", m3_PACW.Value.ToString());
			if (m3_PACH.HasValue)
				request.WithQueryParameter("PACH", m3_PACH.Value.ToString());
			if (m3_CMNG.HasValue)
				request.WithQueryParameter("CMNG", m3_CMNG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_CHKC.HasValue)
				request.WithQueryParameter("CHKC", m3_CHKC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LOCG))
				request.WithQueryParameter("LOCG", m3_LOCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LCHK))
				request.WithQueryParameter("LCHK", m3_LCHK.Trim());
			if (m3_WHLC.HasValue)
				request.WithQueryParameter("WHLC", m3_WHLC.Value.ToString());

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
		/// Name DelLocation
		/// Description Delete stock location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_WHSL">Location (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLocation(
			string m3_WHLO, 
			string m3_WHSL, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLocation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("WHSL", m3_WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name GetLocation
		/// Description Get stock location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_WHSL">Location (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLocationResponse></returns>
		/// <exception cref="M3Exception<GetLocationResponse>"></exception>
		public async Task<M3Response<GetLocationResponse>> GetLocation(
			string m3_WHLO, 
			string m3_WHSL, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLocation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("WHSL", m3_WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetLocationResponse>(
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
		/// Name ListLocations
		/// Description List stock locations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListLocationsResponse></returns>
		/// <exception cref="M3Exception<ListLocationsResponse>"></exception>
		public async Task<M3Response<ListLocationsResponse>> ListLocations(
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListLocations",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());

			// Execute the request
			var result = await Execute<ListLocationsResponse>(
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
		/// Name LstByLocType
		/// Description LstByLocType
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_WHLT">Location type</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByLocTypeResponse></returns>
		/// <exception cref="M3Exception<LstByLocTypeResponse>"></exception>
		public async Task<M3Response<LstByLocTypeResponse>> LstByLocType(
			string m3_WHLO, 
			string m3_WHLT = null, 
			string m3_WHSL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByLocType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLT))
				request.WithQueryParameter("WHLT", m3_WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());

			// Execute the request
			var result = await Execute<LstByLocTypeResponse>(
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
		/// Name LstByStkZone
		/// Description LstByStkZone
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SLTP">Stock zone</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByStkZoneResponse></returns>
		/// <exception cref="M3Exception<LstByStkZoneResponse>"></exception>
		public async Task<M3Response<LstByStkZoneResponse>> LstByStkZone(
			string m3_WHLO, 
			string m3_SLTP = null, 
			string m3_WHSL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByStkZone",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SLTP))
				request.WithQueryParameter("SLTP", m3_SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());

			// Execute the request
			var result = await Execute<LstByStkZoneResponse>(
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
		/// Name LstLocByBal
		/// Description List Locations by Number of Balance Identities
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_WHLT">Location type (Required)</param>
		/// <param name="m3_NBRL">Number of balance identities (Required)</param>
		/// <param name="m3_FWHS">From Location</param>
		/// <param name="m3_TWHS">To Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLocByBalResponse></returns>
		/// <exception cref="M3Exception<LstLocByBalResponse>"></exception>
		public async Task<M3Response<LstLocByBalResponse>> LstLocByBal(
			string m3_WHLO, 
			string m3_WHLT, 
			int m3_NBRL, 
			string m3_FWHS = null, 
			string m3_TWHS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLocByBal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_WHLT))
				throw new ArgumentNullException("m3_WHLT");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("WHLT", m3_WHLT.Trim())
				.WithQueryParameter("NBRL", m3_NBRL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FWHS))
				request.WithQueryParameter("FWHS", m3_FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHS))
				request.WithQueryParameter("TWHS", m3_TWHS.Trim());

			// Execute the request
			var result = await Execute<LstLocByBalResponse>(
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
		/// Name LstLocGrp
		/// Description ListLocationsGroups
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_LOCG">Location group</param>
		/// <param name="m3_ABFC">ABC class - frequency</param>
		/// <param name="m3_NBRL">Number of balance identities</param>
		/// <param name="m3_NORC">Number of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLocGrpResponse></returns>
		/// <exception cref="M3Exception<LstLocGrpResponse>"></exception>
		public async Task<M3Response<LstLocGrpResponse>> LstLocGrp(
			string m3_WHLO, 
			string m3_WHSL = null, 
			string m3_LOCG = null, 
			string m3_ABFC = null, 
			int? m3_NBRL = null, 
			int? m3_NORC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLocGrp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOCG))
				request.WithQueryParameter("LOCG", m3_LOCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ABFC))
				request.WithQueryParameter("ABFC", m3_ABFC.Trim());
			if (m3_NBRL.HasValue)
				request.WithQueryParameter("NBRL", m3_NBRL.Value.ToString());
			if (m3_NORC.HasValue)
				request.WithQueryParameter("NORC", m3_NORC.Value.ToString());

			// Execute the request
			var result = await Execute<LstLocGrpResponse>(
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
		/// Name SetLocAllocable
		/// Description Set location allocable
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_WHSL">Location (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ALOC">Allocable</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetLocAllocable(
			string m3_WHLO, 
			string m3_WHSL, 
			int? m3_CONO = null, 
			int? m3_ALOC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetLocAllocable",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_WHSL))
				throw new ArgumentNullException("m3_WHSL");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("WHSL", m3_WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3_ALOC.Value.ToString());

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
