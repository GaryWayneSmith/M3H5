/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PMS170MI;
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
	/// Name: PMS170MI
	/// Component Name: ManufacturingOrderProposals
	/// Description: Manufacturing order proposals interface
	/// Version Release: 5ea2
	///</summary>
	public partial class PMS170MIResource : M3BaseResourceEndpoint
	{
		public PMS170MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PMS170MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ClrSimulatedMOP
		/// Description Clear simulated MOP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClrSimulatedMOP(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClrSimulatedMOP",
			};

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
		/// Name CrtPlannedMO
		/// Description Create Planned Manufacturing proposal
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_PPQT">Planned quantity (Required)</param>
		/// <param name="m3_PLDT">Planning date (Required)</param>
		/// <param name="m3_PLHM">Planning time (Required)</param>
		/// <param name="m3_PSTS">Status - planned order (Required)</param>
		/// <param name="m3_SIMD">Simulation (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_AOID">Alternative routing</param>
		/// <param name="m3_CFXX">Old CFIN</param>
		/// <param name="m3_ECVS">Simulation round</param>
		/// <param name="m3_PLPN">Planned order</param>
		/// <param name="m3_CPLP">Copy from planned MO.</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_MFPC">Process</param>
		/// <param name="m3_PCCO">Process code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CrtPlannedMO(
			string m3_FACI, 
			string m3_WHLO, 
			string m3_PRNO, 
			decimal m3_PPQT, 
			DateTime m3_PLDT, 
			int m3_PLHM, 
			string m3_PSTS, 
			int m3_SIMD, 
			int? m3_CONO = null, 
			string m3_STRT = null, 
			string m3_ORTY = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			int? m3_RORC = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			decimal? m3_SCHN = null, 
			string m3_AOID = null, 
			int? m3_CFXX = null, 
			int? m3_ECVS = null, 
			int? m3_PLPN = null, 
			int? m3_CPLP = null, 
			long? m3_CFIN = null, 
			string m3_MFPC = null, 
			int? m3_PCCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CrtPlannedMO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_PSTS))
				throw new ArgumentNullException("m3_PSTS");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("PPQT", m3_PPQT.ToString())
				.WithQueryParameter("PLDT", m3_PLDT.ToM3String())
				.WithQueryParameter("PLHM", m3_PLHM.ToString())
				.WithQueryParameter("PSTS", m3_PSTS.Trim())
				.WithQueryParameter("SIMD", m3_SIMD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOID))
				request.WithQueryParameter("AOID", m3_AOID.Trim());
			if (m3_CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3_CFXX.Value.ToString());
			if (m3_ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3_ECVS.Value.ToString());
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());
			if (m3_CPLP.HasValue)
				request.WithQueryParameter("CPLP", m3_CPLP.Value.ToString());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MFPC))
				request.WithQueryParameter("MFPC", m3_MFPC.Trim());
			if (m3_PCCO.HasValue)
				request.WithQueryParameter("PCCO", m3_PCCO.Value.ToString());

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
		/// Name DelPlannedMO
		/// Description DelPlannedMO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPS">Subnumber - planned order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPlannedMO(
			int m3_PLPN, 
			int? m3_CONO = null, 
			int? m3_PLPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelPlannedMO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3_PLPS.Value.ToString());

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
		/// Description Get manufacturing order proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RIDN">Proposal number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			long m3_RIDN, 
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			string m3_FACI = null, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("RIDN", m3_RIDN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());

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
		/// Name LstByRORN
		/// Description List by reference order number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RORN">Reference order number (Required)</param>
		/// <param name="m3_RORL">Reference order line (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByRORNResponse></returns>
		/// <exception cref="M3Exception<LstByRORNResponse>"></exception>
		public async Task<M3Response<LstByRORNResponse>> LstByRORN(
			string m3_RORN, 
			int m3_RORL, 
			int? m3_CONO = null, 
			int? m3_RORX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByRORN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RORN))
				throw new ArgumentNullException("m3_RORN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RORN", m3_RORN.Trim())
				.WithQueryParameter("RORL", m3_RORL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());

			// Execute the request
			var result = await Execute<LstByRORNResponse>(
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
		/// Name SearchMOP
		/// Description Search MOP
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchMOPResponse></returns>
		/// <exception cref="M3Exception<SearchMOPResponse>"></exception>
		public async Task<M3Response<SearchMOPResponse>> SearchMOP(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchMOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchMOPResponse>(
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
		/// Name SelConfigAttr
		/// Description Selection of manufacturing order proposals
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACF">From facility (Required)</param>
		/// <param name="m3_FACT">To facility (Required)</param>
		/// <param name="m3_STSF">From status (Required)</param>
		/// <param name="m3_STST">To status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp date</param>
		/// <param name="m3_TIME">Timestamp time</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_FWHS">From warehouse</param>
		/// <param name="m3_TWHS">To warehouse</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelConfigAttrResponse></returns>
		/// <exception cref="M3Exception<SelConfigAttrResponse>"></exception>
		public async Task<M3Response<SelConfigAttrResponse>> SelConfigAttr(
			string m3_FACF, 
			string m3_FACT, 
			int m3_STSF, 
			int m3_STST, 
			int? m3_CONO = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_FWHS = null, 
			string m3_TWHS = null, 
			string m3_WHGR = null, 
			string m3_APIP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelConfigAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACF))
				throw new ArgumentNullException("m3_FACF");
			if (string.IsNullOrWhiteSpace(m3_FACT))
				throw new ArgumentNullException("m3_FACT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3_FACF.Trim())
				.WithQueryParameter("FACT", m3_FACT.Trim())
				.WithQueryParameter("STSF", m3_STSF.ToString())
				.WithQueryParameter("STST", m3_STST.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_TIME.HasValue)
				request.WithQueryParameter("TIME", m3_TIME.Value.ToString());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWHS))
				request.WithQueryParameter("FWHS", m3_FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHS))
				request.WithQueryParameter("TWHS", m3_TWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());

			// Execute the request
			var result = await Execute<SelConfigAttrResponse>(
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
		/// Name SelFashionAttr
		/// Description Selection of manufacturing order proposals
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACF">From facility (Required)</param>
		/// <param name="m3_FACT">To facility (Required)</param>
		/// <param name="m3_STSF">From status (Required)</param>
		/// <param name="m3_STST">To status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp date</param>
		/// <param name="m3_TIME">Timestamp time</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_FWHS">From warehouse</param>
		/// <param name="m3_TWHS">To warehouse</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelFashionAttrResponse></returns>
		/// <exception cref="M3Exception<SelFashionAttrResponse>"></exception>
		public async Task<M3Response<SelFashionAttrResponse>> SelFashionAttr(
			string m3_FACF, 
			string m3_FACT, 
			int m3_STSF, 
			int m3_STST, 
			int? m3_CONO = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_FWHS = null, 
			string m3_TWHS = null, 
			string m3_WHGR = null, 
			string m3_APIP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelFashionAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACF))
				throw new ArgumentNullException("m3_FACF");
			if (string.IsNullOrWhiteSpace(m3_FACT))
				throw new ArgumentNullException("m3_FACT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3_FACF.Trim())
				.WithQueryParameter("FACT", m3_FACT.Trim())
				.WithQueryParameter("STSF", m3_STSF.ToString())
				.WithQueryParameter("STST", m3_STST.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_TIME.HasValue)
				request.WithQueryParameter("TIME", m3_TIME.Value.ToString());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWHS))
				request.WithQueryParameter("FWHS", m3_FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHS))
				request.WithQueryParameter("TWHS", m3_TWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());

			// Execute the request
			var result = await Execute<SelFashionAttrResponse>(
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
		/// Name SelMatByHead
		/// Description Select material By Order Header
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FSTS">From Status</param>
		/// <param name="m3_TSTS">To Status</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp date</param>
		/// <param name="m3_TIME">Timestamp time</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="m3_SINV">Select only inv.acc(STCD) equals one</param>
		/// <param name="m3_DBYP">De-select By products</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_PLET">Included planning entity proposals</param>
		/// <param name="m3_PLPN">Manufacturing order proposal number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMatByHeadResponse></returns>
		/// <exception cref="M3Exception<SelMatByHeadResponse>"></exception>
		public async Task<M3Response<SelMatByHeadResponse>> SelMatByHead(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_FSTS = null, 
			string m3_TSTS = null, 
			string m3_WHGR = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_APIP = null, 
			int? m3_SINV = null, 
			int? m3_DBYP = null, 
			int? m3_SIMD = null, 
			int? m3_PLET = null, 
			int? m3_PLPN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelMatByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSTS))
				request.WithQueryParameter("FSTS", m3_FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTS))
				request.WithQueryParameter("TSTS", m3_TSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_TIME.HasValue)
				request.WithQueryParameter("TIME", m3_TIME.Value.ToString());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (m3_SINV.HasValue)
				request.WithQueryParameter("SINV", m3_SINV.Value.ToString());
			if (m3_DBYP.HasValue)
				request.WithQueryParameter("DBYP", m3_DBYP.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_PLET.HasValue)
				request.WithQueryParameter("PLET", m3_PLET.Value.ToString());
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());

			// Execute the request
			var result = await Execute<SelMatByHeadResponse>(
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
		/// Name SelMaterials
		/// Description Selection manufacturing order proposal materials
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RIDN">Manufacturing order proposal number</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_SINV">Select only inv.acc(STCD) equals one</param>
		/// <param name="m3_DBYP">De-select By products</param>
		/// <param name="m3_SIMD">Simualtion</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMaterialsResponse></returns>
		/// <exception cref="M3Exception<SelMaterialsResponse>"></exception>
		public async Task<M3Response<SelMaterialsResponse>> SelMaterials(
			string m3_WHLO, 
			int? m3_CONO = null, 
			long? m3_RIDN = null, 
			string m3_WHGR = null, 
			int? m3_SINV = null, 
			int? m3_DBYP = null, 
			int? m3_SIMD = null, 
			string m3_APIP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelMaterials",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RIDN.HasValue)
				request.WithQueryParameter("RIDN", m3_RIDN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (m3_SINV.HasValue)
				request.WithQueryParameter("SINV", m3_SINV.Value.ToString());
			if (m3_DBYP.HasValue)
				request.WithQueryParameter("DBYP", m3_DBYP.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());

			// Execute the request
			var result = await Execute<SelMaterialsResponse>(
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
		/// Name SelOpeByHead
		/// Description Select Operation By Order Header
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FSTS">From Status</param>
		/// <param name="m3_TSTS">To Status</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp date</param>
		/// <param name="m3_TIME">Timestamp time</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_PLET">Included planning entity proposals</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOpeByHeadResponse></returns>
		/// <exception cref="M3Exception<SelOpeByHeadResponse>"></exception>
		public async Task<M3Response<SelOpeByHeadResponse>> SelOpeByHead(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_FSTS = null, 
			string m3_TSTS = null, 
			string m3_WHGR = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_APIP = null, 
			int? m3_SIMD = null, 
			int? m3_PLET = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelOpeByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSTS))
				request.WithQueryParameter("FSTS", m3_FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTS))
				request.WithQueryParameter("TSTS", m3_TSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_TIME.HasValue)
				request.WithQueryParameter("TIME", m3_TIME.Value.ToString());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_PLET.HasValue)
				request.WithQueryParameter("PLET", m3_PLET.Value.ToString());

			// Execute the request
			var result = await Execute<SelOpeByHeadResponse>(
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
		/// Name SelOperations
		/// Description Selection of manufacturing order proposal operations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RIDN">Proposal number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_REAO">Read all operations</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOperationsResponse></returns>
		/// <exception cref="M3Exception<SelOperationsResponse>"></exception>
		public async Task<M3Response<SelOperationsResponse>> SelOperations(
			string m3_FACI, 
			int? m3_CONO = null, 
			long? m3_RIDN = null, 
			string m3_WHLO = null, 
			string m3_REAO = null, 
			string m3_WHGR = null, 
			int? m3_SIMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelOperations",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_RIDN.HasValue)
				request.WithQueryParameter("RIDN", m3_RIDN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAO))
				request.WithQueryParameter("REAO", m3_REAO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());

			// Execute the request
			var result = await Execute<SelOperationsResponse>(
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
		/// Name SelOrderHead
		/// Description Selection of manufacturing order proposals
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FSTS">From Status</param>
		/// <param name="m3_TSTS">To Status</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp date</param>
		/// <param name="m3_TIME">Timestamp time</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="m3_SLEN">Select Endproducts (1=Yes)</param>
		/// <param name="m3_PLET">Included planning entity proposals</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOrderHeadResponse></returns>
		/// <exception cref="M3Exception<SelOrderHeadResponse>"></exception>
		public async Task<M3Response<SelOrderHeadResponse>> SelOrderHead(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_FSTS = null, 
			string m3_TSTS = null, 
			string m3_WHGR = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_APIP = null, 
			int? m3_SLEN = null, 
			int? m3_PLET = null, 
			int? m3_SIMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelOrderHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSTS))
				request.WithQueryParameter("FSTS", m3_FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTS))
				request.WithQueryParameter("TSTS", m3_TSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_TIME.HasValue)
				request.WithQueryParameter("TIME", m3_TIME.Value.ToString());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());
			if (m3_SLEN.HasValue)
				request.WithQueryParameter("SLEN", m3_SLEN.Value.ToString());
			if (m3_PLET.HasValue)
				request.WithQueryParameter("PLET", m3_PLET.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());

			// Execute the request
			var result = await Execute<SelOrderHeadResponse>(
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
		/// Description Selection of manufacturing order proposals
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACF">From facility (Required)</param>
		/// <param name="m3_FACT">To facility (Required)</param>
		/// <param name="m3_STSF">From status (Required)</param>
		/// <param name="m3_STST">To status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DATE">Timestamp date</param>
		/// <param name="m3_TIME">Timestamp time</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_FWHS">From warehouse</param>
		/// <param name="m3_TWHS">To warehouse</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_SLEN">Select Endproducts (1=Yes)</param>
		/// <param name="m3_PLET">Included planning entity proposals</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3_FACF, 
			string m3_FACT, 
			int m3_STSF, 
			int m3_STST, 
			int? m3_CONO = null, 
			string m3_REAR = null, 
			DateTime? m3_DATE = null, 
			int? m3_TIME = null, 
			int? m3_SCHH = null, 
			string m3_FWHS = null, 
			string m3_TWHS = null, 
			string m3_WHGR = null, 
			int? m3_SLEN = null, 
			int? m3_PLET = null, 
			int? m3_SIMD = null, 
			string m3_APIP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACF))
				throw new ArgumentNullException("m3_FACF");
			if (string.IsNullOrWhiteSpace(m3_FACT))
				throw new ArgumentNullException("m3_FACT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3_FACF.Trim())
				.WithQueryParameter("FACT", m3_FACT.Trim())
				.WithQueryParameter("STSF", m3_STSF.ToString())
				.WithQueryParameter("STST", m3_STST.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_TIME.HasValue)
				request.WithQueryParameter("TIME", m3_TIME.Value.ToString());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWHS))
				request.WithQueryParameter("FWHS", m3_FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHS))
				request.WithQueryParameter("TWHS", m3_TWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (m3_SLEN.HasValue)
				request.WithQueryParameter("SLEN", m3_SLEN.Value.ToString());
			if (m3_PLET.HasValue)
				request.WithQueryParameter("PLET", m3_PLET.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());

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
		/// Name SetStatus
		/// Description Set manufacturing order proposal status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Proposal number (Required)</param>
		/// <param name="m3_PSTS">Proposal status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetStatus(
			int m3_PLPN, 
			int m3_PSTS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetStatus",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString())
				.WithQueryParameter("PSTS", m3_PSTS.ToString());

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
		/// Name Updat
		/// Description Update
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PLPN">Planned order (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_PUIT">Acqusition code</param>
		/// <param name="m3_SCHN">Schedule number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_MSTI">Start time</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_MFTI">Finish time</param>
		/// <param name="m3_ORQA">Orderd quantity</param>
		/// <param name="m3_MAUN">Manufacturing U/M</param>
		/// <param name="m3_PSTS">Status - planned order</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_AOID">Alternate routing</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_RORC">Ref order category</param>
		/// <param name="m3_RORN">Ref order number</param>
		/// <param name="m3_RORL">Ref order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_WHST">Status manufacturing order</param>
		/// <param name="m3_WCLN">Production line</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_DSP1">Warning indicator 1</param>
		/// <param name="m3_DSP3">Warning indicator 3</param>
		/// <param name="m3_DSP4">Warning indicator 4</param>
		/// <param name="m3_DSP6">Warning indicator 6</param>
		/// <param name="m3_DSP7">Warning indicator 7</param>
		/// <param name="m3_DSP8">Warning indicator 8</param>
		/// <param name="m3_MFPC">Process</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Updat(
			int m3_PLPN, 
			int? m3_CONO = null, 
			string m3_RESP = null, 
			int? m3_PUIT = null, 
			decimal? m3_SCHN = null, 
			DateTime? m3_STDT = null, 
			int? m3_MSTI = null, 
			DateTime? m3_FIDT = null, 
			int? m3_MFTI = null, 
			decimal? m3_ORQA = null, 
			string m3_MAUN = null, 
			string m3_PSTS = null, 
			string m3_PRIP = null, 
			string m3_AOID = null, 
			string m3_ORTY = null, 
			string m3_STRT = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_WHST = null, 
			string m3_WCLN = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_DSP1 = null, 
			string m3_DSP3 = null, 
			string m3_DSP4 = null, 
			string m3_DSP6 = null, 
			string m3_DSP7 = null, 
			string m3_DSP8 = null, 
			string m3_MFPC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Updat",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3_PLPN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3_PUIT.Value.ToString());
			if (m3_SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3_SCHN.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3_MSTI.Value.ToString());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3_MFTI.Value.ToString());
			if (m3_ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3_ORQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MAUN))
				request.WithQueryParameter("MAUN", m3_MAUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSTS))
				request.WithQueryParameter("PSTS", m3_PSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOID))
				request.WithQueryParameter("AOID", m3_AOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHST))
				request.WithQueryParameter("WHST", m3_WHST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WCLN))
				request.WithQueryParameter("WCLN", m3_WCLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP1))
				request.WithQueryParameter("DSP1", m3_DSP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP3))
				request.WithQueryParameter("DSP3", m3_DSP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP4))
				request.WithQueryParameter("DSP4", m3_DSP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP6))
				request.WithQueryParameter("DSP6", m3_DSP6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP7))
				request.WithQueryParameter("DSP7", m3_DSP7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSP8))
				request.WithQueryParameter("DSP8", m3_DSP8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFPC))
				request.WithQueryParameter("MFPC", m3_MFPC.Trim());

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
