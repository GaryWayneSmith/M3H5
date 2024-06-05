/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CUSEXTMI;
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
	/// Name: CUSEXTMI
	/// Component Name: Customer generic ext. table
	/// Description: Customer generic extension table
	/// Version Release: 5ea5
	///</summary>
	public partial class CUSEXTMIResource : M3BaseResourceEndpoint
	{
		public CUSEXTMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CUSEXTMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAlphaKPI
		/// Description Add record
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_KPID">KPI ID (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="m3_AL31">Alpha field 30 positions</param>
		/// <param name="m3_AL32">Alpha field 30 positions</param>
		/// <param name="m3_AL33">Alpha field 30 positions</param>
		/// <param name="m3_AL34">Alpha field 30 positions</param>
		/// <param name="m3_AL35">Alpha field 30 positions</param>
		/// <param name="m3_AL36">Alpha field 30 positions</param>
		/// <param name="m3_AL37">Alpha field 30 positions</param>
		/// <param name="m3_AL38">Alpha field 30 positions</param>
		/// <param name="m3_AL39">Alpha field 30 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAlphaKPI(
			string m3_KPID, 
			string m3_PK01, 
			string m3_AL30, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
			string m3_AL31 = null, 
			string m3_AL32 = null, 
			string m3_AL33 = null, 
			string m3_AL34 = null, 
			string m3_AL35 = null, 
			string m3_AL36 = null, 
			string m3_AL37 = null, 
			string m3_AL38 = null, 
			string m3_AL39 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAlphaKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KPID))
				throw new ArgumentNullException("m3_KPID");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");
			if (string.IsNullOrWhiteSpace(m3_AL30))
				throw new ArgumentNullException("m3_AL30");

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3_KPID.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim())
				.WithQueryParameter("AL30", m3_AL30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL31))
				request.WithQueryParameter("AL31", m3_AL31.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL32))
				request.WithQueryParameter("AL32", m3_AL32.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL33))
				request.WithQueryParameter("AL33", m3_AL33.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL34))
				request.WithQueryParameter("AL34", m3_AL34.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL35))
				request.WithQueryParameter("AL35", m3_AL35.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL36))
				request.WithQueryParameter("AL36", m3_AL36.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL37))
				request.WithQueryParameter("AL37", m3_AL37.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL38))
				request.WithQueryParameter("AL38", m3_AL38.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL39))
				request.WithQueryParameter("AL39", m3_AL39.Trim());

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
		/// Name AddFieldAttr
		/// Description Add field atrributes
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_CTGY">Category (Required)</param>
		/// <param name="m3_FLDB">Field length (Required)</param>
		/// <param name="m3_FLDP">Number of decimal places (Required)</param>
		/// <param name="m3_FLUC">Upper case (Required)</param>
		/// <param name="m3_TX15">Name (Required)</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_FLTE">Field type</param>
		/// <param name="m3_TX05">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_FHID">Field help ID</param>
		/// <param name="m3_FLUL">Field Upper Limit</param>
		/// <param name="m3_FLLL">Field Lower Limit</param>
		/// <param name="m3_FLLM">Field Limit Multiple</param>
		/// <param name="m3_ECDE">Edit code</param>
		/// <param name="m3_NBMO">Check digit method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldAttr(
			string m3_FILE, 
			string m3_FLDI, 
			string m3_CTGY, 
			int m3_FLDB, 
			int m3_FLDP, 
			int m3_FLUC, 
			string m3_TX15, 
			string m3_CUER = null, 
			string m3_FLTE = null, 
			string m3_TX05 = null, 
			string m3_TX40 = null, 
			string m3_MSID = null, 
			string m3_FHID = null, 
			decimal? m3_FLUL = null, 
			decimal? m3_FLLL = null, 
			decimal? m3_FLLM = null, 
			string m3_ECDE = null, 
			int? m3_NBMO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFieldAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_CTGY))
				throw new ArgumentNullException("m3_CTGY");
			if (string.IsNullOrWhiteSpace(m3_TX15))
				throw new ArgumentNullException("m3_TX15");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("CTGY", m3_CTGY.Trim())
				.WithQueryParameter("FLDB", m3_FLDB.ToString())
				.WithQueryParameter("FLDP", m3_FLDP.ToString())
				.WithQueryParameter("FLUC", m3_FLUC.ToString())
				.WithQueryParameter("TX15", m3_TX15.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLTE))
				request.WithQueryParameter("FLTE", m3_FLTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX05))
				request.WithQueryParameter("TX05", m3_TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FHID))
				request.WithQueryParameter("FHID", m3_FHID.Trim());
			if (m3_FLUL.HasValue)
				request.WithQueryParameter("FLUL", m3_FLUL.Value.ToString());
			if (m3_FLLL.HasValue)
				request.WithQueryParameter("FLLL", m3_FLLL.Value.ToString());
			if (m3_FLLM.HasValue)
				request.WithQueryParameter("FLLM", m3_FLLM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECDE))
				request.WithQueryParameter("ECDE", m3_ECDE.Trim());
			if (m3_NBMO.HasValue)
				request.WithQueryParameter("NBMO", m3_NBMO.Value.ToString());

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
		/// Name AddFieldVM
		/// Description Add Field Value Map
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3_TX15">Name (Required)</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_TX05">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldVM(
			string m3_FILE, 
			string m3_FLDI, 
			string m3_AL30, 
			string m3_TX15, 
			string m3_CUER = null, 
			int? m3_SEQN = null, 
			string m3_TX05 = null, 
			string m3_TX40 = null, 
			string m3_MSID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFieldVM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_AL30))
				throw new ArgumentNullException("m3_AL30");
			if (string.IsNullOrWhiteSpace(m3_TX15))
				throw new ArgumentNullException("m3_TX15");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("AL30", m3_AL30.Trim())
				.WithQueryParameter("TX15", m3_TX15.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX05))
				request.WithQueryParameter("TX05", m3_TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());

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
		/// Name AddFieldValue
		/// Description Add record
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="m3_A030">Alpha field 30 positions</param>
		/// <param name="m3_A130">Alpha field 30 positions</param>
		/// <param name="m3_A230">Alpha field 30 positions</param>
		/// <param name="m3_A330">Alpha field 30 positions</param>
		/// <param name="m3_A430">Alpha field 30 positions</param>
		/// <param name="m3_A530">Alpha field 30 positions</param>
		/// <param name="m3_A630">Alpha field 30 positions</param>
		/// <param name="m3_A730">Alpha field 30 positions</param>
		/// <param name="m3_A830">Alpha field 30 positions</param>
		/// <param name="m3_A930">Alpha field 30 positions</param>
		/// <param name="m3_N096">Numeric field 19,6 positions</param>
		/// <param name="m3_N196">Numeric field 19,6 positions</param>
		/// <param name="m3_N296">Numeric field 19,6 positions</param>
		/// <param name="m3_N396">Numeric field 19,6 positions</param>
		/// <param name="m3_N496">Numeric field 19,6 positions</param>
		/// <param name="m3_N596">Numeric field 19,6 positions</param>
		/// <param name="m3_N696">Numeric field 19,6 positions</param>
		/// <param name="m3_N796">Numeric field 19,6 positions</param>
		/// <param name="m3_N896">Numeric field 19,6 positions</param>
		/// <param name="m3_N996">Numeric field 19,6 positions</param>
		/// <param name="m3_MIGR">Migrated</param>
		/// <param name="m3_A121">Alphanumeric field 120 positions</param>
		/// <param name="m3_VEXI">Do not validate if M3 record exist = 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldValue(
			string m3_FILE, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
			string m3_A030 = null, 
			string m3_A130 = null, 
			string m3_A230 = null, 
			string m3_A330 = null, 
			string m3_A430 = null, 
			string m3_A530 = null, 
			string m3_A630 = null, 
			string m3_A730 = null, 
			string m3_A830 = null, 
			string m3_A930 = null, 
			decimal? m3_N096 = null, 
			decimal? m3_N196 = null, 
			decimal? m3_N296 = null, 
			decimal? m3_N396 = null, 
			decimal? m3_N496 = null, 
			decimal? m3_N596 = null, 
			decimal? m3_N696 = null, 
			decimal? m3_N796 = null, 
			decimal? m3_N896 = null, 
			decimal? m3_N996 = null, 
			int? m3_MIGR = null, 
			string m3_A121 = null, 
			int? m3_VEXI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A030))
				request.WithQueryParameter("A030", m3_A030.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A130))
				request.WithQueryParameter("A130", m3_A130.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A230))
				request.WithQueryParameter("A230", m3_A230.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A330))
				request.WithQueryParameter("A330", m3_A330.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A430))
				request.WithQueryParameter("A430", m3_A430.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A530))
				request.WithQueryParameter("A530", m3_A530.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A630))
				request.WithQueryParameter("A630", m3_A630.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A730))
				request.WithQueryParameter("A730", m3_A730.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A830))
				request.WithQueryParameter("A830", m3_A830.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A930))
				request.WithQueryParameter("A930", m3_A930.Trim());
			if (m3_N096.HasValue)
				request.WithQueryParameter("N096", m3_N096.Value.ToString());
			if (m3_N196.HasValue)
				request.WithQueryParameter("N196", m3_N196.Value.ToString());
			if (m3_N296.HasValue)
				request.WithQueryParameter("N296", m3_N296.Value.ToString());
			if (m3_N396.HasValue)
				request.WithQueryParameter("N396", m3_N396.Value.ToString());
			if (m3_N496.HasValue)
				request.WithQueryParameter("N496", m3_N496.Value.ToString());
			if (m3_N596.HasValue)
				request.WithQueryParameter("N596", m3_N596.Value.ToString());
			if (m3_N696.HasValue)
				request.WithQueryParameter("N696", m3_N696.Value.ToString());
			if (m3_N796.HasValue)
				request.WithQueryParameter("N796", m3_N796.Value.ToString());
			if (m3_N896.HasValue)
				request.WithQueryParameter("N896", m3_N896.Value.ToString());
			if (m3_N996.HasValue)
				request.WithQueryParameter("N996", m3_N996.Value.ToString());
			if (m3_MIGR.HasValue)
				request.WithQueryParameter("MIGR", m3_MIGR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_A121))
				request.WithQueryParameter("A121", m3_A121.Trim());
			if (m3_VEXI.HasValue)
				request.WithQueryParameter("VEXI", m3_VEXI.Value.ToString());

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
		/// Name AddNumericKPI
		/// Description Add numerical fields
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_KPID">KPI ID (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_N096">Numeric field 19,6 positions (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="m3_N196">Numeric field 19,6 positions</param>
		/// <param name="m3_N296">Numeric field 19,6 positions</param>
		/// <param name="m3_N396">Numeric field 19,6 positions</param>
		/// <param name="m3_N496">Numeric field 19,6 positions</param>
		/// <param name="m3_N596">Numeric field 19,6 positions</param>
		/// <param name="m3_N696">Numeric field 19,6 positions</param>
		/// <param name="m3_N796">Numeric field 19,6 positions</param>
		/// <param name="m3_N896">Numeric field 19,6 positions</param>
		/// <param name="m3_N996">Numeric field 19,6 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddNumericKPI(
			string m3_KPID, 
			string m3_PK01, 
			decimal m3_N096, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
			decimal? m3_N196 = null, 
			decimal? m3_N296 = null, 
			decimal? m3_N396 = null, 
			decimal? m3_N496 = null, 
			decimal? m3_N596 = null, 
			decimal? m3_N696 = null, 
			decimal? m3_N796 = null, 
			decimal? m3_N896 = null, 
			decimal? m3_N996 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddNumericKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KPID))
				throw new ArgumentNullException("m3_KPID");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3_KPID.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim())
				.WithQueryParameter("N096", m3_N096.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());
			if (m3_N196.HasValue)
				request.WithQueryParameter("N196", m3_N196.Value.ToString());
			if (m3_N296.HasValue)
				request.WithQueryParameter("N296", m3_N296.Value.ToString());
			if (m3_N396.HasValue)
				request.WithQueryParameter("N396", m3_N396.Value.ToString());
			if (m3_N496.HasValue)
				request.WithQueryParameter("N496", m3_N496.Value.ToString());
			if (m3_N596.HasValue)
				request.WithQueryParameter("N596", m3_N596.Value.ToString());
			if (m3_N696.HasValue)
				request.WithQueryParameter("N696", m3_N696.Value.ToString());
			if (m3_N796.HasValue)
				request.WithQueryParameter("N796", m3_N796.Value.ToString());
			if (m3_N896.HasValue)
				request.WithQueryParameter("N896", m3_N896.Value.ToString());
			if (m3_N996.HasValue)
				request.WithQueryParameter("N996", m3_N996.Value.ToString());

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
		/// Name ChgAlphaKPI
		/// Description Change existing record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_KPID">KPI ID (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="m3_AL30">Alpha field 30 positions</param>
		/// <param name="m3_AL31">Alpha field 30 positions</param>
		/// <param name="m3_AL32">Alpha field 30 positions</param>
		/// <param name="m3_AL33">Alpha field 30 positions</param>
		/// <param name="m3_AL34">Alpha field 30 positions</param>
		/// <param name="m3_AL35">Alpha field 30 positions</param>
		/// <param name="m3_AL36">Alpha field 30 positions</param>
		/// <param name="m3_AL37">Alpha field 30 positions</param>
		/// <param name="m3_AL38">Alpha field 30 positions</param>
		/// <param name="m3_AL39">Alpha field 30 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAlphaKPI(
			string m3_KPID, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
			string m3_AL30 = null, 
			string m3_AL31 = null, 
			string m3_AL32 = null, 
			string m3_AL33 = null, 
			string m3_AL34 = null, 
			string m3_AL35 = null, 
			string m3_AL36 = null, 
			string m3_AL37 = null, 
			string m3_AL38 = null, 
			string m3_AL39 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgAlphaKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KPID))
				throw new ArgumentNullException("m3_KPID");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3_KPID.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL30))
				request.WithQueryParameter("AL30", m3_AL30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL31))
				request.WithQueryParameter("AL31", m3_AL31.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL32))
				request.WithQueryParameter("AL32", m3_AL32.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL33))
				request.WithQueryParameter("AL33", m3_AL33.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL34))
				request.WithQueryParameter("AL34", m3_AL34.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL35))
				request.WithQueryParameter("AL35", m3_AL35.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL36))
				request.WithQueryParameter("AL36", m3_AL36.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL37))
				request.WithQueryParameter("AL37", m3_AL37.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL38))
				request.WithQueryParameter("AL38", m3_AL38.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL39))
				request.WithQueryParameter("AL39", m3_AL39.Trim());

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
		/// Name ChgFieldAttr
		/// Description Change Field Attributes
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_FLTE">Field type</param>
		/// <param name="m3_CTGY">Category</param>
		/// <param name="m3_FLDB">Field length</param>
		/// <param name="m3_FLDP">Number of decimal places</param>
		/// <param name="m3_FLUC">Upper Case</param>
		/// <param name="m3_TX05">Name</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="m3_FHID">Field help ID</param>
		/// <param name="m3_FLUL">Field Upper Limit</param>
		/// <param name="m3_FLLL">Field Lower Limit</param>
		/// <param name="m3_FLLM">Field Limit Multiple</param>
		/// <param name="m3_ECDE">Edit code</param>
		/// <param name="m3_NBMO">Check digit method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgFieldAttr(
			string m3_FILE, 
			string m3_FLDI, 
			string m3_CUER = null, 
			string m3_FLTE = null, 
			string m3_CTGY = null, 
			int? m3_FLDB = null, 
			int? m3_FLDP = null, 
			int? m3_FLUC = null, 
			string m3_TX05 = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
			string m3_MSID = null, 
			string m3_FHID = null, 
			decimal? m3_FLUL = null, 
			decimal? m3_FLLL = null, 
			decimal? m3_FLLM = null, 
			string m3_ECDE = null, 
			int? m3_NBMO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgFieldAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLTE))
				request.WithQueryParameter("FLTE", m3_FLTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTGY))
				request.WithQueryParameter("CTGY", m3_CTGY.Trim());
			if (m3_FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3_FLDB.Value.ToString());
			if (m3_FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3_FLDP.Value.ToString());
			if (m3_FLUC.HasValue)
				request.WithQueryParameter("FLUC", m3_FLUC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX05))
				request.WithQueryParameter("TX05", m3_TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FHID))
				request.WithQueryParameter("FHID", m3_FHID.Trim());
			if (m3_FLUL.HasValue)
				request.WithQueryParameter("FLUL", m3_FLUL.Value.ToString());
			if (m3_FLLL.HasValue)
				request.WithQueryParameter("FLLL", m3_FLLL.Value.ToString());
			if (m3_FLLM.HasValue)
				request.WithQueryParameter("FLLM", m3_FLLM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ECDE))
				request.WithQueryParameter("ECDE", m3_ECDE.Trim());
			if (m3_NBMO.HasValue)
				request.WithQueryParameter("NBMO", m3_NBMO.Value.ToString());

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
		/// Name ChgFieldVM
		/// Description Change Field Value Map
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_CUER">Customer extension reference (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_TX05">Name</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_MSID">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgFieldVM(
			string m3_FILE, 
			string m3_CUER, 
			string m3_FLDI, 
			string m3_AL30, 
			int m3_SEQN, 
			string m3_TX05 = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
			string m3_MSID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgFieldVM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_CUER))
				throw new ArgumentNullException("m3_CUER");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_AL30))
				throw new ArgumentNullException("m3_AL30");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("CUER", m3_CUER.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("AL30", m3_AL30.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX05))
				request.WithQueryParameter("TX05", m3_TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSID))
				request.WithQueryParameter("MSID", m3_MSID.Trim());

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
		/// Name ChgFieldValue
		/// Description Change record
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="m3_A030">Alpha field 30 positions</param>
		/// <param name="m3_A130">Alpha field 30 positions</param>
		/// <param name="m3_A230">Alpha field 30 positions</param>
		/// <param name="m3_A330">Alpha field 30 positions</param>
		/// <param name="m3_A430">Alpha field 30 positions</param>
		/// <param name="m3_A530">Alpha field 30 positions</param>
		/// <param name="m3_A630">Alpha field 30 positions</param>
		/// <param name="m3_A730">Alpha field 30 positions</param>
		/// <param name="m3_A830">Alpha field 30 positions</param>
		/// <param name="m3_A930">Alpha field 30 positions</param>
		/// <param name="m3_N096">Numeric field 19,6 positions</param>
		/// <param name="m3_N196">Numeric field 19,6 positions</param>
		/// <param name="m3_N296">Numeric field 19,6 positions</param>
		/// <param name="m3_N396">Numeric field 19,6 positions</param>
		/// <param name="m3_N496">Numeric field 19,6 positions</param>
		/// <param name="m3_N596">Numeric field 19,6 positions</param>
		/// <param name="m3_N696">Numeric field 19,6 positions</param>
		/// <param name="m3_N796">Numeric field 19,6 positions</param>
		/// <param name="m3_N896">Numeric field 19,6 positions</param>
		/// <param name="m3_N996">Numeric field 19,6 positions</param>
		/// <param name="m3_MIGR">Migrated</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_A121">Alphanumeric field 120 positions</param>
		/// <param name="m3_VEXI">Do not validate if M3 record exist = 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgFieldValue(
			string m3_FILE, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
			string m3_A030 = null, 
			string m3_A130 = null, 
			string m3_A230 = null, 
			string m3_A330 = null, 
			string m3_A430 = null, 
			string m3_A530 = null, 
			string m3_A630 = null, 
			string m3_A730 = null, 
			string m3_A830 = null, 
			string m3_A930 = null, 
			decimal? m3_N096 = null, 
			decimal? m3_N196 = null, 
			decimal? m3_N296 = null, 
			decimal? m3_N396 = null, 
			decimal? m3_N496 = null, 
			decimal? m3_N596 = null, 
			decimal? m3_N696 = null, 
			decimal? m3_N796 = null, 
			decimal? m3_N896 = null, 
			decimal? m3_N996 = null, 
			int? m3_MIGR = null, 
			decimal? m3_TXID = null, 
			string m3_A121 = null, 
			int? m3_VEXI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A030))
				request.WithQueryParameter("A030", m3_A030.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A130))
				request.WithQueryParameter("A130", m3_A130.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A230))
				request.WithQueryParameter("A230", m3_A230.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A330))
				request.WithQueryParameter("A330", m3_A330.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A430))
				request.WithQueryParameter("A430", m3_A430.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A530))
				request.WithQueryParameter("A530", m3_A530.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A630))
				request.WithQueryParameter("A630", m3_A630.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A730))
				request.WithQueryParameter("A730", m3_A730.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A830))
				request.WithQueryParameter("A830", m3_A830.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A930))
				request.WithQueryParameter("A930", m3_A930.Trim());
			if (m3_N096.HasValue)
				request.WithQueryParameter("N096", m3_N096.Value.ToString());
			if (m3_N196.HasValue)
				request.WithQueryParameter("N196", m3_N196.Value.ToString());
			if (m3_N296.HasValue)
				request.WithQueryParameter("N296", m3_N296.Value.ToString());
			if (m3_N396.HasValue)
				request.WithQueryParameter("N396", m3_N396.Value.ToString());
			if (m3_N496.HasValue)
				request.WithQueryParameter("N496", m3_N496.Value.ToString());
			if (m3_N596.HasValue)
				request.WithQueryParameter("N596", m3_N596.Value.ToString());
			if (m3_N696.HasValue)
				request.WithQueryParameter("N696", m3_N696.Value.ToString());
			if (m3_N796.HasValue)
				request.WithQueryParameter("N796", m3_N796.Value.ToString());
			if (m3_N896.HasValue)
				request.WithQueryParameter("N896", m3_N896.Value.ToString());
			if (m3_N996.HasValue)
				request.WithQueryParameter("N996", m3_N996.Value.ToString());
			if (m3_MIGR.HasValue)
				request.WithQueryParameter("MIGR", m3_MIGR.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_A121))
				request.WithQueryParameter("A121", m3_A121.Trim());
			if (m3_VEXI.HasValue)
				request.WithQueryParameter("VEXI", m3_VEXI.Value.ToString());

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
		/// Name ChgFieldValueEx
		/// Description Add and change the extended fields of an existing record
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="m3_CHB1">Yes/no</param>
		/// <param name="m3_CHB2">Yes/no</param>
		/// <param name="m3_CHB3">Yes/no</param>
		/// <param name="m3_CHB4">Yes/no</param>
		/// <param name="m3_CHB5">Yes/no</param>
		/// <param name="m3_CHB6">Yes/no</param>
		/// <param name="m3_CHB7">Yes/no</param>
		/// <param name="m3_CHB8">Yes/no</param>
		/// <param name="m3_CHB9">Yes/no</param>
		/// <param name="m3_DAT1">Ref field for date</param>
		/// <param name="m3_DAT2">Ref field for date</param>
		/// <param name="m3_DAT3">Ref field for date</param>
		/// <param name="m3_DAT4">Ref field for date</param>
		/// <param name="m3_DAT5">Ref field for date</param>
		/// <param name="m3_DAT6">Ref field for date</param>
		/// <param name="m3_DAT7">Ref field for date</param>
		/// <param name="m3_DAT8">Ref field for date</param>
		/// <param name="m3_DAT9">Ref field for date</param>
		/// <param name="m3_A122">Alphanumeric field 120 positions</param>
		/// <param name="m3_A256">Alphanumeric field 256 positions</param>
		/// <param name="m3_VEXI">Do not validate if M3 record exist = 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgFieldValueEx(
			string m3_FILE, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
			int? m3_CHB1 = null, 
			int? m3_CHB2 = null, 
			int? m3_CHB3 = null, 
			int? m3_CHB4 = null, 
			int? m3_CHB5 = null, 
			int? m3_CHB6 = null, 
			int? m3_CHB7 = null, 
			int? m3_CHB8 = null, 
			int? m3_CHB9 = null, 
			DateTime? m3_DAT1 = null, 
			DateTime? m3_DAT2 = null, 
			DateTime? m3_DAT3 = null, 
			DateTime? m3_DAT4 = null, 
			DateTime? m3_DAT5 = null, 
			DateTime? m3_DAT6 = null, 
			DateTime? m3_DAT7 = null, 
			DateTime? m3_DAT8 = null, 
			DateTime? m3_DAT9 = null, 
			string m3_A122 = null, 
			string m3_A256 = null, 
			int? m3_VEXI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgFieldValueEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());
			if (m3_CHB1.HasValue)
				request.WithQueryParameter("CHB1", m3_CHB1.Value.ToString());
			if (m3_CHB2.HasValue)
				request.WithQueryParameter("CHB2", m3_CHB2.Value.ToString());
			if (m3_CHB3.HasValue)
				request.WithQueryParameter("CHB3", m3_CHB3.Value.ToString());
			if (m3_CHB4.HasValue)
				request.WithQueryParameter("CHB4", m3_CHB4.Value.ToString());
			if (m3_CHB5.HasValue)
				request.WithQueryParameter("CHB5", m3_CHB5.Value.ToString());
			if (m3_CHB6.HasValue)
				request.WithQueryParameter("CHB6", m3_CHB6.Value.ToString());
			if (m3_CHB7.HasValue)
				request.WithQueryParameter("CHB7", m3_CHB7.Value.ToString());
			if (m3_CHB8.HasValue)
				request.WithQueryParameter("CHB8", m3_CHB8.Value.ToString());
			if (m3_CHB9.HasValue)
				request.WithQueryParameter("CHB9", m3_CHB9.Value.ToString());
			if (m3_DAT1.HasValue)
				request.WithQueryParameter("DAT1", m3_DAT1.Value.ToM3String());
			if (m3_DAT2.HasValue)
				request.WithQueryParameter("DAT2", m3_DAT2.Value.ToM3String());
			if (m3_DAT3.HasValue)
				request.WithQueryParameter("DAT3", m3_DAT3.Value.ToM3String());
			if (m3_DAT4.HasValue)
				request.WithQueryParameter("DAT4", m3_DAT4.Value.ToM3String());
			if (m3_DAT5.HasValue)
				request.WithQueryParameter("DAT5", m3_DAT5.Value.ToM3String());
			if (m3_DAT6.HasValue)
				request.WithQueryParameter("DAT6", m3_DAT6.Value.ToM3String());
			if (m3_DAT7.HasValue)
				request.WithQueryParameter("DAT7", m3_DAT7.Value.ToM3String());
			if (m3_DAT8.HasValue)
				request.WithQueryParameter("DAT8", m3_DAT8.Value.ToM3String());
			if (m3_DAT9.HasValue)
				request.WithQueryParameter("DAT9", m3_DAT9.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_A122))
				request.WithQueryParameter("A122", m3_A122.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A256))
				request.WithQueryParameter("A256", m3_A256.Trim());
			if (m3_VEXI.HasValue)
				request.WithQueryParameter("VEXI", m3_VEXI.Value.ToString());

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
		/// Name ChgNumericKPI
		/// Description Change numerical fields
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_KPID">KPI ID (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="m3_N096">Numeric field 19,6 positions</param>
		/// <param name="m3_N196">Numeric field 19,6 positions</param>
		/// <param name="m3_N296">Numeric field 19,6 positions</param>
		/// <param name="m3_N396">Numeric field 19,6 positions</param>
		/// <param name="m3_N496">Numeric field 19,6 positions</param>
		/// <param name="m3_N596">Numeric field 19,6 positions</param>
		/// <param name="m3_N696">Numeric field 19,6 positions</param>
		/// <param name="m3_N796">Numeric field 19,6 positions</param>
		/// <param name="m3_N896">Numeric field 19,6 positions</param>
		/// <param name="m3_N996">Numeric field 19,6 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgNumericKPI(
			string m3_KPID, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
			decimal? m3_N096 = null, 
			decimal? m3_N196 = null, 
			decimal? m3_N296 = null, 
			decimal? m3_N396 = null, 
			decimal? m3_N496 = null, 
			decimal? m3_N596 = null, 
			decimal? m3_N696 = null, 
			decimal? m3_N796 = null, 
			decimal? m3_N896 = null, 
			decimal? m3_N996 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgNumericKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KPID))
				throw new ArgumentNullException("m3_KPID");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3_KPID.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());
			if (m3_N096.HasValue)
				request.WithQueryParameter("N096", m3_N096.Value.ToString());
			if (m3_N196.HasValue)
				request.WithQueryParameter("N196", m3_N196.Value.ToString());
			if (m3_N296.HasValue)
				request.WithQueryParameter("N296", m3_N296.Value.ToString());
			if (m3_N396.HasValue)
				request.WithQueryParameter("N396", m3_N396.Value.ToString());
			if (m3_N496.HasValue)
				request.WithQueryParameter("N496", m3_N496.Value.ToString());
			if (m3_N596.HasValue)
				request.WithQueryParameter("N596", m3_N596.Value.ToString());
			if (m3_N696.HasValue)
				request.WithQueryParameter("N696", m3_N696.Value.ToString());
			if (m3_N796.HasValue)
				request.WithQueryParameter("N796", m3_N796.Value.ToString());
			if (m3_N896.HasValue)
				request.WithQueryParameter("N896", m3_N896.Value.ToString());
			if (m3_N996.HasValue)
				request.WithQueryParameter("N996", m3_N996.Value.ToString());

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
		/// Name CpyFieldValue
		/// Description Copy record
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_PK01">Fr Primary key 1 (Required)</param>
		/// <param name="m3_TFIL">To table (Required)</param>
		/// <param name="m3_PKT1">To Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Fr Primary key 2</param>
		/// <param name="m3_PK03">Fr Primary key 3</param>
		/// <param name="m3_PK04">Fr Primary key 4</param>
		/// <param name="m3_PK05">Fr Primary key 5</param>
		/// <param name="m3_PK06">Fr Primary key 6</param>
		/// <param name="m3_PK07">Fr Primary key 7</param>
		/// <param name="m3_PK08">Fr Primary key 8</param>
		/// <param name="m3_PKT2">To Primary key 2</param>
		/// <param name="m3_PKT3">To Primary key 3</param>
		/// <param name="m3_PKT4">To Primary key 4</param>
		/// <param name="m3_PKT5">To Primary key 5</param>
		/// <param name="m3_PKT6">To Primary key 6</param>
		/// <param name="m3_PKT7">To Primary key 7</param>
		/// <param name="m3_PKT8">To Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyFieldValue(
			string m3_FILE, 
			string m3_PK01, 
			string m3_TFIL, 
			string m3_PKT1, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
			string m3_PKT2 = null, 
			string m3_PKT3 = null, 
			string m3_PKT4 = null, 
			string m3_PKT5 = null, 
			string m3_PKT6 = null, 
			string m3_PKT7 = null, 
			string m3_PKT8 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");
			if (string.IsNullOrWhiteSpace(m3_TFIL))
				throw new ArgumentNullException("m3_TFIL");
			if (string.IsNullOrWhiteSpace(m3_PKT1))
				throw new ArgumentNullException("m3_PKT1");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim())
				.WithQueryParameter("TFIL", m3_TFIL.Trim())
				.WithQueryParameter("PKT1", m3_PKT1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PKT2))
				request.WithQueryParameter("PKT2", m3_PKT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PKT3))
				request.WithQueryParameter("PKT3", m3_PKT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PKT4))
				request.WithQueryParameter("PKT4", m3_PKT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PKT5))
				request.WithQueryParameter("PKT5", m3_PKT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PKT6))
				request.WithQueryParameter("PKT6", m3_PKT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PKT7))
				request.WithQueryParameter("PKT7", m3_PKT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PKT8))
				request.WithQueryParameter("PKT8", m3_PKT8.Trim());

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
		/// Name DelAlphaKPI
		/// Description Delete record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_KPID">KPI ID (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAlphaKPI(
			string m3_KPID, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAlphaKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KPID))
				throw new ArgumentNullException("m3_KPID");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3_KPID.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());

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
		/// Name DelFieldValue
		/// Description Delete record
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelFieldValue(
			string m3_FILE, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());

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
		/// Name DelNumericKPI
		/// Description Delete record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_KPID">KPI ID (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelNumericKPI(
			string m3_KPID, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelNumericKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KPID))
				throw new ArgumentNullException("m3_KPID");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3_KPID.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());

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
		/// Name DltFieldAttr
		/// Description Delete Field Attributes
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_CUER">Customer extension reference (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltFieldAttr(
			string m3_FILE, 
			string m3_CUER, 
			string m3_FLDI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltFieldAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_CUER))
				throw new ArgumentNullException("m3_CUER");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("CUER", m3_CUER.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

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
		/// Name DltFieldVM
		/// Description Delete Field Value Map
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_CUER">Customer extension reference (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltFieldVM(
			string m3_FILE, 
			string m3_CUER, 
			string m3_FLDI, 
			string m3_AL30, 
			int m3_SEQN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltFieldVM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_CUER))
				throw new ArgumentNullException("m3_CUER");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_AL30))
				throw new ArgumentNullException("m3_AL30");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("CUER", m3_CUER.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("AL30", m3_AL30.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

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
		/// Name GetAlphaKPI
		/// Description Get single record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_KPID">KPI ID (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAlphaKPIResponse></returns>
		/// <exception cref="M3Exception<GetAlphaKPIResponse>"></exception>
		public async Task<M3Response<GetAlphaKPIResponse>> GetAlphaKPI(
			string m3_KPID, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAlphaKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KPID))
				throw new ArgumentNullException("m3_KPID");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3_KPID.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());

			// Execute the request
			var result = await Execute<GetAlphaKPIResponse>(
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
		/// Name GetFieldAttr
		/// Description Get Field Attributes
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldAttrResponse></returns>
		/// <exception cref="M3Exception<GetFieldAttrResponse>"></exception>
		public async Task<M3Response<GetFieldAttrResponse>> GetFieldAttr(
			string m3_FILE, 
			string m3_FLDI, 
			string m3_CUER = null, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFieldAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetFieldAttrResponse>(
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
		/// Name GetFieldVM
		/// Description Get Field Value Map
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_CUER">Customer extension reference (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldVMResponse></returns>
		/// <exception cref="M3Exception<GetFieldVMResponse>"></exception>
		public async Task<M3Response<GetFieldVMResponse>> GetFieldVM(
			string m3_FILE, 
			string m3_CUER, 
			string m3_FLDI, 
			string m3_AL30, 
			int m3_SEQN, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFieldVM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_CUER))
				throw new ArgumentNullException("m3_CUER");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_AL30))
				throw new ArgumentNullException("m3_AL30");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("CUER", m3_CUER.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("AL30", m3_AL30.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<GetFieldVMResponse>(
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
		/// Name GetFieldValue
		/// Description Get record
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldValueResponse></returns>
		/// <exception cref="M3Exception<GetFieldValueResponse>"></exception>
		public async Task<M3Response<GetFieldValueResponse>> GetFieldValue(
			string m3_FILE, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());

			// Execute the request
			var result = await Execute<GetFieldValueResponse>(
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
		/// Name GetFieldValueEx
		/// Description Get extended fields
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldValueExResponse></returns>
		/// <exception cref="M3Exception<GetFieldValueExResponse>"></exception>
		public async Task<M3Response<GetFieldValueExResponse>> GetFieldValueEx(
			string m3_FILE, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFieldValueEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());

			// Execute the request
			var result = await Execute<GetFieldValueExResponse>(
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
		/// Name GetNumericKPI
		/// Description Get data
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_KPID">KPI ID (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetNumericKPIResponse></returns>
		/// <exception cref="M3Exception<GetNumericKPIResponse>"></exception>
		public async Task<M3Response<GetNumericKPIResponse>> GetNumericKPI(
			string m3_KPID, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetNumericKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KPID))
				throw new ArgumentNullException("m3_KPID");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3_KPID.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());

			// Execute the request
			var result = await Execute<GetNumericKPIResponse>(
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
		/// Name LstAlphaKPI
		/// Description List records
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_KPID">KPI ID (Required)</param>
		/// <param name="m3_PK01">Primary key 1</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAlphaKPIResponse></returns>
		/// <exception cref="M3Exception<LstAlphaKPIResponse>"></exception>
		public async Task<M3Response<LstAlphaKPIResponse>> LstAlphaKPI(
			string m3_KPID, 
			string m3_PK01 = null, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAlphaKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KPID))
				throw new ArgumentNullException("m3_KPID");

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3_KPID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK01))
				request.WithQueryParameter("PK01", m3_PK01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());

			// Execute the request
			var result = await Execute<LstAlphaKPIResponse>(
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
		/// Name LstFieldAttr
		/// Description List Field Attributes
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldAttrResponse></returns>
		/// <exception cref="M3Exception<LstFieldAttrResponse>"></exception>
		public async Task<M3Response<LstFieldAttrResponse>> LstFieldAttr(
			string m3_FILE = null, 
			string m3_CUER = null, 
			string m3_FLDI = null, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFieldAttr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstFieldAttrResponse>(
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
		/// Name LstFieldVM
		/// Description List Field Value Map
		/// Version Release: 14
		/// </summary>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_CUER">Customer extension reference</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="m3_AL30">Alpha field 30 positions</param>
		/// <param name="m3_SEQN">Sequence number</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldVMResponse></returns>
		/// <exception cref="M3Exception<LstFieldVMResponse>"></exception>
		public async Task<M3Response<LstFieldVMResponse>> LstFieldVM(
			string m3_FILE = null, 
			string m3_CUER = null, 
			string m3_FLDI = null, 
			string m3_AL30 = null, 
			int? m3_SEQN = null, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFieldVM",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUER))
				request.WithQueryParameter("CUER", m3_CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AL30))
				request.WithQueryParameter("AL30", m3_AL30.Trim());
			if (m3_SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3_SEQN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

			// Execute the request
			var result = await Execute<LstFieldVMResponse>(
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
		/// Name LstFieldValue
		/// Description List record
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldValueResponse></returns>
		/// <exception cref="M3Exception<LstFieldValueResponse>"></exception>
		public async Task<M3Response<LstFieldValueResponse>> LstFieldValue(
			string m3_FILE, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());

			// Execute the request
			var result = await Execute<LstFieldValueResponse>(
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
		/// Name LstNumericKPI
		/// Description List records
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_KPID">KPI ID (Required)</param>
		/// <param name="m3_PK01">Primary key 1</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNumericKPIResponse></returns>
		/// <exception cref="M3Exception<LstNumericKPIResponse>"></exception>
		public async Task<M3Response<LstNumericKPIResponse>> LstNumericKPI(
			string m3_KPID, 
			string m3_PK01 = null, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstNumericKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KPID))
				throw new ArgumentNullException("m3_KPID");

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3_KPID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK01))
				request.WithQueryParameter("PK01", m3_PK01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());

			// Execute the request
			var result = await Execute<LstNumericKPIResponse>(
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
		/// Name MathFieldValue
		/// Description Caclulate numerical fields
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="m3_O096">Operator</param>
		/// <param name="m3_N096">Numeric field 19,6 positions</param>
		/// <param name="m3_O196">Operator</param>
		/// <param name="m3_N196">Numeric field 19,6 positions</param>
		/// <param name="m3_O296">Operator</param>
		/// <param name="m3_N296">Numeric field 19,6 positions</param>
		/// <param name="m3_O396">Operator</param>
		/// <param name="m3_N396">Numeric field 19,6 positions</param>
		/// <param name="m3_O496">Operator</param>
		/// <param name="m3_N496">Numeric field 19,6 positions</param>
		/// <param name="m3_O596">Operator</param>
		/// <param name="m3_N596">Numeric field 19,6 positions</param>
		/// <param name="m3_O696">Operator</param>
		/// <param name="m3_N696">Numeric field 19,6 positions</param>
		/// <param name="m3_O796">Operator</param>
		/// <param name="m3_N796">Numeric field 19,6 positions</param>
		/// <param name="m3_O896">Operator</param>
		/// <param name="m3_N896">Numeric field 19,6 positions</param>
		/// <param name="m3_O996">Operator</param>
		/// <param name="m3_N996">Numeric field 19,6 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MathFieldValue(
			string m3_FILE, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
			string m3_O096 = null, 
			decimal? m3_N096 = null, 
			string m3_O196 = null, 
			decimal? m3_N196 = null, 
			string m3_O296 = null, 
			decimal? m3_N296 = null, 
			string m3_O396 = null, 
			decimal? m3_N396 = null, 
			string m3_O496 = null, 
			decimal? m3_N496 = null, 
			string m3_O596 = null, 
			decimal? m3_N596 = null, 
			string m3_O696 = null, 
			decimal? m3_N696 = null, 
			string m3_O796 = null, 
			decimal? m3_N796 = null, 
			string m3_O896 = null, 
			decimal? m3_N896 = null, 
			string m3_O996 = null, 
			decimal? m3_N996 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/MathFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_O096))
				request.WithQueryParameter("O096", m3_O096.Trim());
			if (m3_N096.HasValue)
				request.WithQueryParameter("N096", m3_N096.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O196))
				request.WithQueryParameter("O196", m3_O196.Trim());
			if (m3_N196.HasValue)
				request.WithQueryParameter("N196", m3_N196.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O296))
				request.WithQueryParameter("O296", m3_O296.Trim());
			if (m3_N296.HasValue)
				request.WithQueryParameter("N296", m3_N296.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O396))
				request.WithQueryParameter("O396", m3_O396.Trim());
			if (m3_N396.HasValue)
				request.WithQueryParameter("N396", m3_N396.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O496))
				request.WithQueryParameter("O496", m3_O496.Trim());
			if (m3_N496.HasValue)
				request.WithQueryParameter("N496", m3_N496.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O596))
				request.WithQueryParameter("O596", m3_O596.Trim());
			if (m3_N596.HasValue)
				request.WithQueryParameter("N596", m3_N596.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O696))
				request.WithQueryParameter("O696", m3_O696.Trim());
			if (m3_N696.HasValue)
				request.WithQueryParameter("N696", m3_N696.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O796))
				request.WithQueryParameter("O796", m3_O796.Trim());
			if (m3_N796.HasValue)
				request.WithQueryParameter("N796", m3_N796.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O896))
				request.WithQueryParameter("O896", m3_O896.Trim());
			if (m3_N896.HasValue)
				request.WithQueryParameter("N896", m3_N896.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O996))
				request.WithQueryParameter("O996", m3_O996.Trim());
			if (m3_N996.HasValue)
				request.WithQueryParameter("N996", m3_N996.Value.ToString());

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
		/// Name MathNumericKPI
		/// Description Caclulate numerical fields
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_KPID">KPI ID (Required)</param>
		/// <param name="m3_PK01">Primary key 1 (Required)</param>
		/// <param name="m3_PK02">Primary key 2</param>
		/// <param name="m3_PK03">Primary key 3</param>
		/// <param name="m3_PK04">Primary key 4</param>
		/// <param name="m3_PK05">Primary key 5</param>
		/// <param name="m3_PK06">Primary key 6</param>
		/// <param name="m3_PK07">Primary key 7</param>
		/// <param name="m3_PK08">Primary key 8</param>
		/// <param name="m3_O096">Operator</param>
		/// <param name="m3_N096">Numeric field 19,6 positions</param>
		/// <param name="m3_O196">Operator</param>
		/// <param name="m3_N196">Numeric field 19,6 positions</param>
		/// <param name="m3_O296">Operator</param>
		/// <param name="m3_N296">Numeric field 19,6 positions</param>
		/// <param name="m3_O396">Operator</param>
		/// <param name="m3_N396">Numeric field 19,6 positions</param>
		/// <param name="m3_O496">Operator</param>
		/// <param name="m3_N496">Numeric field 19,6 positions</param>
		/// <param name="m3_O596">Operator</param>
		/// <param name="m3_N596">Numeric field 19,6 positions</param>
		/// <param name="m3_O696">Operator</param>
		/// <param name="m3_N696">Numeric field 19,6 positions</param>
		/// <param name="m3_O796">Operator</param>
		/// <param name="m3_N796">Numeric field 19,6 positions</param>
		/// <param name="m3_O896">Operator</param>
		/// <param name="m3_N896">Numeric field 19,6 positions</param>
		/// <param name="m3_O996">Operator</param>
		/// <param name="m3_N996">Numeric field 19,6 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MathNumericKPI(
			string m3_KPID, 
			string m3_PK01, 
			string m3_PK02 = null, 
			string m3_PK03 = null, 
			string m3_PK04 = null, 
			string m3_PK05 = null, 
			string m3_PK06 = null, 
			string m3_PK07 = null, 
			string m3_PK08 = null, 
			string m3_O096 = null, 
			decimal? m3_N096 = null, 
			string m3_O196 = null, 
			decimal? m3_N196 = null, 
			string m3_O296 = null, 
			decimal? m3_N296 = null, 
			string m3_O396 = null, 
			decimal? m3_N396 = null, 
			string m3_O496 = null, 
			decimal? m3_N496 = null, 
			string m3_O596 = null, 
			decimal? m3_N596 = null, 
			string m3_O696 = null, 
			decimal? m3_N696 = null, 
			string m3_O796 = null, 
			decimal? m3_N796 = null, 
			string m3_O896 = null, 
			decimal? m3_N896 = null, 
			string m3_O996 = null, 
			decimal? m3_N996 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/MathNumericKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_KPID))
				throw new ArgumentNullException("m3_KPID");
			if (string.IsNullOrWhiteSpace(m3_PK01))
				throw new ArgumentNullException("m3_PK01");

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3_KPID.Trim())
				.WithQueryParameter("PK01", m3_PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PK02))
				request.WithQueryParameter("PK02", m3_PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK03))
				request.WithQueryParameter("PK03", m3_PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK04))
				request.WithQueryParameter("PK04", m3_PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK05))
				request.WithQueryParameter("PK05", m3_PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK06))
				request.WithQueryParameter("PK06", m3_PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK07))
				request.WithQueryParameter("PK07", m3_PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PK08))
				request.WithQueryParameter("PK08", m3_PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_O096))
				request.WithQueryParameter("O096", m3_O096.Trim());
			if (m3_N096.HasValue)
				request.WithQueryParameter("N096", m3_N096.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O196))
				request.WithQueryParameter("O196", m3_O196.Trim());
			if (m3_N196.HasValue)
				request.WithQueryParameter("N196", m3_N196.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O296))
				request.WithQueryParameter("O296", m3_O296.Trim());
			if (m3_N296.HasValue)
				request.WithQueryParameter("N296", m3_N296.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O396))
				request.WithQueryParameter("O396", m3_O396.Trim());
			if (m3_N396.HasValue)
				request.WithQueryParameter("N396", m3_N396.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O496))
				request.WithQueryParameter("O496", m3_O496.Trim());
			if (m3_N496.HasValue)
				request.WithQueryParameter("N496", m3_N496.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O596))
				request.WithQueryParameter("O596", m3_O596.Trim());
			if (m3_N596.HasValue)
				request.WithQueryParameter("N596", m3_N596.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O696))
				request.WithQueryParameter("O696", m3_O696.Trim());
			if (m3_N696.HasValue)
				request.WithQueryParameter("N696", m3_N696.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O796))
				request.WithQueryParameter("O796", m3_O796.Trim());
			if (m3_N796.HasValue)
				request.WithQueryParameter("N796", m3_N796.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O896))
				request.WithQueryParameter("O896", m3_O896.Trim());
			if (m3_N896.HasValue)
				request.WithQueryParameter("N896", m3_N896.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_O996))
				request.WithQueryParameter("O996", m3_O996.Trim());
			if (m3_N996.HasValue)
				request.WithQueryParameter("N996", m3_N996.Value.ToString());

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
