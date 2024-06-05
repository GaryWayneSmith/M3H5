/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddLocation
		/// Description Add stock location
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3WHSL">Location (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SLDS">Stock location description</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3SLDV">Multi-storage location</param>
		/// <param name="m3ALOC">Allocatable</param>
		/// <param name="m3SALO">Single allocation</param>
		/// <param name="m3DEHO">Delay</param>
		/// <param name="m3DEST">Status proposal</param>
		/// <param name="m3AUDE">Automatic deletion</param>
		/// <param name="m3AUDD">Automatic deletion delay</param>
		/// <param name="m3IDDT">Last receipt date</param>
		/// <param name="m3ODDT">Last issue date</param>
		/// <param name="m3NBRL">Number of balance identities</param>
		/// <param name="m3MVOL">Maximum storage volume</param>
		/// <param name="m3AVOL">Current storage volume</param>
		/// <param name="m3MAXW">Maximum storage weight</param>
		/// <param name="m3ACTW">Current storage weight</param>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="m3EDP1">Editing position 1</param>
		/// <param name="m3EDP2">Editing position 2</param>
		/// <param name="m3EDS1">Editing character 1</param>
		/// <param name="m3EDS2">Editing character 2</param>
		/// <param name="m3TRFL">Transportation flow</param>
		/// <param name="m3ABFC">ABC class - frequency</param>
		/// <param name="m3SPID">Distribution identity</param>
		/// <param name="m3WHLT">Location type</param>
		/// <param name="m3STFU">Transaction statistics</param>
		/// <param name="m3MFRT">Max filling rate</param>
		/// <param name="m3FRTE">Current filling rate</param>
		/// <param name="m3PACL">Packaging length</param>
		/// <param name="m3PACW">Packaging width</param>
		/// <param name="m3PACH">Packaging height</param>
		/// <param name="m3CMNG">Container management</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CHKC">Check code</param>
		/// <param name="m3LOCG">Location group</param>
		/// <param name="m3LCHK">Check code - location</param>
		/// <param name="m3GEOX">Geographic cod X</param>
		/// <param name="m3GEOY">Geographic code Y</param>
		/// <param name="m3GEOZ">Geographic cod  Z</param>
		/// <param name="m3WHLC">Location characteristic</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLocation(
			string m3WHLO, 
			string m3WHSL, 
			int? m3CONO = null, 
			string m3SLDS = null, 
			string m3SLTP = null, 
			string m3RESP = null, 
			int? m3SLDV = null, 
			int? m3ALOC = null, 
			int? m3SALO = null, 
			int? m3DEHO = null, 
			string m3DEST = null, 
			int? m3AUDE = null, 
			int? m3AUDD = null, 
			DateTime? m3IDDT = null, 
			DateTime? m3ODDT = null, 
			int? m3NBRL = null, 
			decimal? m3MVOL = null, 
			decimal? m3AVOL = null, 
			decimal? m3MAXW = null, 
			decimal? m3ACTW = null, 
			string m3PISE = null, 
			int? m3EDP1 = null, 
			int? m3EDP2 = null, 
			string m3EDS1 = null, 
			string m3EDS2 = null, 
			string m3TRFL = null, 
			string m3ABFC = null, 
			string m3SPID = null, 
			string m3WHLT = null, 
			int? m3STFU = null, 
			int? m3MFRT = null, 
			int? m3FRTE = null, 
			int? m3PACL = null, 
			int? m3PACW = null, 
			int? m3PACH = null, 
			int? m3CMNG = null, 
			string m3CUNO = null, 
			decimal? m3TXID = null, 
			int? m3CHKC = null, 
			string m3LOCG = null, 
			string m3LCHK = null, 
			decimal? m3GEOX = null, 
			decimal? m3GEOY = null, 
			decimal? m3GEOZ = null, 
			int? m3WHLC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddLocation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLDS))
				request.WithQueryParameter("SLDS", m3SLDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3SLDV.HasValue)
				request.WithQueryParameter("SLDV", m3SLDV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3ALOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SALO.HasValue)
				request.WithQueryParameter("SALO", m3SALO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEHO.HasValue)
				request.WithQueryParameter("DEHO", m3DEHO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DEST))
				request.WithQueryParameter("DEST", m3DEST.Trim());
			if (m3AUDE.HasValue)
				request.WithQueryParameter("AUDE", m3AUDE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUDD.HasValue)
				request.WithQueryParameter("AUDD", m3AUDD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDDT.HasValue)
				request.WithQueryParameter("IDDT", m3IDDT.Value.ToM3String());
			if (m3ODDT.HasValue)
				request.WithQueryParameter("ODDT", m3ODDT.Value.ToM3String());
			if (m3NBRL.HasValue)
				request.WithQueryParameter("NBRL", m3NBRL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVOL.HasValue)
				request.WithQueryParameter("MVOL", m3MVOL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVOL.HasValue)
				request.WithQueryParameter("AVOL", m3AVOL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAXW.HasValue)
				request.WithQueryParameter("MAXW", m3MAXW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTW.HasValue)
				request.WithQueryParameter("ACTW", m3ACTW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());
			if (m3EDP1.HasValue)
				request.WithQueryParameter("EDP1", m3EDP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EDP2.HasValue)
				request.WithQueryParameter("EDP2", m3EDP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EDS1))
				request.WithQueryParameter("EDS1", m3EDS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDS2))
				request.WithQueryParameter("EDS2", m3EDS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRFL))
				request.WithQueryParameter("TRFL", m3TRFL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABFC))
				request.WithQueryParameter("ABFC", m3ABFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPID))
				request.WithQueryParameter("SPID", m3SPID.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (m3STFU.HasValue)
				request.WithQueryParameter("STFU", m3STFU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFRT.HasValue)
				request.WithQueryParameter("MFRT", m3MFRT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRTE.HasValue)
				request.WithQueryParameter("FRTE", m3FRTE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACL.HasValue)
				request.WithQueryParameter("PACL", m3PACL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACW.HasValue)
				request.WithQueryParameter("PACW", m3PACW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACH.HasValue)
				request.WithQueryParameter("PACH", m3PACH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CMNG.HasValue)
				request.WithQueryParameter("CMNG", m3CMNG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHKC.HasValue)
				request.WithQueryParameter("CHKC", m3CHKC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LOCG))
				request.WithQueryParameter("LOCG", m3LOCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCHK))
				request.WithQueryParameter("LCHK", m3LCHK.Trim());
			if (m3GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3GEOX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3GEOY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3GEOZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WHLC.HasValue)
				request.WithQueryParameter("WHLC", m3WHLC.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgLocation
		/// Description Change stock location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3WHSL">Location (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SLDS">Stock location description</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3SLDV">Multi-storage location</param>
		/// <param name="m3ALOC">Allocatable</param>
		/// <param name="m3SALO">Single allocation</param>
		/// <param name="m3DEHO">Delay</param>
		/// <param name="m3DEST">Status proposal</param>
		/// <param name="m3AUDE">Automatic deletion</param>
		/// <param name="m3AUDD">Automatic deletion delay</param>
		/// <param name="m3IDDT">Last receipt date</param>
		/// <param name="m3ODDT">Last issue date</param>
		/// <param name="m3NBRL">Number of balance identities</param>
		/// <param name="m3MVOL">Maximum storage volume</param>
		/// <param name="m3AVOL">Current storage volume</param>
		/// <param name="m3MAXW">Maximum storage weight</param>
		/// <param name="m3ACTW">Current storage weight</param>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="m3EDP1">Editing position 1</param>
		/// <param name="m3EDP2">Editing position 2</param>
		/// <param name="m3EDS1">Editing character 1</param>
		/// <param name="m3EDS2">Editing character 2</param>
		/// <param name="m3TRFL">Transportation flow</param>
		/// <param name="m3ABFC">ABC class - frequency</param>
		/// <param name="m3SPID">Distribution identity</param>
		/// <param name="m3WHLT">Location type</param>
		/// <param name="m3STFU">Transaction statistics</param>
		/// <param name="m3MFRT">Max filling rate</param>
		/// <param name="m3FRTE">Current filling rate</param>
		/// <param name="m3PACL">Packaging length</param>
		/// <param name="m3PACW">Packaging width</param>
		/// <param name="m3PACH">Packaging height</param>
		/// <param name="m3CMNG">Container management</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CHKC">Check code</param>
		/// <param name="m3LOCG">Location group</param>
		/// <param name="m3LCHK">Check code - location</param>
		/// <param name="m3WHLC">Location characteristic</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgLocation(
			string m3WHLO, 
			string m3WHSL, 
			int? m3CONO = null, 
			string m3SLDS = null, 
			string m3SLTP = null, 
			string m3RESP = null, 
			int? m3SLDV = null, 
			int? m3ALOC = null, 
			int? m3SALO = null, 
			int? m3DEHO = null, 
			string m3DEST = null, 
			int? m3AUDE = null, 
			int? m3AUDD = null, 
			DateTime? m3IDDT = null, 
			DateTime? m3ODDT = null, 
			int? m3NBRL = null, 
			decimal? m3MVOL = null, 
			decimal? m3AVOL = null, 
			decimal? m3MAXW = null, 
			decimal? m3ACTW = null, 
			string m3PISE = null, 
			int? m3EDP1 = null, 
			int? m3EDP2 = null, 
			string m3EDS1 = null, 
			string m3EDS2 = null, 
			string m3TRFL = null, 
			string m3ABFC = null, 
			string m3SPID = null, 
			string m3WHLT = null, 
			int? m3STFU = null, 
			int? m3MFRT = null, 
			int? m3FRTE = null, 
			int? m3PACL = null, 
			int? m3PACW = null, 
			int? m3PACH = null, 
			int? m3CMNG = null, 
			string m3CUNO = null, 
			decimal? m3TXID = null, 
			int? m3CHKC = null, 
			string m3LOCG = null, 
			string m3LCHK = null, 
			int? m3WHLC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgLocation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLDS))
				request.WithQueryParameter("SLDS", m3SLDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3SLDV.HasValue)
				request.WithQueryParameter("SLDV", m3SLDV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3ALOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SALO.HasValue)
				request.WithQueryParameter("SALO", m3SALO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEHO.HasValue)
				request.WithQueryParameter("DEHO", m3DEHO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DEST))
				request.WithQueryParameter("DEST", m3DEST.Trim());
			if (m3AUDE.HasValue)
				request.WithQueryParameter("AUDE", m3AUDE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUDD.HasValue)
				request.WithQueryParameter("AUDD", m3AUDD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IDDT.HasValue)
				request.WithQueryParameter("IDDT", m3IDDT.Value.ToM3String());
			if (m3ODDT.HasValue)
				request.WithQueryParameter("ODDT", m3ODDT.Value.ToM3String());
			if (m3NBRL.HasValue)
				request.WithQueryParameter("NBRL", m3NBRL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVOL.HasValue)
				request.WithQueryParameter("MVOL", m3MVOL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AVOL.HasValue)
				request.WithQueryParameter("AVOL", m3AVOL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAXW.HasValue)
				request.WithQueryParameter("MAXW", m3MAXW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTW.HasValue)
				request.WithQueryParameter("ACTW", m3ACTW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());
			if (m3EDP1.HasValue)
				request.WithQueryParameter("EDP1", m3EDP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EDP2.HasValue)
				request.WithQueryParameter("EDP2", m3EDP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EDS1))
				request.WithQueryParameter("EDS1", m3EDS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDS2))
				request.WithQueryParameter("EDS2", m3EDS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRFL))
				request.WithQueryParameter("TRFL", m3TRFL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABFC))
				request.WithQueryParameter("ABFC", m3ABFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPID))
				request.WithQueryParameter("SPID", m3SPID.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (m3STFU.HasValue)
				request.WithQueryParameter("STFU", m3STFU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFRT.HasValue)
				request.WithQueryParameter("MFRT", m3MFRT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRTE.HasValue)
				request.WithQueryParameter("FRTE", m3FRTE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACL.HasValue)
				request.WithQueryParameter("PACL", m3PACL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACW.HasValue)
				request.WithQueryParameter("PACW", m3PACW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PACH.HasValue)
				request.WithQueryParameter("PACH", m3PACH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CMNG.HasValue)
				request.WithQueryParameter("CMNG", m3CMNG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHKC.HasValue)
				request.WithQueryParameter("CHKC", m3CHKC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LOCG))
				request.WithQueryParameter("LOCG", m3LOCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3LCHK))
				request.WithQueryParameter("LCHK", m3LCHK.Trim());
			if (m3WHLC.HasValue)
				request.WithQueryParameter("WHLC", m3WHLC.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelLocation
		/// Description Delete stock location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3WHSL">Location (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLocation(
			string m3WHLO, 
			string m3WHSL, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelLocation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetLocation
		/// Description Get stock location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3WHSL">Location (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLocationResponse></returns>
		/// <exception cref="M3Exception<GetLocationResponse>"></exception>
		public async Task<M3Response<GetLocationResponse>> GetLocation(
			string m3WHLO, 
			string m3WHSL, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLocation",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetLocationResponse>(
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
		/// Name ListLocations
		/// Description List stock locations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListLocationsResponse></returns>
		/// <exception cref="M3Exception<ListLocationsResponse>"></exception>
		public async Task<M3Response<ListLocationsResponse>> ListLocations(
			int? m3CONO = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListLocations",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Execute the request
			var result = await Execute<ListLocationsResponse>(
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
		/// Name LstByLocType
		/// Description LstByLocType
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3WHLT">Location type</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByLocTypeResponse></returns>
		/// <exception cref="M3Exception<LstByLocTypeResponse>"></exception>
		public async Task<M3Response<LstByLocTypeResponse>> LstByLocType(
			string m3WHLO, 
			string m3WHLT = null, 
			string m3WHSL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByLocType",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Execute the request
			var result = await Execute<LstByLocTypeResponse>(
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
		/// Name LstByStkZone
		/// Description LstByStkZone
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByStkZoneResponse></returns>
		/// <exception cref="M3Exception<LstByStkZoneResponse>"></exception>
		public async Task<M3Response<LstByStkZoneResponse>> LstByStkZone(
			string m3WHLO, 
			string m3SLTP = null, 
			string m3WHSL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByStkZone",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Execute the request
			var result = await Execute<LstByStkZoneResponse>(
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
		/// Name LstLocByBal
		/// Description List Locations by Number of Balance Identities
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3WHLT">Location type (Required)</param>
		/// <param name="m3NBRL">Number of balance identities (Required)</param>
		/// <param name="m3FWHS">From Location</param>
		/// <param name="m3TWHS">To Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLocByBalResponse></returns>
		/// <exception cref="M3Exception<LstLocByBalResponse>"></exception>
		public async Task<M3Response<LstLocByBalResponse>> LstLocByBal(
			string m3WHLO, 
			string m3WHLT, 
			int m3NBRL, 
			string m3FWHS = null, 
			string m3TWHS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLocByBal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3WHLT))
				throw new ArgumentNullException(nameof(m3WHLT));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("WHLT", m3WHLT.Trim())
				.WithQueryParameter("NBRL", m3NBRL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FWHS))
				request.WithQueryParameter("FWHS", m3FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHS))
				request.WithQueryParameter("TWHS", m3TWHS.Trim());

			// Execute the request
			var result = await Execute<LstLocByBalResponse>(
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
		/// Name LstLocGrp
		/// Description ListLocationsGroups
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3LOCG">Location group</param>
		/// <param name="m3ABFC">ABC class - frequency</param>
		/// <param name="m3NBRL">Number of balance identities</param>
		/// <param name="m3NORC">Number of records</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLocGrpResponse></returns>
		/// <exception cref="M3Exception<LstLocGrpResponse>"></exception>
		public async Task<M3Response<LstLocGrpResponse>> LstLocGrp(
			string m3WHLO, 
			string m3WHSL = null, 
			string m3LOCG = null, 
			string m3ABFC = null, 
			int? m3NBRL = null, 
			int? m3NORC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLocGrp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOCG))
				request.WithQueryParameter("LOCG", m3LOCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABFC))
				request.WithQueryParameter("ABFC", m3ABFC.Trim());
			if (m3NBRL.HasValue)
				request.WithQueryParameter("NBRL", m3NBRL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NORC.HasValue)
				request.WithQueryParameter("NORC", m3NORC.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLocGrpResponse>(
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
		/// Name SetLocAllocable
		/// Description Set location allocable
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3WHSL">Location (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ALOC">Allocable</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetLocAllocable(
			string m3WHLO, 
			string m3WHSL, 
			int? m3CONO = null, 
			int? m3ALOC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SetLocAllocable",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3WHSL))
				throw new ArgumentNullException(nameof(m3WHSL));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3ALOC.Value.ToString(CultureInfo.CurrentCulture));

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
