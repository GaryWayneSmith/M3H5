/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CRS610MI;
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
	/// Name: CRS610MI
	/// Component Name: Customer
	/// Description: Customer interface
	/// Version Release: 5ea5
	///</summary>
	public partial class CRS610MIResource : M3BaseResourceEndpoint
	{
		public CRS610MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS610MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Create a new customer record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUTM">Customer template (Required)</param>
		/// <param name="m3CUNM">Customer name (Required)</param>
		/// <param name="m3CUA1">Customer address 1 (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3CUA2">Customer address 2</param>
		/// <param name="m3CUA3">Customer address 3</param>
		/// <param name="m3CUA4">Customer address 4</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3TFNO">Facsimile number</param>
		/// <param name="m3CUTP">Customer type</param>
		/// <param name="m3ALCU">Search key</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3YRE2">Your reference 2</param>
		/// <param name="m3MAIL">E-mail address</param>
		/// <param name="m3CSCD">Country code</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3CFC1">free field 1</param>
		/// <param name="m3CFC2">Free field 2</param>
		/// <param name="m3CFC3">Free field 3</param>
		/// <param name="m3CFC4">Free field 4</param>
		/// <param name="m3CFC5">Free field 5</param>
		/// <param name="m3CFC6">Free field 6</param>
		/// <param name="m3CFC7">Free field 7</param>
		/// <param name="m3CFC8">Free field 8</param>
		/// <param name="m3CFC9">Free field 9</param>
		/// <param name="m3CFC0">Free field 10</param>
		/// <param name="m3CESA">SMS id</param>
		/// <param name="m3STAT">Customer status</param>
		/// <param name="m3PWMT">Password</param>
		/// <param name="m3IVGP">Invoice group</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3CUSU">Our supplier number at customer</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3EALO">EAN location code</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3SPLE">Standard point location code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3CUTM, 
			string m3CUNM, 
			string m3CUA1, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3LNCD = null, 
			string m3CUNO = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3PONO = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3TFNO = null, 
			int? m3CUTP = null, 
			string m3ALCU = null, 
			string m3YREF = null, 
			string m3YRE2 = null, 
			string m3MAIL = null, 
			string m3CSCD = null, 
			string m3ECAR = null, 
			string m3CFC1 = null, 
			decimal? m3CFC2 = null, 
			string m3CFC3 = null, 
			string m3CFC4 = null, 
			string m3CFC5 = null, 
			string m3CFC6 = null, 
			decimal? m3CFC7 = null, 
			string m3CFC8 = null, 
			string m3CFC9 = null, 
			string m3CFC0 = null, 
			string m3CESA = null, 
			string m3STAT = null, 
			string m3PWMT = null, 
			string m3IVGP = null, 
			string m3TOWN = null, 
			string m3CUSU = null, 
			string m3FRCO = null, 
			string m3EDES = null, 
			decimal? m3EALO = null, 
			string m3RASN = null, 
			string m3SPLE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUTM))
				throw new ArgumentNullException(nameof(m3CUTM));
			if (string.IsNullOrWhiteSpace(m3CUNM))
				throw new ArgumentNullException(nameof(m3CUNM));
			if (string.IsNullOrWhiteSpace(m3CUA1))
				throw new ArgumentNullException(nameof(m3CUA1));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUTM", m3CUTM.Trim())
				.WithQueryParameter("CUNM", m3CUNM.Trim())
				.WithQueryParameter("CUA1", m3CUA1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (m3CUTP.HasValue)
				request.WithQueryParameter("CUTP", m3CUTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALCU))
				request.WithQueryParameter("ALCU", m3ALCU.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE2))
				request.WithQueryParameter("YRE2", m3YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAIL))
				request.WithQueryParameter("MAIL", m3MAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC1))
				request.WithQueryParameter("CFC1", m3CFC1.Trim());
			if (m3CFC2.HasValue)
				request.WithQueryParameter("CFC2", m3CFC2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFC3))
				request.WithQueryParameter("CFC3", m3CFC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC4))
				request.WithQueryParameter("CFC4", m3CFC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC5))
				request.WithQueryParameter("CFC5", m3CFC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC6))
				request.WithQueryParameter("CFC6", m3CFC6.Trim());
			if (m3CFC7.HasValue)
				request.WithQueryParameter("CFC7", m3CFC7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFC8))
				request.WithQueryParameter("CFC8", m3CFC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC9))
				request.WithQueryParameter("CFC9", m3CFC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC0))
				request.WithQueryParameter("CFC0", m3CFC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PWMT))
				request.WithQueryParameter("PWMT", m3PWMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IVGP))
				request.WithQueryParameter("IVGP", m3IVGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUSU))
				request.WithQueryParameter("CUSU", m3CUSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (m3EALO.HasValue)
				request.WithQueryParameter("EALO", m3EALO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPLE))
				request.WithQueryParameter("SPLE", m3SPLE.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name AddAddress
		/// Description Create a new customer address
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="m3CUA1">Customer address 1 (Required)</param>
		/// <param name="m3PONO">postal code (Required)</param>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3TOWN">City (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUA2">Customer address 2</param>
		/// <param name="m3CUA3">Customer address 3</param>
		/// <param name="m3CUA4">Customer address 4</param>
		/// <param name="m3ADVI">Via address</param>
		/// <param name="m3EALO">EAN location code</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3RONO">Run</param>
		/// <param name="m3DEPE">Departure</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Term of delivery</param>
		/// <param name="m3TEL2">Terms text</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile number</param>
		/// <param name="m3YREF">Your reference</param>
		/// <param name="m3LSID">User</param>
		/// <param name="m3LSAD">Address</param>
		/// <param name="m3MEAL">Valid media</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3EDES">Place-replaced by EDE2</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3ULZO">Unloading zone</param>
		/// <param name="m3CESA">Marketing ID in Movex SMS</param>
		/// <param name="m3GEOC">Geographic code</param>
		/// <param name="m3TAXC">Tax code</param>
		/// <param name="m3HAFE">Harbour or airport</param>
		/// <param name="m3EDE2">Place</param>
		/// <param name="m3GEOX">Geographic cod X</param>
		/// <param name="m3GEOY">Geographic code Y</param>
		/// <param name="m3GEOZ">Geographic cod  Z</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3SPLE">Standard point location code</param>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="m3ADCG">Address category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddAddressResponse></returns>
		/// <exception cref="M3Exception<AddAddressResponse>"></exception>
		public async Task<M3Response<AddAddressResponse>> AddAddress(
			string m3CUNO, 
			int m3ADRT, 
			string m3ADID, 
			string m3CUA1, 
			string m3PONO, 
			string m3CSCD, 
			string m3TOWN, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3CUNM = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3ADVI = null, 
			decimal? m3EALO = null, 
			string m3ECAR = null, 
			string m3RONO = null, 
			string m3DEPE = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEL2 = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3LSID = null, 
			string m3LSAD = null, 
			string m3MEAL = null, 
			string m3VRNO = null, 
			string m3EDES = null, 
			string m3ROUT = null, 
			int? m3RODN = null, 
			string m3ULZO = null, 
			string m3CESA = null, 
			int? m3GEOC = null, 
			string m3TAXC = null, 
			string m3HAFE = null, 
			string m3EDE2 = null, 
			decimal? m3GEOX = null, 
			decimal? m3GEOY = null, 
			decimal? m3GEOZ = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			string m3FRCO = null, 
			string m3RASN = null, 
			string m3SPLE = null, 
			int? m3PRIO = null, 
			string m3ADCG = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));
			if (string.IsNullOrWhiteSpace(m3CUA1))
				throw new ArgumentNullException(nameof(m3CUA1));
			if (string.IsNullOrWhiteSpace(m3PONO))
				throw new ArgumentNullException(nameof(m3PONO));
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));
			if (string.IsNullOrWhiteSpace(m3TOWN))
				throw new ArgumentNullException(nameof(m3TOWN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADID", m3ADID.Trim())
				.WithQueryParameter("CUA1", m3CUA1.Trim())
				.WithQueryParameter("PONO", m3PONO.Trim())
				.WithQueryParameter("CSCD", m3CSCD.Trim())
				.WithQueryParameter("TOWN", m3TOWN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADVI))
				request.WithQueryParameter("ADVI", m3ADVI.Trim());
			if (m3EALO.HasValue)
				request.WithQueryParameter("EALO", m3EALO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RONO))
				request.WithQueryParameter("RONO", m3RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPE))
				request.WithQueryParameter("DEPE", m3DEPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL2))
				request.WithQueryParameter("TEL2", m3TEL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3LSID))
				request.WithQueryParameter("LSID", m3LSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3LSAD))
				request.WithQueryParameter("LSAD", m3LSAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEAL))
				request.WithQueryParameter("MEAL", m3MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (m3RODN.HasValue)
				request.WithQueryParameter("RODN", m3RODN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ULZO))
				request.WithQueryParameter("ULZO", m3ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDE2))
				request.WithQueryParameter("EDE2", m3EDE2.Trim());
			if (m3GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3GEOX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3GEOY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3GEOZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPLE))
				request.WithQueryParameter("SPLE", m3SPLE.Trim());
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADCG))
				request.WithQueryParameter("ADCG", m3ADCG.Trim());

			// Execute the request
			var result = await Execute<AddAddressResponse>(
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
		/// Name AddCheckAddress
		/// Description Create and validate a new customer address
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="m3CUA1">Customer address 1 (Required)</param>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUA2">Customer address 2</param>
		/// <param name="m3CUA3">Customer address 3</param>
		/// <param name="m3CUA4">Customer address 4</param>
		/// <param name="m3PONO">postal code</param>
		/// <param name="m3ADVI">Via address</param>
		/// <param name="m3EALO">EAN location code</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3RONO">Run</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Term of delivery</param>
		/// <param name="m3TEL2">Terms text</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile number</param>
		/// <param name="m3YREF">Your reference</param>
		/// <param name="m3LSID">User</param>
		/// <param name="m3LSAD">Address</param>
		/// <param name="m3MEAL">Valid media</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3ULZO">Unloading zone</param>
		/// <param name="m3CESA">Marketing ID in Movex SMS</param>
		/// <param name="m3GEOC">Geographic code</param>
		/// <param name="m3TAXC">Tax code</param>
		/// <param name="m3HAFE">Harbour or airport</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3CALV">Calendar version</param>
		/// <param name="m3DLPA">Delivery pattern</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3SPLM">Supply model</param>
		/// <param name="m3BCKO">Backorder</param>
		/// <param name="m3PADL">Partial delivery</param>
		/// <param name="m3PNOD">Planning node</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3SPLE">Standard point location code</param>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="m3ADCG">Address category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCheckAddress(
			string m3CUNO, 
			int m3ADRT, 
			string m3ADID, 
			string m3CUA1, 
			string m3CSCD, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3CUNM = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3PONO = null, 
			string m3ADVI = null, 
			decimal? m3EALO = null, 
			string m3ECAR = null, 
			string m3RONO = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEL2 = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3LSID = null, 
			string m3LSAD = null, 
			string m3MEAL = null, 
			string m3VRNO = null, 
			string m3EDES = null, 
			string m3ULZO = null, 
			string m3CESA = null, 
			int? m3GEOC = null, 
			string m3TAXC = null, 
			string m3HAFE = null, 
			string m3TOWN = null, 
			string m3CALV = null, 
			string m3DLPA = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			string m3SPLM = null, 
			int? m3BCKO = null, 
			int? m3PADL = null, 
			string m3PNOD = null, 
			string m3FRCO = null, 
			string m3RASN = null, 
			string m3SPLE = null, 
			int? m3PRIO = null, 
			string m3ADCG = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCheckAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));
			if (string.IsNullOrWhiteSpace(m3CUA1))
				throw new ArgumentNullException(nameof(m3CUA1));
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADID", m3ADID.Trim())
				.WithQueryParameter("CUA1", m3CUA1.Trim())
				.WithQueryParameter("CSCD", m3CSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADVI))
				request.WithQueryParameter("ADVI", m3ADVI.Trim());
			if (m3EALO.HasValue)
				request.WithQueryParameter("EALO", m3EALO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RONO))
				request.WithQueryParameter("RONO", m3RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL2))
				request.WithQueryParameter("TEL2", m3TEL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3LSID))
				request.WithQueryParameter("LSID", m3LSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3LSAD))
				request.WithQueryParameter("LSAD", m3LSAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEAL))
				request.WithQueryParameter("MEAL", m3MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3ULZO))
				request.WithQueryParameter("ULZO", m3ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CALV))
				request.WithQueryParameter("CALV", m3CALV.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLPA))
				request.WithQueryParameter("DLPA", m3DLPA.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SPLM))
				request.WithQueryParameter("SPLM", m3SPLM.Trim());
			if (m3BCKO.HasValue)
				request.WithQueryParameter("BCKO", m3BCKO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PADL.HasValue)
				request.WithQueryParameter("PADL", m3PADL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PNOD))
				request.WithQueryParameter("PNOD", m3PNOD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPLE))
				request.WithQueryParameter("SPLE", m3SPLE.Trim());
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADCG))
				request.WithQueryParameter("ADCG", m3ADCG.Trim());

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
		/// Name AddText
		/// Description Add text for customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3PARM">Text (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddText(
			string m3CUNO, 
			string m3PARM, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			string m3TXVR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3PARM))
				throw new ArgumentNullException(nameof(m3PARM));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("PARM", m3PARM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());

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
		/// Name CheckPIN
		/// Description Check customer number and pin
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3PWMT">Password (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CheckPIN(
			string m3CUNO, 
			string m3PWMT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CheckPIN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3PWMT))
				throw new ArgumentNullException(nameof(m3PWMT));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("PWMT", m3PWMT.Trim());

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
		/// Name ChgAddress
		/// Description Modify customer address data
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="m3CUA1">Customer address 1 (Required)</param>
		/// <param name="m3CSCD">Country (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUA2">Customer address 2</param>
		/// <param name="m3CUA3">Customer address 3</param>
		/// <param name="m3CUA4">Customer address 4</param>
		/// <param name="m3PONO">postal code</param>
		/// <param name="m3ADVI">Via address</param>
		/// <param name="m3EALO">EAN location code</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3RONO">Run</param>
		/// <param name="m3DEPE">Departure</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Term of delivery</param>
		/// <param name="m3TEL2">Terms text</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile number</param>
		/// <param name="m3YREF">Your reference</param>
		/// <param name="m3LSID">User</param>
		/// <param name="m3LSAD">Address</param>
		/// <param name="m3MEAL">Valid media</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3EDES">Place-replaced by EDE2</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3ULZO">Unloading zone</param>
		/// <param name="m3CESA">Marketing ID in Movex SMS</param>
		/// <param name="m3GEOC">Geographic code</param>
		/// <param name="m3TAXC">Tax code</param>
		/// <param name="m3HAFE">Harbour or airport</param>
		/// <param name="m3EDE2">Place</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3GEOX">Geographic cod X</param>
		/// <param name="m3GEOY">Geographic code Y</param>
		/// <param name="m3GEOZ">Geographic cod  Z</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3SPLE">Standard point location code</param>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="m3ADCG">Address category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAddress(
			string m3CUNO, 
			int m3ADRT, 
			string m3ADID, 
			string m3CUA1, 
			string m3CSCD, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3CUNM = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3PONO = null, 
			string m3ADVI = null, 
			decimal? m3EALO = null, 
			string m3ECAR = null, 
			string m3RONO = null, 
			string m3DEPE = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEL2 = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3LSID = null, 
			string m3LSAD = null, 
			string m3MEAL = null, 
			string m3VRNO = null, 
			string m3EDES = null, 
			string m3ROUT = null, 
			int? m3RODN = null, 
			string m3ULZO = null, 
			string m3CESA = null, 
			int? m3GEOC = null, 
			string m3TAXC = null, 
			string m3HAFE = null, 
			string m3EDE2 = null, 
			string m3TOWN = null, 
			decimal? m3GEOX = null, 
			decimal? m3GEOY = null, 
			decimal? m3GEOZ = null, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			string m3FRCO = null, 
			string m3RASN = null, 
			string m3SPLE = null, 
			int? m3PRIO = null, 
			string m3ADCG = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));
			if (string.IsNullOrWhiteSpace(m3CUA1))
				throw new ArgumentNullException(nameof(m3CUA1));
			if (string.IsNullOrWhiteSpace(m3CSCD))
				throw new ArgumentNullException(nameof(m3CSCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADID", m3ADID.Trim())
				.WithQueryParameter("CUA1", m3CUA1.Trim())
				.WithQueryParameter("CSCD", m3CSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADVI))
				request.WithQueryParameter("ADVI", m3ADVI.Trim());
			if (m3EALO.HasValue)
				request.WithQueryParameter("EALO", m3EALO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RONO))
				request.WithQueryParameter("RONO", m3RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPE))
				request.WithQueryParameter("DEPE", m3DEPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEL2))
				request.WithQueryParameter("TEL2", m3TEL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3LSID))
				request.WithQueryParameter("LSID", m3LSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3LSAD))
				request.WithQueryParameter("LSAD", m3LSAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEAL))
				request.WithQueryParameter("MEAL", m3MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROUT))
				request.WithQueryParameter("ROUT", m3ROUT.Trim());
			if (m3RODN.HasValue)
				request.WithQueryParameter("RODN", m3RODN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ULZO))
				request.WithQueryParameter("ULZO", m3ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDE2))
				request.WithQueryParameter("EDE2", m3EDE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (m3GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3GEOX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3GEOY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3GEOZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPLE))
				request.WithQueryParameter("SPLE", m3SPLE.Trim());
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADCG))
				request.WithQueryParameter("ADCG", m3ADCG.Trim());

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
		/// Name ChgBasicData
		/// Description Modify customer basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUA1">Customer address 1</param>
		/// <param name="m3CUA2">Customer address 2</param>
		/// <param name="m3CUA3">Customer address 3</param>
		/// <param name="m3CUA4">Customer address 4</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3TFNO">Facsimile number</param>
		/// <param name="m3CUTP">Customer type</param>
		/// <param name="m3ALCU">Search key</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3YRE2">Your reference 2</param>
		/// <param name="m3MAIL">E-mail address</param>
		/// <param name="m3CSCD">Country code</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3CFC1">free field 1</param>
		/// <param name="m3CFC2">Free field 2</param>
		/// <param name="m3CFC3">Free field 3</param>
		/// <param name="m3CFC4">Free field 4</param>
		/// <param name="m3CFC5">Free field 5</param>
		/// <param name="m3CFC6">Free field 6</param>
		/// <param name="m3CFC7">Free field 7</param>
		/// <param name="m3CFC8">Free field 8</param>
		/// <param name="m3CFC9">Free field 9</param>
		/// <param name="m3CFC0">Free field 10</param>
		/// <param name="m3CESA">SMS id</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3PWM1">Old password</param>
		/// <param name="m3PWM2">New password</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3CUSU">Our supplier number at customer</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3EALO">EAN location code</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3SPLE">Standard point location code</param>
		/// <param name="m3LSID">User</param>
		/// <param name="m3LSAD">Address</param>
		/// <param name="m3MEAL">Valid media</param>
		/// <param name="m3HAFE">Harbor or airport</param>
		/// <param name="m3GEOC">Geographic code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgBasicDataResponse></returns>
		/// <exception cref="M3Exception<ChgBasicDataResponse>"></exception>
		public async Task<M3Response<ChgBasicDataResponse>> ChgBasicData(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3LNCD = null, 
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3PONO = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3TFNO = null, 
			int? m3CUTP = null, 
			string m3ALCU = null, 
			string m3YREF = null, 
			string m3YRE2 = null, 
			string m3MAIL = null, 
			string m3CSCD = null, 
			string m3ECAR = null, 
			string m3CFC1 = null, 
			decimal? m3CFC2 = null, 
			string m3CFC3 = null, 
			string m3CFC4 = null, 
			string m3CFC5 = null, 
			string m3CFC6 = null, 
			decimal? m3CFC7 = null, 
			string m3CFC8 = null, 
			string m3CFC9 = null, 
			string m3CFC0 = null, 
			string m3CESA = null, 
			string m3STAT = null, 
			string m3PWM1 = null, 
			string m3PWM2 = null, 
			string m3EDES = null, 
			string m3TOWN = null, 
			string m3CUSU = null, 
			string m3FRCO = null, 
			decimal? m3EALO = null, 
			string m3RASN = null, 
			string m3SPLE = null, 
			string m3LSID = null, 
			string m3LSAD = null, 
			string m3MEAL = null, 
			string m3HAFE = null, 
			int? m3GEOC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (m3CUTP.HasValue)
				request.WithQueryParameter("CUTP", m3CUTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALCU))
				request.WithQueryParameter("ALCU", m3ALCU.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE2))
				request.WithQueryParameter("YRE2", m3YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAIL))
				request.WithQueryParameter("MAIL", m3MAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC1))
				request.WithQueryParameter("CFC1", m3CFC1.Trim());
			if (m3CFC2.HasValue)
				request.WithQueryParameter("CFC2", m3CFC2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFC3))
				request.WithQueryParameter("CFC3", m3CFC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC4))
				request.WithQueryParameter("CFC4", m3CFC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC5))
				request.WithQueryParameter("CFC5", m3CFC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC6))
				request.WithQueryParameter("CFC6", m3CFC6.Trim());
			if (m3CFC7.HasValue)
				request.WithQueryParameter("CFC7", m3CFC7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFC8))
				request.WithQueryParameter("CFC8", m3CFC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC9))
				request.WithQueryParameter("CFC9", m3CFC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC0))
				request.WithQueryParameter("CFC0", m3CFC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PWM1))
				request.WithQueryParameter("PWM1", m3PWM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PWM2))
				request.WithQueryParameter("PWM2", m3PWM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUSU))
				request.WithQueryParameter("CUSU", m3CUSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (m3EALO.HasValue)
				request.WithQueryParameter("EALO", m3EALO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPLE))
				request.WithQueryParameter("SPLE", m3SPLE.Trim());
			if (!string.IsNullOrWhiteSpace(m3LSID))
				request.WithQueryParameter("LSID", m3LSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3LSAD))
				request.WithQueryParameter("LSAD", m3LSAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEAL))
				request.WithQueryParameter("MEAL", m3MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ChgBasicDataResponse>(
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
		/// Name ChgFinancial
		/// Description Modify customer financial data
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CORG">Organization number 1</param>
		/// <param name="m3COR2">Organization number 2</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3CRLM">Credit limit 1 - max overdue invoices</param>
		/// <param name="m3CRL2">Credit limit 2 - max out.invoices</param>
		/// <param name="m3CRL3">Credit limit 3 - max out.invoices + ord.</param>
		/// <param name="m3ODUD">Credit limit 4 - max days on invoices</param>
		/// <param name="m3TDIN">Overdue invoice amount</param>
		/// <param name="m3INCO">Insurance company</param>
		/// <param name="m3INSN">Insurance number</param>
		/// <param name="m3INLI">Insurance limit</param>
		/// <param name="m3AGPY">Payer - post giro</param>
		/// <param name="m3AGCP">Clearing number -  post giro</param>
		/// <param name="m3AGAC">Account number - post giro</param>
		/// <param name="m3AGBP">Payer - bank giro</param>
		/// <param name="m3AGLB">Clearing number - bank giro</param>
		/// <param name="m3AACB">Account number - bank giro</param>
		/// <param name="m3AGBG">Bank giro number</param>
		/// <param name="m3AGPG">Post giro number</param>
		/// <param name="m3CRTP">Exchange rate type</param>
		/// <param name="m3TXAP">Tax applicable</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3TECN">Tax exemption contract number</param>
		/// <param name="m3TEEC">Tax exemption expiry date</param>
		/// <param name="m3TAXC">Tax code</param>
		/// <param name="m3CDRC">Credit department reference</param>
		/// <param name="m3PYCD">Payment method AR</param>
		/// <param name="m3TECD">Cash discount term</param>
		/// <param name="m3BLCD">Customer stop</param>
		/// <param name="m3CLCD">Collection</param>
		/// <param name="m3BLPR">Payment reminder code</param>
		/// <param name="m3RMCT">Payment reminder rule</param>
		/// <param name="m3BLAC">Advice code</param>
		/// <param name="m3ADCA">Advice rule</param>
		/// <param name="m3PYDI">Payment instruction</param>
		/// <param name="m3CCUS">Company group customer number</param>
		/// <param name="m3STMR">Statement rule</param>
		/// <param name="m3BLII">Interest invoicing</param>
		/// <param name="m3IICT">Interest rule</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgFinancial(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3LNCD = null, 
			string m3CUNM = null, 
			string m3CORG = null, 
			string m3COR2 = null, 
			string m3CUCD = null, 
			int? m3VTCD = null, 
			string m3VRNO = null, 
			decimal? m3CRLM = null, 
			decimal? m3CRL2 = null, 
			decimal? m3CRL3 = null, 
			int? m3ODUD = null, 
			decimal? m3TDIN = null, 
			string m3INCO = null, 
			string m3INSN = null, 
			decimal? m3INLI = null, 
			string m3AGPY = null, 
			string m3AGCP = null, 
			string m3AGAC = null, 
			string m3AGBP = null, 
			string m3AGLB = null, 
			string m3AACB = null, 
			long? m3AGBG = null, 
			string m3AGPG = null, 
			int? m3CRTP = null, 
			int? m3TXAP = null, 
			int? m3GEOC = null, 
			string m3TECN = null, 
			DateTime? m3TEEC = null, 
			string m3TAXC = null, 
			string m3CDRC = null, 
			string m3PYCD = null, 
			string m3TECD = null, 
			int? m3BLCD = null, 
			int? m3CLCD = null, 
			int? m3BLPR = null, 
			string m3RMCT = null, 
			int? m3BLAC = null, 
			string m3ADCA = null, 
			string m3PYDI = null, 
			string m3CCUS = null, 
			string m3STMR = null, 
			int? m3BLII = null, 
			string m3IICT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgFinancial",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CORG))
				request.WithQueryParameter("CORG", m3CORG.Trim());
			if (!string.IsNullOrWhiteSpace(m3COR2))
				request.WithQueryParameter("COR2", m3COR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (m3CRLM.HasValue)
				request.WithQueryParameter("CRLM", m3CRLM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRL2.HasValue)
				request.WithQueryParameter("CRL2", m3CRL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRL3.HasValue)
				request.WithQueryParameter("CRL3", m3CRL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODUD.HasValue)
				request.WithQueryParameter("ODUD", m3ODUD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TDIN.HasValue)
				request.WithQueryParameter("TDIN", m3TDIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INCO))
				request.WithQueryParameter("INCO", m3INCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSN))
				request.WithQueryParameter("INSN", m3INSN.Trim());
			if (m3INLI.HasValue)
				request.WithQueryParameter("INLI", m3INLI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGPY))
				request.WithQueryParameter("AGPY", m3AGPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGCP))
				request.WithQueryParameter("AGCP", m3AGCP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGAC))
				request.WithQueryParameter("AGAC", m3AGAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGBP))
				request.WithQueryParameter("AGBP", m3AGBP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGLB))
				request.WithQueryParameter("AGLB", m3AGLB.Trim());
			if (!string.IsNullOrWhiteSpace(m3AACB))
				request.WithQueryParameter("AACB", m3AACB.Trim());
			if (m3AGBG.HasValue)
				request.WithQueryParameter("AGBG", m3AGBG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGPG))
				request.WithQueryParameter("AGPG", m3AGPG.Trim());
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3TXAP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECN))
				request.WithQueryParameter("TECN", m3TECN.Trim());
			if (m3TEEC.HasValue)
				request.WithQueryParameter("TEEC", m3TEEC.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CDRC))
				request.WithQueryParameter("CDRC", m3CDRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYCD))
				request.WithQueryParameter("PYCD", m3PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECD))
				request.WithQueryParameter("TECD", m3TECD.Trim());
			if (m3BLCD.HasValue)
				request.WithQueryParameter("BLCD", m3BLCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CLCD.HasValue)
				request.WithQueryParameter("CLCD", m3CLCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BLPR.HasValue)
				request.WithQueryParameter("BLPR", m3BLPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RMCT))
				request.WithQueryParameter("RMCT", m3RMCT.Trim());
			if (m3BLAC.HasValue)
				request.WithQueryParameter("BLAC", m3BLAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADCA))
				request.WithQueryParameter("ADCA", m3ADCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYDI))
				request.WithQueryParameter("PYDI", m3PYDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCUS))
				request.WithQueryParameter("CCUS", m3CCUS.Trim());
			if (!string.IsNullOrWhiteSpace(m3STMR))
				request.WithQueryParameter("STMR", m3STMR.Trim());
			if (m3BLII.HasValue)
				request.WithQueryParameter("BLII", m3BLII.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IICT))
				request.WithQueryParameter("IICT", m3IICT.Trim());

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
		/// Name ChgOrderInfo
		/// Description Modify customer financial data
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUCL">Customer group</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3SDST">District</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3EXCD">Service model</param>
		/// <param name="m3CHSY">Charge model</param>
		/// <param name="m3TEDL">Term of delivery</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DISY">Discount model</param>
		/// <param name="m3DIGC">Discount group - customer</param>
		/// <param name="m3DIPC">Discount - percentage</param>
		/// <param name="m3EDES">Place-replaced by EDE2</param>
		/// <param name="m3PRVG">Commission group</param>
		/// <param name="m3BGRP">Bonus group</param>
		/// <param name="m3TEPY">Term of payment</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3IVGP">Invoicing group</param>
		/// <param name="m3EDE2">Place</param>
		/// <param name="m3BUSE">Bonus/Commission Active</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ACHK">Assortment Check</param>
		/// <param name="m3ADVI">Ship-via</param>
		/// <param name="m3FRE1">Statistic identity 1 customer</param>
		/// <param name="m3FRE2">Statistic identity 2 customer</param>
		/// <param name="m3PLTB">Price list table</param>
		/// <param name="m3INRC">Invoice recipient</param>
		/// <param name="m3DOGR">Customer document group</param>
		/// <param name="m3ADBO">Separate invoices</param>
		/// <param name="m3AICD">Summary invoice</param>
		/// <param name="m3SPLM">Supply model</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3CUST">Statistics customer</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3PRIO">Priority</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3AGCH">Agreement check - order header</param>
		/// <param name="m3AGCT">Agreement check - order lines</param>
		/// <param name="m3ULZO">Unloading zone</param>
		/// <param name="m3ECLC">Labor code - trade statistics (TST)</param>
		/// <param name="m3GRPY">Group invoice</param>
		/// <param name="m3TINC">VAT included</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3PRDL">Print delivery information</param>
		/// <param name="m3MCOS">CO number mandatory</param>
		/// <param name="m3BCKO">Backorder</param>
		/// <param name="m3PADL">Partial delivery</param>
		/// <param name="m3SCED">Delivery regrouping</param>
		/// <param name="m3BOP1">Automatic closing</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOrderInfo(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3LNCD = null, 
			string m3CUNM = null, 
			string m3CUCL = null, 
			string m3OREF = null, 
			string m3SMCD = null, 
			string m3SDST = null, 
			string m3ORTP = null, 
			string m3EXCD = null, 
			string m3CHSY = null, 
			string m3TEDL = null, 
			string m3MODL = null, 
			string m3WHLO = null, 
			string m3DISY = null, 
			string m3DIGC = null, 
			int? m3DIPC = null, 
			string m3EDES = null, 
			string m3PRVG = null, 
			string m3BGRP = null, 
			string m3TEPY = null, 
			string m3PYNO = null, 
			string m3IVGP = null, 
			string m3EDE2 = null, 
			int? m3BUSE = null, 
			string m3FACI = null, 
			int? m3ACHK = null, 
			string m3ADVI = null, 
			string m3FRE1 = null, 
			string m3FRE2 = null, 
			string m3PLTB = null, 
			string m3INRC = null, 
			string m3DOGR = null, 
			int? m3ADBO = null, 
			int? m3AICD = null, 
			string m3SPLM = null, 
			string m3ADID = null, 
			string m3CUST = null, 
			string m3TEPA = null, 
			int? m3PRIO = null, 
			string m3ACRF = null, 
			int? m3AGCH = null, 
			int? m3AGCT = null, 
			string m3ULZO = null, 
			string m3ECLC = null, 
			int? m3GRPY = null, 
			int? m3TINC = null, 
			int? m3ALWT = null, 
			string m3POPN = null, 
			int? m3PRDL = null, 
			int? m3MCOS = null, 
			int? m3BCKO = null, 
			int? m3PADL = null, 
			int? m3SCED = null, 
			int? m3BOP1 = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgOrderInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCL))
				request.WithQueryParameter("CUCL", m3CUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDST))
				request.WithQueryParameter("SDST", m3SDST.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EXCD))
				request.WithQueryParameter("EXCD", m3EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHSY))
				request.WithQueryParameter("CHSY", m3CHSY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DISY))
				request.WithQueryParameter("DISY", m3DISY.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIGC))
				request.WithQueryParameter("DIGC", m3DIGC.Trim());
			if (m3DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3DIPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRVG))
				request.WithQueryParameter("PRVG", m3PRVG.Trim());
			if (!string.IsNullOrWhiteSpace(m3BGRP))
				request.WithQueryParameter("BGRP", m3BGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3IVGP))
				request.WithQueryParameter("IVGP", m3IVGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDE2))
				request.WithQueryParameter("EDE2", m3EDE2.Trim());
			if (m3BUSE.HasValue)
				request.WithQueryParameter("BUSE", m3BUSE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3ACHK.HasValue)
				request.WithQueryParameter("ACHK", m3ACHK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADVI))
				request.WithQueryParameter("ADVI", m3ADVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE1))
				request.WithQueryParameter("FRE1", m3FRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE2))
				request.WithQueryParameter("FRE2", m3FRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTB))
				request.WithQueryParameter("PLTB", m3PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3INRC))
				request.WithQueryParameter("INRC", m3INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOGR))
				request.WithQueryParameter("DOGR", m3DOGR.Trim());
			if (m3ADBO.HasValue)
				request.WithQueryParameter("ADBO", m3ADBO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AICD.HasValue)
				request.WithQueryParameter("AICD", m3AICD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPLM))
				request.WithQueryParameter("SPLM", m3SPLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUST))
				request.WithQueryParameter("CUST", m3CUST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (m3PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3PRIO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (m3AGCH.HasValue)
				request.WithQueryParameter("AGCH", m3AGCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGCT.HasValue)
				request.WithQueryParameter("AGCT", m3AGCT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ULZO))
				request.WithQueryParameter("ULZO", m3ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECLC))
				request.WithQueryParameter("ECLC", m3ECLC.Trim());
			if (m3GRPY.HasValue)
				request.WithQueryParameter("GRPY", m3GRPY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TINC.HasValue)
				request.WithQueryParameter("TINC", m3TINC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (m3PRDL.HasValue)
				request.WithQueryParameter("PRDL", m3PRDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MCOS.HasValue)
				request.WithQueryParameter("MCOS", m3MCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCKO.HasValue)
				request.WithQueryParameter("BCKO", m3BCKO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PADL.HasValue)
				request.WithQueryParameter("PADL", m3PADL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCED.HasValue)
				request.WithQueryParameter("SCED", m3SCED.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BOP1.HasValue)
				request.WithQueryParameter("BOP1", m3BOP1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

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
		/// Name ChgRentalData
		/// Description Modify customer rental data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RPLT">Rental price list table</param>
		/// <param name="m3RDIS">Rental discount model</param>
		/// <param name="m3RTEP">Rental payment terms</param>
		/// <param name="m3RSMC">Rental salesperson</param>
		/// <param name="m3AOTP">Agreement order type</param>
		/// <param name="m3ST75">Rental rate type</param>
		/// <param name="m3ST76">Number of shifts</param>
		/// <param name="m3ST77">Number of days per week</param>
		/// <param name="m3ST78">Minimum days/week to invoice a week</param>
		/// <param name="m3RAFA">Rate factor</param>
		/// <param name="m3MRTP">Minimum rental type</param>
		/// <param name="m3MINV">Min rental amount</param>
		/// <param name="m3MIHP">Min rental period</param>
		/// <param name="m3RTYR">Return year - open agreement</param>
		/// <param name="m3RTMO">Return month - open agreement</param>
		/// <param name="m3IIYR">Invoice interval - years</param>
		/// <param name="m3IIMO">Invoice interval - months</param>
		/// <param name="m3IIDA">Invoice intervall days</param>
		/// <param name="m3DPOT">Rental depot</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgRentalData(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3RPLT = null, 
			string m3RDIS = null, 
			string m3RTEP = null, 
			string m3RSMC = null, 
			string m3AOTP = null, 
			string m3ST75 = null, 
			int? m3ST76 = null, 
			int? m3ST77 = null, 
			int? m3ST78 = null, 
			int? m3RAFA = null, 
			int? m3MRTP = null, 
			decimal? m3MINV = null, 
			int? m3MIHP = null, 
			int? m3RTYR = null, 
			int? m3RTMO = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIDA = null, 
			string m3DPOT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgRentalData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPLT))
				request.WithQueryParameter("RPLT", m3RPLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RDIS))
				request.WithQueryParameter("RDIS", m3RDIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RTEP))
				request.WithQueryParameter("RTEP", m3RTEP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSMC))
				request.WithQueryParameter("RSMC", m3RSMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOTP))
				request.WithQueryParameter("AOTP", m3AOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ST75))
				request.WithQueryParameter("ST75", m3ST75.Trim());
			if (m3ST76.HasValue)
				request.WithQueryParameter("ST76", m3ST76.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ST77.HasValue)
				request.WithQueryParameter("ST77", m3ST77.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ST78.HasValue)
				request.WithQueryParameter("ST78", m3ST78.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RAFA.HasValue)
				request.WithQueryParameter("RAFA", m3RAFA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MRTP.HasValue)
				request.WithQueryParameter("MRTP", m3MRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MINV.HasValue)
				request.WithQueryParameter("MINV", m3MINV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIHP.HasValue)
				request.WithQueryParameter("MIHP", m3MIHP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTYR.HasValue)
				request.WithQueryParameter("RTYR", m3RTYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTMO.HasValue)
				request.WithQueryParameter("RTMO", m3RTMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3IIDA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DPOT))
				request.WithQueryParameter("DPOT", m3DPOT.Trim());

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
		/// Name ChgServOrdInfo
		/// Description Modify customer Service Order data
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3SOTP">Service order type</param>
		/// <param name="m3PRS1">Price list SO</param>
		/// <param name="m3PRS2">Price list 2 SO</param>
		/// <param name="m3PRS3">Price list 3 SO</param>
		/// <param name="m3PRS4">Price list 4 SO</param>
		/// <param name="m3PRS5">Price list 5 SO</param>
		/// <param name="m3DMSO">Discount model SO</param>
		/// <param name="m3MCON">Mandatory entry of customer's order no.</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgServOrdInfo(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3SRES = null, 
			string m3TECH = null, 
			string m3SOTP = null, 
			string m3PRS1 = null, 
			string m3PRS2 = null, 
			string m3PRS3 = null, 
			string m3PRS4 = null, 
			string m3PRS5 = null, 
			string m3DMSO = null, 
			int? m3MCON = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgServOrdInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3SOTP))
				request.WithQueryParameter("SOTP", m3SOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRS1))
				request.WithQueryParameter("PRS1", m3PRS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRS2))
				request.WithQueryParameter("PRS2", m3PRS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRS3))
				request.WithQueryParameter("PRS3", m3PRS3.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRS4))
				request.WithQueryParameter("PRS4", m3PRS4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRS5))
				request.WithQueryParameter("PRS5", m3PRS5.Trim());
			if (!string.IsNullOrWhiteSpace(m3DMSO))
				request.WithQueryParameter("DMSO", m3DMSO.Trim());
			if (m3MCON.HasValue)
				request.WithQueryParameter("MCON", m3MCON.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Copy
		/// Description Copy an existing customer record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUTM">Customer number - Existing (Required)</param>
		/// <param name="m3CUNM">Customer name (Required)</param>
		/// <param name="m3CUA1">Customer address 1 (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CUNO">Customer number - New</param>
		/// <param name="m3CUA2">Customer address 2</param>
		/// <param name="m3CUA3">Customer address 3</param>
		/// <param name="m3CUA4">Customer address 4</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3TFNO">Facsimile number</param>
		/// <param name="m3CUTP">Customer type</param>
		/// <param name="m3ALCU">Search key</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3YRE2">Your reference 2</param>
		/// <param name="m3MAIL">E-mail address</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3CSCD">Country code</param>
		/// <param name="m3CFC1">free field 1</param>
		/// <param name="m3CFC2">Free field 2</param>
		/// <param name="m3CFC4">Free field 4</param>
		/// <param name="m3CFC5">Free field 5</param>
		/// <param name="m3CFC3">Free field 3</param>
		/// <param name="m3CFC6">Free field 6</param>
		/// <param name="m3CFC7">Free field 7</param>
		/// <param name="m3CFC8">Free field 8</param>
		/// <param name="m3CFC0">Free field 10</param>
		/// <param name="m3CFC9">Free field 9</param>
		/// <param name="m3CESA">SMS id</param>
		/// <param name="m3STAT">Customer status</param>
		/// <param name="m3IVGP">Invoicing group</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3EALO">EAN location code</param>
		/// <param name="m3LSID">User</param>
		/// <param name="m3LSAD">Address</param>
		/// <param name="m3MEAL">Valid media</param>
		/// <param name="m3HAFE">Harbor or airport</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CopyResponse></returns>
		/// <exception cref="M3Exception<CopyResponse>"></exception>
		public async Task<M3Response<CopyResponse>> Copy(
			string m3CUTM, 
			string m3CUNM, 
			string m3CUA1, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3LNCD = null, 
			string m3CUNO = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3PONO = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3TFNO = null, 
			int? m3CUTP = null, 
			string m3ALCU = null, 
			string m3YREF = null, 
			string m3YRE2 = null, 
			string m3MAIL = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3CFC1 = null, 
			decimal? m3CFC2 = null, 
			string m3CFC4 = null, 
			string m3CFC5 = null, 
			string m3CFC3 = null, 
			string m3CFC6 = null, 
			decimal? m3CFC7 = null, 
			string m3CFC8 = null, 
			string m3CFC0 = null, 
			string m3CFC9 = null, 
			string m3CESA = null, 
			string m3STAT = null, 
			string m3IVGP = null, 
			string m3EDES = null, 
			string m3TOWN = null, 
			string m3FRCO = null, 
			decimal? m3EALO = null, 
			string m3LSID = null, 
			string m3LSAD = null, 
			string m3MEAL = null, 
			string m3HAFE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Copy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUTM))
				throw new ArgumentNullException(nameof(m3CUTM));
			if (string.IsNullOrWhiteSpace(m3CUNM))
				throw new ArgumentNullException(nameof(m3CUNM));
			if (string.IsNullOrWhiteSpace(m3CUA1))
				throw new ArgumentNullException(nameof(m3CUA1));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUTM", m3CUTM.Trim())
				.WithQueryParameter("CUNM", m3CUNM.Trim())
				.WithQueryParameter("CUA1", m3CUA1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (m3CUTP.HasValue)
				request.WithQueryParameter("CUTP", m3CUTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALCU))
				request.WithQueryParameter("ALCU", m3ALCU.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE2))
				request.WithQueryParameter("YRE2", m3YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAIL))
				request.WithQueryParameter("MAIL", m3MAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC1))
				request.WithQueryParameter("CFC1", m3CFC1.Trim());
			if (m3CFC2.HasValue)
				request.WithQueryParameter("CFC2", m3CFC2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFC4))
				request.WithQueryParameter("CFC4", m3CFC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC5))
				request.WithQueryParameter("CFC5", m3CFC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC3))
				request.WithQueryParameter("CFC3", m3CFC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC6))
				request.WithQueryParameter("CFC6", m3CFC6.Trim());
			if (m3CFC7.HasValue)
				request.WithQueryParameter("CFC7", m3CFC7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFC8))
				request.WithQueryParameter("CFC8", m3CFC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC0))
				request.WithQueryParameter("CFC0", m3CFC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFC9))
				request.WithQueryParameter("CFC9", m3CFC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IVGP))
				request.WithQueryParameter("IVGP", m3IVGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDES))
				request.WithQueryParameter("EDES", m3EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (m3EALO.HasValue)
				request.WithQueryParameter("EALO", m3EALO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LSID))
				request.WithQueryParameter("LSID", m3LSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3LSAD))
				request.WithQueryParameter("LSAD", m3LSAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEAL))
				request.WithQueryParameter("MEAL", m3MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());

			// Execute the request
			var result = await Execute<CopyResponse>(
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
		/// Name Delete
		/// Description Delete a customer record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3CUNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

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
		/// Name DeleteAddress
		/// Description Delete a customer address record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteAddress(
			string m3CUNO, 
			int m3ADRT, 
			string m3ADID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADID", m3ADID.Trim());

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
		/// Name EXPORTSMS
		/// Description Export to SMS (NO STANDARD TRANSACTION)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<EXPORTSMSResponse></returns>
		/// <exception cref="M3Exception<EXPORTSMSResponse>"></exception>
		public async Task<M3Response<EXPORTSMSResponse>> EXPORTSMS(
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/EXPORTSMS",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<EXPORTSMSResponse>(
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
		/// Name GetAddress
		/// Description Retrieve customer address data
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			string m3CUNO, 
			int m3ADRT, 
			string m3ADID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADID", m3ADID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAddressResponse>(
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
		/// Description Retrieve customer basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3CUNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetFinancial
		/// Description Retrieve customer financial data
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFinancialResponse></returns>
		/// <exception cref="M3Exception<GetFinancialResponse>"></exception>
		public async Task<M3Response<GetFinancialResponse>> GetFinancial(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetFinancial",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetFinancialResponse>(
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
		/// Name GetOrderInfo
		/// Description Retrieve customer financial data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderInfoResponse></returns>
		/// <exception cref="M3Exception<GetOrderInfoResponse>"></exception>
		public async Task<M3Response<GetOrderInfoResponse>> GetOrderInfo(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOrderInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetOrderInfoResponse>(
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
		/// Name GetRentalData
		/// Description Displaycustomer rental data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRentalDataResponse></returns>
		/// <exception cref="M3Exception<GetRentalDataResponse>"></exception>
		public async Task<M3Response<GetRentalDataResponse>> GetRentalData(
			string m3CUNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetRentalData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetRentalDataResponse>(
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
		/// Name GetServOrdInfo
		/// Description Retrieve customer Service Order data
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetServOrdInfoResponse></returns>
		/// <exception cref="M3Exception<GetServOrdInfoResponse>"></exception>
		public async Task<M3Response<GetServOrdInfoResponse>> GetServOrdInfo(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetServOrdInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetServOrdInfoResponse>(
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
		/// Name IMPORTSMS
		/// Description NOT A STANDARD TRANSACTION FOR COMMON USE
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3TPRE">Record type</param>
		/// <param name="m3OPT2">Option</param>
		/// <param name="m3CESA">Marketing ID - Movex SMS</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3CORG">Organization number 1</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3SMAD">Address</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3SMCI">City</param>
		/// <param name="m3SMCO">County</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3SDST">District</param>
		/// <param name="m3CUCL">Customer group</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3CRL3">Credit limit 3</param>
		/// <param name="m3RGDT">Entry date</param>
		/// <param name="m3LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> IMPORTSMS(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3TPRE = null, 
			string m3OPT2 = null, 
			string m3CESA = null, 
			string m3CUNO = null, 
			string m3CORG = null, 
			string m3CUNM = null, 
			string m3SMAD = null, 
			string m3PONO = null, 
			string m3SMCI = null, 
			string m3SMCO = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3SDST = null, 
			string m3CUCL = null, 
			string m3TEPY = null, 
			decimal? m3CRL3 = null, 
			DateTime? m3RGDT = null, 
			DateTime? m3LMDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/IMPORTSMS",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPRE))
				request.WithQueryParameter("TPRE", m3TPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPT2))
				request.WithQueryParameter("OPT2", m3OPT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CORG))
				request.WithQueryParameter("CORG", m3CORG.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMAD))
				request.WithQueryParameter("SMAD", m3SMAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCI))
				request.WithQueryParameter("SMCI", m3SMCI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCO))
				request.WithQueryParameter("SMCO", m3SMCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDST))
				request.WithQueryParameter("SDST", m3SDST.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCL))
				request.WithQueryParameter("CUCL", m3CUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (m3CRL3.HasValue)
				request.WithQueryParameter("CRL3", m3CRL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3RGDT.Value.ToM3String());
			if (m3LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3LMDT.Value.ToM3String());

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
		/// Name LstAddresses
		/// Description List customer address related information
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAddressesResponse></returns>
		/// <exception cref="M3Exception<LstAddressesResponse>"></exception>
		public async Task<M3Response<LstAddressesResponse>> LstAddresses(
			string m3CUNO, 
			int? m3CONO = null, 
			decimal? m3LMTS = null, 
			int? m3ADRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAddresses",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAddressesResponse>(
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
		/// Name LstByGroup
		/// Description List customer in order group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUCL">Customer group (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByGroupResponse></returns>
		/// <exception cref="M3Exception<LstByGroupResponse>"></exception>
		public async Task<M3Response<LstByGroupResponse>> LstByGroup(
			string m3CUCL, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUCL))
				throw new ArgumentNullException(nameof(m3CUCL));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCL", m3CUCL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByGroupResponse>(
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
		/// Name LstByInvoiceRec
		/// Description List customers having a specific invoice recipient
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3INRC">Invoice recipient (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByInvoiceRecResponse></returns>
		/// <exception cref="M3Exception<LstByInvoiceRecResponse>"></exception>
		public async Task<M3Response<LstByInvoiceRecResponse>> LstByInvoiceRec(
			string m3INRC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByInvoiceRec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3INRC))
				throw new ArgumentNullException(nameof(m3INRC));

			// Set mandatory parameters
			request
				.WithQueryParameter("INRC", m3INRC.Trim());

			// Execute the request
			var result = await Execute<LstByInvoiceRecResponse>(
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
		/// Name LstByMarketDim
		/// Description List customer in market dimension order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRCO">From Customer number</param>
		/// <param name="m3TOCO">To Customer number</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByMarketDimResponse></returns>
		/// <exception cref="M3Exception<LstByMarketDimResponse>"></exception>
		public async Task<M3Response<LstByMarketDimResponse>> LstByMarketDim(
			int? m3CONO = null, 
			string m3FRCO = null, 
			string m3TOCO = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByMarketDim",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOCO))
				request.WithQueryParameter("TOCO", m3TOCO.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByMarketDimResponse>(
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
		/// Name LstByName
		/// Description List customer data in customer name order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByNameResponse></returns>
		/// <exception cref="M3Exception<LstByNameResponse>"></exception>
		public async Task<M3Response<LstByNameResponse>> LstByName(
			int? m3CONO = null, 
			string m3CUNM = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByName",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByNameResponse>(
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
		/// Name LstByNumber
		/// Description List customer data in customer number order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByNumberResponse></returns>
		/// <exception cref="M3Exception<LstByNumberResponse>"></exception>
		public async Task<M3Response<LstByNumberResponse>> LstByNumber(
			int? m3CONO = null, 
			string m3CUNO = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByNumber",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByNumberResponse>(
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
		/// Name LstBySearchKey
		/// Description List customer data by search key
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ALCU">Search key</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBySearchKeyResponse></returns>
		/// <exception cref="M3Exception<LstBySearchKeyResponse>"></exception>
		public async Task<M3Response<LstBySearchKeyResponse>> LstBySearchKey(
			int? m3CONO = null, 
			string m3ALCU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBySearchKey",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALCU))
				request.WithQueryParameter("ALCU", m3ALCU.Trim());

			// Execute the request
			var result = await Execute<LstBySearchKeyResponse>(
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
		/// Name LstCustCharges
		/// Description List Customer Charges
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3CRID">Charge</param>
		/// <param name="m3CRTY">Internal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustChargesResponse></returns>
		/// <exception cref="M3Exception<LstCustChargesResponse>"></exception>
		public async Task<M3Response<LstCustChargesResponse>> LstCustCharges(
			int? m3CONO = null, 
			string m3CUNO = null, 
			string m3CRID = null, 
			int? m3CRTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCustCharges",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CRID))
				request.WithQueryParameter("CRID", m3CRID.Trim());
			if (m3CRTY.HasValue)
				request.WithQueryParameter("CRTY", m3CRTY.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstCustChargesResponse>(
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
		/// Name LstTemplates
		/// Description List customer templates
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTemplatesResponse></returns>
		/// <exception cref="M3Exception<LstTemplatesResponse>"></exception>
		public async Task<M3Response<LstTemplatesResponse>> LstTemplates(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTemplates",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstTemplatesResponse>(
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
		/// Name LstUsrDefField1
		/// Description User defiened field 1
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FCF1">From User def field 1</param>
		/// <param name="m3TCF1">To User def field 1</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUsrDefField1Response></returns>
		/// <exception cref="M3Exception<LstUsrDefField1Response>"></exception>
		public async Task<M3Response<LstUsrDefField1Response>> LstUsrDefField1(
			int? m3CONO = null, 
			string m3FCF1 = null, 
			long? m3TCF1 = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstUsrDefField1",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCF1))
				request.WithQueryParameter("FCF1", m3FCF1.Trim());
			if (m3TCF1.HasValue)
				request.WithQueryParameter("TCF1", m3TCF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstUsrDefField1Response>(
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
		/// Name LstUsrDefField3
		/// Description User defiened field 3
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FCF3">From User def field 3</param>
		/// <param name="m3TCF3">To User def field 3</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUsrDefField3Response></returns>
		/// <exception cref="M3Exception<LstUsrDefField3Response>"></exception>
		public async Task<M3Response<LstUsrDefField3Response>> LstUsrDefField3(
			int? m3CONO = null, 
			string m3FCF3 = null, 
			string m3TCF3 = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstUsrDefField3",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCF3))
				request.WithQueryParameter("FCF3", m3FCF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCF3))
				request.WithQueryParameter("TCF3", m3TCF3.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstUsrDefField3Response>(
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
		/// Name LstUsrDefField4
		/// Description User defiened field 4
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FCF4">From User def field 4</param>
		/// <param name="m3TCF4">To User def field 4</param>
		/// <param name="m3LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUsrDefField4Response></returns>
		/// <exception cref="M3Exception<LstUsrDefField4Response>"></exception>
		public async Task<M3Response<LstUsrDefField4Response>> LstUsrDefField4(
			int? m3CONO = null, 
			string m3FCF4 = null, 
			string m3TCF4 = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstUsrDefField4",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCF4))
				request.WithQueryParameter("FCF4", m3FCF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCF4))
				request.WithQueryParameter("TCF4", m3TCF4.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstUsrDefField4Response>(
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
		/// Name SearchCustCred
		/// Description SearchCustCred
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchCustCredResponse></returns>
		/// <exception cref="M3Exception<SearchCustCredResponse>"></exception>
		public async Task<M3Response<SearchCustCredResponse>> SearchCustCred(
			string m3SQRY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchCustCred",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchCustCredResponse>(
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
		/// Name SearchCustomer
		/// Description Search for a customer via LES
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchCustomerResponse></returns>
		/// <exception cref="M3Exception<SearchCustomerResponse>"></exception>
		public async Task<M3Response<SearchCustomerResponse>> SearchCustomer(
			string m3SQRY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchCustomer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchCustomerResponse>(
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
