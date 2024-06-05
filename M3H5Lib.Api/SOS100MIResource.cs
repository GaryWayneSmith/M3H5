/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.SOS100MI;
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
	/// Name: SOS100MI
	/// Component Name: ServiceOrder
	/// Description: Service order interface
	/// Version Release: 5ea1
	///</summary>
	public partial class SOS100MIResource : M3BaseResourceEndpoint
	{
		public SOS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SOS100MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIndItem
		/// Description Add of individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUOW">Customer owner (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3TMPL">Template for indiviudual item</param>
		/// <param name="m3INNO">Individual item number</param>
		/// <param name="m3CUPL">Customer location</param>
		/// <param name="m3ADID">Address id</param>
		/// <param name="m3ISTS">Individual item status</param>
		/// <param name="m3INGR">Individual item group</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3INTY">Individual item type</param>
		/// <param name="m3MODE">Model</param>
		/// <param name="m3MODC">Model name</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3SRES">Service responsible</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3DEDA">Delivery date</param>
		/// <param name="m3REDA">Receipt date</param>
		/// <param name="m3INDA">Installation date</param>
		/// <param name="m3AGRS">Contract item - service</param>
		/// <param name="m3AGRR">Contract item - rental</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3NBID">Number series id</param>
		/// <param name="m3MLYR">Year model</param>
		/// <param name="m3AREA">Location description</param>
		/// <param name="m3GDT1">Warranty date sales</param>
		/// <param name="m3CUGA">General agent</param>
		/// <param name="m3GDT2">Warranty date supplier</param>
		/// <param name="m3PROD">Manufacturer</param>
		/// <param name="m3CUIC">Customer number at insurence company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3MINO">Main individual item number</param>
		/// <param name="m3CONS">Equipment</param>
		/// <param name="m3CFE1">User def 1</param>
		/// <param name="m3CFE2">User def 2</param>
		/// <param name="m3CFE3">User def 3</param>
		/// <param name="m3CFE4">User def 4</param>
		/// <param name="m3CFE5">User def 5</param>
		/// <param name="m3CFE6">User def 6</param>
		/// <param name="m3CFE7">User def 7</param>
		/// <param name="m3CFE8">User def 8</param>
		/// <param name="m3CFE9">User def 9</param>
		/// <param name="m3CFE0">User def 10</param>
		/// <param name="m3CFEA">User def 11</param>
		/// <param name="m3CFEB">User def 12</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3MFNO">Manufactoring order number</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3DDAT">Date disposed</param>
		/// <param name="m3TYPR">Type of prefix</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3LOCS">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddIndItemResponse></returns>
		/// <exception cref="M3Exception<AddIndItemResponse>"></exception>
		public async Task<M3Response<AddIndItemResponse>> AddIndItem(
			string m3CUOW, 
			int? m3CONO = null, 
			string m3TMPL = null, 
			string m3INNO = null, 
			string m3CUPL = null, 
			string m3ADID = null, 
			string m3ISTS = null, 
			string m3INGR = null, 
			string m3BANO = null, 
			string m3BRAN = null, 
			string m3INTY = null, 
			string m3MODE = null, 
			string m3MODC = null, 
			string m3TECH = null, 
			string m3SRES = null, 
			string m3ITGR = null, 
			DateTime? m3DEDA = null, 
			DateTime? m3REDA = null, 
			DateTime? m3INDA = null, 
			string m3AGRS = null, 
			string m3AGRR = null, 
			string m3DIVI = null, 
			string m3ITNO = null, 
			string m3NBID = null, 
			string m3MLYR = null, 
			string m3AREA = null, 
			DateTime? m3GDT1 = null, 
			string m3CUGA = null, 
			DateTime? m3GDT2 = null, 
			string m3PROD = null, 
			string m3CUIC = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3MINO = null, 
			string m3CONS = null, 
			string m3CFE1 = null, 
			decimal? m3CFE2 = null, 
			string m3CFE3 = null, 
			string m3CFE4 = null, 
			string m3CFE5 = null, 
			string m3CFE6 = null, 
			decimal? m3CFE7 = null, 
			string m3CFE8 = null, 
			string m3CFE9 = null, 
			string m3CFE0 = null, 
			string m3CFEA = null, 
			string m3CFEB = null, 
			string m3PUNO = null, 
			string m3PNLI = null, 
			string m3MFNO = null, 
			string m3RORN = null, 
			string m3RORC = null, 
			string m3RORL = null, 
			int? m3RORX = null, 
			DateTime? m3DDAT = null, 
			int? m3TYPR = null, 
			string m3SERI = null, 
			string m3LOCS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddIndItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUOW))
				throw new ArgumentNullException(nameof(m3CUOW));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUOW", m3CUOW.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TMPL))
				request.WithQueryParameter("TMPL", m3TMPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISTS))
				request.WithQueryParameter("ISTS", m3ISTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3INGR))
				request.WithQueryParameter("INGR", m3INGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3INTY))
				request.WithQueryParameter("INTY", m3INTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODE))
				request.WithQueryParameter("MODE", m3MODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODC))
				request.WithQueryParameter("MODC", m3MODC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (m3DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3DEDA.Value.ToM3String());
			if (m3REDA.HasValue)
				request.WithQueryParameter("REDA", m3REDA.Value.ToM3String());
			if (m3INDA.HasValue)
				request.WithQueryParameter("INDA", m3INDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3AGRS))
				request.WithQueryParameter("AGRS", m3AGRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRR))
				request.WithQueryParameter("AGRR", m3AGRR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NBID))
				request.WithQueryParameter("NBID", m3NBID.Trim());
			if (!string.IsNullOrWhiteSpace(m3MLYR))
				request.WithQueryParameter("MLYR", m3MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AREA))
				request.WithQueryParameter("AREA", m3AREA.Trim());
			if (m3GDT1.HasValue)
				request.WithQueryParameter("GDT1", m3GDT1.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUGA))
				request.WithQueryParameter("CUGA", m3CUGA.Trim());
			if (m3GDT2.HasValue)
				request.WithQueryParameter("GDT2", m3GDT2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PROD))
				request.WithQueryParameter("PROD", m3PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUIC))
				request.WithQueryParameter("CUIC", m3CUIC.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3MINO))
				request.WithQueryParameter("MINO", m3MINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CONS))
				request.WithQueryParameter("CONS", m3CONS.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFE1))
				request.WithQueryParameter("CFE1", m3CFE1.Trim());
			if (m3CFE2.HasValue)
				request.WithQueryParameter("CFE2", m3CFE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFE3))
				request.WithQueryParameter("CFE3", m3CFE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFE4))
				request.WithQueryParameter("CFE4", m3CFE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFE5))
				request.WithQueryParameter("CFE5", m3CFE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFE6))
				request.WithQueryParameter("CFE6", m3CFE6.Trim());
			if (m3CFE7.HasValue)
				request.WithQueryParameter("CFE7", m3CFE7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFE8))
				request.WithQueryParameter("CFE8", m3CFE8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFE9))
				request.WithQueryParameter("CFE9", m3CFE9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFE0))
				request.WithQueryParameter("CFE0", m3CFE0.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFEA))
				request.WithQueryParameter("CFEA", m3CFEA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFEB))
				request.WithQueryParameter("CFEB", m3CFEB.Trim());
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PNLI))
				request.WithQueryParameter("PNLI", m3PNLI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORC))
				request.WithQueryParameter("RORC", m3RORC.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORL))
				request.WithQueryParameter("RORL", m3RORL.Trim());
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DDAT.HasValue)
				request.WithQueryParameter("DDAT", m3DDAT.Value.ToM3String());
			if (m3TYPR.HasValue)
				request.WithQueryParameter("TYPR", m3TYPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOCS))
				request.WithQueryParameter("LOCS", m3LOCS.Trim());

			// Execute the request
			var result = await Execute<AddIndItemResponse>(
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
		/// Name AddLine
		/// Description Create a new service order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3JOBN">Assignment number (Required)</param>
		/// <param name="m3JBSX">Assignment suffix (Required)</param>
		/// <param name="m3ITNO">Item number or service expense number (Required)</param>
		/// <param name="m3ORQT">Order quantity (Required)</param>
		/// <param name="m3YYYY">Error message (0=No set sts to 11,1=Yes) (Required)</param>
		/// <param name="m3XXXX">Allocation directly (0=No, 1=Yes) (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ADTY">Addess type (1=Whs,2=Cust)</param>
		/// <param name="m3FWHL">From warehouse</param>
		/// <param name="m3PLSD">Planned start date</param>
		/// <param name="m3LTYP">Line type</param>
		/// <param name="m3PLST">Planned start time</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3ITDS">Name (item or service expense name)</param>
		/// <param name="m3STCD">Inventory accounting</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3REAL">Realocation</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLineResponse></returns>
		/// <exception cref="M3Exception<AddLineResponse>"></exception>
		public async Task<M3Response<AddLineResponse>> AddLine(
			string m3ORNO, 
			int m3JOBN, 
			int m3JBSX, 
			string m3ITNO, 
			decimal m3ORQT, 
			string m3YYYY, 
			string m3XXXX, 
			int? m3CONO = null, 
			string m3WHLO = null, 
			int? m3ADTY = null, 
			string m3FWHL = null, 
			DateTime? m3PLSD = null, 
			int? m3LTYP = null, 
			int? m3PLST = null, 
			string m3DBCO = null, 
			string m3PYNO = null, 
			decimal? m3SAPR = null, 
			string m3SUNO = null, 
			string m3ITDS = null, 
			int? m3STCD = null, 
			string m3TECH = null, 
			int? m3REAL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3YYYY))
				throw new ArgumentNullException(nameof(m3YYYY));
			if (string.IsNullOrWhiteSpace(m3XXXX))
				throw new ArgumentNullException(nameof(m3XXXX));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBSX", m3JBSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ORQT", m3ORQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("YYYY", m3YYYY.Trim())
				.WithQueryParameter("XXXX", m3XXXX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (m3ADTY.HasValue)
				request.WithQueryParameter("ADTY", m3ADTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (m3PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3PLSD.Value.ToM3String());
			if (m3LTYP.HasValue)
				request.WithQueryParameter("LTYP", m3LTYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLST.HasValue)
				request.WithQueryParameter("PLST", m3PLST.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (m3STCD.HasValue)
				request.WithQueryParameter("STCD", m3STCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (m3REAL.HasValue)
				request.WithQueryParameter("REAL", m3REAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());

			// Execute the request
			var result = await Execute<AddLineResponse>(
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
		/// Name AddMtrReading
		/// Description Create new meter reading
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3INNO">Individual item number (Required)</param>
		/// <param name="m3MEEV">Meter event (Required)</param>
		/// <param name="m3MEEN">Meter entry source (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3EVDT">Meter reading date</param>
		/// <param name="m3EVTM">Meter reading time</param>
		/// <param name="m3RESP">Resonsible</param>
		/// <param name="m3AMV1">Meter reading 1</param>
		/// <param name="m3AMV2">Meter reading 2</param>
		/// <param name="m3AMV3">Meter reading 3</param>
		/// <param name="m3AMV4">Meter reading 4</param>
		/// <param name="m3AMV5">Meter reading 5</param>
		/// <param name="m3AMV6">Meter reading 6</param>
		/// <param name="m3AMC1">Credits 1</param>
		/// <param name="m3AMC2">Credits 2</param>
		/// <param name="m3AMC3">Credits 3</param>
		/// <param name="m3AMC4">Credits 4</param>
		/// <param name="m3AMC5">Credits 5</param>
		/// <param name="m3AMC6">Credits 6</param>
		/// <param name="m3AMF1">Free units 1</param>
		/// <param name="m3AMF2">Free units 2</param>
		/// <param name="m3AMF3">Free units 3</param>
		/// <param name="m3AMF4">Free units 4</param>
		/// <param name="m3AMF5">Free units 5</param>
		/// <param name="m3AMF6">Free units 6</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3CHK1">Chk deviation</param>
		/// <param name="m3CHK2">Chk lower value</param>
		/// <param name="m3ORNO">Service order number</param>
		/// <param name="m3JOBN">Assignment number</param>
		/// <param name="m3JBXS">Assignment suffix</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMtrReading(
			string m3INNO, 
			string m3MEEV, 
			string m3MEEN, 
			int? m3CONO = null, 
			DateTime? m3EVDT = null, 
			int? m3EVTM = null, 
			string m3RESP = null, 
			long? m3AMV1 = null, 
			long? m3AMV2 = null, 
			long? m3AMV3 = null, 
			long? m3AMV4 = null, 
			long? m3AMV5 = null, 
			long? m3AMV6 = null, 
			long? m3AMC1 = null, 
			long? m3AMC2 = null, 
			long? m3AMC3 = null, 
			long? m3AMC4 = null, 
			long? m3AMC5 = null, 
			long? m3AMC6 = null, 
			long? m3AMF1 = null, 
			long? m3AMF2 = null, 
			long? m3AMF3 = null, 
			long? m3AMF4 = null, 
			long? m3AMF5 = null, 
			long? m3AMF6 = null, 
			string m3TX30 = null, 
			int? m3CHK1 = null, 
			int? m3CHK2 = null, 
			string m3ORNO = null, 
			int? m3JOBN = null, 
			int? m3JBXS = null, 
			string m3EMNO = null, 
			string m3TECH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMtrReading",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3INNO))
				throw new ArgumentNullException(nameof(m3INNO));
			if (string.IsNullOrWhiteSpace(m3MEEV))
				throw new ArgumentNullException(nameof(m3MEEV));
			if (string.IsNullOrWhiteSpace(m3MEEN))
				throw new ArgumentNullException(nameof(m3MEEN));

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3INNO.Trim())
				.WithQueryParameter("MEEV", m3MEEV.Trim())
				.WithQueryParameter("MEEN", m3MEEN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EVDT.HasValue)
				request.WithQueryParameter("EVDT", m3EVDT.Value.ToM3String());
			if (m3EVTM.HasValue)
				request.WithQueryParameter("EVTM", m3EVTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3AMV1.HasValue)
				request.WithQueryParameter("AMV1", m3AMV1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMV2.HasValue)
				request.WithQueryParameter("AMV2", m3AMV2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMV3.HasValue)
				request.WithQueryParameter("AMV3", m3AMV3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMV4.HasValue)
				request.WithQueryParameter("AMV4", m3AMV4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMV5.HasValue)
				request.WithQueryParameter("AMV5", m3AMV5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMV6.HasValue)
				request.WithQueryParameter("AMV6", m3AMV6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMC1.HasValue)
				request.WithQueryParameter("AMC1", m3AMC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMC2.HasValue)
				request.WithQueryParameter("AMC2", m3AMC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMC3.HasValue)
				request.WithQueryParameter("AMC3", m3AMC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMC4.HasValue)
				request.WithQueryParameter("AMC4", m3AMC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMC5.HasValue)
				request.WithQueryParameter("AMC5", m3AMC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMC6.HasValue)
				request.WithQueryParameter("AMC6", m3AMC6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMF1.HasValue)
				request.WithQueryParameter("AMF1", m3AMF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMF2.HasValue)
				request.WithQueryParameter("AMF2", m3AMF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMF3.HasValue)
				request.WithQueryParameter("AMF3", m3AMF3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMF4.HasValue)
				request.WithQueryParameter("AMF4", m3AMF4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMF5.HasValue)
				request.WithQueryParameter("AMF5", m3AMF5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMF6.HasValue)
				request.WithQueryParameter("AMF6", m3AMF6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (m3CHK1.HasValue)
				request.WithQueryParameter("CHK1", m3CHK1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHK2.HasValue)
				request.WithQueryParameter("CHK2", m3CHK2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3JOBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBXS.HasValue)
				request.WithQueryParameter("JBXS", m3JBXS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());

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
		/// Name AddServOrd
		/// Description Add service order head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3INNO">Individual item number (Required)</param>
		/// <param name="m3SOTP">Service order type (Required)</param>
		/// <param name="m3ESCO">Error symptom code (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Element</param>
		/// <param name="m3SRES">Service Manager</param>
		/// <param name="m3TECH">Technichian</param>
		/// <param name="m3ORNO">Service order number</param>
		/// <param name="m3PSDJ">Planned start date assignment</param>
		/// <param name="m3PSTJ">Planned start time assignment</param>
		/// <param name="m3WOTM">Forcast work hours</param>
		/// <param name="m3WARR">Warranty (Yes/No)</param>
		/// <param name="m3CONF">Confirmation docoment (Yes/No)</param>
		/// <param name="m3CNDI">Condition</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3TEXT">Error Text 4*60</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3OREF">Our reference</param>
		/// <param name="m3PRS1">Price list SO</param>
		/// <param name="m3TXAP">Tax applicable</param>
		/// <param name="m3DLRM">Remark</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3JBST">Status service assignment</param>
		/// <param name="m3JBSE">Additional status</param>
		/// <param name="m3ASST">Assignment type</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3SVID">Service expense</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3ROLE">Role/organizational position</param>
		/// <param name="m3ECLC">Labor code - trade statistics (TST)</param>
		/// <param name="m3VRCD">Business type - trade statistics (TST)</param>
		/// <param name="m3RONO">Run</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3SDST">District</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddServOrdResponse></returns>
		/// <exception cref="M3Exception<AddServOrdResponse>"></exception>
		public async Task<M3Response<AddServOrdResponse>> AddServOrd(
			string m3INNO, 
			string m3SOTP, 
			string m3ESCO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3SRES = null, 
			string m3TECH = null, 
			string m3ORNO = null, 
			int? m3PSDJ = null, 
			int? m3PSTJ = null, 
			int? m3WOTM = null, 
			int? m3WARR = null, 
			int? m3CONF = null, 
			string m3CNDI = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3TEXT = null, 
			string m3CUPL = null, 
			string m3YREF = null, 
			string m3PHNO = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEPY = null, 
			string m3PYNO = null, 
			string m3OREF = null, 
			string m3PRS1 = null, 
			int? m3TXAP = null, 
			string m3DLRM = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3TFNO = null, 
			string m3JBST = null, 
			string m3JBSE = null, 
			string m3ASST = null, 
			string m3CUOR = null, 
			string m3DBCO = null, 
			string m3CTNO = null, 
			string m3SVID = null, 
			string m3SUFI = null, 
			string m3ROLE = null, 
			string m3ECLC = null, 
			string m3VRCD = null, 
			string m3RONO = null, 
			string m3SMCD = null, 
			string m3SDST = null, 
			string m3ADID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddServOrd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3INNO))
				throw new ArgumentNullException(nameof(m3INNO));
			if (string.IsNullOrWhiteSpace(m3SOTP))
				throw new ArgumentNullException(nameof(m3SOTP));
			if (string.IsNullOrWhiteSpace(m3ESCO))
				throw new ArgumentNullException(nameof(m3ESCO));

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3INNO.Trim())
				.WithQueryParameter("SOTP", m3SOTP.Trim())
				.WithQueryParameter("ESCO", m3ESCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3PSDJ.HasValue)
				request.WithQueryParameter("PSDJ", m3PSDJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSTJ.HasValue)
				request.WithQueryParameter("PSTJ", m3PSTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WOTM.HasValue)
				request.WithQueryParameter("WOTM", m3WOTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WARR.HasValue)
				request.WithQueryParameter("WARR", m3WARR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONF.HasValue)
				request.WithQueryParameter("CONF", m3CONF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CNDI))
				request.WithQueryParameter("CNDI", m3CNDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEXT))
				request.WithQueryParameter("TEXT", m3TEXT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3OREF))
				request.WithQueryParameter("OREF", m3OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRS1))
				request.WithQueryParameter("PRS1", m3PRS1.Trim());
			if (m3TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3TXAP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DLRM))
				request.WithQueryParameter("DLRM", m3DLRM.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3JBST))
				request.WithQueryParameter("JBST", m3JBST.Trim());
			if (!string.IsNullOrWhiteSpace(m3JBSE))
				request.WithQueryParameter("JBSE", m3JBSE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASST))
				request.WithQueryParameter("ASST", m3ASST.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SVID))
				request.WithQueryParameter("SVID", m3SVID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROLE))
				request.WithQueryParameter("ROLE", m3ROLE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECLC))
				request.WithQueryParameter("ECLC", m3ECLC.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRCD))
				request.WithQueryParameter("VRCD", m3VRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3RONO))
				request.WithQueryParameter("RONO", m3RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SDST))
				request.WithQueryParameter("SDST", m3SDST.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());

			// Execute the request
			var result = await Execute<AddServOrdResponse>(
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
		/// Name ChgAssignm
		/// Description Change contents of service assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3JOBN">Assignment number (Required)</param>
		/// <param name="m3JBSX">Assignment suffix (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3ESCO">Error symptom code</param>
		/// <param name="m3ETX1">Error symptom text 1</param>
		/// <param name="m3ETX2">Error symptom text 2</param>
		/// <param name="m3ETX3">Error symptom text 3</param>
		/// <param name="m3ETX4">Error symptom text 4</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3OPRI">Priority</param>
		/// <param name="m3ASST">Assignment type</param>
		/// <param name="m3WOTM">Forecasted work hours</param>
		/// <param name="m3QUNO">Qualification</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3JBST">Assignment status</param>
		/// <param name="m3PMDT">Error report date</param>
		/// <param name="m3PMTM">Error report time</param>
		/// <param name="m3SSDT">Last start date</param>
		/// <param name="m3SSTM">Last start time</param>
		/// <param name="m3PSDJ">Planned start date assignment</param>
		/// <param name="m3PSTJ">Planned start time assignment</param>
		/// <param name="m3PSDW">Planned start date task</param>
		/// <param name="m3PSTW">Planned start time task</param>
		/// <param name="m3PFDJ">Planned finish date assignment</param>
		/// <param name="m3PFTJ">Planned finish time assignment</param>
		/// <param name="m3PFDW">Planned finish date task</param>
		/// <param name="m3PFTW">Planned finish time task</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3ERCO">Error cause</param>
		/// <param name="m3MECO">Action code</param>
		/// <param name="m3MTCO">Action text code</param>
		/// <param name="m3MTX1">Action text 1</param>
		/// <param name="m3MTX2">Action text 2</param>
		/// <param name="m3MTX3">Action text 3</param>
		/// <param name="m3MTX4">Action text 4</param>
		/// <param name="m3JBSE">Additional status</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3SVID">Service expense</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3ROLE">Role/organizational position</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAssignm(
			string m3ORNO, 
			int m3JOBN, 
			int m3JBSX, 
			int? m3CONO = null, 
			string m3ESCO = null, 
			string m3ETX1 = null, 
			string m3ETX2 = null, 
			string m3ETX3 = null, 
			string m3ETX4 = null, 
			string m3DBCO = null, 
			int? m3OPRI = null, 
			string m3ASST = null, 
			int? m3WOTM = null, 
			string m3QUNO = null, 
			string m3SRES = null, 
			string m3TECH = null, 
			string m3JBST = null, 
			DateTime? m3PMDT = null, 
			int? m3PMTM = null, 
			DateTime? m3SSDT = null, 
			int? m3SSTM = null, 
			DateTime? m3PSDJ = null, 
			int? m3PSTJ = null, 
			DateTime? m3PSDW = null, 
			int? m3PSTW = null, 
			DateTime? m3PFDJ = null, 
			int? m3PFTJ = null, 
			DateTime? m3PFDW = null, 
			int? m3PFTW = null, 
			string m3CTNO = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3ERCO = null, 
			string m3MECO = null, 
			string m3MTCO = null, 
			string m3MTX1 = null, 
			string m3MTX2 = null, 
			string m3MTX3 = null, 
			string m3MTX4 = null, 
			int? m3JBSE = null, 
			string m3CUOR = null, 
			string m3SVID = null, 
			string m3SUFI = null, 
			string m3ROLE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgAssignm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBSX", m3JBSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ESCO))
				request.WithQueryParameter("ESCO", m3ESCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX1))
				request.WithQueryParameter("ETX1", m3ETX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX2))
				request.WithQueryParameter("ETX2", m3ETX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX3))
				request.WithQueryParameter("ETX3", m3ETX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX4))
				request.WithQueryParameter("ETX4", m3ETX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (m3OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3OPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ASST))
				request.WithQueryParameter("ASST", m3ASST.Trim());
			if (m3WOTM.HasValue)
				request.WithQueryParameter("WOTM", m3WOTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QUNO))
				request.WithQueryParameter("QUNO", m3QUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3JBST))
				request.WithQueryParameter("JBST", m3JBST.Trim());
			if (m3PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3PMDT.Value.ToM3String());
			if (m3PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3PMTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSDT.HasValue)
				request.WithQueryParameter("SSDT", m3SSDT.Value.ToM3String());
			if (m3SSTM.HasValue)
				request.WithQueryParameter("SSTM", m3SSTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSDJ.HasValue)
				request.WithQueryParameter("PSDJ", m3PSDJ.Value.ToM3String());
			if (m3PSTJ.HasValue)
				request.WithQueryParameter("PSTJ", m3PSTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSDW.HasValue)
				request.WithQueryParameter("PSDW", m3PSDW.Value.ToM3String());
			if (m3PSTW.HasValue)
				request.WithQueryParameter("PSTW", m3PSTW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PFDJ.HasValue)
				request.WithQueryParameter("PFDJ", m3PFDJ.Value.ToM3String());
			if (m3PFTJ.HasValue)
				request.WithQueryParameter("PFTJ", m3PFTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PFDW.HasValue)
				request.WithQueryParameter("PFDW", m3PFDW.Value.ToM3String());
			if (m3PFTW.HasValue)
				request.WithQueryParameter("PFTW", m3PFTW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ERCO))
				request.WithQueryParameter("ERCO", m3ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MECO))
				request.WithQueryParameter("MECO", m3MECO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTCO))
				request.WithQueryParameter("MTCO", m3MTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX1))
				request.WithQueryParameter("MTX1", m3MTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX2))
				request.WithQueryParameter("MTX2", m3MTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX3))
				request.WithQueryParameter("MTX3", m3MTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX4))
				request.WithQueryParameter("MTX4", m3MTX4.Trim());
			if (m3JBSE.HasValue)
				request.WithQueryParameter("JBSE", m3JBSE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SVID))
				request.WithQueryParameter("SVID", m3SVID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROLE))
				request.WithQueryParameter("ROLE", m3ROLE.Trim());

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
		/// Name ChgAssignmSts
		/// Description Change assignment status and/or dates
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3JOBN">Assignment number (Required)</param>
		/// <param name="m3JBSX">Assignment suffix (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3JBST">Assignment status</param>
		/// <param name="m3PSDJ">Planned start date assignment</param>
		/// <param name="m3PSTJ">Planned start time assignment</param>
		/// <param name="m3PFDJ">Planned finish date assignment</param>
		/// <param name="m3PFTJ">Planned finish time assignment</param>
		/// <param name="m3RSDJ">Actual start date assignment</param>
		/// <param name="m3RSTJ">Actual start time assignment</param>
		/// <param name="m3RSDW">Actual start date task</param>
		/// <param name="m3RSTW">Actual start time task</param>
		/// <param name="m3RFDJ">Actual finish date assignment</param>
		/// <param name="m3RFTJ">Actual finish time assignment</param>
		/// <param name="m3RFDW">Actual finish date task</param>
		/// <param name="m3RFTW">Actual finish time task</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3TECH">Techinician</param>
		/// <param name="m3JBSE">Additional status</param>
		/// <param name="m3ASST">Assignment type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAssignmSts(
			string m3ORNO, 
			int m3JOBN, 
			int m3JBSX, 
			int? m3CONO = null, 
			string m3JBST = null, 
			DateTime? m3PSDJ = null, 
			int? m3PSTJ = null, 
			DateTime? m3PFDJ = null, 
			int? m3PFTJ = null, 
			DateTime? m3RSDJ = null, 
			int? m3RSTJ = null, 
			DateTime? m3RSDW = null, 
			int? m3RSTW = null, 
			DateTime? m3RFDJ = null, 
			int? m3RFTJ = null, 
			DateTime? m3RFDW = null, 
			int? m3RFTW = null, 
			string m3SRES = null, 
			string m3TECH = null, 
			string m3JBSE = null, 
			string m3ASST = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgAssignmSts",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBSX", m3JBSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3JBST))
				request.WithQueryParameter("JBST", m3JBST.Trim());
			if (m3PSDJ.HasValue)
				request.WithQueryParameter("PSDJ", m3PSDJ.Value.ToM3String());
			if (m3PSTJ.HasValue)
				request.WithQueryParameter("PSTJ", m3PSTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PFDJ.HasValue)
				request.WithQueryParameter("PFDJ", m3PFDJ.Value.ToM3String());
			if (m3PFTJ.HasValue)
				request.WithQueryParameter("PFTJ", m3PFTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSDJ.HasValue)
				request.WithQueryParameter("RSDJ", m3RSDJ.Value.ToM3String());
			if (m3RSTJ.HasValue)
				request.WithQueryParameter("RSTJ", m3RSTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSDW.HasValue)
				request.WithQueryParameter("RSDW", m3RSDW.Value.ToM3String());
			if (m3RSTW.HasValue)
				request.WithQueryParameter("RSTW", m3RSTW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RFDJ.HasValue)
				request.WithQueryParameter("RFDJ", m3RFDJ.Value.ToM3String());
			if (m3RFTJ.HasValue)
				request.WithQueryParameter("RFTJ", m3RFTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RFDW.HasValue)
				request.WithQueryParameter("RFDW", m3RFDW.Value.ToM3String());
			if (m3RFTW.HasValue)
				request.WithQueryParameter("RFTW", m3RFTW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3JBSE))
				request.WithQueryParameter("JBSE", m3JBSE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASST))
				request.WithQueryParameter("ASST", m3ASST.Trim());

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
		/// Name ChgLine
		/// Description Change contents of a service order line
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3JOBN">Assignment number (Required)</param>
		/// <param name="m3JBSX">Assignment suffix (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3POSX">Line suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORQT">Order quantity</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3UCOS">Cost price</param>
		/// <param name="m3RAQT">Reported quantity</param>
		/// <param name="m3ITDS">Name (item or service expense name)</param>
		/// <param name="m3PLSD">Planned start date</param>
		/// <param name="m3PLST">Planned start time</param>
		/// <param name="m3PLFD">Planned finish date</param>
		/// <param name="m3PLFT">Planned finish time</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3CFF1">User-defined field 1 - service expense</param>
		/// <param name="m3CFF2">User-defined field 2 - service expense</param>
		/// <param name="m3CFF3">User-defined field 3 - service expense</param>
		/// <param name="m3CFF4">User-defined field 4 - service expense</param>
		/// <param name="m3CFF5">User-defined field 5 - service expense</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgLine(
			string m3ORNO, 
			int m3JOBN, 
			int m3JBSX, 
			int m3PONR, 
			int m3POSX, 
			int? m3CONO = null, 
			decimal? m3ORQT = null, 
			string m3PYNO = null, 
			decimal? m3SAPR = null, 
			decimal? m3UCOS = null, 
			decimal? m3RAQT = null, 
			string m3ITDS = null, 
			DateTime? m3PLSD = null, 
			int? m3PLST = null, 
			DateTime? m3PLFD = null, 
			int? m3PLFT = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3CFF1 = null, 
			decimal? m3CFF2 = null, 
			string m3CFF3 = null, 
			string m3CFF4 = null, 
			string m3CFF5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBSX", m3JBSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("POSX", m3POSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3UCOS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RAQT.HasValue)
				request.WithQueryParameter("RAQT", m3RAQT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (m3PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3PLSD.Value.ToM3String());
			if (m3PLST.HasValue)
				request.WithQueryParameter("PLST", m3PLST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3PLFD.Value.ToM3String());
			if (m3PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3PLFT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFF1))
				request.WithQueryParameter("CFF1", m3CFF1.Trim());
			if (m3CFF2.HasValue)
				request.WithQueryParameter("CFF2", m3CFF2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFF3))
				request.WithQueryParameter("CFF3", m3CFF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFF4))
				request.WithQueryParameter("CFF4", m3CFF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFF5))
				request.WithQueryParameter("CFF5", m3CFF5.Trim());

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
		/// Name CompleteAssignm
		/// Description Complete the assignment and make it ready for invoicing
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3JOBN">Assignment number (Required)</param>
		/// <param name="m3JBSX">Assignment suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3OEND">Finish marked</param>
		/// <param name="m3RSDJ">Actual start date assignment</param>
		/// <param name="m3RSTJ">Actual start time assignment</param>
		/// <param name="m3RSDW">Actual start date task</param>
		/// <param name="m3RSTW">Actual start time task</param>
		/// <param name="m3RFDJ">Actual finish date assignment</param>
		/// <param name="m3RFTJ">Actual finish time assignment</param>
		/// <param name="m3RFDW">Actual finish date task</param>
		/// <param name="m3RFTW">Actual finish time task</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CompleteAssignmResponse></returns>
		/// <exception cref="M3Exception<CompleteAssignmResponse>"></exception>
		public async Task<M3Response<CompleteAssignmResponse>> CompleteAssignm(
			string m3ORNO, 
			int m3JOBN, 
			int m3JBSX, 
			int? m3CONO = null, 
			int? m3OEND = null, 
			DateTime? m3RSDJ = null, 
			int? m3RSTJ = null, 
			DateTime? m3RSDW = null, 
			int? m3RSTW = null, 
			DateTime? m3RFDJ = null, 
			int? m3RFTJ = null, 
			DateTime? m3RFDW = null, 
			int? m3RFTW = null, 
			string m3TWSL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CompleteAssignm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBSX", m3JBSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSDJ.HasValue)
				request.WithQueryParameter("RSDJ", m3RSDJ.Value.ToM3String());
			if (m3RSTJ.HasValue)
				request.WithQueryParameter("RSTJ", m3RSTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSDW.HasValue)
				request.WithQueryParameter("RSDW", m3RSDW.Value.ToM3String());
			if (m3RSTW.HasValue)
				request.WithQueryParameter("RSTW", m3RSTW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RFDJ.HasValue)
				request.WithQueryParameter("RFDJ", m3RFDJ.Value.ToM3String());
			if (m3RFTJ.HasValue)
				request.WithQueryParameter("RFTJ", m3RFTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RFDW.HasValue)
				request.WithQueryParameter("RFDW", m3RFDW.Value.ToM3String());
			if (m3RFTW.HasValue)
				request.WithQueryParameter("RFTW", m3RFTW.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());

			// Execute the request
			var result = await Execute<CompleteAssignmResponse>(
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
		/// Name DelLine
		/// Description Delete service order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3JOBN">Assignment number (Required)</param>
		/// <param name="m3JBSX">Assignment suffix (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLine(
			string m3ORNO, 
			int m3JOBN, 
			int m3JBSX, 
			int m3PONR, 
			int? m3CONO = null, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBSX", m3JBSX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetAgrInfo
		/// Description Retrieve agreement information per individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3INNO">Individual item (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrInfoResponse></returns>
		/// <exception cref="M3Exception<GetAgrInfoResponse>"></exception>
		public async Task<M3Response<GetAgrInfoResponse>> GetAgrInfo(
			string m3INNO, 
			int? m3CONO = null, 
			string m3CTNO = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAgrInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3INNO))
				throw new ArgumentNullException(nameof(m3INNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAgrInfoResponse>(
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
		/// Name GetAssignm
		/// Description Retrieve assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3JOBN">Assignment number (Required)</param>
		/// <param name="m3JBSX">Assignment suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAssignmResponse></returns>
		/// <exception cref="M3Exception<GetAssignmResponse>"></exception>
		public async Task<M3Response<GetAssignmResponse>> GetAssignm(
			string m3ORNO, 
			int m3JOBN, 
			int m3JBSX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAssignm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBSX", m3JBSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAssignmResponse>(
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
		/// Name GetCurrency
		/// Description Get currency
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCurrencyResponse></returns>
		/// <exception cref="M3Exception<GetCurrencyResponse>"></exception>
		public async Task<M3Response<GetCurrencyResponse>> GetCurrency(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCurrency",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetCurrencyResponse>(
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
		/// Name GetHead
		/// Description Retrieve service order head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetIndividual
		/// Description Get individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3INNO">Individual item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIndividualResponse></returns>
		/// <exception cref="M3Exception<GetIndividualResponse>"></exception>
		public async Task<M3Response<GetIndividualResponse>> GetIndividual(
			string m3INNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetIndividual",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3INNO))
				throw new ArgumentNullException(nameof(m3INNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetIndividualResponse>(
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
		/// Name GetMtrByInd
		/// Description Get all meters per individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3INNO">Individual item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMtrByIndResponse></returns>
		/// <exception cref="M3Exception<GetMtrByIndResponse>"></exception>
		public async Task<M3Response<GetMtrByIndResponse>> GetMtrByInd(
			string m3INNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMtrByInd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3INNO))
				throw new ArgumentNullException(nameof(m3INNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMtrByIndResponse>(
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
		/// Name GetSoAddress
		/// Description Retrieve SO address information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSoAddressResponse></returns>
		/// <exception cref="M3Exception<GetSoAddressResponse>"></exception>
		public async Task<M3Response<GetSoAddressResponse>> GetSoAddress(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSoAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSoAddressResponse>(
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
		/// Name GetUsrInfo
		/// Description Retrieve user information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3USID">User ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUsrInfoResponse></returns>
		/// <exception cref="M3Exception<GetUsrInfoResponse>"></exception>
		public async Task<M3Response<GetUsrInfoResponse>> GetUsrInfo(
			string m3USID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetUsrInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim());

			// Execute the request
			var result = await Execute<GetUsrInfoResponse>(
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
		/// Name LstActTxt
		/// Description List action texts
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MTCO">Action text</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstActTxtResponse></returns>
		/// <exception cref="M3Exception<LstActTxtResponse>"></exception>
		public async Task<M3Response<LstActTxtResponse>> LstActTxt(
			int? m3CONO = null, 
			string m3MTCO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstActTxt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTCO))
				request.WithQueryParameter("MTCO", m3MTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstActTxtResponse>(
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
		/// Name LstAction
		/// Description List action
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MECO">Action code</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstActionResponse></returns>
		/// <exception cref="M3Exception<LstActionResponse>"></exception>
		public async Task<M3Response<LstActionResponse>> LstAction(
			int? m3CONO = null, 
			string m3MECO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAction",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MECO))
				request.WithQueryParameter("MECO", m3MECO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstActionResponse>(
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
		/// Name LstAgrPerIndiv
		/// Description List all agreement lines per individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3INNO">Individual item number</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ALLI">Display all lines</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrPerIndivResponse></returns>
		/// <exception cref="M3Exception<LstAgrPerIndivResponse>"></exception>
		public async Task<M3Response<LstAgrPerIndivResponse>> LstAgrPerIndiv(
			int? m3CONO = null, 
			string m3INNO = null, 
			string m3CTNO = null, 
			string m3CUPL = null, 
			string m3ADID = null, 
			int? m3ALLI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgrPerIndiv",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3ALLI.HasValue)
				request.WithQueryParameter("ALLI", m3ALLI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAgrPerIndivResponse>(
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
		/// Name LstAgrTpContent
		/// Description List the content of an agreement type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrTpContentResponse></returns>
		/// <exception cref="M3Exception<LstAgrTpContentResponse>"></exception>
		public async Task<M3Response<LstAgrTpContentResponse>> LstAgrTpContent(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3AGTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgrTpContent",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());

			// Execute the request
			var result = await Execute<LstAgrTpContentResponse>(
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
		/// Name LstAssignm
		/// Description List assignment status less than 44 and not 38
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TECH">Technician (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssignmResponse></returns>
		/// <exception cref="M3Exception<LstAssignmResponse>"></exception>
		public async Task<M3Response<LstAssignmResponse>> LstAssignm(
			string m3TECH, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAssignm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TECH))
				throw new ArgumentNullException(nameof(m3TECH));

			// Set mandatory parameters
			request
				.WithQueryParameter("TECH", m3TECH.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAssignmResponse>(
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
		/// Name LstAssignmByCus
		/// Description List assignment by customer site
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3OPEN">Open activ (0=All,1=All but not JBST>79) (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3INNO">Individual item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssignmByCusResponse></returns>
		/// <exception cref="M3Exception<LstAssignmByCusResponse>"></exception>
		public async Task<M3Response<LstAssignmByCusResponse>> LstAssignmByCus(
			string m3CUNO, 
			int m3OPEN, 
			int? m3CONO = null, 
			string m3ADID = null, 
			string m3INNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAssignmByCus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("OPEN", m3OPEN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());

			// Execute the request
			var result = await Execute<LstAssignmByCusResponse>(
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
		/// Name LstAssignmByTec
		/// Description Retrieve assignments per technician
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3TECH">Technician (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STFR">Assignment status from</param>
		/// <param name="m3STTO">Assignment status to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssignmByTecResponse></returns>
		/// <exception cref="M3Exception<LstAssignmByTecResponse>"></exception>
		public async Task<M3Response<LstAssignmByTecResponse>> LstAssignmByTec(
			string m3DIVI, 
			string m3TECH, 
			int? m3CONO = null, 
			string m3STFR = null, 
			string m3STTO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAssignmByTec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3TECH))
				throw new ArgumentNullException(nameof(m3TECH));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("TECH", m3TECH.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STFR))
				request.WithQueryParameter("STFR", m3STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3STTO))
				request.WithQueryParameter("STTO", m3STTO.Trim());

			// Execute the request
			var result = await Execute<LstAssignmByTecResponse>(
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
		/// Name LstChgAssignm
		/// Description List new, chg and del assignment Status less than 44, 50, 90
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRPL">Type of assign (0=All,1=New,2=Chg,3=Del) (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstChgAssignmResponse></returns>
		/// <exception cref="M3Exception<LstChgAssignmResponse>"></exception>
		public async Task<M3Response<LstChgAssignmResponse>> LstChgAssignm(
			int m3PRPL, 
			int? m3CONO = null, 
			string m3SRES = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstChgAssignm",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PRPL", m3PRPL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());

			// Execute the request
			var result = await Execute<LstChgAssignmResponse>(
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
		/// Name LstCustByName
		/// Description List customer by name
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDTY">Search identity (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustByNameResponse></returns>
		/// <exception cref="M3Exception<LstCustByNameResponse>"></exception>
		public async Task<M3Response<LstCustByNameResponse>> LstCustByName(
			int m3IDTY, 
			int? m3CONO = null, 
			string m3CUNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCustByName",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("IDTY", m3IDTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());

			// Execute the request
			var result = await Execute<LstCustByNameResponse>(
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
		/// Name LstCustByPhone
		/// Description List customer by Phone
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDTY">Search identity (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3PHNO">Telephone number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustByPhoneResponse></returns>
		/// <exception cref="M3Exception<LstCustByPhoneResponse>"></exception>
		public async Task<M3Response<LstCustByPhoneResponse>> LstCustByPhone(
			int m3IDTY, 
			int? m3CONO = null, 
			string m3PHNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCustByPhone",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("IDTY", m3IDTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());

			// Execute the request
			var result = await Execute<LstCustByPhoneResponse>(
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
		/// Name LstErrCde
		/// Description List error codes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ERCO">Error codes</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrCdeResponse></returns>
		/// <exception cref="M3Exception<LstErrCdeResponse>"></exception>
		public async Task<M3Response<LstErrCdeResponse>> LstErrCde(
			int? m3CONO = null, 
			string m3ERCO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstErrCde",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ERCO))
				request.WithQueryParameter("ERCO", m3ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstErrCdeResponse>(
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
		/// Name LstErrSym
		/// Description List error symptom
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3ESCO">Error symptom</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrSymResponse></returns>
		/// <exception cref="M3Exception<LstErrSymResponse>"></exception>
		public async Task<M3Response<LstErrSymResponse>> LstErrSym(
			int? m3CONO = null, 
			string m3ESCO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstErrSym",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ESCO))
				request.WithQueryParameter("ESCO", m3ESCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstErrSymResponse>(
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
		/// Name LstHistAss
		/// Description List assignment Status greater than equal 45
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3JOBN">Assignment number (Required)</param>
		/// <param name="m3JBSX">Assignment suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHistAssResponse></returns>
		/// <exception cref="M3Exception<LstHistAssResponse>"></exception>
		public async Task<M3Response<LstHistAssResponse>> LstHistAss(
			string m3ORNO, 
			int m3JOBN, 
			int m3JBSX, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstHistAss",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBSX", m3JBSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstHistAssResponse>(
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
		/// Name LstIndPerSite
		/// Description List individual item per site
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3CUPL">Customer location</param>
		/// <param name="m3ADID">Address ID</param>
		/// <param name="m3INNO">Individual item (for positioning)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIndPerSiteResponse></returns>
		/// <exception cref="M3Exception<LstIndPerSiteResponse>"></exception>
		public async Task<M3Response<LstIndPerSiteResponse>> LstIndPerSite(
			int? m3CONO = null, 
			string m3CUPL = null, 
			string m3ADID = null, 
			string m3INNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstIndPerSite",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());

			// Execute the request
			var result = await Execute<LstIndPerSiteResponse>(
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
		/// Name LstItem
		/// Description List item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDTY">Type of ID (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Item description</param>
		/// <param name="m3IDNM">List by type, 0=Number 1=Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemResponse></returns>
		/// <exception cref="M3Exception<LstItemResponse>"></exception>
		public async Task<M3Response<LstItemResponse>> LstItem(
			int m3IDTY, 
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			string m3IDNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItem",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("IDTY", m3IDTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDNM))
				request.WithQueryParameter("IDNM", m3IDNM.Trim());

			// Execute the request
			var result = await Execute<LstItemResponse>(
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
		/// Name LstLine
		/// Description List service order lines per assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3JOBN">Assignment number</param>
		/// <param name="m3JBSX">Assignment suffix</param>
		/// <param name="m3PONR">Position number</param>
		/// <param name="m3POSX">Position suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3ORNO, 
			int? m3CONO = null, 
			int? m3JOBN = null, 
			int? m3JBSX = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3JOBN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3JBSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
		/// Name LstNewMeters
		/// Description List new and changed meter readings
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNewMetersResponse></returns>
		/// <exception cref="M3Exception<LstNewMetersResponse>"></exception>
		public async Task<M3Response<LstNewMetersResponse>> LstNewMeters(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstNewMeters",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstNewMetersResponse>(
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
		/// Name LstPrice
		/// Description List price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRS1">Price list</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3IDTY">Type of prices</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPriceResponse></returns>
		/// <exception cref="M3Exception<LstPriceResponse>"></exception>
		public async Task<M3Response<LstPriceResponse>> LstPrice(
			int? m3CONO = null, 
			string m3PRS1 = null, 
			string m3CUCD = null, 
			string m3CUNO = null, 
			DateTime? m3STDT = null, 
			string m3IDTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPrice",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRS1))
				request.WithQueryParameter("PRS1", m3PRS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3IDTY))
				request.WithQueryParameter("IDTY", m3IDTY.Trim());
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPriceResponse>(
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
		/// Name LstPriceLists
		/// Description List price lists per company
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRS1">Price list SO</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPriceListsResponse></returns>
		/// <exception cref="M3Exception<LstPriceListsResponse>"></exception>
		public async Task<M3Response<LstPriceListsResponse>> LstPriceLists(
			int? m3CONO = null, 
			string m3PRS1 = null, 
			string m3CUCD = null, 
			string m3CUNO = null, 
			DateTime? m3STDT = null, 
			DateTime? m3LVDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPriceLists",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRS1))
				request.WithQueryParameter("PRS1", m3PRS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPriceListsResponse>(
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
		/// Name LstSOAddr
		/// Description List service order address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSOAddrResponse></returns>
		/// <exception cref="M3Exception<LstSOAddrResponse>"></exception>
		public async Task<M3Response<LstSOAddrResponse>> LstSOAddr(
			string m3ORNO, 
			int? m3CONO = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSOAddr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());

			// Execute the request
			var result = await Execute<LstSOAddrResponse>(
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
		/// Name LstServManager
		/// Description List service manager
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServManagerResponse></returns>
		/// <exception cref="M3Exception<LstServManagerResponse>"></exception>
		public async Task<M3Response<LstServManagerResponse>> LstServManager(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3SRES = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstServManager",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());

			// Execute the request
			var result = await Execute<LstServManagerResponse>(
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
		/// Name LstServOrdType
		/// Description List service order types
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3SOTP">Service order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServOrdTypeResponse></returns>
		/// <exception cref="M3Exception<LstServOrdTypeResponse>"></exception>
		public async Task<M3Response<LstServOrdTypeResponse>> LstServOrdType(
			int? m3CONO = null, 
			string m3SOTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstServOrdType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SOTP))
				request.WithQueryParameter("SOTP", m3SOTP.Trim());

			// Execute the request
			var result = await Execute<LstServOrdTypeResponse>(
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
		/// Name LstSoTypeEnh
		/// Description List service order type, cat 1, 4, 6 and 9
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SOTP">Service order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSoTypeEnhResponse></returns>
		/// <exception cref="M3Exception<LstSoTypeEnhResponse>"></exception>
		public async Task<M3Response<LstSoTypeEnhResponse>> LstSoTypeEnh(
			int? m3CONO = null, 
			string m3SOTP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSoTypeEnh",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SOTP))
				request.WithQueryParameter("SOTP", m3SOTP.Trim());

			// Execute the request
			var result = await Execute<LstSoTypeEnhResponse>(
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
		/// Name LstTechQual
		/// Description List technicians qualifications
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3QUNO">Qualification</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTechQualResponse></returns>
		/// <exception cref="M3Exception<LstTechQualResponse>"></exception>
		public async Task<M3Response<LstTechQualResponse>> LstTechQual(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3TECH = null, 
			string m3QUNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTechQual",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3QUNO))
				request.WithQueryParameter("QUNO", m3QUNO.Trim());

			// Execute the request
			var result = await Execute<LstTechQualResponse>(
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
		/// Name LstTechnician
		/// Description List technicians
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTechnicianResponse></returns>
		/// <exception cref="M3Exception<LstTechnicianResponse>"></exception>
		public async Task<M3Response<LstTechnicianResponse>> LstTechnician(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3TECH = null, 
			string m3FACI = null, 
			string m3PLGR = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			string m3EMNO = null, 
			string m3SRES = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstTechnician",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());

			// Execute the request
			var result = await Execute<LstTechnicianResponse>(
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
		/// Name LstWorkSchedule
		/// Description List work schedule per company and division
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3WOSC">Work schedule (Required)</param>
		/// <param name="m3REF4">Type of info 1=Transactions/2=Worktime (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3YNQ1">Display lunch break Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWorkScheduleResponse></returns>
		/// <exception cref="M3Exception<LstWorkScheduleResponse>"></exception>
		public async Task<M3Response<LstWorkScheduleResponse>> LstWorkSchedule(
			string m3DIVI, 
			int m3WOSC, 
			int m3REF4, 
			int? m3CONO = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			int? m3YNQ1 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstWorkSchedule",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("WOSC", m3WOSC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("REF4", m3REF4.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (m3YNQ1.HasValue)
				request.WithQueryParameter("YNQ1", m3YNQ1.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstWorkScheduleResponse>(
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
		/// Name ReportAssignm
		/// Description Report the assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Service order number (Required)</param>
		/// <param name="m3JOBN">Assignment number (Required)</param>
		/// <param name="m3JBSX">Assignment suffix (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3INNO">Individual item number</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3ESCO">Error symptom code</param>
		/// <param name="m3ETX1">Error symptom text 1</param>
		/// <param name="m3ETX2">Error symptom text 2</param>
		/// <param name="m3ETX3">Error symptom text 3</param>
		/// <param name="m3ETX4">Error symptom text 4</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3ASST">Assignment type</param>
		/// <param name="m3ERCO">Error cause</param>
		/// <param name="m3MECO">Action code</param>
		/// <param name="m3MTCO">Action text code</param>
		/// <param name="m3MTX1">Action text 1</param>
		/// <param name="m3MTX2">Action text 2</param>
		/// <param name="m3MTX3">Action text 3</param>
		/// <param name="m3MTX4">Action text 4</param>
		/// <param name="m3RSDJ">Actual start date assignment</param>
		/// <param name="m3RSTJ">Actual start time assignment</param>
		/// <param name="m3RSDW">Actual start date task</param>
		/// <param name="m3RSTW">Actual start time task</param>
		/// <param name="m3RFDJ">Actual finish date assignment</param>
		/// <param name="m3RFTJ">Actual finish time assignment</param>
		/// <param name="m3RFDW">Actual finish date task</param>
		/// <param name="m3RFTW">Actual finish time task</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReportAssignm(
			string m3ORNO, 
			int m3JOBN, 
			int m3JBSX, 
			int? m3CONO = null, 
			string m3INNO = null, 
			string m3SERI = null, 
			string m3CUNO = null, 
			string m3ADID = null, 
			string m3ESCO = null, 
			string m3ETX1 = null, 
			string m3ETX2 = null, 
			string m3ETX3 = null, 
			string m3ETX4 = null, 
			string m3DBCO = null, 
			string m3ASST = null, 
			string m3ERCO = null, 
			string m3MECO = null, 
			string m3MTCO = null, 
			string m3MTX1 = null, 
			string m3MTX2 = null, 
			string m3MTX3 = null, 
			string m3MTX4 = null, 
			DateTime? m3RSDJ = null, 
			int? m3RSTJ = null, 
			DateTime? m3RSDW = null, 
			int? m3RSTW = null, 
			DateTime? m3RFDJ = null, 
			int? m3RFTJ = null, 
			DateTime? m3RFDW = null, 
			int? m3RFTW = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ReportAssignm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("JOBN", m3JOBN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("JBSX", m3JBSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3INNO))
				request.WithQueryParameter("INNO", m3INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ESCO))
				request.WithQueryParameter("ESCO", m3ESCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX1))
				request.WithQueryParameter("ETX1", m3ETX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX2))
				request.WithQueryParameter("ETX2", m3ETX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX3))
				request.WithQueryParameter("ETX3", m3ETX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETX4))
				request.WithQueryParameter("ETX4", m3ETX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASST))
				request.WithQueryParameter("ASST", m3ASST.Trim());
			if (!string.IsNullOrWhiteSpace(m3ERCO))
				request.WithQueryParameter("ERCO", m3ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MECO))
				request.WithQueryParameter("MECO", m3MECO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTCO))
				request.WithQueryParameter("MTCO", m3MTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX1))
				request.WithQueryParameter("MTX1", m3MTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX2))
				request.WithQueryParameter("MTX2", m3MTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX3))
				request.WithQueryParameter("MTX3", m3MTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MTX4))
				request.WithQueryParameter("MTX4", m3MTX4.Trim());
			if (m3RSDJ.HasValue)
				request.WithQueryParameter("RSDJ", m3RSDJ.Value.ToM3String());
			if (m3RSTJ.HasValue)
				request.WithQueryParameter("RSTJ", m3RSTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSDW.HasValue)
				request.WithQueryParameter("RSDW", m3RSDW.Value.ToM3String());
			if (m3RSTW.HasValue)
				request.WithQueryParameter("RSTW", m3RSTW.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RFDJ.HasValue)
				request.WithQueryParameter("RFDJ", m3RFDJ.Value.ToM3String());
			if (m3RFTJ.HasValue)
				request.WithQueryParameter("RFTJ", m3RFTJ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RFDW.HasValue)
				request.WithQueryParameter("RFDW", m3RFDW.Value.ToM3String());
			if (m3RFTW.HasValue)
				request.WithQueryParameter("RFTW", m3RFTW.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name RlsDistOrder
		/// Description Release distribution order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RORN">Reference order number (service order no (Required)</param>
		/// <param name="m3RORC">Reference order cathegory (=7) (Required)</param>
		/// <param name="m3TYPE">Type (*RLS) (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RlsDistOrder(
			string m3RORN, 
			string m3RORC, 
			int m3TYPE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RlsDistOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RORN))
				throw new ArgumentNullException(nameof(m3RORN));
			if (string.IsNullOrWhiteSpace(m3RORC))
				throw new ArgumentNullException(nameof(m3RORC));

			// Set mandatory parameters
			request
				.WithQueryParameter("RORN", m3RORN.Trim())
				.WithQueryParameter("RORC", m3RORC.Trim())
				.WithQueryParameter("TYPE", m3TYPE.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdIndItem
		/// Description Update of individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3INNO">Individual item number (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3CUOW">Customer owner</param>
		/// <param name="m3CUPL">Customer location</param>
		/// <param name="m3ADID">Address id</param>
		/// <param name="m3ISTS">Individual item status</param>
		/// <param name="m3INGR">Individual item group</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3BRAN">Brand</param>
		/// <param name="m3INTY">Individual item type</param>
		/// <param name="m3MODE">Model</param>
		/// <param name="m3MODC">Model name</param>
		/// <param name="m3TECH">Technician</param>
		/// <param name="m3SRES">Service responsible</param>
		/// <param name="m3ITGR">Item group</param>
		/// <param name="m3DEDA">Delivery date</param>
		/// <param name="m3REDA">Receipt date</param>
		/// <param name="m3INDA">Installation date</param>
		/// <param name="m3AGRS">Contract item - service</param>
		/// <param name="m3AGRR">Contract item - rental</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3NBID">Number series id</param>
		/// <param name="m3TRAN">Transaction 1 = Add, 2 = Update</param>
		/// <param name="m3MLYR">Year model</param>
		/// <param name="m3AREA">Location description</param>
		/// <param name="m3GDT1">Warranty date sales</param>
		/// <param name="m3CUGA">General agent</param>
		/// <param name="m3GDT2">Warranty date supplier</param>
		/// <param name="m3PROD">Manufacturer</param>
		/// <param name="m3CUIC">Customer number at insurence company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3CTNO">Agreement number</param>
		/// <param name="m3CTNA">Agreement number</param>
		/// <param name="m3MICD">Main individual item code</param>
		/// <param name="m3MINO">Main individual item number</param>
		/// <param name="m3CONS">Equipment</param>
		/// <param name="m3CFE1">User def 1</param>
		/// <param name="m3CFE2">User def 2</param>
		/// <param name="m3CFE3">User def 3</param>
		/// <param name="m3CFE4">User def 4</param>
		/// <param name="m3CFE5">User def 5</param>
		/// <param name="m3CFE6">User def 6</param>
		/// <param name="m3CFE7">User def 7</param>
		/// <param name="m3CFE8">User def 8</param>
		/// <param name="m3CFE9">User def 9</param>
		/// <param name="m3CFE0">User def 10</param>
		/// <param name="m3CFEA">User def 11</param>
		/// <param name="m3CFEB">User def 12</param>
		/// <param name="m3PINO">GUI picture</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3GDT3">Warranty date work shop</param>
		/// <param name="m3ISTR">Update individual item struct</param>
		/// <param name="m3IHIS">Update individual item history</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3MFNO">Manufactoring order number</param>
		/// <param name="m3REBE">Registration  number</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3LOCS">Location</param>
		/// <param name="m3DDAT">Date disposed</param>
		/// <param name="m3ASID">Fixed asset</param>
		/// <param name="m3SBNO">Sub number</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3FCTN">Function area</param>
		/// <param name="m3MEIT">Meter item</param>
		/// <param name="m3AGCN">Agreement customer</param>
		/// <param name="m3SERI">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdIndItem(
			string m3INNO, 
			int? m3CONO = null, 
			string m3CUOW = null, 
			string m3CUPL = null, 
			string m3ADID = null, 
			string m3ISTS = null, 
			string m3INGR = null, 
			string m3BANO = null, 
			string m3BRAN = null, 
			string m3INTY = null, 
			string m3MODE = null, 
			string m3MODC = null, 
			string m3TECH = null, 
			string m3SRES = null, 
			string m3ITGR = null, 
			DateTime? m3DEDA = null, 
			DateTime? m3REDA = null, 
			DateTime? m3INDA = null, 
			string m3AGRS = null, 
			string m3AGRR = null, 
			string m3DIVI = null, 
			string m3ITNO = null, 
			string m3NBID = null, 
			string m3TRAN = null, 
			string m3MLYR = null, 
			string m3AREA = null, 
			DateTime? m3GDT1 = null, 
			string m3CUGA = null, 
			DateTime? m3GDT2 = null, 
			string m3PROD = null, 
			string m3CUIC = null, 
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3CTNO = null, 
			string m3CTNA = null, 
			string m3MICD = null, 
			string m3MINO = null, 
			string m3CONS = null, 
			string m3CFE1 = null, 
			decimal? m3CFE2 = null, 
			string m3CFE3 = null, 
			string m3CFE4 = null, 
			string m3CFE5 = null, 
			string m3CFE6 = null, 
			decimal? m3CFE7 = null, 
			string m3CFE8 = null, 
			string m3CFE9 = null, 
			string m3CFE0 = null, 
			string m3CFEA = null, 
			string m3CFEB = null, 
			string m3PINO = null, 
			string m3DWNO = null, 
			DateTime? m3GDT3 = null, 
			string m3ISTR = null, 
			string m3IHIS = null, 
			string m3PUNO = null, 
			string m3PNLI = null, 
			string m3MFNO = null, 
			string m3REBE = null, 
			string m3RORN = null, 
			string m3RORC = null, 
			string m3RORL = null, 
			int? m3RORX = null, 
			string m3LOCS = null, 
			DateTime? m3DDAT = null, 
			string m3ASID = null, 
			string m3SBNO = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3FCTN = null, 
			string m3MEIT = null, 
			string m3AGCN = null, 
			string m3SERI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdIndItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3INNO))
				throw new ArgumentNullException(nameof(m3INNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUOW))
				request.WithQueryParameter("CUOW", m3CUOW.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISTS))
				request.WithQueryParameter("ISTS", m3ISTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3INGR))
				request.WithQueryParameter("INGR", m3INGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRAN))
				request.WithQueryParameter("BRAN", m3BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3INTY))
				request.WithQueryParameter("INTY", m3INTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODE))
				request.WithQueryParameter("MODE", m3MODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODC))
				request.WithQueryParameter("MODC", m3MODC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TECH))
				request.WithQueryParameter("TECH", m3TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITGR))
				request.WithQueryParameter("ITGR", m3ITGR.Trim());
			if (m3DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3DEDA.Value.ToM3String());
			if (m3REDA.HasValue)
				request.WithQueryParameter("REDA", m3REDA.Value.ToM3String());
			if (m3INDA.HasValue)
				request.WithQueryParameter("INDA", m3INDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3AGRS))
				request.WithQueryParameter("AGRS", m3AGRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRR))
				request.WithQueryParameter("AGRR", m3AGRR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NBID))
				request.WithQueryParameter("NBID", m3NBID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRAN))
				request.WithQueryParameter("TRAN", m3TRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3MLYR))
				request.WithQueryParameter("MLYR", m3MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AREA))
				request.WithQueryParameter("AREA", m3AREA.Trim());
			if (m3GDT1.HasValue)
				request.WithQueryParameter("GDT1", m3GDT1.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUGA))
				request.WithQueryParameter("CUGA", m3CUGA.Trim());
			if (m3GDT2.HasValue)
				request.WithQueryParameter("GDT2", m3GDT2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PROD))
				request.WithQueryParameter("PROD", m3PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUIC))
				request.WithQueryParameter("CUIC", m3CUIC.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNO))
				request.WithQueryParameter("CTNO", m3CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTNA))
				request.WithQueryParameter("CTNA", m3CTNA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MICD))
				request.WithQueryParameter("MICD", m3MICD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MINO))
				request.WithQueryParameter("MINO", m3MINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CONS))
				request.WithQueryParameter("CONS", m3CONS.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFE1))
				request.WithQueryParameter("CFE1", m3CFE1.Trim());
			if (m3CFE2.HasValue)
				request.WithQueryParameter("CFE2", m3CFE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFE3))
				request.WithQueryParameter("CFE3", m3CFE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFE4))
				request.WithQueryParameter("CFE4", m3CFE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFE5))
				request.WithQueryParameter("CFE5", m3CFE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFE6))
				request.WithQueryParameter("CFE6", m3CFE6.Trim());
			if (m3CFE7.HasValue)
				request.WithQueryParameter("CFE7", m3CFE7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFE8))
				request.WithQueryParameter("CFE8", m3CFE8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFE9))
				request.WithQueryParameter("CFE9", m3CFE9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFE0))
				request.WithQueryParameter("CFE0", m3CFE0.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFEA))
				request.WithQueryParameter("CFEA", m3CFEA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFEB))
				request.WithQueryParameter("CFEB", m3CFEB.Trim());
			if (!string.IsNullOrWhiteSpace(m3PINO))
				request.WithQueryParameter("PINO", m3PINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (m3GDT3.HasValue)
				request.WithQueryParameter("GDT3", m3GDT3.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ISTR))
				request.WithQueryParameter("ISTR", m3ISTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3IHIS))
				request.WithQueryParameter("IHIS", m3IHIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PNLI))
				request.WithQueryParameter("PNLI", m3PNLI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFNO))
				request.WithQueryParameter("MFNO", m3MFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3REBE))
				request.WithQueryParameter("REBE", m3REBE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORC))
				request.WithQueryParameter("RORC", m3RORC.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORL))
				request.WithQueryParameter("RORL", m3RORL.Trim());
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LOCS))
				request.WithQueryParameter("LOCS", m3LOCS.Trim());
			if (m3DDAT.HasValue)
				request.WithQueryParameter("DDAT", m3DDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ASID))
				request.WithQueryParameter("ASID", m3ASID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SBNO))
				request.WithQueryParameter("SBNO", m3SBNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCTN))
				request.WithQueryParameter("FCTN", m3FCTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEIT))
				request.WithQueryParameter("MEIT", m3MEIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGCN))
				request.WithQueryParameter("AGCN", m3AGCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERI))
				request.WithQueryParameter("SERI", m3SERI.Trim());

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
		/// Name UpdSOAddr
		/// Description Update SO address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3CUA1">Customer address 1</param>
		/// <param name="m3CUA2">Customer address 2</param>
		/// <param name="m3CUA3">Customer address 3</param>
		/// <param name="m3CUA4">Customer address 4</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3MEAL">Valid media</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3TAXC">Tax code</param>
		/// <param name="m3ECAR">Area/state</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSOAddr(
			string m3ORNO, 
			int m3ADRT, 
			int? m3CONO = null, 
			string m3ADID = null, 
			string m3CUNM = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3PONO = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3CSCD = null, 
			string m3MEAL = null, 
			long? m3GEOC = null, 
			string m3TAXC = null, 
			string m3ECAR = null, 
			string m3TOWN = null, 
			string m3FRCO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdSOAddr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
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
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MEAL))
				request.WithQueryParameter("MEAL", m3MEAL.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());

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
