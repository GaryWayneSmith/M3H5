/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddIndItem
		/// Description Add of individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUOW">Customer owner (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_TMPL">Template for indiviudual item</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="m3_CUPL">Customer location</param>
		/// <param name="m3_ADID">Address id</param>
		/// <param name="m3_ISTS">Individual item status</param>
		/// <param name="m3_INGR">Individual item group</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_INTY">Individual item type</param>
		/// <param name="m3_MODE">Model</param>
		/// <param name="m3_MODC">Model name</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_SRES">Service responsible</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_DEDA">Delivery date</param>
		/// <param name="m3_REDA">Receipt date</param>
		/// <param name="m3_INDA">Installation date</param>
		/// <param name="m3_AGRS">Contract item - service</param>
		/// <param name="m3_AGRR">Contract item - rental</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_NBID">Number series id</param>
		/// <param name="m3_MLYR">Year model</param>
		/// <param name="m3_AREA">Location description</param>
		/// <param name="m3_GDT1">Warranty date sales</param>
		/// <param name="m3_CUGA">General agent</param>
		/// <param name="m3_GDT2">Warranty date supplier</param>
		/// <param name="m3_PROD">Manufacturer</param>
		/// <param name="m3_CUIC">Customer number at insurence company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_MINO">Main individual item number</param>
		/// <param name="m3_CONS">Equipment</param>
		/// <param name="m3_CFE1">User def 1</param>
		/// <param name="m3_CFE2">User def 2</param>
		/// <param name="m3_CFE3">User def 3</param>
		/// <param name="m3_CFE4">User def 4</param>
		/// <param name="m3_CFE5">User def 5</param>
		/// <param name="m3_CFE6">User def 6</param>
		/// <param name="m3_CFE7">User def 7</param>
		/// <param name="m3_CFE8">User def 8</param>
		/// <param name="m3_CFE9">User def 9</param>
		/// <param name="m3_CFE0">User def 10</param>
		/// <param name="m3_CFEA">User def 11</param>
		/// <param name="m3_CFEB">User def 12</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_MFNO">Manufactoring order number</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_DDAT">Date disposed</param>
		/// <param name="m3_TYPR">Type of prefix</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_LOCS">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddIndItemResponse></returns>
		/// <exception cref="M3Exception<AddIndItemResponse>"></exception>
		public async Task<M3Response<AddIndItemResponse>> AddIndItem(
			string m3_CUOW, 
			int? m3_CONO = null, 
			string m3_TMPL = null, 
			string m3_INNO = null, 
			string m3_CUPL = null, 
			string m3_ADID = null, 
			string m3_ISTS = null, 
			string m3_INGR = null, 
			string m3_BANO = null, 
			string m3_BRAN = null, 
			string m3_INTY = null, 
			string m3_MODE = null, 
			string m3_MODC = null, 
			string m3_TECH = null, 
			string m3_SRES = null, 
			string m3_ITGR = null, 
			DateTime? m3_DEDA = null, 
			DateTime? m3_REDA = null, 
			DateTime? m3_INDA = null, 
			string m3_AGRS = null, 
			string m3_AGRR = null, 
			string m3_DIVI = null, 
			string m3_ITNO = null, 
			string m3_NBID = null, 
			string m3_MLYR = null, 
			string m3_AREA = null, 
			DateTime? m3_GDT1 = null, 
			string m3_CUGA = null, 
			DateTime? m3_GDT2 = null, 
			string m3_PROD = null, 
			string m3_CUIC = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_MINO = null, 
			string m3_CONS = null, 
			string m3_CFE1 = null, 
			decimal? m3_CFE2 = null, 
			string m3_CFE3 = null, 
			string m3_CFE4 = null, 
			string m3_CFE5 = null, 
			string m3_CFE6 = null, 
			decimal? m3_CFE7 = null, 
			string m3_CFE8 = null, 
			string m3_CFE9 = null, 
			string m3_CFE0 = null, 
			string m3_CFEA = null, 
			string m3_CFEB = null, 
			string m3_PUNO = null, 
			string m3_PNLI = null, 
			string m3_MFNO = null, 
			string m3_RORN = null, 
			string m3_RORC = null, 
			string m3_RORL = null, 
			int? m3_RORX = null, 
			DateTime? m3_DDAT = null, 
			int? m3_TYPR = null, 
			string m3_SERI = null, 
			string m3_LOCS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddIndItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUOW))
				throw new ArgumentNullException("m3_CUOW");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUOW", m3_CUOW.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TMPL))
				request.WithQueryParameter("TMPL", m3_TMPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISTS))
				request.WithQueryParameter("ISTS", m3_ISTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INGR))
				request.WithQueryParameter("INGR", m3_INGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INTY))
				request.WithQueryParameter("INTY", m3_INTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODE))
				request.WithQueryParameter("MODE", m3_MODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODC))
				request.WithQueryParameter("MODC", m3_MODC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (m3_DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3_DEDA.Value.ToM3String());
			if (m3_REDA.HasValue)
				request.WithQueryParameter("REDA", m3_REDA.Value.ToM3String());
			if (m3_INDA.HasValue)
				request.WithQueryParameter("INDA", m3_INDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_AGRS))
				request.WithQueryParameter("AGRS", m3_AGRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRR))
				request.WithQueryParameter("AGRR", m3_AGRR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NBID))
				request.WithQueryParameter("NBID", m3_NBID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MLYR))
				request.WithQueryParameter("MLYR", m3_MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AREA))
				request.WithQueryParameter("AREA", m3_AREA.Trim());
			if (m3_GDT1.HasValue)
				request.WithQueryParameter("GDT1", m3_GDT1.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUGA))
				request.WithQueryParameter("CUGA", m3_CUGA.Trim());
			if (m3_GDT2.HasValue)
				request.WithQueryParameter("GDT2", m3_GDT2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PROD))
				request.WithQueryParameter("PROD", m3_PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUIC))
				request.WithQueryParameter("CUIC", m3_CUIC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MINO))
				request.WithQueryParameter("MINO", m3_MINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CONS))
				request.WithQueryParameter("CONS", m3_CONS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFE1))
				request.WithQueryParameter("CFE1", m3_CFE1.Trim());
			if (m3_CFE2.HasValue)
				request.WithQueryParameter("CFE2", m3_CFE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFE3))
				request.WithQueryParameter("CFE3", m3_CFE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFE4))
				request.WithQueryParameter("CFE4", m3_CFE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFE5))
				request.WithQueryParameter("CFE5", m3_CFE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFE6))
				request.WithQueryParameter("CFE6", m3_CFE6.Trim());
			if (m3_CFE7.HasValue)
				request.WithQueryParameter("CFE7", m3_CFE7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFE8))
				request.WithQueryParameter("CFE8", m3_CFE8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFE9))
				request.WithQueryParameter("CFE9", m3_CFE9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFE0))
				request.WithQueryParameter("CFE0", m3_CFE0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFEA))
				request.WithQueryParameter("CFEA", m3_CFEA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFEB))
				request.WithQueryParameter("CFEB", m3_CFEB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PNLI))
				request.WithQueryParameter("PNLI", m3_PNLI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORC))
				request.WithQueryParameter("RORC", m3_RORC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORL))
				request.WithQueryParameter("RORL", m3_RORL.Trim());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (m3_DDAT.HasValue)
				request.WithQueryParameter("DDAT", m3_DDAT.Value.ToM3String());
			if (m3_TYPR.HasValue)
				request.WithQueryParameter("TYPR", m3_TYPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LOCS))
				request.WithQueryParameter("LOCS", m3_LOCS.Trim());

			// Execute the request
			var result = await Execute<AddIndItemResponse>(
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
		/// Name AddLine
		/// Description Create a new service order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_JOBN">Assignment number (Required)</param>
		/// <param name="m3_JBSX">Assignment suffix (Required)</param>
		/// <param name="m3_ITNO">Item number or service expense number (Required)</param>
		/// <param name="m3_ORQT">Order quantity (Required)</param>
		/// <param name="m3_YYYY">Error message (0=No set sts to 11,1=Yes) (Required)</param>
		/// <param name="m3_XXXX">Allocation directly (0=No, 1=Yes) (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ADTY">Addess type (1=Whs,2=Cust)</param>
		/// <param name="m3_FWHL">From warehouse</param>
		/// <param name="m3_PLSD">Planned start date</param>
		/// <param name="m3_LTYP">Line type</param>
		/// <param name="m3_PLST">Planned start time</param>
		/// <param name="m3_DBCO">Payer control</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_ITDS">Name (item or service expense name)</param>
		/// <param name="m3_STCD">Inventory accounting</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_REAL">Realocation</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLineResponse></returns>
		/// <exception cref="M3Exception<AddLineResponse>"></exception>
		public async Task<M3Response<AddLineResponse>> AddLine(
			string m3_ORNO, 
			int m3_JOBN, 
			int m3_JBSX, 
			string m3_ITNO, 
			decimal m3_ORQT, 
			string m3_YYYY, 
			string m3_XXXX, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			int? m3_ADTY = null, 
			string m3_FWHL = null, 
			DateTime? m3_PLSD = null, 
			int? m3_LTYP = null, 
			int? m3_PLST = null, 
			string m3_DBCO = null, 
			string m3_PYNO = null, 
			decimal? m3_SAPR = null, 
			string m3_SUNO = null, 
			string m3_ITDS = null, 
			int? m3_STCD = null, 
			string m3_TECH = null, 
			int? m3_REAL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_YYYY))
				throw new ArgumentNullException("m3_YYYY");
			if (string.IsNullOrWhiteSpace(m3_XXXX))
				throw new ArgumentNullException("m3_XXXX");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("JBSX", m3_JBSX.ToString())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ORQT", m3_ORQT.ToString())
				.WithQueryParameter("YYYY", m3_YYYY.Trim())
				.WithQueryParameter("XXXX", m3_XXXX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_ADTY.HasValue)
				request.WithQueryParameter("ADTY", m3_ADTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWHL))
				request.WithQueryParameter("FWHL", m3_FWHL.Trim());
			if (m3_PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3_PLSD.Value.ToM3String());
			if (m3_LTYP.HasValue)
				request.WithQueryParameter("LTYP", m3_LTYP.Value.ToString());
			if (m3_PLST.HasValue)
				request.WithQueryParameter("PLST", m3_PLST.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DBCO))
				request.WithQueryParameter("DBCO", m3_DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (m3_STCD.HasValue)
				request.WithQueryParameter("STCD", m3_STCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (m3_REAL.HasValue)
				request.WithQueryParameter("REAL", m3_REAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());

			// Execute the request
			var result = await Execute<AddLineResponse>(
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
		/// Name AddMtrReading
		/// Description Create new meter reading
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INNO">Individual item number (Required)</param>
		/// <param name="m3_MEEV">Meter event (Required)</param>
		/// <param name="m3_MEEN">Meter entry source (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_EVDT">Meter reading date</param>
		/// <param name="m3_EVTM">Meter reading time</param>
		/// <param name="m3_RESP">Resonsible</param>
		/// <param name="m3_AMV1">Meter reading 1</param>
		/// <param name="m3_AMV2">Meter reading 2</param>
		/// <param name="m3_AMV3">Meter reading 3</param>
		/// <param name="m3_AMV4">Meter reading 4</param>
		/// <param name="m3_AMV5">Meter reading 5</param>
		/// <param name="m3_AMV6">Meter reading 6</param>
		/// <param name="m3_AMC1">Credits 1</param>
		/// <param name="m3_AMC2">Credits 2</param>
		/// <param name="m3_AMC3">Credits 3</param>
		/// <param name="m3_AMC4">Credits 4</param>
		/// <param name="m3_AMC5">Credits 5</param>
		/// <param name="m3_AMC6">Credits 6</param>
		/// <param name="m3_AMF1">Free units 1</param>
		/// <param name="m3_AMF2">Free units 2</param>
		/// <param name="m3_AMF3">Free units 3</param>
		/// <param name="m3_AMF4">Free units 4</param>
		/// <param name="m3_AMF5">Free units 5</param>
		/// <param name="m3_AMF6">Free units 6</param>
		/// <param name="m3_TX30">Text</param>
		/// <param name="m3_CHK1">Chk deviation</param>
		/// <param name="m3_CHK2">Chk lower value</param>
		/// <param name="m3_ORNO">Service order number</param>
		/// <param name="m3_JOBN">Assignment number</param>
		/// <param name="m3_JBXS">Assignment suffix</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMtrReading(
			string m3_INNO, 
			string m3_MEEV, 
			string m3_MEEN, 
			int? m3_CONO = null, 
			DateTime? m3_EVDT = null, 
			int? m3_EVTM = null, 
			string m3_RESP = null, 
			long? m3_AMV1 = null, 
			long? m3_AMV2 = null, 
			long? m3_AMV3 = null, 
			long? m3_AMV4 = null, 
			long? m3_AMV5 = null, 
			long? m3_AMV6 = null, 
			long? m3_AMC1 = null, 
			long? m3_AMC2 = null, 
			long? m3_AMC3 = null, 
			long? m3_AMC4 = null, 
			long? m3_AMC5 = null, 
			long? m3_AMC6 = null, 
			long? m3_AMF1 = null, 
			long? m3_AMF2 = null, 
			long? m3_AMF3 = null, 
			long? m3_AMF4 = null, 
			long? m3_AMF5 = null, 
			long? m3_AMF6 = null, 
			string m3_TX30 = null, 
			int? m3_CHK1 = null, 
			int? m3_CHK2 = null, 
			string m3_ORNO = null, 
			int? m3_JOBN = null, 
			int? m3_JBXS = null, 
			string m3_EMNO = null, 
			string m3_TECH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMtrReading",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_INNO))
				throw new ArgumentNullException("m3_INNO");
			if (string.IsNullOrWhiteSpace(m3_MEEV))
				throw new ArgumentNullException("m3_MEEV");
			if (string.IsNullOrWhiteSpace(m3_MEEN))
				throw new ArgumentNullException("m3_MEEN");

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3_INNO.Trim())
				.WithQueryParameter("MEEV", m3_MEEV.Trim())
				.WithQueryParameter("MEEN", m3_MEEN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_EVDT.HasValue)
				request.WithQueryParameter("EVDT", m3_EVDT.Value.ToM3String());
			if (m3_EVTM.HasValue)
				request.WithQueryParameter("EVTM", m3_EVTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_AMV1.HasValue)
				request.WithQueryParameter("AMV1", m3_AMV1.Value.ToString());
			if (m3_AMV2.HasValue)
				request.WithQueryParameter("AMV2", m3_AMV2.Value.ToString());
			if (m3_AMV3.HasValue)
				request.WithQueryParameter("AMV3", m3_AMV3.Value.ToString());
			if (m3_AMV4.HasValue)
				request.WithQueryParameter("AMV4", m3_AMV4.Value.ToString());
			if (m3_AMV5.HasValue)
				request.WithQueryParameter("AMV5", m3_AMV5.Value.ToString());
			if (m3_AMV6.HasValue)
				request.WithQueryParameter("AMV6", m3_AMV6.Value.ToString());
			if (m3_AMC1.HasValue)
				request.WithQueryParameter("AMC1", m3_AMC1.Value.ToString());
			if (m3_AMC2.HasValue)
				request.WithQueryParameter("AMC2", m3_AMC2.Value.ToString());
			if (m3_AMC3.HasValue)
				request.WithQueryParameter("AMC3", m3_AMC3.Value.ToString());
			if (m3_AMC4.HasValue)
				request.WithQueryParameter("AMC4", m3_AMC4.Value.ToString());
			if (m3_AMC5.HasValue)
				request.WithQueryParameter("AMC5", m3_AMC5.Value.ToString());
			if (m3_AMC6.HasValue)
				request.WithQueryParameter("AMC6", m3_AMC6.Value.ToString());
			if (m3_AMF1.HasValue)
				request.WithQueryParameter("AMF1", m3_AMF1.Value.ToString());
			if (m3_AMF2.HasValue)
				request.WithQueryParameter("AMF2", m3_AMF2.Value.ToString());
			if (m3_AMF3.HasValue)
				request.WithQueryParameter("AMF3", m3_AMF3.Value.ToString());
			if (m3_AMF4.HasValue)
				request.WithQueryParameter("AMF4", m3_AMF4.Value.ToString());
			if (m3_AMF5.HasValue)
				request.WithQueryParameter("AMF5", m3_AMF5.Value.ToString());
			if (m3_AMF6.HasValue)
				request.WithQueryParameter("AMF6", m3_AMF6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX30))
				request.WithQueryParameter("TX30", m3_TX30.Trim());
			if (m3_CHK1.HasValue)
				request.WithQueryParameter("CHK1", m3_CHK1.Value.ToString());
			if (m3_CHK2.HasValue)
				request.WithQueryParameter("CHK2", m3_CHK2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3_JOBN.Value.ToString());
			if (m3_JBXS.HasValue)
				request.WithQueryParameter("JBXS", m3_JBXS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());

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
		/// Name AddServOrd
		/// Description Add service order head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INNO">Individual item number (Required)</param>
		/// <param name="m3_SOTP">Service order type (Required)</param>
		/// <param name="m3_ESCO">Error symptom code (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Element</param>
		/// <param name="m3_SRES">Service Manager</param>
		/// <param name="m3_TECH">Technichian</param>
		/// <param name="m3_ORNO">Service order number</param>
		/// <param name="m3_PSDJ">Planned start date assignment</param>
		/// <param name="m3_PSTJ">Planned start time assignment</param>
		/// <param name="m3_WOTM">Forcast work hours</param>
		/// <param name="m3_WARR">Warranty (Yes/No)</param>
		/// <param name="m3_CONF">Confirmation docoment (Yes/No)</param>
		/// <param name="m3_CNDI">Condition</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_TEXT">Error Text 4*60</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_OREF">Our reference</param>
		/// <param name="m3_PRS1">Price list SO</param>
		/// <param name="m3_TXAP">Tax applicable</param>
		/// <param name="m3_DLRM">Remark</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_JBST">Status service assignment</param>
		/// <param name="m3_JBSE">Additional status</param>
		/// <param name="m3_ASST">Assignment type</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_DBCO">Payer control</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_SVID">Service expense</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_ROLE">Role/organizational position</param>
		/// <param name="m3_ECLC">Labor code - trade statistics (TST)</param>
		/// <param name="m3_VRCD">Business type - trade statistics (TST)</param>
		/// <param name="m3_RONO">Run</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_SDST">District</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddServOrdResponse></returns>
		/// <exception cref="M3Exception<AddServOrdResponse>"></exception>
		public async Task<M3Response<AddServOrdResponse>> AddServOrd(
			string m3_INNO, 
			string m3_SOTP, 
			string m3_ESCO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_SRES = null, 
			string m3_TECH = null, 
			string m3_ORNO = null, 
			int? m3_PSDJ = null, 
			int? m3_PSTJ = null, 
			int? m3_WOTM = null, 
			int? m3_WARR = null, 
			int? m3_CONF = null, 
			string m3_CNDI = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_TEXT = null, 
			string m3_CUPL = null, 
			string m3_YREF = null, 
			string m3_PHNO = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEPY = null, 
			string m3_PYNO = null, 
			string m3_OREF = null, 
			string m3_PRS1 = null, 
			int? m3_TXAP = null, 
			string m3_DLRM = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_TFNO = null, 
			string m3_JBST = null, 
			string m3_JBSE = null, 
			string m3_ASST = null, 
			string m3_CUOR = null, 
			string m3_DBCO = null, 
			string m3_CTNO = null, 
			string m3_SVID = null, 
			string m3_SUFI = null, 
			string m3_ROLE = null, 
			string m3_ECLC = null, 
			string m3_VRCD = null, 
			string m3_RONO = null, 
			string m3_SMCD = null, 
			string m3_SDST = null, 
			string m3_ADID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddServOrd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_INNO))
				throw new ArgumentNullException("m3_INNO");
			if (string.IsNullOrWhiteSpace(m3_SOTP))
				throw new ArgumentNullException("m3_SOTP");
			if (string.IsNullOrWhiteSpace(m3_ESCO))
				throw new ArgumentNullException("m3_ESCO");

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3_INNO.Trim())
				.WithQueryParameter("SOTP", m3_SOTP.Trim())
				.WithQueryParameter("ESCO", m3_ESCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_PSDJ.HasValue)
				request.WithQueryParameter("PSDJ", m3_PSDJ.Value.ToString());
			if (m3_PSTJ.HasValue)
				request.WithQueryParameter("PSTJ", m3_PSTJ.Value.ToString());
			if (m3_WOTM.HasValue)
				request.WithQueryParameter("WOTM", m3_WOTM.Value.ToString());
			if (m3_WARR.HasValue)
				request.WithQueryParameter("WARR", m3_WARR.Value.ToString());
			if (m3_CONF.HasValue)
				request.WithQueryParameter("CONF", m3_CONF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CNDI))
				request.WithQueryParameter("CNDI", m3_CNDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEXT))
				request.WithQueryParameter("TEXT", m3_TEXT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OREF))
				request.WithQueryParameter("OREF", m3_OREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRS1))
				request.WithQueryParameter("PRS1", m3_PRS1.Trim());
			if (m3_TXAP.HasValue)
				request.WithQueryParameter("TXAP", m3_TXAP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DLRM))
				request.WithQueryParameter("DLRM", m3_DLRM.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JBST))
				request.WithQueryParameter("JBST", m3_JBST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JBSE))
				request.WithQueryParameter("JBSE", m3_JBSE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASST))
				request.WithQueryParameter("ASST", m3_ASST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DBCO))
				request.WithQueryParameter("DBCO", m3_DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SVID))
				request.WithQueryParameter("SVID", m3_SVID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROLE))
				request.WithQueryParameter("ROLE", m3_ROLE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECLC))
				request.WithQueryParameter("ECLC", m3_ECLC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRCD))
				request.WithQueryParameter("VRCD", m3_VRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RONO))
				request.WithQueryParameter("RONO", m3_RONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SDST))
				request.WithQueryParameter("SDST", m3_SDST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());

			// Execute the request
			var result = await Execute<AddServOrdResponse>(
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
		/// Name ChgAssignm
		/// Description Change contents of service assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_JOBN">Assignment number (Required)</param>
		/// <param name="m3_JBSX">Assignment suffix (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_ESCO">Error symptom code</param>
		/// <param name="m3_ETX1">Error symptom text 1</param>
		/// <param name="m3_ETX2">Error symptom text 2</param>
		/// <param name="m3_ETX3">Error symptom text 3</param>
		/// <param name="m3_ETX4">Error symptom text 4</param>
		/// <param name="m3_DBCO">Payer control</param>
		/// <param name="m3_OPRI">Priority</param>
		/// <param name="m3_ASST">Assignment type</param>
		/// <param name="m3_WOTM">Forecasted work hours</param>
		/// <param name="m3_QUNO">Qualification</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_JBST">Assignment status</param>
		/// <param name="m3_PMDT">Error report date</param>
		/// <param name="m3_PMTM">Error report time</param>
		/// <param name="m3_SSDT">Last start date</param>
		/// <param name="m3_SSTM">Last start time</param>
		/// <param name="m3_PSDJ">Planned start date assignment</param>
		/// <param name="m3_PSTJ">Planned start time assignment</param>
		/// <param name="m3_PSDW">Planned start date task</param>
		/// <param name="m3_PSTW">Planned start time task</param>
		/// <param name="m3_PFDJ">Planned finish date assignment</param>
		/// <param name="m3_PFTJ">Planned finish time assignment</param>
		/// <param name="m3_PFDW">Planned finish date task</param>
		/// <param name="m3_PFTW">Planned finish time task</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_ERCO">Error cause</param>
		/// <param name="m3_MECO">Action code</param>
		/// <param name="m3_MTCO">Action text code</param>
		/// <param name="m3_MTX1">Action text 1</param>
		/// <param name="m3_MTX2">Action text 2</param>
		/// <param name="m3_MTX3">Action text 3</param>
		/// <param name="m3_MTX4">Action text 4</param>
		/// <param name="m3_JBSE">Additional status</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_SVID">Service expense</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_ROLE">Role/organizational position</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAssignm(
			string m3_ORNO, 
			int m3_JOBN, 
			int m3_JBSX, 
			int? m3_CONO = null, 
			string m3_ESCO = null, 
			string m3_ETX1 = null, 
			string m3_ETX2 = null, 
			string m3_ETX3 = null, 
			string m3_ETX4 = null, 
			string m3_DBCO = null, 
			int? m3_OPRI = null, 
			string m3_ASST = null, 
			int? m3_WOTM = null, 
			string m3_QUNO = null, 
			string m3_SRES = null, 
			string m3_TECH = null, 
			string m3_JBST = null, 
			DateTime? m3_PMDT = null, 
			int? m3_PMTM = null, 
			DateTime? m3_SSDT = null, 
			int? m3_SSTM = null, 
			DateTime? m3_PSDJ = null, 
			int? m3_PSTJ = null, 
			DateTime? m3_PSDW = null, 
			int? m3_PSTW = null, 
			DateTime? m3_PFDJ = null, 
			int? m3_PFTJ = null, 
			DateTime? m3_PFDW = null, 
			int? m3_PFTW = null, 
			string m3_CTNO = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_ERCO = null, 
			string m3_MECO = null, 
			string m3_MTCO = null, 
			string m3_MTX1 = null, 
			string m3_MTX2 = null, 
			string m3_MTX3 = null, 
			string m3_MTX4 = null, 
			int? m3_JBSE = null, 
			string m3_CUOR = null, 
			string m3_SVID = null, 
			string m3_SUFI = null, 
			string m3_ROLE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgAssignm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("JBSX", m3_JBSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ESCO))
				request.WithQueryParameter("ESCO", m3_ESCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX1))
				request.WithQueryParameter("ETX1", m3_ETX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX2))
				request.WithQueryParameter("ETX2", m3_ETX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX3))
				request.WithQueryParameter("ETX3", m3_ETX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX4))
				request.WithQueryParameter("ETX4", m3_ETX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DBCO))
				request.WithQueryParameter("DBCO", m3_DBCO.Trim());
			if (m3_OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3_OPRI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ASST))
				request.WithQueryParameter("ASST", m3_ASST.Trim());
			if (m3_WOTM.HasValue)
				request.WithQueryParameter("WOTM", m3_WOTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QUNO))
				request.WithQueryParameter("QUNO", m3_QUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JBST))
				request.WithQueryParameter("JBST", m3_JBST.Trim());
			if (m3_PMDT.HasValue)
				request.WithQueryParameter("PMDT", m3_PMDT.Value.ToM3String());
			if (m3_PMTM.HasValue)
				request.WithQueryParameter("PMTM", m3_PMTM.Value.ToString());
			if (m3_SSDT.HasValue)
				request.WithQueryParameter("SSDT", m3_SSDT.Value.ToM3String());
			if (m3_SSTM.HasValue)
				request.WithQueryParameter("SSTM", m3_SSTM.Value.ToString());
			if (m3_PSDJ.HasValue)
				request.WithQueryParameter("PSDJ", m3_PSDJ.Value.ToM3String());
			if (m3_PSTJ.HasValue)
				request.WithQueryParameter("PSTJ", m3_PSTJ.Value.ToString());
			if (m3_PSDW.HasValue)
				request.WithQueryParameter("PSDW", m3_PSDW.Value.ToM3String());
			if (m3_PSTW.HasValue)
				request.WithQueryParameter("PSTW", m3_PSTW.Value.ToString());
			if (m3_PFDJ.HasValue)
				request.WithQueryParameter("PFDJ", m3_PFDJ.Value.ToM3String());
			if (m3_PFTJ.HasValue)
				request.WithQueryParameter("PFTJ", m3_PFTJ.Value.ToString());
			if (m3_PFDW.HasValue)
				request.WithQueryParameter("PFDW", m3_PFDW.Value.ToM3String());
			if (m3_PFTW.HasValue)
				request.WithQueryParameter("PFTW", m3_PFTW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ERCO))
				request.WithQueryParameter("ERCO", m3_ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MECO))
				request.WithQueryParameter("MECO", m3_MECO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTCO))
				request.WithQueryParameter("MTCO", m3_MTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX1))
				request.WithQueryParameter("MTX1", m3_MTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX2))
				request.WithQueryParameter("MTX2", m3_MTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX3))
				request.WithQueryParameter("MTX3", m3_MTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX4))
				request.WithQueryParameter("MTX4", m3_MTX4.Trim());
			if (m3_JBSE.HasValue)
				request.WithQueryParameter("JBSE", m3_JBSE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SVID))
				request.WithQueryParameter("SVID", m3_SVID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROLE))
				request.WithQueryParameter("ROLE", m3_ROLE.Trim());

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
		/// Name ChgAssignmSts
		/// Description Change assignment status and/or dates
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_JOBN">Assignment number (Required)</param>
		/// <param name="m3_JBSX">Assignment suffix (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_JBST">Assignment status</param>
		/// <param name="m3_PSDJ">Planned start date assignment</param>
		/// <param name="m3_PSTJ">Planned start time assignment</param>
		/// <param name="m3_PFDJ">Planned finish date assignment</param>
		/// <param name="m3_PFTJ">Planned finish time assignment</param>
		/// <param name="m3_RSDJ">Actual start date assignment</param>
		/// <param name="m3_RSTJ">Actual start time assignment</param>
		/// <param name="m3_RSDW">Actual start date task</param>
		/// <param name="m3_RSTW">Actual start time task</param>
		/// <param name="m3_RFDJ">Actual finish date assignment</param>
		/// <param name="m3_RFTJ">Actual finish time assignment</param>
		/// <param name="m3_RFDW">Actual finish date task</param>
		/// <param name="m3_RFTW">Actual finish time task</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_TECH">Techinician</param>
		/// <param name="m3_JBSE">Additional status</param>
		/// <param name="m3_ASST">Assignment type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAssignmSts(
			string m3_ORNO, 
			int m3_JOBN, 
			int m3_JBSX, 
			int? m3_CONO = null, 
			string m3_JBST = null, 
			DateTime? m3_PSDJ = null, 
			int? m3_PSTJ = null, 
			DateTime? m3_PFDJ = null, 
			int? m3_PFTJ = null, 
			DateTime? m3_RSDJ = null, 
			int? m3_RSTJ = null, 
			DateTime? m3_RSDW = null, 
			int? m3_RSTW = null, 
			DateTime? m3_RFDJ = null, 
			int? m3_RFTJ = null, 
			DateTime? m3_RFDW = null, 
			int? m3_RFTW = null, 
			string m3_SRES = null, 
			string m3_TECH = null, 
			string m3_JBSE = null, 
			string m3_ASST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgAssignmSts",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("JBSX", m3_JBSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_JBST))
				request.WithQueryParameter("JBST", m3_JBST.Trim());
			if (m3_PSDJ.HasValue)
				request.WithQueryParameter("PSDJ", m3_PSDJ.Value.ToM3String());
			if (m3_PSTJ.HasValue)
				request.WithQueryParameter("PSTJ", m3_PSTJ.Value.ToString());
			if (m3_PFDJ.HasValue)
				request.WithQueryParameter("PFDJ", m3_PFDJ.Value.ToM3String());
			if (m3_PFTJ.HasValue)
				request.WithQueryParameter("PFTJ", m3_PFTJ.Value.ToString());
			if (m3_RSDJ.HasValue)
				request.WithQueryParameter("RSDJ", m3_RSDJ.Value.ToM3String());
			if (m3_RSTJ.HasValue)
				request.WithQueryParameter("RSTJ", m3_RSTJ.Value.ToString());
			if (m3_RSDW.HasValue)
				request.WithQueryParameter("RSDW", m3_RSDW.Value.ToM3String());
			if (m3_RSTW.HasValue)
				request.WithQueryParameter("RSTW", m3_RSTW.Value.ToString());
			if (m3_RFDJ.HasValue)
				request.WithQueryParameter("RFDJ", m3_RFDJ.Value.ToM3String());
			if (m3_RFTJ.HasValue)
				request.WithQueryParameter("RFTJ", m3_RFTJ.Value.ToString());
			if (m3_RFDW.HasValue)
				request.WithQueryParameter("RFDW", m3_RFDW.Value.ToM3String());
			if (m3_RFTW.HasValue)
				request.WithQueryParameter("RFTW", m3_RFTW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JBSE))
				request.WithQueryParameter("JBSE", m3_JBSE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASST))
				request.WithQueryParameter("ASST", m3_ASST.Trim());

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
		/// Name ChgLine
		/// Description Change contents of a service order line
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_JOBN">Assignment number (Required)</param>
		/// <param name="m3_JBSX">Assignment suffix (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_POSX">Line suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORQT">Order quantity</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_UCOS">Cost price</param>
		/// <param name="m3_RAQT">Reported quantity</param>
		/// <param name="m3_ITDS">Name (item or service expense name)</param>
		/// <param name="m3_PLSD">Planned start date</param>
		/// <param name="m3_PLST">Planned start time</param>
		/// <param name="m3_PLFD">Planned finish date</param>
		/// <param name="m3_PLFT">Planned finish time</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_CFF1">User-defined field 1 - service expense</param>
		/// <param name="m3_CFF2">User-defined field 2 - service expense</param>
		/// <param name="m3_CFF3">User-defined field 3 - service expense</param>
		/// <param name="m3_CFF4">User-defined field 4 - service expense</param>
		/// <param name="m3_CFF5">User-defined field 5 - service expense</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgLine(
			string m3_ORNO, 
			int m3_JOBN, 
			int m3_JBSX, 
			int m3_PONR, 
			int m3_POSX, 
			int? m3_CONO = null, 
			decimal? m3_ORQT = null, 
			string m3_PYNO = null, 
			decimal? m3_SAPR = null, 
			decimal? m3_UCOS = null, 
			decimal? m3_RAQT = null, 
			string m3_ITDS = null, 
			DateTime? m3_PLSD = null, 
			int? m3_PLST = null, 
			DateTime? m3_PLFD = null, 
			int? m3_PLFT = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_CFF1 = null, 
			decimal? m3_CFF2 = null, 
			string m3_CFF3 = null, 
			string m3_CFF4 = null, 
			string m3_CFF5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("JBSX", m3_JBSX.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("POSX", m3_POSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_UCOS.HasValue)
				request.WithQueryParameter("UCOS", m3_UCOS.Value.ToString());
			if (m3_RAQT.HasValue)
				request.WithQueryParameter("RAQT", m3_RAQT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (m3_PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3_PLSD.Value.ToM3String());
			if (m3_PLST.HasValue)
				request.WithQueryParameter("PLST", m3_PLST.Value.ToString());
			if (m3_PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3_PLFD.Value.ToM3String());
			if (m3_PLFT.HasValue)
				request.WithQueryParameter("PLFT", m3_PLFT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFF1))
				request.WithQueryParameter("CFF1", m3_CFF1.Trim());
			if (m3_CFF2.HasValue)
				request.WithQueryParameter("CFF2", m3_CFF2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFF3))
				request.WithQueryParameter("CFF3", m3_CFF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFF4))
				request.WithQueryParameter("CFF4", m3_CFF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFF5))
				request.WithQueryParameter("CFF5", m3_CFF5.Trim());

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
		/// Name CompleteAssignm
		/// Description Complete the assignment and make it ready for invoicing
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_JOBN">Assignment number (Required)</param>
		/// <param name="m3_JBSX">Assignment suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_OEND">Finish marked</param>
		/// <param name="m3_RSDJ">Actual start date assignment</param>
		/// <param name="m3_RSTJ">Actual start time assignment</param>
		/// <param name="m3_RSDW">Actual start date task</param>
		/// <param name="m3_RSTW">Actual start time task</param>
		/// <param name="m3_RFDJ">Actual finish date assignment</param>
		/// <param name="m3_RFTJ">Actual finish time assignment</param>
		/// <param name="m3_RFDW">Actual finish date task</param>
		/// <param name="m3_RFTW">Actual finish time task</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CompleteAssignmResponse></returns>
		/// <exception cref="M3Exception<CompleteAssignmResponse>"></exception>
		public async Task<M3Response<CompleteAssignmResponse>> CompleteAssignm(
			string m3_ORNO, 
			int m3_JOBN, 
			int m3_JBSX, 
			int? m3_CONO = null, 
			int? m3_OEND = null, 
			DateTime? m3_RSDJ = null, 
			int? m3_RSTJ = null, 
			DateTime? m3_RSDW = null, 
			int? m3_RSTW = null, 
			DateTime? m3_RFDJ = null, 
			int? m3_RFTJ = null, 
			DateTime? m3_RFDW = null, 
			int? m3_RFTW = null, 
			string m3_TWSL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CompleteAssignm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("JBSX", m3_JBSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_RSDJ.HasValue)
				request.WithQueryParameter("RSDJ", m3_RSDJ.Value.ToM3String());
			if (m3_RSTJ.HasValue)
				request.WithQueryParameter("RSTJ", m3_RSTJ.Value.ToString());
			if (m3_RSDW.HasValue)
				request.WithQueryParameter("RSDW", m3_RSDW.Value.ToM3String());
			if (m3_RSTW.HasValue)
				request.WithQueryParameter("RSTW", m3_RSTW.Value.ToString());
			if (m3_RFDJ.HasValue)
				request.WithQueryParameter("RFDJ", m3_RFDJ.Value.ToM3String());
			if (m3_RFTJ.HasValue)
				request.WithQueryParameter("RFTJ", m3_RFTJ.Value.ToString());
			if (m3_RFDW.HasValue)
				request.WithQueryParameter("RFDW", m3_RFDW.Value.ToM3String());
			if (m3_RFTW.HasValue)
				request.WithQueryParameter("RFTW", m3_RFTW.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());

			// Execute the request
			var result = await Execute<CompleteAssignmResponse>(
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
		/// Name DelLine
		/// Description Delete service order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_JOBN">Assignment number (Required)</param>
		/// <param name="m3_JBSX">Assignment suffix (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLine(
			string m3_ORNO, 
			int m3_JOBN, 
			int m3_JBSX, 
			int m3_PONR, 
			int? m3_CONO = null, 
			int? m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("JBSX", m3_JBSX.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

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
		/// Name GetAgrInfo
		/// Description Retrieve agreement information per individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INNO">Individual item (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrInfoResponse></returns>
		/// <exception cref="M3Exception<GetAgrInfoResponse>"></exception>
		public async Task<M3Response<GetAgrInfoResponse>> GetAgrInfo(
			string m3_INNO, 
			int? m3_CONO = null, 
			string m3_CTNO = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAgrInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_INNO))
				throw new ArgumentNullException("m3_INNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3_INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<GetAgrInfoResponse>(
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
		/// Name GetAssignm
		/// Description Retrieve assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_JOBN">Assignment number (Required)</param>
		/// <param name="m3_JBSX">Assignment suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAssignmResponse></returns>
		/// <exception cref="M3Exception<GetAssignmResponse>"></exception>
		public async Task<M3Response<GetAssignmResponse>> GetAssignm(
			string m3_ORNO, 
			int m3_JOBN, 
			int m3_JBSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAssignm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("JBSX", m3_JBSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetAssignmResponse>(
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
		/// Name GetCurrency
		/// Description Get currency
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCurrencyResponse></returns>
		/// <exception cref="M3Exception<GetCurrencyResponse>"></exception>
		public async Task<M3Response<GetCurrencyResponse>> GetCurrency(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCurrency",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetCurrencyResponse>(
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
		/// Name GetHead
		/// Description Retrieve service order head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetIndividual
		/// Description Get individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INNO">Individual item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetIndividualResponse></returns>
		/// <exception cref="M3Exception<GetIndividualResponse>"></exception>
		public async Task<M3Response<GetIndividualResponse>> GetIndividual(
			string m3_INNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetIndividual",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_INNO))
				throw new ArgumentNullException("m3_INNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3_INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetIndividualResponse>(
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
		/// Name GetMtrByInd
		/// Description Get all meters per individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INNO">Individual item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMtrByIndResponse></returns>
		/// <exception cref="M3Exception<GetMtrByIndResponse>"></exception>
		public async Task<M3Response<GetMtrByIndResponse>> GetMtrByInd(
			string m3_INNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMtrByInd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_INNO))
				throw new ArgumentNullException("m3_INNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3_INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetMtrByIndResponse>(
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
		/// Name GetSoAddress
		/// Description Retrieve SO address information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSoAddressResponse></returns>
		/// <exception cref="M3Exception<GetSoAddressResponse>"></exception>
		public async Task<M3Response<GetSoAddressResponse>> GetSoAddress(
			string m3_ORNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSoAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetSoAddressResponse>(
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
		/// Name GetUsrInfo
		/// Description Retrieve user information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_USID">User ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUsrInfoResponse></returns>
		/// <exception cref="M3Exception<GetUsrInfoResponse>"></exception>
		public async Task<M3Response<GetUsrInfoResponse>> GetUsrInfo(
			string m3_USID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetUsrInfo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<GetUsrInfoResponse>(
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
		/// Name LstActTxt
		/// Description List action texts
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MTCO">Action text</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstActTxtResponse></returns>
		/// <exception cref="M3Exception<LstActTxtResponse>"></exception>
		public async Task<M3Response<LstActTxtResponse>> LstActTxt(
			int? m3_CONO = null, 
			string m3_MTCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstActTxt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTCO))
				request.WithQueryParameter("MTCO", m3_MTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstActTxtResponse>(
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
		/// Name LstAction
		/// Description List action
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MECO">Action code</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstActionResponse></returns>
		/// <exception cref="M3Exception<LstActionResponse>"></exception>
		public async Task<M3Response<LstActionResponse>> LstAction(
			int? m3_CONO = null, 
			string m3_MECO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAction",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MECO))
				request.WithQueryParameter("MECO", m3_MECO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstActionResponse>(
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
		/// Name LstAgrPerIndiv
		/// Description List all agreement lines per individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ALLI">Display all lines</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrPerIndivResponse></returns>
		/// <exception cref="M3Exception<LstAgrPerIndivResponse>"></exception>
		public async Task<M3Response<LstAgrPerIndivResponse>> LstAgrPerIndiv(
			int? m3_CONO = null, 
			string m3_INNO = null, 
			string m3_CTNO = null, 
			string m3_CUPL = null, 
			string m3_ADID = null, 
			int? m3_ALLI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrPerIndiv",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_ALLI.HasValue)
				request.WithQueryParameter("ALLI", m3_ALLI.Value.ToString());

			// Execute the request
			var result = await Execute<LstAgrPerIndivResponse>(
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
		/// Name LstAgrTpContent
		/// Description List the content of an agreement type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_AGTP">Agreement type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrTpContentResponse></returns>
		/// <exception cref="M3Exception<LstAgrTpContentResponse>"></exception>
		public async Task<M3Response<LstAgrTpContentResponse>> LstAgrTpContent(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_AGTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgrTpContent",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGTP))
				request.WithQueryParameter("AGTP", m3_AGTP.Trim());

			// Execute the request
			var result = await Execute<LstAgrTpContentResponse>(
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
		/// Name LstAssignm
		/// Description List assignment status less than 44 and not 38
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TECH">Technician (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssignmResponse></returns>
		/// <exception cref="M3Exception<LstAssignmResponse>"></exception>
		public async Task<M3Response<LstAssignmResponse>> LstAssignm(
			string m3_TECH, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssignm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TECH))
				throw new ArgumentNullException("m3_TECH");

			// Set mandatory parameters
			request
				.WithQueryParameter("TECH", m3_TECH.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstAssignmResponse>(
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
		/// Name LstAssignmByCus
		/// Description List assignment by customer site
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_OPEN">Open activ (0=All,1=All but not JBST>79) (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssignmByCusResponse></returns>
		/// <exception cref="M3Exception<LstAssignmByCusResponse>"></exception>
		public async Task<M3Response<LstAssignmByCusResponse>> LstAssignmByCus(
			string m3_CUNO, 
			int m3_OPEN, 
			int? m3_CONO = null, 
			string m3_ADID = null, 
			string m3_INNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssignmByCus",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("OPEN", m3_OPEN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());

			// Execute the request
			var result = await Execute<LstAssignmByCusResponse>(
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
		/// Name LstAssignmByTec
		/// Description Retrieve assignments per technician
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_TECH">Technician (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STFR">Assignment status from</param>
		/// <param name="m3_STTO">Assignment status to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAssignmByTecResponse></returns>
		/// <exception cref="M3Exception<LstAssignmByTecResponse>"></exception>
		public async Task<M3Response<LstAssignmByTecResponse>> LstAssignmByTec(
			string m3_DIVI, 
			string m3_TECH, 
			int? m3_CONO = null, 
			string m3_STFR = null, 
			string m3_STTO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAssignmByTec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_TECH))
				throw new ArgumentNullException("m3_TECH");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("TECH", m3_TECH.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STFR))
				request.WithQueryParameter("STFR", m3_STFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STTO))
				request.WithQueryParameter("STTO", m3_STTO.Trim());

			// Execute the request
			var result = await Execute<LstAssignmByTecResponse>(
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
		/// Name LstChgAssignm
		/// Description List new, chg and del assignment Status less than 44, 50, 90
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRPL">Type of assign (0=All,1=New,2=Chg,3=Del) (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstChgAssignmResponse></returns>
		/// <exception cref="M3Exception<LstChgAssignmResponse>"></exception>
		public async Task<M3Response<LstChgAssignmResponse>> LstChgAssignm(
			int m3_PRPL, 
			int? m3_CONO = null, 
			string m3_SRES = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstChgAssignm",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PRPL", m3_PRPL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());

			// Execute the request
			var result = await Execute<LstChgAssignmResponse>(
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
		/// Name LstCustByName
		/// Description List customer by name
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDTY">Search identity (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustByNameResponse></returns>
		/// <exception cref="M3Exception<LstCustByNameResponse>"></exception>
		public async Task<M3Response<LstCustByNameResponse>> LstCustByName(
			int m3_IDTY, 
			int? m3_CONO = null, 
			string m3_CUNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustByName",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("IDTY", m3_IDTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());

			// Execute the request
			var result = await Execute<LstCustByNameResponse>(
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
		/// Name LstCustByPhone
		/// Description List customer by Phone
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDTY">Search identity (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_PHNO">Telephone number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustByPhoneResponse></returns>
		/// <exception cref="M3Exception<LstCustByPhoneResponse>"></exception>
		public async Task<M3Response<LstCustByPhoneResponse>> LstCustByPhone(
			int m3_IDTY, 
			int? m3_CONO = null, 
			string m3_PHNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustByPhone",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("IDTY", m3_IDTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());

			// Execute the request
			var result = await Execute<LstCustByPhoneResponse>(
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
		/// Name LstErrCde
		/// Description List error codes
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ERCO">Error codes</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrCdeResponse></returns>
		/// <exception cref="M3Exception<LstErrCdeResponse>"></exception>
		public async Task<M3Response<LstErrCdeResponse>> LstErrCde(
			int? m3_CONO = null, 
			string m3_ERCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstErrCde",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ERCO))
				request.WithQueryParameter("ERCO", m3_ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstErrCdeResponse>(
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
		/// Name LstErrSym
		/// Description List error symptom
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_ESCO">Error symptom</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstErrSymResponse></returns>
		/// <exception cref="M3Exception<LstErrSymResponse>"></exception>
		public async Task<M3Response<LstErrSymResponse>> LstErrSym(
			int? m3_CONO = null, 
			string m3_ESCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstErrSym",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ESCO))
				request.WithQueryParameter("ESCO", m3_ESCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<LstErrSymResponse>(
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
		/// Name LstHistAss
		/// Description List assignment Status greater than equal 45
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_JOBN">Assignment number (Required)</param>
		/// <param name="m3_JBSX">Assignment suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHistAssResponse></returns>
		/// <exception cref="M3Exception<LstHistAssResponse>"></exception>
		public async Task<M3Response<LstHistAssResponse>> LstHistAss(
			string m3_ORNO, 
			int m3_JOBN, 
			int m3_JBSX, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHistAss",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("JBSX", m3_JBSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstHistAssResponse>(
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
		/// Name LstIndPerSite
		/// Description List individual item per site
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_CUPL">Customer location</param>
		/// <param name="m3_ADID">Address ID</param>
		/// <param name="m3_INNO">Individual item (for positioning)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstIndPerSiteResponse></returns>
		/// <exception cref="M3Exception<LstIndPerSiteResponse>"></exception>
		public async Task<M3Response<LstIndPerSiteResponse>> LstIndPerSite(
			int? m3_CONO = null, 
			string m3_CUPL = null, 
			string m3_ADID = null, 
			string m3_INNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstIndPerSite",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());

			// Execute the request
			var result = await Execute<LstIndPerSiteResponse>(
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
		/// Name LstItem
		/// Description List item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDTY">Type of ID (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Item description</param>
		/// <param name="m3_IDNM">List by type, 0=Number 1=Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemResponse></returns>
		/// <exception cref="M3Exception<LstItemResponse>"></exception>
		public async Task<M3Response<LstItemResponse>> LstItem(
			int m3_IDTY, 
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			string m3_IDNM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItem",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("IDTY", m3_IDTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDNM))
				request.WithQueryParameter("IDNM", m3_IDNM.Trim());

			// Execute the request
			var result = await Execute<LstItemResponse>(
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
		/// Name LstLine
		/// Description List service order lines per assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_JOBN">Assignment number</param>
		/// <param name="m3_JBSX">Assignment suffix</param>
		/// <param name="m3_PONR">Position number</param>
		/// <param name="m3_POSX">Position suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3_ORNO, 
			int? m3_CONO = null, 
			int? m3_JOBN = null, 
			int? m3_JBSX = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_JOBN.HasValue)
				request.WithQueryParameter("JOBN", m3_JOBN.Value.ToString());
			if (m3_JBSX.HasValue)
				request.WithQueryParameter("JBSX", m3_JBSX.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
		/// Name LstNewMeters
		/// Description List new and changed meter readings
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNewMetersResponse></returns>
		/// <exception cref="M3Exception<LstNewMetersResponse>"></exception>
		public async Task<M3Response<LstNewMetersResponse>> LstNewMeters(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNewMeters",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstNewMetersResponse>(
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
		/// Name LstPrice
		/// Description List price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRS1">Price list</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_IDTY">Type of prices</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPriceResponse></returns>
		/// <exception cref="M3Exception<LstPriceResponse>"></exception>
		public async Task<M3Response<LstPriceResponse>> LstPrice(
			int? m3_CONO = null, 
			string m3_PRS1 = null, 
			string m3_CUCD = null, 
			string m3_CUNO = null, 
			DateTime? m3_STDT = null, 
			string m3_IDTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPrice",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRS1))
				request.WithQueryParameter("PRS1", m3_PRS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_IDTY))
				request.WithQueryParameter("IDTY", m3_IDTY.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstPriceResponse>(
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
		/// Name LstPriceLists
		/// Description List price lists per company
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRS1">Price list SO</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPriceListsResponse></returns>
		/// <exception cref="M3Exception<LstPriceListsResponse>"></exception>
		public async Task<M3Response<LstPriceListsResponse>> LstPriceLists(
			int? m3_CONO = null, 
			string m3_PRS1 = null, 
			string m3_CUCD = null, 
			string m3_CUNO = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_LVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPriceLists",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRS1))
				request.WithQueryParameter("PRS1", m3_PRS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPriceListsResponse>(
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
		/// Name LstSOAddr
		/// Description List service order address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSOAddrResponse></returns>
		/// <exception cref="M3Exception<LstSOAddrResponse>"></exception>
		public async Task<M3Response<LstSOAddrResponse>> LstSOAddr(
			string m3_ORNO, 
			int? m3_CONO = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSOAddr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());

			// Execute the request
			var result = await Execute<LstSOAddrResponse>(
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
		/// Name LstServManager
		/// Description List service manager
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServManagerResponse></returns>
		/// <exception cref="M3Exception<LstServManagerResponse>"></exception>
		public async Task<M3Response<LstServManagerResponse>> LstServManager(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_SRES = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstServManager",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());

			// Execute the request
			var result = await Execute<LstServManagerResponse>(
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
		/// Name LstServOrdType
		/// Description List service order types
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_SOTP">Service order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServOrdTypeResponse></returns>
		/// <exception cref="M3Exception<LstServOrdTypeResponse>"></exception>
		public async Task<M3Response<LstServOrdTypeResponse>> LstServOrdType(
			int? m3_CONO = null, 
			string m3_SOTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstServOrdType",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SOTP))
				request.WithQueryParameter("SOTP", m3_SOTP.Trim());

			// Execute the request
			var result = await Execute<LstServOrdTypeResponse>(
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
		/// Name LstSoTypeEnh
		/// Description List service order type, cat 1, 4, 6 and 9
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SOTP">Service order type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSoTypeEnhResponse></returns>
		/// <exception cref="M3Exception<LstSoTypeEnhResponse>"></exception>
		public async Task<M3Response<LstSoTypeEnhResponse>> LstSoTypeEnh(
			int? m3_CONO = null, 
			string m3_SOTP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSoTypeEnh",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SOTP))
				request.WithQueryParameter("SOTP", m3_SOTP.Trim());

			// Execute the request
			var result = await Execute<LstSoTypeEnhResponse>(
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
		/// Name LstTechQual
		/// Description List technicians qualifications
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_QUNO">Qualification</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTechQualResponse></returns>
		/// <exception cref="M3Exception<LstTechQualResponse>"></exception>
		public async Task<M3Response<LstTechQualResponse>> LstTechQual(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_TECH = null, 
			string m3_QUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTechQual",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QUNO))
				request.WithQueryParameter("QUNO", m3_QUNO.Trim());

			// Execute the request
			var result = await Execute<LstTechQualResponse>(
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
		/// Name LstTechnician
		/// Description List technicians
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTechnicianResponse></returns>
		/// <exception cref="M3Exception<LstTechnicianResponse>"></exception>
		public async Task<M3Response<LstTechnicianResponse>> LstTechnician(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_TECH = null, 
			string m3_FACI = null, 
			string m3_PLGR = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			string m3_EMNO = null, 
			string m3_SRES = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTechnician",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());

			// Execute the request
			var result = await Execute<LstTechnicianResponse>(
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
		/// Name LstWorkSchedule
		/// Description List work schedule per company and division
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_WOSC">Work schedule (Required)</param>
		/// <param name="m3_REF4">Type of info 1=Transactions/2=Worktime (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_YNQ1">Display lunch break Yes/no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstWorkScheduleResponse></returns>
		/// <exception cref="M3Exception<LstWorkScheduleResponse>"></exception>
		public async Task<M3Response<LstWorkScheduleResponse>> LstWorkSchedule(
			string m3_DIVI, 
			int m3_WOSC, 
			int m3_REF4, 
			int? m3_CONO = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			int? m3_YNQ1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstWorkSchedule",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("WOSC", m3_WOSC.ToString())
				.WithQueryParameter("REF4", m3_REF4.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (m3_YNQ1.HasValue)
				request.WithQueryParameter("YNQ1", m3_YNQ1.Value.ToString());

			// Execute the request
			var result = await Execute<LstWorkScheduleResponse>(
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
		/// Name ReportAssignm
		/// Description Report the assignment
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Service order number (Required)</param>
		/// <param name="m3_JOBN">Assignment number (Required)</param>
		/// <param name="m3_JBSX">Assignment suffix (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_INNO">Individual item number</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_ESCO">Error symptom code</param>
		/// <param name="m3_ETX1">Error symptom text 1</param>
		/// <param name="m3_ETX2">Error symptom text 2</param>
		/// <param name="m3_ETX3">Error symptom text 3</param>
		/// <param name="m3_ETX4">Error symptom text 4</param>
		/// <param name="m3_DBCO">Payer control</param>
		/// <param name="m3_ASST">Assignment type</param>
		/// <param name="m3_ERCO">Error cause</param>
		/// <param name="m3_MECO">Action code</param>
		/// <param name="m3_MTCO">Action text code</param>
		/// <param name="m3_MTX1">Action text 1</param>
		/// <param name="m3_MTX2">Action text 2</param>
		/// <param name="m3_MTX3">Action text 3</param>
		/// <param name="m3_MTX4">Action text 4</param>
		/// <param name="m3_RSDJ">Actual start date assignment</param>
		/// <param name="m3_RSTJ">Actual start time assignment</param>
		/// <param name="m3_RSDW">Actual start date task</param>
		/// <param name="m3_RSTW">Actual start time task</param>
		/// <param name="m3_RFDJ">Actual finish date assignment</param>
		/// <param name="m3_RFTJ">Actual finish time assignment</param>
		/// <param name="m3_RFDW">Actual finish date task</param>
		/// <param name="m3_RFTW">Actual finish time task</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReportAssignm(
			string m3_ORNO, 
			int m3_JOBN, 
			int m3_JBSX, 
			int? m3_CONO = null, 
			string m3_INNO = null, 
			string m3_SERI = null, 
			string m3_CUNO = null, 
			string m3_ADID = null, 
			string m3_ESCO = null, 
			string m3_ETX1 = null, 
			string m3_ETX2 = null, 
			string m3_ETX3 = null, 
			string m3_ETX4 = null, 
			string m3_DBCO = null, 
			string m3_ASST = null, 
			string m3_ERCO = null, 
			string m3_MECO = null, 
			string m3_MTCO = null, 
			string m3_MTX1 = null, 
			string m3_MTX2 = null, 
			string m3_MTX3 = null, 
			string m3_MTX4 = null, 
			DateTime? m3_RSDJ = null, 
			int? m3_RSTJ = null, 
			DateTime? m3_RSDW = null, 
			int? m3_RSTW = null, 
			DateTime? m3_RFDJ = null, 
			int? m3_RFTJ = null, 
			DateTime? m3_RFDW = null, 
			int? m3_RFTW = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReportAssignm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("JOBN", m3_JOBN.ToString())
				.WithQueryParameter("JBSX", m3_JBSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_INNO))
				request.WithQueryParameter("INNO", m3_INNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ESCO))
				request.WithQueryParameter("ESCO", m3_ESCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX1))
				request.WithQueryParameter("ETX1", m3_ETX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX2))
				request.WithQueryParameter("ETX2", m3_ETX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX3))
				request.WithQueryParameter("ETX3", m3_ETX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETX4))
				request.WithQueryParameter("ETX4", m3_ETX4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DBCO))
				request.WithQueryParameter("DBCO", m3_DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASST))
				request.WithQueryParameter("ASST", m3_ASST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ERCO))
				request.WithQueryParameter("ERCO", m3_ERCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MECO))
				request.WithQueryParameter("MECO", m3_MECO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTCO))
				request.WithQueryParameter("MTCO", m3_MTCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX1))
				request.WithQueryParameter("MTX1", m3_MTX1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX2))
				request.WithQueryParameter("MTX2", m3_MTX2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX3))
				request.WithQueryParameter("MTX3", m3_MTX3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MTX4))
				request.WithQueryParameter("MTX4", m3_MTX4.Trim());
			if (m3_RSDJ.HasValue)
				request.WithQueryParameter("RSDJ", m3_RSDJ.Value.ToM3String());
			if (m3_RSTJ.HasValue)
				request.WithQueryParameter("RSTJ", m3_RSTJ.Value.ToString());
			if (m3_RSDW.HasValue)
				request.WithQueryParameter("RSDW", m3_RSDW.Value.ToM3String());
			if (m3_RSTW.HasValue)
				request.WithQueryParameter("RSTW", m3_RSTW.Value.ToString());
			if (m3_RFDJ.HasValue)
				request.WithQueryParameter("RFDJ", m3_RFDJ.Value.ToM3String());
			if (m3_RFTJ.HasValue)
				request.WithQueryParameter("RFTJ", m3_RFTJ.Value.ToString());
			if (m3_RFDW.HasValue)
				request.WithQueryParameter("RFDW", m3_RFDW.Value.ToM3String());
			if (m3_RFTW.HasValue)
				request.WithQueryParameter("RFTW", m3_RFTW.Value.ToString());

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
		/// Name RlsDistOrder
		/// Description Release distribution order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RORN">Reference order number (service order no (Required)</param>
		/// <param name="m3_RORC">Reference order cathegory (=7) (Required)</param>
		/// <param name="m3_TYPE">Type (*RLS) (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RlsDistOrder(
			string m3_RORN, 
			string m3_RORC, 
			int m3_TYPE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RlsDistOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RORN))
				throw new ArgumentNullException("m3_RORN");
			if (string.IsNullOrWhiteSpace(m3_RORC))
				throw new ArgumentNullException("m3_RORC");

			// Set mandatory parameters
			request
				.WithQueryParameter("RORN", m3_RORN.Trim())
				.WithQueryParameter("RORC", m3_RORC.Trim())
				.WithQueryParameter("TYPE", m3_TYPE.ToString());

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
		/// Name UpdIndItem
		/// Description Update of individual item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_INNO">Individual item number (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_CUOW">Customer owner</param>
		/// <param name="m3_CUPL">Customer location</param>
		/// <param name="m3_ADID">Address id</param>
		/// <param name="m3_ISTS">Individual item status</param>
		/// <param name="m3_INGR">Individual item group</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_INTY">Individual item type</param>
		/// <param name="m3_MODE">Model</param>
		/// <param name="m3_MODC">Model name</param>
		/// <param name="m3_TECH">Technician</param>
		/// <param name="m3_SRES">Service responsible</param>
		/// <param name="m3_ITGR">Item group</param>
		/// <param name="m3_DEDA">Delivery date</param>
		/// <param name="m3_REDA">Receipt date</param>
		/// <param name="m3_INDA">Installation date</param>
		/// <param name="m3_AGRS">Contract item - service</param>
		/// <param name="m3_AGRR">Contract item - rental</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_NBID">Number series id</param>
		/// <param name="m3_TRAN">Transaction 1 = Add, 2 = Update</param>
		/// <param name="m3_MLYR">Year model</param>
		/// <param name="m3_AREA">Location description</param>
		/// <param name="m3_GDT1">Warranty date sales</param>
		/// <param name="m3_CUGA">General agent</param>
		/// <param name="m3_GDT2">Warranty date supplier</param>
		/// <param name="m3_PROD">Manufacturer</param>
		/// <param name="m3_CUIC">Customer number at insurence company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_CTNO">Agreement number</param>
		/// <param name="m3_CTNA">Agreement number</param>
		/// <param name="m3_MICD">Main individual item code</param>
		/// <param name="m3_MINO">Main individual item number</param>
		/// <param name="m3_CONS">Equipment</param>
		/// <param name="m3_CFE1">User def 1</param>
		/// <param name="m3_CFE2">User def 2</param>
		/// <param name="m3_CFE3">User def 3</param>
		/// <param name="m3_CFE4">User def 4</param>
		/// <param name="m3_CFE5">User def 5</param>
		/// <param name="m3_CFE6">User def 6</param>
		/// <param name="m3_CFE7">User def 7</param>
		/// <param name="m3_CFE8">User def 8</param>
		/// <param name="m3_CFE9">User def 9</param>
		/// <param name="m3_CFE0">User def 10</param>
		/// <param name="m3_CFEA">User def 11</param>
		/// <param name="m3_CFEB">User def 12</param>
		/// <param name="m3_PINO">GUI picture</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_GDT3">Warranty date work shop</param>
		/// <param name="m3_ISTR">Update individual item struct</param>
		/// <param name="m3_IHIS">Update individual item history</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_MFNO">Manufactoring order number</param>
		/// <param name="m3_REBE">Registration  number</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_LOCS">Location</param>
		/// <param name="m3_DDAT">Date disposed</param>
		/// <param name="m3_ASID">Fixed asset</param>
		/// <param name="m3_SBNO">Sub number</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_FCTN">Function area</param>
		/// <param name="m3_MEIT">Meter item</param>
		/// <param name="m3_AGCN">Agreement customer</param>
		/// <param name="m3_SERI">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdIndItem(
			string m3_INNO, 
			int? m3_CONO = null, 
			string m3_CUOW = null, 
			string m3_CUPL = null, 
			string m3_ADID = null, 
			string m3_ISTS = null, 
			string m3_INGR = null, 
			string m3_BANO = null, 
			string m3_BRAN = null, 
			string m3_INTY = null, 
			string m3_MODE = null, 
			string m3_MODC = null, 
			string m3_TECH = null, 
			string m3_SRES = null, 
			string m3_ITGR = null, 
			DateTime? m3_DEDA = null, 
			DateTime? m3_REDA = null, 
			DateTime? m3_INDA = null, 
			string m3_AGRS = null, 
			string m3_AGRR = null, 
			string m3_DIVI = null, 
			string m3_ITNO = null, 
			string m3_NBID = null, 
			string m3_TRAN = null, 
			string m3_MLYR = null, 
			string m3_AREA = null, 
			DateTime? m3_GDT1 = null, 
			string m3_CUGA = null, 
			DateTime? m3_GDT2 = null, 
			string m3_PROD = null, 
			string m3_CUIC = null, 
			string m3_WHLO = null, 
			string m3_WHSL = null, 
			string m3_CTNO = null, 
			string m3_CTNA = null, 
			string m3_MICD = null, 
			string m3_MINO = null, 
			string m3_CONS = null, 
			string m3_CFE1 = null, 
			decimal? m3_CFE2 = null, 
			string m3_CFE3 = null, 
			string m3_CFE4 = null, 
			string m3_CFE5 = null, 
			string m3_CFE6 = null, 
			decimal? m3_CFE7 = null, 
			string m3_CFE8 = null, 
			string m3_CFE9 = null, 
			string m3_CFE0 = null, 
			string m3_CFEA = null, 
			string m3_CFEB = null, 
			string m3_PINO = null, 
			string m3_DWNO = null, 
			DateTime? m3_GDT3 = null, 
			string m3_ISTR = null, 
			string m3_IHIS = null, 
			string m3_PUNO = null, 
			string m3_PNLI = null, 
			string m3_MFNO = null, 
			string m3_REBE = null, 
			string m3_RORN = null, 
			string m3_RORC = null, 
			string m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_LOCS = null, 
			DateTime? m3_DDAT = null, 
			string m3_ASID = null, 
			string m3_SBNO = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_FCTN = null, 
			string m3_MEIT = null, 
			string m3_AGCN = null, 
			string m3_SERI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdIndItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_INNO))
				throw new ArgumentNullException("m3_INNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("INNO", m3_INNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUOW))
				request.WithQueryParameter("CUOW", m3_CUOW.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ISTS))
				request.WithQueryParameter("ISTS", m3_ISTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INGR))
				request.WithQueryParameter("INGR", m3_INGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INTY))
				request.WithQueryParameter("INTY", m3_INTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODE))
				request.WithQueryParameter("MODE", m3_MODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODC))
				request.WithQueryParameter("MODC", m3_MODC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TECH))
				request.WithQueryParameter("TECH", m3_TECH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITGR))
				request.WithQueryParameter("ITGR", m3_ITGR.Trim());
			if (m3_DEDA.HasValue)
				request.WithQueryParameter("DEDA", m3_DEDA.Value.ToM3String());
			if (m3_REDA.HasValue)
				request.WithQueryParameter("REDA", m3_REDA.Value.ToM3String());
			if (m3_INDA.HasValue)
				request.WithQueryParameter("INDA", m3_INDA.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_AGRS))
				request.WithQueryParameter("AGRS", m3_AGRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRR))
				request.WithQueryParameter("AGRR", m3_AGRR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NBID))
				request.WithQueryParameter("NBID", m3_NBID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRAN))
				request.WithQueryParameter("TRAN", m3_TRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MLYR))
				request.WithQueryParameter("MLYR", m3_MLYR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AREA))
				request.WithQueryParameter("AREA", m3_AREA.Trim());
			if (m3_GDT1.HasValue)
				request.WithQueryParameter("GDT1", m3_GDT1.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUGA))
				request.WithQueryParameter("CUGA", m3_CUGA.Trim());
			if (m3_GDT2.HasValue)
				request.WithQueryParameter("GDT2", m3_GDT2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PROD))
				request.WithQueryParameter("PROD", m3_PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUIC))
				request.WithQueryParameter("CUIC", m3_CUIC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNO))
				request.WithQueryParameter("CTNO", m3_CTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTNA))
				request.WithQueryParameter("CTNA", m3_CTNA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MICD))
				request.WithQueryParameter("MICD", m3_MICD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MINO))
				request.WithQueryParameter("MINO", m3_MINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CONS))
				request.WithQueryParameter("CONS", m3_CONS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFE1))
				request.WithQueryParameter("CFE1", m3_CFE1.Trim());
			if (m3_CFE2.HasValue)
				request.WithQueryParameter("CFE2", m3_CFE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFE3))
				request.WithQueryParameter("CFE3", m3_CFE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFE4))
				request.WithQueryParameter("CFE4", m3_CFE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFE5))
				request.WithQueryParameter("CFE5", m3_CFE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFE6))
				request.WithQueryParameter("CFE6", m3_CFE6.Trim());
			if (m3_CFE7.HasValue)
				request.WithQueryParameter("CFE7", m3_CFE7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFE8))
				request.WithQueryParameter("CFE8", m3_CFE8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFE9))
				request.WithQueryParameter("CFE9", m3_CFE9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFE0))
				request.WithQueryParameter("CFE0", m3_CFE0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFEA))
				request.WithQueryParameter("CFEA", m3_CFEA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFEB))
				request.WithQueryParameter("CFEB", m3_CFEB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PINO))
				request.WithQueryParameter("PINO", m3_PINO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (m3_GDT3.HasValue)
				request.WithQueryParameter("GDT3", m3_GDT3.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ISTR))
				request.WithQueryParameter("ISTR", m3_ISTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IHIS))
				request.WithQueryParameter("IHIS", m3_IHIS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PNLI))
				request.WithQueryParameter("PNLI", m3_PNLI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFNO))
				request.WithQueryParameter("MFNO", m3_MFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REBE))
				request.WithQueryParameter("REBE", m3_REBE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORC))
				request.WithQueryParameter("RORC", m3_RORC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORL))
				request.WithQueryParameter("RORL", m3_RORL.Trim());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LOCS))
				request.WithQueryParameter("LOCS", m3_LOCS.Trim());
			if (m3_DDAT.HasValue)
				request.WithQueryParameter("DDAT", m3_DDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ASID))
				request.WithQueryParameter("ASID", m3_ASID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SBNO))
				request.WithQueryParameter("SBNO", m3_SBNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCTN))
				request.WithQueryParameter("FCTN", m3_FCTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEIT))
				request.WithQueryParameter("MEIT", m3_MEIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGCN))
				request.WithQueryParameter("AGCN", m3_AGCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERI))
				request.WithQueryParameter("SERI", m3_SERI.Trim());

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
		/// Name UpdSOAddr
		/// Description Update SO address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_CUA1">Customer address 1</param>
		/// <param name="m3_CUA2">Customer address 2</param>
		/// <param name="m3_CUA3">Customer address 3</param>
		/// <param name="m3_CUA4">Customer address 4</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_MEAL">Valid media</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_TAXC">Tax code</param>
		/// <param name="m3_ECAR">Area/state</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSOAddr(
			string m3_ORNO, 
			int m3_ADRT, 
			int? m3_CONO = null, 
			string m3_ADID = null, 
			string m3_CUNM = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_PONO = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_CSCD = null, 
			string m3_MEAL = null, 
			long? m3_GEOC = null, 
			string m3_TAXC = null, 
			string m3_ECAR = null, 
			string m3_TOWN = null, 
			string m3_FRCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSOAddr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("ADRT", m3_ADRT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MEAL))
				request.WithQueryParameter("MEAL", m3_MEAL.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());

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
