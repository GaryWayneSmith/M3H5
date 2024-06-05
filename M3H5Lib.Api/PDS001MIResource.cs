/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Create
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3PRTX">Product text</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3SCOM">Structure complexity</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3ECMA">ECO managed</param>
		/// <param name="m3ECON">Engineering change order number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3ECEX">Change type</param>
		/// <param name="m3PFTM">Planning time fence</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3LEAA">Leadtime 5 production time all levels</param>
		/// <param name="m3EOQT">Order quantity</param>
		/// <param name="m3EOQM">Order policy</param>
		/// <param name="m3LEAL">Lead time this level</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3AOPL">Alternate routings</param>
		/// <param name="m3SAOI">Standard routing</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3DCON">Dynamic configurator</param>
		/// <param name="m3ASPC">Cumulative scrap percentage</param>
		/// <param name="m3BACO">Batch recalculation</param>
		/// <param name="m3EXPC">Yield percentage</param>
		/// <param name="m3TEXQ">Batch quantity</param>
		/// <param name="m3BAQT">Yield quantity</param>
		/// <param name="m3SDTB">Same date for batches</param>
		/// <param name="m3PRIB">Batch production</param>
		/// <param name="m3NUC1">Number of put-away cards</param>
		/// <param name="m3NUC2">Number of material requisitions</param>
		/// <param name="m3NUC3">Number of labor tickets</param>
		/// <param name="m3NUC4">Number of shop travelers</param>
		/// <param name="m3NUC5">Number of routing cards</param>
		/// <param name="m3NUC6">Number of picking lists</param>
		/// <param name="m3NUC7">Number of design documents</param>
		/// <param name="m3NUMA">Number of components</param>
		/// <param name="m3NUBD">Number of explosion items</param>
		/// <param name="m3NUOP">Number of operations</param>
		/// <param name="m3NUPH">Number of phantom items</param>
		/// <param name="m3NUSC">Number of subcontract operations</param>
		/// <param name="m3NUEX">Number of yield components</param>
		/// <param name="m3LEVL">Lowest level</param>
		/// <param name="m3FSCD">Kit control</param>
		/// <param name="m3UPCO">Full cost summation</param>
		/// <param name="m3PSET">Pricing method</param>
		/// <param name="m3SRCD">Reservation level</param>
		/// <param name="m3SCCD">Statistics level</param>
		/// <param name="m3KPCD">Kit printout</param>
		/// <param name="m3PULN">Pull-up control - nondelayed orders</param>
		/// <param name="m3PULD">Pull-up control - delayed orders</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="m3NUC8">Number of lot cards</param>
		/// <param name="m3SKTS">Suppress Kit Screen</param>
		/// <param name="m3AADP">Add products - not in item master</param>
		/// <param name="m3PSCL">Product structure class</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3PCBO">Percentage BOM</param>
		/// <param name="m3PPMG">Production lot controlled/op exist</param>
		/// <param name="m3KPPO">Kit printout PO</param>
		/// <param name="m3VRNF">Version managed</param>
		/// <param name="m3MNPL">Maintained by external system</param>
		/// <param name="m3AGAP">Allow date gap</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3FACI, 
			string m3PRNO, 
			int? m3CONO = null, 
			string m3STRT = null, 
			string m3STAT = null, 
			string m3RESP = null, 
			string m3PRTX = null, 
			string m3DWNO = null, 
			int? m3SCOM = null, 
			string m3ECVE = null, 
			int? m3ECMA = null, 
			string m3ECON = null, 
			int? m3FDAT = null, 
			string m3ECEX = null, 
			int? m3PFTM = null, 
			string m3UNMU = null, 
			int? m3LEAA = null, 
			string m3EOQT = null, 
			int? m3EOQM = null, 
			int? m3LEAL = null, 
			string m3UNMS = null, 
			int? m3AOPL = null, 
			string m3SAOI = null, 
			string m3TX15 = null, 
			int? m3DCON = null, 
			int? m3ASPC = null, 
			int? m3BACO = null, 
			int? m3EXPC = null, 
			string m3TEXQ = null, 
			string m3BAQT = null, 
			int? m3SDTB = null, 
			int? m3PRIB = null, 
			int? m3NUC1 = null, 
			int? m3NUC2 = null, 
			int? m3NUC3 = null, 
			int? m3NUC4 = null, 
			int? m3NUC5 = null, 
			int? m3NUC6 = null, 
			int? m3NUC7 = null, 
			int? m3NUMA = null, 
			int? m3NUBD = null, 
			int? m3NUOP = null, 
			int? m3NUPH = null, 
			int? m3NUSC = null, 
			int? m3NUEX = null, 
			int? m3LEVL = null, 
			int? m3FSCD = null, 
			int? m3UPCO = null, 
			int? m3PSET = null, 
			int? m3SRCD = null, 
			int? m3SCCD = null, 
			int? m3KPCD = null, 
			int? m3PULN = null, 
			int? m3PULD = null, 
			int? m3SDAT = null, 
			int? m3STTE = null, 
			int? m3NUC8 = null, 
			int? m3SKTS = null, 
			int? m3AADP = null, 
			string m3PSCL = null, 
			decimal? m3TXID = null, 
			int? m3PCBO = null, 
			int? m3PPMG = null, 
			int? m3KPPO = null, 
			int? m3VRNF = null, 
			int? m3MNPL = null, 
			int? m3AGAP = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRTX))
				request.WithQueryParameter("PRTX", m3PRTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (m3SCOM.HasValue)
				request.WithQueryParameter("SCOM", m3SCOM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (m3ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3ECMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECON))
				request.WithQueryParameter("ECON", m3ECON.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECEX))
				request.WithQueryParameter("ECEX", m3ECEX.Trim());
			if (m3PFTM.HasValue)
				request.WithQueryParameter("PFTM", m3PFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMU))
				request.WithQueryParameter("UNMU", m3UNMU.Trim());
			if (m3LEAA.HasValue)
				request.WithQueryParameter("LEAA", m3LEAA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EOQT))
				request.WithQueryParameter("EOQT", m3EOQT.Trim());
			if (m3EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3EOQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEAL.HasValue)
				request.WithQueryParameter("LEAL", m3LEAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (m3AOPL.HasValue)
				request.WithQueryParameter("AOPL", m3AOPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SAOI))
				request.WithQueryParameter("SAOI", m3SAOI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3DCON.HasValue)
				request.WithQueryParameter("DCON", m3DCON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ASPC.HasValue)
				request.WithQueryParameter("ASPC", m3ASPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BACO.HasValue)
				request.WithQueryParameter("BACO", m3BACO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3EXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEXQ))
				request.WithQueryParameter("TEXQ", m3TEXQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAQT))
				request.WithQueryParameter("BAQT", m3BAQT.Trim());
			if (m3SDTB.HasValue)
				request.WithQueryParameter("SDTB", m3SDTB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRIB.HasValue)
				request.WithQueryParameter("PRIB", m3PRIB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC1.HasValue)
				request.WithQueryParameter("NUC1", m3NUC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC2.HasValue)
				request.WithQueryParameter("NUC2", m3NUC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC3.HasValue)
				request.WithQueryParameter("NUC3", m3NUC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC4.HasValue)
				request.WithQueryParameter("NUC4", m3NUC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC5.HasValue)
				request.WithQueryParameter("NUC5", m3NUC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC6.HasValue)
				request.WithQueryParameter("NUC6", m3NUC6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC7.HasValue)
				request.WithQueryParameter("NUC7", m3NUC7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUMA.HasValue)
				request.WithQueryParameter("NUMA", m3NUMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUBD.HasValue)
				request.WithQueryParameter("NUBD", m3NUBD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUOP.HasValue)
				request.WithQueryParameter("NUOP", m3NUOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUPH.HasValue)
				request.WithQueryParameter("NUPH", m3NUPH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUSC.HasValue)
				request.WithQueryParameter("NUSC", m3NUSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUEX.HasValue)
				request.WithQueryParameter("NUEX", m3NUEX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3LEVL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSCD.HasValue)
				request.WithQueryParameter("FSCD", m3FSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPCO.HasValue)
				request.WithQueryParameter("UPCO", m3UPCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSET.HasValue)
				request.WithQueryParameter("PSET", m3PSET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRCD.HasValue)
				request.WithQueryParameter("SRCD", m3SRCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCCD.HasValue)
				request.WithQueryParameter("SCCD", m3SCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KPCD.HasValue)
				request.WithQueryParameter("KPCD", m3KPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PULN.HasValue)
				request.WithQueryParameter("PULN", m3PULN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PULD.HasValue)
				request.WithQueryParameter("PULD", m3PULD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC8.HasValue)
				request.WithQueryParameter("NUC8", m3NUC8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SKTS.HasValue)
				request.WithQueryParameter("SKTS", m3SKTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AADP.HasValue)
				request.WithQueryParameter("AADP", m3AADP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PSCL))
				request.WithQueryParameter("PSCL", m3PSCL.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCBO.HasValue)
				request.WithQueryParameter("PCBO", m3PCBO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPMG.HasValue)
				request.WithQueryParameter("PPMG", m3PPMG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KPPO.HasValue)
				request.WithQueryParameter("KPPO", m3KPPO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VRNF.HasValue)
				request.WithQueryParameter("VRNF", m3VRNF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MNPL.HasValue)
				request.WithQueryParameter("MNPL", m3MNPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGAP.HasValue)
				request.WithQueryParameter("AGAP", m3AGAP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Copy
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3CFAC">To Facility (Required)</param>
		/// <param name="m3CPRN">To Product number (Required)</param>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3CSTR">To Product structure type</param>
		/// <param name="m3CPOP">Copy Operation</param>
		/// <param name="m3CPPV">Copy Variants</param>
		/// <param name="m3AADP">Add products - not in item master</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3FACI, 
			string m3PRNO, 
			string m3CFAC, 
			string m3CPRN, 
			int? m3CONO = null, 
			string m3STRT = null, 
			string m3CSTR = null, 
			string m3CPOP = null, 
			string m3CPPV = null, 
			int? m3AADP = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3CFAC))
				throw new ArgumentNullException(nameof(m3CFAC));
			if (string.IsNullOrWhiteSpace(m3CPRN))
				throw new ArgumentNullException(nameof(m3CPRN));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("CFAC", m3CFAC.Trim())
				.WithQueryParameter("CPRN", m3CPRN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSTR))
				request.WithQueryParameter("CSTR", m3CSTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPOP))
				request.WithQueryParameter("CPOP", m3CPOP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPPV))
				request.WithQueryParameter("CPPV", m3CPPV.Trim());
			if (m3AADP.HasValue)
				request.WithQueryParameter("AADP", m3AADP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CpyProdVersion
		/// Description Copy Product Version
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3FACI">Source Facility (Required)</param>
		/// <param name="m3PRNO">Source Product (Required)</param>
		/// <param name="m3CFAC">Target facility (Required)</param>
		/// <param name="m3CPRN">Target product (Required)</param>
		/// <param name="m3STRT">Source Product structure type</param>
		/// <param name="m3VRSN">Source version</param>
		/// <param name="m3CSTR">Target  structure type</param>
		/// <param name="m3CSTA">Target Product Structure Status</param>
		/// <param name="m3CVRN">Target version</param>
		/// <param name="m3CFDT">Target from date</param>
		/// <param name="m3CTDT">Target to date</param>
		/// <param name="m3CPOP">Copy Operation</param>
		/// <param name="m3AADP">Add products - not in item master</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyProdVersion(
			string m3FACI, 
			string m3PRNO, 
			string m3CFAC, 
			string m3CPRN, 
			string m3STRT = null, 
			int? m3VRSN = null, 
			string m3CSTR = null, 
			string m3CSTA = null, 
			int? m3CVRN = null, 
			DateTime? m3CFDT = null, 
			DateTime? m3CTDT = null, 
			string m3CPOP = null, 
			int? m3AADP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CpyProdVersion",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3CFAC))
				throw new ArgumentNullException(nameof(m3CFAC));
			if (string.IsNullOrWhiteSpace(m3CPRN))
				throw new ArgumentNullException(nameof(m3CPRN));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("CFAC", m3CFAC.Trim())
				.WithQueryParameter("CPRN", m3CPRN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3VRSN.HasValue)
				request.WithQueryParameter("VRSN", m3VRSN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CSTR))
				request.WithQueryParameter("CSTR", m3CSTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSTA))
				request.WithQueryParameter("CSTA", m3CSTA.Trim());
			if (m3CVRN.HasValue)
				request.WithQueryParameter("CVRN", m3CVRN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFDT.HasValue)
				request.WithQueryParameter("CFDT", m3CFDT.Value.ToM3String());
			if (m3CTDT.HasValue)
				request.WithQueryParameter("CTDT", m3CTDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CPOP))
				request.WithQueryParameter("CPOP", m3CPOP.Trim());
			if (m3AADP.HasValue)
				request.WithQueryParameter("AADP", m3AADP.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Delete
		/// Description Delete
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3FACI, 
			string m3PRNO, 
			int? m3CONO = null, 
			string m3STRT = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

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
		/// Name Get
		/// Description Get
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3FACI, 
			string m3PRNO, 
			int? m3CONO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name GetStructParam
		/// Description Get structure parameter (CRS787)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStructParamResponse></returns>
		/// <exception cref="M3Exception<GetStructParamResponse>"></exception>
		public async Task<M3Response<GetStructParamResponse>> GetStructParam(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetStructParam",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetStructParamResponse>(
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
		/// Name List
		/// Description List
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name ListByItem
		/// Description List By Item
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListByItemResponse></returns>
		/// <exception cref="M3Exception<ListByItemResponse>"></exception>
		public async Task<M3Response<ListByItemResponse>> ListByItem(
			string m3PRNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListByItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<ListByItemResponse>(
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
		/// Name SearchProduct
		/// Description Search product
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchProductResponse></returns>
		/// <exception cref="M3Exception<SearchProductResponse>"></exception>
		public async Task<M3Response<SearchProductResponse>> SearchProduct(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchProduct",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchProductResponse>(
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
		/// Name SelEndProd
		/// Description Select End Products
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelEndProdResponse></returns>
		/// <exception cref="M3Exception<SelEndProdResponse>"></exception>
		public async Task<M3Response<SelEndProdResponse>> SelEndProd(
			string m3FACI, 
			string m3APIP = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			DateTime? m3TRDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelEndProd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<SelEndProdResponse>(
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
		/// Description Select Product Structures
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3APIP">APS - policy</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3FACI, 
			string m3APIP = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Select",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

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
		/// Name StartVersioning
		/// Description Start Version for a non version product structure
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3TSTP">Target Structure Type (Required)</param>
		/// <param name="m3FIST">Status after Conversion (Required)</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> StartVersioning(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			string m3TSTP, 
			string m3FIST, 
			int? m3FDAT = null, 
			int? m3TDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartVersioning",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3TSTP))
				throw new ArgumentNullException(nameof(m3TSTP));
			if (string.IsNullOrWhiteSpace(m3FIST))
				throw new ArgumentNullException(nameof(m3FIST));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("TSTP", m3TSTP.Trim())
				.WithQueryParameter("FIST", m3FIST.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Update
		/// Description Update
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3CONO">Company Number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3PRTX">Product text</param>
		/// <param name="m3DWNO">Drawing number</param>
		/// <param name="m3SCOM">Structure complexity</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3ECMA">ECO managed</param>
		/// <param name="m3ECON">Engineering change order number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3ECEX">Change type</param>
		/// <param name="m3PFTM">Planning time fence</param>
		/// <param name="m3UNMU">Order multiple</param>
		/// <param name="m3LEAA">Leadtime 5 production time all levels</param>
		/// <param name="m3EOQT">Order quantity</param>
		/// <param name="m3EOQM">Order policy</param>
		/// <param name="m3LEAL">Lead time this level</param>
		/// <param name="m3UNMS">Basic unit of measure</param>
		/// <param name="m3AOPL">Alternate routings</param>
		/// <param name="m3SAOI">Standard routing</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3DCON">Dynamic configurator</param>
		/// <param name="m3ASPC">Cumulative scrap percentage</param>
		/// <param name="m3BACO">Batch recalculation</param>
		/// <param name="m3EXPC">Yield percentage</param>
		/// <param name="m3TEXQ">Batch quantity</param>
		/// <param name="m3BAQT">Yield quantity</param>
		/// <param name="m3SDTB">Same date for batches</param>
		/// <param name="m3PRIB">Batch production</param>
		/// <param name="m3NUC1">Number of put-away cards</param>
		/// <param name="m3NUC2">Number of material requisitions</param>
		/// <param name="m3NUC3">Number of labor tickets</param>
		/// <param name="m3NUC4">Number of shop travelers</param>
		/// <param name="m3NUC5">Number of routing cards</param>
		/// <param name="m3NUC6">Number of picking lists</param>
		/// <param name="m3NUC7">Number of design documents</param>
		/// <param name="m3NUMA">Number of components</param>
		/// <param name="m3NUBD">Number of explosion items</param>
		/// <param name="m3NUOP">Number of operations</param>
		/// <param name="m3NUPH">Number of phantom items</param>
		/// <param name="m3NUSC">Number of subcontract operations</param>
		/// <param name="m3NUEX">Number of yield components</param>
		/// <param name="m3LEVL">Lowest level</param>
		/// <param name="m3FSCD">Kit control</param>
		/// <param name="m3UPCO">Full cost summation</param>
		/// <param name="m3PSET">Pricing method</param>
		/// <param name="m3SRCD">Reservation level</param>
		/// <param name="m3SCCD">Statistics level</param>
		/// <param name="m3KPCD">Kit printout</param>
		/// <param name="m3PULN">Pull-up control - nondelayed orders</param>
		/// <param name="m3PULD">Pull-up control - delayed orders</param>
		/// <param name="m3SDAT">Clock date</param>
		/// <param name="m3STTE">Clock time</param>
		/// <param name="m3NUC8">Number of lot cards</param>
		/// <param name="m3SKTS">Suppress Kit Screen</param>
		/// <param name="m3PSCL">Product structure class</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3PCBO">Percentage BOM</param>
		/// <param name="m3PPMG">Production lot controlled/op exist</param>
		/// <param name="m3KPPO">Kit printout PO</param>
		/// <param name="m3VRNF">WVRNF</param>
		/// <param name="m3MNPL">Maintained by external system</param>
		/// <param name="m3AGAP">Allow date gap</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3FACI, 
			string m3PRNO, 
			int? m3CONO = null, 
			string m3STRT = null, 
			string m3STAT = null, 
			string m3RESP = null, 
			string m3PRTX = null, 
			string m3DWNO = null, 
			int? m3SCOM = null, 
			string m3ECVE = null, 
			int? m3ECMA = null, 
			string m3ECON = null, 
			int? m3FDAT = null, 
			string m3ECEX = null, 
			int? m3PFTM = null, 
			string m3UNMU = null, 
			int? m3LEAA = null, 
			string m3EOQT = null, 
			int? m3EOQM = null, 
			int? m3LEAL = null, 
			string m3UNMS = null, 
			int? m3AOPL = null, 
			string m3SAOI = null, 
			string m3TX15 = null, 
			int? m3DCON = null, 
			int? m3ASPC = null, 
			int? m3BACO = null, 
			int? m3EXPC = null, 
			string m3TEXQ = null, 
			string m3BAQT = null, 
			int? m3SDTB = null, 
			int? m3PRIB = null, 
			int? m3NUC1 = null, 
			int? m3NUC2 = null, 
			int? m3NUC3 = null, 
			int? m3NUC4 = null, 
			int? m3NUC5 = null, 
			int? m3NUC6 = null, 
			int? m3NUC7 = null, 
			int? m3NUMA = null, 
			int? m3NUBD = null, 
			int? m3NUOP = null, 
			int? m3NUPH = null, 
			int? m3NUSC = null, 
			int? m3NUEX = null, 
			int? m3LEVL = null, 
			int? m3FSCD = null, 
			int? m3UPCO = null, 
			int? m3PSET = null, 
			int? m3SRCD = null, 
			int? m3SCCD = null, 
			int? m3KPCD = null, 
			int? m3PULN = null, 
			int? m3PULD = null, 
			int? m3SDAT = null, 
			int? m3STTE = null, 
			int? m3NUC8 = null, 
			int? m3SKTS = null, 
			string m3PSCL = null, 
			decimal? m3TXID = null, 
			int? m3PCBO = null, 
			int? m3PPMG = null, 
			int? m3KPPO = null, 
			int? m3VRNF = null, 
			int? m3MNPL = null, 
			int? m3AGAP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRTX))
				request.WithQueryParameter("PRTX", m3PRTX.Trim());
			if (!string.IsNullOrWhiteSpace(m3DWNO))
				request.WithQueryParameter("DWNO", m3DWNO.Trim());
			if (m3SCOM.HasValue)
				request.WithQueryParameter("SCOM", m3SCOM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (m3ECMA.HasValue)
				request.WithQueryParameter("ECMA", m3ECMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECON))
				request.WithQueryParameter("ECON", m3ECON.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECEX))
				request.WithQueryParameter("ECEX", m3ECEX.Trim());
			if (m3PFTM.HasValue)
				request.WithQueryParameter("PFTM", m3PFTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMU))
				request.WithQueryParameter("UNMU", m3UNMU.Trim());
			if (m3LEAA.HasValue)
				request.WithQueryParameter("LEAA", m3LEAA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EOQT))
				request.WithQueryParameter("EOQT", m3EOQT.Trim());
			if (m3EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3EOQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEAL.HasValue)
				request.WithQueryParameter("LEAL", m3LEAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNMS))
				request.WithQueryParameter("UNMS", m3UNMS.Trim());
			if (m3AOPL.HasValue)
				request.WithQueryParameter("AOPL", m3AOPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SAOI))
				request.WithQueryParameter("SAOI", m3SAOI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3DCON.HasValue)
				request.WithQueryParameter("DCON", m3DCON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ASPC.HasValue)
				request.WithQueryParameter("ASPC", m3ASPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BACO.HasValue)
				request.WithQueryParameter("BACO", m3BACO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXPC.HasValue)
				request.WithQueryParameter("EXPC", m3EXPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEXQ))
				request.WithQueryParameter("TEXQ", m3TEXQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAQT))
				request.WithQueryParameter("BAQT", m3BAQT.Trim());
			if (m3SDTB.HasValue)
				request.WithQueryParameter("SDTB", m3SDTB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRIB.HasValue)
				request.WithQueryParameter("PRIB", m3PRIB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC1.HasValue)
				request.WithQueryParameter("NUC1", m3NUC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC2.HasValue)
				request.WithQueryParameter("NUC2", m3NUC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC3.HasValue)
				request.WithQueryParameter("NUC3", m3NUC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC4.HasValue)
				request.WithQueryParameter("NUC4", m3NUC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC5.HasValue)
				request.WithQueryParameter("NUC5", m3NUC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC6.HasValue)
				request.WithQueryParameter("NUC6", m3NUC6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC7.HasValue)
				request.WithQueryParameter("NUC7", m3NUC7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUMA.HasValue)
				request.WithQueryParameter("NUMA", m3NUMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUBD.HasValue)
				request.WithQueryParameter("NUBD", m3NUBD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUOP.HasValue)
				request.WithQueryParameter("NUOP", m3NUOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUPH.HasValue)
				request.WithQueryParameter("NUPH", m3NUPH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUSC.HasValue)
				request.WithQueryParameter("NUSC", m3NUSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUEX.HasValue)
				request.WithQueryParameter("NUEX", m3NUEX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LEVL.HasValue)
				request.WithQueryParameter("LEVL", m3LEVL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSCD.HasValue)
				request.WithQueryParameter("FSCD", m3FSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPCO.HasValue)
				request.WithQueryParameter("UPCO", m3UPCO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PSET.HasValue)
				request.WithQueryParameter("PSET", m3PSET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRCD.HasValue)
				request.WithQueryParameter("SRCD", m3SRCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCCD.HasValue)
				request.WithQueryParameter("SCCD", m3SCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KPCD.HasValue)
				request.WithQueryParameter("KPCD", m3KPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PULN.HasValue)
				request.WithQueryParameter("PULN", m3PULN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PULD.HasValue)
				request.WithQueryParameter("PULD", m3PULD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SDAT.HasValue)
				request.WithQueryParameter("SDAT", m3SDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STTE.HasValue)
				request.WithQueryParameter("STTE", m3STTE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC8.HasValue)
				request.WithQueryParameter("NUC8", m3NUC8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SKTS.HasValue)
				request.WithQueryParameter("SKTS", m3SKTS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PSCL))
				request.WithQueryParameter("PSCL", m3PSCL.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PCBO.HasValue)
				request.WithQueryParameter("PCBO", m3PCBO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPMG.HasValue)
				request.WithQueryParameter("PPMG", m3PPMG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KPPO.HasValue)
				request.WithQueryParameter("KPPO", m3KPPO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VRNF.HasValue)
				request.WithQueryParameter("VRNF", m3VRNF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MNPL.HasValue)
				request.WithQueryParameter("MNPL", m3MNPL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGAP.HasValue)
				request.WithQueryParameter("AGAP", m3AGAP.Value.ToString(CultureInfo.CurrentCulture));

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
