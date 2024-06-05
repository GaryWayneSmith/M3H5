/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ClrSimulatedMOP
		/// Description Clear simulated MOP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClrSimulatedMOP(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ClrSimulatedMOP",
			};

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
		/// Name CrtPlannedMO
		/// Description Create Planned Manufacturing proposal
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3PPQT">Planned quantity (Required)</param>
		/// <param name="m3PLDT">Planning date (Required)</param>
		/// <param name="m3PLHM">Planning time (Required)</param>
		/// <param name="m3PSTS">Status - planned order (Required)</param>
		/// <param name="m3SIMD">Simulation (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3AOID">Alternative routing</param>
		/// <param name="m3CFXX">Old CFIN</param>
		/// <param name="m3ECVS">Simulation round</param>
		/// <param name="m3PLPN">Planned order</param>
		/// <param name="m3CPLP">Copy from planned MO.</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3MFPC">Process</param>
		/// <param name="m3PCCO">Process code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CrtPlannedMO(
			string m3FACI, 
			string m3WHLO, 
			string m3PRNO, 
			decimal m3PPQT, 
			DateTime m3PLDT, 
			int m3PLHM, 
			string m3PSTS, 
			int m3SIMD, 
			int? m3CONO = null, 
			string m3STRT = null, 
			string m3ORTY = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			int? m3RORC = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			decimal? m3SCHN = null, 
			string m3AOID = null, 
			int? m3CFXX = null, 
			int? m3ECVS = null, 
			int? m3PLPN = null, 
			int? m3CPLP = null, 
			long? m3CFIN = null, 
			string m3MFPC = null, 
			int? m3PCCO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CrtPlannedMO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3PSTS))
				throw new ArgumentNullException(nameof(m3PSTS));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("PPQT", m3PPQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLDT", m3PLDT.ToM3String())
				.WithQueryParameter("PLHM", m3PLHM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PSTS", m3PSTS.Trim())
				.WithQueryParameter("SIMD", m3SIMD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AOID))
				request.WithQueryParameter("AOID", m3AOID.Trim());
			if (m3CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3CFXX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3ECVS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3PLPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPLP.HasValue)
				request.WithQueryParameter("CPLP", m3CPLP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MFPC))
				request.WithQueryParameter("MFPC", m3MFPC.Trim());
			if (m3PCCO.HasValue)
				request.WithQueryParameter("PCCO", m3PCCO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelPlannedMO
		/// Description DelPlannedMO
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPS">Subnumber - planned order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPlannedMO(
			int m3PLPN, 
			int? m3CONO = null, 
			int? m3PLPS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelPlannedMO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Get manufacturing order proposal
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RIDN">Proposal number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			long m3RIDN, 
			int? m3CONO = null, 
			string m3WHLO = null, 
			string m3FACI = null, 
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

			// Set mandatory parameters
			request
				.WithQueryParameter("RIDN", m3RIDN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());

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
		/// Name LstByRORN
		/// Description List by reference order number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RORN">Reference order number (Required)</param>
		/// <param name="m3RORL">Reference order line (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByRORNResponse></returns>
		/// <exception cref="M3Exception<LstByRORNResponse>"></exception>
		public async Task<M3Response<LstByRORNResponse>> LstByRORN(
			string m3RORN, 
			int m3RORL, 
			int? m3CONO = null, 
			int? m3RORX = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByRORN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RORN))
				throw new ArgumentNullException(nameof(m3RORN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RORN", m3RORN.Trim())
				.WithQueryParameter("RORL", m3RORL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstByRORNResponse>(
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
		/// Name SearchMOP
		/// Description Search MOP
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchMOPResponse></returns>
		/// <exception cref="M3Exception<SearchMOPResponse>"></exception>
		public async Task<M3Response<SearchMOPResponse>> SearchMOP(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchMOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchMOPResponse>(
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
		/// Name SelConfigAttr
		/// Description Selection of manufacturing order proposals
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACF">From facility (Required)</param>
		/// <param name="m3FACT">To facility (Required)</param>
		/// <param name="m3STSF">From status (Required)</param>
		/// <param name="m3STST">To status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DATE">Timestamp date</param>
		/// <param name="m3TIME">Timestamp time</param>
		/// <param name="m3SCHH">Scheduling horizon</param>
		/// <param name="m3FWHS">From warehouse</param>
		/// <param name="m3TWHS">To warehouse</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelConfigAttrResponse></returns>
		/// <exception cref="M3Exception<SelConfigAttrResponse>"></exception>
		public async Task<M3Response<SelConfigAttrResponse>> SelConfigAttr(
			string m3FACF, 
			string m3FACT, 
			int m3STSF, 
			int m3STST, 
			int? m3CONO = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3FWHS = null, 
			string m3TWHS = null, 
			string m3WHGR = null, 
			string m3APIP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelConfigAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACF))
				throw new ArgumentNullException(nameof(m3FACF));
			if (string.IsNullOrWhiteSpace(m3FACT))
				throw new ArgumentNullException(nameof(m3FACT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3FACF.Trim())
				.WithQueryParameter("FACT", m3FACT.Trim())
				.WithQueryParameter("STSF", m3STSF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STST", m3STST.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3TIME.HasValue)
				request.WithQueryParameter("TIME", m3TIME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHS))
				request.WithQueryParameter("FWHS", m3FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHS))
				request.WithQueryParameter("TWHS", m3TWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());

			// Execute the request
			var result = await Execute<SelConfigAttrResponse>(
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
		/// Name SelFashionAttr
		/// Description Selection of manufacturing order proposals
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACF">From facility (Required)</param>
		/// <param name="m3FACT">To facility (Required)</param>
		/// <param name="m3STSF">From status (Required)</param>
		/// <param name="m3STST">To status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DATE">Timestamp date</param>
		/// <param name="m3TIME">Timestamp time</param>
		/// <param name="m3SCHH">Scheduling horizon</param>
		/// <param name="m3FWHS">From warehouse</param>
		/// <param name="m3TWHS">To warehouse</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelFashionAttrResponse></returns>
		/// <exception cref="M3Exception<SelFashionAttrResponse>"></exception>
		public async Task<M3Response<SelFashionAttrResponse>> SelFashionAttr(
			string m3FACF, 
			string m3FACT, 
			int m3STSF, 
			int m3STST, 
			int? m3CONO = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3FWHS = null, 
			string m3TWHS = null, 
			string m3WHGR = null, 
			string m3APIP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelFashionAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACF))
				throw new ArgumentNullException(nameof(m3FACF));
			if (string.IsNullOrWhiteSpace(m3FACT))
				throw new ArgumentNullException(nameof(m3FACT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3FACF.Trim())
				.WithQueryParameter("FACT", m3FACT.Trim())
				.WithQueryParameter("STSF", m3STSF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STST", m3STST.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3TIME.HasValue)
				request.WithQueryParameter("TIME", m3TIME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHS))
				request.WithQueryParameter("FWHS", m3FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHS))
				request.WithQueryParameter("TWHS", m3TWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());

			// Execute the request
			var result = await Execute<SelFashionAttrResponse>(
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
		/// Name SelMatByHead
		/// Description Select material By Order Header
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FSTS">From Status</param>
		/// <param name="m3TSTS">To Status</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DATE">Timestamp date</param>
		/// <param name="m3TIME">Timestamp time</param>
		/// <param name="m3SCHH">Scheduling horizon</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="m3SINV">Select only inv.acc(STCD) equals one</param>
		/// <param name="m3DBYP">De-select By products</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3PLET">Included planning entity proposals</param>
		/// <param name="m3PLPN">Manufacturing order proposal number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMatByHeadResponse></returns>
		/// <exception cref="M3Exception<SelMatByHeadResponse>"></exception>
		public async Task<M3Response<SelMatByHeadResponse>> SelMatByHead(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3FSTS = null, 
			string m3TSTS = null, 
			string m3WHGR = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3APIP = null, 
			int? m3SINV = null, 
			int? m3DBYP = null, 
			int? m3SIMD = null, 
			int? m3PLET = null, 
			int? m3PLPN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelMatByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSTS))
				request.WithQueryParameter("FSTS", m3FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTS))
				request.WithQueryParameter("TSTS", m3TSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3TIME.HasValue)
				request.WithQueryParameter("TIME", m3TIME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3SINV.HasValue)
				request.WithQueryParameter("SINV", m3SINV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DBYP.HasValue)
				request.WithQueryParameter("DBYP", m3DBYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLET.HasValue)
				request.WithQueryParameter("PLET", m3PLET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3PLPN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelMatByHeadResponse>(
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
		/// Name SelMaterials
		/// Description Selection manufacturing order proposal materials
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RIDN">Manufacturing order proposal number</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3SINV">Select only inv.acc(STCD) equals one</param>
		/// <param name="m3DBYP">De-select By products</param>
		/// <param name="m3SIMD">Simualtion</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMaterialsResponse></returns>
		/// <exception cref="M3Exception<SelMaterialsResponse>"></exception>
		public async Task<M3Response<SelMaterialsResponse>> SelMaterials(
			string m3WHLO, 
			int? m3CONO = null, 
			long? m3RIDN = null, 
			string m3WHGR = null, 
			int? m3SINV = null, 
			int? m3DBYP = null, 
			int? m3SIMD = null, 
			string m3APIP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelMaterials",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDN.HasValue)
				request.WithQueryParameter("RIDN", m3RIDN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3SINV.HasValue)
				request.WithQueryParameter("SINV", m3SINV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DBYP.HasValue)
				request.WithQueryParameter("DBYP", m3DBYP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());

			// Execute the request
			var result = await Execute<SelMaterialsResponse>(
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
		/// Name SelOpeByHead
		/// Description Select Operation By Order Header
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FSTS">From Status</param>
		/// <param name="m3TSTS">To Status</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DATE">Timestamp date</param>
		/// <param name="m3TIME">Timestamp time</param>
		/// <param name="m3SCHH">Scheduling horizon</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3PLET">Included planning entity proposals</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOpeByHeadResponse></returns>
		/// <exception cref="M3Exception<SelOpeByHeadResponse>"></exception>
		public async Task<M3Response<SelOpeByHeadResponse>> SelOpeByHead(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3FSTS = null, 
			string m3TSTS = null, 
			string m3WHGR = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3APIP = null, 
			int? m3SIMD = null, 
			int? m3PLET = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelOpeByHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSTS))
				request.WithQueryParameter("FSTS", m3FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTS))
				request.WithQueryParameter("TSTS", m3TSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3TIME.HasValue)
				request.WithQueryParameter("TIME", m3TIME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLET.HasValue)
				request.WithQueryParameter("PLET", m3PLET.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelOpeByHeadResponse>(
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
		/// Name SelOperations
		/// Description Selection of manufacturing order proposal operations
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RIDN">Proposal number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3REAO">Read all operations</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOperationsResponse></returns>
		/// <exception cref="M3Exception<SelOperationsResponse>"></exception>
		public async Task<M3Response<SelOperationsResponse>> SelOperations(
			string m3FACI, 
			int? m3CONO = null, 
			long? m3RIDN = null, 
			string m3WHLO = null, 
			string m3REAO = null, 
			string m3WHGR = null, 
			int? m3SIMD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelOperations",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDN.HasValue)
				request.WithQueryParameter("RIDN", m3RIDN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAO))
				request.WithQueryParameter("REAO", m3REAO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelOperationsResponse>(
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
		/// Name SelOrderHead
		/// Description Selection of manufacturing order proposals
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FSTS">From Status</param>
		/// <param name="m3TSTS">To Status</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DATE">Timestamp date</param>
		/// <param name="m3TIME">Timestamp time</param>
		/// <param name="m3SCHH">Scheduling horizon</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="m3SLEN">Select Endproducts (1=Yes)</param>
		/// <param name="m3PLET">Included planning entity proposals</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelOrderHeadResponse></returns>
		/// <exception cref="M3Exception<SelOrderHeadResponse>"></exception>
		public async Task<M3Response<SelOrderHeadResponse>> SelOrderHead(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3FSTS = null, 
			string m3TSTS = null, 
			string m3WHGR = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3APIP = null, 
			int? m3SLEN = null, 
			int? m3PLET = null, 
			int? m3SIMD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelOrderHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSTS))
				request.WithQueryParameter("FSTS", m3FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTS))
				request.WithQueryParameter("TSTS", m3TSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3TIME.HasValue)
				request.WithQueryParameter("TIME", m3TIME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());
			if (m3SLEN.HasValue)
				request.WithQueryParameter("SLEN", m3SLEN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLET.HasValue)
				request.WithQueryParameter("PLET", m3PLET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelOrderHeadResponse>(
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
		/// Description Selection of manufacturing order proposals
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACF">From facility (Required)</param>
		/// <param name="m3FACT">To facility (Required)</param>
		/// <param name="m3STSF">From status (Required)</param>
		/// <param name="m3STST">To status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DATE">Timestamp date</param>
		/// <param name="m3TIME">Timestamp time</param>
		/// <param name="m3SCHH">Scheduling horizon</param>
		/// <param name="m3FWHS">From warehouse</param>
		/// <param name="m3TWHS">To warehouse</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3SLEN">Select Endproducts (1=Yes)</param>
		/// <param name="m3PLET">Included planning entity proposals</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3FACF, 
			string m3FACT, 
			int m3STSF, 
			int m3STST, 
			int? m3CONO = null, 
			string m3REAR = null, 
			DateTime? m3DATE = null, 
			int? m3TIME = null, 
			int? m3SCHH = null, 
			string m3FWHS = null, 
			string m3TWHS = null, 
			string m3WHGR = null, 
			int? m3SLEN = null, 
			int? m3PLET = null, 
			int? m3SIMD = null, 
			string m3APIP = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACF))
				throw new ArgumentNullException(nameof(m3FACF));
			if (string.IsNullOrWhiteSpace(m3FACT))
				throw new ArgumentNullException(nameof(m3FACT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACF", m3FACF.Trim())
				.WithQueryParameter("FACT", m3FACT.Trim())
				.WithQueryParameter("STSF", m3STSF.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STST", m3STST.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3TIME.HasValue)
				request.WithQueryParameter("TIME", m3TIME.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3SCHH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHS))
				request.WithQueryParameter("FWHS", m3FWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHS))
				request.WithQueryParameter("TWHS", m3TWHS.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3SLEN.HasValue)
				request.WithQueryParameter("SLEN", m3SLEN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLET.HasValue)
				request.WithQueryParameter("PLET", m3PLET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3APIP))
				request.WithQueryParameter("APIP", m3APIP.Trim());

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
		/// Name SetStatus
		/// Description Set manufacturing order proposal status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Proposal number (Required)</param>
		/// <param name="m3PSTS">Proposal status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetStatus(
			int m3PLPN, 
			int m3PSTS, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SetStatus",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PSTS", m3PSTS.ToString(CultureInfo.CurrentCulture));

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
		/// Name Updat
		/// Description Update
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3PUIT">Acqusition code</param>
		/// <param name="m3SCHN">Schedule number</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3MSTI">Start time</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3MFTI">Finish time</param>
		/// <param name="m3ORQA">Orderd quantity</param>
		/// <param name="m3MAUN">Manufacturing U/M</param>
		/// <param name="m3PSTS">Status - planned order</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3AOID">Alternate routing</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3RORC">Ref order category</param>
		/// <param name="m3RORN">Ref order number</param>
		/// <param name="m3RORL">Ref order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3WHST">Status manufacturing order</param>
		/// <param name="m3WCLN">Production line</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3DSP1">Warning indicator 1</param>
		/// <param name="m3DSP3">Warning indicator 3</param>
		/// <param name="m3DSP4">Warning indicator 4</param>
		/// <param name="m3DSP6">Warning indicator 6</param>
		/// <param name="m3DSP7">Warning indicator 7</param>
		/// <param name="m3DSP8">Warning indicator 8</param>
		/// <param name="m3MFPC">Process</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Updat(
			int m3PLPN, 
			int? m3CONO = null, 
			string m3RESP = null, 
			int? m3PUIT = null, 
			decimal? m3SCHN = null, 
			DateTime? m3STDT = null, 
			int? m3MSTI = null, 
			DateTime? m3FIDT = null, 
			int? m3MFTI = null, 
			decimal? m3ORQA = null, 
			string m3MAUN = null, 
			string m3PSTS = null, 
			string m3PRIP = null, 
			string m3AOID = null, 
			string m3ORTY = null, 
			string m3STRT = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3WHST = null, 
			string m3WCLN = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3DSP1 = null, 
			string m3DSP3 = null, 
			string m3DSP4 = null, 
			string m3DSP6 = null, 
			string m3DSP7 = null, 
			string m3DSP8 = null, 
			string m3MFPC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Updat",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3PUIT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHN.HasValue)
				request.WithQueryParameter("SCHN", m3SCHN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3MSTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3MFTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3ORQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MAUN))
				request.WithQueryParameter("MAUN", m3MAUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSTS))
				request.WithQueryParameter("PSTS", m3PSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOID))
				request.WithQueryParameter("AOID", m3AOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHST))
				request.WithQueryParameter("WHST", m3WHST.Trim());
			if (!string.IsNullOrWhiteSpace(m3WCLN))
				request.WithQueryParameter("WCLN", m3WCLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP1))
				request.WithQueryParameter("DSP1", m3DSP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP3))
				request.WithQueryParameter("DSP3", m3DSP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP4))
				request.WithQueryParameter("DSP4", m3DSP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP6))
				request.WithQueryParameter("DSP6", m3DSP6.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP7))
				request.WithQueryParameter("DSP7", m3DSP7.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSP8))
				request.WithQueryParameter("DSP8", m3DSP8.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFPC))
				request.WithQueryParameter("MFPC", m3MFPC.Trim());

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
