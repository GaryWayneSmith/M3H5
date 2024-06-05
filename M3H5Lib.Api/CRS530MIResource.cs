/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRS530MI;
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
	/// Name: CRS530MI
	/// Component Name: Employee
	/// Description: Employee basic data interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS530MIResource : M3BaseResourceEndpoint
	{
		public CRS530MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS530MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAddress
		/// Description AddAddress
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3CUNM">Name</param>
		/// <param name="m3CUA1">Address line 1</param>
		/// <param name="m3CUA2">Address line 2</param>
		/// <param name="m3CUA3">Address line 3</param>
		/// <param name="m3CUA4">Address line 4</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3ADVI">Ship-via address</param>
		/// <param name="m3EALO">EAN location code</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3RONO">Run</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TEL2">Terms text</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3LSID">User</param>
		/// <param name="m3LSAD">Address</param>
		/// <param name="m3MEAL">Valid media</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3ULZO">Unloading zone</param>
		/// <param name="m3CESA">Marketing ID - M3 SMS</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="m3HAFE">Harbor or airport</param>
		/// <param name="m3EDE2">Place</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3GEOX">Geographic code X</param>
		/// <param name="m3GEOY">Geographic code Y</param>
		/// <param name="m3GEOZ">Geographic code  Z</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3SPLE">Standard point location code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddress(
			string m3EMNO, 
			int m3ADRT, 
			string m3ADID = null, 
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3PONO = null, 
			string m3ADVI = null, 
			decimal? m3EALO = null, 
			string m3ECAR = null, 
			string m3RONO = null, 
			string m3DEPT = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEL2 = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3LSID = null, 
			string m3LSAD = null, 
			string m3MEAL = null, 
			string m3CSCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("EMNO", m3EMNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3ADVI))
				request.WithQueryParameter("ADVI", m3ADVI.Trim());
			if (m3EALO.HasValue)
				request.WithQueryParameter("EALO", m3EALO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RONO))
				request.WithQueryParameter("RONO", m3RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
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
		/// Name AddEmployee
		/// Description Add employee record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3EMNM">Name</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3ACEM">Active employee</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3WOSC">Work schedule</param>
		/// <param name="m3WODT">Work schedule from date</param>
		/// <param name="m3SWSC">Start week - schedule</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3PNCO">PIN code</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3IPHN">Internal telephone number</param>
		/// <param name="m3CAPH">Cell telephone number</param>
		/// <param name="m3MXTM">Used in Time & Attendance</param>
		/// <param name="m3MXSO">Used in Service and Rental</param>
		/// <param name="m3MXTA">Used in Time Accounting</param>
		/// <param name="m3MXPM">Used in Manufacturing Order Processing</param>
		/// <param name="m3MXMO">Used in Maintenence</param>
		/// <param name="m3EMTE">Employee template</param>
		/// <param name="m3EBDT">Employment date</param>
		/// <param name="m3EEDT">Termination date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEmployee(
			string m3DIVI, 
			string m3EMNO, 
			int? m3CONO = null, 
			string m3EMNM = null, 
			string m3USID = null, 
			int? m3ACEM = null, 
			string m3FACI = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			int? m3WOSC = null, 
			DateTime? m3WODT = null, 
			int? m3SWSC = null, 
			long? m3CANO = null, 
			string m3PNCO = null, 
			string m3PHNO = null, 
			string m3IPHN = null, 
			string m3CAPH = null, 
			int? m3MXTM = null, 
			int? m3MXSO = null, 
			int? m3MXTA = null, 
			int? m3MXPM = null, 
			int? m3MXMO = null, 
			string m3EMTE = null, 
			DateTime? m3EBDT = null, 
			DateTime? m3EEDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddEmployee",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("EMNO", m3EMNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNM))
				request.WithQueryParameter("EMNM", m3EMNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (m3ACEM.HasValue)
				request.WithQueryParameter("ACEM", m3ACEM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3WOSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WODT.HasValue)
				request.WithQueryParameter("WODT", m3WODT.Value.ToM3String());
			if (m3SWSC.HasValue)
				request.WithQueryParameter("SWSC", m3SWSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PNCO))
				request.WithQueryParameter("PNCO", m3PNCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3IPHN))
				request.WithQueryParameter("IPHN", m3IPHN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAPH))
				request.WithQueryParameter("CAPH", m3CAPH.Trim());
			if (m3MXTM.HasValue)
				request.WithQueryParameter("MXTM", m3MXTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXSO.HasValue)
				request.WithQueryParameter("MXSO", m3MXSO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXTA.HasValue)
				request.WithQueryParameter("MXTA", m3MXTA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXPM.HasValue)
				request.WithQueryParameter("MXPM", m3MXPM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXMO.HasValue)
				request.WithQueryParameter("MXMO", m3MXMO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMTE))
				request.WithQueryParameter("EMTE", m3EMTE.Trim());
			if (m3EBDT.HasValue)
				request.WithQueryParameter("EBDT", m3EBDT.Value.ToM3String());
			if (m3EEDT.HasValue)
				request.WithQueryParameter("EEDT", m3EEDT.Value.ToM3String());

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
		/// Description ChgAddress
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3CUNM">Name</param>
		/// <param name="m3CUA1">Address line 1</param>
		/// <param name="m3CUA2">Address line 2</param>
		/// <param name="m3CUA3">Address line 3</param>
		/// <param name="m3CUA4">Address line 4</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3ADVI">Ship-via address</param>
		/// <param name="m3EALO">EAN location code</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3RONO">Run</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TEL2">Terms text</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3LSID">User</param>
		/// <param name="m3LSAD">Address</param>
		/// <param name="m3MEAL">Valid media</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3EDES">Place</param>
		/// <param name="m3ROUT">Route</param>
		/// <param name="m3RODN">Route departure</param>
		/// <param name="m3ULZO">Unloading zone</param>
		/// <param name="m3CESA">Marketing ID - M3 SMS</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="m3HAFE">Harbor or airport</param>
		/// <param name="m3EDE2">Place</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3GEOX">Geographic code X</param>
		/// <param name="m3GEOY">Geographic code Y</param>
		/// <param name="m3GEOZ">Geographic code  Z</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3SPLE">Standard point location code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAddress(
			string m3EMNO, 
			int m3ADRT, 
			string m3ADID, 
			DateTime? m3STDT = null, 
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3PONO = null, 
			string m3ADVI = null, 
			decimal? m3EALO = null, 
			string m3ECAR = null, 
			string m3RONO = null, 
			string m3DEPT = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEL2 = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3LSID = null, 
			string m3LSAD = null, 
			string m3MEAL = null, 
			string m3CSCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("EMNO", m3EMNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADID", m3ADID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
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
			if (!string.IsNullOrWhiteSpace(m3ADVI))
				request.WithQueryParameter("ADVI", m3ADVI.Trim());
			if (m3EALO.HasValue)
				request.WithQueryParameter("EALO", m3EALO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RONO))
				request.WithQueryParameter("RONO", m3RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
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
		/// Name DelEmployee
		/// Description Delete Employee
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FCOM">From Company (Required)</param>
		/// <param name="m3TCOM">To Company (Required)</param>
		/// <param name="m3FDIV">From Division (Required)</param>
		/// <param name="m3TDIV">To Division (Required)</param>
		/// <param name="m3FEMN">From Employee (Required)</param>
		/// <param name="m3TEMN">To Employee (Required)</param>
		/// <param name="m3EEDT">Resignation date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelEmployeeResponse></returns>
		/// <exception cref="M3Exception<DelEmployeeResponse>"></exception>
		public async Task<M3Response<DelEmployeeResponse>> DelEmployee(
			int m3FCOM, 
			int m3TCOM, 
			string m3FDIV, 
			string m3TDIV, 
			string m3FEMN, 
			string m3TEMN, 
			DateTime m3EEDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelEmployee",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FDIV))
				throw new ArgumentNullException(nameof(m3FDIV));
			if (string.IsNullOrWhiteSpace(m3TDIV))
				throw new ArgumentNullException(nameof(m3TDIV));
			if (string.IsNullOrWhiteSpace(m3FEMN))
				throw new ArgumentNullException(nameof(m3FEMN));
			if (string.IsNullOrWhiteSpace(m3TEMN))
				throw new ArgumentNullException(nameof(m3TEMN));

			// Set mandatory parameters
			request
				.WithQueryParameter("FCOM", m3FCOM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TCOM", m3TCOM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FDIV", m3FDIV.Trim())
				.WithQueryParameter("TDIV", m3TDIV.Trim())
				.WithQueryParameter("FEMN", m3FEMN.Trim())
				.WithQueryParameter("TEMN", m3TEMN.Trim())
				.WithQueryParameter("EEDT", m3EEDT.ToM3String());

			// Execute the request
			var result = await Execute<DelEmployeeResponse>(
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
		/// Name DelEmployeeS3
		/// Description Delete Employee S3
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3EEDT">Termination date (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelEmployeeS3Response></returns>
		/// <exception cref="M3Exception<DelEmployeeS3Response>"></exception>
		public async Task<M3Response<DelEmployeeS3Response>> DelEmployeeS3(
			int m3CONO, 
			string m3EMNO, 
			DateTime m3EEDT, 
			string m3DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelEmployeeS3",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("EMNO", m3EMNO.Trim())
				.WithQueryParameter("EEDT", m3EEDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<DelEmployeeS3Response>(
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
		/// Name DltAddress
		/// Description DltAddress
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAddress(
			string m3EMNO, 
			int m3ADRT, 
			string m3ADID, 
			DateTime? m3STDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("EMNO", m3EMNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADID", m3ADID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());

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
		/// Name GetAddress
		/// Description GetAddress
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3ADID">Address number (Required)</param>
		/// <param name="m3STDT">Start date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			string m3EMNO, 
			int m3ADRT, 
			string m3ADID, 
			DateTime m3STDT, 
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
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("EMNO", m3EMNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADID", m3ADID.Trim())
				.WithQueryParameter("STDT", m3STDT.ToM3String());

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
		/// Name LstAddress
		/// Description LstAddress
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAddressResponse></returns>
		/// <exception cref="M3Exception<LstAddressResponse>"></exception>
		public async Task<M3Response<LstAddressResponse>> LstAddress(
			string m3EMNO = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			DateTime? m3STDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAddress",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAddressResponse>(
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
		/// Name LstEmployee
		/// Description List employees
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FCOM">From company (Required)</param>
		/// <param name="m3TCOM">To company (Required)</param>
		/// <param name="m3FDIV">From division</param>
		/// <param name="m3TDIV">To division</param>
		/// <param name="m3FEMN">From employee</param>
		/// <param name="m3TEMN">To employee</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEmployeeResponse></returns>
		/// <exception cref="M3Exception<LstEmployeeResponse>"></exception>
		public async Task<M3Response<LstEmployeeResponse>> LstEmployee(
			int m3FCOM, 
			int m3TCOM, 
			string m3FDIV = null, 
			string m3TDIV = null, 
			string m3FEMN = null, 
			string m3TEMN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstEmployee",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("FCOM", m3FCOM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TCOM", m3TCOM.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FDIV))
				request.WithQueryParameter("FDIV", m3FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDIV))
				request.WithQueryParameter("TDIV", m3TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FEMN))
				request.WithQueryParameter("FEMN", m3FEMN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEMN))
				request.WithQueryParameter("TEMN", m3TEMN.Trim());

			// Execute the request
			var result = await Execute<LstEmployeeResponse>(
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
		/// Name SelRelations
		/// Description Select employees relationships with roles
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FDIV">From division</param>
		/// <param name="m3TDIV">To division</param>
		/// <param name="m3PLTP">Resource type</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelRelationsResponse></returns>
		/// <exception cref="M3Exception<SelRelationsResponse>"></exception>
		public async Task<M3Response<SelRelationsResponse>> SelRelations(
			int? m3CONO = null, 
			string m3FDIV = null, 
			string m3TDIV = null, 
			string m3PLTP = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelRelations",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDIV))
				request.WithQueryParameter("FDIV", m3FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDIV))
				request.WithQueryParameter("TDIV", m3TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLTP))
				request.WithQueryParameter("PLTP", m3PLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Execute the request
			var result = await Execute<SelRelationsResponse>(
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
		/// Name SelUserID
		/// Description List employees by User ID
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelUserIDResponse></returns>
		/// <exception cref="M3Exception<SelUserIDResponse>"></exception>
		public async Task<M3Response<SelUserIDResponse>> SelUserID(
			string m3DIVI = null, 
			string m3USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelUserID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());

			// Execute the request
			var result = await Execute<SelUserIDResponse>(
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
		/// Name Select
		/// Description Select employees
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FDIV">From division (Required)</param>
		/// <param name="m3TDIV">To division (Required)</param>
		/// <param name="m3PLTP">Resource type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3FDIV, 
			string m3TDIV, 
			string m3PLTP, 
			int? m3CONO = null, 
			string m3WHGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Select",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FDIV))
				throw new ArgumentNullException(nameof(m3FDIV));
			if (string.IsNullOrWhiteSpace(m3TDIV))
				throw new ArgumentNullException(nameof(m3TDIV));
			if (string.IsNullOrWhiteSpace(m3PLTP))
				throw new ArgumentNullException(nameof(m3PLTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("FDIV", m3FDIV.Trim())
				.WithQueryParameter("TDIV", m3TDIV.Trim())
				.WithQueryParameter("PLTP", m3PLTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name UpdBasicData
		/// Description Update basic employee data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3EMNM">Name</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3ACEM">Active employee</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3WOSC">Work schedule</param>
		/// <param name="m3WODT">Work schedule from date</param>
		/// <param name="m3SWSC">Start week - work schedule</param>
		/// <param name="m3CANO">Card number</param>
		/// <param name="m3PNCO">PIN code</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3IPHN">Internal telephone number</param>
		/// <param name="m3CAPH">Cell telephone number</param>
		/// <param name="m3MXTM">Used in Time & Attendance</param>
		/// <param name="m3MXSO">Used in Service & Rental</param>
		/// <param name="m3MXTA">Used in Time Accounting</param>
		/// <param name="m3MXPM">Used in Manufactoring Order Processing</param>
		/// <param name="m3MXMO">Used in Maintenence</param>
		/// <param name="m3EBDT">Employment date</param>
		/// <param name="m3EEDT">Termination date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBasicData(
			string m3DIVI, 
			string m3EMNO, 
			int? m3CONO = null, 
			string m3EMNM = null, 
			string m3USID = null, 
			int? m3ACEM = null, 
			string m3FACI = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			int? m3WOSC = null, 
			DateTime? m3WODT = null, 
			int? m3SWSC = null, 
			long? m3CANO = null, 
			string m3PNCO = null, 
			string m3PHNO = null, 
			string m3IPHN = null, 
			string m3CAPH = null, 
			int? m3MXTM = null, 
			int? m3MXSO = null, 
			int? m3MXTA = null, 
			int? m3MXPM = null, 
			int? m3MXMO = null, 
			DateTime? m3EBDT = null, 
			DateTime? m3EEDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("EMNO", m3EMNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNM))
				request.WithQueryParameter("EMNM", m3EMNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (m3ACEM.HasValue)
				request.WithQueryParameter("ACEM", m3ACEM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3WOSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WODT.HasValue)
				request.WithQueryParameter("WODT", m3WODT.Value.ToM3String());
			if (m3SWSC.HasValue)
				request.WithQueryParameter("SWSC", m3SWSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CANO.HasValue)
				request.WithQueryParameter("CANO", m3CANO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PNCO))
				request.WithQueryParameter("PNCO", m3PNCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3IPHN))
				request.WithQueryParameter("IPHN", m3IPHN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAPH))
				request.WithQueryParameter("CAPH", m3CAPH.Trim());
			if (m3MXTM.HasValue)
				request.WithQueryParameter("MXTM", m3MXTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXSO.HasValue)
				request.WithQueryParameter("MXSO", m3MXSO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXTA.HasValue)
				request.WithQueryParameter("MXTA", m3MXTA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXPM.HasValue)
				request.WithQueryParameter("MXPM", m3MXPM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXMO.HasValue)
				request.WithQueryParameter("MXMO", m3MXMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EBDT.HasValue)
				request.WithQueryParameter("EBDT", m3EBDT.Value.ToM3String());
			if (m3EEDT.HasValue)
				request.WithQueryParameter("EEDT", m3EEDT.Value.ToM3String());

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
		/// Name UpdServiceOrder
		/// Description Update Service Order data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TNL2">Short name</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3SPHO">Hourly price</param>
		/// <param name="m3CUCS">Currency - sales price</param>
		/// <param name="m3CPHO">Hourly price</param>
		/// <param name="m3RECM">Application message recipient</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdServiceOrder(
			string m3DIVI, 
			string m3EMNO, 
			int? m3CONO = null, 
			string m3TNL2 = null, 
			string m3TECH = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3SRES = null, 
			decimal? m3SPHO = null, 
			string m3CUCS = null, 
			decimal? m3CPHO = null, 
			int? m3RECM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdServiceOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("EMNO", m3EMNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TNL2))
				request.WithQueryParameter("TNL2", m3TNL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (m3SPHO.HasValue)
				request.WithQueryParameter("SPHO", m3SPHO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCS))
				request.WithQueryParameter("CUCS", m3CUCS.Trim());
			if (m3CPHO.HasValue)
				request.WithQueryParameter("CPHO", m3CPHO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RECM.HasValue)
				request.WithQueryParameter("RECM", m3RECM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdTimeAcc
		/// Description Update Time Accounting data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3EMID">Employee identity</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3PCAT">Employee group - Time Accounting</param>
		/// <param name="m3APID">Approval ID</param>
		/// <param name="m3DSSU">Display total</param>
		/// <param name="m3DSSC">Display schedule</param>
		/// <param name="m3DSWD">View display</param>
		/// <param name="m3DSWE">View entry</param>
		/// <param name="m3TACC">Cost center</param>
		/// <param name="m3FRT1">User-defined field 1</param>
		/// <param name="m3FRT2">User-defined field 2</param>
		/// <param name="m3FRT3">User-defined field 3</param>
		/// <param name="m3FRT4">User-defined field 4</param>
		/// <param name="m3FRT5">User-defined field 5</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTimeAcc(
			string m3DIVI, 
			string m3EMNO, 
			int? m3CONO = null, 
			string m3EMID = null, 
			string m3TX15 = null, 
			string m3PCAT = null, 
			string m3APID = null, 
			int? m3DSSU = null, 
			int? m3DSSC = null, 
			int? m3DSWD = null, 
			int? m3DSWE = null, 
			string m3TACC = null, 
			string m3FRT1 = null, 
			string m3FRT2 = null, 
			string m3FRT3 = null, 
			string m3FRT4 = null, 
			string m3FRT5 = null, 
			string m3ACRF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTimeAcc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("EMNO", m3EMNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMID))
				request.WithQueryParameter("EMID", m3EMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3PCAT))
				request.WithQueryParameter("PCAT", m3PCAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3APID))
				request.WithQueryParameter("APID", m3APID.Trim());
			if (m3DSSU.HasValue)
				request.WithQueryParameter("DSSU", m3DSSU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSSC.HasValue)
				request.WithQueryParameter("DSSC", m3DSSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSWD.HasValue)
				request.WithQueryParameter("DSWD", m3DSWD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSWE.HasValue)
				request.WithQueryParameter("DSWE", m3DSWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TACC))
				request.WithQueryParameter("TACC", m3TACC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRT1))
				request.WithQueryParameter("FRT1", m3FRT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRT2))
				request.WithQueryParameter("FRT2", m3FRT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRT3))
				request.WithQueryParameter("FRT3", m3FRT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRT4))
				request.WithQueryParameter("FRT4", m3FRT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRT5))
				request.WithQueryParameter("FRT5", m3FRT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());

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
		/// Name UpdTimeAtt
		/// Description Update Time & Attendance data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3EMNO">Employee number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TMGR">Employee group</param>
		/// <param name="m3SUSD">Operation include Time & Attendance</param>
		/// <param name="m3OTCD">Calculation method - overtime</param>
		/// <param name="m3MNOT">Minimum overtime per day</param>
		/// <param name="m3FLAW">Calculation method - flextime</param>
		/// <param name="m3FLTP">Time type for flextime</param>
		/// <param name="m3TTPE">Time type</param>
		/// <param name="m3TMRP">Time type actual attendance</param>
		/// <param name="m3RMTP">Time type missing time</param>
		/// <param name="m3FXWD">Varible workday</param>
		/// <param name="m3TVWD">Time limit variable workday</param>
		/// <param name="m3AUTT">Automatic generation time type</param>
		/// <param name="m3TMEM">Number of minutes</param>
		/// <param name="m3TPOT">Time type run time</param>
		/// <param name="m3TPST">Time type setup time</param>
		/// <param name="m3PWPY">Piece rate paid</param>
		/// <param name="m3TMCC">Cost center</param>
		/// <param name="m3CTOD">calculated to date</param>
		/// <param name="m3TTPD">Latest transfer to date history/pay</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTimeAtt(
			string m3DIVI, 
			string m3EMNO, 
			int? m3CONO = null, 
			string m3TMGR = null, 
			int? m3SUSD = null, 
			int? m3OTCD = null, 
			int? m3MNOT = null, 
			int? m3FLAW = null, 
			string m3FLTP = null, 
			string m3TTPE = null, 
			string m3TMRP = null, 
			string m3RMTP = null, 
			int? m3FXWD = null, 
			int? m3TVWD = null, 
			string m3AUTT = null, 
			int? m3TMEM = null, 
			string m3TPOT = null, 
			string m3TPST = null, 
			int? m3PWPY = null, 
			string m3TMCC = null, 
			DateTime? m3CTOD = null, 
			DateTime? m3TTPD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTimeAtt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3EMNO))
				throw new ArgumentNullException(nameof(m3EMNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("EMNO", m3EMNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TMGR))
				request.WithQueryParameter("TMGR", m3TMGR.Trim());
			if (m3SUSD.HasValue)
				request.WithQueryParameter("SUSD", m3SUSD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OTCD.HasValue)
				request.WithQueryParameter("OTCD", m3OTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MNOT.HasValue)
				request.WithQueryParameter("MNOT", m3MNOT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLAW.HasValue)
				request.WithQueryParameter("FLAW", m3FLAW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLTP))
				request.WithQueryParameter("FLTP", m3FLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TTPE))
				request.WithQueryParameter("TTPE", m3TTPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TMRP))
				request.WithQueryParameter("TMRP", m3TMRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RMTP))
				request.WithQueryParameter("RMTP", m3RMTP.Trim());
			if (m3FXWD.HasValue)
				request.WithQueryParameter("FXWD", m3FXWD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TVWD.HasValue)
				request.WithQueryParameter("TVWD", m3TVWD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AUTT))
				request.WithQueryParameter("AUTT", m3AUTT.Trim());
			if (m3TMEM.HasValue)
				request.WithQueryParameter("TMEM", m3TMEM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TPOT))
				request.WithQueryParameter("TPOT", m3TPOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPST))
				request.WithQueryParameter("TPST", m3TPST.Trim());
			if (m3PWPY.HasValue)
				request.WithQueryParameter("PWPY", m3PWPY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TMCC))
				request.WithQueryParameter("TMCC", m3TMCC.Trim());
			if (m3CTOD.HasValue)
				request.WithQueryParameter("CTOD", m3CTOD.Value.ToM3String());
			if (m3TTPD.HasValue)
				request.WithQueryParameter("TTPD", m3TTPD.Value.ToM3String());

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
