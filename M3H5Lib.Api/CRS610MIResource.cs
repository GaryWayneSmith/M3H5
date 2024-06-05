/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Create a new customer record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUTM">Customer template (Required)</param>
		/// <param name="m3_CUNM">Customer name (Required)</param>
		/// <param name="m3_CUA1">Customer address 1 (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_CUA2">Customer address 2</param>
		/// <param name="m3_CUA3">Customer address 3</param>
		/// <param name="m3_CUA4">Customer address 4</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_TFNO">Facsimile number</param>
		/// <param name="m3_CUTP">Customer type</param>
		/// <param name="m3_ALCU">Search key</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_YRE2">Your reference 2</param>
		/// <param name="m3_MAIL">E-mail address</param>
		/// <param name="m3_CSCD">Country code</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_CFC1">free field 1</param>
		/// <param name="m3_CFC2">Free field 2</param>
		/// <param name="m3_CFC3">Free field 3</param>
		/// <param name="m3_CFC4">Free field 4</param>
		/// <param name="m3_CFC5">Free field 5</param>
		/// <param name="m3_CFC6">Free field 6</param>
		/// <param name="m3_CFC7">Free field 7</param>
		/// <param name="m3_CFC8">Free field 8</param>
		/// <param name="m3_CFC9">Free field 9</param>
		/// <param name="m3_CFC0">Free field 10</param>
		/// <param name="m3_CESA">SMS id</param>
		/// <param name="m3_STAT">Customer status</param>
		/// <param name="m3_PWMT">Password</param>
		/// <param name="m3_IVGP">Invoice group</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_CUSU">Our supplier number at customer</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_EALO">EAN location code</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_SPLE">Standard point location code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3_CUTM, 
			string m3_CUNM, 
			string m3_CUA1, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_LNCD = null, 
			string m3_CUNO = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_PONO = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_TFNO = null, 
			int? m3_CUTP = null, 
			string m3_ALCU = null, 
			string m3_YREF = null, 
			string m3_YRE2 = null, 
			string m3_MAIL = null, 
			string m3_CSCD = null, 
			string m3_ECAR = null, 
			string m3_CFC1 = null, 
			decimal? m3_CFC2 = null, 
			string m3_CFC3 = null, 
			string m3_CFC4 = null, 
			string m3_CFC5 = null, 
			string m3_CFC6 = null, 
			decimal? m3_CFC7 = null, 
			string m3_CFC8 = null, 
			string m3_CFC9 = null, 
			string m3_CFC0 = null, 
			string m3_CESA = null, 
			string m3_STAT = null, 
			string m3_PWMT = null, 
			string m3_IVGP = null, 
			string m3_TOWN = null, 
			string m3_CUSU = null, 
			string m3_FRCO = null, 
			string m3_EDES = null, 
			decimal? m3_EALO = null, 
			string m3_RASN = null, 
			string m3_SPLE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUTM))
				throw new ArgumentNullException("m3_CUTM");
			if (string.IsNullOrWhiteSpace(m3_CUNM))
				throw new ArgumentNullException("m3_CUNM");
			if (string.IsNullOrWhiteSpace(m3_CUA1))
				throw new ArgumentNullException("m3_CUA1");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUTM", m3_CUTM.Trim())
				.WithQueryParameter("CUNM", m3_CUNM.Trim())
				.WithQueryParameter("CUA1", m3_CUA1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (m3_CUTP.HasValue)
				request.WithQueryParameter("CUTP", m3_CUTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALCU))
				request.WithQueryParameter("ALCU", m3_ALCU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE2))
				request.WithQueryParameter("YRE2", m3_YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAIL))
				request.WithQueryParameter("MAIL", m3_MAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC1))
				request.WithQueryParameter("CFC1", m3_CFC1.Trim());
			if (m3_CFC2.HasValue)
				request.WithQueryParameter("CFC2", m3_CFC2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFC3))
				request.WithQueryParameter("CFC3", m3_CFC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC4))
				request.WithQueryParameter("CFC4", m3_CFC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC5))
				request.WithQueryParameter("CFC5", m3_CFC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC6))
				request.WithQueryParameter("CFC6", m3_CFC6.Trim());
			if (m3_CFC7.HasValue)
				request.WithQueryParameter("CFC7", m3_CFC7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFC8))
				request.WithQueryParameter("CFC8", m3_CFC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC9))
				request.WithQueryParameter("CFC9", m3_CFC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC0))
				request.WithQueryParameter("CFC0", m3_CFC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PWMT))
				request.WithQueryParameter("PWMT", m3_PWMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IVGP))
				request.WithQueryParameter("IVGP", m3_IVGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUSU))
				request.WithQueryParameter("CUSU", m3_CUSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (m3_EALO.HasValue)
				request.WithQueryParameter("EALO", m3_EALO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPLE))
				request.WithQueryParameter("SPLE", m3_SPLE.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name AddAddress
		/// Description Create a new customer address
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="m3_CUA1">Customer address 1 (Required)</param>
		/// <param name="m3_PONO">postal code (Required)</param>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_TOWN">City (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUA2">Customer address 2</param>
		/// <param name="m3_CUA3">Customer address 3</param>
		/// <param name="m3_CUA4">Customer address 4</param>
		/// <param name="m3_ADVI">Via address</param>
		/// <param name="m3_EALO">EAN location code</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_RONO">Run</param>
		/// <param name="m3_DEPE">Departure</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Term of delivery</param>
		/// <param name="m3_TEL2">Terms text</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile number</param>
		/// <param name="m3_YREF">Your reference</param>
		/// <param name="m3_LSID">User</param>
		/// <param name="m3_LSAD">Address</param>
		/// <param name="m3_MEAL">Valid media</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_EDES">Place-replaced by EDE2</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_ULZO">Unloading zone</param>
		/// <param name="m3_CESA">Marketing ID in Movex SMS</param>
		/// <param name="m3_GEOC">Geographic code</param>
		/// <param name="m3_TAXC">Tax code</param>
		/// <param name="m3_HAFE">Harbour or airport</param>
		/// <param name="m3_EDE2">Place</param>
		/// <param name="m3_GEOX">Geographic cod X</param>
		/// <param name="m3_GEOY">Geographic code Y</param>
		/// <param name="m3_GEOZ">Geographic cod  Z</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_SPLE">Standard point location code</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_ADCG">Address category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddAddressResponse></returns>
		/// <exception cref="M3Exception<AddAddressResponse>"></exception>
		public async Task<M3Response<AddAddressResponse>> AddAddress(
			string m3_CUNO, 
			int m3_ADRT, 
			string m3_ADID, 
			string m3_CUA1, 
			string m3_PONO, 
			string m3_CSCD, 
			string m3_TOWN, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_CUNM = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_ADVI = null, 
			decimal? m3_EALO = null, 
			string m3_ECAR = null, 
			string m3_RONO = null, 
			string m3_DEPE = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEL2 = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_LSID = null, 
			string m3_LSAD = null, 
			string m3_MEAL = null, 
			string m3_VRNO = null, 
			string m3_EDES = null, 
			string m3_ROUT = null, 
			int? m3_RODN = null, 
			string m3_ULZO = null, 
			string m3_CESA = null, 
			int? m3_GEOC = null, 
			string m3_TAXC = null, 
			string m3_HAFE = null, 
			string m3_EDE2 = null, 
			decimal? m3_GEOX = null, 
			decimal? m3_GEOY = null, 
			decimal? m3_GEOZ = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			string m3_FRCO = null, 
			string m3_RASN = null, 
			string m3_SPLE = null, 
			int? m3_PRIO = null, 
			string m3_ADCG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");
			if (string.IsNullOrWhiteSpace(m3_CUA1))
				throw new ArgumentNullException("m3_CUA1");
			if (string.IsNullOrWhiteSpace(m3_PONO))
				throw new ArgumentNullException("m3_PONO");
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");
			if (string.IsNullOrWhiteSpace(m3_TOWN))
				throw new ArgumentNullException("m3_TOWN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ADRT", m3_ADRT.ToString())
				.WithQueryParameter("ADID", m3_ADID.Trim())
				.WithQueryParameter("CUA1", m3_CUA1.Trim())
				.WithQueryParameter("PONO", m3_PONO.Trim())
				.WithQueryParameter("CSCD", m3_CSCD.Trim())
				.WithQueryParameter("TOWN", m3_TOWN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADVI))
				request.WithQueryParameter("ADVI", m3_ADVI.Trim());
			if (m3_EALO.HasValue)
				request.WithQueryParameter("EALO", m3_EALO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RONO))
				request.WithQueryParameter("RONO", m3_RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPE))
				request.WithQueryParameter("DEPE", m3_DEPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL2))
				request.WithQueryParameter("TEL2", m3_TEL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LSID))
				request.WithQueryParameter("LSID", m3_LSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LSAD))
				request.WithQueryParameter("LSAD", m3_LSAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEAL))
				request.WithQueryParameter("MEAL", m3_MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (m3_RODN.HasValue)
				request.WithQueryParameter("RODN", m3_RODN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ULZO))
				request.WithQueryParameter("ULZO", m3_ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDE2))
				request.WithQueryParameter("EDE2", m3_EDE2.Trim());
			if (m3_GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3_GEOX.Value.ToString());
			if (m3_GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3_GEOY.Value.ToString());
			if (m3_GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3_GEOZ.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPLE))
				request.WithQueryParameter("SPLE", m3_SPLE.Trim());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADCG))
				request.WithQueryParameter("ADCG", m3_ADCG.Trim());

			// Execute the request
			var result = await Execute<AddAddressResponse>(
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
		/// Name AddCheckAddress
		/// Description Create and validate a new customer address
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="m3_CUA1">Customer address 1 (Required)</param>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUA2">Customer address 2</param>
		/// <param name="m3_CUA3">Customer address 3</param>
		/// <param name="m3_CUA4">Customer address 4</param>
		/// <param name="m3_PONO">postal code</param>
		/// <param name="m3_ADVI">Via address</param>
		/// <param name="m3_EALO">EAN location code</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_RONO">Run</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Term of delivery</param>
		/// <param name="m3_TEL2">Terms text</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile number</param>
		/// <param name="m3_YREF">Your reference</param>
		/// <param name="m3_LSID">User</param>
		/// <param name="m3_LSAD">Address</param>
		/// <param name="m3_MEAL">Valid media</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_ULZO">Unloading zone</param>
		/// <param name="m3_CESA">Marketing ID in Movex SMS</param>
		/// <param name="m3_GEOC">Geographic code</param>
		/// <param name="m3_TAXC">Tax code</param>
		/// <param name="m3_HAFE">Harbour or airport</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_CALV">Calendar version</param>
		/// <param name="m3_DLPA">Delivery pattern</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_SPLM">Supply model</param>
		/// <param name="m3_BCKO">Backorder</param>
		/// <param name="m3_PADL">Partial delivery</param>
		/// <param name="m3_PNOD">Planning node</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_SPLE">Standard point location code</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_ADCG">Address category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCheckAddress(
			string m3_CUNO, 
			int m3_ADRT, 
			string m3_ADID, 
			string m3_CUA1, 
			string m3_CSCD, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_CUNM = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_PONO = null, 
			string m3_ADVI = null, 
			decimal? m3_EALO = null, 
			string m3_ECAR = null, 
			string m3_RONO = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEL2 = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_LSID = null, 
			string m3_LSAD = null, 
			string m3_MEAL = null, 
			string m3_VRNO = null, 
			string m3_EDES = null, 
			string m3_ULZO = null, 
			string m3_CESA = null, 
			int? m3_GEOC = null, 
			string m3_TAXC = null, 
			string m3_HAFE = null, 
			string m3_TOWN = null, 
			string m3_CALV = null, 
			string m3_DLPA = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			string m3_SPLM = null, 
			int? m3_BCKO = null, 
			int? m3_PADL = null, 
			string m3_PNOD = null, 
			string m3_FRCO = null, 
			string m3_RASN = null, 
			string m3_SPLE = null, 
			int? m3_PRIO = null, 
			string m3_ADCG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCheckAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");
			if (string.IsNullOrWhiteSpace(m3_CUA1))
				throw new ArgumentNullException("m3_CUA1");
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ADRT", m3_ADRT.ToString())
				.WithQueryParameter("ADID", m3_ADID.Trim())
				.WithQueryParameter("CUA1", m3_CUA1.Trim())
				.WithQueryParameter("CSCD", m3_CSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADVI))
				request.WithQueryParameter("ADVI", m3_ADVI.Trim());
			if (m3_EALO.HasValue)
				request.WithQueryParameter("EALO", m3_EALO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RONO))
				request.WithQueryParameter("RONO", m3_RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL2))
				request.WithQueryParameter("TEL2", m3_TEL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LSID))
				request.WithQueryParameter("LSID", m3_LSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LSAD))
				request.WithQueryParameter("LSAD", m3_LSAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEAL))
				request.WithQueryParameter("MEAL", m3_MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ULZO))
				request.WithQueryParameter("ULZO", m3_ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CALV))
				request.WithQueryParameter("CALV", m3_CALV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DLPA))
				request.WithQueryParameter("DLPA", m3_DLPA.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SPLM))
				request.WithQueryParameter("SPLM", m3_SPLM.Trim());
			if (m3_BCKO.HasValue)
				request.WithQueryParameter("BCKO", m3_BCKO.Value.ToString());
			if (m3_PADL.HasValue)
				request.WithQueryParameter("PADL", m3_PADL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PNOD))
				request.WithQueryParameter("PNOD", m3_PNOD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPLE))
				request.WithQueryParameter("SPLE", m3_SPLE.Trim());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADCG))
				request.WithQueryParameter("ADCG", m3_ADCG.Trim());

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
		/// Name AddText
		/// Description Add text for customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_PARM">Text (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddText(
			string m3_CUNO, 
			string m3_PARM, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			string m3_TXVR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_PARM))
				throw new ArgumentNullException("m3_PARM");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("PARM", m3_PARM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());

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
		/// Name CheckPIN
		/// Description Check customer number and pin
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_PWMT">Password (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CheckPIN(
			string m3_CUNO, 
			string m3_PWMT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CheckPIN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_PWMT))
				throw new ArgumentNullException("m3_PWMT");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("PWMT", m3_PWMT.Trim());

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
		/// Name ChgAddress
		/// Description Modify customer address data
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="m3_CUA1">Customer address 1 (Required)</param>
		/// <param name="m3_CSCD">Country (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUA2">Customer address 2</param>
		/// <param name="m3_CUA3">Customer address 3</param>
		/// <param name="m3_CUA4">Customer address 4</param>
		/// <param name="m3_PONO">postal code</param>
		/// <param name="m3_ADVI">Via address</param>
		/// <param name="m3_EALO">EAN location code</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_RONO">Run</param>
		/// <param name="m3_DEPE">Departure</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Term of delivery</param>
		/// <param name="m3_TEL2">Terms text</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile number</param>
		/// <param name="m3_YREF">Your reference</param>
		/// <param name="m3_LSID">User</param>
		/// <param name="m3_LSAD">Address</param>
		/// <param name="m3_MEAL">Valid media</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_EDES">Place-replaced by EDE2</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_ULZO">Unloading zone</param>
		/// <param name="m3_CESA">Marketing ID in Movex SMS</param>
		/// <param name="m3_GEOC">Geographic code</param>
		/// <param name="m3_TAXC">Tax code</param>
		/// <param name="m3_HAFE">Harbour or airport</param>
		/// <param name="m3_EDE2">Place</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_GEOX">Geographic cod X</param>
		/// <param name="m3_GEOY">Geographic code Y</param>
		/// <param name="m3_GEOZ">Geographic cod  Z</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_SPLE">Standard point location code</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_ADCG">Address category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAddress(
			string m3_CUNO, 
			int m3_ADRT, 
			string m3_ADID, 
			string m3_CUA1, 
			string m3_CSCD, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_CUNM = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_PONO = null, 
			string m3_ADVI = null, 
			decimal? m3_EALO = null, 
			string m3_ECAR = null, 
			string m3_RONO = null, 
			string m3_DEPE = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEL2 = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_LSID = null, 
			string m3_LSAD = null, 
			string m3_MEAL = null, 
			string m3_VRNO = null, 
			string m3_EDES = null, 
			string m3_ROUT = null, 
			int? m3_RODN = null, 
			string m3_ULZO = null, 
			string m3_CESA = null, 
			int? m3_GEOC = null, 
			string m3_TAXC = null, 
			string m3_HAFE = null, 
			string m3_EDE2 = null, 
			string m3_TOWN = null, 
			decimal? m3_GEOX = null, 
			decimal? m3_GEOY = null, 
			decimal? m3_GEOZ = null, 
			DateTime? m3_FVDT = null, 
			DateTime? m3_LVDT = null, 
			string m3_FRCO = null, 
			string m3_RASN = null, 
			string m3_SPLE = null, 
			int? m3_PRIO = null, 
			string m3_ADCG = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");
			if (string.IsNullOrWhiteSpace(m3_CUA1))
				throw new ArgumentNullException("m3_CUA1");
			if (string.IsNullOrWhiteSpace(m3_CSCD))
				throw new ArgumentNullException("m3_CSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ADRT", m3_ADRT.ToString())
				.WithQueryParameter("ADID", m3_ADID.Trim())
				.WithQueryParameter("CUA1", m3_CUA1.Trim())
				.WithQueryParameter("CSCD", m3_CSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADVI))
				request.WithQueryParameter("ADVI", m3_ADVI.Trim());
			if (m3_EALO.HasValue)
				request.WithQueryParameter("EALO", m3_EALO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RONO))
				request.WithQueryParameter("RONO", m3_RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPE))
				request.WithQueryParameter("DEPE", m3_DEPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEL2))
				request.WithQueryParameter("TEL2", m3_TEL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LSID))
				request.WithQueryParameter("LSID", m3_LSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LSAD))
				request.WithQueryParameter("LSAD", m3_LSAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEAL))
				request.WithQueryParameter("MEAL", m3_MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROUT))
				request.WithQueryParameter("ROUT", m3_ROUT.Trim());
			if (m3_RODN.HasValue)
				request.WithQueryParameter("RODN", m3_RODN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ULZO))
				request.WithQueryParameter("ULZO", m3_ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDE2))
				request.WithQueryParameter("EDE2", m3_EDE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (m3_GEOX.HasValue)
				request.WithQueryParameter("GEOX", m3_GEOX.Value.ToString());
			if (m3_GEOY.HasValue)
				request.WithQueryParameter("GEOY", m3_GEOY.Value.ToString());
			if (m3_GEOZ.HasValue)
				request.WithQueryParameter("GEOZ", m3_GEOZ.Value.ToString());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPLE))
				request.WithQueryParameter("SPLE", m3_SPLE.Trim());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADCG))
				request.WithQueryParameter("ADCG", m3_ADCG.Trim());

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
		/// Name ChgBasicData
		/// Description Modify customer basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUA1">Customer address 1</param>
		/// <param name="m3_CUA2">Customer address 2</param>
		/// <param name="m3_CUA3">Customer address 3</param>
		/// <param name="m3_CUA4">Customer address 4</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_TFNO">Facsimile number</param>
		/// <param name="m3_CUTP">Customer type</param>
		/// <param name="m3_ALCU">Search key</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_YRE2">Your reference 2</param>
		/// <param name="m3_MAIL">E-mail address</param>
		/// <param name="m3_CSCD">Country code</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_CFC1">free field 1</param>
		/// <param name="m3_CFC2">Free field 2</param>
		/// <param name="m3_CFC3">Free field 3</param>
		/// <param name="m3_CFC4">Free field 4</param>
		/// <param name="m3_CFC5">Free field 5</param>
		/// <param name="m3_CFC6">Free field 6</param>
		/// <param name="m3_CFC7">Free field 7</param>
		/// <param name="m3_CFC8">Free field 8</param>
		/// <param name="m3_CFC9">Free field 9</param>
		/// <param name="m3_CFC0">Free field 10</param>
		/// <param name="m3_CESA">SMS id</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_PWM1">Old password</param>
		/// <param name="m3_PWM2">New password</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_CUSU">Our supplier number at customer</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_EALO">EAN location code</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_SPLE">Standard point location code</param>
		/// <param name="m3_LSID">User</param>
		/// <param name="m3_LSAD">Address</param>
		/// <param name="m3_MEAL">Valid media</param>
		/// <param name="m3_HAFE">Harbor or airport</param>
		/// <param name="m3_GEOC">Geographic code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgBasicDataResponse></returns>
		/// <exception cref="M3Exception<ChgBasicDataResponse>"></exception>
		public async Task<M3Response<ChgBasicDataResponse>> ChgBasicData(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_LNCD = null, 
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_PONO = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_TFNO = null, 
			int? m3_CUTP = null, 
			string m3_ALCU = null, 
			string m3_YREF = null, 
			string m3_YRE2 = null, 
			string m3_MAIL = null, 
			string m3_CSCD = null, 
			string m3_ECAR = null, 
			string m3_CFC1 = null, 
			decimal? m3_CFC2 = null, 
			string m3_CFC3 = null, 
			string m3_CFC4 = null, 
			string m3_CFC5 = null, 
			string m3_CFC6 = null, 
			decimal? m3_CFC7 = null, 
			string m3_CFC8 = null, 
			string m3_CFC9 = null, 
			string m3_CFC0 = null, 
			string m3_CESA = null, 
			string m3_STAT = null, 
			string m3_PWM1 = null, 
			string m3_PWM2 = null, 
			string m3_EDES = null, 
			string m3_TOWN = null, 
			string m3_CUSU = null, 
			string m3_FRCO = null, 
			decimal? m3_EALO = null, 
			string m3_RASN = null, 
			string m3_SPLE = null, 
			string m3_LSID = null, 
			string m3_LSAD = null, 
			string m3_MEAL = null, 
			string m3_HAFE = null, 
			int? m3_GEOC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (m3_CUTP.HasValue)
				request.WithQueryParameter("CUTP", m3_CUTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALCU))
				request.WithQueryParameter("ALCU", m3_ALCU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE2))
				request.WithQueryParameter("YRE2", m3_YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAIL))
				request.WithQueryParameter("MAIL", m3_MAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC1))
				request.WithQueryParameter("CFC1", m3_CFC1.Trim());
			if (m3_CFC2.HasValue)
				request.WithQueryParameter("CFC2", m3_CFC2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFC3))
				request.WithQueryParameter("CFC3", m3_CFC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC4))
				request.WithQueryParameter("CFC4", m3_CFC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC5))
				request.WithQueryParameter("CFC5", m3_CFC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC6))
				request.WithQueryParameter("CFC6", m3_CFC6.Trim());
			if (m3_CFC7.HasValue)
				request.WithQueryParameter("CFC7", m3_CFC7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFC8))
				request.WithQueryParameter("CFC8", m3_CFC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC9))
				request.WithQueryParameter("CFC9", m3_CFC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC0))
				request.WithQueryParameter("CFC0", m3_CFC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PWM1))
				request.WithQueryParameter("PWM1", m3_PWM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PWM2))
				request.WithQueryParameter("PWM2", m3_PWM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUSU))
				request.WithQueryParameter("CUSU", m3_CUSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (m3_EALO.HasValue)
				request.WithQueryParameter("EALO", m3_EALO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPLE))
				request.WithQueryParameter("SPLE", m3_SPLE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LSID))
				request.WithQueryParameter("LSID", m3_LSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LSAD))
				request.WithQueryParameter("LSAD", m3_LSAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEAL))
				request.WithQueryParameter("MEAL", m3_MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());

			// Execute the request
			var result = await Execute<ChgBasicDataResponse>(
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
		/// Name ChgFinancial
		/// Description Modify customer financial data
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CORG">Organization number 1</param>
		/// <param name="m3_COR2">Organization number 2</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_CRLM">Credit limit 1 - max overdue invoices</param>
		/// <param name="m3_CRL2">Credit limit 2 - max out.invoices</param>
		/// <param name="m3_CRL3">Credit limit 3 - max out.invoices + ord.</param>
		/// <param name="m3_ODUD">Credit limit 4 - max days on invoices</param>
		/// <param name="m3_TDIN">Overdue invoice amount</param>
		/// <param name="m3_INCO">Insurance company</param>
		/// <param name="m3_INSN">Insurance number</param>
		/// <param name="m3_INLI">Insurance limit</param>
		/// <param name="m3_AGPY">Payer - post giro</param>
		/// <param name="m3_AGCP">Clearing number -  post giro</param>
		/// <param name="m3_AGAC">Account number - post giro</param>
		/// <param name="m3_AGBP">Payer - bank giro</param>
		/// <param name="m3_AGLB">Clearing number - bank giro</param>
		/// <param name="m3_AACB">Account number - bank giro</param>
		/// <param name="m3_AGBG">Bank giro number</param>
		/// <param name="m3_AGPG">Post giro number</param>
		/// <param name="m3_CRTP">Exchange rate type</param>
		/// <param name="m3_TXAP">Tax applicable</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_TECN">Tax exemption contract number</param>
		/// <param name="m3_TEEC">Tax exemption expiry date</param>
		/// <param name="m3_TAXC">Tax code</param>
		/// <param name="m3_CDRC">Credit department reference</param>
		/// <param name="m3_PYCD">Payment method AR</param>
		/// <param name="m3_TECD">Cash discount term</param>
		/// <param name="m3_BLCD">Customer stop</param>
		/// <param name="m3_CLCD">Collection</param>
		/// <param name="m3_BLPR">Payment reminder code</param>
		/// <param name="m3_RMCT">Payment reminder rule</param>
		/// <param name="m3_BLAC">Advice code</param>
		/// <param name="m3_ADCA">Advice rule</param>
		/// <param name="m3_PYDI">Payment instruction</param>
		/// <param name="m3_CCUS">Company group customer number</param>
		/// <param name="m3_STMR">Statement rule</param>
		/// <param name="m3_BLII">Interest invoicing</param>
		/// <param name="m3_IICT">Interest rule</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgFinancial(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_LNCD = null, 
			string m3_CUNM = null, 
			string m3_CORG = null, 
			string m3_COR2 = null, 
			string m3_CUCD = null, 
			int? m3_VTCD = null, 
			string m3_VRNO = null, 
			decimal? m3_CRLM = null, 
			decimal? m3_CRL2 = null, 
			decimal? m3_CRL3 = null, 
			int? m3_ODUD = null, 
			decimal? m3_TDIN = null, 
			string m3_INCO = null, 
			string m3_INSN = null, 
			decimal? m3_INLI = null, 
			string m3_AGPY = null, 
			string m3_AGCP = null, 
			string m3_AGAC = null, 
			string m3_AGBP = null, 
			string m3_AGLB = null, 
			string m3_AACB = null, 
			long? m3_AGBG = null, 
			string m3_AGPG = null, 
			int? m3_CRTP = null, 
			int? m3_TXAP = null, 
			int? m3_GEOC = null, 
			string m3_TECN = null, 
			DateTime? m3_TEEC = null, 
			string m3_TAXC = null, 
			string m3_CDRC = null, 
			string m3_PYCD = null, 
			string m3_TECD = null, 
			int? m3_BLCD = null, 
			int? m3_CLCD = null, 
			int? m3_BLPR = null, 
			string m3_RMCT = null, 
			int? m3_BLAC = null, 
			string m3_ADCA = null, 
			string m3_PYDI = null, 
			string m3_CCUS = null, 
			string m3_STMR = null, 
			int? m3_BLII = null, 
			string m3_IICT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgFinancial",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORG))
				request.WithQueryParameter("CORG", m3_CORG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COR2))
				request.WithQueryParameter("COR2", m3_COR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (m3_CRLM.HasValue)
				request.WithQueryParameter("CRLM", m3_CRLM.Value.ToString());
			if (m3_CRL2.HasValue)
				request.WithQueryParameter("CRL2", m3_CRL2.Value.ToString());
			if (m3_CRL3.HasValue)
				request.WithQueryParameter("CRL3", m3_CRL3.Value.ToString());
			if (m3_ODUD.HasValue)
				request.WithQueryParameter("ODUD", m3_ODUD.Value.ToString());
			if (m3_TDIN.HasValue)
				request.WithQueryParameter("TDIN", m3_TDIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INCO))
				request.WithQueryParameter("INCO", m3_INCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSN))
				request.WithQueryParameter("INSN", m3_INSN.Trim());
			if (m3_INLI.HasValue)
				request.WithQueryParameter("INLI", m3_INLI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGPY))
				request.WithQueryParameter("AGPY", m3_AGPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGCP))
				request.WithQueryParameter("AGCP", m3_AGCP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGAC))
				request.WithQueryParameter("AGAC", m3_AGAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGBP))
				request.WithQueryParameter("AGBP", m3_AGBP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGLB))
				request.WithQueryParameter("AGLB", m3_AGLB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AACB))
				request.WithQueryParameter("AACB", m3_AACB.Trim());
			if (m3_AGBG.HasValue)
				request.WithQueryParameter("AGBG", m3_AGBG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGPG))
				request.WithQueryParameter("AGPG", m3_AGPG.Trim());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (m3_TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3_TXAP.Value.ToString());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECN))
				request.WithQueryParameter("TECN", m3_TECN.Trim());
			if (m3_TEEC.HasValue)
				request.WithQueryParameter("TEEC", m3_TEEC.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CDRC))
				request.WithQueryParameter("CDRC", m3_CDRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYCD))
				request.WithQueryParameter("PYCD", m3_PYCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECD))
				request.WithQueryParameter("TECD", m3_TECD.Trim());
			if (m3_BLCD.HasValue)
				request.WithQueryParameter("BLCD", m3_BLCD.Value.ToString());
			if (m3_CLCD.HasValue)
				request.WithQueryParameter("CLCD", m3_CLCD.Value.ToString());
			if (m3_BLPR.HasValue)
				request.WithQueryParameter("BLPR", m3_BLPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RMCT))
				request.WithQueryParameter("RMCT", m3_RMCT.Trim());
			if (m3_BLAC.HasValue)
				request.WithQueryParameter("BLAC", m3_BLAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADCA))
				request.WithQueryParameter("ADCA", m3_ADCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYDI))
				request.WithQueryParameter("PYDI", m3_PYDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCUS))
				request.WithQueryParameter("CCUS", m3_CCUS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STMR))
				request.WithQueryParameter("STMR", m3_STMR.Trim());
			if (m3_BLII.HasValue)
				request.WithQueryParameter("BLII", m3_BLII.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IICT))
				request.WithQueryParameter("IICT", m3_IICT.Trim());

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
		/// Name ChgOrderInfo
		/// Description Modify customer financial data
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUCL">Customer group</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_SDST">District</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_EXCD">Service model</param>
		/// <param name="m3_CHSY">Charge model</param>
		/// <param name="m3_TEDL">Term of delivery</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DISY">Discount model</param>
		/// <param name="m3_DIGC">Discount group - customer</param>
		/// <param name="m3_DIPC">Discount - percentage</param>
		/// <param name="m3_EDES">Place-replaced by EDE2</param>
		/// <param name="m3_PRVG">Commission group</param>
		/// <param name="m3_BGRP">Bonus group</param>
		/// <param name="m3_TEPY">Term of payment</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_IVGP">Invoicing group</param>
		/// <param name="m3_EDE2">Place</param>
		/// <param name="m3_BUSE">Bonus/Commission Active</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ACHK">Assortment Check</param>
		/// <param name="m3_ADVI">Ship-via</param>
		/// <param name="m3_FRE1">Statistic identity 1 customer</param>
		/// <param name="m3_FRE2">Statistic identity 2 customer</param>
		/// <param name="m3_PLTB">Price list table</param>
		/// <param name="m3_INRC">Invoice recipient</param>
		/// <param name="m3_DOGR">Customer document group</param>
		/// <param name="m3_ADBO">Separate invoices</param>
		/// <param name="m3_AICD">Summary invoice</param>
		/// <param name="m3_SPLM">Supply model</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_CUST">Statistics customer</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_PRIO">Priority</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_AGCH">Agreement check - order header</param>
		/// <param name="m3_AGCT">Agreement check - order lines</param>
		/// <param name="m3_ULZO">Unloading zone</param>
		/// <param name="m3_ECLC">Labor code - trade statistics (TST)</param>
		/// <param name="m3_GRPY">Group invoice</param>
		/// <param name="m3_TINC">VAT included</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_PRDL">Print delivery information</param>
		/// <param name="m3_MCOS">CO number mandatory</param>
		/// <param name="m3_BCKO">Backorder</param>
		/// <param name="m3_PADL">Partial delivery</param>
		/// <param name="m3_SCED">Delivery regrouping</param>
		/// <param name="m3_BOP1">Automatic closing</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOrderInfo(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_LNCD = null, 
			string m3_CUNM = null, 
			string m3_CUCL = null, 
			string m3_OREF = null, 
			string m3_SMCD = null, 
			string m3_SDST = null, 
			string m3_ORTP = null, 
			string m3_EXCD = null, 
			string m3_CHSY = null, 
			string m3_TEDL = null, 
			string m3_MODL = null, 
			string m3_WHLO = null, 
			string m3_DISY = null, 
			string m3_DIGC = null, 
			int? m3_DIPC = null, 
			string m3_EDES = null, 
			string m3_PRVG = null, 
			string m3_BGRP = null, 
			string m3_TEPY = null, 
			string m3_PYNO = null, 
			string m3_IVGP = null, 
			string m3_EDE2 = null, 
			int? m3_BUSE = null, 
			string m3_FACI = null, 
			int? m3_ACHK = null, 
			string m3_ADVI = null, 
			string m3_FRE1 = null, 
			string m3_FRE2 = null, 
			string m3_PLTB = null, 
			string m3_INRC = null, 
			string m3_DOGR = null, 
			int? m3_ADBO = null, 
			int? m3_AICD = null, 
			string m3_SPLM = null, 
			string m3_ADID = null, 
			string m3_CUST = null, 
			string m3_TEPA = null, 
			int? m3_PRIO = null, 
			string m3_ACRF = null, 
			int? m3_AGCH = null, 
			int? m3_AGCT = null, 
			string m3_ULZO = null, 
			string m3_ECLC = null, 
			int? m3_GRPY = null, 
			int? m3_TINC = null, 
			int? m3_ALWT = null, 
			string m3_POPN = null, 
			int? m3_PRDL = null, 
			int? m3_MCOS = null, 
			int? m3_BCKO = null, 
			int? m3_PADL = null, 
			int? m3_SCED = null, 
			int? m3_BOP1 = null, 
			string m3_RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgOrderInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCL))
				request.WithQueryParameter("CUCL", m3_CUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDST))
				request.WithQueryParameter("SDST", m3_SDST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EXCD))
				request.WithQueryParameter("EXCD", m3_EXCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHSY))
				request.WithQueryParameter("CHSY", m3_CHSY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DISY))
				request.WithQueryParameter("DISY", m3_DISY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIGC))
				request.WithQueryParameter("DIGC", m3_DIGC.Trim());
			if (m3_DIPC.HasValue)
				request.WithQueryParameter("DIPC", m3_DIPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRVG))
				request.WithQueryParameter("PRVG", m3_PRVG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BGRP))
				request.WithQueryParameter("BGRP", m3_BGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IVGP))
				request.WithQueryParameter("IVGP", m3_IVGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDE2))
				request.WithQueryParameter("EDE2", m3_EDE2.Trim());
			if (m3_BUSE.HasValue)
				request.WithQueryParameter("BUSE", m3_BUSE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_ACHK.HasValue)
				request.WithQueryParameter("ACHK", m3_ACHK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADVI))
				request.WithQueryParameter("ADVI", m3_ADVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE1))
				request.WithQueryParameter("FRE1", m3_FRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE2))
				request.WithQueryParameter("FRE2", m3_FRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTB))
				request.WithQueryParameter("PLTB", m3_PLTB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INRC))
				request.WithQueryParameter("INRC", m3_INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOGR))
				request.WithQueryParameter("DOGR", m3_DOGR.Trim());
			if (m3_ADBO.HasValue)
				request.WithQueryParameter("ADBO", m3_ADBO.Value.ToString());
			if (m3_AICD.HasValue)
				request.WithQueryParameter("AICD", m3_AICD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPLM))
				request.WithQueryParameter("SPLM", m3_SPLM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUST))
				request.WithQueryParameter("CUST", m3_CUST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (m3_PRIO.HasValue)
				request.WithQueryParameter("PRIO", m3_PRIO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (m3_AGCH.HasValue)
				request.WithQueryParameter("AGCH", m3_AGCH.Value.ToString());
			if (m3_AGCT.HasValue)
				request.WithQueryParameter("AGCT", m3_AGCT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ULZO))
				request.WithQueryParameter("ULZO", m3_ULZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECLC))
				request.WithQueryParameter("ECLC", m3_ECLC.Trim());
			if (m3_GRPY.HasValue)
				request.WithQueryParameter("GRPY", m3_GRPY.Value.ToString());
			if (m3_TINC.HasValue)
				request.WithQueryParameter("TINC", m3_TINC.Value.ToString());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (m3_PRDL.HasValue)
				request.WithQueryParameter("PRDL", m3_PRDL.Value.ToString());
			if (m3_MCOS.HasValue)
				request.WithQueryParameter("MCOS", m3_MCOS.Value.ToString());
			if (m3_BCKO.HasValue)
				request.WithQueryParameter("BCKO", m3_BCKO.Value.ToString());
			if (m3_PADL.HasValue)
				request.WithQueryParameter("PADL", m3_PADL.Value.ToString());
			if (m3_SCED.HasValue)
				request.WithQueryParameter("SCED", m3_SCED.Value.ToString());
			if (m3_BOP1.HasValue)
				request.WithQueryParameter("BOP1", m3_BOP1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

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
		/// Name ChgRentalData
		/// Description Modify customer rental data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RPLT">Rental price list table</param>
		/// <param name="m3_RDIS">Rental discount model</param>
		/// <param name="m3_RTEP">Rental payment terms</param>
		/// <param name="m3_RSMC">Rental salesperson</param>
		/// <param name="m3_AOTP">Agreement order type</param>
		/// <param name="m3_ST75">Rental rate type</param>
		/// <param name="m3_ST76">Number of shifts</param>
		/// <param name="m3_ST77">Number of days per week</param>
		/// <param name="m3_ST78">Minimum days/week to invoice a week</param>
		/// <param name="m3_RAFA">Rate factor</param>
		/// <param name="m3_MRTP">Minimum rental type</param>
		/// <param name="m3_MINV">Min rental amount</param>
		/// <param name="m3_MIHP">Min rental period</param>
		/// <param name="m3_RTYR">Return year - open agreement</param>
		/// <param name="m3_RTMO">Return month - open agreement</param>
		/// <param name="m3_IIYR">Invoice interval - years</param>
		/// <param name="m3_IIMO">Invoice interval - months</param>
		/// <param name="m3_IIDA">Invoice intervall days</param>
		/// <param name="m3_DPOT">Rental depot</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgRentalData(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_RPLT = null, 
			string m3_RDIS = null, 
			string m3_RTEP = null, 
			string m3_RSMC = null, 
			string m3_AOTP = null, 
			string m3_ST75 = null, 
			int? m3_ST76 = null, 
			int? m3_ST77 = null, 
			int? m3_ST78 = null, 
			int? m3_RAFA = null, 
			int? m3_MRTP = null, 
			decimal? m3_MINV = null, 
			int? m3_MIHP = null, 
			int? m3_RTYR = null, 
			int? m3_RTMO = null, 
			int? m3_IIYR = null, 
			int? m3_IIMO = null, 
			int? m3_IIDA = null, 
			string m3_DPOT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgRentalData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPLT))
				request.WithQueryParameter("RPLT", m3_RPLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RDIS))
				request.WithQueryParameter("RDIS", m3_RDIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RTEP))
				request.WithQueryParameter("RTEP", m3_RTEP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSMC))
				request.WithQueryParameter("RSMC", m3_RSMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOTP))
				request.WithQueryParameter("AOTP", m3_AOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ST75))
				request.WithQueryParameter("ST75", m3_ST75.Trim());
			if (m3_ST76.HasValue)
				request.WithQueryParameter("ST76", m3_ST76.Value.ToString());
			if (m3_ST77.HasValue)
				request.WithQueryParameter("ST77", m3_ST77.Value.ToString());
			if (m3_ST78.HasValue)
				request.WithQueryParameter("ST78", m3_ST78.Value.ToString());
			if (m3_RAFA.HasValue)
				request.WithQueryParameter("RAFA", m3_RAFA.Value.ToString());
			if (m3_MRTP.HasValue)
				request.WithQueryParameter("MRTP", m3_MRTP.Value.ToString());
			if (m3_MINV.HasValue)
				request.WithQueryParameter("MINV", m3_MINV.Value.ToString());
			if (m3_MIHP.HasValue)
				request.WithQueryParameter("MIHP", m3_MIHP.Value.ToString());
			if (m3_RTYR.HasValue)
				request.WithQueryParameter("RTYR", m3_RTYR.Value.ToString());
			if (m3_RTMO.HasValue)
				request.WithQueryParameter("RTMO", m3_RTMO.Value.ToString());
			if (m3_IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3_IIYR.Value.ToString());
			if (m3_IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3_IIMO.Value.ToString());
			if (m3_IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3_IIDA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DPOT))
				request.WithQueryParameter("DPOT", m3_DPOT.Trim());

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
		/// Name ChgServOrdInfo
		/// Description Modify customer Service Order data
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_SOTP">Service order type</param>
		/// <param name="m3_PRS1">Price list SO</param>
		/// <param name="m3_PRS2">Price list 2 SO</param>
		/// <param name="m3_PRS3">Price list 3 SO</param>
		/// <param name="m3_PRS4">Price list 4 SO</param>
		/// <param name="m3_PRS5">Price list 5 SO</param>
		/// <param name="m3_DMSO">Discount model SO</param>
		/// <param name="m3_MCON">Mandatory entry of customer's order no.</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgServOrdInfo(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_SRES = null, 
			string m3_TECH = null, 
			string m3_SOTP = null, 
			string m3_PRS1 = null, 
			string m3_PRS2 = null, 
			string m3_PRS3 = null, 
			string m3_PRS4 = null, 
			string m3_PRS5 = null, 
			string m3_DMSO = null, 
			int? m3_MCON = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgServOrdInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SOTP))
				request.WithQueryParameter("SOTP", m3_SOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRS1))
				request.WithQueryParameter("PRS1", m3_PRS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRS2))
				request.WithQueryParameter("PRS2", m3_PRS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRS3))
				request.WithQueryParameter("PRS3", m3_PRS3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRS4))
				request.WithQueryParameter("PRS4", m3_PRS4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRS5))
				request.WithQueryParameter("PRS5", m3_PRS5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DMSO))
				request.WithQueryParameter("DMSO", m3_DMSO.Trim());
			if (m3_MCON.HasValue)
				request.WithQueryParameter("MCON", m3_MCON.Value.ToString());

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
		/// Name Copy
		/// Description Copy an existing customer record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUTM">Customer number - Existing (Required)</param>
		/// <param name="m3_CUNM">Customer name (Required)</param>
		/// <param name="m3_CUA1">Customer address 1 (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CUNO">Customer number - New</param>
		/// <param name="m3_CUA2">Customer address 2</param>
		/// <param name="m3_CUA3">Customer address 3</param>
		/// <param name="m3_CUA4">Customer address 4</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_TFNO">Facsimile number</param>
		/// <param name="m3_CUTP">Customer type</param>
		/// <param name="m3_ALCU">Search key</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_YRE2">Your reference 2</param>
		/// <param name="m3_MAIL">E-mail address</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_CSCD">Country code</param>
		/// <param name="m3_CFC1">free field 1</param>
		/// <param name="m3_CFC2">Free field 2</param>
		/// <param name="m3_CFC4">Free field 4</param>
		/// <param name="m3_CFC5">Free field 5</param>
		/// <param name="m3_CFC3">Free field 3</param>
		/// <param name="m3_CFC6">Free field 6</param>
		/// <param name="m3_CFC7">Free field 7</param>
		/// <param name="m3_CFC8">Free field 8</param>
		/// <param name="m3_CFC0">Free field 10</param>
		/// <param name="m3_CFC9">Free field 9</param>
		/// <param name="m3_CESA">SMS id</param>
		/// <param name="m3_STAT">Customer status</param>
		/// <param name="m3_IVGP">Invoicing group</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_EALO">EAN location code</param>
		/// <param name="m3_LSID">User</param>
		/// <param name="m3_LSAD">Address</param>
		/// <param name="m3_MEAL">Valid media</param>
		/// <param name="m3_HAFE">Harbor or airport</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CopyResponse></returns>
		/// <exception cref="M3Exception<CopyResponse>"></exception>
		public async Task<M3Response<CopyResponse>> Copy(
			string m3_CUTM, 
			string m3_CUNM, 
			string m3_CUA1, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_LNCD = null, 
			string m3_CUNO = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_PONO = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_TFNO = null, 
			int? m3_CUTP = null, 
			string m3_ALCU = null, 
			string m3_YREF = null, 
			string m3_YRE2 = null, 
			string m3_MAIL = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_CFC1 = null, 
			decimal? m3_CFC2 = null, 
			string m3_CFC4 = null, 
			string m3_CFC5 = null, 
			string m3_CFC3 = null, 
			string m3_CFC6 = null, 
			decimal? m3_CFC7 = null, 
			string m3_CFC8 = null, 
			string m3_CFC0 = null, 
			string m3_CFC9 = null, 
			string m3_CESA = null, 
			string m3_STAT = null, 
			string m3_IVGP = null, 
			string m3_EDES = null, 
			string m3_TOWN = null, 
			string m3_FRCO = null, 
			decimal? m3_EALO = null, 
			string m3_LSID = null, 
			string m3_LSAD = null, 
			string m3_MEAL = null, 
			string m3_HAFE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Copy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUTM))
				throw new ArgumentNullException("m3_CUTM");
			if (string.IsNullOrWhiteSpace(m3_CUNM))
				throw new ArgumentNullException("m3_CUNM");
			if (string.IsNullOrWhiteSpace(m3_CUA1))
				throw new ArgumentNullException("m3_CUA1");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUTM", m3_CUTM.Trim())
				.WithQueryParameter("CUNM", m3_CUNM.Trim())
				.WithQueryParameter("CUA1", m3_CUA1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (m3_CUTP.HasValue)
				request.WithQueryParameter("CUTP", m3_CUTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALCU))
				request.WithQueryParameter("ALCU", m3_ALCU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE2))
				request.WithQueryParameter("YRE2", m3_YRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAIL))
				request.WithQueryParameter("MAIL", m3_MAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC1))
				request.WithQueryParameter("CFC1", m3_CFC1.Trim());
			if (m3_CFC2.HasValue)
				request.WithQueryParameter("CFC2", m3_CFC2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFC4))
				request.WithQueryParameter("CFC4", m3_CFC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC5))
				request.WithQueryParameter("CFC5", m3_CFC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC3))
				request.WithQueryParameter("CFC3", m3_CFC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC6))
				request.WithQueryParameter("CFC6", m3_CFC6.Trim());
			if (m3_CFC7.HasValue)
				request.WithQueryParameter("CFC7", m3_CFC7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFC8))
				request.WithQueryParameter("CFC8", m3_CFC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC0))
				request.WithQueryParameter("CFC0", m3_CFC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFC9))
				request.WithQueryParameter("CFC9", m3_CFC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IVGP))
				request.WithQueryParameter("IVGP", m3_IVGP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDES))
				request.WithQueryParameter("EDES", m3_EDES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (m3_EALO.HasValue)
				request.WithQueryParameter("EALO", m3_EALO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LSID))
				request.WithQueryParameter("LSID", m3_LSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LSAD))
				request.WithQueryParameter("LSAD", m3_LSAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEAL))
				request.WithQueryParameter("MEAL", m3_MEAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());

			// Execute the request
			var result = await Execute<CopyResponse>(
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
		/// Name Delete
		/// Description Delete a customer record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_CUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

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
		/// Name DeleteAddress
		/// Description Delete a customer address record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteAddress(
			string m3_CUNO, 
			int m3_ADRT, 
			string m3_ADID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ADRT", m3_ADRT.ToString())
				.WithQueryParameter("ADID", m3_ADID.Trim());

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
		/// Name EXPORTSMS
		/// Description Export to SMS (NO STANDARD TRANSACTION)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<EXPORTSMSResponse></returns>
		/// <exception cref="M3Exception<EXPORTSMSResponse>"></exception>
		public async Task<M3Response<EXPORTSMSResponse>> EXPORTSMS(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/EXPORTSMS",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<EXPORTSMSResponse>(
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
		/// Name GetAddress
		/// Description Retrieve customer address data
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			string m3_CUNO, 
			int m3_ADRT, 
			string m3_ADID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("ADRT", m3_ADRT.ToString())
				.WithQueryParameter("ADID", m3_ADID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetAddressResponse>(
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
		/// Description Retrieve customer basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3_CUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name GetFinancial
		/// Description Retrieve customer financial data
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFinancialResponse></returns>
		/// <exception cref="M3Exception<GetFinancialResponse>"></exception>
		public async Task<M3Response<GetFinancialResponse>> GetFinancial(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFinancial",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetFinancialResponse>(
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
		/// Name GetOrderInfo
		/// Description Retrieve customer financial data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderInfoResponse></returns>
		/// <exception cref="M3Exception<GetOrderInfoResponse>"></exception>
		public async Task<M3Response<GetOrderInfoResponse>> GetOrderInfo(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOrderInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetOrderInfoResponse>(
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
		/// Name GetRentalData
		/// Description Displaycustomer rental data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRentalDataResponse></returns>
		/// <exception cref="M3Exception<GetRentalDataResponse>"></exception>
		public async Task<M3Response<GetRentalDataResponse>> GetRentalData(
			string m3_CUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetRentalData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetRentalDataResponse>(
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
		/// Name GetServOrdInfo
		/// Description Retrieve customer Service Order data
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetServOrdInfoResponse></returns>
		/// <exception cref="M3Exception<GetServOrdInfoResponse>"></exception>
		public async Task<M3Response<GetServOrdInfoResponse>> GetServOrdInfo(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetServOrdInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetServOrdInfoResponse>(
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
		/// Name IMPORTSMS
		/// Description NOT A STANDARD TRANSACTION FOR COMMON USE
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TPRE">Record type</param>
		/// <param name="m3_OPT2">Option</param>
		/// <param name="m3_CESA">Marketing ID - Movex SMS</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_CORG">Organization number 1</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_SMAD">Address</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_SMCI">City</param>
		/// <param name="m3_SMCO">County</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_SDST">District</param>
		/// <param name="m3_CUCL">Customer group</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_CRL3">Credit limit 3</param>
		/// <param name="m3_RGDT">Entry date</param>
		/// <param name="m3_LMDT">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> IMPORTSMS(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_TPRE = null, 
			string m3_OPT2 = null, 
			string m3_CESA = null, 
			string m3_CUNO = null, 
			string m3_CORG = null, 
			string m3_CUNM = null, 
			string m3_SMAD = null, 
			string m3_PONO = null, 
			string m3_SMCI = null, 
			string m3_SMCO = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_SDST = null, 
			string m3_CUCL = null, 
			string m3_TEPY = null, 
			decimal? m3_CRL3 = null, 
			DateTime? m3_RGDT = null, 
			DateTime? m3_LMDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/IMPORTSMS",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPRE))
				request.WithQueryParameter("TPRE", m3_TPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPT2))
				request.WithQueryParameter("OPT2", m3_OPT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORG))
				request.WithQueryParameter("CORG", m3_CORG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMAD))
				request.WithQueryParameter("SMAD", m3_SMAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCI))
				request.WithQueryParameter("SMCI", m3_SMCI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCO))
				request.WithQueryParameter("SMCO", m3_SMCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDST))
				request.WithQueryParameter("SDST", m3_SDST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCL))
				request.WithQueryParameter("CUCL", m3_CUCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (m3_CRL3.HasValue)
				request.WithQueryParameter("CRL3", m3_CRL3.Value.ToString());
			if (m3_RGDT.HasValue)
				request.WithQueryParameter("RGDT", m3_RGDT.Value.ToM3String());
			if (m3_LMDT.HasValue)
				request.WithQueryParameter("LMDT", m3_LMDT.Value.ToM3String());

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
		/// Name LstAddresses
		/// Description List customer address related information
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAddressesResponse></returns>
		/// <exception cref="M3Exception<LstAddressesResponse>"></exception>
		public async Task<M3Response<LstAddressesResponse>> LstAddresses(
			string m3_CUNO, 
			int? m3_CONO = null, 
			decimal? m3_LMTS = null, 
			int? m3_ADRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAddresses",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());

			// Execute the request
			var result = await Execute<LstAddressesResponse>(
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
		/// Name LstByGroup
		/// Description List customer in order group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUCL">Customer group (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByGroupResponse></returns>
		/// <exception cref="M3Exception<LstByGroupResponse>"></exception>
		public async Task<M3Response<LstByGroupResponse>> LstByGroup(
			string m3_CUCL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByGroup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUCL))
				throw new ArgumentNullException("m3_CUCL");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCL", m3_CUCL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstByGroupResponse>(
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
		/// Name LstByInvoiceRec
		/// Description List customers having a specific invoice recipient
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_INRC">Invoice recipient (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByInvoiceRecResponse></returns>
		/// <exception cref="M3Exception<LstByInvoiceRecResponse>"></exception>
		public async Task<M3Response<LstByInvoiceRecResponse>> LstByInvoiceRec(
			string m3_INRC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByInvoiceRec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_INRC))
				throw new ArgumentNullException("m3_INRC");

			// Set mandatory parameters
			request
				.WithQueryParameter("INRC", m3_INRC.Trim());

			// Execute the request
			var result = await Execute<LstByInvoiceRecResponse>(
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
		/// Name LstByMarketDim
		/// Description List customer in market dimension order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRCO">From Customer number</param>
		/// <param name="m3_TOCO">To Customer number</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByMarketDimResponse></returns>
		/// <exception cref="M3Exception<LstByMarketDimResponse>"></exception>
		public async Task<M3Response<LstByMarketDimResponse>> LstByMarketDim(
			int? m3_CONO = null, 
			string m3_FRCO = null, 
			string m3_TOCO = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByMarketDim",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOCO))
				request.WithQueryParameter("TOCO", m3_TOCO.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstByMarketDimResponse>(
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
		/// Name LstByName
		/// Description List customer data in customer name order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByNameResponse></returns>
		/// <exception cref="M3Exception<LstByNameResponse>"></exception>
		public async Task<M3Response<LstByNameResponse>> LstByName(
			int? m3_CONO = null, 
			string m3_CUNM = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByName",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstByNameResponse>(
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
		/// Name LstByNumber
		/// Description List customer data in customer number order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByNumberResponse></returns>
		/// <exception cref="M3Exception<LstByNumberResponse>"></exception>
		public async Task<M3Response<LstByNumberResponse>> LstByNumber(
			int? m3_CONO = null, 
			string m3_CUNO = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByNumber",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstByNumberResponse>(
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
		/// Name LstBySearchKey
		/// Description List customer data by search key
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ALCU">Search key</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBySearchKeyResponse></returns>
		/// <exception cref="M3Exception<LstBySearchKeyResponse>"></exception>
		public async Task<M3Response<LstBySearchKeyResponse>> LstBySearchKey(
			int? m3_CONO = null, 
			string m3_ALCU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBySearchKey",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALCU))
				request.WithQueryParameter("ALCU", m3_ALCU.Trim());

			// Execute the request
			var result = await Execute<LstBySearchKeyResponse>(
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
		/// Name LstCustCharges
		/// Description List Customer Charges
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="m3_CRTY">Internal</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustChargesResponse></returns>
		/// <exception cref="M3Exception<LstCustChargesResponse>"></exception>
		public async Task<M3Response<LstCustChargesResponse>> LstCustCharges(
			int? m3_CONO = null, 
			string m3_CUNO = null, 
			string m3_CRID = null, 
			int? m3_CRTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustCharges",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());
			if (m3_CRTY.HasValue)
				request.WithQueryParameter("CRTY", m3_CRTY.Value.ToString());

			// Execute the request
			var result = await Execute<LstCustChargesResponse>(
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
		/// Name LstTemplates
		/// Description List customer templates
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTemplatesResponse></returns>
		/// <exception cref="M3Exception<LstTemplatesResponse>"></exception>
		public async Task<M3Response<LstTemplatesResponse>> LstTemplates(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTemplates",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstTemplatesResponse>(
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
		/// Name LstUsrDefField1
		/// Description User defiened field 1
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FCF1">From User def field 1</param>
		/// <param name="m3_TCF1">To User def field 1</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUsrDefField1Response></returns>
		/// <exception cref="M3Exception<LstUsrDefField1Response>"></exception>
		public async Task<M3Response<LstUsrDefField1Response>> LstUsrDefField1(
			int? m3_CONO = null, 
			string m3_FCF1 = null, 
			long? m3_TCF1 = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstUsrDefField1",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCF1))
				request.WithQueryParameter("FCF1", m3_FCF1.Trim());
			if (m3_TCF1.HasValue)
				request.WithQueryParameter("TCF1", m3_TCF1.Value.ToString());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstUsrDefField1Response>(
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
		/// Name LstUsrDefField3
		/// Description User defiened field 3
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FCF3">From User def field 3</param>
		/// <param name="m3_TCF3">To User def field 3</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUsrDefField3Response></returns>
		/// <exception cref="M3Exception<LstUsrDefField3Response>"></exception>
		public async Task<M3Response<LstUsrDefField3Response>> LstUsrDefField3(
			int? m3_CONO = null, 
			string m3_FCF3 = null, 
			string m3_TCF3 = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstUsrDefField3",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCF3))
				request.WithQueryParameter("FCF3", m3_FCF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCF3))
				request.WithQueryParameter("TCF3", m3_TCF3.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstUsrDefField3Response>(
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
		/// Name LstUsrDefField4
		/// Description User defiened field 4
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FCF4">From User def field 4</param>
		/// <param name="m3_TCF4">To User def field 4</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUsrDefField4Response></returns>
		/// <exception cref="M3Exception<LstUsrDefField4Response>"></exception>
		public async Task<M3Response<LstUsrDefField4Response>> LstUsrDefField4(
			int? m3_CONO = null, 
			string m3_FCF4 = null, 
			string m3_TCF4 = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstUsrDefField4",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCF4))
				request.WithQueryParameter("FCF4", m3_FCF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCF4))
				request.WithQueryParameter("TCF4", m3_TCF4.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstUsrDefField4Response>(
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
		/// Name SearchCustCred
		/// Description SearchCustCred
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchCustCredResponse></returns>
		/// <exception cref="M3Exception<SearchCustCredResponse>"></exception>
		public async Task<M3Response<SearchCustCredResponse>> SearchCustCred(
			string m3_SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchCustCred",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchCustCredResponse>(
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
		/// Name SearchCustomer
		/// Description Search for a customer via LES
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchCustomerResponse></returns>
		/// <exception cref="M3Exception<SearchCustomerResponse>"></exception>
		public async Task<M3Response<SearchCustomerResponse>> SearchCustomer(
			string m3_SQRY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchCustomer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SQRY))
				request.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchCustomerResponse>(
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
