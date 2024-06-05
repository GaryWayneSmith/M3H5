/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PDS001MI;
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
	/// Name: PDS001MI
	/// Component Name: Product
	/// Description: Product interface
	/// Version Release: 5ea6
	///</summary>
	public partial class PDS001MIResource : M3BaseResourceEndpoint
	{
		public PDS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS001MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Create
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_CONO">Company Number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_PRTX">Product text</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_SCOM">Structure complexity</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_ECMA">ECO managed</param>
		/// <param name="m3_ECON">Engineering change order number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_ECEX">Change type</param>
		/// <param name="m3_PFTM">Planning time fence</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_LEAA">Leadtime 5 production time all levels</param>
		/// <param name="m3_EOQT">Order quantity</param>
		/// <param name="m3_EOQM">Order policy</param>
		/// <param name="m3_LEAL">Lead time this level</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_AOPL">Alternate routings</param>
		/// <param name="m3_SAOI">Standard routing</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_DCON">Dynamic configurator</param>
		/// <param name="m3_ASPC">Cumulative scrap percentage</param>
		/// <param name="m3_BACO">Batch recalculation</param>
		/// <param name="m3_EXPC">Yield percentage</param>
		/// <param name="m3_TEXQ">Batch quantity</param>
		/// <param name="m3_BAQT">Yield quantity</param>
		/// <param name="m3_SDTB">Same date for batches</param>
		/// <param name="m3_PRIB">Batch production</param>
		/// <param name="m3_NUC1">Number of put-away cards</param>
		/// <param name="m3_NUC2">Number of material requisitions</param>
		/// <param name="m3_NUC3">Number of labor tickets</param>
		/// <param name="m3_NUC4">Number of shop travelers</param>
		/// <param name="m3_NUC5">Number of routing cards</param>
		/// <param name="m3_NUC6">Number of picking lists</param>
		/// <param name="m3_NUC7">Number of design documents</param>
		/// <param name="m3_NUMA">Number of components</param>
		/// <param name="m3_NUBD">Number of explosion items</param>
		/// <param name="m3_NUOP">Number of operations</param>
		/// <param name="m3_NUPH">Number of phantom items</param>
		/// <param name="m3_NUSC">Number of subcontract operations</param>
		/// <param name="m3_NUEX">Number of yield components</param>
		/// <param name="m3_LEVL">Lowest level</param>
		/// <param name="m3_FSCD">Kit control</param>
		/// <param name="m3_UPCO">Full cost summation</param>
		/// <param name="m3_PSET">Pricing method</param>
		/// <param name="m3_SRCD">Reservation level</param>
		/// <param name="m3_SCCD">Statistics level</param>
		/// <param name="m3_KPCD">Kit printout</param>
		/// <param name="m3_PULN">Pull-up control - nondelayed orders</param>
		/// <param name="m3_PULD">Pull-up control - delayed orders</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="m3_NUC8">Number of lot cards</param>
		/// <param name="m3_SKTS">Suppress Kit Screen</param>
		/// <param name="m3_AADP">Add products - not in item master</param>
		/// <param name="m3_PSCL">Product structure class</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_PCBO">Percentage BOM</param>
		/// <param name="m3_PPMG">Production lot controlled/op exist</param>
		/// <param name="m3_KPPO">Kit printout PO</param>
		/// <param name="m3_VRNF">Version managed</param>
		/// <param name="m3_MNPL">Maintained by external system</param>
		/// <param name="m3_AGAP">Allow date gap</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_FACI, 
			string m3_PRNO, 
			int? m3_CONO = null, 
			string m3_STRT = null, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			string m3_PRTX = null, 
			string m3_DWNO = null, 
			int? m3_SCOM = null, 
			string m3_ECVE = null, 
			int? m3_ECMA = null, 
			string m3_ECON = null, 
			int? m3_FDAT = null, 
			string m3_ECEX = null, 
			int? m3_PFTM = null, 
			string m3_UNMU = null, 
			int? m3_LEAA = null, 
			string m3_EOQT = null, 
			int? m3_EOQM = null, 
			int? m3_LEAL = null, 
			string m3_UNMS = null, 
			int? m3_AOPL = null, 
			string m3_SAOI = null, 
			string m3_TX15 = null, 
			int? m3_DCON = null, 
			int? m3_ASPC = null, 
			int? m3_BACO = null, 
			int? m3_EXPC = null, 
			string m3_TEXQ = null, 
			string m3_BAQT = null, 
			int? m3_SDTB = null, 
			int? m3_PRIB = null, 
			int? m3_NUC1 = null, 
			int? m3_NUC2 = null, 
			int? m3_NUC3 = null, 
			int? m3_NUC4 = null, 
			int? m3_NUC5 = null, 
			int? m3_NUC6 = null, 
			int? m3_NUC7 = null, 
			int? m3_NUMA = null, 
			int? m3_NUBD = null, 
			int? m3_NUOP = null, 
			int? m3_NUPH = null, 
			int? m3_NUSC = null, 
			int? m3_NUEX = null, 
			int? m3_LEVL = null, 
			int? m3_FSCD = null, 
			int? m3_UPCO = null, 
			int? m3_PSET = null, 
			int? m3_SRCD = null, 
			int? m3_SCCD = null, 
			int? m3_KPCD = null, 
			int? m3_PULN = null, 
			int? m3_PULD = null, 
			int? m3_SDAT = null, 
			int? m3_STTE = null, 
			int? m3_NUC8 = null, 
			int? m3_SKTS = null, 
			int? m3_AADP = null, 
			string m3_PSCL = null, 
			decimal? m3_TXID = null, 
			int? m3_PCBO = null, 
			int? m3_PPMG = null, 
			int? m3_KPPO = null, 
			int? m3_VRNF = null, 
			int? m3_MNPL = null, 
			int? m3_AGAP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRTX))
				request.WithQueryParameter("PRTX", m3_PRTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (m3_SCOM.HasValue)
				request.WithQueryParameter("SCOM", m3_SCOM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (m3_ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3_ECMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECON))
				request.WithQueryParameter("ECON", m3_ECON.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECEX))
				request.WithQueryParameter("ECEX", m3_ECEX.Trim());
			if (m3_PFTM.HasValue)
				request.WithQueryParameter("PFTM", m3_PFTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMU))
				request.WithQueryParameter("UNMU", m3_UNMU.Trim());
			if (m3_LEAA.HasValue)
				request.WithQueryParameter("LEAA", m3_LEAA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EOQT))
				request.WithQueryParameter("EOQT", m3_EOQT.Trim());
			if (m3_EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3_EOQM.Value.ToString());
			if (m3_LEAL.HasValue)
				request.WithQueryParameter("LEAL", m3_LEAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_AOPL.HasValue)
				request.WithQueryParameter("AOPL", m3_AOPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SAOI))
				request.WithQueryParameter("SAOI", m3_SAOI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_DCON.HasValue)
				request.WithQueryParameter("DCON", m3_DCON.Value.ToString());
			if (m3_ASPC.HasValue)
				request.WithQueryParameter("ASPC", m3_ASPC.Value.ToString());
			if (m3_BACO.HasValue)
				request.WithQueryParameter("BACO", m3_BACO.Value.ToString());
			if (m3_EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3_EXPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEXQ))
				request.WithQueryParameter("TEXQ", m3_TEXQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAQT))
				request.WithQueryParameter("BAQT", m3_BAQT.Trim());
			if (m3_SDTB.HasValue)
				request.WithQueryParameter("SDTB", m3_SDTB.Value.ToString());
			if (m3_PRIB.HasValue)
				request.WithQueryParameter("PRIB", m3_PRIB.Value.ToString());
			if (m3_NUC1.HasValue)
				request.WithQueryParameter("NUC1", m3_NUC1.Value.ToString());
			if (m3_NUC2.HasValue)
				request.WithQueryParameter("NUC2", m3_NUC2.Value.ToString());
			if (m3_NUC3.HasValue)
				request.WithQueryParameter("NUC3", m3_NUC3.Value.ToString());
			if (m3_NUC4.HasValue)
				request.WithQueryParameter("NUC4", m3_NUC4.Value.ToString());
			if (m3_NUC5.HasValue)
				request.WithQueryParameter("NUC5", m3_NUC5.Value.ToString());
			if (m3_NUC6.HasValue)
				request.WithQueryParameter("NUC6", m3_NUC6.Value.ToString());
			if (m3_NUC7.HasValue)
				request.WithQueryParameter("NUC7", m3_NUC7.Value.ToString());
			if (m3_NUMA.HasValue)
				request.WithQueryParameter("NUMA", m3_NUMA.Value.ToString());
			if (m3_NUBD.HasValue)
				request.WithQueryParameter("NUBD", m3_NUBD.Value.ToString());
			if (m3_NUOP.HasValue)
				request.WithQueryParameter("NUOP", m3_NUOP.Value.ToString());
			if (m3_NUPH.HasValue)
				request.WithQueryParameter("NUPH", m3_NUPH.Value.ToString());
			if (m3_NUSC.HasValue)
				request.WithQueryParameter("NUSC", m3_NUSC.Value.ToString());
			if (m3_NUEX.HasValue)
				request.WithQueryParameter("NUEX", m3_NUEX.Value.ToString());
			if (m3_LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3_LEVL.Value.ToString());
			if (m3_FSCD.HasValue)
				request.WithQueryParameter("FSCD", m3_FSCD.Value.ToString());
			if (m3_UPCO.HasValue)
				request.WithQueryParameter("UPCO", m3_UPCO.Value.ToString());
			if (m3_PSET.HasValue)
				request.WithQueryParameter("PSET", m3_PSET.Value.ToString());
			if (m3_SRCD.HasValue)
				request.WithQueryParameter("SRCD", m3_SRCD.Value.ToString());
			if (m3_SCCD.HasValue)
				request.WithQueryParameter("SCCD", m3_SCCD.Value.ToString());
			if (m3_KPCD.HasValue)
				request.WithQueryParameter("KPCD", m3_KPCD.Value.ToString());
			if (m3_PULN.HasValue)
				request.WithQueryParameter("PULN", m3_PULN.Value.ToString());
			if (m3_PULD.HasValue)
				request.WithQueryParameter("PULD", m3_PULD.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToString());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());
			if (m3_NUC8.HasValue)
				request.WithQueryParameter("NUC8", m3_NUC8.Value.ToString());
			if (m3_SKTS.HasValue)
				request.WithQueryParameter("SKTS", m3_SKTS.Value.ToString());
			if (m3_AADP.HasValue)
				request.WithQueryParameter("AADP", m3_AADP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PSCL))
				request.WithQueryParameter("PSCL", m3_PSCL.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_PCBO.HasValue)
				request.WithQueryParameter("PCBO", m3_PCBO.Value.ToString());
			if (m3_PPMG.HasValue)
				request.WithQueryParameter("PPMG", m3_PPMG.Value.ToString());
			if (m3_KPPO.HasValue)
				request.WithQueryParameter("KPPO", m3_KPPO.Value.ToString());
			if (m3_VRNF.HasValue)
				request.WithQueryParameter("VRNF", m3_VRNF.Value.ToString());
			if (m3_MNPL.HasValue)
				request.WithQueryParameter("MNPL", m3_MNPL.Value.ToString());
			if (m3_AGAP.HasValue)
				request.WithQueryParameter("AGAP", m3_AGAP.Value.ToString());

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
		/// Description Copy
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_CFAC">To Facility (Required)</param>
		/// <param name="m3_CPRN">To Product number (Required)</param>
		/// <param name="m3_CONO">Company Number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_CSTR">To Product structure type</param>
		/// <param name="m3_CPOP">Copy Operation</param>
		/// <param name="m3_CPPV">Copy Variants</param>
		/// <param name="m3_AADP">Add products - not in item master</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_CFAC, 
			string m3_CPRN, 
			int? m3_CONO = null, 
			string m3_STRT = null, 
			string m3_CSTR = null, 
			string m3_CPOP = null, 
			string m3_CPPV = null, 
			int? m3_AADP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_CFAC))
				throw new ArgumentNullException("m3_CFAC");
			if (string.IsNullOrWhiteSpace(m3_CPRN))
				throw new ArgumentNullException("m3_CPRN");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("CFAC", m3_CFAC.Trim())
				.WithQueryParameter("CPRN", m3_CPRN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSTR))
				request.WithQueryParameter("CSTR", m3_CSTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPOP))
				request.WithQueryParameter("CPOP", m3_CPOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPPV))
				request.WithQueryParameter("CPPV", m3_CPPV.Trim());
			if (m3_AADP.HasValue)
				request.WithQueryParameter("AADP", m3_AADP.Value.ToString());

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
		/// Name CpyProdVersion
		/// Description Copy Product Version
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3_FACI">Source Facility (Required)</param>
		/// <param name="m3_PRNO">Source Product (Required)</param>
		/// <param name="m3_CFAC">Target facility (Required)</param>
		/// <param name="m3_CPRN">Target product (Required)</param>
		/// <param name="m3_STRT">Source Product structure type</param>
		/// <param name="m3_VRSN">Source version</param>
		/// <param name="m3_CSTR">Target  structure type</param>
		/// <param name="m3_CSTA">Target Product Structure Status</param>
		/// <param name="m3_CVRN">Target version</param>
		/// <param name="m3_CFDT">Target from date</param>
		/// <param name="m3_CTDT">Target to date</param>
		/// <param name="m3_CPOP">Copy Operation</param>
		/// <param name="m3_AADP">Add products - not in item master</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyProdVersion(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_CFAC, 
			string m3_CPRN, 
			string m3_STRT = null, 
			int? m3_VRSN = null, 
			string m3_CSTR = null, 
			string m3_CSTA = null, 
			int? m3_CVRN = null, 
			DateTime? m3_CFDT = null, 
			DateTime? m3_CTDT = null, 
			string m3_CPOP = null, 
			int? m3_AADP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyProdVersion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_CFAC))
				throw new ArgumentNullException("m3_CFAC");
			if (string.IsNullOrWhiteSpace(m3_CPRN))
				throw new ArgumentNullException("m3_CPRN");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("CFAC", m3_CFAC.Trim())
				.WithQueryParameter("CPRN", m3_CPRN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3_VRSN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CSTR))
				request.WithQueryParameter("CSTR", m3_CSTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSTA))
				request.WithQueryParameter("CSTA", m3_CSTA.Trim());
			if (m3_CVRN.HasValue)
				request.WithQueryParameter("CVRN", m3_CVRN.Value.ToString());
			if (m3_CFDT.HasValue)
				request.WithQueryParameter("CFDT", m3_CFDT.Value.ToM3String());
			if (m3_CTDT.HasValue)
				request.WithQueryParameter("CTDT", m3_CTDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CPOP))
				request.WithQueryParameter("CPOP", m3_CPOP.Trim());
			if (m3_AADP.HasValue)
				request.WithQueryParameter("AADP", m3_AADP.Value.ToString());

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
		/// Name Delete
		/// Description Delete
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_FACI, 
			string m3_PRNO, 
			int? m3_CONO = null, 
			string m3_STRT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

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
		/// Name Get
		/// Description Get
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_FACI, 
			string m3_PRNO, 
			int? m3_CONO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name GetStructParam
		/// Description Get structure parameter (CRS787)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStructParamResponse></returns>
		/// <exception cref="M3Exception<GetStructParamResponse>"></exception>
		public async Task<M3Response<GetStructParamResponse>> GetStructParam(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetStructParam",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetStructParamResponse>(
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
		/// Name List
		/// Description List
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name ListByItem
		/// Description List By Item
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListByItemResponse></returns>
		/// <exception cref="M3Exception<ListByItemResponse>"></exception>
		public async Task<M3Response<ListByItemResponse>> ListByItem(
			string m3_PRNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListByItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Execute the request
			var result = await Execute<ListByItemResponse>(
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
		/// Name SearchProduct
		/// Description Search product
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchProductResponse></returns>
		/// <exception cref="M3Exception<SearchProductResponse>"></exception>
		public async Task<M3Response<SearchProductResponse>> SearchProduct(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchProduct",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchProductResponse>(
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
		/// Name SelEndProd
		/// Description Select End Products
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelEndProdResponse></returns>
		/// <exception cref="M3Exception<SelEndProdResponse>"></exception>
		public async Task<M3Response<SelEndProdResponse>> SelEndProd(
			string m3_FACI, 
			string m3_APIP = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			DateTime? m3_TRDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelEndProd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<SelEndProdResponse>(
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
		/// Description Select Product Structures
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_APIP">APS - policy</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3_FACI, 
			string m3_APIP = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

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
		/// Name StartVersioning
		/// Description Start Version for a non version product structure
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_STRT">Product structure type (Required)</param>
		/// <param name="m3_TSTP">Target Structure Type (Required)</param>
		/// <param name="m3_FIST">Status after Conversion (Required)</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartVersioning(
			string m3_FACI, 
			string m3_PRNO, 
			string m3_STRT, 
			string m3_TSTP, 
			string m3_FIST, 
			int? m3_FDAT = null, 
			int? m3_TDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartVersioning",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_TSTP))
				throw new ArgumentNullException("m3_TSTP");
			if (string.IsNullOrWhiteSpace(m3_FIST))
				throw new ArgumentNullException("m3_FIST");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("TSTP", m3_TSTP.Trim())
				.WithQueryParameter("FIST", m3_FIST.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToString());

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
		/// Name Update
		/// Description Update
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_CONO">Company Number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_PRTX">Product text</param>
		/// <param name="m3_DWNO">Drawing number</param>
		/// <param name="m3_SCOM">Structure complexity</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_ECMA">ECO managed</param>
		/// <param name="m3_ECON">Engineering change order number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_ECEX">Change type</param>
		/// <param name="m3_PFTM">Planning time fence</param>
		/// <param name="m3_UNMU">Order multiple</param>
		/// <param name="m3_LEAA">Leadtime 5 production time all levels</param>
		/// <param name="m3_EOQT">Order quantity</param>
		/// <param name="m3_EOQM">Order policy</param>
		/// <param name="m3_LEAL">Lead time this level</param>
		/// <param name="m3_UNMS">Basic unit of measure</param>
		/// <param name="m3_AOPL">Alternate routings</param>
		/// <param name="m3_SAOI">Standard routing</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_DCON">Dynamic configurator</param>
		/// <param name="m3_ASPC">Cumulative scrap percentage</param>
		/// <param name="m3_BACO">Batch recalculation</param>
		/// <param name="m3_EXPC">Yield percentage</param>
		/// <param name="m3_TEXQ">Batch quantity</param>
		/// <param name="m3_BAQT">Yield quantity</param>
		/// <param name="m3_SDTB">Same date for batches</param>
		/// <param name="m3_PRIB">Batch production</param>
		/// <param name="m3_NUC1">Number of put-away cards</param>
		/// <param name="m3_NUC2">Number of material requisitions</param>
		/// <param name="m3_NUC3">Number of labor tickets</param>
		/// <param name="m3_NUC4">Number of shop travelers</param>
		/// <param name="m3_NUC5">Number of routing cards</param>
		/// <param name="m3_NUC6">Number of picking lists</param>
		/// <param name="m3_NUC7">Number of design documents</param>
		/// <param name="m3_NUMA">Number of components</param>
		/// <param name="m3_NUBD">Number of explosion items</param>
		/// <param name="m3_NUOP">Number of operations</param>
		/// <param name="m3_NUPH">Number of phantom items</param>
		/// <param name="m3_NUSC">Number of subcontract operations</param>
		/// <param name="m3_NUEX">Number of yield components</param>
		/// <param name="m3_LEVL">Lowest level</param>
		/// <param name="m3_FSCD">Kit control</param>
		/// <param name="m3_UPCO">Full cost summation</param>
		/// <param name="m3_PSET">Pricing method</param>
		/// <param name="m3_SRCD">Reservation level</param>
		/// <param name="m3_SCCD">Statistics level</param>
		/// <param name="m3_KPCD">Kit printout</param>
		/// <param name="m3_PULN">Pull-up control - nondelayed orders</param>
		/// <param name="m3_PULD">Pull-up control - delayed orders</param>
		/// <param name="m3_SDAT">Clock date</param>
		/// <param name="m3_STTE">Clock time</param>
		/// <param name="m3_NUC8">Number of lot cards</param>
		/// <param name="m3_SKTS">Suppress Kit Screen</param>
		/// <param name="m3_PSCL">Product structure class</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_PCBO">Percentage BOM</param>
		/// <param name="m3_PPMG">Production lot controlled/op exist</param>
		/// <param name="m3_KPPO">Kit printout PO</param>
		/// <param name="m3_VRNF">WVRNF</param>
		/// <param name="m3_MNPL">Maintained by external system</param>
		/// <param name="m3_AGAP">Allow date gap</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3_FACI, 
			string m3_PRNO, 
			int? m3_CONO = null, 
			string m3_STRT = null, 
			string m3_STAT = null, 
			string m3_RESP = null, 
			string m3_PRTX = null, 
			string m3_DWNO = null, 
			int? m3_SCOM = null, 
			string m3_ECVE = null, 
			int? m3_ECMA = null, 
			string m3_ECON = null, 
			int? m3_FDAT = null, 
			string m3_ECEX = null, 
			int? m3_PFTM = null, 
			string m3_UNMU = null, 
			int? m3_LEAA = null, 
			string m3_EOQT = null, 
			int? m3_EOQM = null, 
			int? m3_LEAL = null, 
			string m3_UNMS = null, 
			int? m3_AOPL = null, 
			string m3_SAOI = null, 
			string m3_TX15 = null, 
			int? m3_DCON = null, 
			int? m3_ASPC = null, 
			int? m3_BACO = null, 
			int? m3_EXPC = null, 
			string m3_TEXQ = null, 
			string m3_BAQT = null, 
			int? m3_SDTB = null, 
			int? m3_PRIB = null, 
			int? m3_NUC1 = null, 
			int? m3_NUC2 = null, 
			int? m3_NUC3 = null, 
			int? m3_NUC4 = null, 
			int? m3_NUC5 = null, 
			int? m3_NUC6 = null, 
			int? m3_NUC7 = null, 
			int? m3_NUMA = null, 
			int? m3_NUBD = null, 
			int? m3_NUOP = null, 
			int? m3_NUPH = null, 
			int? m3_NUSC = null, 
			int? m3_NUEX = null, 
			int? m3_LEVL = null, 
			int? m3_FSCD = null, 
			int? m3_UPCO = null, 
			int? m3_PSET = null, 
			int? m3_SRCD = null, 
			int? m3_SCCD = null, 
			int? m3_KPCD = null, 
			int? m3_PULN = null, 
			int? m3_PULD = null, 
			int? m3_SDAT = null, 
			int? m3_STTE = null, 
			int? m3_NUC8 = null, 
			int? m3_SKTS = null, 
			string m3_PSCL = null, 
			decimal? m3_TXID = null, 
			int? m3_PCBO = null, 
			int? m3_PPMG = null, 
			int? m3_KPPO = null, 
			int? m3_VRNF = null, 
			int? m3_MNPL = null, 
			int? m3_AGAP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRTX))
				request.WithQueryParameter("PRTX", m3_PRTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DWNO))
				request.WithQueryParameter("DWNO", m3_DWNO.Trim());
			if (m3_SCOM.HasValue)
				request.WithQueryParameter("SCOM", m3_SCOM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (m3_ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3_ECMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECON))
				request.WithQueryParameter("ECON", m3_ECON.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECEX))
				request.WithQueryParameter("ECEX", m3_ECEX.Trim());
			if (m3_PFTM.HasValue)
				request.WithQueryParameter("PFTM", m3_PFTM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMU))
				request.WithQueryParameter("UNMU", m3_UNMU.Trim());
			if (m3_LEAA.HasValue)
				request.WithQueryParameter("LEAA", m3_LEAA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EOQT))
				request.WithQueryParameter("EOQT", m3_EOQT.Trim());
			if (m3_EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3_EOQM.Value.ToString());
			if (m3_LEAL.HasValue)
				request.WithQueryParameter("LEAL", m3_LEAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNMS))
				request.WithQueryParameter("UNMS", m3_UNMS.Trim());
			if (m3_AOPL.HasValue)
				request.WithQueryParameter("AOPL", m3_AOPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SAOI))
				request.WithQueryParameter("SAOI", m3_SAOI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_DCON.HasValue)
				request.WithQueryParameter("DCON", m3_DCON.Value.ToString());
			if (m3_ASPC.HasValue)
				request.WithQueryParameter("ASPC", m3_ASPC.Value.ToString());
			if (m3_BACO.HasValue)
				request.WithQueryParameter("BACO", m3_BACO.Value.ToString());
			if (m3_EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3_EXPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEXQ))
				request.WithQueryParameter("TEXQ", m3_TEXQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAQT))
				request.WithQueryParameter("BAQT", m3_BAQT.Trim());
			if (m3_SDTB.HasValue)
				request.WithQueryParameter("SDTB", m3_SDTB.Value.ToString());
			if (m3_PRIB.HasValue)
				request.WithQueryParameter("PRIB", m3_PRIB.Value.ToString());
			if (m3_NUC1.HasValue)
				request.WithQueryParameter("NUC1", m3_NUC1.Value.ToString());
			if (m3_NUC2.HasValue)
				request.WithQueryParameter("NUC2", m3_NUC2.Value.ToString());
			if (m3_NUC3.HasValue)
				request.WithQueryParameter("NUC3", m3_NUC3.Value.ToString());
			if (m3_NUC4.HasValue)
				request.WithQueryParameter("NUC4", m3_NUC4.Value.ToString());
			if (m3_NUC5.HasValue)
				request.WithQueryParameter("NUC5", m3_NUC5.Value.ToString());
			if (m3_NUC6.HasValue)
				request.WithQueryParameter("NUC6", m3_NUC6.Value.ToString());
			if (m3_NUC7.HasValue)
				request.WithQueryParameter("NUC7", m3_NUC7.Value.ToString());
			if (m3_NUMA.HasValue)
				request.WithQueryParameter("NUMA", m3_NUMA.Value.ToString());
			if (m3_NUBD.HasValue)
				request.WithQueryParameter("NUBD", m3_NUBD.Value.ToString());
			if (m3_NUOP.HasValue)
				request.WithQueryParameter("NUOP", m3_NUOP.Value.ToString());
			if (m3_NUPH.HasValue)
				request.WithQueryParameter("NUPH", m3_NUPH.Value.ToString());
			if (m3_NUSC.HasValue)
				request.WithQueryParameter("NUSC", m3_NUSC.Value.ToString());
			if (m3_NUEX.HasValue)
				request.WithQueryParameter("NUEX", m3_NUEX.Value.ToString());
			if (m3_LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3_LEVL.Value.ToString());
			if (m3_FSCD.HasValue)
				request.WithQueryParameter("FSCD", m3_FSCD.Value.ToString());
			if (m3_UPCO.HasValue)
				request.WithQueryParameter("UPCO", m3_UPCO.Value.ToString());
			if (m3_PSET.HasValue)
				request.WithQueryParameter("PSET", m3_PSET.Value.ToString());
			if (m3_SRCD.HasValue)
				request.WithQueryParameter("SRCD", m3_SRCD.Value.ToString());
			if (m3_SCCD.HasValue)
				request.WithQueryParameter("SCCD", m3_SCCD.Value.ToString());
			if (m3_KPCD.HasValue)
				request.WithQueryParameter("KPCD", m3_KPCD.Value.ToString());
			if (m3_PULN.HasValue)
				request.WithQueryParameter("PULN", m3_PULN.Value.ToString());
			if (m3_PULD.HasValue)
				request.WithQueryParameter("PULD", m3_PULD.Value.ToString());
			if (m3_SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3_SDAT.Value.ToString());
			if (m3_STTE.HasValue)
				request.WithQueryParameter("STTE", m3_STTE.Value.ToString());
			if (m3_NUC8.HasValue)
				request.WithQueryParameter("NUC8", m3_NUC8.Value.ToString());
			if (m3_SKTS.HasValue)
				request.WithQueryParameter("SKTS", m3_SKTS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PSCL))
				request.WithQueryParameter("PSCL", m3_PSCL.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_PCBO.HasValue)
				request.WithQueryParameter("PCBO", m3_PCBO.Value.ToString());
			if (m3_PPMG.HasValue)
				request.WithQueryParameter("PPMG", m3_PPMG.Value.ToString());
			if (m3_KPPO.HasValue)
				request.WithQueryParameter("KPPO", m3_KPPO.Value.ToString());
			if (m3_VRNF.HasValue)
				request.WithQueryParameter("VRNF", m3_VRNF.Value.ToString());
			if (m3_MNPL.HasValue)
				request.WithQueryParameter("MNPL", m3_MNPL.Value.ToString());
			if (m3_AGAP.HasValue)
				request.WithQueryParameter("AGAP", m3_AGAP.Value.ToString());

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
