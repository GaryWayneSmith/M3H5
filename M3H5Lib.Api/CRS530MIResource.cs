/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_CUNM">Name</param>
		/// <param name="m3_CUA1">Address line 1</param>
		/// <param name="m3_CUA2">Address line 2</param>
		/// <param name="m3_CUA3">Address line 3</param>
		/// <param name="m3_CUA4">Address line 4</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_ADVI">Ship-via address</param>
		/// <param name="m3_EALO">EAN location code</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_RONO">Run</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TEL2">Terms text</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_LSID">User</param>
		/// <param name="m3_LSAD">Address</param>
		/// <param name="m3_MEAL">Valid media</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_ULZO">Unloading zone</param>
		/// <param name="m3_CESA">Marketing ID - M3 SMS</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="m3_HAFE">Harbor or airport</param>
		/// <param name="m3_EDE2">Place</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_GEOX">Geographic code X</param>
		/// <param name="m3_GEOY">Geographic code Y</param>
		/// <param name="m3_GEOZ">Geographic code  Z</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_SPLE">Standard point location code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddress(
			string m3_EMNO, 
			int m3_ADRT, 
			string m3_ADID = null, 
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_PONO = null, 
			string m3_ADVI = null, 
			decimal? m3_EALO = null, 
			string m3_ECAR = null, 
			string m3_RONO = null, 
			string m3_DEPT = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEL2 = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_LSID = null, 
			string m3_LSAD = null, 
			string m3_MEAL = null, 
			string m3_CSCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("EMNO", m3_EMNO.Trim())
				.WithQueryParameter("ADRT", m3_ADRT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_ADVI))
				request.WithQueryParameter("ADVI", m3_ADVI.Trim());
			if (m3_EALO.HasValue)
				request.WithQueryParameter("EALO", m3_EALO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RONO))
				request.WithQueryParameter("RONO", m3_RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
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
		/// Name AddEmployee
		/// Description Add employee record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_EMNM">Name</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_ACEM">Active employee</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_WOSC">Work schedule</param>
		/// <param name="m3_WODT">Work schedule from date</param>
		/// <param name="m3_SWSC">Start week - schedule</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_PNCO">PIN code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_IPHN">Internal telephone number</param>
		/// <param name="m3_CAPH">Cell telephone number</param>
		/// <param name="m3_MXTM">Used in Time & Attendance</param>
		/// <param name="m3_MXSO">Used in Service and Rental</param>
		/// <param name="m3_MXTA">Used in Time Accounting</param>
		/// <param name="m3_MXPM">Used in Manufacturing Order Processing</param>
		/// <param name="m3_MXMO">Used in Maintenence</param>
		/// <param name="m3_EMTE">Employee template</param>
		/// <param name="m3_EBDT">Employment date</param>
		/// <param name="m3_EEDT">Termination date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEmployee(
			string m3_DIVI, 
			string m3_EMNO, 
			int? m3_CONO = null, 
			string m3_EMNM = null, 
			string m3_USID = null, 
			int? m3_ACEM = null, 
			string m3_FACI = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			int? m3_WOSC = null, 
			DateTime? m3_WODT = null, 
			int? m3_SWSC = null, 
			long? m3_CANO = null, 
			string m3_PNCO = null, 
			string m3_PHNO = null, 
			string m3_IPHN = null, 
			string m3_CAPH = null, 
			int? m3_MXTM = null, 
			int? m3_MXSO = null, 
			int? m3_MXTA = null, 
			int? m3_MXPM = null, 
			int? m3_MXMO = null, 
			string m3_EMTE = null, 
			DateTime? m3_EBDT = null, 
			DateTime? m3_EEDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("EMNO", m3_EMNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNM))
				request.WithQueryParameter("EMNM", m3_EMNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (m3_ACEM.HasValue)
				request.WithQueryParameter("ACEM", m3_ACEM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3_WOSC.Value.ToString());
			if (m3_WODT.HasValue)
				request.WithQueryParameter("WODT", m3_WODT.Value.ToM3String());
			if (m3_SWSC.HasValue)
				request.WithQueryParameter("SWSC", m3_SWSC.Value.ToString());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PNCO))
				request.WithQueryParameter("PNCO", m3_PNCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IPHN))
				request.WithQueryParameter("IPHN", m3_IPHN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAPH))
				request.WithQueryParameter("CAPH", m3_CAPH.Trim());
			if (m3_MXTM.HasValue)
				request.WithQueryParameter("MXTM", m3_MXTM.Value.ToString());
			if (m3_MXSO.HasValue)
				request.WithQueryParameter("MXSO", m3_MXSO.Value.ToString());
			if (m3_MXTA.HasValue)
				request.WithQueryParameter("MXTA", m3_MXTA.Value.ToString());
			if (m3_MXPM.HasValue)
				request.WithQueryParameter("MXPM", m3_MXPM.Value.ToString());
			if (m3_MXMO.HasValue)
				request.WithQueryParameter("MXMO", m3_MXMO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMTE))
				request.WithQueryParameter("EMTE", m3_EMTE.Trim());
			if (m3_EBDT.HasValue)
				request.WithQueryParameter("EBDT", m3_EBDT.Value.ToM3String());
			if (m3_EEDT.HasValue)
				request.WithQueryParameter("EEDT", m3_EEDT.Value.ToM3String());

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
		/// Description ChgAddress
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_CUNM">Name</param>
		/// <param name="m3_CUA1">Address line 1</param>
		/// <param name="m3_CUA2">Address line 2</param>
		/// <param name="m3_CUA3">Address line 3</param>
		/// <param name="m3_CUA4">Address line 4</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_ADVI">Ship-via address</param>
		/// <param name="m3_EALO">EAN location code</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_RONO">Run</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TEL2">Terms text</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_LSID">User</param>
		/// <param name="m3_LSAD">Address</param>
		/// <param name="m3_MEAL">Valid media</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_EDES">Place</param>
		/// <param name="m3_ROUT">Route</param>
		/// <param name="m3_RODN">Route departure</param>
		/// <param name="m3_ULZO">Unloading zone</param>
		/// <param name="m3_CESA">Marketing ID - M3 SMS</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="m3_HAFE">Harbor or airport</param>
		/// <param name="m3_EDE2">Place</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_GEOX">Geographic code X</param>
		/// <param name="m3_GEOY">Geographic code Y</param>
		/// <param name="m3_GEOZ">Geographic code  Z</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_SPLE">Standard point location code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAddress(
			string m3_EMNO, 
			int m3_ADRT, 
			string m3_ADID, 
			DateTime? m3_STDT = null, 
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_PONO = null, 
			string m3_ADVI = null, 
			decimal? m3_EALO = null, 
			string m3_ECAR = null, 
			string m3_RONO = null, 
			string m3_DEPT = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEL2 = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_LSID = null, 
			string m3_LSAD = null, 
			string m3_MEAL = null, 
			string m3_CSCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("EMNO", m3_EMNO.Trim())
				.WithQueryParameter("ADRT", m3_ADRT.ToString())
				.WithQueryParameter("ADID", m3_ADID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
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
			if (!string.IsNullOrWhiteSpace(m3_ADVI))
				request.WithQueryParameter("ADVI", m3_ADVI.Trim());
			if (m3_EALO.HasValue)
				request.WithQueryParameter("EALO", m3_EALO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RONO))
				request.WithQueryParameter("RONO", m3_RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
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
		/// Name DelEmployee
		/// Description Delete Employee
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FCOM">From Company (Required)</param>
		/// <param name="m3_TCOM">To Company (Required)</param>
		/// <param name="m3_FDIV">From Division (Required)</param>
		/// <param name="m3_TDIV">To Division (Required)</param>
		/// <param name="m3_FEMN">From Employee (Required)</param>
		/// <param name="m3_TEMN">To Employee (Required)</param>
		/// <param name="m3_EEDT">Resignation date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelEmployeeResponse></returns>
		/// <exception cref="M3Exception<DelEmployeeResponse>"></exception>
		public async Task<M3Response<DelEmployeeResponse>> DelEmployee(
			int m3_FCOM, 
			int m3_TCOM, 
			string m3_FDIV, 
			string m3_TDIV, 
			string m3_FEMN, 
			string m3_TEMN, 
			DateTime m3_EEDT, 
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
			if (string.IsNullOrWhiteSpace(m3_FDIV))
				throw new ArgumentNullException("m3_FDIV");
			if (string.IsNullOrWhiteSpace(m3_TDIV))
				throw new ArgumentNullException("m3_TDIV");
			if (string.IsNullOrWhiteSpace(m3_FEMN))
				throw new ArgumentNullException("m3_FEMN");
			if (string.IsNullOrWhiteSpace(m3_TEMN))
				throw new ArgumentNullException("m3_TEMN");

			// Set mandatory parameters
			request
				.WithQueryParameter("FCOM", m3_FCOM.ToString())
				.WithQueryParameter("TCOM", m3_TCOM.ToString())
				.WithQueryParameter("FDIV", m3_FDIV.Trim())
				.WithQueryParameter("TDIV", m3_TDIV.Trim())
				.WithQueryParameter("FEMN", m3_FEMN.Trim())
				.WithQueryParameter("TEMN", m3_TEMN.Trim())
				.WithQueryParameter("EEDT", m3_EEDT.ToM3String());

			// Execute the request
			var result = await Execute<DelEmployeeResponse>(
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
		/// Name DelEmployeeS3
		/// Description Delete Employee S3
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_EEDT">Termination date (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelEmployeeS3Response></returns>
		/// <exception cref="M3Exception<DelEmployeeS3Response>"></exception>
		public async Task<M3Response<DelEmployeeS3Response>> DelEmployeeS3(
			int m3_CONO, 
			string m3_EMNO, 
			DateTime m3_EEDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelEmployeeS3",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("EMNO", m3_EMNO.Trim())
				.WithQueryParameter("EEDT", m3_EEDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<DelEmployeeS3Response>(
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
		/// Name DltAddress
		/// Description DltAddress
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAddress(
			string m3_EMNO, 
			int m3_ADRT, 
			string m3_ADID, 
			DateTime? m3_STDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("EMNO", m3_EMNO.Trim())
				.WithQueryParameter("ADRT", m3_ADRT.ToString())
				.WithQueryParameter("ADID", m3_ADID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());

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
		/// Name GetAddress
		/// Description GetAddress
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_ADID">Address number (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			string m3_EMNO, 
			int m3_ADRT, 
			string m3_ADID, 
			DateTime m3_STDT, 
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
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");
			if (string.IsNullOrWhiteSpace(m3_ADID))
				throw new ArgumentNullException("m3_ADID");

			// Set mandatory parameters
			request
				.WithQueryParameter("EMNO", m3_EMNO.Trim())
				.WithQueryParameter("ADRT", m3_ADRT.ToString())
				.WithQueryParameter("ADID", m3_ADID.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String());

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
		/// Name LstAddress
		/// Description LstAddress
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAddressResponse></returns>
		/// <exception cref="M3Exception<LstAddressResponse>"></exception>
		public async Task<M3Response<LstAddressResponse>> LstAddress(
			string m3_EMNO = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			DateTime? m3_STDT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstAddressResponse>(
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
		/// Name LstEmployee
		/// Description List employees
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FCOM">From company (Required)</param>
		/// <param name="m3_TCOM">To company (Required)</param>
		/// <param name="m3_FDIV">From division</param>
		/// <param name="m3_TDIV">To division</param>
		/// <param name="m3_FEMN">From employee</param>
		/// <param name="m3_TEMN">To employee</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEmployeeResponse></returns>
		/// <exception cref="M3Exception<LstEmployeeResponse>"></exception>
		public async Task<M3Response<LstEmployeeResponse>> LstEmployee(
			int m3_FCOM, 
			int m3_TCOM, 
			string m3_FDIV = null, 
			string m3_TDIV = null, 
			string m3_FEMN = null, 
			string m3_TEMN = null, 
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
				.WithQueryParameter("FCOM", m3_FCOM.ToString())
				.WithQueryParameter("TCOM", m3_TCOM.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FDIV))
				request.WithQueryParameter("FDIV", m3_FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDIV))
				request.WithQueryParameter("TDIV", m3_TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FEMN))
				request.WithQueryParameter("FEMN", m3_FEMN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEMN))
				request.WithQueryParameter("TEMN", m3_TEMN.Trim());

			// Execute the request
			var result = await Execute<LstEmployeeResponse>(
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
		/// Name SelRelations
		/// Description Select employees relationships with roles
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FDIV">From division</param>
		/// <param name="m3_TDIV">To division</param>
		/// <param name="m3_PLTP">Resource type</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelRelationsResponse></returns>
		/// <exception cref="M3Exception<SelRelationsResponse>"></exception>
		public async Task<M3Response<SelRelationsResponse>> SelRelations(
			int? m3_CONO = null, 
			string m3_FDIV = null, 
			string m3_TDIV = null, 
			string m3_PLTP = null, 
			string m3_WHGR = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDIV))
				request.WithQueryParameter("FDIV", m3_FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDIV))
				request.WithQueryParameter("TDIV", m3_TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLTP))
				request.WithQueryParameter("PLTP", m3_PLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());

			// Execute the request
			var result = await Execute<SelRelationsResponse>(
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
		/// Name SelUserID
		/// Description List employees by User ID
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelUserIDResponse></returns>
		/// <exception cref="M3Exception<SelUserIDResponse>"></exception>
		public async Task<M3Response<SelUserIDResponse>> SelUserID(
			string m3_DIVI = null, 
			string m3_USID = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<SelUserIDResponse>(
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
		/// Name Select
		/// Description Select employees
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FDIV">From division (Required)</param>
		/// <param name="m3_TDIV">To division (Required)</param>
		/// <param name="m3_PLTP">Resource type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3_FDIV, 
			string m3_TDIV, 
			string m3_PLTP, 
			int? m3_CONO = null, 
			string m3_WHGR = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FDIV))
				throw new ArgumentNullException("m3_FDIV");
			if (string.IsNullOrWhiteSpace(m3_TDIV))
				throw new ArgumentNullException("m3_TDIV");
			if (string.IsNullOrWhiteSpace(m3_PLTP))
				throw new ArgumentNullException("m3_PLTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("FDIV", m3_FDIV.Trim())
				.WithQueryParameter("TDIV", m3_TDIV.Trim())
				.WithQueryParameter("PLTP", m3_PLTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name UpdBasicData
		/// Description Update basic employee data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_EMNM">Name</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_ACEM">Active employee</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_WOSC">Work schedule</param>
		/// <param name="m3_WODT">Work schedule from date</param>
		/// <param name="m3_SWSC">Start week - work schedule</param>
		/// <param name="m3_CANO">Card number</param>
		/// <param name="m3_PNCO">PIN code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_IPHN">Internal telephone number</param>
		/// <param name="m3_CAPH">Cell telephone number</param>
		/// <param name="m3_MXTM">Used in Time & Attendance</param>
		/// <param name="m3_MXSO">Used in Service & Rental</param>
		/// <param name="m3_MXTA">Used in Time Accounting</param>
		/// <param name="m3_MXPM">Used in Manufactoring Order Processing</param>
		/// <param name="m3_MXMO">Used in Maintenence</param>
		/// <param name="m3_EBDT">Employment date</param>
		/// <param name="m3_EEDT">Termination date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBasicData(
			string m3_DIVI, 
			string m3_EMNO, 
			int? m3_CONO = null, 
			string m3_EMNM = null, 
			string m3_USID = null, 
			int? m3_ACEM = null, 
			string m3_FACI = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			int? m3_WOSC = null, 
			DateTime? m3_WODT = null, 
			int? m3_SWSC = null, 
			long? m3_CANO = null, 
			string m3_PNCO = null, 
			string m3_PHNO = null, 
			string m3_IPHN = null, 
			string m3_CAPH = null, 
			int? m3_MXTM = null, 
			int? m3_MXSO = null, 
			int? m3_MXTA = null, 
			int? m3_MXPM = null, 
			int? m3_MXMO = null, 
			DateTime? m3_EBDT = null, 
			DateTime? m3_EEDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("EMNO", m3_EMNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNM))
				request.WithQueryParameter("EMNM", m3_EMNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (m3_ACEM.HasValue)
				request.WithQueryParameter("ACEM", m3_ACEM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3_WOSC.Value.ToString());
			if (m3_WODT.HasValue)
				request.WithQueryParameter("WODT", m3_WODT.Value.ToM3String());
			if (m3_SWSC.HasValue)
				request.WithQueryParameter("SWSC", m3_SWSC.Value.ToString());
			if (m3_CANO.HasValue)
				request.WithQueryParameter("CANO", m3_CANO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PNCO))
				request.WithQueryParameter("PNCO", m3_PNCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IPHN))
				request.WithQueryParameter("IPHN", m3_IPHN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAPH))
				request.WithQueryParameter("CAPH", m3_CAPH.Trim());
			if (m3_MXTM.HasValue)
				request.WithQueryParameter("MXTM", m3_MXTM.Value.ToString());
			if (m3_MXSO.HasValue)
				request.WithQueryParameter("MXSO", m3_MXSO.Value.ToString());
			if (m3_MXTA.HasValue)
				request.WithQueryParameter("MXTA", m3_MXTA.Value.ToString());
			if (m3_MXPM.HasValue)
				request.WithQueryParameter("MXPM", m3_MXPM.Value.ToString());
			if (m3_MXMO.HasValue)
				request.WithQueryParameter("MXMO", m3_MXMO.Value.ToString());
			if (m3_EBDT.HasValue)
				request.WithQueryParameter("EBDT", m3_EBDT.Value.ToM3String());
			if (m3_EEDT.HasValue)
				request.WithQueryParameter("EEDT", m3_EEDT.Value.ToM3String());

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
		/// Name UpdServiceOrder
		/// Description Update Service Order data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TNL2">Short name</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_SPHO">Hourly price</param>
		/// <param name="m3_CUCS">Currency - sales price</param>
		/// <param name="m3_CPHO">Hourly price</param>
		/// <param name="m3_RECM">Application message recipient</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdServiceOrder(
			string m3_DIVI, 
			string m3_EMNO, 
			int? m3_CONO = null, 
			string m3_TNL2 = null, 
			string m3_TECH = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_SRES = null, 
			decimal? m3_SPHO = null, 
			string m3_CUCS = null, 
			decimal? m3_CPHO = null, 
			int? m3_RECM = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("EMNO", m3_EMNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TNL2))
				request.WithQueryParameter("TNL2", m3_TNL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (m3_SPHO.HasValue)
				request.WithQueryParameter("SPHO", m3_SPHO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCS))
				request.WithQueryParameter("CUCS", m3_CUCS.Trim());
			if (m3_CPHO.HasValue)
				request.WithQueryParameter("CPHO", m3_CPHO.Value.ToString());
			if (m3_RECM.HasValue)
				request.WithQueryParameter("RECM", m3_RECM.Value.ToString());

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
		/// Name UpdTimeAcc
		/// Description Update Time Accounting data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_EMID">Employee identity</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_PCAT">Employee group - Time Accounting</param>
		/// <param name="m3_APID">Approval ID</param>
		/// <param name="m3_DSSU">Display total</param>
		/// <param name="m3_DSSC">Display schedule</param>
		/// <param name="m3_DSWD">View display</param>
		/// <param name="m3_DSWE">View entry</param>
		/// <param name="m3_TACC">Cost center</param>
		/// <param name="m3_FRT1">User-defined field 1</param>
		/// <param name="m3_FRT2">User-defined field 2</param>
		/// <param name="m3_FRT3">User-defined field 3</param>
		/// <param name="m3_FRT4">User-defined field 4</param>
		/// <param name="m3_FRT5">User-defined field 5</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTimeAcc(
			string m3_DIVI, 
			string m3_EMNO, 
			int? m3_CONO = null, 
			string m3_EMID = null, 
			string m3_TX15 = null, 
			string m3_PCAT = null, 
			string m3_APID = null, 
			int? m3_DSSU = null, 
			int? m3_DSSC = null, 
			int? m3_DSWD = null, 
			int? m3_DSWE = null, 
			string m3_TACC = null, 
			string m3_FRT1 = null, 
			string m3_FRT2 = null, 
			string m3_FRT3 = null, 
			string m3_FRT4 = null, 
			string m3_FRT5 = null, 
			string m3_ACRF = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("EMNO", m3_EMNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMID))
				request.WithQueryParameter("EMID", m3_EMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PCAT))
				request.WithQueryParameter("PCAT", m3_PCAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APID))
				request.WithQueryParameter("APID", m3_APID.Trim());
			if (m3_DSSU.HasValue)
				request.WithQueryParameter("DSSU", m3_DSSU.Value.ToString());
			if (m3_DSSC.HasValue)
				request.WithQueryParameter("DSSC", m3_DSSC.Value.ToString());
			if (m3_DSWD.HasValue)
				request.WithQueryParameter("DSWD", m3_DSWD.Value.ToString());
			if (m3_DSWE.HasValue)
				request.WithQueryParameter("DSWE", m3_DSWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TACC))
				request.WithQueryParameter("TACC", m3_TACC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRT1))
				request.WithQueryParameter("FRT1", m3_FRT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRT2))
				request.WithQueryParameter("FRT2", m3_FRT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRT3))
				request.WithQueryParameter("FRT3", m3_FRT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRT4))
				request.WithQueryParameter("FRT4", m3_FRT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRT5))
				request.WithQueryParameter("FRT5", m3_FRT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());

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
		/// Name UpdTimeAtt
		/// Description Update Time & Attendance data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_EMNO">Employee number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TMGR">Employee group</param>
		/// <param name="m3_SUSD">Operation include Time & Attendance</param>
		/// <param name="m3_OTCD">Calculation method - overtime</param>
		/// <param name="m3_MNOT">Minimum overtime per day</param>
		/// <param name="m3_FLAW">Calculation method - flextime</param>
		/// <param name="m3_FLTP">Time type for flextime</param>
		/// <param name="m3_TTPE">Time type</param>
		/// <param name="m3_TMRP">Time type actual attendance</param>
		/// <param name="m3_RMTP">Time type missing time</param>
		/// <param name="m3_FXWD">Varible workday</param>
		/// <param name="m3_TVWD">Time limit variable workday</param>
		/// <param name="m3_AUTT">Automatic generation time type</param>
		/// <param name="m3_TMEM">Number of minutes</param>
		/// <param name="m3_TPOT">Time type run time</param>
		/// <param name="m3_TPST">Time type setup time</param>
		/// <param name="m3_PWPY">Piece rate paid</param>
		/// <param name="m3_TMCC">Cost center</param>
		/// <param name="m3_CTOD">calculated to date</param>
		/// <param name="m3_TTPD">Latest transfer to date history/pay</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTimeAtt(
			string m3_DIVI, 
			string m3_EMNO, 
			int? m3_CONO = null, 
			string m3_TMGR = null, 
			int? m3_SUSD = null, 
			int? m3_OTCD = null, 
			int? m3_MNOT = null, 
			int? m3_FLAW = null, 
			string m3_FLTP = null, 
			string m3_TTPE = null, 
			string m3_TMRP = null, 
			string m3_RMTP = null, 
			int? m3_FXWD = null, 
			int? m3_TVWD = null, 
			string m3_AUTT = null, 
			int? m3_TMEM = null, 
			string m3_TPOT = null, 
			string m3_TPST = null, 
			int? m3_PWPY = null, 
			string m3_TMCC = null, 
			DateTime? m3_CTOD = null, 
			DateTime? m3_TTPD = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_EMNO))
				throw new ArgumentNullException("m3_EMNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("EMNO", m3_EMNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TMGR))
				request.WithQueryParameter("TMGR", m3_TMGR.Trim());
			if (m3_SUSD.HasValue)
				request.WithQueryParameter("SUSD", m3_SUSD.Value.ToString());
			if (m3_OTCD.HasValue)
				request.WithQueryParameter("OTCD", m3_OTCD.Value.ToString());
			if (m3_MNOT.HasValue)
				request.WithQueryParameter("MNOT", m3_MNOT.Value.ToString());
			if (m3_FLAW.HasValue)
				request.WithQueryParameter("FLAW", m3_FLAW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLTP))
				request.WithQueryParameter("FLTP", m3_FLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TTPE))
				request.WithQueryParameter("TTPE", m3_TTPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TMRP))
				request.WithQueryParameter("TMRP", m3_TMRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RMTP))
				request.WithQueryParameter("RMTP", m3_RMTP.Trim());
			if (m3_FXWD.HasValue)
				request.WithQueryParameter("FXWD", m3_FXWD.Value.ToString());
			if (m3_TVWD.HasValue)
				request.WithQueryParameter("TVWD", m3_TVWD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AUTT))
				request.WithQueryParameter("AUTT", m3_AUTT.Trim());
			if (m3_TMEM.HasValue)
				request.WithQueryParameter("TMEM", m3_TMEM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TPOT))
				request.WithQueryParameter("TPOT", m3_TPOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPST))
				request.WithQueryParameter("TPST", m3_TPST.Trim());
			if (m3_PWPY.HasValue)
				request.WithQueryParameter("PWPY", m3_PWPY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TMCC))
				request.WithQueryParameter("TMCC", m3_TMCC.Trim());
			if (m3_CTOD.HasValue)
				request.WithQueryParameter("CTOD", m3_CTOD.Value.ToM3String());
			if (m3_TTPD.HasValue)
				request.WithQueryParameter("TTPD", m3_TTPD.Value.ToM3String());

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
